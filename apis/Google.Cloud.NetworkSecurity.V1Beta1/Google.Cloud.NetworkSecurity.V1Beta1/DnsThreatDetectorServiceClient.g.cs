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
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.NetworkSecurity.V1Beta1
{
    /// <summary>Settings for <see cref="DnsThreatDetectorServiceClient"/> instances.</summary>
    public sealed partial class DnsThreatDetectorServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DnsThreatDetectorServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DnsThreatDetectorServiceSettings"/>.</returns>
        public static DnsThreatDetectorServiceSettings GetDefault() => new DnsThreatDetectorServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="DnsThreatDetectorServiceSettings"/> object with default settings.
        /// </summary>
        public DnsThreatDetectorServiceSettings()
        {
        }

        private DnsThreatDetectorServiceSettings(DnsThreatDetectorServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListDnsThreatDetectorsSettings = existing.ListDnsThreatDetectorsSettings;
            GetDnsThreatDetectorSettings = existing.GetDnsThreatDetectorSettings;
            CreateDnsThreatDetectorSettings = existing.CreateDnsThreatDetectorSettings;
            UpdateDnsThreatDetectorSettings = existing.UpdateDnsThreatDetectorSettings;
            DeleteDnsThreatDetectorSettings = existing.DeleteDnsThreatDetectorSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(DnsThreatDetectorServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DnsThreatDetectorServiceClient.ListDnsThreatDetectors</c> and
        /// <c>DnsThreatDetectorServiceClient.ListDnsThreatDetectorsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDnsThreatDetectorsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DnsThreatDetectorServiceClient.GetDnsThreatDetector</c> and
        /// <c>DnsThreatDetectorServiceClient.GetDnsThreatDetectorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDnsThreatDetectorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DnsThreatDetectorServiceClient.CreateDnsThreatDetector</c> and
        /// <c>DnsThreatDetectorServiceClient.CreateDnsThreatDetectorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDnsThreatDetectorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DnsThreatDetectorServiceClient.UpdateDnsThreatDetector</c> and
        /// <c>DnsThreatDetectorServiceClient.UpdateDnsThreatDetectorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDnsThreatDetectorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DnsThreatDetectorServiceClient.DeleteDnsThreatDetector</c> and
        /// <c>DnsThreatDetectorServiceClient.DeleteDnsThreatDetectorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDnsThreatDetectorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DnsThreatDetectorServiceSettings"/> object.</returns>
        public DnsThreatDetectorServiceSettings Clone() => new DnsThreatDetectorServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DnsThreatDetectorServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class DnsThreatDetectorServiceClientBuilder : gaxgrpc::ClientBuilderBase<DnsThreatDetectorServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DnsThreatDetectorServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DnsThreatDetectorServiceClientBuilder() : base(DnsThreatDetectorServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DnsThreatDetectorServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DnsThreatDetectorServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DnsThreatDetectorServiceClient Build()
        {
            DnsThreatDetectorServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DnsThreatDetectorServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DnsThreatDetectorServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DnsThreatDetectorServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DnsThreatDetectorServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DnsThreatDetectorServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DnsThreatDetectorServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DnsThreatDetectorServiceClient.ChannelPool;
    }

    /// <summary>DnsThreatDetectorService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The Network Security API for DNS Threat Detectors.
    /// </remarks>
    public abstract partial class DnsThreatDetectorServiceClient
    {
        /// <summary>
        /// The default endpoint for the DnsThreatDetectorService service, which is a host of
        /// "networksecurity.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "networksecurity.googleapis.com:443";

        /// <summary>The default DnsThreatDetectorService scopes.</summary>
        /// <remarks>
        /// The default DnsThreatDetectorService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DnsThreatDetectorService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DnsThreatDetectorServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="DnsThreatDetectorServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DnsThreatDetectorServiceClient"/>.</returns>
        public static stt::Task<DnsThreatDetectorServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DnsThreatDetectorServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DnsThreatDetectorServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="DnsThreatDetectorServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DnsThreatDetectorServiceClient"/>.</returns>
        public static DnsThreatDetectorServiceClient Create() => new DnsThreatDetectorServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DnsThreatDetectorServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DnsThreatDetectorServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DnsThreatDetectorServiceClient"/>.</returns>
        internal static DnsThreatDetectorServiceClient Create(grpccore::CallInvoker callInvoker, DnsThreatDetectorServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DnsThreatDetectorService.DnsThreatDetectorServiceClient grpcClient = new DnsThreatDetectorService.DnsThreatDetectorServiceClient(callInvoker);
            return new DnsThreatDetectorServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DnsThreatDetectorService client</summary>
        public virtual DnsThreatDetectorService.DnsThreatDetectorServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DnsThreatDetectors in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DnsThreatDetector"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDnsThreatDetectorsResponse, DnsThreatDetector> ListDnsThreatDetectors(ListDnsThreatDetectorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DnsThreatDetectors in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DnsThreatDetector"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDnsThreatDetectorsResponse, DnsThreatDetector> ListDnsThreatDetectorsAsync(ListDnsThreatDetectorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DnsThreatDetectors in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for `ListDnsThreatDetectorsRequest`.
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
        /// <returns>A pageable sequence of <see cref="DnsThreatDetector"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDnsThreatDetectorsResponse, DnsThreatDetector> ListDnsThreatDetectors(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDnsThreatDetectorsRequest request = new ListDnsThreatDetectorsRequest
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
            return ListDnsThreatDetectors(request, callSettings);
        }

        /// <summary>
        /// Lists DnsThreatDetectors in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for `ListDnsThreatDetectorsRequest`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DnsThreatDetector"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDnsThreatDetectorsResponse, DnsThreatDetector> ListDnsThreatDetectorsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDnsThreatDetectorsRequest request = new ListDnsThreatDetectorsRequest
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
            return ListDnsThreatDetectorsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists DnsThreatDetectors in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for `ListDnsThreatDetectorsRequest`.
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
        /// <returns>A pageable sequence of <see cref="DnsThreatDetector"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDnsThreatDetectorsResponse, DnsThreatDetector> ListDnsThreatDetectors(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDnsThreatDetectorsRequest request = new ListDnsThreatDetectorsRequest
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
            return ListDnsThreatDetectors(request, callSettings);
        }

        /// <summary>
        /// Lists DnsThreatDetectors in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent value for `ListDnsThreatDetectorsRequest`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DnsThreatDetector"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDnsThreatDetectorsResponse, DnsThreatDetector> ListDnsThreatDetectorsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDnsThreatDetectorsRequest request = new ListDnsThreatDetectorsRequest
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
            return ListDnsThreatDetectorsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a single DnsThreatDetector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DnsThreatDetector GetDnsThreatDetector(GetDnsThreatDetectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a single DnsThreatDetector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DnsThreatDetector> GetDnsThreatDetectorAsync(GetDnsThreatDetectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a single DnsThreatDetector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DnsThreatDetector> GetDnsThreatDetectorAsync(GetDnsThreatDetectorRequest request, st::CancellationToken cancellationToken) =>
            GetDnsThreatDetectorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a single DnsThreatDetector.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the DnsThreatDetector resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DnsThreatDetector GetDnsThreatDetector(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDnsThreatDetector(new GetDnsThreatDetectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a single DnsThreatDetector.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the DnsThreatDetector resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DnsThreatDetector> GetDnsThreatDetectorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDnsThreatDetectorAsync(new GetDnsThreatDetectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a single DnsThreatDetector.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the DnsThreatDetector resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DnsThreatDetector> GetDnsThreatDetectorAsync(string name, st::CancellationToken cancellationToken) =>
            GetDnsThreatDetectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a single DnsThreatDetector.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the DnsThreatDetector resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DnsThreatDetector GetDnsThreatDetector(DnsThreatDetectorName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDnsThreatDetector(new GetDnsThreatDetectorRequest
            {
                DnsThreatDetectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a single DnsThreatDetector.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the DnsThreatDetector resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DnsThreatDetector> GetDnsThreatDetectorAsync(DnsThreatDetectorName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDnsThreatDetectorAsync(new GetDnsThreatDetectorRequest
            {
                DnsThreatDetectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a single DnsThreatDetector.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the DnsThreatDetector resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DnsThreatDetector> GetDnsThreatDetectorAsync(DnsThreatDetectorName name, st::CancellationToken cancellationToken) =>
            GetDnsThreatDetectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new DnsThreatDetector in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DnsThreatDetector CreateDnsThreatDetector(CreateDnsThreatDetectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new DnsThreatDetector in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DnsThreatDetector> CreateDnsThreatDetectorAsync(CreateDnsThreatDetectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new DnsThreatDetector in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DnsThreatDetector> CreateDnsThreatDetectorAsync(CreateDnsThreatDetectorRequest request, st::CancellationToken cancellationToken) =>
            CreateDnsThreatDetectorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new DnsThreatDetector in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The value for the parent of the DnsThreatDetector resource.
        /// </param>
        /// <param name="dnsThreatDetector">
        /// Required. The `DnsThreatDetector` resource to create.
        /// </param>
        /// <param name="dnsThreatDetectorId">
        /// Optional. The ID of the requesting DnsThreatDetector object.
        /// If this field is not supplied, the service generates an identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DnsThreatDetector CreateDnsThreatDetector(string parent, DnsThreatDetector dnsThreatDetector, string dnsThreatDetectorId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDnsThreatDetector(new CreateDnsThreatDetectorRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DnsThreatDetectorId = dnsThreatDetectorId ?? "",
                DnsThreatDetector = gax::GaxPreconditions.CheckNotNull(dnsThreatDetector, nameof(dnsThreatDetector)),
            }, callSettings);

        /// <summary>
        /// Creates a new DnsThreatDetector in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The value for the parent of the DnsThreatDetector resource.
        /// </param>
        /// <param name="dnsThreatDetector">
        /// Required. The `DnsThreatDetector` resource to create.
        /// </param>
        /// <param name="dnsThreatDetectorId">
        /// Optional. The ID of the requesting DnsThreatDetector object.
        /// If this field is not supplied, the service generates an identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DnsThreatDetector> CreateDnsThreatDetectorAsync(string parent, DnsThreatDetector dnsThreatDetector, string dnsThreatDetectorId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDnsThreatDetectorAsync(new CreateDnsThreatDetectorRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DnsThreatDetectorId = dnsThreatDetectorId ?? "",
                DnsThreatDetector = gax::GaxPreconditions.CheckNotNull(dnsThreatDetector, nameof(dnsThreatDetector)),
            }, callSettings);

        /// <summary>
        /// Creates a new DnsThreatDetector in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The value for the parent of the DnsThreatDetector resource.
        /// </param>
        /// <param name="dnsThreatDetector">
        /// Required. The `DnsThreatDetector` resource to create.
        /// </param>
        /// <param name="dnsThreatDetectorId">
        /// Optional. The ID of the requesting DnsThreatDetector object.
        /// If this field is not supplied, the service generates an identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DnsThreatDetector> CreateDnsThreatDetectorAsync(string parent, DnsThreatDetector dnsThreatDetector, string dnsThreatDetectorId, st::CancellationToken cancellationToken) =>
            CreateDnsThreatDetectorAsync(parent, dnsThreatDetector, dnsThreatDetectorId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new DnsThreatDetector in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The value for the parent of the DnsThreatDetector resource.
        /// </param>
        /// <param name="dnsThreatDetector">
        /// Required. The `DnsThreatDetector` resource to create.
        /// </param>
        /// <param name="dnsThreatDetectorId">
        /// Optional. The ID of the requesting DnsThreatDetector object.
        /// If this field is not supplied, the service generates an identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DnsThreatDetector CreateDnsThreatDetector(gagr::LocationName parent, DnsThreatDetector dnsThreatDetector, string dnsThreatDetectorId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDnsThreatDetector(new CreateDnsThreatDetectorRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DnsThreatDetectorId = dnsThreatDetectorId ?? "",
                DnsThreatDetector = gax::GaxPreconditions.CheckNotNull(dnsThreatDetector, nameof(dnsThreatDetector)),
            }, callSettings);

        /// <summary>
        /// Creates a new DnsThreatDetector in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The value for the parent of the DnsThreatDetector resource.
        /// </param>
        /// <param name="dnsThreatDetector">
        /// Required. The `DnsThreatDetector` resource to create.
        /// </param>
        /// <param name="dnsThreatDetectorId">
        /// Optional. The ID of the requesting DnsThreatDetector object.
        /// If this field is not supplied, the service generates an identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DnsThreatDetector> CreateDnsThreatDetectorAsync(gagr::LocationName parent, DnsThreatDetector dnsThreatDetector, string dnsThreatDetectorId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDnsThreatDetectorAsync(new CreateDnsThreatDetectorRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DnsThreatDetectorId = dnsThreatDetectorId ?? "",
                DnsThreatDetector = gax::GaxPreconditions.CheckNotNull(dnsThreatDetector, nameof(dnsThreatDetector)),
            }, callSettings);

        /// <summary>
        /// Creates a new DnsThreatDetector in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The value for the parent of the DnsThreatDetector resource.
        /// </param>
        /// <param name="dnsThreatDetector">
        /// Required. The `DnsThreatDetector` resource to create.
        /// </param>
        /// <param name="dnsThreatDetectorId">
        /// Optional. The ID of the requesting DnsThreatDetector object.
        /// If this field is not supplied, the service generates an identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DnsThreatDetector> CreateDnsThreatDetectorAsync(gagr::LocationName parent, DnsThreatDetector dnsThreatDetector, string dnsThreatDetectorId, st::CancellationToken cancellationToken) =>
            CreateDnsThreatDetectorAsync(parent, dnsThreatDetector, dnsThreatDetectorId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a single DnsThreatDetector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DnsThreatDetector UpdateDnsThreatDetector(UpdateDnsThreatDetectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a single DnsThreatDetector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DnsThreatDetector> UpdateDnsThreatDetectorAsync(UpdateDnsThreatDetectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a single DnsThreatDetector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DnsThreatDetector> UpdateDnsThreatDetectorAsync(UpdateDnsThreatDetectorRequest request, st::CancellationToken cancellationToken) =>
            UpdateDnsThreatDetectorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a single DnsThreatDetector.
        /// </summary>
        /// <param name="dnsThreatDetector">
        /// Required. The DnsThreatDetector resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The field mask is used to specify the fields to be overwritten in
        /// the DnsThreatDetector resource by the update. The fields specified in the
        /// update_mask are relative to the resource, not the full request. A field
        /// will be overwritten if it is in the mask. If the mask is not provided then
        /// all fields present in the request will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DnsThreatDetector UpdateDnsThreatDetector(DnsThreatDetector dnsThreatDetector, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDnsThreatDetector(new UpdateDnsThreatDetectorRequest
            {
                UpdateMask = updateMask,
                DnsThreatDetector = gax::GaxPreconditions.CheckNotNull(dnsThreatDetector, nameof(dnsThreatDetector)),
            }, callSettings);

        /// <summary>
        /// Updates a single DnsThreatDetector.
        /// </summary>
        /// <param name="dnsThreatDetector">
        /// Required. The DnsThreatDetector resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The field mask is used to specify the fields to be overwritten in
        /// the DnsThreatDetector resource by the update. The fields specified in the
        /// update_mask are relative to the resource, not the full request. A field
        /// will be overwritten if it is in the mask. If the mask is not provided then
        /// all fields present in the request will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DnsThreatDetector> UpdateDnsThreatDetectorAsync(DnsThreatDetector dnsThreatDetector, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDnsThreatDetectorAsync(new UpdateDnsThreatDetectorRequest
            {
                UpdateMask = updateMask,
                DnsThreatDetector = gax::GaxPreconditions.CheckNotNull(dnsThreatDetector, nameof(dnsThreatDetector)),
            }, callSettings);

        /// <summary>
        /// Updates a single DnsThreatDetector.
        /// </summary>
        /// <param name="dnsThreatDetector">
        /// Required. The DnsThreatDetector resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The field mask is used to specify the fields to be overwritten in
        /// the DnsThreatDetector resource by the update. The fields specified in the
        /// update_mask are relative to the resource, not the full request. A field
        /// will be overwritten if it is in the mask. If the mask is not provided then
        /// all fields present in the request will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DnsThreatDetector> UpdateDnsThreatDetectorAsync(DnsThreatDetector dnsThreatDetector, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDnsThreatDetectorAsync(dnsThreatDetector, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single DnsThreatDetector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDnsThreatDetector(DeleteDnsThreatDetectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single DnsThreatDetector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDnsThreatDetectorAsync(DeleteDnsThreatDetectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single DnsThreatDetector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDnsThreatDetectorAsync(DeleteDnsThreatDetectorRequest request, st::CancellationToken cancellationToken) =>
            DeleteDnsThreatDetectorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single DnsThreatDetector.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the DnsThreatDetector resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDnsThreatDetector(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDnsThreatDetector(new DeleteDnsThreatDetectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single DnsThreatDetector.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the DnsThreatDetector resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDnsThreatDetectorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDnsThreatDetectorAsync(new DeleteDnsThreatDetectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single DnsThreatDetector.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the DnsThreatDetector resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDnsThreatDetectorAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDnsThreatDetectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single DnsThreatDetector.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the DnsThreatDetector resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDnsThreatDetector(DnsThreatDetectorName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDnsThreatDetector(new DeleteDnsThreatDetectorRequest
            {
                DnsThreatDetectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single DnsThreatDetector.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the DnsThreatDetector resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDnsThreatDetectorAsync(DnsThreatDetectorName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDnsThreatDetectorAsync(new DeleteDnsThreatDetectorRequest
            {
                DnsThreatDetectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single DnsThreatDetector.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the DnsThreatDetector resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDnsThreatDetectorAsync(DnsThreatDetectorName name, st::CancellationToken cancellationToken) =>
            DeleteDnsThreatDetectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DnsThreatDetectorService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The Network Security API for DNS Threat Detectors.
    /// </remarks>
    public sealed partial class DnsThreatDetectorServiceClientImpl : DnsThreatDetectorServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListDnsThreatDetectorsRequest, ListDnsThreatDetectorsResponse> _callListDnsThreatDetectors;

        private readonly gaxgrpc::ApiCall<GetDnsThreatDetectorRequest, DnsThreatDetector> _callGetDnsThreatDetector;

        private readonly gaxgrpc::ApiCall<CreateDnsThreatDetectorRequest, DnsThreatDetector> _callCreateDnsThreatDetector;

        private readonly gaxgrpc::ApiCall<UpdateDnsThreatDetectorRequest, DnsThreatDetector> _callUpdateDnsThreatDetector;

        private readonly gaxgrpc::ApiCall<DeleteDnsThreatDetectorRequest, wkt::Empty> _callDeleteDnsThreatDetector;

        /// <summary>
        /// Constructs a client wrapper for the DnsThreatDetectorService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="DnsThreatDetectorServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DnsThreatDetectorServiceClientImpl(DnsThreatDetectorService.DnsThreatDetectorServiceClient grpcClient, DnsThreatDetectorServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DnsThreatDetectorServiceSettings effectiveSettings = settings ?? DnsThreatDetectorServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListDnsThreatDetectors = clientHelper.BuildApiCall<ListDnsThreatDetectorsRequest, ListDnsThreatDetectorsResponse>("ListDnsThreatDetectors", grpcClient.ListDnsThreatDetectorsAsync, grpcClient.ListDnsThreatDetectors, effectiveSettings.ListDnsThreatDetectorsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDnsThreatDetectors);
            Modify_ListDnsThreatDetectorsApiCall(ref _callListDnsThreatDetectors);
            _callGetDnsThreatDetector = clientHelper.BuildApiCall<GetDnsThreatDetectorRequest, DnsThreatDetector>("GetDnsThreatDetector", grpcClient.GetDnsThreatDetectorAsync, grpcClient.GetDnsThreatDetector, effectiveSettings.GetDnsThreatDetectorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDnsThreatDetector);
            Modify_GetDnsThreatDetectorApiCall(ref _callGetDnsThreatDetector);
            _callCreateDnsThreatDetector = clientHelper.BuildApiCall<CreateDnsThreatDetectorRequest, DnsThreatDetector>("CreateDnsThreatDetector", grpcClient.CreateDnsThreatDetectorAsync, grpcClient.CreateDnsThreatDetector, effectiveSettings.CreateDnsThreatDetectorSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDnsThreatDetector);
            Modify_CreateDnsThreatDetectorApiCall(ref _callCreateDnsThreatDetector);
            _callUpdateDnsThreatDetector = clientHelper.BuildApiCall<UpdateDnsThreatDetectorRequest, DnsThreatDetector>("UpdateDnsThreatDetector", grpcClient.UpdateDnsThreatDetectorAsync, grpcClient.UpdateDnsThreatDetector, effectiveSettings.UpdateDnsThreatDetectorSettings).WithGoogleRequestParam("dns_threat_detector.name", request => request.DnsThreatDetector?.Name);
            Modify_ApiCall(ref _callUpdateDnsThreatDetector);
            Modify_UpdateDnsThreatDetectorApiCall(ref _callUpdateDnsThreatDetector);
            _callDeleteDnsThreatDetector = clientHelper.BuildApiCall<DeleteDnsThreatDetectorRequest, wkt::Empty>("DeleteDnsThreatDetector", grpcClient.DeleteDnsThreatDetectorAsync, grpcClient.DeleteDnsThreatDetector, effectiveSettings.DeleteDnsThreatDetectorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDnsThreatDetector);
            Modify_DeleteDnsThreatDetectorApiCall(ref _callDeleteDnsThreatDetector);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListDnsThreatDetectorsApiCall(ref gaxgrpc::ApiCall<ListDnsThreatDetectorsRequest, ListDnsThreatDetectorsResponse> call);

        partial void Modify_GetDnsThreatDetectorApiCall(ref gaxgrpc::ApiCall<GetDnsThreatDetectorRequest, DnsThreatDetector> call);

        partial void Modify_CreateDnsThreatDetectorApiCall(ref gaxgrpc::ApiCall<CreateDnsThreatDetectorRequest, DnsThreatDetector> call);

        partial void Modify_UpdateDnsThreatDetectorApiCall(ref gaxgrpc::ApiCall<UpdateDnsThreatDetectorRequest, DnsThreatDetector> call);

        partial void Modify_DeleteDnsThreatDetectorApiCall(ref gaxgrpc::ApiCall<DeleteDnsThreatDetectorRequest, wkt::Empty> call);

        partial void OnConstruction(DnsThreatDetectorService.DnsThreatDetectorServiceClient grpcClient, DnsThreatDetectorServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DnsThreatDetectorService client</summary>
        public override DnsThreatDetectorService.DnsThreatDetectorServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListDnsThreatDetectorsRequest(ref ListDnsThreatDetectorsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDnsThreatDetectorRequest(ref GetDnsThreatDetectorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateDnsThreatDetectorRequest(ref CreateDnsThreatDetectorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDnsThreatDetectorRequest(ref UpdateDnsThreatDetectorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDnsThreatDetectorRequest(ref DeleteDnsThreatDetectorRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists DnsThreatDetectors in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DnsThreatDetector"/> resources.</returns>
        public override gax::PagedEnumerable<ListDnsThreatDetectorsResponse, DnsThreatDetector> ListDnsThreatDetectors(ListDnsThreatDetectorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDnsThreatDetectorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDnsThreatDetectorsRequest, ListDnsThreatDetectorsResponse, DnsThreatDetector>(_callListDnsThreatDetectors, request, callSettings);
        }

        /// <summary>
        /// Lists DnsThreatDetectors in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DnsThreatDetector"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDnsThreatDetectorsResponse, DnsThreatDetector> ListDnsThreatDetectorsAsync(ListDnsThreatDetectorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDnsThreatDetectorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDnsThreatDetectorsRequest, ListDnsThreatDetectorsResponse, DnsThreatDetector>(_callListDnsThreatDetectors, request, callSettings);
        }

        /// <summary>
        /// Gets the details of a single DnsThreatDetector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DnsThreatDetector GetDnsThreatDetector(GetDnsThreatDetectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDnsThreatDetectorRequest(ref request, ref callSettings);
            return _callGetDnsThreatDetector.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a single DnsThreatDetector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DnsThreatDetector> GetDnsThreatDetectorAsync(GetDnsThreatDetectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDnsThreatDetectorRequest(ref request, ref callSettings);
            return _callGetDnsThreatDetector.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new DnsThreatDetector in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DnsThreatDetector CreateDnsThreatDetector(CreateDnsThreatDetectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDnsThreatDetectorRequest(ref request, ref callSettings);
            return _callCreateDnsThreatDetector.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new DnsThreatDetector in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DnsThreatDetector> CreateDnsThreatDetectorAsync(CreateDnsThreatDetectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDnsThreatDetectorRequest(ref request, ref callSettings);
            return _callCreateDnsThreatDetector.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a single DnsThreatDetector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DnsThreatDetector UpdateDnsThreatDetector(UpdateDnsThreatDetectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDnsThreatDetectorRequest(ref request, ref callSettings);
            return _callUpdateDnsThreatDetector.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a single DnsThreatDetector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DnsThreatDetector> UpdateDnsThreatDetectorAsync(UpdateDnsThreatDetectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDnsThreatDetectorRequest(ref request, ref callSettings);
            return _callUpdateDnsThreatDetector.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a single DnsThreatDetector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteDnsThreatDetector(DeleteDnsThreatDetectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDnsThreatDetectorRequest(ref request, ref callSettings);
            _callDeleteDnsThreatDetector.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a single DnsThreatDetector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteDnsThreatDetectorAsync(DeleteDnsThreatDetectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDnsThreatDetectorRequest(ref request, ref callSettings);
            return _callDeleteDnsThreatDetector.Async(request, callSettings);
        }
    }

    public partial class ListDnsThreatDetectorsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDnsThreatDetectorsResponse : gaxgrpc::IPageResponse<DnsThreatDetector>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DnsThreatDetector> GetEnumerator() => DnsThreatDetectors.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class DnsThreatDetectorService
    {
        public partial class DnsThreatDetectorServiceClient
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
