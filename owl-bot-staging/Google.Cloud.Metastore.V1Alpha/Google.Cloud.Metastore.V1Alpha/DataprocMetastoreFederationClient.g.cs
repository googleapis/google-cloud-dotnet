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

namespace Google.Cloud.Metastore.V1Alpha
{
    /// <summary>Settings for <see cref="DataprocMetastoreFederationClient"/> instances.</summary>
    public sealed partial class DataprocMetastoreFederationSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DataprocMetastoreFederationSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DataprocMetastoreFederationSettings"/>.</returns>
        public static DataprocMetastoreFederationSettings GetDefault() => new DataprocMetastoreFederationSettings();

        /// <summary>
        /// Constructs a new <see cref="DataprocMetastoreFederationSettings"/> object with default settings.
        /// </summary>
        public DataprocMetastoreFederationSettings()
        {
        }

        private DataprocMetastoreFederationSettings(DataprocMetastoreFederationSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListFederationsSettings = existing.ListFederationsSettings;
            GetFederationSettings = existing.GetFederationSettings;
            CreateFederationSettings = existing.CreateFederationSettings;
            CreateFederationOperationsSettings = existing.CreateFederationOperationsSettings.Clone();
            UpdateFederationSettings = existing.UpdateFederationSettings;
            UpdateFederationOperationsSettings = existing.UpdateFederationOperationsSettings.Clone();
            DeleteFederationSettings = existing.DeleteFederationSettings;
            DeleteFederationOperationsSettings = existing.DeleteFederationOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(DataprocMetastoreFederationSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataprocMetastoreFederationClient.ListFederations</c> and
        /// <c>DataprocMetastoreFederationClient.ListFederationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListFederationsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataprocMetastoreFederationClient.GetFederation</c> and
        /// <c>DataprocMetastoreFederationClient.GetFederationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetFederationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataprocMetastoreFederationClient.CreateFederation</c> and
        /// <c>DataprocMetastoreFederationClient.CreateFederationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateFederationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataprocMetastoreFederationClient.CreateFederation</c> and
        /// <c>DataprocMetastoreFederationClient.CreateFederationAsync</c>.
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
        public lro::OperationsSettings CreateFederationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataprocMetastoreFederationClient.UpdateFederation</c> and
        /// <c>DataprocMetastoreFederationClient.UpdateFederationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateFederationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataprocMetastoreFederationClient.UpdateFederation</c> and
        /// <c>DataprocMetastoreFederationClient.UpdateFederationAsync</c>.
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
        public lro::OperationsSettings UpdateFederationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataprocMetastoreFederationClient.DeleteFederation</c> and
        /// <c>DataprocMetastoreFederationClient.DeleteFederationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteFederationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataprocMetastoreFederationClient.DeleteFederation</c> and
        /// <c>DataprocMetastoreFederationClient.DeleteFederationAsync</c>.
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
        public lro::OperationsSettings DeleteFederationOperationsSettings { get; set; } = new lro::OperationsSettings
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
        /// <returns>A deep clone of this <see cref="DataprocMetastoreFederationSettings"/> object.</returns>
        public DataprocMetastoreFederationSettings Clone() => new DataprocMetastoreFederationSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DataprocMetastoreFederationClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class DataprocMetastoreFederationClientBuilder : gaxgrpc::ClientBuilderBase<DataprocMetastoreFederationClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DataprocMetastoreFederationSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DataprocMetastoreFederationClientBuilder() : base(DataprocMetastoreFederationClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DataprocMetastoreFederationClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DataprocMetastoreFederationClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DataprocMetastoreFederationClient Build()
        {
            DataprocMetastoreFederationClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DataprocMetastoreFederationClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DataprocMetastoreFederationClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DataprocMetastoreFederationClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DataprocMetastoreFederationClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DataprocMetastoreFederationClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DataprocMetastoreFederationClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DataprocMetastoreFederationClient.ChannelPool;
    }

    /// <summary>DataprocMetastoreFederation client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Configures and manages metastore federation services.
    /// Dataproc Metastore Federation Service allows federating a collection of
    /// backend metastores like BigQuery, Dataplex Lakes, and other Dataproc
    /// Metastores. The Federation Service exposes a gRPC URL through which metadata
    /// from the backend metastores are served at query time.
    /// 
    /// The Dataproc Metastore Federation API defines the following resource model:
    /// * The service works with a collection of Google Cloud projects.
    /// * Each project has a collection of available locations.
    /// * Each location has a collection of federations.
    /// * Dataproc Metastore Federations are resources with names of the
    /// form:
    /// `projects/{project_number}/locations/{location_id}/federations/{federation_id}`.
    /// </remarks>
    public abstract partial class DataprocMetastoreFederationClient
    {
        /// <summary>
        /// The default endpoint for the DataprocMetastoreFederation service, which is a host of
        /// "metastore.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "metastore.googleapis.com:443";

        /// <summary>The default DataprocMetastoreFederation scopes.</summary>
        /// <remarks>
        /// The default DataprocMetastoreFederation scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DataprocMetastoreFederation.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DataprocMetastoreFederationClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="DataprocMetastoreFederationClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DataprocMetastoreFederationClient"/>.</returns>
        public static stt::Task<DataprocMetastoreFederationClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DataprocMetastoreFederationClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DataprocMetastoreFederationClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="DataprocMetastoreFederationClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DataprocMetastoreFederationClient"/>.</returns>
        public static DataprocMetastoreFederationClient Create() => new DataprocMetastoreFederationClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DataprocMetastoreFederationClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DataprocMetastoreFederationSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DataprocMetastoreFederationClient"/>.</returns>
        internal static DataprocMetastoreFederationClient Create(grpccore::CallInvoker callInvoker, DataprocMetastoreFederationSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DataprocMetastoreFederation.DataprocMetastoreFederationClient grpcClient = new DataprocMetastoreFederation.DataprocMetastoreFederationClient(callInvoker);
            return new DataprocMetastoreFederationClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DataprocMetastoreFederation client</summary>
        public virtual DataprocMetastoreFederation.DataprocMetastoreFederationClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists federations in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Federation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFederationsResponse, Federation> ListFederations(ListFederationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists federations in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Federation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFederationsResponse, Federation> ListFederationsAsync(ListFederationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists federations in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the location of metastore
        /// federations to list, in the following form:
        /// `projects/{project_number}/locations/{location_id}`.
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
        /// <returns>A pageable sequence of <see cref="Federation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFederationsResponse, Federation> ListFederations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFederationsRequest request = new ListFederationsRequest
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
            return ListFederations(request, callSettings);
        }

        /// <summary>
        /// Lists federations in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the location of metastore
        /// federations to list, in the following form:
        /// `projects/{project_number}/locations/{location_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Federation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFederationsResponse, Federation> ListFederationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFederationsRequest request = new ListFederationsRequest
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
            return ListFederationsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists federations in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the location of metastore
        /// federations to list, in the following form:
        /// `projects/{project_number}/locations/{location_id}`.
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
        /// <returns>A pageable sequence of <see cref="Federation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFederationsResponse, Federation> ListFederations(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFederationsRequest request = new ListFederationsRequest
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
            return ListFederations(request, callSettings);
        }

        /// <summary>
        /// Lists federations in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the location of metastore
        /// federations to list, in the following form:
        /// `projects/{project_number}/locations/{location_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Federation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFederationsResponse, Federation> ListFederationsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFederationsRequest request = new ListFederationsRequest
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
            return ListFederationsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a single federation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Federation GetFederation(GetFederationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a single federation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Federation> GetFederationAsync(GetFederationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a single federation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Federation> GetFederationAsync(GetFederationRequest request, st::CancellationToken cancellationToken) =>
            GetFederationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a single federation.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the metastore federation to
        /// retrieve, in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/federations/{federation_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Federation GetFederation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFederation(new GetFederationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a single federation.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the metastore federation to
        /// retrieve, in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/federations/{federation_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Federation> GetFederationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFederationAsync(new GetFederationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a single federation.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the metastore federation to
        /// retrieve, in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/federations/{federation_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Federation> GetFederationAsync(string name, st::CancellationToken cancellationToken) =>
            GetFederationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a single federation.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the metastore federation to
        /// retrieve, in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/federations/{federation_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Federation GetFederation(FederationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFederation(new GetFederationRequest
            {
                FederationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a single federation.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the metastore federation to
        /// retrieve, in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/federations/{federation_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Federation> GetFederationAsync(FederationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFederationAsync(new GetFederationRequest
            {
                FederationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a single federation.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the metastore federation to
        /// retrieve, in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/federations/{federation_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Federation> GetFederationAsync(FederationName name, st::CancellationToken cancellationToken) =>
            GetFederationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a metastore federation in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Federation, OperationMetadata> CreateFederation(CreateFederationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a metastore federation in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Federation, OperationMetadata>> CreateFederationAsync(CreateFederationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a metastore federation in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Federation, OperationMetadata>> CreateFederationAsync(CreateFederationRequest request, st::CancellationToken cancellationToken) =>
            CreateFederationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateFederation</c>.</summary>
        public virtual lro::OperationsClient CreateFederationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateFederation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Federation, OperationMetadata> PollOnceCreateFederation(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Federation, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateFederationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateFederation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Federation, OperationMetadata>> PollOnceCreateFederationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Federation, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateFederationOperationsClient, callSettings);

        /// <summary>
        /// Creates a metastore federation in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the location in which to create a
        /// federation service, in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}`.
        /// </param>
        /// <param name="federation">
        /// Required. The Metastore Federation to create. The `name` field is
        /// ignored. The ID of the created metastore federation must be
        /// provided in the request's `federation_id` field.
        /// </param>
        /// <param name="federationId">
        /// Required. The ID of the metastore federation, which is used as the final
        /// component of the metastore federation's name.
        /// 
        /// This value must be between 2 and 63 characters long inclusive, begin with a
        /// letter, end with a letter or number, and consist of alpha-numeric
        /// ASCII characters or hyphens.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Federation, OperationMetadata> CreateFederation(string parent, Federation federation, string federationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFederation(new CreateFederationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                FederationId = gax::GaxPreconditions.CheckNotNullOrEmpty(federationId, nameof(federationId)),
                Federation = gax::GaxPreconditions.CheckNotNull(federation, nameof(federation)),
            }, callSettings);

        /// <summary>
        /// Creates a metastore federation in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the location in which to create a
        /// federation service, in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}`.
        /// </param>
        /// <param name="federation">
        /// Required. The Metastore Federation to create. The `name` field is
        /// ignored. The ID of the created metastore federation must be
        /// provided in the request's `federation_id` field.
        /// </param>
        /// <param name="federationId">
        /// Required. The ID of the metastore federation, which is used as the final
        /// component of the metastore federation's name.
        /// 
        /// This value must be between 2 and 63 characters long inclusive, begin with a
        /// letter, end with a letter or number, and consist of alpha-numeric
        /// ASCII characters or hyphens.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Federation, OperationMetadata>> CreateFederationAsync(string parent, Federation federation, string federationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFederationAsync(new CreateFederationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                FederationId = gax::GaxPreconditions.CheckNotNullOrEmpty(federationId, nameof(federationId)),
                Federation = gax::GaxPreconditions.CheckNotNull(federation, nameof(federation)),
            }, callSettings);

        /// <summary>
        /// Creates a metastore federation in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the location in which to create a
        /// federation service, in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}`.
        /// </param>
        /// <param name="federation">
        /// Required. The Metastore Federation to create. The `name` field is
        /// ignored. The ID of the created metastore federation must be
        /// provided in the request's `federation_id` field.
        /// </param>
        /// <param name="federationId">
        /// Required. The ID of the metastore federation, which is used as the final
        /// component of the metastore federation's name.
        /// 
        /// This value must be between 2 and 63 characters long inclusive, begin with a
        /// letter, end with a letter or number, and consist of alpha-numeric
        /// ASCII characters or hyphens.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Federation, OperationMetadata>> CreateFederationAsync(string parent, Federation federation, string federationId, st::CancellationToken cancellationToken) =>
            CreateFederationAsync(parent, federation, federationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a metastore federation in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the location in which to create a
        /// federation service, in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}`.
        /// </param>
        /// <param name="federation">
        /// Required. The Metastore Federation to create. The `name` field is
        /// ignored. The ID of the created metastore federation must be
        /// provided in the request's `federation_id` field.
        /// </param>
        /// <param name="federationId">
        /// Required. The ID of the metastore federation, which is used as the final
        /// component of the metastore federation's name.
        /// 
        /// This value must be between 2 and 63 characters long inclusive, begin with a
        /// letter, end with a letter or number, and consist of alpha-numeric
        /// ASCII characters or hyphens.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Federation, OperationMetadata> CreateFederation(gagr::LocationName parent, Federation federation, string federationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFederation(new CreateFederationRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                FederationId = gax::GaxPreconditions.CheckNotNullOrEmpty(federationId, nameof(federationId)),
                Federation = gax::GaxPreconditions.CheckNotNull(federation, nameof(federation)),
            }, callSettings);

        /// <summary>
        /// Creates a metastore federation in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the location in which to create a
        /// federation service, in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}`.
        /// </param>
        /// <param name="federation">
        /// Required. The Metastore Federation to create. The `name` field is
        /// ignored. The ID of the created metastore federation must be
        /// provided in the request's `federation_id` field.
        /// </param>
        /// <param name="federationId">
        /// Required. The ID of the metastore federation, which is used as the final
        /// component of the metastore federation's name.
        /// 
        /// This value must be between 2 and 63 characters long inclusive, begin with a
        /// letter, end with a letter or number, and consist of alpha-numeric
        /// ASCII characters or hyphens.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Federation, OperationMetadata>> CreateFederationAsync(gagr::LocationName parent, Federation federation, string federationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFederationAsync(new CreateFederationRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                FederationId = gax::GaxPreconditions.CheckNotNullOrEmpty(federationId, nameof(federationId)),
                Federation = gax::GaxPreconditions.CheckNotNull(federation, nameof(federation)),
            }, callSettings);

        /// <summary>
        /// Creates a metastore federation in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the location in which to create a
        /// federation service, in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}`.
        /// </param>
        /// <param name="federation">
        /// Required. The Metastore Federation to create. The `name` field is
        /// ignored. The ID of the created metastore federation must be
        /// provided in the request's `federation_id` field.
        /// </param>
        /// <param name="federationId">
        /// Required. The ID of the metastore federation, which is used as the final
        /// component of the metastore federation's name.
        /// 
        /// This value must be between 2 and 63 characters long inclusive, begin with a
        /// letter, end with a letter or number, and consist of alpha-numeric
        /// ASCII characters or hyphens.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Federation, OperationMetadata>> CreateFederationAsync(gagr::LocationName parent, Federation federation, string federationId, st::CancellationToken cancellationToken) =>
            CreateFederationAsync(parent, federation, federationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the fields of a federation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Federation, OperationMetadata> UpdateFederation(UpdateFederationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the fields of a federation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Federation, OperationMetadata>> UpdateFederationAsync(UpdateFederationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the fields of a federation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Federation, OperationMetadata>> UpdateFederationAsync(UpdateFederationRequest request, st::CancellationToken cancellationToken) =>
            UpdateFederationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateFederation</c>.</summary>
        public virtual lro::OperationsClient UpdateFederationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateFederation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Federation, OperationMetadata> PollOnceUpdateFederation(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Federation, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateFederationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateFederation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Federation, OperationMetadata>> PollOnceUpdateFederationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Federation, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateFederationOperationsClient, callSettings);

        /// <summary>
        /// Updates the fields of a federation.
        /// </summary>
        /// <param name="federation">
        /// Required. The metastore federation to update. The server only merges fields
        /// in the service if they are specified in `update_mask`.
        /// 
        /// The metastore federation's `name` field is used to identify the
        /// metastore service to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. A field mask used to specify the fields to be overwritten in the
        /// metastore federation resource by the update.
        /// Fields specified in the `update_mask` are relative to the resource (not
        /// to the full request). A field is overwritten if it is in the mask.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Federation, OperationMetadata> UpdateFederation(Federation federation, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFederation(new UpdateFederationRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Federation = gax::GaxPreconditions.CheckNotNull(federation, nameof(federation)),
            }, callSettings);

        /// <summary>
        /// Updates the fields of a federation.
        /// </summary>
        /// <param name="federation">
        /// Required. The metastore federation to update. The server only merges fields
        /// in the service if they are specified in `update_mask`.
        /// 
        /// The metastore federation's `name` field is used to identify the
        /// metastore service to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. A field mask used to specify the fields to be overwritten in the
        /// metastore federation resource by the update.
        /// Fields specified in the `update_mask` are relative to the resource (not
        /// to the full request). A field is overwritten if it is in the mask.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Federation, OperationMetadata>> UpdateFederationAsync(Federation federation, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFederationAsync(new UpdateFederationRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Federation = gax::GaxPreconditions.CheckNotNull(federation, nameof(federation)),
            }, callSettings);

        /// <summary>
        /// Updates the fields of a federation.
        /// </summary>
        /// <param name="federation">
        /// Required. The metastore federation to update. The server only merges fields
        /// in the service if they are specified in `update_mask`.
        /// 
        /// The metastore federation's `name` field is used to identify the
        /// metastore service to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. A field mask used to specify the fields to be overwritten in the
        /// metastore federation resource by the update.
        /// Fields specified in the `update_mask` are relative to the resource (not
        /// to the full request). A field is overwritten if it is in the mask.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Federation, OperationMetadata>> UpdateFederationAsync(Federation federation, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateFederationAsync(federation, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single federation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteFederation(DeleteFederationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single federation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFederationAsync(DeleteFederationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single federation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFederationAsync(DeleteFederationRequest request, st::CancellationToken cancellationToken) =>
            DeleteFederationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteFederation</c>.</summary>
        public virtual lro::OperationsClient DeleteFederationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteFederation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteFederation(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteFederationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteFederation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteFederationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteFederationOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single federation.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the metastore federation to delete,
        /// in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/federations/{federation_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteFederation(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFederation(new DeleteFederationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single federation.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the metastore federation to delete,
        /// in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/federations/{federation_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFederationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFederationAsync(new DeleteFederationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single federation.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the metastore federation to delete,
        /// in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/federations/{federation_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFederationAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteFederationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single federation.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the metastore federation to delete,
        /// in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/federations/{federation_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteFederation(FederationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFederation(new DeleteFederationRequest
            {
                FederationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single federation.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the metastore federation to delete,
        /// in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/federations/{federation_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFederationAsync(FederationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFederationAsync(new DeleteFederationRequest
            {
                FederationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single federation.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the metastore federation to delete,
        /// in the following form:
        /// 
        /// `projects/{project_number}/locations/{location_id}/federations/{federation_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFederationAsync(FederationName name, st::CancellationToken cancellationToken) =>
            DeleteFederationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DataprocMetastoreFederation client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Configures and manages metastore federation services.
    /// Dataproc Metastore Federation Service allows federating a collection of
    /// backend metastores like BigQuery, Dataplex Lakes, and other Dataproc
    /// Metastores. The Federation Service exposes a gRPC URL through which metadata
    /// from the backend metastores are served at query time.
    /// 
    /// The Dataproc Metastore Federation API defines the following resource model:
    /// * The service works with a collection of Google Cloud projects.
    /// * Each project has a collection of available locations.
    /// * Each location has a collection of federations.
    /// * Dataproc Metastore Federations are resources with names of the
    /// form:
    /// `projects/{project_number}/locations/{location_id}/federations/{federation_id}`.
    /// </remarks>
    public sealed partial class DataprocMetastoreFederationClientImpl : DataprocMetastoreFederationClient
    {
        private readonly gaxgrpc::ApiCall<ListFederationsRequest, ListFederationsResponse> _callListFederations;

        private readonly gaxgrpc::ApiCall<GetFederationRequest, Federation> _callGetFederation;

        private readonly gaxgrpc::ApiCall<CreateFederationRequest, lro::Operation> _callCreateFederation;

        private readonly gaxgrpc::ApiCall<UpdateFederationRequest, lro::Operation> _callUpdateFederation;

        private readonly gaxgrpc::ApiCall<DeleteFederationRequest, lro::Operation> _callDeleteFederation;

        /// <summary>
        /// Constructs a client wrapper for the DataprocMetastoreFederation service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="DataprocMetastoreFederationSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DataprocMetastoreFederationClientImpl(DataprocMetastoreFederation.DataprocMetastoreFederationClient grpcClient, DataprocMetastoreFederationSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DataprocMetastoreFederationSettings effectiveSettings = settings ?? DataprocMetastoreFederationSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateFederationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateFederationOperationsSettings, logger);
            UpdateFederationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateFederationOperationsSettings, logger);
            DeleteFederationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteFederationOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListFederations = clientHelper.BuildApiCall<ListFederationsRequest, ListFederationsResponse>("ListFederations", grpcClient.ListFederationsAsync, grpcClient.ListFederations, effectiveSettings.ListFederationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListFederations);
            Modify_ListFederationsApiCall(ref _callListFederations);
            _callGetFederation = clientHelper.BuildApiCall<GetFederationRequest, Federation>("GetFederation", grpcClient.GetFederationAsync, grpcClient.GetFederation, effectiveSettings.GetFederationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetFederation);
            Modify_GetFederationApiCall(ref _callGetFederation);
            _callCreateFederation = clientHelper.BuildApiCall<CreateFederationRequest, lro::Operation>("CreateFederation", grpcClient.CreateFederationAsync, grpcClient.CreateFederation, effectiveSettings.CreateFederationSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateFederation);
            Modify_CreateFederationApiCall(ref _callCreateFederation);
            _callUpdateFederation = clientHelper.BuildApiCall<UpdateFederationRequest, lro::Operation>("UpdateFederation", grpcClient.UpdateFederationAsync, grpcClient.UpdateFederation, effectiveSettings.UpdateFederationSettings).WithGoogleRequestParam("federation.name", request => request.Federation?.Name);
            Modify_ApiCall(ref _callUpdateFederation);
            Modify_UpdateFederationApiCall(ref _callUpdateFederation);
            _callDeleteFederation = clientHelper.BuildApiCall<DeleteFederationRequest, lro::Operation>("DeleteFederation", grpcClient.DeleteFederationAsync, grpcClient.DeleteFederation, effectiveSettings.DeleteFederationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteFederation);
            Modify_DeleteFederationApiCall(ref _callDeleteFederation);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListFederationsApiCall(ref gaxgrpc::ApiCall<ListFederationsRequest, ListFederationsResponse> call);

        partial void Modify_GetFederationApiCall(ref gaxgrpc::ApiCall<GetFederationRequest, Federation> call);

        partial void Modify_CreateFederationApiCall(ref gaxgrpc::ApiCall<CreateFederationRequest, lro::Operation> call);

        partial void Modify_UpdateFederationApiCall(ref gaxgrpc::ApiCall<UpdateFederationRequest, lro::Operation> call);

        partial void Modify_DeleteFederationApiCall(ref gaxgrpc::ApiCall<DeleteFederationRequest, lro::Operation> call);

        partial void OnConstruction(DataprocMetastoreFederation.DataprocMetastoreFederationClient grpcClient, DataprocMetastoreFederationSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DataprocMetastoreFederation client</summary>
        public override DataprocMetastoreFederation.DataprocMetastoreFederationClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListFederationsRequest(ref ListFederationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetFederationRequest(ref GetFederationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateFederationRequest(ref CreateFederationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateFederationRequest(ref UpdateFederationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteFederationRequest(ref DeleteFederationRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists federations in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Federation"/> resources.</returns>
        public override gax::PagedEnumerable<ListFederationsResponse, Federation> ListFederations(ListFederationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFederationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListFederationsRequest, ListFederationsResponse, Federation>(_callListFederations, request, callSettings);
        }

        /// <summary>
        /// Lists federations in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Federation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListFederationsResponse, Federation> ListFederationsAsync(ListFederationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFederationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListFederationsRequest, ListFederationsResponse, Federation>(_callListFederations, request, callSettings);
        }

        /// <summary>
        /// Gets the details of a single federation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Federation GetFederation(GetFederationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFederationRequest(ref request, ref callSettings);
            return _callGetFederation.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a single federation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Federation> GetFederationAsync(GetFederationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFederationRequest(ref request, ref callSettings);
            return _callGetFederation.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateFederation</c>.</summary>
        public override lro::OperationsClient CreateFederationOperationsClient { get; }

        /// <summary>
        /// Creates a metastore federation in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Federation, OperationMetadata> CreateFederation(CreateFederationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFederationRequest(ref request, ref callSettings);
            return new lro::Operation<Federation, OperationMetadata>(_callCreateFederation.Sync(request, callSettings), CreateFederationOperationsClient);
        }

        /// <summary>
        /// Creates a metastore federation in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Federation, OperationMetadata>> CreateFederationAsync(CreateFederationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFederationRequest(ref request, ref callSettings);
            return new lro::Operation<Federation, OperationMetadata>(await _callCreateFederation.Async(request, callSettings).ConfigureAwait(false), CreateFederationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateFederation</c>.</summary>
        public override lro::OperationsClient UpdateFederationOperationsClient { get; }

        /// <summary>
        /// Updates the fields of a federation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Federation, OperationMetadata> UpdateFederation(UpdateFederationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFederationRequest(ref request, ref callSettings);
            return new lro::Operation<Federation, OperationMetadata>(_callUpdateFederation.Sync(request, callSettings), UpdateFederationOperationsClient);
        }

        /// <summary>
        /// Updates the fields of a federation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Federation, OperationMetadata>> UpdateFederationAsync(UpdateFederationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFederationRequest(ref request, ref callSettings);
            return new lro::Operation<Federation, OperationMetadata>(await _callUpdateFederation.Async(request, callSettings).ConfigureAwait(false), UpdateFederationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteFederation</c>.</summary>
        public override lro::OperationsClient DeleteFederationOperationsClient { get; }

        /// <summary>
        /// Deletes a single federation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteFederation(DeleteFederationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFederationRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteFederation.Sync(request, callSettings), DeleteFederationOperationsClient);
        }

        /// <summary>
        /// Deletes a single federation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFederationAsync(DeleteFederationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFederationRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteFederation.Async(request, callSettings).ConfigureAwait(false), DeleteFederationOperationsClient);
        }
    }

    public partial class ListFederationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListFederationsResponse : gaxgrpc::IPageResponse<Federation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Federation> GetEnumerator() => Federations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class DataprocMetastoreFederation
    {
        public partial class DataprocMetastoreFederationClient
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

    public static partial class DataprocMetastoreFederation
    {
        public partial class DataprocMetastoreFederationClient
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
