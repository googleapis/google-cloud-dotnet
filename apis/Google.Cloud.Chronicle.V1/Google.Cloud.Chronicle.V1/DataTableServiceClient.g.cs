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
    /// <summary>Settings for <see cref="DataTableServiceClient"/> instances.</summary>
    public sealed partial class DataTableServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DataTableServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DataTableServiceSettings"/>.</returns>
        public static DataTableServiceSettings GetDefault() => new DataTableServiceSettings();

        /// <summary>Constructs a new <see cref="DataTableServiceSettings"/> object with default settings.</summary>
        public DataTableServiceSettings()
        {
        }

        private DataTableServiceSettings(DataTableServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateDataTableSettings = existing.CreateDataTableSettings;
            ListDataTablesSettings = existing.ListDataTablesSettings;
            GetDataTableSettings = existing.GetDataTableSettings;
            UpdateDataTableSettings = existing.UpdateDataTableSettings;
            DeleteDataTableSettings = existing.DeleteDataTableSettings;
            CreateDataTableRowSettings = existing.CreateDataTableRowSettings;
            UpdateDataTableRowSettings = existing.UpdateDataTableRowSettings;
            ListDataTableRowsSettings = existing.ListDataTableRowsSettings;
            GetDataTableRowSettings = existing.GetDataTableRowSettings;
            DeleteDataTableRowSettings = existing.DeleteDataTableRowSettings;
            BulkCreateDataTableRowsSettings = existing.BulkCreateDataTableRowsSettings;
            BulkGetDataTableRowsSettings = existing.BulkGetDataTableRowsSettings;
            BulkReplaceDataTableRowsSettings = existing.BulkReplaceDataTableRowsSettings;
            BulkUpdateDataTableRowsSettings = existing.BulkUpdateDataTableRowsSettings;
            GetDataTableOperationErrorsSettings = existing.GetDataTableOperationErrorsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DataTableServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTableServiceClient.CreateDataTable</c> and <c>DataTableServiceClient.CreateDataTableAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDataTableSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTableServiceClient.ListDataTables</c> and <c>DataTableServiceClient.ListDataTablesAsync</c>.
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
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDataTablesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTableServiceClient.GetDataTable</c> and <c>DataTableServiceClient.GetDataTableAsync</c>.
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
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDataTableSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTableServiceClient.UpdateDataTable</c> and <c>DataTableServiceClient.UpdateDataTableAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDataTableSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTableServiceClient.DeleteDataTable</c> and <c>DataTableServiceClient.DeleteDataTableAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDataTableSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTableServiceClient.CreateDataTableRow</c> and <c>DataTableServiceClient.CreateDataTableRowAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDataTableRowSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTableServiceClient.UpdateDataTableRow</c> and <c>DataTableServiceClient.UpdateDataTableRowAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDataTableRowSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTableServiceClient.ListDataTableRows</c> and <c>DataTableServiceClient.ListDataTableRowsAsync</c>.
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
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDataTableRowsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTableServiceClient.GetDataTableRow</c> and <c>DataTableServiceClient.GetDataTableRowAsync</c>.
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
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDataTableRowSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTableServiceClient.DeleteDataTableRow</c> and <c>DataTableServiceClient.DeleteDataTableRowAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDataTableRowSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTableServiceClient.BulkCreateDataTableRows</c> and
        /// <c>DataTableServiceClient.BulkCreateDataTableRowsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BulkCreateDataTableRowsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTableServiceClient.BulkGetDataTableRows</c> and <c>DataTableServiceClient.BulkGetDataTableRowsAsync</c>
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
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BulkGetDataTableRowsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTableServiceClient.BulkReplaceDataTableRows</c> and
        /// <c>DataTableServiceClient.BulkReplaceDataTableRowsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BulkReplaceDataTableRowsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTableServiceClient.BulkUpdateDataTableRows</c> and
        /// <c>DataTableServiceClient.BulkUpdateDataTableRowsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BulkUpdateDataTableRowsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataTableServiceClient.GetDataTableOperationErrors</c> and
        /// <c>DataTableServiceClient.GetDataTableOperationErrorsAsync</c>.
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
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDataTableOperationErrorsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DataTableServiceSettings"/> object.</returns>
        public DataTableServiceSettings Clone() => new DataTableServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DataTableServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class DataTableServiceClientBuilder : gaxgrpc::ClientBuilderBase<DataTableServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DataTableServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DataTableServiceClientBuilder() : base(DataTableServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DataTableServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DataTableServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DataTableServiceClient Build()
        {
            DataTableServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DataTableServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DataTableServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DataTableServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DataTableServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DataTableServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DataTableServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DataTableServiceClient.ChannelPool;
    }

    /// <summary>DataTableService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// DataTableManager provides an interface for managing data tables.
    /// </remarks>
    public abstract partial class DataTableServiceClient
    {
        /// <summary>
        /// The default endpoint for the DataTableService service, which is a host of "chronicle.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "chronicle.googleapis.com:443";

        /// <summary>The default DataTableService scopes.</summary>
        /// <remarks>
        /// The default DataTableService scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DataTableService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DataTableServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DataTableServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DataTableServiceClient"/>.</returns>
        public static stt::Task<DataTableServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DataTableServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DataTableServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DataTableServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DataTableServiceClient"/>.</returns>
        public static DataTableServiceClient Create() => new DataTableServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DataTableServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DataTableServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DataTableServiceClient"/>.</returns>
        internal static DataTableServiceClient Create(grpccore::CallInvoker callInvoker, DataTableServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DataTableService.DataTableServiceClient grpcClient = new DataTableService.DataTableServiceClient(callInvoker);
            return new DataTableServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DataTableService client</summary>
        public virtual DataTableService.DataTableServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new data table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataTable CreateDataTable(CreateDataTableRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new data table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTable> CreateDataTableAsync(CreateDataTableRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new data table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTable> CreateDataTableAsync(CreateDataTableRequest request, st::CancellationToken cancellationToken) =>
            CreateDataTableAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new data table.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this data table will be created.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="dataTable">
        /// Required. The data table being created.
        /// </param>
        /// <param name="dataTableId">
        /// Required. The ID to use for the data table. This is also the display name
        /// for the data table. It must satisfy the following requirements:
        /// - Starts with letter.
        /// - Contains only letters, numbers and underscore.
        /// - Must be unique and has length &lt; 256.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataTable CreateDataTable(string parent, DataTable dataTable, string dataTableId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataTable(new CreateDataTableRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DataTable = gax::GaxPreconditions.CheckNotNull(dataTable, nameof(dataTable)),
                DataTableId = gax::GaxPreconditions.CheckNotNullOrEmpty(dataTableId, nameof(dataTableId)),
            }, callSettings);

        /// <summary>
        /// Create a new data table.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this data table will be created.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="dataTable">
        /// Required. The data table being created.
        /// </param>
        /// <param name="dataTableId">
        /// Required. The ID to use for the data table. This is also the display name
        /// for the data table. It must satisfy the following requirements:
        /// - Starts with letter.
        /// - Contains only letters, numbers and underscore.
        /// - Must be unique and has length &lt; 256.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTable> CreateDataTableAsync(string parent, DataTable dataTable, string dataTableId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataTableAsync(new CreateDataTableRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DataTable = gax::GaxPreconditions.CheckNotNull(dataTable, nameof(dataTable)),
                DataTableId = gax::GaxPreconditions.CheckNotNullOrEmpty(dataTableId, nameof(dataTableId)),
            }, callSettings);

        /// <summary>
        /// Create a new data table.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this data table will be created.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="dataTable">
        /// Required. The data table being created.
        /// </param>
        /// <param name="dataTableId">
        /// Required. The ID to use for the data table. This is also the display name
        /// for the data table. It must satisfy the following requirements:
        /// - Starts with letter.
        /// - Contains only letters, numbers and underscore.
        /// - Must be unique and has length &lt; 256.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTable> CreateDataTableAsync(string parent, DataTable dataTable, string dataTableId, st::CancellationToken cancellationToken) =>
            CreateDataTableAsync(parent, dataTable, dataTableId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new data table.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this data table will be created.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="dataTable">
        /// Required. The data table being created.
        /// </param>
        /// <param name="dataTableId">
        /// Required. The ID to use for the data table. This is also the display name
        /// for the data table. It must satisfy the following requirements:
        /// - Starts with letter.
        /// - Contains only letters, numbers and underscore.
        /// - Must be unique and has length &lt; 256.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataTable CreateDataTable(InstanceName parent, DataTable dataTable, string dataTableId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataTable(new CreateDataTableRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DataTable = gax::GaxPreconditions.CheckNotNull(dataTable, nameof(dataTable)),
                DataTableId = gax::GaxPreconditions.CheckNotNullOrEmpty(dataTableId, nameof(dataTableId)),
            }, callSettings);

        /// <summary>
        /// Create a new data table.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this data table will be created.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="dataTable">
        /// Required. The data table being created.
        /// </param>
        /// <param name="dataTableId">
        /// Required. The ID to use for the data table. This is also the display name
        /// for the data table. It must satisfy the following requirements:
        /// - Starts with letter.
        /// - Contains only letters, numbers and underscore.
        /// - Must be unique and has length &lt; 256.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTable> CreateDataTableAsync(InstanceName parent, DataTable dataTable, string dataTableId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataTableAsync(new CreateDataTableRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DataTable = gax::GaxPreconditions.CheckNotNull(dataTable, nameof(dataTable)),
                DataTableId = gax::GaxPreconditions.CheckNotNullOrEmpty(dataTableId, nameof(dataTableId)),
            }, callSettings);

        /// <summary>
        /// Create a new data table.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this data table will be created.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="dataTable">
        /// Required. The data table being created.
        /// </param>
        /// <param name="dataTableId">
        /// Required. The ID to use for the data table. This is also the display name
        /// for the data table. It must satisfy the following requirements:
        /// - Starts with letter.
        /// - Contains only letters, numbers and underscore.
        /// - Must be unique and has length &lt; 256.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTable> CreateDataTableAsync(InstanceName parent, DataTable dataTable, string dataTableId, st::CancellationToken cancellationToken) =>
            CreateDataTableAsync(parent, dataTable, dataTableId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List data tables.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataTable"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataTablesResponse, DataTable> ListDataTables(ListDataTablesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List data tables.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataTable"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataTablesResponse, DataTable> ListDataTablesAsync(ListDataTablesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List data tables.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this data table will be created.
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
        /// <returns>A pageable sequence of <see cref="DataTable"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataTablesResponse, DataTable> ListDataTables(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataTablesRequest request = new ListDataTablesRequest
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
            return ListDataTables(request, callSettings);
        }

        /// <summary>
        /// List data tables.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this data table will be created.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataTable"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataTablesResponse, DataTable> ListDataTablesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataTablesRequest request = new ListDataTablesRequest
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
            return ListDataTablesAsync(request, callSettings);
        }

        /// <summary>
        /// List data tables.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this data table will be created.
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
        /// <returns>A pageable sequence of <see cref="DataTable"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataTablesResponse, DataTable> ListDataTables(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataTablesRequest request = new ListDataTablesRequest
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
            return ListDataTables(request, callSettings);
        }

        /// <summary>
        /// List data tables.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this data table will be created.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataTable"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataTablesResponse, DataTable> ListDataTablesAsync(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataTablesRequest request = new ListDataTablesRequest
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
            return ListDataTablesAsync(request, callSettings);
        }

        /// <summary>
        /// Get data table info.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataTable GetDataTable(GetDataTableRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get data table info.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTable> GetDataTableAsync(GetDataTableRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get data table info.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTable> GetDataTableAsync(GetDataTableRequest request, st::CancellationToken cancellationToken) =>
            GetDataTableAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get data table info.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the data table to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instances}/dataTables/{data_table}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataTable GetDataTable(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataTable(new GetDataTableRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get data table info.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the data table to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instances}/dataTables/{data_table}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTable> GetDataTableAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataTableAsync(new GetDataTableRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get data table info.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the data table to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instances}/dataTables/{data_table}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTable> GetDataTableAsync(string name, st::CancellationToken cancellationToken) =>
            GetDataTableAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get data table info.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the data table to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instances}/dataTables/{data_table}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataTable GetDataTable(DataTableName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataTable(new GetDataTableRequest
            {
                DataTableName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get data table info.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the data table to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instances}/dataTables/{data_table}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTable> GetDataTableAsync(DataTableName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataTableAsync(new GetDataTableRequest
            {
                DataTableName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get data table info.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the data table to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instances}/dataTables/{data_table}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTable> GetDataTableAsync(DataTableName name, st::CancellationToken cancellationToken) =>
            GetDataTableAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update data table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataTable UpdateDataTable(UpdateDataTableRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update data table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTable> UpdateDataTableAsync(UpdateDataTableRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update data table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTable> UpdateDataTableAsync(UpdateDataTableRequest request, st::CancellationToken cancellationToken) =>
            UpdateDataTableAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update data table.
        /// </summary>
        /// <param name="dataTable">
        /// Required. This field is used to identify the datatable to update.
        /// Format:
        /// projects/{project}/locations/{locations}/instances/{instance}/dataTables/{data_table}
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of metadata fields to update. Currently data tables only
        /// support updating the `description`, `row_time_to_live` and `scope_info`
        /// fields. When no field mask is supplied, all non-empty fields will be
        /// updated. A field mask of "*" will update all fields, whether empty or not.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataTable UpdateDataTable(DataTable dataTable, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataTable(new UpdateDataTableRequest
            {
                DataTable = gax::GaxPreconditions.CheckNotNull(dataTable, nameof(dataTable)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update data table.
        /// </summary>
        /// <param name="dataTable">
        /// Required. This field is used to identify the datatable to update.
        /// Format:
        /// projects/{project}/locations/{locations}/instances/{instance}/dataTables/{data_table}
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of metadata fields to update. Currently data tables only
        /// support updating the `description`, `row_time_to_live` and `scope_info`
        /// fields. When no field mask is supplied, all non-empty fields will be
        /// updated. A field mask of "*" will update all fields, whether empty or not.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTable> UpdateDataTableAsync(DataTable dataTable, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataTableAsync(new UpdateDataTableRequest
            {
                DataTable = gax::GaxPreconditions.CheckNotNull(dataTable, nameof(dataTable)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update data table.
        /// </summary>
        /// <param name="dataTable">
        /// Required. This field is used to identify the datatable to update.
        /// Format:
        /// projects/{project}/locations/{locations}/instances/{instance}/dataTables/{data_table}
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of metadata fields to update. Currently data tables only
        /// support updating the `description`, `row_time_to_live` and `scope_info`
        /// fields. When no field mask is supplied, all non-empty fields will be
        /// updated. A field mask of "*" will update all fields, whether empty or not.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTable> UpdateDataTableAsync(DataTable dataTable, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDataTableAsync(dataTable, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete data table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDataTable(DeleteDataTableRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete data table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataTableAsync(DeleteDataTableRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete data table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataTableAsync(DeleteDataTableRequest request, st::CancellationToken cancellationToken) =>
            DeleteDataTableAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete data table.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the data table to delete.
        /// Format
        /// projects/{project}/locations/{location}/instances/{instances}/dataTables/{data_table}
        /// </param>
        /// <param name="force">
        /// Optional. If set to true, any rows under this data table will also be
        /// deleted. (Otherwise, the request will only work if the data table has no
        /// rows.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDataTable(string name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataTable(new DeleteDataTableRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Delete data table.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the data table to delete.
        /// Format
        /// projects/{project}/locations/{location}/instances/{instances}/dataTables/{data_table}
        /// </param>
        /// <param name="force">
        /// Optional. If set to true, any rows under this data table will also be
        /// deleted. (Otherwise, the request will only work if the data table has no
        /// rows.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataTableAsync(string name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataTableAsync(new DeleteDataTableRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Delete data table.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the data table to delete.
        /// Format
        /// projects/{project}/locations/{location}/instances/{instances}/dataTables/{data_table}
        /// </param>
        /// <param name="force">
        /// Optional. If set to true, any rows under this data table will also be
        /// deleted. (Otherwise, the request will only work if the data table has no
        /// rows.)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataTableAsync(string name, bool force, st::CancellationToken cancellationToken) =>
            DeleteDataTableAsync(name, force, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete data table.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the data table to delete.
        /// Format
        /// projects/{project}/locations/{location}/instances/{instances}/dataTables/{data_table}
        /// </param>
        /// <param name="force">
        /// Optional. If set to true, any rows under this data table will also be
        /// deleted. (Otherwise, the request will only work if the data table has no
        /// rows.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDataTable(DataTableName name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataTable(new DeleteDataTableRequest
            {
                DataTableName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Delete data table.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the data table to delete.
        /// Format
        /// projects/{project}/locations/{location}/instances/{instances}/dataTables/{data_table}
        /// </param>
        /// <param name="force">
        /// Optional. If set to true, any rows under this data table will also be
        /// deleted. (Otherwise, the request will only work if the data table has no
        /// rows.)
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataTableAsync(DataTableName name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataTableAsync(new DeleteDataTableRequest
            {
                DataTableName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Delete data table.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the data table to delete.
        /// Format
        /// projects/{project}/locations/{location}/instances/{instances}/dataTables/{data_table}
        /// </param>
        /// <param name="force">
        /// Optional. If set to true, any rows under this data table will also be
        /// deleted. (Otherwise, the request will only work if the data table has no
        /// rows.)
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataTableAsync(DataTableName name, bool force, st::CancellationToken cancellationToken) =>
            DeleteDataTableAsync(name, force, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new data table row.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataTableRow CreateDataTableRow(CreateDataTableRowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new data table row.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTableRow> CreateDataTableRowAsync(CreateDataTableRowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new data table row.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTableRow> CreateDataTableRowAsync(CreateDataTableRowRequest request, st::CancellationToken cancellationToken) =>
            CreateDataTableRowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new data table row.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource id of the data table.
        /// Format:
        /// /projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}
        /// </param>
        /// <param name="dataTableRow">
        /// Required. The data table row to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataTableRow CreateDataTableRow(string parent, DataTableRow dataTableRow, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataTableRow(new CreateDataTableRowRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DataTableRow = gax::GaxPreconditions.CheckNotNull(dataTableRow, nameof(dataTableRow)),
            }, callSettings);

        /// <summary>
        /// Create a new data table row.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource id of the data table.
        /// Format:
        /// /projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}
        /// </param>
        /// <param name="dataTableRow">
        /// Required. The data table row to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTableRow> CreateDataTableRowAsync(string parent, DataTableRow dataTableRow, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataTableRowAsync(new CreateDataTableRowRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DataTableRow = gax::GaxPreconditions.CheckNotNull(dataTableRow, nameof(dataTableRow)),
            }, callSettings);

        /// <summary>
        /// Create a new data table row.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource id of the data table.
        /// Format:
        /// /projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}
        /// </param>
        /// <param name="dataTableRow">
        /// Required. The data table row to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTableRow> CreateDataTableRowAsync(string parent, DataTableRow dataTableRow, st::CancellationToken cancellationToken) =>
            CreateDataTableRowAsync(parent, dataTableRow, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new data table row.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource id of the data table.
        /// Format:
        /// /projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}
        /// </param>
        /// <param name="dataTableRow">
        /// Required. The data table row to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataTableRow CreateDataTableRow(DataTableName parent, DataTableRow dataTableRow, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataTableRow(new CreateDataTableRowRequest
            {
                ParentAsDataTableName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DataTableRow = gax::GaxPreconditions.CheckNotNull(dataTableRow, nameof(dataTableRow)),
            }, callSettings);

        /// <summary>
        /// Create a new data table row.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource id of the data table.
        /// Format:
        /// /projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}
        /// </param>
        /// <param name="dataTableRow">
        /// Required. The data table row to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTableRow> CreateDataTableRowAsync(DataTableName parent, DataTableRow dataTableRow, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataTableRowAsync(new CreateDataTableRowRequest
            {
                ParentAsDataTableName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DataTableRow = gax::GaxPreconditions.CheckNotNull(dataTableRow, nameof(dataTableRow)),
            }, callSettings);

        /// <summary>
        /// Create a new data table row.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource id of the data table.
        /// Format:
        /// /projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}
        /// </param>
        /// <param name="dataTableRow">
        /// Required. The data table row to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTableRow> CreateDataTableRowAsync(DataTableName parent, DataTableRow dataTableRow, st::CancellationToken cancellationToken) =>
            CreateDataTableRowAsync(parent, dataTableRow, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update data table row
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataTableRow UpdateDataTableRow(UpdateDataTableRowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update data table row
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTableRow> UpdateDataTableRowAsync(UpdateDataTableRowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update data table row
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTableRow> UpdateDataTableRowAsync(UpdateDataTableRowRequest request, st::CancellationToken cancellationToken) =>
            UpdateDataTableRowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update data table row
        /// </summary>
        /// <param name="dataTableRow">
        /// Required. Format:
        /// projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}/dataTableRows/{data_table_row}
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update. Currently data table rows only
        /// support updating the `values` field. When no field mask is supplied, all
        /// non-empty fields will be updated. A field mask of "*" will update all
        /// fields, whether empty or not.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataTableRow UpdateDataTableRow(DataTableRow dataTableRow, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataTableRow(new UpdateDataTableRowRequest
            {
                DataTableRow = gax::GaxPreconditions.CheckNotNull(dataTableRow, nameof(dataTableRow)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update data table row
        /// </summary>
        /// <param name="dataTableRow">
        /// Required. Format:
        /// projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}/dataTableRows/{data_table_row}
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update. Currently data table rows only
        /// support updating the `values` field. When no field mask is supplied, all
        /// non-empty fields will be updated. A field mask of "*" will update all
        /// fields, whether empty or not.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTableRow> UpdateDataTableRowAsync(DataTableRow dataTableRow, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataTableRowAsync(new UpdateDataTableRowRequest
            {
                DataTableRow = gax::GaxPreconditions.CheckNotNull(dataTableRow, nameof(dataTableRow)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update data table row
        /// </summary>
        /// <param name="dataTableRow">
        /// Required. Format:
        /// projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}/dataTableRows/{data_table_row}
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update. Currently data table rows only
        /// support updating the `values` field. When no field mask is supplied, all
        /// non-empty fields will be updated. A field mask of "*" will update all
        /// fields, whether empty or not.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTableRow> UpdateDataTableRowAsync(DataTableRow dataTableRow, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDataTableRowAsync(dataTableRow, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List data table rows.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataTableRow"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataTableRowsResponse, DataTableRow> ListDataTableRows(ListDataTableRowsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List data table rows.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataTableRow"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataTableRowsResponse, DataTableRow> ListDataTableRowsAsync(ListDataTableRowsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List data table rows.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource id of the data table.
        /// Format:
        /// projects/{project}/locations/{locations}/instances/{instance}/dataTables/{data_table}
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
        /// <returns>A pageable sequence of <see cref="DataTableRow"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataTableRowsResponse, DataTableRow> ListDataTableRows(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataTableRowsRequest request = new ListDataTableRowsRequest
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
            return ListDataTableRows(request, callSettings);
        }

        /// <summary>
        /// List data table rows.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource id of the data table.
        /// Format:
        /// projects/{project}/locations/{locations}/instances/{instance}/dataTables/{data_table}
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataTableRow"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataTableRowsResponse, DataTableRow> ListDataTableRowsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataTableRowsRequest request = new ListDataTableRowsRequest
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
            return ListDataTableRowsAsync(request, callSettings);
        }

        /// <summary>
        /// List data table rows.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource id of the data table.
        /// Format:
        /// projects/{project}/locations/{locations}/instances/{instance}/dataTables/{data_table}
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
        /// <returns>A pageable sequence of <see cref="DataTableRow"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataTableRowsResponse, DataTableRow> ListDataTableRows(DataTableName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataTableRowsRequest request = new ListDataTableRowsRequest
            {
                ParentAsDataTableName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDataTableRows(request, callSettings);
        }

        /// <summary>
        /// List data table rows.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource id of the data table.
        /// Format:
        /// projects/{project}/locations/{locations}/instances/{instance}/dataTables/{data_table}
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataTableRow"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataTableRowsResponse, DataTableRow> ListDataTableRowsAsync(DataTableName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataTableRowsRequest request = new ListDataTableRowsRequest
            {
                ParentAsDataTableName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDataTableRowsAsync(request, callSettings);
        }

        /// <summary>
        /// Get data table row
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataTableRow GetDataTableRow(GetDataTableRowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get data table row
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTableRow> GetDataTableRowAsync(GetDataTableRowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get data table row
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTableRow> GetDataTableRowAsync(GetDataTableRowRequest request, st::CancellationToken cancellationToken) =>
            GetDataTableRowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get data table row
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the data table row i,e row_id.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}/dataTableRows/{data_table_row}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataTableRow GetDataTableRow(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataTableRow(new GetDataTableRowRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get data table row
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the data table row i,e row_id.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}/dataTableRows/{data_table_row}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTableRow> GetDataTableRowAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataTableRowAsync(new GetDataTableRowRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get data table row
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the data table row i,e row_id.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}/dataTableRows/{data_table_row}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTableRow> GetDataTableRowAsync(string name, st::CancellationToken cancellationToken) =>
            GetDataTableRowAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get data table row
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the data table row i,e row_id.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}/dataTableRows/{data_table_row}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataTableRow GetDataTableRow(DataTableRowName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataTableRow(new GetDataTableRowRequest
            {
                DataTableRowName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get data table row
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the data table row i,e row_id.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}/dataTableRows/{data_table_row}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTableRow> GetDataTableRowAsync(DataTableRowName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataTableRowAsync(new GetDataTableRowRequest
            {
                DataTableRowName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get data table row
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the data table row i,e row_id.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}/dataTableRows/{data_table_row}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTableRow> GetDataTableRowAsync(DataTableRowName name, st::CancellationToken cancellationToken) =>
            GetDataTableRowAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete data table row.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDataTableRow(DeleteDataTableRowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete data table row.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataTableRowAsync(DeleteDataTableRowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete data table row.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataTableRowAsync(DeleteDataTableRowRequest request, st::CancellationToken cancellationToken) =>
            DeleteDataTableRowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete data table row.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the data table row i,e row_id.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}/dataTableRows/{data_table_row}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDataTableRow(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataTableRow(new DeleteDataTableRowRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete data table row.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the data table row i,e row_id.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}/dataTableRows/{data_table_row}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataTableRowAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataTableRowAsync(new DeleteDataTableRowRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete data table row.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the data table row i,e row_id.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}/dataTableRows/{data_table_row}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataTableRowAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDataTableRowAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete data table row.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the data table row i,e row_id.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}/dataTableRows/{data_table_row}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDataTableRow(DataTableRowName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataTableRow(new DeleteDataTableRowRequest
            {
                DataTableRowName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete data table row.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the data table row i,e row_id.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}/dataTableRows/{data_table_row}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataTableRowAsync(DataTableRowName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataTableRowAsync(new DeleteDataTableRowRequest
            {
                DataTableRowName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete data table row.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the data table row i,e row_id.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}/dataTableRows/{data_table_row}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataTableRowAsync(DataTableRowName name, st::CancellationToken cancellationToken) =>
            DeleteDataTableRowAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create data table rows in bulk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BulkCreateDataTableRowsResponse BulkCreateDataTableRows(BulkCreateDataTableRowsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create data table rows in bulk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BulkCreateDataTableRowsResponse> BulkCreateDataTableRowsAsync(BulkCreateDataTableRowsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create data table rows in bulk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BulkCreateDataTableRowsResponse> BulkCreateDataTableRowsAsync(BulkCreateDataTableRowsRequest request, st::CancellationToken cancellationToken) =>
            BulkCreateDataTableRowsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create data table rows in bulk.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource id of the data table.
        /// Format:
        /// /projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}
        /// </param>
        /// <param name="requests">
        /// Required. Data table rows to create. A maximum of 1000 rows (for sync
        /// requests) or 2000 rows (for async requests) can be created in a single
        /// request. Total size of the rows should be less than 4MB.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BulkCreateDataTableRowsResponse BulkCreateDataTableRows(string parent, scg::IEnumerable<CreateDataTableRowRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BulkCreateDataTableRows(new BulkCreateDataTableRowsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Create data table rows in bulk.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource id of the data table.
        /// Format:
        /// /projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}
        /// </param>
        /// <param name="requests">
        /// Required. Data table rows to create. A maximum of 1000 rows (for sync
        /// requests) or 2000 rows (for async requests) can be created in a single
        /// request. Total size of the rows should be less than 4MB.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BulkCreateDataTableRowsResponse> BulkCreateDataTableRowsAsync(string parent, scg::IEnumerable<CreateDataTableRowRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BulkCreateDataTableRowsAsync(new BulkCreateDataTableRowsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Create data table rows in bulk.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource id of the data table.
        /// Format:
        /// /projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}
        /// </param>
        /// <param name="requests">
        /// Required. Data table rows to create. A maximum of 1000 rows (for sync
        /// requests) or 2000 rows (for async requests) can be created in a single
        /// request. Total size of the rows should be less than 4MB.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BulkCreateDataTableRowsResponse> BulkCreateDataTableRowsAsync(string parent, scg::IEnumerable<CreateDataTableRowRequest> requests, st::CancellationToken cancellationToken) =>
            BulkCreateDataTableRowsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create data table rows in bulk.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource id of the data table.
        /// Format:
        /// /projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}
        /// </param>
        /// <param name="requests">
        /// Required. Data table rows to create. A maximum of 1000 rows (for sync
        /// requests) or 2000 rows (for async requests) can be created in a single
        /// request. Total size of the rows should be less than 4MB.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BulkCreateDataTableRowsResponse BulkCreateDataTableRows(DataTableName parent, scg::IEnumerable<CreateDataTableRowRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BulkCreateDataTableRows(new BulkCreateDataTableRowsRequest
            {
                ParentAsDataTableName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Create data table rows in bulk.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource id of the data table.
        /// Format:
        /// /projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}
        /// </param>
        /// <param name="requests">
        /// Required. Data table rows to create. A maximum of 1000 rows (for sync
        /// requests) or 2000 rows (for async requests) can be created in a single
        /// request. Total size of the rows should be less than 4MB.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BulkCreateDataTableRowsResponse> BulkCreateDataTableRowsAsync(DataTableName parent, scg::IEnumerable<CreateDataTableRowRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BulkCreateDataTableRowsAsync(new BulkCreateDataTableRowsRequest
            {
                ParentAsDataTableName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Create data table rows in bulk.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource id of the data table.
        /// Format:
        /// /projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}
        /// </param>
        /// <param name="requests">
        /// Required. Data table rows to create. A maximum of 1000 rows (for sync
        /// requests) or 2000 rows (for async requests) can be created in a single
        /// request. Total size of the rows should be less than 4MB.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BulkCreateDataTableRowsResponse> BulkCreateDataTableRowsAsync(DataTableName parent, scg::IEnumerable<CreateDataTableRowRequest> requests, st::CancellationToken cancellationToken) =>
            BulkCreateDataTableRowsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get data table rows in bulk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BulkGetDataTableRowsResponse BulkGetDataTableRows(BulkGetDataTableRowsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get data table rows in bulk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BulkGetDataTableRowsResponse> BulkGetDataTableRowsAsync(BulkGetDataTableRowsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get data table rows in bulk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BulkGetDataTableRowsResponse> BulkGetDataTableRowsAsync(BulkGetDataTableRowsRequest request, st::CancellationToken cancellationToken) =>
            BulkGetDataTableRowsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get data table rows in bulk.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource id of the data table.
        /// Format:
        /// /projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}
        /// </param>
        /// <param name="requests">
        /// Required. Data table rows to get. At max 1,000 rows can be there in a
        /// request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BulkGetDataTableRowsResponse BulkGetDataTableRows(string parent, scg::IEnumerable<GetDataTableRowRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BulkGetDataTableRows(new BulkGetDataTableRowsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Get data table rows in bulk.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource id of the data table.
        /// Format:
        /// /projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}
        /// </param>
        /// <param name="requests">
        /// Required. Data table rows to get. At max 1,000 rows can be there in a
        /// request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BulkGetDataTableRowsResponse> BulkGetDataTableRowsAsync(string parent, scg::IEnumerable<GetDataTableRowRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BulkGetDataTableRowsAsync(new BulkGetDataTableRowsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Get data table rows in bulk.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource id of the data table.
        /// Format:
        /// /projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}
        /// </param>
        /// <param name="requests">
        /// Required. Data table rows to get. At max 1,000 rows can be there in a
        /// request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BulkGetDataTableRowsResponse> BulkGetDataTableRowsAsync(string parent, scg::IEnumerable<GetDataTableRowRequest> requests, st::CancellationToken cancellationToken) =>
            BulkGetDataTableRowsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get data table rows in bulk.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource id of the data table.
        /// Format:
        /// /projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}
        /// </param>
        /// <param name="requests">
        /// Required. Data table rows to get. At max 1,000 rows can be there in a
        /// request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BulkGetDataTableRowsResponse BulkGetDataTableRows(DataTableName parent, scg::IEnumerable<GetDataTableRowRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BulkGetDataTableRows(new BulkGetDataTableRowsRequest
            {
                ParentAsDataTableName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Get data table rows in bulk.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource id of the data table.
        /// Format:
        /// /projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}
        /// </param>
        /// <param name="requests">
        /// Required. Data table rows to get. At max 1,000 rows can be there in a
        /// request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BulkGetDataTableRowsResponse> BulkGetDataTableRowsAsync(DataTableName parent, scg::IEnumerable<GetDataTableRowRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BulkGetDataTableRowsAsync(new BulkGetDataTableRowsRequest
            {
                ParentAsDataTableName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Get data table rows in bulk.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource id of the data table.
        /// Format:
        /// /projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}
        /// </param>
        /// <param name="requests">
        /// Required. Data table rows to get. At max 1,000 rows can be there in a
        /// request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BulkGetDataTableRowsResponse> BulkGetDataTableRowsAsync(DataTableName parent, scg::IEnumerable<GetDataTableRowRequest> requests, st::CancellationToken cancellationToken) =>
            BulkGetDataTableRowsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Replace all existing data table rows with new data table rows.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BulkReplaceDataTableRowsResponse BulkReplaceDataTableRows(BulkReplaceDataTableRowsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Replace all existing data table rows with new data table rows.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BulkReplaceDataTableRowsResponse> BulkReplaceDataTableRowsAsync(BulkReplaceDataTableRowsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Replace all existing data table rows with new data table rows.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BulkReplaceDataTableRowsResponse> BulkReplaceDataTableRowsAsync(BulkReplaceDataTableRowsRequest request, st::CancellationToken cancellationToken) =>
            BulkReplaceDataTableRowsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Replace all existing data table rows with new data table rows.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource id of the data table.
        /// Format:
        /// /projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}
        /// </param>
        /// <param name="requests">
        /// Required. Data table rows to replace the existing data table rows. A
        /// maximum of 1000 rows (for sync requests) or 2000 rows (for async requests)
        /// can be replaced in a single request. Total size of the rows should be less
        /// than 4MB.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BulkReplaceDataTableRowsResponse BulkReplaceDataTableRows(string parent, scg::IEnumerable<CreateDataTableRowRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BulkReplaceDataTableRows(new BulkReplaceDataTableRowsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Replace all existing data table rows with new data table rows.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource id of the data table.
        /// Format:
        /// /projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}
        /// </param>
        /// <param name="requests">
        /// Required. Data table rows to replace the existing data table rows. A
        /// maximum of 1000 rows (for sync requests) or 2000 rows (for async requests)
        /// can be replaced in a single request. Total size of the rows should be less
        /// than 4MB.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BulkReplaceDataTableRowsResponse> BulkReplaceDataTableRowsAsync(string parent, scg::IEnumerable<CreateDataTableRowRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BulkReplaceDataTableRowsAsync(new BulkReplaceDataTableRowsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Replace all existing data table rows with new data table rows.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource id of the data table.
        /// Format:
        /// /projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}
        /// </param>
        /// <param name="requests">
        /// Required. Data table rows to replace the existing data table rows. A
        /// maximum of 1000 rows (for sync requests) or 2000 rows (for async requests)
        /// can be replaced in a single request. Total size of the rows should be less
        /// than 4MB.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BulkReplaceDataTableRowsResponse> BulkReplaceDataTableRowsAsync(string parent, scg::IEnumerable<CreateDataTableRowRequest> requests, st::CancellationToken cancellationToken) =>
            BulkReplaceDataTableRowsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Replace all existing data table rows with new data table rows.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource id of the data table.
        /// Format:
        /// /projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}
        /// </param>
        /// <param name="requests">
        /// Required. Data table rows to replace the existing data table rows. A
        /// maximum of 1000 rows (for sync requests) or 2000 rows (for async requests)
        /// can be replaced in a single request. Total size of the rows should be less
        /// than 4MB.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BulkReplaceDataTableRowsResponse BulkReplaceDataTableRows(DataTableName parent, scg::IEnumerable<CreateDataTableRowRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BulkReplaceDataTableRows(new BulkReplaceDataTableRowsRequest
            {
                ParentAsDataTableName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Replace all existing data table rows with new data table rows.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource id of the data table.
        /// Format:
        /// /projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}
        /// </param>
        /// <param name="requests">
        /// Required. Data table rows to replace the existing data table rows. A
        /// maximum of 1000 rows (for sync requests) or 2000 rows (for async requests)
        /// can be replaced in a single request. Total size of the rows should be less
        /// than 4MB.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BulkReplaceDataTableRowsResponse> BulkReplaceDataTableRowsAsync(DataTableName parent, scg::IEnumerable<CreateDataTableRowRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BulkReplaceDataTableRowsAsync(new BulkReplaceDataTableRowsRequest
            {
                ParentAsDataTableName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Replace all existing data table rows with new data table rows.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource id of the data table.
        /// Format:
        /// /projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}
        /// </param>
        /// <param name="requests">
        /// Required. Data table rows to replace the existing data table rows. A
        /// maximum of 1000 rows (for sync requests) or 2000 rows (for async requests)
        /// can be replaced in a single request. Total size of the rows should be less
        /// than 4MB.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BulkReplaceDataTableRowsResponse> BulkReplaceDataTableRowsAsync(DataTableName parent, scg::IEnumerable<CreateDataTableRowRequest> requests, st::CancellationToken cancellationToken) =>
            BulkReplaceDataTableRowsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update data table rows in bulk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BulkUpdateDataTableRowsResponse BulkUpdateDataTableRows(BulkUpdateDataTableRowsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update data table rows in bulk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BulkUpdateDataTableRowsResponse> BulkUpdateDataTableRowsAsync(BulkUpdateDataTableRowsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update data table rows in bulk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BulkUpdateDataTableRowsResponse> BulkUpdateDataTableRowsAsync(BulkUpdateDataTableRowsRequest request, st::CancellationToken cancellationToken) =>
            BulkUpdateDataTableRowsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update data table rows in bulk.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource id of the data table.
        /// Format:
        /// /projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}
        /// </param>
        /// <param name="requests">
        /// Required. Data table rows to update. At max 1,000 rows (or rows with size
        /// less than 2MB) can be there in a request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BulkUpdateDataTableRowsResponse BulkUpdateDataTableRows(string parent, scg::IEnumerable<UpdateDataTableRowRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BulkUpdateDataTableRows(new BulkUpdateDataTableRowsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Update data table rows in bulk.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource id of the data table.
        /// Format:
        /// /projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}
        /// </param>
        /// <param name="requests">
        /// Required. Data table rows to update. At max 1,000 rows (or rows with size
        /// less than 2MB) can be there in a request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BulkUpdateDataTableRowsResponse> BulkUpdateDataTableRowsAsync(string parent, scg::IEnumerable<UpdateDataTableRowRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BulkUpdateDataTableRowsAsync(new BulkUpdateDataTableRowsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Update data table rows in bulk.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource id of the data table.
        /// Format:
        /// /projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}
        /// </param>
        /// <param name="requests">
        /// Required. Data table rows to update. At max 1,000 rows (or rows with size
        /// less than 2MB) can be there in a request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BulkUpdateDataTableRowsResponse> BulkUpdateDataTableRowsAsync(string parent, scg::IEnumerable<UpdateDataTableRowRequest> requests, st::CancellationToken cancellationToken) =>
            BulkUpdateDataTableRowsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update data table rows in bulk.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource id of the data table.
        /// Format:
        /// /projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}
        /// </param>
        /// <param name="requests">
        /// Required. Data table rows to update. At max 1,000 rows (or rows with size
        /// less than 2MB) can be there in a request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BulkUpdateDataTableRowsResponse BulkUpdateDataTableRows(DataTableName parent, scg::IEnumerable<UpdateDataTableRowRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BulkUpdateDataTableRows(new BulkUpdateDataTableRowsRequest
            {
                ParentAsDataTableName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Update data table rows in bulk.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource id of the data table.
        /// Format:
        /// /projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}
        /// </param>
        /// <param name="requests">
        /// Required. Data table rows to update. At max 1,000 rows (or rows with size
        /// less than 2MB) can be there in a request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BulkUpdateDataTableRowsResponse> BulkUpdateDataTableRowsAsync(DataTableName parent, scg::IEnumerable<UpdateDataTableRowRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BulkUpdateDataTableRowsAsync(new BulkUpdateDataTableRowsRequest
            {
                ParentAsDataTableName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Update data table rows in bulk.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource id of the data table.
        /// Format:
        /// /projects/{project}/locations/{location}/instances/{instance}/dataTables/{data_table}
        /// </param>
        /// <param name="requests">
        /// Required. Data table rows to update. At max 1,000 rows (or rows with size
        /// less than 2MB) can be there in a request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BulkUpdateDataTableRowsResponse> BulkUpdateDataTableRowsAsync(DataTableName parent, scg::IEnumerable<UpdateDataTableRowRequest> requests, st::CancellationToken cancellationToken) =>
            BulkUpdateDataTableRowsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the error for a data table operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataTableOperationErrors GetDataTableOperationErrors(GetDataTableOperationErrorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the error for a data table operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTableOperationErrors> GetDataTableOperationErrorsAsync(GetDataTableOperationErrorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the error for a data table operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTableOperationErrors> GetDataTableOperationErrorsAsync(GetDataTableOperationErrorsRequest request, st::CancellationToken cancellationToken) =>
            GetDataTableOperationErrorsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the error for a data table operation.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the data table operation errors.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/dataTableOperationErrors/{data_table_operation_errors}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataTableOperationErrors GetDataTableOperationErrors(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataTableOperationErrors(new GetDataTableOperationErrorsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the error for a data table operation.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the data table operation errors.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/dataTableOperationErrors/{data_table_operation_errors}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTableOperationErrors> GetDataTableOperationErrorsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataTableOperationErrorsAsync(new GetDataTableOperationErrorsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the error for a data table operation.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the data table operation errors.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/dataTableOperationErrors/{data_table_operation_errors}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTableOperationErrors> GetDataTableOperationErrorsAsync(string name, st::CancellationToken cancellationToken) =>
            GetDataTableOperationErrorsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the error for a data table operation.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the data table operation errors.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/dataTableOperationErrors/{data_table_operation_errors}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataTableOperationErrors GetDataTableOperationErrors(DataTableOperationErrorsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataTableOperationErrors(new GetDataTableOperationErrorsRequest
            {
                DataTableOperationErrorsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the error for a data table operation.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the data table operation errors.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/dataTableOperationErrors/{data_table_operation_errors}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTableOperationErrors> GetDataTableOperationErrorsAsync(DataTableOperationErrorsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataTableOperationErrorsAsync(new GetDataTableOperationErrorsRequest
            {
                DataTableOperationErrorsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the error for a data table operation.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the data table operation errors.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/dataTableOperationErrors/{data_table_operation_errors}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataTableOperationErrors> GetDataTableOperationErrorsAsync(DataTableOperationErrorsName name, st::CancellationToken cancellationToken) =>
            GetDataTableOperationErrorsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DataTableService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// DataTableManager provides an interface for managing data tables.
    /// </remarks>
    public sealed partial class DataTableServiceClientImpl : DataTableServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateDataTableRequest, DataTable> _callCreateDataTable;

        private readonly gaxgrpc::ApiCall<ListDataTablesRequest, ListDataTablesResponse> _callListDataTables;

        private readonly gaxgrpc::ApiCall<GetDataTableRequest, DataTable> _callGetDataTable;

        private readonly gaxgrpc::ApiCall<UpdateDataTableRequest, DataTable> _callUpdateDataTable;

        private readonly gaxgrpc::ApiCall<DeleteDataTableRequest, wkt::Empty> _callDeleteDataTable;

        private readonly gaxgrpc::ApiCall<CreateDataTableRowRequest, DataTableRow> _callCreateDataTableRow;

        private readonly gaxgrpc::ApiCall<UpdateDataTableRowRequest, DataTableRow> _callUpdateDataTableRow;

        private readonly gaxgrpc::ApiCall<ListDataTableRowsRequest, ListDataTableRowsResponse> _callListDataTableRows;

        private readonly gaxgrpc::ApiCall<GetDataTableRowRequest, DataTableRow> _callGetDataTableRow;

        private readonly gaxgrpc::ApiCall<DeleteDataTableRowRequest, wkt::Empty> _callDeleteDataTableRow;

        private readonly gaxgrpc::ApiCall<BulkCreateDataTableRowsRequest, BulkCreateDataTableRowsResponse> _callBulkCreateDataTableRows;

        private readonly gaxgrpc::ApiCall<BulkGetDataTableRowsRequest, BulkGetDataTableRowsResponse> _callBulkGetDataTableRows;

        private readonly gaxgrpc::ApiCall<BulkReplaceDataTableRowsRequest, BulkReplaceDataTableRowsResponse> _callBulkReplaceDataTableRows;

        private readonly gaxgrpc::ApiCall<BulkUpdateDataTableRowsRequest, BulkUpdateDataTableRowsResponse> _callBulkUpdateDataTableRows;

        private readonly gaxgrpc::ApiCall<GetDataTableOperationErrorsRequest, DataTableOperationErrors> _callGetDataTableOperationErrors;

        /// <summary>
        /// Constructs a client wrapper for the DataTableService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DataTableServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DataTableServiceClientImpl(DataTableService.DataTableServiceClient grpcClient, DataTableServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DataTableServiceSettings effectiveSettings = settings ?? DataTableServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCreateDataTable = clientHelper.BuildApiCall<CreateDataTableRequest, DataTable>("CreateDataTable", grpcClient.CreateDataTableAsync, grpcClient.CreateDataTable, effectiveSettings.CreateDataTableSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDataTable);
            Modify_CreateDataTableApiCall(ref _callCreateDataTable);
            _callListDataTables = clientHelper.BuildApiCall<ListDataTablesRequest, ListDataTablesResponse>("ListDataTables", grpcClient.ListDataTablesAsync, grpcClient.ListDataTables, effectiveSettings.ListDataTablesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDataTables);
            Modify_ListDataTablesApiCall(ref _callListDataTables);
            _callGetDataTable = clientHelper.BuildApiCall<GetDataTableRequest, DataTable>("GetDataTable", grpcClient.GetDataTableAsync, grpcClient.GetDataTable, effectiveSettings.GetDataTableSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDataTable);
            Modify_GetDataTableApiCall(ref _callGetDataTable);
            _callUpdateDataTable = clientHelper.BuildApiCall<UpdateDataTableRequest, DataTable>("UpdateDataTable", grpcClient.UpdateDataTableAsync, grpcClient.UpdateDataTable, effectiveSettings.UpdateDataTableSettings).WithGoogleRequestParam("data_table.name", request => request.DataTable?.Name);
            Modify_ApiCall(ref _callUpdateDataTable);
            Modify_UpdateDataTableApiCall(ref _callUpdateDataTable);
            _callDeleteDataTable = clientHelper.BuildApiCall<DeleteDataTableRequest, wkt::Empty>("DeleteDataTable", grpcClient.DeleteDataTableAsync, grpcClient.DeleteDataTable, effectiveSettings.DeleteDataTableSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDataTable);
            Modify_DeleteDataTableApiCall(ref _callDeleteDataTable);
            _callCreateDataTableRow = clientHelper.BuildApiCall<CreateDataTableRowRequest, DataTableRow>("CreateDataTableRow", grpcClient.CreateDataTableRowAsync, grpcClient.CreateDataTableRow, effectiveSettings.CreateDataTableRowSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDataTableRow);
            Modify_CreateDataTableRowApiCall(ref _callCreateDataTableRow);
            _callUpdateDataTableRow = clientHelper.BuildApiCall<UpdateDataTableRowRequest, DataTableRow>("UpdateDataTableRow", grpcClient.UpdateDataTableRowAsync, grpcClient.UpdateDataTableRow, effectiveSettings.UpdateDataTableRowSettings).WithGoogleRequestParam("data_table_row.name", request => request.DataTableRow?.Name);
            Modify_ApiCall(ref _callUpdateDataTableRow);
            Modify_UpdateDataTableRowApiCall(ref _callUpdateDataTableRow);
            _callListDataTableRows = clientHelper.BuildApiCall<ListDataTableRowsRequest, ListDataTableRowsResponse>("ListDataTableRows", grpcClient.ListDataTableRowsAsync, grpcClient.ListDataTableRows, effectiveSettings.ListDataTableRowsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDataTableRows);
            Modify_ListDataTableRowsApiCall(ref _callListDataTableRows);
            _callGetDataTableRow = clientHelper.BuildApiCall<GetDataTableRowRequest, DataTableRow>("GetDataTableRow", grpcClient.GetDataTableRowAsync, grpcClient.GetDataTableRow, effectiveSettings.GetDataTableRowSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDataTableRow);
            Modify_GetDataTableRowApiCall(ref _callGetDataTableRow);
            _callDeleteDataTableRow = clientHelper.BuildApiCall<DeleteDataTableRowRequest, wkt::Empty>("DeleteDataTableRow", grpcClient.DeleteDataTableRowAsync, grpcClient.DeleteDataTableRow, effectiveSettings.DeleteDataTableRowSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDataTableRow);
            Modify_DeleteDataTableRowApiCall(ref _callDeleteDataTableRow);
            _callBulkCreateDataTableRows = clientHelper.BuildApiCall<BulkCreateDataTableRowsRequest, BulkCreateDataTableRowsResponse>("BulkCreateDataTableRows", grpcClient.BulkCreateDataTableRowsAsync, grpcClient.BulkCreateDataTableRows, effectiveSettings.BulkCreateDataTableRowsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBulkCreateDataTableRows);
            Modify_BulkCreateDataTableRowsApiCall(ref _callBulkCreateDataTableRows);
            _callBulkGetDataTableRows = clientHelper.BuildApiCall<BulkGetDataTableRowsRequest, BulkGetDataTableRowsResponse>("BulkGetDataTableRows", grpcClient.BulkGetDataTableRowsAsync, grpcClient.BulkGetDataTableRows, effectiveSettings.BulkGetDataTableRowsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBulkGetDataTableRows);
            Modify_BulkGetDataTableRowsApiCall(ref _callBulkGetDataTableRows);
            _callBulkReplaceDataTableRows = clientHelper.BuildApiCall<BulkReplaceDataTableRowsRequest, BulkReplaceDataTableRowsResponse>("BulkReplaceDataTableRows", grpcClient.BulkReplaceDataTableRowsAsync, grpcClient.BulkReplaceDataTableRows, effectiveSettings.BulkReplaceDataTableRowsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBulkReplaceDataTableRows);
            Modify_BulkReplaceDataTableRowsApiCall(ref _callBulkReplaceDataTableRows);
            _callBulkUpdateDataTableRows = clientHelper.BuildApiCall<BulkUpdateDataTableRowsRequest, BulkUpdateDataTableRowsResponse>("BulkUpdateDataTableRows", grpcClient.BulkUpdateDataTableRowsAsync, grpcClient.BulkUpdateDataTableRows, effectiveSettings.BulkUpdateDataTableRowsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBulkUpdateDataTableRows);
            Modify_BulkUpdateDataTableRowsApiCall(ref _callBulkUpdateDataTableRows);
            _callGetDataTableOperationErrors = clientHelper.BuildApiCall<GetDataTableOperationErrorsRequest, DataTableOperationErrors>("GetDataTableOperationErrors", grpcClient.GetDataTableOperationErrorsAsync, grpcClient.GetDataTableOperationErrors, effectiveSettings.GetDataTableOperationErrorsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDataTableOperationErrors);
            Modify_GetDataTableOperationErrorsApiCall(ref _callGetDataTableOperationErrors);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateDataTableApiCall(ref gaxgrpc::ApiCall<CreateDataTableRequest, DataTable> call);

        partial void Modify_ListDataTablesApiCall(ref gaxgrpc::ApiCall<ListDataTablesRequest, ListDataTablesResponse> call);

        partial void Modify_GetDataTableApiCall(ref gaxgrpc::ApiCall<GetDataTableRequest, DataTable> call);

        partial void Modify_UpdateDataTableApiCall(ref gaxgrpc::ApiCall<UpdateDataTableRequest, DataTable> call);

        partial void Modify_DeleteDataTableApiCall(ref gaxgrpc::ApiCall<DeleteDataTableRequest, wkt::Empty> call);

        partial void Modify_CreateDataTableRowApiCall(ref gaxgrpc::ApiCall<CreateDataTableRowRequest, DataTableRow> call);

        partial void Modify_UpdateDataTableRowApiCall(ref gaxgrpc::ApiCall<UpdateDataTableRowRequest, DataTableRow> call);

        partial void Modify_ListDataTableRowsApiCall(ref gaxgrpc::ApiCall<ListDataTableRowsRequest, ListDataTableRowsResponse> call);

        partial void Modify_GetDataTableRowApiCall(ref gaxgrpc::ApiCall<GetDataTableRowRequest, DataTableRow> call);

        partial void Modify_DeleteDataTableRowApiCall(ref gaxgrpc::ApiCall<DeleteDataTableRowRequest, wkt::Empty> call);

        partial void Modify_BulkCreateDataTableRowsApiCall(ref gaxgrpc::ApiCall<BulkCreateDataTableRowsRequest, BulkCreateDataTableRowsResponse> call);

        partial void Modify_BulkGetDataTableRowsApiCall(ref gaxgrpc::ApiCall<BulkGetDataTableRowsRequest, BulkGetDataTableRowsResponse> call);

        partial void Modify_BulkReplaceDataTableRowsApiCall(ref gaxgrpc::ApiCall<BulkReplaceDataTableRowsRequest, BulkReplaceDataTableRowsResponse> call);

        partial void Modify_BulkUpdateDataTableRowsApiCall(ref gaxgrpc::ApiCall<BulkUpdateDataTableRowsRequest, BulkUpdateDataTableRowsResponse> call);

        partial void Modify_GetDataTableOperationErrorsApiCall(ref gaxgrpc::ApiCall<GetDataTableOperationErrorsRequest, DataTableOperationErrors> call);

        partial void OnConstruction(DataTableService.DataTableServiceClient grpcClient, DataTableServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DataTableService client</summary>
        public override DataTableService.DataTableServiceClient GrpcClient { get; }

        partial void Modify_CreateDataTableRequest(ref CreateDataTableRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDataTablesRequest(ref ListDataTablesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDataTableRequest(ref GetDataTableRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDataTableRequest(ref UpdateDataTableRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDataTableRequest(ref DeleteDataTableRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateDataTableRowRequest(ref CreateDataTableRowRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDataTableRowRequest(ref UpdateDataTableRowRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDataTableRowsRequest(ref ListDataTableRowsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDataTableRowRequest(ref GetDataTableRowRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDataTableRowRequest(ref DeleteDataTableRowRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BulkCreateDataTableRowsRequest(ref BulkCreateDataTableRowsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BulkGetDataTableRowsRequest(ref BulkGetDataTableRowsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BulkReplaceDataTableRowsRequest(ref BulkReplaceDataTableRowsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BulkUpdateDataTableRowsRequest(ref BulkUpdateDataTableRowsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDataTableOperationErrorsRequest(ref GetDataTableOperationErrorsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Create a new data table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataTable CreateDataTable(CreateDataTableRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataTableRequest(ref request, ref callSettings);
            return _callCreateDataTable.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a new data table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataTable> CreateDataTableAsync(CreateDataTableRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataTableRequest(ref request, ref callSettings);
            return _callCreateDataTable.Async(request, callSettings);
        }

        /// <summary>
        /// List data tables.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataTable"/> resources.</returns>
        public override gax::PagedEnumerable<ListDataTablesResponse, DataTable> ListDataTables(ListDataTablesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataTablesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDataTablesRequest, ListDataTablesResponse, DataTable>(_callListDataTables, request, callSettings);
        }

        /// <summary>
        /// List data tables.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataTable"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDataTablesResponse, DataTable> ListDataTablesAsync(ListDataTablesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataTablesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDataTablesRequest, ListDataTablesResponse, DataTable>(_callListDataTables, request, callSettings);
        }

        /// <summary>
        /// Get data table info.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataTable GetDataTable(GetDataTableRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataTableRequest(ref request, ref callSettings);
            return _callGetDataTable.Sync(request, callSettings);
        }

        /// <summary>
        /// Get data table info.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataTable> GetDataTableAsync(GetDataTableRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataTableRequest(ref request, ref callSettings);
            return _callGetDataTable.Async(request, callSettings);
        }

        /// <summary>
        /// Update data table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataTable UpdateDataTable(UpdateDataTableRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataTableRequest(ref request, ref callSettings);
            return _callUpdateDataTable.Sync(request, callSettings);
        }

        /// <summary>
        /// Update data table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataTable> UpdateDataTableAsync(UpdateDataTableRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataTableRequest(ref request, ref callSettings);
            return _callUpdateDataTable.Async(request, callSettings);
        }

        /// <summary>
        /// Delete data table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteDataTable(DeleteDataTableRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDataTableRequest(ref request, ref callSettings);
            _callDeleteDataTable.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete data table.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteDataTableAsync(DeleteDataTableRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDataTableRequest(ref request, ref callSettings);
            return _callDeleteDataTable.Async(request, callSettings);
        }

        /// <summary>
        /// Create a new data table row.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataTableRow CreateDataTableRow(CreateDataTableRowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataTableRowRequest(ref request, ref callSettings);
            return _callCreateDataTableRow.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a new data table row.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataTableRow> CreateDataTableRowAsync(CreateDataTableRowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataTableRowRequest(ref request, ref callSettings);
            return _callCreateDataTableRow.Async(request, callSettings);
        }

        /// <summary>
        /// Update data table row
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataTableRow UpdateDataTableRow(UpdateDataTableRowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataTableRowRequest(ref request, ref callSettings);
            return _callUpdateDataTableRow.Sync(request, callSettings);
        }

        /// <summary>
        /// Update data table row
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataTableRow> UpdateDataTableRowAsync(UpdateDataTableRowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataTableRowRequest(ref request, ref callSettings);
            return _callUpdateDataTableRow.Async(request, callSettings);
        }

        /// <summary>
        /// List data table rows.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataTableRow"/> resources.</returns>
        public override gax::PagedEnumerable<ListDataTableRowsResponse, DataTableRow> ListDataTableRows(ListDataTableRowsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataTableRowsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDataTableRowsRequest, ListDataTableRowsResponse, DataTableRow>(_callListDataTableRows, request, callSettings);
        }

        /// <summary>
        /// List data table rows.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataTableRow"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDataTableRowsResponse, DataTableRow> ListDataTableRowsAsync(ListDataTableRowsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataTableRowsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDataTableRowsRequest, ListDataTableRowsResponse, DataTableRow>(_callListDataTableRows, request, callSettings);
        }

        /// <summary>
        /// Get data table row
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataTableRow GetDataTableRow(GetDataTableRowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataTableRowRequest(ref request, ref callSettings);
            return _callGetDataTableRow.Sync(request, callSettings);
        }

        /// <summary>
        /// Get data table row
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataTableRow> GetDataTableRowAsync(GetDataTableRowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataTableRowRequest(ref request, ref callSettings);
            return _callGetDataTableRow.Async(request, callSettings);
        }

        /// <summary>
        /// Delete data table row.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteDataTableRow(DeleteDataTableRowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDataTableRowRequest(ref request, ref callSettings);
            _callDeleteDataTableRow.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete data table row.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteDataTableRowAsync(DeleteDataTableRowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDataTableRowRequest(ref request, ref callSettings);
            return _callDeleteDataTableRow.Async(request, callSettings);
        }

        /// <summary>
        /// Create data table rows in bulk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BulkCreateDataTableRowsResponse BulkCreateDataTableRows(BulkCreateDataTableRowsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BulkCreateDataTableRowsRequest(ref request, ref callSettings);
            return _callBulkCreateDataTableRows.Sync(request, callSettings);
        }

        /// <summary>
        /// Create data table rows in bulk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BulkCreateDataTableRowsResponse> BulkCreateDataTableRowsAsync(BulkCreateDataTableRowsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BulkCreateDataTableRowsRequest(ref request, ref callSettings);
            return _callBulkCreateDataTableRows.Async(request, callSettings);
        }

        /// <summary>
        /// Get data table rows in bulk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BulkGetDataTableRowsResponse BulkGetDataTableRows(BulkGetDataTableRowsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BulkGetDataTableRowsRequest(ref request, ref callSettings);
            return _callBulkGetDataTableRows.Sync(request, callSettings);
        }

        /// <summary>
        /// Get data table rows in bulk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BulkGetDataTableRowsResponse> BulkGetDataTableRowsAsync(BulkGetDataTableRowsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BulkGetDataTableRowsRequest(ref request, ref callSettings);
            return _callBulkGetDataTableRows.Async(request, callSettings);
        }

        /// <summary>
        /// Replace all existing data table rows with new data table rows.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BulkReplaceDataTableRowsResponse BulkReplaceDataTableRows(BulkReplaceDataTableRowsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BulkReplaceDataTableRowsRequest(ref request, ref callSettings);
            return _callBulkReplaceDataTableRows.Sync(request, callSettings);
        }

        /// <summary>
        /// Replace all existing data table rows with new data table rows.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BulkReplaceDataTableRowsResponse> BulkReplaceDataTableRowsAsync(BulkReplaceDataTableRowsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BulkReplaceDataTableRowsRequest(ref request, ref callSettings);
            return _callBulkReplaceDataTableRows.Async(request, callSettings);
        }

        /// <summary>
        /// Update data table rows in bulk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BulkUpdateDataTableRowsResponse BulkUpdateDataTableRows(BulkUpdateDataTableRowsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BulkUpdateDataTableRowsRequest(ref request, ref callSettings);
            return _callBulkUpdateDataTableRows.Sync(request, callSettings);
        }

        /// <summary>
        /// Update data table rows in bulk.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BulkUpdateDataTableRowsResponse> BulkUpdateDataTableRowsAsync(BulkUpdateDataTableRowsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BulkUpdateDataTableRowsRequest(ref request, ref callSettings);
            return _callBulkUpdateDataTableRows.Async(request, callSettings);
        }

        /// <summary>
        /// Get the error for a data table operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataTableOperationErrors GetDataTableOperationErrors(GetDataTableOperationErrorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataTableOperationErrorsRequest(ref request, ref callSettings);
            return _callGetDataTableOperationErrors.Sync(request, callSettings);
        }

        /// <summary>
        /// Get the error for a data table operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataTableOperationErrors> GetDataTableOperationErrorsAsync(GetDataTableOperationErrorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataTableOperationErrorsRequest(ref request, ref callSettings);
            return _callGetDataTableOperationErrors.Async(request, callSettings);
        }
    }

    public partial class ListDataTablesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDataTableRowsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDataTablesResponse : gaxgrpc::IPageResponse<DataTable>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DataTable> GetEnumerator() => DataTables.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDataTableRowsResponse : gaxgrpc::IPageResponse<DataTableRow>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DataTableRow> GetEnumerator() => DataTableRows.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
