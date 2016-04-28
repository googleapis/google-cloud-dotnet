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
        private static readonly PageStreamer<TableList.TablesData, TablesResource.ListRequest, TableList, string> s_tablesPageStreamer =
            new PageStreamer<TableList.TablesData, TablesResource.ListRequest, TableList, string>(
                (request, token) => request.PageToken = token,
                response => response.NextPageToken,
                response => response.Tables);


        /// <inheritdoc />
        public override BigqueryTable GetTable(TableReference tableReference)
        {
            Preconditions.CheckNotNull(tableReference, nameof(tableReference));

            var resource = Service.Tables.Get(tableReference.ProjectId, tableReference.DatasetId, tableReference.TableId).Execute();
            return new BigqueryTable(this, resource);
        }

        /// <inheritdoc />
        public override IEnumerable<BigqueryTable> ListTables(DatasetReference datasetReference, ListTablesOptions options = null)
        {
            Preconditions.CheckNotNull(datasetReference, nameof(datasetReference));

            var initialRequest = CreateListTablesRequest(datasetReference, options);
            return s_tablesPageStreamer.Fetch(initialRequest).Select(apiResource => new BigqueryTable(this, apiResource));
        }

        /// <inheritdoc />
        private TablesResource.ListRequest CreateListTablesRequest(DatasetReference datasetReference, ListTablesOptions options)
        {
            var request = Service.Tables.List(datasetReference.ProjectId, datasetReference.DatasetId);
            options?.ModifyRequest(request);
            return request;
        }

        /// <inheritdoc />
        public override BigqueryTable CreateTable(TableReference tableReference, TableSchema schema)
        {
            Preconditions.CheckNotNull(tableReference, nameof(tableReference));

            var table = Service.Tables
                .Insert(new Table { TableReference = tableReference, Schema = schema }, tableReference.ProjectId, tableReference.DatasetId)
                .Execute();
            return new BigqueryTable(this, table);
        }

        /// <inheritdoc />
        public override BigqueryTable GetOrCreateTable(TableReference tableReference, TableSchema schema)
        {
            Preconditions.CheckNotNull(tableReference, nameof(tableReference));

            try
            {
                // TODO: Validate the schema matches?
                return GetTable(tableReference);
            }
            catch (GoogleApiException ex) when (ex.HttpStatusCode == HttpStatusCode.NotFound)
            {
                return CreateTable(tableReference, schema);
            }
        }

        /// <inheritdoc />
        public override void DeleteTable(TableReference tableReference)
        {
            Preconditions.CheckNotNull(tableReference, nameof(tableReference));

            Service.Tables.Delete(tableReference.ProjectId, tableReference.TableId, tableReference.TableId).Execute();
        }
    }
}
