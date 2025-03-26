// Copyright 2025 Google Inc. All Rights Reserved.
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

namespace Google.Cloud.Storage.V1;

public abstract partial class StorageClient
{
    /// <summary>
    /// Moves an object within a bucket with hierarchical namespace enabled. This method uses the
    /// <c>moveObject</c> underlying API operation for more flexibility and reliability.
    /// </summary>
    /// <param name="sourceBucket">Name of the bucket containing the object you want to move. Must not be null.</param>
    /// <param name="sourceObjectName">The name of the source object to move within the bucket. Must not be null.</param>
    /// <param name="destinationObjectName">The name of the new object to move within the bucket. Must not be null.</param>
    /// <param name="options">Additional options for the move operation. May be null, in which case appropriate
    /// defaults will be used.</param>
    /// <returns>The <see cref="Object"/> representation of the new storage object resulting from the move.</returns>
    public virtual Object MoveObject(
        string sourceBucket,
        string sourceObjectName,
        string destinationObjectName,
        MoveObjectOptions options = null)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Moves an object within a bucket with hierarchical namespace enabled. This method uses the
    /// <c>moveObject</c> underlying API operation for more flexibility and reliability.
    /// </summary>
    /// <param name="sourceBucket">Name of the bucket containing the object you want to move. Must not be null.</param>
    /// <param name="sourceObjectName">The name of the source object to move within the bucket. Must not be null.</param>
    /// <param name="destinationObjectName">The name of the new object to move within the bucket. Must not be null.</param>
    /// <param name="options">Additional options for the move operation. May be null, in which case appropriate
    /// defaults will be used.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation, with a result returning the
    /// <see cref="Object"/> representation of the new storage object resulting from the move.</returns>
    public virtual Task<Object> MoveObjectAsync(
        string sourceBucket,
        string sourceObjectName,
        string destinationObjectName = null,
        MoveObjectOptions options = null,
        CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
