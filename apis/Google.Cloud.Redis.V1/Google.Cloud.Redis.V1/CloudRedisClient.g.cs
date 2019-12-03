// Copyright 2019 Google LLC
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
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using sysnet = System.Net;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Redis.V1
{
    /// <summary>Settings for <see cref="CloudRedisClient"/> instances.</summary>
    public sealed partial class CloudRedisSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CloudRedisSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CloudRedisSettings"/>.</returns>
        public static CloudRedisSettings GetDefault() => new CloudRedisSettings();

        /// <summary>Constructs a new <see cref="CloudRedisSettings"/> object with default settings.</summary>
        public CloudRedisSettings()
        {
        }

        private CloudRedisSettings(CloudRedisSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListInstancesSettings = existing.ListInstancesSettings;
            GetInstanceSettings = existing.GetInstanceSettings;
            CreateInstanceSettings = existing.CreateInstanceSettings;
            CreateInstanceOperationsSettings = existing.CreateInstanceOperationsSettings.Clone();
            UpdateInstanceSettings = existing.UpdateInstanceSettings;
            UpdateInstanceOperationsSettings = existing.UpdateInstanceOperationsSettings.Clone();
            ImportInstanceSettings = existing.ImportInstanceSettings;
            ImportInstanceOperationsSettings = existing.ImportInstanceOperationsSettings.Clone();
            ExportInstanceSettings = existing.ExportInstanceSettings;
            ExportInstanceOperationsSettings = existing.ExportInstanceOperationsSettings.Clone();
            FailoverInstanceSettings = existing.FailoverInstanceSettings;
            FailoverInstanceOperationsSettings = existing.FailoverInstanceOperationsSettings.Clone();
            DeleteInstanceSettings = existing.DeleteInstanceSettings;
            DeleteInstanceOperationsSettings = existing.DeleteInstanceOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(CloudRedisSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudRedisClient.ListInstances</c> and <c>CloudRedisClient.ListInstancesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListInstancesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudRedisClient.GetInstance</c> and <c>CloudRedisClient.GetInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudRedisClient.CreateInstance</c> and <c>CloudRedisClient.CreateInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudRedisClient.CreateInstance</c> and
        /// <c>CloudRedisClient.CreateInstanceAsync</c>.
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
        public lro::OperationsSettings CreateInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudRedisClient.UpdateInstance</c> and <c>CloudRedisClient.UpdateInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudRedisClient.UpdateInstance</c> and
        /// <c>CloudRedisClient.UpdateInstanceAsync</c>.
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
        public lro::OperationsSettings UpdateInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudRedisClient.ImportInstance</c> and <c>CloudRedisClient.ImportInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ImportInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudRedisClient.ImportInstance</c> and
        /// <c>CloudRedisClient.ImportInstanceAsync</c>.
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
        public lro::OperationsSettings ImportInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudRedisClient.ExportInstance</c> and <c>CloudRedisClient.ExportInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExportInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudRedisClient.ExportInstance</c> and
        /// <c>CloudRedisClient.ExportInstanceAsync</c>.
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
        public lro::OperationsSettings ExportInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudRedisClient.FailoverInstance</c> and <c>CloudRedisClient.FailoverInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FailoverInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudRedisClient.FailoverInstance</c> and
        /// <c>CloudRedisClient.FailoverInstanceAsync</c>.
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
        public lro::OperationsSettings FailoverInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudRedisClient.DeleteInstance</c> and <c>CloudRedisClient.DeleteInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudRedisClient.DeleteInstance</c> and
        /// <c>CloudRedisClient.DeleteInstanceAsync</c>.
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
        public lro::OperationsSettings DeleteInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CloudRedisSettings"/> object.</returns>
        public CloudRedisSettings Clone() => new CloudRedisSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CloudRedisClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class CloudRedisClientBuilder : gaxgrpc::ClientBuilderBase<CloudRedisClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CloudRedisSettings Settings { get; set; }

        /// <inheritdoc/>
        public override CloudRedisClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CloudRedisClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc/>
        public override async stt::Task<CloudRedisClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CloudRedisClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc/>
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => CloudRedisClient.DefaultEndpoint;

        /// <inheritdoc/>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => CloudRedisClient.DefaultScopes;

        /// <inheritdoc/>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CloudRedisClient.ChannelPool;
    }

    /// <summary>CloudRedis client wrapper, for convenient use.</summary>
    public abstract partial class CloudRedisClient
    {
        /// <summary>
        /// The default endpoint for the CloudRedis service, which is a host of "redis.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("redis.googleapis.com", 443);

        /// <summary>The default CloudRedis scopes.</summary>
        /// <remarks>
        /// The default CloudRedis scopes are:
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
        /// Asynchronously creates a <see cref="CloudRedisClient"/>, applying defaults for all unspecified settings, and
        /// creating a channel connecting to the given endpoint with application default credentials where necessary.
        /// See the example for how to use custom credentials.
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
        /// <param name="settings">Optional <see cref="CloudRedisSettings"/>.</param>
        /// <returns>The task representing the created <see cref="CloudRedisClient"/>.</returns>
        public static async stt::Task<CloudRedisClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, CloudRedisSettings settings = null)
        {
            grpccore::Channel channel = await ChannelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="CloudRedisClient"/>, applying defaults for all unspecified settings, and
        /// creating a channel connecting to the given endpoint with application default credentials where necessary.
        /// See the example for how to use custom credentials.
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
        /// <param name="settings">Optional <see cref="CloudRedisSettings"/>.</param>
        /// <returns>The created <see cref="CloudRedisClient"/>.</returns>
        public static CloudRedisClient Create(gaxgrpc::ServiceEndpoint endpoint = null, CloudRedisSettings settings = null)
        {
            grpccore::Channel channel = ChannelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="CloudRedisClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="CloudRedisSettings"/>.</param>
        /// <returns>The created <see cref="CloudRedisClient"/>.</returns>
        public static CloudRedisClient Create(grpccore::Channel channel, CloudRedisSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="CloudRedisClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CloudRedisSettings"/>.</param>
        /// <returns>The created <see cref="CloudRedisClient"/>.</returns>
        public static CloudRedisClient Create(grpccore::CallInvoker callInvoker, CloudRedisSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CloudRedis.CloudRedisClient grpcClient = new CloudRedis.CloudRedisClient(callInvoker);
            return new CloudRedisClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by
        /// <see cref="Create(grpccore::CallInvoker,CloudRedisSettings)"/> and
        /// <see cref="CreateAsync(gaxgrpc::ServiceEndpoint,CloudRedisSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create(grpccore::CallInvoker,CloudRedisSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint,CloudRedisSettings)"/> will create new channels, which
        /// could in turn be shut down by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC CloudRedis client</summary>
        public virtual CloudRedis.CloudRedisClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all Redis instances owned by a project in either the specified
        /// location (region) or all locations.
        /// 
        /// The location should have the following format:
        /// * `projects/{project_id}/locations/{location_id}`
        /// 
        /// If `location_id` is specified as `-` (wildcard), then all regions
        /// available to the project are queried, and the results are aggregated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all Redis instances owned by a project in either the specified
        /// location (region) or all locations.
        /// 
        /// The location should have the following format:
        /// * `projects/{project_id}/locations/{location_id}`
        /// 
        /// If `location_id` is specified as `-` (wildcard), then all regions
        /// available to the project are queried, and the results are aggregated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all Redis instances owned by a project in either the specified
        /// location (region) or all locations.
        /// 
        /// The location should have the following format:
        /// * `projects/{project_id}/locations/{location_id}`
        /// 
        /// If `location_id` is specified as `-` (wildcard), then all regions
        /// available to the project are queried, and the results are aggregated.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the instance location using the form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
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
        /// <returns>A pageable sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListInstances(new ListInstancesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all Redis instances owned by a project in either the specified
        /// location (region) or all locations.
        /// 
        /// The location should have the following format:
        /// * `projects/{project_id}/locations/{location_id}`
        /// 
        /// If `location_id` is specified as `-` (wildcard), then all regions
        /// available to the project are queried, and the results are aggregated.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the instance location using the form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListInstancesAsync(new ListInstancesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all Redis instances owned by a project in either the specified
        /// location (region) or all locations.
        /// 
        /// The location should have the following format:
        /// * `projects/{project_id}/locations/{location_id}`
        /// 
        /// If `location_id` is specified as `-` (wildcard), then all regions
        /// available to the project are queried, and the results are aggregated.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the instance location using the form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
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
        /// <returns>A pageable sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListInstances(new ListInstancesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all Redis instances owned by a project in either the specified
        /// location (region) or all locations.
        /// 
        /// The location should have the following format:
        /// * `projects/{project_id}/locations/{location_id}`
        /// 
        /// If `location_id` is specified as `-` (wildcard), then all regions
        /// available to the project are queried, and the results are aggregated.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the instance location using the form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListInstancesAsync(new ListInstancesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific Redis instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance GetInstance(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a specific Redis instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a specific Redis instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(GetInstanceRequest request, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a specific Redis instance.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance GetInstance(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstance(new GetInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific Redis instance.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceAsync(new GetInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific Redis instance.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a specific Redis instance.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance GetInstance(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstance(new GetInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific Redis instance.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceAsync(new GetInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific Redis instance.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(InstanceName name, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Redis instance based on the specified tier and memory size.
        /// 
        /// By default, the instance is accessible from the project's
        /// [default network](/compute/docs/networks-and-firewalls#networks).
        /// 
        /// The creation is executed asynchronously and callers may check the returned
        /// operation to track its progress. Once the operation is completed the Redis
        /// instance will be fully functional. Completed longrunning.Operation will
        /// contain the new instance object in the response field.
        /// 
        /// The returned operation is automatically deleted after a few hours, so there
        /// is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> CreateInstance(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Redis instance based on the specified tier and memory size.
        /// 
        /// By default, the instance is accessible from the project's
        /// [default network](/compute/docs/networks-and-firewalls#networks).
        /// 
        /// The creation is executed asynchronously and callers may check the returned
        /// operation to track its progress. Once the operation is completed the Redis
        /// instance will be fully functional. Completed longrunning.Operation will
        /// contain the new instance object in the response field.
        /// 
        /// The returned operation is automatically deleted after a few hours, so there
        /// is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Redis instance based on the specified tier and memory size.
        /// 
        /// By default, the instance is accessible from the project's
        /// [default network](/compute/docs/networks-and-firewalls#networks).
        /// 
        /// The creation is executed asynchronously and callers may check the returned
        /// operation to track its progress. Once the operation is completed the Redis
        /// instance will be fully functional. Completed longrunning.Operation will
        /// contain the new instance object in the response field.
        /// 
        /// The returned operation is automatically deleted after a few hours, so there
        /// is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(CreateInstanceRequest request, st::CancellationToken cancellationToken) =>
            CreateInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateInstance</c>.</summary>
        public virtual lro::OperationsClient CreateInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceCreateInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceCreateInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateInstanceOperationsClient, callSettings);

        /// <summary>
        /// Creates a Redis instance based on the specified tier and memory size.
        /// 
        /// By default, the instance is accessible from the project's
        /// [default network](/compute/docs/networks-and-firewalls#networks).
        /// 
        /// The creation is executed asynchronously and callers may check the returned
        /// operation to track its progress. Once the operation is completed the Redis
        /// instance will be fully functional. Completed longrunning.Operation will
        /// contain the new instance object in the response field.
        /// 
        /// The returned operation is automatically deleted after a few hours, so there
        /// is no need to call DeleteOperation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the instance location using the form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="instanceId">
        /// Required. The logical name of the Redis instance in the customer project
        /// with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-40 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the customer project / location
        /// </param>
        /// <param name="instance">
        /// Required. A Redis [Instance] resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> CreateInstance(string parent, string instanceId, Instance instance, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstance(new CreateInstanceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Creates a Redis instance based on the specified tier and memory size.
        /// 
        /// By default, the instance is accessible from the project's
        /// [default network](/compute/docs/networks-and-firewalls#networks).
        /// 
        /// The creation is executed asynchronously and callers may check the returned
        /// operation to track its progress. Once the operation is completed the Redis
        /// instance will be fully functional. Completed longrunning.Operation will
        /// contain the new instance object in the response field.
        /// 
        /// The returned operation is automatically deleted after a few hours, so there
        /// is no need to call DeleteOperation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the instance location using the form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="instanceId">
        /// Required. The logical name of the Redis instance in the customer project
        /// with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-40 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the customer project / location
        /// </param>
        /// <param name="instance">
        /// Required. A Redis [Instance] resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(string parent, string instanceId, Instance instance, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstanceAsync(new CreateInstanceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Creates a Redis instance based on the specified tier and memory size.
        /// 
        /// By default, the instance is accessible from the project's
        /// [default network](/compute/docs/networks-and-firewalls#networks).
        /// 
        /// The creation is executed asynchronously and callers may check the returned
        /// operation to track its progress. Once the operation is completed the Redis
        /// instance will be fully functional. Completed longrunning.Operation will
        /// contain the new instance object in the response field.
        /// 
        /// The returned operation is automatically deleted after a few hours, so there
        /// is no need to call DeleteOperation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the instance location using the form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="instanceId">
        /// Required. The logical name of the Redis instance in the customer project
        /// with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-40 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the customer project / location
        /// </param>
        /// <param name="instance">
        /// Required. A Redis [Instance] resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(string parent, string instanceId, Instance instance, st::CancellationToken cancellationToken) =>
            CreateInstanceAsync(parent, instanceId, instance, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Redis instance based on the specified tier and memory size.
        /// 
        /// By default, the instance is accessible from the project's
        /// [default network](/compute/docs/networks-and-firewalls#networks).
        /// 
        /// The creation is executed asynchronously and callers may check the returned
        /// operation to track its progress. Once the operation is completed the Redis
        /// instance will be fully functional. Completed longrunning.Operation will
        /// contain the new instance object in the response field.
        /// 
        /// The returned operation is automatically deleted after a few hours, so there
        /// is no need to call DeleteOperation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the instance location using the form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="instanceId">
        /// Required. The logical name of the Redis instance in the customer project
        /// with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-40 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the customer project / location
        /// </param>
        /// <param name="instance">
        /// Required. A Redis [Instance] resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> CreateInstance(LocationName parent, string instanceId, Instance instance, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstance(new CreateInstanceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Creates a Redis instance based on the specified tier and memory size.
        /// 
        /// By default, the instance is accessible from the project's
        /// [default network](/compute/docs/networks-and-firewalls#networks).
        /// 
        /// The creation is executed asynchronously and callers may check the returned
        /// operation to track its progress. Once the operation is completed the Redis
        /// instance will be fully functional. Completed longrunning.Operation will
        /// contain the new instance object in the response field.
        /// 
        /// The returned operation is automatically deleted after a few hours, so there
        /// is no need to call DeleteOperation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the instance location using the form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="instanceId">
        /// Required. The logical name of the Redis instance in the customer project
        /// with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-40 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the customer project / location
        /// </param>
        /// <param name="instance">
        /// Required. A Redis [Instance] resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(LocationName parent, string instanceId, Instance instance, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstanceAsync(new CreateInstanceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Creates a Redis instance based on the specified tier and memory size.
        /// 
        /// By default, the instance is accessible from the project's
        /// [default network](/compute/docs/networks-and-firewalls#networks).
        /// 
        /// The creation is executed asynchronously and callers may check the returned
        /// operation to track its progress. Once the operation is completed the Redis
        /// instance will be fully functional. Completed longrunning.Operation will
        /// contain the new instance object in the response field.
        /// 
        /// The returned operation is automatically deleted after a few hours, so there
        /// is no need to call DeleteOperation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the instance location using the form:
        /// `projects/{project_id}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="instanceId">
        /// Required. The logical name of the Redis instance in the customer project
        /// with the following restrictions:
        /// 
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-40 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the customer project / location
        /// </param>
        /// <param name="instance">
        /// Required. A Redis [Instance] resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(LocationName parent, string instanceId, Instance instance, st::CancellationToken cancellationToken) =>
            CreateInstanceAsync(parent, instanceId, instance, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the metadata and configuration of a specific Redis instance.
        /// 
        /// Completed longrunning.Operation will contain the new instance object
        /// in the response field. The returned operation is automatically deleted
        /// after a few hours, so there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> UpdateInstance(UpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the metadata and configuration of a specific Redis instance.
        /// 
        /// Completed longrunning.Operation will contain the new instance object
        /// in the response field. The returned operation is automatically deleted
        /// after a few hours, so there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> UpdateInstanceAsync(UpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the metadata and configuration of a specific Redis instance.
        /// 
        /// Completed longrunning.Operation will contain the new instance object
        /// in the response field. The returned operation is automatically deleted
        /// after a few hours, so there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> UpdateInstanceAsync(UpdateInstanceRequest request, st::CancellationToken cancellationToken) =>
            UpdateInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateInstance</c>.</summary>
        public virtual lro::OperationsClient UpdateInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceUpdateInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceUpdateInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateInstanceOperationsClient, callSettings);

        /// <summary>
        /// Updates the metadata and configuration of a specific Redis instance.
        /// 
        /// Completed longrunning.Operation will contain the new instance object
        /// in the response field. The returned operation is automatically deleted
        /// after a few hours, so there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field. The elements of the repeated paths field may only include these
        /// fields from [Instance][CloudRedis.Instance]:
        /// 
        /// *   `displayName`
        /// *   `labels`
        /// *   `memorySizeGb`
        /// *   `redisConfig`
        /// </param>
        /// <param name="instance">
        /// Required. Update description.
        /// Only fields specified in update_mask are updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> UpdateInstance(wkt::FieldMask updateMask, Instance instance, gaxgrpc::CallSettings callSettings = null) =>
            UpdateInstance(new UpdateInstanceRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Updates the metadata and configuration of a specific Redis instance.
        /// 
        /// Completed longrunning.Operation will contain the new instance object
        /// in the response field. The returned operation is automatically deleted
        /// after a few hours, so there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field. The elements of the repeated paths field may only include these
        /// fields from [Instance][CloudRedis.Instance]:
        /// 
        /// *   `displayName`
        /// *   `labels`
        /// *   `memorySizeGb`
        /// *   `redisConfig`
        /// </param>
        /// <param name="instance">
        /// Required. Update description.
        /// Only fields specified in update_mask are updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> UpdateInstanceAsync(wkt::FieldMask updateMask, Instance instance, gaxgrpc::CallSettings callSettings = null) =>
            UpdateInstanceAsync(new UpdateInstanceRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Updates the metadata and configuration of a specific Redis instance.
        /// 
        /// Completed longrunning.Operation will contain the new instance object
        /// in the response field. The returned operation is automatically deleted
        /// after a few hours, so there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="updateMask">
        /// Required. Mask of fields to update. At least one path must be supplied in
        /// this field. The elements of the repeated paths field may only include these
        /// fields from [Instance][CloudRedis.Instance]:
        /// 
        /// *   `displayName`
        /// *   `labels`
        /// *   `memorySizeGb`
        /// *   `redisConfig`
        /// </param>
        /// <param name="instance">
        /// Required. Update description.
        /// Only fields specified in update_mask are updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> UpdateInstanceAsync(wkt::FieldMask updateMask, Instance instance, st::CancellationToken cancellationToken) =>
            UpdateInstanceAsync(updateMask, instance, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Import a Redis RDB snapshot file from Cloud Storage into a Redis instance.
        /// 
        /// Redis may stop serving during this operation. Instance state will be
        /// IMPORTING for entire operation. When complete, the instance will contain
        /// only data from the imported file.
        /// 
        /// The returned operation is automatically deleted after a few hours, so
        /// there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> ImportInstance(ImportInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Import a Redis RDB snapshot file from Cloud Storage into a Redis instance.
        /// 
        /// Redis may stop serving during this operation. Instance state will be
        /// IMPORTING for entire operation. When complete, the instance will contain
        /// only data from the imported file.
        /// 
        /// The returned operation is automatically deleted after a few hours, so
        /// there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> ImportInstanceAsync(ImportInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Import a Redis RDB snapshot file from Cloud Storage into a Redis instance.
        /// 
        /// Redis may stop serving during this operation. Instance state will be
        /// IMPORTING for entire operation. When complete, the instance will contain
        /// only data from the imported file.
        /// 
        /// The returned operation is automatically deleted after a few hours, so
        /// there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> ImportInstanceAsync(ImportInstanceRequest request, st::CancellationToken cancellationToken) =>
            ImportInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ImportInstance</c>.</summary>
        public virtual lro::OperationsClient ImportInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ImportInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceImportInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceImportInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportInstanceOperationsClient, callSettings);

        /// <summary>
        /// Import a Redis RDB snapshot file from Cloud Storage into a Redis instance.
        /// 
        /// Redis may stop serving during this operation. Instance state will be
        /// IMPORTING for entire operation. When complete, the instance will contain
        /// only data from the imported file.
        /// 
        /// The returned operation is automatically deleted after a few hours, so
        /// there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="inputConfig">
        /// Required. Specify data to be imported.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> ImportInstance(string name, InputConfig inputConfig, gaxgrpc::CallSettings callSettings = null) =>
            ImportInstance(new ImportInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                InputConfig = gax::GaxPreconditions.CheckNotNull(inputConfig, nameof(inputConfig)),
            }, callSettings);

        /// <summary>
        /// Import a Redis RDB snapshot file from Cloud Storage into a Redis instance.
        /// 
        /// Redis may stop serving during this operation. Instance state will be
        /// IMPORTING for entire operation. When complete, the instance will contain
        /// only data from the imported file.
        /// 
        /// The returned operation is automatically deleted after a few hours, so
        /// there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="inputConfig">
        /// Required. Specify data to be imported.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> ImportInstanceAsync(string name, InputConfig inputConfig, gaxgrpc::CallSettings callSettings = null) =>
            ImportInstanceAsync(new ImportInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                InputConfig = gax::GaxPreconditions.CheckNotNull(inputConfig, nameof(inputConfig)),
            }, callSettings);

        /// <summary>
        /// Import a Redis RDB snapshot file from Cloud Storage into a Redis instance.
        /// 
        /// Redis may stop serving during this operation. Instance state will be
        /// IMPORTING for entire operation. When complete, the instance will contain
        /// only data from the imported file.
        /// 
        /// The returned operation is automatically deleted after a few hours, so
        /// there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="inputConfig">
        /// Required. Specify data to be imported.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> ImportInstanceAsync(string name, InputConfig inputConfig, st::CancellationToken cancellationToken) =>
            ImportInstanceAsync(name, inputConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Export Redis instance data into a Redis RDB format file in Cloud Storage.
        /// 
        /// Redis will continue serving during this operation.
        /// 
        /// The returned operation is automatically deleted after a few hours, so
        /// there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> ExportInstance(ExportInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Export Redis instance data into a Redis RDB format file in Cloud Storage.
        /// 
        /// Redis will continue serving during this operation.
        /// 
        /// The returned operation is automatically deleted after a few hours, so
        /// there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> ExportInstanceAsync(ExportInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Export Redis instance data into a Redis RDB format file in Cloud Storage.
        /// 
        /// Redis will continue serving during this operation.
        /// 
        /// The returned operation is automatically deleted after a few hours, so
        /// there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> ExportInstanceAsync(ExportInstanceRequest request, st::CancellationToken cancellationToken) =>
            ExportInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExportInstance</c>.</summary>
        public virtual lro::OperationsClient ExportInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ExportInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceExportInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceExportInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportInstanceOperationsClient, callSettings);

        /// <summary>
        /// Export Redis instance data into a Redis RDB format file in Cloud Storage.
        /// 
        /// Redis will continue serving during this operation.
        /// 
        /// The returned operation is automatically deleted after a few hours, so
        /// there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="outputConfig">
        /// Required. Specify data to be exported.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> ExportInstance(string name, OutputConfig outputConfig, gaxgrpc::CallSettings callSettings = null) =>
            ExportInstance(new ExportInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                OutputConfig = gax::GaxPreconditions.CheckNotNull(outputConfig, nameof(outputConfig)),
            }, callSettings);

        /// <summary>
        /// Export Redis instance data into a Redis RDB format file in Cloud Storage.
        /// 
        /// Redis will continue serving during this operation.
        /// 
        /// The returned operation is automatically deleted after a few hours, so
        /// there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="outputConfig">
        /// Required. Specify data to be exported.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> ExportInstanceAsync(string name, OutputConfig outputConfig, gaxgrpc::CallSettings callSettings = null) =>
            ExportInstanceAsync(new ExportInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                OutputConfig = gax::GaxPreconditions.CheckNotNull(outputConfig, nameof(outputConfig)),
            }, callSettings);

        /// <summary>
        /// Export Redis instance data into a Redis RDB format file in Cloud Storage.
        /// 
        /// Redis will continue serving during this operation.
        /// 
        /// The returned operation is automatically deleted after a few hours, so
        /// there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="outputConfig">
        /// Required. Specify data to be exported.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> ExportInstanceAsync(string name, OutputConfig outputConfig, st::CancellationToken cancellationToken) =>
            ExportInstanceAsync(name, outputConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Initiates a failover of the master node to current replica node for a
        /// specific STANDARD tier Cloud Memorystore for Redis instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> FailoverInstance(FailoverInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Initiates a failover of the master node to current replica node for a
        /// specific STANDARD tier Cloud Memorystore for Redis instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> FailoverInstanceAsync(FailoverInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Initiates a failover of the master node to current replica node for a
        /// specific STANDARD tier Cloud Memorystore for Redis instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> FailoverInstanceAsync(FailoverInstanceRequest request, st::CancellationToken cancellationToken) =>
            FailoverInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>FailoverInstance</c>.</summary>
        public virtual lro::OperationsClient FailoverInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>FailoverInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceFailoverInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), FailoverInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>FailoverInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceFailoverInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), FailoverInstanceOperationsClient, callSettings);

        /// <summary>
        /// Initiates a failover of the master node to current replica node for a
        /// specific STANDARD tier Cloud Memorystore for Redis instance.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="dataProtectionMode">
        /// Optional. Available data protection modes that the user can choose. If it's
        /// unspecified, data protection mode will be LIMITED_DATA_LOSS by default.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> FailoverInstance(string name, FailoverInstanceRequest.Types.DataProtectionMode dataProtectionMode, gaxgrpc::CallSettings callSettings = null) =>
            FailoverInstance(new FailoverInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                DataProtectionMode = dataProtectionMode,
            }, callSettings);

        /// <summary>
        /// Initiates a failover of the master node to current replica node for a
        /// specific STANDARD tier Cloud Memorystore for Redis instance.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="dataProtectionMode">
        /// Optional. Available data protection modes that the user can choose. If it's
        /// unspecified, data protection mode will be LIMITED_DATA_LOSS by default.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> FailoverInstanceAsync(string name, FailoverInstanceRequest.Types.DataProtectionMode dataProtectionMode, gaxgrpc::CallSettings callSettings = null) =>
            FailoverInstanceAsync(new FailoverInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                DataProtectionMode = dataProtectionMode,
            }, callSettings);

        /// <summary>
        /// Initiates a failover of the master node to current replica node for a
        /// specific STANDARD tier Cloud Memorystore for Redis instance.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="dataProtectionMode">
        /// Optional. Available data protection modes that the user can choose. If it's
        /// unspecified, data protection mode will be LIMITED_DATA_LOSS by default.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> FailoverInstanceAsync(string name, FailoverInstanceRequest.Types.DataProtectionMode dataProtectionMode, st::CancellationToken cancellationToken) =>
            FailoverInstanceAsync(name, dataProtectionMode, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Initiates a failover of the master node to current replica node for a
        /// specific STANDARD tier Cloud Memorystore for Redis instance.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="dataProtectionMode">
        /// Optional. Available data protection modes that the user can choose. If it's
        /// unspecified, data protection mode will be LIMITED_DATA_LOSS by default.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> FailoverInstance(InstanceName name, FailoverInstanceRequest.Types.DataProtectionMode dataProtectionMode, gaxgrpc::CallSettings callSettings = null) =>
            FailoverInstance(new FailoverInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                DataProtectionMode = dataProtectionMode,
            }, callSettings);

        /// <summary>
        /// Initiates a failover of the master node to current replica node for a
        /// specific STANDARD tier Cloud Memorystore for Redis instance.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="dataProtectionMode">
        /// Optional. Available data protection modes that the user can choose. If it's
        /// unspecified, data protection mode will be LIMITED_DATA_LOSS by default.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> FailoverInstanceAsync(InstanceName name, FailoverInstanceRequest.Types.DataProtectionMode dataProtectionMode, gaxgrpc::CallSettings callSettings = null) =>
            FailoverInstanceAsync(new FailoverInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                DataProtectionMode = dataProtectionMode,
            }, callSettings);

        /// <summary>
        /// Initiates a failover of the master node to current replica node for a
        /// specific STANDARD tier Cloud Memorystore for Redis instance.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="dataProtectionMode">
        /// Optional. Available data protection modes that the user can choose. If it's
        /// unspecified, data protection mode will be LIMITED_DATA_LOSS by default.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> FailoverInstanceAsync(InstanceName name, FailoverInstanceRequest.Types.DataProtectionMode dataProtectionMode, st::CancellationToken cancellationToken) =>
            FailoverInstanceAsync(name, dataProtectionMode, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a specific Redis instance.  Instance stops serving and data is
        /// deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInstance(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a specific Redis instance.  Instance stops serving and data is
        /// deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a specific Redis instance.  Instance stops serving and data is
        /// deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(DeleteInstanceRequest request, st::CancellationToken cancellationToken) =>
            DeleteInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteInstance</c>.</summary>
        public virtual lro::OperationsClient DeleteInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteInstanceOperationsClient, callSettings);

        /// <summary>
        /// Deletes a specific Redis instance.  Instance stops serving and data is
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInstance(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstance(new DeleteInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific Redis instance.  Instance stops serving and data is
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstanceAsync(new DeleteInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific Redis instance.  Instance stops serving and data is
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a specific Redis instance.  Instance stops serving and data is
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInstance(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstance(new DeleteInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific Redis instance.  Instance stops serving and data is
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstanceAsync(new DeleteInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific Redis instance.  Instance stops serving and data is
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. Redis instance resource name using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(InstanceName name, st::CancellationToken cancellationToken) =>
            DeleteInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CloudRedis client wrapper implementation, for convenient use.</summary>
    public sealed partial class CloudRedisClientImpl : CloudRedisClient
    {
        private readonly gaxgrpc::ApiCall<ListInstancesRequest, ListInstancesResponse> _callListInstances;

        private readonly gaxgrpc::ApiCall<GetInstanceRequest, Instance> _callGetInstance;

        private readonly gaxgrpc::ApiCall<CreateInstanceRequest, lro::Operation> _callCreateInstance;

        private readonly gaxgrpc::ApiCall<UpdateInstanceRequest, lro::Operation> _callUpdateInstance;

        private readonly gaxgrpc::ApiCall<ImportInstanceRequest, lro::Operation> _callImportInstance;

        private readonly gaxgrpc::ApiCall<ExportInstanceRequest, lro::Operation> _callExportInstance;

        private readonly gaxgrpc::ApiCall<FailoverInstanceRequest, lro::Operation> _callFailoverInstance;

        private readonly gaxgrpc::ApiCall<DeleteInstanceRequest, lro::Operation> _callDeleteInstance;

        /// <summary>
        /// Constructs a client wrapper for the CloudRedis service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CloudRedisSettings"/> used within this client.</param>
        public CloudRedisClientImpl(CloudRedis.CloudRedisClient grpcClient, CloudRedisSettings settings)
        {
            GrpcClient = grpcClient;
            CloudRedisSettings effectiveSettings = settings ?? CloudRedisSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            CreateInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateInstanceOperationsSettings);
            UpdateInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateInstanceOperationsSettings);
            ImportInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ImportInstanceOperationsSettings);
            ExportInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportInstanceOperationsSettings);
            FailoverInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.FailoverInstanceOperationsSettings);
            DeleteInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteInstanceOperationsSettings);
            _callListInstances = clientHelper.BuildApiCall<ListInstancesRequest, ListInstancesResponse>(grpcClient.ListInstancesAsync, grpcClient.ListInstances, effectiveSettings.ListInstancesSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={(sysnet::WebUtility.UrlEncode(request.Parent))}"));
            Modify_ApiCall(ref _callListInstances);
            Modify_ListInstancesApiCall(ref _callListInstances);
            _callGetInstance = clientHelper.BuildApiCall<GetInstanceRequest, Instance>(grpcClient.GetInstanceAsync, grpcClient.GetInstance, effectiveSettings.GetInstanceSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={(sysnet::WebUtility.UrlEncode(request.Name))}"));
            Modify_ApiCall(ref _callGetInstance);
            Modify_GetInstanceApiCall(ref _callGetInstance);
            _callCreateInstance = clientHelper.BuildApiCall<CreateInstanceRequest, lro::Operation>(grpcClient.CreateInstanceAsync, grpcClient.CreateInstance, effectiveSettings.CreateInstanceSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={(sysnet::WebUtility.UrlEncode(request.Parent))}"));
            Modify_ApiCall(ref _callCreateInstance);
            Modify_CreateInstanceApiCall(ref _callCreateInstance);
            _callUpdateInstance = clientHelper.BuildApiCall<UpdateInstanceRequest, lro::Operation>(grpcClient.UpdateInstanceAsync, grpcClient.UpdateInstance, effectiveSettings.UpdateInstanceSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"instance.name={(sysnet::WebUtility.UrlEncode(request.Instance.Name))}"));
            Modify_ApiCall(ref _callUpdateInstance);
            Modify_UpdateInstanceApiCall(ref _callUpdateInstance);
            _callImportInstance = clientHelper.BuildApiCall<ImportInstanceRequest, lro::Operation>(grpcClient.ImportInstanceAsync, grpcClient.ImportInstance, effectiveSettings.ImportInstanceSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={(sysnet::WebUtility.UrlEncode(request.Name))}"));
            Modify_ApiCall(ref _callImportInstance);
            Modify_ImportInstanceApiCall(ref _callImportInstance);
            _callExportInstance = clientHelper.BuildApiCall<ExportInstanceRequest, lro::Operation>(grpcClient.ExportInstanceAsync, grpcClient.ExportInstance, effectiveSettings.ExportInstanceSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={(sysnet::WebUtility.UrlEncode(request.Name))}"));
            Modify_ApiCall(ref _callExportInstance);
            Modify_ExportInstanceApiCall(ref _callExportInstance);
            _callFailoverInstance = clientHelper.BuildApiCall<FailoverInstanceRequest, lro::Operation>(grpcClient.FailoverInstanceAsync, grpcClient.FailoverInstance, effectiveSettings.FailoverInstanceSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={(sysnet::WebUtility.UrlEncode(request.Name))}"));
            Modify_ApiCall(ref _callFailoverInstance);
            Modify_FailoverInstanceApiCall(ref _callFailoverInstance);
            _callDeleteInstance = clientHelper.BuildApiCall<DeleteInstanceRequest, lro::Operation>(grpcClient.DeleteInstanceAsync, grpcClient.DeleteInstance, effectiveSettings.DeleteInstanceSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={(sysnet::WebUtility.UrlEncode(request.Name))}"));
            Modify_ApiCall(ref _callDeleteInstance);
            Modify_DeleteInstanceApiCall(ref _callDeleteInstance);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListInstancesApiCall(ref gaxgrpc::ApiCall<ListInstancesRequest, ListInstancesResponse> call);

        partial void Modify_GetInstanceApiCall(ref gaxgrpc::ApiCall<GetInstanceRequest, Instance> call);

        partial void Modify_CreateInstanceApiCall(ref gaxgrpc::ApiCall<CreateInstanceRequest, lro::Operation> call);

        partial void Modify_UpdateInstanceApiCall(ref gaxgrpc::ApiCall<UpdateInstanceRequest, lro::Operation> call);

        partial void Modify_ImportInstanceApiCall(ref gaxgrpc::ApiCall<ImportInstanceRequest, lro::Operation> call);

        partial void Modify_ExportInstanceApiCall(ref gaxgrpc::ApiCall<ExportInstanceRequest, lro::Operation> call);

        partial void Modify_FailoverInstanceApiCall(ref gaxgrpc::ApiCall<FailoverInstanceRequest, lro::Operation> call);

        partial void Modify_DeleteInstanceApiCall(ref gaxgrpc::ApiCall<DeleteInstanceRequest, lro::Operation> call);

        partial void OnConstruction(CloudRedis.CloudRedisClient grpcClient, CloudRedisSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CloudRedis client</summary>
        public override CloudRedis.CloudRedisClient GrpcClient { get; }

        partial void Modify_ListInstancesRequest(ref ListInstancesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetInstanceRequest(ref GetInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateInstanceRequest(ref CreateInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateInstanceRequest(ref UpdateInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportInstanceRequest(ref ImportInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportInstanceRequest(ref ExportInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FailoverInstanceRequest(ref FailoverInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteInstanceRequest(ref DeleteInstanceRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists all Redis instances owned by a project in either the specified
        /// location (region) or all locations.
        /// 
        /// The location should have the following format:
        /// * `projects/{project_id}/locations/{location_id}`
        /// 
        /// If `location_id` is specified as `-` (wildcard), then all regions
        /// available to the project are queried, and the results are aggregated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Instance"/> resources.</returns>
        public override gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstancesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListInstancesRequest, ListInstancesResponse, Instance>(_callListInstances, request, callSettings);
        }

        /// <summary>
        /// Lists all Redis instances owned by a project in either the specified
        /// location (region) or all locations.
        /// 
        /// The location should have the following format:
        /// * `projects/{project_id}/locations/{location_id}`
        /// 
        /// If `location_id` is specified as `-` (wildcard), then all regions
        /// available to the project are queried, and the results are aggregated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Instance"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstancesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListInstancesRequest, ListInstancesResponse, Instance>(_callListInstances, request, callSettings);
        }

        /// <summary>
        /// Gets the details of a specific Redis instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Instance GetInstance(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstanceRequest(ref request, ref callSettings);
            return _callGetInstance.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a specific Redis instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Instance> GetInstanceAsync(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstanceRequest(ref request, ref callSettings);
            return _callGetInstance.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateInstance</c>.</summary>
        public override lro::OperationsClient CreateInstanceOperationsClient { get; }

        /// <summary>
        /// Creates a Redis instance based on the specified tier and memory size.
        /// 
        /// By default, the instance is accessible from the project's
        /// [default network](/compute/docs/networks-and-firewalls#networks).
        /// 
        /// The creation is executed asynchronously and callers may check the returned
        /// operation to track its progress. Once the operation is completed the Redis
        /// instance will be fully functional. Completed longrunning.Operation will
        /// contain the new instance object in the response field.
        /// 
        /// The returned operation is automatically deleted after a few hours, so there
        /// is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> CreateInstance(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callCreateInstance.Sync(request, callSettings), CreateInstanceOperationsClient);
        }

        /// <summary>
        /// Creates a Redis instance based on the specified tier and memory size.
        /// 
        /// By default, the instance is accessible from the project's
        /// [default network](/compute/docs/networks-and-firewalls#networks).
        /// 
        /// The creation is executed asynchronously and callers may check the returned
        /// operation to track its progress. Once the operation is completed the Redis
        /// instance will be fully functional. Completed longrunning.Operation will
        /// contain the new instance object in the response field.
        /// 
        /// The returned operation is automatically deleted after a few hours, so there
        /// is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callCreateInstance.Async(request, callSettings).ConfigureAwait(false), CreateInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateInstance</c>.</summary>
        public override lro::OperationsClient UpdateInstanceOperationsClient { get; }

        /// <summary>
        /// Updates the metadata and configuration of a specific Redis instance.
        /// 
        /// Completed longrunning.Operation will contain the new instance object
        /// in the response field. The returned operation is automatically deleted
        /// after a few hours, so there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> UpdateInstance(UpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callUpdateInstance.Sync(request, callSettings), UpdateInstanceOperationsClient);
        }

        /// <summary>
        /// Updates the metadata and configuration of a specific Redis instance.
        /// 
        /// Completed longrunning.Operation will contain the new instance object
        /// in the response field. The returned operation is automatically deleted
        /// after a few hours, so there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> UpdateInstanceAsync(UpdateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callUpdateInstance.Async(request, callSettings).ConfigureAwait(false), UpdateInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ImportInstance</c>.</summary>
        public override lro::OperationsClient ImportInstanceOperationsClient { get; }

        /// <summary>
        /// Import a Redis RDB snapshot file from Cloud Storage into a Redis instance.
        /// 
        /// Redis may stop serving during this operation. Instance state will be
        /// IMPORTING for entire operation. When complete, the instance will contain
        /// only data from the imported file.
        /// 
        /// The returned operation is automatically deleted after a few hours, so
        /// there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> ImportInstance(ImportInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callImportInstance.Sync(request, callSettings), ImportInstanceOperationsClient);
        }

        /// <summary>
        /// Import a Redis RDB snapshot file from Cloud Storage into a Redis instance.
        /// 
        /// Redis may stop serving during this operation. Instance state will be
        /// IMPORTING for entire operation. When complete, the instance will contain
        /// only data from the imported file.
        /// 
        /// The returned operation is automatically deleted after a few hours, so
        /// there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> ImportInstanceAsync(ImportInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callImportInstance.Async(request, callSettings).ConfigureAwait(false), ImportInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ExportInstance</c>.</summary>
        public override lro::OperationsClient ExportInstanceOperationsClient { get; }

        /// <summary>
        /// Export Redis instance data into a Redis RDB format file in Cloud Storage.
        /// 
        /// Redis will continue serving during this operation.
        /// 
        /// The returned operation is automatically deleted after a few hours, so
        /// there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> ExportInstance(ExportInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callExportInstance.Sync(request, callSettings), ExportInstanceOperationsClient);
        }

        /// <summary>
        /// Export Redis instance data into a Redis RDB format file in Cloud Storage.
        /// 
        /// Redis will continue serving during this operation.
        /// 
        /// The returned operation is automatically deleted after a few hours, so
        /// there is no need to call DeleteOperation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> ExportInstanceAsync(ExportInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callExportInstance.Async(request, callSettings).ConfigureAwait(false), ExportInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>FailoverInstance</c>.</summary>
        public override lro::OperationsClient FailoverInstanceOperationsClient { get; }

        /// <summary>
        /// Initiates a failover of the master node to current replica node for a
        /// specific STANDARD tier Cloud Memorystore for Redis instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> FailoverInstance(FailoverInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FailoverInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callFailoverInstance.Sync(request, callSettings), FailoverInstanceOperationsClient);
        }

        /// <summary>
        /// Initiates a failover of the master node to current replica node for a
        /// specific STANDARD tier Cloud Memorystore for Redis instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> FailoverInstanceAsync(FailoverInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FailoverInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callFailoverInstance.Async(request, callSettings).ConfigureAwait(false), FailoverInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteInstance</c>.</summary>
        public override lro::OperationsClient DeleteInstanceOperationsClient { get; }

        /// <summary>
        /// Deletes a specific Redis instance.  Instance stops serving and data is
        /// deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteInstance(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteInstance.Sync(request, callSettings), DeleteInstanceOperationsClient);
        }

        /// <summary>
        /// Deletes a specific Redis instance.  Instance stops serving and data is
        /// deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteInstance.Async(request, callSettings).ConfigureAwait(false), DeleteInstanceOperationsClient);
        }
    }

    public partial class ListInstancesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListInstancesResponse : gaxgrpc::IPageResponse<Instance>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Instance> GetEnumerator() => Instances.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class CloudRedis
    {
        public partial class CloudRedisClient
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
