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
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.DiscoveryEngine.V1Beta
{
    /// <summary>Settings for <see cref="AssistantServiceClient"/> instances.</summary>
    public sealed partial class AssistantServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AssistantServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AssistantServiceSettings"/>.</returns>
        public static AssistantServiceSettings GetDefault() => new AssistantServiceSettings();

        /// <summary>Constructs a new <see cref="AssistantServiceSettings"/> object with default settings.</summary>
        public AssistantServiceSettings()
        {
        }

        private AssistantServiceSettings(AssistantServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            StreamAssistSettings = existing.StreamAssistSettings;
            CreateAssistantSettings = existing.CreateAssistantSettings;
            DeleteAssistantSettings = existing.DeleteAssistantSettings;
            UpdateAssistantSettings = existing.UpdateAssistantSettings;
            GetAssistantSettings = existing.GetAssistantSettings;
            ListAssistantsSettings = existing.ListAssistantsSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AssistantServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssistantServiceClient.StreamAssist</c> and <c>AssistantServiceClient.StreamAssistAsync</c>.
        /// </summary>
        /// <remarks>Timeout: 300 seconds.</remarks>
        public gaxgrpc::CallSettings StreamAssistSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssistantServiceClient.CreateAssistant</c> and <c>AssistantServiceClient.CreateAssistantAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAssistantSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssistantServiceClient.DeleteAssistant</c> and <c>AssistantServiceClient.DeleteAssistantAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAssistantSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssistantServiceClient.UpdateAssistant</c> and <c>AssistantServiceClient.UpdateAssistantAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAssistantSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssistantServiceClient.GetAssistant</c> and <c>AssistantServiceClient.GetAssistantAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAssistantSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssistantServiceClient.ListAssistants</c> and <c>AssistantServiceClient.ListAssistantsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAssistantsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AssistantServiceSettings"/> object.</returns>
        public AssistantServiceSettings Clone() => new AssistantServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AssistantServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class AssistantServiceClientBuilder : gaxgrpc::ClientBuilderBase<AssistantServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AssistantServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AssistantServiceClientBuilder() : base(AssistantServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AssistantServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AssistantServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AssistantServiceClient Build()
        {
            AssistantServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AssistantServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AssistantServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AssistantServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AssistantServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AssistantServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AssistantServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AssistantServiceClient.ChannelPool;
    }

    /// <summary>AssistantService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing Assistant configuration and assisting users.
    /// </remarks>
    public abstract partial class AssistantServiceClient
    {
        /// <summary>
        /// The default endpoint for the AssistantService service, which is a host of "discoveryengine.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "discoveryengine.googleapis.com:443";

        /// <summary>The default AssistantService scopes.</summary>
        /// <remarks>
        /// The default AssistantService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/discoveryengine.assist.readwrite</description></item>
        /// <item><description>https://www.googleapis.com/auth/discoveryengine.readwrite</description></item>
        /// <item><description>https://www.googleapis.com/auth/discoveryengine.serving.readwrite</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/discoveryengine.assist.readwrite",
            "https://www.googleapis.com/auth/discoveryengine.readwrite",
            "https://www.googleapis.com/auth/discoveryengine.serving.readwrite",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AssistantService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AssistantServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AssistantServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AssistantServiceClient"/>.</returns>
        public static stt::Task<AssistantServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AssistantServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AssistantServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AssistantServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AssistantServiceClient"/>.</returns>
        public static AssistantServiceClient Create() => new AssistantServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AssistantServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AssistantServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AssistantServiceClient"/>.</returns>
        internal static AssistantServiceClient Create(grpccore::CallInvoker callInvoker, AssistantServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AssistantService.AssistantServiceClient grpcClient = new AssistantService.AssistantServiceClient(callInvoker);
            return new AssistantServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AssistantService client</summary>
        public virtual AssistantService.AssistantServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Server streaming methods for <see cref="StreamAssist(StreamAssistRequest,gaxgrpc::CallSettings)"/>.
        /// </summary>
        public abstract partial class StreamAssistStream : gaxgrpc::ServerStreamingBase<StreamAssistResponse>
        {
        }

        /// <summary>
        /// Assists the user with a query in a streaming fashion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual StreamAssistStream StreamAssist(StreamAssistRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an [Assistant][google.cloud.discoveryengine.v1beta.Assistant].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Assistant CreateAssistant(CreateAssistantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an [Assistant][google.cloud.discoveryengine.v1beta.Assistant].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Assistant> CreateAssistantAsync(CreateAssistantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an [Assistant][google.cloud.discoveryengine.v1beta.Assistant].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Assistant> CreateAssistantAsync(CreateAssistantRequest request, st::CancellationToken cancellationToken) =>
            CreateAssistantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an [Assistant][google.cloud.discoveryengine.v1beta.Assistant].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAssistant(DeleteAssistantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an [Assistant][google.cloud.discoveryengine.v1beta.Assistant].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAssistantAsync(DeleteAssistantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an [Assistant][google.cloud.discoveryengine.v1beta.Assistant].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAssistantAsync(DeleteAssistantRequest request, st::CancellationToken cancellationToken) =>
            DeleteAssistantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an [Assistant][google.cloud.discoveryengine.v1beta.Assistant].
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of
        /// [Assistant][google.cloud.discoveryengine.v1beta.Assistant]. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/assistants/{assistant}`
        /// 
        /// If the caller does not have permission to delete the
        /// [Assistant][google.cloud.discoveryengine.v1beta.Assistant], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Assistant][google.cloud.discoveryengine.v1beta.Assistant] to delete
        /// does not exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAssistant(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAssistant(new DeleteAssistantRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an [Assistant][google.cloud.discoveryengine.v1beta.Assistant].
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of
        /// [Assistant][google.cloud.discoveryengine.v1beta.Assistant]. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/assistants/{assistant}`
        /// 
        /// If the caller does not have permission to delete the
        /// [Assistant][google.cloud.discoveryengine.v1beta.Assistant], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Assistant][google.cloud.discoveryengine.v1beta.Assistant] to delete
        /// does not exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAssistantAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAssistantAsync(new DeleteAssistantRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an [Assistant][google.cloud.discoveryengine.v1beta.Assistant].
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of
        /// [Assistant][google.cloud.discoveryengine.v1beta.Assistant]. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/assistants/{assistant}`
        /// 
        /// If the caller does not have permission to delete the
        /// [Assistant][google.cloud.discoveryengine.v1beta.Assistant], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Assistant][google.cloud.discoveryengine.v1beta.Assistant] to delete
        /// does not exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAssistantAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAssistantAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an [Assistant][google.cloud.discoveryengine.v1beta.Assistant].
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of
        /// [Assistant][google.cloud.discoveryengine.v1beta.Assistant]. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/assistants/{assistant}`
        /// 
        /// If the caller does not have permission to delete the
        /// [Assistant][google.cloud.discoveryengine.v1beta.Assistant], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Assistant][google.cloud.discoveryengine.v1beta.Assistant] to delete
        /// does not exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAssistant(AssistantName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAssistant(new DeleteAssistantRequest
            {
                AssistantName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an [Assistant][google.cloud.discoveryengine.v1beta.Assistant].
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of
        /// [Assistant][google.cloud.discoveryengine.v1beta.Assistant]. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/assistants/{assistant}`
        /// 
        /// If the caller does not have permission to delete the
        /// [Assistant][google.cloud.discoveryengine.v1beta.Assistant], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Assistant][google.cloud.discoveryengine.v1beta.Assistant] to delete
        /// does not exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAssistantAsync(AssistantName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAssistantAsync(new DeleteAssistantRequest
            {
                AssistantName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an [Assistant][google.cloud.discoveryengine.v1beta.Assistant].
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of
        /// [Assistant][google.cloud.discoveryengine.v1beta.Assistant]. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/assistants/{assistant}`
        /// 
        /// If the caller does not have permission to delete the
        /// [Assistant][google.cloud.discoveryengine.v1beta.Assistant], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Assistant][google.cloud.discoveryengine.v1beta.Assistant] to delete
        /// does not exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAssistantAsync(AssistantName name, st::CancellationToken cancellationToken) =>
            DeleteAssistantAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an [Assistant][google.cloud.discoveryengine.v1beta.Assistant]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Assistant UpdateAssistant(UpdateAssistantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an [Assistant][google.cloud.discoveryengine.v1beta.Assistant]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Assistant> UpdateAssistantAsync(UpdateAssistantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an [Assistant][google.cloud.discoveryengine.v1beta.Assistant]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Assistant> UpdateAssistantAsync(UpdateAssistantRequest request, st::CancellationToken cancellationToken) =>
            UpdateAssistantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an [Assistant][google.cloud.discoveryengine.v1beta.Assistant]
        /// </summary>
        /// <param name="assistant">
        /// Required. The [Assistant][google.cloud.discoveryengine.v1beta.Assistant] to
        /// update.
        /// 
        /// The [Assistant][google.cloud.discoveryengine.v1beta.Assistant]'s `name`
        /// field is used to identify the
        /// [Assistant][google.cloud.discoveryengine.v1beta.Assistant] to update.
        /// Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/assistants/{assistant}`
        /// 
        /// If the caller does not have permission to update the
        /// [Assistant][google.cloud.discoveryengine.v1beta.Assistant], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Assistant][google.cloud.discoveryengine.v1beta.Assistant] to update
        /// does not exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Assistant UpdateAssistant(Assistant assistant, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAssistant(new UpdateAssistantRequest
            {
                Assistant = gax::GaxPreconditions.CheckNotNull(assistant, nameof(assistant)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an [Assistant][google.cloud.discoveryengine.v1beta.Assistant]
        /// </summary>
        /// <param name="assistant">
        /// Required. The [Assistant][google.cloud.discoveryengine.v1beta.Assistant] to
        /// update.
        /// 
        /// The [Assistant][google.cloud.discoveryengine.v1beta.Assistant]'s `name`
        /// field is used to identify the
        /// [Assistant][google.cloud.discoveryengine.v1beta.Assistant] to update.
        /// Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/assistants/{assistant}`
        /// 
        /// If the caller does not have permission to update the
        /// [Assistant][google.cloud.discoveryengine.v1beta.Assistant], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Assistant][google.cloud.discoveryengine.v1beta.Assistant] to update
        /// does not exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Assistant> UpdateAssistantAsync(Assistant assistant, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAssistantAsync(new UpdateAssistantRequest
            {
                Assistant = gax::GaxPreconditions.CheckNotNull(assistant, nameof(assistant)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an [Assistant][google.cloud.discoveryengine.v1beta.Assistant]
        /// </summary>
        /// <param name="assistant">
        /// Required. The [Assistant][google.cloud.discoveryengine.v1beta.Assistant] to
        /// update.
        /// 
        /// The [Assistant][google.cloud.discoveryengine.v1beta.Assistant]'s `name`
        /// field is used to identify the
        /// [Assistant][google.cloud.discoveryengine.v1beta.Assistant] to update.
        /// Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/assistants/{assistant}`
        /// 
        /// If the caller does not have permission to update the
        /// [Assistant][google.cloud.discoveryengine.v1beta.Assistant], regardless of
        /// whether or not it exists, a PERMISSION_DENIED error is returned.
        /// 
        /// If the [Assistant][google.cloud.discoveryengine.v1beta.Assistant] to update
        /// does not exist, a NOT_FOUND error is returned.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Assistant> UpdateAssistantAsync(Assistant assistant, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAssistantAsync(assistant, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an [Assistant][google.cloud.discoveryengine.v1beta.Assistant].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Assistant GetAssistant(GetAssistantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an [Assistant][google.cloud.discoveryengine.v1beta.Assistant].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Assistant> GetAssistantAsync(GetAssistantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an [Assistant][google.cloud.discoveryengine.v1beta.Assistant].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Assistant> GetAssistantAsync(GetAssistantRequest request, st::CancellationToken cancellationToken) =>
            GetAssistantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an [Assistant][google.cloud.discoveryengine.v1beta.Assistant].
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of
        /// [Assistant][google.cloud.discoveryengine.v1beta.Assistant]. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/assistants/{assistant}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Assistant GetAssistant(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAssistant(new GetAssistantRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an [Assistant][google.cloud.discoveryengine.v1beta.Assistant].
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of
        /// [Assistant][google.cloud.discoveryengine.v1beta.Assistant]. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/assistants/{assistant}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Assistant> GetAssistantAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAssistantAsync(new GetAssistantRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an [Assistant][google.cloud.discoveryengine.v1beta.Assistant].
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of
        /// [Assistant][google.cloud.discoveryengine.v1beta.Assistant]. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/assistants/{assistant}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Assistant> GetAssistantAsync(string name, st::CancellationToken cancellationToken) =>
            GetAssistantAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an [Assistant][google.cloud.discoveryengine.v1beta.Assistant].
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of
        /// [Assistant][google.cloud.discoveryengine.v1beta.Assistant]. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/assistants/{assistant}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Assistant GetAssistant(AssistantName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAssistant(new GetAssistantRequest
            {
                AssistantName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an [Assistant][google.cloud.discoveryengine.v1beta.Assistant].
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of
        /// [Assistant][google.cloud.discoveryengine.v1beta.Assistant]. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/assistants/{assistant}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Assistant> GetAssistantAsync(AssistantName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAssistantAsync(new GetAssistantRequest
            {
                AssistantName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an [Assistant][google.cloud.discoveryengine.v1beta.Assistant].
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of
        /// [Assistant][google.cloud.discoveryengine.v1beta.Assistant]. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/assistants/{assistant}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Assistant> GetAssistantAsync(AssistantName name, st::CancellationToken cancellationToken) =>
            GetAssistantAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all [Assistant][google.cloud.discoveryengine.v1beta.Assistant]s under
        /// an [Engine][google.cloud.discoveryengine.v1beta.Engine].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Assistant"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAssistantsResponse, Assistant> ListAssistants(ListAssistantsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all [Assistant][google.cloud.discoveryengine.v1beta.Assistant]s under
        /// an [Engine][google.cloud.discoveryengine.v1beta.Engine].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Assistant"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAssistantsResponse, Assistant> ListAssistantsAsync(ListAssistantsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all [Assistant][google.cloud.discoveryengine.v1beta.Assistant]s under
        /// an [Engine][google.cloud.discoveryengine.v1beta.Engine].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
        /// Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/engines/{engine}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Assistant"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAssistantsResponse, Assistant> ListAssistants(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAssistantsRequest request = new ListAssistantsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAssistants(request, callSettings);
        }

        /// <summary>
        /// Lists all [Assistant][google.cloud.discoveryengine.v1beta.Assistant]s under
        /// an [Engine][google.cloud.discoveryengine.v1beta.Engine].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
        /// Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/engines/{engine}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Assistant"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAssistantsResponse, Assistant> ListAssistantsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAssistantsRequest request = new ListAssistantsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAssistantsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all [Assistant][google.cloud.discoveryengine.v1beta.Assistant]s under
        /// an [Engine][google.cloud.discoveryengine.v1beta.Engine].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
        /// Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/engines/{engine}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Assistant"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAssistantsResponse, Assistant> ListAssistants(EngineName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAssistantsRequest request = new ListAssistantsRequest
            {
                ParentAsEngineName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAssistants(request, callSettings);
        }

        /// <summary>
        /// Lists all [Assistant][google.cloud.discoveryengine.v1beta.Assistant]s under
        /// an [Engine][google.cloud.discoveryengine.v1beta.Engine].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
        /// Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/engines/{engine}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Assistant"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAssistantsResponse, Assistant> ListAssistantsAsync(EngineName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAssistantsRequest request = new ListAssistantsRequest
            {
                ParentAsEngineName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAssistantsAsync(request, callSettings);
        }
    }

    /// <summary>AssistantService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing Assistant configuration and assisting users.
    /// </remarks>
    public sealed partial class AssistantServiceClientImpl : AssistantServiceClient
    {
        private readonly gaxgrpc::ApiServerStreamingCall<StreamAssistRequest, StreamAssistResponse> _callStreamAssist;

        private readonly gaxgrpc::ApiCall<CreateAssistantRequest, Assistant> _callCreateAssistant;

        private readonly gaxgrpc::ApiCall<DeleteAssistantRequest, wkt::Empty> _callDeleteAssistant;

        private readonly gaxgrpc::ApiCall<UpdateAssistantRequest, Assistant> _callUpdateAssistant;

        private readonly gaxgrpc::ApiCall<GetAssistantRequest, Assistant> _callGetAssistant;

        private readonly gaxgrpc::ApiCall<ListAssistantsRequest, ListAssistantsResponse> _callListAssistants;

        /// <summary>
        /// Constructs a client wrapper for the AssistantService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AssistantServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AssistantServiceClientImpl(AssistantService.AssistantServiceClient grpcClient, AssistantServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AssistantServiceSettings effectiveSettings = settings ?? AssistantServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callStreamAssist = clientHelper.BuildApiCall<StreamAssistRequest, StreamAssistResponse>("StreamAssist", grpcClient.StreamAssist, effectiveSettings.StreamAssistSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStreamAssist);
            Modify_StreamAssistApiCall(ref _callStreamAssist);
            _callCreateAssistant = clientHelper.BuildApiCall<CreateAssistantRequest, Assistant>("CreateAssistant", grpcClient.CreateAssistantAsync, grpcClient.CreateAssistant, effectiveSettings.CreateAssistantSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAssistant);
            Modify_CreateAssistantApiCall(ref _callCreateAssistant);
            _callDeleteAssistant = clientHelper.BuildApiCall<DeleteAssistantRequest, wkt::Empty>("DeleteAssistant", grpcClient.DeleteAssistantAsync, grpcClient.DeleteAssistant, effectiveSettings.DeleteAssistantSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAssistant);
            Modify_DeleteAssistantApiCall(ref _callDeleteAssistant);
            _callUpdateAssistant = clientHelper.BuildApiCall<UpdateAssistantRequest, Assistant>("UpdateAssistant", grpcClient.UpdateAssistantAsync, grpcClient.UpdateAssistant, effectiveSettings.UpdateAssistantSettings).WithGoogleRequestParam("assistant.name", request => request.Assistant?.Name);
            Modify_ApiCall(ref _callUpdateAssistant);
            Modify_UpdateAssistantApiCall(ref _callUpdateAssistant);
            _callGetAssistant = clientHelper.BuildApiCall<GetAssistantRequest, Assistant>("GetAssistant", grpcClient.GetAssistantAsync, grpcClient.GetAssistant, effectiveSettings.GetAssistantSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAssistant);
            Modify_GetAssistantApiCall(ref _callGetAssistant);
            _callListAssistants = clientHelper.BuildApiCall<ListAssistantsRequest, ListAssistantsResponse>("ListAssistants", grpcClient.ListAssistantsAsync, grpcClient.ListAssistants, effectiveSettings.ListAssistantsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAssistants);
            Modify_ListAssistantsApiCall(ref _callListAssistants);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiServerStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_StreamAssistApiCall(ref gaxgrpc::ApiServerStreamingCall<StreamAssistRequest, StreamAssistResponse> call);

        partial void Modify_CreateAssistantApiCall(ref gaxgrpc::ApiCall<CreateAssistantRequest, Assistant> call);

        partial void Modify_DeleteAssistantApiCall(ref gaxgrpc::ApiCall<DeleteAssistantRequest, wkt::Empty> call);

        partial void Modify_UpdateAssistantApiCall(ref gaxgrpc::ApiCall<UpdateAssistantRequest, Assistant> call);

        partial void Modify_GetAssistantApiCall(ref gaxgrpc::ApiCall<GetAssistantRequest, Assistant> call);

        partial void Modify_ListAssistantsApiCall(ref gaxgrpc::ApiCall<ListAssistantsRequest, ListAssistantsResponse> call);

        partial void OnConstruction(AssistantService.AssistantServiceClient grpcClient, AssistantServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AssistantService client</summary>
        public override AssistantService.AssistantServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_StreamAssistRequest(ref StreamAssistRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAssistantRequest(ref CreateAssistantRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAssistantRequest(ref DeleteAssistantRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAssistantRequest(ref UpdateAssistantRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAssistantRequest(ref GetAssistantRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAssistantsRequest(ref ListAssistantsRequest request, ref gaxgrpc::CallSettings settings);

        internal sealed partial class StreamAssistStreamImpl : StreamAssistStream
        {
            /// <summary>Construct the server streaming method for <c>StreamAssist</c>.</summary>
            /// <param name="call">The underlying gRPC server streaming call.</param>
            public StreamAssistStreamImpl(grpccore::AsyncServerStreamingCall<StreamAssistResponse> call) => GrpcCall = call;

            public override grpccore::AsyncServerStreamingCall<StreamAssistResponse> GrpcCall { get; }
        }

        /// <summary>
        /// Assists the user with a query in a streaming fashion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public override AssistantServiceClient.StreamAssistStream StreamAssist(StreamAssistRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StreamAssistRequest(ref request, ref callSettings);
            return new StreamAssistStreamImpl(_callStreamAssist.Call(request, callSettings));
        }

        /// <summary>
        /// Creates an [Assistant][google.cloud.discoveryengine.v1beta.Assistant].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Assistant CreateAssistant(CreateAssistantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAssistantRequest(ref request, ref callSettings);
            return _callCreateAssistant.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an [Assistant][google.cloud.discoveryengine.v1beta.Assistant].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Assistant> CreateAssistantAsync(CreateAssistantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAssistantRequest(ref request, ref callSettings);
            return _callCreateAssistant.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an [Assistant][google.cloud.discoveryengine.v1beta.Assistant].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteAssistant(DeleteAssistantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAssistantRequest(ref request, ref callSettings);
            _callDeleteAssistant.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an [Assistant][google.cloud.discoveryengine.v1beta.Assistant].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteAssistantAsync(DeleteAssistantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAssistantRequest(ref request, ref callSettings);
            return _callDeleteAssistant.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an [Assistant][google.cloud.discoveryengine.v1beta.Assistant]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Assistant UpdateAssistant(UpdateAssistantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAssistantRequest(ref request, ref callSettings);
            return _callUpdateAssistant.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an [Assistant][google.cloud.discoveryengine.v1beta.Assistant]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Assistant> UpdateAssistantAsync(UpdateAssistantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAssistantRequest(ref request, ref callSettings);
            return _callUpdateAssistant.Async(request, callSettings);
        }

        /// <summary>
        /// Gets an [Assistant][google.cloud.discoveryengine.v1beta.Assistant].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Assistant GetAssistant(GetAssistantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAssistantRequest(ref request, ref callSettings);
            return _callGetAssistant.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an [Assistant][google.cloud.discoveryengine.v1beta.Assistant].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Assistant> GetAssistantAsync(GetAssistantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAssistantRequest(ref request, ref callSettings);
            return _callGetAssistant.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all [Assistant][google.cloud.discoveryengine.v1beta.Assistant]s under
        /// an [Engine][google.cloud.discoveryengine.v1beta.Engine].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Assistant"/> resources.</returns>
        public override gax::PagedEnumerable<ListAssistantsResponse, Assistant> ListAssistants(ListAssistantsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAssistantsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAssistantsRequest, ListAssistantsResponse, Assistant>(_callListAssistants, request, callSettings);
        }

        /// <summary>
        /// Lists all [Assistant][google.cloud.discoveryengine.v1beta.Assistant]s under
        /// an [Engine][google.cloud.discoveryengine.v1beta.Engine].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Assistant"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAssistantsResponse, Assistant> ListAssistantsAsync(ListAssistantsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAssistantsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAssistantsRequest, ListAssistantsResponse, Assistant>(_callListAssistants, request, callSettings);
        }
    }

    public partial class ListAssistantsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAssistantsResponse : gaxgrpc::IPageResponse<Assistant>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Assistant> GetEnumerator() => Assistants.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class AssistantService
    {
        public partial class AssistantServiceClient
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
