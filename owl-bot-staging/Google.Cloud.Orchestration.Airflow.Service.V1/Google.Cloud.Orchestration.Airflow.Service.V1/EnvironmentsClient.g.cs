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
using lro = Google.LongRunning;
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

namespace Google.Cloud.Orchestration.Airflow.Service.V1
{
    /// <summary>Settings for <see cref="EnvironmentsClient"/> instances.</summary>
    public sealed partial class EnvironmentsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="EnvironmentsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="EnvironmentsSettings"/>.</returns>
        public static EnvironmentsSettings GetDefault() => new EnvironmentsSettings();

        /// <summary>Constructs a new <see cref="EnvironmentsSettings"/> object with default settings.</summary>
        public EnvironmentsSettings()
        {
        }

        private EnvironmentsSettings(EnvironmentsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateEnvironmentSettings = existing.CreateEnvironmentSettings;
            CreateEnvironmentOperationsSettings = existing.CreateEnvironmentOperationsSettings.Clone();
            GetEnvironmentSettings = existing.GetEnvironmentSettings;
            ListEnvironmentsSettings = existing.ListEnvironmentsSettings;
            UpdateEnvironmentSettings = existing.UpdateEnvironmentSettings;
            UpdateEnvironmentOperationsSettings = existing.UpdateEnvironmentOperationsSettings.Clone();
            DeleteEnvironmentSettings = existing.DeleteEnvironmentSettings;
            DeleteEnvironmentOperationsSettings = existing.DeleteEnvironmentOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(EnvironmentsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.CreateEnvironment</c> and <c>EnvironmentsClient.CreateEnvironmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateEnvironmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>EnvironmentsClient.CreateEnvironment</c> and
        /// <c>EnvironmentsClient.CreateEnvironmentAsync</c>.
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
        public lro::OperationsSettings CreateEnvironmentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.GetEnvironment</c> and <c>EnvironmentsClient.GetEnvironmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEnvironmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.ListEnvironments</c> and <c>EnvironmentsClient.ListEnvironmentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEnvironmentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.UpdateEnvironment</c> and <c>EnvironmentsClient.UpdateEnvironmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateEnvironmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>EnvironmentsClient.UpdateEnvironment</c> and
        /// <c>EnvironmentsClient.UpdateEnvironmentAsync</c>.
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
        public lro::OperationsSettings UpdateEnvironmentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.DeleteEnvironment</c> and <c>EnvironmentsClient.DeleteEnvironmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteEnvironmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>EnvironmentsClient.DeleteEnvironment</c> and
        /// <c>EnvironmentsClient.DeleteEnvironmentAsync</c>.
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
        public lro::OperationsSettings DeleteEnvironmentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="EnvironmentsSettings"/> object.</returns>
        public EnvironmentsSettings Clone() => new EnvironmentsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="EnvironmentsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class EnvironmentsClientBuilder : gaxgrpc::ClientBuilderBase<EnvironmentsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public EnvironmentsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public EnvironmentsClientBuilder()
        {
            UseJwtAccessWithScopes = EnvironmentsClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref EnvironmentsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<EnvironmentsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override EnvironmentsClient Build()
        {
            EnvironmentsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<EnvironmentsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<EnvironmentsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private EnvironmentsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return EnvironmentsClient.Create(callInvoker, Settings);
        }

        private async stt::Task<EnvironmentsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return EnvironmentsClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => EnvironmentsClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => EnvironmentsClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => EnvironmentsClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>Environments client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Managed Apache Airflow Environments.
    /// </remarks>
    public abstract partial class EnvironmentsClient
    {
        /// <summary>
        /// The default endpoint for the Environments service, which is a host of "composer.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "composer.googleapis.com:443";

        /// <summary>The default Environments scopes.</summary>
        /// <remarks>
        /// The default Environments scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
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
        /// Asynchronously creates a <see cref="EnvironmentsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="EnvironmentsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="EnvironmentsClient"/>.</returns>
        public static stt::Task<EnvironmentsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new EnvironmentsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="EnvironmentsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="EnvironmentsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="EnvironmentsClient"/>.</returns>
        public static EnvironmentsClient Create() => new EnvironmentsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="EnvironmentsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="EnvironmentsSettings"/>.</param>
        /// <returns>The created <see cref="EnvironmentsClient"/>.</returns>
        internal static EnvironmentsClient Create(grpccore::CallInvoker callInvoker, EnvironmentsSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Environments.EnvironmentsClient grpcClient = new Environments.EnvironmentsClient(callInvoker);
            return new EnvironmentsClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC Environments client</summary>
        public virtual Environments.EnvironmentsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Environment, OperationMetadata> CreateEnvironment(CreateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Environment, OperationMetadata>> CreateEnvironmentAsync(CreateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Environment, OperationMetadata>> CreateEnvironmentAsync(CreateEnvironmentRequest request, st::CancellationToken cancellationToken) =>
            CreateEnvironmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateEnvironment</c>.</summary>
        public virtual lro::OperationsClient CreateEnvironmentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateEnvironment</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Environment, OperationMetadata> PollOnceCreateEnvironment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Environment, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEnvironmentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateEnvironment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Environment, OperationMetadata>> PollOnceCreateEnvironmentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Environment, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEnvironmentOperationsClient, callSettings);

        /// <summary>
        /// Create a new environment.
        /// </summary>
        /// <param name="parent">
        /// The parent must be of the form
        /// "projects/{projectId}/locations/{locationId}".
        /// </param>
        /// <param name="environment">
        /// The environment to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Environment, OperationMetadata> CreateEnvironment(string parent, Environment environment, gaxgrpc::CallSettings callSettings = null) =>
            CreateEnvironment(new CreateEnvironmentRequest
            {
                Parent = parent ?? "",
                Environment = environment,
            }, callSettings);

        /// <summary>
        /// Create a new environment.
        /// </summary>
        /// <param name="parent">
        /// The parent must be of the form
        /// "projects/{projectId}/locations/{locationId}".
        /// </param>
        /// <param name="environment">
        /// The environment to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Environment, OperationMetadata>> CreateEnvironmentAsync(string parent, Environment environment, gaxgrpc::CallSettings callSettings = null) =>
            CreateEnvironmentAsync(new CreateEnvironmentRequest
            {
                Parent = parent ?? "",
                Environment = environment,
            }, callSettings);

        /// <summary>
        /// Create a new environment.
        /// </summary>
        /// <param name="parent">
        /// The parent must be of the form
        /// "projects/{projectId}/locations/{locationId}".
        /// </param>
        /// <param name="environment">
        /// The environment to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Environment, OperationMetadata>> CreateEnvironmentAsync(string parent, Environment environment, st::CancellationToken cancellationToken) =>
            CreateEnvironmentAsync(parent, environment, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get an existing environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Environment GetEnvironment(GetEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get an existing environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Environment> GetEnvironmentAsync(GetEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get an existing environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Environment> GetEnvironmentAsync(GetEnvironmentRequest request, st::CancellationToken cancellationToken) =>
            GetEnvironmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get an existing environment.
        /// </summary>
        /// <param name="name">
        /// The resource name of the environment to get, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Environment GetEnvironment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEnvironment(new GetEnvironmentRequest { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Get an existing environment.
        /// </summary>
        /// <param name="name">
        /// The resource name of the environment to get, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Environment> GetEnvironmentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEnvironmentAsync(new GetEnvironmentRequest { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Get an existing environment.
        /// </summary>
        /// <param name="name">
        /// The resource name of the environment to get, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Environment> GetEnvironmentAsync(string name, st::CancellationToken cancellationToken) =>
            GetEnvironmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List environments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Environment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEnvironmentsResponse, Environment> ListEnvironments(ListEnvironmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List environments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Environment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEnvironmentsResponse, Environment> ListEnvironmentsAsync(ListEnvironmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List environments.
        /// </summary>
        /// <param name="parent">
        /// List environments in the given project and location, in the form:
        /// "projects/{projectId}/locations/{locationId}"
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
        /// <returns>A pageable sequence of <see cref="Environment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEnvironmentsResponse, Environment> ListEnvironments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListEnvironments(new ListEnvironmentsRequest
            {
                Parent = parent ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List environments.
        /// </summary>
        /// <param name="parent">
        /// List environments in the given project and location, in the form:
        /// "projects/{projectId}/locations/{locationId}"
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
        /// <returns>A pageable asynchronous sequence of <see cref="Environment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEnvironmentsResponse, Environment> ListEnvironmentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListEnvironmentsAsync(new ListEnvironmentsRequest
            {
                Parent = parent ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Update an environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Environment, OperationMetadata> UpdateEnvironment(UpdateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update an environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Environment, OperationMetadata>> UpdateEnvironmentAsync(UpdateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update an environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Environment, OperationMetadata>> UpdateEnvironmentAsync(UpdateEnvironmentRequest request, st::CancellationToken cancellationToken) =>
            UpdateEnvironmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateEnvironment</c>.</summary>
        public virtual lro::OperationsClient UpdateEnvironmentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateEnvironment</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Environment, OperationMetadata> PollOnceUpdateEnvironment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Environment, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateEnvironmentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateEnvironment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Environment, OperationMetadata>> PollOnceUpdateEnvironmentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Environment, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateEnvironmentOperationsClient, callSettings);

        /// <summary>
        /// Update an environment.
        /// </summary>
        /// <param name="name">
        /// The relative resource name of the environment to update, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
        /// </param>
        /// <param name="environment">
        /// A patch environment. Fields specified by the `updateMask` will be copied
        /// from the patch environment into the environment under update.
        /// </param>
        /// <param name="updateMask">
        /// Required. A comma-separated list of paths, relative to `Environment`, of
        /// fields to update.
        /// For example, to set the version of scikit-learn to install in the
        /// environment to 0.19.0 and to remove an existing installation of
        /// numpy, the `updateMask` parameter would include the following two
        /// `paths` values: "config.softwareConfig.pypiPackages.scikit-learn" and
        /// "config.softwareConfig.pypiPackages.numpy". The included patch
        /// environment would specify the scikit-learn version as follows:
        /// 
        /// {
        /// "config":{
        /// "softwareConfig":{
        /// "pypiPackages":{
        /// "scikit-learn":"==0.19.0"
        /// }
        /// }
        /// }
        /// }
        /// 
        /// Note that in the above example, any existing PyPI packages
        /// other than scikit-learn and numpy will be unaffected.
        /// 
        /// Only one update type may be included in a single request's `updateMask`.
        /// For example, one cannot update both the PyPI packages and
        /// labels in the same request. However, it is possible to update multiple
        /// members of a map field simultaneously in the same request. For example,
        /// to set the labels "label1" and "label2" while clearing "label3" (assuming
        /// it already exists), one can
        /// provide the paths "labels.label1", "labels.label2", and "labels.label3"
        /// and populate the patch environment as follows:
        /// 
        /// {
        /// "labels":{
        /// "label1":"new-label1-value"
        /// "label2":"new-label2-value"
        /// }
        /// }
        /// 
        /// Note that in the above example, any existing labels that are not
        /// included in the `updateMask` will be unaffected.
        /// 
        /// It is also possible to replace an entire map field by providing the
        /// map field's path in the `updateMask`. The new value of the field will
        /// be that which is provided in the patch environment. For example, to
        /// delete all pre-existing user-specified PyPI packages and
        /// install botocore at version 1.7.14, the `updateMask` would contain
        /// the path "config.softwareConfig.pypiPackages", and
        /// the patch environment would be the following:
        /// 
        /// {
        /// "config":{
        /// "softwareConfig":{
        /// "pypiPackages":{
        /// "botocore":"==1.7.14"
        /// }
        /// }
        /// }
        /// }
        /// 
        /// **Note:** Only the following fields can be updated:
        /// 
        /// * `config.softwareConfig.pypiPackages`
        /// * Replace all custom custom PyPI packages. If a replacement
        /// package map is not included in `environment`, all custom
        /// PyPI packages are cleared. It is an error to provide both
        /// this mask and a mask specifying an individual package.
        /// * `config.softwareConfig.pypiPackages.`packagename
        /// * Update the custom PyPI package *packagename*,
        /// preserving other packages. To delete the package, include it in
        /// `updateMask`, and omit the mapping for it in
        /// `environment.config.softwareConfig.pypiPackages`. It is an error
        /// to provide both a mask of this form and the
        /// `config.softwareConfig.pypiPackages` mask.
        /// * `labels`
        /// * Replace all environment labels. If a replacement labels map is not
        /// included in `environment`, all labels are cleared. It is an error to
        /// provide both this mask and a mask specifying one or more individual
        /// labels.
        /// * `labels.`labelName
        /// * Set the label named *labelName*, while preserving other
        /// labels. To delete the label, include it in `updateMask` and omit its
        /// mapping in `environment.labels`. It is an error to provide both a
        /// mask of this form and the `labels` mask.
        /// * `config.nodeCount`
        /// * Horizontally scale the number of nodes in the environment. An integer
        /// greater than or equal to 3 must be provided in the `config.nodeCount`
        /// field.
        /// * `config.webServerNetworkAccessControl`
        /// * Replace the environment's current `WebServerNetworkAccessControl`.
        /// * `config.databaseConfig`
        /// * Replace the environment's current `DatabaseConfig`.
        /// * `config.webServerConfig`
        /// * Replace the environment's current `WebServerConfig`.
        /// * `config.softwareConfig.airflowConfigOverrides`
        /// * Replace all Apache Airflow config overrides. If a replacement config
        /// overrides map is not included in `environment`, all config overrides
        /// are cleared.
        /// It is an error to provide both this mask and a mask specifying one or
        /// more individual config overrides.
        /// * `config.softwareConfig.airflowConfigOverrides.`section-name
        /// * Override the Apache Airflow config property *name* in the
        /// section named *section*, preserving other properties. To
        /// delete the property override, include it in `updateMask` and omit its
        /// mapping in
        /// `environment.config.softwareConfig.airflowConfigOverrides`.
        /// It is an error to provide both a mask of this form and the
        /// `config.softwareConfig.airflowConfigOverrides` mask.
        /// * `config.softwareConfig.envVariables`
        /// * Replace all environment variables. If a replacement environment
        /// variable map is not included in `environment`, all custom environment
        /// variables  are cleared.
        /// It is an error to provide both this mask and a mask specifying one or
        /// more individual environment variables.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Environment, OperationMetadata> UpdateEnvironment(string name, Environment environment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEnvironment(new UpdateEnvironmentRequest
            {
                Name = name ?? "",
                Environment = environment,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update an environment.
        /// </summary>
        /// <param name="name">
        /// The relative resource name of the environment to update, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
        /// </param>
        /// <param name="environment">
        /// A patch environment. Fields specified by the `updateMask` will be copied
        /// from the patch environment into the environment under update.
        /// </param>
        /// <param name="updateMask">
        /// Required. A comma-separated list of paths, relative to `Environment`, of
        /// fields to update.
        /// For example, to set the version of scikit-learn to install in the
        /// environment to 0.19.0 and to remove an existing installation of
        /// numpy, the `updateMask` parameter would include the following two
        /// `paths` values: "config.softwareConfig.pypiPackages.scikit-learn" and
        /// "config.softwareConfig.pypiPackages.numpy". The included patch
        /// environment would specify the scikit-learn version as follows:
        /// 
        /// {
        /// "config":{
        /// "softwareConfig":{
        /// "pypiPackages":{
        /// "scikit-learn":"==0.19.0"
        /// }
        /// }
        /// }
        /// }
        /// 
        /// Note that in the above example, any existing PyPI packages
        /// other than scikit-learn and numpy will be unaffected.
        /// 
        /// Only one update type may be included in a single request's `updateMask`.
        /// For example, one cannot update both the PyPI packages and
        /// labels in the same request. However, it is possible to update multiple
        /// members of a map field simultaneously in the same request. For example,
        /// to set the labels "label1" and "label2" while clearing "label3" (assuming
        /// it already exists), one can
        /// provide the paths "labels.label1", "labels.label2", and "labels.label3"
        /// and populate the patch environment as follows:
        /// 
        /// {
        /// "labels":{
        /// "label1":"new-label1-value"
        /// "label2":"new-label2-value"
        /// }
        /// }
        /// 
        /// Note that in the above example, any existing labels that are not
        /// included in the `updateMask` will be unaffected.
        /// 
        /// It is also possible to replace an entire map field by providing the
        /// map field's path in the `updateMask`. The new value of the field will
        /// be that which is provided in the patch environment. For example, to
        /// delete all pre-existing user-specified PyPI packages and
        /// install botocore at version 1.7.14, the `updateMask` would contain
        /// the path "config.softwareConfig.pypiPackages", and
        /// the patch environment would be the following:
        /// 
        /// {
        /// "config":{
        /// "softwareConfig":{
        /// "pypiPackages":{
        /// "botocore":"==1.7.14"
        /// }
        /// }
        /// }
        /// }
        /// 
        /// **Note:** Only the following fields can be updated:
        /// 
        /// * `config.softwareConfig.pypiPackages`
        /// * Replace all custom custom PyPI packages. If a replacement
        /// package map is not included in `environment`, all custom
        /// PyPI packages are cleared. It is an error to provide both
        /// this mask and a mask specifying an individual package.
        /// * `config.softwareConfig.pypiPackages.`packagename
        /// * Update the custom PyPI package *packagename*,
        /// preserving other packages. To delete the package, include it in
        /// `updateMask`, and omit the mapping for it in
        /// `environment.config.softwareConfig.pypiPackages`. It is an error
        /// to provide both a mask of this form and the
        /// `config.softwareConfig.pypiPackages` mask.
        /// * `labels`
        /// * Replace all environment labels. If a replacement labels map is not
        /// included in `environment`, all labels are cleared. It is an error to
        /// provide both this mask and a mask specifying one or more individual
        /// labels.
        /// * `labels.`labelName
        /// * Set the label named *labelName*, while preserving other
        /// labels. To delete the label, include it in `updateMask` and omit its
        /// mapping in `environment.labels`. It is an error to provide both a
        /// mask of this form and the `labels` mask.
        /// * `config.nodeCount`
        /// * Horizontally scale the number of nodes in the environment. An integer
        /// greater than or equal to 3 must be provided in the `config.nodeCount`
        /// field.
        /// * `config.webServerNetworkAccessControl`
        /// * Replace the environment's current `WebServerNetworkAccessControl`.
        /// * `config.databaseConfig`
        /// * Replace the environment's current `DatabaseConfig`.
        /// * `config.webServerConfig`
        /// * Replace the environment's current `WebServerConfig`.
        /// * `config.softwareConfig.airflowConfigOverrides`
        /// * Replace all Apache Airflow config overrides. If a replacement config
        /// overrides map is not included in `environment`, all config overrides
        /// are cleared.
        /// It is an error to provide both this mask and a mask specifying one or
        /// more individual config overrides.
        /// * `config.softwareConfig.airflowConfigOverrides.`section-name
        /// * Override the Apache Airflow config property *name* in the
        /// section named *section*, preserving other properties. To
        /// delete the property override, include it in `updateMask` and omit its
        /// mapping in
        /// `environment.config.softwareConfig.airflowConfigOverrides`.
        /// It is an error to provide both a mask of this form and the
        /// `config.softwareConfig.airflowConfigOverrides` mask.
        /// * `config.softwareConfig.envVariables`
        /// * Replace all environment variables. If a replacement environment
        /// variable map is not included in `environment`, all custom environment
        /// variables  are cleared.
        /// It is an error to provide both this mask and a mask specifying one or
        /// more individual environment variables.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Environment, OperationMetadata>> UpdateEnvironmentAsync(string name, Environment environment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEnvironmentAsync(new UpdateEnvironmentRequest
            {
                Name = name ?? "",
                Environment = environment,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update an environment.
        /// </summary>
        /// <param name="name">
        /// The relative resource name of the environment to update, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
        /// </param>
        /// <param name="environment">
        /// A patch environment. Fields specified by the `updateMask` will be copied
        /// from the patch environment into the environment under update.
        /// </param>
        /// <param name="updateMask">
        /// Required. A comma-separated list of paths, relative to `Environment`, of
        /// fields to update.
        /// For example, to set the version of scikit-learn to install in the
        /// environment to 0.19.0 and to remove an existing installation of
        /// numpy, the `updateMask` parameter would include the following two
        /// `paths` values: "config.softwareConfig.pypiPackages.scikit-learn" and
        /// "config.softwareConfig.pypiPackages.numpy". The included patch
        /// environment would specify the scikit-learn version as follows:
        /// 
        /// {
        /// "config":{
        /// "softwareConfig":{
        /// "pypiPackages":{
        /// "scikit-learn":"==0.19.0"
        /// }
        /// }
        /// }
        /// }
        /// 
        /// Note that in the above example, any existing PyPI packages
        /// other than scikit-learn and numpy will be unaffected.
        /// 
        /// Only one update type may be included in a single request's `updateMask`.
        /// For example, one cannot update both the PyPI packages and
        /// labels in the same request. However, it is possible to update multiple
        /// members of a map field simultaneously in the same request. For example,
        /// to set the labels "label1" and "label2" while clearing "label3" (assuming
        /// it already exists), one can
        /// provide the paths "labels.label1", "labels.label2", and "labels.label3"
        /// and populate the patch environment as follows:
        /// 
        /// {
        /// "labels":{
        /// "label1":"new-label1-value"
        /// "label2":"new-label2-value"
        /// }
        /// }
        /// 
        /// Note that in the above example, any existing labels that are not
        /// included in the `updateMask` will be unaffected.
        /// 
        /// It is also possible to replace an entire map field by providing the
        /// map field's path in the `updateMask`. The new value of the field will
        /// be that which is provided in the patch environment. For example, to
        /// delete all pre-existing user-specified PyPI packages and
        /// install botocore at version 1.7.14, the `updateMask` would contain
        /// the path "config.softwareConfig.pypiPackages", and
        /// the patch environment would be the following:
        /// 
        /// {
        /// "config":{
        /// "softwareConfig":{
        /// "pypiPackages":{
        /// "botocore":"==1.7.14"
        /// }
        /// }
        /// }
        /// }
        /// 
        /// **Note:** Only the following fields can be updated:
        /// 
        /// * `config.softwareConfig.pypiPackages`
        /// * Replace all custom custom PyPI packages. If a replacement
        /// package map is not included in `environment`, all custom
        /// PyPI packages are cleared. It is an error to provide both
        /// this mask and a mask specifying an individual package.
        /// * `config.softwareConfig.pypiPackages.`packagename
        /// * Update the custom PyPI package *packagename*,
        /// preserving other packages. To delete the package, include it in
        /// `updateMask`, and omit the mapping for it in
        /// `environment.config.softwareConfig.pypiPackages`. It is an error
        /// to provide both a mask of this form and the
        /// `config.softwareConfig.pypiPackages` mask.
        /// * `labels`
        /// * Replace all environment labels. If a replacement labels map is not
        /// included in `environment`, all labels are cleared. It is an error to
        /// provide both this mask and a mask specifying one or more individual
        /// labels.
        /// * `labels.`labelName
        /// * Set the label named *labelName*, while preserving other
        /// labels. To delete the label, include it in `updateMask` and omit its
        /// mapping in `environment.labels`. It is an error to provide both a
        /// mask of this form and the `labels` mask.
        /// * `config.nodeCount`
        /// * Horizontally scale the number of nodes in the environment. An integer
        /// greater than or equal to 3 must be provided in the `config.nodeCount`
        /// field.
        /// * `config.webServerNetworkAccessControl`
        /// * Replace the environment's current `WebServerNetworkAccessControl`.
        /// * `config.databaseConfig`
        /// * Replace the environment's current `DatabaseConfig`.
        /// * `config.webServerConfig`
        /// * Replace the environment's current `WebServerConfig`.
        /// * `config.softwareConfig.airflowConfigOverrides`
        /// * Replace all Apache Airflow config overrides. If a replacement config
        /// overrides map is not included in `environment`, all config overrides
        /// are cleared.
        /// It is an error to provide both this mask and a mask specifying one or
        /// more individual config overrides.
        /// * `config.softwareConfig.airflowConfigOverrides.`section-name
        /// * Override the Apache Airflow config property *name* in the
        /// section named *section*, preserving other properties. To
        /// delete the property override, include it in `updateMask` and omit its
        /// mapping in
        /// `environment.config.softwareConfig.airflowConfigOverrides`.
        /// It is an error to provide both a mask of this form and the
        /// `config.softwareConfig.airflowConfigOverrides` mask.
        /// * `config.softwareConfig.envVariables`
        /// * Replace all environment variables. If a replacement environment
        /// variable map is not included in `environment`, all custom environment
        /// variables  are cleared.
        /// It is an error to provide both this mask and a mask specifying one or
        /// more individual environment variables.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Environment, OperationMetadata>> UpdateEnvironmentAsync(string name, Environment environment, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateEnvironmentAsync(name, environment, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete an environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteEnvironment(DeleteEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete an environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEnvironmentAsync(DeleteEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete an environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEnvironmentAsync(DeleteEnvironmentRequest request, st::CancellationToken cancellationToken) =>
            DeleteEnvironmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteEnvironment</c>.</summary>
        public virtual lro::OperationsClient DeleteEnvironmentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteEnvironment</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteEnvironment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteEnvironmentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteEnvironment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteEnvironmentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteEnvironmentOperationsClient, callSettings);

        /// <summary>
        /// Delete an environment.
        /// </summary>
        /// <param name="name">
        /// The environment to delete, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteEnvironment(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEnvironment(new DeleteEnvironmentRequest { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Delete an environment.
        /// </summary>
        /// <param name="name">
        /// The environment to delete, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEnvironmentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEnvironmentAsync(new DeleteEnvironmentRequest { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Delete an environment.
        /// </summary>
        /// <param name="name">
        /// The environment to delete, in the form:
        /// "projects/{projectId}/locations/{locationId}/environments/{environmentId}"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEnvironmentAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteEnvironmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Environments client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Managed Apache Airflow Environments.
    /// </remarks>
    public sealed partial class EnvironmentsClientImpl : EnvironmentsClient
    {
        private readonly gaxgrpc::ApiCall<CreateEnvironmentRequest, lro::Operation> _callCreateEnvironment;

        private readonly gaxgrpc::ApiCall<GetEnvironmentRequest, Environment> _callGetEnvironment;

        private readonly gaxgrpc::ApiCall<ListEnvironmentsRequest, ListEnvironmentsResponse> _callListEnvironments;

        private readonly gaxgrpc::ApiCall<UpdateEnvironmentRequest, lro::Operation> _callUpdateEnvironment;

        private readonly gaxgrpc::ApiCall<DeleteEnvironmentRequest, lro::Operation> _callDeleteEnvironment;

        /// <summary>
        /// Constructs a client wrapper for the Environments service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="EnvironmentsSettings"/> used within this client.</param>
        public EnvironmentsClientImpl(Environments.EnvironmentsClient grpcClient, EnvironmentsSettings settings)
        {
            GrpcClient = grpcClient;
            EnvironmentsSettings effectiveSettings = settings ?? EnvironmentsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            CreateEnvironmentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateEnvironmentOperationsSettings);
            UpdateEnvironmentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateEnvironmentOperationsSettings);
            DeleteEnvironmentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteEnvironmentOperationsSettings);
            _callCreateEnvironment = clientHelper.BuildApiCall<CreateEnvironmentRequest, lro::Operation>(grpcClient.CreateEnvironmentAsync, grpcClient.CreateEnvironment, effectiveSettings.CreateEnvironmentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateEnvironment);
            Modify_CreateEnvironmentApiCall(ref _callCreateEnvironment);
            _callGetEnvironment = clientHelper.BuildApiCall<GetEnvironmentRequest, Environment>(grpcClient.GetEnvironmentAsync, grpcClient.GetEnvironment, effectiveSettings.GetEnvironmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEnvironment);
            Modify_GetEnvironmentApiCall(ref _callGetEnvironment);
            _callListEnvironments = clientHelper.BuildApiCall<ListEnvironmentsRequest, ListEnvironmentsResponse>(grpcClient.ListEnvironmentsAsync, grpcClient.ListEnvironments, effectiveSettings.ListEnvironmentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEnvironments);
            Modify_ListEnvironmentsApiCall(ref _callListEnvironments);
            _callUpdateEnvironment = clientHelper.BuildApiCall<UpdateEnvironmentRequest, lro::Operation>(grpcClient.UpdateEnvironmentAsync, grpcClient.UpdateEnvironment, effectiveSettings.UpdateEnvironmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateEnvironment);
            Modify_UpdateEnvironmentApiCall(ref _callUpdateEnvironment);
            _callDeleteEnvironment = clientHelper.BuildApiCall<DeleteEnvironmentRequest, lro::Operation>(grpcClient.DeleteEnvironmentAsync, grpcClient.DeleteEnvironment, effectiveSettings.DeleteEnvironmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteEnvironment);
            Modify_DeleteEnvironmentApiCall(ref _callDeleteEnvironment);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateEnvironmentApiCall(ref gaxgrpc::ApiCall<CreateEnvironmentRequest, lro::Operation> call);

        partial void Modify_GetEnvironmentApiCall(ref gaxgrpc::ApiCall<GetEnvironmentRequest, Environment> call);

        partial void Modify_ListEnvironmentsApiCall(ref gaxgrpc::ApiCall<ListEnvironmentsRequest, ListEnvironmentsResponse> call);

        partial void Modify_UpdateEnvironmentApiCall(ref gaxgrpc::ApiCall<UpdateEnvironmentRequest, lro::Operation> call);

        partial void Modify_DeleteEnvironmentApiCall(ref gaxgrpc::ApiCall<DeleteEnvironmentRequest, lro::Operation> call);

        partial void OnConstruction(Environments.EnvironmentsClient grpcClient, EnvironmentsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Environments client</summary>
        public override Environments.EnvironmentsClient GrpcClient { get; }

        partial void Modify_CreateEnvironmentRequest(ref CreateEnvironmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEnvironmentRequest(ref GetEnvironmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEnvironmentsRequest(ref ListEnvironmentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateEnvironmentRequest(ref UpdateEnvironmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteEnvironmentRequest(ref DeleteEnvironmentRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateEnvironment</c>.</summary>
        public override lro::OperationsClient CreateEnvironmentOperationsClient { get; }

        /// <summary>
        /// Create a new environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Environment, OperationMetadata> CreateEnvironment(CreateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEnvironmentRequest(ref request, ref callSettings);
            return new lro::Operation<Environment, OperationMetadata>(_callCreateEnvironment.Sync(request, callSettings), CreateEnvironmentOperationsClient);
        }

        /// <summary>
        /// Create a new environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Environment, OperationMetadata>> CreateEnvironmentAsync(CreateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEnvironmentRequest(ref request, ref callSettings);
            return new lro::Operation<Environment, OperationMetadata>(await _callCreateEnvironment.Async(request, callSettings).ConfigureAwait(false), CreateEnvironmentOperationsClient);
        }

        /// <summary>
        /// Get an existing environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Environment GetEnvironment(GetEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEnvironmentRequest(ref request, ref callSettings);
            return _callGetEnvironment.Sync(request, callSettings);
        }

        /// <summary>
        /// Get an existing environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Environment> GetEnvironmentAsync(GetEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEnvironmentRequest(ref request, ref callSettings);
            return _callGetEnvironment.Async(request, callSettings);
        }

        /// <summary>
        /// List environments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Environment"/> resources.</returns>
        public override gax::PagedEnumerable<ListEnvironmentsResponse, Environment> ListEnvironments(ListEnvironmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEnvironmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEnvironmentsRequest, ListEnvironmentsResponse, Environment>(_callListEnvironments, request, callSettings);
        }

        /// <summary>
        /// List environments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Environment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEnvironmentsResponse, Environment> ListEnvironmentsAsync(ListEnvironmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEnvironmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEnvironmentsRequest, ListEnvironmentsResponse, Environment>(_callListEnvironments, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateEnvironment</c>.</summary>
        public override lro::OperationsClient UpdateEnvironmentOperationsClient { get; }

        /// <summary>
        /// Update an environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Environment, OperationMetadata> UpdateEnvironment(UpdateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEnvironmentRequest(ref request, ref callSettings);
            return new lro::Operation<Environment, OperationMetadata>(_callUpdateEnvironment.Sync(request, callSettings), UpdateEnvironmentOperationsClient);
        }

        /// <summary>
        /// Update an environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Environment, OperationMetadata>> UpdateEnvironmentAsync(UpdateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEnvironmentRequest(ref request, ref callSettings);
            return new lro::Operation<Environment, OperationMetadata>(await _callUpdateEnvironment.Async(request, callSettings).ConfigureAwait(false), UpdateEnvironmentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteEnvironment</c>.</summary>
        public override lro::OperationsClient DeleteEnvironmentOperationsClient { get; }

        /// <summary>
        /// Delete an environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteEnvironment(DeleteEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEnvironmentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteEnvironment.Sync(request, callSettings), DeleteEnvironmentOperationsClient);
        }

        /// <summary>
        /// Delete an environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEnvironmentAsync(DeleteEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEnvironmentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteEnvironment.Async(request, callSettings).ConfigureAwait(false), DeleteEnvironmentOperationsClient);
        }
    }

    public partial class ListEnvironmentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEnvironmentsResponse : gaxgrpc::IPageResponse<Environment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Environment> GetEnumerator() => Environments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Environments
    {
        public partial class EnvironmentsClient
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
}
