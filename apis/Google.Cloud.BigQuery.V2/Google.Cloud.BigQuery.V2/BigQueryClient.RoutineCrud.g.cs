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
    #region GetRoutine
    /// <summary>
    /// Retrieves the specified routine within this client's project.
    /// This method just creates a <see cref="RoutineReference"/> and delegates to <see cref="GetRoutine(RoutineReference, GetRoutineOptions)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="routineId">The routine ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The requested routine.</returns>
    public virtual BigQueryRoutine GetRoutine(string datasetId, string routineId, GetRoutineOptions options = null) =>
        GetRoutine(GetRoutineReference(datasetId, routineId), options);
    
    /// <summary>
    /// Retrieves the specified routine.
    /// This method just creates a <see cref="RoutineReference"/> and delegates to <see cref="GetRoutine(RoutineReference, GetRoutineOptions)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="routineId">The routine ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The requested routine.</returns>
    public virtual BigQueryRoutine GetRoutine(string projectId, string datasetId, string routineId, GetRoutineOptions options = null) =>
        GetRoutine(GetRoutineReference(projectId, datasetId, routineId), options);
    
    /// <summary>
    /// Retrieves the specified routine.
    /// </summary>
    /// <param name="routineReference">A fully-qualified identifier for the routine. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The requested routine.</returns>
    public virtual BigQueryRoutine GetRoutine(RoutineReference routineReference, GetRoutineOptions options = null) =>
        throw new NotImplementedException();
    
    /// <summary>
    /// Asynchronously retrieves the specified routine within this client's project.
    /// This method just creates a <see cref="RoutineReference"/> and delegates to <see cref="GetRoutineAsync(RoutineReference, GetRoutineOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="routineId">The routine ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the requested routine.</returns>
    public virtual Task<BigQueryRoutine> GetRoutineAsync(string datasetId, string routineId, GetRoutineOptions options = null, CancellationToken cancellationToken = default) =>
        GetRoutineAsync(GetRoutineReference(datasetId, routineId), options, cancellationToken);
    
    /// <summary>
    /// Asynchronously retrieves the specified routine.
    /// This method just creates a <see cref="RoutineReference"/> and delegates to <see cref="GetRoutineAsync(RoutineReference, GetRoutineOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="routineId">The routine ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the requested routine.</returns>
    public virtual Task<BigQueryRoutine> GetRoutineAsync(string projectId, string datasetId, string routineId, GetRoutineOptions options = null, CancellationToken cancellationToken = default) =>
        GetRoutineAsync(GetRoutineReference(projectId, datasetId, routineId), options, cancellationToken);
    
    /// <summary>
    /// Asynchronously retrieves the specified routine.
    /// </summary>
    /// <param name="routineReference">A fully-qualified identifier for the routine. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the requested routine.</returns>
    public virtual Task<BigQueryRoutine> GetRoutineAsync(RoutineReference routineReference, GetRoutineOptions options = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion

    #region CreateRoutine
    /// <summary>
    /// Creates the specified routine within this client's project.
    /// This method just creates a <see cref="RoutineReference"/> and delegates to <see cref="CreateRoutine(RoutineReference, Routine, CreateRoutineOptions)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="routineId">The routine ID. Must not be null.</param>
    /// <param name="resource">The routine resource representation to use for the creation. Must not be null. If this routine's <see cref="Routine.RoutineReference"/> is specified, then it must be the same as the one obtained from the other parameters, else it will be set to the one obtained from the other parameters.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The newly created routine.</returns>
    public virtual BigQueryRoutine CreateRoutine(string datasetId, string routineId, Routine resource, CreateRoutineOptions options = null) =>
        CreateRoutine(GetRoutineReference(datasetId, routineId), resource, options);
    
    /// <summary>
    /// Creates the specified routine.
    /// This method just creates a <see cref="RoutineReference"/> and delegates to <see cref="CreateRoutine(RoutineReference, Routine, CreateRoutineOptions)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="routineId">The routine ID. Must not be null.</param>
    /// <param name="resource">The routine resource representation to use for the creation. Must not be null. If this routine's <see cref="Routine.RoutineReference"/> is specified, then it must be the same as the one obtained from the other parameters, else it will be set to the one obtained from the other parameters.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The newly created routine.</returns>
    public virtual BigQueryRoutine CreateRoutine(string projectId, string datasetId, string routineId, Routine resource, CreateRoutineOptions options = null) =>
        CreateRoutine(GetRoutineReference(projectId, datasetId, routineId), resource, options);
    
    /// <summary>
    /// Creates the specified routine.
    /// </summary>
    /// <param name="routineReference">A fully-qualified identifier for the routine. Must not be null.</param>
    /// <param name="resource">The routine resource representation to use for the creation. Must not be null. If this routine's <see cref="Routine.RoutineReference"/> is specified, then it must be the same as the one obtained from the other parameters, else it will be set to the one obtained from the other parameters.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The newly created routine.</returns>
    public virtual BigQueryRoutine CreateRoutine(RoutineReference routineReference, Routine resource, CreateRoutineOptions options = null) =>
        throw new NotImplementedException();
    
    /// <summary>
    /// Asynchronously creates the specified routine within this client's project.
    /// This method just creates a <see cref="RoutineReference"/> and delegates to <see cref="CreateRoutineAsync(RoutineReference, Routine, CreateRoutineOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="routineId">The routine ID. Must not be null.</param>
    /// <param name="resource">The routine resource representation to use for the creation. Must not be null. If this routine's <see cref="Routine.RoutineReference"/> is specified, then it must be the same as the one obtained from the other parameters, else it will be set to the one obtained from the other parameters.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the newly created routine.</returns>
    public virtual Task<BigQueryRoutine> CreateRoutineAsync(string datasetId, string routineId, Routine resource, CreateRoutineOptions options = null, CancellationToken cancellationToken = default) =>
        CreateRoutineAsync(GetRoutineReference(datasetId, routineId), resource, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously creates the specified routine.
    /// This method just creates a <see cref="RoutineReference"/> and delegates to <see cref="CreateRoutineAsync(RoutineReference, Routine, CreateRoutineOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="routineId">The routine ID. Must not be null.</param>
    /// <param name="resource">The routine resource representation to use for the creation. Must not be null. If this routine's <see cref="Routine.RoutineReference"/> is specified, then it must be the same as the one obtained from the other parameters, else it will be set to the one obtained from the other parameters.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the newly created routine.</returns>
    public virtual Task<BigQueryRoutine> CreateRoutineAsync(string projectId, string datasetId, string routineId, Routine resource, CreateRoutineOptions options = null, CancellationToken cancellationToken = default) =>
        CreateRoutineAsync(GetRoutineReference(projectId, datasetId, routineId), resource, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously creates the specified routine.
    /// </summary>
    /// <param name="routineReference">A fully-qualified identifier for the routine. Must not be null.</param>
    /// <param name="resource">The routine resource representation to use for the creation. Must not be null. If this routine's <see cref="Routine.RoutineReference"/> is specified, then it must be the same as the one obtained from the other parameters, else it will be set to the one obtained from the other parameters.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the newly created routine.</returns>
    public virtual Task<BigQueryRoutine> CreateRoutineAsync(RoutineReference routineReference, Routine resource, CreateRoutineOptions options = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion

    #region GetOrCreateRoutine
    /// <summary>
    /// Attempts to fetch the specified routine within this client's project, creating it if it doesn't exist.
    /// This method just creates a <see cref="RoutineReference"/> and delegates to <see cref="GetOrCreateRoutine(RoutineReference, Routine, GetRoutineOptions, CreateRoutineOptions)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="routineId">The routine ID. Must not be null.</param>
    /// <param name="resource">The routine resource representation to use for the creation. Must not be null. If this routine's <see cref="Routine.RoutineReference"/> is specified, then it must be the same as the one obtained from the other parameters, else it will be set to the one obtained from the other parameters.</param>
    /// <param name="getOptions">The options for the "get" operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="createOptions">The options for the "create" operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The existing or new routine.</returns>
    public virtual BigQueryRoutine GetOrCreateRoutine(string datasetId, string routineId, Routine resource, GetRoutineOptions getOptions = null, CreateRoutineOptions createOptions = null) =>
        GetOrCreateRoutine(GetRoutineReference(datasetId, routineId), resource, getOptions, createOptions);
    
    /// <summary>
    /// Attempts to fetch the specified routine, creating it if it doesn't exist.
    /// This method just creates a <see cref="RoutineReference"/> and delegates to <see cref="GetOrCreateRoutine(RoutineReference, Routine, GetRoutineOptions, CreateRoutineOptions)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="routineId">The routine ID. Must not be null.</param>
    /// <param name="resource">The routine resource representation to use for the creation. Must not be null. If this routine's <see cref="Routine.RoutineReference"/> is specified, then it must be the same as the one obtained from the other parameters, else it will be set to the one obtained from the other parameters.</param>
    /// <param name="getOptions">The options for the "get" operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="createOptions">The options for the "create" operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The existing or new routine.</returns>
    public virtual BigQueryRoutine GetOrCreateRoutine(string projectId, string datasetId, string routineId, Routine resource, GetRoutineOptions getOptions = null, CreateRoutineOptions createOptions = null) =>
        GetOrCreateRoutine(GetRoutineReference(projectId, datasetId, routineId), resource, getOptions, createOptions);
    
    /// <summary>
    /// Attempts to fetch the specified routine, creating it if it doesn't exist.
    /// </summary>
    /// <param name="routineReference">A fully-qualified identifier for the routine. Must not be null.</param>
    /// <param name="resource">The routine resource representation to use for the creation. Must not be null. If this routine's <see cref="Routine.RoutineReference"/> is specified, then it must be the same as the one obtained from the other parameters, else it will be set to the one obtained from the other parameters.</param>
    /// <param name="getOptions">The options for the "get" operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="createOptions">The options for the "create" operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The existing or new routine.</returns>
    public virtual BigQueryRoutine GetOrCreateRoutine(RoutineReference routineReference, Routine resource, GetRoutineOptions getOptions = null, CreateRoutineOptions createOptions = null) =>
        throw new NotImplementedException();
    
    /// <summary>
    /// Asynchronously attempts to fetch the specified routine within this client's project, creating it if it doesn't exist.
    /// This method just creates a <see cref="RoutineReference"/> and delegates to <see cref="GetOrCreateRoutineAsync(RoutineReference, Routine, GetRoutineOptions, CreateRoutineOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="routineId">The routine ID. Must not be null.</param>
    /// <param name="resource">The routine resource representation to use for the creation. Must not be null. If this routine's <see cref="Routine.RoutineReference"/> is specified, then it must be the same as the one obtained from the other parameters, else it will be set to the one obtained from the other parameters.</param>
    /// <param name="getOptions">The options for the "get" operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="createOptions">The options for the "create" operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the existing or new routine.</returns>
    public virtual Task<BigQueryRoutine> GetOrCreateRoutineAsync(string datasetId, string routineId, Routine resource, GetRoutineOptions getOptions = null, CreateRoutineOptions createOptions = null, CancellationToken cancellationToken = default) =>
        GetOrCreateRoutineAsync(GetRoutineReference(datasetId, routineId), resource, getOptions, createOptions, cancellationToken);
    
    /// <summary>
    /// Asynchronously attempts to fetch the specified routine, creating it if it doesn't exist.
    /// This method just creates a <see cref="RoutineReference"/> and delegates to <see cref="GetOrCreateRoutineAsync(RoutineReference, Routine, GetRoutineOptions, CreateRoutineOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="routineId">The routine ID. Must not be null.</param>
    /// <param name="resource">The routine resource representation to use for the creation. Must not be null. If this routine's <see cref="Routine.RoutineReference"/> is specified, then it must be the same as the one obtained from the other parameters, else it will be set to the one obtained from the other parameters.</param>
    /// <param name="getOptions">The options for the "get" operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="createOptions">The options for the "create" operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the existing or new routine.</returns>
    public virtual Task<BigQueryRoutine> GetOrCreateRoutineAsync(string projectId, string datasetId, string routineId, Routine resource, GetRoutineOptions getOptions = null, CreateRoutineOptions createOptions = null, CancellationToken cancellationToken = default) =>
        GetOrCreateRoutineAsync(GetRoutineReference(projectId, datasetId, routineId), resource, getOptions, createOptions, cancellationToken);
    
    /// <summary>
    /// Asynchronously attempts to fetch the specified routine, creating it if it doesn't exist.
    /// </summary>
    /// <param name="routineReference">A fully-qualified identifier for the routine. Must not be null.</param>
    /// <param name="resource">The routine resource representation to use for the creation. Must not be null. If this routine's <see cref="Routine.RoutineReference"/> is specified, then it must be the same as the one obtained from the other parameters, else it will be set to the one obtained from the other parameters.</param>
    /// <param name="getOptions">The options for the "get" operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="createOptions">The options for the "create" operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the existing or new routine.</returns>
    public virtual Task<BigQueryRoutine> GetOrCreateRoutineAsync(RoutineReference routineReference, Routine resource, GetRoutineOptions getOptions = null, CreateRoutineOptions createOptions = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion

    #region DeleteRoutine
    /// <summary>
    /// Deletes the specified routine within this client's project.
    /// This method just creates a <see cref="RoutineReference"/> and delegates to <see cref="DeleteRoutine(RoutineReference, DeleteRoutineOptions)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="routineId">The routine ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    public virtual void DeleteRoutine(string datasetId, string routineId, DeleteRoutineOptions options = null) =>
        DeleteRoutine(GetRoutineReference(datasetId, routineId), options);
    
    /// <summary>
    /// Deletes the specified routine.
    /// This method just creates a <see cref="RoutineReference"/> and delegates to <see cref="DeleteRoutine(RoutineReference, DeleteRoutineOptions)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="routineId">The routine ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    public virtual void DeleteRoutine(string projectId, string datasetId, string routineId, DeleteRoutineOptions options = null) =>
        DeleteRoutine(GetRoutineReference(projectId, datasetId, routineId), options);
    
    /// <summary>
    /// Deletes the specified routine.
    /// </summary>
    /// <param name="routineReference">A fully-qualified identifier for the routine. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    public virtual void DeleteRoutine(RoutineReference routineReference, DeleteRoutineOptions options = null) =>
        throw new NotImplementedException();
    
    /// <summary>
    /// Asynchronously deletes the specified routine within this client's project.
    /// This method just creates a <see cref="RoutineReference"/> and delegates to <see cref="DeleteRoutineAsync(RoutineReference, DeleteRoutineOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="routineId">The routine ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public virtual Task DeleteRoutineAsync(string datasetId, string routineId, DeleteRoutineOptions options = null, CancellationToken cancellationToken = default) =>
        DeleteRoutineAsync(GetRoutineReference(datasetId, routineId), options, cancellationToken);
    
    /// <summary>
    /// Asynchronously deletes the specified routine.
    /// This method just creates a <see cref="RoutineReference"/> and delegates to <see cref="DeleteRoutineAsync(RoutineReference, DeleteRoutineOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="routineId">The routine ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public virtual Task DeleteRoutineAsync(string projectId, string datasetId, string routineId, DeleteRoutineOptions options = null, CancellationToken cancellationToken = default) =>
        DeleteRoutineAsync(GetRoutineReference(projectId, datasetId, routineId), options, cancellationToken);
    
    /// <summary>
    /// Asynchronously deletes the specified routine.
    /// </summary>
    /// <param name="routineReference">A fully-qualified identifier for the routine. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public virtual Task DeleteRoutineAsync(RoutineReference routineReference, DeleteRoutineOptions options = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion

    #region UpdateRoutine
    /// <summary>
    /// Updates the specified routine within this client's project to match the specified resource.
    /// This method just creates a <see cref="RoutineReference"/> and delegates to <see cref="UpdateRoutine(RoutineReference, Routine, UpdateRoutineOptions)"/>.
    /// </summary>
    /// <remarks>
    /// If the resource contains an ETag, it is used for optimistic concurrency validation.
    /// </remarks>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="routineId">The routine ID. Must not be null.</param>
    /// <param name="resource">The routine resource representation to use for the update. All updatable fields will be updated. If this routine's <see cref="Routine.RoutineReference"/> is specified, then it must be the same as the one obtained from the other parameters, else it will be set to the one obtained from the other parameters.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The updated routine.</returns>
    public virtual BigQueryRoutine UpdateRoutine(string datasetId, string routineId, Routine resource, UpdateRoutineOptions options = null) =>
        UpdateRoutine(GetRoutineReference(datasetId, routineId), resource, options);
    
    /// <summary>
    /// Updates the specified routine to match the specified resource.
    /// This method just creates a <see cref="RoutineReference"/> and delegates to <see cref="UpdateRoutine(RoutineReference, Routine, UpdateRoutineOptions)"/>.
    /// </summary>
    /// <remarks>
    /// If the resource contains an ETag, it is used for optimistic concurrency validation.
    /// </remarks>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="routineId">The routine ID. Must not be null.</param>
    /// <param name="resource">The routine resource representation to use for the update. All updatable fields will be updated. If this routine's <see cref="Routine.RoutineReference"/> is specified, then it must be the same as the one obtained from the other parameters, else it will be set to the one obtained from the other parameters.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The updated routine.</returns>
    public virtual BigQueryRoutine UpdateRoutine(string projectId, string datasetId, string routineId, Routine resource, UpdateRoutineOptions options = null) =>
        UpdateRoutine(GetRoutineReference(projectId, datasetId, routineId), resource, options);
    
    /// <summary>
    /// Updates the specified routine to match the specified resource.
    /// </summary>
    /// <remarks>
    /// If the resource contains an ETag, it is used for optimistic concurrency validation.
    /// </remarks>
    /// <param name="routineReference">A fully-qualified identifier for the routine. Must not be null.</param>
    /// <param name="resource">The routine resource representation to use for the update. All updatable fields will be updated. If this routine's <see cref="Routine.RoutineReference"/> is specified, then it must be the same as the one obtained from the other parameters, else it will be set to the one obtained from the other parameters.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The updated routine.</returns>
    public virtual BigQueryRoutine UpdateRoutine(RoutineReference routineReference, Routine resource, UpdateRoutineOptions options = null) =>
        throw new NotImplementedException();
    
    /// <summary>
    /// Asynchronously updates the specified routine within this client's project to match the specified resource.
    /// This method just creates a <see cref="RoutineReference"/> and delegates to <see cref="UpdateRoutineAsync(RoutineReference, Routine, UpdateRoutineOptions, CancellationToken)"/>.
    /// </summary>
    /// <remarks>
    /// If the resource contains an ETag, it is used for optimistic concurrency validation.
    /// </remarks>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="routineId">The routine ID. Must not be null.</param>
    /// <param name="resource">The routine resource representation to use for the update. All updatable fields will be updated. If this routine's <see cref="Routine.RoutineReference"/> is specified, then it must be the same as the one obtained from the other parameters, else it will be set to the one obtained from the other parameters.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the updated routine.</returns>
    public virtual Task<BigQueryRoutine> UpdateRoutineAsync(string datasetId, string routineId, Routine resource, UpdateRoutineOptions options = null, CancellationToken cancellationToken = default) =>
        UpdateRoutineAsync(GetRoutineReference(datasetId, routineId), resource, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously updates the specified routine to match the specified resource.
    /// This method just creates a <see cref="RoutineReference"/> and delegates to <see cref="UpdateRoutineAsync(RoutineReference, Routine, UpdateRoutineOptions, CancellationToken)"/>.
    /// </summary>
    /// <remarks>
    /// If the resource contains an ETag, it is used for optimistic concurrency validation.
    /// </remarks>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="routineId">The routine ID. Must not be null.</param>
    /// <param name="resource">The routine resource representation to use for the update. All updatable fields will be updated. If this routine's <see cref="Routine.RoutineReference"/> is specified, then it must be the same as the one obtained from the other parameters, else it will be set to the one obtained from the other parameters.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the updated routine.</returns>
    public virtual Task<BigQueryRoutine> UpdateRoutineAsync(string projectId, string datasetId, string routineId, Routine resource, UpdateRoutineOptions options = null, CancellationToken cancellationToken = default) =>
        UpdateRoutineAsync(GetRoutineReference(projectId, datasetId, routineId), resource, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously updates the specified routine to match the specified resource.
    /// </summary>
    /// <remarks>
    /// If the resource contains an ETag, it is used for optimistic concurrency validation.
    /// </remarks>
    /// <param name="routineReference">A fully-qualified identifier for the routine. Must not be null.</param>
    /// <param name="resource">The routine resource representation to use for the update. All updatable fields will be updated. If this routine's <see cref="Routine.RoutineReference"/> is specified, then it must be the same as the one obtained from the other parameters, else it will be set to the one obtained from the other parameters.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the updated routine.</returns>
    public virtual Task<BigQueryRoutine> UpdateRoutineAsync(RoutineReference routineReference, Routine resource, UpdateRoutineOptions options = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion
}
