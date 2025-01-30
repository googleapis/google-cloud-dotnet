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

namespace Google.Cloud.Dataproc.V1
{
    /// <summary>Settings for <see cref="AutoscalingPolicyServiceClient"/> instances.</summary>
    public sealed partial class AutoscalingPolicyServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AutoscalingPolicyServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AutoscalingPolicyServiceSettings"/>.</returns>
        public static AutoscalingPolicyServiceSettings GetDefault() => new AutoscalingPolicyServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AutoscalingPolicyServiceSettings"/> object with default settings.
        /// </summary>
        public AutoscalingPolicyServiceSettings()
        {
        }

        private AutoscalingPolicyServiceSettings(AutoscalingPolicyServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateAutoscalingPolicySettings = existing.CreateAutoscalingPolicySettings;
            UpdateAutoscalingPolicySettings = existing.UpdateAutoscalingPolicySettings;
            GetAutoscalingPolicySettings = existing.GetAutoscalingPolicySettings;
            ListAutoscalingPoliciesSettings = existing.ListAutoscalingPoliciesSettings;
            DeleteAutoscalingPolicySettings = existing.DeleteAutoscalingPolicySettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(AutoscalingPolicyServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AutoscalingPolicyServiceClient.CreateAutoscalingPolicy</c> and
        /// <c>AutoscalingPolicyServiceClient.CreateAutoscalingPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAutoscalingPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AutoscalingPolicyServiceClient.UpdateAutoscalingPolicy</c> and
        /// <c>AutoscalingPolicyServiceClient.UpdateAutoscalingPolicyAsync</c>.
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
        public gaxgrpc::CallSettings UpdateAutoscalingPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AutoscalingPolicyServiceClient.GetAutoscalingPolicy</c> and
        /// <c>AutoscalingPolicyServiceClient.GetAutoscalingPolicyAsync</c>.
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
        public gaxgrpc::CallSettings GetAutoscalingPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AutoscalingPolicyServiceClient.ListAutoscalingPolicies</c> and
        /// <c>AutoscalingPolicyServiceClient.ListAutoscalingPoliciesAsync</c>.
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
        public gaxgrpc::CallSettings ListAutoscalingPoliciesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AutoscalingPolicyServiceClient.DeleteAutoscalingPolicy</c> and
        /// <c>AutoscalingPolicyServiceClient.DeleteAutoscalingPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAutoscalingPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AutoscalingPolicyServiceSettings"/> object.</returns>
        public AutoscalingPolicyServiceSettings Clone() => new AutoscalingPolicyServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AutoscalingPolicyServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class AutoscalingPolicyServiceClientBuilder : gaxgrpc::ClientBuilderBase<AutoscalingPolicyServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AutoscalingPolicyServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AutoscalingPolicyServiceClientBuilder() : base(AutoscalingPolicyServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AutoscalingPolicyServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AutoscalingPolicyServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AutoscalingPolicyServiceClient Build()
        {
            AutoscalingPolicyServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AutoscalingPolicyServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AutoscalingPolicyServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AutoscalingPolicyServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AutoscalingPolicyServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AutoscalingPolicyServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AutoscalingPolicyServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AutoscalingPolicyServiceClient.ChannelPool;
    }

    /// <summary>AutoscalingPolicyService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The API interface for managing autoscaling policies in the
    /// Dataproc API.
    /// </remarks>
    public abstract partial class AutoscalingPolicyServiceClient
    {
        /// <summary>
        /// The default endpoint for the AutoscalingPolicyService service, which is a host of "dataproc.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dataproc.googleapis.com:443";

        /// <summary>The default AutoscalingPolicyService scopes.</summary>
        /// <remarks>
        /// The default AutoscalingPolicyService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AutoscalingPolicyService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AutoscalingPolicyServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AutoscalingPolicyServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AutoscalingPolicyServiceClient"/>.</returns>
        public static stt::Task<AutoscalingPolicyServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AutoscalingPolicyServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AutoscalingPolicyServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AutoscalingPolicyServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AutoscalingPolicyServiceClient"/>.</returns>
        public static AutoscalingPolicyServiceClient Create() => new AutoscalingPolicyServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AutoscalingPolicyServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AutoscalingPolicyServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AutoscalingPolicyServiceClient"/>.</returns>
        internal static AutoscalingPolicyServiceClient Create(grpccore::CallInvoker callInvoker, AutoscalingPolicyServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AutoscalingPolicyService.AutoscalingPolicyServiceClient grpcClient = new AutoscalingPolicyService.AutoscalingPolicyServiceClient(callInvoker);
            return new AutoscalingPolicyServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AutoscalingPolicyService client</summary>
        public virtual AutoscalingPolicyService.AutoscalingPolicyServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates new autoscaling policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AutoscalingPolicy CreateAutoscalingPolicy(CreateAutoscalingPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates new autoscaling policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutoscalingPolicy> CreateAutoscalingPolicyAsync(CreateAutoscalingPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates new autoscaling policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutoscalingPolicy> CreateAutoscalingPolicyAsync(CreateAutoscalingPolicyRequest request, st::CancellationToken cancellationToken) =>
            CreateAutoscalingPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates new autoscaling policy.
        /// </summary>
        /// <param name="parent">
        /// Required. The "resource name" of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.autoscalingPolicies.create`, the resource name
        /// of the region has the following format:
        /// `projects/{project_id}/regions/{region}`
        /// 
        /// * For `projects.locations.autoscalingPolicies.create`, the resource name
        /// of the location has the following format:
        /// `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="policy">
        /// Required. The autoscaling policy to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AutoscalingPolicy CreateAutoscalingPolicy(string parent, AutoscalingPolicy policy, gaxgrpc::CallSettings callSettings = null) =>
            CreateAutoscalingPolicy(new CreateAutoscalingPolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Creates new autoscaling policy.
        /// </summary>
        /// <param name="parent">
        /// Required. The "resource name" of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.autoscalingPolicies.create`, the resource name
        /// of the region has the following format:
        /// `projects/{project_id}/regions/{region}`
        /// 
        /// * For `projects.locations.autoscalingPolicies.create`, the resource name
        /// of the location has the following format:
        /// `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="policy">
        /// Required. The autoscaling policy to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutoscalingPolicy> CreateAutoscalingPolicyAsync(string parent, AutoscalingPolicy policy, gaxgrpc::CallSettings callSettings = null) =>
            CreateAutoscalingPolicyAsync(new CreateAutoscalingPolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Creates new autoscaling policy.
        /// </summary>
        /// <param name="parent">
        /// Required. The "resource name" of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.autoscalingPolicies.create`, the resource name
        /// of the region has the following format:
        /// `projects/{project_id}/regions/{region}`
        /// 
        /// * For `projects.locations.autoscalingPolicies.create`, the resource name
        /// of the location has the following format:
        /// `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="policy">
        /// Required. The autoscaling policy to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutoscalingPolicy> CreateAutoscalingPolicyAsync(string parent, AutoscalingPolicy policy, st::CancellationToken cancellationToken) =>
            CreateAutoscalingPolicyAsync(parent, policy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates new autoscaling policy.
        /// </summary>
        /// <param name="parent">
        /// Required. The "resource name" of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.autoscalingPolicies.create`, the resource name
        /// of the region has the following format:
        /// `projects/{project_id}/regions/{region}`
        /// 
        /// * For `projects.locations.autoscalingPolicies.create`, the resource name
        /// of the location has the following format:
        /// `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="policy">
        /// Required. The autoscaling policy to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AutoscalingPolicy CreateAutoscalingPolicy(gagr::LocationName parent, AutoscalingPolicy policy, gaxgrpc::CallSettings callSettings = null) =>
            CreateAutoscalingPolicy(new CreateAutoscalingPolicyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Creates new autoscaling policy.
        /// </summary>
        /// <param name="parent">
        /// Required. The "resource name" of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.autoscalingPolicies.create`, the resource name
        /// of the region has the following format:
        /// `projects/{project_id}/regions/{region}`
        /// 
        /// * For `projects.locations.autoscalingPolicies.create`, the resource name
        /// of the location has the following format:
        /// `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="policy">
        /// Required. The autoscaling policy to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutoscalingPolicy> CreateAutoscalingPolicyAsync(gagr::LocationName parent, AutoscalingPolicy policy, gaxgrpc::CallSettings callSettings = null) =>
            CreateAutoscalingPolicyAsync(new CreateAutoscalingPolicyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Creates new autoscaling policy.
        /// </summary>
        /// <param name="parent">
        /// Required. The "resource name" of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.autoscalingPolicies.create`, the resource name
        /// of the region has the following format:
        /// `projects/{project_id}/regions/{region}`
        /// 
        /// * For `projects.locations.autoscalingPolicies.create`, the resource name
        /// of the location has the following format:
        /// `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="policy">
        /// Required. The autoscaling policy to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutoscalingPolicy> CreateAutoscalingPolicyAsync(gagr::LocationName parent, AutoscalingPolicy policy, st::CancellationToken cancellationToken) =>
            CreateAutoscalingPolicyAsync(parent, policy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates new autoscaling policy.
        /// </summary>
        /// <param name="parent">
        /// Required. The "resource name" of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.autoscalingPolicies.create`, the resource name
        /// of the region has the following format:
        /// `projects/{project_id}/regions/{region}`
        /// 
        /// * For `projects.locations.autoscalingPolicies.create`, the resource name
        /// of the location has the following format:
        /// `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="policy">
        /// Required. The autoscaling policy to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AutoscalingPolicy CreateAutoscalingPolicy(RegionName parent, AutoscalingPolicy policy, gaxgrpc::CallSettings callSettings = null) =>
            CreateAutoscalingPolicy(new CreateAutoscalingPolicyRequest
            {
                ParentAsRegionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Creates new autoscaling policy.
        /// </summary>
        /// <param name="parent">
        /// Required. The "resource name" of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.autoscalingPolicies.create`, the resource name
        /// of the region has the following format:
        /// `projects/{project_id}/regions/{region}`
        /// 
        /// * For `projects.locations.autoscalingPolicies.create`, the resource name
        /// of the location has the following format:
        /// `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="policy">
        /// Required. The autoscaling policy to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutoscalingPolicy> CreateAutoscalingPolicyAsync(RegionName parent, AutoscalingPolicy policy, gaxgrpc::CallSettings callSettings = null) =>
            CreateAutoscalingPolicyAsync(new CreateAutoscalingPolicyRequest
            {
                ParentAsRegionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Creates new autoscaling policy.
        /// </summary>
        /// <param name="parent">
        /// Required. The "resource name" of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.autoscalingPolicies.create`, the resource name
        /// of the region has the following format:
        /// `projects/{project_id}/regions/{region}`
        /// 
        /// * For `projects.locations.autoscalingPolicies.create`, the resource name
        /// of the location has the following format:
        /// `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="policy">
        /// Required. The autoscaling policy to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutoscalingPolicy> CreateAutoscalingPolicyAsync(RegionName parent, AutoscalingPolicy policy, st::CancellationToken cancellationToken) =>
            CreateAutoscalingPolicyAsync(parent, policy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates (replaces) autoscaling policy.
        /// 
        /// Disabled check for update_mask, because all updates will be full
        /// replacements.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AutoscalingPolicy UpdateAutoscalingPolicy(UpdateAutoscalingPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates (replaces) autoscaling policy.
        /// 
        /// Disabled check for update_mask, because all updates will be full
        /// replacements.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutoscalingPolicy> UpdateAutoscalingPolicyAsync(UpdateAutoscalingPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates (replaces) autoscaling policy.
        /// 
        /// Disabled check for update_mask, because all updates will be full
        /// replacements.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutoscalingPolicy> UpdateAutoscalingPolicyAsync(UpdateAutoscalingPolicyRequest request, st::CancellationToken cancellationToken) =>
            UpdateAutoscalingPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates (replaces) autoscaling policy.
        /// 
        /// Disabled check for update_mask, because all updates will be full
        /// replacements.
        /// </summary>
        /// <param name="policy">
        /// Required. The updated autoscaling policy.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AutoscalingPolicy UpdateAutoscalingPolicy(AutoscalingPolicy policy, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAutoscalingPolicy(new UpdateAutoscalingPolicyRequest
            {
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Updates (replaces) autoscaling policy.
        /// 
        /// Disabled check for update_mask, because all updates will be full
        /// replacements.
        /// </summary>
        /// <param name="policy">
        /// Required. The updated autoscaling policy.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutoscalingPolicy> UpdateAutoscalingPolicyAsync(AutoscalingPolicy policy, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAutoscalingPolicyAsync(new UpdateAutoscalingPolicyRequest
            {
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Updates (replaces) autoscaling policy.
        /// 
        /// Disabled check for update_mask, because all updates will be full
        /// replacements.
        /// </summary>
        /// <param name="policy">
        /// Required. The updated autoscaling policy.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutoscalingPolicy> UpdateAutoscalingPolicyAsync(AutoscalingPolicy policy, st::CancellationToken cancellationToken) =>
            UpdateAutoscalingPolicyAsync(policy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves autoscaling policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AutoscalingPolicy GetAutoscalingPolicy(GetAutoscalingPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves autoscaling policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutoscalingPolicy> GetAutoscalingPolicyAsync(GetAutoscalingPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves autoscaling policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutoscalingPolicy> GetAutoscalingPolicyAsync(GetAutoscalingPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetAutoscalingPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves autoscaling policy.
        /// </summary>
        /// <param name="name">
        /// Required. The "resource name" of the autoscaling policy, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.autoscalingPolicies.get`, the resource name
        /// of the policy has the following format:
        /// `projects/{project_id}/regions/{region}/autoscalingPolicies/{policy_id}`
        /// 
        /// * For `projects.locations.autoscalingPolicies.get`, the resource name
        /// of the policy has the following format:
        /// `projects/{project_id}/locations/{location}/autoscalingPolicies/{policy_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AutoscalingPolicy GetAutoscalingPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAutoscalingPolicy(new GetAutoscalingPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves autoscaling policy.
        /// </summary>
        /// <param name="name">
        /// Required. The "resource name" of the autoscaling policy, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.autoscalingPolicies.get`, the resource name
        /// of the policy has the following format:
        /// `projects/{project_id}/regions/{region}/autoscalingPolicies/{policy_id}`
        /// 
        /// * For `projects.locations.autoscalingPolicies.get`, the resource name
        /// of the policy has the following format:
        /// `projects/{project_id}/locations/{location}/autoscalingPolicies/{policy_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutoscalingPolicy> GetAutoscalingPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAutoscalingPolicyAsync(new GetAutoscalingPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves autoscaling policy.
        /// </summary>
        /// <param name="name">
        /// Required. The "resource name" of the autoscaling policy, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.autoscalingPolicies.get`, the resource name
        /// of the policy has the following format:
        /// `projects/{project_id}/regions/{region}/autoscalingPolicies/{policy_id}`
        /// 
        /// * For `projects.locations.autoscalingPolicies.get`, the resource name
        /// of the policy has the following format:
        /// `projects/{project_id}/locations/{location}/autoscalingPolicies/{policy_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutoscalingPolicy> GetAutoscalingPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            GetAutoscalingPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves autoscaling policy.
        /// </summary>
        /// <param name="name">
        /// Required. The "resource name" of the autoscaling policy, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.autoscalingPolicies.get`, the resource name
        /// of the policy has the following format:
        /// `projects/{project_id}/regions/{region}/autoscalingPolicies/{policy_id}`
        /// 
        /// * For `projects.locations.autoscalingPolicies.get`, the resource name
        /// of the policy has the following format:
        /// `projects/{project_id}/locations/{location}/autoscalingPolicies/{policy_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AutoscalingPolicy GetAutoscalingPolicy(AutoscalingPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAutoscalingPolicy(new GetAutoscalingPolicyRequest
            {
                AutoscalingPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves autoscaling policy.
        /// </summary>
        /// <param name="name">
        /// Required. The "resource name" of the autoscaling policy, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.autoscalingPolicies.get`, the resource name
        /// of the policy has the following format:
        /// `projects/{project_id}/regions/{region}/autoscalingPolicies/{policy_id}`
        /// 
        /// * For `projects.locations.autoscalingPolicies.get`, the resource name
        /// of the policy has the following format:
        /// `projects/{project_id}/locations/{location}/autoscalingPolicies/{policy_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutoscalingPolicy> GetAutoscalingPolicyAsync(AutoscalingPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAutoscalingPolicyAsync(new GetAutoscalingPolicyRequest
            {
                AutoscalingPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves autoscaling policy.
        /// </summary>
        /// <param name="name">
        /// Required. The "resource name" of the autoscaling policy, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.autoscalingPolicies.get`, the resource name
        /// of the policy has the following format:
        /// `projects/{project_id}/regions/{region}/autoscalingPolicies/{policy_id}`
        /// 
        /// * For `projects.locations.autoscalingPolicies.get`, the resource name
        /// of the policy has the following format:
        /// `projects/{project_id}/locations/{location}/autoscalingPolicies/{policy_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutoscalingPolicy> GetAutoscalingPolicyAsync(AutoscalingPolicyName name, st::CancellationToken cancellationToken) =>
            GetAutoscalingPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists autoscaling policies in the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AutoscalingPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAutoscalingPoliciesResponse, AutoscalingPolicy> ListAutoscalingPolicies(ListAutoscalingPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists autoscaling policies in the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AutoscalingPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAutoscalingPoliciesResponse, AutoscalingPolicy> ListAutoscalingPoliciesAsync(ListAutoscalingPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists autoscaling policies in the project.
        /// </summary>
        /// <param name="parent">
        /// Required. The "resource name" of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.autoscalingPolicies.list`, the resource name
        /// of the region has the following format:
        /// `projects/{project_id}/regions/{region}`
        /// 
        /// * For `projects.locations.autoscalingPolicies.list`, the resource name
        /// of the location has the following format:
        /// `projects/{project_id}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="AutoscalingPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAutoscalingPoliciesResponse, AutoscalingPolicy> ListAutoscalingPolicies(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAutoscalingPoliciesRequest request = new ListAutoscalingPoliciesRequest
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
            return ListAutoscalingPolicies(request, callSettings);
        }

        /// <summary>
        /// Lists autoscaling policies in the project.
        /// </summary>
        /// <param name="parent">
        /// Required. The "resource name" of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.autoscalingPolicies.list`, the resource name
        /// of the region has the following format:
        /// `projects/{project_id}/regions/{region}`
        /// 
        /// * For `projects.locations.autoscalingPolicies.list`, the resource name
        /// of the location has the following format:
        /// `projects/{project_id}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="AutoscalingPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAutoscalingPoliciesResponse, AutoscalingPolicy> ListAutoscalingPoliciesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAutoscalingPoliciesRequest request = new ListAutoscalingPoliciesRequest
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
            return ListAutoscalingPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists autoscaling policies in the project.
        /// </summary>
        /// <param name="parent">
        /// Required. The "resource name" of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.autoscalingPolicies.list`, the resource name
        /// of the region has the following format:
        /// `projects/{project_id}/regions/{region}`
        /// 
        /// * For `projects.locations.autoscalingPolicies.list`, the resource name
        /// of the location has the following format:
        /// `projects/{project_id}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="AutoscalingPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAutoscalingPoliciesResponse, AutoscalingPolicy> ListAutoscalingPolicies(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAutoscalingPoliciesRequest request = new ListAutoscalingPoliciesRequest
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
            return ListAutoscalingPolicies(request, callSettings);
        }

        /// <summary>
        /// Lists autoscaling policies in the project.
        /// </summary>
        /// <param name="parent">
        /// Required. The "resource name" of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.autoscalingPolicies.list`, the resource name
        /// of the region has the following format:
        /// `projects/{project_id}/regions/{region}`
        /// 
        /// * For `projects.locations.autoscalingPolicies.list`, the resource name
        /// of the location has the following format:
        /// `projects/{project_id}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="AutoscalingPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAutoscalingPoliciesResponse, AutoscalingPolicy> ListAutoscalingPoliciesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAutoscalingPoliciesRequest request = new ListAutoscalingPoliciesRequest
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
            return ListAutoscalingPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists autoscaling policies in the project.
        /// </summary>
        /// <param name="parent">
        /// Required. The "resource name" of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.autoscalingPolicies.list`, the resource name
        /// of the region has the following format:
        /// `projects/{project_id}/regions/{region}`
        /// 
        /// * For `projects.locations.autoscalingPolicies.list`, the resource name
        /// of the location has the following format:
        /// `projects/{project_id}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="AutoscalingPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAutoscalingPoliciesResponse, AutoscalingPolicy> ListAutoscalingPolicies(RegionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAutoscalingPoliciesRequest request = new ListAutoscalingPoliciesRequest
            {
                ParentAsRegionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAutoscalingPolicies(request, callSettings);
        }

        /// <summary>
        /// Lists autoscaling policies in the project.
        /// </summary>
        /// <param name="parent">
        /// Required. The "resource name" of the region or location, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.autoscalingPolicies.list`, the resource name
        /// of the region has the following format:
        /// `projects/{project_id}/regions/{region}`
        /// 
        /// * For `projects.locations.autoscalingPolicies.list`, the resource name
        /// of the location has the following format:
        /// `projects/{project_id}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="AutoscalingPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAutoscalingPoliciesResponse, AutoscalingPolicy> ListAutoscalingPoliciesAsync(RegionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAutoscalingPoliciesRequest request = new ListAutoscalingPoliciesRequest
            {
                ParentAsRegionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAutoscalingPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes an autoscaling policy. It is an error to delete an autoscaling
        /// policy that is in use by one or more clusters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAutoscalingPolicy(DeleteAutoscalingPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an autoscaling policy. It is an error to delete an autoscaling
        /// policy that is in use by one or more clusters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAutoscalingPolicyAsync(DeleteAutoscalingPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an autoscaling policy. It is an error to delete an autoscaling
        /// policy that is in use by one or more clusters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAutoscalingPolicyAsync(DeleteAutoscalingPolicyRequest request, st::CancellationToken cancellationToken) =>
            DeleteAutoscalingPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an autoscaling policy. It is an error to delete an autoscaling
        /// policy that is in use by one or more clusters.
        /// </summary>
        /// <param name="name">
        /// Required. The "resource name" of the autoscaling policy, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.autoscalingPolicies.delete`, the resource name
        /// of the policy has the following format:
        /// `projects/{project_id}/regions/{region}/autoscalingPolicies/{policy_id}`
        /// 
        /// * For `projects.locations.autoscalingPolicies.delete`, the resource name
        /// of the policy has the following format:
        /// `projects/{project_id}/locations/{location}/autoscalingPolicies/{policy_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAutoscalingPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAutoscalingPolicy(new DeleteAutoscalingPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an autoscaling policy. It is an error to delete an autoscaling
        /// policy that is in use by one or more clusters.
        /// </summary>
        /// <param name="name">
        /// Required. The "resource name" of the autoscaling policy, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.autoscalingPolicies.delete`, the resource name
        /// of the policy has the following format:
        /// `projects/{project_id}/regions/{region}/autoscalingPolicies/{policy_id}`
        /// 
        /// * For `projects.locations.autoscalingPolicies.delete`, the resource name
        /// of the policy has the following format:
        /// `projects/{project_id}/locations/{location}/autoscalingPolicies/{policy_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAutoscalingPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAutoscalingPolicyAsync(new DeleteAutoscalingPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an autoscaling policy. It is an error to delete an autoscaling
        /// policy that is in use by one or more clusters.
        /// </summary>
        /// <param name="name">
        /// Required. The "resource name" of the autoscaling policy, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.autoscalingPolicies.delete`, the resource name
        /// of the policy has the following format:
        /// `projects/{project_id}/regions/{region}/autoscalingPolicies/{policy_id}`
        /// 
        /// * For `projects.locations.autoscalingPolicies.delete`, the resource name
        /// of the policy has the following format:
        /// `projects/{project_id}/locations/{location}/autoscalingPolicies/{policy_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAutoscalingPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAutoscalingPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an autoscaling policy. It is an error to delete an autoscaling
        /// policy that is in use by one or more clusters.
        /// </summary>
        /// <param name="name">
        /// Required. The "resource name" of the autoscaling policy, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.autoscalingPolicies.delete`, the resource name
        /// of the policy has the following format:
        /// `projects/{project_id}/regions/{region}/autoscalingPolicies/{policy_id}`
        /// 
        /// * For `projects.locations.autoscalingPolicies.delete`, the resource name
        /// of the policy has the following format:
        /// `projects/{project_id}/locations/{location}/autoscalingPolicies/{policy_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAutoscalingPolicy(AutoscalingPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAutoscalingPolicy(new DeleteAutoscalingPolicyRequest
            {
                AutoscalingPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an autoscaling policy. It is an error to delete an autoscaling
        /// policy that is in use by one or more clusters.
        /// </summary>
        /// <param name="name">
        /// Required. The "resource name" of the autoscaling policy, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.autoscalingPolicies.delete`, the resource name
        /// of the policy has the following format:
        /// `projects/{project_id}/regions/{region}/autoscalingPolicies/{policy_id}`
        /// 
        /// * For `projects.locations.autoscalingPolicies.delete`, the resource name
        /// of the policy has the following format:
        /// `projects/{project_id}/locations/{location}/autoscalingPolicies/{policy_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAutoscalingPolicyAsync(AutoscalingPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAutoscalingPolicyAsync(new DeleteAutoscalingPolicyRequest
            {
                AutoscalingPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an autoscaling policy. It is an error to delete an autoscaling
        /// policy that is in use by one or more clusters.
        /// </summary>
        /// <param name="name">
        /// Required. The "resource name" of the autoscaling policy, as described
        /// in https://cloud.google.com/apis/design/resource_names.
        /// 
        /// * For `projects.regions.autoscalingPolicies.delete`, the resource name
        /// of the policy has the following format:
        /// `projects/{project_id}/regions/{region}/autoscalingPolicies/{policy_id}`
        /// 
        /// * For `projects.locations.autoscalingPolicies.delete`, the resource name
        /// of the policy has the following format:
        /// `projects/{project_id}/locations/{location}/autoscalingPolicies/{policy_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAutoscalingPolicyAsync(AutoscalingPolicyName name, st::CancellationToken cancellationToken) =>
            DeleteAutoscalingPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AutoscalingPolicyService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The API interface for managing autoscaling policies in the
    /// Dataproc API.
    /// </remarks>
    public sealed partial class AutoscalingPolicyServiceClientImpl : AutoscalingPolicyServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateAutoscalingPolicyRequest, AutoscalingPolicy> _callCreateAutoscalingPolicy;

        private readonly gaxgrpc::ApiCall<UpdateAutoscalingPolicyRequest, AutoscalingPolicy> _callUpdateAutoscalingPolicy;

        private readonly gaxgrpc::ApiCall<GetAutoscalingPolicyRequest, AutoscalingPolicy> _callGetAutoscalingPolicy;

        private readonly gaxgrpc::ApiCall<ListAutoscalingPoliciesRequest, ListAutoscalingPoliciesResponse> _callListAutoscalingPolicies;

        private readonly gaxgrpc::ApiCall<DeleteAutoscalingPolicyRequest, wkt::Empty> _callDeleteAutoscalingPolicy;

        /// <summary>
        /// Constructs a client wrapper for the AutoscalingPolicyService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="AutoscalingPolicyServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AutoscalingPolicyServiceClientImpl(AutoscalingPolicyService.AutoscalingPolicyServiceClient grpcClient, AutoscalingPolicyServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AutoscalingPolicyServiceSettings effectiveSettings = settings ?? AutoscalingPolicyServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateAutoscalingPolicy = clientHelper.BuildApiCall<CreateAutoscalingPolicyRequest, AutoscalingPolicy>("CreateAutoscalingPolicy", grpcClient.CreateAutoscalingPolicyAsync, grpcClient.CreateAutoscalingPolicy, effectiveSettings.CreateAutoscalingPolicySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAutoscalingPolicy);
            Modify_CreateAutoscalingPolicyApiCall(ref _callCreateAutoscalingPolicy);
            _callUpdateAutoscalingPolicy = clientHelper.BuildApiCall<UpdateAutoscalingPolicyRequest, AutoscalingPolicy>("UpdateAutoscalingPolicy", grpcClient.UpdateAutoscalingPolicyAsync, grpcClient.UpdateAutoscalingPolicy, effectiveSettings.UpdateAutoscalingPolicySettings).WithGoogleRequestParam("policy.name", request => request.Policy?.Name);
            Modify_ApiCall(ref _callUpdateAutoscalingPolicy);
            Modify_UpdateAutoscalingPolicyApiCall(ref _callUpdateAutoscalingPolicy);
            _callGetAutoscalingPolicy = clientHelper.BuildApiCall<GetAutoscalingPolicyRequest, AutoscalingPolicy>("GetAutoscalingPolicy", grpcClient.GetAutoscalingPolicyAsync, grpcClient.GetAutoscalingPolicy, effectiveSettings.GetAutoscalingPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAutoscalingPolicy);
            Modify_GetAutoscalingPolicyApiCall(ref _callGetAutoscalingPolicy);
            _callListAutoscalingPolicies = clientHelper.BuildApiCall<ListAutoscalingPoliciesRequest, ListAutoscalingPoliciesResponse>("ListAutoscalingPolicies", grpcClient.ListAutoscalingPoliciesAsync, grpcClient.ListAutoscalingPolicies, effectiveSettings.ListAutoscalingPoliciesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAutoscalingPolicies);
            Modify_ListAutoscalingPoliciesApiCall(ref _callListAutoscalingPolicies);
            _callDeleteAutoscalingPolicy = clientHelper.BuildApiCall<DeleteAutoscalingPolicyRequest, wkt::Empty>("DeleteAutoscalingPolicy", grpcClient.DeleteAutoscalingPolicyAsync, grpcClient.DeleteAutoscalingPolicy, effectiveSettings.DeleteAutoscalingPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAutoscalingPolicy);
            Modify_DeleteAutoscalingPolicyApiCall(ref _callDeleteAutoscalingPolicy);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateAutoscalingPolicyApiCall(ref gaxgrpc::ApiCall<CreateAutoscalingPolicyRequest, AutoscalingPolicy> call);

        partial void Modify_UpdateAutoscalingPolicyApiCall(ref gaxgrpc::ApiCall<UpdateAutoscalingPolicyRequest, AutoscalingPolicy> call);

        partial void Modify_GetAutoscalingPolicyApiCall(ref gaxgrpc::ApiCall<GetAutoscalingPolicyRequest, AutoscalingPolicy> call);

        partial void Modify_ListAutoscalingPoliciesApiCall(ref gaxgrpc::ApiCall<ListAutoscalingPoliciesRequest, ListAutoscalingPoliciesResponse> call);

        partial void Modify_DeleteAutoscalingPolicyApiCall(ref gaxgrpc::ApiCall<DeleteAutoscalingPolicyRequest, wkt::Empty> call);

        partial void OnConstruction(AutoscalingPolicyService.AutoscalingPolicyServiceClient grpcClient, AutoscalingPolicyServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AutoscalingPolicyService client</summary>
        public override AutoscalingPolicyService.AutoscalingPolicyServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateAutoscalingPolicyRequest(ref CreateAutoscalingPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAutoscalingPolicyRequest(ref UpdateAutoscalingPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAutoscalingPolicyRequest(ref GetAutoscalingPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAutoscalingPoliciesRequest(ref ListAutoscalingPoliciesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAutoscalingPolicyRequest(ref DeleteAutoscalingPolicyRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates new autoscaling policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AutoscalingPolicy CreateAutoscalingPolicy(CreateAutoscalingPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAutoscalingPolicyRequest(ref request, ref callSettings);
            return _callCreateAutoscalingPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates new autoscaling policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AutoscalingPolicy> CreateAutoscalingPolicyAsync(CreateAutoscalingPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAutoscalingPolicyRequest(ref request, ref callSettings);
            return _callCreateAutoscalingPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Updates (replaces) autoscaling policy.
        /// 
        /// Disabled check for update_mask, because all updates will be full
        /// replacements.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AutoscalingPolicy UpdateAutoscalingPolicy(UpdateAutoscalingPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAutoscalingPolicyRequest(ref request, ref callSettings);
            return _callUpdateAutoscalingPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates (replaces) autoscaling policy.
        /// 
        /// Disabled check for update_mask, because all updates will be full
        /// replacements.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AutoscalingPolicy> UpdateAutoscalingPolicyAsync(UpdateAutoscalingPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAutoscalingPolicyRequest(ref request, ref callSettings);
            return _callUpdateAutoscalingPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves autoscaling policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AutoscalingPolicy GetAutoscalingPolicy(GetAutoscalingPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAutoscalingPolicyRequest(ref request, ref callSettings);
            return _callGetAutoscalingPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves autoscaling policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AutoscalingPolicy> GetAutoscalingPolicyAsync(GetAutoscalingPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAutoscalingPolicyRequest(ref request, ref callSettings);
            return _callGetAutoscalingPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Lists autoscaling policies in the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AutoscalingPolicy"/> resources.</returns>
        public override gax::PagedEnumerable<ListAutoscalingPoliciesResponse, AutoscalingPolicy> ListAutoscalingPolicies(ListAutoscalingPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAutoscalingPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAutoscalingPoliciesRequest, ListAutoscalingPoliciesResponse, AutoscalingPolicy>(_callListAutoscalingPolicies, request, callSettings);
        }

        /// <summary>
        /// Lists autoscaling policies in the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AutoscalingPolicy"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAutoscalingPoliciesResponse, AutoscalingPolicy> ListAutoscalingPoliciesAsync(ListAutoscalingPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAutoscalingPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAutoscalingPoliciesRequest, ListAutoscalingPoliciesResponse, AutoscalingPolicy>(_callListAutoscalingPolicies, request, callSettings);
        }

        /// <summary>
        /// Deletes an autoscaling policy. It is an error to delete an autoscaling
        /// policy that is in use by one or more clusters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteAutoscalingPolicy(DeleteAutoscalingPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAutoscalingPolicyRequest(ref request, ref callSettings);
            _callDeleteAutoscalingPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an autoscaling policy. It is an error to delete an autoscaling
        /// policy that is in use by one or more clusters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteAutoscalingPolicyAsync(DeleteAutoscalingPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAutoscalingPolicyRequest(ref request, ref callSettings);
            return _callDeleteAutoscalingPolicy.Async(request, callSettings);
        }
    }

    public partial class ListAutoscalingPoliciesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAutoscalingPoliciesResponse : gaxgrpc::IPageResponse<AutoscalingPolicy>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AutoscalingPolicy> GetEnumerator() => Policies.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class AutoscalingPolicyService
    {
        public partial class AutoscalingPolicyServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="gciv::IAMPolicy.IAMPolicyClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gciv::IAMPolicy.IAMPolicyClient"/> for the same target as this client.
            /// </returns>
            public virtual gciv::IAMPolicy.IAMPolicyClient CreateIAMPolicyClient() =>
                new gciv::IAMPolicy.IAMPolicyClient(CallInvoker);
        }
    }
}
