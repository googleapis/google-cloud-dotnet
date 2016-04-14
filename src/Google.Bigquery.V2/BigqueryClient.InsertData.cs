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

using Google.Apis.Bigquery.v2.Data;
using System;
using System.Collections.Generic;
using System.IO;

namespace Google.Bigquery.V2
{
    public abstract partial class BigqueryClient
    {
        /// <summary>
        /// Uploads a stream of CSV data to a table specified by project ID, dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadCsv(TableReference, TableSchema, Stream)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <returns>A data upload job.</returns>
        public virtual Job UploadCsv(string projectId, string datasetId, string tableId, TableSchema schema, Stream input) =>
            UploadCsv(GetTableReference(projectId, datasetId, tableId), schema, input);

        /// <summary>
        /// Uploads a stream of CSV data to a table in this project specified by dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadCsv(TableReference, TableSchema, Stream)"/>.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <returns>A data upload job.</returns>
        public virtual Job UploadCsv(string datasetId, string tableId, TableSchema schema, Stream input) =>
            UploadCsv(GetTableReference(datasetId, tableId), schema, input);

        /// <summary>
        /// Uploads a stream of CSV data to a table.
        /// </summary>
        /// /// <param name="datasetReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <returns>A data upload job.</returns>
        public virtual Job UploadCsv(TableReference tableReference, TableSchema schema, Stream input)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Uploads a stream of JSON data to a table specified by project ID, dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadJson(TableReference, TableSchema, Stream)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <returns>A data upload job.</returns>
        public virtual Job UploadJson(string projectId, string datasetId, string tableId, TableSchema schema, Stream input) =>
            UploadCsv(GetTableReference(projectId, datasetId, tableId), schema, input);

        /// <summary>
        /// Uploads a stream of JSON data to a table in this client's project specified by dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="UploadJson(TableReference, TableSchema, Stream)"/>.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <returns>A data upload job.</returns>
        public virtual Job UploadJson(string datasetId, string tableId, TableSchema schema, Stream input) =>
            UploadCsv(GetTableReference(datasetId, tableId), schema, input);

        /// <summary>
        /// Uploads a stream of JSON data to a table.
        /// </summary>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="schema">The schema of the data. May be null if the table already exists, in which case the table schema will be fetched and used.</param>
        /// <param name="input">The stream of input data. Must not be null.</param>
        /// <returns>A data upload job.</returns>
        public virtual Job UploadJson(TableReference tableReference, TableSchema schema, Stream input)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Inserts a single row of data into a table specified by project ID, dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="InsertRow(TableReference, IDictionary{string, object}, string)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="rowData">The data to insert. Must not be null.</param>
        /// <param name="insertId">The ID for the insertion, used to avoid data duplication. May be null.</param>
        public virtual void InsertRow(string projectId, string datasetId, string tableId, IDictionary<string, object> rowData, string insertId = null) =>
            InsertRow(GetTableReference(projectId, datasetId, tableId), rowData, insertId);

        /// <summary>
        /// Inserts a single row of data into a table in this client's project specified by dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="InsertRow(TableReference, IDictionary{string, object}, string)"/>.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="rowData">The data to insert. Must not be null.</param>
        /// <param name="insertId">The ID for the insertion, used to avoid data duplication. May be null.</param>
        public virtual void InsertRow(string datasetId, string tableId, IDictionary<string, object> rowData, string insertId = null) =>
            InsertRow(GetTableReference(datasetId, tableId), rowData, insertId);

        /// <summary>
        /// Inserts a single row of data into a table.
        /// </summary>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="rowData">The data to insert. Must not be null.</param>
        /// <param name="insertId">The ID for the insertion, used to avoid data duplication. May be null.</param>
        public virtual void InsertRow(TableReference tableReference, IDictionary<string, object> rowData, string insertId = null)
        {
            throw new NotImplementedException();
        }

        // TODO: Insert IDs? Perhaps have a special key within the dictionary? Or an InsertRow type.
        // TODO: Is it useful to have two methods here, or should we just have 1? If inserting a single row is very common,
        // it may make things simpler.

        /// <summary>
        /// Inserts all the given rows of data into a table specified by project ID, dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="InsertRows(TableReference, IEnumerable{IDictionary{string, object}})"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="rowData">The data to insert. Must not be null.</param>
        public virtual void InsertRows(string projectId, string datasetId, string tableId, IEnumerable<IDictionary<string, object>> rowData) =>
            InsertRows(GetTableReference(projectId, datasetId, tableId), rowData);

        /// <summary>
        /// Inserts all the given rows of data into a table in this client's project specified by dataset ID and table ID.
        /// This method just creates a <see cref="TableReference"/> and delegates to <see cref="InsertRows(TableReference, IEnumerable{IDictionary{string, object}})"/>.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <param name="rowData">The data to insert. Must not be null.</param>
        public virtual void InsertRows(string datasetId, string tableId, IEnumerable<IDictionary<string, object>> rowData) =>
            InsertRows(GetTableReference(datasetId, tableId), rowData);

        /// <summary>
        /// Inserts all the given rows of data into a table.
        /// </summary>
        /// <param name="tableReference">A fully-qualified identifier for the table. Must not be null.</param>
        /// <param name="rowData">The data to insert. Must not be null.</param>
        public virtual void InsertRows(TableReference tableReference, IEnumerable<IDictionary<string, object>> rowData)
        {
            throw new NotImplementedException();
        }
    }
}
