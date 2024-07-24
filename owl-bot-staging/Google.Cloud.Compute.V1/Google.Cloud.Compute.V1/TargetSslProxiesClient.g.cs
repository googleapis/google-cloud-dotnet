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
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.Compute.V1
{
    /// <summary>Settings for <see cref="TargetSslProxiesClient"/> instances.</summary>
    public sealed partial class TargetSslProxiesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="TargetSslProxiesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="TargetSslProxiesSettings"/>.</returns>
        public static TargetSslProxiesSettings GetDefault() => new TargetSslProxiesSettings();

        /// <summary>Constructs a new <see cref="TargetSslProxiesSettings"/> object with default settings.</summary>
        public TargetSslProxiesSettings()
        {
        }

        private TargetSslProxiesSettings(TargetSslProxiesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            DeleteSettings = existing.DeleteSettings;
            DeleteOperationsSettings = existing.DeleteOperationsSettings.Clone();
            GetSettings = existing.GetSettings;
            InsertSettings = existing.InsertSettings;
            InsertOperationsSettings = existing.InsertOperationsSettings.Clone();
            ListSettings = existing.ListSettings;
            SetBackendServiceSettings = existing.SetBackendServiceSettings;
            SetBackendServiceOperationsSettings = existing.SetBackendServiceOperationsSettings.Clone();
            SetCertificateMapSettings = existing.SetCertificateMapSettings;
            SetCertificateMapOperationsSettings = existing.SetCertificateMapOperationsSettings.Clone();
            SetProxyHeaderSettings = existing.SetProxyHeaderSettings;
            SetProxyHeaderOperationsSettings = existing.SetProxyHeaderOperationsSettings.Clone();
            SetSslCertificatesSettings = existing.SetSslCertificatesSettings;
            SetSslCertificatesOperationsSettings = existing.SetSslCertificatesOperationsSettings.Clone();
            SetSslPolicySettings = existing.SetSslPolicySettings;
            SetSslPolicyOperationsSettings = existing.SetSslPolicyOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(TargetSslProxiesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TargetSslProxiesClient.Delete</c> and <c>TargetSslProxiesClient.DeleteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TargetSslProxiesClient.Delete</c> and
        /// <c>TargetSslProxiesClient.DeleteAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>TargetSslProxiesClient.Get</c>
        ///  and <c>TargetSslProxiesClient.GetAsync</c>.
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
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TargetSslProxiesClient.Insert</c> and <c>TargetSslProxiesClient.InsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InsertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TargetSslProxiesClient.Insert</c> and
        /// <c>TargetSslProxiesClient.InsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings InsertOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>TargetSslProxiesClient.List</c>
        ///  and <c>TargetSslProxiesClient.ListAsync</c>.
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
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TargetSslProxiesClient.SetBackendService</c> and <c>TargetSslProxiesClient.SetBackendServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetBackendServiceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TargetSslProxiesClient.SetBackendService</c> and
        /// <c>TargetSslProxiesClient.SetBackendServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings SetBackendServiceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TargetSslProxiesClient.SetCertificateMap</c> and <c>TargetSslProxiesClient.SetCertificateMapAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetCertificateMapSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TargetSslProxiesClient.SetCertificateMap</c> and
        /// <c>TargetSslProxiesClient.SetCertificateMapAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings SetCertificateMapOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TargetSslProxiesClient.SetProxyHeader</c> and <c>TargetSslProxiesClient.SetProxyHeaderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetProxyHeaderSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TargetSslProxiesClient.SetProxyHeader</c> and
        /// <c>TargetSslProxiesClient.SetProxyHeaderAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings SetProxyHeaderOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TargetSslProxiesClient.SetSslCertificates</c> and <c>TargetSslProxiesClient.SetSslCertificatesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetSslCertificatesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TargetSslProxiesClient.SetSslCertificates</c> and
        /// <c>TargetSslProxiesClient.SetSslCertificatesAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings SetSslCertificatesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TargetSslProxiesClient.SetSslPolicy</c> and <c>TargetSslProxiesClient.SetSslPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetSslPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TargetSslProxiesClient.SetSslPolicy</c> and
        /// <c>TargetSslProxiesClient.SetSslPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings SetSslPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="TargetSslProxiesSettings"/> object.</returns>
        public TargetSslProxiesSettings Clone() => new TargetSslProxiesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="TargetSslProxiesClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class TargetSslProxiesClientBuilder : gaxgrpc::ClientBuilderBase<TargetSslProxiesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public TargetSslProxiesSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public TargetSslProxiesClientBuilder() : base(TargetSslProxiesClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref TargetSslProxiesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<TargetSslProxiesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override TargetSslProxiesClient Build()
        {
            TargetSslProxiesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<TargetSslProxiesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<TargetSslProxiesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private TargetSslProxiesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return TargetSslProxiesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<TargetSslProxiesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TargetSslProxiesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => TargetSslProxiesClient.ChannelPool;
    }

    /// <summary>TargetSslProxies client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The TargetSslProxies API.
    /// </remarks>
    public abstract partial class TargetSslProxiesClient
    {
        /// <summary>
        /// The default endpoint for the TargetSslProxies service, which is a host of "compute.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default TargetSslProxies scopes.</summary>
        /// <remarks>
        /// The default TargetSslProxies scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/compute</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/compute",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(TargetSslProxies.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="TargetSslProxiesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TargetSslProxiesClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="TargetSslProxiesClient"/>.</returns>
        public static stt::Task<TargetSslProxiesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new TargetSslProxiesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="TargetSslProxiesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TargetSslProxiesClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="TargetSslProxiesClient"/>.</returns>
        public static TargetSslProxiesClient Create() => new TargetSslProxiesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="TargetSslProxiesClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="TargetSslProxiesSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="TargetSslProxiesClient"/>.</returns>
        internal static TargetSslProxiesClient Create(grpccore::CallInvoker callInvoker, TargetSslProxiesSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            TargetSslProxies.TargetSslProxiesClient grpcClient = new TargetSslProxies.TargetSslProxiesClient(callInvoker);
            return new TargetSslProxiesClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC TargetSslProxies client</summary>
        public virtual TargetSslProxies.TargetSslProxiesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified TargetSslProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Delete(DeleteTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified TargetSslProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified TargetSslProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteTargetSslProxyRequest request, st::CancellationToken cancellationToken) =>
            DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>Delete</c>.</summary>
        public virtual lro::OperationsClient DeleteOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Delete</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceDelete(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Delete</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceDeleteAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteOperationsClient, callSettings);

        /// <summary>
        /// Deletes the specified TargetSslProxy resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxy">
        /// Name of the TargetSslProxy resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Delete(string project, string targetSslProxy, gaxgrpc::CallSettings callSettings = null) =>
            Delete(new DeleteTargetSslProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetSslProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetSslProxy, nameof(targetSslProxy)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified TargetSslProxy resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxy">
        /// Name of the TargetSslProxy resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(string project, string targetSslProxy, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAsync(new DeleteTargetSslProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetSslProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetSslProxy, nameof(targetSslProxy)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified TargetSslProxy resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxy">
        /// Name of the TargetSslProxy resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(string project, string targetSslProxy, st::CancellationToken cancellationToken) =>
            DeleteAsync(project, targetSslProxy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified TargetSslProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TargetSslProxy Get(GetTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified TargetSslProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetSslProxy> GetAsync(GetTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified TargetSslProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetSslProxy> GetAsync(GetTargetSslProxyRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified TargetSslProxy resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxy">
        /// Name of the TargetSslProxy resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TargetSslProxy Get(string project, string targetSslProxy, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetTargetSslProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetSslProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetSslProxy, nameof(targetSslProxy)),
            }, callSettings);

        /// <summary>
        /// Returns the specified TargetSslProxy resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxy">
        /// Name of the TargetSslProxy resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetSslProxy> GetAsync(string project, string targetSslProxy, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetTargetSslProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetSslProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetSslProxy, nameof(targetSslProxy)),
            }, callSettings);

        /// <summary>
        /// Returns the specified TargetSslProxy resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxy">
        /// Name of the TargetSslProxy resource to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetSslProxy> GetAsync(string project, string targetSslProxy, st::CancellationToken cancellationToken) =>
            GetAsync(project, targetSslProxy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a TargetSslProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Insert(InsertTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a TargetSslProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a TargetSslProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertTargetSslProxyRequest request, st::CancellationToken cancellationToken) =>
            InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>Insert</c>.</summary>
        public virtual lro::OperationsClient InsertOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Insert</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceInsert(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), InsertOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Insert</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceInsertAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), InsertOperationsClient, callSettings);

        /// <summary>
        /// Creates a TargetSslProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Insert(string project, TargetSslProxy targetSslProxyResource, gaxgrpc::CallSettings callSettings = null) =>
            Insert(new InsertTargetSslProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetSslProxyResource = gax::GaxPreconditions.CheckNotNull(targetSslProxyResource, nameof(targetSslProxyResource)),
            }, callSettings);

        /// <summary>
        /// Creates a TargetSslProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(string project, TargetSslProxy targetSslProxyResource, gaxgrpc::CallSettings callSettings = null) =>
            InsertAsync(new InsertTargetSslProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetSslProxyResource = gax::GaxPreconditions.CheckNotNull(targetSslProxyResource, nameof(targetSslProxyResource)),
            }, callSettings);

        /// <summary>
        /// Creates a TargetSslProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(string project, TargetSslProxy targetSslProxyResource, st::CancellationToken cancellationToken) =>
            InsertAsync(project, targetSslProxyResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the list of TargetSslProxy resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TargetSslProxy"/> resources.</returns>
        public virtual gax::PagedEnumerable<TargetSslProxyList, TargetSslProxy> List(ListTargetSslProxiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of TargetSslProxy resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TargetSslProxy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<TargetSslProxyList, TargetSslProxy> ListAsync(ListTargetSslProxiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of TargetSslProxy resources available to the specified project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
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
        /// <returns>A pageable sequence of <see cref="TargetSslProxy"/> resources.</returns>
        public virtual gax::PagedEnumerable<TargetSslProxyList, TargetSslProxy> List(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTargetSslProxiesRequest request = new ListTargetSslProxiesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return List(request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of TargetSslProxy resources available to the specified project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TargetSslProxy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<TargetSslProxyList, TargetSslProxy> ListAsync(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTargetSslProxiesRequest request = new ListTargetSslProxiesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAsync(request, callSettings);
        }

        /// <summary>
        /// Changes the BackendService for TargetSslProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetBackendService(SetBackendServiceTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes the BackendService for TargetSslProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetBackendServiceAsync(SetBackendServiceTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes the BackendService for TargetSslProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetBackendServiceAsync(SetBackendServiceTargetSslProxyRequest request, st::CancellationToken cancellationToken) =>
            SetBackendServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SetBackendService</c>.</summary>
        public virtual lro::OperationsClient SetBackendServiceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SetBackendService</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceSetBackendService(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetBackendServiceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetBackendService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceSetBackendServiceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetBackendServiceOperationsClient, callSettings);

        /// <summary>
        /// Changes the BackendService for TargetSslProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxy">
        /// Name of the TargetSslProxy resource whose BackendService resource is to be set.
        /// </param>
        /// <param name="targetSslProxiesSetBackendServiceRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetBackendService(string project, string targetSslProxy, TargetSslProxiesSetBackendServiceRequest targetSslProxiesSetBackendServiceRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetBackendService(new SetBackendServiceTargetSslProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetSslProxiesSetBackendServiceRequestResource = gax::GaxPreconditions.CheckNotNull(targetSslProxiesSetBackendServiceRequestResource, nameof(targetSslProxiesSetBackendServiceRequestResource)),
                TargetSslProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetSslProxy, nameof(targetSslProxy)),
            }, callSettings);

        /// <summary>
        /// Changes the BackendService for TargetSslProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxy">
        /// Name of the TargetSslProxy resource whose BackendService resource is to be set.
        /// </param>
        /// <param name="targetSslProxiesSetBackendServiceRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetBackendServiceAsync(string project, string targetSslProxy, TargetSslProxiesSetBackendServiceRequest targetSslProxiesSetBackendServiceRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetBackendServiceAsync(new SetBackendServiceTargetSslProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetSslProxiesSetBackendServiceRequestResource = gax::GaxPreconditions.CheckNotNull(targetSslProxiesSetBackendServiceRequestResource, nameof(targetSslProxiesSetBackendServiceRequestResource)),
                TargetSslProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetSslProxy, nameof(targetSslProxy)),
            }, callSettings);

        /// <summary>
        /// Changes the BackendService for TargetSslProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxy">
        /// Name of the TargetSslProxy resource whose BackendService resource is to be set.
        /// </param>
        /// <param name="targetSslProxiesSetBackendServiceRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetBackendServiceAsync(string project, string targetSslProxy, TargetSslProxiesSetBackendServiceRequest targetSslProxiesSetBackendServiceRequestResource, st::CancellationToken cancellationToken) =>
            SetBackendServiceAsync(project, targetSslProxy, targetSslProxiesSetBackendServiceRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Changes the Certificate Map for TargetSslProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetCertificateMap(SetCertificateMapTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes the Certificate Map for TargetSslProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetCertificateMapAsync(SetCertificateMapTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes the Certificate Map for TargetSslProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetCertificateMapAsync(SetCertificateMapTargetSslProxyRequest request, st::CancellationToken cancellationToken) =>
            SetCertificateMapAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SetCertificateMap</c>.</summary>
        public virtual lro::OperationsClient SetCertificateMapOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SetCertificateMap</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceSetCertificateMap(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetCertificateMapOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetCertificateMap</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceSetCertificateMapAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetCertificateMapOperationsClient, callSettings);

        /// <summary>
        /// Changes the Certificate Map for TargetSslProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxy">
        /// Name of the TargetSslProxy resource whose CertificateMap is to be set. The name must be 1-63 characters long, and comply with RFC1035.
        /// </param>
        /// <param name="targetSslProxiesSetCertificateMapRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetCertificateMap(string project, string targetSslProxy, TargetSslProxiesSetCertificateMapRequest targetSslProxiesSetCertificateMapRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetCertificateMap(new SetCertificateMapTargetSslProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetSslProxiesSetCertificateMapRequestResource = gax::GaxPreconditions.CheckNotNull(targetSslProxiesSetCertificateMapRequestResource, nameof(targetSslProxiesSetCertificateMapRequestResource)),
                TargetSslProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetSslProxy, nameof(targetSslProxy)),
            }, callSettings);

        /// <summary>
        /// Changes the Certificate Map for TargetSslProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxy">
        /// Name of the TargetSslProxy resource whose CertificateMap is to be set. The name must be 1-63 characters long, and comply with RFC1035.
        /// </param>
        /// <param name="targetSslProxiesSetCertificateMapRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetCertificateMapAsync(string project, string targetSslProxy, TargetSslProxiesSetCertificateMapRequest targetSslProxiesSetCertificateMapRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetCertificateMapAsync(new SetCertificateMapTargetSslProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetSslProxiesSetCertificateMapRequestResource = gax::GaxPreconditions.CheckNotNull(targetSslProxiesSetCertificateMapRequestResource, nameof(targetSslProxiesSetCertificateMapRequestResource)),
                TargetSslProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetSslProxy, nameof(targetSslProxy)),
            }, callSettings);

        /// <summary>
        /// Changes the Certificate Map for TargetSslProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxy">
        /// Name of the TargetSslProxy resource whose CertificateMap is to be set. The name must be 1-63 characters long, and comply with RFC1035.
        /// </param>
        /// <param name="targetSslProxiesSetCertificateMapRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetCertificateMapAsync(string project, string targetSslProxy, TargetSslProxiesSetCertificateMapRequest targetSslProxiesSetCertificateMapRequestResource, st::CancellationToken cancellationToken) =>
            SetCertificateMapAsync(project, targetSslProxy, targetSslProxiesSetCertificateMapRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Changes the ProxyHeaderType for TargetSslProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetProxyHeader(SetProxyHeaderTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes the ProxyHeaderType for TargetSslProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetProxyHeaderAsync(SetProxyHeaderTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes the ProxyHeaderType for TargetSslProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetProxyHeaderAsync(SetProxyHeaderTargetSslProxyRequest request, st::CancellationToken cancellationToken) =>
            SetProxyHeaderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SetProxyHeader</c>.</summary>
        public virtual lro::OperationsClient SetProxyHeaderOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SetProxyHeader</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceSetProxyHeader(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetProxyHeaderOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetProxyHeader</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceSetProxyHeaderAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetProxyHeaderOperationsClient, callSettings);

        /// <summary>
        /// Changes the ProxyHeaderType for TargetSslProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxy">
        /// Name of the TargetSslProxy resource whose ProxyHeader is to be set.
        /// </param>
        /// <param name="targetSslProxiesSetProxyHeaderRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetProxyHeader(string project, string targetSslProxy, TargetSslProxiesSetProxyHeaderRequest targetSslProxiesSetProxyHeaderRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetProxyHeader(new SetProxyHeaderTargetSslProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetSslProxiesSetProxyHeaderRequestResource = gax::GaxPreconditions.CheckNotNull(targetSslProxiesSetProxyHeaderRequestResource, nameof(targetSslProxiesSetProxyHeaderRequestResource)),
                TargetSslProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetSslProxy, nameof(targetSslProxy)),
            }, callSettings);

        /// <summary>
        /// Changes the ProxyHeaderType for TargetSslProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxy">
        /// Name of the TargetSslProxy resource whose ProxyHeader is to be set.
        /// </param>
        /// <param name="targetSslProxiesSetProxyHeaderRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetProxyHeaderAsync(string project, string targetSslProxy, TargetSslProxiesSetProxyHeaderRequest targetSslProxiesSetProxyHeaderRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetProxyHeaderAsync(new SetProxyHeaderTargetSslProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetSslProxiesSetProxyHeaderRequestResource = gax::GaxPreconditions.CheckNotNull(targetSslProxiesSetProxyHeaderRequestResource, nameof(targetSslProxiesSetProxyHeaderRequestResource)),
                TargetSslProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetSslProxy, nameof(targetSslProxy)),
            }, callSettings);

        /// <summary>
        /// Changes the ProxyHeaderType for TargetSslProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxy">
        /// Name of the TargetSslProxy resource whose ProxyHeader is to be set.
        /// </param>
        /// <param name="targetSslProxiesSetProxyHeaderRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetProxyHeaderAsync(string project, string targetSslProxy, TargetSslProxiesSetProxyHeaderRequest targetSslProxiesSetProxyHeaderRequestResource, st::CancellationToken cancellationToken) =>
            SetProxyHeaderAsync(project, targetSslProxy, targetSslProxiesSetProxyHeaderRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Changes SslCertificates for TargetSslProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetSslCertificates(SetSslCertificatesTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes SslCertificates for TargetSslProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetSslCertificatesAsync(SetSslCertificatesTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes SslCertificates for TargetSslProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetSslCertificatesAsync(SetSslCertificatesTargetSslProxyRequest request, st::CancellationToken cancellationToken) =>
            SetSslCertificatesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SetSslCertificates</c>.</summary>
        public virtual lro::OperationsClient SetSslCertificatesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SetSslCertificates</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceSetSslCertificates(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetSslCertificatesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetSslCertificates</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceSetSslCertificatesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetSslCertificatesOperationsClient, callSettings);

        /// <summary>
        /// Changes SslCertificates for TargetSslProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxy">
        /// Name of the TargetSslProxy resource whose SslCertificate resource is to be set.
        /// </param>
        /// <param name="targetSslProxiesSetSslCertificatesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetSslCertificates(string project, string targetSslProxy, TargetSslProxiesSetSslCertificatesRequest targetSslProxiesSetSslCertificatesRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetSslCertificates(new SetSslCertificatesTargetSslProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetSslProxiesSetSslCertificatesRequestResource = gax::GaxPreconditions.CheckNotNull(targetSslProxiesSetSslCertificatesRequestResource, nameof(targetSslProxiesSetSslCertificatesRequestResource)),
                TargetSslProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetSslProxy, nameof(targetSslProxy)),
            }, callSettings);

        /// <summary>
        /// Changes SslCertificates for TargetSslProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxy">
        /// Name of the TargetSslProxy resource whose SslCertificate resource is to be set.
        /// </param>
        /// <param name="targetSslProxiesSetSslCertificatesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetSslCertificatesAsync(string project, string targetSslProxy, TargetSslProxiesSetSslCertificatesRequest targetSslProxiesSetSslCertificatesRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetSslCertificatesAsync(new SetSslCertificatesTargetSslProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetSslProxiesSetSslCertificatesRequestResource = gax::GaxPreconditions.CheckNotNull(targetSslProxiesSetSslCertificatesRequestResource, nameof(targetSslProxiesSetSslCertificatesRequestResource)),
                TargetSslProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetSslProxy, nameof(targetSslProxy)),
            }, callSettings);

        /// <summary>
        /// Changes SslCertificates for TargetSslProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxy">
        /// Name of the TargetSslProxy resource whose SslCertificate resource is to be set.
        /// </param>
        /// <param name="targetSslProxiesSetSslCertificatesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetSslCertificatesAsync(string project, string targetSslProxy, TargetSslProxiesSetSslCertificatesRequest targetSslProxiesSetSslCertificatesRequestResource, st::CancellationToken cancellationToken) =>
            SetSslCertificatesAsync(project, targetSslProxy, targetSslProxiesSetSslCertificatesRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the SSL policy for TargetSslProxy. The SSL policy specifies the server-side support for SSL features. This affects connections between clients and the load balancer. They do not affect the connection between the load balancer and the backends.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetSslPolicy(SetSslPolicyTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the SSL policy for TargetSslProxy. The SSL policy specifies the server-side support for SSL features. This affects connections between clients and the load balancer. They do not affect the connection between the load balancer and the backends.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetSslPolicyAsync(SetSslPolicyTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the SSL policy for TargetSslProxy. The SSL policy specifies the server-side support for SSL features. This affects connections between clients and the load balancer. They do not affect the connection between the load balancer and the backends.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetSslPolicyAsync(SetSslPolicyTargetSslProxyRequest request, st::CancellationToken cancellationToken) =>
            SetSslPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SetSslPolicy</c>.</summary>
        public virtual lro::OperationsClient SetSslPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SetSslPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceSetSslPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetSslPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetSslPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceSetSslPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetSslPolicyOperationsClient, callSettings);

        /// <summary>
        /// Sets the SSL policy for TargetSslProxy. The SSL policy specifies the server-side support for SSL features. This affects connections between clients and the load balancer. They do not affect the connection between the load balancer and the backends.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxy">
        /// Name of the TargetSslProxy resource whose SSL policy is to be set. The name must be 1-63 characters long, and comply with RFC1035.
        /// </param>
        /// <param name="sslPolicyReferenceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetSslPolicy(string project, string targetSslProxy, SslPolicyReference sslPolicyReferenceResource, gaxgrpc::CallSettings callSettings = null) =>
            SetSslPolicy(new SetSslPolicyTargetSslProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                SslPolicyReferenceResource = gax::GaxPreconditions.CheckNotNull(sslPolicyReferenceResource, nameof(sslPolicyReferenceResource)),
                TargetSslProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetSslProxy, nameof(targetSslProxy)),
            }, callSettings);

        /// <summary>
        /// Sets the SSL policy for TargetSslProxy. The SSL policy specifies the server-side support for SSL features. This affects connections between clients and the load balancer. They do not affect the connection between the load balancer and the backends.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxy">
        /// Name of the TargetSslProxy resource whose SSL policy is to be set. The name must be 1-63 characters long, and comply with RFC1035.
        /// </param>
        /// <param name="sslPolicyReferenceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetSslPolicyAsync(string project, string targetSslProxy, SslPolicyReference sslPolicyReferenceResource, gaxgrpc::CallSettings callSettings = null) =>
            SetSslPolicyAsync(new SetSslPolicyTargetSslProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                SslPolicyReferenceResource = gax::GaxPreconditions.CheckNotNull(sslPolicyReferenceResource, nameof(sslPolicyReferenceResource)),
                TargetSslProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetSslProxy, nameof(targetSslProxy)),
            }, callSettings);

        /// <summary>
        /// Sets the SSL policy for TargetSslProxy. The SSL policy specifies the server-side support for SSL features. This affects connections between clients and the load balancer. They do not affect the connection between the load balancer and the backends.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxy">
        /// Name of the TargetSslProxy resource whose SSL policy is to be set. The name must be 1-63 characters long, and comply with RFC1035.
        /// </param>
        /// <param name="sslPolicyReferenceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetSslPolicyAsync(string project, string targetSslProxy, SslPolicyReference sslPolicyReferenceResource, st::CancellationToken cancellationToken) =>
            SetSslPolicyAsync(project, targetSslProxy, sslPolicyReferenceResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>TargetSslProxies client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The TargetSslProxies API.
    /// </remarks>
    public sealed partial class TargetSslProxiesClientImpl : TargetSslProxiesClient
    {
        private readonly gaxgrpc::ApiCall<DeleteTargetSslProxyRequest, Operation> _callDelete;

        private readonly gaxgrpc::ApiCall<GetTargetSslProxyRequest, TargetSslProxy> _callGet;

        private readonly gaxgrpc::ApiCall<InsertTargetSslProxyRequest, Operation> _callInsert;

        private readonly gaxgrpc::ApiCall<ListTargetSslProxiesRequest, TargetSslProxyList> _callList;

        private readonly gaxgrpc::ApiCall<SetBackendServiceTargetSslProxyRequest, Operation> _callSetBackendService;

        private readonly gaxgrpc::ApiCall<SetCertificateMapTargetSslProxyRequest, Operation> _callSetCertificateMap;

        private readonly gaxgrpc::ApiCall<SetProxyHeaderTargetSslProxyRequest, Operation> _callSetProxyHeader;

        private readonly gaxgrpc::ApiCall<SetSslCertificatesTargetSslProxyRequest, Operation> _callSetSslCertificates;

        private readonly gaxgrpc::ApiCall<SetSslPolicyTargetSslProxyRequest, Operation> _callSetSslPolicy;

        /// <summary>
        /// Constructs a client wrapper for the TargetSslProxies service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="TargetSslProxiesSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public TargetSslProxiesClientImpl(TargetSslProxies.TargetSslProxiesClient grpcClient, TargetSslProxiesSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            TargetSslProxiesSettings effectiveSettings = settings ?? TargetSslProxiesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            DeleteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.DeleteOperationsSettings, logger);
            InsertOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.InsertOperationsSettings, logger);
            SetBackendServiceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.SetBackendServiceOperationsSettings, logger);
            SetCertificateMapOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.SetCertificateMapOperationsSettings, logger);
            SetProxyHeaderOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.SetProxyHeaderOperationsSettings, logger);
            SetSslCertificatesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.SetSslCertificatesOperationsSettings, logger);
            SetSslPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.SetSslPolicyOperationsSettings, logger);
            _callDelete = clientHelper.BuildApiCall<DeleteTargetSslProxyRequest, Operation>("Delete", grpcClient.DeleteAsync, grpcClient.Delete, effectiveSettings.DeleteSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("target_ssl_proxy", request => request.TargetSslProxy);
            Modify_ApiCall(ref _callDelete);
            Modify_DeleteApiCall(ref _callDelete);
            _callGet = clientHelper.BuildApiCall<GetTargetSslProxyRequest, TargetSslProxy>("Get", grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("target_ssl_proxy", request => request.TargetSslProxy);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callInsert = clientHelper.BuildApiCall<InsertTargetSslProxyRequest, Operation>("Insert", grpcClient.InsertAsync, grpcClient.Insert, effectiveSettings.InsertSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callInsert);
            Modify_InsertApiCall(ref _callInsert);
            _callList = clientHelper.BuildApiCall<ListTargetSslProxiesRequest, TargetSslProxyList>("List", grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            _callSetBackendService = clientHelper.BuildApiCall<SetBackendServiceTargetSslProxyRequest, Operation>("SetBackendService", grpcClient.SetBackendServiceAsync, grpcClient.SetBackendService, effectiveSettings.SetBackendServiceSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("target_ssl_proxy", request => request.TargetSslProxy);
            Modify_ApiCall(ref _callSetBackendService);
            Modify_SetBackendServiceApiCall(ref _callSetBackendService);
            _callSetCertificateMap = clientHelper.BuildApiCall<SetCertificateMapTargetSslProxyRequest, Operation>("SetCertificateMap", grpcClient.SetCertificateMapAsync, grpcClient.SetCertificateMap, effectiveSettings.SetCertificateMapSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("target_ssl_proxy", request => request.TargetSslProxy);
            Modify_ApiCall(ref _callSetCertificateMap);
            Modify_SetCertificateMapApiCall(ref _callSetCertificateMap);
            _callSetProxyHeader = clientHelper.BuildApiCall<SetProxyHeaderTargetSslProxyRequest, Operation>("SetProxyHeader", grpcClient.SetProxyHeaderAsync, grpcClient.SetProxyHeader, effectiveSettings.SetProxyHeaderSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("target_ssl_proxy", request => request.TargetSslProxy);
            Modify_ApiCall(ref _callSetProxyHeader);
            Modify_SetProxyHeaderApiCall(ref _callSetProxyHeader);
            _callSetSslCertificates = clientHelper.BuildApiCall<SetSslCertificatesTargetSslProxyRequest, Operation>("SetSslCertificates", grpcClient.SetSslCertificatesAsync, grpcClient.SetSslCertificates, effectiveSettings.SetSslCertificatesSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("target_ssl_proxy", request => request.TargetSslProxy);
            Modify_ApiCall(ref _callSetSslCertificates);
            Modify_SetSslCertificatesApiCall(ref _callSetSslCertificates);
            _callSetSslPolicy = clientHelper.BuildApiCall<SetSslPolicyTargetSslProxyRequest, Operation>("SetSslPolicy", grpcClient.SetSslPolicyAsync, grpcClient.SetSslPolicy, effectiveSettings.SetSslPolicySettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("target_ssl_proxy", request => request.TargetSslProxy);
            Modify_ApiCall(ref _callSetSslPolicy);
            Modify_SetSslPolicyApiCall(ref _callSetSslPolicy);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_DeleteApiCall(ref gaxgrpc::ApiCall<DeleteTargetSslProxyRequest, Operation> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetTargetSslProxyRequest, TargetSslProxy> call);

        partial void Modify_InsertApiCall(ref gaxgrpc::ApiCall<InsertTargetSslProxyRequest, Operation> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListTargetSslProxiesRequest, TargetSslProxyList> call);

        partial void Modify_SetBackendServiceApiCall(ref gaxgrpc::ApiCall<SetBackendServiceTargetSslProxyRequest, Operation> call);

        partial void Modify_SetCertificateMapApiCall(ref gaxgrpc::ApiCall<SetCertificateMapTargetSslProxyRequest, Operation> call);

        partial void Modify_SetProxyHeaderApiCall(ref gaxgrpc::ApiCall<SetProxyHeaderTargetSslProxyRequest, Operation> call);

        partial void Modify_SetSslCertificatesApiCall(ref gaxgrpc::ApiCall<SetSslCertificatesTargetSslProxyRequest, Operation> call);

        partial void Modify_SetSslPolicyApiCall(ref gaxgrpc::ApiCall<SetSslPolicyTargetSslProxyRequest, Operation> call);

        partial void OnConstruction(TargetSslProxies.TargetSslProxiesClient grpcClient, TargetSslProxiesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC TargetSslProxies client</summary>
        public override TargetSslProxies.TargetSslProxiesClient GrpcClient { get; }

        partial void Modify_DeleteTargetSslProxyRequest(ref DeleteTargetSslProxyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTargetSslProxyRequest(ref GetTargetSslProxyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InsertTargetSslProxyRequest(ref InsertTargetSslProxyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTargetSslProxiesRequest(ref ListTargetSslProxiesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetBackendServiceTargetSslProxyRequest(ref SetBackendServiceTargetSslProxyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetCertificateMapTargetSslProxyRequest(ref SetCertificateMapTargetSslProxyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetProxyHeaderTargetSslProxyRequest(ref SetProxyHeaderTargetSslProxyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetSslCertificatesTargetSslProxyRequest(ref SetSslCertificatesTargetSslProxyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetSslPolicyTargetSslProxyRequest(ref SetSslPolicyTargetSslProxyRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>Delete</c>.</summary>
        public override lro::OperationsClient DeleteOperationsClient { get; }

        /// <summary>
        /// Deletes the specified TargetSslProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Delete(DeleteTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTargetSslProxyRequest(ref request, ref callSettings);
            Operation response = _callDelete.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteOperationsClient);
        }

        /// <summary>
        /// Deletes the specified TargetSslProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTargetSslProxyRequest(ref request, ref callSettings);
            Operation response = await _callDelete.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteOperationsClient);
        }

        /// <summary>
        /// Returns the specified TargetSslProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TargetSslProxy Get(GetTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTargetSslProxyRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified TargetSslProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TargetSslProxy> GetAsync(GetTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTargetSslProxyRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>Insert</c>.</summary>
        public override lro::OperationsClient InsertOperationsClient { get; }

        /// <summary>
        /// Creates a TargetSslProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Insert(InsertTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertTargetSslProxyRequest(ref request, ref callSettings);
            Operation response = _callInsert.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), InsertOperationsClient);
        }

        /// <summary>
        /// Creates a TargetSslProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertTargetSslProxyRequest(ref request, ref callSettings);
            Operation response = await _callInsert.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), InsertOperationsClient);
        }

        /// <summary>
        /// Retrieves the list of TargetSslProxy resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TargetSslProxy"/> resources.</returns>
        public override gax::PagedEnumerable<TargetSslProxyList, TargetSslProxy> List(ListTargetSslProxiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTargetSslProxiesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTargetSslProxiesRequest, TargetSslProxyList, TargetSslProxy>(_callList, request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of TargetSslProxy resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TargetSslProxy"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<TargetSslProxyList, TargetSslProxy> ListAsync(ListTargetSslProxiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTargetSslProxiesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTargetSslProxiesRequest, TargetSslProxyList, TargetSslProxy>(_callList, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>SetBackendService</c>.</summary>
        public override lro::OperationsClient SetBackendServiceOperationsClient { get; }

        /// <summary>
        /// Changes the BackendService for TargetSslProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> SetBackendService(SetBackendServiceTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetBackendServiceTargetSslProxyRequest(ref request, ref callSettings);
            Operation response = _callSetBackendService.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetBackendServiceOperationsClient);
        }

        /// <summary>
        /// Changes the BackendService for TargetSslProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> SetBackendServiceAsync(SetBackendServiceTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetBackendServiceTargetSslProxyRequest(ref request, ref callSettings);
            Operation response = await _callSetBackendService.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetBackendServiceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SetCertificateMap</c>.</summary>
        public override lro::OperationsClient SetCertificateMapOperationsClient { get; }

        /// <summary>
        /// Changes the Certificate Map for TargetSslProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> SetCertificateMap(SetCertificateMapTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetCertificateMapTargetSslProxyRequest(ref request, ref callSettings);
            Operation response = _callSetCertificateMap.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetCertificateMapOperationsClient);
        }

        /// <summary>
        /// Changes the Certificate Map for TargetSslProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> SetCertificateMapAsync(SetCertificateMapTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetCertificateMapTargetSslProxyRequest(ref request, ref callSettings);
            Operation response = await _callSetCertificateMap.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetCertificateMapOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SetProxyHeader</c>.</summary>
        public override lro::OperationsClient SetProxyHeaderOperationsClient { get; }

        /// <summary>
        /// Changes the ProxyHeaderType for TargetSslProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> SetProxyHeader(SetProxyHeaderTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetProxyHeaderTargetSslProxyRequest(ref request, ref callSettings);
            Operation response = _callSetProxyHeader.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetProxyHeaderOperationsClient);
        }

        /// <summary>
        /// Changes the ProxyHeaderType for TargetSslProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> SetProxyHeaderAsync(SetProxyHeaderTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetProxyHeaderTargetSslProxyRequest(ref request, ref callSettings);
            Operation response = await _callSetProxyHeader.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetProxyHeaderOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SetSslCertificates</c>.</summary>
        public override lro::OperationsClient SetSslCertificatesOperationsClient { get; }

        /// <summary>
        /// Changes SslCertificates for TargetSslProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> SetSslCertificates(SetSslCertificatesTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetSslCertificatesTargetSslProxyRequest(ref request, ref callSettings);
            Operation response = _callSetSslCertificates.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetSslCertificatesOperationsClient);
        }

        /// <summary>
        /// Changes SslCertificates for TargetSslProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> SetSslCertificatesAsync(SetSslCertificatesTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetSslCertificatesTargetSslProxyRequest(ref request, ref callSettings);
            Operation response = await _callSetSslCertificates.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetSslCertificatesOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SetSslPolicy</c>.</summary>
        public override lro::OperationsClient SetSslPolicyOperationsClient { get; }

        /// <summary>
        /// Sets the SSL policy for TargetSslProxy. The SSL policy specifies the server-side support for SSL features. This affects connections between clients and the load balancer. They do not affect the connection between the load balancer and the backends.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> SetSslPolicy(SetSslPolicyTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetSslPolicyTargetSslProxyRequest(ref request, ref callSettings);
            Operation response = _callSetSslPolicy.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetSslPolicyOperationsClient);
        }

        /// <summary>
        /// Sets the SSL policy for TargetSslProxy. The SSL policy specifies the server-side support for SSL features. This affects connections between clients and the load balancer. They do not affect the connection between the load balancer and the backends.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> SetSslPolicyAsync(SetSslPolicyTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetSslPolicyTargetSslProxyRequest(ref request, ref callSettings);
            Operation response = await _callSetSslPolicy.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetSslPolicyOperationsClient);
        }
    }

    public partial class ListTargetSslProxiesRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class TargetSslProxyList : gaxgrpc::IPageResponse<TargetSslProxy>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TargetSslProxy> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class TargetSslProxies
    {
        public partial class TargetSslProxiesClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client, delegating to GlobalOperations.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClientForGlobalOperations() =>
                GlobalOperations.GlobalOperationsClient.CreateOperationsClient(CallInvoker);
        }
    }
}
