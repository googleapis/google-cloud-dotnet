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
    /// <summary>Settings for <see cref="GlobalVmExtensionPoliciesClient"/> instances.</summary>
    public sealed partial class GlobalVmExtensionPoliciesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="GlobalVmExtensionPoliciesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="GlobalVmExtensionPoliciesSettings"/>.</returns>
        public static GlobalVmExtensionPoliciesSettings GetDefault() => new GlobalVmExtensionPoliciesSettings();

        /// <summary>
        /// Constructs a new <see cref="GlobalVmExtensionPoliciesSettings"/> object with default settings.
        /// </summary>
        public GlobalVmExtensionPoliciesSettings()
        {
        }

        private GlobalVmExtensionPoliciesSettings(GlobalVmExtensionPoliciesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            AggregatedListSettings = existing.AggregatedListSettings;
            DeleteSettings = existing.DeleteSettings;
            DeleteOperationsSettings = existing.DeleteOperationsSettings.Clone();
            GetSettings = existing.GetSettings;
            InsertSettings = existing.InsertSettings;
            InsertOperationsSettings = existing.InsertOperationsSettings.Clone();
            ListSettings = existing.ListSettings;
            UpdateSettings = existing.UpdateSettings;
            UpdateOperationsSettings = existing.UpdateOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(GlobalVmExtensionPoliciesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GlobalVmExtensionPoliciesClient.AggregatedList</c> and
        /// <c>GlobalVmExtensionPoliciesClient.AggregatedListAsync</c>.
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
        public gaxgrpc::CallSettings AggregatedListSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GlobalVmExtensionPoliciesClient.Delete</c> and <c>GlobalVmExtensionPoliciesClient.DeleteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GlobalVmExtensionPoliciesClient.Delete</c> and
        /// <c>GlobalVmExtensionPoliciesClient.DeleteAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GlobalVmExtensionPoliciesClient.Get</c> and <c>GlobalVmExtensionPoliciesClient.GetAsync</c>.
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
        /// <c>GlobalVmExtensionPoliciesClient.Insert</c> and <c>GlobalVmExtensionPoliciesClient.InsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InsertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GlobalVmExtensionPoliciesClient.Insert</c> and
        /// <c>GlobalVmExtensionPoliciesClient.InsertAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GlobalVmExtensionPoliciesClient.List</c> and <c>GlobalVmExtensionPoliciesClient.ListAsync</c>.
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
        /// <c>GlobalVmExtensionPoliciesClient.Update</c> and <c>GlobalVmExtensionPoliciesClient.UpdateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>GlobalVmExtensionPoliciesClient.Update</c> and
        /// <c>GlobalVmExtensionPoliciesClient.UpdateAsync</c>.
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
        public lro::OperationsSettings UpdateOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="GlobalVmExtensionPoliciesSettings"/> object.</returns>
        public GlobalVmExtensionPoliciesSettings Clone() => new GlobalVmExtensionPoliciesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="GlobalVmExtensionPoliciesClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class GlobalVmExtensionPoliciesClientBuilder : gaxgrpc::ClientBuilderBase<GlobalVmExtensionPoliciesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public GlobalVmExtensionPoliciesSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public GlobalVmExtensionPoliciesClientBuilder() : base(GlobalVmExtensionPoliciesClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref GlobalVmExtensionPoliciesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<GlobalVmExtensionPoliciesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override GlobalVmExtensionPoliciesClient Build()
        {
            GlobalVmExtensionPoliciesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<GlobalVmExtensionPoliciesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<GlobalVmExtensionPoliciesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private GlobalVmExtensionPoliciesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return GlobalVmExtensionPoliciesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<GlobalVmExtensionPoliciesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return GlobalVmExtensionPoliciesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => GlobalVmExtensionPoliciesClient.ChannelPool;
    }

    /// <summary>GlobalVmExtensionPolicies client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The GlobalVmExtensionPolicies API.
    /// </remarks>
    public abstract partial class GlobalVmExtensionPoliciesClient
    {
        /// <summary>
        /// The default endpoint for the GlobalVmExtensionPolicies service, which is a host of "compute.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default GlobalVmExtensionPolicies scopes.</summary>
        /// <remarks>
        /// The default GlobalVmExtensionPolicies scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(GlobalVmExtensionPolicies.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="GlobalVmExtensionPoliciesClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="GlobalVmExtensionPoliciesClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="GlobalVmExtensionPoliciesClient"/>.</returns>
        public static stt::Task<GlobalVmExtensionPoliciesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new GlobalVmExtensionPoliciesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="GlobalVmExtensionPoliciesClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="GlobalVmExtensionPoliciesClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="GlobalVmExtensionPoliciesClient"/>.</returns>
        public static GlobalVmExtensionPoliciesClient Create() => new GlobalVmExtensionPoliciesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="GlobalVmExtensionPoliciesClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="GlobalVmExtensionPoliciesSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="GlobalVmExtensionPoliciesClient"/>.</returns>
        internal static GlobalVmExtensionPoliciesClient Create(grpccore::CallInvoker callInvoker, GlobalVmExtensionPoliciesSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            GlobalVmExtensionPolicies.GlobalVmExtensionPoliciesClient grpcClient = new GlobalVmExtensionPolicies.GlobalVmExtensionPoliciesClient(callInvoker);
            return new GlobalVmExtensionPoliciesClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC GlobalVmExtensionPolicies client</summary>
        public virtual GlobalVmExtensionPolicies.GlobalVmExtensionPoliciesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of all VM Extension Policy resources
        /// available to the specified project.
        /// 
        /// To prevent failure, it's recommended that you set the
        /// `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.</returns>
        public virtual gax::PagedEnumerable<VmExtensionPolicyAggregatedListResponse, scg::KeyValuePair<string, VmExtensionPoliciesScopedList>> AggregatedList(AggregatedListGlobalVmExtensionPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of all VM Extension Policy resources
        /// available to the specified project.
        /// 
        /// To prevent failure, it's recommended that you set the
        /// `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<VmExtensionPolicyAggregatedListResponse, scg::KeyValuePair<string, VmExtensionPoliciesScopedList>> AggregatedListAsync(AggregatedListGlobalVmExtensionPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of all VM Extension Policy resources
        /// available to the specified project.
        /// 
        /// To prevent failure, it's recommended that you set the
        /// `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="project">
        /// Name of the project scoping this request.
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
        /// <returns>A pageable sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.</returns>
        public virtual gax::PagedEnumerable<VmExtensionPolicyAggregatedListResponse, scg::KeyValuePair<string, VmExtensionPoliciesScopedList>> AggregatedList(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            AggregatedListGlobalVmExtensionPoliciesRequest request = new AggregatedListGlobalVmExtensionPoliciesRequest
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
            return AggregatedList(request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of all VM Extension Policy resources
        /// available to the specified project.
        /// 
        /// To prevent failure, it's recommended that you set the
        /// `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="project">
        /// Name of the project scoping this request.
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
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<VmExtensionPolicyAggregatedListResponse, scg::KeyValuePair<string, VmExtensionPoliciesScopedList>> AggregatedListAsync(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            AggregatedListGlobalVmExtensionPoliciesRequest request = new AggregatedListGlobalVmExtensionPoliciesRequest
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
            return AggregatedListAsync(request, callSettings);
        }

        /// <summary>
        /// Purge scoped resources (zonal policies) from a global VM extension
        /// policy, and then delete the global VM extension policy. Purge of the scoped
        /// resources is a pre-condition of the global VM extension policy deletion.
        /// The deletion of the global VM extension policy happens after the purge
        /// rollout is done, so it's not a part of the LRO. It's an automatic process
        /// that triggers in the backend.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Delete(DeleteGlobalVmExtensionPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Purge scoped resources (zonal policies) from a global VM extension
        /// policy, and then delete the global VM extension policy. Purge of the scoped
        /// resources is a pre-condition of the global VM extension policy deletion.
        /// The deletion of the global VM extension policy happens after the purge
        /// rollout is done, so it's not a part of the LRO. It's an automatic process
        /// that triggers in the backend.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteGlobalVmExtensionPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Purge scoped resources (zonal policies) from a global VM extension
        /// policy, and then delete the global VM extension policy. Purge of the scoped
        /// resources is a pre-condition of the global VM extension policy deletion.
        /// The deletion of the global VM extension policy happens after the purge
        /// rollout is done, so it's not a part of the LRO. It's an automatic process
        /// that triggers in the backend.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteGlobalVmExtensionPolicyRequest request, st::CancellationToken cancellationToken) =>
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
        /// Purge scoped resources (zonal policies) from a global VM extension
        /// policy, and then delete the global VM extension policy. Purge of the scoped
        /// resources is a pre-condition of the global VM extension policy deletion.
        /// The deletion of the global VM extension policy happens after the purge
        /// rollout is done, so it's not a part of the LRO. It's an automatic process
        /// that triggers in the backend.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="globalVmExtensionPolicy">
        /// Name of the global VM extension policy to purge scoped resources for.
        /// </param>
        /// <param name="globalVmExtensionPolicyRolloutOperationRolloutInputResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Delete(string project, string globalVmExtensionPolicy, GlobalVmExtensionPolicyRolloutOperationRolloutInput globalVmExtensionPolicyRolloutOperationRolloutInputResource, gaxgrpc::CallSettings callSettings = null) =>
            Delete(new DeleteGlobalVmExtensionPolicyRequest
            {
                GlobalVmExtensionPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(globalVmExtensionPolicy, nameof(globalVmExtensionPolicy)),
                GlobalVmExtensionPolicyRolloutOperationRolloutInputResource = gax::GaxPreconditions.CheckNotNull(globalVmExtensionPolicyRolloutOperationRolloutInputResource, nameof(globalVmExtensionPolicyRolloutOperationRolloutInputResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Purge scoped resources (zonal policies) from a global VM extension
        /// policy, and then delete the global VM extension policy. Purge of the scoped
        /// resources is a pre-condition of the global VM extension policy deletion.
        /// The deletion of the global VM extension policy happens after the purge
        /// rollout is done, so it's not a part of the LRO. It's an automatic process
        /// that triggers in the backend.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="globalVmExtensionPolicy">
        /// Name of the global VM extension policy to purge scoped resources for.
        /// </param>
        /// <param name="globalVmExtensionPolicyRolloutOperationRolloutInputResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(string project, string globalVmExtensionPolicy, GlobalVmExtensionPolicyRolloutOperationRolloutInput globalVmExtensionPolicyRolloutOperationRolloutInputResource, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAsync(new DeleteGlobalVmExtensionPolicyRequest
            {
                GlobalVmExtensionPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(globalVmExtensionPolicy, nameof(globalVmExtensionPolicy)),
                GlobalVmExtensionPolicyRolloutOperationRolloutInputResource = gax::GaxPreconditions.CheckNotNull(globalVmExtensionPolicyRolloutOperationRolloutInputResource, nameof(globalVmExtensionPolicyRolloutOperationRolloutInputResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Purge scoped resources (zonal policies) from a global VM extension
        /// policy, and then delete the global VM extension policy. Purge of the scoped
        /// resources is a pre-condition of the global VM extension policy deletion.
        /// The deletion of the global VM extension policy happens after the purge
        /// rollout is done, so it's not a part of the LRO. It's an automatic process
        /// that triggers in the backend.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="globalVmExtensionPolicy">
        /// Name of the global VM extension policy to purge scoped resources for.
        /// </param>
        /// <param name="globalVmExtensionPolicyRolloutOperationRolloutInputResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(string project, string globalVmExtensionPolicy, GlobalVmExtensionPolicyRolloutOperationRolloutInput globalVmExtensionPolicyRolloutOperationRolloutInputResource, st::CancellationToken cancellationToken) =>
            DeleteAsync(project, globalVmExtensionPolicy, globalVmExtensionPolicyRolloutOperationRolloutInputResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a global VM extension policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GlobalVmExtensionPolicy Get(GetGlobalVmExtensionPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a global VM extension policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlobalVmExtensionPolicy> GetAsync(GetGlobalVmExtensionPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a global VM extension policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlobalVmExtensionPolicy> GetAsync(GetGlobalVmExtensionPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a global VM extension policy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="globalVmExtensionPolicy">
        /// Name of the GlobalVmExtensionPolicy resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GlobalVmExtensionPolicy Get(string project, string globalVmExtensionPolicy, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetGlobalVmExtensionPolicyRequest
            {
                GlobalVmExtensionPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(globalVmExtensionPolicy, nameof(globalVmExtensionPolicy)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Gets details of a global VM extension policy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="globalVmExtensionPolicy">
        /// Name of the GlobalVmExtensionPolicy resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlobalVmExtensionPolicy> GetAsync(string project, string globalVmExtensionPolicy, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetGlobalVmExtensionPolicyRequest
            {
                GlobalVmExtensionPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(globalVmExtensionPolicy, nameof(globalVmExtensionPolicy)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Gets details of a global VM extension policy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="globalVmExtensionPolicy">
        /// Name of the GlobalVmExtensionPolicy resource to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GlobalVmExtensionPolicy> GetAsync(string project, string globalVmExtensionPolicy, st::CancellationToken cancellationToken) =>
            GetAsync(project, globalVmExtensionPolicy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new project level GlobalVmExtensionPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Insert(InsertGlobalVmExtensionPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new project level GlobalVmExtensionPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertGlobalVmExtensionPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new project level GlobalVmExtensionPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertGlobalVmExtensionPolicyRequest request, st::CancellationToken cancellationToken) =>
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
        /// Creates a new project level GlobalVmExtensionPolicy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="globalVmExtensionPolicyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Insert(string project, GlobalVmExtensionPolicy globalVmExtensionPolicyResource, gaxgrpc::CallSettings callSettings = null) =>
            Insert(new InsertGlobalVmExtensionPolicyRequest
            {
                GlobalVmExtensionPolicyResource = gax::GaxPreconditions.CheckNotNull(globalVmExtensionPolicyResource, nameof(globalVmExtensionPolicyResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Creates a new project level GlobalVmExtensionPolicy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="globalVmExtensionPolicyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(string project, GlobalVmExtensionPolicy globalVmExtensionPolicyResource, gaxgrpc::CallSettings callSettings = null) =>
            InsertAsync(new InsertGlobalVmExtensionPolicyRequest
            {
                GlobalVmExtensionPolicyResource = gax::GaxPreconditions.CheckNotNull(globalVmExtensionPolicyResource, nameof(globalVmExtensionPolicyResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Creates a new project level GlobalVmExtensionPolicy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="globalVmExtensionPolicyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(string project, GlobalVmExtensionPolicy globalVmExtensionPolicyResource, st::CancellationToken cancellationToken) =>
            InsertAsync(project, globalVmExtensionPolicyResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists global VM extension policies.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GlobalVmExtensionPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<GlobalVmExtensionPolicyList, GlobalVmExtensionPolicy> List(ListGlobalVmExtensionPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists global VM extension policies.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GlobalVmExtensionPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<GlobalVmExtensionPolicyList, GlobalVmExtensionPolicy> ListAsync(ListGlobalVmExtensionPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists global VM extension policies.
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
        /// <returns>A pageable sequence of <see cref="GlobalVmExtensionPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<GlobalVmExtensionPolicyList, GlobalVmExtensionPolicy> List(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGlobalVmExtensionPoliciesRequest request = new ListGlobalVmExtensionPoliciesRequest
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
        /// Lists global VM extension policies.
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
        /// <returns>A pageable asynchronous sequence of <see cref="GlobalVmExtensionPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<GlobalVmExtensionPolicyList, GlobalVmExtensionPolicy> ListAsync(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGlobalVmExtensionPoliciesRequest request = new ListGlobalVmExtensionPoliciesRequest
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
        /// Updates a global VM extension policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Update(UpdateGlobalVmExtensionPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a global VM extension policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateAsync(UpdateGlobalVmExtensionPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a global VM extension policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateAsync(UpdateGlobalVmExtensionPolicyRequest request, st::CancellationToken cancellationToken) =>
            UpdateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>Update</c>.</summary>
        public virtual lro::OperationsClient UpdateOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Update</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceUpdate(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Update</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceUpdateAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateOperationsClient, callSettings);

        /// <summary>
        /// Updates a global VM extension policy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="globalVmExtensionPolicy">
        /// Name of the global VM extension policy to update.
        /// </param>
        /// <param name="globalVmExtensionPolicyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Update(string project, string globalVmExtensionPolicy, GlobalVmExtensionPolicy globalVmExtensionPolicyResource, gaxgrpc::CallSettings callSettings = null) =>
            Update(new UpdateGlobalVmExtensionPolicyRequest
            {
                GlobalVmExtensionPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(globalVmExtensionPolicy, nameof(globalVmExtensionPolicy)),
                GlobalVmExtensionPolicyResource = gax::GaxPreconditions.CheckNotNull(globalVmExtensionPolicyResource, nameof(globalVmExtensionPolicyResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Updates a global VM extension policy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="globalVmExtensionPolicy">
        /// Name of the global VM extension policy to update.
        /// </param>
        /// <param name="globalVmExtensionPolicyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateAsync(string project, string globalVmExtensionPolicy, GlobalVmExtensionPolicy globalVmExtensionPolicyResource, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAsync(new UpdateGlobalVmExtensionPolicyRequest
            {
                GlobalVmExtensionPolicy = gax::GaxPreconditions.CheckNotNullOrEmpty(globalVmExtensionPolicy, nameof(globalVmExtensionPolicy)),
                GlobalVmExtensionPolicyResource = gax::GaxPreconditions.CheckNotNull(globalVmExtensionPolicyResource, nameof(globalVmExtensionPolicyResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Updates a global VM extension policy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="globalVmExtensionPolicy">
        /// Name of the global VM extension policy to update.
        /// </param>
        /// <param name="globalVmExtensionPolicyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> UpdateAsync(string project, string globalVmExtensionPolicy, GlobalVmExtensionPolicy globalVmExtensionPolicyResource, st::CancellationToken cancellationToken) =>
            UpdateAsync(project, globalVmExtensionPolicy, globalVmExtensionPolicyResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>GlobalVmExtensionPolicies client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The GlobalVmExtensionPolicies API.
    /// </remarks>
    public sealed partial class GlobalVmExtensionPoliciesClientImpl : GlobalVmExtensionPoliciesClient
    {
        private readonly gaxgrpc::ApiCall<AggregatedListGlobalVmExtensionPoliciesRequest, VmExtensionPolicyAggregatedListResponse> _callAggregatedList;

        private readonly gaxgrpc::ApiCall<DeleteGlobalVmExtensionPolicyRequest, Operation> _callDelete;

        private readonly gaxgrpc::ApiCall<GetGlobalVmExtensionPolicyRequest, GlobalVmExtensionPolicy> _callGet;

        private readonly gaxgrpc::ApiCall<InsertGlobalVmExtensionPolicyRequest, Operation> _callInsert;

        private readonly gaxgrpc::ApiCall<ListGlobalVmExtensionPoliciesRequest, GlobalVmExtensionPolicyList> _callList;

        private readonly gaxgrpc::ApiCall<UpdateGlobalVmExtensionPolicyRequest, Operation> _callUpdate;

        /// <summary>
        /// Constructs a client wrapper for the GlobalVmExtensionPolicies service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="GlobalVmExtensionPoliciesSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public GlobalVmExtensionPoliciesClientImpl(GlobalVmExtensionPolicies.GlobalVmExtensionPoliciesClient grpcClient, GlobalVmExtensionPoliciesSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            GlobalVmExtensionPoliciesSettings effectiveSettings = settings ?? GlobalVmExtensionPoliciesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            DeleteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.DeleteOperationsSettings, logger);
            InsertOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.InsertOperationsSettings, logger);
            UpdateOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.UpdateOperationsSettings, logger);
            _callAggregatedList = clientHelper.BuildApiCall<AggregatedListGlobalVmExtensionPoliciesRequest, VmExtensionPolicyAggregatedListResponse>("AggregatedList", grpcClient.AggregatedListAsync, grpcClient.AggregatedList, effectiveSettings.AggregatedListSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callAggregatedList);
            Modify_AggregatedListApiCall(ref _callAggregatedList);
            _callDelete = clientHelper.BuildApiCall<DeleteGlobalVmExtensionPolicyRequest, Operation>("Delete", grpcClient.DeleteAsync, grpcClient.Delete, effectiveSettings.DeleteSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("global_vm_extension_policy", request => request.GlobalVmExtensionPolicy);
            Modify_ApiCall(ref _callDelete);
            Modify_DeleteApiCall(ref _callDelete);
            _callGet = clientHelper.BuildApiCall<GetGlobalVmExtensionPolicyRequest, GlobalVmExtensionPolicy>("Get", grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("global_vm_extension_policy", request => request.GlobalVmExtensionPolicy);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callInsert = clientHelper.BuildApiCall<InsertGlobalVmExtensionPolicyRequest, Operation>("Insert", grpcClient.InsertAsync, grpcClient.Insert, effectiveSettings.InsertSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callInsert);
            Modify_InsertApiCall(ref _callInsert);
            _callList = clientHelper.BuildApiCall<ListGlobalVmExtensionPoliciesRequest, GlobalVmExtensionPolicyList>("List", grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            _callUpdate = clientHelper.BuildApiCall<UpdateGlobalVmExtensionPolicyRequest, Operation>("Update", grpcClient.UpdateAsync, grpcClient.Update, effectiveSettings.UpdateSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("global_vm_extension_policy", request => request.GlobalVmExtensionPolicy);
            Modify_ApiCall(ref _callUpdate);
            Modify_UpdateApiCall(ref _callUpdate);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_AggregatedListApiCall(ref gaxgrpc::ApiCall<AggregatedListGlobalVmExtensionPoliciesRequest, VmExtensionPolicyAggregatedListResponse> call);

        partial void Modify_DeleteApiCall(ref gaxgrpc::ApiCall<DeleteGlobalVmExtensionPolicyRequest, Operation> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetGlobalVmExtensionPolicyRequest, GlobalVmExtensionPolicy> call);

        partial void Modify_InsertApiCall(ref gaxgrpc::ApiCall<InsertGlobalVmExtensionPolicyRequest, Operation> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListGlobalVmExtensionPoliciesRequest, GlobalVmExtensionPolicyList> call);

        partial void Modify_UpdateApiCall(ref gaxgrpc::ApiCall<UpdateGlobalVmExtensionPolicyRequest, Operation> call);

        partial void OnConstruction(GlobalVmExtensionPolicies.GlobalVmExtensionPoliciesClient grpcClient, GlobalVmExtensionPoliciesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC GlobalVmExtensionPolicies client</summary>
        public override GlobalVmExtensionPolicies.GlobalVmExtensionPoliciesClient GrpcClient { get; }

        partial void Modify_AggregatedListGlobalVmExtensionPoliciesRequest(ref AggregatedListGlobalVmExtensionPoliciesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteGlobalVmExtensionPolicyRequest(ref DeleteGlobalVmExtensionPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetGlobalVmExtensionPolicyRequest(ref GetGlobalVmExtensionPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InsertGlobalVmExtensionPolicyRequest(ref InsertGlobalVmExtensionPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListGlobalVmExtensionPoliciesRequest(ref ListGlobalVmExtensionPoliciesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateGlobalVmExtensionPolicyRequest(ref UpdateGlobalVmExtensionPolicyRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves the list of all VM Extension Policy resources
        /// available to the specified project.
        /// 
        /// To prevent failure, it's recommended that you set the
        /// `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.</returns>
        public override gax::PagedEnumerable<VmExtensionPolicyAggregatedListResponse, scg::KeyValuePair<string, VmExtensionPoliciesScopedList>> AggregatedList(AggregatedListGlobalVmExtensionPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregatedListGlobalVmExtensionPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<AggregatedListGlobalVmExtensionPoliciesRequest, VmExtensionPolicyAggregatedListResponse, scg::KeyValuePair<string, VmExtensionPoliciesScopedList>>(_callAggregatedList, request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of all VM Extension Policy resources
        /// available to the specified project.
        /// 
        /// To prevent failure, it's recommended that you set the
        /// `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<VmExtensionPolicyAggregatedListResponse, scg::KeyValuePair<string, VmExtensionPoliciesScopedList>> AggregatedListAsync(AggregatedListGlobalVmExtensionPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregatedListGlobalVmExtensionPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<AggregatedListGlobalVmExtensionPoliciesRequest, VmExtensionPolicyAggregatedListResponse, scg::KeyValuePair<string, VmExtensionPoliciesScopedList>>(_callAggregatedList, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>Delete</c>.</summary>
        public override lro::OperationsClient DeleteOperationsClient { get; }

        /// <summary>
        /// Purge scoped resources (zonal policies) from a global VM extension
        /// policy, and then delete the global VM extension policy. Purge of the scoped
        /// resources is a pre-condition of the global VM extension policy deletion.
        /// The deletion of the global VM extension policy happens after the purge
        /// rollout is done, so it's not a part of the LRO. It's an automatic process
        /// that triggers in the backend.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Delete(DeleteGlobalVmExtensionPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGlobalVmExtensionPolicyRequest(ref request, ref callSettings);
            Operation response = _callDelete.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteOperationsClient);
        }

        /// <summary>
        /// Purge scoped resources (zonal policies) from a global VM extension
        /// policy, and then delete the global VM extension policy. Purge of the scoped
        /// resources is a pre-condition of the global VM extension policy deletion.
        /// The deletion of the global VM extension policy happens after the purge
        /// rollout is done, so it's not a part of the LRO. It's an automatic process
        /// that triggers in the backend.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteGlobalVmExtensionPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGlobalVmExtensionPolicyRequest(ref request, ref callSettings);
            Operation response = await _callDelete.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteOperationsClient);
        }

        /// <summary>
        /// Gets details of a global VM extension policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GlobalVmExtensionPolicy Get(GetGlobalVmExtensionPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGlobalVmExtensionPolicyRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a global VM extension policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GlobalVmExtensionPolicy> GetAsync(GetGlobalVmExtensionPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGlobalVmExtensionPolicyRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>Insert</c>.</summary>
        public override lro::OperationsClient InsertOperationsClient { get; }

        /// <summary>
        /// Creates a new project level GlobalVmExtensionPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Insert(InsertGlobalVmExtensionPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertGlobalVmExtensionPolicyRequest(ref request, ref callSettings);
            Operation response = _callInsert.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), InsertOperationsClient);
        }

        /// <summary>
        /// Creates a new project level GlobalVmExtensionPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertGlobalVmExtensionPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertGlobalVmExtensionPolicyRequest(ref request, ref callSettings);
            Operation response = await _callInsert.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), InsertOperationsClient);
        }

        /// <summary>
        /// Lists global VM extension policies.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GlobalVmExtensionPolicy"/> resources.</returns>
        public override gax::PagedEnumerable<GlobalVmExtensionPolicyList, GlobalVmExtensionPolicy> List(ListGlobalVmExtensionPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGlobalVmExtensionPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListGlobalVmExtensionPoliciesRequest, GlobalVmExtensionPolicyList, GlobalVmExtensionPolicy>(_callList, request, callSettings);
        }

        /// <summary>
        /// Lists global VM extension policies.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GlobalVmExtensionPolicy"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<GlobalVmExtensionPolicyList, GlobalVmExtensionPolicy> ListAsync(ListGlobalVmExtensionPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGlobalVmExtensionPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListGlobalVmExtensionPoliciesRequest, GlobalVmExtensionPolicyList, GlobalVmExtensionPolicy>(_callList, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>Update</c>.</summary>
        public override lro::OperationsClient UpdateOperationsClient { get; }

        /// <summary>
        /// Updates a global VM extension policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Update(UpdateGlobalVmExtensionPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGlobalVmExtensionPolicyRequest(ref request, ref callSettings);
            Operation response = _callUpdate.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), UpdateOperationsClient);
        }

        /// <summary>
        /// Updates a global VM extension policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> UpdateAsync(UpdateGlobalVmExtensionPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGlobalVmExtensionPolicyRequest(ref request, ref callSettings);
            Operation response = await _callUpdate.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), UpdateOperationsClient);
        }
    }

    public partial class AggregatedListGlobalVmExtensionPoliciesRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class ListGlobalVmExtensionPoliciesRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class VmExtensionPolicyAggregatedListResponse : gaxgrpc::IPageResponse<scg::KeyValuePair<string, VmExtensionPoliciesScopedList>>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<scg::KeyValuePair<string, VmExtensionPoliciesScopedList>> GetEnumerator() =>
            Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class GlobalVmExtensionPolicyList : gaxgrpc::IPageResponse<GlobalVmExtensionPolicy>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<GlobalVmExtensionPolicy> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class GlobalVmExtensionPolicies
    {
        public partial class GlobalVmExtensionPoliciesClient
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
