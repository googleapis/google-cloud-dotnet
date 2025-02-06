// Copyright 2025 Google LLC
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

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gcl = Google.Cloud.Location;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.DiscoveryEngine.V1
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
            GetSchemaSettings = existing.GetSchemaSettings;
            ListSchemasSettings = existing.ListSchemasSettings;
            CreateSchemaSettings = existing.CreateSchemaSettings;
            CreateSchemaOperationsSettings = existing.CreateSchemaOperationsSettings.Clone();
            UpdateSchemaSettings = existing.UpdateSchemaSettings;
            UpdateSchemaOperationsSettings = existing.UpdateSchemaOperationsSettings.Clone();
            DeleteSchemaSettings = existing.DeleteSchemaSettings;
            DeleteSchemaOperationsSettings = existing.DeleteSchemaOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SchemaServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SchemaServiceClient.GetSchema</c> and <c>SchemaServiceClient.GetSchemaAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSchemaSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SchemaServiceClient.ListSchemas</c> and <c>SchemaServiceClient.ListSchemasAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSchemasSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SchemaServiceClient.CreateSchema</c> and <c>SchemaServiceClient.CreateSchemaAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSchemaSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>SchemaServiceClient.CreateSchema</c> and
        /// <c>SchemaServiceClient.CreateSchemaAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateSchemaOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SchemaServiceClient.UpdateSchema</c> and <c>SchemaServiceClient.UpdateSchemaAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSchemaSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>SchemaServiceClient.UpdateSchema</c> and
        /// <c>SchemaServiceClient.UpdateSchemaAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings UpdateSchemaOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SchemaServiceClient.DeleteSchema</c> and <c>SchemaServiceClient.DeleteSchemaAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSchemaSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>SchemaServiceClient.DeleteSchema</c> and
        /// <c>SchemaServiceClient.DeleteSchemaAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteSchemaOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

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
        public SchemaServiceClientBuilder() : base(SchemaServiceClient.ServiceMetadata)
        {
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
            return SchemaServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SchemaServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SchemaServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SchemaServiceClient.ChannelPool;
    }

    /// <summary>SchemaService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Schema][google.cloud.discoveryengine.v1.Schema]s.
    /// </remarks>
    public abstract partial class SchemaServiceClient
    {
        /// <summary>
        /// The default endpoint for the SchemaService service, which is a host of "discoveryengine.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "discoveryengine.googleapis.com:443";

        /// <summary>The default SchemaService scopes.</summary>
        /// <remarks>
        /// The default SchemaService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SchemaService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

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
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SchemaServiceClient"/>.</returns>
        internal static SchemaServiceClient Create(grpccore::CallInvoker callInvoker, SchemaServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SchemaService.SchemaServiceClient grpcClient = new SchemaService.SchemaServiceClient(callInvoker);
            return new SchemaServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a [Schema][google.cloud.discoveryengine.v1.Schema].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Schema GetSchema(GetSchemaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a [Schema][google.cloud.discoveryengine.v1.Schema].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schema> GetSchemaAsync(GetSchemaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a [Schema][google.cloud.discoveryengine.v1.Schema].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schema> GetSchemaAsync(GetSchemaRequest request, st::CancellationToken cancellationToken) =>
            GetSchemaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a [Schema][google.cloud.discoveryengine.v1.Schema].
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the schema, in the format of
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/schemas/{schema}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Schema GetSchema(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSchema(new GetSchemaRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [Schema][google.cloud.discoveryengine.v1.Schema].
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the schema, in the format of
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/schemas/{schema}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schema> GetSchemaAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSchemaAsync(new GetSchemaRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [Schema][google.cloud.discoveryengine.v1.Schema].
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the schema, in the format of
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/schemas/{schema}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schema> GetSchemaAsync(string name, st::CancellationToken cancellationToken) =>
            GetSchemaAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a [Schema][google.cloud.discoveryengine.v1.Schema].
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the schema, in the format of
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/schemas/{schema}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Schema GetSchema(SchemaName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSchema(new GetSchemaRequest
            {
                SchemaName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [Schema][google.cloud.discoveryengine.v1.Schema].
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the schema, in the format of
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/schemas/{schema}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schema> GetSchemaAsync(SchemaName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSchemaAsync(new GetSchemaRequest
            {
                SchemaName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a [Schema][google.cloud.discoveryengine.v1.Schema].
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the schema, in the format of
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/schemas/{schema}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schema> GetSchemaAsync(SchemaName name, st::CancellationToken cancellationToken) =>
            GetSchemaAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a list of [Schema][google.cloud.discoveryengine.v1.Schema]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Schema"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSchemasResponse, Schema> ListSchemas(ListSchemasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a list of [Schema][google.cloud.discoveryengine.v1.Schema]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Schema"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSchemasResponse, Schema> ListSchemasAsync(ListSchemasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a list of [Schema][google.cloud.discoveryengine.v1.Schema]s.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent data store resource name, in the format of
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}`.
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
        public virtual gax::PagedEnumerable<ListSchemasResponse, Schema> ListSchemas(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSchemasRequest request = new ListSchemasRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSchemas(request, callSettings);
        }

        /// <summary>
        /// Gets a list of [Schema][google.cloud.discoveryengine.v1.Schema]s.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent data store resource name, in the format of
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}`.
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
        public virtual gax::PagedAsyncEnumerable<ListSchemasResponse, Schema> ListSchemasAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSchemasRequest request = new ListSchemasRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSchemasAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a list of [Schema][google.cloud.discoveryengine.v1.Schema]s.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent data store resource name, in the format of
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}`.
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
        public virtual gax::PagedEnumerable<ListSchemasResponse, Schema> ListSchemas(DataStoreName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSchemasRequest request = new ListSchemasRequest
            {
                ParentAsDataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSchemas(request, callSettings);
        }

        /// <summary>
        /// Gets a list of [Schema][google.cloud.discoveryengine.v1.Schema]s.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent data store resource name, in the format of
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}`.
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
        public virtual gax::PagedAsyncEnumerable<ListSchemasResponse, Schema> ListSchemasAsync(DataStoreName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSchemasRequest request = new ListSchemasRequest
            {
                ParentAsDataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSchemasAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a [Schema][google.cloud.discoveryengine.v1.Schema].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Schema, CreateSchemaMetadata> CreateSchema(CreateSchemaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [Schema][google.cloud.discoveryengine.v1.Schema].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Schema, CreateSchemaMetadata>> CreateSchemaAsync(CreateSchemaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [Schema][google.cloud.discoveryengine.v1.Schema].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Schema, CreateSchemaMetadata>> CreateSchemaAsync(CreateSchemaRequest request, st::CancellationToken cancellationToken) =>
            CreateSchemaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateSchema</c>.</summary>
        public virtual lro::OperationsClient CreateSchemaOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateSchema</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Schema, CreateSchemaMetadata> PollOnceCreateSchema(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Schema, CreateSchemaMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSchemaOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateSchema</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Schema, CreateSchemaMetadata>> PollOnceCreateSchemaAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Schema, CreateSchemaMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSchemaOperationsClient, callSettings);

        /// <summary>
        /// Creates a [Schema][google.cloud.discoveryengine.v1.Schema].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent data store resource name, in the format of
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}`.
        /// </param>
        /// <param name="schema">
        /// Required. The [Schema][google.cloud.discoveryengine.v1.Schema] to create.
        /// </param>
        /// <param name="schemaId">
        /// Required. The ID to use for the
        /// [Schema][google.cloud.discoveryengine.v1.Schema], which becomes the final
        /// component of the
        /// [Schema.name][google.cloud.discoveryengine.v1.Schema.name].
        /// 
        /// This field should conform to
        /// [RFC-1034](https://tools.ietf.org/html/rfc1034) standard with a length
        /// limit of 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Schema, CreateSchemaMetadata> CreateSchema(string parent, Schema schema, string schemaId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSchema(new CreateSchemaRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Schema = gax::GaxPreconditions.CheckNotNull(schema, nameof(schema)),
                SchemaId = gax::GaxPreconditions.CheckNotNullOrEmpty(schemaId, nameof(schemaId)),
            }, callSettings);

        /// <summary>
        /// Creates a [Schema][google.cloud.discoveryengine.v1.Schema].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent data store resource name, in the format of
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}`.
        /// </param>
        /// <param name="schema">
        /// Required. The [Schema][google.cloud.discoveryengine.v1.Schema] to create.
        /// </param>
        /// <param name="schemaId">
        /// Required. The ID to use for the
        /// [Schema][google.cloud.discoveryengine.v1.Schema], which becomes the final
        /// component of the
        /// [Schema.name][google.cloud.discoveryengine.v1.Schema.name].
        /// 
        /// This field should conform to
        /// [RFC-1034](https://tools.ietf.org/html/rfc1034) standard with a length
        /// limit of 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Schema, CreateSchemaMetadata>> CreateSchemaAsync(string parent, Schema schema, string schemaId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSchemaAsync(new CreateSchemaRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Schema = gax::GaxPreconditions.CheckNotNull(schema, nameof(schema)),
                SchemaId = gax::GaxPreconditions.CheckNotNullOrEmpty(schemaId, nameof(schemaId)),
            }, callSettings);

        /// <summary>
        /// Creates a [Schema][google.cloud.discoveryengine.v1.Schema].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent data store resource name, in the format of
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}`.
        /// </param>
        /// <param name="schema">
        /// Required. The [Schema][google.cloud.discoveryengine.v1.Schema] to create.
        /// </param>
        /// <param name="schemaId">
        /// Required. The ID to use for the
        /// [Schema][google.cloud.discoveryengine.v1.Schema], which becomes the final
        /// component of the
        /// [Schema.name][google.cloud.discoveryengine.v1.Schema.name].
        /// 
        /// This field should conform to
        /// [RFC-1034](https://tools.ietf.org/html/rfc1034) standard with a length
        /// limit of 63 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Schema, CreateSchemaMetadata>> CreateSchemaAsync(string parent, Schema schema, string schemaId, st::CancellationToken cancellationToken) =>
            CreateSchemaAsync(parent, schema, schemaId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a [Schema][google.cloud.discoveryengine.v1.Schema].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent data store resource name, in the format of
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}`.
        /// </param>
        /// <param name="schema">
        /// Required. The [Schema][google.cloud.discoveryengine.v1.Schema] to create.
        /// </param>
        /// <param name="schemaId">
        /// Required. The ID to use for the
        /// [Schema][google.cloud.discoveryengine.v1.Schema], which becomes the final
        /// component of the
        /// [Schema.name][google.cloud.discoveryengine.v1.Schema.name].
        /// 
        /// This field should conform to
        /// [RFC-1034](https://tools.ietf.org/html/rfc1034) standard with a length
        /// limit of 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Schema, CreateSchemaMetadata> CreateSchema(DataStoreName parent, Schema schema, string schemaId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSchema(new CreateSchemaRequest
            {
                ParentAsDataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Schema = gax::GaxPreconditions.CheckNotNull(schema, nameof(schema)),
                SchemaId = gax::GaxPreconditions.CheckNotNullOrEmpty(schemaId, nameof(schemaId)),
            }, callSettings);

        /// <summary>
        /// Creates a [Schema][google.cloud.discoveryengine.v1.Schema].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent data store resource name, in the format of
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}`.
        /// </param>
        /// <param name="schema">
        /// Required. The [Schema][google.cloud.discoveryengine.v1.Schema] to create.
        /// </param>
        /// <param name="schemaId">
        /// Required. The ID to use for the
        /// [Schema][google.cloud.discoveryengine.v1.Schema], which becomes the final
        /// component of the
        /// [Schema.name][google.cloud.discoveryengine.v1.Schema.name].
        /// 
        /// This field should conform to
        /// [RFC-1034](https://tools.ietf.org/html/rfc1034) standard with a length
        /// limit of 63 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Schema, CreateSchemaMetadata>> CreateSchemaAsync(DataStoreName parent, Schema schema, string schemaId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSchemaAsync(new CreateSchemaRequest
            {
                ParentAsDataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Schema = gax::GaxPreconditions.CheckNotNull(schema, nameof(schema)),
                SchemaId = gax::GaxPreconditions.CheckNotNullOrEmpty(schemaId, nameof(schemaId)),
            }, callSettings);

        /// <summary>
        /// Creates a [Schema][google.cloud.discoveryengine.v1.Schema].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent data store resource name, in the format of
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}`.
        /// </param>
        /// <param name="schema">
        /// Required. The [Schema][google.cloud.discoveryengine.v1.Schema] to create.
        /// </param>
        /// <param name="schemaId">
        /// Required. The ID to use for the
        /// [Schema][google.cloud.discoveryengine.v1.Schema], which becomes the final
        /// component of the
        /// [Schema.name][google.cloud.discoveryengine.v1.Schema.name].
        /// 
        /// This field should conform to
        /// [RFC-1034](https://tools.ietf.org/html/rfc1034) standard with a length
        /// limit of 63 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Schema, CreateSchemaMetadata>> CreateSchemaAsync(DataStoreName parent, Schema schema, string schemaId, st::CancellationToken cancellationToken) =>
            CreateSchemaAsync(parent, schema, schemaId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a [Schema][google.cloud.discoveryengine.v1.Schema].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Schema, UpdateSchemaMetadata> UpdateSchema(UpdateSchemaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a [Schema][google.cloud.discoveryengine.v1.Schema].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Schema, UpdateSchemaMetadata>> UpdateSchemaAsync(UpdateSchemaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a [Schema][google.cloud.discoveryengine.v1.Schema].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Schema, UpdateSchemaMetadata>> UpdateSchemaAsync(UpdateSchemaRequest request, st::CancellationToken cancellationToken) =>
            UpdateSchemaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateSchema</c>.</summary>
        public virtual lro::OperationsClient UpdateSchemaOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateSchema</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Schema, UpdateSchemaMetadata> PollOnceUpdateSchema(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Schema, UpdateSchemaMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateSchemaOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateSchema</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Schema, UpdateSchemaMetadata>> PollOnceUpdateSchemaAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Schema, UpdateSchemaMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateSchemaOperationsClient, callSettings);

        /// <summary>
        /// Deletes a [Schema][google.cloud.discoveryengine.v1.Schema].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteSchemaMetadata> DeleteSchema(DeleteSchemaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a [Schema][google.cloud.discoveryengine.v1.Schema].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteSchemaMetadata>> DeleteSchemaAsync(DeleteSchemaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a [Schema][google.cloud.discoveryengine.v1.Schema].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteSchemaMetadata>> DeleteSchemaAsync(DeleteSchemaRequest request, st::CancellationToken cancellationToken) =>
            DeleteSchemaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteSchema</c>.</summary>
        public virtual lro::OperationsClient DeleteSchemaOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteSchema</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteSchemaMetadata> PollOnceDeleteSchema(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteSchemaMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSchemaOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteSchema</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteSchemaMetadata>> PollOnceDeleteSchemaAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteSchemaMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSchemaOperationsClient, callSettings);

        /// <summary>
        /// Deletes a [Schema][google.cloud.discoveryengine.v1.Schema].
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the schema, in the format of
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/schemas/{schema}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteSchemaMetadata> DeleteSchema(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSchema(new DeleteSchemaRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [Schema][google.cloud.discoveryengine.v1.Schema].
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the schema, in the format of
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/schemas/{schema}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteSchemaMetadata>> DeleteSchemaAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSchemaAsync(new DeleteSchemaRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [Schema][google.cloud.discoveryengine.v1.Schema].
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the schema, in the format of
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/schemas/{schema}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteSchemaMetadata>> DeleteSchemaAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSchemaAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a [Schema][google.cloud.discoveryengine.v1.Schema].
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the schema, in the format of
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/schemas/{schema}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteSchemaMetadata> DeleteSchema(SchemaName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSchema(new DeleteSchemaRequest
            {
                SchemaName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [Schema][google.cloud.discoveryengine.v1.Schema].
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the schema, in the format of
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/schemas/{schema}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteSchemaMetadata>> DeleteSchemaAsync(SchemaName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSchemaAsync(new DeleteSchemaRequest
            {
                SchemaName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [Schema][google.cloud.discoveryengine.v1.Schema].
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the schema, in the format of
        /// `projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/schemas/{schema}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteSchemaMetadata>> DeleteSchemaAsync(SchemaName name, st::CancellationToken cancellationToken) =>
            DeleteSchemaAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SchemaService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Schema][google.cloud.discoveryengine.v1.Schema]s.
    /// </remarks>
    public sealed partial class SchemaServiceClientImpl : SchemaServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetSchemaRequest, Schema> _callGetSchema;

        private readonly gaxgrpc::ApiCall<ListSchemasRequest, ListSchemasResponse> _callListSchemas;

        private readonly gaxgrpc::ApiCall<CreateSchemaRequest, lro::Operation> _callCreateSchema;

        private readonly gaxgrpc::ApiCall<UpdateSchemaRequest, lro::Operation> _callUpdateSchema;

        private readonly gaxgrpc::ApiCall<DeleteSchemaRequest, lro::Operation> _callDeleteSchema;

        /// <summary>
        /// Constructs a client wrapper for the SchemaService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SchemaServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SchemaServiceClientImpl(SchemaService.SchemaServiceClient grpcClient, SchemaServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SchemaServiceSettings effectiveSettings = settings ?? SchemaServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateSchemaOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateSchemaOperationsSettings, logger);
            UpdateSchemaOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateSchemaOperationsSettings, logger);
            DeleteSchemaOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteSchemaOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callGetSchema = clientHelper.BuildApiCall<GetSchemaRequest, Schema>("GetSchema", grpcClient.GetSchemaAsync, grpcClient.GetSchema, effectiveSettings.GetSchemaSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSchema);
            Modify_GetSchemaApiCall(ref _callGetSchema);
            _callListSchemas = clientHelper.BuildApiCall<ListSchemasRequest, ListSchemasResponse>("ListSchemas", grpcClient.ListSchemasAsync, grpcClient.ListSchemas, effectiveSettings.ListSchemasSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSchemas);
            Modify_ListSchemasApiCall(ref _callListSchemas);
            _callCreateSchema = clientHelper.BuildApiCall<CreateSchemaRequest, lro::Operation>("CreateSchema", grpcClient.CreateSchemaAsync, grpcClient.CreateSchema, effectiveSettings.CreateSchemaSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSchema);
            Modify_CreateSchemaApiCall(ref _callCreateSchema);
            _callUpdateSchema = clientHelper.BuildApiCall<UpdateSchemaRequest, lro::Operation>("UpdateSchema", grpcClient.UpdateSchemaAsync, grpcClient.UpdateSchema, effectiveSettings.UpdateSchemaSettings).WithGoogleRequestParam("schema.name", request => request.Schema?.Name);
            Modify_ApiCall(ref _callUpdateSchema);
            Modify_UpdateSchemaApiCall(ref _callUpdateSchema);
            _callDeleteSchema = clientHelper.BuildApiCall<DeleteSchemaRequest, lro::Operation>("DeleteSchema", grpcClient.DeleteSchemaAsync, grpcClient.DeleteSchema, effectiveSettings.DeleteSchemaSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSchema);
            Modify_DeleteSchemaApiCall(ref _callDeleteSchema);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetSchemaApiCall(ref gaxgrpc::ApiCall<GetSchemaRequest, Schema> call);

        partial void Modify_ListSchemasApiCall(ref gaxgrpc::ApiCall<ListSchemasRequest, ListSchemasResponse> call);

        partial void Modify_CreateSchemaApiCall(ref gaxgrpc::ApiCall<CreateSchemaRequest, lro::Operation> call);

        partial void Modify_UpdateSchemaApiCall(ref gaxgrpc::ApiCall<UpdateSchemaRequest, lro::Operation> call);

        partial void Modify_DeleteSchemaApiCall(ref gaxgrpc::ApiCall<DeleteSchemaRequest, lro::Operation> call);

        partial void OnConstruction(SchemaService.SchemaServiceClient grpcClient, SchemaServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SchemaService client</summary>
        public override SchemaService.SchemaServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_GetSchemaRequest(ref GetSchemaRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSchemasRequest(ref ListSchemasRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSchemaRequest(ref CreateSchemaRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSchemaRequest(ref UpdateSchemaRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSchemaRequest(ref DeleteSchemaRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets a [Schema][google.cloud.discoveryengine.v1.Schema].
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
        /// Gets a [Schema][google.cloud.discoveryengine.v1.Schema].
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
        /// Gets a list of [Schema][google.cloud.discoveryengine.v1.Schema]s.
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
        /// Gets a list of [Schema][google.cloud.discoveryengine.v1.Schema]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Schema"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSchemasResponse, Schema> ListSchemasAsync(ListSchemasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSchemasRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSchemasRequest, ListSchemasResponse, Schema>(_callListSchemas, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateSchema</c>.</summary>
        public override lro::OperationsClient CreateSchemaOperationsClient { get; }

        /// <summary>
        /// Creates a [Schema][google.cloud.discoveryengine.v1.Schema].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Schema, CreateSchemaMetadata> CreateSchema(CreateSchemaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSchemaRequest(ref request, ref callSettings);
            return new lro::Operation<Schema, CreateSchemaMetadata>(_callCreateSchema.Sync(request, callSettings), CreateSchemaOperationsClient);
        }

        /// <summary>
        /// Creates a [Schema][google.cloud.discoveryengine.v1.Schema].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Schema, CreateSchemaMetadata>> CreateSchemaAsync(CreateSchemaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSchemaRequest(ref request, ref callSettings);
            return new lro::Operation<Schema, CreateSchemaMetadata>(await _callCreateSchema.Async(request, callSettings).ConfigureAwait(false), CreateSchemaOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateSchema</c>.</summary>
        public override lro::OperationsClient UpdateSchemaOperationsClient { get; }

        /// <summary>
        /// Updates a [Schema][google.cloud.discoveryengine.v1.Schema].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Schema, UpdateSchemaMetadata> UpdateSchema(UpdateSchemaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSchemaRequest(ref request, ref callSettings);
            return new lro::Operation<Schema, UpdateSchemaMetadata>(_callUpdateSchema.Sync(request, callSettings), UpdateSchemaOperationsClient);
        }

        /// <summary>
        /// Updates a [Schema][google.cloud.discoveryengine.v1.Schema].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Schema, UpdateSchemaMetadata>> UpdateSchemaAsync(UpdateSchemaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSchemaRequest(ref request, ref callSettings);
            return new lro::Operation<Schema, UpdateSchemaMetadata>(await _callUpdateSchema.Async(request, callSettings).ConfigureAwait(false), UpdateSchemaOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteSchema</c>.</summary>
        public override lro::OperationsClient DeleteSchemaOperationsClient { get; }

        /// <summary>
        /// Deletes a [Schema][google.cloud.discoveryengine.v1.Schema].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteSchemaMetadata> DeleteSchema(DeleteSchemaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSchemaRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteSchemaMetadata>(_callDeleteSchema.Sync(request, callSettings), DeleteSchemaOperationsClient);
        }

        /// <summary>
        /// Deletes a [Schema][google.cloud.discoveryengine.v1.Schema].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteSchemaMetadata>> DeleteSchemaAsync(DeleteSchemaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSchemaRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteSchemaMetadata>(await _callDeleteSchema.Async(request, callSettings).ConfigureAwait(false), DeleteSchemaOperationsClient);
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
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() =>
                new lro::Operations.OperationsClient(CallInvoker);
        }
    }

    public static partial class SchemaService
    {
        public partial class SchemaServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="gcl::Locations.LocationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gcl::Locations.LocationsClient"/> for the same target as this client.
            /// </returns>
            public virtual gcl::Locations.LocationsClient CreateLocationsClient() =>
                new gcl::Locations.LocationsClient(CallInvoker);
        }
    }
}
