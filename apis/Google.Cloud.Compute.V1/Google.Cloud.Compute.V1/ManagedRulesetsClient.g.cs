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

namespace Google.Cloud.Compute.V1
{
    /// <summary>Settings for <see cref="ManagedRulesetsClient"/> instances.</summary>
    public sealed partial class ManagedRulesetsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ManagedRulesetsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ManagedRulesetsSettings"/>.</returns>
        public static ManagedRulesetsSettings GetDefault() => new ManagedRulesetsSettings();

        /// <summary>Constructs a new <see cref="ManagedRulesetsSettings"/> object with default settings.</summary>
        public ManagedRulesetsSettings()
        {
        }

        private ManagedRulesetsSettings(ManagedRulesetsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetSettings = existing.GetSettings;
            ListSettings = existing.ListSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ManagedRulesetsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ManagedRulesetsClient.Get</c>
        ///  and <c>ManagedRulesetsClient.GetAsync</c>.
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
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ManagedRulesetsClient.List</c>
        ///  and <c>ManagedRulesetsClient.ListAsync</c>.
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
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ManagedRulesetsSettings"/> object.</returns>
        public ManagedRulesetsSettings Clone() => new ManagedRulesetsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ManagedRulesetsClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ManagedRulesetsClientBuilder : gaxgrpc::ClientBuilderBase<ManagedRulesetsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ManagedRulesetsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ManagedRulesetsClientBuilder() : base(ManagedRulesetsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ManagedRulesetsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ManagedRulesetsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ManagedRulesetsClient Build()
        {
            ManagedRulesetsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ManagedRulesetsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ManagedRulesetsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ManagedRulesetsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ManagedRulesetsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ManagedRulesetsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ManagedRulesetsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ManagedRulesetsClient.ChannelPool;
    }

    /// <summary>
    /// ManagedRulesets client wrapper, for convenient use. This client implements API version 2026-09-01.
    /// </summary>
    /// <remarks>
    /// The ManagedRulesets API.
    /// </remarks>
    public abstract partial class ManagedRulesetsClient
    {
        /// <summary>
        /// The default endpoint for the ManagedRulesets service, which is a host of "compute.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default ManagedRulesets scopes.</summary>
        /// <remarks>
        /// The default ManagedRulesets scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/compute.readonly</description></item>
        /// <item><description>https://www.googleapis.com/auth/compute</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/compute.readonly",
            "https://www.googleapis.com/auth/compute",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ManagedRulesets.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ManagedRulesetsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ManagedRulesetsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ManagedRulesetsClient"/>.</returns>
        public static stt::Task<ManagedRulesetsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ManagedRulesetsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ManagedRulesetsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ManagedRulesetsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ManagedRulesetsClient"/>.</returns>
        public static ManagedRulesetsClient Create() => new ManagedRulesetsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ManagedRulesetsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ManagedRulesetsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ManagedRulesetsClient"/>.</returns>
        internal static ManagedRulesetsClient Create(grpccore::CallInvoker callInvoker, ManagedRulesetsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ManagedRulesets.ManagedRulesetsClient grpcClient = new ManagedRulesets.ManagedRulesetsClient(callInvoker);
            return new ManagedRulesetsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ManagedRulesets client</summary>
        public virtual ManagedRulesets.ManagedRulesetsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details for the specified managed ruleset name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ManagedRuleset Get(GetManagedRulesetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details for the specified managed ruleset name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagedRuleset> GetAsync(GetManagedRulesetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details for the specified managed ruleset name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagedRuleset> GetAsync(GetManagedRulesetRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details for the specified managed ruleset name.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="managedRuleset">
        /// Name of the managed ruleset to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ManagedRuleset Get(string project, string managedRuleset, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetManagedRulesetRequest
            {
                ManagedRuleset = gax::GaxPreconditions.CheckNotNullOrEmpty(managedRuleset, nameof(managedRuleset)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Gets the details for the specified managed ruleset name.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="managedRuleset">
        /// Name of the managed ruleset to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagedRuleset> GetAsync(string project, string managedRuleset, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetManagedRulesetRequest
            {
                ManagedRuleset = gax::GaxPreconditions.CheckNotNullOrEmpty(managedRuleset, nameof(managedRuleset)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Gets the details for the specified managed ruleset name.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="managedRuleset">
        /// Name of the managed ruleset to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagedRuleset> GetAsync(string project, string managedRuleset, st::CancellationToken cancellationToken) =>
            GetAsync(project, managedRuleset, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the list of all the managed rulesets available.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ManagedRuleset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ManagedRulesetList, ManagedRuleset> List(ListManagedRulesetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of all the managed rulesets available.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ManagedRuleset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ManagedRulesetList, ManagedRuleset> ListAsync(ListManagedRulesetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of all the managed rulesets available.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
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
        /// <returns>A pageable sequence of <see cref="ManagedRuleset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ManagedRulesetList, ManagedRuleset> List(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListManagedRulesetsRequest request = new ListManagedRulesetsRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return List(request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of all the managed rulesets available.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ManagedRuleset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ManagedRulesetList, ManagedRuleset> ListAsync(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListManagedRulesetsRequest request = new ListManagedRulesetsRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAsync(request, callSettings);
        }
    }

    /// <summary>ManagedRulesets client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The ManagedRulesets API.
    /// </remarks>
    public sealed partial class ManagedRulesetsClientImpl : ManagedRulesetsClient
    {
        private readonly gaxgrpc::ApiCall<GetManagedRulesetRequest, ManagedRuleset> _callGet;

        private readonly gaxgrpc::ApiCall<ListManagedRulesetsRequest, ManagedRulesetList> _callList;

        /// <summary>
        /// Constructs a client wrapper for the ManagedRulesets service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ManagedRulesetsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ManagedRulesetsClientImpl(ManagedRulesets.ManagedRulesetsClient grpcClient, ManagedRulesetsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ManagedRulesetsSettings effectiveSettings = settings ?? ManagedRulesetsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
                ApiVersion = "2026-09-01",
            });
            _callGet = clientHelper.BuildApiCall<GetManagedRulesetRequest, ManagedRuleset>("Get", grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("managed_ruleset", request => request.ManagedRuleset);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callList = clientHelper.BuildApiCall<ListManagedRulesetsRequest, ManagedRulesetList>("List", grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetManagedRulesetRequest, ManagedRuleset> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListManagedRulesetsRequest, ManagedRulesetList> call);

        partial void OnConstruction(ManagedRulesets.ManagedRulesetsClient grpcClient, ManagedRulesetsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ManagedRulesets client</summary>
        public override ManagedRulesets.ManagedRulesetsClient GrpcClient { get; }

        partial void Modify_GetManagedRulesetRequest(ref GetManagedRulesetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListManagedRulesetsRequest(ref ListManagedRulesetsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets the details for the specified managed ruleset name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ManagedRuleset Get(GetManagedRulesetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetManagedRulesetRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the details for the specified managed ruleset name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ManagedRuleset> GetAsync(GetManagedRulesetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetManagedRulesetRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of all the managed rulesets available.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ManagedRuleset"/> resources.</returns>
        public override gax::PagedEnumerable<ManagedRulesetList, ManagedRuleset> List(ListManagedRulesetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListManagedRulesetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListManagedRulesetsRequest, ManagedRulesetList, ManagedRuleset>(_callList, request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of all the managed rulesets available.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ManagedRuleset"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ManagedRulesetList, ManagedRuleset> ListAsync(ListManagedRulesetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListManagedRulesetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListManagedRulesetsRequest, ManagedRulesetList, ManagedRuleset>(_callList, request, callSettings);
        }
    }

    public partial class ListManagedRulesetsRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class ManagedRulesetList : gaxgrpc::IPageResponse<ManagedRuleset>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ManagedRuleset> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
