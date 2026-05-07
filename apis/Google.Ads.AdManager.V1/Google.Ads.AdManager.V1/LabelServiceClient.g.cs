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
    /// <summary>Settings for <see cref="LabelServiceClient"/> instances.</summary>
    public sealed partial class LabelServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="LabelServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="LabelServiceSettings"/>.</returns>
        public static LabelServiceSettings GetDefault() => new LabelServiceSettings();

        /// <summary>Constructs a new <see cref="LabelServiceSettings"/> object with default settings.</summary>
        public LabelServiceSettings()
        {
        }

        private LabelServiceSettings(LabelServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetLabelSettings = existing.GetLabelSettings;
            ListLabelsSettings = existing.ListLabelsSettings;
            CreateLabelSettings = existing.CreateLabelSettings;
            BatchCreateLabelsSettings = existing.BatchCreateLabelsSettings;
            UpdateLabelSettings = existing.UpdateLabelSettings;
            BatchUpdateLabelsSettings = existing.BatchUpdateLabelsSettings;
            BatchActivateLabelsSettings = existing.BatchActivateLabelsSettings;
            BatchDeactivateLabelsSettings = existing.BatchDeactivateLabelsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(LabelServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>LabelServiceClient.GetLabel</c>
        ///  and <c>LabelServiceClient.GetLabelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetLabelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LabelServiceClient.ListLabels</c> and <c>LabelServiceClient.ListLabelsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListLabelsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LabelServiceClient.CreateLabel</c> and <c>LabelServiceClient.CreateLabelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateLabelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LabelServiceClient.BatchCreateLabels</c> and <c>LabelServiceClient.BatchCreateLabelsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateLabelsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LabelServiceClient.UpdateLabel</c> and <c>LabelServiceClient.UpdateLabelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateLabelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LabelServiceClient.BatchUpdateLabels</c> and <c>LabelServiceClient.BatchUpdateLabelsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchUpdateLabelsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LabelServiceClient.BatchActivateLabels</c> and <c>LabelServiceClient.BatchActivateLabelsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchActivateLabelsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LabelServiceClient.BatchDeactivateLabels</c> and <c>LabelServiceClient.BatchDeactivateLabelsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchDeactivateLabelsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="LabelServiceSettings"/> object.</returns>
        public LabelServiceSettings Clone() => new LabelServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="LabelServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class LabelServiceClientBuilder : gaxgrpc::ClientBuilderBase<LabelServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public LabelServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public LabelServiceClientBuilder() : base(LabelServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref LabelServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<LabelServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override LabelServiceClient Build()
        {
            LabelServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<LabelServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<LabelServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private LabelServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return LabelServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<LabelServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return LabelServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => LabelServiceClient.ChannelPool;
    }

    /// <summary>LabelService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `Label` objects.
    /// </remarks>
    public abstract partial class LabelServiceClient
    {
        /// <summary>
        /// The default endpoint for the LabelService service, which is a host of "admanager.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default LabelService scopes.</summary>
        /// <remarks>
        /// The default LabelService scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(LabelService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="LabelServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="LabelServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="LabelServiceClient"/>.</returns>
        public static stt::Task<LabelServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new LabelServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="LabelServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="LabelServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="LabelServiceClient"/>.</returns>
        public static LabelServiceClient Create() => new LabelServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="LabelServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="LabelServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="LabelServiceClient"/>.</returns>
        internal static LabelServiceClient Create(grpccore::CallInvoker callInvoker, LabelServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            LabelService.LabelServiceClient grpcClient = new LabelService.LabelServiceClient(callInvoker);
            return new LabelServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC LabelService client</summary>
        public virtual LabelService.LabelServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `Label` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Label GetLabel(GetLabelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `Label` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Label> GetLabelAsync(GetLabelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `Label` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Label> GetLabelAsync(GetLabelRequest request, st::CancellationToken cancellationToken) =>
            GetLabelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `Label` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Label.
        /// Format: `networks/{network_code}/labels/{label_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Label GetLabel(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLabel(new GetLabelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `Label` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Label.
        /// Format: `networks/{network_code}/labels/{label_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Label> GetLabelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLabelAsync(new GetLabelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `Label` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Label.
        /// Format: `networks/{network_code}/labels/{label_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Label> GetLabelAsync(string name, st::CancellationToken cancellationToken) =>
            GetLabelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `Label` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Label.
        /// Format: `networks/{network_code}/labels/{label_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Label GetLabel(LabelName name, gaxgrpc::CallSettings callSettings = null) =>
            GetLabel(new GetLabelRequest
            {
                LabelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `Label` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Label.
        /// Format: `networks/{network_code}/labels/{label_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Label> GetLabelAsync(LabelName name, gaxgrpc::CallSettings callSettings = null) =>
            GetLabelAsync(new GetLabelRequest
            {
                LabelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `Label` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Label.
        /// Format: `networks/{network_code}/labels/{label_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Label> GetLabelAsync(LabelName name, st::CancellationToken cancellationToken) =>
            GetLabelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a list of `Label` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Label"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLabelsResponse, Label> ListLabels(ListLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `Label` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Label"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLabelsResponse, Label> ListLabelsAsync(ListLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `Label` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Labels.
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
        /// <returns>A pageable sequence of <see cref="Label"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLabelsResponse, Label> ListLabels(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLabelsRequest request = new ListLabelsRequest
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
            return ListLabels(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Label` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Labels.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Label"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLabelsResponse, Label> ListLabelsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLabelsRequest request = new ListLabelsRequest
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
            return ListLabelsAsync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Label` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Labels.
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
        /// <returns>A pageable sequence of <see cref="Label"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLabelsResponse, Label> ListLabels(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLabelsRequest request = new ListLabelsRequest
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
            return ListLabels(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Label` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Labels.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Label"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLabelsResponse, Label> ListLabelsAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLabelsRequest request = new ListLabelsRequest
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
            return ListLabelsAsync(request, callSettings);
        }

        /// <summary>
        /// API to create a `Label` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Label CreateLabel(CreateLabelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to create a `Label` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Label> CreateLabelAsync(CreateLabelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to create a `Label` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Label> CreateLabelAsync(CreateLabelRequest request, st::CancellationToken cancellationToken) =>
            CreateLabelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to create a `Label` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Label` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="label">
        /// Required. The `Label` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Label CreateLabel(string parent, Label label, gaxgrpc::CallSettings callSettings = null) =>
            CreateLabel(new CreateLabelRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Label = gax::GaxPreconditions.CheckNotNull(label, nameof(label)),
            }, callSettings);

        /// <summary>
        /// API to create a `Label` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Label` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="label">
        /// Required. The `Label` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Label> CreateLabelAsync(string parent, Label label, gaxgrpc::CallSettings callSettings = null) =>
            CreateLabelAsync(new CreateLabelRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Label = gax::GaxPreconditions.CheckNotNull(label, nameof(label)),
            }, callSettings);

        /// <summary>
        /// API to create a `Label` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Label` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="label">
        /// Required. The `Label` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Label> CreateLabelAsync(string parent, Label label, st::CancellationToken cancellationToken) =>
            CreateLabelAsync(parent, label, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to create a `Label` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Label` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="label">
        /// Required. The `Label` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Label CreateLabel(NetworkName parent, Label label, gaxgrpc::CallSettings callSettings = null) =>
            CreateLabel(new CreateLabelRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Label = gax::GaxPreconditions.CheckNotNull(label, nameof(label)),
            }, callSettings);

        /// <summary>
        /// API to create a `Label` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Label` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="label">
        /// Required. The `Label` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Label> CreateLabelAsync(NetworkName parent, Label label, gaxgrpc::CallSettings callSettings = null) =>
            CreateLabelAsync(new CreateLabelRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Label = gax::GaxPreconditions.CheckNotNull(label, nameof(label)),
            }, callSettings);

        /// <summary>
        /// API to create a `Label` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `Label` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="label">
        /// Required. The `Label` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Label> CreateLabelAsync(NetworkName parent, Label label, st::CancellationToken cancellationToken) =>
            CreateLabelAsync(parent, label, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch create `Label` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateLabelsResponse BatchCreateLabels(BatchCreateLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to batch create `Label` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateLabelsResponse> BatchCreateLabelsAsync(BatchCreateLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to batch create `Label` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateLabelsResponse> BatchCreateLabelsAsync(BatchCreateLabelsRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateLabelsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch create `Label` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Labels` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateLabelRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Label` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateLabelsResponse BatchCreateLabels(string parent, scg::IEnumerable<CreateLabelRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateLabels(new BatchCreateLabelsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch create `Label` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Labels` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateLabelRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Label` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateLabelsResponse> BatchCreateLabelsAsync(string parent, scg::IEnumerable<CreateLabelRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateLabelsAsync(new BatchCreateLabelsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch create `Label` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Labels` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateLabelRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Label` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateLabelsResponse> BatchCreateLabelsAsync(string parent, scg::IEnumerable<CreateLabelRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateLabelsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch create `Label` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Labels` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateLabelRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Label` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateLabelsResponse BatchCreateLabels(NetworkName parent, scg::IEnumerable<CreateLabelRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateLabels(new BatchCreateLabelsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch create `Label` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Labels` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateLabelRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Label` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateLabelsResponse> BatchCreateLabelsAsync(NetworkName parent, scg::IEnumerable<CreateLabelRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateLabelsAsync(new BatchCreateLabelsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch create `Label` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Labels` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateLabelRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Label` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateLabelsResponse> BatchCreateLabelsAsync(NetworkName parent, scg::IEnumerable<CreateLabelRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateLabelsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to update a `Label` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Label UpdateLabel(UpdateLabelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to update a `Label` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Label> UpdateLabelAsync(UpdateLabelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to update a `Label` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Label> UpdateLabelAsync(UpdateLabelRequest request, st::CancellationToken cancellationToken) =>
            UpdateLabelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to update a `Label` object.
        /// </summary>
        /// <param name="label">
        /// Required. The `Label` to update.
        /// 
        /// The `Label`'s `name` is used to identify the `Label` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Label UpdateLabel(Label label, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateLabel(new UpdateLabelRequest
            {
                Label = gax::GaxPreconditions.CheckNotNull(label, nameof(label)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// API to update a `Label` object.
        /// </summary>
        /// <param name="label">
        /// Required. The `Label` to update.
        /// 
        /// The `Label`'s `name` is used to identify the `Label` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Label> UpdateLabelAsync(Label label, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateLabelAsync(new UpdateLabelRequest
            {
                Label = gax::GaxPreconditions.CheckNotNull(label, nameof(label)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// API to update a `Label` object.
        /// </summary>
        /// <param name="label">
        /// Required. The `Label` to update.
        /// 
        /// The `Label`'s `name` is used to identify the `Label` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Label> UpdateLabelAsync(Label label, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateLabelAsync(label, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch update `Label` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateLabelsResponse BatchUpdateLabels(BatchUpdateLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to batch update `Label` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateLabelsResponse> BatchUpdateLabelsAsync(BatchUpdateLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to batch update `Label` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateLabelsResponse> BatchUpdateLabelsAsync(BatchUpdateLabelsRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdateLabelsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch update `Label` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Labels` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateLabelRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Label` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateLabelsResponse BatchUpdateLabels(string parent, scg::IEnumerable<UpdateLabelRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateLabels(new BatchUpdateLabelsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch update `Label` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Labels` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateLabelRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Label` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateLabelsResponse> BatchUpdateLabelsAsync(string parent, scg::IEnumerable<UpdateLabelRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateLabelsAsync(new BatchUpdateLabelsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch update `Label` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Labels` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateLabelRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Label` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateLabelsResponse> BatchUpdateLabelsAsync(string parent, scg::IEnumerable<UpdateLabelRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateLabelsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to batch update `Label` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Labels` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateLabelRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Label` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateLabelsResponse BatchUpdateLabels(NetworkName parent, scg::IEnumerable<UpdateLabelRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateLabels(new BatchUpdateLabelsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch update `Label` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Labels` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateLabelRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Label` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateLabelsResponse> BatchUpdateLabelsAsync(NetworkName parent, scg::IEnumerable<UpdateLabelRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateLabelsAsync(new BatchUpdateLabelsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// API to batch update `Label` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `Labels` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateLabelRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `Label` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateLabelsResponse> BatchUpdateLabelsAsync(NetworkName parent, scg::IEnumerable<UpdateLabelRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateLabelsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to activate `Label` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateLabelsResponse BatchActivateLabels(BatchActivateLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to activate `Label` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateLabelsResponse> BatchActivateLabelsAsync(BatchActivateLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to activate `Label` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateLabelsResponse> BatchActivateLabelsAsync(BatchActivateLabelsRequest request, st::CancellationToken cancellationToken) =>
            BatchActivateLabelsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to activate `Label` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the Label.
        /// Format: `networks/{network_code}/labels/{label_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateLabelsResponse BatchActivateLabels(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateLabels(new BatchActivateLabelsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// API to activate `Label` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the Label.
        /// Format: `networks/{network_code}/labels/{label_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateLabelsResponse> BatchActivateLabelsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateLabelsAsync(new BatchActivateLabelsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// API to activate `Label` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the Label.
        /// Format: `networks/{network_code}/labels/{label_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateLabelsResponse> BatchActivateLabelsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchActivateLabelsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to activate `Label` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the Label.
        /// Format: `networks/{network_code}/labels/{label_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateLabelsResponse BatchActivateLabels(NetworkName parent, scg::IEnumerable<LabelName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateLabels(new BatchActivateLabelsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LabelNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// API to activate `Label` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the Label.
        /// Format: `networks/{network_code}/labels/{label_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateLabelsResponse> BatchActivateLabelsAsync(NetworkName parent, scg::IEnumerable<LabelName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateLabelsAsync(new BatchActivateLabelsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LabelNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// API to activate `Label` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the Label.
        /// Format: `networks/{network_code}/labels/{label_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateLabelsResponse> BatchActivateLabelsAsync(NetworkName parent, scg::IEnumerable<LabelName> names, st::CancellationToken cancellationToken) =>
            BatchActivateLabelsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to deactivate `Label` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateLabelsResponse BatchDeactivateLabels(BatchDeactivateLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to deactivate `Label` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateLabelsResponse> BatchDeactivateLabelsAsync(BatchDeactivateLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to deactivate `Label` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateLabelsResponse> BatchDeactivateLabelsAsync(BatchDeactivateLabelsRequest request, st::CancellationToken cancellationToken) =>
            BatchDeactivateLabelsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to deactivate `Label` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the Label.
        /// Format: `networks/{network_code}/labels/{label_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateLabelsResponse BatchDeactivateLabels(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateLabels(new BatchDeactivateLabelsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// API to deactivate `Label` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the Label.
        /// Format: `networks/{network_code}/labels/{label_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateLabelsResponse> BatchDeactivateLabelsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateLabelsAsync(new BatchDeactivateLabelsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// API to deactivate `Label` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the Label.
        /// Format: `networks/{network_code}/labels/{label_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateLabelsResponse> BatchDeactivateLabelsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchDeactivateLabelsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to deactivate `Label` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the Label.
        /// Format: `networks/{network_code}/labels/{label_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateLabelsResponse BatchDeactivateLabels(NetworkName parent, scg::IEnumerable<LabelName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateLabels(new BatchDeactivateLabelsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LabelNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// API to deactivate `Label` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the Label.
        /// Format: `networks/{network_code}/labels/{label_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateLabelsResponse> BatchDeactivateLabelsAsync(NetworkName parent, scg::IEnumerable<LabelName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateLabelsAsync(new BatchDeactivateLabelsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LabelNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// API to deactivate `Label` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. Resource names for the Label.
        /// Format: `networks/{network_code}/labels/{label_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateLabelsResponse> BatchDeactivateLabelsAsync(NetworkName parent, scg::IEnumerable<LabelName> names, st::CancellationToken cancellationToken) =>
            BatchDeactivateLabelsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>LabelService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `Label` objects.
    /// </remarks>
    public sealed partial class LabelServiceClientImpl : LabelServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetLabelRequest, Label> _callGetLabel;

        private readonly gaxgrpc::ApiCall<ListLabelsRequest, ListLabelsResponse> _callListLabels;

        private readonly gaxgrpc::ApiCall<CreateLabelRequest, Label> _callCreateLabel;

        private readonly gaxgrpc::ApiCall<BatchCreateLabelsRequest, BatchCreateLabelsResponse> _callBatchCreateLabels;

        private readonly gaxgrpc::ApiCall<UpdateLabelRequest, Label> _callUpdateLabel;

        private readonly gaxgrpc::ApiCall<BatchUpdateLabelsRequest, BatchUpdateLabelsResponse> _callBatchUpdateLabels;

        private readonly gaxgrpc::ApiCall<BatchActivateLabelsRequest, BatchActivateLabelsResponse> _callBatchActivateLabels;

        private readonly gaxgrpc::ApiCall<BatchDeactivateLabelsRequest, BatchDeactivateLabelsResponse> _callBatchDeactivateLabels;

        /// <summary>
        /// Constructs a client wrapper for the LabelService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="LabelServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public LabelServiceClientImpl(LabelService.LabelServiceClient grpcClient, LabelServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            LabelServiceSettings effectiveSettings = settings ?? LabelServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetLabel = clientHelper.BuildApiCall<GetLabelRequest, Label>("GetLabel", grpcClient.GetLabelAsync, grpcClient.GetLabel, effectiveSettings.GetLabelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetLabel);
            Modify_GetLabelApiCall(ref _callGetLabel);
            _callListLabels = clientHelper.BuildApiCall<ListLabelsRequest, ListLabelsResponse>("ListLabels", grpcClient.ListLabelsAsync, grpcClient.ListLabels, effectiveSettings.ListLabelsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListLabels);
            Modify_ListLabelsApiCall(ref _callListLabels);
            _callCreateLabel = clientHelper.BuildApiCall<CreateLabelRequest, Label>("CreateLabel", grpcClient.CreateLabelAsync, grpcClient.CreateLabel, effectiveSettings.CreateLabelSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateLabel);
            Modify_CreateLabelApiCall(ref _callCreateLabel);
            _callBatchCreateLabels = clientHelper.BuildApiCall<BatchCreateLabelsRequest, BatchCreateLabelsResponse>("BatchCreateLabels", grpcClient.BatchCreateLabelsAsync, grpcClient.BatchCreateLabels, effectiveSettings.BatchCreateLabelsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateLabels);
            Modify_BatchCreateLabelsApiCall(ref _callBatchCreateLabels);
            _callUpdateLabel = clientHelper.BuildApiCall<UpdateLabelRequest, Label>("UpdateLabel", grpcClient.UpdateLabelAsync, grpcClient.UpdateLabel, effectiveSettings.UpdateLabelSettings).WithGoogleRequestParam("label.name", request => request.Label?.Name);
            Modify_ApiCall(ref _callUpdateLabel);
            Modify_UpdateLabelApiCall(ref _callUpdateLabel);
            _callBatchUpdateLabels = clientHelper.BuildApiCall<BatchUpdateLabelsRequest, BatchUpdateLabelsResponse>("BatchUpdateLabels", grpcClient.BatchUpdateLabelsAsync, grpcClient.BatchUpdateLabels, effectiveSettings.BatchUpdateLabelsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUpdateLabels);
            Modify_BatchUpdateLabelsApiCall(ref _callBatchUpdateLabels);
            _callBatchActivateLabels = clientHelper.BuildApiCall<BatchActivateLabelsRequest, BatchActivateLabelsResponse>("BatchActivateLabels", grpcClient.BatchActivateLabelsAsync, grpcClient.BatchActivateLabels, effectiveSettings.BatchActivateLabelsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchActivateLabels);
            Modify_BatchActivateLabelsApiCall(ref _callBatchActivateLabels);
            _callBatchDeactivateLabels = clientHelper.BuildApiCall<BatchDeactivateLabelsRequest, BatchDeactivateLabelsResponse>("BatchDeactivateLabels", grpcClient.BatchDeactivateLabelsAsync, grpcClient.BatchDeactivateLabels, effectiveSettings.BatchDeactivateLabelsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchDeactivateLabels);
            Modify_BatchDeactivateLabelsApiCall(ref _callBatchDeactivateLabels);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetLabelApiCall(ref gaxgrpc::ApiCall<GetLabelRequest, Label> call);

        partial void Modify_ListLabelsApiCall(ref gaxgrpc::ApiCall<ListLabelsRequest, ListLabelsResponse> call);

        partial void Modify_CreateLabelApiCall(ref gaxgrpc::ApiCall<CreateLabelRequest, Label> call);

        partial void Modify_BatchCreateLabelsApiCall(ref gaxgrpc::ApiCall<BatchCreateLabelsRequest, BatchCreateLabelsResponse> call);

        partial void Modify_UpdateLabelApiCall(ref gaxgrpc::ApiCall<UpdateLabelRequest, Label> call);

        partial void Modify_BatchUpdateLabelsApiCall(ref gaxgrpc::ApiCall<BatchUpdateLabelsRequest, BatchUpdateLabelsResponse> call);

        partial void Modify_BatchActivateLabelsApiCall(ref gaxgrpc::ApiCall<BatchActivateLabelsRequest, BatchActivateLabelsResponse> call);

        partial void Modify_BatchDeactivateLabelsApiCall(ref gaxgrpc::ApiCall<BatchDeactivateLabelsRequest, BatchDeactivateLabelsResponse> call);

        partial void OnConstruction(LabelService.LabelServiceClient grpcClient, LabelServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC LabelService client</summary>
        public override LabelService.LabelServiceClient GrpcClient { get; }

        partial void Modify_GetLabelRequest(ref GetLabelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListLabelsRequest(ref ListLabelsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateLabelRequest(ref CreateLabelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateLabelsRequest(ref BatchCreateLabelsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateLabelRequest(ref UpdateLabelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdateLabelsRequest(ref BatchUpdateLabelsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchActivateLabelsRequest(ref BatchActivateLabelsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchDeactivateLabelsRequest(ref BatchDeactivateLabelsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// API to retrieve a `Label` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Label GetLabel(GetLabelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLabelRequest(ref request, ref callSettings);
            return _callGetLabel.Sync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a `Label` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Label> GetLabelAsync(GetLabelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLabelRequest(ref request, ref callSettings);
            return _callGetLabel.Async(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Label` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Label"/> resources.</returns>
        public override gax::PagedEnumerable<ListLabelsResponse, Label> ListLabels(ListLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLabelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListLabelsRequest, ListLabelsResponse, Label>(_callListLabels, request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Label` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Label"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListLabelsResponse, Label> ListLabelsAsync(ListLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLabelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListLabelsRequest, ListLabelsResponse, Label>(_callListLabels, request, callSettings);
        }

        /// <summary>
        /// API to create a `Label` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Label CreateLabel(CreateLabelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateLabelRequest(ref request, ref callSettings);
            return _callCreateLabel.Sync(request, callSettings);
        }

        /// <summary>
        /// API to create a `Label` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Label> CreateLabelAsync(CreateLabelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateLabelRequest(ref request, ref callSettings);
            return _callCreateLabel.Async(request, callSettings);
        }

        /// <summary>
        /// API to batch create `Label` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCreateLabelsResponse BatchCreateLabels(BatchCreateLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateLabelsRequest(ref request, ref callSettings);
            return _callBatchCreateLabels.Sync(request, callSettings);
        }

        /// <summary>
        /// API to batch create `Label` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCreateLabelsResponse> BatchCreateLabelsAsync(BatchCreateLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateLabelsRequest(ref request, ref callSettings);
            return _callBatchCreateLabels.Async(request, callSettings);
        }

        /// <summary>
        /// API to update a `Label` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Label UpdateLabel(UpdateLabelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateLabelRequest(ref request, ref callSettings);
            return _callUpdateLabel.Sync(request, callSettings);
        }

        /// <summary>
        /// API to update a `Label` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Label> UpdateLabelAsync(UpdateLabelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateLabelRequest(ref request, ref callSettings);
            return _callUpdateLabel.Async(request, callSettings);
        }

        /// <summary>
        /// API to batch update `Label` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchUpdateLabelsResponse BatchUpdateLabels(BatchUpdateLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateLabelsRequest(ref request, ref callSettings);
            return _callBatchUpdateLabels.Sync(request, callSettings);
        }

        /// <summary>
        /// API to batch update `Label` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchUpdateLabelsResponse> BatchUpdateLabelsAsync(BatchUpdateLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateLabelsRequest(ref request, ref callSettings);
            return _callBatchUpdateLabels.Async(request, callSettings);
        }

        /// <summary>
        /// API to activate `Label` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchActivateLabelsResponse BatchActivateLabels(BatchActivateLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchActivateLabelsRequest(ref request, ref callSettings);
            return _callBatchActivateLabels.Sync(request, callSettings);
        }

        /// <summary>
        /// API to activate `Label` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchActivateLabelsResponse> BatchActivateLabelsAsync(BatchActivateLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchActivateLabelsRequest(ref request, ref callSettings);
            return _callBatchActivateLabels.Async(request, callSettings);
        }

        /// <summary>
        /// API to deactivate `Label` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchDeactivateLabelsResponse BatchDeactivateLabels(BatchDeactivateLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeactivateLabelsRequest(ref request, ref callSettings);
            return _callBatchDeactivateLabels.Sync(request, callSettings);
        }

        /// <summary>
        /// API to deactivate `Label` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchDeactivateLabelsResponse> BatchDeactivateLabelsAsync(BatchDeactivateLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeactivateLabelsRequest(ref request, ref callSettings);
            return _callBatchDeactivateLabels.Async(request, callSettings);
        }
    }

    public partial class ListLabelsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListLabelsResponse : gaxgrpc::IPageResponse<Label>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Label> GetEnumerator() => Labels.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
