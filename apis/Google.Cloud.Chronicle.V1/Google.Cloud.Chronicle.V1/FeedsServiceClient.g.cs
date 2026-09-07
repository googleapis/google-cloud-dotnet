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
using ga = Google.Api;
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

namespace Google.Cloud.Chronicle.V1
{
    /// <summary>Settings for <see cref="FeedsServiceClient"/> instances.</summary>
    public sealed partial class FeedsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="FeedsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="FeedsServiceSettings"/>.</returns>
        public static FeedsServiceSettings GetDefault() => new FeedsServiceSettings();

        /// <summary>Constructs a new <see cref="FeedsServiceSettings"/> object with default settings.</summary>
        public FeedsServiceSettings()
        {
        }

        private FeedsServiceSettings(FeedsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            FetchServiceAccountForCustomerSettings = existing.FetchServiceAccountForCustomerSettings;
            CreateFeedSettings = existing.CreateFeedSettings;
            GetFeedSettings = existing.GetFeedSettings;
            DeleteFeedSettings = existing.DeleteFeedSettings;
            EnableFeedSettings = existing.EnableFeedSettings;
            DisableFeedSettings = existing.DisableFeedSettings;
            ListFeedsSettings = existing.ListFeedsSettings;
            ListFeedPacksSettings = existing.ListFeedPacksSettings;
            GetFeedPackSettings = existing.GetFeedPackSettings;
            UpdateFeedSettings = existing.UpdateFeedSettings;
            ListFeedSourceTypeSchemasSettings = existing.ListFeedSourceTypeSchemasSettings;
            ListLogTypeSchemasSettings = existing.ListLogTypeSchemasSettings;
            ImportPushLogsSettings = existing.ImportPushLogsSettings;
            GenerateSecretSettings = existing.GenerateSecretSettings;
            OnCopy(existing);
        }

        partial void OnCopy(FeedsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeedsServiceClient.FetchServiceAccountForCustomer</c> and
        /// <c>FeedsServiceClient.FetchServiceAccountForCustomerAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FetchServiceAccountForCustomerSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeedsServiceClient.CreateFeed</c> and <c>FeedsServiceClient.CreateFeedAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateFeedSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>FeedsServiceClient.GetFeed</c>
        ///  and <c>FeedsServiceClient.GetFeedAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetFeedSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeedsServiceClient.DeleteFeed</c> and <c>FeedsServiceClient.DeleteFeedAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteFeedSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeedsServiceClient.EnableFeed</c> and <c>FeedsServiceClient.EnableFeedAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings EnableFeedSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeedsServiceClient.DisableFeed</c> and <c>FeedsServiceClient.DisableFeedAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DisableFeedSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeedsServiceClient.ListFeeds</c> and <c>FeedsServiceClient.ListFeedsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 300000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListFeedsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(300000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeedsServiceClient.ListFeedPacks</c> and <c>FeedsServiceClient.ListFeedPacksAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListFeedPacksSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeedsServiceClient.GetFeedPack</c> and <c>FeedsServiceClient.GetFeedPackAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetFeedPackSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeedsServiceClient.UpdateFeed</c> and <c>FeedsServiceClient.UpdateFeedAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateFeedSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeedsServiceClient.ListFeedSourceTypeSchemas</c> and <c>FeedsServiceClient.ListFeedSourceTypeSchemasAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListFeedSourceTypeSchemasSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeedsServiceClient.ListLogTypeSchemas</c> and <c>FeedsServiceClient.ListLogTypeSchemasAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListLogTypeSchemasSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeedsServiceClient.ImportPushLogs</c> and <c>FeedsServiceClient.ImportPushLogsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ImportPushLogsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeedsServiceClient.GenerateSecret</c> and <c>FeedsServiceClient.GenerateSecretAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateSecretSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="FeedsServiceSettings"/> object.</returns>
        public FeedsServiceSettings Clone() => new FeedsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="FeedsServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class FeedsServiceClientBuilder : gaxgrpc::ClientBuilderBase<FeedsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public FeedsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public FeedsServiceClientBuilder() : base(FeedsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref FeedsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<FeedsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override FeedsServiceClient Build()
        {
            FeedsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<FeedsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<FeedsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private FeedsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return FeedsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<FeedsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return FeedsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => FeedsServiceClient.ChannelPool;
    }

    /// <summary>FeedsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// FeedsService contains procedures for managing Chronicle third-party feeds.
    /// </remarks>
    public abstract partial class FeedsServiceClient
    {
        /// <summary>
        /// The default endpoint for the FeedsService service, which is a host of "chronicle.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "chronicle.googleapis.com:443";

        /// <summary>The default FeedsService scopes.</summary>
        /// <remarks>
        /// The default FeedsService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/chronicle</description></item>
        /// <item><description>https://www.googleapis.com/auth/chronicle.readonly</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/chronicle",
            "https://www.googleapis.com/auth/chronicle.readonly",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(FeedsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="FeedsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="FeedsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="FeedsServiceClient"/>.</returns>
        public static stt::Task<FeedsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new FeedsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="FeedsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="FeedsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="FeedsServiceClient"/>.</returns>
        public static FeedsServiceClient Create() => new FeedsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="FeedsServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="FeedsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="FeedsServiceClient"/>.</returns>
        internal static FeedsServiceClient Create(grpccore::CallInvoker callInvoker, FeedsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            FeedsService.FeedsServiceClient grpcClient = new FeedsService.FeedsServiceClient(callInvoker);
            return new FeedsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC FeedsService client</summary>
        public virtual FeedsService.FeedsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Fetch Chronicle's service account used for ingesting data from Cloud
        /// Storage buckets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FeedServiceAccount FetchServiceAccountForCustomer(FetchServiceAccountForCustomerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetch Chronicle's service account used for ingesting data from Cloud
        /// Storage buckets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeedServiceAccount> FetchServiceAccountForCustomerAsync(FetchServiceAccountForCustomerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetch Chronicle's service account used for ingesting data from Cloud
        /// Storage buckets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeedServiceAccount> FetchServiceAccountForCustomerAsync(FetchServiceAccountForCustomerRequest request, st::CancellationToken cancellationToken) =>
            FetchServiceAccountForCustomerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetch Chronicle's service account used for ingesting data from Cloud
        /// Storage buckets.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this FeedServiceAccount will be
        /// created. Format:
        /// projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FeedServiceAccount FetchServiceAccountForCustomer(string parent, gaxgrpc::CallSettings callSettings = null) =>
            FetchServiceAccountForCustomer(new FetchServiceAccountForCustomerRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Fetch Chronicle's service account used for ingesting data from Cloud
        /// Storage buckets.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this FeedServiceAccount will be
        /// created. Format:
        /// projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeedServiceAccount> FetchServiceAccountForCustomerAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            FetchServiceAccountForCustomerAsync(new FetchServiceAccountForCustomerRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Fetch Chronicle's service account used for ingesting data from Cloud
        /// Storage buckets.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this FeedServiceAccount will be
        /// created. Format:
        /// projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeedServiceAccount> FetchServiceAccountForCustomerAsync(string parent, st::CancellationToken cancellationToken) =>
            FetchServiceAccountForCustomerAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetch Chronicle's service account used for ingesting data from Cloud
        /// Storage buckets.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this FeedServiceAccount will be
        /// created. Format:
        /// projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FeedServiceAccount FetchServiceAccountForCustomer(InstanceName parent, gaxgrpc::CallSettings callSettings = null) =>
            FetchServiceAccountForCustomer(new FetchServiceAccountForCustomerRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Fetch Chronicle's service account used for ingesting data from Cloud
        /// Storage buckets.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this FeedServiceAccount will be
        /// created. Format:
        /// projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeedServiceAccount> FetchServiceAccountForCustomerAsync(InstanceName parent, gaxgrpc::CallSettings callSettings = null) =>
            FetchServiceAccountForCustomerAsync(new FetchServiceAccountForCustomerRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Fetch Chronicle's service account used for ingesting data from Cloud
        /// Storage buckets.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this FeedServiceAccount will be
        /// created. Format:
        /// projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeedServiceAccount> FetchServiceAccountForCustomerAsync(InstanceName parent, st::CancellationToken cancellationToken) =>
            FetchServiceAccountForCustomerAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Feed CreateFeed(CreateFeedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> CreateFeedAsync(CreateFeedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> CreateFeedAsync(CreateFeedRequest request, st::CancellationToken cancellationToken) =>
            CreateFeedAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a feed.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this Feed will be created.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="feed">
        /// Required. Feed to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Feed CreateFeed(string parent, Feed feed, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeed(new CreateFeedRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Feed = gax::GaxPreconditions.CheckNotNull(feed, nameof(feed)),
            }, callSettings);

        /// <summary>
        /// Creates a feed.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this Feed will be created.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="feed">
        /// Required. Feed to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> CreateFeedAsync(string parent, Feed feed, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeedAsync(new CreateFeedRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Feed = gax::GaxPreconditions.CheckNotNull(feed, nameof(feed)),
            }, callSettings);

        /// <summary>
        /// Creates a feed.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this Feed will be created.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="feed">
        /// Required. Feed to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> CreateFeedAsync(string parent, Feed feed, st::CancellationToken cancellationToken) =>
            CreateFeedAsync(parent, feed, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a feed.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this Feed will be created.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="feed">
        /// Required. Feed to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Feed CreateFeed(InstanceName parent, Feed feed, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeed(new CreateFeedRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Feed = gax::GaxPreconditions.CheckNotNull(feed, nameof(feed)),
            }, callSettings);

        /// <summary>
        /// Creates a feed.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this Feed will be created.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="feed">
        /// Required. Feed to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> CreateFeedAsync(InstanceName parent, Feed feed, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeedAsync(new CreateFeedRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Feed = gax::GaxPreconditions.CheckNotNull(feed, nameof(feed)),
            }, callSettings);

        /// <summary>
        /// Creates a feed.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this Feed will be created.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="feed">
        /// Required. Feed to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> CreateFeedAsync(InstanceName parent, Feed feed, st::CancellationToken cancellationToken) =>
            CreateFeedAsync(parent, feed, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Feed GetFeed(GetFeedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> GetFeedAsync(GetFeedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> GetFeedAsync(GetFeedRequest request, st::CancellationToken cancellationToken) =>
            GetFeedAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a feed.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the feed to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Feed GetFeed(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeed(new GetFeedRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a feed.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the feed to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> GetFeedAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeedAsync(new GetFeedRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a feed.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the feed to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> GetFeedAsync(string name, st::CancellationToken cancellationToken) =>
            GetFeedAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a feed.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the feed to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Feed GetFeed(FeedName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeed(new GetFeedRequest
            {
                FeedName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a feed.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the feed to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> GetFeedAsync(FeedName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeedAsync(new GetFeedRequest
            {
                FeedName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a feed.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the feed to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> GetFeedAsync(FeedName name, st::CancellationToken cancellationToken) =>
            GetFeedAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteFeed(DeleteFeedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFeedAsync(DeleteFeedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFeedAsync(DeleteFeedRequest request, st::CancellationToken cancellationToken) =>
            DeleteFeedAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a feed.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the feed to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteFeed(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeed(new DeleteFeedRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a feed.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the feed to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFeedAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeedAsync(new DeleteFeedRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a feed.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the feed to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFeedAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteFeedAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a feed.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the feed to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteFeed(FeedName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeed(new DeleteFeedRequest
            {
                FeedName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a feed.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the feed to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFeedAsync(FeedName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeedAsync(new DeleteFeedRequest
            {
                FeedName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a feed.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the feed to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFeedAsync(FeedName name, st::CancellationToken cancellationToken) =>
            DeleteFeedAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enable feed for ingestion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Feed EnableFeed(EnableFeedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enable feed for ingestion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> EnableFeedAsync(EnableFeedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enable feed for ingestion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> EnableFeedAsync(EnableFeedRequest request, st::CancellationToken cancellationToken) =>
            EnableFeedAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enable feed for ingestion.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feed to enable.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Feed EnableFeed(string name, gaxgrpc::CallSettings callSettings = null) =>
            EnableFeed(new EnableFeedRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Enable feed for ingestion.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feed to enable.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> EnableFeedAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            EnableFeedAsync(new EnableFeedRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Enable feed for ingestion.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feed to enable.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> EnableFeedAsync(string name, st::CancellationToken cancellationToken) =>
            EnableFeedAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enable feed for ingestion.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feed to enable.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Feed EnableFeed(FeedName name, gaxgrpc::CallSettings callSettings = null) =>
            EnableFeed(new EnableFeedRequest
            {
                FeedName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Enable feed for ingestion.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feed to enable.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> EnableFeedAsync(FeedName name, gaxgrpc::CallSettings callSettings = null) =>
            EnableFeedAsync(new EnableFeedRequest
            {
                FeedName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Enable feed for ingestion.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feed to enable.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> EnableFeedAsync(FeedName name, st::CancellationToken cancellationToken) =>
            EnableFeedAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Disable feed for ingestion. Make FeedState ARCHIVED.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Feed DisableFeed(DisableFeedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disable feed for ingestion. Make FeedState ARCHIVED.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> DisableFeedAsync(DisableFeedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disable feed for ingestion. Make FeedState ARCHIVED.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> DisableFeedAsync(DisableFeedRequest request, st::CancellationToken cancellationToken) =>
            DisableFeedAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Disable feed for ingestion. Make FeedState ARCHIVED.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feed to disable.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Feed DisableFeed(string name, gaxgrpc::CallSettings callSettings = null) =>
            DisableFeed(new DisableFeedRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Disable feed for ingestion. Make FeedState ARCHIVED.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feed to disable.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> DisableFeedAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DisableFeedAsync(new DisableFeedRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Disable feed for ingestion. Make FeedState ARCHIVED.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feed to disable.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> DisableFeedAsync(string name, st::CancellationToken cancellationToken) =>
            DisableFeedAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Disable feed for ingestion. Make FeedState ARCHIVED.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feed to disable.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Feed DisableFeed(FeedName name, gaxgrpc::CallSettings callSettings = null) =>
            DisableFeed(new DisableFeedRequest
            {
                FeedName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Disable feed for ingestion. Make FeedState ARCHIVED.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feed to disable.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> DisableFeedAsync(FeedName name, gaxgrpc::CallSettings callSettings = null) =>
            DisableFeedAsync(new DisableFeedRequest
            {
                FeedName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Disable feed for ingestion. Make FeedState ARCHIVED.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feed to disable.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> DisableFeedAsync(FeedName name, st::CancellationToken cancellationToken) =>
            DisableFeedAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all feeds for the customer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Feed"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFeedsResponse, Feed> ListFeeds(ListFeedsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all feeds for the customer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Feed"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFeedsResponse, Feed> ListFeedsAsync(ListFeedsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all feeds for the customer.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this Feed will be created.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
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
        /// <returns>A pageable sequence of <see cref="Feed"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFeedsResponse, Feed> ListFeeds(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeedsRequest request = new ListFeedsRequest
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
            return ListFeeds(request, callSettings);
        }

        /// <summary>
        /// Lists all feeds for the customer.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this Feed will be created.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Feed"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFeedsResponse, Feed> ListFeedsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeedsRequest request = new ListFeedsRequest
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
            return ListFeedsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all feeds for the customer.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this Feed will be created.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
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
        /// <returns>A pageable sequence of <see cref="Feed"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFeedsResponse, Feed> ListFeeds(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeedsRequest request = new ListFeedsRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFeeds(request, callSettings);
        }

        /// <summary>
        /// Lists all feeds for the customer.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this Feed will be created.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Feed"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFeedsResponse, Feed> ListFeedsAsync(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeedsRequest request = new ListFeedsRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFeedsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Packs for which feeds can be configured.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FeedPack"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFeedPacksResponse, FeedPack> ListFeedPacks(ListFeedPacksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Packs for which feeds can be configured.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FeedPack"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFeedPacksResponse, FeedPack> ListFeedPacksAsync(ListFeedPacksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Packs for which feeds can be configured.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this content pack will be created.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
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
        /// <returns>A pageable sequence of <see cref="FeedPack"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFeedPacksResponse, FeedPack> ListFeedPacks(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeedPacksRequest request = new ListFeedPacksRequest
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
            return ListFeedPacks(request, callSettings);
        }

        /// <summary>
        /// Lists Packs for which feeds can be configured.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this content pack will be created.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
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
        /// <returns>A pageable asynchronous sequence of <see cref="FeedPack"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFeedPacksResponse, FeedPack> ListFeedPacksAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeedPacksRequest request = new ListFeedPacksRequest
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
            return ListFeedPacksAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Packs for which feeds can be configured.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this content pack will be created.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
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
        /// <returns>A pageable sequence of <see cref="FeedPack"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFeedPacksResponse, FeedPack> ListFeedPacks(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeedPacksRequest request = new ListFeedPacksRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFeedPacks(request, callSettings);
        }

        /// <summary>
        /// Lists Packs for which feeds can be configured.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this content pack will be created.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
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
        /// <returns>A pageable asynchronous sequence of <see cref="FeedPack"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFeedPacksResponse, FeedPack> ListFeedPacksAsync(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeedPacksRequest request = new ListFeedPacksRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFeedPacksAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a feed pack.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FeedPack GetFeedPack(GetFeedPackRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a feed pack.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeedPack> GetFeedPackAsync(GetFeedPackRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a feed pack.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeedPack> GetFeedPackAsync(GetFeedPackRequest request, st::CancellationToken cancellationToken) =>
            GetFeedPackAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a feed pack.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the feed pack to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feedPacks/{feedPack}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FeedPack GetFeedPack(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeedPack(new GetFeedPackRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a feed pack.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the feed pack to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feedPacks/{feedPack}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeedPack> GetFeedPackAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeedPackAsync(new GetFeedPackRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a feed pack.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the feed pack to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feedPacks/{feedPack}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeedPack> GetFeedPackAsync(string name, st::CancellationToken cancellationToken) =>
            GetFeedPackAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a feed pack.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the feed pack to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feedPacks/{feedPack}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FeedPack GetFeedPack(FeedPackName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeedPack(new GetFeedPackRequest
            {
                FeedPackName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a feed pack.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the feed pack to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feedPacks/{feedPack}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeedPack> GetFeedPackAsync(FeedPackName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeedPackAsync(new GetFeedPackRequest
            {
                FeedPackName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a feed pack.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the feed pack to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feedPacks/{feedPack}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FeedPack> GetFeedPackAsync(FeedPackName name, st::CancellationToken cancellationToken) =>
            GetFeedPackAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the full feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Feed UpdateFeed(UpdateFeedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the full feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> UpdateFeedAsync(UpdateFeedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the full feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> UpdateFeedAsync(UpdateFeedRequest request, st::CancellationToken cancellationToken) =>
            UpdateFeedAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the full feed.
        /// </summary>
        /// <param name="feed">
        /// Required. Feed to update. Updates full feed object.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Specifies which fields to update. If empty, update the full feed.
        /// To update the display name, pass only `displayName` and no other
        /// fields. To update other fields, pass a comma-separated list of fields to
        /// update and omit `displayName`. The update fails if an existing
        /// `displayName` is sent in the update request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Feed UpdateFeed(Feed feed, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFeed(new UpdateFeedRequest
            {
                Feed = gax::GaxPreconditions.CheckNotNull(feed, nameof(feed)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the full feed.
        /// </summary>
        /// <param name="feed">
        /// Required. Feed to update. Updates full feed object.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Specifies which fields to update. If empty, update the full feed.
        /// To update the display name, pass only `displayName` and no other
        /// fields. To update other fields, pass a comma-separated list of fields to
        /// update and omit `displayName`. The update fails if an existing
        /// `displayName` is sent in the update request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> UpdateFeedAsync(Feed feed, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFeedAsync(new UpdateFeedRequest
            {
                Feed = gax::GaxPreconditions.CheckNotNull(feed, nameof(feed)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the full feed.
        /// </summary>
        /// <param name="feed">
        /// Required. Feed to update. Updates full feed object.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Specifies which fields to update. If empty, update the full feed.
        /// To update the display name, pass only `displayName` and no other
        /// fields. To update other fields, pass a comma-separated list of fields to
        /// update and omit `displayName`. The update fails if an existing
        /// `displayName` is sent in the update request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> UpdateFeedAsync(Feed feed, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateFeedAsync(feed, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List all FeedSourceTypeSchemas.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FeedSourceTypeSchema"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFeedSourceTypeSchemasResponse, FeedSourceTypeSchema> ListFeedSourceTypeSchemas(ListFeedSourceTypeSchemasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all FeedSourceTypeSchemas.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FeedSourceTypeSchema"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFeedSourceTypeSchemasResponse, FeedSourceTypeSchema> ListFeedSourceTypeSchemasAsync(ListFeedSourceTypeSchemasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all FeedSourceTypeSchemas.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of FeedSourceTypeSchemas.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
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
        /// <returns>A pageable sequence of <see cref="FeedSourceTypeSchema"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFeedSourceTypeSchemasResponse, FeedSourceTypeSchema> ListFeedSourceTypeSchemas(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeedSourceTypeSchemasRequest request = new ListFeedSourceTypeSchemasRequest
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
            return ListFeedSourceTypeSchemas(request, callSettings);
        }

        /// <summary>
        /// List all FeedSourceTypeSchemas.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of FeedSourceTypeSchemas.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
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
        /// <returns>A pageable asynchronous sequence of <see cref="FeedSourceTypeSchema"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFeedSourceTypeSchemasResponse, FeedSourceTypeSchema> ListFeedSourceTypeSchemasAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeedSourceTypeSchemasRequest request = new ListFeedSourceTypeSchemasRequest
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
            return ListFeedSourceTypeSchemasAsync(request, callSettings);
        }

        /// <summary>
        /// List all FeedSourceTypeSchemas.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of FeedSourceTypeSchemas.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
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
        /// <returns>A pageable sequence of <see cref="FeedSourceTypeSchema"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFeedSourceTypeSchemasResponse, FeedSourceTypeSchema> ListFeedSourceTypeSchemas(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeedSourceTypeSchemasRequest request = new ListFeedSourceTypeSchemasRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFeedSourceTypeSchemas(request, callSettings);
        }

        /// <summary>
        /// List all FeedSourceTypeSchemas.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of FeedSourceTypeSchemas.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
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
        /// <returns>A pageable asynchronous sequence of <see cref="FeedSourceTypeSchema"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFeedSourceTypeSchemasResponse, FeedSourceTypeSchema> ListFeedSourceTypeSchemasAsync(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFeedSourceTypeSchemasRequest request = new ListFeedSourceTypeSchemasRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFeedSourceTypeSchemasAsync(request, callSettings);
        }

        /// <summary>
        /// List all LogTypeSchemas compatible with a given
        /// FeedSourceType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LogTypeSchema"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLogTypeSchemasResponse, LogTypeSchema> ListLogTypeSchemas(ListLogTypeSchemasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all LogTypeSchemas compatible with a given
        /// FeedSourceType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LogTypeSchema"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLogTypeSchemasResponse, LogTypeSchema> ListLogTypeSchemasAsync(ListLogTypeSchemasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all LogTypeSchemas compatible with a given
        /// FeedSourceType.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of LogTypeSchemas.
        /// Format: Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feedSourceTypeSchemas/{feed_source_type}
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
        /// <returns>A pageable sequence of <see cref="LogTypeSchema"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLogTypeSchemasResponse, LogTypeSchema> ListLogTypeSchemas(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLogTypeSchemasRequest request = new ListLogTypeSchemasRequest
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
            return ListLogTypeSchemas(request, callSettings);
        }

        /// <summary>
        /// List all LogTypeSchemas compatible with a given
        /// FeedSourceType.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of LogTypeSchemas.
        /// Format: Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feedSourceTypeSchemas/{feed_source_type}
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
        /// <returns>A pageable asynchronous sequence of <see cref="LogTypeSchema"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLogTypeSchemasResponse, LogTypeSchema> ListLogTypeSchemasAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLogTypeSchemasRequest request = new ListLogTypeSchemasRequest
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
            return ListLogTypeSchemasAsync(request, callSettings);
        }

        /// <summary>
        /// List all LogTypeSchemas compatible with a given
        /// FeedSourceType.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of LogTypeSchemas.
        /// Format: Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feedSourceTypeSchemas/{feed_source_type}
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
        /// <returns>A pageable sequence of <see cref="LogTypeSchema"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLogTypeSchemasResponse, LogTypeSchema> ListLogTypeSchemas(FeedSourceTypeSchemaName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLogTypeSchemasRequest request = new ListLogTypeSchemasRequest
            {
                ParentAsFeedSourceTypeSchemaName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListLogTypeSchemas(request, callSettings);
        }

        /// <summary>
        /// List all LogTypeSchemas compatible with a given
        /// FeedSourceType.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of LogTypeSchemas.
        /// Format: Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feedSourceTypeSchemas/{feed_source_type}
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
        /// <returns>A pageable asynchronous sequence of <see cref="LogTypeSchema"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLogTypeSchemasResponse, LogTypeSchema> ListLogTypeSchemasAsync(FeedSourceTypeSchemaName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLogTypeSchemasRequest request = new ListLogTypeSchemasRequest
            {
                ParentAsFeedSourceTypeSchemaName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListLogTypeSchemasAsync(request, callSettings);
        }

        /// <summary>
        /// Import logs coming from https push feeds.
        /// All log entries must be valid UTF-8. A single invalid event will cause the
        /// entire request to be rejected.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ga::HttpBody ImportPushLogs(ImportPushLogsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Import logs coming from https push feeds.
        /// All log entries must be valid UTF-8. A single invalid event will cause the
        /// entire request to be rejected.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> ImportPushLogsAsync(ImportPushLogsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Import logs coming from https push feeds.
        /// All log entries must be valid UTF-8. A single invalid event will cause the
        /// entire request to be rejected.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> ImportPushLogsAsync(ImportPushLogsRequest request, st::CancellationToken cancellationToken) =>
            ImportPushLogsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Import logs coming from https push feeds.
        /// All log entries must be valid UTF-8. A single invalid event will cause the
        /// entire request to be rejected.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of logs.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ga::HttpBody ImportPushLogs(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ImportPushLogs(new ImportPushLogsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Import logs coming from https push feeds.
        /// All log entries must be valid UTF-8. A single invalid event will cause the
        /// entire request to be rejected.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of logs.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> ImportPushLogsAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ImportPushLogsAsync(new ImportPushLogsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Import logs coming from https push feeds.
        /// All log entries must be valid UTF-8. A single invalid event will cause the
        /// entire request to be rejected.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of logs.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> ImportPushLogsAsync(string parent, st::CancellationToken cancellationToken) =>
            ImportPushLogsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Import logs coming from https push feeds.
        /// All log entries must be valid UTF-8. A single invalid event will cause the
        /// entire request to be rejected.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of logs.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ga::HttpBody ImportPushLogs(FeedName parent, gaxgrpc::CallSettings callSettings = null) =>
            ImportPushLogs(new ImportPushLogsRequest
            {
                ParentAsFeedName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Import logs coming from https push feeds.
        /// All log entries must be valid UTF-8. A single invalid event will cause the
        /// entire request to be rejected.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of logs.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> ImportPushLogsAsync(FeedName parent, gaxgrpc::CallSettings callSettings = null) =>
            ImportPushLogsAsync(new ImportPushLogsRequest
            {
                ParentAsFeedName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Import logs coming from https push feeds.
        /// All log entries must be valid UTF-8. A single invalid event will cause the
        /// entire request to be rejected.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of logs.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> ImportPushLogsAsync(FeedName parent, st::CancellationToken cancellationToken) =>
            ImportPushLogsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates a new secret for https push feeds which do not support jwt
        /// tokens. Secrets once generated should be copied and stored in safe place
        /// to be used while configuring https push feeds.Please note that you can
        /// always generate a new secret again for a feed using this API but it will
        /// invalidate the previously generated secret for the feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateSecretResponse GenerateSecret(GenerateSecretRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates a new secret for https push feeds which do not support jwt
        /// tokens. Secrets once generated should be copied and stored in safe place
        /// to be used while configuring https push feeds.Please note that you can
        /// always generate a new secret again for a feed using this API but it will
        /// invalidate the previously generated secret for the feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateSecretResponse> GenerateSecretAsync(GenerateSecretRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates a new secret for https push feeds which do not support jwt
        /// tokens. Secrets once generated should be copied and stored in safe place
        /// to be used while configuring https push feeds.Please note that you can
        /// always generate a new secret again for a feed using this API but it will
        /// invalidate the previously generated secret for the feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateSecretResponse> GenerateSecretAsync(GenerateSecretRequest request, st::CancellationToken cancellationToken) =>
            GenerateSecretAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates a new secret for https push feeds which do not support jwt
        /// tokens. Secrets once generated should be copied and stored in safe place
        /// to be used while configuring https push feeds.Please note that you can
        /// always generate a new secret again for a feed using this API but it will
        /// invalidate the previously generated secret for the feed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feed to for which to generate secret.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateSecretResponse GenerateSecret(string name, gaxgrpc::CallSettings callSettings = null) =>
            GenerateSecret(new GenerateSecretRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Generates a new secret for https push feeds which do not support jwt
        /// tokens. Secrets once generated should be copied and stored in safe place
        /// to be used while configuring https push feeds.Please note that you can
        /// always generate a new secret again for a feed using this API but it will
        /// invalidate the previously generated secret for the feed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feed to for which to generate secret.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateSecretResponse> GenerateSecretAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GenerateSecretAsync(new GenerateSecretRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Generates a new secret for https push feeds which do not support jwt
        /// tokens. Secrets once generated should be copied and stored in safe place
        /// to be used while configuring https push feeds.Please note that you can
        /// always generate a new secret again for a feed using this API but it will
        /// invalidate the previously generated secret for the feed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feed to for which to generate secret.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateSecretResponse> GenerateSecretAsync(string name, st::CancellationToken cancellationToken) =>
            GenerateSecretAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates a new secret for https push feeds which do not support jwt
        /// tokens. Secrets once generated should be copied and stored in safe place
        /// to be used while configuring https push feeds.Please note that you can
        /// always generate a new secret again for a feed using this API but it will
        /// invalidate the previously generated secret for the feed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feed to for which to generate secret.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateSecretResponse GenerateSecret(FeedName name, gaxgrpc::CallSettings callSettings = null) =>
            GenerateSecret(new GenerateSecretRequest
            {
                FeedName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Generates a new secret for https push feeds which do not support jwt
        /// tokens. Secrets once generated should be copied and stored in safe place
        /// to be used while configuring https push feeds.Please note that you can
        /// always generate a new secret again for a feed using this API but it will
        /// invalidate the previously generated secret for the feed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feed to for which to generate secret.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateSecretResponse> GenerateSecretAsync(FeedName name, gaxgrpc::CallSettings callSettings = null) =>
            GenerateSecretAsync(new GenerateSecretRequest
            {
                FeedName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Generates a new secret for https push feeds which do not support jwt
        /// tokens. Secrets once generated should be copied and stored in safe place
        /// to be used while configuring https push feeds.Please note that you can
        /// always generate a new secret again for a feed using this API but it will
        /// invalidate the previously generated secret for the feed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feed to for which to generate secret.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateSecretResponse> GenerateSecretAsync(FeedName name, st::CancellationToken cancellationToken) =>
            GenerateSecretAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>FeedsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// FeedsService contains procedures for managing Chronicle third-party feeds.
    /// </remarks>
    public sealed partial class FeedsServiceClientImpl : FeedsServiceClient
    {
        private readonly gaxgrpc::ApiCall<FetchServiceAccountForCustomerRequest, FeedServiceAccount> _callFetchServiceAccountForCustomer;

        private readonly gaxgrpc::ApiCall<CreateFeedRequest, Feed> _callCreateFeed;

        private readonly gaxgrpc::ApiCall<GetFeedRequest, Feed> _callGetFeed;

        private readonly gaxgrpc::ApiCall<DeleteFeedRequest, wkt::Empty> _callDeleteFeed;

        private readonly gaxgrpc::ApiCall<EnableFeedRequest, Feed> _callEnableFeed;

        private readonly gaxgrpc::ApiCall<DisableFeedRequest, Feed> _callDisableFeed;

        private readonly gaxgrpc::ApiCall<ListFeedsRequest, ListFeedsResponse> _callListFeeds;

        private readonly gaxgrpc::ApiCall<ListFeedPacksRequest, ListFeedPacksResponse> _callListFeedPacks;

        private readonly gaxgrpc::ApiCall<GetFeedPackRequest, FeedPack> _callGetFeedPack;

        private readonly gaxgrpc::ApiCall<UpdateFeedRequest, Feed> _callUpdateFeed;

        private readonly gaxgrpc::ApiCall<ListFeedSourceTypeSchemasRequest, ListFeedSourceTypeSchemasResponse> _callListFeedSourceTypeSchemas;

        private readonly gaxgrpc::ApiCall<ListLogTypeSchemasRequest, ListLogTypeSchemasResponse> _callListLogTypeSchemas;

        private readonly gaxgrpc::ApiCall<ImportPushLogsRequest, ga::HttpBody> _callImportPushLogs;

        private readonly gaxgrpc::ApiCall<GenerateSecretRequest, GenerateSecretResponse> _callGenerateSecret;

        /// <summary>
        /// Constructs a client wrapper for the FeedsService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="FeedsServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public FeedsServiceClientImpl(FeedsService.FeedsServiceClient grpcClient, FeedsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            FeedsServiceSettings effectiveSettings = settings ?? FeedsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callFetchServiceAccountForCustomer = clientHelper.BuildApiCall<FetchServiceAccountForCustomerRequest, FeedServiceAccount>("FetchServiceAccountForCustomer", grpcClient.FetchServiceAccountForCustomerAsync, grpcClient.FetchServiceAccountForCustomer, effectiveSettings.FetchServiceAccountForCustomerSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callFetchServiceAccountForCustomer);
            Modify_FetchServiceAccountForCustomerApiCall(ref _callFetchServiceAccountForCustomer);
            _callCreateFeed = clientHelper.BuildApiCall<CreateFeedRequest, Feed>("CreateFeed", grpcClient.CreateFeedAsync, grpcClient.CreateFeed, effectiveSettings.CreateFeedSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateFeed);
            Modify_CreateFeedApiCall(ref _callCreateFeed);
            _callGetFeed = clientHelper.BuildApiCall<GetFeedRequest, Feed>("GetFeed", grpcClient.GetFeedAsync, grpcClient.GetFeed, effectiveSettings.GetFeedSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetFeed);
            Modify_GetFeedApiCall(ref _callGetFeed);
            _callDeleteFeed = clientHelper.BuildApiCall<DeleteFeedRequest, wkt::Empty>("DeleteFeed", grpcClient.DeleteFeedAsync, grpcClient.DeleteFeed, effectiveSettings.DeleteFeedSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteFeed);
            Modify_DeleteFeedApiCall(ref _callDeleteFeed);
            _callEnableFeed = clientHelper.BuildApiCall<EnableFeedRequest, Feed>("EnableFeed", grpcClient.EnableFeedAsync, grpcClient.EnableFeed, effectiveSettings.EnableFeedSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callEnableFeed);
            Modify_EnableFeedApiCall(ref _callEnableFeed);
            _callDisableFeed = clientHelper.BuildApiCall<DisableFeedRequest, Feed>("DisableFeed", grpcClient.DisableFeedAsync, grpcClient.DisableFeed, effectiveSettings.DisableFeedSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDisableFeed);
            Modify_DisableFeedApiCall(ref _callDisableFeed);
            _callListFeeds = clientHelper.BuildApiCall<ListFeedsRequest, ListFeedsResponse>("ListFeeds", grpcClient.ListFeedsAsync, grpcClient.ListFeeds, effectiveSettings.ListFeedsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListFeeds);
            Modify_ListFeedsApiCall(ref _callListFeeds);
            _callListFeedPacks = clientHelper.BuildApiCall<ListFeedPacksRequest, ListFeedPacksResponse>("ListFeedPacks", grpcClient.ListFeedPacksAsync, grpcClient.ListFeedPacks, effectiveSettings.ListFeedPacksSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListFeedPacks);
            Modify_ListFeedPacksApiCall(ref _callListFeedPacks);
            _callGetFeedPack = clientHelper.BuildApiCall<GetFeedPackRequest, FeedPack>("GetFeedPack", grpcClient.GetFeedPackAsync, grpcClient.GetFeedPack, effectiveSettings.GetFeedPackSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetFeedPack);
            Modify_GetFeedPackApiCall(ref _callGetFeedPack);
            _callUpdateFeed = clientHelper.BuildApiCall<UpdateFeedRequest, Feed>("UpdateFeed", grpcClient.UpdateFeedAsync, grpcClient.UpdateFeed, effectiveSettings.UpdateFeedSettings).WithGoogleRequestParam("feed.name", request => request.Feed?.Name);
            Modify_ApiCall(ref _callUpdateFeed);
            Modify_UpdateFeedApiCall(ref _callUpdateFeed);
            _callListFeedSourceTypeSchemas = clientHelper.BuildApiCall<ListFeedSourceTypeSchemasRequest, ListFeedSourceTypeSchemasResponse>("ListFeedSourceTypeSchemas", grpcClient.ListFeedSourceTypeSchemasAsync, grpcClient.ListFeedSourceTypeSchemas, effectiveSettings.ListFeedSourceTypeSchemasSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListFeedSourceTypeSchemas);
            Modify_ListFeedSourceTypeSchemasApiCall(ref _callListFeedSourceTypeSchemas);
            _callListLogTypeSchemas = clientHelper.BuildApiCall<ListLogTypeSchemasRequest, ListLogTypeSchemasResponse>("ListLogTypeSchemas", grpcClient.ListLogTypeSchemasAsync, grpcClient.ListLogTypeSchemas, effectiveSettings.ListLogTypeSchemasSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListLogTypeSchemas);
            Modify_ListLogTypeSchemasApiCall(ref _callListLogTypeSchemas);
            _callImportPushLogs = clientHelper.BuildApiCall<ImportPushLogsRequest, ga::HttpBody>("ImportPushLogs", grpcClient.ImportPushLogsAsync, grpcClient.ImportPushLogs, effectiveSettings.ImportPushLogsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callImportPushLogs);
            Modify_ImportPushLogsApiCall(ref _callImportPushLogs);
            _callGenerateSecret = clientHelper.BuildApiCall<GenerateSecretRequest, GenerateSecretResponse>("GenerateSecret", grpcClient.GenerateSecretAsync, grpcClient.GenerateSecret, effectiveSettings.GenerateSecretSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGenerateSecret);
            Modify_GenerateSecretApiCall(ref _callGenerateSecret);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_FetchServiceAccountForCustomerApiCall(ref gaxgrpc::ApiCall<FetchServiceAccountForCustomerRequest, FeedServiceAccount> call);

        partial void Modify_CreateFeedApiCall(ref gaxgrpc::ApiCall<CreateFeedRequest, Feed> call);

        partial void Modify_GetFeedApiCall(ref gaxgrpc::ApiCall<GetFeedRequest, Feed> call);

        partial void Modify_DeleteFeedApiCall(ref gaxgrpc::ApiCall<DeleteFeedRequest, wkt::Empty> call);

        partial void Modify_EnableFeedApiCall(ref gaxgrpc::ApiCall<EnableFeedRequest, Feed> call);

        partial void Modify_DisableFeedApiCall(ref gaxgrpc::ApiCall<DisableFeedRequest, Feed> call);

        partial void Modify_ListFeedsApiCall(ref gaxgrpc::ApiCall<ListFeedsRequest, ListFeedsResponse> call);

        partial void Modify_ListFeedPacksApiCall(ref gaxgrpc::ApiCall<ListFeedPacksRequest, ListFeedPacksResponse> call);

        partial void Modify_GetFeedPackApiCall(ref gaxgrpc::ApiCall<GetFeedPackRequest, FeedPack> call);

        partial void Modify_UpdateFeedApiCall(ref gaxgrpc::ApiCall<UpdateFeedRequest, Feed> call);

        partial void Modify_ListFeedSourceTypeSchemasApiCall(ref gaxgrpc::ApiCall<ListFeedSourceTypeSchemasRequest, ListFeedSourceTypeSchemasResponse> call);

        partial void Modify_ListLogTypeSchemasApiCall(ref gaxgrpc::ApiCall<ListLogTypeSchemasRequest, ListLogTypeSchemasResponse> call);

        partial void Modify_ImportPushLogsApiCall(ref gaxgrpc::ApiCall<ImportPushLogsRequest, ga::HttpBody> call);

        partial void Modify_GenerateSecretApiCall(ref gaxgrpc::ApiCall<GenerateSecretRequest, GenerateSecretResponse> call);

        partial void OnConstruction(FeedsService.FeedsServiceClient grpcClient, FeedsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC FeedsService client</summary>
        public override FeedsService.FeedsServiceClient GrpcClient { get; }

        partial void Modify_FetchServiceAccountForCustomerRequest(ref FetchServiceAccountForCustomerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateFeedRequest(ref CreateFeedRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetFeedRequest(ref GetFeedRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteFeedRequest(ref DeleteFeedRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_EnableFeedRequest(ref EnableFeedRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DisableFeedRequest(ref DisableFeedRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListFeedsRequest(ref ListFeedsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListFeedPacksRequest(ref ListFeedPacksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetFeedPackRequest(ref GetFeedPackRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateFeedRequest(ref UpdateFeedRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListFeedSourceTypeSchemasRequest(ref ListFeedSourceTypeSchemasRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListLogTypeSchemasRequest(ref ListLogTypeSchemasRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportPushLogsRequest(ref ImportPushLogsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateSecretRequest(ref GenerateSecretRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Fetch Chronicle's service account used for ingesting data from Cloud
        /// Storage buckets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FeedServiceAccount FetchServiceAccountForCustomer(FetchServiceAccountForCustomerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchServiceAccountForCustomerRequest(ref request, ref callSettings);
            return _callFetchServiceAccountForCustomer.Sync(request, callSettings);
        }

        /// <summary>
        /// Fetch Chronicle's service account used for ingesting data from Cloud
        /// Storage buckets.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FeedServiceAccount> FetchServiceAccountForCustomerAsync(FetchServiceAccountForCustomerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchServiceAccountForCustomerRequest(ref request, ref callSettings);
            return _callFetchServiceAccountForCustomer.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Feed CreateFeed(CreateFeedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFeedRequest(ref request, ref callSettings);
            return _callCreateFeed.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Feed> CreateFeedAsync(CreateFeedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFeedRequest(ref request, ref callSettings);
            return _callCreateFeed.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Feed GetFeed(GetFeedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFeedRequest(ref request, ref callSettings);
            return _callGetFeed.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Feed> GetFeedAsync(GetFeedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFeedRequest(ref request, ref callSettings);
            return _callGetFeed.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteFeed(DeleteFeedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFeedRequest(ref request, ref callSettings);
            _callDeleteFeed.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteFeedAsync(DeleteFeedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFeedRequest(ref request, ref callSettings);
            return _callDeleteFeed.Async(request, callSettings);
        }

        /// <summary>
        /// Enable feed for ingestion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Feed EnableFeed(EnableFeedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnableFeedRequest(ref request, ref callSettings);
            return _callEnableFeed.Sync(request, callSettings);
        }

        /// <summary>
        /// Enable feed for ingestion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Feed> EnableFeedAsync(EnableFeedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnableFeedRequest(ref request, ref callSettings);
            return _callEnableFeed.Async(request, callSettings);
        }

        /// <summary>
        /// Disable feed for ingestion. Make FeedState ARCHIVED.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Feed DisableFeed(DisableFeedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DisableFeedRequest(ref request, ref callSettings);
            return _callDisableFeed.Sync(request, callSettings);
        }

        /// <summary>
        /// Disable feed for ingestion. Make FeedState ARCHIVED.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Feed> DisableFeedAsync(DisableFeedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DisableFeedRequest(ref request, ref callSettings);
            return _callDisableFeed.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all feeds for the customer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Feed"/> resources.</returns>
        public override gax::PagedEnumerable<ListFeedsResponse, Feed> ListFeeds(ListFeedsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFeedsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListFeedsRequest, ListFeedsResponse, Feed>(_callListFeeds, request, callSettings);
        }

        /// <summary>
        /// Lists all feeds for the customer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Feed"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListFeedsResponse, Feed> ListFeedsAsync(ListFeedsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFeedsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListFeedsRequest, ListFeedsResponse, Feed>(_callListFeeds, request, callSettings);
        }

        /// <summary>
        /// Lists Packs for which feeds can be configured.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FeedPack"/> resources.</returns>
        public override gax::PagedEnumerable<ListFeedPacksResponse, FeedPack> ListFeedPacks(ListFeedPacksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFeedPacksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListFeedPacksRequest, ListFeedPacksResponse, FeedPack>(_callListFeedPacks, request, callSettings);
        }

        /// <summary>
        /// Lists Packs for which feeds can be configured.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FeedPack"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListFeedPacksResponse, FeedPack> ListFeedPacksAsync(ListFeedPacksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFeedPacksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListFeedPacksRequest, ListFeedPacksResponse, FeedPack>(_callListFeedPacks, request, callSettings);
        }

        /// <summary>
        /// Gets a feed pack.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FeedPack GetFeedPack(GetFeedPackRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFeedPackRequest(ref request, ref callSettings);
            return _callGetFeedPack.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a feed pack.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FeedPack> GetFeedPackAsync(GetFeedPackRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFeedPackRequest(ref request, ref callSettings);
            return _callGetFeedPack.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the full feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Feed UpdateFeed(UpdateFeedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFeedRequest(ref request, ref callSettings);
            return _callUpdateFeed.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the full feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Feed> UpdateFeedAsync(UpdateFeedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFeedRequest(ref request, ref callSettings);
            return _callUpdateFeed.Async(request, callSettings);
        }

        /// <summary>
        /// List all FeedSourceTypeSchemas.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FeedSourceTypeSchema"/> resources.</returns>
        public override gax::PagedEnumerable<ListFeedSourceTypeSchemasResponse, FeedSourceTypeSchema> ListFeedSourceTypeSchemas(ListFeedSourceTypeSchemasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFeedSourceTypeSchemasRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListFeedSourceTypeSchemasRequest, ListFeedSourceTypeSchemasResponse, FeedSourceTypeSchema>(_callListFeedSourceTypeSchemas, request, callSettings);
        }

        /// <summary>
        /// List all FeedSourceTypeSchemas.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FeedSourceTypeSchema"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListFeedSourceTypeSchemasResponse, FeedSourceTypeSchema> ListFeedSourceTypeSchemasAsync(ListFeedSourceTypeSchemasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFeedSourceTypeSchemasRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListFeedSourceTypeSchemasRequest, ListFeedSourceTypeSchemasResponse, FeedSourceTypeSchema>(_callListFeedSourceTypeSchemas, request, callSettings);
        }

        /// <summary>
        /// List all LogTypeSchemas compatible with a given
        /// FeedSourceType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LogTypeSchema"/> resources.</returns>
        public override gax::PagedEnumerable<ListLogTypeSchemasResponse, LogTypeSchema> ListLogTypeSchemas(ListLogTypeSchemasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLogTypeSchemasRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListLogTypeSchemasRequest, ListLogTypeSchemasResponse, LogTypeSchema>(_callListLogTypeSchemas, request, callSettings);
        }

        /// <summary>
        /// List all LogTypeSchemas compatible with a given
        /// FeedSourceType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LogTypeSchema"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListLogTypeSchemasResponse, LogTypeSchema> ListLogTypeSchemasAsync(ListLogTypeSchemasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLogTypeSchemasRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListLogTypeSchemasRequest, ListLogTypeSchemasResponse, LogTypeSchema>(_callListLogTypeSchemas, request, callSettings);
        }

        /// <summary>
        /// Import logs coming from https push feeds.
        /// All log entries must be valid UTF-8. A single invalid event will cause the
        /// entire request to be rejected.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ga::HttpBody ImportPushLogs(ImportPushLogsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportPushLogsRequest(ref request, ref callSettings);
            return _callImportPushLogs.Sync(request, callSettings);
        }

        /// <summary>
        /// Import logs coming from https push feeds.
        /// All log entries must be valid UTF-8. A single invalid event will cause the
        /// entire request to be rejected.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ga::HttpBody> ImportPushLogsAsync(ImportPushLogsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportPushLogsRequest(ref request, ref callSettings);
            return _callImportPushLogs.Async(request, callSettings);
        }

        /// <summary>
        /// Generates a new secret for https push feeds which do not support jwt
        /// tokens. Secrets once generated should be copied and stored in safe place
        /// to be used while configuring https push feeds.Please note that you can
        /// always generate a new secret again for a feed using this API but it will
        /// invalidate the previously generated secret for the feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateSecretResponse GenerateSecret(GenerateSecretRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateSecretRequest(ref request, ref callSettings);
            return _callGenerateSecret.Sync(request, callSettings);
        }

        /// <summary>
        /// Generates a new secret for https push feeds which do not support jwt
        /// tokens. Secrets once generated should be copied and stored in safe place
        /// to be used while configuring https push feeds.Please note that you can
        /// always generate a new secret again for a feed using this API but it will
        /// invalidate the previously generated secret for the feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateSecretResponse> GenerateSecretAsync(GenerateSecretRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateSecretRequest(ref request, ref callSettings);
            return _callGenerateSecret.Async(request, callSettings);
        }
    }

    public partial class ListFeedsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListFeedPacksRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListFeedSourceTypeSchemasRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListLogTypeSchemasRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListFeedsResponse : gaxgrpc::IPageResponse<Feed>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Feed> GetEnumerator() => Feeds.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListFeedPacksResponse : gaxgrpc::IPageResponse<FeedPack>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<FeedPack> GetEnumerator() => FeedPacks.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListFeedSourceTypeSchemasResponse : gaxgrpc::IPageResponse<FeedSourceTypeSchema>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<FeedSourceTypeSchema> GetEnumerator() => FeedSourceTypeSchemas.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListLogTypeSchemasResponse : gaxgrpc::IPageResponse<LogTypeSchema>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<LogTypeSchema> GetEnumerator() => LogTypeSchemas.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
