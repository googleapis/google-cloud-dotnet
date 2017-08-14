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
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.BigQuery.V2
{
    public abstract partial class BigQueryClient
    {
        #region GetTable
        /// <summary>
        /// Retrieves a table given a project ID, dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="GetTable(TableReference,GetTableOptions)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The requested table.</returns>
        public virtual BigQueryTable GetTable(string projectId, string datasetId, string tableId, GetTableOptions options = null) =>
            GetTable(GetTableReference(projectId, datasetId, tableId), options);

        /// <summary>
        /// Retrieves a table within this client's project given the dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="GetTable(TableReference,GetTableOptions)"/>.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The requested table.</returns>
        public virtual BigQueryTable GetTable(string datasetId, string tableId, GetTableOptions options = null) =>
            GetTable(GetTableReference(datasetId, tableId), options);

        /// <summary>
        /// Retrieves a table.
        /// </summary>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The requested table.</returns>
        public virtual BigQueryTable GetTable(TableReference tableReference, GetTableOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieves a table given a project ID, dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="GetTableAsync(TableReference,GetTableOptions,CancellationToken)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the requested table.</returns>
        public virtual Task<BigQueryTable> GetTableAsync(string projectId, string datasetId, string tableId, GetTableOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            GetTableAsync(GetTableReference(projectId, datasetId, tableId), options, cancellationToken);

        /// <summary>
        /// Retrieves a table within this client's project given the dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="GetTableAsync(TableReference,GetTableOptions,CancellationToken)"/>.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the requested table.</returns>
        public virtual Task<BigQueryTable> GetTableAsync(string datasetId, string tableId, GetTableOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            GetTableAsync(GetTableReference(datasetId, tableId), options, cancellationToken);

        /// <summary>
        /// Retrieves a table.
        /// </summary>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the requested table.</returns>
        public virtual Task<BigQueryTable> GetTableAsync(TableReference tableReference, GetTableOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }
        #endregion

        #region ListTables
        /// <summary>
        /// Lists the tables in a dataset specified by project ID and dataset ID.
        /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="ListTables(DatasetReference, ListTablesOptions)"/>.
        /// </summary>
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
        /// <param name="datasetId">The ID of the dataset to list tables from. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A sequence of tables within the dataset.</returns>
        public virtual PagedEnumerable<TableList, BigQueryTable> ListTables(string datasetId, ListTablesOptions options = null) =>
            ListTables(GetDatasetReference(datasetId), options);

        /// <summary>
        /// Lists the tables in a dataset.
        /// </summary>
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
        /// <param name="datasetId">The ID of the dataset to list tables from. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>An asynchronous sequence of tables within the dataset.</returns>
        public virtual PagedAsyncEnumerable<TableList, BigQueryTable> ListTablesAsync(string datasetId, ListTablesOptions options = null) =>
            ListTablesAsync(GetDatasetReference(datasetId), options);

        /// <summary>
        /// Lists the tables in a dataset.
        /// </summary>
        /// <param name="datasetReference">A fully-qualified identifier for the dataset. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A sequence of tables within the dataset.</returns>
        public virtual PagedAsyncEnumerable<TableList, BigQueryTable> ListTablesAsync(DatasetReference datasetReference, ListTablesOptions options = null)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region CreateTable
        /// <summary>
        /// Creates a table specified by a project ID, dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="CreateTable(TableReference, TableSchema, CreateTableOptions)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema for the new table. Must not be null unless the schema can be inferred (e.g. for a view).</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The newly created table.</returns>
        public virtual BigQueryTable CreateTable(string projectId, string datasetId, string tableId, TableSchema schema, CreateTableOptions options = null) =>
            CreateTable(GetTableReference(projectId, datasetId, tableId), schema, options);

        /// <summary>
        /// Creates a table within this project, specified by a dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="CreateTable(TableReference, TableSchema, CreateTableOptions)"/>.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema for the new table. Must not be null unless the schema can be inferred (e.g. for a view).</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The newly created table.</returns>
        public virtual BigQueryTable CreateTable(string datasetId, string tableId, TableSchema schema, CreateTableOptions options = null) =>
            CreateTable(GetTableReference(datasetId, tableId), schema, options);

        /// <summary>
        /// Creates a table with the given schema.
        /// </summary>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="schema">The schema for the new table. Must not be null unless the schema can be inferred (e.g. for a view).</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The newly created table.</returns>
        public virtual BigQueryTable CreateTable(TableReference tableReference, TableSchema schema, CreateTableOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a table specified by a project ID, dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="CreateTableAsync(TableReference, TableSchema, CreateTableOptions,CancellationToken)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema for the new table. Must not be null unless the schema can be inferred (e.g. for a view).</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the newly created table.</returns>
        public virtual Task<BigQueryTable> CreateTableAsync(string projectId, string datasetId, string tableId, TableSchema schema, CreateTableOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            CreateTableAsync(GetTableReference(projectId, datasetId, tableId), schema, options, cancellationToken);

        /// <summary>
        /// Creates a table within this project, specified by a dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="CreateTableAsync(TableReference, TableSchema, CreateTableOptions,CancellationToken)"/>.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema for the new table. Must not be null unless the schema can be inferred (e.g. for a view).</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the newly created table.</returns>
        public virtual Task<BigQueryTable> CreateTableAsync(string datasetId, string tableId, TableSchema schema, CreateTableOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            CreateTableAsync(GetTableReference(datasetId, tableId), schema, options, cancellationToken);

        /// <summary>
        /// Creates a table with the given schema.
        /// </summary>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="schema">The schema for the new table. Must not be null unless the schema can be inferred (e.g. for a view).</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the newly created table.</returns>
        public virtual Task<BigQueryTable> CreateTableAsync(TableReference tableReference, TableSchema schema, CreateTableOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }
        #endregion

        #region GetOrCreateTable
        /// <summary>
        /// Attempts to fetch a table specified by project ID, dataset ID and table ID, creating it if it doesn't exist.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="GetOrCreateTable(TableReference, TableSchema, GetTableOptions, CreateTableOptions)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="getOptions">The options for the "get" operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="createOptions">The options for the "create" operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="schema">The schema to use to create the table if necessary. Must not be null unless the schema can be inferred (e.g. for a view).</param>
        /// <returns>The existing or new table.</returns>
        public virtual BigQueryTable GetOrCreateTable(string projectId, string datasetId, string tableId, TableSchema schema,
            GetTableOptions getOptions = null, CreateTableOptions createOptions = null) =>
            GetOrCreateTable(GetTableReference(projectId, datasetId, tableId), schema, getOptions, createOptions);

        /// <summary>
        /// Attempts to fetch the specified table within this client's project, creating it if it doesn't exist.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="GetOrCreateTable(TableReference, TableSchema, GetTableOptions, CreateTableOptions)"/>.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema to use to create the table if necessary. Must not be null unless the schema can be inferred (e.g. for a view).</param>
        /// <param name="getOptions">The options for the "get" operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="createOptions">The options for the "create" operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The existing or new table.</returns>
        public virtual BigQueryTable GetOrCreateTable(string datasetId, string tableId, TableSchema schema,
            GetTableOptions getOptions = null, CreateTableOptions createOptions = null) =>
            GetOrCreateTable(GetTableReference(datasetId, tableId), schema, getOptions, createOptions);

        /// <summary>
        /// Attempts to fetch a table, creating it if it doesn't exist.
        /// </summary>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="schema">The schema to use to create the table if necessary. Must not be null unless the schema can be inferred (e.g. for a view).</param>
        /// <param name="getOptions">The options for the "get" operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="createOptions">The options for the "create" operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The existing or new table.</returns>
        public virtual BigQueryTable GetOrCreateTable(TableReference tableReference, TableSchema schema,
            GetTableOptions getOptions = null, CreateTableOptions createOptions = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Attempts to fetch a table specified by project ID, dataset ID and table ID, creating it if it doesn't exist.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="GetOrCreateTableAsync(TableReference, TableSchema, GetTableOptions, CreateTableOptions,CancellationToken)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema to use to create the table if necessary. Must not be null unless the schema can be inferred (e.g. for a view).</param>
        /// <param name="getOptions">The options for the "get" operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="createOptions">The options for the "create" operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the existing or new table.</returns>
        public virtual Task<BigQueryTable> GetOrCreateTableAsync(string projectId, string datasetId, string tableId, TableSchema schema,
            GetTableOptions getOptions = null, CreateTableOptions createOptions = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            GetOrCreateTableAsync(GetTableReference(projectId, datasetId, tableId), schema, getOptions, createOptions, cancellationToken);

        /// <summary>
        /// Attempts to fetch the specified table within this client's project, creating it if it doesn't exist.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="GetOrCreateTableAsync(TableReference, TableSchema, GetTableOptions, CreateTableOptions,CancellationToken)"/>.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema to use to create the table if necessary. Must not be null unless the schema can be inferred (e.g. for a view).</param>
        /// <param name="getOptions">The options for the "get" operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="createOptions">The options for the "create" operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the existing or new table.</returns>
        public virtual Task<BigQueryTable> GetOrCreateTableAsync(string datasetId, string tableId, TableSchema schema,
            GetTableOptions getOptions = null, CreateTableOptions createOptions = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            GetOrCreateTableAsync(GetTableReference(datasetId, tableId), schema, getOptions, createOptions, cancellationToken);

        /// <summary>
        /// Attempts to fetch a table, creating it if it doesn't exist.
        /// </summary>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="schema">The schema to use to create the table if necessary. Must not be null unless the schema can be inferred (e.g. for a view).</param>
        /// <param name="getOptions">The options for the "get" operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="createOptions">The options for the "create" operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the existing or new table.</returns>
        public virtual Task<BigQueryTable> GetOrCreateTableAsync(TableReference tableReference, TableSchema schema,
            GetTableOptions getOptions = null, CreateTableOptions createOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }
        #endregion

        #region DeleteTable
        /// <summary>
        /// Deletes a table specified by project ID, dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="DeleteTable(TableReference,DeleteTableOptions)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        public virtual void DeleteTable(string projectId, string datasetId, string tableId, DeleteTableOptions options = null) =>
            DeleteTable(GetTableReference(projectId, datasetId, tableId), options);

        /// <summary>
        /// Deletes a table within this project specified by dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="DeleteTable(TableReference,DeleteTableOptions)"/>.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        public virtual void DeleteTable(string datasetId, string tableId, DeleteTableOptions options = null) =>
            DeleteTable(GetTableReference(datasetId, tableId), options);

        /// <summary>
        /// Deletes a table.
        /// </summary>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        public virtual void DeleteTable(TableReference tableReference, DeleteTableOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a table specified by project ID, dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="DeleteTableAsync(TableReference,DeleteTableOptions,CancellationToken)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public virtual Task DeleteTableAsync(string projectId, string datasetId, string tableId, DeleteTableOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            DeleteTableAsync(GetTableReference(projectId, datasetId, tableId), options, cancellationToken);

        /// <summary>
        /// Deletes a table within this project specified by dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="DeleteTableAsync(TableReference,DeleteTableOptions,CancellationToken)"/>.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public virtual Task DeleteTableAsync(string datasetId, string tableId, DeleteTableOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            DeleteTableAsync(GetTableReference(datasetId, tableId), options, cancellationToken);

        /// <summary>
        /// Deletes a table.
        /// </summary>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public virtual Task DeleteTableAsync(TableReference tableReference, DeleteTableOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }
        #endregion

        #region UpdateTable
        /// <summary>
        /// Updates the specified table to match the given resource.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UpdateTable(TableReference, Table, UpdateTableOptions)"/>.
        /// </summary>
        /// <remarks>
        /// If the resource contains an ETag, it is used for optimistic concurrency validation.
        /// </remarks>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="resource">The table resource representation to use for the update. All updatable fields will be updated.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The updated table.</returns>
        public virtual BigQueryTable UpdateTable(string projectId, string datasetId, string tableId, Table resource, UpdateTableOptions options = null) =>
            UpdateTable(GetTableReference(projectId, datasetId, tableId), resource, options);

        /// <summary>
        /// Updates the specified table within this client's project to match the given resource.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UpdateTable(TableReference, Table, UpdateTableOptions)"/>.
        /// </summary>
        /// <remarks>
        /// If the resource contains an ETag, it is used for optimistic concurrency validation.
        /// </remarks>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="resource">The table resource representation to use for the update. All updatable fields will be updated.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The updated table.</returns>
        public virtual BigQueryTable UpdateTable(string datasetId, string tableId, Table resource, UpdateTableOptions options = null) =>
            UpdateTable(GetTableReference(datasetId, tableId), resource, options);

        /// <summary>
        /// Updates the specified table to match the given resource.
        /// </summary>
        /// <remarks>
        /// If the resource contains an ETag, it is used for optimistic concurrency validation.
        /// </remarks>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="resource">The table resource representation to use for the update. All updatable fields will be updated.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The updated table.</returns>
        public virtual BigQueryTable UpdateTable(TableReference tableReference, Table resource, UpdateTableOptions options = null) =>
            throw new NotImplementedException();

        /// <summary>
        /// Asynchronously updates the specified table to match the given resource.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UpdateTableAsync(TableReference, Table, UpdateTableOptions, CancellationToken)"/>.
        /// </summary>
        /// <remarks>
        /// If the resource contains an ETag, it is used for optimistic concurrency validation.
        /// </remarks>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="resource">The table resource representation to use for the update. All updatable fields will be updated.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the updated table.</returns>
        public virtual Task<BigQueryTable> UpdateTableAsync(string projectId, string datasetId, string tableId, Table resource, UpdateTableOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            UpdateTableAsync(GetTableReference(projectId, datasetId, tableId), resource, options, cancellationToken);

        /// <summary>
        /// Asynchronously updates the specified table within this client's project to match the given resource.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UpdateTableAsync(TableReference, Table, UpdateTableOptions, CancellationToken)"/>.
        /// </summary>
        /// <remarks>
        /// If the resource contains an ETag, it is used for optimistic concurrency validation.
        /// </remarks>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="resource">The table resource representation to use for the update. All updatable fields will be updated.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the updated table.</returns>
        public virtual Task<BigQueryTable> UpdateTableAsync(string datasetId, string tableId, Table resource, UpdateTableOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            UpdateTableAsync(GetTableReference(datasetId, tableId), resource, options, cancellationToken);

        /// <summary>
        /// Asynchronously updates the specified table to match the given resource.
        /// </summary>
        /// <remarks>
        /// If the resource contains an ETag, it is used for optimistic concurrency validation.
        /// </remarks>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="resource">The table resource representation to use for the update. All updatable fields will be updated.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the updated table.</returns>
        public virtual Task<BigQueryTable> UpdateTableAsync(TableReference tableReference, Table resource, UpdateTableOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            throw new NotImplementedException();
        #endregion

        #region PatchTable
        /// <summary>
        /// Patches the specified table with fields in the given resource.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="PatchTable(TableReference, Table, PatchTableOptions)"/>.
        /// </summary>
        /// <remarks>
        /// If the resource contains an ETag, it is used for optimistic concurrency validation.
        /// </remarks>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="resource">The table resource representation to use for the patch. Only fields present in the resource will be updated.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The updated table.</returns>
        public virtual BigQueryTable PatchTable(string projectId, string datasetId, string tableId, Table resource, PatchTableOptions options = null) =>
            PatchTable(GetTableReference(projectId, datasetId, tableId), resource, options);

        /// <summary>
        /// Patches the specified table within this client's project with fields in the given resource.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="PatchTable(TableReference, Table, PatchTableOptions)"/>.
        /// </summary>
        /// <remarks>
        /// If the resource contains an ETag, it is used for optimistic concurrency validation.
        /// </remarks>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="resource">The table resource representation to use for the patch. Only fields present in the resource will be updated.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The updated table.</returns>
        public virtual BigQueryTable PatchTable(string datasetId, string tableId, Table resource, PatchTableOptions options = null) =>
            PatchTable(GetTableReference(datasetId, tableId), resource, options);

        /// <summary>
        /// Patches the specified table with fields in the given resource.
        /// </summary>
        /// <remarks>
        /// If the resource contains an ETag, it is used for optimistic concurrency validation.
        /// </remarks>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="resource">The table resource representation to use for the patch. Only fields present in the resource will be updated.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The updated table.</returns>
        public virtual BigQueryTable PatchTable(TableReference tableReference, Table resource, PatchTableOptions options = null) =>
            throw new NotImplementedException();

        /// <summary>
        /// Asynchronously patches the specified table with fields in the given resource.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="PatchTableAsync(TableReference, Table, PatchTableOptions, CancellationToken)"/>.
        /// </summary>
        /// <remarks>
        /// If the resource contains an ETag, it is used for optimistic concurrency validation.
        /// </remarks>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="resource">The table resource representation to use for the patch. Only fields present in the resource will be updated.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the updated table.</returns>
        public virtual Task<BigQueryTable> PatchTableAsync(string projectId, string datasetId, string tableId, Table resource, PatchTableOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            PatchTableAsync(GetTableReference(projectId, datasetId, tableId), resource, options, cancellationToken);

        /// <summary>
        /// Asynchronously patches the specified table within this client's project with fields in the given resource.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="PatchTableAsync(TableReference, Table, PatchTableOptions, CancellationToken)"/>.
        /// </summary>
        /// <remarks>
        /// If the resource contains an ETag, it is used for optimistic concurrency validation.
        /// </remarks>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="resource">The table resource representation to use for the patch. Only fields present in the resource will be updated.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the updated table.</returns>
        public virtual Task<BigQueryTable> PatchTableAsync(string datasetId, string tableId, Table resource, PatchTableOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            PatchTableAsync(GetTableReference(datasetId, tableId), resource, options, cancellationToken);

        /// <summary>
        /// Asynchronously patches the specified table with fields in the given resource.
        /// </summary>
        /// <remarks>
        /// If the resource contains an ETag, it is used for optimistic concurrency validation.
        /// </remarks>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="resource">The table resource representation to use for the patch. Only fields present in the resource will be updated.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the updated table.</returns>
        public virtual Task<BigQueryTable> PatchTableAsync(TableReference tableReference, Table resource, PatchTableOptions options = null, CancellationToken cancellationToken = default(CancellationToken)) =>
            throw new NotImplementedException();
        #endregion
    }
}
