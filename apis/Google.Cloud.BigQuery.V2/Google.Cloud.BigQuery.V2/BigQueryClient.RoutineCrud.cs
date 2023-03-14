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
using Google.Apis.Bigquery.v2.Data;
using System;

namespace Google.Cloud.BigQuery.V2
{
    public abstract partial class BigQueryClient
    {
        #region ListRoutines
        /// <summary>
        /// Lists the routines in a dataset specified by project ID and dataset ID.
        /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="ListRoutines(DatasetReference, ListRoutinesOptions)"/>.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The returned routines will contain populated properties as specified by <see cref="ListRoutinesOptions.ReadMask"/>
        /// or the default ones. <see cref="ListRoutinesOptions.ReadMask"/> for more information.
        /// </para>
        /// <para>
        /// No network requests are made until the returned sequence is enumerated.
        /// This means that any exception due to an invalid request will be deferred until that time. Callers should be prepared
        /// for exceptions to be thrown while enumerating the results. In addition to failures due to invalid requests, network
        /// or service failures can cause exceptions even after the first results have been returned.
        /// </para>
        /// </remarks>
        /// <param name="projectId">The ID of the project containing the dataset. Must not be null.</param>
        /// <param name="datasetId">The ID of the dataset to list routines from. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A sequence of routines within the dataset.</returns>
        public virtual PagedEnumerable<ListRoutinesResponse, BigQueryRoutine> ListRoutines(string projectId, string datasetId, ListRoutinesOptions options = null) =>
            ListRoutines(GetDatasetReference(projectId, datasetId), options);

        /// <summary>
        /// Lists the routines in a dataset specified by dataset ID, where the dataset is in this client's project.
        /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="ListRoutines(DatasetReference, ListRoutinesOptions)"/>.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The returned routines will contain populated properties as specified by <see cref="ListRoutinesOptions.ReadMask"/>
        /// or the default ones. <see cref="ListRoutinesOptions.ReadMask"/> for more information.
        /// </para>
        /// <para>
        /// No network requests are made until the returned sequence is enumerated.
        /// This means that any exception due to an invalid request will be deferred until that time. Callers should be prepared
        /// for exceptions to be thrown while enumerating the results. In addition to failures due to invalid requests, network
        /// or service failures can cause exceptions even after the first results have been returned.
        /// </para>
        /// </remarks>
        /// <param name="datasetId">The ID of the dataset to list routines from. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A sequence of routines within the dataset.</returns>
        public virtual PagedEnumerable<ListRoutinesResponse, BigQueryRoutine> ListRoutines(string datasetId, ListRoutinesOptions options = null) =>
            ListRoutines(GetDatasetReference(datasetId), options);

        /// <summary>
        /// Lists the routines in a dataset.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The returned routines will contain populated properties as specified by <see cref="ListRoutinesOptions.ReadMask"/>
        /// or the default ones. <see cref="ListRoutinesOptions.ReadMask"/> for more information.
        /// </para>
        /// <para>
        /// No network requests are made until the returned sequence is enumerated.
        /// This means that any exception due to an invalid request will be deferred until that time. Callers should be prepared
        /// for exceptions to be thrown while enumerating the results. In addition to failures due to invalid requests, network
        /// or service failures can cause exceptions even after the first results have been returned.
        /// </para>
        /// </remarks>
        /// <param name="datasetReference">A fully-qualified identifier for the dataset. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A sequence of tables within the dataset.</returns>
        public virtual PagedEnumerable<ListRoutinesResponse, BigQueryRoutine> ListRoutines(DatasetReference datasetReference, ListRoutinesOptions options = null) =>
            throw new NotImplementedException();

        /// <summary>
        /// Lists the routines in a dataset specified by project ID and dataset ID.
        /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="ListRoutinesAsync(DatasetReference, ListRoutinesOptions)"/>.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The returned routines will contain populated properties as specified by <see cref="ListRoutinesOptions.ReadMask"/>
        /// or the default ones. <see cref="ListRoutinesOptions.ReadMask"/> for more information.
        /// </para>
        /// <para>
        /// No network requests are made until the returned sequence is enumerated.
        /// This means that any exception due to an invalid request will be deferred until that time. Callers should be prepared
        /// for exceptions to be thrown while enumerating the results. In addition to failures due to invalid requests, network
        /// or service failures can cause exceptions even after the first results have been returned.
        /// </para>
        /// </remarks>
        /// <param name="projectId">The ID of the project containing the dataset. Must not be null.</param>
        /// <param name="datasetId">The ID of the dataset to list routines from. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>An asynchronous sequence of routines within the dataset.</returns>
        public virtual PagedAsyncEnumerable<ListRoutinesResponse, BigQueryRoutine> ListRoutinesAsync(string projectId, string datasetId, ListRoutinesOptions options = null) =>
            ListRoutinesAsync(GetDatasetReference(projectId, datasetId), options);

        /// <summary>
        /// Lists the routines in a dataset specified by dataset ID, where the dataset is in this client's project.
        /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="ListRoutinesAsync(DatasetReference, ListRoutinesOptions)"/>.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The returned routines will contain populated properties as specified by <see cref="ListRoutinesOptions.ReadMask"/>
        /// or the default ones. <see cref="ListRoutinesOptions.ReadMask"/> for more information.
        /// </para>
        /// <para>
        /// No network requests are made until the returned sequence is enumerated.
        /// This means that any exception due to an invalid request will be deferred until that time. Callers should be prepared
        /// for exceptions to be thrown while enumerating the results. In addition to failures due to invalid requests, network
        /// or service failures can cause exceptions even after the first results have been returned.
        /// </para>
        /// </remarks>
        /// <param name="datasetId">The ID of the dataset to list routines from. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>An asynchronous sequence of routines within the dataset.</returns>
        public virtual PagedAsyncEnumerable<ListRoutinesResponse, BigQueryRoutine> ListRoutinesAsync(string datasetId, ListRoutinesOptions options = null) =>
            ListRoutinesAsync(GetDatasetReference(datasetId), options);

        /// <summary>
        /// Lists the routines in a dataset.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The returned routines will contain populated properties as specified by <see cref="ListRoutinesOptions.ReadMask"/>
        /// or the default ones. <see cref="ListRoutinesOptions.ReadMask"/> for more information.
        /// </para>
        /// <para>
        /// No network requests are made until the returned sequence is enumerated.
        /// This means that any exception due to an invalid request will be deferred until that time. Callers should be prepared
        /// for exceptions to be thrown while enumerating the results. In addition to failures due to invalid requests, network
        /// or service failures can cause exceptions even after the first results have been returned.
        /// </para>
        /// </remarks>
        /// <param name="datasetReference">A fully-qualified identifier for the dataset. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A sequence of routines within the dataset.</returns>
        public virtual PagedAsyncEnumerable<ListRoutinesResponse, BigQueryRoutine> ListRoutinesAsync(DatasetReference datasetReference, ListRoutinesOptions options = null) =>
            throw new NotImplementedException();
        #endregion
    }
}
