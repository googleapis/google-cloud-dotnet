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

namespace Google.Cloud.Compute.V1
{
    /// <summary>Settings for <see cref="AdviceClient"/> instances.</summary>
    public sealed partial class AdviceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AdviceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AdviceSettings"/>.</returns>
        public static AdviceSettings GetDefault() => new AdviceSettings();

        /// <summary>Constructs a new <see cref="AdviceSettings"/> object with default settings.</summary>
        public AdviceSettings()
        {
        }

        private AdviceSettings(AdviceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CalendarModeSettings = existing.CalendarModeSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AdviceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AdviceClient.CalendarMode</c>
        ///  and <c>AdviceClient.CalendarModeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CalendarModeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AdviceSettings"/> object.</returns>
        public AdviceSettings Clone() => new AdviceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AdviceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class AdviceClientBuilder : gaxgrpc::ClientBuilderBase<AdviceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AdviceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AdviceClientBuilder() : base(AdviceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AdviceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AdviceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AdviceClient Build()
        {
            AdviceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AdviceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AdviceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AdviceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AdviceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AdviceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AdviceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AdviceClient.ChannelPool;
    }

    /// <summary>Advice client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The Advice API.
    /// </remarks>
    public abstract partial class AdviceClient
    {
        /// <summary>
        /// The default endpoint for the Advice service, which is a host of "compute.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default Advice scopes.</summary>
        /// <remarks>
        /// The default Advice scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/compute</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/compute",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Advice.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AdviceClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="AdviceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AdviceClient"/>.</returns>
        public static stt::Task<AdviceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AdviceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AdviceClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="AdviceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AdviceClient"/>.</returns>
        public static AdviceClient Create() => new AdviceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AdviceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AdviceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AdviceClient"/>.</returns>
        internal static AdviceClient Create(grpccore::CallInvoker callInvoker, AdviceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Advice.AdviceClient grpcClient = new Advice.AdviceClient(callInvoker);
            return new AdviceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Advice client</summary>
        public virtual Advice.AdviceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Advise how, where and when to create the requested amount of instances
        /// with specified accelerators, within the specified time and location limits.
        /// The method recommends creating future reservations for the requested
        /// resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CalendarModeAdviceResponse CalendarMode(CalendarModeAdviceRpcRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Advise how, where and when to create the requested amount of instances
        /// with specified accelerators, within the specified time and location limits.
        /// The method recommends creating future reservations for the requested
        /// resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalendarModeAdviceResponse> CalendarModeAsync(CalendarModeAdviceRpcRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Advise how, where and when to create the requested amount of instances
        /// with specified accelerators, within the specified time and location limits.
        /// The method recommends creating future reservations for the requested
        /// resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalendarModeAdviceResponse> CalendarModeAsync(CalendarModeAdviceRpcRequest request, st::CancellationToken cancellationToken) =>
            CalendarModeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Advise how, where and when to create the requested amount of instances
        /// with specified accelerators, within the specified time and location limits.
        /// The method recommends creating future reservations for the requested
        /// resources.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="calendarModeAdviceRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CalendarModeAdviceResponse CalendarMode(string project, string region, CalendarModeAdviceRequest calendarModeAdviceRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            CalendarMode(new CalendarModeAdviceRpcRequest
            {
                CalendarModeAdviceRequestResource = gax::GaxPreconditions.CheckNotNull(calendarModeAdviceRequestResource, nameof(calendarModeAdviceRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Advise how, where and when to create the requested amount of instances
        /// with specified accelerators, within the specified time and location limits.
        /// The method recommends creating future reservations for the requested
        /// resources.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="calendarModeAdviceRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalendarModeAdviceResponse> CalendarModeAsync(string project, string region, CalendarModeAdviceRequest calendarModeAdviceRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            CalendarModeAsync(new CalendarModeAdviceRpcRequest
            {
                CalendarModeAdviceRequestResource = gax::GaxPreconditions.CheckNotNull(calendarModeAdviceRequestResource, nameof(calendarModeAdviceRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Advise how, where and when to create the requested amount of instances
        /// with specified accelerators, within the specified time and location limits.
        /// The method recommends creating future reservations for the requested
        /// resources.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="calendarModeAdviceRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalendarModeAdviceResponse> CalendarModeAsync(string project, string region, CalendarModeAdviceRequest calendarModeAdviceRequestResource, st::CancellationToken cancellationToken) =>
            CalendarModeAsync(project, region, calendarModeAdviceRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Advice client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The Advice API.
    /// </remarks>
    public sealed partial class AdviceClientImpl : AdviceClient
    {
        private readonly gaxgrpc::ApiCall<CalendarModeAdviceRpcRequest, CalendarModeAdviceResponse> _callCalendarMode;

        /// <summary>
        /// Constructs a client wrapper for the Advice service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AdviceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AdviceClientImpl(Advice.AdviceClient grpcClient, AdviceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AdviceSettings effectiveSettings = settings ?? AdviceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCalendarMode = clientHelper.BuildApiCall<CalendarModeAdviceRpcRequest, CalendarModeAdviceResponse>("CalendarMode", grpcClient.CalendarModeAsync, grpcClient.CalendarMode, effectiveSettings.CalendarModeSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region);
            Modify_ApiCall(ref _callCalendarMode);
            Modify_CalendarModeApiCall(ref _callCalendarMode);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CalendarModeApiCall(ref gaxgrpc::ApiCall<CalendarModeAdviceRpcRequest, CalendarModeAdviceResponse> call);

        partial void OnConstruction(Advice.AdviceClient grpcClient, AdviceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Advice client</summary>
        public override Advice.AdviceClient GrpcClient { get; }

        partial void Modify_CalendarModeAdviceRpcRequest(ref CalendarModeAdviceRpcRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Advise how, where and when to create the requested amount of instances
        /// with specified accelerators, within the specified time and location limits.
        /// The method recommends creating future reservations for the requested
        /// resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CalendarModeAdviceResponse CalendarMode(CalendarModeAdviceRpcRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CalendarModeAdviceRpcRequest(ref request, ref callSettings);
            return _callCalendarMode.Sync(request, callSettings);
        }

        /// <summary>
        /// Advise how, where and when to create the requested amount of instances
        /// with specified accelerators, within the specified time and location limits.
        /// The method recommends creating future reservations for the requested
        /// resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CalendarModeAdviceResponse> CalendarModeAsync(CalendarModeAdviceRpcRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CalendarModeAdviceRpcRequest(ref request, ref callSettings);
            return _callCalendarMode.Async(request, callSettings);
        }
    }
}
