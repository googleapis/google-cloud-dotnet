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
        #region ListTables
        /// <summary>
        /// Lists the tables in a dataset specified by project ID and dataset ID.
        /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="ListTables(DatasetReference, ListTablesOptions)"/>.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The returned tables will not have all the properties in the resource populated. For complete information, make a GetTable
        /// call for each table you need the details of.
        /// </para>
        /// <para>
        /// No network requests are made until the returned sequence is enumerated.
        /// This means that any exception due to an invalid request will be deferred until that time. Callers should be prepared
        /// for exceptions to be thrown while enumerating the results. In addition to failures due to invalid requests, network
        /// or service failures can cause exceptions even after the first results have been returned.
        /// </para>
        /// </remarks>
        /// <param name="projectId">The ID of the project containing the dataset. Must not be null.</param>
        /// <param name="datasetId">The ID of the dataset to list tables from. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A sequence of tables within the dataset.</returns>
        public virtual PagedEnumerable<TableList, BigQueryTable> ListTables(string projectId, string datasetId, ListTablesOptions options = null) =>
            ListTables(GetDatasetReference(projectId, datasetId), options);

        /// <summary>
        /// Lists the tables in a dataset specified by dataset ID, where the dataset is in this client's project.
        /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="ListTables(DatasetReference, ListTablesOptions)"/>.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The returned tables will not have all the properties in the resource populated. For complete information, make a GetTable
        /// call for each table you need the details of.
        /// </para>
        /// <para>
        /// No network requests are made until the returned sequence is enumerated.
        /// This means that any exception due to an invalid request will be deferred until that time. Callers should be prepared
        /// for exceptions to be thrown while enumerating the results. In addition to failures due to invalid requests, network
        /// or service failures can cause exceptions even after the first results have been returned.
        /// </para>
        /// </remarks>
        /// <param name="datasetId">The ID of the dataset to list tables from. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A sequence of tables within the dataset.</returns>
        public virtual PagedEnumerable<TableList, BigQueryTable> ListTables(string datasetId, ListTablesOptions options = null) =>
            ListTables(GetDatasetReference(datasetId), options);

        /// <summary>
        /// Lists the tables in a dataset.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The returned tables will not have all the properties in the resource populated. For complete information, make a GetTable
        /// call for each table you need the details of.
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
        public virtual PagedEnumerable<TableList, BigQueryTable> ListTables(DatasetReference datasetReference, ListTablesOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists the tables in a dataset specified by project ID and dataset ID.
        /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="ListTablesAsync(DatasetReference, ListTablesOptions)"/>.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The returned tables will not have all the properties in the resource populated. For complete information, make a GetTable
        /// call for each table you need the details of.
        /// </para>
        /// <para>
        /// No network requests are made until the returned sequence is enumerated.
        /// This means that any exception due to an invalid request will be deferred until that time. Callers should be prepared
        /// for exceptions to be thrown while enumerating the results. In addition to failures due to invalid requests, network
        /// or service failures can cause exceptions even after the first results have been returned.
        /// </para>
        /// </remarks>
        /// <param name="projectId">The ID of the project containing the dataset. Must not be null.</param>
        /// <param name="datasetId">The ID of the dataset to list tables from. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>An asynchronous sequence of tables within the dataset.</returns>
        public virtual PagedAsyncEnumerable<TableList, BigQueryTable> ListTablesAsync(string projectId, string datasetId, ListTablesOptions options = null) =>
            ListTablesAsync(GetDatasetReference(projectId, datasetId), options);

        /// <summary>
        /// Lists the tables in a dataset specified by dataset ID, where the dataset is in this client's project.
        /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="ListTablesAsync(DatasetReference, ListTablesOptions)"/>.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The returned tables will not have all the properties in the resource populated. For complete information, make a GetTable
        /// call for each table you need the details of.
        /// </para>
        /// <para>
        /// No network requests are made until the returned sequence is enumerated.
        /// This means that any exception due to an invalid request will be deferred until that time. Callers should be prepared
        /// for exceptions to be thrown while enumerating the results. In addition to failures due to invalid requests, network
        /// or service failures can cause exceptions even after the first results have been returned.
        /// </para>
        /// </remarks>
        /// <param name="datasetId">The ID of the dataset to list tables from. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>An asynchronous sequence of tables within the dataset.</returns>
        public virtual PagedAsyncEnumerable<TableList, BigQueryTable> ListTablesAsync(string datasetId, ListTablesOptions options = null) =>
            ListTablesAsync(GetDatasetReference(datasetId), options);

        /// <summary>
        /// Lists the tables in a dataset.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The returned tables will not have all the properties in the resource populated. For complete information, make a GetTable
        /// call for each table you need the details of.
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
        public virtual PagedAsyncEnumerable<TableList, BigQueryTable> ListTablesAsync(DatasetReference datasetReference, ListTablesOptions options = null)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
