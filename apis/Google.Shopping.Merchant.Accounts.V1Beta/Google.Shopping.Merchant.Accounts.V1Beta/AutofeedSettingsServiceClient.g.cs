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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Shopping.Merchant.Accounts.V1Beta
{
    /// <summary>Settings for <see cref="AutofeedSettingsServiceClient"/> instances.</summary>
    public sealed partial class AutofeedSettingsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AutofeedSettingsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AutofeedSettingsServiceSettings"/>.</returns>
        public static AutofeedSettingsServiceSettings GetDefault() => new AutofeedSettingsServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AutofeedSettingsServiceSettings"/> object with default settings.
        /// </summary>
        public AutofeedSettingsServiceSettings()
        {
        }

        private AutofeedSettingsServiceSettings(AutofeedSettingsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetAutofeedSettingsSettings = existing.GetAutofeedSettingsSettings;
            UpdateAutofeedSettingsSettings = existing.UpdateAutofeedSettingsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AutofeedSettingsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AutofeedSettingsServiceClient.GetAutofeedSettings</c> and
        /// <c>AutofeedSettingsServiceClient.GetAutofeedSettingsAsync</c>.
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
        public gaxgrpc::CallSettings GetAutofeedSettingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AutofeedSettingsServiceClient.UpdateAutofeedSettings</c> and
        /// <c>AutofeedSettingsServiceClient.UpdateAutofeedSettingsAsync</c>.
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
        public gaxgrpc::CallSettings UpdateAutofeedSettingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AutofeedSettingsServiceSettings"/> object.</returns>
        public AutofeedSettingsServiceSettings Clone() => new AutofeedSettingsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AutofeedSettingsServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class AutofeedSettingsServiceClientBuilder : gaxgrpc::ClientBuilderBase<AutofeedSettingsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AutofeedSettingsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AutofeedSettingsServiceClientBuilder() : base(AutofeedSettingsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AutofeedSettingsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AutofeedSettingsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AutofeedSettingsServiceClient Build()
        {
            AutofeedSettingsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AutofeedSettingsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AutofeedSettingsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AutofeedSettingsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AutofeedSettingsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AutofeedSettingsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AutofeedSettingsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AutofeedSettingsServiceClient.ChannelPool;
    }

    /// <summary>AutofeedSettingsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to support
    /// [autofeed](https://support.google.com/merchants/answer/7538732) setting.
    /// </remarks>
    public abstract partial class AutofeedSettingsServiceClient
    {
        /// <summary>
        /// The default endpoint for the AutofeedSettingsService service, which is a host of
        /// "merchantapi.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default AutofeedSettingsService scopes.</summary>
        /// <remarks>
        /// The default AutofeedSettingsService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AutofeedSettingsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AutofeedSettingsServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AutofeedSettingsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AutofeedSettingsServiceClient"/>.</returns>
        public static stt::Task<AutofeedSettingsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AutofeedSettingsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AutofeedSettingsServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AutofeedSettingsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AutofeedSettingsServiceClient"/>.</returns>
        public static AutofeedSettingsServiceClient Create() => new AutofeedSettingsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AutofeedSettingsServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AutofeedSettingsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AutofeedSettingsServiceClient"/>.</returns>
        internal static AutofeedSettingsServiceClient Create(grpccore::CallInvoker callInvoker, AutofeedSettingsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AutofeedSettingsService.AutofeedSettingsServiceClient grpcClient = new AutofeedSettingsService.AutofeedSettingsServiceClient(callInvoker);
            return new AutofeedSettingsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AutofeedSettingsService client</summary>
        public virtual AutofeedSettingsService.AutofeedSettingsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the autofeed settings of an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AutofeedSettings GetAutofeedSettings(GetAutofeedSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the autofeed settings of an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutofeedSettings> GetAutofeedSettingsAsync(GetAutofeedSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the autofeed settings of an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutofeedSettings> GetAutofeedSettingsAsync(GetAutofeedSettingsRequest request, st::CancellationToken cancellationToken) =>
            GetAutofeedSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the autofeed settings of an account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the autofeed settings.
        /// Format: `accounts/{account}/autofeedSettings`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AutofeedSettings GetAutofeedSettings(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAutofeedSettings(new GetAutofeedSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the autofeed settings of an account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the autofeed settings.
        /// Format: `accounts/{account}/autofeedSettings`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutofeedSettings> GetAutofeedSettingsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAutofeedSettingsAsync(new GetAutofeedSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the autofeed settings of an account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the autofeed settings.
        /// Format: `accounts/{account}/autofeedSettings`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutofeedSettings> GetAutofeedSettingsAsync(string name, st::CancellationToken cancellationToken) =>
            GetAutofeedSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the autofeed settings of an account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the autofeed settings.
        /// Format: `accounts/{account}/autofeedSettings`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AutofeedSettings GetAutofeedSettings(AutofeedSettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAutofeedSettings(new GetAutofeedSettingsRequest
            {
                AutofeedSettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the autofeed settings of an account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the autofeed settings.
        /// Format: `accounts/{account}/autofeedSettings`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutofeedSettings> GetAutofeedSettingsAsync(AutofeedSettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAutofeedSettingsAsync(new GetAutofeedSettingsRequest
            {
                AutofeedSettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the autofeed settings of an account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the autofeed settings.
        /// Format: `accounts/{account}/autofeedSettings`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutofeedSettings> GetAutofeedSettingsAsync(AutofeedSettingsName name, st::CancellationToken cancellationToken) =>
            GetAutofeedSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the autofeed settings of an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AutofeedSettings UpdateAutofeedSettings(UpdateAutofeedSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the autofeed settings of an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutofeedSettings> UpdateAutofeedSettingsAsync(UpdateAutofeedSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the autofeed settings of an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutofeedSettings> UpdateAutofeedSettingsAsync(UpdateAutofeedSettingsRequest request, st::CancellationToken cancellationToken) =>
            UpdateAutofeedSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the autofeed settings of an account.
        /// </summary>
        /// <param name="autofeedSettings">
        /// Required. The new version of the autofeed setting.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields being updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AutofeedSettings UpdateAutofeedSettings(AutofeedSettings autofeedSettings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAutofeedSettings(new UpdateAutofeedSettingsRequest
            {
                AutofeedSettings = gax::GaxPreconditions.CheckNotNull(autofeedSettings, nameof(autofeedSettings)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the autofeed settings of an account.
        /// </summary>
        /// <param name="autofeedSettings">
        /// Required. The new version of the autofeed setting.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields being updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutofeedSettings> UpdateAutofeedSettingsAsync(AutofeedSettings autofeedSettings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAutofeedSettingsAsync(new UpdateAutofeedSettingsRequest
            {
                AutofeedSettings = gax::GaxPreconditions.CheckNotNull(autofeedSettings, nameof(autofeedSettings)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the autofeed settings of an account.
        /// </summary>
        /// <param name="autofeedSettings">
        /// Required. The new version of the autofeed setting.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields being updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutofeedSettings> UpdateAutofeedSettingsAsync(AutofeedSettings autofeedSettings, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAutofeedSettingsAsync(autofeedSettings, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AutofeedSettingsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to support
    /// [autofeed](https://support.google.com/merchants/answer/7538732) setting.
    /// </remarks>
    public sealed partial class AutofeedSettingsServiceClientImpl : AutofeedSettingsServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetAutofeedSettingsRequest, AutofeedSettings> _callGetAutofeedSettings;

        private readonly gaxgrpc::ApiCall<UpdateAutofeedSettingsRequest, AutofeedSettings> _callUpdateAutofeedSettings;

        /// <summary>
        /// Constructs a client wrapper for the AutofeedSettingsService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="AutofeedSettingsServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AutofeedSettingsServiceClientImpl(AutofeedSettingsService.AutofeedSettingsServiceClient grpcClient, AutofeedSettingsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AutofeedSettingsServiceSettings effectiveSettings = settings ?? AutofeedSettingsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetAutofeedSettings = clientHelper.BuildApiCall<GetAutofeedSettingsRequest, AutofeedSettings>("GetAutofeedSettings", grpcClient.GetAutofeedSettingsAsync, grpcClient.GetAutofeedSettings, effectiveSettings.GetAutofeedSettingsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAutofeedSettings);
            Modify_GetAutofeedSettingsApiCall(ref _callGetAutofeedSettings);
            _callUpdateAutofeedSettings = clientHelper.BuildApiCall<UpdateAutofeedSettingsRequest, AutofeedSettings>("UpdateAutofeedSettings", grpcClient.UpdateAutofeedSettingsAsync, grpcClient.UpdateAutofeedSettings, effectiveSettings.UpdateAutofeedSettingsSettings).WithGoogleRequestParam("autofeed_settings.name", request => request.AutofeedSettings?.Name);
            Modify_ApiCall(ref _callUpdateAutofeedSettings);
            Modify_UpdateAutofeedSettingsApiCall(ref _callUpdateAutofeedSettings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetAutofeedSettingsApiCall(ref gaxgrpc::ApiCall<GetAutofeedSettingsRequest, AutofeedSettings> call);

        partial void Modify_UpdateAutofeedSettingsApiCall(ref gaxgrpc::ApiCall<UpdateAutofeedSettingsRequest, AutofeedSettings> call);

        partial void OnConstruction(AutofeedSettingsService.AutofeedSettingsServiceClient grpcClient, AutofeedSettingsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AutofeedSettingsService client</summary>
        public override AutofeedSettingsService.AutofeedSettingsServiceClient GrpcClient { get; }

        partial void Modify_GetAutofeedSettingsRequest(ref GetAutofeedSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAutofeedSettingsRequest(ref UpdateAutofeedSettingsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves the autofeed settings of an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AutofeedSettings GetAutofeedSettings(GetAutofeedSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAutofeedSettingsRequest(ref request, ref callSettings);
            return _callGetAutofeedSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the autofeed settings of an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AutofeedSettings> GetAutofeedSettingsAsync(GetAutofeedSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAutofeedSettingsRequest(ref request, ref callSettings);
            return _callGetAutofeedSettings.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the autofeed settings of an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AutofeedSettings UpdateAutofeedSettings(UpdateAutofeedSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAutofeedSettingsRequest(ref request, ref callSettings);
            return _callUpdateAutofeedSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the autofeed settings of an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AutofeedSettings> UpdateAutofeedSettingsAsync(UpdateAutofeedSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAutofeedSettingsRequest(ref request, ref callSettings);
            return _callUpdateAutofeedSettings.Async(request, callSettings);
        }
    }
}
