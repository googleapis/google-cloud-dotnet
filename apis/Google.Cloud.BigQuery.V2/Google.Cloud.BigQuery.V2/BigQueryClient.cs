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
using Google.Apis.Auth.OAuth2;
using Google.Apis.Bigquery.v2;
using Google.Apis.Bigquery.v2.Data;
using Google.Apis.Json;
using Google.Apis.Services;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Abstract class providing operations for Google Cloud BigQuery.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This abstract class is provided to enable testability while permitting
    /// additional operations to be added in the future. See <see cref="Create(string, GoogleCredential)"/>
    /// and <see cref="CreateAsync(string, GoogleCredential)"/> to construct instances; alternatively, you can
    /// construct a <see cref="BigQueryClientImpl"/> directly from a <see cref="BigqueryService"/>.
    /// </para>
    /// <para>
    /// All instance methods declared in this class are virtual, with an implementation which simply
    /// throws <see cref="NotImplementedException"/>. All these methods are overridden in <see cref="BigQueryClientImpl"/>.
    /// </para>
    /// </remarks>
    public abstract partial class BigQueryClient
    {
        private static readonly ScopedCredentialProvider _credentialProvider = new ScopedCredentialProvider(
            new[] {
                BigqueryService.Scope.Bigquery,
                BigqueryService.Scope.BigqueryInsertdata,
                BigqueryService.Scope.DevstorageFullControl,
                BigqueryService.Scope.CloudPlatform
            });

        /// <summary>
        /// The underlying BigQuery service object used by this client.
        /// </summary>
        /// <remarks>
        /// The <see cref="BigQueryClient"/> class only provides convenience operations built on top of
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
        /// Asynchronously creates a <see cref="BigQueryClient"/>, using application default credentials if
        /// no credentials are specified.
        /// </summary>
        /// <remarks>
        /// The credentials are scoped as necessary.
        /// </remarks>
        /// <param name="projectId">The ID of the project containing the BigQuery data. Must not be null.</param>
        /// <param name="credential">Optional <see cref="GoogleCredential"/>.</param>
        /// <returns>The task representing the created <see cref="BigQueryClient"/>.</returns>
        public static async Task<BigQueryClient> CreateAsync(string projectId, GoogleCredential credential = null)
        {
            GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            var scopedCredentials = await _credentialProvider.GetCredentialsAsync(credential).ConfigureAwait(false);
            return CreateImpl(projectId, scopedCredentials);
        }

        /// <summary>
        /// Synchronously creates a <see cref="BigQueryClient"/>, using application default credentials if
        /// no credentials are specified.
        /// </summary>
        /// <remarks>
        /// The credentials are scoped as necessary.
        /// </remarks>
        /// <param name="projectId">The ID of the project containing the BigQuery data. Must not be null.</param>
        /// <param name="credential">Optional <see cref="GoogleCredential"/>.</param>
        /// <returns>The created <see cref="BigQueryClient"/>.</returns>
        public static BigQueryClient Create(string projectId, GoogleCredential credential = null)
        {
            GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            var scopedCredentials = _credentialProvider.GetCredentials(credential);
            return CreateImpl(projectId, scopedCredentials);
        }

        private static BigQueryClient CreateImpl(string projectId, GoogleCredential scopedCredentials)
        {
            var service = new BigqueryService(new BaseClientService.Initializer
            {
                HttpClientInitializer = scopedCredentials,
                ApplicationName = BigQueryClientImpl.ApplicationName,
                Serializer = new NewtonsoftJsonSerializer(CreateJsonSerializersSettings())
            });

            return new BigQueryClientImpl(projectId, service);
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
                ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId)),
                DatasetId = GaxPreconditions.CheckNotNull(datasetId, nameof(datasetId)),
                TableId = GaxPreconditions.CheckNotNull(tableId, nameof(tableId)),
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
                ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId)),
                DatasetId = GaxPreconditions.CheckNotNull(datasetId, nameof(datasetId)),
            };

        /// <summary>
        /// Creates a <see cref="ProjectReference"/> from the given project ID.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <returns>A <see cref="ProjectReference"/> representing the requested project.</returns>
        public ProjectReference GetProjectReference(string projectId) =>
            new ProjectReference
            {
                ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId)),
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
                ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId)),
                JobId = GaxPreconditions.CheckNotNull(jobId, nameof(jobId))
            };
        
        /// <summary>
        /// Creates a set of <see cref="JsonSerializerSettings"/> suitable for specifying in
        /// <see cref="BigqueryService"/> construction. The settings have Json.NET date parsing
        /// detection disabled.
        /// </summary>
        /// <returns>A suitable set of settings.</returns>
        public static JsonSerializerSettings CreateJsonSerializersSettings()
        {
            JsonSerializerSettings settings = NewtonsoftJsonSerializer.CreateDefaultSettings();
            settings.DateParseHandling = DateParseHandling.None;
            return settings;
        }
    }
}
