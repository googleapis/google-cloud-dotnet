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

namespace Google.Shopping.Merchant.Accounts.V1Beta
{
    /// <summary>Settings for <see cref="TermsOfServiceAgreementStateServiceClient"/> instances.</summary>
    public sealed partial class TermsOfServiceAgreementStateServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="TermsOfServiceAgreementStateServiceSettings"/>.
        /// </summary>
        /// <returns>A new instance of the default <see cref="TermsOfServiceAgreementStateServiceSettings"/>.</returns>
        public static TermsOfServiceAgreementStateServiceSettings GetDefault() =>
            new TermsOfServiceAgreementStateServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="TermsOfServiceAgreementStateServiceSettings"/> object with default settings.
        /// </summary>
        public TermsOfServiceAgreementStateServiceSettings()
        {
        }

        private TermsOfServiceAgreementStateServiceSettings(TermsOfServiceAgreementStateServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetTermsOfServiceAgreementStateSettings = existing.GetTermsOfServiceAgreementStateSettings;
            RetrieveForApplicationTermsOfServiceAgreementStateSettings = existing.RetrieveForApplicationTermsOfServiceAgreementStateSettings;
            OnCopy(existing);
        }

        partial void OnCopy(TermsOfServiceAgreementStateServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TermsOfServiceAgreementStateServiceClient.GetTermsOfServiceAgreementState</c> and
        /// <c>TermsOfServiceAgreementStateServiceClient.GetTermsOfServiceAgreementStateAsync</c>.
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
        public gaxgrpc::CallSettings GetTermsOfServiceAgreementStateSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TermsOfServiceAgreementStateServiceClient.RetrieveForApplicationTermsOfServiceAgreementState</c> and
        /// <c>TermsOfServiceAgreementStateServiceClient.RetrieveForApplicationTermsOfServiceAgreementStateAsync</c>.
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
        public gaxgrpc::CallSettings RetrieveForApplicationTermsOfServiceAgreementStateSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="TermsOfServiceAgreementStateServiceSettings"/> object.</returns>
        public TermsOfServiceAgreementStateServiceSettings Clone() => new TermsOfServiceAgreementStateServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="TermsOfServiceAgreementStateServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class TermsOfServiceAgreementStateServiceClientBuilder : gaxgrpc::ClientBuilderBase<TermsOfServiceAgreementStateServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public TermsOfServiceAgreementStateServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public TermsOfServiceAgreementStateServiceClientBuilder() : base(TermsOfServiceAgreementStateServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref TermsOfServiceAgreementStateServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<TermsOfServiceAgreementStateServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override TermsOfServiceAgreementStateServiceClient Build()
        {
            TermsOfServiceAgreementStateServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<TermsOfServiceAgreementStateServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<TermsOfServiceAgreementStateServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private TermsOfServiceAgreementStateServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return TermsOfServiceAgreementStateServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<TermsOfServiceAgreementStateServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TermsOfServiceAgreementStateServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => TermsOfServiceAgreementStateServiceClient.ChannelPool;
    }

    /// <summary>TermsOfServiceAgreementStateService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to support `TermsOfServiceAgreementState` API.
    /// </remarks>
    public abstract partial class TermsOfServiceAgreementStateServiceClient
    {
        /// <summary>
        /// The default endpoint for the TermsOfServiceAgreementStateService service, which is a host of
        /// "merchantapi.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default TermsOfServiceAgreementStateService scopes.</summary>
        /// <remarks>
        /// The default TermsOfServiceAgreementStateService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(TermsOfServiceAgreementStateService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="TermsOfServiceAgreementStateServiceClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="TermsOfServiceAgreementStateServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>
        /// The task representing the created <see cref="TermsOfServiceAgreementStateServiceClient"/>.
        /// </returns>
        public static stt::Task<TermsOfServiceAgreementStateServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new TermsOfServiceAgreementStateServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="TermsOfServiceAgreementStateServiceClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="TermsOfServiceAgreementStateServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="TermsOfServiceAgreementStateServiceClient"/>.</returns>
        public static TermsOfServiceAgreementStateServiceClient Create() =>
            new TermsOfServiceAgreementStateServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="TermsOfServiceAgreementStateServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="TermsOfServiceAgreementStateServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="TermsOfServiceAgreementStateServiceClient"/>.</returns>
        internal static TermsOfServiceAgreementStateServiceClient Create(grpccore::CallInvoker callInvoker, TermsOfServiceAgreementStateServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            TermsOfServiceAgreementStateService.TermsOfServiceAgreementStateServiceClient grpcClient = new TermsOfServiceAgreementStateService.TermsOfServiceAgreementStateServiceClient(callInvoker);
            return new TermsOfServiceAgreementStateServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC TermsOfServiceAgreementStateService client</summary>
        public virtual TermsOfServiceAgreementStateService.TermsOfServiceAgreementStateServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the state of a terms of service agreement.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TermsOfServiceAgreementState GetTermsOfServiceAgreementState(GetTermsOfServiceAgreementStateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the state of a terms of service agreement.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TermsOfServiceAgreementState> GetTermsOfServiceAgreementStateAsync(GetTermsOfServiceAgreementStateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the state of a terms of service agreement.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TermsOfServiceAgreementState> GetTermsOfServiceAgreementStateAsync(GetTermsOfServiceAgreementStateRequest request, st::CancellationToken cancellationToken) =>
            GetTermsOfServiceAgreementStateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the state of a terms of service agreement.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the terms of service version.
        /// Format: `accounts/{account}/termsOfServiceAgreementState/{identifier}`
        /// The identifier format is: `{TermsOfServiceKind}-{country}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TermsOfServiceAgreementState GetTermsOfServiceAgreementState(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTermsOfServiceAgreementState(new GetTermsOfServiceAgreementStateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the state of a terms of service agreement.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the terms of service version.
        /// Format: `accounts/{account}/termsOfServiceAgreementState/{identifier}`
        /// The identifier format is: `{TermsOfServiceKind}-{country}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TermsOfServiceAgreementState> GetTermsOfServiceAgreementStateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTermsOfServiceAgreementStateAsync(new GetTermsOfServiceAgreementStateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the state of a terms of service agreement.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the terms of service version.
        /// Format: `accounts/{account}/termsOfServiceAgreementState/{identifier}`
        /// The identifier format is: `{TermsOfServiceKind}-{country}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TermsOfServiceAgreementState> GetTermsOfServiceAgreementStateAsync(string name, st::CancellationToken cancellationToken) =>
            GetTermsOfServiceAgreementStateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the state of a terms of service agreement.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the terms of service version.
        /// Format: `accounts/{account}/termsOfServiceAgreementState/{identifier}`
        /// The identifier format is: `{TermsOfServiceKind}-{country}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TermsOfServiceAgreementState GetTermsOfServiceAgreementState(TermsOfServiceAgreementStateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTermsOfServiceAgreementState(new GetTermsOfServiceAgreementStateRequest
            {
                TermsOfServiceAgreementStateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the state of a terms of service agreement.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the terms of service version.
        /// Format: `accounts/{account}/termsOfServiceAgreementState/{identifier}`
        /// The identifier format is: `{TermsOfServiceKind}-{country}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TermsOfServiceAgreementState> GetTermsOfServiceAgreementStateAsync(TermsOfServiceAgreementStateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTermsOfServiceAgreementStateAsync(new GetTermsOfServiceAgreementStateRequest
            {
                TermsOfServiceAgreementStateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the state of a terms of service agreement.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the terms of service version.
        /// Format: `accounts/{account}/termsOfServiceAgreementState/{identifier}`
        /// The identifier format is: `{TermsOfServiceKind}-{country}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TermsOfServiceAgreementState> GetTermsOfServiceAgreementStateAsync(TermsOfServiceAgreementStateName name, st::CancellationToken cancellationToken) =>
            GetTermsOfServiceAgreementStateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the state of the agreement for the application terms of service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TermsOfServiceAgreementState RetrieveForApplicationTermsOfServiceAgreementState(RetrieveForApplicationTermsOfServiceAgreementStateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the state of the agreement for the application terms of service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TermsOfServiceAgreementState> RetrieveForApplicationTermsOfServiceAgreementStateAsync(RetrieveForApplicationTermsOfServiceAgreementStateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the state of the agreement for the application terms of service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TermsOfServiceAgreementState> RetrieveForApplicationTermsOfServiceAgreementStateAsync(RetrieveForApplicationTermsOfServiceAgreementStateRequest request, st::CancellationToken cancellationToken) =>
            RetrieveForApplicationTermsOfServiceAgreementStateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the state of the agreement for the application terms of service.
        /// </summary>
        /// <param name="parent">
        /// Required. The account for which to get a TermsOfServiceAgreementState
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TermsOfServiceAgreementState RetrieveForApplicationTermsOfServiceAgreementState(string parent, gaxgrpc::CallSettings callSettings = null) =>
            RetrieveForApplicationTermsOfServiceAgreementState(new RetrieveForApplicationTermsOfServiceAgreementStateRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Retrieves the state of the agreement for the application terms of service.
        /// </summary>
        /// <param name="parent">
        /// Required. The account for which to get a TermsOfServiceAgreementState
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TermsOfServiceAgreementState> RetrieveForApplicationTermsOfServiceAgreementStateAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            RetrieveForApplicationTermsOfServiceAgreementStateAsync(new RetrieveForApplicationTermsOfServiceAgreementStateRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Retrieves the state of the agreement for the application terms of service.
        /// </summary>
        /// <param name="parent">
        /// Required. The account for which to get a TermsOfServiceAgreementState
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TermsOfServiceAgreementState> RetrieveForApplicationTermsOfServiceAgreementStateAsync(string parent, st::CancellationToken cancellationToken) =>
            RetrieveForApplicationTermsOfServiceAgreementStateAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the state of the agreement for the application terms of service.
        /// </summary>
        /// <param name="parent">
        /// Required. The account for which to get a TermsOfServiceAgreementState
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TermsOfServiceAgreementState RetrieveForApplicationTermsOfServiceAgreementState(AccountName parent, gaxgrpc::CallSettings callSettings = null) =>
            RetrieveForApplicationTermsOfServiceAgreementState(new RetrieveForApplicationTermsOfServiceAgreementStateRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Retrieves the state of the agreement for the application terms of service.
        /// </summary>
        /// <param name="parent">
        /// Required. The account for which to get a TermsOfServiceAgreementState
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TermsOfServiceAgreementState> RetrieveForApplicationTermsOfServiceAgreementStateAsync(AccountName parent, gaxgrpc::CallSettings callSettings = null) =>
            RetrieveForApplicationTermsOfServiceAgreementStateAsync(new RetrieveForApplicationTermsOfServiceAgreementStateRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Retrieves the state of the agreement for the application terms of service.
        /// </summary>
        /// <param name="parent">
        /// Required. The account for which to get a TermsOfServiceAgreementState
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TermsOfServiceAgreementState> RetrieveForApplicationTermsOfServiceAgreementStateAsync(AccountName parent, st::CancellationToken cancellationToken) =>
            RetrieveForApplicationTermsOfServiceAgreementStateAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>TermsOfServiceAgreementStateService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to support `TermsOfServiceAgreementState` API.
    /// </remarks>
    public sealed partial class TermsOfServiceAgreementStateServiceClientImpl : TermsOfServiceAgreementStateServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetTermsOfServiceAgreementStateRequest, TermsOfServiceAgreementState> _callGetTermsOfServiceAgreementState;

        private readonly gaxgrpc::ApiCall<RetrieveForApplicationTermsOfServiceAgreementStateRequest, TermsOfServiceAgreementState> _callRetrieveForApplicationTermsOfServiceAgreementState;

        /// <summary>
        /// Constructs a client wrapper for the TermsOfServiceAgreementStateService service, with the specified gRPC
        /// client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="TermsOfServiceAgreementStateServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public TermsOfServiceAgreementStateServiceClientImpl(TermsOfServiceAgreementStateService.TermsOfServiceAgreementStateServiceClient grpcClient, TermsOfServiceAgreementStateServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            TermsOfServiceAgreementStateServiceSettings effectiveSettings = settings ?? TermsOfServiceAgreementStateServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetTermsOfServiceAgreementState = clientHelper.BuildApiCall<GetTermsOfServiceAgreementStateRequest, TermsOfServiceAgreementState>("GetTermsOfServiceAgreementState", grpcClient.GetTermsOfServiceAgreementStateAsync, grpcClient.GetTermsOfServiceAgreementState, effectiveSettings.GetTermsOfServiceAgreementStateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTermsOfServiceAgreementState);
            Modify_GetTermsOfServiceAgreementStateApiCall(ref _callGetTermsOfServiceAgreementState);
            _callRetrieveForApplicationTermsOfServiceAgreementState = clientHelper.BuildApiCall<RetrieveForApplicationTermsOfServiceAgreementStateRequest, TermsOfServiceAgreementState>("RetrieveForApplicationTermsOfServiceAgreementState", grpcClient.RetrieveForApplicationTermsOfServiceAgreementStateAsync, grpcClient.RetrieveForApplicationTermsOfServiceAgreementState, effectiveSettings.RetrieveForApplicationTermsOfServiceAgreementStateSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callRetrieveForApplicationTermsOfServiceAgreementState);
            Modify_RetrieveForApplicationTermsOfServiceAgreementStateApiCall(ref _callRetrieveForApplicationTermsOfServiceAgreementState);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetTermsOfServiceAgreementStateApiCall(ref gaxgrpc::ApiCall<GetTermsOfServiceAgreementStateRequest, TermsOfServiceAgreementState> call);

        partial void Modify_RetrieveForApplicationTermsOfServiceAgreementStateApiCall(ref gaxgrpc::ApiCall<RetrieveForApplicationTermsOfServiceAgreementStateRequest, TermsOfServiceAgreementState> call);

        partial void OnConstruction(TermsOfServiceAgreementStateService.TermsOfServiceAgreementStateServiceClient grpcClient, TermsOfServiceAgreementStateServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC TermsOfServiceAgreementStateService client</summary>
        public override TermsOfServiceAgreementStateService.TermsOfServiceAgreementStateServiceClient GrpcClient { get; }

        partial void Modify_GetTermsOfServiceAgreementStateRequest(ref GetTermsOfServiceAgreementStateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RetrieveForApplicationTermsOfServiceAgreementStateRequest(ref RetrieveForApplicationTermsOfServiceAgreementStateRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the state of a terms of service agreement.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TermsOfServiceAgreementState GetTermsOfServiceAgreementState(GetTermsOfServiceAgreementStateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTermsOfServiceAgreementStateRequest(ref request, ref callSettings);
            return _callGetTermsOfServiceAgreementState.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the state of a terms of service agreement.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TermsOfServiceAgreementState> GetTermsOfServiceAgreementStateAsync(GetTermsOfServiceAgreementStateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTermsOfServiceAgreementStateRequest(ref request, ref callSettings);
            return _callGetTermsOfServiceAgreementState.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves the state of the agreement for the application terms of service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TermsOfServiceAgreementState RetrieveForApplicationTermsOfServiceAgreementState(RetrieveForApplicationTermsOfServiceAgreementStateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RetrieveForApplicationTermsOfServiceAgreementStateRequest(ref request, ref callSettings);
            return _callRetrieveForApplicationTermsOfServiceAgreementState.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the state of the agreement for the application terms of service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TermsOfServiceAgreementState> RetrieveForApplicationTermsOfServiceAgreementStateAsync(RetrieveForApplicationTermsOfServiceAgreementStateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RetrieveForApplicationTermsOfServiceAgreementStateRequest(ref request, ref callSettings);
            return _callRetrieveForApplicationTermsOfServiceAgreementState.Async(request, callSettings);
        }
    }
}
