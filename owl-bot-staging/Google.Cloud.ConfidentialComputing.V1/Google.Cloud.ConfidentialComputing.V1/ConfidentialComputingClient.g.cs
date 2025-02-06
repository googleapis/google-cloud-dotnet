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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gcl = Google.Cloud.Location;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.ConfidentialComputing.V1
{
    /// <summary>Settings for <see cref="ConfidentialComputingClient"/> instances.</summary>
    public sealed partial class ConfidentialComputingSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ConfidentialComputingSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ConfidentialComputingSettings"/>.</returns>
        public static ConfidentialComputingSettings GetDefault() => new ConfidentialComputingSettings();

        /// <summary>
        /// Constructs a new <see cref="ConfidentialComputingSettings"/> object with default settings.
        /// </summary>
        public ConfidentialComputingSettings()
        {
        }

        private ConfidentialComputingSettings(ConfidentialComputingSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateChallengeSettings = existing.CreateChallengeSettings;
            VerifyAttestationSettings = existing.VerifyAttestationSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ConfidentialComputingSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfidentialComputingClient.CreateChallenge</c> and <c>ConfidentialComputingClient.CreateChallengeAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateChallengeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfidentialComputingClient.VerifyAttestation</c> and
        /// <c>ConfidentialComputingClient.VerifyAttestationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings VerifyAttestationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ConfidentialComputingSettings"/> object.</returns>
        public ConfidentialComputingSettings Clone() => new ConfidentialComputingSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ConfidentialComputingClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ConfidentialComputingClientBuilder : gaxgrpc::ClientBuilderBase<ConfidentialComputingClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ConfidentialComputingSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ConfidentialComputingClientBuilder() : base(ConfidentialComputingClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ConfidentialComputingClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ConfidentialComputingClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ConfidentialComputingClient Build()
        {
            ConfidentialComputingClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ConfidentialComputingClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ConfidentialComputingClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ConfidentialComputingClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ConfidentialComputingClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ConfidentialComputingClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ConfidentialComputingClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ConfidentialComputingClient.ChannelPool;
    }

    /// <summary>ConfidentialComputing client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public abstract partial class ConfidentialComputingClient
    {
        /// <summary>
        /// The default endpoint for the ConfidentialComputing service, which is a host of
        /// "confidentialcomputing.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "confidentialcomputing.googleapis.com:443";

        /// <summary>The default ConfidentialComputing scopes.</summary>
        /// <remarks>
        /// The default ConfidentialComputing scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ConfidentialComputing.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ConfidentialComputingClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ConfidentialComputingClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ConfidentialComputingClient"/>.</returns>
        public static stt::Task<ConfidentialComputingClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ConfidentialComputingClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ConfidentialComputingClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ConfidentialComputingClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ConfidentialComputingClient"/>.</returns>
        public static ConfidentialComputingClient Create() => new ConfidentialComputingClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ConfidentialComputingClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ConfidentialComputingSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ConfidentialComputingClient"/>.</returns>
        internal static ConfidentialComputingClient Create(grpccore::CallInvoker callInvoker, ConfidentialComputingSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ConfidentialComputing.ConfidentialComputingClient grpcClient = new ConfidentialComputing.ConfidentialComputingClient(callInvoker);
            return new ConfidentialComputingClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ConfidentialComputing client</summary>
        public virtual ConfidentialComputing.ConfidentialComputingClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Challenge in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Challenge CreateChallenge(CreateChallengeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Challenge in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Challenge> CreateChallengeAsync(CreateChallengeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Challenge in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Challenge> CreateChallengeAsync(CreateChallengeRequest request, st::CancellationToken cancellationToken) =>
            CreateChallengeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Challenge in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location where the Challenge will be
        /// used, in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="challenge">
        /// Required. The Challenge to be created. Currently this field can be empty as
        /// all the Challenge fields are set by the server.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Challenge CreateChallenge(string parent, Challenge challenge, gaxgrpc::CallSettings callSettings = null) =>
            CreateChallenge(new CreateChallengeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Challenge = gax::GaxPreconditions.CheckNotNull(challenge, nameof(challenge)),
            }, callSettings);

        /// <summary>
        /// Creates a new Challenge in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location where the Challenge will be
        /// used, in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="challenge">
        /// Required. The Challenge to be created. Currently this field can be empty as
        /// all the Challenge fields are set by the server.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Challenge> CreateChallengeAsync(string parent, Challenge challenge, gaxgrpc::CallSettings callSettings = null) =>
            CreateChallengeAsync(new CreateChallengeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Challenge = gax::GaxPreconditions.CheckNotNull(challenge, nameof(challenge)),
            }, callSettings);

        /// <summary>
        /// Creates a new Challenge in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location where the Challenge will be
        /// used, in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="challenge">
        /// Required. The Challenge to be created. Currently this field can be empty as
        /// all the Challenge fields are set by the server.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Challenge> CreateChallengeAsync(string parent, Challenge challenge, st::CancellationToken cancellationToken) =>
            CreateChallengeAsync(parent, challenge, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Challenge in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location where the Challenge will be
        /// used, in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="challenge">
        /// Required. The Challenge to be created. Currently this field can be empty as
        /// all the Challenge fields are set by the server.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Challenge CreateChallenge(gagr::LocationName parent, Challenge challenge, gaxgrpc::CallSettings callSettings = null) =>
            CreateChallenge(new CreateChallengeRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Challenge = gax::GaxPreconditions.CheckNotNull(challenge, nameof(challenge)),
            }, callSettings);

        /// <summary>
        /// Creates a new Challenge in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location where the Challenge will be
        /// used, in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="challenge">
        /// Required. The Challenge to be created. Currently this field can be empty as
        /// all the Challenge fields are set by the server.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Challenge> CreateChallengeAsync(gagr::LocationName parent, Challenge challenge, gaxgrpc::CallSettings callSettings = null) =>
            CreateChallengeAsync(new CreateChallengeRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Challenge = gax::GaxPreconditions.CheckNotNull(challenge, nameof(challenge)),
            }, callSettings);

        /// <summary>
        /// Creates a new Challenge in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location where the Challenge will be
        /// used, in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="challenge">
        /// Required. The Challenge to be created. Currently this field can be empty as
        /// all the Challenge fields are set by the server.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Challenge> CreateChallengeAsync(gagr::LocationName parent, Challenge challenge, st::CancellationToken cancellationToken) =>
            CreateChallengeAsync(parent, challenge, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Verifies the provided attestation info, returning a signed OIDC token.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VerifyAttestationResponse VerifyAttestation(VerifyAttestationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Verifies the provided attestation info, returning a signed OIDC token.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VerifyAttestationResponse> VerifyAttestationAsync(VerifyAttestationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Verifies the provided attestation info, returning a signed OIDC token.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VerifyAttestationResponse> VerifyAttestationAsync(VerifyAttestationRequest request, st::CancellationToken cancellationToken) =>
            VerifyAttestationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ConfidentialComputing client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public sealed partial class ConfidentialComputingClientImpl : ConfidentialComputingClient
    {
        private readonly gaxgrpc::ApiCall<CreateChallengeRequest, Challenge> _callCreateChallenge;

        private readonly gaxgrpc::ApiCall<VerifyAttestationRequest, VerifyAttestationResponse> _callVerifyAttestation;

        /// <summary>
        /// Constructs a client wrapper for the ConfidentialComputing service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ConfidentialComputingSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ConfidentialComputingClientImpl(ConfidentialComputing.ConfidentialComputingClient grpcClient, ConfidentialComputingSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ConfidentialComputingSettings effectiveSettings = settings ?? ConfidentialComputingSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreateChallenge = clientHelper.BuildApiCall<CreateChallengeRequest, Challenge>("CreateChallenge", grpcClient.CreateChallengeAsync, grpcClient.CreateChallenge, effectiveSettings.CreateChallengeSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateChallenge);
            Modify_CreateChallengeApiCall(ref _callCreateChallenge);
            _callVerifyAttestation = clientHelper.BuildApiCall<VerifyAttestationRequest, VerifyAttestationResponse>("VerifyAttestation", grpcClient.VerifyAttestationAsync, grpcClient.VerifyAttestation, effectiveSettings.VerifyAttestationSettings).WithGoogleRequestParam("challenge", request => request.Challenge);
            Modify_ApiCall(ref _callVerifyAttestation);
            Modify_VerifyAttestationApiCall(ref _callVerifyAttestation);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateChallengeApiCall(ref gaxgrpc::ApiCall<CreateChallengeRequest, Challenge> call);

        partial void Modify_VerifyAttestationApiCall(ref gaxgrpc::ApiCall<VerifyAttestationRequest, VerifyAttestationResponse> call);

        partial void OnConstruction(ConfidentialComputing.ConfidentialComputingClient grpcClient, ConfidentialComputingSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ConfidentialComputing client</summary>
        public override ConfidentialComputing.ConfidentialComputingClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreateChallengeRequest(ref CreateChallengeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_VerifyAttestationRequest(ref VerifyAttestationRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a new Challenge in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Challenge CreateChallenge(CreateChallengeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateChallengeRequest(ref request, ref callSettings);
            return _callCreateChallenge.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new Challenge in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Challenge> CreateChallengeAsync(CreateChallengeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateChallengeRequest(ref request, ref callSettings);
            return _callCreateChallenge.Async(request, callSettings);
        }

        /// <summary>
        /// Verifies the provided attestation info, returning a signed OIDC token.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override VerifyAttestationResponse VerifyAttestation(VerifyAttestationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_VerifyAttestationRequest(ref request, ref callSettings);
            return _callVerifyAttestation.Sync(request, callSettings);
        }

        /// <summary>
        /// Verifies the provided attestation info, returning a signed OIDC token.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<VerifyAttestationResponse> VerifyAttestationAsync(VerifyAttestationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_VerifyAttestationRequest(ref request, ref callSettings);
            return _callVerifyAttestation.Async(request, callSettings);
        }
    }

    public static partial class ConfidentialComputing
    {
        public partial class ConfidentialComputingClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="gcl::Locations.LocationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gcl::Locations.LocationsClient"/> for the same target as this client.
            /// </returns>
            public virtual gcl::Locations.LocationsClient CreateLocationsClient() =>
                new gcl::Locations.LocationsClient(CallInvoker);
        }
    }
}
