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
        public override void DeleteObject(string bucket, string objectName, DeleteObjectOptions options = null)
        {
            CreateDeleteObjectRequest(bucket, objectName, options).Execute();
        }

        /// <inheritdoc />
        public override Task DeleteObjectAsync(
            string bucket,
            string objectName,
            DeleteObjectOptions options = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return CreateDeleteObjectRequest(bucket, objectName, options).ExecuteAsync(cancellationToken);
        }

        /// <inheritdoc />
        public override void DeleteObject(Object obj, DeleteObjectOptions options = null)
        {
            CreateDeleteObjectRequest(obj, options).Execute();
        }

        /// <inheritdoc />
        public override Task DeleteObjectAsync(Object obj, DeleteObjectOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return CreateDeleteObjectRequest(obj, options).ExecuteAsync(cancellationToken);
        }

        private ObjectsResource.DeleteRequest CreateDeleteObjectRequest(Object obj, DeleteObjectOptions options)
        {
            ValidateObject(obj, nameof(obj));
            var request = Service.Objects.Delete(obj.Bucket, obj.Name);
            options?.ModifyRequest(request);
            return request;
        }

        private ObjectsResource.DeleteRequest CreateDeleteObjectRequest(string bucket, string name, DeleteObjectOptions options)
        {
            ValidateBucketName(bucket);
            GaxPreconditions.CheckNotNull(name, nameof(name));
            var request = Service.Objects.Delete(bucket, name);
            request.ModifyRequest += _versionHeaderAction;
            options?.ModifyRequest(request);
            return request;
        }
    }
}
