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
using gagr = Google.Api.Gax.ResourceNames;
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

namespace Google.Cloud.CapacityPlanner.V1Beta
{
    /// <summary>Settings for <see cref="CapacityPlanningServiceClient"/> instances.</summary>
    public sealed partial class CapacityPlanningServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CapacityPlanningServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CapacityPlanningServiceSettings"/>.</returns>
        public static CapacityPlanningServiceSettings GetDefault() => new CapacityPlanningServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CapacityPlanningServiceSettings"/> object with default settings.
        /// </summary>
        public CapacityPlanningServiceSettings()
        {
        }

        private CapacityPlanningServiceSettings(CapacityPlanningServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCapacityPlanSettings = existing.GetCapacityPlanSettings;
            QueryCapacityPlansSettings = existing.QueryCapacityPlansSettings;
            QueryCapacityPlanInsightsSettings = existing.QueryCapacityPlanInsightsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CapacityPlanningServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CapacityPlanningServiceClient.GetCapacityPlan</c> and
        /// <c>CapacityPlanningServiceClient.GetCapacityPlanAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCapacityPlanSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CapacityPlanningServiceClient.QueryCapacityPlans</c> and
        /// <c>CapacityPlanningServiceClient.QueryCapacityPlansAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings QueryCapacityPlansSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CapacityPlanningServiceClient.QueryCapacityPlanInsights</c> and
        /// <c>CapacityPlanningServiceClient.QueryCapacityPlanInsightsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>, <see cref="grpccore::StatusCode.Internal"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings QueryCapacityPlanInsightsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CapacityPlanningServiceSettings"/> object.</returns>
        public CapacityPlanningServiceSettings Clone() => new CapacityPlanningServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CapacityPlanningServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class CapacityPlanningServiceClientBuilder : gaxgrpc::ClientBuilderBase<CapacityPlanningServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CapacityPlanningServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CapacityPlanningServiceClientBuilder() : base(CapacityPlanningServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CapacityPlanningServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CapacityPlanningServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CapacityPlanningServiceClient Build()
        {
            CapacityPlanningServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CapacityPlanningServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CapacityPlanningServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CapacityPlanningServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CapacityPlanningServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CapacityPlanningServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CapacityPlanningServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CapacityPlanningServiceClient.ChannelPool;
    }

    /// <summary>CapacityPlanningService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// This API allows users to plan for GCP capacity associated with their
    /// projects. Users can request additional capacity for GCP resources such as
    /// VMs, PDs, etc.
    /// </remarks>
    public abstract partial class CapacityPlanningServiceClient
    {
        /// <summary>
        /// The default endpoint for the CapacityPlanningService service, which is a host of
        /// "capacityplanner.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "capacityplanner.googleapis.com:443";

        /// <summary>The default CapacityPlanningService scopes.</summary>
        /// <remarks>
        /// The default CapacityPlanningService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/devstorage.full_control</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/devstorage.full_control",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CapacityPlanningService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CapacityPlanningServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CapacityPlanningServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CapacityPlanningServiceClient"/>.</returns>
        public static stt::Task<CapacityPlanningServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CapacityPlanningServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CapacityPlanningServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CapacityPlanningServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CapacityPlanningServiceClient"/>.</returns>
        public static CapacityPlanningServiceClient Create() => new CapacityPlanningServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CapacityPlanningServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CapacityPlanningServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CapacityPlanningServiceClient"/>.</returns>
        internal static CapacityPlanningServiceClient Create(grpccore::CallInvoker callInvoker, CapacityPlanningServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CapacityPlanningService.CapacityPlanningServiceClient grpcClient = new CapacityPlanningService.CapacityPlanningServiceClient(callInvoker);
            return new CapacityPlanningServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CapacityPlanningService client</summary>
        public virtual CapacityPlanningService.CapacityPlanningServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns information about the capacity plan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CapacityPlan GetCapacityPlan(GetCapacityPlanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns information about the capacity plan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CapacityPlan> GetCapacityPlanAsync(GetCapacityPlanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns information about the capacity plan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CapacityPlan> GetCapacityPlanAsync(GetCapacityPlanRequest request, st::CancellationToken cancellationToken) =>
            GetCapacityPlanAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns information about the capacity plan.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the capacity plan to retrieve.
        /// Format: projects/{project}/capacityPlans/{capacity_plan}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CapacityPlan GetCapacityPlan(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCapacityPlan(new GetCapacityPlanRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns information about the capacity plan.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the capacity plan to retrieve.
        /// Format: projects/{project}/capacityPlans/{capacity_plan}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CapacityPlan> GetCapacityPlanAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCapacityPlanAsync(new GetCapacityPlanRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns information about the capacity plan.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the capacity plan to retrieve.
        /// Format: projects/{project}/capacityPlans/{capacity_plan}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CapacityPlan> GetCapacityPlanAsync(string name, st::CancellationToken cancellationToken) =>
            GetCapacityPlanAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns information about the capacity plan.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the capacity plan to retrieve.
        /// Format: projects/{project}/capacityPlans/{capacity_plan}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CapacityPlan GetCapacityPlan(CapacityPlanName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCapacityPlan(new GetCapacityPlanRequest
            {
                CapacityPlanName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns information about the capacity plan.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the capacity plan to retrieve.
        /// Format: projects/{project}/capacityPlans/{capacity_plan}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CapacityPlan> GetCapacityPlanAsync(CapacityPlanName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCapacityPlanAsync(new GetCapacityPlanRequest
            {
                CapacityPlanName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns information about the capacity plan.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the capacity plan to retrieve.
        /// Format: projects/{project}/capacityPlans/{capacity_plan}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CapacityPlan> GetCapacityPlanAsync(CapacityPlanName name, st::CancellationToken cancellationToken) =>
            GetCapacityPlanAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of the capacity plans that are in the parent parameter and
        /// match your specified filters.
        /// (The maximum list length is limited by the pageSize parameter.)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CapacityPlan"/> resources.</returns>
        public virtual gax::PagedEnumerable<QueryCapacityPlansResponse, CapacityPlan> QueryCapacityPlans(QueryCapacityPlansRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of the capacity plans that are in the parent parameter and
        /// match your specified filters.
        /// (The maximum list length is limited by the pageSize parameter.)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CapacityPlan"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<QueryCapacityPlansResponse, CapacityPlan> QueryCapacityPlansAsync(QueryCapacityPlansRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of the capacity plans that are in the parent parameter and
        /// match your specified filters.
        /// (The maximum list length is limited by the pageSize parameter.)
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource container.
        /// Format:
        /// projects/{project} or
        /// folders/{folder} or
        /// organizations/{organization}
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
        /// <returns>A pageable sequence of <see cref="CapacityPlan"/> resources.</returns>
        public virtual gax::PagedEnumerable<QueryCapacityPlansResponse, CapacityPlan> QueryCapacityPlans(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            QueryCapacityPlansRequest request = new QueryCapacityPlansRequest
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
            return QueryCapacityPlans(request, callSettings);
        }

        /// <summary>
        /// Returns a list of the capacity plans that are in the parent parameter and
        /// match your specified filters.
        /// (The maximum list length is limited by the pageSize parameter.)
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource container.
        /// Format:
        /// projects/{project} or
        /// folders/{folder} or
        /// organizations/{organization}
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
        /// <returns>A pageable asynchronous sequence of <see cref="CapacityPlan"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<QueryCapacityPlansResponse, CapacityPlan> QueryCapacityPlansAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            QueryCapacityPlansRequest request = new QueryCapacityPlansRequest
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
            return QueryCapacityPlansAsync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of the capacity plans that are in the parent parameter and
        /// match your specified filters.
        /// (The maximum list length is limited by the pageSize parameter.)
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource container.
        /// Format:
        /// projects/{project} or
        /// folders/{folder} or
        /// organizations/{organization}
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
        /// <returns>A pageable sequence of <see cref="CapacityPlan"/> resources.</returns>
        public virtual gax::PagedEnumerable<QueryCapacityPlansResponse, CapacityPlan> QueryCapacityPlans(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            QueryCapacityPlansRequest request = new QueryCapacityPlansRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return QueryCapacityPlans(request, callSettings);
        }

        /// <summary>
        /// Returns a list of the capacity plans that are in the parent parameter and
        /// match your specified filters.
        /// (The maximum list length is limited by the pageSize parameter.)
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource container.
        /// Format:
        /// projects/{project} or
        /// folders/{folder} or
        /// organizations/{organization}
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
        /// <returns>A pageable asynchronous sequence of <see cref="CapacityPlan"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<QueryCapacityPlansResponse, CapacityPlan> QueryCapacityPlansAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            QueryCapacityPlansRequest request = new QueryCapacityPlansRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return QueryCapacityPlansAsync(request, callSettings);
        }

        /// <summary>
        /// Query capacity plan insights that are in the parent parameter and match
        /// your specified filters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QueryCapacityPlanInsightsResponse QueryCapacityPlanInsights(QueryCapacityPlanInsightsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Query capacity plan insights that are in the parent parameter and match
        /// your specified filters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryCapacityPlanInsightsResponse> QueryCapacityPlanInsightsAsync(QueryCapacityPlanInsightsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Query capacity plan insights that are in the parent parameter and match
        /// your specified filters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryCapacityPlanInsightsResponse> QueryCapacityPlanInsightsAsync(QueryCapacityPlanInsightsRequest request, st::CancellationToken cancellationToken) =>
            QueryCapacityPlanInsightsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Query capacity plan insights that are in the parent parameter and match
        /// your specified filters.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource container.
        /// Format: projects/{project}
        /// </param>
        /// <param name="capacityPlanFilters">
        /// Required. The filters to apply to the capacity plan.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QueryCapacityPlanInsightsResponse QueryCapacityPlanInsights(string parent, CapacityPlanFilters capacityPlanFilters, gaxgrpc::CallSettings callSettings = null) =>
            QueryCapacityPlanInsights(new QueryCapacityPlanInsightsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CapacityPlanFilters = gax::GaxPreconditions.CheckNotNull(capacityPlanFilters, nameof(capacityPlanFilters)),
            }, callSettings);

        /// <summary>
        /// Query capacity plan insights that are in the parent parameter and match
        /// your specified filters.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource container.
        /// Format: projects/{project}
        /// </param>
        /// <param name="capacityPlanFilters">
        /// Required. The filters to apply to the capacity plan.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryCapacityPlanInsightsResponse> QueryCapacityPlanInsightsAsync(string parent, CapacityPlanFilters capacityPlanFilters, gaxgrpc::CallSettings callSettings = null) =>
            QueryCapacityPlanInsightsAsync(new QueryCapacityPlanInsightsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CapacityPlanFilters = gax::GaxPreconditions.CheckNotNull(capacityPlanFilters, nameof(capacityPlanFilters)),
            }, callSettings);

        /// <summary>
        /// Query capacity plan insights that are in the parent parameter and match
        /// your specified filters.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource container.
        /// Format: projects/{project}
        /// </param>
        /// <param name="capacityPlanFilters">
        /// Required. The filters to apply to the capacity plan.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryCapacityPlanInsightsResponse> QueryCapacityPlanInsightsAsync(string parent, CapacityPlanFilters capacityPlanFilters, st::CancellationToken cancellationToken) =>
            QueryCapacityPlanInsightsAsync(parent, capacityPlanFilters, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CapacityPlanningService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// This API allows users to plan for GCP capacity associated with their
    /// projects. Users can request additional capacity for GCP resources such as
    /// VMs, PDs, etc.
    /// </remarks>
    public sealed partial class CapacityPlanningServiceClientImpl : CapacityPlanningServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCapacityPlanRequest, CapacityPlan> _callGetCapacityPlan;

        private readonly gaxgrpc::ApiCall<QueryCapacityPlansRequest, QueryCapacityPlansResponse> _callQueryCapacityPlans;

        private readonly gaxgrpc::ApiCall<QueryCapacityPlanInsightsRequest, QueryCapacityPlanInsightsResponse> _callQueryCapacityPlanInsights;

        /// <summary>
        /// Constructs a client wrapper for the CapacityPlanningService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CapacityPlanningServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CapacityPlanningServiceClientImpl(CapacityPlanningService.CapacityPlanningServiceClient grpcClient, CapacityPlanningServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CapacityPlanningServiceSettings effectiveSettings = settings ?? CapacityPlanningServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetCapacityPlan = clientHelper.BuildApiCall<GetCapacityPlanRequest, CapacityPlan>("GetCapacityPlan", grpcClient.GetCapacityPlanAsync, grpcClient.GetCapacityPlan, effectiveSettings.GetCapacityPlanSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCapacityPlan);
            Modify_GetCapacityPlanApiCall(ref _callGetCapacityPlan);
            _callQueryCapacityPlans = clientHelper.BuildApiCall<QueryCapacityPlansRequest, QueryCapacityPlansResponse>("QueryCapacityPlans", grpcClient.QueryCapacityPlansAsync, grpcClient.QueryCapacityPlans, effectiveSettings.QueryCapacityPlansSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callQueryCapacityPlans);
            Modify_QueryCapacityPlansApiCall(ref _callQueryCapacityPlans);
            _callQueryCapacityPlanInsights = clientHelper.BuildApiCall<QueryCapacityPlanInsightsRequest, QueryCapacityPlanInsightsResponse>("QueryCapacityPlanInsights", grpcClient.QueryCapacityPlanInsightsAsync, grpcClient.QueryCapacityPlanInsights, effectiveSettings.QueryCapacityPlanInsightsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callQueryCapacityPlanInsights);
            Modify_QueryCapacityPlanInsightsApiCall(ref _callQueryCapacityPlanInsights);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetCapacityPlanApiCall(ref gaxgrpc::ApiCall<GetCapacityPlanRequest, CapacityPlan> call);

        partial void Modify_QueryCapacityPlansApiCall(ref gaxgrpc::ApiCall<QueryCapacityPlansRequest, QueryCapacityPlansResponse> call);

        partial void Modify_QueryCapacityPlanInsightsApiCall(ref gaxgrpc::ApiCall<QueryCapacityPlanInsightsRequest, QueryCapacityPlanInsightsResponse> call);

        partial void OnConstruction(CapacityPlanningService.CapacityPlanningServiceClient grpcClient, CapacityPlanningServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CapacityPlanningService client</summary>
        public override CapacityPlanningService.CapacityPlanningServiceClient GrpcClient { get; }

        partial void Modify_GetCapacityPlanRequest(ref GetCapacityPlanRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_QueryCapacityPlansRequest(ref QueryCapacityPlansRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_QueryCapacityPlanInsightsRequest(ref QueryCapacityPlanInsightsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns information about the capacity plan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CapacityPlan GetCapacityPlan(GetCapacityPlanRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCapacityPlanRequest(ref request, ref callSettings);
            return _callGetCapacityPlan.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns information about the capacity plan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CapacityPlan> GetCapacityPlanAsync(GetCapacityPlanRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCapacityPlanRequest(ref request, ref callSettings);
            return _callGetCapacityPlan.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a list of the capacity plans that are in the parent parameter and
        /// match your specified filters.
        /// (The maximum list length is limited by the pageSize parameter.)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CapacityPlan"/> resources.</returns>
        public override gax::PagedEnumerable<QueryCapacityPlansResponse, CapacityPlan> QueryCapacityPlans(QueryCapacityPlansRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryCapacityPlansRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<QueryCapacityPlansRequest, QueryCapacityPlansResponse, CapacityPlan>(_callQueryCapacityPlans, request, callSettings);
        }

        /// <summary>
        /// Returns a list of the capacity plans that are in the parent parameter and
        /// match your specified filters.
        /// (The maximum list length is limited by the pageSize parameter.)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CapacityPlan"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<QueryCapacityPlansResponse, CapacityPlan> QueryCapacityPlansAsync(QueryCapacityPlansRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryCapacityPlansRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<QueryCapacityPlansRequest, QueryCapacityPlansResponse, CapacityPlan>(_callQueryCapacityPlans, request, callSettings);
        }

        /// <summary>
        /// Query capacity plan insights that are in the parent parameter and match
        /// your specified filters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override QueryCapacityPlanInsightsResponse QueryCapacityPlanInsights(QueryCapacityPlanInsightsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryCapacityPlanInsightsRequest(ref request, ref callSettings);
            return _callQueryCapacityPlanInsights.Sync(request, callSettings);
        }

        /// <summary>
        /// Query capacity plan insights that are in the parent parameter and match
        /// your specified filters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<QueryCapacityPlanInsightsResponse> QueryCapacityPlanInsightsAsync(QueryCapacityPlanInsightsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryCapacityPlanInsightsRequest(ref request, ref callSettings);
            return _callQueryCapacityPlanInsights.Async(request, callSettings);
        }
    }

    public partial class QueryCapacityPlansRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class QueryCapacityPlansResponse : gaxgrpc::IPageResponse<CapacityPlan>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CapacityPlan> GetEnumerator() => CapacityPlans.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
