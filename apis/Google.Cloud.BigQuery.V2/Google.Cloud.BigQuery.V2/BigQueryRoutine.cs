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
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// A routine within a BigQuery dataset.
    /// </summary>
    /// <remarks>
    /// This class wraps the underlying REST API resource and retains a reference to the original
    /// client, allowing for simpler routine-oriented operations.
    /// </remarks>
    public sealed class BigQueryRoutine
    {
        private readonly BigQueryClient _client;

        /// <summary>
        /// The underlying REST-ful resource for the routine.
        /// </summary>
        /// <remarks>
        /// The data within the resource may be incomplete, depending on how it was obtained,
        /// because for both get and list operations, a read mask can be specified that determines
        /// which fields are populated on the returned resource.
        /// </remarks>
        public Routine Resource { get; }

        /// <summary>
        /// The fully-qualified identifier for the routine in a string form of <c>project.dataset.routine</c>.
        /// </summary>
        public string FullyQualifiedId => $"{Reference.ProjectId}.{Reference.DatasetId}.{Reference.RoutineId}";

        /// <summary>
        /// The fully-qualified identifier for the routine, as an object which can be used for other operations
        /// within this API.
        /// </summary>
        /// <remarks>
        /// The properties within the reference can be used to determine the project ID,
        /// dataset ID and routine ID components.
        /// </remarks>
        public RoutineReference Reference => Resource.RoutineReference;

        /// <summary>
        /// Constructs a new routine.
        /// </summary>
        /// <remarks>
        /// This is public to allow tests to construct instances for production code to consume;
        /// production code should not normally construct instances itself.
        /// </remarks>
        /// <param name="client">The client to use for operations on the routine. Must not be null.</param>
        /// <param name="resource">The REST-ful resource representing the routine. Must not be null.</param>
        public BigQueryRoutine(BigQueryClient client, Routine resource)
        {
            _client = GaxPreconditions.CheckNotNull(client, nameof(client));
            Resource = GaxPreconditions.CheckNotNull(resource, nameof(resource));
        }

        /// <summary>
        /// Deletes this routine.
        /// This method just creates a <see cref="RoutineReference"/> and delegates to <see cref="BigQueryClient.DeleteRoutine(RoutineReference, DeleteRoutineOptions)"/>.
        /// </summary>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        public void Delete(DeleteRoutineOptions options = null) => _client.DeleteRoutine(Reference, options);

        /// <summary>
        /// Asynchronously deletes this routine.
        /// This method just creates a <see cref="RoutineReference"/> and delegates to <see cref="BigQueryClient.DeleteRoutineAsync(RoutineReference, DeleteRoutineOptions, CancellationToken)"/>.
        /// </summary>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public Task DeleteAsync(DeleteRoutineOptions options = null, CancellationToken cancellationToken = default) =>
            _client.DeleteRoutineAsync(Reference, options, cancellationToken);

        /// <summary>
        /// Updates this routine to match the specified resource.
        /// </summary>
        /// <remarks>
        /// This method delegates to <see cref="BigQueryClient.UpdateRoutine(RoutineReference, Routine, UpdateRoutineOptions)"/>.
        /// A simple way of updating the routine is to modify <see cref="Resource"/> and then call this method with no arguments.
        /// This is convenient, but it's important to understand that modifying <see cref="Resource"/> in this way leaves this object
        /// in an unusual state - it represents "the table as it was when fetched, but then modified locally". For example, the etag
        /// will be the original etag, rather than the one associated with the updated routine. To avoid this causing confusion,
        /// we recommend only taking this approach if the object will not be used afterwards. Use the value returned by this method
        /// as the new, self-consistent representation of the routine.
        /// </remarks>
        /// <param name="resource">The resource to update with. If null, the <see cref="Resource"/> property is
        /// used.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The updated routine.</returns>
        public BigQueryRoutine Update(Routine resource = null, UpdateRoutineOptions options = null) =>
            _client.UpdateRoutine(Reference, resource ?? Resource, options);

        /// <summary>
        /// Asynchronously updates this routine to match the specified resource.
        /// </summary>
        /// <remarks>
        /// This method delegates to <see cref="BigQueryClient.UpdateRoutineAsync(RoutineReference, Routine, UpdateRoutineOptions, CancellationToken)"/>.
        /// A simple way of updating the routine is to modify <see cref="Resource"/> and then call this method with no arguments.
        /// This is convenient, but it's important to understand that modifying <see cref="Resource"/> in this way leaves this object
        /// in an unusual state - it represents "the table as it was when fetched, but then modified locally". For example, the etag
        /// will be the original etag, rather than the one associated with the updated routine. To avoid this causing confusion,
        /// we recommend only taking this approach if the object will not be used afterwards. Use the value returned by this method
        /// as the new, self-consistent representation of the routine.
        /// </remarks>
        /// <param name="resource">The resource to update with. If null, the <see cref="Resource"/> property is
        /// used.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the updated routine.</returns>
        public Task<BigQueryRoutine> UpdateAsync(Routine resource = null, UpdateRoutineOptions options = null, CancellationToken cancellationToken = default) =>
            _client.UpdateRoutineAsync(Reference, resource ?? Resource, options, cancellationToken);
    }
}
