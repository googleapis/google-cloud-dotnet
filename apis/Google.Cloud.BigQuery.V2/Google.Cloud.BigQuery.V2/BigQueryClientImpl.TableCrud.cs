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
        // Visible for testing
        internal sealed class TablePageManager : IPageManager<ListRequest, TableList, BigQueryTable>
        {
            private readonly BigQueryClient _client;

            internal TablePageManager(BigQueryClient client)
            {
                _client = client;
            }

            public string GetNextPageToken(TableList response) => response.NextPageToken;
            public IEnumerable<BigQueryTable> GetResources(TableList response) => response.Tables?.Select(resource => new BigQueryTable(_client, ConvertResource(resource)));
            public void SetPageSize(ListRequest request, int pageSize) => request.MaxResults = pageSize;
            public void SetPageToken(ListRequest request, string pageToken) => request.PageToken = pageToken;

            // Visible for testing

            /// <summary>
            /// Converts from the list representation of a table to the get/update/patch one, as far as possible.
            /// </summary>
            internal static Table ConvertResource(TableList.TablesData resource) =>
                new Table
                {
                    Clustering = resource.Clustering,
                    CreationTime = resource.CreationTime,
                    ExpirationTime = resource.ExpirationTime,
                    FriendlyName = resource.FriendlyName,
                    Id = resource.Id,
                    Kind = resource.Kind,
                    Labels = resource.Labels,
                    TimePartitioning = resource.TimePartitioning,
                    TableReference = resource.TableReference,
                    Type = resource.Type,
                    View = resource.View == null ? null : new ViewDefinition { UseLegacySql = resource.View.UseLegacySql }
                };
        }

        /// <inheritdoc />
        public override BigQueryTable GetTable(TableReference tableReference, GetTableOptions options = null)
        {
            var request = CreateGetTableRequest(tableReference, options);
            var resource = request.Execute();
            return new BigQueryTable(this, resource);
        }

        /// <inheritdoc />
        public override async Task<BigQueryTable> GetTableAsync(TableReference tableReference, GetTableOptions options = null, CancellationToken cancellationToken = default)
        {
            var request = CreateGetTableRequest(tableReference, options);
            var resource = await request.ExecuteAsync(cancellationToken).ConfigureAwait(false);
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
        public override PagedAsyncEnumerable<TableList, BigQueryTable> ListTablesAsync(DatasetReference datasetReference, ListTablesOptions options = null)
        {
            GaxPreconditions.CheckNotNull(datasetReference, nameof(datasetReference));

            var pageManager = new TablePageManager(this);
            return new RestPagedAsyncEnumerable<ListRequest, TableList, BigQueryTable>(
                () => CreateListTablesRequest(datasetReference, options),
                pageManager);
        }

        /// <inheritdoc />
        public override BigQueryTable CreateTable(TableReference tableReference, TableSchema schema, CreateTableOptions options = null) =>
            CreateTable(tableReference, new Table { Schema = GaxPreconditions.CheckNotNull(schema, nameof(schema)) }, options);

        /// <inheritdoc />
        public override Task<BigQueryTable> CreateTableAsync(
            TableReference tableReference, TableSchema schema, CreateTableOptions options = null, CancellationToken cancellationToken = default) =>
            CreateTableAsync(tableReference, new Table { Schema = GaxPreconditions.CheckNotNull(schema, nameof(schema)) }, options, cancellationToken);

        /// <inheritdoc />
        public override BigQueryTable CreateTable(TableReference tableReference, Table resource, CreateTableOptions options = null)
        {
            var request = CreateInsertTableRequest(tableReference, resource, options);
            var result = request.Execute();
            return new BigQueryTable(this, result);
        }

        /// <inheritdoc />
        public override async Task<BigQueryTable> CreateTableAsync(
            TableReference tableReference, Table resource, CreateTableOptions options = null, CancellationToken cancellationToken = default)
        {
            var request = CreateInsertTableRequest(tableReference, resource, options);
            var result = await request.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            return new BigQueryTable(this, result);
        }

        /// <inheritdoc />
        public override BigQueryTable GetOrCreateTable(
            TableReference tableReference, TableSchema schema, GetTableOptions getOptions = null, CreateTableOptions createOptions = null) =>
            GetOrCreateTable(tableReference, new Table { Schema = GaxPreconditions.CheckNotNull(schema, nameof(schema)) }, getOptions, createOptions);

        /// <inheritdoc />
        public override Task<BigQueryTable> GetOrCreateTableAsync(
            TableReference tableReference, TableSchema schema, GetTableOptions getOptions = null, CreateTableOptions createOptions = null, CancellationToken cancellationToken = default) =>
            GetOrCreateTableAsync(tableReference, new Table { Schema = GaxPreconditions.CheckNotNull(schema, nameof(schema)) }, getOptions, createOptions, cancellationToken);

        /// <inheritdoc />
        public override BigQueryTable GetOrCreateTable(TableReference tableReference, Table resource, GetTableOptions getOptions = null, CreateTableOptions createOptions = null)
        {
            CheckResourceForCreation(tableReference, resource);

            try
            {
                return GetTable(tableReference, getOptions);
            }
            catch (GoogleApiException ex) when (ex.HttpStatusCode == HttpStatusCode.NotFound)
            {
                try
                {
                    return CreateTable(tableReference, resource, createOptions);
                }
                catch (GoogleApiException ex2) when (ex2.HttpStatusCode == HttpStatusCode.Conflict)
                {
                    return GetTable(tableReference, getOptions);
                }
            }
        }

        /// <inheritdoc />
        public override async Task<BigQueryTable> GetOrCreateTableAsync(
            TableReference tableReference, Table resource, GetTableOptions getOptions = null, CreateTableOptions createOptions = null, CancellationToken cancellationToken = default)
        {
            CheckResourceForCreation(tableReference, resource);

            try
            {
                return await GetTableAsync(tableReference, getOptions, cancellationToken).ConfigureAwait(false);
            }
            catch (GoogleApiException ex) when (ex.HttpStatusCode == HttpStatusCode.NotFound)
            {
                try
                {
                    return await CreateTableAsync(tableReference, resource, createOptions, cancellationToken).ConfigureAwait(false);
                }
                catch (GoogleApiException ex2) when (ex2.HttpStatusCode == HttpStatusCode.Conflict)
                {
                    return await GetTableAsync(tableReference, getOptions, cancellationToken).ConfigureAwait(false);
                }
            }
        }

        /// <inheritdoc />
        public override void DeleteTable(TableReference tableReference, DeleteTableOptions options = null)
        {
            var request = CreateDeleteTableRequest(tableReference, options);
            request.Execute();
        }

        /// <inheritdoc />
        public override async Task DeleteTableAsync(TableReference tableReference, DeleteTableOptions options = null, CancellationToken cancellationToken = default)
        {
            var request = CreateDeleteTableRequest(tableReference, options);
            await request.ExecuteAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public override BigQueryTable UpdateTable(TableReference tableReference, Table resource, UpdateTableOptions options = null)
        {
            var request = CreateUpdateTableRequest(tableReference, resource, options);
            return new BigQueryTable(this, request.Execute());
        }

        /// <inheritdoc />
        public override async Task<BigQueryTable> UpdateTableAsync(TableReference tableReference, Table resource, UpdateTableOptions options = null, CancellationToken cancellationToken = default)
        {
            var request = CreateUpdateTableRequest(tableReference, resource, options);
            return new BigQueryTable(this, await request.ExecuteAsync(cancellationToken).ConfigureAwait(false));
        }

        /// <inheritdoc />
        public override BigQueryTable PatchTable(TableReference tableReference, Table resource, PatchTableOptions options = null)
        {
            var request = CreatePatchTableRequest(tableReference, resource, options);
            return new BigQueryTable(this, request.Execute());
        }

        /// <inheritdoc />
        public override async Task<BigQueryTable> PatchTableAsync(TableReference tableReference, Table resource, PatchTableOptions options = null, CancellationToken cancellationToken = default)
        {
            var request = CreatePatchTableRequest(tableReference, resource, options);
            return new BigQueryTable(this, await request.ExecuteAsync(cancellationToken).ConfigureAwait(false));
        }

        // Request creation
        private GetRequest CreateGetTableRequest(TableReference tableReference, GetTableOptions options)
        {
            GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));

            var request = Service.Tables.Get(tableReference.ProjectId, tableReference.DatasetId, tableReference.TableId);
            options?.ModifyRequest(request);
            RetryHandler.MarkAsRetriable(request);
            request.PrettyPrint = PrettyPrint;
            return request;
        }

        /// <inheritdoc />
        private ListRequest CreateListTablesRequest(DatasetReference datasetReference, ListTablesOptions options)
        {
            var request = Service.Tables.List(datasetReference.ProjectId, datasetReference.DatasetId);
            options?.ModifyRequest(request);
            RetryHandler.MarkAsRetriable(request);
            request.PrettyPrint = PrettyPrint;
            return request;
        }

        private InsertRequest CreateInsertTableRequest(TableReference tableReference, Table resource, CreateTableOptions options)
        {
            CheckResourceForCreation(tableReference, resource);

            resource.TableReference ??= tableReference;

            var request = Service.Tables.Insert(resource, tableReference.ProjectId, tableReference.DatasetId);
            options?.ModifyRequest(request);
            request.PrettyPrint = PrettyPrint;
            return request;
        }

        private void CheckResourceForCreation(TableReference tableReference, Table resource)
        {
            GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));
            GaxPreconditions.CheckNotNull(resource, nameof(resource));
            GaxPreconditions.CheckArgument(
                resource.TableReference == null || tableReference.ReferencesSameAs(resource.TableReference),
                nameof(resource.TableReference),
                $"If {nameof(resource.TableReference)} is specified, it must be the same as {nameof(tableReference)}");
            GaxPreconditions.CheckArgument(
                !(resource.ExternalDataConfiguration is object && resource.View is object),
                nameof(resource.ExternalDataConfiguration),
                $"Cannot specify both {nameof(resource.ExternalDataConfiguration)} and {nameof(resource.View)}");
        }

        private DeleteRequest CreateDeleteTableRequest(TableReference tableReference, DeleteTableOptions options)
        {
            GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));
            var request = Service.Tables.Delete(tableReference.ProjectId, tableReference.DatasetId, tableReference.TableId);
            options?.ModifyRequest(request);
            request.PrettyPrint = PrettyPrint;
            return request;
        }

        private UpdateRequest CreateUpdateTableRequest(TableReference tableReference, Table resource, UpdateTableOptions options)
        {
            GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));
            GaxPreconditions.CheckNotNull(resource, nameof(resource));
            var request = Service.Tables.Update(resource, tableReference.ProjectId, tableReference.DatasetId, tableReference.TableId);
            options?.ModifyRequest(request);
            RetryIfETagPresent(request, resource);
            request.PrettyPrint = PrettyPrint;
            return request;
        }

        private PatchRequest CreatePatchTableRequest(TableReference tableReference, Table resource, PatchTableOptions options)
        {
            GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference));
            GaxPreconditions.CheckNotNull(resource, nameof(resource));
            var request = Service.Tables.Patch(resource, tableReference.ProjectId, tableReference.DatasetId, tableReference.TableId);
            options?.ModifyRequest(request);
            RetryIfETagPresent(request, resource);
            request.PrettyPrint = PrettyPrint;
            return request;
        }
    }
}
