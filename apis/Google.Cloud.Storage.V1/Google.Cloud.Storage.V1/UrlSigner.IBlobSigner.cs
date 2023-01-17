// Copyright 2018 Google LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     https://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Storage.V1
{
    public sealed partial class UrlSigner
    {
        /// <summary>
        /// Represents the capability of signing a blob in a suitable form for Google Cloud Storage signed URLs.
        /// This allows testing URL signing without credentials being available, as well as using Google Cloud IAM
        /// to sign blobs.
        /// </summary>
        public interface IBlobSigner
        {
            /// <summary>
            /// Synchronously signs the given blob.
            /// </summary>
            /// <param name="data">The data to sign. Must not be null.</param>
            /// <param name="parameters">Parameters to use when deriving the signing key.
            /// Concrete implementations may allow a null value if no parameters are required.</param>
            /// <returns>The blob signature as base64 text.</returns>
            string CreateSignature(byte[] data, BlobSignerParameters parameters);

            /// <summary>
            /// Asynchronously signs the given blob.
            /// </summary>
            /// <param name="data">The data to sign. Must not be null.</param>
            /// <param name="parameters">Parameters to use when deriving the signing key.
            /// Concrete implementations may allow a null value if no parameters are required.</param>
            /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
            /// <returns>A task representing the asynchronous operation, with a result returning the
            /// blob signature as base64 text.
            /// </returns>
            Task<string> CreateSignatureAsync(byte[] data, BlobSignerParameters parameters, CancellationToken cancellationToken);

            /// <summary>
            /// The identity of the signer, typically an email address.
            /// </summary>
            string Id { get; }

            /// <summary>
            /// The signing algorithm used by this blob signer.
            /// </summary>
            string Algorithm { get; }
        }

        /// <summary>
        /// Parameters that may be used by an IBlobSigner for deriving
        /// a signing key.
        /// Signers may ignore some or all of these parameters depending on
        /// how the derive the signing key.
        /// </summary>
        public sealed class BlobSignerParameters
        {
            private const string DefaultRegion = "auto";
            private const string DefaultService = "storage";
            private const string DefaultRequestType = "goog4_request";

            private BlobSignerParameters(DateTimeOffset requestDateTime) => SignatureTimestamp = requestDateTime;

            /// <summary>
            /// Region to be used for deriving the signing key.
            /// </summary>
            public string Region { get; } = DefaultRegion;

            /// <summary>
            /// Service to be used for deriving the signing key.
            /// </summary>
            public string Service { get; } = DefaultService;

            /// <summary>
            /// Request type to be used for deriving the signing key.
            /// </summary>
            public string RequestType { get; } = DefaultRequestType;

            /// <summary>
            /// The request date time to be used for deriving the signing key.
            /// </summary>
            public DateTimeOffset SignatureTimestamp { get; }

            /// <summary>
            /// Create a new instance of <see cref="BlobSignerParameters"/> for the given <see cref="DateTimeOffset"/>.
            /// </summary>
            public static BlobSignerParameters ForTimestamp(DateTimeOffset requestDateTime) => new BlobSignerParameters(requestDateTime);

            internal static BlobSignerParameters ForCurrentTimestamp(IClock clock) => ForTimestamp(new DateTimeOffset(clock.GetCurrentDateTimeUtc()));
        }

        /// <summary>
        /// Class to allow UrlSigner to be independent of whether the IBlobSigner
        /// is obtained synchronously or asynchronously.
        /// </summary>
        private sealed class BlobSignerProvider
        {
            /// <summary>
            /// This is the blob signer that was used for building this instance
            /// via <see cref="BlobSignerProvider(IBlobSigner)"/>, if indeed this
            /// constructor was used. Null otherwise.
            /// </summary>
            private readonly IBlobSigner _blobSigner;

            /// <summary>
            /// The cached blob signer building task if this instance was built via
            /// <see cref="BlobSignerProvider(Func{Task{IBlobSigner}})"/>. Null otherwise.
            /// </summary>
            /// <remarks>
            /// Once this cached task completes and a blog signer is built,
            /// obtaining the blob signer is a sync operation. Basically, accessing the cached blob signer is async
            /// only for the first few threads that attempt it, before the blob signer has been built.
            /// </remarks>
            private readonly Lazy<Task<IBlobSigner>> _cachedBlobSignerTask;

            internal BlobSignerProvider(IBlobSigner blobSigner) =>
                _blobSigner = GaxPreconditions.CheckNotNull(blobSigner, nameof(blobSigner));

            internal BlobSignerProvider(Func<Task<IBlobSigner>> blobSignerAsyncProvider)
            {
                GaxPreconditions.CheckNotNull(blobSignerAsyncProvider,nameof(blobSignerAsyncProvider));
                _cachedBlobSignerTask = new Lazy<Task<IBlobSigner>>(SafeBlobSignerProvider, LazyThreadSafetyMode.ExecutionAndPublication);

                async Task<IBlobSigner> SafeBlobSignerProvider()
                {
                    var blobSigner = await blobSignerAsyncProvider().ConfigureAwait(false);
                    if (blobSigner is null)
                    {
                        throw new InvalidOperationException("The given IBlobSigner factory returned a null blob signer.");
                    }
                    return blobSigner;
                }
            }

            internal IBlobSigner GetBlobSigner() => _cachedBlobSignerTask switch
            {
                null => _blobSigner,
                { Value.IsCompleted: true } => _cachedBlobSignerTask.Value.ResultWithUnwrappedExceptions(),
                _ => Task.Run(() => _cachedBlobSignerTask.Value).ResultWithUnwrappedExceptions()
            };

            internal Task<IBlobSigner> GetBlobSignerAsync(CancellationToken cancellationToken = default) => _cachedBlobSignerTask switch
            {
                null => Task.FromResult(_blobSigner),
                { Value.IsCompleted : true } => _cachedBlobSignerTask.Value,
                // When the task hasn't completed, we use Task.Run to take the cancellation token into account.
                _ => Task.Run(() => _cachedBlobSignerTask.Value, cancellationToken)
            };
        }
    }
}
