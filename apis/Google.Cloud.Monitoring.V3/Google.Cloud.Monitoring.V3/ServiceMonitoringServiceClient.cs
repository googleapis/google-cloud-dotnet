// Copyright 2019 Google LLC
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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using pb = Google.Protobuf;
using pbwkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Monitoring.V3
{
    /// <summary>
    /// Settings for a <see cref="ServiceMonitoringServiceClient"/>.
    /// </summary>
    public sealed partial class ServiceMonitoringServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="ServiceMonitoringServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="ServiceMonitoringServiceSettings"/>.
        /// </returns>
        public static ServiceMonitoringServiceSettings GetDefault() => new ServiceMonitoringServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ServiceMonitoringServiceSettings"/> object with default settings.
        /// </summary>
        public ServiceMonitoringServiceSettings() { }

        private ServiceMonitoringServiceSettings(ServiceMonitoringServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateServiceSettings = existing.CreateServiceSettings;
            GetServiceSettings = existing.GetServiceSettings;
            ListServicesSettings = existing.ListServicesSettings;
            UpdateServiceSettings = existing.UpdateServiceSettings;
            DeleteServiceSettings = existing.DeleteServiceSettings;
            CreateServiceLevelObjectiveSettings = existing.CreateServiceLevelObjectiveSettings;
            GetServiceLevelObjectiveSettings = existing.GetServiceLevelObjectiveSettings;
            ListServiceLevelObjectivesSettings = existing.ListServiceLevelObjectivesSettings;
            UpdateServiceLevelObjectiveSettings = existing.UpdateServiceLevelObjectiveSettings;
            DeleteServiceLevelObjectiveSettings = existing.DeleteServiceLevelObjectiveSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ServiceMonitoringServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="ServiceMonitoringServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> IdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="ServiceMonitoringServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="ServiceMonitoringServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="ServiceMonitoringServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="ServiceMonitoringServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(100),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="ServiceMonitoringServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="ServiceMonitoringServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="ServiceMonitoringServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 20000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(20000),
            maxDelay: sys::TimeSpan.FromMilliseconds(20000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceMonitoringServiceClient.CreateService</c> and <c>ServiceMonitoringServiceClient.CreateServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ServiceMonitoringServiceClient.CreateService</c> and
        /// <c>ServiceMonitoringServiceClient.CreateServiceAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings CreateServiceSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceMonitoringServiceClient.GetService</c> and <c>ServiceMonitoringServiceClient.GetServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ServiceMonitoringServiceClient.GetService</c> and
        /// <c>ServiceMonitoringServiceClient.GetServiceAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetServiceSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceMonitoringServiceClient.ListServices</c> and <c>ServiceMonitoringServiceClient.ListServicesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ServiceMonitoringServiceClient.ListServices</c> and
        /// <c>ServiceMonitoringServiceClient.ListServicesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListServicesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceMonitoringServiceClient.UpdateService</c> and <c>ServiceMonitoringServiceClient.UpdateServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ServiceMonitoringServiceClient.UpdateService</c> and
        /// <c>ServiceMonitoringServiceClient.UpdateServiceAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings UpdateServiceSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceMonitoringServiceClient.DeleteService</c> and <c>ServiceMonitoringServiceClient.DeleteServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ServiceMonitoringServiceClient.DeleteService</c> and
        /// <c>ServiceMonitoringServiceClient.DeleteServiceAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings DeleteServiceSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceMonitoringServiceClient.CreateServiceLevelObjective</c> and <c>ServiceMonitoringServiceClient.CreateServiceLevelObjectiveAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ServiceMonitoringServiceClient.CreateServiceLevelObjective</c> and
        /// <c>ServiceMonitoringServiceClient.CreateServiceLevelObjectiveAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings CreateServiceLevelObjectiveSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceMonitoringServiceClient.GetServiceLevelObjective</c> and <c>ServiceMonitoringServiceClient.GetServiceLevelObjectiveAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ServiceMonitoringServiceClient.GetServiceLevelObjective</c> and
        /// <c>ServiceMonitoringServiceClient.GetServiceLevelObjectiveAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetServiceLevelObjectiveSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceMonitoringServiceClient.ListServiceLevelObjectives</c> and <c>ServiceMonitoringServiceClient.ListServiceLevelObjectivesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ServiceMonitoringServiceClient.ListServiceLevelObjectives</c> and
        /// <c>ServiceMonitoringServiceClient.ListServiceLevelObjectivesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListServiceLevelObjectivesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceMonitoringServiceClient.UpdateServiceLevelObjective</c> and <c>ServiceMonitoringServiceClient.UpdateServiceLevelObjectiveAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ServiceMonitoringServiceClient.UpdateServiceLevelObjective</c> and
        /// <c>ServiceMonitoringServiceClient.UpdateServiceLevelObjectiveAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings UpdateServiceLevelObjectiveSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceMonitoringServiceClient.DeleteServiceLevelObjective</c> and <c>ServiceMonitoringServiceClient.DeleteServiceLevelObjectiveAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ServiceMonitoringServiceClient.DeleteServiceLevelObjective</c> and
        /// <c>ServiceMonitoringServiceClient.DeleteServiceLevelObjectiveAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings DeleteServiceLevelObjectiveSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="ServiceMonitoringServiceSettings"/> object.</returns>
        public ServiceMonitoringServiceSettings Clone() => new ServiceMonitoringServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ServiceMonitoringServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ServiceMonitoringServiceClientBuilder : gaxgrpc::ClientBuilderBase<ServiceMonitoringServiceClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public ServiceMonitoringServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override ServiceMonitoringServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ServiceMonitoringServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<ServiceMonitoringServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ServiceMonitoringServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => ServiceMonitoringServiceClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => ServiceMonitoringServiceClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => ServiceMonitoringServiceClient.ChannelPool;
    }

    /// <summary>
    /// ServiceMonitoringService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class ServiceMonitoringServiceClient
    {
        /// <summary>
        /// The default endpoint for the ServiceMonitoringService service, which is a host of "monitoring.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("monitoring.googleapis.com", 443);

        /// <summary>
        /// The default ServiceMonitoringService scopes.
        /// </summary>
        /// <remarks>
        /// The default ServiceMonitoringService scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/monitoring"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/monitoring.read"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/monitoring.write"</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/monitoring",
            "https://www.googleapis.com/auth/monitoring.read",
            "https://www.googleapis.com/auth/monitoring.write",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="ServiceMonitoringServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Monitoring.V3;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ServiceMonitoringServiceClient client = await ServiceMonitoringServiceClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Monitoring.V3;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ServiceMonitoringServiceClient.DefaultEndpoint.Host, ServiceMonitoringServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ServiceMonitoringServiceClient client = ServiceMonitoringServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ServiceMonitoringServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="ServiceMonitoringServiceClient"/>.</returns>
        public static async stt::Task<ServiceMonitoringServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, ServiceMonitoringServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="ServiceMonitoringServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Monitoring.V3;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ServiceMonitoringServiceClient client = ServiceMonitoringServiceClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Monitoring.V3;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ServiceMonitoringServiceClient.DefaultEndpoint.Host, ServiceMonitoringServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ServiceMonitoringServiceClient client = ServiceMonitoringServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ServiceMonitoringServiceSettings"/>.</param>
        /// <returns>The created <see cref="ServiceMonitoringServiceClient"/>.</returns>
        public static ServiceMonitoringServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, ServiceMonitoringServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="ServiceMonitoringServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ServiceMonitoringServiceSettings"/>.</param>
        /// <returns>The created <see cref="ServiceMonitoringServiceClient"/>.</returns>
        public static ServiceMonitoringServiceClient Create(grpccore::Channel channel, ServiceMonitoringServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="ServiceMonitoringServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ServiceMonitoringServiceSettings"/>.</param>
        /// <returns>The created <see cref="ServiceMonitoringServiceClient"/>.</returns>
        public static ServiceMonitoringServiceClient Create(grpccore::CallInvoker callInvoker, ServiceMonitoringServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ServiceMonitoringService.ServiceMonitoringServiceClient grpcClient = new ServiceMonitoringService.ServiceMonitoringServiceClient(callInvoker);
            return new ServiceMonitoringServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, ServiceMonitoringServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, ServiceMonitoringServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, ServiceMonitoringServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, ServiceMonitoringServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC ServiceMonitoringService client.
        /// </summary>
        public virtual ServiceMonitoringService.ServiceMonitoringServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Create a `Service`.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the parent workspace.
        /// Of the form `projects/{project_id}`.
        /// </param>
        /// <param name="service">
        /// The `Service` to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Service> CreateServiceAsync(
            ProjectName parent,
            Service service,
            gaxgrpc::CallSettings callSettings = null) => CreateServiceAsync(
                new CreateServiceRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
                },
                callSettings);

        /// <summary>
        /// Create a `Service`.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the parent workspace.
        /// Of the form `projects/{project_id}`.
        /// </param>
        /// <param name="service">
        /// The `Service` to create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Service> CreateServiceAsync(
            ProjectName parent,
            Service service,
            st::CancellationToken cancellationToken) => CreateServiceAsync(
                parent,
                service,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a `Service`.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the parent workspace.
        /// Of the form `projects/{project_id}`.
        /// </param>
        /// <param name="service">
        /// The `Service` to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Service CreateService(
            ProjectName parent,
            Service service,
            gaxgrpc::CallSettings callSettings = null) => CreateService(
                new CreateServiceRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
                },
                callSettings);

        /// <summary>
        /// Create a `Service`.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the parent workspace.
        /// Of the form `projects/{project_id}`.
        /// </param>
        /// <param name="service">
        /// The `Service` to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Service> CreateServiceAsync(
            string parent,
            Service service,
            gaxgrpc::CallSettings callSettings = null) => CreateServiceAsync(
                new CreateServiceRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
                },
                callSettings);

        /// <summary>
        /// Create a `Service`.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the parent workspace.
        /// Of the form `projects/{project_id}`.
        /// </param>
        /// <param name="service">
        /// The `Service` to create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Service> CreateServiceAsync(
            string parent,
            Service service,
            st::CancellationToken cancellationToken) => CreateServiceAsync(
                parent,
                service,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a `Service`.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the parent workspace.
        /// Of the form `projects/{project_id}`.
        /// </param>
        /// <param name="service">
        /// The `Service` to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Service CreateService(
            string parent,
            Service service,
            gaxgrpc::CallSettings callSettings = null) => CreateService(
                new CreateServiceRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
                },
                callSettings);

        /// <summary>
        /// Create a `Service`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Service> CreateServiceAsync(
            CreateServiceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Create a `Service`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Service> CreateServiceAsync(
            CreateServiceRequest request,
            st::CancellationToken cancellationToken) => CreateServiceAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a `Service`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Service CreateService(
            CreateServiceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Get the named `Service`.
        /// </summary>
        /// <param name="name">
        /// Resource name of the `Service`.
        /// Of the form `projects/{project_id}/services/{service_id}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Service> GetServiceAsync(
            ServiceName name,
            gaxgrpc::CallSettings callSettings = null) => GetServiceAsync(
                new GetServiceRequest
                {
                    ServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Get the named `Service`.
        /// </summary>
        /// <param name="name">
        /// Resource name of the `Service`.
        /// Of the form `projects/{project_id}/services/{service_id}`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Service> GetServiceAsync(
            ServiceName name,
            st::CancellationToken cancellationToken) => GetServiceAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the named `Service`.
        /// </summary>
        /// <param name="name">
        /// Resource name of the `Service`.
        /// Of the form `projects/{project_id}/services/{service_id}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Service GetService(
            ServiceName name,
            gaxgrpc::CallSettings callSettings = null) => GetService(
                new GetServiceRequest
                {
                    ServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Get the named `Service`.
        /// </summary>
        /// <param name="name">
        /// Resource name of the `Service`.
        /// Of the form `projects/{project_id}/services/{service_id}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Service> GetServiceAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetServiceAsync(
                new GetServiceRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Get the named `Service`.
        /// </summary>
        /// <param name="name">
        /// Resource name of the `Service`.
        /// Of the form `projects/{project_id}/services/{service_id}`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Service> GetServiceAsync(
            string name,
            st::CancellationToken cancellationToken) => GetServiceAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the named `Service`.
        /// </summary>
        /// <param name="name">
        /// Resource name of the `Service`.
        /// Of the form `projects/{project_id}/services/{service_id}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Service GetService(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetService(
                new GetServiceRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Get the named `Service`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Service> GetServiceAsync(
            GetServiceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Get the named `Service`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Service> GetServiceAsync(
            GetServiceRequest request,
            st::CancellationToken cancellationToken) => GetServiceAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the named `Service`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Service GetService(
            GetServiceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// List `Service`s for this workspace.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the parent `Workspace`.
        /// Of the form `projects/{project_id}`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Service"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListServicesResponse, Service> ListServicesAsync(
            ProjectName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListServicesAsync(
                new ListServicesRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// List `Service`s for this workspace.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the parent `Workspace`.
        /// Of the form `projects/{project_id}`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Service"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListServicesResponse, Service> ListServices(
            ProjectName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListServices(
                new ListServicesRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// List `Service`s for this workspace.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the parent `Workspace`.
        /// Of the form `projects/{project_id}`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Service"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListServicesResponse, Service> ListServicesAsync(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListServicesAsync(
                new ListServicesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// List `Service`s for this workspace.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the parent `Workspace`.
        /// Of the form `projects/{project_id}`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Service"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListServicesResponse, Service> ListServices(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListServices(
                new ListServicesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// List `Service`s for this workspace.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Service"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListServicesResponse, Service> ListServicesAsync(
            ListServicesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// List `Service`s for this workspace.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Service"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListServicesResponse, Service> ListServices(
            ListServicesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Update this `Service`.
        /// </summary>
        /// <param name="service">
        /// The `Service` to draw updates from.
        /// The given `name` specifies the resource to update.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Service> UpdateServiceAsync(
            Service service,
            gaxgrpc::CallSettings callSettings = null) => UpdateServiceAsync(
                new UpdateServiceRequest
                {
                    Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
                },
                callSettings);

        /// <summary>
        /// Update this `Service`.
        /// </summary>
        /// <param name="service">
        /// The `Service` to draw updates from.
        /// The given `name` specifies the resource to update.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Service> UpdateServiceAsync(
            Service service,
            st::CancellationToken cancellationToken) => UpdateServiceAsync(
                service,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update this `Service`.
        /// </summary>
        /// <param name="service">
        /// The `Service` to draw updates from.
        /// The given `name` specifies the resource to update.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Service UpdateService(
            Service service,
            gaxgrpc::CallSettings callSettings = null) => UpdateService(
                new UpdateServiceRequest
                {
                    Service = gax::GaxPreconditions.CheckNotNull(service, nameof(service)),
                },
                callSettings);

        /// <summary>
        /// Update this `Service`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Service> UpdateServiceAsync(
            UpdateServiceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Update this `Service`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Service> UpdateServiceAsync(
            UpdateServiceRequest request,
            st::CancellationToken cancellationToken) => UpdateServiceAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update this `Service`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Service UpdateService(
            UpdateServiceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Soft delete this `Service`.
        /// </summary>
        /// <param name="name">
        /// Resource name of the `Service` to delete.
        /// Of the form `projects/{project_id}/service/{service_id}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteServiceAsync(
            ServiceName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteServiceAsync(
                new DeleteServiceRequest
                {
                    ServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Soft delete this `Service`.
        /// </summary>
        /// <param name="name">
        /// Resource name of the `Service` to delete.
        /// Of the form `projects/{project_id}/service/{service_id}`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteServiceAsync(
            ServiceName name,
            st::CancellationToken cancellationToken) => DeleteServiceAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Soft delete this `Service`.
        /// </summary>
        /// <param name="name">
        /// Resource name of the `Service` to delete.
        /// Of the form `projects/{project_id}/service/{service_id}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteService(
            ServiceName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteService(
                new DeleteServiceRequest
                {
                    ServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Soft delete this `Service`.
        /// </summary>
        /// <param name="name">
        /// Resource name of the `Service` to delete.
        /// Of the form `projects/{project_id}/service/{service_id}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteServiceAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteServiceAsync(
                new DeleteServiceRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Soft delete this `Service`.
        /// </summary>
        /// <param name="name">
        /// Resource name of the `Service` to delete.
        /// Of the form `projects/{project_id}/service/{service_id}`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteServiceAsync(
            string name,
            st::CancellationToken cancellationToken) => DeleteServiceAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Soft delete this `Service`.
        /// </summary>
        /// <param name="name">
        /// Resource name of the `Service` to delete.
        /// Of the form `projects/{project_id}/service/{service_id}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteService(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteService(
                new DeleteServiceRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Soft delete this `Service`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteServiceAsync(
            DeleteServiceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Soft delete this `Service`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteServiceAsync(
            DeleteServiceRequest request,
            st::CancellationToken cancellationToken) => DeleteServiceAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Soft delete this `Service`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteService(
            DeleteServiceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Create a `ServiceLevelObjective` for the given `Service`.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the parent `Service`.
        /// Of the form `projects/{project_id}/services/{service_id}`.
        /// </param>
        /// <param name="serviceLevelObjective">
        /// The `ServiceLevelObjective` to create.
        /// The provided `name` will be respected if no `ServiceLevelObjective` exists
        /// with this name.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ServiceLevelObjective> CreateServiceLevelObjectiveAsync(
            ServiceName parent,
            ServiceLevelObjective serviceLevelObjective,
            gaxgrpc::CallSettings callSettings = null) => CreateServiceLevelObjectiveAsync(
                new CreateServiceLevelObjectiveRequest
                {
                    ParentAsServiceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    ServiceLevelObjective = gax::GaxPreconditions.CheckNotNull(serviceLevelObjective, nameof(serviceLevelObjective)),
                },
                callSettings);

        /// <summary>
        /// Create a `ServiceLevelObjective` for the given `Service`.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the parent `Service`.
        /// Of the form `projects/{project_id}/services/{service_id}`.
        /// </param>
        /// <param name="serviceLevelObjective">
        /// The `ServiceLevelObjective` to create.
        /// The provided `name` will be respected if no `ServiceLevelObjective` exists
        /// with this name.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ServiceLevelObjective> CreateServiceLevelObjectiveAsync(
            ServiceName parent,
            ServiceLevelObjective serviceLevelObjective,
            st::CancellationToken cancellationToken) => CreateServiceLevelObjectiveAsync(
                parent,
                serviceLevelObjective,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a `ServiceLevelObjective` for the given `Service`.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the parent `Service`.
        /// Of the form `projects/{project_id}/services/{service_id}`.
        /// </param>
        /// <param name="serviceLevelObjective">
        /// The `ServiceLevelObjective` to create.
        /// The provided `name` will be respected if no `ServiceLevelObjective` exists
        /// with this name.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ServiceLevelObjective CreateServiceLevelObjective(
            ServiceName parent,
            ServiceLevelObjective serviceLevelObjective,
            gaxgrpc::CallSettings callSettings = null) => CreateServiceLevelObjective(
                new CreateServiceLevelObjectiveRequest
                {
                    ParentAsServiceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    ServiceLevelObjective = gax::GaxPreconditions.CheckNotNull(serviceLevelObjective, nameof(serviceLevelObjective)),
                },
                callSettings);

        /// <summary>
        /// Create a `ServiceLevelObjective` for the given `Service`.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the parent `Service`.
        /// Of the form `projects/{project_id}/services/{service_id}`.
        /// </param>
        /// <param name="serviceLevelObjective">
        /// The `ServiceLevelObjective` to create.
        /// The provided `name` will be respected if no `ServiceLevelObjective` exists
        /// with this name.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ServiceLevelObjective> CreateServiceLevelObjectiveAsync(
            string parent,
            ServiceLevelObjective serviceLevelObjective,
            gaxgrpc::CallSettings callSettings = null) => CreateServiceLevelObjectiveAsync(
                new CreateServiceLevelObjectiveRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    ServiceLevelObjective = gax::GaxPreconditions.CheckNotNull(serviceLevelObjective, nameof(serviceLevelObjective)),
                },
                callSettings);

        /// <summary>
        /// Create a `ServiceLevelObjective` for the given `Service`.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the parent `Service`.
        /// Of the form `projects/{project_id}/services/{service_id}`.
        /// </param>
        /// <param name="serviceLevelObjective">
        /// The `ServiceLevelObjective` to create.
        /// The provided `name` will be respected if no `ServiceLevelObjective` exists
        /// with this name.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ServiceLevelObjective> CreateServiceLevelObjectiveAsync(
            string parent,
            ServiceLevelObjective serviceLevelObjective,
            st::CancellationToken cancellationToken) => CreateServiceLevelObjectiveAsync(
                parent,
                serviceLevelObjective,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a `ServiceLevelObjective` for the given `Service`.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the parent `Service`.
        /// Of the form `projects/{project_id}/services/{service_id}`.
        /// </param>
        /// <param name="serviceLevelObjective">
        /// The `ServiceLevelObjective` to create.
        /// The provided `name` will be respected if no `ServiceLevelObjective` exists
        /// with this name.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ServiceLevelObjective CreateServiceLevelObjective(
            string parent,
            ServiceLevelObjective serviceLevelObjective,
            gaxgrpc::CallSettings callSettings = null) => CreateServiceLevelObjective(
                new CreateServiceLevelObjectiveRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    ServiceLevelObjective = gax::GaxPreconditions.CheckNotNull(serviceLevelObjective, nameof(serviceLevelObjective)),
                },
                callSettings);

        /// <summary>
        /// Create a `ServiceLevelObjective` for the given `Service`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ServiceLevelObjective> CreateServiceLevelObjectiveAsync(
            CreateServiceLevelObjectiveRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Create a `ServiceLevelObjective` for the given `Service`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ServiceLevelObjective> CreateServiceLevelObjectiveAsync(
            CreateServiceLevelObjectiveRequest request,
            st::CancellationToken cancellationToken) => CreateServiceLevelObjectiveAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a `ServiceLevelObjective` for the given `Service`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ServiceLevelObjective CreateServiceLevelObjective(
            CreateServiceLevelObjectiveRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Get a `ServiceLevelObjective` by name.
        /// </summary>
        /// <param name="name">
        /// Resource name of the `ServiceLevelObjective` to get.
        /// Of the form
        /// `projects/{project_id}/services/{service_id}/serviceLevelObjectives/{slo_name}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ServiceLevelObjective> GetServiceLevelObjectiveAsync(
            ServiceLevelObjectiveName name,
            gaxgrpc::CallSettings callSettings = null) => GetServiceLevelObjectiveAsync(
                new GetServiceLevelObjectiveRequest
                {
                    ServiceLevelObjectiveName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Get a `ServiceLevelObjective` by name.
        /// </summary>
        /// <param name="name">
        /// Resource name of the `ServiceLevelObjective` to get.
        /// Of the form
        /// `projects/{project_id}/services/{service_id}/serviceLevelObjectives/{slo_name}`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ServiceLevelObjective> GetServiceLevelObjectiveAsync(
            ServiceLevelObjectiveName name,
            st::CancellationToken cancellationToken) => GetServiceLevelObjectiveAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a `ServiceLevelObjective` by name.
        /// </summary>
        /// <param name="name">
        /// Resource name of the `ServiceLevelObjective` to get.
        /// Of the form
        /// `projects/{project_id}/services/{service_id}/serviceLevelObjectives/{slo_name}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ServiceLevelObjective GetServiceLevelObjective(
            ServiceLevelObjectiveName name,
            gaxgrpc::CallSettings callSettings = null) => GetServiceLevelObjective(
                new GetServiceLevelObjectiveRequest
                {
                    ServiceLevelObjectiveName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Get a `ServiceLevelObjective` by name.
        /// </summary>
        /// <param name="name">
        /// Resource name of the `ServiceLevelObjective` to get.
        /// Of the form
        /// `projects/{project_id}/services/{service_id}/serviceLevelObjectives/{slo_name}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ServiceLevelObjective> GetServiceLevelObjectiveAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetServiceLevelObjectiveAsync(
                new GetServiceLevelObjectiveRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Get a `ServiceLevelObjective` by name.
        /// </summary>
        /// <param name="name">
        /// Resource name of the `ServiceLevelObjective` to get.
        /// Of the form
        /// `projects/{project_id}/services/{service_id}/serviceLevelObjectives/{slo_name}`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ServiceLevelObjective> GetServiceLevelObjectiveAsync(
            string name,
            st::CancellationToken cancellationToken) => GetServiceLevelObjectiveAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a `ServiceLevelObjective` by name.
        /// </summary>
        /// <param name="name">
        /// Resource name of the `ServiceLevelObjective` to get.
        /// Of the form
        /// `projects/{project_id}/services/{service_id}/serviceLevelObjectives/{slo_name}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ServiceLevelObjective GetServiceLevelObjective(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetServiceLevelObjective(
                new GetServiceLevelObjectiveRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Get a `ServiceLevelObjective` by name.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ServiceLevelObjective> GetServiceLevelObjectiveAsync(
            GetServiceLevelObjectiveRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Get a `ServiceLevelObjective` by name.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ServiceLevelObjective> GetServiceLevelObjectiveAsync(
            GetServiceLevelObjectiveRequest request,
            st::CancellationToken cancellationToken) => GetServiceLevelObjectiveAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a `ServiceLevelObjective` by name.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ServiceLevelObjective GetServiceLevelObjective(
            GetServiceLevelObjectiveRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// List the `ServiceLevelObjective`s for the given `Service`.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the parent `Service`.
        /// Of the form `projects/{project_id}/services/{service_id}`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ServiceLevelObjective"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListServiceLevelObjectivesResponse, ServiceLevelObjective> ListServiceLevelObjectivesAsync(
            ServiceName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListServiceLevelObjectivesAsync(
                new ListServiceLevelObjectivesRequest
                {
                    ParentAsServiceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// List the `ServiceLevelObjective`s for the given `Service`.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the parent `Service`.
        /// Of the form `projects/{project_id}/services/{service_id}`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="ServiceLevelObjective"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListServiceLevelObjectivesResponse, ServiceLevelObjective> ListServiceLevelObjectives(
            ServiceName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListServiceLevelObjectives(
                new ListServiceLevelObjectivesRequest
                {
                    ParentAsServiceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// List the `ServiceLevelObjective`s for the given `Service`.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the parent `Service`.
        /// Of the form `projects/{project_id}/services/{service_id}`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ServiceLevelObjective"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListServiceLevelObjectivesResponse, ServiceLevelObjective> ListServiceLevelObjectivesAsync(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListServiceLevelObjectivesAsync(
                new ListServiceLevelObjectivesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// List the `ServiceLevelObjective`s for the given `Service`.
        /// </summary>
        /// <param name="parent">
        /// Resource name of the parent `Service`.
        /// Of the form `projects/{project_id}/services/{service_id}`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="ServiceLevelObjective"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListServiceLevelObjectivesResponse, ServiceLevelObjective> ListServiceLevelObjectives(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListServiceLevelObjectives(
                new ListServiceLevelObjectivesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// List the `ServiceLevelObjective`s for the given `Service`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ServiceLevelObjective"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListServiceLevelObjectivesResponse, ServiceLevelObjective> ListServiceLevelObjectivesAsync(
            ListServiceLevelObjectivesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// List the `ServiceLevelObjective`s for the given `Service`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="ServiceLevelObjective"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListServiceLevelObjectivesResponse, ServiceLevelObjective> ListServiceLevelObjectives(
            ListServiceLevelObjectivesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Update the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="serviceLevelObjective">
        /// The `ServiceLevelObjective` to draw updates from.
        /// The given `name` specifies the resource to update.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ServiceLevelObjective> UpdateServiceLevelObjectiveAsync(
            ServiceLevelObjective serviceLevelObjective,
            gaxgrpc::CallSettings callSettings = null) => UpdateServiceLevelObjectiveAsync(
                new UpdateServiceLevelObjectiveRequest
                {
                    ServiceLevelObjective = gax::GaxPreconditions.CheckNotNull(serviceLevelObjective, nameof(serviceLevelObjective)),
                },
                callSettings);

        /// <summary>
        /// Update the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="serviceLevelObjective">
        /// The `ServiceLevelObjective` to draw updates from.
        /// The given `name` specifies the resource to update.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ServiceLevelObjective> UpdateServiceLevelObjectiveAsync(
            ServiceLevelObjective serviceLevelObjective,
            st::CancellationToken cancellationToken) => UpdateServiceLevelObjectiveAsync(
                serviceLevelObjective,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="serviceLevelObjective">
        /// The `ServiceLevelObjective` to draw updates from.
        /// The given `name` specifies the resource to update.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ServiceLevelObjective UpdateServiceLevelObjective(
            ServiceLevelObjective serviceLevelObjective,
            gaxgrpc::CallSettings callSettings = null) => UpdateServiceLevelObjective(
                new UpdateServiceLevelObjectiveRequest
                {
                    ServiceLevelObjective = gax::GaxPreconditions.CheckNotNull(serviceLevelObjective, nameof(serviceLevelObjective)),
                },
                callSettings);

        /// <summary>
        /// Update the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ServiceLevelObjective> UpdateServiceLevelObjectiveAsync(
            UpdateServiceLevelObjectiveRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Update the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ServiceLevelObjective> UpdateServiceLevelObjectiveAsync(
            UpdateServiceLevelObjectiveRequest request,
            st::CancellationToken cancellationToken) => UpdateServiceLevelObjectiveAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ServiceLevelObjective UpdateServiceLevelObjective(
            UpdateServiceLevelObjectiveRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Delete the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="name">
        /// Resource name of the `ServiceLevelObjective` to delete.
        /// Of the form
        /// `projects/{project_id}/services/{service_id}/serviceLevelObjectives/{slo_name}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteServiceLevelObjectiveAsync(
            ServiceLevelObjectiveName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteServiceLevelObjectiveAsync(
                new DeleteServiceLevelObjectiveRequest
                {
                    ServiceLevelObjectiveName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Delete the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="name">
        /// Resource name of the `ServiceLevelObjective` to delete.
        /// Of the form
        /// `projects/{project_id}/services/{service_id}/serviceLevelObjectives/{slo_name}`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteServiceLevelObjectiveAsync(
            ServiceLevelObjectiveName name,
            st::CancellationToken cancellationToken) => DeleteServiceLevelObjectiveAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="name">
        /// Resource name of the `ServiceLevelObjective` to delete.
        /// Of the form
        /// `projects/{project_id}/services/{service_id}/serviceLevelObjectives/{slo_name}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteServiceLevelObjective(
            ServiceLevelObjectiveName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteServiceLevelObjective(
                new DeleteServiceLevelObjectiveRequest
                {
                    ServiceLevelObjectiveName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Delete the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="name">
        /// Resource name of the `ServiceLevelObjective` to delete.
        /// Of the form
        /// `projects/{project_id}/services/{service_id}/serviceLevelObjectives/{slo_name}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteServiceLevelObjectiveAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteServiceLevelObjectiveAsync(
                new DeleteServiceLevelObjectiveRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Delete the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="name">
        /// Resource name of the `ServiceLevelObjective` to delete.
        /// Of the form
        /// `projects/{project_id}/services/{service_id}/serviceLevelObjectives/{slo_name}`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteServiceLevelObjectiveAsync(
            string name,
            st::CancellationToken cancellationToken) => DeleteServiceLevelObjectiveAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="name">
        /// Resource name of the `ServiceLevelObjective` to delete.
        /// Of the form
        /// `projects/{project_id}/services/{service_id}/serviceLevelObjectives/{slo_name}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteServiceLevelObjective(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteServiceLevelObjective(
                new DeleteServiceLevelObjectiveRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Delete the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteServiceLevelObjectiveAsync(
            DeleteServiceLevelObjectiveRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Delete the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteServiceLevelObjectiveAsync(
            DeleteServiceLevelObjectiveRequest request,
            st::CancellationToken cancellationToken) => DeleteServiceLevelObjectiveAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteServiceLevelObjective(
            DeleteServiceLevelObjectiveRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// ServiceMonitoringService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class ServiceMonitoringServiceClientImpl : ServiceMonitoringServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateServiceRequest, Service> _callCreateService;
        private readonly gaxgrpc::ApiCall<GetServiceRequest, Service> _callGetService;
        private readonly gaxgrpc::ApiCall<ListServicesRequest, ListServicesResponse> _callListServices;
        private readonly gaxgrpc::ApiCall<UpdateServiceRequest, Service> _callUpdateService;
        private readonly gaxgrpc::ApiCall<DeleteServiceRequest, pbwkt::Empty> _callDeleteService;
        private readonly gaxgrpc::ApiCall<CreateServiceLevelObjectiveRequest, ServiceLevelObjective> _callCreateServiceLevelObjective;
        private readonly gaxgrpc::ApiCall<GetServiceLevelObjectiveRequest, ServiceLevelObjective> _callGetServiceLevelObjective;
        private readonly gaxgrpc::ApiCall<ListServiceLevelObjectivesRequest, ListServiceLevelObjectivesResponse> _callListServiceLevelObjectives;
        private readonly gaxgrpc::ApiCall<UpdateServiceLevelObjectiveRequest, ServiceLevelObjective> _callUpdateServiceLevelObjective;
        private readonly gaxgrpc::ApiCall<DeleteServiceLevelObjectiveRequest, pbwkt::Empty> _callDeleteServiceLevelObjective;

        /// <summary>
        /// Constructs a client wrapper for the ServiceMonitoringService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ServiceMonitoringServiceSettings"/> used within this client </param>
        public ServiceMonitoringServiceClientImpl(ServiceMonitoringService.ServiceMonitoringServiceClient grpcClient, ServiceMonitoringServiceSettings settings)
        {
            GrpcClient = grpcClient;
            ServiceMonitoringServiceSettings effectiveSettings = settings ?? ServiceMonitoringServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callCreateService = clientHelper.BuildApiCall<CreateServiceRequest, Service>(
                GrpcClient.CreateServiceAsync, GrpcClient.CreateService, effectiveSettings.CreateServiceSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callGetService = clientHelper.BuildApiCall<GetServiceRequest, Service>(
                GrpcClient.GetServiceAsync, GrpcClient.GetService, effectiveSettings.GetServiceSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callListServices = clientHelper.BuildApiCall<ListServicesRequest, ListServicesResponse>(
                GrpcClient.ListServicesAsync, GrpcClient.ListServices, effectiveSettings.ListServicesSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callUpdateService = clientHelper.BuildApiCall<UpdateServiceRequest, Service>(
                GrpcClient.UpdateServiceAsync, GrpcClient.UpdateService, effectiveSettings.UpdateServiceSettings)
                .WithGoogleRequestParam("service.name", request => request.Service?.Name);
            _callDeleteService = clientHelper.BuildApiCall<DeleteServiceRequest, pbwkt::Empty>(
                GrpcClient.DeleteServiceAsync, GrpcClient.DeleteService, effectiveSettings.DeleteServiceSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callCreateServiceLevelObjective = clientHelper.BuildApiCall<CreateServiceLevelObjectiveRequest, ServiceLevelObjective>(
                GrpcClient.CreateServiceLevelObjectiveAsync, GrpcClient.CreateServiceLevelObjective, effectiveSettings.CreateServiceLevelObjectiveSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callGetServiceLevelObjective = clientHelper.BuildApiCall<GetServiceLevelObjectiveRequest, ServiceLevelObjective>(
                GrpcClient.GetServiceLevelObjectiveAsync, GrpcClient.GetServiceLevelObjective, effectiveSettings.GetServiceLevelObjectiveSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callListServiceLevelObjectives = clientHelper.BuildApiCall<ListServiceLevelObjectivesRequest, ListServiceLevelObjectivesResponse>(
                GrpcClient.ListServiceLevelObjectivesAsync, GrpcClient.ListServiceLevelObjectives, effectiveSettings.ListServiceLevelObjectivesSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callUpdateServiceLevelObjective = clientHelper.BuildApiCall<UpdateServiceLevelObjectiveRequest, ServiceLevelObjective>(
                GrpcClient.UpdateServiceLevelObjectiveAsync, GrpcClient.UpdateServiceLevelObjective, effectiveSettings.UpdateServiceLevelObjectiveSettings)
                .WithGoogleRequestParam("service_level_objective.name", request => request.ServiceLevelObjective?.Name);
            _callDeleteServiceLevelObjective = clientHelper.BuildApiCall<DeleteServiceLevelObjectiveRequest, pbwkt::Empty>(
                GrpcClient.DeleteServiceLevelObjectiveAsync, GrpcClient.DeleteServiceLevelObjective, effectiveSettings.DeleteServiceLevelObjectiveSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCreateService);
            Modify_CreateServiceApiCall(ref _callCreateService);
            Modify_ApiCall(ref _callGetService);
            Modify_GetServiceApiCall(ref _callGetService);
            Modify_ApiCall(ref _callListServices);
            Modify_ListServicesApiCall(ref _callListServices);
            Modify_ApiCall(ref _callUpdateService);
            Modify_UpdateServiceApiCall(ref _callUpdateService);
            Modify_ApiCall(ref _callDeleteService);
            Modify_DeleteServiceApiCall(ref _callDeleteService);
            Modify_ApiCall(ref _callCreateServiceLevelObjective);
            Modify_CreateServiceLevelObjectiveApiCall(ref _callCreateServiceLevelObjective);
            Modify_ApiCall(ref _callGetServiceLevelObjective);
            Modify_GetServiceLevelObjectiveApiCall(ref _callGetServiceLevelObjective);
            Modify_ApiCall(ref _callListServiceLevelObjectives);
            Modify_ListServiceLevelObjectivesApiCall(ref _callListServiceLevelObjectives);
            Modify_ApiCall(ref _callUpdateServiceLevelObjective);
            Modify_UpdateServiceLevelObjectiveApiCall(ref _callUpdateServiceLevelObjective);
            Modify_ApiCall(ref _callDeleteServiceLevelObjective);
            Modify_DeleteServiceLevelObjectiveApiCall(ref _callDeleteServiceLevelObjective);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        // Partial methods are named to (mostly) ensure there cannot be conflicts with RPC method names.

        // Partial methods called for every ApiCall on construction.
        // Allows modification of all the underlying ApiCall objects.
        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call)
            where TRequest : class, pb::IMessage<TRequest>
            where TResponse : class, pb::IMessage<TResponse>;

        // Partial methods called for each ApiCall on construction.
        // Allows per-RPC-method modification of the underlying ApiCall object.
        partial void Modify_CreateServiceApiCall(ref gaxgrpc::ApiCall<CreateServiceRequest, Service> call);
        partial void Modify_GetServiceApiCall(ref gaxgrpc::ApiCall<GetServiceRequest, Service> call);
        partial void Modify_ListServicesApiCall(ref gaxgrpc::ApiCall<ListServicesRequest, ListServicesResponse> call);
        partial void Modify_UpdateServiceApiCall(ref gaxgrpc::ApiCall<UpdateServiceRequest, Service> call);
        partial void Modify_DeleteServiceApiCall(ref gaxgrpc::ApiCall<DeleteServiceRequest, pbwkt::Empty> call);
        partial void Modify_CreateServiceLevelObjectiveApiCall(ref gaxgrpc::ApiCall<CreateServiceLevelObjectiveRequest, ServiceLevelObjective> call);
        partial void Modify_GetServiceLevelObjectiveApiCall(ref gaxgrpc::ApiCall<GetServiceLevelObjectiveRequest, ServiceLevelObjective> call);
        partial void Modify_ListServiceLevelObjectivesApiCall(ref gaxgrpc::ApiCall<ListServiceLevelObjectivesRequest, ListServiceLevelObjectivesResponse> call);
        partial void Modify_UpdateServiceLevelObjectiveApiCall(ref gaxgrpc::ApiCall<UpdateServiceLevelObjectiveRequest, ServiceLevelObjective> call);
        partial void Modify_DeleteServiceLevelObjectiveApiCall(ref gaxgrpc::ApiCall<DeleteServiceLevelObjectiveRequest, pbwkt::Empty> call);
        partial void OnConstruction(ServiceMonitoringService.ServiceMonitoringServiceClient grpcClient, ServiceMonitoringServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC ServiceMonitoringService client.
        /// </summary>
        public override ServiceMonitoringService.ServiceMonitoringServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_CreateServiceRequest(ref CreateServiceRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetServiceRequest(ref GetServiceRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListServicesRequest(ref ListServicesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateServiceRequest(ref UpdateServiceRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteServiceRequest(ref DeleteServiceRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateServiceLevelObjectiveRequest(ref CreateServiceLevelObjectiveRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetServiceLevelObjectiveRequest(ref GetServiceLevelObjectiveRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListServiceLevelObjectivesRequest(ref ListServiceLevelObjectivesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateServiceLevelObjectiveRequest(ref UpdateServiceLevelObjectiveRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteServiceLevelObjectiveRequest(ref DeleteServiceLevelObjectiveRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Create a `Service`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<Service> CreateServiceAsync(
            CreateServiceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServiceRequest(ref request, ref callSettings);
            return _callCreateService.Async(request, callSettings);
        }

        /// <summary>
        /// Create a `Service`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override Service CreateService(
            CreateServiceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServiceRequest(ref request, ref callSettings);
            return _callCreateService.Sync(request, callSettings);
        }

        /// <summary>
        /// Get the named `Service`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<Service> GetServiceAsync(
            GetServiceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceRequest(ref request, ref callSettings);
            return _callGetService.Async(request, callSettings);
        }

        /// <summary>
        /// Get the named `Service`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override Service GetService(
            GetServiceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceRequest(ref request, ref callSettings);
            return _callGetService.Sync(request, callSettings);
        }

        /// <summary>
        /// List `Service`s for this workspace.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Service"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListServicesResponse, Service> ListServicesAsync(
            ListServicesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListServicesRequest, ListServicesResponse, Service>(_callListServices, request, callSettings);
        }

        /// <summary>
        /// List `Service`s for this workspace.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Service"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListServicesResponse, Service> ListServices(
            ListServicesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListServicesRequest, ListServicesResponse, Service>(_callListServices, request, callSettings);
        }

        /// <summary>
        /// Update this `Service`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<Service> UpdateServiceAsync(
            UpdateServiceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateServiceRequest(ref request, ref callSettings);
            return _callUpdateService.Async(request, callSettings);
        }

        /// <summary>
        /// Update this `Service`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override Service UpdateService(
            UpdateServiceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateServiceRequest(ref request, ref callSettings);
            return _callUpdateService.Sync(request, callSettings);
        }

        /// <summary>
        /// Soft delete this `Service`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public override stt::Task DeleteServiceAsync(
            DeleteServiceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServiceRequest(ref request, ref callSettings);
            return _callDeleteService.Async(request, callSettings);
        }

        /// <summary>
        /// Soft delete this `Service`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteService(
            DeleteServiceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServiceRequest(ref request, ref callSettings);
            _callDeleteService.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a `ServiceLevelObjective` for the given `Service`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<ServiceLevelObjective> CreateServiceLevelObjectiveAsync(
            CreateServiceLevelObjectiveRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServiceLevelObjectiveRequest(ref request, ref callSettings);
            return _callCreateServiceLevelObjective.Async(request, callSettings);
        }

        /// <summary>
        /// Create a `ServiceLevelObjective` for the given `Service`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override ServiceLevelObjective CreateServiceLevelObjective(
            CreateServiceLevelObjectiveRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateServiceLevelObjectiveRequest(ref request, ref callSettings);
            return _callCreateServiceLevelObjective.Sync(request, callSettings);
        }

        /// <summary>
        /// Get a `ServiceLevelObjective` by name.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<ServiceLevelObjective> GetServiceLevelObjectiveAsync(
            GetServiceLevelObjectiveRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceLevelObjectiveRequest(ref request, ref callSettings);
            return _callGetServiceLevelObjective.Async(request, callSettings);
        }

        /// <summary>
        /// Get a `ServiceLevelObjective` by name.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override ServiceLevelObjective GetServiceLevelObjective(
            GetServiceLevelObjectiveRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceLevelObjectiveRequest(ref request, ref callSettings);
            return _callGetServiceLevelObjective.Sync(request, callSettings);
        }

        /// <summary>
        /// List the `ServiceLevelObjective`s for the given `Service`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ServiceLevelObjective"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListServiceLevelObjectivesResponse, ServiceLevelObjective> ListServiceLevelObjectivesAsync(
            ListServiceLevelObjectivesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServiceLevelObjectivesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListServiceLevelObjectivesRequest, ListServiceLevelObjectivesResponse, ServiceLevelObjective>(_callListServiceLevelObjectives, request, callSettings);
        }

        /// <summary>
        /// List the `ServiceLevelObjective`s for the given `Service`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="ServiceLevelObjective"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListServiceLevelObjectivesResponse, ServiceLevelObjective> ListServiceLevelObjectives(
            ListServiceLevelObjectivesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServiceLevelObjectivesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListServiceLevelObjectivesRequest, ListServiceLevelObjectivesResponse, ServiceLevelObjective>(_callListServiceLevelObjectives, request, callSettings);
        }

        /// <summary>
        /// Update the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<ServiceLevelObjective> UpdateServiceLevelObjectiveAsync(
            UpdateServiceLevelObjectiveRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateServiceLevelObjectiveRequest(ref request, ref callSettings);
            return _callUpdateServiceLevelObjective.Async(request, callSettings);
        }

        /// <summary>
        /// Update the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override ServiceLevelObjective UpdateServiceLevelObjective(
            UpdateServiceLevelObjectiveRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateServiceLevelObjectiveRequest(ref request, ref callSettings);
            return _callUpdateServiceLevelObjective.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public override stt::Task DeleteServiceLevelObjectiveAsync(
            DeleteServiceLevelObjectiveRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServiceLevelObjectiveRequest(ref request, ref callSettings);
            return _callDeleteServiceLevelObjective.Async(request, callSettings);
        }

        /// <summary>
        /// Delete the given `ServiceLevelObjective`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteServiceLevelObjective(
            DeleteServiceLevelObjectiveRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteServiceLevelObjectiveRequest(ref request, ref callSettings);
            _callDeleteServiceLevelObjective.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListServicesRequest : gaxgrpc::IPageRequest { }
    public partial class ListServicesResponse : gaxgrpc::IPageResponse<Service>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<Service> GetEnumerator() => Services.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListServiceLevelObjectivesRequest : gaxgrpc::IPageRequest { }
    public partial class ListServiceLevelObjectivesResponse : gaxgrpc::IPageResponse<ServiceLevelObjective>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<ServiceLevelObjective> GetEnumerator() => ServiceLevelObjectives.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
