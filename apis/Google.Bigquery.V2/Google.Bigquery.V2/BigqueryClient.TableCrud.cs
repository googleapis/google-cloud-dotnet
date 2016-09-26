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

using Google.Api.Gax.Rest;
using Google.Apis.Bigquery.v2.Data;
using System;
using System.Collections.Generic;

namespace Google.Bigquery.V2
{
    public abstract partial class BigqueryClient
    {
        /// <summary>
        /// Retrieves a table given a project ID, dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="GetTable(TableReference,GetTableOptions)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The requested dataset.</returns>
        public virtual BigqueryTable GetTable(string projectId, string datasetId, string tableId, GetTableOptions options = null) =>
            GetTable(GetTableReference(projectId, datasetId, tableId), options);

        /// <summary>
        /// Retrieves a table within this client's project given the dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="GetTable(TableReference,GetTableOptions)"/>.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The requested dataset.</returns>
        public virtual BigqueryTable GetTable(string datasetId, string tableId, GetTableOptions options = null) =>
            GetTable(GetTableReference(datasetId, tableId), options);

        /// <summary>
        /// Retrieves a table.
        /// </summary>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The requested table.</returns>
        public virtual BigqueryTable GetTable(TableReference tableReference, GetTableOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists the tables in a dataset specified by project ID and dataset ID.
        /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="ListTables(DatasetReference, ListTablesOptions)"/>.
        /// </summary>
        /// <param name="projectId">The ID of the project containing the dataset. Must not be null.</param>
        /// <param name="datasetId">The ID of the dataset to list tables from. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A sequence of pages of tables within the dataset.</returns>
        public virtual IPagedEnumerable<TableList, BigqueryTable> ListTables(string projectId, string datasetId, ListTablesOptions options = null) =>
            ListTables(GetDatasetReference(projectId, datasetId), options);

        /// <summary>
        /// Lists the tables in a dataset specified by dataset ID, where the dataset is in this client's project.
        /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="ListTables(DatasetReference, ListTablesOptions)"/>.
        /// </summary>
        /// <param name="datasetId">The ID of the dataset to list tables from. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A sequence of pages of tables within the dataset.</returns>
        public virtual IPagedEnumerable<TableList, BigqueryTable> ListTables(string datasetId, ListTablesOptions options = null) =>
            ListTables(GetDatasetReference(datasetId), options);

        /// <summary>
        /// Lists the tables in a dataset.
        /// </summary>
        /// <param name="datasetReference">A fully-qualified identifier for the dataset. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>A sequence of pages of tables within the dataset.</returns>
        public virtual IPagedEnumerable<TableList, BigqueryTable> ListTables(DatasetReference datasetReference, ListTablesOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a table specified by a project ID, dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="CreateTable(TableReference, TableSchema, CreateTableOptions)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema for the new table. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The newly created table.</returns>
        public virtual BigqueryTable CreateTable(string projectId, string datasetId, string tableId, TableSchema schema, CreateTableOptions options = null) =>
            CreateTable(GetTableReference(projectId, datasetId, tableId), schema, options);

        /// <summary>
        /// Creates a table within this project, specified by a dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="CreateTable(TableReference, TableSchema, CreateTableOptions)"/>.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema for the new table. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The newly created table.</returns>
        public virtual BigqueryTable CreateTable(string datasetId, string tableId, TableSchema schema, CreateTableOptions options = null) =>
            CreateTable(GetTableReference(datasetId, tableId), schema, options);

        /// <summary>
        /// Creates a table with the given schema.
        /// </summary>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="schema">The schema for the new table. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The newly created table.</returns>
        public virtual BigqueryTable CreateTable(TableReference tableReference, TableSchema schema, CreateTableOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Attempts to fetch a table specified by project ID, dataset ID and table ID, creating it if it doesn't exist.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="GetOrCreateTable(TableReference, TableSchema, GetTableOptions, CreateTableOptions)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="getOptions">The options for the "get" operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="createOptions">The options for the "create" operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="schema">The schema to use to create the table if necessary. Must not be null.</param>
        /// <returns>The existing or new table.</returns>
        public virtual BigqueryTable GetOrCreateTable(string projectId, string datasetId, string tableId, TableSchema schema,
            GetTableOptions getOptions = null, CreateTableOptions createOptions = null) =>
            GetOrCreateTable(GetTableReference(projectId, datasetId, tableId), schema, getOptions, createOptions);

        /// <summary>
        /// Attempts to fetch the specified table within this client's project, creating it if it doesn't exist.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="GetOrCreateTable(TableReference, TableSchema, GetTableOptions, CreateTableOptions)"/>.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema to use to create the table if necessary. Must not be null.</param>
        /// <param name="getOptions">The options for the "get" operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="createOptions">The options for the "create" operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The existing or new table.</returns>
        public virtual BigqueryTable GetOrCreateTable(string datasetId, string tableId, TableSchema schema,
            GetTableOptions getOptions = null, CreateTableOptions createOptions = null) =>
            GetOrCreateTable(GetTableReference(datasetId, tableId), schema, getOptions, createOptions);

        /// <summary>
        /// Attempts to fetch a table, creating it if it doesn't exist.
        /// </summary>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="schema">The schema to use to create the table if necessary. Must not be null.</param>
        /// <param name="getOptions">The options for the "get" operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="createOptions">The options for the "create" operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The existing or new table.</returns>
        public virtual BigqueryTable GetOrCreateTable(TableReference tableReference, TableSchema schema,
            GetTableOptions getOptions = null, CreateTableOptions createOptions = null)
        {
            throw new NotImplementedException();
        }

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
    }
}
