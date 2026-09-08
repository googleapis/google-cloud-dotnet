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
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Ads.AdManager.V1
{
    /// <summary>Settings for <see cref="BreakTemplateServiceClient"/> instances.</summary>
    public sealed partial class BreakTemplateServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BreakTemplateServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BreakTemplateServiceSettings"/>.</returns>
        public static BreakTemplateServiceSettings GetDefault() => new BreakTemplateServiceSettings();

        /// <summary>Constructs a new <see cref="BreakTemplateServiceSettings"/> object with default settings.</summary>
        public BreakTemplateServiceSettings()
        {
        }

        private BreakTemplateServiceSettings(BreakTemplateServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetBreakTemplateSettings = existing.GetBreakTemplateSettings;
            ListBreakTemplatesSettings = existing.ListBreakTemplatesSettings;
            CreateBreakTemplateSettings = existing.CreateBreakTemplateSettings;
            BatchCreateBreakTemplatesSettings = existing.BatchCreateBreakTemplatesSettings;
            UpdateBreakTemplateSettings = existing.UpdateBreakTemplateSettings;
            BatchUpdateBreakTemplatesSettings = existing.BatchUpdateBreakTemplatesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BreakTemplateServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BreakTemplateServiceClient.GetBreakTemplate</c> and <c>BreakTemplateServiceClient.GetBreakTemplateAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetBreakTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BreakTemplateServiceClient.ListBreakTemplates</c> and
        /// <c>BreakTemplateServiceClient.ListBreakTemplatesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListBreakTemplatesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BreakTemplateServiceClient.CreateBreakTemplate</c> and
        /// <c>BreakTemplateServiceClient.CreateBreakTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateBreakTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BreakTemplateServiceClient.BatchCreateBreakTemplates</c> and
        /// <c>BreakTemplateServiceClient.BatchCreateBreakTemplatesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateBreakTemplatesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BreakTemplateServiceClient.UpdateBreakTemplate</c> and
        /// <c>BreakTemplateServiceClient.UpdateBreakTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateBreakTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BreakTemplateServiceClient.BatchUpdateBreakTemplates</c> and
        /// <c>BreakTemplateServiceClient.BatchUpdateBreakTemplatesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchUpdateBreakTemplatesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BreakTemplateServiceSettings"/> object.</returns>
        public BreakTemplateServiceSettings Clone() => new BreakTemplateServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BreakTemplateServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class BreakTemplateServiceClientBuilder : gaxgrpc::ClientBuilderBase<BreakTemplateServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BreakTemplateServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public BreakTemplateServiceClientBuilder() : base(BreakTemplateServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref BreakTemplateServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<BreakTemplateServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override BreakTemplateServiceClient Build()
        {
            BreakTemplateServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<BreakTemplateServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<BreakTemplateServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private BreakTemplateServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BreakTemplateServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<BreakTemplateServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BreakTemplateServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BreakTemplateServiceClient.ChannelPool;
    }

    /// <summary>BreakTemplateService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `BreakTemplate` objects.
    /// </remarks>
    public abstract partial class BreakTemplateServiceClient
    {
        /// <summary>
        /// The default endpoint for the BreakTemplateService service, which is a host of "admanager.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default BreakTemplateService scopes.</summary>
        /// <remarks>
        /// The default BreakTemplateService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// <item><description>https://www.googleapis.com/auth/admanager.readonly</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
            "https://www.googleapis.com/auth/admanager.readonly",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(BreakTemplateService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="BreakTemplateServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="BreakTemplateServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="BreakTemplateServiceClient"/>.</returns>
        public static stt::Task<BreakTemplateServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new BreakTemplateServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="BreakTemplateServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="BreakTemplateServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="BreakTemplateServiceClient"/>.</returns>
        public static BreakTemplateServiceClient Create() => new BreakTemplateServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="BreakTemplateServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BreakTemplateServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="BreakTemplateServiceClient"/>.</returns>
        internal static BreakTemplateServiceClient Create(grpccore::CallInvoker callInvoker, BreakTemplateServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BreakTemplateService.BreakTemplateServiceClient grpcClient = new BreakTemplateService.BreakTemplateServiceClient(callInvoker);
            return new BreakTemplateServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC BreakTemplateService client</summary>
        public virtual BreakTemplateService.BreakTemplateServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `BreakTemplate` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BreakTemplate GetBreakTemplate(GetBreakTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `BreakTemplate` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BreakTemplate> GetBreakTemplateAsync(GetBreakTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `BreakTemplate` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BreakTemplate> GetBreakTemplateAsync(GetBreakTemplateRequest request, st::CancellationToken cancellationToken) =>
            GetBreakTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `BreakTemplate` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the `BreakTemplate`.
        /// Format: `networks/{network_code}/breakTemplates/{break_template_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BreakTemplate GetBreakTemplate(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBreakTemplate(new GetBreakTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `BreakTemplate` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the `BreakTemplate`.
        /// Format: `networks/{network_code}/breakTemplates/{break_template_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BreakTemplate> GetBreakTemplateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBreakTemplateAsync(new GetBreakTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `BreakTemplate` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the `BreakTemplate`.
        /// Format: `networks/{network_code}/breakTemplates/{break_template_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BreakTemplate> GetBreakTemplateAsync(string name, st::CancellationToken cancellationToken) =>
            GetBreakTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `BreakTemplate` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the `BreakTemplate`.
        /// Format: `networks/{network_code}/breakTemplates/{break_template_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BreakTemplate GetBreakTemplate(BreakTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBreakTemplate(new GetBreakTemplateRequest
            {
                BreakTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `BreakTemplate` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the `BreakTemplate`.
        /// Format: `networks/{network_code}/breakTemplates/{break_template_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BreakTemplate> GetBreakTemplateAsync(BreakTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBreakTemplateAsync(new GetBreakTemplateRequest
            {
                BreakTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `BreakTemplate` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the `BreakTemplate`.
        /// Format: `networks/{network_code}/breakTemplates/{break_template_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BreakTemplate> GetBreakTemplateAsync(BreakTemplateName name, st::CancellationToken cancellationToken) =>
            GetBreakTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists `BreakTemplate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BreakTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBreakTemplatesResponse, BreakTemplate> ListBreakTemplates(ListBreakTemplatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `BreakTemplate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BreakTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBreakTemplatesResponse, BreakTemplate> ListBreakTemplatesAsync(ListBreakTemplatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `BreakTemplate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of `BreakTemplates`.
        /// Format: `networks/{network_code}`
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
        /// <returns>A pageable sequence of <see cref="BreakTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBreakTemplatesResponse, BreakTemplate> ListBreakTemplates(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBreakTemplatesRequest request = new ListBreakTemplatesRequest
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
            return ListBreakTemplates(request, callSettings);
        }

        /// <summary>
        /// Lists `BreakTemplate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of `BreakTemplates`.
        /// Format: `networks/{network_code}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="BreakTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBreakTemplatesResponse, BreakTemplate> ListBreakTemplatesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBreakTemplatesRequest request = new ListBreakTemplatesRequest
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
            return ListBreakTemplatesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists `BreakTemplate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of `BreakTemplates`.
        /// Format: `networks/{network_code}`
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
        /// <returns>A pageable sequence of <see cref="BreakTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBreakTemplatesResponse, BreakTemplate> ListBreakTemplates(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBreakTemplatesRequest request = new ListBreakTemplatesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListBreakTemplates(request, callSettings);
        }

        /// <summary>
        /// Lists `BreakTemplate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of `BreakTemplates`.
        /// Format: `networks/{network_code}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="BreakTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBreakTemplatesResponse, BreakTemplate> ListBreakTemplatesAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBreakTemplatesRequest request = new ListBreakTemplatesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListBreakTemplatesAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a `BreakTemplate` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BreakTemplate CreateBreakTemplate(CreateBreakTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `BreakTemplate` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BreakTemplate> CreateBreakTemplateAsync(CreateBreakTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `BreakTemplate` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BreakTemplate> CreateBreakTemplateAsync(CreateBreakTemplateRequest request, st::CancellationToken cancellationToken) =>
            CreateBreakTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `BreakTemplate` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `BreakTemplate` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="breakTemplate">
        /// Required. The `BreakTemplate` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BreakTemplate CreateBreakTemplate(string parent, BreakTemplate breakTemplate, gaxgrpc::CallSettings callSettings = null) =>
            CreateBreakTemplate(new CreateBreakTemplateRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BreakTemplate = gax::GaxPreconditions.CheckNotNull(breakTemplate, nameof(breakTemplate)),
            }, callSettings);

        /// <summary>
        /// Creates a `BreakTemplate` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `BreakTemplate` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="breakTemplate">
        /// Required. The `BreakTemplate` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BreakTemplate> CreateBreakTemplateAsync(string parent, BreakTemplate breakTemplate, gaxgrpc::CallSettings callSettings = null) =>
            CreateBreakTemplateAsync(new CreateBreakTemplateRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BreakTemplate = gax::GaxPreconditions.CheckNotNull(breakTemplate, nameof(breakTemplate)),
            }, callSettings);

        /// <summary>
        /// Creates a `BreakTemplate` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `BreakTemplate` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="breakTemplate">
        /// Required. The `BreakTemplate` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BreakTemplate> CreateBreakTemplateAsync(string parent, BreakTemplate breakTemplate, st::CancellationToken cancellationToken) =>
            CreateBreakTemplateAsync(parent, breakTemplate, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `BreakTemplate` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `BreakTemplate` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="breakTemplate">
        /// Required. The `BreakTemplate` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BreakTemplate CreateBreakTemplate(NetworkName parent, BreakTemplate breakTemplate, gaxgrpc::CallSettings callSettings = null) =>
            CreateBreakTemplate(new CreateBreakTemplateRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BreakTemplate = gax::GaxPreconditions.CheckNotNull(breakTemplate, nameof(breakTemplate)),
            }, callSettings);

        /// <summary>
        /// Creates a `BreakTemplate` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `BreakTemplate` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="breakTemplate">
        /// Required. The `BreakTemplate` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BreakTemplate> CreateBreakTemplateAsync(NetworkName parent, BreakTemplate breakTemplate, gaxgrpc::CallSettings callSettings = null) =>
            CreateBreakTemplateAsync(new CreateBreakTemplateRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BreakTemplate = gax::GaxPreconditions.CheckNotNull(breakTemplate, nameof(breakTemplate)),
            }, callSettings);

        /// <summary>
        /// Creates a `BreakTemplate` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `BreakTemplate` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="breakTemplate">
        /// Required. The `BreakTemplate` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BreakTemplate> CreateBreakTemplateAsync(NetworkName parent, BreakTemplate breakTemplate, st::CancellationToken cancellationToken) =>
            CreateBreakTemplateAsync(parent, breakTemplate, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch creates `BreakTemplate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateBreakTemplatesResponse BatchCreateBreakTemplates(BatchCreateBreakTemplatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch creates `BreakTemplate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateBreakTemplatesResponse> BatchCreateBreakTemplatesAsync(BatchCreateBreakTemplatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch creates `BreakTemplate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateBreakTemplatesResponse> BatchCreateBreakTemplatesAsync(BatchCreateBreakTemplatesRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateBreakTemplatesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch creates `BreakTemplate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `BreakTemplates` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the `CreateBreakTemplateRequest` must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `BreakTemplate` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateBreakTemplatesResponse BatchCreateBreakTemplates(string parent, scg::IEnumerable<CreateBreakTemplateRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateBreakTemplates(new BatchCreateBreakTemplatesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch creates `BreakTemplate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `BreakTemplates` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the `CreateBreakTemplateRequest` must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `BreakTemplate` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateBreakTemplatesResponse> BatchCreateBreakTemplatesAsync(string parent, scg::IEnumerable<CreateBreakTemplateRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateBreakTemplatesAsync(new BatchCreateBreakTemplatesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch creates `BreakTemplate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `BreakTemplates` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the `CreateBreakTemplateRequest` must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `BreakTemplate` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateBreakTemplatesResponse> BatchCreateBreakTemplatesAsync(string parent, scg::IEnumerable<CreateBreakTemplateRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateBreakTemplatesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch creates `BreakTemplate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `BreakTemplates` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the `CreateBreakTemplateRequest` must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `BreakTemplate` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateBreakTemplatesResponse BatchCreateBreakTemplates(NetworkName parent, scg::IEnumerable<CreateBreakTemplateRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateBreakTemplates(new BatchCreateBreakTemplatesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch creates `BreakTemplate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `BreakTemplates` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the `CreateBreakTemplateRequest` must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `BreakTemplate` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateBreakTemplatesResponse> BatchCreateBreakTemplatesAsync(NetworkName parent, scg::IEnumerable<CreateBreakTemplateRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateBreakTemplatesAsync(new BatchCreateBreakTemplatesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch creates `BreakTemplate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `BreakTemplates` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the `CreateBreakTemplateRequest` must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `BreakTemplate` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateBreakTemplatesResponse> BatchCreateBreakTemplatesAsync(NetworkName parent, scg::IEnumerable<CreateBreakTemplateRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateBreakTemplatesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `BreakTemplate` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BreakTemplate UpdateBreakTemplate(UpdateBreakTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `BreakTemplate` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BreakTemplate> UpdateBreakTemplateAsync(UpdateBreakTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `BreakTemplate` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BreakTemplate> UpdateBreakTemplateAsync(UpdateBreakTemplateRequest request, st::CancellationToken cancellationToken) =>
            UpdateBreakTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `BreakTemplate` object.
        /// </summary>
        /// <param name="breakTemplate">
        /// Required. The `BreakTemplate` to update.
        /// 
        /// The `BreakTemplate`'s `name` is used to identify the `BreakTemplate` to
        /// update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BreakTemplate UpdateBreakTemplate(BreakTemplate breakTemplate, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBreakTemplate(new UpdateBreakTemplateRequest
            {
                BreakTemplate = gax::GaxPreconditions.CheckNotNull(breakTemplate, nameof(breakTemplate)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a `BreakTemplate` object.
        /// </summary>
        /// <param name="breakTemplate">
        /// Required. The `BreakTemplate` to update.
        /// 
        /// The `BreakTemplate`'s `name` is used to identify the `BreakTemplate` to
        /// update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BreakTemplate> UpdateBreakTemplateAsync(BreakTemplate breakTemplate, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBreakTemplateAsync(new UpdateBreakTemplateRequest
            {
                BreakTemplate = gax::GaxPreconditions.CheckNotNull(breakTemplate, nameof(breakTemplate)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a `BreakTemplate` object.
        /// </summary>
        /// <param name="breakTemplate">
        /// Required. The `BreakTemplate` to update.
        /// 
        /// The `BreakTemplate`'s `name` is used to identify the `BreakTemplate` to
        /// update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BreakTemplate> UpdateBreakTemplateAsync(BreakTemplate breakTemplate, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateBreakTemplateAsync(breakTemplate, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `BreakTemplate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateBreakTemplatesResponse BatchUpdateBreakTemplates(BatchUpdateBreakTemplatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates `BreakTemplate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateBreakTemplatesResponse> BatchUpdateBreakTemplatesAsync(BatchUpdateBreakTemplatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates `BreakTemplate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateBreakTemplatesResponse> BatchUpdateBreakTemplatesAsync(BatchUpdateBreakTemplatesRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdateBreakTemplatesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `BreakTemplate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `BreakTemplates` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the `UpdateBreakTemplateRequest` must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `BreakTemplate` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateBreakTemplatesResponse BatchUpdateBreakTemplates(string parent, scg::IEnumerable<UpdateBreakTemplateRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateBreakTemplates(new BatchUpdateBreakTemplatesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `BreakTemplate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `BreakTemplates` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the `UpdateBreakTemplateRequest` must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `BreakTemplate` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateBreakTemplatesResponse> BatchUpdateBreakTemplatesAsync(string parent, scg::IEnumerable<UpdateBreakTemplateRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateBreakTemplatesAsync(new BatchUpdateBreakTemplatesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `BreakTemplate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `BreakTemplates` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the `UpdateBreakTemplateRequest` must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `BreakTemplate` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateBreakTemplatesResponse> BatchUpdateBreakTemplatesAsync(string parent, scg::IEnumerable<UpdateBreakTemplateRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateBreakTemplatesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `BreakTemplate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `BreakTemplates` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the `UpdateBreakTemplateRequest` must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `BreakTemplate` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateBreakTemplatesResponse BatchUpdateBreakTemplates(NetworkName parent, scg::IEnumerable<UpdateBreakTemplateRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateBreakTemplates(new BatchUpdateBreakTemplatesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `BreakTemplate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `BreakTemplates` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the `UpdateBreakTemplateRequest` must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `BreakTemplate` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateBreakTemplatesResponse> BatchUpdateBreakTemplatesAsync(NetworkName parent, scg::IEnumerable<UpdateBreakTemplateRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateBreakTemplatesAsync(new BatchUpdateBreakTemplatesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `BreakTemplate` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `BreakTemplates` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the `UpdateBreakTemplateRequest` must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `BreakTemplate` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateBreakTemplatesResponse> BatchUpdateBreakTemplatesAsync(NetworkName parent, scg::IEnumerable<UpdateBreakTemplateRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateBreakTemplatesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>BreakTemplateService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `BreakTemplate` objects.
    /// </remarks>
    public sealed partial class BreakTemplateServiceClientImpl : BreakTemplateServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetBreakTemplateRequest, BreakTemplate> _callGetBreakTemplate;

        private readonly gaxgrpc::ApiCall<ListBreakTemplatesRequest, ListBreakTemplatesResponse> _callListBreakTemplates;

        private readonly gaxgrpc::ApiCall<CreateBreakTemplateRequest, BreakTemplate> _callCreateBreakTemplate;

        private readonly gaxgrpc::ApiCall<BatchCreateBreakTemplatesRequest, BatchCreateBreakTemplatesResponse> _callBatchCreateBreakTemplates;

        private readonly gaxgrpc::ApiCall<UpdateBreakTemplateRequest, BreakTemplate> _callUpdateBreakTemplate;

        private readonly gaxgrpc::ApiCall<BatchUpdateBreakTemplatesRequest, BatchUpdateBreakTemplatesResponse> _callBatchUpdateBreakTemplates;

        /// <summary>
        /// Constructs a client wrapper for the BreakTemplateService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="BreakTemplateServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public BreakTemplateServiceClientImpl(BreakTemplateService.BreakTemplateServiceClient grpcClient, BreakTemplateServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            BreakTemplateServiceSettings effectiveSettings = settings ?? BreakTemplateServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetBreakTemplate = clientHelper.BuildApiCall<GetBreakTemplateRequest, BreakTemplate>("GetBreakTemplate", grpcClient.GetBreakTemplateAsync, grpcClient.GetBreakTemplate, effectiveSettings.GetBreakTemplateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetBreakTemplate);
            Modify_GetBreakTemplateApiCall(ref _callGetBreakTemplate);
            _callListBreakTemplates = clientHelper.BuildApiCall<ListBreakTemplatesRequest, ListBreakTemplatesResponse>("ListBreakTemplates", grpcClient.ListBreakTemplatesAsync, grpcClient.ListBreakTemplates, effectiveSettings.ListBreakTemplatesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListBreakTemplates);
            Modify_ListBreakTemplatesApiCall(ref _callListBreakTemplates);
            _callCreateBreakTemplate = clientHelper.BuildApiCall<CreateBreakTemplateRequest, BreakTemplate>("CreateBreakTemplate", grpcClient.CreateBreakTemplateAsync, grpcClient.CreateBreakTemplate, effectiveSettings.CreateBreakTemplateSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateBreakTemplate);
            Modify_CreateBreakTemplateApiCall(ref _callCreateBreakTemplate);
            _callBatchCreateBreakTemplates = clientHelper.BuildApiCall<BatchCreateBreakTemplatesRequest, BatchCreateBreakTemplatesResponse>("BatchCreateBreakTemplates", grpcClient.BatchCreateBreakTemplatesAsync, grpcClient.BatchCreateBreakTemplates, effectiveSettings.BatchCreateBreakTemplatesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateBreakTemplates);
            Modify_BatchCreateBreakTemplatesApiCall(ref _callBatchCreateBreakTemplates);
            _callUpdateBreakTemplate = clientHelper.BuildApiCall<UpdateBreakTemplateRequest, BreakTemplate>("UpdateBreakTemplate", grpcClient.UpdateBreakTemplateAsync, grpcClient.UpdateBreakTemplate, effectiveSettings.UpdateBreakTemplateSettings).WithGoogleRequestParam("break_template.name", request => request.BreakTemplate?.Name);
            Modify_ApiCall(ref _callUpdateBreakTemplate);
            Modify_UpdateBreakTemplateApiCall(ref _callUpdateBreakTemplate);
            _callBatchUpdateBreakTemplates = clientHelper.BuildApiCall<BatchUpdateBreakTemplatesRequest, BatchUpdateBreakTemplatesResponse>("BatchUpdateBreakTemplates", grpcClient.BatchUpdateBreakTemplatesAsync, grpcClient.BatchUpdateBreakTemplates, effectiveSettings.BatchUpdateBreakTemplatesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUpdateBreakTemplates);
            Modify_BatchUpdateBreakTemplatesApiCall(ref _callBatchUpdateBreakTemplates);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetBreakTemplateApiCall(ref gaxgrpc::ApiCall<GetBreakTemplateRequest, BreakTemplate> call);

        partial void Modify_ListBreakTemplatesApiCall(ref gaxgrpc::ApiCall<ListBreakTemplatesRequest, ListBreakTemplatesResponse> call);

        partial void Modify_CreateBreakTemplateApiCall(ref gaxgrpc::ApiCall<CreateBreakTemplateRequest, BreakTemplate> call);

        partial void Modify_BatchCreateBreakTemplatesApiCall(ref gaxgrpc::ApiCall<BatchCreateBreakTemplatesRequest, BatchCreateBreakTemplatesResponse> call);

        partial void Modify_UpdateBreakTemplateApiCall(ref gaxgrpc::ApiCall<UpdateBreakTemplateRequest, BreakTemplate> call);

        partial void Modify_BatchUpdateBreakTemplatesApiCall(ref gaxgrpc::ApiCall<BatchUpdateBreakTemplatesRequest, BatchUpdateBreakTemplatesResponse> call);

        partial void OnConstruction(BreakTemplateService.BreakTemplateServiceClient grpcClient, BreakTemplateServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC BreakTemplateService client</summary>
        public override BreakTemplateService.BreakTemplateServiceClient GrpcClient { get; }

        partial void Modify_GetBreakTemplateRequest(ref GetBreakTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBreakTemplatesRequest(ref ListBreakTemplatesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateBreakTemplateRequest(ref CreateBreakTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateBreakTemplatesRequest(ref BatchCreateBreakTemplatesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateBreakTemplateRequest(ref UpdateBreakTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdateBreakTemplatesRequest(ref BatchUpdateBreakTemplatesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves a `BreakTemplate` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BreakTemplate GetBreakTemplate(GetBreakTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBreakTemplateRequest(ref request, ref callSettings);
            return _callGetBreakTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a `BreakTemplate` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BreakTemplate> GetBreakTemplateAsync(GetBreakTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBreakTemplateRequest(ref request, ref callSettings);
            return _callGetBreakTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Lists `BreakTemplate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BreakTemplate"/> resources.</returns>
        public override gax::PagedEnumerable<ListBreakTemplatesResponse, BreakTemplate> ListBreakTemplates(ListBreakTemplatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBreakTemplatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListBreakTemplatesRequest, ListBreakTemplatesResponse, BreakTemplate>(_callListBreakTemplates, request, callSettings);
        }

        /// <summary>
        /// Lists `BreakTemplate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BreakTemplate"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBreakTemplatesResponse, BreakTemplate> ListBreakTemplatesAsync(ListBreakTemplatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBreakTemplatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBreakTemplatesRequest, ListBreakTemplatesResponse, BreakTemplate>(_callListBreakTemplates, request, callSettings);
        }

        /// <summary>
        /// Creates a `BreakTemplate` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BreakTemplate CreateBreakTemplate(CreateBreakTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBreakTemplateRequest(ref request, ref callSettings);
            return _callCreateBreakTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a `BreakTemplate` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BreakTemplate> CreateBreakTemplateAsync(CreateBreakTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBreakTemplateRequest(ref request, ref callSettings);
            return _callCreateBreakTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Batch creates `BreakTemplate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCreateBreakTemplatesResponse BatchCreateBreakTemplates(BatchCreateBreakTemplatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateBreakTemplatesRequest(ref request, ref callSettings);
            return _callBatchCreateBreakTemplates.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch creates `BreakTemplate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCreateBreakTemplatesResponse> BatchCreateBreakTemplatesAsync(BatchCreateBreakTemplatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateBreakTemplatesRequest(ref request, ref callSettings);
            return _callBatchCreateBreakTemplates.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a `BreakTemplate` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BreakTemplate UpdateBreakTemplate(UpdateBreakTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBreakTemplateRequest(ref request, ref callSettings);
            return _callUpdateBreakTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a `BreakTemplate` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BreakTemplate> UpdateBreakTemplateAsync(UpdateBreakTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBreakTemplateRequest(ref request, ref callSettings);
            return _callUpdateBreakTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Batch updates `BreakTemplate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchUpdateBreakTemplatesResponse BatchUpdateBreakTemplates(BatchUpdateBreakTemplatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateBreakTemplatesRequest(ref request, ref callSettings);
            return _callBatchUpdateBreakTemplates.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch updates `BreakTemplate` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchUpdateBreakTemplatesResponse> BatchUpdateBreakTemplatesAsync(BatchUpdateBreakTemplatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateBreakTemplatesRequest(ref request, ref callSettings);
            return _callBatchUpdateBreakTemplates.Async(request, callSettings);
        }
    }

    public partial class ListBreakTemplatesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBreakTemplatesResponse : gaxgrpc::IPageResponse<BreakTemplate>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<BreakTemplate> GetEnumerator() => BreakTemplates.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
