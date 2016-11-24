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
using Google.Apis.Storage.v1.Data;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Cloud.Storage.V1
{
    // ListObjects methods on StorageClient
    public abstract partial class StorageClient
    {
        /// <summary>
        /// Asynchronously lists the objects in a given bucket.
        /// </summary>
        /// <remarks>
        /// This method fetches the objects lazily, making requests to the underlying service
        /// for a page of results at a time, as required.
        /// </remarks>
        /// <param name="bucket">The bucket to list the objects from. Must not be null.</param>
        /// <param name="prefix">The prefix to match. Only objects with names that start with this string will be returned.
        /// This parameter may be null or empty, in which case no filtering is performed.</param>
        /// <param name="options">The options for the operation. May be null, in which case
        /// defaults will be supplied.</param>
        /// <returns>An asynchronous sequence of objects in the specified bucket.</returns>
        public virtual PagedAsyncEnumerable<Objects, Object> ListObjectsAsync(
            string bucket,
            string prefix = null,
            ListObjectsOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists the objects in a given bucket, synchronously but lazily.
        /// </summary>
        /// <remarks>
        /// This method fetches the objects lazily, making requests to the underlying service
        /// for a page of results at a time, as required.
        /// </remarks>
        /// <param name="bucket">The bucket to list the objects from. Must not be null.</param>
        /// <param name="prefix">The prefix to match. Only objects with names that start with this string will be returned.
        /// This parameter may be null or empty, in which case no filtering is performed.</param>
        /// <param name="options">The options for the operation. May be null, in which case
        /// defaults will be supplied.</param>
        /// <returns>A sequence of objects in the specified bucket.</returns>
        public virtual PagedEnumerable<Objects, Object> ListObjects(string bucket, string prefix = null, ListObjectsOptions options = null)
        {
            throw new NotImplementedException();
        }
    }
}
