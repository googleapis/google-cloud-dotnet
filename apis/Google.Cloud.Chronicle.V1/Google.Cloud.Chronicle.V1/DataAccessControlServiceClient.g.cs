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

namespace Google.Cloud.Chronicle.V1
{
    /// <summary>Settings for <see cref="DataAccessControlServiceClient"/> instances.</summary>
    public sealed partial class DataAccessControlServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DataAccessControlServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DataAccessControlServiceSettings"/>.</returns>
        public static DataAccessControlServiceSettings GetDefault() => new DataAccessControlServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="DataAccessControlServiceSettings"/> object with default settings.
        /// </summary>
        public DataAccessControlServiceSettings()
        {
        }

        private DataAccessControlServiceSettings(DataAccessControlServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateDataAccessLabelSettings = existing.CreateDataAccessLabelSettings;
            GetDataAccessLabelSettings = existing.GetDataAccessLabelSettings;
            ListDataAccessLabelsSettings = existing.ListDataAccessLabelsSettings;
            UpdateDataAccessLabelSettings = existing.UpdateDataAccessLabelSettings;
            DeleteDataAccessLabelSettings = existing.DeleteDataAccessLabelSettings;
            CreateDataAccessScopeSettings = existing.CreateDataAccessScopeSettings;
            GetDataAccessScopeSettings = existing.GetDataAccessScopeSettings;
            ListDataAccessScopesSettings = existing.ListDataAccessScopesSettings;
            UpdateDataAccessScopeSettings = existing.UpdateDataAccessScopeSettings;
            DeleteDataAccessScopeSettings = existing.DeleteDataAccessScopeSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DataAccessControlServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataAccessControlServiceClient.CreateDataAccessLabel</c> and
        /// <c>DataAccessControlServiceClient.CreateDataAccessLabelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDataAccessLabelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataAccessControlServiceClient.GetDataAccessLabel</c> and
        /// <c>DataAccessControlServiceClient.GetDataAccessLabelAsync</c>.
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
        public gaxgrpc::CallSettings GetDataAccessLabelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataAccessControlServiceClient.ListDataAccessLabels</c> and
        /// <c>DataAccessControlServiceClient.ListDataAccessLabelsAsync</c>.
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
        public gaxgrpc::CallSettings ListDataAccessLabelsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataAccessControlServiceClient.UpdateDataAccessLabel</c> and
        /// <c>DataAccessControlServiceClient.UpdateDataAccessLabelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDataAccessLabelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataAccessControlServiceClient.DeleteDataAccessLabel</c> and
        /// <c>DataAccessControlServiceClient.DeleteDataAccessLabelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDataAccessLabelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataAccessControlServiceClient.CreateDataAccessScope</c> and
        /// <c>DataAccessControlServiceClient.CreateDataAccessScopeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDataAccessScopeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataAccessControlServiceClient.GetDataAccessScope</c> and
        /// <c>DataAccessControlServiceClient.GetDataAccessScopeAsync</c>.
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
        public gaxgrpc::CallSettings GetDataAccessScopeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataAccessControlServiceClient.ListDataAccessScopes</c> and
        /// <c>DataAccessControlServiceClient.ListDataAccessScopesAsync</c>.
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
        public gaxgrpc::CallSettings ListDataAccessScopesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataAccessControlServiceClient.UpdateDataAccessScope</c> and
        /// <c>DataAccessControlServiceClient.UpdateDataAccessScopeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDataAccessScopeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataAccessControlServiceClient.DeleteDataAccessScope</c> and
        /// <c>DataAccessControlServiceClient.DeleteDataAccessScopeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDataAccessScopeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DataAccessControlServiceSettings"/> object.</returns>
        public DataAccessControlServiceSettings Clone() => new DataAccessControlServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DataAccessControlServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class DataAccessControlServiceClientBuilder : gaxgrpc::ClientBuilderBase<DataAccessControlServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DataAccessControlServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DataAccessControlServiceClientBuilder() : base(DataAccessControlServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DataAccessControlServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DataAccessControlServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DataAccessControlServiceClient Build()
        {
            DataAccessControlServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DataAccessControlServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DataAccessControlServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DataAccessControlServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DataAccessControlServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DataAccessControlServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DataAccessControlServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DataAccessControlServiceClient.ChannelPool;
    }

    /// <summary>DataAccessControlService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// DataAccessControlService exposes resources and endpoints related to data
    /// access control.
    /// </remarks>
    public abstract partial class DataAccessControlServiceClient
    {
        /// <summary>
        /// The default endpoint for the DataAccessControlService service, which is a host of "chronicle.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "chronicle.googleapis.com:443";

        /// <summary>The default DataAccessControlService scopes.</summary>
        /// <remarks>
        /// The default DataAccessControlService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DataAccessControlService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DataAccessControlServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="DataAccessControlServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DataAccessControlServiceClient"/>.</returns>
        public static stt::Task<DataAccessControlServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DataAccessControlServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DataAccessControlServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="DataAccessControlServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DataAccessControlServiceClient"/>.</returns>
        public static DataAccessControlServiceClient Create() => new DataAccessControlServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DataAccessControlServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DataAccessControlServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DataAccessControlServiceClient"/>.</returns>
        internal static DataAccessControlServiceClient Create(grpccore::CallInvoker callInvoker, DataAccessControlServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DataAccessControlService.DataAccessControlServiceClient grpcClient = new DataAccessControlService.DataAccessControlServiceClient(callInvoker);
            return new DataAccessControlServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DataAccessControlService client</summary>
        public virtual DataAccessControlService.DataAccessControlServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a data access label.
        /// Data access labels are applied to incoming event data and selected in data
        /// access scopes (another resource), and only users with scopes containing the
        /// label can see data with that label. Currently, the data access label
        /// resource only includes custom labels, which are labels that correspond
        /// to UDM queries over event data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataAccessLabel CreateDataAccessLabel(CreateDataAccessLabelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a data access label.
        /// Data access labels are applied to incoming event data and selected in data
        /// access scopes (another resource), and only users with scopes containing the
        /// label can see data with that label. Currently, the data access label
        /// resource only includes custom labels, which are labels that correspond
        /// to UDM queries over event data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAccessLabel> CreateDataAccessLabelAsync(CreateDataAccessLabelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a data access label.
        /// Data access labels are applied to incoming event data and selected in data
        /// access scopes (another resource), and only users with scopes containing the
        /// label can see data with that label. Currently, the data access label
        /// resource only includes custom labels, which are labels that correspond
        /// to UDM queries over event data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAccessLabel> CreateDataAccessLabelAsync(CreateDataAccessLabelRequest request, st::CancellationToken cancellationToken) =>
            CreateDataAccessLabelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a data access label.
        /// Data access labels are applied to incoming event data and selected in data
        /// access scopes (another resource), and only users with scopes containing the
        /// label can see data with that label. Currently, the data access label
        /// resource only includes custom labels, which are labels that correspond
        /// to UDM queries over event data.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this Data Access Label will be created.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="dataAccessLabel">
        /// Required. Data access label to create.
        /// </param>
        /// <param name="dataAccessLabelId">
        /// Required. The ID to use for the data access label, which will become the
        /// label's display name and the final component of the label's resource name.
        /// The maximum number of characters should be 63. Regex pattern is as per AIP:
        /// https://google.aip.dev/122#resource-id-segments
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataAccessLabel CreateDataAccessLabel(string parent, DataAccessLabel dataAccessLabel, string dataAccessLabelId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataAccessLabel(new CreateDataAccessLabelRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DataAccessLabel = gax::GaxPreconditions.CheckNotNull(dataAccessLabel, nameof(dataAccessLabel)),
                DataAccessLabelId = gax::GaxPreconditions.CheckNotNullOrEmpty(dataAccessLabelId, nameof(dataAccessLabelId)),
            }, callSettings);

        /// <summary>
        /// Creates a data access label.
        /// Data access labels are applied to incoming event data and selected in data
        /// access scopes (another resource), and only users with scopes containing the
        /// label can see data with that label. Currently, the data access label
        /// resource only includes custom labels, which are labels that correspond
        /// to UDM queries over event data.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this Data Access Label will be created.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="dataAccessLabel">
        /// Required. Data access label to create.
        /// </param>
        /// <param name="dataAccessLabelId">
        /// Required. The ID to use for the data access label, which will become the
        /// label's display name and the final component of the label's resource name.
        /// The maximum number of characters should be 63. Regex pattern is as per AIP:
        /// https://google.aip.dev/122#resource-id-segments
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAccessLabel> CreateDataAccessLabelAsync(string parent, DataAccessLabel dataAccessLabel, string dataAccessLabelId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataAccessLabelAsync(new CreateDataAccessLabelRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DataAccessLabel = gax::GaxPreconditions.CheckNotNull(dataAccessLabel, nameof(dataAccessLabel)),
                DataAccessLabelId = gax::GaxPreconditions.CheckNotNullOrEmpty(dataAccessLabelId, nameof(dataAccessLabelId)),
            }, callSettings);

        /// <summary>
        /// Creates a data access label.
        /// Data access labels are applied to incoming event data and selected in data
        /// access scopes (another resource), and only users with scopes containing the
        /// label can see data with that label. Currently, the data access label
        /// resource only includes custom labels, which are labels that correspond
        /// to UDM queries over event data.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this Data Access Label will be created.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="dataAccessLabel">
        /// Required. Data access label to create.
        /// </param>
        /// <param name="dataAccessLabelId">
        /// Required. The ID to use for the data access label, which will become the
        /// label's display name and the final component of the label's resource name.
        /// The maximum number of characters should be 63. Regex pattern is as per AIP:
        /// https://google.aip.dev/122#resource-id-segments
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAccessLabel> CreateDataAccessLabelAsync(string parent, DataAccessLabel dataAccessLabel, string dataAccessLabelId, st::CancellationToken cancellationToken) =>
            CreateDataAccessLabelAsync(parent, dataAccessLabel, dataAccessLabelId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a data access label.
        /// Data access labels are applied to incoming event data and selected in data
        /// access scopes (another resource), and only users with scopes containing the
        /// label can see data with that label. Currently, the data access label
        /// resource only includes custom labels, which are labels that correspond
        /// to UDM queries over event data.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this Data Access Label will be created.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="dataAccessLabel">
        /// Required. Data access label to create.
        /// </param>
        /// <param name="dataAccessLabelId">
        /// Required. The ID to use for the data access label, which will become the
        /// label's display name and the final component of the label's resource name.
        /// The maximum number of characters should be 63. Regex pattern is as per AIP:
        /// https://google.aip.dev/122#resource-id-segments
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataAccessLabel CreateDataAccessLabel(InstanceName parent, DataAccessLabel dataAccessLabel, string dataAccessLabelId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataAccessLabel(new CreateDataAccessLabelRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DataAccessLabel = gax::GaxPreconditions.CheckNotNull(dataAccessLabel, nameof(dataAccessLabel)),
                DataAccessLabelId = gax::GaxPreconditions.CheckNotNullOrEmpty(dataAccessLabelId, nameof(dataAccessLabelId)),
            }, callSettings);

        /// <summary>
        /// Creates a data access label.
        /// Data access labels are applied to incoming event data and selected in data
        /// access scopes (another resource), and only users with scopes containing the
        /// label can see data with that label. Currently, the data access label
        /// resource only includes custom labels, which are labels that correspond
        /// to UDM queries over event data.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this Data Access Label will be created.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="dataAccessLabel">
        /// Required. Data access label to create.
        /// </param>
        /// <param name="dataAccessLabelId">
        /// Required. The ID to use for the data access label, which will become the
        /// label's display name and the final component of the label's resource name.
        /// The maximum number of characters should be 63. Regex pattern is as per AIP:
        /// https://google.aip.dev/122#resource-id-segments
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAccessLabel> CreateDataAccessLabelAsync(InstanceName parent, DataAccessLabel dataAccessLabel, string dataAccessLabelId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataAccessLabelAsync(new CreateDataAccessLabelRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DataAccessLabel = gax::GaxPreconditions.CheckNotNull(dataAccessLabel, nameof(dataAccessLabel)),
                DataAccessLabelId = gax::GaxPreconditions.CheckNotNullOrEmpty(dataAccessLabelId, nameof(dataAccessLabelId)),
            }, callSettings);

        /// <summary>
        /// Creates a data access label.
        /// Data access labels are applied to incoming event data and selected in data
        /// access scopes (another resource), and only users with scopes containing the
        /// label can see data with that label. Currently, the data access label
        /// resource only includes custom labels, which are labels that correspond
        /// to UDM queries over event data.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this Data Access Label will be created.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="dataAccessLabel">
        /// Required. Data access label to create.
        /// </param>
        /// <param name="dataAccessLabelId">
        /// Required. The ID to use for the data access label, which will become the
        /// label's display name and the final component of the label's resource name.
        /// The maximum number of characters should be 63. Regex pattern is as per AIP:
        /// https://google.aip.dev/122#resource-id-segments
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAccessLabel> CreateDataAccessLabelAsync(InstanceName parent, DataAccessLabel dataAccessLabel, string dataAccessLabelId, st::CancellationToken cancellationToken) =>
            CreateDataAccessLabelAsync(parent, dataAccessLabel, dataAccessLabelId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a data access label.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataAccessLabel GetDataAccessLabel(GetDataAccessLabelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a data access label.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAccessLabel> GetDataAccessLabelAsync(GetDataAccessLabelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a data access label.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAccessLabel> GetDataAccessLabelAsync(GetDataAccessLabelRequest request, st::CancellationToken cancellationToken) =>
            GetDataAccessLabelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a data access label.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the data access label to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/dataAccessLabels/{data_access_label}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataAccessLabel GetDataAccessLabel(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataAccessLabel(new GetDataAccessLabelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a data access label.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the data access label to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/dataAccessLabels/{data_access_label}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAccessLabel> GetDataAccessLabelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataAccessLabelAsync(new GetDataAccessLabelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a data access label.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the data access label to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/dataAccessLabels/{data_access_label}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAccessLabel> GetDataAccessLabelAsync(string name, st::CancellationToken cancellationToken) =>
            GetDataAccessLabelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a data access label.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the data access label to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/dataAccessLabels/{data_access_label}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataAccessLabel GetDataAccessLabel(DataAccessLabelName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataAccessLabel(new GetDataAccessLabelRequest
            {
                DataAccessLabelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a data access label.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the data access label to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/dataAccessLabels/{data_access_label}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAccessLabel> GetDataAccessLabelAsync(DataAccessLabelName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataAccessLabelAsync(new GetDataAccessLabelRequest
            {
                DataAccessLabelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a data access label.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the data access label to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/dataAccessLabels/{data_access_label}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAccessLabel> GetDataAccessLabelAsync(DataAccessLabelName name, st::CancellationToken cancellationToken) =>
            GetDataAccessLabelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all data access labels for the customer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataAccessLabel"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataAccessLabelsResponse, DataAccessLabel> ListDataAccessLabels(ListDataAccessLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all data access labels for the customer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataAccessLabel"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataAccessLabelsResponse, DataAccessLabel> ListDataAccessLabelsAsync(ListDataAccessLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all data access labels for the customer.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this data access label will be created.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
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
        /// <returns>A pageable sequence of <see cref="DataAccessLabel"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataAccessLabelsResponse, DataAccessLabel> ListDataAccessLabels(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataAccessLabelsRequest request = new ListDataAccessLabelsRequest
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
            return ListDataAccessLabels(request, callSettings);
        }

        /// <summary>
        /// Lists all data access labels for the customer.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this data access label will be created.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataAccessLabel"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataAccessLabelsResponse, DataAccessLabel> ListDataAccessLabelsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataAccessLabelsRequest request = new ListDataAccessLabelsRequest
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
            return ListDataAccessLabelsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all data access labels for the customer.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this data access label will be created.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
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
        /// <returns>A pageable sequence of <see cref="DataAccessLabel"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataAccessLabelsResponse, DataAccessLabel> ListDataAccessLabels(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataAccessLabelsRequest request = new ListDataAccessLabelsRequest
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
            return ListDataAccessLabels(request, callSettings);
        }

        /// <summary>
        /// Lists all data access labels for the customer.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this data access label will be created.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataAccessLabel"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataAccessLabelsResponse, DataAccessLabel> ListDataAccessLabelsAsync(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataAccessLabelsRequest request = new ListDataAccessLabelsRequest
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
            return ListDataAccessLabelsAsync(request, callSettings);
        }

        /// <summary>
        /// Updates a data access label.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataAccessLabel UpdateDataAccessLabel(UpdateDataAccessLabelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a data access label.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAccessLabel> UpdateDataAccessLabelAsync(UpdateDataAccessLabelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a data access label.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAccessLabel> UpdateDataAccessLabelAsync(UpdateDataAccessLabelRequest request, st::CancellationToken cancellationToken) =>
            UpdateDataAccessLabelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a data access label.
        /// </summary>
        /// <param name="dataAccessLabel">
        /// Required. The data access label to update.
        /// 
        /// The label's `name` field is used to identify the label to update.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/dataAccessLabels/{data_access_label}`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update. If not included, all fields with a non-empty
        /// value will be overwritten. Currently, only the description and definition
        /// fields are supported for update; an update call that attempts to update any
        /// other fields will return INVALID_ARGUMENT.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataAccessLabel UpdateDataAccessLabel(DataAccessLabel dataAccessLabel, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataAccessLabel(new UpdateDataAccessLabelRequest
            {
                DataAccessLabel = gax::GaxPreconditions.CheckNotNull(dataAccessLabel, nameof(dataAccessLabel)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a data access label.
        /// </summary>
        /// <param name="dataAccessLabel">
        /// Required. The data access label to update.
        /// 
        /// The label's `name` field is used to identify the label to update.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/dataAccessLabels/{data_access_label}`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update. If not included, all fields with a non-empty
        /// value will be overwritten. Currently, only the description and definition
        /// fields are supported for update; an update call that attempts to update any
        /// other fields will return INVALID_ARGUMENT.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAccessLabel> UpdateDataAccessLabelAsync(DataAccessLabel dataAccessLabel, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataAccessLabelAsync(new UpdateDataAccessLabelRequest
            {
                DataAccessLabel = gax::GaxPreconditions.CheckNotNull(dataAccessLabel, nameof(dataAccessLabel)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a data access label.
        /// </summary>
        /// <param name="dataAccessLabel">
        /// Required. The data access label to update.
        /// 
        /// The label's `name` field is used to identify the label to update.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/dataAccessLabels/{data_access_label}`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update. If not included, all fields with a non-empty
        /// value will be overwritten. Currently, only the description and definition
        /// fields are supported for update; an update call that attempts to update any
        /// other fields will return INVALID_ARGUMENT.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAccessLabel> UpdateDataAccessLabelAsync(DataAccessLabel dataAccessLabel, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDataAccessLabelAsync(dataAccessLabel, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a data access label. When a label is deleted, new
        /// data that enters in the system will not receive the label, but the label
        /// will not be removed from old data that still refers to it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDataAccessLabel(DeleteDataAccessLabelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a data access label. When a label is deleted, new
        /// data that enters in the system will not receive the label, but the label
        /// will not be removed from old data that still refers to it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataAccessLabelAsync(DeleteDataAccessLabelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a data access label. When a label is deleted, new
        /// data that enters in the system will not receive the label, but the label
        /// will not be removed from old data that still refers to it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataAccessLabelAsync(DeleteDataAccessLabelRequest request, st::CancellationToken cancellationToken) =>
            DeleteDataAccessLabelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a data access label. When a label is deleted, new
        /// data that enters in the system will not receive the label, but the label
        /// will not be removed from old data that still refers to it.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the data access label to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/dataAccessLabels/{data_access_label}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDataAccessLabel(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataAccessLabel(new DeleteDataAccessLabelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a data access label. When a label is deleted, new
        /// data that enters in the system will not receive the label, but the label
        /// will not be removed from old data that still refers to it.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the data access label to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/dataAccessLabels/{data_access_label}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataAccessLabelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataAccessLabelAsync(new DeleteDataAccessLabelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a data access label. When a label is deleted, new
        /// data that enters in the system will not receive the label, but the label
        /// will not be removed from old data that still refers to it.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the data access label to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/dataAccessLabels/{data_access_label}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataAccessLabelAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDataAccessLabelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a data access label. When a label is deleted, new
        /// data that enters in the system will not receive the label, but the label
        /// will not be removed from old data that still refers to it.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the data access label to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/dataAccessLabels/{data_access_label}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDataAccessLabel(DataAccessLabelName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataAccessLabel(new DeleteDataAccessLabelRequest
            {
                DataAccessLabelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a data access label. When a label is deleted, new
        /// data that enters in the system will not receive the label, but the label
        /// will not be removed from old data that still refers to it.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the data access label to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/dataAccessLabels/{data_access_label}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataAccessLabelAsync(DataAccessLabelName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataAccessLabelAsync(new DeleteDataAccessLabelRequest
            {
                DataAccessLabelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a data access label. When a label is deleted, new
        /// data that enters in the system will not receive the label, but the label
        /// will not be removed from old data that still refers to it.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the data access label to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/dataAccessLabels/{data_access_label}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataAccessLabelAsync(DataAccessLabelName name, st::CancellationToken cancellationToken) =>
            DeleteDataAccessLabelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a data access scope.
        /// Data access scope is a combination of allowed and denied labels attached
        /// to a permission group. If a scope has allowed labels A and B and denied
        /// labels C and D, then the group of people attached to the scope
        /// will have permissions to see all events labeled with A or B (or both) and
        /// not labeled with either C or D.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataAccessScope CreateDataAccessScope(CreateDataAccessScopeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a data access scope.
        /// Data access scope is a combination of allowed and denied labels attached
        /// to a permission group. If a scope has allowed labels A and B and denied
        /// labels C and D, then the group of people attached to the scope
        /// will have permissions to see all events labeled with A or B (or both) and
        /// not labeled with either C or D.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAccessScope> CreateDataAccessScopeAsync(CreateDataAccessScopeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a data access scope.
        /// Data access scope is a combination of allowed and denied labels attached
        /// to a permission group. If a scope has allowed labels A and B and denied
        /// labels C and D, then the group of people attached to the scope
        /// will have permissions to see all events labeled with A or B (or both) and
        /// not labeled with either C or D.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAccessScope> CreateDataAccessScopeAsync(CreateDataAccessScopeRequest request, st::CancellationToken cancellationToken) =>
            CreateDataAccessScopeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a data access scope.
        /// Data access scope is a combination of allowed and denied labels attached
        /// to a permission group. If a scope has allowed labels A and B and denied
        /// labels C and D, then the group of people attached to the scope
        /// will have permissions to see all events labeled with A or B (or both) and
        /// not labeled with either C or D.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this Data Access Scope will be created.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="dataAccessScope">
        /// Required. Data access scope to create.
        /// </param>
        /// <param name="dataAccessScopeId">
        /// Required. The user provided scope id which will become the last part of the
        /// name of the scope resource. Needs to be compliant with
        /// https://google.aip.dev/122
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataAccessScope CreateDataAccessScope(string parent, DataAccessScope dataAccessScope, string dataAccessScopeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataAccessScope(new CreateDataAccessScopeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DataAccessScope = gax::GaxPreconditions.CheckNotNull(dataAccessScope, nameof(dataAccessScope)),
                DataAccessScopeId = gax::GaxPreconditions.CheckNotNullOrEmpty(dataAccessScopeId, nameof(dataAccessScopeId)),
            }, callSettings);

        /// <summary>
        /// Creates a data access scope.
        /// Data access scope is a combination of allowed and denied labels attached
        /// to a permission group. If a scope has allowed labels A and B and denied
        /// labels C and D, then the group of people attached to the scope
        /// will have permissions to see all events labeled with A or B (or both) and
        /// not labeled with either C or D.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this Data Access Scope will be created.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="dataAccessScope">
        /// Required. Data access scope to create.
        /// </param>
        /// <param name="dataAccessScopeId">
        /// Required. The user provided scope id which will become the last part of the
        /// name of the scope resource. Needs to be compliant with
        /// https://google.aip.dev/122
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAccessScope> CreateDataAccessScopeAsync(string parent, DataAccessScope dataAccessScope, string dataAccessScopeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataAccessScopeAsync(new CreateDataAccessScopeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DataAccessScope = gax::GaxPreconditions.CheckNotNull(dataAccessScope, nameof(dataAccessScope)),
                DataAccessScopeId = gax::GaxPreconditions.CheckNotNullOrEmpty(dataAccessScopeId, nameof(dataAccessScopeId)),
            }, callSettings);

        /// <summary>
        /// Creates a data access scope.
        /// Data access scope is a combination of allowed and denied labels attached
        /// to a permission group. If a scope has allowed labels A and B and denied
        /// labels C and D, then the group of people attached to the scope
        /// will have permissions to see all events labeled with A or B (or both) and
        /// not labeled with either C or D.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this Data Access Scope will be created.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="dataAccessScope">
        /// Required. Data access scope to create.
        /// </param>
        /// <param name="dataAccessScopeId">
        /// Required. The user provided scope id which will become the last part of the
        /// name of the scope resource. Needs to be compliant with
        /// https://google.aip.dev/122
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAccessScope> CreateDataAccessScopeAsync(string parent, DataAccessScope dataAccessScope, string dataAccessScopeId, st::CancellationToken cancellationToken) =>
            CreateDataAccessScopeAsync(parent, dataAccessScope, dataAccessScopeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a data access scope.
        /// Data access scope is a combination of allowed and denied labels attached
        /// to a permission group. If a scope has allowed labels A and B and denied
        /// labels C and D, then the group of people attached to the scope
        /// will have permissions to see all events labeled with A or B (or both) and
        /// not labeled with either C or D.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this Data Access Scope will be created.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="dataAccessScope">
        /// Required. Data access scope to create.
        /// </param>
        /// <param name="dataAccessScopeId">
        /// Required. The user provided scope id which will become the last part of the
        /// name of the scope resource. Needs to be compliant with
        /// https://google.aip.dev/122
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataAccessScope CreateDataAccessScope(InstanceName parent, DataAccessScope dataAccessScope, string dataAccessScopeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataAccessScope(new CreateDataAccessScopeRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DataAccessScope = gax::GaxPreconditions.CheckNotNull(dataAccessScope, nameof(dataAccessScope)),
                DataAccessScopeId = gax::GaxPreconditions.CheckNotNullOrEmpty(dataAccessScopeId, nameof(dataAccessScopeId)),
            }, callSettings);

        /// <summary>
        /// Creates a data access scope.
        /// Data access scope is a combination of allowed and denied labels attached
        /// to a permission group. If a scope has allowed labels A and B and denied
        /// labels C and D, then the group of people attached to the scope
        /// will have permissions to see all events labeled with A or B (or both) and
        /// not labeled with either C or D.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this Data Access Scope will be created.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="dataAccessScope">
        /// Required. Data access scope to create.
        /// </param>
        /// <param name="dataAccessScopeId">
        /// Required. The user provided scope id which will become the last part of the
        /// name of the scope resource. Needs to be compliant with
        /// https://google.aip.dev/122
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAccessScope> CreateDataAccessScopeAsync(InstanceName parent, DataAccessScope dataAccessScope, string dataAccessScopeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataAccessScopeAsync(new CreateDataAccessScopeRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DataAccessScope = gax::GaxPreconditions.CheckNotNull(dataAccessScope, nameof(dataAccessScope)),
                DataAccessScopeId = gax::GaxPreconditions.CheckNotNullOrEmpty(dataAccessScopeId, nameof(dataAccessScopeId)),
            }, callSettings);

        /// <summary>
        /// Creates a data access scope.
        /// Data access scope is a combination of allowed and denied labels attached
        /// to a permission group. If a scope has allowed labels A and B and denied
        /// labels C and D, then the group of people attached to the scope
        /// will have permissions to see all events labeled with A or B (or both) and
        /// not labeled with either C or D.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this Data Access Scope will be created.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="dataAccessScope">
        /// Required. Data access scope to create.
        /// </param>
        /// <param name="dataAccessScopeId">
        /// Required. The user provided scope id which will become the last part of the
        /// name of the scope resource. Needs to be compliant with
        /// https://google.aip.dev/122
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAccessScope> CreateDataAccessScopeAsync(InstanceName parent, DataAccessScope dataAccessScope, string dataAccessScopeId, st::CancellationToken cancellationToken) =>
            CreateDataAccessScopeAsync(parent, dataAccessScope, dataAccessScopeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves an existing data access scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataAccessScope GetDataAccessScope(GetDataAccessScopeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an existing data access scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAccessScope> GetDataAccessScopeAsync(GetDataAccessScopeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an existing data access scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAccessScope> GetDataAccessScopeAsync(GetDataAccessScopeRequest request, st::CancellationToken cancellationToken) =>
            GetDataAccessScopeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves an existing data access scope.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the data access scope to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/dataAccessScopes/{data_access_scope}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataAccessScope GetDataAccessScope(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataAccessScope(new GetDataAccessScopeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves an existing data access scope.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the data access scope to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/dataAccessScopes/{data_access_scope}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAccessScope> GetDataAccessScopeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataAccessScopeAsync(new GetDataAccessScopeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves an existing data access scope.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the data access scope to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/dataAccessScopes/{data_access_scope}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAccessScope> GetDataAccessScopeAsync(string name, st::CancellationToken cancellationToken) =>
            GetDataAccessScopeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves an existing data access scope.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the data access scope to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/dataAccessScopes/{data_access_scope}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataAccessScope GetDataAccessScope(DataAccessScopeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataAccessScope(new GetDataAccessScopeRequest
            {
                DataAccessScopeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves an existing data access scope.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the data access scope to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/dataAccessScopes/{data_access_scope}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAccessScope> GetDataAccessScopeAsync(DataAccessScopeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataAccessScopeAsync(new GetDataAccessScopeRequest
            {
                DataAccessScopeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves an existing data access scope.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the data access scope to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/dataAccessScopes/{data_access_scope}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAccessScope> GetDataAccessScopeAsync(DataAccessScopeName name, st::CancellationToken cancellationToken) =>
            GetDataAccessScopeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all existing data access scopes for the customer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataAccessScope"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataAccessScopesResponse, DataAccessScope> ListDataAccessScopes(ListDataAccessScopesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all existing data access scopes for the customer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataAccessScope"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataAccessScopesResponse, DataAccessScope> ListDataAccessScopesAsync(ListDataAccessScopesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all existing data access scopes for the customer.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this data access scope will be created.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
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
        /// <returns>A pageable sequence of <see cref="DataAccessScope"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataAccessScopesResponse, DataAccessScope> ListDataAccessScopes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataAccessScopesRequest request = new ListDataAccessScopesRequest
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
            return ListDataAccessScopes(request, callSettings);
        }

        /// <summary>
        /// Lists all existing data access scopes for the customer.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this data access scope will be created.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataAccessScope"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataAccessScopesResponse, DataAccessScope> ListDataAccessScopesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataAccessScopesRequest request = new ListDataAccessScopesRequest
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
            return ListDataAccessScopesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all existing data access scopes for the customer.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this data access scope will be created.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
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
        /// <returns>A pageable sequence of <see cref="DataAccessScope"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataAccessScopesResponse, DataAccessScope> ListDataAccessScopes(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataAccessScopesRequest request = new ListDataAccessScopesRequest
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
            return ListDataAccessScopes(request, callSettings);
        }

        /// <summary>
        /// Lists all existing data access scopes for the customer.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this data access scope will be created.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataAccessScope"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataAccessScopesResponse, DataAccessScope> ListDataAccessScopesAsync(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataAccessScopesRequest request = new ListDataAccessScopesRequest
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
            return ListDataAccessScopesAsync(request, callSettings);
        }

        /// <summary>
        /// Updates a data access scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataAccessScope UpdateDataAccessScope(UpdateDataAccessScopeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a data access scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAccessScope> UpdateDataAccessScopeAsync(UpdateDataAccessScopeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a data access scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAccessScope> UpdateDataAccessScopeAsync(UpdateDataAccessScopeRequest request, st::CancellationToken cancellationToken) =>
            UpdateDataAccessScopeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a data access scope.
        /// </summary>
        /// <param name="dataAccessScope">
        /// Required. The data access scope to update.
        /// 
        /// The scope's `name` field is used to identify the scope to update.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/dataAccessScopes/{data_access_scope}`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update. If not included, all fields with a non-empty
        /// value will be overwritten. Currently, only the description, the allowed
        /// and denied labels list fields are supported for update;
        /// an update call that attempts to update any
        /// other fields will return INVALID_ARGUMENT.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataAccessScope UpdateDataAccessScope(DataAccessScope dataAccessScope, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataAccessScope(new UpdateDataAccessScopeRequest
            {
                DataAccessScope = gax::GaxPreconditions.CheckNotNull(dataAccessScope, nameof(dataAccessScope)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a data access scope.
        /// </summary>
        /// <param name="dataAccessScope">
        /// Required. The data access scope to update.
        /// 
        /// The scope's `name` field is used to identify the scope to update.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/dataAccessScopes/{data_access_scope}`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update. If not included, all fields with a non-empty
        /// value will be overwritten. Currently, only the description, the allowed
        /// and denied labels list fields are supported for update;
        /// an update call that attempts to update any
        /// other fields will return INVALID_ARGUMENT.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAccessScope> UpdateDataAccessScopeAsync(DataAccessScope dataAccessScope, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataAccessScopeAsync(new UpdateDataAccessScopeRequest
            {
                DataAccessScope = gax::GaxPreconditions.CheckNotNull(dataAccessScope, nameof(dataAccessScope)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a data access scope.
        /// </summary>
        /// <param name="dataAccessScope">
        /// Required. The data access scope to update.
        /// 
        /// The scope's `name` field is used to identify the scope to update.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/dataAccessScopes/{data_access_scope}`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update. If not included, all fields with a non-empty
        /// value will be overwritten. Currently, only the description, the allowed
        /// and denied labels list fields are supported for update;
        /// an update call that attempts to update any
        /// other fields will return INVALID_ARGUMENT.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataAccessScope> UpdateDataAccessScopeAsync(DataAccessScope dataAccessScope, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDataAccessScopeAsync(dataAccessScope, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a data access scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDataAccessScope(DeleteDataAccessScopeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a data access scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataAccessScopeAsync(DeleteDataAccessScopeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a data access scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataAccessScopeAsync(DeleteDataAccessScopeRequest request, st::CancellationToken cancellationToken) =>
            DeleteDataAccessScopeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a data access scope.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the data access scope to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/dataAccessScopes/{data_access_scope}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDataAccessScope(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataAccessScope(new DeleteDataAccessScopeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a data access scope.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the data access scope to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/dataAccessScopes/{data_access_scope}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataAccessScopeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataAccessScopeAsync(new DeleteDataAccessScopeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a data access scope.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the data access scope to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/dataAccessScopes/{data_access_scope}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataAccessScopeAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDataAccessScopeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a data access scope.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the data access scope to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/dataAccessScopes/{data_access_scope}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDataAccessScope(DataAccessScopeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataAccessScope(new DeleteDataAccessScopeRequest
            {
                DataAccessScopeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a data access scope.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the data access scope to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/dataAccessScopes/{data_access_scope}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataAccessScopeAsync(DataAccessScopeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataAccessScopeAsync(new DeleteDataAccessScopeRequest
            {
                DataAccessScopeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a data access scope.
        /// </summary>
        /// <param name="name">
        /// Required. The ID of the data access scope to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/dataAccessScopes/{data_access_scope}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataAccessScopeAsync(DataAccessScopeName name, st::CancellationToken cancellationToken) =>
            DeleteDataAccessScopeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DataAccessControlService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// DataAccessControlService exposes resources and endpoints related to data
    /// access control.
    /// </remarks>
    public sealed partial class DataAccessControlServiceClientImpl : DataAccessControlServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateDataAccessLabelRequest, DataAccessLabel> _callCreateDataAccessLabel;

        private readonly gaxgrpc::ApiCall<GetDataAccessLabelRequest, DataAccessLabel> _callGetDataAccessLabel;

        private readonly gaxgrpc::ApiCall<ListDataAccessLabelsRequest, ListDataAccessLabelsResponse> _callListDataAccessLabels;

        private readonly gaxgrpc::ApiCall<UpdateDataAccessLabelRequest, DataAccessLabel> _callUpdateDataAccessLabel;

        private readonly gaxgrpc::ApiCall<DeleteDataAccessLabelRequest, wkt::Empty> _callDeleteDataAccessLabel;

        private readonly gaxgrpc::ApiCall<CreateDataAccessScopeRequest, DataAccessScope> _callCreateDataAccessScope;

        private readonly gaxgrpc::ApiCall<GetDataAccessScopeRequest, DataAccessScope> _callGetDataAccessScope;

        private readonly gaxgrpc::ApiCall<ListDataAccessScopesRequest, ListDataAccessScopesResponse> _callListDataAccessScopes;

        private readonly gaxgrpc::ApiCall<UpdateDataAccessScopeRequest, DataAccessScope> _callUpdateDataAccessScope;

        private readonly gaxgrpc::ApiCall<DeleteDataAccessScopeRequest, wkt::Empty> _callDeleteDataAccessScope;

        /// <summary>
        /// Constructs a client wrapper for the DataAccessControlService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="DataAccessControlServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DataAccessControlServiceClientImpl(DataAccessControlService.DataAccessControlServiceClient grpcClient, DataAccessControlServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DataAccessControlServiceSettings effectiveSettings = settings ?? DataAccessControlServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCreateDataAccessLabel = clientHelper.BuildApiCall<CreateDataAccessLabelRequest, DataAccessLabel>("CreateDataAccessLabel", grpcClient.CreateDataAccessLabelAsync, grpcClient.CreateDataAccessLabel, effectiveSettings.CreateDataAccessLabelSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDataAccessLabel);
            Modify_CreateDataAccessLabelApiCall(ref _callCreateDataAccessLabel);
            _callGetDataAccessLabel = clientHelper.BuildApiCall<GetDataAccessLabelRequest, DataAccessLabel>("GetDataAccessLabel", grpcClient.GetDataAccessLabelAsync, grpcClient.GetDataAccessLabel, effectiveSettings.GetDataAccessLabelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDataAccessLabel);
            Modify_GetDataAccessLabelApiCall(ref _callGetDataAccessLabel);
            _callListDataAccessLabels = clientHelper.BuildApiCall<ListDataAccessLabelsRequest, ListDataAccessLabelsResponse>("ListDataAccessLabels", grpcClient.ListDataAccessLabelsAsync, grpcClient.ListDataAccessLabels, effectiveSettings.ListDataAccessLabelsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDataAccessLabels);
            Modify_ListDataAccessLabelsApiCall(ref _callListDataAccessLabels);
            _callUpdateDataAccessLabel = clientHelper.BuildApiCall<UpdateDataAccessLabelRequest, DataAccessLabel>("UpdateDataAccessLabel", grpcClient.UpdateDataAccessLabelAsync, grpcClient.UpdateDataAccessLabel, effectiveSettings.UpdateDataAccessLabelSettings).WithGoogleRequestParam("data_access_label.name", request => request.DataAccessLabel?.Name);
            Modify_ApiCall(ref _callUpdateDataAccessLabel);
            Modify_UpdateDataAccessLabelApiCall(ref _callUpdateDataAccessLabel);
            _callDeleteDataAccessLabel = clientHelper.BuildApiCall<DeleteDataAccessLabelRequest, wkt::Empty>("DeleteDataAccessLabel", grpcClient.DeleteDataAccessLabelAsync, grpcClient.DeleteDataAccessLabel, effectiveSettings.DeleteDataAccessLabelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDataAccessLabel);
            Modify_DeleteDataAccessLabelApiCall(ref _callDeleteDataAccessLabel);
            _callCreateDataAccessScope = clientHelper.BuildApiCall<CreateDataAccessScopeRequest, DataAccessScope>("CreateDataAccessScope", grpcClient.CreateDataAccessScopeAsync, grpcClient.CreateDataAccessScope, effectiveSettings.CreateDataAccessScopeSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDataAccessScope);
            Modify_CreateDataAccessScopeApiCall(ref _callCreateDataAccessScope);
            _callGetDataAccessScope = clientHelper.BuildApiCall<GetDataAccessScopeRequest, DataAccessScope>("GetDataAccessScope", grpcClient.GetDataAccessScopeAsync, grpcClient.GetDataAccessScope, effectiveSettings.GetDataAccessScopeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDataAccessScope);
            Modify_GetDataAccessScopeApiCall(ref _callGetDataAccessScope);
            _callListDataAccessScopes = clientHelper.BuildApiCall<ListDataAccessScopesRequest, ListDataAccessScopesResponse>("ListDataAccessScopes", grpcClient.ListDataAccessScopesAsync, grpcClient.ListDataAccessScopes, effectiveSettings.ListDataAccessScopesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDataAccessScopes);
            Modify_ListDataAccessScopesApiCall(ref _callListDataAccessScopes);
            _callUpdateDataAccessScope = clientHelper.BuildApiCall<UpdateDataAccessScopeRequest, DataAccessScope>("UpdateDataAccessScope", grpcClient.UpdateDataAccessScopeAsync, grpcClient.UpdateDataAccessScope, effectiveSettings.UpdateDataAccessScopeSettings).WithGoogleRequestParam("data_access_scope.name", request => request.DataAccessScope?.Name);
            Modify_ApiCall(ref _callUpdateDataAccessScope);
            Modify_UpdateDataAccessScopeApiCall(ref _callUpdateDataAccessScope);
            _callDeleteDataAccessScope = clientHelper.BuildApiCall<DeleteDataAccessScopeRequest, wkt::Empty>("DeleteDataAccessScope", grpcClient.DeleteDataAccessScopeAsync, grpcClient.DeleteDataAccessScope, effectiveSettings.DeleteDataAccessScopeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDataAccessScope);
            Modify_DeleteDataAccessScopeApiCall(ref _callDeleteDataAccessScope);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateDataAccessLabelApiCall(ref gaxgrpc::ApiCall<CreateDataAccessLabelRequest, DataAccessLabel> call);

        partial void Modify_GetDataAccessLabelApiCall(ref gaxgrpc::ApiCall<GetDataAccessLabelRequest, DataAccessLabel> call);

        partial void Modify_ListDataAccessLabelsApiCall(ref gaxgrpc::ApiCall<ListDataAccessLabelsRequest, ListDataAccessLabelsResponse> call);

        partial void Modify_UpdateDataAccessLabelApiCall(ref gaxgrpc::ApiCall<UpdateDataAccessLabelRequest, DataAccessLabel> call);

        partial void Modify_DeleteDataAccessLabelApiCall(ref gaxgrpc::ApiCall<DeleteDataAccessLabelRequest, wkt::Empty> call);

        partial void Modify_CreateDataAccessScopeApiCall(ref gaxgrpc::ApiCall<CreateDataAccessScopeRequest, DataAccessScope> call);

        partial void Modify_GetDataAccessScopeApiCall(ref gaxgrpc::ApiCall<GetDataAccessScopeRequest, DataAccessScope> call);

        partial void Modify_ListDataAccessScopesApiCall(ref gaxgrpc::ApiCall<ListDataAccessScopesRequest, ListDataAccessScopesResponse> call);

        partial void Modify_UpdateDataAccessScopeApiCall(ref gaxgrpc::ApiCall<UpdateDataAccessScopeRequest, DataAccessScope> call);

        partial void Modify_DeleteDataAccessScopeApiCall(ref gaxgrpc::ApiCall<DeleteDataAccessScopeRequest, wkt::Empty> call);

        partial void OnConstruction(DataAccessControlService.DataAccessControlServiceClient grpcClient, DataAccessControlServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DataAccessControlService client</summary>
        public override DataAccessControlService.DataAccessControlServiceClient GrpcClient { get; }

        partial void Modify_CreateDataAccessLabelRequest(ref CreateDataAccessLabelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDataAccessLabelRequest(ref GetDataAccessLabelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDataAccessLabelsRequest(ref ListDataAccessLabelsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDataAccessLabelRequest(ref UpdateDataAccessLabelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDataAccessLabelRequest(ref DeleteDataAccessLabelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateDataAccessScopeRequest(ref CreateDataAccessScopeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDataAccessScopeRequest(ref GetDataAccessScopeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDataAccessScopesRequest(ref ListDataAccessScopesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDataAccessScopeRequest(ref UpdateDataAccessScopeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDataAccessScopeRequest(ref DeleteDataAccessScopeRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a data access label.
        /// Data access labels are applied to incoming event data and selected in data
        /// access scopes (another resource), and only users with scopes containing the
        /// label can see data with that label. Currently, the data access label
        /// resource only includes custom labels, which are labels that correspond
        /// to UDM queries over event data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataAccessLabel CreateDataAccessLabel(CreateDataAccessLabelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataAccessLabelRequest(ref request, ref callSettings);
            return _callCreateDataAccessLabel.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a data access label.
        /// Data access labels are applied to incoming event data and selected in data
        /// access scopes (another resource), and only users with scopes containing the
        /// label can see data with that label. Currently, the data access label
        /// resource only includes custom labels, which are labels that correspond
        /// to UDM queries over event data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataAccessLabel> CreateDataAccessLabelAsync(CreateDataAccessLabelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataAccessLabelRequest(ref request, ref callSettings);
            return _callCreateDataAccessLabel.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a data access label.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataAccessLabel GetDataAccessLabel(GetDataAccessLabelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataAccessLabelRequest(ref request, ref callSettings);
            return _callGetDataAccessLabel.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a data access label.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataAccessLabel> GetDataAccessLabelAsync(GetDataAccessLabelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataAccessLabelRequest(ref request, ref callSettings);
            return _callGetDataAccessLabel.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all data access labels for the customer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataAccessLabel"/> resources.</returns>
        public override gax::PagedEnumerable<ListDataAccessLabelsResponse, DataAccessLabel> ListDataAccessLabels(ListDataAccessLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataAccessLabelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDataAccessLabelsRequest, ListDataAccessLabelsResponse, DataAccessLabel>(_callListDataAccessLabels, request, callSettings);
        }

        /// <summary>
        /// Lists all data access labels for the customer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataAccessLabel"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDataAccessLabelsResponse, DataAccessLabel> ListDataAccessLabelsAsync(ListDataAccessLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataAccessLabelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDataAccessLabelsRequest, ListDataAccessLabelsResponse, DataAccessLabel>(_callListDataAccessLabels, request, callSettings);
        }

        /// <summary>
        /// Updates a data access label.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataAccessLabel UpdateDataAccessLabel(UpdateDataAccessLabelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataAccessLabelRequest(ref request, ref callSettings);
            return _callUpdateDataAccessLabel.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a data access label.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataAccessLabel> UpdateDataAccessLabelAsync(UpdateDataAccessLabelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataAccessLabelRequest(ref request, ref callSettings);
            return _callUpdateDataAccessLabel.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a data access label. When a label is deleted, new
        /// data that enters in the system will not receive the label, but the label
        /// will not be removed from old data that still refers to it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteDataAccessLabel(DeleteDataAccessLabelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDataAccessLabelRequest(ref request, ref callSettings);
            _callDeleteDataAccessLabel.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a data access label. When a label is deleted, new
        /// data that enters in the system will not receive the label, but the label
        /// will not be removed from old data that still refers to it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteDataAccessLabelAsync(DeleteDataAccessLabelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDataAccessLabelRequest(ref request, ref callSettings);
            return _callDeleteDataAccessLabel.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a data access scope.
        /// Data access scope is a combination of allowed and denied labels attached
        /// to a permission group. If a scope has allowed labels A and B and denied
        /// labels C and D, then the group of people attached to the scope
        /// will have permissions to see all events labeled with A or B (or both) and
        /// not labeled with either C or D.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataAccessScope CreateDataAccessScope(CreateDataAccessScopeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataAccessScopeRequest(ref request, ref callSettings);
            return _callCreateDataAccessScope.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a data access scope.
        /// Data access scope is a combination of allowed and denied labels attached
        /// to a permission group. If a scope has allowed labels A and B and denied
        /// labels C and D, then the group of people attached to the scope
        /// will have permissions to see all events labeled with A or B (or both) and
        /// not labeled with either C or D.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataAccessScope> CreateDataAccessScopeAsync(CreateDataAccessScopeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataAccessScopeRequest(ref request, ref callSettings);
            return _callCreateDataAccessScope.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves an existing data access scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataAccessScope GetDataAccessScope(GetDataAccessScopeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataAccessScopeRequest(ref request, ref callSettings);
            return _callGetDataAccessScope.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves an existing data access scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataAccessScope> GetDataAccessScopeAsync(GetDataAccessScopeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataAccessScopeRequest(ref request, ref callSettings);
            return _callGetDataAccessScope.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all existing data access scopes for the customer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataAccessScope"/> resources.</returns>
        public override gax::PagedEnumerable<ListDataAccessScopesResponse, DataAccessScope> ListDataAccessScopes(ListDataAccessScopesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataAccessScopesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDataAccessScopesRequest, ListDataAccessScopesResponse, DataAccessScope>(_callListDataAccessScopes, request, callSettings);
        }

        /// <summary>
        /// Lists all existing data access scopes for the customer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataAccessScope"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDataAccessScopesResponse, DataAccessScope> ListDataAccessScopesAsync(ListDataAccessScopesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataAccessScopesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDataAccessScopesRequest, ListDataAccessScopesResponse, DataAccessScope>(_callListDataAccessScopes, request, callSettings);
        }

        /// <summary>
        /// Updates a data access scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataAccessScope UpdateDataAccessScope(UpdateDataAccessScopeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataAccessScopeRequest(ref request, ref callSettings);
            return _callUpdateDataAccessScope.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a data access scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataAccessScope> UpdateDataAccessScopeAsync(UpdateDataAccessScopeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataAccessScopeRequest(ref request, ref callSettings);
            return _callUpdateDataAccessScope.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a data access scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteDataAccessScope(DeleteDataAccessScopeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDataAccessScopeRequest(ref request, ref callSettings);
            _callDeleteDataAccessScope.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a data access scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteDataAccessScopeAsync(DeleteDataAccessScopeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDataAccessScopeRequest(ref request, ref callSettings);
            return _callDeleteDataAccessScope.Async(request, callSettings);
        }
    }

    public partial class ListDataAccessLabelsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDataAccessScopesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDataAccessLabelsResponse : gaxgrpc::IPageResponse<DataAccessLabel>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DataAccessLabel> GetEnumerator() => DataAccessLabels.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDataAccessScopesResponse : gaxgrpc::IPageResponse<DataAccessScope>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DataAccessScope> GetEnumerator() => DataAccessScopes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
