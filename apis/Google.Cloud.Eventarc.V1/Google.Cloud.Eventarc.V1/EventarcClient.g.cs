// Copyright 2021 Google LLC
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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using gagr = Google.Api.Gax.ResourceNames;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Eventarc.V1
{
    /// <summary>Settings for <see cref="EventarcClient"/> instances.</summary>
    public sealed partial class EventarcSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="EventarcSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="EventarcSettings"/>.</returns>
        public static EventarcSettings GetDefault() => new EventarcSettings();

        /// <summary>Constructs a new <see cref="EventarcSettings"/> object with default settings.</summary>
        public EventarcSettings()
        {
        }

        private EventarcSettings(EventarcSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetTriggerSettings = existing.GetTriggerSettings;
            ListTriggersSettings = existing.ListTriggersSettings;
            CreateTriggerSettings = existing.CreateTriggerSettings;
            CreateTriggerOperationsSettings = existing.CreateTriggerOperationsSettings.Clone();
            UpdateTriggerSettings = existing.UpdateTriggerSettings;
            UpdateTriggerOperationsSettings = existing.UpdateTriggerOperationsSettings.Clone();
            DeleteTriggerSettings = existing.DeleteTriggerSettings;
            DeleteTriggerOperationsSettings = existing.DeleteTriggerOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(EventarcSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>EventarcClient.GetTrigger</c>
        ///  and <c>EventarcClient.GetTriggerAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTriggerSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>EventarcClient.ListTriggers</c>
        ///  and <c>EventarcClient.ListTriggersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTriggersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EventarcClient.CreateTrigger</c> and <c>EventarcClient.CreateTriggerAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTriggerSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>EventarcClient.CreateTrigger</c> and
        /// <c>EventarcClient.CreateTriggerAsync</c>.
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
        public lro::OperationsSettings CreateTriggerOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EventarcClient.UpdateTrigger</c> and <c>EventarcClient.UpdateTriggerAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateTriggerSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>EventarcClient.UpdateTrigger</c> and
        /// <c>EventarcClient.UpdateTriggerAsync</c>.
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
        public lro::OperationsSettings UpdateTriggerOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EventarcClient.DeleteTrigger</c> and <c>EventarcClient.DeleteTriggerAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTriggerSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>EventarcClient.DeleteTrigger</c> and
        /// <c>EventarcClient.DeleteTriggerAsync</c>.
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
        public lro::OperationsSettings DeleteTriggerOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="EventarcSettings"/> object.</returns>
        public EventarcSettings Clone() => new EventarcSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="EventarcClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class EventarcClientBuilder : gaxgrpc::ClientBuilderBase<EventarcClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public EventarcSettings Settings { get; set; }

        partial void InterceptBuild(ref EventarcClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<EventarcClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override EventarcClient Build()
        {
            EventarcClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<EventarcClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<EventarcClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private EventarcClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return EventarcClient.Create(callInvoker, Settings);
        }

        private async stt::Task<EventarcClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return EventarcClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => EventarcClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => EventarcClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => EventarcClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>Eventarc client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Eventarc allows users to subscribe to various events that are provided by
    /// Google Cloud services and forward them to supported destinations.
    /// </remarks>
    public abstract partial class EventarcClient
    {
        /// <summary>
        /// The default endpoint for the Eventarc service, which is a host of "eventarc.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "eventarc.googleapis.com:443";

        /// <summary>The default Eventarc scopes.</summary>
        /// <remarks>
        /// The default Eventarc scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="EventarcClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="EventarcClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="EventarcClient"/>.</returns>
        public static stt::Task<EventarcClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new EventarcClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="EventarcClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="EventarcClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="EventarcClient"/>.</returns>
        public static EventarcClient Create() => new EventarcClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="EventarcClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="EventarcSettings"/>.</param>
        /// <returns>The created <see cref="EventarcClient"/>.</returns>
        internal static EventarcClient Create(grpccore::CallInvoker callInvoker, EventarcSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Eventarc.EventarcClient grpcClient = new Eventarc.EventarcClient(callInvoker);
            return new EventarcClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC Eventarc client</summary>
        public virtual Eventarc.EventarcClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Get a single trigger.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Trigger GetTrigger(GetTriggerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a single trigger.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Trigger> GetTriggerAsync(GetTriggerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a single trigger.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Trigger> GetTriggerAsync(GetTriggerRequest request, st::CancellationToken cancellationToken) =>
            GetTriggerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a single trigger.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the trigger to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Trigger GetTrigger(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTrigger(new GetTriggerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single trigger.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the trigger to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Trigger> GetTriggerAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTriggerAsync(new GetTriggerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single trigger.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the trigger to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Trigger> GetTriggerAsync(string name, st::CancellationToken cancellationToken) =>
            GetTriggerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a single trigger.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the trigger to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Trigger GetTrigger(TriggerName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTrigger(new GetTriggerRequest
            {
                TriggerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single trigger.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the trigger to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Trigger> GetTriggerAsync(TriggerName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTriggerAsync(new GetTriggerRequest
            {
                TriggerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a single trigger.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the trigger to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Trigger> GetTriggerAsync(TriggerName name, st::CancellationToken cancellationToken) =>
            GetTriggerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List triggers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Trigger"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTriggersResponse, Trigger> ListTriggers(ListTriggersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List triggers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Trigger"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTriggersResponse, Trigger> ListTriggersAsync(ListTriggersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List triggers.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection to list triggers on.
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
        /// <returns>A pageable sequence of <see cref="Trigger"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTriggersResponse, Trigger> ListTriggers(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTriggers(new ListTriggersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List triggers.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection to list triggers on.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Trigger"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTriggersResponse, Trigger> ListTriggersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTriggersAsync(new ListTriggersRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List triggers.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection to list triggers on.
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
        /// <returns>A pageable sequence of <see cref="Trigger"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTriggersResponse, Trigger> ListTriggers(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTriggers(new ListTriggersRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List triggers.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection to list triggers on.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Trigger"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTriggersResponse, Trigger> ListTriggersAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTriggersAsync(new ListTriggersRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Create a new trigger in a particular project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Trigger, OperationMetadata> CreateTrigger(CreateTriggerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new trigger in a particular project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Trigger, OperationMetadata>> CreateTriggerAsync(CreateTriggerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new trigger in a particular project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Trigger, OperationMetadata>> CreateTriggerAsync(CreateTriggerRequest request, st::CancellationToken cancellationToken) =>
            CreateTriggerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateTrigger</c>.</summary>
        public virtual lro::OperationsClient CreateTriggerOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateTrigger</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Trigger, OperationMetadata> PollOnceCreateTrigger(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Trigger, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateTriggerOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateTrigger</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Trigger, OperationMetadata>> PollOnceCreateTriggerAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Trigger, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateTriggerOperationsClient, callSettings);

        /// <summary>
        /// Create a new trigger in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this trigger.
        /// </param>
        /// <param name="trigger">
        /// Required. The trigger to create.
        /// </param>
        /// <param name="triggerId">
        /// Required. The user-provided ID to be assigned to the trigger.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Trigger, OperationMetadata> CreateTrigger(string parent, Trigger trigger, string triggerId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTrigger(new CreateTriggerRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Trigger = gax::GaxPreconditions.CheckNotNull(trigger, nameof(trigger)),
                TriggerId = gax::GaxPreconditions.CheckNotNullOrEmpty(triggerId, nameof(triggerId)),
            }, callSettings);

        /// <summary>
        /// Create a new trigger in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this trigger.
        /// </param>
        /// <param name="trigger">
        /// Required. The trigger to create.
        /// </param>
        /// <param name="triggerId">
        /// Required. The user-provided ID to be assigned to the trigger.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Trigger, OperationMetadata>> CreateTriggerAsync(string parent, Trigger trigger, string triggerId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTriggerAsync(new CreateTriggerRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Trigger = gax::GaxPreconditions.CheckNotNull(trigger, nameof(trigger)),
                TriggerId = gax::GaxPreconditions.CheckNotNullOrEmpty(triggerId, nameof(triggerId)),
            }, callSettings);

        /// <summary>
        /// Create a new trigger in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this trigger.
        /// </param>
        /// <param name="trigger">
        /// Required. The trigger to create.
        /// </param>
        /// <param name="triggerId">
        /// Required. The user-provided ID to be assigned to the trigger.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Trigger, OperationMetadata>> CreateTriggerAsync(string parent, Trigger trigger, string triggerId, st::CancellationToken cancellationToken) =>
            CreateTriggerAsync(parent, trigger, triggerId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new trigger in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this trigger.
        /// </param>
        /// <param name="trigger">
        /// Required. The trigger to create.
        /// </param>
        /// <param name="triggerId">
        /// Required. The user-provided ID to be assigned to the trigger.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Trigger, OperationMetadata> CreateTrigger(gagr::LocationName parent, Trigger trigger, string triggerId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTrigger(new CreateTriggerRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Trigger = gax::GaxPreconditions.CheckNotNull(trigger, nameof(trigger)),
                TriggerId = gax::GaxPreconditions.CheckNotNullOrEmpty(triggerId, nameof(triggerId)),
            }, callSettings);

        /// <summary>
        /// Create a new trigger in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this trigger.
        /// </param>
        /// <param name="trigger">
        /// Required. The trigger to create.
        /// </param>
        /// <param name="triggerId">
        /// Required. The user-provided ID to be assigned to the trigger.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Trigger, OperationMetadata>> CreateTriggerAsync(gagr::LocationName parent, Trigger trigger, string triggerId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTriggerAsync(new CreateTriggerRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Trigger = gax::GaxPreconditions.CheckNotNull(trigger, nameof(trigger)),
                TriggerId = gax::GaxPreconditions.CheckNotNullOrEmpty(triggerId, nameof(triggerId)),
            }, callSettings);

        /// <summary>
        /// Create a new trigger in a particular project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which to add this trigger.
        /// </param>
        /// <param name="trigger">
        /// Required. The trigger to create.
        /// </param>
        /// <param name="triggerId">
        /// Required. The user-provided ID to be assigned to the trigger.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Trigger, OperationMetadata>> CreateTriggerAsync(gagr::LocationName parent, Trigger trigger, string triggerId, st::CancellationToken cancellationToken) =>
            CreateTriggerAsync(parent, trigger, triggerId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a single trigger.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Trigger, OperationMetadata> UpdateTrigger(UpdateTriggerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a single trigger.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Trigger, OperationMetadata>> UpdateTriggerAsync(UpdateTriggerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a single trigger.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Trigger, OperationMetadata>> UpdateTriggerAsync(UpdateTriggerRequest request, st::CancellationToken cancellationToken) =>
            UpdateTriggerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateTrigger</c>.</summary>
        public virtual lro::OperationsClient UpdateTriggerOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateTrigger</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Trigger, OperationMetadata> PollOnceUpdateTrigger(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Trigger, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateTriggerOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateTrigger</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Trigger, OperationMetadata>> PollOnceUpdateTriggerAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Trigger, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateTriggerOperationsClient, callSettings);

        /// <summary>
        /// Update a single trigger.
        /// </summary>
        /// <param name="trigger">
        /// The trigger to be updated.
        /// </param>
        /// <param name="updateMask">
        /// The fields to be updated; only fields explicitly provided will be updated.
        /// If no field mask is provided, all provided fields in the request will be
        /// updated. To update all fields, provide a field mask of "*".
        /// </param>
        /// <param name="allowMissing">
        /// If set to true, and the trigger is not found, a new trigger will be
        /// created. In this situation, `update_mask` is ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Trigger, OperationMetadata> UpdateTrigger(Trigger trigger, wkt::FieldMask updateMask, bool allowMissing, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTrigger(new UpdateTriggerRequest
            {
                Trigger = trigger,
                UpdateMask = updateMask,
                AllowMissing = allowMissing,
            }, callSettings);

        /// <summary>
        /// Update a single trigger.
        /// </summary>
        /// <param name="trigger">
        /// The trigger to be updated.
        /// </param>
        /// <param name="updateMask">
        /// The fields to be updated; only fields explicitly provided will be updated.
        /// If no field mask is provided, all provided fields in the request will be
        /// updated. To update all fields, provide a field mask of "*".
        /// </param>
        /// <param name="allowMissing">
        /// If set to true, and the trigger is not found, a new trigger will be
        /// created. In this situation, `update_mask` is ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Trigger, OperationMetadata>> UpdateTriggerAsync(Trigger trigger, wkt::FieldMask updateMask, bool allowMissing, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTriggerAsync(new UpdateTriggerRequest
            {
                Trigger = trigger,
                UpdateMask = updateMask,
                AllowMissing = allowMissing,
            }, callSettings);

        /// <summary>
        /// Update a single trigger.
        /// </summary>
        /// <param name="trigger">
        /// The trigger to be updated.
        /// </param>
        /// <param name="updateMask">
        /// The fields to be updated; only fields explicitly provided will be updated.
        /// If no field mask is provided, all provided fields in the request will be
        /// updated. To update all fields, provide a field mask of "*".
        /// </param>
        /// <param name="allowMissing">
        /// If set to true, and the trigger is not found, a new trigger will be
        /// created. In this situation, `update_mask` is ignored.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Trigger, OperationMetadata>> UpdateTriggerAsync(Trigger trigger, wkt::FieldMask updateMask, bool allowMissing, st::CancellationToken cancellationToken) =>
            UpdateTriggerAsync(trigger, updateMask, allowMissing, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single trigger.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Trigger, OperationMetadata> DeleteTrigger(DeleteTriggerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a single trigger.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Trigger, OperationMetadata>> DeleteTriggerAsync(DeleteTriggerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a single trigger.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Trigger, OperationMetadata>> DeleteTriggerAsync(DeleteTriggerRequest request, st::CancellationToken cancellationToken) =>
            DeleteTriggerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteTrigger</c>.</summary>
        public virtual lro::OperationsClient DeleteTriggerOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteTrigger</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Trigger, OperationMetadata> PollOnceDeleteTrigger(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Trigger, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteTriggerOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteTrigger</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Trigger, OperationMetadata>> PollOnceDeleteTriggerAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Trigger, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteTriggerOperationsClient, callSettings);

        /// <summary>
        /// Delete a single trigger.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the trigger to be deleted.
        /// </param>
        /// <param name="allowMissing">
        /// If set to true, and the trigger is not found, the request will succeed
        /// but no action will be taken on the server.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Trigger, OperationMetadata> DeleteTrigger(string name, bool allowMissing, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTrigger(new DeleteTriggerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                AllowMissing = allowMissing,
            }, callSettings);

        /// <summary>
        /// Delete a single trigger.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the trigger to be deleted.
        /// </param>
        /// <param name="allowMissing">
        /// If set to true, and the trigger is not found, the request will succeed
        /// but no action will be taken on the server.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Trigger, OperationMetadata>> DeleteTriggerAsync(string name, bool allowMissing, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTriggerAsync(new DeleteTriggerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                AllowMissing = allowMissing,
            }, callSettings);

        /// <summary>
        /// Delete a single trigger.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the trigger to be deleted.
        /// </param>
        /// <param name="allowMissing">
        /// If set to true, and the trigger is not found, the request will succeed
        /// but no action will be taken on the server.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Trigger, OperationMetadata>> DeleteTriggerAsync(string name, bool allowMissing, st::CancellationToken cancellationToken) =>
            DeleteTriggerAsync(name, allowMissing, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a single trigger.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the trigger to be deleted.
        /// </param>
        /// <param name="allowMissing">
        /// If set to true, and the trigger is not found, the request will succeed
        /// but no action will be taken on the server.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Trigger, OperationMetadata> DeleteTrigger(TriggerName name, bool allowMissing, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTrigger(new DeleteTriggerRequest
            {
                TriggerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                AllowMissing = allowMissing,
            }, callSettings);

        /// <summary>
        /// Delete a single trigger.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the trigger to be deleted.
        /// </param>
        /// <param name="allowMissing">
        /// If set to true, and the trigger is not found, the request will succeed
        /// but no action will be taken on the server.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Trigger, OperationMetadata>> DeleteTriggerAsync(TriggerName name, bool allowMissing, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTriggerAsync(new DeleteTriggerRequest
            {
                TriggerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                AllowMissing = allowMissing,
            }, callSettings);

        /// <summary>
        /// Delete a single trigger.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the trigger to be deleted.
        /// </param>
        /// <param name="allowMissing">
        /// If set to true, and the trigger is not found, the request will succeed
        /// but no action will be taken on the server.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Trigger, OperationMetadata>> DeleteTriggerAsync(TriggerName name, bool allowMissing, st::CancellationToken cancellationToken) =>
            DeleteTriggerAsync(name, allowMissing, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Eventarc client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Eventarc allows users to subscribe to various events that are provided by
    /// Google Cloud services and forward them to supported destinations.
    /// </remarks>
    public sealed partial class EventarcClientImpl : EventarcClient
    {
        private readonly gaxgrpc::ApiCall<GetTriggerRequest, Trigger> _callGetTrigger;

        private readonly gaxgrpc::ApiCall<ListTriggersRequest, ListTriggersResponse> _callListTriggers;

        private readonly gaxgrpc::ApiCall<CreateTriggerRequest, lro::Operation> _callCreateTrigger;

        private readonly gaxgrpc::ApiCall<UpdateTriggerRequest, lro::Operation> _callUpdateTrigger;

        private readonly gaxgrpc::ApiCall<DeleteTriggerRequest, lro::Operation> _callDeleteTrigger;

        /// <summary>
        /// Constructs a client wrapper for the Eventarc service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="EventarcSettings"/> used within this client.</param>
        public EventarcClientImpl(Eventarc.EventarcClient grpcClient, EventarcSettings settings)
        {
            GrpcClient = grpcClient;
            EventarcSettings effectiveSettings = settings ?? EventarcSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            CreateTriggerOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateTriggerOperationsSettings);
            UpdateTriggerOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateTriggerOperationsSettings);
            DeleteTriggerOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteTriggerOperationsSettings);
            _callGetTrigger = clientHelper.BuildApiCall<GetTriggerRequest, Trigger>(grpcClient.GetTriggerAsync, grpcClient.GetTrigger, effectiveSettings.GetTriggerSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTrigger);
            Modify_GetTriggerApiCall(ref _callGetTrigger);
            _callListTriggers = clientHelper.BuildApiCall<ListTriggersRequest, ListTriggersResponse>(grpcClient.ListTriggersAsync, grpcClient.ListTriggers, effectiveSettings.ListTriggersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTriggers);
            Modify_ListTriggersApiCall(ref _callListTriggers);
            _callCreateTrigger = clientHelper.BuildApiCall<CreateTriggerRequest, lro::Operation>(grpcClient.CreateTriggerAsync, grpcClient.CreateTrigger, effectiveSettings.CreateTriggerSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTrigger);
            Modify_CreateTriggerApiCall(ref _callCreateTrigger);
            _callUpdateTrigger = clientHelper.BuildApiCall<UpdateTriggerRequest, lro::Operation>(grpcClient.UpdateTriggerAsync, grpcClient.UpdateTrigger, effectiveSettings.UpdateTriggerSettings).WithGoogleRequestParam("trigger.name", request => request.Trigger?.Name);
            Modify_ApiCall(ref _callUpdateTrigger);
            Modify_UpdateTriggerApiCall(ref _callUpdateTrigger);
            _callDeleteTrigger = clientHelper.BuildApiCall<DeleteTriggerRequest, lro::Operation>(grpcClient.DeleteTriggerAsync, grpcClient.DeleteTrigger, effectiveSettings.DeleteTriggerSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTrigger);
            Modify_DeleteTriggerApiCall(ref _callDeleteTrigger);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetTriggerApiCall(ref gaxgrpc::ApiCall<GetTriggerRequest, Trigger> call);

        partial void Modify_ListTriggersApiCall(ref gaxgrpc::ApiCall<ListTriggersRequest, ListTriggersResponse> call);

        partial void Modify_CreateTriggerApiCall(ref gaxgrpc::ApiCall<CreateTriggerRequest, lro::Operation> call);

        partial void Modify_UpdateTriggerApiCall(ref gaxgrpc::ApiCall<UpdateTriggerRequest, lro::Operation> call);

        partial void Modify_DeleteTriggerApiCall(ref gaxgrpc::ApiCall<DeleteTriggerRequest, lro::Operation> call);

        partial void OnConstruction(Eventarc.EventarcClient grpcClient, EventarcSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Eventarc client</summary>
        public override Eventarc.EventarcClient GrpcClient { get; }

        partial void Modify_GetTriggerRequest(ref GetTriggerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTriggersRequest(ref ListTriggersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTriggerRequest(ref CreateTriggerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTriggerRequest(ref UpdateTriggerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTriggerRequest(ref DeleteTriggerRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Get a single trigger.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Trigger GetTrigger(GetTriggerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTriggerRequest(ref request, ref callSettings);
            return _callGetTrigger.Sync(request, callSettings);
        }

        /// <summary>
        /// Get a single trigger.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Trigger> GetTriggerAsync(GetTriggerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTriggerRequest(ref request, ref callSettings);
            return _callGetTrigger.Async(request, callSettings);
        }

        /// <summary>
        /// List triggers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Trigger"/> resources.</returns>
        public override gax::PagedEnumerable<ListTriggersResponse, Trigger> ListTriggers(ListTriggersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTriggersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTriggersRequest, ListTriggersResponse, Trigger>(_callListTriggers, request, callSettings);
        }

        /// <summary>
        /// List triggers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Trigger"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTriggersResponse, Trigger> ListTriggersAsync(ListTriggersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTriggersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTriggersRequest, ListTriggersResponse, Trigger>(_callListTriggers, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateTrigger</c>.</summary>
        public override lro::OperationsClient CreateTriggerOperationsClient { get; }

        /// <summary>
        /// Create a new trigger in a particular project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Trigger, OperationMetadata> CreateTrigger(CreateTriggerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTriggerRequest(ref request, ref callSettings);
            return new lro::Operation<Trigger, OperationMetadata>(_callCreateTrigger.Sync(request, callSettings), CreateTriggerOperationsClient);
        }

        /// <summary>
        /// Create a new trigger in a particular project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Trigger, OperationMetadata>> CreateTriggerAsync(CreateTriggerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTriggerRequest(ref request, ref callSettings);
            return new lro::Operation<Trigger, OperationMetadata>(await _callCreateTrigger.Async(request, callSettings).ConfigureAwait(false), CreateTriggerOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateTrigger</c>.</summary>
        public override lro::OperationsClient UpdateTriggerOperationsClient { get; }

        /// <summary>
        /// Update a single trigger.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Trigger, OperationMetadata> UpdateTrigger(UpdateTriggerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTriggerRequest(ref request, ref callSettings);
            return new lro::Operation<Trigger, OperationMetadata>(_callUpdateTrigger.Sync(request, callSettings), UpdateTriggerOperationsClient);
        }

        /// <summary>
        /// Update a single trigger.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Trigger, OperationMetadata>> UpdateTriggerAsync(UpdateTriggerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTriggerRequest(ref request, ref callSettings);
            return new lro::Operation<Trigger, OperationMetadata>(await _callUpdateTrigger.Async(request, callSettings).ConfigureAwait(false), UpdateTriggerOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteTrigger</c>.</summary>
        public override lro::OperationsClient DeleteTriggerOperationsClient { get; }

        /// <summary>
        /// Delete a single trigger.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Trigger, OperationMetadata> DeleteTrigger(DeleteTriggerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTriggerRequest(ref request, ref callSettings);
            return new lro::Operation<Trigger, OperationMetadata>(_callDeleteTrigger.Sync(request, callSettings), DeleteTriggerOperationsClient);
        }

        /// <summary>
        /// Delete a single trigger.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Trigger, OperationMetadata>> DeleteTriggerAsync(DeleteTriggerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTriggerRequest(ref request, ref callSettings);
            return new lro::Operation<Trigger, OperationMetadata>(await _callDeleteTrigger.Async(request, callSettings).ConfigureAwait(false), DeleteTriggerOperationsClient);
        }
    }

    public partial class ListTriggersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTriggersResponse : gaxgrpc::IPageResponse<Trigger>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Trigger> GetEnumerator() => Triggers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Eventarc
    {
        public partial class EventarcClient
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
}
