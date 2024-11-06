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

namespace Google.Cloud.Dialogflow.Cx.V3
{
    /// <summary>Settings for <see cref="ChangelogsClient"/> instances.</summary>
    public sealed partial class ChangelogsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ChangelogsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ChangelogsSettings"/>.</returns>
        public static ChangelogsSettings GetDefault() => new ChangelogsSettings();

        /// <summary>Constructs a new <see cref="ChangelogsSettings"/> object with default settings.</summary>
        public ChangelogsSettings()
        {
        }

        private ChangelogsSettings(ChangelogsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListChangelogsSettings = existing.ListChangelogsSettings;
            GetChangelogSettings = existing.GetChangelogSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ChangelogsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChangelogsClient.ListChangelogs</c> and <c>ChangelogsClient.ListChangelogsAsync</c>.
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
        public gaxgrpc::CallSettings ListChangelogsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChangelogsClient.GetChangelog</c> and <c>ChangelogsClient.GetChangelogAsync</c>.
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
        public gaxgrpc::CallSettings GetChangelogSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ChangelogsSettings"/> object.</returns>
        public ChangelogsSettings Clone() => new ChangelogsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ChangelogsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ChangelogsClientBuilder : gaxgrpc::ClientBuilderBase<ChangelogsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ChangelogsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ChangelogsClientBuilder() : base(ChangelogsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ChangelogsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ChangelogsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ChangelogsClient Build()
        {
            ChangelogsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ChangelogsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ChangelogsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ChangelogsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ChangelogsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ChangelogsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ChangelogsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ChangelogsClient.ChannelPool;
    }

    /// <summary>Changelogs client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Changelogs][google.cloud.dialogflow.cx.v3.Changelog].
    /// </remarks>
    public abstract partial class ChangelogsClient
    {
        /// <summary>
        /// The default endpoint for the Changelogs service, which is a host of "dialogflow.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dialogflow.googleapis.com:443";

        /// <summary>The default Changelogs scopes.</summary>
        /// <remarks>
        /// The default Changelogs scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Changelogs.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ChangelogsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ChangelogsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ChangelogsClient"/>.</returns>
        public static stt::Task<ChangelogsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ChangelogsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ChangelogsClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="ChangelogsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ChangelogsClient"/>.</returns>
        public static ChangelogsClient Create() => new ChangelogsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ChangelogsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ChangelogsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ChangelogsClient"/>.</returns>
        internal static ChangelogsClient Create(grpccore::CallInvoker callInvoker, ChangelogsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Changelogs.ChangelogsClient grpcClient = new Changelogs.ChangelogsClient(callInvoker);
            return new ChangelogsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Changelogs client</summary>
        public virtual Changelogs.ChangelogsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of Changelogs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Changelog"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListChangelogsResponse, Changelog> ListChangelogs(ListChangelogsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of Changelogs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Changelog"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListChangelogsResponse, Changelog> ListChangelogsAsync(ListChangelogsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of Changelogs.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent containing the changelogs.
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
        /// <returns>A pageable sequence of <see cref="Changelog"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListChangelogsResponse, Changelog> ListChangelogs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListChangelogsRequest request = new ListChangelogsRequest
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
            return ListChangelogs(request, callSettings);
        }

        /// <summary>
        /// Returns the list of Changelogs.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent containing the changelogs.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Changelog"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListChangelogsResponse, Changelog> ListChangelogsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListChangelogsRequest request = new ListChangelogsRequest
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
            return ListChangelogsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of Changelogs.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent containing the changelogs.
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
        /// <returns>A pageable sequence of <see cref="Changelog"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListChangelogsResponse, Changelog> ListChangelogs(AgentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListChangelogsRequest request = new ListChangelogsRequest
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
            return ListChangelogs(request, callSettings);
        }

        /// <summary>
        /// Returns the list of Changelogs.
        /// </summary>
        /// <param name="parent">
        /// Required. The agent containing the changelogs.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Changelog"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListChangelogsResponse, Changelog> ListChangelogsAsync(AgentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListChangelogsRequest request = new ListChangelogsRequest
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
            return ListChangelogsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified Changelog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Changelog GetChangelog(GetChangelogRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified Changelog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Changelog> GetChangelogAsync(GetChangelogRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified Changelog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Changelog> GetChangelogAsync(GetChangelogRequest request, st::CancellationToken cancellationToken) =>
            GetChangelogAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified Changelog.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the changelog to get.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/changelogs/&lt;ChangelogID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Changelog GetChangelog(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetChangelog(new GetChangelogRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified Changelog.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the changelog to get.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/changelogs/&lt;ChangelogID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Changelog> GetChangelogAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetChangelogAsync(new GetChangelogRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified Changelog.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the changelog to get.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/changelogs/&lt;ChangelogID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Changelog> GetChangelogAsync(string name, st::CancellationToken cancellationToken) =>
            GetChangelogAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified Changelog.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the changelog to get.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/changelogs/&lt;ChangelogID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Changelog GetChangelog(ChangelogName name, gaxgrpc::CallSettings callSettings = null) =>
            GetChangelog(new GetChangelogRequest
            {
                ChangelogName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified Changelog.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the changelog to get.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/changelogs/&lt;ChangelogID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Changelog> GetChangelogAsync(ChangelogName name, gaxgrpc::CallSettings callSettings = null) =>
            GetChangelogAsync(new GetChangelogRequest
            {
                ChangelogName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified Changelog.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the changelog to get.
        /// Format:
        /// `projects/&lt;ProjectID&gt;/locations/&lt;LocationID&gt;/agents/&lt;AgentID&gt;/changelogs/&lt;ChangelogID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Changelog> GetChangelogAsync(ChangelogName name, st::CancellationToken cancellationToken) =>
            GetChangelogAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Changelogs client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Changelogs][google.cloud.dialogflow.cx.v3.Changelog].
    /// </remarks>
    public sealed partial class ChangelogsClientImpl : ChangelogsClient
    {
        private readonly gaxgrpc::ApiCall<ListChangelogsRequest, ListChangelogsResponse> _callListChangelogs;

        private readonly gaxgrpc::ApiCall<GetChangelogRequest, Changelog> _callGetChangelog;

        /// <summary>
        /// Constructs a client wrapper for the Changelogs service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ChangelogsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ChangelogsClientImpl(Changelogs.ChangelogsClient grpcClient, ChangelogsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ChangelogsSettings effectiveSettings = settings ?? ChangelogsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListChangelogs = clientHelper.BuildApiCall<ListChangelogsRequest, ListChangelogsResponse>("ListChangelogs", grpcClient.ListChangelogsAsync, grpcClient.ListChangelogs, effectiveSettings.ListChangelogsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListChangelogs);
            Modify_ListChangelogsApiCall(ref _callListChangelogs);
            _callGetChangelog = clientHelper.BuildApiCall<GetChangelogRequest, Changelog>("GetChangelog", grpcClient.GetChangelogAsync, grpcClient.GetChangelog, effectiveSettings.GetChangelogSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetChangelog);
            Modify_GetChangelogApiCall(ref _callGetChangelog);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListChangelogsApiCall(ref gaxgrpc::ApiCall<ListChangelogsRequest, ListChangelogsResponse> call);

        partial void Modify_GetChangelogApiCall(ref gaxgrpc::ApiCall<GetChangelogRequest, Changelog> call);

        partial void OnConstruction(Changelogs.ChangelogsClient grpcClient, ChangelogsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Changelogs client</summary>
        public override Changelogs.ChangelogsClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListChangelogsRequest(ref ListChangelogsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetChangelogRequest(ref GetChangelogRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the list of Changelogs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Changelog"/> resources.</returns>
        public override gax::PagedEnumerable<ListChangelogsResponse, Changelog> ListChangelogs(ListChangelogsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListChangelogsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListChangelogsRequest, ListChangelogsResponse, Changelog>(_callListChangelogs, request, callSettings);
        }

        /// <summary>
        /// Returns the list of Changelogs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Changelog"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListChangelogsResponse, Changelog> ListChangelogsAsync(ListChangelogsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListChangelogsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListChangelogsRequest, ListChangelogsResponse, Changelog>(_callListChangelogs, request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified Changelog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Changelog GetChangelog(GetChangelogRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetChangelogRequest(ref request, ref callSettings);
            return _callGetChangelog.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified Changelog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Changelog> GetChangelogAsync(GetChangelogRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetChangelogRequest(ref request, ref callSettings);
            return _callGetChangelog.Async(request, callSettings);
        }
    }

    public partial class ListChangelogsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListChangelogsResponse : gaxgrpc::IPageResponse<Changelog>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Changelog> GetEnumerator() => Changelogs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Changelogs
    {
        public partial class ChangelogsClient
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
