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
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.GeminiDataAnalytics.V1Beta
{
    /// <summary>Settings for <see cref="DataAgentServiceClient"/> instances.</summary>
    public sealed partial class DataAgentServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DataAgentServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DataAgentServiceSettings"/>.</returns>
        public static DataAgentServiceSettings GetDefault() => new DataAgentServiceSettings();

        /// <summary>Constructs a new <see cref="DataAgentServiceSettings"/> object with default settings.</summary>
        public DataAgentServiceSettings()
        {
        }

        private DataAgentServiceSettings(DataAgentServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListDataAgentsSettings = existing.ListDataAgentsSettings;
            ListAccessibleDataAgentsSettings = existing.ListAccessibleDataAgentsSettings;
            GetDataAgentSettings = existing.GetDataAgentSettings;
            CreateDataAgentSettings = existing.CreateDataAgentSettings;
            CreateDataAgentOperationsSettings = existing.CreateDataAgentOperationsSettings.Clone();
            UpdateDataAgentSettings = existing.UpdateDataAgentSettings;
            UpdateDataAgentOperationsSettings = existing.UpdateDataAgentOperationsSettings.Clone();
            DeleteDataAgentSettings = existing.DeleteDataAgentSettings;
            DeleteDataAgentOperationsSettings = existing.DeleteDataAgentOperationsSettings.Clone();
            GetIamPolicySettings = existing.GetIamPolicySettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DataAgentServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataAgentServiceClient.ListDataAgents</c> and <c>DataAgentServiceClient.ListDataAgentsAsync</c>.
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
        public gaxgrpc::CallSettings ListDataAgentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataAgentServiceClient.ListAccessibleDataAgents</c> and
        /// <c>DataAgentServiceClient.ListAccessibleDataAgentsAsync</c>.
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
        public gaxgrpc::CallSettings ListAccessibleDataAgentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataAgentServiceClient.GetDataAgent</c> and <c>DataAgentServiceClient.GetDataAgentAsync</c>.
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
        public gaxgrpc::CallSettings GetDataAgentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataAgentServiceClient.CreateDataAgent</c> and <c>DataAgentServiceClient.CreateDataAgentAsync</c>.
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
        public gaxgrpc::CallSettings CreateDataAgentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataAgentServiceClient.CreateDataAgent</c> and
        /// <c>DataAgentServiceClient.CreateDataAgentAsync</c>.
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
        public lro::OperationsSettings CreateDataAgentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataAgentServiceClient.UpdateDataAgent</c> and <c>DataAgentServiceClient.UpdateDataAgentAsync</c>.
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
        public gaxgrpc::CallSettings UpdateDataAgentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataAgentServiceClient.UpdateDataAgent</c> and
        /// <c>DataAgentServiceClient.UpdateDataAgentAsync</c>.
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
        public lro::OperationsSettings UpdateDataAgentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataAgentServiceClient.DeleteDataAgent</c> and <c>DataAgentServiceClient.DeleteDataAgentAsync</c>.
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
        public gaxgrpc::CallSettings DeleteDataAgentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataAgentServiceClient.DeleteDataAgent</c> and
        /// <c>DataAgentServiceClient.DeleteDataAgentAsync</c>.
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
        public lro::OperationsSettings DeleteDataAgentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataAgentServiceClient.GetIamPolicy</c> and <c>DataAgentServiceClient.GetIamPolicyAsync</c>.
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
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataAgentServiceClient.SetIamPolicy</c> and <c>DataAgentServiceClient.SetIamPolicyAsync</c>.
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
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DataAgentServiceSettings"/> object.</returns>
        public DataAgentServiceSettings Clone() => new DataAgentServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DataAgentServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class DataAgentServiceClientBuilder : gaxgrpc::ClientBuilderBase<DataAgentServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DataAgentServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DataAgentServiceClientBuilder() : base(DataAgentServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DataAgentServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DataAgentServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DataAgentServiceClient Build()
        {
            DataAgentServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DataAgentServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DataAgentServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DataAgentServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DataAgentServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DataAgentServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DataAgentServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DataAgentServiceClient.ChannelPool;
    }

    /// <summary>DataAgentService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources.
    /// </remarks>
    public abstract partial class DataAgentServiceClient
    {
        /// <summary>
        /// The default endpoint for the DataAgentService service, which is a host of
        /// "geminidataanalytics.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "geminidataanalytics.googleapis.com:443";

        /// <summary>The default DataAgentService scopes.</summary>
        /// <remarks>
        /// The default DataAgentService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DataAgentService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DataAgentServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DataAgentServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DataAgentServiceClient"/>.</returns>
        public static stt::Task<DataAgentServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DataAgentServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DataAgentServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DataAgentServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DataAgentServiceClient"/>.</returns>
        public static DataAgentServiceClient Create() => new DataAgentServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DataAgentServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DataAgentServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DataAgentServiceClient"/>.</returns>
        internal static DataAgentServiceClient Create(grpccore::CallInvoker callInvoker, DataAgentServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DataAgentService.DataAgentServiceClient grpcClient = new DataAgentService.DataAgentServiceClient(callInvoker);
            return new DataAgentServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DataAgentService client</summary>
        public virtual DataAgentService.DataAgentServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DataAgents in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataAgent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataAgentsResponse, DataAgent> ListDataAgents(ListDataAgentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DataAgents in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataAgent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataAgentsResponse, DataAgent> ListDataAgentsAsync(ListDataAgentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DataAgents in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListDataAgentsRequest.
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
        /// <returns>A pageable sequence of <see cref="DataAgent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataAgentsResponse, DataAgent> ListDataAgents(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataAgentsRequest request = new ListDataAgentsRequest
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
            return ListDataAgents(request, callSettings);
        }

        /// <summary>
        /// Lists DataAgents in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListDataAgentsRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataAgent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataAgentsResponse, DataAgent> ListDataAgentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataAgentsRequest request = new ListDataAgentsRequest
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
            return ListDataAgentsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists DataAgents in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListDataAgentsRequest.
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
        /// <returns>A pageable sequence of <see cref="DataAgent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataAgentsResponse, DataAgent> ListDataAgents(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataAgentsRequest request = new ListDataAgentsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDataAgents(request, callSettings);
        }

        /// <summary>
        /// Lists DataAgents in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListDataAgentsRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataAgent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataAgentsResponse, DataAgent> ListDataAgentsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataAgentsRequest request = new ListDataAgentsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDataAgentsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists DataAgents that are accessible to the caller in a given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataAgent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAccessibleDataAgentsResponse, DataAgent> ListAccessibleDataAgents(ListAccessibleDataAgentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DataAgents that are accessible to the caller in a given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataAgent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAccessibleDataAgentsResponse, DataAgent> ListAccessibleDataAgentsAsync(ListAccessibleDataAgentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DataAgents that are accessible to the caller in a given project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListAccessibleDataAgentsRequest.
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
        /// <returns>A pageable sequence of <see cref="DataAgent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAccessibleDataAgentsResponse, DataAgent> ListAccessibleDataAgents(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAccessibleDataAgentsRequest request = new ListAccessibleDataAgentsRequest
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
            return ListAccessibleDataAgents(request, callSettings);
        }

        /// <summary>
        /// Lists DataAgents that are accessible to the caller in a given project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListAccessibleDataAgentsRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataAgent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAccessibleDataAgentsResponse, DataAgent> ListAccessibleDataAgentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAccessibleDataAgentsRequest request = new ListAccessibleDataAgentsRequest
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
            return ListAccessibleDataAgentsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists DataAgents that are accessible to the caller in a given project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListAccessibleDataAgentsRequest.
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
        /// <returns>A pageable sequence of <see cref="DataAgent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAccessibleDataAgentsResponse, DataAgent> ListAccessibleDataAgents(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAccessibleDataAgentsRequest request = new ListAccessibleDataAgentsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAccessibleDataAgents(request, callSettings);
        }

        /// <summary>
        /// Lists DataAgents that are accessible to the caller in a given project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListAccessibleDataAgentsRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataAgent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAccessibleDataAgentsResponse, DataAgent> ListAccessibleDataAgentsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAccessibleDataAgentsRequest request = new ListAccessibleDataAgentsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAccessibleDataAgentsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single DataAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataAgent GetDataAgent(GetDataAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single DataAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAgent> GetDataAgentAsync(GetDataAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single DataAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAgent> GetDataAgentAsync(GetDataAgentRequest request, st::CancellationToken cancellationToken) =>
            GetDataAgentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single DataAgent.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataAgent GetDataAgent(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataAgent(new GetDataAgentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single DataAgent.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAgent> GetDataAgentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataAgentAsync(new GetDataAgentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single DataAgent.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAgent> GetDataAgentAsync(string name, st::CancellationToken cancellationToken) =>
            GetDataAgentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single DataAgent.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataAgent GetDataAgent(DataAgentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataAgent(new GetDataAgentRequest
            {
                DataAgentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single DataAgent.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAgent> GetDataAgentAsync(DataAgentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataAgentAsync(new GetDataAgentRequest
            {
                DataAgentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single DataAgent.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAgent> GetDataAgentAsync(DataAgentName name, st::CancellationToken cancellationToken) =>
            GetDataAgentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new DataAgent in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataAgent, OperationMetadata> CreateDataAgent(CreateDataAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new DataAgent in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataAgent, OperationMetadata>> CreateDataAgentAsync(CreateDataAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new DataAgent in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataAgent, OperationMetadata>> CreateDataAgentAsync(CreateDataAgentRequest request, st::CancellationToken cancellationToken) =>
            CreateDataAgentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateDataAgent</c>.</summary>
        public virtual lro::OperationsClient CreateDataAgentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateDataAgent</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DataAgent, OperationMetadata> PollOnceCreateDataAgent(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DataAgent, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDataAgentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateDataAgent</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DataAgent, OperationMetadata>> PollOnceCreateDataAgentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DataAgent, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDataAgentOperationsClient, callSettings);

        /// <summary>
        /// Creates a new DataAgent in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="dataAgent">
        /// Required. The resource being created.
        /// </param>
        /// <param name="dataAgentId">
        /// Optional. Id of the requesting object. Must be unique within the parent.
        /// The allowed format is: `^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$`.
        /// If not provided, the server will auto-generate a value for the id.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataAgent, OperationMetadata> CreateDataAgent(string parent, DataAgent dataAgent, string dataAgentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataAgent(new CreateDataAgentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DataAgentId = dataAgentId ?? "",
                DataAgent = gax::GaxPreconditions.CheckNotNull(dataAgent, nameof(dataAgent)),
            }, callSettings);

        /// <summary>
        /// Creates a new DataAgent in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="dataAgent">
        /// Required. The resource being created.
        /// </param>
        /// <param name="dataAgentId">
        /// Optional. Id of the requesting object. Must be unique within the parent.
        /// The allowed format is: `^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$`.
        /// If not provided, the server will auto-generate a value for the id.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataAgent, OperationMetadata>> CreateDataAgentAsync(string parent, DataAgent dataAgent, string dataAgentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataAgentAsync(new CreateDataAgentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DataAgentId = dataAgentId ?? "",
                DataAgent = gax::GaxPreconditions.CheckNotNull(dataAgent, nameof(dataAgent)),
            }, callSettings);

        /// <summary>
        /// Creates a new DataAgent in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="dataAgent">
        /// Required. The resource being created.
        /// </param>
        /// <param name="dataAgentId">
        /// Optional. Id of the requesting object. Must be unique within the parent.
        /// The allowed format is: `^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$`.
        /// If not provided, the server will auto-generate a value for the id.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataAgent, OperationMetadata>> CreateDataAgentAsync(string parent, DataAgent dataAgent, string dataAgentId, st::CancellationToken cancellationToken) =>
            CreateDataAgentAsync(parent, dataAgent, dataAgentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new DataAgent in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="dataAgent">
        /// Required. The resource being created.
        /// </param>
        /// <param name="dataAgentId">
        /// Optional. Id of the requesting object. Must be unique within the parent.
        /// The allowed format is: `^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$`.
        /// If not provided, the server will auto-generate a value for the id.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataAgent, OperationMetadata> CreateDataAgent(gagr::LocationName parent, DataAgent dataAgent, string dataAgentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataAgent(new CreateDataAgentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DataAgentId = dataAgentId ?? "",
                DataAgent = gax::GaxPreconditions.CheckNotNull(dataAgent, nameof(dataAgent)),
            }, callSettings);

        /// <summary>
        /// Creates a new DataAgent in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="dataAgent">
        /// Required. The resource being created.
        /// </param>
        /// <param name="dataAgentId">
        /// Optional. Id of the requesting object. Must be unique within the parent.
        /// The allowed format is: `^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$`.
        /// If not provided, the server will auto-generate a value for the id.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataAgent, OperationMetadata>> CreateDataAgentAsync(gagr::LocationName parent, DataAgent dataAgent, string dataAgentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataAgentAsync(new CreateDataAgentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DataAgentId = dataAgentId ?? "",
                DataAgent = gax::GaxPreconditions.CheckNotNull(dataAgent, nameof(dataAgent)),
            }, callSettings);

        /// <summary>
        /// Creates a new DataAgent in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="dataAgent">
        /// Required. The resource being created.
        /// </param>
        /// <param name="dataAgentId">
        /// Optional. Id of the requesting object. Must be unique within the parent.
        /// The allowed format is: `^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$`.
        /// If not provided, the server will auto-generate a value for the id.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataAgent, OperationMetadata>> CreateDataAgentAsync(gagr::LocationName parent, DataAgent dataAgent, string dataAgentId, st::CancellationToken cancellationToken) =>
            CreateDataAgentAsync(parent, dataAgent, dataAgentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single DataAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataAgent, OperationMetadata> UpdateDataAgent(UpdateDataAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single DataAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataAgent, OperationMetadata>> UpdateDataAgentAsync(UpdateDataAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single DataAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataAgent, OperationMetadata>> UpdateDataAgentAsync(UpdateDataAgentRequest request, st::CancellationToken cancellationToken) =>
            UpdateDataAgentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateDataAgent</c>.</summary>
        public virtual lro::OperationsClient UpdateDataAgentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateDataAgent</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DataAgent, OperationMetadata> PollOnceUpdateDataAgent(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DataAgent, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDataAgentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateDataAgent</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DataAgent, OperationMetadata>> PollOnceUpdateDataAgentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DataAgent, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDataAgentOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single DataAgent.
        /// </summary>
        /// <param name="dataAgent">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// DataAgent resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields with non-default values
        /// present in the request will be overwritten. If a wildcard mask is provided,
        /// all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DataAgent, OperationMetadata> UpdateDataAgent(DataAgent dataAgent, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataAgent(new UpdateDataAgentRequest
            {
                UpdateMask = updateMask,
                DataAgent = gax::GaxPreconditions.CheckNotNull(dataAgent, nameof(dataAgent)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single DataAgent.
        /// </summary>
        /// <param name="dataAgent">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// DataAgent resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields with non-default values
        /// present in the request will be overwritten. If a wildcard mask is provided,
        /// all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataAgent, OperationMetadata>> UpdateDataAgentAsync(DataAgent dataAgent, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataAgentAsync(new UpdateDataAgentRequest
            {
                UpdateMask = updateMask,
                DataAgent = gax::GaxPreconditions.CheckNotNull(dataAgent, nameof(dataAgent)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single DataAgent.
        /// </summary>
        /// <param name="dataAgent">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// DataAgent resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields with non-default values
        /// present in the request will be overwritten. If a wildcard mask is provided,
        /// all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DataAgent, OperationMetadata>> UpdateDataAgentAsync(DataAgent dataAgent, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDataAgentAsync(dataAgent, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single DataAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDataAgent(DeleteDataAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single DataAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataAgentAsync(DeleteDataAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single DataAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataAgentAsync(DeleteDataAgentRequest request, st::CancellationToken cancellationToken) =>
            DeleteDataAgentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteDataAgent</c>.</summary>
        public virtual lro::OperationsClient DeleteDataAgentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteDataAgent</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteDataAgent(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDataAgentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteDataAgent</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteDataAgentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDataAgentOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single DataAgent.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDataAgent(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataAgent(new DeleteDataAgentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single DataAgent.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataAgentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataAgentAsync(new DeleteDataAgentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single DataAgent.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataAgentAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDataAgentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single DataAgent.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDataAgent(DataAgentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataAgent(new DeleteDataAgentRequest
            {
                DataAgentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single DataAgent.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataAgentAsync(DataAgentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataAgentAsync(new DeleteDataAgentRequest
            {
                DataAgentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single DataAgent.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataAgentAsync(DataAgentName name, st::CancellationToken cancellationToken) =>
            DeleteDataAgentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the IAM policy for DataAgent
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the IAM policy for DataAgent
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the IAM policy for DataAgent
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the IAM policy for DataAgent
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new gciv::GetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the IAM policy for DataAgent
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new gciv::GetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the IAM policy for DataAgent
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(string resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the IAM policy for DataAgent
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the IAM policy for DataAgent
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the IAM policy for DataAgent
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gax::IResourceName resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the IAM policy for a DataAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the IAM policy for a DataAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the IAM policy for a DataAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the IAM policy for a DataAgent.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(string resource, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicy(new gciv::SetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Sets the IAM policy for a DataAgent.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(string resource, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyAsync(new gciv::SetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Sets the IAM policy for a DataAgent.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(string resource, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the IAM policy for a DataAgent.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicy(new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Sets the IAM policy for a DataAgent.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyAsync(new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Sets the IAM policy for a DataAgent.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gax::IResourceName resource, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DataAgentService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources.
    /// </remarks>
    public sealed partial class DataAgentServiceClientImpl : DataAgentServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListDataAgentsRequest, ListDataAgentsResponse> _callListDataAgents;

        private readonly gaxgrpc::ApiCall<ListAccessibleDataAgentsRequest, ListAccessibleDataAgentsResponse> _callListAccessibleDataAgents;

        private readonly gaxgrpc::ApiCall<GetDataAgentRequest, DataAgent> _callGetDataAgent;

        private readonly gaxgrpc::ApiCall<CreateDataAgentRequest, lro::Operation> _callCreateDataAgent;

        private readonly gaxgrpc::ApiCall<UpdateDataAgentRequest, lro::Operation> _callUpdateDataAgent;

        private readonly gaxgrpc::ApiCall<DeleteDataAgentRequest, lro::Operation> _callDeleteDataAgent;

        private readonly gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> _callGetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> _callSetIamPolicy;

        /// <summary>
        /// Constructs a client wrapper for the DataAgentService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DataAgentServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DataAgentServiceClientImpl(DataAgentService.DataAgentServiceClient grpcClient, DataAgentServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DataAgentServiceSettings effectiveSettings = settings ?? DataAgentServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateDataAgentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateDataAgentOperationsSettings, logger);
            UpdateDataAgentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateDataAgentOperationsSettings, logger);
            DeleteDataAgentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteDataAgentOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListDataAgents = clientHelper.BuildApiCall<ListDataAgentsRequest, ListDataAgentsResponse>("ListDataAgents", grpcClient.ListDataAgentsAsync, grpcClient.ListDataAgents, effectiveSettings.ListDataAgentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDataAgents);
            Modify_ListDataAgentsApiCall(ref _callListDataAgents);
            _callListAccessibleDataAgents = clientHelper.BuildApiCall<ListAccessibleDataAgentsRequest, ListAccessibleDataAgentsResponse>("ListAccessibleDataAgents", grpcClient.ListAccessibleDataAgentsAsync, grpcClient.ListAccessibleDataAgents, effectiveSettings.ListAccessibleDataAgentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAccessibleDataAgents);
            Modify_ListAccessibleDataAgentsApiCall(ref _callListAccessibleDataAgents);
            _callGetDataAgent = clientHelper.BuildApiCall<GetDataAgentRequest, DataAgent>("GetDataAgent", grpcClient.GetDataAgentAsync, grpcClient.GetDataAgent, effectiveSettings.GetDataAgentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDataAgent);
            Modify_GetDataAgentApiCall(ref _callGetDataAgent);
            _callCreateDataAgent = clientHelper.BuildApiCall<CreateDataAgentRequest, lro::Operation>("CreateDataAgent", grpcClient.CreateDataAgentAsync, grpcClient.CreateDataAgent, effectiveSettings.CreateDataAgentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDataAgent);
            Modify_CreateDataAgentApiCall(ref _callCreateDataAgent);
            _callUpdateDataAgent = clientHelper.BuildApiCall<UpdateDataAgentRequest, lro::Operation>("UpdateDataAgent", grpcClient.UpdateDataAgentAsync, grpcClient.UpdateDataAgent, effectiveSettings.UpdateDataAgentSettings).WithGoogleRequestParam("data_agent.name", request => request.DataAgent?.Name);
            Modify_ApiCall(ref _callUpdateDataAgent);
            Modify_UpdateDataAgentApiCall(ref _callUpdateDataAgent);
            _callDeleteDataAgent = clientHelper.BuildApiCall<DeleteDataAgentRequest, lro::Operation>("DeleteDataAgent", grpcClient.DeleteDataAgentAsync, grpcClient.DeleteDataAgent, effectiveSettings.DeleteDataAgentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDataAgent);
            Modify_DeleteDataAgentApiCall(ref _callDeleteDataAgent);
            _callGetIamPolicy = clientHelper.BuildApiCall<gciv::GetIamPolicyRequest, gciv::Policy>("GetIamPolicy", grpcClient.GetIamPolicyAsync, grpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            _callSetIamPolicy = clientHelper.BuildApiCall<gciv::SetIamPolicyRequest, gciv::Policy>("SetIamPolicy", grpcClient.SetIamPolicyAsync, grpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListDataAgentsApiCall(ref gaxgrpc::ApiCall<ListDataAgentsRequest, ListDataAgentsResponse> call);

        partial void Modify_ListAccessibleDataAgentsApiCall(ref gaxgrpc::ApiCall<ListAccessibleDataAgentsRequest, ListAccessibleDataAgentsResponse> call);

        partial void Modify_GetDataAgentApiCall(ref gaxgrpc::ApiCall<GetDataAgentRequest, DataAgent> call);

        partial void Modify_CreateDataAgentApiCall(ref gaxgrpc::ApiCall<CreateDataAgentRequest, lro::Operation> call);

        partial void Modify_UpdateDataAgentApiCall(ref gaxgrpc::ApiCall<UpdateDataAgentRequest, lro::Operation> call);

        partial void Modify_DeleteDataAgentApiCall(ref gaxgrpc::ApiCall<DeleteDataAgentRequest, lro::Operation> call);

        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> call);

        partial void OnConstruction(DataAgentService.DataAgentServiceClient grpcClient, DataAgentServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DataAgentService client</summary>
        public override DataAgentService.DataAgentServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListDataAgentsRequest(ref ListDataAgentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAccessibleDataAgentsRequest(ref ListAccessibleDataAgentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDataAgentRequest(ref GetDataAgentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateDataAgentRequest(ref CreateDataAgentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDataAgentRequest(ref UpdateDataAgentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDataAgentRequest(ref DeleteDataAgentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIamPolicyRequest(ref gciv::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetIamPolicyRequest(ref gciv::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists DataAgents in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataAgent"/> resources.</returns>
        public override gax::PagedEnumerable<ListDataAgentsResponse, DataAgent> ListDataAgents(ListDataAgentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataAgentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDataAgentsRequest, ListDataAgentsResponse, DataAgent>(_callListDataAgents, request, callSettings);
        }

        /// <summary>
        /// Lists DataAgents in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataAgent"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDataAgentsResponse, DataAgent> ListDataAgentsAsync(ListDataAgentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataAgentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDataAgentsRequest, ListDataAgentsResponse, DataAgent>(_callListDataAgents, request, callSettings);
        }

        /// <summary>
        /// Lists DataAgents that are accessible to the caller in a given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataAgent"/> resources.</returns>
        public override gax::PagedEnumerable<ListAccessibleDataAgentsResponse, DataAgent> ListAccessibleDataAgents(ListAccessibleDataAgentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAccessibleDataAgentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAccessibleDataAgentsRequest, ListAccessibleDataAgentsResponse, DataAgent>(_callListAccessibleDataAgents, request, callSettings);
        }

        /// <summary>
        /// Lists DataAgents that are accessible to the caller in a given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataAgent"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAccessibleDataAgentsResponse, DataAgent> ListAccessibleDataAgentsAsync(ListAccessibleDataAgentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAccessibleDataAgentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAccessibleDataAgentsRequest, ListAccessibleDataAgentsResponse, DataAgent>(_callListAccessibleDataAgents, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single DataAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataAgent GetDataAgent(GetDataAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataAgentRequest(ref request, ref callSettings);
            return _callGetDataAgent.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single DataAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataAgent> GetDataAgentAsync(GetDataAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataAgentRequest(ref request, ref callSettings);
            return _callGetDataAgent.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateDataAgent</c>.</summary>
        public override lro::OperationsClient CreateDataAgentOperationsClient { get; }

        /// <summary>
        /// Creates a new DataAgent in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DataAgent, OperationMetadata> CreateDataAgent(CreateDataAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataAgentRequest(ref request, ref callSettings);
            return new lro::Operation<DataAgent, OperationMetadata>(_callCreateDataAgent.Sync(request, callSettings), CreateDataAgentOperationsClient);
        }

        /// <summary>
        /// Creates a new DataAgent in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DataAgent, OperationMetadata>> CreateDataAgentAsync(CreateDataAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataAgentRequest(ref request, ref callSettings);
            return new lro::Operation<DataAgent, OperationMetadata>(await _callCreateDataAgent.Async(request, callSettings).ConfigureAwait(false), CreateDataAgentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateDataAgent</c>.</summary>
        public override lro::OperationsClient UpdateDataAgentOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single DataAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DataAgent, OperationMetadata> UpdateDataAgent(UpdateDataAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataAgentRequest(ref request, ref callSettings);
            return new lro::Operation<DataAgent, OperationMetadata>(_callUpdateDataAgent.Sync(request, callSettings), UpdateDataAgentOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single DataAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DataAgent, OperationMetadata>> UpdateDataAgentAsync(UpdateDataAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataAgentRequest(ref request, ref callSettings);
            return new lro::Operation<DataAgent, OperationMetadata>(await _callUpdateDataAgent.Async(request, callSettings).ConfigureAwait(false), UpdateDataAgentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteDataAgent</c>.</summary>
        public override lro::OperationsClient DeleteDataAgentOperationsClient { get; }

        /// <summary>
        /// Deletes a single DataAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteDataAgent(DeleteDataAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDataAgentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteDataAgent.Sync(request, callSettings), DeleteDataAgentOperationsClient);
        }

        /// <summary>
        /// Deletes a single DataAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDataAgentAsync(DeleteDataAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDataAgentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteDataAgent.Async(request, callSettings).ConfigureAwait(false), DeleteDataAgentOperationsClient);
        }

        /// <summary>
        /// Gets the IAM policy for DataAgent
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the IAM policy for DataAgent
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the IAM policy for a DataAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the IAM policy for a DataAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Async(request, callSettings);
        }
    }

    public partial class ListDataAgentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAccessibleDataAgentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDataAgentsResponse : gaxgrpc::IPageResponse<DataAgent>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DataAgent> GetEnumerator() => DataAgents.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAccessibleDataAgentsResponse : gaxgrpc::IPageResponse<DataAgent>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DataAgent> GetEnumerator() => DataAgents.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class DataAgentService
    {
        public partial class DataAgentServiceClient
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

    public static partial class DataAgentService
    {
        public partial class DataAgentServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="gcl::Locations.LocationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gcl::Locations.LocationsClient"/> for the same target as this client.
            /// </returns>
            public virtual gcl::Locations.LocationsClient CreateLocationsClient() =>
                new gcl::Locations.LocationsClient(CallInvoker);
        }
    }
}
