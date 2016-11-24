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

using System;
using System.Threading;
using System.Threading.Tasks;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Cloud.Storage.V1
{
    public abstract partial class StorageClient
    {
        /// <summary>
        /// Fetches the information about an object synchronously.
        /// </summary>
        /// <remarks>This does not retrieve the content of the object itself. Use <see cref="DownloadObject(string, string, System.IO.Stream, DownloadObjectOptions, System.IProgress{Apis.Download.IDownloadProgress})"/>
        /// to download the content.</remarks>
        /// <param name="bucket">The name of the bucket containing the object. Must not be null.</param>
        /// <param name="objectName">The name of the object within the bucket. Must not be null.</param>
        /// <param name="options">Additional options for the fetch operation. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <returns>The <see cref="Object"/> representation of the storage object.</returns>
        public virtual Object GetObject(string bucket, string objectName, GetObjectOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Fetches the information about an object asynchronously.
        /// </summary>
        /// <remarks>This does not retrieve the content of the object itself. Use <see cref="DownloadObjectAsync(string, string, System.IO.Stream, DownloadObjectOptions, CancellationToken, System.IProgress{Apis.Download.IDownloadProgress})"/>
        /// to download the content.</remarks>
        /// <param name="bucket">The name of the bucket containing the object. Must not be null.</param>
        /// <param name="objectName">The name of the object within the bucket. Must not be null.</param>
        /// <param name="options">Additional options for the fetch operation. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation, with a result returning the
        /// <see cref="Object"/> representation of the storage object.</returns>
        public virtual Task<Object> GetObjectAsync(
            string bucket,
            string objectName,
            GetObjectOptions options = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }        
    }
}
