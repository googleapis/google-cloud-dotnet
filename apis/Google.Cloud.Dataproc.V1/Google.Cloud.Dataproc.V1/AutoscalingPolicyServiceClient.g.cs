// Copyright 2020 Google LLC
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
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

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
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAutoscalingPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

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
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAutoscalingPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

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

        /// <inheritdoc/>
        public override AutoscalingPolicyServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AutoscalingPolicyServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc/>
        public override async stt::Task<AutoscalingPolicyServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AutoscalingPolicyServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc/>
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => AutoscalingPolicyServiceClient.DefaultEndpoint;

        /// <inheritdoc/>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => AutoscalingPolicyServiceClient.DefaultScopes;

        /// <inheritdoc/>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AutoscalingPolicyServiceClient.ChannelPool;
    }

    /// <summary>AutoscalingPolicyService client wrapper, for convenient use.</summary>
    public abstract partial class AutoscalingPolicyServiceClient
    {
        /// <summary>
        /// The default endpoint for the AutoscalingPolicyService service, which is a host of "dataproc.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("dataproc.googleapis.com", 443);

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

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="AutoscalingPolicyServiceClient"/>, applying defaults for all unspecified
        /// settings, and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ImageAnnotatorClient client = await ImageAnnotatorClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ImageAnnotatorClient.DefaultEndpoint.Host, ImageAnnotatorClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ImageAnnotatorClient client = ImageAnnotatorClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="AutoscalingPolicyServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="AutoscalingPolicyServiceClient"/>.</returns>
        public static async stt::Task<AutoscalingPolicyServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, AutoscalingPolicyServiceSettings settings = null)
        {
            grpccore::Channel channel = await ChannelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="AutoscalingPolicyServiceClient"/>, applying defaults for all unspecified
        /// settings, and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ImageAnnotatorClient client = ImageAnnotatorClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ImageAnnotatorClient.DefaultEndpoint.Host, ImageAnnotatorClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ImageAnnotatorClient client = ImageAnnotatorClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="AutoscalingPolicyServiceSettings"/>.</param>
        /// <returns>The created <see cref="AutoscalingPolicyServiceClient"/>.</returns>
        public static AutoscalingPolicyServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, AutoscalingPolicyServiceSettings settings = null)
        {
            grpccore::Channel channel = ChannelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="AutoscalingPolicyServiceClient"/> which uses the specified channel for remote
        /// operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="AutoscalingPolicyServiceSettings"/>.</param>
        /// <returns>The created <see cref="AutoscalingPolicyServiceClient"/>.</returns>
        public static AutoscalingPolicyServiceClient Create(grpccore::Channel channel, AutoscalingPolicyServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="AutoscalingPolicyServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AutoscalingPolicyServiceSettings"/>.</param>
        /// <returns>The created <see cref="AutoscalingPolicyServiceClient"/>.</returns>
        public static AutoscalingPolicyServiceClient Create(grpccore::CallInvoker callInvoker, AutoscalingPolicyServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AutoscalingPolicyService.AutoscalingPolicyServiceClient grpcClient = new AutoscalingPolicyService.AutoscalingPolicyServiceClient(callInvoker);
            return new AutoscalingPolicyServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by
        /// <see cref="Create(grpccore::CallInvoker,AutoscalingPolicyServiceSettings)"/> and
        /// <see cref="CreateAsync(gaxgrpc::ServiceEndpoint,AutoscalingPolicyServiceSettings)"/>. Channels which weren't
        /// automatically created are not affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to
        /// <see cref="Create(grpccore::CallInvoker,AutoscalingPolicyServiceSettings)"/> and
        /// <see cref="CreateAsync(gaxgrpc::ServiceEndpoint,AutoscalingPolicyServiceSettings)"/> will create new
        /// channels, which could in turn be shut down by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC AutoscalingPolicyService client</summary>
        public virtual AutoscalingPolicyService.AutoscalingPolicyServiceClient GrpcClient => throw new sys::NotImplementedException();

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
    }

    /// <summary>AutoscalingPolicyService client wrapper implementation, for convenient use.</summary>
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
        public AutoscalingPolicyServiceClientImpl(AutoscalingPolicyService.AutoscalingPolicyServiceClient grpcClient, AutoscalingPolicyServiceSettings settings)
        {
            GrpcClient = grpcClient;
            AutoscalingPolicyServiceSettings effectiveSettings = settings ?? AutoscalingPolicyServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callCreateAutoscalingPolicy = clientHelper.BuildApiCall<CreateAutoscalingPolicyRequest, AutoscalingPolicy>(grpcClient.CreateAutoscalingPolicyAsync, grpcClient.CreateAutoscalingPolicy, effectiveSettings.CreateAutoscalingPolicySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAutoscalingPolicy);
            Modify_CreateAutoscalingPolicyApiCall(ref _callCreateAutoscalingPolicy);
            _callUpdateAutoscalingPolicy = clientHelper.BuildApiCall<UpdateAutoscalingPolicyRequest, AutoscalingPolicy>(grpcClient.UpdateAutoscalingPolicyAsync, grpcClient.UpdateAutoscalingPolicy, effectiveSettings.UpdateAutoscalingPolicySettings).WithGoogleRequestParam("policy.name", request => request.Policy?.Name);
            Modify_ApiCall(ref _callUpdateAutoscalingPolicy);
            Modify_UpdateAutoscalingPolicyApiCall(ref _callUpdateAutoscalingPolicy);
            _callGetAutoscalingPolicy = clientHelper.BuildApiCall<GetAutoscalingPolicyRequest, AutoscalingPolicy>(grpcClient.GetAutoscalingPolicyAsync, grpcClient.GetAutoscalingPolicy, effectiveSettings.GetAutoscalingPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAutoscalingPolicy);
            Modify_GetAutoscalingPolicyApiCall(ref _callGetAutoscalingPolicy);
            _callListAutoscalingPolicies = clientHelper.BuildApiCall<ListAutoscalingPoliciesRequest, ListAutoscalingPoliciesResponse>(grpcClient.ListAutoscalingPoliciesAsync, grpcClient.ListAutoscalingPolicies, effectiveSettings.ListAutoscalingPoliciesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAutoscalingPolicies);
            Modify_ListAutoscalingPoliciesApiCall(ref _callListAutoscalingPolicies);
            _callDeleteAutoscalingPolicy = clientHelper.BuildApiCall<DeleteAutoscalingPolicyRequest, wkt::Empty>(grpcClient.DeleteAutoscalingPolicyAsync, grpcClient.DeleteAutoscalingPolicy, effectiveSettings.DeleteAutoscalingPolicySettings).WithGoogleRequestParam("name", request => request.Name);
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
}
