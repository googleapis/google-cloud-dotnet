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
using Google.Api.Gax.Rest;
using Google.Apis.Bigquery.v2.Data;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using static Google.Apis.Bigquery.v2.DatasetsResource;

namespace Google.Cloud.BigQuery.V2
{
    public partial class BigQueryClientImpl
    {
        private sealed class DatasetPageManager : IPageManager<ListRequest, DatasetList, BigQueryDataset>
        {
            private readonly BigQueryClient _client;

            internal DatasetPageManager(BigQueryClient client)
            {
                _client = client;
            }

            public string GetNextPageToken(DatasetList response) => response.NextPageToken;
            public IEnumerable<BigQueryDataset> GetResources(DatasetList response) => response.Datasets?.Select(resource => new BigQueryDataset(_client, resource));
            public void SetPageSize(ListRequest request, int pageSize) => request.MaxResults = pageSize;
            public void SetPageToken(ListRequest request, string pageToken) => request.PageToken = pageToken;
        }

        /// <inheritdoc />
        public override BigQueryDataset GetDataset(DatasetReference datasetReference, GetDatasetOptions options = null)
        {
            var request = CreateGetDatasetRequest(datasetReference, options);
            return new BigQueryDataset(this, CheckETag(request.Execute(), options?.ETag));
        }

        /// <inheritdoc />
        public override async Task<BigQueryDataset> GetDatasetAsync(DatasetReference datasetReference, GetDatasetOptions options = null, CancellationToken cancellationToken = default)
        {
            var request = CreateGetDatasetRequest(datasetReference, options);
            return new BigQueryDataset(this, CheckETag(await request.ExecuteAsync(cancellationToken).ConfigureAwait(false), options?.ETag));
        }

        /// <inheritdoc />
        public override PagedEnumerable<DatasetList, BigQueryDataset> ListDatasets(ProjectReference projectReference, ListDatasetsOptions options = null)
        {
            GaxPreconditions.CheckNotNull(projectReference, nameof(projectReference));

            var pageManager = new DatasetPageManager(this);
            return new RestPagedEnumerable<ListRequest, DatasetList, BigQueryDataset>(
                () => CreateListDatasetsRequest(projectReference, options),
                pageManager);
        }

        /// <inheritdoc />
        public override PagedAsyncEnumerable<DatasetList, BigQueryDataset> ListDatasetsAsync(ProjectReference projectReference, ListDatasetsOptions options = null)
        {
            GaxPreconditions.CheckNotNull(projectReference, nameof(projectReference));

            var pageManager = new DatasetPageManager(this);
            return new RestPagedAsyncEnumerable<ListRequest, DatasetList, BigQueryDataset>(
                () => CreateListDatasetsRequest(projectReference, options),
                pageManager);
        }

        /// <inheritdoc />
        public override BigQueryDataset CreateDataset(DatasetReference datasetReference, Dataset resource = null, CreateDatasetOptions options = null)
        {
            var request = CreateInsertDatasetRequest(datasetReference, resource, options);
            return new BigQueryDataset(this, request.Execute());
        }

        /// <inheritdoc />
        public override async Task<BigQueryDataset> CreateDatasetAsync(DatasetReference datasetReference, Dataset resource = null, CreateDatasetOptions options = null, CancellationToken cancellationToken = default)
        {
            var request = CreateInsertDatasetRequest(datasetReference, resource, options);
            return new BigQueryDataset(this, await request.ExecuteAsync(cancellationToken).ConfigureAwait(false));
        }

        /// <inheritdoc />
        public override BigQueryDataset GetOrCreateDataset(DatasetReference datasetReference, Dataset resource = null, GetDatasetOptions getOptions = null, CreateDatasetOptions createOptions = null)
        {
            GaxPreconditions.CheckNotNull(datasetReference, nameof(datasetReference));
            GaxPreconditions.CheckArgument(
                resource?.DatasetReference == null || datasetReference.ReferencesSameAs(resource.DatasetReference),
                nameof(resource.DatasetReference),
                $"If {nameof(resource.DatasetReference)} is specified, it must be the same as {nameof(datasetReference)}");
            try
            {
                return GetDataset(datasetReference, getOptions);
            }
            catch (GoogleApiException ex) when (ex.HttpStatusCode == HttpStatusCode.NotFound)
            {
                try
                {
                    return CreateDataset(datasetReference, resource, createOptions);
                }
                catch (GoogleApiException ex2) when (ex2.HttpStatusCode == HttpStatusCode.Conflict)
                {
                    return GetDataset(datasetReference, getOptions);
                }
            }
        }

        /// <inheritdoc />
        public override async Task<BigQueryDataset> GetOrCreateDatasetAsync(DatasetReference datasetReference, Dataset resource = null, GetDatasetOptions getOptions = null, CreateDatasetOptions createOptions = null, CancellationToken cancellationToken = default)
        {
            GaxPreconditions.CheckNotNull(datasetReference, nameof(datasetReference));
            GaxPreconditions.CheckArgument(
                resource?.DatasetReference == null || datasetReference.ReferencesSameAs(resource.DatasetReference),
                nameof(resource.DatasetReference),
                $"If {nameof(resource.DatasetReference)} is specified, it must be the same as {nameof(datasetReference)}");
            try
            {
                return await GetDatasetAsync(datasetReference, getOptions, cancellationToken).ConfigureAwait(false);
            }
            catch (GoogleApiException ex) when (ex.HttpStatusCode == HttpStatusCode.NotFound)
            {
                try
                {
                    return await CreateDatasetAsync(datasetReference, resource, createOptions, cancellationToken).ConfigureAwait(false);
                }
                catch (GoogleApiException ex2) when (ex2.HttpStatusCode == HttpStatusCode.Conflict)
                {
                    return await GetDatasetAsync(datasetReference, getOptions, cancellationToken).ConfigureAwait(false);
                }
            }
        }

        /// <inheritdoc />
        public override void DeleteDataset(DatasetReference datasetReference, DeleteDatasetOptions options = null)
        {
            var request = CreateDeleteDatasetRequest(datasetReference, options);
            request.Execute();
        }

        /// <inheritdoc />
        public override async Task DeleteDatasetAsync(DatasetReference datasetReference, DeleteDatasetOptions options = null, CancellationToken cancellationToken = default)
        {
            var request = CreateDeleteDatasetRequest(datasetReference, options);
            await request.ExecuteAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public override BigQueryDataset UpdateDataset(DatasetReference datasetReference, Dataset resource, UpdateDatasetOptions options = null)
        {
            var request = CreateUpdateDatasetRequest(datasetReference, resource, options);
            return new BigQueryDataset(this, request.Execute());
        }

        /// <inheritdoc />
        public override async Task<BigQueryDataset> UpdateDatasetAsync(DatasetReference datasetReference, Dataset resource, UpdateDatasetOptions options = null, CancellationToken cancellationToken = default)
        {
            var request = CreateUpdateDatasetRequest(datasetReference, resource, options);
            return new BigQueryDataset(this, await request.ExecuteAsync(cancellationToken).ConfigureAwait(false));
        }

        /// <inheritdoc />
        public override BigQueryDataset PatchDataset(DatasetReference datasetReference, Dataset resource, PatchDatasetOptions options = null)
        {
            var request = CreatePatchDatasetRequest(datasetReference, resource, options);
            return new BigQueryDataset(this, request.Execute());
        }

        /// <inheritdoc />
        public override async Task<BigQueryDataset> PatchDatasetAsync(DatasetReference datasetReference, Dataset resource, PatchDatasetOptions options = null, CancellationToken cancellationToken = default)
        {
            var request = CreatePatchDatasetRequest(datasetReference, resource, options);
            return new BigQueryDataset(this, await request.ExecuteAsync(cancellationToken).ConfigureAwait(false));
        }

        // Request creation
        private GetRequest CreateGetDatasetRequest(DatasetReference datasetReference, GetDatasetOptions options)
        {
            GaxPreconditions.CheckNotNull(datasetReference, nameof(datasetReference));
            var request = Service.Datasets.Get(datasetReference.ProjectId, datasetReference.DatasetId);
            options?.ModifyRequest(request);
            RetryHandler.MarkAsRetriable(request);
            request.PrettyPrint = PrettyPrint;
            return request;
        }

        private ListRequest CreateListDatasetsRequest(ProjectReference projectReference, ListDatasetsOptions options)
        {
            var request = Service.Datasets.List(projectReference.ProjectId);
            options?.ModifyRequest(request);
            RetryHandler.MarkAsRetriable(request);
            request.PrettyPrint = PrettyPrint;
            return request;
        }

        private InsertRequest CreateInsertDatasetRequest(DatasetReference datasetReference, Dataset resource, CreateDatasetOptions options)
        {
            GaxPreconditions.CheckNotNull(datasetReference, nameof(datasetReference));
            GaxPreconditions.CheckArgument(
                resource?.DatasetReference == null || datasetReference.ReferencesSameAs(resource.DatasetReference),
                nameof(resource.DatasetReference),
                $"If {nameof(resource.DatasetReference)} is specified, it must be the same as {nameof(datasetReference)}");

            resource ??= new Dataset ();
            resource.DatasetReference ??= datasetReference;
            resource.Location ??= DefaultLocation;

            var request = Service.Datasets.Insert(resource, datasetReference.ProjectId);
            options?.ModifyRequest(request);
            request.PrettyPrint = PrettyPrint;
            return request;
        }

        private DeleteRequest CreateDeleteDatasetRequest(DatasetReference datasetReference, DeleteDatasetOptions options)
        {
            GaxPreconditions.CheckNotNull(datasetReference, nameof(datasetReference));
            var request = Service.Datasets.Delete(datasetReference.ProjectId, datasetReference.DatasetId);
            options?.ModifyRequest(request);
            request.PrettyPrint = PrettyPrint;
            return request;
        }

        private UpdateRequest CreateUpdateDatasetRequest(DatasetReference datasetReference, Dataset resource, UpdateDatasetOptions options)
        {
            GaxPreconditions.CheckNotNull(datasetReference, nameof(datasetReference));
            GaxPreconditions.CheckNotNull(resource, nameof(resource));
            var request = Service.Datasets.Update(resource, datasetReference.ProjectId, datasetReference.DatasetId);
            options?.ModifyRequest(request);
            RetryIfETagPresent(request, resource);
            request.PrettyPrint = PrettyPrint;
            return request;
        }

        private PatchRequest CreatePatchDatasetRequest(DatasetReference datasetReference, Dataset resource, PatchDatasetOptions options)
        {
            GaxPreconditions.CheckNotNull(datasetReference, nameof(datasetReference));
            GaxPreconditions.CheckNotNull(resource, nameof(resource));
            var request = Service.Datasets.Patch(resource, datasetReference.ProjectId, datasetReference.DatasetId);
            options?.ModifyRequest(request);
            RetryIfETagPresent(request, resource);
            request.PrettyPrint = PrettyPrint;
            return request;
        }
    }
}
