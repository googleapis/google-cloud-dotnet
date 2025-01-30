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

namespace Google.Cloud.AdvisoryNotifications.V1
{
    /// <summary>Settings for <see cref="AdvisoryNotificationsServiceClient"/> instances.</summary>
    public sealed partial class AdvisoryNotificationsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AdvisoryNotificationsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AdvisoryNotificationsServiceSettings"/>.</returns>
        public static AdvisoryNotificationsServiceSettings GetDefault() => new AdvisoryNotificationsServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AdvisoryNotificationsServiceSettings"/> object with default settings.
        /// </summary>
        public AdvisoryNotificationsServiceSettings()
        {
        }

        private AdvisoryNotificationsServiceSettings(AdvisoryNotificationsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListNotificationsSettings = existing.ListNotificationsSettings;
            GetNotificationSettings = existing.GetNotificationSettings;
            GetSettingsSettings = existing.GetSettingsSettings;
            UpdateSettingsSettings = existing.UpdateSettingsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AdvisoryNotificationsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdvisoryNotificationsServiceClient.ListNotifications</c> and
        /// <c>AdvisoryNotificationsServiceClient.ListNotificationsAsync</c>.
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
        public gaxgrpc::CallSettings ListNotificationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdvisoryNotificationsServiceClient.GetNotification</c> and
        /// <c>AdvisoryNotificationsServiceClient.GetNotificationAsync</c>.
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
        public gaxgrpc::CallSettings GetNotificationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdvisoryNotificationsServiceClient.GetSettings</c> and
        /// <c>AdvisoryNotificationsServiceClient.GetSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSettingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdvisoryNotificationsServiceClient.UpdateSettings</c> and
        /// <c>AdvisoryNotificationsServiceClient.UpdateSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSettingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AdvisoryNotificationsServiceSettings"/> object.</returns>
        public AdvisoryNotificationsServiceSettings Clone() => new AdvisoryNotificationsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AdvisoryNotificationsServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class AdvisoryNotificationsServiceClientBuilder : gaxgrpc::ClientBuilderBase<AdvisoryNotificationsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AdvisoryNotificationsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AdvisoryNotificationsServiceClientBuilder() : base(AdvisoryNotificationsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AdvisoryNotificationsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AdvisoryNotificationsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AdvisoryNotificationsServiceClient Build()
        {
            AdvisoryNotificationsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AdvisoryNotificationsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AdvisoryNotificationsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AdvisoryNotificationsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AdvisoryNotificationsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AdvisoryNotificationsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AdvisoryNotificationsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AdvisoryNotificationsServiceClient.ChannelPool;
    }

    /// <summary>AdvisoryNotificationsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage Security and Privacy Notifications.
    /// </remarks>
    public abstract partial class AdvisoryNotificationsServiceClient
    {
        /// <summary>
        /// The default endpoint for the AdvisoryNotificationsService service, which is a host of
        /// "advisorynotifications.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "advisorynotifications.googleapis.com:443";

        /// <summary>The default AdvisoryNotificationsService scopes.</summary>
        /// <remarks>
        /// The default AdvisoryNotificationsService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AdvisoryNotificationsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AdvisoryNotificationsServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AdvisoryNotificationsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AdvisoryNotificationsServiceClient"/>.</returns>
        public static stt::Task<AdvisoryNotificationsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AdvisoryNotificationsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AdvisoryNotificationsServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AdvisoryNotificationsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AdvisoryNotificationsServiceClient"/>.</returns>
        public static AdvisoryNotificationsServiceClient Create() => new AdvisoryNotificationsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AdvisoryNotificationsServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AdvisoryNotificationsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AdvisoryNotificationsServiceClient"/>.</returns>
        internal static AdvisoryNotificationsServiceClient Create(grpccore::CallInvoker callInvoker, AdvisoryNotificationsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AdvisoryNotificationsService.AdvisoryNotificationsServiceClient grpcClient = new AdvisoryNotificationsService.AdvisoryNotificationsServiceClient(callInvoker);
            return new AdvisoryNotificationsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AdvisoryNotificationsService client</summary>
        public virtual AdvisoryNotificationsService.AdvisoryNotificationsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists notifications under a given parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Notification"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNotificationsResponse, Notification> ListNotifications(ListNotificationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists notifications under a given parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Notification"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNotificationsResponse, Notification> ListNotificationsAsync(ListNotificationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists notifications under a given parent.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of notifications.
        /// Must be of the form "organizations/{organization}/locations/{location}"
        /// or "projects/{project}/locations/{location}".
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
        /// <returns>A pageable sequence of <see cref="Notification"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNotificationsResponse, Notification> ListNotifications(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNotificationsRequest request = new ListNotificationsRequest
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
            return ListNotifications(request, callSettings);
        }

        /// <summary>
        /// Lists notifications under a given parent.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of notifications.
        /// Must be of the form "organizations/{organization}/locations/{location}"
        /// or "projects/{project}/locations/{location}".
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
        /// <returns>A pageable asynchronous sequence of <see cref="Notification"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNotificationsResponse, Notification> ListNotificationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNotificationsRequest request = new ListNotificationsRequest
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
            return ListNotificationsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists notifications under a given parent.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of notifications.
        /// Must be of the form "organizations/{organization}/locations/{location}"
        /// or "projects/{project}/locations/{location}".
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
        /// <returns>A pageable sequence of <see cref="Notification"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNotificationsResponse, Notification> ListNotifications(LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNotificationsRequest request = new ListNotificationsRequest
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
            return ListNotifications(request, callSettings);
        }

        /// <summary>
        /// Lists notifications under a given parent.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of notifications.
        /// Must be of the form "organizations/{organization}/locations/{location}"
        /// or "projects/{project}/locations/{location}".
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
        /// <returns>A pageable asynchronous sequence of <see cref="Notification"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNotificationsResponse, Notification> ListNotificationsAsync(LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNotificationsRequest request = new ListNotificationsRequest
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
            return ListNotificationsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a notification.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Notification GetNotification(GetNotificationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a notification.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Notification> GetNotificationAsync(GetNotificationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a notification.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Notification> GetNotificationAsync(GetNotificationRequest request, st::CancellationToken cancellationToken) =>
            GetNotificationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a notification.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the notification to retrieve.
        /// Format:
        /// organizations/{organization}/locations/{location}/notifications/{notification}
        /// or projects/{projects}/locations/{location}/notifications/{notification}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Notification GetNotification(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotification(new GetNotificationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a notification.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the notification to retrieve.
        /// Format:
        /// organizations/{organization}/locations/{location}/notifications/{notification}
        /// or projects/{projects}/locations/{location}/notifications/{notification}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Notification> GetNotificationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotificationAsync(new GetNotificationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a notification.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the notification to retrieve.
        /// Format:
        /// organizations/{organization}/locations/{location}/notifications/{notification}
        /// or projects/{projects}/locations/{location}/notifications/{notification}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Notification> GetNotificationAsync(string name, st::CancellationToken cancellationToken) =>
            GetNotificationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a notification.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the notification to retrieve.
        /// Format:
        /// organizations/{organization}/locations/{location}/notifications/{notification}
        /// or projects/{projects}/locations/{location}/notifications/{notification}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Notification GetNotification(NotificationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotification(new GetNotificationRequest
            {
                NotificationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a notification.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the notification to retrieve.
        /// Format:
        /// organizations/{organization}/locations/{location}/notifications/{notification}
        /// or projects/{projects}/locations/{location}/notifications/{notification}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Notification> GetNotificationAsync(NotificationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotificationAsync(new GetNotificationRequest
            {
                NotificationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a notification.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the notification to retrieve.
        /// Format:
        /// organizations/{organization}/locations/{location}/notifications/{notification}
        /// or projects/{projects}/locations/{location}/notifications/{notification}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Notification> GetNotificationAsync(NotificationName name, st::CancellationToken cancellationToken) =>
            GetNotificationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get notification settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings GetSettings(GetSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get notification settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(GetSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get notification settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(GetSettingsRequest request, st::CancellationToken cancellationToken) =>
            GetSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get notification settings.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the settings to retrieve.
        /// Format:
        /// organizations/{organization}/locations/{location}/settings or
        /// projects/{projects}/locations/{location}/settings.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings GetSettings(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSettings(new GetSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get notification settings.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the settings to retrieve.
        /// Format:
        /// organizations/{organization}/locations/{location}/settings or
        /// projects/{projects}/locations/{location}/settings.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSettingsAsync(new GetSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get notification settings.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the settings to retrieve.
        /// Format:
        /// organizations/{organization}/locations/{location}/settings or
        /// projects/{projects}/locations/{location}/settings.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(string name, st::CancellationToken cancellationToken) =>
            GetSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get notification settings.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the settings to retrieve.
        /// Format:
        /// organizations/{organization}/locations/{location}/settings or
        /// projects/{projects}/locations/{location}/settings.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings GetSettings(SettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSettings(new GetSettingsRequest
            {
                SettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get notification settings.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the settings to retrieve.
        /// Format:
        /// organizations/{organization}/locations/{location}/settings or
        /// projects/{projects}/locations/{location}/settings.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(SettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSettingsAsync(new GetSettingsRequest
            {
                SettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get notification settings.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the settings to retrieve.
        /// Format:
        /// organizations/{organization}/locations/{location}/settings or
        /// projects/{projects}/locations/{location}/settings.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(SettingsName name, st::CancellationToken cancellationToken) =>
            GetSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update notification settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings UpdateSettings(UpdateSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update notification settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> UpdateSettingsAsync(UpdateSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update notification settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> UpdateSettingsAsync(UpdateSettingsRequest request, st::CancellationToken cancellationToken) =>
            UpdateSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update notification settings.
        /// </summary>
        /// <param name="settings">
        /// Required. New settings.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings UpdateSettings(Settings settings, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSettings(new UpdateSettingsRequest
            {
                Settings = gax::GaxPreconditions.CheckNotNull(settings, nameof(settings)),
            }, callSettings);

        /// <summary>
        /// Update notification settings.
        /// </summary>
        /// <param name="settings">
        /// Required. New settings.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> UpdateSettingsAsync(Settings settings, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSettingsAsync(new UpdateSettingsRequest
            {
                Settings = gax::GaxPreconditions.CheckNotNull(settings, nameof(settings)),
            }, callSettings);

        /// <summary>
        /// Update notification settings.
        /// </summary>
        /// <param name="settings">
        /// Required. New settings.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> UpdateSettingsAsync(Settings settings, st::CancellationToken cancellationToken) =>
            UpdateSettingsAsync(settings, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AdvisoryNotificationsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage Security and Privacy Notifications.
    /// </remarks>
    public sealed partial class AdvisoryNotificationsServiceClientImpl : AdvisoryNotificationsServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListNotificationsRequest, ListNotificationsResponse> _callListNotifications;

        private readonly gaxgrpc::ApiCall<GetNotificationRequest, Notification> _callGetNotification;

        private readonly gaxgrpc::ApiCall<GetSettingsRequest, Settings> _callGetSettings;

        private readonly gaxgrpc::ApiCall<UpdateSettingsRequest, Settings> _callUpdateSettings;

        /// <summary>
        /// Constructs a client wrapper for the AdvisoryNotificationsService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="AdvisoryNotificationsServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AdvisoryNotificationsServiceClientImpl(AdvisoryNotificationsService.AdvisoryNotificationsServiceClient grpcClient, AdvisoryNotificationsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AdvisoryNotificationsServiceSettings effectiveSettings = settings ?? AdvisoryNotificationsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callListNotifications = clientHelper.BuildApiCall<ListNotificationsRequest, ListNotificationsResponse>("ListNotifications", grpcClient.ListNotificationsAsync, grpcClient.ListNotifications, effectiveSettings.ListNotificationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListNotifications);
            Modify_ListNotificationsApiCall(ref _callListNotifications);
            _callGetNotification = clientHelper.BuildApiCall<GetNotificationRequest, Notification>("GetNotification", grpcClient.GetNotificationAsync, grpcClient.GetNotification, effectiveSettings.GetNotificationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetNotification);
            Modify_GetNotificationApiCall(ref _callGetNotification);
            _callGetSettings = clientHelper.BuildApiCall<GetSettingsRequest, Settings>("GetSettings", grpcClient.GetSettingsAsync, grpcClient.GetSettings, effectiveSettings.GetSettingsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSettings);
            Modify_GetSettingsApiCall(ref _callGetSettings);
            _callUpdateSettings = clientHelper.BuildApiCall<UpdateSettingsRequest, Settings>("UpdateSettings", grpcClient.UpdateSettingsAsync, grpcClient.UpdateSettings, effectiveSettings.UpdateSettingsSettings).WithGoogleRequestParam("settings.name", request => request.Settings?.Name);
            Modify_ApiCall(ref _callUpdateSettings);
            Modify_UpdateSettingsApiCall(ref _callUpdateSettings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListNotificationsApiCall(ref gaxgrpc::ApiCall<ListNotificationsRequest, ListNotificationsResponse> call);

        partial void Modify_GetNotificationApiCall(ref gaxgrpc::ApiCall<GetNotificationRequest, Notification> call);

        partial void Modify_GetSettingsApiCall(ref gaxgrpc::ApiCall<GetSettingsRequest, Settings> call);

        partial void Modify_UpdateSettingsApiCall(ref gaxgrpc::ApiCall<UpdateSettingsRequest, Settings> call);

        partial void OnConstruction(AdvisoryNotificationsService.AdvisoryNotificationsServiceClient grpcClient, AdvisoryNotificationsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AdvisoryNotificationsService client</summary>
        public override AdvisoryNotificationsService.AdvisoryNotificationsServiceClient GrpcClient { get; }

        partial void Modify_ListNotificationsRequest(ref ListNotificationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetNotificationRequest(ref GetNotificationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSettingsRequest(ref GetSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSettingsRequest(ref UpdateSettingsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists notifications under a given parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Notification"/> resources.</returns>
        public override gax::PagedEnumerable<ListNotificationsResponse, Notification> ListNotifications(ListNotificationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNotificationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListNotificationsRequest, ListNotificationsResponse, Notification>(_callListNotifications, request, callSettings);
        }

        /// <summary>
        /// Lists notifications under a given parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Notification"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListNotificationsResponse, Notification> ListNotificationsAsync(ListNotificationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNotificationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListNotificationsRequest, ListNotificationsResponse, Notification>(_callListNotifications, request, callSettings);
        }

        /// <summary>
        /// Gets a notification.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Notification GetNotification(GetNotificationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNotificationRequest(ref request, ref callSettings);
            return _callGetNotification.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a notification.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Notification> GetNotificationAsync(GetNotificationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNotificationRequest(ref request, ref callSettings);
            return _callGetNotification.Async(request, callSettings);
        }

        /// <summary>
        /// Get notification settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Settings GetSettings(GetSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSettingsRequest(ref request, ref callSettings);
            return _callGetSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Get notification settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Settings> GetSettingsAsync(GetSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSettingsRequest(ref request, ref callSettings);
            return _callGetSettings.Async(request, callSettings);
        }

        /// <summary>
        /// Update notification settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Settings UpdateSettings(UpdateSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSettingsRequest(ref request, ref callSettings);
            return _callUpdateSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Update notification settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Settings> UpdateSettingsAsync(UpdateSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSettingsRequest(ref request, ref callSettings);
            return _callUpdateSettings.Async(request, callSettings);
        }
    }

    public partial class ListNotificationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListNotificationsResponse : gaxgrpc::IPageResponse<Notification>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Notification> GetEnumerator() => Notifications.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
