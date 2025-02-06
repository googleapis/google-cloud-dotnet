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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Monitoring.V3
{
    /// <summary>Settings for <see cref="SnoozeServiceClient"/> instances.</summary>
    public sealed partial class SnoozeServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SnoozeServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SnoozeServiceSettings"/>.</returns>
        public static SnoozeServiceSettings GetDefault() => new SnoozeServiceSettings();

        /// <summary>Constructs a new <see cref="SnoozeServiceSettings"/> object with default settings.</summary>
        public SnoozeServiceSettings()
        {
        }

        private SnoozeServiceSettings(SnoozeServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateSnoozeSettings = existing.CreateSnoozeSettings;
            ListSnoozesSettings = existing.ListSnoozesSettings;
            GetSnoozeSettings = existing.GetSnoozeSettings;
            UpdateSnoozeSettings = existing.UpdateSnoozeSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SnoozeServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SnoozeServiceClient.CreateSnooze</c> and <c>SnoozeServiceClient.CreateSnoozeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSnoozeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SnoozeServiceClient.ListSnoozes</c> and <c>SnoozeServiceClient.ListSnoozesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSnoozesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SnoozeServiceClient.GetSnooze</c> and <c>SnoozeServiceClient.GetSnoozeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSnoozeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SnoozeServiceClient.UpdateSnooze</c> and <c>SnoozeServiceClient.UpdateSnoozeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSnoozeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SnoozeServiceSettings"/> object.</returns>
        public SnoozeServiceSettings Clone() => new SnoozeServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SnoozeServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class SnoozeServiceClientBuilder : gaxgrpc::ClientBuilderBase<SnoozeServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SnoozeServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SnoozeServiceClientBuilder() : base(SnoozeServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SnoozeServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SnoozeServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SnoozeServiceClient Build()
        {
            SnoozeServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SnoozeServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SnoozeServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SnoozeServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SnoozeServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SnoozeServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SnoozeServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SnoozeServiceClient.ChannelPool;
    }

    /// <summary>SnoozeService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The SnoozeService API is used to temporarily prevent an alert policy from
    /// generating alerts. A Snooze is a description of the criteria under which one
    /// or more alert policies should not fire alerts for the specified duration.
    /// </remarks>
    public abstract partial class SnoozeServiceClient
    {
        /// <summary>
        /// The default endpoint for the SnoozeService service, which is a host of "monitoring.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "monitoring.googleapis.com:443";

        /// <summary>The default SnoozeService scopes.</summary>
        /// <remarks>
        /// The default SnoozeService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/monitoring</description></item>
        /// <item><description>https://www.googleapis.com/auth/monitoring.read</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/monitoring",
            "https://www.googleapis.com/auth/monitoring.read",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SnoozeService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SnoozeServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SnoozeServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SnoozeServiceClient"/>.</returns>
        public static stt::Task<SnoozeServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SnoozeServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SnoozeServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SnoozeServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SnoozeServiceClient"/>.</returns>
        public static SnoozeServiceClient Create() => new SnoozeServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SnoozeServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SnoozeServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SnoozeServiceClient"/>.</returns>
        internal static SnoozeServiceClient Create(grpccore::CallInvoker callInvoker, SnoozeServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SnoozeService.SnoozeServiceClient grpcClient = new SnoozeService.SnoozeServiceClient(callInvoker);
            return new SnoozeServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC SnoozeService client</summary>
        public virtual SnoozeService.SnoozeServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `Snooze` that will prevent alerts, which match the provided
        /// criteria, from being opened. The `Snooze` applies for a specific time
        /// interval.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Snooze CreateSnooze(CreateSnoozeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `Snooze` that will prevent alerts, which match the provided
        /// criteria, from being opened. The `Snooze` applies for a specific time
        /// interval.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snooze> CreateSnoozeAsync(CreateSnoozeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `Snooze` that will prevent alerts, which match the provided
        /// criteria, from being opened. The `Snooze` applies for a specific time
        /// interval.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snooze> CreateSnoozeAsync(CreateSnoozeRequest request, st::CancellationToken cancellationToken) =>
            CreateSnoozeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `Snooze` that will prevent alerts, which match the provided
        /// criteria, from being opened. The `Snooze` applies for a specific time
        /// interval.
        /// </summary>
        /// <param name="parent">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// a `Snooze` should be created. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="snooze">
        /// Required. The `Snooze` to create. Omit the `name` field, as it will be
        /// filled in by the API.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Snooze CreateSnooze(string parent, Snooze snooze, gaxgrpc::CallSettings callSettings = null) =>
            CreateSnooze(new CreateSnoozeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Snooze = gax::GaxPreconditions.CheckNotNull(snooze, nameof(snooze)),
            }, callSettings);

        /// <summary>
        /// Creates a `Snooze` that will prevent alerts, which match the provided
        /// criteria, from being opened. The `Snooze` applies for a specific time
        /// interval.
        /// </summary>
        /// <param name="parent">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// a `Snooze` should be created. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="snooze">
        /// Required. The `Snooze` to create. Omit the `name` field, as it will be
        /// filled in by the API.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snooze> CreateSnoozeAsync(string parent, Snooze snooze, gaxgrpc::CallSettings callSettings = null) =>
            CreateSnoozeAsync(new CreateSnoozeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Snooze = gax::GaxPreconditions.CheckNotNull(snooze, nameof(snooze)),
            }, callSettings);

        /// <summary>
        /// Creates a `Snooze` that will prevent alerts, which match the provided
        /// criteria, from being opened. The `Snooze` applies for a specific time
        /// interval.
        /// </summary>
        /// <param name="parent">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// a `Snooze` should be created. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="snooze">
        /// Required. The `Snooze` to create. Omit the `name` field, as it will be
        /// filled in by the API.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snooze> CreateSnoozeAsync(string parent, Snooze snooze, st::CancellationToken cancellationToken) =>
            CreateSnoozeAsync(parent, snooze, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `Snooze` that will prevent alerts, which match the provided
        /// criteria, from being opened. The `Snooze` applies for a specific time
        /// interval.
        /// </summary>
        /// <param name="parent">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// a `Snooze` should be created. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="snooze">
        /// Required. The `Snooze` to create. Omit the `name` field, as it will be
        /// filled in by the API.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Snooze CreateSnooze(gagr::ProjectName parent, Snooze snooze, gaxgrpc::CallSettings callSettings = null) =>
            CreateSnooze(new CreateSnoozeRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Snooze = gax::GaxPreconditions.CheckNotNull(snooze, nameof(snooze)),
            }, callSettings);

        /// <summary>
        /// Creates a `Snooze` that will prevent alerts, which match the provided
        /// criteria, from being opened. The `Snooze` applies for a specific time
        /// interval.
        /// </summary>
        /// <param name="parent">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// a `Snooze` should be created. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="snooze">
        /// Required. The `Snooze` to create. Omit the `name` field, as it will be
        /// filled in by the API.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snooze> CreateSnoozeAsync(gagr::ProjectName parent, Snooze snooze, gaxgrpc::CallSettings callSettings = null) =>
            CreateSnoozeAsync(new CreateSnoozeRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Snooze = gax::GaxPreconditions.CheckNotNull(snooze, nameof(snooze)),
            }, callSettings);

        /// <summary>
        /// Creates a `Snooze` that will prevent alerts, which match the provided
        /// criteria, from being opened. The `Snooze` applies for a specific time
        /// interval.
        /// </summary>
        /// <param name="parent">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// a `Snooze` should be created. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="snooze">
        /// Required. The `Snooze` to create. Omit the `name` field, as it will be
        /// filled in by the API.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snooze> CreateSnoozeAsync(gagr::ProjectName parent, Snooze snooze, st::CancellationToken cancellationToken) =>
            CreateSnoozeAsync(parent, snooze, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the `Snooze`s associated with a project. Can optionally pass in
        /// `filter`, which specifies predicates to match `Snooze`s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Snooze"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSnoozesResponse, Snooze> ListSnoozes(ListSnoozesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the `Snooze`s associated with a project. Can optionally pass in
        /// `filter`, which specifies predicates to match `Snooze`s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Snooze"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSnoozesResponse, Snooze> ListSnoozesAsync(ListSnoozesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the `Snooze`s associated with a project. Can optionally pass in
        /// `filter`, which specifies predicates to match `Snooze`s.
        /// </summary>
        /// <param name="parent">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) whose
        /// `Snooze`s should be listed. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
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
        /// <returns>A pageable sequence of <see cref="Snooze"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSnoozesResponse, Snooze> ListSnoozes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSnoozesRequest request = new ListSnoozesRequest
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
            return ListSnoozes(request, callSettings);
        }

        /// <summary>
        /// Lists the `Snooze`s associated with a project. Can optionally pass in
        /// `filter`, which specifies predicates to match `Snooze`s.
        /// </summary>
        /// <param name="parent">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) whose
        /// `Snooze`s should be listed. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
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
        /// <returns>A pageable asynchronous sequence of <see cref="Snooze"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSnoozesResponse, Snooze> ListSnoozesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSnoozesRequest request = new ListSnoozesRequest
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
            return ListSnoozesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the `Snooze`s associated with a project. Can optionally pass in
        /// `filter`, which specifies predicates to match `Snooze`s.
        /// </summary>
        /// <param name="parent">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) whose
        /// `Snooze`s should be listed. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
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
        /// <returns>A pageable sequence of <see cref="Snooze"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSnoozesResponse, Snooze> ListSnoozes(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSnoozesRequest request = new ListSnoozesRequest
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
            return ListSnoozes(request, callSettings);
        }

        /// <summary>
        /// Lists the `Snooze`s associated with a project. Can optionally pass in
        /// `filter`, which specifies predicates to match `Snooze`s.
        /// </summary>
        /// <param name="parent">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) whose
        /// `Snooze`s should be listed. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
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
        /// <returns>A pageable asynchronous sequence of <see cref="Snooze"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSnoozesResponse, Snooze> ListSnoozesAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSnoozesRequest request = new ListSnoozesRequest
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
            return ListSnoozesAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a `Snooze` by `name`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Snooze GetSnooze(GetSnoozeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `Snooze` by `name`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snooze> GetSnoozeAsync(GetSnoozeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `Snooze` by `name`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snooze> GetSnoozeAsync(GetSnoozeRequest request, st::CancellationToken cancellationToken) =>
            GetSnoozeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `Snooze` by `name`.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the `Snooze` to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/snoozes/[SNOOZE_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Snooze GetSnooze(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSnooze(new GetSnoozeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `Snooze` by `name`.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the `Snooze` to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/snoozes/[SNOOZE_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snooze> GetSnoozeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSnoozeAsync(new GetSnoozeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `Snooze` by `name`.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the `Snooze` to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/snoozes/[SNOOZE_ID]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snooze> GetSnoozeAsync(string name, st::CancellationToken cancellationToken) =>
            GetSnoozeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `Snooze` by `name`.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the `Snooze` to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/snoozes/[SNOOZE_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Snooze GetSnooze(SnoozeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSnooze(new GetSnoozeRequest
            {
                SnoozeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `Snooze` by `name`.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the `Snooze` to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/snoozes/[SNOOZE_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snooze> GetSnoozeAsync(SnoozeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSnoozeAsync(new GetSnoozeRequest
            {
                SnoozeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `Snooze` by `name`.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the `Snooze` to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/snoozes/[SNOOZE_ID]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snooze> GetSnoozeAsync(SnoozeName name, st::CancellationToken cancellationToken) =>
            GetSnoozeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `Snooze`, identified by its `name`, with the parameters in the
        /// given `Snooze` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Snooze UpdateSnooze(UpdateSnoozeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `Snooze`, identified by its `name`, with the parameters in the
        /// given `Snooze` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snooze> UpdateSnoozeAsync(UpdateSnoozeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `Snooze`, identified by its `name`, with the parameters in the
        /// given `Snooze` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snooze> UpdateSnoozeAsync(UpdateSnoozeRequest request, st::CancellationToken cancellationToken) =>
            UpdateSnoozeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `Snooze`, identified by its `name`, with the parameters in the
        /// given `Snooze` object.
        /// </summary>
        /// <param name="snooze">
        /// Required. The `Snooze` to update. Must have the name field present.
        /// </param>
        /// <param name="updateMask">
        /// Required. The fields to update.
        /// 
        /// For each field listed in `update_mask`:
        /// 
        /// * If the `Snooze` object supplied in the `UpdateSnoozeRequest` has a
        /// value for that field, the value of the field in the existing `Snooze`
        /// will be set to the value of the field in the supplied `Snooze`.
        /// * If the field does not have a value in the supplied `Snooze`, the field
        /// in the existing `Snooze` is set to its default value.
        /// 
        /// Fields not listed retain their existing value.
        /// 
        /// The following are the field names that are accepted in `update_mask`:
        /// 
        /// * `display_name`
        /// * `interval.start_time`
        /// * `interval.end_time`
        /// 
        /// That said, the start time and end time of the `Snooze` determines which
        /// fields can legally be updated. Before attempting an update, users should
        /// consult the documentation for `UpdateSnoozeRequest`, which talks about
        /// which fields can be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Snooze UpdateSnooze(Snooze snooze, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSnooze(new UpdateSnoozeRequest
            {
                Snooze = gax::GaxPreconditions.CheckNotNull(snooze, nameof(snooze)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a `Snooze`, identified by its `name`, with the parameters in the
        /// given `Snooze` object.
        /// </summary>
        /// <param name="snooze">
        /// Required. The `Snooze` to update. Must have the name field present.
        /// </param>
        /// <param name="updateMask">
        /// Required. The fields to update.
        /// 
        /// For each field listed in `update_mask`:
        /// 
        /// * If the `Snooze` object supplied in the `UpdateSnoozeRequest` has a
        /// value for that field, the value of the field in the existing `Snooze`
        /// will be set to the value of the field in the supplied `Snooze`.
        /// * If the field does not have a value in the supplied `Snooze`, the field
        /// in the existing `Snooze` is set to its default value.
        /// 
        /// Fields not listed retain their existing value.
        /// 
        /// The following are the field names that are accepted in `update_mask`:
        /// 
        /// * `display_name`
        /// * `interval.start_time`
        /// * `interval.end_time`
        /// 
        /// That said, the start time and end time of the `Snooze` determines which
        /// fields can legally be updated. Before attempting an update, users should
        /// consult the documentation for `UpdateSnoozeRequest`, which talks about
        /// which fields can be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snooze> UpdateSnoozeAsync(Snooze snooze, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSnoozeAsync(new UpdateSnoozeRequest
            {
                Snooze = gax::GaxPreconditions.CheckNotNull(snooze, nameof(snooze)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a `Snooze`, identified by its `name`, with the parameters in the
        /// given `Snooze` object.
        /// </summary>
        /// <param name="snooze">
        /// Required. The `Snooze` to update. Must have the name field present.
        /// </param>
        /// <param name="updateMask">
        /// Required. The fields to update.
        /// 
        /// For each field listed in `update_mask`:
        /// 
        /// * If the `Snooze` object supplied in the `UpdateSnoozeRequest` has a
        /// value for that field, the value of the field in the existing `Snooze`
        /// will be set to the value of the field in the supplied `Snooze`.
        /// * If the field does not have a value in the supplied `Snooze`, the field
        /// in the existing `Snooze` is set to its default value.
        /// 
        /// Fields not listed retain their existing value.
        /// 
        /// The following are the field names that are accepted in `update_mask`:
        /// 
        /// * `display_name`
        /// * `interval.start_time`
        /// * `interval.end_time`
        /// 
        /// That said, the start time and end time of the `Snooze` determines which
        /// fields can legally be updated. Before attempting an update, users should
        /// consult the documentation for `UpdateSnoozeRequest`, which talks about
        /// which fields can be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snooze> UpdateSnoozeAsync(Snooze snooze, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSnoozeAsync(snooze, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SnoozeService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The SnoozeService API is used to temporarily prevent an alert policy from
    /// generating alerts. A Snooze is a description of the criteria under which one
    /// or more alert policies should not fire alerts for the specified duration.
    /// </remarks>
    public sealed partial class SnoozeServiceClientImpl : SnoozeServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateSnoozeRequest, Snooze> _callCreateSnooze;

        private readonly gaxgrpc::ApiCall<ListSnoozesRequest, ListSnoozesResponse> _callListSnoozes;

        private readonly gaxgrpc::ApiCall<GetSnoozeRequest, Snooze> _callGetSnooze;

        private readonly gaxgrpc::ApiCall<UpdateSnoozeRequest, Snooze> _callUpdateSnooze;

        /// <summary>
        /// Constructs a client wrapper for the SnoozeService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SnoozeServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SnoozeServiceClientImpl(SnoozeService.SnoozeServiceClient grpcClient, SnoozeServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SnoozeServiceSettings effectiveSettings = settings ?? SnoozeServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCreateSnooze = clientHelper.BuildApiCall<CreateSnoozeRequest, Snooze>("CreateSnooze", grpcClient.CreateSnoozeAsync, grpcClient.CreateSnooze, effectiveSettings.CreateSnoozeSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSnooze);
            Modify_CreateSnoozeApiCall(ref _callCreateSnooze);
            _callListSnoozes = clientHelper.BuildApiCall<ListSnoozesRequest, ListSnoozesResponse>("ListSnoozes", grpcClient.ListSnoozesAsync, grpcClient.ListSnoozes, effectiveSettings.ListSnoozesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSnoozes);
            Modify_ListSnoozesApiCall(ref _callListSnoozes);
            _callGetSnooze = clientHelper.BuildApiCall<GetSnoozeRequest, Snooze>("GetSnooze", grpcClient.GetSnoozeAsync, grpcClient.GetSnooze, effectiveSettings.GetSnoozeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSnooze);
            Modify_GetSnoozeApiCall(ref _callGetSnooze);
            _callUpdateSnooze = clientHelper.BuildApiCall<UpdateSnoozeRequest, Snooze>("UpdateSnooze", grpcClient.UpdateSnoozeAsync, grpcClient.UpdateSnooze, effectiveSettings.UpdateSnoozeSettings).WithGoogleRequestParam("snooze.name", request => request.Snooze?.Name);
            Modify_ApiCall(ref _callUpdateSnooze);
            Modify_UpdateSnoozeApiCall(ref _callUpdateSnooze);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateSnoozeApiCall(ref gaxgrpc::ApiCall<CreateSnoozeRequest, Snooze> call);

        partial void Modify_ListSnoozesApiCall(ref gaxgrpc::ApiCall<ListSnoozesRequest, ListSnoozesResponse> call);

        partial void Modify_GetSnoozeApiCall(ref gaxgrpc::ApiCall<GetSnoozeRequest, Snooze> call);

        partial void Modify_UpdateSnoozeApiCall(ref gaxgrpc::ApiCall<UpdateSnoozeRequest, Snooze> call);

        partial void OnConstruction(SnoozeService.SnoozeServiceClient grpcClient, SnoozeServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SnoozeService client</summary>
        public override SnoozeService.SnoozeServiceClient GrpcClient { get; }

        partial void Modify_CreateSnoozeRequest(ref CreateSnoozeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSnoozesRequest(ref ListSnoozesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSnoozeRequest(ref GetSnoozeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSnoozeRequest(ref UpdateSnoozeRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a `Snooze` that will prevent alerts, which match the provided
        /// criteria, from being opened. The `Snooze` applies for a specific time
        /// interval.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Snooze CreateSnooze(CreateSnoozeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSnoozeRequest(ref request, ref callSettings);
            return _callCreateSnooze.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a `Snooze` that will prevent alerts, which match the provided
        /// criteria, from being opened. The `Snooze` applies for a specific time
        /// interval.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Snooze> CreateSnoozeAsync(CreateSnoozeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSnoozeRequest(ref request, ref callSettings);
            return _callCreateSnooze.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the `Snooze`s associated with a project. Can optionally pass in
        /// `filter`, which specifies predicates to match `Snooze`s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Snooze"/> resources.</returns>
        public override gax::PagedEnumerable<ListSnoozesResponse, Snooze> ListSnoozes(ListSnoozesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSnoozesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSnoozesRequest, ListSnoozesResponse, Snooze>(_callListSnoozes, request, callSettings);
        }

        /// <summary>
        /// Lists the `Snooze`s associated with a project. Can optionally pass in
        /// `filter`, which specifies predicates to match `Snooze`s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Snooze"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSnoozesResponse, Snooze> ListSnoozesAsync(ListSnoozesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSnoozesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSnoozesRequest, ListSnoozesResponse, Snooze>(_callListSnoozes, request, callSettings);
        }

        /// <summary>
        /// Retrieves a `Snooze` by `name`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Snooze GetSnooze(GetSnoozeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSnoozeRequest(ref request, ref callSettings);
            return _callGetSnooze.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a `Snooze` by `name`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Snooze> GetSnoozeAsync(GetSnoozeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSnoozeRequest(ref request, ref callSettings);
            return _callGetSnooze.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a `Snooze`, identified by its `name`, with the parameters in the
        /// given `Snooze` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Snooze UpdateSnooze(UpdateSnoozeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSnoozeRequest(ref request, ref callSettings);
            return _callUpdateSnooze.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a `Snooze`, identified by its `name`, with the parameters in the
        /// given `Snooze` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Snooze> UpdateSnoozeAsync(UpdateSnoozeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSnoozeRequest(ref request, ref callSettings);
            return _callUpdateSnooze.Async(request, callSettings);
        }
    }

    public partial class ListSnoozesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSnoozesResponse : gaxgrpc::IPageResponse<Snooze>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Snooze> GetEnumerator() => Snoozes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
