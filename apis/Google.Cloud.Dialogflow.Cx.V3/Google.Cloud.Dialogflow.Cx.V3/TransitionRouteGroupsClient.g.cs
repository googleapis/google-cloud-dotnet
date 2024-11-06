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
    /// <summary>Settings for <see cref="TransitionRouteGroupsClient"/> instances.</summary>
    public sealed partial class TransitionRouteGroupsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="TransitionRouteGroupsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="TransitionRouteGroupsSettings"/>.</returns>
        public static TransitionRouteGroupsSettings GetDefault() => new TransitionRouteGroupsSettings();

        /// <summary>
        /// Constructs a new <see cref="TransitionRouteGroupsSettings"/> object with default settings.
        /// </summary>
        public TransitionRouteGroupsSettings()
        {
        }

        private TransitionRouteGroupsSettings(TransitionRouteGroupsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListTransitionRouteGroupsSettings = existing.ListTransitionRouteGroupsSettings;
            GetTransitionRouteGroupSettings = existing.GetTransitionRouteGroupSettings;
            CreateTransitionRouteGroupSettings = existing.CreateTransitionRouteGroupSettings;
            UpdateTransitionRouteGroupSettings = existing.UpdateTransitionRouteGroupSettings;
            DeleteTransitionRouteGroupSettings = existing.DeleteTransitionRouteGroupSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(TransitionRouteGroupsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TransitionRouteGroupsClient.ListTransitionRouteGroups</c> and
        /// <c>TransitionRouteGroupsClient.ListTransitionRouteGroupsAsync</c>.
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
        public gaxgrpc::CallSettings ListTransitionRouteGroupsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TransitionRouteGroupsClient.GetTransitionRouteGroup</c> and
        /// <c>TransitionRouteGroupsClient.GetTransitionRouteGroupAsync</c>.
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
        public gaxgrpc::CallSettings GetTransitionRouteGroupSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TransitionRouteGroupsClient.CreateTransitionRouteGroup</c> and
        /// <c>TransitionRouteGroupsClient.CreateTransitionRouteGroupAsync</c>.
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
        public gaxgrpc::CallSettings CreateTransitionRouteGroupSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TransitionRouteGroupsClient.UpdateTransitionRouteGroup</c> and
        /// <c>TransitionRouteGroupsClient.UpdateTransitionRouteGroupAsync</c>.
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
        public gaxgrpc::CallSettings UpdateTransitionRouteGroupSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TransitionRouteGroupsClient.DeleteTransitionRouteGroup</c> and
        /// <c>TransitionRouteGroupsClient.DeleteTransitionRouteGroupAsync</c>.
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
        public gaxgrpc::CallSettings DeleteTransitionRouteGroupSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="TransitionRouteGroupsSettings"/> object.</returns>
        public TransitionRouteGroupsSettings Clone() => new TransitionRouteGroupsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="TransitionRouteGroupsClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class TransitionRouteGroupsClientBuilder : gaxgrpc::ClientBuilderBase<TransitionRouteGroupsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public TransitionRouteGroupsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public TransitionRouteGroupsClientBuilder() : base(TransitionRouteGroupsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref TransitionRouteGroupsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<TransitionRouteGroupsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override TransitionRouteGroupsClient Build()
        {
            TransitionRouteGroupsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<TransitionRouteGroupsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<TransitionRouteGroupsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private TransitionRouteGroupsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return TransitionRouteGroupsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<TransitionRouteGroupsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TransitionRouteGroupsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => TransitionRouteGroupsClient.ChannelPool;
    }

    /// <summary>TransitionRouteGroups client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing
    /// [TransitionRouteGroups][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
    /// </remarks>
    public abstract partial class TransitionRouteGroupsClient
    {
        /// <summary>
        /// The default endpoint for the TransitionRouteGroups service, which is a host of "dialogflow.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dialogflow.googleapis.com:443";

        /// <summary>The default TransitionRouteGroups scopes.</summary>
        /// <remarks>
        /// The default TransitionRouteGroups scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(TransitionRouteGroups.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="TransitionRouteGroupsClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="TransitionRouteGroupsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="TransitionRouteGroupsClient"/>.</returns>
        public static stt::Task<TransitionRouteGroupsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new TransitionRouteGroupsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="TransitionRouteGroupsClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="TransitionRouteGroupsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="TransitionRouteGroupsClient"/>.</returns>
        public static TransitionRouteGroupsClient Create() => new TransitionRouteGroupsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="TransitionRouteGroupsClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="TransitionRouteGroupsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="TransitionRouteGroupsClient"/>.</returns>
        internal static TransitionRouteGroupsClient Create(grpccore::CallInvoker callInvoker, TransitionRouteGroupsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            TransitionRouteGroups.TransitionRouteGroupsClient grpcClient = new TransitionRouteGroups.TransitionRouteGroupsClient(callInvoker);
            return new TransitionRouteGroupsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC TransitionRouteGroups client</summary>
        public virtual TransitionRouteGroups.TransitionRouteGroupsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all transition route groups in the specified flow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TransitionRouteGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTransitionRouteGroupsResponse, TransitionRouteGroup> ListTransitionRouteGroups(ListTransitionRouteGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all transition route groups in the specified flow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TransitionRouteGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTransitionRouteGroupsResponse, TransitionRouteGroup> ListTransitionRouteGroupsAsync(ListTransitionRouteGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all transition route groups in the specified flow.
        /// </summary>
        /// <param name="parent">
        /// Required. The flow to list all transition route groups for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`
        /// or `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;.
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
        /// <returns>A pageable sequence of <see cref="TransitionRouteGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTransitionRouteGroupsResponse, TransitionRouteGroup> ListTransitionRouteGroups(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTransitionRouteGroupsRequest request = new ListTransitionRouteGroupsRequest
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
            return ListTransitionRouteGroups(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all transition route groups in the specified flow.
        /// </summary>
        /// <param name="parent">
        /// Required. The flow to list all transition route groups for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`
        /// or `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TransitionRouteGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTransitionRouteGroupsResponse, TransitionRouteGroup> ListTransitionRouteGroupsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTransitionRouteGroupsRequest request = new ListTransitionRouteGroupsRequest
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
            return ListTransitionRouteGroupsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all transition route groups in the specified flow.
        /// </summary>
        /// <param name="parent">
        /// Required. The flow to list all transition route groups for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`
        /// or `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;.
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
        /// <returns>A pageable sequence of <see cref="TransitionRouteGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTransitionRouteGroupsResponse, TransitionRouteGroup> ListTransitionRouteGroups(FlowName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTransitionRouteGroupsRequest request = new ListTransitionRouteGroupsRequest
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
            return ListTransitionRouteGroups(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all transition route groups in the specified flow.
        /// </summary>
        /// <param name="parent">
        /// Required. The flow to list all transition route groups for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`
        /// or `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TransitionRouteGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTransitionRouteGroupsResponse, TransitionRouteGroup> ListTransitionRouteGroupsAsync(FlowName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTransitionRouteGroupsRequest request = new ListTransitionRouteGroupsRequest
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
            return ListTransitionRouteGroupsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all transition route groups in the specified flow.
        /// </summary>
        /// <param name="parent">
        /// Required. The flow to list all transition route groups for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`
        /// or `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;.
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
        /// <returns>A pageable sequence of <see cref="TransitionRouteGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTransitionRouteGroupsResponse, TransitionRouteGroup> ListTransitionRouteGroups(AgentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTransitionRouteGroupsRequest request = new ListTransitionRouteGroupsRequest
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
            return ListTransitionRouteGroups(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all transition route groups in the specified flow.
        /// </summary>
        /// <param name="parent">
        /// Required. The flow to list all transition route groups for.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`
        /// or `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TransitionRouteGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTransitionRouteGroupsResponse, TransitionRouteGroup> ListTransitionRouteGroupsAsync(AgentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTransitionRouteGroupsRequest request = new ListTransitionRouteGroupsRequest
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
            return ListTransitionRouteGroupsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TransitionRouteGroup GetTransitionRouteGroup(GetTransitionRouteGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransitionRouteGroup> GetTransitionRouteGroupAsync(GetTransitionRouteGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransitionRouteGroup> GetTransitionRouteGroupAsync(GetTransitionRouteGroupRequest request, st::CancellationToken cancellationToken) =>
            GetTransitionRouteGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;/transitionRouteGroups/&lt;TransitionRouteGroupID&gt;`
        /// or
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/transitionRouteGroups/&lt;TransitionRouteGroupID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TransitionRouteGroup GetTransitionRouteGroup(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTransitionRouteGroup(new GetTransitionRouteGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;/transitionRouteGroups/&lt;TransitionRouteGroupID&gt;`
        /// or
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/transitionRouteGroups/&lt;TransitionRouteGroupID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransitionRouteGroup> GetTransitionRouteGroupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTransitionRouteGroupAsync(new GetTransitionRouteGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;/transitionRouteGroups/&lt;TransitionRouteGroupID&gt;`
        /// or
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/transitionRouteGroups/&lt;TransitionRouteGroupID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransitionRouteGroup> GetTransitionRouteGroupAsync(string name, st::CancellationToken cancellationToken) =>
            GetTransitionRouteGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;/transitionRouteGroups/&lt;TransitionRouteGroupID&gt;`
        /// or
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/transitionRouteGroups/&lt;TransitionRouteGroupID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TransitionRouteGroup GetTransitionRouteGroup(TransitionRouteGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTransitionRouteGroup(new GetTransitionRouteGroupRequest
            {
                TransitionRouteGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;/transitionRouteGroups/&lt;TransitionRouteGroupID&gt;`
        /// or
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/transitionRouteGroups/&lt;TransitionRouteGroupID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransitionRouteGroup> GetTransitionRouteGroupAsync(TransitionRouteGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTransitionRouteGroupAsync(new GetTransitionRouteGroupRequest
            {
                TransitionRouteGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;/transitionRouteGroups/&lt;TransitionRouteGroupID&gt;`
        /// or
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/transitionRouteGroups/&lt;TransitionRouteGroupID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransitionRouteGroup> GetTransitionRouteGroupAsync(TransitionRouteGroupName name, st::CancellationToken cancellationToken) =>
            GetTransitionRouteGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup]
        /// in the specified flow.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TransitionRouteGroup CreateTransitionRouteGroup(CreateTransitionRouteGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup]
        /// in the specified flow.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransitionRouteGroup> CreateTransitionRouteGroupAsync(CreateTransitionRouteGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup]
        /// in the specified flow.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransitionRouteGroup> CreateTransitionRouteGroupAsync(CreateTransitionRouteGroupRequest request, st::CancellationToken cancellationToken) =>
            CreateTransitionRouteGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup]
        /// in the specified flow.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The flow to create an
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup]
        /// for. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`
        /// or `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`
        /// for agent-level groups.
        /// </param>
        /// <param name="transitionRouteGroup">
        /// Required. The transition route group to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TransitionRouteGroup CreateTransitionRouteGroup(string parent, TransitionRouteGroup transitionRouteGroup, gaxgrpc::CallSettings callSettings = null) =>
            CreateTransitionRouteGroup(new CreateTransitionRouteGroupRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TransitionRouteGroup = gax::GaxPreconditions.CheckNotNull(transitionRouteGroup, nameof(transitionRouteGroup)),
            }, callSettings);

        /// <summary>
        /// Creates an
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup]
        /// in the specified flow.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The flow to create an
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup]
        /// for. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`
        /// or `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`
        /// for agent-level groups.
        /// </param>
        /// <param name="transitionRouteGroup">
        /// Required. The transition route group to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransitionRouteGroup> CreateTransitionRouteGroupAsync(string parent, TransitionRouteGroup transitionRouteGroup, gaxgrpc::CallSettings callSettings = null) =>
            CreateTransitionRouteGroupAsync(new CreateTransitionRouteGroupRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TransitionRouteGroup = gax::GaxPreconditions.CheckNotNull(transitionRouteGroup, nameof(transitionRouteGroup)),
            }, callSettings);

        /// <summary>
        /// Creates an
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup]
        /// in the specified flow.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The flow to create an
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup]
        /// for. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`
        /// or `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`
        /// for agent-level groups.
        /// </param>
        /// <param name="transitionRouteGroup">
        /// Required. The transition route group to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransitionRouteGroup> CreateTransitionRouteGroupAsync(string parent, TransitionRouteGroup transitionRouteGroup, st::CancellationToken cancellationToken) =>
            CreateTransitionRouteGroupAsync(parent, transitionRouteGroup, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup]
        /// in the specified flow.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The flow to create an
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup]
        /// for. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`
        /// or `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`
        /// for agent-level groups.
        /// </param>
        /// <param name="transitionRouteGroup">
        /// Required. The transition route group to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TransitionRouteGroup CreateTransitionRouteGroup(FlowName parent, TransitionRouteGroup transitionRouteGroup, gaxgrpc::CallSettings callSettings = null) =>
            CreateTransitionRouteGroup(new CreateTransitionRouteGroupRequest
            {
                ParentAsFlowName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TransitionRouteGroup = gax::GaxPreconditions.CheckNotNull(transitionRouteGroup, nameof(transitionRouteGroup)),
            }, callSettings);

        /// <summary>
        /// Creates an
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup]
        /// in the specified flow.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The flow to create an
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup]
        /// for. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`
        /// or `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`
        /// for agent-level groups.
        /// </param>
        /// <param name="transitionRouteGroup">
        /// Required. The transition route group to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransitionRouteGroup> CreateTransitionRouteGroupAsync(FlowName parent, TransitionRouteGroup transitionRouteGroup, gaxgrpc::CallSettings callSettings = null) =>
            CreateTransitionRouteGroupAsync(new CreateTransitionRouteGroupRequest
            {
                ParentAsFlowName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TransitionRouteGroup = gax::GaxPreconditions.CheckNotNull(transitionRouteGroup, nameof(transitionRouteGroup)),
            }, callSettings);

        /// <summary>
        /// Creates an
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup]
        /// in the specified flow.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The flow to create an
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup]
        /// for. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`
        /// or `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`
        /// for agent-level groups.
        /// </param>
        /// <param name="transitionRouteGroup">
        /// Required. The transition route group to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransitionRouteGroup> CreateTransitionRouteGroupAsync(FlowName parent, TransitionRouteGroup transitionRouteGroup, st::CancellationToken cancellationToken) =>
            CreateTransitionRouteGroupAsync(parent, transitionRouteGroup, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup]
        /// in the specified flow.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The flow to create an
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup]
        /// for. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`
        /// or `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`
        /// for agent-level groups.
        /// </param>
        /// <param name="transitionRouteGroup">
        /// Required. The transition route group to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TransitionRouteGroup CreateTransitionRouteGroup(AgentName parent, TransitionRouteGroup transitionRouteGroup, gaxgrpc::CallSettings callSettings = null) =>
            CreateTransitionRouteGroup(new CreateTransitionRouteGroupRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TransitionRouteGroup = gax::GaxPreconditions.CheckNotNull(transitionRouteGroup, nameof(transitionRouteGroup)),
            }, callSettings);

        /// <summary>
        /// Creates an
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup]
        /// in the specified flow.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The flow to create an
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup]
        /// for. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`
        /// or `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`
        /// for agent-level groups.
        /// </param>
        /// <param name="transitionRouteGroup">
        /// Required. The transition route group to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransitionRouteGroup> CreateTransitionRouteGroupAsync(AgentName parent, TransitionRouteGroup transitionRouteGroup, gaxgrpc::CallSettings callSettings = null) =>
            CreateTransitionRouteGroupAsync(new CreateTransitionRouteGroupRequest
            {
                ParentAsAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TransitionRouteGroup = gax::GaxPreconditions.CheckNotNull(transitionRouteGroup, nameof(transitionRouteGroup)),
            }, callSettings);

        /// <summary>
        /// Creates an
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup]
        /// in the specified flow.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The flow to create an
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup]
        /// for. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;`
        /// or `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;`
        /// for agent-level groups.
        /// </param>
        /// <param name="transitionRouteGroup">
        /// Required. The transition route group to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransitionRouteGroup> CreateTransitionRouteGroupAsync(AgentName parent, TransitionRouteGroup transitionRouteGroup, st::CancellationToken cancellationToken) =>
            CreateTransitionRouteGroupAsync(parent, transitionRouteGroup, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TransitionRouteGroup UpdateTransitionRouteGroup(UpdateTransitionRouteGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransitionRouteGroup> UpdateTransitionRouteGroupAsync(UpdateTransitionRouteGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransitionRouteGroup> UpdateTransitionRouteGroupAsync(UpdateTransitionRouteGroupRequest request, st::CancellationToken cancellationToken) =>
            UpdateTransitionRouteGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="transitionRouteGroup">
        /// Required. The transition route group to update.
        /// </param>
        /// <param name="updateMask">
        /// The mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TransitionRouteGroup UpdateTransitionRouteGroup(TransitionRouteGroup transitionRouteGroup, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTransitionRouteGroup(new UpdateTransitionRouteGroupRequest
            {
                TransitionRouteGroup = gax::GaxPreconditions.CheckNotNull(transitionRouteGroup, nameof(transitionRouteGroup)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="transitionRouteGroup">
        /// Required. The transition route group to update.
        /// </param>
        /// <param name="updateMask">
        /// The mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransitionRouteGroup> UpdateTransitionRouteGroupAsync(TransitionRouteGroup transitionRouteGroup, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTransitionRouteGroupAsync(new UpdateTransitionRouteGroupRequest
            {
                TransitionRouteGroup = gax::GaxPreconditions.CheckNotNull(transitionRouteGroup, nameof(transitionRouteGroup)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="transitionRouteGroup">
        /// Required. The transition route group to update.
        /// </param>
        /// <param name="updateMask">
        /// The mask to control which fields get updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TransitionRouteGroup> UpdateTransitionRouteGroupAsync(TransitionRouteGroup transitionRouteGroup, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateTransitionRouteGroupAsync(transitionRouteGroup, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTransitionRouteGroup(DeleteTransitionRouteGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTransitionRouteGroupAsync(DeleteTransitionRouteGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTransitionRouteGroupAsync(DeleteTransitionRouteGroupRequest request, st::CancellationToken cancellationToken) =>
            DeleteTransitionRouteGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup]
        /// to delete. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;/transitionRouteGroups/&lt;TransitionRouteGroupID&gt;`
        /// or
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/transitionRouteGroups/&lt;TransitionRouteGroupID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTransitionRouteGroup(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTransitionRouteGroup(new DeleteTransitionRouteGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup]
        /// to delete. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;/transitionRouteGroups/&lt;TransitionRouteGroupID&gt;`
        /// or
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/transitionRouteGroups/&lt;TransitionRouteGroupID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTransitionRouteGroupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTransitionRouteGroupAsync(new DeleteTransitionRouteGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup]
        /// to delete. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;/transitionRouteGroups/&lt;TransitionRouteGroupID&gt;`
        /// or
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/transitionRouteGroups/&lt;TransitionRouteGroupID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTransitionRouteGroupAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteTransitionRouteGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup]
        /// to delete. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;/transitionRouteGroups/&lt;TransitionRouteGroupID&gt;`
        /// or
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/transitionRouteGroups/&lt;TransitionRouteGroupID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTransitionRouteGroup(TransitionRouteGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTransitionRouteGroup(new DeleteTransitionRouteGroupRequest
            {
                TransitionRouteGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup]
        /// to delete. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;/transitionRouteGroups/&lt;TransitionRouteGroupID&gt;`
        /// or
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/transitionRouteGroups/&lt;TransitionRouteGroupID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTransitionRouteGroupAsync(TransitionRouteGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTransitionRouteGroupAsync(new DeleteTransitionRouteGroupRequest
            {
                TransitionRouteGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup]
        /// to delete. Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/flows/&lt;FlowID&gt;/transitionRouteGroups/&lt;TransitionRouteGroupID&gt;`
        /// or
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/transitionRouteGroups/&lt;TransitionRouteGroupID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTransitionRouteGroupAsync(TransitionRouteGroupName name, st::CancellationToken cancellationToken) =>
            DeleteTransitionRouteGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>TransitionRouteGroups client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing
    /// [TransitionRouteGroups][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
    /// </remarks>
    public sealed partial class TransitionRouteGroupsClientImpl : TransitionRouteGroupsClient
    {
        private readonly gaxgrpc::ApiCall<ListTransitionRouteGroupsRequest, ListTransitionRouteGroupsResponse> _callListTransitionRouteGroups;

        private readonly gaxgrpc::ApiCall<GetTransitionRouteGroupRequest, TransitionRouteGroup> _callGetTransitionRouteGroup;

        private readonly gaxgrpc::ApiCall<CreateTransitionRouteGroupRequest, TransitionRouteGroup> _callCreateTransitionRouteGroup;

        private readonly gaxgrpc::ApiCall<UpdateTransitionRouteGroupRequest, TransitionRouteGroup> _callUpdateTransitionRouteGroup;

        private readonly gaxgrpc::ApiCall<DeleteTransitionRouteGroupRequest, wkt::Empty> _callDeleteTransitionRouteGroup;

        /// <summary>
        /// Constructs a client wrapper for the TransitionRouteGroups service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="TransitionRouteGroupsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public TransitionRouteGroupsClientImpl(TransitionRouteGroups.TransitionRouteGroupsClient grpcClient, TransitionRouteGroupsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            TransitionRouteGroupsSettings effectiveSettings = settings ?? TransitionRouteGroupsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListTransitionRouteGroups = clientHelper.BuildApiCall<ListTransitionRouteGroupsRequest, ListTransitionRouteGroupsResponse>("ListTransitionRouteGroups", grpcClient.ListTransitionRouteGroupsAsync, grpcClient.ListTransitionRouteGroups, effectiveSettings.ListTransitionRouteGroupsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTransitionRouteGroups);
            Modify_ListTransitionRouteGroupsApiCall(ref _callListTransitionRouteGroups);
            _callGetTransitionRouteGroup = clientHelper.BuildApiCall<GetTransitionRouteGroupRequest, TransitionRouteGroup>("GetTransitionRouteGroup", grpcClient.GetTransitionRouteGroupAsync, grpcClient.GetTransitionRouteGroup, effectiveSettings.GetTransitionRouteGroupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTransitionRouteGroup);
            Modify_GetTransitionRouteGroupApiCall(ref _callGetTransitionRouteGroup);
            _callCreateTransitionRouteGroup = clientHelper.BuildApiCall<CreateTransitionRouteGroupRequest, TransitionRouteGroup>("CreateTransitionRouteGroup", grpcClient.CreateTransitionRouteGroupAsync, grpcClient.CreateTransitionRouteGroup, effectiveSettings.CreateTransitionRouteGroupSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTransitionRouteGroup);
            Modify_CreateTransitionRouteGroupApiCall(ref _callCreateTransitionRouteGroup);
            _callUpdateTransitionRouteGroup = clientHelper.BuildApiCall<UpdateTransitionRouteGroupRequest, TransitionRouteGroup>("UpdateTransitionRouteGroup", grpcClient.UpdateTransitionRouteGroupAsync, grpcClient.UpdateTransitionRouteGroup, effectiveSettings.UpdateTransitionRouteGroupSettings).WithGoogleRequestParam("transition_route_group.name", request => request.TransitionRouteGroup?.Name);
            Modify_ApiCall(ref _callUpdateTransitionRouteGroup);
            Modify_UpdateTransitionRouteGroupApiCall(ref _callUpdateTransitionRouteGroup);
            _callDeleteTransitionRouteGroup = clientHelper.BuildApiCall<DeleteTransitionRouteGroupRequest, wkt::Empty>("DeleteTransitionRouteGroup", grpcClient.DeleteTransitionRouteGroupAsync, grpcClient.DeleteTransitionRouteGroup, effectiveSettings.DeleteTransitionRouteGroupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTransitionRouteGroup);
            Modify_DeleteTransitionRouteGroupApiCall(ref _callDeleteTransitionRouteGroup);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListTransitionRouteGroupsApiCall(ref gaxgrpc::ApiCall<ListTransitionRouteGroupsRequest, ListTransitionRouteGroupsResponse> call);

        partial void Modify_GetTransitionRouteGroupApiCall(ref gaxgrpc::ApiCall<GetTransitionRouteGroupRequest, TransitionRouteGroup> call);

        partial void Modify_CreateTransitionRouteGroupApiCall(ref gaxgrpc::ApiCall<CreateTransitionRouteGroupRequest, TransitionRouteGroup> call);

        partial void Modify_UpdateTransitionRouteGroupApiCall(ref gaxgrpc::ApiCall<UpdateTransitionRouteGroupRequest, TransitionRouteGroup> call);

        partial void Modify_DeleteTransitionRouteGroupApiCall(ref gaxgrpc::ApiCall<DeleteTransitionRouteGroupRequest, wkt::Empty> call);

        partial void OnConstruction(TransitionRouteGroups.TransitionRouteGroupsClient grpcClient, TransitionRouteGroupsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC TransitionRouteGroups client</summary>
        public override TransitionRouteGroups.TransitionRouteGroupsClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListTransitionRouteGroupsRequest(ref ListTransitionRouteGroupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTransitionRouteGroupRequest(ref GetTransitionRouteGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTransitionRouteGroupRequest(ref CreateTransitionRouteGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTransitionRouteGroupRequest(ref UpdateTransitionRouteGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTransitionRouteGroupRequest(ref DeleteTransitionRouteGroupRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the list of all transition route groups in the specified flow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TransitionRouteGroup"/> resources.</returns>
        public override gax::PagedEnumerable<ListTransitionRouteGroupsResponse, TransitionRouteGroup> ListTransitionRouteGroups(ListTransitionRouteGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTransitionRouteGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTransitionRouteGroupsRequest, ListTransitionRouteGroupsResponse, TransitionRouteGroup>(_callListTransitionRouteGroups, request, callSettings);
        }

        /// <summary>
        /// Returns the list of all transition route groups in the specified flow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TransitionRouteGroup"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTransitionRouteGroupsResponse, TransitionRouteGroup> ListTransitionRouteGroupsAsync(ListTransitionRouteGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTransitionRouteGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTransitionRouteGroupsRequest, ListTransitionRouteGroupsResponse, TransitionRouteGroup>(_callListTransitionRouteGroups, request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TransitionRouteGroup GetTransitionRouteGroup(GetTransitionRouteGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTransitionRouteGroupRequest(ref request, ref callSettings);
            return _callGetTransitionRouteGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TransitionRouteGroup> GetTransitionRouteGroupAsync(GetTransitionRouteGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTransitionRouteGroupRequest(ref request, ref callSettings);
            return _callGetTransitionRouteGroup.Async(request, callSettings);
        }

        /// <summary>
        /// Creates an
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup]
        /// in the specified flow.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TransitionRouteGroup CreateTransitionRouteGroup(CreateTransitionRouteGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTransitionRouteGroupRequest(ref request, ref callSettings);
            return _callCreateTransitionRouteGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup]
        /// in the specified flow.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TransitionRouteGroup> CreateTransitionRouteGroupAsync(CreateTransitionRouteGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTransitionRouteGroupRequest(ref request, ref callSettings);
            return _callCreateTransitionRouteGroup.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TransitionRouteGroup UpdateTransitionRouteGroup(UpdateTransitionRouteGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTransitionRouteGroupRequest(ref request, ref callSettings);
            return _callUpdateTransitionRouteGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TransitionRouteGroup> UpdateTransitionRouteGroupAsync(UpdateTransitionRouteGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTransitionRouteGroupRequest(ref request, ref callSettings);
            return _callUpdateTransitionRouteGroup.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteTransitionRouteGroup(DeleteTransitionRouteGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTransitionRouteGroupRequest(ref request, ref callSettings);
            _callDeleteTransitionRouteGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified
        /// [TransitionRouteGroup][google.cloud.dialogflow.cx.v3.TransitionRouteGroup].
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteTransitionRouteGroupAsync(DeleteTransitionRouteGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTransitionRouteGroupRequest(ref request, ref callSettings);
            return _callDeleteTransitionRouteGroup.Async(request, callSettings);
        }
    }

    public partial class ListTransitionRouteGroupsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTransitionRouteGroupsResponse : gaxgrpc::IPageResponse<TransitionRouteGroup>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TransitionRouteGroup> GetEnumerator() => TransitionRouteGroups.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class TransitionRouteGroups
    {
        public partial class TransitionRouteGroupsClient
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
