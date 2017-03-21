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

using Google.Api.Gax;
using Google.Apis.Storage.v1;
using System.Threading;
using System.Threading.Tasks;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Cloud.Storage.V1
{
    public sealed partial class StorageClientImpl : StorageClient
    {
        /// <inheritdoc />
        public override Object PatchObject(
            Object obj,
            PatchObjectOptions options = null)
            => CreatePatchObjectRequest(obj, options).Execute();

        /// <inheritdoc />
        public override Task<Object> PatchObjectAsync(
            Object obj,
            PatchObjectOptions options = null,
            CancellationToken cancellationToken = default(CancellationToken))
            => CreatePatchObjectRequest(obj, options).ExecuteAsync(cancellationToken);

        private ObjectsResource.PatchRequest CreatePatchObjectRequest(Object obj, PatchObjectOptions options)
        {
            GaxPreconditions.CheckNotNull(obj, nameof(obj));
            GaxPreconditions.CheckArgument(obj.Bucket != null, nameof(obj), "The Bucket property of the object to update is null");
            GaxPreconditions.CheckArgument(obj.Name != null, nameof(obj), "The Name property of the object to update is null");
            var request = Service.Objects.Patch(obj, obj.Bucket, obj.Name);
            request.ModifyRequest += _versionHeaderAction;
            options?.ModifyRequest(request);
            ApplyEncryptionKey(options?.EncryptionKey, request);
            return request;
        }
    }
}
