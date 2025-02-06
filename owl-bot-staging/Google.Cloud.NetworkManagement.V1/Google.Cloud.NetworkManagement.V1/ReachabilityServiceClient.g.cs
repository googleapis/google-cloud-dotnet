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

namespace Google.Cloud.NetworkManagement.V1
{
    /// <summary>Settings for <see cref="ReachabilityServiceClient"/> instances.</summary>
    public sealed partial class ReachabilityServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ReachabilityServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ReachabilityServiceSettings"/>.</returns>
        public static ReachabilityServiceSettings GetDefault() => new ReachabilityServiceSettings();

        /// <summary>Constructs a new <see cref="ReachabilityServiceSettings"/> object with default settings.</summary>
        public ReachabilityServiceSettings()
        {
        }

        private ReachabilityServiceSettings(ReachabilityServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListConnectivityTestsSettings = existing.ListConnectivityTestsSettings;
            GetConnectivityTestSettings = existing.GetConnectivityTestSettings;
            CreateConnectivityTestSettings = existing.CreateConnectivityTestSettings;
            CreateConnectivityTestOperationsSettings = existing.CreateConnectivityTestOperationsSettings.Clone();
            UpdateConnectivityTestSettings = existing.UpdateConnectivityTestSettings;
            UpdateConnectivityTestOperationsSettings = existing.UpdateConnectivityTestOperationsSettings.Clone();
            RerunConnectivityTestSettings = existing.RerunConnectivityTestSettings;
            RerunConnectivityTestOperationsSettings = existing.RerunConnectivityTestOperationsSettings.Clone();
            DeleteConnectivityTestSettings = existing.DeleteConnectivityTestSettings;
            DeleteConnectivityTestOperationsSettings = existing.DeleteConnectivityTestOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(ReachabilityServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReachabilityServiceClient.ListConnectivityTests</c> and
        /// <c>ReachabilityServiceClient.ListConnectivityTestsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListConnectivityTestsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReachabilityServiceClient.GetConnectivityTest</c> and
        /// <c>ReachabilityServiceClient.GetConnectivityTestAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetConnectivityTestSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReachabilityServiceClient.CreateConnectivityTest</c> and
        /// <c>ReachabilityServiceClient.CreateConnectivityTestAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateConnectivityTestSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ReachabilityServiceClient.CreateConnectivityTest</c> and
        /// <c>ReachabilityServiceClient.CreateConnectivityTestAsync</c>.
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
        public lro::OperationsSettings CreateConnectivityTestOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReachabilityServiceClient.UpdateConnectivityTest</c> and
        /// <c>ReachabilityServiceClient.UpdateConnectivityTestAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateConnectivityTestSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ReachabilityServiceClient.UpdateConnectivityTest</c> and
        /// <c>ReachabilityServiceClient.UpdateConnectivityTestAsync</c>.
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
        public lro::OperationsSettings UpdateConnectivityTestOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReachabilityServiceClient.RerunConnectivityTest</c> and
        /// <c>ReachabilityServiceClient.RerunConnectivityTestAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RerunConnectivityTestSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ReachabilityServiceClient.RerunConnectivityTest</c> and
        /// <c>ReachabilityServiceClient.RerunConnectivityTestAsync</c>.
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
        public lro::OperationsSettings RerunConnectivityTestOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReachabilityServiceClient.DeleteConnectivityTest</c> and
        /// <c>ReachabilityServiceClient.DeleteConnectivityTestAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteConnectivityTestSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ReachabilityServiceClient.DeleteConnectivityTest</c> and
        /// <c>ReachabilityServiceClient.DeleteConnectivityTestAsync</c>.
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
        public lro::OperationsSettings DeleteConnectivityTestOperationsSettings { get; set; } = new lro::OperationsSettings
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
        /// <returns>A deep clone of this <see cref="ReachabilityServiceSettings"/> object.</returns>
        public ReachabilityServiceSettings Clone() => new ReachabilityServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ReachabilityServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ReachabilityServiceClientBuilder : gaxgrpc::ClientBuilderBase<ReachabilityServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ReachabilityServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ReachabilityServiceClientBuilder() : base(ReachabilityServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ReachabilityServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ReachabilityServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ReachabilityServiceClient Build()
        {
            ReachabilityServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ReachabilityServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ReachabilityServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ReachabilityServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ReachabilityServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ReachabilityServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ReachabilityServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ReachabilityServiceClient.ChannelPool;
    }

    /// <summary>ReachabilityService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The Reachability service in the Google Cloud Network Management API provides
    /// services that analyze the reachability within a single Google Virtual Private
    /// Cloud (VPC) network, between peered VPC networks, between VPC and on-premises
    /// networks, or between VPC networks and internet hosts. A reachability analysis
    /// is based on Google Cloud network configurations.
    /// 
    /// You can use the analysis results to verify these configurations and
    /// to troubleshoot connectivity issues.
    /// </remarks>
    public abstract partial class ReachabilityServiceClient
    {
        /// <summary>
        /// The default endpoint for the ReachabilityService service, which is a host of
        /// "networkmanagement.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "networkmanagement.googleapis.com:443";

        /// <summary>The default ReachabilityService scopes.</summary>
        /// <remarks>
        /// The default ReachabilityService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ReachabilityService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ReachabilityServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="ReachabilityServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ReachabilityServiceClient"/>.</returns>
        public static stt::Task<ReachabilityServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ReachabilityServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ReachabilityServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="ReachabilityServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ReachabilityServiceClient"/>.</returns>
        public static ReachabilityServiceClient Create() => new ReachabilityServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ReachabilityServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ReachabilityServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ReachabilityServiceClient"/>.</returns>
        internal static ReachabilityServiceClient Create(grpccore::CallInvoker callInvoker, ReachabilityServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ReachabilityService.ReachabilityServiceClient grpcClient = new ReachabilityService.ReachabilityServiceClient(callInvoker);
            return new ReachabilityServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ReachabilityService client</summary>
        public virtual ReachabilityService.ReachabilityServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all Connectivity Tests owned by a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ConnectivityTest"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConnectivityTestsResponse, ConnectivityTest> ListConnectivityTests(ListConnectivityTestsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all Connectivity Tests owned by a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ConnectivityTest"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConnectivityTestsResponse, ConnectivityTest> ListConnectivityTestsAsync(ListConnectivityTestsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all Connectivity Tests owned by a project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the Connectivity Tests:
        /// `projects/{project_id}/locations/global`
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
        /// <returns>A pageable sequence of <see cref="ConnectivityTest"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConnectivityTestsResponse, ConnectivityTest> ListConnectivityTests(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectivityTestsRequest request = new ListConnectivityTestsRequest
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
            return ListConnectivityTests(request, callSettings);
        }

        /// <summary>
        /// Lists all Connectivity Tests owned by a project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the Connectivity Tests:
        /// `projects/{project_id}/locations/global`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ConnectivityTest"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConnectivityTestsResponse, ConnectivityTest> ListConnectivityTestsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectivityTestsRequest request = new ListConnectivityTestsRequest
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
            return ListConnectivityTestsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all Connectivity Tests owned by a project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the Connectivity Tests:
        /// `projects/{project_id}/locations/global`
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
        /// <returns>A pageable sequence of <see cref="ConnectivityTest"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConnectivityTestsResponse, ConnectivityTest> ListConnectivityTests(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectivityTestsRequest request = new ListConnectivityTestsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListConnectivityTests(request, callSettings);
        }

        /// <summary>
        /// Lists all Connectivity Tests owned by a project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the Connectivity Tests:
        /// `projects/{project_id}/locations/global`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ConnectivityTest"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConnectivityTestsResponse, ConnectivityTest> ListConnectivityTestsAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectivityTestsRequest request = new ListConnectivityTestsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListConnectivityTestsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a specific Connectivity Test.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConnectivityTest GetConnectivityTest(GetConnectivityTestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a specific Connectivity Test.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectivityTest> GetConnectivityTestAsync(GetConnectivityTestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a specific Connectivity Test.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectivityTest> GetConnectivityTestAsync(GetConnectivityTestRequest request, st::CancellationToken cancellationToken) =>
            GetConnectivityTestAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a specific Connectivity Test.
        /// </summary>
        /// <param name="name">
        /// Required. `ConnectivityTest` resource name using the form:
        /// `projects/{project_id}/locations/global/connectivityTests/{test_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConnectivityTest GetConnectivityTest(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectivityTest(new GetConnectivityTestRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific Connectivity Test.
        /// </summary>
        /// <param name="name">
        /// Required. `ConnectivityTest` resource name using the form:
        /// `projects/{project_id}/locations/global/connectivityTests/{test_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectivityTest> GetConnectivityTestAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectivityTestAsync(new GetConnectivityTestRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific Connectivity Test.
        /// </summary>
        /// <param name="name">
        /// Required. `ConnectivityTest` resource name using the form:
        /// `projects/{project_id}/locations/global/connectivityTests/{test_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectivityTest> GetConnectivityTestAsync(string name, st::CancellationToken cancellationToken) =>
            GetConnectivityTestAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a specific Connectivity Test.
        /// </summary>
        /// <param name="name">
        /// Required. `ConnectivityTest` resource name using the form:
        /// `projects/{project_id}/locations/global/connectivityTests/{test_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConnectivityTest GetConnectivityTest(ConnectivityTestName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectivityTest(new GetConnectivityTestRequest
            {
                ConnectivityTestName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific Connectivity Test.
        /// </summary>
        /// <param name="name">
        /// Required. `ConnectivityTest` resource name using the form:
        /// `projects/{project_id}/locations/global/connectivityTests/{test_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectivityTest> GetConnectivityTestAsync(ConnectivityTestName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectivityTestAsync(new GetConnectivityTestRequest
            {
                ConnectivityTestName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific Connectivity Test.
        /// </summary>
        /// <param name="name">
        /// Required. `ConnectivityTest` resource name using the form:
        /// `projects/{project_id}/locations/global/connectivityTests/{test_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectivityTest> GetConnectivityTestAsync(ConnectivityTestName name, st::CancellationToken cancellationToken) =>
            GetConnectivityTestAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Connectivity Test.
        /// After you create a test, the reachability analysis is performed as part
        /// of the long running operation, which completes when the analysis completes.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` are invalid
        /// (for example, containing non-existent resources in the network, or you
        /// don't have read permissions to the network configurations of listed
        /// projects), then the reachability result returns a value of `UNKNOWN`.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` are
        /// incomplete, the reachability result returns a value of
        /// &lt;code&gt;AMBIGUOUS&lt;/code&gt;. For more information,
        /// see the Connectivity Test documentation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConnectivityTest, OperationMetadata> CreateConnectivityTest(CreateConnectivityTestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Connectivity Test.
        /// After you create a test, the reachability analysis is performed as part
        /// of the long running operation, which completes when the analysis completes.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` are invalid
        /// (for example, containing non-existent resources in the network, or you
        /// don't have read permissions to the network configurations of listed
        /// projects), then the reachability result returns a value of `UNKNOWN`.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` are
        /// incomplete, the reachability result returns a value of
        /// &lt;code&gt;AMBIGUOUS&lt;/code&gt;. For more information,
        /// see the Connectivity Test documentation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectivityTest, OperationMetadata>> CreateConnectivityTestAsync(CreateConnectivityTestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Connectivity Test.
        /// After you create a test, the reachability analysis is performed as part
        /// of the long running operation, which completes when the analysis completes.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` are invalid
        /// (for example, containing non-existent resources in the network, or you
        /// don't have read permissions to the network configurations of listed
        /// projects), then the reachability result returns a value of `UNKNOWN`.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` are
        /// incomplete, the reachability result returns a value of
        /// &lt;code&gt;AMBIGUOUS&lt;/code&gt;. For more information,
        /// see the Connectivity Test documentation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectivityTest, OperationMetadata>> CreateConnectivityTestAsync(CreateConnectivityTestRequest request, st::CancellationToken cancellationToken) =>
            CreateConnectivityTestAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateConnectivityTest</c>.</summary>
        public virtual lro::OperationsClient CreateConnectivityTestOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateConnectivityTest</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ConnectivityTest, OperationMetadata> PollOnceCreateConnectivityTest(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConnectivityTest, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateConnectivityTestOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateConnectivityTest</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ConnectivityTest, OperationMetadata>> PollOnceCreateConnectivityTestAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConnectivityTest, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateConnectivityTestOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Connectivity Test.
        /// After you create a test, the reachability analysis is performed as part
        /// of the long running operation, which completes when the analysis completes.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` are invalid
        /// (for example, containing non-existent resources in the network, or you
        /// don't have read permissions to the network configurations of listed
        /// projects), then the reachability result returns a value of `UNKNOWN`.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` are
        /// incomplete, the reachability result returns a value of
        /// &lt;code&gt;AMBIGUOUS&lt;/code&gt;. For more information,
        /// see the Connectivity Test documentation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the Connectivity Test to create:
        /// `projects/{project_id}/locations/global`
        /// </param>
        /// <param name="testId">
        /// Required. The logical name of the Connectivity Test in your project
        /// with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-40 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the customer project
        /// </param>
        /// <param name="resource">
        /// Required. A `ConnectivityTest` resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConnectivityTest, OperationMetadata> CreateConnectivityTest(string parent, string testId, ConnectivityTest resource, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnectivityTest(new CreateConnectivityTestRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TestId = gax::GaxPreconditions.CheckNotNullOrEmpty(testId, nameof(testId)),
                Resource = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Creates a new Connectivity Test.
        /// After you create a test, the reachability analysis is performed as part
        /// of the long running operation, which completes when the analysis completes.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` are invalid
        /// (for example, containing non-existent resources in the network, or you
        /// don't have read permissions to the network configurations of listed
        /// projects), then the reachability result returns a value of `UNKNOWN`.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` are
        /// incomplete, the reachability result returns a value of
        /// &lt;code&gt;AMBIGUOUS&lt;/code&gt;. For more information,
        /// see the Connectivity Test documentation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the Connectivity Test to create:
        /// `projects/{project_id}/locations/global`
        /// </param>
        /// <param name="testId">
        /// Required. The logical name of the Connectivity Test in your project
        /// with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-40 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the customer project
        /// </param>
        /// <param name="resource">
        /// Required. A `ConnectivityTest` resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectivityTest, OperationMetadata>> CreateConnectivityTestAsync(string parent, string testId, ConnectivityTest resource, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnectivityTestAsync(new CreateConnectivityTestRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TestId = gax::GaxPreconditions.CheckNotNullOrEmpty(testId, nameof(testId)),
                Resource = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Creates a new Connectivity Test.
        /// After you create a test, the reachability analysis is performed as part
        /// of the long running operation, which completes when the analysis completes.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` are invalid
        /// (for example, containing non-existent resources in the network, or you
        /// don't have read permissions to the network configurations of listed
        /// projects), then the reachability result returns a value of `UNKNOWN`.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` are
        /// incomplete, the reachability result returns a value of
        /// &lt;code&gt;AMBIGUOUS&lt;/code&gt;. For more information,
        /// see the Connectivity Test documentation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the Connectivity Test to create:
        /// `projects/{project_id}/locations/global`
        /// </param>
        /// <param name="testId">
        /// Required. The logical name of the Connectivity Test in your project
        /// with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-40 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the customer project
        /// </param>
        /// <param name="resource">
        /// Required. A `ConnectivityTest` resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectivityTest, OperationMetadata>> CreateConnectivityTestAsync(string parent, string testId, ConnectivityTest resource, st::CancellationToken cancellationToken) =>
            CreateConnectivityTestAsync(parent, testId, resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Connectivity Test.
        /// After you create a test, the reachability analysis is performed as part
        /// of the long running operation, which completes when the analysis completes.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` are invalid
        /// (for example, containing non-existent resources in the network, or you
        /// don't have read permissions to the network configurations of listed
        /// projects), then the reachability result returns a value of `UNKNOWN`.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` are
        /// incomplete, the reachability result returns a value of
        /// &lt;code&gt;AMBIGUOUS&lt;/code&gt;. For more information,
        /// see the Connectivity Test documentation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the Connectivity Test to create:
        /// `projects/{project_id}/locations/global`
        /// </param>
        /// <param name="testId">
        /// Required. The logical name of the Connectivity Test in your project
        /// with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-40 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the customer project
        /// </param>
        /// <param name="resource">
        /// Required. A `ConnectivityTest` resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConnectivityTest, OperationMetadata> CreateConnectivityTest(gagr::ProjectName parent, string testId, ConnectivityTest resource, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnectivityTest(new CreateConnectivityTestRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TestId = gax::GaxPreconditions.CheckNotNullOrEmpty(testId, nameof(testId)),
                Resource = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Creates a new Connectivity Test.
        /// After you create a test, the reachability analysis is performed as part
        /// of the long running operation, which completes when the analysis completes.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` are invalid
        /// (for example, containing non-existent resources in the network, or you
        /// don't have read permissions to the network configurations of listed
        /// projects), then the reachability result returns a value of `UNKNOWN`.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` are
        /// incomplete, the reachability result returns a value of
        /// &lt;code&gt;AMBIGUOUS&lt;/code&gt;. For more information,
        /// see the Connectivity Test documentation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the Connectivity Test to create:
        /// `projects/{project_id}/locations/global`
        /// </param>
        /// <param name="testId">
        /// Required. The logical name of the Connectivity Test in your project
        /// with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-40 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the customer project
        /// </param>
        /// <param name="resource">
        /// Required. A `ConnectivityTest` resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectivityTest, OperationMetadata>> CreateConnectivityTestAsync(gagr::ProjectName parent, string testId, ConnectivityTest resource, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnectivityTestAsync(new CreateConnectivityTestRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TestId = gax::GaxPreconditions.CheckNotNullOrEmpty(testId, nameof(testId)),
                Resource = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Creates a new Connectivity Test.
        /// After you create a test, the reachability analysis is performed as part
        /// of the long running operation, which completes when the analysis completes.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` are invalid
        /// (for example, containing non-existent resources in the network, or you
        /// don't have read permissions to the network configurations of listed
        /// projects), then the reachability result returns a value of `UNKNOWN`.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` are
        /// incomplete, the reachability result returns a value of
        /// &lt;code&gt;AMBIGUOUS&lt;/code&gt;. For more information,
        /// see the Connectivity Test documentation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the Connectivity Test to create:
        /// `projects/{project_id}/locations/global`
        /// </param>
        /// <param name="testId">
        /// Required. The logical name of the Connectivity Test in your project
        /// with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-40 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the customer project
        /// </param>
        /// <param name="resource">
        /// Required. A `ConnectivityTest` resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectivityTest, OperationMetadata>> CreateConnectivityTestAsync(gagr::ProjectName parent, string testId, ConnectivityTest resource, st::CancellationToken cancellationToken) =>
            CreateConnectivityTestAsync(parent, testId, resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the configuration of an existing `ConnectivityTest`.
        /// After you update a test, the reachability analysis is performed as part
        /// of the long running operation, which completes when the analysis completes.
        /// The Reachability state in the test resource is updated with the new result.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` are invalid
        /// (for example, they contain non-existent resources in the network, or the
        /// user does not have read permissions to the network configurations of
        /// listed projects), then the reachability result returns a value of
        /// &lt;code&gt;UNKNOWN&lt;/code&gt;.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` are incomplete, the
        /// reachability result returns a value of `AMBIGUOUS`. See the documentation
        /// in `ConnectivityTest` for more details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConnectivityTest, OperationMetadata> UpdateConnectivityTest(UpdateConnectivityTestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the configuration of an existing `ConnectivityTest`.
        /// After you update a test, the reachability analysis is performed as part
        /// of the long running operation, which completes when the analysis completes.
        /// The Reachability state in the test resource is updated with the new result.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` are invalid
        /// (for example, they contain non-existent resources in the network, or the
        /// user does not have read permissions to the network configurations of
        /// listed projects), then the reachability result returns a value of
        /// &lt;code&gt;UNKNOWN&lt;/code&gt;.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` are incomplete, the
        /// reachability result returns a value of `AMBIGUOUS`. See the documentation
        /// in `ConnectivityTest` for more details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectivityTest, OperationMetadata>> UpdateConnectivityTestAsync(UpdateConnectivityTestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the configuration of an existing `ConnectivityTest`.
        /// After you update a test, the reachability analysis is performed as part
        /// of the long running operation, which completes when the analysis completes.
        /// The Reachability state in the test resource is updated with the new result.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` are invalid
        /// (for example, they contain non-existent resources in the network, or the
        /// user does not have read permissions to the network configurations of
        /// listed projects), then the reachability result returns a value of
        /// &lt;code&gt;UNKNOWN&lt;/code&gt;.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` are incomplete, the
        /// reachability result returns a value of `AMBIGUOUS`. See the documentation
        /// in `ConnectivityTest` for more details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectivityTest, OperationMetadata>> UpdateConnectivityTestAsync(UpdateConnectivityTestRequest request, st::CancellationToken cancellationToken) =>
            UpdateConnectivityTestAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateConnectivityTest</c>.</summary>
        public virtual lro::OperationsClient UpdateConnectivityTestOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateConnectivityTest</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ConnectivityTest, OperationMetadata> PollOnceUpdateConnectivityTest(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConnectivityTest, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateConnectivityTestOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateConnectivityTest</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ConnectivityTest, OperationMetadata>> PollOnceUpdateConnectivityTestAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConnectivityTest, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateConnectivityTestOperationsClient, callSettings);

        /// <summary>
        /// Updates the configuration of an existing `ConnectivityTest`.
        /// After you update a test, the reachability analysis is performed as part
        /// of the long running operation, which completes when the analysis completes.
        /// The Reachability state in the test resource is updated with the new result.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` are invalid
        /// (for example, they contain non-existent resources in the network, or the
        /// user does not have read permissions to the network configurations of
        /// listed projects), then the reachability result returns a value of
        /// &lt;code&gt;UNKNOWN&lt;/code&gt;.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` are incomplete, the
        /// reachability result returns a value of `AMBIGUOUS`. See the documentation
        /// in `ConnectivityTest` for more details.
        /// </summary>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field.
        /// </param>
        /// <param name="resource">
        /// Required. Only fields specified in update_mask are updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConnectivityTest, OperationMetadata> UpdateConnectivityTest(wkt::FieldMask updateMask, ConnectivityTest resource, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConnectivityTest(new UpdateConnectivityTestRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Resource = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Updates the configuration of an existing `ConnectivityTest`.
        /// After you update a test, the reachability analysis is performed as part
        /// of the long running operation, which completes when the analysis completes.
        /// The Reachability state in the test resource is updated with the new result.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` are invalid
        /// (for example, they contain non-existent resources in the network, or the
        /// user does not have read permissions to the network configurations of
        /// listed projects), then the reachability result returns a value of
        /// &lt;code&gt;UNKNOWN&lt;/code&gt;.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` are incomplete, the
        /// reachability result returns a value of `AMBIGUOUS`. See the documentation
        /// in `ConnectivityTest` for more details.
        /// </summary>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field.
        /// </param>
        /// <param name="resource">
        /// Required. Only fields specified in update_mask are updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectivityTest, OperationMetadata>> UpdateConnectivityTestAsync(wkt::FieldMask updateMask, ConnectivityTest resource, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConnectivityTestAsync(new UpdateConnectivityTestRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Resource = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Updates the configuration of an existing `ConnectivityTest`.
        /// After you update a test, the reachability analysis is performed as part
        /// of the long running operation, which completes when the analysis completes.
        /// The Reachability state in the test resource is updated with the new result.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` are invalid
        /// (for example, they contain non-existent resources in the network, or the
        /// user does not have read permissions to the network configurations of
        /// listed projects), then the reachability result returns a value of
        /// &lt;code&gt;UNKNOWN&lt;/code&gt;.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` are incomplete, the
        /// reachability result returns a value of `AMBIGUOUS`. See the documentation
        /// in `ConnectivityTest` for more details.
        /// </summary>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field.
        /// </param>
        /// <param name="resource">
        /// Required. Only fields specified in update_mask are updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectivityTest, OperationMetadata>> UpdateConnectivityTestAsync(wkt::FieldMask updateMask, ConnectivityTest resource, st::CancellationToken cancellationToken) =>
            UpdateConnectivityTestAsync(updateMask, resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Rerun an existing `ConnectivityTest`.
        /// After the user triggers the rerun, the reachability analysis is performed
        /// as part of the long running operation, which completes when the analysis
        /// completes.
        /// 
        /// Even though the test configuration remains the same, the reachability
        /// result may change due to underlying network configuration changes.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` become invalid (for
        /// example, specified resources are deleted in the network, or you lost
        /// read permissions to the network configurations of listed projects), then
        /// the reachability result returns a value of `UNKNOWN`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConnectivityTest, OperationMetadata> RerunConnectivityTest(RerunConnectivityTestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Rerun an existing `ConnectivityTest`.
        /// After the user triggers the rerun, the reachability analysis is performed
        /// as part of the long running operation, which completes when the analysis
        /// completes.
        /// 
        /// Even though the test configuration remains the same, the reachability
        /// result may change due to underlying network configuration changes.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` become invalid (for
        /// example, specified resources are deleted in the network, or you lost
        /// read permissions to the network configurations of listed projects), then
        /// the reachability result returns a value of `UNKNOWN`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectivityTest, OperationMetadata>> RerunConnectivityTestAsync(RerunConnectivityTestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Rerun an existing `ConnectivityTest`.
        /// After the user triggers the rerun, the reachability analysis is performed
        /// as part of the long running operation, which completes when the analysis
        /// completes.
        /// 
        /// Even though the test configuration remains the same, the reachability
        /// result may change due to underlying network configuration changes.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` become invalid (for
        /// example, specified resources are deleted in the network, or you lost
        /// read permissions to the network configurations of listed projects), then
        /// the reachability result returns a value of `UNKNOWN`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectivityTest, OperationMetadata>> RerunConnectivityTestAsync(RerunConnectivityTestRequest request, st::CancellationToken cancellationToken) =>
            RerunConnectivityTestAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RerunConnectivityTest</c>.</summary>
        public virtual lro::OperationsClient RerunConnectivityTestOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RerunConnectivityTest</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ConnectivityTest, OperationMetadata> PollOnceRerunConnectivityTest(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConnectivityTest, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RerunConnectivityTestOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RerunConnectivityTest</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ConnectivityTest, OperationMetadata>> PollOnceRerunConnectivityTestAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConnectivityTest, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RerunConnectivityTestOperationsClient, callSettings);

        /// <summary>
        /// Deletes a specific `ConnectivityTest`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteConnectivityTest(DeleteConnectivityTestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a specific `ConnectivityTest`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectivityTestAsync(DeleteConnectivityTestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a specific `ConnectivityTest`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectivityTestAsync(DeleteConnectivityTestRequest request, st::CancellationToken cancellationToken) =>
            DeleteConnectivityTestAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteConnectivityTest</c>.</summary>
        public virtual lro::OperationsClient DeleteConnectivityTestOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteConnectivityTest</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteConnectivityTest(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteConnectivityTestOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteConnectivityTest</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteConnectivityTestAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteConnectivityTestOperationsClient, callSettings);

        /// <summary>
        /// Deletes a specific `ConnectivityTest`.
        /// </summary>
        /// <param name="name">
        /// Required. Connectivity Test resource name using the form:
        /// `projects/{project_id}/locations/global/connectivityTests/{test_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteConnectivityTest(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnectivityTest(new DeleteConnectivityTestRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific `ConnectivityTest`.
        /// </summary>
        /// <param name="name">
        /// Required. Connectivity Test resource name using the form:
        /// `projects/{project_id}/locations/global/connectivityTests/{test_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectivityTestAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnectivityTestAsync(new DeleteConnectivityTestRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific `ConnectivityTest`.
        /// </summary>
        /// <param name="name">
        /// Required. Connectivity Test resource name using the form:
        /// `projects/{project_id}/locations/global/connectivityTests/{test_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectivityTestAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteConnectivityTestAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a specific `ConnectivityTest`.
        /// </summary>
        /// <param name="name">
        /// Required. Connectivity Test resource name using the form:
        /// `projects/{project_id}/locations/global/connectivityTests/{test_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteConnectivityTest(ConnectivityTestName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnectivityTest(new DeleteConnectivityTestRequest
            {
                ConnectivityTestName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific `ConnectivityTest`.
        /// </summary>
        /// <param name="name">
        /// Required. Connectivity Test resource name using the form:
        /// `projects/{project_id}/locations/global/connectivityTests/{test_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectivityTestAsync(ConnectivityTestName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnectivityTestAsync(new DeleteConnectivityTestRequest
            {
                ConnectivityTestName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific `ConnectivityTest`.
        /// </summary>
        /// <param name="name">
        /// Required. Connectivity Test resource name using the form:
        /// `projects/{project_id}/locations/global/connectivityTests/{test_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectivityTestAsync(ConnectivityTestName name, st::CancellationToken cancellationToken) =>
            DeleteConnectivityTestAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ReachabilityService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The Reachability service in the Google Cloud Network Management API provides
    /// services that analyze the reachability within a single Google Virtual Private
    /// Cloud (VPC) network, between peered VPC networks, between VPC and on-premises
    /// networks, or between VPC networks and internet hosts. A reachability analysis
    /// is based on Google Cloud network configurations.
    /// 
    /// You can use the analysis results to verify these configurations and
    /// to troubleshoot connectivity issues.
    /// </remarks>
    public sealed partial class ReachabilityServiceClientImpl : ReachabilityServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListConnectivityTestsRequest, ListConnectivityTestsResponse> _callListConnectivityTests;

        private readonly gaxgrpc::ApiCall<GetConnectivityTestRequest, ConnectivityTest> _callGetConnectivityTest;

        private readonly gaxgrpc::ApiCall<CreateConnectivityTestRequest, lro::Operation> _callCreateConnectivityTest;

        private readonly gaxgrpc::ApiCall<UpdateConnectivityTestRequest, lro::Operation> _callUpdateConnectivityTest;

        private readonly gaxgrpc::ApiCall<RerunConnectivityTestRequest, lro::Operation> _callRerunConnectivityTest;

        private readonly gaxgrpc::ApiCall<DeleteConnectivityTestRequest, lro::Operation> _callDeleteConnectivityTest;

        /// <summary>
        /// Constructs a client wrapper for the ReachabilityService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ReachabilityServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ReachabilityServiceClientImpl(ReachabilityService.ReachabilityServiceClient grpcClient, ReachabilityServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ReachabilityServiceSettings effectiveSettings = settings ?? ReachabilityServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateConnectivityTestOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateConnectivityTestOperationsSettings, logger);
            UpdateConnectivityTestOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateConnectivityTestOperationsSettings, logger);
            RerunConnectivityTestOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RerunConnectivityTestOperationsSettings, logger);
            DeleteConnectivityTestOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteConnectivityTestOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListConnectivityTests = clientHelper.BuildApiCall<ListConnectivityTestsRequest, ListConnectivityTestsResponse>("ListConnectivityTests", grpcClient.ListConnectivityTestsAsync, grpcClient.ListConnectivityTests, effectiveSettings.ListConnectivityTestsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListConnectivityTests);
            Modify_ListConnectivityTestsApiCall(ref _callListConnectivityTests);
            _callGetConnectivityTest = clientHelper.BuildApiCall<GetConnectivityTestRequest, ConnectivityTest>("GetConnectivityTest", grpcClient.GetConnectivityTestAsync, grpcClient.GetConnectivityTest, effectiveSettings.GetConnectivityTestSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetConnectivityTest);
            Modify_GetConnectivityTestApiCall(ref _callGetConnectivityTest);
            _callCreateConnectivityTest = clientHelper.BuildApiCall<CreateConnectivityTestRequest, lro::Operation>("CreateConnectivityTest", grpcClient.CreateConnectivityTestAsync, grpcClient.CreateConnectivityTest, effectiveSettings.CreateConnectivityTestSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateConnectivityTest);
            Modify_CreateConnectivityTestApiCall(ref _callCreateConnectivityTest);
            _callUpdateConnectivityTest = clientHelper.BuildApiCall<UpdateConnectivityTestRequest, lro::Operation>("UpdateConnectivityTest", grpcClient.UpdateConnectivityTestAsync, grpcClient.UpdateConnectivityTest, effectiveSettings.UpdateConnectivityTestSettings).WithGoogleRequestParam("resource.name", request => request.Resource?.Name);
            Modify_ApiCall(ref _callUpdateConnectivityTest);
            Modify_UpdateConnectivityTestApiCall(ref _callUpdateConnectivityTest);
            _callRerunConnectivityTest = clientHelper.BuildApiCall<RerunConnectivityTestRequest, lro::Operation>("RerunConnectivityTest", grpcClient.RerunConnectivityTestAsync, grpcClient.RerunConnectivityTest, effectiveSettings.RerunConnectivityTestSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRerunConnectivityTest);
            Modify_RerunConnectivityTestApiCall(ref _callRerunConnectivityTest);
            _callDeleteConnectivityTest = clientHelper.BuildApiCall<DeleteConnectivityTestRequest, lro::Operation>("DeleteConnectivityTest", grpcClient.DeleteConnectivityTestAsync, grpcClient.DeleteConnectivityTest, effectiveSettings.DeleteConnectivityTestSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteConnectivityTest);
            Modify_DeleteConnectivityTestApiCall(ref _callDeleteConnectivityTest);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListConnectivityTestsApiCall(ref gaxgrpc::ApiCall<ListConnectivityTestsRequest, ListConnectivityTestsResponse> call);

        partial void Modify_GetConnectivityTestApiCall(ref gaxgrpc::ApiCall<GetConnectivityTestRequest, ConnectivityTest> call);

        partial void Modify_CreateConnectivityTestApiCall(ref gaxgrpc::ApiCall<CreateConnectivityTestRequest, lro::Operation> call);

        partial void Modify_UpdateConnectivityTestApiCall(ref gaxgrpc::ApiCall<UpdateConnectivityTestRequest, lro::Operation> call);

        partial void Modify_RerunConnectivityTestApiCall(ref gaxgrpc::ApiCall<RerunConnectivityTestRequest, lro::Operation> call);

        partial void Modify_DeleteConnectivityTestApiCall(ref gaxgrpc::ApiCall<DeleteConnectivityTestRequest, lro::Operation> call);

        partial void OnConstruction(ReachabilityService.ReachabilityServiceClient grpcClient, ReachabilityServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ReachabilityService client</summary>
        public override ReachabilityService.ReachabilityServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListConnectivityTestsRequest(ref ListConnectivityTestsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetConnectivityTestRequest(ref GetConnectivityTestRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateConnectivityTestRequest(ref CreateConnectivityTestRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateConnectivityTestRequest(ref UpdateConnectivityTestRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RerunConnectivityTestRequest(ref RerunConnectivityTestRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteConnectivityTestRequest(ref DeleteConnectivityTestRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists all Connectivity Tests owned by a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ConnectivityTest"/> resources.</returns>
        public override gax::PagedEnumerable<ListConnectivityTestsResponse, ConnectivityTest> ListConnectivityTests(ListConnectivityTestsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConnectivityTestsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListConnectivityTestsRequest, ListConnectivityTestsResponse, ConnectivityTest>(_callListConnectivityTests, request, callSettings);
        }

        /// <summary>
        /// Lists all Connectivity Tests owned by a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ConnectivityTest"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListConnectivityTestsResponse, ConnectivityTest> ListConnectivityTestsAsync(ListConnectivityTestsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConnectivityTestsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListConnectivityTestsRequest, ListConnectivityTestsResponse, ConnectivityTest>(_callListConnectivityTests, request, callSettings);
        }

        /// <summary>
        /// Gets the details of a specific Connectivity Test.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ConnectivityTest GetConnectivityTest(GetConnectivityTestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConnectivityTestRequest(ref request, ref callSettings);
            return _callGetConnectivityTest.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a specific Connectivity Test.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ConnectivityTest> GetConnectivityTestAsync(GetConnectivityTestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConnectivityTestRequest(ref request, ref callSettings);
            return _callGetConnectivityTest.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateConnectivityTest</c>.</summary>
        public override lro::OperationsClient CreateConnectivityTestOperationsClient { get; }

        /// <summary>
        /// Creates a new Connectivity Test.
        /// After you create a test, the reachability analysis is performed as part
        /// of the long running operation, which completes when the analysis completes.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` are invalid
        /// (for example, containing non-existent resources in the network, or you
        /// don't have read permissions to the network configurations of listed
        /// projects), then the reachability result returns a value of `UNKNOWN`.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` are
        /// incomplete, the reachability result returns a value of
        /// &lt;code&gt;AMBIGUOUS&lt;/code&gt;. For more information,
        /// see the Connectivity Test documentation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ConnectivityTest, OperationMetadata> CreateConnectivityTest(CreateConnectivityTestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConnectivityTestRequest(ref request, ref callSettings);
            return new lro::Operation<ConnectivityTest, OperationMetadata>(_callCreateConnectivityTest.Sync(request, callSettings), CreateConnectivityTestOperationsClient);
        }

        /// <summary>
        /// Creates a new Connectivity Test.
        /// After you create a test, the reachability analysis is performed as part
        /// of the long running operation, which completes when the analysis completes.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` are invalid
        /// (for example, containing non-existent resources in the network, or you
        /// don't have read permissions to the network configurations of listed
        /// projects), then the reachability result returns a value of `UNKNOWN`.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` are
        /// incomplete, the reachability result returns a value of
        /// &lt;code&gt;AMBIGUOUS&lt;/code&gt;. For more information,
        /// see the Connectivity Test documentation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ConnectivityTest, OperationMetadata>> CreateConnectivityTestAsync(CreateConnectivityTestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConnectivityTestRequest(ref request, ref callSettings);
            return new lro::Operation<ConnectivityTest, OperationMetadata>(await _callCreateConnectivityTest.Async(request, callSettings).ConfigureAwait(false), CreateConnectivityTestOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateConnectivityTest</c>.</summary>
        public override lro::OperationsClient UpdateConnectivityTestOperationsClient { get; }

        /// <summary>
        /// Updates the configuration of an existing `ConnectivityTest`.
        /// After you update a test, the reachability analysis is performed as part
        /// of the long running operation, which completes when the analysis completes.
        /// The Reachability state in the test resource is updated with the new result.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` are invalid
        /// (for example, they contain non-existent resources in the network, or the
        /// user does not have read permissions to the network configurations of
        /// listed projects), then the reachability result returns a value of
        /// &lt;code&gt;UNKNOWN&lt;/code&gt;.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` are incomplete, the
        /// reachability result returns a value of `AMBIGUOUS`. See the documentation
        /// in `ConnectivityTest` for more details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ConnectivityTest, OperationMetadata> UpdateConnectivityTest(UpdateConnectivityTestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConnectivityTestRequest(ref request, ref callSettings);
            return new lro::Operation<ConnectivityTest, OperationMetadata>(_callUpdateConnectivityTest.Sync(request, callSettings), UpdateConnectivityTestOperationsClient);
        }

        /// <summary>
        /// Updates the configuration of an existing `ConnectivityTest`.
        /// After you update a test, the reachability analysis is performed as part
        /// of the long running operation, which completes when the analysis completes.
        /// The Reachability state in the test resource is updated with the new result.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` are invalid
        /// (for example, they contain non-existent resources in the network, or the
        /// user does not have read permissions to the network configurations of
        /// listed projects), then the reachability result returns a value of
        /// &lt;code&gt;UNKNOWN&lt;/code&gt;.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` are incomplete, the
        /// reachability result returns a value of `AMBIGUOUS`. See the documentation
        /// in `ConnectivityTest` for more details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ConnectivityTest, OperationMetadata>> UpdateConnectivityTestAsync(UpdateConnectivityTestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConnectivityTestRequest(ref request, ref callSettings);
            return new lro::Operation<ConnectivityTest, OperationMetadata>(await _callUpdateConnectivityTest.Async(request, callSettings).ConfigureAwait(false), UpdateConnectivityTestOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RerunConnectivityTest</c>.</summary>
        public override lro::OperationsClient RerunConnectivityTestOperationsClient { get; }

        /// <summary>
        /// Rerun an existing `ConnectivityTest`.
        /// After the user triggers the rerun, the reachability analysis is performed
        /// as part of the long running operation, which completes when the analysis
        /// completes.
        /// 
        /// Even though the test configuration remains the same, the reachability
        /// result may change due to underlying network configuration changes.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` become invalid (for
        /// example, specified resources are deleted in the network, or you lost
        /// read permissions to the network configurations of listed projects), then
        /// the reachability result returns a value of `UNKNOWN`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ConnectivityTest, OperationMetadata> RerunConnectivityTest(RerunConnectivityTestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RerunConnectivityTestRequest(ref request, ref callSettings);
            return new lro::Operation<ConnectivityTest, OperationMetadata>(_callRerunConnectivityTest.Sync(request, callSettings), RerunConnectivityTestOperationsClient);
        }

        /// <summary>
        /// Rerun an existing `ConnectivityTest`.
        /// After the user triggers the rerun, the reachability analysis is performed
        /// as part of the long running operation, which completes when the analysis
        /// completes.
        /// 
        /// Even though the test configuration remains the same, the reachability
        /// result may change due to underlying network configuration changes.
        /// 
        /// If the endpoint specifications in `ConnectivityTest` become invalid (for
        /// example, specified resources are deleted in the network, or you lost
        /// read permissions to the network configurations of listed projects), then
        /// the reachability result returns a value of `UNKNOWN`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ConnectivityTest, OperationMetadata>> RerunConnectivityTestAsync(RerunConnectivityTestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RerunConnectivityTestRequest(ref request, ref callSettings);
            return new lro::Operation<ConnectivityTest, OperationMetadata>(await _callRerunConnectivityTest.Async(request, callSettings).ConfigureAwait(false), RerunConnectivityTestOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteConnectivityTest</c>.</summary>
        public override lro::OperationsClient DeleteConnectivityTestOperationsClient { get; }

        /// <summary>
        /// Deletes a specific `ConnectivityTest`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteConnectivityTest(DeleteConnectivityTestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConnectivityTestRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteConnectivityTest.Sync(request, callSettings), DeleteConnectivityTestOperationsClient);
        }

        /// <summary>
        /// Deletes a specific `ConnectivityTest`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectivityTestAsync(DeleteConnectivityTestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConnectivityTestRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteConnectivityTest.Async(request, callSettings).ConfigureAwait(false), DeleteConnectivityTestOperationsClient);
        }
    }

    public partial class ListConnectivityTestsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListConnectivityTestsResponse : gaxgrpc::IPageResponse<ConnectivityTest>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ConnectivityTest> GetEnumerator() => Resources.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ReachabilityService
    {
        public partial class ReachabilityServiceClient
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

    public static partial class ReachabilityService
    {
        public partial class ReachabilityServiceClient
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
