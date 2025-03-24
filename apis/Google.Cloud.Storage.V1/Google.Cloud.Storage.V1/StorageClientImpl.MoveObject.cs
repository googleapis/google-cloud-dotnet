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

using Google.Api.Gax;
using Google.Apis.Storage.v1;
using System.Threading;
using System.Threading.Tasks;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Cloud.Storage.V1;

public sealed partial class StorageClientImpl : StorageClient
{
    /// <inheritdoc />
    public override Object MoveObject(
        string sourceBucket,
        string sourceObjectName,
        string destinationObjectName,
        MoveObjectOptions options = null)
    {
        var request = CreateMoveObjectRequest(sourceBucket, sourceObjectName, destinationObjectName, options);
        var response = request.Execute();
        return response;
    }

    /// <inheritdoc />
    public override async Task<Object> MoveObjectAsync(
        string sourceBucket,
        string sourceObjectName,
        string destinationObjectName,
        MoveObjectOptions options = null,
        CancellationToken cancellationToken = default)
    {
        var request = CreateMoveObjectRequest(sourceBucket, sourceObjectName, destinationObjectName, options);
        var response = await request.ExecuteAsync(cancellationToken).ConfigureAwait(false);
        return response;
    }

    private ObjectsResource.MoveRequest CreateMoveObjectRequest(
        string sourceBucket,
        string sourceObjectName,
        string destinationObjectName,
        MoveObjectOptions options)
    {
        GaxPreconditions.CheckNotNull(sourceBucket, nameof(sourceBucket));
        GaxPreconditions.CheckNotNull(sourceObjectName, nameof(sourceObjectName));
        GaxPreconditions.CheckNotNull(destinationObjectName, nameof(destinationObjectName));
        Object obj = options?.ExtraMetadata ?? new Object();
        var request = Service.Objects.Move(sourceBucket, sourceObjectName, destinationObjectName);
        options?.ModifyRequest(request);
        RetryOptions retryOptions = options?.RetryOptions ?? RetryOptions.MaybeIdempotent(options?.IfGenerationMatch);
        MarkAsRetriable(request, retryOptions);
        request.ModifyRequest += (options?.SourceEncryptionKey ?? EncryptionKey).ModifyRequest;
        return request;
    }
}
