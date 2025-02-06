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

namespace Google.Cloud.Dialogflow.V2
{
    /// <summary>Settings for <see cref="EnvironmentsClient"/> instances.</summary>
    public sealed partial class EnvironmentsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="EnvironmentsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="EnvironmentsSettings"/>.</returns>
        public static EnvironmentsSettings GetDefault() => new EnvironmentsSettings();

        /// <summary>Constructs a new <see cref="EnvironmentsSettings"/> object with default settings.</summary>
        public EnvironmentsSettings()
        {
        }

        private EnvironmentsSettings(EnvironmentsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListEnvironmentsSettings = existing.ListEnvironmentsSettings;
            GetEnvironmentSettings = existing.GetEnvironmentSettings;
            CreateEnvironmentSettings = existing.CreateEnvironmentSettings;
            UpdateEnvironmentSettings = existing.UpdateEnvironmentSettings;
            DeleteEnvironmentSettings = existing.DeleteEnvironmentSettings;
            GetEnvironmentHistorySettings = existing.GetEnvironmentHistorySettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(EnvironmentsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.ListEnvironments</c> and <c>EnvironmentsClient.ListEnvironmentsAsync</c>.
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
        public gaxgrpc::CallSettings ListEnvironmentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.GetEnvironment</c> and <c>EnvironmentsClient.GetEnvironmentAsync</c>.
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
        public gaxgrpc::CallSettings GetEnvironmentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.CreateEnvironment</c> and <c>EnvironmentsClient.CreateEnvironmentAsync</c>.
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
        public gaxgrpc::CallSettings CreateEnvironmentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.UpdateEnvironment</c> and <c>EnvironmentsClient.UpdateEnvironmentAsync</c>.
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
        public gaxgrpc::CallSettings UpdateEnvironmentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.DeleteEnvironment</c> and <c>EnvironmentsClient.DeleteEnvironmentAsync</c>.
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
        public gaxgrpc::CallSettings DeleteEnvironmentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnvironmentsClient.GetEnvironmentHistory</c> and <c>EnvironmentsClient.GetEnvironmentHistoryAsync</c>.
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
        public gaxgrpc::CallSettings GetEnvironmentHistorySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="EnvironmentsSettings"/> object.</returns>
        public EnvironmentsSettings Clone() => new EnvironmentsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="EnvironmentsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class EnvironmentsClientBuilder : gaxgrpc::ClientBuilderBase<EnvironmentsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public EnvironmentsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public EnvironmentsClientBuilder() : base(EnvironmentsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref EnvironmentsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<EnvironmentsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override EnvironmentsClient Build()
        {
            EnvironmentsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<EnvironmentsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<EnvironmentsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private EnvironmentsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return EnvironmentsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<EnvironmentsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return EnvironmentsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => EnvironmentsClient.ChannelPool;
    }

    /// <summary>Environments client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Environments][google.cloud.dialogflow.v2.Environment].
    /// </remarks>
    public abstract partial class EnvironmentsClient
    {
        /// <summary>
        /// The default endpoint for the Environments service, which is a host of "dialogflow.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dialogflow.googleapis.com:443";

        /// <summary>The default Environments scopes.</summary>
        /// <remarks>
        /// The default Environments scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Environments.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="EnvironmentsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="EnvironmentsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="EnvironmentsClient"/>.</returns>
        public static stt::Task<EnvironmentsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new EnvironmentsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="EnvironmentsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="EnvironmentsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="EnvironmentsClient"/>.</returns>
        public static EnvironmentsClient Create() => new EnvironmentsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="EnvironmentsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="EnvironmentsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="EnvironmentsClient"/>.</returns>
        internal static EnvironmentsClient Create(grpccore::CallInvoker callInvoker, EnvironmentsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Environments.EnvironmentsClient grpcClient = new Environments.EnvironmentsClient(callInvoker);
            return new EnvironmentsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Environments client</summary>
        public virtual Environments.EnvironmentsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all non-default environments of the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Environment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEnvironmentsResponse, Environment> ListEnvironments(ListEnvironmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all non-default environments of the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Environment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEnvironmentsResponse, Environment> ListEnvironmentsAsync(ListEnvironmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all non-default environments of the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all environments from.
        /// Format:
        /// 
        /// - `projects/&lt;Project ID&gt;/agent`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent`
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
        /// <returns>A pageable sequence of <see cref="Environment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEnvironmentsResponse, Environment> ListEnvironments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEnvironmentsRequest request = new ListEnvironmentsRequest
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
            return ListEnvironments(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all non-default environments of the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all environments from.
        /// Format:
        /// 
        /// - `projects/&lt;Project ID&gt;/agent`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Environment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEnvironmentsResponse, Environment> ListEnvironmentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEnvironmentsRequest request = new ListEnvironmentsRequest
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
            return ListEnvironmentsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all non-default environments of the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all environments from.
        /// Format:
        /// 
        /// - `projects/&lt;Project ID&gt;/agent`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent`
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
        /// <returns>A pageable sequence of <see cref="Environment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEnvironmentsResponse, Environment> ListEnvironments(AgentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEnvironmentsRequest request = new ListEnvironmentsRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEnvironments(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all non-default environments of the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all environments from.
        /// Format:
        /// 
        /// - `projects/&lt;Project ID&gt;/agent`
        /// - `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Environment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEnvironmentsResponse, Environment> ListEnvironmentsAsync(AgentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEnvironmentsRequest request = new ListEnvironmentsRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEnvironmentsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified agent environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Environment GetEnvironment(GetEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified agent environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Environment> GetEnvironmentAsync(GetEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified agent environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Environment> GetEnvironmentAsync(GetEnvironmentRequest request, st::CancellationToken cancellationToken) =>
            GetEnvironmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an agent environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Environment CreateEnvironment(CreateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an agent environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Environment> CreateEnvironmentAsync(CreateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an agent environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Environment> CreateEnvironmentAsync(CreateEnvironmentRequest request, st::CancellationToken cancellationToken) =>
            CreateEnvironmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified agent environment.
        /// 
        /// This method allows you to deploy new agent versions into the environment.
        /// When an environment is pointed to a new agent version by setting
        /// `environment.agent_version`, the environment is temporarily set to the
        /// `LOADING` state. During that time, the environment continues serving the
        /// previous version of the agent. After the new agent version is done loading,
        /// the environment is set back to the `RUNNING` state.
        /// You can use "-" as Environment ID in environment name to update an agent
        /// version in the default environment. WARNING: this will negate all recent
        /// changes to the draft agent and can't be undone. You may want to save the
        /// draft agent to a version before calling this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Environment UpdateEnvironment(UpdateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified agent environment.
        /// 
        /// This method allows you to deploy new agent versions into the environment.
        /// When an environment is pointed to a new agent version by setting
        /// `environment.agent_version`, the environment is temporarily set to the
        /// `LOADING` state. During that time, the environment continues serving the
        /// previous version of the agent. After the new agent version is done loading,
        /// the environment is set back to the `RUNNING` state.
        /// You can use "-" as Environment ID in environment name to update an agent
        /// version in the default environment. WARNING: this will negate all recent
        /// changes to the draft agent and can't be undone. You may want to save the
        /// draft agent to a version before calling this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Environment> UpdateEnvironmentAsync(UpdateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified agent environment.
        /// 
        /// This method allows you to deploy new agent versions into the environment.
        /// When an environment is pointed to a new agent version by setting
        /// `environment.agent_version`, the environment is temporarily set to the
        /// `LOADING` state. During that time, the environment continues serving the
        /// previous version of the agent. After the new agent version is done loading,
        /// the environment is set back to the `RUNNING` state.
        /// You can use "-" as Environment ID in environment name to update an agent
        /// version in the default environment. WARNING: this will negate all recent
        /// changes to the draft agent and can't be undone. You may want to save the
        /// draft agent to a version before calling this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Environment> UpdateEnvironmentAsync(UpdateEnvironmentRequest request, st::CancellationToken cancellationToken) =>
            UpdateEnvironmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified agent environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEnvironment(DeleteEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified agent environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEnvironmentAsync(DeleteEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified agent environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEnvironmentAsync(DeleteEnvironmentRequest request, st::CancellationToken cancellationToken) =>
            DeleteEnvironmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the history of the specified environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EnvironmentHistory.Types.Entry"/> resources.</returns>
        public virtual gax::PagedEnumerable<EnvironmentHistory, EnvironmentHistory.Types.Entry> GetEnvironmentHistory(GetEnvironmentHistoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the history of the specified environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="EnvironmentHistory.Types.Entry"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<EnvironmentHistory, EnvironmentHistory.Types.Entry> GetEnvironmentHistoryAsync(GetEnvironmentHistoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>Environments client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Environments][google.cloud.dialogflow.v2.Environment].
    /// </remarks>
    public sealed partial class EnvironmentsClientImpl : EnvironmentsClient
    {
        private readonly gaxgrpc::ApiCall<ListEnvironmentsRequest, ListEnvironmentsResponse> _callListEnvironments;

        private readonly gaxgrpc::ApiCall<GetEnvironmentRequest, Environment> _callGetEnvironment;

        private readonly gaxgrpc::ApiCall<CreateEnvironmentRequest, Environment> _callCreateEnvironment;

        private readonly gaxgrpc::ApiCall<UpdateEnvironmentRequest, Environment> _callUpdateEnvironment;

        private readonly gaxgrpc::ApiCall<DeleteEnvironmentRequest, wkt::Empty> _callDeleteEnvironment;

        private readonly gaxgrpc::ApiCall<GetEnvironmentHistoryRequest, EnvironmentHistory> _callGetEnvironmentHistory;

        /// <summary>
        /// Constructs a client wrapper for the Environments service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="EnvironmentsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public EnvironmentsClientImpl(Environments.EnvironmentsClient grpcClient, EnvironmentsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            EnvironmentsSettings effectiveSettings = settings ?? EnvironmentsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListEnvironments = clientHelper.BuildApiCall<ListEnvironmentsRequest, ListEnvironmentsResponse>("ListEnvironments", grpcClient.ListEnvironmentsAsync, grpcClient.ListEnvironments, effectiveSettings.ListEnvironmentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEnvironments);
            Modify_ListEnvironmentsApiCall(ref _callListEnvironments);
            _callGetEnvironment = clientHelper.BuildApiCall<GetEnvironmentRequest, Environment>("GetEnvironment", grpcClient.GetEnvironmentAsync, grpcClient.GetEnvironment, effectiveSettings.GetEnvironmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEnvironment);
            Modify_GetEnvironmentApiCall(ref _callGetEnvironment);
            _callCreateEnvironment = clientHelper.BuildApiCall<CreateEnvironmentRequest, Environment>("CreateEnvironment", grpcClient.CreateEnvironmentAsync, grpcClient.CreateEnvironment, effectiveSettings.CreateEnvironmentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateEnvironment);
            Modify_CreateEnvironmentApiCall(ref _callCreateEnvironment);
            _callUpdateEnvironment = clientHelper.BuildApiCall<UpdateEnvironmentRequest, Environment>("UpdateEnvironment", grpcClient.UpdateEnvironmentAsync, grpcClient.UpdateEnvironment, effectiveSettings.UpdateEnvironmentSettings).WithGoogleRequestParam("environment.name", request => request.Environment?.Name);
            Modify_ApiCall(ref _callUpdateEnvironment);
            Modify_UpdateEnvironmentApiCall(ref _callUpdateEnvironment);
            _callDeleteEnvironment = clientHelper.BuildApiCall<DeleteEnvironmentRequest, wkt::Empty>("DeleteEnvironment", grpcClient.DeleteEnvironmentAsync, grpcClient.DeleteEnvironment, effectiveSettings.DeleteEnvironmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteEnvironment);
            Modify_DeleteEnvironmentApiCall(ref _callDeleteEnvironment);
            _callGetEnvironmentHistory = clientHelper.BuildApiCall<GetEnvironmentHistoryRequest, EnvironmentHistory>("GetEnvironmentHistory", grpcClient.GetEnvironmentHistoryAsync, grpcClient.GetEnvironmentHistory, effectiveSettings.GetEnvironmentHistorySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callGetEnvironmentHistory);
            Modify_GetEnvironmentHistoryApiCall(ref _callGetEnvironmentHistory);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListEnvironmentsApiCall(ref gaxgrpc::ApiCall<ListEnvironmentsRequest, ListEnvironmentsResponse> call);

        partial void Modify_GetEnvironmentApiCall(ref gaxgrpc::ApiCall<GetEnvironmentRequest, Environment> call);

        partial void Modify_CreateEnvironmentApiCall(ref gaxgrpc::ApiCall<CreateEnvironmentRequest, Environment> call);

        partial void Modify_UpdateEnvironmentApiCall(ref gaxgrpc::ApiCall<UpdateEnvironmentRequest, Environment> call);

        partial void Modify_DeleteEnvironmentApiCall(ref gaxgrpc::ApiCall<DeleteEnvironmentRequest, wkt::Empty> call);

        partial void Modify_GetEnvironmentHistoryApiCall(ref gaxgrpc::ApiCall<GetEnvironmentHistoryRequest, EnvironmentHistory> call);

        partial void OnConstruction(Environments.EnvironmentsClient grpcClient, EnvironmentsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Environments client</summary>
        public override Environments.EnvironmentsClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListEnvironmentsRequest(ref ListEnvironmentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEnvironmentRequest(ref GetEnvironmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateEnvironmentRequest(ref CreateEnvironmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateEnvironmentRequest(ref UpdateEnvironmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteEnvironmentRequest(ref DeleteEnvironmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEnvironmentHistoryRequest(ref GetEnvironmentHistoryRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the list of all non-default environments of the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Environment"/> resources.</returns>
        public override gax::PagedEnumerable<ListEnvironmentsResponse, Environment> ListEnvironments(ListEnvironmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEnvironmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEnvironmentsRequest, ListEnvironmentsResponse, Environment>(_callListEnvironments, request, callSettings);
        }

        /// <summary>
        /// Returns the list of all non-default environments of the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Environment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEnvironmentsResponse, Environment> ListEnvironmentsAsync(ListEnvironmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEnvironmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEnvironmentsRequest, ListEnvironmentsResponse, Environment>(_callListEnvironments, request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified agent environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Environment GetEnvironment(GetEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEnvironmentRequest(ref request, ref callSettings);
            return _callGetEnvironment.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified agent environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Environment> GetEnvironmentAsync(GetEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEnvironmentRequest(ref request, ref callSettings);
            return _callGetEnvironment.Async(request, callSettings);
        }

        /// <summary>
        /// Creates an agent environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Environment CreateEnvironment(CreateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEnvironmentRequest(ref request, ref callSettings);
            return _callCreateEnvironment.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an agent environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Environment> CreateEnvironmentAsync(CreateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEnvironmentRequest(ref request, ref callSettings);
            return _callCreateEnvironment.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified agent environment.
        /// 
        /// This method allows you to deploy new agent versions into the environment.
        /// When an environment is pointed to a new agent version by setting
        /// `environment.agent_version`, the environment is temporarily set to the
        /// `LOADING` state. During that time, the environment continues serving the
        /// previous version of the agent. After the new agent version is done loading,
        /// the environment is set back to the `RUNNING` state.
        /// You can use "-" as Environment ID in environment name to update an agent
        /// version in the default environment. WARNING: this will negate all recent
        /// changes to the draft agent and can't be undone. You may want to save the
        /// draft agent to a version before calling this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Environment UpdateEnvironment(UpdateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEnvironmentRequest(ref request, ref callSettings);
            return _callUpdateEnvironment.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified agent environment.
        /// 
        /// This method allows you to deploy new agent versions into the environment.
        /// When an environment is pointed to a new agent version by setting
        /// `environment.agent_version`, the environment is temporarily set to the
        /// `LOADING` state. During that time, the environment continues serving the
        /// previous version of the agent. After the new agent version is done loading,
        /// the environment is set back to the `RUNNING` state.
        /// You can use "-" as Environment ID in environment name to update an agent
        /// version in the default environment. WARNING: this will negate all recent
        /// changes to the draft agent and can't be undone. You may want to save the
        /// draft agent to a version before calling this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Environment> UpdateEnvironmentAsync(UpdateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEnvironmentRequest(ref request, ref callSettings);
            return _callUpdateEnvironment.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified agent environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteEnvironment(DeleteEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEnvironmentRequest(ref request, ref callSettings);
            _callDeleteEnvironment.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified agent environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteEnvironmentAsync(DeleteEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEnvironmentRequest(ref request, ref callSettings);
            return _callDeleteEnvironment.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the history of the specified environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EnvironmentHistory.Types.Entry"/> resources.</returns>
        public override gax::PagedEnumerable<EnvironmentHistory, EnvironmentHistory.Types.Entry> GetEnvironmentHistory(GetEnvironmentHistoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEnvironmentHistoryRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<GetEnvironmentHistoryRequest, EnvironmentHistory, EnvironmentHistory.Types.Entry>(_callGetEnvironmentHistory, request, callSettings);
        }

        /// <summary>
        /// Gets the history of the specified environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="EnvironmentHistory.Types.Entry"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<EnvironmentHistory, EnvironmentHistory.Types.Entry> GetEnvironmentHistoryAsync(GetEnvironmentHistoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEnvironmentHistoryRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<GetEnvironmentHistoryRequest, EnvironmentHistory, EnvironmentHistory.Types.Entry>(_callGetEnvironmentHistory, request, callSettings);
        }
    }

    public partial class ListEnvironmentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class GetEnvironmentHistoryRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEnvironmentsResponse : gaxgrpc::IPageResponse<Environment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Environment> GetEnumerator() => Environments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class EnvironmentHistory : gaxgrpc::IPageResponse<EnvironmentHistory.Types.Entry>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Types.Entry> GetEnumerator() => Entries.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Environments
    {
        public partial class EnvironmentsClient
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
