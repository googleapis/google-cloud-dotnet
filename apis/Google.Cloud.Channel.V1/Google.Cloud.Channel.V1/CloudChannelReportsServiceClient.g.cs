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
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.Channel.V1
{
    /// <summary>Settings for <see cref="CloudChannelReportsServiceClient"/> instances.</summary>
    [sys::ObsoleteAttribute]
    public sealed partial class CloudChannelReportsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CloudChannelReportsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CloudChannelReportsServiceSettings"/>.</returns>
        public static CloudChannelReportsServiceSettings GetDefault() => new CloudChannelReportsServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CloudChannelReportsServiceSettings"/> object with default settings.
        /// </summary>
        public CloudChannelReportsServiceSettings()
        {
        }

        private CloudChannelReportsServiceSettings(CloudChannelReportsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            RunReportJobSettings = existing.RunReportJobSettings;
            RunReportJobOperationsSettings = existing.RunReportJobOperationsSettings.Clone();
            FetchReportResultsSettings = existing.FetchReportResultsSettings;
            ListReportsSettings = existing.ListReportsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CloudChannelReportsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelReportsServiceClient.RunReportJob</c> and
        /// <c>CloudChannelReportsServiceClient.RunReportJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RunReportJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudChannelReportsServiceClient.RunReportJob</c> and
        /// <c>CloudChannelReportsServiceClient.RunReportJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings RunReportJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelReportsServiceClient.FetchReportResults</c> and
        /// <c>CloudChannelReportsServiceClient.FetchReportResultsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FetchReportResultsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelReportsServiceClient.ListReports</c> and <c>CloudChannelReportsServiceClient.ListReportsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListReportsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CloudChannelReportsServiceSettings"/> object.</returns>
        public CloudChannelReportsServiceSettings Clone() => new CloudChannelReportsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CloudChannelReportsServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    [sys::ObsoleteAttribute]
    public sealed partial class CloudChannelReportsServiceClientBuilder : gaxgrpc::ClientBuilderBase<CloudChannelReportsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CloudChannelReportsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CloudChannelReportsServiceClientBuilder() : base(CloudChannelReportsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CloudChannelReportsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CloudChannelReportsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CloudChannelReportsServiceClient Build()
        {
            CloudChannelReportsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CloudChannelReportsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CloudChannelReportsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CloudChannelReportsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CloudChannelReportsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CloudChannelReportsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CloudChannelReportsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CloudChannelReportsServiceClient.ChannelPool;
    }

    /// <summary>CloudChannelReportsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// CloudChannelReportsService lets Google Cloud resellers and
    /// distributors retrieve and combine a variety of data in Cloud Channel for
    /// multiple products (Google Cloud, Google Voice, and Google Workspace.)
    /// 
    /// Deprecated: This service is being deprecated. Please use [Export Channel
    /// Services data to
    /// BigQuery](https://cloud.google.com/channel/docs/rebilling/export-data-to-bigquery)
    /// instead.
    /// </remarks>
    [sys::ObsoleteAttribute]
    public abstract partial class CloudChannelReportsServiceClient
    {
        /// <summary>
        /// The default endpoint for the CloudChannelReportsService service, which is a host of
        /// "cloudchannel.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudchannel.googleapis.com:443";

        /// <summary>The default CloudChannelReportsService scopes.</summary>
        /// <remarks>
        /// The default CloudChannelReportsService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/apps.reports.usage.readonly</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/apps.reports.usage.readonly",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CloudChannelReportsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CloudChannelReportsServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CloudChannelReportsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CloudChannelReportsServiceClient"/>.</returns>
        public static stt::Task<CloudChannelReportsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CloudChannelReportsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CloudChannelReportsServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CloudChannelReportsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CloudChannelReportsServiceClient"/>.</returns>
        public static CloudChannelReportsServiceClient Create() => new CloudChannelReportsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CloudChannelReportsServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CloudChannelReportsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CloudChannelReportsServiceClient"/>.</returns>
        internal static CloudChannelReportsServiceClient Create(grpccore::CallInvoker callInvoker, CloudChannelReportsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CloudChannelReportsService.CloudChannelReportsServiceClient grpcClient = new CloudChannelReportsService.CloudChannelReportsServiceClient(callInvoker);
            return new CloudChannelReportsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CloudChannelReportsService client</summary>
        public virtual CloudChannelReportsService.CloudChannelReportsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Begins generation of data for a given report. The report
        /// identifier is a UID (for example, `613bf59q`).
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The user doesn't have access to this report.
        /// * INVALID_ARGUMENT: Required request parameters are missing
        /// or invalid.
        /// * NOT_FOUND: The report identifier was not found.
        /// * INTERNAL: Any non-user error related to a technical issue
        /// in the backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue
        /// in the backend. Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata contains an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// 
        /// To get the results of report generation, call
        /// [CloudChannelReportsService.FetchReportResults][google.cloud.channel.v1.CloudChannelReportsService.FetchReportResults]
        /// with the
        /// [RunReportJobResponse.report_job][google.cloud.channel.v1.RunReportJobResponse.report_job].
        /// 
        /// Deprecated: Please use [Export Channel Services data to
        /// BigQuery](https://cloud.google.com/channel/docs/rebilling/export-data-to-bigquery)
        /// instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual lro::Operation<RunReportJobResponse, OperationMetadata> RunReportJob(RunReportJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
#pragma warning restore CS0612
            throw new sys::NotImplementedException();

        /// <summary>
        /// Begins generation of data for a given report. The report
        /// identifier is a UID (for example, `613bf59q`).
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The user doesn't have access to this report.
        /// * INVALID_ARGUMENT: Required request parameters are missing
        /// or invalid.
        /// * NOT_FOUND: The report identifier was not found.
        /// * INTERNAL: Any non-user error related to a technical issue
        /// in the backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue
        /// in the backend. Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata contains an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// 
        /// To get the results of report generation, call
        /// [CloudChannelReportsService.FetchReportResults][google.cloud.channel.v1.CloudChannelReportsService.FetchReportResults]
        /// with the
        /// [RunReportJobResponse.report_job][google.cloud.channel.v1.RunReportJobResponse.report_job].
        /// 
        /// Deprecated: Please use [Export Channel Services data to
        /// BigQuery](https://cloud.google.com/channel/docs/rebilling/export-data-to-bigquery)
        /// instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual stt::Task<lro::Operation<RunReportJobResponse, OperationMetadata>> RunReportJobAsync(RunReportJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
#pragma warning restore CS0612
            throw new sys::NotImplementedException();

        /// <summary>
        /// Begins generation of data for a given report. The report
        /// identifier is a UID (for example, `613bf59q`).
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The user doesn't have access to this report.
        /// * INVALID_ARGUMENT: Required request parameters are missing
        /// or invalid.
        /// * NOT_FOUND: The report identifier was not found.
        /// * INTERNAL: Any non-user error related to a technical issue
        /// in the backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue
        /// in the backend. Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata contains an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// 
        /// To get the results of report generation, call
        /// [CloudChannelReportsService.FetchReportResults][google.cloud.channel.v1.CloudChannelReportsService.FetchReportResults]
        /// with the
        /// [RunReportJobResponse.report_job][google.cloud.channel.v1.RunReportJobResponse.report_job].
        /// 
        /// Deprecated: Please use [Export Channel Services data to
        /// BigQuery](https://cloud.google.com/channel/docs/rebilling/export-data-to-bigquery)
        /// instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual stt::Task<lro::Operation<RunReportJobResponse, OperationMetadata>> RunReportJobAsync(RunReportJobRequest request, st::CancellationToken cancellationToken) =>
#pragma warning restore CS0612
            RunReportJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RunReportJob</c>.</summary>
        public virtual lro::OperationsClient RunReportJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RunReportJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual lro::Operation<RunReportJobResponse, OperationMetadata> PollOnceRunReportJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RunReportJobResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RunReportJobOperationsClient, callSettings);
#pragma warning restore CS0612

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RunReportJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual stt::Task<lro::Operation<RunReportJobResponse, OperationMetadata>> PollOnceRunReportJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RunReportJobResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RunReportJobOperationsClient, callSettings);
#pragma warning restore CS0612

        /// <summary>
        /// Retrieves data generated by
        /// [CloudChannelReportsService.RunReportJob][google.cloud.channel.v1.CloudChannelReportsService.RunReportJob].
        /// 
        /// Deprecated: Please use [Export Channel Services data to
        /// BigQuery](https://cloud.google.com/channel/docs/rebilling/export-data-to-bigquery)
        /// instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Row"/> resources.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual gax::PagedEnumerable<FetchReportResultsResponse, Row> FetchReportResults(FetchReportResultsRequest request, gaxgrpc::CallSettings callSettings = null) =>
#pragma warning restore CS0612
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves data generated by
        /// [CloudChannelReportsService.RunReportJob][google.cloud.channel.v1.CloudChannelReportsService.RunReportJob].
        /// 
        /// Deprecated: Please use [Export Channel Services data to
        /// BigQuery](https://cloud.google.com/channel/docs/rebilling/export-data-to-bigquery)
        /// instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Row"/> resources.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual gax::PagedAsyncEnumerable<FetchReportResultsResponse, Row> FetchReportResultsAsync(FetchReportResultsRequest request, gaxgrpc::CallSettings callSettings = null) =>
#pragma warning restore CS0612
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves data generated by
        /// [CloudChannelReportsService.RunReportJob][google.cloud.channel.v1.CloudChannelReportsService.RunReportJob].
        /// 
        /// Deprecated: Please use [Export Channel Services data to
        /// BigQuery](https://cloud.google.com/channel/docs/rebilling/export-data-to-bigquery)
        /// instead.
        /// </summary>
        /// <param name="reportJob">
        /// Required. The report job created by
        /// [CloudChannelReportsService.RunReportJob][google.cloud.channel.v1.CloudChannelReportsService.RunReportJob].
        /// Report_job uses the format:
        /// accounts/{account_id}/reportJobs/{report_job_id}
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
        /// <returns>A pageable sequence of <see cref="Row"/> resources.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual gax::PagedEnumerable<FetchReportResultsResponse, Row> FetchReportResults(string reportJob, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
#pragma warning restore CS0612
        {
#pragma warning disable CS0612
            FetchReportResultsRequest request = new FetchReportResultsRequest
#pragma warning restore CS0612
            {
                ReportJob = gax::GaxPreconditions.CheckNotNullOrEmpty(reportJob, nameof(reportJob)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return FetchReportResults(request, callSettings);
        }

        /// <summary>
        /// Retrieves data generated by
        /// [CloudChannelReportsService.RunReportJob][google.cloud.channel.v1.CloudChannelReportsService.RunReportJob].
        /// 
        /// Deprecated: Please use [Export Channel Services data to
        /// BigQuery](https://cloud.google.com/channel/docs/rebilling/export-data-to-bigquery)
        /// instead.
        /// </summary>
        /// <param name="reportJob">
        /// Required. The report job created by
        /// [CloudChannelReportsService.RunReportJob][google.cloud.channel.v1.CloudChannelReportsService.RunReportJob].
        /// Report_job uses the format:
        /// accounts/{account_id}/reportJobs/{report_job_id}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Row"/> resources.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual gax::PagedAsyncEnumerable<FetchReportResultsResponse, Row> FetchReportResultsAsync(string reportJob, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
#pragma warning restore CS0612
        {
#pragma warning disable CS0612
            FetchReportResultsRequest request = new FetchReportResultsRequest
#pragma warning restore CS0612
            {
                ReportJob = gax::GaxPreconditions.CheckNotNullOrEmpty(reportJob, nameof(reportJob)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return FetchReportResultsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves data generated by
        /// [CloudChannelReportsService.RunReportJob][google.cloud.channel.v1.CloudChannelReportsService.RunReportJob].
        /// 
        /// Deprecated: Please use [Export Channel Services data to
        /// BigQuery](https://cloud.google.com/channel/docs/rebilling/export-data-to-bigquery)
        /// instead.
        /// </summary>
        /// <param name="reportJob">
        /// Required. The report job created by
        /// [CloudChannelReportsService.RunReportJob][google.cloud.channel.v1.CloudChannelReportsService.RunReportJob].
        /// Report_job uses the format:
        /// accounts/{account_id}/reportJobs/{report_job_id}
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
        /// <returns>A pageable sequence of <see cref="Row"/> resources.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual gax::PagedEnumerable<FetchReportResultsResponse, Row> FetchReportResults(ReportJobName reportJob, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
#pragma warning restore CS0612
        {
#pragma warning disable CS0612
            FetchReportResultsRequest request = new FetchReportResultsRequest
#pragma warning restore CS0612
            {
                ReportJobAsReportJobName = gax::GaxPreconditions.CheckNotNull(reportJob, nameof(reportJob)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return FetchReportResults(request, callSettings);
        }

        /// <summary>
        /// Retrieves data generated by
        /// [CloudChannelReportsService.RunReportJob][google.cloud.channel.v1.CloudChannelReportsService.RunReportJob].
        /// 
        /// Deprecated: Please use [Export Channel Services data to
        /// BigQuery](https://cloud.google.com/channel/docs/rebilling/export-data-to-bigquery)
        /// instead.
        /// </summary>
        /// <param name="reportJob">
        /// Required. The report job created by
        /// [CloudChannelReportsService.RunReportJob][google.cloud.channel.v1.CloudChannelReportsService.RunReportJob].
        /// Report_job uses the format:
        /// accounts/{account_id}/reportJobs/{report_job_id}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Row"/> resources.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual gax::PagedAsyncEnumerable<FetchReportResultsResponse, Row> FetchReportResultsAsync(ReportJobName reportJob, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
#pragma warning restore CS0612
        {
#pragma warning disable CS0612
            FetchReportResultsRequest request = new FetchReportResultsRequest
#pragma warning restore CS0612
            {
                ReportJobAsReportJobName = gax::GaxPreconditions.CheckNotNull(reportJob, nameof(reportJob)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return FetchReportResultsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the reports that RunReportJob can run. These reports include an ID,
        /// a description, and the list of columns that will be in the result.
        /// 
        /// Deprecated: Please use [Export Channel Services data to
        /// BigQuery](https://cloud.google.com/channel/docs/rebilling/export-data-to-bigquery)
        /// instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Report"/> resources.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual gax::PagedEnumerable<ListReportsResponse, Report> ListReports(ListReportsRequest request, gaxgrpc::CallSettings callSettings = null) =>
#pragma warning restore CS0612
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the reports that RunReportJob can run. These reports include an ID,
        /// a description, and the list of columns that will be in the result.
        /// 
        /// Deprecated: Please use [Export Channel Services data to
        /// BigQuery](https://cloud.google.com/channel/docs/rebilling/export-data-to-bigquery)
        /// instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Report"/> resources.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual gax::PagedAsyncEnumerable<ListReportsResponse, Report> ListReportsAsync(ListReportsRequest request, gaxgrpc::CallSettings callSettings = null) =>
#pragma warning restore CS0612
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the reports that RunReportJob can run. These reports include an ID,
        /// a description, and the list of columns that will be in the result.
        /// 
        /// Deprecated: Please use [Export Channel Services data to
        /// BigQuery](https://cloud.google.com/channel/docs/rebilling/export-data-to-bigquery)
        /// instead.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the partner account to list available
        /// reports for. Parent uses the format: accounts/{account_id}
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
        /// <returns>A pageable sequence of <see cref="Report"/> resources.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual gax::PagedEnumerable<ListReportsResponse, Report> ListReports(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
#pragma warning restore CS0612
        {
#pragma warning disable CS0612
            ListReportsRequest request = new ListReportsRequest
#pragma warning restore CS0612
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
            return ListReports(request, callSettings);
        }

        /// <summary>
        /// Lists the reports that RunReportJob can run. These reports include an ID,
        /// a description, and the list of columns that will be in the result.
        /// 
        /// Deprecated: Please use [Export Channel Services data to
        /// BigQuery](https://cloud.google.com/channel/docs/rebilling/export-data-to-bigquery)
        /// instead.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the partner account to list available
        /// reports for. Parent uses the format: accounts/{account_id}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Report"/> resources.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual gax::PagedAsyncEnumerable<ListReportsResponse, Report> ListReportsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
#pragma warning restore CS0612
        {
#pragma warning disable CS0612
            ListReportsRequest request = new ListReportsRequest
#pragma warning restore CS0612
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
            return ListReportsAsync(request, callSettings);
        }
    }

    /// <summary>CloudChannelReportsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// CloudChannelReportsService lets Google Cloud resellers and
    /// distributors retrieve and combine a variety of data in Cloud Channel for
    /// multiple products (Google Cloud, Google Voice, and Google Workspace.)
    /// 
    /// Deprecated: This service is being deprecated. Please use [Export Channel
    /// Services data to
    /// BigQuery](https://cloud.google.com/channel/docs/rebilling/export-data-to-bigquery)
    /// instead.
    /// </remarks>
    [sys::ObsoleteAttribute]
    public sealed partial class CloudChannelReportsServiceClientImpl : CloudChannelReportsServiceClient
    {
#pragma warning disable CS0612
        private readonly gaxgrpc::ApiCall<RunReportJobRequest, lro::Operation> _callRunReportJob;

        private readonly gaxgrpc::ApiCall<FetchReportResultsRequest, FetchReportResultsResponse> _callFetchReportResults;

        private readonly gaxgrpc::ApiCall<ListReportsRequest, ListReportsResponse> _callListReports;
#pragma warning restore CS0612

        /// <summary>
        /// Constructs a client wrapper for the CloudChannelReportsService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CloudChannelReportsServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CloudChannelReportsServiceClientImpl(CloudChannelReportsService.CloudChannelReportsServiceClient grpcClient, CloudChannelReportsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CloudChannelReportsServiceSettings effectiveSettings = settings ?? CloudChannelReportsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            RunReportJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RunReportJobOperationsSettings, logger);
#pragma warning disable CS0612
            _callRunReportJob = clientHelper.BuildApiCall<RunReportJobRequest, lro::Operation>("RunReportJob", grpcClient.RunReportJobAsync, grpcClient.RunReportJob, effectiveSettings.RunReportJobSettings).WithGoogleRequestParam("name", request => request.Name);
#pragma warning restore CS0612
            Modify_ApiCall(ref _callRunReportJob);
            Modify_RunReportJobApiCall(ref _callRunReportJob);
#pragma warning disable CS0612
            _callFetchReportResults = clientHelper.BuildApiCall<FetchReportResultsRequest, FetchReportResultsResponse>("FetchReportResults", grpcClient.FetchReportResultsAsync, grpcClient.FetchReportResults, effectiveSettings.FetchReportResultsSettings).WithGoogleRequestParam("report_job", request => request.ReportJob);
#pragma warning restore CS0612
            Modify_ApiCall(ref _callFetchReportResults);
            Modify_FetchReportResultsApiCall(ref _callFetchReportResults);
#pragma warning disable CS0612
            _callListReports = clientHelper.BuildApiCall<ListReportsRequest, ListReportsResponse>("ListReports", grpcClient.ListReportsAsync, grpcClient.ListReports, effectiveSettings.ListReportsSettings).WithGoogleRequestParam("parent", request => request.Parent);
#pragma warning restore CS0612
            Modify_ApiCall(ref _callListReports);
            Modify_ListReportsApiCall(ref _callListReports);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

#pragma warning disable CS0612
        partial void Modify_RunReportJobApiCall(ref gaxgrpc::ApiCall<RunReportJobRequest, lro::Operation> call);

        partial void Modify_FetchReportResultsApiCall(ref gaxgrpc::ApiCall<FetchReportResultsRequest, FetchReportResultsResponse> call);

        partial void Modify_ListReportsApiCall(ref gaxgrpc::ApiCall<ListReportsRequest, ListReportsResponse> call);
#pragma warning restore CS0612

        partial void OnConstruction(CloudChannelReportsService.CloudChannelReportsServiceClient grpcClient, CloudChannelReportsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CloudChannelReportsService client</summary>
        public override CloudChannelReportsService.CloudChannelReportsServiceClient GrpcClient { get; }

#pragma warning disable CS0612
        partial void Modify_RunReportJobRequest(ref RunReportJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchReportResultsRequest(ref FetchReportResultsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListReportsRequest(ref ListReportsRequest request, ref gaxgrpc::CallSettings settings);
#pragma warning restore CS0612

        /// <summary>The long-running operations client for <c>RunReportJob</c>.</summary>
        public override lro::OperationsClient RunReportJobOperationsClient { get; }

        /// <summary>
        /// Begins generation of data for a given report. The report
        /// identifier is a UID (for example, `613bf59q`).
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The user doesn't have access to this report.
        /// * INVALID_ARGUMENT: Required request parameters are missing
        /// or invalid.
        /// * NOT_FOUND: The report identifier was not found.
        /// * INTERNAL: Any non-user error related to a technical issue
        /// in the backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue
        /// in the backend. Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata contains an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// 
        /// To get the results of report generation, call
        /// [CloudChannelReportsService.FetchReportResults][google.cloud.channel.v1.CloudChannelReportsService.FetchReportResults]
        /// with the
        /// [RunReportJobResponse.report_job][google.cloud.channel.v1.RunReportJobResponse.report_job].
        /// 
        /// Deprecated: Please use [Export Channel Services data to
        /// BigQuery](https://cloud.google.com/channel/docs/rebilling/export-data-to-bigquery)
        /// instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public override lro::Operation<RunReportJobResponse, OperationMetadata> RunReportJob(RunReportJobRequest request, gaxgrpc::CallSettings callSettings = null)
#pragma warning restore CS0612
        {
            Modify_RunReportJobRequest(ref request, ref callSettings);
#pragma warning disable CS0612
            return new lro::Operation<RunReportJobResponse, OperationMetadata>(_callRunReportJob.Sync(request, callSettings), RunReportJobOperationsClient);
#pragma warning restore CS0612
        }

        /// <summary>
        /// Begins generation of data for a given report. The report
        /// identifier is a UID (for example, `613bf59q`).
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The user doesn't have access to this report.
        /// * INVALID_ARGUMENT: Required request parameters are missing
        /// or invalid.
        /// * NOT_FOUND: The report identifier was not found.
        /// * INTERNAL: Any non-user error related to a technical issue
        /// in the backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue
        /// in the backend. Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata contains an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// 
        /// To get the results of report generation, call
        /// [CloudChannelReportsService.FetchReportResults][google.cloud.channel.v1.CloudChannelReportsService.FetchReportResults]
        /// with the
        /// [RunReportJobResponse.report_job][google.cloud.channel.v1.RunReportJobResponse.report_job].
        /// 
        /// Deprecated: Please use [Export Channel Services data to
        /// BigQuery](https://cloud.google.com/channel/docs/rebilling/export-data-to-bigquery)
        /// instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public override async stt::Task<lro::Operation<RunReportJobResponse, OperationMetadata>> RunReportJobAsync(RunReportJobRequest request, gaxgrpc::CallSettings callSettings = null)
#pragma warning restore CS0612
        {
            Modify_RunReportJobRequest(ref request, ref callSettings);
#pragma warning disable CS0612
            return new lro::Operation<RunReportJobResponse, OperationMetadata>(await _callRunReportJob.Async(request, callSettings).ConfigureAwait(false), RunReportJobOperationsClient);
#pragma warning restore CS0612
        }

        /// <summary>
        /// Retrieves data generated by
        /// [CloudChannelReportsService.RunReportJob][google.cloud.channel.v1.CloudChannelReportsService.RunReportJob].
        /// 
        /// Deprecated: Please use [Export Channel Services data to
        /// BigQuery](https://cloud.google.com/channel/docs/rebilling/export-data-to-bigquery)
        /// instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Row"/> resources.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public override gax::PagedEnumerable<FetchReportResultsResponse, Row> FetchReportResults(FetchReportResultsRequest request, gaxgrpc::CallSettings callSettings = null)
#pragma warning restore CS0612
        {
            Modify_FetchReportResultsRequest(ref request, ref callSettings);
#pragma warning disable CS0612
            return new gaxgrpc::GrpcPagedEnumerable<FetchReportResultsRequest, FetchReportResultsResponse, Row>(_callFetchReportResults, request, callSettings);
#pragma warning restore CS0612
        }

        /// <summary>
        /// Retrieves data generated by
        /// [CloudChannelReportsService.RunReportJob][google.cloud.channel.v1.CloudChannelReportsService.RunReportJob].
        /// 
        /// Deprecated: Please use [Export Channel Services data to
        /// BigQuery](https://cloud.google.com/channel/docs/rebilling/export-data-to-bigquery)
        /// instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Row"/> resources.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public override gax::PagedAsyncEnumerable<FetchReportResultsResponse, Row> FetchReportResultsAsync(FetchReportResultsRequest request, gaxgrpc::CallSettings callSettings = null)
#pragma warning restore CS0612
        {
            Modify_FetchReportResultsRequest(ref request, ref callSettings);
#pragma warning disable CS0612
            return new gaxgrpc::GrpcPagedAsyncEnumerable<FetchReportResultsRequest, FetchReportResultsResponse, Row>(_callFetchReportResults, request, callSettings);
#pragma warning restore CS0612
        }

        /// <summary>
        /// Lists the reports that RunReportJob can run. These reports include an ID,
        /// a description, and the list of columns that will be in the result.
        /// 
        /// Deprecated: Please use [Export Channel Services data to
        /// BigQuery](https://cloud.google.com/channel/docs/rebilling/export-data-to-bigquery)
        /// instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Report"/> resources.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public override gax::PagedEnumerable<ListReportsResponse, Report> ListReports(ListReportsRequest request, gaxgrpc::CallSettings callSettings = null)
#pragma warning restore CS0612
        {
            Modify_ListReportsRequest(ref request, ref callSettings);
#pragma warning disable CS0612
            return new gaxgrpc::GrpcPagedEnumerable<ListReportsRequest, ListReportsResponse, Report>(_callListReports, request, callSettings);
#pragma warning restore CS0612
        }

        /// <summary>
        /// Lists the reports that RunReportJob can run. These reports include an ID,
        /// a description, and the list of columns that will be in the result.
        /// 
        /// Deprecated: Please use [Export Channel Services data to
        /// BigQuery](https://cloud.google.com/channel/docs/rebilling/export-data-to-bigquery)
        /// instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Report"/> resources.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public override gax::PagedAsyncEnumerable<ListReportsResponse, Report> ListReportsAsync(ListReportsRequest request, gaxgrpc::CallSettings callSettings = null)
#pragma warning restore CS0612
        {
            Modify_ListReportsRequest(ref request, ref callSettings);
#pragma warning disable CS0612
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListReportsRequest, ListReportsResponse, Report>(_callListReports, request, callSettings);
#pragma warning restore CS0612
        }
    }

    public partial class FetchReportResultsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListReportsRequest : gaxgrpc::IPageRequest
    {
    }

#pragma warning disable CS0612
    public partial class FetchReportResultsResponse : gaxgrpc::IPageResponse<Row>
#pragma warning restore CS0612
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
#pragma warning disable CS0612
        public scg::IEnumerator<Row> GetEnumerator() => Rows.GetEnumerator();
#pragma warning restore CS0612

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

#pragma warning disable CS0612
    public partial class ListReportsResponse : gaxgrpc::IPageResponse<Report>
#pragma warning restore CS0612
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
#pragma warning disable CS0612
        public scg::IEnumerator<Report> GetEnumerator() => Reports.GetEnumerator();
#pragma warning restore CS0612

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class CloudChannelReportsService
    {
        public partial class CloudChannelReportsServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() =>
                new lro::Operations.OperationsClient(CallInvoker);
        }
    }
}
