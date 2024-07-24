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

namespace Google.Cloud.PrivilegedAccessManager.V1
{
    /// <summary>Settings for <see cref="PrivilegedAccessManagerClient"/> instances.</summary>
    public sealed partial class PrivilegedAccessManagerSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PrivilegedAccessManagerSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PrivilegedAccessManagerSettings"/>.</returns>
        public static PrivilegedAccessManagerSettings GetDefault() => new PrivilegedAccessManagerSettings();

        /// <summary>
        /// Constructs a new <see cref="PrivilegedAccessManagerSettings"/> object with default settings.
        /// </summary>
        public PrivilegedAccessManagerSettings()
        {
        }

        private PrivilegedAccessManagerSettings(PrivilegedAccessManagerSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CheckOnboardingStatusSettings = existing.CheckOnboardingStatusSettings;
            ListEntitlementsSettings = existing.ListEntitlementsSettings;
            SearchEntitlementsSettings = existing.SearchEntitlementsSettings;
            GetEntitlementSettings = existing.GetEntitlementSettings;
            CreateEntitlementSettings = existing.CreateEntitlementSettings;
            CreateEntitlementOperationsSettings = existing.CreateEntitlementOperationsSettings.Clone();
            DeleteEntitlementSettings = existing.DeleteEntitlementSettings;
            DeleteEntitlementOperationsSettings = existing.DeleteEntitlementOperationsSettings.Clone();
            UpdateEntitlementSettings = existing.UpdateEntitlementSettings;
            UpdateEntitlementOperationsSettings = existing.UpdateEntitlementOperationsSettings.Clone();
            ListGrantsSettings = existing.ListGrantsSettings;
            SearchGrantsSettings = existing.SearchGrantsSettings;
            GetGrantSettings = existing.GetGrantSettings;
            CreateGrantSettings = existing.CreateGrantSettings;
            ApproveGrantSettings = existing.ApproveGrantSettings;
            DenyGrantSettings = existing.DenyGrantSettings;
            RevokeGrantSettings = existing.RevokeGrantSettings;
            RevokeGrantOperationsSettings = existing.RevokeGrantOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(PrivilegedAccessManagerSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PrivilegedAccessManagerClient.CheckOnboardingStatus</c> and
        /// <c>PrivilegedAccessManagerClient.CheckOnboardingStatusAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CheckOnboardingStatusSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PrivilegedAccessManagerClient.ListEntitlements</c> and
        /// <c>PrivilegedAccessManagerClient.ListEntitlementsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEntitlementsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PrivilegedAccessManagerClient.SearchEntitlements</c> and
        /// <c>PrivilegedAccessManagerClient.SearchEntitlementsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchEntitlementsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PrivilegedAccessManagerClient.GetEntitlement</c> and <c>PrivilegedAccessManagerClient.GetEntitlementAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEntitlementSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PrivilegedAccessManagerClient.CreateEntitlement</c> and
        /// <c>PrivilegedAccessManagerClient.CreateEntitlementAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateEntitlementSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>PrivilegedAccessManagerClient.CreateEntitlement</c> and
        /// <c>PrivilegedAccessManagerClient.CreateEntitlementAsync</c>.
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
        public lro::OperationsSettings CreateEntitlementOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PrivilegedAccessManagerClient.DeleteEntitlement</c> and
        /// <c>PrivilegedAccessManagerClient.DeleteEntitlementAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteEntitlementSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>PrivilegedAccessManagerClient.DeleteEntitlement</c> and
        /// <c>PrivilegedAccessManagerClient.DeleteEntitlementAsync</c>.
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
        public lro::OperationsSettings DeleteEntitlementOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PrivilegedAccessManagerClient.UpdateEntitlement</c> and
        /// <c>PrivilegedAccessManagerClient.UpdateEntitlementAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateEntitlementSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>PrivilegedAccessManagerClient.UpdateEntitlement</c> and
        /// <c>PrivilegedAccessManagerClient.UpdateEntitlementAsync</c>.
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
        public lro::OperationsSettings UpdateEntitlementOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PrivilegedAccessManagerClient.ListGrants</c> and <c>PrivilegedAccessManagerClient.ListGrantsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListGrantsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PrivilegedAccessManagerClient.SearchGrants</c> and <c>PrivilegedAccessManagerClient.SearchGrantsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchGrantsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PrivilegedAccessManagerClient.GetGrant</c> and <c>PrivilegedAccessManagerClient.GetGrantAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetGrantSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PrivilegedAccessManagerClient.CreateGrant</c> and <c>PrivilegedAccessManagerClient.CreateGrantAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateGrantSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PrivilegedAccessManagerClient.ApproveGrant</c> and <c>PrivilegedAccessManagerClient.ApproveGrantAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ApproveGrantSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PrivilegedAccessManagerClient.DenyGrant</c> and <c>PrivilegedAccessManagerClient.DenyGrantAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DenyGrantSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PrivilegedAccessManagerClient.RevokeGrant</c> and <c>PrivilegedAccessManagerClient.RevokeGrantAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RevokeGrantSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>PrivilegedAccessManagerClient.RevokeGrant</c> and
        /// <c>PrivilegedAccessManagerClient.RevokeGrantAsync</c>.
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
        public lro::OperationsSettings RevokeGrantOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PrivilegedAccessManagerSettings"/> object.</returns>
        public PrivilegedAccessManagerSettings Clone() => new PrivilegedAccessManagerSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PrivilegedAccessManagerClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class PrivilegedAccessManagerClientBuilder : gaxgrpc::ClientBuilderBase<PrivilegedAccessManagerClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PrivilegedAccessManagerSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public PrivilegedAccessManagerClientBuilder() : base(PrivilegedAccessManagerClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref PrivilegedAccessManagerClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PrivilegedAccessManagerClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PrivilegedAccessManagerClient Build()
        {
            PrivilegedAccessManagerClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PrivilegedAccessManagerClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PrivilegedAccessManagerClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PrivilegedAccessManagerClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PrivilegedAccessManagerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<PrivilegedAccessManagerClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PrivilegedAccessManagerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PrivilegedAccessManagerClient.ChannelPool;
    }

    /// <summary>PrivilegedAccessManager client wrapper, for convenient use.</summary>
    /// <remarks>
    /// This API allows customers to manage temporary, request based privileged
    /// access to their resources.
    /// 
    /// It defines the following resource model:
    /// 
    /// * A collection of `Entitlement` resources. An entitlement allows configuring
    /// (among other things):
    /// 
    /// * Some kind of privileged access that users can request.
    /// * A set of users called _requesters_ who can request this access.
    /// * A maximum duration for which the access can be requested.
    /// * An optional approval workflow which must be satisfied before access is
    /// granted.
    /// 
    /// * A collection of `Grant` resources. A grant is a request by a requester to
    /// get the privileged access specified in an entitlement for some duration.
    /// 
    /// After the approval workflow as specified in the entitlement is satisfied,
    /// the specified access is given to the requester. The access is automatically
    /// taken back after the requested duration is over.
    /// </remarks>
    public abstract partial class PrivilegedAccessManagerClient
    {
        /// <summary>
        /// The default endpoint for the PrivilegedAccessManager service, which is a host of
        /// "privilegedaccessmanager.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "privilegedaccessmanager.googleapis.com:443";

        /// <summary>The default PrivilegedAccessManager scopes.</summary>
        /// <remarks>
        /// The default PrivilegedAccessManager scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(PrivilegedAccessManager.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="PrivilegedAccessManagerClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="PrivilegedAccessManagerClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PrivilegedAccessManagerClient"/>.</returns>
        public static stt::Task<PrivilegedAccessManagerClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PrivilegedAccessManagerClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PrivilegedAccessManagerClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="PrivilegedAccessManagerClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PrivilegedAccessManagerClient"/>.</returns>
        public static PrivilegedAccessManagerClient Create() => new PrivilegedAccessManagerClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PrivilegedAccessManagerClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PrivilegedAccessManagerSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="PrivilegedAccessManagerClient"/>.</returns>
        internal static PrivilegedAccessManagerClient Create(grpccore::CallInvoker callInvoker, PrivilegedAccessManagerSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            PrivilegedAccessManager.PrivilegedAccessManagerClient grpcClient = new PrivilegedAccessManager.PrivilegedAccessManagerClient(callInvoker);
            return new PrivilegedAccessManagerClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC PrivilegedAccessManager client</summary>
        public virtual PrivilegedAccessManager.PrivilegedAccessManagerClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// CheckOnboardingStatus reports the onboarding status for a
        /// project/folder/organization. Any findings reported by this API need to be
        /// fixed before PAM can be used on the resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CheckOnboardingStatusResponse CheckOnboardingStatus(CheckOnboardingStatusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// CheckOnboardingStatus reports the onboarding status for a
        /// project/folder/organization. Any findings reported by this API need to be
        /// fixed before PAM can be used on the resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckOnboardingStatusResponse> CheckOnboardingStatusAsync(CheckOnboardingStatusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// CheckOnboardingStatus reports the onboarding status for a
        /// project/folder/organization. Any findings reported by this API need to be
        /// fixed before PAM can be used on the resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckOnboardingStatusResponse> CheckOnboardingStatusAsync(CheckOnboardingStatusRequest request, st::CancellationToken cancellationToken) =>
            CheckOnboardingStatusAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists entitlements in a given project/folder/organization and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Entitlement"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntitlementsResponse, Entitlement> ListEntitlements(ListEntitlementsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists entitlements in a given project/folder/organization and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Entitlement"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntitlementsResponse, Entitlement> ListEntitlementsAsync(ListEntitlementsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists entitlements in a given project/folder/organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns the entitlement resources.
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
        /// <returns>A pageable sequence of <see cref="Entitlement"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntitlementsResponse, Entitlement> ListEntitlements(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntitlementsRequest request = new ListEntitlementsRequest
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
            return ListEntitlements(request, callSettings);
        }

        /// <summary>
        /// Lists entitlements in a given project/folder/organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns the entitlement resources.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Entitlement"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntitlementsResponse, Entitlement> ListEntitlementsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntitlementsRequest request = new ListEntitlementsRequest
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
            return ListEntitlementsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists entitlements in a given project/folder/organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns the entitlement resources.
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
        /// <returns>A pageable sequence of <see cref="Entitlement"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntitlementsResponse, Entitlement> ListEntitlements(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntitlementsRequest request = new ListEntitlementsRequest
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
            return ListEntitlements(request, callSettings);
        }

        /// <summary>
        /// Lists entitlements in a given project/folder/organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns the entitlement resources.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Entitlement"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntitlementsResponse, Entitlement> ListEntitlementsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntitlementsRequest request = new ListEntitlementsRequest
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
            return ListEntitlementsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists entitlements in a given project/folder/organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns the entitlement resources.
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
        /// <returns>A pageable sequence of <see cref="Entitlement"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntitlementsResponse, Entitlement> ListEntitlements(FolderLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntitlementsRequest request = new ListEntitlementsRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEntitlements(request, callSettings);
        }

        /// <summary>
        /// Lists entitlements in a given project/folder/organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns the entitlement resources.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Entitlement"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntitlementsResponse, Entitlement> ListEntitlementsAsync(FolderLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntitlementsRequest request = new ListEntitlementsRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEntitlementsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists entitlements in a given project/folder/organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns the entitlement resources.
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
        /// <returns>A pageable sequence of <see cref="Entitlement"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntitlementsResponse, Entitlement> ListEntitlements(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntitlementsRequest request = new ListEntitlementsRequest
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
            return ListEntitlements(request, callSettings);
        }

        /// <summary>
        /// Lists entitlements in a given project/folder/organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent which owns the entitlement resources.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Entitlement"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntitlementsResponse, Entitlement> ListEntitlementsAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntitlementsRequest request = new ListEntitlementsRequest
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
            return ListEntitlementsAsync(request, callSettings);
        }

        /// <summary>
        /// `SearchEntitlements` returns entitlements on which the caller has the
        /// specified access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Entitlement"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchEntitlementsResponse, Entitlement> SearchEntitlements(SearchEntitlementsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// `SearchEntitlements` returns entitlements on which the caller has the
        /// specified access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Entitlement"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchEntitlementsResponse, Entitlement> SearchEntitlementsAsync(SearchEntitlementsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single entitlement.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Entitlement GetEntitlement(GetEntitlementRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single entitlement.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entitlement> GetEntitlementAsync(GetEntitlementRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single entitlement.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entitlement> GetEntitlementAsync(GetEntitlementRequest request, st::CancellationToken cancellationToken) =>
            GetEntitlementAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single entitlement.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Entitlement GetEntitlement(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntitlement(new GetEntitlementRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single entitlement.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entitlement> GetEntitlementAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntitlementAsync(new GetEntitlementRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single entitlement.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entitlement> GetEntitlementAsync(string name, st::CancellationToken cancellationToken) =>
            GetEntitlementAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single entitlement.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Entitlement GetEntitlement(EntitlementName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntitlement(new GetEntitlementRequest
            {
                EntitlementName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single entitlement.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entitlement> GetEntitlementAsync(EntitlementName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntitlementAsync(new GetEntitlementRequest
            {
                EntitlementName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single entitlement.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entitlement> GetEntitlementAsync(EntitlementName name, st::CancellationToken cancellationToken) =>
            GetEntitlementAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new entitlement in a given project/folder/organization and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Entitlement, OperationMetadata> CreateEntitlement(CreateEntitlementRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new entitlement in a given project/folder/organization and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> CreateEntitlementAsync(CreateEntitlementRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new entitlement in a given project/folder/organization and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> CreateEntitlementAsync(CreateEntitlementRequest request, st::CancellationToken cancellationToken) =>
            CreateEntitlementAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateEntitlement</c>.</summary>
        public virtual lro::OperationsClient CreateEntitlementOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateEntitlement</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Entitlement, OperationMetadata> PollOnceCreateEntitlement(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Entitlement, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEntitlementOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateEntitlement</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> PollOnceCreateEntitlementAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Entitlement, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEntitlementOperationsClient, callSettings);

        /// <summary>
        /// Creates a new entitlement in a given project/folder/organization and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent resource for the entitlement.
        /// Possible formats:
        /// 
        /// * `organizations/{organization-number}/locations/{region}`
        /// * `folders/{folder-number}/locations/{region}`
        /// * `projects/{project-id|project-number}/locations/{region}`
        /// </param>
        /// <param name="entitlement">
        /// Required. The resource being created
        /// </param>
        /// <param name="entitlementId">
        /// Required. The ID to use for this entitlement. This becomes the last part of
        /// the resource name.
        /// 
        /// This value should be 4-63 characters in length, and valid characters are
        /// "[a-z]", "[0-9]", and "-". The first character should be from [a-z].
        /// 
        /// This value should be unique among all other entitlements under the
        /// specified `parent`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Entitlement, OperationMetadata> CreateEntitlement(string parent, Entitlement entitlement, string entitlementId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntitlement(new CreateEntitlementRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EntitlementId = gax::GaxPreconditions.CheckNotNullOrEmpty(entitlementId, nameof(entitlementId)),
                Entitlement = gax::GaxPreconditions.CheckNotNull(entitlement, nameof(entitlement)),
            }, callSettings);

        /// <summary>
        /// Creates a new entitlement in a given project/folder/organization and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent resource for the entitlement.
        /// Possible formats:
        /// 
        /// * `organizations/{organization-number}/locations/{region}`
        /// * `folders/{folder-number}/locations/{region}`
        /// * `projects/{project-id|project-number}/locations/{region}`
        /// </param>
        /// <param name="entitlement">
        /// Required. The resource being created
        /// </param>
        /// <param name="entitlementId">
        /// Required. The ID to use for this entitlement. This becomes the last part of
        /// the resource name.
        /// 
        /// This value should be 4-63 characters in length, and valid characters are
        /// "[a-z]", "[0-9]", and "-". The first character should be from [a-z].
        /// 
        /// This value should be unique among all other entitlements under the
        /// specified `parent`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> CreateEntitlementAsync(string parent, Entitlement entitlement, string entitlementId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntitlementAsync(new CreateEntitlementRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EntitlementId = gax::GaxPreconditions.CheckNotNullOrEmpty(entitlementId, nameof(entitlementId)),
                Entitlement = gax::GaxPreconditions.CheckNotNull(entitlement, nameof(entitlement)),
            }, callSettings);

        /// <summary>
        /// Creates a new entitlement in a given project/folder/organization and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent resource for the entitlement.
        /// Possible formats:
        /// 
        /// * `organizations/{organization-number}/locations/{region}`
        /// * `folders/{folder-number}/locations/{region}`
        /// * `projects/{project-id|project-number}/locations/{region}`
        /// </param>
        /// <param name="entitlement">
        /// Required. The resource being created
        /// </param>
        /// <param name="entitlementId">
        /// Required. The ID to use for this entitlement. This becomes the last part of
        /// the resource name.
        /// 
        /// This value should be 4-63 characters in length, and valid characters are
        /// "[a-z]", "[0-9]", and "-". The first character should be from [a-z].
        /// 
        /// This value should be unique among all other entitlements under the
        /// specified `parent`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> CreateEntitlementAsync(string parent, Entitlement entitlement, string entitlementId, st::CancellationToken cancellationToken) =>
            CreateEntitlementAsync(parent, entitlement, entitlementId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new entitlement in a given project/folder/organization and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent resource for the entitlement.
        /// Possible formats:
        /// 
        /// * `organizations/{organization-number}/locations/{region}`
        /// * `folders/{folder-number}/locations/{region}`
        /// * `projects/{project-id|project-number}/locations/{region}`
        /// </param>
        /// <param name="entitlement">
        /// Required. The resource being created
        /// </param>
        /// <param name="entitlementId">
        /// Required. The ID to use for this entitlement. This becomes the last part of
        /// the resource name.
        /// 
        /// This value should be 4-63 characters in length, and valid characters are
        /// "[a-z]", "[0-9]", and "-". The first character should be from [a-z].
        /// 
        /// This value should be unique among all other entitlements under the
        /// specified `parent`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Entitlement, OperationMetadata> CreateEntitlement(gagr::LocationName parent, Entitlement entitlement, string entitlementId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntitlement(new CreateEntitlementRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EntitlementId = gax::GaxPreconditions.CheckNotNullOrEmpty(entitlementId, nameof(entitlementId)),
                Entitlement = gax::GaxPreconditions.CheckNotNull(entitlement, nameof(entitlement)),
            }, callSettings);

        /// <summary>
        /// Creates a new entitlement in a given project/folder/organization and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent resource for the entitlement.
        /// Possible formats:
        /// 
        /// * `organizations/{organization-number}/locations/{region}`
        /// * `folders/{folder-number}/locations/{region}`
        /// * `projects/{project-id|project-number}/locations/{region}`
        /// </param>
        /// <param name="entitlement">
        /// Required. The resource being created
        /// </param>
        /// <param name="entitlementId">
        /// Required. The ID to use for this entitlement. This becomes the last part of
        /// the resource name.
        /// 
        /// This value should be 4-63 characters in length, and valid characters are
        /// "[a-z]", "[0-9]", and "-". The first character should be from [a-z].
        /// 
        /// This value should be unique among all other entitlements under the
        /// specified `parent`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> CreateEntitlementAsync(gagr::LocationName parent, Entitlement entitlement, string entitlementId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntitlementAsync(new CreateEntitlementRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EntitlementId = gax::GaxPreconditions.CheckNotNullOrEmpty(entitlementId, nameof(entitlementId)),
                Entitlement = gax::GaxPreconditions.CheckNotNull(entitlement, nameof(entitlement)),
            }, callSettings);

        /// <summary>
        /// Creates a new entitlement in a given project/folder/organization and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent resource for the entitlement.
        /// Possible formats:
        /// 
        /// * `organizations/{organization-number}/locations/{region}`
        /// * `folders/{folder-number}/locations/{region}`
        /// * `projects/{project-id|project-number}/locations/{region}`
        /// </param>
        /// <param name="entitlement">
        /// Required. The resource being created
        /// </param>
        /// <param name="entitlementId">
        /// Required. The ID to use for this entitlement. This becomes the last part of
        /// the resource name.
        /// 
        /// This value should be 4-63 characters in length, and valid characters are
        /// "[a-z]", "[0-9]", and "-". The first character should be from [a-z].
        /// 
        /// This value should be unique among all other entitlements under the
        /// specified `parent`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> CreateEntitlementAsync(gagr::LocationName parent, Entitlement entitlement, string entitlementId, st::CancellationToken cancellationToken) =>
            CreateEntitlementAsync(parent, entitlement, entitlementId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new entitlement in a given project/folder/organization and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent resource for the entitlement.
        /// Possible formats:
        /// 
        /// * `organizations/{organization-number}/locations/{region}`
        /// * `folders/{folder-number}/locations/{region}`
        /// * `projects/{project-id|project-number}/locations/{region}`
        /// </param>
        /// <param name="entitlement">
        /// Required. The resource being created
        /// </param>
        /// <param name="entitlementId">
        /// Required. The ID to use for this entitlement. This becomes the last part of
        /// the resource name.
        /// 
        /// This value should be 4-63 characters in length, and valid characters are
        /// "[a-z]", "[0-9]", and "-". The first character should be from [a-z].
        /// 
        /// This value should be unique among all other entitlements under the
        /// specified `parent`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Entitlement, OperationMetadata> CreateEntitlement(FolderLocationName parent, Entitlement entitlement, string entitlementId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntitlement(new CreateEntitlementRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EntitlementId = gax::GaxPreconditions.CheckNotNullOrEmpty(entitlementId, nameof(entitlementId)),
                Entitlement = gax::GaxPreconditions.CheckNotNull(entitlement, nameof(entitlement)),
            }, callSettings);

        /// <summary>
        /// Creates a new entitlement in a given project/folder/organization and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent resource for the entitlement.
        /// Possible formats:
        /// 
        /// * `organizations/{organization-number}/locations/{region}`
        /// * `folders/{folder-number}/locations/{region}`
        /// * `projects/{project-id|project-number}/locations/{region}`
        /// </param>
        /// <param name="entitlement">
        /// Required. The resource being created
        /// </param>
        /// <param name="entitlementId">
        /// Required. The ID to use for this entitlement. This becomes the last part of
        /// the resource name.
        /// 
        /// This value should be 4-63 characters in length, and valid characters are
        /// "[a-z]", "[0-9]", and "-". The first character should be from [a-z].
        /// 
        /// This value should be unique among all other entitlements under the
        /// specified `parent`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> CreateEntitlementAsync(FolderLocationName parent, Entitlement entitlement, string entitlementId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntitlementAsync(new CreateEntitlementRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EntitlementId = gax::GaxPreconditions.CheckNotNullOrEmpty(entitlementId, nameof(entitlementId)),
                Entitlement = gax::GaxPreconditions.CheckNotNull(entitlement, nameof(entitlement)),
            }, callSettings);

        /// <summary>
        /// Creates a new entitlement in a given project/folder/organization and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent resource for the entitlement.
        /// Possible formats:
        /// 
        /// * `organizations/{organization-number}/locations/{region}`
        /// * `folders/{folder-number}/locations/{region}`
        /// * `projects/{project-id|project-number}/locations/{region}`
        /// </param>
        /// <param name="entitlement">
        /// Required. The resource being created
        /// </param>
        /// <param name="entitlementId">
        /// Required. The ID to use for this entitlement. This becomes the last part of
        /// the resource name.
        /// 
        /// This value should be 4-63 characters in length, and valid characters are
        /// "[a-z]", "[0-9]", and "-". The first character should be from [a-z].
        /// 
        /// This value should be unique among all other entitlements under the
        /// specified `parent`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> CreateEntitlementAsync(FolderLocationName parent, Entitlement entitlement, string entitlementId, st::CancellationToken cancellationToken) =>
            CreateEntitlementAsync(parent, entitlement, entitlementId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new entitlement in a given project/folder/organization and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent resource for the entitlement.
        /// Possible formats:
        /// 
        /// * `organizations/{organization-number}/locations/{region}`
        /// * `folders/{folder-number}/locations/{region}`
        /// * `projects/{project-id|project-number}/locations/{region}`
        /// </param>
        /// <param name="entitlement">
        /// Required. The resource being created
        /// </param>
        /// <param name="entitlementId">
        /// Required. The ID to use for this entitlement. This becomes the last part of
        /// the resource name.
        /// 
        /// This value should be 4-63 characters in length, and valid characters are
        /// "[a-z]", "[0-9]", and "-". The first character should be from [a-z].
        /// 
        /// This value should be unique among all other entitlements under the
        /// specified `parent`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Entitlement, OperationMetadata> CreateEntitlement(OrganizationLocationName parent, Entitlement entitlement, string entitlementId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntitlement(new CreateEntitlementRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EntitlementId = gax::GaxPreconditions.CheckNotNullOrEmpty(entitlementId, nameof(entitlementId)),
                Entitlement = gax::GaxPreconditions.CheckNotNull(entitlement, nameof(entitlement)),
            }, callSettings);

        /// <summary>
        /// Creates a new entitlement in a given project/folder/organization and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent resource for the entitlement.
        /// Possible formats:
        /// 
        /// * `organizations/{organization-number}/locations/{region}`
        /// * `folders/{folder-number}/locations/{region}`
        /// * `projects/{project-id|project-number}/locations/{region}`
        /// </param>
        /// <param name="entitlement">
        /// Required. The resource being created
        /// </param>
        /// <param name="entitlementId">
        /// Required. The ID to use for this entitlement. This becomes the last part of
        /// the resource name.
        /// 
        /// This value should be 4-63 characters in length, and valid characters are
        /// "[a-z]", "[0-9]", and "-". The first character should be from [a-z].
        /// 
        /// This value should be unique among all other entitlements under the
        /// specified `parent`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> CreateEntitlementAsync(OrganizationLocationName parent, Entitlement entitlement, string entitlementId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntitlementAsync(new CreateEntitlementRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EntitlementId = gax::GaxPreconditions.CheckNotNullOrEmpty(entitlementId, nameof(entitlementId)),
                Entitlement = gax::GaxPreconditions.CheckNotNull(entitlement, nameof(entitlement)),
            }, callSettings);

        /// <summary>
        /// Creates a new entitlement in a given project/folder/organization and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent resource for the entitlement.
        /// Possible formats:
        /// 
        /// * `organizations/{organization-number}/locations/{region}`
        /// * `folders/{folder-number}/locations/{region}`
        /// * `projects/{project-id|project-number}/locations/{region}`
        /// </param>
        /// <param name="entitlement">
        /// Required. The resource being created
        /// </param>
        /// <param name="entitlementId">
        /// Required. The ID to use for this entitlement. This becomes the last part of
        /// the resource name.
        /// 
        /// This value should be 4-63 characters in length, and valid characters are
        /// "[a-z]", "[0-9]", and "-". The first character should be from [a-z].
        /// 
        /// This value should be unique among all other entitlements under the
        /// specified `parent`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> CreateEntitlementAsync(OrganizationLocationName parent, Entitlement entitlement, string entitlementId, st::CancellationToken cancellationToken) =>
            CreateEntitlementAsync(parent, entitlement, entitlementId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single entitlement. This method can only be called when there
        /// are no in-progress (ACTIVE/ACTIVATING/REVOKING) grants under the
        /// entitlement.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Entitlement, OperationMetadata> DeleteEntitlement(DeleteEntitlementRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single entitlement. This method can only be called when there
        /// are no in-progress (ACTIVE/ACTIVATING/REVOKING) grants under the
        /// entitlement.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> DeleteEntitlementAsync(DeleteEntitlementRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single entitlement. This method can only be called when there
        /// are no in-progress (ACTIVE/ACTIVATING/REVOKING) grants under the
        /// entitlement.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> DeleteEntitlementAsync(DeleteEntitlementRequest request, st::CancellationToken cancellationToken) =>
            DeleteEntitlementAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteEntitlement</c>.</summary>
        public virtual lro::OperationsClient DeleteEntitlementOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteEntitlement</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Entitlement, OperationMetadata> PollOnceDeleteEntitlement(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Entitlement, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteEntitlementOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteEntitlement</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> PollOnceDeleteEntitlementAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Entitlement, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteEntitlementOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single entitlement. This method can only be called when there
        /// are no in-progress (ACTIVE/ACTIVATING/REVOKING) grants under the
        /// entitlement.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Entitlement, OperationMetadata> DeleteEntitlement(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntitlement(new DeleteEntitlementRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single entitlement. This method can only be called when there
        /// are no in-progress (ACTIVE/ACTIVATING/REVOKING) grants under the
        /// entitlement.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> DeleteEntitlementAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntitlementAsync(new DeleteEntitlementRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single entitlement. This method can only be called when there
        /// are no in-progress (ACTIVE/ACTIVATING/REVOKING) grants under the
        /// entitlement.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> DeleteEntitlementAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteEntitlementAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single entitlement. This method can only be called when there
        /// are no in-progress (ACTIVE/ACTIVATING/REVOKING) grants under the
        /// entitlement.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Entitlement, OperationMetadata> DeleteEntitlement(EntitlementName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntitlement(new DeleteEntitlementRequest
            {
                EntitlementName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single entitlement. This method can only be called when there
        /// are no in-progress (ACTIVE/ACTIVATING/REVOKING) grants under the
        /// entitlement.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> DeleteEntitlementAsync(EntitlementName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntitlementAsync(new DeleteEntitlementRequest
            {
                EntitlementName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single entitlement. This method can only be called when there
        /// are no in-progress (ACTIVE/ACTIVATING/REVOKING) grants under the
        /// entitlement.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> DeleteEntitlementAsync(EntitlementName name, st::CancellationToken cancellationToken) =>
            DeleteEntitlementAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the entitlement specified in the request. Updated fields in the
        /// entitlement need to be specified in an update mask. The changes made to an
        /// entitlement are applicable only on future grants of the entitlement.
        /// However, if new approvers are added or existing approvers are removed from
        /// the approval workflow, the changes are effective on existing grants.
        /// 
        /// The following fields are not supported for updates:
        /// 
        /// * All immutable fields
        /// * Entitlement name
        /// * Resource name
        /// * Resource type
        /// * Adding an approval workflow in an entitlement which previously had no
        /// approval workflow.
        /// * Deleting the approval workflow from an entitlement.
        /// * Adding or deleting a step in the approval workflow (only one step is
        /// supported)
        /// 
        /// Note that updates are allowed on the list of approvers in an approval
        /// workflow step.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Entitlement, OperationMetadata> UpdateEntitlement(UpdateEntitlementRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the entitlement specified in the request. Updated fields in the
        /// entitlement need to be specified in an update mask. The changes made to an
        /// entitlement are applicable only on future grants of the entitlement.
        /// However, if new approvers are added or existing approvers are removed from
        /// the approval workflow, the changes are effective on existing grants.
        /// 
        /// The following fields are not supported for updates:
        /// 
        /// * All immutable fields
        /// * Entitlement name
        /// * Resource name
        /// * Resource type
        /// * Adding an approval workflow in an entitlement which previously had no
        /// approval workflow.
        /// * Deleting the approval workflow from an entitlement.
        /// * Adding or deleting a step in the approval workflow (only one step is
        /// supported)
        /// 
        /// Note that updates are allowed on the list of approvers in an approval
        /// workflow step.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> UpdateEntitlementAsync(UpdateEntitlementRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the entitlement specified in the request. Updated fields in the
        /// entitlement need to be specified in an update mask. The changes made to an
        /// entitlement are applicable only on future grants of the entitlement.
        /// However, if new approvers are added or existing approvers are removed from
        /// the approval workflow, the changes are effective on existing grants.
        /// 
        /// The following fields are not supported for updates:
        /// 
        /// * All immutable fields
        /// * Entitlement name
        /// * Resource name
        /// * Resource type
        /// * Adding an approval workflow in an entitlement which previously had no
        /// approval workflow.
        /// * Deleting the approval workflow from an entitlement.
        /// * Adding or deleting a step in the approval workflow (only one step is
        /// supported)
        /// 
        /// Note that updates are allowed on the list of approvers in an approval
        /// workflow step.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> UpdateEntitlementAsync(UpdateEntitlementRequest request, st::CancellationToken cancellationToken) =>
            UpdateEntitlementAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateEntitlement</c>.</summary>
        public virtual lro::OperationsClient UpdateEntitlementOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateEntitlement</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Entitlement, OperationMetadata> PollOnceUpdateEntitlement(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Entitlement, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateEntitlementOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateEntitlement</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> PollOnceUpdateEntitlementAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Entitlement, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateEntitlementOperationsClient, callSettings);

        /// <summary>
        /// Updates the entitlement specified in the request. Updated fields in the
        /// entitlement need to be specified in an update mask. The changes made to an
        /// entitlement are applicable only on future grants of the entitlement.
        /// However, if new approvers are added or existing approvers are removed from
        /// the approval workflow, the changes are effective on existing grants.
        /// 
        /// The following fields are not supported for updates:
        /// 
        /// * All immutable fields
        /// * Entitlement name
        /// * Resource name
        /// * Resource type
        /// * Adding an approval workflow in an entitlement which previously had no
        /// approval workflow.
        /// * Deleting the approval workflow from an entitlement.
        /// * Adding or deleting a step in the approval workflow (only one step is
        /// supported)
        /// 
        /// Note that updates are allowed on the list of approvers in an approval
        /// workflow step.
        /// </summary>
        /// <param name="entitlement">
        /// Required. The entitlement resource that is updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update. A field is overwritten if, and only
        /// if, it is in the mask. Any immutable fields set in the mask are ignored by
        /// the server. Repeated fields and map fields are only allowed in the last
        /// position of a `paths` string and overwrite the existing values. Hence an
        /// update to a repeated field or a map should contain the entire list of
        /// values. The fields specified in the update_mask are relative to the
        /// resource and not to the request.
        /// (e.g. `MaxRequestDuration`; *not* `entitlement.MaxRequestDuration`)
        /// A value of '*' for this field refers to full replacement of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Entitlement, OperationMetadata> UpdateEntitlement(Entitlement entitlement, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEntitlement(new UpdateEntitlementRequest
            {
                Entitlement = gax::GaxPreconditions.CheckNotNull(entitlement, nameof(entitlement)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the entitlement specified in the request. Updated fields in the
        /// entitlement need to be specified in an update mask. The changes made to an
        /// entitlement are applicable only on future grants of the entitlement.
        /// However, if new approvers are added or existing approvers are removed from
        /// the approval workflow, the changes are effective on existing grants.
        /// 
        /// The following fields are not supported for updates:
        /// 
        /// * All immutable fields
        /// * Entitlement name
        /// * Resource name
        /// * Resource type
        /// * Adding an approval workflow in an entitlement which previously had no
        /// approval workflow.
        /// * Deleting the approval workflow from an entitlement.
        /// * Adding or deleting a step in the approval workflow (only one step is
        /// supported)
        /// 
        /// Note that updates are allowed on the list of approvers in an approval
        /// workflow step.
        /// </summary>
        /// <param name="entitlement">
        /// Required. The entitlement resource that is updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update. A field is overwritten if, and only
        /// if, it is in the mask. Any immutable fields set in the mask are ignored by
        /// the server. Repeated fields and map fields are only allowed in the last
        /// position of a `paths` string and overwrite the existing values. Hence an
        /// update to a repeated field or a map should contain the entire list of
        /// values. The fields specified in the update_mask are relative to the
        /// resource and not to the request.
        /// (e.g. `MaxRequestDuration`; *not* `entitlement.MaxRequestDuration`)
        /// A value of '*' for this field refers to full replacement of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> UpdateEntitlementAsync(Entitlement entitlement, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEntitlementAsync(new UpdateEntitlementRequest
            {
                Entitlement = gax::GaxPreconditions.CheckNotNull(entitlement, nameof(entitlement)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the entitlement specified in the request. Updated fields in the
        /// entitlement need to be specified in an update mask. The changes made to an
        /// entitlement are applicable only on future grants of the entitlement.
        /// However, if new approvers are added or existing approvers are removed from
        /// the approval workflow, the changes are effective on existing grants.
        /// 
        /// The following fields are not supported for updates:
        /// 
        /// * All immutable fields
        /// * Entitlement name
        /// * Resource name
        /// * Resource type
        /// * Adding an approval workflow in an entitlement which previously had no
        /// approval workflow.
        /// * Deleting the approval workflow from an entitlement.
        /// * Adding or deleting a step in the approval workflow (only one step is
        /// supported)
        /// 
        /// Note that updates are allowed on the list of approvers in an approval
        /// workflow step.
        /// </summary>
        /// <param name="entitlement">
        /// Required. The entitlement resource that is updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update. A field is overwritten if, and only
        /// if, it is in the mask. Any immutable fields set in the mask are ignored by
        /// the server. Repeated fields and map fields are only allowed in the last
        /// position of a `paths` string and overwrite the existing values. Hence an
        /// update to a repeated field or a map should contain the entire list of
        /// values. The fields specified in the update_mask are relative to the
        /// resource and not to the request.
        /// (e.g. `MaxRequestDuration`; *not* `entitlement.MaxRequestDuration`)
        /// A value of '*' for this field refers to full replacement of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> UpdateEntitlementAsync(Entitlement entitlement, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateEntitlementAsync(entitlement, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists grants for a given entitlement.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Grant"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGrantsResponse, Grant> ListGrants(ListGrantsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists grants for a given entitlement.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Grant"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGrantsResponse, Grant> ListGrantsAsync(ListGrantsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists grants for a given entitlement.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource which owns the grants.
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
        /// <returns>A pageable sequence of <see cref="Grant"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGrantsResponse, Grant> ListGrants(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGrantsRequest request = new ListGrantsRequest
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
            return ListGrants(request, callSettings);
        }

        /// <summary>
        /// Lists grants for a given entitlement.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource which owns the grants.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Grant"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGrantsResponse, Grant> ListGrantsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGrantsRequest request = new ListGrantsRequest
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
            return ListGrantsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists grants for a given entitlement.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource which owns the grants.
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
        /// <returns>A pageable sequence of <see cref="Grant"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGrantsResponse, Grant> ListGrants(EntitlementName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGrantsRequest request = new ListGrantsRequest
            {
                ParentAsEntitlementName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGrants(request, callSettings);
        }

        /// <summary>
        /// Lists grants for a given entitlement.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource which owns the grants.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Grant"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGrantsResponse, Grant> ListGrantsAsync(EntitlementName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGrantsRequest request = new ListGrantsRequest
            {
                ParentAsEntitlementName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGrantsAsync(request, callSettings);
        }

        /// <summary>
        /// `SearchGrants` returns grants that are related to the calling user in the
        /// specified way.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Grant"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchGrantsResponse, Grant> SearchGrants(SearchGrantsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// `SearchGrants` returns grants that are related to the calling user in the
        /// specified way.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Grant"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchGrantsResponse, Grant> SearchGrantsAsync(SearchGrantsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details of a single grant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Grant GetGrant(GetGrantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details of a single grant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Grant> GetGrantAsync(GetGrantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details of a single grant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Grant> GetGrantAsync(GetGrantRequest request, st::CancellationToken cancellationToken) =>
            GetGrantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details of a single grant.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Grant GetGrant(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGrant(new GetGrantRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a single grant.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Grant> GetGrantAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGrantAsync(new GetGrantRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a single grant.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Grant> GetGrantAsync(string name, st::CancellationToken cancellationToken) =>
            GetGrantAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details of a single grant.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Grant GetGrant(GrantName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGrant(new GetGrantRequest
            {
                GrantName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a single grant.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Grant> GetGrantAsync(GrantName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGrantAsync(new GetGrantRequest
            {
                GrantName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a single grant.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Grant> GetGrantAsync(GrantName name, st::CancellationToken cancellationToken) =>
            GetGrantAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new grant in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Grant CreateGrant(CreateGrantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new grant in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Grant> CreateGrantAsync(CreateGrantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new grant in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Grant> CreateGrantAsync(CreateGrantRequest request, st::CancellationToken cancellationToken) =>
            CreateGrantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new grant in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent entitlement for which this grant is being
        /// requested.
        /// </param>
        /// <param name="grant">
        /// Required. The resource being created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Grant CreateGrant(string parent, Grant grant, gaxgrpc::CallSettings callSettings = null) =>
            CreateGrant(new CreateGrantRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Grant = gax::GaxPreconditions.CheckNotNull(grant, nameof(grant)),
            }, callSettings);

        /// <summary>
        /// Creates a new grant in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent entitlement for which this grant is being
        /// requested.
        /// </param>
        /// <param name="grant">
        /// Required. The resource being created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Grant> CreateGrantAsync(string parent, Grant grant, gaxgrpc::CallSettings callSettings = null) =>
            CreateGrantAsync(new CreateGrantRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Grant = gax::GaxPreconditions.CheckNotNull(grant, nameof(grant)),
            }, callSettings);

        /// <summary>
        /// Creates a new grant in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent entitlement for which this grant is being
        /// requested.
        /// </param>
        /// <param name="grant">
        /// Required. The resource being created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Grant> CreateGrantAsync(string parent, Grant grant, st::CancellationToken cancellationToken) =>
            CreateGrantAsync(parent, grant, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new grant in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent entitlement for which this grant is being
        /// requested.
        /// </param>
        /// <param name="grant">
        /// Required. The resource being created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Grant CreateGrant(EntitlementName parent, Grant grant, gaxgrpc::CallSettings callSettings = null) =>
            CreateGrant(new CreateGrantRequest
            {
                ParentAsEntitlementName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Grant = gax::GaxPreconditions.CheckNotNull(grant, nameof(grant)),
            }, callSettings);

        /// <summary>
        /// Creates a new grant in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent entitlement for which this grant is being
        /// requested.
        /// </param>
        /// <param name="grant">
        /// Required. The resource being created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Grant> CreateGrantAsync(EntitlementName parent, Grant grant, gaxgrpc::CallSettings callSettings = null) =>
            CreateGrantAsync(new CreateGrantRequest
            {
                ParentAsEntitlementName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Grant = gax::GaxPreconditions.CheckNotNull(grant, nameof(grant)),
            }, callSettings);

        /// <summary>
        /// Creates a new grant in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent entitlement for which this grant is being
        /// requested.
        /// </param>
        /// <param name="grant">
        /// Required. The resource being created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Grant> CreateGrantAsync(EntitlementName parent, Grant grant, st::CancellationToken cancellationToken) =>
            CreateGrantAsync(parent, grant, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// `ApproveGrant` is used to approve a grant. This method can only be called
        /// on a grant when it's in the `APPROVAL_AWAITED` state. This operation can't
        /// be undone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Grant ApproveGrant(ApproveGrantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// `ApproveGrant` is used to approve a grant. This method can only be called
        /// on a grant when it's in the `APPROVAL_AWAITED` state. This operation can't
        /// be undone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Grant> ApproveGrantAsync(ApproveGrantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// `ApproveGrant` is used to approve a grant. This method can only be called
        /// on a grant when it's in the `APPROVAL_AWAITED` state. This operation can't
        /// be undone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Grant> ApproveGrantAsync(ApproveGrantRequest request, st::CancellationToken cancellationToken) =>
            ApproveGrantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// `DenyGrant` is used to deny a grant. This method can only be called on a
        /// grant when it's in the `APPROVAL_AWAITED` state. This operation can't be
        /// undone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Grant DenyGrant(DenyGrantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// `DenyGrant` is used to deny a grant. This method can only be called on a
        /// grant when it's in the `APPROVAL_AWAITED` state. This operation can't be
        /// undone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Grant> DenyGrantAsync(DenyGrantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// `DenyGrant` is used to deny a grant. This method can only be called on a
        /// grant when it's in the `APPROVAL_AWAITED` state. This operation can't be
        /// undone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Grant> DenyGrantAsync(DenyGrantRequest request, st::CancellationToken cancellationToken) =>
            DenyGrantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// `RevokeGrant` is used to immediately revoke access for a grant. This method
        /// can be called when the grant is in a non-terminal state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Grant, OperationMetadata> RevokeGrant(RevokeGrantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// `RevokeGrant` is used to immediately revoke access for a grant. This method
        /// can be called when the grant is in a non-terminal state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Grant, OperationMetadata>> RevokeGrantAsync(RevokeGrantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// `RevokeGrant` is used to immediately revoke access for a grant. This method
        /// can be called when the grant is in a non-terminal state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Grant, OperationMetadata>> RevokeGrantAsync(RevokeGrantRequest request, st::CancellationToken cancellationToken) =>
            RevokeGrantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RevokeGrant</c>.</summary>
        public virtual lro::OperationsClient RevokeGrantOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RevokeGrant</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Grant, OperationMetadata> PollOnceRevokeGrant(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Grant, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RevokeGrantOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RevokeGrant</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Grant, OperationMetadata>> PollOnceRevokeGrantAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Grant, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RevokeGrantOperationsClient, callSettings);
    }

    /// <summary>PrivilegedAccessManager client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// This API allows customers to manage temporary, request based privileged
    /// access to their resources.
    /// 
    /// It defines the following resource model:
    /// 
    /// * A collection of `Entitlement` resources. An entitlement allows configuring
    /// (among other things):
    /// 
    /// * Some kind of privileged access that users can request.
    /// * A set of users called _requesters_ who can request this access.
    /// * A maximum duration for which the access can be requested.
    /// * An optional approval workflow which must be satisfied before access is
    /// granted.
    /// 
    /// * A collection of `Grant` resources. A grant is a request by a requester to
    /// get the privileged access specified in an entitlement for some duration.
    /// 
    /// After the approval workflow as specified in the entitlement is satisfied,
    /// the specified access is given to the requester. The access is automatically
    /// taken back after the requested duration is over.
    /// </remarks>
    public sealed partial class PrivilegedAccessManagerClientImpl : PrivilegedAccessManagerClient
    {
        private readonly gaxgrpc::ApiCall<CheckOnboardingStatusRequest, CheckOnboardingStatusResponse> _callCheckOnboardingStatus;

        private readonly gaxgrpc::ApiCall<ListEntitlementsRequest, ListEntitlementsResponse> _callListEntitlements;

        private readonly gaxgrpc::ApiCall<SearchEntitlementsRequest, SearchEntitlementsResponse> _callSearchEntitlements;

        private readonly gaxgrpc::ApiCall<GetEntitlementRequest, Entitlement> _callGetEntitlement;

        private readonly gaxgrpc::ApiCall<CreateEntitlementRequest, lro::Operation> _callCreateEntitlement;

        private readonly gaxgrpc::ApiCall<DeleteEntitlementRequest, lro::Operation> _callDeleteEntitlement;

        private readonly gaxgrpc::ApiCall<UpdateEntitlementRequest, lro::Operation> _callUpdateEntitlement;

        private readonly gaxgrpc::ApiCall<ListGrantsRequest, ListGrantsResponse> _callListGrants;

        private readonly gaxgrpc::ApiCall<SearchGrantsRequest, SearchGrantsResponse> _callSearchGrants;

        private readonly gaxgrpc::ApiCall<GetGrantRequest, Grant> _callGetGrant;

        private readonly gaxgrpc::ApiCall<CreateGrantRequest, Grant> _callCreateGrant;

        private readonly gaxgrpc::ApiCall<ApproveGrantRequest, Grant> _callApproveGrant;

        private readonly gaxgrpc::ApiCall<DenyGrantRequest, Grant> _callDenyGrant;

        private readonly gaxgrpc::ApiCall<RevokeGrantRequest, lro::Operation> _callRevokeGrant;

        /// <summary>
        /// Constructs a client wrapper for the PrivilegedAccessManager service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="PrivilegedAccessManagerSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public PrivilegedAccessManagerClientImpl(PrivilegedAccessManager.PrivilegedAccessManagerClient grpcClient, PrivilegedAccessManagerSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            PrivilegedAccessManagerSettings effectiveSettings = settings ?? PrivilegedAccessManagerSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateEntitlementOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateEntitlementOperationsSettings, logger);
            DeleteEntitlementOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteEntitlementOperationsSettings, logger);
            UpdateEntitlementOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateEntitlementOperationsSettings, logger);
            RevokeGrantOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RevokeGrantOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCheckOnboardingStatus = clientHelper.BuildApiCall<CheckOnboardingStatusRequest, CheckOnboardingStatusResponse>("CheckOnboardingStatus", grpcClient.CheckOnboardingStatusAsync, grpcClient.CheckOnboardingStatus, effectiveSettings.CheckOnboardingStatusSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCheckOnboardingStatus);
            Modify_CheckOnboardingStatusApiCall(ref _callCheckOnboardingStatus);
            _callListEntitlements = clientHelper.BuildApiCall<ListEntitlementsRequest, ListEntitlementsResponse>("ListEntitlements", grpcClient.ListEntitlementsAsync, grpcClient.ListEntitlements, effectiveSettings.ListEntitlementsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEntitlements);
            Modify_ListEntitlementsApiCall(ref _callListEntitlements);
            _callSearchEntitlements = clientHelper.BuildApiCall<SearchEntitlementsRequest, SearchEntitlementsResponse>("SearchEntitlements", grpcClient.SearchEntitlementsAsync, grpcClient.SearchEntitlements, effectiveSettings.SearchEntitlementsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSearchEntitlements);
            Modify_SearchEntitlementsApiCall(ref _callSearchEntitlements);
            _callGetEntitlement = clientHelper.BuildApiCall<GetEntitlementRequest, Entitlement>("GetEntitlement", grpcClient.GetEntitlementAsync, grpcClient.GetEntitlement, effectiveSettings.GetEntitlementSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEntitlement);
            Modify_GetEntitlementApiCall(ref _callGetEntitlement);
            _callCreateEntitlement = clientHelper.BuildApiCall<CreateEntitlementRequest, lro::Operation>("CreateEntitlement", grpcClient.CreateEntitlementAsync, grpcClient.CreateEntitlement, effectiveSettings.CreateEntitlementSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateEntitlement);
            Modify_CreateEntitlementApiCall(ref _callCreateEntitlement);
            _callDeleteEntitlement = clientHelper.BuildApiCall<DeleteEntitlementRequest, lro::Operation>("DeleteEntitlement", grpcClient.DeleteEntitlementAsync, grpcClient.DeleteEntitlement, effectiveSettings.DeleteEntitlementSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteEntitlement);
            Modify_DeleteEntitlementApiCall(ref _callDeleteEntitlement);
            _callUpdateEntitlement = clientHelper.BuildApiCall<UpdateEntitlementRequest, lro::Operation>("UpdateEntitlement", grpcClient.UpdateEntitlementAsync, grpcClient.UpdateEntitlement, effectiveSettings.UpdateEntitlementSettings).WithGoogleRequestParam("entitlement.name", request => request.Entitlement?.Name);
            Modify_ApiCall(ref _callUpdateEntitlement);
            Modify_UpdateEntitlementApiCall(ref _callUpdateEntitlement);
            _callListGrants = clientHelper.BuildApiCall<ListGrantsRequest, ListGrantsResponse>("ListGrants", grpcClient.ListGrantsAsync, grpcClient.ListGrants, effectiveSettings.ListGrantsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListGrants);
            Modify_ListGrantsApiCall(ref _callListGrants);
            _callSearchGrants = clientHelper.BuildApiCall<SearchGrantsRequest, SearchGrantsResponse>("SearchGrants", grpcClient.SearchGrantsAsync, grpcClient.SearchGrants, effectiveSettings.SearchGrantsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSearchGrants);
            Modify_SearchGrantsApiCall(ref _callSearchGrants);
            _callGetGrant = clientHelper.BuildApiCall<GetGrantRequest, Grant>("GetGrant", grpcClient.GetGrantAsync, grpcClient.GetGrant, effectiveSettings.GetGrantSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetGrant);
            Modify_GetGrantApiCall(ref _callGetGrant);
            _callCreateGrant = clientHelper.BuildApiCall<CreateGrantRequest, Grant>("CreateGrant", grpcClient.CreateGrantAsync, grpcClient.CreateGrant, effectiveSettings.CreateGrantSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateGrant);
            Modify_CreateGrantApiCall(ref _callCreateGrant);
            _callApproveGrant = clientHelper.BuildApiCall<ApproveGrantRequest, Grant>("ApproveGrant", grpcClient.ApproveGrantAsync, grpcClient.ApproveGrant, effectiveSettings.ApproveGrantSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callApproveGrant);
            Modify_ApproveGrantApiCall(ref _callApproveGrant);
            _callDenyGrant = clientHelper.BuildApiCall<DenyGrantRequest, Grant>("DenyGrant", grpcClient.DenyGrantAsync, grpcClient.DenyGrant, effectiveSettings.DenyGrantSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDenyGrant);
            Modify_DenyGrantApiCall(ref _callDenyGrant);
            _callRevokeGrant = clientHelper.BuildApiCall<RevokeGrantRequest, lro::Operation>("RevokeGrant", grpcClient.RevokeGrantAsync, grpcClient.RevokeGrant, effectiveSettings.RevokeGrantSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRevokeGrant);
            Modify_RevokeGrantApiCall(ref _callRevokeGrant);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CheckOnboardingStatusApiCall(ref gaxgrpc::ApiCall<CheckOnboardingStatusRequest, CheckOnboardingStatusResponse> call);

        partial void Modify_ListEntitlementsApiCall(ref gaxgrpc::ApiCall<ListEntitlementsRequest, ListEntitlementsResponse> call);

        partial void Modify_SearchEntitlementsApiCall(ref gaxgrpc::ApiCall<SearchEntitlementsRequest, SearchEntitlementsResponse> call);

        partial void Modify_GetEntitlementApiCall(ref gaxgrpc::ApiCall<GetEntitlementRequest, Entitlement> call);

        partial void Modify_CreateEntitlementApiCall(ref gaxgrpc::ApiCall<CreateEntitlementRequest, lro::Operation> call);

        partial void Modify_DeleteEntitlementApiCall(ref gaxgrpc::ApiCall<DeleteEntitlementRequest, lro::Operation> call);

        partial void Modify_UpdateEntitlementApiCall(ref gaxgrpc::ApiCall<UpdateEntitlementRequest, lro::Operation> call);

        partial void Modify_ListGrantsApiCall(ref gaxgrpc::ApiCall<ListGrantsRequest, ListGrantsResponse> call);

        partial void Modify_SearchGrantsApiCall(ref gaxgrpc::ApiCall<SearchGrantsRequest, SearchGrantsResponse> call);

        partial void Modify_GetGrantApiCall(ref gaxgrpc::ApiCall<GetGrantRequest, Grant> call);

        partial void Modify_CreateGrantApiCall(ref gaxgrpc::ApiCall<CreateGrantRequest, Grant> call);

        partial void Modify_ApproveGrantApiCall(ref gaxgrpc::ApiCall<ApproveGrantRequest, Grant> call);

        partial void Modify_DenyGrantApiCall(ref gaxgrpc::ApiCall<DenyGrantRequest, Grant> call);

        partial void Modify_RevokeGrantApiCall(ref gaxgrpc::ApiCall<RevokeGrantRequest, lro::Operation> call);

        partial void OnConstruction(PrivilegedAccessManager.PrivilegedAccessManagerClient grpcClient, PrivilegedAccessManagerSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC PrivilegedAccessManager client</summary>
        public override PrivilegedAccessManager.PrivilegedAccessManagerClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CheckOnboardingStatusRequest(ref CheckOnboardingStatusRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEntitlementsRequest(ref ListEntitlementsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchEntitlementsRequest(ref SearchEntitlementsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEntitlementRequest(ref GetEntitlementRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateEntitlementRequest(ref CreateEntitlementRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteEntitlementRequest(ref DeleteEntitlementRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateEntitlementRequest(ref UpdateEntitlementRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListGrantsRequest(ref ListGrantsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchGrantsRequest(ref SearchGrantsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetGrantRequest(ref GetGrantRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateGrantRequest(ref CreateGrantRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ApproveGrantRequest(ref ApproveGrantRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DenyGrantRequest(ref DenyGrantRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RevokeGrantRequest(ref RevokeGrantRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// CheckOnboardingStatus reports the onboarding status for a
        /// project/folder/organization. Any findings reported by this API need to be
        /// fixed before PAM can be used on the resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CheckOnboardingStatusResponse CheckOnboardingStatus(CheckOnboardingStatusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CheckOnboardingStatusRequest(ref request, ref callSettings);
            return _callCheckOnboardingStatus.Sync(request, callSettings);
        }

        /// <summary>
        /// CheckOnboardingStatus reports the onboarding status for a
        /// project/folder/organization. Any findings reported by this API need to be
        /// fixed before PAM can be used on the resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CheckOnboardingStatusResponse> CheckOnboardingStatusAsync(CheckOnboardingStatusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CheckOnboardingStatusRequest(ref request, ref callSettings);
            return _callCheckOnboardingStatus.Async(request, callSettings);
        }

        /// <summary>
        /// Lists entitlements in a given project/folder/organization and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Entitlement"/> resources.</returns>
        public override gax::PagedEnumerable<ListEntitlementsResponse, Entitlement> ListEntitlements(ListEntitlementsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEntitlementsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEntitlementsRequest, ListEntitlementsResponse, Entitlement>(_callListEntitlements, request, callSettings);
        }

        /// <summary>
        /// Lists entitlements in a given project/folder/organization and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Entitlement"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEntitlementsResponse, Entitlement> ListEntitlementsAsync(ListEntitlementsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEntitlementsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEntitlementsRequest, ListEntitlementsResponse, Entitlement>(_callListEntitlements, request, callSettings);
        }

        /// <summary>
        /// `SearchEntitlements` returns entitlements on which the caller has the
        /// specified access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Entitlement"/> resources.</returns>
        public override gax::PagedEnumerable<SearchEntitlementsResponse, Entitlement> SearchEntitlements(SearchEntitlementsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchEntitlementsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchEntitlementsRequest, SearchEntitlementsResponse, Entitlement>(_callSearchEntitlements, request, callSettings);
        }

        /// <summary>
        /// `SearchEntitlements` returns entitlements on which the caller has the
        /// specified access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Entitlement"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchEntitlementsResponse, Entitlement> SearchEntitlementsAsync(SearchEntitlementsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchEntitlementsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchEntitlementsRequest, SearchEntitlementsResponse, Entitlement>(_callSearchEntitlements, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single entitlement.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Entitlement GetEntitlement(GetEntitlementRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEntitlementRequest(ref request, ref callSettings);
            return _callGetEntitlement.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single entitlement.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Entitlement> GetEntitlementAsync(GetEntitlementRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEntitlementRequest(ref request, ref callSettings);
            return _callGetEntitlement.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateEntitlement</c>.</summary>
        public override lro::OperationsClient CreateEntitlementOperationsClient { get; }

        /// <summary>
        /// Creates a new entitlement in a given project/folder/organization and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Entitlement, OperationMetadata> CreateEntitlement(CreateEntitlementRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEntitlementRequest(ref request, ref callSettings);
            return new lro::Operation<Entitlement, OperationMetadata>(_callCreateEntitlement.Sync(request, callSettings), CreateEntitlementOperationsClient);
        }

        /// <summary>
        /// Creates a new entitlement in a given project/folder/organization and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Entitlement, OperationMetadata>> CreateEntitlementAsync(CreateEntitlementRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEntitlementRequest(ref request, ref callSettings);
            return new lro::Operation<Entitlement, OperationMetadata>(await _callCreateEntitlement.Async(request, callSettings).ConfigureAwait(false), CreateEntitlementOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteEntitlement</c>.</summary>
        public override lro::OperationsClient DeleteEntitlementOperationsClient { get; }

        /// <summary>
        /// Deletes a single entitlement. This method can only be called when there
        /// are no in-progress (ACTIVE/ACTIVATING/REVOKING) grants under the
        /// entitlement.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Entitlement, OperationMetadata> DeleteEntitlement(DeleteEntitlementRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEntitlementRequest(ref request, ref callSettings);
            return new lro::Operation<Entitlement, OperationMetadata>(_callDeleteEntitlement.Sync(request, callSettings), DeleteEntitlementOperationsClient);
        }

        /// <summary>
        /// Deletes a single entitlement. This method can only be called when there
        /// are no in-progress (ACTIVE/ACTIVATING/REVOKING) grants under the
        /// entitlement.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Entitlement, OperationMetadata>> DeleteEntitlementAsync(DeleteEntitlementRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEntitlementRequest(ref request, ref callSettings);
            return new lro::Operation<Entitlement, OperationMetadata>(await _callDeleteEntitlement.Async(request, callSettings).ConfigureAwait(false), DeleteEntitlementOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateEntitlement</c>.</summary>
        public override lro::OperationsClient UpdateEntitlementOperationsClient { get; }

        /// <summary>
        /// Updates the entitlement specified in the request. Updated fields in the
        /// entitlement need to be specified in an update mask. The changes made to an
        /// entitlement are applicable only on future grants of the entitlement.
        /// However, if new approvers are added or existing approvers are removed from
        /// the approval workflow, the changes are effective on existing grants.
        /// 
        /// The following fields are not supported for updates:
        /// 
        /// * All immutable fields
        /// * Entitlement name
        /// * Resource name
        /// * Resource type
        /// * Adding an approval workflow in an entitlement which previously had no
        /// approval workflow.
        /// * Deleting the approval workflow from an entitlement.
        /// * Adding or deleting a step in the approval workflow (only one step is
        /// supported)
        /// 
        /// Note that updates are allowed on the list of approvers in an approval
        /// workflow step.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Entitlement, OperationMetadata> UpdateEntitlement(UpdateEntitlementRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEntitlementRequest(ref request, ref callSettings);
            return new lro::Operation<Entitlement, OperationMetadata>(_callUpdateEntitlement.Sync(request, callSettings), UpdateEntitlementOperationsClient);
        }

        /// <summary>
        /// Updates the entitlement specified in the request. Updated fields in the
        /// entitlement need to be specified in an update mask. The changes made to an
        /// entitlement are applicable only on future grants of the entitlement.
        /// However, if new approvers are added or existing approvers are removed from
        /// the approval workflow, the changes are effective on existing grants.
        /// 
        /// The following fields are not supported for updates:
        /// 
        /// * All immutable fields
        /// * Entitlement name
        /// * Resource name
        /// * Resource type
        /// * Adding an approval workflow in an entitlement which previously had no
        /// approval workflow.
        /// * Deleting the approval workflow from an entitlement.
        /// * Adding or deleting a step in the approval workflow (only one step is
        /// supported)
        /// 
        /// Note that updates are allowed on the list of approvers in an approval
        /// workflow step.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Entitlement, OperationMetadata>> UpdateEntitlementAsync(UpdateEntitlementRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEntitlementRequest(ref request, ref callSettings);
            return new lro::Operation<Entitlement, OperationMetadata>(await _callUpdateEntitlement.Async(request, callSettings).ConfigureAwait(false), UpdateEntitlementOperationsClient);
        }

        /// <summary>
        /// Lists grants for a given entitlement.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Grant"/> resources.</returns>
        public override gax::PagedEnumerable<ListGrantsResponse, Grant> ListGrants(ListGrantsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGrantsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListGrantsRequest, ListGrantsResponse, Grant>(_callListGrants, request, callSettings);
        }

        /// <summary>
        /// Lists grants for a given entitlement.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Grant"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListGrantsResponse, Grant> ListGrantsAsync(ListGrantsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGrantsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListGrantsRequest, ListGrantsResponse, Grant>(_callListGrants, request, callSettings);
        }

        /// <summary>
        /// `SearchGrants` returns grants that are related to the calling user in the
        /// specified way.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Grant"/> resources.</returns>
        public override gax::PagedEnumerable<SearchGrantsResponse, Grant> SearchGrants(SearchGrantsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchGrantsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchGrantsRequest, SearchGrantsResponse, Grant>(_callSearchGrants, request, callSettings);
        }

        /// <summary>
        /// `SearchGrants` returns grants that are related to the calling user in the
        /// specified way.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Grant"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchGrantsResponse, Grant> SearchGrantsAsync(SearchGrantsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchGrantsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchGrantsRequest, SearchGrantsResponse, Grant>(_callSearchGrants, request, callSettings);
        }

        /// <summary>
        /// Get details of a single grant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Grant GetGrant(GetGrantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGrantRequest(ref request, ref callSettings);
            return _callGetGrant.Sync(request, callSettings);
        }

        /// <summary>
        /// Get details of a single grant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Grant> GetGrantAsync(GetGrantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGrantRequest(ref request, ref callSettings);
            return _callGetGrant.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new grant in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Grant CreateGrant(CreateGrantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGrantRequest(ref request, ref callSettings);
            return _callCreateGrant.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new grant in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Grant> CreateGrantAsync(CreateGrantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGrantRequest(ref request, ref callSettings);
            return _callCreateGrant.Async(request, callSettings);
        }

        /// <summary>
        /// `ApproveGrant` is used to approve a grant. This method can only be called
        /// on a grant when it's in the `APPROVAL_AWAITED` state. This operation can't
        /// be undone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Grant ApproveGrant(ApproveGrantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ApproveGrantRequest(ref request, ref callSettings);
            return _callApproveGrant.Sync(request, callSettings);
        }

        /// <summary>
        /// `ApproveGrant` is used to approve a grant. This method can only be called
        /// on a grant when it's in the `APPROVAL_AWAITED` state. This operation can't
        /// be undone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Grant> ApproveGrantAsync(ApproveGrantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ApproveGrantRequest(ref request, ref callSettings);
            return _callApproveGrant.Async(request, callSettings);
        }

        /// <summary>
        /// `DenyGrant` is used to deny a grant. This method can only be called on a
        /// grant when it's in the `APPROVAL_AWAITED` state. This operation can't be
        /// undone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Grant DenyGrant(DenyGrantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DenyGrantRequest(ref request, ref callSettings);
            return _callDenyGrant.Sync(request, callSettings);
        }

        /// <summary>
        /// `DenyGrant` is used to deny a grant. This method can only be called on a
        /// grant when it's in the `APPROVAL_AWAITED` state. This operation can't be
        /// undone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Grant> DenyGrantAsync(DenyGrantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DenyGrantRequest(ref request, ref callSettings);
            return _callDenyGrant.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>RevokeGrant</c>.</summary>
        public override lro::OperationsClient RevokeGrantOperationsClient { get; }

        /// <summary>
        /// `RevokeGrant` is used to immediately revoke access for a grant. This method
        /// can be called when the grant is in a non-terminal state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Grant, OperationMetadata> RevokeGrant(RevokeGrantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RevokeGrantRequest(ref request, ref callSettings);
            return new lro::Operation<Grant, OperationMetadata>(_callRevokeGrant.Sync(request, callSettings), RevokeGrantOperationsClient);
        }

        /// <summary>
        /// `RevokeGrant` is used to immediately revoke access for a grant. This method
        /// can be called when the grant is in a non-terminal state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Grant, OperationMetadata>> RevokeGrantAsync(RevokeGrantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RevokeGrantRequest(ref request, ref callSettings);
            return new lro::Operation<Grant, OperationMetadata>(await _callRevokeGrant.Async(request, callSettings).ConfigureAwait(false), RevokeGrantOperationsClient);
        }
    }

    public partial class ListEntitlementsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchEntitlementsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListGrantsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchGrantsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEntitlementsResponse : gaxgrpc::IPageResponse<Entitlement>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Entitlement> GetEnumerator() => Entitlements.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchEntitlementsResponse : gaxgrpc::IPageResponse<Entitlement>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Entitlement> GetEnumerator() => Entitlements.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListGrantsResponse : gaxgrpc::IPageResponse<Grant>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Grant> GetEnumerator() => Grants.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchGrantsResponse : gaxgrpc::IPageResponse<Grant>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Grant> GetEnumerator() => Grants.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class PrivilegedAccessManager
    {
        public partial class PrivilegedAccessManagerClient
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

    public static partial class PrivilegedAccessManager
    {
        public partial class PrivilegedAccessManagerClient
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
