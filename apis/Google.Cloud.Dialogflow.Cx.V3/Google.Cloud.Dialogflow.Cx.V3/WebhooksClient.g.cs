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

namespace Google.Cloud.Dialogflow.Cx.V3
{
    /// <summary>Settings for <see cref="WebhooksClient"/> instances.</summary>
    public sealed partial class WebhooksSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="WebhooksSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="WebhooksSettings"/>.</returns>
        public static WebhooksSettings GetDefault() => new WebhooksSettings();

        /// <summary>Constructs a new <see cref="WebhooksSettings"/> object with default settings.</summary>
        public WebhooksSettings()
        {
        }

        private WebhooksSettings(WebhooksSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListWebhooksSettings = existing.ListWebhooksSettings;
            GetWebhookSettings = existing.GetWebhookSettings;
            CreateWebhookSettings = existing.CreateWebhookSettings;
            UpdateWebhookSettings = existing.UpdateWebhookSettings;
            DeleteWebhookSettings = existing.DeleteWebhookSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(WebhooksSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>WebhooksClient.ListWebhooks</c>
        ///  and <c>WebhooksClient.ListWebhooksAsync</c>.
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
        public gaxgrpc::CallSettings ListWebhooksSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>WebhooksClient.GetWebhook</c>
        ///  and <c>WebhooksClient.GetWebhookAsync</c>.
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
        public gaxgrpc::CallSettings GetWebhookSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WebhooksClient.CreateWebhook</c> and <c>WebhooksClient.CreateWebhookAsync</c>.
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
        public gaxgrpc::CallSettings CreateWebhookSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WebhooksClient.UpdateWebhook</c> and <c>WebhooksClient.UpdateWebhookAsync</c>.
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
        public gaxgrpc::CallSettings UpdateWebhookSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WebhooksClient.DeleteWebhook</c> and <c>WebhooksClient.DeleteWebhookAsync</c>.
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
        public gaxgrpc::CallSettings DeleteWebhookSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="WebhooksSettings"/> object.</returns>
        public WebhooksSettings Clone() => new WebhooksSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="WebhooksClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class WebhooksClientBuilder : gaxgrpc::ClientBuilderBase<WebhooksClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public WebhooksSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public WebhooksClientBuilder() : base(WebhooksClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref WebhooksClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<WebhooksClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override WebhooksClient Build()
        {
            WebhooksClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<WebhooksClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<WebhooksClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private WebhooksClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return WebhooksClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<WebhooksClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return WebhooksClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => WebhooksClient.ChannelPool;
    }

    /// <summary>Webhooks client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Webhooks][google.cloud.dialogflow.cx.v3.Webhook].
    /// </remarks>
    public abstract partial class WebhooksClient
    {
        /// <summary>
        /// The default endpoint for the Webhooks service, which is a host of "dialogflow.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dialogflow.googleapis.com:443";

        /// <summary>The default Webhooks scopes.</summary>
        /// <remarks>
        /// The default Webhooks scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Webhooks.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="WebhooksClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="WebhooksClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="WebhooksClient"/>.</returns>
        public static stt::Task<WebhooksClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new WebhooksClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="WebhooksClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="WebhooksClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="WebhooksClient"/>.</returns>
        public static WebhooksClient Create() => new WebhooksClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="WebhooksClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="WebhooksSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="WebhooksClient"/>.</returns>
        internal static WebhooksClient Create(grpccore::CallInvoker callInvoker, WebhooksSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Webhooks.WebhooksClient grpcClient = new Webhooks.WebhooksClient(callInvoker);
            return new WebhooksClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Webhooks client</summary>
        public virtual Webhooks.WebhooksClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all webhooks in the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Webhook"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWebhooksResponse, Webhook> ListWebhooks(ListWebhooksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all webhooks in the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Webhook"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWebhooksResponse, Webhook> ListWebhooksAsync(ListWebhooksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all webhooks in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all webhooks for.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="Webhook"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWebhooksResponse, Webhook> ListWebhooks(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWebhooksRequest request = new ListWebhooksRequest
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
            return ListWebhooks(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all webhooks in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all webhooks for.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Webhook"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWebhooksResponse, Webhook> ListWebhooksAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWebhooksRequest request = new ListWebhooksRequest
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
            return ListWebhooksAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all webhooks in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all webhooks for.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="Webhook"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWebhooksResponse, Webhook> ListWebhooks(AgentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWebhooksRequest request = new ListWebhooksRequest
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
            return ListWebhooks(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all webhooks in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to list all webhooks for.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Webhook"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWebhooksResponse, Webhook> ListWebhooksAsync(AgentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWebhooksRequest request = new ListWebhooksRequest
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
            return ListWebhooksAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified webhook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Webhook GetWebhook(GetWebhookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified webhook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Webhook> GetWebhookAsync(GetWebhookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified webhook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Webhook> GetWebhookAsync(GetWebhookRequest request, st::CancellationToken cancellationToken) =>
            GetWebhookAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified webhook.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the webhook.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/webhooks/&lt;WebhookID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Webhook GetWebhook(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetWebhook(new GetWebhookRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified webhook.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the webhook.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/webhooks/&lt;WebhookID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Webhook> GetWebhookAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetWebhookAsync(new GetWebhookRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified webhook.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the webhook.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/webhooks/&lt;WebhookID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Webhook> GetWebhookAsync(string name, st::CancellationToken cancellationToken) =>
            GetWebhookAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified webhook.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the webhook.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/webhooks/&lt;WebhookID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Webhook GetWebhook(WebhookName name, gaxgrpc::CallSettings callSettings = null) =>
            GetWebhook(new GetWebhookRequest
            {
                WebhookName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified webhook.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the webhook.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/webhooks/&lt;WebhookID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Webhook> GetWebhookAsync(WebhookName name, gaxgrpc::CallSettings callSettings = null) =>
            GetWebhookAsync(new GetWebhookRequest
            {
                WebhookName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified webhook.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the webhook.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/webhooks/&lt;WebhookID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Webhook> GetWebhookAsync(WebhookName name, st::CancellationToken cancellationToken) =>
            GetWebhookAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a webhook in the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Webhook CreateWebhook(CreateWebhookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a webhook in the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Webhook> CreateWebhookAsync(CreateWebhookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a webhook in the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Webhook> CreateWebhookAsync(CreateWebhookRequest request, st::CancellationToken cancellationToken) =>
            CreateWebhookAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a webhook in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a webhook for.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
        /// </param>
        /// <param name="webhook">
        /// Required. The webhook to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Webhook CreateWebhook(string parent, Webhook webhook, gaxgrpc::CallSettings callSettings = null) =>
            CreateWebhook(new CreateWebhookRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Webhook = gax::GaxPreconditions.CheckNotNull(webhook, nameof(webhook)),
            }, callSettings);

        /// <summary>
        /// Creates a webhook in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a webhook for.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
        /// </param>
        /// <param name="webhook">
        /// Required. The webhook to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Webhook> CreateWebhookAsync(string parent, Webhook webhook, gaxgrpc::CallSettings callSettings = null) =>
            CreateWebhookAsync(new CreateWebhookRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Webhook = gax::GaxPreconditions.CheckNotNull(webhook, nameof(webhook)),
            }, callSettings);

        /// <summary>
        /// Creates a webhook in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a webhook for.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
        /// </param>
        /// <param name="webhook">
        /// Required. The webhook to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Webhook> CreateWebhookAsync(string parent, Webhook webhook, st::CancellationToken cancellationToken) =>
            CreateWebhookAsync(parent, webhook, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a webhook in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a webhook for.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
        /// </param>
        /// <param name="webhook">
        /// Required. The webhook to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Webhook CreateWebhook(AgentName parent, Webhook webhook, gaxgrpc::CallSettings callSettings = null) =>
            CreateWebhook(new CreateWebhookRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Webhook = gax::GaxPreconditions.CheckNotNull(webhook, nameof(webhook)),
            }, callSettings);

        /// <summary>
        /// Creates a webhook in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a webhook for.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
        /// </param>
        /// <param name="webhook">
        /// Required. The webhook to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Webhook> CreateWebhookAsync(AgentName parent, Webhook webhook, gaxgrpc::CallSettings callSettings = null) =>
            CreateWebhookAsync(new CreateWebhookRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Webhook = gax::GaxPreconditions.CheckNotNull(webhook, nameof(webhook)),
            }, callSettings);

        /// <summary>
        /// Creates a webhook in the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent to create a webhook for.
        /// Format: `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`.
        /// </param>
        /// <param name="webhook">
        /// Required. The webhook to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Webhook> CreateWebhookAsync(AgentName parent, Webhook webhook, st::CancellationToken cancellationToken) =>
            CreateWebhookAsync(parent, webhook, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified webhook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Webhook UpdateWebhook(UpdateWebhookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified webhook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Webhook> UpdateWebhookAsync(UpdateWebhookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified webhook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Webhook> UpdateWebhookAsync(UpdateWebhookRequest request, st::CancellationToken cancellationToken) =>
            UpdateWebhookAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified webhook.
        /// </summary>
        /// <param name="webhook">
        /// Required. The webhook to update.
        /// </param>
        /// <param name="updateMask">
        /// The mask to control which fields get updated. If the mask is not present,
        /// all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Webhook UpdateWebhook(Webhook webhook, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateWebhook(new UpdateWebhookRequest
            {
                Webhook = gax::GaxPreconditions.CheckNotNull(webhook, nameof(webhook)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified webhook.
        /// </summary>
        /// <param name="webhook">
        /// Required. The webhook to update.
        /// </param>
        /// <param name="updateMask">
        /// The mask to control which fields get updated. If the mask is not present,
        /// all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Webhook> UpdateWebhookAsync(Webhook webhook, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateWebhookAsync(new UpdateWebhookRequest
            {
                Webhook = gax::GaxPreconditions.CheckNotNull(webhook, nameof(webhook)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified webhook.
        /// </summary>
        /// <param name="webhook">
        /// Required. The webhook to update.
        /// </param>
        /// <param name="updateMask">
        /// The mask to control which fields get updated. If the mask is not present,
        /// all fields will be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Webhook> UpdateWebhookAsync(Webhook webhook, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateWebhookAsync(webhook, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified webhook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteWebhook(DeleteWebhookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified webhook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWebhookAsync(DeleteWebhookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified webhook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWebhookAsync(DeleteWebhookRequest request, st::CancellationToken cancellationToken) =>
            DeleteWebhookAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified webhook.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the webhook to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/webhooks/&lt;WebhookID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteWebhook(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWebhook(new DeleteWebhookRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified webhook.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the webhook to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/webhooks/&lt;WebhookID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWebhookAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWebhookAsync(new DeleteWebhookRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified webhook.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the webhook to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/webhooks/&lt;WebhookID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWebhookAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteWebhookAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified webhook.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the webhook to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/webhooks/&lt;WebhookID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteWebhook(WebhookName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWebhook(new DeleteWebhookRequest
            {
                WebhookName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified webhook.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the webhook to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/webhooks/&lt;WebhookID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWebhookAsync(WebhookName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWebhookAsync(new DeleteWebhookRequest
            {
                WebhookName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified webhook.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the webhook to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/webhooks/&lt;WebhookID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteWebhookAsync(WebhookName name, st::CancellationToken cancellationToken) =>
            DeleteWebhookAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Webhooks client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Webhooks][google.cloud.dialogflow.cx.v3.Webhook].
    /// </remarks>
    public sealed partial class WebhooksClientImpl : WebhooksClient
    {
        private readonly gaxgrpc::ApiCall<ListWebhooksRequest, ListWebhooksResponse> _callListWebhooks;

        private readonly gaxgrpc::ApiCall<GetWebhookRequest, Webhook> _callGetWebhook;

        private readonly gaxgrpc::ApiCall<CreateWebhookRequest, Webhook> _callCreateWebhook;

        private readonly gaxgrpc::ApiCall<UpdateWebhookRequest, Webhook> _callUpdateWebhook;

        private readonly gaxgrpc::ApiCall<DeleteWebhookRequest, wkt::Empty> _callDeleteWebhook;

        /// <summary>
        /// Constructs a client wrapper for the Webhooks service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="WebhooksSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public WebhooksClientImpl(Webhooks.WebhooksClient grpcClient, WebhooksSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            WebhooksSettings effectiveSettings = settings ?? WebhooksSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListWebhooks = clientHelper.BuildApiCall<ListWebhooksRequest, ListWebhooksResponse>("ListWebhooks", grpcClient.ListWebhooksAsync, grpcClient.ListWebhooks, effectiveSettings.ListWebhooksSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListWebhooks);
            Modify_ListWebhooksApiCall(ref _callListWebhooks);
            _callGetWebhook = clientHelper.BuildApiCall<GetWebhookRequest, Webhook>("GetWebhook", grpcClient.GetWebhookAsync, grpcClient.GetWebhook, effectiveSettings.GetWebhookSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetWebhook);
            Modify_GetWebhookApiCall(ref _callGetWebhook);
            _callCreateWebhook = clientHelper.BuildApiCall<CreateWebhookRequest, Webhook>("CreateWebhook", grpcClient.CreateWebhookAsync, grpcClient.CreateWebhook, effectiveSettings.CreateWebhookSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateWebhook);
            Modify_CreateWebhookApiCall(ref _callCreateWebhook);
            _callUpdateWebhook = clientHelper.BuildApiCall<UpdateWebhookRequest, Webhook>("UpdateWebhook", grpcClient.UpdateWebhookAsync, grpcClient.UpdateWebhook, effectiveSettings.UpdateWebhookSettings).WithGoogleRequestParam("webhook.name", request => request.Webhook?.Name);
            Modify_ApiCall(ref _callUpdateWebhook);
            Modify_UpdateWebhookApiCall(ref _callUpdateWebhook);
            _callDeleteWebhook = clientHelper.BuildApiCall<DeleteWebhookRequest, wkt::Empty>("DeleteWebhook", grpcClient.DeleteWebhookAsync, grpcClient.DeleteWebhook, effectiveSettings.DeleteWebhookSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteWebhook);
            Modify_DeleteWebhookApiCall(ref _callDeleteWebhook);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListWebhooksApiCall(ref gaxgrpc::ApiCall<ListWebhooksRequest, ListWebhooksResponse> call);

        partial void Modify_GetWebhookApiCall(ref gaxgrpc::ApiCall<GetWebhookRequest, Webhook> call);

        partial void Modify_CreateWebhookApiCall(ref gaxgrpc::ApiCall<CreateWebhookRequest, Webhook> call);

        partial void Modify_UpdateWebhookApiCall(ref gaxgrpc::ApiCall<UpdateWebhookRequest, Webhook> call);

        partial void Modify_DeleteWebhookApiCall(ref gaxgrpc::ApiCall<DeleteWebhookRequest, wkt::Empty> call);

        partial void OnConstruction(Webhooks.WebhooksClient grpcClient, WebhooksSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Webhooks client</summary>
        public override Webhooks.WebhooksClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListWebhooksRequest(ref ListWebhooksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetWebhookRequest(ref GetWebhookRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateWebhookRequest(ref CreateWebhookRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateWebhookRequest(ref UpdateWebhookRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteWebhookRequest(ref DeleteWebhookRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the list of all webhooks in the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Webhook"/> resources.</returns>
        public override gax::PagedEnumerable<ListWebhooksResponse, Webhook> ListWebhooks(ListWebhooksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListWebhooksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListWebhooksRequest, ListWebhooksResponse, Webhook>(_callListWebhooks, request, callSettings);
        }

        /// <summary>
        /// Returns the list of all webhooks in the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Webhook"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListWebhooksResponse, Webhook> ListWebhooksAsync(ListWebhooksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListWebhooksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListWebhooksRequest, ListWebhooksResponse, Webhook>(_callListWebhooks, request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified webhook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Webhook GetWebhook(GetWebhookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWebhookRequest(ref request, ref callSettings);
            return _callGetWebhook.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified webhook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Webhook> GetWebhookAsync(GetWebhookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWebhookRequest(ref request, ref callSettings);
            return _callGetWebhook.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a webhook in the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Webhook CreateWebhook(CreateWebhookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateWebhookRequest(ref request, ref callSettings);
            return _callCreateWebhook.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a webhook in the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Webhook> CreateWebhookAsync(CreateWebhookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateWebhookRequest(ref request, ref callSettings);
            return _callCreateWebhook.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified webhook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Webhook UpdateWebhook(UpdateWebhookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateWebhookRequest(ref request, ref callSettings);
            return _callUpdateWebhook.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified webhook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Webhook> UpdateWebhookAsync(UpdateWebhookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateWebhookRequest(ref request, ref callSettings);
            return _callUpdateWebhook.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified webhook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteWebhook(DeleteWebhookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteWebhookRequest(ref request, ref callSettings);
            _callDeleteWebhook.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified webhook.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteWebhookAsync(DeleteWebhookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteWebhookRequest(ref request, ref callSettings);
            return _callDeleteWebhook.Async(request, callSettings);
        }
    }

    public partial class ListWebhooksRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListWebhooksResponse : gaxgrpc::IPageResponse<Webhook>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Webhook> GetEnumerator() => Webhooks.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Webhooks
    {
        public partial class WebhooksClient
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
