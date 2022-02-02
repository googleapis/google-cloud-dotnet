// Copyright 2022 Google LLC
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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using gagr = Google.Api.Gax.ResourceNames;
using gciv = Google.Cloud.Iam.V1;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.PubSub.V1
{
    /// <summary>Settings for <see cref="SchemaServiceClient"/> instances.</summary>
    public sealed partial class SchemaServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SchemaServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SchemaServiceSettings"/>.</returns>
        public static SchemaServiceSettings GetDefault() => new SchemaServiceSettings();

        /// <summary>Constructs a new <see cref="SchemaServiceSettings"/> object with default settings.</summary>
        public SchemaServiceSettings()
        {
        }

        private SchemaServiceSettings(SchemaServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateSchemaSettings = existing.CreateSchemaSettings;
            GetSchemaSettings = existing.GetSchemaSettings;
            ListSchemasSettings = existing.ListSchemasSettings;
            DeleteSchemaSettings = existing.DeleteSchemaSettings;
            ValidateSchemaSettings = existing.ValidateSchemaSettings;
            ValidateMessageSettings = existing.ValidateMessageSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(SchemaServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SchemaServiceClient.CreateSchema</c> and <c>SchemaServiceClient.CreateSchemaAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSchemaSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SchemaServiceClient.GetSchema</c> and <c>SchemaServiceClient.GetSchemaAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSchemaSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SchemaServiceClient.ListSchemas</c> and <c>SchemaServiceClient.ListSchemasAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSchemasSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SchemaServiceClient.DeleteSchema</c> and <c>SchemaServiceClient.DeleteSchemaAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSchemaSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SchemaServiceClient.ValidateSchema</c> and <c>SchemaServiceClient.ValidateSchemaAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ValidateSchemaSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SchemaServiceClient.ValidateMessage</c> and <c>SchemaServiceClient.ValidateMessageAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ValidateMessageSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SchemaServiceSettings"/> object.</returns>
        public SchemaServiceSettings Clone() => new SchemaServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SchemaServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class SchemaServiceClientBuilder : gaxgrpc::ClientBuilderBase<SchemaServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SchemaServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SchemaServiceClientBuilder()
        {
            UseJwtAccessWithScopes = SchemaServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref SchemaServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SchemaServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SchemaServiceClient Build()
        {
            SchemaServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SchemaServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SchemaServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SchemaServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SchemaServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<SchemaServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SchemaServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => SchemaServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => SchemaServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SchemaServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>SchemaService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for doing schema-related operations.
    /// </remarks>
    public abstract partial class SchemaServiceClient
    {
        /// <summary>
        /// The default endpoint for the SchemaService service, which is a host of "pubsub.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "pubsub.googleapis.com:443";

        /// <summary>The default SchemaService scopes.</summary>
        /// <remarks>
        /// The default SchemaService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/pubsub</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/pubsub",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes, UseJwtAccessWithScopes);

        internal static bool UseJwtAccessWithScopes
        {
            get
            {
                bool useJwtAccessWithScopes = true;
                MaybeUseJwtAccessWithScopes(ref useJwtAccessWithScopes);
                return useJwtAccessWithScopes;
            }
        }

        static partial void MaybeUseJwtAccessWithScopes(ref bool useJwtAccessWithScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="SchemaServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SchemaServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SchemaServiceClient"/>.</returns>
        public static stt::Task<SchemaServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SchemaServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SchemaServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SchemaServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SchemaServiceClient"/>.</returns>
        public static SchemaServiceClient Create() => new SchemaServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SchemaServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SchemaServiceSettings"/>.</param>
        /// <returns>The created <see cref="SchemaServiceClient"/>.</returns>
        internal static SchemaServiceClient Create(grpccore::CallInvoker callInvoker, SchemaServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SchemaService.SchemaServiceClient grpcClient = new SchemaService.SchemaServiceClient(callInvoker);
            return new SchemaServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/>. Channels which weren't automatically created are not
        /// affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/> will create new channels, which could in turn be shut down
        /// by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC SchemaService client</summary>
        public virtual SchemaService.SchemaServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a schema.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Schema CreateSchema(CreateSchemaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a schema.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schema> CreateSchemaAsync(CreateSchemaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a schema.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schema> CreateSchemaAsync(CreateSchemaRequest request, st::CancellationToken cancellationToken) =>
            CreateSchemaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a schema.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which to create the schema.
        /// Format is `projects/{project-id}`.
        /// </param>
        /// <param name="schema">
        /// Required. The schema object to create.
        /// 
        /// This schema's `name` parameter is ignored. The schema object returned
        /// by CreateSchema will have a `name` made using the given `parent` and
        /// `schema_id`.
        /// </param>
        /// <param name="schemaId">
        /// The ID to use for the schema, which will become the final component of
        /// the schema's resource name.
        /// 
        /// See https://cloud.google.com/pubsub/docs/admin#resource_names for resource
        /// name constraints.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Schema CreateSchema(string parent, Schema schema, string schemaId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSchema(new CreateSchemaRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Schema = gax::GaxPreconditions.CheckNotNull(schema, nameof(schema)),
                SchemaId = schemaId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a schema.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which to create the schema.
        /// Format is `projects/{project-id}`.
        /// </param>
        /// <param name="schema">
        /// Required. The schema object to create.
        /// 
        /// This schema's `name` parameter is ignored. The schema object returned
        /// by CreateSchema will have a `name` made using the given `parent` and
        /// `schema_id`.
        /// </param>
        /// <param name="schemaId">
        /// The ID to use for the schema, which will become the final component of
        /// the schema's resource name.
        /// 
        /// See https://cloud.google.com/pubsub/docs/admin#resource_names for resource
        /// name constraints.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schema> CreateSchemaAsync(string parent, Schema schema, string schemaId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSchemaAsync(new CreateSchemaRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Schema = gax::GaxPreconditions.CheckNotNull(schema, nameof(schema)),
                SchemaId = schemaId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a schema.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which to create the schema.
        /// Format is `projects/{project-id}`.
        /// </param>
        /// <param name="schema">
        /// Required. The schema object to create.
        /// 
        /// This schema's `name` parameter is ignored. The schema object returned
        /// by CreateSchema will have a `name` made using the given `parent` and
        /// `schema_id`.
        /// </param>
        /// <param name="schemaId">
        /// The ID to use for the schema, which will become the final component of
        /// the schema's resource name.
        /// 
        /// See https://cloud.google.com/pubsub/docs/admin#resource_names for resource
        /// name constraints.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schema> CreateSchemaAsync(string parent, Schema schema, string schemaId, st::CancellationToken cancellationToken) =>
            CreateSchemaAsync(parent, schema, schemaId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a schema.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which to create the schema.
        /// Format is `projects/{project-id}`.
        /// </param>
        /// <param name="schema">
        /// Required. The schema object to create.
        /// 
        /// This schema's `name` parameter is ignored. The schema object returned
        /// by CreateSchema will have a `name` made using the given `parent` and
        /// `schema_id`.
        /// </param>
        /// <param name="schemaId">
        /// The ID to use for the schema, which will become the final component of
        /// the schema's resource name.
        /// 
        /// See https://cloud.google.com/pubsub/docs/admin#resource_names for resource
        /// name constraints.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Schema CreateSchema(gagr::ProjectName parent, Schema schema, string schemaId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSchema(new CreateSchemaRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Schema = gax::GaxPreconditions.CheckNotNull(schema, nameof(schema)),
                SchemaId = schemaId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a schema.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which to create the schema.
        /// Format is `projects/{project-id}`.
        /// </param>
        /// <param name="schema">
        /// Required. The schema object to create.
        /// 
        /// This schema's `name` parameter is ignored. The schema object returned
        /// by CreateSchema will have a `name` made using the given `parent` and
        /// `schema_id`.
        /// </param>
        /// <param name="schemaId">
        /// The ID to use for the schema, which will become the final component of
        /// the schema's resource name.
        /// 
        /// See https://cloud.google.com/pubsub/docs/admin#resource_names for resource
        /// name constraints.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schema> CreateSchemaAsync(gagr::ProjectName parent, Schema schema, string schemaId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSchemaAsync(new CreateSchemaRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Schema = gax::GaxPreconditions.CheckNotNull(schema, nameof(schema)),
                SchemaId = schemaId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a schema.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which to create the schema.
        /// Format is `projects/{project-id}`.
        /// </param>
        /// <param name="schema">
        /// Required. The schema object to create.
        /// 
        /// This schema's `name` parameter is ignored. The schema object returned
        /// by CreateSchema will have a `name` made using the given `parent` and
        /// `schema_id`.
        /// </param>
        /// <param name="schemaId">
        /// The ID to use for the schema, which will become the final component of
        /// the schema's resource name.
        /// 
        /// See https://cloud.google.com/pubsub/docs/admin#resource_names for resource
        /// name constraints.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schema> CreateSchemaAsync(gagr::ProjectName parent, Schema schema, string schemaId, st::CancellationToken cancellationToken) =>
            CreateSchemaAsync(parent, schema, schemaId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a schema.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Schema GetSchema(GetSchemaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a schema.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schema> GetSchemaAsync(GetSchemaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a schema.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schema> GetSchemaAsync(GetSchemaRequest request, st::CancellationToken cancellationToken) =>
            GetSchemaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a schema.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the schema to get.
        /// Format is `projects/{project}/schemas/{schema}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Schema GetSchema(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSchema(new GetSchemaRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a schema.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the schema to get.
        /// Format is `projects/{project}/schemas/{schema}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schema> GetSchemaAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSchemaAsync(new GetSchemaRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a schema.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the schema to get.
        /// Format is `projects/{project}/schemas/{schema}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schema> GetSchemaAsync(string name, st::CancellationToken cancellationToken) =>
            GetSchemaAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a schema.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the schema to get.
        /// Format is `projects/{project}/schemas/{schema}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Schema GetSchema(SchemaName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSchema(new GetSchemaRequest
            {
                SchemaName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a schema.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the schema to get.
        /// Format is `projects/{project}/schemas/{schema}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schema> GetSchemaAsync(SchemaName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSchemaAsync(new GetSchemaRequest
            {
                SchemaName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a schema.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the schema to get.
        /// Format is `projects/{project}/schemas/{schema}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schema> GetSchemaAsync(SchemaName name, st::CancellationToken cancellationToken) =>
            GetSchemaAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists schemas in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Schema"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSchemasResponse, Schema> ListSchemas(ListSchemasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists schemas in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Schema"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSchemasResponse, Schema> ListSchemasAsync(ListSchemasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists schemas in a project.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which to list schemas.
        /// Format is `projects/{project-id}`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Schema"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSchemasResponse, Schema> ListSchemas(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSchemas(new ListSchemasRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists schemas in a project.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which to list schemas.
        /// Format is `projects/{project-id}`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Schema"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSchemasResponse, Schema> ListSchemasAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSchemasAsync(new ListSchemasRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists schemas in a project.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which to list schemas.
        /// Format is `projects/{project-id}`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Schema"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSchemasResponse, Schema> ListSchemas(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSchemas(new ListSchemasRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists schemas in a project.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which to list schemas.
        /// Format is `projects/{project-id}`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Schema"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSchemasResponse, Schema> ListSchemasAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSchemasAsync(new ListSchemasRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Deletes a schema.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSchema(DeleteSchemaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a schema.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSchemaAsync(DeleteSchemaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a schema.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSchemaAsync(DeleteSchemaRequest request, st::CancellationToken cancellationToken) =>
            DeleteSchemaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a schema.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the schema to delete.
        /// Format is `projects/{project}/schemas/{schema}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSchema(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSchema(new DeleteSchemaRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a schema.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the schema to delete.
        /// Format is `projects/{project}/schemas/{schema}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSchemaAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSchemaAsync(new DeleteSchemaRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a schema.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the schema to delete.
        /// Format is `projects/{project}/schemas/{schema}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSchemaAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSchemaAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a schema.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the schema to delete.
        /// Format is `projects/{project}/schemas/{schema}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSchema(SchemaName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSchema(new DeleteSchemaRequest
            {
                SchemaName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a schema.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the schema to delete.
        /// Format is `projects/{project}/schemas/{schema}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSchemaAsync(SchemaName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSchemaAsync(new DeleteSchemaRequest
            {
                SchemaName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a schema.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the schema to delete.
        /// Format is `projects/{project}/schemas/{schema}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSchemaAsync(SchemaName name, st::CancellationToken cancellationToken) =>
            DeleteSchemaAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Validates a schema.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ValidateSchemaResponse ValidateSchema(ValidateSchemaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Validates a schema.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ValidateSchemaResponse> ValidateSchemaAsync(ValidateSchemaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Validates a schema.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ValidateSchemaResponse> ValidateSchemaAsync(ValidateSchemaRequest request, st::CancellationToken cancellationToken) =>
            ValidateSchemaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Validates a schema.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which to validate schemas.
        /// Format is `projects/{project-id}`.
        /// </param>
        /// <param name="schema">
        /// Required. The schema object to validate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ValidateSchemaResponse ValidateSchema(string parent, Schema schema, gaxgrpc::CallSettings callSettings = null) =>
            ValidateSchema(new ValidateSchemaRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Schema = gax::GaxPreconditions.CheckNotNull(schema, nameof(schema)),
            }, callSettings);

        /// <summary>
        /// Validates a schema.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which to validate schemas.
        /// Format is `projects/{project-id}`.
        /// </param>
        /// <param name="schema">
        /// Required. The schema object to validate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ValidateSchemaResponse> ValidateSchemaAsync(string parent, Schema schema, gaxgrpc::CallSettings callSettings = null) =>
            ValidateSchemaAsync(new ValidateSchemaRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Schema = gax::GaxPreconditions.CheckNotNull(schema, nameof(schema)),
            }, callSettings);

        /// <summary>
        /// Validates a schema.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which to validate schemas.
        /// Format is `projects/{project-id}`.
        /// </param>
        /// <param name="schema">
        /// Required. The schema object to validate.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ValidateSchemaResponse> ValidateSchemaAsync(string parent, Schema schema, st::CancellationToken cancellationToken) =>
            ValidateSchemaAsync(parent, schema, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Validates a schema.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which to validate schemas.
        /// Format is `projects/{project-id}`.
        /// </param>
        /// <param name="schema">
        /// Required. The schema object to validate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ValidateSchemaResponse ValidateSchema(gagr::ProjectName parent, Schema schema, gaxgrpc::CallSettings callSettings = null) =>
            ValidateSchema(new ValidateSchemaRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Schema = gax::GaxPreconditions.CheckNotNull(schema, nameof(schema)),
            }, callSettings);

        /// <summary>
        /// Validates a schema.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which to validate schemas.
        /// Format is `projects/{project-id}`.
        /// </param>
        /// <param name="schema">
        /// Required. The schema object to validate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ValidateSchemaResponse> ValidateSchemaAsync(gagr::ProjectName parent, Schema schema, gaxgrpc::CallSettings callSettings = null) =>
            ValidateSchemaAsync(new ValidateSchemaRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Schema = gax::GaxPreconditions.CheckNotNull(schema, nameof(schema)),
            }, callSettings);

        /// <summary>
        /// Validates a schema.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which to validate schemas.
        /// Format is `projects/{project-id}`.
        /// </param>
        /// <param name="schema">
        /// Required. The schema object to validate.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ValidateSchemaResponse> ValidateSchemaAsync(gagr::ProjectName parent, Schema schema, st::CancellationToken cancellationToken) =>
            ValidateSchemaAsync(parent, schema, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Validates a message against a schema.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ValidateMessageResponse ValidateMessage(ValidateMessageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Validates a message against a schema.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ValidateMessageResponse> ValidateMessageAsync(ValidateMessageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Validates a message against a schema.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ValidateMessageResponse> ValidateMessageAsync(ValidateMessageRequest request, st::CancellationToken cancellationToken) =>
            ValidateMessageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SchemaService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for doing schema-related operations.
    /// </remarks>
    public sealed partial class SchemaServiceClientImpl : SchemaServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateSchemaRequest, Schema> _callCreateSchema;

        private readonly gaxgrpc::ApiCall<GetSchemaRequest, Schema> _callGetSchema;

        private readonly gaxgrpc::ApiCall<ListSchemasRequest, ListSchemasResponse> _callListSchemas;

        private readonly gaxgrpc::ApiCall<DeleteSchemaRequest, wkt::Empty> _callDeleteSchema;

        private readonly gaxgrpc::ApiCall<ValidateSchemaRequest, ValidateSchemaResponse> _callValidateSchema;

        private readonly gaxgrpc::ApiCall<ValidateMessageRequest, ValidateMessageResponse> _callValidateMessage;

        /// <summary>
        /// Constructs a client wrapper for the SchemaService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SchemaServiceSettings"/> used within this client.</param>
        public SchemaServiceClientImpl(SchemaService.SchemaServiceClient grpcClient, SchemaServiceSettings settings)
        {
            GrpcClient = grpcClient;
            SchemaServiceSettings effectiveSettings = settings ?? SchemaServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings);
            _callCreateSchema = clientHelper.BuildApiCall<CreateSchemaRequest, Schema>(grpcClient.CreateSchemaAsync, grpcClient.CreateSchema, effectiveSettings.CreateSchemaSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSchema);
            Modify_CreateSchemaApiCall(ref _callCreateSchema);
            _callGetSchema = clientHelper.BuildApiCall<GetSchemaRequest, Schema>(grpcClient.GetSchemaAsync, grpcClient.GetSchema, effectiveSettings.GetSchemaSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSchema);
            Modify_GetSchemaApiCall(ref _callGetSchema);
            _callListSchemas = clientHelper.BuildApiCall<ListSchemasRequest, ListSchemasResponse>(grpcClient.ListSchemasAsync, grpcClient.ListSchemas, effectiveSettings.ListSchemasSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSchemas);
            Modify_ListSchemasApiCall(ref _callListSchemas);
            _callDeleteSchema = clientHelper.BuildApiCall<DeleteSchemaRequest, wkt::Empty>(grpcClient.DeleteSchemaAsync, grpcClient.DeleteSchema, effectiveSettings.DeleteSchemaSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSchema);
            Modify_DeleteSchemaApiCall(ref _callDeleteSchema);
            _callValidateSchema = clientHelper.BuildApiCall<ValidateSchemaRequest, ValidateSchemaResponse>(grpcClient.ValidateSchemaAsync, grpcClient.ValidateSchema, effectiveSettings.ValidateSchemaSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callValidateSchema);
            Modify_ValidateSchemaApiCall(ref _callValidateSchema);
            _callValidateMessage = clientHelper.BuildApiCall<ValidateMessageRequest, ValidateMessageResponse>(grpcClient.ValidateMessageAsync, grpcClient.ValidateMessage, effectiveSettings.ValidateMessageSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callValidateMessage);
            Modify_ValidateMessageApiCall(ref _callValidateMessage);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateSchemaApiCall(ref gaxgrpc::ApiCall<CreateSchemaRequest, Schema> call);

        partial void Modify_GetSchemaApiCall(ref gaxgrpc::ApiCall<GetSchemaRequest, Schema> call);

        partial void Modify_ListSchemasApiCall(ref gaxgrpc::ApiCall<ListSchemasRequest, ListSchemasResponse> call);

        partial void Modify_DeleteSchemaApiCall(ref gaxgrpc::ApiCall<DeleteSchemaRequest, wkt::Empty> call);

        partial void Modify_ValidateSchemaApiCall(ref gaxgrpc::ApiCall<ValidateSchemaRequest, ValidateSchemaResponse> call);

        partial void Modify_ValidateMessageApiCall(ref gaxgrpc::ApiCall<ValidateMessageRequest, ValidateMessageResponse> call);

        partial void OnConstruction(SchemaService.SchemaServiceClient grpcClient, SchemaServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SchemaService client</summary>
        public override SchemaService.SchemaServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateSchemaRequest(ref CreateSchemaRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSchemaRequest(ref GetSchemaRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSchemasRequest(ref ListSchemasRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSchemaRequest(ref DeleteSchemaRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ValidateSchemaRequest(ref ValidateSchemaRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ValidateMessageRequest(ref ValidateMessageRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a schema.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Schema CreateSchema(CreateSchemaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSchemaRequest(ref request, ref callSettings);
            return _callCreateSchema.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a schema.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Schema> CreateSchemaAsync(CreateSchemaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSchemaRequest(ref request, ref callSettings);
            return _callCreateSchema.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a schema.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Schema GetSchema(GetSchemaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSchemaRequest(ref request, ref callSettings);
            return _callGetSchema.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a schema.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Schema> GetSchemaAsync(GetSchemaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSchemaRequest(ref request, ref callSettings);
            return _callGetSchema.Async(request, callSettings);
        }

        /// <summary>
        /// Lists schemas in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Schema"/> resources.</returns>
        public override gax::PagedEnumerable<ListSchemasResponse, Schema> ListSchemas(ListSchemasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSchemasRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSchemasRequest, ListSchemasResponse, Schema>(_callListSchemas, request, callSettings);
        }

        /// <summary>
        /// Lists schemas in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Schema"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSchemasResponse, Schema> ListSchemasAsync(ListSchemasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSchemasRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSchemasRequest, ListSchemasResponse, Schema>(_callListSchemas, request, callSettings);
        }

        /// <summary>
        /// Deletes a schema.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteSchema(DeleteSchemaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSchemaRequest(ref request, ref callSettings);
            _callDeleteSchema.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a schema.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteSchemaAsync(DeleteSchemaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSchemaRequest(ref request, ref callSettings);
            return _callDeleteSchema.Async(request, callSettings);
        }

        /// <summary>
        /// Validates a schema.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ValidateSchemaResponse ValidateSchema(ValidateSchemaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ValidateSchemaRequest(ref request, ref callSettings);
            return _callValidateSchema.Sync(request, callSettings);
        }

        /// <summary>
        /// Validates a schema.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ValidateSchemaResponse> ValidateSchemaAsync(ValidateSchemaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ValidateSchemaRequest(ref request, ref callSettings);
            return _callValidateSchema.Async(request, callSettings);
        }

        /// <summary>
        /// Validates a message against a schema.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ValidateMessageResponse ValidateMessage(ValidateMessageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ValidateMessageRequest(ref request, ref callSettings);
            return _callValidateMessage.Sync(request, callSettings);
        }

        /// <summary>
        /// Validates a message against a schema.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ValidateMessageResponse> ValidateMessageAsync(ValidateMessageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ValidateMessageRequest(ref request, ref callSettings);
            return _callValidateMessage.Async(request, callSettings);
        }
    }

    public partial class ListSchemasRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSchemasResponse : gaxgrpc::IPageResponse<Schema>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Schema> GetEnumerator() => Schemas.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class SchemaService
    {
        public partial class SchemaServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="gciv::IAMPolicy.IAMPolicyClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gciv::IAMPolicy.IAMPolicyClient"/> for the same target as this client.
            /// </returns>
            public virtual gciv::IAMPolicy.IAMPolicyClient CreateIAMPolicyClient() =>
                new gciv::IAMPolicy.IAMPolicyClient(CallInvoker);
        }
    }
}
