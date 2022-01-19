// Copyright 2022 Google LLC
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
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
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

namespace Google.Cloud.AccessApproval.V1
{
    /// <summary>Settings for <see cref="AccessApprovalClient"/> instances.</summary>
    public sealed partial class AccessApprovalSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AccessApprovalSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AccessApprovalSettings"/>.</returns>
        public static AccessApprovalSettings GetDefault() => new AccessApprovalSettings();

        /// <summary>Constructs a new <see cref="AccessApprovalSettings"/> object with default settings.</summary>
        public AccessApprovalSettings()
        {
        }

        private AccessApprovalSettings(AccessApprovalSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListApprovalRequestsSettings = existing.ListApprovalRequestsSettings;
            GetApprovalRequestSettings = existing.GetApprovalRequestSettings;
            ApproveApprovalRequestSettings = existing.ApproveApprovalRequestSettings;
            DismissApprovalRequestSettings = existing.DismissApprovalRequestSettings;
            GetAccessApprovalSettingsSettings = existing.GetAccessApprovalSettingsSettings;
            UpdateAccessApprovalSettingsSettings = existing.UpdateAccessApprovalSettingsSettings;
            DeleteAccessApprovalSettingsSettings = existing.DeleteAccessApprovalSettingsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AccessApprovalSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccessApprovalClient.ListApprovalRequests</c> and <c>AccessApprovalClient.ListApprovalRequestsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListApprovalRequestsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccessApprovalClient.GetApprovalRequest</c> and <c>AccessApprovalClient.GetApprovalRequestAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetApprovalRequestSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccessApprovalClient.ApproveApprovalRequest</c> and <c>AccessApprovalClient.ApproveApprovalRequestAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ApproveApprovalRequestSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccessApprovalClient.DismissApprovalRequest</c> and <c>AccessApprovalClient.DismissApprovalRequestAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DismissApprovalRequestSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccessApprovalClient.GetAccessApprovalSettings</c> and
        /// <c>AccessApprovalClient.GetAccessApprovalSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAccessApprovalSettingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccessApprovalClient.UpdateAccessApprovalSettings</c> and
        /// <c>AccessApprovalClient.UpdateAccessApprovalSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAccessApprovalSettingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccessApprovalClient.DeleteAccessApprovalSettings</c> and
        /// <c>AccessApprovalClient.DeleteAccessApprovalSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAccessApprovalSettingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AccessApprovalSettings"/> object.</returns>
        public AccessApprovalSettings Clone() => new AccessApprovalSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AccessApprovalClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class AccessApprovalClientBuilder : gaxgrpc::ClientBuilderBase<AccessApprovalClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AccessApprovalSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AccessApprovalClientBuilder()
        {
            UseJwtAccessWithScopes = AccessApprovalClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref AccessApprovalClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AccessApprovalClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AccessApprovalClient Build()
        {
            AccessApprovalClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AccessApprovalClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AccessApprovalClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AccessApprovalClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AccessApprovalClient.Create(callInvoker, Settings);
        }

        private async stt::Task<AccessApprovalClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AccessApprovalClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => AccessApprovalClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => AccessApprovalClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AccessApprovalClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>AccessApproval client wrapper, for convenient use.</summary>
    /// <remarks>
    /// This API allows a customer to manage accesses to cloud resources by
    /// Google personnel. It defines the following resource model:
    /// 
    /// - The API has a collection of
    /// [ApprovalRequest][google.cloud.accessapproval.v1.ApprovalRequest]
    /// resources, named `approvalRequests/{approval_request_id}`
    /// - The API has top-level settings per Project/Folder/Organization, named
    /// `accessApprovalSettings`
    /// 
    /// The service also periodically emails a list of recipients, defined at the
    /// Project/Folder/Organization level in the accessApprovalSettings, when there
    /// is a pending ApprovalRequest for them to act on. The ApprovalRequests can
    /// also optionally be published to a Cloud Pub/Sub topic owned by the customer
    /// (for Beta, the Pub/Sub setup is managed manually).
    /// 
    /// ApprovalRequests can be approved or dismissed. Google personel can only
    /// access the indicated resource or resources if the request is approved
    /// (subject to some exclusions:
    /// https://cloud.google.com/access-approval/docs/overview#exclusions).
    /// 
    /// Note: Using Access Approval functionality will mean that Google may not be
    /// able to meet the SLAs for your chosen products, as any support response times
    /// may be dramatically increased. As such the SLAs do not apply to any service
    /// disruption to the extent impacted by Customer's use of Access Approval. Do
    /// not enable Access Approval for projects where you may require high service
    /// availability and rapid response by Google Cloud Support.
    /// 
    /// After a request is approved or dismissed, no further action may be taken on
    /// it. Requests with the requested_expiration in the past or with no activity
    /// for 14 days are considered dismissed. When an approval expires, the request
    /// is considered dismissed.
    /// 
    /// If a request is not approved or dismissed, we call it pending.
    /// </remarks>
    public abstract partial class AccessApprovalClient
    {
        /// <summary>
        /// The default endpoint for the AccessApproval service, which is a host of "accessapproval.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "accessapproval.googleapis.com:443";

        /// <summary>The default AccessApproval scopes.</summary>
        /// <remarks>
        /// The default AccessApproval scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes, UseJwtAccessWithScopes);

        internal static bool UseJwtAccessWithScopes
        {
            get
            {
                bool useJwtAccessWithScopes = true;
                MaybeUseJwtAccessWithScopes(ref useJwtAccessWithScopes);
                return useJwtAccessWithScopes;
            }
        }

        static partial void MaybeUseJwtAccessWithScopes(ref bool useJwtAccessWithScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="AccessApprovalClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AccessApprovalClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AccessApprovalClient"/>.</returns>
        public static stt::Task<AccessApprovalClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AccessApprovalClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AccessApprovalClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AccessApprovalClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AccessApprovalClient"/>.</returns>
        public static AccessApprovalClient Create() => new AccessApprovalClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AccessApprovalClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AccessApprovalSettings"/>.</param>
        /// <returns>The created <see cref="AccessApprovalClient"/>.</returns>
        internal static AccessApprovalClient Create(grpccore::CallInvoker callInvoker, AccessApprovalSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AccessApproval.AccessApprovalClient grpcClient = new AccessApproval.AccessApprovalClient(callInvoker);
            return new AccessApprovalClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC AccessApproval client</summary>
        public virtual AccessApproval.AccessApprovalClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists approval requests associated with a project, folder, or organization.
        /// Approval requests can be filtered by state (pending, active, dismissed).
        /// The order is reverse chronological.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ApprovalRequest"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApprovalRequestsResponse, ApprovalRequest> ListApprovalRequests(ListApprovalRequestsMessage request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists approval requests associated with a project, folder, or organization.
        /// Approval requests can be filtered by state (pending, active, dismissed).
        /// The order is reverse chronological.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ApprovalRequest"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApprovalRequestsResponse, ApprovalRequest> ListApprovalRequestsAsync(ListApprovalRequestsMessage request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists approval requests associated with a project, folder, or organization.
        /// Approval requests can be filtered by state (pending, active, dismissed).
        /// The order is reverse chronological.
        /// </summary>
        /// <param name="parent">
        /// The parent resource. This may be "projects/{project_id}",
        /// "folders/{folder_id}", or "organizations/{organization_id}".
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
        /// <returns>A pageable sequence of <see cref="ApprovalRequest"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApprovalRequestsResponse, ApprovalRequest> ListApprovalRequests(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListApprovalRequests(new ListApprovalRequestsMessage
            {
                Parent = parent ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists approval requests associated with a project, folder, or organization.
        /// Approval requests can be filtered by state (pending, active, dismissed).
        /// The order is reverse chronological.
        /// </summary>
        /// <param name="parent">
        /// The parent resource. This may be "projects/{project_id}",
        /// "folders/{folder_id}", or "organizations/{organization_id}".
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
        /// <returns>A pageable asynchronous sequence of <see cref="ApprovalRequest"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApprovalRequestsResponse, ApprovalRequest> ListApprovalRequestsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListApprovalRequestsAsync(new ListApprovalRequestsMessage
            {
                Parent = parent ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets an approval request. Returns NOT_FOUND if the request does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApprovalRequest GetApprovalRequest(GetApprovalRequestMessage request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an approval request. Returns NOT_FOUND if the request does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApprovalRequest> GetApprovalRequestAsync(GetApprovalRequestMessage request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an approval request. Returns NOT_FOUND if the request does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApprovalRequest> GetApprovalRequestAsync(GetApprovalRequestMessage request, st::CancellationToken cancellationToken) =>
            GetApprovalRequestAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an approval request. Returns NOT_FOUND if the request does not exist.
        /// </summary>
        /// <param name="name">
        /// Name of the approval request to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApprovalRequest GetApprovalRequest(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApprovalRequest(new GetApprovalRequestMessage { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Gets an approval request. Returns NOT_FOUND if the request does not exist.
        /// </summary>
        /// <param name="name">
        /// Name of the approval request to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApprovalRequest> GetApprovalRequestAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApprovalRequestAsync(new GetApprovalRequestMessage { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Gets an approval request. Returns NOT_FOUND if the request does not exist.
        /// </summary>
        /// <param name="name">
        /// Name of the approval request to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApprovalRequest> GetApprovalRequestAsync(string name, st::CancellationToken cancellationToken) =>
            GetApprovalRequestAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Approves a request and returns the updated ApprovalRequest.
        /// 
        /// Returns NOT_FOUND if the request does not exist. Returns
        /// FAILED_PRECONDITION if the request exists but is not in a pending state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApprovalRequest ApproveApprovalRequest(ApproveApprovalRequestMessage request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Approves a request and returns the updated ApprovalRequest.
        /// 
        /// Returns NOT_FOUND if the request does not exist. Returns
        /// FAILED_PRECONDITION if the request exists but is not in a pending state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApprovalRequest> ApproveApprovalRequestAsync(ApproveApprovalRequestMessage request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Approves a request and returns the updated ApprovalRequest.
        /// 
        /// Returns NOT_FOUND if the request does not exist. Returns
        /// FAILED_PRECONDITION if the request exists but is not in a pending state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApprovalRequest> ApproveApprovalRequestAsync(ApproveApprovalRequestMessage request, st::CancellationToken cancellationToken) =>
            ApproveApprovalRequestAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Dismisses a request. Returns the updated ApprovalRequest.
        /// 
        /// NOTE: This does not deny access to the resource if another request has been
        /// made and approved. It is equivalent in effect to ignoring the request
        /// altogether.
        /// 
        /// Returns NOT_FOUND if the request does not exist.
        /// 
        /// Returns FAILED_PRECONDITION if the request exists but is not in a pending
        /// state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApprovalRequest DismissApprovalRequest(DismissApprovalRequestMessage request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Dismisses a request. Returns the updated ApprovalRequest.
        /// 
        /// NOTE: This does not deny access to the resource if another request has been
        /// made and approved. It is equivalent in effect to ignoring the request
        /// altogether.
        /// 
        /// Returns NOT_FOUND if the request does not exist.
        /// 
        /// Returns FAILED_PRECONDITION if the request exists but is not in a pending
        /// state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApprovalRequest> DismissApprovalRequestAsync(DismissApprovalRequestMessage request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Dismisses a request. Returns the updated ApprovalRequest.
        /// 
        /// NOTE: This does not deny access to the resource if another request has been
        /// made and approved. It is equivalent in effect to ignoring the request
        /// altogether.
        /// 
        /// Returns NOT_FOUND if the request does not exist.
        /// 
        /// Returns FAILED_PRECONDITION if the request exists but is not in a pending
        /// state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApprovalRequest> DismissApprovalRequestAsync(DismissApprovalRequestMessage request, st::CancellationToken cancellationToken) =>
            DismissApprovalRequestAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the settings associated with a project, folder, or organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccessApprovalSettings GetAccessApprovalSettings(GetAccessApprovalSettingsMessage request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the settings associated with a project, folder, or organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccessApprovalSettings> GetAccessApprovalSettingsAsync(GetAccessApprovalSettingsMessage request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the settings associated with a project, folder, or organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccessApprovalSettings> GetAccessApprovalSettingsAsync(GetAccessApprovalSettingsMessage request, st::CancellationToken cancellationToken) =>
            GetAccessApprovalSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the settings associated with a project, folder, or organization.
        /// </summary>
        /// <param name="name">
        /// Name of the AccessApprovalSettings to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccessApprovalSettings GetAccessApprovalSettings(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAccessApprovalSettings(new GetAccessApprovalSettingsMessage { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Gets the settings associated with a project, folder, or organization.
        /// </summary>
        /// <param name="name">
        /// Name of the AccessApprovalSettings to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccessApprovalSettings> GetAccessApprovalSettingsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAccessApprovalSettingsAsync(new GetAccessApprovalSettingsMessage { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Gets the settings associated with a project, folder, or organization.
        /// </summary>
        /// <param name="name">
        /// Name of the AccessApprovalSettings to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccessApprovalSettings> GetAccessApprovalSettingsAsync(string name, st::CancellationToken cancellationToken) =>
            GetAccessApprovalSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the settings associated with a project, folder, or organization.
        /// Settings to update are determined by the value of field_mask.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccessApprovalSettings UpdateAccessApprovalSettings(UpdateAccessApprovalSettingsMessage request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the settings associated with a project, folder, or organization.
        /// Settings to update are determined by the value of field_mask.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccessApprovalSettings> UpdateAccessApprovalSettingsAsync(UpdateAccessApprovalSettingsMessage request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the settings associated with a project, folder, or organization.
        /// Settings to update are determined by the value of field_mask.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccessApprovalSettings> UpdateAccessApprovalSettingsAsync(UpdateAccessApprovalSettingsMessage request, st::CancellationToken cancellationToken) =>
            UpdateAccessApprovalSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the settings associated with a project, folder, or organization.
        /// Settings to update are determined by the value of field_mask.
        /// </summary>
        /// <param name="settings">
        /// The new AccessApprovalSettings.
        /// </param>
        /// <param name="updateMask">
        /// The update mask applies to the settings. Only the top level fields of
        /// AccessApprovalSettings (notification_emails &amp;amp; enrolled_services) are
        /// supported. For each field, if it is included, the currently stored value
        /// will be entirely overwritten with the value of the field passed in this
        /// request.
        /// 
        /// For the `FieldMask` definition, see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
        /// If this field is left unset, only the notification_emails field will be
        /// updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccessApprovalSettings UpdateAccessApprovalSettings(AccessApprovalSettings settings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAccessApprovalSettings(new UpdateAccessApprovalSettingsMessage
            {
                Settings = settings,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the settings associated with a project, folder, or organization.
        /// Settings to update are determined by the value of field_mask.
        /// </summary>
        /// <param name="settings">
        /// The new AccessApprovalSettings.
        /// </param>
        /// <param name="updateMask">
        /// The update mask applies to the settings. Only the top level fields of
        /// AccessApprovalSettings (notification_emails &amp;amp; enrolled_services) are
        /// supported. For each field, if it is included, the currently stored value
        /// will be entirely overwritten with the value of the field passed in this
        /// request.
        /// 
        /// For the `FieldMask` definition, see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
        /// If this field is left unset, only the notification_emails field will be
        /// updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccessApprovalSettings> UpdateAccessApprovalSettingsAsync(AccessApprovalSettings settings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAccessApprovalSettingsAsync(new UpdateAccessApprovalSettingsMessage
            {
                Settings = settings,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the settings associated with a project, folder, or organization.
        /// Settings to update are determined by the value of field_mask.
        /// </summary>
        /// <param name="settings">
        /// The new AccessApprovalSettings.
        /// </param>
        /// <param name="updateMask">
        /// The update mask applies to the settings. Only the top level fields of
        /// AccessApprovalSettings (notification_emails &amp;amp; enrolled_services) are
        /// supported. For each field, if it is included, the currently stored value
        /// will be entirely overwritten with the value of the field passed in this
        /// request.
        /// 
        /// For the `FieldMask` definition, see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
        /// If this field is left unset, only the notification_emails field will be
        /// updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccessApprovalSettings> UpdateAccessApprovalSettingsAsync(AccessApprovalSettings settings, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAccessApprovalSettingsAsync(settings, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the settings associated with a project, folder, or organization.
        /// This will have the effect of disabling Access Approval for the project,
        /// folder, or organization, but only if all ancestors also have Access
        /// Approval disabled. If Access Approval is enabled at a higher level of the
        /// hierarchy, then Access Approval will still be enabled at this level as
        /// the settings are inherited.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAccessApprovalSettings(DeleteAccessApprovalSettingsMessage request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the settings associated with a project, folder, or organization.
        /// This will have the effect of disabling Access Approval for the project,
        /// folder, or organization, but only if all ancestors also have Access
        /// Approval disabled. If Access Approval is enabled at a higher level of the
        /// hierarchy, then Access Approval will still be enabled at this level as
        /// the settings are inherited.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAccessApprovalSettingsAsync(DeleteAccessApprovalSettingsMessage request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the settings associated with a project, folder, or organization.
        /// This will have the effect of disabling Access Approval for the project,
        /// folder, or organization, but only if all ancestors also have Access
        /// Approval disabled. If Access Approval is enabled at a higher level of the
        /// hierarchy, then Access Approval will still be enabled at this level as
        /// the settings are inherited.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAccessApprovalSettingsAsync(DeleteAccessApprovalSettingsMessage request, st::CancellationToken cancellationToken) =>
            DeleteAccessApprovalSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the settings associated with a project, folder, or organization.
        /// This will have the effect of disabling Access Approval for the project,
        /// folder, or organization, but only if all ancestors also have Access
        /// Approval disabled. If Access Approval is enabled at a higher level of the
        /// hierarchy, then Access Approval will still be enabled at this level as
        /// the settings are inherited.
        /// </summary>
        /// <param name="name">
        /// Name of the AccessApprovalSettings to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAccessApprovalSettings(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAccessApprovalSettings(new DeleteAccessApprovalSettingsMessage { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Deletes the settings associated with a project, folder, or organization.
        /// This will have the effect of disabling Access Approval for the project,
        /// folder, or organization, but only if all ancestors also have Access
        /// Approval disabled. If Access Approval is enabled at a higher level of the
        /// hierarchy, then Access Approval will still be enabled at this level as
        /// the settings are inherited.
        /// </summary>
        /// <param name="name">
        /// Name of the AccessApprovalSettings to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAccessApprovalSettingsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAccessApprovalSettingsAsync(new DeleteAccessApprovalSettingsMessage { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Deletes the settings associated with a project, folder, or organization.
        /// This will have the effect of disabling Access Approval for the project,
        /// folder, or organization, but only if all ancestors also have Access
        /// Approval disabled. If Access Approval is enabled at a higher level of the
        /// hierarchy, then Access Approval will still be enabled at this level as
        /// the settings are inherited.
        /// </summary>
        /// <param name="name">
        /// Name of the AccessApprovalSettings to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAccessApprovalSettingsAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAccessApprovalSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AccessApproval client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// This API allows a customer to manage accesses to cloud resources by
    /// Google personnel. It defines the following resource model:
    /// 
    /// - The API has a collection of
    /// [ApprovalRequest][google.cloud.accessapproval.v1.ApprovalRequest]
    /// resources, named `approvalRequests/{approval_request_id}`
    /// - The API has top-level settings per Project/Folder/Organization, named
    /// `accessApprovalSettings`
    /// 
    /// The service also periodically emails a list of recipients, defined at the
    /// Project/Folder/Organization level in the accessApprovalSettings, when there
    /// is a pending ApprovalRequest for them to act on. The ApprovalRequests can
    /// also optionally be published to a Cloud Pub/Sub topic owned by the customer
    /// (for Beta, the Pub/Sub setup is managed manually).
    /// 
    /// ApprovalRequests can be approved or dismissed. Google personel can only
    /// access the indicated resource or resources if the request is approved
    /// (subject to some exclusions:
    /// https://cloud.google.com/access-approval/docs/overview#exclusions).
    /// 
    /// Note: Using Access Approval functionality will mean that Google may not be
    /// able to meet the SLAs for your chosen products, as any support response times
    /// may be dramatically increased. As such the SLAs do not apply to any service
    /// disruption to the extent impacted by Customer's use of Access Approval. Do
    /// not enable Access Approval for projects where you may require high service
    /// availability and rapid response by Google Cloud Support.
    /// 
    /// After a request is approved or dismissed, no further action may be taken on
    /// it. Requests with the requested_expiration in the past or with no activity
    /// for 14 days are considered dismissed. When an approval expires, the request
    /// is considered dismissed.
    /// 
    /// If a request is not approved or dismissed, we call it pending.
    /// </remarks>
    public sealed partial class AccessApprovalClientImpl : AccessApprovalClient
    {
        private readonly gaxgrpc::ApiCall<ListApprovalRequestsMessage, ListApprovalRequestsResponse> _callListApprovalRequests;

        private readonly gaxgrpc::ApiCall<GetApprovalRequestMessage, ApprovalRequest> _callGetApprovalRequest;

        private readonly gaxgrpc::ApiCall<ApproveApprovalRequestMessage, ApprovalRequest> _callApproveApprovalRequest;

        private readonly gaxgrpc::ApiCall<DismissApprovalRequestMessage, ApprovalRequest> _callDismissApprovalRequest;

        private readonly gaxgrpc::ApiCall<GetAccessApprovalSettingsMessage, AccessApprovalSettings> _callGetAccessApprovalSettings;

        private readonly gaxgrpc::ApiCall<UpdateAccessApprovalSettingsMessage, AccessApprovalSettings> _callUpdateAccessApprovalSettings;

        private readonly gaxgrpc::ApiCall<DeleteAccessApprovalSettingsMessage, wkt::Empty> _callDeleteAccessApprovalSettings;

        /// <summary>
        /// Constructs a client wrapper for the AccessApproval service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AccessApprovalSettings"/> used within this client.</param>
        public AccessApprovalClientImpl(AccessApproval.AccessApprovalClient grpcClient, AccessApprovalSettings settings)
        {
            GrpcClient = grpcClient;
            AccessApprovalSettings effectiveSettings = settings ?? AccessApprovalSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callListApprovalRequests = clientHelper.BuildApiCall<ListApprovalRequestsMessage, ListApprovalRequestsResponse>(grpcClient.ListApprovalRequestsAsync, grpcClient.ListApprovalRequests, effectiveSettings.ListApprovalRequestsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListApprovalRequests);
            Modify_ListApprovalRequestsApiCall(ref _callListApprovalRequests);
            _callGetApprovalRequest = clientHelper.BuildApiCall<GetApprovalRequestMessage, ApprovalRequest>(grpcClient.GetApprovalRequestAsync, grpcClient.GetApprovalRequest, effectiveSettings.GetApprovalRequestSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetApprovalRequest);
            Modify_GetApprovalRequestApiCall(ref _callGetApprovalRequest);
            _callApproveApprovalRequest = clientHelper.BuildApiCall<ApproveApprovalRequestMessage, ApprovalRequest>(grpcClient.ApproveApprovalRequestAsync, grpcClient.ApproveApprovalRequest, effectiveSettings.ApproveApprovalRequestSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callApproveApprovalRequest);
            Modify_ApproveApprovalRequestApiCall(ref _callApproveApprovalRequest);
            _callDismissApprovalRequest = clientHelper.BuildApiCall<DismissApprovalRequestMessage, ApprovalRequest>(grpcClient.DismissApprovalRequestAsync, grpcClient.DismissApprovalRequest, effectiveSettings.DismissApprovalRequestSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDismissApprovalRequest);
            Modify_DismissApprovalRequestApiCall(ref _callDismissApprovalRequest);
            _callGetAccessApprovalSettings = clientHelper.BuildApiCall<GetAccessApprovalSettingsMessage, AccessApprovalSettings>(grpcClient.GetAccessApprovalSettingsAsync, grpcClient.GetAccessApprovalSettings, effectiveSettings.GetAccessApprovalSettingsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAccessApprovalSettings);
            Modify_GetAccessApprovalSettingsApiCall(ref _callGetAccessApprovalSettings);
            _callUpdateAccessApprovalSettings = clientHelper.BuildApiCall<UpdateAccessApprovalSettingsMessage, AccessApprovalSettings>(grpcClient.UpdateAccessApprovalSettingsAsync, grpcClient.UpdateAccessApprovalSettings, effectiveSettings.UpdateAccessApprovalSettingsSettings).WithGoogleRequestParam("settings.name", request => request.Settings?.Name);
            Modify_ApiCall(ref _callUpdateAccessApprovalSettings);
            Modify_UpdateAccessApprovalSettingsApiCall(ref _callUpdateAccessApprovalSettings);
            _callDeleteAccessApprovalSettings = clientHelper.BuildApiCall<DeleteAccessApprovalSettingsMessage, wkt::Empty>(grpcClient.DeleteAccessApprovalSettingsAsync, grpcClient.DeleteAccessApprovalSettings, effectiveSettings.DeleteAccessApprovalSettingsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAccessApprovalSettings);
            Modify_DeleteAccessApprovalSettingsApiCall(ref _callDeleteAccessApprovalSettings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListApprovalRequestsApiCall(ref gaxgrpc::ApiCall<ListApprovalRequestsMessage, ListApprovalRequestsResponse> call);

        partial void Modify_GetApprovalRequestApiCall(ref gaxgrpc::ApiCall<GetApprovalRequestMessage, ApprovalRequest> call);

        partial void Modify_ApproveApprovalRequestApiCall(ref gaxgrpc::ApiCall<ApproveApprovalRequestMessage, ApprovalRequest> call);

        partial void Modify_DismissApprovalRequestApiCall(ref gaxgrpc::ApiCall<DismissApprovalRequestMessage, ApprovalRequest> call);

        partial void Modify_GetAccessApprovalSettingsApiCall(ref gaxgrpc::ApiCall<GetAccessApprovalSettingsMessage, AccessApprovalSettings> call);

        partial void Modify_UpdateAccessApprovalSettingsApiCall(ref gaxgrpc::ApiCall<UpdateAccessApprovalSettingsMessage, AccessApprovalSettings> call);

        partial void Modify_DeleteAccessApprovalSettingsApiCall(ref gaxgrpc::ApiCall<DeleteAccessApprovalSettingsMessage, wkt::Empty> call);

        partial void OnConstruction(AccessApproval.AccessApprovalClient grpcClient, AccessApprovalSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AccessApproval client</summary>
        public override AccessApproval.AccessApprovalClient GrpcClient { get; }

        partial void Modify_ListApprovalRequestsMessage(ref ListApprovalRequestsMessage request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetApprovalRequestMessage(ref GetApprovalRequestMessage request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ApproveApprovalRequestMessage(ref ApproveApprovalRequestMessage request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DismissApprovalRequestMessage(ref DismissApprovalRequestMessage request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAccessApprovalSettingsMessage(ref GetAccessApprovalSettingsMessage request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAccessApprovalSettingsMessage(ref UpdateAccessApprovalSettingsMessage request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAccessApprovalSettingsMessage(ref DeleteAccessApprovalSettingsMessage request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists approval requests associated with a project, folder, or organization.
        /// Approval requests can be filtered by state (pending, active, dismissed).
        /// The order is reverse chronological.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ApprovalRequest"/> resources.</returns>
        public override gax::PagedEnumerable<ListApprovalRequestsResponse, ApprovalRequest> ListApprovalRequests(ListApprovalRequestsMessage request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListApprovalRequestsMessage(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListApprovalRequestsMessage, ListApprovalRequestsResponse, ApprovalRequest>(_callListApprovalRequests, request, callSettings);
        }

        /// <summary>
        /// Lists approval requests associated with a project, folder, or organization.
        /// Approval requests can be filtered by state (pending, active, dismissed).
        /// The order is reverse chronological.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ApprovalRequest"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListApprovalRequestsResponse, ApprovalRequest> ListApprovalRequestsAsync(ListApprovalRequestsMessage request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListApprovalRequestsMessage(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListApprovalRequestsMessage, ListApprovalRequestsResponse, ApprovalRequest>(_callListApprovalRequests, request, callSettings);
        }

        /// <summary>
        /// Gets an approval request. Returns NOT_FOUND if the request does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ApprovalRequest GetApprovalRequest(GetApprovalRequestMessage request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetApprovalRequestMessage(ref request, ref callSettings);
            return _callGetApprovalRequest.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an approval request. Returns NOT_FOUND if the request does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ApprovalRequest> GetApprovalRequestAsync(GetApprovalRequestMessage request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetApprovalRequestMessage(ref request, ref callSettings);
            return _callGetApprovalRequest.Async(request, callSettings);
        }

        /// <summary>
        /// Approves a request and returns the updated ApprovalRequest.
        /// 
        /// Returns NOT_FOUND if the request does not exist. Returns
        /// FAILED_PRECONDITION if the request exists but is not in a pending state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ApprovalRequest ApproveApprovalRequest(ApproveApprovalRequestMessage request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ApproveApprovalRequestMessage(ref request, ref callSettings);
            return _callApproveApprovalRequest.Sync(request, callSettings);
        }

        /// <summary>
        /// Approves a request and returns the updated ApprovalRequest.
        /// 
        /// Returns NOT_FOUND if the request does not exist. Returns
        /// FAILED_PRECONDITION if the request exists but is not in a pending state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ApprovalRequest> ApproveApprovalRequestAsync(ApproveApprovalRequestMessage request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ApproveApprovalRequestMessage(ref request, ref callSettings);
            return _callApproveApprovalRequest.Async(request, callSettings);
        }

        /// <summary>
        /// Dismisses a request. Returns the updated ApprovalRequest.
        /// 
        /// NOTE: This does not deny access to the resource if another request has been
        /// made and approved. It is equivalent in effect to ignoring the request
        /// altogether.
        /// 
        /// Returns NOT_FOUND if the request does not exist.
        /// 
        /// Returns FAILED_PRECONDITION if the request exists but is not in a pending
        /// state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ApprovalRequest DismissApprovalRequest(DismissApprovalRequestMessage request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DismissApprovalRequestMessage(ref request, ref callSettings);
            return _callDismissApprovalRequest.Sync(request, callSettings);
        }

        /// <summary>
        /// Dismisses a request. Returns the updated ApprovalRequest.
        /// 
        /// NOTE: This does not deny access to the resource if another request has been
        /// made and approved. It is equivalent in effect to ignoring the request
        /// altogether.
        /// 
        /// Returns NOT_FOUND if the request does not exist.
        /// 
        /// Returns FAILED_PRECONDITION if the request exists but is not in a pending
        /// state.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ApprovalRequest> DismissApprovalRequestAsync(DismissApprovalRequestMessage request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DismissApprovalRequestMessage(ref request, ref callSettings);
            return _callDismissApprovalRequest.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the settings associated with a project, folder, or organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AccessApprovalSettings GetAccessApprovalSettings(GetAccessApprovalSettingsMessage request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAccessApprovalSettingsMessage(ref request, ref callSettings);
            return _callGetAccessApprovalSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the settings associated with a project, folder, or organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AccessApprovalSettings> GetAccessApprovalSettingsAsync(GetAccessApprovalSettingsMessage request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAccessApprovalSettingsMessage(ref request, ref callSettings);
            return _callGetAccessApprovalSettings.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the settings associated with a project, folder, or organization.
        /// Settings to update are determined by the value of field_mask.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AccessApprovalSettings UpdateAccessApprovalSettings(UpdateAccessApprovalSettingsMessage request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAccessApprovalSettingsMessage(ref request, ref callSettings);
            return _callUpdateAccessApprovalSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the settings associated with a project, folder, or organization.
        /// Settings to update are determined by the value of field_mask.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AccessApprovalSettings> UpdateAccessApprovalSettingsAsync(UpdateAccessApprovalSettingsMessage request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAccessApprovalSettingsMessage(ref request, ref callSettings);
            return _callUpdateAccessApprovalSettings.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the settings associated with a project, folder, or organization.
        /// This will have the effect of disabling Access Approval for the project,
        /// folder, or organization, but only if all ancestors also have Access
        /// Approval disabled. If Access Approval is enabled at a higher level of the
        /// hierarchy, then Access Approval will still be enabled at this level as
        /// the settings are inherited.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteAccessApprovalSettings(DeleteAccessApprovalSettingsMessage request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAccessApprovalSettingsMessage(ref request, ref callSettings);
            _callDeleteAccessApprovalSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the settings associated with a project, folder, or organization.
        /// This will have the effect of disabling Access Approval for the project,
        /// folder, or organization, but only if all ancestors also have Access
        /// Approval disabled. If Access Approval is enabled at a higher level of the
        /// hierarchy, then Access Approval will still be enabled at this level as
        /// the settings are inherited.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteAccessApprovalSettingsAsync(DeleteAccessApprovalSettingsMessage request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAccessApprovalSettingsMessage(ref request, ref callSettings);
            return _callDeleteAccessApprovalSettings.Async(request, callSettings);
        }
    }

    public partial class ListApprovalRequestsMessage : gaxgrpc::IPageRequest
    {
    }

    public partial class ListApprovalRequestsResponse : gaxgrpc::IPageResponse<ApprovalRequest>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ApprovalRequest> GetEnumerator() => ApprovalRequests.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
