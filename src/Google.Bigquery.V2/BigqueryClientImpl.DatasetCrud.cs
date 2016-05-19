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

using Google.Apis.Bigquery.v2;
using Google.Apis.Bigquery.v2.Data;
using Google.Apis.Requests;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Google.Bigquery.V2
{
    public partial class BigqueryClientImpl
    {
        private static readonly PageStreamer<DatasetList.DatasetsData, DatasetsResource.ListRequest, DatasetList, string> s_datasetsPageStreamer =
            new PageStreamer<DatasetList.DatasetsData, DatasetsResource.ListRequest, DatasetList, string>(
            (request, token) => request.PageToken = token,
            response => response.NextPageToken,
            response => response.Datasets);

        /// <inheritdoc />
        public override BigqueryDataset GetDataset(DatasetReference datasetReference, GetDatasetOptions options = null)
        {
            Preconditions.CheckNotNull(datasetReference, nameof(datasetReference));
            var request = Service.Datasets.Get(datasetReference.ProjectId, datasetReference.DatasetId);
            options?.ModifyRequest(request);
            return new BigqueryDataset(this, request.Execute());
        }

        /// <inheritdoc />
        public override IEnumerable<BigqueryDataset> ListDatasets(ProjectReference projectReference, ListDatasetsOptions options = null)
        {
            Preconditions.CheckNotNull(projectReference, nameof(projectReference));

            var initialRequest = CreateListDatasetsRequest(projectReference, options);
            return s_datasetsPageStreamer.Fetch(initialRequest).Select(resource => new BigqueryDataset(this, resource));
        }

        private DatasetsResource.ListRequest CreateListDatasetsRequest(ProjectReference projectReference, ListDatasetsOptions options)
        {
            var request = Service.Datasets.List(projectReference.ProjectId);
            options?.ModifyRequest(request);
            return request;
        }

        /// <inheritdoc />
        public override BigqueryDataset CreateDataset(DatasetReference datasetReference, CreateDatasetOptions options = null)
        {
            Preconditions.CheckNotNull(datasetReference, nameof(datasetReference));
            var dataset = new Dataset { DatasetReference = datasetReference };
            var request = Service.Datasets.Insert(dataset, datasetReference.ProjectId);
            options?.ModifyRequest(dataset, request);
            return new BigqueryDataset(this, request.Execute());
        }

        /// <inheritdoc />
        public override BigqueryDataset GetOrCreateDataset(DatasetReference datasetReference, GetDatasetOptions getOptions = null, CreateDatasetOptions createOptions = null)
        {
            Preconditions.CheckNotNull(datasetReference, nameof(datasetReference));
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
            Preconditions.CheckNotNull(datasetReference, nameof(datasetReference));
            var request = Service.Datasets.Delete(datasetReference.ProjectId, datasetReference.DatasetId);
            options?.ModifyRequest(request);
            request.Execute();
        }
    }
}
