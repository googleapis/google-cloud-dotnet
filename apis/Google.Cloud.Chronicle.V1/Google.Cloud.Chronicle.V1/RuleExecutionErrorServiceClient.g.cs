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

namespace Google.Cloud.Chronicle.V1
{
    /// <summary>Settings for <see cref="RuleExecutionErrorServiceClient"/> instances.</summary>
    public sealed partial class RuleExecutionErrorServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="RuleExecutionErrorServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="RuleExecutionErrorServiceSettings"/>.</returns>
        public static RuleExecutionErrorServiceSettings GetDefault() => new RuleExecutionErrorServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="RuleExecutionErrorServiceSettings"/> object with default settings.
        /// </summary>
        public RuleExecutionErrorServiceSettings()
        {
        }

        private RuleExecutionErrorServiceSettings(RuleExecutionErrorServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListRuleExecutionErrorsSettings = existing.ListRuleExecutionErrorsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(RuleExecutionErrorServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RuleExecutionErrorServiceClient.ListRuleExecutionErrors</c> and
        /// <c>RuleExecutionErrorServiceClient.ListRuleExecutionErrorsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 600000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListRuleExecutionErrorsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(600000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="RuleExecutionErrorServiceSettings"/> object.</returns>
        public RuleExecutionErrorServiceSettings Clone() => new RuleExecutionErrorServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RuleExecutionErrorServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class RuleExecutionErrorServiceClientBuilder : gaxgrpc::ClientBuilderBase<RuleExecutionErrorServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RuleExecutionErrorServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public RuleExecutionErrorServiceClientBuilder() : base(RuleExecutionErrorServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref RuleExecutionErrorServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RuleExecutionErrorServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override RuleExecutionErrorServiceClient Build()
        {
            RuleExecutionErrorServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RuleExecutionErrorServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RuleExecutionErrorServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RuleExecutionErrorServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RuleExecutionErrorServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<RuleExecutionErrorServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RuleExecutionErrorServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => RuleExecutionErrorServiceClient.ChannelPool;
    }

    /// <summary>RuleExecutionErrorService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// RuleExecutionErrorService contains endpoints related to rule execution
    /// errors.
    /// </remarks>
    public abstract partial class RuleExecutionErrorServiceClient
    {
        /// <summary>
        /// The default endpoint for the RuleExecutionErrorService service, which is a host of
        /// "chronicle.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "chronicle.googleapis.com:443";

        /// <summary>The default RuleExecutionErrorService scopes.</summary>
        /// <remarks>
        /// The default RuleExecutionErrorService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/chronicle</description></item>
        /// <item><description>https://www.googleapis.com/auth/chronicle.readonly</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/chronicle",
            "https://www.googleapis.com/auth/chronicle.readonly",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(RuleExecutionErrorService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="RuleExecutionErrorServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="RuleExecutionErrorServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="RuleExecutionErrorServiceClient"/>.</returns>
        public static stt::Task<RuleExecutionErrorServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RuleExecutionErrorServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RuleExecutionErrorServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="RuleExecutionErrorServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="RuleExecutionErrorServiceClient"/>.</returns>
        public static RuleExecutionErrorServiceClient Create() => new RuleExecutionErrorServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RuleExecutionErrorServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RuleExecutionErrorServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="RuleExecutionErrorServiceClient"/>.</returns>
        internal static RuleExecutionErrorServiceClient Create(grpccore::CallInvoker callInvoker, RuleExecutionErrorServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            RuleExecutionErrorService.RuleExecutionErrorServiceClient grpcClient = new RuleExecutionErrorService.RuleExecutionErrorServiceClient(callInvoker);
            return new RuleExecutionErrorServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC RuleExecutionErrorService client</summary>
        public virtual RuleExecutionErrorService.RuleExecutionErrorServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists rule execution errors.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RuleExecutionError"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRuleExecutionErrorsResponse, RuleExecutionError> ListRuleExecutionErrors(ListRuleExecutionErrorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists rule execution errors.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RuleExecutionError"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRuleExecutionErrorsResponse, RuleExecutionError> ListRuleExecutionErrorsAsync(ListRuleExecutionErrorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists rule execution errors.
        /// </summary>
        /// <param name="parent">
        /// Required. The instance to list rule execution errors from.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}
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
        /// <returns>A pageable sequence of <see cref="RuleExecutionError"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRuleExecutionErrorsResponse, RuleExecutionError> ListRuleExecutionErrors(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRuleExecutionErrorsRequest request = new ListRuleExecutionErrorsRequest
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
            return ListRuleExecutionErrors(request, callSettings);
        }

        /// <summary>
        /// Lists rule execution errors.
        /// </summary>
        /// <param name="parent">
        /// Required. The instance to list rule execution errors from.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}
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
        /// <returns>A pageable asynchronous sequence of <see cref="RuleExecutionError"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRuleExecutionErrorsResponse, RuleExecutionError> ListRuleExecutionErrorsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRuleExecutionErrorsRequest request = new ListRuleExecutionErrorsRequest
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
            return ListRuleExecutionErrorsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists rule execution errors.
        /// </summary>
        /// <param name="parent">
        /// Required. The instance to list rule execution errors from.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}
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
        /// <returns>A pageable sequence of <see cref="RuleExecutionError"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRuleExecutionErrorsResponse, RuleExecutionError> ListRuleExecutionErrors(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRuleExecutionErrorsRequest request = new ListRuleExecutionErrorsRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRuleExecutionErrors(request, callSettings);
        }

        /// <summary>
        /// Lists rule execution errors.
        /// </summary>
        /// <param name="parent">
        /// Required. The instance to list rule execution errors from.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}
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
        /// <returns>A pageable asynchronous sequence of <see cref="RuleExecutionError"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRuleExecutionErrorsResponse, RuleExecutionError> ListRuleExecutionErrorsAsync(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRuleExecutionErrorsRequest request = new ListRuleExecutionErrorsRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRuleExecutionErrorsAsync(request, callSettings);
        }
    }

    /// <summary>RuleExecutionErrorService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// RuleExecutionErrorService contains endpoints related to rule execution
    /// errors.
    /// </remarks>
    public sealed partial class RuleExecutionErrorServiceClientImpl : RuleExecutionErrorServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListRuleExecutionErrorsRequest, ListRuleExecutionErrorsResponse> _callListRuleExecutionErrors;

        /// <summary>
        /// Constructs a client wrapper for the RuleExecutionErrorService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="RuleExecutionErrorServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public RuleExecutionErrorServiceClientImpl(RuleExecutionErrorService.RuleExecutionErrorServiceClient grpcClient, RuleExecutionErrorServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            RuleExecutionErrorServiceSettings effectiveSettings = settings ?? RuleExecutionErrorServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callListRuleExecutionErrors = clientHelper.BuildApiCall<ListRuleExecutionErrorsRequest, ListRuleExecutionErrorsResponse>("ListRuleExecutionErrors", grpcClient.ListRuleExecutionErrorsAsync, grpcClient.ListRuleExecutionErrors, effectiveSettings.ListRuleExecutionErrorsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRuleExecutionErrors);
            Modify_ListRuleExecutionErrorsApiCall(ref _callListRuleExecutionErrors);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListRuleExecutionErrorsApiCall(ref gaxgrpc::ApiCall<ListRuleExecutionErrorsRequest, ListRuleExecutionErrorsResponse> call);

        partial void OnConstruction(RuleExecutionErrorService.RuleExecutionErrorServiceClient grpcClient, RuleExecutionErrorServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC RuleExecutionErrorService client</summary>
        public override RuleExecutionErrorService.RuleExecutionErrorServiceClient GrpcClient { get; }

        partial void Modify_ListRuleExecutionErrorsRequest(ref ListRuleExecutionErrorsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists rule execution errors.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RuleExecutionError"/> resources.</returns>
        public override gax::PagedEnumerable<ListRuleExecutionErrorsResponse, RuleExecutionError> ListRuleExecutionErrors(ListRuleExecutionErrorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRuleExecutionErrorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRuleExecutionErrorsRequest, ListRuleExecutionErrorsResponse, RuleExecutionError>(_callListRuleExecutionErrors, request, callSettings);
        }

        /// <summary>
        /// Lists rule execution errors.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RuleExecutionError"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRuleExecutionErrorsResponse, RuleExecutionError> ListRuleExecutionErrorsAsync(ListRuleExecutionErrorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRuleExecutionErrorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRuleExecutionErrorsRequest, ListRuleExecutionErrorsResponse, RuleExecutionError>(_callListRuleExecutionErrors, request, callSettings);
        }
    }

    public partial class ListRuleExecutionErrorsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRuleExecutionErrorsResponse : gaxgrpc::IPageResponse<RuleExecutionError>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<RuleExecutionError> GetEnumerator() => RuleExecutionErrors.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
