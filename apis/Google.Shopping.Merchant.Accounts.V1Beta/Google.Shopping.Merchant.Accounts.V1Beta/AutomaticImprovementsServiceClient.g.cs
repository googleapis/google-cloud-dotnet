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

namespace Google.Shopping.Merchant.Accounts.V1Beta
{
    /// <summary>Settings for <see cref="AutomaticImprovementsServiceClient"/> instances.</summary>
    public sealed partial class AutomaticImprovementsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AutomaticImprovementsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AutomaticImprovementsServiceSettings"/>.</returns>
        public static AutomaticImprovementsServiceSettings GetDefault() => new AutomaticImprovementsServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AutomaticImprovementsServiceSettings"/> object with default settings.
        /// </summary>
        public AutomaticImprovementsServiceSettings()
        {
        }

        private AutomaticImprovementsServiceSettings(AutomaticImprovementsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetAutomaticImprovementsSettings = existing.GetAutomaticImprovementsSettings;
            UpdateAutomaticImprovementsSettings = existing.UpdateAutomaticImprovementsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AutomaticImprovementsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AutomaticImprovementsServiceClient.GetAutomaticImprovements</c> and
        /// <c>AutomaticImprovementsServiceClient.GetAutomaticImprovementsAsync</c>.
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
        public gaxgrpc::CallSettings GetAutomaticImprovementsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AutomaticImprovementsServiceClient.UpdateAutomaticImprovements</c> and
        /// <c>AutomaticImprovementsServiceClient.UpdateAutomaticImprovementsAsync</c>.
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
        public gaxgrpc::CallSettings UpdateAutomaticImprovementsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AutomaticImprovementsServiceSettings"/> object.</returns>
        public AutomaticImprovementsServiceSettings Clone() => new AutomaticImprovementsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AutomaticImprovementsServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class AutomaticImprovementsServiceClientBuilder : gaxgrpc::ClientBuilderBase<AutomaticImprovementsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AutomaticImprovementsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AutomaticImprovementsServiceClientBuilder() : base(AutomaticImprovementsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AutomaticImprovementsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AutomaticImprovementsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AutomaticImprovementsServiceClient Build()
        {
            AutomaticImprovementsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AutomaticImprovementsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AutomaticImprovementsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AutomaticImprovementsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AutomaticImprovementsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AutomaticImprovementsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AutomaticImprovementsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AutomaticImprovementsServiceClient.ChannelPool;
    }

    /// <summary>AutomaticImprovementsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage the automatic improvements of an account. The automatic
    /// improvements of the account can be used to automatically update products,
    /// improve images and shipping.
    /// </remarks>
    public abstract partial class AutomaticImprovementsServiceClient
    {
        /// <summary>
        /// The default endpoint for the AutomaticImprovementsService service, which is a host of
        /// "merchantapi.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default AutomaticImprovementsService scopes.</summary>
        /// <remarks>
        /// The default AutomaticImprovementsService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AutomaticImprovementsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AutomaticImprovementsServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AutomaticImprovementsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AutomaticImprovementsServiceClient"/>.</returns>
        public static stt::Task<AutomaticImprovementsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AutomaticImprovementsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AutomaticImprovementsServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AutomaticImprovementsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AutomaticImprovementsServiceClient"/>.</returns>
        public static AutomaticImprovementsServiceClient Create() => new AutomaticImprovementsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AutomaticImprovementsServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AutomaticImprovementsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AutomaticImprovementsServiceClient"/>.</returns>
        internal static AutomaticImprovementsServiceClient Create(grpccore::CallInvoker callInvoker, AutomaticImprovementsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AutomaticImprovementsService.AutomaticImprovementsServiceClient grpcClient = new AutomaticImprovementsService.AutomaticImprovementsServiceClient(callInvoker);
            return new AutomaticImprovementsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AutomaticImprovementsService client</summary>
        public virtual AutomaticImprovementsService.AutomaticImprovementsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the automatic improvements of an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AutomaticImprovements GetAutomaticImprovements(GetAutomaticImprovementsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the automatic improvements of an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutomaticImprovements> GetAutomaticImprovementsAsync(GetAutomaticImprovementsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the automatic improvements of an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutomaticImprovements> GetAutomaticImprovementsAsync(GetAutomaticImprovementsRequest request, st::CancellationToken cancellationToken) =>
            GetAutomaticImprovementsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the automatic improvements of an account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the automatic improvements.
        /// Format: `accounts/{account}/automaticImprovements`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AutomaticImprovements GetAutomaticImprovements(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAutomaticImprovements(new GetAutomaticImprovementsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the automatic improvements of an account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the automatic improvements.
        /// Format: `accounts/{account}/automaticImprovements`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutomaticImprovements> GetAutomaticImprovementsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAutomaticImprovementsAsync(new GetAutomaticImprovementsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the automatic improvements of an account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the automatic improvements.
        /// Format: `accounts/{account}/automaticImprovements`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutomaticImprovements> GetAutomaticImprovementsAsync(string name, st::CancellationToken cancellationToken) =>
            GetAutomaticImprovementsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the automatic improvements of an account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the automatic improvements.
        /// Format: `accounts/{account}/automaticImprovements`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AutomaticImprovements GetAutomaticImprovements(AutomaticImprovementsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAutomaticImprovements(new GetAutomaticImprovementsRequest
            {
                AutomaticImprovementsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the automatic improvements of an account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the automatic improvements.
        /// Format: `accounts/{account}/automaticImprovements`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutomaticImprovements> GetAutomaticImprovementsAsync(AutomaticImprovementsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAutomaticImprovementsAsync(new GetAutomaticImprovementsRequest
            {
                AutomaticImprovementsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the automatic improvements of an account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the automatic improvements.
        /// Format: `accounts/{account}/automaticImprovements`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutomaticImprovements> GetAutomaticImprovementsAsync(AutomaticImprovementsName name, st::CancellationToken cancellationToken) =>
            GetAutomaticImprovementsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the automatic improvements of an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AutomaticImprovements UpdateAutomaticImprovements(UpdateAutomaticImprovementsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the automatic improvements of an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutomaticImprovements> UpdateAutomaticImprovementsAsync(UpdateAutomaticImprovementsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the automatic improvements of an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutomaticImprovements> UpdateAutomaticImprovementsAsync(UpdateAutomaticImprovementsRequest request, st::CancellationToken cancellationToken) =>
            UpdateAutomaticImprovementsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the automatic improvements of an account.
        /// </summary>
        /// <param name="automaticImprovements">
        /// Required. The new version of the automatic imrovements.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields being updated.
        /// The following fields are supported (in both `snake_case` and
        /// `lowerCamelCase`):
        /// 
        /// - `item_updates`
        /// - `item_updates.account_level_settings`
        /// - `image_improvements`
        /// - `image_improvements.account_level_settings`
        /// - `shipping_improvements`
        /// - `shipping_improvements.allow_shipping_improvements`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AutomaticImprovements UpdateAutomaticImprovements(AutomaticImprovements automaticImprovements, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAutomaticImprovements(new UpdateAutomaticImprovementsRequest
            {
                AutomaticImprovements = gax::GaxPreconditions.CheckNotNull(automaticImprovements, nameof(automaticImprovements)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the automatic improvements of an account.
        /// </summary>
        /// <param name="automaticImprovements">
        /// Required. The new version of the automatic imrovements.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields being updated.
        /// The following fields are supported (in both `snake_case` and
        /// `lowerCamelCase`):
        /// 
        /// - `item_updates`
        /// - `item_updates.account_level_settings`
        /// - `image_improvements`
        /// - `image_improvements.account_level_settings`
        /// - `shipping_improvements`
        /// - `shipping_improvements.allow_shipping_improvements`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutomaticImprovements> UpdateAutomaticImprovementsAsync(AutomaticImprovements automaticImprovements, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAutomaticImprovementsAsync(new UpdateAutomaticImprovementsRequest
            {
                AutomaticImprovements = gax::GaxPreconditions.CheckNotNull(automaticImprovements, nameof(automaticImprovements)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the automatic improvements of an account.
        /// </summary>
        /// <param name="automaticImprovements">
        /// Required. The new version of the automatic imrovements.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields being updated.
        /// The following fields are supported (in both `snake_case` and
        /// `lowerCamelCase`):
        /// 
        /// - `item_updates`
        /// - `item_updates.account_level_settings`
        /// - `image_improvements`
        /// - `image_improvements.account_level_settings`
        /// - `shipping_improvements`
        /// - `shipping_improvements.allow_shipping_improvements`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutomaticImprovements> UpdateAutomaticImprovementsAsync(AutomaticImprovements automaticImprovements, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAutomaticImprovementsAsync(automaticImprovements, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AutomaticImprovementsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage the automatic improvements of an account. The automatic
    /// improvements of the account can be used to automatically update products,
    /// improve images and shipping.
    /// </remarks>
    public sealed partial class AutomaticImprovementsServiceClientImpl : AutomaticImprovementsServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetAutomaticImprovementsRequest, AutomaticImprovements> _callGetAutomaticImprovements;

        private readonly gaxgrpc::ApiCall<UpdateAutomaticImprovementsRequest, AutomaticImprovements> _callUpdateAutomaticImprovements;

        /// <summary>
        /// Constructs a client wrapper for the AutomaticImprovementsService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="AutomaticImprovementsServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AutomaticImprovementsServiceClientImpl(AutomaticImprovementsService.AutomaticImprovementsServiceClient grpcClient, AutomaticImprovementsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AutomaticImprovementsServiceSettings effectiveSettings = settings ?? AutomaticImprovementsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetAutomaticImprovements = clientHelper.BuildApiCall<GetAutomaticImprovementsRequest, AutomaticImprovements>("GetAutomaticImprovements", grpcClient.GetAutomaticImprovementsAsync, grpcClient.GetAutomaticImprovements, effectiveSettings.GetAutomaticImprovementsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAutomaticImprovements);
            Modify_GetAutomaticImprovementsApiCall(ref _callGetAutomaticImprovements);
            _callUpdateAutomaticImprovements = clientHelper.BuildApiCall<UpdateAutomaticImprovementsRequest, AutomaticImprovements>("UpdateAutomaticImprovements", grpcClient.UpdateAutomaticImprovementsAsync, grpcClient.UpdateAutomaticImprovements, effectiveSettings.UpdateAutomaticImprovementsSettings).WithGoogleRequestParam("automatic_improvements.name", request => request.AutomaticImprovements?.Name);
            Modify_ApiCall(ref _callUpdateAutomaticImprovements);
            Modify_UpdateAutomaticImprovementsApiCall(ref _callUpdateAutomaticImprovements);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetAutomaticImprovementsApiCall(ref gaxgrpc::ApiCall<GetAutomaticImprovementsRequest, AutomaticImprovements> call);

        partial void Modify_UpdateAutomaticImprovementsApiCall(ref gaxgrpc::ApiCall<UpdateAutomaticImprovementsRequest, AutomaticImprovements> call);

        partial void OnConstruction(AutomaticImprovementsService.AutomaticImprovementsServiceClient grpcClient, AutomaticImprovementsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AutomaticImprovementsService client</summary>
        public override AutomaticImprovementsService.AutomaticImprovementsServiceClient GrpcClient { get; }

        partial void Modify_GetAutomaticImprovementsRequest(ref GetAutomaticImprovementsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAutomaticImprovementsRequest(ref UpdateAutomaticImprovementsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves the automatic improvements of an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AutomaticImprovements GetAutomaticImprovements(GetAutomaticImprovementsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAutomaticImprovementsRequest(ref request, ref callSettings);
            return _callGetAutomaticImprovements.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the automatic improvements of an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AutomaticImprovements> GetAutomaticImprovementsAsync(GetAutomaticImprovementsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAutomaticImprovementsRequest(ref request, ref callSettings);
            return _callGetAutomaticImprovements.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the automatic improvements of an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AutomaticImprovements UpdateAutomaticImprovements(UpdateAutomaticImprovementsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAutomaticImprovementsRequest(ref request, ref callSettings);
            return _callUpdateAutomaticImprovements.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the automatic improvements of an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AutomaticImprovements> UpdateAutomaticImprovementsAsync(UpdateAutomaticImprovementsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAutomaticImprovementsRequest(ref request, ref callSettings);
            return _callUpdateAutomaticImprovements.Async(request, callSettings);
        }
    }
}
