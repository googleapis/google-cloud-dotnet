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

namespace Google.Maps.AddressValidation.V1
{
    /// <summary>Settings for <see cref="AddressValidationClient"/> instances.</summary>
    public sealed partial class AddressValidationSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AddressValidationSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AddressValidationSettings"/>.</returns>
        public static AddressValidationSettings GetDefault() => new AddressValidationSettings();

        /// <summary>Constructs a new <see cref="AddressValidationSettings"/> object with default settings.</summary>
        public AddressValidationSettings()
        {
        }

        private AddressValidationSettings(AddressValidationSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ValidateAddressSettings = existing.ValidateAddressSettings;
            ProvideValidationFeedbackSettings = existing.ProvideValidationFeedbackSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AddressValidationSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AddressValidationClient.ValidateAddress</c> and <c>AddressValidationClient.ValidateAddressAsync</c>.
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
        public gaxgrpc::CallSettings ValidateAddressSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AddressValidationClient.ProvideValidationFeedback</c> and
        /// <c>AddressValidationClient.ProvideValidationFeedbackAsync</c>.
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
        public gaxgrpc::CallSettings ProvideValidationFeedbackSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AddressValidationSettings"/> object.</returns>
        public AddressValidationSettings Clone() => new AddressValidationSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AddressValidationClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class AddressValidationClientBuilder : gaxgrpc::ClientBuilderBase<AddressValidationClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AddressValidationSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AddressValidationClientBuilder() : base(AddressValidationClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AddressValidationClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AddressValidationClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AddressValidationClient Build()
        {
            AddressValidationClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AddressValidationClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AddressValidationClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AddressValidationClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AddressValidationClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AddressValidationClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AddressValidationClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AddressValidationClient.ChannelPool;
    }

    /// <summary>AddressValidation client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The service for validating addresses.
    /// </remarks>
    public abstract partial class AddressValidationClient
    {
        /// <summary>
        /// The default endpoint for the AddressValidation service, which is a host of
        /// "addressvalidation.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "addressvalidation.googleapis.com:443";

        /// <summary>The default AddressValidation scopes.</summary>
        /// <remarks>The default AddressValidation scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AddressValidation.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AddressValidationClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AddressValidationClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AddressValidationClient"/>.</returns>
        public static stt::Task<AddressValidationClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AddressValidationClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AddressValidationClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AddressValidationClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AddressValidationClient"/>.</returns>
        public static AddressValidationClient Create() => new AddressValidationClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AddressValidationClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AddressValidationSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AddressValidationClient"/>.</returns>
        internal static AddressValidationClient Create(grpccore::CallInvoker callInvoker, AddressValidationSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AddressValidation.AddressValidationClient grpcClient = new AddressValidation.AddressValidationClient(callInvoker);
            return new AddressValidationClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AddressValidation client</summary>
        public virtual AddressValidation.AddressValidationClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Validates an address.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ValidateAddressResponse ValidateAddress(ValidateAddressRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Validates an address.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ValidateAddressResponse> ValidateAddressAsync(ValidateAddressRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Validates an address.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ValidateAddressResponse> ValidateAddressAsync(ValidateAddressRequest request, st::CancellationToken cancellationToken) =>
            ValidateAddressAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Feedback about the outcome of the sequence of validation attempts. This
        /// should be the last call made after a sequence of validation calls for the
        /// same address, and should be called once the transaction is concluded. This
        /// should only be sent once for the sequence of `ValidateAddress` requests
        /// needed to validate an address fully.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProvideValidationFeedbackResponse ProvideValidationFeedback(ProvideValidationFeedbackRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Feedback about the outcome of the sequence of validation attempts. This
        /// should be the last call made after a sequence of validation calls for the
        /// same address, and should be called once the transaction is concluded. This
        /// should only be sent once for the sequence of `ValidateAddress` requests
        /// needed to validate an address fully.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProvideValidationFeedbackResponse> ProvideValidationFeedbackAsync(ProvideValidationFeedbackRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Feedback about the outcome of the sequence of validation attempts. This
        /// should be the last call made after a sequence of validation calls for the
        /// same address, and should be called once the transaction is concluded. This
        /// should only be sent once for the sequence of `ValidateAddress` requests
        /// needed to validate an address fully.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProvideValidationFeedbackResponse> ProvideValidationFeedbackAsync(ProvideValidationFeedbackRequest request, st::CancellationToken cancellationToken) =>
            ProvideValidationFeedbackAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AddressValidation client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The service for validating addresses.
    /// </remarks>
    public sealed partial class AddressValidationClientImpl : AddressValidationClient
    {
        private readonly gaxgrpc::ApiCall<ValidateAddressRequest, ValidateAddressResponse> _callValidateAddress;

        private readonly gaxgrpc::ApiCall<ProvideValidationFeedbackRequest, ProvideValidationFeedbackResponse> _callProvideValidationFeedback;

        /// <summary>
        /// Constructs a client wrapper for the AddressValidation service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AddressValidationSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AddressValidationClientImpl(AddressValidation.AddressValidationClient grpcClient, AddressValidationSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AddressValidationSettings effectiveSettings = settings ?? AddressValidationSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callValidateAddress = clientHelper.BuildApiCall<ValidateAddressRequest, ValidateAddressResponse>("ValidateAddress", grpcClient.ValidateAddressAsync, grpcClient.ValidateAddress, effectiveSettings.ValidateAddressSettings);
            Modify_ApiCall(ref _callValidateAddress);
            Modify_ValidateAddressApiCall(ref _callValidateAddress);
            _callProvideValidationFeedback = clientHelper.BuildApiCall<ProvideValidationFeedbackRequest, ProvideValidationFeedbackResponse>("ProvideValidationFeedback", grpcClient.ProvideValidationFeedbackAsync, grpcClient.ProvideValidationFeedback, effectiveSettings.ProvideValidationFeedbackSettings);
            Modify_ApiCall(ref _callProvideValidationFeedback);
            Modify_ProvideValidationFeedbackApiCall(ref _callProvideValidationFeedback);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ValidateAddressApiCall(ref gaxgrpc::ApiCall<ValidateAddressRequest, ValidateAddressResponse> call);

        partial void Modify_ProvideValidationFeedbackApiCall(ref gaxgrpc::ApiCall<ProvideValidationFeedbackRequest, ProvideValidationFeedbackResponse> call);

        partial void OnConstruction(AddressValidation.AddressValidationClient grpcClient, AddressValidationSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AddressValidation client</summary>
        public override AddressValidation.AddressValidationClient GrpcClient { get; }

        partial void Modify_ValidateAddressRequest(ref ValidateAddressRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ProvideValidationFeedbackRequest(ref ProvideValidationFeedbackRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Validates an address.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ValidateAddressResponse ValidateAddress(ValidateAddressRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ValidateAddressRequest(ref request, ref callSettings);
            return _callValidateAddress.Sync(request, callSettings);
        }

        /// <summary>
        /// Validates an address.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ValidateAddressResponse> ValidateAddressAsync(ValidateAddressRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ValidateAddressRequest(ref request, ref callSettings);
            return _callValidateAddress.Async(request, callSettings);
        }

        /// <summary>
        /// Feedback about the outcome of the sequence of validation attempts. This
        /// should be the last call made after a sequence of validation calls for the
        /// same address, and should be called once the transaction is concluded. This
        /// should only be sent once for the sequence of `ValidateAddress` requests
        /// needed to validate an address fully.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ProvideValidationFeedbackResponse ProvideValidationFeedback(ProvideValidationFeedbackRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ProvideValidationFeedbackRequest(ref request, ref callSettings);
            return _callProvideValidationFeedback.Sync(request, callSettings);
        }

        /// <summary>
        /// Feedback about the outcome of the sequence of validation attempts. This
        /// should be the last call made after a sequence of validation calls for the
        /// same address, and should be called once the transaction is concluded. This
        /// should only be sent once for the sequence of `ValidateAddress` requests
        /// needed to validate an address fully.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ProvideValidationFeedbackResponse> ProvideValidationFeedbackAsync(ProvideValidationFeedbackRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ProvideValidationFeedbackRequest(ref request, ref callSettings);
            return _callProvideValidationFeedback.Async(request, callSettings);
        }
    }
}
