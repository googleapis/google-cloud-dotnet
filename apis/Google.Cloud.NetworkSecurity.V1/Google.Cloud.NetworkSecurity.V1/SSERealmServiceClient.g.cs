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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
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

namespace Google.Cloud.NetworkSecurity.V1
{
    /// <summary>Settings for <see cref="SSERealmServiceClient"/> instances.</summary>
    public sealed partial class SSERealmServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SSERealmServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SSERealmServiceSettings"/>.</returns>
        public static SSERealmServiceSettings GetDefault() => new SSERealmServiceSettings();

        /// <summary>Constructs a new <see cref="SSERealmServiceSettings"/> object with default settings.</summary>
        public SSERealmServiceSettings()
        {
        }

        private SSERealmServiceSettings(SSERealmServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListSACRealmsSettings = existing.ListSACRealmsSettings;
            GetSACRealmSettings = existing.GetSACRealmSettings;
            CreateSACRealmSettings = existing.CreateSACRealmSettings;
            CreateSACRealmOperationsSettings = existing.CreateSACRealmOperationsSettings.Clone();
            DeleteSACRealmSettings = existing.DeleteSACRealmSettings;
            DeleteSACRealmOperationsSettings = existing.DeleteSACRealmOperationsSettings.Clone();
            ListSACAttachmentsSettings = existing.ListSACAttachmentsSettings;
            GetSACAttachmentSettings = existing.GetSACAttachmentSettings;
            CreateSACAttachmentSettings = existing.CreateSACAttachmentSettings;
            CreateSACAttachmentOperationsSettings = existing.CreateSACAttachmentOperationsSettings.Clone();
            DeleteSACAttachmentSettings = existing.DeleteSACAttachmentSettings;
            DeleteSACAttachmentOperationsSettings = existing.DeleteSACAttachmentOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(SSERealmServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SSERealmServiceClient.ListSACRealms</c> and <c>SSERealmServiceClient.ListSACRealmsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSACRealmsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SSERealmServiceClient.GetSACRealm</c> and <c>SSERealmServiceClient.GetSACRealmAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSACRealmSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SSERealmServiceClient.CreateSACRealm</c> and <c>SSERealmServiceClient.CreateSACRealmAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSACRealmSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SSERealmServiceClient.CreateSACRealm</c> and
        /// <c>SSERealmServiceClient.CreateSACRealmAsync</c>.
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
        public lro::OperationsSettings CreateSACRealmOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SSERealmServiceClient.DeleteSACRealm</c> and <c>SSERealmServiceClient.DeleteSACRealmAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSACRealmSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SSERealmServiceClient.DeleteSACRealm</c> and
        /// <c>SSERealmServiceClient.DeleteSACRealmAsync</c>.
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
        public lro::OperationsSettings DeleteSACRealmOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SSERealmServiceClient.ListSACAttachments</c> and <c>SSERealmServiceClient.ListSACAttachmentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSACAttachmentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SSERealmServiceClient.GetSACAttachment</c> and <c>SSERealmServiceClient.GetSACAttachmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSACAttachmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SSERealmServiceClient.CreateSACAttachment</c> and <c>SSERealmServiceClient.CreateSACAttachmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSACAttachmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SSERealmServiceClient.CreateSACAttachment</c> and
        /// <c>SSERealmServiceClient.CreateSACAttachmentAsync</c>.
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
        public lro::OperationsSettings CreateSACAttachmentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SSERealmServiceClient.DeleteSACAttachment</c> and <c>SSERealmServiceClient.DeleteSACAttachmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSACAttachmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SSERealmServiceClient.DeleteSACAttachment</c> and
        /// <c>SSERealmServiceClient.DeleteSACAttachmentAsync</c>.
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
        public lro::OperationsSettings DeleteSACAttachmentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SSERealmServiceSettings"/> object.</returns>
        public SSERealmServiceSettings Clone() => new SSERealmServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SSERealmServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class SSERealmServiceClientBuilder : gaxgrpc::ClientBuilderBase<SSERealmServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SSERealmServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SSERealmServiceClientBuilder() : base(SSERealmServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SSERealmServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SSERealmServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SSERealmServiceClient Build()
        {
            SSERealmServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SSERealmServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SSERealmServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SSERealmServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SSERealmServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SSERealmServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SSERealmServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SSERealmServiceClient.ChannelPool;
    }

    /// <summary>SSERealmService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public abstract partial class SSERealmServiceClient
    {
        /// <summary>
        /// The default endpoint for the SSERealmService service, which is a host of "networksecurity.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "networksecurity.googleapis.com:443";

        /// <summary>The default SSERealmService scopes.</summary>
        /// <remarks>
        /// The default SSERealmService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SSERealmService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SSERealmServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SSERealmServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SSERealmServiceClient"/>.</returns>
        public static stt::Task<SSERealmServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SSERealmServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SSERealmServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SSERealmServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SSERealmServiceClient"/>.</returns>
        public static SSERealmServiceClient Create() => new SSERealmServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SSERealmServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SSERealmServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SSERealmServiceClient"/>.</returns>
        internal static SSERealmServiceClient Create(grpccore::CallInvoker callInvoker, SSERealmServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SSERealmService.SSERealmServiceClient grpcClient = new SSERealmService.SSERealmServiceClient(callInvoker);
            return new SSERealmServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC SSERealmService client</summary>
        public virtual SSERealmService.SSERealmServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists SACRealms in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SACRealm"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSACRealmsResponse, SACRealm> ListSACRealms(ListSACRealmsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists SACRealms in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SACRealm"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSACRealmsResponse, SACRealm> ListSACRealmsAsync(ListSACRealmsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists SACRealms in a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, in the form `projects/{project}/locations/global`.
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
        /// <returns>A pageable sequence of <see cref="SACRealm"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSACRealmsResponse, SACRealm> ListSACRealms(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSACRealmsRequest request = new ListSACRealmsRequest
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
            return ListSACRealms(request, callSettings);
        }

        /// <summary>
        /// Lists SACRealms in a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, in the form `projects/{project}/locations/global`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SACRealm"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSACRealmsResponse, SACRealm> ListSACRealmsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSACRealmsRequest request = new ListSACRealmsRequest
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
            return ListSACRealmsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists SACRealms in a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, in the form `projects/{project}/locations/global`.
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
        /// <returns>A pageable sequence of <see cref="SACRealm"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSACRealmsResponse, SACRealm> ListSACRealms(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSACRealmsRequest request = new ListSACRealmsRequest
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
            return ListSACRealms(request, callSettings);
        }

        /// <summary>
        /// Lists SACRealms in a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, in the form `projects/{project}/locations/global`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SACRealm"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSACRealmsResponse, SACRealm> ListSACRealmsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSACRealmsRequest request = new ListSACRealmsRequest
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
            return ListSACRealmsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified realm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SACRealm GetSACRealm(GetSACRealmRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified realm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SACRealm> GetSACRealmAsync(GetSACRealmRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified realm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SACRealm> GetSACRealmAsync(GetSACRealmRequest request, st::CancellationToken cancellationToken) =>
            GetSACRealmAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified realm.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the form
        /// `projects/{project}/locations/global/sacRealms/{sacRealm}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SACRealm GetSACRealm(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSACRealm(new GetSACRealmRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified realm.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the form
        /// `projects/{project}/locations/global/sacRealms/{sacRealm}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SACRealm> GetSACRealmAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSACRealmAsync(new GetSACRealmRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified realm.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the form
        /// `projects/{project}/locations/global/sacRealms/{sacRealm}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SACRealm> GetSACRealmAsync(string name, st::CancellationToken cancellationToken) =>
            GetSACRealmAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified realm.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the form
        /// `projects/{project}/locations/global/sacRealms/{sacRealm}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SACRealm GetSACRealm(SACRealmName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSACRealm(new GetSACRealmRequest
            {
                SACRealmName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified realm.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the form
        /// `projects/{project}/locations/global/sacRealms/{sacRealm}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SACRealm> GetSACRealmAsync(SACRealmName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSACRealmAsync(new GetSACRealmRequest
            {
                SACRealmName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified realm.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the form
        /// `projects/{project}/locations/global/sacRealms/{sacRealm}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SACRealm> GetSACRealmAsync(SACRealmName name, st::CancellationToken cancellationToken) =>
            GetSACRealmAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new SACRealm in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SACRealm, OperationMetadata> CreateSACRealm(CreateSACRealmRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new SACRealm in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SACRealm, OperationMetadata>> CreateSACRealmAsync(CreateSACRealmRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new SACRealm in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SACRealm, OperationMetadata>> CreateSACRealmAsync(CreateSACRealmRequest request, st::CancellationToken cancellationToken) =>
            CreateSACRealmAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateSACRealm</c>.</summary>
        public virtual lro::OperationsClient CreateSACRealmOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateSACRealm</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<SACRealm, OperationMetadata> PollOnceCreateSACRealm(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SACRealm, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSACRealmOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateSACRealm</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<SACRealm, OperationMetadata>> PollOnceCreateSACRealmAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SACRealm, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSACRealmOperationsClient, callSettings);

        /// <summary>
        /// Creates a new SACRealm in a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, in the form `projects/{project}/locations/global`.
        /// </param>
        /// <param name="sacRealm">
        /// Required. The resource being created.
        /// </param>
        /// <param name="sacRealmId">
        /// Required. ID of the created realm.
        /// The ID must be 1-63 characters long, and comply with
        /// &lt;a href="https://www.ietf.org/rfc/rfc1035.txt" target="_blank"&gt;RFC1035&lt;/a&gt;.
        /// Specifically, it must be 1-63 characters long and match the regular
        /// expression `[a-z]([-a-z0-9]*[a-z0-9])?`
        /// which means the first character must be a lowercase letter, and all
        /// following characters must be a dash, lowercase letter, or digit, except
        /// the last character, which cannot be a dash.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SACRealm, OperationMetadata> CreateSACRealm(string parent, SACRealm sacRealm, string sacRealmId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSACRealm(new CreateSACRealmRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SacRealmId = gax::GaxPreconditions.CheckNotNullOrEmpty(sacRealmId, nameof(sacRealmId)),
                SacRealm = gax::GaxPreconditions.CheckNotNull(sacRealm, nameof(sacRealm)),
            }, callSettings);

        /// <summary>
        /// Creates a new SACRealm in a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, in the form `projects/{project}/locations/global`.
        /// </param>
        /// <param name="sacRealm">
        /// Required. The resource being created.
        /// </param>
        /// <param name="sacRealmId">
        /// Required. ID of the created realm.
        /// The ID must be 1-63 characters long, and comply with
        /// &lt;a href="https://www.ietf.org/rfc/rfc1035.txt" target="_blank"&gt;RFC1035&lt;/a&gt;.
        /// Specifically, it must be 1-63 characters long and match the regular
        /// expression `[a-z]([-a-z0-9]*[a-z0-9])?`
        /// which means the first character must be a lowercase letter, and all
        /// following characters must be a dash, lowercase letter, or digit, except
        /// the last character, which cannot be a dash.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SACRealm, OperationMetadata>> CreateSACRealmAsync(string parent, SACRealm sacRealm, string sacRealmId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSACRealmAsync(new CreateSACRealmRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SacRealmId = gax::GaxPreconditions.CheckNotNullOrEmpty(sacRealmId, nameof(sacRealmId)),
                SacRealm = gax::GaxPreconditions.CheckNotNull(sacRealm, nameof(sacRealm)),
            }, callSettings);

        /// <summary>
        /// Creates a new SACRealm in a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, in the form `projects/{project}/locations/global`.
        /// </param>
        /// <param name="sacRealm">
        /// Required. The resource being created.
        /// </param>
        /// <param name="sacRealmId">
        /// Required. ID of the created realm.
        /// The ID must be 1-63 characters long, and comply with
        /// &lt;a href="https://www.ietf.org/rfc/rfc1035.txt" target="_blank"&gt;RFC1035&lt;/a&gt;.
        /// Specifically, it must be 1-63 characters long and match the regular
        /// expression `[a-z]([-a-z0-9]*[a-z0-9])?`
        /// which means the first character must be a lowercase letter, and all
        /// following characters must be a dash, lowercase letter, or digit, except
        /// the last character, which cannot be a dash.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SACRealm, OperationMetadata>> CreateSACRealmAsync(string parent, SACRealm sacRealm, string sacRealmId, st::CancellationToken cancellationToken) =>
            CreateSACRealmAsync(parent, sacRealm, sacRealmId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new SACRealm in a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, in the form `projects/{project}/locations/global`.
        /// </param>
        /// <param name="sacRealm">
        /// Required. The resource being created.
        /// </param>
        /// <param name="sacRealmId">
        /// Required. ID of the created realm.
        /// The ID must be 1-63 characters long, and comply with
        /// &lt;a href="https://www.ietf.org/rfc/rfc1035.txt" target="_blank"&gt;RFC1035&lt;/a&gt;.
        /// Specifically, it must be 1-63 characters long and match the regular
        /// expression `[a-z]([-a-z0-9]*[a-z0-9])?`
        /// which means the first character must be a lowercase letter, and all
        /// following characters must be a dash, lowercase letter, or digit, except
        /// the last character, which cannot be a dash.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SACRealm, OperationMetadata> CreateSACRealm(gagr::LocationName parent, SACRealm sacRealm, string sacRealmId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSACRealm(new CreateSACRealmRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SacRealmId = gax::GaxPreconditions.CheckNotNullOrEmpty(sacRealmId, nameof(sacRealmId)),
                SacRealm = gax::GaxPreconditions.CheckNotNull(sacRealm, nameof(sacRealm)),
            }, callSettings);

        /// <summary>
        /// Creates a new SACRealm in a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, in the form `projects/{project}/locations/global`.
        /// </param>
        /// <param name="sacRealm">
        /// Required. The resource being created.
        /// </param>
        /// <param name="sacRealmId">
        /// Required. ID of the created realm.
        /// The ID must be 1-63 characters long, and comply with
        /// &lt;a href="https://www.ietf.org/rfc/rfc1035.txt" target="_blank"&gt;RFC1035&lt;/a&gt;.
        /// Specifically, it must be 1-63 characters long and match the regular
        /// expression `[a-z]([-a-z0-9]*[a-z0-9])?`
        /// which means the first character must be a lowercase letter, and all
        /// following characters must be a dash, lowercase letter, or digit, except
        /// the last character, which cannot be a dash.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SACRealm, OperationMetadata>> CreateSACRealmAsync(gagr::LocationName parent, SACRealm sacRealm, string sacRealmId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSACRealmAsync(new CreateSACRealmRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SacRealmId = gax::GaxPreconditions.CheckNotNullOrEmpty(sacRealmId, nameof(sacRealmId)),
                SacRealm = gax::GaxPreconditions.CheckNotNull(sacRealm, nameof(sacRealm)),
            }, callSettings);

        /// <summary>
        /// Creates a new SACRealm in a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, in the form `projects/{project}/locations/global`.
        /// </param>
        /// <param name="sacRealm">
        /// Required. The resource being created.
        /// </param>
        /// <param name="sacRealmId">
        /// Required. ID of the created realm.
        /// The ID must be 1-63 characters long, and comply with
        /// &lt;a href="https://www.ietf.org/rfc/rfc1035.txt" target="_blank"&gt;RFC1035&lt;/a&gt;.
        /// Specifically, it must be 1-63 characters long and match the regular
        /// expression `[a-z]([-a-z0-9]*[a-z0-9])?`
        /// which means the first character must be a lowercase letter, and all
        /// following characters must be a dash, lowercase letter, or digit, except
        /// the last character, which cannot be a dash.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SACRealm, OperationMetadata>> CreateSACRealmAsync(gagr::LocationName parent, SACRealm sacRealm, string sacRealmId, st::CancellationToken cancellationToken) =>
            CreateSACRealmAsync(parent, sacRealm, sacRealmId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified realm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSACRealm(DeleteSACRealmRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified realm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSACRealmAsync(DeleteSACRealmRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified realm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSACRealmAsync(DeleteSACRealmRequest request, st::CancellationToken cancellationToken) =>
            DeleteSACRealmAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteSACRealm</c>.</summary>
        public virtual lro::OperationsClient DeleteSACRealmOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteSACRealm</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteSACRealm(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSACRealmOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteSACRealm</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteSACRealmAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSACRealmOperationsClient, callSettings);

        /// <summary>
        /// Deletes the specified realm.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the form
        /// `projects/{project}/locations/global/sacRealms/{sacRealm}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSACRealm(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSACRealm(new DeleteSACRealmRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified realm.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the form
        /// `projects/{project}/locations/global/sacRealms/{sacRealm}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSACRealmAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSACRealmAsync(new DeleteSACRealmRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified realm.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the form
        /// `projects/{project}/locations/global/sacRealms/{sacRealm}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSACRealmAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSACRealmAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified realm.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the form
        /// `projects/{project}/locations/global/sacRealms/{sacRealm}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSACRealm(SACRealmName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSACRealm(new DeleteSACRealmRequest
            {
                SACRealmName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified realm.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the form
        /// `projects/{project}/locations/global/sacRealms/{sacRealm}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSACRealmAsync(SACRealmName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSACRealmAsync(new DeleteSACRealmRequest
            {
                SACRealmName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified realm.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the form
        /// `projects/{project}/locations/global/sacRealms/{sacRealm}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSACRealmAsync(SACRealmName name, st::CancellationToken cancellationToken) =>
            DeleteSACRealmAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists SACAttachments in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SACAttachment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSACAttachmentsResponse, SACAttachment> ListSACAttachments(ListSACAttachmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists SACAttachments in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SACAttachment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSACAttachmentsResponse, SACAttachment> ListSACAttachmentsAsync(ListSACAttachmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists SACAttachments in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, in the form
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="SACAttachment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSACAttachmentsResponse, SACAttachment> ListSACAttachments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSACAttachmentsRequest request = new ListSACAttachmentsRequest
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
            return ListSACAttachments(request, callSettings);
        }

        /// <summary>
        /// Lists SACAttachments in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, in the form
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SACAttachment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSACAttachmentsResponse, SACAttachment> ListSACAttachmentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSACAttachmentsRequest request = new ListSACAttachmentsRequest
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
            return ListSACAttachmentsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists SACAttachments in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, in the form
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="SACAttachment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSACAttachmentsResponse, SACAttachment> ListSACAttachments(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSACAttachmentsRequest request = new ListSACAttachmentsRequest
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
            return ListSACAttachments(request, callSettings);
        }

        /// <summary>
        /// Lists SACAttachments in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, in the form
        /// `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SACAttachment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSACAttachmentsResponse, SACAttachment> ListSACAttachmentsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSACAttachmentsRequest request = new ListSACAttachmentsRequest
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
            return ListSACAttachmentsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified attachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SACAttachment GetSACAttachment(GetSACAttachmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified attachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SACAttachment> GetSACAttachmentAsync(GetSACAttachmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified attachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SACAttachment> GetSACAttachmentAsync(GetSACAttachmentRequest request, st::CancellationToken cancellationToken) =>
            GetSACAttachmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified attachment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the form
        /// `projects/{project}/locations/{location}/sacAttachments/{sac_attachment}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SACAttachment GetSACAttachment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSACAttachment(new GetSACAttachmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified attachment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the form
        /// `projects/{project}/locations/{location}/sacAttachments/{sac_attachment}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SACAttachment> GetSACAttachmentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSACAttachmentAsync(new GetSACAttachmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified attachment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the form
        /// `projects/{project}/locations/{location}/sacAttachments/{sac_attachment}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SACAttachment> GetSACAttachmentAsync(string name, st::CancellationToken cancellationToken) =>
            GetSACAttachmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified attachment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the form
        /// `projects/{project}/locations/{location}/sacAttachments/{sac_attachment}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SACAttachment GetSACAttachment(SACAttachmentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSACAttachment(new GetSACAttachmentRequest
            {
                SACAttachmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified attachment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the form
        /// `projects/{project}/locations/{location}/sacAttachments/{sac_attachment}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SACAttachment> GetSACAttachmentAsync(SACAttachmentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSACAttachmentAsync(new GetSACAttachmentRequest
            {
                SACAttachmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the specified attachment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the form
        /// `projects/{project}/locations/{location}/sacAttachments/{sac_attachment}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SACAttachment> GetSACAttachmentAsync(SACAttachmentName name, st::CancellationToken cancellationToken) =>
            GetSACAttachmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new SACAttachment in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SACAttachment, OperationMetadata> CreateSACAttachment(CreateSACAttachmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new SACAttachment in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SACAttachment, OperationMetadata>> CreateSACAttachmentAsync(CreateSACAttachmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new SACAttachment in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SACAttachment, OperationMetadata>> CreateSACAttachmentAsync(CreateSACAttachmentRequest request, st::CancellationToken cancellationToken) =>
            CreateSACAttachmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateSACAttachment</c>.</summary>
        public virtual lro::OperationsClient CreateSACAttachmentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateSACAttachment</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<SACAttachment, OperationMetadata> PollOnceCreateSACAttachment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SACAttachment, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSACAttachmentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateSACAttachment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<SACAttachment, OperationMetadata>> PollOnceCreateSACAttachmentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SACAttachment, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSACAttachmentOperationsClient, callSettings);

        /// <summary>
        /// Creates a new SACAttachment in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, in the form
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="sacAttachment">
        /// Required. The resource being created.
        /// </param>
        /// <param name="sacAttachmentId">
        /// Required. ID of the created attachment.
        /// The ID must be 1-63 characters long, and comply with
        /// &lt;a href="https://www.ietf.org/rfc/rfc1035.txt" target="_blank"&gt;RFC1035&lt;/a&gt;.
        /// Specifically, it must be 1-63 characters long and match the regular
        /// expression `[a-z]([-a-z0-9]*[a-z0-9])?`
        /// which means the first character must be a lowercase letter, and all
        /// following characters must be a dash, lowercase letter, or digit, except
        /// the last character, which cannot be a dash.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SACAttachment, OperationMetadata> CreateSACAttachment(string parent, SACAttachment sacAttachment, string sacAttachmentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSACAttachment(new CreateSACAttachmentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SacAttachmentId = gax::GaxPreconditions.CheckNotNullOrEmpty(sacAttachmentId, nameof(sacAttachmentId)),
                SacAttachment = gax::GaxPreconditions.CheckNotNull(sacAttachment, nameof(sacAttachment)),
            }, callSettings);

        /// <summary>
        /// Creates a new SACAttachment in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, in the form
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="sacAttachment">
        /// Required. The resource being created.
        /// </param>
        /// <param name="sacAttachmentId">
        /// Required. ID of the created attachment.
        /// The ID must be 1-63 characters long, and comply with
        /// &lt;a href="https://www.ietf.org/rfc/rfc1035.txt" target="_blank"&gt;RFC1035&lt;/a&gt;.
        /// Specifically, it must be 1-63 characters long and match the regular
        /// expression `[a-z]([-a-z0-9]*[a-z0-9])?`
        /// which means the first character must be a lowercase letter, and all
        /// following characters must be a dash, lowercase letter, or digit, except
        /// the last character, which cannot be a dash.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SACAttachment, OperationMetadata>> CreateSACAttachmentAsync(string parent, SACAttachment sacAttachment, string sacAttachmentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSACAttachmentAsync(new CreateSACAttachmentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SacAttachmentId = gax::GaxPreconditions.CheckNotNullOrEmpty(sacAttachmentId, nameof(sacAttachmentId)),
                SacAttachment = gax::GaxPreconditions.CheckNotNull(sacAttachment, nameof(sacAttachment)),
            }, callSettings);

        /// <summary>
        /// Creates a new SACAttachment in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, in the form
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="sacAttachment">
        /// Required. The resource being created.
        /// </param>
        /// <param name="sacAttachmentId">
        /// Required. ID of the created attachment.
        /// The ID must be 1-63 characters long, and comply with
        /// &lt;a href="https://www.ietf.org/rfc/rfc1035.txt" target="_blank"&gt;RFC1035&lt;/a&gt;.
        /// Specifically, it must be 1-63 characters long and match the regular
        /// expression `[a-z]([-a-z0-9]*[a-z0-9])?`
        /// which means the first character must be a lowercase letter, and all
        /// following characters must be a dash, lowercase letter, or digit, except
        /// the last character, which cannot be a dash.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SACAttachment, OperationMetadata>> CreateSACAttachmentAsync(string parent, SACAttachment sacAttachment, string sacAttachmentId, st::CancellationToken cancellationToken) =>
            CreateSACAttachmentAsync(parent, sacAttachment, sacAttachmentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new SACAttachment in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, in the form
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="sacAttachment">
        /// Required. The resource being created.
        /// </param>
        /// <param name="sacAttachmentId">
        /// Required. ID of the created attachment.
        /// The ID must be 1-63 characters long, and comply with
        /// &lt;a href="https://www.ietf.org/rfc/rfc1035.txt" target="_blank"&gt;RFC1035&lt;/a&gt;.
        /// Specifically, it must be 1-63 characters long and match the regular
        /// expression `[a-z]([-a-z0-9]*[a-z0-9])?`
        /// which means the first character must be a lowercase letter, and all
        /// following characters must be a dash, lowercase letter, or digit, except
        /// the last character, which cannot be a dash.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SACAttachment, OperationMetadata> CreateSACAttachment(gagr::LocationName parent, SACAttachment sacAttachment, string sacAttachmentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSACAttachment(new CreateSACAttachmentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SacAttachmentId = gax::GaxPreconditions.CheckNotNullOrEmpty(sacAttachmentId, nameof(sacAttachmentId)),
                SacAttachment = gax::GaxPreconditions.CheckNotNull(sacAttachment, nameof(sacAttachment)),
            }, callSettings);

        /// <summary>
        /// Creates a new SACAttachment in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, in the form
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="sacAttachment">
        /// Required. The resource being created.
        /// </param>
        /// <param name="sacAttachmentId">
        /// Required. ID of the created attachment.
        /// The ID must be 1-63 characters long, and comply with
        /// &lt;a href="https://www.ietf.org/rfc/rfc1035.txt" target="_blank"&gt;RFC1035&lt;/a&gt;.
        /// Specifically, it must be 1-63 characters long and match the regular
        /// expression `[a-z]([-a-z0-9]*[a-z0-9])?`
        /// which means the first character must be a lowercase letter, and all
        /// following characters must be a dash, lowercase letter, or digit, except
        /// the last character, which cannot be a dash.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SACAttachment, OperationMetadata>> CreateSACAttachmentAsync(gagr::LocationName parent, SACAttachment sacAttachment, string sacAttachmentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSACAttachmentAsync(new CreateSACAttachmentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SacAttachmentId = gax::GaxPreconditions.CheckNotNullOrEmpty(sacAttachmentId, nameof(sacAttachmentId)),
                SacAttachment = gax::GaxPreconditions.CheckNotNull(sacAttachment, nameof(sacAttachment)),
            }, callSettings);

        /// <summary>
        /// Creates a new SACAttachment in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, in the form
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="sacAttachment">
        /// Required. The resource being created.
        /// </param>
        /// <param name="sacAttachmentId">
        /// Required. ID of the created attachment.
        /// The ID must be 1-63 characters long, and comply with
        /// &lt;a href="https://www.ietf.org/rfc/rfc1035.txt" target="_blank"&gt;RFC1035&lt;/a&gt;.
        /// Specifically, it must be 1-63 characters long and match the regular
        /// expression `[a-z]([-a-z0-9]*[a-z0-9])?`
        /// which means the first character must be a lowercase letter, and all
        /// following characters must be a dash, lowercase letter, or digit, except
        /// the last character, which cannot be a dash.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SACAttachment, OperationMetadata>> CreateSACAttachmentAsync(gagr::LocationName parent, SACAttachment sacAttachment, string sacAttachmentId, st::CancellationToken cancellationToken) =>
            CreateSACAttachmentAsync(parent, sacAttachment, sacAttachmentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified attachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSACAttachment(DeleteSACAttachmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified attachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSACAttachmentAsync(DeleteSACAttachmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified attachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSACAttachmentAsync(DeleteSACAttachmentRequest request, st::CancellationToken cancellationToken) =>
            DeleteSACAttachmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteSACAttachment</c>.</summary>
        public virtual lro::OperationsClient DeleteSACAttachmentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteSACAttachment</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteSACAttachment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSACAttachmentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteSACAttachment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteSACAttachmentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSACAttachmentOperationsClient, callSettings);

        /// <summary>
        /// Deletes the specified attachment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the form
        /// `projects/{project}/locations/{location}/sacAttachments/{sac_attachment}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSACAttachment(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSACAttachment(new DeleteSACAttachmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified attachment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the form
        /// `projects/{project}/locations/{location}/sacAttachments/{sac_attachment}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSACAttachmentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSACAttachmentAsync(new DeleteSACAttachmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified attachment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the form
        /// `projects/{project}/locations/{location}/sacAttachments/{sac_attachment}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSACAttachmentAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSACAttachmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified attachment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the form
        /// `projects/{project}/locations/{location}/sacAttachments/{sac_attachment}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSACAttachment(SACAttachmentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSACAttachment(new DeleteSACAttachmentRequest
            {
                SACAttachmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified attachment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the form
        /// `projects/{project}/locations/{location}/sacAttachments/{sac_attachment}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSACAttachmentAsync(SACAttachmentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSACAttachmentAsync(new DeleteSACAttachmentRequest
            {
                SACAttachmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified attachment.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the form
        /// `projects/{project}/locations/{location}/sacAttachments/{sac_attachment}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSACAttachmentAsync(SACAttachmentName name, st::CancellationToken cancellationToken) =>
            DeleteSACAttachmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SSERealmService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public sealed partial class SSERealmServiceClientImpl : SSERealmServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListSACRealmsRequest, ListSACRealmsResponse> _callListSACRealms;

        private readonly gaxgrpc::ApiCall<GetSACRealmRequest, SACRealm> _callGetSACRealm;

        private readonly gaxgrpc::ApiCall<CreateSACRealmRequest, lro::Operation> _callCreateSACRealm;

        private readonly gaxgrpc::ApiCall<DeleteSACRealmRequest, lro::Operation> _callDeleteSACRealm;

        private readonly gaxgrpc::ApiCall<ListSACAttachmentsRequest, ListSACAttachmentsResponse> _callListSACAttachments;

        private readonly gaxgrpc::ApiCall<GetSACAttachmentRequest, SACAttachment> _callGetSACAttachment;

        private readonly gaxgrpc::ApiCall<CreateSACAttachmentRequest, lro::Operation> _callCreateSACAttachment;

        private readonly gaxgrpc::ApiCall<DeleteSACAttachmentRequest, lro::Operation> _callDeleteSACAttachment;

        /// <summary>
        /// Constructs a client wrapper for the SSERealmService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SSERealmServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SSERealmServiceClientImpl(SSERealmService.SSERealmServiceClient grpcClient, SSERealmServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SSERealmServiceSettings effectiveSettings = settings ?? SSERealmServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateSACRealmOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateSACRealmOperationsSettings, logger);
            DeleteSACRealmOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteSACRealmOperationsSettings, logger);
            CreateSACAttachmentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateSACAttachmentOperationsSettings, logger);
            DeleteSACAttachmentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteSACAttachmentOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListSACRealms = clientHelper.BuildApiCall<ListSACRealmsRequest, ListSACRealmsResponse>("ListSACRealms", grpcClient.ListSACRealmsAsync, grpcClient.ListSACRealms, effectiveSettings.ListSACRealmsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSACRealms);
            Modify_ListSACRealmsApiCall(ref _callListSACRealms);
            _callGetSACRealm = clientHelper.BuildApiCall<GetSACRealmRequest, SACRealm>("GetSACRealm", grpcClient.GetSACRealmAsync, grpcClient.GetSACRealm, effectiveSettings.GetSACRealmSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSACRealm);
            Modify_GetSACRealmApiCall(ref _callGetSACRealm);
            _callCreateSACRealm = clientHelper.BuildApiCall<CreateSACRealmRequest, lro::Operation>("CreateSACRealm", grpcClient.CreateSACRealmAsync, grpcClient.CreateSACRealm, effectiveSettings.CreateSACRealmSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSACRealm);
            Modify_CreateSACRealmApiCall(ref _callCreateSACRealm);
            _callDeleteSACRealm = clientHelper.BuildApiCall<DeleteSACRealmRequest, lro::Operation>("DeleteSACRealm", grpcClient.DeleteSACRealmAsync, grpcClient.DeleteSACRealm, effectiveSettings.DeleteSACRealmSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSACRealm);
            Modify_DeleteSACRealmApiCall(ref _callDeleteSACRealm);
            _callListSACAttachments = clientHelper.BuildApiCall<ListSACAttachmentsRequest, ListSACAttachmentsResponse>("ListSACAttachments", grpcClient.ListSACAttachmentsAsync, grpcClient.ListSACAttachments, effectiveSettings.ListSACAttachmentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSACAttachments);
            Modify_ListSACAttachmentsApiCall(ref _callListSACAttachments);
            _callGetSACAttachment = clientHelper.BuildApiCall<GetSACAttachmentRequest, SACAttachment>("GetSACAttachment", grpcClient.GetSACAttachmentAsync, grpcClient.GetSACAttachment, effectiveSettings.GetSACAttachmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSACAttachment);
            Modify_GetSACAttachmentApiCall(ref _callGetSACAttachment);
            _callCreateSACAttachment = clientHelper.BuildApiCall<CreateSACAttachmentRequest, lro::Operation>("CreateSACAttachment", grpcClient.CreateSACAttachmentAsync, grpcClient.CreateSACAttachment, effectiveSettings.CreateSACAttachmentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSACAttachment);
            Modify_CreateSACAttachmentApiCall(ref _callCreateSACAttachment);
            _callDeleteSACAttachment = clientHelper.BuildApiCall<DeleteSACAttachmentRequest, lro::Operation>("DeleteSACAttachment", grpcClient.DeleteSACAttachmentAsync, grpcClient.DeleteSACAttachment, effectiveSettings.DeleteSACAttachmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSACAttachment);
            Modify_DeleteSACAttachmentApiCall(ref _callDeleteSACAttachment);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListSACRealmsApiCall(ref gaxgrpc::ApiCall<ListSACRealmsRequest, ListSACRealmsResponse> call);

        partial void Modify_GetSACRealmApiCall(ref gaxgrpc::ApiCall<GetSACRealmRequest, SACRealm> call);

        partial void Modify_CreateSACRealmApiCall(ref gaxgrpc::ApiCall<CreateSACRealmRequest, lro::Operation> call);

        partial void Modify_DeleteSACRealmApiCall(ref gaxgrpc::ApiCall<DeleteSACRealmRequest, lro::Operation> call);

        partial void Modify_ListSACAttachmentsApiCall(ref gaxgrpc::ApiCall<ListSACAttachmentsRequest, ListSACAttachmentsResponse> call);

        partial void Modify_GetSACAttachmentApiCall(ref gaxgrpc::ApiCall<GetSACAttachmentRequest, SACAttachment> call);

        partial void Modify_CreateSACAttachmentApiCall(ref gaxgrpc::ApiCall<CreateSACAttachmentRequest, lro::Operation> call);

        partial void Modify_DeleteSACAttachmentApiCall(ref gaxgrpc::ApiCall<DeleteSACAttachmentRequest, lro::Operation> call);

        partial void OnConstruction(SSERealmService.SSERealmServiceClient grpcClient, SSERealmServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SSERealmService client</summary>
        public override SSERealmService.SSERealmServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListSACRealmsRequest(ref ListSACRealmsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSACRealmRequest(ref GetSACRealmRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSACRealmRequest(ref CreateSACRealmRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSACRealmRequest(ref DeleteSACRealmRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSACAttachmentsRequest(ref ListSACAttachmentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSACAttachmentRequest(ref GetSACAttachmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSACAttachmentRequest(ref CreateSACAttachmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSACAttachmentRequest(ref DeleteSACAttachmentRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists SACRealms in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SACRealm"/> resources.</returns>
        public override gax::PagedEnumerable<ListSACRealmsResponse, SACRealm> ListSACRealms(ListSACRealmsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSACRealmsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSACRealmsRequest, ListSACRealmsResponse, SACRealm>(_callListSACRealms, request, callSettings);
        }

        /// <summary>
        /// Lists SACRealms in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SACRealm"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSACRealmsResponse, SACRealm> ListSACRealmsAsync(ListSACRealmsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSACRealmsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSACRealmsRequest, ListSACRealmsResponse, SACRealm>(_callListSACRealms, request, callSettings);
        }

        /// <summary>
        /// Returns the specified realm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SACRealm GetSACRealm(GetSACRealmRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSACRealmRequest(ref request, ref callSettings);
            return _callGetSACRealm.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified realm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SACRealm> GetSACRealmAsync(GetSACRealmRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSACRealmRequest(ref request, ref callSettings);
            return _callGetSACRealm.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateSACRealm</c>.</summary>
        public override lro::OperationsClient CreateSACRealmOperationsClient { get; }

        /// <summary>
        /// Creates a new SACRealm in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<SACRealm, OperationMetadata> CreateSACRealm(CreateSACRealmRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSACRealmRequest(ref request, ref callSettings);
            return new lro::Operation<SACRealm, OperationMetadata>(_callCreateSACRealm.Sync(request, callSettings), CreateSACRealmOperationsClient);
        }

        /// <summary>
        /// Creates a new SACRealm in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<SACRealm, OperationMetadata>> CreateSACRealmAsync(CreateSACRealmRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSACRealmRequest(ref request, ref callSettings);
            return new lro::Operation<SACRealm, OperationMetadata>(await _callCreateSACRealm.Async(request, callSettings).ConfigureAwait(false), CreateSACRealmOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteSACRealm</c>.</summary>
        public override lro::OperationsClient DeleteSACRealmOperationsClient { get; }

        /// <summary>
        /// Deletes the specified realm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteSACRealm(DeleteSACRealmRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSACRealmRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteSACRealm.Sync(request, callSettings), DeleteSACRealmOperationsClient);
        }

        /// <summary>
        /// Deletes the specified realm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSACRealmAsync(DeleteSACRealmRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSACRealmRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteSACRealm.Async(request, callSettings).ConfigureAwait(false), DeleteSACRealmOperationsClient);
        }

        /// <summary>
        /// Lists SACAttachments in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SACAttachment"/> resources.</returns>
        public override gax::PagedEnumerable<ListSACAttachmentsResponse, SACAttachment> ListSACAttachments(ListSACAttachmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSACAttachmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSACAttachmentsRequest, ListSACAttachmentsResponse, SACAttachment>(_callListSACAttachments, request, callSettings);
        }

        /// <summary>
        /// Lists SACAttachments in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SACAttachment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSACAttachmentsResponse, SACAttachment> ListSACAttachmentsAsync(ListSACAttachmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSACAttachmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSACAttachmentsRequest, ListSACAttachmentsResponse, SACAttachment>(_callListSACAttachments, request, callSettings);
        }

        /// <summary>
        /// Returns the specified attachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SACAttachment GetSACAttachment(GetSACAttachmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSACAttachmentRequest(ref request, ref callSettings);
            return _callGetSACAttachment.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified attachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SACAttachment> GetSACAttachmentAsync(GetSACAttachmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSACAttachmentRequest(ref request, ref callSettings);
            return _callGetSACAttachment.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateSACAttachment</c>.</summary>
        public override lro::OperationsClient CreateSACAttachmentOperationsClient { get; }

        /// <summary>
        /// Creates a new SACAttachment in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<SACAttachment, OperationMetadata> CreateSACAttachment(CreateSACAttachmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSACAttachmentRequest(ref request, ref callSettings);
            return new lro::Operation<SACAttachment, OperationMetadata>(_callCreateSACAttachment.Sync(request, callSettings), CreateSACAttachmentOperationsClient);
        }

        /// <summary>
        /// Creates a new SACAttachment in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<SACAttachment, OperationMetadata>> CreateSACAttachmentAsync(CreateSACAttachmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSACAttachmentRequest(ref request, ref callSettings);
            return new lro::Operation<SACAttachment, OperationMetadata>(await _callCreateSACAttachment.Async(request, callSettings).ConfigureAwait(false), CreateSACAttachmentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteSACAttachment</c>.</summary>
        public override lro::OperationsClient DeleteSACAttachmentOperationsClient { get; }

        /// <summary>
        /// Deletes the specified attachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteSACAttachment(DeleteSACAttachmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSACAttachmentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteSACAttachment.Sync(request, callSettings), DeleteSACAttachmentOperationsClient);
        }

        /// <summary>
        /// Deletes the specified attachment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSACAttachmentAsync(DeleteSACAttachmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSACAttachmentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteSACAttachment.Async(request, callSettings).ConfigureAwait(false), DeleteSACAttachmentOperationsClient);
        }
    }

    public partial class ListSACRealmsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSACAttachmentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSACRealmsResponse : gaxgrpc::IPageResponse<SACRealm>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<SACRealm> GetEnumerator() => SacRealms.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSACAttachmentsResponse : gaxgrpc::IPageResponse<SACAttachment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<SACAttachment> GetEnumerator() => SacAttachments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class SSERealmService
    {
        public partial class SSERealmServiceClient
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

    public static partial class SSERealmService
    {
        public partial class SSERealmServiceClient
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
