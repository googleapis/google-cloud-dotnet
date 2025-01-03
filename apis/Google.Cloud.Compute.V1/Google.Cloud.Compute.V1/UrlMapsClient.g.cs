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
    /// <summary>Settings for <see cref="UrlMapsClient"/> instances.</summary>
    public sealed partial class UrlMapsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="UrlMapsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="UrlMapsSettings"/>.</returns>
        public static UrlMapsSettings GetDefault() => new UrlMapsSettings();

        /// <summary>Constructs a new <see cref="UrlMapsSettings"/> object with default settings.</summary>
        public UrlMapsSettings()
        {
        }

        private UrlMapsSettings(UrlMapsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            AggregatedListSettings = existing.AggregatedListSettings;
            DeleteSettings = existing.DeleteSettings;
            DeleteOperationsSettings = existing.DeleteOperationsSettings.Clone();
            GetSettings = existing.GetSettings;
            InsertSettings = existing.InsertSettings;
            InsertOperationsSettings = existing.InsertOperationsSettings.Clone();
            InvalidateCacheSettings = existing.InvalidateCacheSettings;
            InvalidateCacheOperationsSettings = existing.InvalidateCacheOperationsSettings.Clone();
            ListSettings = existing.ListSettings;
            PatchSettings = existing.PatchSettings;
            PatchOperationsSettings = existing.PatchOperationsSettings.Clone();
            UpdateSettings = existing.UpdateSettings;
            UpdateOperationsSettings = existing.UpdateOperationsSettings.Clone();
            ValidateSettings = existing.ValidateSettings;
            OnCopy(existing);
        }

        partial void OnCopy(UrlMapsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UrlMapsClient.AggregatedList</c> and <c>UrlMapsClient.AggregatedListAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>UrlMapsClient.Delete</c>
        /// and <c>UrlMapsClient.DeleteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>UrlMapsClient.Delete</c> and <c>UrlMapsClient.DeleteAsync</c>
        /// .
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>UrlMapsClient.Get</c> and
        /// <c>UrlMapsClient.GetAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>UrlMapsClient.Insert</c>
        /// and <c>UrlMapsClient.InsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InsertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>UrlMapsClient.Insert</c> and <c>UrlMapsClient.InsertAsync</c>
        /// .
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
        /// <c>UrlMapsClient.InvalidateCache</c> and <c>UrlMapsClient.InvalidateCacheAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InvalidateCacheSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>UrlMapsClient.InvalidateCache</c> and
        /// <c>UrlMapsClient.InvalidateCacheAsync</c>.
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
        public lro::OperationsSettings InvalidateCacheOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>UrlMapsClient.List</c> and
        /// <c>UrlMapsClient.ListAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>UrlMapsClient.Patch</c> and
        /// <c>UrlMapsClient.PatchAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PatchSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>UrlMapsClient.Patch</c> and <c>UrlMapsClient.PatchAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>UrlMapsClient.Update</c>
        /// and <c>UrlMapsClient.UpdateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>UrlMapsClient.Update</c> and <c>UrlMapsClient.UpdateAsync</c>
        /// .
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
        public lro::OperationsSettings UpdateOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>UrlMapsClient.Validate</c>
        /// and <c>UrlMapsClient.ValidateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ValidateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="UrlMapsSettings"/> object.</returns>
        public UrlMapsSettings Clone() => new UrlMapsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="UrlMapsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class UrlMapsClientBuilder : gaxgrpc::ClientBuilderBase<UrlMapsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public UrlMapsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public UrlMapsClientBuilder() : base(UrlMapsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref UrlMapsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<UrlMapsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override UrlMapsClient Build()
        {
            UrlMapsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<UrlMapsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<UrlMapsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private UrlMapsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return UrlMapsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<UrlMapsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return UrlMapsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => UrlMapsClient.ChannelPool;
    }

    /// <summary>UrlMaps client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The UrlMaps API.
    /// </remarks>
    public abstract partial class UrlMapsClient
    {
        /// <summary>
        /// The default endpoint for the UrlMaps service, which is a host of "compute.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default UrlMaps scopes.</summary>
        /// <remarks>
        /// The default UrlMaps scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(UrlMaps.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="UrlMapsClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="UrlMapsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="UrlMapsClient"/>.</returns>
        public static stt::Task<UrlMapsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new UrlMapsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="UrlMapsClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="UrlMapsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="UrlMapsClient"/>.</returns>
        public static UrlMapsClient Create() => new UrlMapsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="UrlMapsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="UrlMapsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="UrlMapsClient"/>.</returns>
        internal static UrlMapsClient Create(grpccore::CallInvoker callInvoker, UrlMapsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            UrlMaps.UrlMapsClient grpcClient = new UrlMaps.UrlMapsClient(callInvoker);
            return new UrlMapsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC UrlMaps client</summary>
        public virtual UrlMaps.UrlMapsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of all UrlMap resources, regional and global, available to the specified project. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.</returns>
        public virtual gax::PagedEnumerable<UrlMapsAggregatedList, scg::KeyValuePair<string, UrlMapsScopedList>> AggregatedList(AggregatedListUrlMapsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of all UrlMap resources, regional and global, available to the specified project. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<UrlMapsAggregatedList, scg::KeyValuePair<string, UrlMapsScopedList>> AggregatedListAsync(AggregatedListUrlMapsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of all UrlMap resources, regional and global, available to the specified project. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
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
        public virtual gax::PagedEnumerable<UrlMapsAggregatedList, scg::KeyValuePair<string, UrlMapsScopedList>> AggregatedList(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            AggregatedListUrlMapsRequest request = new AggregatedListUrlMapsRequest
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
        /// Retrieves the list of all UrlMap resources, regional and global, available to the specified project. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
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
        public virtual gax::PagedAsyncEnumerable<UrlMapsAggregatedList, scg::KeyValuePair<string, UrlMapsScopedList>> AggregatedListAsync(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            AggregatedListUrlMapsRequest request = new AggregatedListUrlMapsRequest
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
        /// Deletes the specified UrlMap resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Delete(DeleteUrlMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified UrlMap resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteUrlMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified UrlMap resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteUrlMapRequest request, st::CancellationToken cancellationToken) =>
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
        /// Deletes the specified UrlMap resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="urlMap">
        /// Name of the UrlMap resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Delete(string project, string urlMap, gaxgrpc::CallSettings callSettings = null) =>
            Delete(new DeleteUrlMapRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                UrlMap = gax::GaxPreconditions.CheckNotNullOrEmpty(urlMap, nameof(urlMap)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified UrlMap resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="urlMap">
        /// Name of the UrlMap resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(string project, string urlMap, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAsync(new DeleteUrlMapRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                UrlMap = gax::GaxPreconditions.CheckNotNullOrEmpty(urlMap, nameof(urlMap)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified UrlMap resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="urlMap">
        /// Name of the UrlMap resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(string project, string urlMap, st::CancellationToken cancellationToken) =>
            DeleteAsync(project, urlMap, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified UrlMap resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UrlMap Get(GetUrlMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified UrlMap resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UrlMap> GetAsync(GetUrlMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified UrlMap resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UrlMap> GetAsync(GetUrlMapRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified UrlMap resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="urlMap">
        /// Name of the UrlMap resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UrlMap Get(string project, string urlMap, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetUrlMapRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                UrlMap = gax::GaxPreconditions.CheckNotNullOrEmpty(urlMap, nameof(urlMap)),
            }, callSettings);

        /// <summary>
        /// Returns the specified UrlMap resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="urlMap">
        /// Name of the UrlMap resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UrlMap> GetAsync(string project, string urlMap, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetUrlMapRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                UrlMap = gax::GaxPreconditions.CheckNotNullOrEmpty(urlMap, nameof(urlMap)),
            }, callSettings);

        /// <summary>
        /// Returns the specified UrlMap resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="urlMap">
        /// Name of the UrlMap resource to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UrlMap> GetAsync(string project, string urlMap, st::CancellationToken cancellationToken) =>
            GetAsync(project, urlMap, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a UrlMap resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Insert(InsertUrlMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a UrlMap resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertUrlMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a UrlMap resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertUrlMapRequest request, st::CancellationToken cancellationToken) =>
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
        /// Creates a UrlMap resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="urlMapResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Insert(string project, UrlMap urlMapResource, gaxgrpc::CallSettings callSettings = null) =>
            Insert(new InsertUrlMapRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                UrlMapResource = gax::GaxPreconditions.CheckNotNull(urlMapResource, nameof(urlMapResource)),
            }, callSettings);

        /// <summary>
        /// Creates a UrlMap resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="urlMapResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(string project, UrlMap urlMapResource, gaxgrpc::CallSettings callSettings = null) =>
            InsertAsync(new InsertUrlMapRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                UrlMapResource = gax::GaxPreconditions.CheckNotNull(urlMapResource, nameof(urlMapResource)),
            }, callSettings);

        /// <summary>
        /// Creates a UrlMap resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="urlMapResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(string project, UrlMap urlMapResource, st::CancellationToken cancellationToken) =>
            InsertAsync(project, urlMapResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Initiates a cache invalidation operation, invalidating the specified path, scoped to the specified UrlMap. For more information, see [Invalidating cached content](/cdn/docs/invalidating-cached-content).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> InvalidateCache(InvalidateCacheUrlMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Initiates a cache invalidation operation, invalidating the specified path, scoped to the specified UrlMap. For more information, see [Invalidating cached content](/cdn/docs/invalidating-cached-content).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InvalidateCacheAsync(InvalidateCacheUrlMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Initiates a cache invalidation operation, invalidating the specified path, scoped to the specified UrlMap. For more information, see [Invalidating cached content](/cdn/docs/invalidating-cached-content).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InvalidateCacheAsync(InvalidateCacheUrlMapRequest request, st::CancellationToken cancellationToken) =>
            InvalidateCacheAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>InvalidateCache</c>.</summary>
        public virtual lro::OperationsClient InvalidateCacheOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>InvalidateCache</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceInvalidateCache(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), InvalidateCacheOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>InvalidateCache</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceInvalidateCacheAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), InvalidateCacheOperationsClient, callSettings);

        /// <summary>
        /// Initiates a cache invalidation operation, invalidating the specified path, scoped to the specified UrlMap. For more information, see [Invalidating cached content](/cdn/docs/invalidating-cached-content).
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="urlMap">
        /// Name of the UrlMap scoping this request.
        /// </param>
        /// <param name="cacheInvalidationRuleResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> InvalidateCache(string project, string urlMap, CacheInvalidationRule cacheInvalidationRuleResource, gaxgrpc::CallSettings callSettings = null) =>
            InvalidateCache(new InvalidateCacheUrlMapRequest
            {
                CacheInvalidationRuleResource = gax::GaxPreconditions.CheckNotNull(cacheInvalidationRuleResource, nameof(cacheInvalidationRuleResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                UrlMap = gax::GaxPreconditions.CheckNotNullOrEmpty(urlMap, nameof(urlMap)),
            }, callSettings);

        /// <summary>
        /// Initiates a cache invalidation operation, invalidating the specified path, scoped to the specified UrlMap. For more information, see [Invalidating cached content](/cdn/docs/invalidating-cached-content).
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="urlMap">
        /// Name of the UrlMap scoping this request.
        /// </param>
        /// <param name="cacheInvalidationRuleResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InvalidateCacheAsync(string project, string urlMap, CacheInvalidationRule cacheInvalidationRuleResource, gaxgrpc::CallSettings callSettings = null) =>
            InvalidateCacheAsync(new InvalidateCacheUrlMapRequest
            {
                CacheInvalidationRuleResource = gax::GaxPreconditions.CheckNotNull(cacheInvalidationRuleResource, nameof(cacheInvalidationRuleResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                UrlMap = gax::GaxPreconditions.CheckNotNullOrEmpty(urlMap, nameof(urlMap)),
            }, callSettings);

        /// <summary>
        /// Initiates a cache invalidation operation, invalidating the specified path, scoped to the specified UrlMap. For more information, see [Invalidating cached content](/cdn/docs/invalidating-cached-content).
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="urlMap">
        /// Name of the UrlMap scoping this request.
        /// </param>
        /// <param name="cacheInvalidationRuleResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InvalidateCacheAsync(string project, string urlMap, CacheInvalidationRule cacheInvalidationRuleResource, st::CancellationToken cancellationToken) =>
            InvalidateCacheAsync(project, urlMap, cacheInvalidationRuleResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the list of UrlMap resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UrlMap"/> resources.</returns>
        public virtual gax::PagedEnumerable<UrlMapList, UrlMap> List(ListUrlMapsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of UrlMap resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UrlMap"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<UrlMapList, UrlMap> ListAsync(ListUrlMapsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of UrlMap resources available to the specified project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
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
        /// <returns>A pageable sequence of <see cref="UrlMap"/> resources.</returns>
        public virtual gax::PagedEnumerable<UrlMapList, UrlMap> List(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUrlMapsRequest request = new ListUrlMapsRequest
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
            return List(request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of UrlMap resources available to the specified project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
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
        /// <returns>A pageable asynchronous sequence of <see cref="UrlMap"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<UrlMapList, UrlMap> ListAsync(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListUrlMapsRequest request = new ListUrlMapsRequest
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
            return ListAsync(request, callSettings);
        }

        /// <summary>
        /// Patches the specified UrlMap resource with the data included in the request. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Patch(PatchUrlMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches the specified UrlMap resource with the data included in the request. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PatchAsync(PatchUrlMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches the specified UrlMap resource with the data included in the request. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PatchAsync(PatchUrlMapRequest request, st::CancellationToken cancellationToken) =>
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
        /// Patches the specified UrlMap resource with the data included in the request. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="urlMap">
        /// Name of the UrlMap resource to patch.
        /// </param>
        /// <param name="urlMapResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Patch(string project, string urlMap, UrlMap urlMapResource, gaxgrpc::CallSettings callSettings = null) =>
            Patch(new PatchUrlMapRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                UrlMap = gax::GaxPreconditions.CheckNotNullOrEmpty(urlMap, nameof(urlMap)),
                UrlMapResource = gax::GaxPreconditions.CheckNotNull(urlMapResource, nameof(urlMapResource)),
            }, callSettings);

        /// <summary>
        /// Patches the specified UrlMap resource with the data included in the request. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="urlMap">
        /// Name of the UrlMap resource to patch.
        /// </param>
        /// <param name="urlMapResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PatchAsync(string project, string urlMap, UrlMap urlMapResource, gaxgrpc::CallSettings callSettings = null) =>
            PatchAsync(new PatchUrlMapRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                UrlMap = gax::GaxPreconditions.CheckNotNullOrEmpty(urlMap, nameof(urlMap)),
                UrlMapResource = gax::GaxPreconditions.CheckNotNull(urlMapResource, nameof(urlMapResource)),
            }, callSettings);

        /// <summary>
        /// Patches the specified UrlMap resource with the data included in the request. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="urlMap">
        /// Name of the UrlMap resource to patch.
        /// </param>
        /// <param name="urlMapResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PatchAsync(string project, string urlMap, UrlMap urlMapResource, st::CancellationToken cancellationToken) =>
            PatchAsync(project, urlMap, urlMapResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified UrlMap resource with the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Update(UpdateUrlMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified UrlMap resource with the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateAsync(UpdateUrlMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified UrlMap resource with the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateAsync(UpdateUrlMapRequest request, st::CancellationToken cancellationToken) =>
            UpdateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>Update</c>.</summary>
        public virtual lro::OperationsClient UpdateOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Update</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceUpdate(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Update</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceUpdateAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateOperationsClient, callSettings);

        /// <summary>
        /// Updates the specified UrlMap resource with the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="urlMap">
        /// Name of the UrlMap resource to update.
        /// </param>
        /// <param name="urlMapResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Update(string project, string urlMap, UrlMap urlMapResource, gaxgrpc::CallSettings callSettings = null) =>
            Update(new UpdateUrlMapRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                UrlMap = gax::GaxPreconditions.CheckNotNullOrEmpty(urlMap, nameof(urlMap)),
                UrlMapResource = gax::GaxPreconditions.CheckNotNull(urlMapResource, nameof(urlMapResource)),
            }, callSettings);

        /// <summary>
        /// Updates the specified UrlMap resource with the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="urlMap">
        /// Name of the UrlMap resource to update.
        /// </param>
        /// <param name="urlMapResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateAsync(string project, string urlMap, UrlMap urlMapResource, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAsync(new UpdateUrlMapRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                UrlMap = gax::GaxPreconditions.CheckNotNullOrEmpty(urlMap, nameof(urlMap)),
                UrlMapResource = gax::GaxPreconditions.CheckNotNull(urlMapResource, nameof(urlMapResource)),
            }, callSettings);

        /// <summary>
        /// Updates the specified UrlMap resource with the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="urlMap">
        /// Name of the UrlMap resource to update.
        /// </param>
        /// <param name="urlMapResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateAsync(string project, string urlMap, UrlMap urlMapResource, st::CancellationToken cancellationToken) =>
            UpdateAsync(project, urlMap, urlMapResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Runs static validation for the UrlMap. In particular, the tests of the provided UrlMap will be run. Calling this method does NOT create the UrlMap.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UrlMapsValidateResponse Validate(ValidateUrlMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Runs static validation for the UrlMap. In particular, the tests of the provided UrlMap will be run. Calling this method does NOT create the UrlMap.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UrlMapsValidateResponse> ValidateAsync(ValidateUrlMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Runs static validation for the UrlMap. In particular, the tests of the provided UrlMap will be run. Calling this method does NOT create the UrlMap.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UrlMapsValidateResponse> ValidateAsync(ValidateUrlMapRequest request, st::CancellationToken cancellationToken) =>
            ValidateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Runs static validation for the UrlMap. In particular, the tests of the provided UrlMap will be run. Calling this method does NOT create the UrlMap.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="urlMap">
        /// Name of the UrlMap resource to be validated as.
        /// </param>
        /// <param name="urlMapsValidateRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UrlMapsValidateResponse Validate(string project, string urlMap, UrlMapsValidateRequest urlMapsValidateRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            Validate(new ValidateUrlMapRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                UrlMap = gax::GaxPreconditions.CheckNotNullOrEmpty(urlMap, nameof(urlMap)),
                UrlMapsValidateRequestResource = gax::GaxPreconditions.CheckNotNull(urlMapsValidateRequestResource, nameof(urlMapsValidateRequestResource)),
            }, callSettings);

        /// <summary>
        /// Runs static validation for the UrlMap. In particular, the tests of the provided UrlMap will be run. Calling this method does NOT create the UrlMap.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="urlMap">
        /// Name of the UrlMap resource to be validated as.
        /// </param>
        /// <param name="urlMapsValidateRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UrlMapsValidateResponse> ValidateAsync(string project, string urlMap, UrlMapsValidateRequest urlMapsValidateRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            ValidateAsync(new ValidateUrlMapRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                UrlMap = gax::GaxPreconditions.CheckNotNullOrEmpty(urlMap, nameof(urlMap)),
                UrlMapsValidateRequestResource = gax::GaxPreconditions.CheckNotNull(urlMapsValidateRequestResource, nameof(urlMapsValidateRequestResource)),
            }, callSettings);

        /// <summary>
        /// Runs static validation for the UrlMap. In particular, the tests of the provided UrlMap will be run. Calling this method does NOT create the UrlMap.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="urlMap">
        /// Name of the UrlMap resource to be validated as.
        /// </param>
        /// <param name="urlMapsValidateRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UrlMapsValidateResponse> ValidateAsync(string project, string urlMap, UrlMapsValidateRequest urlMapsValidateRequestResource, st::CancellationToken cancellationToken) =>
            ValidateAsync(project, urlMap, urlMapsValidateRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>UrlMaps client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The UrlMaps API.
    /// </remarks>
    public sealed partial class UrlMapsClientImpl : UrlMapsClient
    {
        private readonly gaxgrpc::ApiCall<AggregatedListUrlMapsRequest, UrlMapsAggregatedList> _callAggregatedList;

        private readonly gaxgrpc::ApiCall<DeleteUrlMapRequest, Operation> _callDelete;

        private readonly gaxgrpc::ApiCall<GetUrlMapRequest, UrlMap> _callGet;

        private readonly gaxgrpc::ApiCall<InsertUrlMapRequest, Operation> _callInsert;

        private readonly gaxgrpc::ApiCall<InvalidateCacheUrlMapRequest, Operation> _callInvalidateCache;

        private readonly gaxgrpc::ApiCall<ListUrlMapsRequest, UrlMapList> _callList;

        private readonly gaxgrpc::ApiCall<PatchUrlMapRequest, Operation> _callPatch;

        private readonly gaxgrpc::ApiCall<UpdateUrlMapRequest, Operation> _callUpdate;

        private readonly gaxgrpc::ApiCall<ValidateUrlMapRequest, UrlMapsValidateResponse> _callValidate;

        /// <summary>
        /// Constructs a client wrapper for the UrlMaps service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="UrlMapsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public UrlMapsClientImpl(UrlMaps.UrlMapsClient grpcClient, UrlMapsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            UrlMapsSettings effectiveSettings = settings ?? UrlMapsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            DeleteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.DeleteOperationsSettings, logger);
            InsertOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.InsertOperationsSettings, logger);
            InvalidateCacheOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.InvalidateCacheOperationsSettings, logger);
            PatchOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.PatchOperationsSettings, logger);
            UpdateOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.UpdateOperationsSettings, logger);
            _callAggregatedList = clientHelper.BuildApiCall<AggregatedListUrlMapsRequest, UrlMapsAggregatedList>("AggregatedList", grpcClient.AggregatedListAsync, grpcClient.AggregatedList, effectiveSettings.AggregatedListSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callAggregatedList);
            Modify_AggregatedListApiCall(ref _callAggregatedList);
            _callDelete = clientHelper.BuildApiCall<DeleteUrlMapRequest, Operation>("Delete", grpcClient.DeleteAsync, grpcClient.Delete, effectiveSettings.DeleteSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("url_map", request => request.UrlMap);
            Modify_ApiCall(ref _callDelete);
            Modify_DeleteApiCall(ref _callDelete);
            _callGet = clientHelper.BuildApiCall<GetUrlMapRequest, UrlMap>("Get", grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("url_map", request => request.UrlMap);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callInsert = clientHelper.BuildApiCall<InsertUrlMapRequest, Operation>("Insert", grpcClient.InsertAsync, grpcClient.Insert, effectiveSettings.InsertSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callInsert);
            Modify_InsertApiCall(ref _callInsert);
            _callInvalidateCache = clientHelper.BuildApiCall<InvalidateCacheUrlMapRequest, Operation>("InvalidateCache", grpcClient.InvalidateCacheAsync, grpcClient.InvalidateCache, effectiveSettings.InvalidateCacheSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("url_map", request => request.UrlMap);
            Modify_ApiCall(ref _callInvalidateCache);
            Modify_InvalidateCacheApiCall(ref _callInvalidateCache);
            _callList = clientHelper.BuildApiCall<ListUrlMapsRequest, UrlMapList>("List", grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            _callPatch = clientHelper.BuildApiCall<PatchUrlMapRequest, Operation>("Patch", grpcClient.PatchAsync, grpcClient.Patch, effectiveSettings.PatchSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("url_map", request => request.UrlMap);
            Modify_ApiCall(ref _callPatch);
            Modify_PatchApiCall(ref _callPatch);
            _callUpdate = clientHelper.BuildApiCall<UpdateUrlMapRequest, Operation>("Update", grpcClient.UpdateAsync, grpcClient.Update, effectiveSettings.UpdateSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("url_map", request => request.UrlMap);
            Modify_ApiCall(ref _callUpdate);
            Modify_UpdateApiCall(ref _callUpdate);
            _callValidate = clientHelper.BuildApiCall<ValidateUrlMapRequest, UrlMapsValidateResponse>("Validate", grpcClient.ValidateAsync, grpcClient.Validate, effectiveSettings.ValidateSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("url_map", request => request.UrlMap);
            Modify_ApiCall(ref _callValidate);
            Modify_ValidateApiCall(ref _callValidate);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_AggregatedListApiCall(ref gaxgrpc::ApiCall<AggregatedListUrlMapsRequest, UrlMapsAggregatedList> call);

        partial void Modify_DeleteApiCall(ref gaxgrpc::ApiCall<DeleteUrlMapRequest, Operation> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetUrlMapRequest, UrlMap> call);

        partial void Modify_InsertApiCall(ref gaxgrpc::ApiCall<InsertUrlMapRequest, Operation> call);

        partial void Modify_InvalidateCacheApiCall(ref gaxgrpc::ApiCall<InvalidateCacheUrlMapRequest, Operation> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListUrlMapsRequest, UrlMapList> call);

        partial void Modify_PatchApiCall(ref gaxgrpc::ApiCall<PatchUrlMapRequest, Operation> call);

        partial void Modify_UpdateApiCall(ref gaxgrpc::ApiCall<UpdateUrlMapRequest, Operation> call);

        partial void Modify_ValidateApiCall(ref gaxgrpc::ApiCall<ValidateUrlMapRequest, UrlMapsValidateResponse> call);

        partial void OnConstruction(UrlMaps.UrlMapsClient grpcClient, UrlMapsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC UrlMaps client</summary>
        public override UrlMaps.UrlMapsClient GrpcClient { get; }

        partial void Modify_AggregatedListUrlMapsRequest(ref AggregatedListUrlMapsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteUrlMapRequest(ref DeleteUrlMapRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetUrlMapRequest(ref GetUrlMapRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InsertUrlMapRequest(ref InsertUrlMapRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InvalidateCacheUrlMapRequest(ref InvalidateCacheUrlMapRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListUrlMapsRequest(ref ListUrlMapsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PatchUrlMapRequest(ref PatchUrlMapRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateUrlMapRequest(ref UpdateUrlMapRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ValidateUrlMapRequest(ref ValidateUrlMapRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves the list of all UrlMap resources, regional and global, available to the specified project. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.</returns>
        public override gax::PagedEnumerable<UrlMapsAggregatedList, scg::KeyValuePair<string, UrlMapsScopedList>> AggregatedList(AggregatedListUrlMapsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregatedListUrlMapsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<AggregatedListUrlMapsRequest, UrlMapsAggregatedList, scg::KeyValuePair<string, UrlMapsScopedList>>(_callAggregatedList, request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of all UrlMap resources, regional and global, available to the specified project. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<UrlMapsAggregatedList, scg::KeyValuePair<string, UrlMapsScopedList>> AggregatedListAsync(AggregatedListUrlMapsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregatedListUrlMapsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<AggregatedListUrlMapsRequest, UrlMapsAggregatedList, scg::KeyValuePair<string, UrlMapsScopedList>>(_callAggregatedList, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>Delete</c>.</summary>
        public override lro::OperationsClient DeleteOperationsClient { get; }

        /// <summary>
        /// Deletes the specified UrlMap resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Delete(DeleteUrlMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteUrlMapRequest(ref request, ref callSettings);
            Operation response = _callDelete.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteOperationsClient);
        }

        /// <summary>
        /// Deletes the specified UrlMap resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteUrlMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteUrlMapRequest(ref request, ref callSettings);
            Operation response = await _callDelete.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteOperationsClient);
        }

        /// <summary>
        /// Returns the specified UrlMap resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UrlMap Get(GetUrlMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUrlMapRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified UrlMap resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UrlMap> GetAsync(GetUrlMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUrlMapRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>Insert</c>.</summary>
        public override lro::OperationsClient InsertOperationsClient { get; }

        /// <summary>
        /// Creates a UrlMap resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Insert(InsertUrlMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertUrlMapRequest(ref request, ref callSettings);
            Operation response = _callInsert.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), InsertOperationsClient);
        }

        /// <summary>
        /// Creates a UrlMap resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertUrlMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertUrlMapRequest(ref request, ref callSettings);
            Operation response = await _callInsert.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), InsertOperationsClient);
        }

        /// <summary>The long-running operations client for <c>InvalidateCache</c>.</summary>
        public override lro::OperationsClient InvalidateCacheOperationsClient { get; }

        /// <summary>
        /// Initiates a cache invalidation operation, invalidating the specified path, scoped to the specified UrlMap. For more information, see [Invalidating cached content](/cdn/docs/invalidating-cached-content).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> InvalidateCache(InvalidateCacheUrlMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InvalidateCacheUrlMapRequest(ref request, ref callSettings);
            Operation response = _callInvalidateCache.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), InvalidateCacheOperationsClient);
        }

        /// <summary>
        /// Initiates a cache invalidation operation, invalidating the specified path, scoped to the specified UrlMap. For more information, see [Invalidating cached content](/cdn/docs/invalidating-cached-content).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> InvalidateCacheAsync(InvalidateCacheUrlMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InvalidateCacheUrlMapRequest(ref request, ref callSettings);
            Operation response = await _callInvalidateCache.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), InvalidateCacheOperationsClient);
        }

        /// <summary>
        /// Retrieves the list of UrlMap resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UrlMap"/> resources.</returns>
        public override gax::PagedEnumerable<UrlMapList, UrlMap> List(ListUrlMapsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUrlMapsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListUrlMapsRequest, UrlMapList, UrlMap>(_callList, request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of UrlMap resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UrlMap"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<UrlMapList, UrlMap> ListAsync(ListUrlMapsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListUrlMapsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListUrlMapsRequest, UrlMapList, UrlMap>(_callList, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>Patch</c>.</summary>
        public override lro::OperationsClient PatchOperationsClient { get; }

        /// <summary>
        /// Patches the specified UrlMap resource with the data included in the request. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Patch(PatchUrlMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchUrlMapRequest(ref request, ref callSettings);
            Operation response = _callPatch.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), PatchOperationsClient);
        }

        /// <summary>
        /// Patches the specified UrlMap resource with the data included in the request. This method supports PATCH semantics and uses the JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> PatchAsync(PatchUrlMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchUrlMapRequest(ref request, ref callSettings);
            Operation response = await _callPatch.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), PatchOperationsClient);
        }

        /// <summary>The long-running operations client for <c>Update</c>.</summary>
        public override lro::OperationsClient UpdateOperationsClient { get; }

        /// <summary>
        /// Updates the specified UrlMap resource with the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Update(UpdateUrlMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUrlMapRequest(ref request, ref callSettings);
            Operation response = _callUpdate.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), UpdateOperationsClient);
        }

        /// <summary>
        /// Updates the specified UrlMap resource with the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> UpdateAsync(UpdateUrlMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateUrlMapRequest(ref request, ref callSettings);
            Operation response = await _callUpdate.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), UpdateOperationsClient);
        }

        /// <summary>
        /// Runs static validation for the UrlMap. In particular, the tests of the provided UrlMap will be run. Calling this method does NOT create the UrlMap.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UrlMapsValidateResponse Validate(ValidateUrlMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ValidateUrlMapRequest(ref request, ref callSettings);
            return _callValidate.Sync(request, callSettings);
        }

        /// <summary>
        /// Runs static validation for the UrlMap. In particular, the tests of the provided UrlMap will be run. Calling this method does NOT create the UrlMap.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UrlMapsValidateResponse> ValidateAsync(ValidateUrlMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ValidateUrlMapRequest(ref request, ref callSettings);
            return _callValidate.Async(request, callSettings);
        }
    }

    public partial class AggregatedListUrlMapsRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class ListUrlMapsRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class UrlMapsAggregatedList : gaxgrpc::IPageResponse<scg::KeyValuePair<string, UrlMapsScopedList>>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<scg::KeyValuePair<string, UrlMapsScopedList>> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class UrlMaps
    {
        public partial class UrlMapsClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client, delegating to GlobalOperations.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClientForGlobalOperations() =>
                GlobalOperations.GlobalOperationsClient.CreateOperationsClient(CallInvoker);
        }
    }
}
