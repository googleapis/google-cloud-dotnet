// Copyright 2024 Google LLC
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

namespace Google.Cloud.BigQuery.DataPolicies.V1
{
    /// <summary>Settings for <see cref="DataPolicyServiceClient"/> instances.</summary>
    public sealed partial class DataPolicyServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DataPolicyServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DataPolicyServiceSettings"/>.</returns>
        public static DataPolicyServiceSettings GetDefault() => new DataPolicyServiceSettings();

        /// <summary>Constructs a new <see cref="DataPolicyServiceSettings"/> object with default settings.</summary>
        public DataPolicyServiceSettings()
        {
        }

        private DataPolicyServiceSettings(DataPolicyServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateDataPolicySettings = existing.CreateDataPolicySettings;
            UpdateDataPolicySettings = existing.UpdateDataPolicySettings;
            RenameDataPolicySettings = existing.RenameDataPolicySettings;
            DeleteDataPolicySettings = existing.DeleteDataPolicySettings;
            GetDataPolicySettings = existing.GetDataPolicySettings;
            ListDataPoliciesSettings = existing.ListDataPoliciesSettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DataPolicyServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataPolicyServiceClient.CreateDataPolicy</c> and <c>DataPolicyServiceClient.CreateDataPolicyAsync</c>.
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
        public gaxgrpc::CallSettings CreateDataPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataPolicyServiceClient.UpdateDataPolicy</c> and <c>DataPolicyServiceClient.UpdateDataPolicyAsync</c>.
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
        public gaxgrpc::CallSettings UpdateDataPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataPolicyServiceClient.RenameDataPolicy</c> and <c>DataPolicyServiceClient.RenameDataPolicyAsync</c>.
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
        public gaxgrpc::CallSettings RenameDataPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataPolicyServiceClient.DeleteDataPolicy</c> and <c>DataPolicyServiceClient.DeleteDataPolicyAsync</c>.
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
        public gaxgrpc::CallSettings DeleteDataPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataPolicyServiceClient.GetDataPolicy</c> and <c>DataPolicyServiceClient.GetDataPolicyAsync</c>.
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
        public gaxgrpc::CallSettings GetDataPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataPolicyServiceClient.ListDataPolicies</c> and <c>DataPolicyServiceClient.ListDataPoliciesAsync</c>.
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
        public gaxgrpc::CallSettings ListDataPoliciesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataPolicyServiceClient.GetIamPolicy</c> and <c>DataPolicyServiceClient.GetIamPolicyAsync</c>.
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
        /// <c>DataPolicyServiceClient.SetIamPolicy</c> and <c>DataPolicyServiceClient.SetIamPolicyAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataPolicyServiceClient.TestIamPermissions</c> and <c>DataPolicyServiceClient.TestIamPermissionsAsync</c>
        /// .
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
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DataPolicyServiceSettings"/> object.</returns>
        public DataPolicyServiceSettings Clone() => new DataPolicyServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DataPolicyServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class DataPolicyServiceClientBuilder : gaxgrpc::ClientBuilderBase<DataPolicyServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DataPolicyServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DataPolicyServiceClientBuilder() : base(DataPolicyServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DataPolicyServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DataPolicyServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DataPolicyServiceClient Build()
        {
            DataPolicyServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DataPolicyServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DataPolicyServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DataPolicyServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DataPolicyServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DataPolicyServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DataPolicyServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DataPolicyServiceClient.ChannelPool;
    }

    /// <summary>DataPolicyService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Data Policy Service provides APIs for managing the label-policy bindings.
    /// </remarks>
    public abstract partial class DataPolicyServiceClient
    {
        /// <summary>
        /// The default endpoint for the DataPolicyService service, which is a host of
        /// "bigquerydatapolicy.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "bigquerydatapolicy.googleapis.com:443";

        /// <summary>The default DataPolicyService scopes.</summary>
        /// <remarks>
        /// The default DataPolicyService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/bigquery</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/bigquery",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DataPolicyService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DataPolicyServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DataPolicyServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DataPolicyServiceClient"/>.</returns>
        public static stt::Task<DataPolicyServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DataPolicyServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DataPolicyServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DataPolicyServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DataPolicyServiceClient"/>.</returns>
        public static DataPolicyServiceClient Create() => new DataPolicyServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DataPolicyServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DataPolicyServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DataPolicyServiceClient"/>.</returns>
        internal static DataPolicyServiceClient Create(grpccore::CallInvoker callInvoker, DataPolicyServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DataPolicyService.DataPolicyServiceClient grpcClient = new DataPolicyService.DataPolicyServiceClient(callInvoker);
            return new DataPolicyServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DataPolicyService client</summary>
        public virtual DataPolicyService.DataPolicyServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new data policy under a project with the given `dataPolicyId`
        /// (used as the display name), policy tag, and data policy type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataPolicy CreateDataPolicy(CreateDataPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new data policy under a project with the given `dataPolicyId`
        /// (used as the display name), policy tag, and data policy type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataPolicy> CreateDataPolicyAsync(CreateDataPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new data policy under a project with the given `dataPolicyId`
        /// (used as the display name), policy tag, and data policy type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataPolicy> CreateDataPolicyAsync(CreateDataPolicyRequest request, st::CancellationToken cancellationToken) =>
            CreateDataPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new data policy under a project with the given `dataPolicyId`
        /// (used as the display name), policy tag, and data policy type.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the project that the data policy will belong to.
        /// The format is `projects/{project_number}/locations/{location_id}`.
        /// </param>
        /// <param name="dataPolicy">
        /// Required. The data policy to create. The `name` field does not need to be
        /// provided for the data policy creation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataPolicy CreateDataPolicy(string parent, DataPolicy dataPolicy, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataPolicy(new CreateDataPolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DataPolicy = gax::GaxPreconditions.CheckNotNull(dataPolicy, nameof(dataPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new data policy under a project with the given `dataPolicyId`
        /// (used as the display name), policy tag, and data policy type.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the project that the data policy will belong to.
        /// The format is `projects/{project_number}/locations/{location_id}`.
        /// </param>
        /// <param name="dataPolicy">
        /// Required. The data policy to create. The `name` field does not need to be
        /// provided for the data policy creation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataPolicy> CreateDataPolicyAsync(string parent, DataPolicy dataPolicy, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataPolicyAsync(new CreateDataPolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DataPolicy = gax::GaxPreconditions.CheckNotNull(dataPolicy, nameof(dataPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new data policy under a project with the given `dataPolicyId`
        /// (used as the display name), policy tag, and data policy type.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the project that the data policy will belong to.
        /// The format is `projects/{project_number}/locations/{location_id}`.
        /// </param>
        /// <param name="dataPolicy">
        /// Required. The data policy to create. The `name` field does not need to be
        /// provided for the data policy creation.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataPolicy> CreateDataPolicyAsync(string parent, DataPolicy dataPolicy, st::CancellationToken cancellationToken) =>
            CreateDataPolicyAsync(parent, dataPolicy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new data policy under a project with the given `dataPolicyId`
        /// (used as the display name), policy tag, and data policy type.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the project that the data policy will belong to.
        /// The format is `projects/{project_number}/locations/{location_id}`.
        /// </param>
        /// <param name="dataPolicy">
        /// Required. The data policy to create. The `name` field does not need to be
        /// provided for the data policy creation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataPolicy CreateDataPolicy(gagr::LocationName parent, DataPolicy dataPolicy, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataPolicy(new CreateDataPolicyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DataPolicy = gax::GaxPreconditions.CheckNotNull(dataPolicy, nameof(dataPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new data policy under a project with the given `dataPolicyId`
        /// (used as the display name), policy tag, and data policy type.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the project that the data policy will belong to.
        /// The format is `projects/{project_number}/locations/{location_id}`.
        /// </param>
        /// <param name="dataPolicy">
        /// Required. The data policy to create. The `name` field does not need to be
        /// provided for the data policy creation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataPolicy> CreateDataPolicyAsync(gagr::LocationName parent, DataPolicy dataPolicy, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataPolicyAsync(new CreateDataPolicyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DataPolicy = gax::GaxPreconditions.CheckNotNull(dataPolicy, nameof(dataPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new data policy under a project with the given `dataPolicyId`
        /// (used as the display name), policy tag, and data policy type.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the project that the data policy will belong to.
        /// The format is `projects/{project_number}/locations/{location_id}`.
        /// </param>
        /// <param name="dataPolicy">
        /// Required. The data policy to create. The `name` field does not need to be
        /// provided for the data policy creation.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataPolicy> CreateDataPolicyAsync(gagr::LocationName parent, DataPolicy dataPolicy, st::CancellationToken cancellationToken) =>
            CreateDataPolicyAsync(parent, dataPolicy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the metadata for an existing data policy. The target data policy
        /// can be specified by the resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataPolicy UpdateDataPolicy(UpdateDataPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the metadata for an existing data policy. The target data policy
        /// can be specified by the resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataPolicy> UpdateDataPolicyAsync(UpdateDataPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the metadata for an existing data policy. The target data policy
        /// can be specified by the resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataPolicy> UpdateDataPolicyAsync(UpdateDataPolicyRequest request, st::CancellationToken cancellationToken) =>
            UpdateDataPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the metadata for an existing data policy. The target data policy
        /// can be specified by the resource name.
        /// </summary>
        /// <param name="dataPolicy">
        /// Required. Update the data policy's metadata.
        /// 
        /// The target data policy is determined by the `name` field.
        /// Other fields are updated to the specified values based on the field masks.
        /// </param>
        /// <param name="updateMask">
        /// The update mask applies to the resource. For the `FieldMask` definition,
        /// see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
        /// If not set, defaults to all of the fields that are allowed to update.
        /// 
        /// Updates to the `name` and `dataPolicyId` fields are not allowed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataPolicy UpdateDataPolicy(DataPolicy dataPolicy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataPolicy(new UpdateDataPolicyRequest
            {
                DataPolicy = gax::GaxPreconditions.CheckNotNull(dataPolicy, nameof(dataPolicy)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the metadata for an existing data policy. The target data policy
        /// can be specified by the resource name.
        /// </summary>
        /// <param name="dataPolicy">
        /// Required. Update the data policy's metadata.
        /// 
        /// The target data policy is determined by the `name` field.
        /// Other fields are updated to the specified values based on the field masks.
        /// </param>
        /// <param name="updateMask">
        /// The update mask applies to the resource. For the `FieldMask` definition,
        /// see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
        /// If not set, defaults to all of the fields that are allowed to update.
        /// 
        /// Updates to the `name` and `dataPolicyId` fields are not allowed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataPolicy> UpdateDataPolicyAsync(DataPolicy dataPolicy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataPolicyAsync(new UpdateDataPolicyRequest
            {
                DataPolicy = gax::GaxPreconditions.CheckNotNull(dataPolicy, nameof(dataPolicy)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the metadata for an existing data policy. The target data policy
        /// can be specified by the resource name.
        /// </summary>
        /// <param name="dataPolicy">
        /// Required. Update the data policy's metadata.
        /// 
        /// The target data policy is determined by the `name` field.
        /// Other fields are updated to the specified values based on the field masks.
        /// </param>
        /// <param name="updateMask">
        /// The update mask applies to the resource. For the `FieldMask` definition,
        /// see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
        /// If not set, defaults to all of the fields that are allowed to update.
        /// 
        /// Updates to the `name` and `dataPolicyId` fields are not allowed.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataPolicy> UpdateDataPolicyAsync(DataPolicy dataPolicy, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDataPolicyAsync(dataPolicy, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Renames the id (display name) of the specified data policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataPolicy RenameDataPolicy(RenameDataPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Renames the id (display name) of the specified data policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataPolicy> RenameDataPolicyAsync(RenameDataPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Renames the id (display name) of the specified data policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataPolicy> RenameDataPolicyAsync(RenameDataPolicyRequest request, st::CancellationToken cancellationToken) =>
            RenameDataPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Renames the id (display name) of the specified data policy.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the data policy to rename. The format is
        /// `projects/{project_number}/locations/{location_id}/dataPolicies/{data_policy_id}`
        /// </param>
        /// <param name="newDataPolicyId">
        /// Required. The new data policy id.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataPolicy RenameDataPolicy(string name, string newDataPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            RenameDataPolicy(new RenameDataPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                NewDataPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(newDataPolicyId, nameof(newDataPolicyId)),
            }, callSettings);

        /// <summary>
        /// Renames the id (display name) of the specified data policy.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the data policy to rename. The format is
        /// `projects/{project_number}/locations/{location_id}/dataPolicies/{data_policy_id}`
        /// </param>
        /// <param name="newDataPolicyId">
        /// Required. The new data policy id.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataPolicy> RenameDataPolicyAsync(string name, string newDataPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            RenameDataPolicyAsync(new RenameDataPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                NewDataPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(newDataPolicyId, nameof(newDataPolicyId)),
            }, callSettings);

        /// <summary>
        /// Renames the id (display name) of the specified data policy.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the data policy to rename. The format is
        /// `projects/{project_number}/locations/{location_id}/dataPolicies/{data_policy_id}`
        /// </param>
        /// <param name="newDataPolicyId">
        /// Required. The new data policy id.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataPolicy> RenameDataPolicyAsync(string name, string newDataPolicyId, st::CancellationToken cancellationToken) =>
            RenameDataPolicyAsync(name, newDataPolicyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the data policy specified by its resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDataPolicy(DeleteDataPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the data policy specified by its resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataPolicyAsync(DeleteDataPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the data policy specified by its resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataPolicyAsync(DeleteDataPolicyRequest request, st::CancellationToken cancellationToken) =>
            DeleteDataPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the data policy specified by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the data policy to delete. Format is
        /// `projects/{project_number}/locations/{location_id}/dataPolicies/{data_policy_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDataPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataPolicy(new DeleteDataPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the data policy specified by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the data policy to delete. Format is
        /// `projects/{project_number}/locations/{location_id}/dataPolicies/{data_policy_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataPolicyAsync(new DeleteDataPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the data policy specified by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the data policy to delete. Format is
        /// `projects/{project_number}/locations/{location_id}/dataPolicies/{data_policy_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDataPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the data policy specified by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the data policy to delete. Format is
        /// `projects/{project_number}/locations/{location_id}/dataPolicies/{data_policy_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDataPolicy(DataPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataPolicy(new DeleteDataPolicyRequest
            {
                DataPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the data policy specified by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the data policy to delete. Format is
        /// `projects/{project_number}/locations/{location_id}/dataPolicies/{data_policy_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataPolicyAsync(DataPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataPolicyAsync(new DeleteDataPolicyRequest
            {
                DataPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the data policy specified by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the data policy to delete. Format is
        /// `projects/{project_number}/locations/{location_id}/dataPolicies/{data_policy_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDataPolicyAsync(DataPolicyName name, st::CancellationToken cancellationToken) =>
            DeleteDataPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the data policy specified by its resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataPolicy GetDataPolicy(GetDataPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the data policy specified by its resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataPolicy> GetDataPolicyAsync(GetDataPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the data policy specified by its resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataPolicy> GetDataPolicyAsync(GetDataPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetDataPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the data policy specified by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the requested data policy. Format is
        /// `projects/{project_number}/locations/{location_id}/dataPolicies/{data_policy_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataPolicy GetDataPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataPolicy(new GetDataPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the data policy specified by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the requested data policy. Format is
        /// `projects/{project_number}/locations/{location_id}/dataPolicies/{data_policy_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataPolicy> GetDataPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataPolicyAsync(new GetDataPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the data policy specified by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the requested data policy. Format is
        /// `projects/{project_number}/locations/{location_id}/dataPolicies/{data_policy_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataPolicy> GetDataPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            GetDataPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the data policy specified by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the requested data policy. Format is
        /// `projects/{project_number}/locations/{location_id}/dataPolicies/{data_policy_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataPolicy GetDataPolicy(DataPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataPolicy(new GetDataPolicyRequest
            {
                DataPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the data policy specified by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the requested data policy. Format is
        /// `projects/{project_number}/locations/{location_id}/dataPolicies/{data_policy_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataPolicy> GetDataPolicyAsync(DataPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataPolicyAsync(new GetDataPolicyRequest
            {
                DataPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the data policy specified by its resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the requested data policy. Format is
        /// `projects/{project_number}/locations/{location_id}/dataPolicies/{data_policy_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataPolicy> GetDataPolicyAsync(DataPolicyName name, st::CancellationToken cancellationToken) =>
            GetDataPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List all of the data policies in the specified parent project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataPoliciesResponse, DataPolicy> ListDataPolicies(ListDataPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all of the data policies in the specified parent project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataPoliciesResponse, DataPolicy> ListDataPoliciesAsync(ListDataPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all of the data policies in the specified parent project.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the project for which to list data policies.
        /// Format is `projects/{project_number}/locations/{location_id}`.
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
        /// <returns>A pageable sequence of <see cref="DataPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataPoliciesResponse, DataPolicy> ListDataPolicies(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataPoliciesRequest request = new ListDataPoliciesRequest
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
            return ListDataPolicies(request, callSettings);
        }

        /// <summary>
        /// List all of the data policies in the specified parent project.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the project for which to list data policies.
        /// Format is `projects/{project_number}/locations/{location_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataPoliciesResponse, DataPolicy> ListDataPoliciesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataPoliciesRequest request = new ListDataPoliciesRequest
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
            return ListDataPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// List all of the data policies in the specified parent project.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the project for which to list data policies.
        /// Format is `projects/{project_number}/locations/{location_id}`.
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
        /// <returns>A pageable sequence of <see cref="DataPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataPoliciesResponse, DataPolicy> ListDataPolicies(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataPoliciesRequest request = new ListDataPoliciesRequest
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
            return ListDataPolicies(request, callSettings);
        }

        /// <summary>
        /// List all of the data policies in the specified parent project.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the project for which to list data policies.
        /// Format is `projects/{project_number}/locations/{location_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataPoliciesResponse, DataPolicy> ListDataPoliciesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDataPoliciesRequest request = new ListDataPoliciesRequest
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
            return ListDataPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the IAM policy for the specified data policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the IAM policy for the specified data policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the IAM policy for the specified data policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the IAM policy for the specified data policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the IAM policy for the specified data policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the IAM policy for the specified data policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the caller's permission on the specified data policy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the caller's permission on the specified data policy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the caller's permission on the specified data policy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DataPolicyService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Data Policy Service provides APIs for managing the label-policy bindings.
    /// </remarks>
    public sealed partial class DataPolicyServiceClientImpl : DataPolicyServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateDataPolicyRequest, DataPolicy> _callCreateDataPolicy;

        private readonly gaxgrpc::ApiCall<UpdateDataPolicyRequest, DataPolicy> _callUpdateDataPolicy;

        private readonly gaxgrpc::ApiCall<RenameDataPolicyRequest, DataPolicy> _callRenameDataPolicy;

        private readonly gaxgrpc::ApiCall<DeleteDataPolicyRequest, wkt::Empty> _callDeleteDataPolicy;

        private readonly gaxgrpc::ApiCall<GetDataPolicyRequest, DataPolicy> _callGetDataPolicy;

        private readonly gaxgrpc::ApiCall<ListDataPoliciesRequest, ListDataPoliciesResponse> _callListDataPolicies;

        private readonly gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> _callGetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> _callSetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> _callTestIamPermissions;

        /// <summary>
        /// Constructs a client wrapper for the DataPolicyService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DataPolicyServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DataPolicyServiceClientImpl(DataPolicyService.DataPolicyServiceClient grpcClient, DataPolicyServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DataPolicyServiceSettings effectiveSettings = settings ?? DataPolicyServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCreateDataPolicy = clientHelper.BuildApiCall<CreateDataPolicyRequest, DataPolicy>("CreateDataPolicy", grpcClient.CreateDataPolicyAsync, grpcClient.CreateDataPolicy, effectiveSettings.CreateDataPolicySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDataPolicy);
            Modify_CreateDataPolicyApiCall(ref _callCreateDataPolicy);
            _callUpdateDataPolicy = clientHelper.BuildApiCall<UpdateDataPolicyRequest, DataPolicy>("UpdateDataPolicy", grpcClient.UpdateDataPolicyAsync, grpcClient.UpdateDataPolicy, effectiveSettings.UpdateDataPolicySettings).WithGoogleRequestParam("data_policy.name", request => request.DataPolicy?.Name);
            Modify_ApiCall(ref _callUpdateDataPolicy);
            Modify_UpdateDataPolicyApiCall(ref _callUpdateDataPolicy);
            _callRenameDataPolicy = clientHelper.BuildApiCall<RenameDataPolicyRequest, DataPolicy>("RenameDataPolicy", grpcClient.RenameDataPolicyAsync, grpcClient.RenameDataPolicy, effectiveSettings.RenameDataPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRenameDataPolicy);
            Modify_RenameDataPolicyApiCall(ref _callRenameDataPolicy);
            _callDeleteDataPolicy = clientHelper.BuildApiCall<DeleteDataPolicyRequest, wkt::Empty>("DeleteDataPolicy", grpcClient.DeleteDataPolicyAsync, grpcClient.DeleteDataPolicy, effectiveSettings.DeleteDataPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDataPolicy);
            Modify_DeleteDataPolicyApiCall(ref _callDeleteDataPolicy);
            _callGetDataPolicy = clientHelper.BuildApiCall<GetDataPolicyRequest, DataPolicy>("GetDataPolicy", grpcClient.GetDataPolicyAsync, grpcClient.GetDataPolicy, effectiveSettings.GetDataPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDataPolicy);
            Modify_GetDataPolicyApiCall(ref _callGetDataPolicy);
            _callListDataPolicies = clientHelper.BuildApiCall<ListDataPoliciesRequest, ListDataPoliciesResponse>("ListDataPolicies", grpcClient.ListDataPoliciesAsync, grpcClient.ListDataPolicies, effectiveSettings.ListDataPoliciesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDataPolicies);
            Modify_ListDataPoliciesApiCall(ref _callListDataPolicies);
            _callGetIamPolicy = clientHelper.BuildApiCall<gciv::GetIamPolicyRequest, gciv::Policy>("GetIamPolicy", grpcClient.GetIamPolicyAsync, grpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            _callSetIamPolicy = clientHelper.BuildApiCall<gciv::SetIamPolicyRequest, gciv::Policy>("SetIamPolicy", grpcClient.SetIamPolicyAsync, grpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            _callTestIamPermissions = clientHelper.BuildApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse>("TestIamPermissions", grpcClient.TestIamPermissionsAsync, grpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateDataPolicyApiCall(ref gaxgrpc::ApiCall<CreateDataPolicyRequest, DataPolicy> call);

        partial void Modify_UpdateDataPolicyApiCall(ref gaxgrpc::ApiCall<UpdateDataPolicyRequest, DataPolicy> call);

        partial void Modify_RenameDataPolicyApiCall(ref gaxgrpc::ApiCall<RenameDataPolicyRequest, DataPolicy> call);

        partial void Modify_DeleteDataPolicyApiCall(ref gaxgrpc::ApiCall<DeleteDataPolicyRequest, wkt::Empty> call);

        partial void Modify_GetDataPolicyApiCall(ref gaxgrpc::ApiCall<GetDataPolicyRequest, DataPolicy> call);

        partial void Modify_ListDataPoliciesApiCall(ref gaxgrpc::ApiCall<ListDataPoliciesRequest, ListDataPoliciesResponse> call);

        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> call);

        partial void OnConstruction(DataPolicyService.DataPolicyServiceClient grpcClient, DataPolicyServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DataPolicyService client</summary>
        public override DataPolicyService.DataPolicyServiceClient GrpcClient { get; }

        partial void Modify_CreateDataPolicyRequest(ref CreateDataPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDataPolicyRequest(ref UpdateDataPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RenameDataPolicyRequest(ref RenameDataPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDataPolicyRequest(ref DeleteDataPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDataPolicyRequest(ref GetDataPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDataPoliciesRequest(ref ListDataPoliciesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIamPolicyRequest(ref gciv::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetIamPolicyRequest(ref gciv::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsRequest(ref gciv::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a new data policy under a project with the given `dataPolicyId`
        /// (used as the display name), policy tag, and data policy type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataPolicy CreateDataPolicy(CreateDataPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataPolicyRequest(ref request, ref callSettings);
            return _callCreateDataPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new data policy under a project with the given `dataPolicyId`
        /// (used as the display name), policy tag, and data policy type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataPolicy> CreateDataPolicyAsync(CreateDataPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataPolicyRequest(ref request, ref callSettings);
            return _callCreateDataPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the metadata for an existing data policy. The target data policy
        /// can be specified by the resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataPolicy UpdateDataPolicy(UpdateDataPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataPolicyRequest(ref request, ref callSettings);
            return _callUpdateDataPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the metadata for an existing data policy. The target data policy
        /// can be specified by the resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataPolicy> UpdateDataPolicyAsync(UpdateDataPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataPolicyRequest(ref request, ref callSettings);
            return _callUpdateDataPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Renames the id (display name) of the specified data policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataPolicy RenameDataPolicy(RenameDataPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RenameDataPolicyRequest(ref request, ref callSettings);
            return _callRenameDataPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Renames the id (display name) of the specified data policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataPolicy> RenameDataPolicyAsync(RenameDataPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RenameDataPolicyRequest(ref request, ref callSettings);
            return _callRenameDataPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the data policy specified by its resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteDataPolicy(DeleteDataPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDataPolicyRequest(ref request, ref callSettings);
            _callDeleteDataPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the data policy specified by its resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteDataPolicyAsync(DeleteDataPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDataPolicyRequest(ref request, ref callSettings);
            return _callDeleteDataPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the data policy specified by its resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataPolicy GetDataPolicy(GetDataPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataPolicyRequest(ref request, ref callSettings);
            return _callGetDataPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the data policy specified by its resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataPolicy> GetDataPolicyAsync(GetDataPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataPolicyRequest(ref request, ref callSettings);
            return _callGetDataPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// List all of the data policies in the specified parent project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataPolicy"/> resources.</returns>
        public override gax::PagedEnumerable<ListDataPoliciesResponse, DataPolicy> ListDataPolicies(ListDataPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDataPoliciesRequest, ListDataPoliciesResponse, DataPolicy>(_callListDataPolicies, request, callSettings);
        }

        /// <summary>
        /// List all of the data policies in the specified parent project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataPolicy"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDataPoliciesResponse, DataPolicy> ListDataPoliciesAsync(ListDataPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDataPoliciesRequest, ListDataPoliciesResponse, DataPolicy>(_callListDataPolicies, request, callSettings);
        }

        /// <summary>
        /// Gets the IAM policy for the specified data policy.
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
        /// Gets the IAM policy for the specified data policy.
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
        /// Sets the IAM policy for the specified data policy.
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
        /// Sets the IAM policy for the specified data policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the caller's permission on the specified data policy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the caller's permission on the specified data policy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }
    }

    public partial class ListDataPoliciesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDataPoliciesResponse : gaxgrpc::IPageResponse<DataPolicy>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DataPolicy> GetEnumerator() => DataPolicies.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
