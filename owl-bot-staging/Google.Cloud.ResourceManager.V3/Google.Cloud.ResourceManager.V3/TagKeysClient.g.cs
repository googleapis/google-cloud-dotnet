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
using gciv = Google.Cloud.Iam.V1;
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

namespace Google.Cloud.ResourceManager.V3
{
    /// <summary>Settings for <see cref="TagKeysClient"/> instances.</summary>
    public sealed partial class TagKeysSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="TagKeysSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="TagKeysSettings"/>.</returns>
        public static TagKeysSettings GetDefault() => new TagKeysSettings();

        /// <summary>Constructs a new <see cref="TagKeysSettings"/> object with default settings.</summary>
        public TagKeysSettings()
        {
        }

        private TagKeysSettings(TagKeysSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListTagKeysSettings = existing.ListTagKeysSettings;
            GetTagKeySettings = existing.GetTagKeySettings;
            GetNamespacedTagKeySettings = existing.GetNamespacedTagKeySettings;
            CreateTagKeySettings = existing.CreateTagKeySettings;
            CreateTagKeyOperationsSettings = existing.CreateTagKeyOperationsSettings.Clone();
            UpdateTagKeySettings = existing.UpdateTagKeySettings;
            UpdateTagKeyOperationsSettings = existing.UpdateTagKeyOperationsSettings.Clone();
            DeleteTagKeySettings = existing.DeleteTagKeySettings;
            DeleteTagKeyOperationsSettings = existing.DeleteTagKeyOperationsSettings.Clone();
            GetIamPolicySettings = existing.GetIamPolicySettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(TagKeysSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>TagKeysClient.ListTagKeys</c>
        ///  and <c>TagKeysClient.ListTagKeysAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTagKeysSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>TagKeysClient.GetTagKey</c>
        /// and <c>TagKeysClient.GetTagKeyAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTagKeySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TagKeysClient.GetNamespacedTagKey</c> and <c>TagKeysClient.GetNamespacedTagKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetNamespacedTagKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>TagKeysClient.CreateTagKey</c>
        ///  and <c>TagKeysClient.CreateTagKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTagKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TagKeysClient.CreateTagKey</c> and
        /// <c>TagKeysClient.CreateTagKeyAsync</c>.
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
        public lro::OperationsSettings CreateTagKeyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>TagKeysClient.UpdateTagKey</c>
        ///  and <c>TagKeysClient.UpdateTagKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateTagKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TagKeysClient.UpdateTagKey</c> and
        /// <c>TagKeysClient.UpdateTagKeyAsync</c>.
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
        public lro::OperationsSettings UpdateTagKeyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>TagKeysClient.DeleteTagKey</c>
        ///  and <c>TagKeysClient.DeleteTagKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTagKeySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TagKeysClient.DeleteTagKey</c> and
        /// <c>TagKeysClient.DeleteTagKeyAsync</c>.
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
        public lro::OperationsSettings DeleteTagKeyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>TagKeysClient.GetIamPolicy</c>
        ///  and <c>TagKeysClient.GetIamPolicyAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>TagKeysClient.SetIamPolicy</c>
        ///  and <c>TagKeysClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TagKeysClient.TestIamPermissions</c> and <c>TagKeysClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="TagKeysSettings"/> object.</returns>
        public TagKeysSettings Clone() => new TagKeysSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="TagKeysClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class TagKeysClientBuilder : gaxgrpc::ClientBuilderBase<TagKeysClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public TagKeysSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public TagKeysClientBuilder() : base(TagKeysClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref TagKeysClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<TagKeysClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override TagKeysClient Build()
        {
            TagKeysClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<TagKeysClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<TagKeysClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private TagKeysClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return TagKeysClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<TagKeysClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TagKeysClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => TagKeysClient.ChannelPool;
    }

    /// <summary>TagKeys client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Allow users to create and manage tag keys.
    /// </remarks>
    public abstract partial class TagKeysClient
    {
        /// <summary>
        /// The default endpoint for the TagKeys service, which is a host of "cloudresourcemanager.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudresourcemanager.googleapis.com:443";

        /// <summary>The default TagKeys scopes.</summary>
        /// <remarks>
        /// The default TagKeys scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform.read-only</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(TagKeys.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="TagKeysClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="TagKeysClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="TagKeysClient"/>.</returns>
        public static stt::Task<TagKeysClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new TagKeysClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="TagKeysClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="TagKeysClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="TagKeysClient"/>.</returns>
        public static TagKeysClient Create() => new TagKeysClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="TagKeysClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="TagKeysSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="TagKeysClient"/>.</returns>
        internal static TagKeysClient Create(grpccore::CallInvoker callInvoker, TagKeysSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            TagKeys.TagKeysClient grpcClient = new TagKeys.TagKeysClient(callInvoker);
            return new TagKeysClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC TagKeys client</summary>
        public virtual TagKeys.TagKeysClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all TagKeys for a parent resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TagKey"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTagKeysResponse, TagKey> ListTagKeys(ListTagKeysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all TagKeys for a parent resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TagKey"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTagKeysResponse, TagKey> ListTagKeysAsync(ListTagKeysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all TagKeys for a parent resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TagKey's parent.
        /// Must be of the form `organizations/{org_id}` or `projects/{project_id}` or
        /// `projects/{project_number}`
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
        /// <returns>A pageable sequence of <see cref="TagKey"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTagKeysResponse, TagKey> ListTagKeys(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTagKeysRequest request = new ListTagKeysRequest
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
            return ListTagKeys(request, callSettings);
        }

        /// <summary>
        /// Lists all TagKeys for a parent resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TagKey's parent.
        /// Must be of the form `organizations/{org_id}` or `projects/{project_id}` or
        /// `projects/{project_number}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="TagKey"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTagKeysResponse, TagKey> ListTagKeysAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTagKeysRequest request = new ListTagKeysRequest
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
            return ListTagKeysAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all TagKeys for a parent resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TagKey's parent.
        /// Must be of the form `organizations/{org_id}` or `projects/{project_id}` or
        /// `projects/{project_number}`
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
        /// <returns>A pageable sequence of <see cref="TagKey"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTagKeysResponse, TagKey> ListTagKeys(gax::IResourceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTagKeysRequest request = new ListTagKeysRequest
            {
                ParentAsResourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTagKeys(request, callSettings);
        }

        /// <summary>
        /// Lists all TagKeys for a parent resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the TagKey's parent.
        /// Must be of the form `organizations/{org_id}` or `projects/{project_id}` or
        /// `projects/{project_number}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="TagKey"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTagKeysResponse, TagKey> ListTagKeysAsync(gax::IResourceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTagKeysRequest request = new ListTagKeysRequest
            {
                ParentAsResourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTagKeysAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a TagKey. This method will return `PERMISSION_DENIED` if the
        /// key does not exist or the user does not have permission to view it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TagKey GetTagKey(GetTagKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a TagKey. This method will return `PERMISSION_DENIED` if the
        /// key does not exist or the user does not have permission to view it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagKey> GetTagKeyAsync(GetTagKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a TagKey. This method will return `PERMISSION_DENIED` if the
        /// key does not exist or the user does not have permission to view it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagKey> GetTagKeyAsync(GetTagKeyRequest request, st::CancellationToken cancellationToken) =>
            GetTagKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a TagKey. This method will return `PERMISSION_DENIED` if the
        /// key does not exist or the user does not have permission to view it.
        /// </summary>
        /// <param name="name">
        /// Required. A resource name in the format `tagKeys/{id}`, such as
        /// `tagKeys/123`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TagKey GetTagKey(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTagKey(new GetTagKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a TagKey. This method will return `PERMISSION_DENIED` if the
        /// key does not exist or the user does not have permission to view it.
        /// </summary>
        /// <param name="name">
        /// Required. A resource name in the format `tagKeys/{id}`, such as
        /// `tagKeys/123`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagKey> GetTagKeyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTagKeyAsync(new GetTagKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a TagKey. This method will return `PERMISSION_DENIED` if the
        /// key does not exist or the user does not have permission to view it.
        /// </summary>
        /// <param name="name">
        /// Required. A resource name in the format `tagKeys/{id}`, such as
        /// `tagKeys/123`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagKey> GetTagKeyAsync(string name, st::CancellationToken cancellationToken) =>
            GetTagKeyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a TagKey. This method will return `PERMISSION_DENIED` if the
        /// key does not exist or the user does not have permission to view it.
        /// </summary>
        /// <param name="name">
        /// Required. A resource name in the format `tagKeys/{id}`, such as
        /// `tagKeys/123`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TagKey GetTagKey(TagKeyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTagKey(new GetTagKeyRequest
            {
                TagKeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a TagKey. This method will return `PERMISSION_DENIED` if the
        /// key does not exist or the user does not have permission to view it.
        /// </summary>
        /// <param name="name">
        /// Required. A resource name in the format `tagKeys/{id}`, such as
        /// `tagKeys/123`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagKey> GetTagKeyAsync(TagKeyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTagKeyAsync(new GetTagKeyRequest
            {
                TagKeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a TagKey. This method will return `PERMISSION_DENIED` if the
        /// key does not exist or the user does not have permission to view it.
        /// </summary>
        /// <param name="name">
        /// Required. A resource name in the format `tagKeys/{id}`, such as
        /// `tagKeys/123`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagKey> GetTagKeyAsync(TagKeyName name, st::CancellationToken cancellationToken) =>
            GetTagKeyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a TagKey by its namespaced name.
        /// This method will return `PERMISSION_DENIED` if the key does not exist
        /// or the user does not have permission to view it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TagKey GetNamespacedTagKey(GetNamespacedTagKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a TagKey by its namespaced name.
        /// This method will return `PERMISSION_DENIED` if the key does not exist
        /// or the user does not have permission to view it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagKey> GetNamespacedTagKeyAsync(GetNamespacedTagKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a TagKey by its namespaced name.
        /// This method will return `PERMISSION_DENIED` if the key does not exist
        /// or the user does not have permission to view it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagKey> GetNamespacedTagKeyAsync(GetNamespacedTagKeyRequest request, st::CancellationToken cancellationToken) =>
            GetNamespacedTagKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a TagKey by its namespaced name.
        /// This method will return `PERMISSION_DENIED` if the key does not exist
        /// or the user does not have permission to view it.
        /// </summary>
        /// <param name="name">
        /// Required. A namespaced tag key name in the format
        /// `{parentId}/{tagKeyShort}`, such as `42/foo` for a key with short name
        /// "foo" under the organization with ID 42 or `r2-d2/bar` for a key with short
        /// name "bar" under the project `r2-d2`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TagKey GetNamespacedTagKey(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNamespacedTagKey(new GetNamespacedTagKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a TagKey by its namespaced name.
        /// This method will return `PERMISSION_DENIED` if the key does not exist
        /// or the user does not have permission to view it.
        /// </summary>
        /// <param name="name">
        /// Required. A namespaced tag key name in the format
        /// `{parentId}/{tagKeyShort}`, such as `42/foo` for a key with short name
        /// "foo" under the organization with ID 42 or `r2-d2/bar` for a key with short
        /// name "bar" under the project `r2-d2`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagKey> GetNamespacedTagKeyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNamespacedTagKeyAsync(new GetNamespacedTagKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a TagKey by its namespaced name.
        /// This method will return `PERMISSION_DENIED` if the key does not exist
        /// or the user does not have permission to view it.
        /// </summary>
        /// <param name="name">
        /// Required. A namespaced tag key name in the format
        /// `{parentId}/{tagKeyShort}`, such as `42/foo` for a key with short name
        /// "foo" under the organization with ID 42 or `r2-d2/bar` for a key with short
        /// name "bar" under the project `r2-d2`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagKey> GetNamespacedTagKeyAsync(string name, st::CancellationToken cancellationToken) =>
            GetNamespacedTagKeyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a TagKey by its namespaced name.
        /// This method will return `PERMISSION_DENIED` if the key does not exist
        /// or the user does not have permission to view it.
        /// </summary>
        /// <param name="name">
        /// Required. A namespaced tag key name in the format
        /// `{parentId}/{tagKeyShort}`, such as `42/foo` for a key with short name
        /// "foo" under the organization with ID 42 or `r2-d2/bar` for a key with short
        /// name "bar" under the project `r2-d2`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TagKey GetNamespacedTagKey(TagKeyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNamespacedTagKey(new GetNamespacedTagKeyRequest
            {
                TagKeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a TagKey by its namespaced name.
        /// This method will return `PERMISSION_DENIED` if the key does not exist
        /// or the user does not have permission to view it.
        /// </summary>
        /// <param name="name">
        /// Required. A namespaced tag key name in the format
        /// `{parentId}/{tagKeyShort}`, such as `42/foo` for a key with short name
        /// "foo" under the organization with ID 42 or `r2-d2/bar` for a key with short
        /// name "bar" under the project `r2-d2`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagKey> GetNamespacedTagKeyAsync(TagKeyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNamespacedTagKeyAsync(new GetNamespacedTagKeyRequest
            {
                TagKeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a TagKey by its namespaced name.
        /// This method will return `PERMISSION_DENIED` if the key does not exist
        /// or the user does not have permission to view it.
        /// </summary>
        /// <param name="name">
        /// Required. A namespaced tag key name in the format
        /// `{parentId}/{tagKeyShort}`, such as `42/foo` for a key with short name
        /// "foo" under the organization with ID 42 or `r2-d2/bar` for a key with short
        /// name "bar" under the project `r2-d2`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagKey> GetNamespacedTagKeyAsync(TagKeyName name, st::CancellationToken cancellationToken) =>
            GetNamespacedTagKeyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new TagKey. If another request with the same parameters is
        /// sent while the original request is in process, the second request
        /// will receive an error. A maximum of 1000 TagKeys can exist under a parent
        /// at any given time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TagKey, CreateTagKeyMetadata> CreateTagKey(CreateTagKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new TagKey. If another request with the same parameters is
        /// sent while the original request is in process, the second request
        /// will receive an error. A maximum of 1000 TagKeys can exist under a parent
        /// at any given time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TagKey, CreateTagKeyMetadata>> CreateTagKeyAsync(CreateTagKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new TagKey. If another request with the same parameters is
        /// sent while the original request is in process, the second request
        /// will receive an error. A maximum of 1000 TagKeys can exist under a parent
        /// at any given time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TagKey, CreateTagKeyMetadata>> CreateTagKeyAsync(CreateTagKeyRequest request, st::CancellationToken cancellationToken) =>
            CreateTagKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateTagKey</c>.</summary>
        public virtual lro::OperationsClient CreateTagKeyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateTagKey</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<TagKey, CreateTagKeyMetadata> PollOnceCreateTagKey(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TagKey, CreateTagKeyMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateTagKeyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateTagKey</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<TagKey, CreateTagKeyMetadata>> PollOnceCreateTagKeyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TagKey, CreateTagKeyMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateTagKeyOperationsClient, callSettings);

        /// <summary>
        /// Creates a new TagKey. If another request with the same parameters is
        /// sent while the original request is in process, the second request
        /// will receive an error. A maximum of 1000 TagKeys can exist under a parent
        /// at any given time.
        /// </summary>
        /// <param name="tagKey">
        /// Required. The TagKey to be created. Only fields `short_name`,
        /// `description`, and `parent` are considered during the creation request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TagKey, CreateTagKeyMetadata> CreateTagKey(TagKey tagKey, gaxgrpc::CallSettings callSettings = null) =>
            CreateTagKey(new CreateTagKeyRequest
            {
                TagKey = gax::GaxPreconditions.CheckNotNull(tagKey, nameof(tagKey)),
            }, callSettings);

        /// <summary>
        /// Creates a new TagKey. If another request with the same parameters is
        /// sent while the original request is in process, the second request
        /// will receive an error. A maximum of 1000 TagKeys can exist under a parent
        /// at any given time.
        /// </summary>
        /// <param name="tagKey">
        /// Required. The TagKey to be created. Only fields `short_name`,
        /// `description`, and `parent` are considered during the creation request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TagKey, CreateTagKeyMetadata>> CreateTagKeyAsync(TagKey tagKey, gaxgrpc::CallSettings callSettings = null) =>
            CreateTagKeyAsync(new CreateTagKeyRequest
            {
                TagKey = gax::GaxPreconditions.CheckNotNull(tagKey, nameof(tagKey)),
            }, callSettings);

        /// <summary>
        /// Creates a new TagKey. If another request with the same parameters is
        /// sent while the original request is in process, the second request
        /// will receive an error. A maximum of 1000 TagKeys can exist under a parent
        /// at any given time.
        /// </summary>
        /// <param name="tagKey">
        /// Required. The TagKey to be created. Only fields `short_name`,
        /// `description`, and `parent` are considered during the creation request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TagKey, CreateTagKeyMetadata>> CreateTagKeyAsync(TagKey tagKey, st::CancellationToken cancellationToken) =>
            CreateTagKeyAsync(tagKey, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the attributes of the TagKey resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TagKey, UpdateTagKeyMetadata> UpdateTagKey(UpdateTagKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the attributes of the TagKey resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TagKey, UpdateTagKeyMetadata>> UpdateTagKeyAsync(UpdateTagKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the attributes of the TagKey resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TagKey, UpdateTagKeyMetadata>> UpdateTagKeyAsync(UpdateTagKeyRequest request, st::CancellationToken cancellationToken) =>
            UpdateTagKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateTagKey</c>.</summary>
        public virtual lro::OperationsClient UpdateTagKeyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateTagKey</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<TagKey, UpdateTagKeyMetadata> PollOnceUpdateTagKey(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TagKey, UpdateTagKeyMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateTagKeyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateTagKey</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<TagKey, UpdateTagKeyMetadata>> PollOnceUpdateTagKeyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TagKey, UpdateTagKeyMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateTagKeyOperationsClient, callSettings);

        /// <summary>
        /// Updates the attributes of the TagKey resource.
        /// </summary>
        /// <param name="tagKey">
        /// Required. The new definition of the TagKey. Only the `description` and
        /// `etag` fields can be updated by this request. If the `etag` field is not
        /// empty, it must match the `etag` field of the existing tag key. Otherwise,
        /// `ABORTED` will be returned.
        /// </param>
        /// <param name="updateMask">
        /// Fields to be updated. The mask may only contain `description` or
        /// `etag`. If omitted entirely, both `description` and `etag` are assumed to
        /// be significant.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TagKey, UpdateTagKeyMetadata> UpdateTagKey(TagKey tagKey, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTagKey(new UpdateTagKeyRequest
            {
                TagKey = gax::GaxPreconditions.CheckNotNull(tagKey, nameof(tagKey)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the attributes of the TagKey resource.
        /// </summary>
        /// <param name="tagKey">
        /// Required. The new definition of the TagKey. Only the `description` and
        /// `etag` fields can be updated by this request. If the `etag` field is not
        /// empty, it must match the `etag` field of the existing tag key. Otherwise,
        /// `ABORTED` will be returned.
        /// </param>
        /// <param name="updateMask">
        /// Fields to be updated. The mask may only contain `description` or
        /// `etag`. If omitted entirely, both `description` and `etag` are assumed to
        /// be significant.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TagKey, UpdateTagKeyMetadata>> UpdateTagKeyAsync(TagKey tagKey, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTagKeyAsync(new UpdateTagKeyRequest
            {
                TagKey = gax::GaxPreconditions.CheckNotNull(tagKey, nameof(tagKey)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the attributes of the TagKey resource.
        /// </summary>
        /// <param name="tagKey">
        /// Required. The new definition of the TagKey. Only the `description` and
        /// `etag` fields can be updated by this request. If the `etag` field is not
        /// empty, it must match the `etag` field of the existing tag key. Otherwise,
        /// `ABORTED` will be returned.
        /// </param>
        /// <param name="updateMask">
        /// Fields to be updated. The mask may only contain `description` or
        /// `etag`. If omitted entirely, both `description` and `etag` are assumed to
        /// be significant.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TagKey, UpdateTagKeyMetadata>> UpdateTagKeyAsync(TagKey tagKey, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateTagKeyAsync(tagKey, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a TagKey. The TagKey cannot be deleted if it has any child
        /// TagValues.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TagKey, DeleteTagKeyMetadata> DeleteTagKey(DeleteTagKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a TagKey. The TagKey cannot be deleted if it has any child
        /// TagValues.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TagKey, DeleteTagKeyMetadata>> DeleteTagKeyAsync(DeleteTagKeyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a TagKey. The TagKey cannot be deleted if it has any child
        /// TagValues.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TagKey, DeleteTagKeyMetadata>> DeleteTagKeyAsync(DeleteTagKeyRequest request, st::CancellationToken cancellationToken) =>
            DeleteTagKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteTagKey</c>.</summary>
        public virtual lro::OperationsClient DeleteTagKeyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteTagKey</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<TagKey, DeleteTagKeyMetadata> PollOnceDeleteTagKey(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TagKey, DeleteTagKeyMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteTagKeyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteTagKey</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<TagKey, DeleteTagKeyMetadata>> PollOnceDeleteTagKeyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TagKey, DeleteTagKeyMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteTagKeyOperationsClient, callSettings);

        /// <summary>
        /// Deletes a TagKey. The TagKey cannot be deleted if it has any child
        /// TagValues.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of a TagKey to be deleted in the format
        /// `tagKeys/123`. The TagKey cannot be a parent of any existing TagValues or
        /// it will not be deleted successfully.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TagKey, DeleteTagKeyMetadata> DeleteTagKey(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTagKey(new DeleteTagKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a TagKey. The TagKey cannot be deleted if it has any child
        /// TagValues.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of a TagKey to be deleted in the format
        /// `tagKeys/123`. The TagKey cannot be a parent of any existing TagValues or
        /// it will not be deleted successfully.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TagKey, DeleteTagKeyMetadata>> DeleteTagKeyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTagKeyAsync(new DeleteTagKeyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a TagKey. The TagKey cannot be deleted if it has any child
        /// TagValues.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of a TagKey to be deleted in the format
        /// `tagKeys/123`. The TagKey cannot be a parent of any existing TagValues or
        /// it will not be deleted successfully.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TagKey, DeleteTagKeyMetadata>> DeleteTagKeyAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteTagKeyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a TagKey. The TagKey cannot be deleted if it has any child
        /// TagValues.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of a TagKey to be deleted in the format
        /// `tagKeys/123`. The TagKey cannot be a parent of any existing TagValues or
        /// it will not be deleted successfully.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TagKey, DeleteTagKeyMetadata> DeleteTagKey(TagKeyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTagKey(new DeleteTagKeyRequest
            {
                TagKeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a TagKey. The TagKey cannot be deleted if it has any child
        /// TagValues.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of a TagKey to be deleted in the format
        /// `tagKeys/123`. The TagKey cannot be a parent of any existing TagValues or
        /// it will not be deleted successfully.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TagKey, DeleteTagKeyMetadata>> DeleteTagKeyAsync(TagKeyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTagKeyAsync(new DeleteTagKeyRequest
            {
                TagKeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a TagKey. The TagKey cannot be deleted if it has any child
        /// TagValues.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of a TagKey to be deleted in the format
        /// `tagKeys/123`. The TagKey cannot be a parent of any existing TagValues or
        /// it will not be deleted successfully.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TagKey, DeleteTagKeyMetadata>> DeleteTagKeyAsync(TagKeyName name, st::CancellationToken cancellationToken) =>
            DeleteTagKeyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a TagKey. The returned policy may be
        /// empty if no such policy or resource exists. The `resource` field should
        /// be the TagKey's resource name. For example, "tagKeys/1234".
        /// The caller must have
        /// `cloudresourcemanager.googleapis.com/tagKeys.getIamPolicy` permission on
        /// the specified TagKey.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for a TagKey. The returned policy may be
        /// empty if no such policy or resource exists. The `resource` field should
        /// be the TagKey's resource name. For example, "tagKeys/1234".
        /// The caller must have
        /// `cloudresourcemanager.googleapis.com/tagKeys.getIamPolicy` permission on
        /// the specified TagKey.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for a TagKey. The returned policy may be
        /// empty if no such policy or resource exists. The `resource` field should
        /// be the TagKey's resource name. For example, "tagKeys/1234".
        /// The caller must have
        /// `cloudresourcemanager.googleapis.com/tagKeys.getIamPolicy` permission on
        /// the specified TagKey.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a TagKey. The returned policy may be
        /// empty if no such policy or resource exists. The `resource` field should
        /// be the TagKey's resource name. For example, "tagKeys/1234".
        /// The caller must have
        /// `cloudresourcemanager.googleapis.com/tagKeys.getIamPolicy` permission on
        /// the specified TagKey.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new gciv::GetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a TagKey. The returned policy may be
        /// empty if no such policy or resource exists. The `resource` field should
        /// be the TagKey's resource name. For example, "tagKeys/1234".
        /// The caller must have
        /// `cloudresourcemanager.googleapis.com/tagKeys.getIamPolicy` permission on
        /// the specified TagKey.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new gciv::GetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a TagKey. The returned policy may be
        /// empty if no such policy or resource exists. The `resource` field should
        /// be the TagKey's resource name. For example, "tagKeys/1234".
        /// The caller must have
        /// `cloudresourcemanager.googleapis.com/tagKeys.getIamPolicy` permission on
        /// the specified TagKey.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(string resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a TagKey. The returned policy may be
        /// empty if no such policy or resource exists. The `resource` field should
        /// be the TagKey's resource name. For example, "tagKeys/1234".
        /// The caller must have
        /// `cloudresourcemanager.googleapis.com/tagKeys.getIamPolicy` permission on
        /// the specified TagKey.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a TagKey. The returned policy may be
        /// empty if no such policy or resource exists. The `resource` field should
        /// be the TagKey's resource name. For example, "tagKeys/1234".
        /// The caller must have
        /// `cloudresourcemanager.googleapis.com/tagKeys.getIamPolicy` permission on
        /// the specified TagKey.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a TagKey. The returned policy may be
        /// empty if no such policy or resource exists. The `resource` field should
        /// be the TagKey's resource name. For example, "tagKeys/1234".
        /// The caller must have
        /// `cloudresourcemanager.googleapis.com/tagKeys.getIamPolicy` permission on
        /// the specified TagKey.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gax::IResourceName resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on a TagKey, replacing any existing
        /// policy. The `resource` field should be the TagKey's resource name.
        /// For example, "tagKeys/1234".
        /// The caller must have `resourcemanager.tagKeys.setIamPolicy` permission
        /// on the identified tagValue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on a TagKey, replacing any existing
        /// policy. The `resource` field should be the TagKey's resource name.
        /// For example, "tagKeys/1234".
        /// The caller must have `resourcemanager.tagKeys.setIamPolicy` permission
        /// on the identified tagValue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on a TagKey, replacing any existing
        /// policy. The `resource` field should be the TagKey's resource name.
        /// For example, "tagKeys/1234".
        /// The caller must have `resourcemanager.tagKeys.setIamPolicy` permission
        /// on the identified tagValue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on a TagKey, replacing any existing
        /// policy. The `resource` field should be the TagKey's resource name.
        /// For example, "tagKeys/1234".
        /// The caller must have `resourcemanager.tagKeys.setIamPolicy` permission
        /// on the identified tagValue.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(string resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicy(new gciv::SetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy on a TagKey, replacing any existing
        /// policy. The `resource` field should be the TagKey's resource name.
        /// For example, "tagKeys/1234".
        /// The caller must have `resourcemanager.tagKeys.setIamPolicy` permission
        /// on the identified tagValue.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(string resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyAsync(new gciv::SetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy on a TagKey, replacing any existing
        /// policy. The `resource` field should be the TagKey's resource name.
        /// For example, "tagKeys/1234".
        /// The caller must have `resourcemanager.tagKeys.setIamPolicy` permission
        /// on the identified tagValue.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(string resource, gciv::Policy policy, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(resource, policy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on a TagKey, replacing any existing
        /// policy. The `resource` field should be the TagKey's resource name.
        /// For example, "tagKeys/1234".
        /// The caller must have `resourcemanager.tagKeys.setIamPolicy` permission
        /// on the identified tagValue.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gax::IResourceName resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicy(new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy on a TagKey, replacing any existing
        /// policy. The `resource` field should be the TagKey's resource name.
        /// For example, "tagKeys/1234".
        /// The caller must have `resourcemanager.tagKeys.setIamPolicy` permission
        /// on the identified tagValue.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gax::IResourceName resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyAsync(new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy on a TagKey, replacing any existing
        /// policy. The `resource` field should be the TagKey's resource name.
        /// For example, "tagKeys/1234".
        /// The caller must have `resourcemanager.tagKeys.setIamPolicy` permission
        /// on the identified tagValue.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gax::IResourceName resource, gciv::Policy policy, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(resource, policy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on the specified TagKey.
        /// The `resource` field should be the TagKey's resource name.
        /// For example, "tagKeys/1234".
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that a caller has on the specified TagKey.
        /// The `resource` field should be the TagKey's resource name.
        /// For example, "tagKeys/1234".
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that a caller has on the specified TagKey.
        /// The `resource` field should be the TagKey's resource name.
        /// For example, "tagKeys/1234".
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on the specified TagKey.
        /// The `resource` field should be the TagKey's resource name.
        /// For example, "tagKeys/1234".
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(string resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissions(new gciv::TestIamPermissionsRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Returns permissions that a caller has on the specified TagKey.
        /// The `resource` field should be the TagKey's resource name.
        /// For example, "tagKeys/1234".
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(string resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissionsAsync(new gciv::TestIamPermissionsRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Returns permissions that a caller has on the specified TagKey.
        /// The `resource` field should be the TagKey's resource name.
        /// For example, "tagKeys/1234".
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(string resource, scg::IEnumerable<string> permissions, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(resource, permissions, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on the specified TagKey.
        /// The `resource` field should be the TagKey's resource name.
        /// For example, "tagKeys/1234".
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gax::IResourceName resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissions(new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Returns permissions that a caller has on the specified TagKey.
        /// The `resource` field should be the TagKey's resource name.
        /// For example, "tagKeys/1234".
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gax::IResourceName resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissionsAsync(new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Returns permissions that a caller has on the specified TagKey.
        /// The `resource` field should be the TagKey's resource name.
        /// For example, "tagKeys/1234".
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gax::IResourceName resource, scg::IEnumerable<string> permissions, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(resource, permissions, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>TagKeys client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Allow users to create and manage tag keys.
    /// </remarks>
    public sealed partial class TagKeysClientImpl : TagKeysClient
    {
        private readonly gaxgrpc::ApiCall<ListTagKeysRequest, ListTagKeysResponse> _callListTagKeys;

        private readonly gaxgrpc::ApiCall<GetTagKeyRequest, TagKey> _callGetTagKey;

        private readonly gaxgrpc::ApiCall<GetNamespacedTagKeyRequest, TagKey> _callGetNamespacedTagKey;

        private readonly gaxgrpc::ApiCall<CreateTagKeyRequest, lro::Operation> _callCreateTagKey;

        private readonly gaxgrpc::ApiCall<UpdateTagKeyRequest, lro::Operation> _callUpdateTagKey;

        private readonly gaxgrpc::ApiCall<DeleteTagKeyRequest, lro::Operation> _callDeleteTagKey;

        private readonly gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> _callGetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> _callSetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> _callTestIamPermissions;

        /// <summary>
        /// Constructs a client wrapper for the TagKeys service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="TagKeysSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public TagKeysClientImpl(TagKeys.TagKeysClient grpcClient, TagKeysSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            TagKeysSettings effectiveSettings = settings ?? TagKeysSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateTagKeyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateTagKeyOperationsSettings, logger);
            UpdateTagKeyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateTagKeyOperationsSettings, logger);
            DeleteTagKeyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteTagKeyOperationsSettings, logger);
            _callListTagKeys = clientHelper.BuildApiCall<ListTagKeysRequest, ListTagKeysResponse>("ListTagKeys", grpcClient.ListTagKeysAsync, grpcClient.ListTagKeys, effectiveSettings.ListTagKeysSettings);
            Modify_ApiCall(ref _callListTagKeys);
            Modify_ListTagKeysApiCall(ref _callListTagKeys);
            _callGetTagKey = clientHelper.BuildApiCall<GetTagKeyRequest, TagKey>("GetTagKey", grpcClient.GetTagKeyAsync, grpcClient.GetTagKey, effectiveSettings.GetTagKeySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTagKey);
            Modify_GetTagKeyApiCall(ref _callGetTagKey);
            _callGetNamespacedTagKey = clientHelper.BuildApiCall<GetNamespacedTagKeyRequest, TagKey>("GetNamespacedTagKey", grpcClient.GetNamespacedTagKeyAsync, grpcClient.GetNamespacedTagKey, effectiveSettings.GetNamespacedTagKeySettings);
            Modify_ApiCall(ref _callGetNamespacedTagKey);
            Modify_GetNamespacedTagKeyApiCall(ref _callGetNamespacedTagKey);
            _callCreateTagKey = clientHelper.BuildApiCall<CreateTagKeyRequest, lro::Operation>("CreateTagKey", grpcClient.CreateTagKeyAsync, grpcClient.CreateTagKey, effectiveSettings.CreateTagKeySettings);
            Modify_ApiCall(ref _callCreateTagKey);
            Modify_CreateTagKeyApiCall(ref _callCreateTagKey);
            _callUpdateTagKey = clientHelper.BuildApiCall<UpdateTagKeyRequest, lro::Operation>("UpdateTagKey", grpcClient.UpdateTagKeyAsync, grpcClient.UpdateTagKey, effectiveSettings.UpdateTagKeySettings).WithGoogleRequestParam("tag_key.name", request => request.TagKey?.Name);
            Modify_ApiCall(ref _callUpdateTagKey);
            Modify_UpdateTagKeyApiCall(ref _callUpdateTagKey);
            _callDeleteTagKey = clientHelper.BuildApiCall<DeleteTagKeyRequest, lro::Operation>("DeleteTagKey", grpcClient.DeleteTagKeyAsync, grpcClient.DeleteTagKey, effectiveSettings.DeleteTagKeySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTagKey);
            Modify_DeleteTagKeyApiCall(ref _callDeleteTagKey);
            _callGetIamPolicy = clientHelper.BuildApiCall<gciv::GetIamPolicyRequest, gciv::Policy>("GetIamPolicy", grpcClient.GetIamPolicyAsync, grpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            _callSetIamPolicy = clientHelper.BuildApiCall<gciv::SetIamPolicyRequest, gciv::Policy>("SetIamPolicy", grpcClient.SetIamPolicyAsync, grpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            _callTestIamPermissions = clientHelper.BuildApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse>("TestIamPermissions", grpcClient.TestIamPermissionsAsync, grpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListTagKeysApiCall(ref gaxgrpc::ApiCall<ListTagKeysRequest, ListTagKeysResponse> call);

        partial void Modify_GetTagKeyApiCall(ref gaxgrpc::ApiCall<GetTagKeyRequest, TagKey> call);

        partial void Modify_GetNamespacedTagKeyApiCall(ref gaxgrpc::ApiCall<GetNamespacedTagKeyRequest, TagKey> call);

        partial void Modify_CreateTagKeyApiCall(ref gaxgrpc::ApiCall<CreateTagKeyRequest, lro::Operation> call);

        partial void Modify_UpdateTagKeyApiCall(ref gaxgrpc::ApiCall<UpdateTagKeyRequest, lro::Operation> call);

        partial void Modify_DeleteTagKeyApiCall(ref gaxgrpc::ApiCall<DeleteTagKeyRequest, lro::Operation> call);

        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> call);

        partial void OnConstruction(TagKeys.TagKeysClient grpcClient, TagKeysSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC TagKeys client</summary>
        public override TagKeys.TagKeysClient GrpcClient { get; }

        partial void Modify_ListTagKeysRequest(ref ListTagKeysRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTagKeyRequest(ref GetTagKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetNamespacedTagKeyRequest(ref GetNamespacedTagKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTagKeyRequest(ref CreateTagKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTagKeyRequest(ref UpdateTagKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTagKeyRequest(ref DeleteTagKeyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIamPolicyRequest(ref gciv::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetIamPolicyRequest(ref gciv::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsRequest(ref gciv::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists all TagKeys for a parent resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TagKey"/> resources.</returns>
        public override gax::PagedEnumerable<ListTagKeysResponse, TagKey> ListTagKeys(ListTagKeysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTagKeysRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTagKeysRequest, ListTagKeysResponse, TagKey>(_callListTagKeys, request, callSettings);
        }

        /// <summary>
        /// Lists all TagKeys for a parent resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TagKey"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTagKeysResponse, TagKey> ListTagKeysAsync(ListTagKeysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTagKeysRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTagKeysRequest, ListTagKeysResponse, TagKey>(_callListTagKeys, request, callSettings);
        }

        /// <summary>
        /// Retrieves a TagKey. This method will return `PERMISSION_DENIED` if the
        /// key does not exist or the user does not have permission to view it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TagKey GetTagKey(GetTagKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTagKeyRequest(ref request, ref callSettings);
            return _callGetTagKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a TagKey. This method will return `PERMISSION_DENIED` if the
        /// key does not exist or the user does not have permission to view it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TagKey> GetTagKeyAsync(GetTagKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTagKeyRequest(ref request, ref callSettings);
            return _callGetTagKey.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a TagKey by its namespaced name.
        /// This method will return `PERMISSION_DENIED` if the key does not exist
        /// or the user does not have permission to view it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TagKey GetNamespacedTagKey(GetNamespacedTagKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNamespacedTagKeyRequest(ref request, ref callSettings);
            return _callGetNamespacedTagKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a TagKey by its namespaced name.
        /// This method will return `PERMISSION_DENIED` if the key does not exist
        /// or the user does not have permission to view it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TagKey> GetNamespacedTagKeyAsync(GetNamespacedTagKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNamespacedTagKeyRequest(ref request, ref callSettings);
            return _callGetNamespacedTagKey.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateTagKey</c>.</summary>
        public override lro::OperationsClient CreateTagKeyOperationsClient { get; }

        /// <summary>
        /// Creates a new TagKey. If another request with the same parameters is
        /// sent while the original request is in process, the second request
        /// will receive an error. A maximum of 1000 TagKeys can exist under a parent
        /// at any given time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<TagKey, CreateTagKeyMetadata> CreateTagKey(CreateTagKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTagKeyRequest(ref request, ref callSettings);
            return new lro::Operation<TagKey, CreateTagKeyMetadata>(_callCreateTagKey.Sync(request, callSettings), CreateTagKeyOperationsClient);
        }

        /// <summary>
        /// Creates a new TagKey. If another request with the same parameters is
        /// sent while the original request is in process, the second request
        /// will receive an error. A maximum of 1000 TagKeys can exist under a parent
        /// at any given time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<TagKey, CreateTagKeyMetadata>> CreateTagKeyAsync(CreateTagKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTagKeyRequest(ref request, ref callSettings);
            return new lro::Operation<TagKey, CreateTagKeyMetadata>(await _callCreateTagKey.Async(request, callSettings).ConfigureAwait(false), CreateTagKeyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateTagKey</c>.</summary>
        public override lro::OperationsClient UpdateTagKeyOperationsClient { get; }

        /// <summary>
        /// Updates the attributes of the TagKey resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<TagKey, UpdateTagKeyMetadata> UpdateTagKey(UpdateTagKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTagKeyRequest(ref request, ref callSettings);
            return new lro::Operation<TagKey, UpdateTagKeyMetadata>(_callUpdateTagKey.Sync(request, callSettings), UpdateTagKeyOperationsClient);
        }

        /// <summary>
        /// Updates the attributes of the TagKey resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<TagKey, UpdateTagKeyMetadata>> UpdateTagKeyAsync(UpdateTagKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTagKeyRequest(ref request, ref callSettings);
            return new lro::Operation<TagKey, UpdateTagKeyMetadata>(await _callUpdateTagKey.Async(request, callSettings).ConfigureAwait(false), UpdateTagKeyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteTagKey</c>.</summary>
        public override lro::OperationsClient DeleteTagKeyOperationsClient { get; }

        /// <summary>
        /// Deletes a TagKey. The TagKey cannot be deleted if it has any child
        /// TagValues.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<TagKey, DeleteTagKeyMetadata> DeleteTagKey(DeleteTagKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTagKeyRequest(ref request, ref callSettings);
            return new lro::Operation<TagKey, DeleteTagKeyMetadata>(_callDeleteTagKey.Sync(request, callSettings), DeleteTagKeyOperationsClient);
        }

        /// <summary>
        /// Deletes a TagKey. The TagKey cannot be deleted if it has any child
        /// TagValues.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<TagKey, DeleteTagKeyMetadata>> DeleteTagKeyAsync(DeleteTagKeyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTagKeyRequest(ref request, ref callSettings);
            return new lro::Operation<TagKey, DeleteTagKeyMetadata>(await _callDeleteTagKey.Async(request, callSettings).ConfigureAwait(false), DeleteTagKeyOperationsClient);
        }

        /// <summary>
        /// Gets the access control policy for a TagKey. The returned policy may be
        /// empty if no such policy or resource exists. The `resource` field should
        /// be the TagKey's resource name. For example, "tagKeys/1234".
        /// The caller must have
        /// `cloudresourcemanager.googleapis.com/tagKeys.getIamPolicy` permission on
        /// the specified TagKey.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for a TagKey. The returned policy may be
        /// empty if no such policy or resource exists. The `resource` field should
        /// be the TagKey's resource name. For example, "tagKeys/1234".
        /// The caller must have
        /// `cloudresourcemanager.googleapis.com/tagKeys.getIamPolicy` permission on
        /// the specified TagKey.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy on a TagKey, replacing any existing
        /// policy. The `resource` field should be the TagKey's resource name.
        /// For example, "tagKeys/1234".
        /// The caller must have `resourcemanager.tagKeys.setIamPolicy` permission
        /// on the identified tagValue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy on a TagKey, replacing any existing
        /// policy. The `resource` field should be the TagKey's resource name.
        /// For example, "tagKeys/1234".
        /// The caller must have `resourcemanager.tagKeys.setIamPolicy` permission
        /// on the identified tagValue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified TagKey.
        /// The `resource` field should be the TagKey's resource name.
        /// For example, "tagKeys/1234".
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified TagKey.
        /// The `resource` field should be the TagKey's resource name.
        /// For example, "tagKeys/1234".
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }
    }

    public partial class ListTagKeysRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTagKeysResponse : gaxgrpc::IPageResponse<TagKey>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TagKey> GetEnumerator() => TagKeys.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class TagKeys
    {
        public partial class TagKeysClient
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
