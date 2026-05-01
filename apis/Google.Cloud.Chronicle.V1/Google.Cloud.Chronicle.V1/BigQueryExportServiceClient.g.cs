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
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Chronicle.V1
{
    /// <summary>Settings for <see cref="BigQueryExportServiceClient"/> instances.</summary>
    public sealed partial class BigQueryExportServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BigQueryExportServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BigQueryExportServiceSettings"/>.</returns>
        public static BigQueryExportServiceSettings GetDefault() => new BigQueryExportServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="BigQueryExportServiceSettings"/> object with default settings.
        /// </summary>
        public BigQueryExportServiceSettings()
        {
        }

        private BigQueryExportServiceSettings(BigQueryExportServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetBigQueryExportSettings = existing.GetBigQueryExportSettings;
            UpdateBigQueryExportSettings = existing.UpdateBigQueryExportSettings;
            ProvisionBigQueryExportSettings = existing.ProvisionBigQueryExportSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BigQueryExportServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigQueryExportServiceClient.GetBigQueryExport</c> and
        /// <c>BigQueryExportServiceClient.GetBigQueryExportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 120000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetBigQueryExportSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(120000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigQueryExportServiceClient.UpdateBigQueryExport</c> and
        /// <c>BigQueryExportServiceClient.UpdateBigQueryExportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 120000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateBigQueryExportSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(120000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigQueryExportServiceClient.ProvisionBigQueryExport</c> and
        /// <c>BigQueryExportServiceClient.ProvisionBigQueryExportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 120000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ProvisionBigQueryExportSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(120000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BigQueryExportServiceSettings"/> object.</returns>
        public BigQueryExportServiceSettings Clone() => new BigQueryExportServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BigQueryExportServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class BigQueryExportServiceClientBuilder : gaxgrpc::ClientBuilderBase<BigQueryExportServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BigQueryExportServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public BigQueryExportServiceClientBuilder() : base(BigQueryExportServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref BigQueryExportServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<BigQueryExportServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override BigQueryExportServiceClient Build()
        {
            BigQueryExportServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<BigQueryExportServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<BigQueryExportServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private BigQueryExportServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BigQueryExportServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<BigQueryExportServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BigQueryExportServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BigQueryExportServiceClient.ChannelPool;
    }

    /// <summary>BigQueryExportService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing BigQuery export configurations for Chronicle instances.
    /// </remarks>
    public abstract partial class BigQueryExportServiceClient
    {
        /// <summary>
        /// The default endpoint for the BigQueryExportService service, which is a host of "chronicle.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "chronicle.googleapis.com:443";

        /// <summary>The default BigQueryExportService scopes.</summary>
        /// <remarks>
        /// The default BigQueryExportService scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(BigQueryExportService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="BigQueryExportServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="BigQueryExportServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="BigQueryExportServiceClient"/>.</returns>
        public static stt::Task<BigQueryExportServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new BigQueryExportServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="BigQueryExportServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="BigQueryExportServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="BigQueryExportServiceClient"/>.</returns>
        public static BigQueryExportServiceClient Create() => new BigQueryExportServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="BigQueryExportServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BigQueryExportServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="BigQueryExportServiceClient"/>.</returns>
        internal static BigQueryExportServiceClient Create(grpccore::CallInvoker callInvoker, BigQueryExportServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BigQueryExportService.BigQueryExportServiceClient grpcClient = new BigQueryExportService.BigQueryExportServiceClient(callInvoker);
            return new BigQueryExportServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC BigQueryExportService client</summary>
        public virtual BigQueryExportService.BigQueryExportServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Get the BigQuery export configuration for a Chronicle instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BigQueryExport GetBigQueryExport(GetBigQueryExportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the BigQuery export configuration for a Chronicle instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BigQueryExport> GetBigQueryExportAsync(GetBigQueryExportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the BigQuery export configuration for a Chronicle instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BigQueryExport> GetBigQueryExportAsync(GetBigQueryExportRequest request, st::CancellationToken cancellationToken) =>
            GetBigQueryExportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the BigQuery export configuration for a Chronicle instance.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the BigqueryExport to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/bigQueryExport
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BigQueryExport GetBigQueryExport(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBigQueryExport(new GetBigQueryExportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the BigQuery export configuration for a Chronicle instance.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the BigqueryExport to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/bigQueryExport
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BigQueryExport> GetBigQueryExportAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBigQueryExportAsync(new GetBigQueryExportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the BigQuery export configuration for a Chronicle instance.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the BigqueryExport to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/bigQueryExport
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BigQueryExport> GetBigQueryExportAsync(string name, st::CancellationToken cancellationToken) =>
            GetBigQueryExportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the BigQuery export configuration for a Chronicle instance.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the BigqueryExport to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/bigQueryExport
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BigQueryExport GetBigQueryExport(BigQueryExportName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBigQueryExport(new GetBigQueryExportRequest
            {
                BigQueryExportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the BigQuery export configuration for a Chronicle instance.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the BigqueryExport to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/bigQueryExport
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BigQueryExport> GetBigQueryExportAsync(BigQueryExportName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBigQueryExportAsync(new GetBigQueryExportRequest
            {
                BigQueryExportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the BigQuery export configuration for a Chronicle instance.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the BigqueryExport to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/bigQueryExport
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BigQueryExport> GetBigQueryExportAsync(BigQueryExportName name, st::CancellationToken cancellationToken) =>
            GetBigQueryExportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update the BigQuery export configuration for a Chronicle instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BigQueryExport UpdateBigQueryExport(UpdateBigQueryExportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update the BigQuery export configuration for a Chronicle instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BigQueryExport> UpdateBigQueryExportAsync(UpdateBigQueryExportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update the BigQuery export configuration for a Chronicle instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BigQueryExport> UpdateBigQueryExportAsync(UpdateBigQueryExportRequest request, st::CancellationToken cancellationToken) =>
            UpdateBigQueryExportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update the BigQuery export configuration for a Chronicle instance.
        /// </summary>
        /// <param name="bigQueryExport">
        /// Required. The BigQueryExport settings to update.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/bigQueryExport
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BigQueryExport UpdateBigQueryExport(BigQueryExport bigQueryExport, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBigQueryExport(new UpdateBigQueryExportRequest
            {
                BigQueryExport = gax::GaxPreconditions.CheckNotNull(bigQueryExport, nameof(bigQueryExport)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update the BigQuery export configuration for a Chronicle instance.
        /// </summary>
        /// <param name="bigQueryExport">
        /// Required. The BigQueryExport settings to update.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/bigQueryExport
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BigQueryExport> UpdateBigQueryExportAsync(BigQueryExport bigQueryExport, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBigQueryExportAsync(new UpdateBigQueryExportRequest
            {
                BigQueryExport = gax::GaxPreconditions.CheckNotNull(bigQueryExport, nameof(bigQueryExport)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update the BigQuery export configuration for a Chronicle instance.
        /// </summary>
        /// <param name="bigQueryExport">
        /// Required. The BigQueryExport settings to update.
        /// Format:
        /// projects/{project}/locations/{location}/instances/{instance}/bigQueryExport
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BigQueryExport> UpdateBigQueryExportAsync(BigQueryExport bigQueryExport, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateBigQueryExportAsync(bigQueryExport, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Provision the BigQuery export for a Chronicle instance. This will create
        /// {{gcp_name}} resources like {{storage_name}} buckets, BigQuery datasets
        /// and set default export settings for each data source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BigQueryExport ProvisionBigQueryExport(ProvisionBigQueryExportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Provision the BigQuery export for a Chronicle instance. This will create
        /// {{gcp_name}} resources like {{storage_name}} buckets, BigQuery datasets
        /// and set default export settings for each data source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BigQueryExport> ProvisionBigQueryExportAsync(ProvisionBigQueryExportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Provision the BigQuery export for a Chronicle instance. This will create
        /// {{gcp_name}} resources like {{storage_name}} buckets, BigQuery datasets
        /// and set default export settings for each data source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BigQueryExport> ProvisionBigQueryExportAsync(ProvisionBigQueryExportRequest request, st::CancellationToken cancellationToken) =>
            ProvisionBigQueryExportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Provision the BigQuery export for a Chronicle instance. This will create
        /// {{gcp_name}} resources like {{storage_name}} buckets, BigQuery datasets
        /// and set default export settings for each data source.
        /// </summary>
        /// <param name="parent">
        /// Required. The instance for which BigQuery export is being provisioned.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BigQueryExport ProvisionBigQueryExport(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ProvisionBigQueryExport(new ProvisionBigQueryExportRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Provision the BigQuery export for a Chronicle instance. This will create
        /// {{gcp_name}} resources like {{storage_name}} buckets, BigQuery datasets
        /// and set default export settings for each data source.
        /// </summary>
        /// <param name="parent">
        /// Required. The instance for which BigQuery export is being provisioned.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BigQueryExport> ProvisionBigQueryExportAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ProvisionBigQueryExportAsync(new ProvisionBigQueryExportRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Provision the BigQuery export for a Chronicle instance. This will create
        /// {{gcp_name}} resources like {{storage_name}} buckets, BigQuery datasets
        /// and set default export settings for each data source.
        /// </summary>
        /// <param name="parent">
        /// Required. The instance for which BigQuery export is being provisioned.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BigQueryExport> ProvisionBigQueryExportAsync(string parent, st::CancellationToken cancellationToken) =>
            ProvisionBigQueryExportAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Provision the BigQuery export for a Chronicle instance. This will create
        /// {{gcp_name}} resources like {{storage_name}} buckets, BigQuery datasets
        /// and set default export settings for each data source.
        /// </summary>
        /// <param name="parent">
        /// Required. The instance for which BigQuery export is being provisioned.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BigQueryExport ProvisionBigQueryExport(InstanceName parent, gaxgrpc::CallSettings callSettings = null) =>
            ProvisionBigQueryExport(new ProvisionBigQueryExportRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Provision the BigQuery export for a Chronicle instance. This will create
        /// {{gcp_name}} resources like {{storage_name}} buckets, BigQuery datasets
        /// and set default export settings for each data source.
        /// </summary>
        /// <param name="parent">
        /// Required. The instance for which BigQuery export is being provisioned.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BigQueryExport> ProvisionBigQueryExportAsync(InstanceName parent, gaxgrpc::CallSettings callSettings = null) =>
            ProvisionBigQueryExportAsync(new ProvisionBigQueryExportRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Provision the BigQuery export for a Chronicle instance. This will create
        /// {{gcp_name}} resources like {{storage_name}} buckets, BigQuery datasets
        /// and set default export settings for each data source.
        /// </summary>
        /// <param name="parent">
        /// Required. The instance for which BigQuery export is being provisioned.
        /// Format: projects/{project}/locations/{location}/instances/{instance}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BigQueryExport> ProvisionBigQueryExportAsync(InstanceName parent, st::CancellationToken cancellationToken) =>
            ProvisionBigQueryExportAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>BigQueryExportService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing BigQuery export configurations for Chronicle instances.
    /// </remarks>
    public sealed partial class BigQueryExportServiceClientImpl : BigQueryExportServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetBigQueryExportRequest, BigQueryExport> _callGetBigQueryExport;

        private readonly gaxgrpc::ApiCall<UpdateBigQueryExportRequest, BigQueryExport> _callUpdateBigQueryExport;

        private readonly gaxgrpc::ApiCall<ProvisionBigQueryExportRequest, BigQueryExport> _callProvisionBigQueryExport;

        /// <summary>
        /// Constructs a client wrapper for the BigQueryExportService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="BigQueryExportServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public BigQueryExportServiceClientImpl(BigQueryExportService.BigQueryExportServiceClient grpcClient, BigQueryExportServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            BigQueryExportServiceSettings effectiveSettings = settings ?? BigQueryExportServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetBigQueryExport = clientHelper.BuildApiCall<GetBigQueryExportRequest, BigQueryExport>("GetBigQueryExport", grpcClient.GetBigQueryExportAsync, grpcClient.GetBigQueryExport, effectiveSettings.GetBigQueryExportSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetBigQueryExport);
            Modify_GetBigQueryExportApiCall(ref _callGetBigQueryExport);
            _callUpdateBigQueryExport = clientHelper.BuildApiCall<UpdateBigQueryExportRequest, BigQueryExport>("UpdateBigQueryExport", grpcClient.UpdateBigQueryExportAsync, grpcClient.UpdateBigQueryExport, effectiveSettings.UpdateBigQueryExportSettings).WithGoogleRequestParam("big_query_export.name", request => request.BigQueryExport?.Name);
            Modify_ApiCall(ref _callUpdateBigQueryExport);
            Modify_UpdateBigQueryExportApiCall(ref _callUpdateBigQueryExport);
            _callProvisionBigQueryExport = clientHelper.BuildApiCall<ProvisionBigQueryExportRequest, BigQueryExport>("ProvisionBigQueryExport", grpcClient.ProvisionBigQueryExportAsync, grpcClient.ProvisionBigQueryExport, effectiveSettings.ProvisionBigQueryExportSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callProvisionBigQueryExport);
            Modify_ProvisionBigQueryExportApiCall(ref _callProvisionBigQueryExport);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetBigQueryExportApiCall(ref gaxgrpc::ApiCall<GetBigQueryExportRequest, BigQueryExport> call);

        partial void Modify_UpdateBigQueryExportApiCall(ref gaxgrpc::ApiCall<UpdateBigQueryExportRequest, BigQueryExport> call);

        partial void Modify_ProvisionBigQueryExportApiCall(ref gaxgrpc::ApiCall<ProvisionBigQueryExportRequest, BigQueryExport> call);

        partial void OnConstruction(BigQueryExportService.BigQueryExportServiceClient grpcClient, BigQueryExportServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC BigQueryExportService client</summary>
        public override BigQueryExportService.BigQueryExportServiceClient GrpcClient { get; }

        partial void Modify_GetBigQueryExportRequest(ref GetBigQueryExportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateBigQueryExportRequest(ref UpdateBigQueryExportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ProvisionBigQueryExportRequest(ref ProvisionBigQueryExportRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Get the BigQuery export configuration for a Chronicle instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BigQueryExport GetBigQueryExport(GetBigQueryExportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBigQueryExportRequest(ref request, ref callSettings);
            return _callGetBigQueryExport.Sync(request, callSettings);
        }

        /// <summary>
        /// Get the BigQuery export configuration for a Chronicle instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BigQueryExport> GetBigQueryExportAsync(GetBigQueryExportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBigQueryExportRequest(ref request, ref callSettings);
            return _callGetBigQueryExport.Async(request, callSettings);
        }

        /// <summary>
        /// Update the BigQuery export configuration for a Chronicle instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BigQueryExport UpdateBigQueryExport(UpdateBigQueryExportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBigQueryExportRequest(ref request, ref callSettings);
            return _callUpdateBigQueryExport.Sync(request, callSettings);
        }

        /// <summary>
        /// Update the BigQuery export configuration for a Chronicle instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BigQueryExport> UpdateBigQueryExportAsync(UpdateBigQueryExportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBigQueryExportRequest(ref request, ref callSettings);
            return _callUpdateBigQueryExport.Async(request, callSettings);
        }

        /// <summary>
        /// Provision the BigQuery export for a Chronicle instance. This will create
        /// {{gcp_name}} resources like {{storage_name}} buckets, BigQuery datasets
        /// and set default export settings for each data source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BigQueryExport ProvisionBigQueryExport(ProvisionBigQueryExportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ProvisionBigQueryExportRequest(ref request, ref callSettings);
            return _callProvisionBigQueryExport.Sync(request, callSettings);
        }

        /// <summary>
        /// Provision the BigQuery export for a Chronicle instance. This will create
        /// {{gcp_name}} resources like {{storage_name}} buckets, BigQuery datasets
        /// and set default export settings for each data source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BigQueryExport> ProvisionBigQueryExportAsync(ProvisionBigQueryExportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ProvisionBigQueryExportRequest(ref request, ref callSettings);
            return _callProvisionBigQueryExport.Async(request, callSettings);
        }
    }
}
