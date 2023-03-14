// Copyright 2018 Google LLC
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
    #region GetBigQueryServiceAccountEmail
    /// <summary>
    /// Retrieves the service account email address that Google Cloud BigQuery uses for operations on
    /// other services such as the Google Cloud Key Management Service.
    /// This method just creates a <see cref="ProjectReference"/> and delegates to <see cref="GetBigQueryServiceAccountEmail(ProjectReference, GetBigQueryServiceAccountEmailOptions)"/>.
    /// </summary>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The email address of the service account.</returns>
    public virtual string GetBigQueryServiceAccountEmail(GetBigQueryServiceAccountEmailOptions options = null) =>
        GetBigQueryServiceAccountEmail(GetProjectReference(), options);
    
    /// <summary>
    /// Retrieves the service account email address that Google Cloud BigQuery uses for operations on
    /// other services such as the Google Cloud Key Management Service.
    /// This method just creates a <see cref="ProjectReference"/> and delegates to <see cref="GetBigQueryServiceAccountEmail(ProjectReference, GetBigQueryServiceAccountEmailOptions)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The email address of the service account.</returns>
    public virtual string GetBigQueryServiceAccountEmail(string projectId, GetBigQueryServiceAccountEmailOptions options = null) =>
        GetBigQueryServiceAccountEmail(GetProjectReference(projectId), options);
    
    /// <summary>
    /// Retrieves the service account email address that Google Cloud BigQuery uses for operations on
    /// other services such as the Google Cloud Key Management Service.
    /// </summary>
    /// <param name="projectReference">A fully-qualified identifier for the project. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <returns>The email address of the service account.</returns>
    public virtual string GetBigQueryServiceAccountEmail(ProjectReference projectReference, GetBigQueryServiceAccountEmailOptions options = null) =>
        throw new NotImplementedException();
    
    /// <summary>
    /// Asynchronously retrieves the service account email address that Google Cloud BigQuery uses for operations on
    /// other services such as the Google Cloud Key Management Service.
    /// This method just creates a <see cref="ProjectReference"/> and delegates to <see cref="GetBigQueryServiceAccountEmailAsync(ProjectReference, GetBigQueryServiceAccountEmailOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the email address of the service account.</returns>
    public virtual Task<string> GetBigQueryServiceAccountEmailAsync(GetBigQueryServiceAccountEmailOptions options = null, CancellationToken cancellationToken = default) =>
        GetBigQueryServiceAccountEmailAsync(GetProjectReference(), options, cancellationToken);
    
    /// <summary>
    /// Asynchronously retrieves the service account email address that Google Cloud BigQuery uses for operations on
    /// other services such as the Google Cloud Key Management Service.
    /// This method just creates a <see cref="ProjectReference"/> and delegates to <see cref="GetBigQueryServiceAccountEmailAsync(ProjectReference, GetBigQueryServiceAccountEmailOptions, CancellationToken)"/>.
    /// </summary>
    /// <param name="projectId">The project ID. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the email address of the service account.</returns>
    public virtual Task<string> GetBigQueryServiceAccountEmailAsync(string projectId, GetBigQueryServiceAccountEmailOptions options = null, CancellationToken cancellationToken = default) =>
        GetBigQueryServiceAccountEmailAsync(GetProjectReference(projectId), options, cancellationToken);
    
    /// <summary>
    /// Asynchronously retrieves the service account email address that Google Cloud BigQuery uses for operations on
    /// other services such as the Google Cloud Key Management Service.
    /// </summary>
    /// <param name="projectReference">A fully-qualified identifier for the project. Must not be null.</param>
    /// <param name="options">The options for the operation. May be null, in which case defaults will be supplied.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task representing the asynchronous operation. When complete, the result is
    /// the email address of the service account.</returns>
    public virtual Task<string> GetBigQueryServiceAccountEmailAsync(ProjectReference projectReference, GetBigQueryServiceAccountEmailOptions options = null, CancellationToken cancellationToken = default) =>
        throw new NotImplementedException();
    #endregion
}
