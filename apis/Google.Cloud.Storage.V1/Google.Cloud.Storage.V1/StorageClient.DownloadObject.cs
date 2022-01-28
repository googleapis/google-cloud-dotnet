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

using Google.Apis.Download;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Cloud.Storage.V1
{
    public abstract partial class StorageClient
    {
        /// <summary>
        /// Downloads the data for an object from storage synchronously, into a specified stream.
        /// </summary>
        /// <param name="bucket">The name of the bucket containing the object. Must not be null.</param>
        /// <param name="objectName">The name of the object within the bucket. Must not be null.</param>
        /// <param name="destination">The stream to write the data into. Must not be null.</param>
        /// <param name="options">Additional options for the download. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <param name="progress">Progress reporter for the download. May be null.</param>
        /// <returns>FIXME</returns>
        public virtual ContentMetadata DownloadObject(
            string bucket,
            string objectName,
            Stream destination,
            DownloadObjectOptions options = null,
            IProgress<IDownloadProgress> progress = null)
        {
            throw new NotImplementedException();
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
        public virtual Task<ContentMetadata> DownloadObjectAsync(
            string bucket,
            string objectName,
            Stream destination,
            DownloadObjectOptions options = null,
            CancellationToken cancellationToken = default,
            IProgress<IDownloadProgress> progress = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Downloads the data for an object from storage synchronously, into a specified stream.
        /// </summary>
        /// <remarks>The generation number within <paramref name="source"/> is ignored by this method.
        /// To download a specific generation, use <see cref="DownloadObjectOptions.Generation"/>.
        /// </remarks>
        /// <param name="source">Source object to download the data from. Must not be null.</param>
        /// <param name="destination">The stream to write the data into. Must not be null.</param>
        /// <param name="options">Additional options for the download. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <param name="progress">Progress reporter for the download. May be null.</param>
        public virtual ContentMetadata DownloadObject(
            Object source,
            Stream destination,
            DownloadObjectOptions options = null,
            IProgress<IDownloadProgress> progress = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Downloads the data for an object from storage asynchronously, into a specified stream.
        /// </summary>
        /// <remarks>The generation number within <paramref name="source"/> is ignored by this method.
        /// To download a specific generation, use <see cref="DownloadObjectOptions.Generation"/>.
        /// </remarks>
        /// <param name="source">Source object to download the data from. Must not be null.</param>
        /// <param name="destination">The stream to write the data into. Must not be null.</param>
        /// <param name="options">Additional options for the download. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <param name="progress">Progress reporter for the download. May be null.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public virtual Task<ContentMetadata> DownloadObjectAsync(
            Object source,
            Stream destination,
            DownloadObjectOptions options = null,
            CancellationToken cancellationToken = default,
            IProgress<IDownloadProgress> progress = null)
        {
            throw new NotImplementedException();
        }
    }
}
