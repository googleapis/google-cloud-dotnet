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
using lro = Google.LongRunning;
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
    /// <summary>Settings for <see cref="HostsClient"/> instances.</summary>
    public sealed partial class HostsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="HostsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="HostsSettings"/>.</returns>
        public static HostsSettings GetDefault() => new HostsSettings();

        /// <summary>Constructs a new <see cref="HostsSettings"/> object with default settings.</summary>
        public HostsSettings()
        {
        }

        private HostsSettings(HostsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetSettings = existing.GetSettings;
            GetVersionSettings = existing.GetVersionSettings;
            GetVersionOperationsSettings = existing.GetVersionOperationsSettings.Clone();
            ListSettings = existing.ListSettings;
            OnCopy(existing);
        }

        partial void OnCopy(HostsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>HostsClient.Get</c> and
        /// <c>HostsClient.GetAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>HostsClient.GetVersion</c>
        /// and <c>HostsClient.GetVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetVersionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>HostsClient.GetVersion</c> and
        /// <c>HostsClient.GetVersionAsync</c>.
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
        public lro::OperationsSettings GetVersionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>HostsClient.List</c> and
        /// <c>HostsClient.ListAsync</c>.
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
        /// <returns>A deep clone of this <see cref="HostsSettings"/> object.</returns>
        public HostsSettings Clone() => new HostsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="HostsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class HostsClientBuilder : gaxgrpc::ClientBuilderBase<HostsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public HostsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public HostsClientBuilder() : base(HostsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref HostsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<HostsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override HostsClient Build()
        {
            HostsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<HostsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<HostsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private HostsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return HostsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<HostsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return HostsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => HostsClient.ChannelPool;
    }

    /// <summary>Hosts client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The Hosts API.
    /// </remarks>
    public abstract partial class HostsClient
    {
        /// <summary>
        /// The default endpoint for the Hosts service, which is a host of "compute.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default Hosts scopes.</summary>
        /// <remarks>
        /// The default Hosts scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/compute</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/compute",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Hosts.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="HostsClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="HostsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="HostsClient"/>.</returns>
        public static stt::Task<HostsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new HostsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="HostsClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="HostsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="HostsClient"/>.</returns>
        public static HostsClient Create() => new HostsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="HostsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="HostsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="HostsClient"/>.</returns>
        internal static HostsClient Create(grpccore::CallInvoker callInvoker, HostsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Hosts.HostsClient grpcClient = new Hosts.HostsClient(callInvoker);
            return new HostsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Hosts client</summary>
        public virtual Hosts.HostsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves information about the specified host.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Host Get(GetHostRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves information about the specified host.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Host> GetAsync(GetHostRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves information about the specified host.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Host> GetAsync(GetHostRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves information about the specified host.
        /// </summary>
        /// <param name="project">
        /// The project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request, formatted as RFC1035.
        /// </param>
        /// <param name="association">
        /// The parent resource association for the Host. This field specifies the
        /// hierarchical context (e.g., reservation, block, sub-block) when
        /// accessing the host. For example, reservations/reservation_name,
        /// reservations/reservation_name/reservationBlocks/reservation_block_name or
        /// reservations/reservation_name/reservationBlocks/reservation_block_name/reservationSubBlocks/reservation_sub_block_name.
        /// </param>
        /// <param name="host">
        /// The name of the host, formatted as RFC1035 or a resource ID
        /// number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Host Get(string project, string zone, string association, string host, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetHostRequest
            {
                Association = gax::GaxPreconditions.CheckNotNullOrEmpty(association, nameof(association)),
                Host = gax::GaxPreconditions.CheckNotNullOrEmpty(host, nameof(host)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Retrieves information about the specified host.
        /// </summary>
        /// <param name="project">
        /// The project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request, formatted as RFC1035.
        /// </param>
        /// <param name="association">
        /// The parent resource association for the Host. This field specifies the
        /// hierarchical context (e.g., reservation, block, sub-block) when
        /// accessing the host. For example, reservations/reservation_name,
        /// reservations/reservation_name/reservationBlocks/reservation_block_name or
        /// reservations/reservation_name/reservationBlocks/reservation_block_name/reservationSubBlocks/reservation_sub_block_name.
        /// </param>
        /// <param name="host">
        /// The name of the host, formatted as RFC1035 or a resource ID
        /// number.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Host> GetAsync(string project, string zone, string association, string host, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetHostRequest
            {
                Association = gax::GaxPreconditions.CheckNotNullOrEmpty(association, nameof(association)),
                Host = gax::GaxPreconditions.CheckNotNullOrEmpty(host, nameof(host)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Retrieves information about the specified host.
        /// </summary>
        /// <param name="project">
        /// The project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request, formatted as RFC1035.
        /// </param>
        /// <param name="association">
        /// The parent resource association for the Host. This field specifies the
        /// hierarchical context (e.g., reservation, block, sub-block) when
        /// accessing the host. For example, reservations/reservation_name,
        /// reservations/reservation_name/reservationBlocks/reservation_block_name or
        /// reservations/reservation_name/reservationBlocks/reservation_block_name/reservationSubBlocks/reservation_sub_block_name.
        /// </param>
        /// <param name="host">
        /// The name of the host, formatted as RFC1035 or a resource ID
        /// number.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Host> GetAsync(string project, string zone, string association, string host, st::CancellationToken cancellationToken) =>
            GetAsync(project, zone, association, host, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Allows customers to get SBOM versions of a host.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> GetVersion(GetVersionHostRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Allows customers to get SBOM versions of a host.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> GetVersionAsync(GetVersionHostRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Allows customers to get SBOM versions of a host.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> GetVersionAsync(GetVersionHostRequest request, st::CancellationToken cancellationToken) =>
            GetVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>GetVersion</c>.</summary>
        public virtual lro::OperationsClient GetVersionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>GetVersion</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceGetVersion(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), GetVersionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>GetVersion</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceGetVersionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), GetVersionOperationsClient, callSettings);

        /// <summary>
        /// Allows customers to get SBOM versions of a host.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// Name of the zone for this request. Zone name should conform to RFC1035.
        /// </param>
        /// <param name="association">
        /// The parent resource association for the Host. This field specifies the
        /// hierarchical context (e.g., reservation, block, sub-block) when
        /// accessing the host.
        /// </param>
        /// <param name="host">
        /// The name of the host, formatted as RFC1035 or a resource ID
        /// number.
        /// </param>
        /// <param name="hostsGetVersionRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> GetVersion(string project, string zone, string association, string host, HostsGetVersionRequest hostsGetVersionRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            GetVersion(new GetVersionHostRequest
            {
                Association = gax::GaxPreconditions.CheckNotNullOrEmpty(association, nameof(association)),
                Host = gax::GaxPreconditions.CheckNotNullOrEmpty(host, nameof(host)),
                HostsGetVersionRequestResource = gax::GaxPreconditions.CheckNotNull(hostsGetVersionRequestResource, nameof(hostsGetVersionRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Allows customers to get SBOM versions of a host.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// Name of the zone for this request. Zone name should conform to RFC1035.
        /// </param>
        /// <param name="association">
        /// The parent resource association for the Host. This field specifies the
        /// hierarchical context (e.g., reservation, block, sub-block) when
        /// accessing the host.
        /// </param>
        /// <param name="host">
        /// The name of the host, formatted as RFC1035 or a resource ID
        /// number.
        /// </param>
        /// <param name="hostsGetVersionRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> GetVersionAsync(string project, string zone, string association, string host, HostsGetVersionRequest hostsGetVersionRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            GetVersionAsync(new GetVersionHostRequest
            {
                Association = gax::GaxPreconditions.CheckNotNullOrEmpty(association, nameof(association)),
                Host = gax::GaxPreconditions.CheckNotNullOrEmpty(host, nameof(host)),
                HostsGetVersionRequestResource = gax::GaxPreconditions.CheckNotNull(hostsGetVersionRequestResource, nameof(hostsGetVersionRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Allows customers to get SBOM versions of a host.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// Name of the zone for this request. Zone name should conform to RFC1035.
        /// </param>
        /// <param name="association">
        /// The parent resource association for the Host. This field specifies the
        /// hierarchical context (e.g., reservation, block, sub-block) when
        /// accessing the host.
        /// </param>
        /// <param name="host">
        /// The name of the host, formatted as RFC1035 or a resource ID
        /// number.
        /// </param>
        /// <param name="hostsGetVersionRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> GetVersionAsync(string project, string zone, string association, string host, HostsGetVersionRequest hostsGetVersionRequestResource, st::CancellationToken cancellationToken) =>
            GetVersionAsync(project, zone, association, host, hostsGetVersionRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a list of hosts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Host"/> resources.</returns>
        public virtual gax::PagedEnumerable<HostsListResponse, Host> List(ListHostsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of hosts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Host"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<HostsListResponse, Host> ListAsync(ListHostsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of hosts.
        /// </summary>
        /// <param name="project">
        /// The project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request, formatted as RFC1035.
        /// </param>
        /// <param name="association">
        /// The parent resource association for the Host. This field specifies the
        /// hierarchical context (e.g., reservation, block, sub-block) when
        /// accessing the host. For example, reservations/reservation_name,
        /// reservations/reservation_name/reservationBlocks/reservation_block_name or
        /// reservations/reservation_name/reservationBlocks/reservation_block_name/reservationSubBlocks/reservation_sub_block_name.
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
        /// <returns>A pageable sequence of <see cref="Host"/> resources.</returns>
        public virtual gax::PagedEnumerable<HostsListResponse, Host> List(string project, string zone, string association, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHostsRequest request = new ListHostsRequest
            {
                Association = gax::GaxPreconditions.CheckNotNullOrEmpty(association, nameof(association)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
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
        /// Retrieves a list of hosts.
        /// </summary>
        /// <param name="project">
        /// The project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request, formatted as RFC1035.
        /// </param>
        /// <param name="association">
        /// The parent resource association for the Host. This field specifies the
        /// hierarchical context (e.g., reservation, block, sub-block) when
        /// accessing the host. For example, reservations/reservation_name,
        /// reservations/reservation_name/reservationBlocks/reservation_block_name or
        /// reservations/reservation_name/reservationBlocks/reservation_block_name/reservationSubBlocks/reservation_sub_block_name.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Host"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<HostsListResponse, Host> ListAsync(string project, string zone, string association, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListHostsRequest request = new ListHostsRequest
            {
                Association = gax::GaxPreconditions.CheckNotNullOrEmpty(association, nameof(association)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
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

    /// <summary>Hosts client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The Hosts API.
    /// </remarks>
    public sealed partial class HostsClientImpl : HostsClient
    {
        private readonly gaxgrpc::ApiCall<GetHostRequest, Host> _callGet;

        private readonly gaxgrpc::ApiCall<GetVersionHostRequest, Operation> _callGetVersion;

        private readonly gaxgrpc::ApiCall<ListHostsRequest, HostsListResponse> _callList;

        /// <summary>
        /// Constructs a client wrapper for the Hosts service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="HostsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public HostsClientImpl(Hosts.HostsClient grpcClient, HostsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            HostsSettings effectiveSettings = settings ?? HostsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            GetVersionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForZoneOperations(), effectiveSettings.GetVersionOperationsSettings, logger);
            _callGet = clientHelper.BuildApiCall<GetHostRequest, Host>("Get", grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("association", request => request.Association).WithGoogleRequestParam("host", request => request.Host);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callGetVersion = clientHelper.BuildApiCall<GetVersionHostRequest, Operation>("GetVersion", grpcClient.GetVersionAsync, grpcClient.GetVersion, effectiveSettings.GetVersionSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("association", request => request.Association).WithGoogleRequestParam("host", request => request.Host);
            Modify_ApiCall(ref _callGetVersion);
            Modify_GetVersionApiCall(ref _callGetVersion);
            _callList = clientHelper.BuildApiCall<ListHostsRequest, HostsListResponse>("List", grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("association", request => request.Association);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetHostRequest, Host> call);

        partial void Modify_GetVersionApiCall(ref gaxgrpc::ApiCall<GetVersionHostRequest, Operation> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListHostsRequest, HostsListResponse> call);

        partial void OnConstruction(Hosts.HostsClient grpcClient, HostsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Hosts client</summary>
        public override Hosts.HostsClient GrpcClient { get; }

        partial void Modify_GetHostRequest(ref GetHostRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetVersionHostRequest(ref GetVersionHostRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListHostsRequest(ref ListHostsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves information about the specified host.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Host Get(GetHostRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetHostRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves information about the specified host.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Host> GetAsync(GetHostRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetHostRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>GetVersion</c>.</summary>
        public override lro::OperationsClient GetVersionOperationsClient { get; }

        /// <summary>
        /// Allows customers to get SBOM versions of a host.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> GetVersion(GetVersionHostRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVersionHostRequest(ref request, ref callSettings);
            Operation response = _callGetVersion.Sync(request, callSettings);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), GetVersionOperationsClient);
        }

        /// <summary>
        /// Allows customers to get SBOM versions of a host.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> GetVersionAsync(GetVersionHostRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVersionHostRequest(ref request, ref callSettings);
            Operation response = await _callGetVersion.Async(request, callSettings).ConfigureAwait(false);
            GetZoneOperationRequest pollRequest = GetZoneOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), GetVersionOperationsClient);
        }

        /// <summary>
        /// Retrieves a list of hosts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Host"/> resources.</returns>
        public override gax::PagedEnumerable<HostsListResponse, Host> List(ListHostsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListHostsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListHostsRequest, HostsListResponse, Host>(_callList, request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of hosts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Host"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<HostsListResponse, Host> ListAsync(ListHostsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListHostsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListHostsRequest, HostsListResponse, Host>(_callList, request, callSettings);
        }
    }

    public partial class ListHostsRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class HostsListResponse : gaxgrpc::IPageResponse<Host>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Host> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Hosts
    {
        public partial class HostsClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client, delegating to ZoneOperations.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClientForZoneOperations() =>
                ZoneOperations.ZoneOperationsClient.CreateOperationsClient(CallInvoker);
        }
    }
}
