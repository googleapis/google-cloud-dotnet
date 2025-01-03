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
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Shopping.Merchant.DataSources.V1Beta
{
    /// <summary>Settings for <see cref="DataSourcesServiceClient"/> instances.</summary>
    public sealed partial class DataSourcesServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DataSourcesServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DataSourcesServiceSettings"/>.</returns>
        public static DataSourcesServiceSettings GetDefault() => new DataSourcesServiceSettings();

        /// <summary>Constructs a new <see cref="DataSourcesServiceSettings"/> object with default settings.</summary>
        public DataSourcesServiceSettings()
        {
        }

        private DataSourcesServiceSettings(DataSourcesServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetDataSourceSettings = existing.GetDataSourceSettings;
            ListDataSourcesSettings = existing.ListDataSourcesSettings;
            CreateDataSourceSettings = existing.CreateDataSourceSettings;
            UpdateDataSourceSettings = existing.UpdateDataSourceSettings;
            DeleteDataSourceSettings = existing.DeleteDataSourceSettings;
            FetchDataSourceSettings = existing.FetchDataSourceSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DataSourcesServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataSourcesServiceClient.GetDataSource</c> and <c>DataSourcesServiceClient.GetDataSourceAsync</c>.
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
        public gaxgrpc::CallSettings GetDataSourceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataSourcesServiceClient.ListDataSources</c> and <c>DataSourcesServiceClient.ListDataSourcesAsync</c>.
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
        public gaxgrpc::CallSettings ListDataSourcesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataSourcesServiceClient.CreateDataSource</c> and <c>DataSourcesServiceClient.CreateDataSourceAsync</c>.
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
        public gaxgrpc::CallSettings CreateDataSourceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataSourcesServiceClient.UpdateDataSource</c> and <c>DataSourcesServiceClient.UpdateDataSourceAsync</c>.
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
        public gaxgrpc::CallSettings UpdateDataSourceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataSourcesServiceClient.DeleteDataSource</c> and <c>DataSourcesServiceClient.DeleteDataSourceAsync</c>.
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
        public gaxgrpc::CallSettings DeleteDataSourceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataSourcesServiceClient.FetchDataSource</c> and <c>DataSourcesServiceClient.FetchDataSourceAsync</c>.
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
        public gaxgrpc::CallSettings FetchDataSourceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DataSourcesServiceSettings"/> object.</returns>
        public DataSourcesServiceSettings Clone() => new DataSourcesServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DataSourcesServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class DataSourcesServiceClientBuilder : gaxgrpc::ClientBuilderBase<DataSourcesServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DataSourcesServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DataSourcesServiceClientBuilder() : base(DataSourcesServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DataSourcesServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DataSourcesServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DataSourcesServiceClient Build()
        {
            DataSourcesServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DataSourcesServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DataSourcesServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DataSourcesServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DataSourcesServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DataSourcesServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DataSourcesServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DataSourcesServiceClient.ChannelPool;
    }

    /// <summary>DataSourcesService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage primary, supplemental, inventory and other data sources.
    /// See more in the [Merchant
    /// Center](https://support.google.com/merchants/answer/7439058) help article.
    /// </remarks>
    public abstract partial class DataSourcesServiceClient
    {
        /// <summary>
        /// The default endpoint for the DataSourcesService service, which is a host of "merchantapi.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default DataSourcesService scopes.</summary>
        /// <remarks>
        /// The default DataSourcesService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DataSourcesService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DataSourcesServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DataSourcesServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DataSourcesServiceClient"/>.</returns>
        public static stt::Task<DataSourcesServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DataSourcesServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DataSourcesServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DataSourcesServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="DataSourcesServiceClient"/>.</returns>
        public static DataSourcesServiceClient Create() => new DataSourcesServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DataSourcesServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DataSourcesServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DataSourcesServiceClient"/>.</returns>
        internal static DataSourcesServiceClient Create(grpccore::CallInvoker callInvoker, DataSourcesServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DataSourcesService.DataSourcesServiceClient grpcClient = new DataSourcesService.DataSourcesServiceClient(callInvoker);
            return new DataSourcesServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DataSourcesService client</summary>
        public virtual DataSourcesService.DataSourcesServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the data source configuration for the given account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataSource GetDataSource(GetDataSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the data source configuration for the given account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSource> GetDataSourceAsync(GetDataSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the data source configuration for the given account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSource> GetDataSourceAsync(GetDataSourceRequest request, st::CancellationToken cancellationToken) =>
            GetDataSourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the data source configuration for the given account.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data source to retrieve.
        /// Format: `accounts/{account}/dataSources/{datasource}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataSource GetDataSource(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataSource(new GetDataSourceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the data source configuration for the given account.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data source to retrieve.
        /// Format: `accounts/{account}/dataSources/{datasource}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSource> GetDataSourceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataSourceAsync(new GetDataSourceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the data source configuration for the given account.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data source to retrieve.
        /// Format: `accounts/{account}/dataSources/{datasource}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSource> GetDataSourceAsync(string name, st::CancellationToken cancellationToken) =>
            GetDataSourceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the data source configuration for the given account.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data source to retrieve.
        /// Format: `accounts/{account}/dataSources/{datasource}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataSource GetDataSource(DataSourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataSource(new GetDataSourceRequest
            {
                DataSourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the data source configuration for the given account.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data source to retrieve.
        /// Format: `accounts/{account}/dataSources/{datasource}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSource> GetDataSourceAsync(DataSourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataSourceAsync(new GetDataSourceRequest
            {
                DataSourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the data source configuration for the given account.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data source to retrieve.
        /// Format: `accounts/{account}/dataSources/{datasource}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSource> GetDataSourceAsync(DataSourceName name, st::CancellationToken cancellationToken) =>
            GetDataSourceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the configurations for data sources for the given account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataSource"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataSourcesResponse, DataSource> ListDataSources(ListDataSourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the configurations for data sources for the given account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataSource"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataSourcesResponse, DataSource> ListDataSourcesAsync(ListDataSourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the configurations for data sources for the given account.
        /// </summary>
        /// <param name="parent">
        /// Required. The account to list data sources for.
        /// Format: `accounts/{account}`
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
        /// <returns>A pageable sequence of <see cref="DataSource"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataSourcesResponse, DataSource> ListDataSources(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataSourcesRequest request = new ListDataSourcesRequest
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
            return ListDataSources(request, callSettings);
        }

        /// <summary>
        /// Lists the configurations for data sources for the given account.
        /// </summary>
        /// <param name="parent">
        /// Required. The account to list data sources for.
        /// Format: `accounts/{account}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataSource"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataSourcesResponse, DataSource> ListDataSourcesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataSourcesRequest request = new ListDataSourcesRequest
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
            return ListDataSourcesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the configurations for data sources for the given account.
        /// </summary>
        /// <param name="parent">
        /// Required. The account to list data sources for.
        /// Format: `accounts/{account}`
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
        /// <returns>A pageable sequence of <see cref="DataSource"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataSourcesResponse, DataSource> ListDataSources(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataSourcesRequest request = new ListDataSourcesRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDataSources(request, callSettings);
        }

        /// <summary>
        /// Lists the configurations for data sources for the given account.
        /// </summary>
        /// <param name="parent">
        /// Required. The account to list data sources for.
        /// Format: `accounts/{account}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataSource"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataSourcesResponse, DataSource> ListDataSourcesAsync(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataSourcesRequest request = new ListDataSourcesRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDataSourcesAsync(request, callSettings);
        }

        /// <summary>
        /// Creates the new data source configuration for the given account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataSource CreateDataSource(CreateDataSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates the new data source configuration for the given account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSource> CreateDataSourceAsync(CreateDataSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates the new data source configuration for the given account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSource> CreateDataSourceAsync(CreateDataSourceRequest request, st::CancellationToken cancellationToken) =>
            CreateDataSourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates the new data source configuration for the given account.
        /// </summary>
        /// <param name="parent">
        /// Required. The account where this data source will be created.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="dataSource">
        /// Required. The data source to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataSource CreateDataSource(string parent, DataSource dataSource, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataSource(new CreateDataSourceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DataSource = gax::GaxPreconditions.CheckNotNull(dataSource, nameof(dataSource)),
            }, callSettings);

        /// <summary>
        /// Creates the new data source configuration for the given account.
        /// </summary>
        /// <param name="parent">
        /// Required. The account where this data source will be created.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="dataSource">
        /// Required. The data source to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSource> CreateDataSourceAsync(string parent, DataSource dataSource, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataSourceAsync(new CreateDataSourceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DataSource = gax::GaxPreconditions.CheckNotNull(dataSource, nameof(dataSource)),
            }, callSettings);

        /// <summary>
        /// Creates the new data source configuration for the given account.
        /// </summary>
        /// <param name="parent">
        /// Required. The account where this data source will be created.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="dataSource">
        /// Required. The data source to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSource> CreateDataSourceAsync(string parent, DataSource dataSource, st::CancellationToken cancellationToken) =>
            CreateDataSourceAsync(parent, dataSource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates the new data source configuration for the given account.
        /// </summary>
        /// <param name="parent">
        /// Required. The account where this data source will be created.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="dataSource">
        /// Required. The data source to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataSource CreateDataSource(AccountName parent, DataSource dataSource, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataSource(new CreateDataSourceRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DataSource = gax::GaxPreconditions.CheckNotNull(dataSource, nameof(dataSource)),
            }, callSettings);

        /// <summary>
        /// Creates the new data source configuration for the given account.
        /// </summary>
        /// <param name="parent">
        /// Required. The account where this data source will be created.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="dataSource">
        /// Required. The data source to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSource> CreateDataSourceAsync(AccountName parent, DataSource dataSource, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataSourceAsync(new CreateDataSourceRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DataSource = gax::GaxPreconditions.CheckNotNull(dataSource, nameof(dataSource)),
            }, callSettings);

        /// <summary>
        /// Creates the new data source configuration for the given account.
        /// </summary>
        /// <param name="parent">
        /// Required. The account where this data source will be created.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="dataSource">
        /// Required. The data source to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSource> CreateDataSourceAsync(AccountName parent, DataSource dataSource, st::CancellationToken cancellationToken) =>
            CreateDataSourceAsync(parent, dataSource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the existing data source configuration. The fields that are
        /// set in the update mask but not provided in the resource will be deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataSource UpdateDataSource(UpdateDataSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the existing data source configuration. The fields that are
        /// set in the update mask but not provided in the resource will be deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSource> UpdateDataSourceAsync(UpdateDataSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the existing data source configuration. The fields that are
        /// set in the update mask but not provided in the resource will be deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSource> UpdateDataSourceAsync(UpdateDataSourceRequest request, st::CancellationToken cancellationToken) =>
            UpdateDataSourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the existing data source configuration. The fields that are
        /// set in the update mask but not provided in the resource will be deleted.
        /// </summary>
        /// <param name="dataSource">
        /// Required. The data source resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of data source fields to be updated.
        /// 
        /// Fields specified in the update mask without a value specified in the
        /// body will be deleted from the data source.
        /// 
        /// Providing special "*" value for full data source replacement is not
        /// supported.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataSource UpdateDataSource(DataSource dataSource, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataSource(new UpdateDataSourceRequest
            {
                DataSource = gax::GaxPreconditions.CheckNotNull(dataSource, nameof(dataSource)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the existing data source configuration. The fields that are
        /// set in the update mask but not provided in the resource will be deleted.
        /// </summary>
        /// <param name="dataSource">
        /// Required. The data source resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of data source fields to be updated.
        /// 
        /// Fields specified in the update mask without a value specified in the
        /// body will be deleted from the data source.
        /// 
        /// Providing special "*" value for full data source replacement is not
        /// supported.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSource> UpdateDataSourceAsync(DataSource dataSource, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataSourceAsync(new UpdateDataSourceRequest
            {
                DataSource = gax::GaxPreconditions.CheckNotNull(dataSource, nameof(dataSource)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the existing data source configuration. The fields that are
        /// set in the update mask but not provided in the resource will be deleted.
        /// </summary>
        /// <param name="dataSource">
        /// Required. The data source resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of data source fields to be updated.
        /// 
        /// Fields specified in the update mask without a value specified in the
        /// body will be deleted from the data source.
        /// 
        /// Providing special "*" value for full data source replacement is not
        /// supported.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataSource> UpdateDataSourceAsync(DataSource dataSource, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDataSourceAsync(dataSource, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a data source from your Merchant Center account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDataSource(DeleteDataSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a data source from your Merchant Center account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataSourceAsync(DeleteDataSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a data source from your Merchant Center account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataSourceAsync(DeleteDataSourceRequest request, st::CancellationToken cancellationToken) =>
            DeleteDataSourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a data source from your Merchant Center account.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data source to delete.
        /// Format: `accounts/{account}/dataSources/{datasource}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDataSource(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataSource(new DeleteDataSourceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a data source from your Merchant Center account.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data source to delete.
        /// Format: `accounts/{account}/dataSources/{datasource}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataSourceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataSourceAsync(new DeleteDataSourceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a data source from your Merchant Center account.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data source to delete.
        /// Format: `accounts/{account}/dataSources/{datasource}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataSourceAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDataSourceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a data source from your Merchant Center account.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data source to delete.
        /// Format: `accounts/{account}/dataSources/{datasource}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDataSource(DataSourceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataSource(new DeleteDataSourceRequest
            {
                DataSourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a data source from your Merchant Center account.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data source to delete.
        /// Format: `accounts/{account}/dataSources/{datasource}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataSourceAsync(DataSourceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataSourceAsync(new DeleteDataSourceRequest
            {
                DataSourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a data source from your Merchant Center account.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data source to delete.
        /// Format: `accounts/{account}/dataSources/{datasource}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataSourceAsync(DataSourceName name, st::CancellationToken cancellationToken) =>
            DeleteDataSourceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Performs the data fetch immediately (even outside fetch schedule) on a
        /// data source from your Merchant Center Account. If you need to call
        /// this method more than once per day, you should use the Products service to
        /// update your product data instead.
        /// This method only works on data sources with a file input set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void FetchDataSource(FetchDataSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Performs the data fetch immediately (even outside fetch schedule) on a
        /// data source from your Merchant Center Account. If you need to call
        /// this method more than once per day, you should use the Products service to
        /// update your product data instead.
        /// This method only works on data sources with a file input set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task FetchDataSourceAsync(FetchDataSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Performs the data fetch immediately (even outside fetch schedule) on a
        /// data source from your Merchant Center Account. If you need to call
        /// this method more than once per day, you should use the Products service to
        /// update your product data instead.
        /// This method only works on data sources with a file input set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task FetchDataSourceAsync(FetchDataSourceRequest request, st::CancellationToken cancellationToken) =>
            FetchDataSourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DataSourcesService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage primary, supplemental, inventory and other data sources.
    /// See more in the [Merchant
    /// Center](https://support.google.com/merchants/answer/7439058) help article.
    /// </remarks>
    public sealed partial class DataSourcesServiceClientImpl : DataSourcesServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetDataSourceRequest, DataSource> _callGetDataSource;

        private readonly gaxgrpc::ApiCall<ListDataSourcesRequest, ListDataSourcesResponse> _callListDataSources;

        private readonly gaxgrpc::ApiCall<CreateDataSourceRequest, DataSource> _callCreateDataSource;

        private readonly gaxgrpc::ApiCall<UpdateDataSourceRequest, DataSource> _callUpdateDataSource;

        private readonly gaxgrpc::ApiCall<DeleteDataSourceRequest, wkt::Empty> _callDeleteDataSource;

        private readonly gaxgrpc::ApiCall<FetchDataSourceRequest, wkt::Empty> _callFetchDataSource;

        /// <summary>
        /// Constructs a client wrapper for the DataSourcesService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DataSourcesServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DataSourcesServiceClientImpl(DataSourcesService.DataSourcesServiceClient grpcClient, DataSourcesServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DataSourcesServiceSettings effectiveSettings = settings ?? DataSourcesServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetDataSource = clientHelper.BuildApiCall<GetDataSourceRequest, DataSource>("GetDataSource", grpcClient.GetDataSourceAsync, grpcClient.GetDataSource, effectiveSettings.GetDataSourceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDataSource);
            Modify_GetDataSourceApiCall(ref _callGetDataSource);
            _callListDataSources = clientHelper.BuildApiCall<ListDataSourcesRequest, ListDataSourcesResponse>("ListDataSources", grpcClient.ListDataSourcesAsync, grpcClient.ListDataSources, effectiveSettings.ListDataSourcesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDataSources);
            Modify_ListDataSourcesApiCall(ref _callListDataSources);
            _callCreateDataSource = clientHelper.BuildApiCall<CreateDataSourceRequest, DataSource>("CreateDataSource", grpcClient.CreateDataSourceAsync, grpcClient.CreateDataSource, effectiveSettings.CreateDataSourceSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDataSource);
            Modify_CreateDataSourceApiCall(ref _callCreateDataSource);
            _callUpdateDataSource = clientHelper.BuildApiCall<UpdateDataSourceRequest, DataSource>("UpdateDataSource", grpcClient.UpdateDataSourceAsync, grpcClient.UpdateDataSource, effectiveSettings.UpdateDataSourceSettings).WithGoogleRequestParam("data_source.name", request => request.DataSource?.Name);
            Modify_ApiCall(ref _callUpdateDataSource);
            Modify_UpdateDataSourceApiCall(ref _callUpdateDataSource);
            _callDeleteDataSource = clientHelper.BuildApiCall<DeleteDataSourceRequest, wkt::Empty>("DeleteDataSource", grpcClient.DeleteDataSourceAsync, grpcClient.DeleteDataSource, effectiveSettings.DeleteDataSourceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDataSource);
            Modify_DeleteDataSourceApiCall(ref _callDeleteDataSource);
            _callFetchDataSource = clientHelper.BuildApiCall<FetchDataSourceRequest, wkt::Empty>("FetchDataSource", grpcClient.FetchDataSourceAsync, grpcClient.FetchDataSource, effectiveSettings.FetchDataSourceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callFetchDataSource);
            Modify_FetchDataSourceApiCall(ref _callFetchDataSource);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetDataSourceApiCall(ref gaxgrpc::ApiCall<GetDataSourceRequest, DataSource> call);

        partial void Modify_ListDataSourcesApiCall(ref gaxgrpc::ApiCall<ListDataSourcesRequest, ListDataSourcesResponse> call);

        partial void Modify_CreateDataSourceApiCall(ref gaxgrpc::ApiCall<CreateDataSourceRequest, DataSource> call);

        partial void Modify_UpdateDataSourceApiCall(ref gaxgrpc::ApiCall<UpdateDataSourceRequest, DataSource> call);

        partial void Modify_DeleteDataSourceApiCall(ref gaxgrpc::ApiCall<DeleteDataSourceRequest, wkt::Empty> call);

        partial void Modify_FetchDataSourceApiCall(ref gaxgrpc::ApiCall<FetchDataSourceRequest, wkt::Empty> call);

        partial void OnConstruction(DataSourcesService.DataSourcesServiceClient grpcClient, DataSourcesServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DataSourcesService client</summary>
        public override DataSourcesService.DataSourcesServiceClient GrpcClient { get; }

        partial void Modify_GetDataSourceRequest(ref GetDataSourceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDataSourcesRequest(ref ListDataSourcesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateDataSourceRequest(ref CreateDataSourceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDataSourceRequest(ref UpdateDataSourceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDataSourceRequest(ref DeleteDataSourceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchDataSourceRequest(ref FetchDataSourceRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves the data source configuration for the given account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataSource GetDataSource(GetDataSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataSourceRequest(ref request, ref callSettings);
            return _callGetDataSource.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the data source configuration for the given account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataSource> GetDataSourceAsync(GetDataSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataSourceRequest(ref request, ref callSettings);
            return _callGetDataSource.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the configurations for data sources for the given account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataSource"/> resources.</returns>
        public override gax::PagedEnumerable<ListDataSourcesResponse, DataSource> ListDataSources(ListDataSourcesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataSourcesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDataSourcesRequest, ListDataSourcesResponse, DataSource>(_callListDataSources, request, callSettings);
        }

        /// <summary>
        /// Lists the configurations for data sources for the given account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataSource"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDataSourcesResponse, DataSource> ListDataSourcesAsync(ListDataSourcesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataSourcesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDataSourcesRequest, ListDataSourcesResponse, DataSource>(_callListDataSources, request, callSettings);
        }

        /// <summary>
        /// Creates the new data source configuration for the given account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataSource CreateDataSource(CreateDataSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataSourceRequest(ref request, ref callSettings);
            return _callCreateDataSource.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates the new data source configuration for the given account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataSource> CreateDataSourceAsync(CreateDataSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataSourceRequest(ref request, ref callSettings);
            return _callCreateDataSource.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the existing data source configuration. The fields that are
        /// set in the update mask but not provided in the resource will be deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataSource UpdateDataSource(UpdateDataSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataSourceRequest(ref request, ref callSettings);
            return _callUpdateDataSource.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the existing data source configuration. The fields that are
        /// set in the update mask but not provided in the resource will be deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataSource> UpdateDataSourceAsync(UpdateDataSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataSourceRequest(ref request, ref callSettings);
            return _callUpdateDataSource.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a data source from your Merchant Center account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteDataSource(DeleteDataSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDataSourceRequest(ref request, ref callSettings);
            _callDeleteDataSource.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a data source from your Merchant Center account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteDataSourceAsync(DeleteDataSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDataSourceRequest(ref request, ref callSettings);
            return _callDeleteDataSource.Async(request, callSettings);
        }

        /// <summary>
        /// Performs the data fetch immediately (even outside fetch schedule) on a
        /// data source from your Merchant Center Account. If you need to call
        /// this method more than once per day, you should use the Products service to
        /// update your product data instead.
        /// This method only works on data sources with a file input set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void FetchDataSource(FetchDataSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchDataSourceRequest(ref request, ref callSettings);
            _callFetchDataSource.Sync(request, callSettings);
        }

        /// <summary>
        /// Performs the data fetch immediately (even outside fetch schedule) on a
        /// data source from your Merchant Center Account. If you need to call
        /// this method more than once per day, you should use the Products service to
        /// update your product data instead.
        /// This method only works on data sources with a file input set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task FetchDataSourceAsync(FetchDataSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchDataSourceRequest(ref request, ref callSettings);
            return _callFetchDataSource.Async(request, callSettings);
        }
    }

    public partial class ListDataSourcesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDataSourcesResponse : gaxgrpc::IPageResponse<DataSource>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DataSource> GetEnumerator() => DataSources.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
