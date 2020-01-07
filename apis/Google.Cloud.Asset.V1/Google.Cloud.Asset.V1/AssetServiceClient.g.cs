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
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using sysnet = System.Net;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Asset.V1
{
    /// <summary>Settings for <see cref="AssetServiceClient"/> instances.</summary>
    public sealed partial class AssetServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AssetServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AssetServiceSettings"/>.</returns>
        public static AssetServiceSettings GetDefault() => new AssetServiceSettings();

        /// <summary>Constructs a new <see cref="AssetServiceSettings"/> object with default settings.</summary>
        public AssetServiceSettings()
        {
        }

        private AssetServiceSettings(AssetServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ExportAssetsSettings = existing.ExportAssetsSettings;
            ExportAssetsOperationsSettings = existing.ExportAssetsOperationsSettings.Clone();
            BatchGetAssetsHistorySettings = existing.BatchGetAssetsHistorySettings;
            CreateFeedSettings = existing.CreateFeedSettings;
            GetFeedSettings = existing.GetFeedSettings;
            ListFeedsSettings = existing.ListFeedsSettings;
            UpdateFeedSettings = existing.UpdateFeedSettings;
            DeleteFeedSettings = existing.DeleteFeedSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AssetServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssetServiceClient.ExportAssets</c> and <c>AssetServiceClient.ExportAssetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExportAssetsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>AssetServiceClient.ExportAssets</c> and
        /// <c>AssetServiceClient.ExportAssetsAsync</c>.
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
        public lro::OperationsSettings ExportAssetsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssetServiceClient.BatchGetAssetsHistory</c> and <c>AssetServiceClient.BatchGetAssetsHistoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchGetAssetsHistorySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssetServiceClient.CreateFeed</c> and <c>AssetServiceClient.CreateFeedAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateFeedSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AssetServiceClient.GetFeed</c>
        ///  and <c>AssetServiceClient.GetFeedAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetFeedSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssetServiceClient.ListFeeds</c> and <c>AssetServiceClient.ListFeedsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListFeedsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssetServiceClient.UpdateFeed</c> and <c>AssetServiceClient.UpdateFeedAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateFeedSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssetServiceClient.DeleteFeed</c> and <c>AssetServiceClient.DeleteFeedAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteFeedSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AssetServiceSettings"/> object.</returns>
        public AssetServiceSettings Clone() => new AssetServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AssetServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class AssetServiceClientBuilder : gaxgrpc::ClientBuilderBase<AssetServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AssetServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override AssetServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AssetServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc/>
        public override async stt::Task<AssetServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AssetServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc/>
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => AssetServiceClient.DefaultEndpoint;

        /// <inheritdoc/>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => AssetServiceClient.DefaultScopes;

        /// <inheritdoc/>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AssetServiceClient.ChannelPool;
    }

    /// <summary>AssetService client wrapper, for convenient use.</summary>
    public abstract partial class AssetServiceClient
    {
        /// <summary>
        /// The default endpoint for the AssetService service, which is a host of "cloudasset.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("cloudasset.googleapis.com", 443);

        /// <summary>The default AssetService scopes.</summary>
        /// <remarks>
        /// The default AssetService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="AssetServiceClient"/>, applying defaults for all unspecified settings, 
        /// and creating a channel connecting to the given endpoint with application default credentials where 
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ImageAnnotatorClient client = await ImageAnnotatorClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ImageAnnotatorClient.DefaultEndpoint.Host, ImageAnnotatorClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ImageAnnotatorClient client = ImageAnnotatorClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="AssetServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="AssetServiceClient"/>.</returns>
        public static async stt::Task<AssetServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, AssetServiceSettings settings = null)
        {
            grpccore::Channel channel = await ChannelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="AssetServiceClient"/>, applying defaults for all unspecified settings, 
        /// and creating a channel connecting to the given endpoint with application default credentials where 
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ImageAnnotatorClient client = ImageAnnotatorClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ImageAnnotatorClient.DefaultEndpoint.Host, ImageAnnotatorClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ImageAnnotatorClient client = ImageAnnotatorClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="AssetServiceSettings"/>.</param>
        /// <returns>The created <see cref="AssetServiceClient"/>.</returns>
        public static AssetServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, AssetServiceSettings settings = null)
        {
            grpccore::Channel channel = ChannelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="AssetServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="AssetServiceSettings"/>.</param>
        /// <returns>The created <see cref="AssetServiceClient"/>.</returns>
        public static AssetServiceClient Create(grpccore::Channel channel, AssetServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="AssetServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AssetServiceSettings"/>.</param>
        /// <returns>The created <see cref="AssetServiceClient"/>.</returns>
        public static AssetServiceClient Create(grpccore::CallInvoker callInvoker, AssetServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AssetService.AssetServiceClient grpcClient = new AssetService.AssetServiceClient(callInvoker);
            return new AssetServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by
        /// <see cref="Create(grpccore::CallInvoker,AssetServiceSettings)"/> and
        /// <see cref="CreateAsync(gaxgrpc::ServiceEndpoint,AssetServiceSettings)"/>. Channels which weren't
        /// automatically created are not affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create(grpccore::CallInvoker,AssetServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint,AssetServiceSettings)"/> will create new channels, which
        /// could in turn be shut down by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC AssetService client</summary>
        public virtual AssetService.AssetServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Exports assets with time and resource types to a given Cloud Storage
        /// location. The output format is newline-delimited JSON.
        /// This API implements the [google.longrunning.Operation][google.longrunning.Operation] API allowing you
        /// to keep track of the export.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportAssetsResponse, ExportAssetsRequest> ExportAssets(ExportAssetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports assets with time and resource types to a given Cloud Storage
        /// location. The output format is newline-delimited JSON.
        /// This API implements the [google.longrunning.Operation][google.longrunning.Operation] API allowing you
        /// to keep track of the export.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportAssetsResponse, ExportAssetsRequest>> ExportAssetsAsync(ExportAssetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports assets with time and resource types to a given Cloud Storage
        /// location. The output format is newline-delimited JSON.
        /// This API implements the [google.longrunning.Operation][google.longrunning.Operation] API allowing you
        /// to keep track of the export.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportAssetsResponse, ExportAssetsRequest>> ExportAssetsAsync(ExportAssetsRequest request, st::CancellationToken cancellationToken) =>
            ExportAssetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExportAssets</c>.</summary>
        public virtual lro::OperationsClient ExportAssetsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ExportAssets</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ExportAssetsResponse, ExportAssetsRequest> PollOnceExportAssets(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportAssetsResponse, ExportAssetsRequest>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportAssetsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportAssets</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExportAssetsResponse, ExportAssetsRequest>> PollOnceExportAssetsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportAssetsResponse, ExportAssetsRequest>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportAssetsOperationsClient, callSettings);

        /// <summary>
        /// Batch gets the update history of assets that overlap a time window.
        /// For RESOURCE content, this API outputs history with asset in both
        /// non-delete or deleted status.
        /// For IAM_POLICY content, this API outputs history when the asset and its
        /// attached IAM POLICY both exist. This can create gaps in the output history.
        /// If a specified asset does not exist, this API returns an INVALID_ARGUMENT
        /// error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchGetAssetsHistoryResponse BatchGetAssetsHistory(BatchGetAssetsHistoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch gets the update history of assets that overlap a time window.
        /// For RESOURCE content, this API outputs history with asset in both
        /// non-delete or deleted status.
        /// For IAM_POLICY content, this API outputs history when the asset and its
        /// attached IAM POLICY both exist. This can create gaps in the output history.
        /// If a specified asset does not exist, this API returns an INVALID_ARGUMENT
        /// error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchGetAssetsHistoryResponse> BatchGetAssetsHistoryAsync(BatchGetAssetsHistoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch gets the update history of assets that overlap a time window.
        /// For RESOURCE content, this API outputs history with asset in both
        /// non-delete or deleted status.
        /// For IAM_POLICY content, this API outputs history when the asset and its
        /// attached IAM POLICY both exist. This can create gaps in the output history.
        /// If a specified asset does not exist, this API returns an INVALID_ARGUMENT
        /// error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchGetAssetsHistoryResponse> BatchGetAssetsHistoryAsync(BatchGetAssetsHistoryRequest request, st::CancellationToken cancellationToken) =>
            BatchGetAssetsHistoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a feed in a parent project/folder/organization to listen to its
        /// asset updates.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Feed CreateFeed(CreateFeedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a feed in a parent project/folder/organization to listen to its
        /// asset updates.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> CreateFeedAsync(CreateFeedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a feed in a parent project/folder/organization to listen to its
        /// asset updates.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> CreateFeedAsync(CreateFeedRequest request, st::CancellationToken cancellationToken) =>
            CreateFeedAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a feed in a parent project/folder/organization to listen to its
        /// asset updates.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project/folder/organization where this feed
        /// should be created in. It can only be an organization number (such as
        /// "organizations/123"), a folder number (such as "folders/123"), a project ID
        /// (such as "projects/my-project-id")", or a project number (such as
        /// "projects/12345").
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Feed CreateFeed(string parent, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeed(new CreateFeedRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Creates a feed in a parent project/folder/organization to listen to its
        /// asset updates.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project/folder/organization where this feed
        /// should be created in. It can only be an organization number (such as
        /// "organizations/123"), a folder number (such as "folders/123"), a project ID
        /// (such as "projects/my-project-id")", or a project number (such as
        /// "projects/12345").
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> CreateFeedAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            CreateFeedAsync(new CreateFeedRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Creates a feed in a parent project/folder/organization to listen to its
        /// asset updates.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project/folder/organization where this feed
        /// should be created in. It can only be an organization number (such as
        /// "organizations/123"), a folder number (such as "folders/123"), a project ID
        /// (such as "projects/my-project-id")", or a project number (such as
        /// "projects/12345").
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> CreateFeedAsync(string parent, st::CancellationToken cancellationToken) =>
            CreateFeedAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about an asset feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Feed GetFeed(GetFeedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about an asset feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> GetFeedAsync(GetFeedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about an asset feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> GetFeedAsync(GetFeedRequest request, st::CancellationToken cancellationToken) =>
            GetFeedAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about an asset feed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Feed and it must be in the format of:
        /// projects/project_number/feeds/feed_id
        /// folders/folder_number/feeds/feed_id
        /// organizations/organization_number/feeds/feed_id
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Feed GetFeed(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeed(new GetFeedRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about an asset feed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Feed and it must be in the format of:
        /// projects/project_number/feeds/feed_id
        /// folders/folder_number/feeds/feed_id
        /// organizations/organization_number/feeds/feed_id
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> GetFeedAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeedAsync(new GetFeedRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about an asset feed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Feed and it must be in the format of:
        /// projects/project_number/feeds/feed_id
        /// folders/folder_number/feeds/feed_id
        /// organizations/organization_number/feeds/feed_id
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> GetFeedAsync(string name, st::CancellationToken cancellationToken) =>
            GetFeedAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about an asset feed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Feed and it must be in the format of:
        /// projects/project_number/feeds/feed_id
        /// folders/folder_number/feeds/feed_id
        /// organizations/organization_number/feeds/feed_id
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Feed GetFeed(FeedName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeed(new GetFeedRequest
            {
                FeedName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about an asset feed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Feed and it must be in the format of:
        /// projects/project_number/feeds/feed_id
        /// folders/folder_number/feeds/feed_id
        /// organizations/organization_number/feeds/feed_id
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> GetFeedAsync(FeedName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFeedAsync(new GetFeedRequest
            {
                FeedName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about an asset feed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Feed and it must be in the format of:
        /// projects/project_number/feeds/feed_id
        /// folders/folder_number/feeds/feed_id
        /// organizations/organization_number/feeds/feed_id
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> GetFeedAsync(FeedName name, st::CancellationToken cancellationToken) =>
            GetFeedAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all asset feeds in a parent project/folder/organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListFeedsResponse ListFeeds(ListFeedsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all asset feeds in a parent project/folder/organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListFeedsResponse> ListFeedsAsync(ListFeedsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all asset feeds in a parent project/folder/organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListFeedsResponse> ListFeedsAsync(ListFeedsRequest request, st::CancellationToken cancellationToken) =>
            ListFeedsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all asset feeds in a parent project/folder/organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project/folder/organization whose feeds are to be
        /// listed. It can only be using project/folder/organization number (such as
        /// "folders/12345")", or a project ID (such as "projects/my-project-id").
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListFeedsResponse ListFeeds(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ListFeeds(new ListFeedsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Lists all asset feeds in a parent project/folder/organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project/folder/organization whose feeds are to be
        /// listed. It can only be using project/folder/organization number (such as
        /// "folders/12345")", or a project ID (such as "projects/my-project-id").
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListFeedsResponse> ListFeedsAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ListFeedsAsync(new ListFeedsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Lists all asset feeds in a parent project/folder/organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project/folder/organization whose feeds are to be
        /// listed. It can only be using project/folder/organization number (such as
        /// "folders/12345")", or a project ID (such as "projects/my-project-id").
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListFeedsResponse> ListFeedsAsync(string parent, st::CancellationToken cancellationToken) =>
            ListFeedsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an asset feed configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Feed UpdateFeed(UpdateFeedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an asset feed configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> UpdateFeedAsync(UpdateFeedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an asset feed configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> UpdateFeedAsync(UpdateFeedRequest request, st::CancellationToken cancellationToken) =>
            UpdateFeedAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an asset feed configuration.
        /// </summary>
        /// <param name="feed">
        /// Required. The new values of feed details. It must match an existing feed and the
        /// field `name` must be in the format of:
        /// projects/project_number/feeds/feed_id or
        /// folders/folder_number/feeds/feed_id or
        /// organizations/organization_number/feeds/feed_id.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Feed UpdateFeed(Feed feed, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFeed(new UpdateFeedRequest
            {
                Feed = gax::GaxPreconditions.CheckNotNull(feed, nameof(feed)),
            }, callSettings);

        /// <summary>
        /// Updates an asset feed configuration.
        /// </summary>
        /// <param name="feed">
        /// Required. The new values of feed details. It must match an existing feed and the
        /// field `name` must be in the format of:
        /// projects/project_number/feeds/feed_id or
        /// folders/folder_number/feeds/feed_id or
        /// organizations/organization_number/feeds/feed_id.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> UpdateFeedAsync(Feed feed, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFeedAsync(new UpdateFeedRequest
            {
                Feed = gax::GaxPreconditions.CheckNotNull(feed, nameof(feed)),
            }, callSettings);

        /// <summary>
        /// Updates an asset feed configuration.
        /// </summary>
        /// <param name="feed">
        /// Required. The new values of feed details. It must match an existing feed and the
        /// field `name` must be in the format of:
        /// projects/project_number/feeds/feed_id or
        /// folders/folder_number/feeds/feed_id or
        /// organizations/organization_number/feeds/feed_id.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Feed> UpdateFeedAsync(Feed feed, st::CancellationToken cancellationToken) =>
            UpdateFeedAsync(feed, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an asset feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteFeed(DeleteFeedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an asset feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFeedAsync(DeleteFeedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an asset feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFeedAsync(DeleteFeedRequest request, st::CancellationToken cancellationToken) =>
            DeleteFeedAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an asset feed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feed and it must be in the format of:
        /// projects/project_number/feeds/feed_id
        /// folders/folder_number/feeds/feed_id
        /// organizations/organization_number/feeds/feed_id
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteFeed(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeed(new DeleteFeedRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an asset feed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feed and it must be in the format of:
        /// projects/project_number/feeds/feed_id
        /// folders/folder_number/feeds/feed_id
        /// organizations/organization_number/feeds/feed_id
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFeedAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeedAsync(new DeleteFeedRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an asset feed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feed and it must be in the format of:
        /// projects/project_number/feeds/feed_id
        /// folders/folder_number/feeds/feed_id
        /// organizations/organization_number/feeds/feed_id
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFeedAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteFeedAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an asset feed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feed and it must be in the format of:
        /// projects/project_number/feeds/feed_id
        /// folders/folder_number/feeds/feed_id
        /// organizations/organization_number/feeds/feed_id
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteFeed(FeedName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeed(new DeleteFeedRequest
            {
                FeedName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an asset feed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feed and it must be in the format of:
        /// projects/project_number/feeds/feed_id
        /// folders/folder_number/feeds/feed_id
        /// organizations/organization_number/feeds/feed_id
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFeedAsync(FeedName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFeedAsync(new DeleteFeedRequest
            {
                FeedName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an asset feed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the feed and it must be in the format of:
        /// projects/project_number/feeds/feed_id
        /// folders/folder_number/feeds/feed_id
        /// organizations/organization_number/feeds/feed_id
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFeedAsync(FeedName name, st::CancellationToken cancellationToken) =>
            DeleteFeedAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AssetService client wrapper implementation, for convenient use.</summary>
    public sealed partial class AssetServiceClientImpl : AssetServiceClient
    {
        private readonly gaxgrpc::ApiCall<ExportAssetsRequest, lro::Operation> _callExportAssets;

        private readonly gaxgrpc::ApiCall<BatchGetAssetsHistoryRequest, BatchGetAssetsHistoryResponse> _callBatchGetAssetsHistory;

        private readonly gaxgrpc::ApiCall<CreateFeedRequest, Feed> _callCreateFeed;

        private readonly gaxgrpc::ApiCall<GetFeedRequest, Feed> _callGetFeed;

        private readonly gaxgrpc::ApiCall<ListFeedsRequest, ListFeedsResponse> _callListFeeds;

        private readonly gaxgrpc::ApiCall<UpdateFeedRequest, Feed> _callUpdateFeed;

        private readonly gaxgrpc::ApiCall<DeleteFeedRequest, wkt::Empty> _callDeleteFeed;

        /// <summary>
        /// Constructs a client wrapper for the AssetService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AssetServiceSettings"/> used within this client.</param>
        public AssetServiceClientImpl(AssetService.AssetServiceClient grpcClient, AssetServiceSettings settings)
        {
            GrpcClient = grpcClient;
            AssetServiceSettings effectiveSettings = settings ?? AssetServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            ExportAssetsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportAssetsOperationsSettings);
            _callExportAssets = clientHelper.BuildApiCall<ExportAssetsRequest, lro::Operation>(grpcClient.ExportAssetsAsync, grpcClient.ExportAssets, effectiveSettings.ExportAssetsSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={(sysnet::WebUtility.UrlEncode(request.Parent))}"));
            Modify_ApiCall(ref _callExportAssets);
            Modify_ExportAssetsApiCall(ref _callExportAssets);
            _callBatchGetAssetsHistory = clientHelper.BuildApiCall<BatchGetAssetsHistoryRequest, BatchGetAssetsHistoryResponse>(grpcClient.BatchGetAssetsHistoryAsync, grpcClient.BatchGetAssetsHistory, effectiveSettings.BatchGetAssetsHistorySettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={(sysnet::WebUtility.UrlEncode(request.Parent))}"));
            Modify_ApiCall(ref _callBatchGetAssetsHistory);
            Modify_BatchGetAssetsHistoryApiCall(ref _callBatchGetAssetsHistory);
            _callCreateFeed = clientHelper.BuildApiCall<CreateFeedRequest, Feed>(grpcClient.CreateFeedAsync, grpcClient.CreateFeed, effectiveSettings.CreateFeedSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={(sysnet::WebUtility.UrlEncode(request.Parent))}"));
            Modify_ApiCall(ref _callCreateFeed);
            Modify_CreateFeedApiCall(ref _callCreateFeed);
            _callGetFeed = clientHelper.BuildApiCall<GetFeedRequest, Feed>(grpcClient.GetFeedAsync, grpcClient.GetFeed, effectiveSettings.GetFeedSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={(sysnet::WebUtility.UrlEncode(request.Name))}"));
            Modify_ApiCall(ref _callGetFeed);
            Modify_GetFeedApiCall(ref _callGetFeed);
            _callListFeeds = clientHelper.BuildApiCall<ListFeedsRequest, ListFeedsResponse>(grpcClient.ListFeedsAsync, grpcClient.ListFeeds, effectiveSettings.ListFeedsSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={(sysnet::WebUtility.UrlEncode(request.Parent))}"));
            Modify_ApiCall(ref _callListFeeds);
            Modify_ListFeedsApiCall(ref _callListFeeds);
            _callUpdateFeed = clientHelper.BuildApiCall<UpdateFeedRequest, Feed>(grpcClient.UpdateFeedAsync, grpcClient.UpdateFeed, effectiveSettings.UpdateFeedSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"feed.name={(sysnet::WebUtility.UrlEncode(request.Feed.Name))}"));
            Modify_ApiCall(ref _callUpdateFeed);
            Modify_UpdateFeedApiCall(ref _callUpdateFeed);
            _callDeleteFeed = clientHelper.BuildApiCall<DeleteFeedRequest, wkt::Empty>(grpcClient.DeleteFeedAsync, grpcClient.DeleteFeed, effectiveSettings.DeleteFeedSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={(sysnet::WebUtility.UrlEncode(request.Name))}"));
            Modify_ApiCall(ref _callDeleteFeed);
            Modify_DeleteFeedApiCall(ref _callDeleteFeed);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ExportAssetsApiCall(ref gaxgrpc::ApiCall<ExportAssetsRequest, lro::Operation> call);

        partial void Modify_BatchGetAssetsHistoryApiCall(ref gaxgrpc::ApiCall<BatchGetAssetsHistoryRequest, BatchGetAssetsHistoryResponse> call);

        partial void Modify_CreateFeedApiCall(ref gaxgrpc::ApiCall<CreateFeedRequest, Feed> call);

        partial void Modify_GetFeedApiCall(ref gaxgrpc::ApiCall<GetFeedRequest, Feed> call);

        partial void Modify_ListFeedsApiCall(ref gaxgrpc::ApiCall<ListFeedsRequest, ListFeedsResponse> call);

        partial void Modify_UpdateFeedApiCall(ref gaxgrpc::ApiCall<UpdateFeedRequest, Feed> call);

        partial void Modify_DeleteFeedApiCall(ref gaxgrpc::ApiCall<DeleteFeedRequest, wkt::Empty> call);

        partial void OnConstruction(AssetService.AssetServiceClient grpcClient, AssetServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AssetService client</summary>
        public override AssetService.AssetServiceClient GrpcClient { get; }

        partial void Modify_ExportAssetsRequest(ref ExportAssetsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchGetAssetsHistoryRequest(ref BatchGetAssetsHistoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateFeedRequest(ref CreateFeedRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetFeedRequest(ref GetFeedRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListFeedsRequest(ref ListFeedsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateFeedRequest(ref UpdateFeedRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteFeedRequest(ref DeleteFeedRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>ExportAssets</c>.</summary>
        public override lro::OperationsClient ExportAssetsOperationsClient { get; }

        /// <summary>
        /// Exports assets with time and resource types to a given Cloud Storage
        /// location. The output format is newline-delimited JSON.
        /// This API implements the [google.longrunning.Operation][google.longrunning.Operation] API allowing you
        /// to keep track of the export.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ExportAssetsResponse, ExportAssetsRequest> ExportAssets(ExportAssetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportAssetsRequest(ref request, ref callSettings);
            return new lro::Operation<ExportAssetsResponse, ExportAssetsRequest>(_callExportAssets.Sync(request, callSettings), ExportAssetsOperationsClient);
        }

        /// <summary>
        /// Exports assets with time and resource types to a given Cloud Storage
        /// location. The output format is newline-delimited JSON.
        /// This API implements the [google.longrunning.Operation][google.longrunning.Operation] API allowing you
        /// to keep track of the export.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExportAssetsResponse, ExportAssetsRequest>> ExportAssetsAsync(ExportAssetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportAssetsRequest(ref request, ref callSettings);
            return new lro::Operation<ExportAssetsResponse, ExportAssetsRequest>(await _callExportAssets.Async(request, callSettings).ConfigureAwait(false), ExportAssetsOperationsClient);
        }

        /// <summary>
        /// Batch gets the update history of assets that overlap a time window.
        /// For RESOURCE content, this API outputs history with asset in both
        /// non-delete or deleted status.
        /// For IAM_POLICY content, this API outputs history when the asset and its
        /// attached IAM POLICY both exist. This can create gaps in the output history.
        /// If a specified asset does not exist, this API returns an INVALID_ARGUMENT
        /// error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchGetAssetsHistoryResponse BatchGetAssetsHistory(BatchGetAssetsHistoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchGetAssetsHistoryRequest(ref request, ref callSettings);
            return _callBatchGetAssetsHistory.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch gets the update history of assets that overlap a time window.
        /// For RESOURCE content, this API outputs history with asset in both
        /// non-delete or deleted status.
        /// For IAM_POLICY content, this API outputs history when the asset and its
        /// attached IAM POLICY both exist. This can create gaps in the output history.
        /// If a specified asset does not exist, this API returns an INVALID_ARGUMENT
        /// error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchGetAssetsHistoryResponse> BatchGetAssetsHistoryAsync(BatchGetAssetsHistoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchGetAssetsHistoryRequest(ref request, ref callSettings);
            return _callBatchGetAssetsHistory.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a feed in a parent project/folder/organization to listen to its
        /// asset updates.
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
        /// Creates a feed in a parent project/folder/organization to listen to its
        /// asset updates.
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
        /// Gets details about an asset feed.
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
        /// Gets details about an asset feed.
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
        /// Lists all asset feeds in a parent project/folder/organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListFeedsResponse ListFeeds(ListFeedsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFeedsRequest(ref request, ref callSettings);
            return _callListFeeds.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists all asset feeds in a parent project/folder/organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListFeedsResponse> ListFeedsAsync(ListFeedsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFeedsRequest(ref request, ref callSettings);
            return _callListFeeds.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an asset feed configuration.
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
        /// Updates an asset feed configuration.
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
        /// Deletes an asset feed.
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
        /// Deletes an asset feed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteFeedAsync(DeleteFeedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFeedRequest(ref request, ref callSettings);
            return _callDeleteFeed.Async(request, callSettings);
        }
    }

    public static partial class AssetService
    {
        public partial class AssetServiceClient
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
