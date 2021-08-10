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
using Google.Api.Gax.Rest;
using Google.Apis.Bigquery.v2.Data;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using static Google.Apis.Bigquery.v2.RoutinesResource;

namespace Google.Cloud.BigQuery.V2
{
    public partial class BigQueryClientImpl
    {
        // Visible for testing
        internal sealed class RoutinePageManager : IPageManager<ListRequest, ListRoutinesResponse, BigQueryRoutine>
        {
            private readonly BigQueryClient _client;

            internal RoutinePageManager(BigQueryClient client)
            {
                _client = client;
            }

            public string GetNextPageToken(ListRoutinesResponse response) => response.NextPageToken;
            public IEnumerable<BigQueryRoutine> GetResources(ListRoutinesResponse response) => response.Routines?.Select(resource => new BigQueryRoutine(_client, resource));
            public void SetPageSize(ListRequest request, int pageSize) => request.MaxResults = pageSize;
            public void SetPageToken(ListRequest request, string pageToken) => request.PageToken = pageToken;
        }

        /// <inheritdoc />
        public override BigQueryRoutine GetRoutine(RoutineReference routineReference, GetRoutineOptions options = null)
        {
            var request = CreateGetRoutineRequest(routineReference, options);
            var resource = request.Execute();
            return new BigQueryRoutine(this, resource);
        }

        /// <inheritdoc />
        public async override Task<BigQueryRoutine> GetRoutineAsync(RoutineReference routineReference, GetRoutineOptions options = null, CancellationToken cancellationToken = default)
        {
            var request = CreateGetRoutineRequest(routineReference, options);
            var resource = await request.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            return new BigQueryRoutine(this, resource);
        }

        /// <inheritdoc />
        public override PagedEnumerable<ListRoutinesResponse, BigQueryRoutine> ListRoutines(DatasetReference datasetReference, ListRoutinesOptions options = null)
        {
            GaxPreconditions.CheckNotNull(datasetReference, nameof(datasetReference));

            var pageManager = new RoutinePageManager(this);
            return new RestPagedEnumerable<ListRequest, ListRoutinesResponse, BigQueryRoutine>(
                () => CreateListRoutinesRequest(datasetReference, options),
                pageManager);
        }

        /// <inheritdoc />
        public override PagedAsyncEnumerable<ListRoutinesResponse, BigQueryRoutine> ListRoutinesAsync(DatasetReference datasetReference, ListRoutinesOptions options = null)
        {
            GaxPreconditions.CheckNotNull(datasetReference, nameof(datasetReference));

            var pageManager = new RoutinePageManager(this);
            return new RestPagedAsyncEnumerable<ListRequest, ListRoutinesResponse, BigQueryRoutine>(
                () => CreateListRoutinesRequest(datasetReference, options),
                pageManager);
        }

        /// <inheritdoc />
        public override BigQueryRoutine CreateRoutine(RoutineReference routineReference, Routine resource, CreateRoutineOptions options = null)
        {
            var request = CreateInsertRoutineRequest(routineReference, resource, options);
            var result = request.Execute();
            return new BigQueryRoutine(this, result);
        }

        /// <inheritdoc />
        public async override Task<BigQueryRoutine> CreateRoutineAsync(RoutineReference routineReference, Routine resource, CreateRoutineOptions options = null, CancellationToken cancellationToken = default)
        {
            var request = CreateInsertRoutineRequest(routineReference, resource, options);
            var result = await request.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            return new BigQueryRoutine(this, result);
        }

        /// <inheritdoc />
        public override BigQueryRoutine GetOrCreateRoutine(RoutineReference routineReference, Routine resource, GetRoutineOptions getOptions = null, CreateRoutineOptions createOptions = null)
        {
            CheckResourceReference(routineReference, resource);

            try
            {
                return GetRoutine(routineReference, getOptions);
            }
            catch (GoogleApiException ex) when (ex.HttpStatusCode == HttpStatusCode.NotFound)
            {
                try
                {
                    return CreateRoutine(routineReference, resource, createOptions);
                }
                catch (GoogleApiException ex2) when (ex2.HttpStatusCode == HttpStatusCode.Conflict)
                {
                    return GetRoutine(routineReference, getOptions);
                }
            }
        }

        /// <inheritdoc />
        public async override Task<BigQueryRoutine> GetOrCreateRoutineAsync(RoutineReference routineReference, Routine resource, GetRoutineOptions getOptions = null, CreateRoutineOptions createOptions = null, CancellationToken cancellationToken = default)
        {
            CheckResourceReference(routineReference, resource);

            try
            {
                return await GetRoutineAsync(routineReference, getOptions, cancellationToken).ConfigureAwait(false);
            }
            catch (GoogleApiException ex) when (ex.HttpStatusCode == HttpStatusCode.NotFound)
            {
                try
                {
                    return await CreateRoutineAsync(routineReference, resource, createOptions, cancellationToken).ConfigureAwait(false);
                }
                catch (GoogleApiException ex2) when (ex2.HttpStatusCode == HttpStatusCode.Conflict)
                {
                    return await GetRoutineAsync(routineReference, getOptions, cancellationToken).ConfigureAwait(false);
                }
            }
        }

        /// <inheritdoc />
        public override void DeleteRoutine(RoutineReference routineReference, DeleteRoutineOptions options = null)
        {
            var request = CreateDeleteRoutineRequest(routineReference, options);
            request.Execute();
        }

        /// <inheritdoc />
        public async override Task DeleteRoutineAsync(RoutineReference routineReference, DeleteRoutineOptions options = null, CancellationToken cancellationToken = default)
        {
            var request = CreateDeleteRoutineRequest(routineReference, options);
            await request.ExecuteAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public override BigQueryRoutine UpdateRoutine(RoutineReference routineReference, Routine resource, UpdateRoutineOptions options = null)
        {
            var request = CreateUpdateRoutineRequest(routineReference, resource, options);
            var routine = request.Execute();
            return new BigQueryRoutine(this, routine);
        }

        /// <inheritdoc />
        public async override Task<BigQueryRoutine> UpdateRoutineAsync(RoutineReference routineReference, Routine resource, UpdateRoutineOptions options = null, CancellationToken cancellationToken = default)
        {
            var request = CreateUpdateRoutineRequest(routineReference, resource, options);
            var routine = await request.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            return new BigQueryRoutine(this, routine);
        }

        private GetRequest CreateGetRoutineRequest(RoutineReference routineReference, GetRoutineOptions options)
        {
            GaxPreconditions.CheckNotNull(routineReference, nameof(routineReference));

            var request = Service.Routines.Get(routineReference.ProjectId, routineReference.DatasetId, routineReference.RoutineId);
            options?.ModifyRequest(request);
            RetryHandler.MarkAsRetriable(request);
            request.PrettyPrint = PrettyPrint;
            return request;
        }

        private ListRequest CreateListRoutinesRequest(DatasetReference datasetReference, ListRoutinesOptions options)
        {
            var request = Service.Routines.List(datasetReference.ProjectId, datasetReference.DatasetId);
            options?.ModifyRequest(request);
            RetryHandler.MarkAsRetriable(request);
            request.PrettyPrint = PrettyPrint;
            return request;
        }

        private InsertRequest CreateInsertRoutineRequest(RoutineReference routineReference, Routine resource, CreateRoutineOptions options)
        {
            CheckResourceReference(routineReference, resource);

            resource.RoutineReference ??= routineReference;

            var request = Service.Routines.Insert(resource, routineReference.ProjectId, routineReference.DatasetId);
            options?.ModifyRequest(request);
            request.PrettyPrint = PrettyPrint;
            return request;
        }

        private DeleteRequest CreateDeleteRoutineRequest(RoutineReference routineReference, DeleteRoutineOptions options)
        {
            GaxPreconditions.CheckNotNull(routineReference, nameof(routineReference));
            var request = Service.Routines.Delete(routineReference.ProjectId, routineReference.DatasetId, routineReference.RoutineId);
            options?.ModifyRequest(request);
            request.PrettyPrint = PrettyPrint;
            return request;
        }

        private UpdateRequest CreateUpdateRoutineRequest(RoutineReference routineReference, Routine resource, UpdateRoutineOptions options)
        {
            CheckResourceReference(routineReference, resource);
            var request = Service.Routines.Update(resource, routineReference.ProjectId, routineReference.DatasetId, routineReference.RoutineId);
            options?.ModifyRequest(request);
            RetryIfETagPresent(request, resource);
            request.PrettyPrint = PrettyPrint;
            return request;
        }

        private static void CheckResourceReference(RoutineReference routineReference, Routine resource)
        {
            GaxPreconditions.CheckNotNull(routineReference, nameof(routineReference));
            GaxPreconditions.CheckNotNull(resource, nameof(resource));
            GaxPreconditions.CheckArgument(
                resource.RoutineReference == null || routineReference.ReferencesSameAs(resource.RoutineReference),
                nameof(resource.RoutineReference),
                $"If {nameof(resource.RoutineReference)} is specified, it must be the same as {nameof(routineReference)}");
        }
    }
}
