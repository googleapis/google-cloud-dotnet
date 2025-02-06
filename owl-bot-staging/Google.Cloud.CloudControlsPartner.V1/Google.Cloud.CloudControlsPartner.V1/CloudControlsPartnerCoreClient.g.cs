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

namespace Google.Cloud.CloudControlsPartner.V1
{
    /// <summary>Settings for <see cref="CloudControlsPartnerCoreClient"/> instances.</summary>
    public sealed partial class CloudControlsPartnerCoreSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CloudControlsPartnerCoreSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CloudControlsPartnerCoreSettings"/>.</returns>
        public static CloudControlsPartnerCoreSettings GetDefault() => new CloudControlsPartnerCoreSettings();

        /// <summary>
        /// Constructs a new <see cref="CloudControlsPartnerCoreSettings"/> object with default settings.
        /// </summary>
        public CloudControlsPartnerCoreSettings()
        {
        }

        private CloudControlsPartnerCoreSettings(CloudControlsPartnerCoreSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetWorkloadSettings = existing.GetWorkloadSettings;
            ListWorkloadsSettings = existing.ListWorkloadsSettings;
            GetCustomerSettings = existing.GetCustomerSettings;
            ListCustomersSettings = existing.ListCustomersSettings;
            GetEkmConnectionsSettings = existing.GetEkmConnectionsSettings;
            GetPartnerPermissionsSettings = existing.GetPartnerPermissionsSettings;
            ListAccessApprovalRequestsSettings = existing.ListAccessApprovalRequestsSettings;
            GetPartnerSettings = existing.GetPartnerSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CloudControlsPartnerCoreSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudControlsPartnerCoreClient.GetWorkload</c> and <c>CloudControlsPartnerCoreClient.GetWorkloadAsync</c>
        /// .
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
        public gaxgrpc::CallSettings GetWorkloadSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudControlsPartnerCoreClient.ListWorkloads</c> and <c>CloudControlsPartnerCoreClient.ListWorkloadsAsync</c>
        /// .
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
        public gaxgrpc::CallSettings ListWorkloadsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudControlsPartnerCoreClient.GetCustomer</c> and <c>CloudControlsPartnerCoreClient.GetCustomerAsync</c>
        /// .
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
        public gaxgrpc::CallSettings GetCustomerSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudControlsPartnerCoreClient.ListCustomers</c> and <c>CloudControlsPartnerCoreClient.ListCustomersAsync</c>
        /// .
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
        public gaxgrpc::CallSettings ListCustomersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudControlsPartnerCoreClient.GetEkmConnections</c> and
        /// <c>CloudControlsPartnerCoreClient.GetEkmConnectionsAsync</c>.
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
        public gaxgrpc::CallSettings GetEkmConnectionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudControlsPartnerCoreClient.GetPartnerPermissions</c> and
        /// <c>CloudControlsPartnerCoreClient.GetPartnerPermissionsAsync</c>.
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
        public gaxgrpc::CallSettings GetPartnerPermissionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudControlsPartnerCoreClient.ListAccessApprovalRequests</c> and
        /// <c>CloudControlsPartnerCoreClient.ListAccessApprovalRequestsAsync</c>.
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
        public gaxgrpc::CallSettings ListAccessApprovalRequestsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudControlsPartnerCoreClient.GetPartner</c> and <c>CloudControlsPartnerCoreClient.GetPartnerAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetPartnerSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CloudControlsPartnerCoreSettings"/> object.</returns>
        public CloudControlsPartnerCoreSettings Clone() => new CloudControlsPartnerCoreSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CloudControlsPartnerCoreClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class CloudControlsPartnerCoreClientBuilder : gaxgrpc::ClientBuilderBase<CloudControlsPartnerCoreClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CloudControlsPartnerCoreSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CloudControlsPartnerCoreClientBuilder() : base(CloudControlsPartnerCoreClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CloudControlsPartnerCoreClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CloudControlsPartnerCoreClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CloudControlsPartnerCoreClient Build()
        {
            CloudControlsPartnerCoreClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CloudControlsPartnerCoreClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CloudControlsPartnerCoreClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CloudControlsPartnerCoreClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CloudControlsPartnerCoreClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CloudControlsPartnerCoreClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CloudControlsPartnerCoreClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CloudControlsPartnerCoreClient.ChannelPool;
    }

    /// <summary>CloudControlsPartnerCore client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public abstract partial class CloudControlsPartnerCoreClient
    {
        /// <summary>
        /// The default endpoint for the CloudControlsPartnerCore service, which is a host of
        /// "cloudcontrolspartner.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudcontrolspartner.googleapis.com:443";

        /// <summary>The default CloudControlsPartnerCore scopes.</summary>
        /// <remarks>
        /// The default CloudControlsPartnerCore scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CloudControlsPartnerCore.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CloudControlsPartnerCoreClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CloudControlsPartnerCoreClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CloudControlsPartnerCoreClient"/>.</returns>
        public static stt::Task<CloudControlsPartnerCoreClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CloudControlsPartnerCoreClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CloudControlsPartnerCoreClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CloudControlsPartnerCoreClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CloudControlsPartnerCoreClient"/>.</returns>
        public static CloudControlsPartnerCoreClient Create() => new CloudControlsPartnerCoreClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CloudControlsPartnerCoreClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CloudControlsPartnerCoreSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CloudControlsPartnerCoreClient"/>.</returns>
        internal static CloudControlsPartnerCoreClient Create(grpccore::CallInvoker callInvoker, CloudControlsPartnerCoreSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CloudControlsPartnerCore.CloudControlsPartnerCoreClient grpcClient = new CloudControlsPartnerCore.CloudControlsPartnerCoreClient(callInvoker);
            return new CloudControlsPartnerCoreClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CloudControlsPartnerCore client</summary>
        public virtual CloudControlsPartnerCore.CloudControlsPartnerCoreClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single workload
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Workload GetWorkload(GetWorkloadRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single workload
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workload> GetWorkloadAsync(GetWorkloadRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single workload
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workload> GetWorkloadAsync(GetWorkloadRequest request, st::CancellationToken cancellationToken) =>
            GetWorkloadAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single workload
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Workload GetWorkload(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkload(new GetWorkloadRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single workload
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workload> GetWorkloadAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkloadAsync(new GetWorkloadRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single workload
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workload> GetWorkloadAsync(string name, st::CancellationToken cancellationToken) =>
            GetWorkloadAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single workload
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Workload GetWorkload(WorkloadName name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkload(new GetWorkloadRequest
            {
                WorkloadName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single workload
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workload> GetWorkloadAsync(WorkloadName name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkloadAsync(new GetWorkloadRequest
            {
                WorkloadName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single workload
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Workload> GetWorkloadAsync(WorkloadName name, st::CancellationToken cancellationToken) =>
            GetWorkloadAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists customer workloads for a given customer org id
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Workload"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkloadsResponse, Workload> ListWorkloads(ListWorkloadsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists customer workloads for a given customer org id
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Workload"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkloadsResponse, Workload> ListWorkloadsAsync(ListWorkloadsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists customer workloads for a given customer org id
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource
        /// Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}`
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
        /// <returns>A pageable sequence of <see cref="Workload"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkloadsResponse, Workload> ListWorkloads(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkloadsRequest request = new ListWorkloadsRequest
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
            return ListWorkloads(request, callSettings);
        }

        /// <summary>
        /// Lists customer workloads for a given customer org id
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource
        /// Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Workload"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkloadsResponse, Workload> ListWorkloadsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkloadsRequest request = new ListWorkloadsRequest
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
            return ListWorkloadsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists customer workloads for a given customer org id
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource
        /// Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}`
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
        /// <returns>A pageable sequence of <see cref="Workload"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkloadsResponse, Workload> ListWorkloads(CustomerName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkloadsRequest request = new ListWorkloadsRequest
            {
                ParentAsCustomerName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListWorkloads(request, callSettings);
        }

        /// <summary>
        /// Lists customer workloads for a given customer org id
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource
        /// Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Workload"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkloadsResponse, Workload> ListWorkloadsAsync(CustomerName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkloadsRequest request = new ListWorkloadsRequest
            {
                ParentAsCustomerName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListWorkloadsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single customer
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Customer GetCustomer(GetCustomerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single customer
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Customer> GetCustomerAsync(GetCustomerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single customer
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Customer> GetCustomerAsync(GetCustomerRequest request, st::CancellationToken cancellationToken) =>
            GetCustomerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single customer
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Customer GetCustomer(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomer(new GetCustomerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single customer
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Customer> GetCustomerAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomerAsync(new GetCustomerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single customer
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Customer> GetCustomerAsync(string name, st::CancellationToken cancellationToken) =>
            GetCustomerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single customer
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Customer GetCustomer(CustomerName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomer(new GetCustomerRequest
            {
                CustomerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single customer
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Customer> GetCustomerAsync(CustomerName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomerAsync(new GetCustomerRequest
            {
                CustomerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single customer
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Customer> GetCustomerAsync(CustomerName name, st::CancellationToken cancellationToken) =>
            GetCustomerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists customers of a partner identified by its Google Cloud organization ID
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Customer"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCustomersResponse, Customer> ListCustomers(ListCustomersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists customers of a partner identified by its Google Cloud organization ID
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Customer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCustomersResponse, Customer> ListCustomersAsync(ListCustomersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists customers of a partner identified by its Google Cloud organization ID
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource
        /// Format: `organizations/{organization}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="Customer"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCustomersResponse, Customer> ListCustomers(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomersRequest request = new ListCustomersRequest
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
            return ListCustomers(request, callSettings);
        }

        /// <summary>
        /// Lists customers of a partner identified by its Google Cloud organization ID
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource
        /// Format: `organizations/{organization}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Customer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCustomersResponse, Customer> ListCustomersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomersRequest request = new ListCustomersRequest
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
            return ListCustomersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists customers of a partner identified by its Google Cloud organization ID
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource
        /// Format: `organizations/{organization}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="Customer"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCustomersResponse, Customer> ListCustomers(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomersRequest request = new ListCustomersRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCustomers(request, callSettings);
        }

        /// <summary>
        /// Lists customers of a partner identified by its Google Cloud organization ID
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource
        /// Format: `organizations/{organization}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Customer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCustomersResponse, Customer> ListCustomersAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomersRequest request = new ListCustomersRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCustomersAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the EKM connections associated with a workload
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EkmConnections GetEkmConnections(GetEkmConnectionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the EKM connections associated with a workload
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConnections> GetEkmConnectionsAsync(GetEkmConnectionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the EKM connections associated with a workload
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConnections> GetEkmConnectionsAsync(GetEkmConnectionsRequest request, st::CancellationToken cancellationToken) =>
            GetEkmConnectionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the EKM connections associated with a workload
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/ekmConnections`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EkmConnections GetEkmConnections(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEkmConnections(new GetEkmConnectionsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the EKM connections associated with a workload
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/ekmConnections`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConnections> GetEkmConnectionsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEkmConnectionsAsync(new GetEkmConnectionsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the EKM connections associated with a workload
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/ekmConnections`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConnections> GetEkmConnectionsAsync(string name, st::CancellationToken cancellationToken) =>
            GetEkmConnectionsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the EKM connections associated with a workload
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/ekmConnections`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EkmConnections GetEkmConnections(EkmConnectionsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEkmConnections(new GetEkmConnectionsRequest
            {
                EkmConnectionsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the EKM connections associated with a workload
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/ekmConnections`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConnections> GetEkmConnectionsAsync(EkmConnectionsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEkmConnectionsAsync(new GetEkmConnectionsRequest
            {
                EkmConnectionsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the EKM connections associated with a workload
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/ekmConnections`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConnections> GetEkmConnectionsAsync(EkmConnectionsName name, st::CancellationToken cancellationToken) =>
            GetEkmConnectionsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the partner permissions granted for a workload
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PartnerPermissions GetPartnerPermissions(GetPartnerPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the partner permissions granted for a workload
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PartnerPermissions> GetPartnerPermissionsAsync(GetPartnerPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the partner permissions granted for a workload
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PartnerPermissions> GetPartnerPermissionsAsync(GetPartnerPermissionsRequest request, st::CancellationToken cancellationToken) =>
            GetPartnerPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the partner permissions granted for a workload
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource to get in the format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/partnerPermissions`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PartnerPermissions GetPartnerPermissions(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPartnerPermissions(new GetPartnerPermissionsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the partner permissions granted for a workload
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource to get in the format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/partnerPermissions`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PartnerPermissions> GetPartnerPermissionsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPartnerPermissionsAsync(new GetPartnerPermissionsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the partner permissions granted for a workload
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource to get in the format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/partnerPermissions`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PartnerPermissions> GetPartnerPermissionsAsync(string name, st::CancellationToken cancellationToken) =>
            GetPartnerPermissionsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the partner permissions granted for a workload
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource to get in the format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/partnerPermissions`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PartnerPermissions GetPartnerPermissions(PartnerPermissionsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPartnerPermissions(new GetPartnerPermissionsRequest
            {
                PartnerPermissionsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the partner permissions granted for a workload
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource to get in the format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/partnerPermissions`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PartnerPermissions> GetPartnerPermissionsAsync(PartnerPermissionsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPartnerPermissionsAsync(new GetPartnerPermissionsRequest
            {
                PartnerPermissionsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the partner permissions granted for a workload
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource to get in the format:
        /// `organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/partnerPermissions`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PartnerPermissions> GetPartnerPermissionsAsync(PartnerPermissionsName name, st::CancellationToken cancellationToken) =>
            GetPartnerPermissionsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deprecated: Only returns access approval requests directly associated with
        /// an assured workload folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AccessApprovalRequest"/> resources.</returns>
        [sys::ObsoleteAttribute]
        public virtual gax::PagedEnumerable<ListAccessApprovalRequestsResponse, AccessApprovalRequest> ListAccessApprovalRequests(ListAccessApprovalRequestsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deprecated: Only returns access approval requests directly associated with
        /// an assured workload folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AccessApprovalRequest"/> resources.</returns>
        [sys::ObsoleteAttribute]
        public virtual gax::PagedAsyncEnumerable<ListAccessApprovalRequestsResponse, AccessApprovalRequest> ListAccessApprovalRequestsAsync(ListAccessApprovalRequestsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deprecated: Only returns access approval requests directly associated with
        /// an assured workload folder.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource
        /// Format:
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
        /// <returns>A pageable sequence of <see cref="AccessApprovalRequest"/> resources.</returns>
        [sys::ObsoleteAttribute]
        public virtual gax::PagedEnumerable<ListAccessApprovalRequestsResponse, AccessApprovalRequest> ListAccessApprovalRequests(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAccessApprovalRequestsRequest request = new ListAccessApprovalRequestsRequest
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
            return ListAccessApprovalRequests(request, callSettings);
        }

        /// <summary>
        /// Deprecated: Only returns access approval requests directly associated with
        /// an assured workload folder.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource
        /// Format:
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
        /// <returns>A pageable asynchronous sequence of <see cref="AccessApprovalRequest"/> resources.</returns>
        [sys::ObsoleteAttribute]
        public virtual gax::PagedAsyncEnumerable<ListAccessApprovalRequestsResponse, AccessApprovalRequest> ListAccessApprovalRequestsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAccessApprovalRequestsRequest request = new ListAccessApprovalRequestsRequest
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
            return ListAccessApprovalRequestsAsync(request, callSettings);
        }

        /// <summary>
        /// Deprecated: Only returns access approval requests directly associated with
        /// an assured workload folder.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource
        /// Format:
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
        /// <returns>A pageable sequence of <see cref="AccessApprovalRequest"/> resources.</returns>
        [sys::ObsoleteAttribute]
        public virtual gax::PagedEnumerable<ListAccessApprovalRequestsResponse, AccessApprovalRequest> ListAccessApprovalRequests(WorkloadName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAccessApprovalRequestsRequest request = new ListAccessApprovalRequestsRequest
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
            return ListAccessApprovalRequests(request, callSettings);
        }

        /// <summary>
        /// Deprecated: Only returns access approval requests directly associated with
        /// an assured workload folder.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource
        /// Format:
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
        /// <returns>A pageable asynchronous sequence of <see cref="AccessApprovalRequest"/> resources.</returns>
        [sys::ObsoleteAttribute]
        public virtual gax::PagedAsyncEnumerable<ListAccessApprovalRequestsResponse, AccessApprovalRequest> ListAccessApprovalRequestsAsync(WorkloadName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAccessApprovalRequestsRequest request = new ListAccessApprovalRequestsRequest
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
            return ListAccessApprovalRequestsAsync(request, callSettings);
        }

        /// <summary>
        /// Get details of a Partner.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Partner GetPartner(GetPartnerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details of a Partner.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Partner> GetPartnerAsync(GetPartnerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details of a Partner.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Partner> GetPartnerAsync(GetPartnerRequest request, st::CancellationToken cancellationToken) =>
            GetPartnerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details of a Partner.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `organizations/{organization}/locations/{location}/partner`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Partner GetPartner(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPartner(new GetPartnerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a Partner.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `organizations/{organization}/locations/{location}/partner`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Partner> GetPartnerAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPartnerAsync(new GetPartnerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a Partner.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `organizations/{organization}/locations/{location}/partner`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Partner> GetPartnerAsync(string name, st::CancellationToken cancellationToken) =>
            GetPartnerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details of a Partner.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `organizations/{organization}/locations/{location}/partner`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Partner GetPartner(PartnerName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPartner(new GetPartnerRequest
            {
                PartnerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a Partner.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `organizations/{organization}/locations/{location}/partner`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Partner> GetPartnerAsync(PartnerName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPartnerAsync(new GetPartnerRequest
            {
                PartnerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a Partner.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `organizations/{organization}/locations/{location}/partner`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Partner> GetPartnerAsync(PartnerName name, st::CancellationToken cancellationToken) =>
            GetPartnerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CloudControlsPartnerCore client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public sealed partial class CloudControlsPartnerCoreClientImpl : CloudControlsPartnerCoreClient
    {
        private readonly gaxgrpc::ApiCall<GetWorkloadRequest, Workload> _callGetWorkload;

        private readonly gaxgrpc::ApiCall<ListWorkloadsRequest, ListWorkloadsResponse> _callListWorkloads;

        private readonly gaxgrpc::ApiCall<GetCustomerRequest, Customer> _callGetCustomer;

        private readonly gaxgrpc::ApiCall<ListCustomersRequest, ListCustomersResponse> _callListCustomers;

        private readonly gaxgrpc::ApiCall<GetEkmConnectionsRequest, EkmConnections> _callGetEkmConnections;

        private readonly gaxgrpc::ApiCall<GetPartnerPermissionsRequest, PartnerPermissions> _callGetPartnerPermissions;

        private readonly gaxgrpc::ApiCall<ListAccessApprovalRequestsRequest, ListAccessApprovalRequestsResponse> _callListAccessApprovalRequests;

        private readonly gaxgrpc::ApiCall<GetPartnerRequest, Partner> _callGetPartner;

        /// <summary>
        /// Constructs a client wrapper for the CloudControlsPartnerCore service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CloudControlsPartnerCoreSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CloudControlsPartnerCoreClientImpl(CloudControlsPartnerCore.CloudControlsPartnerCoreClient grpcClient, CloudControlsPartnerCoreSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CloudControlsPartnerCoreSettings effectiveSettings = settings ?? CloudControlsPartnerCoreSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetWorkload = clientHelper.BuildApiCall<GetWorkloadRequest, Workload>("GetWorkload", grpcClient.GetWorkloadAsync, grpcClient.GetWorkload, effectiveSettings.GetWorkloadSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetWorkload);
            Modify_GetWorkloadApiCall(ref _callGetWorkload);
            _callListWorkloads = clientHelper.BuildApiCall<ListWorkloadsRequest, ListWorkloadsResponse>("ListWorkloads", grpcClient.ListWorkloadsAsync, grpcClient.ListWorkloads, effectiveSettings.ListWorkloadsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListWorkloads);
            Modify_ListWorkloadsApiCall(ref _callListWorkloads);
            _callGetCustomer = clientHelper.BuildApiCall<GetCustomerRequest, Customer>("GetCustomer", grpcClient.GetCustomerAsync, grpcClient.GetCustomer, effectiveSettings.GetCustomerSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCustomer);
            Modify_GetCustomerApiCall(ref _callGetCustomer);
            _callListCustomers = clientHelper.BuildApiCall<ListCustomersRequest, ListCustomersResponse>("ListCustomers", grpcClient.ListCustomersAsync, grpcClient.ListCustomers, effectiveSettings.ListCustomersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCustomers);
            Modify_ListCustomersApiCall(ref _callListCustomers);
            _callGetEkmConnections = clientHelper.BuildApiCall<GetEkmConnectionsRequest, EkmConnections>("GetEkmConnections", grpcClient.GetEkmConnectionsAsync, grpcClient.GetEkmConnections, effectiveSettings.GetEkmConnectionsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEkmConnections);
            Modify_GetEkmConnectionsApiCall(ref _callGetEkmConnections);
            _callGetPartnerPermissions = clientHelper.BuildApiCall<GetPartnerPermissionsRequest, PartnerPermissions>("GetPartnerPermissions", grpcClient.GetPartnerPermissionsAsync, grpcClient.GetPartnerPermissions, effectiveSettings.GetPartnerPermissionsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPartnerPermissions);
            Modify_GetPartnerPermissionsApiCall(ref _callGetPartnerPermissions);
#pragma warning disable CS0612
            _callListAccessApprovalRequests = clientHelper.BuildApiCall<ListAccessApprovalRequestsRequest, ListAccessApprovalRequestsResponse>("ListAccessApprovalRequests", grpcClient.ListAccessApprovalRequestsAsync, grpcClient.ListAccessApprovalRequests, effectiveSettings.ListAccessApprovalRequestsSettings).WithGoogleRequestParam("parent", request => request.Parent);
#pragma warning restore CS0612
            Modify_ApiCall(ref _callListAccessApprovalRequests);
            Modify_ListAccessApprovalRequestsApiCall(ref _callListAccessApprovalRequests);
            _callGetPartner = clientHelper.BuildApiCall<GetPartnerRequest, Partner>("GetPartner", grpcClient.GetPartnerAsync, grpcClient.GetPartner, effectiveSettings.GetPartnerSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPartner);
            Modify_GetPartnerApiCall(ref _callGetPartner);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetWorkloadApiCall(ref gaxgrpc::ApiCall<GetWorkloadRequest, Workload> call);

        partial void Modify_ListWorkloadsApiCall(ref gaxgrpc::ApiCall<ListWorkloadsRequest, ListWorkloadsResponse> call);

        partial void Modify_GetCustomerApiCall(ref gaxgrpc::ApiCall<GetCustomerRequest, Customer> call);

        partial void Modify_ListCustomersApiCall(ref gaxgrpc::ApiCall<ListCustomersRequest, ListCustomersResponse> call);

        partial void Modify_GetEkmConnectionsApiCall(ref gaxgrpc::ApiCall<GetEkmConnectionsRequest, EkmConnections> call);

        partial void Modify_GetPartnerPermissionsApiCall(ref gaxgrpc::ApiCall<GetPartnerPermissionsRequest, PartnerPermissions> call);

        partial void Modify_ListAccessApprovalRequestsApiCall(ref gaxgrpc::ApiCall<ListAccessApprovalRequestsRequest, ListAccessApprovalRequestsResponse> call);

        partial void Modify_GetPartnerApiCall(ref gaxgrpc::ApiCall<GetPartnerRequest, Partner> call);

        partial void OnConstruction(CloudControlsPartnerCore.CloudControlsPartnerCoreClient grpcClient, CloudControlsPartnerCoreSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CloudControlsPartnerCore client</summary>
        public override CloudControlsPartnerCore.CloudControlsPartnerCoreClient GrpcClient { get; }

        partial void Modify_GetWorkloadRequest(ref GetWorkloadRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListWorkloadsRequest(ref ListWorkloadsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCustomerRequest(ref GetCustomerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCustomersRequest(ref ListCustomersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEkmConnectionsRequest(ref GetEkmConnectionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPartnerPermissionsRequest(ref GetPartnerPermissionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAccessApprovalRequestsRequest(ref ListAccessApprovalRequestsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPartnerRequest(ref GetPartnerRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets details of a single workload
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Workload GetWorkload(GetWorkloadRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWorkloadRequest(ref request, ref callSettings);
            return _callGetWorkload.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single workload
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Workload> GetWorkloadAsync(GetWorkloadRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWorkloadRequest(ref request, ref callSettings);
            return _callGetWorkload.Async(request, callSettings);
        }

        /// <summary>
        /// Lists customer workloads for a given customer org id
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Workload"/> resources.</returns>
        public override gax::PagedEnumerable<ListWorkloadsResponse, Workload> ListWorkloads(ListWorkloadsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListWorkloadsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListWorkloadsRequest, ListWorkloadsResponse, Workload>(_callListWorkloads, request, callSettings);
        }

        /// <summary>
        /// Lists customer workloads for a given customer org id
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Workload"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListWorkloadsResponse, Workload> ListWorkloadsAsync(ListWorkloadsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListWorkloadsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListWorkloadsRequest, ListWorkloadsResponse, Workload>(_callListWorkloads, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single customer
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Customer GetCustomer(GetCustomerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomerRequest(ref request, ref callSettings);
            return _callGetCustomer.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single customer
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Customer> GetCustomerAsync(GetCustomerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomerRequest(ref request, ref callSettings);
            return _callGetCustomer.Async(request, callSettings);
        }

        /// <summary>
        /// Lists customers of a partner identified by its Google Cloud organization ID
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Customer"/> resources.</returns>
        public override gax::PagedEnumerable<ListCustomersResponse, Customer> ListCustomers(ListCustomersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCustomersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCustomersRequest, ListCustomersResponse, Customer>(_callListCustomers, request, callSettings);
        }

        /// <summary>
        /// Lists customers of a partner identified by its Google Cloud organization ID
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Customer"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCustomersResponse, Customer> ListCustomersAsync(ListCustomersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCustomersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCustomersRequest, ListCustomersResponse, Customer>(_callListCustomers, request, callSettings);
        }

        /// <summary>
        /// Gets the EKM connections associated with a workload
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EkmConnections GetEkmConnections(GetEkmConnectionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEkmConnectionsRequest(ref request, ref callSettings);
            return _callGetEkmConnections.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the EKM connections associated with a workload
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EkmConnections> GetEkmConnectionsAsync(GetEkmConnectionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEkmConnectionsRequest(ref request, ref callSettings);
            return _callGetEkmConnections.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the partner permissions granted for a workload
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PartnerPermissions GetPartnerPermissions(GetPartnerPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPartnerPermissionsRequest(ref request, ref callSettings);
            return _callGetPartnerPermissions.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the partner permissions granted for a workload
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PartnerPermissions> GetPartnerPermissionsAsync(GetPartnerPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPartnerPermissionsRequest(ref request, ref callSettings);
            return _callGetPartnerPermissions.Async(request, callSettings);
        }

        /// <summary>
        /// Deprecated: Only returns access approval requests directly associated with
        /// an assured workload folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AccessApprovalRequest"/> resources.</returns>
        [sys::ObsoleteAttribute]
        public override gax::PagedEnumerable<ListAccessApprovalRequestsResponse, AccessApprovalRequest> ListAccessApprovalRequests(ListAccessApprovalRequestsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAccessApprovalRequestsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAccessApprovalRequestsRequest, ListAccessApprovalRequestsResponse, AccessApprovalRequest>(_callListAccessApprovalRequests, request, callSettings);
        }

        /// <summary>
        /// Deprecated: Only returns access approval requests directly associated with
        /// an assured workload folder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AccessApprovalRequest"/> resources.</returns>
        [sys::ObsoleteAttribute]
        public override gax::PagedAsyncEnumerable<ListAccessApprovalRequestsResponse, AccessApprovalRequest> ListAccessApprovalRequestsAsync(ListAccessApprovalRequestsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAccessApprovalRequestsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAccessApprovalRequestsRequest, ListAccessApprovalRequestsResponse, AccessApprovalRequest>(_callListAccessApprovalRequests, request, callSettings);
        }

        /// <summary>
        /// Get details of a Partner.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Partner GetPartner(GetPartnerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPartnerRequest(ref request, ref callSettings);
            return _callGetPartner.Sync(request, callSettings);
        }

        /// <summary>
        /// Get details of a Partner.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Partner> GetPartnerAsync(GetPartnerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPartnerRequest(ref request, ref callSettings);
            return _callGetPartner.Async(request, callSettings);
        }
    }

    public partial class ListWorkloadsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCustomersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAccessApprovalRequestsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListWorkloadsResponse : gaxgrpc::IPageResponse<Workload>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Workload> GetEnumerator() => Workloads.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListCustomersResponse : gaxgrpc::IPageResponse<Customer>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Customer> GetEnumerator() => Customers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAccessApprovalRequestsResponse : gaxgrpc::IPageResponse<AccessApprovalRequest>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AccessApprovalRequest> GetEnumerator() => AccessApprovalRequests.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
