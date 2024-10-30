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
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.Eventarc.Publishing.V1
{
    /// <summary>Settings for <see cref="PublisherClient"/> instances.</summary>
    public sealed partial class PublisherSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PublisherSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PublisherSettings"/>.</returns>
        public static PublisherSettings GetDefault() => new PublisherSettings();

        /// <summary>Constructs a new <see cref="PublisherSettings"/> object with default settings.</summary>
        public PublisherSettings()
        {
        }

        private PublisherSettings(PublisherSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            PublishChannelConnectionEventsSettings = existing.PublishChannelConnectionEventsSettings;
            PublishEventsSettings = existing.PublishEventsSettings;
            PublishSettings = existing.PublishSettings;
            OnCopy(existing);
        }

        partial void OnCopy(PublisherSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublisherClient.PublishChannelConnectionEvents</c> and
        /// <c>PublisherClient.PublishChannelConnectionEventsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PublishChannelConnectionEventsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublisherClient.PublishEvents</c> and <c>PublisherClient.PublishEventsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PublishEventsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>PublisherClient.Publish</c>
        /// and <c>PublisherClient.PublishAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PublishSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PublisherSettings"/> object.</returns>
        public PublisherSettings Clone() => new PublisherSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PublisherClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class PublisherClientBuilder : gaxgrpc::ClientBuilderBase<PublisherClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PublisherSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public PublisherClientBuilder() : base(PublisherClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref PublisherClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PublisherClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PublisherClient Build()
        {
            PublisherClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PublisherClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PublisherClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PublisherClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PublisherClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<PublisherClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PublisherClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PublisherClient.ChannelPool;
    }

    /// <summary>Publisher client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Eventarc processes events generated by an event provider and delivers them to
    /// a subscriber.
    /// 
    /// An event provider is a software-as-a-service (SaaS) system or
    /// product that can generate and deliver events through Eventarc.
    /// 
    /// A third-party event provider is an event provider from outside of Google.
    /// 
    /// A partner is a third-party event provider that is integrated with Eventarc.
    /// 
    /// A subscriber is a GCP customer interested in receiving events.
    /// 
    /// Channel is a first-class Eventarc resource that is created and managed
    /// by the subscriber in their GCP project. A Channel represents a subscriber's
    /// intent to receive events from an event provider. A Channel is associated with
    /// exactly one event provider.
    /// 
    /// ChannelConnection is a first-class Eventarc resource that
    /// is created and managed by the partner in their GCP project. A
    /// ChannelConnection represents a connection between a partner and a
    /// subscriber's Channel. A ChannelConnection has a one-to-one mapping with a
    /// Channel.
    /// 
    /// Publisher allows an event provider to publish events to Eventarc.
    /// </remarks>
    public abstract partial class PublisherClient
    {
        /// <summary>
        /// The default endpoint for the Publisher service, which is a host of "eventarcpublishing.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "eventarcpublishing.googleapis.com:443";

        /// <summary>The default Publisher scopes.</summary>
        /// <remarks>
        /// The default Publisher scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Publisher.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="PublisherClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="PublisherClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PublisherClient"/>.</returns>
        public static stt::Task<PublisherClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PublisherClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PublisherClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="PublisherClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PublisherClient"/>.</returns>
        public static PublisherClient Create() => new PublisherClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PublisherClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PublisherSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="PublisherClient"/>.</returns>
        internal static PublisherClient Create(grpccore::CallInvoker callInvoker, PublisherSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Publisher.PublisherClient grpcClient = new Publisher.PublisherClient(callInvoker);
            return new PublisherClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Publisher client</summary>
        public virtual Publisher.PublisherClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Publish events to a ChannelConnection in a partner's project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PublishChannelConnectionEventsResponse PublishChannelConnectionEvents(PublishChannelConnectionEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Publish events to a ChannelConnection in a partner's project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublishChannelConnectionEventsResponse> PublishChannelConnectionEventsAsync(PublishChannelConnectionEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Publish events to a ChannelConnection in a partner's project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublishChannelConnectionEventsResponse> PublishChannelConnectionEventsAsync(PublishChannelConnectionEventsRequest request, st::CancellationToken cancellationToken) =>
            PublishChannelConnectionEventsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Publish events to a subscriber's channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PublishEventsResponse PublishEvents(PublishEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Publish events to a subscriber's channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublishEventsResponse> PublishEventsAsync(PublishEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Publish events to a subscriber's channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublishEventsResponse> PublishEventsAsync(PublishEventsRequest request, st::CancellationToken cancellationToken) =>
            PublishEventsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Publish events to a message bus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PublishResponse Publish(PublishRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Publish events to a message bus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublishResponse> PublishAsync(PublishRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Publish events to a message bus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublishResponse> PublishAsync(PublishRequest request, st::CancellationToken cancellationToken) =>
            PublishAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Publisher client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Eventarc processes events generated by an event provider and delivers them to
    /// a subscriber.
    /// 
    /// An event provider is a software-as-a-service (SaaS) system or
    /// product that can generate and deliver events through Eventarc.
    /// 
    /// A third-party event provider is an event provider from outside of Google.
    /// 
    /// A partner is a third-party event provider that is integrated with Eventarc.
    /// 
    /// A subscriber is a GCP customer interested in receiving events.
    /// 
    /// Channel is a first-class Eventarc resource that is created and managed
    /// by the subscriber in their GCP project. A Channel represents a subscriber's
    /// intent to receive events from an event provider. A Channel is associated with
    /// exactly one event provider.
    /// 
    /// ChannelConnection is a first-class Eventarc resource that
    /// is created and managed by the partner in their GCP project. A
    /// ChannelConnection represents a connection between a partner and a
    /// subscriber's Channel. A ChannelConnection has a one-to-one mapping with a
    /// Channel.
    /// 
    /// Publisher allows an event provider to publish events to Eventarc.
    /// </remarks>
    public sealed partial class PublisherClientImpl : PublisherClient
    {
        private readonly gaxgrpc::ApiCall<PublishChannelConnectionEventsRequest, PublishChannelConnectionEventsResponse> _callPublishChannelConnectionEvents;

        private readonly gaxgrpc::ApiCall<PublishEventsRequest, PublishEventsResponse> _callPublishEvents;

        private readonly gaxgrpc::ApiCall<PublishRequest, PublishResponse> _callPublish;

        /// <summary>
        /// Constructs a client wrapper for the Publisher service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="PublisherSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public PublisherClientImpl(Publisher.PublisherClient grpcClient, PublisherSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            PublisherSettings effectiveSettings = settings ?? PublisherSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callPublishChannelConnectionEvents = clientHelper.BuildApiCall<PublishChannelConnectionEventsRequest, PublishChannelConnectionEventsResponse>("PublishChannelConnectionEvents", grpcClient.PublishChannelConnectionEventsAsync, grpcClient.PublishChannelConnectionEvents, effectiveSettings.PublishChannelConnectionEventsSettings).WithGoogleRequestParam("channel_connection", request => request.ChannelConnection);
            Modify_ApiCall(ref _callPublishChannelConnectionEvents);
            Modify_PublishChannelConnectionEventsApiCall(ref _callPublishChannelConnectionEvents);
            _callPublishEvents = clientHelper.BuildApiCall<PublishEventsRequest, PublishEventsResponse>("PublishEvents", grpcClient.PublishEventsAsync, grpcClient.PublishEvents, effectiveSettings.PublishEventsSettings).WithGoogleRequestParam("channel", request => request.Channel);
            Modify_ApiCall(ref _callPublishEvents);
            Modify_PublishEventsApiCall(ref _callPublishEvents);
            _callPublish = clientHelper.BuildApiCall<PublishRequest, PublishResponse>("Publish", grpcClient.PublishAsync, grpcClient.Publish, effectiveSettings.PublishSettings).WithGoogleRequestParam("message_bus", request => request.MessageBus);
            Modify_ApiCall(ref _callPublish);
            Modify_PublishApiCall(ref _callPublish);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_PublishChannelConnectionEventsApiCall(ref gaxgrpc::ApiCall<PublishChannelConnectionEventsRequest, PublishChannelConnectionEventsResponse> call);

        partial void Modify_PublishEventsApiCall(ref gaxgrpc::ApiCall<PublishEventsRequest, PublishEventsResponse> call);

        partial void Modify_PublishApiCall(ref gaxgrpc::ApiCall<PublishRequest, PublishResponse> call);

        partial void OnConstruction(Publisher.PublisherClient grpcClient, PublisherSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Publisher client</summary>
        public override Publisher.PublisherClient GrpcClient { get; }

        partial void Modify_PublishChannelConnectionEventsRequest(ref PublishChannelConnectionEventsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PublishEventsRequest(ref PublishEventsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PublishRequest(ref PublishRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Publish events to a ChannelConnection in a partner's project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PublishChannelConnectionEventsResponse PublishChannelConnectionEvents(PublishChannelConnectionEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PublishChannelConnectionEventsRequest(ref request, ref callSettings);
            return _callPublishChannelConnectionEvents.Sync(request, callSettings);
        }

        /// <summary>
        /// Publish events to a ChannelConnection in a partner's project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PublishChannelConnectionEventsResponse> PublishChannelConnectionEventsAsync(PublishChannelConnectionEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PublishChannelConnectionEventsRequest(ref request, ref callSettings);
            return _callPublishChannelConnectionEvents.Async(request, callSettings);
        }

        /// <summary>
        /// Publish events to a subscriber's channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PublishEventsResponse PublishEvents(PublishEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PublishEventsRequest(ref request, ref callSettings);
            return _callPublishEvents.Sync(request, callSettings);
        }

        /// <summary>
        /// Publish events to a subscriber's channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PublishEventsResponse> PublishEventsAsync(PublishEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PublishEventsRequest(ref request, ref callSettings);
            return _callPublishEvents.Async(request, callSettings);
        }

        /// <summary>
        /// Publish events to a message bus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PublishResponse Publish(PublishRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PublishRequest(ref request, ref callSettings);
            return _callPublish.Sync(request, callSettings);
        }

        /// <summary>
        /// Publish events to a message bus.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PublishResponse> PublishAsync(PublishRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PublishRequest(ref request, ref callSettings);
            return _callPublish.Async(request, callSettings);
        }
    }
}
