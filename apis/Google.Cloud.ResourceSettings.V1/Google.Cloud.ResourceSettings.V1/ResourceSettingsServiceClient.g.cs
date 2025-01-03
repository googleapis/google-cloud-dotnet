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

namespace Google.Cloud.ResourceSettings.V1
{
    /// <summary>Settings for <see cref="ResourceSettingsServiceClient"/> instances.</summary>
    [sys::ObsoleteAttribute]
    public sealed partial class ResourceSettingsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ResourceSettingsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ResourceSettingsServiceSettings"/>.</returns>
        public static ResourceSettingsServiceSettings GetDefault() => new ResourceSettingsServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ResourceSettingsServiceSettings"/> object with default settings.
        /// </summary>
        public ResourceSettingsServiceSettings()
        {
        }

        private ResourceSettingsServiceSettings(ResourceSettingsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListSettingsSettings = existing.ListSettingsSettings;
            GetSettingSettings = existing.GetSettingSettings;
            UpdateSettingSettings = existing.UpdateSettingSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ResourceSettingsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ResourceSettingsServiceClient.ListSettings</c> and <c>ResourceSettingsServiceClient.ListSettingsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSettingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ResourceSettingsServiceClient.GetSetting</c> and <c>ResourceSettingsServiceClient.GetSettingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSettingSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ResourceSettingsServiceClient.UpdateSetting</c> and <c>ResourceSettingsServiceClient.UpdateSettingAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSettingSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ResourceSettingsServiceSettings"/> object.</returns>
        public ResourceSettingsServiceSettings Clone() => new ResourceSettingsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ResourceSettingsServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    [sys::ObsoleteAttribute]
    public sealed partial class ResourceSettingsServiceClientBuilder : gaxgrpc::ClientBuilderBase<ResourceSettingsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ResourceSettingsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ResourceSettingsServiceClientBuilder() : base(ResourceSettingsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ResourceSettingsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ResourceSettingsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ResourceSettingsServiceClient Build()
        {
            ResourceSettingsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ResourceSettingsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ResourceSettingsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ResourceSettingsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ResourceSettingsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ResourceSettingsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ResourceSettingsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ResourceSettingsServiceClient.ChannelPool;
    }

    /// <summary>ResourceSettingsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// An interface to interact with resource settings and setting values throughout
    /// the resource hierarchy.
    /// 
    /// Services may surface a number of settings for users to control how their
    /// resources behave. Values of settings applied on a given Cloud resource are
    /// evaluated hierarchically and inherited by all descendants of that resource.
    /// 
    /// For all requests, returns a `google.rpc.Status` with
    /// `google.rpc.Code.PERMISSION_DENIED` if the IAM check fails or the `parent`
    /// resource is not in a Cloud Organization.
    /// For all requests, returns a `google.rpc.Status` with
    /// `google.rpc.Code.INVALID_ARGUMENT` if the request is malformed.
    /// (== deprecation_description Resource Settings is deprecated. As of November
    /// 7, 2023, no organizations will be onboarded for any of the enabled settings,
    /// and the service will be shut down on October 1, 2024. ==)
    /// </remarks>
    [sys::ObsoleteAttribute]
    public abstract partial class ResourceSettingsServiceClient
    {
        /// <summary>
        /// The default endpoint for the ResourceSettingsService service, which is a host of
        /// "resourcesettings.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "resourcesettings.googleapis.com:443";

        /// <summary>The default ResourceSettingsService scopes.</summary>
        /// <remarks>
        /// The default ResourceSettingsService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ResourceSettingsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ResourceSettingsServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ResourceSettingsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ResourceSettingsServiceClient"/>.</returns>
        public static stt::Task<ResourceSettingsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ResourceSettingsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ResourceSettingsServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ResourceSettingsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ResourceSettingsServiceClient"/>.</returns>
        public static ResourceSettingsServiceClient Create() => new ResourceSettingsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ResourceSettingsServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ResourceSettingsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ResourceSettingsServiceClient"/>.</returns>
        internal static ResourceSettingsServiceClient Create(grpccore::CallInvoker callInvoker, ResourceSettingsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ResourceSettingsService.ResourceSettingsServiceClient grpcClient = new ResourceSettingsService.ResourceSettingsServiceClient(callInvoker);
            return new ResourceSettingsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ResourceSettingsService client</summary>
        public virtual ResourceSettingsService.ResourceSettingsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the settings that are available on the Cloud resource `parent`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Setting"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSettingsResponse, Setting> ListSettings(ListSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the settings that are available on the Cloud resource `parent`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Setting"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSettingsResponse, Setting> ListSettingsAsync(ListSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the settings that are available on the Cloud resource `parent`.
        /// </summary>
        /// <param name="parent">
        /// Required. The Cloud resource that parents the setting. Must be in one of
        /// the following forms:
        /// 
        /// * `projects/{project_number}`
        /// * `projects/{project_id}`
        /// * `folders/{folder_id}`
        /// * `organizations/{organization_id}`
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
        /// <returns>A pageable sequence of <see cref="Setting"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSettingsResponse, Setting> ListSettings(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSettingsRequest request = new ListSettingsRequest
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
            return ListSettings(request, callSettings);
        }

        /// <summary>
        /// Lists all the settings that are available on the Cloud resource `parent`.
        /// </summary>
        /// <param name="parent">
        /// Required. The Cloud resource that parents the setting. Must be in one of
        /// the following forms:
        /// 
        /// * `projects/{project_number}`
        /// * `projects/{project_id}`
        /// * `folders/{folder_id}`
        /// * `organizations/{organization_id}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Setting"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSettingsResponse, Setting> ListSettingsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSettingsRequest request = new ListSettingsRequest
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
            return ListSettingsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all the settings that are available on the Cloud resource `parent`.
        /// </summary>
        /// <param name="parent">
        /// Required. The Cloud resource that parents the setting. Must be in one of
        /// the following forms:
        /// 
        /// * `projects/{project_number}`
        /// * `projects/{project_id}`
        /// * `folders/{folder_id}`
        /// * `organizations/{organization_id}`
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
        /// <returns>A pageable sequence of <see cref="Setting"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSettingsResponse, Setting> ListSettings(gax::IResourceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSettingsRequest request = new ListSettingsRequest
            {
                ParentAsResourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSettings(request, callSettings);
        }

        /// <summary>
        /// Lists all the settings that are available on the Cloud resource `parent`.
        /// </summary>
        /// <param name="parent">
        /// Required. The Cloud resource that parents the setting. Must be in one of
        /// the following forms:
        /// 
        /// * `projects/{project_number}`
        /// * `projects/{project_id}`
        /// * `folders/{folder_id}`
        /// * `organizations/{organization_id}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Setting"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSettingsResponse, Setting> ListSettingsAsync(gax::IResourceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSettingsRequest request = new ListSettingsRequest
            {
                ParentAsResourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSettingsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a setting.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// setting does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Setting GetSetting(GetSettingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a setting.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// setting does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Setting> GetSettingAsync(GetSettingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a setting.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// setting does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Setting> GetSettingAsync(GetSettingRequest request, st::CancellationToken cancellationToken) =>
            GetSettingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a setting.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// setting does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the setting to get. See
        /// [Setting][google.cloud.resourcesettings.v1.Setting] for naming
        /// requirements.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Setting GetSetting(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSetting(new GetSettingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a setting.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// setting does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the setting to get. See
        /// [Setting][google.cloud.resourcesettings.v1.Setting] for naming
        /// requirements.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Setting> GetSettingAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSettingAsync(new GetSettingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a setting.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// setting does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the setting to get. See
        /// [Setting][google.cloud.resourcesettings.v1.Setting] for naming
        /// requirements.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Setting> GetSettingAsync(string name, st::CancellationToken cancellationToken) =>
            GetSettingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a setting.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// setting does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the setting to get. See
        /// [Setting][google.cloud.resourcesettings.v1.Setting] for naming
        /// requirements.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Setting GetSetting(SettingName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSetting(new GetSettingRequest
            {
                SettingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a setting.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// setting does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the setting to get. See
        /// [Setting][google.cloud.resourcesettings.v1.Setting] for naming
        /// requirements.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Setting> GetSettingAsync(SettingName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSettingAsync(new GetSettingRequest
            {
                SettingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a setting.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// setting does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the setting to get. See
        /// [Setting][google.cloud.resourcesettings.v1.Setting] for naming
        /// requirements.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Setting> GetSettingAsync(SettingName name, st::CancellationToken cancellationToken) =>
            GetSettingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a setting.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// setting does not exist.
        /// Returns a `google.rpc.Status` with `google.rpc.Code.FAILED_PRECONDITION` if
        /// the setting is flagged as read only.
        /// Returns a `google.rpc.Status` with `google.rpc.Code.ABORTED` if the etag
        /// supplied in the request does not match the persisted etag of the setting
        /// value.
        /// 
        /// On success, the response will contain only `name`, `local_value` and
        /// `etag`.  The `metadata` and `effective_value` cannot be updated through
        /// this API.
        /// 
        /// Note: the supplied setting will perform a full overwrite of the
        /// `local_value` field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Setting UpdateSetting(UpdateSettingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a setting.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// setting does not exist.
        /// Returns a `google.rpc.Status` with `google.rpc.Code.FAILED_PRECONDITION` if
        /// the setting is flagged as read only.
        /// Returns a `google.rpc.Status` with `google.rpc.Code.ABORTED` if the etag
        /// supplied in the request does not match the persisted etag of the setting
        /// value.
        /// 
        /// On success, the response will contain only `name`, `local_value` and
        /// `etag`.  The `metadata` and `effective_value` cannot be updated through
        /// this API.
        /// 
        /// Note: the supplied setting will perform a full overwrite of the
        /// `local_value` field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Setting> UpdateSettingAsync(UpdateSettingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a setting.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// setting does not exist.
        /// Returns a `google.rpc.Status` with `google.rpc.Code.FAILED_PRECONDITION` if
        /// the setting is flagged as read only.
        /// Returns a `google.rpc.Status` with `google.rpc.Code.ABORTED` if the etag
        /// supplied in the request does not match the persisted etag of the setting
        /// value.
        /// 
        /// On success, the response will contain only `name`, `local_value` and
        /// `etag`.  The `metadata` and `effective_value` cannot be updated through
        /// this API.
        /// 
        /// Note: the supplied setting will perform a full overwrite of the
        /// `local_value` field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Setting> UpdateSettingAsync(UpdateSettingRequest request, st::CancellationToken cancellationToken) =>
            UpdateSettingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ResourceSettingsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// An interface to interact with resource settings and setting values throughout
    /// the resource hierarchy.
    /// 
    /// Services may surface a number of settings for users to control how their
    /// resources behave. Values of settings applied on a given Cloud resource are
    /// evaluated hierarchically and inherited by all descendants of that resource.
    /// 
    /// For all requests, returns a `google.rpc.Status` with
    /// `google.rpc.Code.PERMISSION_DENIED` if the IAM check fails or the `parent`
    /// resource is not in a Cloud Organization.
    /// For all requests, returns a `google.rpc.Status` with
    /// `google.rpc.Code.INVALID_ARGUMENT` if the request is malformed.
    /// (== deprecation_description Resource Settings is deprecated. As of November
    /// 7, 2023, no organizations will be onboarded for any of the enabled settings,
    /// and the service will be shut down on October 1, 2024. ==)
    /// </remarks>
    [sys::ObsoleteAttribute]
    public sealed partial class ResourceSettingsServiceClientImpl : ResourceSettingsServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListSettingsRequest, ListSettingsResponse> _callListSettings;

        private readonly gaxgrpc::ApiCall<GetSettingRequest, Setting> _callGetSetting;

        private readonly gaxgrpc::ApiCall<UpdateSettingRequest, Setting> _callUpdateSetting;

        /// <summary>
        /// Constructs a client wrapper for the ResourceSettingsService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="ResourceSettingsServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ResourceSettingsServiceClientImpl(ResourceSettingsService.ResourceSettingsServiceClient grpcClient, ResourceSettingsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ResourceSettingsServiceSettings effectiveSettings = settings ?? ResourceSettingsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callListSettings = clientHelper.BuildApiCall<ListSettingsRequest, ListSettingsResponse>("ListSettings", grpcClient.ListSettingsAsync, grpcClient.ListSettings, effectiveSettings.ListSettingsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSettings);
            Modify_ListSettingsApiCall(ref _callListSettings);
            _callGetSetting = clientHelper.BuildApiCall<GetSettingRequest, Setting>("GetSetting", grpcClient.GetSettingAsync, grpcClient.GetSetting, effectiveSettings.GetSettingSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSetting);
            Modify_GetSettingApiCall(ref _callGetSetting);
            _callUpdateSetting = clientHelper.BuildApiCall<UpdateSettingRequest, Setting>("UpdateSetting", grpcClient.UpdateSettingAsync, grpcClient.UpdateSetting, effectiveSettings.UpdateSettingSettings).WithGoogleRequestParam("setting.name", request => request.Setting?.Name);
            Modify_ApiCall(ref _callUpdateSetting);
            Modify_UpdateSettingApiCall(ref _callUpdateSetting);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListSettingsApiCall(ref gaxgrpc::ApiCall<ListSettingsRequest, ListSettingsResponse> call);

        partial void Modify_GetSettingApiCall(ref gaxgrpc::ApiCall<GetSettingRequest, Setting> call);

        partial void Modify_UpdateSettingApiCall(ref gaxgrpc::ApiCall<UpdateSettingRequest, Setting> call);

        partial void OnConstruction(ResourceSettingsService.ResourceSettingsServiceClient grpcClient, ResourceSettingsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ResourceSettingsService client</summary>
        public override ResourceSettingsService.ResourceSettingsServiceClient GrpcClient { get; }

        partial void Modify_ListSettingsRequest(ref ListSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSettingRequest(ref GetSettingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSettingRequest(ref UpdateSettingRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists all the settings that are available on the Cloud resource `parent`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Setting"/> resources.</returns>
        public override gax::PagedEnumerable<ListSettingsResponse, Setting> ListSettings(ListSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSettingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSettingsRequest, ListSettingsResponse, Setting>(_callListSettings, request, callSettings);
        }

        /// <summary>
        /// Lists all the settings that are available on the Cloud resource `parent`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Setting"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSettingsResponse, Setting> ListSettingsAsync(ListSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSettingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSettingsRequest, ListSettingsResponse, Setting>(_callListSettings, request, callSettings);
        }

        /// <summary>
        /// Gets a setting.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// setting does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Setting GetSetting(GetSettingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSettingRequest(ref request, ref callSettings);
            return _callGetSetting.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a setting.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// setting does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Setting> GetSettingAsync(GetSettingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSettingRequest(ref request, ref callSettings);
            return _callGetSetting.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a setting.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// setting does not exist.
        /// Returns a `google.rpc.Status` with `google.rpc.Code.FAILED_PRECONDITION` if
        /// the setting is flagged as read only.
        /// Returns a `google.rpc.Status` with `google.rpc.Code.ABORTED` if the etag
        /// supplied in the request does not match the persisted etag of the setting
        /// value.
        /// 
        /// On success, the response will contain only `name`, `local_value` and
        /// `etag`.  The `metadata` and `effective_value` cannot be updated through
        /// this API.
        /// 
        /// Note: the supplied setting will perform a full overwrite of the
        /// `local_value` field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Setting UpdateSetting(UpdateSettingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSettingRequest(ref request, ref callSettings);
            return _callUpdateSetting.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a setting.
        /// 
        /// Returns a `google.rpc.Status` with `google.rpc.Code.NOT_FOUND` if the
        /// setting does not exist.
        /// Returns a `google.rpc.Status` with `google.rpc.Code.FAILED_PRECONDITION` if
        /// the setting is flagged as read only.
        /// Returns a `google.rpc.Status` with `google.rpc.Code.ABORTED` if the etag
        /// supplied in the request does not match the persisted etag of the setting
        /// value.
        /// 
        /// On success, the response will contain only `name`, `local_value` and
        /// `etag`.  The `metadata` and `effective_value` cannot be updated through
        /// this API.
        /// 
        /// Note: the supplied setting will perform a full overwrite of the
        /// `local_value` field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Setting> UpdateSettingAsync(UpdateSettingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSettingRequest(ref request, ref callSettings);
            return _callUpdateSetting.Async(request, callSettings);
        }
    }

    public partial class ListSettingsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSettingsResponse : gaxgrpc::IPageResponse<Setting>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Setting> GetEnumerator() => Settings.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
