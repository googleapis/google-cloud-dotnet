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
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.Security.PublicCA.V1Beta1
{
    /// <summary>Settings for <see cref="PublicCertificateAuthorityServiceClient"/> instances.</summary>
    public sealed partial class PublicCertificateAuthorityServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="PublicCertificateAuthorityServiceSettings"/>.
        /// </summary>
        /// <returns>A new instance of the default <see cref="PublicCertificateAuthorityServiceSettings"/>.</returns>
        public static PublicCertificateAuthorityServiceSettings GetDefault() =>
            new PublicCertificateAuthorityServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="PublicCertificateAuthorityServiceSettings"/> object with default settings.
        /// </summary>
        public PublicCertificateAuthorityServiceSettings()
        {
        }

        private PublicCertificateAuthorityServiceSettings(PublicCertificateAuthorityServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateExternalAccountKeySettings = existing.CreateExternalAccountKeySettings;
            OnCopy(existing);
        }

        partial void OnCopy(PublicCertificateAuthorityServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublicCertificateAuthorityServiceClient.CreateExternalAccountKey</c> and
        /// <c>PublicCertificateAuthorityServiceClient.CreateExternalAccountKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateExternalAccountKeySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PublicCertificateAuthorityServiceSettings"/> object.</returns>
        public PublicCertificateAuthorityServiceSettings Clone() => new PublicCertificateAuthorityServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PublicCertificateAuthorityServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class PublicCertificateAuthorityServiceClientBuilder : gaxgrpc::ClientBuilderBase<PublicCertificateAuthorityServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PublicCertificateAuthorityServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public PublicCertificateAuthorityServiceClientBuilder() : base(PublicCertificateAuthorityServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref PublicCertificateAuthorityServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PublicCertificateAuthorityServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PublicCertificateAuthorityServiceClient Build()
        {
            PublicCertificateAuthorityServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PublicCertificateAuthorityServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PublicCertificateAuthorityServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PublicCertificateAuthorityServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PublicCertificateAuthorityServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<PublicCertificateAuthorityServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PublicCertificateAuthorityServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PublicCertificateAuthorityServiceClient.ChannelPool;
    }

    /// <summary>PublicCertificateAuthorityService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Manages the resources required for ACME [external account
    /// binding](https://tools.ietf.org/html/rfc8555#section-7.3.4) for
    /// the public certificate authority service.
    /// </remarks>
    public abstract partial class PublicCertificateAuthorityServiceClient
    {
        /// <summary>
        /// The default endpoint for the PublicCertificateAuthorityService service, which is a host of
        /// "publicca.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "publicca.googleapis.com:443";

        /// <summary>The default PublicCertificateAuthorityService scopes.</summary>
        /// <remarks>
        /// The default PublicCertificateAuthorityService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(PublicCertificateAuthorityService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="PublicCertificateAuthorityServiceClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="PublicCertificateAuthorityServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PublicCertificateAuthorityServiceClient"/>.</returns>
        public static stt::Task<PublicCertificateAuthorityServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PublicCertificateAuthorityServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PublicCertificateAuthorityServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="PublicCertificateAuthorityServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PublicCertificateAuthorityServiceClient"/>.</returns>
        public static PublicCertificateAuthorityServiceClient Create() =>
            new PublicCertificateAuthorityServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PublicCertificateAuthorityServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PublicCertificateAuthorityServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="PublicCertificateAuthorityServiceClient"/>.</returns>
        internal static PublicCertificateAuthorityServiceClient Create(grpccore::CallInvoker callInvoker, PublicCertificateAuthorityServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            PublicCertificateAuthorityService.PublicCertificateAuthorityServiceClient grpcClient = new PublicCertificateAuthorityService.PublicCertificateAuthorityServiceClient(callInvoker);
            return new PublicCertificateAuthorityServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC PublicCertificateAuthorityService client</summary>
        public virtual PublicCertificateAuthorityService.PublicCertificateAuthorityServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new [ExternalAccountKey][google.cloud.security.publicca.v1beta1.ExternalAccountKey] bound to the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExternalAccountKey CreateExternalAccountKey(CreateExternalAccountKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new [ExternalAccountKey][google.cloud.security.publicca.v1beta1.ExternalAccountKey] bound to the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExternalAccountKey> CreateExternalAccountKeyAsync(CreateExternalAccountKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new [ExternalAccountKey][google.cloud.security.publicca.v1beta1.ExternalAccountKey] bound to the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExternalAccountKey> CreateExternalAccountKeyAsync(CreateExternalAccountKeyRequest request, st::CancellationToken cancellationToken) =>
            CreateExternalAccountKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new [ExternalAccountKey][google.cloud.security.publicca.v1beta1.ExternalAccountKey] bound to the project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this external_account_key will be created.
        /// Format: projects/[project_id]/locations/[location].
        /// At present only the "global" location is supported.
        /// </param>
        /// <param name="externalAccountKey">
        /// Required. The external account key to create. This field only exists to future-proof
        /// the API. At present, all fields in ExternalAccountKey are output only and
        /// all values are ignored. For the purpose of the
        /// CreateExternalAccountKeyRequest, set it to a default/empty value.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExternalAccountKey CreateExternalAccountKey(string parent, ExternalAccountKey externalAccountKey, gaxgrpc::CallSettings callSettings = null) =>
            CreateExternalAccountKey(new CreateExternalAccountKeyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ExternalAccountKey = gax::GaxPreconditions.CheckNotNull(externalAccountKey, nameof(externalAccountKey)),
            }, callSettings);

        /// <summary>
        /// Creates a new [ExternalAccountKey][google.cloud.security.publicca.v1beta1.ExternalAccountKey] bound to the project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this external_account_key will be created.
        /// Format: projects/[project_id]/locations/[location].
        /// At present only the "global" location is supported.
        /// </param>
        /// <param name="externalAccountKey">
        /// Required. The external account key to create. This field only exists to future-proof
        /// the API. At present, all fields in ExternalAccountKey are output only and
        /// all values are ignored. For the purpose of the
        /// CreateExternalAccountKeyRequest, set it to a default/empty value.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExternalAccountKey> CreateExternalAccountKeyAsync(string parent, ExternalAccountKey externalAccountKey, gaxgrpc::CallSettings callSettings = null) =>
            CreateExternalAccountKeyAsync(new CreateExternalAccountKeyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ExternalAccountKey = gax::GaxPreconditions.CheckNotNull(externalAccountKey, nameof(externalAccountKey)),
            }, callSettings);

        /// <summary>
        /// Creates a new [ExternalAccountKey][google.cloud.security.publicca.v1beta1.ExternalAccountKey] bound to the project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this external_account_key will be created.
        /// Format: projects/[project_id]/locations/[location].
        /// At present only the "global" location is supported.
        /// </param>
        /// <param name="externalAccountKey">
        /// Required. The external account key to create. This field only exists to future-proof
        /// the API. At present, all fields in ExternalAccountKey are output only and
        /// all values are ignored. For the purpose of the
        /// CreateExternalAccountKeyRequest, set it to a default/empty value.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExternalAccountKey> CreateExternalAccountKeyAsync(string parent, ExternalAccountKey externalAccountKey, st::CancellationToken cancellationToken) =>
            CreateExternalAccountKeyAsync(parent, externalAccountKey, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new [ExternalAccountKey][google.cloud.security.publicca.v1beta1.ExternalAccountKey] bound to the project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this external_account_key will be created.
        /// Format: projects/[project_id]/locations/[location].
        /// At present only the "global" location is supported.
        /// </param>
        /// <param name="externalAccountKey">
        /// Required. The external account key to create. This field only exists to future-proof
        /// the API. At present, all fields in ExternalAccountKey are output only and
        /// all values are ignored. For the purpose of the
        /// CreateExternalAccountKeyRequest, set it to a default/empty value.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExternalAccountKey CreateExternalAccountKey(gagr::LocationName parent, ExternalAccountKey externalAccountKey, gaxgrpc::CallSettings callSettings = null) =>
            CreateExternalAccountKey(new CreateExternalAccountKeyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ExternalAccountKey = gax::GaxPreconditions.CheckNotNull(externalAccountKey, nameof(externalAccountKey)),
            }, callSettings);

        /// <summary>
        /// Creates a new [ExternalAccountKey][google.cloud.security.publicca.v1beta1.ExternalAccountKey] bound to the project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this external_account_key will be created.
        /// Format: projects/[project_id]/locations/[location].
        /// At present only the "global" location is supported.
        /// </param>
        /// <param name="externalAccountKey">
        /// Required. The external account key to create. This field only exists to future-proof
        /// the API. At present, all fields in ExternalAccountKey are output only and
        /// all values are ignored. For the purpose of the
        /// CreateExternalAccountKeyRequest, set it to a default/empty value.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExternalAccountKey> CreateExternalAccountKeyAsync(gagr::LocationName parent, ExternalAccountKey externalAccountKey, gaxgrpc::CallSettings callSettings = null) =>
            CreateExternalAccountKeyAsync(new CreateExternalAccountKeyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ExternalAccountKey = gax::GaxPreconditions.CheckNotNull(externalAccountKey, nameof(externalAccountKey)),
            }, callSettings);

        /// <summary>
        /// Creates a new [ExternalAccountKey][google.cloud.security.publicca.v1beta1.ExternalAccountKey] bound to the project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this external_account_key will be created.
        /// Format: projects/[project_id]/locations/[location].
        /// At present only the "global" location is supported.
        /// </param>
        /// <param name="externalAccountKey">
        /// Required. The external account key to create. This field only exists to future-proof
        /// the API. At present, all fields in ExternalAccountKey are output only and
        /// all values are ignored. For the purpose of the
        /// CreateExternalAccountKeyRequest, set it to a default/empty value.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExternalAccountKey> CreateExternalAccountKeyAsync(gagr::LocationName parent, ExternalAccountKey externalAccountKey, st::CancellationToken cancellationToken) =>
            CreateExternalAccountKeyAsync(parent, externalAccountKey, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>PublicCertificateAuthorityService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Manages the resources required for ACME [external account
    /// binding](https://tools.ietf.org/html/rfc8555#section-7.3.4) for
    /// the public certificate authority service.
    /// </remarks>
    public sealed partial class PublicCertificateAuthorityServiceClientImpl : PublicCertificateAuthorityServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateExternalAccountKeyRequest, ExternalAccountKey> _callCreateExternalAccountKey;

        /// <summary>
        /// Constructs a client wrapper for the PublicCertificateAuthorityService service, with the specified gRPC
        /// client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="PublicCertificateAuthorityServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public PublicCertificateAuthorityServiceClientImpl(PublicCertificateAuthorityService.PublicCertificateAuthorityServiceClient grpcClient, PublicCertificateAuthorityServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            PublicCertificateAuthorityServiceSettings effectiveSettings = settings ?? PublicCertificateAuthorityServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCreateExternalAccountKey = clientHelper.BuildApiCall<CreateExternalAccountKeyRequest, ExternalAccountKey>("CreateExternalAccountKey", grpcClient.CreateExternalAccountKeyAsync, grpcClient.CreateExternalAccountKey, effectiveSettings.CreateExternalAccountKeySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateExternalAccountKey);
            Modify_CreateExternalAccountKeyApiCall(ref _callCreateExternalAccountKey);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateExternalAccountKeyApiCall(ref gaxgrpc::ApiCall<CreateExternalAccountKeyRequest, ExternalAccountKey> call);

        partial void OnConstruction(PublicCertificateAuthorityService.PublicCertificateAuthorityServiceClient grpcClient, PublicCertificateAuthorityServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC PublicCertificateAuthorityService client</summary>
        public override PublicCertificateAuthorityService.PublicCertificateAuthorityServiceClient GrpcClient { get; }

        partial void Modify_CreateExternalAccountKeyRequest(ref CreateExternalAccountKeyRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a new [ExternalAccountKey][google.cloud.security.publicca.v1beta1.ExternalAccountKey] bound to the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ExternalAccountKey CreateExternalAccountKey(CreateExternalAccountKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateExternalAccountKeyRequest(ref request, ref callSettings);
            return _callCreateExternalAccountKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new [ExternalAccountKey][google.cloud.security.publicca.v1beta1.ExternalAccountKey] bound to the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ExternalAccountKey> CreateExternalAccountKeyAsync(CreateExternalAccountKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateExternalAccountKeyRequest(ref request, ref callSettings);
            return _callCreateExternalAccountKey.Async(request, callSettings);
        }
    }
}
