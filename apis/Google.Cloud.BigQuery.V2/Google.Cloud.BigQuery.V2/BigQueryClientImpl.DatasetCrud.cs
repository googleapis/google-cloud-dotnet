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
            GaxPreconditions.CheckNotNull(datasetReference, nameof(datasetReference));
            var request = Service.Datasets.Get(datasetReference.ProjectId, datasetReference.DatasetId);
            request.ModifyRequest += _versionHeaderAction;
            options?.ModifyRequest(request);
            return new BigQueryDataset(this, request.Execute());
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

        private ListRequest CreateListDatasetsRequest(ProjectReference projectReference, ListDatasetsOptions options)
        {
            var request = Service.Datasets.List(projectReference.ProjectId);
            request.ModifyRequest += _versionHeaderAction;
            options?.ModifyRequest(request);
            return request;
        }

        /// <inheritdoc />
        public override BigQueryDataset CreateDataset(DatasetReference datasetReference, CreateDatasetOptions options = null)
        {
            GaxPreconditions.CheckNotNull(datasetReference, nameof(datasetReference));
            var dataset = new Dataset { DatasetReference = datasetReference };
            var request = Service.Datasets.Insert(dataset, datasetReference.ProjectId);
            request.ModifyRequest += _versionHeaderAction;
            options?.ModifyRequest(dataset, request);
            return new BigQueryDataset(this, request.Execute());
        }

        /// <inheritdoc />
        public override BigQueryDataset GetOrCreateDataset(DatasetReference datasetReference, GetDatasetOptions getOptions = null, CreateDatasetOptions createOptions = null)
        {
            GaxPreconditions.CheckNotNull(datasetReference, nameof(datasetReference));
            try
            {
                return GetDataset(datasetReference, getOptions);
            }
            catch (GoogleApiException ex) when (ex.HttpStatusCode == HttpStatusCode.NotFound)
            {
                return CreateDataset(datasetReference, createOptions);
            }
        }

        /// <inheritdoc />
        public override void DeleteDataset(DatasetReference datasetReference, DeleteDatasetOptions options = null)
        {
            GaxPreconditions.CheckNotNull(datasetReference, nameof(datasetReference));
            var request = Service.Datasets.Delete(datasetReference.ProjectId, datasetReference.DatasetId);
            request.ModifyRequest += _versionHeaderAction;
            options?.ModifyRequest(request);
            request.Execute();
        }

        /// <inheritdoc />
        public override async Task<BigQueryDataset> GetDatasetAsync(DatasetReference datasetReference, GetDatasetOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxPreconditions.CheckNotNull(datasetReference, nameof(datasetReference));
            var request = Service.Datasets.Get(datasetReference.ProjectId, datasetReference.DatasetId);
            request.ModifyRequest += _versionHeaderAction;
            options?.ModifyRequest(request);
            return new BigQueryDataset(this, await request.ExecuteAsync(cancellationToken).ConfigureAwait(false));
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
        public override async Task<BigQueryDataset> CreateDatasetAsync(DatasetReference datasetReference, CreateDatasetOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxPreconditions.CheckNotNull(datasetReference, nameof(datasetReference));
            var dataset = new Dataset { DatasetReference = datasetReference };
            var request = Service.Datasets.Insert(dataset, datasetReference.ProjectId);
            request.ModifyRequest += _versionHeaderAction;
            options?.ModifyRequest(dataset, request);
            return new BigQueryDataset(this, await request.ExecuteAsync(cancellationToken).ConfigureAwait(false));
        }

        /// <inheritdoc />
        public override async Task<BigQueryDataset> GetOrCreateDatasetAsync(DatasetReference datasetReference, GetDatasetOptions getOptions = null, CreateDatasetOptions createOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxPreconditions.CheckNotNull(datasetReference, nameof(datasetReference));
            try
            {
                return await GetDatasetAsync(datasetReference, getOptions, cancellationToken).ConfigureAwait(false);
            }
            catch (GoogleApiException ex) when (ex.HttpStatusCode == HttpStatusCode.NotFound)
            {
                return await CreateDatasetAsync(datasetReference, createOptions, cancellationToken).ConfigureAwait(false); ;
            }
        }

        /// <inheritdoc />
        public override async Task DeleteDatasetAsync(DatasetReference datasetReference, DeleteDatasetOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxPreconditions.CheckNotNull(datasetReference, nameof(datasetReference));
            var request = Service.Datasets.Delete(datasetReference.ProjectId, datasetReference.DatasetId);
            request.ModifyRequest += _versionHeaderAction;
            options?.ModifyRequest(request);
            await request.ExecuteAsync(cancellationToken).ConfigureAwait(false);
        }
    }
}
