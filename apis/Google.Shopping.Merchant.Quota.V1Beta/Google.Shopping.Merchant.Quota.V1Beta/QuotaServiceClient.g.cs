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

namespace Google.Shopping.Merchant.Quota.V1Beta
{
    /// <summary>Settings for <see cref="QuotaServiceClient"/> instances.</summary>
    public sealed partial class QuotaServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="QuotaServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="QuotaServiceSettings"/>.</returns>
        public static QuotaServiceSettings GetDefault() => new QuotaServiceSettings();

        /// <summary>Constructs a new <see cref="QuotaServiceSettings"/> object with default settings.</summary>
        public QuotaServiceSettings()
        {
        }

        private QuotaServiceSettings(QuotaServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListQuotaGroupsSettings = existing.ListQuotaGroupsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(QuotaServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>QuotaServiceClient.ListQuotaGroups</c> and <c>QuotaServiceClient.ListQuotaGroupsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListQuotaGroupsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="QuotaServiceSettings"/> object.</returns>
        public QuotaServiceSettings Clone() => new QuotaServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="QuotaServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class QuotaServiceClientBuilder : gaxgrpc::ClientBuilderBase<QuotaServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public QuotaServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public QuotaServiceClientBuilder() : base(QuotaServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref QuotaServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<QuotaServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override QuotaServiceClient Build()
        {
            QuotaServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<QuotaServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<QuotaServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private QuotaServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return QuotaServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<QuotaServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return QuotaServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => QuotaServiceClient.ChannelPool;
    }

    /// <summary>QuotaService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to get method call quota information per Merchant API method.
    /// </remarks>
    public abstract partial class QuotaServiceClient
    {
        /// <summary>
        /// The default endpoint for the QuotaService service, which is a host of "merchantapi.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default QuotaService scopes.</summary>
        /// <remarks>
        /// The default QuotaService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(QuotaService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="QuotaServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="QuotaServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="QuotaServiceClient"/>.</returns>
        public static stt::Task<QuotaServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new QuotaServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="QuotaServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="QuotaServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="QuotaServiceClient"/>.</returns>
        public static QuotaServiceClient Create() => new QuotaServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="QuotaServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="QuotaServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="QuotaServiceClient"/>.</returns>
        internal static QuotaServiceClient Create(grpccore::CallInvoker callInvoker, QuotaServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            QuotaService.QuotaServiceClient grpcClient = new QuotaService.QuotaServiceClient(callInvoker);
            return new QuotaServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC QuotaService client</summary>
        public virtual QuotaService.QuotaServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the daily call quota and usage per group for your Merchant
        /// Center account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="QuotaGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListQuotaGroupsResponse, QuotaGroup> ListQuotaGroups(ListQuotaGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the daily call quota and usage per group for your Merchant
        /// Center account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="QuotaGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListQuotaGroupsResponse, QuotaGroup> ListQuotaGroupsAsync(ListQuotaGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the daily call quota and usage per group for your Merchant
        /// Center account.
        /// </summary>
        /// <param name="parent">
        /// Required. The merchant account who owns the collection of method quotas
        /// Format: accounts/{account}
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
        /// <returns>A pageable sequence of <see cref="QuotaGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListQuotaGroupsResponse, QuotaGroup> ListQuotaGroups(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListQuotaGroupsRequest request = new ListQuotaGroupsRequest
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
            return ListQuotaGroups(request, callSettings);
        }

        /// <summary>
        /// Lists the daily call quota and usage per group for your Merchant
        /// Center account.
        /// </summary>
        /// <param name="parent">
        /// Required. The merchant account who owns the collection of method quotas
        /// Format: accounts/{account}
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
        /// <returns>A pageable asynchronous sequence of <see cref="QuotaGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListQuotaGroupsResponse, QuotaGroup> ListQuotaGroupsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListQuotaGroupsRequest request = new ListQuotaGroupsRequest
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
            return ListQuotaGroupsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the daily call quota and usage per group for your Merchant
        /// Center account.
        /// </summary>
        /// <param name="parent">
        /// Required. The merchant account who owns the collection of method quotas
        /// Format: accounts/{account}
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
        /// <returns>A pageable sequence of <see cref="QuotaGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListQuotaGroupsResponse, QuotaGroup> ListQuotaGroups(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListQuotaGroupsRequest request = new ListQuotaGroupsRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListQuotaGroups(request, callSettings);
        }

        /// <summary>
        /// Lists the daily call quota and usage per group for your Merchant
        /// Center account.
        /// </summary>
        /// <param name="parent">
        /// Required. The merchant account who owns the collection of method quotas
        /// Format: accounts/{account}
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
        /// <returns>A pageable asynchronous sequence of <see cref="QuotaGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListQuotaGroupsResponse, QuotaGroup> ListQuotaGroupsAsync(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListQuotaGroupsRequest request = new ListQuotaGroupsRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListQuotaGroupsAsync(request, callSettings);
        }
    }

    /// <summary>QuotaService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to get method call quota information per Merchant API method.
    /// </remarks>
    public sealed partial class QuotaServiceClientImpl : QuotaServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListQuotaGroupsRequest, ListQuotaGroupsResponse> _callListQuotaGroups;

        /// <summary>
        /// Constructs a client wrapper for the QuotaService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="QuotaServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public QuotaServiceClientImpl(QuotaService.QuotaServiceClient grpcClient, QuotaServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            QuotaServiceSettings effectiveSettings = settings ?? QuotaServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callListQuotaGroups = clientHelper.BuildApiCall<ListQuotaGroupsRequest, ListQuotaGroupsResponse>("ListQuotaGroups", grpcClient.ListQuotaGroupsAsync, grpcClient.ListQuotaGroups, effectiveSettings.ListQuotaGroupsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListQuotaGroups);
            Modify_ListQuotaGroupsApiCall(ref _callListQuotaGroups);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListQuotaGroupsApiCall(ref gaxgrpc::ApiCall<ListQuotaGroupsRequest, ListQuotaGroupsResponse> call);

        partial void OnConstruction(QuotaService.QuotaServiceClient grpcClient, QuotaServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC QuotaService client</summary>
        public override QuotaService.QuotaServiceClient GrpcClient { get; }

        partial void Modify_ListQuotaGroupsRequest(ref ListQuotaGroupsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists the daily call quota and usage per group for your Merchant
        /// Center account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="QuotaGroup"/> resources.</returns>
        public override gax::PagedEnumerable<ListQuotaGroupsResponse, QuotaGroup> ListQuotaGroups(ListQuotaGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListQuotaGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListQuotaGroupsRequest, ListQuotaGroupsResponse, QuotaGroup>(_callListQuotaGroups, request, callSettings);
        }

        /// <summary>
        /// Lists the daily call quota and usage per group for your Merchant
        /// Center account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="QuotaGroup"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListQuotaGroupsResponse, QuotaGroup> ListQuotaGroupsAsync(ListQuotaGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListQuotaGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListQuotaGroupsRequest, ListQuotaGroupsResponse, QuotaGroup>(_callListQuotaGroups, request, callSettings);
        }
    }

    public partial class ListQuotaGroupsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListQuotaGroupsResponse : gaxgrpc::IPageResponse<QuotaGroup>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<QuotaGroup> GetEnumerator() => QuotaGroups.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
