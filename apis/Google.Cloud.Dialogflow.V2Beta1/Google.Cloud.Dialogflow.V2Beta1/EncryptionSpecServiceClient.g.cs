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
using gcl = Google.Cloud.Location;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.Dialogflow.V2Beta1
{
    /// <summary>Settings for <see cref="EncryptionSpecServiceClient"/> instances.</summary>
    public sealed partial class EncryptionSpecServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="EncryptionSpecServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="EncryptionSpecServiceSettings"/>.</returns>
        public static EncryptionSpecServiceSettings GetDefault() => new EncryptionSpecServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="EncryptionSpecServiceSettings"/> object with default settings.
        /// </summary>
        public EncryptionSpecServiceSettings()
        {
        }

        private EncryptionSpecServiceSettings(EncryptionSpecServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetEncryptionSpecSettings = existing.GetEncryptionSpecSettings;
            InitializeEncryptionSpecSettings = existing.InitializeEncryptionSpecSettings;
            InitializeEncryptionSpecOperationsSettings = existing.InitializeEncryptionSpecOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(EncryptionSpecServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EncryptionSpecServiceClient.GetEncryptionSpec</c> and
        /// <c>EncryptionSpecServiceClient.GetEncryptionSpecAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEncryptionSpecSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EncryptionSpecServiceClient.InitializeEncryptionSpec</c> and
        /// <c>EncryptionSpecServiceClient.InitializeEncryptionSpecAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InitializeEncryptionSpecSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EncryptionSpecServiceClient.InitializeEncryptionSpec</c> and
        /// <c>EncryptionSpecServiceClient.InitializeEncryptionSpecAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings InitializeEncryptionSpecOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="EncryptionSpecServiceSettings"/> object.</returns>
        public EncryptionSpecServiceSettings Clone() => new EncryptionSpecServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="EncryptionSpecServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class EncryptionSpecServiceClientBuilder : gaxgrpc::ClientBuilderBase<EncryptionSpecServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public EncryptionSpecServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public EncryptionSpecServiceClientBuilder() : base(EncryptionSpecServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref EncryptionSpecServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<EncryptionSpecServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override EncryptionSpecServiceClient Build()
        {
            EncryptionSpecServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<EncryptionSpecServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<EncryptionSpecServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private EncryptionSpecServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return EncryptionSpecServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<EncryptionSpecServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return EncryptionSpecServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => EncryptionSpecServiceClient.ChannelPool;
    }

    /// <summary>EncryptionSpecService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Manages encryption spec settings for Dialogflow and Agent Assist.
    /// </remarks>
    public abstract partial class EncryptionSpecServiceClient
    {
        /// <summary>
        /// The default endpoint for the EncryptionSpecService service, which is a host of "dialogflow.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dialogflow.googleapis.com:443";

        /// <summary>The default EncryptionSpecService scopes.</summary>
        /// <remarks>
        /// The default EncryptionSpecService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/dialogflow</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/dialogflow",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(EncryptionSpecService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="EncryptionSpecServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="EncryptionSpecServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="EncryptionSpecServiceClient"/>.</returns>
        public static stt::Task<EncryptionSpecServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new EncryptionSpecServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="EncryptionSpecServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="EncryptionSpecServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="EncryptionSpecServiceClient"/>.</returns>
        public static EncryptionSpecServiceClient Create() => new EncryptionSpecServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="EncryptionSpecServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="EncryptionSpecServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="EncryptionSpecServiceClient"/>.</returns>
        internal static EncryptionSpecServiceClient Create(grpccore::CallInvoker callInvoker, EncryptionSpecServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            EncryptionSpecService.EncryptionSpecServiceClient grpcClient = new EncryptionSpecService.EncryptionSpecServiceClient(callInvoker);
            return new EncryptionSpecServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC EncryptionSpecService client</summary>
        public virtual EncryptionSpecService.EncryptionSpecServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets location-level encryption key specification.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EncryptionSpec GetEncryptionSpec(GetEncryptionSpecRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets location-level encryption key specification.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EncryptionSpec> GetEncryptionSpecAsync(GetEncryptionSpecRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets location-level encryption key specification.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EncryptionSpec> GetEncryptionSpecAsync(GetEncryptionSpecRequest request, st::CancellationToken cancellationToken) =>
            GetEncryptionSpecAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets location-level encryption key specification.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the encryption spec resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EncryptionSpec GetEncryptionSpec(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEncryptionSpec(new GetEncryptionSpecRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets location-level encryption key specification.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the encryption spec resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EncryptionSpec> GetEncryptionSpecAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEncryptionSpecAsync(new GetEncryptionSpecRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets location-level encryption key specification.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the encryption spec resource to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EncryptionSpec> GetEncryptionSpecAsync(string name, st::CancellationToken cancellationToken) =>
            GetEncryptionSpecAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets location-level encryption key specification.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the encryption spec resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EncryptionSpec GetEncryptionSpec(EncryptionSpecName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEncryptionSpec(new GetEncryptionSpecRequest
            {
                EncryptionSpecName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets location-level encryption key specification.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the encryption spec resource to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EncryptionSpec> GetEncryptionSpecAsync(EncryptionSpecName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEncryptionSpecAsync(new GetEncryptionSpecRequest
            {
                EncryptionSpecName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets location-level encryption key specification.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the encryption spec resource to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EncryptionSpec> GetEncryptionSpecAsync(EncryptionSpecName name, st::CancellationToken cancellationToken) =>
            GetEncryptionSpecAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Initializes a location-level encryption key specification.  An error will
        /// be thrown if the location has resources already created before the
        /// initialization. Once the encryption specification is initialized at a
        /// location, it is immutable and all newly created resources under the
        /// location will be encrypted with the existing specification.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InitializeEncryptionSpecResponse, InitializeEncryptionSpecMetadata> InitializeEncryptionSpec(InitializeEncryptionSpecRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Initializes a location-level encryption key specification.  An error will
        /// be thrown if the location has resources already created before the
        /// initialization. Once the encryption specification is initialized at a
        /// location, it is immutable and all newly created resources under the
        /// location will be encrypted with the existing specification.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InitializeEncryptionSpecResponse, InitializeEncryptionSpecMetadata>> InitializeEncryptionSpecAsync(InitializeEncryptionSpecRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Initializes a location-level encryption key specification.  An error will
        /// be thrown if the location has resources already created before the
        /// initialization. Once the encryption specification is initialized at a
        /// location, it is immutable and all newly created resources under the
        /// location will be encrypted with the existing specification.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InitializeEncryptionSpecResponse, InitializeEncryptionSpecMetadata>> InitializeEncryptionSpecAsync(InitializeEncryptionSpecRequest request, st::CancellationToken cancellationToken) =>
            InitializeEncryptionSpecAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>InitializeEncryptionSpec</c>.</summary>
        public virtual lro::OperationsClient InitializeEncryptionSpecOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>InitializeEncryptionSpec</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<InitializeEncryptionSpecResponse, InitializeEncryptionSpecMetadata> PollOnceInitializeEncryptionSpec(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<InitializeEncryptionSpecResponse, InitializeEncryptionSpecMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), InitializeEncryptionSpecOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>InitializeEncryptionSpec</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<InitializeEncryptionSpecResponse, InitializeEncryptionSpecMetadata>> PollOnceInitializeEncryptionSpecAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<InitializeEncryptionSpecResponse, InitializeEncryptionSpecMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), InitializeEncryptionSpecOperationsClient, callSettings);

        /// <summary>
        /// Initializes a location-level encryption key specification.  An error will
        /// be thrown if the location has resources already created before the
        /// initialization. Once the encryption specification is initialized at a
        /// location, it is immutable and all newly created resources under the
        /// location will be encrypted with the existing specification.
        /// </summary>
        /// <param name="encryptionSpec">
        /// Required. The encryption spec used for CMEK encryption. It is required that
        /// the kms key is in the same region as the endpoint. The same key will be
        /// used for all provisioned resources, if encryption is available. If the
        /// kms_key_name is left empty, no encryption will be enforced.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InitializeEncryptionSpecResponse, InitializeEncryptionSpecMetadata> InitializeEncryptionSpec(EncryptionSpec encryptionSpec, gaxgrpc::CallSettings callSettings = null) =>
            InitializeEncryptionSpec(new InitializeEncryptionSpecRequest
            {
                EncryptionSpec = gax::GaxPreconditions.CheckNotNull(encryptionSpec, nameof(encryptionSpec)),
            }, callSettings);

        /// <summary>
        /// Initializes a location-level encryption key specification.  An error will
        /// be thrown if the location has resources already created before the
        /// initialization. Once the encryption specification is initialized at a
        /// location, it is immutable and all newly created resources under the
        /// location will be encrypted with the existing specification.
        /// </summary>
        /// <param name="encryptionSpec">
        /// Required. The encryption spec used for CMEK encryption. It is required that
        /// the kms key is in the same region as the endpoint. The same key will be
        /// used for all provisioned resources, if encryption is available. If the
        /// kms_key_name is left empty, no encryption will be enforced.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InitializeEncryptionSpecResponse, InitializeEncryptionSpecMetadata>> InitializeEncryptionSpecAsync(EncryptionSpec encryptionSpec, gaxgrpc::CallSettings callSettings = null) =>
            InitializeEncryptionSpecAsync(new InitializeEncryptionSpecRequest
            {
                EncryptionSpec = gax::GaxPreconditions.CheckNotNull(encryptionSpec, nameof(encryptionSpec)),
            }, callSettings);

        /// <summary>
        /// Initializes a location-level encryption key specification.  An error will
        /// be thrown if the location has resources already created before the
        /// initialization. Once the encryption specification is initialized at a
        /// location, it is immutable and all newly created resources under the
        /// location will be encrypted with the existing specification.
        /// </summary>
        /// <param name="encryptionSpec">
        /// Required. The encryption spec used for CMEK encryption. It is required that
        /// the kms key is in the same region as the endpoint. The same key will be
        /// used for all provisioned resources, if encryption is available. If the
        /// kms_key_name is left empty, no encryption will be enforced.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InitializeEncryptionSpecResponse, InitializeEncryptionSpecMetadata>> InitializeEncryptionSpecAsync(EncryptionSpec encryptionSpec, st::CancellationToken cancellationToken) =>
            InitializeEncryptionSpecAsync(encryptionSpec, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>EncryptionSpecService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Manages encryption spec settings for Dialogflow and Agent Assist.
    /// </remarks>
    public sealed partial class EncryptionSpecServiceClientImpl : EncryptionSpecServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetEncryptionSpecRequest, EncryptionSpec> _callGetEncryptionSpec;

        private readonly gaxgrpc::ApiCall<InitializeEncryptionSpecRequest, lro::Operation> _callInitializeEncryptionSpec;

        /// <summary>
        /// Constructs a client wrapper for the EncryptionSpecService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="EncryptionSpecServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public EncryptionSpecServiceClientImpl(EncryptionSpecService.EncryptionSpecServiceClient grpcClient, EncryptionSpecServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            EncryptionSpecServiceSettings effectiveSettings = settings ?? EncryptionSpecServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            InitializeEncryptionSpecOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.InitializeEncryptionSpecOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callGetEncryptionSpec = clientHelper.BuildApiCall<GetEncryptionSpecRequest, EncryptionSpec>("GetEncryptionSpec", grpcClient.GetEncryptionSpecAsync, grpcClient.GetEncryptionSpec, effectiveSettings.GetEncryptionSpecSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEncryptionSpec);
            Modify_GetEncryptionSpecApiCall(ref _callGetEncryptionSpec);
            _callInitializeEncryptionSpec = clientHelper.BuildApiCall<InitializeEncryptionSpecRequest, lro::Operation>("InitializeEncryptionSpec", grpcClient.InitializeEncryptionSpecAsync, grpcClient.InitializeEncryptionSpec, effectiveSettings.InitializeEncryptionSpecSettings).WithGoogleRequestParam("encryption_spec.name", request => request.EncryptionSpec?.Name);
            Modify_ApiCall(ref _callInitializeEncryptionSpec);
            Modify_InitializeEncryptionSpecApiCall(ref _callInitializeEncryptionSpec);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetEncryptionSpecApiCall(ref gaxgrpc::ApiCall<GetEncryptionSpecRequest, EncryptionSpec> call);

        partial void Modify_InitializeEncryptionSpecApiCall(ref gaxgrpc::ApiCall<InitializeEncryptionSpecRequest, lro::Operation> call);

        partial void OnConstruction(EncryptionSpecService.EncryptionSpecServiceClient grpcClient, EncryptionSpecServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC EncryptionSpecService client</summary>
        public override EncryptionSpecService.EncryptionSpecServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_GetEncryptionSpecRequest(ref GetEncryptionSpecRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InitializeEncryptionSpecRequest(ref InitializeEncryptionSpecRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets location-level encryption key specification.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EncryptionSpec GetEncryptionSpec(GetEncryptionSpecRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEncryptionSpecRequest(ref request, ref callSettings);
            return _callGetEncryptionSpec.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets location-level encryption key specification.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EncryptionSpec> GetEncryptionSpecAsync(GetEncryptionSpecRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEncryptionSpecRequest(ref request, ref callSettings);
            return _callGetEncryptionSpec.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>InitializeEncryptionSpec</c>.</summary>
        public override lro::OperationsClient InitializeEncryptionSpecOperationsClient { get; }

        /// <summary>
        /// Initializes a location-level encryption key specification.  An error will
        /// be thrown if the location has resources already created before the
        /// initialization. Once the encryption specification is initialized at a
        /// location, it is immutable and all newly created resources under the
        /// location will be encrypted with the existing specification.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<InitializeEncryptionSpecResponse, InitializeEncryptionSpecMetadata> InitializeEncryptionSpec(InitializeEncryptionSpecRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InitializeEncryptionSpecRequest(ref request, ref callSettings);
            return new lro::Operation<InitializeEncryptionSpecResponse, InitializeEncryptionSpecMetadata>(_callInitializeEncryptionSpec.Sync(request, callSettings), InitializeEncryptionSpecOperationsClient);
        }

        /// <summary>
        /// Initializes a location-level encryption key specification.  An error will
        /// be thrown if the location has resources already created before the
        /// initialization. Once the encryption specification is initialized at a
        /// location, it is immutable and all newly created resources under the
        /// location will be encrypted with the existing specification.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<InitializeEncryptionSpecResponse, InitializeEncryptionSpecMetadata>> InitializeEncryptionSpecAsync(InitializeEncryptionSpecRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InitializeEncryptionSpecRequest(ref request, ref callSettings);
            return new lro::Operation<InitializeEncryptionSpecResponse, InitializeEncryptionSpecMetadata>(await _callInitializeEncryptionSpec.Async(request, callSettings).ConfigureAwait(false), InitializeEncryptionSpecOperationsClient);
        }
    }

    public static partial class EncryptionSpecService
    {
        public partial class EncryptionSpecServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() =>
                new lro::Operations.OperationsClient(CallInvoker);
        }
    }

    public static partial class EncryptionSpecService
    {
        public partial class EncryptionSpecServiceClient
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
