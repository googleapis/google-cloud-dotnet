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

namespace Google.Cloud.BinaryAuthorization.V1
{
    /// <summary>Settings for <see cref="ValidationHelperV1Client"/> instances.</summary>
    public sealed partial class ValidationHelperV1Settings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ValidationHelperV1Settings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ValidationHelperV1Settings"/>.</returns>
        public static ValidationHelperV1Settings GetDefault() => new ValidationHelperV1Settings();

        /// <summary>Constructs a new <see cref="ValidationHelperV1Settings"/> object with default settings.</summary>
        public ValidationHelperV1Settings()
        {
        }

        private ValidationHelperV1Settings(ValidationHelperV1Settings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ValidateAttestationOccurrenceSettings = existing.ValidateAttestationOccurrenceSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ValidationHelperV1Settings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ValidationHelperV1Client.ValidateAttestationOccurrence</c> and
        /// <c>ValidationHelperV1Client.ValidateAttestationOccurrenceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ValidateAttestationOccurrenceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ValidationHelperV1Settings"/> object.</returns>
        public ValidationHelperV1Settings Clone() => new ValidationHelperV1Settings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ValidationHelperV1Client"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ValidationHelperV1ClientBuilder : gaxgrpc::ClientBuilderBase<ValidationHelperV1Client>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ValidationHelperV1Settings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ValidationHelperV1ClientBuilder() : base(ValidationHelperV1Client.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ValidationHelperV1Client client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ValidationHelperV1Client> task);

        /// <summary>Builds the resulting client.</summary>
        public override ValidationHelperV1Client Build()
        {
            ValidationHelperV1Client client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ValidationHelperV1Client> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ValidationHelperV1Client> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ValidationHelperV1Client BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ValidationHelperV1Client.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ValidationHelperV1Client> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ValidationHelperV1Client.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ValidationHelperV1Client.ChannelPool;
    }

    /// <summary>ValidationHelperV1 client wrapper, for convenient use.</summary>
    /// <remarks>
    /// BinAuthz Attestor verification
    /// </remarks>
    public abstract partial class ValidationHelperV1Client
    {
        /// <summary>
        /// The default endpoint for the ValidationHelperV1 service, which is a host of
        /// "binaryauthorization.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "binaryauthorization.googleapis.com:443";

        /// <summary>The default ValidationHelperV1 scopes.</summary>
        /// <remarks>
        /// The default ValidationHelperV1 scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ValidationHelperV1.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ValidationHelperV1Client"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ValidationHelperV1ClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ValidationHelperV1Client"/>.</returns>
        public static stt::Task<ValidationHelperV1Client> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ValidationHelperV1ClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ValidationHelperV1Client"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ValidationHelperV1ClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="ValidationHelperV1Client"/>.</returns>
        public static ValidationHelperV1Client Create() => new ValidationHelperV1ClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ValidationHelperV1Client"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ValidationHelperV1Settings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ValidationHelperV1Client"/>.</returns>
        internal static ValidationHelperV1Client Create(grpccore::CallInvoker callInvoker, ValidationHelperV1Settings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ValidationHelperV1.ValidationHelperV1Client grpcClient = new ValidationHelperV1.ValidationHelperV1Client(callInvoker);
            return new ValidationHelperV1ClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ValidationHelperV1 client</summary>
        public virtual ValidationHelperV1.ValidationHelperV1Client GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns whether the given Attestation for the given image URI
        /// was signed by the given Attestor
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ValidateAttestationOccurrenceResponse ValidateAttestationOccurrence(ValidateAttestationOccurrenceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns whether the given Attestation for the given image URI
        /// was signed by the given Attestor
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ValidateAttestationOccurrenceResponse> ValidateAttestationOccurrenceAsync(ValidateAttestationOccurrenceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns whether the given Attestation for the given image URI
        /// was signed by the given Attestor
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ValidateAttestationOccurrenceResponse> ValidateAttestationOccurrenceAsync(ValidateAttestationOccurrenceRequest request, st::CancellationToken cancellationToken) =>
            ValidateAttestationOccurrenceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ValidationHelperV1 client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// BinAuthz Attestor verification
    /// </remarks>
    public sealed partial class ValidationHelperV1ClientImpl : ValidationHelperV1Client
    {
        private readonly gaxgrpc::ApiCall<ValidateAttestationOccurrenceRequest, ValidateAttestationOccurrenceResponse> _callValidateAttestationOccurrence;

        /// <summary>
        /// Constructs a client wrapper for the ValidationHelperV1 service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ValidationHelperV1Settings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ValidationHelperV1ClientImpl(ValidationHelperV1.ValidationHelperV1Client grpcClient, ValidationHelperV1Settings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ValidationHelperV1Settings effectiveSettings = settings ?? ValidationHelperV1Settings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callValidateAttestationOccurrence = clientHelper.BuildApiCall<ValidateAttestationOccurrenceRequest, ValidateAttestationOccurrenceResponse>("ValidateAttestationOccurrence", grpcClient.ValidateAttestationOccurrenceAsync, grpcClient.ValidateAttestationOccurrence, effectiveSettings.ValidateAttestationOccurrenceSettings).WithGoogleRequestParam("attestor", request => request.Attestor);
            Modify_ApiCall(ref _callValidateAttestationOccurrence);
            Modify_ValidateAttestationOccurrenceApiCall(ref _callValidateAttestationOccurrence);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ValidateAttestationOccurrenceApiCall(ref gaxgrpc::ApiCall<ValidateAttestationOccurrenceRequest, ValidateAttestationOccurrenceResponse> call);

        partial void OnConstruction(ValidationHelperV1.ValidationHelperV1Client grpcClient, ValidationHelperV1Settings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ValidationHelperV1 client</summary>
        public override ValidationHelperV1.ValidationHelperV1Client GrpcClient { get; }

        partial void Modify_ValidateAttestationOccurrenceRequest(ref ValidateAttestationOccurrenceRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns whether the given Attestation for the given image URI
        /// was signed by the given Attestor
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ValidateAttestationOccurrenceResponse ValidateAttestationOccurrence(ValidateAttestationOccurrenceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ValidateAttestationOccurrenceRequest(ref request, ref callSettings);
            return _callValidateAttestationOccurrence.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns whether the given Attestation for the given image URI
        /// was signed by the given Attestor
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ValidateAttestationOccurrenceResponse> ValidateAttestationOccurrenceAsync(ValidateAttestationOccurrenceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ValidateAttestationOccurrenceRequest(ref request, ref callSettings);
            return _callValidateAttestationOccurrence.Async(request, callSettings);
        }
    }
}
