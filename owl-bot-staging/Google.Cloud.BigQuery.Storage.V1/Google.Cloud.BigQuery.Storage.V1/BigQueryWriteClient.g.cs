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
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.BigQuery.Storage.V1
{
    /// <summary>Settings for <see cref="BigQueryWriteClient"/> instances.</summary>
    public sealed partial class BigQueryWriteSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BigQueryWriteSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BigQueryWriteSettings"/>.</returns>
        public static BigQueryWriteSettings GetDefault() => new BigQueryWriteSettings();

        /// <summary>Constructs a new <see cref="BigQueryWriteSettings"/> object with default settings.</summary>
        public BigQueryWriteSettings()
        {
        }

        private BigQueryWriteSettings(BigQueryWriteSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateWriteStreamSettings = existing.CreateWriteStreamSettings;
            AppendRowsSettings = existing.AppendRowsSettings;
            AppendRowsStreamingSettings = existing.AppendRowsStreamingSettings;
            GetWriteStreamSettings = existing.GetWriteStreamSettings;
            FinalizeWriteStreamSettings = existing.FinalizeWriteStreamSettings;
            BatchCommitWriteStreamsSettings = existing.BatchCommitWriteStreamsSettings;
            FlushRowsSettings = existing.FlushRowsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BigQueryWriteSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigQueryWriteClient.CreateWriteStream</c> and <c>BigQueryWriteClient.CreateWriteStreamAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 10000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 120000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.ResourceExhausted"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 1200 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateWriteStreamSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(1200000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(10000), maxBackoff: sys::TimeSpan.FromMilliseconds(120000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigQueryWriteClient.AppendRows</c> and <c>BigQueryWriteClient.AppendRowsAsync</c>.
        /// </summary>
        /// <remarks>Timeout: 86400 seconds.</remarks>
        public gaxgrpc::CallSettings AppendRowsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(86400000)));

        /// <summary>
        /// <see cref="gaxgrpc::BidirectionalStreamingSettings"/> for calls to <c>BigQueryWriteClient.AppendRows</c> and
        /// <c>BigQueryWriteClient.AppendRowsAsync</c>.
        /// </summary>
        /// <remarks>The default local send queue size is 100.</remarks>
        public gaxgrpc::BidirectionalStreamingSettings AppendRowsStreamingSettings { get; set; } = new gaxgrpc::BidirectionalStreamingSettings(100);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigQueryWriteClient.GetWriteStream</c> and <c>BigQueryWriteClient.GetWriteStreamAsync</c>.
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
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.ResourceExhausted"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetWriteStreamSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigQueryWriteClient.FinalizeWriteStream</c> and <c>BigQueryWriteClient.FinalizeWriteStreamAsync</c>.
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
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.ResourceExhausted"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FinalizeWriteStreamSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigQueryWriteClient.BatchCommitWriteStreams</c> and <c>BigQueryWriteClient.BatchCommitWriteStreamsAsync</c>
        /// .
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
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.ResourceExhausted"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCommitWriteStreamsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigQueryWriteClient.FlushRows</c> and <c>BigQueryWriteClient.FlushRowsAsync</c>.
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
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.ResourceExhausted"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FlushRowsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BigQueryWriteSettings"/> object.</returns>
        public BigQueryWriteSettings Clone() => new BigQueryWriteSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BigQueryWriteClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class BigQueryWriteClientBuilder : gaxgrpc::ClientBuilderBase<BigQueryWriteClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BigQueryWriteSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public BigQueryWriteClientBuilder() : base(BigQueryWriteClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref BigQueryWriteClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<BigQueryWriteClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override BigQueryWriteClient Build()
        {
            BigQueryWriteClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<BigQueryWriteClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<BigQueryWriteClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private BigQueryWriteClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BigQueryWriteClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<BigQueryWriteClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BigQueryWriteClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BigQueryWriteClient.ChannelPool;
    }

    /// <summary>BigQueryWrite client wrapper, for convenient use.</summary>
    /// <remarks>
    /// BigQuery Write API.
    /// 
    /// The Write API can be used to write data to BigQuery.
    /// 
    /// For supplementary information about the Write API, see:
    /// https://cloud.google.com/bigquery/docs/write-api
    /// </remarks>
    public abstract partial class BigQueryWriteClient
    {
        /// <summary>
        /// The default endpoint for the BigQueryWrite service, which is a host of "bigquerystorage.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "bigquerystorage.googleapis.com:443";

        /// <summary>The default BigQueryWrite scopes.</summary>
        /// <remarks>
        /// The default BigQueryWrite scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/bigquery</description></item>
        /// <item><description>https://www.googleapis.com/auth/bigquery.insertdata</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/bigquery",
            "https://www.googleapis.com/auth/bigquery.insertdata",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(BigQueryWrite.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="BigQueryWriteClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="BigQueryWriteClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="BigQueryWriteClient"/>.</returns>
        public static stt::Task<BigQueryWriteClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new BigQueryWriteClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="BigQueryWriteClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="BigQueryWriteClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="BigQueryWriteClient"/>.</returns>
        public static BigQueryWriteClient Create() => new BigQueryWriteClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="BigQueryWriteClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BigQueryWriteSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="BigQueryWriteClient"/>.</returns>
        internal static BigQueryWriteClient Create(grpccore::CallInvoker callInvoker, BigQueryWriteSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BigQueryWrite.BigQueryWriteClient grpcClient = new BigQueryWrite.BigQueryWriteClient(callInvoker);
            return new BigQueryWriteClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC BigQueryWrite client</summary>
        public virtual BigQueryWrite.BigQueryWriteClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a write stream to the given table.
        /// Additionally, every table has a special stream named '_default'
        /// to which data can be written. This stream doesn't need to be created using
        /// CreateWriteStream. It is a stream that can be used simultaneously by any
        /// number of clients. Data written to this stream is considered committed as
        /// soon as an acknowledgement is received.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WriteStream CreateWriteStream(CreateWriteStreamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a write stream to the given table.
        /// Additionally, every table has a special stream named '_default'
        /// to which data can be written. This stream doesn't need to be created using
        /// CreateWriteStream. It is a stream that can be used simultaneously by any
        /// number of clients. Data written to this stream is considered committed as
        /// soon as an acknowledgement is received.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WriteStream> CreateWriteStreamAsync(CreateWriteStreamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a write stream to the given table.
        /// Additionally, every table has a special stream named '_default'
        /// to which data can be written. This stream doesn't need to be created using
        /// CreateWriteStream. It is a stream that can be used simultaneously by any
        /// number of clients. Data written to this stream is considered committed as
        /// soon as an acknowledgement is received.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WriteStream> CreateWriteStreamAsync(CreateWriteStreamRequest request, st::CancellationToken cancellationToken) =>
            CreateWriteStreamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a write stream to the given table.
        /// Additionally, every table has a special stream named '_default'
        /// to which data can be written. This stream doesn't need to be created using
        /// CreateWriteStream. It is a stream that can be used simultaneously by any
        /// number of clients. Data written to this stream is considered committed as
        /// soon as an acknowledgement is received.
        /// </summary>
        /// <param name="parent">
        /// Required. Reference to the table to which the stream belongs, in the format
        /// of `projects/{project}/datasets/{dataset}/tables/{table}`.
        /// </param>
        /// <param name="writeStream">
        /// Required. Stream to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WriteStream CreateWriteStream(string parent, WriteStream writeStream, gaxgrpc::CallSettings callSettings = null) =>
            CreateWriteStream(new CreateWriteStreamRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                WriteStream = gax::GaxPreconditions.CheckNotNull(writeStream, nameof(writeStream)),
            }, callSettings);

        /// <summary>
        /// Creates a write stream to the given table.
        /// Additionally, every table has a special stream named '_default'
        /// to which data can be written. This stream doesn't need to be created using
        /// CreateWriteStream. It is a stream that can be used simultaneously by any
        /// number of clients. Data written to this stream is considered committed as
        /// soon as an acknowledgement is received.
        /// </summary>
        /// <param name="parent">
        /// Required. Reference to the table to which the stream belongs, in the format
        /// of `projects/{project}/datasets/{dataset}/tables/{table}`.
        /// </param>
        /// <param name="writeStream">
        /// Required. Stream to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WriteStream> CreateWriteStreamAsync(string parent, WriteStream writeStream, gaxgrpc::CallSettings callSettings = null) =>
            CreateWriteStreamAsync(new CreateWriteStreamRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                WriteStream = gax::GaxPreconditions.CheckNotNull(writeStream, nameof(writeStream)),
            }, callSettings);

        /// <summary>
        /// Creates a write stream to the given table.
        /// Additionally, every table has a special stream named '_default'
        /// to which data can be written. This stream doesn't need to be created using
        /// CreateWriteStream. It is a stream that can be used simultaneously by any
        /// number of clients. Data written to this stream is considered committed as
        /// soon as an acknowledgement is received.
        /// </summary>
        /// <param name="parent">
        /// Required. Reference to the table to which the stream belongs, in the format
        /// of `projects/{project}/datasets/{dataset}/tables/{table}`.
        /// </param>
        /// <param name="writeStream">
        /// Required. Stream to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WriteStream> CreateWriteStreamAsync(string parent, WriteStream writeStream, st::CancellationToken cancellationToken) =>
            CreateWriteStreamAsync(parent, writeStream, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a write stream to the given table.
        /// Additionally, every table has a special stream named '_default'
        /// to which data can be written. This stream doesn't need to be created using
        /// CreateWriteStream. It is a stream that can be used simultaneously by any
        /// number of clients. Data written to this stream is considered committed as
        /// soon as an acknowledgement is received.
        /// </summary>
        /// <param name="parent">
        /// Required. Reference to the table to which the stream belongs, in the format
        /// of `projects/{project}/datasets/{dataset}/tables/{table}`.
        /// </param>
        /// <param name="writeStream">
        /// Required. Stream to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WriteStream CreateWriteStream(TableName parent, WriteStream writeStream, gaxgrpc::CallSettings callSettings = null) =>
            CreateWriteStream(new CreateWriteStreamRequest
            {
                ParentAsTableName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                WriteStream = gax::GaxPreconditions.CheckNotNull(writeStream, nameof(writeStream)),
            }, callSettings);

        /// <summary>
        /// Creates a write stream to the given table.
        /// Additionally, every table has a special stream named '_default'
        /// to which data can be written. This stream doesn't need to be created using
        /// CreateWriteStream. It is a stream that can be used simultaneously by any
        /// number of clients. Data written to this stream is considered committed as
        /// soon as an acknowledgement is received.
        /// </summary>
        /// <param name="parent">
        /// Required. Reference to the table to which the stream belongs, in the format
        /// of `projects/{project}/datasets/{dataset}/tables/{table}`.
        /// </param>
        /// <param name="writeStream">
        /// Required. Stream to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WriteStream> CreateWriteStreamAsync(TableName parent, WriteStream writeStream, gaxgrpc::CallSettings callSettings = null) =>
            CreateWriteStreamAsync(new CreateWriteStreamRequest
            {
                ParentAsTableName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                WriteStream = gax::GaxPreconditions.CheckNotNull(writeStream, nameof(writeStream)),
            }, callSettings);

        /// <summary>
        /// Creates a write stream to the given table.
        /// Additionally, every table has a special stream named '_default'
        /// to which data can be written. This stream doesn't need to be created using
        /// CreateWriteStream. It is a stream that can be used simultaneously by any
        /// number of clients. Data written to this stream is considered committed as
        /// soon as an acknowledgement is received.
        /// </summary>
        /// <param name="parent">
        /// Required. Reference to the table to which the stream belongs, in the format
        /// of `projects/{project}/datasets/{dataset}/tables/{table}`.
        /// </param>
        /// <param name="writeStream">
        /// Required. Stream to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WriteStream> CreateWriteStreamAsync(TableName parent, WriteStream writeStream, st::CancellationToken cancellationToken) =>
            CreateWriteStreamAsync(parent, writeStream, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Bidirectional streaming methods for
        /// <see cref="AppendRows(gaxgrpc::CallSettings,gaxgrpc::BidirectionalStreamingSettings)"/>.
        /// </summary>
        public abstract partial class AppendRowsStream : gaxgrpc::BidirectionalStreamingBase<AppendRowsRequest, AppendRowsResponse>
        {
        }

        /// <summary>
        /// Appends data to the given stream.
        /// 
        /// If `offset` is specified, the `offset` is checked against the end of
        /// stream. The server returns `OUT_OF_RANGE` in `AppendRowsResponse` if an
        /// attempt is made to append to an offset beyond the current end of the stream
        /// or `ALREADY_EXISTS` if user provides an `offset` that has already been
        /// written to. User can retry with adjusted offset within the same RPC
        /// connection. If `offset` is not specified, append happens at the end of the
        /// stream.
        /// 
        /// The response contains an optional offset at which the append
        /// happened.  No offset information will be returned for appends to a
        /// default stream.
        /// 
        /// Responses are received in the same order in which requests are sent.
        /// There will be one response for each successful inserted request.  Responses
        /// may optionally embed error information if the originating AppendRequest was
        /// not successfully processed.
        /// 
        /// The specifics of when successfully appended data is made visible to the
        /// table are governed by the type of stream:
        /// 
        /// * For COMMITTED streams (which includes the default stream), data is
        /// visible immediately upon successful append.
        /// 
        /// * For BUFFERED streams, data is made visible via a subsequent `FlushRows`
        /// rpc which advances a cursor to a newer offset in the stream.
        /// 
        /// * For PENDING streams, data is not made visible until the stream itself is
        /// finalized (via the `FinalizeWriteStream` rpc), and the stream is explicitly
        /// committed via the `BatchCommitWriteStreams` rpc.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public virtual AppendRowsStream AppendRows(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a write stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WriteStream GetWriteStream(GetWriteStreamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a write stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WriteStream> GetWriteStreamAsync(GetWriteStreamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a write stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WriteStream> GetWriteStreamAsync(GetWriteStreamRequest request, st::CancellationToken cancellationToken) =>
            GetWriteStreamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a write stream.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the stream to get, in the form of
        /// `projects/{project}/datasets/{dataset}/tables/{table}/streams/{stream}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WriteStream GetWriteStream(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetWriteStream(new GetWriteStreamRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a write stream.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the stream to get, in the form of
        /// `projects/{project}/datasets/{dataset}/tables/{table}/streams/{stream}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WriteStream> GetWriteStreamAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetWriteStreamAsync(new GetWriteStreamRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a write stream.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the stream to get, in the form of
        /// `projects/{project}/datasets/{dataset}/tables/{table}/streams/{stream}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WriteStream> GetWriteStreamAsync(string name, st::CancellationToken cancellationToken) =>
            GetWriteStreamAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a write stream.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the stream to get, in the form of
        /// `projects/{project}/datasets/{dataset}/tables/{table}/streams/{stream}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WriteStream GetWriteStream(WriteStreamName name, gaxgrpc::CallSettings callSettings = null) =>
            GetWriteStream(new GetWriteStreamRequest
            {
                WriteStreamName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a write stream.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the stream to get, in the form of
        /// `projects/{project}/datasets/{dataset}/tables/{table}/streams/{stream}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WriteStream> GetWriteStreamAsync(WriteStreamName name, gaxgrpc::CallSettings callSettings = null) =>
            GetWriteStreamAsync(new GetWriteStreamRequest
            {
                WriteStreamName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a write stream.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the stream to get, in the form of
        /// `projects/{project}/datasets/{dataset}/tables/{table}/streams/{stream}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WriteStream> GetWriteStreamAsync(WriteStreamName name, st::CancellationToken cancellationToken) =>
            GetWriteStreamAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Finalize a write stream so that no new data can be appended to the
        /// stream. Finalize is not supported on the '_default' stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FinalizeWriteStreamResponse FinalizeWriteStream(FinalizeWriteStreamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Finalize a write stream so that no new data can be appended to the
        /// stream. Finalize is not supported on the '_default' stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FinalizeWriteStreamResponse> FinalizeWriteStreamAsync(FinalizeWriteStreamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Finalize a write stream so that no new data can be appended to the
        /// stream. Finalize is not supported on the '_default' stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FinalizeWriteStreamResponse> FinalizeWriteStreamAsync(FinalizeWriteStreamRequest request, st::CancellationToken cancellationToken) =>
            FinalizeWriteStreamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Finalize a write stream so that no new data can be appended to the
        /// stream. Finalize is not supported on the '_default' stream.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the stream to finalize, in the form of
        /// `projects/{project}/datasets/{dataset}/tables/{table}/streams/{stream}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FinalizeWriteStreamResponse FinalizeWriteStream(string name, gaxgrpc::CallSettings callSettings = null) =>
            FinalizeWriteStream(new FinalizeWriteStreamRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Finalize a write stream so that no new data can be appended to the
        /// stream. Finalize is not supported on the '_default' stream.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the stream to finalize, in the form of
        /// `projects/{project}/datasets/{dataset}/tables/{table}/streams/{stream}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FinalizeWriteStreamResponse> FinalizeWriteStreamAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            FinalizeWriteStreamAsync(new FinalizeWriteStreamRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Finalize a write stream so that no new data can be appended to the
        /// stream. Finalize is not supported on the '_default' stream.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the stream to finalize, in the form of
        /// `projects/{project}/datasets/{dataset}/tables/{table}/streams/{stream}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FinalizeWriteStreamResponse> FinalizeWriteStreamAsync(string name, st::CancellationToken cancellationToken) =>
            FinalizeWriteStreamAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Finalize a write stream so that no new data can be appended to the
        /// stream. Finalize is not supported on the '_default' stream.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the stream to finalize, in the form of
        /// `projects/{project}/datasets/{dataset}/tables/{table}/streams/{stream}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FinalizeWriteStreamResponse FinalizeWriteStream(WriteStreamName name, gaxgrpc::CallSettings callSettings = null) =>
            FinalizeWriteStream(new FinalizeWriteStreamRequest
            {
                WriteStreamName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Finalize a write stream so that no new data can be appended to the
        /// stream. Finalize is not supported on the '_default' stream.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the stream to finalize, in the form of
        /// `projects/{project}/datasets/{dataset}/tables/{table}/streams/{stream}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FinalizeWriteStreamResponse> FinalizeWriteStreamAsync(WriteStreamName name, gaxgrpc::CallSettings callSettings = null) =>
            FinalizeWriteStreamAsync(new FinalizeWriteStreamRequest
            {
                WriteStreamName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Finalize a write stream so that no new data can be appended to the
        /// stream. Finalize is not supported on the '_default' stream.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the stream to finalize, in the form of
        /// `projects/{project}/datasets/{dataset}/tables/{table}/streams/{stream}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FinalizeWriteStreamResponse> FinalizeWriteStreamAsync(WriteStreamName name, st::CancellationToken cancellationToken) =>
            FinalizeWriteStreamAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Atomically commits a group of `PENDING` streams that belong to the same
        /// `parent` table.
        /// 
        /// Streams must be finalized before commit and cannot be committed multiple
        /// times. Once a stream is committed, data in the stream becomes available
        /// for read operations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCommitWriteStreamsResponse BatchCommitWriteStreams(BatchCommitWriteStreamsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Atomically commits a group of `PENDING` streams that belong to the same
        /// `parent` table.
        /// 
        /// Streams must be finalized before commit and cannot be committed multiple
        /// times. Once a stream is committed, data in the stream becomes available
        /// for read operations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCommitWriteStreamsResponse> BatchCommitWriteStreamsAsync(BatchCommitWriteStreamsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Atomically commits a group of `PENDING` streams that belong to the same
        /// `parent` table.
        /// 
        /// Streams must be finalized before commit and cannot be committed multiple
        /// times. Once a stream is committed, data in the stream becomes available
        /// for read operations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCommitWriteStreamsResponse> BatchCommitWriteStreamsAsync(BatchCommitWriteStreamsRequest request, st::CancellationToken cancellationToken) =>
            BatchCommitWriteStreamsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Atomically commits a group of `PENDING` streams that belong to the same
        /// `parent` table.
        /// 
        /// Streams must be finalized before commit and cannot be committed multiple
        /// times. Once a stream is committed, data in the stream becomes available
        /// for read operations.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent table that all the streams should belong to, in the form
        /// of `projects/{project}/datasets/{dataset}/tables/{table}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCommitWriteStreamsResponse BatchCommitWriteStreams(string parent, gaxgrpc::CallSettings callSettings = null) =>
            BatchCommitWriteStreams(new BatchCommitWriteStreamsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Atomically commits a group of `PENDING` streams that belong to the same
        /// `parent` table.
        /// 
        /// Streams must be finalized before commit and cannot be committed multiple
        /// times. Once a stream is committed, data in the stream becomes available
        /// for read operations.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent table that all the streams should belong to, in the form
        /// of `projects/{project}/datasets/{dataset}/tables/{table}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCommitWriteStreamsResponse> BatchCommitWriteStreamsAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            BatchCommitWriteStreamsAsync(new BatchCommitWriteStreamsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Atomically commits a group of `PENDING` streams that belong to the same
        /// `parent` table.
        /// 
        /// Streams must be finalized before commit and cannot be committed multiple
        /// times. Once a stream is committed, data in the stream becomes available
        /// for read operations.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent table that all the streams should belong to, in the form
        /// of `projects/{project}/datasets/{dataset}/tables/{table}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCommitWriteStreamsResponse> BatchCommitWriteStreamsAsync(string parent, st::CancellationToken cancellationToken) =>
            BatchCommitWriteStreamsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Atomically commits a group of `PENDING` streams that belong to the same
        /// `parent` table.
        /// 
        /// Streams must be finalized before commit and cannot be committed multiple
        /// times. Once a stream is committed, data in the stream becomes available
        /// for read operations.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent table that all the streams should belong to, in the form
        /// of `projects/{project}/datasets/{dataset}/tables/{table}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCommitWriteStreamsResponse BatchCommitWriteStreams(TableName parent, gaxgrpc::CallSettings callSettings = null) =>
            BatchCommitWriteStreams(new BatchCommitWriteStreamsRequest
            {
                ParentAsTableName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Atomically commits a group of `PENDING` streams that belong to the same
        /// `parent` table.
        /// 
        /// Streams must be finalized before commit and cannot be committed multiple
        /// times. Once a stream is committed, data in the stream becomes available
        /// for read operations.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent table that all the streams should belong to, in the form
        /// of `projects/{project}/datasets/{dataset}/tables/{table}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCommitWriteStreamsResponse> BatchCommitWriteStreamsAsync(TableName parent, gaxgrpc::CallSettings callSettings = null) =>
            BatchCommitWriteStreamsAsync(new BatchCommitWriteStreamsRequest
            {
                ParentAsTableName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Atomically commits a group of `PENDING` streams that belong to the same
        /// `parent` table.
        /// 
        /// Streams must be finalized before commit and cannot be committed multiple
        /// times. Once a stream is committed, data in the stream becomes available
        /// for read operations.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent table that all the streams should belong to, in the form
        /// of `projects/{project}/datasets/{dataset}/tables/{table}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCommitWriteStreamsResponse> BatchCommitWriteStreamsAsync(TableName parent, st::CancellationToken cancellationToken) =>
            BatchCommitWriteStreamsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Flushes rows to a BUFFERED stream.
        /// 
        /// If users are appending rows to BUFFERED stream, flush operation is
        /// required in order for the rows to become available for reading. A
        /// Flush operation flushes up to any previously flushed offset in a BUFFERED
        /// stream, to the offset specified in the request.
        /// 
        /// Flush is not supported on the _default stream, since it is not BUFFERED.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FlushRowsResponse FlushRows(FlushRowsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Flushes rows to a BUFFERED stream.
        /// 
        /// If users are appending rows to BUFFERED stream, flush operation is
        /// required in order for the rows to become available for reading. A
        /// Flush operation flushes up to any previously flushed offset in a BUFFERED
        /// stream, to the offset specified in the request.
        /// 
        /// Flush is not supported on the _default stream, since it is not BUFFERED.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FlushRowsResponse> FlushRowsAsync(FlushRowsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Flushes rows to a BUFFERED stream.
        /// 
        /// If users are appending rows to BUFFERED stream, flush operation is
        /// required in order for the rows to become available for reading. A
        /// Flush operation flushes up to any previously flushed offset in a BUFFERED
        /// stream, to the offset specified in the request.
        /// 
        /// Flush is not supported on the _default stream, since it is not BUFFERED.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FlushRowsResponse> FlushRowsAsync(FlushRowsRequest request, st::CancellationToken cancellationToken) =>
            FlushRowsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Flushes rows to a BUFFERED stream.
        /// 
        /// If users are appending rows to BUFFERED stream, flush operation is
        /// required in order for the rows to become available for reading. A
        /// Flush operation flushes up to any previously flushed offset in a BUFFERED
        /// stream, to the offset specified in the request.
        /// 
        /// Flush is not supported on the _default stream, since it is not BUFFERED.
        /// </summary>
        /// <param name="writeStream">
        /// Required. The stream that is the target of the flush operation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FlushRowsResponse FlushRows(string writeStream, gaxgrpc::CallSettings callSettings = null) =>
            FlushRows(new FlushRowsRequest
            {
                WriteStream = gax::GaxPreconditions.CheckNotNullOrEmpty(writeStream, nameof(writeStream)),
            }, callSettings);

        /// <summary>
        /// Flushes rows to a BUFFERED stream.
        /// 
        /// If users are appending rows to BUFFERED stream, flush operation is
        /// required in order for the rows to become available for reading. A
        /// Flush operation flushes up to any previously flushed offset in a BUFFERED
        /// stream, to the offset specified in the request.
        /// 
        /// Flush is not supported on the _default stream, since it is not BUFFERED.
        /// </summary>
        /// <param name="writeStream">
        /// Required. The stream that is the target of the flush operation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FlushRowsResponse> FlushRowsAsync(string writeStream, gaxgrpc::CallSettings callSettings = null) =>
            FlushRowsAsync(new FlushRowsRequest
            {
                WriteStream = gax::GaxPreconditions.CheckNotNullOrEmpty(writeStream, nameof(writeStream)),
            }, callSettings);

        /// <summary>
        /// Flushes rows to a BUFFERED stream.
        /// 
        /// If users are appending rows to BUFFERED stream, flush operation is
        /// required in order for the rows to become available for reading. A
        /// Flush operation flushes up to any previously flushed offset in a BUFFERED
        /// stream, to the offset specified in the request.
        /// 
        /// Flush is not supported on the _default stream, since it is not BUFFERED.
        /// </summary>
        /// <param name="writeStream">
        /// Required. The stream that is the target of the flush operation.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FlushRowsResponse> FlushRowsAsync(string writeStream, st::CancellationToken cancellationToken) =>
            FlushRowsAsync(writeStream, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Flushes rows to a BUFFERED stream.
        /// 
        /// If users are appending rows to BUFFERED stream, flush operation is
        /// required in order for the rows to become available for reading. A
        /// Flush operation flushes up to any previously flushed offset in a BUFFERED
        /// stream, to the offset specified in the request.
        /// 
        /// Flush is not supported on the _default stream, since it is not BUFFERED.
        /// </summary>
        /// <param name="writeStream">
        /// Required. The stream that is the target of the flush operation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FlushRowsResponse FlushRows(WriteStreamName writeStream, gaxgrpc::CallSettings callSettings = null) =>
            FlushRows(new FlushRowsRequest
            {
                WriteStreamAsWriteStreamName = gax::GaxPreconditions.CheckNotNull(writeStream, nameof(writeStream)),
            }, callSettings);

        /// <summary>
        /// Flushes rows to a BUFFERED stream.
        /// 
        /// If users are appending rows to BUFFERED stream, flush operation is
        /// required in order for the rows to become available for reading. A
        /// Flush operation flushes up to any previously flushed offset in a BUFFERED
        /// stream, to the offset specified in the request.
        /// 
        /// Flush is not supported on the _default stream, since it is not BUFFERED.
        /// </summary>
        /// <param name="writeStream">
        /// Required. The stream that is the target of the flush operation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FlushRowsResponse> FlushRowsAsync(WriteStreamName writeStream, gaxgrpc::CallSettings callSettings = null) =>
            FlushRowsAsync(new FlushRowsRequest
            {
                WriteStreamAsWriteStreamName = gax::GaxPreconditions.CheckNotNull(writeStream, nameof(writeStream)),
            }, callSettings);

        /// <summary>
        /// Flushes rows to a BUFFERED stream.
        /// 
        /// If users are appending rows to BUFFERED stream, flush operation is
        /// required in order for the rows to become available for reading. A
        /// Flush operation flushes up to any previously flushed offset in a BUFFERED
        /// stream, to the offset specified in the request.
        /// 
        /// Flush is not supported on the _default stream, since it is not BUFFERED.
        /// </summary>
        /// <param name="writeStream">
        /// Required. The stream that is the target of the flush operation.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FlushRowsResponse> FlushRowsAsync(WriteStreamName writeStream, st::CancellationToken cancellationToken) =>
            FlushRowsAsync(writeStream, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>BigQueryWrite client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// BigQuery Write API.
    /// 
    /// The Write API can be used to write data to BigQuery.
    /// 
    /// For supplementary information about the Write API, see:
    /// https://cloud.google.com/bigquery/docs/write-api
    /// </remarks>
    public sealed partial class BigQueryWriteClientImpl : BigQueryWriteClient
    {
        private readonly gaxgrpc::ApiCall<CreateWriteStreamRequest, WriteStream> _callCreateWriteStream;

        private readonly gaxgrpc::ApiBidirectionalStreamingCall<AppendRowsRequest, AppendRowsResponse> _callAppendRows;

        private readonly gaxgrpc::ApiCall<GetWriteStreamRequest, WriteStream> _callGetWriteStream;

        private readonly gaxgrpc::ApiCall<FinalizeWriteStreamRequest, FinalizeWriteStreamResponse> _callFinalizeWriteStream;

        private readonly gaxgrpc::ApiCall<BatchCommitWriteStreamsRequest, BatchCommitWriteStreamsResponse> _callBatchCommitWriteStreams;

        private readonly gaxgrpc::ApiCall<FlushRowsRequest, FlushRowsResponse> _callFlushRows;

        /// <summary>
        /// Constructs a client wrapper for the BigQueryWrite service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="BigQueryWriteSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public BigQueryWriteClientImpl(BigQueryWrite.BigQueryWriteClient grpcClient, BigQueryWriteSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            BigQueryWriteSettings effectiveSettings = settings ?? BigQueryWriteSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCreateWriteStream = clientHelper.BuildApiCall<CreateWriteStreamRequest, WriteStream>("CreateWriteStream", grpcClient.CreateWriteStreamAsync, grpcClient.CreateWriteStream, effectiveSettings.CreateWriteStreamSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateWriteStream);
            Modify_CreateWriteStreamApiCall(ref _callCreateWriteStream);
            _callAppendRows = clientHelper.BuildApiCall<AppendRowsRequest, AppendRowsResponse>("AppendRows", grpcClient.AppendRows, effectiveSettings.AppendRowsSettings, effectiveSettings.AppendRowsStreamingSettings);
            Modify_ApiCall(ref _callAppendRows);
            Modify_AppendRowsApiCall(ref _callAppendRows);
            _callGetWriteStream = clientHelper.BuildApiCall<GetWriteStreamRequest, WriteStream>("GetWriteStream", grpcClient.GetWriteStreamAsync, grpcClient.GetWriteStream, effectiveSettings.GetWriteStreamSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetWriteStream);
            Modify_GetWriteStreamApiCall(ref _callGetWriteStream);
            _callFinalizeWriteStream = clientHelper.BuildApiCall<FinalizeWriteStreamRequest, FinalizeWriteStreamResponse>("FinalizeWriteStream", grpcClient.FinalizeWriteStreamAsync, grpcClient.FinalizeWriteStream, effectiveSettings.FinalizeWriteStreamSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callFinalizeWriteStream);
            Modify_FinalizeWriteStreamApiCall(ref _callFinalizeWriteStream);
            _callBatchCommitWriteStreams = clientHelper.BuildApiCall<BatchCommitWriteStreamsRequest, BatchCommitWriteStreamsResponse>("BatchCommitWriteStreams", grpcClient.BatchCommitWriteStreamsAsync, grpcClient.BatchCommitWriteStreams, effectiveSettings.BatchCommitWriteStreamsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCommitWriteStreams);
            Modify_BatchCommitWriteStreamsApiCall(ref _callBatchCommitWriteStreams);
            _callFlushRows = clientHelper.BuildApiCall<FlushRowsRequest, FlushRowsResponse>("FlushRows", grpcClient.FlushRowsAsync, grpcClient.FlushRows, effectiveSettings.FlushRowsSettings).WithGoogleRequestParam("write_stream", request => request.WriteStream);
            Modify_ApiCall(ref _callFlushRows);
            Modify_FlushRowsApiCall(ref _callFlushRows);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiBidirectionalStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateWriteStreamApiCall(ref gaxgrpc::ApiCall<CreateWriteStreamRequest, WriteStream> call);

        partial void Modify_AppendRowsApiCall(ref gaxgrpc::ApiBidirectionalStreamingCall<AppendRowsRequest, AppendRowsResponse> call);

        partial void Modify_GetWriteStreamApiCall(ref gaxgrpc::ApiCall<GetWriteStreamRequest, WriteStream> call);

        partial void Modify_FinalizeWriteStreamApiCall(ref gaxgrpc::ApiCall<FinalizeWriteStreamRequest, FinalizeWriteStreamResponse> call);

        partial void Modify_BatchCommitWriteStreamsApiCall(ref gaxgrpc::ApiCall<BatchCommitWriteStreamsRequest, BatchCommitWriteStreamsResponse> call);

        partial void Modify_FlushRowsApiCall(ref gaxgrpc::ApiCall<FlushRowsRequest, FlushRowsResponse> call);

        partial void OnConstruction(BigQueryWrite.BigQueryWriteClient grpcClient, BigQueryWriteSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC BigQueryWrite client</summary>
        public override BigQueryWrite.BigQueryWriteClient GrpcClient { get; }

        partial void Modify_CreateWriteStreamRequest(ref CreateWriteStreamRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AppendRowsRequestCallSettings(ref gaxgrpc::CallSettings settings);

        partial void Modify_AppendRowsRequestRequest(ref AppendRowsRequest request);

        partial void Modify_GetWriteStreamRequest(ref GetWriteStreamRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FinalizeWriteStreamRequest(ref FinalizeWriteStreamRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCommitWriteStreamsRequest(ref BatchCommitWriteStreamsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FlushRowsRequest(ref FlushRowsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a write stream to the given table.
        /// Additionally, every table has a special stream named '_default'
        /// to which data can be written. This stream doesn't need to be created using
        /// CreateWriteStream. It is a stream that can be used simultaneously by any
        /// number of clients. Data written to this stream is considered committed as
        /// soon as an acknowledgement is received.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override WriteStream CreateWriteStream(CreateWriteStreamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateWriteStreamRequest(ref request, ref callSettings);
            return _callCreateWriteStream.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a write stream to the given table.
        /// Additionally, every table has a special stream named '_default'
        /// to which data can be written. This stream doesn't need to be created using
        /// CreateWriteStream. It is a stream that can be used simultaneously by any
        /// number of clients. Data written to this stream is considered committed as
        /// soon as an acknowledgement is received.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<WriteStream> CreateWriteStreamAsync(CreateWriteStreamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateWriteStreamRequest(ref request, ref callSettings);
            return _callCreateWriteStream.Async(request, callSettings);
        }

        internal sealed partial class AppendRowsStreamImpl : AppendRowsStream
        {
            /// <summary>Construct the bidirectional streaming method for <c>AppendRows</c>.</summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">
            /// The <see cref="gaxgrpc::BufferedClientStreamWriter{AppendRowsRequest}"/> instance associated with this
            /// streaming call.
            /// </param>
            public AppendRowsStreamImpl(BigQueryWriteClientImpl service, grpccore::AsyncDuplexStreamingCall<AppendRowsRequest, AppendRowsResponse> call, gaxgrpc::BufferedClientStreamWriter<AppendRowsRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private BigQueryWriteClientImpl _service;

            private gaxgrpc::BufferedClientStreamWriter<AppendRowsRequest> _writeBuffer;

            public override grpccore::AsyncDuplexStreamingCall<AppendRowsRequest, AppendRowsResponse> GrpcCall { get; }

            private AppendRowsRequest ModifyRequest(AppendRowsRequest request)
            {
                _service.Modify_AppendRowsRequestRequest(ref request);
                return request;
            }

            public override stt::Task TryWriteAsync(AppendRowsRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            public override stt::Task WriteAsync(AppendRowsRequest message) =>
                _writeBuffer.WriteAsync(ModifyRequest(message));

            public override stt::Task TryWriteAsync(AppendRowsRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            public override stt::Task WriteAsync(AppendRowsRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            public override stt::Task TryWriteCompleteAsync() => _writeBuffer.TryWriteCompleteAsync();

            public override stt::Task WriteCompleteAsync() => _writeBuffer.WriteCompleteAsync();
        }

        /// <summary>
        /// Appends data to the given stream.
        /// 
        /// If `offset` is specified, the `offset` is checked against the end of
        /// stream. The server returns `OUT_OF_RANGE` in `AppendRowsResponse` if an
        /// attempt is made to append to an offset beyond the current end of the stream
        /// or `ALREADY_EXISTS` if user provides an `offset` that has already been
        /// written to. User can retry with adjusted offset within the same RPC
        /// connection. If `offset` is not specified, append happens at the end of the
        /// stream.
        /// 
        /// The response contains an optional offset at which the append
        /// happened.  No offset information will be returned for appends to a
        /// default stream.
        /// 
        /// Responses are received in the same order in which requests are sent.
        /// There will be one response for each successful inserted request.  Responses
        /// may optionally embed error information if the originating AppendRequest was
        /// not successfully processed.
        /// 
        /// The specifics of when successfully appended data is made visible to the
        /// table are governed by the type of stream:
        /// 
        /// * For COMMITTED streams (which includes the default stream), data is
        /// visible immediately upon successful append.
        /// 
        /// * For BUFFERED streams, data is made visible via a subsequent `FlushRows`
        /// rpc which advances a cursor to a newer offset in the stream.
        /// 
        /// * For PENDING streams, data is not made visible until the stream itself is
        /// finalized (via the `FinalizeWriteStream` rpc), and the stream is explicitly
        /// committed via the `BatchCommitWriteStreams` rpc.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public override BigQueryWriteClient.AppendRowsStream AppendRows(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_AppendRowsRequestCallSettings(ref callSettings);
            gaxgrpc::BidirectionalStreamingSettings effectiveStreamingSettings = streamingSettings ?? _callAppendRows.StreamingSettings;
            grpccore::AsyncDuplexStreamingCall<AppendRowsRequest, AppendRowsResponse> call = _callAppendRows.Call(callSettings);
            gaxgrpc::BufferedClientStreamWriter<AppendRowsRequest> writeBuffer = new gaxgrpc::BufferedClientStreamWriter<AppendRowsRequest>(call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new AppendRowsStreamImpl(this, call, writeBuffer);
        }

        /// <summary>
        /// Gets information about a write stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override WriteStream GetWriteStream(GetWriteStreamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWriteStreamRequest(ref request, ref callSettings);
            return _callGetWriteStream.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets information about a write stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<WriteStream> GetWriteStreamAsync(GetWriteStreamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWriteStreamRequest(ref request, ref callSettings);
            return _callGetWriteStream.Async(request, callSettings);
        }

        /// <summary>
        /// Finalize a write stream so that no new data can be appended to the
        /// stream. Finalize is not supported on the '_default' stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FinalizeWriteStreamResponse FinalizeWriteStream(FinalizeWriteStreamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FinalizeWriteStreamRequest(ref request, ref callSettings);
            return _callFinalizeWriteStream.Sync(request, callSettings);
        }

        /// <summary>
        /// Finalize a write stream so that no new data can be appended to the
        /// stream. Finalize is not supported on the '_default' stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FinalizeWriteStreamResponse> FinalizeWriteStreamAsync(FinalizeWriteStreamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FinalizeWriteStreamRequest(ref request, ref callSettings);
            return _callFinalizeWriteStream.Async(request, callSettings);
        }

        /// <summary>
        /// Atomically commits a group of `PENDING` streams that belong to the same
        /// `parent` table.
        /// 
        /// Streams must be finalized before commit and cannot be committed multiple
        /// times. Once a stream is committed, data in the stream becomes available
        /// for read operations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCommitWriteStreamsResponse BatchCommitWriteStreams(BatchCommitWriteStreamsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCommitWriteStreamsRequest(ref request, ref callSettings);
            return _callBatchCommitWriteStreams.Sync(request, callSettings);
        }

        /// <summary>
        /// Atomically commits a group of `PENDING` streams that belong to the same
        /// `parent` table.
        /// 
        /// Streams must be finalized before commit and cannot be committed multiple
        /// times. Once a stream is committed, data in the stream becomes available
        /// for read operations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCommitWriteStreamsResponse> BatchCommitWriteStreamsAsync(BatchCommitWriteStreamsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCommitWriteStreamsRequest(ref request, ref callSettings);
            return _callBatchCommitWriteStreams.Async(request, callSettings);
        }

        /// <summary>
        /// Flushes rows to a BUFFERED stream.
        /// 
        /// If users are appending rows to BUFFERED stream, flush operation is
        /// required in order for the rows to become available for reading. A
        /// Flush operation flushes up to any previously flushed offset in a BUFFERED
        /// stream, to the offset specified in the request.
        /// 
        /// Flush is not supported on the _default stream, since it is not BUFFERED.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FlushRowsResponse FlushRows(FlushRowsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FlushRowsRequest(ref request, ref callSettings);
            return _callFlushRows.Sync(request, callSettings);
        }

        /// <summary>
        /// Flushes rows to a BUFFERED stream.
        /// 
        /// If users are appending rows to BUFFERED stream, flush operation is
        /// required in order for the rows to become available for reading. A
        /// Flush operation flushes up to any previously flushed offset in a BUFFERED
        /// stream, to the offset specified in the request.
        /// 
        /// Flush is not supported on the _default stream, since it is not BUFFERED.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FlushRowsResponse> FlushRowsAsync(FlushRowsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FlushRowsRequest(ref request, ref callSettings);
            return _callFlushRows.Async(request, callSettings);
        }
    }
}
