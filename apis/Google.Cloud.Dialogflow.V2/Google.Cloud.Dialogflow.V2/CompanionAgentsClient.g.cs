// Copyright 2026 Google LLC
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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gcl = Google.Cloud.Location;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Dialogflow.V2
{
    /// <summary>Settings for <see cref="CompanionAgentsClient"/> instances.</summary>
    public sealed partial class CompanionAgentsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CompanionAgentsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CompanionAgentsSettings"/>.</returns>
        public static CompanionAgentsSettings GetDefault() => new CompanionAgentsSettings();

        /// <summary>Constructs a new <see cref="CompanionAgentsSettings"/> object with default settings.</summary>
        public CompanionAgentsSettings()
        {
        }

        private CompanionAgentsSettings(CompanionAgentsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateCompanionAgentSettings = existing.CreateCompanionAgentSettings;
            GetCompanionAgentSettings = existing.GetCompanionAgentSettings;
            UpdateCompanionAgentSettings = existing.UpdateCompanionAgentSettings;
            DeleteCompanionAgentSettings = existing.DeleteCompanionAgentSettings;
            ListCompanionAgentsSettings = existing.ListCompanionAgentsSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CompanionAgentsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CompanionAgentsClient.CreateCompanionAgent</c> and <c>CompanionAgentsClient.CreateCompanionAgentAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateCompanionAgentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CompanionAgentsClient.GetCompanionAgent</c> and <c>CompanionAgentsClient.GetCompanionAgentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCompanionAgentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CompanionAgentsClient.UpdateCompanionAgent</c> and <c>CompanionAgentsClient.UpdateCompanionAgentAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateCompanionAgentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CompanionAgentsClient.DeleteCompanionAgent</c> and <c>CompanionAgentsClient.DeleteCompanionAgentAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteCompanionAgentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CompanionAgentsClient.ListCompanionAgents</c> and <c>CompanionAgentsClient.ListCompanionAgentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCompanionAgentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CompanionAgentsSettings"/> object.</returns>
        public CompanionAgentsSettings Clone() => new CompanionAgentsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CompanionAgentsClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class CompanionAgentsClientBuilder : gaxgrpc::ClientBuilderBase<CompanionAgentsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CompanionAgentsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CompanionAgentsClientBuilder() : base(CompanionAgentsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CompanionAgentsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CompanionAgentsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CompanionAgentsClient Build()
        {
            CompanionAgentsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CompanionAgentsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CompanionAgentsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CompanionAgentsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CompanionAgentsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CompanionAgentsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CompanionAgentsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CompanionAgentsClient.ChannelPool;
    }

    /// <summary>CompanionAgents client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing companion agents.
    /// </remarks>
    public abstract partial class CompanionAgentsClient
    {
        /// <summary>
        /// The default endpoint for the CompanionAgents service, which is a host of "dialogflow.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dialogflow.googleapis.com:443";

        /// <summary>The default CompanionAgents scopes.</summary>
        /// <remarks>
        /// The default CompanionAgents scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/dialogflow</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/dialogflow",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CompanionAgents.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CompanionAgentsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CompanionAgentsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CompanionAgentsClient"/>.</returns>
        public static stt::Task<CompanionAgentsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CompanionAgentsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CompanionAgentsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CompanionAgentsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CompanionAgentsClient"/>.</returns>
        public static CompanionAgentsClient Create() => new CompanionAgentsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CompanionAgentsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CompanionAgentsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CompanionAgentsClient"/>.</returns>
        internal static CompanionAgentsClient Create(grpccore::CallInvoker callInvoker, CompanionAgentsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CompanionAgents.CompanionAgentsClient grpcClient = new CompanionAgents.CompanionAgentsClient(callInvoker);
            return new CompanionAgentsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CompanionAgents client</summary>
        public virtual CompanionAgents.CompanionAgentsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a companion agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CompanionAgent CreateCompanionAgent(CreateCompanionAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a companion agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompanionAgent> CreateCompanionAgentAsync(CreateCompanionAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a companion agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompanionAgent> CreateCompanionAgentAsync(CreateCompanionAgentRequest request, st::CancellationToken cancellationToken) =>
            CreateCompanionAgentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a companion agent.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource identifier of the project creating the companion agent.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="companionAgent">
        /// Required. The companion agent to create.
        /// </param>
        /// <param name="companionAgentId">
        /// Optional. The resource ID of the companion agent to create. If not
        /// provided, the server will auto-generate a resource ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CompanionAgent CreateCompanionAgent(string parent, CompanionAgent companionAgent, string companionAgentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCompanionAgent(new CreateCompanionAgentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CompanionAgent = gax::GaxPreconditions.CheckNotNull(companionAgent, nameof(companionAgent)),
                CompanionAgentId = companionAgentId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a companion agent.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource identifier of the project creating the companion agent.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="companionAgent">
        /// Required. The companion agent to create.
        /// </param>
        /// <param name="companionAgentId">
        /// Optional. The resource ID of the companion agent to create. If not
        /// provided, the server will auto-generate a resource ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompanionAgent> CreateCompanionAgentAsync(string parent, CompanionAgent companionAgent, string companionAgentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCompanionAgentAsync(new CreateCompanionAgentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CompanionAgent = gax::GaxPreconditions.CheckNotNull(companionAgent, nameof(companionAgent)),
                CompanionAgentId = companionAgentId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a companion agent.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource identifier of the project creating the companion agent.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="companionAgent">
        /// Required. The companion agent to create.
        /// </param>
        /// <param name="companionAgentId">
        /// Optional. The resource ID of the companion agent to create. If not
        /// provided, the server will auto-generate a resource ID.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompanionAgent> CreateCompanionAgentAsync(string parent, CompanionAgent companionAgent, string companionAgentId, st::CancellationToken cancellationToken) =>
            CreateCompanionAgentAsync(parent, companionAgent, companionAgentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a companion agent.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource identifier of the project creating the companion agent.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="companionAgent">
        /// Required. The companion agent to create.
        /// </param>
        /// <param name="companionAgentId">
        /// Optional. The resource ID of the companion agent to create. If not
        /// provided, the server will auto-generate a resource ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CompanionAgent CreateCompanionAgent(gagr::LocationName parent, CompanionAgent companionAgent, string companionAgentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCompanionAgent(new CreateCompanionAgentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CompanionAgent = gax::GaxPreconditions.CheckNotNull(companionAgent, nameof(companionAgent)),
                CompanionAgentId = companionAgentId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a companion agent.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource identifier of the project creating the companion agent.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="companionAgent">
        /// Required. The companion agent to create.
        /// </param>
        /// <param name="companionAgentId">
        /// Optional. The resource ID of the companion agent to create. If not
        /// provided, the server will auto-generate a resource ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompanionAgent> CreateCompanionAgentAsync(gagr::LocationName parent, CompanionAgent companionAgent, string companionAgentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCompanionAgentAsync(new CreateCompanionAgentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CompanionAgent = gax::GaxPreconditions.CheckNotNull(companionAgent, nameof(companionAgent)),
                CompanionAgentId = companionAgentId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a companion agent.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource identifier of the project creating the companion agent.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="companionAgent">
        /// Required. The companion agent to create.
        /// </param>
        /// <param name="companionAgentId">
        /// Optional. The resource ID of the companion agent to create. If not
        /// provided, the server will auto-generate a resource ID.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompanionAgent> CreateCompanionAgentAsync(gagr::LocationName parent, CompanionAgent companionAgent, string companionAgentId, st::CancellationToken cancellationToken) =>
            CreateCompanionAgentAsync(parent, companionAgent, companionAgentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a companion agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CompanionAgent GetCompanionAgent(GetCompanionAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a companion agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompanionAgent> GetCompanionAgentAsync(GetCompanionAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a companion agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompanionAgent> GetCompanionAgentAsync(GetCompanionAgentRequest request, st::CancellationToken cancellationToken) =>
            GetCompanionAgentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a companion agent.
        /// </summary>
        /// <param name="name">
        /// Required. The unique resource identifier of the CompanionAgent to get all
        /// information for. Format:
        /// `projects/{project}/locations/{location}/companionAgents/{companion_agent}`.
        /// Contains the information about the {project}, {location}, and
        /// {companion_agent}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CompanionAgent GetCompanionAgent(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCompanionAgent(new GetCompanionAgentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a companion agent.
        /// </summary>
        /// <param name="name">
        /// Required. The unique resource identifier of the CompanionAgent to get all
        /// information for. Format:
        /// `projects/{project}/locations/{location}/companionAgents/{companion_agent}`.
        /// Contains the information about the {project}, {location}, and
        /// {companion_agent}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompanionAgent> GetCompanionAgentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCompanionAgentAsync(new GetCompanionAgentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a companion agent.
        /// </summary>
        /// <param name="name">
        /// Required. The unique resource identifier of the CompanionAgent to get all
        /// information for. Format:
        /// `projects/{project}/locations/{location}/companionAgents/{companion_agent}`.
        /// Contains the information about the {project}, {location}, and
        /// {companion_agent}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompanionAgent> GetCompanionAgentAsync(string name, st::CancellationToken cancellationToken) =>
            GetCompanionAgentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a companion agent.
        /// </summary>
        /// <param name="name">
        /// Required. The unique resource identifier of the CompanionAgent to get all
        /// information for. Format:
        /// `projects/{project}/locations/{location}/companionAgents/{companion_agent}`.
        /// Contains the information about the {project}, {location}, and
        /// {companion_agent}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CompanionAgent GetCompanionAgent(CompanionAgentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCompanionAgent(new GetCompanionAgentRequest
            {
                CompanionAgentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a companion agent.
        /// </summary>
        /// <param name="name">
        /// Required. The unique resource identifier of the CompanionAgent to get all
        /// information for. Format:
        /// `projects/{project}/locations/{location}/companionAgents/{companion_agent}`.
        /// Contains the information about the {project}, {location}, and
        /// {companion_agent}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompanionAgent> GetCompanionAgentAsync(CompanionAgentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCompanionAgentAsync(new GetCompanionAgentRequest
            {
                CompanionAgentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a companion agent.
        /// </summary>
        /// <param name="name">
        /// Required. The unique resource identifier of the CompanionAgent to get all
        /// information for. Format:
        /// `projects/{project}/locations/{location}/companionAgents/{companion_agent}`.
        /// Contains the information about the {project}, {location}, and
        /// {companion_agent}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompanionAgent> GetCompanionAgentAsync(CompanionAgentName name, st::CancellationToken cancellationToken) =>
            GetCompanionAgentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a companion agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CompanionAgent UpdateCompanionAgent(UpdateCompanionAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a companion agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompanionAgent> UpdateCompanionAgentAsync(UpdateCompanionAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a companion agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompanionAgent> UpdateCompanionAgentAsync(UpdateCompanionAgentRequest request, st::CancellationToken cancellationToken) =>
            UpdateCompanionAgentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a companion agent.
        /// </summary>
        /// <param name="companionAgent">
        /// Required. The Companion Agent to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Update mask for Companion Agent.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CompanionAgent UpdateCompanionAgent(CompanionAgent companionAgent, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCompanionAgent(new UpdateCompanionAgentRequest
            {
                CompanionAgent = gax::GaxPreconditions.CheckNotNull(companionAgent, nameof(companionAgent)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a companion agent.
        /// </summary>
        /// <param name="companionAgent">
        /// Required. The Companion Agent to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Update mask for Companion Agent.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompanionAgent> UpdateCompanionAgentAsync(CompanionAgent companionAgent, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCompanionAgentAsync(new UpdateCompanionAgentRequest
            {
                CompanionAgent = gax::GaxPreconditions.CheckNotNull(companionAgent, nameof(companionAgent)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a companion agent.
        /// </summary>
        /// <param name="companionAgent">
        /// Required. The Companion Agent to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Update mask for Companion Agent.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompanionAgent> UpdateCompanionAgentAsync(CompanionAgent companionAgent, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCompanionAgentAsync(companionAgent, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a companion agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCompanionAgent(DeleteCompanionAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a companion agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCompanionAgentAsync(DeleteCompanionAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a companion agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCompanionAgentAsync(DeleteCompanionAgentRequest request, st::CancellationToken cancellationToken) =>
            DeleteCompanionAgentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a companion agent.
        /// </summary>
        /// <param name="name">
        /// Required. The unique resource identifier of the CompanionAgent to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/companionAgents/{companion_agent}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCompanionAgent(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCompanionAgent(new DeleteCompanionAgentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a companion agent.
        /// </summary>
        /// <param name="name">
        /// Required. The unique resource identifier of the CompanionAgent to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/companionAgents/{companion_agent}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCompanionAgentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCompanionAgentAsync(new DeleteCompanionAgentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a companion agent.
        /// </summary>
        /// <param name="name">
        /// Required. The unique resource identifier of the CompanionAgent to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/companionAgents/{companion_agent}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCompanionAgentAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteCompanionAgentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a companion agent.
        /// </summary>
        /// <param name="name">
        /// Required. The unique resource identifier of the CompanionAgent to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/companionAgents/{companion_agent}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCompanionAgent(CompanionAgentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCompanionAgent(new DeleteCompanionAgentRequest
            {
                CompanionAgentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a companion agent.
        /// </summary>
        /// <param name="name">
        /// Required. The unique resource identifier of the CompanionAgent to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/companionAgents/{companion_agent}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCompanionAgentAsync(CompanionAgentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCompanionAgentAsync(new DeleteCompanionAgentRequest
            {
                CompanionAgentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a companion agent.
        /// </summary>
        /// <param name="name">
        /// Required. The unique resource identifier of the CompanionAgent to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/companionAgents/{companion_agent}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCompanionAgentAsync(CompanionAgentName name, st::CancellationToken cancellationToken) =>
            DeleteCompanionAgentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists companion agents.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CompanionAgent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCompanionAgentsResponse, CompanionAgent> ListCompanionAgents(ListCompanionAgentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists companion agents.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CompanionAgent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCompanionAgentsResponse, CompanionAgent> ListCompanionAgentsAsync(ListCompanionAgentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists companion agents.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name to list the companion agents for.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="CompanionAgent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCompanionAgentsResponse, CompanionAgent> ListCompanionAgents(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCompanionAgentsRequest request = new ListCompanionAgentsRequest
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
            return ListCompanionAgents(request, callSettings);
        }

        /// <summary>
        /// Lists companion agents.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name to list the companion agents for.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="CompanionAgent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCompanionAgentsResponse, CompanionAgent> ListCompanionAgentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCompanionAgentsRequest request = new ListCompanionAgentsRequest
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
            return ListCompanionAgentsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists companion agents.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name to list the companion agents for.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="CompanionAgent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCompanionAgentsResponse, CompanionAgent> ListCompanionAgents(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCompanionAgentsRequest request = new ListCompanionAgentsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCompanionAgents(request, callSettings);
        }

        /// <summary>
        /// Lists companion agents.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name to list the companion agents for.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="CompanionAgent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCompanionAgentsResponse, CompanionAgent> ListCompanionAgentsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCompanionAgentsRequest request = new ListCompanionAgentsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCompanionAgentsAsync(request, callSettings);
        }
    }

    /// <summary>CompanionAgents client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing companion agents.
    /// </remarks>
    public sealed partial class CompanionAgentsClientImpl : CompanionAgentsClient
    {
        private readonly gaxgrpc::ApiCall<CreateCompanionAgentRequest, CompanionAgent> _callCreateCompanionAgent;

        private readonly gaxgrpc::ApiCall<GetCompanionAgentRequest, CompanionAgent> _callGetCompanionAgent;

        private readonly gaxgrpc::ApiCall<UpdateCompanionAgentRequest, CompanionAgent> _callUpdateCompanionAgent;

        private readonly gaxgrpc::ApiCall<DeleteCompanionAgentRequest, wkt::Empty> _callDeleteCompanionAgent;

        private readonly gaxgrpc::ApiCall<ListCompanionAgentsRequest, ListCompanionAgentsResponse> _callListCompanionAgents;

        /// <summary>
        /// Constructs a client wrapper for the CompanionAgents service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CompanionAgentsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CompanionAgentsClientImpl(CompanionAgents.CompanionAgentsClient grpcClient, CompanionAgentsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CompanionAgentsSettings effectiveSettings = settings ?? CompanionAgentsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreateCompanionAgent = clientHelper.BuildApiCall<CreateCompanionAgentRequest, CompanionAgent>("CreateCompanionAgent", grpcClient.CreateCompanionAgentAsync, grpcClient.CreateCompanionAgent, effectiveSettings.CreateCompanionAgentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCompanionAgent);
            Modify_CreateCompanionAgentApiCall(ref _callCreateCompanionAgent);
            _callGetCompanionAgent = clientHelper.BuildApiCall<GetCompanionAgentRequest, CompanionAgent>("GetCompanionAgent", grpcClient.GetCompanionAgentAsync, grpcClient.GetCompanionAgent, effectiveSettings.GetCompanionAgentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCompanionAgent);
            Modify_GetCompanionAgentApiCall(ref _callGetCompanionAgent);
            _callUpdateCompanionAgent = clientHelper.BuildApiCall<UpdateCompanionAgentRequest, CompanionAgent>("UpdateCompanionAgent", grpcClient.UpdateCompanionAgentAsync, grpcClient.UpdateCompanionAgent, effectiveSettings.UpdateCompanionAgentSettings).WithGoogleRequestParam("companion_agent.name", request => request.CompanionAgent?.Name);
            Modify_ApiCall(ref _callUpdateCompanionAgent);
            Modify_UpdateCompanionAgentApiCall(ref _callUpdateCompanionAgent);
            _callDeleteCompanionAgent = clientHelper.BuildApiCall<DeleteCompanionAgentRequest, wkt::Empty>("DeleteCompanionAgent", grpcClient.DeleteCompanionAgentAsync, grpcClient.DeleteCompanionAgent, effectiveSettings.DeleteCompanionAgentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteCompanionAgent);
            Modify_DeleteCompanionAgentApiCall(ref _callDeleteCompanionAgent);
            _callListCompanionAgents = clientHelper.BuildApiCall<ListCompanionAgentsRequest, ListCompanionAgentsResponse>("ListCompanionAgents", grpcClient.ListCompanionAgentsAsync, grpcClient.ListCompanionAgents, effectiveSettings.ListCompanionAgentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCompanionAgents);
            Modify_ListCompanionAgentsApiCall(ref _callListCompanionAgents);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateCompanionAgentApiCall(ref gaxgrpc::ApiCall<CreateCompanionAgentRequest, CompanionAgent> call);

        partial void Modify_GetCompanionAgentApiCall(ref gaxgrpc::ApiCall<GetCompanionAgentRequest, CompanionAgent> call);

        partial void Modify_UpdateCompanionAgentApiCall(ref gaxgrpc::ApiCall<UpdateCompanionAgentRequest, CompanionAgent> call);

        partial void Modify_DeleteCompanionAgentApiCall(ref gaxgrpc::ApiCall<DeleteCompanionAgentRequest, wkt::Empty> call);

        partial void Modify_ListCompanionAgentsApiCall(ref gaxgrpc::ApiCall<ListCompanionAgentsRequest, ListCompanionAgentsResponse> call);

        partial void OnConstruction(CompanionAgents.CompanionAgentsClient grpcClient, CompanionAgentsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CompanionAgents client</summary>
        public override CompanionAgents.CompanionAgentsClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreateCompanionAgentRequest(ref CreateCompanionAgentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCompanionAgentRequest(ref GetCompanionAgentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCompanionAgentRequest(ref UpdateCompanionAgentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteCompanionAgentRequest(ref DeleteCompanionAgentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCompanionAgentsRequest(ref ListCompanionAgentsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a companion agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CompanionAgent CreateCompanionAgent(CreateCompanionAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCompanionAgentRequest(ref request, ref callSettings);
            return _callCreateCompanionAgent.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a companion agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CompanionAgent> CreateCompanionAgentAsync(CreateCompanionAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCompanionAgentRequest(ref request, ref callSettings);
            return _callCreateCompanionAgent.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a companion agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CompanionAgent GetCompanionAgent(GetCompanionAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCompanionAgentRequest(ref request, ref callSettings);
            return _callGetCompanionAgent.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a companion agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CompanionAgent> GetCompanionAgentAsync(GetCompanionAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCompanionAgentRequest(ref request, ref callSettings);
            return _callGetCompanionAgent.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a companion agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CompanionAgent UpdateCompanionAgent(UpdateCompanionAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCompanionAgentRequest(ref request, ref callSettings);
            return _callUpdateCompanionAgent.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a companion agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CompanionAgent> UpdateCompanionAgentAsync(UpdateCompanionAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCompanionAgentRequest(ref request, ref callSettings);
            return _callUpdateCompanionAgent.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a companion agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteCompanionAgent(DeleteCompanionAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCompanionAgentRequest(ref request, ref callSettings);
            _callDeleteCompanionAgent.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a companion agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteCompanionAgentAsync(DeleteCompanionAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCompanionAgentRequest(ref request, ref callSettings);
            return _callDeleteCompanionAgent.Async(request, callSettings);
        }

        /// <summary>
        /// Lists companion agents.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CompanionAgent"/> resources.</returns>
        public override gax::PagedEnumerable<ListCompanionAgentsResponse, CompanionAgent> ListCompanionAgents(ListCompanionAgentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCompanionAgentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCompanionAgentsRequest, ListCompanionAgentsResponse, CompanionAgent>(_callListCompanionAgents, request, callSettings);
        }

        /// <summary>
        /// Lists companion agents.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CompanionAgent"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCompanionAgentsResponse, CompanionAgent> ListCompanionAgentsAsync(ListCompanionAgentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCompanionAgentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCompanionAgentsRequest, ListCompanionAgentsResponse, CompanionAgent>(_callListCompanionAgents, request, callSettings);
        }
    }

    public partial class ListCompanionAgentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCompanionAgentsResponse : gaxgrpc::IPageResponse<CompanionAgent>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CompanionAgent> GetEnumerator() => CompanionAgents.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class CompanionAgents
    {
        public partial class CompanionAgentsClient
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
