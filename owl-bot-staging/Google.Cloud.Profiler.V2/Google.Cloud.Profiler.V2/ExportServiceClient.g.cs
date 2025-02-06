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

namespace Google.Cloud.Profiler.V2
{
    /// <summary>Settings for <see cref="ExportServiceClient"/> instances.</summary>
    public sealed partial class ExportServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ExportServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ExportServiceSettings"/>.</returns>
        public static ExportServiceSettings GetDefault() => new ExportServiceSettings();

        /// <summary>Constructs a new <see cref="ExportServiceSettings"/> object with default settings.</summary>
        public ExportServiceSettings()
        {
        }

        private ExportServiceSettings(ExportServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListProfilesSettings = existing.ListProfilesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ExportServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExportServiceClient.ListProfiles</c> and <c>ExportServiceClient.ListProfilesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 3</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 130 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListProfilesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(130000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 3, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ExportServiceSettings"/> object.</returns>
        public ExportServiceSettings Clone() => new ExportServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ExportServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ExportServiceClientBuilder : gaxgrpc::ClientBuilderBase<ExportServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ExportServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ExportServiceClientBuilder() : base(ExportServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ExportServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ExportServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ExportServiceClient Build()
        {
            ExportServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ExportServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ExportServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ExportServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ExportServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ExportServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ExportServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ExportServiceClient.ChannelPool;
    }

    /// <summary>ExportService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service allows existing Cloud Profiler customers to export their profile data
    /// out of Google Cloud.
    /// </remarks>
    public abstract partial class ExportServiceClient
    {
        /// <summary>
        /// The default endpoint for the ExportService service, which is a host of "cloudprofiler.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudprofiler.googleapis.com:443";

        /// <summary>The default ExportService scopes.</summary>
        /// <remarks>
        /// The default ExportService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/monitoring</description></item>
        /// <item><description>https://www.googleapis.com/auth/monitoring.write</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/monitoring",
            "https://www.googleapis.com/auth/monitoring.write",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ExportService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ExportServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ExportServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ExportServiceClient"/>.</returns>
        public static stt::Task<ExportServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ExportServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ExportServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ExportServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ExportServiceClient"/>.</returns>
        public static ExportServiceClient Create() => new ExportServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ExportServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ExportServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ExportServiceClient"/>.</returns>
        internal static ExportServiceClient Create(grpccore::CallInvoker callInvoker, ExportServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ExportService.ExportServiceClient grpcClient = new ExportService.ExportServiceClient(callInvoker);
            return new ExportServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ExportService client</summary>
        public virtual ExportService.ExportServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists profiles which have been collected so far and for which the caller
        /// has permission to view.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Profile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProfilesResponse, Profile> ListProfiles(ListProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists profiles which have been collected so far and for which the caller
        /// has permission to view.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Profile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProfilesResponse, Profile> ListProfilesAsync(ListProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists profiles which have been collected so far and for which the caller
        /// has permission to view.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of profiles.
        /// Format: projects/{user_project_id}
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
        /// <returns>A pageable sequence of <see cref="Profile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProfilesResponse, Profile> ListProfiles(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProfilesRequest request = new ListProfilesRequest
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
            return ListProfiles(request, callSettings);
        }

        /// <summary>
        /// Lists profiles which have been collected so far and for which the caller
        /// has permission to view.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of profiles.
        /// Format: projects/{user_project_id}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Profile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProfilesResponse, Profile> ListProfilesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProfilesRequest request = new ListProfilesRequest
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
            return ListProfilesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists profiles which have been collected so far and for which the caller
        /// has permission to view.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of profiles.
        /// Format: projects/{user_project_id}
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
        /// <returns>A pageable sequence of <see cref="Profile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProfilesResponse, Profile> ListProfiles(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProfilesRequest request = new ListProfilesRequest
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
            return ListProfiles(request, callSettings);
        }

        /// <summary>
        /// Lists profiles which have been collected so far and for which the caller
        /// has permission to view.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of profiles.
        /// Format: projects/{user_project_id}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Profile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProfilesResponse, Profile> ListProfilesAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProfilesRequest request = new ListProfilesRequest
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
            return ListProfilesAsync(request, callSettings);
        }
    }

    /// <summary>ExportService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service allows existing Cloud Profiler customers to export their profile data
    /// out of Google Cloud.
    /// </remarks>
    public sealed partial class ExportServiceClientImpl : ExportServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListProfilesRequest, ListProfilesResponse> _callListProfiles;

        /// <summary>
        /// Constructs a client wrapper for the ExportService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ExportServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ExportServiceClientImpl(ExportService.ExportServiceClient grpcClient, ExportServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ExportServiceSettings effectiveSettings = settings ?? ExportServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callListProfiles = clientHelper.BuildApiCall<ListProfilesRequest, ListProfilesResponse>("ListProfiles", grpcClient.ListProfilesAsync, grpcClient.ListProfiles, effectiveSettings.ListProfilesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListProfiles);
            Modify_ListProfilesApiCall(ref _callListProfiles);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListProfilesApiCall(ref gaxgrpc::ApiCall<ListProfilesRequest, ListProfilesResponse> call);

        partial void OnConstruction(ExportService.ExportServiceClient grpcClient, ExportServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ExportService client</summary>
        public override ExportService.ExportServiceClient GrpcClient { get; }

        partial void Modify_ListProfilesRequest(ref ListProfilesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists profiles which have been collected so far and for which the caller
        /// has permission to view.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Profile"/> resources.</returns>
        public override gax::PagedEnumerable<ListProfilesResponse, Profile> ListProfiles(ListProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProfilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListProfilesRequest, ListProfilesResponse, Profile>(_callListProfiles, request, callSettings);
        }

        /// <summary>
        /// Lists profiles which have been collected so far and for which the caller
        /// has permission to view.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Profile"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListProfilesResponse, Profile> ListProfilesAsync(ListProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProfilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListProfilesRequest, ListProfilesResponse, Profile>(_callListProfiles, request, callSettings);
        }
    }

    public partial class ListProfilesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListProfilesResponse : gaxgrpc::IPageResponse<Profile>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Profile> GetEnumerator() => Profiles.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
