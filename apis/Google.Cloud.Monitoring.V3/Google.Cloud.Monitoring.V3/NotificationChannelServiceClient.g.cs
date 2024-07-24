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

namespace Google.Cloud.Monitoring.V3
{
    /// <summary>Settings for <see cref="NotificationChannelServiceClient"/> instances.</summary>
    public sealed partial class NotificationChannelServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="NotificationChannelServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="NotificationChannelServiceSettings"/>.</returns>
        public static NotificationChannelServiceSettings GetDefault() => new NotificationChannelServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="NotificationChannelServiceSettings"/> object with default settings.
        /// </summary>
        public NotificationChannelServiceSettings()
        {
        }

        private NotificationChannelServiceSettings(NotificationChannelServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListNotificationChannelDescriptorsSettings = existing.ListNotificationChannelDescriptorsSettings;
            GetNotificationChannelDescriptorSettings = existing.GetNotificationChannelDescriptorSettings;
            ListNotificationChannelsSettings = existing.ListNotificationChannelsSettings;
            GetNotificationChannelSettings = existing.GetNotificationChannelSettings;
            CreateNotificationChannelSettings = existing.CreateNotificationChannelSettings;
            UpdateNotificationChannelSettings = existing.UpdateNotificationChannelSettings;
            DeleteNotificationChannelSettings = existing.DeleteNotificationChannelSettings;
            SendNotificationChannelVerificationCodeSettings = existing.SendNotificationChannelVerificationCodeSettings;
            GetNotificationChannelVerificationCodeSettings = existing.GetNotificationChannelVerificationCodeSettings;
            VerifyNotificationChannelSettings = existing.VerifyNotificationChannelSettings;
            OnCopy(existing);
        }

        partial void OnCopy(NotificationChannelServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotificationChannelServiceClient.ListNotificationChannelDescriptors</c> and
        /// <c>NotificationChannelServiceClient.ListNotificationChannelDescriptorsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListNotificationChannelDescriptorsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotificationChannelServiceClient.GetNotificationChannelDescriptor</c> and
        /// <c>NotificationChannelServiceClient.GetNotificationChannelDescriptorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetNotificationChannelDescriptorSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotificationChannelServiceClient.ListNotificationChannels</c> and
        /// <c>NotificationChannelServiceClient.ListNotificationChannelsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListNotificationChannelsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotificationChannelServiceClient.GetNotificationChannel</c> and
        /// <c>NotificationChannelServiceClient.GetNotificationChannelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetNotificationChannelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotificationChannelServiceClient.CreateNotificationChannel</c> and
        /// <c>NotificationChannelServiceClient.CreateNotificationChannelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateNotificationChannelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotificationChannelServiceClient.UpdateNotificationChannel</c> and
        /// <c>NotificationChannelServiceClient.UpdateNotificationChannelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateNotificationChannelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotificationChannelServiceClient.DeleteNotificationChannel</c> and
        /// <c>NotificationChannelServiceClient.DeleteNotificationChannelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteNotificationChannelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotificationChannelServiceClient.SendNotificationChannelVerificationCode</c> and
        /// <c>NotificationChannelServiceClient.SendNotificationChannelVerificationCodeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SendNotificationChannelVerificationCodeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotificationChannelServiceClient.GetNotificationChannelVerificationCode</c> and
        /// <c>NotificationChannelServiceClient.GetNotificationChannelVerificationCodeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetNotificationChannelVerificationCodeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotificationChannelServiceClient.VerifyNotificationChannel</c> and
        /// <c>NotificationChannelServiceClient.VerifyNotificationChannelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings VerifyNotificationChannelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="NotificationChannelServiceSettings"/> object.</returns>
        public NotificationChannelServiceSettings Clone() => new NotificationChannelServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="NotificationChannelServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class NotificationChannelServiceClientBuilder : gaxgrpc::ClientBuilderBase<NotificationChannelServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public NotificationChannelServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public NotificationChannelServiceClientBuilder() : base(NotificationChannelServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref NotificationChannelServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<NotificationChannelServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override NotificationChannelServiceClient Build()
        {
            NotificationChannelServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<NotificationChannelServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<NotificationChannelServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private NotificationChannelServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return NotificationChannelServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<NotificationChannelServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return NotificationChannelServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => NotificationChannelServiceClient.ChannelPool;
    }

    /// <summary>NotificationChannelService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The Notification Channel API provides access to configuration that
    /// controls how messages related to incidents are sent.
    /// </remarks>
    public abstract partial class NotificationChannelServiceClient
    {
        /// <summary>
        /// The default endpoint for the NotificationChannelService service, which is a host of
        /// "monitoring.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "monitoring.googleapis.com:443";

        /// <summary>The default NotificationChannelService scopes.</summary>
        /// <remarks>
        /// The default NotificationChannelService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/monitoring</description></item>
        /// <item><description>https://www.googleapis.com/auth/monitoring.read</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/monitoring",
            "https://www.googleapis.com/auth/monitoring.read",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(NotificationChannelService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="NotificationChannelServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="NotificationChannelServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="NotificationChannelServiceClient"/>.</returns>
        public static stt::Task<NotificationChannelServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new NotificationChannelServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="NotificationChannelServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="NotificationChannelServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="NotificationChannelServiceClient"/>.</returns>
        public static NotificationChannelServiceClient Create() => new NotificationChannelServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="NotificationChannelServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="NotificationChannelServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="NotificationChannelServiceClient"/>.</returns>
        internal static NotificationChannelServiceClient Create(grpccore::CallInvoker callInvoker, NotificationChannelServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            NotificationChannelService.NotificationChannelServiceClient grpcClient = new NotificationChannelService.NotificationChannelServiceClient(callInvoker);
            return new NotificationChannelServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC NotificationChannelService client</summary>
        public virtual NotificationChannelService.NotificationChannelServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the descriptors for supported channel types. The use of descriptors
        /// makes it possible for new channel types to be dynamically added.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NotificationChannelDescriptor"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> ListNotificationChannelDescriptors(ListNotificationChannelDescriptorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the descriptors for supported channel types. The use of descriptors
        /// makes it possible for new channel types to be dynamically added.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="NotificationChannelDescriptor"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> ListNotificationChannelDescriptorsAsync(ListNotificationChannelDescriptorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the descriptors for supported channel types. The use of descriptors
        /// makes it possible for new channel types to be dynamically added.
        /// </summary>
        /// <param name="name">
        /// Required. The REST resource name of the parent from which to retrieve
        /// the notification channel descriptors. The expected syntax is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// Note that this
        /// [names](https://cloud.google.com/monitoring/api/v3#project_name) the parent
        /// container in which to look for the descriptors; to retrieve a single
        /// descriptor by name, use the
        /// [GetNotificationChannelDescriptor][google.monitoring.v3.NotificationChannelService.GetNotificationChannelDescriptor]
        /// operation, instead.
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
        /// <returns>A pageable sequence of <see cref="NotificationChannelDescriptor"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> ListNotificationChannelDescriptors(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNotificationChannelDescriptorsRequest request = new ListNotificationChannelDescriptorsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListNotificationChannelDescriptors(request, callSettings);
        }

        /// <summary>
        /// Lists the descriptors for supported channel types. The use of descriptors
        /// makes it possible for new channel types to be dynamically added.
        /// </summary>
        /// <param name="name">
        /// Required. The REST resource name of the parent from which to retrieve
        /// the notification channel descriptors. The expected syntax is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// Note that this
        /// [names](https://cloud.google.com/monitoring/api/v3#project_name) the parent
        /// container in which to look for the descriptors; to retrieve a single
        /// descriptor by name, use the
        /// [GetNotificationChannelDescriptor][google.monitoring.v3.NotificationChannelService.GetNotificationChannelDescriptor]
        /// operation, instead.
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
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="NotificationChannelDescriptor"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> ListNotificationChannelDescriptorsAsync(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNotificationChannelDescriptorsRequest request = new ListNotificationChannelDescriptorsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListNotificationChannelDescriptorsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the descriptors for supported channel types. The use of descriptors
        /// makes it possible for new channel types to be dynamically added.
        /// </summary>
        /// <param name="name">
        /// Required. The REST resource name of the parent from which to retrieve
        /// the notification channel descriptors. The expected syntax is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// Note that this
        /// [names](https://cloud.google.com/monitoring/api/v3#project_name) the parent
        /// container in which to look for the descriptors; to retrieve a single
        /// descriptor by name, use the
        /// [GetNotificationChannelDescriptor][google.monitoring.v3.NotificationChannelService.GetNotificationChannelDescriptor]
        /// operation, instead.
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
        /// <returns>A pageable sequence of <see cref="NotificationChannelDescriptor"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> ListNotificationChannelDescriptors(gagr::ProjectName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNotificationChannelDescriptorsRequest request = new ListNotificationChannelDescriptorsRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListNotificationChannelDescriptors(request, callSettings);
        }

        /// <summary>
        /// Lists the descriptors for supported channel types. The use of descriptors
        /// makes it possible for new channel types to be dynamically added.
        /// </summary>
        /// <param name="name">
        /// Required. The REST resource name of the parent from which to retrieve
        /// the notification channel descriptors. The expected syntax is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// Note that this
        /// [names](https://cloud.google.com/monitoring/api/v3#project_name) the parent
        /// container in which to look for the descriptors; to retrieve a single
        /// descriptor by name, use the
        /// [GetNotificationChannelDescriptor][google.monitoring.v3.NotificationChannelService.GetNotificationChannelDescriptor]
        /// operation, instead.
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
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="NotificationChannelDescriptor"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> ListNotificationChannelDescriptorsAsync(gagr::ProjectName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNotificationChannelDescriptorsRequest request = new ListNotificationChannelDescriptorsRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListNotificationChannelDescriptorsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the descriptors for supported channel types. The use of descriptors
        /// makes it possible for new channel types to be dynamically added.
        /// </summary>
        /// <param name="name">
        /// Required. The REST resource name of the parent from which to retrieve
        /// the notification channel descriptors. The expected syntax is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// Note that this
        /// [names](https://cloud.google.com/monitoring/api/v3#project_name) the parent
        /// container in which to look for the descriptors; to retrieve a single
        /// descriptor by name, use the
        /// [GetNotificationChannelDescriptor][google.monitoring.v3.NotificationChannelService.GetNotificationChannelDescriptor]
        /// operation, instead.
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
        /// <returns>A pageable sequence of <see cref="NotificationChannelDescriptor"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> ListNotificationChannelDescriptors(gagr::OrganizationName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNotificationChannelDescriptorsRequest request = new ListNotificationChannelDescriptorsRequest
            {
                OrganizationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListNotificationChannelDescriptors(request, callSettings);
        }

        /// <summary>
        /// Lists the descriptors for supported channel types. The use of descriptors
        /// makes it possible for new channel types to be dynamically added.
        /// </summary>
        /// <param name="name">
        /// Required. The REST resource name of the parent from which to retrieve
        /// the notification channel descriptors. The expected syntax is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// Note that this
        /// [names](https://cloud.google.com/monitoring/api/v3#project_name) the parent
        /// container in which to look for the descriptors; to retrieve a single
        /// descriptor by name, use the
        /// [GetNotificationChannelDescriptor][google.monitoring.v3.NotificationChannelService.GetNotificationChannelDescriptor]
        /// operation, instead.
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
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="NotificationChannelDescriptor"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> ListNotificationChannelDescriptorsAsync(gagr::OrganizationName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNotificationChannelDescriptorsRequest request = new ListNotificationChannelDescriptorsRequest
            {
                OrganizationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListNotificationChannelDescriptorsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the descriptors for supported channel types. The use of descriptors
        /// makes it possible for new channel types to be dynamically added.
        /// </summary>
        /// <param name="name">
        /// Required. The REST resource name of the parent from which to retrieve
        /// the notification channel descriptors. The expected syntax is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// Note that this
        /// [names](https://cloud.google.com/monitoring/api/v3#project_name) the parent
        /// container in which to look for the descriptors; to retrieve a single
        /// descriptor by name, use the
        /// [GetNotificationChannelDescriptor][google.monitoring.v3.NotificationChannelService.GetNotificationChannelDescriptor]
        /// operation, instead.
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
        /// <returns>A pageable sequence of <see cref="NotificationChannelDescriptor"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> ListNotificationChannelDescriptors(gagr::FolderName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNotificationChannelDescriptorsRequest request = new ListNotificationChannelDescriptorsRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListNotificationChannelDescriptors(request, callSettings);
        }

        /// <summary>
        /// Lists the descriptors for supported channel types. The use of descriptors
        /// makes it possible for new channel types to be dynamically added.
        /// </summary>
        /// <param name="name">
        /// Required. The REST resource name of the parent from which to retrieve
        /// the notification channel descriptors. The expected syntax is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// Note that this
        /// [names](https://cloud.google.com/monitoring/api/v3#project_name) the parent
        /// container in which to look for the descriptors; to retrieve a single
        /// descriptor by name, use the
        /// [GetNotificationChannelDescriptor][google.monitoring.v3.NotificationChannelService.GetNotificationChannelDescriptor]
        /// operation, instead.
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
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="NotificationChannelDescriptor"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> ListNotificationChannelDescriptorsAsync(gagr::FolderName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNotificationChannelDescriptorsRequest request = new ListNotificationChannelDescriptorsRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListNotificationChannelDescriptorsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the descriptors for supported channel types. The use of descriptors
        /// makes it possible for new channel types to be dynamically added.
        /// </summary>
        /// <param name="name">
        /// Required. The REST resource name of the parent from which to retrieve
        /// the notification channel descriptors. The expected syntax is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// Note that this
        /// [names](https://cloud.google.com/monitoring/api/v3#project_name) the parent
        /// container in which to look for the descriptors; to retrieve a single
        /// descriptor by name, use the
        /// [GetNotificationChannelDescriptor][google.monitoring.v3.NotificationChannelService.GetNotificationChannelDescriptor]
        /// operation, instead.
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
        /// <returns>A pageable sequence of <see cref="NotificationChannelDescriptor"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> ListNotificationChannelDescriptors(gax::IResourceName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNotificationChannelDescriptorsRequest request = new ListNotificationChannelDescriptorsRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListNotificationChannelDescriptors(request, callSettings);
        }

        /// <summary>
        /// Lists the descriptors for supported channel types. The use of descriptors
        /// makes it possible for new channel types to be dynamically added.
        /// </summary>
        /// <param name="name">
        /// Required. The REST resource name of the parent from which to retrieve
        /// the notification channel descriptors. The expected syntax is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// Note that this
        /// [names](https://cloud.google.com/monitoring/api/v3#project_name) the parent
        /// container in which to look for the descriptors; to retrieve a single
        /// descriptor by name, use the
        /// [GetNotificationChannelDescriptor][google.monitoring.v3.NotificationChannelService.GetNotificationChannelDescriptor]
        /// operation, instead.
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
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="NotificationChannelDescriptor"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> ListNotificationChannelDescriptorsAsync(gax::IResourceName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNotificationChannelDescriptorsRequest request = new ListNotificationChannelDescriptorsRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListNotificationChannelDescriptorsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a single channel descriptor. The descriptor indicates which fields
        /// are expected / permitted for a notification channel of the given type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationChannelDescriptor GetNotificationChannelDescriptor(GetNotificationChannelDescriptorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a single channel descriptor. The descriptor indicates which fields
        /// are expected / permitted for a notification channel of the given type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationChannelDescriptor> GetNotificationChannelDescriptorAsync(GetNotificationChannelDescriptorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a single channel descriptor. The descriptor indicates which fields
        /// are expected / permitted for a notification channel of the given type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationChannelDescriptor> GetNotificationChannelDescriptorAsync(GetNotificationChannelDescriptorRequest request, st::CancellationToken cancellationToken) =>
            GetNotificationChannelDescriptorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single channel descriptor. The descriptor indicates which fields
        /// are expected / permitted for a notification channel of the given type.
        /// </summary>
        /// <param name="name">
        /// Required. The channel type for which to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannelDescriptors/[CHANNEL_TYPE]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationChannelDescriptor GetNotificationChannelDescriptor(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotificationChannelDescriptor(new GetNotificationChannelDescriptorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single channel descriptor. The descriptor indicates which fields
        /// are expected / permitted for a notification channel of the given type.
        /// </summary>
        /// <param name="name">
        /// Required. The channel type for which to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannelDescriptors/[CHANNEL_TYPE]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationChannelDescriptor> GetNotificationChannelDescriptorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotificationChannelDescriptorAsync(new GetNotificationChannelDescriptorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single channel descriptor. The descriptor indicates which fields
        /// are expected / permitted for a notification channel of the given type.
        /// </summary>
        /// <param name="name">
        /// Required. The channel type for which to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannelDescriptors/[CHANNEL_TYPE]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationChannelDescriptor> GetNotificationChannelDescriptorAsync(string name, st::CancellationToken cancellationToken) =>
            GetNotificationChannelDescriptorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single channel descriptor. The descriptor indicates which fields
        /// are expected / permitted for a notification channel of the given type.
        /// </summary>
        /// <param name="name">
        /// Required. The channel type for which to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannelDescriptors/[CHANNEL_TYPE]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationChannelDescriptor GetNotificationChannelDescriptor(NotificationChannelDescriptorName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotificationChannelDescriptor(new GetNotificationChannelDescriptorRequest
            {
                NotificationChannelDescriptorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single channel descriptor. The descriptor indicates which fields
        /// are expected / permitted for a notification channel of the given type.
        /// </summary>
        /// <param name="name">
        /// Required. The channel type for which to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannelDescriptors/[CHANNEL_TYPE]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationChannelDescriptor> GetNotificationChannelDescriptorAsync(NotificationChannelDescriptorName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotificationChannelDescriptorAsync(new GetNotificationChannelDescriptorRequest
            {
                NotificationChannelDescriptorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single channel descriptor. The descriptor indicates which fields
        /// are expected / permitted for a notification channel of the given type.
        /// </summary>
        /// <param name="name">
        /// Required. The channel type for which to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannelDescriptors/[CHANNEL_TYPE]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationChannelDescriptor> GetNotificationChannelDescriptorAsync(NotificationChannelDescriptorName name, st::CancellationToken cancellationToken) =>
            GetNotificationChannelDescriptorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single channel descriptor. The descriptor indicates which fields
        /// are expected / permitted for a notification channel of the given type.
        /// </summary>
        /// <param name="name">
        /// Required. The channel type for which to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannelDescriptors/[CHANNEL_TYPE]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationChannelDescriptor GetNotificationChannelDescriptor(gax::IResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotificationChannelDescriptor(new GetNotificationChannelDescriptorRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single channel descriptor. The descriptor indicates which fields
        /// are expected / permitted for a notification channel of the given type.
        /// </summary>
        /// <param name="name">
        /// Required. The channel type for which to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannelDescriptors/[CHANNEL_TYPE]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationChannelDescriptor> GetNotificationChannelDescriptorAsync(gax::IResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotificationChannelDescriptorAsync(new GetNotificationChannelDescriptorRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single channel descriptor. The descriptor indicates which fields
        /// are expected / permitted for a notification channel of the given type.
        /// </summary>
        /// <param name="name">
        /// Required. The channel type for which to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannelDescriptors/[CHANNEL_TYPE]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationChannelDescriptor> GetNotificationChannelDescriptorAsync(gax::IResourceName name, st::CancellationToken cancellationToken) =>
            GetNotificationChannelDescriptorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the notification channels that have been created for the project.
        /// To list the types of notification channels that are supported, use
        /// the `ListNotificationChannelDescriptors` method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NotificationChannel"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNotificationChannelsResponse, NotificationChannel> ListNotificationChannels(ListNotificationChannelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the notification channels that have been created for the project.
        /// To list the types of notification channels that are supported, use
        /// the `ListNotificationChannelDescriptors` method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NotificationChannel"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNotificationChannelsResponse, NotificationChannel> ListNotificationChannelsAsync(ListNotificationChannelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the notification channels that have been created for the project.
        /// To list the types of notification channels that are supported, use
        /// the `ListNotificationChannelDescriptors` method.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// This names the container
        /// in which to look for the notification channels; it does not name a
        /// specific channel. To query a specific channel by REST resource name, use
        /// the
        /// [`GetNotificationChannel`][google.monitoring.v3.NotificationChannelService.GetNotificationChannel]
        /// operation.
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
        /// <returns>A pageable sequence of <see cref="NotificationChannel"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNotificationChannelsResponse, NotificationChannel> ListNotificationChannels(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNotificationChannelsRequest request = new ListNotificationChannelsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListNotificationChannels(request, callSettings);
        }

        /// <summary>
        /// Lists the notification channels that have been created for the project.
        /// To list the types of notification channels that are supported, use
        /// the `ListNotificationChannelDescriptors` method.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// This names the container
        /// in which to look for the notification channels; it does not name a
        /// specific channel. To query a specific channel by REST resource name, use
        /// the
        /// [`GetNotificationChannel`][google.monitoring.v3.NotificationChannelService.GetNotificationChannel]
        /// operation.
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
        /// <returns>A pageable asynchronous sequence of <see cref="NotificationChannel"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNotificationChannelsResponse, NotificationChannel> ListNotificationChannelsAsync(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNotificationChannelsRequest request = new ListNotificationChannelsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListNotificationChannelsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the notification channels that have been created for the project.
        /// To list the types of notification channels that are supported, use
        /// the `ListNotificationChannelDescriptors` method.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// This names the container
        /// in which to look for the notification channels; it does not name a
        /// specific channel. To query a specific channel by REST resource name, use
        /// the
        /// [`GetNotificationChannel`][google.monitoring.v3.NotificationChannelService.GetNotificationChannel]
        /// operation.
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
        /// <returns>A pageable sequence of <see cref="NotificationChannel"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNotificationChannelsResponse, NotificationChannel> ListNotificationChannels(gagr::ProjectName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNotificationChannelsRequest request = new ListNotificationChannelsRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListNotificationChannels(request, callSettings);
        }

        /// <summary>
        /// Lists the notification channels that have been created for the project.
        /// To list the types of notification channels that are supported, use
        /// the `ListNotificationChannelDescriptors` method.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// This names the container
        /// in which to look for the notification channels; it does not name a
        /// specific channel. To query a specific channel by REST resource name, use
        /// the
        /// [`GetNotificationChannel`][google.monitoring.v3.NotificationChannelService.GetNotificationChannel]
        /// operation.
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
        /// <returns>A pageable asynchronous sequence of <see cref="NotificationChannel"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNotificationChannelsResponse, NotificationChannel> ListNotificationChannelsAsync(gagr::ProjectName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNotificationChannelsRequest request = new ListNotificationChannelsRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListNotificationChannelsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the notification channels that have been created for the project.
        /// To list the types of notification channels that are supported, use
        /// the `ListNotificationChannelDescriptors` method.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// This names the container
        /// in which to look for the notification channels; it does not name a
        /// specific channel. To query a specific channel by REST resource name, use
        /// the
        /// [`GetNotificationChannel`][google.monitoring.v3.NotificationChannelService.GetNotificationChannel]
        /// operation.
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
        /// <returns>A pageable sequence of <see cref="NotificationChannel"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNotificationChannelsResponse, NotificationChannel> ListNotificationChannels(gagr::OrganizationName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNotificationChannelsRequest request = new ListNotificationChannelsRequest
            {
                OrganizationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListNotificationChannels(request, callSettings);
        }

        /// <summary>
        /// Lists the notification channels that have been created for the project.
        /// To list the types of notification channels that are supported, use
        /// the `ListNotificationChannelDescriptors` method.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// This names the container
        /// in which to look for the notification channels; it does not name a
        /// specific channel. To query a specific channel by REST resource name, use
        /// the
        /// [`GetNotificationChannel`][google.monitoring.v3.NotificationChannelService.GetNotificationChannel]
        /// operation.
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
        /// <returns>A pageable asynchronous sequence of <see cref="NotificationChannel"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNotificationChannelsResponse, NotificationChannel> ListNotificationChannelsAsync(gagr::OrganizationName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNotificationChannelsRequest request = new ListNotificationChannelsRequest
            {
                OrganizationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListNotificationChannelsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the notification channels that have been created for the project.
        /// To list the types of notification channels that are supported, use
        /// the `ListNotificationChannelDescriptors` method.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// This names the container
        /// in which to look for the notification channels; it does not name a
        /// specific channel. To query a specific channel by REST resource name, use
        /// the
        /// [`GetNotificationChannel`][google.monitoring.v3.NotificationChannelService.GetNotificationChannel]
        /// operation.
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
        /// <returns>A pageable sequence of <see cref="NotificationChannel"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNotificationChannelsResponse, NotificationChannel> ListNotificationChannels(gagr::FolderName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNotificationChannelsRequest request = new ListNotificationChannelsRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListNotificationChannels(request, callSettings);
        }

        /// <summary>
        /// Lists the notification channels that have been created for the project.
        /// To list the types of notification channels that are supported, use
        /// the `ListNotificationChannelDescriptors` method.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// This names the container
        /// in which to look for the notification channels; it does not name a
        /// specific channel. To query a specific channel by REST resource name, use
        /// the
        /// [`GetNotificationChannel`][google.monitoring.v3.NotificationChannelService.GetNotificationChannel]
        /// operation.
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
        /// <returns>A pageable asynchronous sequence of <see cref="NotificationChannel"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNotificationChannelsResponse, NotificationChannel> ListNotificationChannelsAsync(gagr::FolderName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNotificationChannelsRequest request = new ListNotificationChannelsRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListNotificationChannelsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the notification channels that have been created for the project.
        /// To list the types of notification channels that are supported, use
        /// the `ListNotificationChannelDescriptors` method.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// This names the container
        /// in which to look for the notification channels; it does not name a
        /// specific channel. To query a specific channel by REST resource name, use
        /// the
        /// [`GetNotificationChannel`][google.monitoring.v3.NotificationChannelService.GetNotificationChannel]
        /// operation.
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
        /// <returns>A pageable sequence of <see cref="NotificationChannel"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNotificationChannelsResponse, NotificationChannel> ListNotificationChannels(gax::IResourceName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNotificationChannelsRequest request = new ListNotificationChannelsRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListNotificationChannels(request, callSettings);
        }

        /// <summary>
        /// Lists the notification channels that have been created for the project.
        /// To list the types of notification channels that are supported, use
        /// the `ListNotificationChannelDescriptors` method.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// This names the container
        /// in which to look for the notification channels; it does not name a
        /// specific channel. To query a specific channel by REST resource name, use
        /// the
        /// [`GetNotificationChannel`][google.monitoring.v3.NotificationChannelService.GetNotificationChannel]
        /// operation.
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
        /// <returns>A pageable asynchronous sequence of <see cref="NotificationChannel"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNotificationChannelsResponse, NotificationChannel> ListNotificationChannelsAsync(gax::IResourceName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNotificationChannelsRequest request = new ListNotificationChannelsRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListNotificationChannelsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a single notification channel. The channel includes the relevant
        /// configuration details with which the channel was created. However, the
        /// response may truncate or omit passwords, API keys, or other private key
        /// matter and thus the response may not be 100% identical to the information
        /// that was supplied in the call to the create method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationChannel GetNotificationChannel(GetNotificationChannelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a single notification channel. The channel includes the relevant
        /// configuration details with which the channel was created. However, the
        /// response may truncate or omit passwords, API keys, or other private key
        /// matter and thus the response may not be 100% identical to the information
        /// that was supplied in the call to the create method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationChannel> GetNotificationChannelAsync(GetNotificationChannelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a single notification channel. The channel includes the relevant
        /// configuration details with which the channel was created. However, the
        /// response may truncate or omit passwords, API keys, or other private key
        /// matter and thus the response may not be 100% identical to the information
        /// that was supplied in the call to the create method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationChannel> GetNotificationChannelAsync(GetNotificationChannelRequest request, st::CancellationToken cancellationToken) =>
            GetNotificationChannelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single notification channel. The channel includes the relevant
        /// configuration details with which the channel was created. However, the
        /// response may truncate or omit passwords, API keys, or other private key
        /// matter and thus the response may not be 100% identical to the information
        /// that was supplied in the call to the create method.
        /// </summary>
        /// <param name="name">
        /// Required. The channel for which to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannels/[CHANNEL_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationChannel GetNotificationChannel(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotificationChannel(new GetNotificationChannelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single notification channel. The channel includes the relevant
        /// configuration details with which the channel was created. However, the
        /// response may truncate or omit passwords, API keys, or other private key
        /// matter and thus the response may not be 100% identical to the information
        /// that was supplied in the call to the create method.
        /// </summary>
        /// <param name="name">
        /// Required. The channel for which to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannels/[CHANNEL_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationChannel> GetNotificationChannelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotificationChannelAsync(new GetNotificationChannelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single notification channel. The channel includes the relevant
        /// configuration details with which the channel was created. However, the
        /// response may truncate or omit passwords, API keys, or other private key
        /// matter and thus the response may not be 100% identical to the information
        /// that was supplied in the call to the create method.
        /// </summary>
        /// <param name="name">
        /// Required. The channel for which to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannels/[CHANNEL_ID]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationChannel> GetNotificationChannelAsync(string name, st::CancellationToken cancellationToken) =>
            GetNotificationChannelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single notification channel. The channel includes the relevant
        /// configuration details with which the channel was created. However, the
        /// response may truncate or omit passwords, API keys, or other private key
        /// matter and thus the response may not be 100% identical to the information
        /// that was supplied in the call to the create method.
        /// </summary>
        /// <param name="name">
        /// Required. The channel for which to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannels/[CHANNEL_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationChannel GetNotificationChannel(NotificationChannelName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotificationChannel(new GetNotificationChannelRequest
            {
                NotificationChannelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single notification channel. The channel includes the relevant
        /// configuration details with which the channel was created. However, the
        /// response may truncate or omit passwords, API keys, or other private key
        /// matter and thus the response may not be 100% identical to the information
        /// that was supplied in the call to the create method.
        /// </summary>
        /// <param name="name">
        /// Required. The channel for which to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannels/[CHANNEL_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationChannel> GetNotificationChannelAsync(NotificationChannelName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotificationChannelAsync(new GetNotificationChannelRequest
            {
                NotificationChannelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single notification channel. The channel includes the relevant
        /// configuration details with which the channel was created. However, the
        /// response may truncate or omit passwords, API keys, or other private key
        /// matter and thus the response may not be 100% identical to the information
        /// that was supplied in the call to the create method.
        /// </summary>
        /// <param name="name">
        /// Required. The channel for which to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannels/[CHANNEL_ID]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationChannel> GetNotificationChannelAsync(NotificationChannelName name, st::CancellationToken cancellationToken) =>
            GetNotificationChannelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single notification channel. The channel includes the relevant
        /// configuration details with which the channel was created. However, the
        /// response may truncate or omit passwords, API keys, or other private key
        /// matter and thus the response may not be 100% identical to the information
        /// that was supplied in the call to the create method.
        /// </summary>
        /// <param name="name">
        /// Required. The channel for which to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannels/[CHANNEL_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationChannel GetNotificationChannel(gax::IResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotificationChannel(new GetNotificationChannelRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single notification channel. The channel includes the relevant
        /// configuration details with which the channel was created. However, the
        /// response may truncate or omit passwords, API keys, or other private key
        /// matter and thus the response may not be 100% identical to the information
        /// that was supplied in the call to the create method.
        /// </summary>
        /// <param name="name">
        /// Required. The channel for which to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannels/[CHANNEL_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationChannel> GetNotificationChannelAsync(gax::IResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotificationChannelAsync(new GetNotificationChannelRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single notification channel. The channel includes the relevant
        /// configuration details with which the channel was created. However, the
        /// response may truncate or omit passwords, API keys, or other private key
        /// matter and thus the response may not be 100% identical to the information
        /// that was supplied in the call to the create method.
        /// </summary>
        /// <param name="name">
        /// Required. The channel for which to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannels/[CHANNEL_ID]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationChannel> GetNotificationChannelAsync(gax::IResourceName name, st::CancellationToken cancellationToken) =>
            GetNotificationChannelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new notification channel, representing a single notification
        /// endpoint such as an email address, SMS number, or PagerDuty service.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationChannel CreateNotificationChannel(CreateNotificationChannelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new notification channel, representing a single notification
        /// endpoint such as an email address, SMS number, or PagerDuty service.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationChannel> CreateNotificationChannelAsync(CreateNotificationChannelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new notification channel, representing a single notification
        /// endpoint such as an email address, SMS number, or PagerDuty service.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationChannel> CreateNotificationChannelAsync(CreateNotificationChannelRequest request, st::CancellationToken cancellationToken) =>
            CreateNotificationChannelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new notification channel, representing a single notification
        /// endpoint such as an email address, SMS number, or PagerDuty service.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// This names the container into which the channel will be
        /// written, this does not name the newly created channel. The resulting
        /// channel's name will have a normalized version of this field as a prefix,
        /// but will add `/notificationChannels/[CHANNEL_ID]` to identify the channel.
        /// </param>
        /// <param name="notificationChannel">
        /// Required. The definition of the `NotificationChannel` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationChannel CreateNotificationChannel(string name, NotificationChannel notificationChannel, gaxgrpc::CallSettings callSettings = null) =>
            CreateNotificationChannel(new CreateNotificationChannelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                NotificationChannel = gax::GaxPreconditions.CheckNotNull(notificationChannel, nameof(notificationChannel)),
            }, callSettings);

        /// <summary>
        /// Creates a new notification channel, representing a single notification
        /// endpoint such as an email address, SMS number, or PagerDuty service.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// This names the container into which the channel will be
        /// written, this does not name the newly created channel. The resulting
        /// channel's name will have a normalized version of this field as a prefix,
        /// but will add `/notificationChannels/[CHANNEL_ID]` to identify the channel.
        /// </param>
        /// <param name="notificationChannel">
        /// Required. The definition of the `NotificationChannel` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationChannel> CreateNotificationChannelAsync(string name, NotificationChannel notificationChannel, gaxgrpc::CallSettings callSettings = null) =>
            CreateNotificationChannelAsync(new CreateNotificationChannelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                NotificationChannel = gax::GaxPreconditions.CheckNotNull(notificationChannel, nameof(notificationChannel)),
            }, callSettings);

        /// <summary>
        /// Creates a new notification channel, representing a single notification
        /// endpoint such as an email address, SMS number, or PagerDuty service.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// This names the container into which the channel will be
        /// written, this does not name the newly created channel. The resulting
        /// channel's name will have a normalized version of this field as a prefix,
        /// but will add `/notificationChannels/[CHANNEL_ID]` to identify the channel.
        /// </param>
        /// <param name="notificationChannel">
        /// Required. The definition of the `NotificationChannel` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationChannel> CreateNotificationChannelAsync(string name, NotificationChannel notificationChannel, st::CancellationToken cancellationToken) =>
            CreateNotificationChannelAsync(name, notificationChannel, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new notification channel, representing a single notification
        /// endpoint such as an email address, SMS number, or PagerDuty service.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// This names the container into which the channel will be
        /// written, this does not name the newly created channel. The resulting
        /// channel's name will have a normalized version of this field as a prefix,
        /// but will add `/notificationChannels/[CHANNEL_ID]` to identify the channel.
        /// </param>
        /// <param name="notificationChannel">
        /// Required. The definition of the `NotificationChannel` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationChannel CreateNotificationChannel(gagr::ProjectName name, NotificationChannel notificationChannel, gaxgrpc::CallSettings callSettings = null) =>
            CreateNotificationChannel(new CreateNotificationChannelRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                NotificationChannel = gax::GaxPreconditions.CheckNotNull(notificationChannel, nameof(notificationChannel)),
            }, callSettings);

        /// <summary>
        /// Creates a new notification channel, representing a single notification
        /// endpoint such as an email address, SMS number, or PagerDuty service.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// This names the container into which the channel will be
        /// written, this does not name the newly created channel. The resulting
        /// channel's name will have a normalized version of this field as a prefix,
        /// but will add `/notificationChannels/[CHANNEL_ID]` to identify the channel.
        /// </param>
        /// <param name="notificationChannel">
        /// Required. The definition of the `NotificationChannel` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationChannel> CreateNotificationChannelAsync(gagr::ProjectName name, NotificationChannel notificationChannel, gaxgrpc::CallSettings callSettings = null) =>
            CreateNotificationChannelAsync(new CreateNotificationChannelRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                NotificationChannel = gax::GaxPreconditions.CheckNotNull(notificationChannel, nameof(notificationChannel)),
            }, callSettings);

        /// <summary>
        /// Creates a new notification channel, representing a single notification
        /// endpoint such as an email address, SMS number, or PagerDuty service.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// This names the container into which the channel will be
        /// written, this does not name the newly created channel. The resulting
        /// channel's name will have a normalized version of this field as a prefix,
        /// but will add `/notificationChannels/[CHANNEL_ID]` to identify the channel.
        /// </param>
        /// <param name="notificationChannel">
        /// Required. The definition of the `NotificationChannel` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationChannel> CreateNotificationChannelAsync(gagr::ProjectName name, NotificationChannel notificationChannel, st::CancellationToken cancellationToken) =>
            CreateNotificationChannelAsync(name, notificationChannel, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new notification channel, representing a single notification
        /// endpoint such as an email address, SMS number, or PagerDuty service.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// This names the container into which the channel will be
        /// written, this does not name the newly created channel. The resulting
        /// channel's name will have a normalized version of this field as a prefix,
        /// but will add `/notificationChannels/[CHANNEL_ID]` to identify the channel.
        /// </param>
        /// <param name="notificationChannel">
        /// Required. The definition of the `NotificationChannel` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationChannel CreateNotificationChannel(gagr::OrganizationName name, NotificationChannel notificationChannel, gaxgrpc::CallSettings callSettings = null) =>
            CreateNotificationChannel(new CreateNotificationChannelRequest
            {
                OrganizationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                NotificationChannel = gax::GaxPreconditions.CheckNotNull(notificationChannel, nameof(notificationChannel)),
            }, callSettings);

        /// <summary>
        /// Creates a new notification channel, representing a single notification
        /// endpoint such as an email address, SMS number, or PagerDuty service.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// This names the container into which the channel will be
        /// written, this does not name the newly created channel. The resulting
        /// channel's name will have a normalized version of this field as a prefix,
        /// but will add `/notificationChannels/[CHANNEL_ID]` to identify the channel.
        /// </param>
        /// <param name="notificationChannel">
        /// Required. The definition of the `NotificationChannel` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationChannel> CreateNotificationChannelAsync(gagr::OrganizationName name, NotificationChannel notificationChannel, gaxgrpc::CallSettings callSettings = null) =>
            CreateNotificationChannelAsync(new CreateNotificationChannelRequest
            {
                OrganizationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                NotificationChannel = gax::GaxPreconditions.CheckNotNull(notificationChannel, nameof(notificationChannel)),
            }, callSettings);

        /// <summary>
        /// Creates a new notification channel, representing a single notification
        /// endpoint such as an email address, SMS number, or PagerDuty service.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// This names the container into which the channel will be
        /// written, this does not name the newly created channel. The resulting
        /// channel's name will have a normalized version of this field as a prefix,
        /// but will add `/notificationChannels/[CHANNEL_ID]` to identify the channel.
        /// </param>
        /// <param name="notificationChannel">
        /// Required. The definition of the `NotificationChannel` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationChannel> CreateNotificationChannelAsync(gagr::OrganizationName name, NotificationChannel notificationChannel, st::CancellationToken cancellationToken) =>
            CreateNotificationChannelAsync(name, notificationChannel, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new notification channel, representing a single notification
        /// endpoint such as an email address, SMS number, or PagerDuty service.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// This names the container into which the channel will be
        /// written, this does not name the newly created channel. The resulting
        /// channel's name will have a normalized version of this field as a prefix,
        /// but will add `/notificationChannels/[CHANNEL_ID]` to identify the channel.
        /// </param>
        /// <param name="notificationChannel">
        /// Required. The definition of the `NotificationChannel` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationChannel CreateNotificationChannel(gagr::FolderName name, NotificationChannel notificationChannel, gaxgrpc::CallSettings callSettings = null) =>
            CreateNotificationChannel(new CreateNotificationChannelRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                NotificationChannel = gax::GaxPreconditions.CheckNotNull(notificationChannel, nameof(notificationChannel)),
            }, callSettings);

        /// <summary>
        /// Creates a new notification channel, representing a single notification
        /// endpoint such as an email address, SMS number, or PagerDuty service.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// This names the container into which the channel will be
        /// written, this does not name the newly created channel. The resulting
        /// channel's name will have a normalized version of this field as a prefix,
        /// but will add `/notificationChannels/[CHANNEL_ID]` to identify the channel.
        /// </param>
        /// <param name="notificationChannel">
        /// Required. The definition of the `NotificationChannel` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationChannel> CreateNotificationChannelAsync(gagr::FolderName name, NotificationChannel notificationChannel, gaxgrpc::CallSettings callSettings = null) =>
            CreateNotificationChannelAsync(new CreateNotificationChannelRequest
            {
                FolderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                NotificationChannel = gax::GaxPreconditions.CheckNotNull(notificationChannel, nameof(notificationChannel)),
            }, callSettings);

        /// <summary>
        /// Creates a new notification channel, representing a single notification
        /// endpoint such as an email address, SMS number, or PagerDuty service.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// This names the container into which the channel will be
        /// written, this does not name the newly created channel. The resulting
        /// channel's name will have a normalized version of this field as a prefix,
        /// but will add `/notificationChannels/[CHANNEL_ID]` to identify the channel.
        /// </param>
        /// <param name="notificationChannel">
        /// Required. The definition of the `NotificationChannel` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationChannel> CreateNotificationChannelAsync(gagr::FolderName name, NotificationChannel notificationChannel, st::CancellationToken cancellationToken) =>
            CreateNotificationChannelAsync(name, notificationChannel, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new notification channel, representing a single notification
        /// endpoint such as an email address, SMS number, or PagerDuty service.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// This names the container into which the channel will be
        /// written, this does not name the newly created channel. The resulting
        /// channel's name will have a normalized version of this field as a prefix,
        /// but will add `/notificationChannels/[CHANNEL_ID]` to identify the channel.
        /// </param>
        /// <param name="notificationChannel">
        /// Required. The definition of the `NotificationChannel` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationChannel CreateNotificationChannel(gax::IResourceName name, NotificationChannel notificationChannel, gaxgrpc::CallSettings callSettings = null) =>
            CreateNotificationChannel(new CreateNotificationChannelRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                NotificationChannel = gax::GaxPreconditions.CheckNotNull(notificationChannel, nameof(notificationChannel)),
            }, callSettings);

        /// <summary>
        /// Creates a new notification channel, representing a single notification
        /// endpoint such as an email address, SMS number, or PagerDuty service.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// This names the container into which the channel will be
        /// written, this does not name the newly created channel. The resulting
        /// channel's name will have a normalized version of this field as a prefix,
        /// but will add `/notificationChannels/[CHANNEL_ID]` to identify the channel.
        /// </param>
        /// <param name="notificationChannel">
        /// Required. The definition of the `NotificationChannel` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationChannel> CreateNotificationChannelAsync(gax::IResourceName name, NotificationChannel notificationChannel, gaxgrpc::CallSettings callSettings = null) =>
            CreateNotificationChannelAsync(new CreateNotificationChannelRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                NotificationChannel = gax::GaxPreconditions.CheckNotNull(notificationChannel, nameof(notificationChannel)),
            }, callSettings);

        /// <summary>
        /// Creates a new notification channel, representing a single notification
        /// endpoint such as an email address, SMS number, or PagerDuty service.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [project](https://cloud.google.com/monitoring/api/v3#project_name) on which
        /// to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]
        /// 
        /// This names the container into which the channel will be
        /// written, this does not name the newly created channel. The resulting
        /// channel's name will have a normalized version of this field as a prefix,
        /// but will add `/notificationChannels/[CHANNEL_ID]` to identify the channel.
        /// </param>
        /// <param name="notificationChannel">
        /// Required. The definition of the `NotificationChannel` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationChannel> CreateNotificationChannelAsync(gax::IResourceName name, NotificationChannel notificationChannel, st::CancellationToken cancellationToken) =>
            CreateNotificationChannelAsync(name, notificationChannel, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a notification channel. Fields not specified in the field mask
        /// remain unchanged.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationChannel UpdateNotificationChannel(UpdateNotificationChannelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a notification channel. Fields not specified in the field mask
        /// remain unchanged.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationChannel> UpdateNotificationChannelAsync(UpdateNotificationChannelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a notification channel. Fields not specified in the field mask
        /// remain unchanged.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationChannel> UpdateNotificationChannelAsync(UpdateNotificationChannelRequest request, st::CancellationToken cancellationToken) =>
            UpdateNotificationChannelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a notification channel. Fields not specified in the field mask
        /// remain unchanged.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="notificationChannel">
        /// Required. A description of the changes to be applied to the specified
        /// notification channel. The description must provide a definition for
        /// fields to be updated; the names of these fields should also be
        /// included in the `update_mask`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationChannel UpdateNotificationChannel(wkt::FieldMask updateMask, NotificationChannel notificationChannel, gaxgrpc::CallSettings callSettings = null) =>
            UpdateNotificationChannel(new UpdateNotificationChannelRequest
            {
                UpdateMask = updateMask,
                NotificationChannel = gax::GaxPreconditions.CheckNotNull(notificationChannel, nameof(notificationChannel)),
            }, callSettings);

        /// <summary>
        /// Updates a notification channel. Fields not specified in the field mask
        /// remain unchanged.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="notificationChannel">
        /// Required. A description of the changes to be applied to the specified
        /// notification channel. The description must provide a definition for
        /// fields to be updated; the names of these fields should also be
        /// included in the `update_mask`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationChannel> UpdateNotificationChannelAsync(wkt::FieldMask updateMask, NotificationChannel notificationChannel, gaxgrpc::CallSettings callSettings = null) =>
            UpdateNotificationChannelAsync(new UpdateNotificationChannelRequest
            {
                UpdateMask = updateMask,
                NotificationChannel = gax::GaxPreconditions.CheckNotNull(notificationChannel, nameof(notificationChannel)),
            }, callSettings);

        /// <summary>
        /// Updates a notification channel. Fields not specified in the field mask
        /// remain unchanged.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="notificationChannel">
        /// Required. A description of the changes to be applied to the specified
        /// notification channel. The description must provide a definition for
        /// fields to be updated; the names of these fields should also be
        /// included in the `update_mask`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationChannel> UpdateNotificationChannelAsync(wkt::FieldMask updateMask, NotificationChannel notificationChannel, st::CancellationToken cancellationToken) =>
            UpdateNotificationChannelAsync(updateMask, notificationChannel, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a notification channel.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteNotificationChannel(DeleteNotificationChannelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a notification channel.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNotificationChannelAsync(DeleteNotificationChannelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a notification channel.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNotificationChannelAsync(DeleteNotificationChannelRequest request, st::CancellationToken cancellationToken) =>
            DeleteNotificationChannelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a notification channel.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="name">
        /// Required. The channel for which to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannels/[CHANNEL_ID]
        /// </param>
        /// <param name="force">
        /// If true, the notification channel will be deleted regardless of its
        /// use in alert policies (the policies will be updated to remove the
        /// channel). If false, channels that are still referenced by an existing
        /// alerting policy will fail to be deleted in a delete operation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteNotificationChannel(string name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNotificationChannel(new DeleteNotificationChannelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes a notification channel.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="name">
        /// Required. The channel for which to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannels/[CHANNEL_ID]
        /// </param>
        /// <param name="force">
        /// If true, the notification channel will be deleted regardless of its
        /// use in alert policies (the policies will be updated to remove the
        /// channel). If false, channels that are still referenced by an existing
        /// alerting policy will fail to be deleted in a delete operation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNotificationChannelAsync(string name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNotificationChannelAsync(new DeleteNotificationChannelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes a notification channel.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="name">
        /// Required. The channel for which to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannels/[CHANNEL_ID]
        /// </param>
        /// <param name="force">
        /// If true, the notification channel will be deleted regardless of its
        /// use in alert policies (the policies will be updated to remove the
        /// channel). If false, channels that are still referenced by an existing
        /// alerting policy will fail to be deleted in a delete operation.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNotificationChannelAsync(string name, bool force, st::CancellationToken cancellationToken) =>
            DeleteNotificationChannelAsync(name, force, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a notification channel.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="name">
        /// Required. The channel for which to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannels/[CHANNEL_ID]
        /// </param>
        /// <param name="force">
        /// If true, the notification channel will be deleted regardless of its
        /// use in alert policies (the policies will be updated to remove the
        /// channel). If false, channels that are still referenced by an existing
        /// alerting policy will fail to be deleted in a delete operation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteNotificationChannel(NotificationChannelName name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNotificationChannel(new DeleteNotificationChannelRequest
            {
                NotificationChannelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes a notification channel.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="name">
        /// Required. The channel for which to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannels/[CHANNEL_ID]
        /// </param>
        /// <param name="force">
        /// If true, the notification channel will be deleted regardless of its
        /// use in alert policies (the policies will be updated to remove the
        /// channel). If false, channels that are still referenced by an existing
        /// alerting policy will fail to be deleted in a delete operation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNotificationChannelAsync(NotificationChannelName name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNotificationChannelAsync(new DeleteNotificationChannelRequest
            {
                NotificationChannelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes a notification channel.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="name">
        /// Required. The channel for which to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannels/[CHANNEL_ID]
        /// </param>
        /// <param name="force">
        /// If true, the notification channel will be deleted regardless of its
        /// use in alert policies (the policies will be updated to remove the
        /// channel). If false, channels that are still referenced by an existing
        /// alerting policy will fail to be deleted in a delete operation.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNotificationChannelAsync(NotificationChannelName name, bool force, st::CancellationToken cancellationToken) =>
            DeleteNotificationChannelAsync(name, force, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a notification channel.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="name">
        /// Required. The channel for which to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannels/[CHANNEL_ID]
        /// </param>
        /// <param name="force">
        /// If true, the notification channel will be deleted regardless of its
        /// use in alert policies (the policies will be updated to remove the
        /// channel). If false, channels that are still referenced by an existing
        /// alerting policy will fail to be deleted in a delete operation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteNotificationChannel(gax::IResourceName name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNotificationChannel(new DeleteNotificationChannelRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes a notification channel.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="name">
        /// Required. The channel for which to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannels/[CHANNEL_ID]
        /// </param>
        /// <param name="force">
        /// If true, the notification channel will be deleted regardless of its
        /// use in alert policies (the policies will be updated to remove the
        /// channel). If false, channels that are still referenced by an existing
        /// alerting policy will fail to be deleted in a delete operation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNotificationChannelAsync(gax::IResourceName name, bool force, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNotificationChannelAsync(new DeleteNotificationChannelRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Force = force,
            }, callSettings);

        /// <summary>
        /// Deletes a notification channel.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="name">
        /// Required. The channel for which to execute the request. The format is:
        /// 
        /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannels/[CHANNEL_ID]
        /// </param>
        /// <param name="force">
        /// If true, the notification channel will be deleted regardless of its
        /// use in alert policies (the policies will be updated to remove the
        /// channel). If false, channels that are still referenced by an existing
        /// alerting policy will fail to be deleted in a delete operation.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNotificationChannelAsync(gax::IResourceName name, bool force, st::CancellationToken cancellationToken) =>
            DeleteNotificationChannelAsync(name, force, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Causes a verification code to be delivered to the channel. The code
        /// can then be supplied in `VerifyNotificationChannel` to verify the channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void SendNotificationChannelVerificationCode(SendNotificationChannelVerificationCodeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Causes a verification code to be delivered to the channel. The code
        /// can then be supplied in `VerifyNotificationChannel` to verify the channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task SendNotificationChannelVerificationCodeAsync(SendNotificationChannelVerificationCodeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Causes a verification code to be delivered to the channel. The code
        /// can then be supplied in `VerifyNotificationChannel` to verify the channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task SendNotificationChannelVerificationCodeAsync(SendNotificationChannelVerificationCodeRequest request, st::CancellationToken cancellationToken) =>
            SendNotificationChannelVerificationCodeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Causes a verification code to be delivered to the channel. The code
        /// can then be supplied in `VerifyNotificationChannel` to verify the channel.
        /// </summary>
        /// <param name="name">
        /// Required. The notification channel to which to send a verification code.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void SendNotificationChannelVerificationCode(string name, gaxgrpc::CallSettings callSettings = null) =>
            SendNotificationChannelVerificationCode(new SendNotificationChannelVerificationCodeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Causes a verification code to be delivered to the channel. The code
        /// can then be supplied in `VerifyNotificationChannel` to verify the channel.
        /// </summary>
        /// <param name="name">
        /// Required. The notification channel to which to send a verification code.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task SendNotificationChannelVerificationCodeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            SendNotificationChannelVerificationCodeAsync(new SendNotificationChannelVerificationCodeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Causes a verification code to be delivered to the channel. The code
        /// can then be supplied in `VerifyNotificationChannel` to verify the channel.
        /// </summary>
        /// <param name="name">
        /// Required. The notification channel to which to send a verification code.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task SendNotificationChannelVerificationCodeAsync(string name, st::CancellationToken cancellationToken) =>
            SendNotificationChannelVerificationCodeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Causes a verification code to be delivered to the channel. The code
        /// can then be supplied in `VerifyNotificationChannel` to verify the channel.
        /// </summary>
        /// <param name="name">
        /// Required. The notification channel to which to send a verification code.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void SendNotificationChannelVerificationCode(NotificationChannelName name, gaxgrpc::CallSettings callSettings = null) =>
            SendNotificationChannelVerificationCode(new SendNotificationChannelVerificationCodeRequest
            {
                NotificationChannelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Causes a verification code to be delivered to the channel. The code
        /// can then be supplied in `VerifyNotificationChannel` to verify the channel.
        /// </summary>
        /// <param name="name">
        /// Required. The notification channel to which to send a verification code.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task SendNotificationChannelVerificationCodeAsync(NotificationChannelName name, gaxgrpc::CallSettings callSettings = null) =>
            SendNotificationChannelVerificationCodeAsync(new SendNotificationChannelVerificationCodeRequest
            {
                NotificationChannelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Causes a verification code to be delivered to the channel. The code
        /// can then be supplied in `VerifyNotificationChannel` to verify the channel.
        /// </summary>
        /// <param name="name">
        /// Required. The notification channel to which to send a verification code.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task SendNotificationChannelVerificationCodeAsync(NotificationChannelName name, st::CancellationToken cancellationToken) =>
            SendNotificationChannelVerificationCodeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Causes a verification code to be delivered to the channel. The code
        /// can then be supplied in `VerifyNotificationChannel` to verify the channel.
        /// </summary>
        /// <param name="name">
        /// Required. The notification channel to which to send a verification code.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void SendNotificationChannelVerificationCode(gax::IResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            SendNotificationChannelVerificationCode(new SendNotificationChannelVerificationCodeRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Causes a verification code to be delivered to the channel. The code
        /// can then be supplied in `VerifyNotificationChannel` to verify the channel.
        /// </summary>
        /// <param name="name">
        /// Required. The notification channel to which to send a verification code.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task SendNotificationChannelVerificationCodeAsync(gax::IResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            SendNotificationChannelVerificationCodeAsync(new SendNotificationChannelVerificationCodeRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Causes a verification code to be delivered to the channel. The code
        /// can then be supplied in `VerifyNotificationChannel` to verify the channel.
        /// </summary>
        /// <param name="name">
        /// Required. The notification channel to which to send a verification code.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task SendNotificationChannelVerificationCodeAsync(gax::IResourceName name, st::CancellationToken cancellationToken) =>
            SendNotificationChannelVerificationCodeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Requests a verification code for an already verified channel that can then
        /// be used in a call to VerifyNotificationChannel() on a different channel
        /// with an equivalent identity in the same or in a different project. This
        /// makes it possible to copy a channel between projects without requiring
        /// manual reverification of the channel. If the channel is not in the
        /// verified state, this method will fail (in other words, this may only be
        /// used if the SendNotificationChannelVerificationCode and
        /// VerifyNotificationChannel paths have already been used to put the given
        /// channel into the verified state).
        /// 
        /// There is no guarantee that the verification codes returned by this method
        /// will be of a similar structure or form as the ones that are delivered
        /// to the channel via SendNotificationChannelVerificationCode; while
        /// VerifyNotificationChannel() will recognize both the codes delivered via
        /// SendNotificationChannelVerificationCode() and returned from
        /// GetNotificationChannelVerificationCode(), it is typically the case that
        /// the verification codes delivered via
        /// SendNotificationChannelVerificationCode() will be shorter and also
        /// have a shorter expiration (e.g. codes such as "G-123456") whereas
        /// GetVerificationCode() will typically return a much longer, websafe base
        /// 64 encoded string that has a longer expiration time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GetNotificationChannelVerificationCodeResponse GetNotificationChannelVerificationCode(GetNotificationChannelVerificationCodeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Requests a verification code for an already verified channel that can then
        /// be used in a call to VerifyNotificationChannel() on a different channel
        /// with an equivalent identity in the same or in a different project. This
        /// makes it possible to copy a channel between projects without requiring
        /// manual reverification of the channel. If the channel is not in the
        /// verified state, this method will fail (in other words, this may only be
        /// used if the SendNotificationChannelVerificationCode and
        /// VerifyNotificationChannel paths have already been used to put the given
        /// channel into the verified state).
        /// 
        /// There is no guarantee that the verification codes returned by this method
        /// will be of a similar structure or form as the ones that are delivered
        /// to the channel via SendNotificationChannelVerificationCode; while
        /// VerifyNotificationChannel() will recognize both the codes delivered via
        /// SendNotificationChannelVerificationCode() and returned from
        /// GetNotificationChannelVerificationCode(), it is typically the case that
        /// the verification codes delivered via
        /// SendNotificationChannelVerificationCode() will be shorter and also
        /// have a shorter expiration (e.g. codes such as "G-123456") whereas
        /// GetVerificationCode() will typically return a much longer, websafe base
        /// 64 encoded string that has a longer expiration time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetNotificationChannelVerificationCodeResponse> GetNotificationChannelVerificationCodeAsync(GetNotificationChannelVerificationCodeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Requests a verification code for an already verified channel that can then
        /// be used in a call to VerifyNotificationChannel() on a different channel
        /// with an equivalent identity in the same or in a different project. This
        /// makes it possible to copy a channel between projects without requiring
        /// manual reverification of the channel. If the channel is not in the
        /// verified state, this method will fail (in other words, this may only be
        /// used if the SendNotificationChannelVerificationCode and
        /// VerifyNotificationChannel paths have already been used to put the given
        /// channel into the verified state).
        /// 
        /// There is no guarantee that the verification codes returned by this method
        /// will be of a similar structure or form as the ones that are delivered
        /// to the channel via SendNotificationChannelVerificationCode; while
        /// VerifyNotificationChannel() will recognize both the codes delivered via
        /// SendNotificationChannelVerificationCode() and returned from
        /// GetNotificationChannelVerificationCode(), it is typically the case that
        /// the verification codes delivered via
        /// SendNotificationChannelVerificationCode() will be shorter and also
        /// have a shorter expiration (e.g. codes such as "G-123456") whereas
        /// GetVerificationCode() will typically return a much longer, websafe base
        /// 64 encoded string that has a longer expiration time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetNotificationChannelVerificationCodeResponse> GetNotificationChannelVerificationCodeAsync(GetNotificationChannelVerificationCodeRequest request, st::CancellationToken cancellationToken) =>
            GetNotificationChannelVerificationCodeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Requests a verification code for an already verified channel that can then
        /// be used in a call to VerifyNotificationChannel() on a different channel
        /// with an equivalent identity in the same or in a different project. This
        /// makes it possible to copy a channel between projects without requiring
        /// manual reverification of the channel. If the channel is not in the
        /// verified state, this method will fail (in other words, this may only be
        /// used if the SendNotificationChannelVerificationCode and
        /// VerifyNotificationChannel paths have already been used to put the given
        /// channel into the verified state).
        /// 
        /// There is no guarantee that the verification codes returned by this method
        /// will be of a similar structure or form as the ones that are delivered
        /// to the channel via SendNotificationChannelVerificationCode; while
        /// VerifyNotificationChannel() will recognize both the codes delivered via
        /// SendNotificationChannelVerificationCode() and returned from
        /// GetNotificationChannelVerificationCode(), it is typically the case that
        /// the verification codes delivered via
        /// SendNotificationChannelVerificationCode() will be shorter and also
        /// have a shorter expiration (e.g. codes such as "G-123456") whereas
        /// GetVerificationCode() will typically return a much longer, websafe base
        /// 64 encoded string that has a longer expiration time.
        /// </summary>
        /// <param name="name">
        /// Required. The notification channel for which a verification code is to be
        /// generated and retrieved. This must name a channel that is already verified;
        /// if the specified channel is not verified, the request will fail.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GetNotificationChannelVerificationCodeResponse GetNotificationChannelVerificationCode(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotificationChannelVerificationCode(new GetNotificationChannelVerificationCodeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Requests a verification code for an already verified channel that can then
        /// be used in a call to VerifyNotificationChannel() on a different channel
        /// with an equivalent identity in the same or in a different project. This
        /// makes it possible to copy a channel between projects without requiring
        /// manual reverification of the channel. If the channel is not in the
        /// verified state, this method will fail (in other words, this may only be
        /// used if the SendNotificationChannelVerificationCode and
        /// VerifyNotificationChannel paths have already been used to put the given
        /// channel into the verified state).
        /// 
        /// There is no guarantee that the verification codes returned by this method
        /// will be of a similar structure or form as the ones that are delivered
        /// to the channel via SendNotificationChannelVerificationCode; while
        /// VerifyNotificationChannel() will recognize both the codes delivered via
        /// SendNotificationChannelVerificationCode() and returned from
        /// GetNotificationChannelVerificationCode(), it is typically the case that
        /// the verification codes delivered via
        /// SendNotificationChannelVerificationCode() will be shorter and also
        /// have a shorter expiration (e.g. codes such as "G-123456") whereas
        /// GetVerificationCode() will typically return a much longer, websafe base
        /// 64 encoded string that has a longer expiration time.
        /// </summary>
        /// <param name="name">
        /// Required. The notification channel for which a verification code is to be
        /// generated and retrieved. This must name a channel that is already verified;
        /// if the specified channel is not verified, the request will fail.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetNotificationChannelVerificationCodeResponse> GetNotificationChannelVerificationCodeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotificationChannelVerificationCodeAsync(new GetNotificationChannelVerificationCodeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Requests a verification code for an already verified channel that can then
        /// be used in a call to VerifyNotificationChannel() on a different channel
        /// with an equivalent identity in the same or in a different project. This
        /// makes it possible to copy a channel between projects without requiring
        /// manual reverification of the channel. If the channel is not in the
        /// verified state, this method will fail (in other words, this may only be
        /// used if the SendNotificationChannelVerificationCode and
        /// VerifyNotificationChannel paths have already been used to put the given
        /// channel into the verified state).
        /// 
        /// There is no guarantee that the verification codes returned by this method
        /// will be of a similar structure or form as the ones that are delivered
        /// to the channel via SendNotificationChannelVerificationCode; while
        /// VerifyNotificationChannel() will recognize both the codes delivered via
        /// SendNotificationChannelVerificationCode() and returned from
        /// GetNotificationChannelVerificationCode(), it is typically the case that
        /// the verification codes delivered via
        /// SendNotificationChannelVerificationCode() will be shorter and also
        /// have a shorter expiration (e.g. codes such as "G-123456") whereas
        /// GetVerificationCode() will typically return a much longer, websafe base
        /// 64 encoded string that has a longer expiration time.
        /// </summary>
        /// <param name="name">
        /// Required. The notification channel for which a verification code is to be
        /// generated and retrieved. This must name a channel that is already verified;
        /// if the specified channel is not verified, the request will fail.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetNotificationChannelVerificationCodeResponse> GetNotificationChannelVerificationCodeAsync(string name, st::CancellationToken cancellationToken) =>
            GetNotificationChannelVerificationCodeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Requests a verification code for an already verified channel that can then
        /// be used in a call to VerifyNotificationChannel() on a different channel
        /// with an equivalent identity in the same or in a different project. This
        /// makes it possible to copy a channel between projects without requiring
        /// manual reverification of the channel. If the channel is not in the
        /// verified state, this method will fail (in other words, this may only be
        /// used if the SendNotificationChannelVerificationCode and
        /// VerifyNotificationChannel paths have already been used to put the given
        /// channel into the verified state).
        /// 
        /// There is no guarantee that the verification codes returned by this method
        /// will be of a similar structure or form as the ones that are delivered
        /// to the channel via SendNotificationChannelVerificationCode; while
        /// VerifyNotificationChannel() will recognize both the codes delivered via
        /// SendNotificationChannelVerificationCode() and returned from
        /// GetNotificationChannelVerificationCode(), it is typically the case that
        /// the verification codes delivered via
        /// SendNotificationChannelVerificationCode() will be shorter and also
        /// have a shorter expiration (e.g. codes such as "G-123456") whereas
        /// GetVerificationCode() will typically return a much longer, websafe base
        /// 64 encoded string that has a longer expiration time.
        /// </summary>
        /// <param name="name">
        /// Required. The notification channel for which a verification code is to be
        /// generated and retrieved. This must name a channel that is already verified;
        /// if the specified channel is not verified, the request will fail.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GetNotificationChannelVerificationCodeResponse GetNotificationChannelVerificationCode(NotificationChannelName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotificationChannelVerificationCode(new GetNotificationChannelVerificationCodeRequest
            {
                NotificationChannelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Requests a verification code for an already verified channel that can then
        /// be used in a call to VerifyNotificationChannel() on a different channel
        /// with an equivalent identity in the same or in a different project. This
        /// makes it possible to copy a channel between projects without requiring
        /// manual reverification of the channel. If the channel is not in the
        /// verified state, this method will fail (in other words, this may only be
        /// used if the SendNotificationChannelVerificationCode and
        /// VerifyNotificationChannel paths have already been used to put the given
        /// channel into the verified state).
        /// 
        /// There is no guarantee that the verification codes returned by this method
        /// will be of a similar structure or form as the ones that are delivered
        /// to the channel via SendNotificationChannelVerificationCode; while
        /// VerifyNotificationChannel() will recognize both the codes delivered via
        /// SendNotificationChannelVerificationCode() and returned from
        /// GetNotificationChannelVerificationCode(), it is typically the case that
        /// the verification codes delivered via
        /// SendNotificationChannelVerificationCode() will be shorter and also
        /// have a shorter expiration (e.g. codes such as "G-123456") whereas
        /// GetVerificationCode() will typically return a much longer, websafe base
        /// 64 encoded string that has a longer expiration time.
        /// </summary>
        /// <param name="name">
        /// Required. The notification channel for which a verification code is to be
        /// generated and retrieved. This must name a channel that is already verified;
        /// if the specified channel is not verified, the request will fail.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetNotificationChannelVerificationCodeResponse> GetNotificationChannelVerificationCodeAsync(NotificationChannelName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotificationChannelVerificationCodeAsync(new GetNotificationChannelVerificationCodeRequest
            {
                NotificationChannelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Requests a verification code for an already verified channel that can then
        /// be used in a call to VerifyNotificationChannel() on a different channel
        /// with an equivalent identity in the same or in a different project. This
        /// makes it possible to copy a channel between projects without requiring
        /// manual reverification of the channel. If the channel is not in the
        /// verified state, this method will fail (in other words, this may only be
        /// used if the SendNotificationChannelVerificationCode and
        /// VerifyNotificationChannel paths have already been used to put the given
        /// channel into the verified state).
        /// 
        /// There is no guarantee that the verification codes returned by this method
        /// will be of a similar structure or form as the ones that are delivered
        /// to the channel via SendNotificationChannelVerificationCode; while
        /// VerifyNotificationChannel() will recognize both the codes delivered via
        /// SendNotificationChannelVerificationCode() and returned from
        /// GetNotificationChannelVerificationCode(), it is typically the case that
        /// the verification codes delivered via
        /// SendNotificationChannelVerificationCode() will be shorter and also
        /// have a shorter expiration (e.g. codes such as "G-123456") whereas
        /// GetVerificationCode() will typically return a much longer, websafe base
        /// 64 encoded string that has a longer expiration time.
        /// </summary>
        /// <param name="name">
        /// Required. The notification channel for which a verification code is to be
        /// generated and retrieved. This must name a channel that is already verified;
        /// if the specified channel is not verified, the request will fail.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetNotificationChannelVerificationCodeResponse> GetNotificationChannelVerificationCodeAsync(NotificationChannelName name, st::CancellationToken cancellationToken) =>
            GetNotificationChannelVerificationCodeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Requests a verification code for an already verified channel that can then
        /// be used in a call to VerifyNotificationChannel() on a different channel
        /// with an equivalent identity in the same or in a different project. This
        /// makes it possible to copy a channel between projects without requiring
        /// manual reverification of the channel. If the channel is not in the
        /// verified state, this method will fail (in other words, this may only be
        /// used if the SendNotificationChannelVerificationCode and
        /// VerifyNotificationChannel paths have already been used to put the given
        /// channel into the verified state).
        /// 
        /// There is no guarantee that the verification codes returned by this method
        /// will be of a similar structure or form as the ones that are delivered
        /// to the channel via SendNotificationChannelVerificationCode; while
        /// VerifyNotificationChannel() will recognize both the codes delivered via
        /// SendNotificationChannelVerificationCode() and returned from
        /// GetNotificationChannelVerificationCode(), it is typically the case that
        /// the verification codes delivered via
        /// SendNotificationChannelVerificationCode() will be shorter and also
        /// have a shorter expiration (e.g. codes such as "G-123456") whereas
        /// GetVerificationCode() will typically return a much longer, websafe base
        /// 64 encoded string that has a longer expiration time.
        /// </summary>
        /// <param name="name">
        /// Required. The notification channel for which a verification code is to be
        /// generated and retrieved. This must name a channel that is already verified;
        /// if the specified channel is not verified, the request will fail.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GetNotificationChannelVerificationCodeResponse GetNotificationChannelVerificationCode(gax::IResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotificationChannelVerificationCode(new GetNotificationChannelVerificationCodeRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Requests a verification code for an already verified channel that can then
        /// be used in a call to VerifyNotificationChannel() on a different channel
        /// with an equivalent identity in the same or in a different project. This
        /// makes it possible to copy a channel between projects without requiring
        /// manual reverification of the channel. If the channel is not in the
        /// verified state, this method will fail (in other words, this may only be
        /// used if the SendNotificationChannelVerificationCode and
        /// VerifyNotificationChannel paths have already been used to put the given
        /// channel into the verified state).
        /// 
        /// There is no guarantee that the verification codes returned by this method
        /// will be of a similar structure or form as the ones that are delivered
        /// to the channel via SendNotificationChannelVerificationCode; while
        /// VerifyNotificationChannel() will recognize both the codes delivered via
        /// SendNotificationChannelVerificationCode() and returned from
        /// GetNotificationChannelVerificationCode(), it is typically the case that
        /// the verification codes delivered via
        /// SendNotificationChannelVerificationCode() will be shorter and also
        /// have a shorter expiration (e.g. codes such as "G-123456") whereas
        /// GetVerificationCode() will typically return a much longer, websafe base
        /// 64 encoded string that has a longer expiration time.
        /// </summary>
        /// <param name="name">
        /// Required. The notification channel for which a verification code is to be
        /// generated and retrieved. This must name a channel that is already verified;
        /// if the specified channel is not verified, the request will fail.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetNotificationChannelVerificationCodeResponse> GetNotificationChannelVerificationCodeAsync(gax::IResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotificationChannelVerificationCodeAsync(new GetNotificationChannelVerificationCodeRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Requests a verification code for an already verified channel that can then
        /// be used in a call to VerifyNotificationChannel() on a different channel
        /// with an equivalent identity in the same or in a different project. This
        /// makes it possible to copy a channel between projects without requiring
        /// manual reverification of the channel. If the channel is not in the
        /// verified state, this method will fail (in other words, this may only be
        /// used if the SendNotificationChannelVerificationCode and
        /// VerifyNotificationChannel paths have already been used to put the given
        /// channel into the verified state).
        /// 
        /// There is no guarantee that the verification codes returned by this method
        /// will be of a similar structure or form as the ones that are delivered
        /// to the channel via SendNotificationChannelVerificationCode; while
        /// VerifyNotificationChannel() will recognize both the codes delivered via
        /// SendNotificationChannelVerificationCode() and returned from
        /// GetNotificationChannelVerificationCode(), it is typically the case that
        /// the verification codes delivered via
        /// SendNotificationChannelVerificationCode() will be shorter and also
        /// have a shorter expiration (e.g. codes such as "G-123456") whereas
        /// GetVerificationCode() will typically return a much longer, websafe base
        /// 64 encoded string that has a longer expiration time.
        /// </summary>
        /// <param name="name">
        /// Required. The notification channel for which a verification code is to be
        /// generated and retrieved. This must name a channel that is already verified;
        /// if the specified channel is not verified, the request will fail.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetNotificationChannelVerificationCodeResponse> GetNotificationChannelVerificationCodeAsync(gax::IResourceName name, st::CancellationToken cancellationToken) =>
            GetNotificationChannelVerificationCodeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Verifies a `NotificationChannel` by proving receipt of the code
        /// delivered to the channel as a result of calling
        /// `SendNotificationChannelVerificationCode`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationChannel VerifyNotificationChannel(VerifyNotificationChannelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Verifies a `NotificationChannel` by proving receipt of the code
        /// delivered to the channel as a result of calling
        /// `SendNotificationChannelVerificationCode`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationChannel> VerifyNotificationChannelAsync(VerifyNotificationChannelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Verifies a `NotificationChannel` by proving receipt of the code
        /// delivered to the channel as a result of calling
        /// `SendNotificationChannelVerificationCode`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationChannel> VerifyNotificationChannelAsync(VerifyNotificationChannelRequest request, st::CancellationToken cancellationToken) =>
            VerifyNotificationChannelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Verifies a `NotificationChannel` by proving receipt of the code
        /// delivered to the channel as a result of calling
        /// `SendNotificationChannelVerificationCode`.
        /// </summary>
        /// <param name="name">
        /// Required. The notification channel to verify.
        /// </param>
        /// <param name="code">
        /// Required. The verification code that was delivered to the channel as
        /// a result of invoking the `SendNotificationChannelVerificationCode` API
        /// method or that was retrieved from a verified channel via
        /// `GetNotificationChannelVerificationCode`. For example, one might have
        /// "G-123456" or "TKNZGhhd2EyN3I1MnRnMjRv" (in general, one is only
        /// guaranteed that the code is valid UTF-8; one should not
        /// make any assumptions regarding the structure or format of the code).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationChannel VerifyNotificationChannel(string name, string code, gaxgrpc::CallSettings callSettings = null) =>
            VerifyNotificationChannel(new VerifyNotificationChannelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Code = gax::GaxPreconditions.CheckNotNullOrEmpty(code, nameof(code)),
            }, callSettings);

        /// <summary>
        /// Verifies a `NotificationChannel` by proving receipt of the code
        /// delivered to the channel as a result of calling
        /// `SendNotificationChannelVerificationCode`.
        /// </summary>
        /// <param name="name">
        /// Required. The notification channel to verify.
        /// </param>
        /// <param name="code">
        /// Required. The verification code that was delivered to the channel as
        /// a result of invoking the `SendNotificationChannelVerificationCode` API
        /// method or that was retrieved from a verified channel via
        /// `GetNotificationChannelVerificationCode`. For example, one might have
        /// "G-123456" or "TKNZGhhd2EyN3I1MnRnMjRv" (in general, one is only
        /// guaranteed that the code is valid UTF-8; one should not
        /// make any assumptions regarding the structure or format of the code).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationChannel> VerifyNotificationChannelAsync(string name, string code, gaxgrpc::CallSettings callSettings = null) =>
            VerifyNotificationChannelAsync(new VerifyNotificationChannelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Code = gax::GaxPreconditions.CheckNotNullOrEmpty(code, nameof(code)),
            }, callSettings);

        /// <summary>
        /// Verifies a `NotificationChannel` by proving receipt of the code
        /// delivered to the channel as a result of calling
        /// `SendNotificationChannelVerificationCode`.
        /// </summary>
        /// <param name="name">
        /// Required. The notification channel to verify.
        /// </param>
        /// <param name="code">
        /// Required. The verification code that was delivered to the channel as
        /// a result of invoking the `SendNotificationChannelVerificationCode` API
        /// method or that was retrieved from a verified channel via
        /// `GetNotificationChannelVerificationCode`. For example, one might have
        /// "G-123456" or "TKNZGhhd2EyN3I1MnRnMjRv" (in general, one is only
        /// guaranteed that the code is valid UTF-8; one should not
        /// make any assumptions regarding the structure or format of the code).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationChannel> VerifyNotificationChannelAsync(string name, string code, st::CancellationToken cancellationToken) =>
            VerifyNotificationChannelAsync(name, code, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Verifies a `NotificationChannel` by proving receipt of the code
        /// delivered to the channel as a result of calling
        /// `SendNotificationChannelVerificationCode`.
        /// </summary>
        /// <param name="name">
        /// Required. The notification channel to verify.
        /// </param>
        /// <param name="code">
        /// Required. The verification code that was delivered to the channel as
        /// a result of invoking the `SendNotificationChannelVerificationCode` API
        /// method or that was retrieved from a verified channel via
        /// `GetNotificationChannelVerificationCode`. For example, one might have
        /// "G-123456" or "TKNZGhhd2EyN3I1MnRnMjRv" (in general, one is only
        /// guaranteed that the code is valid UTF-8; one should not
        /// make any assumptions regarding the structure or format of the code).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationChannel VerifyNotificationChannel(NotificationChannelName name, string code, gaxgrpc::CallSettings callSettings = null) =>
            VerifyNotificationChannel(new VerifyNotificationChannelRequest
            {
                NotificationChannelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Code = gax::GaxPreconditions.CheckNotNullOrEmpty(code, nameof(code)),
            }, callSettings);

        /// <summary>
        /// Verifies a `NotificationChannel` by proving receipt of the code
        /// delivered to the channel as a result of calling
        /// `SendNotificationChannelVerificationCode`.
        /// </summary>
        /// <param name="name">
        /// Required. The notification channel to verify.
        /// </param>
        /// <param name="code">
        /// Required. The verification code that was delivered to the channel as
        /// a result of invoking the `SendNotificationChannelVerificationCode` API
        /// method or that was retrieved from a verified channel via
        /// `GetNotificationChannelVerificationCode`. For example, one might have
        /// "G-123456" or "TKNZGhhd2EyN3I1MnRnMjRv" (in general, one is only
        /// guaranteed that the code is valid UTF-8; one should not
        /// make any assumptions regarding the structure or format of the code).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationChannel> VerifyNotificationChannelAsync(NotificationChannelName name, string code, gaxgrpc::CallSettings callSettings = null) =>
            VerifyNotificationChannelAsync(new VerifyNotificationChannelRequest
            {
                NotificationChannelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Code = gax::GaxPreconditions.CheckNotNullOrEmpty(code, nameof(code)),
            }, callSettings);

        /// <summary>
        /// Verifies a `NotificationChannel` by proving receipt of the code
        /// delivered to the channel as a result of calling
        /// `SendNotificationChannelVerificationCode`.
        /// </summary>
        /// <param name="name">
        /// Required. The notification channel to verify.
        /// </param>
        /// <param name="code">
        /// Required. The verification code that was delivered to the channel as
        /// a result of invoking the `SendNotificationChannelVerificationCode` API
        /// method or that was retrieved from a verified channel via
        /// `GetNotificationChannelVerificationCode`. For example, one might have
        /// "G-123456" or "TKNZGhhd2EyN3I1MnRnMjRv" (in general, one is only
        /// guaranteed that the code is valid UTF-8; one should not
        /// make any assumptions regarding the structure or format of the code).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationChannel> VerifyNotificationChannelAsync(NotificationChannelName name, string code, st::CancellationToken cancellationToken) =>
            VerifyNotificationChannelAsync(name, code, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Verifies a `NotificationChannel` by proving receipt of the code
        /// delivered to the channel as a result of calling
        /// `SendNotificationChannelVerificationCode`.
        /// </summary>
        /// <param name="name">
        /// Required. The notification channel to verify.
        /// </param>
        /// <param name="code">
        /// Required. The verification code that was delivered to the channel as
        /// a result of invoking the `SendNotificationChannelVerificationCode` API
        /// method or that was retrieved from a verified channel via
        /// `GetNotificationChannelVerificationCode`. For example, one might have
        /// "G-123456" or "TKNZGhhd2EyN3I1MnRnMjRv" (in general, one is only
        /// guaranteed that the code is valid UTF-8; one should not
        /// make any assumptions regarding the structure or format of the code).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationChannel VerifyNotificationChannel(gax::IResourceName name, string code, gaxgrpc::CallSettings callSettings = null) =>
            VerifyNotificationChannel(new VerifyNotificationChannelRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Code = gax::GaxPreconditions.CheckNotNullOrEmpty(code, nameof(code)),
            }, callSettings);

        /// <summary>
        /// Verifies a `NotificationChannel` by proving receipt of the code
        /// delivered to the channel as a result of calling
        /// `SendNotificationChannelVerificationCode`.
        /// </summary>
        /// <param name="name">
        /// Required. The notification channel to verify.
        /// </param>
        /// <param name="code">
        /// Required. The verification code that was delivered to the channel as
        /// a result of invoking the `SendNotificationChannelVerificationCode` API
        /// method or that was retrieved from a verified channel via
        /// `GetNotificationChannelVerificationCode`. For example, one might have
        /// "G-123456" or "TKNZGhhd2EyN3I1MnRnMjRv" (in general, one is only
        /// guaranteed that the code is valid UTF-8; one should not
        /// make any assumptions regarding the structure or format of the code).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationChannel> VerifyNotificationChannelAsync(gax::IResourceName name, string code, gaxgrpc::CallSettings callSettings = null) =>
            VerifyNotificationChannelAsync(new VerifyNotificationChannelRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Code = gax::GaxPreconditions.CheckNotNullOrEmpty(code, nameof(code)),
            }, callSettings);

        /// <summary>
        /// Verifies a `NotificationChannel` by proving receipt of the code
        /// delivered to the channel as a result of calling
        /// `SendNotificationChannelVerificationCode`.
        /// </summary>
        /// <param name="name">
        /// Required. The notification channel to verify.
        /// </param>
        /// <param name="code">
        /// Required. The verification code that was delivered to the channel as
        /// a result of invoking the `SendNotificationChannelVerificationCode` API
        /// method or that was retrieved from a verified channel via
        /// `GetNotificationChannelVerificationCode`. For example, one might have
        /// "G-123456" or "TKNZGhhd2EyN3I1MnRnMjRv" (in general, one is only
        /// guaranteed that the code is valid UTF-8; one should not
        /// make any assumptions regarding the structure or format of the code).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationChannel> VerifyNotificationChannelAsync(gax::IResourceName name, string code, st::CancellationToken cancellationToken) =>
            VerifyNotificationChannelAsync(name, code, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>NotificationChannelService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The Notification Channel API provides access to configuration that
    /// controls how messages related to incidents are sent.
    /// </remarks>
    public sealed partial class NotificationChannelServiceClientImpl : NotificationChannelServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListNotificationChannelDescriptorsRequest, ListNotificationChannelDescriptorsResponse> _callListNotificationChannelDescriptors;

        private readonly gaxgrpc::ApiCall<GetNotificationChannelDescriptorRequest, NotificationChannelDescriptor> _callGetNotificationChannelDescriptor;

        private readonly gaxgrpc::ApiCall<ListNotificationChannelsRequest, ListNotificationChannelsResponse> _callListNotificationChannels;

        private readonly gaxgrpc::ApiCall<GetNotificationChannelRequest, NotificationChannel> _callGetNotificationChannel;

        private readonly gaxgrpc::ApiCall<CreateNotificationChannelRequest, NotificationChannel> _callCreateNotificationChannel;

        private readonly gaxgrpc::ApiCall<UpdateNotificationChannelRequest, NotificationChannel> _callUpdateNotificationChannel;

        private readonly gaxgrpc::ApiCall<DeleteNotificationChannelRequest, wkt::Empty> _callDeleteNotificationChannel;

        private readonly gaxgrpc::ApiCall<SendNotificationChannelVerificationCodeRequest, wkt::Empty> _callSendNotificationChannelVerificationCode;

        private readonly gaxgrpc::ApiCall<GetNotificationChannelVerificationCodeRequest, GetNotificationChannelVerificationCodeResponse> _callGetNotificationChannelVerificationCode;

        private readonly gaxgrpc::ApiCall<VerifyNotificationChannelRequest, NotificationChannel> _callVerifyNotificationChannel;

        /// <summary>
        /// Constructs a client wrapper for the NotificationChannelService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="NotificationChannelServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public NotificationChannelServiceClientImpl(NotificationChannelService.NotificationChannelServiceClient grpcClient, NotificationChannelServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            NotificationChannelServiceSettings effectiveSettings = settings ?? NotificationChannelServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callListNotificationChannelDescriptors = clientHelper.BuildApiCall<ListNotificationChannelDescriptorsRequest, ListNotificationChannelDescriptorsResponse>("ListNotificationChannelDescriptors", grpcClient.ListNotificationChannelDescriptorsAsync, grpcClient.ListNotificationChannelDescriptors, effectiveSettings.ListNotificationChannelDescriptorsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callListNotificationChannelDescriptors);
            Modify_ListNotificationChannelDescriptorsApiCall(ref _callListNotificationChannelDescriptors);
            _callGetNotificationChannelDescriptor = clientHelper.BuildApiCall<GetNotificationChannelDescriptorRequest, NotificationChannelDescriptor>("GetNotificationChannelDescriptor", grpcClient.GetNotificationChannelDescriptorAsync, grpcClient.GetNotificationChannelDescriptor, effectiveSettings.GetNotificationChannelDescriptorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetNotificationChannelDescriptor);
            Modify_GetNotificationChannelDescriptorApiCall(ref _callGetNotificationChannelDescriptor);
            _callListNotificationChannels = clientHelper.BuildApiCall<ListNotificationChannelsRequest, ListNotificationChannelsResponse>("ListNotificationChannels", grpcClient.ListNotificationChannelsAsync, grpcClient.ListNotificationChannels, effectiveSettings.ListNotificationChannelsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callListNotificationChannels);
            Modify_ListNotificationChannelsApiCall(ref _callListNotificationChannels);
            _callGetNotificationChannel = clientHelper.BuildApiCall<GetNotificationChannelRequest, NotificationChannel>("GetNotificationChannel", grpcClient.GetNotificationChannelAsync, grpcClient.GetNotificationChannel, effectiveSettings.GetNotificationChannelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetNotificationChannel);
            Modify_GetNotificationChannelApiCall(ref _callGetNotificationChannel);
            _callCreateNotificationChannel = clientHelper.BuildApiCall<CreateNotificationChannelRequest, NotificationChannel>("CreateNotificationChannel", grpcClient.CreateNotificationChannelAsync, grpcClient.CreateNotificationChannel, effectiveSettings.CreateNotificationChannelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCreateNotificationChannel);
            Modify_CreateNotificationChannelApiCall(ref _callCreateNotificationChannel);
            _callUpdateNotificationChannel = clientHelper.BuildApiCall<UpdateNotificationChannelRequest, NotificationChannel>("UpdateNotificationChannel", grpcClient.UpdateNotificationChannelAsync, grpcClient.UpdateNotificationChannel, effectiveSettings.UpdateNotificationChannelSettings).WithGoogleRequestParam("notification_channel.name", request => request.NotificationChannel?.Name);
            Modify_ApiCall(ref _callUpdateNotificationChannel);
            Modify_UpdateNotificationChannelApiCall(ref _callUpdateNotificationChannel);
            _callDeleteNotificationChannel = clientHelper.BuildApiCall<DeleteNotificationChannelRequest, wkt::Empty>("DeleteNotificationChannel", grpcClient.DeleteNotificationChannelAsync, grpcClient.DeleteNotificationChannel, effectiveSettings.DeleteNotificationChannelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteNotificationChannel);
            Modify_DeleteNotificationChannelApiCall(ref _callDeleteNotificationChannel);
            _callSendNotificationChannelVerificationCode = clientHelper.BuildApiCall<SendNotificationChannelVerificationCodeRequest, wkt::Empty>("SendNotificationChannelVerificationCode", grpcClient.SendNotificationChannelVerificationCodeAsync, grpcClient.SendNotificationChannelVerificationCode, effectiveSettings.SendNotificationChannelVerificationCodeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callSendNotificationChannelVerificationCode);
            Modify_SendNotificationChannelVerificationCodeApiCall(ref _callSendNotificationChannelVerificationCode);
            _callGetNotificationChannelVerificationCode = clientHelper.BuildApiCall<GetNotificationChannelVerificationCodeRequest, GetNotificationChannelVerificationCodeResponse>("GetNotificationChannelVerificationCode", grpcClient.GetNotificationChannelVerificationCodeAsync, grpcClient.GetNotificationChannelVerificationCode, effectiveSettings.GetNotificationChannelVerificationCodeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetNotificationChannelVerificationCode);
            Modify_GetNotificationChannelVerificationCodeApiCall(ref _callGetNotificationChannelVerificationCode);
            _callVerifyNotificationChannel = clientHelper.BuildApiCall<VerifyNotificationChannelRequest, NotificationChannel>("VerifyNotificationChannel", grpcClient.VerifyNotificationChannelAsync, grpcClient.VerifyNotificationChannel, effectiveSettings.VerifyNotificationChannelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callVerifyNotificationChannel);
            Modify_VerifyNotificationChannelApiCall(ref _callVerifyNotificationChannel);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListNotificationChannelDescriptorsApiCall(ref gaxgrpc::ApiCall<ListNotificationChannelDescriptorsRequest, ListNotificationChannelDescriptorsResponse> call);

        partial void Modify_GetNotificationChannelDescriptorApiCall(ref gaxgrpc::ApiCall<GetNotificationChannelDescriptorRequest, NotificationChannelDescriptor> call);

        partial void Modify_ListNotificationChannelsApiCall(ref gaxgrpc::ApiCall<ListNotificationChannelsRequest, ListNotificationChannelsResponse> call);

        partial void Modify_GetNotificationChannelApiCall(ref gaxgrpc::ApiCall<GetNotificationChannelRequest, NotificationChannel> call);

        partial void Modify_CreateNotificationChannelApiCall(ref gaxgrpc::ApiCall<CreateNotificationChannelRequest, NotificationChannel> call);

        partial void Modify_UpdateNotificationChannelApiCall(ref gaxgrpc::ApiCall<UpdateNotificationChannelRequest, NotificationChannel> call);

        partial void Modify_DeleteNotificationChannelApiCall(ref gaxgrpc::ApiCall<DeleteNotificationChannelRequest, wkt::Empty> call);

        partial void Modify_SendNotificationChannelVerificationCodeApiCall(ref gaxgrpc::ApiCall<SendNotificationChannelVerificationCodeRequest, wkt::Empty> call);

        partial void Modify_GetNotificationChannelVerificationCodeApiCall(ref gaxgrpc::ApiCall<GetNotificationChannelVerificationCodeRequest, GetNotificationChannelVerificationCodeResponse> call);

        partial void Modify_VerifyNotificationChannelApiCall(ref gaxgrpc::ApiCall<VerifyNotificationChannelRequest, NotificationChannel> call);

        partial void OnConstruction(NotificationChannelService.NotificationChannelServiceClient grpcClient, NotificationChannelServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC NotificationChannelService client</summary>
        public override NotificationChannelService.NotificationChannelServiceClient GrpcClient { get; }

        partial void Modify_ListNotificationChannelDescriptorsRequest(ref ListNotificationChannelDescriptorsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetNotificationChannelDescriptorRequest(ref GetNotificationChannelDescriptorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListNotificationChannelsRequest(ref ListNotificationChannelsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetNotificationChannelRequest(ref GetNotificationChannelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateNotificationChannelRequest(ref CreateNotificationChannelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateNotificationChannelRequest(ref UpdateNotificationChannelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteNotificationChannelRequest(ref DeleteNotificationChannelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SendNotificationChannelVerificationCodeRequest(ref SendNotificationChannelVerificationCodeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetNotificationChannelVerificationCodeRequest(ref GetNotificationChannelVerificationCodeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_VerifyNotificationChannelRequest(ref VerifyNotificationChannelRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists the descriptors for supported channel types. The use of descriptors
        /// makes it possible for new channel types to be dynamically added.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NotificationChannelDescriptor"/> resources.</returns>
        public override gax::PagedEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> ListNotificationChannelDescriptors(ListNotificationChannelDescriptorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNotificationChannelDescriptorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListNotificationChannelDescriptorsRequest, ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor>(_callListNotificationChannelDescriptors, request, callSettings);
        }

        /// <summary>
        /// Lists the descriptors for supported channel types. The use of descriptors
        /// makes it possible for new channel types to be dynamically added.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="NotificationChannelDescriptor"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> ListNotificationChannelDescriptorsAsync(ListNotificationChannelDescriptorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNotificationChannelDescriptorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListNotificationChannelDescriptorsRequest, ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor>(_callListNotificationChannelDescriptors, request, callSettings);
        }

        /// <summary>
        /// Gets a single channel descriptor. The descriptor indicates which fields
        /// are expected / permitted for a notification channel of the given type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override NotificationChannelDescriptor GetNotificationChannelDescriptor(GetNotificationChannelDescriptorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNotificationChannelDescriptorRequest(ref request, ref callSettings);
            return _callGetNotificationChannelDescriptor.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a single channel descriptor. The descriptor indicates which fields
        /// are expected / permitted for a notification channel of the given type.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<NotificationChannelDescriptor> GetNotificationChannelDescriptorAsync(GetNotificationChannelDescriptorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNotificationChannelDescriptorRequest(ref request, ref callSettings);
            return _callGetNotificationChannelDescriptor.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the notification channels that have been created for the project.
        /// To list the types of notification channels that are supported, use
        /// the `ListNotificationChannelDescriptors` method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NotificationChannel"/> resources.</returns>
        public override gax::PagedEnumerable<ListNotificationChannelsResponse, NotificationChannel> ListNotificationChannels(ListNotificationChannelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNotificationChannelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListNotificationChannelsRequest, ListNotificationChannelsResponse, NotificationChannel>(_callListNotificationChannels, request, callSettings);
        }

        /// <summary>
        /// Lists the notification channels that have been created for the project.
        /// To list the types of notification channels that are supported, use
        /// the `ListNotificationChannelDescriptors` method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NotificationChannel"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListNotificationChannelsResponse, NotificationChannel> ListNotificationChannelsAsync(ListNotificationChannelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNotificationChannelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListNotificationChannelsRequest, ListNotificationChannelsResponse, NotificationChannel>(_callListNotificationChannels, request, callSettings);
        }

        /// <summary>
        /// Gets a single notification channel. The channel includes the relevant
        /// configuration details with which the channel was created. However, the
        /// response may truncate or omit passwords, API keys, or other private key
        /// matter and thus the response may not be 100% identical to the information
        /// that was supplied in the call to the create method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override NotificationChannel GetNotificationChannel(GetNotificationChannelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNotificationChannelRequest(ref request, ref callSettings);
            return _callGetNotificationChannel.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a single notification channel. The channel includes the relevant
        /// configuration details with which the channel was created. However, the
        /// response may truncate or omit passwords, API keys, or other private key
        /// matter and thus the response may not be 100% identical to the information
        /// that was supplied in the call to the create method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<NotificationChannel> GetNotificationChannelAsync(GetNotificationChannelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNotificationChannelRequest(ref request, ref callSettings);
            return _callGetNotificationChannel.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new notification channel, representing a single notification
        /// endpoint such as an email address, SMS number, or PagerDuty service.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override NotificationChannel CreateNotificationChannel(CreateNotificationChannelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateNotificationChannelRequest(ref request, ref callSettings);
            return _callCreateNotificationChannel.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new notification channel, representing a single notification
        /// endpoint such as an email address, SMS number, or PagerDuty service.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<NotificationChannel> CreateNotificationChannelAsync(CreateNotificationChannelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateNotificationChannelRequest(ref request, ref callSettings);
            return _callCreateNotificationChannel.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a notification channel. Fields not specified in the field mask
        /// remain unchanged.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override NotificationChannel UpdateNotificationChannel(UpdateNotificationChannelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateNotificationChannelRequest(ref request, ref callSettings);
            return _callUpdateNotificationChannel.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a notification channel. Fields not specified in the field mask
        /// remain unchanged.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<NotificationChannel> UpdateNotificationChannelAsync(UpdateNotificationChannelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateNotificationChannelRequest(ref request, ref callSettings);
            return _callUpdateNotificationChannel.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a notification channel.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteNotificationChannel(DeleteNotificationChannelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteNotificationChannelRequest(ref request, ref callSettings);
            _callDeleteNotificationChannel.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a notification channel.
        /// 
        /// Design your application to single-thread API calls that modify the state of
        /// notification channels in a single project. This includes calls to
        /// CreateNotificationChannel, DeleteNotificationChannel and
        /// UpdateNotificationChannel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteNotificationChannelAsync(DeleteNotificationChannelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteNotificationChannelRequest(ref request, ref callSettings);
            return _callDeleteNotificationChannel.Async(request, callSettings);
        }

        /// <summary>
        /// Causes a verification code to be delivered to the channel. The code
        /// can then be supplied in `VerifyNotificationChannel` to verify the channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void SendNotificationChannelVerificationCode(SendNotificationChannelVerificationCodeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SendNotificationChannelVerificationCodeRequest(ref request, ref callSettings);
            _callSendNotificationChannelVerificationCode.Sync(request, callSettings);
        }

        /// <summary>
        /// Causes a verification code to be delivered to the channel. The code
        /// can then be supplied in `VerifyNotificationChannel` to verify the channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task SendNotificationChannelVerificationCodeAsync(SendNotificationChannelVerificationCodeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SendNotificationChannelVerificationCodeRequest(ref request, ref callSettings);
            return _callSendNotificationChannelVerificationCode.Async(request, callSettings);
        }

        /// <summary>
        /// Requests a verification code for an already verified channel that can then
        /// be used in a call to VerifyNotificationChannel() on a different channel
        /// with an equivalent identity in the same or in a different project. This
        /// makes it possible to copy a channel between projects without requiring
        /// manual reverification of the channel. If the channel is not in the
        /// verified state, this method will fail (in other words, this may only be
        /// used if the SendNotificationChannelVerificationCode and
        /// VerifyNotificationChannel paths have already been used to put the given
        /// channel into the verified state).
        /// 
        /// There is no guarantee that the verification codes returned by this method
        /// will be of a similar structure or form as the ones that are delivered
        /// to the channel via SendNotificationChannelVerificationCode; while
        /// VerifyNotificationChannel() will recognize both the codes delivered via
        /// SendNotificationChannelVerificationCode() and returned from
        /// GetNotificationChannelVerificationCode(), it is typically the case that
        /// the verification codes delivered via
        /// SendNotificationChannelVerificationCode() will be shorter and also
        /// have a shorter expiration (e.g. codes such as "G-123456") whereas
        /// GetVerificationCode() will typically return a much longer, websafe base
        /// 64 encoded string that has a longer expiration time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GetNotificationChannelVerificationCodeResponse GetNotificationChannelVerificationCode(GetNotificationChannelVerificationCodeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNotificationChannelVerificationCodeRequest(ref request, ref callSettings);
            return _callGetNotificationChannelVerificationCode.Sync(request, callSettings);
        }

        /// <summary>
        /// Requests a verification code for an already verified channel that can then
        /// be used in a call to VerifyNotificationChannel() on a different channel
        /// with an equivalent identity in the same or in a different project. This
        /// makes it possible to copy a channel between projects without requiring
        /// manual reverification of the channel. If the channel is not in the
        /// verified state, this method will fail (in other words, this may only be
        /// used if the SendNotificationChannelVerificationCode and
        /// VerifyNotificationChannel paths have already been used to put the given
        /// channel into the verified state).
        /// 
        /// There is no guarantee that the verification codes returned by this method
        /// will be of a similar structure or form as the ones that are delivered
        /// to the channel via SendNotificationChannelVerificationCode; while
        /// VerifyNotificationChannel() will recognize both the codes delivered via
        /// SendNotificationChannelVerificationCode() and returned from
        /// GetNotificationChannelVerificationCode(), it is typically the case that
        /// the verification codes delivered via
        /// SendNotificationChannelVerificationCode() will be shorter and also
        /// have a shorter expiration (e.g. codes such as "G-123456") whereas
        /// GetVerificationCode() will typically return a much longer, websafe base
        /// 64 encoded string that has a longer expiration time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GetNotificationChannelVerificationCodeResponse> GetNotificationChannelVerificationCodeAsync(GetNotificationChannelVerificationCodeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNotificationChannelVerificationCodeRequest(ref request, ref callSettings);
            return _callGetNotificationChannelVerificationCode.Async(request, callSettings);
        }

        /// <summary>
        /// Verifies a `NotificationChannel` by proving receipt of the code
        /// delivered to the channel as a result of calling
        /// `SendNotificationChannelVerificationCode`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override NotificationChannel VerifyNotificationChannel(VerifyNotificationChannelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_VerifyNotificationChannelRequest(ref request, ref callSettings);
            return _callVerifyNotificationChannel.Sync(request, callSettings);
        }

        /// <summary>
        /// Verifies a `NotificationChannel` by proving receipt of the code
        /// delivered to the channel as a result of calling
        /// `SendNotificationChannelVerificationCode`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<NotificationChannel> VerifyNotificationChannelAsync(VerifyNotificationChannelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_VerifyNotificationChannelRequest(ref request, ref callSettings);
            return _callVerifyNotificationChannel.Async(request, callSettings);
        }
    }

    public partial class ListNotificationChannelDescriptorsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListNotificationChannelsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListNotificationChannelDescriptorsResponse : gaxgrpc::IPageResponse<NotificationChannelDescriptor>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<NotificationChannelDescriptor> GetEnumerator() => ChannelDescriptors.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListNotificationChannelsResponse : gaxgrpc::IPageResponse<NotificationChannel>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<NotificationChannel> GetEnumerator() => NotificationChannels.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
