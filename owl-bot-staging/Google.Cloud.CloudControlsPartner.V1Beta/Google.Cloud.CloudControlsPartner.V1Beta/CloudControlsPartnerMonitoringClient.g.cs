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

namespace Google.Cloud.CloudControlsPartner.V1Beta
{
    /// <summary>Settings for <see cref="CloudControlsPartnerMonitoringClient"/> instances.</summary>
    public sealed partial class CloudControlsPartnerMonitoringSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CloudControlsPartnerMonitoringSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CloudControlsPartnerMonitoringSettings"/>.</returns>
        public static CloudControlsPartnerMonitoringSettings GetDefault() => new CloudControlsPartnerMonitoringSettings();

        /// <summary>
        /// Constructs a new <see cref="CloudControlsPartnerMonitoringSettings"/> object with default settings.
        /// </summary>
        public CloudControlsPartnerMonitoringSettings()
        {
        }

        private CloudControlsPartnerMonitoringSettings(CloudControlsPartnerMonitoringSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListViolationsSettings = existing.ListViolationsSettings;
            GetViolationSettings = existing.GetViolationSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CloudControlsPartnerMonitoringSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudControlsPartnerMonitoringClient.ListViolations</c> and
        /// <c>CloudControlsPartnerMonitoringClient.ListViolationsAsync</c>.
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
        public gaxgrpc::CallSettings ListViolationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudControlsPartnerMonitoringClient.GetViolation</c> and
        /// <c>CloudControlsPartnerMonitoringClient.GetViolationAsync</c>.
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
        public gaxgrpc::CallSettings GetViolationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CloudControlsPartnerMonitoringSettings"/> object.</returns>
        public CloudControlsPartnerMonitoringSettings Clone() => new CloudControlsPartnerMonitoringSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CloudControlsPartnerMonitoringClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class CloudControlsPartnerMonitoringClientBuilder : gaxgrpc::ClientBuilderBase<CloudControlsPartnerMonitoringClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CloudControlsPartnerMonitoringSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CloudControlsPartnerMonitoringClientBuilder() : base(CloudControlsPartnerMonitoringClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CloudControlsPartnerMonitoringClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CloudControlsPartnerMonitoringClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CloudControlsPartnerMonitoringClient Build()
        {
            CloudControlsPartnerMonitoringClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CloudControlsPartnerMonitoringClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CloudControlsPartnerMonitoringClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CloudControlsPartnerMonitoringClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CloudControlsPartnerMonitoringClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CloudControlsPartnerMonitoringClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CloudControlsPartnerMonitoringClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CloudControlsPartnerMonitoringClient.ChannelPool;
    }

    /// <summary>CloudControlsPartnerMonitoring client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public abstract partial class CloudControlsPartnerMonitoringClient
    {
        /// <summary>
        /// The default endpoint for the CloudControlsPartnerMonitoring service, which is a host of
        /// "cloudcontrolspartner.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudcontrolspartner.googleapis.com:443";

        /// <summary>The default CloudControlsPartnerMonitoring scopes.</summary>
        /// <remarks>
        /// The default CloudControlsPartnerMonitoring scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CloudControlsPartnerMonitoring.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CloudControlsPartnerMonitoringClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CloudControlsPartnerMonitoringClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CloudControlsPartnerMonitoringClient"/>.</returns>
        public static stt::Task<CloudControlsPartnerMonitoringClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CloudControlsPartnerMonitoringClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CloudControlsPartnerMonitoringClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CloudControlsPartnerMonitoringClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CloudControlsPartnerMonitoringClient"/>.</returns>
        public static CloudControlsPartnerMonitoringClient Create() =>
            new CloudControlsPartnerMonitoringClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CloudControlsPartnerMonitoringClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CloudControlsPartnerMonitoringSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CloudControlsPartnerMonitoringClient"/>.</returns>
        internal static CloudControlsPartnerMonitoringClient Create(grpccore::CallInvoker callInvoker, CloudControlsPartnerMonitoringSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CloudControlsPartnerMonitoring.CloudControlsPartnerMonitoringClient grpcClient = new CloudControlsPartnerMonitoring.CloudControlsPartnerMonitoringClient(callInvoker);
            return new CloudControlsPartnerMonitoringClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CloudControlsPartnerMonitoring client</summary>
        public virtual CloudControlsPartnerMonitoring.CloudControlsPartnerMonitoringClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Violations for a workload
        /// Callers may also choose to read across multiple Customers or for a single
        /// customer as per
        /// [AIP-159](https://google.aip.dev/159) by using '-' (the hyphen or dash
        /// character) as a wildcard character instead of {customer} &amp; {workload}.
        /// Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Violation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListViolationsResponse, Violation> ListViolations(ListViolationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Violations for a workload
        /// Callers may also choose to read across multiple Customers or for a single
        /// customer as per
        /// [AIP-159](https://google.aip.dev/159) by using '-' (the hyphen or dash
        /// character) as a wildcard character instead of {customer} &amp; {workload}.
        /// Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Violation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListViolationsResponse, Violation> ListViolationsAsync(ListViolationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Violations for a workload
        /// Callers may also choose to read across multiple Customers or for a single
        /// customer as per
        /// [AIP-159](https://google.aip.dev/159) by using '-' (the hyphen or dash
        /// character) as a wildcard character instead of {customer} &amp; {workload}.
        /// Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}`
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource
        /// Format
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}`
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
        /// <returns>A pageable sequence of <see cref="Violation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListViolationsResponse, Violation> ListViolations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListViolationsRequest request = new ListViolationsRequest
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
            return ListViolations(request, callSettings);
        }

        /// <summary>
        /// Lists Violations for a workload
        /// Callers may also choose to read across multiple Customers or for a single
        /// customer as per
        /// [AIP-159](https://google.aip.dev/159) by using '-' (the hyphen or dash
        /// character) as a wildcard character instead of {customer} &amp; {workload}.
        /// Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}`
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource
        /// Format
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Violation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListViolationsResponse, Violation> ListViolationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListViolationsRequest request = new ListViolationsRequest
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
            return ListViolationsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Violations for a workload
        /// Callers may also choose to read across multiple Customers or for a single
        /// customer as per
        /// [AIP-159](https://google.aip.dev/159) by using '-' (the hyphen or dash
        /// character) as a wildcard character instead of {customer} &amp; {workload}.
        /// Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}`
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource
        /// Format
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}`
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
        /// <returns>A pageable sequence of <see cref="Violation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListViolationsResponse, Violation> ListViolations(WorkloadName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListViolationsRequest request = new ListViolationsRequest
            {
                ParentAsWorkloadName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListViolations(request, callSettings);
        }

        /// <summary>
        /// Lists Violations for a workload
        /// Callers may also choose to read across multiple Customers or for a single
        /// customer as per
        /// [AIP-159](https://google.aip.dev/159) by using '-' (the hyphen or dash
        /// character) as a wildcard character instead of {customer} &amp; {workload}.
        /// Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}`
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource
        /// Format
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Violation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListViolationsResponse, Violation> ListViolationsAsync(WorkloadName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListViolationsRequest request = new ListViolationsRequest
            {
                ParentAsWorkloadName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListViolationsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Violation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Violation GetViolation(GetViolationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Violation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Violation> GetViolationAsync(GetViolationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Violation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Violation> GetViolationAsync(GetViolationRequest request, st::CancellationToken cancellationToken) =>
            GetViolationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Violation.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/violations/{violation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Violation GetViolation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetViolation(new GetViolationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Violation.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/violations/{violation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Violation> GetViolationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetViolationAsync(new GetViolationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Violation.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/violations/{violation}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Violation> GetViolationAsync(string name, st::CancellationToken cancellationToken) =>
            GetViolationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Violation.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/violations/{violation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Violation GetViolation(ViolationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetViolation(new GetViolationRequest
            {
                ViolationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Violation.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/violations/{violation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Violation> GetViolationAsync(ViolationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetViolationAsync(new GetViolationRequest
            {
                ViolationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Violation.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/violations/{violation}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Violation> GetViolationAsync(ViolationName name, st::CancellationToken cancellationToken) =>
            GetViolationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CloudControlsPartnerMonitoring client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public sealed partial class CloudControlsPartnerMonitoringClientImpl : CloudControlsPartnerMonitoringClient
    {
        private readonly gaxgrpc::ApiCall<ListViolationsRequest, ListViolationsResponse> _callListViolations;

        private readonly gaxgrpc::ApiCall<GetViolationRequest, Violation> _callGetViolation;

        /// <summary>
        /// Constructs a client wrapper for the CloudControlsPartnerMonitoring service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CloudControlsPartnerMonitoringSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CloudControlsPartnerMonitoringClientImpl(CloudControlsPartnerMonitoring.CloudControlsPartnerMonitoringClient grpcClient, CloudControlsPartnerMonitoringSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CloudControlsPartnerMonitoringSettings effectiveSettings = settings ?? CloudControlsPartnerMonitoringSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callListViolations = clientHelper.BuildApiCall<ListViolationsRequest, ListViolationsResponse>("ListViolations", grpcClient.ListViolationsAsync, grpcClient.ListViolations, effectiveSettings.ListViolationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListViolations);
            Modify_ListViolationsApiCall(ref _callListViolations);
            _callGetViolation = clientHelper.BuildApiCall<GetViolationRequest, Violation>("GetViolation", grpcClient.GetViolationAsync, grpcClient.GetViolation, effectiveSettings.GetViolationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetViolation);
            Modify_GetViolationApiCall(ref _callGetViolation);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListViolationsApiCall(ref gaxgrpc::ApiCall<ListViolationsRequest, ListViolationsResponse> call);

        partial void Modify_GetViolationApiCall(ref gaxgrpc::ApiCall<GetViolationRequest, Violation> call);

        partial void OnConstruction(CloudControlsPartnerMonitoring.CloudControlsPartnerMonitoringClient grpcClient, CloudControlsPartnerMonitoringSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CloudControlsPartnerMonitoring client</summary>
        public override CloudControlsPartnerMonitoring.CloudControlsPartnerMonitoringClient GrpcClient { get; }

        partial void Modify_ListViolationsRequest(ref ListViolationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetViolationRequest(ref GetViolationRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists Violations for a workload
        /// Callers may also choose to read across multiple Customers or for a single
        /// customer as per
        /// [AIP-159](https://google.aip.dev/159) by using '-' (the hyphen or dash
        /// character) as a wildcard character instead of {customer} &amp; {workload}.
        /// Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Violation"/> resources.</returns>
        public override gax::PagedEnumerable<ListViolationsResponse, Violation> ListViolations(ListViolationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListViolationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListViolationsRequest, ListViolationsResponse, Violation>(_callListViolations, request, callSettings);
        }

        /// <summary>
        /// Lists Violations for a workload
        /// Callers may also choose to read across multiple Customers or for a single
        /// customer as per
        /// [AIP-159](https://google.aip.dev/159) by using '-' (the hyphen or dash
        /// character) as a wildcard character instead of {customer} &amp; {workload}.
        /// Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Violation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListViolationsResponse, Violation> ListViolationsAsync(ListViolationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListViolationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListViolationsRequest, ListViolationsResponse, Violation>(_callListViolations, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Violation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Violation GetViolation(GetViolationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetViolationRequest(ref request, ref callSettings);
            return _callGetViolation.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Violation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Violation> GetViolationAsync(GetViolationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetViolationRequest(ref request, ref callSettings);
            return _callGetViolation.Async(request, callSettings);
        }
    }

    public partial class ListViolationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListViolationsResponse : gaxgrpc::IPageResponse<Violation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Violation> GetEnumerator() => Violations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
