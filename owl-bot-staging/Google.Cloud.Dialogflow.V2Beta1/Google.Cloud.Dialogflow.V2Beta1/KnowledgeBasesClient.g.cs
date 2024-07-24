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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gcl = Google.Cloud.Location;
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

namespace Google.Cloud.Dialogflow.V2Beta1
{
    /// <summary>Settings for <see cref="KnowledgeBasesClient"/> instances.</summary>
    public sealed partial class KnowledgeBasesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="KnowledgeBasesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="KnowledgeBasesSettings"/>.</returns>
        public static KnowledgeBasesSettings GetDefault() => new KnowledgeBasesSettings();

        /// <summary>Constructs a new <see cref="KnowledgeBasesSettings"/> object with default settings.</summary>
        public KnowledgeBasesSettings()
        {
        }

        private KnowledgeBasesSettings(KnowledgeBasesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListKnowledgeBasesSettings = existing.ListKnowledgeBasesSettings;
            GetKnowledgeBaseSettings = existing.GetKnowledgeBaseSettings;
            CreateKnowledgeBaseSettings = existing.CreateKnowledgeBaseSettings;
            DeleteKnowledgeBaseSettings = existing.DeleteKnowledgeBaseSettings;
            UpdateKnowledgeBaseSettings = existing.UpdateKnowledgeBaseSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(KnowledgeBasesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KnowledgeBasesClient.ListKnowledgeBases</c> and <c>KnowledgeBasesClient.ListKnowledgeBasesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListKnowledgeBasesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KnowledgeBasesClient.GetKnowledgeBase</c> and <c>KnowledgeBasesClient.GetKnowledgeBaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetKnowledgeBaseSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KnowledgeBasesClient.CreateKnowledgeBase</c> and <c>KnowledgeBasesClient.CreateKnowledgeBaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateKnowledgeBaseSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KnowledgeBasesClient.DeleteKnowledgeBase</c> and <c>KnowledgeBasesClient.DeleteKnowledgeBaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteKnowledgeBaseSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KnowledgeBasesClient.UpdateKnowledgeBase</c> and <c>KnowledgeBasesClient.UpdateKnowledgeBaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateKnowledgeBaseSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="KnowledgeBasesSettings"/> object.</returns>
        public KnowledgeBasesSettings Clone() => new KnowledgeBasesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="KnowledgeBasesClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class KnowledgeBasesClientBuilder : gaxgrpc::ClientBuilderBase<KnowledgeBasesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public KnowledgeBasesSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public KnowledgeBasesClientBuilder() : base(KnowledgeBasesClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref KnowledgeBasesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<KnowledgeBasesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override KnowledgeBasesClient Build()
        {
            KnowledgeBasesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<KnowledgeBasesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<KnowledgeBasesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private KnowledgeBasesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return KnowledgeBasesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<KnowledgeBasesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return KnowledgeBasesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => KnowledgeBasesClient.ChannelPool;
    }

    /// <summary>KnowledgeBases client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing
    /// [KnowledgeBases][google.cloud.dialogflow.v2beta1.KnowledgeBase].
    /// </remarks>
    public abstract partial class KnowledgeBasesClient
    {
        /// <summary>
        /// The default endpoint for the KnowledgeBases service, which is a host of "dialogflow.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dialogflow.googleapis.com:443";

        /// <summary>The default KnowledgeBases scopes.</summary>
        /// <remarks>
        /// The default KnowledgeBases scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/dialogflow</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/dialogflow",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(KnowledgeBases.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="KnowledgeBasesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="KnowledgeBasesClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="KnowledgeBasesClient"/>.</returns>
        public static stt::Task<KnowledgeBasesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new KnowledgeBasesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="KnowledgeBasesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="KnowledgeBasesClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="KnowledgeBasesClient"/>.</returns>
        public static KnowledgeBasesClient Create() => new KnowledgeBasesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="KnowledgeBasesClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="KnowledgeBasesSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="KnowledgeBasesClient"/>.</returns>
        internal static KnowledgeBasesClient Create(grpccore::CallInvoker callInvoker, KnowledgeBasesSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            KnowledgeBases.KnowledgeBasesClient grpcClient = new KnowledgeBases.KnowledgeBasesClient(callInvoker);
            return new KnowledgeBasesClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC KnowledgeBases client</summary>
        public virtual KnowledgeBases.KnowledgeBasesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all knowledge bases of the specified agent.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="KnowledgeBase"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListKnowledgeBasesResponse, KnowledgeBase> ListKnowledgeBases(ListKnowledgeBasesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all knowledge bases of the specified agent.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="KnowledgeBase"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListKnowledgeBasesResponse, KnowledgeBase> ListKnowledgeBasesAsync(ListKnowledgeBasesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all knowledge bases of the specified agent.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to list of knowledge bases for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="KnowledgeBase"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListKnowledgeBasesResponse, KnowledgeBase> ListKnowledgeBases(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListKnowledgeBasesRequest request = new ListKnowledgeBasesRequest
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
            return ListKnowledgeBases(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all knowledge bases of the specified agent.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to list of knowledge bases for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="KnowledgeBase"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListKnowledgeBasesResponse, KnowledgeBase> ListKnowledgeBasesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListKnowledgeBasesRequest request = new ListKnowledgeBasesRequest
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
            return ListKnowledgeBasesAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all knowledge bases of the specified agent.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to list of knowledge bases for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="KnowledgeBase"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListKnowledgeBasesResponse, KnowledgeBase> ListKnowledgeBases(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListKnowledgeBasesRequest request = new ListKnowledgeBasesRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListKnowledgeBases(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all knowledge bases of the specified agent.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to list of knowledge bases for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="KnowledgeBase"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListKnowledgeBasesResponse, KnowledgeBase> ListKnowledgeBasesAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListKnowledgeBasesRequest request = new ListKnowledgeBasesRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListKnowledgeBasesAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all knowledge bases of the specified agent.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to list of knowledge bases for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="KnowledgeBase"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListKnowledgeBasesResponse, KnowledgeBase> ListKnowledgeBases(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListKnowledgeBasesRequest request = new ListKnowledgeBasesRequest
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
            return ListKnowledgeBases(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all knowledge bases of the specified agent.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to list of knowledge bases for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="KnowledgeBase"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListKnowledgeBasesResponse, KnowledgeBase> ListKnowledgeBasesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListKnowledgeBasesRequest request = new ListKnowledgeBasesRequest
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
            return ListKnowledgeBasesAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual KnowledgeBase GetKnowledgeBase(GetKnowledgeBaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KnowledgeBase> GetKnowledgeBaseAsync(GetKnowledgeBaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KnowledgeBase> GetKnowledgeBaseAsync(GetKnowledgeBaseRequest request, st::CancellationToken cancellationToken) =>
            GetKnowledgeBaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the knowledge base to retrieve.
        /// Format `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/knowledgeBases/&lt;Knowledge Base ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual KnowledgeBase GetKnowledgeBase(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetKnowledgeBase(new GetKnowledgeBaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the knowledge base to retrieve.
        /// Format `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/knowledgeBases/&lt;Knowledge Base ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KnowledgeBase> GetKnowledgeBaseAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetKnowledgeBaseAsync(new GetKnowledgeBaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the knowledge base to retrieve.
        /// Format `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/knowledgeBases/&lt;Knowledge Base ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KnowledgeBase> GetKnowledgeBaseAsync(string name, st::CancellationToken cancellationToken) =>
            GetKnowledgeBaseAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the knowledge base to retrieve.
        /// Format `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/knowledgeBases/&lt;Knowledge Base ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual KnowledgeBase GetKnowledgeBase(KnowledgeBaseName name, gaxgrpc::CallSettings callSettings = null) =>
            GetKnowledgeBase(new GetKnowledgeBaseRequest
            {
                KnowledgeBaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the knowledge base to retrieve.
        /// Format `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/knowledgeBases/&lt;Knowledge Base ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KnowledgeBase> GetKnowledgeBaseAsync(KnowledgeBaseName name, gaxgrpc::CallSettings callSettings = null) =>
            GetKnowledgeBaseAsync(new GetKnowledgeBaseRequest
            {
                KnowledgeBaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the knowledge base to retrieve.
        /// Format `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/knowledgeBases/&lt;Knowledge Base ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KnowledgeBase> GetKnowledgeBaseAsync(KnowledgeBaseName name, st::CancellationToken cancellationToken) =>
            GetKnowledgeBaseAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual KnowledgeBase CreateKnowledgeBase(CreateKnowledgeBaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KnowledgeBase> CreateKnowledgeBaseAsync(CreateKnowledgeBaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KnowledgeBase> CreateKnowledgeBaseAsync(CreateKnowledgeBaseRequest request, st::CancellationToken cancellationToken) =>
            CreateKnowledgeBaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to create a knowledge base for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
        /// </param>
        /// <param name="knowledgeBase">
        /// Required. The knowledge base to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual KnowledgeBase CreateKnowledgeBase(string parent, KnowledgeBase knowledgeBase, gaxgrpc::CallSettings callSettings = null) =>
            CreateKnowledgeBase(new CreateKnowledgeBaseRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                KnowledgeBase = gax::GaxPreconditions.CheckNotNull(knowledgeBase, nameof(knowledgeBase)),
            }, callSettings);

        /// <summary>
        /// Creates a knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to create a knowledge base for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
        /// </param>
        /// <param name="knowledgeBase">
        /// Required. The knowledge base to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KnowledgeBase> CreateKnowledgeBaseAsync(string parent, KnowledgeBase knowledgeBase, gaxgrpc::CallSettings callSettings = null) =>
            CreateKnowledgeBaseAsync(new CreateKnowledgeBaseRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                KnowledgeBase = gax::GaxPreconditions.CheckNotNull(knowledgeBase, nameof(knowledgeBase)),
            }, callSettings);

        /// <summary>
        /// Creates a knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to create a knowledge base for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
        /// </param>
        /// <param name="knowledgeBase">
        /// Required. The knowledge base to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KnowledgeBase> CreateKnowledgeBaseAsync(string parent, KnowledgeBase knowledgeBase, st::CancellationToken cancellationToken) =>
            CreateKnowledgeBaseAsync(parent, knowledgeBase, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to create a knowledge base for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
        /// </param>
        /// <param name="knowledgeBase">
        /// Required. The knowledge base to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual KnowledgeBase CreateKnowledgeBase(gagr::ProjectName parent, KnowledgeBase knowledgeBase, gaxgrpc::CallSettings callSettings = null) =>
            CreateKnowledgeBase(new CreateKnowledgeBaseRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                KnowledgeBase = gax::GaxPreconditions.CheckNotNull(knowledgeBase, nameof(knowledgeBase)),
            }, callSettings);

        /// <summary>
        /// Creates a knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to create a knowledge base for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
        /// </param>
        /// <param name="knowledgeBase">
        /// Required. The knowledge base to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KnowledgeBase> CreateKnowledgeBaseAsync(gagr::ProjectName parent, KnowledgeBase knowledgeBase, gaxgrpc::CallSettings callSettings = null) =>
            CreateKnowledgeBaseAsync(new CreateKnowledgeBaseRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                KnowledgeBase = gax::GaxPreconditions.CheckNotNull(knowledgeBase, nameof(knowledgeBase)),
            }, callSettings);

        /// <summary>
        /// Creates a knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to create a knowledge base for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
        /// </param>
        /// <param name="knowledgeBase">
        /// Required. The knowledge base to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KnowledgeBase> CreateKnowledgeBaseAsync(gagr::ProjectName parent, KnowledgeBase knowledgeBase, st::CancellationToken cancellationToken) =>
            CreateKnowledgeBaseAsync(parent, knowledgeBase, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to create a knowledge base for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
        /// </param>
        /// <param name="knowledgeBase">
        /// Required. The knowledge base to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual KnowledgeBase CreateKnowledgeBase(gagr::LocationName parent, KnowledgeBase knowledgeBase, gaxgrpc::CallSettings callSettings = null) =>
            CreateKnowledgeBase(new CreateKnowledgeBaseRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                KnowledgeBase = gax::GaxPreconditions.CheckNotNull(knowledgeBase, nameof(knowledgeBase)),
            }, callSettings);

        /// <summary>
        /// Creates a knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to create a knowledge base for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
        /// </param>
        /// <param name="knowledgeBase">
        /// Required. The knowledge base to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KnowledgeBase> CreateKnowledgeBaseAsync(gagr::LocationName parent, KnowledgeBase knowledgeBase, gaxgrpc::CallSettings callSettings = null) =>
            CreateKnowledgeBaseAsync(new CreateKnowledgeBaseRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                KnowledgeBase = gax::GaxPreconditions.CheckNotNull(knowledgeBase, nameof(knowledgeBase)),
            }, callSettings);

        /// <summary>
        /// Creates a knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to create a knowledge base for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
        /// </param>
        /// <param name="knowledgeBase">
        /// Required. The knowledge base to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KnowledgeBase> CreateKnowledgeBaseAsync(gagr::LocationName parent, KnowledgeBase knowledgeBase, st::CancellationToken cancellationToken) =>
            CreateKnowledgeBaseAsync(parent, knowledgeBase, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteKnowledgeBase(DeleteKnowledgeBaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteKnowledgeBaseAsync(DeleteKnowledgeBaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteKnowledgeBaseAsync(DeleteKnowledgeBaseRequest request, st::CancellationToken cancellationToken) =>
            DeleteKnowledgeBaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the knowledge base to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/knowledgeBases/&lt;Knowledge Base ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteKnowledgeBase(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteKnowledgeBase(new DeleteKnowledgeBaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the knowledge base to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/knowledgeBases/&lt;Knowledge Base ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteKnowledgeBaseAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteKnowledgeBaseAsync(new DeleteKnowledgeBaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the knowledge base to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/knowledgeBases/&lt;Knowledge Base ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteKnowledgeBaseAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteKnowledgeBaseAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the knowledge base to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/knowledgeBases/&lt;Knowledge Base ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteKnowledgeBase(KnowledgeBaseName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteKnowledgeBase(new DeleteKnowledgeBaseRequest
            {
                KnowledgeBaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the knowledge base to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/knowledgeBases/&lt;Knowledge Base ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteKnowledgeBaseAsync(KnowledgeBaseName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteKnowledgeBaseAsync(new DeleteKnowledgeBaseRequest
            {
                KnowledgeBaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the knowledge base to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/knowledgeBases/&lt;Knowledge Base ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteKnowledgeBaseAsync(KnowledgeBaseName name, st::CancellationToken cancellationToken) =>
            DeleteKnowledgeBaseAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual KnowledgeBase UpdateKnowledgeBase(UpdateKnowledgeBaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KnowledgeBase> UpdateKnowledgeBaseAsync(UpdateKnowledgeBaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KnowledgeBase> UpdateKnowledgeBaseAsync(UpdateKnowledgeBaseRequest request, st::CancellationToken cancellationToken) =>
            UpdateKnowledgeBaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="knowledgeBase">
        /// Required. The knowledge base to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Not specified means `update all`.
        /// Currently, only `display_name` can be updated, an InvalidArgument will be
        /// returned for attempting to update other fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual KnowledgeBase UpdateKnowledgeBase(KnowledgeBase knowledgeBase, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateKnowledgeBase(new UpdateKnowledgeBaseRequest
            {
                KnowledgeBase = gax::GaxPreconditions.CheckNotNull(knowledgeBase, nameof(knowledgeBase)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="knowledgeBase">
        /// Required. The knowledge base to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Not specified means `update all`.
        /// Currently, only `display_name` can be updated, an InvalidArgument will be
        /// returned for attempting to update other fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KnowledgeBase> UpdateKnowledgeBaseAsync(KnowledgeBase knowledgeBase, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateKnowledgeBaseAsync(new UpdateKnowledgeBaseRequest
            {
                KnowledgeBase = gax::GaxPreconditions.CheckNotNull(knowledgeBase, nameof(knowledgeBase)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="knowledgeBase">
        /// Required. The knowledge base to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Not specified means `update all`.
        /// Currently, only `display_name` can be updated, an InvalidArgument will be
        /// returned for attempting to update other fields.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KnowledgeBase> UpdateKnowledgeBaseAsync(KnowledgeBase knowledgeBase, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateKnowledgeBaseAsync(knowledgeBase, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="knowledgeBase">
        /// Required. The knowledge base to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual KnowledgeBase UpdateKnowledgeBase(KnowledgeBase knowledgeBase, gaxgrpc::CallSettings callSettings = null) =>
            UpdateKnowledgeBase(new UpdateKnowledgeBaseRequest
            {
                KnowledgeBase = gax::GaxPreconditions.CheckNotNull(knowledgeBase, nameof(knowledgeBase)),
            }, callSettings);

        /// <summary>
        /// Updates the specified knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="knowledgeBase">
        /// Required. The knowledge base to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KnowledgeBase> UpdateKnowledgeBaseAsync(KnowledgeBase knowledgeBase, gaxgrpc::CallSettings callSettings = null) =>
            UpdateKnowledgeBaseAsync(new UpdateKnowledgeBaseRequest
            {
                KnowledgeBase = gax::GaxPreconditions.CheckNotNull(knowledgeBase, nameof(knowledgeBase)),
            }, callSettings);

        /// <summary>
        /// Updates the specified knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="knowledgeBase">
        /// Required. The knowledge base to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KnowledgeBase> UpdateKnowledgeBaseAsync(KnowledgeBase knowledgeBase, st::CancellationToken cancellationToken) =>
            UpdateKnowledgeBaseAsync(knowledgeBase, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>KnowledgeBases client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing
    /// [KnowledgeBases][google.cloud.dialogflow.v2beta1.KnowledgeBase].
    /// </remarks>
    public sealed partial class KnowledgeBasesClientImpl : KnowledgeBasesClient
    {
        private readonly gaxgrpc::ApiCall<ListKnowledgeBasesRequest, ListKnowledgeBasesResponse> _callListKnowledgeBases;

        private readonly gaxgrpc::ApiCall<GetKnowledgeBaseRequest, KnowledgeBase> _callGetKnowledgeBase;

        private readonly gaxgrpc::ApiCall<CreateKnowledgeBaseRequest, KnowledgeBase> _callCreateKnowledgeBase;

        private readonly gaxgrpc::ApiCall<DeleteKnowledgeBaseRequest, wkt::Empty> _callDeleteKnowledgeBase;

        private readonly gaxgrpc::ApiCall<UpdateKnowledgeBaseRequest, KnowledgeBase> _callUpdateKnowledgeBase;

        /// <summary>
        /// Constructs a client wrapper for the KnowledgeBases service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="KnowledgeBasesSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public KnowledgeBasesClientImpl(KnowledgeBases.KnowledgeBasesClient grpcClient, KnowledgeBasesSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            KnowledgeBasesSettings effectiveSettings = settings ?? KnowledgeBasesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListKnowledgeBases = clientHelper.BuildApiCall<ListKnowledgeBasesRequest, ListKnowledgeBasesResponse>("ListKnowledgeBases", grpcClient.ListKnowledgeBasesAsync, grpcClient.ListKnowledgeBases, effectiveSettings.ListKnowledgeBasesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListKnowledgeBases);
            Modify_ListKnowledgeBasesApiCall(ref _callListKnowledgeBases);
            _callGetKnowledgeBase = clientHelper.BuildApiCall<GetKnowledgeBaseRequest, KnowledgeBase>("GetKnowledgeBase", grpcClient.GetKnowledgeBaseAsync, grpcClient.GetKnowledgeBase, effectiveSettings.GetKnowledgeBaseSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetKnowledgeBase);
            Modify_GetKnowledgeBaseApiCall(ref _callGetKnowledgeBase);
            _callCreateKnowledgeBase = clientHelper.BuildApiCall<CreateKnowledgeBaseRequest, KnowledgeBase>("CreateKnowledgeBase", grpcClient.CreateKnowledgeBaseAsync, grpcClient.CreateKnowledgeBase, effectiveSettings.CreateKnowledgeBaseSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateKnowledgeBase);
            Modify_CreateKnowledgeBaseApiCall(ref _callCreateKnowledgeBase);
            _callDeleteKnowledgeBase = clientHelper.BuildApiCall<DeleteKnowledgeBaseRequest, wkt::Empty>("DeleteKnowledgeBase", grpcClient.DeleteKnowledgeBaseAsync, grpcClient.DeleteKnowledgeBase, effectiveSettings.DeleteKnowledgeBaseSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteKnowledgeBase);
            Modify_DeleteKnowledgeBaseApiCall(ref _callDeleteKnowledgeBase);
            _callUpdateKnowledgeBase = clientHelper.BuildApiCall<UpdateKnowledgeBaseRequest, KnowledgeBase>("UpdateKnowledgeBase", grpcClient.UpdateKnowledgeBaseAsync, grpcClient.UpdateKnowledgeBase, effectiveSettings.UpdateKnowledgeBaseSettings).WithGoogleRequestParam("knowledge_base.name", request => request.KnowledgeBase?.Name);
            Modify_ApiCall(ref _callUpdateKnowledgeBase);
            Modify_UpdateKnowledgeBaseApiCall(ref _callUpdateKnowledgeBase);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListKnowledgeBasesApiCall(ref gaxgrpc::ApiCall<ListKnowledgeBasesRequest, ListKnowledgeBasesResponse> call);

        partial void Modify_GetKnowledgeBaseApiCall(ref gaxgrpc::ApiCall<GetKnowledgeBaseRequest, KnowledgeBase> call);

        partial void Modify_CreateKnowledgeBaseApiCall(ref gaxgrpc::ApiCall<CreateKnowledgeBaseRequest, KnowledgeBase> call);

        partial void Modify_DeleteKnowledgeBaseApiCall(ref gaxgrpc::ApiCall<DeleteKnowledgeBaseRequest, wkt::Empty> call);

        partial void Modify_UpdateKnowledgeBaseApiCall(ref gaxgrpc::ApiCall<UpdateKnowledgeBaseRequest, KnowledgeBase> call);

        partial void OnConstruction(KnowledgeBases.KnowledgeBasesClient grpcClient, KnowledgeBasesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC KnowledgeBases client</summary>
        public override KnowledgeBases.KnowledgeBasesClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListKnowledgeBasesRequest(ref ListKnowledgeBasesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetKnowledgeBaseRequest(ref GetKnowledgeBaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateKnowledgeBaseRequest(ref CreateKnowledgeBaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteKnowledgeBaseRequest(ref DeleteKnowledgeBaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateKnowledgeBaseRequest(ref UpdateKnowledgeBaseRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the list of all knowledge bases of the specified agent.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="KnowledgeBase"/> resources.</returns>
        public override gax::PagedEnumerable<ListKnowledgeBasesResponse, KnowledgeBase> ListKnowledgeBases(ListKnowledgeBasesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListKnowledgeBasesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListKnowledgeBasesRequest, ListKnowledgeBasesResponse, KnowledgeBase>(_callListKnowledgeBases, request, callSettings);
        }

        /// <summary>
        /// Returns the list of all knowledge bases of the specified agent.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="KnowledgeBase"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListKnowledgeBasesResponse, KnowledgeBase> ListKnowledgeBasesAsync(ListKnowledgeBasesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListKnowledgeBasesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListKnowledgeBasesRequest, ListKnowledgeBasesResponse, KnowledgeBase>(_callListKnowledgeBases, request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override KnowledgeBase GetKnowledgeBase(GetKnowledgeBaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetKnowledgeBaseRequest(ref request, ref callSettings);
            return _callGetKnowledgeBase.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<KnowledgeBase> GetKnowledgeBaseAsync(GetKnowledgeBaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetKnowledgeBaseRequest(ref request, ref callSettings);
            return _callGetKnowledgeBase.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override KnowledgeBase CreateKnowledgeBase(CreateKnowledgeBaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateKnowledgeBaseRequest(ref request, ref callSettings);
            return _callCreateKnowledgeBase.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<KnowledgeBase> CreateKnowledgeBaseAsync(CreateKnowledgeBaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateKnowledgeBaseRequest(ref request, ref callSettings);
            return _callCreateKnowledgeBase.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteKnowledgeBase(DeleteKnowledgeBaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteKnowledgeBaseRequest(ref request, ref callSettings);
            _callDeleteKnowledgeBase.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteKnowledgeBaseAsync(DeleteKnowledgeBaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteKnowledgeBaseRequest(ref request, ref callSettings);
            return _callDeleteKnowledgeBase.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override KnowledgeBase UpdateKnowledgeBase(UpdateKnowledgeBaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateKnowledgeBaseRequest(ref request, ref callSettings);
            return _callUpdateKnowledgeBase.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified knowledge base.
        /// 
        /// Note: The `projects.agent.knowledgeBases` resource is deprecated;
        /// only use `projects.knowledgeBases`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<KnowledgeBase> UpdateKnowledgeBaseAsync(UpdateKnowledgeBaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateKnowledgeBaseRequest(ref request, ref callSettings);
            return _callUpdateKnowledgeBase.Async(request, callSettings);
        }
    }

    public partial class ListKnowledgeBasesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListKnowledgeBasesResponse : gaxgrpc::IPageResponse<KnowledgeBase>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<KnowledgeBase> GetEnumerator() => KnowledgeBases.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class KnowledgeBases
    {
        public partial class KnowledgeBasesClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="gcl::Locations.LocationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gcl::Locations.LocationsClient"/> for the same target as this client.
            /// </returns>
            public virtual gcl::Locations.LocationsClient CreateLocationsClient() =>
                new gcl::Locations.LocationsClient(CallInvoker);
        }
    }
}
