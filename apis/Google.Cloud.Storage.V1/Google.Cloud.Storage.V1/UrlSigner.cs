// Copyright 2015 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Apis.Auth.OAuth2;
using System;
using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Storage.V1
{
    /// <summary>
    /// Class which helps create signed URLs which can be used to provide limited access to specific buckets and objects
    /// to anyone in possession of the URL, regardless of whether they have a Google account.
    /// </summary>
    /// <remarks>
    /// See https://cloud.google.com/storage/docs/access-control/signed-urls for more information on signed URLs.
    /// </remarks>
    public sealed partial class UrlSigner
    {
        private static readonly ISigner s_v2Signer = new V2Signer();
        private static readonly ISigner s_v4Signer = new V4Signer();

        private const string GoogHeaderPrefix = "x-goog-";
        private const string StorageHost = "https://storage.googleapis.com";

        /// <summary>
        /// Gets a special HTTP method which can be used to create a signed URL for initiating a resumable upload.
        /// See https://cloud.google.com/storage/docs/access-control/signed-urls#signing-resumable for more information.
        /// </summary>
        /// <remarks>
        /// Note: When using the RESUMABLE method to create a signed URL, a URL will actually be signed for the POST method with a header of
        /// 'x-goog-resumable:start'. The caller must perform a POST request with this URL and specify the 'x-goog-resumable:start' header as
        /// well or signature validation will fail.
        /// </remarks>
        public static HttpMethod ResumableHttpMethod { get; } = new HttpMethod("RESUMABLE");

        private static readonly DateTimeOffset UnixEpoch = new DateTimeOffset(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc), TimeSpan.Zero);

        private readonly IBlobSigner _blobSigner;
        private readonly SigningVersion _signingVersion;
        private readonly IClock _clock;

        private UrlSigner(IBlobSigner blobSigner, SigningVersion signingVersion, IClock clock)
        {
            _blobSigner = blobSigner;
            _signingVersion = signingVersion;
            _clock = clock;
        }

        /// <summary>
        /// Creates a new <see cref="UrlSigner"/> instance for a service account.
        /// </summary>
        /// <param name="credentialFilePath">The path to the JSON key file for a service account. Must not be null.</param>
        /// <exception cref="InvalidOperationException">
        /// The <paramref name="credentialFilePath"/> does not refer to a valid JSON service account key file.
        /// </exception>
        public static UrlSigner FromServiceAccountPath(string credentialFilePath)
        {
            GaxPreconditions.CheckNotNull(credentialFilePath, nameof(credentialFilePath));
            using (var credentialData = File.OpenRead(credentialFilePath))
            {
                return FromServiceAccountData(credentialData);
            }
        }

        /// <summary>
        /// Creates a new <see cref="UrlSigner"/> instance for a service account.
        /// </summary>
        /// <param name="credentialData">The stream from which to read the JSON key data for a service account. Must not be null.</param>
        /// <exception cref="InvalidOperationException">
        /// The <paramref name="credentialData"/> does not contain valid JSON service account key data.
        /// </exception>
        public static UrlSigner FromServiceAccountData(Stream credentialData)
        {
            GaxPreconditions.CheckNotNull(credentialData, nameof(credentialData));
            return UrlSigner.FromServiceAccountCredential(ServiceAccountCredential.FromServiceAccountData(credentialData));
        }

        /// <summary>
        /// Creates a new <see cref="UrlSigner"/> instance for a service account.
        /// </summary>
        /// <param name="credential">The credential for the a service account. Must not be null.</param>
        public static UrlSigner FromServiceAccountCredential(ServiceAccountCredential credential)
        {
            GaxPreconditions.CheckNotNull(credential, nameof(credential));
            return new UrlSigner(new ServiceAccountCredentialBlobSigner(credential), SigningVersion.Default, SystemClock.Instance);
        }

        /// <summary>
        /// Creates a new <see cref="UrlSigner"/> instance for a custom blob signer.
        /// </summary>
        /// <remarks>
        /// This method is typically used when a service account credential file isn't available, either
        /// for testing or to use the IAM service's blob signing capabilities.
        /// </remarks>
        /// <param name="signer">The blob signer to use. Must not be null.</param>
        /// <returns>A new <see cref="UrlSigner"/> using the specified blob signer.</returns>
        public static UrlSigner FromBlobSigner(IBlobSigner signer)
        {
            GaxPreconditions.CheckNotNull(signer, nameof(signer));
            return new UrlSigner(signer, SigningVersion.Default, SystemClock.Instance);
        }

        /// <summary>
        /// Returns a new instance of <see cref="UrlSigner"/> using the same signing source (e.g. a service account
        /// private key) but with the specified URL signing algorithm version.
        /// </summary>
        /// <param name="signingVersion">The algorithm version to use when signing URLs.</param>
        /// <returns>A new instance using the specified version.</returns>
        public UrlSigner WithSigningVersion(SigningVersion signingVersion)
        {
            GaxPreconditions.CheckEnumValue(signingVersion, nameof(signingVersion));
            return new UrlSigner(_blobSigner, signingVersion, _clock);
        }

        /// <summary>
        /// Only available for testing purposes, this allows the clock used for signature generation to be replaced.
        /// </summary>
        internal UrlSigner WithClock(IClock clock) => new UrlSigner(_blobSigner, _signingVersion, clock);

        /// <summary>
        /// Creates a signed URL which can be used to provide limited access to specific buckets and objects to anyone
        /// in possession of the URL, regardless of whether they have a Google account.
        /// </summary>
        /// <remarks>
        /// <para>
        /// When a <see cref="UrlSigner"/> is created with a service account credential, the signing can be performed
        /// with no network access. When it is created with an implementation of <see cref="IBlobSigner"/>, that may require
        /// network access or other IO. In that case, one of the asynchronous methods should be used when the caller is
        /// in a context that should not block.
        /// </para>
        /// <para>
        /// See https://cloud.google.com/storage/docs/access-control/signed-urls for more information on signed URLs.
        /// </para>
        /// </remarks>
        /// <param name="requestTemplate">The request template that will be used to generate the signed URL for. Must not be null.</param>
        /// <param name="options">The options used to generate the signed URL. Must not be null.</param>
        /// <returns>
        /// The signed URL which can be used to provide access to a bucket or object for a limited amount of time.
        /// </returns>
        public string Sign(RequestTemplate requestTemplate, Options options) =>
            GetEffectiveSigner().Sign(
                GaxPreconditions.CheckNotNull(requestTemplate, nameof(requestTemplate)),
                GaxPreconditions.CheckNotNull(options, nameof(options)),
                _blobSigner,
                _clock);

        /// <summary>
        /// Asynchronously creates a signed URL which can be used to provide limited access to specific buckets and objects to anyone
        /// in possession of the URL, regardless of whether they have a Google account.
        /// </summary>
        /// <remarks>
        /// <para>
        /// When a <see cref="UrlSigner"/> is created with a service account credential, the signing can be performed
        /// with no network access. When it is created with an implementation of <see cref="IBlobSigner"/>, that may require
        /// network access or other IO. In that case, one of the asynchronous methods should be used when the caller is
        /// in a context that should not block.
        /// </para>
        /// <para>
        /// See https://cloud.google.com/storage/docs/access-control/signed-urls for more information on signed URLs.
        /// </para>
        /// </remarks>
        /// <param name="requestTemplate">The request template that will be used to generate the signed URL for. Must not be null.</param>
        /// <param name="options">The options used to generate the signed URL. Must not be null.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>
        /// A task representing the asynchronous operation, with a result returning the
        /// signed URL which can be used to provide access to a bucket or object for a limited amount of time.
        /// </returns>
        public Task<string> SignAsync(RequestTemplate requestTemplate, Options options, CancellationToken cancellationToken = default) =>
            GetEffectiveSigner().SignAsync(
                GaxPreconditions.CheckNotNull(requestTemplate, nameof(requestTemplate)),
                GaxPreconditions.CheckNotNull(options, nameof(options)),
                _blobSigner,
                _clock,
                cancellationToken);

        private ISigner GetEffectiveSigner()
        {
            switch (_signingVersion)
            {
                case SigningVersion.Default:
                    return s_v2Signer;
                case SigningVersion.V2:
                    return s_v2Signer;
                case SigningVersion.V4:
                    return s_v4Signer;
                default:
                    // We really shouldn't get here, as we validate any user-specified signing version.
                    throw new InvalidOperationException($"Invalid signing version: {_signingVersion}");
            }
        }

        private static readonly Regex s_newlineRegex = new Regex(@"\r?\n", RegexOptions.Compiled);
        private static readonly Regex s_tabRegex = new Regex(@"\t+", RegexOptions.Compiled);
        private static readonly Regex s_whitespaceRegex = new Regex(@"\s+", RegexOptions.Compiled);

        /// <summary>
        /// Prepares a header value for signing, trimming both ends and collapsing internal whitespace.
        /// </summary>
        internal static string PrepareHeaderValue(string value, bool collapseTabs)
        {
            // Remove leading/trailing whitespace
            value = value.Trim();

            if (collapseTabs)
            {
                // Replaces all consecutive tabs by a space.
                // If consecutive spaces result out of this, then the next line will
                // collapse all the spaces.
                value = s_tabRegex.Replace(value, " ");
            }

            // Collapse whitespace runs: only keep the last character
            value = s_whitespaceRegex.Replace(value, match => match.Value[match.Value.Length - 1].ToString());

            // Remove newlines
            value = s_newlineRegex.Replace(value, "");

            return value;
        }

    }
}
