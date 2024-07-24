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
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Dialogflow.V2Beta1
{
    /// <summary>Settings for <see cref="ContextsClient"/> instances.</summary>
    public sealed partial class ContextsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ContextsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ContextsSettings"/>.</returns>
        public static ContextsSettings GetDefault() => new ContextsSettings();

        /// <summary>Constructs a new <see cref="ContextsSettings"/> object with default settings.</summary>
        public ContextsSettings()
        {
        }

        private ContextsSettings(ContextsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListContextsSettings = existing.ListContextsSettings;
            GetContextSettings = existing.GetContextSettings;
            CreateContextSettings = existing.CreateContextSettings;
            UpdateContextSettings = existing.UpdateContextSettings;
            DeleteContextSettings = existing.DeleteContextSettings;
            DeleteAllContextsSettings = existing.DeleteAllContextsSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ContextsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ContextsClient.ListContexts</c>
        ///  and <c>ContextsClient.ListContextsAsync</c>.
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
        public gaxgrpc::CallSettings ListContextsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ContextsClient.GetContext</c>
        ///  and <c>ContextsClient.GetContextAsync</c>.
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
        public gaxgrpc::CallSettings GetContextSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContextsClient.CreateContext</c> and <c>ContextsClient.CreateContextAsync</c>.
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
        public gaxgrpc::CallSettings CreateContextSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContextsClient.UpdateContext</c> and <c>ContextsClient.UpdateContextAsync</c>.
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
        public gaxgrpc::CallSettings UpdateContextSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContextsClient.DeleteContext</c> and <c>ContextsClient.DeleteContextAsync</c>.
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
        public gaxgrpc::CallSettings DeleteContextSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContextsClient.DeleteAllContexts</c> and <c>ContextsClient.DeleteAllContextsAsync</c>.
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
        public gaxgrpc::CallSettings DeleteAllContextsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ContextsSettings"/> object.</returns>
        public ContextsSettings Clone() => new ContextsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ContextsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ContextsClientBuilder : gaxgrpc::ClientBuilderBase<ContextsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ContextsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ContextsClientBuilder() : base(ContextsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ContextsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ContextsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ContextsClient Build()
        {
            ContextsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ContextsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ContextsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ContextsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ContextsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ContextsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ContextsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ContextsClient.ChannelPool;
    }

    /// <summary>Contexts client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Contexts][google.cloud.dialogflow.v2beta1.Context].
    /// </remarks>
    public abstract partial class ContextsClient
    {
        /// <summary>
        /// The default endpoint for the Contexts service, which is a host of "dialogflow.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dialogflow.googleapis.com:443";

        /// <summary>The default Contexts scopes.</summary>
        /// <remarks>
        /// The default Contexts scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Contexts.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ContextsClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="ContextsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ContextsClient"/>.</returns>
        public static stt::Task<ContextsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ContextsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ContextsClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="ContextsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ContextsClient"/>.</returns>
        public static ContextsClient Create() => new ContextsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ContextsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ContextsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ContextsClient"/>.</returns>
        internal static ContextsClient Create(grpccore::CallInvoker callInvoker, ContextsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Contexts.ContextsClient grpcClient = new Contexts.ContextsClient(callInvoker);
            return new ContextsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Contexts client</summary>
        public virtual Contexts.ContextsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all contexts in the specified session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Context"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListContextsResponse, Context> ListContexts(ListContextsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all contexts in the specified session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Context"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListContextsResponse, Context> ListContextsAsync(ListContextsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all contexts in the specified session.
        /// </summary>
        /// <param name="parent">
        /// Required. The session to list all contexts from. Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/sessions/&lt;Session
        /// ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User
        /// ID&gt;/sessions/&lt;Session ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User ID&gt;/sessions/&lt;Session
        /// ID&gt;`,
        /// 
        /// If `Location ID` is not specified we assume default 'us' location. If
        /// `Environment ID` is not specified, we assume default 'draft' environment.
        /// If `User ID` is not specified, we assume default '-' user.
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
        /// <returns>A pageable sequence of <see cref="Context"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListContextsResponse, Context> ListContexts(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListContextsRequest request = new ListContextsRequest
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
            return ListContexts(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all contexts in the specified session.
        /// </summary>
        /// <param name="parent">
        /// Required. The session to list all contexts from. Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/sessions/&lt;Session
        /// ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User
        /// ID&gt;/sessions/&lt;Session ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User ID&gt;/sessions/&lt;Session
        /// ID&gt;`,
        /// 
        /// If `Location ID` is not specified we assume default 'us' location. If
        /// `Environment ID` is not specified, we assume default 'draft' environment.
        /// If `User ID` is not specified, we assume default '-' user.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Context"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListContextsResponse, Context> ListContextsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListContextsRequest request = new ListContextsRequest
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
            return ListContextsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all contexts in the specified session.
        /// </summary>
        /// <param name="parent">
        /// Required. The session to list all contexts from. Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/sessions/&lt;Session
        /// ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User
        /// ID&gt;/sessions/&lt;Session ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User ID&gt;/sessions/&lt;Session
        /// ID&gt;`,
        /// 
        /// If `Location ID` is not specified we assume default 'us' location. If
        /// `Environment ID` is not specified, we assume default 'draft' environment.
        /// If `User ID` is not specified, we assume default '-' user.
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
        /// <returns>A pageable sequence of <see cref="Context"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListContextsResponse, Context> ListContexts(SessionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListContextsRequest request = new ListContextsRequest
            {
                ParentAsSessionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListContexts(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all contexts in the specified session.
        /// </summary>
        /// <param name="parent">
        /// Required. The session to list all contexts from. Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/sessions/&lt;Session
        /// ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User
        /// ID&gt;/sessions/&lt;Session ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User ID&gt;/sessions/&lt;Session
        /// ID&gt;`,
        /// 
        /// If `Location ID` is not specified we assume default 'us' location. If
        /// `Environment ID` is not specified, we assume default 'draft' environment.
        /// If `User ID` is not specified, we assume default '-' user.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Context"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListContextsResponse, Context> ListContextsAsync(SessionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListContextsRequest request = new ListContextsRequest
            {
                ParentAsSessionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListContextsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Context GetContext(GetContextRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Context> GetContextAsync(GetContextRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Context> GetContextAsync(GetContextRequest request, st::CancellationToken cancellationToken) =>
            GetContextAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified context.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the context. Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;/contexts/&lt;Context
        /// ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/sessions/&lt;Session
        /// ID&gt;/contexts/&lt;Context ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User
        /// ID&gt;/sessions/&lt;Session ID&gt;/contexts/&lt;Context ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User ID&gt;/sessions/&lt;Session
        /// ID&gt;/contexts/&lt;Context ID&gt;`,
        /// 
        /// If `Location ID` is not specified we assume default 'us' location. If
        /// `Environment ID` is not specified, we assume default 'draft' environment.
        /// If `User ID` is not specified, we assume default '-' user.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Context GetContext(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetContext(new GetContextRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified context.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the context. Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;/contexts/&lt;Context
        /// ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/sessions/&lt;Session
        /// ID&gt;/contexts/&lt;Context ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User
        /// ID&gt;/sessions/&lt;Session ID&gt;/contexts/&lt;Context ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User ID&gt;/sessions/&lt;Session
        /// ID&gt;/contexts/&lt;Context ID&gt;`,
        /// 
        /// If `Location ID` is not specified we assume default 'us' location. If
        /// `Environment ID` is not specified, we assume default 'draft' environment.
        /// If `User ID` is not specified, we assume default '-' user.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Context> GetContextAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetContextAsync(new GetContextRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified context.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the context. Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;/contexts/&lt;Context
        /// ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/sessions/&lt;Session
        /// ID&gt;/contexts/&lt;Context ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User
        /// ID&gt;/sessions/&lt;Session ID&gt;/contexts/&lt;Context ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User ID&gt;/sessions/&lt;Session
        /// ID&gt;/contexts/&lt;Context ID&gt;`,
        /// 
        /// If `Location ID` is not specified we assume default 'us' location. If
        /// `Environment ID` is not specified, we assume default 'draft' environment.
        /// If `User ID` is not specified, we assume default '-' user.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Context> GetContextAsync(string name, st::CancellationToken cancellationToken) =>
            GetContextAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified context.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the context. Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;/contexts/&lt;Context
        /// ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/sessions/&lt;Session
        /// ID&gt;/contexts/&lt;Context ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User
        /// ID&gt;/sessions/&lt;Session ID&gt;/contexts/&lt;Context ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User ID&gt;/sessions/&lt;Session
        /// ID&gt;/contexts/&lt;Context ID&gt;`,
        /// 
        /// If `Location ID` is not specified we assume default 'us' location. If
        /// `Environment ID` is not specified, we assume default 'draft' environment.
        /// If `User ID` is not specified, we assume default '-' user.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Context GetContext(ContextName name, gaxgrpc::CallSettings callSettings = null) =>
            GetContext(new GetContextRequest
            {
                ContextName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified context.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the context. Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;/contexts/&lt;Context
        /// ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/sessions/&lt;Session
        /// ID&gt;/contexts/&lt;Context ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User
        /// ID&gt;/sessions/&lt;Session ID&gt;/contexts/&lt;Context ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User ID&gt;/sessions/&lt;Session
        /// ID&gt;/contexts/&lt;Context ID&gt;`,
        /// 
        /// If `Location ID` is not specified we assume default 'us' location. If
        /// `Environment ID` is not specified, we assume default 'draft' environment.
        /// If `User ID` is not specified, we assume default '-' user.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Context> GetContextAsync(ContextName name, gaxgrpc::CallSettings callSettings = null) =>
            GetContextAsync(new GetContextRequest
            {
                ContextName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified context.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the context. Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;/contexts/&lt;Context
        /// ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/sessions/&lt;Session
        /// ID&gt;/contexts/&lt;Context ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User
        /// ID&gt;/sessions/&lt;Session ID&gt;/contexts/&lt;Context ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User ID&gt;/sessions/&lt;Session
        /// ID&gt;/contexts/&lt;Context ID&gt;`,
        /// 
        /// If `Location ID` is not specified we assume default 'us' location. If
        /// `Environment ID` is not specified, we assume default 'draft' environment.
        /// If `User ID` is not specified, we assume default '-' user.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Context> GetContextAsync(ContextName name, st::CancellationToken cancellationToken) =>
            GetContextAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a context.
        /// 
        /// If the specified context already exists, overrides the context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Context CreateContext(CreateContextRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a context.
        /// 
        /// If the specified context already exists, overrides the context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Context> CreateContextAsync(CreateContextRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a context.
        /// 
        /// If the specified context already exists, overrides the context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Context> CreateContextAsync(CreateContextRequest request, st::CancellationToken cancellationToken) =>
            CreateContextAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a context.
        /// 
        /// If the specified context already exists, overrides the context.
        /// </summary>
        /// <param name="parent">
        /// Required. The session to create a context for. Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/sessions/&lt;Session
        /// ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User
        /// ID&gt;/sessions/&lt;Session ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User ID&gt;/sessions/&lt;Session
        /// ID&gt;`,
        /// 
        /// If `Location ID` is not specified we assume default 'us' location. If
        /// `Environment ID` is not specified, we assume default 'draft' environment.
        /// If `User ID` is not specified, we assume default '-' user.
        /// </param>
        /// <param name="context">
        /// Required. The context to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Context CreateContext(string parent, Context context, gaxgrpc::CallSettings callSettings = null) =>
            CreateContext(new CreateContextRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Context = gax::GaxPreconditions.CheckNotNull(context, nameof(context)),
            }, callSettings);

        /// <summary>
        /// Creates a context.
        /// 
        /// If the specified context already exists, overrides the context.
        /// </summary>
        /// <param name="parent">
        /// Required. The session to create a context for. Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/sessions/&lt;Session
        /// ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User
        /// ID&gt;/sessions/&lt;Session ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User ID&gt;/sessions/&lt;Session
        /// ID&gt;`,
        /// 
        /// If `Location ID` is not specified we assume default 'us' location. If
        /// `Environment ID` is not specified, we assume default 'draft' environment.
        /// If `User ID` is not specified, we assume default '-' user.
        /// </param>
        /// <param name="context">
        /// Required. The context to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Context> CreateContextAsync(string parent, Context context, gaxgrpc::CallSettings callSettings = null) =>
            CreateContextAsync(new CreateContextRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Context = gax::GaxPreconditions.CheckNotNull(context, nameof(context)),
            }, callSettings);

        /// <summary>
        /// Creates a context.
        /// 
        /// If the specified context already exists, overrides the context.
        /// </summary>
        /// <param name="parent">
        /// Required. The session to create a context for. Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/sessions/&lt;Session
        /// ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User
        /// ID&gt;/sessions/&lt;Session ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User ID&gt;/sessions/&lt;Session
        /// ID&gt;`,
        /// 
        /// If `Location ID` is not specified we assume default 'us' location. If
        /// `Environment ID` is not specified, we assume default 'draft' environment.
        /// If `User ID` is not specified, we assume default '-' user.
        /// </param>
        /// <param name="context">
        /// Required. The context to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Context> CreateContextAsync(string parent, Context context, st::CancellationToken cancellationToken) =>
            CreateContextAsync(parent, context, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a context.
        /// 
        /// If the specified context already exists, overrides the context.
        /// </summary>
        /// <param name="parent">
        /// Required. The session to create a context for. Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/sessions/&lt;Session
        /// ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User
        /// ID&gt;/sessions/&lt;Session ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User ID&gt;/sessions/&lt;Session
        /// ID&gt;`,
        /// 
        /// If `Location ID` is not specified we assume default 'us' location. If
        /// `Environment ID` is not specified, we assume default 'draft' environment.
        /// If `User ID` is not specified, we assume default '-' user.
        /// </param>
        /// <param name="context">
        /// Required. The context to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Context CreateContext(SessionName parent, Context context, gaxgrpc::CallSettings callSettings = null) =>
            CreateContext(new CreateContextRequest
            {
                ParentAsSessionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Context = gax::GaxPreconditions.CheckNotNull(context, nameof(context)),
            }, callSettings);

        /// <summary>
        /// Creates a context.
        /// 
        /// If the specified context already exists, overrides the context.
        /// </summary>
        /// <param name="parent">
        /// Required. The session to create a context for. Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/sessions/&lt;Session
        /// ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User
        /// ID&gt;/sessions/&lt;Session ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User ID&gt;/sessions/&lt;Session
        /// ID&gt;`,
        /// 
        /// If `Location ID` is not specified we assume default 'us' location. If
        /// `Environment ID` is not specified, we assume default 'draft' environment.
        /// If `User ID` is not specified, we assume default '-' user.
        /// </param>
        /// <param name="context">
        /// Required. The context to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Context> CreateContextAsync(SessionName parent, Context context, gaxgrpc::CallSettings callSettings = null) =>
            CreateContextAsync(new CreateContextRequest
            {
                ParentAsSessionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Context = gax::GaxPreconditions.CheckNotNull(context, nameof(context)),
            }, callSettings);

        /// <summary>
        /// Creates a context.
        /// 
        /// If the specified context already exists, overrides the context.
        /// </summary>
        /// <param name="parent">
        /// Required. The session to create a context for. Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/sessions/&lt;Session
        /// ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User
        /// ID&gt;/sessions/&lt;Session ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User ID&gt;/sessions/&lt;Session
        /// ID&gt;`,
        /// 
        /// If `Location ID` is not specified we assume default 'us' location. If
        /// `Environment ID` is not specified, we assume default 'draft' environment.
        /// If `User ID` is not specified, we assume default '-' user.
        /// </param>
        /// <param name="context">
        /// Required. The context to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Context> CreateContextAsync(SessionName parent, Context context, st::CancellationToken cancellationToken) =>
            CreateContextAsync(parent, context, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Context UpdateContext(UpdateContextRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Context> UpdateContextAsync(UpdateContextRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Context> UpdateContextAsync(UpdateContextRequest request, st::CancellationToken cancellationToken) =>
            UpdateContextAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified context.
        /// </summary>
        /// <param name="context">
        /// Required. The context to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Context UpdateContext(Context context, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateContext(new UpdateContextRequest
            {
                Context = gax::GaxPreconditions.CheckNotNull(context, nameof(context)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified context.
        /// </summary>
        /// <param name="context">
        /// Required. The context to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Context> UpdateContextAsync(Context context, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateContextAsync(new UpdateContextRequest
            {
                Context = gax::GaxPreconditions.CheckNotNull(context, nameof(context)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified context.
        /// </summary>
        /// <param name="context">
        /// Required. The context to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The mask to control which fields get updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Context> UpdateContextAsync(Context context, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateContextAsync(context, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified context.
        /// </summary>
        /// <param name="context">
        /// Required. The context to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Context UpdateContext(Context context, gaxgrpc::CallSettings callSettings = null) =>
            UpdateContext(new UpdateContextRequest
            {
                Context = gax::GaxPreconditions.CheckNotNull(context, nameof(context)),
            }, callSettings);

        /// <summary>
        /// Updates the specified context.
        /// </summary>
        /// <param name="context">
        /// Required. The context to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Context> UpdateContextAsync(Context context, gaxgrpc::CallSettings callSettings = null) =>
            UpdateContextAsync(new UpdateContextRequest
            {
                Context = gax::GaxPreconditions.CheckNotNull(context, nameof(context)),
            }, callSettings);

        /// <summary>
        /// Updates the specified context.
        /// </summary>
        /// <param name="context">
        /// Required. The context to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Context> UpdateContextAsync(Context context, st::CancellationToken cancellationToken) =>
            UpdateContextAsync(context, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteContext(DeleteContextRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteContextAsync(DeleteContextRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteContextAsync(DeleteContextRequest request, st::CancellationToken cancellationToken) =>
            DeleteContextAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified context.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the context to delete. Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;/contexts/&lt;Context
        /// ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/sessions/&lt;Session
        /// ID&gt;/contexts/&lt;Context ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User
        /// ID&gt;/sessions/&lt;Session ID&gt;/contexts/&lt;Context ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User ID&gt;/sessions/&lt;Session
        /// ID&gt;/contexts/&lt;Context ID&gt;`,
        /// 
        /// If `Location ID` is not specified we assume default 'us' location. If
        /// `Environment ID` is not specified, we assume default 'draft' environment.
        /// If `User ID` is not specified, we assume default '-' user.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteContext(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteContext(new DeleteContextRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified context.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the context to delete. Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;/contexts/&lt;Context
        /// ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/sessions/&lt;Session
        /// ID&gt;/contexts/&lt;Context ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User
        /// ID&gt;/sessions/&lt;Session ID&gt;/contexts/&lt;Context ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User ID&gt;/sessions/&lt;Session
        /// ID&gt;/contexts/&lt;Context ID&gt;`,
        /// 
        /// If `Location ID` is not specified we assume default 'us' location. If
        /// `Environment ID` is not specified, we assume default 'draft' environment.
        /// If `User ID` is not specified, we assume default '-' user.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteContextAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteContextAsync(new DeleteContextRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified context.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the context to delete. Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;/contexts/&lt;Context
        /// ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/sessions/&lt;Session
        /// ID&gt;/contexts/&lt;Context ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User
        /// ID&gt;/sessions/&lt;Session ID&gt;/contexts/&lt;Context ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User ID&gt;/sessions/&lt;Session
        /// ID&gt;/contexts/&lt;Context ID&gt;`,
        /// 
        /// If `Location ID` is not specified we assume default 'us' location. If
        /// `Environment ID` is not specified, we assume default 'draft' environment.
        /// If `User ID` is not specified, we assume default '-' user.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteContextAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteContextAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified context.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the context to delete. Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;/contexts/&lt;Context
        /// ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/sessions/&lt;Session
        /// ID&gt;/contexts/&lt;Context ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User
        /// ID&gt;/sessions/&lt;Session ID&gt;/contexts/&lt;Context ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User ID&gt;/sessions/&lt;Session
        /// ID&gt;/contexts/&lt;Context ID&gt;`,
        /// 
        /// If `Location ID` is not specified we assume default 'us' location. If
        /// `Environment ID` is not specified, we assume default 'draft' environment.
        /// If `User ID` is not specified, we assume default '-' user.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteContext(ContextName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteContext(new DeleteContextRequest
            {
                ContextName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified context.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the context to delete. Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;/contexts/&lt;Context
        /// ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/sessions/&lt;Session
        /// ID&gt;/contexts/&lt;Context ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User
        /// ID&gt;/sessions/&lt;Session ID&gt;/contexts/&lt;Context ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User ID&gt;/sessions/&lt;Session
        /// ID&gt;/contexts/&lt;Context ID&gt;`,
        /// 
        /// If `Location ID` is not specified we assume default 'us' location. If
        /// `Environment ID` is not specified, we assume default 'draft' environment.
        /// If `User ID` is not specified, we assume default '-' user.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteContextAsync(ContextName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteContextAsync(new DeleteContextRequest
            {
                ContextName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified context.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the context to delete. Supported formats:
        /// - `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;/contexts/&lt;Context
        /// ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/sessions/&lt;Session
        /// ID&gt;/contexts/&lt;Context ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User
        /// ID&gt;/sessions/&lt;Session ID&gt;/contexts/&lt;Context ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User ID&gt;/sessions/&lt;Session
        /// ID&gt;/contexts/&lt;Context ID&gt;`,
        /// 
        /// If `Location ID` is not specified we assume default 'us' location. If
        /// `Environment ID` is not specified, we assume default 'draft' environment.
        /// If `User ID` is not specified, we assume default '-' user.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteContextAsync(ContextName name, st::CancellationToken cancellationToken) =>
            DeleteContextAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes all active contexts in the specified session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAllContexts(DeleteAllContextsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes all active contexts in the specified session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAllContextsAsync(DeleteAllContextsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes all active contexts in the specified session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAllContextsAsync(DeleteAllContextsRequest request, st::CancellationToken cancellationToken) =>
            DeleteAllContextsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes all active contexts in the specified session.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the session to delete all contexts from. Supported
        /// formats:
        /// - `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/sessions/&lt;Session
        /// ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User
        /// ID&gt;/sessions/&lt;Session ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User ID&gt;/sessions/&lt;Session
        /// ID&gt;`,
        /// 
        /// If `Location ID` is not specified we assume default 'us' location. If
        /// `Environment ID` is not specified we assume default 'draft' environment. If
        /// `User ID` is not specified, we assume default '-' user.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAllContexts(string parent, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAllContexts(new DeleteAllContextsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Deletes all active contexts in the specified session.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the session to delete all contexts from. Supported
        /// formats:
        /// - `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/sessions/&lt;Session
        /// ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User
        /// ID&gt;/sessions/&lt;Session ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User ID&gt;/sessions/&lt;Session
        /// ID&gt;`,
        /// 
        /// If `Location ID` is not specified we assume default 'us' location. If
        /// `Environment ID` is not specified we assume default 'draft' environment. If
        /// `User ID` is not specified, we assume default '-' user.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAllContextsAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAllContextsAsync(new DeleteAllContextsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Deletes all active contexts in the specified session.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the session to delete all contexts from. Supported
        /// formats:
        /// - `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/sessions/&lt;Session
        /// ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User
        /// ID&gt;/sessions/&lt;Session ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User ID&gt;/sessions/&lt;Session
        /// ID&gt;`,
        /// 
        /// If `Location ID` is not specified we assume default 'us' location. If
        /// `Environment ID` is not specified we assume default 'draft' environment. If
        /// `User ID` is not specified, we assume default '-' user.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAllContextsAsync(string parent, st::CancellationToken cancellationToken) =>
            DeleteAllContextsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes all active contexts in the specified session.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the session to delete all contexts from. Supported
        /// formats:
        /// - `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/sessions/&lt;Session
        /// ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User
        /// ID&gt;/sessions/&lt;Session ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User ID&gt;/sessions/&lt;Session
        /// ID&gt;`,
        /// 
        /// If `Location ID` is not specified we assume default 'us' location. If
        /// `Environment ID` is not specified we assume default 'draft' environment. If
        /// `User ID` is not specified, we assume default '-' user.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAllContexts(SessionName parent, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAllContexts(new DeleteAllContextsRequest
            {
                ParentAsSessionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Deletes all active contexts in the specified session.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the session to delete all contexts from. Supported
        /// formats:
        /// - `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/sessions/&lt;Session
        /// ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User
        /// ID&gt;/sessions/&lt;Session ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User ID&gt;/sessions/&lt;Session
        /// ID&gt;`,
        /// 
        /// If `Location ID` is not specified we assume default 'us' location. If
        /// `Environment ID` is not specified we assume default 'draft' environment. If
        /// `User ID` is not specified, we assume default '-' user.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAllContextsAsync(SessionName parent, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAllContextsAsync(new DeleteAllContextsRequest
            {
                ParentAsSessionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Deletes all active contexts in the specified session.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the session to delete all contexts from. Supported
        /// formats:
        /// - `projects/&lt;Project ID&gt;/agent/sessions/&lt;Session ID&gt;,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/sessions/&lt;Session
        /// ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User
        /// ID&gt;/sessions/&lt;Session ID&gt;`,
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/agent/environments/&lt;Environment ID&gt;/users/&lt;User ID&gt;/sessions/&lt;Session
        /// ID&gt;`,
        /// 
        /// If `Location ID` is not specified we assume default 'us' location. If
        /// `Environment ID` is not specified we assume default 'draft' environment. If
        /// `User ID` is not specified, we assume default '-' user.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAllContextsAsync(SessionName parent, st::CancellationToken cancellationToken) =>
            DeleteAllContextsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Contexts client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Contexts][google.cloud.dialogflow.v2beta1.Context].
    /// </remarks>
    public sealed partial class ContextsClientImpl : ContextsClient
    {
        private readonly gaxgrpc::ApiCall<ListContextsRequest, ListContextsResponse> _callListContexts;

        private readonly gaxgrpc::ApiCall<GetContextRequest, Context> _callGetContext;

        private readonly gaxgrpc::ApiCall<CreateContextRequest, Context> _callCreateContext;

        private readonly gaxgrpc::ApiCall<UpdateContextRequest, Context> _callUpdateContext;

        private readonly gaxgrpc::ApiCall<DeleteContextRequest, wkt::Empty> _callDeleteContext;

        private readonly gaxgrpc::ApiCall<DeleteAllContextsRequest, wkt::Empty> _callDeleteAllContexts;

        /// <summary>
        /// Constructs a client wrapper for the Contexts service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ContextsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ContextsClientImpl(Contexts.ContextsClient grpcClient, ContextsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ContextsSettings effectiveSettings = settings ?? ContextsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListContexts = clientHelper.BuildApiCall<ListContextsRequest, ListContextsResponse>("ListContexts", grpcClient.ListContextsAsync, grpcClient.ListContexts, effectiveSettings.ListContextsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListContexts);
            Modify_ListContextsApiCall(ref _callListContexts);
            _callGetContext = clientHelper.BuildApiCall<GetContextRequest, Context>("GetContext", grpcClient.GetContextAsync, grpcClient.GetContext, effectiveSettings.GetContextSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetContext);
            Modify_GetContextApiCall(ref _callGetContext);
            _callCreateContext = clientHelper.BuildApiCall<CreateContextRequest, Context>("CreateContext", grpcClient.CreateContextAsync, grpcClient.CreateContext, effectiveSettings.CreateContextSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateContext);
            Modify_CreateContextApiCall(ref _callCreateContext);
            _callUpdateContext = clientHelper.BuildApiCall<UpdateContextRequest, Context>("UpdateContext", grpcClient.UpdateContextAsync, grpcClient.UpdateContext, effectiveSettings.UpdateContextSettings).WithGoogleRequestParam("context.name", request => request.Context?.Name);
            Modify_ApiCall(ref _callUpdateContext);
            Modify_UpdateContextApiCall(ref _callUpdateContext);
            _callDeleteContext = clientHelper.BuildApiCall<DeleteContextRequest, wkt::Empty>("DeleteContext", grpcClient.DeleteContextAsync, grpcClient.DeleteContext, effectiveSettings.DeleteContextSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteContext);
            Modify_DeleteContextApiCall(ref _callDeleteContext);
            _callDeleteAllContexts = clientHelper.BuildApiCall<DeleteAllContextsRequest, wkt::Empty>("DeleteAllContexts", grpcClient.DeleteAllContextsAsync, grpcClient.DeleteAllContexts, effectiveSettings.DeleteAllContextsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callDeleteAllContexts);
            Modify_DeleteAllContextsApiCall(ref _callDeleteAllContexts);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListContextsApiCall(ref gaxgrpc::ApiCall<ListContextsRequest, ListContextsResponse> call);

        partial void Modify_GetContextApiCall(ref gaxgrpc::ApiCall<GetContextRequest, Context> call);

        partial void Modify_CreateContextApiCall(ref gaxgrpc::ApiCall<CreateContextRequest, Context> call);

        partial void Modify_UpdateContextApiCall(ref gaxgrpc::ApiCall<UpdateContextRequest, Context> call);

        partial void Modify_DeleteContextApiCall(ref gaxgrpc::ApiCall<DeleteContextRequest, wkt::Empty> call);

        partial void Modify_DeleteAllContextsApiCall(ref gaxgrpc::ApiCall<DeleteAllContextsRequest, wkt::Empty> call);

        partial void OnConstruction(Contexts.ContextsClient grpcClient, ContextsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Contexts client</summary>
        public override Contexts.ContextsClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListContextsRequest(ref ListContextsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetContextRequest(ref GetContextRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateContextRequest(ref CreateContextRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateContextRequest(ref UpdateContextRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteContextRequest(ref DeleteContextRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAllContextsRequest(ref DeleteAllContextsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the list of all contexts in the specified session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Context"/> resources.</returns>
        public override gax::PagedEnumerable<ListContextsResponse, Context> ListContexts(ListContextsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListContextsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListContextsRequest, ListContextsResponse, Context>(_callListContexts, request, callSettings);
        }

        /// <summary>
        /// Returns the list of all contexts in the specified session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Context"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListContextsResponse, Context> ListContextsAsync(ListContextsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListContextsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListContextsRequest, ListContextsResponse, Context>(_callListContexts, request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Context GetContext(GetContextRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetContextRequest(ref request, ref callSettings);
            return _callGetContext.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Context> GetContextAsync(GetContextRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetContextRequest(ref request, ref callSettings);
            return _callGetContext.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a context.
        /// 
        /// If the specified context already exists, overrides the context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Context CreateContext(CreateContextRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateContextRequest(ref request, ref callSettings);
            return _callCreateContext.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a context.
        /// 
        /// If the specified context already exists, overrides the context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Context> CreateContextAsync(CreateContextRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateContextRequest(ref request, ref callSettings);
            return _callCreateContext.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Context UpdateContext(UpdateContextRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateContextRequest(ref request, ref callSettings);
            return _callUpdateContext.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Context> UpdateContextAsync(UpdateContextRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateContextRequest(ref request, ref callSettings);
            return _callUpdateContext.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteContext(DeleteContextRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteContextRequest(ref request, ref callSettings);
            _callDeleteContext.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteContextAsync(DeleteContextRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteContextRequest(ref request, ref callSettings);
            return _callDeleteContext.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes all active contexts in the specified session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteAllContexts(DeleteAllContextsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAllContextsRequest(ref request, ref callSettings);
            _callDeleteAllContexts.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes all active contexts in the specified session.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteAllContextsAsync(DeleteAllContextsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAllContextsRequest(ref request, ref callSettings);
            return _callDeleteAllContexts.Async(request, callSettings);
        }
    }

    public partial class ListContextsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListContextsResponse : gaxgrpc::IPageResponse<Context>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Context> GetEnumerator() => Contexts.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Contexts
    {
        public partial class ContextsClient
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
