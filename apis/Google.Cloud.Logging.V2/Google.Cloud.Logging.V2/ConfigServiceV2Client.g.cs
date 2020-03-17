// Copyright 2020 Google LLC
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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using gagr = Google.Api.Gax.ResourceNames;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Logging.V2
{
    /// <summary>Settings for <see cref="ConfigServiceV2Client"/> instances.</summary>
    public sealed partial class ConfigServiceV2Settings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ConfigServiceV2Settings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ConfigServiceV2Settings"/>.</returns>
        public static ConfigServiceV2Settings GetDefault() => new ConfigServiceV2Settings();

        /// <summary>Constructs a new <see cref="ConfigServiceV2Settings"/> object with default settings.</summary>
        public ConfigServiceV2Settings()
        {
        }

        private ConfigServiceV2Settings(ConfigServiceV2Settings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListBucketsSettings = existing.ListBucketsSettings;
            GetBucketSettings = existing.GetBucketSettings;
            UpdateBucketSettings = existing.UpdateBucketSettings;
            ListSinksSettings = existing.ListSinksSettings;
            GetSinkSettings = existing.GetSinkSettings;
            CreateSinkSettings = existing.CreateSinkSettings;
            UpdateSinkSettings = existing.UpdateSinkSettings;
            DeleteSinkSettings = existing.DeleteSinkSettings;
            ListExclusionsSettings = existing.ListExclusionsSettings;
            GetExclusionSettings = existing.GetExclusionSettings;
            CreateExclusionSettings = existing.CreateExclusionSettings;
            UpdateExclusionSettings = existing.UpdateExclusionSettings;
            DeleteExclusionSettings = existing.DeleteExclusionSettings;
            GetCmekSettingsSettings = existing.GetCmekSettingsSettings;
            UpdateCmekSettingsSettings = existing.UpdateCmekSettingsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ConfigServiceV2Settings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.ListBuckets</c> and <c>ConfigServiceV2Client.ListBucketsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListBucketsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.GetBucket</c> and <c>ConfigServiceV2Client.GetBucketAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetBucketSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.UpdateBucket</c> and <c>ConfigServiceV2Client.UpdateBucketAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateBucketSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.ListSinks</c> and <c>ConfigServiceV2Client.ListSinksAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSinksSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.GetSink</c> and <c>ConfigServiceV2Client.GetSinkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.CreateSink</c> and <c>ConfigServiceV2Client.CreateSinkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSinkSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.UpdateSink</c> and <c>ConfigServiceV2Client.UpdateSinkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.DeleteSink</c> and <c>ConfigServiceV2Client.DeleteSinkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.ListExclusions</c> and <c>ConfigServiceV2Client.ListExclusionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListExclusionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.GetExclusion</c> and <c>ConfigServiceV2Client.GetExclusionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetExclusionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.CreateExclusion</c> and <c>ConfigServiceV2Client.CreateExclusionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateExclusionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.UpdateExclusion</c> and <c>ConfigServiceV2Client.UpdateExclusionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateExclusionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.DeleteExclusion</c> and <c>ConfigServiceV2Client.DeleteExclusionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteExclusionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.GetCmekSettings</c> and <c>ConfigServiceV2Client.GetCmekSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCmekSettingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.UpdateCmekSettings</c> and <c>ConfigServiceV2Client.UpdateCmekSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateCmekSettingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ConfigServiceV2Settings"/> object.</returns>
        public ConfigServiceV2Settings Clone() => new ConfigServiceV2Settings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ConfigServiceV2Client"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ConfigServiceV2ClientBuilder : gaxgrpc::ClientBuilderBase<ConfigServiceV2Client>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ConfigServiceV2Settings Settings { get; set; }

        partial void InterceptBuild(ref ConfigServiceV2Client client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ConfigServiceV2Client> task);

        /// <inheritdoc/>
        public override ConfigServiceV2Client Build()
        {
            ConfigServiceV2Client client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <inheritdoc/>
        public override stt::Task<ConfigServiceV2Client> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ConfigServiceV2Client> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ConfigServiceV2Client BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ConfigServiceV2Client.Create(callInvoker, Settings);
        }

        private async stt::Task<ConfigServiceV2Client> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ConfigServiceV2Client.Create(callInvoker, Settings);
        }

        /// <inheritdoc/>
        protected override string GetDefaultEndpoint() => ConfigServiceV2Client.DefaultEndpoint;

        /// <inheritdoc/>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => ConfigServiceV2Client.DefaultScopes;

        /// <inheritdoc/>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ConfigServiceV2Client.ChannelPool;

        /// <inheritdoc/>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>ConfigServiceV2 client wrapper, for convenient use.</summary>
    public abstract partial class ConfigServiceV2Client
    {
        /// <summary>
        /// The default endpoint for the ConfigServiceV2 service, which is a host of "logging.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "logging.googleapis.com:443";

        /// <summary>The default ConfigServiceV2 scopes.</summary>
        /// <remarks>
        /// The default ConfigServiceV2 scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform.read-only</description></item>
        /// <item><description>https://www.googleapis.com/auth/logging.admin</description></item>
        /// <item><description>https://www.googleapis.com/auth/logging.read</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
            "https://www.googleapis.com/auth/logging.admin",
            "https://www.googleapis.com/auth/logging.read",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="ConfigServiceV2Client"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ConfigServiceV2ClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ConfigServiceV2Client"/>.</returns>
        public static stt::Task<ConfigServiceV2Client> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ConfigServiceV2ClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ConfigServiceV2Client"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ConfigServiceV2ClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ConfigServiceV2Client"/>.</returns>
        public static ConfigServiceV2Client Create() => new ConfigServiceV2ClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ConfigServiceV2Client"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ConfigServiceV2Settings"/>.</param>
        /// <returns>The created <see cref="ConfigServiceV2Client"/>.</returns>
        internal static ConfigServiceV2Client Create(grpccore::CallInvoker callInvoker, ConfigServiceV2Settings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ConfigServiceV2.ConfigServiceV2Client grpcClient = new ConfigServiceV2.ConfigServiceV2Client(callInvoker);
            return new ConfigServiceV2ClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC ConfigServiceV2 client</summary>
        public virtual ConfigServiceV2.ConfigServiceV2Client GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists buckets (Beta).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LogBucket"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBucketsResponse, LogBucket> ListBuckets(ListBucketsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists buckets (Beta).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LogBucket"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBucketsResponse, LogBucket> ListBucketsAsync(ListBucketsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists buckets (Beta).
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose buckets are to be listed:
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]"
        /// 
        /// Note: The locations portion of the resource must be specified, but
        /// supplying the character `-` in place of [LOCATION_ID] will return all
        /// buckets.
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
        /// <returns>A pageable sequence of <see cref="LogBucket"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBucketsResponse, LogBucket> ListBuckets(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListBuckets(new ListBucketsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists buckets (Beta).
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose buckets are to be listed:
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]"
        /// 
        /// Note: The locations portion of the resource must be specified, but
        /// supplying the character `-` in place of [LOCATION_ID] will return all
        /// buckets.
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
        /// <returns>A pageable asynchronous sequence of <see cref="LogBucket"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBucketsResponse, LogBucket> ListBucketsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListBucketsAsync(new ListBucketsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists buckets (Beta).
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose buckets are to be listed:
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]"
        /// 
        /// Note: The locations portion of the resource must be specified, but
        /// supplying the character `-` in place of [LOCATION_ID] will return all
        /// buckets.
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
        /// <returns>A pageable sequence of <see cref="LogBucket"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBucketsResponse, LogBucket> ListBuckets(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListBuckets(new ListBucketsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists buckets (Beta).
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose buckets are to be listed:
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]"
        /// 
        /// Note: The locations portion of the resource must be specified, but
        /// supplying the character `-` in place of [LOCATION_ID] will return all
        /// buckets.
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
        /// <returns>A pageable asynchronous sequence of <see cref="LogBucket"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBucketsResponse, LogBucket> ListBucketsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListBucketsAsync(new ListBucketsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists buckets (Beta).
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose buckets are to be listed:
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]"
        /// 
        /// Note: The locations portion of the resource must be specified, but
        /// supplying the character `-` in place of [LOCATION_ID] will return all
        /// buckets.
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
        /// <returns>A pageable sequence of <see cref="LogBucket"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBucketsResponse, LogBucket> ListBuckets(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListBuckets(new ListBucketsRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists buckets (Beta).
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose buckets are to be listed:
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]"
        /// 
        /// Note: The locations portion of the resource must be specified, but
        /// supplying the character `-` in place of [LOCATION_ID] will return all
        /// buckets.
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
        /// <returns>A pageable asynchronous sequence of <see cref="LogBucket"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBucketsResponse, LogBucket> ListBucketsAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListBucketsAsync(new ListBucketsRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists buckets (Beta).
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose buckets are to be listed:
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]"
        /// 
        /// Note: The locations portion of the resource must be specified, but
        /// supplying the character `-` in place of [LOCATION_ID] will return all
        /// buckets.
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
        /// <returns>A pageable sequence of <see cref="LogBucket"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBucketsResponse, LogBucket> ListBuckets(FolderLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListBuckets(new ListBucketsRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists buckets (Beta).
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose buckets are to be listed:
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]"
        /// 
        /// Note: The locations portion of the resource must be specified, but
        /// supplying the character `-` in place of [LOCATION_ID] will return all
        /// buckets.
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
        /// <returns>A pageable asynchronous sequence of <see cref="LogBucket"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBucketsResponse, LogBucket> ListBucketsAsync(FolderLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListBucketsAsync(new ListBucketsRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists buckets (Beta).
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose buckets are to be listed:
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]"
        /// 
        /// Note: The locations portion of the resource must be specified, but
        /// supplying the character `-` in place of [LOCATION_ID] will return all
        /// buckets.
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
        /// <returns>A pageable sequence of <see cref="LogBucket"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBucketsResponse, LogBucket> ListBuckets(BillingAccountLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListBuckets(new ListBucketsRequest
            {
                ParentAsBillingAccountLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists buckets (Beta).
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose buckets are to be listed:
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION_ID]"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]"
        /// "folders/[FOLDER_ID]/locations/[LOCATION_ID]"
        /// 
        /// Note: The locations portion of the resource must be specified, but
        /// supplying the character `-` in place of [LOCATION_ID] will return all
        /// buckets.
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
        /// <returns>A pageable asynchronous sequence of <see cref="LogBucket"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBucketsResponse, LogBucket> ListBucketsAsync(BillingAccountLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListBucketsAsync(new ListBucketsRequest
            {
                ParentAsBillingAccountLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets a bucket (Beta).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogBucket GetBucket(GetBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a bucket (Beta).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogBucket> GetBucketAsync(GetBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a bucket (Beta).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogBucket> GetBucketAsync(GetBucketRequest request, st::CancellationToken cancellationToken) =>
            GetBucketAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a bucket. This method replaces the following fields in the
        /// existing bucket with values from the new bucket: `retention_period`
        /// 
        /// If the retention period is decreased and the bucket is locked,
        /// FAILED_PRECONDITION will be returned.
        /// 
        /// If the bucket has a LifecycleState of DELETE_REQUESTED, FAILED_PRECONDITION
        /// will be returned.
        /// 
        /// A buckets region may not be modified after it is created.
        /// This method is in Beta.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogBucket UpdateBucket(UpdateBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a bucket. This method replaces the following fields in the
        /// existing bucket with values from the new bucket: `retention_period`
        /// 
        /// If the retention period is decreased and the bucket is locked,
        /// FAILED_PRECONDITION will be returned.
        /// 
        /// If the bucket has a LifecycleState of DELETE_REQUESTED, FAILED_PRECONDITION
        /// will be returned.
        /// 
        /// A buckets region may not be modified after it is created.
        /// This method is in Beta.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogBucket> UpdateBucketAsync(UpdateBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a bucket. This method replaces the following fields in the
        /// existing bucket with values from the new bucket: `retention_period`
        /// 
        /// If the retention period is decreased and the bucket is locked,
        /// FAILED_PRECONDITION will be returned.
        /// 
        /// If the bucket has a LifecycleState of DELETE_REQUESTED, FAILED_PRECONDITION
        /// will be returned.
        /// 
        /// A buckets region may not be modified after it is created.
        /// This method is in Beta.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogBucket> UpdateBucketAsync(UpdateBucketRequest request, st::CancellationToken cancellationToken) =>
            UpdateBucketAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LogSink"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSinksResponse, LogSink> ListSinks(ListSinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LogSink"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSinksResponse, LogSink> ListSinksAsync(ListSinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose sinks are to be listed:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
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
        /// <returns>A pageable sequence of <see cref="LogSink"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSinksResponse, LogSink> ListSinks(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSinks(new ListSinksRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose sinks are to be listed:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
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
        /// <returns>A pageable asynchronous sequence of <see cref="LogSink"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSinksResponse, LogSink> ListSinksAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSinksAsync(new ListSinksRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose sinks are to be listed:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
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
        /// <returns>A pageable sequence of <see cref="LogSink"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSinksResponse, LogSink> ListSinks(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSinks(new ListSinksRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose sinks are to be listed:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
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
        /// <returns>A pageable asynchronous sequence of <see cref="LogSink"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSinksResponse, LogSink> ListSinksAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSinksAsync(new ListSinksRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose sinks are to be listed:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
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
        /// <returns>A pageable sequence of <see cref="LogSink"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSinksResponse, LogSink> ListSinks(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSinks(new ListSinksRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose sinks are to be listed:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
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
        /// <returns>A pageable asynchronous sequence of <see cref="LogSink"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSinksResponse, LogSink> ListSinksAsync(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSinksAsync(new ListSinksRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose sinks are to be listed:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
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
        /// <returns>A pageable sequence of <see cref="LogSink"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSinksResponse, LogSink> ListSinks(gagr::FolderName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSinks(new ListSinksRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose sinks are to be listed:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
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
        /// <returns>A pageable asynchronous sequence of <see cref="LogSink"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSinksResponse, LogSink> ListSinksAsync(gagr::FolderName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSinksAsync(new ListSinksRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose sinks are to be listed:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
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
        /// <returns>A pageable sequence of <see cref="LogSink"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSinksResponse, LogSink> ListSinks(gagr::BillingAccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSinks(new ListSinksRequest
            {
                ParentAsBillingAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose sinks are to be listed:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
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
        /// <returns>A pageable asynchronous sequence of <see cref="LogSink"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSinksResponse, LogSink> ListSinksAsync(gagr::BillingAccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSinksAsync(new ListSinksRequest
            {
                ParentAsBillingAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogSink GetSink(GetSinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> GetSinkAsync(GetSinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> GetSinkAsync(GetSinkRequest request, st::CancellationToken cancellationToken) =>
            GetSinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The resource name of the sink:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogSink GetSink(string sinkName, gaxgrpc::CallSettings callSettings = null) =>
            GetSink(new GetSinkRequest
            {
                SinkName = gax::GaxPreconditions.CheckNotNullOrEmpty(sinkName, nameof(sinkName)),
            }, callSettings);

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The resource name of the sink:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> GetSinkAsync(string sinkName, gaxgrpc::CallSettings callSettings = null) =>
            GetSinkAsync(new GetSinkRequest
            {
                SinkName = gax::GaxPreconditions.CheckNotNullOrEmpty(sinkName, nameof(sinkName)),
            }, callSettings);

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The resource name of the sink:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> GetSinkAsync(string sinkName, st::CancellationToken cancellationToken) =>
            GetSinkAsync(sinkName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The resource name of the sink:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogSink GetSink(LogSinkName sinkName, gaxgrpc::CallSettings callSettings = null) =>
            GetSink(new GetSinkRequest
            {
                SinkNameAsLogSinkName = gax::GaxPreconditions.CheckNotNull(sinkName, nameof(sinkName)),
            }, callSettings);

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The resource name of the sink:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> GetSinkAsync(LogSinkName sinkName, gaxgrpc::CallSettings callSettings = null) =>
            GetSinkAsync(new GetSinkRequest
            {
                SinkNameAsLogSinkName = gax::GaxPreconditions.CheckNotNull(sinkName, nameof(sinkName)),
            }, callSettings);

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The resource name of the sink:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> GetSinkAsync(LogSinkName sinkName, st::CancellationToken cancellationToken) =>
            GetSinkAsync(sinkName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogSink CreateSink(CreateSinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> CreateSinkAsync(CreateSinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> CreateSinkAsync(CreateSinkRequest request, st::CancellationToken cancellationToken) =>
            CreateSinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource in which to create the sink:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="sink">
        /// Required. The new sink, whose `name` parameter is a sink identifier that
        /// is not already in use.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogSink CreateSink(string parent, LogSink sink, gaxgrpc::CallSettings callSettings = null) =>
            CreateSink(new CreateSinkRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
            }, callSettings);

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource in which to create the sink:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="sink">
        /// Required. The new sink, whose `name` parameter is a sink identifier that
        /// is not already in use.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> CreateSinkAsync(string parent, LogSink sink, gaxgrpc::CallSettings callSettings = null) =>
            CreateSinkAsync(new CreateSinkRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
            }, callSettings);

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource in which to create the sink:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="sink">
        /// Required. The new sink, whose `name` parameter is a sink identifier that
        /// is not already in use.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> CreateSinkAsync(string parent, LogSink sink, st::CancellationToken cancellationToken) =>
            CreateSinkAsync(parent, sink, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource in which to create the sink:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="sink">
        /// Required. The new sink, whose `name` parameter is a sink identifier that
        /// is not already in use.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogSink CreateSink(gagr::ProjectName parent, LogSink sink, gaxgrpc::CallSettings callSettings = null) =>
            CreateSink(new CreateSinkRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
            }, callSettings);

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource in which to create the sink:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="sink">
        /// Required. The new sink, whose `name` parameter is a sink identifier that
        /// is not already in use.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> CreateSinkAsync(gagr::ProjectName parent, LogSink sink, gaxgrpc::CallSettings callSettings = null) =>
            CreateSinkAsync(new CreateSinkRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
            }, callSettings);

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource in which to create the sink:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="sink">
        /// Required. The new sink, whose `name` parameter is a sink identifier that
        /// is not already in use.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> CreateSinkAsync(gagr::ProjectName parent, LogSink sink, st::CancellationToken cancellationToken) =>
            CreateSinkAsync(parent, sink, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource in which to create the sink:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="sink">
        /// Required. The new sink, whose `name` parameter is a sink identifier that
        /// is not already in use.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogSink CreateSink(gagr::OrganizationName parent, LogSink sink, gaxgrpc::CallSettings callSettings = null) =>
            CreateSink(new CreateSinkRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
            }, callSettings);

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource in which to create the sink:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="sink">
        /// Required. The new sink, whose `name` parameter is a sink identifier that
        /// is not already in use.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> CreateSinkAsync(gagr::OrganizationName parent, LogSink sink, gaxgrpc::CallSettings callSettings = null) =>
            CreateSinkAsync(new CreateSinkRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
            }, callSettings);

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource in which to create the sink:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="sink">
        /// Required. The new sink, whose `name` parameter is a sink identifier that
        /// is not already in use.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> CreateSinkAsync(gagr::OrganizationName parent, LogSink sink, st::CancellationToken cancellationToken) =>
            CreateSinkAsync(parent, sink, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource in which to create the sink:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="sink">
        /// Required. The new sink, whose `name` parameter is a sink identifier that
        /// is not already in use.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogSink CreateSink(gagr::FolderName parent, LogSink sink, gaxgrpc::CallSettings callSettings = null) =>
            CreateSink(new CreateSinkRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
            }, callSettings);

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource in which to create the sink:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="sink">
        /// Required. The new sink, whose `name` parameter is a sink identifier that
        /// is not already in use.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> CreateSinkAsync(gagr::FolderName parent, LogSink sink, gaxgrpc::CallSettings callSettings = null) =>
            CreateSinkAsync(new CreateSinkRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
            }, callSettings);

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource in which to create the sink:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="sink">
        /// Required. The new sink, whose `name` parameter is a sink identifier that
        /// is not already in use.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> CreateSinkAsync(gagr::FolderName parent, LogSink sink, st::CancellationToken cancellationToken) =>
            CreateSinkAsync(parent, sink, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource in which to create the sink:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="sink">
        /// Required. The new sink, whose `name` parameter is a sink identifier that
        /// is not already in use.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogSink CreateSink(gagr::BillingAccountName parent, LogSink sink, gaxgrpc::CallSettings callSettings = null) =>
            CreateSink(new CreateSinkRequest
            {
                ParentAsBillingAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
            }, callSettings);

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource in which to create the sink:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="sink">
        /// Required. The new sink, whose `name` parameter is a sink identifier that
        /// is not already in use.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> CreateSinkAsync(gagr::BillingAccountName parent, LogSink sink, gaxgrpc::CallSettings callSettings = null) =>
            CreateSinkAsync(new CreateSinkRequest
            {
                ParentAsBillingAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
            }, callSettings);

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource in which to create the sink:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="sink">
        /// Required. The new sink, whose `name` parameter is a sink identifier that
        /// is not already in use.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> CreateSinkAsync(gagr::BillingAccountName parent, LogSink sink, st::CancellationToken cancellationToken) =>
            CreateSinkAsync(parent, sink, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// 
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogSink UpdateSink(UpdateSinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// 
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> UpdateSinkAsync(UpdateSinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// 
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> UpdateSinkAsync(UpdateSinkRequest request, st::CancellationToken cancellationToken) =>
            UpdateSinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// 
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to update, including the parent
        /// resource and the sink identifier:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="sink">
        /// Required. The updated sink, whose name is the same identifier that appears as part
        /// of `sink_name`.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask that specifies the fields in `sink` that need
        /// an update. A sink field will be overwritten if, and only if, it is
        /// in the update mask. `name` and output only fields cannot be updated.
        /// 
        /// An empty updateMask is temporarily treated as using the following mask
        /// for backwards compatibility purposes:
        /// destination,filter,includeChildren
        /// At some point in the future, behavior will be removed and specifying an
        /// empty updateMask will be an error.
        /// 
        /// For a detailed `FieldMask` definition, see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMask
        /// 
        /// Example: `updateMask=filter`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogSink UpdateSink(string sinkName, LogSink sink, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSink(new UpdateSinkRequest
            {
                SinkName = gax::GaxPreconditions.CheckNotNullOrEmpty(sinkName, nameof(sinkName)),
                Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// 
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to update, including the parent
        /// resource and the sink identifier:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="sink">
        /// Required. The updated sink, whose name is the same identifier that appears as part
        /// of `sink_name`.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask that specifies the fields in `sink` that need
        /// an update. A sink field will be overwritten if, and only if, it is
        /// in the update mask. `name` and output only fields cannot be updated.
        /// 
        /// An empty updateMask is temporarily treated as using the following mask
        /// for backwards compatibility purposes:
        /// destination,filter,includeChildren
        /// At some point in the future, behavior will be removed and specifying an
        /// empty updateMask will be an error.
        /// 
        /// For a detailed `FieldMask` definition, see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMask
        /// 
        /// Example: `updateMask=filter`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> UpdateSinkAsync(string sinkName, LogSink sink, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSinkAsync(new UpdateSinkRequest
            {
                SinkName = gax::GaxPreconditions.CheckNotNullOrEmpty(sinkName, nameof(sinkName)),
                Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// 
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to update, including the parent
        /// resource and the sink identifier:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="sink">
        /// Required. The updated sink, whose name is the same identifier that appears as part
        /// of `sink_name`.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask that specifies the fields in `sink` that need
        /// an update. A sink field will be overwritten if, and only if, it is
        /// in the update mask. `name` and output only fields cannot be updated.
        /// 
        /// An empty updateMask is temporarily treated as using the following mask
        /// for backwards compatibility purposes:
        /// destination,filter,includeChildren
        /// At some point in the future, behavior will be removed and specifying an
        /// empty updateMask will be an error.
        /// 
        /// For a detailed `FieldMask` definition, see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMask
        /// 
        /// Example: `updateMask=filter`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> UpdateSinkAsync(string sinkName, LogSink sink, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSinkAsync(sinkName, sink, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// 
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to update, including the parent
        /// resource and the sink identifier:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="sink">
        /// Required. The updated sink, whose name is the same identifier that appears as part
        /// of `sink_name`.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask that specifies the fields in `sink` that need
        /// an update. A sink field will be overwritten if, and only if, it is
        /// in the update mask. `name` and output only fields cannot be updated.
        /// 
        /// An empty updateMask is temporarily treated as using the following mask
        /// for backwards compatibility purposes:
        /// destination,filter,includeChildren
        /// At some point in the future, behavior will be removed and specifying an
        /// empty updateMask will be an error.
        /// 
        /// For a detailed `FieldMask` definition, see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMask
        /// 
        /// Example: `updateMask=filter`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogSink UpdateSink(LogSinkName sinkName, LogSink sink, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSink(new UpdateSinkRequest
            {
                SinkNameAsLogSinkName = gax::GaxPreconditions.CheckNotNull(sinkName, nameof(sinkName)),
                Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// 
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to update, including the parent
        /// resource and the sink identifier:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="sink">
        /// Required. The updated sink, whose name is the same identifier that appears as part
        /// of `sink_name`.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask that specifies the fields in `sink` that need
        /// an update. A sink field will be overwritten if, and only if, it is
        /// in the update mask. `name` and output only fields cannot be updated.
        /// 
        /// An empty updateMask is temporarily treated as using the following mask
        /// for backwards compatibility purposes:
        /// destination,filter,includeChildren
        /// At some point in the future, behavior will be removed and specifying an
        /// empty updateMask will be an error.
        /// 
        /// For a detailed `FieldMask` definition, see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMask
        /// 
        /// Example: `updateMask=filter`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> UpdateSinkAsync(LogSinkName sinkName, LogSink sink, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSinkAsync(new UpdateSinkRequest
            {
                SinkNameAsLogSinkName = gax::GaxPreconditions.CheckNotNull(sinkName, nameof(sinkName)),
                Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// 
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to update, including the parent
        /// resource and the sink identifier:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="sink">
        /// Required. The updated sink, whose name is the same identifier that appears as part
        /// of `sink_name`.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask that specifies the fields in `sink` that need
        /// an update. A sink field will be overwritten if, and only if, it is
        /// in the update mask. `name` and output only fields cannot be updated.
        /// 
        /// An empty updateMask is temporarily treated as using the following mask
        /// for backwards compatibility purposes:
        /// destination,filter,includeChildren
        /// At some point in the future, behavior will be removed and specifying an
        /// empty updateMask will be an error.
        /// 
        /// For a detailed `FieldMask` definition, see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMask
        /// 
        /// Example: `updateMask=filter`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> UpdateSinkAsync(LogSinkName sinkName, LogSink sink, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSinkAsync(sinkName, sink, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// 
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to update, including the parent
        /// resource and the sink identifier:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="sink">
        /// Required. The updated sink, whose name is the same identifier that appears as part
        /// of `sink_name`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogSink UpdateSink(string sinkName, LogSink sink, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSink(new UpdateSinkRequest
            {
                SinkName = gax::GaxPreconditions.CheckNotNullOrEmpty(sinkName, nameof(sinkName)),
                Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
            }, callSettings);

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// 
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to update, including the parent
        /// resource and the sink identifier:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="sink">
        /// Required. The updated sink, whose name is the same identifier that appears as part
        /// of `sink_name`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> UpdateSinkAsync(string sinkName, LogSink sink, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSinkAsync(new UpdateSinkRequest
            {
                SinkName = gax::GaxPreconditions.CheckNotNullOrEmpty(sinkName, nameof(sinkName)),
                Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
            }, callSettings);

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// 
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to update, including the parent
        /// resource and the sink identifier:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="sink">
        /// Required. The updated sink, whose name is the same identifier that appears as part
        /// of `sink_name`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> UpdateSinkAsync(string sinkName, LogSink sink, st::CancellationToken cancellationToken) =>
            UpdateSinkAsync(sinkName, sink, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// 
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to update, including the parent
        /// resource and the sink identifier:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="sink">
        /// Required. The updated sink, whose name is the same identifier that appears as part
        /// of `sink_name`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogSink UpdateSink(LogSinkName sinkName, LogSink sink, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSink(new UpdateSinkRequest
            {
                SinkNameAsLogSinkName = gax::GaxPreconditions.CheckNotNull(sinkName, nameof(sinkName)),
                Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
            }, callSettings);

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// 
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to update, including the parent
        /// resource and the sink identifier:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="sink">
        /// Required. The updated sink, whose name is the same identifier that appears as part
        /// of `sink_name`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> UpdateSinkAsync(LogSinkName sinkName, LogSink sink, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSinkAsync(new UpdateSinkRequest
            {
                SinkNameAsLogSinkName = gax::GaxPreconditions.CheckNotNull(sinkName, nameof(sinkName)),
                Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
            }, callSettings);

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// 
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to update, including the parent
        /// resource and the sink identifier:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="sink">
        /// Required. The updated sink, whose name is the same identifier that appears as part
        /// of `sink_name`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogSink> UpdateSinkAsync(LogSinkName sinkName, LogSink sink, st::CancellationToken cancellationToken) =>
            UpdateSinkAsync(sinkName, sink, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a sink. If the sink has a unique `writer_identity`, then that
        /// service account is also deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSink(DeleteSinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a sink. If the sink has a unique `writer_identity`, then that
        /// service account is also deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSinkAsync(DeleteSinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a sink. If the sink has a unique `writer_identity`, then that
        /// service account is also deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSinkAsync(DeleteSinkRequest request, st::CancellationToken cancellationToken) =>
            DeleteSinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a sink. If the sink has a unique `writer_identity`, then that
        /// service account is also deleted.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to delete, including the parent
        /// resource and the sink identifier:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSink(string sinkName, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSink(new DeleteSinkRequest
            {
                SinkName = gax::GaxPreconditions.CheckNotNullOrEmpty(sinkName, nameof(sinkName)),
            }, callSettings);

        /// <summary>
        /// Deletes a sink. If the sink has a unique `writer_identity`, then that
        /// service account is also deleted.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to delete, including the parent
        /// resource and the sink identifier:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSinkAsync(string sinkName, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSinkAsync(new DeleteSinkRequest
            {
                SinkName = gax::GaxPreconditions.CheckNotNullOrEmpty(sinkName, nameof(sinkName)),
            }, callSettings);

        /// <summary>
        /// Deletes a sink. If the sink has a unique `writer_identity`, then that
        /// service account is also deleted.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to delete, including the parent
        /// resource and the sink identifier:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSinkAsync(string sinkName, st::CancellationToken cancellationToken) =>
            DeleteSinkAsync(sinkName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a sink. If the sink has a unique `writer_identity`, then that
        /// service account is also deleted.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to delete, including the parent
        /// resource and the sink identifier:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSink(LogSinkName sinkName, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSink(new DeleteSinkRequest
            {
                SinkNameAsLogSinkName = gax::GaxPreconditions.CheckNotNull(sinkName, nameof(sinkName)),
            }, callSettings);

        /// <summary>
        /// Deletes a sink. If the sink has a unique `writer_identity`, then that
        /// service account is also deleted.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to delete, including the parent
        /// resource and the sink identifier:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSinkAsync(LogSinkName sinkName, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSinkAsync(new DeleteSinkRequest
            {
                SinkNameAsLogSinkName = gax::GaxPreconditions.CheckNotNull(sinkName, nameof(sinkName)),
            }, callSettings);

        /// <summary>
        /// Deletes a sink. If the sink has a unique `writer_identity`, then that
        /// service account is also deleted.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to delete, including the parent
        /// resource and the sink identifier:
        /// 
        /// "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        /// "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        /// "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        /// 
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSinkAsync(LogSinkName sinkName, st::CancellationToken cancellationToken) =>
            DeleteSinkAsync(sinkName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all the exclusions in a parent resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LogExclusion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExclusionsResponse, LogExclusion> ListExclusions(ListExclusionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the exclusions in a parent resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LogExclusion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExclusionsResponse, LogExclusion> ListExclusionsAsync(ListExclusionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the exclusions in a parent resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose exclusions are to be listed.
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
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
        /// <returns>A pageable sequence of <see cref="LogExclusion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExclusionsResponse, LogExclusion> ListExclusions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListExclusions(new ListExclusionsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all the exclusions in a parent resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose exclusions are to be listed.
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
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
        /// <returns>A pageable asynchronous sequence of <see cref="LogExclusion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExclusionsResponse, LogExclusion> ListExclusionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListExclusionsAsync(new ListExclusionsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all the exclusions in a parent resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose exclusions are to be listed.
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
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
        /// <returns>A pageable sequence of <see cref="LogExclusion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExclusionsResponse, LogExclusion> ListExclusions(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListExclusions(new ListExclusionsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all the exclusions in a parent resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose exclusions are to be listed.
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
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
        /// <returns>A pageable asynchronous sequence of <see cref="LogExclusion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExclusionsResponse, LogExclusion> ListExclusionsAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListExclusionsAsync(new ListExclusionsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all the exclusions in a parent resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose exclusions are to be listed.
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
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
        /// <returns>A pageable sequence of <see cref="LogExclusion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExclusionsResponse, LogExclusion> ListExclusions(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListExclusions(new ListExclusionsRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all the exclusions in a parent resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose exclusions are to be listed.
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
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
        /// <returns>A pageable asynchronous sequence of <see cref="LogExclusion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExclusionsResponse, LogExclusion> ListExclusionsAsync(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListExclusionsAsync(new ListExclusionsRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all the exclusions in a parent resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose exclusions are to be listed.
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
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
        /// <returns>A pageable sequence of <see cref="LogExclusion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExclusionsResponse, LogExclusion> ListExclusions(gagr::FolderName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListExclusions(new ListExclusionsRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all the exclusions in a parent resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose exclusions are to be listed.
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
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
        /// <returns>A pageable asynchronous sequence of <see cref="LogExclusion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExclusionsResponse, LogExclusion> ListExclusionsAsync(gagr::FolderName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListExclusionsAsync(new ListExclusionsRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all the exclusions in a parent resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose exclusions are to be listed.
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
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
        /// <returns>A pageable sequence of <see cref="LogExclusion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExclusionsResponse, LogExclusion> ListExclusions(gagr::BillingAccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListExclusions(new ListExclusionsRequest
            {
                ParentAsBillingAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all the exclusions in a parent resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose exclusions are to be listed.
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
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
        /// <returns>A pageable asynchronous sequence of <see cref="LogExclusion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExclusionsResponse, LogExclusion> ListExclusionsAsync(gagr::BillingAccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListExclusionsAsync(new ListExclusionsRequest
            {
                ParentAsBillingAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets the description of an exclusion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogExclusion GetExclusion(GetExclusionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the description of an exclusion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> GetExclusionAsync(GetExclusionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the description of an exclusion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> GetExclusionAsync(GetExclusionRequest request, st::CancellationToken cancellationToken) =>
            GetExclusionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the description of an exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion:
        /// 
        /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        /// 
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogExclusion GetExclusion(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetExclusion(new GetExclusionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the description of an exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion:
        /// 
        /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        /// 
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> GetExclusionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetExclusionAsync(new GetExclusionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the description of an exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion:
        /// 
        /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        /// 
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> GetExclusionAsync(string name, st::CancellationToken cancellationToken) =>
            GetExclusionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the description of an exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion:
        /// 
        /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        /// 
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogExclusion GetExclusion(LogExclusionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetExclusion(new GetExclusionRequest
            {
                LogExclusionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the description of an exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion:
        /// 
        /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        /// 
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> GetExclusionAsync(LogExclusionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetExclusionAsync(new GetExclusionRequest
            {
                LogExclusionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the description of an exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion:
        /// 
        /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        /// 
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> GetExclusionAsync(LogExclusionName name, st::CancellationToken cancellationToken) =>
            GetExclusionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new exclusion in a specified parent resource.
        /// Only log entries belonging to that resource can be excluded.
        /// You can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogExclusion CreateExclusion(CreateExclusionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new exclusion in a specified parent resource.
        /// Only log entries belonging to that resource can be excluded.
        /// You can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> CreateExclusionAsync(CreateExclusionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new exclusion in a specified parent resource.
        /// Only log entries belonging to that resource can be excluded.
        /// You can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> CreateExclusionAsync(CreateExclusionRequest request, st::CancellationToken cancellationToken) =>
            CreateExclusionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new exclusion in a specified parent resource.
        /// Only log entries belonging to that resource can be excluded.
        /// You can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the exclusion:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="exclusion">
        /// Required. The new exclusion, whose `name` parameter is an exclusion name
        /// that is not already used in the parent resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogExclusion CreateExclusion(string parent, LogExclusion exclusion, gaxgrpc::CallSettings callSettings = null) =>
            CreateExclusion(new CreateExclusionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Exclusion = gax::GaxPreconditions.CheckNotNull(exclusion, nameof(exclusion)),
            }, callSettings);

        /// <summary>
        /// Creates a new exclusion in a specified parent resource.
        /// Only log entries belonging to that resource can be excluded.
        /// You can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the exclusion:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="exclusion">
        /// Required. The new exclusion, whose `name` parameter is an exclusion name
        /// that is not already used in the parent resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> CreateExclusionAsync(string parent, LogExclusion exclusion, gaxgrpc::CallSettings callSettings = null) =>
            CreateExclusionAsync(new CreateExclusionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Exclusion = gax::GaxPreconditions.CheckNotNull(exclusion, nameof(exclusion)),
            }, callSettings);

        /// <summary>
        /// Creates a new exclusion in a specified parent resource.
        /// Only log entries belonging to that resource can be excluded.
        /// You can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the exclusion:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="exclusion">
        /// Required. The new exclusion, whose `name` parameter is an exclusion name
        /// that is not already used in the parent resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> CreateExclusionAsync(string parent, LogExclusion exclusion, st::CancellationToken cancellationToken) =>
            CreateExclusionAsync(parent, exclusion, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new exclusion in a specified parent resource.
        /// Only log entries belonging to that resource can be excluded.
        /// You can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the exclusion:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="exclusion">
        /// Required. The new exclusion, whose `name` parameter is an exclusion name
        /// that is not already used in the parent resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogExclusion CreateExclusion(gagr::ProjectName parent, LogExclusion exclusion, gaxgrpc::CallSettings callSettings = null) =>
            CreateExclusion(new CreateExclusionRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Exclusion = gax::GaxPreconditions.CheckNotNull(exclusion, nameof(exclusion)),
            }, callSettings);

        /// <summary>
        /// Creates a new exclusion in a specified parent resource.
        /// Only log entries belonging to that resource can be excluded.
        /// You can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the exclusion:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="exclusion">
        /// Required. The new exclusion, whose `name` parameter is an exclusion name
        /// that is not already used in the parent resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> CreateExclusionAsync(gagr::ProjectName parent, LogExclusion exclusion, gaxgrpc::CallSettings callSettings = null) =>
            CreateExclusionAsync(new CreateExclusionRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Exclusion = gax::GaxPreconditions.CheckNotNull(exclusion, nameof(exclusion)),
            }, callSettings);

        /// <summary>
        /// Creates a new exclusion in a specified parent resource.
        /// Only log entries belonging to that resource can be excluded.
        /// You can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the exclusion:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="exclusion">
        /// Required. The new exclusion, whose `name` parameter is an exclusion name
        /// that is not already used in the parent resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> CreateExclusionAsync(gagr::ProjectName parent, LogExclusion exclusion, st::CancellationToken cancellationToken) =>
            CreateExclusionAsync(parent, exclusion, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new exclusion in a specified parent resource.
        /// Only log entries belonging to that resource can be excluded.
        /// You can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the exclusion:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="exclusion">
        /// Required. The new exclusion, whose `name` parameter is an exclusion name
        /// that is not already used in the parent resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogExclusion CreateExclusion(gagr::OrganizationName parent, LogExclusion exclusion, gaxgrpc::CallSettings callSettings = null) =>
            CreateExclusion(new CreateExclusionRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Exclusion = gax::GaxPreconditions.CheckNotNull(exclusion, nameof(exclusion)),
            }, callSettings);

        /// <summary>
        /// Creates a new exclusion in a specified parent resource.
        /// Only log entries belonging to that resource can be excluded.
        /// You can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the exclusion:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="exclusion">
        /// Required. The new exclusion, whose `name` parameter is an exclusion name
        /// that is not already used in the parent resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> CreateExclusionAsync(gagr::OrganizationName parent, LogExclusion exclusion, gaxgrpc::CallSettings callSettings = null) =>
            CreateExclusionAsync(new CreateExclusionRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Exclusion = gax::GaxPreconditions.CheckNotNull(exclusion, nameof(exclusion)),
            }, callSettings);

        /// <summary>
        /// Creates a new exclusion in a specified parent resource.
        /// Only log entries belonging to that resource can be excluded.
        /// You can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the exclusion:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="exclusion">
        /// Required. The new exclusion, whose `name` parameter is an exclusion name
        /// that is not already used in the parent resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> CreateExclusionAsync(gagr::OrganizationName parent, LogExclusion exclusion, st::CancellationToken cancellationToken) =>
            CreateExclusionAsync(parent, exclusion, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new exclusion in a specified parent resource.
        /// Only log entries belonging to that resource can be excluded.
        /// You can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the exclusion:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="exclusion">
        /// Required. The new exclusion, whose `name` parameter is an exclusion name
        /// that is not already used in the parent resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogExclusion CreateExclusion(gagr::FolderName parent, LogExclusion exclusion, gaxgrpc::CallSettings callSettings = null) =>
            CreateExclusion(new CreateExclusionRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Exclusion = gax::GaxPreconditions.CheckNotNull(exclusion, nameof(exclusion)),
            }, callSettings);

        /// <summary>
        /// Creates a new exclusion in a specified parent resource.
        /// Only log entries belonging to that resource can be excluded.
        /// You can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the exclusion:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="exclusion">
        /// Required. The new exclusion, whose `name` parameter is an exclusion name
        /// that is not already used in the parent resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> CreateExclusionAsync(gagr::FolderName parent, LogExclusion exclusion, gaxgrpc::CallSettings callSettings = null) =>
            CreateExclusionAsync(new CreateExclusionRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Exclusion = gax::GaxPreconditions.CheckNotNull(exclusion, nameof(exclusion)),
            }, callSettings);

        /// <summary>
        /// Creates a new exclusion in a specified parent resource.
        /// Only log entries belonging to that resource can be excluded.
        /// You can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the exclusion:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="exclusion">
        /// Required. The new exclusion, whose `name` parameter is an exclusion name
        /// that is not already used in the parent resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> CreateExclusionAsync(gagr::FolderName parent, LogExclusion exclusion, st::CancellationToken cancellationToken) =>
            CreateExclusionAsync(parent, exclusion, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new exclusion in a specified parent resource.
        /// Only log entries belonging to that resource can be excluded.
        /// You can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the exclusion:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="exclusion">
        /// Required. The new exclusion, whose `name` parameter is an exclusion name
        /// that is not already used in the parent resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogExclusion CreateExclusion(gagr::BillingAccountName parent, LogExclusion exclusion, gaxgrpc::CallSettings callSettings = null) =>
            CreateExclusion(new CreateExclusionRequest
            {
                ParentAsBillingAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Exclusion = gax::GaxPreconditions.CheckNotNull(exclusion, nameof(exclusion)),
            }, callSettings);

        /// <summary>
        /// Creates a new exclusion in a specified parent resource.
        /// Only log entries belonging to that resource can be excluded.
        /// You can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the exclusion:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="exclusion">
        /// Required. The new exclusion, whose `name` parameter is an exclusion name
        /// that is not already used in the parent resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> CreateExclusionAsync(gagr::BillingAccountName parent, LogExclusion exclusion, gaxgrpc::CallSettings callSettings = null) =>
            CreateExclusionAsync(new CreateExclusionRequest
            {
                ParentAsBillingAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Exclusion = gax::GaxPreconditions.CheckNotNull(exclusion, nameof(exclusion)),
            }, callSettings);

        /// <summary>
        /// Creates a new exclusion in a specified parent resource.
        /// Only log entries belonging to that resource can be excluded.
        /// You can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the exclusion:
        /// 
        /// "projects/[PROJECT_ID]"
        /// "organizations/[ORGANIZATION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]"
        /// "folders/[FOLDER_ID]"
        /// 
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="exclusion">
        /// Required. The new exclusion, whose `name` parameter is an exclusion name
        /// that is not already used in the parent resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> CreateExclusionAsync(gagr::BillingAccountName parent, LogExclusion exclusion, st::CancellationToken cancellationToken) =>
            CreateExclusionAsync(parent, exclusion, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Changes one or more properties of an existing exclusion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogExclusion UpdateExclusion(UpdateExclusionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes one or more properties of an existing exclusion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> UpdateExclusionAsync(UpdateExclusionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes one or more properties of an existing exclusion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> UpdateExclusionAsync(UpdateExclusionRequest request, st::CancellationToken cancellationToken) =>
            UpdateExclusionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Changes one or more properties of an existing exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the exclusion to update:
        /// 
        /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        /// 
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="exclusion">
        /// Required. New values for the existing exclusion. Only the fields specified in
        /// `update_mask` are relevant.
        /// </param>
        /// <param name="updateMask">
        /// Required. A non-empty list of fields to change in the existing exclusion. New values
        /// for the fields are taken from the corresponding fields in the
        /// [LogExclusion][google.logging.v2.LogExclusion] included in this request. Fields not mentioned in
        /// `update_mask` are not changed and are ignored in the request.
        /// 
        /// For example, to change the filter and description of an exclusion,
        /// specify an `update_mask` of `"filter,description"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogExclusion UpdateExclusion(string name, LogExclusion exclusion, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateExclusion(new UpdateExclusionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Exclusion = gax::GaxPreconditions.CheckNotNull(exclusion, nameof(exclusion)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Changes one or more properties of an existing exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the exclusion to update:
        /// 
        /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        /// 
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="exclusion">
        /// Required. New values for the existing exclusion. Only the fields specified in
        /// `update_mask` are relevant.
        /// </param>
        /// <param name="updateMask">
        /// Required. A non-empty list of fields to change in the existing exclusion. New values
        /// for the fields are taken from the corresponding fields in the
        /// [LogExclusion][google.logging.v2.LogExclusion] included in this request. Fields not mentioned in
        /// `update_mask` are not changed and are ignored in the request.
        /// 
        /// For example, to change the filter and description of an exclusion,
        /// specify an `update_mask` of `"filter,description"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> UpdateExclusionAsync(string name, LogExclusion exclusion, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateExclusionAsync(new UpdateExclusionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Exclusion = gax::GaxPreconditions.CheckNotNull(exclusion, nameof(exclusion)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Changes one or more properties of an existing exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the exclusion to update:
        /// 
        /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        /// 
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="exclusion">
        /// Required. New values for the existing exclusion. Only the fields specified in
        /// `update_mask` are relevant.
        /// </param>
        /// <param name="updateMask">
        /// Required. A non-empty list of fields to change in the existing exclusion. New values
        /// for the fields are taken from the corresponding fields in the
        /// [LogExclusion][google.logging.v2.LogExclusion] included in this request. Fields not mentioned in
        /// `update_mask` are not changed and are ignored in the request.
        /// 
        /// For example, to change the filter and description of an exclusion,
        /// specify an `update_mask` of `"filter,description"`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> UpdateExclusionAsync(string name, LogExclusion exclusion, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateExclusionAsync(name, exclusion, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Changes one or more properties of an existing exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the exclusion to update:
        /// 
        /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        /// 
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="exclusion">
        /// Required. New values for the existing exclusion. Only the fields specified in
        /// `update_mask` are relevant.
        /// </param>
        /// <param name="updateMask">
        /// Required. A non-empty list of fields to change in the existing exclusion. New values
        /// for the fields are taken from the corresponding fields in the
        /// [LogExclusion][google.logging.v2.LogExclusion] included in this request. Fields not mentioned in
        /// `update_mask` are not changed and are ignored in the request.
        /// 
        /// For example, to change the filter and description of an exclusion,
        /// specify an `update_mask` of `"filter,description"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogExclusion UpdateExclusion(LogExclusionName name, LogExclusion exclusion, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateExclusion(new UpdateExclusionRequest
            {
                LogExclusionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Exclusion = gax::GaxPreconditions.CheckNotNull(exclusion, nameof(exclusion)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Changes one or more properties of an existing exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the exclusion to update:
        /// 
        /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        /// 
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="exclusion">
        /// Required. New values for the existing exclusion. Only the fields specified in
        /// `update_mask` are relevant.
        /// </param>
        /// <param name="updateMask">
        /// Required. A non-empty list of fields to change in the existing exclusion. New values
        /// for the fields are taken from the corresponding fields in the
        /// [LogExclusion][google.logging.v2.LogExclusion] included in this request. Fields not mentioned in
        /// `update_mask` are not changed and are ignored in the request.
        /// 
        /// For example, to change the filter and description of an exclusion,
        /// specify an `update_mask` of `"filter,description"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> UpdateExclusionAsync(LogExclusionName name, LogExclusion exclusion, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateExclusionAsync(new UpdateExclusionRequest
            {
                LogExclusionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Exclusion = gax::GaxPreconditions.CheckNotNull(exclusion, nameof(exclusion)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Changes one or more properties of an existing exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the exclusion to update:
        /// 
        /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        /// 
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="exclusion">
        /// Required. New values for the existing exclusion. Only the fields specified in
        /// `update_mask` are relevant.
        /// </param>
        /// <param name="updateMask">
        /// Required. A non-empty list of fields to change in the existing exclusion. New values
        /// for the fields are taken from the corresponding fields in the
        /// [LogExclusion][google.logging.v2.LogExclusion] included in this request. Fields not mentioned in
        /// `update_mask` are not changed and are ignored in the request.
        /// 
        /// For example, to change the filter and description of an exclusion,
        /// specify an `update_mask` of `"filter,description"`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogExclusion> UpdateExclusionAsync(LogExclusionName name, LogExclusion exclusion, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateExclusionAsync(name, exclusion, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an exclusion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteExclusion(DeleteExclusionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an exclusion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteExclusionAsync(DeleteExclusionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an exclusion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteExclusionAsync(DeleteExclusionRequest request, st::CancellationToken cancellationToken) =>
            DeleteExclusionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion to delete:
        /// 
        /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        /// 
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteExclusion(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExclusion(new DeleteExclusionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion to delete:
        /// 
        /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        /// 
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteExclusionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExclusionAsync(new DeleteExclusionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion to delete:
        /// 
        /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        /// 
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteExclusionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteExclusionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion to delete:
        /// 
        /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        /// 
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteExclusion(LogExclusionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExclusion(new DeleteExclusionRequest
            {
                LogExclusionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion to delete:
        /// 
        /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        /// 
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteExclusionAsync(LogExclusionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExclusionAsync(new DeleteExclusionRequest
            {
                LogExclusionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion to delete:
        /// 
        /// "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        /// "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        /// "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        /// "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        /// 
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteExclusionAsync(LogExclusionName name, st::CancellationToken cancellationToken) =>
            DeleteExclusionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the Logs Router CMEK settings for the given resource.
        /// 
        /// Note: CMEK for the Logs Router can currently only be configured for GCP
        /// organizations. Once configured, it applies to all projects and folders in
        /// the GCP organization.
        /// 
        /// See [Enabling CMEK for Logs
        /// Router](/logging/docs/routing/managed-encryption) for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CmekSettings GetCmekSettings(GetCmekSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the Logs Router CMEK settings for the given resource.
        /// 
        /// Note: CMEK for the Logs Router can currently only be configured for GCP
        /// organizations. Once configured, it applies to all projects and folders in
        /// the GCP organization.
        /// 
        /// See [Enabling CMEK for Logs
        /// Router](/logging/docs/routing/managed-encryption) for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CmekSettings> GetCmekSettingsAsync(GetCmekSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the Logs Router CMEK settings for the given resource.
        /// 
        /// Note: CMEK for the Logs Router can currently only be configured for GCP
        /// organizations. Once configured, it applies to all projects and folders in
        /// the GCP organization.
        /// 
        /// See [Enabling CMEK for Logs
        /// Router](/logging/docs/routing/managed-encryption) for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CmekSettings> GetCmekSettingsAsync(GetCmekSettingsRequest request, st::CancellationToken cancellationToken) =>
            GetCmekSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the Logs Router CMEK settings for the given resource.
        /// 
        /// Note: CMEK for the Logs Router can currently only be configured for GCP
        /// organizations. Once configured, it applies to all projects and folders in
        /// the GCP organization.
        /// 
        /// [UpdateCmekSettings][google.logging.v2.ConfigServiceV2.UpdateCmekSettings]
        /// will fail if 1) `kms_key_name` is invalid, or 2) the associated service
        /// account does not have the required
        /// `roles/cloudkms.cryptoKeyEncrypterDecrypter` role assigned for the key, or
        /// 3) access to the key is disabled.
        /// 
        /// See [Enabling CMEK for Logs
        /// Router](/logging/docs/routing/managed-encryption) for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CmekSettings UpdateCmekSettings(UpdateCmekSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Logs Router CMEK settings for the given resource.
        /// 
        /// Note: CMEK for the Logs Router can currently only be configured for GCP
        /// organizations. Once configured, it applies to all projects and folders in
        /// the GCP organization.
        /// 
        /// [UpdateCmekSettings][google.logging.v2.ConfigServiceV2.UpdateCmekSettings]
        /// will fail if 1) `kms_key_name` is invalid, or 2) the associated service
        /// account does not have the required
        /// `roles/cloudkms.cryptoKeyEncrypterDecrypter` role assigned for the key, or
        /// 3) access to the key is disabled.
        /// 
        /// See [Enabling CMEK for Logs
        /// Router](/logging/docs/routing/managed-encryption) for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CmekSettings> UpdateCmekSettingsAsync(UpdateCmekSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Logs Router CMEK settings for the given resource.
        /// 
        /// Note: CMEK for the Logs Router can currently only be configured for GCP
        /// organizations. Once configured, it applies to all projects and folders in
        /// the GCP organization.
        /// 
        /// [UpdateCmekSettings][google.logging.v2.ConfigServiceV2.UpdateCmekSettings]
        /// will fail if 1) `kms_key_name` is invalid, or 2) the associated service
        /// account does not have the required
        /// `roles/cloudkms.cryptoKeyEncrypterDecrypter` role assigned for the key, or
        /// 3) access to the key is disabled.
        /// 
        /// See [Enabling CMEK for Logs
        /// Router](/logging/docs/routing/managed-encryption) for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CmekSettings> UpdateCmekSettingsAsync(UpdateCmekSettingsRequest request, st::CancellationToken cancellationToken) =>
            UpdateCmekSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ConfigServiceV2 client wrapper implementation, for convenient use.</summary>
    public sealed partial class ConfigServiceV2ClientImpl : ConfigServiceV2Client
    {
        private readonly gaxgrpc::ApiCall<ListBucketsRequest, ListBucketsResponse> _callListBuckets;

        private readonly gaxgrpc::ApiCall<GetBucketRequest, LogBucket> _callGetBucket;

        private readonly gaxgrpc::ApiCall<UpdateBucketRequest, LogBucket> _callUpdateBucket;

        private readonly gaxgrpc::ApiCall<ListSinksRequest, ListSinksResponse> _callListSinks;

        private readonly gaxgrpc::ApiCall<GetSinkRequest, LogSink> _callGetSink;

        private readonly gaxgrpc::ApiCall<CreateSinkRequest, LogSink> _callCreateSink;

        private readonly gaxgrpc::ApiCall<UpdateSinkRequest, LogSink> _callUpdateSink;

        private readonly gaxgrpc::ApiCall<DeleteSinkRequest, wkt::Empty> _callDeleteSink;

        private readonly gaxgrpc::ApiCall<ListExclusionsRequest, ListExclusionsResponse> _callListExclusions;

        private readonly gaxgrpc::ApiCall<GetExclusionRequest, LogExclusion> _callGetExclusion;

        private readonly gaxgrpc::ApiCall<CreateExclusionRequest, LogExclusion> _callCreateExclusion;

        private readonly gaxgrpc::ApiCall<UpdateExclusionRequest, LogExclusion> _callUpdateExclusion;

        private readonly gaxgrpc::ApiCall<DeleteExclusionRequest, wkt::Empty> _callDeleteExclusion;

        private readonly gaxgrpc::ApiCall<GetCmekSettingsRequest, CmekSettings> _callGetCmekSettings;

        private readonly gaxgrpc::ApiCall<UpdateCmekSettingsRequest, CmekSettings> _callUpdateCmekSettings;

        /// <summary>
        /// Constructs a client wrapper for the ConfigServiceV2 service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ConfigServiceV2Settings"/> used within this client.</param>
        public ConfigServiceV2ClientImpl(ConfigServiceV2.ConfigServiceV2Client grpcClient, ConfigServiceV2Settings settings)
        {
            GrpcClient = grpcClient;
            ConfigServiceV2Settings effectiveSettings = settings ?? ConfigServiceV2Settings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callListBuckets = clientHelper.BuildApiCall<ListBucketsRequest, ListBucketsResponse>(grpcClient.ListBucketsAsync, grpcClient.ListBuckets, effectiveSettings.ListBucketsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListBuckets);
            Modify_ListBucketsApiCall(ref _callListBuckets);
            _callGetBucket = clientHelper.BuildApiCall<GetBucketRequest, LogBucket>(grpcClient.GetBucketAsync, grpcClient.GetBucket, effectiveSettings.GetBucketSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetBucket);
            Modify_GetBucketApiCall(ref _callGetBucket);
            _callUpdateBucket = clientHelper.BuildApiCall<UpdateBucketRequest, LogBucket>(grpcClient.UpdateBucketAsync, grpcClient.UpdateBucket, effectiveSettings.UpdateBucketSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateBucket);
            Modify_UpdateBucketApiCall(ref _callUpdateBucket);
            _callListSinks = clientHelper.BuildApiCall<ListSinksRequest, ListSinksResponse>(grpcClient.ListSinksAsync, grpcClient.ListSinks, effectiveSettings.ListSinksSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSinks);
            Modify_ListSinksApiCall(ref _callListSinks);
            _callGetSink = clientHelper.BuildApiCall<GetSinkRequest, LogSink>(grpcClient.GetSinkAsync, grpcClient.GetSink, effectiveSettings.GetSinkSettings).WithGoogleRequestParam("sink_name", request => request.SinkName);
            Modify_ApiCall(ref _callGetSink);
            Modify_GetSinkApiCall(ref _callGetSink);
            _callCreateSink = clientHelper.BuildApiCall<CreateSinkRequest, LogSink>(grpcClient.CreateSinkAsync, grpcClient.CreateSink, effectiveSettings.CreateSinkSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSink);
            Modify_CreateSinkApiCall(ref _callCreateSink);
            _callUpdateSink = clientHelper.BuildApiCall<UpdateSinkRequest, LogSink>(grpcClient.UpdateSinkAsync, grpcClient.UpdateSink, effectiveSettings.UpdateSinkSettings).WithGoogleRequestParam("sink_name", request => request.SinkName);
            Modify_ApiCall(ref _callUpdateSink);
            Modify_UpdateSinkApiCall(ref _callUpdateSink);
            _callDeleteSink = clientHelper.BuildApiCall<DeleteSinkRequest, wkt::Empty>(grpcClient.DeleteSinkAsync, grpcClient.DeleteSink, effectiveSettings.DeleteSinkSettings).WithGoogleRequestParam("sink_name", request => request.SinkName);
            Modify_ApiCall(ref _callDeleteSink);
            Modify_DeleteSinkApiCall(ref _callDeleteSink);
            _callListExclusions = clientHelper.BuildApiCall<ListExclusionsRequest, ListExclusionsResponse>(grpcClient.ListExclusionsAsync, grpcClient.ListExclusions, effectiveSettings.ListExclusionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListExclusions);
            Modify_ListExclusionsApiCall(ref _callListExclusions);
            _callGetExclusion = clientHelper.BuildApiCall<GetExclusionRequest, LogExclusion>(grpcClient.GetExclusionAsync, grpcClient.GetExclusion, effectiveSettings.GetExclusionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetExclusion);
            Modify_GetExclusionApiCall(ref _callGetExclusion);
            _callCreateExclusion = clientHelper.BuildApiCall<CreateExclusionRequest, LogExclusion>(grpcClient.CreateExclusionAsync, grpcClient.CreateExclusion, effectiveSettings.CreateExclusionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateExclusion);
            Modify_CreateExclusionApiCall(ref _callCreateExclusion);
            _callUpdateExclusion = clientHelper.BuildApiCall<UpdateExclusionRequest, LogExclusion>(grpcClient.UpdateExclusionAsync, grpcClient.UpdateExclusion, effectiveSettings.UpdateExclusionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateExclusion);
            Modify_UpdateExclusionApiCall(ref _callUpdateExclusion);
            _callDeleteExclusion = clientHelper.BuildApiCall<DeleteExclusionRequest, wkt::Empty>(grpcClient.DeleteExclusionAsync, grpcClient.DeleteExclusion, effectiveSettings.DeleteExclusionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteExclusion);
            Modify_DeleteExclusionApiCall(ref _callDeleteExclusion);
            _callGetCmekSettings = clientHelper.BuildApiCall<GetCmekSettingsRequest, CmekSettings>(grpcClient.GetCmekSettingsAsync, grpcClient.GetCmekSettings, effectiveSettings.GetCmekSettingsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCmekSettings);
            Modify_GetCmekSettingsApiCall(ref _callGetCmekSettings);
            _callUpdateCmekSettings = clientHelper.BuildApiCall<UpdateCmekSettingsRequest, CmekSettings>(grpcClient.UpdateCmekSettingsAsync, grpcClient.UpdateCmekSettings, effectiveSettings.UpdateCmekSettingsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateCmekSettings);
            Modify_UpdateCmekSettingsApiCall(ref _callUpdateCmekSettings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListBucketsApiCall(ref gaxgrpc::ApiCall<ListBucketsRequest, ListBucketsResponse> call);

        partial void Modify_GetBucketApiCall(ref gaxgrpc::ApiCall<GetBucketRequest, LogBucket> call);

        partial void Modify_UpdateBucketApiCall(ref gaxgrpc::ApiCall<UpdateBucketRequest, LogBucket> call);

        partial void Modify_ListSinksApiCall(ref gaxgrpc::ApiCall<ListSinksRequest, ListSinksResponse> call);

        partial void Modify_GetSinkApiCall(ref gaxgrpc::ApiCall<GetSinkRequest, LogSink> call);

        partial void Modify_CreateSinkApiCall(ref gaxgrpc::ApiCall<CreateSinkRequest, LogSink> call);

        partial void Modify_UpdateSinkApiCall(ref gaxgrpc::ApiCall<UpdateSinkRequest, LogSink> call);

        partial void Modify_DeleteSinkApiCall(ref gaxgrpc::ApiCall<DeleteSinkRequest, wkt::Empty> call);

        partial void Modify_ListExclusionsApiCall(ref gaxgrpc::ApiCall<ListExclusionsRequest, ListExclusionsResponse> call);

        partial void Modify_GetExclusionApiCall(ref gaxgrpc::ApiCall<GetExclusionRequest, LogExclusion> call);

        partial void Modify_CreateExclusionApiCall(ref gaxgrpc::ApiCall<CreateExclusionRequest, LogExclusion> call);

        partial void Modify_UpdateExclusionApiCall(ref gaxgrpc::ApiCall<UpdateExclusionRequest, LogExclusion> call);

        partial void Modify_DeleteExclusionApiCall(ref gaxgrpc::ApiCall<DeleteExclusionRequest, wkt::Empty> call);

        partial void Modify_GetCmekSettingsApiCall(ref gaxgrpc::ApiCall<GetCmekSettingsRequest, CmekSettings> call);

        partial void Modify_UpdateCmekSettingsApiCall(ref gaxgrpc::ApiCall<UpdateCmekSettingsRequest, CmekSettings> call);

        partial void OnConstruction(ConfigServiceV2.ConfigServiceV2Client grpcClient, ConfigServiceV2Settings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ConfigServiceV2 client</summary>
        public override ConfigServiceV2.ConfigServiceV2Client GrpcClient { get; }

        partial void Modify_ListBucketsRequest(ref ListBucketsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBucketRequest(ref GetBucketRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateBucketRequest(ref UpdateBucketRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSinksRequest(ref ListSinksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSinkRequest(ref GetSinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSinkRequest(ref CreateSinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSinkRequest(ref UpdateSinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSinkRequest(ref DeleteSinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListExclusionsRequest(ref ListExclusionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetExclusionRequest(ref GetExclusionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateExclusionRequest(ref CreateExclusionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateExclusionRequest(ref UpdateExclusionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteExclusionRequest(ref DeleteExclusionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCmekSettingsRequest(ref GetCmekSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCmekSettingsRequest(ref UpdateCmekSettingsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists buckets (Beta).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LogBucket"/> resources.</returns>
        public override gax::PagedEnumerable<ListBucketsResponse, LogBucket> ListBuckets(ListBucketsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBucketsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListBucketsRequest, ListBucketsResponse, LogBucket>(_callListBuckets, request, callSettings);
        }

        /// <summary>
        /// Lists buckets (Beta).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LogBucket"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBucketsResponse, LogBucket> ListBucketsAsync(ListBucketsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBucketsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBucketsRequest, ListBucketsResponse, LogBucket>(_callListBuckets, request, callSettings);
        }

        /// <summary>
        /// Gets a bucket (Beta).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LogBucket GetBucket(GetBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBucketRequest(ref request, ref callSettings);
            return _callGetBucket.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a bucket (Beta).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LogBucket> GetBucketAsync(GetBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBucketRequest(ref request, ref callSettings);
            return _callGetBucket.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a bucket. This method replaces the following fields in the
        /// existing bucket with values from the new bucket: `retention_period`
        /// 
        /// If the retention period is decreased and the bucket is locked,
        /// FAILED_PRECONDITION will be returned.
        /// 
        /// If the bucket has a LifecycleState of DELETE_REQUESTED, FAILED_PRECONDITION
        /// will be returned.
        /// 
        /// A buckets region may not be modified after it is created.
        /// This method is in Beta.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LogBucket UpdateBucket(UpdateBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBucketRequest(ref request, ref callSettings);
            return _callUpdateBucket.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a bucket. This method replaces the following fields in the
        /// existing bucket with values from the new bucket: `retention_period`
        /// 
        /// If the retention period is decreased and the bucket is locked,
        /// FAILED_PRECONDITION will be returned.
        /// 
        /// If the bucket has a LifecycleState of DELETE_REQUESTED, FAILED_PRECONDITION
        /// will be returned.
        /// 
        /// A buckets region may not be modified after it is created.
        /// This method is in Beta.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LogBucket> UpdateBucketAsync(UpdateBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBucketRequest(ref request, ref callSettings);
            return _callUpdateBucket.Async(request, callSettings);
        }

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LogSink"/> resources.</returns>
        public override gax::PagedEnumerable<ListSinksResponse, LogSink> ListSinks(ListSinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSinksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSinksRequest, ListSinksResponse, LogSink>(_callListSinks, request, callSettings);
        }

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LogSink"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSinksResponse, LogSink> ListSinksAsync(ListSinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSinksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSinksRequest, ListSinksResponse, LogSink>(_callListSinks, request, callSettings);
        }

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LogSink GetSink(GetSinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSinkRequest(ref request, ref callSettings);
            return _callGetSink.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LogSink> GetSinkAsync(GetSinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSinkRequest(ref request, ref callSettings);
            return _callGetSink.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LogSink CreateSink(CreateSinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSinkRequest(ref request, ref callSettings);
            return _callCreateSink.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LogSink> CreateSinkAsync(CreateSinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSinkRequest(ref request, ref callSettings);
            return _callCreateSink.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// 
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LogSink UpdateSink(UpdateSinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSinkRequest(ref request, ref callSettings);
            return _callUpdateSink.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        /// 
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LogSink> UpdateSinkAsync(UpdateSinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSinkRequest(ref request, ref callSettings);
            return _callUpdateSink.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a sink. If the sink has a unique `writer_identity`, then that
        /// service account is also deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteSink(DeleteSinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSinkRequest(ref request, ref callSettings);
            _callDeleteSink.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a sink. If the sink has a unique `writer_identity`, then that
        /// service account is also deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteSinkAsync(DeleteSinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSinkRequest(ref request, ref callSettings);
            return _callDeleteSink.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all the exclusions in a parent resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LogExclusion"/> resources.</returns>
        public override gax::PagedEnumerable<ListExclusionsResponse, LogExclusion> ListExclusions(ListExclusionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListExclusionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListExclusionsRequest, ListExclusionsResponse, LogExclusion>(_callListExclusions, request, callSettings);
        }

        /// <summary>
        /// Lists all the exclusions in a parent resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LogExclusion"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListExclusionsResponse, LogExclusion> ListExclusionsAsync(ListExclusionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListExclusionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListExclusionsRequest, ListExclusionsResponse, LogExclusion>(_callListExclusions, request, callSettings);
        }

        /// <summary>
        /// Gets the description of an exclusion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LogExclusion GetExclusion(GetExclusionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetExclusionRequest(ref request, ref callSettings);
            return _callGetExclusion.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the description of an exclusion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LogExclusion> GetExclusionAsync(GetExclusionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetExclusionRequest(ref request, ref callSettings);
            return _callGetExclusion.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new exclusion in a specified parent resource.
        /// Only log entries belonging to that resource can be excluded.
        /// You can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LogExclusion CreateExclusion(CreateExclusionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateExclusionRequest(ref request, ref callSettings);
            return _callCreateExclusion.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new exclusion in a specified parent resource.
        /// Only log entries belonging to that resource can be excluded.
        /// You can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LogExclusion> CreateExclusionAsync(CreateExclusionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateExclusionRequest(ref request, ref callSettings);
            return _callCreateExclusion.Async(request, callSettings);
        }

        /// <summary>
        /// Changes one or more properties of an existing exclusion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LogExclusion UpdateExclusion(UpdateExclusionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateExclusionRequest(ref request, ref callSettings);
            return _callUpdateExclusion.Sync(request, callSettings);
        }

        /// <summary>
        /// Changes one or more properties of an existing exclusion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LogExclusion> UpdateExclusionAsync(UpdateExclusionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateExclusionRequest(ref request, ref callSettings);
            return _callUpdateExclusion.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an exclusion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteExclusion(DeleteExclusionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteExclusionRequest(ref request, ref callSettings);
            _callDeleteExclusion.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an exclusion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteExclusionAsync(DeleteExclusionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteExclusionRequest(ref request, ref callSettings);
            return _callDeleteExclusion.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the Logs Router CMEK settings for the given resource.
        /// 
        /// Note: CMEK for the Logs Router can currently only be configured for GCP
        /// organizations. Once configured, it applies to all projects and folders in
        /// the GCP organization.
        /// 
        /// See [Enabling CMEK for Logs
        /// Router](/logging/docs/routing/managed-encryption) for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CmekSettings GetCmekSettings(GetCmekSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCmekSettingsRequest(ref request, ref callSettings);
            return _callGetCmekSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the Logs Router CMEK settings for the given resource.
        /// 
        /// Note: CMEK for the Logs Router can currently only be configured for GCP
        /// organizations. Once configured, it applies to all projects and folders in
        /// the GCP organization.
        /// 
        /// See [Enabling CMEK for Logs
        /// Router](/logging/docs/routing/managed-encryption) for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CmekSettings> GetCmekSettingsAsync(GetCmekSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCmekSettingsRequest(ref request, ref callSettings);
            return _callGetCmekSettings.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the Logs Router CMEK settings for the given resource.
        /// 
        /// Note: CMEK for the Logs Router can currently only be configured for GCP
        /// organizations. Once configured, it applies to all projects and folders in
        /// the GCP organization.
        /// 
        /// [UpdateCmekSettings][google.logging.v2.ConfigServiceV2.UpdateCmekSettings]
        /// will fail if 1) `kms_key_name` is invalid, or 2) the associated service
        /// account does not have the required
        /// `roles/cloudkms.cryptoKeyEncrypterDecrypter` role assigned for the key, or
        /// 3) access to the key is disabled.
        /// 
        /// See [Enabling CMEK for Logs
        /// Router](/logging/docs/routing/managed-encryption) for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CmekSettings UpdateCmekSettings(UpdateCmekSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCmekSettingsRequest(ref request, ref callSettings);
            return _callUpdateCmekSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the Logs Router CMEK settings for the given resource.
        /// 
        /// Note: CMEK for the Logs Router can currently only be configured for GCP
        /// organizations. Once configured, it applies to all projects and folders in
        /// the GCP organization.
        /// 
        /// [UpdateCmekSettings][google.logging.v2.ConfigServiceV2.UpdateCmekSettings]
        /// will fail if 1) `kms_key_name` is invalid, or 2) the associated service
        /// account does not have the required
        /// `roles/cloudkms.cryptoKeyEncrypterDecrypter` role assigned for the key, or
        /// 3) access to the key is disabled.
        /// 
        /// See [Enabling CMEK for Logs
        /// Router](/logging/docs/routing/managed-encryption) for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CmekSettings> UpdateCmekSettingsAsync(UpdateCmekSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCmekSettingsRequest(ref request, ref callSettings);
            return _callUpdateCmekSettings.Async(request, callSettings);
        }
    }

    public partial class ListBucketsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSinksRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListExclusionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBucketsResponse : gaxgrpc::IPageResponse<LogBucket>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<LogBucket> GetEnumerator() => Buckets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSinksResponse : gaxgrpc::IPageResponse<LogSink>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<LogSink> GetEnumerator() => Sinks.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListExclusionsResponse : gaxgrpc::IPageResponse<LogExclusion>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<LogExclusion> GetEnumerator() => Exclusions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
