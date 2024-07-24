// Copyright 2024 Google LLC
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

namespace Google.Cloud.NetworkServices.V1
{
    /// <summary>Settings for <see cref="DepServiceClient"/> instances.</summary>
    public sealed partial class DepServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DepServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DepServiceSettings"/>.</returns>
        public static DepServiceSettings GetDefault() => new DepServiceSettings();

        /// <summary>Constructs a new <see cref="DepServiceSettings"/> object with default settings.</summary>
        public DepServiceSettings()
        {
        }

        private DepServiceSettings(DepServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListLbTrafficExtensionsSettings = existing.ListLbTrafficExtensionsSettings;
            GetLbTrafficExtensionSettings = existing.GetLbTrafficExtensionSettings;
            CreateLbTrafficExtensionSettings = existing.CreateLbTrafficExtensionSettings;
            CreateLbTrafficExtensionOperationsSettings = existing.CreateLbTrafficExtensionOperationsSettings.Clone();
            UpdateLbTrafficExtensionSettings = existing.UpdateLbTrafficExtensionSettings;
            UpdateLbTrafficExtensionOperationsSettings = existing.UpdateLbTrafficExtensionOperationsSettings.Clone();
            DeleteLbTrafficExtensionSettings = existing.DeleteLbTrafficExtensionSettings;
            DeleteLbTrafficExtensionOperationsSettings = existing.DeleteLbTrafficExtensionOperationsSettings.Clone();
            ListLbRouteExtensionsSettings = existing.ListLbRouteExtensionsSettings;
            GetLbRouteExtensionSettings = existing.GetLbRouteExtensionSettings;
            CreateLbRouteExtensionSettings = existing.CreateLbRouteExtensionSettings;
            CreateLbRouteExtensionOperationsSettings = existing.CreateLbRouteExtensionOperationsSettings.Clone();
            UpdateLbRouteExtensionSettings = existing.UpdateLbRouteExtensionSettings;
            UpdateLbRouteExtensionOperationsSettings = existing.UpdateLbRouteExtensionOperationsSettings.Clone();
            DeleteLbRouteExtensionSettings = existing.DeleteLbRouteExtensionSettings;
            DeleteLbRouteExtensionOperationsSettings = existing.DeleteLbRouteExtensionOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(DepServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DepServiceClient.ListLbTrafficExtensions</c> and <c>DepServiceClient.ListLbTrafficExtensionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListLbTrafficExtensionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DepServiceClient.GetLbTrafficExtension</c> and <c>DepServiceClient.GetLbTrafficExtensionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetLbTrafficExtensionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DepServiceClient.CreateLbTrafficExtension</c> and <c>DepServiceClient.CreateLbTrafficExtensionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateLbTrafficExtensionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DepServiceClient.CreateLbTrafficExtension</c> and
        /// <c>DepServiceClient.CreateLbTrafficExtensionAsync</c>.
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
        public lro::OperationsSettings CreateLbTrafficExtensionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DepServiceClient.UpdateLbTrafficExtension</c> and <c>DepServiceClient.UpdateLbTrafficExtensionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateLbTrafficExtensionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DepServiceClient.UpdateLbTrafficExtension</c> and
        /// <c>DepServiceClient.UpdateLbTrafficExtensionAsync</c>.
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
        public lro::OperationsSettings UpdateLbTrafficExtensionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DepServiceClient.DeleteLbTrafficExtension</c> and <c>DepServiceClient.DeleteLbTrafficExtensionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteLbTrafficExtensionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DepServiceClient.DeleteLbTrafficExtension</c> and
        /// <c>DepServiceClient.DeleteLbTrafficExtensionAsync</c>.
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
        public lro::OperationsSettings DeleteLbTrafficExtensionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DepServiceClient.ListLbRouteExtensions</c> and <c>DepServiceClient.ListLbRouteExtensionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListLbRouteExtensionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DepServiceClient.GetLbRouteExtension</c> and <c>DepServiceClient.GetLbRouteExtensionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetLbRouteExtensionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DepServiceClient.CreateLbRouteExtension</c> and <c>DepServiceClient.CreateLbRouteExtensionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateLbRouteExtensionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DepServiceClient.CreateLbRouteExtension</c> and
        /// <c>DepServiceClient.CreateLbRouteExtensionAsync</c>.
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
        public lro::OperationsSettings CreateLbRouteExtensionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DepServiceClient.UpdateLbRouteExtension</c> and <c>DepServiceClient.UpdateLbRouteExtensionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateLbRouteExtensionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DepServiceClient.UpdateLbRouteExtension</c> and
        /// <c>DepServiceClient.UpdateLbRouteExtensionAsync</c>.
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
        public lro::OperationsSettings UpdateLbRouteExtensionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DepServiceClient.DeleteLbRouteExtension</c> and <c>DepServiceClient.DeleteLbRouteExtensionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteLbRouteExtensionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DepServiceClient.DeleteLbRouteExtension</c> and
        /// <c>DepServiceClient.DeleteLbRouteExtensionAsync</c>.
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
        public lro::OperationsSettings DeleteLbRouteExtensionOperationsSettings { get; set; } = new lro::OperationsSettings
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
        /// <returns>A deep clone of this <see cref="DepServiceSettings"/> object.</returns>
        public DepServiceSettings Clone() => new DepServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DepServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class DepServiceClientBuilder : gaxgrpc::ClientBuilderBase<DepServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DepServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DepServiceClientBuilder() : base(DepServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DepServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DepServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DepServiceClient Build()
        {
            DepServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DepServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DepServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DepServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DepServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DepServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DepServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DepServiceClient.ChannelPool;
    }

    /// <summary>DepService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources.
    /// </remarks>
    public abstract partial class DepServiceClient
    {
        /// <summary>
        /// The default endpoint for the DepService service, which is a host of "networkservices.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "networkservices.googleapis.com:443";

        /// <summary>The default DepService scopes.</summary>
        /// <remarks>
        /// The default DepService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DepService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DepServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DepServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DepServiceClient"/>.</returns>
        public static stt::Task<DepServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DepServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DepServiceClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="DepServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DepServiceClient"/>.</returns>
        public static DepServiceClient Create() => new DepServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DepServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DepServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DepServiceClient"/>.</returns>
        internal static DepServiceClient Create(grpccore::CallInvoker callInvoker, DepServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DepService.DepServiceClient grpcClient = new DepService.DepServiceClient(callInvoker);
            return new DepServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DepService client</summary>
        public virtual DepService.DepServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `LbTrafficExtension` resources in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LbTrafficExtension"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLbTrafficExtensionsResponse, LbTrafficExtension> ListLbTrafficExtensions(ListLbTrafficExtensionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `LbTrafficExtension` resources in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LbTrafficExtension"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLbTrafficExtensionsResponse, LbTrafficExtension> ListLbTrafficExtensionsAsync(ListLbTrafficExtensionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `LbTrafficExtension` resources in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the `LbTrafficExtension`
        /// resources are listed, specified in the following format:
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="LbTrafficExtension"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLbTrafficExtensionsResponse, LbTrafficExtension> ListLbTrafficExtensions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLbTrafficExtensionsRequest request = new ListLbTrafficExtensionsRequest
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
            return ListLbTrafficExtensions(request, callSettings);
        }

        /// <summary>
        /// Lists `LbTrafficExtension` resources in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the `LbTrafficExtension`
        /// resources are listed, specified in the following format:
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="LbTrafficExtension"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLbTrafficExtensionsResponse, LbTrafficExtension> ListLbTrafficExtensionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLbTrafficExtensionsRequest request = new ListLbTrafficExtensionsRequest
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
            return ListLbTrafficExtensionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists `LbTrafficExtension` resources in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the `LbTrafficExtension`
        /// resources are listed, specified in the following format:
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="LbTrafficExtension"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLbTrafficExtensionsResponse, LbTrafficExtension> ListLbTrafficExtensions(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLbTrafficExtensionsRequest request = new ListLbTrafficExtensionsRequest
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
            return ListLbTrafficExtensions(request, callSettings);
        }

        /// <summary>
        /// Lists `LbTrafficExtension` resources in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the `LbTrafficExtension`
        /// resources are listed, specified in the following format:
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="LbTrafficExtension"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLbTrafficExtensionsResponse, LbTrafficExtension> ListLbTrafficExtensionsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLbTrafficExtensionsRequest request = new ListLbTrafficExtensionsRequest
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
            return ListLbTrafficExtensionsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified `LbTrafficExtension` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LbTrafficExtension GetLbTrafficExtension(GetLbTrafficExtensionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of the specified `LbTrafficExtension` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LbTrafficExtension> GetLbTrafficExtensionAsync(GetLbTrafficExtensionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of the specified `LbTrafficExtension` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LbTrafficExtension> GetLbTrafficExtensionAsync(GetLbTrafficExtensionRequest request, st::CancellationToken cancellationToken) =>
            GetLbTrafficExtensionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified `LbTrafficExtension` resource.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the `LbTrafficExtension` resource to get. Must be in
        /// the format
        /// `projects/{project}/locations/{location}/lbTrafficExtensions/{lb_traffic_extension}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LbTrafficExtension GetLbTrafficExtension(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLbTrafficExtension(new GetLbTrafficExtensionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified `LbTrafficExtension` resource.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the `LbTrafficExtension` resource to get. Must be in
        /// the format
        /// `projects/{project}/locations/{location}/lbTrafficExtensions/{lb_traffic_extension}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LbTrafficExtension> GetLbTrafficExtensionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLbTrafficExtensionAsync(new GetLbTrafficExtensionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified `LbTrafficExtension` resource.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the `LbTrafficExtension` resource to get. Must be in
        /// the format
        /// `projects/{project}/locations/{location}/lbTrafficExtensions/{lb_traffic_extension}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LbTrafficExtension> GetLbTrafficExtensionAsync(string name, st::CancellationToken cancellationToken) =>
            GetLbTrafficExtensionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified `LbTrafficExtension` resource.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the `LbTrafficExtension` resource to get. Must be in
        /// the format
        /// `projects/{project}/locations/{location}/lbTrafficExtensions/{lb_traffic_extension}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LbTrafficExtension GetLbTrafficExtension(LbTrafficExtensionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetLbTrafficExtension(new GetLbTrafficExtensionRequest
            {
                LbTrafficExtensionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified `LbTrafficExtension` resource.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the `LbTrafficExtension` resource to get. Must be in
        /// the format
        /// `projects/{project}/locations/{location}/lbTrafficExtensions/{lb_traffic_extension}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LbTrafficExtension> GetLbTrafficExtensionAsync(LbTrafficExtensionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetLbTrafficExtensionAsync(new GetLbTrafficExtensionRequest
            {
                LbTrafficExtensionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified `LbTrafficExtension` resource.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the `LbTrafficExtension` resource to get. Must be in
        /// the format
        /// `projects/{project}/locations/{location}/lbTrafficExtensions/{lb_traffic_extension}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LbTrafficExtension> GetLbTrafficExtensionAsync(LbTrafficExtensionName name, st::CancellationToken cancellationToken) =>
            GetLbTrafficExtensionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new `LbTrafficExtension` resource in a given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<LbTrafficExtension, OperationMetadata> CreateLbTrafficExtension(CreateLbTrafficExtensionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new `LbTrafficExtension` resource in a given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<LbTrafficExtension, OperationMetadata>> CreateLbTrafficExtensionAsync(CreateLbTrafficExtensionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new `LbTrafficExtension` resource in a given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<LbTrafficExtension, OperationMetadata>> CreateLbTrafficExtensionAsync(CreateLbTrafficExtensionRequest request, st::CancellationToken cancellationToken) =>
            CreateLbTrafficExtensionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateLbTrafficExtension</c>.</summary>
        public virtual lro::OperationsClient CreateLbTrafficExtensionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateLbTrafficExtension</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<LbTrafficExtension, OperationMetadata> PollOnceCreateLbTrafficExtension(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<LbTrafficExtension, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateLbTrafficExtensionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateLbTrafficExtension</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<LbTrafficExtension, OperationMetadata>> PollOnceCreateLbTrafficExtensionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<LbTrafficExtension, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateLbTrafficExtensionOperationsClient, callSettings);

        /// <summary>
        /// Creates a new `LbTrafficExtension` resource in a given project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the `LbTrafficExtension` resource. Must be
        /// in the format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="lbTrafficExtension">
        /// Required. `LbTrafficExtension` resource to be created.
        /// </param>
        /// <param name="lbTrafficExtensionId">
        /// Required. User-provided ID of the `LbTrafficExtension` resource to be
        /// created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<LbTrafficExtension, OperationMetadata> CreateLbTrafficExtension(string parent, LbTrafficExtension lbTrafficExtension, string lbTrafficExtensionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateLbTrafficExtension(new CreateLbTrafficExtensionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                LbTrafficExtensionId = gax::GaxPreconditions.CheckNotNullOrEmpty(lbTrafficExtensionId, nameof(lbTrafficExtensionId)),
                LbTrafficExtension = gax::GaxPreconditions.CheckNotNull(lbTrafficExtension, nameof(lbTrafficExtension)),
            }, callSettings);

        /// <summary>
        /// Creates a new `LbTrafficExtension` resource in a given project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the `LbTrafficExtension` resource. Must be
        /// in the format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="lbTrafficExtension">
        /// Required. `LbTrafficExtension` resource to be created.
        /// </param>
        /// <param name="lbTrafficExtensionId">
        /// Required. User-provided ID of the `LbTrafficExtension` resource to be
        /// created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<LbTrafficExtension, OperationMetadata>> CreateLbTrafficExtensionAsync(string parent, LbTrafficExtension lbTrafficExtension, string lbTrafficExtensionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateLbTrafficExtensionAsync(new CreateLbTrafficExtensionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                LbTrafficExtensionId = gax::GaxPreconditions.CheckNotNullOrEmpty(lbTrafficExtensionId, nameof(lbTrafficExtensionId)),
                LbTrafficExtension = gax::GaxPreconditions.CheckNotNull(lbTrafficExtension, nameof(lbTrafficExtension)),
            }, callSettings);

        /// <summary>
        /// Creates a new `LbTrafficExtension` resource in a given project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the `LbTrafficExtension` resource. Must be
        /// in the format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="lbTrafficExtension">
        /// Required. `LbTrafficExtension` resource to be created.
        /// </param>
        /// <param name="lbTrafficExtensionId">
        /// Required. User-provided ID of the `LbTrafficExtension` resource to be
        /// created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<LbTrafficExtension, OperationMetadata>> CreateLbTrafficExtensionAsync(string parent, LbTrafficExtension lbTrafficExtension, string lbTrafficExtensionId, st::CancellationToken cancellationToken) =>
            CreateLbTrafficExtensionAsync(parent, lbTrafficExtension, lbTrafficExtensionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new `LbTrafficExtension` resource in a given project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the `LbTrafficExtension` resource. Must be
        /// in the format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="lbTrafficExtension">
        /// Required. `LbTrafficExtension` resource to be created.
        /// </param>
        /// <param name="lbTrafficExtensionId">
        /// Required. User-provided ID of the `LbTrafficExtension` resource to be
        /// created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<LbTrafficExtension, OperationMetadata> CreateLbTrafficExtension(gagr::LocationName parent, LbTrafficExtension lbTrafficExtension, string lbTrafficExtensionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateLbTrafficExtension(new CreateLbTrafficExtensionRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LbTrafficExtensionId = gax::GaxPreconditions.CheckNotNullOrEmpty(lbTrafficExtensionId, nameof(lbTrafficExtensionId)),
                LbTrafficExtension = gax::GaxPreconditions.CheckNotNull(lbTrafficExtension, nameof(lbTrafficExtension)),
            }, callSettings);

        /// <summary>
        /// Creates a new `LbTrafficExtension` resource in a given project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the `LbTrafficExtension` resource. Must be
        /// in the format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="lbTrafficExtension">
        /// Required. `LbTrafficExtension` resource to be created.
        /// </param>
        /// <param name="lbTrafficExtensionId">
        /// Required. User-provided ID of the `LbTrafficExtension` resource to be
        /// created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<LbTrafficExtension, OperationMetadata>> CreateLbTrafficExtensionAsync(gagr::LocationName parent, LbTrafficExtension lbTrafficExtension, string lbTrafficExtensionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateLbTrafficExtensionAsync(new CreateLbTrafficExtensionRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LbTrafficExtensionId = gax::GaxPreconditions.CheckNotNullOrEmpty(lbTrafficExtensionId, nameof(lbTrafficExtensionId)),
                LbTrafficExtension = gax::GaxPreconditions.CheckNotNull(lbTrafficExtension, nameof(lbTrafficExtension)),
            }, callSettings);

        /// <summary>
        /// Creates a new `LbTrafficExtension` resource in a given project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the `LbTrafficExtension` resource. Must be
        /// in the format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="lbTrafficExtension">
        /// Required. `LbTrafficExtension` resource to be created.
        /// </param>
        /// <param name="lbTrafficExtensionId">
        /// Required. User-provided ID of the `LbTrafficExtension` resource to be
        /// created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<LbTrafficExtension, OperationMetadata>> CreateLbTrafficExtensionAsync(gagr::LocationName parent, LbTrafficExtension lbTrafficExtension, string lbTrafficExtensionId, st::CancellationToken cancellationToken) =>
            CreateLbTrafficExtensionAsync(parent, lbTrafficExtension, lbTrafficExtensionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of the specified `LbTrafficExtension` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<LbTrafficExtension, OperationMetadata> UpdateLbTrafficExtension(UpdateLbTrafficExtensionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of the specified `LbTrafficExtension` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<LbTrafficExtension, OperationMetadata>> UpdateLbTrafficExtensionAsync(UpdateLbTrafficExtensionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of the specified `LbTrafficExtension` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<LbTrafficExtension, OperationMetadata>> UpdateLbTrafficExtensionAsync(UpdateLbTrafficExtensionRequest request, st::CancellationToken cancellationToken) =>
            UpdateLbTrafficExtensionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateLbTrafficExtension</c>.</summary>
        public virtual lro::OperationsClient UpdateLbTrafficExtensionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateLbTrafficExtension</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<LbTrafficExtension, OperationMetadata> PollOnceUpdateLbTrafficExtension(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<LbTrafficExtension, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateLbTrafficExtensionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateLbTrafficExtension</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<LbTrafficExtension, OperationMetadata>> PollOnceUpdateLbTrafficExtensionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<LbTrafficExtension, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateLbTrafficExtensionOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of the specified `LbTrafficExtension` resource.
        /// </summary>
        /// <param name="lbTrafficExtension">
        /// Required. `LbTrafficExtension` resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Used to specify the fields to be overwritten in the
        /// `LbTrafficExtension` resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field is overwritten if it is in the mask. If the
        /// user does not specify a mask, then all fields are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<LbTrafficExtension, OperationMetadata> UpdateLbTrafficExtension(LbTrafficExtension lbTrafficExtension, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateLbTrafficExtension(new UpdateLbTrafficExtensionRequest
            {
                UpdateMask = updateMask,
                LbTrafficExtension = gax::GaxPreconditions.CheckNotNull(lbTrafficExtension, nameof(lbTrafficExtension)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of the specified `LbTrafficExtension` resource.
        /// </summary>
        /// <param name="lbTrafficExtension">
        /// Required. `LbTrafficExtension` resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Used to specify the fields to be overwritten in the
        /// `LbTrafficExtension` resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field is overwritten if it is in the mask. If the
        /// user does not specify a mask, then all fields are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<LbTrafficExtension, OperationMetadata>> UpdateLbTrafficExtensionAsync(LbTrafficExtension lbTrafficExtension, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateLbTrafficExtensionAsync(new UpdateLbTrafficExtensionRequest
            {
                UpdateMask = updateMask,
                LbTrafficExtension = gax::GaxPreconditions.CheckNotNull(lbTrafficExtension, nameof(lbTrafficExtension)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of the specified `LbTrafficExtension` resource.
        /// </summary>
        /// <param name="lbTrafficExtension">
        /// Required. `LbTrafficExtension` resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Used to specify the fields to be overwritten in the
        /// `LbTrafficExtension` resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field is overwritten if it is in the mask. If the
        /// user does not specify a mask, then all fields are overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<LbTrafficExtension, OperationMetadata>> UpdateLbTrafficExtensionAsync(LbTrafficExtension lbTrafficExtension, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateLbTrafficExtensionAsync(lbTrafficExtension, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified `LbTrafficExtension` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteLbTrafficExtension(DeleteLbTrafficExtensionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified `LbTrafficExtension` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteLbTrafficExtensionAsync(DeleteLbTrafficExtensionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified `LbTrafficExtension` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteLbTrafficExtensionAsync(DeleteLbTrafficExtensionRequest request, st::CancellationToken cancellationToken) =>
            DeleteLbTrafficExtensionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteLbTrafficExtension</c>.</summary>
        public virtual lro::OperationsClient DeleteLbTrafficExtensionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteLbTrafficExtension</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteLbTrafficExtension(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteLbTrafficExtensionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteLbTrafficExtension</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteLbTrafficExtensionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteLbTrafficExtensionOperationsClient, callSettings);

        /// <summary>
        /// Deletes the specified `LbTrafficExtension` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `LbTrafficExtension` resource to delete. Must be
        /// in the format
        /// `projects/{project}/locations/{location}/lbTrafficExtensions/{lb_traffic_extension}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteLbTrafficExtension(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteLbTrafficExtension(new DeleteLbTrafficExtensionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified `LbTrafficExtension` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `LbTrafficExtension` resource to delete. Must be
        /// in the format
        /// `projects/{project}/locations/{location}/lbTrafficExtensions/{lb_traffic_extension}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteLbTrafficExtensionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteLbTrafficExtensionAsync(new DeleteLbTrafficExtensionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified `LbTrafficExtension` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `LbTrafficExtension` resource to delete. Must be
        /// in the format
        /// `projects/{project}/locations/{location}/lbTrafficExtensions/{lb_traffic_extension}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteLbTrafficExtensionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteLbTrafficExtensionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified `LbTrafficExtension` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `LbTrafficExtension` resource to delete. Must be
        /// in the format
        /// `projects/{project}/locations/{location}/lbTrafficExtensions/{lb_traffic_extension}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteLbTrafficExtension(LbTrafficExtensionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteLbTrafficExtension(new DeleteLbTrafficExtensionRequest
            {
                LbTrafficExtensionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified `LbTrafficExtension` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `LbTrafficExtension` resource to delete. Must be
        /// in the format
        /// `projects/{project}/locations/{location}/lbTrafficExtensions/{lb_traffic_extension}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteLbTrafficExtensionAsync(LbTrafficExtensionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteLbTrafficExtensionAsync(new DeleteLbTrafficExtensionRequest
            {
                LbTrafficExtensionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified `LbTrafficExtension` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `LbTrafficExtension` resource to delete. Must be
        /// in the format
        /// `projects/{project}/locations/{location}/lbTrafficExtensions/{lb_traffic_extension}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteLbTrafficExtensionAsync(LbTrafficExtensionName name, st::CancellationToken cancellationToken) =>
            DeleteLbTrafficExtensionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists `LbRouteExtension` resources in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LbRouteExtension"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLbRouteExtensionsResponse, LbRouteExtension> ListLbRouteExtensions(ListLbRouteExtensionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `LbRouteExtension` resources in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LbRouteExtension"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLbRouteExtensionsResponse, LbRouteExtension> ListLbRouteExtensionsAsync(ListLbRouteExtensionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `LbRouteExtension` resources in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the `LbRouteExtension`
        /// resources are listed, specified in the following format:
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="LbRouteExtension"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLbRouteExtensionsResponse, LbRouteExtension> ListLbRouteExtensions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLbRouteExtensionsRequest request = new ListLbRouteExtensionsRequest
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
            return ListLbRouteExtensions(request, callSettings);
        }

        /// <summary>
        /// Lists `LbRouteExtension` resources in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the `LbRouteExtension`
        /// resources are listed, specified in the following format:
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="LbRouteExtension"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLbRouteExtensionsResponse, LbRouteExtension> ListLbRouteExtensionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLbRouteExtensionsRequest request = new ListLbRouteExtensionsRequest
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
            return ListLbRouteExtensionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists `LbRouteExtension` resources in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the `LbRouteExtension`
        /// resources are listed, specified in the following format:
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="LbRouteExtension"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLbRouteExtensionsResponse, LbRouteExtension> ListLbRouteExtensions(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLbRouteExtensionsRequest request = new ListLbRouteExtensionsRequest
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
            return ListLbRouteExtensions(request, callSettings);
        }

        /// <summary>
        /// Lists `LbRouteExtension` resources in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the `LbRouteExtension`
        /// resources are listed, specified in the following format:
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="LbRouteExtension"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLbRouteExtensionsResponse, LbRouteExtension> ListLbRouteExtensionsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLbRouteExtensionsRequest request = new ListLbRouteExtensionsRequest
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
            return ListLbRouteExtensionsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified `LbRouteExtension` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LbRouteExtension GetLbRouteExtension(GetLbRouteExtensionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of the specified `LbRouteExtension` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LbRouteExtension> GetLbRouteExtensionAsync(GetLbRouteExtensionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of the specified `LbRouteExtension` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LbRouteExtension> GetLbRouteExtensionAsync(GetLbRouteExtensionRequest request, st::CancellationToken cancellationToken) =>
            GetLbRouteExtensionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified `LbRouteExtension` resource.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the `LbRouteExtension` resource to get. Must be in the
        /// format
        /// `projects/{project}/locations/{location}/lbRouteExtensions/{lb_route_extension}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LbRouteExtension GetLbRouteExtension(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLbRouteExtension(new GetLbRouteExtensionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified `LbRouteExtension` resource.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the `LbRouteExtension` resource to get. Must be in the
        /// format
        /// `projects/{project}/locations/{location}/lbRouteExtensions/{lb_route_extension}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LbRouteExtension> GetLbRouteExtensionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLbRouteExtensionAsync(new GetLbRouteExtensionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified `LbRouteExtension` resource.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the `LbRouteExtension` resource to get. Must be in the
        /// format
        /// `projects/{project}/locations/{location}/lbRouteExtensions/{lb_route_extension}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LbRouteExtension> GetLbRouteExtensionAsync(string name, st::CancellationToken cancellationToken) =>
            GetLbRouteExtensionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified `LbRouteExtension` resource.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the `LbRouteExtension` resource to get. Must be in the
        /// format
        /// `projects/{project}/locations/{location}/lbRouteExtensions/{lb_route_extension}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LbRouteExtension GetLbRouteExtension(LbRouteExtensionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetLbRouteExtension(new GetLbRouteExtensionRequest
            {
                LbRouteExtensionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified `LbRouteExtension` resource.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the `LbRouteExtension` resource to get. Must be in the
        /// format
        /// `projects/{project}/locations/{location}/lbRouteExtensions/{lb_route_extension}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LbRouteExtension> GetLbRouteExtensionAsync(LbRouteExtensionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetLbRouteExtensionAsync(new GetLbRouteExtensionRequest
            {
                LbRouteExtensionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified `LbRouteExtension` resource.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the `LbRouteExtension` resource to get. Must be in the
        /// format
        /// `projects/{project}/locations/{location}/lbRouteExtensions/{lb_route_extension}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LbRouteExtension> GetLbRouteExtensionAsync(LbRouteExtensionName name, st::CancellationToken cancellationToken) =>
            GetLbRouteExtensionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new `LbRouteExtension` resource in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<LbRouteExtension, OperationMetadata> CreateLbRouteExtension(CreateLbRouteExtensionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new `LbRouteExtension` resource in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<LbRouteExtension, OperationMetadata>> CreateLbRouteExtensionAsync(CreateLbRouteExtensionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new `LbRouteExtension` resource in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<LbRouteExtension, OperationMetadata>> CreateLbRouteExtensionAsync(CreateLbRouteExtensionRequest request, st::CancellationToken cancellationToken) =>
            CreateLbRouteExtensionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateLbRouteExtension</c>.</summary>
        public virtual lro::OperationsClient CreateLbRouteExtensionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateLbRouteExtension</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<LbRouteExtension, OperationMetadata> PollOnceCreateLbRouteExtension(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<LbRouteExtension, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateLbRouteExtensionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateLbRouteExtension</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<LbRouteExtension, OperationMetadata>> PollOnceCreateLbRouteExtensionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<LbRouteExtension, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateLbRouteExtensionOperationsClient, callSettings);

        /// <summary>
        /// Creates a new `LbRouteExtension` resource in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the `LbRouteExtension` resource. Must be
        /// in the format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="lbRouteExtension">
        /// Required. `LbRouteExtension` resource to be created.
        /// </param>
        /// <param name="lbRouteExtensionId">
        /// Required. User-provided ID of the `LbRouteExtension` resource to be
        /// created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<LbRouteExtension, OperationMetadata> CreateLbRouteExtension(string parent, LbRouteExtension lbRouteExtension, string lbRouteExtensionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateLbRouteExtension(new CreateLbRouteExtensionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                LbRouteExtensionId = gax::GaxPreconditions.CheckNotNullOrEmpty(lbRouteExtensionId, nameof(lbRouteExtensionId)),
                LbRouteExtension = gax::GaxPreconditions.CheckNotNull(lbRouteExtension, nameof(lbRouteExtension)),
            }, callSettings);

        /// <summary>
        /// Creates a new `LbRouteExtension` resource in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the `LbRouteExtension` resource. Must be
        /// in the format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="lbRouteExtension">
        /// Required. `LbRouteExtension` resource to be created.
        /// </param>
        /// <param name="lbRouteExtensionId">
        /// Required. User-provided ID of the `LbRouteExtension` resource to be
        /// created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<LbRouteExtension, OperationMetadata>> CreateLbRouteExtensionAsync(string parent, LbRouteExtension lbRouteExtension, string lbRouteExtensionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateLbRouteExtensionAsync(new CreateLbRouteExtensionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                LbRouteExtensionId = gax::GaxPreconditions.CheckNotNullOrEmpty(lbRouteExtensionId, nameof(lbRouteExtensionId)),
                LbRouteExtension = gax::GaxPreconditions.CheckNotNull(lbRouteExtension, nameof(lbRouteExtension)),
            }, callSettings);

        /// <summary>
        /// Creates a new `LbRouteExtension` resource in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the `LbRouteExtension` resource. Must be
        /// in the format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="lbRouteExtension">
        /// Required. `LbRouteExtension` resource to be created.
        /// </param>
        /// <param name="lbRouteExtensionId">
        /// Required. User-provided ID of the `LbRouteExtension` resource to be
        /// created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<LbRouteExtension, OperationMetadata>> CreateLbRouteExtensionAsync(string parent, LbRouteExtension lbRouteExtension, string lbRouteExtensionId, st::CancellationToken cancellationToken) =>
            CreateLbRouteExtensionAsync(parent, lbRouteExtension, lbRouteExtensionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new `LbRouteExtension` resource in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the `LbRouteExtension` resource. Must be
        /// in the format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="lbRouteExtension">
        /// Required. `LbRouteExtension` resource to be created.
        /// </param>
        /// <param name="lbRouteExtensionId">
        /// Required. User-provided ID of the `LbRouteExtension` resource to be
        /// created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<LbRouteExtension, OperationMetadata> CreateLbRouteExtension(gagr::LocationName parent, LbRouteExtension lbRouteExtension, string lbRouteExtensionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateLbRouteExtension(new CreateLbRouteExtensionRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LbRouteExtensionId = gax::GaxPreconditions.CheckNotNullOrEmpty(lbRouteExtensionId, nameof(lbRouteExtensionId)),
                LbRouteExtension = gax::GaxPreconditions.CheckNotNull(lbRouteExtension, nameof(lbRouteExtension)),
            }, callSettings);

        /// <summary>
        /// Creates a new `LbRouteExtension` resource in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the `LbRouteExtension` resource. Must be
        /// in the format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="lbRouteExtension">
        /// Required. `LbRouteExtension` resource to be created.
        /// </param>
        /// <param name="lbRouteExtensionId">
        /// Required. User-provided ID of the `LbRouteExtension` resource to be
        /// created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<LbRouteExtension, OperationMetadata>> CreateLbRouteExtensionAsync(gagr::LocationName parent, LbRouteExtension lbRouteExtension, string lbRouteExtensionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateLbRouteExtensionAsync(new CreateLbRouteExtensionRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LbRouteExtensionId = gax::GaxPreconditions.CheckNotNullOrEmpty(lbRouteExtensionId, nameof(lbRouteExtensionId)),
                LbRouteExtension = gax::GaxPreconditions.CheckNotNull(lbRouteExtension, nameof(lbRouteExtension)),
            }, callSettings);

        /// <summary>
        /// Creates a new `LbRouteExtension` resource in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the `LbRouteExtension` resource. Must be
        /// in the format `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="lbRouteExtension">
        /// Required. `LbRouteExtension` resource to be created.
        /// </param>
        /// <param name="lbRouteExtensionId">
        /// Required. User-provided ID of the `LbRouteExtension` resource to be
        /// created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<LbRouteExtension, OperationMetadata>> CreateLbRouteExtensionAsync(gagr::LocationName parent, LbRouteExtension lbRouteExtension, string lbRouteExtensionId, st::CancellationToken cancellationToken) =>
            CreateLbRouteExtensionAsync(parent, lbRouteExtension, lbRouteExtensionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of the specified `LbRouteExtension` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<LbRouteExtension, OperationMetadata> UpdateLbRouteExtension(UpdateLbRouteExtensionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of the specified `LbRouteExtension` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<LbRouteExtension, OperationMetadata>> UpdateLbRouteExtensionAsync(UpdateLbRouteExtensionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of the specified `LbRouteExtension` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<LbRouteExtension, OperationMetadata>> UpdateLbRouteExtensionAsync(UpdateLbRouteExtensionRequest request, st::CancellationToken cancellationToken) =>
            UpdateLbRouteExtensionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateLbRouteExtension</c>.</summary>
        public virtual lro::OperationsClient UpdateLbRouteExtensionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateLbRouteExtension</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<LbRouteExtension, OperationMetadata> PollOnceUpdateLbRouteExtension(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<LbRouteExtension, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateLbRouteExtensionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateLbRouteExtension</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<LbRouteExtension, OperationMetadata>> PollOnceUpdateLbRouteExtensionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<LbRouteExtension, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateLbRouteExtensionOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of the specified `LbRouteExtension` resource.
        /// </summary>
        /// <param name="lbRouteExtension">
        /// Required. `LbRouteExtension` resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Used to specify the fields to be overwritten in the
        /// `LbRouteExtension` resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field is overwritten if it is in the mask. If the
        /// user does not specify a mask, then all fields are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<LbRouteExtension, OperationMetadata> UpdateLbRouteExtension(LbRouteExtension lbRouteExtension, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateLbRouteExtension(new UpdateLbRouteExtensionRequest
            {
                UpdateMask = updateMask,
                LbRouteExtension = gax::GaxPreconditions.CheckNotNull(lbRouteExtension, nameof(lbRouteExtension)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of the specified `LbRouteExtension` resource.
        /// </summary>
        /// <param name="lbRouteExtension">
        /// Required. `LbRouteExtension` resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Used to specify the fields to be overwritten in the
        /// `LbRouteExtension` resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field is overwritten if it is in the mask. If the
        /// user does not specify a mask, then all fields are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<LbRouteExtension, OperationMetadata>> UpdateLbRouteExtensionAsync(LbRouteExtension lbRouteExtension, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateLbRouteExtensionAsync(new UpdateLbRouteExtensionRequest
            {
                UpdateMask = updateMask,
                LbRouteExtension = gax::GaxPreconditions.CheckNotNull(lbRouteExtension, nameof(lbRouteExtension)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of the specified `LbRouteExtension` resource.
        /// </summary>
        /// <param name="lbRouteExtension">
        /// Required. `LbRouteExtension` resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Used to specify the fields to be overwritten in the
        /// `LbRouteExtension` resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field is overwritten if it is in the mask. If the
        /// user does not specify a mask, then all fields are overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<LbRouteExtension, OperationMetadata>> UpdateLbRouteExtensionAsync(LbRouteExtension lbRouteExtension, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateLbRouteExtensionAsync(lbRouteExtension, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified `LbRouteExtension` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteLbRouteExtension(DeleteLbRouteExtensionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified `LbRouteExtension` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteLbRouteExtensionAsync(DeleteLbRouteExtensionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified `LbRouteExtension` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteLbRouteExtensionAsync(DeleteLbRouteExtensionRequest request, st::CancellationToken cancellationToken) =>
            DeleteLbRouteExtensionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteLbRouteExtension</c>.</summary>
        public virtual lro::OperationsClient DeleteLbRouteExtensionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteLbRouteExtension</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteLbRouteExtension(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteLbRouteExtensionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteLbRouteExtension</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteLbRouteExtensionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteLbRouteExtensionOperationsClient, callSettings);

        /// <summary>
        /// Deletes the specified `LbRouteExtension` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `LbRouteExtension` resource to delete. Must be in
        /// the format
        /// `projects/{project}/locations/{location}/lbRouteExtensions/{lb_route_extension}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteLbRouteExtension(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteLbRouteExtension(new DeleteLbRouteExtensionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified `LbRouteExtension` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `LbRouteExtension` resource to delete. Must be in
        /// the format
        /// `projects/{project}/locations/{location}/lbRouteExtensions/{lb_route_extension}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteLbRouteExtensionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteLbRouteExtensionAsync(new DeleteLbRouteExtensionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified `LbRouteExtension` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `LbRouteExtension` resource to delete. Must be in
        /// the format
        /// `projects/{project}/locations/{location}/lbRouteExtensions/{lb_route_extension}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteLbRouteExtensionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteLbRouteExtensionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified `LbRouteExtension` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `LbRouteExtension` resource to delete. Must be in
        /// the format
        /// `projects/{project}/locations/{location}/lbRouteExtensions/{lb_route_extension}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteLbRouteExtension(LbRouteExtensionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteLbRouteExtension(new DeleteLbRouteExtensionRequest
            {
                LbRouteExtensionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified `LbRouteExtension` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `LbRouteExtension` resource to delete. Must be in
        /// the format
        /// `projects/{project}/locations/{location}/lbRouteExtensions/{lb_route_extension}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteLbRouteExtensionAsync(LbRouteExtensionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteLbRouteExtensionAsync(new DeleteLbRouteExtensionRequest
            {
                LbRouteExtensionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified `LbRouteExtension` resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `LbRouteExtension` resource to delete. Must be in
        /// the format
        /// `projects/{project}/locations/{location}/lbRouteExtensions/{lb_route_extension}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteLbRouteExtensionAsync(LbRouteExtensionName name, st::CancellationToken cancellationToken) =>
            DeleteLbRouteExtensionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DepService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources.
    /// </remarks>
    public sealed partial class DepServiceClientImpl : DepServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListLbTrafficExtensionsRequest, ListLbTrafficExtensionsResponse> _callListLbTrafficExtensions;

        private readonly gaxgrpc::ApiCall<GetLbTrafficExtensionRequest, LbTrafficExtension> _callGetLbTrafficExtension;

        private readonly gaxgrpc::ApiCall<CreateLbTrafficExtensionRequest, lro::Operation> _callCreateLbTrafficExtension;

        private readonly gaxgrpc::ApiCall<UpdateLbTrafficExtensionRequest, lro::Operation> _callUpdateLbTrafficExtension;

        private readonly gaxgrpc::ApiCall<DeleteLbTrafficExtensionRequest, lro::Operation> _callDeleteLbTrafficExtension;

        private readonly gaxgrpc::ApiCall<ListLbRouteExtensionsRequest, ListLbRouteExtensionsResponse> _callListLbRouteExtensions;

        private readonly gaxgrpc::ApiCall<GetLbRouteExtensionRequest, LbRouteExtension> _callGetLbRouteExtension;

        private readonly gaxgrpc::ApiCall<CreateLbRouteExtensionRequest, lro::Operation> _callCreateLbRouteExtension;

        private readonly gaxgrpc::ApiCall<UpdateLbRouteExtensionRequest, lro::Operation> _callUpdateLbRouteExtension;

        private readonly gaxgrpc::ApiCall<DeleteLbRouteExtensionRequest, lro::Operation> _callDeleteLbRouteExtension;

        /// <summary>
        /// Constructs a client wrapper for the DepService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DepServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DepServiceClientImpl(DepService.DepServiceClient grpcClient, DepServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DepServiceSettings effectiveSettings = settings ?? DepServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateLbTrafficExtensionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateLbTrafficExtensionOperationsSettings, logger);
            UpdateLbTrafficExtensionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateLbTrafficExtensionOperationsSettings, logger);
            DeleteLbTrafficExtensionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteLbTrafficExtensionOperationsSettings, logger);
            CreateLbRouteExtensionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateLbRouteExtensionOperationsSettings, logger);
            UpdateLbRouteExtensionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateLbRouteExtensionOperationsSettings, logger);
            DeleteLbRouteExtensionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteLbRouteExtensionOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListLbTrafficExtensions = clientHelper.BuildApiCall<ListLbTrafficExtensionsRequest, ListLbTrafficExtensionsResponse>("ListLbTrafficExtensions", grpcClient.ListLbTrafficExtensionsAsync, grpcClient.ListLbTrafficExtensions, effectiveSettings.ListLbTrafficExtensionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListLbTrafficExtensions);
            Modify_ListLbTrafficExtensionsApiCall(ref _callListLbTrafficExtensions);
            _callGetLbTrafficExtension = clientHelper.BuildApiCall<GetLbTrafficExtensionRequest, LbTrafficExtension>("GetLbTrafficExtension", grpcClient.GetLbTrafficExtensionAsync, grpcClient.GetLbTrafficExtension, effectiveSettings.GetLbTrafficExtensionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetLbTrafficExtension);
            Modify_GetLbTrafficExtensionApiCall(ref _callGetLbTrafficExtension);
            _callCreateLbTrafficExtension = clientHelper.BuildApiCall<CreateLbTrafficExtensionRequest, lro::Operation>("CreateLbTrafficExtension", grpcClient.CreateLbTrafficExtensionAsync, grpcClient.CreateLbTrafficExtension, effectiveSettings.CreateLbTrafficExtensionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateLbTrafficExtension);
            Modify_CreateLbTrafficExtensionApiCall(ref _callCreateLbTrafficExtension);
            _callUpdateLbTrafficExtension = clientHelper.BuildApiCall<UpdateLbTrafficExtensionRequest, lro::Operation>("UpdateLbTrafficExtension", grpcClient.UpdateLbTrafficExtensionAsync, grpcClient.UpdateLbTrafficExtension, effectiveSettings.UpdateLbTrafficExtensionSettings).WithGoogleRequestParam("lb_traffic_extension.name", request => request.LbTrafficExtension?.Name);
            Modify_ApiCall(ref _callUpdateLbTrafficExtension);
            Modify_UpdateLbTrafficExtensionApiCall(ref _callUpdateLbTrafficExtension);
            _callDeleteLbTrafficExtension = clientHelper.BuildApiCall<DeleteLbTrafficExtensionRequest, lro::Operation>("DeleteLbTrafficExtension", grpcClient.DeleteLbTrafficExtensionAsync, grpcClient.DeleteLbTrafficExtension, effectiveSettings.DeleteLbTrafficExtensionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteLbTrafficExtension);
            Modify_DeleteLbTrafficExtensionApiCall(ref _callDeleteLbTrafficExtension);
            _callListLbRouteExtensions = clientHelper.BuildApiCall<ListLbRouteExtensionsRequest, ListLbRouteExtensionsResponse>("ListLbRouteExtensions", grpcClient.ListLbRouteExtensionsAsync, grpcClient.ListLbRouteExtensions, effectiveSettings.ListLbRouteExtensionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListLbRouteExtensions);
            Modify_ListLbRouteExtensionsApiCall(ref _callListLbRouteExtensions);
            _callGetLbRouteExtension = clientHelper.BuildApiCall<GetLbRouteExtensionRequest, LbRouteExtension>("GetLbRouteExtension", grpcClient.GetLbRouteExtensionAsync, grpcClient.GetLbRouteExtension, effectiveSettings.GetLbRouteExtensionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetLbRouteExtension);
            Modify_GetLbRouteExtensionApiCall(ref _callGetLbRouteExtension);
            _callCreateLbRouteExtension = clientHelper.BuildApiCall<CreateLbRouteExtensionRequest, lro::Operation>("CreateLbRouteExtension", grpcClient.CreateLbRouteExtensionAsync, grpcClient.CreateLbRouteExtension, effectiveSettings.CreateLbRouteExtensionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateLbRouteExtension);
            Modify_CreateLbRouteExtensionApiCall(ref _callCreateLbRouteExtension);
            _callUpdateLbRouteExtension = clientHelper.BuildApiCall<UpdateLbRouteExtensionRequest, lro::Operation>("UpdateLbRouteExtension", grpcClient.UpdateLbRouteExtensionAsync, grpcClient.UpdateLbRouteExtension, effectiveSettings.UpdateLbRouteExtensionSettings).WithGoogleRequestParam("lb_route_extension.name", request => request.LbRouteExtension?.Name);
            Modify_ApiCall(ref _callUpdateLbRouteExtension);
            Modify_UpdateLbRouteExtensionApiCall(ref _callUpdateLbRouteExtension);
            _callDeleteLbRouteExtension = clientHelper.BuildApiCall<DeleteLbRouteExtensionRequest, lro::Operation>("DeleteLbRouteExtension", grpcClient.DeleteLbRouteExtensionAsync, grpcClient.DeleteLbRouteExtension, effectiveSettings.DeleteLbRouteExtensionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteLbRouteExtension);
            Modify_DeleteLbRouteExtensionApiCall(ref _callDeleteLbRouteExtension);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListLbTrafficExtensionsApiCall(ref gaxgrpc::ApiCall<ListLbTrafficExtensionsRequest, ListLbTrafficExtensionsResponse> call);

        partial void Modify_GetLbTrafficExtensionApiCall(ref gaxgrpc::ApiCall<GetLbTrafficExtensionRequest, LbTrafficExtension> call);

        partial void Modify_CreateLbTrafficExtensionApiCall(ref gaxgrpc::ApiCall<CreateLbTrafficExtensionRequest, lro::Operation> call);

        partial void Modify_UpdateLbTrafficExtensionApiCall(ref gaxgrpc::ApiCall<UpdateLbTrafficExtensionRequest, lro::Operation> call);

        partial void Modify_DeleteLbTrafficExtensionApiCall(ref gaxgrpc::ApiCall<DeleteLbTrafficExtensionRequest, lro::Operation> call);

        partial void Modify_ListLbRouteExtensionsApiCall(ref gaxgrpc::ApiCall<ListLbRouteExtensionsRequest, ListLbRouteExtensionsResponse> call);

        partial void Modify_GetLbRouteExtensionApiCall(ref gaxgrpc::ApiCall<GetLbRouteExtensionRequest, LbRouteExtension> call);

        partial void Modify_CreateLbRouteExtensionApiCall(ref gaxgrpc::ApiCall<CreateLbRouteExtensionRequest, lro::Operation> call);

        partial void Modify_UpdateLbRouteExtensionApiCall(ref gaxgrpc::ApiCall<UpdateLbRouteExtensionRequest, lro::Operation> call);

        partial void Modify_DeleteLbRouteExtensionApiCall(ref gaxgrpc::ApiCall<DeleteLbRouteExtensionRequest, lro::Operation> call);

        partial void OnConstruction(DepService.DepServiceClient grpcClient, DepServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DepService client</summary>
        public override DepService.DepServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListLbTrafficExtensionsRequest(ref ListLbTrafficExtensionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetLbTrafficExtensionRequest(ref GetLbTrafficExtensionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateLbTrafficExtensionRequest(ref CreateLbTrafficExtensionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateLbTrafficExtensionRequest(ref UpdateLbTrafficExtensionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteLbTrafficExtensionRequest(ref DeleteLbTrafficExtensionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListLbRouteExtensionsRequest(ref ListLbRouteExtensionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetLbRouteExtensionRequest(ref GetLbRouteExtensionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateLbRouteExtensionRequest(ref CreateLbRouteExtensionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateLbRouteExtensionRequest(ref UpdateLbRouteExtensionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteLbRouteExtensionRequest(ref DeleteLbRouteExtensionRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists `LbTrafficExtension` resources in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LbTrafficExtension"/> resources.</returns>
        public override gax::PagedEnumerable<ListLbTrafficExtensionsResponse, LbTrafficExtension> ListLbTrafficExtensions(ListLbTrafficExtensionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLbTrafficExtensionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListLbTrafficExtensionsRequest, ListLbTrafficExtensionsResponse, LbTrafficExtension>(_callListLbTrafficExtensions, request, callSettings);
        }

        /// <summary>
        /// Lists `LbTrafficExtension` resources in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LbTrafficExtension"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListLbTrafficExtensionsResponse, LbTrafficExtension> ListLbTrafficExtensionsAsync(ListLbTrafficExtensionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLbTrafficExtensionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListLbTrafficExtensionsRequest, ListLbTrafficExtensionsResponse, LbTrafficExtension>(_callListLbTrafficExtensions, request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified `LbTrafficExtension` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LbTrafficExtension GetLbTrafficExtension(GetLbTrafficExtensionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLbTrafficExtensionRequest(ref request, ref callSettings);
            return _callGetLbTrafficExtension.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified `LbTrafficExtension` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LbTrafficExtension> GetLbTrafficExtensionAsync(GetLbTrafficExtensionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLbTrafficExtensionRequest(ref request, ref callSettings);
            return _callGetLbTrafficExtension.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateLbTrafficExtension</c>.</summary>
        public override lro::OperationsClient CreateLbTrafficExtensionOperationsClient { get; }

        /// <summary>
        /// Creates a new `LbTrafficExtension` resource in a given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<LbTrafficExtension, OperationMetadata> CreateLbTrafficExtension(CreateLbTrafficExtensionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateLbTrafficExtensionRequest(ref request, ref callSettings);
            return new lro::Operation<LbTrafficExtension, OperationMetadata>(_callCreateLbTrafficExtension.Sync(request, callSettings), CreateLbTrafficExtensionOperationsClient);
        }

        /// <summary>
        /// Creates a new `LbTrafficExtension` resource in a given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<LbTrafficExtension, OperationMetadata>> CreateLbTrafficExtensionAsync(CreateLbTrafficExtensionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateLbTrafficExtensionRequest(ref request, ref callSettings);
            return new lro::Operation<LbTrafficExtension, OperationMetadata>(await _callCreateLbTrafficExtension.Async(request, callSettings).ConfigureAwait(false), CreateLbTrafficExtensionOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateLbTrafficExtension</c>.</summary>
        public override lro::OperationsClient UpdateLbTrafficExtensionOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of the specified `LbTrafficExtension` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<LbTrafficExtension, OperationMetadata> UpdateLbTrafficExtension(UpdateLbTrafficExtensionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateLbTrafficExtensionRequest(ref request, ref callSettings);
            return new lro::Operation<LbTrafficExtension, OperationMetadata>(_callUpdateLbTrafficExtension.Sync(request, callSettings), UpdateLbTrafficExtensionOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of the specified `LbTrafficExtension` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<LbTrafficExtension, OperationMetadata>> UpdateLbTrafficExtensionAsync(UpdateLbTrafficExtensionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateLbTrafficExtensionRequest(ref request, ref callSettings);
            return new lro::Operation<LbTrafficExtension, OperationMetadata>(await _callUpdateLbTrafficExtension.Async(request, callSettings).ConfigureAwait(false), UpdateLbTrafficExtensionOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteLbTrafficExtension</c>.</summary>
        public override lro::OperationsClient DeleteLbTrafficExtensionOperationsClient { get; }

        /// <summary>
        /// Deletes the specified `LbTrafficExtension` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteLbTrafficExtension(DeleteLbTrafficExtensionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteLbTrafficExtensionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteLbTrafficExtension.Sync(request, callSettings), DeleteLbTrafficExtensionOperationsClient);
        }

        /// <summary>
        /// Deletes the specified `LbTrafficExtension` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteLbTrafficExtensionAsync(DeleteLbTrafficExtensionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteLbTrafficExtensionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteLbTrafficExtension.Async(request, callSettings).ConfigureAwait(false), DeleteLbTrafficExtensionOperationsClient);
        }

        /// <summary>
        /// Lists `LbRouteExtension` resources in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LbRouteExtension"/> resources.</returns>
        public override gax::PagedEnumerable<ListLbRouteExtensionsResponse, LbRouteExtension> ListLbRouteExtensions(ListLbRouteExtensionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLbRouteExtensionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListLbRouteExtensionsRequest, ListLbRouteExtensionsResponse, LbRouteExtension>(_callListLbRouteExtensions, request, callSettings);
        }

        /// <summary>
        /// Lists `LbRouteExtension` resources in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LbRouteExtension"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListLbRouteExtensionsResponse, LbRouteExtension> ListLbRouteExtensionsAsync(ListLbRouteExtensionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLbRouteExtensionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListLbRouteExtensionsRequest, ListLbRouteExtensionsResponse, LbRouteExtension>(_callListLbRouteExtensions, request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified `LbRouteExtension` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LbRouteExtension GetLbRouteExtension(GetLbRouteExtensionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLbRouteExtensionRequest(ref request, ref callSettings);
            return _callGetLbRouteExtension.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified `LbRouteExtension` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LbRouteExtension> GetLbRouteExtensionAsync(GetLbRouteExtensionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLbRouteExtensionRequest(ref request, ref callSettings);
            return _callGetLbRouteExtension.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateLbRouteExtension</c>.</summary>
        public override lro::OperationsClient CreateLbRouteExtensionOperationsClient { get; }

        /// <summary>
        /// Creates a new `LbRouteExtension` resource in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<LbRouteExtension, OperationMetadata> CreateLbRouteExtension(CreateLbRouteExtensionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateLbRouteExtensionRequest(ref request, ref callSettings);
            return new lro::Operation<LbRouteExtension, OperationMetadata>(_callCreateLbRouteExtension.Sync(request, callSettings), CreateLbRouteExtensionOperationsClient);
        }

        /// <summary>
        /// Creates a new `LbRouteExtension` resource in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<LbRouteExtension, OperationMetadata>> CreateLbRouteExtensionAsync(CreateLbRouteExtensionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateLbRouteExtensionRequest(ref request, ref callSettings);
            return new lro::Operation<LbRouteExtension, OperationMetadata>(await _callCreateLbRouteExtension.Async(request, callSettings).ConfigureAwait(false), CreateLbRouteExtensionOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateLbRouteExtension</c>.</summary>
        public override lro::OperationsClient UpdateLbRouteExtensionOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of the specified `LbRouteExtension` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<LbRouteExtension, OperationMetadata> UpdateLbRouteExtension(UpdateLbRouteExtensionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateLbRouteExtensionRequest(ref request, ref callSettings);
            return new lro::Operation<LbRouteExtension, OperationMetadata>(_callUpdateLbRouteExtension.Sync(request, callSettings), UpdateLbRouteExtensionOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of the specified `LbRouteExtension` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<LbRouteExtension, OperationMetadata>> UpdateLbRouteExtensionAsync(UpdateLbRouteExtensionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateLbRouteExtensionRequest(ref request, ref callSettings);
            return new lro::Operation<LbRouteExtension, OperationMetadata>(await _callUpdateLbRouteExtension.Async(request, callSettings).ConfigureAwait(false), UpdateLbRouteExtensionOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteLbRouteExtension</c>.</summary>
        public override lro::OperationsClient DeleteLbRouteExtensionOperationsClient { get; }

        /// <summary>
        /// Deletes the specified `LbRouteExtension` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteLbRouteExtension(DeleteLbRouteExtensionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteLbRouteExtensionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteLbRouteExtension.Sync(request, callSettings), DeleteLbRouteExtensionOperationsClient);
        }

        /// <summary>
        /// Deletes the specified `LbRouteExtension` resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteLbRouteExtensionAsync(DeleteLbRouteExtensionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteLbRouteExtensionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteLbRouteExtension.Async(request, callSettings).ConfigureAwait(false), DeleteLbRouteExtensionOperationsClient);
        }
    }

    public partial class ListLbTrafficExtensionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListLbRouteExtensionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListLbTrafficExtensionsResponse : gaxgrpc::IPageResponse<LbTrafficExtension>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<LbTrafficExtension> GetEnumerator() => LbTrafficExtensions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListLbRouteExtensionsResponse : gaxgrpc::IPageResponse<LbRouteExtension>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<LbRouteExtension> GetEnumerator() => LbRouteExtensions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class DepService
    {
        public partial class DepServiceClient
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

    public static partial class DepService
    {
        public partial class DepServiceClient
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
