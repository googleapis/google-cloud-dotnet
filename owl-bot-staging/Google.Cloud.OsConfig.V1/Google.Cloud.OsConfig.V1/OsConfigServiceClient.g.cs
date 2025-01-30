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

namespace Google.Cloud.OsConfig.V1
{
    /// <summary>Settings for <see cref="OsConfigServiceClient"/> instances.</summary>
    public sealed partial class OsConfigServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="OsConfigServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="OsConfigServiceSettings"/>.</returns>
        public static OsConfigServiceSettings GetDefault() => new OsConfigServiceSettings();

        /// <summary>Constructs a new <see cref="OsConfigServiceSettings"/> object with default settings.</summary>
        public OsConfigServiceSettings()
        {
        }

        private OsConfigServiceSettings(OsConfigServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ExecutePatchJobSettings = existing.ExecutePatchJobSettings;
            GetPatchJobSettings = existing.GetPatchJobSettings;
            CancelPatchJobSettings = existing.CancelPatchJobSettings;
            ListPatchJobsSettings = existing.ListPatchJobsSettings;
            ListPatchJobInstanceDetailsSettings = existing.ListPatchJobInstanceDetailsSettings;
            CreatePatchDeploymentSettings = existing.CreatePatchDeploymentSettings;
            GetPatchDeploymentSettings = existing.GetPatchDeploymentSettings;
            ListPatchDeploymentsSettings = existing.ListPatchDeploymentsSettings;
            DeletePatchDeploymentSettings = existing.DeletePatchDeploymentSettings;
            UpdatePatchDeploymentSettings = existing.UpdatePatchDeploymentSettings;
            PausePatchDeploymentSettings = existing.PausePatchDeploymentSettings;
            ResumePatchDeploymentSettings = existing.ResumePatchDeploymentSettings;
            OnCopy(existing);
        }

        partial void OnCopy(OsConfigServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigServiceClient.ExecutePatchJob</c> and <c>OsConfigServiceClient.ExecutePatchJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExecutePatchJobSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigServiceClient.GetPatchJob</c> and <c>OsConfigServiceClient.GetPatchJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetPatchJobSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigServiceClient.CancelPatchJob</c> and <c>OsConfigServiceClient.CancelPatchJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CancelPatchJobSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigServiceClient.ListPatchJobs</c> and <c>OsConfigServiceClient.ListPatchJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPatchJobsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigServiceClient.ListPatchJobInstanceDetails</c> and
        /// <c>OsConfigServiceClient.ListPatchJobInstanceDetailsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPatchJobInstanceDetailsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigServiceClient.CreatePatchDeployment</c> and <c>OsConfigServiceClient.CreatePatchDeploymentAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreatePatchDeploymentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigServiceClient.GetPatchDeployment</c> and <c>OsConfigServiceClient.GetPatchDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetPatchDeploymentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigServiceClient.ListPatchDeployments</c> and <c>OsConfigServiceClient.ListPatchDeploymentsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPatchDeploymentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigServiceClient.DeletePatchDeployment</c> and <c>OsConfigServiceClient.DeletePatchDeploymentAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeletePatchDeploymentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigServiceClient.UpdatePatchDeployment</c> and <c>OsConfigServiceClient.UpdatePatchDeploymentAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdatePatchDeploymentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigServiceClient.PausePatchDeployment</c> and <c>OsConfigServiceClient.PausePatchDeploymentAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PausePatchDeploymentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigServiceClient.ResumePatchDeployment</c> and <c>OsConfigServiceClient.ResumePatchDeploymentAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResumePatchDeploymentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="OsConfigServiceSettings"/> object.</returns>
        public OsConfigServiceSettings Clone() => new OsConfigServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="OsConfigServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class OsConfigServiceClientBuilder : gaxgrpc::ClientBuilderBase<OsConfigServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public OsConfigServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public OsConfigServiceClientBuilder() : base(OsConfigServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref OsConfigServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<OsConfigServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override OsConfigServiceClient Build()
        {
            OsConfigServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<OsConfigServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<OsConfigServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private OsConfigServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return OsConfigServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<OsConfigServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return OsConfigServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => OsConfigServiceClient.ChannelPool;
    }

    /// <summary>OsConfigService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// OS Config API
    /// 
    /// The OS Config service is a server-side component that you can use to
    /// manage package installations and patch jobs for virtual machine instances.
    /// </remarks>
    public abstract partial class OsConfigServiceClient
    {
        /// <summary>
        /// The default endpoint for the OsConfigService service, which is a host of "osconfig.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "osconfig.googleapis.com:443";

        /// <summary>The default OsConfigService scopes.</summary>
        /// <remarks>
        /// The default OsConfigService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(OsConfigService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="OsConfigServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="OsConfigServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="OsConfigServiceClient"/>.</returns>
        public static stt::Task<OsConfigServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new OsConfigServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="OsConfigServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="OsConfigServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="OsConfigServiceClient"/>.</returns>
        public static OsConfigServiceClient Create() => new OsConfigServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="OsConfigServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="OsConfigServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="OsConfigServiceClient"/>.</returns>
        internal static OsConfigServiceClient Create(grpccore::CallInvoker callInvoker, OsConfigServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            OsConfigService.OsConfigServiceClient grpcClient = new OsConfigService.OsConfigServiceClient(callInvoker);
            return new OsConfigServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC OsConfigService client</summary>
        public virtual OsConfigService.OsConfigServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Patch VM instances by creating and running a patch job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PatchJob ExecutePatchJob(ExecutePatchJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patch VM instances by creating and running a patch job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchJob> ExecutePatchJobAsync(ExecutePatchJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patch VM instances by creating and running a patch job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchJob> ExecutePatchJobAsync(ExecutePatchJobRequest request, st::CancellationToken cancellationToken) =>
            ExecutePatchJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the patch job. This can be used to track the progress of an
        /// ongoing patch job or review the details of completed jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PatchJob GetPatchJob(GetPatchJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the patch job. This can be used to track the progress of an
        /// ongoing patch job or review the details of completed jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchJob> GetPatchJobAsync(GetPatchJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the patch job. This can be used to track the progress of an
        /// ongoing patch job or review the details of completed jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchJob> GetPatchJobAsync(GetPatchJobRequest request, st::CancellationToken cancellationToken) =>
            GetPatchJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the patch job. This can be used to track the progress of an
        /// ongoing patch job or review the details of completed jobs.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the patch in the form `projects/*/patchJobs/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PatchJob GetPatchJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPatchJob(new GetPatchJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the patch job. This can be used to track the progress of an
        /// ongoing patch job or review the details of completed jobs.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the patch in the form `projects/*/patchJobs/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchJob> GetPatchJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPatchJobAsync(new GetPatchJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the patch job. This can be used to track the progress of an
        /// ongoing patch job or review the details of completed jobs.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the patch in the form `projects/*/patchJobs/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchJob> GetPatchJobAsync(string name, st::CancellationToken cancellationToken) =>
            GetPatchJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the patch job. This can be used to track the progress of an
        /// ongoing patch job or review the details of completed jobs.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the patch in the form `projects/*/patchJobs/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PatchJob GetPatchJob(PatchJobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPatchJob(new GetPatchJobRequest
            {
                PatchJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the patch job. This can be used to track the progress of an
        /// ongoing patch job or review the details of completed jobs.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the patch in the form `projects/*/patchJobs/*`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchJob> GetPatchJobAsync(PatchJobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPatchJobAsync(new GetPatchJobRequest
            {
                PatchJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the patch job. This can be used to track the progress of an
        /// ongoing patch job or review the details of completed jobs.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the patch in the form `projects/*/patchJobs/*`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchJob> GetPatchJobAsync(PatchJobName name, st::CancellationToken cancellationToken) =>
            GetPatchJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancel a patch job. The patch job must be active. Canceled patch jobs
        /// cannot be restarted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PatchJob CancelPatchJob(CancelPatchJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancel a patch job. The patch job must be active. Canceled patch jobs
        /// cannot be restarted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchJob> CancelPatchJobAsync(CancelPatchJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancel a patch job. The patch job must be active. Canceled patch jobs
        /// cannot be restarted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchJob> CancelPatchJobAsync(CancelPatchJobRequest request, st::CancellationToken cancellationToken) =>
            CancelPatchJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a list of patch jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PatchJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPatchJobsResponse, PatchJob> ListPatchJobs(ListPatchJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a list of patch jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PatchJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPatchJobsResponse, PatchJob> ListPatchJobsAsync(ListPatchJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a list of patch jobs.
        /// </summary>
        /// <param name="parent">
        /// Required. In the form of `projects/*`
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
        /// <returns>A pageable sequence of <see cref="PatchJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPatchJobsResponse, PatchJob> ListPatchJobs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPatchJobsRequest request = new ListPatchJobsRequest
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
            return ListPatchJobs(request, callSettings);
        }

        /// <summary>
        /// Get a list of patch jobs.
        /// </summary>
        /// <param name="parent">
        /// Required. In the form of `projects/*`
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
        /// <returns>A pageable asynchronous sequence of <see cref="PatchJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPatchJobsResponse, PatchJob> ListPatchJobsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPatchJobsRequest request = new ListPatchJobsRequest
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
            return ListPatchJobsAsync(request, callSettings);
        }

        /// <summary>
        /// Get a list of patch jobs.
        /// </summary>
        /// <param name="parent">
        /// Required. In the form of `projects/*`
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
        /// <returns>A pageable sequence of <see cref="PatchJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPatchJobsResponse, PatchJob> ListPatchJobs(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPatchJobsRequest request = new ListPatchJobsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPatchJobs(request, callSettings);
        }

        /// <summary>
        /// Get a list of patch jobs.
        /// </summary>
        /// <param name="parent">
        /// Required. In the form of `projects/*`
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
        /// <returns>A pageable asynchronous sequence of <see cref="PatchJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPatchJobsResponse, PatchJob> ListPatchJobsAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPatchJobsRequest request = new ListPatchJobsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPatchJobsAsync(request, callSettings);
        }

        /// <summary>
        /// Get a list of instance details for a given patch job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PatchJobInstanceDetails"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPatchJobInstanceDetailsResponse, PatchJobInstanceDetails> ListPatchJobInstanceDetails(ListPatchJobInstanceDetailsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a list of instance details for a given patch job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PatchJobInstanceDetails"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPatchJobInstanceDetailsResponse, PatchJobInstanceDetails> ListPatchJobInstanceDetailsAsync(ListPatchJobInstanceDetailsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a list of instance details for a given patch job.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent for the instances are in the form of
        /// `projects/*/patchJobs/*`.
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
        /// <returns>A pageable sequence of <see cref="PatchJobInstanceDetails"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPatchJobInstanceDetailsResponse, PatchJobInstanceDetails> ListPatchJobInstanceDetails(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPatchJobInstanceDetailsRequest request = new ListPatchJobInstanceDetailsRequest
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
            return ListPatchJobInstanceDetails(request, callSettings);
        }

        /// <summary>
        /// Get a list of instance details for a given patch job.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent for the instances are in the form of
        /// `projects/*/patchJobs/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="PatchJobInstanceDetails"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPatchJobInstanceDetailsResponse, PatchJobInstanceDetails> ListPatchJobInstanceDetailsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPatchJobInstanceDetailsRequest request = new ListPatchJobInstanceDetailsRequest
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
            return ListPatchJobInstanceDetailsAsync(request, callSettings);
        }

        /// <summary>
        /// Get a list of instance details for a given patch job.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent for the instances are in the form of
        /// `projects/*/patchJobs/*`.
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
        /// <returns>A pageable sequence of <see cref="PatchJobInstanceDetails"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPatchJobInstanceDetailsResponse, PatchJobInstanceDetails> ListPatchJobInstanceDetails(PatchJobName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPatchJobInstanceDetailsRequest request = new ListPatchJobInstanceDetailsRequest
            {
                ParentAsPatchJobName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPatchJobInstanceDetails(request, callSettings);
        }

        /// <summary>
        /// Get a list of instance details for a given patch job.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent for the instances are in the form of
        /// `projects/*/patchJobs/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="PatchJobInstanceDetails"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPatchJobInstanceDetailsResponse, PatchJobInstanceDetails> ListPatchJobInstanceDetailsAsync(PatchJobName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPatchJobInstanceDetailsRequest request = new ListPatchJobInstanceDetailsRequest
            {
                ParentAsPatchJobName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPatchJobInstanceDetailsAsync(request, callSettings);
        }

        /// <summary>
        /// Create an OS Config patch deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PatchDeployment CreatePatchDeployment(CreatePatchDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create an OS Config patch deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchDeployment> CreatePatchDeploymentAsync(CreatePatchDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create an OS Config patch deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchDeployment> CreatePatchDeploymentAsync(CreatePatchDeploymentRequest request, st::CancellationToken cancellationToken) =>
            CreatePatchDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create an OS Config patch deployment.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to apply this patch deployment to in the form
        /// `projects/*`.
        /// </param>
        /// <param name="patchDeployment">
        /// Required. The patch deployment to create.
        /// </param>
        /// <param name="patchDeploymentId">
        /// Required. A name for the patch deployment in the project. When creating a
        /// name the following rules apply:
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the project.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PatchDeployment CreatePatchDeployment(string parent, PatchDeployment patchDeployment, string patchDeploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePatchDeployment(new CreatePatchDeploymentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PatchDeploymentId = gax::GaxPreconditions.CheckNotNullOrEmpty(patchDeploymentId, nameof(patchDeploymentId)),
                PatchDeployment = gax::GaxPreconditions.CheckNotNull(patchDeployment, nameof(patchDeployment)),
            }, callSettings);

        /// <summary>
        /// Create an OS Config patch deployment.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to apply this patch deployment to in the form
        /// `projects/*`.
        /// </param>
        /// <param name="patchDeployment">
        /// Required. The patch deployment to create.
        /// </param>
        /// <param name="patchDeploymentId">
        /// Required. A name for the patch deployment in the project. When creating a
        /// name the following rules apply:
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the project.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchDeployment> CreatePatchDeploymentAsync(string parent, PatchDeployment patchDeployment, string patchDeploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePatchDeploymentAsync(new CreatePatchDeploymentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PatchDeploymentId = gax::GaxPreconditions.CheckNotNullOrEmpty(patchDeploymentId, nameof(patchDeploymentId)),
                PatchDeployment = gax::GaxPreconditions.CheckNotNull(patchDeployment, nameof(patchDeployment)),
            }, callSettings);

        /// <summary>
        /// Create an OS Config patch deployment.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to apply this patch deployment to in the form
        /// `projects/*`.
        /// </param>
        /// <param name="patchDeployment">
        /// Required. The patch deployment to create.
        /// </param>
        /// <param name="patchDeploymentId">
        /// Required. A name for the patch deployment in the project. When creating a
        /// name the following rules apply:
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the project.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchDeployment> CreatePatchDeploymentAsync(string parent, PatchDeployment patchDeployment, string patchDeploymentId, st::CancellationToken cancellationToken) =>
            CreatePatchDeploymentAsync(parent, patchDeployment, patchDeploymentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create an OS Config patch deployment.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to apply this patch deployment to in the form
        /// `projects/*`.
        /// </param>
        /// <param name="patchDeployment">
        /// Required. The patch deployment to create.
        /// </param>
        /// <param name="patchDeploymentId">
        /// Required. A name for the patch deployment in the project. When creating a
        /// name the following rules apply:
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the project.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PatchDeployment CreatePatchDeployment(gagr::ProjectName parent, PatchDeployment patchDeployment, string patchDeploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePatchDeployment(new CreatePatchDeploymentRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PatchDeploymentId = gax::GaxPreconditions.CheckNotNullOrEmpty(patchDeploymentId, nameof(patchDeploymentId)),
                PatchDeployment = gax::GaxPreconditions.CheckNotNull(patchDeployment, nameof(patchDeployment)),
            }, callSettings);

        /// <summary>
        /// Create an OS Config patch deployment.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to apply this patch deployment to in the form
        /// `projects/*`.
        /// </param>
        /// <param name="patchDeployment">
        /// Required. The patch deployment to create.
        /// </param>
        /// <param name="patchDeploymentId">
        /// Required. A name for the patch deployment in the project. When creating a
        /// name the following rules apply:
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the project.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchDeployment> CreatePatchDeploymentAsync(gagr::ProjectName parent, PatchDeployment patchDeployment, string patchDeploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePatchDeploymentAsync(new CreatePatchDeploymentRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PatchDeploymentId = gax::GaxPreconditions.CheckNotNullOrEmpty(patchDeploymentId, nameof(patchDeploymentId)),
                PatchDeployment = gax::GaxPreconditions.CheckNotNull(patchDeployment, nameof(patchDeployment)),
            }, callSettings);

        /// <summary>
        /// Create an OS Config patch deployment.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to apply this patch deployment to in the form
        /// `projects/*`.
        /// </param>
        /// <param name="patchDeployment">
        /// Required. The patch deployment to create.
        /// </param>
        /// <param name="patchDeploymentId">
        /// Required. A name for the patch deployment in the project. When creating a
        /// name the following rules apply:
        /// * Must contain only lowercase letters, numbers, and hyphens.
        /// * Must start with a letter.
        /// * Must be between 1-63 characters.
        /// * Must end with a number or a letter.
        /// * Must be unique within the project.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchDeployment> CreatePatchDeploymentAsync(gagr::ProjectName parent, PatchDeployment patchDeployment, string patchDeploymentId, st::CancellationToken cancellationToken) =>
            CreatePatchDeploymentAsync(parent, patchDeployment, patchDeploymentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get an OS Config patch deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PatchDeployment GetPatchDeployment(GetPatchDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get an OS Config patch deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchDeployment> GetPatchDeploymentAsync(GetPatchDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get an OS Config patch deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchDeployment> GetPatchDeploymentAsync(GetPatchDeploymentRequest request, st::CancellationToken cancellationToken) =>
            GetPatchDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get an OS Config patch deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the patch deployment in the form
        /// `projects/*/patchDeployments/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PatchDeployment GetPatchDeployment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPatchDeployment(new GetPatchDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get an OS Config patch deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the patch deployment in the form
        /// `projects/*/patchDeployments/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchDeployment> GetPatchDeploymentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPatchDeploymentAsync(new GetPatchDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get an OS Config patch deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the patch deployment in the form
        /// `projects/*/patchDeployments/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchDeployment> GetPatchDeploymentAsync(string name, st::CancellationToken cancellationToken) =>
            GetPatchDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get an OS Config patch deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the patch deployment in the form
        /// `projects/*/patchDeployments/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PatchDeployment GetPatchDeployment(PatchDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPatchDeployment(new GetPatchDeploymentRequest
            {
                PatchDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get an OS Config patch deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the patch deployment in the form
        /// `projects/*/patchDeployments/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchDeployment> GetPatchDeploymentAsync(PatchDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPatchDeploymentAsync(new GetPatchDeploymentRequest
            {
                PatchDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get an OS Config patch deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the patch deployment in the form
        /// `projects/*/patchDeployments/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchDeployment> GetPatchDeploymentAsync(PatchDeploymentName name, st::CancellationToken cancellationToken) =>
            GetPatchDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a page of OS Config patch deployments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PatchDeployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPatchDeploymentsResponse, PatchDeployment> ListPatchDeployments(ListPatchDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a page of OS Config patch deployments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PatchDeployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPatchDeploymentsResponse, PatchDeployment> ListPatchDeploymentsAsync(ListPatchDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a page of OS Config patch deployments.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent in the form `projects/*`.
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
        /// <returns>A pageable sequence of <see cref="PatchDeployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPatchDeploymentsResponse, PatchDeployment> ListPatchDeployments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPatchDeploymentsRequest request = new ListPatchDeploymentsRequest
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
            return ListPatchDeployments(request, callSettings);
        }

        /// <summary>
        /// Get a page of OS Config patch deployments.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent in the form `projects/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="PatchDeployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPatchDeploymentsResponse, PatchDeployment> ListPatchDeploymentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPatchDeploymentsRequest request = new ListPatchDeploymentsRequest
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
            return ListPatchDeploymentsAsync(request, callSettings);
        }

        /// <summary>
        /// Get a page of OS Config patch deployments.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent in the form `projects/*`.
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
        /// <returns>A pageable sequence of <see cref="PatchDeployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPatchDeploymentsResponse, PatchDeployment> ListPatchDeployments(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPatchDeploymentsRequest request = new ListPatchDeploymentsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPatchDeployments(request, callSettings);
        }

        /// <summary>
        /// Get a page of OS Config patch deployments.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent in the form `projects/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="PatchDeployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPatchDeploymentsResponse, PatchDeployment> ListPatchDeploymentsAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPatchDeploymentsRequest request = new ListPatchDeploymentsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPatchDeploymentsAsync(request, callSettings);
        }

        /// <summary>
        /// Delete an OS Config patch deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePatchDeployment(DeletePatchDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete an OS Config patch deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePatchDeploymentAsync(DeletePatchDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete an OS Config patch deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePatchDeploymentAsync(DeletePatchDeploymentRequest request, st::CancellationToken cancellationToken) =>
            DeletePatchDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete an OS Config patch deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the patch deployment in the form
        /// `projects/*/patchDeployments/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePatchDeployment(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePatchDeployment(new DeletePatchDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an OS Config patch deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the patch deployment in the form
        /// `projects/*/patchDeployments/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePatchDeploymentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePatchDeploymentAsync(new DeletePatchDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an OS Config patch deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the patch deployment in the form
        /// `projects/*/patchDeployments/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePatchDeploymentAsync(string name, st::CancellationToken cancellationToken) =>
            DeletePatchDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete an OS Config patch deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the patch deployment in the form
        /// `projects/*/patchDeployments/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePatchDeployment(PatchDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePatchDeployment(new DeletePatchDeploymentRequest
            {
                PatchDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an OS Config patch deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the patch deployment in the form
        /// `projects/*/patchDeployments/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePatchDeploymentAsync(PatchDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePatchDeploymentAsync(new DeletePatchDeploymentRequest
            {
                PatchDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an OS Config patch deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the patch deployment in the form
        /// `projects/*/patchDeployments/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePatchDeploymentAsync(PatchDeploymentName name, st::CancellationToken cancellationToken) =>
            DeletePatchDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update an OS Config patch deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PatchDeployment UpdatePatchDeployment(UpdatePatchDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update an OS Config patch deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchDeployment> UpdatePatchDeploymentAsync(UpdatePatchDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update an OS Config patch deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchDeployment> UpdatePatchDeploymentAsync(UpdatePatchDeploymentRequest request, st::CancellationToken cancellationToken) =>
            UpdatePatchDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update an OS Config patch deployment.
        /// </summary>
        /// <param name="patchDeployment">
        /// Required. The patch deployment to Update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask that controls which fields of the patch deployment
        /// should be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PatchDeployment UpdatePatchDeployment(PatchDeployment patchDeployment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePatchDeployment(new UpdatePatchDeploymentRequest
            {
                PatchDeployment = gax::GaxPreconditions.CheckNotNull(patchDeployment, nameof(patchDeployment)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update an OS Config patch deployment.
        /// </summary>
        /// <param name="patchDeployment">
        /// Required. The patch deployment to Update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask that controls which fields of the patch deployment
        /// should be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchDeployment> UpdatePatchDeploymentAsync(PatchDeployment patchDeployment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePatchDeploymentAsync(new UpdatePatchDeploymentRequest
            {
                PatchDeployment = gax::GaxPreconditions.CheckNotNull(patchDeployment, nameof(patchDeployment)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update an OS Config patch deployment.
        /// </summary>
        /// <param name="patchDeployment">
        /// Required. The patch deployment to Update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask that controls which fields of the patch deployment
        /// should be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchDeployment> UpdatePatchDeploymentAsync(PatchDeployment patchDeployment, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdatePatchDeploymentAsync(patchDeployment, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Change state of patch deployment to "PAUSED".
        /// Patch deployment in paused state doesn't generate patch jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PatchDeployment PausePatchDeployment(PausePatchDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Change state of patch deployment to "PAUSED".
        /// Patch deployment in paused state doesn't generate patch jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchDeployment> PausePatchDeploymentAsync(PausePatchDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Change state of patch deployment to "PAUSED".
        /// Patch deployment in paused state doesn't generate patch jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchDeployment> PausePatchDeploymentAsync(PausePatchDeploymentRequest request, st::CancellationToken cancellationToken) =>
            PausePatchDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Change state of patch deployment to "PAUSED".
        /// Patch deployment in paused state doesn't generate patch jobs.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the patch deployment in the form
        /// `projects/*/patchDeployments/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PatchDeployment PausePatchDeployment(string name, gaxgrpc::CallSettings callSettings = null) =>
            PausePatchDeployment(new PausePatchDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Change state of patch deployment to "PAUSED".
        /// Patch deployment in paused state doesn't generate patch jobs.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the patch deployment in the form
        /// `projects/*/patchDeployments/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchDeployment> PausePatchDeploymentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            PausePatchDeploymentAsync(new PausePatchDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Change state of patch deployment to "PAUSED".
        /// Patch deployment in paused state doesn't generate patch jobs.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the patch deployment in the form
        /// `projects/*/patchDeployments/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchDeployment> PausePatchDeploymentAsync(string name, st::CancellationToken cancellationToken) =>
            PausePatchDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Change state of patch deployment to "PAUSED".
        /// Patch deployment in paused state doesn't generate patch jobs.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the patch deployment in the form
        /// `projects/*/patchDeployments/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PatchDeployment PausePatchDeployment(PatchDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            PausePatchDeployment(new PausePatchDeploymentRequest
            {
                PatchDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Change state of patch deployment to "PAUSED".
        /// Patch deployment in paused state doesn't generate patch jobs.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the patch deployment in the form
        /// `projects/*/patchDeployments/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchDeployment> PausePatchDeploymentAsync(PatchDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            PausePatchDeploymentAsync(new PausePatchDeploymentRequest
            {
                PatchDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Change state of patch deployment to "PAUSED".
        /// Patch deployment in paused state doesn't generate patch jobs.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the patch deployment in the form
        /// `projects/*/patchDeployments/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchDeployment> PausePatchDeploymentAsync(PatchDeploymentName name, st::CancellationToken cancellationToken) =>
            PausePatchDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Change state of patch deployment back to "ACTIVE".
        /// Patch deployment in active state continues to generate patch jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PatchDeployment ResumePatchDeployment(ResumePatchDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Change state of patch deployment back to "ACTIVE".
        /// Patch deployment in active state continues to generate patch jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchDeployment> ResumePatchDeploymentAsync(ResumePatchDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Change state of patch deployment back to "ACTIVE".
        /// Patch deployment in active state continues to generate patch jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchDeployment> ResumePatchDeploymentAsync(ResumePatchDeploymentRequest request, st::CancellationToken cancellationToken) =>
            ResumePatchDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Change state of patch deployment back to "ACTIVE".
        /// Patch deployment in active state continues to generate patch jobs.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the patch deployment in the form
        /// `projects/*/patchDeployments/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PatchDeployment ResumePatchDeployment(string name, gaxgrpc::CallSettings callSettings = null) =>
            ResumePatchDeployment(new ResumePatchDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Change state of patch deployment back to "ACTIVE".
        /// Patch deployment in active state continues to generate patch jobs.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the patch deployment in the form
        /// `projects/*/patchDeployments/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchDeployment> ResumePatchDeploymentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ResumePatchDeploymentAsync(new ResumePatchDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Change state of patch deployment back to "ACTIVE".
        /// Patch deployment in active state continues to generate patch jobs.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the patch deployment in the form
        /// `projects/*/patchDeployments/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchDeployment> ResumePatchDeploymentAsync(string name, st::CancellationToken cancellationToken) =>
            ResumePatchDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Change state of patch deployment back to "ACTIVE".
        /// Patch deployment in active state continues to generate patch jobs.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the patch deployment in the form
        /// `projects/*/patchDeployments/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PatchDeployment ResumePatchDeployment(PatchDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            ResumePatchDeployment(new ResumePatchDeploymentRequest
            {
                PatchDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Change state of patch deployment back to "ACTIVE".
        /// Patch deployment in active state continues to generate patch jobs.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the patch deployment in the form
        /// `projects/*/patchDeployments/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchDeployment> ResumePatchDeploymentAsync(PatchDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            ResumePatchDeploymentAsync(new ResumePatchDeploymentRequest
            {
                PatchDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Change state of patch deployment back to "ACTIVE".
        /// Patch deployment in active state continues to generate patch jobs.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the patch deployment in the form
        /// `projects/*/patchDeployments/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchDeployment> ResumePatchDeploymentAsync(PatchDeploymentName name, st::CancellationToken cancellationToken) =>
            ResumePatchDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>OsConfigService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// OS Config API
    /// 
    /// The OS Config service is a server-side component that you can use to
    /// manage package installations and patch jobs for virtual machine instances.
    /// </remarks>
    public sealed partial class OsConfigServiceClientImpl : OsConfigServiceClient
    {
        private readonly gaxgrpc::ApiCall<ExecutePatchJobRequest, PatchJob> _callExecutePatchJob;

        private readonly gaxgrpc::ApiCall<GetPatchJobRequest, PatchJob> _callGetPatchJob;

        private readonly gaxgrpc::ApiCall<CancelPatchJobRequest, PatchJob> _callCancelPatchJob;

        private readonly gaxgrpc::ApiCall<ListPatchJobsRequest, ListPatchJobsResponse> _callListPatchJobs;

        private readonly gaxgrpc::ApiCall<ListPatchJobInstanceDetailsRequest, ListPatchJobInstanceDetailsResponse> _callListPatchJobInstanceDetails;

        private readonly gaxgrpc::ApiCall<CreatePatchDeploymentRequest, PatchDeployment> _callCreatePatchDeployment;

        private readonly gaxgrpc::ApiCall<GetPatchDeploymentRequest, PatchDeployment> _callGetPatchDeployment;

        private readonly gaxgrpc::ApiCall<ListPatchDeploymentsRequest, ListPatchDeploymentsResponse> _callListPatchDeployments;

        private readonly gaxgrpc::ApiCall<DeletePatchDeploymentRequest, wkt::Empty> _callDeletePatchDeployment;

        private readonly gaxgrpc::ApiCall<UpdatePatchDeploymentRequest, PatchDeployment> _callUpdatePatchDeployment;

        private readonly gaxgrpc::ApiCall<PausePatchDeploymentRequest, PatchDeployment> _callPausePatchDeployment;

        private readonly gaxgrpc::ApiCall<ResumePatchDeploymentRequest, PatchDeployment> _callResumePatchDeployment;

        /// <summary>
        /// Constructs a client wrapper for the OsConfigService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="OsConfigServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public OsConfigServiceClientImpl(OsConfigService.OsConfigServiceClient grpcClient, OsConfigServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            OsConfigServiceSettings effectiveSettings = settings ?? OsConfigServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callExecutePatchJob = clientHelper.BuildApiCall<ExecutePatchJobRequest, PatchJob>("ExecutePatchJob", grpcClient.ExecutePatchJobAsync, grpcClient.ExecutePatchJob, effectiveSettings.ExecutePatchJobSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callExecutePatchJob);
            Modify_ExecutePatchJobApiCall(ref _callExecutePatchJob);
            _callGetPatchJob = clientHelper.BuildApiCall<GetPatchJobRequest, PatchJob>("GetPatchJob", grpcClient.GetPatchJobAsync, grpcClient.GetPatchJob, effectiveSettings.GetPatchJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPatchJob);
            Modify_GetPatchJobApiCall(ref _callGetPatchJob);
            _callCancelPatchJob = clientHelper.BuildApiCall<CancelPatchJobRequest, PatchJob>("CancelPatchJob", grpcClient.CancelPatchJobAsync, grpcClient.CancelPatchJob, effectiveSettings.CancelPatchJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCancelPatchJob);
            Modify_CancelPatchJobApiCall(ref _callCancelPatchJob);
            _callListPatchJobs = clientHelper.BuildApiCall<ListPatchJobsRequest, ListPatchJobsResponse>("ListPatchJobs", grpcClient.ListPatchJobsAsync, grpcClient.ListPatchJobs, effectiveSettings.ListPatchJobsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPatchJobs);
            Modify_ListPatchJobsApiCall(ref _callListPatchJobs);
            _callListPatchJobInstanceDetails = clientHelper.BuildApiCall<ListPatchJobInstanceDetailsRequest, ListPatchJobInstanceDetailsResponse>("ListPatchJobInstanceDetails", grpcClient.ListPatchJobInstanceDetailsAsync, grpcClient.ListPatchJobInstanceDetails, effectiveSettings.ListPatchJobInstanceDetailsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPatchJobInstanceDetails);
            Modify_ListPatchJobInstanceDetailsApiCall(ref _callListPatchJobInstanceDetails);
            _callCreatePatchDeployment = clientHelper.BuildApiCall<CreatePatchDeploymentRequest, PatchDeployment>("CreatePatchDeployment", grpcClient.CreatePatchDeploymentAsync, grpcClient.CreatePatchDeployment, effectiveSettings.CreatePatchDeploymentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreatePatchDeployment);
            Modify_CreatePatchDeploymentApiCall(ref _callCreatePatchDeployment);
            _callGetPatchDeployment = clientHelper.BuildApiCall<GetPatchDeploymentRequest, PatchDeployment>("GetPatchDeployment", grpcClient.GetPatchDeploymentAsync, grpcClient.GetPatchDeployment, effectiveSettings.GetPatchDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPatchDeployment);
            Modify_GetPatchDeploymentApiCall(ref _callGetPatchDeployment);
            _callListPatchDeployments = clientHelper.BuildApiCall<ListPatchDeploymentsRequest, ListPatchDeploymentsResponse>("ListPatchDeployments", grpcClient.ListPatchDeploymentsAsync, grpcClient.ListPatchDeployments, effectiveSettings.ListPatchDeploymentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPatchDeployments);
            Modify_ListPatchDeploymentsApiCall(ref _callListPatchDeployments);
            _callDeletePatchDeployment = clientHelper.BuildApiCall<DeletePatchDeploymentRequest, wkt::Empty>("DeletePatchDeployment", grpcClient.DeletePatchDeploymentAsync, grpcClient.DeletePatchDeployment, effectiveSettings.DeletePatchDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeletePatchDeployment);
            Modify_DeletePatchDeploymentApiCall(ref _callDeletePatchDeployment);
            _callUpdatePatchDeployment = clientHelper.BuildApiCall<UpdatePatchDeploymentRequest, PatchDeployment>("UpdatePatchDeployment", grpcClient.UpdatePatchDeploymentAsync, grpcClient.UpdatePatchDeployment, effectiveSettings.UpdatePatchDeploymentSettings).WithGoogleRequestParam("patch_deployment.name", request => request.PatchDeployment?.Name);
            Modify_ApiCall(ref _callUpdatePatchDeployment);
            Modify_UpdatePatchDeploymentApiCall(ref _callUpdatePatchDeployment);
            _callPausePatchDeployment = clientHelper.BuildApiCall<PausePatchDeploymentRequest, PatchDeployment>("PausePatchDeployment", grpcClient.PausePatchDeploymentAsync, grpcClient.PausePatchDeployment, effectiveSettings.PausePatchDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callPausePatchDeployment);
            Modify_PausePatchDeploymentApiCall(ref _callPausePatchDeployment);
            _callResumePatchDeployment = clientHelper.BuildApiCall<ResumePatchDeploymentRequest, PatchDeployment>("ResumePatchDeployment", grpcClient.ResumePatchDeploymentAsync, grpcClient.ResumePatchDeployment, effectiveSettings.ResumePatchDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callResumePatchDeployment);
            Modify_ResumePatchDeploymentApiCall(ref _callResumePatchDeployment);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ExecutePatchJobApiCall(ref gaxgrpc::ApiCall<ExecutePatchJobRequest, PatchJob> call);

        partial void Modify_GetPatchJobApiCall(ref gaxgrpc::ApiCall<GetPatchJobRequest, PatchJob> call);

        partial void Modify_CancelPatchJobApiCall(ref gaxgrpc::ApiCall<CancelPatchJobRequest, PatchJob> call);

        partial void Modify_ListPatchJobsApiCall(ref gaxgrpc::ApiCall<ListPatchJobsRequest, ListPatchJobsResponse> call);

        partial void Modify_ListPatchJobInstanceDetailsApiCall(ref gaxgrpc::ApiCall<ListPatchJobInstanceDetailsRequest, ListPatchJobInstanceDetailsResponse> call);

        partial void Modify_CreatePatchDeploymentApiCall(ref gaxgrpc::ApiCall<CreatePatchDeploymentRequest, PatchDeployment> call);

        partial void Modify_GetPatchDeploymentApiCall(ref gaxgrpc::ApiCall<GetPatchDeploymentRequest, PatchDeployment> call);

        partial void Modify_ListPatchDeploymentsApiCall(ref gaxgrpc::ApiCall<ListPatchDeploymentsRequest, ListPatchDeploymentsResponse> call);

        partial void Modify_DeletePatchDeploymentApiCall(ref gaxgrpc::ApiCall<DeletePatchDeploymentRequest, wkt::Empty> call);

        partial void Modify_UpdatePatchDeploymentApiCall(ref gaxgrpc::ApiCall<UpdatePatchDeploymentRequest, PatchDeployment> call);

        partial void Modify_PausePatchDeploymentApiCall(ref gaxgrpc::ApiCall<PausePatchDeploymentRequest, PatchDeployment> call);

        partial void Modify_ResumePatchDeploymentApiCall(ref gaxgrpc::ApiCall<ResumePatchDeploymentRequest, PatchDeployment> call);

        partial void OnConstruction(OsConfigService.OsConfigServiceClient grpcClient, OsConfigServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC OsConfigService client</summary>
        public override OsConfigService.OsConfigServiceClient GrpcClient { get; }

        partial void Modify_ExecutePatchJobRequest(ref ExecutePatchJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPatchJobRequest(ref GetPatchJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CancelPatchJobRequest(ref CancelPatchJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPatchJobsRequest(ref ListPatchJobsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPatchJobInstanceDetailsRequest(ref ListPatchJobInstanceDetailsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreatePatchDeploymentRequest(ref CreatePatchDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPatchDeploymentRequest(ref GetPatchDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPatchDeploymentsRequest(ref ListPatchDeploymentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePatchDeploymentRequest(ref DeletePatchDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdatePatchDeploymentRequest(ref UpdatePatchDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PausePatchDeploymentRequest(ref PausePatchDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResumePatchDeploymentRequest(ref ResumePatchDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Patch VM instances by creating and running a patch job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PatchJob ExecutePatchJob(ExecutePatchJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExecutePatchJobRequest(ref request, ref callSettings);
            return _callExecutePatchJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Patch VM instances by creating and running a patch job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PatchJob> ExecutePatchJobAsync(ExecutePatchJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExecutePatchJobRequest(ref request, ref callSettings);
            return _callExecutePatchJob.Async(request, callSettings);
        }

        /// <summary>
        /// Get the patch job. This can be used to track the progress of an
        /// ongoing patch job or review the details of completed jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PatchJob GetPatchJob(GetPatchJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPatchJobRequest(ref request, ref callSettings);
            return _callGetPatchJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Get the patch job. This can be used to track the progress of an
        /// ongoing patch job or review the details of completed jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PatchJob> GetPatchJobAsync(GetPatchJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPatchJobRequest(ref request, ref callSettings);
            return _callGetPatchJob.Async(request, callSettings);
        }

        /// <summary>
        /// Cancel a patch job. The patch job must be active. Canceled patch jobs
        /// cannot be restarted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PatchJob CancelPatchJob(CancelPatchJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelPatchJobRequest(ref request, ref callSettings);
            return _callCancelPatchJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Cancel a patch job. The patch job must be active. Canceled patch jobs
        /// cannot be restarted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PatchJob> CancelPatchJobAsync(CancelPatchJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelPatchJobRequest(ref request, ref callSettings);
            return _callCancelPatchJob.Async(request, callSettings);
        }

        /// <summary>
        /// Get a list of patch jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PatchJob"/> resources.</returns>
        public override gax::PagedEnumerable<ListPatchJobsResponse, PatchJob> ListPatchJobs(ListPatchJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPatchJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPatchJobsRequest, ListPatchJobsResponse, PatchJob>(_callListPatchJobs, request, callSettings);
        }

        /// <summary>
        /// Get a list of patch jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PatchJob"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPatchJobsResponse, PatchJob> ListPatchJobsAsync(ListPatchJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPatchJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPatchJobsRequest, ListPatchJobsResponse, PatchJob>(_callListPatchJobs, request, callSettings);
        }

        /// <summary>
        /// Get a list of instance details for a given patch job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PatchJobInstanceDetails"/> resources.</returns>
        public override gax::PagedEnumerable<ListPatchJobInstanceDetailsResponse, PatchJobInstanceDetails> ListPatchJobInstanceDetails(ListPatchJobInstanceDetailsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPatchJobInstanceDetailsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPatchJobInstanceDetailsRequest, ListPatchJobInstanceDetailsResponse, PatchJobInstanceDetails>(_callListPatchJobInstanceDetails, request, callSettings);
        }

        /// <summary>
        /// Get a list of instance details for a given patch job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PatchJobInstanceDetails"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPatchJobInstanceDetailsResponse, PatchJobInstanceDetails> ListPatchJobInstanceDetailsAsync(ListPatchJobInstanceDetailsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPatchJobInstanceDetailsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPatchJobInstanceDetailsRequest, ListPatchJobInstanceDetailsResponse, PatchJobInstanceDetails>(_callListPatchJobInstanceDetails, request, callSettings);
        }

        /// <summary>
        /// Create an OS Config patch deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PatchDeployment CreatePatchDeployment(CreatePatchDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePatchDeploymentRequest(ref request, ref callSettings);
            return _callCreatePatchDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Create an OS Config patch deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PatchDeployment> CreatePatchDeploymentAsync(CreatePatchDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePatchDeploymentRequest(ref request, ref callSettings);
            return _callCreatePatchDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// Get an OS Config patch deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PatchDeployment GetPatchDeployment(GetPatchDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPatchDeploymentRequest(ref request, ref callSettings);
            return _callGetPatchDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Get an OS Config patch deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PatchDeployment> GetPatchDeploymentAsync(GetPatchDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPatchDeploymentRequest(ref request, ref callSettings);
            return _callGetPatchDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// Get a page of OS Config patch deployments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PatchDeployment"/> resources.</returns>
        public override gax::PagedEnumerable<ListPatchDeploymentsResponse, PatchDeployment> ListPatchDeployments(ListPatchDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPatchDeploymentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPatchDeploymentsRequest, ListPatchDeploymentsResponse, PatchDeployment>(_callListPatchDeployments, request, callSettings);
        }

        /// <summary>
        /// Get a page of OS Config patch deployments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PatchDeployment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPatchDeploymentsResponse, PatchDeployment> ListPatchDeploymentsAsync(ListPatchDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPatchDeploymentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPatchDeploymentsRequest, ListPatchDeploymentsResponse, PatchDeployment>(_callListPatchDeployments, request, callSettings);
        }

        /// <summary>
        /// Delete an OS Config patch deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeletePatchDeployment(DeletePatchDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePatchDeploymentRequest(ref request, ref callSettings);
            _callDeletePatchDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete an OS Config patch deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeletePatchDeploymentAsync(DeletePatchDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePatchDeploymentRequest(ref request, ref callSettings);
            return _callDeletePatchDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// Update an OS Config patch deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PatchDeployment UpdatePatchDeployment(UpdatePatchDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePatchDeploymentRequest(ref request, ref callSettings);
            return _callUpdatePatchDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Update an OS Config patch deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PatchDeployment> UpdatePatchDeploymentAsync(UpdatePatchDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePatchDeploymentRequest(ref request, ref callSettings);
            return _callUpdatePatchDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// Change state of patch deployment to "PAUSED".
        /// Patch deployment in paused state doesn't generate patch jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PatchDeployment PausePatchDeployment(PausePatchDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PausePatchDeploymentRequest(ref request, ref callSettings);
            return _callPausePatchDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Change state of patch deployment to "PAUSED".
        /// Patch deployment in paused state doesn't generate patch jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PatchDeployment> PausePatchDeploymentAsync(PausePatchDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PausePatchDeploymentRequest(ref request, ref callSettings);
            return _callPausePatchDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// Change state of patch deployment back to "ACTIVE".
        /// Patch deployment in active state continues to generate patch jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PatchDeployment ResumePatchDeployment(ResumePatchDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResumePatchDeploymentRequest(ref request, ref callSettings);
            return _callResumePatchDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Change state of patch deployment back to "ACTIVE".
        /// Patch deployment in active state continues to generate patch jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PatchDeployment> ResumePatchDeploymentAsync(ResumePatchDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResumePatchDeploymentRequest(ref request, ref callSettings);
            return _callResumePatchDeployment.Async(request, callSettings);
        }
    }

    public partial class ListPatchJobsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPatchJobInstanceDetailsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPatchDeploymentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPatchJobsResponse : gaxgrpc::IPageResponse<PatchJob>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PatchJob> GetEnumerator() => PatchJobs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListPatchJobInstanceDetailsResponse : gaxgrpc::IPageResponse<PatchJobInstanceDetails>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PatchJobInstanceDetails> GetEnumerator() => PatchJobInstanceDetails.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListPatchDeploymentsResponse : gaxgrpc::IPageResponse<PatchDeployment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PatchDeployment> GetEnumerator() => PatchDeployments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
