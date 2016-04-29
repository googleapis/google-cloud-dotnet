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

using Google.Apis.Auth.OAuth2;
using Google.Apis.Bigquery.v2;
using Google.Apis.Bigquery.v2.Data;
using Google.Apis.Services;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Google.Bigquery.V2
{
    /// <summary>
    /// Abstract class providing operations for Google Cloud Bigquery.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This abstract class is provided to enable testability while permitting
    /// additional operations to be added in the future. See <see cref="Create(GoogleCredential)"/>
    /// and <see cref="CreateAsync(GoogleCredential)"/> to construct instances; alternatively, you can
    /// construct a <see cref="BigqueryClientImpl"/> directly from a <see cref="BigqueryService"/>.
    /// </para>
    /// <para>
    /// All instance methods declared in this class are virtual, with an implementation which simply
    /// throws <see cref="NotImplementedException"/>. All these methods are overridden in <see cref="BigqueryClientImpl"/>.
    /// </para>
    /// </remarks>
    public abstract partial class BigqueryClient
    {
        /// <summary>
        /// The underlying Bigquery service object used by this client.
        /// </summary>
        /// <remarks>
        /// The <see cref="BigqueryClient"/> class only provides convenience operations built on top of
        /// an existing service object. Any more complex operations which are not supported by this wrapper may wish
        /// to use the same service object as the wrapper, in order to take advantage of its configuration (for authentication,
        /// application naming etc).
        /// </remarks>
        public virtual BigqueryService Service { get { throw new NotImplementedException(); } }

        /// <summary>
        /// The ID of the project this client operates on. All operations that require a
        /// project to be specified implicitly supply this ID.
        /// </summary>
        public virtual string ProjectId { get { throw new NotImplementedException(); } }

        /// <summary>
        /// Asynchronously creates a <see cref="BigqueryClient"/>, using application default credentials if
        /// no credentials are specified.
        /// </summary>
        /// <remarks>
        /// The credentials are scoped as necessary.
        /// </remarks>
        /// <param name="credential">Optional <see cref="GoogleCredential"/>.</param>
        /// <returns>The task representing the created <see cref="BigqueryClient"/>.</returns>
        public static async Task<BigqueryClient> CreateAsync(string projectId, GoogleCredential credential = null) =>
            // If no credentials have been specified, we fetch them "properly asynchronously"
            // to avoid the Task.Run in the synchronous call
            Create(
                Preconditions.CheckNotNull(projectId, nameof(projectId)),
                credential ?? await GoogleCredential.GetApplicationDefaultAsync().ConfigureAwait(false));

        /// <summary>
        /// Synchronously creates a <see cref="BigqueryClient"/>, using application default credentials if
        /// no credentials are specified.
        /// </summary>
        /// <remarks>
        /// The credentials are scoped as necessary.
        /// </remarks>
        /// <param name="credential">Optional <see cref="GoogleCredential"/>.</param>
        /// <returns>The created <see cref="BigqueryClient"/>.</returns>
        public static BigqueryClient Create(string projectId, GoogleCredential credential = null)
        {
            Preconditions.CheckNotNull(projectId, nameof(projectId));
            try
            {
                credential = credential ?? Task.Run(() => GoogleCredential.GetApplicationDefaultAsync()).Result;
            }
            catch (AggregateException e)
            {
                // Unwrap the first exception, a bit like await would.
                // It's very unlikely that we'd ever see an AggregateException without an inner exceptions,
                // but let's handle it relatively gracefully.
                throw e.InnerExceptions.FirstOrDefault() ?? e;
            }
            if (credential.IsCreateScopedRequired)
            {
                credential = credential.CreateScoped(
                    // FIXME: Work out which of these we actually need.
                    BigqueryService.Scope.Bigquery,
                    BigqueryService.Scope.BigqueryInsertdata,
                    BigqueryService.Scope.DevstorageFullControl,
                    BigqueryService.Scope.CloudPlatform);
            }
            var service = new BigqueryService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = BigqueryClientImpl.ApplicationName,
            });

            return new BigqueryClientImpl(projectId, service);
        }

        /// <summary>
        /// Creates a <see cref="TableReference"/> from the given dataset ID and table ID,
        /// using this client's project ID.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <returns>A <see cref="TableReference"/> representing the requested table.</returns>
        public TableReference GetTableReference(string datasetId, string tableId) =>
            GetTableReference(ProjectId, datasetId, tableId);

        /// <summary>
        /// Creates a <see cref="TableReference"/> from the given project ID, dataset ID and table ID.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="tableId">The table ID. Must not be null.</param>
        /// <returns>A <see cref="TableReference"/> representing the requested table.</returns>
        public TableReference GetTableReference(string projectId, string datasetId, string tableId) =>
            new TableReference
            {
                ProjectId = Preconditions.CheckNotNull(projectId, nameof(projectId)),
                DatasetId = Preconditions.CheckNotNull(datasetId, nameof(datasetId)),
                TableId = Preconditions.CheckNotNull(tableId, nameof(tableId)),
            };

        /// <summary>
        /// Creates a <see cref="DatasetReference"/> from the given dataset ID,
        /// using this client's project ID.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <returns>A <see cref="DatasetReference"/> representing the requested dataset.</returns>
        public DatasetReference GetDatasetReference(string datasetId) =>
            GetDatasetReference(ProjectId, datasetId);

        /// <summary>
        /// Creates a <see cref="DatasetReference"/> from the given project ID and dataset ID.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <returns>A <see cref="DatasetReference"/> representing the requested dataset.</returns>
        public DatasetReference GetDatasetReference(string projectId, string datasetId) =>
            new DatasetReference
            {
                ProjectId = Preconditions.CheckNotNull(projectId, nameof(projectId)),
                DatasetId = Preconditions.CheckNotNull(datasetId, nameof(datasetId)),
            };

        /// <summary>
        /// Creates a <see cref="ProjectReference"/> from the given project ID.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <returns>A <see cref="ProjectReference"/> representing the requested project.</returns>
        public ProjectReference GetProjectReference(string projectId) =>
            new ProjectReference
            {
                ProjectId = Preconditions.CheckNotNull(projectId, nameof(projectId)),
            };

        /// <summary>
        /// Creates a <see cref="JobReference"/> from the given job ID,
        /// using this client's project ID.
        /// </summary>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <returns>A <see cref="JobReference"/> representing the requested job.</returns>
        public JobReference GetJobReference(string jobId) =>
            GetJobReference(ProjectId, jobId);

        /// <summary>
        /// Creates a <see cref="JobReference"/> from the given project ID and job ID.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <returns>A <see cref="JobReference"/> representing the requested job.</returns>
        public JobReference GetJobReference(string projectId, string jobId) =>
            new JobReference
            {
                ProjectId = Preconditions.CheckNotNull(projectId, nameof(projectId)),
                JobId = Preconditions.CheckNotNull(jobId, nameof(jobId))
            };
    }
}
