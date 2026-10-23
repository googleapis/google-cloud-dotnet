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

namespace Google.Cloud.Ces.V1Beta
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
            ListAssistantSessionsSettings = existing.ListAssistantSessionsSettings;
            GetAssistantSessionSettings = existing.GetAssistantSessionSettings;
            CreateAssistantSessionSettings = existing.CreateAssistantSessionSettings;
            DeleteAssistantSessionSettings = existing.DeleteAssistantSessionSettings;
            RunAssistantSettings = existing.RunAssistantSettings;
            ChatAiAssistantSettings = existing.ChatAiAssistantSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AssistantServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssistantServiceClient.ListAssistantSessions</c> and <c>AssistantServiceClient.ListAssistantSessionsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAssistantSessionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssistantServiceClient.GetAssistantSession</c> and <c>AssistantServiceClient.GetAssistantSessionAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAssistantSessionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssistantServiceClient.CreateAssistantSession</c> and
        /// <c>AssistantServiceClient.CreateAssistantSessionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAssistantSessionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssistantServiceClient.DeleteAssistantSession</c> and
        /// <c>AssistantServiceClient.DeleteAssistantSessionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAssistantSessionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssistantServiceClient.RunAssistant</c> and <c>AssistantServiceClient.RunAssistantAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RunAssistantSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssistantServiceClient.ChatAiAssistant</c> and <c>AssistantServiceClient.ChatAiAssistantAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ChatAiAssistantSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

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
    /// The service that manages assistant-related resources in Customer Engagement
    /// Suite (CES). The assistant, Arc, is a conversational agent embedded in CES
    /// applications to help users with building their agents.
    /// </remarks>
    public abstract partial class AssistantServiceClient
    {
        /// <summary>
        /// The default endpoint for the AssistantService service, which is a host of "ces.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "ces.googleapis.com:443";

        /// <summary>The default AssistantService scopes.</summary>
        /// <remarks>
        /// The default AssistantService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/ces</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/ces",
            "https://www.googleapis.com/auth/cloud-platform",
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
        /// Lists all assistant sessions in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AssistantSession"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAssistantSessionsResponse, AssistantSession> ListAssistantSessions(ListAssistantSessionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all assistant sessions in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AssistantSession"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAssistantSessionsResponse, AssistantSession> ListAssistantSessionsAsync(ListAssistantSessionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all assistant sessions in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to list assistant sessions from.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
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
        /// <returns>A pageable sequence of <see cref="AssistantSession"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAssistantSessionsResponse, AssistantSession> ListAssistantSessions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAssistantSessionsRequest request = new ListAssistantSessionsRequest
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
            return ListAssistantSessions(request, callSettings);
        }

        /// <summary>
        /// Lists all assistant sessions in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to list assistant sessions from.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="AssistantSession"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAssistantSessionsResponse, AssistantSession> ListAssistantSessionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAssistantSessionsRequest request = new ListAssistantSessionsRequest
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
            return ListAssistantSessionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all assistant sessions in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to list assistant sessions from.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
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
        /// <returns>A pageable sequence of <see cref="AssistantSession"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAssistantSessionsResponse, AssistantSession> ListAssistantSessions(AppName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAssistantSessionsRequest request = new ListAssistantSessionsRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAssistantSessions(request, callSettings);
        }

        /// <summary>
        /// Lists all assistant sessions in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to list assistant sessions from.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="AssistantSession"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAssistantSessionsResponse, AssistantSession> ListAssistantSessionsAsync(AppName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAssistantSessionsRequest request = new ListAssistantSessionsRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAssistantSessionsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified assistant session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AssistantSession GetAssistantSession(GetAssistantSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of the specified assistant session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AssistantSession> GetAssistantSessionAsync(GetAssistantSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of the specified assistant session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AssistantSession> GetAssistantSessionAsync(GetAssistantSessionRequest request, st::CancellationToken cancellationToken) =>
            GetAssistantSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified assistant session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the assistant session to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}/assistantSessions/{assistant_session}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AssistantSession GetAssistantSession(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAssistantSession(new GetAssistantSessionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified assistant session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the assistant session to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}/assistantSessions/{assistant_session}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AssistantSession> GetAssistantSessionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAssistantSessionAsync(new GetAssistantSessionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified assistant session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the assistant session to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}/assistantSessions/{assistant_session}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AssistantSession> GetAssistantSessionAsync(string name, st::CancellationToken cancellationToken) =>
            GetAssistantSessionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified assistant session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the assistant session to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}/assistantSessions/{assistant_session}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AssistantSession GetAssistantSession(AssistantSessionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAssistantSession(new GetAssistantSessionRequest
            {
                AssistantSessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified assistant session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the assistant session to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}/assistantSessions/{assistant_session}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AssistantSession> GetAssistantSessionAsync(AssistantSessionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAssistantSessionAsync(new GetAssistantSessionRequest
            {
                AssistantSessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified assistant session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the assistant session to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}/assistantSessions/{assistant_session}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AssistantSession> GetAssistantSessionAsync(AssistantSessionName name, st::CancellationToken cancellationToken) =>
            GetAssistantSessionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new assistant session in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AssistantSession CreateAssistantSession(CreateAssistantSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new assistant session in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AssistantSession> CreateAssistantSessionAsync(CreateAssistantSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new assistant session in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AssistantSession> CreateAssistantSessionAsync(CreateAssistantSessionRequest request, st::CancellationToken cancellationToken) =>
            CreateAssistantSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new assistant session in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the assistant session in
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="assistantSessionId">
        /// Optional. The ID to use for the assistant session, which will become the
        /// final component of the assistant session's resource name. If not provided,
        /// a unique ID will be automatically assigned for the assistant session.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AssistantSession CreateAssistantSession(string parent, string assistantSessionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAssistantSession(new CreateAssistantSessionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AssistantSessionId = assistantSessionId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a new assistant session in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the assistant session in
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="assistantSessionId">
        /// Optional. The ID to use for the assistant session, which will become the
        /// final component of the assistant session's resource name. If not provided,
        /// a unique ID will be automatically assigned for the assistant session.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AssistantSession> CreateAssistantSessionAsync(string parent, string assistantSessionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAssistantSessionAsync(new CreateAssistantSessionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AssistantSessionId = assistantSessionId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a new assistant session in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the assistant session in
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="assistantSessionId">
        /// Optional. The ID to use for the assistant session, which will become the
        /// final component of the assistant session's resource name. If not provided,
        /// a unique ID will be automatically assigned for the assistant session.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AssistantSession> CreateAssistantSessionAsync(string parent, string assistantSessionId, st::CancellationToken cancellationToken) =>
            CreateAssistantSessionAsync(parent, assistantSessionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new assistant session in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the assistant session in
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="assistantSessionId">
        /// Optional. The ID to use for the assistant session, which will become the
        /// final component of the assistant session's resource name. If not provided,
        /// a unique ID will be automatically assigned for the assistant session.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AssistantSession CreateAssistantSession(AppName parent, string assistantSessionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAssistantSession(new CreateAssistantSessionRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AssistantSessionId = assistantSessionId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a new assistant session in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the assistant session in
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="assistantSessionId">
        /// Optional. The ID to use for the assistant session, which will become the
        /// final component of the assistant session's resource name. If not provided,
        /// a unique ID will be automatically assigned for the assistant session.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AssistantSession> CreateAssistantSessionAsync(AppName parent, string assistantSessionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAssistantSessionAsync(new CreateAssistantSessionRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AssistantSessionId = assistantSessionId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a new assistant session in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the assistant session in
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="assistantSessionId">
        /// Optional. The ID to use for the assistant session, which will become the
        /// final component of the assistant session's resource name. If not provided,
        /// a unique ID will be automatically assigned for the assistant session.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AssistantSession> CreateAssistantSessionAsync(AppName parent, string assistantSessionId, st::CancellationToken cancellationToken) =>
            CreateAssistantSessionAsync(parent, assistantSessionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified assistant session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAssistantSession(DeleteAssistantSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified assistant session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAssistantSessionAsync(DeleteAssistantSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified assistant session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAssistantSessionAsync(DeleteAssistantSessionRequest request, st::CancellationToken cancellationToken) =>
            DeleteAssistantSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified assistant session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the assistant session to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}/assistantSessions/{assistant_session}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAssistantSession(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAssistantSession(new DeleteAssistantSessionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified assistant session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the assistant session to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}/assistantSessions/{assistant_session}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAssistantSessionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAssistantSessionAsync(new DeleteAssistantSessionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified assistant session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the assistant session to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}/assistantSessions/{assistant_session}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAssistantSessionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAssistantSessionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified assistant session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the assistant session to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}/assistantSessions/{assistant_session}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAssistantSession(AssistantSessionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAssistantSession(new DeleteAssistantSessionRequest
            {
                AssistantSessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified assistant session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the assistant session to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}/assistantSessions/{assistant_session}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAssistantSessionAsync(AssistantSessionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAssistantSessionAsync(new DeleteAssistantSessionRequest
            {
                AssistantSessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified assistant session.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the assistant session to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}/assistantSessions/{assistant_session}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAssistantSessionAsync(AssistantSessionName name, st::CancellationToken cancellationToken) =>
            DeleteAssistantSessionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Runs the assistant agent for the specified assistant session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RunAssistantResponse RunAssistant(RunAssistantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Runs the assistant agent for the specified assistant session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunAssistantResponse> RunAssistantAsync(RunAssistantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Runs the assistant agent for the specified assistant session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunAssistantResponse> RunAssistantAsync(RunAssistantRequest request, st::CancellationToken cancellationToken) =>
            RunAssistantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Runs Arc, the AI assistant, for the specified assistant session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ChatAiAssistantResponse ChatAiAssistant(ChatAiAssistantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Runs Arc, the AI assistant, for the specified assistant session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChatAiAssistantResponse> ChatAiAssistantAsync(ChatAiAssistantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Runs Arc, the AI assistant, for the specified assistant session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChatAiAssistantResponse> ChatAiAssistantAsync(ChatAiAssistantRequest request, st::CancellationToken cancellationToken) =>
            ChatAiAssistantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AssistantService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The service that manages assistant-related resources in Customer Engagement
    /// Suite (CES). The assistant, Arc, is a conversational agent embedded in CES
    /// applications to help users with building their agents.
    /// </remarks>
    public sealed partial class AssistantServiceClientImpl : AssistantServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListAssistantSessionsRequest, ListAssistantSessionsResponse> _callListAssistantSessions;

        private readonly gaxgrpc::ApiCall<GetAssistantSessionRequest, AssistantSession> _callGetAssistantSession;

        private readonly gaxgrpc::ApiCall<CreateAssistantSessionRequest, AssistantSession> _callCreateAssistantSession;

        private readonly gaxgrpc::ApiCall<DeleteAssistantSessionRequest, wkt::Empty> _callDeleteAssistantSession;

        private readonly gaxgrpc::ApiCall<RunAssistantRequest, RunAssistantResponse> _callRunAssistant;

        private readonly gaxgrpc::ApiCall<ChatAiAssistantRequest, ChatAiAssistantResponse> _callChatAiAssistant;

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
            _callListAssistantSessions = clientHelper.BuildApiCall<ListAssistantSessionsRequest, ListAssistantSessionsResponse>("ListAssistantSessions", grpcClient.ListAssistantSessionsAsync, grpcClient.ListAssistantSessions, effectiveSettings.ListAssistantSessionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAssistantSessions);
            Modify_ListAssistantSessionsApiCall(ref _callListAssistantSessions);
            _callGetAssistantSession = clientHelper.BuildApiCall<GetAssistantSessionRequest, AssistantSession>("GetAssistantSession", grpcClient.GetAssistantSessionAsync, grpcClient.GetAssistantSession, effectiveSettings.GetAssistantSessionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAssistantSession);
            Modify_GetAssistantSessionApiCall(ref _callGetAssistantSession);
            _callCreateAssistantSession = clientHelper.BuildApiCall<CreateAssistantSessionRequest, AssistantSession>("CreateAssistantSession", grpcClient.CreateAssistantSessionAsync, grpcClient.CreateAssistantSession, effectiveSettings.CreateAssistantSessionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAssistantSession);
            Modify_CreateAssistantSessionApiCall(ref _callCreateAssistantSession);
            _callDeleteAssistantSession = clientHelper.BuildApiCall<DeleteAssistantSessionRequest, wkt::Empty>("DeleteAssistantSession", grpcClient.DeleteAssistantSessionAsync, grpcClient.DeleteAssistantSession, effectiveSettings.DeleteAssistantSessionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAssistantSession);
            Modify_DeleteAssistantSessionApiCall(ref _callDeleteAssistantSession);
            _callRunAssistant = clientHelper.BuildApiCall<RunAssistantRequest, RunAssistantResponse>("RunAssistant", grpcClient.RunAssistantAsync, grpcClient.RunAssistant, effectiveSettings.RunAssistantSettings).WithGoogleRequestParam("app", request => request.App);
            Modify_ApiCall(ref _callRunAssistant);
            Modify_RunAssistantApiCall(ref _callRunAssistant);
            _callChatAiAssistant = clientHelper.BuildApiCall<ChatAiAssistantRequest, ChatAiAssistantResponse>("ChatAiAssistant", grpcClient.ChatAiAssistantAsync, grpcClient.ChatAiAssistant, effectiveSettings.ChatAiAssistantSettings).WithGoogleRequestParam("app", request => request.App);
            Modify_ApiCall(ref _callChatAiAssistant);
            Modify_ChatAiAssistantApiCall(ref _callChatAiAssistant);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListAssistantSessionsApiCall(ref gaxgrpc::ApiCall<ListAssistantSessionsRequest, ListAssistantSessionsResponse> call);

        partial void Modify_GetAssistantSessionApiCall(ref gaxgrpc::ApiCall<GetAssistantSessionRequest, AssistantSession> call);

        partial void Modify_CreateAssistantSessionApiCall(ref gaxgrpc::ApiCall<CreateAssistantSessionRequest, AssistantSession> call);

        partial void Modify_DeleteAssistantSessionApiCall(ref gaxgrpc::ApiCall<DeleteAssistantSessionRequest, wkt::Empty> call);

        partial void Modify_RunAssistantApiCall(ref gaxgrpc::ApiCall<RunAssistantRequest, RunAssistantResponse> call);

        partial void Modify_ChatAiAssistantApiCall(ref gaxgrpc::ApiCall<ChatAiAssistantRequest, ChatAiAssistantResponse> call);

        partial void OnConstruction(AssistantService.AssistantServiceClient grpcClient, AssistantServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AssistantService client</summary>
        public override AssistantService.AssistantServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListAssistantSessionsRequest(ref ListAssistantSessionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAssistantSessionRequest(ref GetAssistantSessionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAssistantSessionRequest(ref CreateAssistantSessionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAssistantSessionRequest(ref DeleteAssistantSessionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RunAssistantRequest(ref RunAssistantRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ChatAiAssistantRequest(ref ChatAiAssistantRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists all assistant sessions in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AssistantSession"/> resources.</returns>
        public override gax::PagedEnumerable<ListAssistantSessionsResponse, AssistantSession> ListAssistantSessions(ListAssistantSessionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAssistantSessionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAssistantSessionsRequest, ListAssistantSessionsResponse, AssistantSession>(_callListAssistantSessions, request, callSettings);
        }

        /// <summary>
        /// Lists all assistant sessions in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AssistantSession"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAssistantSessionsResponse, AssistantSession> ListAssistantSessionsAsync(ListAssistantSessionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAssistantSessionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAssistantSessionsRequest, ListAssistantSessionsResponse, AssistantSession>(_callListAssistantSessions, request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified assistant session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AssistantSession GetAssistantSession(GetAssistantSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAssistantSessionRequest(ref request, ref callSettings);
            return _callGetAssistantSession.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified assistant session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AssistantSession> GetAssistantSessionAsync(GetAssistantSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAssistantSessionRequest(ref request, ref callSettings);
            return _callGetAssistantSession.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new assistant session in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AssistantSession CreateAssistantSession(CreateAssistantSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAssistantSessionRequest(ref request, ref callSettings);
            return _callCreateAssistantSession.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new assistant session in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AssistantSession> CreateAssistantSessionAsync(CreateAssistantSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAssistantSessionRequest(ref request, ref callSettings);
            return _callCreateAssistantSession.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified assistant session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteAssistantSession(DeleteAssistantSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAssistantSessionRequest(ref request, ref callSettings);
            _callDeleteAssistantSession.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified assistant session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteAssistantSessionAsync(DeleteAssistantSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAssistantSessionRequest(ref request, ref callSettings);
            return _callDeleteAssistantSession.Async(request, callSettings);
        }

        /// <summary>
        /// Runs the assistant agent for the specified assistant session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RunAssistantResponse RunAssistant(RunAssistantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunAssistantRequest(ref request, ref callSettings);
            return _callRunAssistant.Sync(request, callSettings);
        }

        /// <summary>
        /// Runs the assistant agent for the specified assistant session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RunAssistantResponse> RunAssistantAsync(RunAssistantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunAssistantRequest(ref request, ref callSettings);
            return _callRunAssistant.Async(request, callSettings);
        }

        /// <summary>
        /// Runs Arc, the AI assistant, for the specified assistant session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ChatAiAssistantResponse ChatAiAssistant(ChatAiAssistantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ChatAiAssistantRequest(ref request, ref callSettings);
            return _callChatAiAssistant.Sync(request, callSettings);
        }

        /// <summary>
        /// Runs Arc, the AI assistant, for the specified assistant session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ChatAiAssistantResponse> ChatAiAssistantAsync(ChatAiAssistantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ChatAiAssistantRequest(ref request, ref callSettings);
            return _callChatAiAssistant.Async(request, callSettings);
        }
    }

    public partial class ListAssistantSessionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAssistantSessionsResponse : gaxgrpc::IPageResponse<AssistantSession>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AssistantSession> GetEnumerator() => AssistantSessions.GetEnumerator();

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
