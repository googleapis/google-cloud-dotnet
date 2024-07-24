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

namespace Google.Cloud.BackupDR.V1
{
    /// <summary>Settings for <see cref="BackupDRClient"/> instances.</summary>
    public sealed partial class BackupDRSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BackupDRSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BackupDRSettings"/>.</returns>
        public static BackupDRSettings GetDefault() => new BackupDRSettings();

        /// <summary>Constructs a new <see cref="BackupDRSettings"/> object with default settings.</summary>
        public BackupDRSettings()
        {
        }

        private BackupDRSettings(BackupDRSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListManagementServersSettings = existing.ListManagementServersSettings;
            GetManagementServerSettings = existing.GetManagementServerSettings;
            CreateManagementServerSettings = existing.CreateManagementServerSettings;
            CreateManagementServerOperationsSettings = existing.CreateManagementServerOperationsSettings.Clone();
            DeleteManagementServerSettings = existing.DeleteManagementServerSettings;
            DeleteManagementServerOperationsSettings = existing.DeleteManagementServerOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(BackupDRSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupDRClient.ListManagementServers</c> and <c>BackupDRClient.ListManagementServersAsync</c>.
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
        public gaxgrpc::CallSettings ListManagementServersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupDRClient.GetManagementServer</c> and <c>BackupDRClient.GetManagementServerAsync</c>.
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
        public gaxgrpc::CallSettings GetManagementServerSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupDRClient.CreateManagementServer</c> and <c>BackupDRClient.CreateManagementServerAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateManagementServerSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BackupDRClient.CreateManagementServer</c> and
        /// <c>BackupDRClient.CreateManagementServerAsync</c>.
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
        public lro::OperationsSettings CreateManagementServerOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BackupDRClient.DeleteManagementServer</c> and <c>BackupDRClient.DeleteManagementServerAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteManagementServerSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BackupDRClient.DeleteManagementServer</c> and
        /// <c>BackupDRClient.DeleteManagementServerAsync</c>.
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
        public lro::OperationsSettings DeleteManagementServerOperationsSettings { get; set; } = new lro::OperationsSettings
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
        /// <returns>A deep clone of this <see cref="BackupDRSettings"/> object.</returns>
        public BackupDRSettings Clone() => new BackupDRSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BackupDRClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class BackupDRClientBuilder : gaxgrpc::ClientBuilderBase<BackupDRClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BackupDRSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public BackupDRClientBuilder() : base(BackupDRClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref BackupDRClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<BackupDRClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override BackupDRClient Build()
        {
            BackupDRClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<BackupDRClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<BackupDRClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private BackupDRClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BackupDRClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<BackupDRClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BackupDRClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BackupDRClient.ChannelPool;
    }

    /// <summary>BackupDR client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The BackupDR Service
    /// </remarks>
    public abstract partial class BackupDRClient
    {
        /// <summary>
        /// The default endpoint for the BackupDR service, which is a host of "backupdr.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "backupdr.googleapis.com:443";

        /// <summary>The default BackupDR scopes.</summary>
        /// <remarks>
        /// The default BackupDR scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(BackupDR.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="BackupDRClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="BackupDRClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="BackupDRClient"/>.</returns>
        public static stt::Task<BackupDRClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new BackupDRClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="BackupDRClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="BackupDRClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="BackupDRClient"/>.</returns>
        public static BackupDRClient Create() => new BackupDRClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="BackupDRClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BackupDRSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="BackupDRClient"/>.</returns>
        internal static BackupDRClient Create(grpccore::CallInvoker callInvoker, BackupDRSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BackupDR.BackupDRClient grpcClient = new BackupDR.BackupDRClient(callInvoker);
            return new BackupDRClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC BackupDR client</summary>
        public virtual BackupDR.BackupDRClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ManagementServers in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ManagementServer"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListManagementServersResponse, ManagementServer> ListManagementServers(ListManagementServersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ManagementServers in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ManagementServer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListManagementServersResponse, ManagementServer> ListManagementServersAsync(ListManagementServersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ManagementServers in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location for which to retrieve management servers
        /// information, in the format `projects/{project_id}/locations/{location}`. In
        /// Cloud BackupDR, locations map to GCP regions, for example **us-central1**.
        /// To retrieve management servers for all locations, use "-" for the
        /// `{location}` value.
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
        /// <returns>A pageable sequence of <see cref="ManagementServer"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListManagementServersResponse, ManagementServer> ListManagementServers(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListManagementServersRequest request = new ListManagementServersRequest
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
            return ListManagementServers(request, callSettings);
        }

        /// <summary>
        /// Lists ManagementServers in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location for which to retrieve management servers
        /// information, in the format `projects/{project_id}/locations/{location}`. In
        /// Cloud BackupDR, locations map to GCP regions, for example **us-central1**.
        /// To retrieve management servers for all locations, use "-" for the
        /// `{location}` value.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ManagementServer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListManagementServersResponse, ManagementServer> ListManagementServersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListManagementServersRequest request = new ListManagementServersRequest
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
            return ListManagementServersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists ManagementServers in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location for which to retrieve management servers
        /// information, in the format `projects/{project_id}/locations/{location}`. In
        /// Cloud BackupDR, locations map to GCP regions, for example **us-central1**.
        /// To retrieve management servers for all locations, use "-" for the
        /// `{location}` value.
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
        /// <returns>A pageable sequence of <see cref="ManagementServer"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListManagementServersResponse, ManagementServer> ListManagementServers(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListManagementServersRequest request = new ListManagementServersRequest
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
            return ListManagementServers(request, callSettings);
        }

        /// <summary>
        /// Lists ManagementServers in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location for which to retrieve management servers
        /// information, in the format `projects/{project_id}/locations/{location}`. In
        /// Cloud BackupDR, locations map to GCP regions, for example **us-central1**.
        /// To retrieve management servers for all locations, use "-" for the
        /// `{location}` value.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ManagementServer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListManagementServersResponse, ManagementServer> ListManagementServersAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListManagementServersRequest request = new ListManagementServersRequest
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
            return ListManagementServersAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ManagementServer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ManagementServer GetManagementServer(GetManagementServerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ManagementServer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagementServer> GetManagementServerAsync(GetManagementServerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ManagementServer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagementServer> GetManagementServerAsync(GetManagementServerRequest request, st::CancellationToken cancellationToken) =>
            GetManagementServerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ManagementServer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the management server resource name, in the format
        /// `projects/{project_id}/locations/{location}/managementServers/{resource_name}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ManagementServer GetManagementServer(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetManagementServer(new GetManagementServerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ManagementServer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the management server resource name, in the format
        /// `projects/{project_id}/locations/{location}/managementServers/{resource_name}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagementServer> GetManagementServerAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetManagementServerAsync(new GetManagementServerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ManagementServer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the management server resource name, in the format
        /// `projects/{project_id}/locations/{location}/managementServers/{resource_name}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagementServer> GetManagementServerAsync(string name, st::CancellationToken cancellationToken) =>
            GetManagementServerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ManagementServer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the management server resource name, in the format
        /// `projects/{project_id}/locations/{location}/managementServers/{resource_name}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ManagementServer GetManagementServer(ManagementServerName name, gaxgrpc::CallSettings callSettings = null) =>
            GetManagementServer(new GetManagementServerRequest
            {
                ManagementServerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ManagementServer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the management server resource name, in the format
        /// `projects/{project_id}/locations/{location}/managementServers/{resource_name}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagementServer> GetManagementServerAsync(ManagementServerName name, gaxgrpc::CallSettings callSettings = null) =>
            GetManagementServerAsync(new GetManagementServerRequest
            {
                ManagementServerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ManagementServer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the management server resource name, in the format
        /// `projects/{project_id}/locations/{location}/managementServers/{resource_name}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManagementServer> GetManagementServerAsync(ManagementServerName name, st::CancellationToken cancellationToken) =>
            GetManagementServerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ManagementServer in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ManagementServer, OperationMetadata> CreateManagementServer(CreateManagementServerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ManagementServer in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ManagementServer, OperationMetadata>> CreateManagementServerAsync(CreateManagementServerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ManagementServer in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ManagementServer, OperationMetadata>> CreateManagementServerAsync(CreateManagementServerRequest request, st::CancellationToken cancellationToken) =>
            CreateManagementServerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateManagementServer</c>.</summary>
        public virtual lro::OperationsClient CreateManagementServerOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateManagementServer</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ManagementServer, OperationMetadata> PollOnceCreateManagementServer(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ManagementServer, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateManagementServerOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateManagementServer</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ManagementServer, OperationMetadata>> PollOnceCreateManagementServerAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ManagementServer, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateManagementServerOperationsClient, callSettings);

        /// <summary>
        /// Creates a new ManagementServer in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The management server project and location in the format
        /// `projects/{project_id}/locations/{location}`. In Cloud Backup and DR
        /// locations map to GCP regions, for example **us-central1**.
        /// </param>
        /// <param name="managementServer">
        /// Required. A [management server
        /// resource][google.cloud.backupdr.v1.ManagementServer]
        /// </param>
        /// <param name="managementServerId">
        /// Required. The name of the management server to create. The name must be
        /// unique for the specified project and location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ManagementServer, OperationMetadata> CreateManagementServer(string parent, ManagementServer managementServer, string managementServerId, gaxgrpc::CallSettings callSettings = null) =>
            CreateManagementServer(new CreateManagementServerRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ManagementServerId = gax::GaxPreconditions.CheckNotNullOrEmpty(managementServerId, nameof(managementServerId)),
                ManagementServer = gax::GaxPreconditions.CheckNotNull(managementServer, nameof(managementServer)),
            }, callSettings);

        /// <summary>
        /// Creates a new ManagementServer in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The management server project and location in the format
        /// `projects/{project_id}/locations/{location}`. In Cloud Backup and DR
        /// locations map to GCP regions, for example **us-central1**.
        /// </param>
        /// <param name="managementServer">
        /// Required. A [management server
        /// resource][google.cloud.backupdr.v1.ManagementServer]
        /// </param>
        /// <param name="managementServerId">
        /// Required. The name of the management server to create. The name must be
        /// unique for the specified project and location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ManagementServer, OperationMetadata>> CreateManagementServerAsync(string parent, ManagementServer managementServer, string managementServerId, gaxgrpc::CallSettings callSettings = null) =>
            CreateManagementServerAsync(new CreateManagementServerRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ManagementServerId = gax::GaxPreconditions.CheckNotNullOrEmpty(managementServerId, nameof(managementServerId)),
                ManagementServer = gax::GaxPreconditions.CheckNotNull(managementServer, nameof(managementServer)),
            }, callSettings);

        /// <summary>
        /// Creates a new ManagementServer in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The management server project and location in the format
        /// `projects/{project_id}/locations/{location}`. In Cloud Backup and DR
        /// locations map to GCP regions, for example **us-central1**.
        /// </param>
        /// <param name="managementServer">
        /// Required. A [management server
        /// resource][google.cloud.backupdr.v1.ManagementServer]
        /// </param>
        /// <param name="managementServerId">
        /// Required. The name of the management server to create. The name must be
        /// unique for the specified project and location.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ManagementServer, OperationMetadata>> CreateManagementServerAsync(string parent, ManagementServer managementServer, string managementServerId, st::CancellationToken cancellationToken) =>
            CreateManagementServerAsync(parent, managementServer, managementServerId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ManagementServer in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The management server project and location in the format
        /// `projects/{project_id}/locations/{location}`. In Cloud Backup and DR
        /// locations map to GCP regions, for example **us-central1**.
        /// </param>
        /// <param name="managementServer">
        /// Required. A [management server
        /// resource][google.cloud.backupdr.v1.ManagementServer]
        /// </param>
        /// <param name="managementServerId">
        /// Required. The name of the management server to create. The name must be
        /// unique for the specified project and location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ManagementServer, OperationMetadata> CreateManagementServer(gagr::LocationName parent, ManagementServer managementServer, string managementServerId, gaxgrpc::CallSettings callSettings = null) =>
            CreateManagementServer(new CreateManagementServerRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ManagementServerId = gax::GaxPreconditions.CheckNotNullOrEmpty(managementServerId, nameof(managementServerId)),
                ManagementServer = gax::GaxPreconditions.CheckNotNull(managementServer, nameof(managementServer)),
            }, callSettings);

        /// <summary>
        /// Creates a new ManagementServer in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The management server project and location in the format
        /// `projects/{project_id}/locations/{location}`. In Cloud Backup and DR
        /// locations map to GCP regions, for example **us-central1**.
        /// </param>
        /// <param name="managementServer">
        /// Required. A [management server
        /// resource][google.cloud.backupdr.v1.ManagementServer]
        /// </param>
        /// <param name="managementServerId">
        /// Required. The name of the management server to create. The name must be
        /// unique for the specified project and location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ManagementServer, OperationMetadata>> CreateManagementServerAsync(gagr::LocationName parent, ManagementServer managementServer, string managementServerId, gaxgrpc::CallSettings callSettings = null) =>
            CreateManagementServerAsync(new CreateManagementServerRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ManagementServerId = gax::GaxPreconditions.CheckNotNullOrEmpty(managementServerId, nameof(managementServerId)),
                ManagementServer = gax::GaxPreconditions.CheckNotNull(managementServer, nameof(managementServer)),
            }, callSettings);

        /// <summary>
        /// Creates a new ManagementServer in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The management server project and location in the format
        /// `projects/{project_id}/locations/{location}`. In Cloud Backup and DR
        /// locations map to GCP regions, for example **us-central1**.
        /// </param>
        /// <param name="managementServer">
        /// Required. A [management server
        /// resource][google.cloud.backupdr.v1.ManagementServer]
        /// </param>
        /// <param name="managementServerId">
        /// Required. The name of the management server to create. The name must be
        /// unique for the specified project and location.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ManagementServer, OperationMetadata>> CreateManagementServerAsync(gagr::LocationName parent, ManagementServer managementServer, string managementServerId, st::CancellationToken cancellationToken) =>
            CreateManagementServerAsync(parent, managementServer, managementServerId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ManagementServer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteManagementServer(DeleteManagementServerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ManagementServer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteManagementServerAsync(DeleteManagementServerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ManagementServer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteManagementServerAsync(DeleteManagementServerRequest request, st::CancellationToken cancellationToken) =>
            DeleteManagementServerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteManagementServer</c>.</summary>
        public virtual lro::OperationsClient DeleteManagementServerOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteManagementServer</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteManagementServer(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteManagementServerOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteManagementServer</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteManagementServerAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteManagementServerOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single ManagementServer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteManagementServer(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteManagementServer(new DeleteManagementServerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ManagementServer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteManagementServerAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteManagementServerAsync(new DeleteManagementServerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ManagementServer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteManagementServerAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteManagementServerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ManagementServer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteManagementServer(ManagementServerName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteManagementServer(new DeleteManagementServerRequest
            {
                ManagementServerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ManagementServer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteManagementServerAsync(ManagementServerName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteManagementServerAsync(new DeleteManagementServerRequest
            {
                ManagementServerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ManagementServer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteManagementServerAsync(ManagementServerName name, st::CancellationToken cancellationToken) =>
            DeleteManagementServerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>BackupDR client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The BackupDR Service
    /// </remarks>
    public sealed partial class BackupDRClientImpl : BackupDRClient
    {
        private readonly gaxgrpc::ApiCall<ListManagementServersRequest, ListManagementServersResponse> _callListManagementServers;

        private readonly gaxgrpc::ApiCall<GetManagementServerRequest, ManagementServer> _callGetManagementServer;

        private readonly gaxgrpc::ApiCall<CreateManagementServerRequest, lro::Operation> _callCreateManagementServer;

        private readonly gaxgrpc::ApiCall<DeleteManagementServerRequest, lro::Operation> _callDeleteManagementServer;

        /// <summary>
        /// Constructs a client wrapper for the BackupDR service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="BackupDRSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public BackupDRClientImpl(BackupDR.BackupDRClient grpcClient, BackupDRSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            BackupDRSettings effectiveSettings = settings ?? BackupDRSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateManagementServerOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateManagementServerOperationsSettings, logger);
            DeleteManagementServerOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteManagementServerOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListManagementServers = clientHelper.BuildApiCall<ListManagementServersRequest, ListManagementServersResponse>("ListManagementServers", grpcClient.ListManagementServersAsync, grpcClient.ListManagementServers, effectiveSettings.ListManagementServersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListManagementServers);
            Modify_ListManagementServersApiCall(ref _callListManagementServers);
            _callGetManagementServer = clientHelper.BuildApiCall<GetManagementServerRequest, ManagementServer>("GetManagementServer", grpcClient.GetManagementServerAsync, grpcClient.GetManagementServer, effectiveSettings.GetManagementServerSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetManagementServer);
            Modify_GetManagementServerApiCall(ref _callGetManagementServer);
            _callCreateManagementServer = clientHelper.BuildApiCall<CreateManagementServerRequest, lro::Operation>("CreateManagementServer", grpcClient.CreateManagementServerAsync, grpcClient.CreateManagementServer, effectiveSettings.CreateManagementServerSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateManagementServer);
            Modify_CreateManagementServerApiCall(ref _callCreateManagementServer);
            _callDeleteManagementServer = clientHelper.BuildApiCall<DeleteManagementServerRequest, lro::Operation>("DeleteManagementServer", grpcClient.DeleteManagementServerAsync, grpcClient.DeleteManagementServer, effectiveSettings.DeleteManagementServerSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteManagementServer);
            Modify_DeleteManagementServerApiCall(ref _callDeleteManagementServer);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListManagementServersApiCall(ref gaxgrpc::ApiCall<ListManagementServersRequest, ListManagementServersResponse> call);

        partial void Modify_GetManagementServerApiCall(ref gaxgrpc::ApiCall<GetManagementServerRequest, ManagementServer> call);

        partial void Modify_CreateManagementServerApiCall(ref gaxgrpc::ApiCall<CreateManagementServerRequest, lro::Operation> call);

        partial void Modify_DeleteManagementServerApiCall(ref gaxgrpc::ApiCall<DeleteManagementServerRequest, lro::Operation> call);

        partial void OnConstruction(BackupDR.BackupDRClient grpcClient, BackupDRSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC BackupDR client</summary>
        public override BackupDR.BackupDRClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListManagementServersRequest(ref ListManagementServersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetManagementServerRequest(ref GetManagementServerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateManagementServerRequest(ref CreateManagementServerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteManagementServerRequest(ref DeleteManagementServerRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists ManagementServers in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ManagementServer"/> resources.</returns>
        public override gax::PagedEnumerable<ListManagementServersResponse, ManagementServer> ListManagementServers(ListManagementServersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListManagementServersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListManagementServersRequest, ListManagementServersResponse, ManagementServer>(_callListManagementServers, request, callSettings);
        }

        /// <summary>
        /// Lists ManagementServers in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ManagementServer"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListManagementServersResponse, ManagementServer> ListManagementServersAsync(ListManagementServersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListManagementServersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListManagementServersRequest, ListManagementServersResponse, ManagementServer>(_callListManagementServers, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ManagementServer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ManagementServer GetManagementServer(GetManagementServerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetManagementServerRequest(ref request, ref callSettings);
            return _callGetManagementServer.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ManagementServer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ManagementServer> GetManagementServerAsync(GetManagementServerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetManagementServerRequest(ref request, ref callSettings);
            return _callGetManagementServer.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateManagementServer</c>.</summary>
        public override lro::OperationsClient CreateManagementServerOperationsClient { get; }

        /// <summary>
        /// Creates a new ManagementServer in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ManagementServer, OperationMetadata> CreateManagementServer(CreateManagementServerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateManagementServerRequest(ref request, ref callSettings);
            return new lro::Operation<ManagementServer, OperationMetadata>(_callCreateManagementServer.Sync(request, callSettings), CreateManagementServerOperationsClient);
        }

        /// <summary>
        /// Creates a new ManagementServer in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ManagementServer, OperationMetadata>> CreateManagementServerAsync(CreateManagementServerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateManagementServerRequest(ref request, ref callSettings);
            return new lro::Operation<ManagementServer, OperationMetadata>(await _callCreateManagementServer.Async(request, callSettings).ConfigureAwait(false), CreateManagementServerOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteManagementServer</c>.</summary>
        public override lro::OperationsClient DeleteManagementServerOperationsClient { get; }

        /// <summary>
        /// Deletes a single ManagementServer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteManagementServer(DeleteManagementServerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteManagementServerRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteManagementServer.Sync(request, callSettings), DeleteManagementServerOperationsClient);
        }

        /// <summary>
        /// Deletes a single ManagementServer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteManagementServerAsync(DeleteManagementServerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteManagementServerRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteManagementServer.Async(request, callSettings).ConfigureAwait(false), DeleteManagementServerOperationsClient);
        }
    }

    public partial class ListManagementServersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListManagementServersResponse : gaxgrpc::IPageResponse<ManagementServer>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ManagementServer> GetEnumerator() => ManagementServers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class BackupDR
    {
        public partial class BackupDRClient
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

    public static partial class BackupDR
    {
        public partial class BackupDRClient
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
