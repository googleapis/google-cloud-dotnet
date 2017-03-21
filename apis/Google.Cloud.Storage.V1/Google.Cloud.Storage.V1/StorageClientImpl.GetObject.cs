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
using Google.Apis.Storage.v1;
using System.Threading;
using System.Threading.Tasks;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Cloud.Storage.V1
{
    public sealed partial class StorageClientImpl : StorageClient
    {
        /// <inheritdoc />
        public override Object GetObject(string bucket, string objectName, GetObjectOptions options = null)
        {
            ValidateBucketName(bucket);
            GaxPreconditions.CheckNotNull(objectName, nameof(objectName));
            return CreateGetObjectRequest(bucket, objectName, options).Execute();
        }

        /// <inheritdoc />
        public override Task<Object> GetObjectAsync(
            string bucket,
            string objectName,
            GetObjectOptions options = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            ValidateBucketName(bucket);
            GaxPreconditions.CheckNotNull(objectName, nameof(objectName));
            return CreateGetObjectRequest(bucket, objectName, options).ExecuteAsync(cancellationToken);
        }

        private ObjectsResource.GetRequest CreateGetObjectRequest(string bucket, string objectName, GetObjectOptions options)
        {
            var request = Service.Objects.Get(bucket, objectName);
            request.ModifyRequest += _versionHeaderAction;
            ApplyEncryptionKey(options?.EncryptionKey, request);
            options?.ModifyRequest(request);
            return request;
        }
    }
}
