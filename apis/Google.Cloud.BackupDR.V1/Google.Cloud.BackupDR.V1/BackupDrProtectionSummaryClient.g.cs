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
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.BackupDR.V1
{
    /// <summary>Settings for <see cref="BackupDrProtectionSummaryClient"/> instances.</summary>
    public sealed partial class BackupDrProtectionSummarySettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BackupDrProtectionSummarySettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BackupDrProtectionSummarySettings"/>.</returns>
        public static BackupDrProtectionSummarySettings GetDefault() => new BackupDrProtectionSummarySettings();

        /// <summary>
        /// Constructs a new <see cref="BackupDrProtectionSummarySettings"/> object with default settings.
        /// </summary>
        public BackupDrProtectionSummarySettings()
        {
        }

        private BackupDrProtectionSummarySettings(BackupDrProtectionSummarySettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListResourceBackupConfigsSettings = existing.ListResourceBackupConfigsSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(BackupDrProtectionSummarySettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupDrProtectionSummaryClient.ListResourceBackupConfigs</c> and
        /// <c>BackupDrProtectionSummaryClient.ListResourceBackupConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListResourceBackupConfigsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BackupDrProtectionSummarySettings"/> object.</returns>
        public BackupDrProtectionSummarySettings Clone() => new BackupDrProtectionSummarySettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BackupDrProtectionSummaryClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class BackupDrProtectionSummaryClientBuilder : gaxgrpc::ClientBuilderBase<BackupDrProtectionSummaryClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BackupDrProtectionSummarySettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public BackupDrProtectionSummaryClientBuilder() : base(BackupDrProtectionSummaryClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref BackupDrProtectionSummaryClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<BackupDrProtectionSummaryClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override BackupDrProtectionSummaryClient Build()
        {
            BackupDrProtectionSummaryClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<BackupDrProtectionSummaryClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<BackupDrProtectionSummaryClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private BackupDrProtectionSummaryClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BackupDrProtectionSummaryClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<BackupDrProtectionSummaryClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BackupDrProtectionSummaryClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BackupDrProtectionSummaryClient.ChannelPool;
    }

    /// <summary>BackupDrProtectionSummary client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The Protection Summary service.
    /// </remarks>
    public abstract partial class BackupDrProtectionSummaryClient
    {
        /// <summary>
        /// The default endpoint for the BackupDrProtectionSummary service, which is a host of "backupdr.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "backupdr.googleapis.com:443";

        /// <summary>The default BackupDrProtectionSummary scopes.</summary>
        /// <remarks>
        /// The default BackupDrProtectionSummary scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(BackupDrProtectionSummary.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="BackupDrProtectionSummaryClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="BackupDrProtectionSummaryClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="BackupDrProtectionSummaryClient"/>.</returns>
        public static stt::Task<BackupDrProtectionSummaryClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new BackupDrProtectionSummaryClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="BackupDrProtectionSummaryClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="BackupDrProtectionSummaryClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="BackupDrProtectionSummaryClient"/>.</returns>
        public static BackupDrProtectionSummaryClient Create() => new BackupDrProtectionSummaryClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="BackupDrProtectionSummaryClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BackupDrProtectionSummarySettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="BackupDrProtectionSummaryClient"/>.</returns>
        internal static BackupDrProtectionSummaryClient Create(grpccore::CallInvoker callInvoker, BackupDrProtectionSummarySettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BackupDrProtectionSummary.BackupDrProtectionSummaryClient grpcClient = new BackupDrProtectionSummary.BackupDrProtectionSummaryClient(callInvoker);
            return new BackupDrProtectionSummaryClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC BackupDrProtectionSummary client</summary>
        public virtual BackupDrProtectionSummary.BackupDrProtectionSummaryClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ResourceBackupConfigs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ResourceBackupConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListResourceBackupConfigsResponse, ResourceBackupConfig> ListResourceBackupConfigs(ListResourceBackupConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ResourceBackupConfigs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ResourceBackupConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListResourceBackupConfigsResponse, ResourceBackupConfig> ListResourceBackupConfigsAsync(ListResourceBackupConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ResourceBackupConfigs.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location for which to retrieve resource backup
        /// configs. Format: 'projects/{project_id}/locations/{location}'. In Google
        /// Cloud Backup and DR, locations map to Google Cloud regions, for example
        /// **us-central1**.
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
        /// <returns>A pageable sequence of <see cref="ResourceBackupConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListResourceBackupConfigsResponse, ResourceBackupConfig> ListResourceBackupConfigs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListResourceBackupConfigsRequest request = new ListResourceBackupConfigsRequest
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
            return ListResourceBackupConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists ResourceBackupConfigs.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location for which to retrieve resource backup
        /// configs. Format: 'projects/{project_id}/locations/{location}'. In Google
        /// Cloud Backup and DR, locations map to Google Cloud regions, for example
        /// **us-central1**.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ResourceBackupConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListResourceBackupConfigsResponse, ResourceBackupConfig> ListResourceBackupConfigsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListResourceBackupConfigsRequest request = new ListResourceBackupConfigsRequest
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
            return ListResourceBackupConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists ResourceBackupConfigs.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location for which to retrieve resource backup
        /// configs. Format: 'projects/{project_id}/locations/{location}'. In Google
        /// Cloud Backup and DR, locations map to Google Cloud regions, for example
        /// **us-central1**.
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
        /// <returns>A pageable sequence of <see cref="ResourceBackupConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListResourceBackupConfigsResponse, ResourceBackupConfig> ListResourceBackupConfigs(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListResourceBackupConfigsRequest request = new ListResourceBackupConfigsRequest
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
            return ListResourceBackupConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists ResourceBackupConfigs.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location for which to retrieve resource backup
        /// configs. Format: 'projects/{project_id}/locations/{location}'. In Google
        /// Cloud Backup and DR, locations map to Google Cloud regions, for example
        /// **us-central1**.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ResourceBackupConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListResourceBackupConfigsResponse, ResourceBackupConfig> ListResourceBackupConfigsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListResourceBackupConfigsRequest request = new ListResourceBackupConfigsRequest
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
            return ListResourceBackupConfigsAsync(request, callSettings);
        }
    }

    /// <summary>BackupDrProtectionSummary client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The Protection Summary service.
    /// </remarks>
    public sealed partial class BackupDrProtectionSummaryClientImpl : BackupDrProtectionSummaryClient
    {
        private readonly gaxgrpc::ApiCall<ListResourceBackupConfigsRequest, ListResourceBackupConfigsResponse> _callListResourceBackupConfigs;

        /// <summary>
        /// Constructs a client wrapper for the BackupDrProtectionSummary service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="BackupDrProtectionSummarySettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public BackupDrProtectionSummaryClientImpl(BackupDrProtectionSummary.BackupDrProtectionSummaryClient grpcClient, BackupDrProtectionSummarySettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            BackupDrProtectionSummarySettings effectiveSettings = settings ?? BackupDrProtectionSummarySettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListResourceBackupConfigs = clientHelper.BuildApiCall<ListResourceBackupConfigsRequest, ListResourceBackupConfigsResponse>("ListResourceBackupConfigs", grpcClient.ListResourceBackupConfigsAsync, grpcClient.ListResourceBackupConfigs, effectiveSettings.ListResourceBackupConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListResourceBackupConfigs);
            Modify_ListResourceBackupConfigsApiCall(ref _callListResourceBackupConfigs);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListResourceBackupConfigsApiCall(ref gaxgrpc::ApiCall<ListResourceBackupConfigsRequest, ListResourceBackupConfigsResponse> call);

        partial void OnConstruction(BackupDrProtectionSummary.BackupDrProtectionSummaryClient grpcClient, BackupDrProtectionSummarySettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC BackupDrProtectionSummary client</summary>
        public override BackupDrProtectionSummary.BackupDrProtectionSummaryClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListResourceBackupConfigsRequest(ref ListResourceBackupConfigsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists ResourceBackupConfigs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ResourceBackupConfig"/> resources.</returns>
        public override gax::PagedEnumerable<ListResourceBackupConfigsResponse, ResourceBackupConfig> ListResourceBackupConfigs(ListResourceBackupConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListResourceBackupConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListResourceBackupConfigsRequest, ListResourceBackupConfigsResponse, ResourceBackupConfig>(_callListResourceBackupConfigs, request, callSettings);
        }

        /// <summary>
        /// Lists ResourceBackupConfigs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ResourceBackupConfig"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListResourceBackupConfigsResponse, ResourceBackupConfig> ListResourceBackupConfigsAsync(ListResourceBackupConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListResourceBackupConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListResourceBackupConfigsRequest, ListResourceBackupConfigsResponse, ResourceBackupConfig>(_callListResourceBackupConfigs, request, callSettings);
        }
    }

    public partial class ListResourceBackupConfigsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListResourceBackupConfigsResponse : gaxgrpc::IPageResponse<ResourceBackupConfig>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ResourceBackupConfig> GetEnumerator() => ResourceBackupConfigs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class BackupDrProtectionSummary
    {
        public partial class BackupDrProtectionSummaryClient
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
