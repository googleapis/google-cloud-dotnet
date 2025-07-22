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

namespace Google.Cloud.PolicySimulator.V1
{
    /// <summary>Settings for <see cref="OrgPolicyViolationsPreviewServiceClient"/> instances.</summary>
    public sealed partial class OrgPolicyViolationsPreviewServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="OrgPolicyViolationsPreviewServiceSettings"/>.
        /// </summary>
        /// <returns>A new instance of the default <see cref="OrgPolicyViolationsPreviewServiceSettings"/>.</returns>
        public static OrgPolicyViolationsPreviewServiceSettings GetDefault() =>
            new OrgPolicyViolationsPreviewServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="OrgPolicyViolationsPreviewServiceSettings"/> object with default settings.
        /// </summary>
        public OrgPolicyViolationsPreviewServiceSettings()
        {
        }

        private OrgPolicyViolationsPreviewServiceSettings(OrgPolicyViolationsPreviewServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListOrgPolicyViolationsPreviewsSettings = existing.ListOrgPolicyViolationsPreviewsSettings;
            GetOrgPolicyViolationsPreviewSettings = existing.GetOrgPolicyViolationsPreviewSettings;
            CreateOrgPolicyViolationsPreviewSettings = existing.CreateOrgPolicyViolationsPreviewSettings;
            CreateOrgPolicyViolationsPreviewOperationsSettings = existing.CreateOrgPolicyViolationsPreviewOperationsSettings.Clone();
            ListOrgPolicyViolationsSettings = existing.ListOrgPolicyViolationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(OrgPolicyViolationsPreviewServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrgPolicyViolationsPreviewServiceClient.ListOrgPolicyViolationsPreviews</c> and
        /// <c>OrgPolicyViolationsPreviewServiceClient.ListOrgPolicyViolationsPreviewsAsync</c>.
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
        public gaxgrpc::CallSettings ListOrgPolicyViolationsPreviewsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrgPolicyViolationsPreviewServiceClient.GetOrgPolicyViolationsPreview</c> and
        /// <c>OrgPolicyViolationsPreviewServiceClient.GetOrgPolicyViolationsPreviewAsync</c>.
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
        public gaxgrpc::CallSettings GetOrgPolicyViolationsPreviewSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrgPolicyViolationsPreviewServiceClient.CreateOrgPolicyViolationsPreview</c> and
        /// <c>OrgPolicyViolationsPreviewServiceClient.CreateOrgPolicyViolationsPreviewAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateOrgPolicyViolationsPreviewSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>OrgPolicyViolationsPreviewServiceClient.CreateOrgPolicyViolationsPreview</c> and
        /// <c>OrgPolicyViolationsPreviewServiceClient.CreateOrgPolicyViolationsPreviewAsync</c>.
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
        public lro::OperationsSettings CreateOrgPolicyViolationsPreviewOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrgPolicyViolationsPreviewServiceClient.ListOrgPolicyViolations</c> and
        /// <c>OrgPolicyViolationsPreviewServiceClient.ListOrgPolicyViolationsAsync</c>.
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
        public gaxgrpc::CallSettings ListOrgPolicyViolationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="OrgPolicyViolationsPreviewServiceSettings"/> object.</returns>
        public OrgPolicyViolationsPreviewServiceSettings Clone() => new OrgPolicyViolationsPreviewServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="OrgPolicyViolationsPreviewServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class OrgPolicyViolationsPreviewServiceClientBuilder : gaxgrpc::ClientBuilderBase<OrgPolicyViolationsPreviewServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public OrgPolicyViolationsPreviewServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public OrgPolicyViolationsPreviewServiceClientBuilder() : base(OrgPolicyViolationsPreviewServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref OrgPolicyViolationsPreviewServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<OrgPolicyViolationsPreviewServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override OrgPolicyViolationsPreviewServiceClient Build()
        {
            OrgPolicyViolationsPreviewServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<OrgPolicyViolationsPreviewServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<OrgPolicyViolationsPreviewServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private OrgPolicyViolationsPreviewServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return OrgPolicyViolationsPreviewServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<OrgPolicyViolationsPreviewServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return OrgPolicyViolationsPreviewServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => OrgPolicyViolationsPreviewServiceClient.ChannelPool;
    }

    /// <summary>OrgPolicyViolationsPreviewService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Violations Preview API service for OrgPolicy.
    /// 
    /// An
    /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
    /// is a preview of the violations that will exist as soon as a proposed
    /// OrgPolicy change is submitted. To create an
    /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview],
    /// the API user specifies the changes they wish to make and requests the
    /// generation of a preview via [GenerateViolationsPreview][]. the OrgPolicy
    /// Simulator service then scans the API user's currently existing resources to
    /// determine these resources violate the newly set OrgPolicy.
    /// </remarks>
    public abstract partial class OrgPolicyViolationsPreviewServiceClient
    {
        /// <summary>
        /// The default endpoint for the OrgPolicyViolationsPreviewService service, which is a host of
        /// "policysimulator.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "policysimulator.googleapis.com:443";

        /// <summary>The default OrgPolicyViolationsPreviewService scopes.</summary>
        /// <remarks>
        /// The default OrgPolicyViolationsPreviewService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(OrgPolicyViolationsPreviewService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="OrgPolicyViolationsPreviewServiceClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="OrgPolicyViolationsPreviewServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="OrgPolicyViolationsPreviewServiceClient"/>.</returns>
        public static stt::Task<OrgPolicyViolationsPreviewServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new OrgPolicyViolationsPreviewServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="OrgPolicyViolationsPreviewServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="OrgPolicyViolationsPreviewServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="OrgPolicyViolationsPreviewServiceClient"/>.</returns>
        public static OrgPolicyViolationsPreviewServiceClient Create() =>
            new OrgPolicyViolationsPreviewServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="OrgPolicyViolationsPreviewServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="OrgPolicyViolationsPreviewServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="OrgPolicyViolationsPreviewServiceClient"/>.</returns>
        internal static OrgPolicyViolationsPreviewServiceClient Create(grpccore::CallInvoker callInvoker, OrgPolicyViolationsPreviewServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            OrgPolicyViolationsPreviewService.OrgPolicyViolationsPreviewServiceClient grpcClient = new OrgPolicyViolationsPreviewService.OrgPolicyViolationsPreviewServiceClient(callInvoker);
            return new OrgPolicyViolationsPreviewServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC OrgPolicyViolationsPreviewService client</summary>
        public virtual OrgPolicyViolationsPreviewService.OrgPolicyViolationsPreviewServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// ListOrgPolicyViolationsPreviews lists each
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// in an organization. Each
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// is available for at least 7 days.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="OrgPolicyViolationsPreview"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOrgPolicyViolationsPreviewsResponse, OrgPolicyViolationsPreview> ListOrgPolicyViolationsPreviews(ListOrgPolicyViolationsPreviewsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// ListOrgPolicyViolationsPreviews lists each
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// in an organization. Each
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// is available for at least 7 days.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="OrgPolicyViolationsPreview"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOrgPolicyViolationsPreviewsResponse, OrgPolicyViolationsPreview> ListOrgPolicyViolationsPreviewsAsync(ListOrgPolicyViolationsPreviewsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// ListOrgPolicyViolationsPreviews lists each
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// in an organization. Each
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// is available for at least 7 days.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent the violations are scoped to.
        /// Format:
        /// `organizations/{organization}/locations/{location}`
        /// 
        /// Example: `organizations/my-example-org/locations/global`
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
        /// <returns>A pageable sequence of <see cref="OrgPolicyViolationsPreview"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOrgPolicyViolationsPreviewsResponse, OrgPolicyViolationsPreview> ListOrgPolicyViolationsPreviews(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOrgPolicyViolationsPreviewsRequest request = new ListOrgPolicyViolationsPreviewsRequest
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
            return ListOrgPolicyViolationsPreviews(request, callSettings);
        }

        /// <summary>
        /// ListOrgPolicyViolationsPreviews lists each
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// in an organization. Each
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// is available for at least 7 days.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent the violations are scoped to.
        /// Format:
        /// `organizations/{organization}/locations/{location}`
        /// 
        /// Example: `organizations/my-example-org/locations/global`
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
        /// <returns>A pageable asynchronous sequence of <see cref="OrgPolicyViolationsPreview"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOrgPolicyViolationsPreviewsResponse, OrgPolicyViolationsPreview> ListOrgPolicyViolationsPreviewsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOrgPolicyViolationsPreviewsRequest request = new ListOrgPolicyViolationsPreviewsRequest
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
            return ListOrgPolicyViolationsPreviewsAsync(request, callSettings);
        }

        /// <summary>
        /// ListOrgPolicyViolationsPreviews lists each
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// in an organization. Each
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// is available for at least 7 days.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent the violations are scoped to.
        /// Format:
        /// `organizations/{organization}/locations/{location}`
        /// 
        /// Example: `organizations/my-example-org/locations/global`
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
        /// <returns>A pageable sequence of <see cref="OrgPolicyViolationsPreview"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOrgPolicyViolationsPreviewsResponse, OrgPolicyViolationsPreview> ListOrgPolicyViolationsPreviews(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOrgPolicyViolationsPreviewsRequest request = new ListOrgPolicyViolationsPreviewsRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListOrgPolicyViolationsPreviews(request, callSettings);
        }

        /// <summary>
        /// ListOrgPolicyViolationsPreviews lists each
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// in an organization. Each
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// is available for at least 7 days.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent the violations are scoped to.
        /// Format:
        /// `organizations/{organization}/locations/{location}`
        /// 
        /// Example: `organizations/my-example-org/locations/global`
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
        /// <returns>A pageable asynchronous sequence of <see cref="OrgPolicyViolationsPreview"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOrgPolicyViolationsPreviewsResponse, OrgPolicyViolationsPreview> ListOrgPolicyViolationsPreviewsAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOrgPolicyViolationsPreviewsRequest request = new ListOrgPolicyViolationsPreviewsRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListOrgPolicyViolationsPreviewsAsync(request, callSettings);
        }

        /// <summary>
        /// GetOrgPolicyViolationsPreview gets the specified
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview].
        /// Each
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// is available for at least 7 days.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OrgPolicyViolationsPreview GetOrgPolicyViolationsPreview(GetOrgPolicyViolationsPreviewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// GetOrgPolicyViolationsPreview gets the specified
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview].
        /// Each
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// is available for at least 7 days.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OrgPolicyViolationsPreview> GetOrgPolicyViolationsPreviewAsync(GetOrgPolicyViolationsPreviewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// GetOrgPolicyViolationsPreview gets the specified
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview].
        /// Each
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// is available for at least 7 days.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OrgPolicyViolationsPreview> GetOrgPolicyViolationsPreviewAsync(GetOrgPolicyViolationsPreviewRequest request, st::CancellationToken cancellationToken) =>
            GetOrgPolicyViolationsPreviewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// GetOrgPolicyViolationsPreview gets the specified
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview].
        /// Each
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// is available for at least 7 days.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OrgPolicyViolationsPreview to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OrgPolicyViolationsPreview GetOrgPolicyViolationsPreview(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrgPolicyViolationsPreview(new GetOrgPolicyViolationsPreviewRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// GetOrgPolicyViolationsPreview gets the specified
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview].
        /// Each
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// is available for at least 7 days.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OrgPolicyViolationsPreview to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OrgPolicyViolationsPreview> GetOrgPolicyViolationsPreviewAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrgPolicyViolationsPreviewAsync(new GetOrgPolicyViolationsPreviewRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// GetOrgPolicyViolationsPreview gets the specified
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview].
        /// Each
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// is available for at least 7 days.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OrgPolicyViolationsPreview to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OrgPolicyViolationsPreview> GetOrgPolicyViolationsPreviewAsync(string name, st::CancellationToken cancellationToken) =>
            GetOrgPolicyViolationsPreviewAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// GetOrgPolicyViolationsPreview gets the specified
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview].
        /// Each
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// is available for at least 7 days.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OrgPolicyViolationsPreview to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OrgPolicyViolationsPreview GetOrgPolicyViolationsPreview(OrgPolicyViolationsPreviewName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrgPolicyViolationsPreview(new GetOrgPolicyViolationsPreviewRequest
            {
                OrgPolicyViolationsPreviewName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// GetOrgPolicyViolationsPreview gets the specified
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview].
        /// Each
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// is available for at least 7 days.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OrgPolicyViolationsPreview to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OrgPolicyViolationsPreview> GetOrgPolicyViolationsPreviewAsync(OrgPolicyViolationsPreviewName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrgPolicyViolationsPreviewAsync(new GetOrgPolicyViolationsPreviewRequest
            {
                OrgPolicyViolationsPreviewName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// GetOrgPolicyViolationsPreview gets the specified
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview].
        /// Each
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// is available for at least 7 days.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the OrgPolicyViolationsPreview to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OrgPolicyViolationsPreview> GetOrgPolicyViolationsPreviewAsync(OrgPolicyViolationsPreviewName name, st::CancellationToken cancellationToken) =>
            GetOrgPolicyViolationsPreviewAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// CreateOrgPolicyViolationsPreview creates an
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// for the proposed changes in the provided
        /// [OrgPolicyViolationsPreview.OrgPolicyOverlay][]. The changes to OrgPolicy
        /// are specified by this `OrgPolicyOverlay`. The resources to scan are
        /// inferred from these specified changes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<OrgPolicyViolationsPreview, CreateOrgPolicyViolationsPreviewOperationMetadata> CreateOrgPolicyViolationsPreview(CreateOrgPolicyViolationsPreviewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// CreateOrgPolicyViolationsPreview creates an
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// for the proposed changes in the provided
        /// [OrgPolicyViolationsPreview.OrgPolicyOverlay][]. The changes to OrgPolicy
        /// are specified by this `OrgPolicyOverlay`. The resources to scan are
        /// inferred from these specified changes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OrgPolicyViolationsPreview, CreateOrgPolicyViolationsPreviewOperationMetadata>> CreateOrgPolicyViolationsPreviewAsync(CreateOrgPolicyViolationsPreviewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// CreateOrgPolicyViolationsPreview creates an
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// for the proposed changes in the provided
        /// [OrgPolicyViolationsPreview.OrgPolicyOverlay][]. The changes to OrgPolicy
        /// are specified by this `OrgPolicyOverlay`. The resources to scan are
        /// inferred from these specified changes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OrgPolicyViolationsPreview, CreateOrgPolicyViolationsPreviewOperationMetadata>> CreateOrgPolicyViolationsPreviewAsync(CreateOrgPolicyViolationsPreviewRequest request, st::CancellationToken cancellationToken) =>
            CreateOrgPolicyViolationsPreviewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateOrgPolicyViolationsPreview</c>.</summary>
        public virtual lro::OperationsClient CreateOrgPolicyViolationsPreviewOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateOrgPolicyViolationsPreview</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<OrgPolicyViolationsPreview, CreateOrgPolicyViolationsPreviewOperationMetadata> PollOnceCreateOrgPolicyViolationsPreview(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<OrgPolicyViolationsPreview, CreateOrgPolicyViolationsPreviewOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateOrgPolicyViolationsPreviewOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateOrgPolicyViolationsPreview</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<OrgPolicyViolationsPreview, CreateOrgPolicyViolationsPreviewOperationMetadata>> PollOnceCreateOrgPolicyViolationsPreviewAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<OrgPolicyViolationsPreview, CreateOrgPolicyViolationsPreviewOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateOrgPolicyViolationsPreviewOperationsClient, callSettings);

        /// <summary>
        /// CreateOrgPolicyViolationsPreview creates an
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// for the proposed changes in the provided
        /// [OrgPolicyViolationsPreview.OrgPolicyOverlay][]. The changes to OrgPolicy
        /// are specified by this `OrgPolicyOverlay`. The resources to scan are
        /// inferred from these specified changes.
        /// </summary>
        /// <param name="parent">
        /// Required. The organization under which this
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// will be created.
        /// 
        /// Example: `organizations/my-example-org/locations/global`
        /// </param>
        /// <param name="orgPolicyViolationsPreview">
        /// Required. The
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// to generate.
        /// </param>
        /// <param name="orgPolicyViolationsPreviewId">
        /// Optional. An optional user-specified ID for the
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview].
        /// If not provided, a random ID will be generated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<OrgPolicyViolationsPreview, CreateOrgPolicyViolationsPreviewOperationMetadata> CreateOrgPolicyViolationsPreview(string parent, OrgPolicyViolationsPreview orgPolicyViolationsPreview, string orgPolicyViolationsPreviewId, gaxgrpc::CallSettings callSettings = null) =>
            CreateOrgPolicyViolationsPreview(new CreateOrgPolicyViolationsPreviewRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                OrgPolicyViolationsPreview = gax::GaxPreconditions.CheckNotNull(orgPolicyViolationsPreview, nameof(orgPolicyViolationsPreview)),
                OrgPolicyViolationsPreviewId = orgPolicyViolationsPreviewId ?? "",
            }, callSettings);

        /// <summary>
        /// CreateOrgPolicyViolationsPreview creates an
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// for the proposed changes in the provided
        /// [OrgPolicyViolationsPreview.OrgPolicyOverlay][]. The changes to OrgPolicy
        /// are specified by this `OrgPolicyOverlay`. The resources to scan are
        /// inferred from these specified changes.
        /// </summary>
        /// <param name="parent">
        /// Required. The organization under which this
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// will be created.
        /// 
        /// Example: `organizations/my-example-org/locations/global`
        /// </param>
        /// <param name="orgPolicyViolationsPreview">
        /// Required. The
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// to generate.
        /// </param>
        /// <param name="orgPolicyViolationsPreviewId">
        /// Optional. An optional user-specified ID for the
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview].
        /// If not provided, a random ID will be generated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OrgPolicyViolationsPreview, CreateOrgPolicyViolationsPreviewOperationMetadata>> CreateOrgPolicyViolationsPreviewAsync(string parent, OrgPolicyViolationsPreview orgPolicyViolationsPreview, string orgPolicyViolationsPreviewId, gaxgrpc::CallSettings callSettings = null) =>
            CreateOrgPolicyViolationsPreviewAsync(new CreateOrgPolicyViolationsPreviewRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                OrgPolicyViolationsPreview = gax::GaxPreconditions.CheckNotNull(orgPolicyViolationsPreview, nameof(orgPolicyViolationsPreview)),
                OrgPolicyViolationsPreviewId = orgPolicyViolationsPreviewId ?? "",
            }, callSettings);

        /// <summary>
        /// CreateOrgPolicyViolationsPreview creates an
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// for the proposed changes in the provided
        /// [OrgPolicyViolationsPreview.OrgPolicyOverlay][]. The changes to OrgPolicy
        /// are specified by this `OrgPolicyOverlay`. The resources to scan are
        /// inferred from these specified changes.
        /// </summary>
        /// <param name="parent">
        /// Required. The organization under which this
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// will be created.
        /// 
        /// Example: `organizations/my-example-org/locations/global`
        /// </param>
        /// <param name="orgPolicyViolationsPreview">
        /// Required. The
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// to generate.
        /// </param>
        /// <param name="orgPolicyViolationsPreviewId">
        /// Optional. An optional user-specified ID for the
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview].
        /// If not provided, a random ID will be generated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OrgPolicyViolationsPreview, CreateOrgPolicyViolationsPreviewOperationMetadata>> CreateOrgPolicyViolationsPreviewAsync(string parent, OrgPolicyViolationsPreview orgPolicyViolationsPreview, string orgPolicyViolationsPreviewId, st::CancellationToken cancellationToken) =>
            CreateOrgPolicyViolationsPreviewAsync(parent, orgPolicyViolationsPreview, orgPolicyViolationsPreviewId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// CreateOrgPolicyViolationsPreview creates an
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// for the proposed changes in the provided
        /// [OrgPolicyViolationsPreview.OrgPolicyOverlay][]. The changes to OrgPolicy
        /// are specified by this `OrgPolicyOverlay`. The resources to scan are
        /// inferred from these specified changes.
        /// </summary>
        /// <param name="parent">
        /// Required. The organization under which this
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// will be created.
        /// 
        /// Example: `organizations/my-example-org/locations/global`
        /// </param>
        /// <param name="orgPolicyViolationsPreview">
        /// Required. The
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// to generate.
        /// </param>
        /// <param name="orgPolicyViolationsPreviewId">
        /// Optional. An optional user-specified ID for the
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview].
        /// If not provided, a random ID will be generated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<OrgPolicyViolationsPreview, CreateOrgPolicyViolationsPreviewOperationMetadata> CreateOrgPolicyViolationsPreview(OrganizationLocationName parent, OrgPolicyViolationsPreview orgPolicyViolationsPreview, string orgPolicyViolationsPreviewId, gaxgrpc::CallSettings callSettings = null) =>
            CreateOrgPolicyViolationsPreview(new CreateOrgPolicyViolationsPreviewRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OrgPolicyViolationsPreview = gax::GaxPreconditions.CheckNotNull(orgPolicyViolationsPreview, nameof(orgPolicyViolationsPreview)),
                OrgPolicyViolationsPreviewId = orgPolicyViolationsPreviewId ?? "",
            }, callSettings);

        /// <summary>
        /// CreateOrgPolicyViolationsPreview creates an
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// for the proposed changes in the provided
        /// [OrgPolicyViolationsPreview.OrgPolicyOverlay][]. The changes to OrgPolicy
        /// are specified by this `OrgPolicyOverlay`. The resources to scan are
        /// inferred from these specified changes.
        /// </summary>
        /// <param name="parent">
        /// Required. The organization under which this
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// will be created.
        /// 
        /// Example: `organizations/my-example-org/locations/global`
        /// </param>
        /// <param name="orgPolicyViolationsPreview">
        /// Required. The
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// to generate.
        /// </param>
        /// <param name="orgPolicyViolationsPreviewId">
        /// Optional. An optional user-specified ID for the
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview].
        /// If not provided, a random ID will be generated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OrgPolicyViolationsPreview, CreateOrgPolicyViolationsPreviewOperationMetadata>> CreateOrgPolicyViolationsPreviewAsync(OrganizationLocationName parent, OrgPolicyViolationsPreview orgPolicyViolationsPreview, string orgPolicyViolationsPreviewId, gaxgrpc::CallSettings callSettings = null) =>
            CreateOrgPolicyViolationsPreviewAsync(new CreateOrgPolicyViolationsPreviewRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OrgPolicyViolationsPreview = gax::GaxPreconditions.CheckNotNull(orgPolicyViolationsPreview, nameof(orgPolicyViolationsPreview)),
                OrgPolicyViolationsPreviewId = orgPolicyViolationsPreviewId ?? "",
            }, callSettings);

        /// <summary>
        /// CreateOrgPolicyViolationsPreview creates an
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// for the proposed changes in the provided
        /// [OrgPolicyViolationsPreview.OrgPolicyOverlay][]. The changes to OrgPolicy
        /// are specified by this `OrgPolicyOverlay`. The resources to scan are
        /// inferred from these specified changes.
        /// </summary>
        /// <param name="parent">
        /// Required. The organization under which this
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// will be created.
        /// 
        /// Example: `organizations/my-example-org/locations/global`
        /// </param>
        /// <param name="orgPolicyViolationsPreview">
        /// Required. The
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// to generate.
        /// </param>
        /// <param name="orgPolicyViolationsPreviewId">
        /// Optional. An optional user-specified ID for the
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview].
        /// If not provided, a random ID will be generated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<OrgPolicyViolationsPreview, CreateOrgPolicyViolationsPreviewOperationMetadata>> CreateOrgPolicyViolationsPreviewAsync(OrganizationLocationName parent, OrgPolicyViolationsPreview orgPolicyViolationsPreview, string orgPolicyViolationsPreviewId, st::CancellationToken cancellationToken) =>
            CreateOrgPolicyViolationsPreviewAsync(parent, orgPolicyViolationsPreview, orgPolicyViolationsPreviewId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// ListOrgPolicyViolations lists the [OrgPolicyViolations][] that are present
        /// in an
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="OrgPolicyViolation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOrgPolicyViolationsResponse, OrgPolicyViolation> ListOrgPolicyViolations(ListOrgPolicyViolationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// ListOrgPolicyViolations lists the [OrgPolicyViolations][] that are present
        /// in an
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="OrgPolicyViolation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOrgPolicyViolationsResponse, OrgPolicyViolation> ListOrgPolicyViolationsAsync(ListOrgPolicyViolationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// ListOrgPolicyViolations lists the [OrgPolicyViolations][] that are present
        /// in an
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview].
        /// </summary>
        /// <param name="parent">
        /// Required. The OrgPolicyViolationsPreview to get OrgPolicyViolations from.
        /// Format:
        /// organizations/{organization}/locations/{location}/orgPolicyViolationsPreviews/{orgPolicyViolationsPreview}
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
        /// <returns>A pageable sequence of <see cref="OrgPolicyViolation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOrgPolicyViolationsResponse, OrgPolicyViolation> ListOrgPolicyViolations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOrgPolicyViolationsRequest request = new ListOrgPolicyViolationsRequest
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
            return ListOrgPolicyViolations(request, callSettings);
        }

        /// <summary>
        /// ListOrgPolicyViolations lists the [OrgPolicyViolations][] that are present
        /// in an
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview].
        /// </summary>
        /// <param name="parent">
        /// Required. The OrgPolicyViolationsPreview to get OrgPolicyViolations from.
        /// Format:
        /// organizations/{organization}/locations/{location}/orgPolicyViolationsPreviews/{orgPolicyViolationsPreview}
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
        /// <returns>A pageable asynchronous sequence of <see cref="OrgPolicyViolation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOrgPolicyViolationsResponse, OrgPolicyViolation> ListOrgPolicyViolationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOrgPolicyViolationsRequest request = new ListOrgPolicyViolationsRequest
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
            return ListOrgPolicyViolationsAsync(request, callSettings);
        }

        /// <summary>
        /// ListOrgPolicyViolations lists the [OrgPolicyViolations][] that are present
        /// in an
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview].
        /// </summary>
        /// <param name="parent">
        /// Required. The OrgPolicyViolationsPreview to get OrgPolicyViolations from.
        /// Format:
        /// organizations/{organization}/locations/{location}/orgPolicyViolationsPreviews/{orgPolicyViolationsPreview}
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
        /// <returns>A pageable sequence of <see cref="OrgPolicyViolation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOrgPolicyViolationsResponse, OrgPolicyViolation> ListOrgPolicyViolations(OrgPolicyViolationsPreviewName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOrgPolicyViolationsRequest request = new ListOrgPolicyViolationsRequest
            {
                ParentAsOrgPolicyViolationsPreviewName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListOrgPolicyViolations(request, callSettings);
        }

        /// <summary>
        /// ListOrgPolicyViolations lists the [OrgPolicyViolations][] that are present
        /// in an
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview].
        /// </summary>
        /// <param name="parent">
        /// Required. The OrgPolicyViolationsPreview to get OrgPolicyViolations from.
        /// Format:
        /// organizations/{organization}/locations/{location}/orgPolicyViolationsPreviews/{orgPolicyViolationsPreview}
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
        /// <returns>A pageable asynchronous sequence of <see cref="OrgPolicyViolation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOrgPolicyViolationsResponse, OrgPolicyViolation> ListOrgPolicyViolationsAsync(OrgPolicyViolationsPreviewName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOrgPolicyViolationsRequest request = new ListOrgPolicyViolationsRequest
            {
                ParentAsOrgPolicyViolationsPreviewName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListOrgPolicyViolationsAsync(request, callSettings);
        }
    }

    /// <summary>OrgPolicyViolationsPreviewService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Violations Preview API service for OrgPolicy.
    /// 
    /// An
    /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
    /// is a preview of the violations that will exist as soon as a proposed
    /// OrgPolicy change is submitted. To create an
    /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview],
    /// the API user specifies the changes they wish to make and requests the
    /// generation of a preview via [GenerateViolationsPreview][]. the OrgPolicy
    /// Simulator service then scans the API user's currently existing resources to
    /// determine these resources violate the newly set OrgPolicy.
    /// </remarks>
    public sealed partial class OrgPolicyViolationsPreviewServiceClientImpl : OrgPolicyViolationsPreviewServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListOrgPolicyViolationsPreviewsRequest, ListOrgPolicyViolationsPreviewsResponse> _callListOrgPolicyViolationsPreviews;

        private readonly gaxgrpc::ApiCall<GetOrgPolicyViolationsPreviewRequest, OrgPolicyViolationsPreview> _callGetOrgPolicyViolationsPreview;

        private readonly gaxgrpc::ApiCall<CreateOrgPolicyViolationsPreviewRequest, lro::Operation> _callCreateOrgPolicyViolationsPreview;

        private readonly gaxgrpc::ApiCall<ListOrgPolicyViolationsRequest, ListOrgPolicyViolationsResponse> _callListOrgPolicyViolations;

        /// <summary>
        /// Constructs a client wrapper for the OrgPolicyViolationsPreviewService service, with the specified gRPC
        /// client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="OrgPolicyViolationsPreviewServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public OrgPolicyViolationsPreviewServiceClientImpl(OrgPolicyViolationsPreviewService.OrgPolicyViolationsPreviewServiceClient grpcClient, OrgPolicyViolationsPreviewServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            OrgPolicyViolationsPreviewServiceSettings effectiveSettings = settings ?? OrgPolicyViolationsPreviewServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateOrgPolicyViolationsPreviewOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateOrgPolicyViolationsPreviewOperationsSettings, logger);
            _callListOrgPolicyViolationsPreviews = clientHelper.BuildApiCall<ListOrgPolicyViolationsPreviewsRequest, ListOrgPolicyViolationsPreviewsResponse>("ListOrgPolicyViolationsPreviews", grpcClient.ListOrgPolicyViolationsPreviewsAsync, grpcClient.ListOrgPolicyViolationsPreviews, effectiveSettings.ListOrgPolicyViolationsPreviewsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListOrgPolicyViolationsPreviews);
            Modify_ListOrgPolicyViolationsPreviewsApiCall(ref _callListOrgPolicyViolationsPreviews);
            _callGetOrgPolicyViolationsPreview = clientHelper.BuildApiCall<GetOrgPolicyViolationsPreviewRequest, OrgPolicyViolationsPreview>("GetOrgPolicyViolationsPreview", grpcClient.GetOrgPolicyViolationsPreviewAsync, grpcClient.GetOrgPolicyViolationsPreview, effectiveSettings.GetOrgPolicyViolationsPreviewSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetOrgPolicyViolationsPreview);
            Modify_GetOrgPolicyViolationsPreviewApiCall(ref _callGetOrgPolicyViolationsPreview);
            _callCreateOrgPolicyViolationsPreview = clientHelper.BuildApiCall<CreateOrgPolicyViolationsPreviewRequest, lro::Operation>("CreateOrgPolicyViolationsPreview", grpcClient.CreateOrgPolicyViolationsPreviewAsync, grpcClient.CreateOrgPolicyViolationsPreview, effectiveSettings.CreateOrgPolicyViolationsPreviewSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateOrgPolicyViolationsPreview);
            Modify_CreateOrgPolicyViolationsPreviewApiCall(ref _callCreateOrgPolicyViolationsPreview);
            _callListOrgPolicyViolations = clientHelper.BuildApiCall<ListOrgPolicyViolationsRequest, ListOrgPolicyViolationsResponse>("ListOrgPolicyViolations", grpcClient.ListOrgPolicyViolationsAsync, grpcClient.ListOrgPolicyViolations, effectiveSettings.ListOrgPolicyViolationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListOrgPolicyViolations);
            Modify_ListOrgPolicyViolationsApiCall(ref _callListOrgPolicyViolations);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListOrgPolicyViolationsPreviewsApiCall(ref gaxgrpc::ApiCall<ListOrgPolicyViolationsPreviewsRequest, ListOrgPolicyViolationsPreviewsResponse> call);

        partial void Modify_GetOrgPolicyViolationsPreviewApiCall(ref gaxgrpc::ApiCall<GetOrgPolicyViolationsPreviewRequest, OrgPolicyViolationsPreview> call);

        partial void Modify_CreateOrgPolicyViolationsPreviewApiCall(ref gaxgrpc::ApiCall<CreateOrgPolicyViolationsPreviewRequest, lro::Operation> call);

        partial void Modify_ListOrgPolicyViolationsApiCall(ref gaxgrpc::ApiCall<ListOrgPolicyViolationsRequest, ListOrgPolicyViolationsResponse> call);

        partial void OnConstruction(OrgPolicyViolationsPreviewService.OrgPolicyViolationsPreviewServiceClient grpcClient, OrgPolicyViolationsPreviewServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC OrgPolicyViolationsPreviewService client</summary>
        public override OrgPolicyViolationsPreviewService.OrgPolicyViolationsPreviewServiceClient GrpcClient { get; }

        partial void Modify_ListOrgPolicyViolationsPreviewsRequest(ref ListOrgPolicyViolationsPreviewsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetOrgPolicyViolationsPreviewRequest(ref GetOrgPolicyViolationsPreviewRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateOrgPolicyViolationsPreviewRequest(ref CreateOrgPolicyViolationsPreviewRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListOrgPolicyViolationsRequest(ref ListOrgPolicyViolationsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// ListOrgPolicyViolationsPreviews lists each
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// in an organization. Each
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// is available for at least 7 days.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="OrgPolicyViolationsPreview"/> resources.</returns>
        public override gax::PagedEnumerable<ListOrgPolicyViolationsPreviewsResponse, OrgPolicyViolationsPreview> ListOrgPolicyViolationsPreviews(ListOrgPolicyViolationsPreviewsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOrgPolicyViolationsPreviewsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListOrgPolicyViolationsPreviewsRequest, ListOrgPolicyViolationsPreviewsResponse, OrgPolicyViolationsPreview>(_callListOrgPolicyViolationsPreviews, request, callSettings);
        }

        /// <summary>
        /// ListOrgPolicyViolationsPreviews lists each
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// in an organization. Each
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// is available for at least 7 days.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="OrgPolicyViolationsPreview"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListOrgPolicyViolationsPreviewsResponse, OrgPolicyViolationsPreview> ListOrgPolicyViolationsPreviewsAsync(ListOrgPolicyViolationsPreviewsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOrgPolicyViolationsPreviewsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListOrgPolicyViolationsPreviewsRequest, ListOrgPolicyViolationsPreviewsResponse, OrgPolicyViolationsPreview>(_callListOrgPolicyViolationsPreviews, request, callSettings);
        }

        /// <summary>
        /// GetOrgPolicyViolationsPreview gets the specified
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview].
        /// Each
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// is available for at least 7 days.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override OrgPolicyViolationsPreview GetOrgPolicyViolationsPreview(GetOrgPolicyViolationsPreviewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOrgPolicyViolationsPreviewRequest(ref request, ref callSettings);
            return _callGetOrgPolicyViolationsPreview.Sync(request, callSettings);
        }

        /// <summary>
        /// GetOrgPolicyViolationsPreview gets the specified
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview].
        /// Each
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// is available for at least 7 days.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<OrgPolicyViolationsPreview> GetOrgPolicyViolationsPreviewAsync(GetOrgPolicyViolationsPreviewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOrgPolicyViolationsPreviewRequest(ref request, ref callSettings);
            return _callGetOrgPolicyViolationsPreview.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateOrgPolicyViolationsPreview</c>.</summary>
        public override lro::OperationsClient CreateOrgPolicyViolationsPreviewOperationsClient { get; }

        /// <summary>
        /// CreateOrgPolicyViolationsPreview creates an
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// for the proposed changes in the provided
        /// [OrgPolicyViolationsPreview.OrgPolicyOverlay][]. The changes to OrgPolicy
        /// are specified by this `OrgPolicyOverlay`. The resources to scan are
        /// inferred from these specified changes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<OrgPolicyViolationsPreview, CreateOrgPolicyViolationsPreviewOperationMetadata> CreateOrgPolicyViolationsPreview(CreateOrgPolicyViolationsPreviewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateOrgPolicyViolationsPreviewRequest(ref request, ref callSettings);
            return new lro::Operation<OrgPolicyViolationsPreview, CreateOrgPolicyViolationsPreviewOperationMetadata>(_callCreateOrgPolicyViolationsPreview.Sync(request, callSettings), CreateOrgPolicyViolationsPreviewOperationsClient);
        }

        /// <summary>
        /// CreateOrgPolicyViolationsPreview creates an
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview]
        /// for the proposed changes in the provided
        /// [OrgPolicyViolationsPreview.OrgPolicyOverlay][]. The changes to OrgPolicy
        /// are specified by this `OrgPolicyOverlay`. The resources to scan are
        /// inferred from these specified changes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<OrgPolicyViolationsPreview, CreateOrgPolicyViolationsPreviewOperationMetadata>> CreateOrgPolicyViolationsPreviewAsync(CreateOrgPolicyViolationsPreviewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateOrgPolicyViolationsPreviewRequest(ref request, ref callSettings);
            return new lro::Operation<OrgPolicyViolationsPreview, CreateOrgPolicyViolationsPreviewOperationMetadata>(await _callCreateOrgPolicyViolationsPreview.Async(request, callSettings).ConfigureAwait(false), CreateOrgPolicyViolationsPreviewOperationsClient);
        }

        /// <summary>
        /// ListOrgPolicyViolations lists the [OrgPolicyViolations][] that are present
        /// in an
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="OrgPolicyViolation"/> resources.</returns>
        public override gax::PagedEnumerable<ListOrgPolicyViolationsResponse, OrgPolicyViolation> ListOrgPolicyViolations(ListOrgPolicyViolationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOrgPolicyViolationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListOrgPolicyViolationsRequest, ListOrgPolicyViolationsResponse, OrgPolicyViolation>(_callListOrgPolicyViolations, request, callSettings);
        }

        /// <summary>
        /// ListOrgPolicyViolations lists the [OrgPolicyViolations][] that are present
        /// in an
        /// [OrgPolicyViolationsPreview][google.cloud.policysimulator.v1.OrgPolicyViolationsPreview].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="OrgPolicyViolation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListOrgPolicyViolationsResponse, OrgPolicyViolation> ListOrgPolicyViolationsAsync(ListOrgPolicyViolationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOrgPolicyViolationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListOrgPolicyViolationsRequest, ListOrgPolicyViolationsResponse, OrgPolicyViolation>(_callListOrgPolicyViolations, request, callSettings);
        }
    }

    public partial class ListOrgPolicyViolationsPreviewsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListOrgPolicyViolationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListOrgPolicyViolationsPreviewsResponse : gaxgrpc::IPageResponse<OrgPolicyViolationsPreview>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<OrgPolicyViolationsPreview> GetEnumerator() => OrgPolicyViolationsPreviews.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListOrgPolicyViolationsResponse : gaxgrpc::IPageResponse<OrgPolicyViolation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<OrgPolicyViolation> GetEnumerator() => OrgPolicyViolations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class OrgPolicyViolationsPreviewService
    {
        public partial class OrgPolicyViolationsPreviewServiceClient
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
