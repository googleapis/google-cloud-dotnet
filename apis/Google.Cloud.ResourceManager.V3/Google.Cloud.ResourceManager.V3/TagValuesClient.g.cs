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
    /// <summary>Settings for <see cref="TagValuesClient"/> instances.</summary>
    public sealed partial class TagValuesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="TagValuesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="TagValuesSettings"/>.</returns>
        public static TagValuesSettings GetDefault() => new TagValuesSettings();

        /// <summary>Constructs a new <see cref="TagValuesSettings"/> object with default settings.</summary>
        public TagValuesSettings()
        {
        }

        private TagValuesSettings(TagValuesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListTagValuesSettings = existing.ListTagValuesSettings;
            GetTagValueSettings = existing.GetTagValueSettings;
            GetNamespacedTagValueSettings = existing.GetNamespacedTagValueSettings;
            CreateTagValueSettings = existing.CreateTagValueSettings;
            CreateTagValueOperationsSettings = existing.CreateTagValueOperationsSettings.Clone();
            UpdateTagValueSettings = existing.UpdateTagValueSettings;
            UpdateTagValueOperationsSettings = existing.UpdateTagValueOperationsSettings.Clone();
            DeleteTagValueSettings = existing.DeleteTagValueSettings;
            DeleteTagValueOperationsSettings = existing.DeleteTagValueOperationsSettings.Clone();
            GetIamPolicySettings = existing.GetIamPolicySettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(TagValuesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TagValuesClient.ListTagValues</c> and <c>TagValuesClient.ListTagValuesAsync</c>.
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
        public gaxgrpc::CallSettings ListTagValuesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>TagValuesClient.GetTagValue</c>
        ///  and <c>TagValuesClient.GetTagValueAsync</c>.
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
        public gaxgrpc::CallSettings GetTagValueSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TagValuesClient.GetNamespacedTagValue</c> and <c>TagValuesClient.GetNamespacedTagValueAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetNamespacedTagValueSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TagValuesClient.CreateTagValue</c> and <c>TagValuesClient.CreateTagValueAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTagValueSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TagValuesClient.CreateTagValue</c> and
        /// <c>TagValuesClient.CreateTagValueAsync</c>.
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
        public lro::OperationsSettings CreateTagValueOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TagValuesClient.UpdateTagValue</c> and <c>TagValuesClient.UpdateTagValueAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateTagValueSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TagValuesClient.UpdateTagValue</c> and
        /// <c>TagValuesClient.UpdateTagValueAsync</c>.
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
        public lro::OperationsSettings UpdateTagValueOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TagValuesClient.DeleteTagValue</c> and <c>TagValuesClient.DeleteTagValueAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTagValueSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TagValuesClient.DeleteTagValue</c> and
        /// <c>TagValuesClient.DeleteTagValueAsync</c>.
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
        public lro::OperationsSettings DeleteTagValueOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TagValuesClient.GetIamPolicy</c> and <c>TagValuesClient.GetIamPolicyAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TagValuesClient.SetIamPolicy</c> and <c>TagValuesClient.SetIamPolicyAsync</c>.
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
        /// <c>TagValuesClient.TestIamPermissions</c> and <c>TagValuesClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="TagValuesSettings"/> object.</returns>
        public TagValuesSettings Clone() => new TagValuesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="TagValuesClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class TagValuesClientBuilder : gaxgrpc::ClientBuilderBase<TagValuesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public TagValuesSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public TagValuesClientBuilder() : base(TagValuesClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref TagValuesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<TagValuesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override TagValuesClient Build()
        {
            TagValuesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<TagValuesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<TagValuesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private TagValuesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return TagValuesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<TagValuesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TagValuesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => TagValuesClient.ChannelPool;
    }

    /// <summary>TagValues client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Allow users to create and manage tag values.
    /// </remarks>
    public abstract partial class TagValuesClient
    {
        /// <summary>
        /// The default endpoint for the TagValues service, which is a host of "cloudresourcemanager.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudresourcemanager.googleapis.com:443";

        /// <summary>The default TagValues scopes.</summary>
        /// <remarks>
        /// The default TagValues scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(TagValues.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="TagValuesClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="TagValuesClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="TagValuesClient"/>.</returns>
        public static stt::Task<TagValuesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new TagValuesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="TagValuesClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="TagValuesClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="TagValuesClient"/>.</returns>
        public static TagValuesClient Create() => new TagValuesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="TagValuesClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="TagValuesSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="TagValuesClient"/>.</returns>
        internal static TagValuesClient Create(grpccore::CallInvoker callInvoker, TagValuesSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            TagValues.TagValuesClient grpcClient = new TagValues.TagValuesClient(callInvoker);
            return new TagValuesClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC TagValues client</summary>
        public virtual TagValues.TagValuesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all TagValues for a specific TagKey.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TagValue"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTagValuesResponse, TagValue> ListTagValues(ListTagValuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all TagValues for a specific TagKey.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TagValue"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTagValuesResponse, TagValue> ListTagValuesAsync(ListTagValuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all TagValues for a specific TagKey.
        /// </summary>
        /// <param name="parent">
        /// Required.
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
        /// <returns>A pageable sequence of <see cref="TagValue"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTagValuesResponse, TagValue> ListTagValues(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTagValuesRequest request = new ListTagValuesRequest
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
            return ListTagValues(request, callSettings);
        }

        /// <summary>
        /// Lists all TagValues for a specific TagKey.
        /// </summary>
        /// <param name="parent">
        /// Required.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TagValue"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTagValuesResponse, TagValue> ListTagValuesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTagValuesRequest request = new ListTagValuesRequest
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
            return ListTagValuesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all TagValues for a specific TagKey.
        /// </summary>
        /// <param name="parent">
        /// Required.
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
        /// <returns>A pageable sequence of <see cref="TagValue"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTagValuesResponse, TagValue> ListTagValues(gax::IResourceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTagValuesRequest request = new ListTagValuesRequest
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
            return ListTagValues(request, callSettings);
        }

        /// <summary>
        /// Lists all TagValues for a specific TagKey.
        /// </summary>
        /// <param name="parent">
        /// Required.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TagValue"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTagValuesResponse, TagValue> ListTagValuesAsync(gax::IResourceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTagValuesRequest request = new ListTagValuesRequest
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
            return ListTagValuesAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a TagValue. This method will return `PERMISSION_DENIED` if the
        /// value does not exist or the user does not have permission to view it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TagValue GetTagValue(GetTagValueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a TagValue. This method will return `PERMISSION_DENIED` if the
        /// value does not exist or the user does not have permission to view it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagValue> GetTagValueAsync(GetTagValueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a TagValue. This method will return `PERMISSION_DENIED` if the
        /// value does not exist or the user does not have permission to view it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagValue> GetTagValueAsync(GetTagValueRequest request, st::CancellationToken cancellationToken) =>
            GetTagValueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a TagValue. This method will return `PERMISSION_DENIED` if the
        /// value does not exist or the user does not have permission to view it.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for TagValue to be fetched in the format
        /// `tagValues/456`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TagValue GetTagValue(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTagValue(new GetTagValueRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a TagValue. This method will return `PERMISSION_DENIED` if the
        /// value does not exist or the user does not have permission to view it.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for TagValue to be fetched in the format
        /// `tagValues/456`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagValue> GetTagValueAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTagValueAsync(new GetTagValueRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a TagValue. This method will return `PERMISSION_DENIED` if the
        /// value does not exist or the user does not have permission to view it.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for TagValue to be fetched in the format
        /// `tagValues/456`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagValue> GetTagValueAsync(string name, st::CancellationToken cancellationToken) =>
            GetTagValueAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a TagValue. This method will return `PERMISSION_DENIED` if the
        /// value does not exist or the user does not have permission to view it.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for TagValue to be fetched in the format
        /// `tagValues/456`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TagValue GetTagValue(TagValueName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTagValue(new GetTagValueRequest
            {
                TagValueName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a TagValue. This method will return `PERMISSION_DENIED` if the
        /// value does not exist or the user does not have permission to view it.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for TagValue to be fetched in the format
        /// `tagValues/456`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagValue> GetTagValueAsync(TagValueName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTagValueAsync(new GetTagValueRequest
            {
                TagValueName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a TagValue. This method will return `PERMISSION_DENIED` if the
        /// value does not exist or the user does not have permission to view it.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for TagValue to be fetched in the format
        /// `tagValues/456`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagValue> GetTagValueAsync(TagValueName name, st::CancellationToken cancellationToken) =>
            GetTagValueAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a TagValue by its namespaced name.
        /// This method will return `PERMISSION_DENIED` if the value does not exist
        /// or the user does not have permission to view it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TagValue GetNamespacedTagValue(GetNamespacedTagValueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a TagValue by its namespaced name.
        /// This method will return `PERMISSION_DENIED` if the value does not exist
        /// or the user does not have permission to view it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagValue> GetNamespacedTagValueAsync(GetNamespacedTagValueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a TagValue by its namespaced name.
        /// This method will return `PERMISSION_DENIED` if the value does not exist
        /// or the user does not have permission to view it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagValue> GetNamespacedTagValueAsync(GetNamespacedTagValueRequest request, st::CancellationToken cancellationToken) =>
            GetNamespacedTagValueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a TagValue by its namespaced name.
        /// This method will return `PERMISSION_DENIED` if the value does not exist
        /// or the user does not have permission to view it.
        /// </summary>
        /// <param name="name">
        /// Required. A namespaced tag value name in the following format:
        /// 
        /// `{parentId}/{tagKeyShort}/{tagValueShort}`
        /// 
        /// Examples:
        /// - `42/foo/abc` for a value with short name "abc" under the key with short
        /// name "foo" under the organization with ID 42
        /// - `r2-d2/bar/xyz` for a value with short name "xyz" under the key with
        /// short name "bar" under the project with ID "r2-d2"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TagValue GetNamespacedTagValue(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNamespacedTagValue(new GetNamespacedTagValueRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a TagValue by its namespaced name.
        /// This method will return `PERMISSION_DENIED` if the value does not exist
        /// or the user does not have permission to view it.
        /// </summary>
        /// <param name="name">
        /// Required. A namespaced tag value name in the following format:
        /// 
        /// `{parentId}/{tagKeyShort}/{tagValueShort}`
        /// 
        /// Examples:
        /// - `42/foo/abc` for a value with short name "abc" under the key with short
        /// name "foo" under the organization with ID 42
        /// - `r2-d2/bar/xyz` for a value with short name "xyz" under the key with
        /// short name "bar" under the project with ID "r2-d2"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagValue> GetNamespacedTagValueAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNamespacedTagValueAsync(new GetNamespacedTagValueRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a TagValue by its namespaced name.
        /// This method will return `PERMISSION_DENIED` if the value does not exist
        /// or the user does not have permission to view it.
        /// </summary>
        /// <param name="name">
        /// Required. A namespaced tag value name in the following format:
        /// 
        /// `{parentId}/{tagKeyShort}/{tagValueShort}`
        /// 
        /// Examples:
        /// - `42/foo/abc` for a value with short name "abc" under the key with short
        /// name "foo" under the organization with ID 42
        /// - `r2-d2/bar/xyz` for a value with short name "xyz" under the key with
        /// short name "bar" under the project with ID "r2-d2"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagValue> GetNamespacedTagValueAsync(string name, st::CancellationToken cancellationToken) =>
            GetNamespacedTagValueAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a TagValue by its namespaced name.
        /// This method will return `PERMISSION_DENIED` if the value does not exist
        /// or the user does not have permission to view it.
        /// </summary>
        /// <param name="name">
        /// Required. A namespaced tag value name in the following format:
        /// 
        /// `{parentId}/{tagKeyShort}/{tagValueShort}`
        /// 
        /// Examples:
        /// - `42/foo/abc` for a value with short name "abc" under the key with short
        /// name "foo" under the organization with ID 42
        /// - `r2-d2/bar/xyz` for a value with short name "xyz" under the key with
        /// short name "bar" under the project with ID "r2-d2"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TagValue GetNamespacedTagValue(TagValueName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNamespacedTagValue(new GetNamespacedTagValueRequest
            {
                TagValueName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a TagValue by its namespaced name.
        /// This method will return `PERMISSION_DENIED` if the value does not exist
        /// or the user does not have permission to view it.
        /// </summary>
        /// <param name="name">
        /// Required. A namespaced tag value name in the following format:
        /// 
        /// `{parentId}/{tagKeyShort}/{tagValueShort}`
        /// 
        /// Examples:
        /// - `42/foo/abc` for a value with short name "abc" under the key with short
        /// name "foo" under the organization with ID 42
        /// - `r2-d2/bar/xyz` for a value with short name "xyz" under the key with
        /// short name "bar" under the project with ID "r2-d2"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagValue> GetNamespacedTagValueAsync(TagValueName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNamespacedTagValueAsync(new GetNamespacedTagValueRequest
            {
                TagValueName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a TagValue by its namespaced name.
        /// This method will return `PERMISSION_DENIED` if the value does not exist
        /// or the user does not have permission to view it.
        /// </summary>
        /// <param name="name">
        /// Required. A namespaced tag value name in the following format:
        /// 
        /// `{parentId}/{tagKeyShort}/{tagValueShort}`
        /// 
        /// Examples:
        /// - `42/foo/abc` for a value with short name "abc" under the key with short
        /// name "foo" under the organization with ID 42
        /// - `r2-d2/bar/xyz` for a value with short name "xyz" under the key with
        /// short name "bar" under the project with ID "r2-d2"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TagValue> GetNamespacedTagValueAsync(TagValueName name, st::CancellationToken cancellationToken) =>
            GetNamespacedTagValueAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a TagValue as a child of the specified TagKey. If a another
        /// request with the same parameters is sent while the original request is in
        /// process the second request will receive an error. A maximum of 1000
        /// TagValues can exist under a TagKey at any given time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TagValue, CreateTagValueMetadata> CreateTagValue(CreateTagValueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a TagValue as a child of the specified TagKey. If a another
        /// request with the same parameters is sent while the original request is in
        /// process the second request will receive an error. A maximum of 1000
        /// TagValues can exist under a TagKey at any given time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TagValue, CreateTagValueMetadata>> CreateTagValueAsync(CreateTagValueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a TagValue as a child of the specified TagKey. If a another
        /// request with the same parameters is sent while the original request is in
        /// process the second request will receive an error. A maximum of 1000
        /// TagValues can exist under a TagKey at any given time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TagValue, CreateTagValueMetadata>> CreateTagValueAsync(CreateTagValueRequest request, st::CancellationToken cancellationToken) =>
            CreateTagValueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateTagValue</c>.</summary>
        public virtual lro::OperationsClient CreateTagValueOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateTagValue</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<TagValue, CreateTagValueMetadata> PollOnceCreateTagValue(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TagValue, CreateTagValueMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateTagValueOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateTagValue</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<TagValue, CreateTagValueMetadata>> PollOnceCreateTagValueAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TagValue, CreateTagValueMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateTagValueOperationsClient, callSettings);

        /// <summary>
        /// Creates a TagValue as a child of the specified TagKey. If a another
        /// request with the same parameters is sent while the original request is in
        /// process the second request will receive an error. A maximum of 1000
        /// TagValues can exist under a TagKey at any given time.
        /// </summary>
        /// <param name="tagValue">
        /// Required. The TagValue to be created. Only fields `short_name`,
        /// `description`, and `parent` are considered during the creation request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TagValue, CreateTagValueMetadata> CreateTagValue(TagValue tagValue, gaxgrpc::CallSettings callSettings = null) =>
            CreateTagValue(new CreateTagValueRequest
            {
                TagValue = gax::GaxPreconditions.CheckNotNull(tagValue, nameof(tagValue)),
            }, callSettings);

        /// <summary>
        /// Creates a TagValue as a child of the specified TagKey. If a another
        /// request with the same parameters is sent while the original request is in
        /// process the second request will receive an error. A maximum of 1000
        /// TagValues can exist under a TagKey at any given time.
        /// </summary>
        /// <param name="tagValue">
        /// Required. The TagValue to be created. Only fields `short_name`,
        /// `description`, and `parent` are considered during the creation request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TagValue, CreateTagValueMetadata>> CreateTagValueAsync(TagValue tagValue, gaxgrpc::CallSettings callSettings = null) =>
            CreateTagValueAsync(new CreateTagValueRequest
            {
                TagValue = gax::GaxPreconditions.CheckNotNull(tagValue, nameof(tagValue)),
            }, callSettings);

        /// <summary>
        /// Creates a TagValue as a child of the specified TagKey. If a another
        /// request with the same parameters is sent while the original request is in
        /// process the second request will receive an error. A maximum of 1000
        /// TagValues can exist under a TagKey at any given time.
        /// </summary>
        /// <param name="tagValue">
        /// Required. The TagValue to be created. Only fields `short_name`,
        /// `description`, and `parent` are considered during the creation request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TagValue, CreateTagValueMetadata>> CreateTagValueAsync(TagValue tagValue, st::CancellationToken cancellationToken) =>
            CreateTagValueAsync(tagValue, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the attributes of the TagValue resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TagValue, UpdateTagValueMetadata> UpdateTagValue(UpdateTagValueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the attributes of the TagValue resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TagValue, UpdateTagValueMetadata>> UpdateTagValueAsync(UpdateTagValueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the attributes of the TagValue resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TagValue, UpdateTagValueMetadata>> UpdateTagValueAsync(UpdateTagValueRequest request, st::CancellationToken cancellationToken) =>
            UpdateTagValueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateTagValue</c>.</summary>
        public virtual lro::OperationsClient UpdateTagValueOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateTagValue</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<TagValue, UpdateTagValueMetadata> PollOnceUpdateTagValue(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TagValue, UpdateTagValueMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateTagValueOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateTagValue</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<TagValue, UpdateTagValueMetadata>> PollOnceUpdateTagValueAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TagValue, UpdateTagValueMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateTagValueOperationsClient, callSettings);

        /// <summary>
        /// Updates the attributes of the TagValue resource.
        /// </summary>
        /// <param name="tagValue">
        /// Required. The new definition of the TagValue. Only fields `description` and
        /// `etag` fields can be updated by this request. If the `etag` field is
        /// nonempty, it must match the `etag` field of the existing ControlGroup.
        /// Otherwise, `ABORTED` will be returned.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TagValue, UpdateTagValueMetadata> UpdateTagValue(TagValue tagValue, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTagValue(new UpdateTagValueRequest
            {
                TagValue = gax::GaxPreconditions.CheckNotNull(tagValue, nameof(tagValue)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the attributes of the TagValue resource.
        /// </summary>
        /// <param name="tagValue">
        /// Required. The new definition of the TagValue. Only fields `description` and
        /// `etag` fields can be updated by this request. If the `etag` field is
        /// nonempty, it must match the `etag` field of the existing ControlGroup.
        /// Otherwise, `ABORTED` will be returned.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TagValue, UpdateTagValueMetadata>> UpdateTagValueAsync(TagValue tagValue, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTagValueAsync(new UpdateTagValueRequest
            {
                TagValue = gax::GaxPreconditions.CheckNotNull(tagValue, nameof(tagValue)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the attributes of the TagValue resource.
        /// </summary>
        /// <param name="tagValue">
        /// Required. The new definition of the TagValue. Only fields `description` and
        /// `etag` fields can be updated by this request. If the `etag` field is
        /// nonempty, it must match the `etag` field of the existing ControlGroup.
        /// Otherwise, `ABORTED` will be returned.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TagValue, UpdateTagValueMetadata>> UpdateTagValueAsync(TagValue tagValue, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateTagValueAsync(tagValue, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a TagValue. The TagValue cannot have any bindings when it is
        /// deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TagValue, DeleteTagValueMetadata> DeleteTagValue(DeleteTagValueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a TagValue. The TagValue cannot have any bindings when it is
        /// deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TagValue, DeleteTagValueMetadata>> DeleteTagValueAsync(DeleteTagValueRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a TagValue. The TagValue cannot have any bindings when it is
        /// deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TagValue, DeleteTagValueMetadata>> DeleteTagValueAsync(DeleteTagValueRequest request, st::CancellationToken cancellationToken) =>
            DeleteTagValueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteTagValue</c>.</summary>
        public virtual lro::OperationsClient DeleteTagValueOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteTagValue</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<TagValue, DeleteTagValueMetadata> PollOnceDeleteTagValue(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TagValue, DeleteTagValueMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteTagValueOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteTagValue</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<TagValue, DeleteTagValueMetadata>> PollOnceDeleteTagValueAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TagValue, DeleteTagValueMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteTagValueOperationsClient, callSettings);

        /// <summary>
        /// Deletes a TagValue. The TagValue cannot have any bindings when it is
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for TagValue to be deleted in the format
        /// tagValues/456.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TagValue, DeleteTagValueMetadata> DeleteTagValue(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTagValue(new DeleteTagValueRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a TagValue. The TagValue cannot have any bindings when it is
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for TagValue to be deleted in the format
        /// tagValues/456.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TagValue, DeleteTagValueMetadata>> DeleteTagValueAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTagValueAsync(new DeleteTagValueRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a TagValue. The TagValue cannot have any bindings when it is
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for TagValue to be deleted in the format
        /// tagValues/456.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TagValue, DeleteTagValueMetadata>> DeleteTagValueAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteTagValueAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a TagValue. The TagValue cannot have any bindings when it is
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for TagValue to be deleted in the format
        /// tagValues/456.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TagValue, DeleteTagValueMetadata> DeleteTagValue(TagValueName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTagValue(new DeleteTagValueRequest
            {
                TagValueName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a TagValue. The TagValue cannot have any bindings when it is
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for TagValue to be deleted in the format
        /// tagValues/456.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TagValue, DeleteTagValueMetadata>> DeleteTagValueAsync(TagValueName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTagValueAsync(new DeleteTagValueRequest
            {
                TagValueName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a TagValue. The TagValue cannot have any bindings when it is
        /// deleted.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for TagValue to be deleted in the format
        /// tagValues/456.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TagValue, DeleteTagValueMetadata>> DeleteTagValueAsync(TagValueName name, st::CancellationToken cancellationToken) =>
            DeleteTagValueAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a TagValue. The returned policy may be
        /// empty if no such policy or resource exists. The `resource` field should
        /// be the TagValue's resource name. For example: `tagValues/1234`.
        /// The caller must have the
        /// `cloudresourcemanager.googleapis.com/tagValues.getIamPolicy` permission on
        /// the identified TagValue to get the access control policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for a TagValue. The returned policy may be
        /// empty if no such policy or resource exists. The `resource` field should
        /// be the TagValue's resource name. For example: `tagValues/1234`.
        /// The caller must have the
        /// `cloudresourcemanager.googleapis.com/tagValues.getIamPolicy` permission on
        /// the identified TagValue to get the access control policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for a TagValue. The returned policy may be
        /// empty if no such policy or resource exists. The `resource` field should
        /// be the TagValue's resource name. For example: `tagValues/1234`.
        /// The caller must have the
        /// `cloudresourcemanager.googleapis.com/tagValues.getIamPolicy` permission on
        /// the identified TagValue to get the access control policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a TagValue. The returned policy may be
        /// empty if no such policy or resource exists. The `resource` field should
        /// be the TagValue's resource name. For example: `tagValues/1234`.
        /// The caller must have the
        /// `cloudresourcemanager.googleapis.com/tagValues.getIamPolicy` permission on
        /// the identified TagValue to get the access control policy.
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
        /// Gets the access control policy for a TagValue. The returned policy may be
        /// empty if no such policy or resource exists. The `resource` field should
        /// be the TagValue's resource name. For example: `tagValues/1234`.
        /// The caller must have the
        /// `cloudresourcemanager.googleapis.com/tagValues.getIamPolicy` permission on
        /// the identified TagValue to get the access control policy.
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
        /// Gets the access control policy for a TagValue. The returned policy may be
        /// empty if no such policy or resource exists. The `resource` field should
        /// be the TagValue's resource name. For example: `tagValues/1234`.
        /// The caller must have the
        /// `cloudresourcemanager.googleapis.com/tagValues.getIamPolicy` permission on
        /// the identified TagValue to get the access control policy.
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
        /// Gets the access control policy for a TagValue. The returned policy may be
        /// empty if no such policy or resource exists. The `resource` field should
        /// be the TagValue's resource name. For example: `tagValues/1234`.
        /// The caller must have the
        /// `cloudresourcemanager.googleapis.com/tagValues.getIamPolicy` permission on
        /// the identified TagValue to get the access control policy.
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
        /// Gets the access control policy for a TagValue. The returned policy may be
        /// empty if no such policy or resource exists. The `resource` field should
        /// be the TagValue's resource name. For example: `tagValues/1234`.
        /// The caller must have the
        /// `cloudresourcemanager.googleapis.com/tagValues.getIamPolicy` permission on
        /// the identified TagValue to get the access control policy.
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
        /// Gets the access control policy for a TagValue. The returned policy may be
        /// empty if no such policy or resource exists. The `resource` field should
        /// be the TagValue's resource name. For example: `tagValues/1234`.
        /// The caller must have the
        /// `cloudresourcemanager.googleapis.com/tagValues.getIamPolicy` permission on
        /// the identified TagValue to get the access control policy.
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
        /// Sets the access control policy on a TagValue, replacing any existing
        /// policy. The `resource` field should be the TagValue's resource name.
        /// For example: `tagValues/1234`.
        /// The caller must have `resourcemanager.tagValues.setIamPolicy` permission
        /// on the identified tagValue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on a TagValue, replacing any existing
        /// policy. The `resource` field should be the TagValue's resource name.
        /// For example: `tagValues/1234`.
        /// The caller must have `resourcemanager.tagValues.setIamPolicy` permission
        /// on the identified tagValue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on a TagValue, replacing any existing
        /// policy. The `resource` field should be the TagValue's resource name.
        /// For example: `tagValues/1234`.
        /// The caller must have `resourcemanager.tagValues.setIamPolicy` permission
        /// on the identified tagValue.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on a TagValue, replacing any existing
        /// policy. The `resource` field should be the TagValue's resource name.
        /// For example: `tagValues/1234`.
        /// The caller must have `resourcemanager.tagValues.setIamPolicy` permission
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
        /// Sets the access control policy on a TagValue, replacing any existing
        /// policy. The `resource` field should be the TagValue's resource name.
        /// For example: `tagValues/1234`.
        /// The caller must have `resourcemanager.tagValues.setIamPolicy` permission
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
        /// Sets the access control policy on a TagValue, replacing any existing
        /// policy. The `resource` field should be the TagValue's resource name.
        /// For example: `tagValues/1234`.
        /// The caller must have `resourcemanager.tagValues.setIamPolicy` permission
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
        /// Sets the access control policy on a TagValue, replacing any existing
        /// policy. The `resource` field should be the TagValue's resource name.
        /// For example: `tagValues/1234`.
        /// The caller must have `resourcemanager.tagValues.setIamPolicy` permission
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
        /// Sets the access control policy on a TagValue, replacing any existing
        /// policy. The `resource` field should be the TagValue's resource name.
        /// For example: `tagValues/1234`.
        /// The caller must have `resourcemanager.tagValues.setIamPolicy` permission
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
        /// Sets the access control policy on a TagValue, replacing any existing
        /// policy. The `resource` field should be the TagValue's resource name.
        /// For example: `tagValues/1234`.
        /// The caller must have `resourcemanager.tagValues.setIamPolicy` permission
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
        /// Returns permissions that a caller has on the specified TagValue.
        /// The `resource` field should be the TagValue's resource name. For example:
        /// `tagValues/1234`.
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that a caller has on the specified TagValue.
        /// The `resource` field should be the TagValue's resource name. For example:
        /// `tagValues/1234`.
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that a caller has on the specified TagValue.
        /// The `resource` field should be the TagValue's resource name. For example:
        /// `tagValues/1234`.
        /// 
        /// There are no permissions required for making this API call.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on the specified TagValue.
        /// The `resource` field should be the TagValue's resource name. For example:
        /// `tagValues/1234`.
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
        /// Returns permissions that a caller has on the specified TagValue.
        /// The `resource` field should be the TagValue's resource name. For example:
        /// `tagValues/1234`.
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
        /// Returns permissions that a caller has on the specified TagValue.
        /// The `resource` field should be the TagValue's resource name. For example:
        /// `tagValues/1234`.
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
        /// Returns permissions that a caller has on the specified TagValue.
        /// The `resource` field should be the TagValue's resource name. For example:
        /// `tagValues/1234`.
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
        /// Returns permissions that a caller has on the specified TagValue.
        /// The `resource` field should be the TagValue's resource name. For example:
        /// `tagValues/1234`.
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
        /// Returns permissions that a caller has on the specified TagValue.
        /// The `resource` field should be the TagValue's resource name. For example:
        /// `tagValues/1234`.
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

    /// <summary>TagValues client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Allow users to create and manage tag values.
    /// </remarks>
    public sealed partial class TagValuesClientImpl : TagValuesClient
    {
        private readonly gaxgrpc::ApiCall<ListTagValuesRequest, ListTagValuesResponse> _callListTagValues;

        private readonly gaxgrpc::ApiCall<GetTagValueRequest, TagValue> _callGetTagValue;

        private readonly gaxgrpc::ApiCall<GetNamespacedTagValueRequest, TagValue> _callGetNamespacedTagValue;

        private readonly gaxgrpc::ApiCall<CreateTagValueRequest, lro::Operation> _callCreateTagValue;

        private readonly gaxgrpc::ApiCall<UpdateTagValueRequest, lro::Operation> _callUpdateTagValue;

        private readonly gaxgrpc::ApiCall<DeleteTagValueRequest, lro::Operation> _callDeleteTagValue;

        private readonly gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> _callGetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> _callSetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> _callTestIamPermissions;

        /// <summary>
        /// Constructs a client wrapper for the TagValues service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="TagValuesSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public TagValuesClientImpl(TagValues.TagValuesClient grpcClient, TagValuesSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            TagValuesSettings effectiveSettings = settings ?? TagValuesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateTagValueOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateTagValueOperationsSettings, logger);
            UpdateTagValueOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateTagValueOperationsSettings, logger);
            DeleteTagValueOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteTagValueOperationsSettings, logger);
            _callListTagValues = clientHelper.BuildApiCall<ListTagValuesRequest, ListTagValuesResponse>("ListTagValues", grpcClient.ListTagValuesAsync, grpcClient.ListTagValues, effectiveSettings.ListTagValuesSettings);
            Modify_ApiCall(ref _callListTagValues);
            Modify_ListTagValuesApiCall(ref _callListTagValues);
            _callGetTagValue = clientHelper.BuildApiCall<GetTagValueRequest, TagValue>("GetTagValue", grpcClient.GetTagValueAsync, grpcClient.GetTagValue, effectiveSettings.GetTagValueSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTagValue);
            Modify_GetTagValueApiCall(ref _callGetTagValue);
            _callGetNamespacedTagValue = clientHelper.BuildApiCall<GetNamespacedTagValueRequest, TagValue>("GetNamespacedTagValue", grpcClient.GetNamespacedTagValueAsync, grpcClient.GetNamespacedTagValue, effectiveSettings.GetNamespacedTagValueSettings);
            Modify_ApiCall(ref _callGetNamespacedTagValue);
            Modify_GetNamespacedTagValueApiCall(ref _callGetNamespacedTagValue);
            _callCreateTagValue = clientHelper.BuildApiCall<CreateTagValueRequest, lro::Operation>("CreateTagValue", grpcClient.CreateTagValueAsync, grpcClient.CreateTagValue, effectiveSettings.CreateTagValueSettings);
            Modify_ApiCall(ref _callCreateTagValue);
            Modify_CreateTagValueApiCall(ref _callCreateTagValue);
            _callUpdateTagValue = clientHelper.BuildApiCall<UpdateTagValueRequest, lro::Operation>("UpdateTagValue", grpcClient.UpdateTagValueAsync, grpcClient.UpdateTagValue, effectiveSettings.UpdateTagValueSettings).WithGoogleRequestParam("tag_value.name", request => request.TagValue?.Name);
            Modify_ApiCall(ref _callUpdateTagValue);
            Modify_UpdateTagValueApiCall(ref _callUpdateTagValue);
            _callDeleteTagValue = clientHelper.BuildApiCall<DeleteTagValueRequest, lro::Operation>("DeleteTagValue", grpcClient.DeleteTagValueAsync, grpcClient.DeleteTagValue, effectiveSettings.DeleteTagValueSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTagValue);
            Modify_DeleteTagValueApiCall(ref _callDeleteTagValue);
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

        partial void Modify_ListTagValuesApiCall(ref gaxgrpc::ApiCall<ListTagValuesRequest, ListTagValuesResponse> call);

        partial void Modify_GetTagValueApiCall(ref gaxgrpc::ApiCall<GetTagValueRequest, TagValue> call);

        partial void Modify_GetNamespacedTagValueApiCall(ref gaxgrpc::ApiCall<GetNamespacedTagValueRequest, TagValue> call);

        partial void Modify_CreateTagValueApiCall(ref gaxgrpc::ApiCall<CreateTagValueRequest, lro::Operation> call);

        partial void Modify_UpdateTagValueApiCall(ref gaxgrpc::ApiCall<UpdateTagValueRequest, lro::Operation> call);

        partial void Modify_DeleteTagValueApiCall(ref gaxgrpc::ApiCall<DeleteTagValueRequest, lro::Operation> call);

        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> call);

        partial void OnConstruction(TagValues.TagValuesClient grpcClient, TagValuesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC TagValues client</summary>
        public override TagValues.TagValuesClient GrpcClient { get; }

        partial void Modify_ListTagValuesRequest(ref ListTagValuesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTagValueRequest(ref GetTagValueRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetNamespacedTagValueRequest(ref GetNamespacedTagValueRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTagValueRequest(ref CreateTagValueRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTagValueRequest(ref UpdateTagValueRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTagValueRequest(ref DeleteTagValueRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIamPolicyRequest(ref gciv::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetIamPolicyRequest(ref gciv::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsRequest(ref gciv::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists all TagValues for a specific TagKey.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TagValue"/> resources.</returns>
        public override gax::PagedEnumerable<ListTagValuesResponse, TagValue> ListTagValues(ListTagValuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTagValuesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTagValuesRequest, ListTagValuesResponse, TagValue>(_callListTagValues, request, callSettings);
        }

        /// <summary>
        /// Lists all TagValues for a specific TagKey.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TagValue"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTagValuesResponse, TagValue> ListTagValuesAsync(ListTagValuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTagValuesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTagValuesRequest, ListTagValuesResponse, TagValue>(_callListTagValues, request, callSettings);
        }

        /// <summary>
        /// Retrieves a TagValue. This method will return `PERMISSION_DENIED` if the
        /// value does not exist or the user does not have permission to view it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TagValue GetTagValue(GetTagValueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTagValueRequest(ref request, ref callSettings);
            return _callGetTagValue.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a TagValue. This method will return `PERMISSION_DENIED` if the
        /// value does not exist or the user does not have permission to view it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TagValue> GetTagValueAsync(GetTagValueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTagValueRequest(ref request, ref callSettings);
            return _callGetTagValue.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a TagValue by its namespaced name.
        /// This method will return `PERMISSION_DENIED` if the value does not exist
        /// or the user does not have permission to view it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TagValue GetNamespacedTagValue(GetNamespacedTagValueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNamespacedTagValueRequest(ref request, ref callSettings);
            return _callGetNamespacedTagValue.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a TagValue by its namespaced name.
        /// This method will return `PERMISSION_DENIED` if the value does not exist
        /// or the user does not have permission to view it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TagValue> GetNamespacedTagValueAsync(GetNamespacedTagValueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNamespacedTagValueRequest(ref request, ref callSettings);
            return _callGetNamespacedTagValue.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateTagValue</c>.</summary>
        public override lro::OperationsClient CreateTagValueOperationsClient { get; }

        /// <summary>
        /// Creates a TagValue as a child of the specified TagKey. If a another
        /// request with the same parameters is sent while the original request is in
        /// process the second request will receive an error. A maximum of 1000
        /// TagValues can exist under a TagKey at any given time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<TagValue, CreateTagValueMetadata> CreateTagValue(CreateTagValueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTagValueRequest(ref request, ref callSettings);
            return new lro::Operation<TagValue, CreateTagValueMetadata>(_callCreateTagValue.Sync(request, callSettings), CreateTagValueOperationsClient);
        }

        /// <summary>
        /// Creates a TagValue as a child of the specified TagKey. If a another
        /// request with the same parameters is sent while the original request is in
        /// process the second request will receive an error. A maximum of 1000
        /// TagValues can exist under a TagKey at any given time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<TagValue, CreateTagValueMetadata>> CreateTagValueAsync(CreateTagValueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTagValueRequest(ref request, ref callSettings);
            return new lro::Operation<TagValue, CreateTagValueMetadata>(await _callCreateTagValue.Async(request, callSettings).ConfigureAwait(false), CreateTagValueOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateTagValue</c>.</summary>
        public override lro::OperationsClient UpdateTagValueOperationsClient { get; }

        /// <summary>
        /// Updates the attributes of the TagValue resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<TagValue, UpdateTagValueMetadata> UpdateTagValue(UpdateTagValueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTagValueRequest(ref request, ref callSettings);
            return new lro::Operation<TagValue, UpdateTagValueMetadata>(_callUpdateTagValue.Sync(request, callSettings), UpdateTagValueOperationsClient);
        }

        /// <summary>
        /// Updates the attributes of the TagValue resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<TagValue, UpdateTagValueMetadata>> UpdateTagValueAsync(UpdateTagValueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTagValueRequest(ref request, ref callSettings);
            return new lro::Operation<TagValue, UpdateTagValueMetadata>(await _callUpdateTagValue.Async(request, callSettings).ConfigureAwait(false), UpdateTagValueOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteTagValue</c>.</summary>
        public override lro::OperationsClient DeleteTagValueOperationsClient { get; }

        /// <summary>
        /// Deletes a TagValue. The TagValue cannot have any bindings when it is
        /// deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<TagValue, DeleteTagValueMetadata> DeleteTagValue(DeleteTagValueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTagValueRequest(ref request, ref callSettings);
            return new lro::Operation<TagValue, DeleteTagValueMetadata>(_callDeleteTagValue.Sync(request, callSettings), DeleteTagValueOperationsClient);
        }

        /// <summary>
        /// Deletes a TagValue. The TagValue cannot have any bindings when it is
        /// deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<TagValue, DeleteTagValueMetadata>> DeleteTagValueAsync(DeleteTagValueRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTagValueRequest(ref request, ref callSettings);
            return new lro::Operation<TagValue, DeleteTagValueMetadata>(await _callDeleteTagValue.Async(request, callSettings).ConfigureAwait(false), DeleteTagValueOperationsClient);
        }

        /// <summary>
        /// Gets the access control policy for a TagValue. The returned policy may be
        /// empty if no such policy or resource exists. The `resource` field should
        /// be the TagValue's resource name. For example: `tagValues/1234`.
        /// The caller must have the
        /// `cloudresourcemanager.googleapis.com/tagValues.getIamPolicy` permission on
        /// the identified TagValue to get the access control policy.
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
        /// Gets the access control policy for a TagValue. The returned policy may be
        /// empty if no such policy or resource exists. The `resource` field should
        /// be the TagValue's resource name. For example: `tagValues/1234`.
        /// The caller must have the
        /// `cloudresourcemanager.googleapis.com/tagValues.getIamPolicy` permission on
        /// the identified TagValue to get the access control policy.
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
        /// Sets the access control policy on a TagValue, replacing any existing
        /// policy. The `resource` field should be the TagValue's resource name.
        /// For example: `tagValues/1234`.
        /// The caller must have `resourcemanager.tagValues.setIamPolicy` permission
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
        /// Sets the access control policy on a TagValue, replacing any existing
        /// policy. The `resource` field should be the TagValue's resource name.
        /// For example: `tagValues/1234`.
        /// The caller must have `resourcemanager.tagValues.setIamPolicy` permission
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
        /// Returns permissions that a caller has on the specified TagValue.
        /// The `resource` field should be the TagValue's resource name. For example:
        /// `tagValues/1234`.
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
        /// Returns permissions that a caller has on the specified TagValue.
        /// The `resource` field should be the TagValue's resource name. For example:
        /// `tagValues/1234`.
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

    public partial class ListTagValuesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTagValuesResponse : gaxgrpc::IPageResponse<TagValue>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TagValue> GetEnumerator() => TagValues.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class TagValues
    {
        public partial class TagValuesClient
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
