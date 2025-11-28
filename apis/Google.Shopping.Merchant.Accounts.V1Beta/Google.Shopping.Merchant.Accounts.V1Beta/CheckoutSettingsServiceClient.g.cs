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
    /// <summary>Settings for <see cref="CheckoutSettingsServiceClient"/> instances.</summary>
    public sealed partial class CheckoutSettingsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CheckoutSettingsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CheckoutSettingsServiceSettings"/>.</returns>
        public static CheckoutSettingsServiceSettings GetDefault() => new CheckoutSettingsServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CheckoutSettingsServiceSettings"/> object with default settings.
        /// </summary>
        public CheckoutSettingsServiceSettings()
        {
        }

        private CheckoutSettingsServiceSettings(CheckoutSettingsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCheckoutSettingsSettings = existing.GetCheckoutSettingsSettings;
            CreateCheckoutSettingsSettings = existing.CreateCheckoutSettingsSettings;
            UpdateCheckoutSettingsSettings = existing.UpdateCheckoutSettingsSettings;
            DeleteCheckoutSettingsSettings = existing.DeleteCheckoutSettingsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CheckoutSettingsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CheckoutSettingsServiceClient.GetCheckoutSettings</c> and
        /// <c>CheckoutSettingsServiceClient.GetCheckoutSettingsAsync</c>.
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
        public gaxgrpc::CallSettings GetCheckoutSettingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CheckoutSettingsServiceClient.CreateCheckoutSettings</c> and
        /// <c>CheckoutSettingsServiceClient.CreateCheckoutSettingsAsync</c>.
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
        public gaxgrpc::CallSettings CreateCheckoutSettingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CheckoutSettingsServiceClient.UpdateCheckoutSettings</c> and
        /// <c>CheckoutSettingsServiceClient.UpdateCheckoutSettingsAsync</c>.
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
        public gaxgrpc::CallSettings UpdateCheckoutSettingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CheckoutSettingsServiceClient.DeleteCheckoutSettings</c> and
        /// <c>CheckoutSettingsServiceClient.DeleteCheckoutSettingsAsync</c>.
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
        public gaxgrpc::CallSettings DeleteCheckoutSettingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CheckoutSettingsServiceSettings"/> object.</returns>
        public CheckoutSettingsServiceSettings Clone() => new CheckoutSettingsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CheckoutSettingsServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class CheckoutSettingsServiceClientBuilder : gaxgrpc::ClientBuilderBase<CheckoutSettingsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CheckoutSettingsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CheckoutSettingsServiceClientBuilder() : base(CheckoutSettingsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CheckoutSettingsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CheckoutSettingsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CheckoutSettingsServiceClient Build()
        {
            CheckoutSettingsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CheckoutSettingsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CheckoutSettingsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CheckoutSettingsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CheckoutSettingsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CheckoutSettingsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CheckoutSettingsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CheckoutSettingsServiceClient.ChannelPool;
    }

    /// <summary>CheckoutSettingsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for supporting [checkout
    /// settings](https://support.google.com/merchants/answer/13945960).
    /// </remarks>
    public abstract partial class CheckoutSettingsServiceClient
    {
        /// <summary>
        /// The default endpoint for the CheckoutSettingsService service, which is a host of
        /// "merchantapi.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default CheckoutSettingsService scopes.</summary>
        /// <remarks>
        /// The default CheckoutSettingsService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CheckoutSettingsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CheckoutSettingsServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CheckoutSettingsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CheckoutSettingsServiceClient"/>.</returns>
        public static stt::Task<CheckoutSettingsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CheckoutSettingsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CheckoutSettingsServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CheckoutSettingsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CheckoutSettingsServiceClient"/>.</returns>
        public static CheckoutSettingsServiceClient Create() => new CheckoutSettingsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CheckoutSettingsServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CheckoutSettingsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CheckoutSettingsServiceClient"/>.</returns>
        internal static CheckoutSettingsServiceClient Create(grpccore::CallInvoker callInvoker, CheckoutSettingsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CheckoutSettingsService.CheckoutSettingsServiceClient grpcClient = new CheckoutSettingsService.CheckoutSettingsServiceClient(callInvoker);
            return new CheckoutSettingsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CheckoutSettingsService client</summary>
        public virtual CheckoutSettingsService.CheckoutSettingsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets `CheckoutSettings` for the given merchant. This includes
        /// information about review state, enrollment state and URL settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CheckoutSettings GetCheckoutSettings(GetCheckoutSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets `CheckoutSettings` for the given merchant. This includes
        /// information about review state, enrollment state and URL settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckoutSettings> GetCheckoutSettingsAsync(GetCheckoutSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets `CheckoutSettings` for the given merchant. This includes
        /// information about review state, enrollment state and URL settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckoutSettings> GetCheckoutSettingsAsync(GetCheckoutSettingsRequest request, st::CancellationToken cancellationToken) =>
            GetCheckoutSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets `CheckoutSettings` for the given merchant. This includes
        /// information about review state, enrollment state and URL settings.
        /// </summary>
        /// <param name="name">
        /// Required. The name/identifier of the merchant account.
        /// Format: `accounts/{account}/programs/{program}/checkoutSettings`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CheckoutSettings GetCheckoutSettings(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCheckoutSettings(new GetCheckoutSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets `CheckoutSettings` for the given merchant. This includes
        /// information about review state, enrollment state and URL settings.
        /// </summary>
        /// <param name="name">
        /// Required. The name/identifier of the merchant account.
        /// Format: `accounts/{account}/programs/{program}/checkoutSettings`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckoutSettings> GetCheckoutSettingsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCheckoutSettingsAsync(new GetCheckoutSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets `CheckoutSettings` for the given merchant. This includes
        /// information about review state, enrollment state and URL settings.
        /// </summary>
        /// <param name="name">
        /// Required. The name/identifier of the merchant account.
        /// Format: `accounts/{account}/programs/{program}/checkoutSettings`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckoutSettings> GetCheckoutSettingsAsync(string name, st::CancellationToken cancellationToken) =>
            GetCheckoutSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets `CheckoutSettings` for the given merchant. This includes
        /// information about review state, enrollment state and URL settings.
        /// </summary>
        /// <param name="name">
        /// Required. The name/identifier of the merchant account.
        /// Format: `accounts/{account}/programs/{program}/checkoutSettings`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CheckoutSettings GetCheckoutSettings(CheckoutSettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCheckoutSettings(new GetCheckoutSettingsRequest
            {
                CheckoutSettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets `CheckoutSettings` for the given merchant. This includes
        /// information about review state, enrollment state and URL settings.
        /// </summary>
        /// <param name="name">
        /// Required. The name/identifier of the merchant account.
        /// Format: `accounts/{account}/programs/{program}/checkoutSettings`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckoutSettings> GetCheckoutSettingsAsync(CheckoutSettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCheckoutSettingsAsync(new GetCheckoutSettingsRequest
            {
                CheckoutSettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets `CheckoutSettings` for the given merchant. This includes
        /// information about review state, enrollment state and URL settings.
        /// </summary>
        /// <param name="name">
        /// Required. The name/identifier of the merchant account.
        /// Format: `accounts/{account}/programs/{program}/checkoutSettings`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckoutSettings> GetCheckoutSettingsAsync(CheckoutSettingsName name, st::CancellationToken cancellationToken) =>
            GetCheckoutSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates `CheckoutSettings` for the given merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CheckoutSettings CreateCheckoutSettings(CreateCheckoutSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates `CheckoutSettings` for the given merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckoutSettings> CreateCheckoutSettingsAsync(CreateCheckoutSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates `CheckoutSettings` for the given merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckoutSettings> CreateCheckoutSettingsAsync(CreateCheckoutSettingsRequest request, st::CancellationToken cancellationToken) =>
            CreateCheckoutSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates `CheckoutSettings` for the given merchant.
        /// </summary>
        /// <param name="parent">
        /// Required. The merchant account for which the `CheckoutSettings` will be
        /// created.
        /// </param>
        /// <param name="checkoutSettings">
        /// Required. The `CheckoutSettings` object to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CheckoutSettings CreateCheckoutSettings(string parent, CheckoutSettings checkoutSettings, gaxgrpc::CallSettings callSettings = null) =>
            CreateCheckoutSettings(new CreateCheckoutSettingsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CheckoutSettings = gax::GaxPreconditions.CheckNotNull(checkoutSettings, nameof(checkoutSettings)),
            }, callSettings);

        /// <summary>
        /// Creates `CheckoutSettings` for the given merchant.
        /// </summary>
        /// <param name="parent">
        /// Required. The merchant account for which the `CheckoutSettings` will be
        /// created.
        /// </param>
        /// <param name="checkoutSettings">
        /// Required. The `CheckoutSettings` object to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckoutSettings> CreateCheckoutSettingsAsync(string parent, CheckoutSettings checkoutSettings, gaxgrpc::CallSettings callSettings = null) =>
            CreateCheckoutSettingsAsync(new CreateCheckoutSettingsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CheckoutSettings = gax::GaxPreconditions.CheckNotNull(checkoutSettings, nameof(checkoutSettings)),
            }, callSettings);

        /// <summary>
        /// Creates `CheckoutSettings` for the given merchant.
        /// </summary>
        /// <param name="parent">
        /// Required. The merchant account for which the `CheckoutSettings` will be
        /// created.
        /// </param>
        /// <param name="checkoutSettings">
        /// Required. The `CheckoutSettings` object to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckoutSettings> CreateCheckoutSettingsAsync(string parent, CheckoutSettings checkoutSettings, st::CancellationToken cancellationToken) =>
            CreateCheckoutSettingsAsync(parent, checkoutSettings, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates `CheckoutSettings` for the given merchant.
        /// </summary>
        /// <param name="parent">
        /// Required. The merchant account for which the `CheckoutSettings` will be
        /// created.
        /// </param>
        /// <param name="checkoutSettings">
        /// Required. The `CheckoutSettings` object to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CheckoutSettings CreateCheckoutSettings(ProgramName parent, CheckoutSettings checkoutSettings, gaxgrpc::CallSettings callSettings = null) =>
            CreateCheckoutSettings(new CreateCheckoutSettingsRequest
            {
                ParentAsProgramName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CheckoutSettings = gax::GaxPreconditions.CheckNotNull(checkoutSettings, nameof(checkoutSettings)),
            }, callSettings);

        /// <summary>
        /// Creates `CheckoutSettings` for the given merchant.
        /// </summary>
        /// <param name="parent">
        /// Required. The merchant account for which the `CheckoutSettings` will be
        /// created.
        /// </param>
        /// <param name="checkoutSettings">
        /// Required. The `CheckoutSettings` object to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckoutSettings> CreateCheckoutSettingsAsync(ProgramName parent, CheckoutSettings checkoutSettings, gaxgrpc::CallSettings callSettings = null) =>
            CreateCheckoutSettingsAsync(new CreateCheckoutSettingsRequest
            {
                ParentAsProgramName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CheckoutSettings = gax::GaxPreconditions.CheckNotNull(checkoutSettings, nameof(checkoutSettings)),
            }, callSettings);

        /// <summary>
        /// Creates `CheckoutSettings` for the given merchant.
        /// </summary>
        /// <param name="parent">
        /// Required. The merchant account for which the `CheckoutSettings` will be
        /// created.
        /// </param>
        /// <param name="checkoutSettings">
        /// Required. The `CheckoutSettings` object to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckoutSettings> CreateCheckoutSettingsAsync(ProgramName parent, CheckoutSettings checkoutSettings, st::CancellationToken cancellationToken) =>
            CreateCheckoutSettingsAsync(parent, checkoutSettings, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates `CheckoutSettings` for the given merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CheckoutSettings UpdateCheckoutSettings(UpdateCheckoutSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates `CheckoutSettings` for the given merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckoutSettings> UpdateCheckoutSettingsAsync(UpdateCheckoutSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates `CheckoutSettings` for the given merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckoutSettings> UpdateCheckoutSettingsAsync(UpdateCheckoutSettingsRequest request, st::CancellationToken cancellationToken) =>
            UpdateCheckoutSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates `CheckoutSettings` for the given merchant.
        /// </summary>
        /// <param name="checkoutSettings">
        /// Required. The updated version of the `CheckoutSettings`.
        /// The `name` field is used to identify the `CheckoutSettings`.
        /// Format: `accounts/{account}/programs/{program}/checkoutSettings`
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields being updated.
        /// The following fields are supported (in both `snake_case` and
        /// `lowerCamelCase`):
        /// 
        /// - `eligible_destinations`
        /// - `uri_settings`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CheckoutSettings UpdateCheckoutSettings(CheckoutSettings checkoutSettings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCheckoutSettings(new UpdateCheckoutSettingsRequest
            {
                CheckoutSettings = gax::GaxPreconditions.CheckNotNull(checkoutSettings, nameof(checkoutSettings)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates `CheckoutSettings` for the given merchant.
        /// </summary>
        /// <param name="checkoutSettings">
        /// Required. The updated version of the `CheckoutSettings`.
        /// The `name` field is used to identify the `CheckoutSettings`.
        /// Format: `accounts/{account}/programs/{program}/checkoutSettings`
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields being updated.
        /// The following fields are supported (in both `snake_case` and
        /// `lowerCamelCase`):
        /// 
        /// - `eligible_destinations`
        /// - `uri_settings`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckoutSettings> UpdateCheckoutSettingsAsync(CheckoutSettings checkoutSettings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCheckoutSettingsAsync(new UpdateCheckoutSettingsRequest
            {
                CheckoutSettings = gax::GaxPreconditions.CheckNotNull(checkoutSettings, nameof(checkoutSettings)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates `CheckoutSettings` for the given merchant.
        /// </summary>
        /// <param name="checkoutSettings">
        /// Required. The updated version of the `CheckoutSettings`.
        /// The `name` field is used to identify the `CheckoutSettings`.
        /// Format: `accounts/{account}/programs/{program}/checkoutSettings`
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields being updated.
        /// The following fields are supported (in both `snake_case` and
        /// `lowerCamelCase`):
        /// 
        /// - `eligible_destinations`
        /// - `uri_settings`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckoutSettings> UpdateCheckoutSettingsAsync(CheckoutSettings checkoutSettings, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCheckoutSettingsAsync(checkoutSettings, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes `CheckoutSettings` and unenrolls merchant from
        /// `Checkout` program.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCheckoutSettings(DeleteCheckoutSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes `CheckoutSettings` and unenrolls merchant from
        /// `Checkout` program.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCheckoutSettingsAsync(DeleteCheckoutSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes `CheckoutSettings` and unenrolls merchant from
        /// `Checkout` program.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCheckoutSettingsAsync(DeleteCheckoutSettingsRequest request, st::CancellationToken cancellationToken) =>
            DeleteCheckoutSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes `CheckoutSettings` and unenrolls merchant from
        /// `Checkout` program.
        /// </summary>
        /// <param name="name">
        /// Required. The name/identifier of the merchant account.
        /// Format: `accounts/{account}/programs/{program}/checkoutSettings`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCheckoutSettings(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCheckoutSettings(new DeleteCheckoutSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes `CheckoutSettings` and unenrolls merchant from
        /// `Checkout` program.
        /// </summary>
        /// <param name="name">
        /// Required. The name/identifier of the merchant account.
        /// Format: `accounts/{account}/programs/{program}/checkoutSettings`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCheckoutSettingsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCheckoutSettingsAsync(new DeleteCheckoutSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes `CheckoutSettings` and unenrolls merchant from
        /// `Checkout` program.
        /// </summary>
        /// <param name="name">
        /// Required. The name/identifier of the merchant account.
        /// Format: `accounts/{account}/programs/{program}/checkoutSettings`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCheckoutSettingsAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteCheckoutSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes `CheckoutSettings` and unenrolls merchant from
        /// `Checkout` program.
        /// </summary>
        /// <param name="name">
        /// Required. The name/identifier of the merchant account.
        /// Format: `accounts/{account}/programs/{program}/checkoutSettings`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCheckoutSettings(CheckoutSettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCheckoutSettings(new DeleteCheckoutSettingsRequest
            {
                CheckoutSettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes `CheckoutSettings` and unenrolls merchant from
        /// `Checkout` program.
        /// </summary>
        /// <param name="name">
        /// Required. The name/identifier of the merchant account.
        /// Format: `accounts/{account}/programs/{program}/checkoutSettings`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCheckoutSettingsAsync(CheckoutSettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCheckoutSettingsAsync(new DeleteCheckoutSettingsRequest
            {
                CheckoutSettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes `CheckoutSettings` and unenrolls merchant from
        /// `Checkout` program.
        /// </summary>
        /// <param name="name">
        /// Required. The name/identifier of the merchant account.
        /// Format: `accounts/{account}/programs/{program}/checkoutSettings`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCheckoutSettingsAsync(CheckoutSettingsName name, st::CancellationToken cancellationToken) =>
            DeleteCheckoutSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CheckoutSettingsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for supporting [checkout
    /// settings](https://support.google.com/merchants/answer/13945960).
    /// </remarks>
    public sealed partial class CheckoutSettingsServiceClientImpl : CheckoutSettingsServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCheckoutSettingsRequest, CheckoutSettings> _callGetCheckoutSettings;

        private readonly gaxgrpc::ApiCall<CreateCheckoutSettingsRequest, CheckoutSettings> _callCreateCheckoutSettings;

        private readonly gaxgrpc::ApiCall<UpdateCheckoutSettingsRequest, CheckoutSettings> _callUpdateCheckoutSettings;

        private readonly gaxgrpc::ApiCall<DeleteCheckoutSettingsRequest, wkt::Empty> _callDeleteCheckoutSettings;

        /// <summary>
        /// Constructs a client wrapper for the CheckoutSettingsService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CheckoutSettingsServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CheckoutSettingsServiceClientImpl(CheckoutSettingsService.CheckoutSettingsServiceClient grpcClient, CheckoutSettingsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CheckoutSettingsServiceSettings effectiveSettings = settings ?? CheckoutSettingsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetCheckoutSettings = clientHelper.BuildApiCall<GetCheckoutSettingsRequest, CheckoutSettings>("GetCheckoutSettings", grpcClient.GetCheckoutSettingsAsync, grpcClient.GetCheckoutSettings, effectiveSettings.GetCheckoutSettingsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCheckoutSettings);
            Modify_GetCheckoutSettingsApiCall(ref _callGetCheckoutSettings);
            _callCreateCheckoutSettings = clientHelper.BuildApiCall<CreateCheckoutSettingsRequest, CheckoutSettings>("CreateCheckoutSettings", grpcClient.CreateCheckoutSettingsAsync, grpcClient.CreateCheckoutSettings, effectiveSettings.CreateCheckoutSettingsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCheckoutSettings);
            Modify_CreateCheckoutSettingsApiCall(ref _callCreateCheckoutSettings);
            _callUpdateCheckoutSettings = clientHelper.BuildApiCall<UpdateCheckoutSettingsRequest, CheckoutSettings>("UpdateCheckoutSettings", grpcClient.UpdateCheckoutSettingsAsync, grpcClient.UpdateCheckoutSettings, effectiveSettings.UpdateCheckoutSettingsSettings).WithGoogleRequestParam("checkout_settings.name", request => request.CheckoutSettings?.Name);
            Modify_ApiCall(ref _callUpdateCheckoutSettings);
            Modify_UpdateCheckoutSettingsApiCall(ref _callUpdateCheckoutSettings);
            _callDeleteCheckoutSettings = clientHelper.BuildApiCall<DeleteCheckoutSettingsRequest, wkt::Empty>("DeleteCheckoutSettings", grpcClient.DeleteCheckoutSettingsAsync, grpcClient.DeleteCheckoutSettings, effectiveSettings.DeleteCheckoutSettingsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteCheckoutSettings);
            Modify_DeleteCheckoutSettingsApiCall(ref _callDeleteCheckoutSettings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetCheckoutSettingsApiCall(ref gaxgrpc::ApiCall<GetCheckoutSettingsRequest, CheckoutSettings> call);

        partial void Modify_CreateCheckoutSettingsApiCall(ref gaxgrpc::ApiCall<CreateCheckoutSettingsRequest, CheckoutSettings> call);

        partial void Modify_UpdateCheckoutSettingsApiCall(ref gaxgrpc::ApiCall<UpdateCheckoutSettingsRequest, CheckoutSettings> call);

        partial void Modify_DeleteCheckoutSettingsApiCall(ref gaxgrpc::ApiCall<DeleteCheckoutSettingsRequest, wkt::Empty> call);

        partial void OnConstruction(CheckoutSettingsService.CheckoutSettingsServiceClient grpcClient, CheckoutSettingsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CheckoutSettingsService client</summary>
        public override CheckoutSettingsService.CheckoutSettingsServiceClient GrpcClient { get; }

        partial void Modify_GetCheckoutSettingsRequest(ref GetCheckoutSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateCheckoutSettingsRequest(ref CreateCheckoutSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCheckoutSettingsRequest(ref UpdateCheckoutSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteCheckoutSettingsRequest(ref DeleteCheckoutSettingsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets `CheckoutSettings` for the given merchant. This includes
        /// information about review state, enrollment state and URL settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CheckoutSettings GetCheckoutSettings(GetCheckoutSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCheckoutSettingsRequest(ref request, ref callSettings);
            return _callGetCheckoutSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets `CheckoutSettings` for the given merchant. This includes
        /// information about review state, enrollment state and URL settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CheckoutSettings> GetCheckoutSettingsAsync(GetCheckoutSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCheckoutSettingsRequest(ref request, ref callSettings);
            return _callGetCheckoutSettings.Async(request, callSettings);
        }

        /// <summary>
        /// Creates `CheckoutSettings` for the given merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CheckoutSettings CreateCheckoutSettings(CreateCheckoutSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCheckoutSettingsRequest(ref request, ref callSettings);
            return _callCreateCheckoutSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates `CheckoutSettings` for the given merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CheckoutSettings> CreateCheckoutSettingsAsync(CreateCheckoutSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCheckoutSettingsRequest(ref request, ref callSettings);
            return _callCreateCheckoutSettings.Async(request, callSettings);
        }

        /// <summary>
        /// Updates `CheckoutSettings` for the given merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CheckoutSettings UpdateCheckoutSettings(UpdateCheckoutSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCheckoutSettingsRequest(ref request, ref callSettings);
            return _callUpdateCheckoutSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates `CheckoutSettings` for the given merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CheckoutSettings> UpdateCheckoutSettingsAsync(UpdateCheckoutSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCheckoutSettingsRequest(ref request, ref callSettings);
            return _callUpdateCheckoutSettings.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes `CheckoutSettings` and unenrolls merchant from
        /// `Checkout` program.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteCheckoutSettings(DeleteCheckoutSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCheckoutSettingsRequest(ref request, ref callSettings);
            _callDeleteCheckoutSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes `CheckoutSettings` and unenrolls merchant from
        /// `Checkout` program.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteCheckoutSettingsAsync(DeleteCheckoutSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCheckoutSettingsRequest(ref request, ref callSettings);
            return _callDeleteCheckoutSettings.Async(request, callSettings);
        }
    }
}
