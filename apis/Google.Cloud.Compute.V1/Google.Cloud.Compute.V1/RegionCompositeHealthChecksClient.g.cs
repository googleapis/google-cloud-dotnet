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
    /// <summary>Settings for <see cref="RegionCompositeHealthChecksClient"/> instances.</summary>
    public sealed partial class RegionCompositeHealthChecksSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="RegionCompositeHealthChecksSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="RegionCompositeHealthChecksSettings"/>.</returns>
        public static RegionCompositeHealthChecksSettings GetDefault() => new RegionCompositeHealthChecksSettings();

        /// <summary>
        /// Constructs a new <see cref="RegionCompositeHealthChecksSettings"/> object with default settings.
        /// </summary>
        public RegionCompositeHealthChecksSettings()
        {
        }

        private RegionCompositeHealthChecksSettings(RegionCompositeHealthChecksSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            AggregatedListSettings = existing.AggregatedListSettings;
            DeleteSettings = existing.DeleteSettings;
            DeleteOperationsSettings = existing.DeleteOperationsSettings.Clone();
            GetSettings = existing.GetSettings;
            InsertSettings = existing.InsertSettings;
            InsertOperationsSettings = existing.InsertOperationsSettings.Clone();
            ListSettings = existing.ListSettings;
            PatchSettings = existing.PatchSettings;
            PatchOperationsSettings = existing.PatchOperationsSettings.Clone();
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(RegionCompositeHealthChecksSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionCompositeHealthChecksClient.AggregatedList</c> and
        /// <c>RegionCompositeHealthChecksClient.AggregatedListAsync</c>.
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
        public gaxgrpc::CallSettings AggregatedListSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionCompositeHealthChecksClient.Delete</c> and <c>RegionCompositeHealthChecksClient.DeleteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RegionCompositeHealthChecksClient.Delete</c> and
        /// <c>RegionCompositeHealthChecksClient.DeleteAsync</c>.
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
        public lro::OperationsSettings DeleteOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionCompositeHealthChecksClient.Get</c> and <c>RegionCompositeHealthChecksClient.GetAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionCompositeHealthChecksClient.Insert</c> and <c>RegionCompositeHealthChecksClient.InsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InsertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RegionCompositeHealthChecksClient.Insert</c> and
        /// <c>RegionCompositeHealthChecksClient.InsertAsync</c>.
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
        public lro::OperationsSettings InsertOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionCompositeHealthChecksClient.List</c> and <c>RegionCompositeHealthChecksClient.ListAsync</c>.
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

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionCompositeHealthChecksClient.Patch</c> and <c>RegionCompositeHealthChecksClient.PatchAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PatchSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RegionCompositeHealthChecksClient.Patch</c> and
        /// <c>RegionCompositeHealthChecksClient.PatchAsync</c>.
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
        public lro::OperationsSettings PatchOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionCompositeHealthChecksClient.TestIamPermissions</c> and
        /// <c>RegionCompositeHealthChecksClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="RegionCompositeHealthChecksSettings"/> object.</returns>
        public RegionCompositeHealthChecksSettings Clone() => new RegionCompositeHealthChecksSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RegionCompositeHealthChecksClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class RegionCompositeHealthChecksClientBuilder : gaxgrpc::ClientBuilderBase<RegionCompositeHealthChecksClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RegionCompositeHealthChecksSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public RegionCompositeHealthChecksClientBuilder() : base(RegionCompositeHealthChecksClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref RegionCompositeHealthChecksClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RegionCompositeHealthChecksClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override RegionCompositeHealthChecksClient Build()
        {
            RegionCompositeHealthChecksClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RegionCompositeHealthChecksClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RegionCompositeHealthChecksClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RegionCompositeHealthChecksClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RegionCompositeHealthChecksClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<RegionCompositeHealthChecksClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RegionCompositeHealthChecksClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => RegionCompositeHealthChecksClient.ChannelPool;
    }

    /// <summary>RegionCompositeHealthChecks client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The RegionCompositeHealthChecks API.
    /// </remarks>
    public abstract partial class RegionCompositeHealthChecksClient
    {
        /// <summary>
        /// The default endpoint for the RegionCompositeHealthChecks service, which is a host of
        /// "compute.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default RegionCompositeHealthChecks scopes.</summary>
        /// <remarks>
        /// The default RegionCompositeHealthChecks scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(RegionCompositeHealthChecks.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="RegionCompositeHealthChecksClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="RegionCompositeHealthChecksClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="RegionCompositeHealthChecksClient"/>.</returns>
        public static stt::Task<RegionCompositeHealthChecksClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RegionCompositeHealthChecksClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RegionCompositeHealthChecksClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="RegionCompositeHealthChecksClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="RegionCompositeHealthChecksClient"/>.</returns>
        public static RegionCompositeHealthChecksClient Create() => new RegionCompositeHealthChecksClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RegionCompositeHealthChecksClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RegionCompositeHealthChecksSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="RegionCompositeHealthChecksClient"/>.</returns>
        internal static RegionCompositeHealthChecksClient Create(grpccore::CallInvoker callInvoker, RegionCompositeHealthChecksSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            RegionCompositeHealthChecks.RegionCompositeHealthChecksClient grpcClient = new RegionCompositeHealthChecks.RegionCompositeHealthChecksClient(callInvoker);
            return new RegionCompositeHealthChecksClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC RegionCompositeHealthChecks client</summary>
        public virtual RegionCompositeHealthChecks.RegionCompositeHealthChecksClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of all CompositeHealthCheck resources (all
        /// regional) available to the specified project.
        /// 
        /// To prevent failure, it is recommended that you set the
        /// `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.</returns>
        public virtual gax::PagedEnumerable<CompositeHealthCheckAggregatedList, scg::KeyValuePair<string, CompositeHealthChecksScopedList>> AggregatedList(AggregatedListRegionCompositeHealthChecksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of all CompositeHealthCheck resources (all
        /// regional) available to the specified project.
        /// 
        /// To prevent failure, it is recommended that you set the
        /// `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<CompositeHealthCheckAggregatedList, scg::KeyValuePair<string, CompositeHealthChecksScopedList>> AggregatedListAsync(AggregatedListRegionCompositeHealthChecksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of all CompositeHealthCheck resources (all
        /// regional) available to the specified project.
        /// 
        /// To prevent failure, it is recommended that you set the
        /// `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="project">
        /// Name of the project scoping this request.
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
        /// <returns>A pageable sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.</returns>
        public virtual gax::PagedEnumerable<CompositeHealthCheckAggregatedList, scg::KeyValuePair<string, CompositeHealthChecksScopedList>> AggregatedList(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            AggregatedListRegionCompositeHealthChecksRequest request = new AggregatedListRegionCompositeHealthChecksRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return AggregatedList(request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of all CompositeHealthCheck resources (all
        /// regional) available to the specified project.
        /// 
        /// To prevent failure, it is recommended that you set the
        /// `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="project">
        /// Name of the project scoping this request.
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
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<CompositeHealthCheckAggregatedList, scg::KeyValuePair<string, CompositeHealthChecksScopedList>> AggregatedListAsync(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            AggregatedListRegionCompositeHealthChecksRequest request = new AggregatedListRegionCompositeHealthChecksRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return AggregatedListAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified CompositeHealthCheck in the given region
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Delete(DeleteRegionCompositeHealthCheckRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified CompositeHealthCheck in the given region
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteRegionCompositeHealthCheckRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified CompositeHealthCheck in the given region
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteRegionCompositeHealthCheckRequest request, st::CancellationToken cancellationToken) =>
            DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>Delete</c>.</summary>
        public virtual lro::OperationsClient DeleteOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Delete</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceDelete(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Delete</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceDeleteAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteOperationsClient, callSettings);

        /// <summary>
        /// Deletes the specified CompositeHealthCheck in the given region
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="compositeHealthCheck">
        /// Name of the CompositeHealthCheck resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Delete(string project, string region, string compositeHealthCheck, gaxgrpc::CallSettings callSettings = null) =>
            Delete(new DeleteRegionCompositeHealthCheckRequest
            {
                CompositeHealthCheck = gax::GaxPreconditions.CheckNotNullOrEmpty(compositeHealthCheck, nameof(compositeHealthCheck)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified CompositeHealthCheck in the given region
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="compositeHealthCheck">
        /// Name of the CompositeHealthCheck resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(string project, string region, string compositeHealthCheck, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAsync(new DeleteRegionCompositeHealthCheckRequest
            {
                CompositeHealthCheck = gax::GaxPreconditions.CheckNotNullOrEmpty(compositeHealthCheck, nameof(compositeHealthCheck)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified CompositeHealthCheck in the given region
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="compositeHealthCheck">
        /// Name of the CompositeHealthCheck resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(string project, string region, string compositeHealthCheck, st::CancellationToken cancellationToken) =>
            DeleteAsync(project, region, compositeHealthCheck, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified CompositeHealthCheck resource in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CompositeHealthCheck Get(GetRegionCompositeHealthCheckRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified CompositeHealthCheck resource in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompositeHealthCheck> GetAsync(GetRegionCompositeHealthCheckRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified CompositeHealthCheck resource in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompositeHealthCheck> GetAsync(GetRegionCompositeHealthCheckRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified CompositeHealthCheck resource in the given region.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="compositeHealthCheck">
        /// Name of the CompositeHealthCheck resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CompositeHealthCheck Get(string project, string region, string compositeHealthCheck, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetRegionCompositeHealthCheckRequest
            {
                CompositeHealthCheck = gax::GaxPreconditions.CheckNotNullOrEmpty(compositeHealthCheck, nameof(compositeHealthCheck)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Returns the specified CompositeHealthCheck resource in the given region.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="compositeHealthCheck">
        /// Name of the CompositeHealthCheck resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompositeHealthCheck> GetAsync(string project, string region, string compositeHealthCheck, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetRegionCompositeHealthCheckRequest
            {
                CompositeHealthCheck = gax::GaxPreconditions.CheckNotNullOrEmpty(compositeHealthCheck, nameof(compositeHealthCheck)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Returns the specified CompositeHealthCheck resource in the given region.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="compositeHealthCheck">
        /// Name of the CompositeHealthCheck resource to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CompositeHealthCheck> GetAsync(string project, string region, string compositeHealthCheck, st::CancellationToken cancellationToken) =>
            GetAsync(project, region, compositeHealthCheck, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a CompositeHealthCheck in the specified project in the given region
        /// using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Insert(InsertRegionCompositeHealthCheckRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a CompositeHealthCheck in the specified project in the given region
        /// using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertRegionCompositeHealthCheckRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a CompositeHealthCheck in the specified project in the given region
        /// using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertRegionCompositeHealthCheckRequest request, st::CancellationToken cancellationToken) =>
            InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>Insert</c>.</summary>
        public virtual lro::OperationsClient InsertOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Insert</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceInsert(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), InsertOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Insert</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceInsertAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), InsertOperationsClient, callSettings);

        /// <summary>
        /// Create a CompositeHealthCheck in the specified project in the given region
        /// using the parameters that are included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="compositeHealthCheckResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Insert(string project, string region, CompositeHealthCheck compositeHealthCheckResource, gaxgrpc::CallSettings callSettings = null) =>
            Insert(new InsertRegionCompositeHealthCheckRequest
            {
                CompositeHealthCheckResource = gax::GaxPreconditions.CheckNotNull(compositeHealthCheckResource, nameof(compositeHealthCheckResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Create a CompositeHealthCheck in the specified project in the given region
        /// using the parameters that are included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="compositeHealthCheckResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(string project, string region, CompositeHealthCheck compositeHealthCheckResource, gaxgrpc::CallSettings callSettings = null) =>
            InsertAsync(new InsertRegionCompositeHealthCheckRequest
            {
                CompositeHealthCheckResource = gax::GaxPreconditions.CheckNotNull(compositeHealthCheckResource, nameof(compositeHealthCheckResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Create a CompositeHealthCheck in the specified project in the given region
        /// using the parameters that are included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="compositeHealthCheckResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(string project, string region, CompositeHealthCheck compositeHealthCheckResource, st::CancellationToken cancellationToken) =>
            InsertAsync(project, region, compositeHealthCheckResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the CompositeHealthChecks for a project in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CompositeHealthCheck"/> resources.</returns>
        public virtual gax::PagedEnumerable<CompositeHealthCheckList, CompositeHealthCheck> List(ListRegionCompositeHealthChecksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the CompositeHealthChecks for a project in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CompositeHealthCheck"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<CompositeHealthCheckList, CompositeHealthCheck> ListAsync(ListRegionCompositeHealthChecksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the CompositeHealthChecks for a project in the given region.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
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
        /// <returns>A pageable sequence of <see cref="CompositeHealthCheck"/> resources.</returns>
        public virtual gax::PagedEnumerable<CompositeHealthCheckList, CompositeHealthCheck> List(string project, string region, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRegionCompositeHealthChecksRequest request = new ListRegionCompositeHealthChecksRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
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
        /// Lists the CompositeHealthChecks for a project in the given region.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CompositeHealthCheck"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<CompositeHealthCheckList, CompositeHealthCheck> ListAsync(string project, string region, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRegionCompositeHealthChecksRequest request = new ListRegionCompositeHealthChecksRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
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

        /// <summary>
        /// Updates the specified regional CompositeHealthCheck resource
        /// with the data included in the request.  This method supportsPATCH
        /// semantics and uses theJSON merge
        /// patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Patch(PatchRegionCompositeHealthCheckRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified regional CompositeHealthCheck resource
        /// with the data included in the request.  This method supportsPATCH
        /// semantics and uses theJSON merge
        /// patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PatchAsync(PatchRegionCompositeHealthCheckRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified regional CompositeHealthCheck resource
        /// with the data included in the request.  This method supportsPATCH
        /// semantics and uses theJSON merge
        /// patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PatchAsync(PatchRegionCompositeHealthCheckRequest request, st::CancellationToken cancellationToken) =>
            PatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>Patch</c>.</summary>
        public virtual lro::OperationsClient PatchOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Patch</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOncePatch(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PatchOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Patch</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOncePatchAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PatchOperationsClient, callSettings);

        /// <summary>
        /// Updates the specified regional CompositeHealthCheck resource
        /// with the data included in the request.  This method supportsPATCH
        /// semantics and uses theJSON merge
        /// patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="compositeHealthCheck">
        /// Name of the CompositeHealthCheck to update. The name
        /// must be 1-63 characters long, and comply with RFC1035.
        /// </param>
        /// <param name="compositeHealthCheckResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Patch(string project, string region, string compositeHealthCheck, CompositeHealthCheck compositeHealthCheckResource, gaxgrpc::CallSettings callSettings = null) =>
            Patch(new PatchRegionCompositeHealthCheckRequest
            {
                CompositeHealthCheck = gax::GaxPreconditions.CheckNotNullOrEmpty(compositeHealthCheck, nameof(compositeHealthCheck)),
                CompositeHealthCheckResource = gax::GaxPreconditions.CheckNotNull(compositeHealthCheckResource, nameof(compositeHealthCheckResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Updates the specified regional CompositeHealthCheck resource
        /// with the data included in the request.  This method supportsPATCH
        /// semantics and uses theJSON merge
        /// patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="compositeHealthCheck">
        /// Name of the CompositeHealthCheck to update. The name
        /// must be 1-63 characters long, and comply with RFC1035.
        /// </param>
        /// <param name="compositeHealthCheckResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PatchAsync(string project, string region, string compositeHealthCheck, CompositeHealthCheck compositeHealthCheckResource, gaxgrpc::CallSettings callSettings = null) =>
            PatchAsync(new PatchRegionCompositeHealthCheckRequest
            {
                CompositeHealthCheck = gax::GaxPreconditions.CheckNotNullOrEmpty(compositeHealthCheck, nameof(compositeHealthCheck)),
                CompositeHealthCheckResource = gax::GaxPreconditions.CheckNotNull(compositeHealthCheckResource, nameof(compositeHealthCheckResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Updates the specified regional CompositeHealthCheck resource
        /// with the data included in the request.  This method supportsPATCH
        /// semantics and uses theJSON merge
        /// patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="compositeHealthCheck">
        /// Name of the CompositeHealthCheck to update. The name
        /// must be 1-63 characters long, and comply with RFC1035.
        /// </param>
        /// <param name="compositeHealthCheckResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PatchAsync(string project, string region, string compositeHealthCheck, CompositeHealthCheck compositeHealthCheckResource, st::CancellationToken cancellationToken) =>
            PatchAsync(project, region, compositeHealthCheck, compositeHealthCheckResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TestPermissionsResponse TestIamPermissions(TestIamPermissionsRegionCompositeHealthCheckRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestPermissionsResponse> TestIamPermissionsAsync(TestIamPermissionsRegionCompositeHealthCheckRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestPermissionsResponse> TestIamPermissionsAsync(TestIamPermissionsRegionCompositeHealthCheckRequest request, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="testPermissionsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TestPermissionsResponse TestIamPermissions(string project, string region, string resource, TestPermissionsRequest testPermissionsRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissions(new TestIamPermissionsRegionCompositeHealthCheckRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                TestPermissionsRequestResource = gax::GaxPreconditions.CheckNotNull(testPermissionsRequestResource, nameof(testPermissionsRequestResource)),
            }, callSettings);

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="testPermissionsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestPermissionsResponse> TestIamPermissionsAsync(string project, string region, string resource, TestPermissionsRequest testPermissionsRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissionsAsync(new TestIamPermissionsRegionCompositeHealthCheckRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                TestPermissionsRequestResource = gax::GaxPreconditions.CheckNotNull(testPermissionsRequestResource, nameof(testPermissionsRequestResource)),
            }, callSettings);

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="resource">
        /// Name or id of the resource for this request.
        /// </param>
        /// <param name="testPermissionsRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestPermissionsResponse> TestIamPermissionsAsync(string project, string region, string resource, TestPermissionsRequest testPermissionsRequestResource, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(project, region, resource, testPermissionsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>RegionCompositeHealthChecks client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The RegionCompositeHealthChecks API.
    /// </remarks>
    public sealed partial class RegionCompositeHealthChecksClientImpl : RegionCompositeHealthChecksClient
    {
        private readonly gaxgrpc::ApiCall<AggregatedListRegionCompositeHealthChecksRequest, CompositeHealthCheckAggregatedList> _callAggregatedList;

        private readonly gaxgrpc::ApiCall<DeleteRegionCompositeHealthCheckRequest, Operation> _callDelete;

        private readonly gaxgrpc::ApiCall<GetRegionCompositeHealthCheckRequest, CompositeHealthCheck> _callGet;

        private readonly gaxgrpc::ApiCall<InsertRegionCompositeHealthCheckRequest, Operation> _callInsert;

        private readonly gaxgrpc::ApiCall<ListRegionCompositeHealthChecksRequest, CompositeHealthCheckList> _callList;

        private readonly gaxgrpc::ApiCall<PatchRegionCompositeHealthCheckRequest, Operation> _callPatch;

        private readonly gaxgrpc::ApiCall<TestIamPermissionsRegionCompositeHealthCheckRequest, TestPermissionsResponse> _callTestIamPermissions;

        /// <summary>
        /// Constructs a client wrapper for the RegionCompositeHealthChecks service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="RegionCompositeHealthChecksSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public RegionCompositeHealthChecksClientImpl(RegionCompositeHealthChecks.RegionCompositeHealthChecksClient grpcClient, RegionCompositeHealthChecksSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            RegionCompositeHealthChecksSettings effectiveSettings = settings ?? RegionCompositeHealthChecksSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            DeleteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForRegionOperations(), effectiveSettings.DeleteOperationsSettings, logger);
            InsertOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForRegionOperations(), effectiveSettings.InsertOperationsSettings, logger);
            PatchOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForRegionOperations(), effectiveSettings.PatchOperationsSettings, logger);
            _callAggregatedList = clientHelper.BuildApiCall<AggregatedListRegionCompositeHealthChecksRequest, CompositeHealthCheckAggregatedList>("AggregatedList", grpcClient.AggregatedListAsync, grpcClient.AggregatedList, effectiveSettings.AggregatedListSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callAggregatedList);
            Modify_AggregatedListApiCall(ref _callAggregatedList);
            _callDelete = clientHelper.BuildApiCall<DeleteRegionCompositeHealthCheckRequest, Operation>("Delete", grpcClient.DeleteAsync, grpcClient.Delete, effectiveSettings.DeleteSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("composite_health_check", request => request.CompositeHealthCheck);
            Modify_ApiCall(ref _callDelete);
            Modify_DeleteApiCall(ref _callDelete);
            _callGet = clientHelper.BuildApiCall<GetRegionCompositeHealthCheckRequest, CompositeHealthCheck>("Get", grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("composite_health_check", request => request.CompositeHealthCheck);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callInsert = clientHelper.BuildApiCall<InsertRegionCompositeHealthCheckRequest, Operation>("Insert", grpcClient.InsertAsync, grpcClient.Insert, effectiveSettings.InsertSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region);
            Modify_ApiCall(ref _callInsert);
            Modify_InsertApiCall(ref _callInsert);
            _callList = clientHelper.BuildApiCall<ListRegionCompositeHealthChecksRequest, CompositeHealthCheckList>("List", grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            _callPatch = clientHelper.BuildApiCall<PatchRegionCompositeHealthCheckRequest, Operation>("Patch", grpcClient.PatchAsync, grpcClient.Patch, effectiveSettings.PatchSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("composite_health_check", request => request.CompositeHealthCheck);
            Modify_ApiCall(ref _callPatch);
            Modify_PatchApiCall(ref _callPatch);
            _callTestIamPermissions = clientHelper.BuildApiCall<TestIamPermissionsRegionCompositeHealthCheckRequest, TestPermissionsResponse>("TestIamPermissions", grpcClient.TestIamPermissionsAsync, grpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_AggregatedListApiCall(ref gaxgrpc::ApiCall<AggregatedListRegionCompositeHealthChecksRequest, CompositeHealthCheckAggregatedList> call);

        partial void Modify_DeleteApiCall(ref gaxgrpc::ApiCall<DeleteRegionCompositeHealthCheckRequest, Operation> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetRegionCompositeHealthCheckRequest, CompositeHealthCheck> call);

        partial void Modify_InsertApiCall(ref gaxgrpc::ApiCall<InsertRegionCompositeHealthCheckRequest, Operation> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListRegionCompositeHealthChecksRequest, CompositeHealthCheckList> call);

        partial void Modify_PatchApiCall(ref gaxgrpc::ApiCall<PatchRegionCompositeHealthCheckRequest, Operation> call);

        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<TestIamPermissionsRegionCompositeHealthCheckRequest, TestPermissionsResponse> call);

        partial void OnConstruction(RegionCompositeHealthChecks.RegionCompositeHealthChecksClient grpcClient, RegionCompositeHealthChecksSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC RegionCompositeHealthChecks client</summary>
        public override RegionCompositeHealthChecks.RegionCompositeHealthChecksClient GrpcClient { get; }

        partial void Modify_AggregatedListRegionCompositeHealthChecksRequest(ref AggregatedListRegionCompositeHealthChecksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteRegionCompositeHealthCheckRequest(ref DeleteRegionCompositeHealthCheckRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRegionCompositeHealthCheckRequest(ref GetRegionCompositeHealthCheckRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InsertRegionCompositeHealthCheckRequest(ref InsertRegionCompositeHealthCheckRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRegionCompositeHealthChecksRequest(ref ListRegionCompositeHealthChecksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PatchRegionCompositeHealthCheckRequest(ref PatchRegionCompositeHealthCheckRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsRegionCompositeHealthCheckRequest(ref TestIamPermissionsRegionCompositeHealthCheckRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves the list of all CompositeHealthCheck resources (all
        /// regional) available to the specified project.
        /// 
        /// To prevent failure, it is recommended that you set the
        /// `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.</returns>
        public override gax::PagedEnumerable<CompositeHealthCheckAggregatedList, scg::KeyValuePair<string, CompositeHealthChecksScopedList>> AggregatedList(AggregatedListRegionCompositeHealthChecksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregatedListRegionCompositeHealthChecksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<AggregatedListRegionCompositeHealthChecksRequest, CompositeHealthCheckAggregatedList, scg::KeyValuePair<string, CompositeHealthChecksScopedList>>(_callAggregatedList, request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of all CompositeHealthCheck resources (all
        /// regional) available to the specified project.
        /// 
        /// To prevent failure, it is recommended that you set the
        /// `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<CompositeHealthCheckAggregatedList, scg::KeyValuePair<string, CompositeHealthChecksScopedList>> AggregatedListAsync(AggregatedListRegionCompositeHealthChecksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregatedListRegionCompositeHealthChecksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<AggregatedListRegionCompositeHealthChecksRequest, CompositeHealthCheckAggregatedList, scg::KeyValuePair<string, CompositeHealthChecksScopedList>>(_callAggregatedList, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>Delete</c>.</summary>
        public override lro::OperationsClient DeleteOperationsClient { get; }

        /// <summary>
        /// Deletes the specified CompositeHealthCheck in the given region
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Delete(DeleteRegionCompositeHealthCheckRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRegionCompositeHealthCheckRequest(ref request, ref callSettings);
            Operation response = _callDelete.Sync(request, callSettings);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteOperationsClient);
        }

        /// <summary>
        /// Deletes the specified CompositeHealthCheck in the given region
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteRegionCompositeHealthCheckRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRegionCompositeHealthCheckRequest(ref request, ref callSettings);
            Operation response = await _callDelete.Async(request, callSettings).ConfigureAwait(false);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteOperationsClient);
        }

        /// <summary>
        /// Returns the specified CompositeHealthCheck resource in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CompositeHealthCheck Get(GetRegionCompositeHealthCheckRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRegionCompositeHealthCheckRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified CompositeHealthCheck resource in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CompositeHealthCheck> GetAsync(GetRegionCompositeHealthCheckRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRegionCompositeHealthCheckRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>Insert</c>.</summary>
        public override lro::OperationsClient InsertOperationsClient { get; }

        /// <summary>
        /// Create a CompositeHealthCheck in the specified project in the given region
        /// using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Insert(InsertRegionCompositeHealthCheckRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertRegionCompositeHealthCheckRequest(ref request, ref callSettings);
            Operation response = _callInsert.Sync(request, callSettings);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), InsertOperationsClient);
        }

        /// <summary>
        /// Create a CompositeHealthCheck in the specified project in the given region
        /// using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertRegionCompositeHealthCheckRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertRegionCompositeHealthCheckRequest(ref request, ref callSettings);
            Operation response = await _callInsert.Async(request, callSettings).ConfigureAwait(false);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), InsertOperationsClient);
        }

        /// <summary>
        /// Lists the CompositeHealthChecks for a project in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CompositeHealthCheck"/> resources.</returns>
        public override gax::PagedEnumerable<CompositeHealthCheckList, CompositeHealthCheck> List(ListRegionCompositeHealthChecksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRegionCompositeHealthChecksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRegionCompositeHealthChecksRequest, CompositeHealthCheckList, CompositeHealthCheck>(_callList, request, callSettings);
        }

        /// <summary>
        /// Lists the CompositeHealthChecks for a project in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CompositeHealthCheck"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<CompositeHealthCheckList, CompositeHealthCheck> ListAsync(ListRegionCompositeHealthChecksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRegionCompositeHealthChecksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRegionCompositeHealthChecksRequest, CompositeHealthCheckList, CompositeHealthCheck>(_callList, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>Patch</c>.</summary>
        public override lro::OperationsClient PatchOperationsClient { get; }

        /// <summary>
        /// Updates the specified regional CompositeHealthCheck resource
        /// with the data included in the request.  This method supportsPATCH
        /// semantics and uses theJSON merge
        /// patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Patch(PatchRegionCompositeHealthCheckRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchRegionCompositeHealthCheckRequest(ref request, ref callSettings);
            Operation response = _callPatch.Sync(request, callSettings);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), PatchOperationsClient);
        }

        /// <summary>
        /// Updates the specified regional CompositeHealthCheck resource
        /// with the data included in the request.  This method supportsPATCH
        /// semantics and uses theJSON merge
        /// patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> PatchAsync(PatchRegionCompositeHealthCheckRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchRegionCompositeHealthCheckRequest(ref request, ref callSettings);
            Operation response = await _callPatch.Async(request, callSettings).ConfigureAwait(false);
            GetRegionOperationRequest pollRequest = GetRegionOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), PatchOperationsClient);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TestPermissionsResponse TestIamPermissions(TestIamPermissionsRegionCompositeHealthCheckRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRegionCompositeHealthCheckRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TestPermissionsResponse> TestIamPermissionsAsync(TestIamPermissionsRegionCompositeHealthCheckRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRegionCompositeHealthCheckRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }
    }

    public partial class AggregatedListRegionCompositeHealthChecksRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class ListRegionCompositeHealthChecksRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class CompositeHealthCheckAggregatedList : gaxgrpc::IPageResponse<scg::KeyValuePair<string, CompositeHealthChecksScopedList>>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<scg::KeyValuePair<string, CompositeHealthChecksScopedList>> GetEnumerator() =>
            Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class CompositeHealthCheckList : gaxgrpc::IPageResponse<CompositeHealthCheck>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CompositeHealthCheck> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class RegionCompositeHealthChecks
    {
        public partial class RegionCompositeHealthChecksClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client, delegating to RegionOperations.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClientForRegionOperations() =>
                RegionOperations.RegionOperationsClient.CreateOperationsClient(CallInvoker);
        }
    }
}
