// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
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
    /// <inheritdoc/>
    public override Object RestoreObject(string bucket, string objectName, long generation, RestoreObjectOptions options = null) =>
        CreateRestoreObjectRequest(bucket, objectName, generation, options).Execute();

    /// <inheritdoc/>
    public override Task<Object> RestoreObjectAsync(
        string bucket,
        string objectName,
        long generation,
        RestoreObjectOptions options = null,
        CancellationToken cancellationToken = default) =>
        CreateRestoreObjectRequest(bucket, objectName, generation, options).ExecuteAsync(cancellationToken);

    private ObjectsResource.RestoreRequest CreateRestoreObjectRequest(string bucket, string objectName, long generation, RestoreObjectOptions options)
    {
        ValidateBucketName(bucket);
        GaxPreconditions.CheckNotNull(objectName, nameof(objectName));
        var request = Service.Objects.Restore(bucket, objectName, generation);
        ApplyEncryptionKey(options?.EncryptionKey, kmsNameFromOptions: null, request);
        options?.ModifyRequest(request);
        RetryOptions retryOptions = options?.RetryOptions ?? RetryOptions.MaybeIdempotent(options?.IfGenerationMatch);
        MarkAsRetriable(request, retryOptions);
        return request;
    }
}
