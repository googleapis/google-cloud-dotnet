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
using lro = Google.LongRunning;
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
    /// <summary>Settings for <see cref="RuleServiceClient"/> instances.</summary>
    public sealed partial class RuleServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="RuleServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="RuleServiceSettings"/>.</returns>
        public static RuleServiceSettings GetDefault() => new RuleServiceSettings();

        /// <summary>Constructs a new <see cref="RuleServiceSettings"/> object with default settings.</summary>
        public RuleServiceSettings()
        {
        }

        private RuleServiceSettings(RuleServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateRuleSettings = existing.CreateRuleSettings;
            GetRuleSettings = existing.GetRuleSettings;
            ListRulesSettings = existing.ListRulesSettings;
            UpdateRuleSettings = existing.UpdateRuleSettings;
            DeleteRuleSettings = existing.DeleteRuleSettings;
            ListRuleRevisionsSettings = existing.ListRuleRevisionsSettings;
            CreateRetrohuntSettings = existing.CreateRetrohuntSettings;
            CreateRetrohuntOperationsSettings = existing.CreateRetrohuntOperationsSettings.Clone();
            GetRetrohuntSettings = existing.GetRetrohuntSettings;
            ListRetrohuntsSettings = existing.ListRetrohuntsSettings;
            GetRuleDeploymentSettings = existing.GetRuleDeploymentSettings;
            ListRuleDeploymentsSettings = existing.ListRuleDeploymentsSettings;
            UpdateRuleDeploymentSettings = existing.UpdateRuleDeploymentSettings;
            OnCopy(existing);
        }

        partial void OnCopy(RuleServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RuleServiceClient.CreateRule</c> and <c>RuleServiceClient.CreateRuleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateRuleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RuleServiceClient.GetRule</c>
        ///  and <c>RuleServiceClient.GetRuleAsync</c>.
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
        public gaxgrpc::CallSettings GetRuleSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RuleServiceClient.ListRules</c>
        ///  and <c>RuleServiceClient.ListRulesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 600000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListRulesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(600000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RuleServiceClient.UpdateRule</c> and <c>RuleServiceClient.UpdateRuleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateRuleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RuleServiceClient.DeleteRule</c> and <c>RuleServiceClient.DeleteRuleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteRuleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RuleServiceClient.ListRuleRevisions</c> and <c>RuleServiceClient.ListRuleRevisionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 600000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListRuleRevisionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(600000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RuleServiceClient.CreateRetrohunt</c> and <c>RuleServiceClient.CreateRetrohuntAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateRetrohuntSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RuleServiceClient.CreateRetrohunt</c> and
        /// <c>RuleServiceClient.CreateRetrohuntAsync</c>.
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
        public lro::OperationsSettings CreateRetrohuntOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RuleServiceClient.GetRetrohunt</c> and <c>RuleServiceClient.GetRetrohuntAsync</c>.
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
        public gaxgrpc::CallSettings GetRetrohuntSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RuleServiceClient.ListRetrohunts</c> and <c>RuleServiceClient.ListRetrohuntsAsync</c>.
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
        public gaxgrpc::CallSettings ListRetrohuntsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RuleServiceClient.GetRuleDeployment</c> and <c>RuleServiceClient.GetRuleDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 600000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetRuleDeploymentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(600000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RuleServiceClient.ListRuleDeployments</c> and <c>RuleServiceClient.ListRuleDeploymentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 600000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListRuleDeploymentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(600000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RuleServiceClient.UpdateRuleDeployment</c> and <c>RuleServiceClient.UpdateRuleDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateRuleDeploymentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="RuleServiceSettings"/> object.</returns>
        public RuleServiceSettings Clone() => new RuleServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RuleServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class RuleServiceClientBuilder : gaxgrpc::ClientBuilderBase<RuleServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RuleServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public RuleServiceClientBuilder() : base(RuleServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref RuleServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RuleServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override RuleServiceClient Build()
        {
            RuleServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RuleServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RuleServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RuleServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RuleServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<RuleServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RuleServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => RuleServiceClient.ChannelPool;
    }

    /// <summary>RuleService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// RuleService provides interface for user-created rules.
    /// </remarks>
    public abstract partial class RuleServiceClient
    {
        /// <summary>
        /// The default endpoint for the RuleService service, which is a host of "chronicle.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "chronicle.googleapis.com:443";

        /// <summary>The default RuleService scopes.</summary>
        /// <remarks>
        /// The default RuleService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(RuleService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="RuleServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="RuleServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="RuleServiceClient"/>.</returns>
        public static stt::Task<RuleServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RuleServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RuleServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="RuleServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="RuleServiceClient"/>.</returns>
        public static RuleServiceClient Create() => new RuleServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RuleServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RuleServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="RuleServiceClient"/>.</returns>
        internal static RuleServiceClient Create(grpccore::CallInvoker callInvoker, RuleServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            RuleService.RuleServiceClient grpcClient = new RuleService.RuleServiceClient(callInvoker);
            return new RuleServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC RuleService client</summary>
        public virtual RuleService.RuleServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Rule CreateRule(CreateRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rule> CreateRuleAsync(CreateRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rule> CreateRuleAsync(CreateRuleRequest request, st::CancellationToken cancellationToken) =>
            CreateRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Rule.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this rule will be created.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="rule">
        /// Required. The rule to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Rule CreateRule(string parent, Rule rule, gaxgrpc::CallSettings callSettings = null) =>
            CreateRule(new CreateRuleRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Rule = gax::GaxPreconditions.CheckNotNull(rule, nameof(rule)),
            }, callSettings);

        /// <summary>
        /// Creates a new Rule.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this rule will be created.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="rule">
        /// Required. The rule to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rule> CreateRuleAsync(string parent, Rule rule, gaxgrpc::CallSettings callSettings = null) =>
            CreateRuleAsync(new CreateRuleRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Rule = gax::GaxPreconditions.CheckNotNull(rule, nameof(rule)),
            }, callSettings);

        /// <summary>
        /// Creates a new Rule.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this rule will be created.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="rule">
        /// Required. The rule to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rule> CreateRuleAsync(string parent, Rule rule, st::CancellationToken cancellationToken) =>
            CreateRuleAsync(parent, rule, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Rule.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this rule will be created.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="rule">
        /// Required. The rule to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Rule CreateRule(InstanceName parent, Rule rule, gaxgrpc::CallSettings callSettings = null) =>
            CreateRule(new CreateRuleRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Rule = gax::GaxPreconditions.CheckNotNull(rule, nameof(rule)),
            }, callSettings);

        /// <summary>
        /// Creates a new Rule.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this rule will be created.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="rule">
        /// Required. The rule to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rule> CreateRuleAsync(InstanceName parent, Rule rule, gaxgrpc::CallSettings callSettings = null) =>
            CreateRuleAsync(new CreateRuleRequest
            {
                ParentAsInstanceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Rule = gax::GaxPreconditions.CheckNotNull(rule, nameof(rule)),
            }, callSettings);

        /// <summary>
        /// Creates a new Rule.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this rule will be created.
        /// Format: `projects/{project}/locations/{location}/instances/{instance}`
        /// </param>
        /// <param name="rule">
        /// Required. The rule to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rule> CreateRuleAsync(InstanceName parent, Rule rule, st::CancellationToken cancellationToken) =>
            CreateRuleAsync(parent, rule, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Rule GetRule(GetRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rule> GetRuleAsync(GetRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rule> GetRuleAsync(GetRuleRequest request, st::CancellationToken cancellationToken) =>
            GetRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Rule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the rule to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Rule GetRule(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRule(new GetRuleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Rule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the rule to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rule> GetRuleAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRuleAsync(new GetRuleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Rule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the rule to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rule> GetRuleAsync(string name, st::CancellationToken cancellationToken) =>
            GetRuleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Rule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the rule to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Rule GetRule(RuleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRule(new GetRuleRequest
            {
                RuleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Rule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the rule to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rule> GetRuleAsync(RuleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRuleAsync(new GetRuleRequest
            {
                RuleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Rule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the rule to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rule> GetRuleAsync(RuleName name, st::CancellationToken cancellationToken) =>
            GetRuleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Rule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRulesResponse, Rule> ListRules(ListRulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Rule"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRulesResponse, Rule> ListRulesAsync(ListRulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Rules.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of rules.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}`
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
        /// <returns>A pageable sequence of <see cref="Rule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRulesResponse, Rule> ListRules(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRulesRequest request = new ListRulesRequest
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
            return ListRules(request, callSettings);
        }

        /// <summary>
        /// Lists Rules.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of rules.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Rule"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRulesResponse, Rule> ListRulesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRulesRequest request = new ListRulesRequest
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
            return ListRulesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Rules.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of rules.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}`
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
        /// <returns>A pageable sequence of <see cref="Rule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRulesResponse, Rule> ListRules(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRulesRequest request = new ListRulesRequest
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
            return ListRules(request, callSettings);
        }

        /// <summary>
        /// Lists Rules.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of rules.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Rule"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRulesResponse, Rule> ListRulesAsync(InstanceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRulesRequest request = new ListRulesRequest
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
            return ListRulesAsync(request, callSettings);
        }

        /// <summary>
        /// Updates a Rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Rule UpdateRule(UpdateRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a Rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rule> UpdateRuleAsync(UpdateRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a Rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rule> UpdateRuleAsync(UpdateRuleRequest request, st::CancellationToken cancellationToken) =>
            UpdateRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a Rule.
        /// </summary>
        /// <param name="rule">
        /// Required. The rule to update.
        /// 
        /// The rule's `name` field is used to identify the rule to update.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update. If not included, all fields with a non-empty
        /// value will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Rule UpdateRule(Rule rule, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRule(new UpdateRuleRequest
            {
                Rule = gax::GaxPreconditions.CheckNotNull(rule, nameof(rule)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a Rule.
        /// </summary>
        /// <param name="rule">
        /// Required. The rule to update.
        /// 
        /// The rule's `name` field is used to identify the rule to update.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update. If not included, all fields with a non-empty
        /// value will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rule> UpdateRuleAsync(Rule rule, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRuleAsync(new UpdateRuleRequest
            {
                Rule = gax::GaxPreconditions.CheckNotNull(rule, nameof(rule)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a Rule.
        /// </summary>
        /// <param name="rule">
        /// Required. The rule to update.
        /// 
        /// The rule's `name` field is used to identify the rule to update.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update. If not included, all fields with a non-empty
        /// value will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rule> UpdateRuleAsync(Rule rule, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateRuleAsync(rule, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteRule(DeleteRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRuleAsync(DeleteRuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRuleAsync(DeleteRuleRequest request, st::CancellationToken cancellationToken) =>
            DeleteRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Rule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the rule to delete. A rule revision timestamp cannot
        /// be specified as part of the name, as deleting specific revisions is not
        /// supported.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteRule(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRule(new DeleteRuleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Rule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the rule to delete. A rule revision timestamp cannot
        /// be specified as part of the name, as deleting specific revisions is not
        /// supported.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRuleAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRuleAsync(new DeleteRuleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Rule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the rule to delete. A rule revision timestamp cannot
        /// be specified as part of the name, as deleting specific revisions is not
        /// supported.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRuleAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteRuleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Rule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the rule to delete. A rule revision timestamp cannot
        /// be specified as part of the name, as deleting specific revisions is not
        /// supported.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteRule(RuleName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRule(new DeleteRuleRequest
            {
                RuleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Rule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the rule to delete. A rule revision timestamp cannot
        /// be specified as part of the name, as deleting specific revisions is not
        /// supported.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRuleAsync(RuleName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRuleAsync(new DeleteRuleRequest
            {
                RuleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Rule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the rule to delete. A rule revision timestamp cannot
        /// be specified as part of the name, as deleting specific revisions is not
        /// supported.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteRuleAsync(RuleName name, st::CancellationToken cancellationToken) =>
            DeleteRuleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all revisions of the rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Rule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRuleRevisionsResponse, Rule> ListRuleRevisions(ListRuleRevisionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all revisions of the rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Rule"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRuleRevisionsResponse, Rule> ListRuleRevisionsAsync(ListRuleRevisionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all revisions of the rule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the rule to list revisions for.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}`
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
        /// <returns>A pageable sequence of <see cref="Rule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRuleRevisionsResponse, Rule> ListRuleRevisions(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRuleRevisionsRequest request = new ListRuleRevisionsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRuleRevisions(request, callSettings);
        }

        /// <summary>
        /// Lists all revisions of the rule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the rule to list revisions for.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Rule"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRuleRevisionsResponse, Rule> ListRuleRevisionsAsync(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRuleRevisionsRequest request = new ListRuleRevisionsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRuleRevisionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all revisions of the rule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the rule to list revisions for.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}`
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
        /// <returns>A pageable sequence of <see cref="Rule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRuleRevisionsResponse, Rule> ListRuleRevisions(RuleName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRuleRevisionsRequest request = new ListRuleRevisionsRequest
            {
                RuleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRuleRevisions(request, callSettings);
        }

        /// <summary>
        /// Lists all revisions of the rule.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the rule to list revisions for.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Rule"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRuleRevisionsResponse, Rule> ListRuleRevisionsAsync(RuleName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRuleRevisionsRequest request = new ListRuleRevisionsRequest
            {
                RuleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRuleRevisionsAsync(request, callSettings);
        }

        /// <summary>
        /// Create a Retrohunt.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Retrohunt, RetrohuntMetadata> CreateRetrohunt(CreateRetrohuntRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a Retrohunt.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Retrohunt, RetrohuntMetadata>> CreateRetrohuntAsync(CreateRetrohuntRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a Retrohunt.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Retrohunt, RetrohuntMetadata>> CreateRetrohuntAsync(CreateRetrohuntRequest request, st::CancellationToken cancellationToken) =>
            CreateRetrohuntAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateRetrohunt</c>.</summary>
        public virtual lro::OperationsClient CreateRetrohuntOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateRetrohunt</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Retrohunt, RetrohuntMetadata> PollOnceCreateRetrohunt(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Retrohunt, RetrohuntMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateRetrohuntOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateRetrohunt</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Retrohunt, RetrohuntMetadata>> PollOnceCreateRetrohuntAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Retrohunt, RetrohuntMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateRetrohuntOperationsClient, callSettings);

        /// <summary>
        /// Create a Retrohunt.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of retrohunt, which is a rule.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}`
        /// </param>
        /// <param name="retrohunt">
        /// Required. The retrohunt to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Retrohunt, RetrohuntMetadata> CreateRetrohunt(string parent, Retrohunt retrohunt, gaxgrpc::CallSettings callSettings = null) =>
            CreateRetrohunt(new CreateRetrohuntRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Retrohunt = gax::GaxPreconditions.CheckNotNull(retrohunt, nameof(retrohunt)),
            }, callSettings);

        /// <summary>
        /// Create a Retrohunt.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of retrohunt, which is a rule.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}`
        /// </param>
        /// <param name="retrohunt">
        /// Required. The retrohunt to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Retrohunt, RetrohuntMetadata>> CreateRetrohuntAsync(string parent, Retrohunt retrohunt, gaxgrpc::CallSettings callSettings = null) =>
            CreateRetrohuntAsync(new CreateRetrohuntRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Retrohunt = gax::GaxPreconditions.CheckNotNull(retrohunt, nameof(retrohunt)),
            }, callSettings);

        /// <summary>
        /// Create a Retrohunt.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of retrohunt, which is a rule.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}`
        /// </param>
        /// <param name="retrohunt">
        /// Required. The retrohunt to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Retrohunt, RetrohuntMetadata>> CreateRetrohuntAsync(string parent, Retrohunt retrohunt, st::CancellationToken cancellationToken) =>
            CreateRetrohuntAsync(parent, retrohunt, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a Retrohunt.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of retrohunt, which is a rule.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}`
        /// </param>
        /// <param name="retrohunt">
        /// Required. The retrohunt to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Retrohunt, RetrohuntMetadata> CreateRetrohunt(RuleName parent, Retrohunt retrohunt, gaxgrpc::CallSettings callSettings = null) =>
            CreateRetrohunt(new CreateRetrohuntRequest
            {
                ParentAsRuleName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Retrohunt = gax::GaxPreconditions.CheckNotNull(retrohunt, nameof(retrohunt)),
            }, callSettings);

        /// <summary>
        /// Create a Retrohunt.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of retrohunt, which is a rule.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}`
        /// </param>
        /// <param name="retrohunt">
        /// Required. The retrohunt to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Retrohunt, RetrohuntMetadata>> CreateRetrohuntAsync(RuleName parent, Retrohunt retrohunt, gaxgrpc::CallSettings callSettings = null) =>
            CreateRetrohuntAsync(new CreateRetrohuntRequest
            {
                ParentAsRuleName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Retrohunt = gax::GaxPreconditions.CheckNotNull(retrohunt, nameof(retrohunt)),
            }, callSettings);

        /// <summary>
        /// Create a Retrohunt.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of retrohunt, which is a rule.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}`
        /// </param>
        /// <param name="retrohunt">
        /// Required. The retrohunt to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Retrohunt, RetrohuntMetadata>> CreateRetrohuntAsync(RuleName parent, Retrohunt retrohunt, st::CancellationToken cancellationToken) =>
            CreateRetrohuntAsync(parent, retrohunt, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a Retrohunt.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Retrohunt GetRetrohunt(GetRetrohuntRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a Retrohunt.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Retrohunt> GetRetrohuntAsync(GetRetrohuntRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a Retrohunt.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Retrohunt> GetRetrohuntAsync(GetRetrohuntRequest request, st::CancellationToken cancellationToken) =>
            GetRetrohuntAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a Retrohunt.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the retrohunt to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/retrohunts/{retrohunt}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Retrohunt GetRetrohunt(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRetrohunt(new GetRetrohuntRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a Retrohunt.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the retrohunt to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/retrohunts/{retrohunt}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Retrohunt> GetRetrohuntAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRetrohuntAsync(new GetRetrohuntRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a Retrohunt.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the retrohunt to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/retrohunts/{retrohunt}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Retrohunt> GetRetrohuntAsync(string name, st::CancellationToken cancellationToken) =>
            GetRetrohuntAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a Retrohunt.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the retrohunt to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/retrohunts/{retrohunt}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Retrohunt GetRetrohunt(RetrohuntName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRetrohunt(new GetRetrohuntRequest
            {
                RetrohuntName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a Retrohunt.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the retrohunt to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/retrohunts/{retrohunt}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Retrohunt> GetRetrohuntAsync(RetrohuntName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRetrohuntAsync(new GetRetrohuntRequest
            {
                RetrohuntName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a Retrohunt.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the retrohunt to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/retrohunts/{retrohunt}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Retrohunt> GetRetrohuntAsync(RetrohuntName name, st::CancellationToken cancellationToken) =>
            GetRetrohuntAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List Retrohunts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Retrohunt"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRetrohuntsResponse, Retrohunt> ListRetrohunts(ListRetrohuntsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List Retrohunts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Retrohunt"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRetrohuntsResponse, Retrohunt> ListRetrohuntsAsync(ListRetrohuntsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List Retrohunts.
        /// </summary>
        /// <param name="parent">
        /// Required. The rule that the retrohunts belong to.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}`
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
        /// <returns>A pageable sequence of <see cref="Retrohunt"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRetrohuntsResponse, Retrohunt> ListRetrohunts(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRetrohuntsRequest request = new ListRetrohuntsRequest
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
            return ListRetrohunts(request, callSettings);
        }

        /// <summary>
        /// List Retrohunts.
        /// </summary>
        /// <param name="parent">
        /// Required. The rule that the retrohunts belong to.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Retrohunt"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRetrohuntsResponse, Retrohunt> ListRetrohuntsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRetrohuntsRequest request = new ListRetrohuntsRequest
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
            return ListRetrohuntsAsync(request, callSettings);
        }

        /// <summary>
        /// List Retrohunts.
        /// </summary>
        /// <param name="parent">
        /// Required. The rule that the retrohunts belong to.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}`
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
        /// <returns>A pageable sequence of <see cref="Retrohunt"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRetrohuntsResponse, Retrohunt> ListRetrohunts(RuleName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRetrohuntsRequest request = new ListRetrohuntsRequest
            {
                ParentAsRuleName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRetrohunts(request, callSettings);
        }

        /// <summary>
        /// List Retrohunts.
        /// </summary>
        /// <param name="parent">
        /// Required. The rule that the retrohunts belong to.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Retrohunt"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRetrohuntsResponse, Retrohunt> ListRetrohuntsAsync(RuleName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRetrohuntsRequest request = new ListRetrohuntsRequest
            {
                ParentAsRuleName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRetrohuntsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a RuleDeployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RuleDeployment GetRuleDeployment(GetRuleDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a RuleDeployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RuleDeployment> GetRuleDeploymentAsync(GetRuleDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a RuleDeployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RuleDeployment> GetRuleDeploymentAsync(GetRuleDeploymentRequest request, st::CancellationToken cancellationToken) =>
            GetRuleDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a RuleDeployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the rule deployment to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/deployment`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RuleDeployment GetRuleDeployment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRuleDeployment(new GetRuleDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a RuleDeployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the rule deployment to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/deployment`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RuleDeployment> GetRuleDeploymentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRuleDeploymentAsync(new GetRuleDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a RuleDeployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the rule deployment to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/deployment`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RuleDeployment> GetRuleDeploymentAsync(string name, st::CancellationToken cancellationToken) =>
            GetRuleDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a RuleDeployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the rule deployment to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/deployment`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RuleDeployment GetRuleDeployment(RuleDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRuleDeployment(new GetRuleDeploymentRequest
            {
                RuleDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a RuleDeployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the rule deployment to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/deployment`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RuleDeployment> GetRuleDeploymentAsync(RuleDeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRuleDeploymentAsync(new GetRuleDeploymentRequest
            {
                RuleDeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a RuleDeployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the rule deployment to retrieve.
        /// Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/deployment`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RuleDeployment> GetRuleDeploymentAsync(RuleDeploymentName name, st::CancellationToken cancellationToken) =>
            GetRuleDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists RuleDeployments across all Rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RuleDeployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRuleDeploymentsResponse, RuleDeployment> ListRuleDeployments(ListRuleDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists RuleDeployments across all Rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RuleDeployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRuleDeploymentsResponse, RuleDeployment> ListRuleDeploymentsAsync(ListRuleDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists RuleDeployments across all Rules.
        /// </summary>
        /// <param name="parent">
        /// Required. The collection of all parents which own all rule deployments. The
        /// "-" wildcard token must be used as the rule identifier in the resource
        /// path. Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/-`
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
        /// <returns>A pageable sequence of <see cref="RuleDeployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRuleDeploymentsResponse, RuleDeployment> ListRuleDeployments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRuleDeploymentsRequest request = new ListRuleDeploymentsRequest
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
            return ListRuleDeployments(request, callSettings);
        }

        /// <summary>
        /// Lists RuleDeployments across all Rules.
        /// </summary>
        /// <param name="parent">
        /// Required. The collection of all parents which own all rule deployments. The
        /// "-" wildcard token must be used as the rule identifier in the resource
        /// path. Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/-`
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
        /// <returns>A pageable asynchronous sequence of <see cref="RuleDeployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRuleDeploymentsResponse, RuleDeployment> ListRuleDeploymentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRuleDeploymentsRequest request = new ListRuleDeploymentsRequest
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
            return ListRuleDeploymentsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists RuleDeployments across all Rules.
        /// </summary>
        /// <param name="parent">
        /// Required. The collection of all parents which own all rule deployments. The
        /// "-" wildcard token must be used as the rule identifier in the resource
        /// path. Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/-`
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
        /// <returns>A pageable sequence of <see cref="RuleDeployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRuleDeploymentsResponse, RuleDeployment> ListRuleDeployments(RuleName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRuleDeploymentsRequest request = new ListRuleDeploymentsRequest
            {
                ParentAsRuleName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRuleDeployments(request, callSettings);
        }

        /// <summary>
        /// Lists RuleDeployments across all Rules.
        /// </summary>
        /// <param name="parent">
        /// Required. The collection of all parents which own all rule deployments. The
        /// "-" wildcard token must be used as the rule identifier in the resource
        /// path. Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/-`
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
        /// <returns>A pageable asynchronous sequence of <see cref="RuleDeployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRuleDeploymentsResponse, RuleDeployment> ListRuleDeploymentsAsync(RuleName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRuleDeploymentsRequest request = new ListRuleDeploymentsRequest
            {
                ParentAsRuleName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRuleDeploymentsAsync(request, callSettings);
        }

        /// <summary>
        /// Updates a RuleDeployment.
        /// Failures are not necessarily atomic. If there is a request to update
        /// multiple fields, and any update to a single field fails, an error will be
        /// returned, but other fields may remain successfully updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RuleDeployment UpdateRuleDeployment(UpdateRuleDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a RuleDeployment.
        /// Failures are not necessarily atomic. If there is a request to update
        /// multiple fields, and any update to a single field fails, an error will be
        /// returned, but other fields may remain successfully updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RuleDeployment> UpdateRuleDeploymentAsync(UpdateRuleDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a RuleDeployment.
        /// Failures are not necessarily atomic. If there is a request to update
        /// multiple fields, and any update to a single field fails, an error will be
        /// returned, but other fields may remain successfully updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RuleDeployment> UpdateRuleDeploymentAsync(UpdateRuleDeploymentRequest request, st::CancellationToken cancellationToken) =>
            UpdateRuleDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a RuleDeployment.
        /// Failures are not necessarily atomic. If there is a request to update
        /// multiple fields, and any update to a single field fails, an error will be
        /// returned, but other fields may remain successfully updated.
        /// </summary>
        /// <param name="ruleDeployment">
        /// Required. The rule deployment to update.
        /// 
        /// The rule deployment's `name` field is used to identify the rule deployment
        /// to update. Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/deployment`
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RuleDeployment UpdateRuleDeployment(RuleDeployment ruleDeployment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRuleDeployment(new UpdateRuleDeploymentRequest
            {
                RuleDeployment = gax::GaxPreconditions.CheckNotNull(ruleDeployment, nameof(ruleDeployment)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a RuleDeployment.
        /// Failures are not necessarily atomic. If there is a request to update
        /// multiple fields, and any update to a single field fails, an error will be
        /// returned, but other fields may remain successfully updated.
        /// </summary>
        /// <param name="ruleDeployment">
        /// Required. The rule deployment to update.
        /// 
        /// The rule deployment's `name` field is used to identify the rule deployment
        /// to update. Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/deployment`
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RuleDeployment> UpdateRuleDeploymentAsync(RuleDeployment ruleDeployment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRuleDeploymentAsync(new UpdateRuleDeploymentRequest
            {
                RuleDeployment = gax::GaxPreconditions.CheckNotNull(ruleDeployment, nameof(ruleDeployment)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a RuleDeployment.
        /// Failures are not necessarily atomic. If there is a request to update
        /// multiple fields, and any update to a single field fails, an error will be
        /// returned, but other fields may remain successfully updated.
        /// </summary>
        /// <param name="ruleDeployment">
        /// Required. The rule deployment to update.
        /// 
        /// The rule deployment's `name` field is used to identify the rule deployment
        /// to update. Format:
        /// `projects/{project}/locations/{location}/instances/{instance}/rules/{rule}/deployment`
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RuleDeployment> UpdateRuleDeploymentAsync(RuleDeployment ruleDeployment, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateRuleDeploymentAsync(ruleDeployment, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>RuleService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// RuleService provides interface for user-created rules.
    /// </remarks>
    public sealed partial class RuleServiceClientImpl : RuleServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateRuleRequest, Rule> _callCreateRule;

        private readonly gaxgrpc::ApiCall<GetRuleRequest, Rule> _callGetRule;

        private readonly gaxgrpc::ApiCall<ListRulesRequest, ListRulesResponse> _callListRules;

        private readonly gaxgrpc::ApiCall<UpdateRuleRequest, Rule> _callUpdateRule;

        private readonly gaxgrpc::ApiCall<DeleteRuleRequest, wkt::Empty> _callDeleteRule;

        private readonly gaxgrpc::ApiCall<ListRuleRevisionsRequest, ListRuleRevisionsResponse> _callListRuleRevisions;

        private readonly gaxgrpc::ApiCall<CreateRetrohuntRequest, lro::Operation> _callCreateRetrohunt;

        private readonly gaxgrpc::ApiCall<GetRetrohuntRequest, Retrohunt> _callGetRetrohunt;

        private readonly gaxgrpc::ApiCall<ListRetrohuntsRequest, ListRetrohuntsResponse> _callListRetrohunts;

        private readonly gaxgrpc::ApiCall<GetRuleDeploymentRequest, RuleDeployment> _callGetRuleDeployment;

        private readonly gaxgrpc::ApiCall<ListRuleDeploymentsRequest, ListRuleDeploymentsResponse> _callListRuleDeployments;

        private readonly gaxgrpc::ApiCall<UpdateRuleDeploymentRequest, RuleDeployment> _callUpdateRuleDeployment;

        /// <summary>
        /// Constructs a client wrapper for the RuleService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="RuleServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public RuleServiceClientImpl(RuleService.RuleServiceClient grpcClient, RuleServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            RuleServiceSettings effectiveSettings = settings ?? RuleServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateRetrohuntOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateRetrohuntOperationsSettings, logger);
            _callCreateRule = clientHelper.BuildApiCall<CreateRuleRequest, Rule>("CreateRule", grpcClient.CreateRuleAsync, grpcClient.CreateRule, effectiveSettings.CreateRuleSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateRule);
            Modify_CreateRuleApiCall(ref _callCreateRule);
            _callGetRule = clientHelper.BuildApiCall<GetRuleRequest, Rule>("GetRule", grpcClient.GetRuleAsync, grpcClient.GetRule, effectiveSettings.GetRuleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRule);
            Modify_GetRuleApiCall(ref _callGetRule);
            _callListRules = clientHelper.BuildApiCall<ListRulesRequest, ListRulesResponse>("ListRules", grpcClient.ListRulesAsync, grpcClient.ListRules, effectiveSettings.ListRulesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRules);
            Modify_ListRulesApiCall(ref _callListRules);
            _callUpdateRule = clientHelper.BuildApiCall<UpdateRuleRequest, Rule>("UpdateRule", grpcClient.UpdateRuleAsync, grpcClient.UpdateRule, effectiveSettings.UpdateRuleSettings).WithGoogleRequestParam("rule.name", request => request.Rule?.Name);
            Modify_ApiCall(ref _callUpdateRule);
            Modify_UpdateRuleApiCall(ref _callUpdateRule);
            _callDeleteRule = clientHelper.BuildApiCall<DeleteRuleRequest, wkt::Empty>("DeleteRule", grpcClient.DeleteRuleAsync, grpcClient.DeleteRule, effectiveSettings.DeleteRuleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteRule);
            Modify_DeleteRuleApiCall(ref _callDeleteRule);
            _callListRuleRevisions = clientHelper.BuildApiCall<ListRuleRevisionsRequest, ListRuleRevisionsResponse>("ListRuleRevisions", grpcClient.ListRuleRevisionsAsync, grpcClient.ListRuleRevisions, effectiveSettings.ListRuleRevisionsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callListRuleRevisions);
            Modify_ListRuleRevisionsApiCall(ref _callListRuleRevisions);
            _callCreateRetrohunt = clientHelper.BuildApiCall<CreateRetrohuntRequest, lro::Operation>("CreateRetrohunt", grpcClient.CreateRetrohuntAsync, grpcClient.CreateRetrohunt, effectiveSettings.CreateRetrohuntSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateRetrohunt);
            Modify_CreateRetrohuntApiCall(ref _callCreateRetrohunt);
            _callGetRetrohunt = clientHelper.BuildApiCall<GetRetrohuntRequest, Retrohunt>("GetRetrohunt", grpcClient.GetRetrohuntAsync, grpcClient.GetRetrohunt, effectiveSettings.GetRetrohuntSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRetrohunt);
            Modify_GetRetrohuntApiCall(ref _callGetRetrohunt);
            _callListRetrohunts = clientHelper.BuildApiCall<ListRetrohuntsRequest, ListRetrohuntsResponse>("ListRetrohunts", grpcClient.ListRetrohuntsAsync, grpcClient.ListRetrohunts, effectiveSettings.ListRetrohuntsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRetrohunts);
            Modify_ListRetrohuntsApiCall(ref _callListRetrohunts);
            _callGetRuleDeployment = clientHelper.BuildApiCall<GetRuleDeploymentRequest, RuleDeployment>("GetRuleDeployment", grpcClient.GetRuleDeploymentAsync, grpcClient.GetRuleDeployment, effectiveSettings.GetRuleDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRuleDeployment);
            Modify_GetRuleDeploymentApiCall(ref _callGetRuleDeployment);
            _callListRuleDeployments = clientHelper.BuildApiCall<ListRuleDeploymentsRequest, ListRuleDeploymentsResponse>("ListRuleDeployments", grpcClient.ListRuleDeploymentsAsync, grpcClient.ListRuleDeployments, effectiveSettings.ListRuleDeploymentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRuleDeployments);
            Modify_ListRuleDeploymentsApiCall(ref _callListRuleDeployments);
            _callUpdateRuleDeployment = clientHelper.BuildApiCall<UpdateRuleDeploymentRequest, RuleDeployment>("UpdateRuleDeployment", grpcClient.UpdateRuleDeploymentAsync, grpcClient.UpdateRuleDeployment, effectiveSettings.UpdateRuleDeploymentSettings).WithGoogleRequestParam("rule_deployment.name", request => request.RuleDeployment?.Name);
            Modify_ApiCall(ref _callUpdateRuleDeployment);
            Modify_UpdateRuleDeploymentApiCall(ref _callUpdateRuleDeployment);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateRuleApiCall(ref gaxgrpc::ApiCall<CreateRuleRequest, Rule> call);

        partial void Modify_GetRuleApiCall(ref gaxgrpc::ApiCall<GetRuleRequest, Rule> call);

        partial void Modify_ListRulesApiCall(ref gaxgrpc::ApiCall<ListRulesRequest, ListRulesResponse> call);

        partial void Modify_UpdateRuleApiCall(ref gaxgrpc::ApiCall<UpdateRuleRequest, Rule> call);

        partial void Modify_DeleteRuleApiCall(ref gaxgrpc::ApiCall<DeleteRuleRequest, wkt::Empty> call);

        partial void Modify_ListRuleRevisionsApiCall(ref gaxgrpc::ApiCall<ListRuleRevisionsRequest, ListRuleRevisionsResponse> call);

        partial void Modify_CreateRetrohuntApiCall(ref gaxgrpc::ApiCall<CreateRetrohuntRequest, lro::Operation> call);

        partial void Modify_GetRetrohuntApiCall(ref gaxgrpc::ApiCall<GetRetrohuntRequest, Retrohunt> call);

        partial void Modify_ListRetrohuntsApiCall(ref gaxgrpc::ApiCall<ListRetrohuntsRequest, ListRetrohuntsResponse> call);

        partial void Modify_GetRuleDeploymentApiCall(ref gaxgrpc::ApiCall<GetRuleDeploymentRequest, RuleDeployment> call);

        partial void Modify_ListRuleDeploymentsApiCall(ref gaxgrpc::ApiCall<ListRuleDeploymentsRequest, ListRuleDeploymentsResponse> call);

        partial void Modify_UpdateRuleDeploymentApiCall(ref gaxgrpc::ApiCall<UpdateRuleDeploymentRequest, RuleDeployment> call);

        partial void OnConstruction(RuleService.RuleServiceClient grpcClient, RuleServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC RuleService client</summary>
        public override RuleService.RuleServiceClient GrpcClient { get; }

        partial void Modify_CreateRuleRequest(ref CreateRuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRuleRequest(ref GetRuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRulesRequest(ref ListRulesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateRuleRequest(ref UpdateRuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteRuleRequest(ref DeleteRuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRuleRevisionsRequest(ref ListRuleRevisionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateRetrohuntRequest(ref CreateRetrohuntRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRetrohuntRequest(ref GetRetrohuntRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRetrohuntsRequest(ref ListRetrohuntsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRuleDeploymentRequest(ref GetRuleDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRuleDeploymentsRequest(ref ListRuleDeploymentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateRuleDeploymentRequest(ref UpdateRuleDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a new Rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Rule CreateRule(CreateRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRuleRequest(ref request, ref callSettings);
            return _callCreateRule.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new Rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Rule> CreateRuleAsync(CreateRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRuleRequest(ref request, ref callSettings);
            return _callCreateRule.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a Rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Rule GetRule(GetRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRuleRequest(ref request, ref callSettings);
            return _callGetRule.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a Rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Rule> GetRuleAsync(GetRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRuleRequest(ref request, ref callSettings);
            return _callGetRule.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Rule"/> resources.</returns>
        public override gax::PagedEnumerable<ListRulesResponse, Rule> ListRules(ListRulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRulesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRulesRequest, ListRulesResponse, Rule>(_callListRules, request, callSettings);
        }

        /// <summary>
        /// Lists Rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Rule"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRulesResponse, Rule> ListRulesAsync(ListRulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRulesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRulesRequest, ListRulesResponse, Rule>(_callListRules, request, callSettings);
        }

        /// <summary>
        /// Updates a Rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Rule UpdateRule(UpdateRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRuleRequest(ref request, ref callSettings);
            return _callUpdateRule.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a Rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Rule> UpdateRuleAsync(UpdateRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRuleRequest(ref request, ref callSettings);
            return _callUpdateRule.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a Rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteRule(DeleteRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRuleRequest(ref request, ref callSettings);
            _callDeleteRule.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a Rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteRuleAsync(DeleteRuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRuleRequest(ref request, ref callSettings);
            return _callDeleteRule.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all revisions of the rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Rule"/> resources.</returns>
        public override gax::PagedEnumerable<ListRuleRevisionsResponse, Rule> ListRuleRevisions(ListRuleRevisionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRuleRevisionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRuleRevisionsRequest, ListRuleRevisionsResponse, Rule>(_callListRuleRevisions, request, callSettings);
        }

        /// <summary>
        /// Lists all revisions of the rule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Rule"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRuleRevisionsResponse, Rule> ListRuleRevisionsAsync(ListRuleRevisionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRuleRevisionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRuleRevisionsRequest, ListRuleRevisionsResponse, Rule>(_callListRuleRevisions, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateRetrohunt</c>.</summary>
        public override lro::OperationsClient CreateRetrohuntOperationsClient { get; }

        /// <summary>
        /// Create a Retrohunt.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Retrohunt, RetrohuntMetadata> CreateRetrohunt(CreateRetrohuntRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRetrohuntRequest(ref request, ref callSettings);
            return new lro::Operation<Retrohunt, RetrohuntMetadata>(_callCreateRetrohunt.Sync(request, callSettings), CreateRetrohuntOperationsClient);
        }

        /// <summary>
        /// Create a Retrohunt.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Retrohunt, RetrohuntMetadata>> CreateRetrohuntAsync(CreateRetrohuntRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRetrohuntRequest(ref request, ref callSettings);
            return new lro::Operation<Retrohunt, RetrohuntMetadata>(await _callCreateRetrohunt.Async(request, callSettings).ConfigureAwait(false), CreateRetrohuntOperationsClient);
        }

        /// <summary>
        /// Get a Retrohunt.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Retrohunt GetRetrohunt(GetRetrohuntRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRetrohuntRequest(ref request, ref callSettings);
            return _callGetRetrohunt.Sync(request, callSettings);
        }

        /// <summary>
        /// Get a Retrohunt.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Retrohunt> GetRetrohuntAsync(GetRetrohuntRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRetrohuntRequest(ref request, ref callSettings);
            return _callGetRetrohunt.Async(request, callSettings);
        }

        /// <summary>
        /// List Retrohunts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Retrohunt"/> resources.</returns>
        public override gax::PagedEnumerable<ListRetrohuntsResponse, Retrohunt> ListRetrohunts(ListRetrohuntsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRetrohuntsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRetrohuntsRequest, ListRetrohuntsResponse, Retrohunt>(_callListRetrohunts, request, callSettings);
        }

        /// <summary>
        /// List Retrohunts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Retrohunt"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRetrohuntsResponse, Retrohunt> ListRetrohuntsAsync(ListRetrohuntsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRetrohuntsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRetrohuntsRequest, ListRetrohuntsResponse, Retrohunt>(_callListRetrohunts, request, callSettings);
        }

        /// <summary>
        /// Gets a RuleDeployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RuleDeployment GetRuleDeployment(GetRuleDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRuleDeploymentRequest(ref request, ref callSettings);
            return _callGetRuleDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a RuleDeployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RuleDeployment> GetRuleDeploymentAsync(GetRuleDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRuleDeploymentRequest(ref request, ref callSettings);
            return _callGetRuleDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// Lists RuleDeployments across all Rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="RuleDeployment"/> resources.</returns>
        public override gax::PagedEnumerable<ListRuleDeploymentsResponse, RuleDeployment> ListRuleDeployments(ListRuleDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRuleDeploymentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRuleDeploymentsRequest, ListRuleDeploymentsResponse, RuleDeployment>(_callListRuleDeployments, request, callSettings);
        }

        /// <summary>
        /// Lists RuleDeployments across all Rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="RuleDeployment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRuleDeploymentsResponse, RuleDeployment> ListRuleDeploymentsAsync(ListRuleDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRuleDeploymentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRuleDeploymentsRequest, ListRuleDeploymentsResponse, RuleDeployment>(_callListRuleDeployments, request, callSettings);
        }

        /// <summary>
        /// Updates a RuleDeployment.
        /// Failures are not necessarily atomic. If there is a request to update
        /// multiple fields, and any update to a single field fails, an error will be
        /// returned, but other fields may remain successfully updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RuleDeployment UpdateRuleDeployment(UpdateRuleDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRuleDeploymentRequest(ref request, ref callSettings);
            return _callUpdateRuleDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a RuleDeployment.
        /// Failures are not necessarily atomic. If there is a request to update
        /// multiple fields, and any update to a single field fails, an error will be
        /// returned, but other fields may remain successfully updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RuleDeployment> UpdateRuleDeploymentAsync(UpdateRuleDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRuleDeploymentRequest(ref request, ref callSettings);
            return _callUpdateRuleDeployment.Async(request, callSettings);
        }
    }

    public partial class ListRulesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRuleRevisionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRetrohuntsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRuleDeploymentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRulesResponse : gaxgrpc::IPageResponse<Rule>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Rule> GetEnumerator() => Rules.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListRuleRevisionsResponse : gaxgrpc::IPageResponse<Rule>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Rule> GetEnumerator() => Rules.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListRetrohuntsResponse : gaxgrpc::IPageResponse<Retrohunt>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Retrohunt> GetEnumerator() => Retrohunts.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListRuleDeploymentsResponse : gaxgrpc::IPageResponse<RuleDeployment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<RuleDeployment> GetEnumerator() => RuleDeployments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class RuleService
    {
        public partial class RuleServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() =>
                new lro::Operations.OperationsClient(CallInvoker);
        }
    }
}
