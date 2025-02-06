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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.CloudQuotas.V1Beta
{
    /// <summary>Settings for <see cref="QuotaAdjusterSettingsManagerClient"/> instances.</summary>
    public sealed partial class QuotaAdjusterSettingsManagerSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="QuotaAdjusterSettingsManagerSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="QuotaAdjusterSettingsManagerSettings"/>.</returns>
        public static QuotaAdjusterSettingsManagerSettings GetDefault() => new QuotaAdjusterSettingsManagerSettings();

        /// <summary>
        /// Constructs a new <see cref="QuotaAdjusterSettingsManagerSettings"/> object with default settings.
        /// </summary>
        public QuotaAdjusterSettingsManagerSettings()
        {
        }

        private QuotaAdjusterSettingsManagerSettings(QuotaAdjusterSettingsManagerSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            UpdateQuotaAdjusterSettingsSettings = existing.UpdateQuotaAdjusterSettingsSettings;
            GetQuotaAdjusterSettingsSettings = existing.GetQuotaAdjusterSettingsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(QuotaAdjusterSettingsManagerSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>QuotaAdjusterSettingsManagerClient.UpdateQuotaAdjusterSettings</c> and
        /// <c>QuotaAdjusterSettingsManagerClient.UpdateQuotaAdjusterSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateQuotaAdjusterSettingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>QuotaAdjusterSettingsManagerClient.GetQuotaAdjusterSettings</c> and
        /// <c>QuotaAdjusterSettingsManagerClient.GetQuotaAdjusterSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetQuotaAdjusterSettingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="QuotaAdjusterSettingsManagerSettings"/> object.</returns>
        public QuotaAdjusterSettingsManagerSettings Clone() => new QuotaAdjusterSettingsManagerSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="QuotaAdjusterSettingsManagerClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class QuotaAdjusterSettingsManagerClientBuilder : gaxgrpc::ClientBuilderBase<QuotaAdjusterSettingsManagerClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public QuotaAdjusterSettingsManagerSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public QuotaAdjusterSettingsManagerClientBuilder() : base(QuotaAdjusterSettingsManagerClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref QuotaAdjusterSettingsManagerClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<QuotaAdjusterSettingsManagerClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override QuotaAdjusterSettingsManagerClient Build()
        {
            QuotaAdjusterSettingsManagerClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<QuotaAdjusterSettingsManagerClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<QuotaAdjusterSettingsManagerClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private QuotaAdjusterSettingsManagerClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return QuotaAdjusterSettingsManagerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<QuotaAdjusterSettingsManagerClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return QuotaAdjusterSettingsManagerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => QuotaAdjusterSettingsManagerClient.ChannelPool;
    }

    /// <summary>QuotaAdjusterSettingsManager client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The Quotas Adjuster Settings API is an infrastructure service for Google
    /// Cloud that lets service consumers view and update their quota adjuster
    /// settings.
    /// 
    /// - Update quota adjuster settings.
    /// - Get the name of the configurations.
    /// </remarks>
    public abstract partial class QuotaAdjusterSettingsManagerClient
    {
        /// <summary>
        /// The default endpoint for the QuotaAdjusterSettingsManager service, which is a host of
        /// "cloudquotas.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudquotas.googleapis.com:443";

        /// <summary>The default QuotaAdjusterSettingsManager scopes.</summary>
        /// <remarks>
        /// The default QuotaAdjusterSettingsManager scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(QuotaAdjusterSettingsManager.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="QuotaAdjusterSettingsManagerClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="QuotaAdjusterSettingsManagerClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="QuotaAdjusterSettingsManagerClient"/>.</returns>
        public static stt::Task<QuotaAdjusterSettingsManagerClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new QuotaAdjusterSettingsManagerClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="QuotaAdjusterSettingsManagerClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="QuotaAdjusterSettingsManagerClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="QuotaAdjusterSettingsManagerClient"/>.</returns>
        public static QuotaAdjusterSettingsManagerClient Create() => new QuotaAdjusterSettingsManagerClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="QuotaAdjusterSettingsManagerClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="QuotaAdjusterSettingsManagerSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="QuotaAdjusterSettingsManagerClient"/>.</returns>
        internal static QuotaAdjusterSettingsManagerClient Create(grpccore::CallInvoker callInvoker, QuotaAdjusterSettingsManagerSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            QuotaAdjusterSettingsManager.QuotaAdjusterSettingsManagerClient grpcClient = new QuotaAdjusterSettingsManager.QuotaAdjusterSettingsManagerClient(callInvoker);
            return new QuotaAdjusterSettingsManagerClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC QuotaAdjusterSettingsManager client</summary>
        public virtual QuotaAdjusterSettingsManager.QuotaAdjusterSettingsManagerClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// RPC Method for updating QuotaAdjusterSettings based on the request
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QuotaAdjusterSettings UpdateQuotaAdjusterSettings(UpdateQuotaAdjusterSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// RPC Method for updating QuotaAdjusterSettings based on the request
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuotaAdjusterSettings> UpdateQuotaAdjusterSettingsAsync(UpdateQuotaAdjusterSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// RPC Method for updating QuotaAdjusterSettings based on the request
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuotaAdjusterSettings> UpdateQuotaAdjusterSettingsAsync(UpdateQuotaAdjusterSettingsRequest request, st::CancellationToken cancellationToken) =>
            UpdateQuotaAdjusterSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// RPC Method for updating QuotaAdjusterSettings based on the request
        /// </summary>
        /// <param name="quotaAdjusterSettings">
        /// Required. The QuotaAdjusterSettings to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QuotaAdjusterSettings UpdateQuotaAdjusterSettings(QuotaAdjusterSettings quotaAdjusterSettings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateQuotaAdjusterSettings(new UpdateQuotaAdjusterSettingsRequest
            {
                QuotaAdjusterSettings = gax::GaxPreconditions.CheckNotNull(quotaAdjusterSettings, nameof(quotaAdjusterSettings)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// RPC Method for updating QuotaAdjusterSettings based on the request
        /// </summary>
        /// <param name="quotaAdjusterSettings">
        /// Required. The QuotaAdjusterSettings to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuotaAdjusterSettings> UpdateQuotaAdjusterSettingsAsync(QuotaAdjusterSettings quotaAdjusterSettings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateQuotaAdjusterSettingsAsync(new UpdateQuotaAdjusterSettingsRequest
            {
                QuotaAdjusterSettings = gax::GaxPreconditions.CheckNotNull(quotaAdjusterSettings, nameof(quotaAdjusterSettings)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// RPC Method for updating QuotaAdjusterSettings based on the request
        /// </summary>
        /// <param name="quotaAdjusterSettings">
        /// Required. The QuotaAdjusterSettings to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuotaAdjusterSettings> UpdateQuotaAdjusterSettingsAsync(QuotaAdjusterSettings quotaAdjusterSettings, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateQuotaAdjusterSettingsAsync(quotaAdjusterSettings, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// RPC Method for getting QuotaAdjusterSettings based on the request
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QuotaAdjusterSettings GetQuotaAdjusterSettings(GetQuotaAdjusterSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// RPC Method for getting QuotaAdjusterSettings based on the request
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuotaAdjusterSettings> GetQuotaAdjusterSettingsAsync(GetQuotaAdjusterSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// RPC Method for getting QuotaAdjusterSettings based on the request
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuotaAdjusterSettings> GetQuotaAdjusterSettingsAsync(GetQuotaAdjusterSettingsRequest request, st::CancellationToken cancellationToken) =>
            GetQuotaAdjusterSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// RPC Method for getting QuotaAdjusterSettings based on the request
        /// </summary>
        /// <param name="name">
        /// Required. Name of the config. Required to be “settings”, as only a single
        /// setting per container will be supported initially.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QuotaAdjusterSettings GetQuotaAdjusterSettings(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetQuotaAdjusterSettings(new GetQuotaAdjusterSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// RPC Method for getting QuotaAdjusterSettings based on the request
        /// </summary>
        /// <param name="name">
        /// Required. Name of the config. Required to be “settings”, as only a single
        /// setting per container will be supported initially.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuotaAdjusterSettings> GetQuotaAdjusterSettingsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetQuotaAdjusterSettingsAsync(new GetQuotaAdjusterSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// RPC Method for getting QuotaAdjusterSettings based on the request
        /// </summary>
        /// <param name="name">
        /// Required. Name of the config. Required to be “settings”, as only a single
        /// setting per container will be supported initially.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuotaAdjusterSettings> GetQuotaAdjusterSettingsAsync(string name, st::CancellationToken cancellationToken) =>
            GetQuotaAdjusterSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// RPC Method for getting QuotaAdjusterSettings based on the request
        /// </summary>
        /// <param name="name">
        /// Required. Name of the config. Required to be “settings”, as only a single
        /// setting per container will be supported initially.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QuotaAdjusterSettings GetQuotaAdjusterSettings(QuotaAdjusterSettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetQuotaAdjusterSettings(new GetQuotaAdjusterSettingsRequest
            {
                QuotaAdjusterSettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// RPC Method for getting QuotaAdjusterSettings based on the request
        /// </summary>
        /// <param name="name">
        /// Required. Name of the config. Required to be “settings”, as only a single
        /// setting per container will be supported initially.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuotaAdjusterSettings> GetQuotaAdjusterSettingsAsync(QuotaAdjusterSettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetQuotaAdjusterSettingsAsync(new GetQuotaAdjusterSettingsRequest
            {
                QuotaAdjusterSettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// RPC Method for getting QuotaAdjusterSettings based on the request
        /// </summary>
        /// <param name="name">
        /// Required. Name of the config. Required to be “settings”, as only a single
        /// setting per container will be supported initially.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuotaAdjusterSettings> GetQuotaAdjusterSettingsAsync(QuotaAdjusterSettingsName name, st::CancellationToken cancellationToken) =>
            GetQuotaAdjusterSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>QuotaAdjusterSettingsManager client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The Quotas Adjuster Settings API is an infrastructure service for Google
    /// Cloud that lets service consumers view and update their quota adjuster
    /// settings.
    /// 
    /// - Update quota adjuster settings.
    /// - Get the name of the configurations.
    /// </remarks>
    public sealed partial class QuotaAdjusterSettingsManagerClientImpl : QuotaAdjusterSettingsManagerClient
    {
        private readonly gaxgrpc::ApiCall<UpdateQuotaAdjusterSettingsRequest, QuotaAdjusterSettings> _callUpdateQuotaAdjusterSettings;

        private readonly gaxgrpc::ApiCall<GetQuotaAdjusterSettingsRequest, QuotaAdjusterSettings> _callGetQuotaAdjusterSettings;

        /// <summary>
        /// Constructs a client wrapper for the QuotaAdjusterSettingsManager service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="QuotaAdjusterSettingsManagerSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public QuotaAdjusterSettingsManagerClientImpl(QuotaAdjusterSettingsManager.QuotaAdjusterSettingsManagerClient grpcClient, QuotaAdjusterSettingsManagerSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            QuotaAdjusterSettingsManagerSettings effectiveSettings = settings ?? QuotaAdjusterSettingsManagerSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callUpdateQuotaAdjusterSettings = clientHelper.BuildApiCall<UpdateQuotaAdjusterSettingsRequest, QuotaAdjusterSettings>("UpdateQuotaAdjusterSettings", grpcClient.UpdateQuotaAdjusterSettingsAsync, grpcClient.UpdateQuotaAdjusterSettings, effectiveSettings.UpdateQuotaAdjusterSettingsSettings).WithGoogleRequestParam("quota_adjuster_settings.name", request => request.QuotaAdjusterSettings?.Name);
            Modify_ApiCall(ref _callUpdateQuotaAdjusterSettings);
            Modify_UpdateQuotaAdjusterSettingsApiCall(ref _callUpdateQuotaAdjusterSettings);
            _callGetQuotaAdjusterSettings = clientHelper.BuildApiCall<GetQuotaAdjusterSettingsRequest, QuotaAdjusterSettings>("GetQuotaAdjusterSettings", grpcClient.GetQuotaAdjusterSettingsAsync, grpcClient.GetQuotaAdjusterSettings, effectiveSettings.GetQuotaAdjusterSettingsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetQuotaAdjusterSettings);
            Modify_GetQuotaAdjusterSettingsApiCall(ref _callGetQuotaAdjusterSettings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_UpdateQuotaAdjusterSettingsApiCall(ref gaxgrpc::ApiCall<UpdateQuotaAdjusterSettingsRequest, QuotaAdjusterSettings> call);

        partial void Modify_GetQuotaAdjusterSettingsApiCall(ref gaxgrpc::ApiCall<GetQuotaAdjusterSettingsRequest, QuotaAdjusterSettings> call);

        partial void OnConstruction(QuotaAdjusterSettingsManager.QuotaAdjusterSettingsManagerClient grpcClient, QuotaAdjusterSettingsManagerSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC QuotaAdjusterSettingsManager client</summary>
        public override QuotaAdjusterSettingsManager.QuotaAdjusterSettingsManagerClient GrpcClient { get; }

        partial void Modify_UpdateQuotaAdjusterSettingsRequest(ref UpdateQuotaAdjusterSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetQuotaAdjusterSettingsRequest(ref GetQuotaAdjusterSettingsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// RPC Method for updating QuotaAdjusterSettings based on the request
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override QuotaAdjusterSettings UpdateQuotaAdjusterSettings(UpdateQuotaAdjusterSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateQuotaAdjusterSettingsRequest(ref request, ref callSettings);
            return _callUpdateQuotaAdjusterSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// RPC Method for updating QuotaAdjusterSettings based on the request
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<QuotaAdjusterSettings> UpdateQuotaAdjusterSettingsAsync(UpdateQuotaAdjusterSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateQuotaAdjusterSettingsRequest(ref request, ref callSettings);
            return _callUpdateQuotaAdjusterSettings.Async(request, callSettings);
        }

        /// <summary>
        /// RPC Method for getting QuotaAdjusterSettings based on the request
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override QuotaAdjusterSettings GetQuotaAdjusterSettings(GetQuotaAdjusterSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetQuotaAdjusterSettingsRequest(ref request, ref callSettings);
            return _callGetQuotaAdjusterSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// RPC Method for getting QuotaAdjusterSettings based on the request
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<QuotaAdjusterSettings> GetQuotaAdjusterSettingsAsync(GetQuotaAdjusterSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetQuotaAdjusterSettingsRequest(ref request, ref callSettings);
            return _callGetQuotaAdjusterSettings.Async(request, callSettings);
        }
    }
}
