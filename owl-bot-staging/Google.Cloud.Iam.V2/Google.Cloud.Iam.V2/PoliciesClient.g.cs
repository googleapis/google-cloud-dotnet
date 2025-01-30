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

namespace Google.Cloud.Iam.V2
{
    /// <summary>Settings for <see cref="PoliciesClient"/> instances.</summary>
    public sealed partial class PoliciesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PoliciesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PoliciesSettings"/>.</returns>
        public static PoliciesSettings GetDefault() => new PoliciesSettings();

        /// <summary>Constructs a new <see cref="PoliciesSettings"/> object with default settings.</summary>
        public PoliciesSettings()
        {
        }

        private PoliciesSettings(PoliciesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListPoliciesSettings = existing.ListPoliciesSettings;
            GetPolicySettings = existing.GetPolicySettings;
            CreatePolicySettings = existing.CreatePolicySettings;
            CreatePolicyOperationsSettings = existing.CreatePolicyOperationsSettings.Clone();
            UpdatePolicySettings = existing.UpdatePolicySettings;
            UpdatePolicyOperationsSettings = existing.UpdatePolicyOperationsSettings.Clone();
            DeletePolicySettings = existing.DeletePolicySettings;
            DeletePolicyOperationsSettings = existing.DeletePolicyOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(PoliciesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>PoliciesClient.ListPolicies</c>
        ///  and <c>PoliciesClient.ListPoliciesAsync</c>.
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
        public gaxgrpc::CallSettings ListPoliciesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>PoliciesClient.GetPolicy</c>
        ///  and <c>PoliciesClient.GetPolicyAsync</c>.
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
        public gaxgrpc::CallSettings GetPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>PoliciesClient.CreatePolicy</c>
        ///  and <c>PoliciesClient.CreatePolicyAsync</c>.
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
        public gaxgrpc::CallSettings CreatePolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>PoliciesClient.CreatePolicy</c> and
        /// <c>PoliciesClient.CreatePolicyAsync</c>.
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
        public lro::OperationsSettings CreatePolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>PoliciesClient.UpdatePolicy</c>
        ///  and <c>PoliciesClient.UpdatePolicyAsync</c>.
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
        public gaxgrpc::CallSettings UpdatePolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>PoliciesClient.UpdatePolicy</c> and
        /// <c>PoliciesClient.UpdatePolicyAsync</c>.
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
        public lro::OperationsSettings UpdatePolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>PoliciesClient.DeletePolicy</c>
        ///  and <c>PoliciesClient.DeletePolicyAsync</c>.
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
        public gaxgrpc::CallSettings DeletePolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>PoliciesClient.DeletePolicy</c> and
        /// <c>PoliciesClient.DeletePolicyAsync</c>.
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
        public lro::OperationsSettings DeletePolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PoliciesSettings"/> object.</returns>
        public PoliciesSettings Clone() => new PoliciesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PoliciesClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class PoliciesClientBuilder : gaxgrpc::ClientBuilderBase<PoliciesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PoliciesSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public PoliciesClientBuilder() : base(PoliciesClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref PoliciesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PoliciesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PoliciesClient Build()
        {
            PoliciesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PoliciesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PoliciesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PoliciesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PoliciesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<PoliciesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PoliciesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PoliciesClient.ChannelPool;
    }

    /// <summary>Policies client wrapper, for convenient use.</summary>
    /// <remarks>
    /// An interface for managing Identity and Access Management (IAM) policies.
    /// </remarks>
    public abstract partial class PoliciesClient
    {
        /// <summary>
        /// The default endpoint for the Policies service, which is a host of "iam.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "iam.googleapis.com:443";

        /// <summary>The default Policies scopes.</summary>
        /// <remarks>
        /// The default Policies scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Policies.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="PoliciesClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="PoliciesClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PoliciesClient"/>.</returns>
        public static stt::Task<PoliciesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PoliciesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PoliciesClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="PoliciesClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PoliciesClient"/>.</returns>
        public static PoliciesClient Create() => new PoliciesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PoliciesClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PoliciesSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="PoliciesClient"/>.</returns>
        internal static PoliciesClient Create(grpccore::CallInvoker callInvoker, PoliciesSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Policies.PoliciesClient grpcClient = new Policies.PoliciesClient(callInvoker);
            return new PoliciesClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Policies client</summary>
        public virtual Policies.PoliciesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the policies of the specified kind that are attached to a
        /// resource.
        /// 
        /// The response lists only policy metadata. In particular, policy rules are
        /// omitted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Policy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPoliciesResponse, Policy> ListPolicies(ListPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the policies of the specified kind that are attached to a
        /// resource.
        /// 
        /// The response lists only policy metadata. In particular, policy rules are
        /// omitted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Policy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPoliciesResponse, Policy> ListPoliciesAsync(ListPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the policies of the specified kind that are attached to a
        /// resource.
        /// 
        /// The response lists only policy metadata. In particular, policy rules are
        /// omitted.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource that the policy is attached to, along with the kind of policy
        /// to list. Format:
        /// `policies/{attachment_point}/denypolicies`
        /// 
        /// 
        /// The attachment point is identified by its URL-encoded full resource name,
        /// which means that the forward-slash character, `/`, must be written as
        /// `%2F`. For example,
        /// `policies/cloudresourcemanager.googleapis.com%2Fprojects%2Fmy-project/denypolicies`.
        /// 
        /// For organizations and folders, use the numeric ID in the full resource
        /// name. For projects, you can use the alphanumeric or the numeric ID.
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
        /// <returns>A pageable sequence of <see cref="Policy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPoliciesResponse, Policy> ListPolicies(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPoliciesRequest request = new ListPoliciesRequest
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
            return ListPolicies(request, callSettings);
        }

        /// <summary>
        /// Retrieves the policies of the specified kind that are attached to a
        /// resource.
        /// 
        /// The response lists only policy metadata. In particular, policy rules are
        /// omitted.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource that the policy is attached to, along with the kind of policy
        /// to list. Format:
        /// `policies/{attachment_point}/denypolicies`
        /// 
        /// 
        /// The attachment point is identified by its URL-encoded full resource name,
        /// which means that the forward-slash character, `/`, must be written as
        /// `%2F`. For example,
        /// `policies/cloudresourcemanager.googleapis.com%2Fprojects%2Fmy-project/denypolicies`.
        /// 
        /// For organizations and folders, use the numeric ID in the full resource
        /// name. For projects, you can use the alphanumeric or the numeric ID.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Policy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPoliciesResponse, Policy> ListPoliciesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPoliciesRequest request = new ListPoliciesRequest
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
            return ListPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy GetPolicy(GetPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetPolicyAsync(GetPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetPolicyAsync(GetPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a policy.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the policy to retrieve. Format:
        /// `policies/{attachment_point}/denypolicies/{policy_id}`
        /// 
        /// 
        /// Use the URL-encoded full resource name, which means that the forward-slash
        /// character, `/`, must be written as `%2F`. For example,
        /// `policies/cloudresourcemanager.googleapis.com%2Fprojects%2Fmy-project/denypolicies/my-policy`.
        /// 
        /// For organizations and folders, use the numeric ID in the full resource
        /// name. For projects, you can use the alphanumeric or the numeric ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy GetPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPolicy(new GetPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a policy.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the policy to retrieve. Format:
        /// `policies/{attachment_point}/denypolicies/{policy_id}`
        /// 
        /// 
        /// Use the URL-encoded full resource name, which means that the forward-slash
        /// character, `/`, must be written as `%2F`. For example,
        /// `policies/cloudresourcemanager.googleapis.com%2Fprojects%2Fmy-project/denypolicies/my-policy`.
        /// 
        /// For organizations and folders, use the numeric ID in the full resource
        /// name. For projects, you can use the alphanumeric or the numeric ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPolicyAsync(new GetPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a policy.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the policy to retrieve. Format:
        /// `policies/{attachment_point}/denypolicies/{policy_id}`
        /// 
        /// 
        /// Use the URL-encoded full resource name, which means that the forward-slash
        /// character, `/`, must be written as `%2F`. For example,
        /// `policies/cloudresourcemanager.googleapis.com%2Fprojects%2Fmy-project/denypolicies/my-policy`.
        /// 
        /// For organizations and folders, use the numeric ID in the full resource
        /// name. For projects, you can use the alphanumeric or the numeric ID.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            GetPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Policy, PolicyOperationMetadata> CreatePolicy(CreatePolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Policy, PolicyOperationMetadata>> CreatePolicyAsync(CreatePolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Policy, PolicyOperationMetadata>> CreatePolicyAsync(CreatePolicyRequest request, st::CancellationToken cancellationToken) =>
            CreatePolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreatePolicy</c>.</summary>
        public virtual lro::OperationsClient CreatePolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreatePolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Policy, PolicyOperationMetadata> PollOnceCreatePolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Policy, PolicyOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreatePolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreatePolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Policy, PolicyOperationMetadata>> PollOnceCreatePolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Policy, PolicyOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreatePolicyOperationsClient, callSettings);

        /// <summary>
        /// Creates a policy.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource that the policy is attached to, along with the kind of policy
        /// to create. Format: `policies/{attachment_point}/denypolicies`
        /// 
        /// 
        /// The attachment point is identified by its URL-encoded full resource name,
        /// which means that the forward-slash character, `/`, must be written as
        /// `%2F`. For example,
        /// `policies/cloudresourcemanager.googleapis.com%2Fprojects%2Fmy-project/denypolicies`.
        /// 
        /// For organizations and folders, use the numeric ID in the full resource
        /// name. For projects, you can use the alphanumeric or the numeric ID.
        /// </param>
        /// <param name="policy">
        /// Required. The policy to create.
        /// </param>
        /// <param name="policyId">
        /// The ID to use for this policy, which will become the final component of
        /// the policy's resource name. The ID must contain 3 to 63 characters. It can
        /// contain lowercase letters and numbers, as well as dashes (`-`) and periods
        /// (`.`). The first character must be a lowercase letter.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Policy, PolicyOperationMetadata> CreatePolicy(string parent, Policy policy, string policyId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePolicy(new CreatePolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
                PolicyId = policyId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a policy.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource that the policy is attached to, along with the kind of policy
        /// to create. Format: `policies/{attachment_point}/denypolicies`
        /// 
        /// 
        /// The attachment point is identified by its URL-encoded full resource name,
        /// which means that the forward-slash character, `/`, must be written as
        /// `%2F`. For example,
        /// `policies/cloudresourcemanager.googleapis.com%2Fprojects%2Fmy-project/denypolicies`.
        /// 
        /// For organizations and folders, use the numeric ID in the full resource
        /// name. For projects, you can use the alphanumeric or the numeric ID.
        /// </param>
        /// <param name="policy">
        /// Required. The policy to create.
        /// </param>
        /// <param name="policyId">
        /// The ID to use for this policy, which will become the final component of
        /// the policy's resource name. The ID must contain 3 to 63 characters. It can
        /// contain lowercase letters and numbers, as well as dashes (`-`) and periods
        /// (`.`). The first character must be a lowercase letter.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Policy, PolicyOperationMetadata>> CreatePolicyAsync(string parent, Policy policy, string policyId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePolicyAsync(new CreatePolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
                PolicyId = policyId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates a policy.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource that the policy is attached to, along with the kind of policy
        /// to create. Format: `policies/{attachment_point}/denypolicies`
        /// 
        /// 
        /// The attachment point is identified by its URL-encoded full resource name,
        /// which means that the forward-slash character, `/`, must be written as
        /// `%2F`. For example,
        /// `policies/cloudresourcemanager.googleapis.com%2Fprojects%2Fmy-project/denypolicies`.
        /// 
        /// For organizations and folders, use the numeric ID in the full resource
        /// name. For projects, you can use the alphanumeric or the numeric ID.
        /// </param>
        /// <param name="policy">
        /// Required. The policy to create.
        /// </param>
        /// <param name="policyId">
        /// The ID to use for this policy, which will become the final component of
        /// the policy's resource name. The ID must contain 3 to 63 characters. It can
        /// contain lowercase letters and numbers, as well as dashes (`-`) and periods
        /// (`.`). The first character must be a lowercase letter.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Policy, PolicyOperationMetadata>> CreatePolicyAsync(string parent, Policy policy, string policyId, st::CancellationToken cancellationToken) =>
            CreatePolicyAsync(parent, policy, policyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified policy.
        /// 
        /// You can update only the rules and the display name for the policy.
        /// 
        /// To update a policy, you should use a read-modify-write loop:
        /// 
        /// 1. Use [GetPolicy][google.iam.v2.Policies.GetPolicy] to read the current version of the policy.
        /// 2. Modify the policy as needed.
        /// 3. Use `UpdatePolicy` to write the updated policy.
        /// 
        /// This pattern helps prevent conflicts between concurrent updates.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Policy, PolicyOperationMetadata> UpdatePolicy(UpdatePolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified policy.
        /// 
        /// You can update only the rules and the display name for the policy.
        /// 
        /// To update a policy, you should use a read-modify-write loop:
        /// 
        /// 1. Use [GetPolicy][google.iam.v2.Policies.GetPolicy] to read the current version of the policy.
        /// 2. Modify the policy as needed.
        /// 3. Use `UpdatePolicy` to write the updated policy.
        /// 
        /// This pattern helps prevent conflicts between concurrent updates.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Policy, PolicyOperationMetadata>> UpdatePolicyAsync(UpdatePolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified policy.
        /// 
        /// You can update only the rules and the display name for the policy.
        /// 
        /// To update a policy, you should use a read-modify-write loop:
        /// 
        /// 1. Use [GetPolicy][google.iam.v2.Policies.GetPolicy] to read the current version of the policy.
        /// 2. Modify the policy as needed.
        /// 3. Use `UpdatePolicy` to write the updated policy.
        /// 
        /// This pattern helps prevent conflicts between concurrent updates.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Policy, PolicyOperationMetadata>> UpdatePolicyAsync(UpdatePolicyRequest request, st::CancellationToken cancellationToken) =>
            UpdatePolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdatePolicy</c>.</summary>
        public virtual lro::OperationsClient UpdatePolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdatePolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Policy, PolicyOperationMetadata> PollOnceUpdatePolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Policy, PolicyOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdatePolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdatePolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Policy, PolicyOperationMetadata>> PollOnceUpdatePolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Policy, PolicyOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdatePolicyOperationsClient, callSettings);

        /// <summary>
        /// Deletes a policy. This action is permanent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Policy, PolicyOperationMetadata> DeletePolicy(DeletePolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a policy. This action is permanent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Policy, PolicyOperationMetadata>> DeletePolicyAsync(DeletePolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a policy. This action is permanent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Policy, PolicyOperationMetadata>> DeletePolicyAsync(DeletePolicyRequest request, st::CancellationToken cancellationToken) =>
            DeletePolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeletePolicy</c>.</summary>
        public virtual lro::OperationsClient DeletePolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeletePolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Policy, PolicyOperationMetadata> PollOnceDeletePolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Policy, PolicyOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeletePolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeletePolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Policy, PolicyOperationMetadata>> PollOnceDeletePolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Policy, PolicyOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeletePolicyOperationsClient, callSettings);

        /// <summary>
        /// Deletes a policy. This action is permanent.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the policy to delete. Format:
        /// `policies/{attachment_point}/denypolicies/{policy_id}`
        /// 
        /// 
        /// Use the URL-encoded full resource name, which means that the forward-slash
        /// character, `/`, must be written as `%2F`. For example,
        /// `policies/cloudresourcemanager.googleapis.com%2Fprojects%2Fmy-project/denypolicies/my-policy`.
        /// 
        /// For organizations and folders, use the numeric ID in the full resource
        /// name. For projects, you can use the alphanumeric or the numeric ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Policy, PolicyOperationMetadata> DeletePolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePolicy(new DeletePolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a policy. This action is permanent.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the policy to delete. Format:
        /// `policies/{attachment_point}/denypolicies/{policy_id}`
        /// 
        /// 
        /// Use the URL-encoded full resource name, which means that the forward-slash
        /// character, `/`, must be written as `%2F`. For example,
        /// `policies/cloudresourcemanager.googleapis.com%2Fprojects%2Fmy-project/denypolicies/my-policy`.
        /// 
        /// For organizations and folders, use the numeric ID in the full resource
        /// name. For projects, you can use the alphanumeric or the numeric ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Policy, PolicyOperationMetadata>> DeletePolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePolicyAsync(new DeletePolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a policy. This action is permanent.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the policy to delete. Format:
        /// `policies/{attachment_point}/denypolicies/{policy_id}`
        /// 
        /// 
        /// Use the URL-encoded full resource name, which means that the forward-slash
        /// character, `/`, must be written as `%2F`. For example,
        /// `policies/cloudresourcemanager.googleapis.com%2Fprojects%2Fmy-project/denypolicies/my-policy`.
        /// 
        /// For organizations and folders, use the numeric ID in the full resource
        /// name. For projects, you can use the alphanumeric or the numeric ID.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Policy, PolicyOperationMetadata>> DeletePolicyAsync(string name, st::CancellationToken cancellationToken) =>
            DeletePolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Policies client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// An interface for managing Identity and Access Management (IAM) policies.
    /// </remarks>
    public sealed partial class PoliciesClientImpl : PoliciesClient
    {
        private readonly gaxgrpc::ApiCall<ListPoliciesRequest, ListPoliciesResponse> _callListPolicies;

        private readonly gaxgrpc::ApiCall<GetPolicyRequest, Policy> _callGetPolicy;

        private readonly gaxgrpc::ApiCall<CreatePolicyRequest, lro::Operation> _callCreatePolicy;

        private readonly gaxgrpc::ApiCall<UpdatePolicyRequest, lro::Operation> _callUpdatePolicy;

        private readonly gaxgrpc::ApiCall<DeletePolicyRequest, lro::Operation> _callDeletePolicy;

        /// <summary>
        /// Constructs a client wrapper for the Policies service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="PoliciesSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public PoliciesClientImpl(Policies.PoliciesClient grpcClient, PoliciesSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            PoliciesSettings effectiveSettings = settings ?? PoliciesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreatePolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreatePolicyOperationsSettings, logger);
            UpdatePolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdatePolicyOperationsSettings, logger);
            DeletePolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeletePolicyOperationsSettings, logger);
            _callListPolicies = clientHelper.BuildApiCall<ListPoliciesRequest, ListPoliciesResponse>("ListPolicies", grpcClient.ListPoliciesAsync, grpcClient.ListPolicies, effectiveSettings.ListPoliciesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPolicies);
            Modify_ListPoliciesApiCall(ref _callListPolicies);
            _callGetPolicy = clientHelper.BuildApiCall<GetPolicyRequest, Policy>("GetPolicy", grpcClient.GetPolicyAsync, grpcClient.GetPolicy, effectiveSettings.GetPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPolicy);
            Modify_GetPolicyApiCall(ref _callGetPolicy);
            _callCreatePolicy = clientHelper.BuildApiCall<CreatePolicyRequest, lro::Operation>("CreatePolicy", grpcClient.CreatePolicyAsync, grpcClient.CreatePolicy, effectiveSettings.CreatePolicySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreatePolicy);
            Modify_CreatePolicyApiCall(ref _callCreatePolicy);
            _callUpdatePolicy = clientHelper.BuildApiCall<UpdatePolicyRequest, lro::Operation>("UpdatePolicy", grpcClient.UpdatePolicyAsync, grpcClient.UpdatePolicy, effectiveSettings.UpdatePolicySettings).WithGoogleRequestParam("policy.name", request => request.Policy?.Name);
            Modify_ApiCall(ref _callUpdatePolicy);
            Modify_UpdatePolicyApiCall(ref _callUpdatePolicy);
            _callDeletePolicy = clientHelper.BuildApiCall<DeletePolicyRequest, lro::Operation>("DeletePolicy", grpcClient.DeletePolicyAsync, grpcClient.DeletePolicy, effectiveSettings.DeletePolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeletePolicy);
            Modify_DeletePolicyApiCall(ref _callDeletePolicy);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListPoliciesApiCall(ref gaxgrpc::ApiCall<ListPoliciesRequest, ListPoliciesResponse> call);

        partial void Modify_GetPolicyApiCall(ref gaxgrpc::ApiCall<GetPolicyRequest, Policy> call);

        partial void Modify_CreatePolicyApiCall(ref gaxgrpc::ApiCall<CreatePolicyRequest, lro::Operation> call);

        partial void Modify_UpdatePolicyApiCall(ref gaxgrpc::ApiCall<UpdatePolicyRequest, lro::Operation> call);

        partial void Modify_DeletePolicyApiCall(ref gaxgrpc::ApiCall<DeletePolicyRequest, lro::Operation> call);

        partial void OnConstruction(Policies.PoliciesClient grpcClient, PoliciesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Policies client</summary>
        public override Policies.PoliciesClient GrpcClient { get; }

        partial void Modify_ListPoliciesRequest(ref ListPoliciesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPolicyRequest(ref GetPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreatePolicyRequest(ref CreatePolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdatePolicyRequest(ref UpdatePolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePolicyRequest(ref DeletePolicyRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves the policies of the specified kind that are attached to a
        /// resource.
        /// 
        /// The response lists only policy metadata. In particular, policy rules are
        /// omitted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Policy"/> resources.</returns>
        public override gax::PagedEnumerable<ListPoliciesResponse, Policy> ListPolicies(ListPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPoliciesRequest, ListPoliciesResponse, Policy>(_callListPolicies, request, callSettings);
        }

        /// <summary>
        /// Retrieves the policies of the specified kind that are attached to a
        /// resource.
        /// 
        /// The response lists only policy metadata. In particular, policy rules are
        /// omitted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Policy"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPoliciesResponse, Policy> ListPoliciesAsync(ListPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPoliciesRequest, ListPoliciesResponse, Policy>(_callListPolicies, request, callSettings);
        }

        /// <summary>
        /// Gets a policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Policy GetPolicy(GetPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPolicyRequest(ref request, ref callSettings);
            return _callGetPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Policy> GetPolicyAsync(GetPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPolicyRequest(ref request, ref callSettings);
            return _callGetPolicy.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreatePolicy</c>.</summary>
        public override lro::OperationsClient CreatePolicyOperationsClient { get; }

        /// <summary>
        /// Creates a policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Policy, PolicyOperationMetadata> CreatePolicy(CreatePolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePolicyRequest(ref request, ref callSettings);
            return new lro::Operation<Policy, PolicyOperationMetadata>(_callCreatePolicy.Sync(request, callSettings), CreatePolicyOperationsClient);
        }

        /// <summary>
        /// Creates a policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Policy, PolicyOperationMetadata>> CreatePolicyAsync(CreatePolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePolicyRequest(ref request, ref callSettings);
            return new lro::Operation<Policy, PolicyOperationMetadata>(await _callCreatePolicy.Async(request, callSettings).ConfigureAwait(false), CreatePolicyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdatePolicy</c>.</summary>
        public override lro::OperationsClient UpdatePolicyOperationsClient { get; }

        /// <summary>
        /// Updates the specified policy.
        /// 
        /// You can update only the rules and the display name for the policy.
        /// 
        /// To update a policy, you should use a read-modify-write loop:
        /// 
        /// 1. Use [GetPolicy][google.iam.v2.Policies.GetPolicy] to read the current version of the policy.
        /// 2. Modify the policy as needed.
        /// 3. Use `UpdatePolicy` to write the updated policy.
        /// 
        /// This pattern helps prevent conflicts between concurrent updates.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Policy, PolicyOperationMetadata> UpdatePolicy(UpdatePolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePolicyRequest(ref request, ref callSettings);
            return new lro::Operation<Policy, PolicyOperationMetadata>(_callUpdatePolicy.Sync(request, callSettings), UpdatePolicyOperationsClient);
        }

        /// <summary>
        /// Updates the specified policy.
        /// 
        /// You can update only the rules and the display name for the policy.
        /// 
        /// To update a policy, you should use a read-modify-write loop:
        /// 
        /// 1. Use [GetPolicy][google.iam.v2.Policies.GetPolicy] to read the current version of the policy.
        /// 2. Modify the policy as needed.
        /// 3. Use `UpdatePolicy` to write the updated policy.
        /// 
        /// This pattern helps prevent conflicts between concurrent updates.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Policy, PolicyOperationMetadata>> UpdatePolicyAsync(UpdatePolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePolicyRequest(ref request, ref callSettings);
            return new lro::Operation<Policy, PolicyOperationMetadata>(await _callUpdatePolicy.Async(request, callSettings).ConfigureAwait(false), UpdatePolicyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeletePolicy</c>.</summary>
        public override lro::OperationsClient DeletePolicyOperationsClient { get; }

        /// <summary>
        /// Deletes a policy. This action is permanent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Policy, PolicyOperationMetadata> DeletePolicy(DeletePolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePolicyRequest(ref request, ref callSettings);
            return new lro::Operation<Policy, PolicyOperationMetadata>(_callDeletePolicy.Sync(request, callSettings), DeletePolicyOperationsClient);
        }

        /// <summary>
        /// Deletes a policy. This action is permanent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Policy, PolicyOperationMetadata>> DeletePolicyAsync(DeletePolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePolicyRequest(ref request, ref callSettings);
            return new lro::Operation<Policy, PolicyOperationMetadata>(await _callDeletePolicy.Async(request, callSettings).ConfigureAwait(false), DeletePolicyOperationsClient);
        }
    }

    public partial class ListPoliciesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPoliciesResponse : gaxgrpc::IPageResponse<Policy>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Policy> GetEnumerator() => Policies.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Policies
    {
        public partial class PoliciesClient
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
