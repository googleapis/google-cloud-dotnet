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
using gciv = Google.Cloud.Iam.V1;
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

namespace Google.Cloud.NetworkServices.V1Beta1
{
    /// <summary>Settings for <see cref="NetworkServicesClient"/> instances.</summary>
    public sealed partial class NetworkServicesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="NetworkServicesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="NetworkServicesSettings"/>.</returns>
        public static NetworkServicesSettings GetDefault() => new NetworkServicesSettings();

        /// <summary>Constructs a new <see cref="NetworkServicesSettings"/> object with default settings.</summary>
        public NetworkServicesSettings()
        {
        }

        private NetworkServicesSettings(NetworkServicesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListEndpointPoliciesSettings = existing.ListEndpointPoliciesSettings;
            GetEndpointPolicySettings = existing.GetEndpointPolicySettings;
            CreateEndpointPolicySettings = existing.CreateEndpointPolicySettings;
            CreateEndpointPolicyOperationsSettings = existing.CreateEndpointPolicyOperationsSettings.Clone();
            UpdateEndpointPolicySettings = existing.UpdateEndpointPolicySettings;
            UpdateEndpointPolicyOperationsSettings = existing.UpdateEndpointPolicyOperationsSettings.Clone();
            DeleteEndpointPolicySettings = existing.DeleteEndpointPolicySettings;
            DeleteEndpointPolicyOperationsSettings = existing.DeleteEndpointPolicyOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(NetworkServicesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.ListEndpointPolicies</c> and <c>NetworkServicesClient.ListEndpointPoliciesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEndpointPoliciesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.GetEndpointPolicy</c> and <c>NetworkServicesClient.GetEndpointPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEndpointPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.CreateEndpointPolicy</c> and <c>NetworkServicesClient.CreateEndpointPolicyAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateEndpointPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkServicesClient.CreateEndpointPolicy</c> and
        /// <c>NetworkServicesClient.CreateEndpointPolicyAsync</c>.
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
        public lro::OperationsSettings CreateEndpointPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.UpdateEndpointPolicy</c> and <c>NetworkServicesClient.UpdateEndpointPolicyAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateEndpointPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkServicesClient.UpdateEndpointPolicy</c> and
        /// <c>NetworkServicesClient.UpdateEndpointPolicyAsync</c>.
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
        public lro::OperationsSettings UpdateEndpointPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServicesClient.DeleteEndpointPolicy</c> and <c>NetworkServicesClient.DeleteEndpointPolicyAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteEndpointPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetworkServicesClient.DeleteEndpointPolicy</c> and
        /// <c>NetworkServicesClient.DeleteEndpointPolicyAsync</c>.
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
        public lro::OperationsSettings DeleteEndpointPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="NetworkServicesSettings"/> object.</returns>
        public NetworkServicesSettings Clone() => new NetworkServicesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="NetworkServicesClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class NetworkServicesClientBuilder : gaxgrpc::ClientBuilderBase<NetworkServicesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public NetworkServicesSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public NetworkServicesClientBuilder() : base(NetworkServicesClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref NetworkServicesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<NetworkServicesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override NetworkServicesClient Build()
        {
            NetworkServicesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<NetworkServicesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<NetworkServicesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private NetworkServicesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return NetworkServicesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<NetworkServicesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return NetworkServicesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => NetworkServicesClient.ChannelPool;
    }

    /// <summary>NetworkServices client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources.
    /// </remarks>
    public abstract partial class NetworkServicesClient
    {
        /// <summary>
        /// The default endpoint for the NetworkServices service, which is a host of "networkservices.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "networkservices.googleapis.com:443";

        /// <summary>The default NetworkServices scopes.</summary>
        /// <remarks>
        /// The default NetworkServices scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(NetworkServices.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="NetworkServicesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="NetworkServicesClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="NetworkServicesClient"/>.</returns>
        public static stt::Task<NetworkServicesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new NetworkServicesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="NetworkServicesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="NetworkServicesClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="NetworkServicesClient"/>.</returns>
        public static NetworkServicesClient Create() => new NetworkServicesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="NetworkServicesClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="NetworkServicesSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="NetworkServicesClient"/>.</returns>
        internal static NetworkServicesClient Create(grpccore::CallInvoker callInvoker, NetworkServicesSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            NetworkServices.NetworkServicesClient grpcClient = new NetworkServices.NetworkServicesClient(callInvoker);
            return new NetworkServicesClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC NetworkServices client</summary>
        public virtual NetworkServices.NetworkServicesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists EndpointPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EndpointPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEndpointPoliciesResponse, EndpointPolicy> ListEndpointPolicies(ListEndpointPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists EndpointPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EndpointPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEndpointPoliciesResponse, EndpointPolicy> ListEndpointPoliciesAsync(ListEndpointPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists EndpointPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the EndpointPolicies should
        /// be listed, specified in the format `projects/*/locations/global`.
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
        /// <returns>A pageable sequence of <see cref="EndpointPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEndpointPoliciesResponse, EndpointPolicy> ListEndpointPolicies(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEndpointPoliciesRequest request = new ListEndpointPoliciesRequest
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
            return ListEndpointPolicies(request, callSettings);
        }

        /// <summary>
        /// Lists EndpointPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the EndpointPolicies should
        /// be listed, specified in the format `projects/*/locations/global`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="EndpointPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEndpointPoliciesResponse, EndpointPolicy> ListEndpointPoliciesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEndpointPoliciesRequest request = new ListEndpointPoliciesRequest
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
            return ListEndpointPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists EndpointPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the EndpointPolicies should
        /// be listed, specified in the format `projects/*/locations/global`.
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
        /// <returns>A pageable sequence of <see cref="EndpointPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEndpointPoliciesResponse, EndpointPolicy> ListEndpointPolicies(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEndpointPoliciesRequest request = new ListEndpointPoliciesRequest
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
            return ListEndpointPolicies(request, callSettings);
        }

        /// <summary>
        /// Lists EndpointPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the EndpointPolicies should
        /// be listed, specified in the format `projects/*/locations/global`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="EndpointPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEndpointPoliciesResponse, EndpointPolicy> ListEndpointPoliciesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEndpointPoliciesRequest request = new ListEndpointPoliciesRequest
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
            return ListEndpointPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single EndpointPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EndpointPolicy GetEndpointPolicy(GetEndpointPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single EndpointPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EndpointPolicy> GetEndpointPolicyAsync(GetEndpointPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single EndpointPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EndpointPolicy> GetEndpointPolicyAsync(GetEndpointPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetEndpointPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single EndpointPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the EndpointPolicy to get. Must be in the format
        /// `projects/*/locations/global/endpointPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EndpointPolicy GetEndpointPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEndpointPolicy(new GetEndpointPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single EndpointPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the EndpointPolicy to get. Must be in the format
        /// `projects/*/locations/global/endpointPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EndpointPolicy> GetEndpointPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEndpointPolicyAsync(new GetEndpointPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single EndpointPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the EndpointPolicy to get. Must be in the format
        /// `projects/*/locations/global/endpointPolicies/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EndpointPolicy> GetEndpointPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            GetEndpointPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single EndpointPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the EndpointPolicy to get. Must be in the format
        /// `projects/*/locations/global/endpointPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EndpointPolicy GetEndpointPolicy(EndpointPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEndpointPolicy(new GetEndpointPolicyRequest
            {
                EndpointPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single EndpointPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the EndpointPolicy to get. Must be in the format
        /// `projects/*/locations/global/endpointPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EndpointPolicy> GetEndpointPolicyAsync(EndpointPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEndpointPolicyAsync(new GetEndpointPolicyRequest
            {
                EndpointPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single EndpointPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the EndpointPolicy to get. Must be in the format
        /// `projects/*/locations/global/endpointPolicies/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EndpointPolicy> GetEndpointPolicyAsync(EndpointPolicyName name, st::CancellationToken cancellationToken) =>
            GetEndpointPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new EndpointPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EndpointPolicy, OperationMetadata> CreateEndpointPolicy(CreateEndpointPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new EndpointPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EndpointPolicy, OperationMetadata>> CreateEndpointPolicyAsync(CreateEndpointPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new EndpointPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EndpointPolicy, OperationMetadata>> CreateEndpointPolicyAsync(CreateEndpointPolicyRequest request, st::CancellationToken cancellationToken) =>
            CreateEndpointPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateEndpointPolicy</c>.</summary>
        public virtual lro::OperationsClient CreateEndpointPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateEndpointPolicy</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<EndpointPolicy, OperationMetadata> PollOnceCreateEndpointPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EndpointPolicy, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEndpointPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateEndpointPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<EndpointPolicy, OperationMetadata>> PollOnceCreateEndpointPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EndpointPolicy, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEndpointPolicyOperationsClient, callSettings);

        /// <summary>
        /// Creates a new EndpointPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the EndpointPolicy. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="endpointPolicy">
        /// Required. EndpointPolicy resource to be created.
        /// </param>
        /// <param name="endpointPolicyId">
        /// Required. Short name of the EndpointPolicy resource to be created.
        /// E.g. "CustomECS".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EndpointPolicy, OperationMetadata> CreateEndpointPolicy(string parent, EndpointPolicy endpointPolicy, string endpointPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEndpointPolicy(new CreateEndpointPolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EndpointPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(endpointPolicyId, nameof(endpointPolicyId)),
                EndpointPolicy = gax::GaxPreconditions.CheckNotNull(endpointPolicy, nameof(endpointPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new EndpointPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the EndpointPolicy. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="endpointPolicy">
        /// Required. EndpointPolicy resource to be created.
        /// </param>
        /// <param name="endpointPolicyId">
        /// Required. Short name of the EndpointPolicy resource to be created.
        /// E.g. "CustomECS".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EndpointPolicy, OperationMetadata>> CreateEndpointPolicyAsync(string parent, EndpointPolicy endpointPolicy, string endpointPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEndpointPolicyAsync(new CreateEndpointPolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EndpointPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(endpointPolicyId, nameof(endpointPolicyId)),
                EndpointPolicy = gax::GaxPreconditions.CheckNotNull(endpointPolicy, nameof(endpointPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new EndpointPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the EndpointPolicy. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="endpointPolicy">
        /// Required. EndpointPolicy resource to be created.
        /// </param>
        /// <param name="endpointPolicyId">
        /// Required. Short name of the EndpointPolicy resource to be created.
        /// E.g. "CustomECS".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EndpointPolicy, OperationMetadata>> CreateEndpointPolicyAsync(string parent, EndpointPolicy endpointPolicy, string endpointPolicyId, st::CancellationToken cancellationToken) =>
            CreateEndpointPolicyAsync(parent, endpointPolicy, endpointPolicyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new EndpointPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the EndpointPolicy. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="endpointPolicy">
        /// Required. EndpointPolicy resource to be created.
        /// </param>
        /// <param name="endpointPolicyId">
        /// Required. Short name of the EndpointPolicy resource to be created.
        /// E.g. "CustomECS".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EndpointPolicy, OperationMetadata> CreateEndpointPolicy(gagr::LocationName parent, EndpointPolicy endpointPolicy, string endpointPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEndpointPolicy(new CreateEndpointPolicyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EndpointPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(endpointPolicyId, nameof(endpointPolicyId)),
                EndpointPolicy = gax::GaxPreconditions.CheckNotNull(endpointPolicy, nameof(endpointPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new EndpointPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the EndpointPolicy. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="endpointPolicy">
        /// Required. EndpointPolicy resource to be created.
        /// </param>
        /// <param name="endpointPolicyId">
        /// Required. Short name of the EndpointPolicy resource to be created.
        /// E.g. "CustomECS".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EndpointPolicy, OperationMetadata>> CreateEndpointPolicyAsync(gagr::LocationName parent, EndpointPolicy endpointPolicy, string endpointPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEndpointPolicyAsync(new CreateEndpointPolicyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EndpointPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(endpointPolicyId, nameof(endpointPolicyId)),
                EndpointPolicy = gax::GaxPreconditions.CheckNotNull(endpointPolicy, nameof(endpointPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new EndpointPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the EndpointPolicy. Must be in the
        /// format `projects/*/locations/global`.
        /// </param>
        /// <param name="endpointPolicy">
        /// Required. EndpointPolicy resource to be created.
        /// </param>
        /// <param name="endpointPolicyId">
        /// Required. Short name of the EndpointPolicy resource to be created.
        /// E.g. "CustomECS".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EndpointPolicy, OperationMetadata>> CreateEndpointPolicyAsync(gagr::LocationName parent, EndpointPolicy endpointPolicy, string endpointPolicyId, st::CancellationToken cancellationToken) =>
            CreateEndpointPolicyAsync(parent, endpointPolicy, endpointPolicyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single EndpointPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EndpointPolicy, OperationMetadata> UpdateEndpointPolicy(UpdateEndpointPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single EndpointPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EndpointPolicy, OperationMetadata>> UpdateEndpointPolicyAsync(UpdateEndpointPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single EndpointPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EndpointPolicy, OperationMetadata>> UpdateEndpointPolicyAsync(UpdateEndpointPolicyRequest request, st::CancellationToken cancellationToken) =>
            UpdateEndpointPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateEndpointPolicy</c>.</summary>
        public virtual lro::OperationsClient UpdateEndpointPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateEndpointPolicy</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<EndpointPolicy, OperationMetadata> PollOnceUpdateEndpointPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EndpointPolicy, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateEndpointPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateEndpointPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<EndpointPolicy, OperationMetadata>> PollOnceUpdateEndpointPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EndpointPolicy, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateEndpointPolicyOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single EndpointPolicy.
        /// </summary>
        /// <param name="endpointPolicy">
        /// Required. Updated EndpointPolicy resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// EndpointPolicy resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EndpointPolicy, OperationMetadata> UpdateEndpointPolicy(EndpointPolicy endpointPolicy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEndpointPolicy(new UpdateEndpointPolicyRequest
            {
                UpdateMask = updateMask,
                EndpointPolicy = gax::GaxPreconditions.CheckNotNull(endpointPolicy, nameof(endpointPolicy)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single EndpointPolicy.
        /// </summary>
        /// <param name="endpointPolicy">
        /// Required. Updated EndpointPolicy resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// EndpointPolicy resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EndpointPolicy, OperationMetadata>> UpdateEndpointPolicyAsync(EndpointPolicy endpointPolicy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEndpointPolicyAsync(new UpdateEndpointPolicyRequest
            {
                UpdateMask = updateMask,
                EndpointPolicy = gax::GaxPreconditions.CheckNotNull(endpointPolicy, nameof(endpointPolicy)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single EndpointPolicy.
        /// </summary>
        /// <param name="endpointPolicy">
        /// Required. Updated EndpointPolicy resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// EndpointPolicy resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EndpointPolicy, OperationMetadata>> UpdateEndpointPolicyAsync(EndpointPolicy endpointPolicy, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateEndpointPolicyAsync(endpointPolicy, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single EndpointPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteEndpointPolicy(DeleteEndpointPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single EndpointPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEndpointPolicyAsync(DeleteEndpointPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single EndpointPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEndpointPolicyAsync(DeleteEndpointPolicyRequest request, st::CancellationToken cancellationToken) =>
            DeleteEndpointPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteEndpointPolicy</c>.</summary>
        public virtual lro::OperationsClient DeleteEndpointPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteEndpointPolicy</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteEndpointPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteEndpointPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteEndpointPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteEndpointPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteEndpointPolicyOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single EndpointPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the EndpointPolicy to delete. Must be in the format
        /// `projects/*/locations/global/endpointPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteEndpointPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEndpointPolicy(new DeleteEndpointPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single EndpointPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the EndpointPolicy to delete. Must be in the format
        /// `projects/*/locations/global/endpointPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEndpointPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEndpointPolicyAsync(new DeleteEndpointPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single EndpointPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the EndpointPolicy to delete. Must be in the format
        /// `projects/*/locations/global/endpointPolicies/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEndpointPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteEndpointPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single EndpointPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the EndpointPolicy to delete. Must be in the format
        /// `projects/*/locations/global/endpointPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteEndpointPolicy(EndpointPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEndpointPolicy(new DeleteEndpointPolicyRequest
            {
                EndpointPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single EndpointPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the EndpointPolicy to delete. Must be in the format
        /// `projects/*/locations/global/endpointPolicies/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEndpointPolicyAsync(EndpointPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEndpointPolicyAsync(new DeleteEndpointPolicyRequest
            {
                EndpointPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single EndpointPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the EndpointPolicy to delete. Must be in the format
        /// `projects/*/locations/global/endpointPolicies/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEndpointPolicyAsync(EndpointPolicyName name, st::CancellationToken cancellationToken) =>
            DeleteEndpointPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>NetworkServices client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources.
    /// </remarks>
    public sealed partial class NetworkServicesClientImpl : NetworkServicesClient
    {
        private readonly gaxgrpc::ApiCall<ListEndpointPoliciesRequest, ListEndpointPoliciesResponse> _callListEndpointPolicies;

        private readonly gaxgrpc::ApiCall<GetEndpointPolicyRequest, EndpointPolicy> _callGetEndpointPolicy;

        private readonly gaxgrpc::ApiCall<CreateEndpointPolicyRequest, lro::Operation> _callCreateEndpointPolicy;

        private readonly gaxgrpc::ApiCall<UpdateEndpointPolicyRequest, lro::Operation> _callUpdateEndpointPolicy;

        private readonly gaxgrpc::ApiCall<DeleteEndpointPolicyRequest, lro::Operation> _callDeleteEndpointPolicy;

        /// <summary>
        /// Constructs a client wrapper for the NetworkServices service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="NetworkServicesSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public NetworkServicesClientImpl(NetworkServices.NetworkServicesClient grpcClient, NetworkServicesSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            NetworkServicesSettings effectiveSettings = settings ?? NetworkServicesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateEndpointPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateEndpointPolicyOperationsSettings, logger);
            UpdateEndpointPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateEndpointPolicyOperationsSettings, logger);
            DeleteEndpointPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteEndpointPolicyOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListEndpointPolicies = clientHelper.BuildApiCall<ListEndpointPoliciesRequest, ListEndpointPoliciesResponse>("ListEndpointPolicies", grpcClient.ListEndpointPoliciesAsync, grpcClient.ListEndpointPolicies, effectiveSettings.ListEndpointPoliciesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEndpointPolicies);
            Modify_ListEndpointPoliciesApiCall(ref _callListEndpointPolicies);
            _callGetEndpointPolicy = clientHelper.BuildApiCall<GetEndpointPolicyRequest, EndpointPolicy>("GetEndpointPolicy", grpcClient.GetEndpointPolicyAsync, grpcClient.GetEndpointPolicy, effectiveSettings.GetEndpointPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEndpointPolicy);
            Modify_GetEndpointPolicyApiCall(ref _callGetEndpointPolicy);
            _callCreateEndpointPolicy = clientHelper.BuildApiCall<CreateEndpointPolicyRequest, lro::Operation>("CreateEndpointPolicy", grpcClient.CreateEndpointPolicyAsync, grpcClient.CreateEndpointPolicy, effectiveSettings.CreateEndpointPolicySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateEndpointPolicy);
            Modify_CreateEndpointPolicyApiCall(ref _callCreateEndpointPolicy);
            _callUpdateEndpointPolicy = clientHelper.BuildApiCall<UpdateEndpointPolicyRequest, lro::Operation>("UpdateEndpointPolicy", grpcClient.UpdateEndpointPolicyAsync, grpcClient.UpdateEndpointPolicy, effectiveSettings.UpdateEndpointPolicySettings).WithGoogleRequestParam("endpoint_policy.name", request => request.EndpointPolicy?.Name);
            Modify_ApiCall(ref _callUpdateEndpointPolicy);
            Modify_UpdateEndpointPolicyApiCall(ref _callUpdateEndpointPolicy);
            _callDeleteEndpointPolicy = clientHelper.BuildApiCall<DeleteEndpointPolicyRequest, lro::Operation>("DeleteEndpointPolicy", grpcClient.DeleteEndpointPolicyAsync, grpcClient.DeleteEndpointPolicy, effectiveSettings.DeleteEndpointPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteEndpointPolicy);
            Modify_DeleteEndpointPolicyApiCall(ref _callDeleteEndpointPolicy);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListEndpointPoliciesApiCall(ref gaxgrpc::ApiCall<ListEndpointPoliciesRequest, ListEndpointPoliciesResponse> call);

        partial void Modify_GetEndpointPolicyApiCall(ref gaxgrpc::ApiCall<GetEndpointPolicyRequest, EndpointPolicy> call);

        partial void Modify_CreateEndpointPolicyApiCall(ref gaxgrpc::ApiCall<CreateEndpointPolicyRequest, lro::Operation> call);

        partial void Modify_UpdateEndpointPolicyApiCall(ref gaxgrpc::ApiCall<UpdateEndpointPolicyRequest, lro::Operation> call);

        partial void Modify_DeleteEndpointPolicyApiCall(ref gaxgrpc::ApiCall<DeleteEndpointPolicyRequest, lro::Operation> call);

        partial void OnConstruction(NetworkServices.NetworkServicesClient grpcClient, NetworkServicesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC NetworkServices client</summary>
        public override NetworkServices.NetworkServicesClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListEndpointPoliciesRequest(ref ListEndpointPoliciesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEndpointPolicyRequest(ref GetEndpointPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateEndpointPolicyRequest(ref CreateEndpointPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateEndpointPolicyRequest(ref UpdateEndpointPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteEndpointPolicyRequest(ref DeleteEndpointPolicyRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists EndpointPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EndpointPolicy"/> resources.</returns>
        public override gax::PagedEnumerable<ListEndpointPoliciesResponse, EndpointPolicy> ListEndpointPolicies(ListEndpointPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEndpointPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEndpointPoliciesRequest, ListEndpointPoliciesResponse, EndpointPolicy>(_callListEndpointPolicies, request, callSettings);
        }

        /// <summary>
        /// Lists EndpointPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EndpointPolicy"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEndpointPoliciesResponse, EndpointPolicy> ListEndpointPoliciesAsync(ListEndpointPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEndpointPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEndpointPoliciesRequest, ListEndpointPoliciesResponse, EndpointPolicy>(_callListEndpointPolicies, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single EndpointPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EndpointPolicy GetEndpointPolicy(GetEndpointPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEndpointPolicyRequest(ref request, ref callSettings);
            return _callGetEndpointPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single EndpointPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EndpointPolicy> GetEndpointPolicyAsync(GetEndpointPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEndpointPolicyRequest(ref request, ref callSettings);
            return _callGetEndpointPolicy.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateEndpointPolicy</c>.</summary>
        public override lro::OperationsClient CreateEndpointPolicyOperationsClient { get; }

        /// <summary>
        /// Creates a new EndpointPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<EndpointPolicy, OperationMetadata> CreateEndpointPolicy(CreateEndpointPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEndpointPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<EndpointPolicy, OperationMetadata>(_callCreateEndpointPolicy.Sync(request, callSettings), CreateEndpointPolicyOperationsClient);
        }

        /// <summary>
        /// Creates a new EndpointPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<EndpointPolicy, OperationMetadata>> CreateEndpointPolicyAsync(CreateEndpointPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEndpointPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<EndpointPolicy, OperationMetadata>(await _callCreateEndpointPolicy.Async(request, callSettings).ConfigureAwait(false), CreateEndpointPolicyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateEndpointPolicy</c>.</summary>
        public override lro::OperationsClient UpdateEndpointPolicyOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single EndpointPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<EndpointPolicy, OperationMetadata> UpdateEndpointPolicy(UpdateEndpointPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEndpointPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<EndpointPolicy, OperationMetadata>(_callUpdateEndpointPolicy.Sync(request, callSettings), UpdateEndpointPolicyOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single EndpointPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<EndpointPolicy, OperationMetadata>> UpdateEndpointPolicyAsync(UpdateEndpointPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEndpointPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<EndpointPolicy, OperationMetadata>(await _callUpdateEndpointPolicy.Async(request, callSettings).ConfigureAwait(false), UpdateEndpointPolicyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteEndpointPolicy</c>.</summary>
        public override lro::OperationsClient DeleteEndpointPolicyOperationsClient { get; }

        /// <summary>
        /// Deletes a single EndpointPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteEndpointPolicy(DeleteEndpointPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEndpointPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteEndpointPolicy.Sync(request, callSettings), DeleteEndpointPolicyOperationsClient);
        }

        /// <summary>
        /// Deletes a single EndpointPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEndpointPolicyAsync(DeleteEndpointPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEndpointPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteEndpointPolicy.Async(request, callSettings).ConfigureAwait(false), DeleteEndpointPolicyOperationsClient);
        }
    }

    public partial class ListEndpointPoliciesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEndpointPoliciesResponse : gaxgrpc::IPageResponse<EndpointPolicy>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<EndpointPolicy> GetEnumerator() => EndpointPolicies.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class NetworkServices
    {
        public partial class NetworkServicesClient
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

    public static partial class NetworkServices
    {
        public partial class NetworkServicesClient
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
