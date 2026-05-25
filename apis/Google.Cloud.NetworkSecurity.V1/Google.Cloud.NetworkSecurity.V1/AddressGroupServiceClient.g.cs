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

namespace Google.Cloud.NetworkSecurity.V1
{
    /// <summary>Settings for <see cref="AddressGroupServiceClient"/> instances.</summary>
    public sealed partial class AddressGroupServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AddressGroupServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AddressGroupServiceSettings"/>.</returns>
        public static AddressGroupServiceSettings GetDefault() => new AddressGroupServiceSettings();

        /// <summary>Constructs a new <see cref="AddressGroupServiceSettings"/> object with default settings.</summary>
        public AddressGroupServiceSettings()
        {
        }

        private AddressGroupServiceSettings(AddressGroupServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListAddressGroupsSettings = existing.ListAddressGroupsSettings;
            GetAddressGroupSettings = existing.GetAddressGroupSettings;
            CreateAddressGroupSettings = existing.CreateAddressGroupSettings;
            CreateAddressGroupOperationsSettings = existing.CreateAddressGroupOperationsSettings.Clone();
            UpdateAddressGroupSettings = existing.UpdateAddressGroupSettings;
            UpdateAddressGroupOperationsSettings = existing.UpdateAddressGroupOperationsSettings.Clone();
            AddAddressGroupItemsSettings = existing.AddAddressGroupItemsSettings;
            AddAddressGroupItemsOperationsSettings = existing.AddAddressGroupItemsOperationsSettings.Clone();
            RemoveAddressGroupItemsSettings = existing.RemoveAddressGroupItemsSettings;
            RemoveAddressGroupItemsOperationsSettings = existing.RemoveAddressGroupItemsOperationsSettings.Clone();
            CloneAddressGroupItemsSettings = existing.CloneAddressGroupItemsSettings;
            CloneAddressGroupItemsOperationsSettings = existing.CloneAddressGroupItemsOperationsSettings.Clone();
            DeleteAddressGroupSettings = existing.DeleteAddressGroupSettings;
            DeleteAddressGroupOperationsSettings = existing.DeleteAddressGroupOperationsSettings.Clone();
            ListAddressGroupReferencesSettings = existing.ListAddressGroupReferencesSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(AddressGroupServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AddressGroupServiceClient.ListAddressGroups</c> and <c>AddressGroupServiceClient.ListAddressGroupsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAddressGroupsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AddressGroupServiceClient.GetAddressGroup</c> and <c>AddressGroupServiceClient.GetAddressGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAddressGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AddressGroupServiceClient.CreateAddressGroup</c> and <c>AddressGroupServiceClient.CreateAddressGroupAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAddressGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>AddressGroupServiceClient.CreateAddressGroup</c> and
        /// <c>AddressGroupServiceClient.CreateAddressGroupAsync</c>.
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
        public lro::OperationsSettings CreateAddressGroupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AddressGroupServiceClient.UpdateAddressGroup</c> and <c>AddressGroupServiceClient.UpdateAddressGroupAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAddressGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>AddressGroupServiceClient.UpdateAddressGroup</c> and
        /// <c>AddressGroupServiceClient.UpdateAddressGroupAsync</c>.
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
        public lro::OperationsSettings UpdateAddressGroupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AddressGroupServiceClient.AddAddressGroupItems</c> and
        /// <c>AddressGroupServiceClient.AddAddressGroupItemsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AddAddressGroupItemsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>AddressGroupServiceClient.AddAddressGroupItems</c> and
        /// <c>AddressGroupServiceClient.AddAddressGroupItemsAsync</c>.
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
        public lro::OperationsSettings AddAddressGroupItemsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AddressGroupServiceClient.RemoveAddressGroupItems</c> and
        /// <c>AddressGroupServiceClient.RemoveAddressGroupItemsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RemoveAddressGroupItemsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>AddressGroupServiceClient.RemoveAddressGroupItems</c> and
        /// <c>AddressGroupServiceClient.RemoveAddressGroupItemsAsync</c>.
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
        public lro::OperationsSettings RemoveAddressGroupItemsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AddressGroupServiceClient.CloneAddressGroupItems</c> and
        /// <c>AddressGroupServiceClient.CloneAddressGroupItemsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CloneAddressGroupItemsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>AddressGroupServiceClient.CloneAddressGroupItems</c> and
        /// <c>AddressGroupServiceClient.CloneAddressGroupItemsAsync</c>.
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
        public lro::OperationsSettings CloneAddressGroupItemsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AddressGroupServiceClient.DeleteAddressGroup</c> and <c>AddressGroupServiceClient.DeleteAddressGroupAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAddressGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>AddressGroupServiceClient.DeleteAddressGroup</c> and
        /// <c>AddressGroupServiceClient.DeleteAddressGroupAsync</c>.
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
        public lro::OperationsSettings DeleteAddressGroupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AddressGroupServiceClient.ListAddressGroupReferences</c> and
        /// <c>AddressGroupServiceClient.ListAddressGroupReferencesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAddressGroupReferencesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AddressGroupServiceSettings"/> object.</returns>
        public AddressGroupServiceSettings Clone() => new AddressGroupServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AddressGroupServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class AddressGroupServiceClientBuilder : gaxgrpc::ClientBuilderBase<AddressGroupServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AddressGroupServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AddressGroupServiceClientBuilder() : base(AddressGroupServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AddressGroupServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AddressGroupServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AddressGroupServiceClient Build()
        {
            AddressGroupServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AddressGroupServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AddressGroupServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AddressGroupServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AddressGroupServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AddressGroupServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AddressGroupServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AddressGroupServiceClient.ChannelPool;
    }

    /// <summary>AddressGroupService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// AddressGroup is a resource that manages a collection of IP or Domain Names,
    /// it can be used in Firewall Policy to represent allow or deny traffic from
    /// all the IP or Domain Names from the Address Group.
    /// </remarks>
    public abstract partial class AddressGroupServiceClient
    {
        /// <summary>
        /// The default endpoint for the AddressGroupService service, which is a host of
        /// "networksecurity.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "networksecurity.googleapis.com:443";

        /// <summary>The default AddressGroupService scopes.</summary>
        /// <remarks>
        /// The default AddressGroupService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AddressGroupService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AddressGroupServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="AddressGroupServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AddressGroupServiceClient"/>.</returns>
        public static stt::Task<AddressGroupServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AddressGroupServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AddressGroupServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="AddressGroupServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AddressGroupServiceClient"/>.</returns>
        public static AddressGroupServiceClient Create() => new AddressGroupServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AddressGroupServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AddressGroupServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AddressGroupServiceClient"/>.</returns>
        internal static AddressGroupServiceClient Create(grpccore::CallInvoker callInvoker, AddressGroupServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AddressGroupService.AddressGroupServiceClient grpcClient = new AddressGroupService.AddressGroupServiceClient(callInvoker);
            return new AddressGroupServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AddressGroupService client</summary>
        public virtual AddressGroupService.AddressGroupServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists address groups in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AddressGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAddressGroupsResponse, AddressGroup> ListAddressGroups(ListAddressGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists address groups in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AddressGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAddressGroupsResponse, AddressGroup> ListAddressGroupsAsync(ListAddressGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists address groups in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the AddressGroups
        /// should be listed, specified in the format
        /// `projects/*/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="AddressGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAddressGroupsResponse, AddressGroup> ListAddressGroups(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAddressGroupsRequest request = new ListAddressGroupsRequest
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
            return ListAddressGroups(request, callSettings);
        }

        /// <summary>
        /// Lists address groups in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the AddressGroups
        /// should be listed, specified in the format
        /// `projects/*/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AddressGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAddressGroupsResponse, AddressGroup> ListAddressGroupsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAddressGroupsRequest request = new ListAddressGroupsRequest
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
            return ListAddressGroupsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists address groups in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the AddressGroups
        /// should be listed, specified in the format
        /// `projects/*/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="AddressGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAddressGroupsResponse, AddressGroup> ListAddressGroups(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAddressGroupsRequest request = new ListAddressGroupsRequest
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
            return ListAddressGroups(request, callSettings);
        }

        /// <summary>
        /// Lists address groups in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the AddressGroups
        /// should be listed, specified in the format
        /// `projects/*/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AddressGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAddressGroupsResponse, AddressGroup> ListAddressGroupsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAddressGroupsRequest request = new ListAddressGroupsRequest
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
            return ListAddressGroupsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single address group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AddressGroup GetAddressGroup(GetAddressGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single address group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddressGroup> GetAddressGroupAsync(GetAddressGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single address group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddressGroup> GetAddressGroupAsync(GetAddressGroupRequest request, st::CancellationToken cancellationToken) =>
            GetAddressGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single address group.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the AddressGroup to get. Must be in the format
        /// `projects/*/locations/{location}/addressGroups/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AddressGroup GetAddressGroup(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAddressGroup(new GetAddressGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single address group.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the AddressGroup to get. Must be in the format
        /// `projects/*/locations/{location}/addressGroups/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddressGroup> GetAddressGroupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAddressGroupAsync(new GetAddressGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single address group.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the AddressGroup to get. Must be in the format
        /// `projects/*/locations/{location}/addressGroups/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddressGroup> GetAddressGroupAsync(string name, st::CancellationToken cancellationToken) =>
            GetAddressGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single address group.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the AddressGroup to get. Must be in the format
        /// `projects/*/locations/{location}/addressGroups/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AddressGroup GetAddressGroup(AddressGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAddressGroup(new GetAddressGroupRequest
            {
                AddressGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single address group.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the AddressGroup to get. Must be in the format
        /// `projects/*/locations/{location}/addressGroups/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddressGroup> GetAddressGroupAsync(AddressGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAddressGroupAsync(new GetAddressGroupRequest
            {
                AddressGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single address group.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the AddressGroup to get. Must be in the format
        /// `projects/*/locations/{location}/addressGroups/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddressGroup> GetAddressGroupAsync(AddressGroupName name, st::CancellationToken cancellationToken) =>
            GetAddressGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new address group in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AddressGroup, OperationMetadata> CreateAddressGroup(CreateAddressGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new address group in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddressGroup, OperationMetadata>> CreateAddressGroupAsync(CreateAddressGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new address group in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddressGroup, OperationMetadata>> CreateAddressGroupAsync(CreateAddressGroupRequest request, st::CancellationToken cancellationToken) =>
            CreateAddressGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateAddressGroup</c>.</summary>
        public virtual lro::OperationsClient CreateAddressGroupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateAddressGroup</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AddressGroup, OperationMetadata> PollOnceCreateAddressGroup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AddressGroup, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAddressGroupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateAddressGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AddressGroup, OperationMetadata>> PollOnceCreateAddressGroupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AddressGroup, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAddressGroupOperationsClient, callSettings);

        /// <summary>
        /// Creates a new address group in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the AddressGroup. Must be in the
        /// format `projects/*/locations/{location}`.
        /// </param>
        /// <param name="addressGroup">
        /// Required. AddressGroup resource to be created.
        /// </param>
        /// <param name="addressGroupId">
        /// Required. Short name of the AddressGroup resource to be created.
        /// This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start
        /// with a number. E.g. "authz_policy".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AddressGroup, OperationMetadata> CreateAddressGroup(string parent, AddressGroup addressGroup, string addressGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAddressGroup(new CreateAddressGroupRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AddressGroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(addressGroupId, nameof(addressGroupId)),
                AddressGroup = gax::GaxPreconditions.CheckNotNull(addressGroup, nameof(addressGroup)),
            }, callSettings);

        /// <summary>
        /// Creates a new address group in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the AddressGroup. Must be in the
        /// format `projects/*/locations/{location}`.
        /// </param>
        /// <param name="addressGroup">
        /// Required. AddressGroup resource to be created.
        /// </param>
        /// <param name="addressGroupId">
        /// Required. Short name of the AddressGroup resource to be created.
        /// This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start
        /// with a number. E.g. "authz_policy".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddressGroup, OperationMetadata>> CreateAddressGroupAsync(string parent, AddressGroup addressGroup, string addressGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAddressGroupAsync(new CreateAddressGroupRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AddressGroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(addressGroupId, nameof(addressGroupId)),
                AddressGroup = gax::GaxPreconditions.CheckNotNull(addressGroup, nameof(addressGroup)),
            }, callSettings);

        /// <summary>
        /// Creates a new address group in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the AddressGroup. Must be in the
        /// format `projects/*/locations/{location}`.
        /// </param>
        /// <param name="addressGroup">
        /// Required. AddressGroup resource to be created.
        /// </param>
        /// <param name="addressGroupId">
        /// Required. Short name of the AddressGroup resource to be created.
        /// This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start
        /// with a number. E.g. "authz_policy".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddressGroup, OperationMetadata>> CreateAddressGroupAsync(string parent, AddressGroup addressGroup, string addressGroupId, st::CancellationToken cancellationToken) =>
            CreateAddressGroupAsync(parent, addressGroup, addressGroupId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new address group in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the AddressGroup. Must be in the
        /// format `projects/*/locations/{location}`.
        /// </param>
        /// <param name="addressGroup">
        /// Required. AddressGroup resource to be created.
        /// </param>
        /// <param name="addressGroupId">
        /// Required. Short name of the AddressGroup resource to be created.
        /// This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start
        /// with a number. E.g. "authz_policy".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AddressGroup, OperationMetadata> CreateAddressGroup(gagr::LocationName parent, AddressGroup addressGroup, string addressGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAddressGroup(new CreateAddressGroupRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AddressGroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(addressGroupId, nameof(addressGroupId)),
                AddressGroup = gax::GaxPreconditions.CheckNotNull(addressGroup, nameof(addressGroup)),
            }, callSettings);

        /// <summary>
        /// Creates a new address group in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the AddressGroup. Must be in the
        /// format `projects/*/locations/{location}`.
        /// </param>
        /// <param name="addressGroup">
        /// Required. AddressGroup resource to be created.
        /// </param>
        /// <param name="addressGroupId">
        /// Required. Short name of the AddressGroup resource to be created.
        /// This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start
        /// with a number. E.g. "authz_policy".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddressGroup, OperationMetadata>> CreateAddressGroupAsync(gagr::LocationName parent, AddressGroup addressGroup, string addressGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAddressGroupAsync(new CreateAddressGroupRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AddressGroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(addressGroupId, nameof(addressGroupId)),
                AddressGroup = gax::GaxPreconditions.CheckNotNull(addressGroup, nameof(addressGroup)),
            }, callSettings);

        /// <summary>
        /// Creates a new address group in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the AddressGroup. Must be in the
        /// format `projects/*/locations/{location}`.
        /// </param>
        /// <param name="addressGroup">
        /// Required. AddressGroup resource to be created.
        /// </param>
        /// <param name="addressGroupId">
        /// Required. Short name of the AddressGroup resource to be created.
        /// This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start
        /// with a number. E.g. "authz_policy".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddressGroup, OperationMetadata>> CreateAddressGroupAsync(gagr::LocationName parent, AddressGroup addressGroup, string addressGroupId, st::CancellationToken cancellationToken) =>
            CreateAddressGroupAsync(parent, addressGroup, addressGroupId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new address group in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the AddressGroup. Must be in the
        /// format `projects/*/locations/{location}`.
        /// </param>
        /// <param name="addressGroup">
        /// Required. AddressGroup resource to be created.
        /// </param>
        /// <param name="addressGroupId">
        /// Required. Short name of the AddressGroup resource to be created.
        /// This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start
        /// with a number. E.g. "authz_policy".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AddressGroup, OperationMetadata> CreateAddressGroup(OrganizationLocationName parent, AddressGroup addressGroup, string addressGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAddressGroup(new CreateAddressGroupRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AddressGroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(addressGroupId, nameof(addressGroupId)),
                AddressGroup = gax::GaxPreconditions.CheckNotNull(addressGroup, nameof(addressGroup)),
            }, callSettings);

        /// <summary>
        /// Creates a new address group in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the AddressGroup. Must be in the
        /// format `projects/*/locations/{location}`.
        /// </param>
        /// <param name="addressGroup">
        /// Required. AddressGroup resource to be created.
        /// </param>
        /// <param name="addressGroupId">
        /// Required. Short name of the AddressGroup resource to be created.
        /// This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start
        /// with a number. E.g. "authz_policy".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddressGroup, OperationMetadata>> CreateAddressGroupAsync(OrganizationLocationName parent, AddressGroup addressGroup, string addressGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAddressGroupAsync(new CreateAddressGroupRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AddressGroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(addressGroupId, nameof(addressGroupId)),
                AddressGroup = gax::GaxPreconditions.CheckNotNull(addressGroup, nameof(addressGroup)),
            }, callSettings);

        /// <summary>
        /// Creates a new address group in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the AddressGroup. Must be in the
        /// format `projects/*/locations/{location}`.
        /// </param>
        /// <param name="addressGroup">
        /// Required. AddressGroup resource to be created.
        /// </param>
        /// <param name="addressGroupId">
        /// Required. Short name of the AddressGroup resource to be created.
        /// This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start
        /// with a number. E.g. "authz_policy".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddressGroup, OperationMetadata>> CreateAddressGroupAsync(OrganizationLocationName parent, AddressGroup addressGroup, string addressGroupId, st::CancellationToken cancellationToken) =>
            CreateAddressGroupAsync(parent, addressGroup, addressGroupId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single address group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AddressGroup, OperationMetadata> UpdateAddressGroup(UpdateAddressGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single address group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddressGroup, OperationMetadata>> UpdateAddressGroupAsync(UpdateAddressGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single address group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddressGroup, OperationMetadata>> UpdateAddressGroupAsync(UpdateAddressGroupRequest request, st::CancellationToken cancellationToken) =>
            UpdateAddressGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateAddressGroup</c>.</summary>
        public virtual lro::OperationsClient UpdateAddressGroupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateAddressGroup</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AddressGroup, OperationMetadata> PollOnceUpdateAddressGroup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AddressGroup, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAddressGroupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateAddressGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AddressGroup, OperationMetadata>> PollOnceUpdateAddressGroupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AddressGroup, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAddressGroupOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single address group.
        /// </summary>
        /// <param name="addressGroup">
        /// Required. Updated AddressGroup resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// AddressGroup resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AddressGroup, OperationMetadata> UpdateAddressGroup(AddressGroup addressGroup, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAddressGroup(new UpdateAddressGroupRequest
            {
                UpdateMask = updateMask,
                AddressGroup = gax::GaxPreconditions.CheckNotNull(addressGroup, nameof(addressGroup)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single address group.
        /// </summary>
        /// <param name="addressGroup">
        /// Required. Updated AddressGroup resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// AddressGroup resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddressGroup, OperationMetadata>> UpdateAddressGroupAsync(AddressGroup addressGroup, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAddressGroupAsync(new UpdateAddressGroupRequest
            {
                UpdateMask = updateMask,
                AddressGroup = gax::GaxPreconditions.CheckNotNull(addressGroup, nameof(addressGroup)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single address group.
        /// </summary>
        /// <param name="addressGroup">
        /// Required. Updated AddressGroup resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// AddressGroup resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddressGroup, OperationMetadata>> UpdateAddressGroupAsync(AddressGroup addressGroup, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAddressGroupAsync(addressGroup, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds items to an address group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AddressGroup, OperationMetadata> AddAddressGroupItems(AddAddressGroupItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds items to an address group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddressGroup, OperationMetadata>> AddAddressGroupItemsAsync(AddAddressGroupItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds items to an address group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddressGroup, OperationMetadata>> AddAddressGroupItemsAsync(AddAddressGroupItemsRequest request, st::CancellationToken cancellationToken) =>
            AddAddressGroupItemsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>AddAddressGroupItems</c>.</summary>
        public virtual lro::OperationsClient AddAddressGroupItemsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>AddAddressGroupItems</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AddressGroup, OperationMetadata> PollOnceAddAddressGroupItems(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AddressGroup, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AddAddressGroupItemsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>AddAddressGroupItems</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AddressGroup, OperationMetadata>> PollOnceAddAddressGroupItemsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AddressGroup, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AddAddressGroupItemsOperationsClient, callSettings);

        /// <summary>
        /// Adds items to an address group.
        /// </summary>
        /// <param name="addressGroup">
        /// Required. A name of the AddressGroup to add items to. Must be in the format
        /// `projects|organization/*/locations/{location}/addressGroups/*`.
        /// </param>
        /// <param name="items">
        /// Required. List of items to add.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AddressGroup, OperationMetadata> AddAddressGroupItems(string addressGroup, scg::IEnumerable<string> items, gaxgrpc::CallSettings callSettings = null) =>
            AddAddressGroupItems(new AddAddressGroupItemsRequest
            {
                AddressGroup = gax::GaxPreconditions.CheckNotNullOrEmpty(addressGroup, nameof(addressGroup)),
                Items =
                {
                    gax::GaxPreconditions.CheckNotNull(items, nameof(items)),
                },
            }, callSettings);

        /// <summary>
        /// Adds items to an address group.
        /// </summary>
        /// <param name="addressGroup">
        /// Required. A name of the AddressGroup to add items to. Must be in the format
        /// `projects|organization/*/locations/{location}/addressGroups/*`.
        /// </param>
        /// <param name="items">
        /// Required. List of items to add.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddressGroup, OperationMetadata>> AddAddressGroupItemsAsync(string addressGroup, scg::IEnumerable<string> items, gaxgrpc::CallSettings callSettings = null) =>
            AddAddressGroupItemsAsync(new AddAddressGroupItemsRequest
            {
                AddressGroup = gax::GaxPreconditions.CheckNotNullOrEmpty(addressGroup, nameof(addressGroup)),
                Items =
                {
                    gax::GaxPreconditions.CheckNotNull(items, nameof(items)),
                },
            }, callSettings);

        /// <summary>
        /// Adds items to an address group.
        /// </summary>
        /// <param name="addressGroup">
        /// Required. A name of the AddressGroup to add items to. Must be in the format
        /// `projects|organization/*/locations/{location}/addressGroups/*`.
        /// </param>
        /// <param name="items">
        /// Required. List of items to add.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddressGroup, OperationMetadata>> AddAddressGroupItemsAsync(string addressGroup, scg::IEnumerable<string> items, st::CancellationToken cancellationToken) =>
            AddAddressGroupItemsAsync(addressGroup, items, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds items to an address group.
        /// </summary>
        /// <param name="addressGroup">
        /// Required. A name of the AddressGroup to add items to. Must be in the format
        /// `projects|organization/*/locations/{location}/addressGroups/*`.
        /// </param>
        /// <param name="items">
        /// Required. List of items to add.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AddressGroup, OperationMetadata> AddAddressGroupItems(AddressGroupName addressGroup, scg::IEnumerable<string> items, gaxgrpc::CallSettings callSettings = null) =>
            AddAddressGroupItems(new AddAddressGroupItemsRequest
            {
                AddressGroupAsAddressGroupName = gax::GaxPreconditions.CheckNotNull(addressGroup, nameof(addressGroup)),
                Items =
                {
                    gax::GaxPreconditions.CheckNotNull(items, nameof(items)),
                },
            }, callSettings);

        /// <summary>
        /// Adds items to an address group.
        /// </summary>
        /// <param name="addressGroup">
        /// Required. A name of the AddressGroup to add items to. Must be in the format
        /// `projects|organization/*/locations/{location}/addressGroups/*`.
        /// </param>
        /// <param name="items">
        /// Required. List of items to add.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddressGroup, OperationMetadata>> AddAddressGroupItemsAsync(AddressGroupName addressGroup, scg::IEnumerable<string> items, gaxgrpc::CallSettings callSettings = null) =>
            AddAddressGroupItemsAsync(new AddAddressGroupItemsRequest
            {
                AddressGroupAsAddressGroupName = gax::GaxPreconditions.CheckNotNull(addressGroup, nameof(addressGroup)),
                Items =
                {
                    gax::GaxPreconditions.CheckNotNull(items, nameof(items)),
                },
            }, callSettings);

        /// <summary>
        /// Adds items to an address group.
        /// </summary>
        /// <param name="addressGroup">
        /// Required. A name of the AddressGroup to add items to. Must be in the format
        /// `projects|organization/*/locations/{location}/addressGroups/*`.
        /// </param>
        /// <param name="items">
        /// Required. List of items to add.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddressGroup, OperationMetadata>> AddAddressGroupItemsAsync(AddressGroupName addressGroup, scg::IEnumerable<string> items, st::CancellationToken cancellationToken) =>
            AddAddressGroupItemsAsync(addressGroup, items, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes items from an address group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AddressGroup, OperationMetadata> RemoveAddressGroupItems(RemoveAddressGroupItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes items from an address group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddressGroup, OperationMetadata>> RemoveAddressGroupItemsAsync(RemoveAddressGroupItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes items from an address group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddressGroup, OperationMetadata>> RemoveAddressGroupItemsAsync(RemoveAddressGroupItemsRequest request, st::CancellationToken cancellationToken) =>
            RemoveAddressGroupItemsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RemoveAddressGroupItems</c>.</summary>
        public virtual lro::OperationsClient RemoveAddressGroupItemsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RemoveAddressGroupItems</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AddressGroup, OperationMetadata> PollOnceRemoveAddressGroupItems(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AddressGroup, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RemoveAddressGroupItemsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RemoveAddressGroupItems</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AddressGroup, OperationMetadata>> PollOnceRemoveAddressGroupItemsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AddressGroup, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RemoveAddressGroupItemsOperationsClient, callSettings);

        /// <summary>
        /// Removes items from an address group.
        /// </summary>
        /// <param name="addressGroup">
        /// Required. A name of the AddressGroup to remove items from. Must be in the
        /// format `projects|organization/*/locations/{location}/addressGroups/*`.
        /// </param>
        /// <param name="items">
        /// Required. List of items to remove.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AddressGroup, OperationMetadata> RemoveAddressGroupItems(string addressGroup, scg::IEnumerable<string> items, gaxgrpc::CallSettings callSettings = null) =>
            RemoveAddressGroupItems(new RemoveAddressGroupItemsRequest
            {
                AddressGroup = gax::GaxPreconditions.CheckNotNullOrEmpty(addressGroup, nameof(addressGroup)),
                Items =
                {
                    gax::GaxPreconditions.CheckNotNull(items, nameof(items)),
                },
            }, callSettings);

        /// <summary>
        /// Removes items from an address group.
        /// </summary>
        /// <param name="addressGroup">
        /// Required. A name of the AddressGroup to remove items from. Must be in the
        /// format `projects|organization/*/locations/{location}/addressGroups/*`.
        /// </param>
        /// <param name="items">
        /// Required. List of items to remove.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddressGroup, OperationMetadata>> RemoveAddressGroupItemsAsync(string addressGroup, scg::IEnumerable<string> items, gaxgrpc::CallSettings callSettings = null) =>
            RemoveAddressGroupItemsAsync(new RemoveAddressGroupItemsRequest
            {
                AddressGroup = gax::GaxPreconditions.CheckNotNullOrEmpty(addressGroup, nameof(addressGroup)),
                Items =
                {
                    gax::GaxPreconditions.CheckNotNull(items, nameof(items)),
                },
            }, callSettings);

        /// <summary>
        /// Removes items from an address group.
        /// </summary>
        /// <param name="addressGroup">
        /// Required. A name of the AddressGroup to remove items from. Must be in the
        /// format `projects|organization/*/locations/{location}/addressGroups/*`.
        /// </param>
        /// <param name="items">
        /// Required. List of items to remove.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddressGroup, OperationMetadata>> RemoveAddressGroupItemsAsync(string addressGroup, scg::IEnumerable<string> items, st::CancellationToken cancellationToken) =>
            RemoveAddressGroupItemsAsync(addressGroup, items, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes items from an address group.
        /// </summary>
        /// <param name="addressGroup">
        /// Required. A name of the AddressGroup to remove items from. Must be in the
        /// format `projects|organization/*/locations/{location}/addressGroups/*`.
        /// </param>
        /// <param name="items">
        /// Required. List of items to remove.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AddressGroup, OperationMetadata> RemoveAddressGroupItems(AddressGroupName addressGroup, scg::IEnumerable<string> items, gaxgrpc::CallSettings callSettings = null) =>
            RemoveAddressGroupItems(new RemoveAddressGroupItemsRequest
            {
                AddressGroupAsAddressGroupName = gax::GaxPreconditions.CheckNotNull(addressGroup, nameof(addressGroup)),
                Items =
                {
                    gax::GaxPreconditions.CheckNotNull(items, nameof(items)),
                },
            }, callSettings);

        /// <summary>
        /// Removes items from an address group.
        /// </summary>
        /// <param name="addressGroup">
        /// Required. A name of the AddressGroup to remove items from. Must be in the
        /// format `projects|organization/*/locations/{location}/addressGroups/*`.
        /// </param>
        /// <param name="items">
        /// Required. List of items to remove.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddressGroup, OperationMetadata>> RemoveAddressGroupItemsAsync(AddressGroupName addressGroup, scg::IEnumerable<string> items, gaxgrpc::CallSettings callSettings = null) =>
            RemoveAddressGroupItemsAsync(new RemoveAddressGroupItemsRequest
            {
                AddressGroupAsAddressGroupName = gax::GaxPreconditions.CheckNotNull(addressGroup, nameof(addressGroup)),
                Items =
                {
                    gax::GaxPreconditions.CheckNotNull(items, nameof(items)),
                },
            }, callSettings);

        /// <summary>
        /// Removes items from an address group.
        /// </summary>
        /// <param name="addressGroup">
        /// Required. A name of the AddressGroup to remove items from. Must be in the
        /// format `projects|organization/*/locations/{location}/addressGroups/*`.
        /// </param>
        /// <param name="items">
        /// Required. List of items to remove.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddressGroup, OperationMetadata>> RemoveAddressGroupItemsAsync(AddressGroupName addressGroup, scg::IEnumerable<string> items, st::CancellationToken cancellationToken) =>
            RemoveAddressGroupItemsAsync(addressGroup, items, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Clones items from one address group to another.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AddressGroup, OperationMetadata> CloneAddressGroupItems(CloneAddressGroupItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Clones items from one address group to another.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddressGroup, OperationMetadata>> CloneAddressGroupItemsAsync(CloneAddressGroupItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Clones items from one address group to another.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddressGroup, OperationMetadata>> CloneAddressGroupItemsAsync(CloneAddressGroupItemsRequest request, st::CancellationToken cancellationToken) =>
            CloneAddressGroupItemsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CloneAddressGroupItems</c>.</summary>
        public virtual lro::OperationsClient CloneAddressGroupItemsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CloneAddressGroupItems</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AddressGroup, OperationMetadata> PollOnceCloneAddressGroupItems(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AddressGroup, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CloneAddressGroupItemsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CloneAddressGroupItems</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AddressGroup, OperationMetadata>> PollOnceCloneAddressGroupItemsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AddressGroup, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CloneAddressGroupItemsOperationsClient, callSettings);

        /// <summary>
        /// Clones items from one address group to another.
        /// </summary>
        /// <param name="addressGroup">
        /// Required. A name of the AddressGroup to clone items to. Must be in the
        /// format `projects|organization/*/locations/{location}/addressGroups/*`.
        /// </param>
        /// <param name="sourceAddressGroup">
        /// Required. Source address group to clone items from.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AddressGroup, OperationMetadata> CloneAddressGroupItems(string addressGroup, string sourceAddressGroup, gaxgrpc::CallSettings callSettings = null) =>
            CloneAddressGroupItems(new CloneAddressGroupItemsRequest
            {
                AddressGroup = gax::GaxPreconditions.CheckNotNullOrEmpty(addressGroup, nameof(addressGroup)),
                SourceAddressGroup = gax::GaxPreconditions.CheckNotNullOrEmpty(sourceAddressGroup, nameof(sourceAddressGroup)),
            }, callSettings);

        /// <summary>
        /// Clones items from one address group to another.
        /// </summary>
        /// <param name="addressGroup">
        /// Required. A name of the AddressGroup to clone items to. Must be in the
        /// format `projects|organization/*/locations/{location}/addressGroups/*`.
        /// </param>
        /// <param name="sourceAddressGroup">
        /// Required. Source address group to clone items from.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddressGroup, OperationMetadata>> CloneAddressGroupItemsAsync(string addressGroup, string sourceAddressGroup, gaxgrpc::CallSettings callSettings = null) =>
            CloneAddressGroupItemsAsync(new CloneAddressGroupItemsRequest
            {
                AddressGroup = gax::GaxPreconditions.CheckNotNullOrEmpty(addressGroup, nameof(addressGroup)),
                SourceAddressGroup = gax::GaxPreconditions.CheckNotNullOrEmpty(sourceAddressGroup, nameof(sourceAddressGroup)),
            }, callSettings);

        /// <summary>
        /// Clones items from one address group to another.
        /// </summary>
        /// <param name="addressGroup">
        /// Required. A name of the AddressGroup to clone items to. Must be in the
        /// format `projects|organization/*/locations/{location}/addressGroups/*`.
        /// </param>
        /// <param name="sourceAddressGroup">
        /// Required. Source address group to clone items from.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddressGroup, OperationMetadata>> CloneAddressGroupItemsAsync(string addressGroup, string sourceAddressGroup, st::CancellationToken cancellationToken) =>
            CloneAddressGroupItemsAsync(addressGroup, sourceAddressGroup, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Clones items from one address group to another.
        /// </summary>
        /// <param name="addressGroup">
        /// Required. A name of the AddressGroup to clone items to. Must be in the
        /// format `projects|organization/*/locations/{location}/addressGroups/*`.
        /// </param>
        /// <param name="sourceAddressGroup">
        /// Required. Source address group to clone items from.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AddressGroup, OperationMetadata> CloneAddressGroupItems(AddressGroupName addressGroup, AddressGroupName sourceAddressGroup, gaxgrpc::CallSettings callSettings = null) =>
            CloneAddressGroupItems(new CloneAddressGroupItemsRequest
            {
                AddressGroupAsAddressGroupName = gax::GaxPreconditions.CheckNotNull(addressGroup, nameof(addressGroup)),
                SourceAddressGroupAsAddressGroupName = gax::GaxPreconditions.CheckNotNull(sourceAddressGroup, nameof(sourceAddressGroup)),
            }, callSettings);

        /// <summary>
        /// Clones items from one address group to another.
        /// </summary>
        /// <param name="addressGroup">
        /// Required. A name of the AddressGroup to clone items to. Must be in the
        /// format `projects|organization/*/locations/{location}/addressGroups/*`.
        /// </param>
        /// <param name="sourceAddressGroup">
        /// Required. Source address group to clone items from.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddressGroup, OperationMetadata>> CloneAddressGroupItemsAsync(AddressGroupName addressGroup, AddressGroupName sourceAddressGroup, gaxgrpc::CallSettings callSettings = null) =>
            CloneAddressGroupItemsAsync(new CloneAddressGroupItemsRequest
            {
                AddressGroupAsAddressGroupName = gax::GaxPreconditions.CheckNotNull(addressGroup, nameof(addressGroup)),
                SourceAddressGroupAsAddressGroupName = gax::GaxPreconditions.CheckNotNull(sourceAddressGroup, nameof(sourceAddressGroup)),
            }, callSettings);

        /// <summary>
        /// Clones items from one address group to another.
        /// </summary>
        /// <param name="addressGroup">
        /// Required. A name of the AddressGroup to clone items to. Must be in the
        /// format `projects|organization/*/locations/{location}/addressGroups/*`.
        /// </param>
        /// <param name="sourceAddressGroup">
        /// Required. Source address group to clone items from.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AddressGroup, OperationMetadata>> CloneAddressGroupItemsAsync(AddressGroupName addressGroup, AddressGroupName sourceAddressGroup, st::CancellationToken cancellationToken) =>
            CloneAddressGroupItemsAsync(addressGroup, sourceAddressGroup, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single address group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAddressGroup(DeleteAddressGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single address group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAddressGroupAsync(DeleteAddressGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single address group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAddressGroupAsync(DeleteAddressGroupRequest request, st::CancellationToken cancellationToken) =>
            DeleteAddressGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteAddressGroup</c>.</summary>
        public virtual lro::OperationsClient DeleteAddressGroupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteAddressGroup</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteAddressGroup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAddressGroupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteAddressGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteAddressGroupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAddressGroupOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single address group.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the AddressGroup to delete. Must be in the format
        /// `projects/*/locations/{location}/addressGroups/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAddressGroup(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAddressGroup(new DeleteAddressGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single address group.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the AddressGroup to delete. Must be in the format
        /// `projects/*/locations/{location}/addressGroups/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAddressGroupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAddressGroupAsync(new DeleteAddressGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single address group.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the AddressGroup to delete. Must be in the format
        /// `projects/*/locations/{location}/addressGroups/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAddressGroupAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAddressGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single address group.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the AddressGroup to delete. Must be in the format
        /// `projects/*/locations/{location}/addressGroups/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAddressGroup(AddressGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAddressGroup(new DeleteAddressGroupRequest
            {
                AddressGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single address group.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the AddressGroup to delete. Must be in the format
        /// `projects/*/locations/{location}/addressGroups/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAddressGroupAsync(AddressGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAddressGroupAsync(new DeleteAddressGroupRequest
            {
                AddressGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single address group.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the AddressGroup to delete. Must be in the format
        /// `projects/*/locations/{location}/addressGroups/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAddressGroupAsync(AddressGroupName name, st::CancellationToken cancellationToken) =>
            DeleteAddressGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists references of an address group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable sequence of <see cref="ListAddressGroupReferencesResponse.Types.AddressGroupReference"/>
        /// resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListAddressGroupReferencesResponse, ListAddressGroupReferencesResponse.Types.AddressGroupReference> ListAddressGroupReferences(ListAddressGroupReferencesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists references of an address group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of
        /// <see cref="ListAddressGroupReferencesResponse.Types.AddressGroupReference"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListAddressGroupReferencesResponse, ListAddressGroupReferencesResponse.Types.AddressGroupReference> ListAddressGroupReferencesAsync(ListAddressGroupReferencesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists references of an address group.
        /// </summary>
        /// <param name="addressGroup">
        /// Required. A name of the AddressGroup to clone items to. Must be in the
        /// format `projects|organization/*/locations/{location}/addressGroups/*`.
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
        /// A pageable sequence of <see cref="ListAddressGroupReferencesResponse.Types.AddressGroupReference"/>
        /// resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListAddressGroupReferencesResponse, ListAddressGroupReferencesResponse.Types.AddressGroupReference> ListAddressGroupReferences(string addressGroup, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAddressGroupReferencesRequest request = new ListAddressGroupReferencesRequest
            {
                AddressGroup = gax::GaxPreconditions.CheckNotNullOrEmpty(addressGroup, nameof(addressGroup)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAddressGroupReferences(request, callSettings);
        }

        /// <summary>
        /// Lists references of an address group.
        /// </summary>
        /// <param name="addressGroup">
        /// Required. A name of the AddressGroup to clone items to. Must be in the
        /// format `projects|organization/*/locations/{location}/addressGroups/*`.
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
        /// A pageable asynchronous sequence of
        /// <see cref="ListAddressGroupReferencesResponse.Types.AddressGroupReference"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListAddressGroupReferencesResponse, ListAddressGroupReferencesResponse.Types.AddressGroupReference> ListAddressGroupReferencesAsync(string addressGroup, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAddressGroupReferencesRequest request = new ListAddressGroupReferencesRequest
            {
                AddressGroup = gax::GaxPreconditions.CheckNotNullOrEmpty(addressGroup, nameof(addressGroup)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAddressGroupReferencesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists references of an address group.
        /// </summary>
        /// <param name="addressGroup">
        /// Required. A name of the AddressGroup to clone items to. Must be in the
        /// format `projects|organization/*/locations/{location}/addressGroups/*`.
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
        /// A pageable sequence of <see cref="ListAddressGroupReferencesResponse.Types.AddressGroupReference"/>
        /// resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListAddressGroupReferencesResponse, ListAddressGroupReferencesResponse.Types.AddressGroupReference> ListAddressGroupReferences(AddressGroupName addressGroup, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAddressGroupReferencesRequest request = new ListAddressGroupReferencesRequest
            {
                AddressGroupAsAddressGroupName = gax::GaxPreconditions.CheckNotNull(addressGroup, nameof(addressGroup)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAddressGroupReferences(request, callSettings);
        }

        /// <summary>
        /// Lists references of an address group.
        /// </summary>
        /// <param name="addressGroup">
        /// Required. A name of the AddressGroup to clone items to. Must be in the
        /// format `projects|organization/*/locations/{location}/addressGroups/*`.
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
        /// A pageable asynchronous sequence of
        /// <see cref="ListAddressGroupReferencesResponse.Types.AddressGroupReference"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListAddressGroupReferencesResponse, ListAddressGroupReferencesResponse.Types.AddressGroupReference> ListAddressGroupReferencesAsync(AddressGroupName addressGroup, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAddressGroupReferencesRequest request = new ListAddressGroupReferencesRequest
            {
                AddressGroupAsAddressGroupName = gax::GaxPreconditions.CheckNotNull(addressGroup, nameof(addressGroup)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAddressGroupReferencesAsync(request, callSettings);
        }
    }

    /// <summary>AddressGroupService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// AddressGroup is a resource that manages a collection of IP or Domain Names,
    /// it can be used in Firewall Policy to represent allow or deny traffic from
    /// all the IP or Domain Names from the Address Group.
    /// </remarks>
    public sealed partial class AddressGroupServiceClientImpl : AddressGroupServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListAddressGroupsRequest, ListAddressGroupsResponse> _callListAddressGroups;

        private readonly gaxgrpc::ApiCall<GetAddressGroupRequest, AddressGroup> _callGetAddressGroup;

        private readonly gaxgrpc::ApiCall<CreateAddressGroupRequest, lro::Operation> _callCreateAddressGroup;

        private readonly gaxgrpc::ApiCall<UpdateAddressGroupRequest, lro::Operation> _callUpdateAddressGroup;

        private readonly gaxgrpc::ApiCall<AddAddressGroupItemsRequest, lro::Operation> _callAddAddressGroupItems;

        private readonly gaxgrpc::ApiCall<RemoveAddressGroupItemsRequest, lro::Operation> _callRemoveAddressGroupItems;

        private readonly gaxgrpc::ApiCall<CloneAddressGroupItemsRequest, lro::Operation> _callCloneAddressGroupItems;

        private readonly gaxgrpc::ApiCall<DeleteAddressGroupRequest, lro::Operation> _callDeleteAddressGroup;

        private readonly gaxgrpc::ApiCall<ListAddressGroupReferencesRequest, ListAddressGroupReferencesResponse> _callListAddressGroupReferences;

        /// <summary>
        /// Constructs a client wrapper for the AddressGroupService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AddressGroupServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AddressGroupServiceClientImpl(AddressGroupService.AddressGroupServiceClient grpcClient, AddressGroupServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AddressGroupServiceSettings effectiveSettings = settings ?? AddressGroupServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateAddressGroupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateAddressGroupOperationsSettings, logger);
            UpdateAddressGroupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateAddressGroupOperationsSettings, logger);
            AddAddressGroupItemsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.AddAddressGroupItemsOperationsSettings, logger);
            RemoveAddressGroupItemsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RemoveAddressGroupItemsOperationsSettings, logger);
            CloneAddressGroupItemsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CloneAddressGroupItemsOperationsSettings, logger);
            DeleteAddressGroupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteAddressGroupOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListAddressGroups = clientHelper.BuildApiCall<ListAddressGroupsRequest, ListAddressGroupsResponse>("ListAddressGroups", grpcClient.ListAddressGroupsAsync, grpcClient.ListAddressGroups, effectiveSettings.ListAddressGroupsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAddressGroups);
            Modify_ListAddressGroupsApiCall(ref _callListAddressGroups);
            _callGetAddressGroup = clientHelper.BuildApiCall<GetAddressGroupRequest, AddressGroup>("GetAddressGroup", grpcClient.GetAddressGroupAsync, grpcClient.GetAddressGroup, effectiveSettings.GetAddressGroupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAddressGroup);
            Modify_GetAddressGroupApiCall(ref _callGetAddressGroup);
            _callCreateAddressGroup = clientHelper.BuildApiCall<CreateAddressGroupRequest, lro::Operation>("CreateAddressGroup", grpcClient.CreateAddressGroupAsync, grpcClient.CreateAddressGroup, effectiveSettings.CreateAddressGroupSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAddressGroup);
            Modify_CreateAddressGroupApiCall(ref _callCreateAddressGroup);
            _callUpdateAddressGroup = clientHelper.BuildApiCall<UpdateAddressGroupRequest, lro::Operation>("UpdateAddressGroup", grpcClient.UpdateAddressGroupAsync, grpcClient.UpdateAddressGroup, effectiveSettings.UpdateAddressGroupSettings).WithGoogleRequestParam("address_group.name", request => request.AddressGroup?.Name);
            Modify_ApiCall(ref _callUpdateAddressGroup);
            Modify_UpdateAddressGroupApiCall(ref _callUpdateAddressGroup);
            _callAddAddressGroupItems = clientHelper.BuildApiCall<AddAddressGroupItemsRequest, lro::Operation>("AddAddressGroupItems", grpcClient.AddAddressGroupItemsAsync, grpcClient.AddAddressGroupItems, effectiveSettings.AddAddressGroupItemsSettings).WithGoogleRequestParam("address_group", request => request.AddressGroup);
            Modify_ApiCall(ref _callAddAddressGroupItems);
            Modify_AddAddressGroupItemsApiCall(ref _callAddAddressGroupItems);
            _callRemoveAddressGroupItems = clientHelper.BuildApiCall<RemoveAddressGroupItemsRequest, lro::Operation>("RemoveAddressGroupItems", grpcClient.RemoveAddressGroupItemsAsync, grpcClient.RemoveAddressGroupItems, effectiveSettings.RemoveAddressGroupItemsSettings).WithGoogleRequestParam("address_group", request => request.AddressGroup);
            Modify_ApiCall(ref _callRemoveAddressGroupItems);
            Modify_RemoveAddressGroupItemsApiCall(ref _callRemoveAddressGroupItems);
            _callCloneAddressGroupItems = clientHelper.BuildApiCall<CloneAddressGroupItemsRequest, lro::Operation>("CloneAddressGroupItems", grpcClient.CloneAddressGroupItemsAsync, grpcClient.CloneAddressGroupItems, effectiveSettings.CloneAddressGroupItemsSettings).WithGoogleRequestParam("address_group", request => request.AddressGroup);
            Modify_ApiCall(ref _callCloneAddressGroupItems);
            Modify_CloneAddressGroupItemsApiCall(ref _callCloneAddressGroupItems);
            _callDeleteAddressGroup = clientHelper.BuildApiCall<DeleteAddressGroupRequest, lro::Operation>("DeleteAddressGroup", grpcClient.DeleteAddressGroupAsync, grpcClient.DeleteAddressGroup, effectiveSettings.DeleteAddressGroupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAddressGroup);
            Modify_DeleteAddressGroupApiCall(ref _callDeleteAddressGroup);
            _callListAddressGroupReferences = clientHelper.BuildApiCall<ListAddressGroupReferencesRequest, ListAddressGroupReferencesResponse>("ListAddressGroupReferences", grpcClient.ListAddressGroupReferencesAsync, grpcClient.ListAddressGroupReferences, effectiveSettings.ListAddressGroupReferencesSettings).WithGoogleRequestParam("address_group", request => request.AddressGroup);
            Modify_ApiCall(ref _callListAddressGroupReferences);
            Modify_ListAddressGroupReferencesApiCall(ref _callListAddressGroupReferences);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListAddressGroupsApiCall(ref gaxgrpc::ApiCall<ListAddressGroupsRequest, ListAddressGroupsResponse> call);

        partial void Modify_GetAddressGroupApiCall(ref gaxgrpc::ApiCall<GetAddressGroupRequest, AddressGroup> call);

        partial void Modify_CreateAddressGroupApiCall(ref gaxgrpc::ApiCall<CreateAddressGroupRequest, lro::Operation> call);

        partial void Modify_UpdateAddressGroupApiCall(ref gaxgrpc::ApiCall<UpdateAddressGroupRequest, lro::Operation> call);

        partial void Modify_AddAddressGroupItemsApiCall(ref gaxgrpc::ApiCall<AddAddressGroupItemsRequest, lro::Operation> call);

        partial void Modify_RemoveAddressGroupItemsApiCall(ref gaxgrpc::ApiCall<RemoveAddressGroupItemsRequest, lro::Operation> call);

        partial void Modify_CloneAddressGroupItemsApiCall(ref gaxgrpc::ApiCall<CloneAddressGroupItemsRequest, lro::Operation> call);

        partial void Modify_DeleteAddressGroupApiCall(ref gaxgrpc::ApiCall<DeleteAddressGroupRequest, lro::Operation> call);

        partial void Modify_ListAddressGroupReferencesApiCall(ref gaxgrpc::ApiCall<ListAddressGroupReferencesRequest, ListAddressGroupReferencesResponse> call);

        partial void OnConstruction(AddressGroupService.AddressGroupServiceClient grpcClient, AddressGroupServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AddressGroupService client</summary>
        public override AddressGroupService.AddressGroupServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListAddressGroupsRequest(ref ListAddressGroupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAddressGroupRequest(ref GetAddressGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAddressGroupRequest(ref CreateAddressGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAddressGroupRequest(ref UpdateAddressGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AddAddressGroupItemsRequest(ref AddAddressGroupItemsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RemoveAddressGroupItemsRequest(ref RemoveAddressGroupItemsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CloneAddressGroupItemsRequest(ref CloneAddressGroupItemsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAddressGroupRequest(ref DeleteAddressGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAddressGroupReferencesRequest(ref ListAddressGroupReferencesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists address groups in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AddressGroup"/> resources.</returns>
        public override gax::PagedEnumerable<ListAddressGroupsResponse, AddressGroup> ListAddressGroups(ListAddressGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAddressGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAddressGroupsRequest, ListAddressGroupsResponse, AddressGroup>(_callListAddressGroups, request, callSettings);
        }

        /// <summary>
        /// Lists address groups in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AddressGroup"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAddressGroupsResponse, AddressGroup> ListAddressGroupsAsync(ListAddressGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAddressGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAddressGroupsRequest, ListAddressGroupsResponse, AddressGroup>(_callListAddressGroups, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single address group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AddressGroup GetAddressGroup(GetAddressGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAddressGroupRequest(ref request, ref callSettings);
            return _callGetAddressGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single address group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AddressGroup> GetAddressGroupAsync(GetAddressGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAddressGroupRequest(ref request, ref callSettings);
            return _callGetAddressGroup.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateAddressGroup</c>.</summary>
        public override lro::OperationsClient CreateAddressGroupOperationsClient { get; }

        /// <summary>
        /// Creates a new address group in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AddressGroup, OperationMetadata> CreateAddressGroup(CreateAddressGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAddressGroupRequest(ref request, ref callSettings);
            return new lro::Operation<AddressGroup, OperationMetadata>(_callCreateAddressGroup.Sync(request, callSettings), CreateAddressGroupOperationsClient);
        }

        /// <summary>
        /// Creates a new address group in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AddressGroup, OperationMetadata>> CreateAddressGroupAsync(CreateAddressGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAddressGroupRequest(ref request, ref callSettings);
            return new lro::Operation<AddressGroup, OperationMetadata>(await _callCreateAddressGroup.Async(request, callSettings).ConfigureAwait(false), CreateAddressGroupOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateAddressGroup</c>.</summary>
        public override lro::OperationsClient UpdateAddressGroupOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single address group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AddressGroup, OperationMetadata> UpdateAddressGroup(UpdateAddressGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAddressGroupRequest(ref request, ref callSettings);
            return new lro::Operation<AddressGroup, OperationMetadata>(_callUpdateAddressGroup.Sync(request, callSettings), UpdateAddressGroupOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single address group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AddressGroup, OperationMetadata>> UpdateAddressGroupAsync(UpdateAddressGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAddressGroupRequest(ref request, ref callSettings);
            return new lro::Operation<AddressGroup, OperationMetadata>(await _callUpdateAddressGroup.Async(request, callSettings).ConfigureAwait(false), UpdateAddressGroupOperationsClient);
        }

        /// <summary>The long-running operations client for <c>AddAddressGroupItems</c>.</summary>
        public override lro::OperationsClient AddAddressGroupItemsOperationsClient { get; }

        /// <summary>
        /// Adds items to an address group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AddressGroup, OperationMetadata> AddAddressGroupItems(AddAddressGroupItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddAddressGroupItemsRequest(ref request, ref callSettings);
            return new lro::Operation<AddressGroup, OperationMetadata>(_callAddAddressGroupItems.Sync(request, callSettings), AddAddressGroupItemsOperationsClient);
        }

        /// <summary>
        /// Adds items to an address group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AddressGroup, OperationMetadata>> AddAddressGroupItemsAsync(AddAddressGroupItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddAddressGroupItemsRequest(ref request, ref callSettings);
            return new lro::Operation<AddressGroup, OperationMetadata>(await _callAddAddressGroupItems.Async(request, callSettings).ConfigureAwait(false), AddAddressGroupItemsOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RemoveAddressGroupItems</c>.</summary>
        public override lro::OperationsClient RemoveAddressGroupItemsOperationsClient { get; }

        /// <summary>
        /// Removes items from an address group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AddressGroup, OperationMetadata> RemoveAddressGroupItems(RemoveAddressGroupItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveAddressGroupItemsRequest(ref request, ref callSettings);
            return new lro::Operation<AddressGroup, OperationMetadata>(_callRemoveAddressGroupItems.Sync(request, callSettings), RemoveAddressGroupItemsOperationsClient);
        }

        /// <summary>
        /// Removes items from an address group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AddressGroup, OperationMetadata>> RemoveAddressGroupItemsAsync(RemoveAddressGroupItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveAddressGroupItemsRequest(ref request, ref callSettings);
            return new lro::Operation<AddressGroup, OperationMetadata>(await _callRemoveAddressGroupItems.Async(request, callSettings).ConfigureAwait(false), RemoveAddressGroupItemsOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CloneAddressGroupItems</c>.</summary>
        public override lro::OperationsClient CloneAddressGroupItemsOperationsClient { get; }

        /// <summary>
        /// Clones items from one address group to another.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AddressGroup, OperationMetadata> CloneAddressGroupItems(CloneAddressGroupItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CloneAddressGroupItemsRequest(ref request, ref callSettings);
            return new lro::Operation<AddressGroup, OperationMetadata>(_callCloneAddressGroupItems.Sync(request, callSettings), CloneAddressGroupItemsOperationsClient);
        }

        /// <summary>
        /// Clones items from one address group to another.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AddressGroup, OperationMetadata>> CloneAddressGroupItemsAsync(CloneAddressGroupItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CloneAddressGroupItemsRequest(ref request, ref callSettings);
            return new lro::Operation<AddressGroup, OperationMetadata>(await _callCloneAddressGroupItems.Async(request, callSettings).ConfigureAwait(false), CloneAddressGroupItemsOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteAddressGroup</c>.</summary>
        public override lro::OperationsClient DeleteAddressGroupOperationsClient { get; }

        /// <summary>
        /// Deletes a single address group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteAddressGroup(DeleteAddressGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAddressGroupRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteAddressGroup.Sync(request, callSettings), DeleteAddressGroupOperationsClient);
        }

        /// <summary>
        /// Deletes a single address group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAddressGroupAsync(DeleteAddressGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAddressGroupRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteAddressGroup.Async(request, callSettings).ConfigureAwait(false), DeleteAddressGroupOperationsClient);
        }

        /// <summary>
        /// Lists references of an address group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable sequence of <see cref="ListAddressGroupReferencesResponse.Types.AddressGroupReference"/>
        /// resources.
        /// </returns>
        public override gax::PagedEnumerable<ListAddressGroupReferencesResponse, ListAddressGroupReferencesResponse.Types.AddressGroupReference> ListAddressGroupReferences(ListAddressGroupReferencesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAddressGroupReferencesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAddressGroupReferencesRequest, ListAddressGroupReferencesResponse, ListAddressGroupReferencesResponse.Types.AddressGroupReference>(_callListAddressGroupReferences, request, callSettings);
        }

        /// <summary>
        /// Lists references of an address group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of
        /// <see cref="ListAddressGroupReferencesResponse.Types.AddressGroupReference"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListAddressGroupReferencesResponse, ListAddressGroupReferencesResponse.Types.AddressGroupReference> ListAddressGroupReferencesAsync(ListAddressGroupReferencesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAddressGroupReferencesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAddressGroupReferencesRequest, ListAddressGroupReferencesResponse, ListAddressGroupReferencesResponse.Types.AddressGroupReference>(_callListAddressGroupReferences, request, callSettings);
        }
    }

    public partial class ListAddressGroupsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAddressGroupReferencesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAddressGroupsResponse : gaxgrpc::IPageResponse<AddressGroup>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AddressGroup> GetEnumerator() => AddressGroups.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAddressGroupReferencesResponse : gaxgrpc::IPageResponse<ListAddressGroupReferencesResponse.Types.AddressGroupReference>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Types.AddressGroupReference> GetEnumerator() => AddressGroupReferences.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class AddressGroupService
    {
        public partial class AddressGroupServiceClient
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

    public static partial class AddressGroupService
    {
        public partial class AddressGroupServiceClient
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
