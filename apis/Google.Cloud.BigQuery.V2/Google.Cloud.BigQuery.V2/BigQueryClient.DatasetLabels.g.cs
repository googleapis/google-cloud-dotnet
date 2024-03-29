// Copyright 2017 Google Inc. All Rights Reserved.
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
    #region SetDatasetLabel
    /// <summary>
    /// Sets the value for a single label on a dataset. The label will be added if it does
    /// not exist, or updated if it already exists.
    /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="SetDatasetLabel(DatasetReference, string, string, ModifyLabelsOptions)"/>.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The dataset is first fetched to retrieve the current values, then a patch call is made.
    /// </para>
    /// </remarks>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="labelName">The name of the label. Must not be null.</param>
    /// <param name="labelValue">The new value of the label. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The previous value of the label, or <c>null</c> if the label was not previously set.</returns>
    public virtual string SetDatasetLabel(string datasetId, string labelName, string labelValue, ModifyLabelsOptions options = null) =>
        SetDatasetLabel(GetDatasetReference(datasetId), labelName, labelValue, options);
    
    /// <summary>
    /// Sets the value for a single label on a dataset. The label will be added if it does
    /// not exist, or updated if it already exists.
    /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="SetDatasetLabel(DatasetReference, string, string, ModifyLabelsOptions)"/>.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The dataset is first fetched to retrieve the current values, then a patch call is made.
    /// </para>
    /// </remarks>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="labelName">The name of the label. Must not be null.</param>
    /// <param name="labelValue">The new value of the label. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The previous value of the label, or <c>null</c> if the label was not previously set.</returns>
    public virtual string SetDatasetLabel(string projectId, string datasetId, string labelName, string labelValue, ModifyLabelsOptions options = null) =>
        SetDatasetLabel(GetDatasetReference(projectId, datasetId), labelName, labelValue, options);
    
    /// <summary>
    /// Sets the value for a single label on a dataset. The label will be added if it does
    /// not exist, or updated if it already exists.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The dataset is first fetched to retrieve the current values, then a patch call is made.
    /// </para>
    /// </remarks>
    /// <param name="datasetReference">A fully-qualified identifier for the dataset. Must not be null.</param>
    /// <param name="labelName">The name of the label. Must not be null.</param>
    /// <param name="labelValue">The new value of the label. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The previous value of the label, or <c>null</c> if the label was not previously set.</returns>
    public virtual string SetDatasetLabel(DatasetReference datasetReference, string labelName, string labelValue, ModifyLabelsOptions options = null) =>
        throw new NotImplementedException();
    
    /// <summary>
    /// Asynchronously sets the value for a single label on a dataset. The label will be added if it does
    /// not exist, or updated if it already exists.
    /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="SetDatasetLabelAsync(DatasetReference, string, string, ModifyLabelsOptions, CancellationToken)"/>.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The dataset is first fetched to retrieve the current values, then a patch call is made.
    /// </para>
    /// </remarks>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="labelName">The name of the label. Must not be null.</param>
    /// <param name="labelValue">The new value of the label. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the previous value of the label, or <c>null</c> if the label was not previously set.</returns>
    public virtual Task<string> SetDatasetLabelAsync(string datasetId, string labelName, string labelValue, ModifyLabelsOptions options = null, CancellationToken cancellationToken = default) =>
        SetDatasetLabelAsync(GetDatasetReference(datasetId), labelName, labelValue, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously sets the value for a single label on a dataset. The label will be added if it does
    /// not exist, or updated if it already exists.
    /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="SetDatasetLabelAsync(DatasetReference, string, string, ModifyLabelsOptions, CancellationToken)"/>.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The dataset is first fetched to retrieve the current values, then a patch call is made.
    /// </para>
    /// </remarks>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="labelName">The name of the label. Must not be null.</param>
    /// <param name="labelValue">The new value of the label. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the previous value of the label, or <c>null</c> if the label was not previously set.</returns>
    public virtual Task<string> SetDatasetLabelAsync(string projectId, string datasetId, string labelName, string labelValue, ModifyLabelsOptions options = null, CancellationToken cancellationToken = default) =>
        SetDatasetLabelAsync(GetDatasetReference(projectId, datasetId), labelName, labelValue, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously sets the value for a single label on a dataset. The label will be added if it does
    /// not exist, or updated if it already exists.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The dataset is first fetched to retrieve the current values, then a patch call is made.
    /// </para>
    /// </remarks>
    /// <param name="datasetReference">A fully-qualified identifier for the dataset. Must not be null.</param>
    /// <param name="labelName">The name of the label. Must not be null.</param>
    /// <param name="labelValue">The new value of the label. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the previous value of the label, or <c>null</c> if the label was not previously set.</returns>
    public virtual Task<string> SetDatasetLabelAsync(DatasetReference datasetReference, string labelName, string labelValue, ModifyLabelsOptions options = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion

    #region RemoveDatasetLabel
    /// <summary>
    /// Removes a label from a dataset, if it previously existed. It is not an error to
    /// attempt to remove a label that doesn't already exist.
    /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="RemoveDatasetLabel(DatasetReference, string, ModifyLabelsOptions)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="labelName">The name of the label. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The previous value of the label, or <c>null</c> if the label was not previously set.</returns>
    public virtual string RemoveDatasetLabel(string datasetId, string labelName, ModifyLabelsOptions options = null) =>
        RemoveDatasetLabel(GetDatasetReference(datasetId), labelName, options);
    
    /// <summary>
    /// Removes a label from a dataset, if it previously existed. It is not an error to
    /// attempt to remove a label that doesn't already exist.
    /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="RemoveDatasetLabel(DatasetReference, string, ModifyLabelsOptions)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="labelName">The name of the label. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The previous value of the label, or <c>null</c> if the label was not previously set.</returns>
    public virtual string RemoveDatasetLabel(string projectId, string datasetId, string labelName, ModifyLabelsOptions options = null) =>
        RemoveDatasetLabel(GetDatasetReference(projectId, datasetId), labelName, options);
    
    /// <summary>
    /// Removes a label from a dataset, if it previously existed. It is not an error to
    /// attempt to remove a label that doesn't already exist.
    /// </summary>
    /// <param name="datasetReference">A fully-qualified identifier for the dataset. Must not be null.</param>
    /// <param name="labelName">The name of the label. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The previous value of the label, or <c>null</c> if the label was not previously set.</returns>
    public virtual string RemoveDatasetLabel(DatasetReference datasetReference, string labelName, ModifyLabelsOptions options = null) =>
        throw new NotImplementedException();
    
    /// <summary>
    /// Asynchronously removes a label from a dataset, if it previously existed. It is not an error to
    /// attempt to remove a label that doesn't already exist.
    /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="RemoveDatasetLabelAsync(DatasetReference, string, ModifyLabelsOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="labelName">The name of the label. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the previous value of the label, or <c>null</c> if the label was not previously set.</returns>
    public virtual Task<string> RemoveDatasetLabelAsync(string datasetId, string labelName, ModifyLabelsOptions options = null, CancellationToken cancellationToken = default) =>
        RemoveDatasetLabelAsync(GetDatasetReference(datasetId), labelName, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously removes a label from a dataset, if it previously existed. It is not an error to
    /// attempt to remove a label that doesn't already exist.
    /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="RemoveDatasetLabelAsync(DatasetReference, string, ModifyLabelsOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="labelName">The name of the label. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the previous value of the label, or <c>null</c> if the label was not previously set.</returns>
    public virtual Task<string> RemoveDatasetLabelAsync(string projectId, string datasetId, string labelName, ModifyLabelsOptions options = null, CancellationToken cancellationToken = default) =>
        RemoveDatasetLabelAsync(GetDatasetReference(projectId, datasetId), labelName, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously removes a label from a dataset, if it previously existed. It is not an error to
    /// attempt to remove a label that doesn't already exist.
    /// </summary>
    /// <param name="datasetReference">A fully-qualified identifier for the dataset. Must not be null.</param>
    /// <param name="labelName">The name of the label. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the previous value of the label, or <c>null</c> if the label was not previously set.</returns>
    public virtual Task<string> RemoveDatasetLabelAsync(DatasetReference datasetReference, string labelName, ModifyLabelsOptions options = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion

    #region ClearDatasetLabels
    /// <summary>
    /// Clears all labels on the specified dataset within this client's project.
    /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="ClearDatasetLabels(DatasetReference, ModifyLabelsOptions)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>A dictionary with the labels on the dataset before they were cleared.</returns>
    public virtual IDictionary<string, string> ClearDatasetLabels(string datasetId, ModifyLabelsOptions options = null) =>
        ClearDatasetLabels(GetDatasetReference(datasetId), options);
    
    /// <summary>
    /// Clears all labels on the specified dataset.
    /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="ClearDatasetLabels(DatasetReference, ModifyLabelsOptions)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>A dictionary with the labels on the dataset before they were cleared.</returns>
    public virtual IDictionary<string, string> ClearDatasetLabels(string projectId, string datasetId, ModifyLabelsOptions options = null) =>
        ClearDatasetLabels(GetDatasetReference(projectId, datasetId), options);
    
    /// <summary>
    /// Clears all labels on the specified dataset.
    /// </summary>
    /// <param name="datasetReference">A fully-qualified identifier for the dataset. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>A dictionary with the labels on the dataset before they were cleared.</returns>
    public virtual IDictionary<string, string> ClearDatasetLabels(DatasetReference datasetReference, ModifyLabelsOptions options = null) =>
        throw new NotImplementedException();
    
    /// <summary>
    /// Asynchronously clears all labels on the specified dataset within this client's project.
    /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="ClearDatasetLabelsAsync(DatasetReference, ModifyLabelsOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// a dictionary with the labels on the dataset before they were cleared.</returns>
    public virtual Task<IDictionary<string, string>> ClearDatasetLabelsAsync(string datasetId, ModifyLabelsOptions options = null, CancellationToken cancellationToken = default) =>
        ClearDatasetLabelsAsync(GetDatasetReference(datasetId), options, cancellationToken);
    
    /// <summary>
    /// Asynchronously clears all labels on the specified dataset.
    /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="ClearDatasetLabelsAsync(DatasetReference, ModifyLabelsOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// a dictionary with the labels on the dataset before they were cleared.</returns>
    public virtual Task<IDictionary<string, string>> ClearDatasetLabelsAsync(string projectId, string datasetId, ModifyLabelsOptions options = null, CancellationToken cancellationToken = default) =>
        ClearDatasetLabelsAsync(GetDatasetReference(projectId, datasetId), options, cancellationToken);
    
    /// <summary>
    /// Asynchronously clears all labels on the specified dataset.
    /// </summary>
    /// <param name="datasetReference">A fully-qualified identifier for the dataset. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// a dictionary with the labels on the dataset before they were cleared.</returns>
    public virtual Task<IDictionary<string, string>> ClearDatasetLabelsAsync(DatasetReference datasetReference, ModifyLabelsOptions options = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion

    #region ModifyDatasetLabels
    /// <summary>
    /// Sets or removes one or more labels on the specified dataset within this client's project.
    /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="ModifyDatasetLabels(DatasetReference, IDictionary{string, string}, ModifyLabelsOptions)"/>.
    /// </summary>
    /// <remarks>
    /// Each entry in <paramref name="labels" /> is treated as a label to set or remove. If the value is null,
    /// it will be removed from the dataset; otherwise, it will be set/added. Labels which do not have an entry
    /// in the dictionary will be ignored.
    /// </remarks>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="labels">The labels to set. Must contain at least one entry; keys must not be null, but values may be (indicating label removal).</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>
    /// A dictionary with the same keys as <paramref name="labels" />, and values indicating the corresponding label value
    /// before this operation completed. Labels which weren't present on the dataset before the modification have corresponding
    /// null values in the returned dictionary.
    /// </returns>
    public virtual IDictionary<string, string> ModifyDatasetLabels(string datasetId, IDictionary<string, string> labels, ModifyLabelsOptions options = null) =>
        ModifyDatasetLabels(GetDatasetReference(datasetId), labels, options);
    
    /// <summary>
    /// Sets or removes one or more labels on the specified dataset.
    /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="ModifyDatasetLabels(DatasetReference, IDictionary{string, string}, ModifyLabelsOptions)"/>.
    /// </summary>
    /// <remarks>
    /// Each entry in <paramref name="labels" /> is treated as a label to set or remove. If the value is null,
    /// it will be removed from the dataset; otherwise, it will be set/added. Labels which do not have an entry
    /// in the dictionary will be ignored.
    /// </remarks>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="labels">The labels to set. Must contain at least one entry; keys must not be null, but values may be (indicating label removal).</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>
    /// A dictionary with the same keys as <paramref name="labels" />, and values indicating the corresponding label value
    /// before this operation completed. Labels which weren't present on the dataset before the modification have corresponding
    /// null values in the returned dictionary.
    /// </returns>
    public virtual IDictionary<string, string> ModifyDatasetLabels(string projectId, string datasetId, IDictionary<string, string> labels, ModifyLabelsOptions options = null) =>
        ModifyDatasetLabels(GetDatasetReference(projectId, datasetId), labels, options);
    
    /// <summary>
    /// Sets or removes one or more labels on the specified dataset.
    /// </summary>
    /// <remarks>
    /// Each entry in <paramref name="labels" /> is treated as a label to set or remove. If the value is null,
    /// it will be removed from the dataset; otherwise, it will be set/added. Labels which do not have an entry
    /// in the dictionary will be ignored.
    /// </remarks>
    /// <param name="datasetReference">A fully-qualified identifier for the dataset. Must not be null.</param>
    /// <param name="labels">The labels to set. Must contain at least one entry; keys must not be null, but values may be (indicating label removal).</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>
    /// A dictionary with the same keys as <paramref name="labels" />, and values indicating the corresponding label value
    /// before this operation completed. Labels which weren't present on the dataset before the modification have corresponding
    /// null values in the returned dictionary.
    /// </returns>
    public virtual IDictionary<string, string> ModifyDatasetLabels(DatasetReference datasetReference, IDictionary<string, string> labels, ModifyLabelsOptions options = null) =>
        throw new NotImplementedException();
    
    /// <summary>
    /// Asynchronously sets or removes one or more labels on the specified dataset within this client's project.
    /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="ModifyDatasetLabelsAsync(DatasetReference, IDictionary{string, string}, ModifyLabelsOptions, CancellationToken)"/>.
    /// </summary>
    /// <remarks>
    /// Each entry in <paramref name="labels" /> is treated as a label to set or remove. If the value is null,
    /// it will be removed from the dataset; otherwise, it will be set/added. Labels which do not have an entry
    /// in the dictionary will be ignored.
    /// </remarks>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="labels">The labels to set. Must contain at least one entry; keys must not be null, but values may be (indicating label removal).</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// a dictionary with the same keys as <paramref name="labels" />, and values indicating the corresponding label value
    /// before this operation completed. Labels which weren't present on the dataset before the modification have corresponding
    /// null values in the returned dictionary.
    /// </returns>
    public virtual Task<IDictionary<string, string>> ModifyDatasetLabelsAsync(string datasetId, IDictionary<string, string> labels, ModifyLabelsOptions options = null, CancellationToken cancellationToken = default) =>
        ModifyDatasetLabelsAsync(GetDatasetReference(datasetId), labels, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously sets or removes one or more labels on the specified dataset.
    /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="ModifyDatasetLabelsAsync(DatasetReference, IDictionary{string, string}, ModifyLabelsOptions, CancellationToken)"/>.
    /// </summary>
    /// <remarks>
    /// Each entry in <paramref name="labels" /> is treated as a label to set or remove. If the value is null,
    /// it will be removed from the dataset; otherwise, it will be set/added. Labels which do not have an entry
    /// in the dictionary will be ignored.
    /// </remarks>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="datasetId">The dataset ID. Must not be null.</param>
    /// <param name="labels">The labels to set. Must contain at least one entry; keys must not be null, but values may be (indicating label removal).</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// a dictionary with the same keys as <paramref name="labels" />, and values indicating the corresponding label value
    /// before this operation completed. Labels which weren't present on the dataset before the modification have corresponding
    /// null values in the returned dictionary.
    /// </returns>
    public virtual Task<IDictionary<string, string>> ModifyDatasetLabelsAsync(string projectId, string datasetId, IDictionary<string, string> labels, ModifyLabelsOptions options = null, CancellationToken cancellationToken = default) =>
        ModifyDatasetLabelsAsync(GetDatasetReference(projectId, datasetId), labels, options, cancellationToken);
    
    /// <summary>
    /// Asynchronously sets or removes one or more labels on the specified dataset.
    /// </summary>
    /// <remarks>
    /// Each entry in <paramref name="labels" /> is treated as a label to set or remove. If the value is null,
    /// it will be removed from the dataset; otherwise, it will be set/added. Labels which do not have an entry
    /// in the dictionary will be ignored.
    /// </remarks>
    /// <param name="datasetReference">A fully-qualified identifier for the dataset. Must not be null.</param>
    /// <param name="labels">The labels to set. Must contain at least one entry; keys must not be null, but values may be (indicating label removal).</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// a dictionary with the same keys as <paramref name="labels" />, and values indicating the corresponding label value
    /// before this operation completed. Labels which weren't present on the dataset before the modification have corresponding
    /// null values in the returned dictionary.
    /// </returns>
    public virtual Task<IDictionary<string, string>> ModifyDatasetLabelsAsync(DatasetReference datasetReference, IDictionary<string, string> labels, ModifyLabelsOptions options = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion
}
