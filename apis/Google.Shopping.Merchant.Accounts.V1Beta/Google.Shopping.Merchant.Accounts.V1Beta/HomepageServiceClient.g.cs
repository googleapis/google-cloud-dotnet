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
    /// <summary>Settings for <see cref="HomepageServiceClient"/> instances.</summary>
    public sealed partial class HomepageServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="HomepageServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="HomepageServiceSettings"/>.</returns>
        public static HomepageServiceSettings GetDefault() => new HomepageServiceSettings();

        /// <summary>Constructs a new <see cref="HomepageServiceSettings"/> object with default settings.</summary>
        public HomepageServiceSettings()
        {
        }

        private HomepageServiceSettings(HomepageServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetHomepageSettings = existing.GetHomepageSettings;
            UpdateHomepageSettings = existing.UpdateHomepageSettings;
            ClaimHomepageSettings = existing.ClaimHomepageSettings;
            UnclaimHomepageSettings = existing.UnclaimHomepageSettings;
            OnCopy(existing);
        }

        partial void OnCopy(HomepageServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HomepageServiceClient.GetHomepage</c> and <c>HomepageServiceClient.GetHomepageAsync</c>.
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
        public gaxgrpc::CallSettings GetHomepageSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HomepageServiceClient.UpdateHomepage</c> and <c>HomepageServiceClient.UpdateHomepageAsync</c>.
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
        public gaxgrpc::CallSettings UpdateHomepageSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HomepageServiceClient.ClaimHomepage</c> and <c>HomepageServiceClient.ClaimHomepageAsync</c>.
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
        public gaxgrpc::CallSettings ClaimHomepageSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HomepageServiceClient.UnclaimHomepage</c> and <c>HomepageServiceClient.UnclaimHomepageAsync</c>.
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
        public gaxgrpc::CallSettings UnclaimHomepageSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="HomepageServiceSettings"/> object.</returns>
        public HomepageServiceSettings Clone() => new HomepageServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="HomepageServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class HomepageServiceClientBuilder : gaxgrpc::ClientBuilderBase<HomepageServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public HomepageServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public HomepageServiceClientBuilder() : base(HomepageServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref HomepageServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<HomepageServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override HomepageServiceClient Build()
        {
            HomepageServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<HomepageServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<HomepageServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private HomepageServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return HomepageServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<HomepageServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return HomepageServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => HomepageServiceClient.ChannelPool;
    }

    /// <summary>HomepageService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to support an API for a store's homepage.
    /// </remarks>
    public abstract partial class HomepageServiceClient
    {
        /// <summary>
        /// The default endpoint for the HomepageService service, which is a host of "merchantapi.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default HomepageService scopes.</summary>
        /// <remarks>
        /// The default HomepageService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(HomepageService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="HomepageServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="HomepageServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="HomepageServiceClient"/>.</returns>
        public static stt::Task<HomepageServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new HomepageServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="HomepageServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="HomepageServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="HomepageServiceClient"/>.</returns>
        public static HomepageServiceClient Create() => new HomepageServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="HomepageServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="HomepageServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="HomepageServiceClient"/>.</returns>
        internal static HomepageServiceClient Create(grpccore::CallInvoker callInvoker, HomepageServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            HomepageService.HomepageServiceClient grpcClient = new HomepageService.HomepageServiceClient(callInvoker);
            return new HomepageServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC HomepageService client</summary>
        public virtual HomepageService.HomepageServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a store's homepage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Homepage GetHomepage(GetHomepageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a store's homepage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Homepage> GetHomepageAsync(GetHomepageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a store's homepage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Homepage> GetHomepageAsync(GetHomepageRequest request, st::CancellationToken cancellationToken) =>
            GetHomepageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a store's homepage.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the homepage to retrieve.
        /// Format: `accounts/{account}/homepage`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Homepage GetHomepage(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetHomepage(new GetHomepageRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a store's homepage.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the homepage to retrieve.
        /// Format: `accounts/{account}/homepage`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Homepage> GetHomepageAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetHomepageAsync(new GetHomepageRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a store's homepage.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the homepage to retrieve.
        /// Format: `accounts/{account}/homepage`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Homepage> GetHomepageAsync(string name, st::CancellationToken cancellationToken) =>
            GetHomepageAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a store's homepage.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the homepage to retrieve.
        /// Format: `accounts/{account}/homepage`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Homepage GetHomepage(HomepageName name, gaxgrpc::CallSettings callSettings = null) =>
            GetHomepage(new GetHomepageRequest
            {
                HomepageName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a store's homepage.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the homepage to retrieve.
        /// Format: `accounts/{account}/homepage`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Homepage> GetHomepageAsync(HomepageName name, gaxgrpc::CallSettings callSettings = null) =>
            GetHomepageAsync(new GetHomepageRequest
            {
                HomepageName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a store's homepage.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the homepage to retrieve.
        /// Format: `accounts/{account}/homepage`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Homepage> GetHomepageAsync(HomepageName name, st::CancellationToken cancellationToken) =>
            GetHomepageAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a store's homepage. Executing this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Homepage UpdateHomepage(UpdateHomepageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a store's homepage. Executing this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Homepage> UpdateHomepageAsync(UpdateHomepageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a store's homepage. Executing this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Homepage> UpdateHomepageAsync(UpdateHomepageRequest request, st::CancellationToken cancellationToken) =>
            UpdateHomepageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a store's homepage. Executing this method requires admin access.
        /// </summary>
        /// <param name="homepage">
        /// Required. The new version of the homepage.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields being updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Homepage UpdateHomepage(Homepage homepage, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateHomepage(new UpdateHomepageRequest
            {
                Homepage = gax::GaxPreconditions.CheckNotNull(homepage, nameof(homepage)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a store's homepage. Executing this method requires admin access.
        /// </summary>
        /// <param name="homepage">
        /// Required. The new version of the homepage.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields being updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Homepage> UpdateHomepageAsync(Homepage homepage, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateHomepageAsync(new UpdateHomepageRequest
            {
                Homepage = gax::GaxPreconditions.CheckNotNull(homepage, nameof(homepage)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a store's homepage. Executing this method requires admin access.
        /// </summary>
        /// <param name="homepage">
        /// Required. The new version of the homepage.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields being updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Homepage> UpdateHomepageAsync(Homepage homepage, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateHomepageAsync(homepage, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Claims a store's homepage. Executing this method requires admin access.
        /// 
        /// If the homepage is already claimed, this will recheck the
        /// verification (unless the merchant is exempted from claiming, which also
        /// exempts from verification) and return a successful response. If ownership
        /// can no longer be verified, it will return an error, but it won't clear the
        /// claim. In case of failure, a canonical error message will be returned:
        /// * PERMISSION_DENIED: user doesn't have the necessary permissions on this
        /// MC account;
        /// * FAILED_PRECONDITION:
        /// - The account is not a Merchant Center account;
        /// - MC account doesn't have a homepage;
        /// - claiming failed (in this case the error message will contain more
        /// details).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Homepage ClaimHomepage(ClaimHomepageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Claims a store's homepage. Executing this method requires admin access.
        /// 
        /// If the homepage is already claimed, this will recheck the
        /// verification (unless the merchant is exempted from claiming, which also
        /// exempts from verification) and return a successful response. If ownership
        /// can no longer be verified, it will return an error, but it won't clear the
        /// claim. In case of failure, a canonical error message will be returned:
        /// * PERMISSION_DENIED: user doesn't have the necessary permissions on this
        /// MC account;
        /// * FAILED_PRECONDITION:
        /// - The account is not a Merchant Center account;
        /// - MC account doesn't have a homepage;
        /// - claiming failed (in this case the error message will contain more
        /// details).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Homepage> ClaimHomepageAsync(ClaimHomepageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Claims a store's homepage. Executing this method requires admin access.
        /// 
        /// If the homepage is already claimed, this will recheck the
        /// verification (unless the merchant is exempted from claiming, which also
        /// exempts from verification) and return a successful response. If ownership
        /// can no longer be verified, it will return an error, but it won't clear the
        /// claim. In case of failure, a canonical error message will be returned:
        /// * PERMISSION_DENIED: user doesn't have the necessary permissions on this
        /// MC account;
        /// * FAILED_PRECONDITION:
        /// - The account is not a Merchant Center account;
        /// - MC account doesn't have a homepage;
        /// - claiming failed (in this case the error message will contain more
        /// details).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Homepage> ClaimHomepageAsync(ClaimHomepageRequest request, st::CancellationToken cancellationToken) =>
            ClaimHomepageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Unclaims a store's homepage. Executing this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Homepage UnclaimHomepage(UnclaimHomepageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Unclaims a store's homepage. Executing this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Homepage> UnclaimHomepageAsync(UnclaimHomepageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Unclaims a store's homepage. Executing this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Homepage> UnclaimHomepageAsync(UnclaimHomepageRequest request, st::CancellationToken cancellationToken) =>
            UnclaimHomepageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>HomepageService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to support an API for a store's homepage.
    /// </remarks>
    public sealed partial class HomepageServiceClientImpl : HomepageServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetHomepageRequest, Homepage> _callGetHomepage;

        private readonly gaxgrpc::ApiCall<UpdateHomepageRequest, Homepage> _callUpdateHomepage;

        private readonly gaxgrpc::ApiCall<ClaimHomepageRequest, Homepage> _callClaimHomepage;

        private readonly gaxgrpc::ApiCall<UnclaimHomepageRequest, Homepage> _callUnclaimHomepage;

        /// <summary>
        /// Constructs a client wrapper for the HomepageService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="HomepageServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public HomepageServiceClientImpl(HomepageService.HomepageServiceClient grpcClient, HomepageServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            HomepageServiceSettings effectiveSettings = settings ?? HomepageServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetHomepage = clientHelper.BuildApiCall<GetHomepageRequest, Homepage>("GetHomepage", grpcClient.GetHomepageAsync, grpcClient.GetHomepage, effectiveSettings.GetHomepageSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetHomepage);
            Modify_GetHomepageApiCall(ref _callGetHomepage);
            _callUpdateHomepage = clientHelper.BuildApiCall<UpdateHomepageRequest, Homepage>("UpdateHomepage", grpcClient.UpdateHomepageAsync, grpcClient.UpdateHomepage, effectiveSettings.UpdateHomepageSettings).WithGoogleRequestParam("homepage.name", request => request.Homepage?.Name);
            Modify_ApiCall(ref _callUpdateHomepage);
            Modify_UpdateHomepageApiCall(ref _callUpdateHomepage);
            _callClaimHomepage = clientHelper.BuildApiCall<ClaimHomepageRequest, Homepage>("ClaimHomepage", grpcClient.ClaimHomepageAsync, grpcClient.ClaimHomepage, effectiveSettings.ClaimHomepageSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callClaimHomepage);
            Modify_ClaimHomepageApiCall(ref _callClaimHomepage);
            _callUnclaimHomepage = clientHelper.BuildApiCall<UnclaimHomepageRequest, Homepage>("UnclaimHomepage", grpcClient.UnclaimHomepageAsync, grpcClient.UnclaimHomepage, effectiveSettings.UnclaimHomepageSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUnclaimHomepage);
            Modify_UnclaimHomepageApiCall(ref _callUnclaimHomepage);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetHomepageApiCall(ref gaxgrpc::ApiCall<GetHomepageRequest, Homepage> call);

        partial void Modify_UpdateHomepageApiCall(ref gaxgrpc::ApiCall<UpdateHomepageRequest, Homepage> call);

        partial void Modify_ClaimHomepageApiCall(ref gaxgrpc::ApiCall<ClaimHomepageRequest, Homepage> call);

        partial void Modify_UnclaimHomepageApiCall(ref gaxgrpc::ApiCall<UnclaimHomepageRequest, Homepage> call);

        partial void OnConstruction(HomepageService.HomepageServiceClient grpcClient, HomepageServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC HomepageService client</summary>
        public override HomepageService.HomepageServiceClient GrpcClient { get; }

        partial void Modify_GetHomepageRequest(ref GetHomepageRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateHomepageRequest(ref UpdateHomepageRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ClaimHomepageRequest(ref ClaimHomepageRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UnclaimHomepageRequest(ref UnclaimHomepageRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves a store's homepage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Homepage GetHomepage(GetHomepageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetHomepageRequest(ref request, ref callSettings);
            return _callGetHomepage.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a store's homepage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Homepage> GetHomepageAsync(GetHomepageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetHomepageRequest(ref request, ref callSettings);
            return _callGetHomepage.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a store's homepage. Executing this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Homepage UpdateHomepage(UpdateHomepageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateHomepageRequest(ref request, ref callSettings);
            return _callUpdateHomepage.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a store's homepage. Executing this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Homepage> UpdateHomepageAsync(UpdateHomepageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateHomepageRequest(ref request, ref callSettings);
            return _callUpdateHomepage.Async(request, callSettings);
        }

        /// <summary>
        /// Claims a store's homepage. Executing this method requires admin access.
        /// 
        /// If the homepage is already claimed, this will recheck the
        /// verification (unless the merchant is exempted from claiming, which also
        /// exempts from verification) and return a successful response. If ownership
        /// can no longer be verified, it will return an error, but it won't clear the
        /// claim. In case of failure, a canonical error message will be returned:
        /// * PERMISSION_DENIED: user doesn't have the necessary permissions on this
        /// MC account;
        /// * FAILED_PRECONDITION:
        /// - The account is not a Merchant Center account;
        /// - MC account doesn't have a homepage;
        /// - claiming failed (in this case the error message will contain more
        /// details).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Homepage ClaimHomepage(ClaimHomepageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ClaimHomepageRequest(ref request, ref callSettings);
            return _callClaimHomepage.Sync(request, callSettings);
        }

        /// <summary>
        /// Claims a store's homepage. Executing this method requires admin access.
        /// 
        /// If the homepage is already claimed, this will recheck the
        /// verification (unless the merchant is exempted from claiming, which also
        /// exempts from verification) and return a successful response. If ownership
        /// can no longer be verified, it will return an error, but it won't clear the
        /// claim. In case of failure, a canonical error message will be returned:
        /// * PERMISSION_DENIED: user doesn't have the necessary permissions on this
        /// MC account;
        /// * FAILED_PRECONDITION:
        /// - The account is not a Merchant Center account;
        /// - MC account doesn't have a homepage;
        /// - claiming failed (in this case the error message will contain more
        /// details).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Homepage> ClaimHomepageAsync(ClaimHomepageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ClaimHomepageRequest(ref request, ref callSettings);
            return _callClaimHomepage.Async(request, callSettings);
        }

        /// <summary>
        /// Unclaims a store's homepage. Executing this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Homepage UnclaimHomepage(UnclaimHomepageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UnclaimHomepageRequest(ref request, ref callSettings);
            return _callUnclaimHomepage.Sync(request, callSettings);
        }

        /// <summary>
        /// Unclaims a store's homepage. Executing this method requires admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Homepage> UnclaimHomepageAsync(UnclaimHomepageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UnclaimHomepageRequest(ref request, ref callSettings);
            return _callUnclaimHomepage.Async(request, callSettings);
        }
    }
}
