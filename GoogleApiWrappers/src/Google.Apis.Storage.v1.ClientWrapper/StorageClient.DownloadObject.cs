// Copyright 2015 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.

using Google.Apis.Download;
using Google.Common;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Apis.Storage.v1.ClientWrapper
{
    public partial class StorageClient
    {
        /// <summary>
        /// Downloads the data for an object from storage synchronously, into a specified stream.
        /// </summary>
        /// <param name="bucket">The name of the bucket containing the object. Must not be null.</param>
        /// <param name="objectName">The name of the object within the bucket. Must not be null.</param>
        /// <param name="destination">The stream to write the data into. Must not be null.</param>
        public void DownloadObject(string bucket, string objectName, Stream destination)
        {
            DownloadObject(bucket, objectName, destination, options: null, progress: null);
        }

        /// <summary>
        /// Downloads the data for an object from storage synchronously, into a specified stream.
        /// </summary>
        /// <param name="bucket">The name of the bucket containing the object. Must not be null.</param>
        /// <param name="objectName">The name of the object within the bucket. Must not be null.</param>
        /// <param name="destination">The stream to write the data into. Must not be null.</param>
        /// <param name="options">Additional options for the download. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <param name="progress">Progress reporter for the download. May be null.</param>
        public void DownloadObject(
            string bucket,
            string objectName,
            Stream destination,
            DownloadObjectOptions options,
            IProgress<IDownloadProgress> progress)
        {
            string uri = GetUri(bucket, objectName);
            DownloadObjectImpl(uri, destination, options, progress);
        }

        /// <summary>
        /// Downloads the data for an object from storage asynchronously, into a specified stream.
        /// </summary>
        /// <param name="bucket">The name of the bucket containing the object. Must not be null.</param>
        /// <param name="objectName">The name of the object within the bucket. Must not be null.</param>
        /// <param name="destination">The stream to write the data into. Must not be null.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public Task DownloadObjectAsync(string bucket, string objectName, Stream destination)
        {
            return DownloadObjectAsync(bucket, objectName, destination,
                options: null, cancellationToken: CancellationToken.None, progress: null);
        }

        /// <summary>
        /// Downloads the data for an object from storage asynchronously, into a specified stream.
        /// </summary>
        /// <param name="bucket">The name of the bucket containing the object. Must not be null.</param>
        /// <param name="objectName">The name of the object within the bucket. Must not be null.</param>
        /// <param name="destination">The stream to write the data into. Must not be null.</param>
        /// <param name="options">Additional options for the download. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <param name="progress">Progress reporter for the download. May be null.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public Task DownloadObjectAsync(
            string bucket,
            string objectName,
            Stream destination,
            DownloadObjectOptions options,
            CancellationToken cancellationToken,
            IProgress<IDownloadProgress> progress)
        {
            string uri = GetUri(bucket, objectName);
            return DownloadObjectAsyncImpl(uri, destination, options, cancellationToken, progress);
        }

        /// <summary>
        /// Downloads the data for an object from storage asynchronously, into a specified stream.
        /// </summary>
        /// <param name="source">Source object to download the data from. Must not be null.</param>
        /// <param name="destination">The stream to write the data into. Must not be null.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public Task DownloadObjectAsync(Object source, Stream destination)
        {
            return DownloadObjectAsync(source, destination,
                options: null, cancellationToken: CancellationToken.None, progress: null);
        }

        /// <summary>
        /// Downloads the data for an object from storage synchronously, into a specified stream.
        /// </summary>
        /// <param name="source">Source object to download the data from. Must not be null.</param>
        /// <param name="destination">The stream to write the data into. Must not be null.</param>
        public void DownloadObject(Object source, Stream destination)
        {
            DownloadObject(source, destination, options: null, progress: null);
        }

        /// <summary>
        /// Downloads the data for an object from storage synchronously, into a specified stream.
        /// </summary>
        /// <param name="source">Source object to download the data from. Must not be null.</param>
        /// <param name="destination">The stream to write the data into. Must not be null.</param>
        /// <param name="options">Additional options for the download. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <param name="progress">Progress reporter for the download. May be null.</param>
        public void DownloadObject(
            Object source,
            Stream destination,
            DownloadObjectOptions options,
            IProgress<IDownloadProgress> progress)
        {
            string uri = GetUri(source);
            DownloadObjectImpl(uri, destination, options, progress);
        }

        /// <summary>
        /// Downloads the data for an object from storage asynchronously, into a specified stream.
        /// </summary>
        /// <param name="source">Source object to download the data from. Must not be null.</param>
        /// <param name="destination">The stream to write the data into. Must not be null.</param>
        /// <param name="options">Additional options for the download. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <param name="progress">Progress reporter for the download. May be null.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public Task DownloadObjectAsync(
            Object source,
            Stream destination,
            DownloadObjectOptions options,
            CancellationToken cancellationToken,
            IProgress<IDownloadProgress> progress)
        {
            string uri = GetUri(source);
            return DownloadObjectAsyncImpl(uri, destination, options, cancellationToken, progress);
        }

        /// <summary>
        /// Constructs the media URL of an object from its bucket and name.
        /// </summary>
        private static string GetUri(string bucket, string objectName)
        {
            ValidateBucket(bucket);
            objectName.CheckNotNull(nameof(objectName));
            return $"https://www.googleapis.com/download/storage/v1/b/{bucket}/o/{Uri.EscapeDataString(objectName)}?alt=media";
        }

        /// <summary>
        /// Obtains the media URL of an object from eiteher the MediaLink property, or its bucket and name.
        /// </summary>
        private static string GetUri(Object source)
        {
            source.CheckNotNull(nameof(source));
            if (source.MediaLink != null)
            {
                return source.MediaLink;
            }
            if (source.Bucket != null && source.Name != null)
            {
                return GetUri(source.Bucket, source.Name);
            }
            throw new ArgumentException("Object must have either MediaLink or both Bucket and Name set");
        }

        private void DownloadObjectImpl(string uri, Stream destination, DownloadObjectOptions options, IProgress<IDownloadProgress> progress)
        {
            // URI will definitely not be null; that's constructed internally.
            destination.CheckNotNull(nameof(destination));
            var downloader = new MediaDownloader(Service);
            options?.ModifyDownloader(downloader);
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

        private async Task DownloadObjectAsyncImpl(
            string uri,
            Stream destination,
            DownloadObjectOptions options,
            CancellationToken cancellationToken,
            IProgress<IDownloadProgress> progress)
        {
            destination.CheckNotNull(nameof(destination));
            var downloader = new MediaDownloader(Service);
            options?.ModifyDownloader(downloader);
            if (progress != null)
            {
                downloader.ProgressChanged += progress.Report;
                // Avoid reporting progress synchronously in the original call.
                await Task.Yield();
                progress.Report(InitialDownloadProgress.Instance);
            }
            var result = await downloader.DownloadAsync(uri, destination, cancellationToken).ConfigureAwait(false);
            if (result.Status == DownloadStatus.Failed)
            {
                throw result.Exception;
            }
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
