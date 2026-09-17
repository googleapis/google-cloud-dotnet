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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gcl = Google.Cloud.Location;
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

namespace Google.Cloud.ParameterManager.V1
{
    /// <summary>Settings for <see cref="ParameterManagerClient"/> instances.</summary>
    public sealed partial class ParameterManagerSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ParameterManagerSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ParameterManagerSettings"/>.</returns>
        public static ParameterManagerSettings GetDefault() => new ParameterManagerSettings();

        /// <summary>Constructs a new <see cref="ParameterManagerSettings"/> object with default settings.</summary>
        public ParameterManagerSettings()
        {
        }

        private ParameterManagerSettings(ParameterManagerSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListParametersSettings = existing.ListParametersSettings;
            GetParameterSettings = existing.GetParameterSettings;
            CreateParameterSettings = existing.CreateParameterSettings;
            UpdateParameterSettings = existing.UpdateParameterSettings;
            DeleteParameterSettings = existing.DeleteParameterSettings;
            ListParameterVersionsSettings = existing.ListParameterVersionsSettings;
            GetParameterVersionSettings = existing.GetParameterVersionSettings;
            RenderParameterVersionSettings = existing.RenderParameterVersionSettings;
            CreateParameterVersionSettings = existing.CreateParameterVersionSettings;
            UpdateParameterVersionSettings = existing.UpdateParameterVersionSettings;
            DeleteParameterVersionSettings = existing.DeleteParameterVersionSettings;
            ListTemplatesSettings = existing.ListTemplatesSettings;
            GetTemplateSettings = existing.GetTemplateSettings;
            CreateTemplateSettings = existing.CreateTemplateSettings;
            UpdateTemplateSettings = existing.UpdateTemplateSettings;
            DeleteTemplateSettings = existing.DeleteTemplateSettings;
            ListTemplateVersionsSettings = existing.ListTemplateVersionsSettings;
            GetTemplateVersionSettings = existing.GetTemplateVersionSettings;
            CreateTemplateVersionSettings = existing.CreateTemplateVersionSettings;
            UpdateTemplateVersionSettings = existing.UpdateTemplateVersionSettings;
            DeleteTemplateVersionSettings = existing.DeleteTemplateVersionSettings;
            RenderTemplateVersionSettings = existing.RenderTemplateVersionSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ParameterManagerSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParameterManagerClient.ListParameters</c> and <c>ParameterManagerClient.ListParametersAsync</c>.
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
        public gaxgrpc::CallSettings ListParametersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParameterManagerClient.GetParameter</c> and <c>ParameterManagerClient.GetParameterAsync</c>.
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
        public gaxgrpc::CallSettings GetParameterSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParameterManagerClient.CreateParameter</c> and <c>ParameterManagerClient.CreateParameterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateParameterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParameterManagerClient.UpdateParameter</c> and <c>ParameterManagerClient.UpdateParameterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateParameterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParameterManagerClient.DeleteParameter</c> and <c>ParameterManagerClient.DeleteParameterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteParameterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParameterManagerClient.ListParameterVersions</c> and <c>ParameterManagerClient.ListParameterVersionsAsync</c>
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
        public gaxgrpc::CallSettings ListParameterVersionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParameterManagerClient.GetParameterVersion</c> and <c>ParameterManagerClient.GetParameterVersionAsync</c>
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
        public gaxgrpc::CallSettings GetParameterVersionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParameterManagerClient.RenderParameterVersion</c> and
        /// <c>ParameterManagerClient.RenderParameterVersionAsync</c>.
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
        public gaxgrpc::CallSettings RenderParameterVersionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParameterManagerClient.CreateParameterVersion</c> and
        /// <c>ParameterManagerClient.CreateParameterVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateParameterVersionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParameterManagerClient.UpdateParameterVersion</c> and
        /// <c>ParameterManagerClient.UpdateParameterVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateParameterVersionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParameterManagerClient.DeleteParameterVersion</c> and
        /// <c>ParameterManagerClient.DeleteParameterVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteParameterVersionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParameterManagerClient.ListTemplates</c> and <c>ParameterManagerClient.ListTemplatesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTemplatesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParameterManagerClient.GetTemplate</c> and <c>ParameterManagerClient.GetTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParameterManagerClient.CreateTemplate</c> and <c>ParameterManagerClient.CreateTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParameterManagerClient.UpdateTemplate</c> and <c>ParameterManagerClient.UpdateTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParameterManagerClient.DeleteTemplate</c> and <c>ParameterManagerClient.DeleteTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParameterManagerClient.ListTemplateVersions</c> and <c>ParameterManagerClient.ListTemplateVersionsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTemplateVersionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParameterManagerClient.GetTemplateVersion</c> and <c>ParameterManagerClient.GetTemplateVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTemplateVersionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParameterManagerClient.CreateTemplateVersion</c> and <c>ParameterManagerClient.CreateTemplateVersionAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTemplateVersionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParameterManagerClient.UpdateTemplateVersion</c> and <c>ParameterManagerClient.UpdateTemplateVersionAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateTemplateVersionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParameterManagerClient.DeleteTemplateVersion</c> and <c>ParameterManagerClient.DeleteTemplateVersionAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTemplateVersionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParameterManagerClient.RenderTemplateVersion</c> and <c>ParameterManagerClient.RenderTemplateVersionAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RenderTemplateVersionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ParameterManagerSettings"/> object.</returns>
        public ParameterManagerSettings Clone() => new ParameterManagerSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ParameterManagerClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ParameterManagerClientBuilder : gaxgrpc::ClientBuilderBase<ParameterManagerClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ParameterManagerSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ParameterManagerClientBuilder() : base(ParameterManagerClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ParameterManagerClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ParameterManagerClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ParameterManagerClient Build()
        {
            ParameterManagerClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ParameterManagerClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ParameterManagerClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ParameterManagerClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ParameterManagerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ParameterManagerClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ParameterManagerClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ParameterManagerClient.ChannelPool;
    }

    /// <summary>ParameterManager client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public abstract partial class ParameterManagerClient
    {
        /// <summary>
        /// The default endpoint for the ParameterManager service, which is a host of "parametermanager.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "parametermanager.googleapis.com:443";

        /// <summary>The default ParameterManager scopes.</summary>
        /// <remarks>
        /// The default ParameterManager scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ParameterManager.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ParameterManagerClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ParameterManagerClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ParameterManagerClient"/>.</returns>
        public static stt::Task<ParameterManagerClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ParameterManagerClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ParameterManagerClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ParameterManagerClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ParameterManagerClient"/>.</returns>
        public static ParameterManagerClient Create() => new ParameterManagerClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ParameterManagerClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ParameterManagerSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ParameterManagerClient"/>.</returns>
        internal static ParameterManagerClient Create(grpccore::CallInvoker callInvoker, ParameterManagerSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ParameterManager.ParameterManagerClient grpcClient = new ParameterManager.ParameterManagerClient(callInvoker);
            return new ParameterManagerClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ParameterManager client</summary>
        public virtual ParameterManager.ParameterManagerClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Parameters in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Parameter"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListParametersResponse, Parameter> ListParameters(ListParametersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Parameters in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Parameter"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListParametersResponse, Parameter> ListParametersAsync(ListParametersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Parameters in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListParametersRequest in the format
        /// `projects/*/locations/*`.
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
        /// <returns>A pageable sequence of <see cref="Parameter"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListParametersResponse, Parameter> ListParameters(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListParametersRequest request = new ListParametersRequest
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
            return ListParameters(request, callSettings);
        }

        /// <summary>
        /// Lists Parameters in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListParametersRequest in the format
        /// `projects/*/locations/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Parameter"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListParametersResponse, Parameter> ListParametersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListParametersRequest request = new ListParametersRequest
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
            return ListParametersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Parameters in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListParametersRequest in the format
        /// `projects/*/locations/*`.
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
        /// <returns>A pageable sequence of <see cref="Parameter"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListParametersResponse, Parameter> ListParameters(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListParametersRequest request = new ListParametersRequest
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
            return ListParameters(request, callSettings);
        }

        /// <summary>
        /// Lists Parameters in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListParametersRequest in the format
        /// `projects/*/locations/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Parameter"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListParametersResponse, Parameter> ListParametersAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListParametersRequest request = new ListParametersRequest
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
            return ListParametersAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Parameter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Parameter GetParameter(GetParameterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Parameter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Parameter> GetParameterAsync(GetParameterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Parameter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Parameter> GetParameterAsync(GetParameterRequest request, st::CancellationToken cancellationToken) =>
            GetParameterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Parameter.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/parameters/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Parameter GetParameter(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetParameter(new GetParameterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Parameter.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/parameters/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Parameter> GetParameterAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetParameterAsync(new GetParameterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Parameter.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/parameters/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Parameter> GetParameterAsync(string name, st::CancellationToken cancellationToken) =>
            GetParameterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Parameter.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/parameters/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Parameter GetParameter(ParameterName name, gaxgrpc::CallSettings callSettings = null) =>
            GetParameter(new GetParameterRequest
            {
                ParameterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Parameter.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/parameters/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Parameter> GetParameterAsync(ParameterName name, gaxgrpc::CallSettings callSettings = null) =>
            GetParameterAsync(new GetParameterRequest
            {
                ParameterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Parameter.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/parameters/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Parameter> GetParameterAsync(ParameterName name, st::CancellationToken cancellationToken) =>
            GetParameterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Parameter in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Parameter CreateParameter(CreateParameterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Parameter in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Parameter> CreateParameterAsync(CreateParameterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Parameter in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Parameter> CreateParameterAsync(CreateParameterRequest request, st::CancellationToken cancellationToken) =>
            CreateParameterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Parameter in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="parameter">
        /// Required. The Parameter resource being created
        /// </param>
        /// <param name="parameterId">
        /// Required. Id of the Parameter resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Parameter CreateParameter(string parent, Parameter parameter, string parameterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateParameter(new CreateParameterRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ParameterId = gax::GaxPreconditions.CheckNotNullOrEmpty(parameterId, nameof(parameterId)),
                Parameter = gax::GaxPreconditions.CheckNotNull(parameter, nameof(parameter)),
            }, callSettings);

        /// <summary>
        /// Creates a new Parameter in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="parameter">
        /// Required. The Parameter resource being created
        /// </param>
        /// <param name="parameterId">
        /// Required. Id of the Parameter resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Parameter> CreateParameterAsync(string parent, Parameter parameter, string parameterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateParameterAsync(new CreateParameterRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ParameterId = gax::GaxPreconditions.CheckNotNullOrEmpty(parameterId, nameof(parameterId)),
                Parameter = gax::GaxPreconditions.CheckNotNull(parameter, nameof(parameter)),
            }, callSettings);

        /// <summary>
        /// Creates a new Parameter in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="parameter">
        /// Required. The Parameter resource being created
        /// </param>
        /// <param name="parameterId">
        /// Required. Id of the Parameter resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Parameter> CreateParameterAsync(string parent, Parameter parameter, string parameterId, st::CancellationToken cancellationToken) =>
            CreateParameterAsync(parent, parameter, parameterId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Parameter in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="parameter">
        /// Required. The Parameter resource being created
        /// </param>
        /// <param name="parameterId">
        /// Required. Id of the Parameter resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Parameter CreateParameter(gagr::LocationName parent, Parameter parameter, string parameterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateParameter(new CreateParameterRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ParameterId = gax::GaxPreconditions.CheckNotNullOrEmpty(parameterId, nameof(parameterId)),
                Parameter = gax::GaxPreconditions.CheckNotNull(parameter, nameof(parameter)),
            }, callSettings);

        /// <summary>
        /// Creates a new Parameter in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="parameter">
        /// Required. The Parameter resource being created
        /// </param>
        /// <param name="parameterId">
        /// Required. Id of the Parameter resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Parameter> CreateParameterAsync(gagr::LocationName parent, Parameter parameter, string parameterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateParameterAsync(new CreateParameterRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ParameterId = gax::GaxPreconditions.CheckNotNullOrEmpty(parameterId, nameof(parameterId)),
                Parameter = gax::GaxPreconditions.CheckNotNull(parameter, nameof(parameter)),
            }, callSettings);

        /// <summary>
        /// Creates a new Parameter in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="parameter">
        /// Required. The Parameter resource being created
        /// </param>
        /// <param name="parameterId">
        /// Required. Id of the Parameter resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Parameter> CreateParameterAsync(gagr::LocationName parent, Parameter parameter, string parameterId, st::CancellationToken cancellationToken) =>
            CreateParameterAsync(parent, parameter, parameterId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a single Parameter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Parameter UpdateParameter(UpdateParameterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a single Parameter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Parameter> UpdateParameterAsync(UpdateParameterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a single Parameter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Parameter> UpdateParameterAsync(UpdateParameterRequest request, st::CancellationToken cancellationToken) =>
            UpdateParameterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a single Parameter.
        /// </summary>
        /// <param name="parameter">
        /// Required. The Parameter resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Parameter resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A mutable field will be overwritten if it is in the
        /// mask. If the user does not provide a mask then all mutable fields present
        /// in the request will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Parameter UpdateParameter(Parameter parameter, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateParameter(new UpdateParameterRequest
            {
                UpdateMask = updateMask,
                Parameter = gax::GaxPreconditions.CheckNotNull(parameter, nameof(parameter)),
            }, callSettings);

        /// <summary>
        /// Updates a single Parameter.
        /// </summary>
        /// <param name="parameter">
        /// Required. The Parameter resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Parameter resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A mutable field will be overwritten if it is in the
        /// mask. If the user does not provide a mask then all mutable fields present
        /// in the request will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Parameter> UpdateParameterAsync(Parameter parameter, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateParameterAsync(new UpdateParameterRequest
            {
                UpdateMask = updateMask,
                Parameter = gax::GaxPreconditions.CheckNotNull(parameter, nameof(parameter)),
            }, callSettings);

        /// <summary>
        /// Updates a single Parameter.
        /// </summary>
        /// <param name="parameter">
        /// Required. The Parameter resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Parameter resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A mutable field will be overwritten if it is in the
        /// mask. If the user does not provide a mask then all mutable fields present
        /// in the request will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Parameter> UpdateParameterAsync(Parameter parameter, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateParameterAsync(parameter, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Parameter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteParameter(DeleteParameterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Parameter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteParameterAsync(DeleteParameterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Parameter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteParameterAsync(DeleteParameterRequest request, st::CancellationToken cancellationToken) =>
            DeleteParameterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Parameter.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/parameters/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteParameter(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteParameter(new DeleteParameterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Parameter.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/parameters/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteParameterAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteParameterAsync(new DeleteParameterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Parameter.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/parameters/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteParameterAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteParameterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Parameter.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/parameters/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteParameter(ParameterName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteParameter(new DeleteParameterRequest
            {
                ParameterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Parameter.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/parameters/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteParameterAsync(ParameterName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteParameterAsync(new DeleteParameterRequest
            {
                ParameterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Parameter.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/parameters/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteParameterAsync(ParameterName name, st::CancellationToken cancellationToken) =>
            DeleteParameterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists ParameterVersions in a given project, location, and parameter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ParameterVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListParameterVersionsResponse, ParameterVersion> ListParameterVersions(ListParameterVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ParameterVersions in a given project, location, and parameter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ParameterVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListParameterVersionsResponse, ParameterVersion> ListParameterVersionsAsync(ListParameterVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ParameterVersions in a given project, location, and parameter.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListParameterVersionsRequest in the format
        /// `projects/*/locations/*/parameters/*`.
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
        /// <returns>A pageable sequence of <see cref="ParameterVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListParameterVersionsResponse, ParameterVersion> ListParameterVersions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListParameterVersionsRequest request = new ListParameterVersionsRequest
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
            return ListParameterVersions(request, callSettings);
        }

        /// <summary>
        /// Lists ParameterVersions in a given project, location, and parameter.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListParameterVersionsRequest in the format
        /// `projects/*/locations/*/parameters/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ParameterVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListParameterVersionsResponse, ParameterVersion> ListParameterVersionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListParameterVersionsRequest request = new ListParameterVersionsRequest
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
            return ListParameterVersionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists ParameterVersions in a given project, location, and parameter.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListParameterVersionsRequest in the format
        /// `projects/*/locations/*/parameters/*`.
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
        /// <returns>A pageable sequence of <see cref="ParameterVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListParameterVersionsResponse, ParameterVersion> ListParameterVersions(ParameterName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListParameterVersionsRequest request = new ListParameterVersionsRequest
            {
                ParentAsParameterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListParameterVersions(request, callSettings);
        }

        /// <summary>
        /// Lists ParameterVersions in a given project, location, and parameter.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListParameterVersionsRequest in the format
        /// `projects/*/locations/*/parameters/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ParameterVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListParameterVersionsResponse, ParameterVersion> ListParameterVersionsAsync(ParameterName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListParameterVersionsRequest request = new ListParameterVersionsRequest
            {
                ParentAsParameterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListParameterVersionsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ParameterVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ParameterVersion GetParameterVersion(GetParameterVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ParameterVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ParameterVersion> GetParameterVersionAsync(GetParameterVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ParameterVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ParameterVersion> GetParameterVersionAsync(GetParameterVersionRequest request, st::CancellationToken cancellationToken) =>
            GetParameterVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ParameterVersion.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/parameters/*/versions/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ParameterVersion GetParameterVersion(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetParameterVersion(new GetParameterVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ParameterVersion.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/parameters/*/versions/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ParameterVersion> GetParameterVersionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetParameterVersionAsync(new GetParameterVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ParameterVersion.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/parameters/*/versions/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ParameterVersion> GetParameterVersionAsync(string name, st::CancellationToken cancellationToken) =>
            GetParameterVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ParameterVersion.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/parameters/*/versions/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ParameterVersion GetParameterVersion(ParameterVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetParameterVersion(new GetParameterVersionRequest
            {
                ParameterVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ParameterVersion.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/parameters/*/versions/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ParameterVersion> GetParameterVersionAsync(ParameterVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetParameterVersionAsync(new GetParameterVersionRequest
            {
                ParameterVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ParameterVersion.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/parameters/*/versions/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ParameterVersion> GetParameterVersionAsync(ParameterVersionName name, st::CancellationToken cancellationToken) =>
            GetParameterVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets rendered version of a ParameterVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RenderParameterVersionResponse RenderParameterVersion(RenderParameterVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets rendered version of a ParameterVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RenderParameterVersionResponse> RenderParameterVersionAsync(RenderParameterVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets rendered version of a ParameterVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RenderParameterVersionResponse> RenderParameterVersionAsync(RenderParameterVersionRequest request, st::CancellationToken cancellationToken) =>
            RenderParameterVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets rendered version of a ParameterVersion.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RenderParameterVersionResponse RenderParameterVersion(string name, gaxgrpc::CallSettings callSettings = null) =>
            RenderParameterVersion(new RenderParameterVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets rendered version of a ParameterVersion.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RenderParameterVersionResponse> RenderParameterVersionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            RenderParameterVersionAsync(new RenderParameterVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets rendered version of a ParameterVersion.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RenderParameterVersionResponse> RenderParameterVersionAsync(string name, st::CancellationToken cancellationToken) =>
            RenderParameterVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets rendered version of a ParameterVersion.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RenderParameterVersionResponse RenderParameterVersion(ParameterVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            RenderParameterVersion(new RenderParameterVersionRequest
            {
                ParameterVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets rendered version of a ParameterVersion.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RenderParameterVersionResponse> RenderParameterVersionAsync(ParameterVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            RenderParameterVersionAsync(new RenderParameterVersionRequest
            {
                ParameterVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets rendered version of a ParameterVersion.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RenderParameterVersionResponse> RenderParameterVersionAsync(ParameterVersionName name, st::CancellationToken cancellationToken) =>
            RenderParameterVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ParameterVersion in a given project, location, and parameter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ParameterVersion CreateParameterVersion(CreateParameterVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ParameterVersion in a given project, location, and parameter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ParameterVersion> CreateParameterVersionAsync(CreateParameterVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ParameterVersion in a given project, location, and parameter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ParameterVersion> CreateParameterVersionAsync(CreateParameterVersionRequest request, st::CancellationToken cancellationToken) =>
            CreateParameterVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ParameterVersion in a given project, location, and parameter.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent in the format
        /// `projects/*/locations/*/parameters/*`.
        /// </param>
        /// <param name="parameterVersion">
        /// Required. The ParameterVersion resource being created
        /// </param>
        /// <param name="parameterVersionId">
        /// Required. Id of the ParameterVersion resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ParameterVersion CreateParameterVersion(string parent, ParameterVersion parameterVersion, string parameterVersionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateParameterVersion(new CreateParameterVersionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ParameterVersionId = gax::GaxPreconditions.CheckNotNullOrEmpty(parameterVersionId, nameof(parameterVersionId)),
                ParameterVersion = gax::GaxPreconditions.CheckNotNull(parameterVersion, nameof(parameterVersion)),
            }, callSettings);

        /// <summary>
        /// Creates a new ParameterVersion in a given project, location, and parameter.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent in the format
        /// `projects/*/locations/*/parameters/*`.
        /// </param>
        /// <param name="parameterVersion">
        /// Required. The ParameterVersion resource being created
        /// </param>
        /// <param name="parameterVersionId">
        /// Required. Id of the ParameterVersion resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ParameterVersion> CreateParameterVersionAsync(string parent, ParameterVersion parameterVersion, string parameterVersionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateParameterVersionAsync(new CreateParameterVersionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ParameterVersionId = gax::GaxPreconditions.CheckNotNullOrEmpty(parameterVersionId, nameof(parameterVersionId)),
                ParameterVersion = gax::GaxPreconditions.CheckNotNull(parameterVersion, nameof(parameterVersion)),
            }, callSettings);

        /// <summary>
        /// Creates a new ParameterVersion in a given project, location, and parameter.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent in the format
        /// `projects/*/locations/*/parameters/*`.
        /// </param>
        /// <param name="parameterVersion">
        /// Required. The ParameterVersion resource being created
        /// </param>
        /// <param name="parameterVersionId">
        /// Required. Id of the ParameterVersion resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ParameterVersion> CreateParameterVersionAsync(string parent, ParameterVersion parameterVersion, string parameterVersionId, st::CancellationToken cancellationToken) =>
            CreateParameterVersionAsync(parent, parameterVersion, parameterVersionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ParameterVersion in a given project, location, and parameter.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent in the format
        /// `projects/*/locations/*/parameters/*`.
        /// </param>
        /// <param name="parameterVersion">
        /// Required. The ParameterVersion resource being created
        /// </param>
        /// <param name="parameterVersionId">
        /// Required. Id of the ParameterVersion resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ParameterVersion CreateParameterVersion(ParameterName parent, ParameterVersion parameterVersion, string parameterVersionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateParameterVersion(new CreateParameterVersionRequest
            {
                ParentAsParameterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ParameterVersionId = gax::GaxPreconditions.CheckNotNullOrEmpty(parameterVersionId, nameof(parameterVersionId)),
                ParameterVersion = gax::GaxPreconditions.CheckNotNull(parameterVersion, nameof(parameterVersion)),
            }, callSettings);

        /// <summary>
        /// Creates a new ParameterVersion in a given project, location, and parameter.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent in the format
        /// `projects/*/locations/*/parameters/*`.
        /// </param>
        /// <param name="parameterVersion">
        /// Required. The ParameterVersion resource being created
        /// </param>
        /// <param name="parameterVersionId">
        /// Required. Id of the ParameterVersion resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ParameterVersion> CreateParameterVersionAsync(ParameterName parent, ParameterVersion parameterVersion, string parameterVersionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateParameterVersionAsync(new CreateParameterVersionRequest
            {
                ParentAsParameterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ParameterVersionId = gax::GaxPreconditions.CheckNotNullOrEmpty(parameterVersionId, nameof(parameterVersionId)),
                ParameterVersion = gax::GaxPreconditions.CheckNotNull(parameterVersion, nameof(parameterVersion)),
            }, callSettings);

        /// <summary>
        /// Creates a new ParameterVersion in a given project, location, and parameter.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent in the format
        /// `projects/*/locations/*/parameters/*`.
        /// </param>
        /// <param name="parameterVersion">
        /// Required. The ParameterVersion resource being created
        /// </param>
        /// <param name="parameterVersionId">
        /// Required. Id of the ParameterVersion resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ParameterVersion> CreateParameterVersionAsync(ParameterName parent, ParameterVersion parameterVersion, string parameterVersionId, st::CancellationToken cancellationToken) =>
            CreateParameterVersionAsync(parent, parameterVersion, parameterVersionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a single ParameterVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ParameterVersion UpdateParameterVersion(UpdateParameterVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a single ParameterVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ParameterVersion> UpdateParameterVersionAsync(UpdateParameterVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a single ParameterVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ParameterVersion> UpdateParameterVersionAsync(UpdateParameterVersionRequest request, st::CancellationToken cancellationToken) =>
            UpdateParameterVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a single ParameterVersion.
        /// </summary>
        /// <param name="parameterVersion">
        /// Required. The ParameterVersion resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// ParameterVersion resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A mutable field will be overwritten if it is in the
        /// mask. If the user does not provide a mask then all mutable fields present
        /// in the request will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ParameterVersion UpdateParameterVersion(ParameterVersion parameterVersion, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateParameterVersion(new UpdateParameterVersionRequest
            {
                UpdateMask = updateMask,
                ParameterVersion = gax::GaxPreconditions.CheckNotNull(parameterVersion, nameof(parameterVersion)),
            }, callSettings);

        /// <summary>
        /// Updates a single ParameterVersion.
        /// </summary>
        /// <param name="parameterVersion">
        /// Required. The ParameterVersion resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// ParameterVersion resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A mutable field will be overwritten if it is in the
        /// mask. If the user does not provide a mask then all mutable fields present
        /// in the request will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ParameterVersion> UpdateParameterVersionAsync(ParameterVersion parameterVersion, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateParameterVersionAsync(new UpdateParameterVersionRequest
            {
                UpdateMask = updateMask,
                ParameterVersion = gax::GaxPreconditions.CheckNotNull(parameterVersion, nameof(parameterVersion)),
            }, callSettings);

        /// <summary>
        /// Updates a single ParameterVersion.
        /// </summary>
        /// <param name="parameterVersion">
        /// Required. The ParameterVersion resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// ParameterVersion resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A mutable field will be overwritten if it is in the
        /// mask. If the user does not provide a mask then all mutable fields present
        /// in the request will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ParameterVersion> UpdateParameterVersionAsync(ParameterVersion parameterVersion, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateParameterVersionAsync(parameterVersion, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ParameterVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteParameterVersion(DeleteParameterVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ParameterVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteParameterVersionAsync(DeleteParameterVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ParameterVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteParameterVersionAsync(DeleteParameterVersionRequest request, st::CancellationToken cancellationToken) =>
            DeleteParameterVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ParameterVersion.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/parameters/*/versions/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteParameterVersion(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteParameterVersion(new DeleteParameterVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ParameterVersion.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/parameters/*/versions/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteParameterVersionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteParameterVersionAsync(new DeleteParameterVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ParameterVersion.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/parameters/*/versions/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteParameterVersionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteParameterVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ParameterVersion.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/parameters/*/versions/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteParameterVersion(ParameterVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteParameterVersion(new DeleteParameterVersionRequest
            {
                ParameterVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ParameterVersion.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/parameters/*/versions/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteParameterVersionAsync(ParameterVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteParameterVersionAsync(new DeleteParameterVersionRequest
            {
                ParameterVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ParameterVersion.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/parameters/*/versions/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteParameterVersionAsync(ParameterVersionName name, st::CancellationToken cancellationToken) =>
            DeleteParameterVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Templates in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Template"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTemplatesResponse, Template> ListTemplates(ListTemplatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Templates in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Template"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTemplatesResponse, Template> ListTemplatesAsync(ListTemplatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Templates in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListTemplatesRequest in the format
        /// `projects/*/locations/*`.
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
        /// <returns>A pageable sequence of <see cref="Template"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTemplatesResponse, Template> ListTemplates(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTemplatesRequest request = new ListTemplatesRequest
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
            return ListTemplates(request, callSettings);
        }

        /// <summary>
        /// Lists Templates in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListTemplatesRequest in the format
        /// `projects/*/locations/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Template"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTemplatesResponse, Template> ListTemplatesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTemplatesRequest request = new ListTemplatesRequest
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
            return ListTemplatesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Templates in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListTemplatesRequest in the format
        /// `projects/*/locations/*`.
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
        /// <returns>A pageable sequence of <see cref="Template"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTemplatesResponse, Template> ListTemplates(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTemplatesRequest request = new ListTemplatesRequest
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
            return ListTemplates(request, callSettings);
        }

        /// <summary>
        /// Lists Templates in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListTemplatesRequest in the format
        /// `projects/*/locations/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Template"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTemplatesResponse, Template> ListTemplatesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTemplatesRequest request = new ListTemplatesRequest
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
            return ListTemplatesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Template GetTemplate(GetTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Template> GetTemplateAsync(GetTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Template> GetTemplateAsync(GetTemplateRequest request, st::CancellationToken cancellationToken) =>
            GetTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Template.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/templates/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Template GetTemplate(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTemplate(new GetTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Template.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/templates/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Template> GetTemplateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTemplateAsync(new GetTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Template.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/templates/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Template> GetTemplateAsync(string name, st::CancellationToken cancellationToken) =>
            GetTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Template.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/templates/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Template GetTemplate(TemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTemplate(new GetTemplateRequest
            {
                TemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Template.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/templates/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Template> GetTemplateAsync(TemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTemplateAsync(new GetTemplateRequest
            {
                TemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Template.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/templates/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Template> GetTemplateAsync(TemplateName name, st::CancellationToken cancellationToken) =>
            GetTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Template in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Template CreateTemplate(CreateTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Template in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Template> CreateTemplateAsync(CreateTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Template in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Template> CreateTemplateAsync(CreateTemplateRequest request, st::CancellationToken cancellationToken) =>
            CreateTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Template in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="template">
        /// Required. The Template resource being created
        /// </param>
        /// <param name="templateId">
        /// Required. Id of the Template resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Template CreateTemplate(string parent, Template template, string templateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTemplate(new CreateTemplateRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TemplateId = gax::GaxPreconditions.CheckNotNullOrEmpty(templateId, nameof(templateId)),
                Template = gax::GaxPreconditions.CheckNotNull(template, nameof(template)),
            }, callSettings);

        /// <summary>
        /// Creates a new Template in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="template">
        /// Required. The Template resource being created
        /// </param>
        /// <param name="templateId">
        /// Required. Id of the Template resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Template> CreateTemplateAsync(string parent, Template template, string templateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTemplateAsync(new CreateTemplateRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TemplateId = gax::GaxPreconditions.CheckNotNullOrEmpty(templateId, nameof(templateId)),
                Template = gax::GaxPreconditions.CheckNotNull(template, nameof(template)),
            }, callSettings);

        /// <summary>
        /// Creates a new Template in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="template">
        /// Required. The Template resource being created
        /// </param>
        /// <param name="templateId">
        /// Required. Id of the Template resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Template> CreateTemplateAsync(string parent, Template template, string templateId, st::CancellationToken cancellationToken) =>
            CreateTemplateAsync(parent, template, templateId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Template in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="template">
        /// Required. The Template resource being created
        /// </param>
        /// <param name="templateId">
        /// Required. Id of the Template resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Template CreateTemplate(gagr::LocationName parent, Template template, string templateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTemplate(new CreateTemplateRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TemplateId = gax::GaxPreconditions.CheckNotNullOrEmpty(templateId, nameof(templateId)),
                Template = gax::GaxPreconditions.CheckNotNull(template, nameof(template)),
            }, callSettings);

        /// <summary>
        /// Creates a new Template in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="template">
        /// Required. The Template resource being created
        /// </param>
        /// <param name="templateId">
        /// Required. Id of the Template resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Template> CreateTemplateAsync(gagr::LocationName parent, Template template, string templateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTemplateAsync(new CreateTemplateRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TemplateId = gax::GaxPreconditions.CheckNotNullOrEmpty(templateId, nameof(templateId)),
                Template = gax::GaxPreconditions.CheckNotNull(template, nameof(template)),
            }, callSettings);

        /// <summary>
        /// Creates a new Template in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="template">
        /// Required. The Template resource being created
        /// </param>
        /// <param name="templateId">
        /// Required. Id of the Template resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Template> CreateTemplateAsync(gagr::LocationName parent, Template template, string templateId, st::CancellationToken cancellationToken) =>
            CreateTemplateAsync(parent, template, templateId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a single Template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Template UpdateTemplate(UpdateTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a single Template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Template> UpdateTemplateAsync(UpdateTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a single Template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Template> UpdateTemplateAsync(UpdateTemplateRequest request, st::CancellationToken cancellationToken) =>
            UpdateTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a single Template.
        /// </summary>
        /// <param name="template">
        /// Required. The Template resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Template resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A mutable field will be overwritten if it is in the
        /// mask. If the user does not provide a mask then all mutable fields present
        /// in the request will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Template UpdateTemplate(Template template, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTemplate(new UpdateTemplateRequest
            {
                UpdateMask = updateMask,
                Template = gax::GaxPreconditions.CheckNotNull(template, nameof(template)),
            }, callSettings);

        /// <summary>
        /// Updates a single Template.
        /// </summary>
        /// <param name="template">
        /// Required. The Template resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Template resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A mutable field will be overwritten if it is in the
        /// mask. If the user does not provide a mask then all mutable fields present
        /// in the request will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Template> UpdateTemplateAsync(Template template, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTemplateAsync(new UpdateTemplateRequest
            {
                UpdateMask = updateMask,
                Template = gax::GaxPreconditions.CheckNotNull(template, nameof(template)),
            }, callSettings);

        /// <summary>
        /// Updates a single Template.
        /// </summary>
        /// <param name="template">
        /// Required. The Template resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Template resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A mutable field will be overwritten if it is in the
        /// mask. If the user does not provide a mask then all mutable fields present
        /// in the request will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Template> UpdateTemplateAsync(Template template, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateTemplateAsync(template, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTemplate(DeleteTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTemplateAsync(DeleteTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTemplateAsync(DeleteTemplateRequest request, st::CancellationToken cancellationToken) =>
            DeleteTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Template.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/templates/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTemplate(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTemplate(new DeleteTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Template.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/templates/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTemplateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTemplateAsync(new DeleteTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Template.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/templates/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTemplateAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Template.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/templates/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTemplate(TemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTemplate(new DeleteTemplateRequest
            {
                TemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Template.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/templates/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTemplateAsync(TemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTemplateAsync(new DeleteTemplateRequest
            {
                TemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Template.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/templates/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTemplateAsync(TemplateName name, st::CancellationToken cancellationToken) =>
            DeleteTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists TemplateVersions in a given project, location, and template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TemplateVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTemplateVersionsResponse, TemplateVersion> ListTemplateVersions(ListTemplateVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists TemplateVersions in a given project, location, and template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TemplateVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTemplateVersionsResponse, TemplateVersion> ListTemplateVersionsAsync(ListTemplateVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists TemplateVersions in a given project, location, and template.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListTemplateVersionsRequest in the format
        /// `projects/*/locations/*/templates/*`.
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
        /// <returns>A pageable sequence of <see cref="TemplateVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTemplateVersionsResponse, TemplateVersion> ListTemplateVersions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTemplateVersionsRequest request = new ListTemplateVersionsRequest
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
            return ListTemplateVersions(request, callSettings);
        }

        /// <summary>
        /// Lists TemplateVersions in a given project, location, and template.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListTemplateVersionsRequest in the format
        /// `projects/*/locations/*/templates/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TemplateVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTemplateVersionsResponse, TemplateVersion> ListTemplateVersionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTemplateVersionsRequest request = new ListTemplateVersionsRequest
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
            return ListTemplateVersionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists TemplateVersions in a given project, location, and template.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListTemplateVersionsRequest in the format
        /// `projects/*/locations/*/templates/*`.
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
        /// <returns>A pageable sequence of <see cref="TemplateVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTemplateVersionsResponse, TemplateVersion> ListTemplateVersions(TemplateName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTemplateVersionsRequest request = new ListTemplateVersionsRequest
            {
                ParentAsTemplateName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTemplateVersions(request, callSettings);
        }

        /// <summary>
        /// Lists TemplateVersions in a given project, location, and template.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListTemplateVersionsRequest in the format
        /// `projects/*/locations/*/templates/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TemplateVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTemplateVersionsResponse, TemplateVersion> ListTemplateVersionsAsync(TemplateName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTemplateVersionsRequest request = new ListTemplateVersionsRequest
            {
                ParentAsTemplateName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTemplateVersionsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single TemplateVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TemplateVersion GetTemplateVersion(GetTemplateVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single TemplateVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TemplateVersion> GetTemplateVersionAsync(GetTemplateVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single TemplateVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TemplateVersion> GetTemplateVersionAsync(GetTemplateVersionRequest request, st::CancellationToken cancellationToken) =>
            GetTemplateVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single TemplateVersion.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/templates/*/versions/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TemplateVersion GetTemplateVersion(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTemplateVersion(new GetTemplateVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single TemplateVersion.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/templates/*/versions/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TemplateVersion> GetTemplateVersionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTemplateVersionAsync(new GetTemplateVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single TemplateVersion.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/templates/*/versions/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TemplateVersion> GetTemplateVersionAsync(string name, st::CancellationToken cancellationToken) =>
            GetTemplateVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single TemplateVersion.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/templates/*/versions/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TemplateVersion GetTemplateVersion(TemplateVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTemplateVersion(new GetTemplateVersionRequest
            {
                TemplateVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single TemplateVersion.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/templates/*/versions/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TemplateVersion> GetTemplateVersionAsync(TemplateVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTemplateVersionAsync(new GetTemplateVersionRequest
            {
                TemplateVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single TemplateVersion.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/templates/*/versions/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TemplateVersion> GetTemplateVersionAsync(TemplateVersionName name, st::CancellationToken cancellationToken) =>
            GetTemplateVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new TemplateVersion in a given project, location, and template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TemplateVersion CreateTemplateVersion(CreateTemplateVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new TemplateVersion in a given project, location, and template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TemplateVersion> CreateTemplateVersionAsync(CreateTemplateVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new TemplateVersion in a given project, location, and template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TemplateVersion> CreateTemplateVersionAsync(CreateTemplateVersionRequest request, st::CancellationToken cancellationToken) =>
            CreateTemplateVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new TemplateVersion in a given project, location, and template.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent in the format
        /// `projects/*/locations/*/templates/*`.
        /// </param>
        /// <param name="templateVersion">
        /// Required. The TemplateVersion resource being created
        /// </param>
        /// <param name="templateVersionId">
        /// Required. Id of the TemplateVersion resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TemplateVersion CreateTemplateVersion(string parent, TemplateVersion templateVersion, string templateVersionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTemplateVersion(new CreateTemplateVersionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TemplateVersionId = gax::GaxPreconditions.CheckNotNullOrEmpty(templateVersionId, nameof(templateVersionId)),
                TemplateVersion = gax::GaxPreconditions.CheckNotNull(templateVersion, nameof(templateVersion)),
            }, callSettings);

        /// <summary>
        /// Creates a new TemplateVersion in a given project, location, and template.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent in the format
        /// `projects/*/locations/*/templates/*`.
        /// </param>
        /// <param name="templateVersion">
        /// Required. The TemplateVersion resource being created
        /// </param>
        /// <param name="templateVersionId">
        /// Required. Id of the TemplateVersion resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TemplateVersion> CreateTemplateVersionAsync(string parent, TemplateVersion templateVersion, string templateVersionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTemplateVersionAsync(new CreateTemplateVersionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TemplateVersionId = gax::GaxPreconditions.CheckNotNullOrEmpty(templateVersionId, nameof(templateVersionId)),
                TemplateVersion = gax::GaxPreconditions.CheckNotNull(templateVersion, nameof(templateVersion)),
            }, callSettings);

        /// <summary>
        /// Creates a new TemplateVersion in a given project, location, and template.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent in the format
        /// `projects/*/locations/*/templates/*`.
        /// </param>
        /// <param name="templateVersion">
        /// Required. The TemplateVersion resource being created
        /// </param>
        /// <param name="templateVersionId">
        /// Required. Id of the TemplateVersion resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TemplateVersion> CreateTemplateVersionAsync(string parent, TemplateVersion templateVersion, string templateVersionId, st::CancellationToken cancellationToken) =>
            CreateTemplateVersionAsync(parent, templateVersion, templateVersionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new TemplateVersion in a given project, location, and template.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent in the format
        /// `projects/*/locations/*/templates/*`.
        /// </param>
        /// <param name="templateVersion">
        /// Required. The TemplateVersion resource being created
        /// </param>
        /// <param name="templateVersionId">
        /// Required. Id of the TemplateVersion resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TemplateVersion CreateTemplateVersion(TemplateName parent, TemplateVersion templateVersion, string templateVersionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTemplateVersion(new CreateTemplateVersionRequest
            {
                ParentAsTemplateName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TemplateVersionId = gax::GaxPreconditions.CheckNotNullOrEmpty(templateVersionId, nameof(templateVersionId)),
                TemplateVersion = gax::GaxPreconditions.CheckNotNull(templateVersion, nameof(templateVersion)),
            }, callSettings);

        /// <summary>
        /// Creates a new TemplateVersion in a given project, location, and template.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent in the format
        /// `projects/*/locations/*/templates/*`.
        /// </param>
        /// <param name="templateVersion">
        /// Required. The TemplateVersion resource being created
        /// </param>
        /// <param name="templateVersionId">
        /// Required. Id of the TemplateVersion resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TemplateVersion> CreateTemplateVersionAsync(TemplateName parent, TemplateVersion templateVersion, string templateVersionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTemplateVersionAsync(new CreateTemplateVersionRequest
            {
                ParentAsTemplateName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TemplateVersionId = gax::GaxPreconditions.CheckNotNullOrEmpty(templateVersionId, nameof(templateVersionId)),
                TemplateVersion = gax::GaxPreconditions.CheckNotNull(templateVersion, nameof(templateVersion)),
            }, callSettings);

        /// <summary>
        /// Creates a new TemplateVersion in a given project, location, and template.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent in the format
        /// `projects/*/locations/*/templates/*`.
        /// </param>
        /// <param name="templateVersion">
        /// Required. The TemplateVersion resource being created
        /// </param>
        /// <param name="templateVersionId">
        /// Required. Id of the TemplateVersion resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TemplateVersion> CreateTemplateVersionAsync(TemplateName parent, TemplateVersion templateVersion, string templateVersionId, st::CancellationToken cancellationToken) =>
            CreateTemplateVersionAsync(parent, templateVersion, templateVersionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a single TemplateVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TemplateVersion UpdateTemplateVersion(UpdateTemplateVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a single TemplateVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TemplateVersion> UpdateTemplateVersionAsync(UpdateTemplateVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a single TemplateVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TemplateVersion> UpdateTemplateVersionAsync(UpdateTemplateVersionRequest request, st::CancellationToken cancellationToken) =>
            UpdateTemplateVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a single TemplateVersion.
        /// </summary>
        /// <param name="templateVersion">
        /// Required. The TemplateVersion resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// TemplateVersion resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A mutable field will be overwritten if it is in the
        /// mask. If the user does not provide a mask then all mutable fields present
        /// in the request will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TemplateVersion UpdateTemplateVersion(TemplateVersion templateVersion, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTemplateVersion(new UpdateTemplateVersionRequest
            {
                UpdateMask = updateMask,
                TemplateVersion = gax::GaxPreconditions.CheckNotNull(templateVersion, nameof(templateVersion)),
            }, callSettings);

        /// <summary>
        /// Updates a single TemplateVersion.
        /// </summary>
        /// <param name="templateVersion">
        /// Required. The TemplateVersion resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// TemplateVersion resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A mutable field will be overwritten if it is in the
        /// mask. If the user does not provide a mask then all mutable fields present
        /// in the request will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TemplateVersion> UpdateTemplateVersionAsync(TemplateVersion templateVersion, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTemplateVersionAsync(new UpdateTemplateVersionRequest
            {
                UpdateMask = updateMask,
                TemplateVersion = gax::GaxPreconditions.CheckNotNull(templateVersion, nameof(templateVersion)),
            }, callSettings);

        /// <summary>
        /// Updates a single TemplateVersion.
        /// </summary>
        /// <param name="templateVersion">
        /// Required. The TemplateVersion resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// TemplateVersion resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A mutable field will be overwritten if it is in the
        /// mask. If the user does not provide a mask then all mutable fields present
        /// in the request will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TemplateVersion> UpdateTemplateVersionAsync(TemplateVersion templateVersion, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateTemplateVersionAsync(templateVersion, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single TemplateVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTemplateVersion(DeleteTemplateVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single TemplateVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTemplateVersionAsync(DeleteTemplateVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single TemplateVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTemplateVersionAsync(DeleteTemplateVersionRequest request, st::CancellationToken cancellationToken) =>
            DeleteTemplateVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single TemplateVersion.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/templates/*/versions/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTemplateVersion(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTemplateVersion(new DeleteTemplateVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single TemplateVersion.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/templates/*/versions/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTemplateVersionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTemplateVersionAsync(new DeleteTemplateVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single TemplateVersion.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/templates/*/versions/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTemplateVersionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteTemplateVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single TemplateVersion.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/templates/*/versions/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTemplateVersion(TemplateVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTemplateVersion(new DeleteTemplateVersionRequest
            {
                TemplateVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single TemplateVersion.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/templates/*/versions/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTemplateVersionAsync(TemplateVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTemplateVersionAsync(new DeleteTemplateVersionRequest
            {
                TemplateVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single TemplateVersion.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource in the format
        /// `projects/*/locations/*/templates/*/versions/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTemplateVersionAsync(TemplateVersionName name, st::CancellationToken cancellationToken) =>
            DeleteTemplateVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets rendered version of a TemplateVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RenderTemplateVersionResponse RenderTemplateVersion(RenderTemplateVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets rendered version of a TemplateVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RenderTemplateVersionResponse> RenderTemplateVersionAsync(RenderTemplateVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets rendered version of a TemplateVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RenderTemplateVersionResponse> RenderTemplateVersionAsync(RenderTemplateVersionRequest request, st::CancellationToken cancellationToken) =>
            RenderTemplateVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets rendered version of a TemplateVersion.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RenderTemplateVersionResponse RenderTemplateVersion(string name, gaxgrpc::CallSettings callSettings = null) =>
            RenderTemplateVersion(new RenderTemplateVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets rendered version of a TemplateVersion.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RenderTemplateVersionResponse> RenderTemplateVersionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            RenderTemplateVersionAsync(new RenderTemplateVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets rendered version of a TemplateVersion.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RenderTemplateVersionResponse> RenderTemplateVersionAsync(string name, st::CancellationToken cancellationToken) =>
            RenderTemplateVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets rendered version of a TemplateVersion.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RenderTemplateVersionResponse RenderTemplateVersion(TemplateVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            RenderTemplateVersion(new RenderTemplateVersionRequest
            {
                TemplateVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets rendered version of a TemplateVersion.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RenderTemplateVersionResponse> RenderTemplateVersionAsync(TemplateVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            RenderTemplateVersionAsync(new RenderTemplateVersionRequest
            {
                TemplateVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets rendered version of a TemplateVersion.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RenderTemplateVersionResponse> RenderTemplateVersionAsync(TemplateVersionName name, st::CancellationToken cancellationToken) =>
            RenderTemplateVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ParameterManager client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public sealed partial class ParameterManagerClientImpl : ParameterManagerClient
    {
        private readonly gaxgrpc::ApiCall<ListParametersRequest, ListParametersResponse> _callListParameters;

        private readonly gaxgrpc::ApiCall<GetParameterRequest, Parameter> _callGetParameter;

        private readonly gaxgrpc::ApiCall<CreateParameterRequest, Parameter> _callCreateParameter;

        private readonly gaxgrpc::ApiCall<UpdateParameterRequest, Parameter> _callUpdateParameter;

        private readonly gaxgrpc::ApiCall<DeleteParameterRequest, wkt::Empty> _callDeleteParameter;

        private readonly gaxgrpc::ApiCall<ListParameterVersionsRequest, ListParameterVersionsResponse> _callListParameterVersions;

        private readonly gaxgrpc::ApiCall<GetParameterVersionRequest, ParameterVersion> _callGetParameterVersion;

        private readonly gaxgrpc::ApiCall<RenderParameterVersionRequest, RenderParameterVersionResponse> _callRenderParameterVersion;

        private readonly gaxgrpc::ApiCall<CreateParameterVersionRequest, ParameterVersion> _callCreateParameterVersion;

        private readonly gaxgrpc::ApiCall<UpdateParameterVersionRequest, ParameterVersion> _callUpdateParameterVersion;

        private readonly gaxgrpc::ApiCall<DeleteParameterVersionRequest, wkt::Empty> _callDeleteParameterVersion;

        private readonly gaxgrpc::ApiCall<ListTemplatesRequest, ListTemplatesResponse> _callListTemplates;

        private readonly gaxgrpc::ApiCall<GetTemplateRequest, Template> _callGetTemplate;

        private readonly gaxgrpc::ApiCall<CreateTemplateRequest, Template> _callCreateTemplate;

        private readonly gaxgrpc::ApiCall<UpdateTemplateRequest, Template> _callUpdateTemplate;

        private readonly gaxgrpc::ApiCall<DeleteTemplateRequest, wkt::Empty> _callDeleteTemplate;

        private readonly gaxgrpc::ApiCall<ListTemplateVersionsRequest, ListTemplateVersionsResponse> _callListTemplateVersions;

        private readonly gaxgrpc::ApiCall<GetTemplateVersionRequest, TemplateVersion> _callGetTemplateVersion;

        private readonly gaxgrpc::ApiCall<CreateTemplateVersionRequest, TemplateVersion> _callCreateTemplateVersion;

        private readonly gaxgrpc::ApiCall<UpdateTemplateVersionRequest, TemplateVersion> _callUpdateTemplateVersion;

        private readonly gaxgrpc::ApiCall<DeleteTemplateVersionRequest, wkt::Empty> _callDeleteTemplateVersion;

        private readonly gaxgrpc::ApiCall<RenderTemplateVersionRequest, RenderTemplateVersionResponse> _callRenderTemplateVersion;

        /// <summary>
        /// Constructs a client wrapper for the ParameterManager service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ParameterManagerSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ParameterManagerClientImpl(ParameterManager.ParameterManagerClient grpcClient, ParameterManagerSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ParameterManagerSettings effectiveSettings = settings ?? ParameterManagerSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListParameters = clientHelper.BuildApiCall<ListParametersRequest, ListParametersResponse>("ListParameters", grpcClient.ListParametersAsync, grpcClient.ListParameters, effectiveSettings.ListParametersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListParameters);
            Modify_ListParametersApiCall(ref _callListParameters);
            _callGetParameter = clientHelper.BuildApiCall<GetParameterRequest, Parameter>("GetParameter", grpcClient.GetParameterAsync, grpcClient.GetParameter, effectiveSettings.GetParameterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetParameter);
            Modify_GetParameterApiCall(ref _callGetParameter);
            _callCreateParameter = clientHelper.BuildApiCall<CreateParameterRequest, Parameter>("CreateParameter", grpcClient.CreateParameterAsync, grpcClient.CreateParameter, effectiveSettings.CreateParameterSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateParameter);
            Modify_CreateParameterApiCall(ref _callCreateParameter);
            _callUpdateParameter = clientHelper.BuildApiCall<UpdateParameterRequest, Parameter>("UpdateParameter", grpcClient.UpdateParameterAsync, grpcClient.UpdateParameter, effectiveSettings.UpdateParameterSettings).WithGoogleRequestParam("parameter.name", request => request.Parameter?.Name);
            Modify_ApiCall(ref _callUpdateParameter);
            Modify_UpdateParameterApiCall(ref _callUpdateParameter);
            _callDeleteParameter = clientHelper.BuildApiCall<DeleteParameterRequest, wkt::Empty>("DeleteParameter", grpcClient.DeleteParameterAsync, grpcClient.DeleteParameter, effectiveSettings.DeleteParameterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteParameter);
            Modify_DeleteParameterApiCall(ref _callDeleteParameter);
            _callListParameterVersions = clientHelper.BuildApiCall<ListParameterVersionsRequest, ListParameterVersionsResponse>("ListParameterVersions", grpcClient.ListParameterVersionsAsync, grpcClient.ListParameterVersions, effectiveSettings.ListParameterVersionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListParameterVersions);
            Modify_ListParameterVersionsApiCall(ref _callListParameterVersions);
            _callGetParameterVersion = clientHelper.BuildApiCall<GetParameterVersionRequest, ParameterVersion>("GetParameterVersion", grpcClient.GetParameterVersionAsync, grpcClient.GetParameterVersion, effectiveSettings.GetParameterVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetParameterVersion);
            Modify_GetParameterVersionApiCall(ref _callGetParameterVersion);
            _callRenderParameterVersion = clientHelper.BuildApiCall<RenderParameterVersionRequest, RenderParameterVersionResponse>("RenderParameterVersion", grpcClient.RenderParameterVersionAsync, grpcClient.RenderParameterVersion, effectiveSettings.RenderParameterVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRenderParameterVersion);
            Modify_RenderParameterVersionApiCall(ref _callRenderParameterVersion);
            _callCreateParameterVersion = clientHelper.BuildApiCall<CreateParameterVersionRequest, ParameterVersion>("CreateParameterVersion", grpcClient.CreateParameterVersionAsync, grpcClient.CreateParameterVersion, effectiveSettings.CreateParameterVersionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateParameterVersion);
            Modify_CreateParameterVersionApiCall(ref _callCreateParameterVersion);
            _callUpdateParameterVersion = clientHelper.BuildApiCall<UpdateParameterVersionRequest, ParameterVersion>("UpdateParameterVersion", grpcClient.UpdateParameterVersionAsync, grpcClient.UpdateParameterVersion, effectiveSettings.UpdateParameterVersionSettings).WithGoogleRequestParam("parameter_version.name", request => request.ParameterVersion?.Name);
            Modify_ApiCall(ref _callUpdateParameterVersion);
            Modify_UpdateParameterVersionApiCall(ref _callUpdateParameterVersion);
            _callDeleteParameterVersion = clientHelper.BuildApiCall<DeleteParameterVersionRequest, wkt::Empty>("DeleteParameterVersion", grpcClient.DeleteParameterVersionAsync, grpcClient.DeleteParameterVersion, effectiveSettings.DeleteParameterVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteParameterVersion);
            Modify_DeleteParameterVersionApiCall(ref _callDeleteParameterVersion);
            _callListTemplates = clientHelper.BuildApiCall<ListTemplatesRequest, ListTemplatesResponse>("ListTemplates", grpcClient.ListTemplatesAsync, grpcClient.ListTemplates, effectiveSettings.ListTemplatesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTemplates);
            Modify_ListTemplatesApiCall(ref _callListTemplates);
            _callGetTemplate = clientHelper.BuildApiCall<GetTemplateRequest, Template>("GetTemplate", grpcClient.GetTemplateAsync, grpcClient.GetTemplate, effectiveSettings.GetTemplateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTemplate);
            Modify_GetTemplateApiCall(ref _callGetTemplate);
            _callCreateTemplate = clientHelper.BuildApiCall<CreateTemplateRequest, Template>("CreateTemplate", grpcClient.CreateTemplateAsync, grpcClient.CreateTemplate, effectiveSettings.CreateTemplateSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTemplate);
            Modify_CreateTemplateApiCall(ref _callCreateTemplate);
            _callUpdateTemplate = clientHelper.BuildApiCall<UpdateTemplateRequest, Template>("UpdateTemplate", grpcClient.UpdateTemplateAsync, grpcClient.UpdateTemplate, effectiveSettings.UpdateTemplateSettings).WithGoogleRequestParam("template.name", request => request.Template?.Name);
            Modify_ApiCall(ref _callUpdateTemplate);
            Modify_UpdateTemplateApiCall(ref _callUpdateTemplate);
            _callDeleteTemplate = clientHelper.BuildApiCall<DeleteTemplateRequest, wkt::Empty>("DeleteTemplate", grpcClient.DeleteTemplateAsync, grpcClient.DeleteTemplate, effectiveSettings.DeleteTemplateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTemplate);
            Modify_DeleteTemplateApiCall(ref _callDeleteTemplate);
            _callListTemplateVersions = clientHelper.BuildApiCall<ListTemplateVersionsRequest, ListTemplateVersionsResponse>("ListTemplateVersions", grpcClient.ListTemplateVersionsAsync, grpcClient.ListTemplateVersions, effectiveSettings.ListTemplateVersionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTemplateVersions);
            Modify_ListTemplateVersionsApiCall(ref _callListTemplateVersions);
            _callGetTemplateVersion = clientHelper.BuildApiCall<GetTemplateVersionRequest, TemplateVersion>("GetTemplateVersion", grpcClient.GetTemplateVersionAsync, grpcClient.GetTemplateVersion, effectiveSettings.GetTemplateVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTemplateVersion);
            Modify_GetTemplateVersionApiCall(ref _callGetTemplateVersion);
            _callCreateTemplateVersion = clientHelper.BuildApiCall<CreateTemplateVersionRequest, TemplateVersion>("CreateTemplateVersion", grpcClient.CreateTemplateVersionAsync, grpcClient.CreateTemplateVersion, effectiveSettings.CreateTemplateVersionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTemplateVersion);
            Modify_CreateTemplateVersionApiCall(ref _callCreateTemplateVersion);
            _callUpdateTemplateVersion = clientHelper.BuildApiCall<UpdateTemplateVersionRequest, TemplateVersion>("UpdateTemplateVersion", grpcClient.UpdateTemplateVersionAsync, grpcClient.UpdateTemplateVersion, effectiveSettings.UpdateTemplateVersionSettings).WithGoogleRequestParam("template_version.name", request => request.TemplateVersion?.Name);
            Modify_ApiCall(ref _callUpdateTemplateVersion);
            Modify_UpdateTemplateVersionApiCall(ref _callUpdateTemplateVersion);
            _callDeleteTemplateVersion = clientHelper.BuildApiCall<DeleteTemplateVersionRequest, wkt::Empty>("DeleteTemplateVersion", grpcClient.DeleteTemplateVersionAsync, grpcClient.DeleteTemplateVersion, effectiveSettings.DeleteTemplateVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTemplateVersion);
            Modify_DeleteTemplateVersionApiCall(ref _callDeleteTemplateVersion);
            _callRenderTemplateVersion = clientHelper.BuildApiCall<RenderTemplateVersionRequest, RenderTemplateVersionResponse>("RenderTemplateVersion", grpcClient.RenderTemplateVersionAsync, grpcClient.RenderTemplateVersion, effectiveSettings.RenderTemplateVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRenderTemplateVersion);
            Modify_RenderTemplateVersionApiCall(ref _callRenderTemplateVersion);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListParametersApiCall(ref gaxgrpc::ApiCall<ListParametersRequest, ListParametersResponse> call);

        partial void Modify_GetParameterApiCall(ref gaxgrpc::ApiCall<GetParameterRequest, Parameter> call);

        partial void Modify_CreateParameterApiCall(ref gaxgrpc::ApiCall<CreateParameterRequest, Parameter> call);

        partial void Modify_UpdateParameterApiCall(ref gaxgrpc::ApiCall<UpdateParameterRequest, Parameter> call);

        partial void Modify_DeleteParameterApiCall(ref gaxgrpc::ApiCall<DeleteParameterRequest, wkt::Empty> call);

        partial void Modify_ListParameterVersionsApiCall(ref gaxgrpc::ApiCall<ListParameterVersionsRequest, ListParameterVersionsResponse> call);

        partial void Modify_GetParameterVersionApiCall(ref gaxgrpc::ApiCall<GetParameterVersionRequest, ParameterVersion> call);

        partial void Modify_RenderParameterVersionApiCall(ref gaxgrpc::ApiCall<RenderParameterVersionRequest, RenderParameterVersionResponse> call);

        partial void Modify_CreateParameterVersionApiCall(ref gaxgrpc::ApiCall<CreateParameterVersionRequest, ParameterVersion> call);

        partial void Modify_UpdateParameterVersionApiCall(ref gaxgrpc::ApiCall<UpdateParameterVersionRequest, ParameterVersion> call);

        partial void Modify_DeleteParameterVersionApiCall(ref gaxgrpc::ApiCall<DeleteParameterVersionRequest, wkt::Empty> call);

        partial void Modify_ListTemplatesApiCall(ref gaxgrpc::ApiCall<ListTemplatesRequest, ListTemplatesResponse> call);

        partial void Modify_GetTemplateApiCall(ref gaxgrpc::ApiCall<GetTemplateRequest, Template> call);

        partial void Modify_CreateTemplateApiCall(ref gaxgrpc::ApiCall<CreateTemplateRequest, Template> call);

        partial void Modify_UpdateTemplateApiCall(ref gaxgrpc::ApiCall<UpdateTemplateRequest, Template> call);

        partial void Modify_DeleteTemplateApiCall(ref gaxgrpc::ApiCall<DeleteTemplateRequest, wkt::Empty> call);

        partial void Modify_ListTemplateVersionsApiCall(ref gaxgrpc::ApiCall<ListTemplateVersionsRequest, ListTemplateVersionsResponse> call);

        partial void Modify_GetTemplateVersionApiCall(ref gaxgrpc::ApiCall<GetTemplateVersionRequest, TemplateVersion> call);

        partial void Modify_CreateTemplateVersionApiCall(ref gaxgrpc::ApiCall<CreateTemplateVersionRequest, TemplateVersion> call);

        partial void Modify_UpdateTemplateVersionApiCall(ref gaxgrpc::ApiCall<UpdateTemplateVersionRequest, TemplateVersion> call);

        partial void Modify_DeleteTemplateVersionApiCall(ref gaxgrpc::ApiCall<DeleteTemplateVersionRequest, wkt::Empty> call);

        partial void Modify_RenderTemplateVersionApiCall(ref gaxgrpc::ApiCall<RenderTemplateVersionRequest, RenderTemplateVersionResponse> call);

        partial void OnConstruction(ParameterManager.ParameterManagerClient grpcClient, ParameterManagerSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ParameterManager client</summary>
        public override ParameterManager.ParameterManagerClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListParametersRequest(ref ListParametersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetParameterRequest(ref GetParameterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateParameterRequest(ref CreateParameterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateParameterRequest(ref UpdateParameterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteParameterRequest(ref DeleteParameterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListParameterVersionsRequest(ref ListParameterVersionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetParameterVersionRequest(ref GetParameterVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RenderParameterVersionRequest(ref RenderParameterVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateParameterVersionRequest(ref CreateParameterVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateParameterVersionRequest(ref UpdateParameterVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteParameterVersionRequest(ref DeleteParameterVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTemplatesRequest(ref ListTemplatesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTemplateRequest(ref GetTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTemplateRequest(ref CreateTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTemplateRequest(ref UpdateTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTemplateRequest(ref DeleteTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTemplateVersionsRequest(ref ListTemplateVersionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTemplateVersionRequest(ref GetTemplateVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTemplateVersionRequest(ref CreateTemplateVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTemplateVersionRequest(ref UpdateTemplateVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTemplateVersionRequest(ref DeleteTemplateVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RenderTemplateVersionRequest(ref RenderTemplateVersionRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists Parameters in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Parameter"/> resources.</returns>
        public override gax::PagedEnumerable<ListParametersResponse, Parameter> ListParameters(ListParametersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListParametersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListParametersRequest, ListParametersResponse, Parameter>(_callListParameters, request, callSettings);
        }

        /// <summary>
        /// Lists Parameters in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Parameter"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListParametersResponse, Parameter> ListParametersAsync(ListParametersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListParametersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListParametersRequest, ListParametersResponse, Parameter>(_callListParameters, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Parameter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Parameter GetParameter(GetParameterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetParameterRequest(ref request, ref callSettings);
            return _callGetParameter.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Parameter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Parameter> GetParameterAsync(GetParameterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetParameterRequest(ref request, ref callSettings);
            return _callGetParameter.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new Parameter in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Parameter CreateParameter(CreateParameterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateParameterRequest(ref request, ref callSettings);
            return _callCreateParameter.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new Parameter in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Parameter> CreateParameterAsync(CreateParameterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateParameterRequest(ref request, ref callSettings);
            return _callCreateParameter.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a single Parameter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Parameter UpdateParameter(UpdateParameterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateParameterRequest(ref request, ref callSettings);
            return _callUpdateParameter.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a single Parameter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Parameter> UpdateParameterAsync(UpdateParameterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateParameterRequest(ref request, ref callSettings);
            return _callUpdateParameter.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a single Parameter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteParameter(DeleteParameterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteParameterRequest(ref request, ref callSettings);
            _callDeleteParameter.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a single Parameter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteParameterAsync(DeleteParameterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteParameterRequest(ref request, ref callSettings);
            return _callDeleteParameter.Async(request, callSettings);
        }

        /// <summary>
        /// Lists ParameterVersions in a given project, location, and parameter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ParameterVersion"/> resources.</returns>
        public override gax::PagedEnumerable<ListParameterVersionsResponse, ParameterVersion> ListParameterVersions(ListParameterVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListParameterVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListParameterVersionsRequest, ListParameterVersionsResponse, ParameterVersion>(_callListParameterVersions, request, callSettings);
        }

        /// <summary>
        /// Lists ParameterVersions in a given project, location, and parameter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ParameterVersion"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListParameterVersionsResponse, ParameterVersion> ListParameterVersionsAsync(ListParameterVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListParameterVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListParameterVersionsRequest, ListParameterVersionsResponse, ParameterVersion>(_callListParameterVersions, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ParameterVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ParameterVersion GetParameterVersion(GetParameterVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetParameterVersionRequest(ref request, ref callSettings);
            return _callGetParameterVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ParameterVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ParameterVersion> GetParameterVersionAsync(GetParameterVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetParameterVersionRequest(ref request, ref callSettings);
            return _callGetParameterVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Gets rendered version of a ParameterVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RenderParameterVersionResponse RenderParameterVersion(RenderParameterVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RenderParameterVersionRequest(ref request, ref callSettings);
            return _callRenderParameterVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets rendered version of a ParameterVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RenderParameterVersionResponse> RenderParameterVersionAsync(RenderParameterVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RenderParameterVersionRequest(ref request, ref callSettings);
            return _callRenderParameterVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new ParameterVersion in a given project, location, and parameter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ParameterVersion CreateParameterVersion(CreateParameterVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateParameterVersionRequest(ref request, ref callSettings);
            return _callCreateParameterVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new ParameterVersion in a given project, location, and parameter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ParameterVersion> CreateParameterVersionAsync(CreateParameterVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateParameterVersionRequest(ref request, ref callSettings);
            return _callCreateParameterVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a single ParameterVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ParameterVersion UpdateParameterVersion(UpdateParameterVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateParameterVersionRequest(ref request, ref callSettings);
            return _callUpdateParameterVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a single ParameterVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ParameterVersion> UpdateParameterVersionAsync(UpdateParameterVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateParameterVersionRequest(ref request, ref callSettings);
            return _callUpdateParameterVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a single ParameterVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteParameterVersion(DeleteParameterVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteParameterVersionRequest(ref request, ref callSettings);
            _callDeleteParameterVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a single ParameterVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteParameterVersionAsync(DeleteParameterVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteParameterVersionRequest(ref request, ref callSettings);
            return _callDeleteParameterVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Templates in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Template"/> resources.</returns>
        public override gax::PagedEnumerable<ListTemplatesResponse, Template> ListTemplates(ListTemplatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTemplatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTemplatesRequest, ListTemplatesResponse, Template>(_callListTemplates, request, callSettings);
        }

        /// <summary>
        /// Lists Templates in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Template"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTemplatesResponse, Template> ListTemplatesAsync(ListTemplatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTemplatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTemplatesRequest, ListTemplatesResponse, Template>(_callListTemplates, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Template GetTemplate(GetTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTemplateRequest(ref request, ref callSettings);
            return _callGetTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Template> GetTemplateAsync(GetTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTemplateRequest(ref request, ref callSettings);
            return _callGetTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new Template in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Template CreateTemplate(CreateTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTemplateRequest(ref request, ref callSettings);
            return _callCreateTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new Template in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Template> CreateTemplateAsync(CreateTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTemplateRequest(ref request, ref callSettings);
            return _callCreateTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a single Template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Template UpdateTemplate(UpdateTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTemplateRequest(ref request, ref callSettings);
            return _callUpdateTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a single Template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Template> UpdateTemplateAsync(UpdateTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTemplateRequest(ref request, ref callSettings);
            return _callUpdateTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a single Template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteTemplate(DeleteTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTemplateRequest(ref request, ref callSettings);
            _callDeleteTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a single Template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteTemplateAsync(DeleteTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTemplateRequest(ref request, ref callSettings);
            return _callDeleteTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Lists TemplateVersions in a given project, location, and template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TemplateVersion"/> resources.</returns>
        public override gax::PagedEnumerable<ListTemplateVersionsResponse, TemplateVersion> ListTemplateVersions(ListTemplateVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTemplateVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTemplateVersionsRequest, ListTemplateVersionsResponse, TemplateVersion>(_callListTemplateVersions, request, callSettings);
        }

        /// <summary>
        /// Lists TemplateVersions in a given project, location, and template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TemplateVersion"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTemplateVersionsResponse, TemplateVersion> ListTemplateVersionsAsync(ListTemplateVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTemplateVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTemplateVersionsRequest, ListTemplateVersionsResponse, TemplateVersion>(_callListTemplateVersions, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single TemplateVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TemplateVersion GetTemplateVersion(GetTemplateVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTemplateVersionRequest(ref request, ref callSettings);
            return _callGetTemplateVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single TemplateVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TemplateVersion> GetTemplateVersionAsync(GetTemplateVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTemplateVersionRequest(ref request, ref callSettings);
            return _callGetTemplateVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new TemplateVersion in a given project, location, and template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TemplateVersion CreateTemplateVersion(CreateTemplateVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTemplateVersionRequest(ref request, ref callSettings);
            return _callCreateTemplateVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new TemplateVersion in a given project, location, and template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TemplateVersion> CreateTemplateVersionAsync(CreateTemplateVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTemplateVersionRequest(ref request, ref callSettings);
            return _callCreateTemplateVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a single TemplateVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TemplateVersion UpdateTemplateVersion(UpdateTemplateVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTemplateVersionRequest(ref request, ref callSettings);
            return _callUpdateTemplateVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a single TemplateVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TemplateVersion> UpdateTemplateVersionAsync(UpdateTemplateVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTemplateVersionRequest(ref request, ref callSettings);
            return _callUpdateTemplateVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a single TemplateVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteTemplateVersion(DeleteTemplateVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTemplateVersionRequest(ref request, ref callSettings);
            _callDeleteTemplateVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a single TemplateVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteTemplateVersionAsync(DeleteTemplateVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTemplateVersionRequest(ref request, ref callSettings);
            return _callDeleteTemplateVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Gets rendered version of a TemplateVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RenderTemplateVersionResponse RenderTemplateVersion(RenderTemplateVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RenderTemplateVersionRequest(ref request, ref callSettings);
            return _callRenderTemplateVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets rendered version of a TemplateVersion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RenderTemplateVersionResponse> RenderTemplateVersionAsync(RenderTemplateVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RenderTemplateVersionRequest(ref request, ref callSettings);
            return _callRenderTemplateVersion.Async(request, callSettings);
        }
    }

    public partial class ListParametersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListParameterVersionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTemplatesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTemplateVersionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListParametersResponse : gaxgrpc::IPageResponse<Parameter>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Parameter> GetEnumerator() => Parameters.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListParameterVersionsResponse : gaxgrpc::IPageResponse<ParameterVersion>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ParameterVersion> GetEnumerator() => ParameterVersions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTemplatesResponse : gaxgrpc::IPageResponse<Template>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Template> GetEnumerator() => Templates.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTemplateVersionsResponse : gaxgrpc::IPageResponse<TemplateVersion>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TemplateVersion> GetEnumerator() => TemplateVersions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ParameterManager
    {
        public partial class ParameterManagerClient
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
