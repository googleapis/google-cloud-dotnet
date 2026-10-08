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
    /// <summary>Settings for <see cref="GlobalFrontendSettingsServiceClient"/> instances.</summary>
    public sealed partial class GlobalFrontendSettingsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="GlobalFrontendSettingsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="GlobalFrontendSettingsServiceSettings"/>.</returns>
        public static GlobalFrontendSettingsServiceSettings GetDefault() => new GlobalFrontendSettingsServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="GlobalFrontendSettingsServiceSettings"/> object with default settings.
        /// </summary>
        public GlobalFrontendSettingsServiceSettings()
        {
        }

        private GlobalFrontendSettingsServiceSettings(GlobalFrontendSettingsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetSettings = existing.GetSettings;
            PatchSettings = existing.PatchSettings;
            OnCopy(existing);
        }

        partial void OnCopy(GlobalFrontendSettingsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GlobalFrontendSettingsServiceClient.Get</c> and <c>GlobalFrontendSettingsServiceClient.GetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GlobalFrontendSettingsServiceClient.Patch</c> and <c>GlobalFrontendSettingsServiceClient.PatchAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PatchSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="GlobalFrontendSettingsServiceSettings"/> object.</returns>
        public GlobalFrontendSettingsServiceSettings Clone() => new GlobalFrontendSettingsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="GlobalFrontendSettingsServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class GlobalFrontendSettingsServiceClientBuilder : gaxgrpc::ClientBuilderBase<GlobalFrontendSettingsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public GlobalFrontendSettingsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public GlobalFrontendSettingsServiceClientBuilder() : base(GlobalFrontendSettingsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref GlobalFrontendSettingsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<GlobalFrontendSettingsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override GlobalFrontendSettingsServiceClient Build()
        {
            GlobalFrontendSettingsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<GlobalFrontendSettingsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<GlobalFrontendSettingsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private GlobalFrontendSettingsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return GlobalFrontendSettingsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<GlobalFrontendSettingsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return GlobalFrontendSettingsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => GlobalFrontendSettingsServiceClient.ChannelPool;
    }

    /// <summary>
    /// GlobalFrontendSettingsService client wrapper, for convenient use. This client implements API version 2026-09-01.
    /// </summary>
    /// <remarks>
    /// The GlobalFrontendSettings API.
    /// </remarks>
    public abstract partial class GlobalFrontendSettingsServiceClient
    {
        /// <summary>
        /// The default endpoint for the GlobalFrontendSettingsService service, which is a host of
        /// "compute.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default GlobalFrontendSettingsService scopes.</summary>
        /// <remarks>
        /// The default GlobalFrontendSettingsService scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(GlobalFrontendSettingsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="GlobalFrontendSettingsServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="GlobalFrontendSettingsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="GlobalFrontendSettingsServiceClient"/>.</returns>
        public static stt::Task<GlobalFrontendSettingsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new GlobalFrontendSettingsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="GlobalFrontendSettingsServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="GlobalFrontendSettingsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="GlobalFrontendSettingsServiceClient"/>.</returns>
        public static GlobalFrontendSettingsServiceClient Create() =>
            new GlobalFrontendSettingsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="GlobalFrontendSettingsServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="GlobalFrontendSettingsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="GlobalFrontendSettingsServiceClient"/>.</returns>
        internal static GlobalFrontendSettingsServiceClient Create(grpccore::CallInvoker callInvoker, GlobalFrontendSettingsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            GlobalFrontendSettingsService.GlobalFrontendSettingsServiceClient grpcClient = new GlobalFrontendSettingsService.GlobalFrontendSettingsServiceClient(callInvoker);
            return new GlobalFrontendSettingsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC GlobalFrontendSettingsService client</summary>
        public virtual GlobalFrontendSettingsService.GlobalFrontendSettingsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the Global Frontend Billing Bundle Settings for a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GlobalFrontendSettings Get(GetGlobalFrontendSettingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the Global Frontend Billing Bundle Settings for a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlobalFrontendSettings> GetAsync(GetGlobalFrontendSettingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the Global Frontend Billing Bundle Settings for a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlobalFrontendSettings> GetAsync(GetGlobalFrontendSettingRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the Global Frontend Billing Bundle Settings for a project.
        /// </summary>
        /// <param name="project">
        /// Required. Project ID for this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GlobalFrontendSettings Get(string project, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetGlobalFrontendSettingRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Gets the Global Frontend Billing Bundle Settings for a project.
        /// </summary>
        /// <param name="project">
        /// Required. Project ID for this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlobalFrontendSettings> GetAsync(string project, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetGlobalFrontendSettingRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Gets the Global Frontend Billing Bundle Settings for a project.
        /// </summary>
        /// <param name="project">
        /// Required. Project ID for this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlobalFrontendSettings> GetAsync(string project, st::CancellationToken cancellationToken) =>
            GetAsync(project, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the Global Frontend Billing Bundle Settings for a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GlobalFrontendSettingsPatchResponse Patch(PatchGlobalFrontendSettingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Global Frontend Billing Bundle Settings for a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlobalFrontendSettingsPatchResponse> PatchAsync(PatchGlobalFrontendSettingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Global Frontend Billing Bundle Settings for a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlobalFrontendSettingsPatchResponse> PatchAsync(PatchGlobalFrontendSettingRequest request, st::CancellationToken cancellationToken) =>
            PatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the Global Frontend Billing Bundle Settings for a project.
        /// </summary>
        /// <param name="project">
        /// Required. Project ID for this request.
        /// </param>
        /// <param name="globalFrontendSettingsResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GlobalFrontendSettingsPatchResponse Patch(string project, GlobalFrontendSettings globalFrontendSettingsResource, gaxgrpc::CallSettings callSettings = null) =>
            Patch(new PatchGlobalFrontendSettingRequest
            {
                GlobalFrontendSettingsResource = gax::GaxPreconditions.CheckNotNull(globalFrontendSettingsResource, nameof(globalFrontendSettingsResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Updates the Global Frontend Billing Bundle Settings for a project.
        /// </summary>
        /// <param name="project">
        /// Required. Project ID for this request.
        /// </param>
        /// <param name="globalFrontendSettingsResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlobalFrontendSettingsPatchResponse> PatchAsync(string project, GlobalFrontendSettings globalFrontendSettingsResource, gaxgrpc::CallSettings callSettings = null) =>
            PatchAsync(new PatchGlobalFrontendSettingRequest
            {
                GlobalFrontendSettingsResource = gax::GaxPreconditions.CheckNotNull(globalFrontendSettingsResource, nameof(globalFrontendSettingsResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Updates the Global Frontend Billing Bundle Settings for a project.
        /// </summary>
        /// <param name="project">
        /// Required. Project ID for this request.
        /// </param>
        /// <param name="globalFrontendSettingsResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlobalFrontendSettingsPatchResponse> PatchAsync(string project, GlobalFrontendSettings globalFrontendSettingsResource, st::CancellationToken cancellationToken) =>
            PatchAsync(project, globalFrontendSettingsResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>GlobalFrontendSettingsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The GlobalFrontendSettings API.
    /// </remarks>
    public sealed partial class GlobalFrontendSettingsServiceClientImpl : GlobalFrontendSettingsServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetGlobalFrontendSettingRequest, GlobalFrontendSettings> _callGet;

        private readonly gaxgrpc::ApiCall<PatchGlobalFrontendSettingRequest, GlobalFrontendSettingsPatchResponse> _callPatch;

        /// <summary>
        /// Constructs a client wrapper for the GlobalFrontendSettingsService service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="GlobalFrontendSettingsServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public GlobalFrontendSettingsServiceClientImpl(GlobalFrontendSettingsService.GlobalFrontendSettingsServiceClient grpcClient, GlobalFrontendSettingsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            GlobalFrontendSettingsServiceSettings effectiveSettings = settings ?? GlobalFrontendSettingsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
                ApiVersion = "2026-09-01",
            });
            _callGet = clientHelper.BuildApiCall<GetGlobalFrontendSettingRequest, GlobalFrontendSettings>("Get", grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callPatch = clientHelper.BuildApiCall<PatchGlobalFrontendSettingRequest, GlobalFrontendSettingsPatchResponse>("Patch", grpcClient.PatchAsync, grpcClient.Patch, effectiveSettings.PatchSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callPatch);
            Modify_PatchApiCall(ref _callPatch);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetGlobalFrontendSettingRequest, GlobalFrontendSettings> call);

        partial void Modify_PatchApiCall(ref gaxgrpc::ApiCall<PatchGlobalFrontendSettingRequest, GlobalFrontendSettingsPatchResponse> call);

        partial void OnConstruction(GlobalFrontendSettingsService.GlobalFrontendSettingsServiceClient grpcClient, GlobalFrontendSettingsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC GlobalFrontendSettingsService client</summary>
        public override GlobalFrontendSettingsService.GlobalFrontendSettingsServiceClient GrpcClient { get; }

        partial void Modify_GetGlobalFrontendSettingRequest(ref GetGlobalFrontendSettingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PatchGlobalFrontendSettingRequest(ref PatchGlobalFrontendSettingRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets the Global Frontend Billing Bundle Settings for a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GlobalFrontendSettings Get(GetGlobalFrontendSettingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGlobalFrontendSettingRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the Global Frontend Billing Bundle Settings for a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GlobalFrontendSettings> GetAsync(GetGlobalFrontendSettingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGlobalFrontendSettingRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the Global Frontend Billing Bundle Settings for a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GlobalFrontendSettingsPatchResponse Patch(PatchGlobalFrontendSettingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchGlobalFrontendSettingRequest(ref request, ref callSettings);
            return _callPatch.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the Global Frontend Billing Bundle Settings for a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GlobalFrontendSettingsPatchResponse> PatchAsync(PatchGlobalFrontendSettingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchGlobalFrontendSettingRequest(ref request, ref callSettings);
            return _callPatch.Async(request, callSettings);
        }
    }
}
