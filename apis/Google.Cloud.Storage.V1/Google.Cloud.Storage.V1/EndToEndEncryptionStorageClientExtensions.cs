// Copyright 2019 Google Inc. All Rights Reserved.
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
using Google.Apis.Download;
using Google.Apis.Upload;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Cloud.Storage.V1
{
    /// <summary>
    /// Extension methods on <see cref="StorageClient"/> that allow end to end encryption.
    /// </summary>
    public static class EndToEndEncryptionStorageClientExtensions
    {
        /// <summary>
        /// Transforms the data from the specified stream using the given cryto transform
        /// and uploads the result as the data for an object, synchronously.
        /// </summary>
        /// <param name="client">The Storage client to perform the operation with.</param>
        /// <param name="bucket">The name of the bucket containing the object. Must not be null.</param>
        /// <param name="objectName">The name of the object within the bucket. Must not be null.</param>
        /// <param name="contentType">The content type of the object. This should be a MIME type
        /// such as "text/html" or "application/octet-stream". May be null.</param>
        /// <param name="source">The stream to read the data from. Must not be null.</param>
        /// <param name="transform">The cryptographic transformation to apply to <paramref name="source"/>
        /// before uploading. Must not be null.</param>
        /// <param name="options">Additional options for the upload. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <param name="progress">Progress reporter for the upload. May be null.</param>
        /// <returns>The <see cref="Object"/> representation of the uploaded object.</returns>
        public static Object CryptoTransformAndUploadObject(
            this StorageClient client,
            string bucket,
            string objectName,
            string contentType,
            Stream source,
            ICryptoTransform transform,
            UploadObjectOptions options = null,
            IProgress<IUploadProgress> progress = null)
        {
            using (CryptoStream transformed = BuildReaderCryptoStream(source, transform))
            {
                return client.UploadObject(bucket, objectName, contentType, transformed, options, progress);
            }
        }

        /// <summary>
        /// Transforms the data from the specified stream using the given cryto transform
        /// and uploads the result as the data for object, synchronously.
        /// </summary>
        /// <param name="client">The Storage client to perform the operation with.</param>
        /// <param name="destination">Object to create or update. Must not be null, and must have the name,
        /// bucket and content type populated.</param>
        /// <param name="source">The stream to read the data from. Must not be null.</param>
        /// <param name="transform">The cryptographic transformation to apply to <paramref name="source"/>
        /// before uploading. Must not be null.</param>
        /// <param name="options">Additional options for the upload. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <param name="progress">Progress reporter for the upload. May be null.</param>
        /// <returns>The <see cref="Object"/> representation of the uploaded object.</returns>
        public static Object CryptoTransformAndUploadObject(
            this StorageClient client,
            Object destination,
            Stream source,
            ICryptoTransform transform,
            UploadObjectOptions options = null,
            IProgress<IUploadProgress> progress = null)
        {
            using (CryptoStream transformed = BuildReaderCryptoStream(source, transform))
            {
                return client.UploadObject(destination, transformed, options, progress);
            }
        }

        /// <summary>
        /// Transforms the data from the specified stream using the given cryto transform
        /// and uploads the result as the data for an object, asynchronously.
        /// </summary>
        /// <param name="client">The Storage client to perform the operation with.</param>
        /// <param name="bucket">The name of the bucket containing the object. Must not be null.</param>
        /// <param name="objectName">The name of the object within the bucket. Must not be null.</param>
        /// <param name="contentType">The content type of the object. This should be a MIME type
        /// such as "text/html" or "application/octet-stream". May be null.</param>
        /// <param name="source">The stream to read the data from. Must not be null.</param>
        /// <param name="transform">The cryptographic transformation to apply to <paramref name="source"/>
        /// before uploading. Must not be null.</param>
        /// <param name="options">Additional options for the upload. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <param name="progress">Progress reporter for the upload. May be null.</param>
        /// <returns>A task representing the asynchronous operation, with a result returning the
        /// <see cref="Object"/> representation of the uploaded object.</returns>
        public static async Task<Object> CryptoTransformAndUploadObjectAsync(
            this StorageClient client,
            string bucket,
            string objectName,
            string contentType,
            Stream source,
            ICryptoTransform transform,
            UploadObjectOptions options = null,
            CancellationToken cancellationToken = default,
            IProgress<IUploadProgress> progress = null)
        {
            using (CryptoStream transformed = BuildReaderCryptoStream(source, transform))
            {
                return await client.UploadObjectAsync(bucket, objectName, contentType, transformed, options, cancellationToken, progress).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Transforms the data from the specified stream using the given cryto transform
        /// and uploads the result as the data for object, asynchronously.
        /// </summary>
        /// <param name="client">The Storage client to perform the operation with.</param>
        /// <param name="destination">Object to create or update. Must not be null, and must have the name,
        /// bucket and content type populated.</param>
        /// <param name="source">The stream to read the data from. Must not be null.</param>
        /// <param name="transform">The cryptographic transformation to apply to <paramref name="source"/>
        /// before uploading. Must not be null.</param>
        /// <param name="options">Additional options for the upload. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <param name="progress">Progress reporter for the upload. May be null.</param>
        /// <returns>The <see cref="Object"/> representation of the uploaded object.</returns>
        public static async Task<Object> CryptoTransformAndUploadObjectAsync(
            this StorageClient client,
            Object destination,
            Stream source,
            ICryptoTransform transform,
            UploadObjectOptions options = null,
            CancellationToken cancellationToken = default,
            IProgress<IUploadProgress> progress = null)
        {
            using (CryptoStream transformed = BuildReaderCryptoStream(source, transform))
            {
                return await client.UploadObjectAsync(destination, transformed, options, cancellationToken, progress).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Downloads the data for an object from storage synchronously, and transforms it using the
        /// specified crypto transform into a specified stream.
        /// </summary>
        /// <param name="client">The Storage client to perform the operation with.</param>
        /// <param name="bucket">The name of the bucket containing the object. Must not be null.</param>
        /// <param name="objectName">The name of the object within the bucket. Must not be null.</param>
        /// <param name="destination">The stream to write the data into. Must not be null.</param>
        /// <param name="transform">The cryptographic transformation to apply to <paramref name="destination"/>
        /// after downloading. Must not be null.</param>
        /// <param name="options">Additional options for the download. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <param name="progress">Progress reporter for the download. May be null.</param>
        public static void DownloadObjectAndCryptoTransform(
            this StorageClient client,
            string bucket,
            string objectName,
            Stream destination,
            ICryptoTransform transform,
            DownloadObjectOptions options = null,
            IProgress<IDownloadProgress> progress = null)
        {
            using (CryptoStream transformed = BuildWriterCryptoStream(destination, transform))
            {
                client.DownloadObject(bucket, objectName, transformed, options, progress);
                transformed.FlushFinalBlock();
            }
        }

        /// <summary>
        /// Downloads the data for an object from storage synchronously, and transforms it using the
        /// specified crypto transform into a specified stream.
        /// </summary>
        /// <remarks>The generation number within <paramref name="source"/> is ignored by this method.
        /// To download a specific generation, use <see cref="DownloadObjectOptions.Generation"/>.
        /// </remarks>
        /// <param name="client">The Storage client to perform the operation with.</param>
        /// <param name="source">Source object to download the data from. Must not be null.</param>
        /// <param name="destination">The stream to write the data into. Must not be null.</param>
        /// <param name="transform">The cryptographic transformation to apply to <paramref name="destination"/>
        /// after downloading. Must not be null.</param>
        /// <param name="options">Additional options for the download. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <param name="progress">Progress reporter for the download. May be null.</param>
        public static void DownloadObjectAndCryptoTransform(
            this StorageClient client,
            Object source,
            Stream destination,
            ICryptoTransform transform,
            DownloadObjectOptions options = null,
            IProgress<IDownloadProgress> progress = null)
        {
            using (CryptoStream transformed = BuildWriterCryptoStream(destination, transform))
            {
                client.DownloadObject(source, transformed, options, progress);
                transformed.FlushFinalBlock();
            }
        }

        /// <summary>
        /// Downloads the data for an object from storage asynchronously, and transforms it using the
        /// specified crypto transform into a specified stream.
        /// </summary>
        /// <param name="client">The Storage client to perform the operation with.</param>
        /// <param name="bucket">The name of the bucket containing the object. Must not be null.</param>
        /// <param name="objectName">The name of the object within the bucket. Must not be null.</param>
        /// <param name="destination">The stream to write the data into. Must not be null.</param>
        /// <param name="transform">The cryptographic transformation to apply to <paramref name="destination"/>
        /// after downloading. Must not be null.</param>
        /// <param name="options">Additional options for the download. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <param name="progress">Progress reporter for the download. May be null.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public static async Task DownloadObjectAndCryptoTransformAsync(
            this StorageClient client,
            string bucket,
            string objectName,
            Stream destination,
            ICryptoTransform transform,
            DownloadObjectOptions options = null,
            CancellationToken cancellationToken = default,
            IProgress<IDownloadProgress> progress = null)
        {
            using (CryptoStream transformed = BuildWriterCryptoStream(destination, transform))
            {
                await client.DownloadObjectAsync(bucket, objectName, transformed, options, cancellationToken, progress).ConfigureAwait(false);
                transformed.FlushFinalBlock();
            }
        }

        /// <summary>
        /// Downloads the data for an object from storage asynchronously, and transforms it using the
        /// specified crypto transform into a specified stream.
        /// </summary>
        /// <remarks>The generation number within <paramref name="source"/> is ignored by this method.
        /// To download a specific generation, use <see cref="DownloadObjectOptions.Generation"/>.
        /// </remarks>
        /// <param name="client">The Storage client to perform the operation with.</param>
        /// <param name="source">Source object to download the data from. Must not be null.</param>
        /// <param name="destination">The stream to write the data into. Must not be null.</param>
        /// <param name="transform">The cryptographic transformation to apply to <paramref name="destination"/>
        /// after downloading. Must not be null.</param>
        /// <param name="options">Additional options for the download. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <param name="progress">Progress reporter for the download. May be null.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public static async Task DownloadObjectAndCryptoTransformAsync(
            this StorageClient client,
            Object source,
            Stream destination,
            ICryptoTransform transform,
            DownloadObjectOptions options = null,
            CancellationToken cancellationToken = default,
            IProgress<IDownloadProgress> progress = null)
        {
            using (CryptoStream transformed = BuildWriterCryptoStream(destination, transform))
            {
                await client.DownloadObjectAsync(source, transformed, options, cancellationToken, progress).ConfigureAwait(false);
                transformed.FlushFinalBlock();
            }
        }

        private static CryptoStream BuildReaderCryptoStream(Stream source, ICryptoTransform transform) =>
            BuildCryptoStream(source, transform, CryptoStreamMode.Read);

        private static CryptoStream BuildWriterCryptoStream(Stream destination, ICryptoTransform transform) =>
            BuildCryptoStream(destination, transform, CryptoStreamMode.Write);

        private static CryptoStream BuildCryptoStream(Stream target, ICryptoTransform transform, CryptoStreamMode mode)
        {
            GaxPreconditions.CheckNotNull(transform, nameof(transform));
            GaxPreconditions.CheckNotNull(target, nameof(target));

            var undisposableSource = new StaysOpenStreamWrapper(target);
            return new CryptoStream(undisposableSource, transform, mode);
        }

        private sealed class StaysOpenStreamWrapper : Stream
        {
            private readonly Stream _wrapped;
            public StaysOpenStreamWrapper(Stream wrapped) => _wrapped = wrapped;
            public override bool CanRead => _wrapped.CanRead;

            public override bool CanSeek => _wrapped.CanSeek;

            public override bool CanWrite => _wrapped.CanWrite;

            public override long Length => _wrapped.Length;

            public override bool CanTimeout => _wrapped.CanTimeout;

            public override int ReadTimeout
            {
                get => _wrapped.ReadTimeout;
                set => _wrapped.ReadTimeout = value;
            }

            public override int WriteTimeout
            {
                get => _wrapped.WriteTimeout;
                set => _wrapped.WriteTimeout = value;
            }

            public override long Position
            {
                get => _wrapped.Position;
                set => _wrapped.Position = value;
            }

            public override long Seek(long offset, SeekOrigin origin) =>
                _wrapped.Seek(offset, origin);

            public override void SetLength(long value) => _wrapped.SetLength(value);

            public override int ReadByte() => _wrapped.ReadByte();

            public override int Read(byte[] buffer, int offset, int count) =>
                _wrapped.Read(buffer, offset, count);

            public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) =>
                _wrapped.ReadAsync(buffer, offset, count, cancellationToken);

            public override void WriteByte(byte value) => _wrapped.WriteByte(value);

            public override void Write(byte[] buffer, int offset, int count) =>
                _wrapped.Write(buffer, offset, count);

            public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) =>
                _wrapped.WriteAsync(buffer, offset, count, cancellationToken);

            public override void Flush() => _wrapped.Flush();

            public override Task FlushAsync(CancellationToken cancellationToken) =>
                _wrapped.FlushAsync(cancellationToken);

            public override Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken) =>
                _wrapped.CopyToAsync(destination, bufferSize, cancellationToken);

            public override bool Equals(object obj) => _wrapped.Equals(obj);

            public override int GetHashCode() => _wrapped.GetHashCode();

            public override string ToString() => _wrapped.ToString();

            protected override void Dispose(bool disposing)
            {
                // noop (precisely what we want to achieve)
            }
        }
    }
}
