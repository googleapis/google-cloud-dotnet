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

namespace Google.Cloud.NetworkConnectivity.V1
{
    /// <summary>Settings for <see cref="DataTransferServiceClient"/> instances.</summary>
    public sealed partial class DataTransferServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DataTransferServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DataTransferServiceSettings"/>.</returns>
        public static DataTransferServiceSettings GetDefault() => new DataTransferServiceSettings();

        /// <summary>Constructs a new <see cref="DataTransferServiceSettings"/> object with default settings.</summary>
        public DataTransferServiceSettings()
        {
        }

        private DataTransferServiceSettings(DataTransferServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListMulticloudDataTransferConfigsSettings = existing.ListMulticloudDataTransferConfigsSettings;
            GetMulticloudDataTransferConfigSettings = existing.GetMulticloudDataTransferConfigSettings;
            CreateMulticloudDataTransferConfigSettings = existing.CreateMulticloudDataTransferConfigSettings;
            CreateMulticloudDataTransferConfigOperationsSettings = existing.CreateMulticloudDataTransferConfigOperationsSettings.Clone();
            UpdateMulticloudDataTransferConfigSettings = existing.UpdateMulticloudDataTransferConfigSettings;
            UpdateMulticloudDataTransferConfigOperationsSettings = existing.UpdateMulticloudDataTransferConfigOperationsSettings.Clone();
            DeleteMulticloudDataTransferConfigSettings = existing.DeleteMulticloudDataTransferConfigSettings;
            DeleteMulticloudDataTransferConfigOperationsSettings = existing.DeleteMulticloudDataTransferConfigOperationsSettings.Clone();
            ListDestinationsSettings = existing.ListDestinationsSettings;
            GetDestinationSettings = existing.GetDestinationSettings;
            CreateDestinationSettings = existing.CreateDestinationSettings;
            CreateDestinationOperationsSettings = existing.CreateDestinationOperationsSettings.Clone();
            UpdateDestinationSettings = existing.UpdateDestinationSettings;
            UpdateDestinationOperationsSettings = existing.UpdateDestinationOperationsSettings.Clone();
            DeleteDestinationSettings = existing.DeleteDestinationSettings;
            DeleteDestinationOperationsSettings = existing.DeleteDestinationOperationsSettings.Clone();
            GetMulticloudDataTransferSupportedServiceSettings = existing.GetMulticloudDataTransferSupportedServiceSettings;
            ListMulticloudDataTransferSupportedServicesSettings = existing.ListMulticloudDataTransferSupportedServicesSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(DataTransferServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.ListMulticloudDataTransferConfigs</c> and
        /// <c>DataTransferServiceClient.ListMulticloudDataTransferConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListMulticloudDataTransferConfigsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.GetMulticloudDataTransferConfig</c> and
        /// <c>DataTransferServiceClient.GetMulticloudDataTransferConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMulticloudDataTransferConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.CreateMulticloudDataTransferConfig</c> and
        /// <c>DataTransferServiceClient.CreateMulticloudDataTransferConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateMulticloudDataTransferConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataTransferServiceClient.CreateMulticloudDataTransferConfig</c>
        ///  and <c>DataTransferServiceClient.CreateMulticloudDataTransferConfigAsync</c>.
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
        public lro::OperationsSettings CreateMulticloudDataTransferConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.UpdateMulticloudDataTransferConfig</c> and
        /// <c>DataTransferServiceClient.UpdateMulticloudDataTransferConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateMulticloudDataTransferConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataTransferServiceClient.UpdateMulticloudDataTransferConfig</c>
        ///  and <c>DataTransferServiceClient.UpdateMulticloudDataTransferConfigAsync</c>.
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
        public lro::OperationsSettings UpdateMulticloudDataTransferConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.DeleteMulticloudDataTransferConfig</c> and
        /// <c>DataTransferServiceClient.DeleteMulticloudDataTransferConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteMulticloudDataTransferConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataTransferServiceClient.DeleteMulticloudDataTransferConfig</c>
        ///  and <c>DataTransferServiceClient.DeleteMulticloudDataTransferConfigAsync</c>.
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
        public lro::OperationsSettings DeleteMulticloudDataTransferConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.ListDestinations</c> and <c>DataTransferServiceClient.ListDestinationsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDestinationsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.GetDestination</c> and <c>DataTransferServiceClient.GetDestinationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDestinationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.CreateDestination</c> and <c>DataTransferServiceClient.CreateDestinationAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDestinationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataTransferServiceClient.CreateDestination</c> and
        /// <c>DataTransferServiceClient.CreateDestinationAsync</c>.
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
        public lro::OperationsSettings CreateDestinationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.UpdateDestination</c> and <c>DataTransferServiceClient.UpdateDestinationAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDestinationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataTransferServiceClient.UpdateDestination</c> and
        /// <c>DataTransferServiceClient.UpdateDestinationAsync</c>.
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
        public lro::OperationsSettings UpdateDestinationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.DeleteDestination</c> and <c>DataTransferServiceClient.DeleteDestinationAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDestinationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataTransferServiceClient.DeleteDestination</c> and
        /// <c>DataTransferServiceClient.DeleteDestinationAsync</c>.
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
        public lro::OperationsSettings DeleteDestinationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.GetMulticloudDataTransferSupportedService</c> and
        /// <c>DataTransferServiceClient.GetMulticloudDataTransferSupportedServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMulticloudDataTransferSupportedServiceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTransferServiceClient.ListMulticloudDataTransferSupportedServices</c> and
        /// <c>DataTransferServiceClient.ListMulticloudDataTransferSupportedServicesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListMulticloudDataTransferSupportedServicesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DataTransferServiceSettings"/> object.</returns>
        public DataTransferServiceSettings Clone() => new DataTransferServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DataTransferServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class DataTransferServiceClientBuilder : gaxgrpc::ClientBuilderBase<DataTransferServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DataTransferServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DataTransferServiceClientBuilder() : base(DataTransferServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DataTransferServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DataTransferServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DataTransferServiceClient Build()
        {
            DataTransferServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DataTransferServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DataTransferServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DataTransferServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DataTransferServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DataTransferServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DataTransferServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DataTransferServiceClient.ChannelPool;
    }

    /// <summary>DataTransferService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// DataTransferService is the service for the Data Transfer API.
    /// </remarks>
    public abstract partial class DataTransferServiceClient
    {
        /// <summary>
        /// The default endpoint for the DataTransferService service, which is a host of
        /// "networkconnectivity.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "networkconnectivity.googleapis.com:443";

        /// <summary>The default DataTransferService scopes.</summary>
        /// <remarks>
        /// The default DataTransferService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DataTransferService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DataTransferServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="DataTransferServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DataTransferServiceClient"/>.</returns>
        public static stt::Task<DataTransferServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DataTransferServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DataTransferServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="DataTransferServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DataTransferServiceClient"/>.</returns>
        public static DataTransferServiceClient Create() => new DataTransferServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DataTransferServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DataTransferServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DataTransferServiceClient"/>.</returns>
        internal static DataTransferServiceClient Create(grpccore::CallInvoker callInvoker, DataTransferServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DataTransferService.DataTransferServiceClient grpcClient = new DataTransferService.DataTransferServiceClient(callInvoker);
            return new DataTransferServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DataTransferService client</summary>
        public virtual DataTransferService.DataTransferServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the `MulticloudDataTransferConfig` resources in a specified project
        /// and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MulticloudDataTransferConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMulticloudDataTransferConfigsResponse, MulticloudDataTransferConfig> ListMulticloudDataTransferConfigs(ListMulticloudDataTransferConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the `MulticloudDataTransferConfig` resources in a specified project
        /// and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MulticloudDataTransferConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMulticloudDataTransferConfigsResponse, MulticloudDataTransferConfig> ListMulticloudDataTransferConfigsAsync(ListMulticloudDataTransferConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the `MulticloudDataTransferConfig` resources in a specified project
        /// and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource.
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
        /// <returns>A pageable sequence of <see cref="MulticloudDataTransferConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMulticloudDataTransferConfigsResponse, MulticloudDataTransferConfig> ListMulticloudDataTransferConfigs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMulticloudDataTransferConfigsRequest request = new ListMulticloudDataTransferConfigsRequest
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
            return ListMulticloudDataTransferConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists the `MulticloudDataTransferConfig` resources in a specified project
        /// and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource.
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
        /// <returns>A pageable asynchronous sequence of <see cref="MulticloudDataTransferConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMulticloudDataTransferConfigsResponse, MulticloudDataTransferConfig> ListMulticloudDataTransferConfigsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMulticloudDataTransferConfigsRequest request = new ListMulticloudDataTransferConfigsRequest
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
            return ListMulticloudDataTransferConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the `MulticloudDataTransferConfig` resources in a specified project
        /// and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource.
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
        /// <returns>A pageable sequence of <see cref="MulticloudDataTransferConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMulticloudDataTransferConfigsResponse, MulticloudDataTransferConfig> ListMulticloudDataTransferConfigs(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMulticloudDataTransferConfigsRequest request = new ListMulticloudDataTransferConfigsRequest
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
            return ListMulticloudDataTransferConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists the `MulticloudDataTransferConfig` resources in a specified project
        /// and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource.
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
        /// <returns>A pageable asynchronous sequence of <see cref="MulticloudDataTransferConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMulticloudDataTransferConfigsResponse, MulticloudDataTransferConfig> ListMulticloudDataTransferConfigsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMulticloudDataTransferConfigsRequest request = new ListMulticloudDataTransferConfigsRequest
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
            return ListMulticloudDataTransferConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a `MulticloudDataTransferConfig` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MulticloudDataTransferConfig GetMulticloudDataTransferConfig(GetMulticloudDataTransferConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a `MulticloudDataTransferConfig` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MulticloudDataTransferConfig> GetMulticloudDataTransferConfigAsync(GetMulticloudDataTransferConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a `MulticloudDataTransferConfig` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MulticloudDataTransferConfig> GetMulticloudDataTransferConfigAsync(GetMulticloudDataTransferConfigRequest request, st::CancellationToken cancellationToken) =>
            GetMulticloudDataTransferConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a `MulticloudDataTransferConfig` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `MulticloudDataTransferConfig` resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MulticloudDataTransferConfig GetMulticloudDataTransferConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMulticloudDataTransferConfig(new GetMulticloudDataTransferConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a `MulticloudDataTransferConfig` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `MulticloudDataTransferConfig` resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MulticloudDataTransferConfig> GetMulticloudDataTransferConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMulticloudDataTransferConfigAsync(new GetMulticloudDataTransferConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a `MulticloudDataTransferConfig` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `MulticloudDataTransferConfig` resource to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MulticloudDataTransferConfig> GetMulticloudDataTransferConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetMulticloudDataTransferConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a `MulticloudDataTransferConfig` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `MulticloudDataTransferConfig` resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MulticloudDataTransferConfig GetMulticloudDataTransferConfig(MulticloudDataTransferConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMulticloudDataTransferConfig(new GetMulticloudDataTransferConfigRequest
            {
                MulticloudDataTransferConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a `MulticloudDataTransferConfig` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `MulticloudDataTransferConfig` resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MulticloudDataTransferConfig> GetMulticloudDataTransferConfigAsync(MulticloudDataTransferConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMulticloudDataTransferConfigAsync(new GetMulticloudDataTransferConfigRequest
            {
                MulticloudDataTransferConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a `MulticloudDataTransferConfig` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `MulticloudDataTransferConfig` resource to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MulticloudDataTransferConfig> GetMulticloudDataTransferConfigAsync(MulticloudDataTransferConfigName name, st::CancellationToken cancellationToken) =>
            GetMulticloudDataTransferConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `MulticloudDataTransferConfig` resource in a specified project
        /// and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MulticloudDataTransferConfig, OperationMetadata> CreateMulticloudDataTransferConfig(CreateMulticloudDataTransferConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `MulticloudDataTransferConfig` resource in a specified project
        /// and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MulticloudDataTransferConfig, OperationMetadata>> CreateMulticloudDataTransferConfigAsync(CreateMulticloudDataTransferConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `MulticloudDataTransferConfig` resource in a specified project
        /// and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MulticloudDataTransferConfig, OperationMetadata>> CreateMulticloudDataTransferConfigAsync(CreateMulticloudDataTransferConfigRequest request, st::CancellationToken cancellationToken) =>
            CreateMulticloudDataTransferConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateMulticloudDataTransferConfig</c>.</summary>
        public virtual lro::OperationsClient CreateMulticloudDataTransferConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateMulticloudDataTransferConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MulticloudDataTransferConfig, OperationMetadata> PollOnceCreateMulticloudDataTransferConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MulticloudDataTransferConfig, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateMulticloudDataTransferConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateMulticloudDataTransferConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MulticloudDataTransferConfig, OperationMetadata>> PollOnceCreateMulticloudDataTransferConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MulticloudDataTransferConfig, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateMulticloudDataTransferConfigOperationsClient, callSettings);

        /// <summary>
        /// Creates a `MulticloudDataTransferConfig` resource in a specified project
        /// and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource.
        /// </param>
        /// <param name="multicloudDataTransferConfig">
        /// Required. The `MulticloudDataTransferConfig` resource to create.
        /// </param>
        /// <param name="multicloudDataTransferConfigId">
        /// Required. The ID to use for the `MulticloudDataTransferConfig` resource,
        /// which becomes the final component of the `MulticloudDataTransferConfig`
        /// resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MulticloudDataTransferConfig, OperationMetadata> CreateMulticloudDataTransferConfig(string parent, MulticloudDataTransferConfig multicloudDataTransferConfig, string multicloudDataTransferConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMulticloudDataTransferConfig(new CreateMulticloudDataTransferConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MulticloudDataTransferConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(multicloudDataTransferConfigId, nameof(multicloudDataTransferConfigId)),
                MulticloudDataTransferConfig = gax::GaxPreconditions.CheckNotNull(multicloudDataTransferConfig, nameof(multicloudDataTransferConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a `MulticloudDataTransferConfig` resource in a specified project
        /// and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource.
        /// </param>
        /// <param name="multicloudDataTransferConfig">
        /// Required. The `MulticloudDataTransferConfig` resource to create.
        /// </param>
        /// <param name="multicloudDataTransferConfigId">
        /// Required. The ID to use for the `MulticloudDataTransferConfig` resource,
        /// which becomes the final component of the `MulticloudDataTransferConfig`
        /// resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MulticloudDataTransferConfig, OperationMetadata>> CreateMulticloudDataTransferConfigAsync(string parent, MulticloudDataTransferConfig multicloudDataTransferConfig, string multicloudDataTransferConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMulticloudDataTransferConfigAsync(new CreateMulticloudDataTransferConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MulticloudDataTransferConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(multicloudDataTransferConfigId, nameof(multicloudDataTransferConfigId)),
                MulticloudDataTransferConfig = gax::GaxPreconditions.CheckNotNull(multicloudDataTransferConfig, nameof(multicloudDataTransferConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a `MulticloudDataTransferConfig` resource in a specified project
        /// and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource.
        /// </param>
        /// <param name="multicloudDataTransferConfig">
        /// Required. The `MulticloudDataTransferConfig` resource to create.
        /// </param>
        /// <param name="multicloudDataTransferConfigId">
        /// Required. The ID to use for the `MulticloudDataTransferConfig` resource,
        /// which becomes the final component of the `MulticloudDataTransferConfig`
        /// resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MulticloudDataTransferConfig, OperationMetadata>> CreateMulticloudDataTransferConfigAsync(string parent, MulticloudDataTransferConfig multicloudDataTransferConfig, string multicloudDataTransferConfigId, st::CancellationToken cancellationToken) =>
            CreateMulticloudDataTransferConfigAsync(parent, multicloudDataTransferConfig, multicloudDataTransferConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `MulticloudDataTransferConfig` resource in a specified project
        /// and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource.
        /// </param>
        /// <param name="multicloudDataTransferConfig">
        /// Required. The `MulticloudDataTransferConfig` resource to create.
        /// </param>
        /// <param name="multicloudDataTransferConfigId">
        /// Required. The ID to use for the `MulticloudDataTransferConfig` resource,
        /// which becomes the final component of the `MulticloudDataTransferConfig`
        /// resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MulticloudDataTransferConfig, OperationMetadata> CreateMulticloudDataTransferConfig(gagr::LocationName parent, MulticloudDataTransferConfig multicloudDataTransferConfig, string multicloudDataTransferConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMulticloudDataTransferConfig(new CreateMulticloudDataTransferConfigRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MulticloudDataTransferConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(multicloudDataTransferConfigId, nameof(multicloudDataTransferConfigId)),
                MulticloudDataTransferConfig = gax::GaxPreconditions.CheckNotNull(multicloudDataTransferConfig, nameof(multicloudDataTransferConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a `MulticloudDataTransferConfig` resource in a specified project
        /// and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource.
        /// </param>
        /// <param name="multicloudDataTransferConfig">
        /// Required. The `MulticloudDataTransferConfig` resource to create.
        /// </param>
        /// <param name="multicloudDataTransferConfigId">
        /// Required. The ID to use for the `MulticloudDataTransferConfig` resource,
        /// which becomes the final component of the `MulticloudDataTransferConfig`
        /// resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MulticloudDataTransferConfig, OperationMetadata>> CreateMulticloudDataTransferConfigAsync(gagr::LocationName parent, MulticloudDataTransferConfig multicloudDataTransferConfig, string multicloudDataTransferConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMulticloudDataTransferConfigAsync(new CreateMulticloudDataTransferConfigRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MulticloudDataTransferConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(multicloudDataTransferConfigId, nameof(multicloudDataTransferConfigId)),
                MulticloudDataTransferConfig = gax::GaxPreconditions.CheckNotNull(multicloudDataTransferConfig, nameof(multicloudDataTransferConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a `MulticloudDataTransferConfig` resource in a specified project
        /// and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource.
        /// </param>
        /// <param name="multicloudDataTransferConfig">
        /// Required. The `MulticloudDataTransferConfig` resource to create.
        /// </param>
        /// <param name="multicloudDataTransferConfigId">
        /// Required. The ID to use for the `MulticloudDataTransferConfig` resource,
        /// which becomes the final component of the `MulticloudDataTransferConfig`
        /// resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MulticloudDataTransferConfig, OperationMetadata>> CreateMulticloudDataTransferConfigAsync(gagr::LocationName parent, MulticloudDataTransferConfig multicloudDataTransferConfig, string multicloudDataTransferConfigId, st::CancellationToken cancellationToken) =>
            CreateMulticloudDataTransferConfigAsync(parent, multicloudDataTransferConfig, multicloudDataTransferConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `MulticloudDataTransferConfig` resource in a specified project
        /// and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MulticloudDataTransferConfig, OperationMetadata> UpdateMulticloudDataTransferConfig(UpdateMulticloudDataTransferConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `MulticloudDataTransferConfig` resource in a specified project
        /// and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MulticloudDataTransferConfig, OperationMetadata>> UpdateMulticloudDataTransferConfigAsync(UpdateMulticloudDataTransferConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `MulticloudDataTransferConfig` resource in a specified project
        /// and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MulticloudDataTransferConfig, OperationMetadata>> UpdateMulticloudDataTransferConfigAsync(UpdateMulticloudDataTransferConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateMulticloudDataTransferConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateMulticloudDataTransferConfig</c>.</summary>
        public virtual lro::OperationsClient UpdateMulticloudDataTransferConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateMulticloudDataTransferConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MulticloudDataTransferConfig, OperationMetadata> PollOnceUpdateMulticloudDataTransferConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MulticloudDataTransferConfig, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateMulticloudDataTransferConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateMulticloudDataTransferConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MulticloudDataTransferConfig, OperationMetadata>> PollOnceUpdateMulticloudDataTransferConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MulticloudDataTransferConfig, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateMulticloudDataTransferConfigOperationsClient, callSettings);

        /// <summary>
        /// Updates a `MulticloudDataTransferConfig` resource in a specified project
        /// and location.
        /// </summary>
        /// <param name="multicloudDataTransferConfig">
        /// Required. The `MulticloudDataTransferConfig` resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. `FieldMask` is used to specify the fields in the
        /// `MulticloudDataTransferConfig` resource to be overwritten by the update.
        /// The fields specified in `update_mask` are relative to the resource, not
        /// the full request. A field is overwritten if it is in the mask. If you
        /// don't specify a mask, all fields are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MulticloudDataTransferConfig, OperationMetadata> UpdateMulticloudDataTransferConfig(MulticloudDataTransferConfig multicloudDataTransferConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMulticloudDataTransferConfig(new UpdateMulticloudDataTransferConfigRequest
            {
                UpdateMask = updateMask,
                MulticloudDataTransferConfig = gax::GaxPreconditions.CheckNotNull(multicloudDataTransferConfig, nameof(multicloudDataTransferConfig)),
            }, callSettings);

        /// <summary>
        /// Updates a `MulticloudDataTransferConfig` resource in a specified project
        /// and location.
        /// </summary>
        /// <param name="multicloudDataTransferConfig">
        /// Required. The `MulticloudDataTransferConfig` resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. `FieldMask` is used to specify the fields in the
        /// `MulticloudDataTransferConfig` resource to be overwritten by the update.
        /// The fields specified in `update_mask` are relative to the resource, not
        /// the full request. A field is overwritten if it is in the mask. If you
        /// don't specify a mask, all fields are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MulticloudDataTransferConfig, OperationMetadata>> UpdateMulticloudDataTransferConfigAsync(MulticloudDataTransferConfig multicloudDataTransferConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMulticloudDataTransferConfigAsync(new UpdateMulticloudDataTransferConfigRequest
            {
                UpdateMask = updateMask,
                MulticloudDataTransferConfig = gax::GaxPreconditions.CheckNotNull(multicloudDataTransferConfig, nameof(multicloudDataTransferConfig)),
            }, callSettings);

        /// <summary>
        /// Updates a `MulticloudDataTransferConfig` resource in a specified project
        /// and location.
        /// </summary>
        /// <param name="multicloudDataTransferConfig">
        /// Required. The `MulticloudDataTransferConfig` resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. `FieldMask` is used to specify the fields in the
        /// `MulticloudDataTransferConfig` resource to be overwritten by the update.
        /// The fields specified in `update_mask` are relative to the resource, not
        /// the full request. A field is overwritten if it is in the mask. If you
        /// don't specify a mask, all fields are overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MulticloudDataTransferConfig, OperationMetadata>> UpdateMulticloudDataTransferConfigAsync(MulticloudDataTransferConfig multicloudDataTransferConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateMulticloudDataTransferConfigAsync(multicloudDataTransferConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a `MulticloudDataTransferConfig` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMulticloudDataTransferConfig(DeleteMulticloudDataTransferConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a `MulticloudDataTransferConfig` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMulticloudDataTransferConfigAsync(DeleteMulticloudDataTransferConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a `MulticloudDataTransferConfig` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMulticloudDataTransferConfigAsync(DeleteMulticloudDataTransferConfigRequest request, st::CancellationToken cancellationToken) =>
            DeleteMulticloudDataTransferConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteMulticloudDataTransferConfig</c>.</summary>
        public virtual lro::OperationsClient DeleteMulticloudDataTransferConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteMulticloudDataTransferConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteMulticloudDataTransferConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteMulticloudDataTransferConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteMulticloudDataTransferConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteMulticloudDataTransferConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteMulticloudDataTransferConfigOperationsClient, callSettings);

        /// <summary>
        /// Deletes a `MulticloudDataTransferConfig` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `MulticloudDataTransferConfig` resource to
        /// delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMulticloudDataTransferConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMulticloudDataTransferConfig(new DeleteMulticloudDataTransferConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a `MulticloudDataTransferConfig` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `MulticloudDataTransferConfig` resource to
        /// delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMulticloudDataTransferConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMulticloudDataTransferConfigAsync(new DeleteMulticloudDataTransferConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a `MulticloudDataTransferConfig` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `MulticloudDataTransferConfig` resource to
        /// delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMulticloudDataTransferConfigAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteMulticloudDataTransferConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a `MulticloudDataTransferConfig` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `MulticloudDataTransferConfig` resource to
        /// delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteMulticloudDataTransferConfig(MulticloudDataTransferConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMulticloudDataTransferConfig(new DeleteMulticloudDataTransferConfigRequest
            {
                MulticloudDataTransferConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a `MulticloudDataTransferConfig` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `MulticloudDataTransferConfig` resource to
        /// delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMulticloudDataTransferConfigAsync(MulticloudDataTransferConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMulticloudDataTransferConfigAsync(new DeleteMulticloudDataTransferConfigRequest
            {
                MulticloudDataTransferConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a `MulticloudDataTransferConfig` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `MulticloudDataTransferConfig` resource to
        /// delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMulticloudDataTransferConfigAsync(MulticloudDataTransferConfigName name, st::CancellationToken cancellationToken) =>
            DeleteMulticloudDataTransferConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the `Destination` resources in a specified project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Destination"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDestinationsResponse, Destination> ListDestinations(ListDestinationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the `Destination` resources in a specified project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Destination"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDestinationsResponse, Destination> ListDestinationsAsync(ListDestinationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the `Destination` resources in a specified project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource.
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
        /// <returns>A pageable sequence of <see cref="Destination"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDestinationsResponse, Destination> ListDestinations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDestinationsRequest request = new ListDestinationsRequest
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
            return ListDestinations(request, callSettings);
        }

        /// <summary>
        /// Lists the `Destination` resources in a specified project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Destination"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDestinationsResponse, Destination> ListDestinationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDestinationsRequest request = new ListDestinationsRequest
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
            return ListDestinationsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the `Destination` resources in a specified project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource.
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
        /// <returns>A pageable sequence of <see cref="Destination"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDestinationsResponse, Destination> ListDestinations(MulticloudDataTransferConfigName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDestinationsRequest request = new ListDestinationsRequest
            {
                ParentAsMulticloudDataTransferConfigName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDestinations(request, callSettings);
        }

        /// <summary>
        /// Lists the `Destination` resources in a specified project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Destination"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDestinationsResponse, Destination> ListDestinationsAsync(MulticloudDataTransferConfigName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDestinationsRequest request = new ListDestinationsRequest
            {
                ParentAsMulticloudDataTransferConfigName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDestinationsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a `Destination` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Destination GetDestination(GetDestinationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a `Destination` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Destination> GetDestinationAsync(GetDestinationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a `Destination` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Destination> GetDestinationAsync(GetDestinationRequest request, st::CancellationToken cancellationToken) =>
            GetDestinationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a `Destination` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Destination` resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Destination GetDestination(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDestination(new GetDestinationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a `Destination` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Destination` resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Destination> GetDestinationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDestinationAsync(new GetDestinationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a `Destination` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Destination` resource to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Destination> GetDestinationAsync(string name, st::CancellationToken cancellationToken) =>
            GetDestinationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a `Destination` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Destination` resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Destination GetDestination(DestinationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDestination(new GetDestinationRequest
            {
                DestinationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a `Destination` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Destination` resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Destination> GetDestinationAsync(DestinationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDestinationAsync(new GetDestinationRequest
            {
                DestinationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a `Destination` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Destination` resource to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Destination> GetDestinationAsync(DestinationName name, st::CancellationToken cancellationToken) =>
            GetDestinationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `Destination` resource in a specified project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Destination, OperationMetadata> CreateDestination(CreateDestinationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `Destination` resource in a specified project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Destination, OperationMetadata>> CreateDestinationAsync(CreateDestinationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `Destination` resource in a specified project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Destination, OperationMetadata>> CreateDestinationAsync(CreateDestinationRequest request, st::CancellationToken cancellationToken) =>
            CreateDestinationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateDestination</c>.</summary>
        public virtual lro::OperationsClient CreateDestinationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateDestination</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Destination, OperationMetadata> PollOnceCreateDestination(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Destination, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDestinationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateDestination</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Destination, OperationMetadata>> PollOnceCreateDestinationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Destination, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDestinationOperationsClient, callSettings);

        /// <summary>
        /// Creates a `Destination` resource in a specified project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource.
        /// </param>
        /// <param name="destination">
        /// Required. The `Destination` resource to create.
        /// </param>
        /// <param name="destinationId">
        /// Required. The ID to use for the `Destination` resource, which becomes the
        /// final component of the `Destination` resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Destination, OperationMetadata> CreateDestination(string parent, Destination destination, string destinationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDestination(new CreateDestinationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DestinationId = gax::GaxPreconditions.CheckNotNullOrEmpty(destinationId, nameof(destinationId)),
                Destination = gax::GaxPreconditions.CheckNotNull(destination, nameof(destination)),
            }, callSettings);

        /// <summary>
        /// Creates a `Destination` resource in a specified project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource.
        /// </param>
        /// <param name="destination">
        /// Required. The `Destination` resource to create.
        /// </param>
        /// <param name="destinationId">
        /// Required. The ID to use for the `Destination` resource, which becomes the
        /// final component of the `Destination` resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Destination, OperationMetadata>> CreateDestinationAsync(string parent, Destination destination, string destinationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDestinationAsync(new CreateDestinationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DestinationId = gax::GaxPreconditions.CheckNotNullOrEmpty(destinationId, nameof(destinationId)),
                Destination = gax::GaxPreconditions.CheckNotNull(destination, nameof(destination)),
            }, callSettings);

        /// <summary>
        /// Creates a `Destination` resource in a specified project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource.
        /// </param>
        /// <param name="destination">
        /// Required. The `Destination` resource to create.
        /// </param>
        /// <param name="destinationId">
        /// Required. The ID to use for the `Destination` resource, which becomes the
        /// final component of the `Destination` resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Destination, OperationMetadata>> CreateDestinationAsync(string parent, Destination destination, string destinationId, st::CancellationToken cancellationToken) =>
            CreateDestinationAsync(parent, destination, destinationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `Destination` resource in a specified project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource.
        /// </param>
        /// <param name="destination">
        /// Required. The `Destination` resource to create.
        /// </param>
        /// <param name="destinationId">
        /// Required. The ID to use for the `Destination` resource, which becomes the
        /// final component of the `Destination` resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Destination, OperationMetadata> CreateDestination(MulticloudDataTransferConfigName parent, Destination destination, string destinationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDestination(new CreateDestinationRequest
            {
                ParentAsMulticloudDataTransferConfigName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DestinationId = gax::GaxPreconditions.CheckNotNullOrEmpty(destinationId, nameof(destinationId)),
                Destination = gax::GaxPreconditions.CheckNotNull(destination, nameof(destination)),
            }, callSettings);

        /// <summary>
        /// Creates a `Destination` resource in a specified project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource.
        /// </param>
        /// <param name="destination">
        /// Required. The `Destination` resource to create.
        /// </param>
        /// <param name="destinationId">
        /// Required. The ID to use for the `Destination` resource, which becomes the
        /// final component of the `Destination` resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Destination, OperationMetadata>> CreateDestinationAsync(MulticloudDataTransferConfigName parent, Destination destination, string destinationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDestinationAsync(new CreateDestinationRequest
            {
                ParentAsMulticloudDataTransferConfigName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DestinationId = gax::GaxPreconditions.CheckNotNullOrEmpty(destinationId, nameof(destinationId)),
                Destination = gax::GaxPreconditions.CheckNotNull(destination, nameof(destination)),
            }, callSettings);

        /// <summary>
        /// Creates a `Destination` resource in a specified project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource.
        /// </param>
        /// <param name="destination">
        /// Required. The `Destination` resource to create.
        /// </param>
        /// <param name="destinationId">
        /// Required. The ID to use for the `Destination` resource, which becomes the
        /// final component of the `Destination` resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Destination, OperationMetadata>> CreateDestinationAsync(MulticloudDataTransferConfigName parent, Destination destination, string destinationId, st::CancellationToken cancellationToken) =>
            CreateDestinationAsync(parent, destination, destinationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `Destination` resource in a specified project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Destination, OperationMetadata> UpdateDestination(UpdateDestinationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `Destination` resource in a specified project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Destination, OperationMetadata>> UpdateDestinationAsync(UpdateDestinationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `Destination` resource in a specified project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Destination, OperationMetadata>> UpdateDestinationAsync(UpdateDestinationRequest request, st::CancellationToken cancellationToken) =>
            UpdateDestinationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateDestination</c>.</summary>
        public virtual lro::OperationsClient UpdateDestinationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateDestination</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Destination, OperationMetadata> PollOnceUpdateDestination(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Destination, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDestinationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateDestination</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Destination, OperationMetadata>> PollOnceUpdateDestinationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Destination, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDestinationOperationsClient, callSettings);

        /// <summary>
        /// Updates a `Destination` resource in a specified project and location.
        /// </summary>
        /// <param name="destination">
        /// Required. The `Destination` resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. `FieldMask is used to specify the fields to be overwritten in the
        /// `Destination` resource by the update.
        /// The fields specified in `update_mask` are relative to the resource, not
        /// the full request. A field is overwritten if it is in the mask. If you
        /// don't specify a mask, all fields are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Destination, OperationMetadata> UpdateDestination(Destination destination, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDestination(new UpdateDestinationRequest
            {
                UpdateMask = updateMask,
                Destination = gax::GaxPreconditions.CheckNotNull(destination, nameof(destination)),
            }, callSettings);

        /// <summary>
        /// Updates a `Destination` resource in a specified project and location.
        /// </summary>
        /// <param name="destination">
        /// Required. The `Destination` resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. `FieldMask is used to specify the fields to be overwritten in the
        /// `Destination` resource by the update.
        /// The fields specified in `update_mask` are relative to the resource, not
        /// the full request. A field is overwritten if it is in the mask. If you
        /// don't specify a mask, all fields are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Destination, OperationMetadata>> UpdateDestinationAsync(Destination destination, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDestinationAsync(new UpdateDestinationRequest
            {
                UpdateMask = updateMask,
                Destination = gax::GaxPreconditions.CheckNotNull(destination, nameof(destination)),
            }, callSettings);

        /// <summary>
        /// Updates a `Destination` resource in a specified project and location.
        /// </summary>
        /// <param name="destination">
        /// Required. The `Destination` resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. `FieldMask is used to specify the fields to be overwritten in the
        /// `Destination` resource by the update.
        /// The fields specified in `update_mask` are relative to the resource, not
        /// the full request. A field is overwritten if it is in the mask. If you
        /// don't specify a mask, all fields are overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Destination, OperationMetadata>> UpdateDestinationAsync(Destination destination, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDestinationAsync(destination, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a `Destination` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDestination(DeleteDestinationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a `Destination` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDestinationAsync(DeleteDestinationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a `Destination` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDestinationAsync(DeleteDestinationRequest request, st::CancellationToken cancellationToken) =>
            DeleteDestinationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteDestination</c>.</summary>
        public virtual lro::OperationsClient DeleteDestinationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteDestination</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteDestination(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDestinationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteDestination</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteDestinationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDestinationOperationsClient, callSettings);

        /// <summary>
        /// Deletes a `Destination` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Destination` resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDestination(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDestination(new DeleteDestinationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a `Destination` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Destination` resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDestinationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDestinationAsync(new DeleteDestinationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a `Destination` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Destination` resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDestinationAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDestinationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a `Destination` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Destination` resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDestination(DestinationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDestination(new DeleteDestinationRequest
            {
                DestinationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a `Destination` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Destination` resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDestinationAsync(DestinationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDestinationAsync(new DeleteDestinationRequest
            {
                DestinationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a `Destination` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Destination` resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDestinationAsync(DestinationName name, st::CancellationToken cancellationToken) =>
            DeleteDestinationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a service that is supported for Data Transfer
        /// Essentials.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MulticloudDataTransferSupportedService GetMulticloudDataTransferSupportedService(GetMulticloudDataTransferSupportedServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a service that is supported for Data Transfer
        /// Essentials.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MulticloudDataTransferSupportedService> GetMulticloudDataTransferSupportedServiceAsync(GetMulticloudDataTransferSupportedServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a service that is supported for Data Transfer
        /// Essentials.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MulticloudDataTransferSupportedService> GetMulticloudDataTransferSupportedServiceAsync(GetMulticloudDataTransferSupportedServiceRequest request, st::CancellationToken cancellationToken) =>
            GetMulticloudDataTransferSupportedServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a service that is supported for Data Transfer
        /// Essentials.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MulticloudDataTransferSupportedService GetMulticloudDataTransferSupportedService(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMulticloudDataTransferSupportedService(new GetMulticloudDataTransferSupportedServiceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a service that is supported for Data Transfer
        /// Essentials.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MulticloudDataTransferSupportedService> GetMulticloudDataTransferSupportedServiceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMulticloudDataTransferSupportedServiceAsync(new GetMulticloudDataTransferSupportedServiceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a service that is supported for Data Transfer
        /// Essentials.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the service.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MulticloudDataTransferSupportedService> GetMulticloudDataTransferSupportedServiceAsync(string name, st::CancellationToken cancellationToken) =>
            GetMulticloudDataTransferSupportedServiceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a service that is supported for Data Transfer
        /// Essentials.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MulticloudDataTransferSupportedService GetMulticloudDataTransferSupportedService(MulticloudDataTransferSupportedServiceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMulticloudDataTransferSupportedService(new GetMulticloudDataTransferSupportedServiceRequest
            {
                MulticloudDataTransferSupportedServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a service that is supported for Data Transfer
        /// Essentials.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the service.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MulticloudDataTransferSupportedService> GetMulticloudDataTransferSupportedServiceAsync(MulticloudDataTransferSupportedServiceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMulticloudDataTransferSupportedServiceAsync(new GetMulticloudDataTransferSupportedServiceRequest
            {
                MulticloudDataTransferSupportedServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a service that is supported for Data Transfer
        /// Essentials.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the service.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MulticloudDataTransferSupportedService> GetMulticloudDataTransferSupportedServiceAsync(MulticloudDataTransferSupportedServiceName name, st::CancellationToken cancellationToken) =>
            GetMulticloudDataTransferSupportedServiceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the services in the project for a region that are supported for
        /// Data Transfer Essentials.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MulticloudDataTransferSupportedService"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMulticloudDataTransferSupportedServicesResponse, MulticloudDataTransferSupportedService> ListMulticloudDataTransferSupportedServices(ListMulticloudDataTransferSupportedServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the services in the project for a region that are supported for
        /// Data Transfer Essentials.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="MulticloudDataTransferSupportedService"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListMulticloudDataTransferSupportedServicesResponse, MulticloudDataTransferSupportedService> ListMulticloudDataTransferSupportedServicesAsync(ListMulticloudDataTransferSupportedServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the services in the project for a region that are supported for
        /// Data Transfer Essentials.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource.
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
        /// <returns>A pageable sequence of <see cref="MulticloudDataTransferSupportedService"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMulticloudDataTransferSupportedServicesResponse, MulticloudDataTransferSupportedService> ListMulticloudDataTransferSupportedServices(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMulticloudDataTransferSupportedServicesRequest request = new ListMulticloudDataTransferSupportedServicesRequest
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
            return ListMulticloudDataTransferSupportedServices(request, callSettings);
        }

        /// <summary>
        /// Lists the services in the project for a region that are supported for
        /// Data Transfer Essentials.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource.
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
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="MulticloudDataTransferSupportedService"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListMulticloudDataTransferSupportedServicesResponse, MulticloudDataTransferSupportedService> ListMulticloudDataTransferSupportedServicesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMulticloudDataTransferSupportedServicesRequest request = new ListMulticloudDataTransferSupportedServicesRequest
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
            return ListMulticloudDataTransferSupportedServicesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the services in the project for a region that are supported for
        /// Data Transfer Essentials.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource.
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
        /// <returns>A pageable sequence of <see cref="MulticloudDataTransferSupportedService"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMulticloudDataTransferSupportedServicesResponse, MulticloudDataTransferSupportedService> ListMulticloudDataTransferSupportedServices(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMulticloudDataTransferSupportedServicesRequest request = new ListMulticloudDataTransferSupportedServicesRequest
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
            return ListMulticloudDataTransferSupportedServices(request, callSettings);
        }

        /// <summary>
        /// Lists the services in the project for a region that are supported for
        /// Data Transfer Essentials.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource.
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
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="MulticloudDataTransferSupportedService"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListMulticloudDataTransferSupportedServicesResponse, MulticloudDataTransferSupportedService> ListMulticloudDataTransferSupportedServicesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMulticloudDataTransferSupportedServicesRequest request = new ListMulticloudDataTransferSupportedServicesRequest
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
            return ListMulticloudDataTransferSupportedServicesAsync(request, callSettings);
        }
    }

    /// <summary>DataTransferService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// DataTransferService is the service for the Data Transfer API.
    /// </remarks>
    public sealed partial class DataTransferServiceClientImpl : DataTransferServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListMulticloudDataTransferConfigsRequest, ListMulticloudDataTransferConfigsResponse> _callListMulticloudDataTransferConfigs;

        private readonly gaxgrpc::ApiCall<GetMulticloudDataTransferConfigRequest, MulticloudDataTransferConfig> _callGetMulticloudDataTransferConfig;

        private readonly gaxgrpc::ApiCall<CreateMulticloudDataTransferConfigRequest, lro::Operation> _callCreateMulticloudDataTransferConfig;

        private readonly gaxgrpc::ApiCall<UpdateMulticloudDataTransferConfigRequest, lro::Operation> _callUpdateMulticloudDataTransferConfig;

        private readonly gaxgrpc::ApiCall<DeleteMulticloudDataTransferConfigRequest, lro::Operation> _callDeleteMulticloudDataTransferConfig;

        private readonly gaxgrpc::ApiCall<ListDestinationsRequest, ListDestinationsResponse> _callListDestinations;

        private readonly gaxgrpc::ApiCall<GetDestinationRequest, Destination> _callGetDestination;

        private readonly gaxgrpc::ApiCall<CreateDestinationRequest, lro::Operation> _callCreateDestination;

        private readonly gaxgrpc::ApiCall<UpdateDestinationRequest, lro::Operation> _callUpdateDestination;

        private readonly gaxgrpc::ApiCall<DeleteDestinationRequest, lro::Operation> _callDeleteDestination;

        private readonly gaxgrpc::ApiCall<GetMulticloudDataTransferSupportedServiceRequest, MulticloudDataTransferSupportedService> _callGetMulticloudDataTransferSupportedService;

        private readonly gaxgrpc::ApiCall<ListMulticloudDataTransferSupportedServicesRequest, ListMulticloudDataTransferSupportedServicesResponse> _callListMulticloudDataTransferSupportedServices;

        /// <summary>
        /// Constructs a client wrapper for the DataTransferService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DataTransferServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DataTransferServiceClientImpl(DataTransferService.DataTransferServiceClient grpcClient, DataTransferServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DataTransferServiceSettings effectiveSettings = settings ?? DataTransferServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateMulticloudDataTransferConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateMulticloudDataTransferConfigOperationsSettings, logger);
            UpdateMulticloudDataTransferConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateMulticloudDataTransferConfigOperationsSettings, logger);
            DeleteMulticloudDataTransferConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteMulticloudDataTransferConfigOperationsSettings, logger);
            CreateDestinationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateDestinationOperationsSettings, logger);
            UpdateDestinationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateDestinationOperationsSettings, logger);
            DeleteDestinationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteDestinationOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListMulticloudDataTransferConfigs = clientHelper.BuildApiCall<ListMulticloudDataTransferConfigsRequest, ListMulticloudDataTransferConfigsResponse>("ListMulticloudDataTransferConfigs", grpcClient.ListMulticloudDataTransferConfigsAsync, grpcClient.ListMulticloudDataTransferConfigs, effectiveSettings.ListMulticloudDataTransferConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMulticloudDataTransferConfigs);
            Modify_ListMulticloudDataTransferConfigsApiCall(ref _callListMulticloudDataTransferConfigs);
            _callGetMulticloudDataTransferConfig = clientHelper.BuildApiCall<GetMulticloudDataTransferConfigRequest, MulticloudDataTransferConfig>("GetMulticloudDataTransferConfig", grpcClient.GetMulticloudDataTransferConfigAsync, grpcClient.GetMulticloudDataTransferConfig, effectiveSettings.GetMulticloudDataTransferConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMulticloudDataTransferConfig);
            Modify_GetMulticloudDataTransferConfigApiCall(ref _callGetMulticloudDataTransferConfig);
            _callCreateMulticloudDataTransferConfig = clientHelper.BuildApiCall<CreateMulticloudDataTransferConfigRequest, lro::Operation>("CreateMulticloudDataTransferConfig", grpcClient.CreateMulticloudDataTransferConfigAsync, grpcClient.CreateMulticloudDataTransferConfig, effectiveSettings.CreateMulticloudDataTransferConfigSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateMulticloudDataTransferConfig);
            Modify_CreateMulticloudDataTransferConfigApiCall(ref _callCreateMulticloudDataTransferConfig);
            _callUpdateMulticloudDataTransferConfig = clientHelper.BuildApiCall<UpdateMulticloudDataTransferConfigRequest, lro::Operation>("UpdateMulticloudDataTransferConfig", grpcClient.UpdateMulticloudDataTransferConfigAsync, grpcClient.UpdateMulticloudDataTransferConfig, effectiveSettings.UpdateMulticloudDataTransferConfigSettings).WithGoogleRequestParam("multicloud_data_transfer_config.name", request => request.MulticloudDataTransferConfig?.Name);
            Modify_ApiCall(ref _callUpdateMulticloudDataTransferConfig);
            Modify_UpdateMulticloudDataTransferConfigApiCall(ref _callUpdateMulticloudDataTransferConfig);
            _callDeleteMulticloudDataTransferConfig = clientHelper.BuildApiCall<DeleteMulticloudDataTransferConfigRequest, lro::Operation>("DeleteMulticloudDataTransferConfig", grpcClient.DeleteMulticloudDataTransferConfigAsync, grpcClient.DeleteMulticloudDataTransferConfig, effectiveSettings.DeleteMulticloudDataTransferConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteMulticloudDataTransferConfig);
            Modify_DeleteMulticloudDataTransferConfigApiCall(ref _callDeleteMulticloudDataTransferConfig);
            _callListDestinations = clientHelper.BuildApiCall<ListDestinationsRequest, ListDestinationsResponse>("ListDestinations", grpcClient.ListDestinationsAsync, grpcClient.ListDestinations, effectiveSettings.ListDestinationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDestinations);
            Modify_ListDestinationsApiCall(ref _callListDestinations);
            _callGetDestination = clientHelper.BuildApiCall<GetDestinationRequest, Destination>("GetDestination", grpcClient.GetDestinationAsync, grpcClient.GetDestination, effectiveSettings.GetDestinationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDestination);
            Modify_GetDestinationApiCall(ref _callGetDestination);
            _callCreateDestination = clientHelper.BuildApiCall<CreateDestinationRequest, lro::Operation>("CreateDestination", grpcClient.CreateDestinationAsync, grpcClient.CreateDestination, effectiveSettings.CreateDestinationSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDestination);
            Modify_CreateDestinationApiCall(ref _callCreateDestination);
            _callUpdateDestination = clientHelper.BuildApiCall<UpdateDestinationRequest, lro::Operation>("UpdateDestination", grpcClient.UpdateDestinationAsync, grpcClient.UpdateDestination, effectiveSettings.UpdateDestinationSettings).WithGoogleRequestParam("destination.name", request => request.Destination?.Name);
            Modify_ApiCall(ref _callUpdateDestination);
            Modify_UpdateDestinationApiCall(ref _callUpdateDestination);
            _callDeleteDestination = clientHelper.BuildApiCall<DeleteDestinationRequest, lro::Operation>("DeleteDestination", grpcClient.DeleteDestinationAsync, grpcClient.DeleteDestination, effectiveSettings.DeleteDestinationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDestination);
            Modify_DeleteDestinationApiCall(ref _callDeleteDestination);
            _callGetMulticloudDataTransferSupportedService = clientHelper.BuildApiCall<GetMulticloudDataTransferSupportedServiceRequest, MulticloudDataTransferSupportedService>("GetMulticloudDataTransferSupportedService", grpcClient.GetMulticloudDataTransferSupportedServiceAsync, grpcClient.GetMulticloudDataTransferSupportedService, effectiveSettings.GetMulticloudDataTransferSupportedServiceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMulticloudDataTransferSupportedService);
            Modify_GetMulticloudDataTransferSupportedServiceApiCall(ref _callGetMulticloudDataTransferSupportedService);
            _callListMulticloudDataTransferSupportedServices = clientHelper.BuildApiCall<ListMulticloudDataTransferSupportedServicesRequest, ListMulticloudDataTransferSupportedServicesResponse>("ListMulticloudDataTransferSupportedServices", grpcClient.ListMulticloudDataTransferSupportedServicesAsync, grpcClient.ListMulticloudDataTransferSupportedServices, effectiveSettings.ListMulticloudDataTransferSupportedServicesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMulticloudDataTransferSupportedServices);
            Modify_ListMulticloudDataTransferSupportedServicesApiCall(ref _callListMulticloudDataTransferSupportedServices);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListMulticloudDataTransferConfigsApiCall(ref gaxgrpc::ApiCall<ListMulticloudDataTransferConfigsRequest, ListMulticloudDataTransferConfigsResponse> call);

        partial void Modify_GetMulticloudDataTransferConfigApiCall(ref gaxgrpc::ApiCall<GetMulticloudDataTransferConfigRequest, MulticloudDataTransferConfig> call);

        partial void Modify_CreateMulticloudDataTransferConfigApiCall(ref gaxgrpc::ApiCall<CreateMulticloudDataTransferConfigRequest, lro::Operation> call);

        partial void Modify_UpdateMulticloudDataTransferConfigApiCall(ref gaxgrpc::ApiCall<UpdateMulticloudDataTransferConfigRequest, lro::Operation> call);

        partial void Modify_DeleteMulticloudDataTransferConfigApiCall(ref gaxgrpc::ApiCall<DeleteMulticloudDataTransferConfigRequest, lro::Operation> call);

        partial void Modify_ListDestinationsApiCall(ref gaxgrpc::ApiCall<ListDestinationsRequest, ListDestinationsResponse> call);

        partial void Modify_GetDestinationApiCall(ref gaxgrpc::ApiCall<GetDestinationRequest, Destination> call);

        partial void Modify_CreateDestinationApiCall(ref gaxgrpc::ApiCall<CreateDestinationRequest, lro::Operation> call);

        partial void Modify_UpdateDestinationApiCall(ref gaxgrpc::ApiCall<UpdateDestinationRequest, lro::Operation> call);

        partial void Modify_DeleteDestinationApiCall(ref gaxgrpc::ApiCall<DeleteDestinationRequest, lro::Operation> call);

        partial void Modify_GetMulticloudDataTransferSupportedServiceApiCall(ref gaxgrpc::ApiCall<GetMulticloudDataTransferSupportedServiceRequest, MulticloudDataTransferSupportedService> call);

        partial void Modify_ListMulticloudDataTransferSupportedServicesApiCall(ref gaxgrpc::ApiCall<ListMulticloudDataTransferSupportedServicesRequest, ListMulticloudDataTransferSupportedServicesResponse> call);

        partial void OnConstruction(DataTransferService.DataTransferServiceClient grpcClient, DataTransferServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DataTransferService client</summary>
        public override DataTransferService.DataTransferServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListMulticloudDataTransferConfigsRequest(ref ListMulticloudDataTransferConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMulticloudDataTransferConfigRequest(ref GetMulticloudDataTransferConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateMulticloudDataTransferConfigRequest(ref CreateMulticloudDataTransferConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateMulticloudDataTransferConfigRequest(ref UpdateMulticloudDataTransferConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteMulticloudDataTransferConfigRequest(ref DeleteMulticloudDataTransferConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDestinationsRequest(ref ListDestinationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDestinationRequest(ref GetDestinationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateDestinationRequest(ref CreateDestinationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDestinationRequest(ref UpdateDestinationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDestinationRequest(ref DeleteDestinationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMulticloudDataTransferSupportedServiceRequest(ref GetMulticloudDataTransferSupportedServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListMulticloudDataTransferSupportedServicesRequest(ref ListMulticloudDataTransferSupportedServicesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists the `MulticloudDataTransferConfig` resources in a specified project
        /// and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MulticloudDataTransferConfig"/> resources.</returns>
        public override gax::PagedEnumerable<ListMulticloudDataTransferConfigsResponse, MulticloudDataTransferConfig> ListMulticloudDataTransferConfigs(ListMulticloudDataTransferConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMulticloudDataTransferConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMulticloudDataTransferConfigsRequest, ListMulticloudDataTransferConfigsResponse, MulticloudDataTransferConfig>(_callListMulticloudDataTransferConfigs, request, callSettings);
        }

        /// <summary>
        /// Lists the `MulticloudDataTransferConfig` resources in a specified project
        /// and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MulticloudDataTransferConfig"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMulticloudDataTransferConfigsResponse, MulticloudDataTransferConfig> ListMulticloudDataTransferConfigsAsync(ListMulticloudDataTransferConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMulticloudDataTransferConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMulticloudDataTransferConfigsRequest, ListMulticloudDataTransferConfigsResponse, MulticloudDataTransferConfig>(_callListMulticloudDataTransferConfigs, request, callSettings);
        }

        /// <summary>
        /// Gets the details of a `MulticloudDataTransferConfig` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MulticloudDataTransferConfig GetMulticloudDataTransferConfig(GetMulticloudDataTransferConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMulticloudDataTransferConfigRequest(ref request, ref callSettings);
            return _callGetMulticloudDataTransferConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a `MulticloudDataTransferConfig` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MulticloudDataTransferConfig> GetMulticloudDataTransferConfigAsync(GetMulticloudDataTransferConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMulticloudDataTransferConfigRequest(ref request, ref callSettings);
            return _callGetMulticloudDataTransferConfig.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateMulticloudDataTransferConfig</c>.</summary>
        public override lro::OperationsClient CreateMulticloudDataTransferConfigOperationsClient { get; }

        /// <summary>
        /// Creates a `MulticloudDataTransferConfig` resource in a specified project
        /// and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MulticloudDataTransferConfig, OperationMetadata> CreateMulticloudDataTransferConfig(CreateMulticloudDataTransferConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMulticloudDataTransferConfigRequest(ref request, ref callSettings);
            return new lro::Operation<MulticloudDataTransferConfig, OperationMetadata>(_callCreateMulticloudDataTransferConfig.Sync(request, callSettings), CreateMulticloudDataTransferConfigOperationsClient);
        }

        /// <summary>
        /// Creates a `MulticloudDataTransferConfig` resource in a specified project
        /// and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MulticloudDataTransferConfig, OperationMetadata>> CreateMulticloudDataTransferConfigAsync(CreateMulticloudDataTransferConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMulticloudDataTransferConfigRequest(ref request, ref callSettings);
            return new lro::Operation<MulticloudDataTransferConfig, OperationMetadata>(await _callCreateMulticloudDataTransferConfig.Async(request, callSettings).ConfigureAwait(false), CreateMulticloudDataTransferConfigOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateMulticloudDataTransferConfig</c>.</summary>
        public override lro::OperationsClient UpdateMulticloudDataTransferConfigOperationsClient { get; }

        /// <summary>
        /// Updates a `MulticloudDataTransferConfig` resource in a specified project
        /// and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MulticloudDataTransferConfig, OperationMetadata> UpdateMulticloudDataTransferConfig(UpdateMulticloudDataTransferConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMulticloudDataTransferConfigRequest(ref request, ref callSettings);
            return new lro::Operation<MulticloudDataTransferConfig, OperationMetadata>(_callUpdateMulticloudDataTransferConfig.Sync(request, callSettings), UpdateMulticloudDataTransferConfigOperationsClient);
        }

        /// <summary>
        /// Updates a `MulticloudDataTransferConfig` resource in a specified project
        /// and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MulticloudDataTransferConfig, OperationMetadata>> UpdateMulticloudDataTransferConfigAsync(UpdateMulticloudDataTransferConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMulticloudDataTransferConfigRequest(ref request, ref callSettings);
            return new lro::Operation<MulticloudDataTransferConfig, OperationMetadata>(await _callUpdateMulticloudDataTransferConfig.Async(request, callSettings).ConfigureAwait(false), UpdateMulticloudDataTransferConfigOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteMulticloudDataTransferConfig</c>.</summary>
        public override lro::OperationsClient DeleteMulticloudDataTransferConfigOperationsClient { get; }

        /// <summary>
        /// Deletes a `MulticloudDataTransferConfig` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteMulticloudDataTransferConfig(DeleteMulticloudDataTransferConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMulticloudDataTransferConfigRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteMulticloudDataTransferConfig.Sync(request, callSettings), DeleteMulticloudDataTransferConfigOperationsClient);
        }

        /// <summary>
        /// Deletes a `MulticloudDataTransferConfig` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteMulticloudDataTransferConfigAsync(DeleteMulticloudDataTransferConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMulticloudDataTransferConfigRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteMulticloudDataTransferConfig.Async(request, callSettings).ConfigureAwait(false), DeleteMulticloudDataTransferConfigOperationsClient);
        }

        /// <summary>
        /// Lists the `Destination` resources in a specified project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Destination"/> resources.</returns>
        public override gax::PagedEnumerable<ListDestinationsResponse, Destination> ListDestinations(ListDestinationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDestinationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDestinationsRequest, ListDestinationsResponse, Destination>(_callListDestinations, request, callSettings);
        }

        /// <summary>
        /// Lists the `Destination` resources in a specified project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Destination"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDestinationsResponse, Destination> ListDestinationsAsync(ListDestinationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDestinationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDestinationsRequest, ListDestinationsResponse, Destination>(_callListDestinations, request, callSettings);
        }

        /// <summary>
        /// Gets the details of a `Destination` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Destination GetDestination(GetDestinationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDestinationRequest(ref request, ref callSettings);
            return _callGetDestination.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a `Destination` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Destination> GetDestinationAsync(GetDestinationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDestinationRequest(ref request, ref callSettings);
            return _callGetDestination.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateDestination</c>.</summary>
        public override lro::OperationsClient CreateDestinationOperationsClient { get; }

        /// <summary>
        /// Creates a `Destination` resource in a specified project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Destination, OperationMetadata> CreateDestination(CreateDestinationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDestinationRequest(ref request, ref callSettings);
            return new lro::Operation<Destination, OperationMetadata>(_callCreateDestination.Sync(request, callSettings), CreateDestinationOperationsClient);
        }

        /// <summary>
        /// Creates a `Destination` resource in a specified project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Destination, OperationMetadata>> CreateDestinationAsync(CreateDestinationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDestinationRequest(ref request, ref callSettings);
            return new lro::Operation<Destination, OperationMetadata>(await _callCreateDestination.Async(request, callSettings).ConfigureAwait(false), CreateDestinationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateDestination</c>.</summary>
        public override lro::OperationsClient UpdateDestinationOperationsClient { get; }

        /// <summary>
        /// Updates a `Destination` resource in a specified project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Destination, OperationMetadata> UpdateDestination(UpdateDestinationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDestinationRequest(ref request, ref callSettings);
            return new lro::Operation<Destination, OperationMetadata>(_callUpdateDestination.Sync(request, callSettings), UpdateDestinationOperationsClient);
        }

        /// <summary>
        /// Updates a `Destination` resource in a specified project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Destination, OperationMetadata>> UpdateDestinationAsync(UpdateDestinationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDestinationRequest(ref request, ref callSettings);
            return new lro::Operation<Destination, OperationMetadata>(await _callUpdateDestination.Async(request, callSettings).ConfigureAwait(false), UpdateDestinationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteDestination</c>.</summary>
        public override lro::OperationsClient DeleteDestinationOperationsClient { get; }

        /// <summary>
        /// Deletes a `Destination` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteDestination(DeleteDestinationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDestinationRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteDestination.Sync(request, callSettings), DeleteDestinationOperationsClient);
        }

        /// <summary>
        /// Deletes a `Destination` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDestinationAsync(DeleteDestinationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDestinationRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteDestination.Async(request, callSettings).ConfigureAwait(false), DeleteDestinationOperationsClient);
        }

        /// <summary>
        /// Gets the details of a service that is supported for Data Transfer
        /// Essentials.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MulticloudDataTransferSupportedService GetMulticloudDataTransferSupportedService(GetMulticloudDataTransferSupportedServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMulticloudDataTransferSupportedServiceRequest(ref request, ref callSettings);
            return _callGetMulticloudDataTransferSupportedService.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a service that is supported for Data Transfer
        /// Essentials.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MulticloudDataTransferSupportedService> GetMulticloudDataTransferSupportedServiceAsync(GetMulticloudDataTransferSupportedServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMulticloudDataTransferSupportedServiceRequest(ref request, ref callSettings);
            return _callGetMulticloudDataTransferSupportedService.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the services in the project for a region that are supported for
        /// Data Transfer Essentials.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MulticloudDataTransferSupportedService"/> resources.</returns>
        public override gax::PagedEnumerable<ListMulticloudDataTransferSupportedServicesResponse, MulticloudDataTransferSupportedService> ListMulticloudDataTransferSupportedServices(ListMulticloudDataTransferSupportedServicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMulticloudDataTransferSupportedServicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMulticloudDataTransferSupportedServicesRequest, ListMulticloudDataTransferSupportedServicesResponse, MulticloudDataTransferSupportedService>(_callListMulticloudDataTransferSupportedServices, request, callSettings);
        }

        /// <summary>
        /// Lists the services in the project for a region that are supported for
        /// Data Transfer Essentials.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="MulticloudDataTransferSupportedService"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListMulticloudDataTransferSupportedServicesResponse, MulticloudDataTransferSupportedService> ListMulticloudDataTransferSupportedServicesAsync(ListMulticloudDataTransferSupportedServicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMulticloudDataTransferSupportedServicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMulticloudDataTransferSupportedServicesRequest, ListMulticloudDataTransferSupportedServicesResponse, MulticloudDataTransferSupportedService>(_callListMulticloudDataTransferSupportedServices, request, callSettings);
        }
    }

    public partial class ListMulticloudDataTransferConfigsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDestinationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMulticloudDataTransferSupportedServicesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMulticloudDataTransferConfigsResponse : gaxgrpc::IPageResponse<MulticloudDataTransferConfig>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<MulticloudDataTransferConfig> GetEnumerator() =>
            MulticloudDataTransferConfigs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDestinationsResponse : gaxgrpc::IPageResponse<Destination>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Destination> GetEnumerator() => Destinations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListMulticloudDataTransferSupportedServicesResponse : gaxgrpc::IPageResponse<MulticloudDataTransferSupportedService>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<MulticloudDataTransferSupportedService> GetEnumerator() =>
            MulticloudDataTransferSupportedServices.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class DataTransferService
    {
        public partial class DataTransferServiceClient
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

    public static partial class DataTransferService
    {
        public partial class DataTransferServiceClient
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
