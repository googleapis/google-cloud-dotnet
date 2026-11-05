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

namespace Google.Ads.DataManager.V1
{
    /// <summary>Settings for <see cref="ReportingServiceClient"/> instances.</summary>
    public sealed partial class ReportingServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ReportingServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ReportingServiceSettings"/>.</returns>
        public static ReportingServiceSettings GetDefault() => new ReportingServiceSettings();

        /// <summary>Constructs a new <see cref="ReportingServiceSettings"/> object with default settings.</summary>
        public ReportingServiceSettings()
        {
        }

        private ReportingServiceSettings(ReportingServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            RetrievePartnerMatchReportSettings = existing.RetrievePartnerMatchReportSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ReportingServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReportingServiceClient.RetrievePartnerMatchReport</c> and
        /// <c>ReportingServiceClient.RetrievePartnerMatchReportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RetrievePartnerMatchReportSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ReportingServiceSettings"/> object.</returns>
        public ReportingServiceSettings Clone() => new ReportingServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ReportingServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ReportingServiceClientBuilder : gaxgrpc::ClientBuilderBase<ReportingServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ReportingServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ReportingServiceClientBuilder() : base(ReportingServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ReportingServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ReportingServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ReportingServiceClient Build()
        {
            ReportingServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ReportingServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ReportingServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ReportingServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ReportingServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ReportingServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ReportingServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ReportingServiceClient.ChannelPool;
    }

    /// <summary>ReportingService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for querying reports.
    /// </remarks>
    public abstract partial class ReportingServiceClient
    {
        /// <summary>
        /// The default endpoint for the ReportingService service, which is a host of "datamanager.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "datamanager.googleapis.com:443";

        /// <summary>The default ReportingService scopes.</summary>
        /// <remarks>
        /// The default ReportingService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/datamanager</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/datamanager",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ReportingService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ReportingServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ReportingServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ReportingServiceClient"/>.</returns>
        public static stt::Task<ReportingServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ReportingServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ReportingServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ReportingServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ReportingServiceClient"/>.</returns>
        public static ReportingServiceClient Create() => new ReportingServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ReportingServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ReportingServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ReportingServiceClient"/>.</returns>
        internal static ReportingServiceClient Create(grpccore::CallInvoker callInvoker, ReportingServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ReportingService.ReportingServiceClient grpcClient = new ReportingService.ReportingServiceClient(callInvoker);
            return new ReportingServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ReportingService client</summary>
        public virtual ReportingService.ReportingServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a partner match report.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PartnerMatchReportEntry"/> resources.</returns>
        public virtual gax::PagedEnumerable<RetrievePartnerMatchReportResponse, PartnerMatchReportEntry> RetrievePartnerMatchReport(RetrievePartnerMatchReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a partner match report.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PartnerMatchReportEntry"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<RetrievePartnerMatchReportResponse, PartnerMatchReportEntry> RetrievePartnerMatchReportAsync(RetrievePartnerMatchReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a partner match report.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent account that owns the user list.
        /// Format: `accountTypes/{account_type}/accounts/{account}`
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
        /// <returns>A pageable sequence of <see cref="PartnerMatchReportEntry"/> resources.</returns>
        public virtual gax::PagedEnumerable<RetrievePartnerMatchReportResponse, PartnerMatchReportEntry> RetrievePartnerMatchReport(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            RetrievePartnerMatchReportRequest request = new RetrievePartnerMatchReportRequest
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
            return RetrievePartnerMatchReport(request, callSettings);
        }

        /// <summary>
        /// Retrieves a partner match report.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent account that owns the user list.
        /// Format: `accountTypes/{account_type}/accounts/{account}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="PartnerMatchReportEntry"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<RetrievePartnerMatchReportResponse, PartnerMatchReportEntry> RetrievePartnerMatchReportAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            RetrievePartnerMatchReportRequest request = new RetrievePartnerMatchReportRequest
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
            return RetrievePartnerMatchReportAsync(request, callSettings);
        }
    }

    /// <summary>ReportingService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for querying reports.
    /// </remarks>
    public sealed partial class ReportingServiceClientImpl : ReportingServiceClient
    {
        private readonly gaxgrpc::ApiCall<RetrievePartnerMatchReportRequest, RetrievePartnerMatchReportResponse> _callRetrievePartnerMatchReport;

        /// <summary>
        /// Constructs a client wrapper for the ReportingService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ReportingServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ReportingServiceClientImpl(ReportingService.ReportingServiceClient grpcClient, ReportingServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ReportingServiceSettings effectiveSettings = settings ?? ReportingServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callRetrievePartnerMatchReport = clientHelper.BuildApiCall<RetrievePartnerMatchReportRequest, RetrievePartnerMatchReportResponse>("RetrievePartnerMatchReport", grpcClient.RetrievePartnerMatchReportAsync, grpcClient.RetrievePartnerMatchReport, effectiveSettings.RetrievePartnerMatchReportSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callRetrievePartnerMatchReport);
            Modify_RetrievePartnerMatchReportApiCall(ref _callRetrievePartnerMatchReport);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_RetrievePartnerMatchReportApiCall(ref gaxgrpc::ApiCall<RetrievePartnerMatchReportRequest, RetrievePartnerMatchReportResponse> call);

        partial void OnConstruction(ReportingService.ReportingServiceClient grpcClient, ReportingServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ReportingService client</summary>
        public override ReportingService.ReportingServiceClient GrpcClient { get; }

        partial void Modify_RetrievePartnerMatchReportRequest(ref RetrievePartnerMatchReportRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves a partner match report.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PartnerMatchReportEntry"/> resources.</returns>
        public override gax::PagedEnumerable<RetrievePartnerMatchReportResponse, PartnerMatchReportEntry> RetrievePartnerMatchReport(RetrievePartnerMatchReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RetrievePartnerMatchReportRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<RetrievePartnerMatchReportRequest, RetrievePartnerMatchReportResponse, PartnerMatchReportEntry>(_callRetrievePartnerMatchReport, request, callSettings);
        }

        /// <summary>
        /// Retrieves a partner match report.
        /// 
        /// This feature is only available to data partners.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PartnerMatchReportEntry"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<RetrievePartnerMatchReportResponse, PartnerMatchReportEntry> RetrievePartnerMatchReportAsync(RetrievePartnerMatchReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RetrievePartnerMatchReportRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<RetrievePartnerMatchReportRequest, RetrievePartnerMatchReportResponse, PartnerMatchReportEntry>(_callRetrievePartnerMatchReport, request, callSettings);
        }
    }

    public partial class RetrievePartnerMatchReportRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class RetrievePartnerMatchReportResponse : gaxgrpc::IPageResponse<PartnerMatchReportEntry>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PartnerMatchReportEntry> GetEnumerator() => PartnerMatchReportEntries.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
