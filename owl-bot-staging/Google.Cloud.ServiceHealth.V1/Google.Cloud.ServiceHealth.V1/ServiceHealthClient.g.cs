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

namespace Google.Cloud.ServiceHealth.V1
{
    /// <summary>Settings for <see cref="ServiceHealthClient"/> instances.</summary>
    public sealed partial class ServiceHealthSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ServiceHealthSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ServiceHealthSettings"/>.</returns>
        public static ServiceHealthSettings GetDefault() => new ServiceHealthSettings();

        /// <summary>Constructs a new <see cref="ServiceHealthSettings"/> object with default settings.</summary>
        public ServiceHealthSettings()
        {
        }

        private ServiceHealthSettings(ServiceHealthSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListEventsSettings = existing.ListEventsSettings;
            GetEventSettings = existing.GetEventSettings;
            ListOrganizationEventsSettings = existing.ListOrganizationEventsSettings;
            GetOrganizationEventSettings = existing.GetOrganizationEventSettings;
            ListOrganizationImpactsSettings = existing.ListOrganizationImpactsSettings;
            GetOrganizationImpactSettings = existing.GetOrganizationImpactSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ServiceHealthSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceHealthClient.ListEvents</c> and <c>ServiceHealthClient.ListEventsAsync</c>.
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
        public gaxgrpc::CallSettings ListEventsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceHealthClient.GetEvent</c> and <c>ServiceHealthClient.GetEventAsync</c>.
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
        public gaxgrpc::CallSettings GetEventSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceHealthClient.ListOrganizationEvents</c> and <c>ServiceHealthClient.ListOrganizationEventsAsync</c>
        /// .
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
        public gaxgrpc::CallSettings ListOrganizationEventsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceHealthClient.GetOrganizationEvent</c> and <c>ServiceHealthClient.GetOrganizationEventAsync</c>.
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
        public gaxgrpc::CallSettings GetOrganizationEventSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceHealthClient.ListOrganizationImpacts</c> and <c>ServiceHealthClient.ListOrganizationImpactsAsync</c>
        /// .
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
        public gaxgrpc::CallSettings ListOrganizationImpactsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceHealthClient.GetOrganizationImpact</c> and <c>ServiceHealthClient.GetOrganizationImpactAsync</c>.
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
        public gaxgrpc::CallSettings GetOrganizationImpactSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ServiceHealthSettings"/> object.</returns>
        public ServiceHealthSettings Clone() => new ServiceHealthSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ServiceHealthClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ServiceHealthClientBuilder : gaxgrpc::ClientBuilderBase<ServiceHealthClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ServiceHealthSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ServiceHealthClientBuilder() : base(ServiceHealthClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ServiceHealthClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ServiceHealthClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ServiceHealthClient Build()
        {
            ServiceHealthClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ServiceHealthClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ServiceHealthClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ServiceHealthClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ServiceHealthClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ServiceHealthClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ServiceHealthClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ServiceHealthClient.ChannelPool;
    }

    /// <summary>ServiceHealth client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Request service health events relevant to your Google Cloud project.
    /// </remarks>
    public abstract partial class ServiceHealthClient
    {
        /// <summary>
        /// The default endpoint for the ServiceHealth service, which is a host of "servicehealth.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "servicehealth.googleapis.com:443";

        /// <summary>The default ServiceHealth scopes.</summary>
        /// <remarks>
        /// The default ServiceHealth scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ServiceHealth.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ServiceHealthClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ServiceHealthClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ServiceHealthClient"/>.</returns>
        public static stt::Task<ServiceHealthClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ServiceHealthClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ServiceHealthClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ServiceHealthClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ServiceHealthClient"/>.</returns>
        public static ServiceHealthClient Create() => new ServiceHealthClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ServiceHealthClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ServiceHealthSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ServiceHealthClient"/>.</returns>
        internal static ServiceHealthClient Create(grpccore::CallInvoker callInvoker, ServiceHealthSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ServiceHealth.ServiceHealthClient grpcClient = new ServiceHealth.ServiceHealthClient(callInvoker);
            return new ServiceHealthClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ServiceHealth client</summary>
        public virtual ServiceHealth.ServiceHealthClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists events under a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Event"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEventsResponse, Event> ListEvents(ListEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists events under a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Event"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEventsResponse, Event> ListEventsAsync(ListEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists events under a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value using the form
        /// `projects/{project_id}/locations/{location}/events`.
        /// 
        /// `project_id` - ID of the project for which to list service health
        /// events.
        /// `location` - The location to get the service health events from.
        /// To retrieve service health events of category = INCIDENT, use `location` =
        /// `global`.
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
        /// <returns>A pageable sequence of <see cref="Event"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEventsResponse, Event> ListEvents(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEventsRequest request = new ListEventsRequest
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
            return ListEvents(request, callSettings);
        }

        /// <summary>
        /// Lists events under a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value using the form
        /// `projects/{project_id}/locations/{location}/events`.
        /// 
        /// `project_id` - ID of the project for which to list service health
        /// events.
        /// `location` - The location to get the service health events from.
        /// To retrieve service health events of category = INCIDENT, use `location` =
        /// `global`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Event"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEventsResponse, Event> ListEventsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEventsRequest request = new ListEventsRequest
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
            return ListEventsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists events under a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value using the form
        /// `projects/{project_id}/locations/{location}/events`.
        /// 
        /// `project_id` - ID of the project for which to list service health
        /// events.
        /// `location` - The location to get the service health events from.
        /// To retrieve service health events of category = INCIDENT, use `location` =
        /// `global`.
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
        /// <returns>A pageable sequence of <see cref="Event"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEventsResponse, Event> ListEvents(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEventsRequest request = new ListEventsRequest
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
            return ListEvents(request, callSettings);
        }

        /// <summary>
        /// Lists events under a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value using the form
        /// `projects/{project_id}/locations/{location}/events`.
        /// 
        /// `project_id` - ID of the project for which to list service health
        /// events.
        /// `location` - The location to get the service health events from.
        /// To retrieve service health events of category = INCIDENT, use `location` =
        /// `global`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Event"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEventsResponse, Event> ListEventsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEventsRequest request = new ListEventsRequest
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
            return ListEventsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a resource containing information about an event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Event GetEvent(GetEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a resource containing information about an event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Event> GetEventAsync(GetEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a resource containing information about an event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Event> GetEventAsync(GetEventRequest request, st::CancellationToken cancellationToken) =>
            GetEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a resource containing information about an event.
        /// </summary>
        /// <param name="name">
        /// Required. Unique name of the event in this scope including project
        /// and location using the form
        /// `projects/{project_id}/locations/{location}/events/{event_id}`.
        /// 
        /// `project_id` - Project ID of the project that contains the event. &lt;br&gt;
        /// `location` - The location to get the service health events from. &lt;br&gt;
        /// `event_id` - Event ID to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Event GetEvent(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvent(new GetEventRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a resource containing information about an event.
        /// </summary>
        /// <param name="name">
        /// Required. Unique name of the event in this scope including project
        /// and location using the form
        /// `projects/{project_id}/locations/{location}/events/{event_id}`.
        /// 
        /// `project_id` - Project ID of the project that contains the event. &lt;br&gt;
        /// `location` - The location to get the service health events from. &lt;br&gt;
        /// `event_id` - Event ID to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Event> GetEventAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEventAsync(new GetEventRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a resource containing information about an event.
        /// </summary>
        /// <param name="name">
        /// Required. Unique name of the event in this scope including project
        /// and location using the form
        /// `projects/{project_id}/locations/{location}/events/{event_id}`.
        /// 
        /// `project_id` - Project ID of the project that contains the event. &lt;br&gt;
        /// `location` - The location to get the service health events from. &lt;br&gt;
        /// `event_id` - Event ID to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Event> GetEventAsync(string name, st::CancellationToken cancellationToken) =>
            GetEventAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a resource containing information about an event.
        /// </summary>
        /// <param name="name">
        /// Required. Unique name of the event in this scope including project
        /// and location using the form
        /// `projects/{project_id}/locations/{location}/events/{event_id}`.
        /// 
        /// `project_id` - Project ID of the project that contains the event. &lt;br&gt;
        /// `location` - The location to get the service health events from. &lt;br&gt;
        /// `event_id` - Event ID to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Event GetEvent(EventName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvent(new GetEventRequest
            {
                EventName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a resource containing information about an event.
        /// </summary>
        /// <param name="name">
        /// Required. Unique name of the event in this scope including project
        /// and location using the form
        /// `projects/{project_id}/locations/{location}/events/{event_id}`.
        /// 
        /// `project_id` - Project ID of the project that contains the event. &lt;br&gt;
        /// `location` - The location to get the service health events from. &lt;br&gt;
        /// `event_id` - Event ID to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Event> GetEventAsync(EventName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEventAsync(new GetEventRequest
            {
                EventName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a resource containing information about an event.
        /// </summary>
        /// <param name="name">
        /// Required. Unique name of the event in this scope including project
        /// and location using the form
        /// `projects/{project_id}/locations/{location}/events/{event_id}`.
        /// 
        /// `project_id` - Project ID of the project that contains the event. &lt;br&gt;
        /// `location` - The location to get the service health events from. &lt;br&gt;
        /// `event_id` - Event ID to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Event> GetEventAsync(EventName name, st::CancellationToken cancellationToken) =>
            GetEventAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists organization events under a given organization and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="OrganizationEvent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOrganizationEventsResponse, OrganizationEvent> ListOrganizationEvents(ListOrganizationEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists organization events under a given organization and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="OrganizationEvent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOrganizationEventsResponse, OrganizationEvent> ListOrganizationEventsAsync(ListOrganizationEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists organization events under a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value using the form
        /// `organizations/{organization_id}/locations/{location}/organizationEvents`.
        /// 
        /// `organization_id` - ID (number) of the project that contains the event. To
        /// get your `organization_id`, see
        /// [Getting your organization resource
        /// ID](https://cloud.google.com/resource-manager/docs/creating-managing-organization#retrieving_your_organization_id).&lt;br&gt;
        /// `location` - The location to get the service health events from. To
        /// retrieve service health events of category = INCIDENT, use `location` =
        /// `global`.
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
        /// <returns>A pageable sequence of <see cref="OrganizationEvent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOrganizationEventsResponse, OrganizationEvent> ListOrganizationEvents(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOrganizationEventsRequest request = new ListOrganizationEventsRequest
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
            return ListOrganizationEvents(request, callSettings);
        }

        /// <summary>
        /// Lists organization events under a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value using the form
        /// `organizations/{organization_id}/locations/{location}/organizationEvents`.
        /// 
        /// `organization_id` - ID (number) of the project that contains the event. To
        /// get your `organization_id`, see
        /// [Getting your organization resource
        /// ID](https://cloud.google.com/resource-manager/docs/creating-managing-organization#retrieving_your_organization_id).&lt;br&gt;
        /// `location` - The location to get the service health events from. To
        /// retrieve service health events of category = INCIDENT, use `location` =
        /// `global`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="OrganizationEvent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOrganizationEventsResponse, OrganizationEvent> ListOrganizationEventsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOrganizationEventsRequest request = new ListOrganizationEventsRequest
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
            return ListOrganizationEventsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists organization events under a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value using the form
        /// `organizations/{organization_id}/locations/{location}/organizationEvents`.
        /// 
        /// `organization_id` - ID (number) of the project that contains the event. To
        /// get your `organization_id`, see
        /// [Getting your organization resource
        /// ID](https://cloud.google.com/resource-manager/docs/creating-managing-organization#retrieving_your_organization_id).&lt;br&gt;
        /// `location` - The location to get the service health events from. To
        /// retrieve service health events of category = INCIDENT, use `location` =
        /// `global`.
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
        /// <returns>A pageable sequence of <see cref="OrganizationEvent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOrganizationEventsResponse, OrganizationEvent> ListOrganizationEvents(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOrganizationEventsRequest request = new ListOrganizationEventsRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListOrganizationEvents(request, callSettings);
        }

        /// <summary>
        /// Lists organization events under a given organization and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value using the form
        /// `organizations/{organization_id}/locations/{location}/organizationEvents`.
        /// 
        /// `organization_id` - ID (number) of the project that contains the event. To
        /// get your `organization_id`, see
        /// [Getting your organization resource
        /// ID](https://cloud.google.com/resource-manager/docs/creating-managing-organization#retrieving_your_organization_id).&lt;br&gt;
        /// `location` - The location to get the service health events from. To
        /// retrieve service health events of category = INCIDENT, use `location` =
        /// `global`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="OrganizationEvent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOrganizationEventsResponse, OrganizationEvent> ListOrganizationEventsAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOrganizationEventsRequest request = new ListOrganizationEventsRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListOrganizationEventsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a resource containing information about an event affecting an
        /// organization .
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OrganizationEvent GetOrganizationEvent(GetOrganizationEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a resource containing information about an event affecting an
        /// organization .
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OrganizationEvent> GetOrganizationEventAsync(GetOrganizationEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a resource containing information about an event affecting an
        /// organization .
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OrganizationEvent> GetOrganizationEventAsync(GetOrganizationEventRequest request, st::CancellationToken cancellationToken) =>
            GetOrganizationEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a resource containing information about an event affecting an
        /// organization .
        /// </summary>
        /// <param name="name">
        /// Required. Unique name of the event in this scope including organization and
        /// event ID using the form
        /// `organizations/{organization_id}/locations/locations/global/organizationEvents/{event_id}`.
        /// 
        /// `organization_id` - ID (number) of the project that contains the event. To
        /// get your `organization_id`, see
        /// [Getting your organization resource
        /// ID](https://cloud.google.com/resource-manager/docs/creating-managing-organization#retrieving_your_organization_id).&lt;br&gt;
        /// `event_id` - Organization event ID to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OrganizationEvent GetOrganizationEvent(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrganizationEvent(new GetOrganizationEventRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a resource containing information about an event affecting an
        /// organization .
        /// </summary>
        /// <param name="name">
        /// Required. Unique name of the event in this scope including organization and
        /// event ID using the form
        /// `organizations/{organization_id}/locations/locations/global/organizationEvents/{event_id}`.
        /// 
        /// `organization_id` - ID (number) of the project that contains the event. To
        /// get your `organization_id`, see
        /// [Getting your organization resource
        /// ID](https://cloud.google.com/resource-manager/docs/creating-managing-organization#retrieving_your_organization_id).&lt;br&gt;
        /// `event_id` - Organization event ID to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OrganizationEvent> GetOrganizationEventAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrganizationEventAsync(new GetOrganizationEventRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a resource containing information about an event affecting an
        /// organization .
        /// </summary>
        /// <param name="name">
        /// Required. Unique name of the event in this scope including organization and
        /// event ID using the form
        /// `organizations/{organization_id}/locations/locations/global/organizationEvents/{event_id}`.
        /// 
        /// `organization_id` - ID (number) of the project that contains the event. To
        /// get your `organization_id`, see
        /// [Getting your organization resource
        /// ID](https://cloud.google.com/resource-manager/docs/creating-managing-organization#retrieving_your_organization_id).&lt;br&gt;
        /// `event_id` - Organization event ID to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OrganizationEvent> GetOrganizationEventAsync(string name, st::CancellationToken cancellationToken) =>
            GetOrganizationEventAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a resource containing information about an event affecting an
        /// organization .
        /// </summary>
        /// <param name="name">
        /// Required. Unique name of the event in this scope including organization and
        /// event ID using the form
        /// `organizations/{organization_id}/locations/locations/global/organizationEvents/{event_id}`.
        /// 
        /// `organization_id` - ID (number) of the project that contains the event. To
        /// get your `organization_id`, see
        /// [Getting your organization resource
        /// ID](https://cloud.google.com/resource-manager/docs/creating-managing-organization#retrieving_your_organization_id).&lt;br&gt;
        /// `event_id` - Organization event ID to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OrganizationEvent GetOrganizationEvent(OrganizationEventName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrganizationEvent(new GetOrganizationEventRequest
            {
                OrganizationEventName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a resource containing information about an event affecting an
        /// organization .
        /// </summary>
        /// <param name="name">
        /// Required. Unique name of the event in this scope including organization and
        /// event ID using the form
        /// `organizations/{organization_id}/locations/locations/global/organizationEvents/{event_id}`.
        /// 
        /// `organization_id` - ID (number) of the project that contains the event. To
        /// get your `organization_id`, see
        /// [Getting your organization resource
        /// ID](https://cloud.google.com/resource-manager/docs/creating-managing-organization#retrieving_your_organization_id).&lt;br&gt;
        /// `event_id` - Organization event ID to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OrganizationEvent> GetOrganizationEventAsync(OrganizationEventName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrganizationEventAsync(new GetOrganizationEventRequest
            {
                OrganizationEventName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a resource containing information about an event affecting an
        /// organization .
        /// </summary>
        /// <param name="name">
        /// Required. Unique name of the event in this scope including organization and
        /// event ID using the form
        /// `organizations/{organization_id}/locations/locations/global/organizationEvents/{event_id}`.
        /// 
        /// `organization_id` - ID (number) of the project that contains the event. To
        /// get your `organization_id`, see
        /// [Getting your organization resource
        /// ID](https://cloud.google.com/resource-manager/docs/creating-managing-organization#retrieving_your_organization_id).&lt;br&gt;
        /// `event_id` - Organization event ID to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OrganizationEvent> GetOrganizationEventAsync(OrganizationEventName name, st::CancellationToken cancellationToken) =>
            GetOrganizationEventAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists assets impacted by organization events under a given organization and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="OrganizationImpact"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOrganizationImpactsResponse, OrganizationImpact> ListOrganizationImpacts(ListOrganizationImpactsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists assets impacted by organization events under a given organization and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="OrganizationImpact"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOrganizationImpactsResponse, OrganizationImpact> ListOrganizationImpactsAsync(ListOrganizationImpactsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists assets impacted by organization events under a given organization and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value using the form
        /// `organizations/{organization_id}/locations/{location}/organizationImpacts`.
        /// 
        /// `organization_id` - ID (number) of the project that contains the event. To
        /// get your `organization_id`, see
        /// [Getting your organization resource
        /// ID](https://cloud.google.com/resource-manager/docs/creating-managing-organization#retrieving_your_organization_id).
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
        /// <returns>A pageable sequence of <see cref="OrganizationImpact"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOrganizationImpactsResponse, OrganizationImpact> ListOrganizationImpacts(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOrganizationImpactsRequest request = new ListOrganizationImpactsRequest
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
            return ListOrganizationImpacts(request, callSettings);
        }

        /// <summary>
        /// Lists assets impacted by organization events under a given organization and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value using the form
        /// `organizations/{organization_id}/locations/{location}/organizationImpacts`.
        /// 
        /// `organization_id` - ID (number) of the project that contains the event. To
        /// get your `organization_id`, see
        /// [Getting your organization resource
        /// ID](https://cloud.google.com/resource-manager/docs/creating-managing-organization#retrieving_your_organization_id).
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
        /// <returns>A pageable asynchronous sequence of <see cref="OrganizationImpact"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOrganizationImpactsResponse, OrganizationImpact> ListOrganizationImpactsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOrganizationImpactsRequest request = new ListOrganizationImpactsRequest
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
            return ListOrganizationImpactsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists assets impacted by organization events under a given organization and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value using the form
        /// `organizations/{organization_id}/locations/{location}/organizationImpacts`.
        /// 
        /// `organization_id` - ID (number) of the project that contains the event. To
        /// get your `organization_id`, see
        /// [Getting your organization resource
        /// ID](https://cloud.google.com/resource-manager/docs/creating-managing-organization#retrieving_your_organization_id).
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
        /// <returns>A pageable sequence of <see cref="OrganizationImpact"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOrganizationImpactsResponse, OrganizationImpact> ListOrganizationImpacts(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOrganizationImpactsRequest request = new ListOrganizationImpactsRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListOrganizationImpacts(request, callSettings);
        }

        /// <summary>
        /// Lists assets impacted by organization events under a given organization and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value using the form
        /// `organizations/{organization_id}/locations/{location}/organizationImpacts`.
        /// 
        /// `organization_id` - ID (number) of the project that contains the event. To
        /// get your `organization_id`, see
        /// [Getting your organization resource
        /// ID](https://cloud.google.com/resource-manager/docs/creating-managing-organization#retrieving_your_organization_id).
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
        /// <returns>A pageable asynchronous sequence of <see cref="OrganizationImpact"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOrganizationImpactsResponse, OrganizationImpact> ListOrganizationImpactsAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOrganizationImpactsRequest request = new ListOrganizationImpactsRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListOrganizationImpactsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a resource containing information about impact to an asset under
        /// an organization affected by a service health event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OrganizationImpact GetOrganizationImpact(GetOrganizationImpactRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a resource containing information about impact to an asset under
        /// an organization affected by a service health event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OrganizationImpact> GetOrganizationImpactAsync(GetOrganizationImpactRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a resource containing information about impact to an asset under
        /// an organization affected by a service health event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OrganizationImpact> GetOrganizationImpactAsync(GetOrganizationImpactRequest request, st::CancellationToken cancellationToken) =>
            GetOrganizationImpactAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a resource containing information about impact to an asset under
        /// an organization affected by a service health event.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource using the form
        /// `organizations/{organization_id}/locations/global/organizationImpacts/{organization_impact_id}`.
        /// 
        /// `organization_id` - ID (number) of the organization that contains the
        /// event. To get your `organization_id`, see
        /// [Getting your organization resource
        /// ID](https://cloud.google.com/resource-manager/docs/creating-managing-organization#retrieving_your_organization_id).&lt;br&gt;
        /// `organization_impact_id` - ID of the [OrganizationImpact
        /// resource](/service-health/docs/reference/rest/v1beta/organizations.locations.organizationImpacts#OrganizationImpact).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OrganizationImpact GetOrganizationImpact(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrganizationImpact(new GetOrganizationImpactRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a resource containing information about impact to an asset under
        /// an organization affected by a service health event.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource using the form
        /// `organizations/{organization_id}/locations/global/organizationImpacts/{organization_impact_id}`.
        /// 
        /// `organization_id` - ID (number) of the organization that contains the
        /// event. To get your `organization_id`, see
        /// [Getting your organization resource
        /// ID](https://cloud.google.com/resource-manager/docs/creating-managing-organization#retrieving_your_organization_id).&lt;br&gt;
        /// `organization_impact_id` - ID of the [OrganizationImpact
        /// resource](/service-health/docs/reference/rest/v1beta/organizations.locations.organizationImpacts#OrganizationImpact).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OrganizationImpact> GetOrganizationImpactAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrganizationImpactAsync(new GetOrganizationImpactRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a resource containing information about impact to an asset under
        /// an organization affected by a service health event.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource using the form
        /// `organizations/{organization_id}/locations/global/organizationImpacts/{organization_impact_id}`.
        /// 
        /// `organization_id` - ID (number) of the organization that contains the
        /// event. To get your `organization_id`, see
        /// [Getting your organization resource
        /// ID](https://cloud.google.com/resource-manager/docs/creating-managing-organization#retrieving_your_organization_id).&lt;br&gt;
        /// `organization_impact_id` - ID of the [OrganizationImpact
        /// resource](/service-health/docs/reference/rest/v1beta/organizations.locations.organizationImpacts#OrganizationImpact).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OrganizationImpact> GetOrganizationImpactAsync(string name, st::CancellationToken cancellationToken) =>
            GetOrganizationImpactAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a resource containing information about impact to an asset under
        /// an organization affected by a service health event.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource using the form
        /// `organizations/{organization_id}/locations/global/organizationImpacts/{organization_impact_id}`.
        /// 
        /// `organization_id` - ID (number) of the organization that contains the
        /// event. To get your `organization_id`, see
        /// [Getting your organization resource
        /// ID](https://cloud.google.com/resource-manager/docs/creating-managing-organization#retrieving_your_organization_id).&lt;br&gt;
        /// `organization_impact_id` - ID of the [OrganizationImpact
        /// resource](/service-health/docs/reference/rest/v1beta/organizations.locations.organizationImpacts#OrganizationImpact).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OrganizationImpact GetOrganizationImpact(OrganizationImpactName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrganizationImpact(new GetOrganizationImpactRequest
            {
                OrganizationImpactName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a resource containing information about impact to an asset under
        /// an organization affected by a service health event.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource using the form
        /// `organizations/{organization_id}/locations/global/organizationImpacts/{organization_impact_id}`.
        /// 
        /// `organization_id` - ID (number) of the organization that contains the
        /// event. To get your `organization_id`, see
        /// [Getting your organization resource
        /// ID](https://cloud.google.com/resource-manager/docs/creating-managing-organization#retrieving_your_organization_id).&lt;br&gt;
        /// `organization_impact_id` - ID of the [OrganizationImpact
        /// resource](/service-health/docs/reference/rest/v1beta/organizations.locations.organizationImpacts#OrganizationImpact).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OrganizationImpact> GetOrganizationImpactAsync(OrganizationImpactName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOrganizationImpactAsync(new GetOrganizationImpactRequest
            {
                OrganizationImpactName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a resource containing information about impact to an asset under
        /// an organization affected by a service health event.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource using the form
        /// `organizations/{organization_id}/locations/global/organizationImpacts/{organization_impact_id}`.
        /// 
        /// `organization_id` - ID (number) of the organization that contains the
        /// event. To get your `organization_id`, see
        /// [Getting your organization resource
        /// ID](https://cloud.google.com/resource-manager/docs/creating-managing-organization#retrieving_your_organization_id).&lt;br&gt;
        /// `organization_impact_id` - ID of the [OrganizationImpact
        /// resource](/service-health/docs/reference/rest/v1beta/organizations.locations.organizationImpacts#OrganizationImpact).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OrganizationImpact> GetOrganizationImpactAsync(OrganizationImpactName name, st::CancellationToken cancellationToken) =>
            GetOrganizationImpactAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ServiceHealth client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Request service health events relevant to your Google Cloud project.
    /// </remarks>
    public sealed partial class ServiceHealthClientImpl : ServiceHealthClient
    {
        private readonly gaxgrpc::ApiCall<ListEventsRequest, ListEventsResponse> _callListEvents;

        private readonly gaxgrpc::ApiCall<GetEventRequest, Event> _callGetEvent;

        private readonly gaxgrpc::ApiCall<ListOrganizationEventsRequest, ListOrganizationEventsResponse> _callListOrganizationEvents;

        private readonly gaxgrpc::ApiCall<GetOrganizationEventRequest, OrganizationEvent> _callGetOrganizationEvent;

        private readonly gaxgrpc::ApiCall<ListOrganizationImpactsRequest, ListOrganizationImpactsResponse> _callListOrganizationImpacts;

        private readonly gaxgrpc::ApiCall<GetOrganizationImpactRequest, OrganizationImpact> _callGetOrganizationImpact;

        /// <summary>
        /// Constructs a client wrapper for the ServiceHealth service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ServiceHealthSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ServiceHealthClientImpl(ServiceHealth.ServiceHealthClient grpcClient, ServiceHealthSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ServiceHealthSettings effectiveSettings = settings ?? ServiceHealthSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListEvents = clientHelper.BuildApiCall<ListEventsRequest, ListEventsResponse>("ListEvents", grpcClient.ListEventsAsync, grpcClient.ListEvents, effectiveSettings.ListEventsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEvents);
            Modify_ListEventsApiCall(ref _callListEvents);
            _callGetEvent = clientHelper.BuildApiCall<GetEventRequest, Event>("GetEvent", grpcClient.GetEventAsync, grpcClient.GetEvent, effectiveSettings.GetEventSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEvent);
            Modify_GetEventApiCall(ref _callGetEvent);
            _callListOrganizationEvents = clientHelper.BuildApiCall<ListOrganizationEventsRequest, ListOrganizationEventsResponse>("ListOrganizationEvents", grpcClient.ListOrganizationEventsAsync, grpcClient.ListOrganizationEvents, effectiveSettings.ListOrganizationEventsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListOrganizationEvents);
            Modify_ListOrganizationEventsApiCall(ref _callListOrganizationEvents);
            _callGetOrganizationEvent = clientHelper.BuildApiCall<GetOrganizationEventRequest, OrganizationEvent>("GetOrganizationEvent", grpcClient.GetOrganizationEventAsync, grpcClient.GetOrganizationEvent, effectiveSettings.GetOrganizationEventSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetOrganizationEvent);
            Modify_GetOrganizationEventApiCall(ref _callGetOrganizationEvent);
            _callListOrganizationImpacts = clientHelper.BuildApiCall<ListOrganizationImpactsRequest, ListOrganizationImpactsResponse>("ListOrganizationImpacts", grpcClient.ListOrganizationImpactsAsync, grpcClient.ListOrganizationImpacts, effectiveSettings.ListOrganizationImpactsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListOrganizationImpacts);
            Modify_ListOrganizationImpactsApiCall(ref _callListOrganizationImpacts);
            _callGetOrganizationImpact = clientHelper.BuildApiCall<GetOrganizationImpactRequest, OrganizationImpact>("GetOrganizationImpact", grpcClient.GetOrganizationImpactAsync, grpcClient.GetOrganizationImpact, effectiveSettings.GetOrganizationImpactSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetOrganizationImpact);
            Modify_GetOrganizationImpactApiCall(ref _callGetOrganizationImpact);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListEventsApiCall(ref gaxgrpc::ApiCall<ListEventsRequest, ListEventsResponse> call);

        partial void Modify_GetEventApiCall(ref gaxgrpc::ApiCall<GetEventRequest, Event> call);

        partial void Modify_ListOrganizationEventsApiCall(ref gaxgrpc::ApiCall<ListOrganizationEventsRequest, ListOrganizationEventsResponse> call);

        partial void Modify_GetOrganizationEventApiCall(ref gaxgrpc::ApiCall<GetOrganizationEventRequest, OrganizationEvent> call);

        partial void Modify_ListOrganizationImpactsApiCall(ref gaxgrpc::ApiCall<ListOrganizationImpactsRequest, ListOrganizationImpactsResponse> call);

        partial void Modify_GetOrganizationImpactApiCall(ref gaxgrpc::ApiCall<GetOrganizationImpactRequest, OrganizationImpact> call);

        partial void OnConstruction(ServiceHealth.ServiceHealthClient grpcClient, ServiceHealthSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ServiceHealth client</summary>
        public override ServiceHealth.ServiceHealthClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListEventsRequest(ref ListEventsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEventRequest(ref GetEventRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListOrganizationEventsRequest(ref ListOrganizationEventsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetOrganizationEventRequest(ref GetOrganizationEventRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListOrganizationImpactsRequest(ref ListOrganizationImpactsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetOrganizationImpactRequest(ref GetOrganizationImpactRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists events under a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Event"/> resources.</returns>
        public override gax::PagedEnumerable<ListEventsResponse, Event> ListEvents(ListEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEventsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEventsRequest, ListEventsResponse, Event>(_callListEvents, request, callSettings);
        }

        /// <summary>
        /// Lists events under a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Event"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEventsResponse, Event> ListEventsAsync(ListEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEventsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEventsRequest, ListEventsResponse, Event>(_callListEvents, request, callSettings);
        }

        /// <summary>
        /// Retrieves a resource containing information about an event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Event GetEvent(GetEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEventRequest(ref request, ref callSettings);
            return _callGetEvent.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a resource containing information about an event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Event> GetEventAsync(GetEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEventRequest(ref request, ref callSettings);
            return _callGetEvent.Async(request, callSettings);
        }

        /// <summary>
        /// Lists organization events under a given organization and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="OrganizationEvent"/> resources.</returns>
        public override gax::PagedEnumerable<ListOrganizationEventsResponse, OrganizationEvent> ListOrganizationEvents(ListOrganizationEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOrganizationEventsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListOrganizationEventsRequest, ListOrganizationEventsResponse, OrganizationEvent>(_callListOrganizationEvents, request, callSettings);
        }

        /// <summary>
        /// Lists organization events under a given organization and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="OrganizationEvent"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListOrganizationEventsResponse, OrganizationEvent> ListOrganizationEventsAsync(ListOrganizationEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOrganizationEventsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListOrganizationEventsRequest, ListOrganizationEventsResponse, OrganizationEvent>(_callListOrganizationEvents, request, callSettings);
        }

        /// <summary>
        /// Retrieves a resource containing information about an event affecting an
        /// organization .
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override OrganizationEvent GetOrganizationEvent(GetOrganizationEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOrganizationEventRequest(ref request, ref callSettings);
            return _callGetOrganizationEvent.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a resource containing information about an event affecting an
        /// organization .
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<OrganizationEvent> GetOrganizationEventAsync(GetOrganizationEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOrganizationEventRequest(ref request, ref callSettings);
            return _callGetOrganizationEvent.Async(request, callSettings);
        }

        /// <summary>
        /// Lists assets impacted by organization events under a given organization and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="OrganizationImpact"/> resources.</returns>
        public override gax::PagedEnumerable<ListOrganizationImpactsResponse, OrganizationImpact> ListOrganizationImpacts(ListOrganizationImpactsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOrganizationImpactsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListOrganizationImpactsRequest, ListOrganizationImpactsResponse, OrganizationImpact>(_callListOrganizationImpacts, request, callSettings);
        }

        /// <summary>
        /// Lists assets impacted by organization events under a given organization and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="OrganizationImpact"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListOrganizationImpactsResponse, OrganizationImpact> ListOrganizationImpactsAsync(ListOrganizationImpactsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOrganizationImpactsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListOrganizationImpactsRequest, ListOrganizationImpactsResponse, OrganizationImpact>(_callListOrganizationImpacts, request, callSettings);
        }

        /// <summary>
        /// Retrieves a resource containing information about impact to an asset under
        /// an organization affected by a service health event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override OrganizationImpact GetOrganizationImpact(GetOrganizationImpactRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOrganizationImpactRequest(ref request, ref callSettings);
            return _callGetOrganizationImpact.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a resource containing information about impact to an asset under
        /// an organization affected by a service health event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<OrganizationImpact> GetOrganizationImpactAsync(GetOrganizationImpactRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOrganizationImpactRequest(ref request, ref callSettings);
            return _callGetOrganizationImpact.Async(request, callSettings);
        }
    }

    public partial class ListEventsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListOrganizationEventsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListOrganizationImpactsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEventsResponse : gaxgrpc::IPageResponse<Event>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Event> GetEnumerator() => Events.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListOrganizationEventsResponse : gaxgrpc::IPageResponse<OrganizationEvent>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<OrganizationEvent> GetEnumerator() => OrganizationEvents.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListOrganizationImpactsResponse : gaxgrpc::IPageResponse<OrganizationImpact>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<OrganizationImpact> GetEnumerator() => OrganizationImpacts.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ServiceHealth
    {
        public partial class ServiceHealthClient
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
        }
    }
}
