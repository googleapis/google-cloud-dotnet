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
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.NetworkSecurity.V1
{
    /// <summary>Settings for <see cref="OrganizationSecurityProfileGroupServiceClient"/> instances.</summary>
    public sealed partial class OrganizationSecurityProfileGroupServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="OrganizationSecurityProfileGroupServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="OrganizationSecurityProfileGroupServiceSettings"/>.
        /// </returns>
        public static OrganizationSecurityProfileGroupServiceSettings GetDefault() =>
            new OrganizationSecurityProfileGroupServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="OrganizationSecurityProfileGroupServiceSettings"/> object with default settings.
        /// </summary>
        public OrganizationSecurityProfileGroupServiceSettings()
        {
        }

        private OrganizationSecurityProfileGroupServiceSettings(OrganizationSecurityProfileGroupServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListSecurityProfileGroupsSettings = existing.ListSecurityProfileGroupsSettings;
            GetSecurityProfileGroupSettings = existing.GetSecurityProfileGroupSettings;
            CreateSecurityProfileGroupSettings = existing.CreateSecurityProfileGroupSettings;
            CreateSecurityProfileGroupOperationsSettings = existing.CreateSecurityProfileGroupOperationsSettings.Clone();
            UpdateSecurityProfileGroupSettings = existing.UpdateSecurityProfileGroupSettings;
            UpdateSecurityProfileGroupOperationsSettings = existing.UpdateSecurityProfileGroupOperationsSettings.Clone();
            DeleteSecurityProfileGroupSettings = existing.DeleteSecurityProfileGroupSettings;
            DeleteSecurityProfileGroupOperationsSettings = existing.DeleteSecurityProfileGroupOperationsSettings.Clone();
            ListSecurityProfilesSettings = existing.ListSecurityProfilesSettings;
            GetSecurityProfileSettings = existing.GetSecurityProfileSettings;
            CreateSecurityProfileSettings = existing.CreateSecurityProfileSettings;
            CreateSecurityProfileOperationsSettings = existing.CreateSecurityProfileOperationsSettings.Clone();
            UpdateSecurityProfileSettings = existing.UpdateSecurityProfileSettings;
            UpdateSecurityProfileOperationsSettings = existing.UpdateSecurityProfileOperationsSettings.Clone();
            DeleteSecurityProfileSettings = existing.DeleteSecurityProfileSettings;
            DeleteSecurityProfileOperationsSettings = existing.DeleteSecurityProfileOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(OrganizationSecurityProfileGroupServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrganizationSecurityProfileGroupServiceClient.ListSecurityProfileGroups</c> and
        /// <c>OrganizationSecurityProfileGroupServiceClient.ListSecurityProfileGroupsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSecurityProfileGroupsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrganizationSecurityProfileGroupServiceClient.GetSecurityProfileGroup</c> and
        /// <c>OrganizationSecurityProfileGroupServiceClient.GetSecurityProfileGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSecurityProfileGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrganizationSecurityProfileGroupServiceClient.CreateSecurityProfileGroup</c> and
        /// <c>OrganizationSecurityProfileGroupServiceClient.CreateSecurityProfileGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSecurityProfileGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>OrganizationSecurityProfileGroupServiceClient.CreateSecurityProfileGroup</c> and
        /// <c>OrganizationSecurityProfileGroupServiceClient.CreateSecurityProfileGroupAsync</c>.
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
        public lro::OperationsSettings CreateSecurityProfileGroupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrganizationSecurityProfileGroupServiceClient.UpdateSecurityProfileGroup</c> and
        /// <c>OrganizationSecurityProfileGroupServiceClient.UpdateSecurityProfileGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSecurityProfileGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>OrganizationSecurityProfileGroupServiceClient.UpdateSecurityProfileGroup</c> and
        /// <c>OrganizationSecurityProfileGroupServiceClient.UpdateSecurityProfileGroupAsync</c>.
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
        public lro::OperationsSettings UpdateSecurityProfileGroupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrganizationSecurityProfileGroupServiceClient.DeleteSecurityProfileGroup</c> and
        /// <c>OrganizationSecurityProfileGroupServiceClient.DeleteSecurityProfileGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSecurityProfileGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>OrganizationSecurityProfileGroupServiceClient.DeleteSecurityProfileGroup</c> and
        /// <c>OrganizationSecurityProfileGroupServiceClient.DeleteSecurityProfileGroupAsync</c>.
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
        public lro::OperationsSettings DeleteSecurityProfileGroupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrganizationSecurityProfileGroupServiceClient.ListSecurityProfiles</c> and
        /// <c>OrganizationSecurityProfileGroupServiceClient.ListSecurityProfilesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSecurityProfilesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrganizationSecurityProfileGroupServiceClient.GetSecurityProfile</c> and
        /// <c>OrganizationSecurityProfileGroupServiceClient.GetSecurityProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSecurityProfileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrganizationSecurityProfileGroupServiceClient.CreateSecurityProfile</c> and
        /// <c>OrganizationSecurityProfileGroupServiceClient.CreateSecurityProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSecurityProfileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>OrganizationSecurityProfileGroupServiceClient.CreateSecurityProfile</c> and
        /// <c>OrganizationSecurityProfileGroupServiceClient.CreateSecurityProfileAsync</c>.
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
        public lro::OperationsSettings CreateSecurityProfileOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrganizationSecurityProfileGroupServiceClient.UpdateSecurityProfile</c> and
        /// <c>OrganizationSecurityProfileGroupServiceClient.UpdateSecurityProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSecurityProfileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>OrganizationSecurityProfileGroupServiceClient.UpdateSecurityProfile</c> and
        /// <c>OrganizationSecurityProfileGroupServiceClient.UpdateSecurityProfileAsync</c>.
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
        public lro::OperationsSettings UpdateSecurityProfileOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrganizationSecurityProfileGroupServiceClient.DeleteSecurityProfile</c> and
        /// <c>OrganizationSecurityProfileGroupServiceClient.DeleteSecurityProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSecurityProfileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>OrganizationSecurityProfileGroupServiceClient.DeleteSecurityProfile</c> and
        /// <c>OrganizationSecurityProfileGroupServiceClient.DeleteSecurityProfileAsync</c>.
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
        public lro::OperationsSettings DeleteSecurityProfileOperationsSettings { get; set; } = new lro::OperationsSettings
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
        /// <returns>
        /// A deep clone of this <see cref="OrganizationSecurityProfileGroupServiceSettings"/> object.
        /// </returns>
        public OrganizationSecurityProfileGroupServiceSettings Clone() =>
            new OrganizationSecurityProfileGroupServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="OrganizationSecurityProfileGroupServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class OrganizationSecurityProfileGroupServiceClientBuilder : gaxgrpc::ClientBuilderBase<OrganizationSecurityProfileGroupServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public OrganizationSecurityProfileGroupServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public OrganizationSecurityProfileGroupServiceClientBuilder() : base(OrganizationSecurityProfileGroupServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref OrganizationSecurityProfileGroupServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<OrganizationSecurityProfileGroupServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override OrganizationSecurityProfileGroupServiceClient Build()
        {
            OrganizationSecurityProfileGroupServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<OrganizationSecurityProfileGroupServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<OrganizationSecurityProfileGroupServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private OrganizationSecurityProfileGroupServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return OrganizationSecurityProfileGroupServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<OrganizationSecurityProfileGroupServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return OrganizationSecurityProfileGroupServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() =>
            OrganizationSecurityProfileGroupServiceClient.ChannelPool;
    }

    /// <summary>OrganizationSecurityProfileGroupService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Organization SecurityProfileGroup is created under organization.
    /// </remarks>
    public abstract partial class OrganizationSecurityProfileGroupServiceClient
    {
        /// <summary>
        /// The default endpoint for the OrganizationSecurityProfileGroupService service, which is a host of
        /// "networksecurity.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "networksecurity.googleapis.com:443";

        /// <summary>The default OrganizationSecurityProfileGroupService scopes.</summary>
        /// <remarks>
        /// The default OrganizationSecurityProfileGroupService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(OrganizationSecurityProfileGroupService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="OrganizationSecurityProfileGroupServiceClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="OrganizationSecurityProfileGroupServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>
        /// The task representing the created <see cref="OrganizationSecurityProfileGroupServiceClient"/>.
        /// </returns>
        public static stt::Task<OrganizationSecurityProfileGroupServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new OrganizationSecurityProfileGroupServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="OrganizationSecurityProfileGroupServiceClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="OrganizationSecurityProfileGroupServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="OrganizationSecurityProfileGroupServiceClient"/>.</returns>
        public static OrganizationSecurityProfileGroupServiceClient Create() =>
            new OrganizationSecurityProfileGroupServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="OrganizationSecurityProfileGroupServiceClient"/> which uses the specified call invoker
        /// for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="OrganizationSecurityProfileGroupServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="OrganizationSecurityProfileGroupServiceClient"/>.</returns>
        internal static OrganizationSecurityProfileGroupServiceClient Create(grpccore::CallInvoker callInvoker, OrganizationSecurityProfileGroupServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            OrganizationSecurityProfileGroupService.OrganizationSecurityProfileGroupServiceClient grpcClient = new OrganizationSecurityProfileGroupService.OrganizationSecurityProfileGroupServiceClient(callInvoker);
            return new OrganizationSecurityProfileGroupServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC OrganizationSecurityProfileGroupService client</summary>
        public virtual OrganizationSecurityProfileGroupService.OrganizationSecurityProfileGroupServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists SecurityProfileGroups in a given organization and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SecurityProfileGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSecurityProfileGroupsResponse, SecurityProfileGroup> ListSecurityProfileGroups(ListSecurityProfileGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists SecurityProfileGroups in a given organization and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SecurityProfileGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSecurityProfileGroupsResponse, SecurityProfileGroup> ListSecurityProfileGroupsAsync(ListSecurityProfileGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists SecurityProfileGroups in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project or organization and location from which the
        /// SecurityProfileGroups should be listed, specified in the format
        /// `projects|organizations/*/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="SecurityProfileGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSecurityProfileGroupsResponse, SecurityProfileGroup> ListSecurityProfileGroups(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecurityProfileGroupsRequest request = new ListSecurityProfileGroupsRequest
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
            return ListSecurityProfileGroups(request, callSettings);
        }

        /// <summary>
        /// Lists SecurityProfileGroups in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project or organization and location from which the
        /// SecurityProfileGroups should be listed, specified in the format
        /// `projects|organizations/*/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SecurityProfileGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSecurityProfileGroupsResponse, SecurityProfileGroup> ListSecurityProfileGroupsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecurityProfileGroupsRequest request = new ListSecurityProfileGroupsRequest
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
            return ListSecurityProfileGroupsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists SecurityProfileGroups in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project or organization and location from which the
        /// SecurityProfileGroups should be listed, specified in the format
        /// `projects|organizations/*/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="SecurityProfileGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSecurityProfileGroupsResponse, SecurityProfileGroup> ListSecurityProfileGroups(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecurityProfileGroupsRequest request = new ListSecurityProfileGroupsRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSecurityProfileGroups(request, callSettings);
        }

        /// <summary>
        /// Lists SecurityProfileGroups in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project or organization and location from which the
        /// SecurityProfileGroups should be listed, specified in the format
        /// `projects|organizations/*/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SecurityProfileGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSecurityProfileGroupsResponse, SecurityProfileGroup> ListSecurityProfileGroupsAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecurityProfileGroupsRequest request = new ListSecurityProfileGroupsRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSecurityProfileGroupsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists SecurityProfileGroups in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project or organization and location from which the
        /// SecurityProfileGroups should be listed, specified in the format
        /// `projects|organizations/*/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="SecurityProfileGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSecurityProfileGroupsResponse, SecurityProfileGroup> ListSecurityProfileGroups(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecurityProfileGroupsRequest request = new ListSecurityProfileGroupsRequest
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
            return ListSecurityProfileGroups(request, callSettings);
        }

        /// <summary>
        /// Lists SecurityProfileGroups in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project or organization and location from which the
        /// SecurityProfileGroups should be listed, specified in the format
        /// `projects|organizations/*/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SecurityProfileGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSecurityProfileGroupsResponse, SecurityProfileGroup> ListSecurityProfileGroupsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecurityProfileGroupsRequest request = new ListSecurityProfileGroupsRequest
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
            return ListSecurityProfileGroupsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single SecurityProfileGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecurityProfileGroup GetSecurityProfileGroup(GetSecurityProfileGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single SecurityProfileGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityProfileGroup> GetSecurityProfileGroupAsync(GetSecurityProfileGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single SecurityProfileGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityProfileGroup> GetSecurityProfileGroupAsync(GetSecurityProfileGroupRequest request, st::CancellationToken cancellationToken) =>
            GetSecurityProfileGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single SecurityProfileGroup.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the SecurityProfileGroup to get. Must be in the format
        /// `projects|organizations/*/locations/{location}/securityProfileGroups/{security_profile_group}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecurityProfileGroup GetSecurityProfileGroup(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSecurityProfileGroup(new GetSecurityProfileGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single SecurityProfileGroup.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the SecurityProfileGroup to get. Must be in the format
        /// `projects|organizations/*/locations/{location}/securityProfileGroups/{security_profile_group}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityProfileGroup> GetSecurityProfileGroupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSecurityProfileGroupAsync(new GetSecurityProfileGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single SecurityProfileGroup.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the SecurityProfileGroup to get. Must be in the format
        /// `projects|organizations/*/locations/{location}/securityProfileGroups/{security_profile_group}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityProfileGroup> GetSecurityProfileGroupAsync(string name, st::CancellationToken cancellationToken) =>
            GetSecurityProfileGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single SecurityProfileGroup.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the SecurityProfileGroup to get. Must be in the format
        /// `projects|organizations/*/locations/{location}/securityProfileGroups/{security_profile_group}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecurityProfileGroup GetSecurityProfileGroup(SecurityProfileGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSecurityProfileGroup(new GetSecurityProfileGroupRequest
            {
                SecurityProfileGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single SecurityProfileGroup.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the SecurityProfileGroup to get. Must be in the format
        /// `projects|organizations/*/locations/{location}/securityProfileGroups/{security_profile_group}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityProfileGroup> GetSecurityProfileGroupAsync(SecurityProfileGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSecurityProfileGroupAsync(new GetSecurityProfileGroupRequest
            {
                SecurityProfileGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single SecurityProfileGroup.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the SecurityProfileGroup to get. Must be in the format
        /// `projects|organizations/*/locations/{location}/securityProfileGroups/{security_profile_group}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityProfileGroup> GetSecurityProfileGroupAsync(SecurityProfileGroupName name, st::CancellationToken cancellationToken) =>
            GetSecurityProfileGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new SecurityProfileGroup in a given organization and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SecurityProfileGroup, OperationMetadata> CreateSecurityProfileGroup(CreateSecurityProfileGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new SecurityProfileGroup in a given organization and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SecurityProfileGroup, OperationMetadata>> CreateSecurityProfileGroupAsync(CreateSecurityProfileGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new SecurityProfileGroup in a given organization and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SecurityProfileGroup, OperationMetadata>> CreateSecurityProfileGroupAsync(CreateSecurityProfileGroupRequest request, st::CancellationToken cancellationToken) =>
            CreateSecurityProfileGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateSecurityProfileGroup</c>.</summary>
        public virtual lro::OperationsClient CreateSecurityProfileGroupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateSecurityProfileGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<SecurityProfileGroup, OperationMetadata> PollOnceCreateSecurityProfileGroup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SecurityProfileGroup, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSecurityProfileGroupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateSecurityProfileGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<SecurityProfileGroup, OperationMetadata>> PollOnceCreateSecurityProfileGroupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SecurityProfileGroup, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSecurityProfileGroupOperationsClient, callSettings);

        /// <summary>
        /// Creates a new SecurityProfileGroup in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the SecurityProfileGroup. Must be in the
        /// format `projects|organizations/*/locations/{location}`.
        /// </param>
        /// <param name="securityProfileGroup">
        /// Required. SecurityProfileGroup resource to be created.
        /// </param>
        /// <param name="securityProfileGroupId">
        /// Required. Short name of the SecurityProfileGroup resource to be created.
        /// This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start
        /// with a number. E.g. "security_profile_group1".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SecurityProfileGroup, OperationMetadata> CreateSecurityProfileGroup(string parent, SecurityProfileGroup securityProfileGroup, string securityProfileGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSecurityProfileGroup(new CreateSecurityProfileGroupRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SecurityProfileGroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(securityProfileGroupId, nameof(securityProfileGroupId)),
                SecurityProfileGroup = gax::GaxPreconditions.CheckNotNull(securityProfileGroup, nameof(securityProfileGroup)),
            }, callSettings);

        /// <summary>
        /// Creates a new SecurityProfileGroup in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the SecurityProfileGroup. Must be in the
        /// format `projects|organizations/*/locations/{location}`.
        /// </param>
        /// <param name="securityProfileGroup">
        /// Required. SecurityProfileGroup resource to be created.
        /// </param>
        /// <param name="securityProfileGroupId">
        /// Required. Short name of the SecurityProfileGroup resource to be created.
        /// This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start
        /// with a number. E.g. "security_profile_group1".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SecurityProfileGroup, OperationMetadata>> CreateSecurityProfileGroupAsync(string parent, SecurityProfileGroup securityProfileGroup, string securityProfileGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSecurityProfileGroupAsync(new CreateSecurityProfileGroupRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SecurityProfileGroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(securityProfileGroupId, nameof(securityProfileGroupId)),
                SecurityProfileGroup = gax::GaxPreconditions.CheckNotNull(securityProfileGroup, nameof(securityProfileGroup)),
            }, callSettings);

        /// <summary>
        /// Creates a new SecurityProfileGroup in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the SecurityProfileGroup. Must be in the
        /// format `projects|organizations/*/locations/{location}`.
        /// </param>
        /// <param name="securityProfileGroup">
        /// Required. SecurityProfileGroup resource to be created.
        /// </param>
        /// <param name="securityProfileGroupId">
        /// Required. Short name of the SecurityProfileGroup resource to be created.
        /// This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start
        /// with a number. E.g. "security_profile_group1".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SecurityProfileGroup, OperationMetadata>> CreateSecurityProfileGroupAsync(string parent, SecurityProfileGroup securityProfileGroup, string securityProfileGroupId, st::CancellationToken cancellationToken) =>
            CreateSecurityProfileGroupAsync(parent, securityProfileGroup, securityProfileGroupId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new SecurityProfileGroup in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the SecurityProfileGroup. Must be in the
        /// format `projects|organizations/*/locations/{location}`.
        /// </param>
        /// <param name="securityProfileGroup">
        /// Required. SecurityProfileGroup resource to be created.
        /// </param>
        /// <param name="securityProfileGroupId">
        /// Required. Short name of the SecurityProfileGroup resource to be created.
        /// This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start
        /// with a number. E.g. "security_profile_group1".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SecurityProfileGroup, OperationMetadata> CreateSecurityProfileGroup(OrganizationLocationName parent, SecurityProfileGroup securityProfileGroup, string securityProfileGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSecurityProfileGroup(new CreateSecurityProfileGroupRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SecurityProfileGroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(securityProfileGroupId, nameof(securityProfileGroupId)),
                SecurityProfileGroup = gax::GaxPreconditions.CheckNotNull(securityProfileGroup, nameof(securityProfileGroup)),
            }, callSettings);

        /// <summary>
        /// Creates a new SecurityProfileGroup in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the SecurityProfileGroup. Must be in the
        /// format `projects|organizations/*/locations/{location}`.
        /// </param>
        /// <param name="securityProfileGroup">
        /// Required. SecurityProfileGroup resource to be created.
        /// </param>
        /// <param name="securityProfileGroupId">
        /// Required. Short name of the SecurityProfileGroup resource to be created.
        /// This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start
        /// with a number. E.g. "security_profile_group1".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SecurityProfileGroup, OperationMetadata>> CreateSecurityProfileGroupAsync(OrganizationLocationName parent, SecurityProfileGroup securityProfileGroup, string securityProfileGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSecurityProfileGroupAsync(new CreateSecurityProfileGroupRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SecurityProfileGroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(securityProfileGroupId, nameof(securityProfileGroupId)),
                SecurityProfileGroup = gax::GaxPreconditions.CheckNotNull(securityProfileGroup, nameof(securityProfileGroup)),
            }, callSettings);

        /// <summary>
        /// Creates a new SecurityProfileGroup in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the SecurityProfileGroup. Must be in the
        /// format `projects|organizations/*/locations/{location}`.
        /// </param>
        /// <param name="securityProfileGroup">
        /// Required. SecurityProfileGroup resource to be created.
        /// </param>
        /// <param name="securityProfileGroupId">
        /// Required. Short name of the SecurityProfileGroup resource to be created.
        /// This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start
        /// with a number. E.g. "security_profile_group1".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SecurityProfileGroup, OperationMetadata>> CreateSecurityProfileGroupAsync(OrganizationLocationName parent, SecurityProfileGroup securityProfileGroup, string securityProfileGroupId, st::CancellationToken cancellationToken) =>
            CreateSecurityProfileGroupAsync(parent, securityProfileGroup, securityProfileGroupId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new SecurityProfileGroup in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the SecurityProfileGroup. Must be in the
        /// format `projects|organizations/*/locations/{location}`.
        /// </param>
        /// <param name="securityProfileGroup">
        /// Required. SecurityProfileGroup resource to be created.
        /// </param>
        /// <param name="securityProfileGroupId">
        /// Required. Short name of the SecurityProfileGroup resource to be created.
        /// This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start
        /// with a number. E.g. "security_profile_group1".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SecurityProfileGroup, OperationMetadata> CreateSecurityProfileGroup(gagr::LocationName parent, SecurityProfileGroup securityProfileGroup, string securityProfileGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSecurityProfileGroup(new CreateSecurityProfileGroupRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SecurityProfileGroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(securityProfileGroupId, nameof(securityProfileGroupId)),
                SecurityProfileGroup = gax::GaxPreconditions.CheckNotNull(securityProfileGroup, nameof(securityProfileGroup)),
            }, callSettings);

        /// <summary>
        /// Creates a new SecurityProfileGroup in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the SecurityProfileGroup. Must be in the
        /// format `projects|organizations/*/locations/{location}`.
        /// </param>
        /// <param name="securityProfileGroup">
        /// Required. SecurityProfileGroup resource to be created.
        /// </param>
        /// <param name="securityProfileGroupId">
        /// Required. Short name of the SecurityProfileGroup resource to be created.
        /// This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start
        /// with a number. E.g. "security_profile_group1".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SecurityProfileGroup, OperationMetadata>> CreateSecurityProfileGroupAsync(gagr::LocationName parent, SecurityProfileGroup securityProfileGroup, string securityProfileGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSecurityProfileGroupAsync(new CreateSecurityProfileGroupRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SecurityProfileGroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(securityProfileGroupId, nameof(securityProfileGroupId)),
                SecurityProfileGroup = gax::GaxPreconditions.CheckNotNull(securityProfileGroup, nameof(securityProfileGroup)),
            }, callSettings);

        /// <summary>
        /// Creates a new SecurityProfileGroup in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the SecurityProfileGroup. Must be in the
        /// format `projects|organizations/*/locations/{location}`.
        /// </param>
        /// <param name="securityProfileGroup">
        /// Required. SecurityProfileGroup resource to be created.
        /// </param>
        /// <param name="securityProfileGroupId">
        /// Required. Short name of the SecurityProfileGroup resource to be created.
        /// This value should be 1-63 characters long, containing only
        /// letters, numbers, hyphens, and underscores, and should not start
        /// with a number. E.g. "security_profile_group1".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SecurityProfileGroup, OperationMetadata>> CreateSecurityProfileGroupAsync(gagr::LocationName parent, SecurityProfileGroup securityProfileGroup, string securityProfileGroupId, st::CancellationToken cancellationToken) =>
            CreateSecurityProfileGroupAsync(parent, securityProfileGroup, securityProfileGroupId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single SecurityProfileGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SecurityProfileGroup, OperationMetadata> UpdateSecurityProfileGroup(UpdateSecurityProfileGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single SecurityProfileGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SecurityProfileGroup, OperationMetadata>> UpdateSecurityProfileGroupAsync(UpdateSecurityProfileGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single SecurityProfileGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SecurityProfileGroup, OperationMetadata>> UpdateSecurityProfileGroupAsync(UpdateSecurityProfileGroupRequest request, st::CancellationToken cancellationToken) =>
            UpdateSecurityProfileGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateSecurityProfileGroup</c>.</summary>
        public virtual lro::OperationsClient UpdateSecurityProfileGroupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateSecurityProfileGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<SecurityProfileGroup, OperationMetadata> PollOnceUpdateSecurityProfileGroup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SecurityProfileGroup, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateSecurityProfileGroupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateSecurityProfileGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<SecurityProfileGroup, OperationMetadata>> PollOnceUpdateSecurityProfileGroupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SecurityProfileGroup, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateSecurityProfileGroupOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single SecurityProfileGroup.
        /// </summary>
        /// <param name="securityProfileGroup">
        /// Required. Updated SecurityProfileGroup resource.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// SecurityProfileGroup resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SecurityProfileGroup, OperationMetadata> UpdateSecurityProfileGroup(SecurityProfileGroup securityProfileGroup, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSecurityProfileGroup(new UpdateSecurityProfileGroupRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                SecurityProfileGroup = gax::GaxPreconditions.CheckNotNull(securityProfileGroup, nameof(securityProfileGroup)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single SecurityProfileGroup.
        /// </summary>
        /// <param name="securityProfileGroup">
        /// Required. Updated SecurityProfileGroup resource.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// SecurityProfileGroup resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SecurityProfileGroup, OperationMetadata>> UpdateSecurityProfileGroupAsync(SecurityProfileGroup securityProfileGroup, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSecurityProfileGroupAsync(new UpdateSecurityProfileGroupRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                SecurityProfileGroup = gax::GaxPreconditions.CheckNotNull(securityProfileGroup, nameof(securityProfileGroup)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single SecurityProfileGroup.
        /// </summary>
        /// <param name="securityProfileGroup">
        /// Required. Updated SecurityProfileGroup resource.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// SecurityProfileGroup resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SecurityProfileGroup, OperationMetadata>> UpdateSecurityProfileGroupAsync(SecurityProfileGroup securityProfileGroup, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSecurityProfileGroupAsync(securityProfileGroup, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single SecurityProfileGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSecurityProfileGroup(DeleteSecurityProfileGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single SecurityProfileGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSecurityProfileGroupAsync(DeleteSecurityProfileGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single SecurityProfileGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSecurityProfileGroupAsync(DeleteSecurityProfileGroupRequest request, st::CancellationToken cancellationToken) =>
            DeleteSecurityProfileGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteSecurityProfileGroup</c>.</summary>
        public virtual lro::OperationsClient DeleteSecurityProfileGroupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteSecurityProfileGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteSecurityProfileGroup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSecurityProfileGroupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteSecurityProfileGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteSecurityProfileGroupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSecurityProfileGroupOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single SecurityProfileGroup.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the SecurityProfileGroup to delete. Must be in the
        /// format
        /// `projects|organizations/*/locations/{location}/securityProfileGroups/{security_profile_group}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSecurityProfileGroup(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSecurityProfileGroup(new DeleteSecurityProfileGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single SecurityProfileGroup.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the SecurityProfileGroup to delete. Must be in the
        /// format
        /// `projects|organizations/*/locations/{location}/securityProfileGroups/{security_profile_group}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSecurityProfileGroupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSecurityProfileGroupAsync(new DeleteSecurityProfileGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single SecurityProfileGroup.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the SecurityProfileGroup to delete. Must be in the
        /// format
        /// `projects|organizations/*/locations/{location}/securityProfileGroups/{security_profile_group}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSecurityProfileGroupAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSecurityProfileGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single SecurityProfileGroup.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the SecurityProfileGroup to delete. Must be in the
        /// format
        /// `projects|organizations/*/locations/{location}/securityProfileGroups/{security_profile_group}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSecurityProfileGroup(SecurityProfileGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSecurityProfileGroup(new DeleteSecurityProfileGroupRequest
            {
                SecurityProfileGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single SecurityProfileGroup.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the SecurityProfileGroup to delete. Must be in the
        /// format
        /// `projects|organizations/*/locations/{location}/securityProfileGroups/{security_profile_group}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSecurityProfileGroupAsync(SecurityProfileGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSecurityProfileGroupAsync(new DeleteSecurityProfileGroupRequest
            {
                SecurityProfileGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single SecurityProfileGroup.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the SecurityProfileGroup to delete. Must be in the
        /// format
        /// `projects|organizations/*/locations/{location}/securityProfileGroups/{security_profile_group}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSecurityProfileGroupAsync(SecurityProfileGroupName name, st::CancellationToken cancellationToken) =>
            DeleteSecurityProfileGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists SecurityProfiles in a given organization and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SecurityProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSecurityProfilesResponse, SecurityProfile> ListSecurityProfiles(ListSecurityProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists SecurityProfiles in a given organization and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SecurityProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSecurityProfilesResponse, SecurityProfile> ListSecurityProfilesAsync(ListSecurityProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists SecurityProfiles in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project or organization and location from which the
        /// SecurityProfiles should be listed, specified in the format
        /// `projects|organizations/*/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="SecurityProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSecurityProfilesResponse, SecurityProfile> ListSecurityProfiles(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecurityProfilesRequest request = new ListSecurityProfilesRequest
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
            return ListSecurityProfiles(request, callSettings);
        }

        /// <summary>
        /// Lists SecurityProfiles in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project or organization and location from which the
        /// SecurityProfiles should be listed, specified in the format
        /// `projects|organizations/*/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SecurityProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSecurityProfilesResponse, SecurityProfile> ListSecurityProfilesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecurityProfilesRequest request = new ListSecurityProfilesRequest
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
            return ListSecurityProfilesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists SecurityProfiles in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project or organization and location from which the
        /// SecurityProfiles should be listed, specified in the format
        /// `projects|organizations/*/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="SecurityProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSecurityProfilesResponse, SecurityProfile> ListSecurityProfiles(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecurityProfilesRequest request = new ListSecurityProfilesRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSecurityProfiles(request, callSettings);
        }

        /// <summary>
        /// Lists SecurityProfiles in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project or organization and location from which the
        /// SecurityProfiles should be listed, specified in the format
        /// `projects|organizations/*/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SecurityProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSecurityProfilesResponse, SecurityProfile> ListSecurityProfilesAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecurityProfilesRequest request = new ListSecurityProfilesRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSecurityProfilesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists SecurityProfiles in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project or organization and location from which the
        /// SecurityProfiles should be listed, specified in the format
        /// `projects|organizations/*/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="SecurityProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSecurityProfilesResponse, SecurityProfile> ListSecurityProfiles(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecurityProfilesRequest request = new ListSecurityProfilesRequest
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
            return ListSecurityProfiles(request, callSettings);
        }

        /// <summary>
        /// Lists SecurityProfiles in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project or organization and location from which the
        /// SecurityProfiles should be listed, specified in the format
        /// `projects|organizations/*/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SecurityProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSecurityProfilesResponse, SecurityProfile> ListSecurityProfilesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecurityProfilesRequest request = new ListSecurityProfilesRequest
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
            return ListSecurityProfilesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single SecurityProfile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecurityProfile GetSecurityProfile(GetSecurityProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single SecurityProfile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityProfile> GetSecurityProfileAsync(GetSecurityProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single SecurityProfile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityProfile> GetSecurityProfileAsync(GetSecurityProfileRequest request, st::CancellationToken cancellationToken) =>
            GetSecurityProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single SecurityProfile.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the SecurityProfile to get. Must be in the format
        /// `projects|organizations/*/locations/{location}/securityProfiles/{security_profile_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecurityProfile GetSecurityProfile(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSecurityProfile(new GetSecurityProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single SecurityProfile.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the SecurityProfile to get. Must be in the format
        /// `projects|organizations/*/locations/{location}/securityProfiles/{security_profile_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityProfile> GetSecurityProfileAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSecurityProfileAsync(new GetSecurityProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single SecurityProfile.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the SecurityProfile to get. Must be in the format
        /// `projects|organizations/*/locations/{location}/securityProfiles/{security_profile_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityProfile> GetSecurityProfileAsync(string name, st::CancellationToken cancellationToken) =>
            GetSecurityProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single SecurityProfile.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the SecurityProfile to get. Must be in the format
        /// `projects|organizations/*/locations/{location}/securityProfiles/{security_profile_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecurityProfile GetSecurityProfile(SecurityProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSecurityProfile(new GetSecurityProfileRequest
            {
                SecurityProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single SecurityProfile.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the SecurityProfile to get. Must be in the format
        /// `projects|organizations/*/locations/{location}/securityProfiles/{security_profile_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityProfile> GetSecurityProfileAsync(SecurityProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSecurityProfileAsync(new GetSecurityProfileRequest
            {
                SecurityProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single SecurityProfile.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the SecurityProfile to get. Must be in the format
        /// `projects|organizations/*/locations/{location}/securityProfiles/{security_profile_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityProfile> GetSecurityProfileAsync(SecurityProfileName name, st::CancellationToken cancellationToken) =>
            GetSecurityProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new SecurityProfile in a given organization and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SecurityProfile, OperationMetadata> CreateSecurityProfile(CreateSecurityProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new SecurityProfile in a given organization and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SecurityProfile, OperationMetadata>> CreateSecurityProfileAsync(CreateSecurityProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new SecurityProfile in a given organization and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SecurityProfile, OperationMetadata>> CreateSecurityProfileAsync(CreateSecurityProfileRequest request, st::CancellationToken cancellationToken) =>
            CreateSecurityProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateSecurityProfile</c>.</summary>
        public virtual lro::OperationsClient CreateSecurityProfileOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateSecurityProfile</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<SecurityProfile, OperationMetadata> PollOnceCreateSecurityProfile(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SecurityProfile, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSecurityProfileOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateSecurityProfile</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<SecurityProfile, OperationMetadata>> PollOnceCreateSecurityProfileAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SecurityProfile, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSecurityProfileOperationsClient, callSettings);

        /// <summary>
        /// Creates a new SecurityProfile in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the SecurityProfile. Must be in the format
        /// `projects|organizations/*/locations/{location}`.
        /// </param>
        /// <param name="securityProfile">
        /// Required. SecurityProfile resource to be created.
        /// </param>
        /// <param name="securityProfileId">
        /// Required. Short name of the SecurityProfile resource to be created. This
        /// value should be 1-63 characters long, containing only letters, numbers,
        /// hyphens, and underscores, and should not start with a number. E.g.
        /// "security_profile1".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SecurityProfile, OperationMetadata> CreateSecurityProfile(string parent, SecurityProfile securityProfile, string securityProfileId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSecurityProfile(new CreateSecurityProfileRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SecurityProfileId = gax::GaxPreconditions.CheckNotNullOrEmpty(securityProfileId, nameof(securityProfileId)),
                SecurityProfile = gax::GaxPreconditions.CheckNotNull(securityProfile, nameof(securityProfile)),
            }, callSettings);

        /// <summary>
        /// Creates a new SecurityProfile in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the SecurityProfile. Must be in the format
        /// `projects|organizations/*/locations/{location}`.
        /// </param>
        /// <param name="securityProfile">
        /// Required. SecurityProfile resource to be created.
        /// </param>
        /// <param name="securityProfileId">
        /// Required. Short name of the SecurityProfile resource to be created. This
        /// value should be 1-63 characters long, containing only letters, numbers,
        /// hyphens, and underscores, and should not start with a number. E.g.
        /// "security_profile1".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SecurityProfile, OperationMetadata>> CreateSecurityProfileAsync(string parent, SecurityProfile securityProfile, string securityProfileId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSecurityProfileAsync(new CreateSecurityProfileRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SecurityProfileId = gax::GaxPreconditions.CheckNotNullOrEmpty(securityProfileId, nameof(securityProfileId)),
                SecurityProfile = gax::GaxPreconditions.CheckNotNull(securityProfile, nameof(securityProfile)),
            }, callSettings);

        /// <summary>
        /// Creates a new SecurityProfile in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the SecurityProfile. Must be in the format
        /// `projects|organizations/*/locations/{location}`.
        /// </param>
        /// <param name="securityProfile">
        /// Required. SecurityProfile resource to be created.
        /// </param>
        /// <param name="securityProfileId">
        /// Required. Short name of the SecurityProfile resource to be created. This
        /// value should be 1-63 characters long, containing only letters, numbers,
        /// hyphens, and underscores, and should not start with a number. E.g.
        /// "security_profile1".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SecurityProfile, OperationMetadata>> CreateSecurityProfileAsync(string parent, SecurityProfile securityProfile, string securityProfileId, st::CancellationToken cancellationToken) =>
            CreateSecurityProfileAsync(parent, securityProfile, securityProfileId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new SecurityProfile in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the SecurityProfile. Must be in the format
        /// `projects|organizations/*/locations/{location}`.
        /// </param>
        /// <param name="securityProfile">
        /// Required. SecurityProfile resource to be created.
        /// </param>
        /// <param name="securityProfileId">
        /// Required. Short name of the SecurityProfile resource to be created. This
        /// value should be 1-63 characters long, containing only letters, numbers,
        /// hyphens, and underscores, and should not start with a number. E.g.
        /// "security_profile1".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SecurityProfile, OperationMetadata> CreateSecurityProfile(OrganizationLocationName parent, SecurityProfile securityProfile, string securityProfileId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSecurityProfile(new CreateSecurityProfileRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SecurityProfileId = gax::GaxPreconditions.CheckNotNullOrEmpty(securityProfileId, nameof(securityProfileId)),
                SecurityProfile = gax::GaxPreconditions.CheckNotNull(securityProfile, nameof(securityProfile)),
            }, callSettings);

        /// <summary>
        /// Creates a new SecurityProfile in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the SecurityProfile. Must be in the format
        /// `projects|organizations/*/locations/{location}`.
        /// </param>
        /// <param name="securityProfile">
        /// Required. SecurityProfile resource to be created.
        /// </param>
        /// <param name="securityProfileId">
        /// Required. Short name of the SecurityProfile resource to be created. This
        /// value should be 1-63 characters long, containing only letters, numbers,
        /// hyphens, and underscores, and should not start with a number. E.g.
        /// "security_profile1".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SecurityProfile, OperationMetadata>> CreateSecurityProfileAsync(OrganizationLocationName parent, SecurityProfile securityProfile, string securityProfileId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSecurityProfileAsync(new CreateSecurityProfileRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SecurityProfileId = gax::GaxPreconditions.CheckNotNullOrEmpty(securityProfileId, nameof(securityProfileId)),
                SecurityProfile = gax::GaxPreconditions.CheckNotNull(securityProfile, nameof(securityProfile)),
            }, callSettings);

        /// <summary>
        /// Creates a new SecurityProfile in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the SecurityProfile. Must be in the format
        /// `projects|organizations/*/locations/{location}`.
        /// </param>
        /// <param name="securityProfile">
        /// Required. SecurityProfile resource to be created.
        /// </param>
        /// <param name="securityProfileId">
        /// Required. Short name of the SecurityProfile resource to be created. This
        /// value should be 1-63 characters long, containing only letters, numbers,
        /// hyphens, and underscores, and should not start with a number. E.g.
        /// "security_profile1".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SecurityProfile, OperationMetadata>> CreateSecurityProfileAsync(OrganizationLocationName parent, SecurityProfile securityProfile, string securityProfileId, st::CancellationToken cancellationToken) =>
            CreateSecurityProfileAsync(parent, securityProfile, securityProfileId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new SecurityProfile in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the SecurityProfile. Must be in the format
        /// `projects|organizations/*/locations/{location}`.
        /// </param>
        /// <param name="securityProfile">
        /// Required. SecurityProfile resource to be created.
        /// </param>
        /// <param name="securityProfileId">
        /// Required. Short name of the SecurityProfile resource to be created. This
        /// value should be 1-63 characters long, containing only letters, numbers,
        /// hyphens, and underscores, and should not start with a number. E.g.
        /// "security_profile1".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SecurityProfile, OperationMetadata> CreateSecurityProfile(gagr::LocationName parent, SecurityProfile securityProfile, string securityProfileId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSecurityProfile(new CreateSecurityProfileRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SecurityProfileId = gax::GaxPreconditions.CheckNotNullOrEmpty(securityProfileId, nameof(securityProfileId)),
                SecurityProfile = gax::GaxPreconditions.CheckNotNull(securityProfile, nameof(securityProfile)),
            }, callSettings);

        /// <summary>
        /// Creates a new SecurityProfile in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the SecurityProfile. Must be in the format
        /// `projects|organizations/*/locations/{location}`.
        /// </param>
        /// <param name="securityProfile">
        /// Required. SecurityProfile resource to be created.
        /// </param>
        /// <param name="securityProfileId">
        /// Required. Short name of the SecurityProfile resource to be created. This
        /// value should be 1-63 characters long, containing only letters, numbers,
        /// hyphens, and underscores, and should not start with a number. E.g.
        /// "security_profile1".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SecurityProfile, OperationMetadata>> CreateSecurityProfileAsync(gagr::LocationName parent, SecurityProfile securityProfile, string securityProfileId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSecurityProfileAsync(new CreateSecurityProfileRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SecurityProfileId = gax::GaxPreconditions.CheckNotNullOrEmpty(securityProfileId, nameof(securityProfileId)),
                SecurityProfile = gax::GaxPreconditions.CheckNotNull(securityProfile, nameof(securityProfile)),
            }, callSettings);

        /// <summary>
        /// Creates a new SecurityProfile in a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource of the SecurityProfile. Must be in the format
        /// `projects|organizations/*/locations/{location}`.
        /// </param>
        /// <param name="securityProfile">
        /// Required. SecurityProfile resource to be created.
        /// </param>
        /// <param name="securityProfileId">
        /// Required. Short name of the SecurityProfile resource to be created. This
        /// value should be 1-63 characters long, containing only letters, numbers,
        /// hyphens, and underscores, and should not start with a number. E.g.
        /// "security_profile1".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SecurityProfile, OperationMetadata>> CreateSecurityProfileAsync(gagr::LocationName parent, SecurityProfile securityProfile, string securityProfileId, st::CancellationToken cancellationToken) =>
            CreateSecurityProfileAsync(parent, securityProfile, securityProfileId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single SecurityProfile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SecurityProfile, OperationMetadata> UpdateSecurityProfile(UpdateSecurityProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single SecurityProfile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SecurityProfile, OperationMetadata>> UpdateSecurityProfileAsync(UpdateSecurityProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single SecurityProfile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SecurityProfile, OperationMetadata>> UpdateSecurityProfileAsync(UpdateSecurityProfileRequest request, st::CancellationToken cancellationToken) =>
            UpdateSecurityProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateSecurityProfile</c>.</summary>
        public virtual lro::OperationsClient UpdateSecurityProfileOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateSecurityProfile</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<SecurityProfile, OperationMetadata> PollOnceUpdateSecurityProfile(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SecurityProfile, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateSecurityProfileOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateSecurityProfile</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<SecurityProfile, OperationMetadata>> PollOnceUpdateSecurityProfileAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SecurityProfile, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateSecurityProfileOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single SecurityProfile.
        /// </summary>
        /// <param name="securityProfile">
        /// Required. Updated SecurityProfile resource.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// SecurityProfile resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SecurityProfile, OperationMetadata> UpdateSecurityProfile(SecurityProfile securityProfile, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSecurityProfile(new UpdateSecurityProfileRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                SecurityProfile = gax::GaxPreconditions.CheckNotNull(securityProfile, nameof(securityProfile)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single SecurityProfile.
        /// </summary>
        /// <param name="securityProfile">
        /// Required. Updated SecurityProfile resource.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// SecurityProfile resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SecurityProfile, OperationMetadata>> UpdateSecurityProfileAsync(SecurityProfile securityProfile, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSecurityProfileAsync(new UpdateSecurityProfileRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                SecurityProfile = gax::GaxPreconditions.CheckNotNull(securityProfile, nameof(securityProfile)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single SecurityProfile.
        /// </summary>
        /// <param name="securityProfile">
        /// Required. Updated SecurityProfile resource.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// SecurityProfile resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SecurityProfile, OperationMetadata>> UpdateSecurityProfileAsync(SecurityProfile securityProfile, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSecurityProfileAsync(securityProfile, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single SecurityProfile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSecurityProfile(DeleteSecurityProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single SecurityProfile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSecurityProfileAsync(DeleteSecurityProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single SecurityProfile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSecurityProfileAsync(DeleteSecurityProfileRequest request, st::CancellationToken cancellationToken) =>
            DeleteSecurityProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteSecurityProfile</c>.</summary>
        public virtual lro::OperationsClient DeleteSecurityProfileOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteSecurityProfile</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteSecurityProfile(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSecurityProfileOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteSecurityProfile</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteSecurityProfileAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSecurityProfileOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single SecurityProfile.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the SecurityProfile to delete. Must be in the format
        /// `projects|organizations/*/locations/{location}/securityProfiles/{security_profile_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSecurityProfile(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSecurityProfile(new DeleteSecurityProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single SecurityProfile.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the SecurityProfile to delete. Must be in the format
        /// `projects|organizations/*/locations/{location}/securityProfiles/{security_profile_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSecurityProfileAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSecurityProfileAsync(new DeleteSecurityProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single SecurityProfile.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the SecurityProfile to delete. Must be in the format
        /// `projects|organizations/*/locations/{location}/securityProfiles/{security_profile_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSecurityProfileAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSecurityProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single SecurityProfile.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the SecurityProfile to delete. Must be in the format
        /// `projects|organizations/*/locations/{location}/securityProfiles/{security_profile_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSecurityProfile(SecurityProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSecurityProfile(new DeleteSecurityProfileRequest
            {
                SecurityProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single SecurityProfile.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the SecurityProfile to delete. Must be in the format
        /// `projects|organizations/*/locations/{location}/securityProfiles/{security_profile_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSecurityProfileAsync(SecurityProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSecurityProfileAsync(new DeleteSecurityProfileRequest
            {
                SecurityProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single SecurityProfile.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the SecurityProfile to delete. Must be in the format
        /// `projects|organizations/*/locations/{location}/securityProfiles/{security_profile_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSecurityProfileAsync(SecurityProfileName name, st::CancellationToken cancellationToken) =>
            DeleteSecurityProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>OrganizationSecurityProfileGroupService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Organization SecurityProfileGroup is created under organization.
    /// </remarks>
    public sealed partial class OrganizationSecurityProfileGroupServiceClientImpl : OrganizationSecurityProfileGroupServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListSecurityProfileGroupsRequest, ListSecurityProfileGroupsResponse> _callListSecurityProfileGroups;

        private readonly gaxgrpc::ApiCall<GetSecurityProfileGroupRequest, SecurityProfileGroup> _callGetSecurityProfileGroup;

        private readonly gaxgrpc::ApiCall<CreateSecurityProfileGroupRequest, lro::Operation> _callCreateSecurityProfileGroup;

        private readonly gaxgrpc::ApiCall<UpdateSecurityProfileGroupRequest, lro::Operation> _callUpdateSecurityProfileGroup;

        private readonly gaxgrpc::ApiCall<DeleteSecurityProfileGroupRequest, lro::Operation> _callDeleteSecurityProfileGroup;

        private readonly gaxgrpc::ApiCall<ListSecurityProfilesRequest, ListSecurityProfilesResponse> _callListSecurityProfiles;

        private readonly gaxgrpc::ApiCall<GetSecurityProfileRequest, SecurityProfile> _callGetSecurityProfile;

        private readonly gaxgrpc::ApiCall<CreateSecurityProfileRequest, lro::Operation> _callCreateSecurityProfile;

        private readonly gaxgrpc::ApiCall<UpdateSecurityProfileRequest, lro::Operation> _callUpdateSecurityProfile;

        private readonly gaxgrpc::ApiCall<DeleteSecurityProfileRequest, lro::Operation> _callDeleteSecurityProfile;

        /// <summary>
        /// Constructs a client wrapper for the OrganizationSecurityProfileGroupService service, with the specified gRPC
        /// client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="OrganizationSecurityProfileGroupServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public OrganizationSecurityProfileGroupServiceClientImpl(OrganizationSecurityProfileGroupService.OrganizationSecurityProfileGroupServiceClient grpcClient, OrganizationSecurityProfileGroupServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            OrganizationSecurityProfileGroupServiceSettings effectiveSettings = settings ?? OrganizationSecurityProfileGroupServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateSecurityProfileGroupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateSecurityProfileGroupOperationsSettings, logger);
            UpdateSecurityProfileGroupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateSecurityProfileGroupOperationsSettings, logger);
            DeleteSecurityProfileGroupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteSecurityProfileGroupOperationsSettings, logger);
            CreateSecurityProfileOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateSecurityProfileOperationsSettings, logger);
            UpdateSecurityProfileOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateSecurityProfileOperationsSettings, logger);
            DeleteSecurityProfileOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteSecurityProfileOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListSecurityProfileGroups = clientHelper.BuildApiCall<ListSecurityProfileGroupsRequest, ListSecurityProfileGroupsResponse>("ListSecurityProfileGroups", grpcClient.ListSecurityProfileGroupsAsync, grpcClient.ListSecurityProfileGroups, effectiveSettings.ListSecurityProfileGroupsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSecurityProfileGroups);
            Modify_ListSecurityProfileGroupsApiCall(ref _callListSecurityProfileGroups);
            _callGetSecurityProfileGroup = clientHelper.BuildApiCall<GetSecurityProfileGroupRequest, SecurityProfileGroup>("GetSecurityProfileGroup", grpcClient.GetSecurityProfileGroupAsync, grpcClient.GetSecurityProfileGroup, effectiveSettings.GetSecurityProfileGroupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSecurityProfileGroup);
            Modify_GetSecurityProfileGroupApiCall(ref _callGetSecurityProfileGroup);
            _callCreateSecurityProfileGroup = clientHelper.BuildApiCall<CreateSecurityProfileGroupRequest, lro::Operation>("CreateSecurityProfileGroup", grpcClient.CreateSecurityProfileGroupAsync, grpcClient.CreateSecurityProfileGroup, effectiveSettings.CreateSecurityProfileGroupSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSecurityProfileGroup);
            Modify_CreateSecurityProfileGroupApiCall(ref _callCreateSecurityProfileGroup);
            _callUpdateSecurityProfileGroup = clientHelper.BuildApiCall<UpdateSecurityProfileGroupRequest, lro::Operation>("UpdateSecurityProfileGroup", grpcClient.UpdateSecurityProfileGroupAsync, grpcClient.UpdateSecurityProfileGroup, effectiveSettings.UpdateSecurityProfileGroupSettings).WithGoogleRequestParam("security_profile_group.name", request => request.SecurityProfileGroup?.Name);
            Modify_ApiCall(ref _callUpdateSecurityProfileGroup);
            Modify_UpdateSecurityProfileGroupApiCall(ref _callUpdateSecurityProfileGroup);
            _callDeleteSecurityProfileGroup = clientHelper.BuildApiCall<DeleteSecurityProfileGroupRequest, lro::Operation>("DeleteSecurityProfileGroup", grpcClient.DeleteSecurityProfileGroupAsync, grpcClient.DeleteSecurityProfileGroup, effectiveSettings.DeleteSecurityProfileGroupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSecurityProfileGroup);
            Modify_DeleteSecurityProfileGroupApiCall(ref _callDeleteSecurityProfileGroup);
            _callListSecurityProfiles = clientHelper.BuildApiCall<ListSecurityProfilesRequest, ListSecurityProfilesResponse>("ListSecurityProfiles", grpcClient.ListSecurityProfilesAsync, grpcClient.ListSecurityProfiles, effectiveSettings.ListSecurityProfilesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSecurityProfiles);
            Modify_ListSecurityProfilesApiCall(ref _callListSecurityProfiles);
            _callGetSecurityProfile = clientHelper.BuildApiCall<GetSecurityProfileRequest, SecurityProfile>("GetSecurityProfile", grpcClient.GetSecurityProfileAsync, grpcClient.GetSecurityProfile, effectiveSettings.GetSecurityProfileSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSecurityProfile);
            Modify_GetSecurityProfileApiCall(ref _callGetSecurityProfile);
            _callCreateSecurityProfile = clientHelper.BuildApiCall<CreateSecurityProfileRequest, lro::Operation>("CreateSecurityProfile", grpcClient.CreateSecurityProfileAsync, grpcClient.CreateSecurityProfile, effectiveSettings.CreateSecurityProfileSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSecurityProfile);
            Modify_CreateSecurityProfileApiCall(ref _callCreateSecurityProfile);
            _callUpdateSecurityProfile = clientHelper.BuildApiCall<UpdateSecurityProfileRequest, lro::Operation>("UpdateSecurityProfile", grpcClient.UpdateSecurityProfileAsync, grpcClient.UpdateSecurityProfile, effectiveSettings.UpdateSecurityProfileSettings).WithGoogleRequestParam("security_profile.name", request => request.SecurityProfile?.Name);
            Modify_ApiCall(ref _callUpdateSecurityProfile);
            Modify_UpdateSecurityProfileApiCall(ref _callUpdateSecurityProfile);
            _callDeleteSecurityProfile = clientHelper.BuildApiCall<DeleteSecurityProfileRequest, lro::Operation>("DeleteSecurityProfile", grpcClient.DeleteSecurityProfileAsync, grpcClient.DeleteSecurityProfile, effectiveSettings.DeleteSecurityProfileSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSecurityProfile);
            Modify_DeleteSecurityProfileApiCall(ref _callDeleteSecurityProfile);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListSecurityProfileGroupsApiCall(ref gaxgrpc::ApiCall<ListSecurityProfileGroupsRequest, ListSecurityProfileGroupsResponse> call);

        partial void Modify_GetSecurityProfileGroupApiCall(ref gaxgrpc::ApiCall<GetSecurityProfileGroupRequest, SecurityProfileGroup> call);

        partial void Modify_CreateSecurityProfileGroupApiCall(ref gaxgrpc::ApiCall<CreateSecurityProfileGroupRequest, lro::Operation> call);

        partial void Modify_UpdateSecurityProfileGroupApiCall(ref gaxgrpc::ApiCall<UpdateSecurityProfileGroupRequest, lro::Operation> call);

        partial void Modify_DeleteSecurityProfileGroupApiCall(ref gaxgrpc::ApiCall<DeleteSecurityProfileGroupRequest, lro::Operation> call);

        partial void Modify_ListSecurityProfilesApiCall(ref gaxgrpc::ApiCall<ListSecurityProfilesRequest, ListSecurityProfilesResponse> call);

        partial void Modify_GetSecurityProfileApiCall(ref gaxgrpc::ApiCall<GetSecurityProfileRequest, SecurityProfile> call);

        partial void Modify_CreateSecurityProfileApiCall(ref gaxgrpc::ApiCall<CreateSecurityProfileRequest, lro::Operation> call);

        partial void Modify_UpdateSecurityProfileApiCall(ref gaxgrpc::ApiCall<UpdateSecurityProfileRequest, lro::Operation> call);

        partial void Modify_DeleteSecurityProfileApiCall(ref gaxgrpc::ApiCall<DeleteSecurityProfileRequest, lro::Operation> call);

        partial void OnConstruction(OrganizationSecurityProfileGroupService.OrganizationSecurityProfileGroupServiceClient grpcClient, OrganizationSecurityProfileGroupServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC OrganizationSecurityProfileGroupService client</summary>
        public override OrganizationSecurityProfileGroupService.OrganizationSecurityProfileGroupServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListSecurityProfileGroupsRequest(ref ListSecurityProfileGroupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSecurityProfileGroupRequest(ref GetSecurityProfileGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSecurityProfileGroupRequest(ref CreateSecurityProfileGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSecurityProfileGroupRequest(ref UpdateSecurityProfileGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSecurityProfileGroupRequest(ref DeleteSecurityProfileGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSecurityProfilesRequest(ref ListSecurityProfilesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSecurityProfileRequest(ref GetSecurityProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSecurityProfileRequest(ref CreateSecurityProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSecurityProfileRequest(ref UpdateSecurityProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSecurityProfileRequest(ref DeleteSecurityProfileRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists SecurityProfileGroups in a given organization and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SecurityProfileGroup"/> resources.</returns>
        public override gax::PagedEnumerable<ListSecurityProfileGroupsResponse, SecurityProfileGroup> ListSecurityProfileGroups(ListSecurityProfileGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSecurityProfileGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSecurityProfileGroupsRequest, ListSecurityProfileGroupsResponse, SecurityProfileGroup>(_callListSecurityProfileGroups, request, callSettings);
        }

        /// <summary>
        /// Lists SecurityProfileGroups in a given organization and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SecurityProfileGroup"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSecurityProfileGroupsResponse, SecurityProfileGroup> ListSecurityProfileGroupsAsync(ListSecurityProfileGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSecurityProfileGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSecurityProfileGroupsRequest, ListSecurityProfileGroupsResponse, SecurityProfileGroup>(_callListSecurityProfileGroups, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single SecurityProfileGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SecurityProfileGroup GetSecurityProfileGroup(GetSecurityProfileGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSecurityProfileGroupRequest(ref request, ref callSettings);
            return _callGetSecurityProfileGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single SecurityProfileGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SecurityProfileGroup> GetSecurityProfileGroupAsync(GetSecurityProfileGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSecurityProfileGroupRequest(ref request, ref callSettings);
            return _callGetSecurityProfileGroup.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateSecurityProfileGroup</c>.</summary>
        public override lro::OperationsClient CreateSecurityProfileGroupOperationsClient { get; }

        /// <summary>
        /// Creates a new SecurityProfileGroup in a given organization and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<SecurityProfileGroup, OperationMetadata> CreateSecurityProfileGroup(CreateSecurityProfileGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSecurityProfileGroupRequest(ref request, ref callSettings);
            return new lro::Operation<SecurityProfileGroup, OperationMetadata>(_callCreateSecurityProfileGroup.Sync(request, callSettings), CreateSecurityProfileGroupOperationsClient);
        }

        /// <summary>
        /// Creates a new SecurityProfileGroup in a given organization and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<SecurityProfileGroup, OperationMetadata>> CreateSecurityProfileGroupAsync(CreateSecurityProfileGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSecurityProfileGroupRequest(ref request, ref callSettings);
            return new lro::Operation<SecurityProfileGroup, OperationMetadata>(await _callCreateSecurityProfileGroup.Async(request, callSettings).ConfigureAwait(false), CreateSecurityProfileGroupOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateSecurityProfileGroup</c>.</summary>
        public override lro::OperationsClient UpdateSecurityProfileGroupOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single SecurityProfileGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<SecurityProfileGroup, OperationMetadata> UpdateSecurityProfileGroup(UpdateSecurityProfileGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSecurityProfileGroupRequest(ref request, ref callSettings);
            return new lro::Operation<SecurityProfileGroup, OperationMetadata>(_callUpdateSecurityProfileGroup.Sync(request, callSettings), UpdateSecurityProfileGroupOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single SecurityProfileGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<SecurityProfileGroup, OperationMetadata>> UpdateSecurityProfileGroupAsync(UpdateSecurityProfileGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSecurityProfileGroupRequest(ref request, ref callSettings);
            return new lro::Operation<SecurityProfileGroup, OperationMetadata>(await _callUpdateSecurityProfileGroup.Async(request, callSettings).ConfigureAwait(false), UpdateSecurityProfileGroupOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteSecurityProfileGroup</c>.</summary>
        public override lro::OperationsClient DeleteSecurityProfileGroupOperationsClient { get; }

        /// <summary>
        /// Deletes a single SecurityProfileGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteSecurityProfileGroup(DeleteSecurityProfileGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSecurityProfileGroupRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteSecurityProfileGroup.Sync(request, callSettings), DeleteSecurityProfileGroupOperationsClient);
        }

        /// <summary>
        /// Deletes a single SecurityProfileGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSecurityProfileGroupAsync(DeleteSecurityProfileGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSecurityProfileGroupRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteSecurityProfileGroup.Async(request, callSettings).ConfigureAwait(false), DeleteSecurityProfileGroupOperationsClient);
        }

        /// <summary>
        /// Lists SecurityProfiles in a given organization and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SecurityProfile"/> resources.</returns>
        public override gax::PagedEnumerable<ListSecurityProfilesResponse, SecurityProfile> ListSecurityProfiles(ListSecurityProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSecurityProfilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSecurityProfilesRequest, ListSecurityProfilesResponse, SecurityProfile>(_callListSecurityProfiles, request, callSettings);
        }

        /// <summary>
        /// Lists SecurityProfiles in a given organization and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SecurityProfile"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSecurityProfilesResponse, SecurityProfile> ListSecurityProfilesAsync(ListSecurityProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSecurityProfilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSecurityProfilesRequest, ListSecurityProfilesResponse, SecurityProfile>(_callListSecurityProfiles, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single SecurityProfile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SecurityProfile GetSecurityProfile(GetSecurityProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSecurityProfileRequest(ref request, ref callSettings);
            return _callGetSecurityProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single SecurityProfile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SecurityProfile> GetSecurityProfileAsync(GetSecurityProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSecurityProfileRequest(ref request, ref callSettings);
            return _callGetSecurityProfile.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateSecurityProfile</c>.</summary>
        public override lro::OperationsClient CreateSecurityProfileOperationsClient { get; }

        /// <summary>
        /// Creates a new SecurityProfile in a given organization and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<SecurityProfile, OperationMetadata> CreateSecurityProfile(CreateSecurityProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSecurityProfileRequest(ref request, ref callSettings);
            return new lro::Operation<SecurityProfile, OperationMetadata>(_callCreateSecurityProfile.Sync(request, callSettings), CreateSecurityProfileOperationsClient);
        }

        /// <summary>
        /// Creates a new SecurityProfile in a given organization and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<SecurityProfile, OperationMetadata>> CreateSecurityProfileAsync(CreateSecurityProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSecurityProfileRequest(ref request, ref callSettings);
            return new lro::Operation<SecurityProfile, OperationMetadata>(await _callCreateSecurityProfile.Async(request, callSettings).ConfigureAwait(false), CreateSecurityProfileOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateSecurityProfile</c>.</summary>
        public override lro::OperationsClient UpdateSecurityProfileOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single SecurityProfile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<SecurityProfile, OperationMetadata> UpdateSecurityProfile(UpdateSecurityProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSecurityProfileRequest(ref request, ref callSettings);
            return new lro::Operation<SecurityProfile, OperationMetadata>(_callUpdateSecurityProfile.Sync(request, callSettings), UpdateSecurityProfileOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single SecurityProfile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<SecurityProfile, OperationMetadata>> UpdateSecurityProfileAsync(UpdateSecurityProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSecurityProfileRequest(ref request, ref callSettings);
            return new lro::Operation<SecurityProfile, OperationMetadata>(await _callUpdateSecurityProfile.Async(request, callSettings).ConfigureAwait(false), UpdateSecurityProfileOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteSecurityProfile</c>.</summary>
        public override lro::OperationsClient DeleteSecurityProfileOperationsClient { get; }

        /// <summary>
        /// Deletes a single SecurityProfile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteSecurityProfile(DeleteSecurityProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSecurityProfileRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteSecurityProfile.Sync(request, callSettings), DeleteSecurityProfileOperationsClient);
        }

        /// <summary>
        /// Deletes a single SecurityProfile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSecurityProfileAsync(DeleteSecurityProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSecurityProfileRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteSecurityProfile.Async(request, callSettings).ConfigureAwait(false), DeleteSecurityProfileOperationsClient);
        }
    }

    public partial class ListSecurityProfileGroupsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSecurityProfilesRequest : gaxgrpc::IPageRequest
    {
    }

    public static partial class OrganizationSecurityProfileGroupService
    {
        public partial class OrganizationSecurityProfileGroupServiceClient
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

    public static partial class OrganizationSecurityProfileGroupService
    {
        public partial class OrganizationSecurityProfileGroupServiceClient
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
