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
using Google.Apis.Requests;
using Newtonsoft.Json;
using System;
using System.Net;
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
    /// <para>
    /// This class implements <see cref="IDisposable"/>; however, the <see cref="Dispose"/> method only requires calling
    /// if many short-lived instances of <see cref="BigQueryClient"/> are being created.
    /// Most code would be expected to create a single <c>BigQueryClient</c> instance, and use this instance throughout
    /// the lifetime of the application. In this case, <c>Dispose</c> need not be called.
    /// </para>
    /// </remarks>
    public abstract partial class BigQueryClient : IDisposable
    {
        /// <summary>
        /// Google Drive Scope is required when Big Query Table has Google Sheet as a data source.
        /// </summary>
        private const string GoogleDriveScope = "https://www.googleapis.com/auth/drive";

        private static readonly string[] s_scopes = new[] {
                BigqueryService.Scope.Bigquery,
                BigqueryService.Scope.BigqueryInsertdata,
                BigqueryService.Scope.DevstorageFullControl,
                BigqueryService.Scope.CloudPlatform,
                GoogleDriveScope
            };

        internal static ScopedCredentialProvider ScopedCredentialProvider { get; } =
            new ScopedCredentialProvider(s_scopes);

        /// <summary>
        /// The underlying BigQuery service object used by this client.
        /// </summary>
        /// <remarks>
        /// The <see cref="BigQueryClient"/> class only provides convenience operations built on top of
        /// an existing service object. Any more complex operations which are not supported by this wrapper may wish
        /// to use the same service object as the wrapper, in order to take advantage of its configuration (for authentication,
        /// application naming etc).
        /// </remarks>
        public virtual BigqueryService Service => throw new NotImplementedException();

        /// <summary>
        /// The ID of the project this client operates on. All operations that require a
        /// project to be specified implicitly supply this ID.
        /// </summary>
        public virtual string ProjectId => throw new NotImplementedException();

        /// <summary>
        /// The default location to use for all operations where locations
        /// can be specified, such as dataset and job creation.
        /// </summary>
        public virtual string DefaultLocation => throw new NotImplementedException();

        /// <summary>
        /// Determines whether or not responses should be formatted with whitespace for readability.
        /// </summary>
        public virtual bool PrettyPrint => throw new NotImplementedException();

        /// <summary>
        /// Asynchronously creates a <see cref="BigQueryClient"/>, using application default credentials if
        /// no credentials are specified.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If the supplied credentials support scoping, the following scopes are specified, overwriting any
        /// previously-specified scopes.
        /// </para>
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/bigquery"</description></item>
        /// <item><description>https://www.googleapis.com/auth/bigquery.insertdata"</description></item>
        /// <item><description>https://www.googleapis.com/auth/devstorage.full_control"</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// </list>
        /// <para>
        /// If you require a different set of scopes, please create and scope the credential,
        /// then use <see cref="BigQueryClientBuilder"/>, specify the <see cref="ClientBuilderBase{TClient}.Credential"/>
        /// and <see cref="BigQueryClientBuilder.ProjectId"/> properties, then call <see cref="ClientBuilderBase{TClient}.Build"/>
        /// to create the client.
        /// </para>
        /// </remarks>
        /// <param name="projectId">The ID of the project containing the BigQuery data. Must not be null.</param>
        /// <param name="credential">Optional <see cref="GoogleCredential"/>.</param>
        /// <returns>The task representing the created <see cref="BigQueryClient"/>.</returns>
        public static Task<BigQueryClient> CreateAsync(string projectId, GoogleCredential credential = null) =>
            new BigQueryClientBuilder
            {
                ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId)),
                Credential = credential?.CreateScoped(s_scopes)
            }.BuildAsync();

        /// <summary>
        /// Synchronously creates a <see cref="BigQueryClient"/>, using application default credentials if
        /// no credentials are specified.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If the supplied credentials support scoping, the following scopes are specified, overwriting any
        /// previously-specified scopes.
        /// </para>
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/bigquery"</description></item>
        /// <item><description>https://www.googleapis.com/auth/bigquery.insertdata"</description></item>
        /// <item><description>https://www.googleapis.com/auth/devstorage.full_control"</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// </list>
        /// <para>
        /// If you require a different set of scopes, please create and scope the credential,
        /// then use <see cref="BigQueryClientBuilder"/>, specify the <see cref="ClientBuilderBase{TClient}.Credential"/>
        /// and <see cref="BigQueryClientBuilder.ProjectId"/> properties, then call <see cref="ClientBuilderBase{TClient}.Build"/>
        /// to create the client.
        /// </para>
        /// </remarks>
        /// <param name="projectId">The ID of the project containing the BigQuery data. Must not be null.</param>
        /// <param name="credential">Optional <see cref="GoogleCredential"/>.</param>
        /// <returns>The created <see cref="BigQueryClient"/>.</returns>
        public static BigQueryClient Create(string projectId, GoogleCredential credential = null) =>
            new BigQueryClientBuilder
            {
                ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId)),
                Credential = credential?.CreateScoped(s_scopes)
            }.Build();

        /// <summary>
        /// Creates a new client which uses the specified location by default for all operations where locations
        /// can be specified, such as dataset and job creation.
        /// </summary>
        /// <remarks>
        /// Implementations should normally ensure that the object returned is of the same type as this client,
        /// in case users need implementation-specific features of that client.
        /// </remarks>
        /// <param name="defaultLocation">The location to use by default, for job creation etc.</param>
        /// <returns>A new client with the specified default location.</returns>
        public virtual BigQueryClient WithDefaultLocation(string defaultLocation) =>
            throw new NotImplementedException();

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
        /// Creates a <see cref="ProjectReference"/> using this client's project ID.
        /// </summary>
        /// <remarks>
        /// This method mostly exists for uniformity - it makes the code generation simpler for methods
        /// using project references. While we could expose it publicly, there's little reason to do so.
        /// </remarks>
        /// <returns>A <see cref="ProjectReference"/> representing the requested project.</returns>
        internal ProjectReference GetProjectReference() => GetProjectReference(ProjectId);

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
        /// using this client's project ID and default location.
        /// </summary>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <returns>A <see cref="JobReference"/> representing the requested job.</returns>
        public JobReference GetJobReference(string jobId) =>
            GetJobReference(ProjectId, jobId);

        /// <summary>
        /// Creates a <see cref="JobReference"/> from the given project ID and job ID, using
        /// this client's default location.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <returns>A <see cref="JobReference"/> representing the requested job.</returns>
        public JobReference GetJobReference(string projectId, string jobId) =>
            GetJobReference(projectId, jobId, DefaultLocation);

        /// <summary>
        /// Creates a <see cref="JobReference"/> from the given project ID, job ID and location.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="jobId">The job ID. Must not be null.</param>
        /// <param name="location">The location. May be null.</param>
        /// <returns>A <see cref="JobReference"/> representing the requested job.</returns>
        public JobReference GetJobReference(string projectId, string jobId, string location) =>
            new JobReference
            {
                ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId)),
                JobId = GaxPreconditions.CheckNotNull(jobId, nameof(jobId)),
                Location = location
            };

        /// <summary>
        /// Creates a <see cref="ModelReference"/> from the given dataset ID and model ID,
        /// using this client's project ID.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="modelId">The model ID. Must not be null.</param>
        /// <returns>A <see cref="ModelReference"/> representing the requested model.</returns>
        public ModelReference GetModelReference(string datasetId, string modelId) =>
            GetModelReference(ProjectId, datasetId, modelId);

        /// <summary>
        /// Creates a <see cref="ModelReference"/> from the given project ID, dataset ID and model ID.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="modelId">The model ID. Must not be null.</param>
        /// <returns>A <see cref="ModelReference"/> representing the requested model.</returns>
        public ModelReference GetModelReference(string projectId, string datasetId, string modelId) =>
            new ModelReference
            {
                ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId)),
                DatasetId = GaxPreconditions.CheckNotNull(datasetId, nameof(datasetId)),
                ModelId = GaxPreconditions.CheckNotNull(modelId, nameof(modelId)),
            };

        /// <summary>
        /// Creates a <see cref="RoutineReference"/> from the given dataset ID and routine ID,
        /// using this client's project ID.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="routineId">The routine ID. Must not be null.</param>
        /// <returns>A <see cref="RoutineReference"/> representing the requested routine.</returns>
        public RoutineReference GetRoutineReference(string datasetId, string routineId) =>
            GetRoutineReference(ProjectId, datasetId, routineId);

        /// <summary>
        /// Creates a <see cref="RoutineReference"/> from the given project ID, dataset ID and routine ID.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <param name="routineId">The routine ID. Must not be null.</param>
        /// <returns>A <see cref="RoutineReference"/> representing the requested routine.</returns>
        public RoutineReference GetRoutineReference(string projectId, string datasetId, string routineId) =>
            new RoutineReference
            {
                ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId)),
                DatasetId = GaxPreconditions.CheckNotNull(datasetId, nameof(datasetId)),
                RoutineId = GaxPreconditions.CheckNotNull(routineId, nameof(routineId)),
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

        /// <summary>
        /// Validates an ETag, simulating an HTTP status code of 412 if the ETag doesn't match.
        /// </summary>
        /// <typeparam name="T">The entity type</typeparam>
        /// <param name="resource">The resource to check</param>
        /// <param name="etag">The ETag to check, or null for no check</param>
        /// <returns><paramref name="resource"/> if the ETag matches, or if <paramref name="etag"/> is null</returns>
        /// <exception cref="GoogleApiException">The ETag in the resource doesn't match <paramref name="etag"/></exception>
        internal T CheckETag<T>(T resource, string etag) where T : IDirectResponseSchema =>
            etag == null || etag == resource.ETag
            ? resource
            : throw new GoogleApiException(Service.Name, "ETag didn't match") { HttpStatusCode = HttpStatusCode.PreconditionFailed };

        static internal void RetryIfETagPresent<TResource, TResponse>(BigqueryBaseServiceRequest<TResponse> request, TResource resource)
            where TResource : IDirectResponseSchema
        {
            if (resource.ETag != null)
            {
                RetryHandler.MarkAsRetriable(request);
            }
        }

        /// <summary>
        /// Dispose of this instance. See the <see cref="BigQueryClient"/> remarks on when this should be called.
        /// </summary>
        public virtual void Dispose() { }
    }
}
