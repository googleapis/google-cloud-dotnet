// Copyright 2020 Google LLC
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
using Google.Apis.Bigquery.v2.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static Google.Apis.Bigquery.v2.ModelsResource;

namespace Google.Cloud.BigQuery.V2
{
    public partial class BigQueryClientImpl
    {
        // Visible for testing
        internal sealed class ModelPageManager : IPageManager<ListRequest, ListModelsResponse, BigQueryModel>
        {
            private readonly BigQueryClient _client;

            internal ModelPageManager(BigQueryClient client)
            {
                _client = client;
            }

            public string GetNextPageToken(ListModelsResponse response) => response.NextPageToken;
            public IEnumerable<BigQueryModel> GetResources(ListModelsResponse response) => response.Models?.Select(resource => new BigQueryModel(_client, resource));
            public void SetPageSize(ListRequest request, int pageSize) => request.MaxResults = pageSize;
            public void SetPageToken(ListRequest request, string pageToken) => request.PageToken = pageToken;
        }

        /// <inheritdoc />
        public override BigQueryModel GetModel(ModelReference modelReference, GetModelOptions options = null)
        {
            var request = CreateGetModelRequest(modelReference, options);
            var resource = request.Execute();
            return new BigQueryModel(this, resource);
        }

        /// <inheritdoc />
        public override async Task<BigQueryModel> GetModelAsync(ModelReference modelReference, GetModelOptions options = null, CancellationToken cancellationToken = default)
        {
            var request = CreateGetModelRequest(modelReference, options);
            var resource = await request.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            return new BigQueryModel(this, resource);
        }

        /// <inheritdoc />
        public override void DeleteModel(ModelReference modelReference, DeleteModelOptions options = null)
        {
            var request = CreateDeleteModelRequest(modelReference, options);
            request.Execute();
        }

        /// <inheritdoc />
        public override async Task DeleteModelAsync(ModelReference modelReference, DeleteModelOptions options = null, CancellationToken cancellationToken = default)
        {
            var request = CreateDeleteModelRequest(modelReference, options);
            await request.ExecuteAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public override BigQueryModel PatchModel(ModelReference modelReference, Model resource, PatchModelOptions options = null)
        {
            var request = CreatePatchModelRequest(modelReference, resource, options);
            var model = request.Execute();
            return new BigQueryModel(this, model);
        }

        /// <inheritdoc />
        public override async Task<BigQueryModel> PatchModelAsync(ModelReference modelReference, Model resource, PatchModelOptions options = null, CancellationToken cancellationToken = default)
        {
            var request = CreatePatchModelRequest(modelReference, resource, options);
            var model = await request.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            return new BigQueryModel(this, model);
        }

        /// <inheritdoc />
        public override PagedEnumerable<ListModelsResponse, BigQueryModel> ListModels(DatasetReference datasetReference, ListModelsOptions options = null)
        {
            GaxPreconditions.CheckNotNull(datasetReference, nameof(datasetReference));

            var pageManager = new ModelPageManager(this);
            return new RestPagedEnumerable<ListRequest, ListModelsResponse, BigQueryModel>(
                () => CreateListModelsRequest(datasetReference, options),
                pageManager);
        }

        /// <inheritdoc />
        public override PagedAsyncEnumerable<ListModelsResponse, BigQueryModel> ListModelsAsync(DatasetReference datasetReference, ListModelsOptions options = null)
        {
            GaxPreconditions.CheckNotNull(datasetReference, nameof(datasetReference));

            var pageManager = new ModelPageManager(this);
            return new RestPagedAsyncEnumerable<ListRequest, ListModelsResponse, BigQueryModel>(
                () => CreateListModelsRequest(datasetReference, options),
                pageManager);
        }

        private GetRequest CreateGetModelRequest(ModelReference modelReference, GetModelOptions options)
        {
            GaxPreconditions.CheckNotNull(modelReference, nameof(modelReference));

            var request = Service.Models.Get(modelReference.ProjectId, modelReference.DatasetId, modelReference.ModelId);
            options?.ModifyRequest(request);
            RetryHandler.MarkAsRetriable(request);
            request.PrettyPrint = PrettyPrint;
            return request;
        }

        private DeleteRequest CreateDeleteModelRequest(ModelReference modelReference, DeleteModelOptions options)
        {
            GaxPreconditions.CheckNotNull(modelReference, nameof(modelReference));
            var request = Service.Models.Delete(modelReference.ProjectId, modelReference.DatasetId, modelReference.ModelId);
            options?.ModifyRequest(request);
            request.PrettyPrint = PrettyPrint;
            return request;
        }

        private PatchRequest CreatePatchModelRequest(ModelReference modelReference, Model resource, PatchModelOptions options)
        {
            GaxPreconditions.CheckNotNull(modelReference, nameof(modelReference));
            GaxPreconditions.CheckNotNull(resource, nameof(resource));
            var request = Service.Models.Patch(resource, modelReference.ProjectId, modelReference.DatasetId, modelReference.ModelId);
            options?.ModifyRequest(request);
            RetryIfETagPresent(request, resource);
            request.PrettyPrint = PrettyPrint;
            return request;
        }

        private ListRequest CreateListModelsRequest(DatasetReference datasetReference, ListModelsOptions options)
        {
            var request = Service.Models.List(datasetReference.ProjectId, datasetReference.DatasetId);
            options?.ModifyRequest(request);
            RetryHandler.MarkAsRetriable(request);
            request.PrettyPrint = PrettyPrint;
            return request;
        }
    }
}
