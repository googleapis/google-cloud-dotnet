// Copyright 2022 Google LLC
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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gagr = Google.Api.Gax.ResourceNames;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Gaming.V1Beta
{
    /// <summary>Settings for <see cref="RealmsServiceClient"/> instances.</summary>
    public sealed partial class RealmsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="RealmsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="RealmsServiceSettings"/>.</returns>
        public static RealmsServiceSettings GetDefault() => new RealmsServiceSettings();

        /// <summary>Constructs a new <see cref="RealmsServiceSettings"/> object with default settings.</summary>
        public RealmsServiceSettings()
        {
        }

        private RealmsServiceSettings(RealmsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListRealmsSettings = existing.ListRealmsSettings;
            GetRealmSettings = existing.GetRealmSettings;
            CreateRealmSettings = existing.CreateRealmSettings;
            CreateRealmOperationsSettings = existing.CreateRealmOperationsSettings.Clone();
            DeleteRealmSettings = existing.DeleteRealmSettings;
            DeleteRealmOperationsSettings = existing.DeleteRealmOperationsSettings.Clone();
            UpdateRealmSettings = existing.UpdateRealmSettings;
            UpdateRealmOperationsSettings = existing.UpdateRealmOperationsSettings.Clone();
            PreviewRealmUpdateSettings = existing.PreviewRealmUpdateSettings;
            OnCopy(existing);
        }

        partial void OnCopy(RealmsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RealmsServiceClient.ListRealms</c> and <c>RealmsServiceClient.ListRealmsAsync</c>.
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
        public gaxgrpc::CallSettings ListRealmsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RealmsServiceClient.GetRealm</c> and <c>RealmsServiceClient.GetRealmAsync</c>.
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
        public gaxgrpc::CallSettings GetRealmSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RealmsServiceClient.CreateRealm</c> and <c>RealmsServiceClient.CreateRealmAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateRealmSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RealmsServiceClient.CreateRealm</c> and
        /// <c>RealmsServiceClient.CreateRealmAsync</c>.
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
        public lro::OperationsSettings CreateRealmOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RealmsServiceClient.DeleteRealm</c> and <c>RealmsServiceClient.DeleteRealmAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteRealmSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RealmsServiceClient.DeleteRealm</c> and
        /// <c>RealmsServiceClient.DeleteRealmAsync</c>.
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
        public lro::OperationsSettings DeleteRealmOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RealmsServiceClient.UpdateRealm</c> and <c>RealmsServiceClient.UpdateRealmAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateRealmSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>RealmsServiceClient.UpdateRealm</c> and
        /// <c>RealmsServiceClient.UpdateRealmAsync</c>.
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
        public lro::OperationsSettings UpdateRealmOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RealmsServiceClient.PreviewRealmUpdate</c> and <c>RealmsServiceClient.PreviewRealmUpdateAsync</c>.
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
        public gaxgrpc::CallSettings PreviewRealmUpdateSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="RealmsServiceSettings"/> object.</returns>
        public RealmsServiceSettings Clone() => new RealmsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RealmsServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class RealmsServiceClientBuilder : gaxgrpc::ClientBuilderBase<RealmsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RealmsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public RealmsServiceClientBuilder() : base(RealmsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref RealmsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RealmsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override RealmsServiceClient Build()
        {
            RealmsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RealmsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RealmsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RealmsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RealmsServiceClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<RealmsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RealmsServiceClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => RealmsServiceClient.ChannelPool;
    }

    /// <summary>RealmsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A realm is a grouping of game server clusters that are considered
    /// interchangeable.
    /// </remarks>
    public abstract partial class RealmsServiceClient
    {
        /// <summary>
        /// The default endpoint for the RealmsService service, which is a host of "gameservices.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "gameservices.googleapis.com:443";

        /// <summary>The default RealmsService scopes.</summary>
        /// <remarks>
        /// The default RealmsService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        internal static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(RealmsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="RealmsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="RealmsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="RealmsServiceClient"/>.</returns>
        public static stt::Task<RealmsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RealmsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RealmsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="RealmsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="RealmsServiceClient"/>.</returns>
        public static RealmsServiceClient Create() => new RealmsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RealmsServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RealmsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="RealmsServiceClient"/>.</returns>
        internal static RealmsServiceClient Create(grpccore::CallInvoker callInvoker, RealmsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            RealmsService.RealmsServiceClient grpcClient = new RealmsService.RealmsServiceClient(callInvoker);
            return new RealmsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC RealmsService client</summary>
        public virtual RealmsService.RealmsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists realms in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Realm"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRealmsResponse, Realm> ListRealms(ListRealmsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists realms in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Realm"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRealmsResponse, Realm> ListRealmsAsync(ListRealmsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists realms in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name. Uses the form:
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
        /// <returns>A pageable sequence of <see cref="Realm"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRealmsResponse, Realm> ListRealms(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListRealms(new ListRealmsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists realms in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name. Uses the form:
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
        /// <returns>A pageable asynchronous sequence of <see cref="Realm"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRealmsResponse, Realm> ListRealmsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListRealmsAsync(new ListRealmsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists realms in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name. Uses the form:
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
        /// <returns>A pageable sequence of <see cref="Realm"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRealmsResponse, Realm> ListRealms(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListRealms(new ListRealmsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists realms in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name. Uses the form:
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
        /// <returns>A pageable asynchronous sequence of <see cref="Realm"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRealmsResponse, Realm> ListRealmsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListRealmsAsync(new ListRealmsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets details of a single realm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Realm GetRealm(GetRealmRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single realm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Realm> GetRealmAsync(GetRealmRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single realm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Realm> GetRealmAsync(GetRealmRequest request, st::CancellationToken cancellationToken) =>
            GetRealmAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single realm.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the realm to retrieve. Uses the form:
        /// `projects/{project}/locations/{location}/realms/{realm}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Realm GetRealm(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRealm(new GetRealmRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single realm.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the realm to retrieve. Uses the form:
        /// `projects/{project}/locations/{location}/realms/{realm}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Realm> GetRealmAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRealmAsync(new GetRealmRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single realm.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the realm to retrieve. Uses the form:
        /// `projects/{project}/locations/{location}/realms/{realm}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Realm> GetRealmAsync(string name, st::CancellationToken cancellationToken) =>
            GetRealmAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single realm.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the realm to retrieve. Uses the form:
        /// `projects/{project}/locations/{location}/realms/{realm}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Realm GetRealm(RealmName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRealm(new GetRealmRequest
            {
                RealmName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single realm.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the realm to retrieve. Uses the form:
        /// `projects/{project}/locations/{location}/realms/{realm}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Realm> GetRealmAsync(RealmName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRealmAsync(new GetRealmRequest
            {
                RealmName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single realm.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the realm to retrieve. Uses the form:
        /// `projects/{project}/locations/{location}/realms/{realm}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Realm> GetRealmAsync(RealmName name, st::CancellationToken cancellationToken) =>
            GetRealmAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new realm in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Realm, OperationMetadata> CreateRealm(CreateRealmRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new realm in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Realm, OperationMetadata>> CreateRealmAsync(CreateRealmRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new realm in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Realm, OperationMetadata>> CreateRealmAsync(CreateRealmRequest request, st::CancellationToken cancellationToken) =>
            CreateRealmAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateRealm</c>.</summary>
        public virtual lro::OperationsClient CreateRealmOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateRealm</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Realm, OperationMetadata> PollOnceCreateRealm(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Realm, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateRealmOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateRealm</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Realm, OperationMetadata>> PollOnceCreateRealmAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Realm, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateRealmOperationsClient, callSettings);

        /// <summary>
        /// Creates a new realm in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name. Uses the form:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="realm">
        /// Required. The realm resource to be created.
        /// </param>
        /// <param name="realmId">
        /// Required. The ID of the realm resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Realm, OperationMetadata> CreateRealm(string parent, Realm realm, string realmId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRealm(new CreateRealmRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RealmId = gax::GaxPreconditions.CheckNotNullOrEmpty(realmId, nameof(realmId)),
                Realm = gax::GaxPreconditions.CheckNotNull(realm, nameof(realm)),
            }, callSettings);

        /// <summary>
        /// Creates a new realm in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name. Uses the form:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="realm">
        /// Required. The realm resource to be created.
        /// </param>
        /// <param name="realmId">
        /// Required. The ID of the realm resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Realm, OperationMetadata>> CreateRealmAsync(string parent, Realm realm, string realmId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRealmAsync(new CreateRealmRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RealmId = gax::GaxPreconditions.CheckNotNullOrEmpty(realmId, nameof(realmId)),
                Realm = gax::GaxPreconditions.CheckNotNull(realm, nameof(realm)),
            }, callSettings);

        /// <summary>
        /// Creates a new realm in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name. Uses the form:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="realm">
        /// Required. The realm resource to be created.
        /// </param>
        /// <param name="realmId">
        /// Required. The ID of the realm resource to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Realm, OperationMetadata>> CreateRealmAsync(string parent, Realm realm, string realmId, st::CancellationToken cancellationToken) =>
            CreateRealmAsync(parent, realm, realmId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new realm in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name. Uses the form:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="realm">
        /// Required. The realm resource to be created.
        /// </param>
        /// <param name="realmId">
        /// Required. The ID of the realm resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Realm, OperationMetadata> CreateRealm(gagr::LocationName parent, Realm realm, string realmId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRealm(new CreateRealmRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RealmId = gax::GaxPreconditions.CheckNotNullOrEmpty(realmId, nameof(realmId)),
                Realm = gax::GaxPreconditions.CheckNotNull(realm, nameof(realm)),
            }, callSettings);

        /// <summary>
        /// Creates a new realm in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name. Uses the form:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="realm">
        /// Required. The realm resource to be created.
        /// </param>
        /// <param name="realmId">
        /// Required. The ID of the realm resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Realm, OperationMetadata>> CreateRealmAsync(gagr::LocationName parent, Realm realm, string realmId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRealmAsync(new CreateRealmRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RealmId = gax::GaxPreconditions.CheckNotNullOrEmpty(realmId, nameof(realmId)),
                Realm = gax::GaxPreconditions.CheckNotNull(realm, nameof(realm)),
            }, callSettings);

        /// <summary>
        /// Creates a new realm in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name. Uses the form:
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="realm">
        /// Required. The realm resource to be created.
        /// </param>
        /// <param name="realmId">
        /// Required. The ID of the realm resource to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Realm, OperationMetadata>> CreateRealmAsync(gagr::LocationName parent, Realm realm, string realmId, st::CancellationToken cancellationToken) =>
            CreateRealmAsync(parent, realm, realmId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single realm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteRealm(DeleteRealmRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single realm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRealmAsync(DeleteRealmRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single realm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRealmAsync(DeleteRealmRequest request, st::CancellationToken cancellationToken) =>
            DeleteRealmAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteRealm</c>.</summary>
        public virtual lro::OperationsClient DeleteRealmOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteRealm</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteRealm(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteRealmOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteRealm</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteRealmAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteRealmOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single realm.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the realm to delete. Uses the form:
        /// `projects/{project}/locations/{location}/realms/{realm}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteRealm(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRealm(new DeleteRealmRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single realm.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the realm to delete. Uses the form:
        /// `projects/{project}/locations/{location}/realms/{realm}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRealmAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRealmAsync(new DeleteRealmRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single realm.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the realm to delete. Uses the form:
        /// `projects/{project}/locations/{location}/realms/{realm}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRealmAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteRealmAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single realm.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the realm to delete. Uses the form:
        /// `projects/{project}/locations/{location}/realms/{realm}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteRealm(RealmName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRealm(new DeleteRealmRequest
            {
                RealmName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single realm.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the realm to delete. Uses the form:
        /// `projects/{project}/locations/{location}/realms/{realm}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRealmAsync(RealmName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRealmAsync(new DeleteRealmRequest
            {
                RealmName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single realm.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the realm to delete. Uses the form:
        /// `projects/{project}/locations/{location}/realms/{realm}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRealmAsync(RealmName name, st::CancellationToken cancellationToken) =>
            DeleteRealmAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Patches a single realm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Realm, OperationMetadata> UpdateRealm(UpdateRealmRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches a single realm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Realm, OperationMetadata>> UpdateRealmAsync(UpdateRealmRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches a single realm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Realm, OperationMetadata>> UpdateRealmAsync(UpdateRealmRequest request, st::CancellationToken cancellationToken) =>
            UpdateRealmAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateRealm</c>.</summary>
        public virtual lro::OperationsClient UpdateRealmOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateRealm</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Realm, OperationMetadata> PollOnceUpdateRealm(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Realm, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateRealmOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateRealm</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Realm, OperationMetadata>> PollOnceUpdateRealmAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Realm, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateRealmOperationsClient, callSettings);

        /// <summary>
        /// Patches a single realm.
        /// </summary>
        /// <param name="realm">
        /// Required. The realm to be updated.
        /// Only fields specified in update_mask are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource. For the `FieldMask`
        /// definition, see
        /// 
        /// https:
        /// //developers.google.com/protocol-buffers
        /// // /docs/reference/google.protobuf#fieldmask
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Realm, OperationMetadata> UpdateRealm(Realm realm, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRealm(new UpdateRealmRequest
            {
                Realm = gax::GaxPreconditions.CheckNotNull(realm, nameof(realm)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Patches a single realm.
        /// </summary>
        /// <param name="realm">
        /// Required. The realm to be updated.
        /// Only fields specified in update_mask are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource. For the `FieldMask`
        /// definition, see
        /// 
        /// https:
        /// //developers.google.com/protocol-buffers
        /// // /docs/reference/google.protobuf#fieldmask
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Realm, OperationMetadata>> UpdateRealmAsync(Realm realm, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRealmAsync(new UpdateRealmRequest
            {
                Realm = gax::GaxPreconditions.CheckNotNull(realm, nameof(realm)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Patches a single realm.
        /// </summary>
        /// <param name="realm">
        /// Required. The realm to be updated.
        /// Only fields specified in update_mask are updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource. For the `FieldMask`
        /// definition, see
        /// 
        /// https:
        /// //developers.google.com/protocol-buffers
        /// // /docs/reference/google.protobuf#fieldmask
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Realm, OperationMetadata>> UpdateRealmAsync(Realm realm, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateRealmAsync(realm, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Previews patches to a single realm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PreviewRealmUpdateResponse PreviewRealmUpdate(PreviewRealmUpdateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Previews patches to a single realm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PreviewRealmUpdateResponse> PreviewRealmUpdateAsync(PreviewRealmUpdateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Previews patches to a single realm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PreviewRealmUpdateResponse> PreviewRealmUpdateAsync(PreviewRealmUpdateRequest request, st::CancellationToken cancellationToken) =>
            PreviewRealmUpdateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>RealmsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A realm is a grouping of game server clusters that are considered
    /// interchangeable.
    /// </remarks>
    public sealed partial class RealmsServiceClientImpl : RealmsServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListRealmsRequest, ListRealmsResponse> _callListRealms;

        private readonly gaxgrpc::ApiCall<GetRealmRequest, Realm> _callGetRealm;

        private readonly gaxgrpc::ApiCall<CreateRealmRequest, lro::Operation> _callCreateRealm;

        private readonly gaxgrpc::ApiCall<DeleteRealmRequest, lro::Operation> _callDeleteRealm;

        private readonly gaxgrpc::ApiCall<UpdateRealmRequest, lro::Operation> _callUpdateRealm;

        private readonly gaxgrpc::ApiCall<PreviewRealmUpdateRequest, PreviewRealmUpdateResponse> _callPreviewRealmUpdate;

        /// <summary>
        /// Constructs a client wrapper for the RealmsService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="RealmsServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public RealmsServiceClientImpl(RealmsService.RealmsServiceClient grpcClient, RealmsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            RealmsServiceSettings effectiveSettings = settings ?? RealmsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            CreateRealmOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateRealmOperationsSettings, logger);
            DeleteRealmOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteRealmOperationsSettings, logger);
            UpdateRealmOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateRealmOperationsSettings, logger);
            _callListRealms = clientHelper.BuildApiCall<ListRealmsRequest, ListRealmsResponse>("ListRealms", grpcClient.ListRealmsAsync, grpcClient.ListRealms, effectiveSettings.ListRealmsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRealms);
            Modify_ListRealmsApiCall(ref _callListRealms);
            _callGetRealm = clientHelper.BuildApiCall<GetRealmRequest, Realm>("GetRealm", grpcClient.GetRealmAsync, grpcClient.GetRealm, effectiveSettings.GetRealmSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRealm);
            Modify_GetRealmApiCall(ref _callGetRealm);
            _callCreateRealm = clientHelper.BuildApiCall<CreateRealmRequest, lro::Operation>("CreateRealm", grpcClient.CreateRealmAsync, grpcClient.CreateRealm, effectiveSettings.CreateRealmSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateRealm);
            Modify_CreateRealmApiCall(ref _callCreateRealm);
            _callDeleteRealm = clientHelper.BuildApiCall<DeleteRealmRequest, lro::Operation>("DeleteRealm", grpcClient.DeleteRealmAsync, grpcClient.DeleteRealm, effectiveSettings.DeleteRealmSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteRealm);
            Modify_DeleteRealmApiCall(ref _callDeleteRealm);
            _callUpdateRealm = clientHelper.BuildApiCall<UpdateRealmRequest, lro::Operation>("UpdateRealm", grpcClient.UpdateRealmAsync, grpcClient.UpdateRealm, effectiveSettings.UpdateRealmSettings).WithGoogleRequestParam("realm.name", request => request.Realm?.Name);
            Modify_ApiCall(ref _callUpdateRealm);
            Modify_UpdateRealmApiCall(ref _callUpdateRealm);
            _callPreviewRealmUpdate = clientHelper.BuildApiCall<PreviewRealmUpdateRequest, PreviewRealmUpdateResponse>("PreviewRealmUpdate", grpcClient.PreviewRealmUpdateAsync, grpcClient.PreviewRealmUpdate, effectiveSettings.PreviewRealmUpdateSettings).WithGoogleRequestParam("realm.name", request => request.Realm?.Name);
            Modify_ApiCall(ref _callPreviewRealmUpdate);
            Modify_PreviewRealmUpdateApiCall(ref _callPreviewRealmUpdate);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListRealmsApiCall(ref gaxgrpc::ApiCall<ListRealmsRequest, ListRealmsResponse> call);

        partial void Modify_GetRealmApiCall(ref gaxgrpc::ApiCall<GetRealmRequest, Realm> call);

        partial void Modify_CreateRealmApiCall(ref gaxgrpc::ApiCall<CreateRealmRequest, lro::Operation> call);

        partial void Modify_DeleteRealmApiCall(ref gaxgrpc::ApiCall<DeleteRealmRequest, lro::Operation> call);

        partial void Modify_UpdateRealmApiCall(ref gaxgrpc::ApiCall<UpdateRealmRequest, lro::Operation> call);

        partial void Modify_PreviewRealmUpdateApiCall(ref gaxgrpc::ApiCall<PreviewRealmUpdateRequest, PreviewRealmUpdateResponse> call);

        partial void OnConstruction(RealmsService.RealmsServiceClient grpcClient, RealmsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC RealmsService client</summary>
        public override RealmsService.RealmsServiceClient GrpcClient { get; }

        partial void Modify_ListRealmsRequest(ref ListRealmsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRealmRequest(ref GetRealmRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateRealmRequest(ref CreateRealmRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteRealmRequest(ref DeleteRealmRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateRealmRequest(ref UpdateRealmRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PreviewRealmUpdateRequest(ref PreviewRealmUpdateRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists realms in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Realm"/> resources.</returns>
        public override gax::PagedEnumerable<ListRealmsResponse, Realm> ListRealms(ListRealmsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRealmsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRealmsRequest, ListRealmsResponse, Realm>(_callListRealms, request, callSettings);
        }

        /// <summary>
        /// Lists realms in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Realm"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRealmsResponse, Realm> ListRealmsAsync(ListRealmsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRealmsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRealmsRequest, ListRealmsResponse, Realm>(_callListRealms, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single realm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Realm GetRealm(GetRealmRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRealmRequest(ref request, ref callSettings);
            return _callGetRealm.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single realm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Realm> GetRealmAsync(GetRealmRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRealmRequest(ref request, ref callSettings);
            return _callGetRealm.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateRealm</c>.</summary>
        public override lro::OperationsClient CreateRealmOperationsClient { get; }

        /// <summary>
        /// Creates a new realm in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Realm, OperationMetadata> CreateRealm(CreateRealmRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRealmRequest(ref request, ref callSettings);
            return new lro::Operation<Realm, OperationMetadata>(_callCreateRealm.Sync(request, callSettings), CreateRealmOperationsClient);
        }

        /// <summary>
        /// Creates a new realm in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Realm, OperationMetadata>> CreateRealmAsync(CreateRealmRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRealmRequest(ref request, ref callSettings);
            return new lro::Operation<Realm, OperationMetadata>(await _callCreateRealm.Async(request, callSettings).ConfigureAwait(false), CreateRealmOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteRealm</c>.</summary>
        public override lro::OperationsClient DeleteRealmOperationsClient { get; }

        /// <summary>
        /// Deletes a single realm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteRealm(DeleteRealmRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRealmRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteRealm.Sync(request, callSettings), DeleteRealmOperationsClient);
        }

        /// <summary>
        /// Deletes a single realm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteRealmAsync(DeleteRealmRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRealmRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteRealm.Async(request, callSettings).ConfigureAwait(false), DeleteRealmOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateRealm</c>.</summary>
        public override lro::OperationsClient UpdateRealmOperationsClient { get; }

        /// <summary>
        /// Patches a single realm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Realm, OperationMetadata> UpdateRealm(UpdateRealmRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRealmRequest(ref request, ref callSettings);
            return new lro::Operation<Realm, OperationMetadata>(_callUpdateRealm.Sync(request, callSettings), UpdateRealmOperationsClient);
        }

        /// <summary>
        /// Patches a single realm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Realm, OperationMetadata>> UpdateRealmAsync(UpdateRealmRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRealmRequest(ref request, ref callSettings);
            return new lro::Operation<Realm, OperationMetadata>(await _callUpdateRealm.Async(request, callSettings).ConfigureAwait(false), UpdateRealmOperationsClient);
        }

        /// <summary>
        /// Previews patches to a single realm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PreviewRealmUpdateResponse PreviewRealmUpdate(PreviewRealmUpdateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PreviewRealmUpdateRequest(ref request, ref callSettings);
            return _callPreviewRealmUpdate.Sync(request, callSettings);
        }

        /// <summary>
        /// Previews patches to a single realm.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PreviewRealmUpdateResponse> PreviewRealmUpdateAsync(PreviewRealmUpdateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PreviewRealmUpdateRequest(ref request, ref callSettings);
            return _callPreviewRealmUpdate.Async(request, callSettings);
        }
    }

    public partial class ListRealmsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRealmsResponse : gaxgrpc::IPageResponse<Realm>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Realm> GetEnumerator() => Realms.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class RealmsService
    {
        public partial class RealmsServiceClient
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
}
