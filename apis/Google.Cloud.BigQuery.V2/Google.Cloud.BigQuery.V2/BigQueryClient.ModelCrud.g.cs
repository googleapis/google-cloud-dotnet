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

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Google.Apis.Bigquery.v2.Data;
using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.BigQuery.V2;

public abstract partial class BigQueryClient
{
    #region GetModel
    /// <summary>
    /// Retrieves the specified model within this client's project.
    /// This method just creates a <see cref="ModelReference"/> and delegates to <see cref="GetModel(ModelReference, GetModelOptions)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="modelId">The model ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The requested model.</returns>
    public virtual BigQueryModel GetModel(string datasetId, string modelId, GetModelOptions options = null) =>
        GetModel(GetModelReference(datasetId, modelId), options);
    
    /// <summary>
    /// Retrieves the specified model.
    /// This method just creates a <see cref="ModelReference"/> and delegates to <see cref="GetModel(ModelReference, GetModelOptions)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="modelId">The model ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The requested model.</returns>
    public virtual BigQueryModel GetModel(string projectId, string datasetId, string modelId, GetModelOptions options = null) =>
        GetModel(GetModelReference(projectId, datasetId, modelId), options);
    
    /// <summary>
    /// Retrieves the specified model.
    /// </summary>
    /// <param name="modelReference">A fully-qualified identifier for the model. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The requested model.</returns>
    public virtual BigQueryModel GetModel(ModelReference modelReference, GetModelOptions options = null) =>
        throw new NotImplementedException();
    
    /// <summary>
    /// Asynchronously retrieves the specified model within this client's project.
    /// This method just creates a <see cref="ModelReference"/> and delegates to <see cref="GetModelAsync(ModelReference, GetModelOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="modelId">The model ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the requested model.</returns>
    public virtual Task<BigQueryModel> GetModelAsync(string datasetId, string modelId, GetModelOptions options = null, CancellationToken cancellationToken = default) =>
        GetModelAsync(GetModelReference(datasetId, modelId), options, cancellationToken);
    
    /// <summary>
    /// Asynchronously retrieves the specified model.
    /// This method just creates a <see cref="ModelReference"/> and delegates to <see cref="GetModelAsync(ModelReference, GetModelOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="modelId">The model ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the requested model.</returns>
    public virtual Task<BigQueryModel> GetModelAsync(string projectId, string datasetId, string modelId, GetModelOptions options = null, CancellationToken cancellationToken = default) =>
        GetModelAsync(GetModelReference(projectId, datasetId, modelId), options, cancellationToken);
    
    /// <summary>
    /// Asynchronously retrieves the specified model.
    /// </summary>
    /// <param name="modelReference">A fully-qualified identifier for the model. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the requested model.</returns>
    public virtual Task<BigQueryModel> GetModelAsync(ModelReference modelReference, GetModelOptions options = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion

    #region DeleteModel
    /// <summary>
    /// Deletes the specified model within this client's project.
    /// This method just creates a <see cref="ModelReference"/> and delegates to <see cref="DeleteModel(ModelReference, DeleteModelOptions)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="modelId">The model ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    public virtual void DeleteModel(string datasetId, string modelId, DeleteModelOptions options = null) =>
        DeleteModel(GetModelReference(datasetId, modelId), options);
    
    /// <summary>
    /// Deletes the specified model.
    /// This method just creates a <see cref="ModelReference"/> and delegates to <see cref="DeleteModel(ModelReference, DeleteModelOptions)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="modelId">The model ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    public virtual void DeleteModel(string projectId, string datasetId, string modelId, DeleteModelOptions options = null) =>
        DeleteModel(GetModelReference(projectId, datasetId, modelId), options);
    
    /// <summary>
    /// Deletes the specified model.
    /// </summary>
    /// <param name="modelReference">A fully-qualified identifier for the model. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    public virtual void DeleteModel(ModelReference modelReference, DeleteModelOptions options = null) =>
        throw new NotImplementedException();
    
    /// <summary>
    /// Asynchronously deletes the specified model within this client's project.
    /// This method just creates a <see cref="ModelReference"/> and delegates to <see cref="DeleteModelAsync(ModelReference, DeleteModelOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="modelId">The model ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public virtual Task DeleteModelAsync(string datasetId, string modelId, DeleteModelOptions options = null, CancellationToken cancellationToken = default) =>
        DeleteModelAsync(GetModelReference(datasetId, modelId), options, cancellationToken);
    
    /// <summary>
    /// Asynchronously deletes the specified model.
    /// This method just creates a <see cref="ModelReference"/> and delegates to <see cref="DeleteModelAsync(ModelReference, DeleteModelOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="modelId">The model ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public virtual Task DeleteModelAsync(string projectId, string datasetId, string modelId, DeleteModelOptions options = null, CancellationToken cancellationToken = default) =>
        DeleteModelAsync(GetModelReference(projectId, datasetId, modelId), options, cancellationToken);
    
    /// <summary>
    /// Asynchronously deletes the specified model.
    /// </summary>
    /// <param name="modelReference">A fully-qualified identifier for the model. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public virtual Task DeleteModelAsync(ModelReference modelReference, DeleteModelOptions options = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion

    #region PatchModel
    /// <summary>
    /// Patches the specified model within this client's project with fields in the given resource.
    /// This method just creates a <see cref="ModelReference"/> and delegates to <see cref="PatchModel(ModelReference, Model, PatchModelOptions)"/>.
    /// </summary>
    /// <remarks>
    /// If the resource contains an ETag, it is used for optimistic concurrency validation.
    /// </remarks>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="modelId">The model ID. Must not be null.</param>
    /// <param name="resource">The model resource representation to use for the patch. Only fields present in the resource will be updated.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The updated model.</returns>
    public virtual BigQueryModel PatchModel(string datasetId, string modelId, Model resource, PatchModelOptions options = null) =>
        PatchModel(GetModelReference(datasetId, modelId), resource, options);
    
    /// <summary>
    /// Patches the specified model with fields in the given resource.
    /// This method just creates a <see cref="ModelReference"/> and delegates to <see cref="PatchModel(ModelReference, Model, PatchModelOptions)"/>.
    /// </summary>
    /// <remarks>
    /// If the resource contains an ETag, it is used for optimistic concurrency validation.
    /// </remarks>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="modelId">The model ID. Must not be null.</param>
    /// <param name="resource">The model resource representation to use for the patch. Only fields present in the resource will be updated.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The updated model.</returns>
    public virtual BigQueryModel PatchModel(string projectId, string datasetId, string modelId, Model resource, PatchModelOptions options = null) =>
        PatchModel(GetModelReference(projectId, datasetId, modelId), resource, options);
    
    /// <summary>
    /// Patches the specified model with fields in the given resource.
    /// </summary>
    /// <remarks>
    /// If the resource contains an ETag, it is used for optimistic concurrency validation.
    /// </remarks>
    /// <param name="modelReference">A fully-qualified identifier for the model. Must not be null.</param>
    /// <param name="resource">The model resource representation to use for the patch. Only fields present in the resource will be updated.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The updated model.</returns>
    public virtual BigQueryModel PatchModel(ModelReference modelReference, Model resource, PatchModelOptions options = null) =>
        throw new NotImplementedException();
    
    /// <summary>
    /// Asynchronously patches the specified model within this client's project with fields in the given resource.
    /// This method just creates a <see cref="ModelReference"/> and delegates to <see cref="PatchModelAsync(ModelReference, Model, PatchModelOptions, CancellationToken)"/>.
    /// </summary>
    /// <remarks>
    /// If the resource contains an ETag, it is used for optimistic concurrency validation.
    /// </remarks>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="modelId">The model ID. Must not be null.</param>
    /// <param name="resource">The model resource representation to use for the patch. Only fields present in the resource will be updated.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the updated model.</returns>
    public virtual Task<BigQueryModel> PatchModelAsync(string datasetId, string modelId, Model resource, PatchModelOptions options = null, CancellationToken cancellationToken = default) =>
        PatchModelAsync(GetModelReference(datasetId, modelId), resource, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously patches the specified model with fields in the given resource.
    /// This method just creates a <see cref="ModelReference"/> and delegates to <see cref="PatchModelAsync(ModelReference, Model, PatchModelOptions, CancellationToken)"/>.
    /// </summary>
    /// <remarks>
    /// If the resource contains an ETag, it is used for optimistic concurrency validation.
    /// </remarks>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="modelId">The model ID. Must not be null.</param>
    /// <param name="resource">The model resource representation to use for the patch. Only fields present in the resource will be updated.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the updated model.</returns>
    public virtual Task<BigQueryModel> PatchModelAsync(string projectId, string datasetId, string modelId, Model resource, PatchModelOptions options = null, CancellationToken cancellationToken = default) =>
        PatchModelAsync(GetModelReference(projectId, datasetId, modelId), resource, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously patches the specified model with fields in the given resource.
    /// </summary>
    /// <remarks>
    /// If the resource contains an ETag, it is used for optimistic concurrency validation.
    /// </remarks>
    /// <param name="modelReference">A fully-qualified identifier for the model. Must not be null.</param>
    /// <param name="resource">The model resource representation to use for the patch. Only fields present in the resource will be updated.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the updated model.</returns>
    public virtual Task<BigQueryModel> PatchModelAsync(ModelReference modelReference, Model resource, PatchModelOptions options = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion
}
