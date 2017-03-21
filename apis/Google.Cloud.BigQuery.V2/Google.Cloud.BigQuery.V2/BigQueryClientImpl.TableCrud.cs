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
using static Google.Apis.Bigquery.v2.TablesResource;

namespace Google.Cloud.BigQuery.V2
{
    public partial class BigQueryClientImpl
    {
        private sealed class TablePageManager : IPageManager<ListRequest, TableList, BigQueryTable>
        {
            private readonly BigQueryClient _client;

            internal TablePageManager(BigQueryClient client)
            {
                _client = client;
            }

            public string GetNextPageToken(TableList response) => response.NextPageToken;
            public IEnumerable<BigQueryTable> GetResources(TableList response) => response.Tables?.Select(resource => new BigQueryTable(_client, resource));
            public void SetPageSize(ListRequest request, int pageSize) => request.MaxResults = pageSize;
            public void SetPageToken(ListRequest request, string pageToken) => request.PageToken = pageToken;
        }

        /// <inheritdoc />
        public override BigQueryTable GetTable(TableReference tableReference, GetTableOptions options = null)
        {
            GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));

            var request = Service.Tables.Get(tableReference.ProjectId, tableReference.DatasetId, tableReference.TableId);
            request.ModifyRequest += _versionHeaderAction;
            options?.ModifyRequest(request);
            var resource = request.Execute();
            return new BigQueryTable(this, resource);
        }

        /// <inheritdoc />
        public override PagedEnumerable<TableList, BigQueryTable> ListTables(DatasetReference datasetReference, ListTablesOptions options = null)
        {
            GaxPreconditions.CheckNotNull(datasetReference, nameof(datasetReference));

            var pageManager = new TablePageManager(this);
            return new RestPagedEnumerable<ListRequest, TableList, BigQueryTable>(
                () => CreateListTablesRequest(datasetReference, options),
                pageManager);
        }

        /// <inheritdoc />
        private ListRequest CreateListTablesRequest(DatasetReference datasetReference, ListTablesOptions options)
        {
            var request = Service.Tables.List(datasetReference.ProjectId, datasetReference.DatasetId);
            request.ModifyRequest += _versionHeaderAction;
            options?.ModifyRequest(request);
            return request;
        }

        /// <inheritdoc />
        public override BigQueryTable CreateTable(TableReference tableReference, TableSchema schema, CreateTableOptions options = null)
        {
            GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));

            var table = new Table { TableReference = tableReference, Schema = schema };
            var request = Service.Tables.Insert(table, tableReference.ProjectId, tableReference.DatasetId);
            request.ModifyRequest += _versionHeaderAction;
            options?.ModifyRequest(table, request);
            var result = request.Execute();
            return new BigQueryTable(this, result);
        }

        /// <inheritdoc />
        public override BigQueryTable GetOrCreateTable(TableReference tableReference, TableSchema schema, GetTableOptions getOptions = null, CreateTableOptions createOptions = null)
        {
            GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));

            try
            {
                // TODO: Validate the schema matches?
                return GetTable(tableReference, getOptions);
            }
            catch (GoogleApiException ex) when (ex.HttpStatusCode == HttpStatusCode.NotFound)
            {
                return CreateTable(tableReference, schema, createOptions);
            }
        }

        /// <inheritdoc />
        public override void DeleteTable(TableReference tableReference, DeleteTableOptions options = null)
        {
            GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));
            var request = Service.Tables.Delete(tableReference.ProjectId, tableReference.DatasetId, tableReference.TableId);
            request.ModifyRequest += _versionHeaderAction;
            options?.ModifyRequest(request);
            request.Execute();
        }

        /// <inheritdoc />
        public override async Task<BigQueryTable> GetTableAsync(TableReference tableReference, GetTableOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));

            var request = Service.Tables.Get(tableReference.ProjectId, tableReference.DatasetId, tableReference.TableId);
            request.ModifyRequest += _versionHeaderAction;
            options?.ModifyRequest(request);
            var resource = await request.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            return new BigQueryTable(this, resource);
        }

        /// <inheritdoc />
        public override PagedAsyncEnumerable<TableList, BigQueryTable> ListTablesAsync(DatasetReference datasetReference, ListTablesOptions options = null)
        {
            GaxPreconditions.CheckNotNull(datasetReference, nameof(datasetReference));

            var pageManager = new TablePageManager(this);
            return new RestPagedAsyncEnumerable<ListRequest, TableList, BigQueryTable>(
                () => CreateListTablesRequest(datasetReference, options),
                pageManager);
        }

        /// <inheritdoc />
        public override async Task<BigQueryTable> CreateTableAsync(TableReference tableReference, TableSchema schema,
            CreateTableOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));

            var table = new Table { TableReference = tableReference, Schema = schema };
            var request = Service.Tables.Insert(table, tableReference.ProjectId, tableReference.DatasetId);
            request.ModifyRequest += _versionHeaderAction;
            options?.ModifyRequest(table, request);
            var result = await request.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            return new BigQueryTable(this, result);
        }

        /// <inheritdoc />
        public override async Task<BigQueryTable> GetOrCreateTableAsync(TableReference tableReference, TableSchema schema,
            GetTableOptions getOptions = null, CreateTableOptions createOptions = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));

            try
            {
                // TODO: Validate the schema matches?
                return await GetTableAsync(tableReference, getOptions, cancellationToken).ConfigureAwait(false);
            }
            catch (GoogleApiException ex) when (ex.HttpStatusCode == HttpStatusCode.NotFound)
            {
                return await CreateTableAsync(tableReference, schema, createOptions, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc />
        public override async Task DeleteTableAsync(TableReference tableReference, DeleteTableOptions options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));
            var request = Service.Tables.Delete(tableReference.ProjectId, tableReference.DatasetId, tableReference.TableId);
            request.ModifyRequest += _versionHeaderAction;
            options?.ModifyRequest(request);
            await request.ExecuteAsync(cancellationToken).ConfigureAwait(false);
        }

    }
}
