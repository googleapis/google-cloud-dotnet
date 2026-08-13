// Copyright 2026 Google LLC
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

namespace Google.Cloud.WorkloadIdentity.V1
{
    /// <summary>Settings for <see cref="WorkloadIdentityClient"/> instances.</summary>
    public sealed partial class WorkloadIdentitySettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="WorkloadIdentitySettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="WorkloadIdentitySettings"/>.</returns>
        public static WorkloadIdentitySettings GetDefault() => new WorkloadIdentitySettings();

        /// <summary>Constructs a new <see cref="WorkloadIdentitySettings"/> object with default settings.</summary>
        public WorkloadIdentitySettings()
        {
        }

        private WorkloadIdentitySettings(WorkloadIdentitySettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GenerateServiceAgentsSettings = existing.GenerateServiceAgentsSettings;
            GenerateServiceAgentsOperationsSettings = existing.GenerateServiceAgentsOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(WorkloadIdentitySettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WorkloadIdentityClient.GenerateServiceAgents</c> and <c>WorkloadIdentityClient.GenerateServiceAgentsAsync</c>
        /// .
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
        public gaxgrpc::CallSettings GenerateServiceAgentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>WorkloadIdentityClient.GenerateServiceAgents</c> and
        /// <c>WorkloadIdentityClient.GenerateServiceAgentsAsync</c>.
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
        public lro::OperationsSettings GenerateServiceAgentsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="WorkloadIdentitySettings"/> object.</returns>
        public WorkloadIdentitySettings Clone() => new WorkloadIdentitySettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="WorkloadIdentityClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class WorkloadIdentityClientBuilder : gaxgrpc::ClientBuilderBase<WorkloadIdentityClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public WorkloadIdentitySettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public WorkloadIdentityClientBuilder() : base(WorkloadIdentityClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref WorkloadIdentityClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<WorkloadIdentityClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override WorkloadIdentityClient Build()
        {
            WorkloadIdentityClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<WorkloadIdentityClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<WorkloadIdentityClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private WorkloadIdentityClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return WorkloadIdentityClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<WorkloadIdentityClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return WorkloadIdentityClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => WorkloadIdentityClient.ChannelPool;
    }

    /// <summary>WorkloadIdentity client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public abstract partial class WorkloadIdentityClient
    {
        /// <summary>
        /// The default endpoint for the WorkloadIdentity service, which is a host of "workloadidentity.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "workloadidentity.googleapis.com:443";

        /// <summary>The default WorkloadIdentity scopes.</summary>
        /// <remarks>
        /// The default WorkloadIdentity scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(WorkloadIdentity.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="WorkloadIdentityClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="WorkloadIdentityClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="WorkloadIdentityClient"/>.</returns>
        public static stt::Task<WorkloadIdentityClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new WorkloadIdentityClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="WorkloadIdentityClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="WorkloadIdentityClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="WorkloadIdentityClient"/>.</returns>
        public static WorkloadIdentityClient Create() => new WorkloadIdentityClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="WorkloadIdentityClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="WorkloadIdentitySettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="WorkloadIdentityClient"/>.</returns>
        internal static WorkloadIdentityClient Create(grpccore::CallInvoker callInvoker, WorkloadIdentitySettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            WorkloadIdentity.WorkloadIdentityClient grpcClient = new WorkloadIdentity.WorkloadIdentityClient(callInvoker);
            return new WorkloadIdentityClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC WorkloadIdentity client</summary>
        public virtual WorkloadIdentity.WorkloadIdentityClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates all service agents for a given resource, location and service
        /// producer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GenerateServiceAgentsResponse, OperationMetadata> GenerateServiceAgents(GenerateServiceAgentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates all service agents for a given resource, location and service
        /// producer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GenerateServiceAgentsResponse, OperationMetadata>> GenerateServiceAgentsAsync(GenerateServiceAgentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates all service agents for a given resource, location and service
        /// producer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GenerateServiceAgentsResponse, OperationMetadata>> GenerateServiceAgentsAsync(GenerateServiceAgentsRequest request, st::CancellationToken cancellationToken) =>
            GenerateServiceAgentsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>GenerateServiceAgents</c>.</summary>
        public virtual lro::OperationsClient GenerateServiceAgentsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>GenerateServiceAgents</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<GenerateServiceAgentsResponse, OperationMetadata> PollOnceGenerateServiceAgents(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GenerateServiceAgentsResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), GenerateServiceAgentsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>GenerateServiceAgents</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<GenerateServiceAgentsResponse, OperationMetadata>> PollOnceGenerateServiceAgentsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GenerateServiceAgentsResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), GenerateServiceAgentsOperationsClient, callSettings);

        /// <summary>
        /// Creates all service agents for a given resource, location and service
        /// producer.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource. The `location` for the parent resource must
        /// be `global`.
        /// 
        /// Examples:
        /// 
        /// - projects/1234/locations/global/serviceProducers/bigquery.googleapis.com
        /// - folders/2344/locations/global/serviceProducers/vertexai.googleapis.com
        /// - organizations/3344/locations/global/serviceProducers/iam.googleapis.com
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GenerateServiceAgentsResponse, OperationMetadata> GenerateServiceAgents(string parent, gaxgrpc::CallSettings callSettings = null) =>
            GenerateServiceAgents(new GenerateServiceAgentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Creates all service agents for a given resource, location and service
        /// producer.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource. The `location` for the parent resource must
        /// be `global`.
        /// 
        /// Examples:
        /// 
        /// - projects/1234/locations/global/serviceProducers/bigquery.googleapis.com
        /// - folders/2344/locations/global/serviceProducers/vertexai.googleapis.com
        /// - organizations/3344/locations/global/serviceProducers/iam.googleapis.com
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GenerateServiceAgentsResponse, OperationMetadata>> GenerateServiceAgentsAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            GenerateServiceAgentsAsync(new GenerateServiceAgentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Creates all service agents for a given resource, location and service
        /// producer.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource. The `location` for the parent resource must
        /// be `global`.
        /// 
        /// Examples:
        /// 
        /// - projects/1234/locations/global/serviceProducers/bigquery.googleapis.com
        /// - folders/2344/locations/global/serviceProducers/vertexai.googleapis.com
        /// - organizations/3344/locations/global/serviceProducers/iam.googleapis.com
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GenerateServiceAgentsResponse, OperationMetadata>> GenerateServiceAgentsAsync(string parent, st::CancellationToken cancellationToken) =>
            GenerateServiceAgentsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates all service agents for a given resource, location and service
        /// producer.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource. The `location` for the parent resource must
        /// be `global`.
        /// 
        /// Examples:
        /// 
        /// - projects/1234/locations/global/serviceProducers/bigquery.googleapis.com
        /// - folders/2344/locations/global/serviceProducers/vertexai.googleapis.com
        /// - organizations/3344/locations/global/serviceProducers/iam.googleapis.com
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GenerateServiceAgentsResponse, OperationMetadata> GenerateServiceAgents(ServiceProducerName parent, gaxgrpc::CallSettings callSettings = null) =>
            GenerateServiceAgents(new GenerateServiceAgentsRequest
            {
                ParentAsServiceProducerName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Creates all service agents for a given resource, location and service
        /// producer.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource. The `location` for the parent resource must
        /// be `global`.
        /// 
        /// Examples:
        /// 
        /// - projects/1234/locations/global/serviceProducers/bigquery.googleapis.com
        /// - folders/2344/locations/global/serviceProducers/vertexai.googleapis.com
        /// - organizations/3344/locations/global/serviceProducers/iam.googleapis.com
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GenerateServiceAgentsResponse, OperationMetadata>> GenerateServiceAgentsAsync(ServiceProducerName parent, gaxgrpc::CallSettings callSettings = null) =>
            GenerateServiceAgentsAsync(new GenerateServiceAgentsRequest
            {
                ParentAsServiceProducerName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Creates all service agents for a given resource, location and service
        /// producer.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource. The `location` for the parent resource must
        /// be `global`.
        /// 
        /// Examples:
        /// 
        /// - projects/1234/locations/global/serviceProducers/bigquery.googleapis.com
        /// - folders/2344/locations/global/serviceProducers/vertexai.googleapis.com
        /// - organizations/3344/locations/global/serviceProducers/iam.googleapis.com
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GenerateServiceAgentsResponse, OperationMetadata>> GenerateServiceAgentsAsync(ServiceProducerName parent, st::CancellationToken cancellationToken) =>
            GenerateServiceAgentsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>WorkloadIdentity client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public sealed partial class WorkloadIdentityClientImpl : WorkloadIdentityClient
    {
        private readonly gaxgrpc::ApiCall<GenerateServiceAgentsRequest, lro::Operation> _callGenerateServiceAgents;

        /// <summary>
        /// Constructs a client wrapper for the WorkloadIdentity service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="WorkloadIdentitySettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public WorkloadIdentityClientImpl(WorkloadIdentity.WorkloadIdentityClient grpcClient, WorkloadIdentitySettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            WorkloadIdentitySettings effectiveSettings = settings ?? WorkloadIdentitySettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            GenerateServiceAgentsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.GenerateServiceAgentsOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callGenerateServiceAgents = clientHelper.BuildApiCall<GenerateServiceAgentsRequest, lro::Operation>("GenerateServiceAgents", grpcClient.GenerateServiceAgentsAsync, grpcClient.GenerateServiceAgents, effectiveSettings.GenerateServiceAgentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callGenerateServiceAgents);
            Modify_GenerateServiceAgentsApiCall(ref _callGenerateServiceAgents);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GenerateServiceAgentsApiCall(ref gaxgrpc::ApiCall<GenerateServiceAgentsRequest, lro::Operation> call);

        partial void OnConstruction(WorkloadIdentity.WorkloadIdentityClient grpcClient, WorkloadIdentitySettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC WorkloadIdentity client</summary>
        public override WorkloadIdentity.WorkloadIdentityClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_GenerateServiceAgentsRequest(ref GenerateServiceAgentsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>GenerateServiceAgents</c>.</summary>
        public override lro::OperationsClient GenerateServiceAgentsOperationsClient { get; }

        /// <summary>
        /// Creates all service agents for a given resource, location and service
        /// producer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<GenerateServiceAgentsResponse, OperationMetadata> GenerateServiceAgents(GenerateServiceAgentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateServiceAgentsRequest(ref request, ref callSettings);
            return new lro::Operation<GenerateServiceAgentsResponse, OperationMetadata>(_callGenerateServiceAgents.Sync(request, callSettings), GenerateServiceAgentsOperationsClient);
        }

        /// <summary>
        /// Creates all service agents for a given resource, location and service
        /// producer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<GenerateServiceAgentsResponse, OperationMetadata>> GenerateServiceAgentsAsync(GenerateServiceAgentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateServiceAgentsRequest(ref request, ref callSettings);
            return new lro::Operation<GenerateServiceAgentsResponse, OperationMetadata>(await _callGenerateServiceAgents.Async(request, callSettings).ConfigureAwait(false), GenerateServiceAgentsOperationsClient);
        }
    }

    public static partial class WorkloadIdentity
    {
        public partial class WorkloadIdentityClient
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

    public static partial class WorkloadIdentity
    {
        public partial class WorkloadIdentityClient
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
