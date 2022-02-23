// Copyright 2019 Google LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     https://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Api.Gax.Rest;
using Google.Apis.Storage.v1.Data;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using static Google.Apis.Storage.v1.ProjectsResource;

namespace Google.Cloud.Storage.V1
{
    public partial class StorageClientImpl
    {
        private sealed class HmacKeyPageManager : IPageManager<HmacKeysResource.ListRequest, HmacKeysMetadata, HmacKeyMetadata>
        {
            internal static readonly HmacKeyPageManager Instance = new HmacKeyPageManager();
            public string GetNextPageToken(HmacKeysMetadata response) => response.NextPageToken;
            public IEnumerable<HmacKeyMetadata> GetResources(HmacKeysMetadata response) => response.Items;
            public void SetPageSize(HmacKeysResource.ListRequest request, int pageSize) => request.MaxResults = pageSize;
            public void SetPageToken(HmacKeysResource.ListRequest request, string pageToken) => request.PageToken = pageToken;
        }

        /// <inheritdoc />
        public override HmacKey CreateHmacKey(string projectId, string serviceAccountEmail, CreateHmacKeyOptions options = null) =>
            CreateCreateHmacKeyRequest(projectId, serviceAccountEmail, options).Execute();

        /// <inheritdoc />
        public override Task<HmacKey> CreateHmacKeyAsync(string projectId, string serviceAccountEmail, CreateHmacKeyOptions options = null, CancellationToken cancellationToken = default) =>
            CreateCreateHmacKeyRequest(projectId, serviceAccountEmail, options).ExecuteAsync(cancellationToken);

        /// <inheritdoc />
        public override HmacKeyMetadata GetHmacKey(string projectId, string accessId, GetHmacKeyOptions options = null) =>
            CreateGetHmacKeyRequest(projectId, accessId, options).Execute();

        /// <inheritdoc />
        public override Task<HmacKeyMetadata> GetHmacKeyAsync(string projectId, string accessId, GetHmacKeyOptions options = null, CancellationToken cancellationToken = default) =>
            CreateGetHmacKeyRequest(projectId, accessId, options).ExecuteAsync(cancellationToken);

        /// <inheritdoc />
        public override PagedEnumerable<HmacKeysMetadata, HmacKeyMetadata> ListHmacKeys(string projectId, string serviceAccountEmail = null, ListHmacKeysOptions options = null)
        {
            GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            return new RestPagedEnumerable<HmacKeysResource.ListRequest, HmacKeysMetadata, HmacKeyMetadata>(
                () => CreateListHmacKeysRequest(projectId, serviceAccountEmail, options), HmacKeyPageManager.Instance);
        }

        /// <inheritdoc />
        public override PagedAsyncEnumerable<HmacKeysMetadata, HmacKeyMetadata> ListHmacKeysAsync(string projectId, string serviceAccountEmail = null, ListHmacKeysOptions options = null)
        {
            GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            return new RestPagedAsyncEnumerable<HmacKeysResource.ListRequest, HmacKeysMetadata, HmacKeyMetadata>(
                () => CreateListHmacKeysRequest(projectId, serviceAccountEmail, options), HmacKeyPageManager.Instance);
        }

        /// <inheritdoc />
        public override HmacKeyMetadata UpdateHmacKey(HmacKeyMetadata key, UpdateHmacKeyOptions options = null) =>
            CreateUpdateHmacKeyRequest(key, options).Execute();

        /// <inheritdoc />
        public override Task<HmacKeyMetadata> UpdateHmacKeyAsync(HmacKeyMetadata key, UpdateHmacKeyOptions options = null, CancellationToken cancellationToken = default) =>
            CreateUpdateHmacKeyRequest(key, options).ExecuteAsync(cancellationToken);

        /// <inheritdoc />
        public override void DeleteHmacKey(string projectId, string accessId, DeleteHmacKeyOptions options = null) =>
            CreateDeleteHmacKeyRequest(projectId, accessId, options).Execute();

        /// <inheritdoc />
        public override Task DeleteHmacKeyAsync(string projectId, string accessId, DeleteHmacKeyOptions options = null, CancellationToken cancellationToken = default) =>
            CreateDeleteHmacKeyRequest(projectId, accessId, options).ExecuteAsync(cancellationToken);

        private HmacKeysResource.CreateRequest CreateCreateHmacKeyRequest(string projectId, string serviceAccountEmail, CreateHmacKeyOptions options)
        {
            GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            GaxPreconditions.CheckNotNull(serviceAccountEmail, nameof(serviceAccountEmail));
            var request = Service.Projects.HmacKeys.Create(projectId, serviceAccountEmail);
            options?.ModifyRequest(request);
            return request;
        }

        private HmacKeysResource.GetRequest CreateGetHmacKeyRequest(string projectId, string accessId, GetHmacKeyOptions options)
        {
            GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            GaxPreconditions.CheckNotNull(accessId, nameof(accessId));
            var request = Service.Projects.HmacKeys.Get(projectId, accessId);
            options?.ModifyRequest(request);
            RetryHandler.MarkAsRetriable(request);
            return request;
        }

        private HmacKeysResource.UpdateRequest CreateUpdateHmacKeyRequest(HmacKeyMetadata key, UpdateHmacKeyOptions options)
        {
            GaxPreconditions.CheckNotNull(key, nameof(key));
            GaxPreconditions.CheckArgument(key.ProjectId != null, nameof(key), "Key must contain a project ID");
            GaxPreconditions.CheckArgument(key.AccessId != null, nameof(key), "Key must contain an access ID");
            var request = Service.Projects.HmacKeys.Update(key, key.ProjectId, key.AccessId);
            options?.ModifyRequest(request);
            return request;
        }

        private HmacKeysResource.DeleteRequest CreateDeleteHmacKeyRequest(string projectId, string accessId, DeleteHmacKeyOptions options)
        {
            GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            GaxPreconditions.CheckNotNull(accessId, nameof(accessId));
            var request = Service.Projects.HmacKeys.Delete(projectId, accessId);
            options?.ModifyRequest(request);
            RetryHandler.MarkAsRetriable(request);
            return request;
        }

        private HmacKeysResource.ListRequest CreateListHmacKeysRequest(string projectId, string serviceAccountEmail, ListHmacKeysOptions options)
        {
            var request = Service.Projects.HmacKeys.List(projectId);
            request.ServiceAccountEmail = serviceAccountEmail; // Note: may be null
            options?.ModifyRequest(request);
            RetryHandler.MarkAsRetriable(request);
            return request;
        }
    }
}
