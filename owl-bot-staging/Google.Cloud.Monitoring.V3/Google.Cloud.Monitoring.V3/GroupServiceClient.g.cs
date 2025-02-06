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
using ga = Google.Api;
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
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

namespace Google.Cloud.Monitoring.V3
{
    /// <summary>Settings for <see cref="GroupServiceClient"/> instances.</summary>
    public sealed partial class GroupServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="GroupServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="GroupServiceSettings"/>.</returns>
        public static GroupServiceSettings GetDefault() => new GroupServiceSettings();

        /// <summary>Constructs a new <see cref="GroupServiceSettings"/> object with default settings.</summary>
        public GroupServiceSettings()
        {
        }

        private GroupServiceSettings(GroupServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListGroupsSettings = existing.ListGroupsSettings;
            GetGroupSettings = existing.GetGroupSettings;
            CreateGroupSettings = existing.CreateGroupSettings;
            UpdateGroupSettings = existing.UpdateGroupSettings;
            DeleteGroupSettings = existing.DeleteGroupSettings;
            ListGroupMembersSettings = existing.ListGroupMembersSettings;
            OnCopy(existing);
        }

        partial void OnCopy(GroupServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GroupServiceClient.ListGroups</c> and <c>GroupServiceClient.ListGroupsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListGroupsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>GroupServiceClient.GetGroup</c>
        ///  and <c>GroupServiceClient.GetGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetGroupSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GroupServiceClient.CreateGroup</c> and <c>GroupServiceClient.CreateGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GroupServiceClient.UpdateGroup</c> and <c>GroupServiceClient.UpdateGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 180 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateGroupSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(180000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GroupServiceClient.DeleteGroup</c> and <c>GroupServiceClient.DeleteGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteGroupSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GroupServiceClient.ListGroupMembers</c> and <c>GroupServiceClient.ListGroupMembersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListGroupMembersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="GroupServiceSettings"/> object.</returns>
        public GroupServiceSettings Clone() => new GroupServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="GroupServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class GroupServiceClientBuilder : gaxgrpc::ClientBuilderBase<GroupServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public GroupServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public GroupServiceClientBuilder() : base(GroupServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref GroupServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<GroupServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override GroupServiceClient Build()
        {
            GroupServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<GroupServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<GroupServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private GroupServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return GroupServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<GroupServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return GroupServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => GroupServiceClient.ChannelPool;
    }

    /// <summary>GroupService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The Group API lets you inspect and manage your
    /// [groups](#google.monitoring.v3.Group).
    /// 
    /// A group is a named filter that is used to identify
    /// a collection of monitored resources. Groups are typically used to
    /// mirror the physical and/or logical topology of the environment.
    /// Because group membership is computed dynamically, monitored
    /// resources that are started in the future are automatically placed
    /// in matching groups. By using a group to name monitored resources in,
    /// for example, an alert policy, the target of that alert policy is
    /// updated automatically as monitored resources are added and removed
    /// from the infrastructure.
    /// </remarks>
    public abstract partial class GroupServiceClient
    {
        /// <summary>
        /// The default endpoint for the GroupService service, which is a host of "monitoring.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "monitoring.googleapis.com:443";

        /// <summary>The default GroupService scopes.</summary>
        /// <remarks>
        /// The default GroupService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/monitoring</description></item>
        /// <item><description>https://www.googleapis.com/auth/monitoring.read</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/monitoring",
            "https://www.googleapis.com/auth/monitoring.read",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(GroupService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="GroupServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="GroupServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="GroupServiceClient"/>.</returns>
        public static stt::Task<GroupServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new GroupServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="GroupServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="GroupServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="GroupServiceClient"/>.</returns>
        public static GroupServiceClient Create() => new GroupServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="GroupServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="GroupServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="GroupServiceClient"/>.</returns>
        internal static GroupServiceClient Create(grpccore::CallInvoker callInvoker, GroupServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            GroupService.GroupServiceClient grpcClient = new GroupService.GroupServiceClient(callInvoker);
            return new GroupServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC GroupService client</summary>
        public virtual GroupService.GroupServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the existing groups.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Group"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGroupsResponse, Group> ListGroups(ListGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the existing groups.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Group"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGroupsResponse, Group> ListGroupsAsync(ListGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the existing groups.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) whose
        /// groups are to be listed. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
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
        /// <returns>A pageable sequence of <see cref="Group"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGroupsResponse, Group> ListGroups(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGroupsRequest request = new ListGroupsRequest
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
            return ListGroups(request, callSettings);
        }

        /// <summary>
        /// Lists the existing groups.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) whose
        /// groups are to be listed. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
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
        /// <returns>A pageable asynchronous sequence of <see cref="Group"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGroupsResponse, Group> ListGroupsAsync(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGroupsRequest request = new ListGroupsRequest
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
            return ListGroupsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the existing groups.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) whose
        /// groups are to be listed. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
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
        /// <returns>A pageable sequence of <see cref="Group"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGroupsResponse, Group> ListGroups(gagr::ProjectName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGroupsRequest request = new ListGroupsRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGroups(request, callSettings);
        }

        /// <summary>
        /// Lists the existing groups.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) whose
        /// groups are to be listed. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
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
        /// <returns>A pageable asynchronous sequence of <see cref="Group"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGroupsResponse, Group> ListGroupsAsync(gagr::ProjectName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGroupsRequest request = new ListGroupsRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGroupsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the existing groups.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) whose
        /// groups are to be listed. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
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
        /// <returns>A pageable sequence of <see cref="Group"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGroupsResponse, Group> ListGroups(gagr::OrganizationName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGroupsRequest request = new ListGroupsRequest
            {
                OrganizationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGroups(request, callSettings);
        }

        /// <summary>
        /// Lists the existing groups.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) whose
        /// groups are to be listed. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
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
        /// <returns>A pageable asynchronous sequence of <see cref="Group"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGroupsResponse, Group> ListGroupsAsync(gagr::OrganizationName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGroupsRequest request = new ListGroupsRequest
            {
                OrganizationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGroupsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the existing groups.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) whose
        /// groups are to be listed. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
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
        /// <returns>A pageable sequence of <see cref="Group"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGroupsResponse, Group> ListGroups(gagr::FolderName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGroupsRequest request = new ListGroupsRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGroups(request, callSettings);
        }

        /// <summary>
        /// Lists the existing groups.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) whose
        /// groups are to be listed. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
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
        /// <returns>A pageable asynchronous sequence of <see cref="Group"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGroupsResponse, Group> ListGroupsAsync(gagr::FolderName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGroupsRequest request = new ListGroupsRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGroupsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the existing groups.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) whose
        /// groups are to be listed. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
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
        /// <returns>A pageable sequence of <see cref="Group"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGroupsResponse, Group> ListGroups(gax::IResourceName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGroupsRequest request = new ListGroupsRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGroups(request, callSettings);
        }

        /// <summary>
        /// Lists the existing groups.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) whose
        /// groups are to be listed. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
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
        /// <returns>A pageable asynchronous sequence of <see cref="Group"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGroupsResponse, Group> ListGroupsAsync(gax::IResourceName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGroupsRequest request = new ListGroupsRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGroupsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a single group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Group GetGroup(GetGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a single group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> GetGroupAsync(GetGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a single group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> GetGroupAsync(GetGroupRequest request, st::CancellationToken cancellationToken) =>
            GetGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single group.
        /// </summary>
        /// <param name="name">
        /// Required. The group to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/groups/[GROUP_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Group GetGroup(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGroup(new GetGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single group.
        /// </summary>
        /// <param name="name">
        /// Required. The group to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/groups/[GROUP_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> GetGroupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGroupAsync(new GetGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single group.
        /// </summary>
        /// <param name="name">
        /// Required. The group to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/groups/[GROUP_ID]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> GetGroupAsync(string name, st::CancellationToken cancellationToken) =>
            GetGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single group.
        /// </summary>
        /// <param name="name">
        /// Required. The group to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/groups/[GROUP_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Group GetGroup(GroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGroup(new GetGroupRequest
            {
                GroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single group.
        /// </summary>
        /// <param name="name">
        /// Required. The group to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/groups/[GROUP_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> GetGroupAsync(GroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGroupAsync(new GetGroupRequest
            {
                GroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single group.
        /// </summary>
        /// <param name="name">
        /// Required. The group to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/groups/[GROUP_ID]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> GetGroupAsync(GroupName name, st::CancellationToken cancellationToken) =>
            GetGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single group.
        /// </summary>
        /// <param name="name">
        /// Required. The group to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/groups/[GROUP_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Group GetGroup(gax::IResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGroup(new GetGroupRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single group.
        /// </summary>
        /// <param name="name">
        /// Required. The group to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/groups/[GROUP_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> GetGroupAsync(gax::IResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGroupAsync(new GetGroupRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single group.
        /// </summary>
        /// <param name="name">
        /// Required. The group to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/groups/[GROUP_ID]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> GetGroupAsync(gax::IResourceName name, st::CancellationToken cancellationToken) =>
            GetGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Group CreateGroup(CreateGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> CreateGroupAsync(CreateGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> CreateGroupAsync(CreateGroupRequest request, st::CancellationToken cancellationToken) =>
            CreateGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new group.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the group. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="group">
        /// Required. A group definition. It is an error to define the `name` field
        /// because the system assigns the name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Group CreateGroup(string name, Group group, gaxgrpc::CallSettings callSettings = null) =>
            CreateGroup(new CreateGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Group = gax::GaxPreconditions.CheckNotNull(group, nameof(group)),
            }, callSettings);

        /// <summary>
        /// Creates a new group.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the group. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="group">
        /// Required. A group definition. It is an error to define the `name` field
        /// because the system assigns the name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> CreateGroupAsync(string name, Group group, gaxgrpc::CallSettings callSettings = null) =>
            CreateGroupAsync(new CreateGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Group = gax::GaxPreconditions.CheckNotNull(group, nameof(group)),
            }, callSettings);

        /// <summary>
        /// Creates a new group.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the group. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="group">
        /// Required. A group definition. It is an error to define the `name` field
        /// because the system assigns the name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> CreateGroupAsync(string name, Group group, st::CancellationToken cancellationToken) =>
            CreateGroupAsync(name, group, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new group.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the group. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="group">
        /// Required. A group definition. It is an error to define the `name` field
        /// because the system assigns the name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Group CreateGroup(gagr::ProjectName name, Group group, gaxgrpc::CallSettings callSettings = null) =>
            CreateGroup(new CreateGroupRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Group = gax::GaxPreconditions.CheckNotNull(group, nameof(group)),
            }, callSettings);

        /// <summary>
        /// Creates a new group.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the group. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="group">
        /// Required. A group definition. It is an error to define the `name` field
        /// because the system assigns the name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> CreateGroupAsync(gagr::ProjectName name, Group group, gaxgrpc::CallSettings callSettings = null) =>
            CreateGroupAsync(new CreateGroupRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Group = gax::GaxPreconditions.CheckNotNull(group, nameof(group)),
            }, callSettings);

        /// <summary>
        /// Creates a new group.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the group. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="group">
        /// Required. A group definition. It is an error to define the `name` field
        /// because the system assigns the name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> CreateGroupAsync(gagr::ProjectName name, Group group, st::CancellationToken cancellationToken) =>
            CreateGroupAsync(name, group, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new group.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the group. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="group">
        /// Required. A group definition. It is an error to define the `name` field
        /// because the system assigns the name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Group CreateGroup(gagr::OrganizationName name, Group group, gaxgrpc::CallSettings callSettings = null) =>
            CreateGroup(new CreateGroupRequest
            {
                OrganizationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Group = gax::GaxPreconditions.CheckNotNull(group, nameof(group)),
            }, callSettings);

        /// <summary>
        /// Creates a new group.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the group. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="group">
        /// Required. A group definition. It is an error to define the `name` field
        /// because the system assigns the name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> CreateGroupAsync(gagr::OrganizationName name, Group group, gaxgrpc::CallSettings callSettings = null) =>
            CreateGroupAsync(new CreateGroupRequest
            {
                OrganizationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Group = gax::GaxPreconditions.CheckNotNull(group, nameof(group)),
            }, callSettings);

        /// <summary>
        /// Creates a new group.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the group. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="group">
        /// Required. A group definition. It is an error to define the `name` field
        /// because the system assigns the name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> CreateGroupAsync(gagr::OrganizationName name, Group group, st::CancellationToken cancellationToken) =>
            CreateGroupAsync(name, group, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new group.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the group. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="group">
        /// Required. A group definition. It is an error to define the `name` field
        /// because the system assigns the name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Group CreateGroup(gagr::FolderName name, Group group, gaxgrpc::CallSettings callSettings = null) =>
            CreateGroup(new CreateGroupRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Group = gax::GaxPreconditions.CheckNotNull(group, nameof(group)),
            }, callSettings);

        /// <summary>
        /// Creates a new group.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the group. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="group">
        /// Required. A group definition. It is an error to define the `name` field
        /// because the system assigns the name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> CreateGroupAsync(gagr::FolderName name, Group group, gaxgrpc::CallSettings callSettings = null) =>
            CreateGroupAsync(new CreateGroupRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Group = gax::GaxPreconditions.CheckNotNull(group, nameof(group)),
            }, callSettings);

        /// <summary>
        /// Creates a new group.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the group. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="group">
        /// Required. A group definition. It is an error to define the `name` field
        /// because the system assigns the name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> CreateGroupAsync(gagr::FolderName name, Group group, st::CancellationToken cancellationToken) =>
            CreateGroupAsync(name, group, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new group.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the group. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="group">
        /// Required. A group definition. It is an error to define the `name` field
        /// because the system assigns the name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Group CreateGroup(gax::IResourceName name, Group group, gaxgrpc::CallSettings callSettings = null) =>
            CreateGroup(new CreateGroupRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Group = gax::GaxPreconditions.CheckNotNull(group, nameof(group)),
            }, callSettings);

        /// <summary>
        /// Creates a new group.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the group. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="group">
        /// Required. A group definition. It is an error to define the `name` field
        /// because the system assigns the name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> CreateGroupAsync(gax::IResourceName name, Group group, gaxgrpc::CallSettings callSettings = null) =>
            CreateGroupAsync(new CreateGroupRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Group = gax::GaxPreconditions.CheckNotNull(group, nameof(group)),
            }, callSettings);

        /// <summary>
        /// Creates a new group.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) in which
        /// to create the group. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// </param>
        /// <param name="group">
        /// Required. A group definition. It is an error to define the `name` field
        /// because the system assigns the name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> CreateGroupAsync(gax::IResourceName name, Group group, st::CancellationToken cancellationToken) =>
            CreateGroupAsync(name, group, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing group.
        /// You can change any group attributes except `name`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Group UpdateGroup(UpdateGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing group.
        /// You can change any group attributes except `name`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> UpdateGroupAsync(UpdateGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing group.
        /// You can change any group attributes except `name`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> UpdateGroupAsync(UpdateGroupRequest request, st::CancellationToken cancellationToken) =>
            UpdateGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing group.
        /// You can change any group attributes except `name`.
        /// </summary>
        /// <param name="group">
        /// Required. The new definition of the group.  All fields of the existing
        /// group, excepting `name`, are replaced with the corresponding fields of this
        /// group.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Group UpdateGroup(Group group, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGroup(new UpdateGroupRequest
            {
                Group = gax::GaxPreconditions.CheckNotNull(group, nameof(group)),
            }, callSettings);

        /// <summary>
        /// Updates an existing group.
        /// You can change any group attributes except `name`.
        /// </summary>
        /// <param name="group">
        /// Required. The new definition of the group.  All fields of the existing
        /// group, excepting `name`, are replaced with the corresponding fields of this
        /// group.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> UpdateGroupAsync(Group group, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGroupAsync(new UpdateGroupRequest
            {
                Group = gax::GaxPreconditions.CheckNotNull(group, nameof(group)),
            }, callSettings);

        /// <summary>
        /// Updates an existing group.
        /// You can change any group attributes except `name`.
        /// </summary>
        /// <param name="group">
        /// Required. The new definition of the group.  All fields of the existing
        /// group, excepting `name`, are replaced with the corresponding fields of this
        /// group.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Group> UpdateGroupAsync(Group group, st::CancellationToken cancellationToken) =>
            UpdateGroupAsync(group, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteGroup(DeleteGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an existing group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGroupAsync(DeleteGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an existing group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGroupAsync(DeleteGroupRequest request, st::CancellationToken cancellationToken) =>
            DeleteGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing group.
        /// </summary>
        /// <param name="name">
        /// Required. The group to delete. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/groups/[GROUP_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteGroup(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGroup(new DeleteGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing group.
        /// </summary>
        /// <param name="name">
        /// Required. The group to delete. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/groups/[GROUP_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGroupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGroupAsync(new DeleteGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing group.
        /// </summary>
        /// <param name="name">
        /// Required. The group to delete. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/groups/[GROUP_ID]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGroupAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing group.
        /// </summary>
        /// <param name="name">
        /// Required. The group to delete. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/groups/[GROUP_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteGroup(GroupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGroup(new DeleteGroupRequest
            {
                GroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing group.
        /// </summary>
        /// <param name="name">
        /// Required. The group to delete. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/groups/[GROUP_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGroupAsync(GroupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGroupAsync(new DeleteGroupRequest
            {
                GroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing group.
        /// </summary>
        /// <param name="name">
        /// Required. The group to delete. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/groups/[GROUP_ID]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGroupAsync(GroupName name, st::CancellationToken cancellationToken) =>
            DeleteGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing group.
        /// </summary>
        /// <param name="name">
        /// Required. The group to delete. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/groups/[GROUP_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteGroup(gax::IResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGroup(new DeleteGroupRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing group.
        /// </summary>
        /// <param name="name">
        /// Required. The group to delete. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/groups/[GROUP_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGroupAsync(gax::IResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGroupAsync(new DeleteGroupRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing group.
        /// </summary>
        /// <param name="name">
        /// Required. The group to delete. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/groups/[GROUP_ID]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGroupAsync(gax::IResourceName name, st::CancellationToken cancellationToken) =>
            DeleteGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the monitored resources that are members of a group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ga::MonitoredResource"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGroupMembersResponse, ga::MonitoredResource> ListGroupMembers(ListGroupMembersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the monitored resources that are members of a group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ga::MonitoredResource"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGroupMembersResponse, ga::MonitoredResource> ListGroupMembersAsync(ListGroupMembersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the monitored resources that are members of a group.
        /// </summary>
        /// <param name="name">
        /// Required. The group whose members are listed. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/groups/[GROUP_ID]
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
        /// <returns>A pageable sequence of <see cref="ga::MonitoredResource"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGroupMembersResponse, ga::MonitoredResource> ListGroupMembers(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGroupMembersRequest request = new ListGroupMembersRequest
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
            return ListGroupMembers(request, callSettings);
        }

        /// <summary>
        /// Lists the monitored resources that are members of a group.
        /// </summary>
        /// <param name="name">
        /// Required. The group whose members are listed. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/groups/[GROUP_ID]
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
        /// <returns>A pageable asynchronous sequence of <see cref="ga::MonitoredResource"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGroupMembersResponse, ga::MonitoredResource> ListGroupMembersAsync(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGroupMembersRequest request = new ListGroupMembersRequest
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
            return ListGroupMembersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the monitored resources that are members of a group.
        /// </summary>
        /// <param name="name">
        /// Required. The group whose members are listed. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/groups/[GROUP_ID]
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
        /// <returns>A pageable sequence of <see cref="ga::MonitoredResource"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGroupMembersResponse, ga::MonitoredResource> ListGroupMembers(GroupName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGroupMembersRequest request = new ListGroupMembersRequest
            {
                GroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGroupMembers(request, callSettings);
        }

        /// <summary>
        /// Lists the monitored resources that are members of a group.
        /// </summary>
        /// <param name="name">
        /// Required. The group whose members are listed. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/groups/[GROUP_ID]
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
        /// <returns>A pageable asynchronous sequence of <see cref="ga::MonitoredResource"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGroupMembersResponse, ga::MonitoredResource> ListGroupMembersAsync(GroupName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGroupMembersRequest request = new ListGroupMembersRequest
            {
                GroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGroupMembersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the monitored resources that are members of a group.
        /// </summary>
        /// <param name="name">
        /// Required. The group whose members are listed. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/groups/[GROUP_ID]
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
        /// <returns>A pageable sequence of <see cref="ga::MonitoredResource"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGroupMembersResponse, ga::MonitoredResource> ListGroupMembers(gax::IResourceName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGroupMembersRequest request = new ListGroupMembersRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGroupMembers(request, callSettings);
        }

        /// <summary>
        /// Lists the monitored resources that are members of a group.
        /// </summary>
        /// <param name="name">
        /// Required. The group whose members are listed. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/groups/[GROUP_ID]
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
        /// <returns>A pageable asynchronous sequence of <see cref="ga::MonitoredResource"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGroupMembersResponse, ga::MonitoredResource> ListGroupMembersAsync(gax::IResourceName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGroupMembersRequest request = new ListGroupMembersRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGroupMembersAsync(request, callSettings);
        }
    }

    /// <summary>GroupService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The Group API lets you inspect and manage your
    /// [groups](#google.monitoring.v3.Group).
    /// 
    /// A group is a named filter that is used to identify
    /// a collection of monitored resources. Groups are typically used to
    /// mirror the physical and/or logical topology of the environment.
    /// Because group membership is computed dynamically, monitored
    /// resources that are started in the future are automatically placed
    /// in matching groups. By using a group to name monitored resources in,
    /// for example, an alert policy, the target of that alert policy is
    /// updated automatically as monitored resources are added and removed
    /// from the infrastructure.
    /// </remarks>
    public sealed partial class GroupServiceClientImpl : GroupServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListGroupsRequest, ListGroupsResponse> _callListGroups;

        private readonly gaxgrpc::ApiCall<GetGroupRequest, Group> _callGetGroup;

        private readonly gaxgrpc::ApiCall<CreateGroupRequest, Group> _callCreateGroup;

        private readonly gaxgrpc::ApiCall<UpdateGroupRequest, Group> _callUpdateGroup;

        private readonly gaxgrpc::ApiCall<DeleteGroupRequest, wkt::Empty> _callDeleteGroup;

        private readonly gaxgrpc::ApiCall<ListGroupMembersRequest, ListGroupMembersResponse> _callListGroupMembers;

        /// <summary>
        /// Constructs a client wrapper for the GroupService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="GroupServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public GroupServiceClientImpl(GroupService.GroupServiceClient grpcClient, GroupServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            GroupServiceSettings effectiveSettings = settings ?? GroupServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callListGroups = clientHelper.BuildApiCall<ListGroupsRequest, ListGroupsResponse>("ListGroups", grpcClient.ListGroupsAsync, grpcClient.ListGroups, effectiveSettings.ListGroupsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callListGroups);
            Modify_ListGroupsApiCall(ref _callListGroups);
            _callGetGroup = clientHelper.BuildApiCall<GetGroupRequest, Group>("GetGroup", grpcClient.GetGroupAsync, grpcClient.GetGroup, effectiveSettings.GetGroupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetGroup);
            Modify_GetGroupApiCall(ref _callGetGroup);
            _callCreateGroup = clientHelper.BuildApiCall<CreateGroupRequest, Group>("CreateGroup", grpcClient.CreateGroupAsync, grpcClient.CreateGroup, effectiveSettings.CreateGroupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCreateGroup);
            Modify_CreateGroupApiCall(ref _callCreateGroup);
            _callUpdateGroup = clientHelper.BuildApiCall<UpdateGroupRequest, Group>("UpdateGroup", grpcClient.UpdateGroupAsync, grpcClient.UpdateGroup, effectiveSettings.UpdateGroupSettings).WithGoogleRequestParam("group.name", request => request.Group?.Name);
            Modify_ApiCall(ref _callUpdateGroup);
            Modify_UpdateGroupApiCall(ref _callUpdateGroup);
            _callDeleteGroup = clientHelper.BuildApiCall<DeleteGroupRequest, wkt::Empty>("DeleteGroup", grpcClient.DeleteGroupAsync, grpcClient.DeleteGroup, effectiveSettings.DeleteGroupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteGroup);
            Modify_DeleteGroupApiCall(ref _callDeleteGroup);
            _callListGroupMembers = clientHelper.BuildApiCall<ListGroupMembersRequest, ListGroupMembersResponse>("ListGroupMembers", grpcClient.ListGroupMembersAsync, grpcClient.ListGroupMembers, effectiveSettings.ListGroupMembersSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callListGroupMembers);
            Modify_ListGroupMembersApiCall(ref _callListGroupMembers);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListGroupsApiCall(ref gaxgrpc::ApiCall<ListGroupsRequest, ListGroupsResponse> call);

        partial void Modify_GetGroupApiCall(ref gaxgrpc::ApiCall<GetGroupRequest, Group> call);

        partial void Modify_CreateGroupApiCall(ref gaxgrpc::ApiCall<CreateGroupRequest, Group> call);

        partial void Modify_UpdateGroupApiCall(ref gaxgrpc::ApiCall<UpdateGroupRequest, Group> call);

        partial void Modify_DeleteGroupApiCall(ref gaxgrpc::ApiCall<DeleteGroupRequest, wkt::Empty> call);

        partial void Modify_ListGroupMembersApiCall(ref gaxgrpc::ApiCall<ListGroupMembersRequest, ListGroupMembersResponse> call);

        partial void OnConstruction(GroupService.GroupServiceClient grpcClient, GroupServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC GroupService client</summary>
        public override GroupService.GroupServiceClient GrpcClient { get; }

        partial void Modify_ListGroupsRequest(ref ListGroupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetGroupRequest(ref GetGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateGroupRequest(ref CreateGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateGroupRequest(ref UpdateGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteGroupRequest(ref DeleteGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListGroupMembersRequest(ref ListGroupMembersRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists the existing groups.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Group"/> resources.</returns>
        public override gax::PagedEnumerable<ListGroupsResponse, Group> ListGroups(ListGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListGroupsRequest, ListGroupsResponse, Group>(_callListGroups, request, callSettings);
        }

        /// <summary>
        /// Lists the existing groups.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Group"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListGroupsResponse, Group> ListGroupsAsync(ListGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListGroupsRequest, ListGroupsResponse, Group>(_callListGroups, request, callSettings);
        }

        /// <summary>
        /// Gets a single group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Group GetGroup(GetGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGroupRequest(ref request, ref callSettings);
            return _callGetGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a single group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Group> GetGroupAsync(GetGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGroupRequest(ref request, ref callSettings);
            return _callGetGroup.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Group CreateGroup(CreateGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGroupRequest(ref request, ref callSettings);
            return _callCreateGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Group> CreateGroupAsync(CreateGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGroupRequest(ref request, ref callSettings);
            return _callCreateGroup.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an existing group.
        /// You can change any group attributes except `name`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Group UpdateGroup(UpdateGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGroupRequest(ref request, ref callSettings);
            return _callUpdateGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an existing group.
        /// You can change any group attributes except `name`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Group> UpdateGroupAsync(UpdateGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGroupRequest(ref request, ref callSettings);
            return _callUpdateGroup.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an existing group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteGroup(DeleteGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGroupRequest(ref request, ref callSettings);
            _callDeleteGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an existing group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteGroupAsync(DeleteGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGroupRequest(ref request, ref callSettings);
            return _callDeleteGroup.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the monitored resources that are members of a group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ga::MonitoredResource"/> resources.</returns>
        public override gax::PagedEnumerable<ListGroupMembersResponse, ga::MonitoredResource> ListGroupMembers(ListGroupMembersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGroupMembersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListGroupMembersRequest, ListGroupMembersResponse, ga::MonitoredResource>(_callListGroupMembers, request, callSettings);
        }

        /// <summary>
        /// Lists the monitored resources that are members of a group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ga::MonitoredResource"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListGroupMembersResponse, ga::MonitoredResource> ListGroupMembersAsync(ListGroupMembersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGroupMembersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListGroupMembersRequest, ListGroupMembersResponse, ga::MonitoredResource>(_callListGroupMembers, request, callSettings);
        }
    }

    public partial class ListGroupsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListGroupMembersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListGroupsResponse : gaxgrpc::IPageResponse<Group>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Group> GetEnumerator() => Group.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListGroupMembersResponse : gaxgrpc::IPageResponse<ga::MonitoredResource>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ga::MonitoredResource> GetEnumerator() => Members.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
