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
using Google.Apis.Bigquery.v2.Data;
using System;

namespace Google.Cloud.BigQuery.V2
{
    public abstract partial class BigQueryClient
    {
        #region ListDatasets
        /// <summary>
        /// Lists the datasets within this client's project.
        /// This method just creates a <see cref="ProjectReference"/> and delegates to <see cref="ListDatasets(ProjectReference, ListDatasetsOptions)"/>.
        /// </summary>
        /// <remarks>
        /// No network requests are made until the returned sequence is enumerated.
        /// This means that any exception due to an invalid request will be deferred until that time. Callers should be prepared
        /// for exceptions to be thrown while enumerating the results. In addition to failures due to invalid requests, network
        /// or service failures can cause exceptions even after the first results have been returned.
        /// </remarks>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A sequence of datasets within this project.</returns>
        public virtual PagedEnumerable<DatasetList, BigQueryDataset> ListDatasets(ListDatasetsOptions options = null) =>
            ListDatasets(GetProjectReference(ProjectId), options);

        /// <summary>
        /// Lists the datasets within the specified project.
        /// This method just creates a <see cref="ProjectReference"/> and delegates to <see cref="ListDatasets(ProjectReference, ListDatasetsOptions)"/>.
        /// </summary>
        /// <remarks>
        /// No network requests are made until the returned sequence is enumerated.
        /// This means that any exception due to an invalid request will be deferred until that time. Callers should be prepared
        /// for exceptions to be thrown while enumerating the results. In addition to failures due to invalid requests, network
        /// or service failures can cause exceptions even after the first results have been returned.
        /// </remarks>
        /// <param name="projectId">The project to list the datasets from. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A sequence of datasets within the specified project.</returns>
        public virtual PagedEnumerable<DatasetList, BigQueryDataset> ListDatasets(string projectId, ListDatasetsOptions options = null) =>
            ListDatasets(GetProjectReference(projectId), options);

        /// <summary>
        /// Lists the datasets within the specified project.
        /// </summary>
        /// <remarks>
        /// No network requests are made until the returned sequence is enumerated.
        /// This means that any exception due to an invalid request will be deferred until that time. Callers should be prepared
        /// for exceptions to be thrown while enumerating the results. In addition to failures due to invalid requests, network
        /// or service failures can cause exceptions even after the first results have been returned.
        /// </remarks>
        /// <param name="projectReference">A fully-qualified identifier for the project. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A sequence of datasets within the specified project.</returns>
        public virtual PagedEnumerable<DatasetList, BigQueryDataset> ListDatasets(ProjectReference projectReference, ListDatasetsOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously lists the datasets within this client's project.
        /// This method just creates a <see cref="ProjectReference"/> and delegates to <see cref="ListDatasetsAsync(ProjectReference, ListDatasetsOptions)"/>.
        /// </summary>
        /// <remarks>
        /// No network requests are made until the returned sequence is enumerated.
        /// This means that any exception due to an invalid request will be deferred until that time. Callers should be prepared
        /// for exceptions to be thrown while enumerating the results. In addition to failures due to invalid requests, network
        /// or service failures can cause exceptions even after the first results have been returned.
        /// </remarks>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>An asynchronous sequence of datasets within this project.</returns>
        public virtual PagedAsyncEnumerable<DatasetList, BigQueryDataset> ListDatasetsAsync(ListDatasetsOptions options = null) =>
            ListDatasetsAsync(GetProjectReference(ProjectId), options);

        /// <summary>
        /// Asynchronously lists the datasets within the specified project.
        /// This method just creates a <see cref="ProjectReference"/> and delegates to <see cref="ListDatasetsAsync(ProjectReference, ListDatasetsOptions)"/>.
        /// </summary>
        /// <remarks>
        /// No network requests are made until the returned sequence is enumerated.
        /// This means that any exception due to an invalid request will be deferred until that time. Callers should be prepared
        /// for exceptions to be thrown while enumerating the results. In addition to failures due to invalid requests, network
        /// or service failures can cause exceptions even after the first results have been returned.
        /// </remarks>
        /// <param name="projectId">The project to list the datasets from. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>An asynchronous sequence of datasets within the specified project.</returns>
        public virtual PagedAsyncEnumerable<DatasetList, BigQueryDataset> ListDatasetsAsync(string projectId, ListDatasetsOptions options = null) =>
            ListDatasetsAsync(GetProjectReference(projectId), options);

        /// <summary>
        /// Asynchronously lists the datasets within the specified project.
        /// </summary>
        /// <remarks>
        /// No network requests are made until the returned sequence is enumerated.
        /// This means that any exception due to an invalid request will be deferred until that time. Callers should be prepared
        /// for exceptions to be thrown while enumerating the results. In addition to failures due to invalid requests, network
        /// or service failures can cause exceptions even after the first results have been returned.
        /// </remarks>
        /// <param name="projectReference">A fully-qualified identifier for the project. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>An asynchronous sequence of datasets within the specified project.</returns>
        public virtual PagedAsyncEnumerable<DatasetList, BigQueryDataset> ListDatasetsAsync(ProjectReference projectReference, ListDatasetsOptions options = null)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
