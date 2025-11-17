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

namespace Google.Shopping.Merchant.Accounts.V1
{
    /// <summary>Settings for <see cref="DeveloperRegistrationServiceClient"/> instances.</summary>
    public sealed partial class DeveloperRegistrationServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DeveloperRegistrationServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DeveloperRegistrationServiceSettings"/>.</returns>
        public static DeveloperRegistrationServiceSettings GetDefault() => new DeveloperRegistrationServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="DeveloperRegistrationServiceSettings"/> object with default settings.
        /// </summary>
        public DeveloperRegistrationServiceSettings()
        {
        }

        private DeveloperRegistrationServiceSettings(DeveloperRegistrationServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            RegisterGcpSettings = existing.RegisterGcpSettings;
            GetDeveloperRegistrationSettings = existing.GetDeveloperRegistrationSettings;
            UnregisterGcpSettings = existing.UnregisterGcpSettings;
            GetAccountForGcpRegistrationSettings = existing.GetAccountForGcpRegistrationSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DeveloperRegistrationServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeveloperRegistrationServiceClient.RegisterGcp</c> and
        /// <c>DeveloperRegistrationServiceClient.RegisterGcpAsync</c>.
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
        public gaxgrpc::CallSettings RegisterGcpSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeveloperRegistrationServiceClient.GetDeveloperRegistration</c> and
        /// <c>DeveloperRegistrationServiceClient.GetDeveloperRegistrationAsync</c>.
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
        public gaxgrpc::CallSettings GetDeveloperRegistrationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeveloperRegistrationServiceClient.UnregisterGcp</c> and
        /// <c>DeveloperRegistrationServiceClient.UnregisterGcpAsync</c>.
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
        public gaxgrpc::CallSettings UnregisterGcpSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DeveloperRegistrationServiceClient.GetAccountForGcpRegistration</c> and
        /// <c>DeveloperRegistrationServiceClient.GetAccountForGcpRegistrationAsync</c>.
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
        public gaxgrpc::CallSettings GetAccountForGcpRegistrationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DeveloperRegistrationServiceSettings"/> object.</returns>
        public DeveloperRegistrationServiceSettings Clone() => new DeveloperRegistrationServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DeveloperRegistrationServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class DeveloperRegistrationServiceClientBuilder : gaxgrpc::ClientBuilderBase<DeveloperRegistrationServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DeveloperRegistrationServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DeveloperRegistrationServiceClientBuilder() : base(DeveloperRegistrationServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DeveloperRegistrationServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DeveloperRegistrationServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DeveloperRegistrationServiceClient Build()
        {
            DeveloperRegistrationServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DeveloperRegistrationServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DeveloperRegistrationServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DeveloperRegistrationServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DeveloperRegistrationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DeveloperRegistrationServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DeveloperRegistrationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DeveloperRegistrationServiceClient.ChannelPool;
    }

    /// <summary>DeveloperRegistrationService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to access Developer Registration.
    /// </remarks>
    public abstract partial class DeveloperRegistrationServiceClient
    {
        /// <summary>
        /// The default endpoint for the DeveloperRegistrationService service, which is a host of
        /// "merchantapi.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default DeveloperRegistrationService scopes.</summary>
        /// <remarks>
        /// The default DeveloperRegistrationService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DeveloperRegistrationService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DeveloperRegistrationServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="DeveloperRegistrationServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DeveloperRegistrationServiceClient"/>.</returns>
        public static stt::Task<DeveloperRegistrationServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DeveloperRegistrationServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DeveloperRegistrationServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="DeveloperRegistrationServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DeveloperRegistrationServiceClient"/>.</returns>
        public static DeveloperRegistrationServiceClient Create() => new DeveloperRegistrationServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DeveloperRegistrationServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DeveloperRegistrationServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DeveloperRegistrationServiceClient"/>.</returns>
        internal static DeveloperRegistrationServiceClient Create(grpccore::CallInvoker callInvoker, DeveloperRegistrationServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DeveloperRegistrationService.DeveloperRegistrationServiceClient grpcClient = new DeveloperRegistrationService.DeveloperRegistrationServiceClient(callInvoker);
            return new DeveloperRegistrationServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DeveloperRegistrationService client</summary>
        public virtual DeveloperRegistrationService.DeveloperRegistrationServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Registers the GCP used for the API call to the shopping account passed in
        /// the request. Will create a user with an "API developer" and add the
        /// "developer_email" as a contact with "API notifications" email preference
        /// on.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeveloperRegistration RegisterGcp(RegisterGcpRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Registers the GCP used for the API call to the shopping account passed in
        /// the request. Will create a user with an "API developer" and add the
        /// "developer_email" as a contact with "API notifications" email preference
        /// on.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeveloperRegistration> RegisterGcpAsync(RegisterGcpRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Registers the GCP used for the API call to the shopping account passed in
        /// the request. Will create a user with an "API developer" and add the
        /// "developer_email" as a contact with "API notifications" email preference
        /// on.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeveloperRegistration> RegisterGcpAsync(RegisterGcpRequest request, st::CancellationToken cancellationToken) =>
            RegisterGcpAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a developer registration for a merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeveloperRegistration GetDeveloperRegistration(GetDeveloperRegistrationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a developer registration for a merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeveloperRegistration> GetDeveloperRegistrationAsync(GetDeveloperRegistrationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a developer registration for a merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeveloperRegistration> GetDeveloperRegistrationAsync(GetDeveloperRegistrationRequest request, st::CancellationToken cancellationToken) =>
            GetDeveloperRegistrationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a developer registration for a merchant.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` (ID) of the developer registration.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeveloperRegistration GetDeveloperRegistration(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeveloperRegistration(new GetDeveloperRegistrationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a developer registration for a merchant.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` (ID) of the developer registration.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeveloperRegistration> GetDeveloperRegistrationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeveloperRegistrationAsync(new GetDeveloperRegistrationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a developer registration for a merchant.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` (ID) of the developer registration.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeveloperRegistration> GetDeveloperRegistrationAsync(string name, st::CancellationToken cancellationToken) =>
            GetDeveloperRegistrationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a developer registration for a merchant.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` (ID) of the developer registration.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeveloperRegistration GetDeveloperRegistration(DeveloperRegistrationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeveloperRegistration(new GetDeveloperRegistrationRequest
            {
                DeveloperRegistrationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a developer registration for a merchant.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` (ID) of the developer registration.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeveloperRegistration> GetDeveloperRegistrationAsync(DeveloperRegistrationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeveloperRegistrationAsync(new GetDeveloperRegistrationRequest
            {
                DeveloperRegistrationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a developer registration for a merchant.
        /// </summary>
        /// <param name="name">
        /// Required. The `name` (ID) of the developer registration.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeveloperRegistration> GetDeveloperRegistrationAsync(DeveloperRegistrationName name, st::CancellationToken cancellationToken) =>
            GetDeveloperRegistrationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Unregister the calling GCP from the calling shopping account. Note that the
        /// GCP will still be able to access the API for at most 1 day from the
        /// unregister succussful call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void UnregisterGcp(UnregisterGcpRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Unregister the calling GCP from the calling shopping account. Note that the
        /// GCP will still be able to access the API for at most 1 day from the
        /// unregister succussful call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task UnregisterGcpAsync(UnregisterGcpRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Unregister the calling GCP from the calling shopping account. Note that the
        /// GCP will still be able to access the API for at most 1 day from the
        /// unregister succussful call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task UnregisterGcpAsync(UnregisterGcpRequest request, st::CancellationToken cancellationToken) =>
            UnregisterGcpAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the merchant account that the calling GCP is registered with.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GetAccountForGcpRegistrationResponse GetAccountForGcpRegistration(wkt::Empty request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the merchant account that the calling GCP is registered with.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetAccountForGcpRegistrationResponse> GetAccountForGcpRegistrationAsync(wkt::Empty request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the merchant account that the calling GCP is registered with.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetAccountForGcpRegistrationResponse> GetAccountForGcpRegistrationAsync(wkt::Empty request, st::CancellationToken cancellationToken) =>
            GetAccountForGcpRegistrationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DeveloperRegistrationService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to access Developer Registration.
    /// </remarks>
    public sealed partial class DeveloperRegistrationServiceClientImpl : DeveloperRegistrationServiceClient
    {
        private readonly gaxgrpc::ApiCall<RegisterGcpRequest, DeveloperRegistration> _callRegisterGcp;

        private readonly gaxgrpc::ApiCall<GetDeveloperRegistrationRequest, DeveloperRegistration> _callGetDeveloperRegistration;

        private readonly gaxgrpc::ApiCall<UnregisterGcpRequest, wkt::Empty> _callUnregisterGcp;

        private readonly gaxgrpc::ApiCall<wkt::Empty, GetAccountForGcpRegistrationResponse> _callGetAccountForGcpRegistration;

        /// <summary>
        /// Constructs a client wrapper for the DeveloperRegistrationService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="DeveloperRegistrationServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DeveloperRegistrationServiceClientImpl(DeveloperRegistrationService.DeveloperRegistrationServiceClient grpcClient, DeveloperRegistrationServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DeveloperRegistrationServiceSettings effectiveSettings = settings ?? DeveloperRegistrationServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callRegisterGcp = clientHelper.BuildApiCall<RegisterGcpRequest, DeveloperRegistration>("RegisterGcp", grpcClient.RegisterGcpAsync, grpcClient.RegisterGcp, effectiveSettings.RegisterGcpSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRegisterGcp);
            Modify_RegisterGcpApiCall(ref _callRegisterGcp);
            _callGetDeveloperRegistration = clientHelper.BuildApiCall<GetDeveloperRegistrationRequest, DeveloperRegistration>("GetDeveloperRegistration", grpcClient.GetDeveloperRegistrationAsync, grpcClient.GetDeveloperRegistration, effectiveSettings.GetDeveloperRegistrationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDeveloperRegistration);
            Modify_GetDeveloperRegistrationApiCall(ref _callGetDeveloperRegistration);
            _callUnregisterGcp = clientHelper.BuildApiCall<UnregisterGcpRequest, wkt::Empty>("UnregisterGcp", grpcClient.UnregisterGcpAsync, grpcClient.UnregisterGcp, effectiveSettings.UnregisterGcpSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUnregisterGcp);
            Modify_UnregisterGcpApiCall(ref _callUnregisterGcp);
            _callGetAccountForGcpRegistration = clientHelper.BuildApiCall<wkt::Empty, GetAccountForGcpRegistrationResponse>("GetAccountForGcpRegistration", grpcClient.GetAccountForGcpRegistrationAsync, grpcClient.GetAccountForGcpRegistration, effectiveSettings.GetAccountForGcpRegistrationSettings);
            Modify_ApiCall(ref _callGetAccountForGcpRegistration);
            Modify_GetAccountForGcpRegistrationApiCall(ref _callGetAccountForGcpRegistration);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_RegisterGcpApiCall(ref gaxgrpc::ApiCall<RegisterGcpRequest, DeveloperRegistration> call);

        partial void Modify_GetDeveloperRegistrationApiCall(ref gaxgrpc::ApiCall<GetDeveloperRegistrationRequest, DeveloperRegistration> call);

        partial void Modify_UnregisterGcpApiCall(ref gaxgrpc::ApiCall<UnregisterGcpRequest, wkt::Empty> call);

        partial void Modify_GetAccountForGcpRegistrationApiCall(ref gaxgrpc::ApiCall<wkt::Empty, GetAccountForGcpRegistrationResponse> call);

        partial void OnConstruction(DeveloperRegistrationService.DeveloperRegistrationServiceClient grpcClient, DeveloperRegistrationServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DeveloperRegistrationService client</summary>
        public override DeveloperRegistrationService.DeveloperRegistrationServiceClient GrpcClient { get; }

        partial void Modify_RegisterGcpRequest(ref RegisterGcpRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDeveloperRegistrationRequest(ref GetDeveloperRegistrationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UnregisterGcpRequest(ref UnregisterGcpRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_Empty(ref wkt::Empty request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Registers the GCP used for the API call to the shopping account passed in
        /// the request. Will create a user with an "API developer" and add the
        /// "developer_email" as a contact with "API notifications" email preference
        /// on.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DeveloperRegistration RegisterGcp(RegisterGcpRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RegisterGcpRequest(ref request, ref callSettings);
            return _callRegisterGcp.Sync(request, callSettings);
        }

        /// <summary>
        /// Registers the GCP used for the API call to the shopping account passed in
        /// the request. Will create a user with an "API developer" and add the
        /// "developer_email" as a contact with "API notifications" email preference
        /// on.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DeveloperRegistration> RegisterGcpAsync(RegisterGcpRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RegisterGcpRequest(ref request, ref callSettings);
            return _callRegisterGcp.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a developer registration for a merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DeveloperRegistration GetDeveloperRegistration(GetDeveloperRegistrationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeveloperRegistrationRequest(ref request, ref callSettings);
            return _callGetDeveloperRegistration.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a developer registration for a merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DeveloperRegistration> GetDeveloperRegistrationAsync(GetDeveloperRegistrationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeveloperRegistrationRequest(ref request, ref callSettings);
            return _callGetDeveloperRegistration.Async(request, callSettings);
        }

        /// <summary>
        /// Unregister the calling GCP from the calling shopping account. Note that the
        /// GCP will still be able to access the API for at most 1 day from the
        /// unregister succussful call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void UnregisterGcp(UnregisterGcpRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UnregisterGcpRequest(ref request, ref callSettings);
            _callUnregisterGcp.Sync(request, callSettings);
        }

        /// <summary>
        /// Unregister the calling GCP from the calling shopping account. Note that the
        /// GCP will still be able to access the API for at most 1 day from the
        /// unregister succussful call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task UnregisterGcpAsync(UnregisterGcpRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UnregisterGcpRequest(ref request, ref callSettings);
            return _callUnregisterGcp.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves the merchant account that the calling GCP is registered with.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GetAccountForGcpRegistrationResponse GetAccountForGcpRegistration(wkt::Empty request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_Empty(ref request, ref callSettings);
            return _callGetAccountForGcpRegistration.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the merchant account that the calling GCP is registered with.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GetAccountForGcpRegistrationResponse> GetAccountForGcpRegistrationAsync(wkt::Empty request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_Empty(ref request, ref callSettings);
            return _callGetAccountForGcpRegistration.Async(request, callSettings);
        }
    }
}
