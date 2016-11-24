// Copyright 2016 Google Inc. All Rights Reserved.
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
        /// Patches the metadata for an object in storage synchronously.
        /// </summary>
        /// <param name="obj">Object to update. Must not be null, and must have populated <c>Name</c> and
        /// <c>Bucket</c> properties.</param>
        /// <param name="options">Additional options for the update. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <returns>The <see cref="Object"/> representation of the updated storage object.</returns>
        public virtual Object PatchObject(
            Object obj,
            PatchObjectOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Patches the metadata for an object in storage asynchronously.
        /// </summary>
        /// <param name="obj">Object to update. Must not be null, and must have populated <c>Name</c> and
        /// <c>Bucket</c> properties.</param>
        /// <param name="options">Additional options for the update. May be null, in which case appropriate
        /// defaults will be used.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation, with a result returning the
        /// <see cref="Object"/> representation of the updated storage object.</returns>
        public virtual Task<Object> PatchObjectAsync(
            Object obj,
            PatchObjectOptions options = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }
    }
}
