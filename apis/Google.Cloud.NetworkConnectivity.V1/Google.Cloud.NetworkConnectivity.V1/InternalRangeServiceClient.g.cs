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

namespace Google.Cloud.NetworkConnectivity.V1
{
    /// <summary>Settings for <see cref="InternalRangeServiceClient"/> instances.</summary>
    public sealed partial class InternalRangeServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="InternalRangeServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="InternalRangeServiceSettings"/>.</returns>
        public static InternalRangeServiceSettings GetDefault() => new InternalRangeServiceSettings();

        /// <summary>Constructs a new <see cref="InternalRangeServiceSettings"/> object with default settings.</summary>
        public InternalRangeServiceSettings()
        {
        }

        private InternalRangeServiceSettings(InternalRangeServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListInternalRangesSettings = existing.ListInternalRangesSettings;
            GetInternalRangeSettings = existing.GetInternalRangeSettings;
            CreateInternalRangeSettings = existing.CreateInternalRangeSettings;
            CreateInternalRangeOperationsSettings = existing.CreateInternalRangeOperationsSettings.Clone();
            UpdateInternalRangeSettings = existing.UpdateInternalRangeSettings;
            UpdateInternalRangeOperationsSettings = existing.UpdateInternalRangeOperationsSettings.Clone();
            DeleteInternalRangeSettings = existing.DeleteInternalRangeSettings;
            DeleteInternalRangeOperationsSettings = existing.DeleteInternalRangeOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(InternalRangeServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InternalRangeServiceClient.ListInternalRanges</c> and
        /// <c>InternalRangeServiceClient.ListInternalRangesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListInternalRangesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InternalRangeServiceClient.GetInternalRange</c> and <c>InternalRangeServiceClient.GetInternalRangeAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetInternalRangeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InternalRangeServiceClient.CreateInternalRange</c> and
        /// <c>InternalRangeServiceClient.CreateInternalRangeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateInternalRangeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InternalRangeServiceClient.CreateInternalRange</c> and
        /// <c>InternalRangeServiceClient.CreateInternalRangeAsync</c>.
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
        public lro::OperationsSettings CreateInternalRangeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InternalRangeServiceClient.UpdateInternalRange</c> and
        /// <c>InternalRangeServiceClient.UpdateInternalRangeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateInternalRangeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InternalRangeServiceClient.UpdateInternalRange</c> and
        /// <c>InternalRangeServiceClient.UpdateInternalRangeAsync</c>.
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
        public lro::OperationsSettings UpdateInternalRangeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InternalRangeServiceClient.DeleteInternalRange</c> and
        /// <c>InternalRangeServiceClient.DeleteInternalRangeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteInternalRangeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InternalRangeServiceClient.DeleteInternalRange</c> and
        /// <c>InternalRangeServiceClient.DeleteInternalRangeAsync</c>.
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
        public lro::OperationsSettings DeleteInternalRangeOperationsSettings { get; set; } = new lro::OperationsSettings
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
        /// <returns>A deep clone of this <see cref="InternalRangeServiceSettings"/> object.</returns>
        public InternalRangeServiceSettings Clone() => new InternalRangeServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="InternalRangeServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class InternalRangeServiceClientBuilder : gaxgrpc::ClientBuilderBase<InternalRangeServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public InternalRangeServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public InternalRangeServiceClientBuilder() : base(InternalRangeServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref InternalRangeServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<InternalRangeServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override InternalRangeServiceClient Build()
        {
            InternalRangeServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<InternalRangeServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<InternalRangeServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private InternalRangeServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return InternalRangeServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<InternalRangeServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return InternalRangeServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => InternalRangeServiceClient.ChannelPool;
    }

    /// <summary>InternalRangeService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The CLH-based service for internal range resources used to perform IPAM
    /// operations within a VPC network.
    /// </remarks>
    public abstract partial class InternalRangeServiceClient
    {
        /// <summary>
        /// The default endpoint for the InternalRangeService service, which is a host of
        /// "networkconnectivity.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "networkconnectivity.googleapis.com:443";

        /// <summary>The default InternalRangeService scopes.</summary>
        /// <remarks>
        /// The default InternalRangeService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(InternalRangeService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="InternalRangeServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="InternalRangeServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="InternalRangeServiceClient"/>.</returns>
        public static stt::Task<InternalRangeServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new InternalRangeServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="InternalRangeServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="InternalRangeServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="InternalRangeServiceClient"/>.</returns>
        public static InternalRangeServiceClient Create() => new InternalRangeServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="InternalRangeServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="InternalRangeServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="InternalRangeServiceClient"/>.</returns>
        internal static InternalRangeServiceClient Create(grpccore::CallInvoker callInvoker, InternalRangeServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            InternalRangeService.InternalRangeServiceClient grpcClient = new InternalRangeService.InternalRangeServiceClient(callInvoker);
            return new InternalRangeServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC InternalRangeService client</summary>
        public virtual InternalRangeService.InternalRangeServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists internal ranges in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InternalRange"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInternalRangesResponse, InternalRange> ListInternalRanges(ListInternalRangesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists internal ranges in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="InternalRange"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInternalRangesResponse, InternalRange> ListInternalRangesAsync(ListInternalRangesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists internal ranges in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name.
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
        /// <returns>A pageable sequence of <see cref="InternalRange"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInternalRangesResponse, InternalRange> ListInternalRanges(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInternalRangesRequest request = new ListInternalRangesRequest
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
            return ListInternalRanges(request, callSettings);
        }

        /// <summary>
        /// Lists internal ranges in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name.
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
        /// <returns>A pageable asynchronous sequence of <see cref="InternalRange"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInternalRangesResponse, InternalRange> ListInternalRangesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInternalRangesRequest request = new ListInternalRangesRequest
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
            return ListInternalRangesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists internal ranges in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name.
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
        /// <returns>A pageable sequence of <see cref="InternalRange"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInternalRangesResponse, InternalRange> ListInternalRanges(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInternalRangesRequest request = new ListInternalRangesRequest
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
            return ListInternalRanges(request, callSettings);
        }

        /// <summary>
        /// Lists internal ranges in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name.
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
        /// <returns>A pageable asynchronous sequence of <see cref="InternalRange"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInternalRangesResponse, InternalRange> ListInternalRangesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInternalRangesRequest request = new ListInternalRangesRequest
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
            return ListInternalRangesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single internal range.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InternalRange GetInternalRange(GetInternalRangeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single internal range.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InternalRange> GetInternalRangeAsync(GetInternalRangeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single internal range.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InternalRange> GetInternalRangeAsync(GetInternalRangeRequest request, st::CancellationToken cancellationToken) =>
            GetInternalRangeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single internal range.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the InternalRange to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InternalRange GetInternalRange(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInternalRange(new GetInternalRangeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single internal range.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the InternalRange to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InternalRange> GetInternalRangeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInternalRangeAsync(new GetInternalRangeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single internal range.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the InternalRange to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InternalRange> GetInternalRangeAsync(string name, st::CancellationToken cancellationToken) =>
            GetInternalRangeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single internal range.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the InternalRange to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InternalRange GetInternalRange(InternalRangeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInternalRange(new GetInternalRangeRequest
            {
                InternalRangeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single internal range.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the InternalRange to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InternalRange> GetInternalRangeAsync(InternalRangeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInternalRangeAsync(new GetInternalRangeRequest
            {
                InternalRangeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single internal range.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the InternalRange to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InternalRange> GetInternalRangeAsync(InternalRangeName name, st::CancellationToken cancellationToken) =>
            GetInternalRangeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new internal range in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InternalRange, OperationMetadata> CreateInternalRange(CreateInternalRangeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new internal range in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InternalRange, OperationMetadata>> CreateInternalRangeAsync(CreateInternalRangeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new internal range in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InternalRange, OperationMetadata>> CreateInternalRangeAsync(CreateInternalRangeRequest request, st::CancellationToken cancellationToken) =>
            CreateInternalRangeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateInternalRange</c>.</summary>
        public virtual lro::OperationsClient CreateInternalRangeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateInternalRange</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<InternalRange, OperationMetadata> PollOnceCreateInternalRange(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<InternalRange, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateInternalRangeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateInternalRange</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<InternalRange, OperationMetadata>> PollOnceCreateInternalRangeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<InternalRange, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateInternalRangeOperationsClient, callSettings);

        /// <summary>
        /// Creates a new internal range in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name of the internal range.
        /// </param>
        /// <param name="internalRange">
        /// Required. Initial values for a new internal range
        /// </param>
        /// <param name="internalRangeId">
        /// Optional. Resource ID
        /// (i.e. 'foo' in '[...]/projects/p/locations/l/internalRanges/foo')
        /// See https://google.aip.dev/122#resource-id-segments
        /// Unique per location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InternalRange, OperationMetadata> CreateInternalRange(string parent, InternalRange internalRange, string internalRangeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInternalRange(new CreateInternalRangeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InternalRangeId = internalRangeId ?? "",
                InternalRange = gax::GaxPreconditions.CheckNotNull(internalRange, nameof(internalRange)),
            }, callSettings);

        /// <summary>
        /// Creates a new internal range in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name of the internal range.
        /// </param>
        /// <param name="internalRange">
        /// Required. Initial values for a new internal range
        /// </param>
        /// <param name="internalRangeId">
        /// Optional. Resource ID
        /// (i.e. 'foo' in '[...]/projects/p/locations/l/internalRanges/foo')
        /// See https://google.aip.dev/122#resource-id-segments
        /// Unique per location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InternalRange, OperationMetadata>> CreateInternalRangeAsync(string parent, InternalRange internalRange, string internalRangeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInternalRangeAsync(new CreateInternalRangeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InternalRangeId = internalRangeId ?? "",
                InternalRange = gax::GaxPreconditions.CheckNotNull(internalRange, nameof(internalRange)),
            }, callSettings);

        /// <summary>
        /// Creates a new internal range in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name of the internal range.
        /// </param>
        /// <param name="internalRange">
        /// Required. Initial values for a new internal range
        /// </param>
        /// <param name="internalRangeId">
        /// Optional. Resource ID
        /// (i.e. 'foo' in '[...]/projects/p/locations/l/internalRanges/foo')
        /// See https://google.aip.dev/122#resource-id-segments
        /// Unique per location.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InternalRange, OperationMetadata>> CreateInternalRangeAsync(string parent, InternalRange internalRange, string internalRangeId, st::CancellationToken cancellationToken) =>
            CreateInternalRangeAsync(parent, internalRange, internalRangeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new internal range in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name of the internal range.
        /// </param>
        /// <param name="internalRange">
        /// Required. Initial values for a new internal range
        /// </param>
        /// <param name="internalRangeId">
        /// Optional. Resource ID
        /// (i.e. 'foo' in '[...]/projects/p/locations/l/internalRanges/foo')
        /// See https://google.aip.dev/122#resource-id-segments
        /// Unique per location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InternalRange, OperationMetadata> CreateInternalRange(gagr::LocationName parent, InternalRange internalRange, string internalRangeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInternalRange(new CreateInternalRangeRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InternalRangeId = internalRangeId ?? "",
                InternalRange = gax::GaxPreconditions.CheckNotNull(internalRange, nameof(internalRange)),
            }, callSettings);

        /// <summary>
        /// Creates a new internal range in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name of the internal range.
        /// </param>
        /// <param name="internalRange">
        /// Required. Initial values for a new internal range
        /// </param>
        /// <param name="internalRangeId">
        /// Optional. Resource ID
        /// (i.e. 'foo' in '[...]/projects/p/locations/l/internalRanges/foo')
        /// See https://google.aip.dev/122#resource-id-segments
        /// Unique per location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InternalRange, OperationMetadata>> CreateInternalRangeAsync(gagr::LocationName parent, InternalRange internalRange, string internalRangeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInternalRangeAsync(new CreateInternalRangeRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InternalRangeId = internalRangeId ?? "",
                InternalRange = gax::GaxPreconditions.CheckNotNull(internalRange, nameof(internalRange)),
            }, callSettings);

        /// <summary>
        /// Creates a new internal range in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource's name of the internal range.
        /// </param>
        /// <param name="internalRange">
        /// Required. Initial values for a new internal range
        /// </param>
        /// <param name="internalRangeId">
        /// Optional. Resource ID
        /// (i.e. 'foo' in '[...]/projects/p/locations/l/internalRanges/foo')
        /// See https://google.aip.dev/122#resource-id-segments
        /// Unique per location.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InternalRange, OperationMetadata>> CreateInternalRangeAsync(gagr::LocationName parent, InternalRange internalRange, string internalRangeId, st::CancellationToken cancellationToken) =>
            CreateInternalRangeAsync(parent, internalRange, internalRangeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single internal range.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InternalRange, OperationMetadata> UpdateInternalRange(UpdateInternalRangeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single internal range.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InternalRange, OperationMetadata>> UpdateInternalRangeAsync(UpdateInternalRangeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single internal range.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InternalRange, OperationMetadata>> UpdateInternalRangeAsync(UpdateInternalRangeRequest request, st::CancellationToken cancellationToken) =>
            UpdateInternalRangeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateInternalRange</c>.</summary>
        public virtual lro::OperationsClient UpdateInternalRangeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateInternalRange</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<InternalRange, OperationMetadata> PollOnceUpdateInternalRange(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<InternalRange, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateInternalRangeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateInternalRange</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<InternalRange, OperationMetadata>> PollOnceUpdateInternalRangeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<InternalRange, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateInternalRangeOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single internal range.
        /// </summary>
        /// <param name="internalRange">
        /// Required. New values to be patched into the resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// InternalRange resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<InternalRange, OperationMetadata> UpdateInternalRange(InternalRange internalRange, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateInternalRange(new UpdateInternalRangeRequest
            {
                UpdateMask = updateMask,
                InternalRange = gax::GaxPreconditions.CheckNotNull(internalRange, nameof(internalRange)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single internal range.
        /// </summary>
        /// <param name="internalRange">
        /// Required. New values to be patched into the resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// InternalRange resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InternalRange, OperationMetadata>> UpdateInternalRangeAsync(InternalRange internalRange, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateInternalRangeAsync(new UpdateInternalRangeRequest
            {
                UpdateMask = updateMask,
                InternalRange = gax::GaxPreconditions.CheckNotNull(internalRange, nameof(internalRange)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single internal range.
        /// </summary>
        /// <param name="internalRange">
        /// Required. New values to be patched into the resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// InternalRange resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<InternalRange, OperationMetadata>> UpdateInternalRangeAsync(InternalRange internalRange, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateInternalRangeAsync(internalRange, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single internal range.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInternalRange(DeleteInternalRangeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single internal range.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInternalRangeAsync(DeleteInternalRangeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single internal range.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInternalRangeAsync(DeleteInternalRangeRequest request, st::CancellationToken cancellationToken) =>
            DeleteInternalRangeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteInternalRange</c>.</summary>
        public virtual lro::OperationsClient DeleteInternalRangeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteInternalRange</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteInternalRange(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteInternalRangeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteInternalRange</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteInternalRangeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteInternalRangeOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single internal range.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the internal range to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInternalRange(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInternalRange(new DeleteInternalRangeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single internal range.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the internal range to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInternalRangeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInternalRangeAsync(new DeleteInternalRangeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single internal range.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the internal range to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInternalRangeAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteInternalRangeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single internal range.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the internal range to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInternalRange(InternalRangeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInternalRange(new DeleteInternalRangeRequest
            {
                InternalRangeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single internal range.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the internal range to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInternalRangeAsync(InternalRangeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInternalRangeAsync(new DeleteInternalRangeRequest
            {
                InternalRangeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single internal range.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the internal range to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInternalRangeAsync(InternalRangeName name, st::CancellationToken cancellationToken) =>
            DeleteInternalRangeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>InternalRangeService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The CLH-based service for internal range resources used to perform IPAM
    /// operations within a VPC network.
    /// </remarks>
    public sealed partial class InternalRangeServiceClientImpl : InternalRangeServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListInternalRangesRequest, ListInternalRangesResponse> _callListInternalRanges;

        private readonly gaxgrpc::ApiCall<GetInternalRangeRequest, InternalRange> _callGetInternalRange;

        private readonly gaxgrpc::ApiCall<CreateInternalRangeRequest, lro::Operation> _callCreateInternalRange;

        private readonly gaxgrpc::ApiCall<UpdateInternalRangeRequest, lro::Operation> _callUpdateInternalRange;

        private readonly gaxgrpc::ApiCall<DeleteInternalRangeRequest, lro::Operation> _callDeleteInternalRange;

        /// <summary>
        /// Constructs a client wrapper for the InternalRangeService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="InternalRangeServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public InternalRangeServiceClientImpl(InternalRangeService.InternalRangeServiceClient grpcClient, InternalRangeServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            InternalRangeServiceSettings effectiveSettings = settings ?? InternalRangeServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateInternalRangeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateInternalRangeOperationsSettings, logger);
            UpdateInternalRangeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateInternalRangeOperationsSettings, logger);
            DeleteInternalRangeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteInternalRangeOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListInternalRanges = clientHelper.BuildApiCall<ListInternalRangesRequest, ListInternalRangesResponse>("ListInternalRanges", grpcClient.ListInternalRangesAsync, grpcClient.ListInternalRanges, effectiveSettings.ListInternalRangesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListInternalRanges);
            Modify_ListInternalRangesApiCall(ref _callListInternalRanges);
            _callGetInternalRange = clientHelper.BuildApiCall<GetInternalRangeRequest, InternalRange>("GetInternalRange", grpcClient.GetInternalRangeAsync, grpcClient.GetInternalRange, effectiveSettings.GetInternalRangeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetInternalRange);
            Modify_GetInternalRangeApiCall(ref _callGetInternalRange);
            _callCreateInternalRange = clientHelper.BuildApiCall<CreateInternalRangeRequest, lro::Operation>("CreateInternalRange", grpcClient.CreateInternalRangeAsync, grpcClient.CreateInternalRange, effectiveSettings.CreateInternalRangeSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateInternalRange);
            Modify_CreateInternalRangeApiCall(ref _callCreateInternalRange);
            _callUpdateInternalRange = clientHelper.BuildApiCall<UpdateInternalRangeRequest, lro::Operation>("UpdateInternalRange", grpcClient.UpdateInternalRangeAsync, grpcClient.UpdateInternalRange, effectiveSettings.UpdateInternalRangeSettings).WithGoogleRequestParam("internal_range.name", request => request.InternalRange?.Name);
            Modify_ApiCall(ref _callUpdateInternalRange);
            Modify_UpdateInternalRangeApiCall(ref _callUpdateInternalRange);
            _callDeleteInternalRange = clientHelper.BuildApiCall<DeleteInternalRangeRequest, lro::Operation>("DeleteInternalRange", grpcClient.DeleteInternalRangeAsync, grpcClient.DeleteInternalRange, effectiveSettings.DeleteInternalRangeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteInternalRange);
            Modify_DeleteInternalRangeApiCall(ref _callDeleteInternalRange);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListInternalRangesApiCall(ref gaxgrpc::ApiCall<ListInternalRangesRequest, ListInternalRangesResponse> call);

        partial void Modify_GetInternalRangeApiCall(ref gaxgrpc::ApiCall<GetInternalRangeRequest, InternalRange> call);

        partial void Modify_CreateInternalRangeApiCall(ref gaxgrpc::ApiCall<CreateInternalRangeRequest, lro::Operation> call);

        partial void Modify_UpdateInternalRangeApiCall(ref gaxgrpc::ApiCall<UpdateInternalRangeRequest, lro::Operation> call);

        partial void Modify_DeleteInternalRangeApiCall(ref gaxgrpc::ApiCall<DeleteInternalRangeRequest, lro::Operation> call);

        partial void OnConstruction(InternalRangeService.InternalRangeServiceClient grpcClient, InternalRangeServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC InternalRangeService client</summary>
        public override InternalRangeService.InternalRangeServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListInternalRangesRequest(ref ListInternalRangesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetInternalRangeRequest(ref GetInternalRangeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateInternalRangeRequest(ref CreateInternalRangeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateInternalRangeRequest(ref UpdateInternalRangeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteInternalRangeRequest(ref DeleteInternalRangeRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists internal ranges in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InternalRange"/> resources.</returns>
        public override gax::PagedEnumerable<ListInternalRangesResponse, InternalRange> ListInternalRanges(ListInternalRangesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInternalRangesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListInternalRangesRequest, ListInternalRangesResponse, InternalRange>(_callListInternalRanges, request, callSettings);
        }

        /// <summary>
        /// Lists internal ranges in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="InternalRange"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListInternalRangesResponse, InternalRange> ListInternalRangesAsync(ListInternalRangesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInternalRangesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListInternalRangesRequest, ListInternalRangesResponse, InternalRange>(_callListInternalRanges, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single internal range.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override InternalRange GetInternalRange(GetInternalRangeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInternalRangeRequest(ref request, ref callSettings);
            return _callGetInternalRange.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single internal range.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<InternalRange> GetInternalRangeAsync(GetInternalRangeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInternalRangeRequest(ref request, ref callSettings);
            return _callGetInternalRange.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateInternalRange</c>.</summary>
        public override lro::OperationsClient CreateInternalRangeOperationsClient { get; }

        /// <summary>
        /// Creates a new internal range in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<InternalRange, OperationMetadata> CreateInternalRange(CreateInternalRangeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInternalRangeRequest(ref request, ref callSettings);
            return new lro::Operation<InternalRange, OperationMetadata>(_callCreateInternalRange.Sync(request, callSettings), CreateInternalRangeOperationsClient);
        }

        /// <summary>
        /// Creates a new internal range in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<InternalRange, OperationMetadata>> CreateInternalRangeAsync(CreateInternalRangeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInternalRangeRequest(ref request, ref callSettings);
            return new lro::Operation<InternalRange, OperationMetadata>(await _callCreateInternalRange.Async(request, callSettings).ConfigureAwait(false), CreateInternalRangeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateInternalRange</c>.</summary>
        public override lro::OperationsClient UpdateInternalRangeOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single internal range.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<InternalRange, OperationMetadata> UpdateInternalRange(UpdateInternalRangeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInternalRangeRequest(ref request, ref callSettings);
            return new lro::Operation<InternalRange, OperationMetadata>(_callUpdateInternalRange.Sync(request, callSettings), UpdateInternalRangeOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single internal range.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<InternalRange, OperationMetadata>> UpdateInternalRangeAsync(UpdateInternalRangeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInternalRangeRequest(ref request, ref callSettings);
            return new lro::Operation<InternalRange, OperationMetadata>(await _callUpdateInternalRange.Async(request, callSettings).ConfigureAwait(false), UpdateInternalRangeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteInternalRange</c>.</summary>
        public override lro::OperationsClient DeleteInternalRangeOperationsClient { get; }

        /// <summary>
        /// Deletes a single internal range.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteInternalRange(DeleteInternalRangeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInternalRangeRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteInternalRange.Sync(request, callSettings), DeleteInternalRangeOperationsClient);
        }

        /// <summary>
        /// Deletes a single internal range.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInternalRangeAsync(DeleteInternalRangeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInternalRangeRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteInternalRange.Async(request, callSettings).ConfigureAwait(false), DeleteInternalRangeOperationsClient);
        }
    }

    public partial class ListInternalRangesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListInternalRangesResponse : gaxgrpc::IPageResponse<InternalRange>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<InternalRange> GetEnumerator() => InternalRanges.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class InternalRangeService
    {
        public partial class InternalRangeServiceClient
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

    public static partial class InternalRangeService
    {
        public partial class InternalRangeServiceClient
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
