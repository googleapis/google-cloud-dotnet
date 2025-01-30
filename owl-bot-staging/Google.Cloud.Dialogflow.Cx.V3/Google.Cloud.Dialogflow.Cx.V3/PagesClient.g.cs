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

namespace Google.Cloud.Dialogflow.Cx.V3
{
    /// <summary>Settings for <see cref="PagesClient"/> instances.</summary>
    public sealed partial class PagesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PagesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PagesSettings"/>.</returns>
        public static PagesSettings GetDefault() => new PagesSettings();

        /// <summary>Constructs a new <see cref="PagesSettings"/> object with default settings.</summary>
        public PagesSettings()
        {
        }

        private PagesSettings(PagesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListPagesSettings = existing.ListPagesSettings;
            GetPageSettings = existing.GetPageSettings;
            CreatePageSettings = existing.CreatePageSettings;
            UpdatePageSettings = existing.UpdatePageSettings;
            DeletePageSettings = existing.DeletePageSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(PagesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>PagesClient.ListPages</c>
        /// and <c>PagesClient.ListPagesAsync</c>.
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
        public gaxgrpc::CallSettings ListPagesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>PagesClient.GetPage</c> and
        /// <c>PagesClient.GetPageAsync</c>.
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
        public gaxgrpc::CallSettings GetPageSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>PagesClient.CreatePage</c>
        /// and <c>PagesClient.CreatePageAsync</c>.
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
        public gaxgrpc::CallSettings CreatePageSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>PagesClient.UpdatePage</c>
        /// and <c>PagesClient.UpdatePageAsync</c>.
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
        public gaxgrpc::CallSettings UpdatePageSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>PagesClient.DeletePage</c>
        /// and <c>PagesClient.DeletePageAsync</c>.
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
        public gaxgrpc::CallSettings DeletePageSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PagesSettings"/> object.</returns>
        public PagesSettings Clone() => new PagesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PagesClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class PagesClientBuilder : gaxgrpc::ClientBuilderBase<PagesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PagesSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public PagesClientBuilder() : base(PagesClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref PagesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PagesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PagesClient Build()
        {
            PagesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PagesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PagesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PagesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PagesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<PagesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PagesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PagesClient.ChannelPool;
    }

    /// <summary>Pages client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Pages][google.cloud.dialogflow.cx.v3.Page].
    /// </remarks>
    public abstract partial class PagesClient
    {
        /// <summary>
        /// The default endpoint for the Pages service, which is a host of "dialogflow.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dialogflow.googleapis.com:443";

        /// <summary>The default Pages scopes.</summary>
        /// <remarks>
        /// The default Pages scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Pages.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="PagesClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="PagesClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PagesClient"/>.</returns>
        public static stt::Task<PagesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PagesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PagesClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="PagesClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PagesClient"/>.</returns>
        public static PagesClient Create() => new PagesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PagesClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PagesSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="PagesClient"/>.</returns>
        internal static PagesClient Create(grpccore::CallInvoker callInvoker, PagesSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Pages.PagesClient grpcClient = new Pages.PagesClient(callInvoker);
            return new PagesClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Pages client</summary>
        public virtual Pages.PagesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all pages in the specified flow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Page"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPagesResponse, Page> ListPages(ListPagesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all pages in the specified flow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Page"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPagesResponse, Page> ListPagesAsync(ListPagesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all pages in the specified flow.
        /// </summary>
        /// <param name="parent">
        /// Required. The flow to list all pages for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="Page"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPagesResponse, Page> ListPages(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPagesRequest request = new ListPagesRequest
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
            return ListPages(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all pages in the specified flow.
        /// </summary>
        /// <param name="parent">
        /// Required. The flow to list all pages for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Page"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPagesResponse, Page> ListPagesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPagesRequest request = new ListPagesRequest
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
            return ListPagesAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all pages in the specified flow.
        /// </summary>
        /// <param name="parent">
        /// Required. The flow to list all pages for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="Page"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPagesResponse, Page> ListPages(FlowName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPagesRequest request = new ListPagesRequest
            {
                ParentAsFlowName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPages(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all pages in the specified flow.
        /// </summary>
        /// <param name="parent">
        /// Required. The flow to list all pages for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Page"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPagesResponse, Page> ListPagesAsync(FlowName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPagesRequest request = new ListPagesRequest
            {
                ParentAsFlowName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPagesAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified page.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Page GetPage(GetPageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified page.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Page> GetPageAsync(GetPageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified page.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Page> GetPageAsync(GetPageRequest request, st::CancellationToken cancellationToken) =>
            GetPageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified page.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the page.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;/pages/&lt;PageID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Page GetPage(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPage(new GetPageRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified page.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the page.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;/pages/&lt;PageID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Page> GetPageAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPageAsync(new GetPageRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified page.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the page.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;/pages/&lt;PageID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Page> GetPageAsync(string name, st::CancellationToken cancellationToken) =>
            GetPageAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified page.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the page.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;/pages/&lt;PageID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Page GetPage(PageName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPage(new GetPageRequest
            {
                PageName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified page.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the page.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;/pages/&lt;PageID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Page> GetPageAsync(PageName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPageAsync(new GetPageRequest
            {
                PageName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified page.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the page.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;/pages/&lt;PageID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Page> GetPageAsync(PageName name, st::CancellationToken cancellationToken) =>
            GetPageAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a page in the specified flow.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Page CreatePage(CreatePageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a page in the specified flow.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Page> CreatePageAsync(CreatePageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a page in the specified flow.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Page> CreatePageAsync(CreatePageRequest request, st::CancellationToken cancellationToken) =>
            CreatePageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a page in the specified flow.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The flow to create a page for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`.
        /// </param>
        /// <param name="page">
        /// Required. The page to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Page CreatePage(string parent, Page page, gaxgrpc::CallSettings callSettings = null) =>
            CreatePage(new CreatePageRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Page = gax::GaxPreconditions.CheckNotNull(page, nameof(page)),
            }, callSettings);

        /// <summary>
        /// Creates a page in the specified flow.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The flow to create a page for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`.
        /// </param>
        /// <param name="page">
        /// Required. The page to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Page> CreatePageAsync(string parent, Page page, gaxgrpc::CallSettings callSettings = null) =>
            CreatePageAsync(new CreatePageRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Page = gax::GaxPreconditions.CheckNotNull(page, nameof(page)),
            }, callSettings);

        /// <summary>
        /// Creates a page in the specified flow.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The flow to create a page for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`.
        /// </param>
        /// <param name="page">
        /// Required. The page to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Page> CreatePageAsync(string parent, Page page, st::CancellationToken cancellationToken) =>
            CreatePageAsync(parent, page, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a page in the specified flow.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The flow to create a page for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`.
        /// </param>
        /// <param name="page">
        /// Required. The page to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Page CreatePage(FlowName parent, Page page, gaxgrpc::CallSettings callSettings = null) =>
            CreatePage(new CreatePageRequest
            {
                ParentAsFlowName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Page = gax::GaxPreconditions.CheckNotNull(page, nameof(page)),
            }, callSettings);

        /// <summary>
        /// Creates a page in the specified flow.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The flow to create a page for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`.
        /// </param>
        /// <param name="page">
        /// Required. The page to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Page> CreatePageAsync(FlowName parent, Page page, gaxgrpc::CallSettings callSettings = null) =>
            CreatePageAsync(new CreatePageRequest
            {
                ParentAsFlowName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Page = gax::GaxPreconditions.CheckNotNull(page, nameof(page)),
            }, callSettings);

        /// <summary>
        /// Creates a page in the specified flow.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The flow to create a page for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`.
        /// </param>
        /// <param name="page">
        /// Required. The page to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Page> CreatePageAsync(FlowName parent, Page page, st::CancellationToken cancellationToken) =>
            CreatePageAsync(parent, page, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified page.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Page UpdatePage(UpdatePageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified page.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Page> UpdatePageAsync(UpdatePageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified page.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Page> UpdatePageAsync(UpdatePageRequest request, st::CancellationToken cancellationToken) =>
            UpdatePageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified page.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="page">
        /// Required. The page to update.
        /// </param>
        /// <param name="updateMask">
        /// The mask to control which fields get updated. If the mask is not present,
        /// all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Page UpdatePage(Page page, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePage(new UpdatePageRequest
            {
                Page = gax::GaxPreconditions.CheckNotNull(page, nameof(page)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified page.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="page">
        /// Required. The page to update.
        /// </param>
        /// <param name="updateMask">
        /// The mask to control which fields get updated. If the mask is not present,
        /// all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Page> UpdatePageAsync(Page page, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePageAsync(new UpdatePageRequest
            {
                Page = gax::GaxPreconditions.CheckNotNull(page, nameof(page)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified page.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="page">
        /// Required. The page to update.
        /// </param>
        /// <param name="updateMask">
        /// The mask to control which fields get updated. If the mask is not present,
        /// all fields will be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Page> UpdatePageAsync(Page page, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdatePageAsync(page, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified page.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePage(DeletePageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified page.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePageAsync(DeletePageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified page.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePageAsync(DeletePageRequest request, st::CancellationToken cancellationToken) =>
            DeletePageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified page.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the page to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/Flows/&lt;flowID&gt;/pages/&lt;PageID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePage(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePage(new DeletePageRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified page.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the page to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/Flows/&lt;flowID&gt;/pages/&lt;PageID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePageAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePageAsync(new DeletePageRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified page.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the page to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/Flows/&lt;flowID&gt;/pages/&lt;PageID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePageAsync(string name, st::CancellationToken cancellationToken) =>
            DeletePageAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified page.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the page to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/Flows/&lt;flowID&gt;/pages/&lt;PageID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePage(PageName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePage(new DeletePageRequest
            {
                PageName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified page.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the page to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/Flows/&lt;flowID&gt;/pages/&lt;PageID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePageAsync(PageName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePageAsync(new DeletePageRequest
            {
                PageName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified page.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the page to delete.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/Flows/&lt;flowID&gt;/pages/&lt;PageID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePageAsync(PageName name, st::CancellationToken cancellationToken) =>
            DeletePageAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Pages client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Pages][google.cloud.dialogflow.cx.v3.Page].
    /// </remarks>
    public sealed partial class PagesClientImpl : PagesClient
    {
        private readonly gaxgrpc::ApiCall<ListPagesRequest, ListPagesResponse> _callListPages;

        private readonly gaxgrpc::ApiCall<GetPageRequest, Page> _callGetPage;

        private readonly gaxgrpc::ApiCall<CreatePageRequest, Page> _callCreatePage;

        private readonly gaxgrpc::ApiCall<UpdatePageRequest, Page> _callUpdatePage;

        private readonly gaxgrpc::ApiCall<DeletePageRequest, wkt::Empty> _callDeletePage;

        /// <summary>
        /// Constructs a client wrapper for the Pages service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="PagesSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public PagesClientImpl(Pages.PagesClient grpcClient, PagesSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            PagesSettings effectiveSettings = settings ?? PagesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListPages = clientHelper.BuildApiCall<ListPagesRequest, ListPagesResponse>("ListPages", grpcClient.ListPagesAsync, grpcClient.ListPages, effectiveSettings.ListPagesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPages);
            Modify_ListPagesApiCall(ref _callListPages);
            _callGetPage = clientHelper.BuildApiCall<GetPageRequest, Page>("GetPage", grpcClient.GetPageAsync, grpcClient.GetPage, effectiveSettings.GetPageSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPage);
            Modify_GetPageApiCall(ref _callGetPage);
            _callCreatePage = clientHelper.BuildApiCall<CreatePageRequest, Page>("CreatePage", grpcClient.CreatePageAsync, grpcClient.CreatePage, effectiveSettings.CreatePageSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreatePage);
            Modify_CreatePageApiCall(ref _callCreatePage);
            _callUpdatePage = clientHelper.BuildApiCall<UpdatePageRequest, Page>("UpdatePage", grpcClient.UpdatePageAsync, grpcClient.UpdatePage, effectiveSettings.UpdatePageSettings).WithGoogleRequestParam("page.name", request => request.Page?.Name);
            Modify_ApiCall(ref _callUpdatePage);
            Modify_UpdatePageApiCall(ref _callUpdatePage);
            _callDeletePage = clientHelper.BuildApiCall<DeletePageRequest, wkt::Empty>("DeletePage", grpcClient.DeletePageAsync, grpcClient.DeletePage, effectiveSettings.DeletePageSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeletePage);
            Modify_DeletePageApiCall(ref _callDeletePage);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListPagesApiCall(ref gaxgrpc::ApiCall<ListPagesRequest, ListPagesResponse> call);

        partial void Modify_GetPageApiCall(ref gaxgrpc::ApiCall<GetPageRequest, Page> call);

        partial void Modify_CreatePageApiCall(ref gaxgrpc::ApiCall<CreatePageRequest, Page> call);

        partial void Modify_UpdatePageApiCall(ref gaxgrpc::ApiCall<UpdatePageRequest, Page> call);

        partial void Modify_DeletePageApiCall(ref gaxgrpc::ApiCall<DeletePageRequest, wkt::Empty> call);

        partial void OnConstruction(Pages.PagesClient grpcClient, PagesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Pages client</summary>
        public override Pages.PagesClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListPagesRequest(ref ListPagesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPageRequest(ref GetPageRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreatePageRequest(ref CreatePageRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdatePageRequest(ref UpdatePageRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePageRequest(ref DeletePageRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the list of all pages in the specified flow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Page"/> resources.</returns>
        public override gax::PagedEnumerable<ListPagesResponse, Page> ListPages(ListPagesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPagesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPagesRequest, ListPagesResponse, Page>(_callListPages, request, callSettings);
        }

        /// <summary>
        /// Returns the list of all pages in the specified flow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Page"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPagesResponse, Page> ListPagesAsync(ListPagesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPagesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPagesRequest, ListPagesResponse, Page>(_callListPages, request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified page.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Page GetPage(GetPageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPageRequest(ref request, ref callSettings);
            return _callGetPage.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified page.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Page> GetPageAsync(GetPageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPageRequest(ref request, ref callSettings);
            return _callGetPage.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a page in the specified flow.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Page CreatePage(CreatePageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePageRequest(ref request, ref callSettings);
            return _callCreatePage.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a page in the specified flow.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Page> CreatePageAsync(CreatePageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePageRequest(ref request, ref callSettings);
            return _callCreatePage.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified page.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Page UpdatePage(UpdatePageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePageRequest(ref request, ref callSettings);
            return _callUpdatePage.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified page.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Page> UpdatePageAsync(UpdatePageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePageRequest(ref request, ref callSettings);
            return _callUpdatePage.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified page.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeletePage(DeletePageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePageRequest(ref request, ref callSettings);
            _callDeletePage.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified page.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeletePageAsync(DeletePageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePageRequest(ref request, ref callSettings);
            return _callDeletePage.Async(request, callSettings);
        }
    }

    public partial class ListPagesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPagesResponse : gaxgrpc::IPageResponse<Page>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Page> GetEnumerator() => Pages.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Pages
    {
        public partial class PagesClient
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
