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
using Google.Apis.Download;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Cloud.Storage.V1
{
    public sealed partial class StorageClientImpl : StorageClient
    {
        /// <inheritdoc />
        public override void DownloadObject(
            string bucket,
            string objectName,
            Stream destination,
            DownloadObjectOptions options = null,
            IProgress<IDownloadProgress> progress = null)
        {
            var baseUri = GetBaseUri(bucket, objectName);
            DownloadObjectImpl(baseUri, destination, options, progress);
        }

        /// <inheritdoc />
        public override Task DownloadObjectAsync(
            string bucket,
            string objectName,
            Stream destination,
            DownloadObjectOptions options = null,
            CancellationToken cancellationToken = default(CancellationToken),
            IProgress<IDownloadProgress> progress = null)
        {
            var baseUri = GetBaseUri(bucket, objectName);
            return DownloadObjectAsyncImpl(baseUri, destination, options, cancellationToken, progress);
        }

        /// <inheritdoc />
        public override void DownloadObject(
            Object source,
            Stream destination,
            DownloadObjectOptions options = null,
            IProgress<IDownloadProgress> progress = null)
        {
            var baseUri = GetBaseUri(source);
            DownloadObjectImpl(baseUri, destination, options, progress);
        }

        /// <inheritdoc />
        public override Task DownloadObjectAsync(
            Object source,
            Stream destination,
            DownloadObjectOptions options = null,
            CancellationToken cancellationToken = default(CancellationToken),
            IProgress<IDownloadProgress> progress = null)
        {
            var baseUri = GetBaseUri(source);
            return DownloadObjectAsyncImpl(baseUri, destination, options, cancellationToken, progress);
        }

        /// <summary>
        /// Constructs the media URL of an object from its bucket and name. This does not include the generation
        /// or any GaxPreconditions. The returned string will always have a query parameter, so later query parameters
        /// can unconditionally be appended with an "&amp;" prefix.
        /// </summary>
        private static string GetBaseUri(string bucket, string objectName)
        {
            ValidateBucketName(bucket);
            GaxPreconditions.CheckNotNull(objectName, nameof(objectName));
            return $"https://www.googleapis.com/download/storage/v1/b/{bucket}/o/{Uri.EscapeDataString(objectName)}?alt=media";
        }

        /// <summary>
        /// Obtains the media URL of an object from its bucket and name.
        /// The returned string will always have a query parameter, so later query parameters
        /// can unconditionally be appended with an "&amp;" prefix.
        /// </summary>
        private string GetBaseUri(Object source)
        {
            ValidateObject(source, nameof(source));
            return GetBaseUri(source.Bucket, source.Name);
        }

        private void DownloadObjectImpl(
            string baseUri,
            Stream destination,
            DownloadObjectOptions options,
            IProgress<IDownloadProgress> progress)
        {
            // URI will definitely not be null; that's constructed internally.
            GaxPreconditions.CheckNotNull(destination, nameof(destination));
            var downloader = CreateDownloader(options);
            string uri = options == null ? baseUri : options.GetUri(baseUri);
            if (progress != null)
            {
                downloader.ProgressChanged += progress.Report;
                progress.Report(InitialDownloadProgress.Instance);
            }
            var result = downloader.Download(uri, destination);
            if (result.Status == DownloadStatus.Failed)
            {
                throw result.Exception;
            }
        }

        private Task DownloadObjectAsyncImpl(
            string baseUri,
            Stream destination,
            DownloadObjectOptions options,
            CancellationToken cancellationToken,
            IProgress<IDownloadProgress> progress) =>
            // Use Task.Run to prevent reporting progress synchronously in the original call.
            // We used to await Task.Yield(), but that doesn't actually achieve what we want.
            Task.Run(async () =>
            {
                GaxPreconditions.CheckNotNull(destination, nameof(destination));
                var downloader = CreateDownloader(options);
                string uri = options == null ? baseUri : options.GetUri(baseUri);
                if (progress != null)
                {
                    downloader.ProgressChanged += progress.Report;
                    progress.Report(InitialDownloadProgress.Instance);
                }
                var result = await downloader.DownloadAsync(uri, destination, cancellationToken).ConfigureAwait(false);
                if (result.Status == DownloadStatus.Failed)
                {
                    throw result.Exception;
                }
            });

        private HashValidatingDownloader CreateDownloader(DownloadObjectOptions options)
        {
            var downloader = new HashValidatingDownloader(Service);
            downloader.ModifyRequest += _versionHeaderAction;
            options?.ModifyDownloader(downloader);
            ApplyEncryptionKey(options?.EncryptionKey, downloader);
            return downloader;
        }

        // MediaDownloader doesn't report progress until the first chunk has been fetched. It can be useful to
        // report a status of "not started" immediately. This implementation of IDownloadProgress does that.
        private sealed class InitialDownloadProgress : IDownloadProgress
        {
            internal static readonly IDownloadProgress Instance = new InitialDownloadProgress();

            public long BytesDownloaded => 0;
            public Exception Exception => null;
            public DownloadStatus Status => DownloadStatus.NotStarted;
        }
    }
}
