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
    /// <summary>Settings for <see cref="DaiEncodingProfileServiceClient"/> instances.</summary>
    public sealed partial class DaiEncodingProfileServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DaiEncodingProfileServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DaiEncodingProfileServiceSettings"/>.</returns>
        public static DaiEncodingProfileServiceSettings GetDefault() => new DaiEncodingProfileServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="DaiEncodingProfileServiceSettings"/> object with default settings.
        /// </summary>
        public DaiEncodingProfileServiceSettings()
        {
        }

        private DaiEncodingProfileServiceSettings(DaiEncodingProfileServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetDaiEncodingProfileSettings = existing.GetDaiEncodingProfileSettings;
            ListDaiEncodingProfilesSettings = existing.ListDaiEncodingProfilesSettings;
            CreateDaiEncodingProfileSettings = existing.CreateDaiEncodingProfileSettings;
            BatchCreateDaiEncodingProfilesSettings = existing.BatchCreateDaiEncodingProfilesSettings;
            UpdateDaiEncodingProfileSettings = existing.UpdateDaiEncodingProfileSettings;
            BatchUpdateDaiEncodingProfilesSettings = existing.BatchUpdateDaiEncodingProfilesSettings;
            BatchActivateDaiEncodingProfilesSettings = existing.BatchActivateDaiEncodingProfilesSettings;
            BatchArchiveDaiEncodingProfilesSettings = existing.BatchArchiveDaiEncodingProfilesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DaiEncodingProfileServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DaiEncodingProfileServiceClient.GetDaiEncodingProfile</c> and
        /// <c>DaiEncodingProfileServiceClient.GetDaiEncodingProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDaiEncodingProfileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DaiEncodingProfileServiceClient.ListDaiEncodingProfiles</c> and
        /// <c>DaiEncodingProfileServiceClient.ListDaiEncodingProfilesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDaiEncodingProfilesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DaiEncodingProfileServiceClient.CreateDaiEncodingProfile</c> and
        /// <c>DaiEncodingProfileServiceClient.CreateDaiEncodingProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDaiEncodingProfileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DaiEncodingProfileServiceClient.BatchCreateDaiEncodingProfiles</c> and
        /// <c>DaiEncodingProfileServiceClient.BatchCreateDaiEncodingProfilesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateDaiEncodingProfilesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DaiEncodingProfileServiceClient.UpdateDaiEncodingProfile</c> and
        /// <c>DaiEncodingProfileServiceClient.UpdateDaiEncodingProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDaiEncodingProfileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DaiEncodingProfileServiceClient.BatchUpdateDaiEncodingProfiles</c> and
        /// <c>DaiEncodingProfileServiceClient.BatchUpdateDaiEncodingProfilesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchUpdateDaiEncodingProfilesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DaiEncodingProfileServiceClient.BatchActivateDaiEncodingProfiles</c> and
        /// <c>DaiEncodingProfileServiceClient.BatchActivateDaiEncodingProfilesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchActivateDaiEncodingProfilesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DaiEncodingProfileServiceClient.BatchArchiveDaiEncodingProfiles</c> and
        /// <c>DaiEncodingProfileServiceClient.BatchArchiveDaiEncodingProfilesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchArchiveDaiEncodingProfilesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DaiEncodingProfileServiceSettings"/> object.</returns>
        public DaiEncodingProfileServiceSettings Clone() => new DaiEncodingProfileServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DaiEncodingProfileServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class DaiEncodingProfileServiceClientBuilder : gaxgrpc::ClientBuilderBase<DaiEncodingProfileServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DaiEncodingProfileServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DaiEncodingProfileServiceClientBuilder() : base(DaiEncodingProfileServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DaiEncodingProfileServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DaiEncodingProfileServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DaiEncodingProfileServiceClient Build()
        {
            DaiEncodingProfileServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DaiEncodingProfileServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DaiEncodingProfileServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DaiEncodingProfileServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DaiEncodingProfileServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DaiEncodingProfileServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DaiEncodingProfileServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DaiEncodingProfileServiceClient.ChannelPool;
    }

    /// <summary>DaiEncodingProfileService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `DaiEncodingProfile` objects.
    /// </remarks>
    public abstract partial class DaiEncodingProfileServiceClient
    {
        /// <summary>
        /// The default endpoint for the DaiEncodingProfileService service, which is a host of
        /// "admanager.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default DaiEncodingProfileService scopes.</summary>
        /// <remarks>
        /// The default DaiEncodingProfileService scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DaiEncodingProfileService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DaiEncodingProfileServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="DaiEncodingProfileServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DaiEncodingProfileServiceClient"/>.</returns>
        public static stt::Task<DaiEncodingProfileServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DaiEncodingProfileServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DaiEncodingProfileServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="DaiEncodingProfileServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DaiEncodingProfileServiceClient"/>.</returns>
        public static DaiEncodingProfileServiceClient Create() => new DaiEncodingProfileServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DaiEncodingProfileServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DaiEncodingProfileServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DaiEncodingProfileServiceClient"/>.</returns>
        internal static DaiEncodingProfileServiceClient Create(grpccore::CallInvoker callInvoker, DaiEncodingProfileServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DaiEncodingProfileService.DaiEncodingProfileServiceClient grpcClient = new DaiEncodingProfileService.DaiEncodingProfileServiceClient(callInvoker);
            return new DaiEncodingProfileServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DaiEncodingProfileService client</summary>
        public virtual DaiEncodingProfileService.DaiEncodingProfileServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `DaiEncodingProfile` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DaiEncodingProfile GetDaiEncodingProfile(GetDaiEncodingProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `DaiEncodingProfile` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DaiEncodingProfile> GetDaiEncodingProfileAsync(GetDaiEncodingProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `DaiEncodingProfile` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DaiEncodingProfile> GetDaiEncodingProfileAsync(GetDaiEncodingProfileRequest request, st::CancellationToken cancellationToken) =>
            GetDaiEncodingProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `DaiEncodingProfile` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DaiEncodingProfile.
        /// Format:
        /// `networks/{network_code}/daiEncodingProfiles/{dai_encoding_profile_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DaiEncodingProfile GetDaiEncodingProfile(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDaiEncodingProfile(new GetDaiEncodingProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `DaiEncodingProfile` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DaiEncodingProfile.
        /// Format:
        /// `networks/{network_code}/daiEncodingProfiles/{dai_encoding_profile_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DaiEncodingProfile> GetDaiEncodingProfileAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDaiEncodingProfileAsync(new GetDaiEncodingProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `DaiEncodingProfile` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DaiEncodingProfile.
        /// Format:
        /// `networks/{network_code}/daiEncodingProfiles/{dai_encoding_profile_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DaiEncodingProfile> GetDaiEncodingProfileAsync(string name, st::CancellationToken cancellationToken) =>
            GetDaiEncodingProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `DaiEncodingProfile` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DaiEncodingProfile.
        /// Format:
        /// `networks/{network_code}/daiEncodingProfiles/{dai_encoding_profile_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DaiEncodingProfile GetDaiEncodingProfile(DaiEncodingProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDaiEncodingProfile(new GetDaiEncodingProfileRequest
            {
                DaiEncodingProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `DaiEncodingProfile` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DaiEncodingProfile.
        /// Format:
        /// `networks/{network_code}/daiEncodingProfiles/{dai_encoding_profile_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DaiEncodingProfile> GetDaiEncodingProfileAsync(DaiEncodingProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDaiEncodingProfileAsync(new GetDaiEncodingProfileRequest
            {
                DaiEncodingProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `DaiEncodingProfile` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the DaiEncodingProfile.
        /// Format:
        /// `networks/{network_code}/daiEncodingProfiles/{dai_encoding_profile_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DaiEncodingProfile> GetDaiEncodingProfileAsync(DaiEncodingProfileName name, st::CancellationToken cancellationToken) =>
            GetDaiEncodingProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DaiEncodingProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDaiEncodingProfilesResponse, DaiEncodingProfile> ListDaiEncodingProfiles(ListDaiEncodingProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DaiEncodingProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDaiEncodingProfilesResponse, DaiEncodingProfile> ListDaiEncodingProfilesAsync(ListDaiEncodingProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of DaiEncodingProfiles.
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
        /// <returns>A pageable sequence of <see cref="DaiEncodingProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDaiEncodingProfilesResponse, DaiEncodingProfile> ListDaiEncodingProfiles(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDaiEncodingProfilesRequest request = new ListDaiEncodingProfilesRequest
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
            return ListDaiEncodingProfiles(request, callSettings);
        }

        /// <summary>
        /// Lists `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of DaiEncodingProfiles.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DaiEncodingProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDaiEncodingProfilesResponse, DaiEncodingProfile> ListDaiEncodingProfilesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDaiEncodingProfilesRequest request = new ListDaiEncodingProfilesRequest
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
            return ListDaiEncodingProfilesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of DaiEncodingProfiles.
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
        /// <returns>A pageable sequence of <see cref="DaiEncodingProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDaiEncodingProfilesResponse, DaiEncodingProfile> ListDaiEncodingProfiles(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDaiEncodingProfilesRequest request = new ListDaiEncodingProfilesRequest
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
            return ListDaiEncodingProfiles(request, callSettings);
        }

        /// <summary>
        /// Lists `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of DaiEncodingProfiles.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DaiEncodingProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDaiEncodingProfilesResponse, DaiEncodingProfile> ListDaiEncodingProfilesAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDaiEncodingProfilesRequest request = new ListDaiEncodingProfilesRequest
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
            return ListDaiEncodingProfilesAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a `DaiEncodingProfile` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DaiEncodingProfile CreateDaiEncodingProfile(CreateDaiEncodingProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `DaiEncodingProfile` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DaiEncodingProfile> CreateDaiEncodingProfileAsync(CreateDaiEncodingProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `DaiEncodingProfile` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DaiEncodingProfile> CreateDaiEncodingProfileAsync(CreateDaiEncodingProfileRequest request, st::CancellationToken cancellationToken) =>
            CreateDaiEncodingProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `DaiEncodingProfile` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `DaiEncodingProfile` will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="daiEncodingProfile">
        /// Required. The `DaiEncodingProfile` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DaiEncodingProfile CreateDaiEncodingProfile(string parent, DaiEncodingProfile daiEncodingProfile, gaxgrpc::CallSettings callSettings = null) =>
            CreateDaiEncodingProfile(new CreateDaiEncodingProfileRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DaiEncodingProfile = gax::GaxPreconditions.CheckNotNull(daiEncodingProfile, nameof(daiEncodingProfile)),
            }, callSettings);

        /// <summary>
        /// Creates a `DaiEncodingProfile` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `DaiEncodingProfile` will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="daiEncodingProfile">
        /// Required. The `DaiEncodingProfile` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DaiEncodingProfile> CreateDaiEncodingProfileAsync(string parent, DaiEncodingProfile daiEncodingProfile, gaxgrpc::CallSettings callSettings = null) =>
            CreateDaiEncodingProfileAsync(new CreateDaiEncodingProfileRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DaiEncodingProfile = gax::GaxPreconditions.CheckNotNull(daiEncodingProfile, nameof(daiEncodingProfile)),
            }, callSettings);

        /// <summary>
        /// Creates a `DaiEncodingProfile` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `DaiEncodingProfile` will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="daiEncodingProfile">
        /// Required. The `DaiEncodingProfile` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DaiEncodingProfile> CreateDaiEncodingProfileAsync(string parent, DaiEncodingProfile daiEncodingProfile, st::CancellationToken cancellationToken) =>
            CreateDaiEncodingProfileAsync(parent, daiEncodingProfile, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `DaiEncodingProfile` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `DaiEncodingProfile` will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="daiEncodingProfile">
        /// Required. The `DaiEncodingProfile` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DaiEncodingProfile CreateDaiEncodingProfile(NetworkName parent, DaiEncodingProfile daiEncodingProfile, gaxgrpc::CallSettings callSettings = null) =>
            CreateDaiEncodingProfile(new CreateDaiEncodingProfileRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DaiEncodingProfile = gax::GaxPreconditions.CheckNotNull(daiEncodingProfile, nameof(daiEncodingProfile)),
            }, callSettings);

        /// <summary>
        /// Creates a `DaiEncodingProfile` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `DaiEncodingProfile` will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="daiEncodingProfile">
        /// Required. The `DaiEncodingProfile` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DaiEncodingProfile> CreateDaiEncodingProfileAsync(NetworkName parent, DaiEncodingProfile daiEncodingProfile, gaxgrpc::CallSettings callSettings = null) =>
            CreateDaiEncodingProfileAsync(new CreateDaiEncodingProfileRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DaiEncodingProfile = gax::GaxPreconditions.CheckNotNull(daiEncodingProfile, nameof(daiEncodingProfile)),
            }, callSettings);

        /// <summary>
        /// Creates a `DaiEncodingProfile` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `DaiEncodingProfile` will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="daiEncodingProfile">
        /// Required. The `DaiEncodingProfile` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DaiEncodingProfile> CreateDaiEncodingProfileAsync(NetworkName parent, DaiEncodingProfile daiEncodingProfile, st::CancellationToken cancellationToken) =>
            CreateDaiEncodingProfileAsync(parent, daiEncodingProfile, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch creates `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateDaiEncodingProfilesResponse BatchCreateDaiEncodingProfiles(BatchCreateDaiEncodingProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch creates `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateDaiEncodingProfilesResponse> BatchCreateDaiEncodingProfilesAsync(BatchCreateDaiEncodingProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch creates `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateDaiEncodingProfilesResponse> BatchCreateDaiEncodingProfilesAsync(BatchCreateDaiEncodingProfilesRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateDaiEncodingProfilesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch creates `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `DaiEncodingProfiles` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateDaiEncodingProfileRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `DaiEncodingProfile` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateDaiEncodingProfilesResponse BatchCreateDaiEncodingProfiles(string parent, scg::IEnumerable<CreateDaiEncodingProfileRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateDaiEncodingProfiles(new BatchCreateDaiEncodingProfilesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch creates `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `DaiEncodingProfiles` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateDaiEncodingProfileRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `DaiEncodingProfile` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateDaiEncodingProfilesResponse> BatchCreateDaiEncodingProfilesAsync(string parent, scg::IEnumerable<CreateDaiEncodingProfileRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateDaiEncodingProfilesAsync(new BatchCreateDaiEncodingProfilesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch creates `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `DaiEncodingProfiles` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateDaiEncodingProfileRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `DaiEncodingProfile` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateDaiEncodingProfilesResponse> BatchCreateDaiEncodingProfilesAsync(string parent, scg::IEnumerable<CreateDaiEncodingProfileRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateDaiEncodingProfilesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch creates `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `DaiEncodingProfiles` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateDaiEncodingProfileRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `DaiEncodingProfile` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateDaiEncodingProfilesResponse BatchCreateDaiEncodingProfiles(NetworkName parent, scg::IEnumerable<CreateDaiEncodingProfileRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateDaiEncodingProfiles(new BatchCreateDaiEncodingProfilesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch creates `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `DaiEncodingProfiles` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateDaiEncodingProfileRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `DaiEncodingProfile` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateDaiEncodingProfilesResponse> BatchCreateDaiEncodingProfilesAsync(NetworkName parent, scg::IEnumerable<CreateDaiEncodingProfileRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateDaiEncodingProfilesAsync(new BatchCreateDaiEncodingProfilesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch creates `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `DaiEncodingProfiles` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateDaiEncodingProfileRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `DaiEncodingProfile` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateDaiEncodingProfilesResponse> BatchCreateDaiEncodingProfilesAsync(NetworkName parent, scg::IEnumerable<CreateDaiEncodingProfileRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateDaiEncodingProfilesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `DaiEncodingProfile` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DaiEncodingProfile UpdateDaiEncodingProfile(UpdateDaiEncodingProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `DaiEncodingProfile` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DaiEncodingProfile> UpdateDaiEncodingProfileAsync(UpdateDaiEncodingProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `DaiEncodingProfile` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DaiEncodingProfile> UpdateDaiEncodingProfileAsync(UpdateDaiEncodingProfileRequest request, st::CancellationToken cancellationToken) =>
            UpdateDaiEncodingProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `DaiEncodingProfile` object.
        /// </summary>
        /// <param name="daiEncodingProfile">
        /// Required. The `DaiEncodingProfile` to update.
        /// 
        /// The `DaiEncodingProfile`'s `name` is used to identify the
        /// `DaiEncodingProfile` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DaiEncodingProfile UpdateDaiEncodingProfile(DaiEncodingProfile daiEncodingProfile, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDaiEncodingProfile(new UpdateDaiEncodingProfileRequest
            {
                DaiEncodingProfile = gax::GaxPreconditions.CheckNotNull(daiEncodingProfile, nameof(daiEncodingProfile)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a `DaiEncodingProfile` object.
        /// </summary>
        /// <param name="daiEncodingProfile">
        /// Required. The `DaiEncodingProfile` to update.
        /// 
        /// The `DaiEncodingProfile`'s `name` is used to identify the
        /// `DaiEncodingProfile` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DaiEncodingProfile> UpdateDaiEncodingProfileAsync(DaiEncodingProfile daiEncodingProfile, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDaiEncodingProfileAsync(new UpdateDaiEncodingProfileRequest
            {
                DaiEncodingProfile = gax::GaxPreconditions.CheckNotNull(daiEncodingProfile, nameof(daiEncodingProfile)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a `DaiEncodingProfile` object.
        /// </summary>
        /// <param name="daiEncodingProfile">
        /// Required. The `DaiEncodingProfile` to update.
        /// 
        /// The `DaiEncodingProfile`'s `name` is used to identify the
        /// `DaiEncodingProfile` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DaiEncodingProfile> UpdateDaiEncodingProfileAsync(DaiEncodingProfile daiEncodingProfile, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDaiEncodingProfileAsync(daiEncodingProfile, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateDaiEncodingProfilesResponse BatchUpdateDaiEncodingProfiles(BatchUpdateDaiEncodingProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateDaiEncodingProfilesResponse> BatchUpdateDaiEncodingProfilesAsync(BatchUpdateDaiEncodingProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateDaiEncodingProfilesResponse> BatchUpdateDaiEncodingProfilesAsync(BatchUpdateDaiEncodingProfilesRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdateDaiEncodingProfilesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `DaiEncodingProfiles` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateDaiEncodingProfileRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `DaiEncodingProfile` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateDaiEncodingProfilesResponse BatchUpdateDaiEncodingProfiles(string parent, scg::IEnumerable<UpdateDaiEncodingProfileRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateDaiEncodingProfiles(new BatchUpdateDaiEncodingProfilesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `DaiEncodingProfiles` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateDaiEncodingProfileRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `DaiEncodingProfile` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateDaiEncodingProfilesResponse> BatchUpdateDaiEncodingProfilesAsync(string parent, scg::IEnumerable<UpdateDaiEncodingProfileRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateDaiEncodingProfilesAsync(new BatchUpdateDaiEncodingProfilesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `DaiEncodingProfiles` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateDaiEncodingProfileRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `DaiEncodingProfile` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateDaiEncodingProfilesResponse> BatchUpdateDaiEncodingProfilesAsync(string parent, scg::IEnumerable<UpdateDaiEncodingProfileRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateDaiEncodingProfilesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `DaiEncodingProfiles` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateDaiEncodingProfileRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `DaiEncodingProfile` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateDaiEncodingProfilesResponse BatchUpdateDaiEncodingProfiles(NetworkName parent, scg::IEnumerable<UpdateDaiEncodingProfileRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateDaiEncodingProfiles(new BatchUpdateDaiEncodingProfilesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `DaiEncodingProfiles` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateDaiEncodingProfileRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `DaiEncodingProfile` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateDaiEncodingProfilesResponse> BatchUpdateDaiEncodingProfilesAsync(NetworkName parent, scg::IEnumerable<UpdateDaiEncodingProfileRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateDaiEncodingProfilesAsync(new BatchUpdateDaiEncodingProfilesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `DaiEncodingProfiles` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateDaiEncodingProfileRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `DaiEncodingProfile` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateDaiEncodingProfilesResponse> BatchUpdateDaiEncodingProfilesAsync(NetworkName parent, scg::IEnumerable<UpdateDaiEncodingProfileRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateDaiEncodingProfilesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Activates a list of `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateDaiEncodingProfilesResponse BatchActivateDaiEncodingProfiles(BatchActivateDaiEncodingProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Activates a list of `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateDaiEncodingProfilesResponse> BatchActivateDaiEncodingProfilesAsync(BatchActivateDaiEncodingProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Activates a list of `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateDaiEncodingProfilesResponse> BatchActivateDaiEncodingProfilesAsync(BatchActivateDaiEncodingProfilesRequest request, st::CancellationToken cancellationToken) =>
            BatchActivateDaiEncodingProfilesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Activates a list of `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="requests">
        /// Required. The `DaiEncodingProfile` objects to activate.
        /// A maximum of 100 objects can be activated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateDaiEncodingProfilesResponse BatchActivateDaiEncodingProfiles(string parent, scg::IEnumerable<ActivateDaiEncodingProfileRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateDaiEncodingProfiles(new BatchActivateDaiEncodingProfilesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Activates a list of `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="requests">
        /// Required. The `DaiEncodingProfile` objects to activate.
        /// A maximum of 100 objects can be activated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateDaiEncodingProfilesResponse> BatchActivateDaiEncodingProfilesAsync(string parent, scg::IEnumerable<ActivateDaiEncodingProfileRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateDaiEncodingProfilesAsync(new BatchActivateDaiEncodingProfilesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Activates a list of `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="requests">
        /// Required. The `DaiEncodingProfile` objects to activate.
        /// A maximum of 100 objects can be activated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateDaiEncodingProfilesResponse> BatchActivateDaiEncodingProfilesAsync(string parent, scg::IEnumerable<ActivateDaiEncodingProfileRequest> requests, st::CancellationToken cancellationToken) =>
            BatchActivateDaiEncodingProfilesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Activates a list of `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="requests">
        /// Required. The `DaiEncodingProfile` objects to activate.
        /// A maximum of 100 objects can be activated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateDaiEncodingProfilesResponse BatchActivateDaiEncodingProfiles(NetworkName parent, scg::IEnumerable<ActivateDaiEncodingProfileRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateDaiEncodingProfiles(new BatchActivateDaiEncodingProfilesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Activates a list of `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="requests">
        /// Required. The `DaiEncodingProfile` objects to activate.
        /// A maximum of 100 objects can be activated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateDaiEncodingProfilesResponse> BatchActivateDaiEncodingProfilesAsync(NetworkName parent, scg::IEnumerable<ActivateDaiEncodingProfileRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateDaiEncodingProfilesAsync(new BatchActivateDaiEncodingProfilesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Activates a list of `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="requests">
        /// Required. The `DaiEncodingProfile` objects to activate.
        /// A maximum of 100 objects can be activated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateDaiEncodingProfilesResponse> BatchActivateDaiEncodingProfilesAsync(NetworkName parent, scg::IEnumerable<ActivateDaiEncodingProfileRequest> requests, st::CancellationToken cancellationToken) =>
            BatchActivateDaiEncodingProfilesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Archives a list of `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchArchiveDaiEncodingProfilesResponse BatchArchiveDaiEncodingProfiles(BatchArchiveDaiEncodingProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Archives a list of `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveDaiEncodingProfilesResponse> BatchArchiveDaiEncodingProfilesAsync(BatchArchiveDaiEncodingProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Archives a list of `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveDaiEncodingProfilesResponse> BatchArchiveDaiEncodingProfilesAsync(BatchArchiveDaiEncodingProfilesRequest request, st::CancellationToken cancellationToken) =>
            BatchArchiveDaiEncodingProfilesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Archives a list of `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="requests">
        /// Required. The `DaiEncodingProfile` objects to archive.
        /// A maximum of 100 objects can be archived in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchArchiveDaiEncodingProfilesResponse BatchArchiveDaiEncodingProfiles(string parent, scg::IEnumerable<ArchiveDaiEncodingProfileRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchArchiveDaiEncodingProfiles(new BatchArchiveDaiEncodingProfilesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Archives a list of `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="requests">
        /// Required. The `DaiEncodingProfile` objects to archive.
        /// A maximum of 100 objects can be archived in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveDaiEncodingProfilesResponse> BatchArchiveDaiEncodingProfilesAsync(string parent, scg::IEnumerable<ArchiveDaiEncodingProfileRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchArchiveDaiEncodingProfilesAsync(new BatchArchiveDaiEncodingProfilesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Archives a list of `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="requests">
        /// Required. The `DaiEncodingProfile` objects to archive.
        /// A maximum of 100 objects can be archived in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveDaiEncodingProfilesResponse> BatchArchiveDaiEncodingProfilesAsync(string parent, scg::IEnumerable<ArchiveDaiEncodingProfileRequest> requests, st::CancellationToken cancellationToken) =>
            BatchArchiveDaiEncodingProfilesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Archives a list of `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="requests">
        /// Required. The `DaiEncodingProfile` objects to archive.
        /// A maximum of 100 objects can be archived in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchArchiveDaiEncodingProfilesResponse BatchArchiveDaiEncodingProfiles(NetworkName parent, scg::IEnumerable<ArchiveDaiEncodingProfileRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchArchiveDaiEncodingProfiles(new BatchArchiveDaiEncodingProfilesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Archives a list of `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="requests">
        /// Required. The `DaiEncodingProfile` objects to archive.
        /// A maximum of 100 objects can be archived in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveDaiEncodingProfilesResponse> BatchArchiveDaiEncodingProfilesAsync(NetworkName parent, scg::IEnumerable<ArchiveDaiEncodingProfileRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchArchiveDaiEncodingProfilesAsync(new BatchArchiveDaiEncodingProfilesRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Archives a list of `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="requests">
        /// Required. The `DaiEncodingProfile` objects to archive.
        /// A maximum of 100 objects can be archived in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveDaiEncodingProfilesResponse> BatchArchiveDaiEncodingProfilesAsync(NetworkName parent, scg::IEnumerable<ArchiveDaiEncodingProfileRequest> requests, st::CancellationToken cancellationToken) =>
            BatchArchiveDaiEncodingProfilesAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DaiEncodingProfileService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `DaiEncodingProfile` objects.
    /// </remarks>
    public sealed partial class DaiEncodingProfileServiceClientImpl : DaiEncodingProfileServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetDaiEncodingProfileRequest, DaiEncodingProfile> _callGetDaiEncodingProfile;

        private readonly gaxgrpc::ApiCall<ListDaiEncodingProfilesRequest, ListDaiEncodingProfilesResponse> _callListDaiEncodingProfiles;

        private readonly gaxgrpc::ApiCall<CreateDaiEncodingProfileRequest, DaiEncodingProfile> _callCreateDaiEncodingProfile;

        private readonly gaxgrpc::ApiCall<BatchCreateDaiEncodingProfilesRequest, BatchCreateDaiEncodingProfilesResponse> _callBatchCreateDaiEncodingProfiles;

        private readonly gaxgrpc::ApiCall<UpdateDaiEncodingProfileRequest, DaiEncodingProfile> _callUpdateDaiEncodingProfile;

        private readonly gaxgrpc::ApiCall<BatchUpdateDaiEncodingProfilesRequest, BatchUpdateDaiEncodingProfilesResponse> _callBatchUpdateDaiEncodingProfiles;

        private readonly gaxgrpc::ApiCall<BatchActivateDaiEncodingProfilesRequest, BatchActivateDaiEncodingProfilesResponse> _callBatchActivateDaiEncodingProfiles;

        private readonly gaxgrpc::ApiCall<BatchArchiveDaiEncodingProfilesRequest, BatchArchiveDaiEncodingProfilesResponse> _callBatchArchiveDaiEncodingProfiles;

        /// <summary>
        /// Constructs a client wrapper for the DaiEncodingProfileService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="DaiEncodingProfileServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DaiEncodingProfileServiceClientImpl(DaiEncodingProfileService.DaiEncodingProfileServiceClient grpcClient, DaiEncodingProfileServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DaiEncodingProfileServiceSettings effectiveSettings = settings ?? DaiEncodingProfileServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetDaiEncodingProfile = clientHelper.BuildApiCall<GetDaiEncodingProfileRequest, DaiEncodingProfile>("GetDaiEncodingProfile", grpcClient.GetDaiEncodingProfileAsync, grpcClient.GetDaiEncodingProfile, effectiveSettings.GetDaiEncodingProfileSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDaiEncodingProfile);
            Modify_GetDaiEncodingProfileApiCall(ref _callGetDaiEncodingProfile);
            _callListDaiEncodingProfiles = clientHelper.BuildApiCall<ListDaiEncodingProfilesRequest, ListDaiEncodingProfilesResponse>("ListDaiEncodingProfiles", grpcClient.ListDaiEncodingProfilesAsync, grpcClient.ListDaiEncodingProfiles, effectiveSettings.ListDaiEncodingProfilesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDaiEncodingProfiles);
            Modify_ListDaiEncodingProfilesApiCall(ref _callListDaiEncodingProfiles);
            _callCreateDaiEncodingProfile = clientHelper.BuildApiCall<CreateDaiEncodingProfileRequest, DaiEncodingProfile>("CreateDaiEncodingProfile", grpcClient.CreateDaiEncodingProfileAsync, grpcClient.CreateDaiEncodingProfile, effectiveSettings.CreateDaiEncodingProfileSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDaiEncodingProfile);
            Modify_CreateDaiEncodingProfileApiCall(ref _callCreateDaiEncodingProfile);
            _callBatchCreateDaiEncodingProfiles = clientHelper.BuildApiCall<BatchCreateDaiEncodingProfilesRequest, BatchCreateDaiEncodingProfilesResponse>("BatchCreateDaiEncodingProfiles", grpcClient.BatchCreateDaiEncodingProfilesAsync, grpcClient.BatchCreateDaiEncodingProfiles, effectiveSettings.BatchCreateDaiEncodingProfilesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateDaiEncodingProfiles);
            Modify_BatchCreateDaiEncodingProfilesApiCall(ref _callBatchCreateDaiEncodingProfiles);
            _callUpdateDaiEncodingProfile = clientHelper.BuildApiCall<UpdateDaiEncodingProfileRequest, DaiEncodingProfile>("UpdateDaiEncodingProfile", grpcClient.UpdateDaiEncodingProfileAsync, grpcClient.UpdateDaiEncodingProfile, effectiveSettings.UpdateDaiEncodingProfileSettings).WithGoogleRequestParam("dai_encoding_profile.name", request => request.DaiEncodingProfile?.Name);
            Modify_ApiCall(ref _callUpdateDaiEncodingProfile);
            Modify_UpdateDaiEncodingProfileApiCall(ref _callUpdateDaiEncodingProfile);
            _callBatchUpdateDaiEncodingProfiles = clientHelper.BuildApiCall<BatchUpdateDaiEncodingProfilesRequest, BatchUpdateDaiEncodingProfilesResponse>("BatchUpdateDaiEncodingProfiles", grpcClient.BatchUpdateDaiEncodingProfilesAsync, grpcClient.BatchUpdateDaiEncodingProfiles, effectiveSettings.BatchUpdateDaiEncodingProfilesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUpdateDaiEncodingProfiles);
            Modify_BatchUpdateDaiEncodingProfilesApiCall(ref _callBatchUpdateDaiEncodingProfiles);
            _callBatchActivateDaiEncodingProfiles = clientHelper.BuildApiCall<BatchActivateDaiEncodingProfilesRequest, BatchActivateDaiEncodingProfilesResponse>("BatchActivateDaiEncodingProfiles", grpcClient.BatchActivateDaiEncodingProfilesAsync, grpcClient.BatchActivateDaiEncodingProfiles, effectiveSettings.BatchActivateDaiEncodingProfilesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchActivateDaiEncodingProfiles);
            Modify_BatchActivateDaiEncodingProfilesApiCall(ref _callBatchActivateDaiEncodingProfiles);
            _callBatchArchiveDaiEncodingProfiles = clientHelper.BuildApiCall<BatchArchiveDaiEncodingProfilesRequest, BatchArchiveDaiEncodingProfilesResponse>("BatchArchiveDaiEncodingProfiles", grpcClient.BatchArchiveDaiEncodingProfilesAsync, grpcClient.BatchArchiveDaiEncodingProfiles, effectiveSettings.BatchArchiveDaiEncodingProfilesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchArchiveDaiEncodingProfiles);
            Modify_BatchArchiveDaiEncodingProfilesApiCall(ref _callBatchArchiveDaiEncodingProfiles);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetDaiEncodingProfileApiCall(ref gaxgrpc::ApiCall<GetDaiEncodingProfileRequest, DaiEncodingProfile> call);

        partial void Modify_ListDaiEncodingProfilesApiCall(ref gaxgrpc::ApiCall<ListDaiEncodingProfilesRequest, ListDaiEncodingProfilesResponse> call);

        partial void Modify_CreateDaiEncodingProfileApiCall(ref gaxgrpc::ApiCall<CreateDaiEncodingProfileRequest, DaiEncodingProfile> call);

        partial void Modify_BatchCreateDaiEncodingProfilesApiCall(ref gaxgrpc::ApiCall<BatchCreateDaiEncodingProfilesRequest, BatchCreateDaiEncodingProfilesResponse> call);

        partial void Modify_UpdateDaiEncodingProfileApiCall(ref gaxgrpc::ApiCall<UpdateDaiEncodingProfileRequest, DaiEncodingProfile> call);

        partial void Modify_BatchUpdateDaiEncodingProfilesApiCall(ref gaxgrpc::ApiCall<BatchUpdateDaiEncodingProfilesRequest, BatchUpdateDaiEncodingProfilesResponse> call);

        partial void Modify_BatchActivateDaiEncodingProfilesApiCall(ref gaxgrpc::ApiCall<BatchActivateDaiEncodingProfilesRequest, BatchActivateDaiEncodingProfilesResponse> call);

        partial void Modify_BatchArchiveDaiEncodingProfilesApiCall(ref gaxgrpc::ApiCall<BatchArchiveDaiEncodingProfilesRequest, BatchArchiveDaiEncodingProfilesResponse> call);

        partial void OnConstruction(DaiEncodingProfileService.DaiEncodingProfileServiceClient grpcClient, DaiEncodingProfileServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DaiEncodingProfileService client</summary>
        public override DaiEncodingProfileService.DaiEncodingProfileServiceClient GrpcClient { get; }

        partial void Modify_GetDaiEncodingProfileRequest(ref GetDaiEncodingProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDaiEncodingProfilesRequest(ref ListDaiEncodingProfilesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateDaiEncodingProfileRequest(ref CreateDaiEncodingProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateDaiEncodingProfilesRequest(ref BatchCreateDaiEncodingProfilesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDaiEncodingProfileRequest(ref UpdateDaiEncodingProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdateDaiEncodingProfilesRequest(ref BatchUpdateDaiEncodingProfilesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchActivateDaiEncodingProfilesRequest(ref BatchActivateDaiEncodingProfilesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchArchiveDaiEncodingProfilesRequest(ref BatchArchiveDaiEncodingProfilesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves a `DaiEncodingProfile` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DaiEncodingProfile GetDaiEncodingProfile(GetDaiEncodingProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDaiEncodingProfileRequest(ref request, ref callSettings);
            return _callGetDaiEncodingProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a `DaiEncodingProfile` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DaiEncodingProfile> GetDaiEncodingProfileAsync(GetDaiEncodingProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDaiEncodingProfileRequest(ref request, ref callSettings);
            return _callGetDaiEncodingProfile.Async(request, callSettings);
        }

        /// <summary>
        /// Lists `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DaiEncodingProfile"/> resources.</returns>
        public override gax::PagedEnumerable<ListDaiEncodingProfilesResponse, DaiEncodingProfile> ListDaiEncodingProfiles(ListDaiEncodingProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDaiEncodingProfilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDaiEncodingProfilesRequest, ListDaiEncodingProfilesResponse, DaiEncodingProfile>(_callListDaiEncodingProfiles, request, callSettings);
        }

        /// <summary>
        /// Lists `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DaiEncodingProfile"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDaiEncodingProfilesResponse, DaiEncodingProfile> ListDaiEncodingProfilesAsync(ListDaiEncodingProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDaiEncodingProfilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDaiEncodingProfilesRequest, ListDaiEncodingProfilesResponse, DaiEncodingProfile>(_callListDaiEncodingProfiles, request, callSettings);
        }

        /// <summary>
        /// Creates a `DaiEncodingProfile` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DaiEncodingProfile CreateDaiEncodingProfile(CreateDaiEncodingProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDaiEncodingProfileRequest(ref request, ref callSettings);
            return _callCreateDaiEncodingProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a `DaiEncodingProfile` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DaiEncodingProfile> CreateDaiEncodingProfileAsync(CreateDaiEncodingProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDaiEncodingProfileRequest(ref request, ref callSettings);
            return _callCreateDaiEncodingProfile.Async(request, callSettings);
        }

        /// <summary>
        /// Batch creates `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCreateDaiEncodingProfilesResponse BatchCreateDaiEncodingProfiles(BatchCreateDaiEncodingProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateDaiEncodingProfilesRequest(ref request, ref callSettings);
            return _callBatchCreateDaiEncodingProfiles.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch creates `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCreateDaiEncodingProfilesResponse> BatchCreateDaiEncodingProfilesAsync(BatchCreateDaiEncodingProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateDaiEncodingProfilesRequest(ref request, ref callSettings);
            return _callBatchCreateDaiEncodingProfiles.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a `DaiEncodingProfile` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DaiEncodingProfile UpdateDaiEncodingProfile(UpdateDaiEncodingProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDaiEncodingProfileRequest(ref request, ref callSettings);
            return _callUpdateDaiEncodingProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a `DaiEncodingProfile` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DaiEncodingProfile> UpdateDaiEncodingProfileAsync(UpdateDaiEncodingProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDaiEncodingProfileRequest(ref request, ref callSettings);
            return _callUpdateDaiEncodingProfile.Async(request, callSettings);
        }

        /// <summary>
        /// Batch updates `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchUpdateDaiEncodingProfilesResponse BatchUpdateDaiEncodingProfiles(BatchUpdateDaiEncodingProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateDaiEncodingProfilesRequest(ref request, ref callSettings);
            return _callBatchUpdateDaiEncodingProfiles.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch updates `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchUpdateDaiEncodingProfilesResponse> BatchUpdateDaiEncodingProfilesAsync(BatchUpdateDaiEncodingProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateDaiEncodingProfilesRequest(ref request, ref callSettings);
            return _callBatchUpdateDaiEncodingProfiles.Async(request, callSettings);
        }

        /// <summary>
        /// Activates a list of `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchActivateDaiEncodingProfilesResponse BatchActivateDaiEncodingProfiles(BatchActivateDaiEncodingProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchActivateDaiEncodingProfilesRequest(ref request, ref callSettings);
            return _callBatchActivateDaiEncodingProfiles.Sync(request, callSettings);
        }

        /// <summary>
        /// Activates a list of `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchActivateDaiEncodingProfilesResponse> BatchActivateDaiEncodingProfilesAsync(BatchActivateDaiEncodingProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchActivateDaiEncodingProfilesRequest(ref request, ref callSettings);
            return _callBatchActivateDaiEncodingProfiles.Async(request, callSettings);
        }

        /// <summary>
        /// Archives a list of `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchArchiveDaiEncodingProfilesResponse BatchArchiveDaiEncodingProfiles(BatchArchiveDaiEncodingProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchArchiveDaiEncodingProfilesRequest(ref request, ref callSettings);
            return _callBatchArchiveDaiEncodingProfiles.Sync(request, callSettings);
        }

        /// <summary>
        /// Archives a list of `DaiEncodingProfile` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchArchiveDaiEncodingProfilesResponse> BatchArchiveDaiEncodingProfilesAsync(BatchArchiveDaiEncodingProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchArchiveDaiEncodingProfilesRequest(ref request, ref callSettings);
            return _callBatchArchiveDaiEncodingProfiles.Async(request, callSettings);
        }
    }

    public partial class ListDaiEncodingProfilesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDaiEncodingProfilesResponse : gaxgrpc::IPageResponse<DaiEncodingProfile>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DaiEncodingProfile> GetEnumerator() => DaiEncodingProfiles.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
