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
using gcbcv = Google.Cloud.Bigtable.Common.V2;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using linq = System.Linq;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.Bigtable.V2
{
    /// <summary>Settings for <see cref="BigtableServiceApiClient"/> instances.</summary>
    public sealed partial class BigtableServiceApiSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BigtableServiceApiSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BigtableServiceApiSettings"/>.</returns>
        public static BigtableServiceApiSettings GetDefault() => new BigtableServiceApiSettings();

        /// <summary>Constructs a new <see cref="BigtableServiceApiSettings"/> object with default settings.</summary>
        public BigtableServiceApiSettings()
        {
        }

        private BigtableServiceApiSettings(BigtableServiceApiSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ReadRowsSettings = existing.ReadRowsSettings;
            SampleRowKeysSettings = existing.SampleRowKeysSettings;
            MutateRowSettings = existing.MutateRowSettings;
            MutateRowsSettings = existing.MutateRowsSettings;
            CheckAndMutateRowSettings = existing.CheckAndMutateRowSettings;
            PingAndWarmSettings = existing.PingAndWarmSettings;
            ReadModifyWriteRowSettings = existing.ReadModifyWriteRowSettings;
            GenerateInitialChangeStreamPartitionsSettings = existing.GenerateInitialChangeStreamPartitionsSettings;
            ReadChangeStreamSettings = existing.ReadChangeStreamSettings;
            PrepareQuerySettings = existing.PrepareQuerySettings;
            ExecuteQuerySettings = existing.ExecuteQuerySettings;
            OnCopy(existing);
        }

        partial void OnCopy(BigtableServiceApiSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableServiceApiClient.ReadRows</c> and <c>BigtableServiceApiClient.ReadRowsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 43200 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReadRowsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(43200000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableServiceApiClient.SampleRowKeys</c> and <c>BigtableServiceApiClient.SampleRowKeysAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SampleRowKeysSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableServiceApiClient.MutateRow</c> and <c>BigtableServiceApiClient.MutateRowAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 10 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateRowSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(10), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableServiceApiClient.MutateRows</c> and <c>BigtableServiceApiClient.MutateRowsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateRowsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableServiceApiClient.CheckAndMutateRow</c> and <c>BigtableServiceApiClient.CheckAndMutateRowAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CheckAndMutateRowSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableServiceApiClient.PingAndWarm</c> and <c>BigtableServiceApiClient.PingAndWarmAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PingAndWarmSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableServiceApiClient.ReadModifyWriteRow</c> and <c>BigtableServiceApiClient.ReadModifyWriteRowAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReadModifyWriteRowSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableServiceApiClient.GenerateInitialChangeStreamPartitions</c> and
        /// <c>BigtableServiceApiClient.GenerateInitialChangeStreamPartitionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateInitialChangeStreamPartitionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableServiceApiClient.ReadChangeStream</c> and <c>BigtableServiceApiClient.ReadChangeStreamAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 43200 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReadChangeStreamSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(43200000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableServiceApiClient.PrepareQuery</c> and <c>BigtableServiceApiClient.PrepareQueryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PrepareQuerySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableServiceApiClient.ExecuteQuery</c> and <c>BigtableServiceApiClient.ExecuteQueryAsync</c>.
        /// </summary>
        /// <remarks>Timeout: 43200 seconds.</remarks>
        public gaxgrpc::CallSettings ExecuteQuerySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(43200000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BigtableServiceApiSettings"/> object.</returns>
        public BigtableServiceApiSettings Clone() => new BigtableServiceApiSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BigtableServiceApiClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class BigtableServiceApiClientBuilder : gaxgrpc::ClientBuilderBase<BigtableServiceApiClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BigtableServiceApiSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public BigtableServiceApiClientBuilder() : base(BigtableServiceApiClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref BigtableServiceApiClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<BigtableServiceApiClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override BigtableServiceApiClient Build()
        {
            BigtableServiceApiClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<BigtableServiceApiClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<BigtableServiceApiClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private BigtableServiceApiClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BigtableServiceApiClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<BigtableServiceApiClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BigtableServiceApiClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BigtableServiceApiClient.ChannelPool;
    }

    /// <summary>BigtableServiceApi client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for reading from and writing to existing Bigtable tables.
    /// </remarks>
    public abstract partial class BigtableServiceApiClient
    {
        /// <summary>
        /// The default endpoint for the BigtableServiceApi service, which is a host of "bigtable.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "bigtable.googleapis.com:443";

        /// <summary>The default BigtableServiceApi scopes.</summary>
        /// <remarks>
        /// The default BigtableServiceApi scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/bigtable.data</description></item>
        /// <item><description>https://www.googleapis.com/auth/bigtable.data.readonly</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-bigtable.data</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-bigtable.data.readonly</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform.read-only</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/bigtable.data",
            "https://www.googleapis.com/auth/bigtable.data.readonly",
            "https://www.googleapis.com/auth/cloud-bigtable.data",
            "https://www.googleapis.com/auth/cloud-bigtable.data.readonly",
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Bigtable.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="BigtableServiceApiClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="BigtableServiceApiClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="BigtableServiceApiClient"/>.</returns>
        public static stt::Task<BigtableServiceApiClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new BigtableServiceApiClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="BigtableServiceApiClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="BigtableServiceApiClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="BigtableServiceApiClient"/>.</returns>
        public static BigtableServiceApiClient Create() => new BigtableServiceApiClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="BigtableServiceApiClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BigtableServiceApiSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="BigtableServiceApiClient"/>.</returns>
        internal static BigtableServiceApiClient Create(grpccore::CallInvoker callInvoker, BigtableServiceApiSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Bigtable.BigtableClient grpcClient = new Bigtable.BigtableClient(callInvoker);
            return new BigtableServiceApiClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC BigtableServiceApi client</summary>
        public virtual Bigtable.BigtableClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Server streaming methods for <see cref="ReadRows(ReadRowsRequest,gaxgrpc::CallSettings)"/>.
        /// </summary>
        public abstract partial class ReadRowsStream : gaxgrpc::ServerStreamingBase<ReadRowsResponse>
        {
        }

        /// <summary>
        /// Streams back the contents of all requested rows in key order, optionally
        /// applying the same Reader filter to each. Depending on their size,
        /// rows and cells may be broken up across multiple responses, but
        /// atomicity of each row will still be preserved. See the
        /// ReadRowsResponse documentation for details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ReadRowsStream ReadRows(ReadRowsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Streams back the contents of all requested rows in key order, optionally
        /// applying the same Reader filter to each. Depending on their size,
        /// rows and cells may be broken up across multiple responses, but
        /// atomicity of each row will still be preserved. See the
        /// ReadRowsResponse documentation for details.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table from which to read.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ReadRowsStream ReadRows(string tableName, gaxgrpc::CallSettings callSettings = null) =>
            ReadRows(new ReadRowsRequest
            {
                TableName = tableName ?? "",
            }, callSettings);

        /// <summary>
        /// Streams back the contents of all requested rows in key order, optionally
        /// applying the same Reader filter to each. Depending on their size,
        /// rows and cells may be broken up across multiple responses, but
        /// atomicity of each row will still be preserved. See the
        /// ReadRowsResponse documentation for details.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table from which to read.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ReadRowsStream ReadRows(gcbcv::TableName tableName, gaxgrpc::CallSettings callSettings = null) =>
            ReadRows(new ReadRowsRequest
            {
                TableNameAsTableName = tableName,
            }, callSettings);

        /// <summary>
        /// Streams back the contents of all requested rows in key order, optionally
        /// applying the same Reader filter to each. Depending on their size,
        /// rows and cells may be broken up across multiple responses, but
        /// atomicity of each row will still be preserved. See the
        /// ReadRowsResponse documentation for details.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table from which to read.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ReadRowsStream ReadRows(string tableName, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            ReadRows(new ReadRowsRequest
            {
                TableName = tableName ?? "",
                AppProfileId = appProfileId ?? "",
            }, callSettings);

        /// <summary>
        /// Streams back the contents of all requested rows in key order, optionally
        /// applying the same Reader filter to each. Depending on their size,
        /// rows and cells may be broken up across multiple responses, but
        /// atomicity of each row will still be preserved. See the
        /// ReadRowsResponse documentation for details.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table from which to read.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ReadRowsStream ReadRows(gcbcv::TableName tableName, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            ReadRows(new ReadRowsRequest
            {
                TableNameAsTableName = tableName,
                AppProfileId = appProfileId ?? "",
            }, callSettings);

        /// <summary>
        /// Server streaming methods for <see cref="SampleRowKeys(SampleRowKeysRequest,gaxgrpc::CallSettings)"/>.
        /// </summary>
        public abstract partial class SampleRowKeysStream : gaxgrpc::ServerStreamingBase<SampleRowKeysResponse>
        {
        }

        /// <summary>
        /// Returns a sample of row keys in the table. The returned row keys will
        /// delimit contiguous sections of the table of approximately equal size,
        /// which can be used to break up the data for distributed tasks like
        /// mapreduces.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual SampleRowKeysStream SampleRowKeys(SampleRowKeysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a sample of row keys in the table. The returned row keys will
        /// delimit contiguous sections of the table of approximately equal size,
        /// which can be used to break up the data for distributed tasks like
        /// mapreduces.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table from which to sample row keys.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual SampleRowKeysStream SampleRowKeys(string tableName, gaxgrpc::CallSettings callSettings = null) =>
            SampleRowKeys(new SampleRowKeysRequest
            {
                TableName = tableName ?? "",
            }, callSettings);

        /// <summary>
        /// Returns a sample of row keys in the table. The returned row keys will
        /// delimit contiguous sections of the table of approximately equal size,
        /// which can be used to break up the data for distributed tasks like
        /// mapreduces.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table from which to sample row keys.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual SampleRowKeysStream SampleRowKeys(gcbcv::TableName tableName, gaxgrpc::CallSettings callSettings = null) =>
            SampleRowKeys(new SampleRowKeysRequest
            {
                TableNameAsTableName = tableName,
            }, callSettings);

        /// <summary>
        /// Returns a sample of row keys in the table. The returned row keys will
        /// delimit contiguous sections of the table of approximately equal size,
        /// which can be used to break up the data for distributed tasks like
        /// mapreduces.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table from which to sample row keys.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual SampleRowKeysStream SampleRowKeys(string tableName, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            SampleRowKeys(new SampleRowKeysRequest
            {
                TableName = tableName ?? "",
                AppProfileId = appProfileId ?? "",
            }, callSettings);

        /// <summary>
        /// Returns a sample of row keys in the table. The returned row keys will
        /// delimit contiguous sections of the table of approximately equal size,
        /// which can be used to break up the data for distributed tasks like
        /// mapreduces.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table from which to sample row keys.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual SampleRowKeysStream SampleRowKeys(gcbcv::TableName tableName, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            SampleRowKeys(new SampleRowKeysRequest
            {
                TableNameAsTableName = tableName,
                AppProfileId = appProfileId ?? "",
            }, callSettings);

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateRowResponse MutateRow(MutateRowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateRowResponse> MutateRowAsync(MutateRowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateRowResponse> MutateRowAsync(MutateRowRequest request, st::CancellationToken cancellationToken) =>
            MutateRowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table to which the mutation should be
        /// applied.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the mutation should be applied.
        /// </param>
        /// <param name="mutations">
        /// Required. Changes to be atomically applied to the specified row. Entries
        /// are applied in order, meaning that earlier mutations can be masked by later
        /// ones. Must contain at least one entry and at most 100000.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateRowResponse MutateRow(string tableName, proto::ByteString rowKey, scg::IEnumerable<Mutation> mutations, gaxgrpc::CallSettings callSettings = null) =>
            MutateRow(new MutateRowRequest
            {
                TableName = tableName ?? "",
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                Mutations =
                {
                    gax::GaxPreconditions.CheckNotNull(mutations, nameof(mutations)),
                },
            }, callSettings);

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table to which the mutation should be
        /// applied.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the mutation should be applied.
        /// </param>
        /// <param name="mutations">
        /// Required. Changes to be atomically applied to the specified row. Entries
        /// are applied in order, meaning that earlier mutations can be masked by later
        /// ones. Must contain at least one entry and at most 100000.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateRowResponse> MutateRowAsync(string tableName, proto::ByteString rowKey, scg::IEnumerable<Mutation> mutations, gaxgrpc::CallSettings callSettings = null) =>
            MutateRowAsync(new MutateRowRequest
            {
                TableName = tableName ?? "",
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                Mutations =
                {
                    gax::GaxPreconditions.CheckNotNull(mutations, nameof(mutations)),
                },
            }, callSettings);

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table to which the mutation should be
        /// applied.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the mutation should be applied.
        /// </param>
        /// <param name="mutations">
        /// Required. Changes to be atomically applied to the specified row. Entries
        /// are applied in order, meaning that earlier mutations can be masked by later
        /// ones. Must contain at least one entry and at most 100000.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateRowResponse> MutateRowAsync(string tableName, proto::ByteString rowKey, scg::IEnumerable<Mutation> mutations, st::CancellationToken cancellationToken) =>
            MutateRowAsync(tableName, rowKey, mutations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table to which the mutation should be
        /// applied.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the mutation should be applied.
        /// </param>
        /// <param name="mutations">
        /// Required. Changes to be atomically applied to the specified row. Entries
        /// are applied in order, meaning that earlier mutations can be masked by later
        /// ones. Must contain at least one entry and at most 100000.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateRowResponse MutateRow(gcbcv::TableName tableName, proto::ByteString rowKey, scg::IEnumerable<Mutation> mutations, gaxgrpc::CallSettings callSettings = null) =>
            MutateRow(new MutateRowRequest
            {
                TableNameAsTableName = tableName,
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                Mutations =
                {
                    gax::GaxPreconditions.CheckNotNull(mutations, nameof(mutations)),
                },
            }, callSettings);

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table to which the mutation should be
        /// applied.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the mutation should be applied.
        /// </param>
        /// <param name="mutations">
        /// Required. Changes to be atomically applied to the specified row. Entries
        /// are applied in order, meaning that earlier mutations can be masked by later
        /// ones. Must contain at least one entry and at most 100000.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateRowResponse> MutateRowAsync(gcbcv::TableName tableName, proto::ByteString rowKey, scg::IEnumerable<Mutation> mutations, gaxgrpc::CallSettings callSettings = null) =>
            MutateRowAsync(new MutateRowRequest
            {
                TableNameAsTableName = tableName,
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                Mutations =
                {
                    gax::GaxPreconditions.CheckNotNull(mutations, nameof(mutations)),
                },
            }, callSettings);

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table to which the mutation should be
        /// applied.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the mutation should be applied.
        /// </param>
        /// <param name="mutations">
        /// Required. Changes to be atomically applied to the specified row. Entries
        /// are applied in order, meaning that earlier mutations can be masked by later
        /// ones. Must contain at least one entry and at most 100000.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateRowResponse> MutateRowAsync(gcbcv::TableName tableName, proto::ByteString rowKey, scg::IEnumerable<Mutation> mutations, st::CancellationToken cancellationToken) =>
            MutateRowAsync(tableName, rowKey, mutations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table to which the mutation should be
        /// applied.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the mutation should be applied.
        /// </param>
        /// <param name="mutations">
        /// Required. Changes to be atomically applied to the specified row. Entries
        /// are applied in order, meaning that earlier mutations can be masked by later
        /// ones. Must contain at least one entry and at most 100000.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateRowResponse MutateRow(string tableName, proto::ByteString rowKey, scg::IEnumerable<Mutation> mutations, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            MutateRow(new MutateRowRequest
            {
                TableName = tableName ?? "",
                AppProfileId = appProfileId ?? "",
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                Mutations =
                {
                    gax::GaxPreconditions.CheckNotNull(mutations, nameof(mutations)),
                },
            }, callSettings);

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table to which the mutation should be
        /// applied.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the mutation should be applied.
        /// </param>
        /// <param name="mutations">
        /// Required. Changes to be atomically applied to the specified row. Entries
        /// are applied in order, meaning that earlier mutations can be masked by later
        /// ones. Must contain at least one entry and at most 100000.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateRowResponse> MutateRowAsync(string tableName, proto::ByteString rowKey, scg::IEnumerable<Mutation> mutations, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            MutateRowAsync(new MutateRowRequest
            {
                TableName = tableName ?? "",
                AppProfileId = appProfileId ?? "",
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                Mutations =
                {
                    gax::GaxPreconditions.CheckNotNull(mutations, nameof(mutations)),
                },
            }, callSettings);

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table to which the mutation should be
        /// applied.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the mutation should be applied.
        /// </param>
        /// <param name="mutations">
        /// Required. Changes to be atomically applied to the specified row. Entries
        /// are applied in order, meaning that earlier mutations can be masked by later
        /// ones. Must contain at least one entry and at most 100000.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateRowResponse> MutateRowAsync(string tableName, proto::ByteString rowKey, scg::IEnumerable<Mutation> mutations, string appProfileId, st::CancellationToken cancellationToken) =>
            MutateRowAsync(tableName, rowKey, mutations, appProfileId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table to which the mutation should be
        /// applied.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the mutation should be applied.
        /// </param>
        /// <param name="mutations">
        /// Required. Changes to be atomically applied to the specified row. Entries
        /// are applied in order, meaning that earlier mutations can be masked by later
        /// ones. Must contain at least one entry and at most 100000.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateRowResponse MutateRow(gcbcv::TableName tableName, proto::ByteString rowKey, scg::IEnumerable<Mutation> mutations, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            MutateRow(new MutateRowRequest
            {
                TableNameAsTableName = tableName,
                AppProfileId = appProfileId ?? "",
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                Mutations =
                {
                    gax::GaxPreconditions.CheckNotNull(mutations, nameof(mutations)),
                },
            }, callSettings);

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table to which the mutation should be
        /// applied.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the mutation should be applied.
        /// </param>
        /// <param name="mutations">
        /// Required. Changes to be atomically applied to the specified row. Entries
        /// are applied in order, meaning that earlier mutations can be masked by later
        /// ones. Must contain at least one entry and at most 100000.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateRowResponse> MutateRowAsync(gcbcv::TableName tableName, proto::ByteString rowKey, scg::IEnumerable<Mutation> mutations, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            MutateRowAsync(new MutateRowRequest
            {
                TableNameAsTableName = tableName,
                AppProfileId = appProfileId ?? "",
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                Mutations =
                {
                    gax::GaxPreconditions.CheckNotNull(mutations, nameof(mutations)),
                },
            }, callSettings);

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table to which the mutation should be
        /// applied.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the mutation should be applied.
        /// </param>
        /// <param name="mutations">
        /// Required. Changes to be atomically applied to the specified row. Entries
        /// are applied in order, meaning that earlier mutations can be masked by later
        /// ones. Must contain at least one entry and at most 100000.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateRowResponse> MutateRowAsync(gcbcv::TableName tableName, proto::ByteString rowKey, scg::IEnumerable<Mutation> mutations, string appProfileId, st::CancellationToken cancellationToken) =>
            MutateRowAsync(tableName, rowKey, mutations, appProfileId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Server streaming methods for <see cref="MutateRows(MutateRowsRequest,gaxgrpc::CallSettings)"/>.
        /// </summary>
        public abstract partial class MutateRowsStream : gaxgrpc::ServerStreamingBase<MutateRowsResponse>
        {
        }

        /// <summary>
        /// Mutates multiple rows in a batch. Each individual row is mutated
        /// atomically as in MutateRow, but the entire batch is not executed
        /// atomically.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual MutateRowsStream MutateRows(MutateRowsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Mutates multiple rows in a batch. Each individual row is mutated
        /// atomically as in MutateRow, but the entire batch is not executed
        /// atomically.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table to which the mutations should be
        /// applied.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="entries">
        /// Required. The row keys and corresponding mutations to be applied in bulk.
        /// Each entry is applied as an atomic mutation, but the entries may be
        /// applied in arbitrary order (even between entries for the same row).
        /// At least one entry must be specified, and in total the entries can
        /// contain at most 100000 mutations.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual MutateRowsStream MutateRows(string tableName, scg::IEnumerable<MutateRowsRequest.Types.Entry> entries, gaxgrpc::CallSettings callSettings = null) =>
            MutateRows(new MutateRowsRequest
            {
                TableName = tableName ?? "",
                Entries =
                {
                    gax::GaxPreconditions.CheckNotNull(entries, nameof(entries)),
                },
            }, callSettings);

        /// <summary>
        /// Mutates multiple rows in a batch. Each individual row is mutated
        /// atomically as in MutateRow, but the entire batch is not executed
        /// atomically.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table to which the mutations should be
        /// applied.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="entries">
        /// Required. The row keys and corresponding mutations to be applied in bulk.
        /// Each entry is applied as an atomic mutation, but the entries may be
        /// applied in arbitrary order (even between entries for the same row).
        /// At least one entry must be specified, and in total the entries can
        /// contain at most 100000 mutations.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual MutateRowsStream MutateRows(gcbcv::TableName tableName, scg::IEnumerable<MutateRowsRequest.Types.Entry> entries, gaxgrpc::CallSettings callSettings = null) =>
            MutateRows(new MutateRowsRequest
            {
                TableNameAsTableName = tableName,
                Entries =
                {
                    gax::GaxPreconditions.CheckNotNull(entries, nameof(entries)),
                },
            }, callSettings);

        /// <summary>
        /// Mutates multiple rows in a batch. Each individual row is mutated
        /// atomically as in MutateRow, but the entire batch is not executed
        /// atomically.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table to which the mutations should be
        /// applied.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="entries">
        /// Required. The row keys and corresponding mutations to be applied in bulk.
        /// Each entry is applied as an atomic mutation, but the entries may be
        /// applied in arbitrary order (even between entries for the same row).
        /// At least one entry must be specified, and in total the entries can
        /// contain at most 100000 mutations.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual MutateRowsStream MutateRows(string tableName, scg::IEnumerable<MutateRowsRequest.Types.Entry> entries, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            MutateRows(new MutateRowsRequest
            {
                TableName = tableName ?? "",
                AppProfileId = appProfileId ?? "",
                Entries =
                {
                    gax::GaxPreconditions.CheckNotNull(entries, nameof(entries)),
                },
            }, callSettings);

        /// <summary>
        /// Mutates multiple rows in a batch. Each individual row is mutated
        /// atomically as in MutateRow, but the entire batch is not executed
        /// atomically.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table to which the mutations should be
        /// applied.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="entries">
        /// Required. The row keys and corresponding mutations to be applied in bulk.
        /// Each entry is applied as an atomic mutation, but the entries may be
        /// applied in arbitrary order (even between entries for the same row).
        /// At least one entry must be specified, and in total the entries can
        /// contain at most 100000 mutations.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual MutateRowsStream MutateRows(gcbcv::TableName tableName, scg::IEnumerable<MutateRowsRequest.Types.Entry> entries, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            MutateRows(new MutateRowsRequest
            {
                TableNameAsTableName = tableName,
                AppProfileId = appProfileId ?? "",
                Entries =
                {
                    gax::GaxPreconditions.CheckNotNull(entries, nameof(entries)),
                },
            }, callSettings);

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CheckAndMutateRowResponse CheckAndMutateRow(CheckAndMutateRowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(CheckAndMutateRowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(CheckAndMutateRowRequest request, st::CancellationToken cancellationToken) =>
            CheckAndMutateRowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table to which the conditional mutation
        /// should be applied.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the conditional mutation should be
        /// applied.
        /// </param>
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, either `true_mutations` or
        /// `false_mutations` will be executed. If unset, checks that the row contains
        /// any values at all.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// yields at least one cell when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `false_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="falseMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// does not yield any cells when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `true_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CheckAndMutateRowResponse CheckAndMutateRow(string tableName, proto::ByteString rowKey, RowFilter predicateFilter, scg::IEnumerable<Mutation> trueMutations, scg::IEnumerable<Mutation> falseMutations, gaxgrpc::CallSettings callSettings = null) =>
            CheckAndMutateRow(new CheckAndMutateRowRequest
            {
                TableName = tableName ?? "",
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                PredicateFilter = predicateFilter,
                TrueMutations =
                {
                    trueMutations ?? linq::Enumerable.Empty<Mutation>(),
                },
                FalseMutations =
                {
                    falseMutations ?? linq::Enumerable.Empty<Mutation>(),
                },
            }, callSettings);

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table to which the conditional mutation
        /// should be applied.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the conditional mutation should be
        /// applied.
        /// </param>
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, either `true_mutations` or
        /// `false_mutations` will be executed. If unset, checks that the row contains
        /// any values at all.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// yields at least one cell when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `false_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="falseMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// does not yield any cells when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `true_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(string tableName, proto::ByteString rowKey, RowFilter predicateFilter, scg::IEnumerable<Mutation> trueMutations, scg::IEnumerable<Mutation> falseMutations, gaxgrpc::CallSettings callSettings = null) =>
            CheckAndMutateRowAsync(new CheckAndMutateRowRequest
            {
                TableName = tableName ?? "",
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                PredicateFilter = predicateFilter,
                TrueMutations =
                {
                    trueMutations ?? linq::Enumerable.Empty<Mutation>(),
                },
                FalseMutations =
                {
                    falseMutations ?? linq::Enumerable.Empty<Mutation>(),
                },
            }, callSettings);

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table to which the conditional mutation
        /// should be applied.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the conditional mutation should be
        /// applied.
        /// </param>
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, either `true_mutations` or
        /// `false_mutations` will be executed. If unset, checks that the row contains
        /// any values at all.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// yields at least one cell when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `false_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="falseMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// does not yield any cells when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `true_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(string tableName, proto::ByteString rowKey, RowFilter predicateFilter, scg::IEnumerable<Mutation> trueMutations, scg::IEnumerable<Mutation> falseMutations, st::CancellationToken cancellationToken) =>
            CheckAndMutateRowAsync(tableName, rowKey, predicateFilter, trueMutations, falseMutations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table to which the conditional mutation
        /// should be applied.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the conditional mutation should be
        /// applied.
        /// </param>
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, either `true_mutations` or
        /// `false_mutations` will be executed. If unset, checks that the row contains
        /// any values at all.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// yields at least one cell when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `false_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="falseMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// does not yield any cells when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `true_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CheckAndMutateRowResponse CheckAndMutateRow(gcbcv::TableName tableName, proto::ByteString rowKey, RowFilter predicateFilter, scg::IEnumerable<Mutation> trueMutations, scg::IEnumerable<Mutation> falseMutations, gaxgrpc::CallSettings callSettings = null) =>
            CheckAndMutateRow(new CheckAndMutateRowRequest
            {
                TableNameAsTableName = tableName,
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                PredicateFilter = predicateFilter,
                TrueMutations =
                {
                    trueMutations ?? linq::Enumerable.Empty<Mutation>(),
                },
                FalseMutations =
                {
                    falseMutations ?? linq::Enumerable.Empty<Mutation>(),
                },
            }, callSettings);

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table to which the conditional mutation
        /// should be applied.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the conditional mutation should be
        /// applied.
        /// </param>
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, either `true_mutations` or
        /// `false_mutations` will be executed. If unset, checks that the row contains
        /// any values at all.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// yields at least one cell when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `false_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="falseMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// does not yield any cells when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `true_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(gcbcv::TableName tableName, proto::ByteString rowKey, RowFilter predicateFilter, scg::IEnumerable<Mutation> trueMutations, scg::IEnumerable<Mutation> falseMutations, gaxgrpc::CallSettings callSettings = null) =>
            CheckAndMutateRowAsync(new CheckAndMutateRowRequest
            {
                TableNameAsTableName = tableName,
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                PredicateFilter = predicateFilter,
                TrueMutations =
                {
                    trueMutations ?? linq::Enumerable.Empty<Mutation>(),
                },
                FalseMutations =
                {
                    falseMutations ?? linq::Enumerable.Empty<Mutation>(),
                },
            }, callSettings);

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table to which the conditional mutation
        /// should be applied.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the conditional mutation should be
        /// applied.
        /// </param>
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, either `true_mutations` or
        /// `false_mutations` will be executed. If unset, checks that the row contains
        /// any values at all.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// yields at least one cell when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `false_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="falseMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// does not yield any cells when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `true_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(gcbcv::TableName tableName, proto::ByteString rowKey, RowFilter predicateFilter, scg::IEnumerable<Mutation> trueMutations, scg::IEnumerable<Mutation> falseMutations, st::CancellationToken cancellationToken) =>
            CheckAndMutateRowAsync(tableName, rowKey, predicateFilter, trueMutations, falseMutations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table to which the conditional mutation
        /// should be applied.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the conditional mutation should be
        /// applied.
        /// </param>
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, either `true_mutations` or
        /// `false_mutations` will be executed. If unset, checks that the row contains
        /// any values at all.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// yields at least one cell when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `false_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="falseMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// does not yield any cells when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `true_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CheckAndMutateRowResponse CheckAndMutateRow(string tableName, proto::ByteString rowKey, RowFilter predicateFilter, scg::IEnumerable<Mutation> trueMutations, scg::IEnumerable<Mutation> falseMutations, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            CheckAndMutateRow(new CheckAndMutateRowRequest
            {
                TableName = tableName ?? "",
                AppProfileId = appProfileId ?? "",
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                PredicateFilter = predicateFilter,
                TrueMutations =
                {
                    trueMutations ?? linq::Enumerable.Empty<Mutation>(),
                },
                FalseMutations =
                {
                    falseMutations ?? linq::Enumerable.Empty<Mutation>(),
                },
            }, callSettings);

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table to which the conditional mutation
        /// should be applied.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the conditional mutation should be
        /// applied.
        /// </param>
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, either `true_mutations` or
        /// `false_mutations` will be executed. If unset, checks that the row contains
        /// any values at all.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// yields at least one cell when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `false_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="falseMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// does not yield any cells when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `true_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(string tableName, proto::ByteString rowKey, RowFilter predicateFilter, scg::IEnumerable<Mutation> trueMutations, scg::IEnumerable<Mutation> falseMutations, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            CheckAndMutateRowAsync(new CheckAndMutateRowRequest
            {
                TableName = tableName ?? "",
                AppProfileId = appProfileId ?? "",
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                PredicateFilter = predicateFilter,
                TrueMutations =
                {
                    trueMutations ?? linq::Enumerable.Empty<Mutation>(),
                },
                FalseMutations =
                {
                    falseMutations ?? linq::Enumerable.Empty<Mutation>(),
                },
            }, callSettings);

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table to which the conditional mutation
        /// should be applied.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the conditional mutation should be
        /// applied.
        /// </param>
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, either `true_mutations` or
        /// `false_mutations` will be executed. If unset, checks that the row contains
        /// any values at all.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// yields at least one cell when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `false_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="falseMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// does not yield any cells when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `true_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(string tableName, proto::ByteString rowKey, RowFilter predicateFilter, scg::IEnumerable<Mutation> trueMutations, scg::IEnumerable<Mutation> falseMutations, string appProfileId, st::CancellationToken cancellationToken) =>
            CheckAndMutateRowAsync(tableName, rowKey, predicateFilter, trueMutations, falseMutations, appProfileId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table to which the conditional mutation
        /// should be applied.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the conditional mutation should be
        /// applied.
        /// </param>
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, either `true_mutations` or
        /// `false_mutations` will be executed. If unset, checks that the row contains
        /// any values at all.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// yields at least one cell when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `false_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="falseMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// does not yield any cells when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `true_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CheckAndMutateRowResponse CheckAndMutateRow(gcbcv::TableName tableName, proto::ByteString rowKey, RowFilter predicateFilter, scg::IEnumerable<Mutation> trueMutations, scg::IEnumerable<Mutation> falseMutations, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            CheckAndMutateRow(new CheckAndMutateRowRequest
            {
                TableNameAsTableName = tableName,
                AppProfileId = appProfileId ?? "",
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                PredicateFilter = predicateFilter,
                TrueMutations =
                {
                    trueMutations ?? linq::Enumerable.Empty<Mutation>(),
                },
                FalseMutations =
                {
                    falseMutations ?? linq::Enumerable.Empty<Mutation>(),
                },
            }, callSettings);

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table to which the conditional mutation
        /// should be applied.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the conditional mutation should be
        /// applied.
        /// </param>
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, either `true_mutations` or
        /// `false_mutations` will be executed. If unset, checks that the row contains
        /// any values at all.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// yields at least one cell when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `false_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="falseMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// does not yield any cells when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `true_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(gcbcv::TableName tableName, proto::ByteString rowKey, RowFilter predicateFilter, scg::IEnumerable<Mutation> trueMutations, scg::IEnumerable<Mutation> falseMutations, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            CheckAndMutateRowAsync(new CheckAndMutateRowRequest
            {
                TableNameAsTableName = tableName,
                AppProfileId = appProfileId ?? "",
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                PredicateFilter = predicateFilter,
                TrueMutations =
                {
                    trueMutations ?? linq::Enumerable.Empty<Mutation>(),
                },
                FalseMutations =
                {
                    falseMutations ?? linq::Enumerable.Empty<Mutation>(),
                },
            }, callSettings);

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table to which the conditional mutation
        /// should be applied.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the conditional mutation should be
        /// applied.
        /// </param>
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, either `true_mutations` or
        /// `false_mutations` will be executed. If unset, checks that the row contains
        /// any values at all.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// yields at least one cell when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `false_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="falseMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// does not yield any cells when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `true_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(gcbcv::TableName tableName, proto::ByteString rowKey, RowFilter predicateFilter, scg::IEnumerable<Mutation> trueMutations, scg::IEnumerable<Mutation> falseMutations, string appProfileId, st::CancellationToken cancellationToken) =>
            CheckAndMutateRowAsync(tableName, rowKey, predicateFilter, trueMutations, falseMutations, appProfileId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Warm up associated instance metadata for this connection.
        /// This call is not required but may be useful for connection keep-alive.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PingAndWarmResponse PingAndWarm(PingAndWarmRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Warm up associated instance metadata for this connection.
        /// This call is not required but may be useful for connection keep-alive.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PingAndWarmResponse> PingAndWarmAsync(PingAndWarmRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Warm up associated instance metadata for this connection.
        /// This call is not required but may be useful for connection keep-alive.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PingAndWarmResponse> PingAndWarmAsync(PingAndWarmRequest request, st::CancellationToken cancellationToken) =>
            PingAndWarmAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Warm up associated instance metadata for this connection.
        /// This call is not required but may be useful for connection keep-alive.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the instance to check permissions for as well
        /// as respond. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PingAndWarmResponse PingAndWarm(string name, gaxgrpc::CallSettings callSettings = null) =>
            PingAndWarm(new PingAndWarmRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Warm up associated instance metadata for this connection.
        /// This call is not required but may be useful for connection keep-alive.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the instance to check permissions for as well
        /// as respond. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PingAndWarmResponse> PingAndWarmAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            PingAndWarmAsync(new PingAndWarmRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Warm up associated instance metadata for this connection.
        /// This call is not required but may be useful for connection keep-alive.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the instance to check permissions for as well
        /// as respond. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PingAndWarmResponse> PingAndWarmAsync(string name, st::CancellationToken cancellationToken) =>
            PingAndWarmAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Warm up associated instance metadata for this connection.
        /// This call is not required but may be useful for connection keep-alive.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the instance to check permissions for as well
        /// as respond. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PingAndWarmResponse PingAndWarm(gcbcv::InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            PingAndWarm(new PingAndWarmRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Warm up associated instance metadata for this connection.
        /// This call is not required but may be useful for connection keep-alive.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the instance to check permissions for as well
        /// as respond. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PingAndWarmResponse> PingAndWarmAsync(gcbcv::InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            PingAndWarmAsync(new PingAndWarmRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Warm up associated instance metadata for this connection.
        /// This call is not required but may be useful for connection keep-alive.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the instance to check permissions for as well
        /// as respond. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PingAndWarmResponse> PingAndWarmAsync(gcbcv::InstanceName name, st::CancellationToken cancellationToken) =>
            PingAndWarmAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Warm up associated instance metadata for this connection.
        /// This call is not required but may be useful for connection keep-alive.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the instance to check permissions for as well
        /// as respond. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PingAndWarmResponse PingAndWarm(string name, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            PingAndWarm(new PingAndWarmRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                AppProfileId = appProfileId ?? "",
            }, callSettings);

        /// <summary>
        /// Warm up associated instance metadata for this connection.
        /// This call is not required but may be useful for connection keep-alive.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the instance to check permissions for as well
        /// as respond. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PingAndWarmResponse> PingAndWarmAsync(string name, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            PingAndWarmAsync(new PingAndWarmRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                AppProfileId = appProfileId ?? "",
            }, callSettings);

        /// <summary>
        /// Warm up associated instance metadata for this connection.
        /// This call is not required but may be useful for connection keep-alive.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the instance to check permissions for as well
        /// as respond. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PingAndWarmResponse> PingAndWarmAsync(string name, string appProfileId, st::CancellationToken cancellationToken) =>
            PingAndWarmAsync(name, appProfileId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Warm up associated instance metadata for this connection.
        /// This call is not required but may be useful for connection keep-alive.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the instance to check permissions for as well
        /// as respond. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PingAndWarmResponse PingAndWarm(gcbcv::InstanceName name, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            PingAndWarm(new PingAndWarmRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                AppProfileId = appProfileId ?? "",
            }, callSettings);

        /// <summary>
        /// Warm up associated instance metadata for this connection.
        /// This call is not required but may be useful for connection keep-alive.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the instance to check permissions for as well
        /// as respond. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PingAndWarmResponse> PingAndWarmAsync(gcbcv::InstanceName name, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            PingAndWarmAsync(new PingAndWarmRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                AppProfileId = appProfileId ?? "",
            }, callSettings);

        /// <summary>
        /// Warm up associated instance metadata for this connection.
        /// This call is not required but may be useful for connection keep-alive.
        /// </summary>
        /// <param name="name">
        /// Required. The unique name of the instance to check permissions for as well
        /// as respond. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PingAndWarmResponse> PingAndWarmAsync(gcbcv::InstanceName name, string appProfileId, st::CancellationToken cancellationToken) =>
            PingAndWarmAsync(name, appProfileId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReadModifyWriteRowResponse ReadModifyWriteRow(ReadModifyWriteRowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(ReadModifyWriteRowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(ReadModifyWriteRowRequest request, st::CancellationToken cancellationToken) =>
            ReadModifyWriteRowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table to which the read/modify/write rules
        /// should be applied.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the read/modify/write rules should be
        /// applied.
        /// </param>
        /// <param name="rules">
        /// Required. Rules specifying how the specified row's contents are to be
        /// transformed into writes. Entries are applied in order, meaning that earlier
        /// rules will affect the results of later ones.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReadModifyWriteRowResponse ReadModifyWriteRow(string tableName, proto::ByteString rowKey, scg::IEnumerable<ReadModifyWriteRule> rules, gaxgrpc::CallSettings callSettings = null) =>
            ReadModifyWriteRow(new ReadModifyWriteRowRequest
            {
                TableName = tableName ?? "",
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                Rules =
                {
                    gax::GaxPreconditions.CheckNotNull(rules, nameof(rules)),
                },
            }, callSettings);

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table to which the read/modify/write rules
        /// should be applied.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the read/modify/write rules should be
        /// applied.
        /// </param>
        /// <param name="rules">
        /// Required. Rules specifying how the specified row's contents are to be
        /// transformed into writes. Entries are applied in order, meaning that earlier
        /// rules will affect the results of later ones.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(string tableName, proto::ByteString rowKey, scg::IEnumerable<ReadModifyWriteRule> rules, gaxgrpc::CallSettings callSettings = null) =>
            ReadModifyWriteRowAsync(new ReadModifyWriteRowRequest
            {
                TableName = tableName ?? "",
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                Rules =
                {
                    gax::GaxPreconditions.CheckNotNull(rules, nameof(rules)),
                },
            }, callSettings);

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table to which the read/modify/write rules
        /// should be applied.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the read/modify/write rules should be
        /// applied.
        /// </param>
        /// <param name="rules">
        /// Required. Rules specifying how the specified row's contents are to be
        /// transformed into writes. Entries are applied in order, meaning that earlier
        /// rules will affect the results of later ones.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(string tableName, proto::ByteString rowKey, scg::IEnumerable<ReadModifyWriteRule> rules, st::CancellationToken cancellationToken) =>
            ReadModifyWriteRowAsync(tableName, rowKey, rules, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table to which the read/modify/write rules
        /// should be applied.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the read/modify/write rules should be
        /// applied.
        /// </param>
        /// <param name="rules">
        /// Required. Rules specifying how the specified row's contents are to be
        /// transformed into writes. Entries are applied in order, meaning that earlier
        /// rules will affect the results of later ones.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReadModifyWriteRowResponse ReadModifyWriteRow(gcbcv::TableName tableName, proto::ByteString rowKey, scg::IEnumerable<ReadModifyWriteRule> rules, gaxgrpc::CallSettings callSettings = null) =>
            ReadModifyWriteRow(new ReadModifyWriteRowRequest
            {
                TableNameAsTableName = tableName,
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                Rules =
                {
                    gax::GaxPreconditions.CheckNotNull(rules, nameof(rules)),
                },
            }, callSettings);

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table to which the read/modify/write rules
        /// should be applied.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the read/modify/write rules should be
        /// applied.
        /// </param>
        /// <param name="rules">
        /// Required. Rules specifying how the specified row's contents are to be
        /// transformed into writes. Entries are applied in order, meaning that earlier
        /// rules will affect the results of later ones.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(gcbcv::TableName tableName, proto::ByteString rowKey, scg::IEnumerable<ReadModifyWriteRule> rules, gaxgrpc::CallSettings callSettings = null) =>
            ReadModifyWriteRowAsync(new ReadModifyWriteRowRequest
            {
                TableNameAsTableName = tableName,
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                Rules =
                {
                    gax::GaxPreconditions.CheckNotNull(rules, nameof(rules)),
                },
            }, callSettings);

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table to which the read/modify/write rules
        /// should be applied.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the read/modify/write rules should be
        /// applied.
        /// </param>
        /// <param name="rules">
        /// Required. Rules specifying how the specified row's contents are to be
        /// transformed into writes. Entries are applied in order, meaning that earlier
        /// rules will affect the results of later ones.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(gcbcv::TableName tableName, proto::ByteString rowKey, scg::IEnumerable<ReadModifyWriteRule> rules, st::CancellationToken cancellationToken) =>
            ReadModifyWriteRowAsync(tableName, rowKey, rules, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table to which the read/modify/write rules
        /// should be applied.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the read/modify/write rules should be
        /// applied.
        /// </param>
        /// <param name="rules">
        /// Required. Rules specifying how the specified row's contents are to be
        /// transformed into writes. Entries are applied in order, meaning that earlier
        /// rules will affect the results of later ones.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReadModifyWriteRowResponse ReadModifyWriteRow(string tableName, proto::ByteString rowKey, scg::IEnumerable<ReadModifyWriteRule> rules, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            ReadModifyWriteRow(new ReadModifyWriteRowRequest
            {
                TableName = tableName ?? "",
                AppProfileId = appProfileId ?? "",
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                Rules =
                {
                    gax::GaxPreconditions.CheckNotNull(rules, nameof(rules)),
                },
            }, callSettings);

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table to which the read/modify/write rules
        /// should be applied.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the read/modify/write rules should be
        /// applied.
        /// </param>
        /// <param name="rules">
        /// Required. Rules specifying how the specified row's contents are to be
        /// transformed into writes. Entries are applied in order, meaning that earlier
        /// rules will affect the results of later ones.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(string tableName, proto::ByteString rowKey, scg::IEnumerable<ReadModifyWriteRule> rules, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            ReadModifyWriteRowAsync(new ReadModifyWriteRowRequest
            {
                TableName = tableName ?? "",
                AppProfileId = appProfileId ?? "",
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                Rules =
                {
                    gax::GaxPreconditions.CheckNotNull(rules, nameof(rules)),
                },
            }, callSettings);

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table to which the read/modify/write rules
        /// should be applied.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the read/modify/write rules should be
        /// applied.
        /// </param>
        /// <param name="rules">
        /// Required. Rules specifying how the specified row's contents are to be
        /// transformed into writes. Entries are applied in order, meaning that earlier
        /// rules will affect the results of later ones.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(string tableName, proto::ByteString rowKey, scg::IEnumerable<ReadModifyWriteRule> rules, string appProfileId, st::CancellationToken cancellationToken) =>
            ReadModifyWriteRowAsync(tableName, rowKey, rules, appProfileId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table to which the read/modify/write rules
        /// should be applied.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the read/modify/write rules should be
        /// applied.
        /// </param>
        /// <param name="rules">
        /// Required. Rules specifying how the specified row's contents are to be
        /// transformed into writes. Entries are applied in order, meaning that earlier
        /// rules will affect the results of later ones.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReadModifyWriteRowResponse ReadModifyWriteRow(gcbcv::TableName tableName, proto::ByteString rowKey, scg::IEnumerable<ReadModifyWriteRule> rules, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            ReadModifyWriteRow(new ReadModifyWriteRowRequest
            {
                TableNameAsTableName = tableName,
                AppProfileId = appProfileId ?? "",
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                Rules =
                {
                    gax::GaxPreconditions.CheckNotNull(rules, nameof(rules)),
                },
            }, callSettings);

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table to which the read/modify/write rules
        /// should be applied.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the read/modify/write rules should be
        /// applied.
        /// </param>
        /// <param name="rules">
        /// Required. Rules specifying how the specified row's contents are to be
        /// transformed into writes. Entries are applied in order, meaning that earlier
        /// rules will affect the results of later ones.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(gcbcv::TableName tableName, proto::ByteString rowKey, scg::IEnumerable<ReadModifyWriteRule> rules, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            ReadModifyWriteRowAsync(new ReadModifyWriteRowRequest
            {
                TableNameAsTableName = tableName,
                AppProfileId = appProfileId ?? "",
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                Rules =
                {
                    gax::GaxPreconditions.CheckNotNull(rules, nameof(rules)),
                },
            }, callSettings);

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="tableName">
        /// Optional. The unique name of the table to which the read/modify/write rules
        /// should be applied.
        /// 
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the read/modify/write rules should be
        /// applied.
        /// </param>
        /// <param name="rules">
        /// Required. Rules specifying how the specified row's contents are to be
        /// transformed into writes. Entries are applied in order, meaning that earlier
        /// rules will affect the results of later ones.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(gcbcv::TableName tableName, proto::ByteString rowKey, scg::IEnumerable<ReadModifyWriteRule> rules, string appProfileId, st::CancellationToken cancellationToken) =>
            ReadModifyWriteRowAsync(tableName, rowKey, rules, appProfileId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Server streaming methods for
        /// <see cref="GenerateInitialChangeStreamPartitions(GenerateInitialChangeStreamPartitionsRequest,gaxgrpc::CallSettings)"/>
        /// .
        /// </summary>
        public abstract partial class GenerateInitialChangeStreamPartitionsStream : gaxgrpc::ServerStreamingBase<GenerateInitialChangeStreamPartitionsResponse>
        {
        }

        /// <summary>
        /// NOTE: This API is intended to be used by Apache Beam BigtableIO.
        /// Returns the current list of partitions that make up the table's
        /// change stream. The union of partitions will cover the entire keyspace.
        /// Partitions can be read with `ReadChangeStream`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual GenerateInitialChangeStreamPartitionsStream GenerateInitialChangeStreamPartitions(GenerateInitialChangeStreamPartitionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// NOTE: This API is intended to be used by Apache Beam BigtableIO.
        /// Returns the current list of partitions that make up the table's
        /// change stream. The union of partitions will cover the entire keyspace.
        /// Partitions can be read with `ReadChangeStream`.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table from which to get change stream
        /// partitions. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// Change streaming must be enabled on the table.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual GenerateInitialChangeStreamPartitionsStream GenerateInitialChangeStreamPartitions(string tableName, gaxgrpc::CallSettings callSettings = null) =>
            GenerateInitialChangeStreamPartitions(new GenerateInitialChangeStreamPartitionsRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
            }, callSettings);

        /// <summary>
        /// NOTE: This API is intended to be used by Apache Beam BigtableIO.
        /// Returns the current list of partitions that make up the table's
        /// change stream. The union of partitions will cover the entire keyspace.
        /// Partitions can be read with `ReadChangeStream`.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table from which to get change stream
        /// partitions. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// Change streaming must be enabled on the table.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual GenerateInitialChangeStreamPartitionsStream GenerateInitialChangeStreamPartitions(gcbcv::TableName tableName, gaxgrpc::CallSettings callSettings = null) =>
            GenerateInitialChangeStreamPartitions(new GenerateInitialChangeStreamPartitionsRequest
            {
                TableNameAsTableName = gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
            }, callSettings);

        /// <summary>
        /// NOTE: This API is intended to be used by Apache Beam BigtableIO.
        /// Returns the current list of partitions that make up the table's
        /// change stream. The union of partitions will cover the entire keyspace.
        /// Partitions can be read with `ReadChangeStream`.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table from which to get change stream
        /// partitions. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// Change streaming must be enabled on the table.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// Single cluster routing must be configured on the profile.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual GenerateInitialChangeStreamPartitionsStream GenerateInitialChangeStreamPartitions(string tableName, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            GenerateInitialChangeStreamPartitions(new GenerateInitialChangeStreamPartitionsRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
                AppProfileId = appProfileId ?? "",
            }, callSettings);

        /// <summary>
        /// NOTE: This API is intended to be used by Apache Beam BigtableIO.
        /// Returns the current list of partitions that make up the table's
        /// change stream. The union of partitions will cover the entire keyspace.
        /// Partitions can be read with `ReadChangeStream`.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table from which to get change stream
        /// partitions. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// Change streaming must be enabled on the table.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// Single cluster routing must be configured on the profile.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual GenerateInitialChangeStreamPartitionsStream GenerateInitialChangeStreamPartitions(gcbcv::TableName tableName, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            GenerateInitialChangeStreamPartitions(new GenerateInitialChangeStreamPartitionsRequest
            {
                TableNameAsTableName = gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
                AppProfileId = appProfileId ?? "",
            }, callSettings);

        /// <summary>
        /// Server streaming methods for <see cref="ReadChangeStream(ReadChangeStreamRequest,gaxgrpc::CallSettings)"/>.
        /// </summary>
        public abstract partial class ReadChangeStreamStream : gaxgrpc::ServerStreamingBase<ReadChangeStreamResponse>
        {
        }

        /// <summary>
        /// NOTE: This API is intended to be used by Apache Beam BigtableIO.
        /// Reads changes from a table's change stream. Changes will
        /// reflect both user-initiated mutations and mutations that are caused by
        /// garbage collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ReadChangeStreamStream ReadChangeStream(ReadChangeStreamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// NOTE: This API is intended to be used by Apache Beam BigtableIO.
        /// Reads changes from a table's change stream. Changes will
        /// reflect both user-initiated mutations and mutations that are caused by
        /// garbage collection.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table from which to read a change stream.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// Change streaming must be enabled on the table.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ReadChangeStreamStream ReadChangeStream(string tableName, gaxgrpc::CallSettings callSettings = null) =>
            ReadChangeStream(new ReadChangeStreamRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
            }, callSettings);

        /// <summary>
        /// NOTE: This API is intended to be used by Apache Beam BigtableIO.
        /// Reads changes from a table's change stream. Changes will
        /// reflect both user-initiated mutations and mutations that are caused by
        /// garbage collection.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table from which to read a change stream.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// Change streaming must be enabled on the table.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ReadChangeStreamStream ReadChangeStream(gcbcv::TableName tableName, gaxgrpc::CallSettings callSettings = null) =>
            ReadChangeStream(new ReadChangeStreamRequest
            {
                TableNameAsTableName = gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
            }, callSettings);

        /// <summary>
        /// NOTE: This API is intended to be used by Apache Beam BigtableIO.
        /// Reads changes from a table's change stream. Changes will
        /// reflect both user-initiated mutations and mutations that are caused by
        /// garbage collection.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table from which to read a change stream.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// Change streaming must be enabled on the table.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// Single cluster routing must be configured on the profile.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ReadChangeStreamStream ReadChangeStream(string tableName, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            ReadChangeStream(new ReadChangeStreamRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
                AppProfileId = appProfileId ?? "",
            }, callSettings);

        /// <summary>
        /// NOTE: This API is intended to be used by Apache Beam BigtableIO.
        /// Reads changes from a table's change stream. Changes will
        /// reflect both user-initiated mutations and mutations that are caused by
        /// garbage collection.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table from which to read a change stream.
        /// Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;/tables/&lt;table&gt;`.
        /// Change streaming must be enabled on the table.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// Single cluster routing must be configured on the profile.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ReadChangeStreamStream ReadChangeStream(gcbcv::TableName tableName, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            ReadChangeStream(new ReadChangeStreamRequest
            {
                TableNameAsTableName = gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
                AppProfileId = appProfileId ?? "",
            }, callSettings);

        /// <summary>
        /// Prepares a GoogleSQL query for execution on a particular Bigtable instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrepareQueryResponse PrepareQuery(PrepareQueryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Prepares a GoogleSQL query for execution on a particular Bigtable instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrepareQueryResponse> PrepareQueryAsync(PrepareQueryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Prepares a GoogleSQL query for execution on a particular Bigtable instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrepareQueryResponse> PrepareQueryAsync(PrepareQueryRequest request, st::CancellationToken cancellationToken) =>
            PrepareQueryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Prepares a GoogleSQL query for execution on a particular Bigtable instance.
        /// </summary>
        /// <param name="instanceName">
        /// Required. The unique name of the instance against which the query should be
        /// executed.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="query">
        /// Required. The query string.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrepareQueryResponse PrepareQuery(string instanceName, string query, gaxgrpc::CallSettings callSettings = null) =>
            PrepareQuery(new PrepareQueryRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceName, nameof(instanceName)),
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            }, callSettings);

        /// <summary>
        /// Prepares a GoogleSQL query for execution on a particular Bigtable instance.
        /// </summary>
        /// <param name="instanceName">
        /// Required. The unique name of the instance against which the query should be
        /// executed.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="query">
        /// Required. The query string.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrepareQueryResponse> PrepareQueryAsync(string instanceName, string query, gaxgrpc::CallSettings callSettings = null) =>
            PrepareQueryAsync(new PrepareQueryRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceName, nameof(instanceName)),
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            }, callSettings);

        /// <summary>
        /// Prepares a GoogleSQL query for execution on a particular Bigtable instance.
        /// </summary>
        /// <param name="instanceName">
        /// Required. The unique name of the instance against which the query should be
        /// executed.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="query">
        /// Required. The query string.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrepareQueryResponse> PrepareQueryAsync(string instanceName, string query, st::CancellationToken cancellationToken) =>
            PrepareQueryAsync(instanceName, query, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Prepares a GoogleSQL query for execution on a particular Bigtable instance.
        /// </summary>
        /// <param name="instanceName">
        /// Required. The unique name of the instance against which the query should be
        /// executed.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="query">
        /// Required. The query string.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrepareQueryResponse PrepareQuery(gcbcv::InstanceName instanceName, string query, gaxgrpc::CallSettings callSettings = null) =>
            PrepareQuery(new PrepareQueryRequest
            {
                InstanceNameAsInstanceName = gax::GaxPreconditions.CheckNotNull(instanceName, nameof(instanceName)),
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            }, callSettings);

        /// <summary>
        /// Prepares a GoogleSQL query for execution on a particular Bigtable instance.
        /// </summary>
        /// <param name="instanceName">
        /// Required. The unique name of the instance against which the query should be
        /// executed.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="query">
        /// Required. The query string.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrepareQueryResponse> PrepareQueryAsync(gcbcv::InstanceName instanceName, string query, gaxgrpc::CallSettings callSettings = null) =>
            PrepareQueryAsync(new PrepareQueryRequest
            {
                InstanceNameAsInstanceName = gax::GaxPreconditions.CheckNotNull(instanceName, nameof(instanceName)),
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            }, callSettings);

        /// <summary>
        /// Prepares a GoogleSQL query for execution on a particular Bigtable instance.
        /// </summary>
        /// <param name="instanceName">
        /// Required. The unique name of the instance against which the query should be
        /// executed.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="query">
        /// Required. The query string.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrepareQueryResponse> PrepareQueryAsync(gcbcv::InstanceName instanceName, string query, st::CancellationToken cancellationToken) =>
            PrepareQueryAsync(instanceName, query, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Prepares a GoogleSQL query for execution on a particular Bigtable instance.
        /// </summary>
        /// <param name="instanceName">
        /// Required. The unique name of the instance against which the query should be
        /// executed.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="query">
        /// Required. The query string.
        /// </param>
        /// <param name="appProfileId">
        /// Optional. This value specifies routing for preparing the query. Note that
        /// this `app_profile_id` is only used for preparing the query. The actual
        /// query execution will use the app profile specified in the
        /// `ExecuteQueryRequest`. If not specified, the `default` application profile
        /// will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrepareQueryResponse PrepareQuery(string instanceName, string query, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            PrepareQuery(new PrepareQueryRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceName, nameof(instanceName)),
                AppProfileId = appProfileId ?? "",
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            }, callSettings);

        /// <summary>
        /// Prepares a GoogleSQL query for execution on a particular Bigtable instance.
        /// </summary>
        /// <param name="instanceName">
        /// Required. The unique name of the instance against which the query should be
        /// executed.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="query">
        /// Required. The query string.
        /// </param>
        /// <param name="appProfileId">
        /// Optional. This value specifies routing for preparing the query. Note that
        /// this `app_profile_id` is only used for preparing the query. The actual
        /// query execution will use the app profile specified in the
        /// `ExecuteQueryRequest`. If not specified, the `default` application profile
        /// will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrepareQueryResponse> PrepareQueryAsync(string instanceName, string query, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            PrepareQueryAsync(new PrepareQueryRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceName, nameof(instanceName)),
                AppProfileId = appProfileId ?? "",
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            }, callSettings);

        /// <summary>
        /// Prepares a GoogleSQL query for execution on a particular Bigtable instance.
        /// </summary>
        /// <param name="instanceName">
        /// Required. The unique name of the instance against which the query should be
        /// executed.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="query">
        /// Required. The query string.
        /// </param>
        /// <param name="appProfileId">
        /// Optional. This value specifies routing for preparing the query. Note that
        /// this `app_profile_id` is only used for preparing the query. The actual
        /// query execution will use the app profile specified in the
        /// `ExecuteQueryRequest`. If not specified, the `default` application profile
        /// will be used.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrepareQueryResponse> PrepareQueryAsync(string instanceName, string query, string appProfileId, st::CancellationToken cancellationToken) =>
            PrepareQueryAsync(instanceName, query, appProfileId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Prepares a GoogleSQL query for execution on a particular Bigtable instance.
        /// </summary>
        /// <param name="instanceName">
        /// Required. The unique name of the instance against which the query should be
        /// executed.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="query">
        /// Required. The query string.
        /// </param>
        /// <param name="appProfileId">
        /// Optional. This value specifies routing for preparing the query. Note that
        /// this `app_profile_id` is only used for preparing the query. The actual
        /// query execution will use the app profile specified in the
        /// `ExecuteQueryRequest`. If not specified, the `default` application profile
        /// will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrepareQueryResponse PrepareQuery(gcbcv::InstanceName instanceName, string query, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            PrepareQuery(new PrepareQueryRequest
            {
                InstanceNameAsInstanceName = gax::GaxPreconditions.CheckNotNull(instanceName, nameof(instanceName)),
                AppProfileId = appProfileId ?? "",
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            }, callSettings);

        /// <summary>
        /// Prepares a GoogleSQL query for execution on a particular Bigtable instance.
        /// </summary>
        /// <param name="instanceName">
        /// Required. The unique name of the instance against which the query should be
        /// executed.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="query">
        /// Required. The query string.
        /// </param>
        /// <param name="appProfileId">
        /// Optional. This value specifies routing for preparing the query. Note that
        /// this `app_profile_id` is only used for preparing the query. The actual
        /// query execution will use the app profile specified in the
        /// `ExecuteQueryRequest`. If not specified, the `default` application profile
        /// will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrepareQueryResponse> PrepareQueryAsync(gcbcv::InstanceName instanceName, string query, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            PrepareQueryAsync(new PrepareQueryRequest
            {
                InstanceNameAsInstanceName = gax::GaxPreconditions.CheckNotNull(instanceName, nameof(instanceName)),
                AppProfileId = appProfileId ?? "",
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            }, callSettings);

        /// <summary>
        /// Prepares a GoogleSQL query for execution on a particular Bigtable instance.
        /// </summary>
        /// <param name="instanceName">
        /// Required. The unique name of the instance against which the query should be
        /// executed.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="query">
        /// Required. The query string.
        /// </param>
        /// <param name="appProfileId">
        /// Optional. This value specifies routing for preparing the query. Note that
        /// this `app_profile_id` is only used for preparing the query. The actual
        /// query execution will use the app profile specified in the
        /// `ExecuteQueryRequest`. If not specified, the `default` application profile
        /// will be used.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrepareQueryResponse> PrepareQueryAsync(gcbcv::InstanceName instanceName, string query, string appProfileId, st::CancellationToken cancellationToken) =>
            PrepareQueryAsync(instanceName, query, appProfileId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Server streaming methods for <see cref="ExecuteQuery(ExecuteQueryRequest,gaxgrpc::CallSettings)"/>.
        /// </summary>
        public abstract partial class ExecuteQueryStream : gaxgrpc::ServerStreamingBase<ExecuteQueryResponse>
        {
        }

        /// <summary>
        /// Executes a SQL query against a particular Bigtable instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ExecuteQueryStream ExecuteQuery(ExecuteQueryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Executes a SQL query against a particular Bigtable instance.
        /// </summary>
        /// <param name="instanceName">
        /// Required. The unique name of the instance against which the query should be
        /// executed.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="query">
        /// Required. The query string.
        /// 
        /// Exactly one of `query` and `prepared_query` is required. Setting both
        /// or neither is an `INVALID_ARGUMENT`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        [sys::ObsoleteAttribute]
        public virtual ExecuteQueryStream ExecuteQuery(string instanceName, string query, gaxgrpc::CallSettings callSettings = null) =>
            ExecuteQuery(new ExecuteQueryRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceName, nameof(instanceName)),
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            }, callSettings);

        /// <summary>
        /// Executes a SQL query against a particular Bigtable instance.
        /// </summary>
        /// <param name="instanceName">
        /// Required. The unique name of the instance against which the query should be
        /// executed.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="query">
        /// Required. The query string.
        /// 
        /// Exactly one of `query` and `prepared_query` is required. Setting both
        /// or neither is an `INVALID_ARGUMENT`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        [sys::ObsoleteAttribute]
        public virtual ExecuteQueryStream ExecuteQuery(gcbcv::InstanceName instanceName, string query, gaxgrpc::CallSettings callSettings = null) =>
            ExecuteQuery(new ExecuteQueryRequest
            {
                InstanceNameAsInstanceName = gax::GaxPreconditions.CheckNotNull(instanceName, nameof(instanceName)),
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            }, callSettings);

        /// <summary>
        /// Executes a SQL query against a particular Bigtable instance.
        /// </summary>
        /// <param name="instanceName">
        /// Required. The unique name of the instance against which the query should be
        /// executed.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="query">
        /// Required. The query string.
        /// 
        /// Exactly one of `query` and `prepared_query` is required. Setting both
        /// or neither is an `INVALID_ARGUMENT`.
        /// </param>
        /// <param name="appProfileId">
        /// Optional. This value specifies routing for replication. If not specified,
        /// the `default` application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        [sys::ObsoleteAttribute]
        public virtual ExecuteQueryStream ExecuteQuery(string instanceName, string query, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            ExecuteQuery(new ExecuteQueryRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceName, nameof(instanceName)),
                AppProfileId = appProfileId ?? "",
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            }, callSettings);

        /// <summary>
        /// Executes a SQL query against a particular Bigtable instance.
        /// </summary>
        /// <param name="instanceName">
        /// Required. The unique name of the instance against which the query should be
        /// executed.
        /// Values are of the form `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="query">
        /// Required. The query string.
        /// 
        /// Exactly one of `query` and `prepared_query` is required. Setting both
        /// or neither is an `INVALID_ARGUMENT`.
        /// </param>
        /// <param name="appProfileId">
        /// Optional. This value specifies routing for replication. If not specified,
        /// the `default` application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        [sys::ObsoleteAttribute]
        public virtual ExecuteQueryStream ExecuteQuery(gcbcv::InstanceName instanceName, string query, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            ExecuteQuery(new ExecuteQueryRequest
            {
                InstanceNameAsInstanceName = gax::GaxPreconditions.CheckNotNull(instanceName, nameof(instanceName)),
                AppProfileId = appProfileId ?? "",
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            }, callSettings);
    }

    /// <summary>BigtableServiceApi client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for reading from and writing to existing Bigtable tables.
    /// </remarks>
    public sealed partial class BigtableServiceApiClientImpl : BigtableServiceApiClient
    {
        private readonly gaxgrpc::ApiServerStreamingCall<ReadRowsRequest, ReadRowsResponse> _callReadRows;

        private readonly gaxgrpc::ApiServerStreamingCall<SampleRowKeysRequest, SampleRowKeysResponse> _callSampleRowKeys;

        private readonly gaxgrpc::ApiCall<MutateRowRequest, MutateRowResponse> _callMutateRow;

        private readonly gaxgrpc::ApiServerStreamingCall<MutateRowsRequest, MutateRowsResponse> _callMutateRows;

        private readonly gaxgrpc::ApiCall<CheckAndMutateRowRequest, CheckAndMutateRowResponse> _callCheckAndMutateRow;

        private readonly gaxgrpc::ApiCall<PingAndWarmRequest, PingAndWarmResponse> _callPingAndWarm;

        private readonly gaxgrpc::ApiCall<ReadModifyWriteRowRequest, ReadModifyWriteRowResponse> _callReadModifyWriteRow;

        private readonly gaxgrpc::ApiServerStreamingCall<GenerateInitialChangeStreamPartitionsRequest, GenerateInitialChangeStreamPartitionsResponse> _callGenerateInitialChangeStreamPartitions;

        private readonly gaxgrpc::ApiServerStreamingCall<ReadChangeStreamRequest, ReadChangeStreamResponse> _callReadChangeStream;

        private readonly gaxgrpc::ApiCall<PrepareQueryRequest, PrepareQueryResponse> _callPrepareQuery;

        private readonly gaxgrpc::ApiServerStreamingCall<ExecuteQueryRequest, ExecuteQueryResponse> _callExecuteQuery;

        /// <summary>
        /// Constructs a client wrapper for the BigtableServiceApi service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="BigtableServiceApiSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public BigtableServiceApiClientImpl(Bigtable.BigtableClient grpcClient, BigtableServiceApiSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            BigtableServiceApiSettings effectiveSettings = settings ?? BigtableServiceApiSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callReadRows = clientHelper.BuildApiCall<ReadRowsRequest, ReadRowsResponse>("ReadRows", grpcClient.ReadRows, effectiveSettings.ReadRowsSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<ReadRowsRequest>().WithExtractedParameter("table_name", "^(projects/[^/]+/instances/[^/]+/tables/[^/]+)/?$", request => request.TableName).WithExtractedParameter("app_profile_id", "^(.+)$", request => request.AppProfileId).WithExtractedParameter("authorized_view_name", "^(projects/[^/]+/instances/[^/]+/tables/[^/]+/authorizedViews/[^/]+)/?$", request => request.AuthorizedViewName));
            Modify_ApiCall(ref _callReadRows);
            Modify_ReadRowsApiCall(ref _callReadRows);
            _callSampleRowKeys = clientHelper.BuildApiCall<SampleRowKeysRequest, SampleRowKeysResponse>("SampleRowKeys", grpcClient.SampleRowKeys, effectiveSettings.SampleRowKeysSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<SampleRowKeysRequest>().WithExtractedParameter("table_name", "^(projects/[^/]+/instances/[^/]+/tables/[^/]+)/?$", request => request.TableName).WithExtractedParameter("app_profile_id", "^(.+)$", request => request.AppProfileId).WithExtractedParameter("authorized_view_name", "^(projects/[^/]+/instances/[^/]+/tables/[^/]+/authorizedViews/[^/]+)/?$", request => request.AuthorizedViewName));
            Modify_ApiCall(ref _callSampleRowKeys);
            Modify_SampleRowKeysApiCall(ref _callSampleRowKeys);
            _callMutateRow = clientHelper.BuildApiCall<MutateRowRequest, MutateRowResponse>("MutateRow", grpcClient.MutateRowAsync, grpcClient.MutateRow, effectiveSettings.MutateRowSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<MutateRowRequest>().WithExtractedParameter("table_name", "^(projects/[^/]+/instances/[^/]+/tables/[^/]+)/?$", request => request.TableName).WithExtractedParameter("app_profile_id", "^(.+)$", request => request.AppProfileId).WithExtractedParameter("authorized_view_name", "^(projects/[^/]+/instances/[^/]+/tables/[^/]+/authorizedViews/[^/]+)/?$", request => request.AuthorizedViewName));
            Modify_ApiCall(ref _callMutateRow);
            Modify_MutateRowApiCall(ref _callMutateRow);
            _callMutateRows = clientHelper.BuildApiCall<MutateRowsRequest, MutateRowsResponse>("MutateRows", grpcClient.MutateRows, effectiveSettings.MutateRowsSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<MutateRowsRequest>().WithExtractedParameter("table_name", "^(projects/[^/]+/instances/[^/]+/tables/[^/]+)/?$", request => request.TableName).WithExtractedParameter("app_profile_id", "^(.+)$", request => request.AppProfileId).WithExtractedParameter("authorized_view_name", "^(projects/[^/]+/instances/[^/]+/tables/[^/]+/authorizedViews/[^/]+)/?$", request => request.AuthorizedViewName));
            Modify_ApiCall(ref _callMutateRows);
            Modify_MutateRowsApiCall(ref _callMutateRows);
            _callCheckAndMutateRow = clientHelper.BuildApiCall<CheckAndMutateRowRequest, CheckAndMutateRowResponse>("CheckAndMutateRow", grpcClient.CheckAndMutateRowAsync, grpcClient.CheckAndMutateRow, effectiveSettings.CheckAndMutateRowSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<CheckAndMutateRowRequest>().WithExtractedParameter("table_name", "^(projects/[^/]+/instances/[^/]+/tables/[^/]+)/?$", request => request.TableName).WithExtractedParameter("app_profile_id", "^(.+)$", request => request.AppProfileId).WithExtractedParameter("authorized_view_name", "^(projects/[^/]+/instances/[^/]+/tables/[^/]+/authorizedViews/[^/]+)/?$", request => request.AuthorizedViewName));
            Modify_ApiCall(ref _callCheckAndMutateRow);
            Modify_CheckAndMutateRowApiCall(ref _callCheckAndMutateRow);
            _callPingAndWarm = clientHelper.BuildApiCall<PingAndWarmRequest, PingAndWarmResponse>("PingAndWarm", grpcClient.PingAndWarmAsync, grpcClient.PingAndWarm, effectiveSettings.PingAndWarmSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<PingAndWarmRequest>().WithExtractedParameter("name", "^(projects/[^/]+/instances/[^/]+)/?$", request => request.Name).WithExtractedParameter("app_profile_id", "^(.+)$", request => request.AppProfileId));
            Modify_ApiCall(ref _callPingAndWarm);
            Modify_PingAndWarmApiCall(ref _callPingAndWarm);
            _callReadModifyWriteRow = clientHelper.BuildApiCall<ReadModifyWriteRowRequest, ReadModifyWriteRowResponse>("ReadModifyWriteRow", grpcClient.ReadModifyWriteRowAsync, grpcClient.ReadModifyWriteRow, effectiveSettings.ReadModifyWriteRowSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<ReadModifyWriteRowRequest>().WithExtractedParameter("table_name", "^(projects/[^/]+/instances/[^/]+/tables/[^/]+)/?$", request => request.TableName).WithExtractedParameter("app_profile_id", "^(.+)$", request => request.AppProfileId).WithExtractedParameter("authorized_view_name", "^(projects/[^/]+/instances/[^/]+/tables/[^/]+/authorizedViews/[^/]+)/?$", request => request.AuthorizedViewName));
            Modify_ApiCall(ref _callReadModifyWriteRow);
            Modify_ReadModifyWriteRowApiCall(ref _callReadModifyWriteRow);
            _callGenerateInitialChangeStreamPartitions = clientHelper.BuildApiCall<GenerateInitialChangeStreamPartitionsRequest, GenerateInitialChangeStreamPartitionsResponse>("GenerateInitialChangeStreamPartitions", grpcClient.GenerateInitialChangeStreamPartitions, effectiveSettings.GenerateInitialChangeStreamPartitionsSettings).WithGoogleRequestParam("table_name", request => request.TableName);
            Modify_ApiCall(ref _callGenerateInitialChangeStreamPartitions);
            Modify_GenerateInitialChangeStreamPartitionsApiCall(ref _callGenerateInitialChangeStreamPartitions);
            _callReadChangeStream = clientHelper.BuildApiCall<ReadChangeStreamRequest, ReadChangeStreamResponse>("ReadChangeStream", grpcClient.ReadChangeStream, effectiveSettings.ReadChangeStreamSettings).WithGoogleRequestParam("table_name", request => request.TableName);
            Modify_ApiCall(ref _callReadChangeStream);
            Modify_ReadChangeStreamApiCall(ref _callReadChangeStream);
            _callPrepareQuery = clientHelper.BuildApiCall<PrepareQueryRequest, PrepareQueryResponse>("PrepareQuery", grpcClient.PrepareQueryAsync, grpcClient.PrepareQuery, effectiveSettings.PrepareQuerySettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<PrepareQueryRequest>().WithExtractedParameter("name", "^(projects/[^/]+/instances/[^/]+)/?$", request => request.InstanceName).WithExtractedParameter("app_profile_id", "^(.+)$", request => request.AppProfileId));
            Modify_ApiCall(ref _callPrepareQuery);
            Modify_PrepareQueryApiCall(ref _callPrepareQuery);
            _callExecuteQuery = clientHelper.BuildApiCall<ExecuteQueryRequest, ExecuteQueryResponse>("ExecuteQuery", grpcClient.ExecuteQuery, effectiveSettings.ExecuteQuerySettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<ExecuteQueryRequest>().WithExtractedParameter("name", "^(projects/[^/]+/instances/[^/]+)/?$", request => request.InstanceName).WithExtractedParameter("app_profile_id", "^(.+)$", request => request.AppProfileId));
            Modify_ApiCall(ref _callExecuteQuery);
            Modify_ExecuteQueryApiCall(ref _callExecuteQuery);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiServerStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ReadRowsApiCall(ref gaxgrpc::ApiServerStreamingCall<ReadRowsRequest, ReadRowsResponse> call);

        partial void Modify_SampleRowKeysApiCall(ref gaxgrpc::ApiServerStreamingCall<SampleRowKeysRequest, SampleRowKeysResponse> call);

        partial void Modify_MutateRowApiCall(ref gaxgrpc::ApiCall<MutateRowRequest, MutateRowResponse> call);

        partial void Modify_MutateRowsApiCall(ref gaxgrpc::ApiServerStreamingCall<MutateRowsRequest, MutateRowsResponse> call);

        partial void Modify_CheckAndMutateRowApiCall(ref gaxgrpc::ApiCall<CheckAndMutateRowRequest, CheckAndMutateRowResponse> call);

        partial void Modify_PingAndWarmApiCall(ref gaxgrpc::ApiCall<PingAndWarmRequest, PingAndWarmResponse> call);

        partial void Modify_ReadModifyWriteRowApiCall(ref gaxgrpc::ApiCall<ReadModifyWriteRowRequest, ReadModifyWriteRowResponse> call);

        partial void Modify_GenerateInitialChangeStreamPartitionsApiCall(ref gaxgrpc::ApiServerStreamingCall<GenerateInitialChangeStreamPartitionsRequest, GenerateInitialChangeStreamPartitionsResponse> call);

        partial void Modify_ReadChangeStreamApiCall(ref gaxgrpc::ApiServerStreamingCall<ReadChangeStreamRequest, ReadChangeStreamResponse> call);

        partial void Modify_PrepareQueryApiCall(ref gaxgrpc::ApiCall<PrepareQueryRequest, PrepareQueryResponse> call);

        partial void Modify_ExecuteQueryApiCall(ref gaxgrpc::ApiServerStreamingCall<ExecuteQueryRequest, ExecuteQueryResponse> call);

        partial void OnConstruction(Bigtable.BigtableClient grpcClient, BigtableServiceApiSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC BigtableServiceApi client</summary>
        public override Bigtable.BigtableClient GrpcClient { get; }

        partial void Modify_ReadRowsRequest(ref ReadRowsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SampleRowKeysRequest(ref SampleRowKeysRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateRowRequest(ref MutateRowRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateRowsRequest(ref MutateRowsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CheckAndMutateRowRequest(ref CheckAndMutateRowRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PingAndWarmRequest(ref PingAndWarmRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReadModifyWriteRowRequest(ref ReadModifyWriteRowRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateInitialChangeStreamPartitionsRequest(ref GenerateInitialChangeStreamPartitionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReadChangeStreamRequest(ref ReadChangeStreamRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PrepareQueryRequest(ref PrepareQueryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExecuteQueryRequest(ref ExecuteQueryRequest request, ref gaxgrpc::CallSettings settings);

        internal sealed partial class ReadRowsStreamImpl : ReadRowsStream
        {
            /// <summary>Construct the server streaming method for <c>ReadRows</c>.</summary>
            /// <param name="call">The underlying gRPC server streaming call.</param>
            public ReadRowsStreamImpl(grpccore::AsyncServerStreamingCall<ReadRowsResponse> call) => GrpcCall = call;

            public override grpccore::AsyncServerStreamingCall<ReadRowsResponse> GrpcCall { get; }
        }

        /// <summary>
        /// Streams back the contents of all requested rows in key order, optionally
        /// applying the same Reader filter to each. Depending on their size,
        /// rows and cells may be broken up across multiple responses, but
        /// atomicity of each row will still be preserved. See the
        /// ReadRowsResponse documentation for details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public override BigtableServiceApiClient.ReadRowsStream ReadRows(ReadRowsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReadRowsRequest(ref request, ref callSettings);
            return new ReadRowsStreamImpl(_callReadRows.Call(request, callSettings));
        }

        internal sealed partial class SampleRowKeysStreamImpl : SampleRowKeysStream
        {
            /// <summary>Construct the server streaming method for <c>SampleRowKeys</c>.</summary>
            /// <param name="call">The underlying gRPC server streaming call.</param>
            public SampleRowKeysStreamImpl(grpccore::AsyncServerStreamingCall<SampleRowKeysResponse> call) => GrpcCall = call;

            public override grpccore::AsyncServerStreamingCall<SampleRowKeysResponse> GrpcCall { get; }
        }

        /// <summary>
        /// Returns a sample of row keys in the table. The returned row keys will
        /// delimit contiguous sections of the table of approximately equal size,
        /// which can be used to break up the data for distributed tasks like
        /// mapreduces.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public override BigtableServiceApiClient.SampleRowKeysStream SampleRowKeys(SampleRowKeysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SampleRowKeysRequest(ref request, ref callSettings);
            return new SampleRowKeysStreamImpl(_callSampleRowKeys.Call(request, callSettings));
        }

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateRowResponse MutateRow(MutateRowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateRowRequest(ref request, ref callSettings);
            return _callMutateRow.Sync(request, callSettings);
        }

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateRowResponse> MutateRowAsync(MutateRowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateRowRequest(ref request, ref callSettings);
            return _callMutateRow.Async(request, callSettings);
        }

        internal sealed partial class MutateRowsStreamImpl : MutateRowsStream
        {
            /// <summary>Construct the server streaming method for <c>MutateRows</c>.</summary>
            /// <param name="call">The underlying gRPC server streaming call.</param>
            public MutateRowsStreamImpl(grpccore::AsyncServerStreamingCall<MutateRowsResponse> call) => GrpcCall = call;

            public override grpccore::AsyncServerStreamingCall<MutateRowsResponse> GrpcCall { get; }
        }

        /// <summary>
        /// Mutates multiple rows in a batch. Each individual row is mutated
        /// atomically as in MutateRow, but the entire batch is not executed
        /// atomically.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public override BigtableServiceApiClient.MutateRowsStream MutateRows(MutateRowsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateRowsRequest(ref request, ref callSettings);
            return new MutateRowsStreamImpl(_callMutateRows.Call(request, callSettings));
        }

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CheckAndMutateRowResponse CheckAndMutateRow(CheckAndMutateRowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CheckAndMutateRowRequest(ref request, ref callSettings);
            return _callCheckAndMutateRow.Sync(request, callSettings);
        }

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(CheckAndMutateRowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CheckAndMutateRowRequest(ref request, ref callSettings);
            return _callCheckAndMutateRow.Async(request, callSettings);
        }

        /// <summary>
        /// Warm up associated instance metadata for this connection.
        /// This call is not required but may be useful for connection keep-alive.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PingAndWarmResponse PingAndWarm(PingAndWarmRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PingAndWarmRequest(ref request, ref callSettings);
            return _callPingAndWarm.Sync(request, callSettings);
        }

        /// <summary>
        /// Warm up associated instance metadata for this connection.
        /// This call is not required but may be useful for connection keep-alive.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PingAndWarmResponse> PingAndWarmAsync(PingAndWarmRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PingAndWarmRequest(ref request, ref callSettings);
            return _callPingAndWarm.Async(request, callSettings);
        }

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReadModifyWriteRowResponse ReadModifyWriteRow(ReadModifyWriteRowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReadModifyWriteRowRequest(ref request, ref callSettings);
            return _callReadModifyWriteRow.Sync(request, callSettings);
        }

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(ReadModifyWriteRowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReadModifyWriteRowRequest(ref request, ref callSettings);
            return _callReadModifyWriteRow.Async(request, callSettings);
        }

        internal sealed partial class GenerateInitialChangeStreamPartitionsStreamImpl : GenerateInitialChangeStreamPartitionsStream
        {
            /// <summary>
            /// Construct the server streaming method for <c>GenerateInitialChangeStreamPartitions</c>.
            /// </summary>
            /// <param name="call">The underlying gRPC server streaming call.</param>
            public GenerateInitialChangeStreamPartitionsStreamImpl(grpccore::AsyncServerStreamingCall<GenerateInitialChangeStreamPartitionsResponse> call) => GrpcCall = call;

            public override grpccore::AsyncServerStreamingCall<GenerateInitialChangeStreamPartitionsResponse> GrpcCall { get; }
        }

        /// <summary>
        /// NOTE: This API is intended to be used by Apache Beam BigtableIO.
        /// Returns the current list of partitions that make up the table's
        /// change stream. The union of partitions will cover the entire keyspace.
        /// Partitions can be read with `ReadChangeStream`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public override BigtableServiceApiClient.GenerateInitialChangeStreamPartitionsStream GenerateInitialChangeStreamPartitions(GenerateInitialChangeStreamPartitionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateInitialChangeStreamPartitionsRequest(ref request, ref callSettings);
            return new GenerateInitialChangeStreamPartitionsStreamImpl(_callGenerateInitialChangeStreamPartitions.Call(request, callSettings));
        }

        internal sealed partial class ReadChangeStreamStreamImpl : ReadChangeStreamStream
        {
            /// <summary>Construct the server streaming method for <c>ReadChangeStream</c>.</summary>
            /// <param name="call">The underlying gRPC server streaming call.</param>
            public ReadChangeStreamStreamImpl(grpccore::AsyncServerStreamingCall<ReadChangeStreamResponse> call) => GrpcCall = call;

            public override grpccore::AsyncServerStreamingCall<ReadChangeStreamResponse> GrpcCall { get; }
        }

        /// <summary>
        /// NOTE: This API is intended to be used by Apache Beam BigtableIO.
        /// Reads changes from a table's change stream. Changes will
        /// reflect both user-initiated mutations and mutations that are caused by
        /// garbage collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public override BigtableServiceApiClient.ReadChangeStreamStream ReadChangeStream(ReadChangeStreamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReadChangeStreamRequest(ref request, ref callSettings);
            return new ReadChangeStreamStreamImpl(_callReadChangeStream.Call(request, callSettings));
        }

        /// <summary>
        /// Prepares a GoogleSQL query for execution on a particular Bigtable instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PrepareQueryResponse PrepareQuery(PrepareQueryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PrepareQueryRequest(ref request, ref callSettings);
            return _callPrepareQuery.Sync(request, callSettings);
        }

        /// <summary>
        /// Prepares a GoogleSQL query for execution on a particular Bigtable instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PrepareQueryResponse> PrepareQueryAsync(PrepareQueryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PrepareQueryRequest(ref request, ref callSettings);
            return _callPrepareQuery.Async(request, callSettings);
        }

        internal sealed partial class ExecuteQueryStreamImpl : ExecuteQueryStream
        {
            /// <summary>Construct the server streaming method for <c>ExecuteQuery</c>.</summary>
            /// <param name="call">The underlying gRPC server streaming call.</param>
            public ExecuteQueryStreamImpl(grpccore::AsyncServerStreamingCall<ExecuteQueryResponse> call) => GrpcCall = call;

            public override grpccore::AsyncServerStreamingCall<ExecuteQueryResponse> GrpcCall { get; }
        }

        /// <summary>
        /// Executes a SQL query against a particular Bigtable instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public override BigtableServiceApiClient.ExecuteQueryStream ExecuteQuery(ExecuteQueryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExecuteQueryRequest(ref request, ref callSettings);
            return new ExecuteQueryStreamImpl(_callExecuteQuery.Call(request, callSettings));
        }
    }
}
