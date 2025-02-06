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
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.RecommendationEngine.V1Beta1
{
    /// <summary>Settings for <see cref="PredictionApiKeyRegistryClient"/> instances.</summary>
    public sealed partial class PredictionApiKeyRegistrySettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PredictionApiKeyRegistrySettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PredictionApiKeyRegistrySettings"/>.</returns>
        public static PredictionApiKeyRegistrySettings GetDefault() => new PredictionApiKeyRegistrySettings();

        /// <summary>
        /// Constructs a new <see cref="PredictionApiKeyRegistrySettings"/> object with default settings.
        /// </summary>
        public PredictionApiKeyRegistrySettings()
        {
        }

        private PredictionApiKeyRegistrySettings(PredictionApiKeyRegistrySettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreatePredictionApiKeyRegistrationSettings = existing.CreatePredictionApiKeyRegistrationSettings;
            ListPredictionApiKeyRegistrationsSettings = existing.ListPredictionApiKeyRegistrationsSettings;
            DeletePredictionApiKeyRegistrationSettings = existing.DeletePredictionApiKeyRegistrationSettings;
            OnCopy(existing);
        }

        partial void OnCopy(PredictionApiKeyRegistrySettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PredictionApiKeyRegistryClient.CreatePredictionApiKeyRegistration</c> and
        /// <c>PredictionApiKeyRegistryClient.CreatePredictionApiKeyRegistrationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreatePredictionApiKeyRegistrationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PredictionApiKeyRegistryClient.ListPredictionApiKeyRegistrations</c> and
        /// <c>PredictionApiKeyRegistryClient.ListPredictionApiKeyRegistrationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPredictionApiKeyRegistrationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PredictionApiKeyRegistryClient.DeletePredictionApiKeyRegistration</c> and
        /// <c>PredictionApiKeyRegistryClient.DeletePredictionApiKeyRegistrationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeletePredictionApiKeyRegistrationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PredictionApiKeyRegistrySettings"/> object.</returns>
        public PredictionApiKeyRegistrySettings Clone() => new PredictionApiKeyRegistrySettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PredictionApiKeyRegistryClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class PredictionApiKeyRegistryClientBuilder : gaxgrpc::ClientBuilderBase<PredictionApiKeyRegistryClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PredictionApiKeyRegistrySettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public PredictionApiKeyRegistryClientBuilder() : base(PredictionApiKeyRegistryClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref PredictionApiKeyRegistryClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PredictionApiKeyRegistryClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PredictionApiKeyRegistryClient Build()
        {
            PredictionApiKeyRegistryClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PredictionApiKeyRegistryClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PredictionApiKeyRegistryClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PredictionApiKeyRegistryClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PredictionApiKeyRegistryClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<PredictionApiKeyRegistryClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PredictionApiKeyRegistryClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PredictionApiKeyRegistryClient.ChannelPool;
    }

    /// <summary>PredictionApiKeyRegistry client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for registering API keys for use with the `predict` method. If you
    /// use an API key to request predictions, you must first register the API key.
    /// Otherwise, your prediction request is rejected. If you use OAuth to
    /// authenticate your `predict` method call, you do not need to register an API
    /// key. You can register up to 20 API keys per project.
    /// </remarks>
    public abstract partial class PredictionApiKeyRegistryClient
    {
        /// <summary>
        /// The default endpoint for the PredictionApiKeyRegistry service, which is a host of
        /// "recommendationengine.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "recommendationengine.googleapis.com:443";

        /// <summary>The default PredictionApiKeyRegistry scopes.</summary>
        /// <remarks>
        /// The default PredictionApiKeyRegistry scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(PredictionApiKeyRegistry.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="PredictionApiKeyRegistryClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="PredictionApiKeyRegistryClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PredictionApiKeyRegistryClient"/>.</returns>
        public static stt::Task<PredictionApiKeyRegistryClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PredictionApiKeyRegistryClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PredictionApiKeyRegistryClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="PredictionApiKeyRegistryClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PredictionApiKeyRegistryClient"/>.</returns>
        public static PredictionApiKeyRegistryClient Create() => new PredictionApiKeyRegistryClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PredictionApiKeyRegistryClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PredictionApiKeyRegistrySettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="PredictionApiKeyRegistryClient"/>.</returns>
        internal static PredictionApiKeyRegistryClient Create(grpccore::CallInvoker callInvoker, PredictionApiKeyRegistrySettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            PredictionApiKeyRegistry.PredictionApiKeyRegistryClient grpcClient = new PredictionApiKeyRegistry.PredictionApiKeyRegistryClient(callInvoker);
            return new PredictionApiKeyRegistryClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC PredictionApiKeyRegistry client</summary>
        public virtual PredictionApiKeyRegistry.PredictionApiKeyRegistryClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Register an API key for use with predict method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PredictionApiKeyRegistration CreatePredictionApiKeyRegistration(CreatePredictionApiKeyRegistrationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Register an API key for use with predict method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PredictionApiKeyRegistration> CreatePredictionApiKeyRegistrationAsync(CreatePredictionApiKeyRegistrationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Register an API key for use with predict method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PredictionApiKeyRegistration> CreatePredictionApiKeyRegistrationAsync(CreatePredictionApiKeyRegistrationRequest request, st::CancellationToken cancellationToken) =>
            CreatePredictionApiKeyRegistrationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Register an API key for use with predict method.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource path.
        /// `projects/*/locations/global/catalogs/default_catalog/eventStores/default_event_store`.
        /// </param>
        /// <param name="predictionApiKeyRegistration">
        /// Required. The prediction API key registration.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PredictionApiKeyRegistration CreatePredictionApiKeyRegistration(string parent, PredictionApiKeyRegistration predictionApiKeyRegistration, gaxgrpc::CallSettings callSettings = null) =>
            CreatePredictionApiKeyRegistration(new CreatePredictionApiKeyRegistrationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PredictionApiKeyRegistration = gax::GaxPreconditions.CheckNotNull(predictionApiKeyRegistration, nameof(predictionApiKeyRegistration)),
            }, callSettings);

        /// <summary>
        /// Register an API key for use with predict method.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource path.
        /// `projects/*/locations/global/catalogs/default_catalog/eventStores/default_event_store`.
        /// </param>
        /// <param name="predictionApiKeyRegistration">
        /// Required. The prediction API key registration.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PredictionApiKeyRegistration> CreatePredictionApiKeyRegistrationAsync(string parent, PredictionApiKeyRegistration predictionApiKeyRegistration, gaxgrpc::CallSettings callSettings = null) =>
            CreatePredictionApiKeyRegistrationAsync(new CreatePredictionApiKeyRegistrationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PredictionApiKeyRegistration = gax::GaxPreconditions.CheckNotNull(predictionApiKeyRegistration, nameof(predictionApiKeyRegistration)),
            }, callSettings);

        /// <summary>
        /// Register an API key for use with predict method.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource path.
        /// `projects/*/locations/global/catalogs/default_catalog/eventStores/default_event_store`.
        /// </param>
        /// <param name="predictionApiKeyRegistration">
        /// Required. The prediction API key registration.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PredictionApiKeyRegistration> CreatePredictionApiKeyRegistrationAsync(string parent, PredictionApiKeyRegistration predictionApiKeyRegistration, st::CancellationToken cancellationToken) =>
            CreatePredictionApiKeyRegistrationAsync(parent, predictionApiKeyRegistration, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Register an API key for use with predict method.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource path.
        /// `projects/*/locations/global/catalogs/default_catalog/eventStores/default_event_store`.
        /// </param>
        /// <param name="predictionApiKeyRegistration">
        /// Required. The prediction API key registration.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PredictionApiKeyRegistration CreatePredictionApiKeyRegistration(EventStoreName parent, PredictionApiKeyRegistration predictionApiKeyRegistration, gaxgrpc::CallSettings callSettings = null) =>
            CreatePredictionApiKeyRegistration(new CreatePredictionApiKeyRegistrationRequest
            {
                ParentAsEventStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PredictionApiKeyRegistration = gax::GaxPreconditions.CheckNotNull(predictionApiKeyRegistration, nameof(predictionApiKeyRegistration)),
            }, callSettings);

        /// <summary>
        /// Register an API key for use with predict method.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource path.
        /// `projects/*/locations/global/catalogs/default_catalog/eventStores/default_event_store`.
        /// </param>
        /// <param name="predictionApiKeyRegistration">
        /// Required. The prediction API key registration.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PredictionApiKeyRegistration> CreatePredictionApiKeyRegistrationAsync(EventStoreName parent, PredictionApiKeyRegistration predictionApiKeyRegistration, gaxgrpc::CallSettings callSettings = null) =>
            CreatePredictionApiKeyRegistrationAsync(new CreatePredictionApiKeyRegistrationRequest
            {
                ParentAsEventStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PredictionApiKeyRegistration = gax::GaxPreconditions.CheckNotNull(predictionApiKeyRegistration, nameof(predictionApiKeyRegistration)),
            }, callSettings);

        /// <summary>
        /// Register an API key for use with predict method.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource path.
        /// `projects/*/locations/global/catalogs/default_catalog/eventStores/default_event_store`.
        /// </param>
        /// <param name="predictionApiKeyRegistration">
        /// Required. The prediction API key registration.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PredictionApiKeyRegistration> CreatePredictionApiKeyRegistrationAsync(EventStoreName parent, PredictionApiKeyRegistration predictionApiKeyRegistration, st::CancellationToken cancellationToken) =>
            CreatePredictionApiKeyRegistrationAsync(parent, predictionApiKeyRegistration, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List the registered apiKeys for use with predict method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PredictionApiKeyRegistration"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPredictionApiKeyRegistrationsResponse, PredictionApiKeyRegistration> ListPredictionApiKeyRegistrations(ListPredictionApiKeyRegistrationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List the registered apiKeys for use with predict method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PredictionApiKeyRegistration"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPredictionApiKeyRegistrationsResponse, PredictionApiKeyRegistration> ListPredictionApiKeyRegistrationsAsync(ListPredictionApiKeyRegistrationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List the registered apiKeys for use with predict method.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent placement resource name such as
        /// `projects/1234/locations/global/catalogs/default_catalog/eventStores/default_event_store`
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
        /// <returns>A pageable sequence of <see cref="PredictionApiKeyRegistration"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPredictionApiKeyRegistrationsResponse, PredictionApiKeyRegistration> ListPredictionApiKeyRegistrations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPredictionApiKeyRegistrationsRequest request = new ListPredictionApiKeyRegistrationsRequest
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
            return ListPredictionApiKeyRegistrations(request, callSettings);
        }

        /// <summary>
        /// List the registered apiKeys for use with predict method.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent placement resource name such as
        /// `projects/1234/locations/global/catalogs/default_catalog/eventStores/default_event_store`
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
        /// <returns>A pageable asynchronous sequence of <see cref="PredictionApiKeyRegistration"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPredictionApiKeyRegistrationsResponse, PredictionApiKeyRegistration> ListPredictionApiKeyRegistrationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPredictionApiKeyRegistrationsRequest request = new ListPredictionApiKeyRegistrationsRequest
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
            return ListPredictionApiKeyRegistrationsAsync(request, callSettings);
        }

        /// <summary>
        /// List the registered apiKeys for use with predict method.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent placement resource name such as
        /// `projects/1234/locations/global/catalogs/default_catalog/eventStores/default_event_store`
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
        /// <returns>A pageable sequence of <see cref="PredictionApiKeyRegistration"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPredictionApiKeyRegistrationsResponse, PredictionApiKeyRegistration> ListPredictionApiKeyRegistrations(EventStoreName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPredictionApiKeyRegistrationsRequest request = new ListPredictionApiKeyRegistrationsRequest
            {
                ParentAsEventStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPredictionApiKeyRegistrations(request, callSettings);
        }

        /// <summary>
        /// List the registered apiKeys for use with predict method.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent placement resource name such as
        /// `projects/1234/locations/global/catalogs/default_catalog/eventStores/default_event_store`
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
        /// <returns>A pageable asynchronous sequence of <see cref="PredictionApiKeyRegistration"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPredictionApiKeyRegistrationsResponse, PredictionApiKeyRegistration> ListPredictionApiKeyRegistrationsAsync(EventStoreName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPredictionApiKeyRegistrationsRequest request = new ListPredictionApiKeyRegistrationsRequest
            {
                ParentAsEventStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPredictionApiKeyRegistrationsAsync(request, callSettings);
        }

        /// <summary>
        /// Unregister an apiKey from using for predict method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePredictionApiKeyRegistration(DeletePredictionApiKeyRegistrationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Unregister an apiKey from using for predict method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePredictionApiKeyRegistrationAsync(DeletePredictionApiKeyRegistrationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Unregister an apiKey from using for predict method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePredictionApiKeyRegistrationAsync(DeletePredictionApiKeyRegistrationRequest request, st::CancellationToken cancellationToken) =>
            DeletePredictionApiKeyRegistrationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Unregister an apiKey from using for predict method.
        /// </summary>
        /// <param name="name">
        /// Required. The API key to unregister including full resource path.
        /// `projects/*/locations/global/catalogs/default_catalog/eventStores/default_event_store/predictionApiKeyRegistrations/&lt;YOUR_API_KEY&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePredictionApiKeyRegistration(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePredictionApiKeyRegistration(new DeletePredictionApiKeyRegistrationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Unregister an apiKey from using for predict method.
        /// </summary>
        /// <param name="name">
        /// Required. The API key to unregister including full resource path.
        /// `projects/*/locations/global/catalogs/default_catalog/eventStores/default_event_store/predictionApiKeyRegistrations/&lt;YOUR_API_KEY&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePredictionApiKeyRegistrationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePredictionApiKeyRegistrationAsync(new DeletePredictionApiKeyRegistrationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Unregister an apiKey from using for predict method.
        /// </summary>
        /// <param name="name">
        /// Required. The API key to unregister including full resource path.
        /// `projects/*/locations/global/catalogs/default_catalog/eventStores/default_event_store/predictionApiKeyRegistrations/&lt;YOUR_API_KEY&gt;`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePredictionApiKeyRegistrationAsync(string name, st::CancellationToken cancellationToken) =>
            DeletePredictionApiKeyRegistrationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Unregister an apiKey from using for predict method.
        /// </summary>
        /// <param name="name">
        /// Required. The API key to unregister including full resource path.
        /// `projects/*/locations/global/catalogs/default_catalog/eventStores/default_event_store/predictionApiKeyRegistrations/&lt;YOUR_API_KEY&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePredictionApiKeyRegistration(PredictionApiKeyRegistrationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePredictionApiKeyRegistration(new DeletePredictionApiKeyRegistrationRequest
            {
                PredictionApiKeyRegistrationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Unregister an apiKey from using for predict method.
        /// </summary>
        /// <param name="name">
        /// Required. The API key to unregister including full resource path.
        /// `projects/*/locations/global/catalogs/default_catalog/eventStores/default_event_store/predictionApiKeyRegistrations/&lt;YOUR_API_KEY&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePredictionApiKeyRegistrationAsync(PredictionApiKeyRegistrationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePredictionApiKeyRegistrationAsync(new DeletePredictionApiKeyRegistrationRequest
            {
                PredictionApiKeyRegistrationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Unregister an apiKey from using for predict method.
        /// </summary>
        /// <param name="name">
        /// Required. The API key to unregister including full resource path.
        /// `projects/*/locations/global/catalogs/default_catalog/eventStores/default_event_store/predictionApiKeyRegistrations/&lt;YOUR_API_KEY&gt;`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePredictionApiKeyRegistrationAsync(PredictionApiKeyRegistrationName name, st::CancellationToken cancellationToken) =>
            DeletePredictionApiKeyRegistrationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>PredictionApiKeyRegistry client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for registering API keys for use with the `predict` method. If you
    /// use an API key to request predictions, you must first register the API key.
    /// Otherwise, your prediction request is rejected. If you use OAuth to
    /// authenticate your `predict` method call, you do not need to register an API
    /// key. You can register up to 20 API keys per project.
    /// </remarks>
    public sealed partial class PredictionApiKeyRegistryClientImpl : PredictionApiKeyRegistryClient
    {
        private readonly gaxgrpc::ApiCall<CreatePredictionApiKeyRegistrationRequest, PredictionApiKeyRegistration> _callCreatePredictionApiKeyRegistration;

        private readonly gaxgrpc::ApiCall<ListPredictionApiKeyRegistrationsRequest, ListPredictionApiKeyRegistrationsResponse> _callListPredictionApiKeyRegistrations;

        private readonly gaxgrpc::ApiCall<DeletePredictionApiKeyRegistrationRequest, wkt::Empty> _callDeletePredictionApiKeyRegistration;

        /// <summary>
        /// Constructs a client wrapper for the PredictionApiKeyRegistry service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="PredictionApiKeyRegistrySettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public PredictionApiKeyRegistryClientImpl(PredictionApiKeyRegistry.PredictionApiKeyRegistryClient grpcClient, PredictionApiKeyRegistrySettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            PredictionApiKeyRegistrySettings effectiveSettings = settings ?? PredictionApiKeyRegistrySettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCreatePredictionApiKeyRegistration = clientHelper.BuildApiCall<CreatePredictionApiKeyRegistrationRequest, PredictionApiKeyRegistration>("CreatePredictionApiKeyRegistration", grpcClient.CreatePredictionApiKeyRegistrationAsync, grpcClient.CreatePredictionApiKeyRegistration, effectiveSettings.CreatePredictionApiKeyRegistrationSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreatePredictionApiKeyRegistration);
            Modify_CreatePredictionApiKeyRegistrationApiCall(ref _callCreatePredictionApiKeyRegistration);
            _callListPredictionApiKeyRegistrations = clientHelper.BuildApiCall<ListPredictionApiKeyRegistrationsRequest, ListPredictionApiKeyRegistrationsResponse>("ListPredictionApiKeyRegistrations", grpcClient.ListPredictionApiKeyRegistrationsAsync, grpcClient.ListPredictionApiKeyRegistrations, effectiveSettings.ListPredictionApiKeyRegistrationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPredictionApiKeyRegistrations);
            Modify_ListPredictionApiKeyRegistrationsApiCall(ref _callListPredictionApiKeyRegistrations);
            _callDeletePredictionApiKeyRegistration = clientHelper.BuildApiCall<DeletePredictionApiKeyRegistrationRequest, wkt::Empty>("DeletePredictionApiKeyRegistration", grpcClient.DeletePredictionApiKeyRegistrationAsync, grpcClient.DeletePredictionApiKeyRegistration, effectiveSettings.DeletePredictionApiKeyRegistrationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeletePredictionApiKeyRegistration);
            Modify_DeletePredictionApiKeyRegistrationApiCall(ref _callDeletePredictionApiKeyRegistration);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreatePredictionApiKeyRegistrationApiCall(ref gaxgrpc::ApiCall<CreatePredictionApiKeyRegistrationRequest, PredictionApiKeyRegistration> call);

        partial void Modify_ListPredictionApiKeyRegistrationsApiCall(ref gaxgrpc::ApiCall<ListPredictionApiKeyRegistrationsRequest, ListPredictionApiKeyRegistrationsResponse> call);

        partial void Modify_DeletePredictionApiKeyRegistrationApiCall(ref gaxgrpc::ApiCall<DeletePredictionApiKeyRegistrationRequest, wkt::Empty> call);

        partial void OnConstruction(PredictionApiKeyRegistry.PredictionApiKeyRegistryClient grpcClient, PredictionApiKeyRegistrySettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC PredictionApiKeyRegistry client</summary>
        public override PredictionApiKeyRegistry.PredictionApiKeyRegistryClient GrpcClient { get; }

        partial void Modify_CreatePredictionApiKeyRegistrationRequest(ref CreatePredictionApiKeyRegistrationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPredictionApiKeyRegistrationsRequest(ref ListPredictionApiKeyRegistrationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePredictionApiKeyRegistrationRequest(ref DeletePredictionApiKeyRegistrationRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Register an API key for use with predict method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PredictionApiKeyRegistration CreatePredictionApiKeyRegistration(CreatePredictionApiKeyRegistrationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePredictionApiKeyRegistrationRequest(ref request, ref callSettings);
            return _callCreatePredictionApiKeyRegistration.Sync(request, callSettings);
        }

        /// <summary>
        /// Register an API key for use with predict method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PredictionApiKeyRegistration> CreatePredictionApiKeyRegistrationAsync(CreatePredictionApiKeyRegistrationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePredictionApiKeyRegistrationRequest(ref request, ref callSettings);
            return _callCreatePredictionApiKeyRegistration.Async(request, callSettings);
        }

        /// <summary>
        /// List the registered apiKeys for use with predict method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PredictionApiKeyRegistration"/> resources.</returns>
        public override gax::PagedEnumerable<ListPredictionApiKeyRegistrationsResponse, PredictionApiKeyRegistration> ListPredictionApiKeyRegistrations(ListPredictionApiKeyRegistrationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPredictionApiKeyRegistrationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPredictionApiKeyRegistrationsRequest, ListPredictionApiKeyRegistrationsResponse, PredictionApiKeyRegistration>(_callListPredictionApiKeyRegistrations, request, callSettings);
        }

        /// <summary>
        /// List the registered apiKeys for use with predict method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PredictionApiKeyRegistration"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPredictionApiKeyRegistrationsResponse, PredictionApiKeyRegistration> ListPredictionApiKeyRegistrationsAsync(ListPredictionApiKeyRegistrationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPredictionApiKeyRegistrationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPredictionApiKeyRegistrationsRequest, ListPredictionApiKeyRegistrationsResponse, PredictionApiKeyRegistration>(_callListPredictionApiKeyRegistrations, request, callSettings);
        }

        /// <summary>
        /// Unregister an apiKey from using for predict method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeletePredictionApiKeyRegistration(DeletePredictionApiKeyRegistrationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePredictionApiKeyRegistrationRequest(ref request, ref callSettings);
            _callDeletePredictionApiKeyRegistration.Sync(request, callSettings);
        }

        /// <summary>
        /// Unregister an apiKey from using for predict method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeletePredictionApiKeyRegistrationAsync(DeletePredictionApiKeyRegistrationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePredictionApiKeyRegistrationRequest(ref request, ref callSettings);
            return _callDeletePredictionApiKeyRegistration.Async(request, callSettings);
        }
    }

    public partial class ListPredictionApiKeyRegistrationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPredictionApiKeyRegistrationsResponse : gaxgrpc::IPageResponse<PredictionApiKeyRegistration>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PredictionApiKeyRegistration> GetEnumerator() =>
            PredictionApiKeyRegistrations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
