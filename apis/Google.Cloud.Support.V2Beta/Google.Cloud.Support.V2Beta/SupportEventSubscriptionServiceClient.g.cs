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

namespace Google.Cloud.Support.V2Beta
{
    /// <summary>Settings for <see cref="SupportEventSubscriptionServiceClient"/> instances.</summary>
    public sealed partial class SupportEventSubscriptionServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SupportEventSubscriptionServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SupportEventSubscriptionServiceSettings"/>.</returns>
        public static SupportEventSubscriptionServiceSettings GetDefault() => new SupportEventSubscriptionServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="SupportEventSubscriptionServiceSettings"/> object with default settings.
        /// </summary>
        public SupportEventSubscriptionServiceSettings()
        {
        }

        private SupportEventSubscriptionServiceSettings(SupportEventSubscriptionServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateSupportEventSubscriptionSettings = existing.CreateSupportEventSubscriptionSettings;
            GetSupportEventSubscriptionSettings = existing.GetSupportEventSubscriptionSettings;
            ListSupportEventSubscriptionsSettings = existing.ListSupportEventSubscriptionsSettings;
            UpdateSupportEventSubscriptionSettings = existing.UpdateSupportEventSubscriptionSettings;
            DeleteSupportEventSubscriptionSettings = existing.DeleteSupportEventSubscriptionSettings;
            UndeleteSupportEventSubscriptionSettings = existing.UndeleteSupportEventSubscriptionSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SupportEventSubscriptionServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SupportEventSubscriptionServiceClient.CreateSupportEventSubscription</c> and
        /// <c>SupportEventSubscriptionServiceClient.CreateSupportEventSubscriptionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSupportEventSubscriptionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SupportEventSubscriptionServiceClient.GetSupportEventSubscription</c> and
        /// <c>SupportEventSubscriptionServiceClient.GetSupportEventSubscriptionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSupportEventSubscriptionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SupportEventSubscriptionServiceClient.ListSupportEventSubscriptions</c> and
        /// <c>SupportEventSubscriptionServiceClient.ListSupportEventSubscriptionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSupportEventSubscriptionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SupportEventSubscriptionServiceClient.UpdateSupportEventSubscription</c> and
        /// <c>SupportEventSubscriptionServiceClient.UpdateSupportEventSubscriptionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSupportEventSubscriptionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SupportEventSubscriptionServiceClient.DeleteSupportEventSubscription</c> and
        /// <c>SupportEventSubscriptionServiceClient.DeleteSupportEventSubscriptionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSupportEventSubscriptionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SupportEventSubscriptionServiceClient.UndeleteSupportEventSubscription</c> and
        /// <c>SupportEventSubscriptionServiceClient.UndeleteSupportEventSubscriptionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UndeleteSupportEventSubscriptionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SupportEventSubscriptionServiceSettings"/> object.</returns>
        public SupportEventSubscriptionServiceSettings Clone() => new SupportEventSubscriptionServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SupportEventSubscriptionServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class SupportEventSubscriptionServiceClientBuilder : gaxgrpc::ClientBuilderBase<SupportEventSubscriptionServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SupportEventSubscriptionServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SupportEventSubscriptionServiceClientBuilder() : base(SupportEventSubscriptionServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SupportEventSubscriptionServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SupportEventSubscriptionServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SupportEventSubscriptionServiceClient Build()
        {
            SupportEventSubscriptionServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SupportEventSubscriptionServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SupportEventSubscriptionServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SupportEventSubscriptionServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SupportEventSubscriptionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SupportEventSubscriptionServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SupportEventSubscriptionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SupportEventSubscriptionServiceClient.ChannelPool;
    }

    /// <summary>SupportEventSubscriptionService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing customer support event subscriptions.
    /// </remarks>
    public abstract partial class SupportEventSubscriptionServiceClient
    {
        /// <summary>
        /// The default endpoint for the SupportEventSubscriptionService service, which is a host of
        /// "cloudsupport.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudsupport.googleapis.com:443";

        /// <summary>The default SupportEventSubscriptionService scopes.</summary>
        /// <remarks>
        /// The default SupportEventSubscriptionService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SupportEventSubscriptionService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SupportEventSubscriptionServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="SupportEventSubscriptionServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SupportEventSubscriptionServiceClient"/>.</returns>
        public static stt::Task<SupportEventSubscriptionServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SupportEventSubscriptionServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SupportEventSubscriptionServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="SupportEventSubscriptionServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SupportEventSubscriptionServiceClient"/>.</returns>
        public static SupportEventSubscriptionServiceClient Create() =>
            new SupportEventSubscriptionServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SupportEventSubscriptionServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SupportEventSubscriptionServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SupportEventSubscriptionServiceClient"/>.</returns>
        internal static SupportEventSubscriptionServiceClient Create(grpccore::CallInvoker callInvoker, SupportEventSubscriptionServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SupportEventSubscriptionService.SupportEventSubscriptionServiceClient grpcClient = new SupportEventSubscriptionService.SupportEventSubscriptionServiceClient(callInvoker);
            return new SupportEventSubscriptionServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC SupportEventSubscriptionService client</summary>
        public virtual SupportEventSubscriptionService.SupportEventSubscriptionServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a support event subscription for an organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SupportEventSubscription CreateSupportEventSubscription(CreateSupportEventSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a support event subscription for an organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SupportEventSubscription> CreateSupportEventSubscriptionAsync(CreateSupportEventSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a support event subscription for an organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SupportEventSubscription> CreateSupportEventSubscriptionAsync(CreateSupportEventSubscriptionRequest request, st::CancellationToken cancellationToken) =>
            CreateSupportEventSubscriptionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a support event subscription for an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name where the support event subscription
        /// will be created. Format: organizations/{organization_id}
        /// </param>
        /// <param name="supportEventSubscription">
        /// Required. The Pub/Sub configuration to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SupportEventSubscription CreateSupportEventSubscription(string parent, SupportEventSubscription supportEventSubscription, gaxgrpc::CallSettings callSettings = null) =>
            CreateSupportEventSubscription(new CreateSupportEventSubscriptionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SupportEventSubscription = gax::GaxPreconditions.CheckNotNull(supportEventSubscription, nameof(supportEventSubscription)),
            }, callSettings);

        /// <summary>
        /// Creates a support event subscription for an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name where the support event subscription
        /// will be created. Format: organizations/{organization_id}
        /// </param>
        /// <param name="supportEventSubscription">
        /// Required. The Pub/Sub configuration to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SupportEventSubscription> CreateSupportEventSubscriptionAsync(string parent, SupportEventSubscription supportEventSubscription, gaxgrpc::CallSettings callSettings = null) =>
            CreateSupportEventSubscriptionAsync(new CreateSupportEventSubscriptionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SupportEventSubscription = gax::GaxPreconditions.CheckNotNull(supportEventSubscription, nameof(supportEventSubscription)),
            }, callSettings);

        /// <summary>
        /// Creates a support event subscription for an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name where the support event subscription
        /// will be created. Format: organizations/{organization_id}
        /// </param>
        /// <param name="supportEventSubscription">
        /// Required. The Pub/Sub configuration to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SupportEventSubscription> CreateSupportEventSubscriptionAsync(string parent, SupportEventSubscription supportEventSubscription, st::CancellationToken cancellationToken) =>
            CreateSupportEventSubscriptionAsync(parent, supportEventSubscription, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a support event subscription for an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name where the support event subscription
        /// will be created. Format: organizations/{organization_id}
        /// </param>
        /// <param name="supportEventSubscription">
        /// Required. The Pub/Sub configuration to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SupportEventSubscription CreateSupportEventSubscription(gagr::OrganizationName parent, SupportEventSubscription supportEventSubscription, gaxgrpc::CallSettings callSettings = null) =>
            CreateSupportEventSubscription(new CreateSupportEventSubscriptionRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SupportEventSubscription = gax::GaxPreconditions.CheckNotNull(supportEventSubscription, nameof(supportEventSubscription)),
            }, callSettings);

        /// <summary>
        /// Creates a support event subscription for an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name where the support event subscription
        /// will be created. Format: organizations/{organization_id}
        /// </param>
        /// <param name="supportEventSubscription">
        /// Required. The Pub/Sub configuration to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SupportEventSubscription> CreateSupportEventSubscriptionAsync(gagr::OrganizationName parent, SupportEventSubscription supportEventSubscription, gaxgrpc::CallSettings callSettings = null) =>
            CreateSupportEventSubscriptionAsync(new CreateSupportEventSubscriptionRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SupportEventSubscription = gax::GaxPreconditions.CheckNotNull(supportEventSubscription, nameof(supportEventSubscription)),
            }, callSettings);

        /// <summary>
        /// Creates a support event subscription for an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name where the support event subscription
        /// will be created. Format: organizations/{organization_id}
        /// </param>
        /// <param name="supportEventSubscription">
        /// Required. The Pub/Sub configuration to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SupportEventSubscription> CreateSupportEventSubscriptionAsync(gagr::OrganizationName parent, SupportEventSubscription supportEventSubscription, st::CancellationToken cancellationToken) =>
            CreateSupportEventSubscriptionAsync(parent, supportEventSubscription, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a support event subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SupportEventSubscription GetSupportEventSubscription(GetSupportEventSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a support event subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SupportEventSubscription> GetSupportEventSubscriptionAsync(GetSupportEventSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a support event subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SupportEventSubscription> GetSupportEventSubscriptionAsync(GetSupportEventSubscriptionRequest request, st::CancellationToken cancellationToken) =>
            GetSupportEventSubscriptionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a support event subscription.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the support event subscription to retrieve.
        /// Format:
        /// organizations/{organization_id}/supportEventSubscriptions/{subscription_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SupportEventSubscription GetSupportEventSubscription(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSupportEventSubscription(new GetSupportEventSubscriptionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a support event subscription.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the support event subscription to retrieve.
        /// Format:
        /// organizations/{organization_id}/supportEventSubscriptions/{subscription_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SupportEventSubscription> GetSupportEventSubscriptionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSupportEventSubscriptionAsync(new GetSupportEventSubscriptionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a support event subscription.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the support event subscription to retrieve.
        /// Format:
        /// organizations/{organization_id}/supportEventSubscriptions/{subscription_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SupportEventSubscription> GetSupportEventSubscriptionAsync(string name, st::CancellationToken cancellationToken) =>
            GetSupportEventSubscriptionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a support event subscription.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the support event subscription to retrieve.
        /// Format:
        /// organizations/{organization_id}/supportEventSubscriptions/{subscription_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SupportEventSubscription GetSupportEventSubscription(SupportEventSubscriptionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSupportEventSubscription(new GetSupportEventSubscriptionRequest
            {
                SupportEventSubscriptionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a support event subscription.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the support event subscription to retrieve.
        /// Format:
        /// organizations/{organization_id}/supportEventSubscriptions/{subscription_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SupportEventSubscription> GetSupportEventSubscriptionAsync(SupportEventSubscriptionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSupportEventSubscriptionAsync(new GetSupportEventSubscriptionRequest
            {
                SupportEventSubscriptionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a support event subscription.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the support event subscription to retrieve.
        /// Format:
        /// organizations/{organization_id}/supportEventSubscriptions/{subscription_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SupportEventSubscription> GetSupportEventSubscriptionAsync(SupportEventSubscriptionName name, st::CancellationToken cancellationToken) =>
            GetSupportEventSubscriptionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists support event subscriptions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SupportEventSubscription"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSupportEventSubscriptionsResponse, SupportEventSubscription> ListSupportEventSubscriptions(ListSupportEventSubscriptionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists support event subscriptions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SupportEventSubscription"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSupportEventSubscriptionsResponse, SupportEventSubscription> ListSupportEventSubscriptionsAsync(ListSupportEventSubscriptionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists support event subscriptions.
        /// </summary>
        /// <param name="parent">
        /// Required. The fully qualified name of the Cloud resource to list support
        /// event subscriptions under. Format: organizations/{organization_id}
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
        /// <returns>A pageable sequence of <see cref="SupportEventSubscription"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSupportEventSubscriptionsResponse, SupportEventSubscription> ListSupportEventSubscriptions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSupportEventSubscriptionsRequest request = new ListSupportEventSubscriptionsRequest
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
            return ListSupportEventSubscriptions(request, callSettings);
        }

        /// <summary>
        /// Lists support event subscriptions.
        /// </summary>
        /// <param name="parent">
        /// Required. The fully qualified name of the Cloud resource to list support
        /// event subscriptions under. Format: organizations/{organization_id}
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
        /// <returns>A pageable asynchronous sequence of <see cref="SupportEventSubscription"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSupportEventSubscriptionsResponse, SupportEventSubscription> ListSupportEventSubscriptionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSupportEventSubscriptionsRequest request = new ListSupportEventSubscriptionsRequest
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
            return ListSupportEventSubscriptionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists support event subscriptions.
        /// </summary>
        /// <param name="parent">
        /// Required. The fully qualified name of the Cloud resource to list support
        /// event subscriptions under. Format: organizations/{organization_id}
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
        /// <returns>A pageable sequence of <see cref="SupportEventSubscription"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSupportEventSubscriptionsResponse, SupportEventSubscription> ListSupportEventSubscriptions(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSupportEventSubscriptionsRequest request = new ListSupportEventSubscriptionsRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSupportEventSubscriptions(request, callSettings);
        }

        /// <summary>
        /// Lists support event subscriptions.
        /// </summary>
        /// <param name="parent">
        /// Required. The fully qualified name of the Cloud resource to list support
        /// event subscriptions under. Format: organizations/{organization_id}
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
        /// <returns>A pageable asynchronous sequence of <see cref="SupportEventSubscription"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSupportEventSubscriptionsResponse, SupportEventSubscription> ListSupportEventSubscriptionsAsync(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSupportEventSubscriptionsRequest request = new ListSupportEventSubscriptionsRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSupportEventSubscriptionsAsync(request, callSettings);
        }

        /// <summary>
        /// Updates a support event subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SupportEventSubscription UpdateSupportEventSubscription(UpdateSupportEventSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a support event subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SupportEventSubscription> UpdateSupportEventSubscriptionAsync(UpdateSupportEventSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a support event subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SupportEventSubscription> UpdateSupportEventSubscriptionAsync(UpdateSupportEventSubscriptionRequest request, st::CancellationToken cancellationToken) =>
            UpdateSupportEventSubscriptionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a support event subscription.
        /// </summary>
        /// <param name="supportEventSubscription">
        /// Required. The support event subscription to update.
        /// The `name` field is used to identify the configuration to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update. The only supported value is
        /// pub_sub_topic.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SupportEventSubscription UpdateSupportEventSubscription(SupportEventSubscription supportEventSubscription, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSupportEventSubscription(new UpdateSupportEventSubscriptionRequest
            {
                SupportEventSubscription = gax::GaxPreconditions.CheckNotNull(supportEventSubscription, nameof(supportEventSubscription)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a support event subscription.
        /// </summary>
        /// <param name="supportEventSubscription">
        /// Required. The support event subscription to update.
        /// The `name` field is used to identify the configuration to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update. The only supported value is
        /// pub_sub_topic.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SupportEventSubscription> UpdateSupportEventSubscriptionAsync(SupportEventSubscription supportEventSubscription, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSupportEventSubscriptionAsync(new UpdateSupportEventSubscriptionRequest
            {
                SupportEventSubscription = gax::GaxPreconditions.CheckNotNull(supportEventSubscription, nameof(supportEventSubscription)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a support event subscription.
        /// </summary>
        /// <param name="supportEventSubscription">
        /// Required. The support event subscription to update.
        /// The `name` field is used to identify the configuration to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update. The only supported value is
        /// pub_sub_topic.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SupportEventSubscription> UpdateSupportEventSubscriptionAsync(SupportEventSubscription supportEventSubscription, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSupportEventSubscriptionAsync(supportEventSubscription, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Soft deletes a support event subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SupportEventSubscription DeleteSupportEventSubscription(DeleteSupportEventSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Soft deletes a support event subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SupportEventSubscription> DeleteSupportEventSubscriptionAsync(DeleteSupportEventSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Soft deletes a support event subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SupportEventSubscription> DeleteSupportEventSubscriptionAsync(DeleteSupportEventSubscriptionRequest request, st::CancellationToken cancellationToken) =>
            DeleteSupportEventSubscriptionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Soft deletes a support event subscription.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the support event subscription to delete.
        /// Format:
        /// organizations/{organization_id}/supportEventSubscriptions/{subscription_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SupportEventSubscription DeleteSupportEventSubscription(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSupportEventSubscription(new DeleteSupportEventSubscriptionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Soft deletes a support event subscription.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the support event subscription to delete.
        /// Format:
        /// organizations/{organization_id}/supportEventSubscriptions/{subscription_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SupportEventSubscription> DeleteSupportEventSubscriptionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSupportEventSubscriptionAsync(new DeleteSupportEventSubscriptionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Soft deletes a support event subscription.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the support event subscription to delete.
        /// Format:
        /// organizations/{organization_id}/supportEventSubscriptions/{subscription_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SupportEventSubscription> DeleteSupportEventSubscriptionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSupportEventSubscriptionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Soft deletes a support event subscription.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the support event subscription to delete.
        /// Format:
        /// organizations/{organization_id}/supportEventSubscriptions/{subscription_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SupportEventSubscription DeleteSupportEventSubscription(SupportEventSubscriptionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSupportEventSubscription(new DeleteSupportEventSubscriptionRequest
            {
                SupportEventSubscriptionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Soft deletes a support event subscription.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the support event subscription to delete.
        /// Format:
        /// organizations/{organization_id}/supportEventSubscriptions/{subscription_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SupportEventSubscription> DeleteSupportEventSubscriptionAsync(SupportEventSubscriptionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSupportEventSubscriptionAsync(new DeleteSupportEventSubscriptionRequest
            {
                SupportEventSubscriptionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Soft deletes a support event subscription.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the support event subscription to delete.
        /// Format:
        /// organizations/{organization_id}/supportEventSubscriptions/{subscription_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SupportEventSubscription> DeleteSupportEventSubscriptionAsync(SupportEventSubscriptionName name, st::CancellationToken cancellationToken) =>
            DeleteSupportEventSubscriptionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Undeletes a support event subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SupportEventSubscription UndeleteSupportEventSubscription(UndeleteSupportEventSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Undeletes a support event subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SupportEventSubscription> UndeleteSupportEventSubscriptionAsync(UndeleteSupportEventSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Undeletes a support event subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SupportEventSubscription> UndeleteSupportEventSubscriptionAsync(UndeleteSupportEventSubscriptionRequest request, st::CancellationToken cancellationToken) =>
            UndeleteSupportEventSubscriptionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SupportEventSubscriptionService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing customer support event subscriptions.
    /// </remarks>
    public sealed partial class SupportEventSubscriptionServiceClientImpl : SupportEventSubscriptionServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateSupportEventSubscriptionRequest, SupportEventSubscription> _callCreateSupportEventSubscription;

        private readonly gaxgrpc::ApiCall<GetSupportEventSubscriptionRequest, SupportEventSubscription> _callGetSupportEventSubscription;

        private readonly gaxgrpc::ApiCall<ListSupportEventSubscriptionsRequest, ListSupportEventSubscriptionsResponse> _callListSupportEventSubscriptions;

        private readonly gaxgrpc::ApiCall<UpdateSupportEventSubscriptionRequest, SupportEventSubscription> _callUpdateSupportEventSubscription;

        private readonly gaxgrpc::ApiCall<DeleteSupportEventSubscriptionRequest, SupportEventSubscription> _callDeleteSupportEventSubscription;

        private readonly gaxgrpc::ApiCall<UndeleteSupportEventSubscriptionRequest, SupportEventSubscription> _callUndeleteSupportEventSubscription;

        /// <summary>
        /// Constructs a client wrapper for the SupportEventSubscriptionService service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="SupportEventSubscriptionServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SupportEventSubscriptionServiceClientImpl(SupportEventSubscriptionService.SupportEventSubscriptionServiceClient grpcClient, SupportEventSubscriptionServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SupportEventSubscriptionServiceSettings effectiveSettings = settings ?? SupportEventSubscriptionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCreateSupportEventSubscription = clientHelper.BuildApiCall<CreateSupportEventSubscriptionRequest, SupportEventSubscription>("CreateSupportEventSubscription", grpcClient.CreateSupportEventSubscriptionAsync, grpcClient.CreateSupportEventSubscription, effectiveSettings.CreateSupportEventSubscriptionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSupportEventSubscription);
            Modify_CreateSupportEventSubscriptionApiCall(ref _callCreateSupportEventSubscription);
            _callGetSupportEventSubscription = clientHelper.BuildApiCall<GetSupportEventSubscriptionRequest, SupportEventSubscription>("GetSupportEventSubscription", grpcClient.GetSupportEventSubscriptionAsync, grpcClient.GetSupportEventSubscription, effectiveSettings.GetSupportEventSubscriptionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSupportEventSubscription);
            Modify_GetSupportEventSubscriptionApiCall(ref _callGetSupportEventSubscription);
            _callListSupportEventSubscriptions = clientHelper.BuildApiCall<ListSupportEventSubscriptionsRequest, ListSupportEventSubscriptionsResponse>("ListSupportEventSubscriptions", grpcClient.ListSupportEventSubscriptionsAsync, grpcClient.ListSupportEventSubscriptions, effectiveSettings.ListSupportEventSubscriptionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSupportEventSubscriptions);
            Modify_ListSupportEventSubscriptionsApiCall(ref _callListSupportEventSubscriptions);
            _callUpdateSupportEventSubscription = clientHelper.BuildApiCall<UpdateSupportEventSubscriptionRequest, SupportEventSubscription>("UpdateSupportEventSubscription", grpcClient.UpdateSupportEventSubscriptionAsync, grpcClient.UpdateSupportEventSubscription, effectiveSettings.UpdateSupportEventSubscriptionSettings).WithGoogleRequestParam("support_event_subscription.name", request => request.SupportEventSubscription?.Name);
            Modify_ApiCall(ref _callUpdateSupportEventSubscription);
            Modify_UpdateSupportEventSubscriptionApiCall(ref _callUpdateSupportEventSubscription);
            _callDeleteSupportEventSubscription = clientHelper.BuildApiCall<DeleteSupportEventSubscriptionRequest, SupportEventSubscription>("DeleteSupportEventSubscription", grpcClient.DeleteSupportEventSubscriptionAsync, grpcClient.DeleteSupportEventSubscription, effectiveSettings.DeleteSupportEventSubscriptionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSupportEventSubscription);
            Modify_DeleteSupportEventSubscriptionApiCall(ref _callDeleteSupportEventSubscription);
            _callUndeleteSupportEventSubscription = clientHelper.BuildApiCall<UndeleteSupportEventSubscriptionRequest, SupportEventSubscription>("UndeleteSupportEventSubscription", grpcClient.UndeleteSupportEventSubscriptionAsync, grpcClient.UndeleteSupportEventSubscription, effectiveSettings.UndeleteSupportEventSubscriptionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUndeleteSupportEventSubscription);
            Modify_UndeleteSupportEventSubscriptionApiCall(ref _callUndeleteSupportEventSubscription);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateSupportEventSubscriptionApiCall(ref gaxgrpc::ApiCall<CreateSupportEventSubscriptionRequest, SupportEventSubscription> call);

        partial void Modify_GetSupportEventSubscriptionApiCall(ref gaxgrpc::ApiCall<GetSupportEventSubscriptionRequest, SupportEventSubscription> call);

        partial void Modify_ListSupportEventSubscriptionsApiCall(ref gaxgrpc::ApiCall<ListSupportEventSubscriptionsRequest, ListSupportEventSubscriptionsResponse> call);

        partial void Modify_UpdateSupportEventSubscriptionApiCall(ref gaxgrpc::ApiCall<UpdateSupportEventSubscriptionRequest, SupportEventSubscription> call);

        partial void Modify_DeleteSupportEventSubscriptionApiCall(ref gaxgrpc::ApiCall<DeleteSupportEventSubscriptionRequest, SupportEventSubscription> call);

        partial void Modify_UndeleteSupportEventSubscriptionApiCall(ref gaxgrpc::ApiCall<UndeleteSupportEventSubscriptionRequest, SupportEventSubscription> call);

        partial void OnConstruction(SupportEventSubscriptionService.SupportEventSubscriptionServiceClient grpcClient, SupportEventSubscriptionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SupportEventSubscriptionService client</summary>
        public override SupportEventSubscriptionService.SupportEventSubscriptionServiceClient GrpcClient { get; }

        partial void Modify_CreateSupportEventSubscriptionRequest(ref CreateSupportEventSubscriptionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSupportEventSubscriptionRequest(ref GetSupportEventSubscriptionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSupportEventSubscriptionsRequest(ref ListSupportEventSubscriptionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSupportEventSubscriptionRequest(ref UpdateSupportEventSubscriptionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSupportEventSubscriptionRequest(ref DeleteSupportEventSubscriptionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UndeleteSupportEventSubscriptionRequest(ref UndeleteSupportEventSubscriptionRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a support event subscription for an organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SupportEventSubscription CreateSupportEventSubscription(CreateSupportEventSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSupportEventSubscriptionRequest(ref request, ref callSettings);
            return _callCreateSupportEventSubscription.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a support event subscription for an organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SupportEventSubscription> CreateSupportEventSubscriptionAsync(CreateSupportEventSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSupportEventSubscriptionRequest(ref request, ref callSettings);
            return _callCreateSupportEventSubscription.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a support event subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SupportEventSubscription GetSupportEventSubscription(GetSupportEventSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSupportEventSubscriptionRequest(ref request, ref callSettings);
            return _callGetSupportEventSubscription.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a support event subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SupportEventSubscription> GetSupportEventSubscriptionAsync(GetSupportEventSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSupportEventSubscriptionRequest(ref request, ref callSettings);
            return _callGetSupportEventSubscription.Async(request, callSettings);
        }

        /// <summary>
        /// Lists support event subscriptions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SupportEventSubscription"/> resources.</returns>
        public override gax::PagedEnumerable<ListSupportEventSubscriptionsResponse, SupportEventSubscription> ListSupportEventSubscriptions(ListSupportEventSubscriptionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSupportEventSubscriptionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSupportEventSubscriptionsRequest, ListSupportEventSubscriptionsResponse, SupportEventSubscription>(_callListSupportEventSubscriptions, request, callSettings);
        }

        /// <summary>
        /// Lists support event subscriptions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SupportEventSubscription"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSupportEventSubscriptionsResponse, SupportEventSubscription> ListSupportEventSubscriptionsAsync(ListSupportEventSubscriptionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSupportEventSubscriptionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSupportEventSubscriptionsRequest, ListSupportEventSubscriptionsResponse, SupportEventSubscription>(_callListSupportEventSubscriptions, request, callSettings);
        }

        /// <summary>
        /// Updates a support event subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SupportEventSubscription UpdateSupportEventSubscription(UpdateSupportEventSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSupportEventSubscriptionRequest(ref request, ref callSettings);
            return _callUpdateSupportEventSubscription.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a support event subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SupportEventSubscription> UpdateSupportEventSubscriptionAsync(UpdateSupportEventSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSupportEventSubscriptionRequest(ref request, ref callSettings);
            return _callUpdateSupportEventSubscription.Async(request, callSettings);
        }

        /// <summary>
        /// Soft deletes a support event subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SupportEventSubscription DeleteSupportEventSubscription(DeleteSupportEventSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSupportEventSubscriptionRequest(ref request, ref callSettings);
            return _callDeleteSupportEventSubscription.Sync(request, callSettings);
        }

        /// <summary>
        /// Soft deletes a support event subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SupportEventSubscription> DeleteSupportEventSubscriptionAsync(DeleteSupportEventSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSupportEventSubscriptionRequest(ref request, ref callSettings);
            return _callDeleteSupportEventSubscription.Async(request, callSettings);
        }

        /// <summary>
        /// Undeletes a support event subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SupportEventSubscription UndeleteSupportEventSubscription(UndeleteSupportEventSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeleteSupportEventSubscriptionRequest(ref request, ref callSettings);
            return _callUndeleteSupportEventSubscription.Sync(request, callSettings);
        }

        /// <summary>
        /// Undeletes a support event subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SupportEventSubscription> UndeleteSupportEventSubscriptionAsync(UndeleteSupportEventSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeleteSupportEventSubscriptionRequest(ref request, ref callSettings);
            return _callUndeleteSupportEventSubscription.Async(request, callSettings);
        }
    }

    public partial class ListSupportEventSubscriptionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSupportEventSubscriptionsResponse : gaxgrpc::IPageResponse<SupportEventSubscription>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<SupportEventSubscription> GetEnumerator() => SupportEventSubscriptions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
