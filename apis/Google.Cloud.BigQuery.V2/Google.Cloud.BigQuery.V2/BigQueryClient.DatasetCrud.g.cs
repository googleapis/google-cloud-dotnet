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
    #region GetDataset
    /// <summary>
    /// Retrieves the specified dataset within this client's project.
    /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="GetDataset(DatasetReference, GetDatasetOptions)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The requested dataset.</returns>
    public virtual BigQueryDataset GetDataset(string datasetId, GetDatasetOptions options = null) =>
        GetDataset(GetDatasetReference(datasetId), options);
    
    /// <summary>
    /// Retrieves the specified dataset.
    /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="GetDataset(DatasetReference, GetDatasetOptions)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The requested dataset.</returns>
    public virtual BigQueryDataset GetDataset(string projectId, string datasetId, GetDatasetOptions options = null) =>
        GetDataset(GetDatasetReference(projectId, datasetId), options);
    
    /// <summary>
    /// Retrieves the specified dataset.
    /// </summary>
    /// <param name="datasetReference">A fully-qualified identifier for the dataset. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The requested dataset.</returns>
    public virtual BigQueryDataset GetDataset(DatasetReference datasetReference, GetDatasetOptions options = null) =>
        throw new NotImplementedException();
    
    /// <summary>
    /// Asynchronously retrieves the specified dataset within this client's project.
    /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="GetDatasetAsync(DatasetReference, GetDatasetOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the requested dataset.</returns>
    public virtual Task<BigQueryDataset> GetDatasetAsync(string datasetId, GetDatasetOptions options = null, CancellationToken cancellationToken = default) =>
        GetDatasetAsync(GetDatasetReference(datasetId), options, cancellationToken);
    
    /// <summary>
    /// Asynchronously retrieves the specified dataset.
    /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="GetDatasetAsync(DatasetReference, GetDatasetOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the requested dataset.</returns>
    public virtual Task<BigQueryDataset> GetDatasetAsync(string projectId, string datasetId, GetDatasetOptions options = null, CancellationToken cancellationToken = default) =>
        GetDatasetAsync(GetDatasetReference(projectId, datasetId), options, cancellationToken);
    
    /// <summary>
    /// Asynchronously retrieves the specified dataset.
    /// </summary>
    /// <param name="datasetReference">A fully-qualified identifier for the dataset. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the requested dataset.</returns>
    public virtual Task<BigQueryDataset> GetDatasetAsync(DatasetReference datasetReference, GetDatasetOptions options = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion

    #region CreateDataset
    /// <summary>
    /// Creates the specified dataset within this client's project.
    /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="CreateDataset(DatasetReference, Dataset, CreateDatasetOptions)"/>.
    /// </summary>
    /// <remarks>
    /// If <paramref name="resource" /><see cref="Dataset.DatasetReference" /> is specified, then it must be the same as the <see cref="DatasetReference" /> obtained from the other parameters.
    /// </remarks>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="resource">The dataset resource representation to use for the creation. May be null in which case default values will be used.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The created dataset.</returns>
    public virtual BigQueryDataset CreateDataset(string datasetId, Dataset resource = null, CreateDatasetOptions options = null) =>
        CreateDataset(GetDatasetReference(datasetId), resource, options);
    
    /// <summary>
    /// Creates the specified dataset.
    /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="CreateDataset(DatasetReference, Dataset, CreateDatasetOptions)"/>.
    /// </summary>
    /// <remarks>
    /// If <paramref name="resource" /><see cref="Dataset.DatasetReference" /> is specified, then it must be the same as the <see cref="DatasetReference" /> obtained from the other parameters.
    /// </remarks>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="resource">The dataset resource representation to use for the creation. May be null in which case default values will be used.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The created dataset.</returns>
    public virtual BigQueryDataset CreateDataset(string projectId, string datasetId, Dataset resource = null, CreateDatasetOptions options = null) =>
        CreateDataset(GetDatasetReference(projectId, datasetId), resource, options);
    
    /// <summary>
    /// Creates the specified dataset.
    /// </summary>
    /// <remarks>
    /// If <paramref name="resource" /><see cref="Dataset.DatasetReference" /> is specified, then it must be the same as the <see cref="DatasetReference" /> obtained from the other parameters.
    /// </remarks>
    /// <param name="datasetReference">A fully-qualified identifier for the dataset. Must not be null.</param>
    /// <param name="resource">The dataset resource representation to use for the creation. May be null in which case default values will be used.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The created dataset.</returns>
    public virtual BigQueryDataset CreateDataset(DatasetReference datasetReference, Dataset resource = null, CreateDatasetOptions options = null) =>
        throw new NotImplementedException();
    
    /// <summary>
    /// Asynchronously creates the specified dataset within this client's project.
    /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="CreateDatasetAsync(DatasetReference, Dataset, CreateDatasetOptions, CancellationToken)"/>.
    /// </summary>
    /// <remarks>
    /// If <paramref name="resource" /><see cref="Dataset.DatasetReference" /> is specified, then it must be the same as the <see cref="DatasetReference" /> obtained from the other parameters.
    /// </remarks>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="resource">The dataset resource representation to use for the creation. May be null in which case default values will be used.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the created dataset.</returns>
    public virtual Task<BigQueryDataset> CreateDatasetAsync(string datasetId, Dataset resource = null, CreateDatasetOptions options = null, CancellationToken cancellationToken = default) =>
        CreateDatasetAsync(GetDatasetReference(datasetId), resource, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously creates the specified dataset.
    /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="CreateDatasetAsync(DatasetReference, Dataset, CreateDatasetOptions, CancellationToken)"/>.
    /// </summary>
    /// <remarks>
    /// If <paramref name="resource" /><see cref="Dataset.DatasetReference" /> is specified, then it must be the same as the <see cref="DatasetReference" /> obtained from the other parameters.
    /// </remarks>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="resource">The dataset resource representation to use for the creation. May be null in which case default values will be used.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the created dataset.</returns>
    public virtual Task<BigQueryDataset> CreateDatasetAsync(string projectId, string datasetId, Dataset resource = null, CreateDatasetOptions options = null, CancellationToken cancellationToken = default) =>
        CreateDatasetAsync(GetDatasetReference(projectId, datasetId), resource, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously creates the specified dataset.
    /// </summary>
    /// <remarks>
    /// If <paramref name="resource" /><see cref="Dataset.DatasetReference" /> is specified, then it must be the same as the <see cref="DatasetReference" /> obtained from the other parameters.
    /// </remarks>
    /// <param name="datasetReference">A fully-qualified identifier for the dataset. Must not be null.</param>
    /// <param name="resource">The dataset resource representation to use for the creation. May be null in which case default values will be used.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the created dataset.</returns>
    public virtual Task<BigQueryDataset> CreateDatasetAsync(DatasetReference datasetReference, Dataset resource = null, CreateDatasetOptions options = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion

    #region GetOrCreateDataset
    /// <summary>
    /// Attempts to fetch the specified dataset within this client's project, creating it if it doesn't exist.
    /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="GetOrCreateDataset(DatasetReference, Dataset, GetDatasetOptions, CreateDatasetOptions)"/>.
    /// </summary>
    /// <remarks>
    /// If <paramref name="resource" /><see cref="Dataset.DatasetReference" /> is specified, then it must be the same as the <see cref="DatasetReference" /> obtained from the other parameters.
    /// </remarks>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="resource">The dataset resource representation to use for the creation. May be null in which case default values will be used.</param>
    /// <param name="getOptions">The options for the "get" operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="createOptions">The options for the "create" operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The existing or new dataset.</returns>
    public virtual BigQueryDataset GetOrCreateDataset(string datasetId, Dataset resource = null, GetDatasetOptions getOptions = null, CreateDatasetOptions createOptions = null) =>
        GetOrCreateDataset(GetDatasetReference(datasetId), resource, getOptions, createOptions);
    
    /// <summary>
    /// Attempts to fetch the specified dataset, creating it if it doesn't exist.
    /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="GetOrCreateDataset(DatasetReference, Dataset, GetDatasetOptions, CreateDatasetOptions)"/>.
    /// </summary>
    /// <remarks>
    /// If <paramref name="resource" /><see cref="Dataset.DatasetReference" /> is specified, then it must be the same as the <see cref="DatasetReference" /> obtained from the other parameters.
    /// </remarks>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="resource">The dataset resource representation to use for the creation. May be null in which case default values will be used.</param>
    /// <param name="getOptions">The options for the "get" operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="createOptions">The options for the "create" operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The existing or new dataset.</returns>
    public virtual BigQueryDataset GetOrCreateDataset(string projectId, string datasetId, Dataset resource = null, GetDatasetOptions getOptions = null, CreateDatasetOptions createOptions = null) =>
        GetOrCreateDataset(GetDatasetReference(projectId, datasetId), resource, getOptions, createOptions);
    
    /// <summary>
    /// Attempts to fetch the specified dataset, creating it if it doesn't exist.
    /// </summary>
    /// <remarks>
    /// If <paramref name="resource" /><see cref="Dataset.DatasetReference" /> is specified, then it must be the same as the <see cref="DatasetReference" /> obtained from the other parameters.
    /// </remarks>
    /// <param name="datasetReference">A fully-qualified identifier for the dataset. Must not be null.</param>
    /// <param name="resource">The dataset resource representation to use for the creation. May be null in which case default values will be used.</param>
    /// <param name="getOptions">The options for the "get" operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="createOptions">The options for the "create" operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The existing or new dataset.</returns>
    public virtual BigQueryDataset GetOrCreateDataset(DatasetReference datasetReference, Dataset resource = null, GetDatasetOptions getOptions = null, CreateDatasetOptions createOptions = null) =>
        throw new NotImplementedException();
    
    /// <summary>
    /// Asynchronously attempts to fetch the specified dataset within this client's project, creating it if it doesn't exist.
    /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="GetOrCreateDatasetAsync(DatasetReference, Dataset, GetDatasetOptions, CreateDatasetOptions, CancellationToken)"/>.
    /// </summary>
    /// <remarks>
    /// If <paramref name="resource" /><see cref="Dataset.DatasetReference" /> is specified, then it must be the same as the <see cref="DatasetReference" /> obtained from the other parameters.
    /// </remarks>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="resource">The dataset resource representation to use for the creation. May be null in which case default values will be used.</param>
    /// <param name="getOptions">The options for the "get" operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="createOptions">The options for the "create" operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the existing or new dataset.</returns>
    public virtual Task<BigQueryDataset> GetOrCreateDatasetAsync(string datasetId, Dataset resource = null, GetDatasetOptions getOptions = null, CreateDatasetOptions createOptions = null, CancellationToken cancellationToken = default) =>
        GetOrCreateDatasetAsync(GetDatasetReference(datasetId), resource, getOptions, createOptions, cancellationToken);
    
    /// <summary>
    /// Asynchronously attempts to fetch the specified dataset, creating it if it doesn't exist.
    /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="GetOrCreateDatasetAsync(DatasetReference, Dataset, GetDatasetOptions, CreateDatasetOptions, CancellationToken)"/>.
    /// </summary>
    /// <remarks>
    /// If <paramref name="resource" /><see cref="Dataset.DatasetReference" /> is specified, then it must be the same as the <see cref="DatasetReference" /> obtained from the other parameters.
    /// </remarks>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="resource">The dataset resource representation to use for the creation. May be null in which case default values will be used.</param>
    /// <param name="getOptions">The options for the "get" operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="createOptions">The options for the "create" operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the existing or new dataset.</returns>
    public virtual Task<BigQueryDataset> GetOrCreateDatasetAsync(string projectId, string datasetId, Dataset resource = null, GetDatasetOptions getOptions = null, CreateDatasetOptions createOptions = null, CancellationToken cancellationToken = default) =>
        GetOrCreateDatasetAsync(GetDatasetReference(projectId, datasetId), resource, getOptions, createOptions, cancellationToken);
    
    /// <summary>
    /// Asynchronously attempts to fetch the specified dataset, creating it if it doesn't exist.
    /// </summary>
    /// <remarks>
    /// If <paramref name="resource" /><see cref="Dataset.DatasetReference" /> is specified, then it must be the same as the <see cref="DatasetReference" /> obtained from the other parameters.
    /// </remarks>
    /// <param name="datasetReference">A fully-qualified identifier for the dataset. Must not be null.</param>
    /// <param name="resource">The dataset resource representation to use for the creation. May be null in which case default values will be used.</param>
    /// <param name="getOptions">The options for the "get" operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="createOptions">The options for the "create" operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the existing or new dataset.</returns>
    public virtual Task<BigQueryDataset> GetOrCreateDatasetAsync(DatasetReference datasetReference, Dataset resource = null, GetDatasetOptions getOptions = null, CreateDatasetOptions createOptions = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion

    #region DeleteDataset
    /// <summary>
    /// Deletes the specified dataset within this client's project.
    /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="DeleteDataset(DatasetReference, DeleteDatasetOptions)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    public virtual void DeleteDataset(string datasetId, DeleteDatasetOptions options = null) =>
        DeleteDataset(GetDatasetReference(datasetId), options);
    
    /// <summary>
    /// Deletes the specified dataset.
    /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="DeleteDataset(DatasetReference, DeleteDatasetOptions)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    public virtual void DeleteDataset(string projectId, string datasetId, DeleteDatasetOptions options = null) =>
        DeleteDataset(GetDatasetReference(projectId, datasetId), options);
    
    /// <summary>
    /// Deletes the specified dataset.
    /// </summary>
    /// <param name="datasetReference">A fully-qualified identifier for the dataset. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    public virtual void DeleteDataset(DatasetReference datasetReference, DeleteDatasetOptions options = null) =>
        throw new NotImplementedException();
    
    /// <summary>
    /// Asynchronously deletes the specified dataset within this client's project.
    /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="DeleteDatasetAsync(DatasetReference, DeleteDatasetOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public virtual Task DeleteDatasetAsync(string datasetId, DeleteDatasetOptions options = null, CancellationToken cancellationToken = default) =>
        DeleteDatasetAsync(GetDatasetReference(datasetId), options, cancellationToken);
    
    /// <summary>
    /// Asynchronously deletes the specified dataset.
    /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="DeleteDatasetAsync(DatasetReference, DeleteDatasetOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public virtual Task DeleteDatasetAsync(string projectId, string datasetId, DeleteDatasetOptions options = null, CancellationToken cancellationToken = default) =>
        DeleteDatasetAsync(GetDatasetReference(projectId, datasetId), options, cancellationToken);
    
    /// <summary>
    /// Asynchronously deletes the specified dataset.
    /// </summary>
    /// <param name="datasetReference">A fully-qualified identifier for the dataset. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public virtual Task DeleteDatasetAsync(DatasetReference datasetReference, DeleteDatasetOptions options = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion

    #region UpdateDataset
    /// <summary>
    /// Updates the specified dataset within this client's project to match the specified resource.
    /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="UpdateDataset(DatasetReference, Dataset, UpdateDatasetOptions)"/>.
    /// </summary>
    /// <remarks>
    /// If the resource contains an ETag, it is used for optimistic concurrency validation.
    /// </remarks>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="resource">The dataset resource representation to use for the update. All updatable fields will be updated.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The updated dataset.</returns>
    public virtual BigQueryDataset UpdateDataset(string datasetId, Dataset resource, UpdateDatasetOptions options = null) =>
        UpdateDataset(GetDatasetReference(datasetId), resource, options);
    
    /// <summary>
    /// Updates the specified dataset to match the specified resource.
    /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="UpdateDataset(DatasetReference, Dataset, UpdateDatasetOptions)"/>.
    /// </summary>
    /// <remarks>
    /// If the resource contains an ETag, it is used for optimistic concurrency validation.
    /// </remarks>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="resource">The dataset resource representation to use for the update. All updatable fields will be updated.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The updated dataset.</returns>
    public virtual BigQueryDataset UpdateDataset(string projectId, string datasetId, Dataset resource, UpdateDatasetOptions options = null) =>
        UpdateDataset(GetDatasetReference(projectId, datasetId), resource, options);
    
    /// <summary>
    /// Updates the specified dataset to match the specified resource.
    /// </summary>
    /// <remarks>
    /// If the resource contains an ETag, it is used for optimistic concurrency validation.
    /// </remarks>
    /// <param name="datasetReference">A fully-qualified identifier for the dataset. Must not be null.</param>
    /// <param name="resource">The dataset resource representation to use for the update. All updatable fields will be updated.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The updated dataset.</returns>
    public virtual BigQueryDataset UpdateDataset(DatasetReference datasetReference, Dataset resource, UpdateDatasetOptions options = null) =>
        throw new NotImplementedException();
    
    /// <summary>
    /// Asynchronously updates the specified dataset within this client's project to match the specified resource.
    /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="UpdateDatasetAsync(DatasetReference, Dataset, UpdateDatasetOptions, CancellationToken)"/>.
    /// </summary>
    /// <remarks>
    /// If the resource contains an ETag, it is used for optimistic concurrency validation.
    /// </remarks>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="resource">The dataset resource representation to use for the update. All updatable fields will be updated.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the updated dataset.</returns>
    public virtual Task<BigQueryDataset> UpdateDatasetAsync(string datasetId, Dataset resource, UpdateDatasetOptions options = null, CancellationToken cancellationToken = default) =>
        UpdateDatasetAsync(GetDatasetReference(datasetId), resource, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously updates the specified dataset to match the specified resource.
    /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="UpdateDatasetAsync(DatasetReference, Dataset, UpdateDatasetOptions, CancellationToken)"/>.
    /// </summary>
    /// <remarks>
    /// If the resource contains an ETag, it is used for optimistic concurrency validation.
    /// </remarks>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="resource">The dataset resource representation to use for the update. All updatable fields will be updated.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the updated dataset.</returns>
    public virtual Task<BigQueryDataset> UpdateDatasetAsync(string projectId, string datasetId, Dataset resource, UpdateDatasetOptions options = null, CancellationToken cancellationToken = default) =>
        UpdateDatasetAsync(GetDatasetReference(projectId, datasetId), resource, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously updates the specified dataset to match the specified resource.
    /// </summary>
    /// <remarks>
    /// If the resource contains an ETag, it is used for optimistic concurrency validation.
    /// </remarks>
    /// <param name="datasetReference">A fully-qualified identifier for the dataset. Must not be null.</param>
    /// <param name="resource">The dataset resource representation to use for the update. All updatable fields will be updated.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the updated dataset.</returns>
    public virtual Task<BigQueryDataset> UpdateDatasetAsync(DatasetReference datasetReference, Dataset resource, UpdateDatasetOptions options = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion

    #region PatchDataset
    /// <summary>
    /// Patches the specified dataset within this client's project with fields in the given resource.
    /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="PatchDataset(DatasetReference, Dataset, PatchDatasetOptions)"/>.
    /// </summary>
    /// <remarks>
    /// If the resource contains an ETag, it is used for optimistic concurrency validation.
    /// </remarks>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="resource">The dataset resource representation to use for the patch. Only fields present in the resource will be updated.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The updated dataset.</returns>
    public virtual BigQueryDataset PatchDataset(string datasetId, Dataset resource, PatchDatasetOptions options = null) =>
        PatchDataset(GetDatasetReference(datasetId), resource, options);
    
    /// <summary>
    /// Patches the specified dataset with fields in the given resource.
    /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="PatchDataset(DatasetReference, Dataset, PatchDatasetOptions)"/>.
    /// </summary>
    /// <remarks>
    /// If the resource contains an ETag, it is used for optimistic concurrency validation.
    /// </remarks>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="resource">The dataset resource representation to use for the patch. Only fields present in the resource will be updated.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The updated dataset.</returns>
    public virtual BigQueryDataset PatchDataset(string projectId, string datasetId, Dataset resource, PatchDatasetOptions options = null) =>
        PatchDataset(GetDatasetReference(projectId, datasetId), resource, options);
    
    /// <summary>
    /// Patches the specified dataset with fields in the given resource.
    /// </summary>
    /// <remarks>
    /// If the resource contains an ETag, it is used for optimistic concurrency validation.
    /// </remarks>
    /// <param name="datasetReference">A fully-qualified identifier for the dataset. Must not be null.</param>
    /// <param name="resource">The dataset resource representation to use for the patch. Only fields present in the resource will be updated.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The updated dataset.</returns>
    public virtual BigQueryDataset PatchDataset(DatasetReference datasetReference, Dataset resource, PatchDatasetOptions options = null) =>
        throw new NotImplementedException();
    
    /// <summary>
    /// Asynchronously patches the specified dataset within this client's project with fields in the given resource.
    /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="PatchDatasetAsync(DatasetReference, Dataset, PatchDatasetOptions, CancellationToken)"/>.
    /// </summary>
    /// <remarks>
    /// If the resource contains an ETag, it is used for optimistic concurrency validation.
    /// </remarks>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="resource">The dataset resource representation to use for the patch. Only fields present in the resource will be updated.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the updated dataset.</returns>
    public virtual Task<BigQueryDataset> PatchDatasetAsync(string datasetId, Dataset resource, PatchDatasetOptions options = null, CancellationToken cancellationToken = default) =>
        PatchDatasetAsync(GetDatasetReference(datasetId), resource, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously patches the specified dataset with fields in the given resource.
    /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="PatchDatasetAsync(DatasetReference, Dataset, PatchDatasetOptions, CancellationToken)"/>.
    /// </summary>
    /// <remarks>
    /// If the resource contains an ETag, it is used for optimistic concurrency validation.
    /// </remarks>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="resource">The dataset resource representation to use for the patch. Only fields present in the resource will be updated.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the updated dataset.</returns>
    public virtual Task<BigQueryDataset> PatchDatasetAsync(string projectId, string datasetId, Dataset resource, PatchDatasetOptions options = null, CancellationToken cancellationToken = default) =>
        PatchDatasetAsync(GetDatasetReference(projectId, datasetId), resource, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously patches the specified dataset with fields in the given resource.
    /// </summary>
    /// <remarks>
    /// If the resource contains an ETag, it is used for optimistic concurrency validation.
    /// </remarks>
    /// <param name="datasetReference">A fully-qualified identifier for the dataset. Must not be null.</param>
    /// <param name="resource">The dataset resource representation to use for the patch. Only fields present in the resource will be updated.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the updated dataset.</returns>
    public virtual Task<BigQueryDataset> PatchDatasetAsync(DatasetReference datasetReference, Dataset resource, PatchDatasetOptions options = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion
}
