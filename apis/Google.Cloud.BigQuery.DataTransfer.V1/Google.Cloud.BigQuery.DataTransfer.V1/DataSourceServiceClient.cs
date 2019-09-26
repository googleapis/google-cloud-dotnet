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
using pb = Google.Protobuf;
using pbwkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.BigQuery.DataTransfer.V1
{
    /// <summary>
    /// Settings for a <see cref="DataSourceServiceClient"/>.
    /// </summary>
    public sealed partial class DataSourceServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="DataSourceServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="DataSourceServiceSettings"/>.
        /// </returns>
        public static DataSourceServiceSettings GetDefault() => new DataSourceServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="DataSourceServiceSettings"/> object with default settings.
        /// </summary>
        public DataSourceServiceSettings() { }

        private DataSourceServiceSettings(DataSourceServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            UpdateTransferRunSettings = existing.UpdateTransferRunSettings;
            LogTransferRunMessagesSettings = existing.LogTransferRunMessagesSettings;
            StartBigQueryJobsSettings = existing.StartBigQueryJobsSettings;
            FinishRunSettings = existing.FinishRunSettings;
            CreateDataSourceDefinitionSettings = existing.CreateDataSourceDefinitionSettings;
            UpdateDataSourceDefinitionSettings = existing.UpdateDataSourceDefinitionSettings;
            DeleteDataSourceDefinitionSettings = existing.DeleteDataSourceDefinitionSettings;
            GetDataSourceDefinitionSettings = existing.GetDataSourceDefinitionSettings;
            ListDataSourceDefinitionsSettings = existing.ListDataSourceDefinitionsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DataSourceServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="DataSourceServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> IdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="DataSourceServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="DataSourceServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="DataSourceServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="DataSourceServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(100),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="DataSourceServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="DataSourceServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="DataSourceServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 20000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(20000),
            maxDelay: sys::TimeSpan.FromMilliseconds(20000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataSourceServiceClient.UpdateTransferRun</c> and <c>DataSourceServiceClient.UpdateTransferRunAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DataSourceServiceClient.UpdateTransferRun</c> and
        /// <c>DataSourceServiceClient.UpdateTransferRunAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings UpdateTransferRunSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataSourceServiceClient.LogTransferRunMessages</c> and <c>DataSourceServiceClient.LogTransferRunMessagesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DataSourceServiceClient.LogTransferRunMessages</c> and
        /// <c>DataSourceServiceClient.LogTransferRunMessagesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings LogTransferRunMessagesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataSourceServiceClient.StartBigQueryJobs</c> and <c>DataSourceServiceClient.StartBigQueryJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DataSourceServiceClient.StartBigQueryJobs</c> and
        /// <c>DataSourceServiceClient.StartBigQueryJobsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings StartBigQueryJobsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataSourceServiceClient.FinishRun</c> and <c>DataSourceServiceClient.FinishRunAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DataSourceServiceClient.FinishRun</c> and
        /// <c>DataSourceServiceClient.FinishRunAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings FinishRunSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataSourceServiceClient.CreateDataSourceDefinition</c> and <c>DataSourceServiceClient.CreateDataSourceDefinitionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DataSourceServiceClient.CreateDataSourceDefinition</c> and
        /// <c>DataSourceServiceClient.CreateDataSourceDefinitionAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings CreateDataSourceDefinitionSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataSourceServiceClient.UpdateDataSourceDefinition</c> and <c>DataSourceServiceClient.UpdateDataSourceDefinitionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DataSourceServiceClient.UpdateDataSourceDefinition</c> and
        /// <c>DataSourceServiceClient.UpdateDataSourceDefinitionAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDataSourceDefinitionSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataSourceServiceClient.DeleteDataSourceDefinition</c> and <c>DataSourceServiceClient.DeleteDataSourceDefinitionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DataSourceServiceClient.DeleteDataSourceDefinition</c> and
        /// <c>DataSourceServiceClient.DeleteDataSourceDefinitionAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDataSourceDefinitionSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataSourceServiceClient.GetDataSourceDefinition</c> and <c>DataSourceServiceClient.GetDataSourceDefinitionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DataSourceServiceClient.GetDataSourceDefinition</c> and
        /// <c>DataSourceServiceClient.GetDataSourceDefinitionAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetDataSourceDefinitionSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataSourceServiceClient.ListDataSourceDefinitions</c> and <c>DataSourceServiceClient.ListDataSourceDefinitionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>DataSourceServiceClient.ListDataSourceDefinitions</c> and
        /// <c>DataSourceServiceClient.ListDataSourceDefinitionsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListDataSourceDefinitionsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="DataSourceServiceSettings"/> object.</returns>
        public DataSourceServiceSettings Clone() => new DataSourceServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DataSourceServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class DataSourceServiceClientBuilder : gaxgrpc::ClientBuilderBase<DataSourceServiceClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public DataSourceServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override DataSourceServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DataSourceServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<DataSourceServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DataSourceServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => DataSourceServiceClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => DataSourceServiceClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => DataSourceServiceClient.ChannelPool;
    }

    /// <summary>
    /// DataSourceService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class DataSourceServiceClient
    {
        /// <summary>
        /// The default endpoint for the DataSourceService service, which is a host of "bigquerydatatransfer.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("bigquerydatatransfer.googleapis.com", 443);

        /// <summary>
        /// The default DataSourceService scopes.
        /// </summary>
        /// <remarks>
        /// The default DataSourceService scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="DataSourceServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.BigQuery.DataTransfer.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// DataSourceServiceClient client = await DataSourceServiceClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.BigQuery.DataTransfer.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     DataSourceServiceClient.DefaultEndpoint.Host, DataSourceServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// DataSourceServiceClient client = DataSourceServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="DataSourceServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="DataSourceServiceClient"/>.</returns>
        public static async stt::Task<DataSourceServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, DataSourceServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="DataSourceServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.BigQuery.DataTransfer.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// DataSourceServiceClient client = DataSourceServiceClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.BigQuery.DataTransfer.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     DataSourceServiceClient.DefaultEndpoint.Host, DataSourceServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// DataSourceServiceClient client = DataSourceServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="DataSourceServiceSettings"/>.</param>
        /// <returns>The created <see cref="DataSourceServiceClient"/>.</returns>
        public static DataSourceServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, DataSourceServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="DataSourceServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="DataSourceServiceSettings"/>.</param>
        /// <returns>The created <see cref="DataSourceServiceClient"/>.</returns>
        public static DataSourceServiceClient Create(grpccore::Channel channel, DataSourceServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="DataSourceServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="DataSourceServiceSettings"/>.</param>
        /// <returns>The created <see cref="DataSourceServiceClient"/>.</returns>
        public static DataSourceServiceClient Create(grpccore::CallInvoker callInvoker, DataSourceServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DataSourceService.DataSourceServiceClient grpcClient = new DataSourceService.DataSourceServiceClient(callInvoker);
            return new DataSourceServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, DataSourceServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, DataSourceServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, DataSourceServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, DataSourceServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC DataSourceService client.
        /// </summary>
        public virtual DataSourceService.DataSourceServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Update a transfer run. If successful, resets
        /// data_source.update_deadline_seconds timer.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<TransferRun> UpdateTransferRunAsync(
            UpdateTransferRunRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Update a transfer run. If successful, resets
        /// data_source.update_deadline_seconds timer.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<TransferRun> UpdateTransferRunAsync(
            UpdateTransferRunRequest request,
            st::CancellationToken cancellationToken) => UpdateTransferRunAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a transfer run. If successful, resets
        /// data_source.update_deadline_seconds timer.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual TransferRun UpdateTransferRun(
            UpdateTransferRunRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Log messages for a transfer run. If successful (at least 1 message), resets
        /// data_source.update_deadline_seconds timer.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task LogTransferRunMessagesAsync(
            LogTransferRunMessagesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Log messages for a transfer run. If successful (at least 1 message), resets
        /// data_source.update_deadline_seconds timer.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task LogTransferRunMessagesAsync(
            LogTransferRunMessagesRequest request,
            st::CancellationToken cancellationToken) => LogTransferRunMessagesAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Log messages for a transfer run. If successful (at least 1 message), resets
        /// data_source.update_deadline_seconds timer.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void LogTransferRunMessages(
            LogTransferRunMessagesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Notify the Data Transfer Service that data is ready for loading.
        /// The Data Transfer Service will start and monitor multiple BigQuery Load
        /// jobs for a transfer run. Monitored jobs will be automatically retried
        /// and produce log messages when starting and finishing a job.
        /// Can be called multiple times for the same transfer run.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task StartBigQueryJobsAsync(
            StartBigQueryJobsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Notify the Data Transfer Service that data is ready for loading.
        /// The Data Transfer Service will start and monitor multiple BigQuery Load
        /// jobs for a transfer run. Monitored jobs will be automatically retried
        /// and produce log messages when starting and finishing a job.
        /// Can be called multiple times for the same transfer run.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task StartBigQueryJobsAsync(
            StartBigQueryJobsRequest request,
            st::CancellationToken cancellationToken) => StartBigQueryJobsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Notify the Data Transfer Service that data is ready for loading.
        /// The Data Transfer Service will start and monitor multiple BigQuery Load
        /// jobs for a transfer run. Monitored jobs will be automatically retried
        /// and produce log messages when starting and finishing a job.
        /// Can be called multiple times for the same transfer run.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void StartBigQueryJobs(
            StartBigQueryJobsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Notify the Data Transfer Service that the data source is done processing
        /// the run. No more status updates or requests to start/monitor jobs will be
        /// accepted. The run will be finalized by the Data Transfer Service when all
        /// monitored jobs are completed.
        /// Does not need to be called if the run is set to FAILED.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task FinishRunAsync(
            FinishRunRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Notify the Data Transfer Service that the data source is done processing
        /// the run. No more status updates or requests to start/monitor jobs will be
        /// accepted. The run will be finalized by the Data Transfer Service when all
        /// monitored jobs are completed.
        /// Does not need to be called if the run is set to FAILED.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task FinishRunAsync(
            FinishRunRequest request,
            st::CancellationToken cancellationToken) => FinishRunAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Notify the Data Transfer Service that the data source is done processing
        /// the run. No more status updates or requests to start/monitor jobs will be
        /// accepted. The run will be finalized by the Data Transfer Service when all
        /// monitored jobs are completed.
        /// Does not need to be called if the run is set to FAILED.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void FinishRun(
            FinishRunRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a data source definition.  Calling this method will automatically
        /// use your credentials to create the following Google Cloud resources in
        /// YOUR Google Cloud project.
        /// 1. OAuth client
        /// 2. Pub/Sub Topics and Subscriptions in each supported_location_ids. e.g.,
        /// projects/{project_id}/{topics|subscriptions}/bigquerydatatransfer.{data_source_id}.{location_id}.run
        /// The field data_source.client_id should be left empty in the input request,
        /// as the API will create a new OAuth client on behalf of the caller. On the
        /// other hand data_source.scopes usually need to be set when there are OAuth
        /// scopes that need to be granted by end users.
        /// 3. We need a longer deadline due to the 60 seconds SLO from Pub/Sub admin
        /// Operations. This also applies to update and delete data source definition.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<DataSourceDefinition> CreateDataSourceDefinitionAsync(
            CreateDataSourceDefinitionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a data source definition.  Calling this method will automatically
        /// use your credentials to create the following Google Cloud resources in
        /// YOUR Google Cloud project.
        /// 1. OAuth client
        /// 2. Pub/Sub Topics and Subscriptions in each supported_location_ids. e.g.,
        /// projects/{project_id}/{topics|subscriptions}/bigquerydatatransfer.{data_source_id}.{location_id}.run
        /// The field data_source.client_id should be left empty in the input request,
        /// as the API will create a new OAuth client on behalf of the caller. On the
        /// other hand data_source.scopes usually need to be set when there are OAuth
        /// scopes that need to be granted by end users.
        /// 3. We need a longer deadline due to the 60 seconds SLO from Pub/Sub admin
        /// Operations. This also applies to update and delete data source definition.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<DataSourceDefinition> CreateDataSourceDefinitionAsync(
            CreateDataSourceDefinitionRequest request,
            st::CancellationToken cancellationToken) => CreateDataSourceDefinitionAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a data source definition.  Calling this method will automatically
        /// use your credentials to create the following Google Cloud resources in
        /// YOUR Google Cloud project.
        /// 1. OAuth client
        /// 2. Pub/Sub Topics and Subscriptions in each supported_location_ids. e.g.,
        /// projects/{project_id}/{topics|subscriptions}/bigquerydatatransfer.{data_source_id}.{location_id}.run
        /// The field data_source.client_id should be left empty in the input request,
        /// as the API will create a new OAuth client on behalf of the caller. On the
        /// other hand data_source.scopes usually need to be set when there are OAuth
        /// scopes that need to be granted by end users.
        /// 3. We need a longer deadline due to the 60 seconds SLO from Pub/Sub admin
        /// Operations. This also applies to update and delete data source definition.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual DataSourceDefinition CreateDataSourceDefinition(
            CreateDataSourceDefinitionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates an existing data source definition. If changing
        /// supported_location_ids, triggers same effects as mentioned in "Create a
        /// data source definition."
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<DataSourceDefinition> UpdateDataSourceDefinitionAsync(
            UpdateDataSourceDefinitionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates an existing data source definition. If changing
        /// supported_location_ids, triggers same effects as mentioned in "Create a
        /// data source definition."
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<DataSourceDefinition> UpdateDataSourceDefinitionAsync(
            UpdateDataSourceDefinitionRequest request,
            st::CancellationToken cancellationToken) => UpdateDataSourceDefinitionAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing data source definition. If changing
        /// supported_location_ids, triggers same effects as mentioned in "Create a
        /// data source definition."
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual DataSourceDefinition UpdateDataSourceDefinition(
            UpdateDataSourceDefinitionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes a data source definition, all of the transfer configs associated
        /// with this data source definition (if any) must be deleted first by the user
        /// in ALL regions, in order to delete the data source definition.
        /// This method is primarily meant for deleting data sources created during
        /// testing stage.
        /// If the data source is referenced by transfer configs in the region
        /// specified in the request URL, the method will fail immediately. If in the
        /// current region (e.g., US) it's not used by any transfer configs, but in
        /// another region (e.g., EU) it is, then although the method will succeed in
        /// region US, but it will fail when the deletion operation is replicated to
        /// region EU. And eventually, the system will replicate the data source
        /// definition back from EU to US, in order to bring all regions to
        /// consistency. The final effect is that the data source appears to be
        /// 'undeleted' in the US region.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteDataSourceDefinitionAsync(
            DeleteDataSourceDefinitionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes a data source definition, all of the transfer configs associated
        /// with this data source definition (if any) must be deleted first by the user
        /// in ALL regions, in order to delete the data source definition.
        /// This method is primarily meant for deleting data sources created during
        /// testing stage.
        /// If the data source is referenced by transfer configs in the region
        /// specified in the request URL, the method will fail immediately. If in the
        /// current region (e.g., US) it's not used by any transfer configs, but in
        /// another region (e.g., EU) it is, then although the method will succeed in
        /// region US, but it will fail when the deletion operation is replicated to
        /// region EU. And eventually, the system will replicate the data source
        /// definition back from EU to US, in order to bring all regions to
        /// consistency. The final effect is that the data source appears to be
        /// 'undeleted' in the US region.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteDataSourceDefinitionAsync(
            DeleteDataSourceDefinitionRequest request,
            st::CancellationToken cancellationToken) => DeleteDataSourceDefinitionAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a data source definition, all of the transfer configs associated
        /// with this data source definition (if any) must be deleted first by the user
        /// in ALL regions, in order to delete the data source definition.
        /// This method is primarily meant for deleting data sources created during
        /// testing stage.
        /// If the data source is referenced by transfer configs in the region
        /// specified in the request URL, the method will fail immediately. If in the
        /// current region (e.g., US) it's not used by any transfer configs, but in
        /// another region (e.g., EU) it is, then although the method will succeed in
        /// region US, but it will fail when the deletion operation is replicated to
        /// region EU. And eventually, the system will replicate the data source
        /// definition back from EU to US, in order to bring all regions to
        /// consistency. The final effect is that the data source appears to be
        /// 'undeleted' in the US region.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteDataSourceDefinition(
            DeleteDataSourceDefinitionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Retrieves an existing data source definition.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<DataSourceDefinition> GetDataSourceDefinitionAsync(
            GetDataSourceDefinitionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Retrieves an existing data source definition.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<DataSourceDefinition> GetDataSourceDefinitionAsync(
            GetDataSourceDefinitionRequest request,
            st::CancellationToken cancellationToken) => GetDataSourceDefinitionAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves an existing data source definition.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual DataSourceDefinition GetDataSourceDefinition(
            GetDataSourceDefinitionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists supported data source definitions.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="DataSourceDefinition"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListDataSourceDefinitionsResponse, DataSourceDefinition> ListDataSourceDefinitionsAsync(
            ListDataSourceDefinitionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists supported data source definitions.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="DataSourceDefinition"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListDataSourceDefinitionsResponse, DataSourceDefinition> ListDataSourceDefinitions(
            ListDataSourceDefinitionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// DataSourceService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class DataSourceServiceClientImpl : DataSourceServiceClient
    {
        private readonly gaxgrpc::ApiCall<UpdateTransferRunRequest, TransferRun> _callUpdateTransferRun;
        private readonly gaxgrpc::ApiCall<LogTransferRunMessagesRequest, pbwkt::Empty> _callLogTransferRunMessages;
        private readonly gaxgrpc::ApiCall<StartBigQueryJobsRequest, pbwkt::Empty> _callStartBigQueryJobs;
        private readonly gaxgrpc::ApiCall<FinishRunRequest, pbwkt::Empty> _callFinishRun;
        private readonly gaxgrpc::ApiCall<CreateDataSourceDefinitionRequest, DataSourceDefinition> _callCreateDataSourceDefinition;
        private readonly gaxgrpc::ApiCall<UpdateDataSourceDefinitionRequest, DataSourceDefinition> _callUpdateDataSourceDefinition;
        private readonly gaxgrpc::ApiCall<DeleteDataSourceDefinitionRequest, pbwkt::Empty> _callDeleteDataSourceDefinition;
        private readonly gaxgrpc::ApiCall<GetDataSourceDefinitionRequest, DataSourceDefinition> _callGetDataSourceDefinition;
        private readonly gaxgrpc::ApiCall<ListDataSourceDefinitionsRequest, ListDataSourceDefinitionsResponse> _callListDataSourceDefinitions;

        /// <summary>
        /// Constructs a client wrapper for the DataSourceService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DataSourceServiceSettings"/> used within this client </param>
        public DataSourceServiceClientImpl(DataSourceService.DataSourceServiceClient grpcClient, DataSourceServiceSettings settings)
        {
            GrpcClient = grpcClient;
            DataSourceServiceSettings effectiveSettings = settings ?? DataSourceServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callUpdateTransferRun = clientHelper.BuildApiCall<UpdateTransferRunRequest, TransferRun>(
                GrpcClient.UpdateTransferRunAsync, GrpcClient.UpdateTransferRun, effectiveSettings.UpdateTransferRunSettings)
                .WithGoogleRequestParam("transfer_run.name", request => request.TransferRun?.Name);
            _callLogTransferRunMessages = clientHelper.BuildApiCall<LogTransferRunMessagesRequest, pbwkt::Empty>(
                GrpcClient.LogTransferRunMessagesAsync, GrpcClient.LogTransferRunMessages, effectiveSettings.LogTransferRunMessagesSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callStartBigQueryJobs = clientHelper.BuildApiCall<StartBigQueryJobsRequest, pbwkt::Empty>(
                GrpcClient.StartBigQueryJobsAsync, GrpcClient.StartBigQueryJobs, effectiveSettings.StartBigQueryJobsSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callFinishRun = clientHelper.BuildApiCall<FinishRunRequest, pbwkt::Empty>(
                GrpcClient.FinishRunAsync, GrpcClient.FinishRun, effectiveSettings.FinishRunSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callCreateDataSourceDefinition = clientHelper.BuildApiCall<CreateDataSourceDefinitionRequest, DataSourceDefinition>(
                GrpcClient.CreateDataSourceDefinitionAsync, GrpcClient.CreateDataSourceDefinition, effectiveSettings.CreateDataSourceDefinitionSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callUpdateDataSourceDefinition = clientHelper.BuildApiCall<UpdateDataSourceDefinitionRequest, DataSourceDefinition>(
                GrpcClient.UpdateDataSourceDefinitionAsync, GrpcClient.UpdateDataSourceDefinition, effectiveSettings.UpdateDataSourceDefinitionSettings)
                .WithGoogleRequestParam("data_source_definition.name", request => request.DataSourceDefinition?.Name);
            _callDeleteDataSourceDefinition = clientHelper.BuildApiCall<DeleteDataSourceDefinitionRequest, pbwkt::Empty>(
                GrpcClient.DeleteDataSourceDefinitionAsync, GrpcClient.DeleteDataSourceDefinition, effectiveSettings.DeleteDataSourceDefinitionSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callGetDataSourceDefinition = clientHelper.BuildApiCall<GetDataSourceDefinitionRequest, DataSourceDefinition>(
                GrpcClient.GetDataSourceDefinitionAsync, GrpcClient.GetDataSourceDefinition, effectiveSettings.GetDataSourceDefinitionSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callListDataSourceDefinitions = clientHelper.BuildApiCall<ListDataSourceDefinitionsRequest, ListDataSourceDefinitionsResponse>(
                GrpcClient.ListDataSourceDefinitionsAsync, GrpcClient.ListDataSourceDefinitions, effectiveSettings.ListDataSourceDefinitionsSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callUpdateTransferRun);
            Modify_UpdateTransferRunApiCall(ref _callUpdateTransferRun);
            Modify_ApiCall(ref _callLogTransferRunMessages);
            Modify_LogTransferRunMessagesApiCall(ref _callLogTransferRunMessages);
            Modify_ApiCall(ref _callStartBigQueryJobs);
            Modify_StartBigQueryJobsApiCall(ref _callStartBigQueryJobs);
            Modify_ApiCall(ref _callFinishRun);
            Modify_FinishRunApiCall(ref _callFinishRun);
            Modify_ApiCall(ref _callCreateDataSourceDefinition);
            Modify_CreateDataSourceDefinitionApiCall(ref _callCreateDataSourceDefinition);
            Modify_ApiCall(ref _callUpdateDataSourceDefinition);
            Modify_UpdateDataSourceDefinitionApiCall(ref _callUpdateDataSourceDefinition);
            Modify_ApiCall(ref _callDeleteDataSourceDefinition);
            Modify_DeleteDataSourceDefinitionApiCall(ref _callDeleteDataSourceDefinition);
            Modify_ApiCall(ref _callGetDataSourceDefinition);
            Modify_GetDataSourceDefinitionApiCall(ref _callGetDataSourceDefinition);
            Modify_ApiCall(ref _callListDataSourceDefinitions);
            Modify_ListDataSourceDefinitionsApiCall(ref _callListDataSourceDefinitions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        // Partial methods are named to (mostly) ensure there cannot be conflicts with RPC method names.

        // Partial methods called for every ApiCall on construction.
        // Allows modification of all the underlying ApiCall objects.
        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call)
            where TRequest : class, pb::IMessage<TRequest>
            where TResponse : class, pb::IMessage<TResponse>;

        // Partial methods called for each ApiCall on construction.
        // Allows per-RPC-method modification of the underlying ApiCall object.
        partial void Modify_UpdateTransferRunApiCall(ref gaxgrpc::ApiCall<UpdateTransferRunRequest, TransferRun> call);
        partial void Modify_LogTransferRunMessagesApiCall(ref gaxgrpc::ApiCall<LogTransferRunMessagesRequest, pbwkt::Empty> call);
        partial void Modify_StartBigQueryJobsApiCall(ref gaxgrpc::ApiCall<StartBigQueryJobsRequest, pbwkt::Empty> call);
        partial void Modify_FinishRunApiCall(ref gaxgrpc::ApiCall<FinishRunRequest, pbwkt::Empty> call);
        partial void Modify_CreateDataSourceDefinitionApiCall(ref gaxgrpc::ApiCall<CreateDataSourceDefinitionRequest, DataSourceDefinition> call);
        partial void Modify_UpdateDataSourceDefinitionApiCall(ref gaxgrpc::ApiCall<UpdateDataSourceDefinitionRequest, DataSourceDefinition> call);
        partial void Modify_DeleteDataSourceDefinitionApiCall(ref gaxgrpc::ApiCall<DeleteDataSourceDefinitionRequest, pbwkt::Empty> call);
        partial void Modify_GetDataSourceDefinitionApiCall(ref gaxgrpc::ApiCall<GetDataSourceDefinitionRequest, DataSourceDefinition> call);
        partial void Modify_ListDataSourceDefinitionsApiCall(ref gaxgrpc::ApiCall<ListDataSourceDefinitionsRequest, ListDataSourceDefinitionsResponse> call);
        partial void OnConstruction(DataSourceService.DataSourceServiceClient grpcClient, DataSourceServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC DataSourceService client.
        /// </summary>
        public override DataSourceService.DataSourceServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_UpdateTransferRunRequest(ref UpdateTransferRunRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_LogTransferRunMessagesRequest(ref LogTransferRunMessagesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_StartBigQueryJobsRequest(ref StartBigQueryJobsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_FinishRunRequest(ref FinishRunRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateDataSourceDefinitionRequest(ref CreateDataSourceDefinitionRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateDataSourceDefinitionRequest(ref UpdateDataSourceDefinitionRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteDataSourceDefinitionRequest(ref DeleteDataSourceDefinitionRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetDataSourceDefinitionRequest(ref GetDataSourceDefinitionRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListDataSourceDefinitionsRequest(ref ListDataSourceDefinitionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Update a transfer run. If successful, resets
        /// data_source.update_deadline_seconds timer.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<TransferRun> UpdateTransferRunAsync(
            UpdateTransferRunRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTransferRunRequest(ref request, ref callSettings);
            return _callUpdateTransferRun.Async(request, callSettings);
        }

        /// <summary>
        /// Update a transfer run. If successful, resets
        /// data_source.update_deadline_seconds timer.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override TransferRun UpdateTransferRun(
            UpdateTransferRunRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTransferRunRequest(ref request, ref callSettings);
            return _callUpdateTransferRun.Sync(request, callSettings);
        }

        /// <summary>
        /// Log messages for a transfer run. If successful (at least 1 message), resets
        /// data_source.update_deadline_seconds timer.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public override stt::Task LogTransferRunMessagesAsync(
            LogTransferRunMessagesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LogTransferRunMessagesRequest(ref request, ref callSettings);
            return _callLogTransferRunMessages.Async(request, callSettings);
        }

        /// <summary>
        /// Log messages for a transfer run. If successful (at least 1 message), resets
        /// data_source.update_deadline_seconds timer.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void LogTransferRunMessages(
            LogTransferRunMessagesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LogTransferRunMessagesRequest(ref request, ref callSettings);
            _callLogTransferRunMessages.Sync(request, callSettings);
        }

        /// <summary>
        /// Notify the Data Transfer Service that data is ready for loading.
        /// The Data Transfer Service will start and monitor multiple BigQuery Load
        /// jobs for a transfer run. Monitored jobs will be automatically retried
        /// and produce log messages when starting and finishing a job.
        /// Can be called multiple times for the same transfer run.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public override stt::Task StartBigQueryJobsAsync(
            StartBigQueryJobsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartBigQueryJobsRequest(ref request, ref callSettings);
            return _callStartBigQueryJobs.Async(request, callSettings);
        }

        /// <summary>
        /// Notify the Data Transfer Service that data is ready for loading.
        /// The Data Transfer Service will start and monitor multiple BigQuery Load
        /// jobs for a transfer run. Monitored jobs will be automatically retried
        /// and produce log messages when starting and finishing a job.
        /// Can be called multiple times for the same transfer run.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void StartBigQueryJobs(
            StartBigQueryJobsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartBigQueryJobsRequest(ref request, ref callSettings);
            _callStartBigQueryJobs.Sync(request, callSettings);
        }

        /// <summary>
        /// Notify the Data Transfer Service that the data source is done processing
        /// the run. No more status updates or requests to start/monitor jobs will be
        /// accepted. The run will be finalized by the Data Transfer Service when all
        /// monitored jobs are completed.
        /// Does not need to be called if the run is set to FAILED.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public override stt::Task FinishRunAsync(
            FinishRunRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FinishRunRequest(ref request, ref callSettings);
            return _callFinishRun.Async(request, callSettings);
        }

        /// <summary>
        /// Notify the Data Transfer Service that the data source is done processing
        /// the run. No more status updates or requests to start/monitor jobs will be
        /// accepted. The run will be finalized by the Data Transfer Service when all
        /// monitored jobs are completed.
        /// Does not need to be called if the run is set to FAILED.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void FinishRun(
            FinishRunRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FinishRunRequest(ref request, ref callSettings);
            _callFinishRun.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a data source definition.  Calling this method will automatically
        /// use your credentials to create the following Google Cloud resources in
        /// YOUR Google Cloud project.
        /// 1. OAuth client
        /// 2. Pub/Sub Topics and Subscriptions in each supported_location_ids. e.g.,
        /// projects/{project_id}/{topics|subscriptions}/bigquerydatatransfer.{data_source_id}.{location_id}.run
        /// The field data_source.client_id should be left empty in the input request,
        /// as the API will create a new OAuth client on behalf of the caller. On the
        /// other hand data_source.scopes usually need to be set when there are OAuth
        /// scopes that need to be granted by end users.
        /// 3. We need a longer deadline due to the 60 seconds SLO from Pub/Sub admin
        /// Operations. This also applies to update and delete data source definition.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<DataSourceDefinition> CreateDataSourceDefinitionAsync(
            CreateDataSourceDefinitionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataSourceDefinitionRequest(ref request, ref callSettings);
            return _callCreateDataSourceDefinition.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a data source definition.  Calling this method will automatically
        /// use your credentials to create the following Google Cloud resources in
        /// YOUR Google Cloud project.
        /// 1. OAuth client
        /// 2. Pub/Sub Topics and Subscriptions in each supported_location_ids. e.g.,
        /// projects/{project_id}/{topics|subscriptions}/bigquerydatatransfer.{data_source_id}.{location_id}.run
        /// The field data_source.client_id should be left empty in the input request,
        /// as the API will create a new OAuth client on behalf of the caller. On the
        /// other hand data_source.scopes usually need to be set when there are OAuth
        /// scopes that need to be granted by end users.
        /// 3. We need a longer deadline due to the 60 seconds SLO from Pub/Sub admin
        /// Operations. This also applies to update and delete data source definition.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override DataSourceDefinition CreateDataSourceDefinition(
            CreateDataSourceDefinitionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataSourceDefinitionRequest(ref request, ref callSettings);
            return _callCreateDataSourceDefinition.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an existing data source definition. If changing
        /// supported_location_ids, triggers same effects as mentioned in "Create a
        /// data source definition."
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<DataSourceDefinition> UpdateDataSourceDefinitionAsync(
            UpdateDataSourceDefinitionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataSourceDefinitionRequest(ref request, ref callSettings);
            return _callUpdateDataSourceDefinition.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an existing data source definition. If changing
        /// supported_location_ids, triggers same effects as mentioned in "Create a
        /// data source definition."
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override DataSourceDefinition UpdateDataSourceDefinition(
            UpdateDataSourceDefinitionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataSourceDefinitionRequest(ref request, ref callSettings);
            return _callUpdateDataSourceDefinition.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a data source definition, all of the transfer configs associated
        /// with this data source definition (if any) must be deleted first by the user
        /// in ALL regions, in order to delete the data source definition.
        /// This method is primarily meant for deleting data sources created during
        /// testing stage.
        /// If the data source is referenced by transfer configs in the region
        /// specified in the request URL, the method will fail immediately. If in the
        /// current region (e.g., US) it's not used by any transfer configs, but in
        /// another region (e.g., EU) it is, then although the method will succeed in
        /// region US, but it will fail when the deletion operation is replicated to
        /// region EU. And eventually, the system will replicate the data source
        /// definition back from EU to US, in order to bring all regions to
        /// consistency. The final effect is that the data source appears to be
        /// 'undeleted' in the US region.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public override stt::Task DeleteDataSourceDefinitionAsync(
            DeleteDataSourceDefinitionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDataSourceDefinitionRequest(ref request, ref callSettings);
            return _callDeleteDataSourceDefinition.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a data source definition, all of the transfer configs associated
        /// with this data source definition (if any) must be deleted first by the user
        /// in ALL regions, in order to delete the data source definition.
        /// This method is primarily meant for deleting data sources created during
        /// testing stage.
        /// If the data source is referenced by transfer configs in the region
        /// specified in the request URL, the method will fail immediately. If in the
        /// current region (e.g., US) it's not used by any transfer configs, but in
        /// another region (e.g., EU) it is, then although the method will succeed in
        /// region US, but it will fail when the deletion operation is replicated to
        /// region EU. And eventually, the system will replicate the data source
        /// definition back from EU to US, in order to bring all regions to
        /// consistency. The final effect is that the data source appears to be
        /// 'undeleted' in the US region.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteDataSourceDefinition(
            DeleteDataSourceDefinitionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDataSourceDefinitionRequest(ref request, ref callSettings);
            _callDeleteDataSourceDefinition.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves an existing data source definition.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<DataSourceDefinition> GetDataSourceDefinitionAsync(
            GetDataSourceDefinitionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataSourceDefinitionRequest(ref request, ref callSettings);
            return _callGetDataSourceDefinition.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves an existing data source definition.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override DataSourceDefinition GetDataSourceDefinition(
            GetDataSourceDefinitionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataSourceDefinitionRequest(ref request, ref callSettings);
            return _callGetDataSourceDefinition.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists supported data source definitions.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="DataSourceDefinition"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListDataSourceDefinitionsResponse, DataSourceDefinition> ListDataSourceDefinitionsAsync(
            ListDataSourceDefinitionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataSourceDefinitionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDataSourceDefinitionsRequest, ListDataSourceDefinitionsResponse, DataSourceDefinition>(_callListDataSourceDefinitions, request, callSettings);
        }

        /// <summary>
        /// Lists supported data source definitions.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="DataSourceDefinition"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListDataSourceDefinitionsResponse, DataSourceDefinition> ListDataSourceDefinitions(
            ListDataSourceDefinitionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataSourceDefinitionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDataSourceDefinitionsRequest, ListDataSourceDefinitionsResponse, DataSourceDefinition>(_callListDataSourceDefinitions, request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListDataSourceDefinitionsRequest : gaxgrpc::IPageRequest { }
    public partial class ListDataSourceDefinitionsResponse : gaxgrpc::IPageResponse<DataSourceDefinition>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<DataSourceDefinition> GetEnumerator() => DataSourceDefinitions.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
