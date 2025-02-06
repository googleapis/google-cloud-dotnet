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
    /// <summary>Settings for <see cref="VpcFlowLogsServiceClient"/> instances.</summary>
    public sealed partial class VpcFlowLogsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="VpcFlowLogsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="VpcFlowLogsServiceSettings"/>.</returns>
        public static VpcFlowLogsServiceSettings GetDefault() => new VpcFlowLogsServiceSettings();

        /// <summary>Constructs a new <see cref="VpcFlowLogsServiceSettings"/> object with default settings.</summary>
        public VpcFlowLogsServiceSettings()
        {
        }

        private VpcFlowLogsServiceSettings(VpcFlowLogsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListVpcFlowLogsConfigsSettings = existing.ListVpcFlowLogsConfigsSettings;
            GetVpcFlowLogsConfigSettings = existing.GetVpcFlowLogsConfigSettings;
            CreateVpcFlowLogsConfigSettings = existing.CreateVpcFlowLogsConfigSettings;
            CreateVpcFlowLogsConfigOperationsSettings = existing.CreateVpcFlowLogsConfigOperationsSettings.Clone();
            UpdateVpcFlowLogsConfigSettings = existing.UpdateVpcFlowLogsConfigSettings;
            UpdateVpcFlowLogsConfigOperationsSettings = existing.UpdateVpcFlowLogsConfigOperationsSettings.Clone();
            DeleteVpcFlowLogsConfigSettings = existing.DeleteVpcFlowLogsConfigSettings;
            DeleteVpcFlowLogsConfigOperationsSettings = existing.DeleteVpcFlowLogsConfigOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(VpcFlowLogsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VpcFlowLogsServiceClient.ListVpcFlowLogsConfigs</c> and
        /// <c>VpcFlowLogsServiceClient.ListVpcFlowLogsConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListVpcFlowLogsConfigsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VpcFlowLogsServiceClient.GetVpcFlowLogsConfig</c> and
        /// <c>VpcFlowLogsServiceClient.GetVpcFlowLogsConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetVpcFlowLogsConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VpcFlowLogsServiceClient.CreateVpcFlowLogsConfig</c> and
        /// <c>VpcFlowLogsServiceClient.CreateVpcFlowLogsConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateVpcFlowLogsConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>VpcFlowLogsServiceClient.CreateVpcFlowLogsConfig</c> and
        /// <c>VpcFlowLogsServiceClient.CreateVpcFlowLogsConfigAsync</c>.
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
        public lro::OperationsSettings CreateVpcFlowLogsConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VpcFlowLogsServiceClient.UpdateVpcFlowLogsConfig</c> and
        /// <c>VpcFlowLogsServiceClient.UpdateVpcFlowLogsConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateVpcFlowLogsConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>VpcFlowLogsServiceClient.UpdateVpcFlowLogsConfig</c> and
        /// <c>VpcFlowLogsServiceClient.UpdateVpcFlowLogsConfigAsync</c>.
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
        public lro::OperationsSettings UpdateVpcFlowLogsConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VpcFlowLogsServiceClient.DeleteVpcFlowLogsConfig</c> and
        /// <c>VpcFlowLogsServiceClient.DeleteVpcFlowLogsConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteVpcFlowLogsConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>VpcFlowLogsServiceClient.DeleteVpcFlowLogsConfig</c> and
        /// <c>VpcFlowLogsServiceClient.DeleteVpcFlowLogsConfigAsync</c>.
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
        public lro::OperationsSettings DeleteVpcFlowLogsConfigOperationsSettings { get; set; } = new lro::OperationsSettings
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
        /// <returns>A deep clone of this <see cref="VpcFlowLogsServiceSettings"/> object.</returns>
        public VpcFlowLogsServiceSettings Clone() => new VpcFlowLogsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="VpcFlowLogsServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class VpcFlowLogsServiceClientBuilder : gaxgrpc::ClientBuilderBase<VpcFlowLogsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public VpcFlowLogsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public VpcFlowLogsServiceClientBuilder() : base(VpcFlowLogsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref VpcFlowLogsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<VpcFlowLogsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override VpcFlowLogsServiceClient Build()
        {
            VpcFlowLogsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<VpcFlowLogsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<VpcFlowLogsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private VpcFlowLogsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return VpcFlowLogsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<VpcFlowLogsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return VpcFlowLogsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => VpcFlowLogsServiceClient.ChannelPool;
    }

    /// <summary>VpcFlowLogsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The VPC Flow Logs service in the Google Cloud Network Management API provides
    /// configurations that generate Flow Logs. The service and the configuration
    /// resources created using this service are global.
    /// </remarks>
    public abstract partial class VpcFlowLogsServiceClient
    {
        /// <summary>
        /// The default endpoint for the VpcFlowLogsService service, which is a host of
        /// "networkmanagement.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "networkmanagement.googleapis.com:443";

        /// <summary>The default VpcFlowLogsService scopes.</summary>
        /// <remarks>
        /// The default VpcFlowLogsService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(VpcFlowLogsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="VpcFlowLogsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="VpcFlowLogsServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="VpcFlowLogsServiceClient"/>.</returns>
        public static stt::Task<VpcFlowLogsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new VpcFlowLogsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="VpcFlowLogsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="VpcFlowLogsServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="VpcFlowLogsServiceClient"/>.</returns>
        public static VpcFlowLogsServiceClient Create() => new VpcFlowLogsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="VpcFlowLogsServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="VpcFlowLogsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="VpcFlowLogsServiceClient"/>.</returns>
        internal static VpcFlowLogsServiceClient Create(grpccore::CallInvoker callInvoker, VpcFlowLogsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            VpcFlowLogsService.VpcFlowLogsServiceClient grpcClient = new VpcFlowLogsService.VpcFlowLogsServiceClient(callInvoker);
            return new VpcFlowLogsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC VpcFlowLogsService client</summary>
        public virtual VpcFlowLogsService.VpcFlowLogsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all `VpcFlowLogsConfigs` in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="VpcFlowLogsConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVpcFlowLogsConfigsResponse, VpcFlowLogsConfig> ListVpcFlowLogsConfigs(ListVpcFlowLogsConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all `VpcFlowLogsConfigs` in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="VpcFlowLogsConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVpcFlowLogsConfigsResponse, VpcFlowLogsConfig> ListVpcFlowLogsConfigsAsync(ListVpcFlowLogsConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all `VpcFlowLogsConfigs` in a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the VpcFlowLogsConfig:
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
        /// <returns>A pageable sequence of <see cref="VpcFlowLogsConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVpcFlowLogsConfigsResponse, VpcFlowLogsConfig> ListVpcFlowLogsConfigs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListVpcFlowLogsConfigsRequest request = new ListVpcFlowLogsConfigsRequest
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
            return ListVpcFlowLogsConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists all `VpcFlowLogsConfigs` in a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the VpcFlowLogsConfig:
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
        /// <returns>A pageable asynchronous sequence of <see cref="VpcFlowLogsConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVpcFlowLogsConfigsResponse, VpcFlowLogsConfig> ListVpcFlowLogsConfigsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListVpcFlowLogsConfigsRequest request = new ListVpcFlowLogsConfigsRequest
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
            return ListVpcFlowLogsConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all `VpcFlowLogsConfigs` in a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the VpcFlowLogsConfig:
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
        /// <returns>A pageable sequence of <see cref="VpcFlowLogsConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVpcFlowLogsConfigsResponse, VpcFlowLogsConfig> ListVpcFlowLogsConfigs(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListVpcFlowLogsConfigsRequest request = new ListVpcFlowLogsConfigsRequest
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
            return ListVpcFlowLogsConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists all `VpcFlowLogsConfigs` in a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the VpcFlowLogsConfig:
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
        /// <returns>A pageable asynchronous sequence of <see cref="VpcFlowLogsConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVpcFlowLogsConfigsResponse, VpcFlowLogsConfig> ListVpcFlowLogsConfigsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListVpcFlowLogsConfigsRequest request = new ListVpcFlowLogsConfigsRequest
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
            return ListVpcFlowLogsConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a specific `VpcFlowLogsConfig`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VpcFlowLogsConfig GetVpcFlowLogsConfig(GetVpcFlowLogsConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a specific `VpcFlowLogsConfig`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VpcFlowLogsConfig> GetVpcFlowLogsConfigAsync(GetVpcFlowLogsConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a specific `VpcFlowLogsConfig`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VpcFlowLogsConfig> GetVpcFlowLogsConfigAsync(GetVpcFlowLogsConfigRequest request, st::CancellationToken cancellationToken) =>
            GetVpcFlowLogsConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a specific `VpcFlowLogsConfig`.
        /// </summary>
        /// <param name="name">
        /// Required. `VpcFlowLogsConfig` resource name using the form:
        /// `projects/{project_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VpcFlowLogsConfig GetVpcFlowLogsConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetVpcFlowLogsConfig(new GetVpcFlowLogsConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific `VpcFlowLogsConfig`.
        /// </summary>
        /// <param name="name">
        /// Required. `VpcFlowLogsConfig` resource name using the form:
        /// `projects/{project_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VpcFlowLogsConfig> GetVpcFlowLogsConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetVpcFlowLogsConfigAsync(new GetVpcFlowLogsConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific `VpcFlowLogsConfig`.
        /// </summary>
        /// <param name="name">
        /// Required. `VpcFlowLogsConfig` resource name using the form:
        /// `projects/{project_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VpcFlowLogsConfig> GetVpcFlowLogsConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetVpcFlowLogsConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a specific `VpcFlowLogsConfig`.
        /// </summary>
        /// <param name="name">
        /// Required. `VpcFlowLogsConfig` resource name using the form:
        /// `projects/{project_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VpcFlowLogsConfig GetVpcFlowLogsConfig(VpcFlowLogsConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetVpcFlowLogsConfig(new GetVpcFlowLogsConfigRequest
            {
                VpcFlowLogsConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific `VpcFlowLogsConfig`.
        /// </summary>
        /// <param name="name">
        /// Required. `VpcFlowLogsConfig` resource name using the form:
        /// `projects/{project_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VpcFlowLogsConfig> GetVpcFlowLogsConfigAsync(VpcFlowLogsConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetVpcFlowLogsConfigAsync(new GetVpcFlowLogsConfigRequest
            {
                VpcFlowLogsConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific `VpcFlowLogsConfig`.
        /// </summary>
        /// <param name="name">
        /// Required. `VpcFlowLogsConfig` resource name using the form:
        /// `projects/{project_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VpcFlowLogsConfig> GetVpcFlowLogsConfigAsync(VpcFlowLogsConfigName name, st::CancellationToken cancellationToken) =>
            GetVpcFlowLogsConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new `VpcFlowLogsConfig`.
        /// If a configuration with the exact same settings already exists (even if the
        /// ID is different), the creation fails.
        /// Notes:
        /// 
        /// 1. Creating a configuration with state=DISABLED will fail
        /// 2. The following fields are not considered as `settings` for the purpose
        /// of the check mentioned above, therefore - creating another configuration
        /// with the same fields but different values for the following fields will
        /// fail as well:
        /// * name
        /// * create_time
        /// * update_time
        /// * labels
        /// * description
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<VpcFlowLogsConfig, OperationMetadata> CreateVpcFlowLogsConfig(CreateVpcFlowLogsConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new `VpcFlowLogsConfig`.
        /// If a configuration with the exact same settings already exists (even if the
        /// ID is different), the creation fails.
        /// Notes:
        /// 
        /// 1. Creating a configuration with state=DISABLED will fail
        /// 2. The following fields are not considered as `settings` for the purpose
        /// of the check mentioned above, therefore - creating another configuration
        /// with the same fields but different values for the following fields will
        /// fail as well:
        /// * name
        /// * create_time
        /// * update_time
        /// * labels
        /// * description
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<VpcFlowLogsConfig, OperationMetadata>> CreateVpcFlowLogsConfigAsync(CreateVpcFlowLogsConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new `VpcFlowLogsConfig`.
        /// If a configuration with the exact same settings already exists (even if the
        /// ID is different), the creation fails.
        /// Notes:
        /// 
        /// 1. Creating a configuration with state=DISABLED will fail
        /// 2. The following fields are not considered as `settings` for the purpose
        /// of the check mentioned above, therefore - creating another configuration
        /// with the same fields but different values for the following fields will
        /// fail as well:
        /// * name
        /// * create_time
        /// * update_time
        /// * labels
        /// * description
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<VpcFlowLogsConfig, OperationMetadata>> CreateVpcFlowLogsConfigAsync(CreateVpcFlowLogsConfigRequest request, st::CancellationToken cancellationToken) =>
            CreateVpcFlowLogsConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateVpcFlowLogsConfig</c>.</summary>
        public virtual lro::OperationsClient CreateVpcFlowLogsConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateVpcFlowLogsConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<VpcFlowLogsConfig, OperationMetadata> PollOnceCreateVpcFlowLogsConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<VpcFlowLogsConfig, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateVpcFlowLogsConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateVpcFlowLogsConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<VpcFlowLogsConfig, OperationMetadata>> PollOnceCreateVpcFlowLogsConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<VpcFlowLogsConfig, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateVpcFlowLogsConfigOperationsClient, callSettings);

        /// <summary>
        /// Creates a new `VpcFlowLogsConfig`.
        /// If a configuration with the exact same settings already exists (even if the
        /// ID is different), the creation fails.
        /// Notes:
        /// 
        /// 1. Creating a configuration with state=DISABLED will fail
        /// 2. The following fields are not considered as `settings` for the purpose
        /// of the check mentioned above, therefore - creating another configuration
        /// with the same fields but different values for the following fields will
        /// fail as well:
        /// * name
        /// * create_time
        /// * update_time
        /// * labels
        /// * description
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the VPC Flow Logs configuration to create:
        /// `projects/{project_id}/locations/global`
        /// </param>
        /// <param name="vpcFlowLogsConfig">
        /// Required. A `VpcFlowLogsConfig` resource
        /// </param>
        /// <param name="vpcFlowLogsConfigId">
        /// Required. ID of the `VpcFlowLogsConfig`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<VpcFlowLogsConfig, OperationMetadata> CreateVpcFlowLogsConfig(string parent, VpcFlowLogsConfig vpcFlowLogsConfig, string vpcFlowLogsConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateVpcFlowLogsConfig(new CreateVpcFlowLogsConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                VpcFlowLogsConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(vpcFlowLogsConfigId, nameof(vpcFlowLogsConfigId)),
                VpcFlowLogsConfig = gax::GaxPreconditions.CheckNotNull(vpcFlowLogsConfig, nameof(vpcFlowLogsConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new `VpcFlowLogsConfig`.
        /// If a configuration with the exact same settings already exists (even if the
        /// ID is different), the creation fails.
        /// Notes:
        /// 
        /// 1. Creating a configuration with state=DISABLED will fail
        /// 2. The following fields are not considered as `settings` for the purpose
        /// of the check mentioned above, therefore - creating another configuration
        /// with the same fields but different values for the following fields will
        /// fail as well:
        /// * name
        /// * create_time
        /// * update_time
        /// * labels
        /// * description
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the VPC Flow Logs configuration to create:
        /// `projects/{project_id}/locations/global`
        /// </param>
        /// <param name="vpcFlowLogsConfig">
        /// Required. A `VpcFlowLogsConfig` resource
        /// </param>
        /// <param name="vpcFlowLogsConfigId">
        /// Required. ID of the `VpcFlowLogsConfig`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<VpcFlowLogsConfig, OperationMetadata>> CreateVpcFlowLogsConfigAsync(string parent, VpcFlowLogsConfig vpcFlowLogsConfig, string vpcFlowLogsConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateVpcFlowLogsConfigAsync(new CreateVpcFlowLogsConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                VpcFlowLogsConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(vpcFlowLogsConfigId, nameof(vpcFlowLogsConfigId)),
                VpcFlowLogsConfig = gax::GaxPreconditions.CheckNotNull(vpcFlowLogsConfig, nameof(vpcFlowLogsConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new `VpcFlowLogsConfig`.
        /// If a configuration with the exact same settings already exists (even if the
        /// ID is different), the creation fails.
        /// Notes:
        /// 
        /// 1. Creating a configuration with state=DISABLED will fail
        /// 2. The following fields are not considered as `settings` for the purpose
        /// of the check mentioned above, therefore - creating another configuration
        /// with the same fields but different values for the following fields will
        /// fail as well:
        /// * name
        /// * create_time
        /// * update_time
        /// * labels
        /// * description
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the VPC Flow Logs configuration to create:
        /// `projects/{project_id}/locations/global`
        /// </param>
        /// <param name="vpcFlowLogsConfig">
        /// Required. A `VpcFlowLogsConfig` resource
        /// </param>
        /// <param name="vpcFlowLogsConfigId">
        /// Required. ID of the `VpcFlowLogsConfig`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<VpcFlowLogsConfig, OperationMetadata>> CreateVpcFlowLogsConfigAsync(string parent, VpcFlowLogsConfig vpcFlowLogsConfig, string vpcFlowLogsConfigId, st::CancellationToken cancellationToken) =>
            CreateVpcFlowLogsConfigAsync(parent, vpcFlowLogsConfig, vpcFlowLogsConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new `VpcFlowLogsConfig`.
        /// If a configuration with the exact same settings already exists (even if the
        /// ID is different), the creation fails.
        /// Notes:
        /// 
        /// 1. Creating a configuration with state=DISABLED will fail
        /// 2. The following fields are not considered as `settings` for the purpose
        /// of the check mentioned above, therefore - creating another configuration
        /// with the same fields but different values for the following fields will
        /// fail as well:
        /// * name
        /// * create_time
        /// * update_time
        /// * labels
        /// * description
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the VPC Flow Logs configuration to create:
        /// `projects/{project_id}/locations/global`
        /// </param>
        /// <param name="vpcFlowLogsConfig">
        /// Required. A `VpcFlowLogsConfig` resource
        /// </param>
        /// <param name="vpcFlowLogsConfigId">
        /// Required. ID of the `VpcFlowLogsConfig`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<VpcFlowLogsConfig, OperationMetadata> CreateVpcFlowLogsConfig(gagr::LocationName parent, VpcFlowLogsConfig vpcFlowLogsConfig, VpcFlowLogsConfigName vpcFlowLogsConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateVpcFlowLogsConfig(new CreateVpcFlowLogsConfigRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                VpcFlowLogsConfigIdAsVpcFlowLogsConfigName = gax::GaxPreconditions.CheckNotNull(vpcFlowLogsConfigId, nameof(vpcFlowLogsConfigId)),
                VpcFlowLogsConfig = gax::GaxPreconditions.CheckNotNull(vpcFlowLogsConfig, nameof(vpcFlowLogsConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new `VpcFlowLogsConfig`.
        /// If a configuration with the exact same settings already exists (even if the
        /// ID is different), the creation fails.
        /// Notes:
        /// 
        /// 1. Creating a configuration with state=DISABLED will fail
        /// 2. The following fields are not considered as `settings` for the purpose
        /// of the check mentioned above, therefore - creating another configuration
        /// with the same fields but different values for the following fields will
        /// fail as well:
        /// * name
        /// * create_time
        /// * update_time
        /// * labels
        /// * description
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the VPC Flow Logs configuration to create:
        /// `projects/{project_id}/locations/global`
        /// </param>
        /// <param name="vpcFlowLogsConfig">
        /// Required. A `VpcFlowLogsConfig` resource
        /// </param>
        /// <param name="vpcFlowLogsConfigId">
        /// Required. ID of the `VpcFlowLogsConfig`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<VpcFlowLogsConfig, OperationMetadata>> CreateVpcFlowLogsConfigAsync(gagr::LocationName parent, VpcFlowLogsConfig vpcFlowLogsConfig, VpcFlowLogsConfigName vpcFlowLogsConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateVpcFlowLogsConfigAsync(new CreateVpcFlowLogsConfigRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                VpcFlowLogsConfigIdAsVpcFlowLogsConfigName = gax::GaxPreconditions.CheckNotNull(vpcFlowLogsConfigId, nameof(vpcFlowLogsConfigId)),
                VpcFlowLogsConfig = gax::GaxPreconditions.CheckNotNull(vpcFlowLogsConfig, nameof(vpcFlowLogsConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new `VpcFlowLogsConfig`.
        /// If a configuration with the exact same settings already exists (even if the
        /// ID is different), the creation fails.
        /// Notes:
        /// 
        /// 1. Creating a configuration with state=DISABLED will fail
        /// 2. The following fields are not considered as `settings` for the purpose
        /// of the check mentioned above, therefore - creating another configuration
        /// with the same fields but different values for the following fields will
        /// fail as well:
        /// * name
        /// * create_time
        /// * update_time
        /// * labels
        /// * description
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the VPC Flow Logs configuration to create:
        /// `projects/{project_id}/locations/global`
        /// </param>
        /// <param name="vpcFlowLogsConfig">
        /// Required. A `VpcFlowLogsConfig` resource
        /// </param>
        /// <param name="vpcFlowLogsConfigId">
        /// Required. ID of the `VpcFlowLogsConfig`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<VpcFlowLogsConfig, OperationMetadata>> CreateVpcFlowLogsConfigAsync(gagr::LocationName parent, VpcFlowLogsConfig vpcFlowLogsConfig, VpcFlowLogsConfigName vpcFlowLogsConfigId, st::CancellationToken cancellationToken) =>
            CreateVpcFlowLogsConfigAsync(parent, vpcFlowLogsConfig, vpcFlowLogsConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing `VpcFlowLogsConfig`.
        /// If a configuration with the exact same settings already exists (even if the
        /// ID is different), the creation fails.
        /// Notes:
        /// 
        /// 1. Updating a configuration with state=DISABLED will fail.
        /// 2. The following fields are not considered as `settings` for the purpose
        /// of the check mentioned above, therefore - updating another configuration
        /// with the same fields but different values for the following fields will
        /// fail as well:
        /// * name
        /// * create_time
        /// * update_time
        /// * labels
        /// * description
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<VpcFlowLogsConfig, OperationMetadata> UpdateVpcFlowLogsConfig(UpdateVpcFlowLogsConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing `VpcFlowLogsConfig`.
        /// If a configuration with the exact same settings already exists (even if the
        /// ID is different), the creation fails.
        /// Notes:
        /// 
        /// 1. Updating a configuration with state=DISABLED will fail.
        /// 2. The following fields are not considered as `settings` for the purpose
        /// of the check mentioned above, therefore - updating another configuration
        /// with the same fields but different values for the following fields will
        /// fail as well:
        /// * name
        /// * create_time
        /// * update_time
        /// * labels
        /// * description
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<VpcFlowLogsConfig, OperationMetadata>> UpdateVpcFlowLogsConfigAsync(UpdateVpcFlowLogsConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing `VpcFlowLogsConfig`.
        /// If a configuration with the exact same settings already exists (even if the
        /// ID is different), the creation fails.
        /// Notes:
        /// 
        /// 1. Updating a configuration with state=DISABLED will fail.
        /// 2. The following fields are not considered as `settings` for the purpose
        /// of the check mentioned above, therefore - updating another configuration
        /// with the same fields but different values for the following fields will
        /// fail as well:
        /// * name
        /// * create_time
        /// * update_time
        /// * labels
        /// * description
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<VpcFlowLogsConfig, OperationMetadata>> UpdateVpcFlowLogsConfigAsync(UpdateVpcFlowLogsConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateVpcFlowLogsConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateVpcFlowLogsConfig</c>.</summary>
        public virtual lro::OperationsClient UpdateVpcFlowLogsConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateVpcFlowLogsConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<VpcFlowLogsConfig, OperationMetadata> PollOnceUpdateVpcFlowLogsConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<VpcFlowLogsConfig, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateVpcFlowLogsConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateVpcFlowLogsConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<VpcFlowLogsConfig, OperationMetadata>> PollOnceUpdateVpcFlowLogsConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<VpcFlowLogsConfig, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateVpcFlowLogsConfigOperationsClient, callSettings);

        /// <summary>
        /// Updates an existing `VpcFlowLogsConfig`.
        /// If a configuration with the exact same settings already exists (even if the
        /// ID is different), the creation fails.
        /// Notes:
        /// 
        /// 1. Updating a configuration with state=DISABLED will fail.
        /// 2. The following fields are not considered as `settings` for the purpose
        /// of the check mentioned above, therefore - updating another configuration
        /// with the same fields but different values for the following fields will
        /// fail as well:
        /// * name
        /// * create_time
        /// * update_time
        /// * labels
        /// * description
        /// </summary>
        /// <param name="vpcFlowLogsConfig">
        /// Required. Only fields specified in update_mask are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<VpcFlowLogsConfig, OperationMetadata> UpdateVpcFlowLogsConfig(VpcFlowLogsConfig vpcFlowLogsConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateVpcFlowLogsConfig(new UpdateVpcFlowLogsConfigRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                VpcFlowLogsConfig = gax::GaxPreconditions.CheckNotNull(vpcFlowLogsConfig, nameof(vpcFlowLogsConfig)),
            }, callSettings);

        /// <summary>
        /// Updates an existing `VpcFlowLogsConfig`.
        /// If a configuration with the exact same settings already exists (even if the
        /// ID is different), the creation fails.
        /// Notes:
        /// 
        /// 1. Updating a configuration with state=DISABLED will fail.
        /// 2. The following fields are not considered as `settings` for the purpose
        /// of the check mentioned above, therefore - updating another configuration
        /// with the same fields but different values for the following fields will
        /// fail as well:
        /// * name
        /// * create_time
        /// * update_time
        /// * labels
        /// * description
        /// </summary>
        /// <param name="vpcFlowLogsConfig">
        /// Required. Only fields specified in update_mask are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<VpcFlowLogsConfig, OperationMetadata>> UpdateVpcFlowLogsConfigAsync(VpcFlowLogsConfig vpcFlowLogsConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateVpcFlowLogsConfigAsync(new UpdateVpcFlowLogsConfigRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                VpcFlowLogsConfig = gax::GaxPreconditions.CheckNotNull(vpcFlowLogsConfig, nameof(vpcFlowLogsConfig)),
            }, callSettings);

        /// <summary>
        /// Updates an existing `VpcFlowLogsConfig`.
        /// If a configuration with the exact same settings already exists (even if the
        /// ID is different), the creation fails.
        /// Notes:
        /// 
        /// 1. Updating a configuration with state=DISABLED will fail.
        /// 2. The following fields are not considered as `settings` for the purpose
        /// of the check mentioned above, therefore - updating another configuration
        /// with the same fields but different values for the following fields will
        /// fail as well:
        /// * name
        /// * create_time
        /// * update_time
        /// * labels
        /// * description
        /// </summary>
        /// <param name="vpcFlowLogsConfig">
        /// Required. Only fields specified in update_mask are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<VpcFlowLogsConfig, OperationMetadata>> UpdateVpcFlowLogsConfigAsync(VpcFlowLogsConfig vpcFlowLogsConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateVpcFlowLogsConfigAsync(vpcFlowLogsConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a specific `VpcFlowLogsConfig`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteVpcFlowLogsConfig(DeleteVpcFlowLogsConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a specific `VpcFlowLogsConfig`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteVpcFlowLogsConfigAsync(DeleteVpcFlowLogsConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a specific `VpcFlowLogsConfig`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteVpcFlowLogsConfigAsync(DeleteVpcFlowLogsConfigRequest request, st::CancellationToken cancellationToken) =>
            DeleteVpcFlowLogsConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteVpcFlowLogsConfig</c>.</summary>
        public virtual lro::OperationsClient DeleteVpcFlowLogsConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteVpcFlowLogsConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteVpcFlowLogsConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteVpcFlowLogsConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteVpcFlowLogsConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteVpcFlowLogsConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteVpcFlowLogsConfigOperationsClient, callSettings);

        /// <summary>
        /// Deletes a specific `VpcFlowLogsConfig`.
        /// </summary>
        /// <param name="name">
        /// Required. `VpcFlowLogsConfig` resource name using the form:
        /// `projects/{project_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteVpcFlowLogsConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVpcFlowLogsConfig(new DeleteVpcFlowLogsConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific `VpcFlowLogsConfig`.
        /// </summary>
        /// <param name="name">
        /// Required. `VpcFlowLogsConfig` resource name using the form:
        /// `projects/{project_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteVpcFlowLogsConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVpcFlowLogsConfigAsync(new DeleteVpcFlowLogsConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific `VpcFlowLogsConfig`.
        /// </summary>
        /// <param name="name">
        /// Required. `VpcFlowLogsConfig` resource name using the form:
        /// `projects/{project_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteVpcFlowLogsConfigAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteVpcFlowLogsConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a specific `VpcFlowLogsConfig`.
        /// </summary>
        /// <param name="name">
        /// Required. `VpcFlowLogsConfig` resource name using the form:
        /// `projects/{project_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteVpcFlowLogsConfig(VpcFlowLogsConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVpcFlowLogsConfig(new DeleteVpcFlowLogsConfigRequest
            {
                VpcFlowLogsConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific `VpcFlowLogsConfig`.
        /// </summary>
        /// <param name="name">
        /// Required. `VpcFlowLogsConfig` resource name using the form:
        /// `projects/{project_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteVpcFlowLogsConfigAsync(VpcFlowLogsConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVpcFlowLogsConfigAsync(new DeleteVpcFlowLogsConfigRequest
            {
                VpcFlowLogsConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific `VpcFlowLogsConfig`.
        /// </summary>
        /// <param name="name">
        /// Required. `VpcFlowLogsConfig` resource name using the form:
        /// `projects/{project_id}/locations/global/vpcFlowLogsConfigs/{vpc_flow_logs_config}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteVpcFlowLogsConfigAsync(VpcFlowLogsConfigName name, st::CancellationToken cancellationToken) =>
            DeleteVpcFlowLogsConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>VpcFlowLogsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The VPC Flow Logs service in the Google Cloud Network Management API provides
    /// configurations that generate Flow Logs. The service and the configuration
    /// resources created using this service are global.
    /// </remarks>
    public sealed partial class VpcFlowLogsServiceClientImpl : VpcFlowLogsServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListVpcFlowLogsConfigsRequest, ListVpcFlowLogsConfigsResponse> _callListVpcFlowLogsConfigs;

        private readonly gaxgrpc::ApiCall<GetVpcFlowLogsConfigRequest, VpcFlowLogsConfig> _callGetVpcFlowLogsConfig;

        private readonly gaxgrpc::ApiCall<CreateVpcFlowLogsConfigRequest, lro::Operation> _callCreateVpcFlowLogsConfig;

        private readonly gaxgrpc::ApiCall<UpdateVpcFlowLogsConfigRequest, lro::Operation> _callUpdateVpcFlowLogsConfig;

        private readonly gaxgrpc::ApiCall<DeleteVpcFlowLogsConfigRequest, lro::Operation> _callDeleteVpcFlowLogsConfig;

        /// <summary>
        /// Constructs a client wrapper for the VpcFlowLogsService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="VpcFlowLogsServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public VpcFlowLogsServiceClientImpl(VpcFlowLogsService.VpcFlowLogsServiceClient grpcClient, VpcFlowLogsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            VpcFlowLogsServiceSettings effectiveSettings = settings ?? VpcFlowLogsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateVpcFlowLogsConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateVpcFlowLogsConfigOperationsSettings, logger);
            UpdateVpcFlowLogsConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateVpcFlowLogsConfigOperationsSettings, logger);
            DeleteVpcFlowLogsConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteVpcFlowLogsConfigOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListVpcFlowLogsConfigs = clientHelper.BuildApiCall<ListVpcFlowLogsConfigsRequest, ListVpcFlowLogsConfigsResponse>("ListVpcFlowLogsConfigs", grpcClient.ListVpcFlowLogsConfigsAsync, grpcClient.ListVpcFlowLogsConfigs, effectiveSettings.ListVpcFlowLogsConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListVpcFlowLogsConfigs);
            Modify_ListVpcFlowLogsConfigsApiCall(ref _callListVpcFlowLogsConfigs);
            _callGetVpcFlowLogsConfig = clientHelper.BuildApiCall<GetVpcFlowLogsConfigRequest, VpcFlowLogsConfig>("GetVpcFlowLogsConfig", grpcClient.GetVpcFlowLogsConfigAsync, grpcClient.GetVpcFlowLogsConfig, effectiveSettings.GetVpcFlowLogsConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetVpcFlowLogsConfig);
            Modify_GetVpcFlowLogsConfigApiCall(ref _callGetVpcFlowLogsConfig);
            _callCreateVpcFlowLogsConfig = clientHelper.BuildApiCall<CreateVpcFlowLogsConfigRequest, lro::Operation>("CreateVpcFlowLogsConfig", grpcClient.CreateVpcFlowLogsConfigAsync, grpcClient.CreateVpcFlowLogsConfig, effectiveSettings.CreateVpcFlowLogsConfigSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateVpcFlowLogsConfig);
            Modify_CreateVpcFlowLogsConfigApiCall(ref _callCreateVpcFlowLogsConfig);
            _callUpdateVpcFlowLogsConfig = clientHelper.BuildApiCall<UpdateVpcFlowLogsConfigRequest, lro::Operation>("UpdateVpcFlowLogsConfig", grpcClient.UpdateVpcFlowLogsConfigAsync, grpcClient.UpdateVpcFlowLogsConfig, effectiveSettings.UpdateVpcFlowLogsConfigSettings).WithGoogleRequestParam("vpc_flow_logs_config.name", request => request.VpcFlowLogsConfig?.Name);
            Modify_ApiCall(ref _callUpdateVpcFlowLogsConfig);
            Modify_UpdateVpcFlowLogsConfigApiCall(ref _callUpdateVpcFlowLogsConfig);
            _callDeleteVpcFlowLogsConfig = clientHelper.BuildApiCall<DeleteVpcFlowLogsConfigRequest, lro::Operation>("DeleteVpcFlowLogsConfig", grpcClient.DeleteVpcFlowLogsConfigAsync, grpcClient.DeleteVpcFlowLogsConfig, effectiveSettings.DeleteVpcFlowLogsConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteVpcFlowLogsConfig);
            Modify_DeleteVpcFlowLogsConfigApiCall(ref _callDeleteVpcFlowLogsConfig);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListVpcFlowLogsConfigsApiCall(ref gaxgrpc::ApiCall<ListVpcFlowLogsConfigsRequest, ListVpcFlowLogsConfigsResponse> call);

        partial void Modify_GetVpcFlowLogsConfigApiCall(ref gaxgrpc::ApiCall<GetVpcFlowLogsConfigRequest, VpcFlowLogsConfig> call);

        partial void Modify_CreateVpcFlowLogsConfigApiCall(ref gaxgrpc::ApiCall<CreateVpcFlowLogsConfigRequest, lro::Operation> call);

        partial void Modify_UpdateVpcFlowLogsConfigApiCall(ref gaxgrpc::ApiCall<UpdateVpcFlowLogsConfigRequest, lro::Operation> call);

        partial void Modify_DeleteVpcFlowLogsConfigApiCall(ref gaxgrpc::ApiCall<DeleteVpcFlowLogsConfigRequest, lro::Operation> call);

        partial void OnConstruction(VpcFlowLogsService.VpcFlowLogsServiceClient grpcClient, VpcFlowLogsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC VpcFlowLogsService client</summary>
        public override VpcFlowLogsService.VpcFlowLogsServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListVpcFlowLogsConfigsRequest(ref ListVpcFlowLogsConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetVpcFlowLogsConfigRequest(ref GetVpcFlowLogsConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateVpcFlowLogsConfigRequest(ref CreateVpcFlowLogsConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateVpcFlowLogsConfigRequest(ref UpdateVpcFlowLogsConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteVpcFlowLogsConfigRequest(ref DeleteVpcFlowLogsConfigRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists all `VpcFlowLogsConfigs` in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="VpcFlowLogsConfig"/> resources.</returns>
        public override gax::PagedEnumerable<ListVpcFlowLogsConfigsResponse, VpcFlowLogsConfig> ListVpcFlowLogsConfigs(ListVpcFlowLogsConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVpcFlowLogsConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListVpcFlowLogsConfigsRequest, ListVpcFlowLogsConfigsResponse, VpcFlowLogsConfig>(_callListVpcFlowLogsConfigs, request, callSettings);
        }

        /// <summary>
        /// Lists all `VpcFlowLogsConfigs` in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="VpcFlowLogsConfig"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListVpcFlowLogsConfigsResponse, VpcFlowLogsConfig> ListVpcFlowLogsConfigsAsync(ListVpcFlowLogsConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVpcFlowLogsConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListVpcFlowLogsConfigsRequest, ListVpcFlowLogsConfigsResponse, VpcFlowLogsConfig>(_callListVpcFlowLogsConfigs, request, callSettings);
        }

        /// <summary>
        /// Gets the details of a specific `VpcFlowLogsConfig`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override VpcFlowLogsConfig GetVpcFlowLogsConfig(GetVpcFlowLogsConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVpcFlowLogsConfigRequest(ref request, ref callSettings);
            return _callGetVpcFlowLogsConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a specific `VpcFlowLogsConfig`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<VpcFlowLogsConfig> GetVpcFlowLogsConfigAsync(GetVpcFlowLogsConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVpcFlowLogsConfigRequest(ref request, ref callSettings);
            return _callGetVpcFlowLogsConfig.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateVpcFlowLogsConfig</c>.</summary>
        public override lro::OperationsClient CreateVpcFlowLogsConfigOperationsClient { get; }

        /// <summary>
        /// Creates a new `VpcFlowLogsConfig`.
        /// If a configuration with the exact same settings already exists (even if the
        /// ID is different), the creation fails.
        /// Notes:
        /// 
        /// 1. Creating a configuration with state=DISABLED will fail
        /// 2. The following fields are not considered as `settings` for the purpose
        /// of the check mentioned above, therefore - creating another configuration
        /// with the same fields but different values for the following fields will
        /// fail as well:
        /// * name
        /// * create_time
        /// * update_time
        /// * labels
        /// * description
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<VpcFlowLogsConfig, OperationMetadata> CreateVpcFlowLogsConfig(CreateVpcFlowLogsConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateVpcFlowLogsConfigRequest(ref request, ref callSettings);
            return new lro::Operation<VpcFlowLogsConfig, OperationMetadata>(_callCreateVpcFlowLogsConfig.Sync(request, callSettings), CreateVpcFlowLogsConfigOperationsClient);
        }

        /// <summary>
        /// Creates a new `VpcFlowLogsConfig`.
        /// If a configuration with the exact same settings already exists (even if the
        /// ID is different), the creation fails.
        /// Notes:
        /// 
        /// 1. Creating a configuration with state=DISABLED will fail
        /// 2. The following fields are not considered as `settings` for the purpose
        /// of the check mentioned above, therefore - creating another configuration
        /// with the same fields but different values for the following fields will
        /// fail as well:
        /// * name
        /// * create_time
        /// * update_time
        /// * labels
        /// * description
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<VpcFlowLogsConfig, OperationMetadata>> CreateVpcFlowLogsConfigAsync(CreateVpcFlowLogsConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateVpcFlowLogsConfigRequest(ref request, ref callSettings);
            return new lro::Operation<VpcFlowLogsConfig, OperationMetadata>(await _callCreateVpcFlowLogsConfig.Async(request, callSettings).ConfigureAwait(false), CreateVpcFlowLogsConfigOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateVpcFlowLogsConfig</c>.</summary>
        public override lro::OperationsClient UpdateVpcFlowLogsConfigOperationsClient { get; }

        /// <summary>
        /// Updates an existing `VpcFlowLogsConfig`.
        /// If a configuration with the exact same settings already exists (even if the
        /// ID is different), the creation fails.
        /// Notes:
        /// 
        /// 1. Updating a configuration with state=DISABLED will fail.
        /// 2. The following fields are not considered as `settings` for the purpose
        /// of the check mentioned above, therefore - updating another configuration
        /// with the same fields but different values for the following fields will
        /// fail as well:
        /// * name
        /// * create_time
        /// * update_time
        /// * labels
        /// * description
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<VpcFlowLogsConfig, OperationMetadata> UpdateVpcFlowLogsConfig(UpdateVpcFlowLogsConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateVpcFlowLogsConfigRequest(ref request, ref callSettings);
            return new lro::Operation<VpcFlowLogsConfig, OperationMetadata>(_callUpdateVpcFlowLogsConfig.Sync(request, callSettings), UpdateVpcFlowLogsConfigOperationsClient);
        }

        /// <summary>
        /// Updates an existing `VpcFlowLogsConfig`.
        /// If a configuration with the exact same settings already exists (even if the
        /// ID is different), the creation fails.
        /// Notes:
        /// 
        /// 1. Updating a configuration with state=DISABLED will fail.
        /// 2. The following fields are not considered as `settings` for the purpose
        /// of the check mentioned above, therefore - updating another configuration
        /// with the same fields but different values for the following fields will
        /// fail as well:
        /// * name
        /// * create_time
        /// * update_time
        /// * labels
        /// * description
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<VpcFlowLogsConfig, OperationMetadata>> UpdateVpcFlowLogsConfigAsync(UpdateVpcFlowLogsConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateVpcFlowLogsConfigRequest(ref request, ref callSettings);
            return new lro::Operation<VpcFlowLogsConfig, OperationMetadata>(await _callUpdateVpcFlowLogsConfig.Async(request, callSettings).ConfigureAwait(false), UpdateVpcFlowLogsConfigOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteVpcFlowLogsConfig</c>.</summary>
        public override lro::OperationsClient DeleteVpcFlowLogsConfigOperationsClient { get; }

        /// <summary>
        /// Deletes a specific `VpcFlowLogsConfig`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteVpcFlowLogsConfig(DeleteVpcFlowLogsConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteVpcFlowLogsConfigRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteVpcFlowLogsConfig.Sync(request, callSettings), DeleteVpcFlowLogsConfigOperationsClient);
        }

        /// <summary>
        /// Deletes a specific `VpcFlowLogsConfig`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteVpcFlowLogsConfigAsync(DeleteVpcFlowLogsConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteVpcFlowLogsConfigRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteVpcFlowLogsConfig.Async(request, callSettings).ConfigureAwait(false), DeleteVpcFlowLogsConfigOperationsClient);
        }
    }

    public partial class ListVpcFlowLogsConfigsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListVpcFlowLogsConfigsResponse : gaxgrpc::IPageResponse<VpcFlowLogsConfig>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<VpcFlowLogsConfig> GetEnumerator() => VpcFlowLogsConfigs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class VpcFlowLogsService
    {
        public partial class VpcFlowLogsServiceClient
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

    public static partial class VpcFlowLogsService
    {
        public partial class VpcFlowLogsServiceClient
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
