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
    /// A model within a BigQuery dataset.
    /// </summary>
    /// <remarks>
    /// This class wraps the underlying REST API resource and retains a reference to the original
    /// client, allowing for simpler model-oriented operations.
    /// </remarks>
    public sealed class BigQueryModel
    {
        private readonly BigQueryClient _client;

        /// <summary>
        /// The underlying REST-ful resource for the model.
        /// </summary>
        /// <remarks>
        /// The data within the resource may be incomplete, depending on how it was obtained.
        /// (ListModels operations return less data than GetModel operations.)
        /// </remarks>
        public Model Resource { get; }

        /// <summary>
        /// The fully-qualified identifier for the model, as an object which can be used for other operations
        /// within this API.
        /// </summary>
        /// <remarks>
        /// The properties within the reference can be used to determine the project ID,
        /// dataset ID and model ID components.
        /// </remarks>
        public ModelReference Reference => Resource.ModelReference;

        /// <summary>
        /// Constructs a new model.
        /// </summary>
        /// <remarks>
        /// This is public to allow tests to construct instances for production code to consume;
        /// production code should not normally construct instances itself.
        /// </remarks>
        /// <param name="client">The client to use for operations on the model. Must not be null.</param>
        /// <param name="resource">The REST-ful resource representing the model. Must not be null.</param>
        public BigQueryModel(BigQueryClient client, Model resource)
        {
            _client = GaxPreconditions.CheckNotNull(client, nameof(client));
            Resource = GaxPreconditions.CheckNotNull(resource, nameof(resource));
        }

        /// <summary>
        /// Patches this model with fields in the specified resource.
        /// </summary>
        /// <remarks>
        /// This method delegates to <see cref="BigQueryClient.PatchModel(ModelReference, Model, PatchModelOptions)"/>.
        /// </remarks>
        /// <param name="resource">The resource to patch with. Must not be null.</param>
        /// <param name="matchETag">If true, the etag from <see cref="Resource"/> is propagated into <paramref name="resource"/> for
        /// optimistic concurrency. Otherwise, <paramref name="resource"/> is left unchanged.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <returns>The updated model.</returns>
        public BigQueryModel Patch(Model resource, bool matchETag, PatchModelOptions options = null)
        {
            if (matchETag)
            {
                resource.ETag = Resource.ETag;
            }
            return _client.PatchModel(Reference, resource, options);
        }

        /// <summary>
        /// Deletes this model.
        /// This method just creates a <see cref="ModelReference"/> and delegates to <see cref="BigQueryClient.DeleteModel(ModelReference, DeleteModelOptions)"/>.
        /// </summary>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        public void Delete(DeleteModelOptions options = null) => _client.DeleteModel(Reference, options);

        /// <summary>
        /// Asynchronously patches this model with fields in the specified resource.
        /// </summary>
        /// <remarks>
        /// This method delegates to <see cref="BigQueryClient.PatchModelAsync(ModelReference, Model, PatchModelOptions, CancellationToken)"/>.
        /// </remarks>
        /// <param name="resource">The resource to patch with. Must not be null.</param>
        /// <param name="matchETag">If true, the etag from <see cref="Resource"/> is propagated into <paramref name="resource"/> for
        /// optimistic concurrency. Otherwise, <paramref name="resource"/> is left unchanged.</param>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation. When complete, the result is
        /// the updated model.</returns>
        public Task<BigQueryModel> PatchAsync(Model resource, bool matchETag, PatchModelOptions options = null, CancellationToken cancellationToken = default)
        {
            if (matchETag)
            {
                resource.ETag = Resource.ETag;
            }
            return _client.PatchModelAsync(Reference, resource, options, cancellationToken);
        }

        /// <summary>
        /// Asynchronously deletes this model.
        /// This method just creates a <see cref="ModelReference"/> and delegates to <see cref="BigQueryClient.DeleteModelAsync(ModelReference, DeleteModelOptions, CancellationToken)"/>.
        /// </summary>
        /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public Task DeleteAsync(DeleteModelOptions options = null, CancellationToken cancellationToken = default) =>
            _client.DeleteModelAsync(Reference, options, cancellationToken);
    }
}
