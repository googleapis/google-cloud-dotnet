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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.CloudQuotas.V1Beta
{
    /// <summary>Settings for <see cref="CloudQuotasClient"/> instances.</summary>
    public sealed partial class CloudQuotasSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CloudQuotasSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CloudQuotasSettings"/>.</returns>
        public static CloudQuotasSettings GetDefault() => new CloudQuotasSettings();

        /// <summary>Constructs a new <see cref="CloudQuotasSettings"/> object with default settings.</summary>
        public CloudQuotasSettings()
        {
        }

        private CloudQuotasSettings(CloudQuotasSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListQuotaInfosSettings = existing.ListQuotaInfosSettings;
            GetQuotaInfoSettings = existing.GetQuotaInfoSettings;
            ListQuotaPreferencesSettings = existing.ListQuotaPreferencesSettings;
            GetQuotaPreferenceSettings = existing.GetQuotaPreferenceSettings;
            CreateQuotaPreferenceSettings = existing.CreateQuotaPreferenceSettings;
            UpdateQuotaPreferenceSettings = existing.UpdateQuotaPreferenceSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CloudQuotasSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudQuotasClient.ListQuotaInfos</c> and <c>CloudQuotasClient.ListQuotaInfosAsync</c>.
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
        public gaxgrpc::CallSettings ListQuotaInfosSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudQuotasClient.GetQuotaInfo</c> and <c>CloudQuotasClient.GetQuotaInfoAsync</c>.
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
        public gaxgrpc::CallSettings GetQuotaInfoSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudQuotasClient.ListQuotaPreferences</c> and <c>CloudQuotasClient.ListQuotaPreferencesAsync</c>.
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
        public gaxgrpc::CallSettings ListQuotaPreferencesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudQuotasClient.GetQuotaPreference</c> and <c>CloudQuotasClient.GetQuotaPreferenceAsync</c>.
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
        public gaxgrpc::CallSettings GetQuotaPreferenceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudQuotasClient.CreateQuotaPreference</c> and <c>CloudQuotasClient.CreateQuotaPreferenceAsync</c>.
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
        public gaxgrpc::CallSettings CreateQuotaPreferenceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudQuotasClient.UpdateQuotaPreference</c> and <c>CloudQuotasClient.UpdateQuotaPreferenceAsync</c>.
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
        public gaxgrpc::CallSettings UpdateQuotaPreferenceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CloudQuotasSettings"/> object.</returns>
        public CloudQuotasSettings Clone() => new CloudQuotasSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CloudQuotasClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class CloudQuotasClientBuilder : gaxgrpc::ClientBuilderBase<CloudQuotasClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CloudQuotasSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CloudQuotasClientBuilder() : base(CloudQuotasClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CloudQuotasClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CloudQuotasClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CloudQuotasClient Build()
        {
            CloudQuotasClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CloudQuotasClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CloudQuotasClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CloudQuotasClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CloudQuotasClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CloudQuotasClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CloudQuotasClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CloudQuotasClient.ChannelPool;
    }

    /// <summary>CloudQuotas client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The Cloud Quotas API is an infrastructure service for Google Cloud that lets
    /// service consumers list and manage their resource usage limits.
    /// 
    /// - List/Get the metadata and current status of the quotas for a service.
    /// - Create/Update quota preferencess that declare the preferred quota values.
    /// - Check the status of a quota preference request.
    /// - List/Get pending and historical quota preference.
    /// </remarks>
    public abstract partial class CloudQuotasClient
    {
        /// <summary>
        /// The default endpoint for the CloudQuotas service, which is a host of "cloudquotas.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudquotas.googleapis.com:443";

        /// <summary>The default CloudQuotas scopes.</summary>
        /// <remarks>
        /// The default CloudQuotas scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CloudQuotas.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CloudQuotasClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CloudQuotasClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CloudQuotasClient"/>.</returns>
        public static stt::Task<CloudQuotasClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CloudQuotasClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CloudQuotasClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CloudQuotasClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CloudQuotasClient"/>.</returns>
        public static CloudQuotasClient Create() => new CloudQuotasClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CloudQuotasClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CloudQuotasSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CloudQuotasClient"/>.</returns>
        internal static CloudQuotasClient Create(grpccore::CallInvoker callInvoker, CloudQuotasSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CloudQuotas.CloudQuotasClient grpcClient = new CloudQuotas.CloudQuotasClient(callInvoker);
            return new CloudQuotasClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CloudQuotas client</summary>
        public virtual CloudQuotas.CloudQuotasClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists QuotaInfos of all quotas for a given project, folder or organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="QuotaInfo"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListQuotaInfosResponse, QuotaInfo> ListQuotaInfos(ListQuotaInfosRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists QuotaInfos of all quotas for a given project, folder or organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="QuotaInfo"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListQuotaInfosResponse, QuotaInfo> ListQuotaInfosAsync(ListQuotaInfosRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists QuotaInfos of all quotas for a given project, folder or organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value of QuotaInfo resources.
        /// Listing across different resource containers (such as 'projects/-') is not
        /// allowed.
        /// 
        /// Example names:
        /// `projects/123/locations/global/services/compute.googleapis.com`
        /// `folders/234/locations/global/services/compute.googleapis.com`
        /// `organizations/345/locations/global/services/compute.googleapis.com`
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
        /// <returns>A pageable sequence of <see cref="QuotaInfo"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListQuotaInfosResponse, QuotaInfo> ListQuotaInfos(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListQuotaInfosRequest request = new ListQuotaInfosRequest
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
            return ListQuotaInfos(request, callSettings);
        }

        /// <summary>
        /// Lists QuotaInfos of all quotas for a given project, folder or organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value of QuotaInfo resources.
        /// Listing across different resource containers (such as 'projects/-') is not
        /// allowed.
        /// 
        /// Example names:
        /// `projects/123/locations/global/services/compute.googleapis.com`
        /// `folders/234/locations/global/services/compute.googleapis.com`
        /// `organizations/345/locations/global/services/compute.googleapis.com`
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
        /// <returns>A pageable asynchronous sequence of <see cref="QuotaInfo"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListQuotaInfosResponse, QuotaInfo> ListQuotaInfosAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListQuotaInfosRequest request = new ListQuotaInfosRequest
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
            return ListQuotaInfosAsync(request, callSettings);
        }

        /// <summary>
        /// Lists QuotaInfos of all quotas for a given project, folder or organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value of QuotaInfo resources.
        /// Listing across different resource containers (such as 'projects/-') is not
        /// allowed.
        /// 
        /// Example names:
        /// `projects/123/locations/global/services/compute.googleapis.com`
        /// `folders/234/locations/global/services/compute.googleapis.com`
        /// `organizations/345/locations/global/services/compute.googleapis.com`
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
        /// <returns>A pageable sequence of <see cref="QuotaInfo"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListQuotaInfosResponse, QuotaInfo> ListQuotaInfos(ServiceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListQuotaInfosRequest request = new ListQuotaInfosRequest
            {
                ParentAsServiceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListQuotaInfos(request, callSettings);
        }

        /// <summary>
        /// Lists QuotaInfos of all quotas for a given project, folder or organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value of QuotaInfo resources.
        /// Listing across different resource containers (such as 'projects/-') is not
        /// allowed.
        /// 
        /// Example names:
        /// `projects/123/locations/global/services/compute.googleapis.com`
        /// `folders/234/locations/global/services/compute.googleapis.com`
        /// `organizations/345/locations/global/services/compute.googleapis.com`
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
        /// <returns>A pageable asynchronous sequence of <see cref="QuotaInfo"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListQuotaInfosResponse, QuotaInfo> ListQuotaInfosAsync(ServiceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListQuotaInfosRequest request = new ListQuotaInfosRequest
            {
                ParentAsServiceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListQuotaInfosAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieve the QuotaInfo of a quota for a project, folder or organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QuotaInfo GetQuotaInfo(GetQuotaInfoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve the QuotaInfo of a quota for a project, folder or organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuotaInfo> GetQuotaInfoAsync(GetQuotaInfoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieve the QuotaInfo of a quota for a project, folder or organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuotaInfo> GetQuotaInfoAsync(GetQuotaInfoRequest request, st::CancellationToken cancellationToken) =>
            GetQuotaInfoAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve the QuotaInfo of a quota for a project, folder or organization.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the quota info.
        /// 
        /// An example name:
        /// `projects/123/locations/global/services/compute.googleapis.com/quotaInfos/CpusPerProjectPerRegion`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QuotaInfo GetQuotaInfo(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetQuotaInfo(new GetQuotaInfoRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve the QuotaInfo of a quota for a project, folder or organization.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the quota info.
        /// 
        /// An example name:
        /// `projects/123/locations/global/services/compute.googleapis.com/quotaInfos/CpusPerProjectPerRegion`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuotaInfo> GetQuotaInfoAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetQuotaInfoAsync(new GetQuotaInfoRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve the QuotaInfo of a quota for a project, folder or organization.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the quota info.
        /// 
        /// An example name:
        /// `projects/123/locations/global/services/compute.googleapis.com/quotaInfos/CpusPerProjectPerRegion`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuotaInfo> GetQuotaInfoAsync(string name, st::CancellationToken cancellationToken) =>
            GetQuotaInfoAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieve the QuotaInfo of a quota for a project, folder or organization.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the quota info.
        /// 
        /// An example name:
        /// `projects/123/locations/global/services/compute.googleapis.com/quotaInfos/CpusPerProjectPerRegion`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QuotaInfo GetQuotaInfo(QuotaInfoName name, gaxgrpc::CallSettings callSettings = null) =>
            GetQuotaInfo(new GetQuotaInfoRequest
            {
                QuotaInfoName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve the QuotaInfo of a quota for a project, folder or organization.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the quota info.
        /// 
        /// An example name:
        /// `projects/123/locations/global/services/compute.googleapis.com/quotaInfos/CpusPerProjectPerRegion`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuotaInfo> GetQuotaInfoAsync(QuotaInfoName name, gaxgrpc::CallSettings callSettings = null) =>
            GetQuotaInfoAsync(new GetQuotaInfoRequest
            {
                QuotaInfoName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieve the QuotaInfo of a quota for a project, folder or organization.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the quota info.
        /// 
        /// An example name:
        /// `projects/123/locations/global/services/compute.googleapis.com/quotaInfos/CpusPerProjectPerRegion`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuotaInfo> GetQuotaInfoAsync(QuotaInfoName name, st::CancellationToken cancellationToken) =>
            GetQuotaInfoAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists QuotaPreferences in a given project, folder or organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="QuotaPreference"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListQuotaPreferencesResponse, QuotaPreference> ListQuotaPreferences(ListQuotaPreferencesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists QuotaPreferences in a given project, folder or organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="QuotaPreference"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListQuotaPreferencesResponse, QuotaPreference> ListQuotaPreferencesAsync(ListQuotaPreferencesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists QuotaPreferences in a given project, folder or organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value of QuotaPreference resources.
        /// Listing across different resource containers (such as 'projects/-') is not
        /// allowed.
        /// 
        /// When the value starts with 'folders' or 'organizations', it lists the
        /// QuotaPreferences for org quotas in the container. It does not list the
        /// QuotaPreferences in the descendant projects of the container.
        /// 
        /// Example parents:
        /// `projects/123/locations/global`
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
        /// <returns>A pageable sequence of <see cref="QuotaPreference"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListQuotaPreferencesResponse, QuotaPreference> ListQuotaPreferences(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListQuotaPreferencesRequest request = new ListQuotaPreferencesRequest
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
            return ListQuotaPreferences(request, callSettings);
        }

        /// <summary>
        /// Lists QuotaPreferences in a given project, folder or organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value of QuotaPreference resources.
        /// Listing across different resource containers (such as 'projects/-') is not
        /// allowed.
        /// 
        /// When the value starts with 'folders' or 'organizations', it lists the
        /// QuotaPreferences for org quotas in the container. It does not list the
        /// QuotaPreferences in the descendant projects of the container.
        /// 
        /// Example parents:
        /// `projects/123/locations/global`
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
        /// <returns>A pageable asynchronous sequence of <see cref="QuotaPreference"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListQuotaPreferencesResponse, QuotaPreference> ListQuotaPreferencesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListQuotaPreferencesRequest request = new ListQuotaPreferencesRequest
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
            return ListQuotaPreferencesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists QuotaPreferences in a given project, folder or organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value of QuotaPreference resources.
        /// Listing across different resource containers (such as 'projects/-') is not
        /// allowed.
        /// 
        /// When the value starts with 'folders' or 'organizations', it lists the
        /// QuotaPreferences for org quotas in the container. It does not list the
        /// QuotaPreferences in the descendant projects of the container.
        /// 
        /// Example parents:
        /// `projects/123/locations/global`
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
        /// <returns>A pageable sequence of <see cref="QuotaPreference"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListQuotaPreferencesResponse, QuotaPreference> ListQuotaPreferences(LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListQuotaPreferencesRequest request = new ListQuotaPreferencesRequest
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
            return ListQuotaPreferences(request, callSettings);
        }

        /// <summary>
        /// Lists QuotaPreferences in a given project, folder or organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value of QuotaPreference resources.
        /// Listing across different resource containers (such as 'projects/-') is not
        /// allowed.
        /// 
        /// When the value starts with 'folders' or 'organizations', it lists the
        /// QuotaPreferences for org quotas in the container. It does not list the
        /// QuotaPreferences in the descendant projects of the container.
        /// 
        /// Example parents:
        /// `projects/123/locations/global`
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
        /// <returns>A pageable asynchronous sequence of <see cref="QuotaPreference"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListQuotaPreferencesResponse, QuotaPreference> ListQuotaPreferencesAsync(LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListQuotaPreferencesRequest request = new ListQuotaPreferencesRequest
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
            return ListQuotaPreferencesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists QuotaPreferences in a given project, folder or organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value of QuotaPreference resources.
        /// Listing across different resource containers (such as 'projects/-') is not
        /// allowed.
        /// 
        /// When the value starts with 'folders' or 'organizations', it lists the
        /// QuotaPreferences for org quotas in the container. It does not list the
        /// QuotaPreferences in the descendant projects of the container.
        /// 
        /// Example parents:
        /// `projects/123/locations/global`
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
        /// <returns>A pageable sequence of <see cref="QuotaPreference"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListQuotaPreferencesResponse, QuotaPreference> ListQuotaPreferences(LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListQuotaPreferencesRequest request = new ListQuotaPreferencesRequest
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
            return ListQuotaPreferences(request, callSettings);
        }

        /// <summary>
        /// Lists QuotaPreferences in a given project, folder or organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value of QuotaPreference resources.
        /// Listing across different resource containers (such as 'projects/-') is not
        /// allowed.
        /// 
        /// When the value starts with 'folders' or 'organizations', it lists the
        /// QuotaPreferences for org quotas in the container. It does not list the
        /// QuotaPreferences in the descendant projects of the container.
        /// 
        /// Example parents:
        /// `projects/123/locations/global`
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
        /// <returns>A pageable asynchronous sequence of <see cref="QuotaPreference"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListQuotaPreferencesResponse, QuotaPreference> ListQuotaPreferencesAsync(LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListQuotaPreferencesRequest request = new ListQuotaPreferencesRequest
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
            return ListQuotaPreferencesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single QuotaPreference.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QuotaPreference GetQuotaPreference(GetQuotaPreferenceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single QuotaPreference.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuotaPreference> GetQuotaPreferenceAsync(GetQuotaPreferenceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single QuotaPreference.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuotaPreference> GetQuotaPreferenceAsync(GetQuotaPreferenceRequest request, st::CancellationToken cancellationToken) =>
            GetQuotaPreferenceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single QuotaPreference.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// 
        /// Example name:
        /// `projects/123/locations/global/quota_preferences/my-config-for-us-east1`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QuotaPreference GetQuotaPreference(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetQuotaPreference(new GetQuotaPreferenceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single QuotaPreference.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// 
        /// Example name:
        /// `projects/123/locations/global/quota_preferences/my-config-for-us-east1`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuotaPreference> GetQuotaPreferenceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetQuotaPreferenceAsync(new GetQuotaPreferenceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single QuotaPreference.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// 
        /// Example name:
        /// `projects/123/locations/global/quota_preferences/my-config-for-us-east1`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuotaPreference> GetQuotaPreferenceAsync(string name, st::CancellationToken cancellationToken) =>
            GetQuotaPreferenceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single QuotaPreference.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// 
        /// Example name:
        /// `projects/123/locations/global/quota_preferences/my-config-for-us-east1`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QuotaPreference GetQuotaPreference(QuotaPreferenceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetQuotaPreference(new GetQuotaPreferenceRequest
            {
                QuotaPreferenceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single QuotaPreference.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// 
        /// Example name:
        /// `projects/123/locations/global/quota_preferences/my-config-for-us-east1`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuotaPreference> GetQuotaPreferenceAsync(QuotaPreferenceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetQuotaPreferenceAsync(new GetQuotaPreferenceRequest
            {
                QuotaPreferenceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single QuotaPreference.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// 
        /// Example name:
        /// `projects/123/locations/global/quota_preferences/my-config-for-us-east1`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuotaPreference> GetQuotaPreferenceAsync(QuotaPreferenceName name, st::CancellationToken cancellationToken) =>
            GetQuotaPreferenceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new QuotaPreference that declares the desired value for a quota.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QuotaPreference CreateQuotaPreference(CreateQuotaPreferenceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new QuotaPreference that declares the desired value for a quota.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuotaPreference> CreateQuotaPreferenceAsync(CreateQuotaPreferenceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new QuotaPreference that declares the desired value for a quota.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuotaPreference> CreateQuotaPreferenceAsync(CreateQuotaPreferenceRequest request, st::CancellationToken cancellationToken) =>
            CreateQuotaPreferenceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new QuotaPreference that declares the desired value for a quota.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// 
        /// Example:
        /// `projects/123/locations/global`
        /// </param>
        /// <param name="quotaPreference">
        /// Required. The resource being created
        /// </param>
        /// <param name="quotaPreferenceId">
        /// Optional. Id of the requesting object, must be unique under its parent.
        /// If client does not set this field, the service will generate one.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QuotaPreference CreateQuotaPreference(string parent, QuotaPreference quotaPreference, string quotaPreferenceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateQuotaPreference(new CreateQuotaPreferenceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                QuotaPreferenceId = quotaPreferenceId ?? "",
                QuotaPreference = gax::GaxPreconditions.CheckNotNull(quotaPreference, nameof(quotaPreference)),
            }, callSettings);

        /// <summary>
        /// Creates a new QuotaPreference that declares the desired value for a quota.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// 
        /// Example:
        /// `projects/123/locations/global`
        /// </param>
        /// <param name="quotaPreference">
        /// Required. The resource being created
        /// </param>
        /// <param name="quotaPreferenceId">
        /// Optional. Id of the requesting object, must be unique under its parent.
        /// If client does not set this field, the service will generate one.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuotaPreference> CreateQuotaPreferenceAsync(string parent, QuotaPreference quotaPreference, string quotaPreferenceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateQuotaPreferenceAsync(new CreateQuotaPreferenceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                QuotaPreferenceId = quotaPreferenceId ?? "",
                QuotaPreference = gax::GaxPreconditions.CheckNotNull(quotaPreference, nameof(quotaPreference)),
            }, callSettings);

        /// <summary>
        /// Creates a new QuotaPreference that declares the desired value for a quota.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// 
        /// Example:
        /// `projects/123/locations/global`
        /// </param>
        /// <param name="quotaPreference">
        /// Required. The resource being created
        /// </param>
        /// <param name="quotaPreferenceId">
        /// Optional. Id of the requesting object, must be unique under its parent.
        /// If client does not set this field, the service will generate one.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuotaPreference> CreateQuotaPreferenceAsync(string parent, QuotaPreference quotaPreference, string quotaPreferenceId, st::CancellationToken cancellationToken) =>
            CreateQuotaPreferenceAsync(parent, quotaPreference, quotaPreferenceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new QuotaPreference that declares the desired value for a quota.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// 
        /// Example:
        /// `projects/123/locations/global`
        /// </param>
        /// <param name="quotaPreference">
        /// Required. The resource being created
        /// </param>
        /// <param name="quotaPreferenceId">
        /// Optional. Id of the requesting object, must be unique under its parent.
        /// If client does not set this field, the service will generate one.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QuotaPreference CreateQuotaPreference(LocationName parent, QuotaPreference quotaPreference, string quotaPreferenceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateQuotaPreference(new CreateQuotaPreferenceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                QuotaPreferenceId = quotaPreferenceId ?? "",
                QuotaPreference = gax::GaxPreconditions.CheckNotNull(quotaPreference, nameof(quotaPreference)),
            }, callSettings);

        /// <summary>
        /// Creates a new QuotaPreference that declares the desired value for a quota.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// 
        /// Example:
        /// `projects/123/locations/global`
        /// </param>
        /// <param name="quotaPreference">
        /// Required. The resource being created
        /// </param>
        /// <param name="quotaPreferenceId">
        /// Optional. Id of the requesting object, must be unique under its parent.
        /// If client does not set this field, the service will generate one.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuotaPreference> CreateQuotaPreferenceAsync(LocationName parent, QuotaPreference quotaPreference, string quotaPreferenceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateQuotaPreferenceAsync(new CreateQuotaPreferenceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                QuotaPreferenceId = quotaPreferenceId ?? "",
                QuotaPreference = gax::GaxPreconditions.CheckNotNull(quotaPreference, nameof(quotaPreference)),
            }, callSettings);

        /// <summary>
        /// Creates a new QuotaPreference that declares the desired value for a quota.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// 
        /// Example:
        /// `projects/123/locations/global`
        /// </param>
        /// <param name="quotaPreference">
        /// Required. The resource being created
        /// </param>
        /// <param name="quotaPreferenceId">
        /// Optional. Id of the requesting object, must be unique under its parent.
        /// If client does not set this field, the service will generate one.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuotaPreference> CreateQuotaPreferenceAsync(LocationName parent, QuotaPreference quotaPreference, string quotaPreferenceId, st::CancellationToken cancellationToken) =>
            CreateQuotaPreferenceAsync(parent, quotaPreference, quotaPreferenceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new QuotaPreference that declares the desired value for a quota.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// 
        /// Example:
        /// `projects/123/locations/global`
        /// </param>
        /// <param name="quotaPreference">
        /// Required. The resource being created
        /// </param>
        /// <param name="quotaPreferenceId">
        /// Optional. Id of the requesting object, must be unique under its parent.
        /// If client does not set this field, the service will generate one.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QuotaPreference CreateQuotaPreference(LocationName parent, QuotaPreference quotaPreference, string quotaPreferenceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateQuotaPreference(new CreateQuotaPreferenceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                QuotaPreferenceId = quotaPreferenceId ?? "",
                QuotaPreference = gax::GaxPreconditions.CheckNotNull(quotaPreference, nameof(quotaPreference)),
            }, callSettings);

        /// <summary>
        /// Creates a new QuotaPreference that declares the desired value for a quota.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// 
        /// Example:
        /// `projects/123/locations/global`
        /// </param>
        /// <param name="quotaPreference">
        /// Required. The resource being created
        /// </param>
        /// <param name="quotaPreferenceId">
        /// Optional. Id of the requesting object, must be unique under its parent.
        /// If client does not set this field, the service will generate one.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuotaPreference> CreateQuotaPreferenceAsync(LocationName parent, QuotaPreference quotaPreference, string quotaPreferenceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateQuotaPreferenceAsync(new CreateQuotaPreferenceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                QuotaPreferenceId = quotaPreferenceId ?? "",
                QuotaPreference = gax::GaxPreconditions.CheckNotNull(quotaPreference, nameof(quotaPreference)),
            }, callSettings);

        /// <summary>
        /// Creates a new QuotaPreference that declares the desired value for a quota.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// 
        /// Example:
        /// `projects/123/locations/global`
        /// </param>
        /// <param name="quotaPreference">
        /// Required. The resource being created
        /// </param>
        /// <param name="quotaPreferenceId">
        /// Optional. Id of the requesting object, must be unique under its parent.
        /// If client does not set this field, the service will generate one.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuotaPreference> CreateQuotaPreferenceAsync(LocationName parent, QuotaPreference quotaPreference, string quotaPreferenceId, st::CancellationToken cancellationToken) =>
            CreateQuotaPreferenceAsync(parent, quotaPreference, quotaPreferenceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new QuotaPreference that declares the desired value for a quota.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// 
        /// Example:
        /// `projects/123/locations/global`
        /// </param>
        /// <param name="quotaPreference">
        /// Required. The resource being created
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QuotaPreference CreateQuotaPreference(string parent, QuotaPreference quotaPreference, gaxgrpc::CallSettings callSettings = null) =>
            CreateQuotaPreference(new CreateQuotaPreferenceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                QuotaPreference = gax::GaxPreconditions.CheckNotNull(quotaPreference, nameof(quotaPreference)),
            }, callSettings);

        /// <summary>
        /// Creates a new QuotaPreference that declares the desired value for a quota.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// 
        /// Example:
        /// `projects/123/locations/global`
        /// </param>
        /// <param name="quotaPreference">
        /// Required. The resource being created
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuotaPreference> CreateQuotaPreferenceAsync(string parent, QuotaPreference quotaPreference, gaxgrpc::CallSettings callSettings = null) =>
            CreateQuotaPreferenceAsync(new CreateQuotaPreferenceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                QuotaPreference = gax::GaxPreconditions.CheckNotNull(quotaPreference, nameof(quotaPreference)),
            }, callSettings);

        /// <summary>
        /// Creates a new QuotaPreference that declares the desired value for a quota.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// 
        /// Example:
        /// `projects/123/locations/global`
        /// </param>
        /// <param name="quotaPreference">
        /// Required. The resource being created
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuotaPreference> CreateQuotaPreferenceAsync(string parent, QuotaPreference quotaPreference, st::CancellationToken cancellationToken) =>
            CreateQuotaPreferenceAsync(parent, quotaPreference, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new QuotaPreference that declares the desired value for a quota.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// 
        /// Example:
        /// `projects/123/locations/global`
        /// </param>
        /// <param name="quotaPreference">
        /// Required. The resource being created
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QuotaPreference CreateQuotaPreference(LocationName parent, QuotaPreference quotaPreference, gaxgrpc::CallSettings callSettings = null) =>
            CreateQuotaPreference(new CreateQuotaPreferenceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                QuotaPreference = gax::GaxPreconditions.CheckNotNull(quotaPreference, nameof(quotaPreference)),
            }, callSettings);

        /// <summary>
        /// Creates a new QuotaPreference that declares the desired value for a quota.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// 
        /// Example:
        /// `projects/123/locations/global`
        /// </param>
        /// <param name="quotaPreference">
        /// Required. The resource being created
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuotaPreference> CreateQuotaPreferenceAsync(LocationName parent, QuotaPreference quotaPreference, gaxgrpc::CallSettings callSettings = null) =>
            CreateQuotaPreferenceAsync(new CreateQuotaPreferenceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                QuotaPreference = gax::GaxPreconditions.CheckNotNull(quotaPreference, nameof(quotaPreference)),
            }, callSettings);

        /// <summary>
        /// Creates a new QuotaPreference that declares the desired value for a quota.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// 
        /// Example:
        /// `projects/123/locations/global`
        /// </param>
        /// <param name="quotaPreference">
        /// Required. The resource being created
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuotaPreference> CreateQuotaPreferenceAsync(LocationName parent, QuotaPreference quotaPreference, st::CancellationToken cancellationToken) =>
            CreateQuotaPreferenceAsync(parent, quotaPreference, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new QuotaPreference that declares the desired value for a quota.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// 
        /// Example:
        /// `projects/123/locations/global`
        /// </param>
        /// <param name="quotaPreference">
        /// Required. The resource being created
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QuotaPreference CreateQuotaPreference(LocationName parent, QuotaPreference quotaPreference, gaxgrpc::CallSettings callSettings = null) =>
            CreateQuotaPreference(new CreateQuotaPreferenceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                QuotaPreference = gax::GaxPreconditions.CheckNotNull(quotaPreference, nameof(quotaPreference)),
            }, callSettings);

        /// <summary>
        /// Creates a new QuotaPreference that declares the desired value for a quota.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// 
        /// Example:
        /// `projects/123/locations/global`
        /// </param>
        /// <param name="quotaPreference">
        /// Required. The resource being created
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuotaPreference> CreateQuotaPreferenceAsync(LocationName parent, QuotaPreference quotaPreference, gaxgrpc::CallSettings callSettings = null) =>
            CreateQuotaPreferenceAsync(new CreateQuotaPreferenceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                QuotaPreference = gax::GaxPreconditions.CheckNotNull(quotaPreference, nameof(quotaPreference)),
            }, callSettings);

        /// <summary>
        /// Creates a new QuotaPreference that declares the desired value for a quota.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// 
        /// Example:
        /// `projects/123/locations/global`
        /// </param>
        /// <param name="quotaPreference">
        /// Required. The resource being created
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuotaPreference> CreateQuotaPreferenceAsync(LocationName parent, QuotaPreference quotaPreference, st::CancellationToken cancellationToken) =>
            CreateQuotaPreferenceAsync(parent, quotaPreference, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single QuotaPreference. It can updates the
        /// config in any states, not just the ones pending approval.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QuotaPreference UpdateQuotaPreference(UpdateQuotaPreferenceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single QuotaPreference. It can updates the
        /// config in any states, not just the ones pending approval.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuotaPreference> UpdateQuotaPreferenceAsync(UpdateQuotaPreferenceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single QuotaPreference. It can updates the
        /// config in any states, not just the ones pending approval.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuotaPreference> UpdateQuotaPreferenceAsync(UpdateQuotaPreferenceRequest request, st::CancellationToken cancellationToken) =>
            UpdateQuotaPreferenceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single QuotaPreference. It can updates the
        /// config in any states, not just the ones pending approval.
        /// </summary>
        /// <param name="quotaPreference">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// QuotaPreference resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QuotaPreference UpdateQuotaPreference(QuotaPreference quotaPreference, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateQuotaPreference(new UpdateQuotaPreferenceRequest
            {
                UpdateMask = updateMask,
                QuotaPreference = gax::GaxPreconditions.CheckNotNull(quotaPreference, nameof(quotaPreference)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single QuotaPreference. It can updates the
        /// config in any states, not just the ones pending approval.
        /// </summary>
        /// <param name="quotaPreference">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// QuotaPreference resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuotaPreference> UpdateQuotaPreferenceAsync(QuotaPreference quotaPreference, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateQuotaPreferenceAsync(new UpdateQuotaPreferenceRequest
            {
                UpdateMask = updateMask,
                QuotaPreference = gax::GaxPreconditions.CheckNotNull(quotaPreference, nameof(quotaPreference)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single QuotaPreference. It can updates the
        /// config in any states, not just the ones pending approval.
        /// </summary>
        /// <param name="quotaPreference">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// QuotaPreference resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuotaPreference> UpdateQuotaPreferenceAsync(QuotaPreference quotaPreference, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateQuotaPreferenceAsync(quotaPreference, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CloudQuotas client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The Cloud Quotas API is an infrastructure service for Google Cloud that lets
    /// service consumers list and manage their resource usage limits.
    /// 
    /// - List/Get the metadata and current status of the quotas for a service.
    /// - Create/Update quota preferencess that declare the preferred quota values.
    /// - Check the status of a quota preference request.
    /// - List/Get pending and historical quota preference.
    /// </remarks>
    public sealed partial class CloudQuotasClientImpl : CloudQuotasClient
    {
        private readonly gaxgrpc::ApiCall<ListQuotaInfosRequest, ListQuotaInfosResponse> _callListQuotaInfos;

        private readonly gaxgrpc::ApiCall<GetQuotaInfoRequest, QuotaInfo> _callGetQuotaInfo;

        private readonly gaxgrpc::ApiCall<ListQuotaPreferencesRequest, ListQuotaPreferencesResponse> _callListQuotaPreferences;

        private readonly gaxgrpc::ApiCall<GetQuotaPreferenceRequest, QuotaPreference> _callGetQuotaPreference;

        private readonly gaxgrpc::ApiCall<CreateQuotaPreferenceRequest, QuotaPreference> _callCreateQuotaPreference;

        private readonly gaxgrpc::ApiCall<UpdateQuotaPreferenceRequest, QuotaPreference> _callUpdateQuotaPreference;

        /// <summary>
        /// Constructs a client wrapper for the CloudQuotas service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CloudQuotasSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CloudQuotasClientImpl(CloudQuotas.CloudQuotasClient grpcClient, CloudQuotasSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CloudQuotasSettings effectiveSettings = settings ?? CloudQuotasSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callListQuotaInfos = clientHelper.BuildApiCall<ListQuotaInfosRequest, ListQuotaInfosResponse>("ListQuotaInfos", grpcClient.ListQuotaInfosAsync, grpcClient.ListQuotaInfos, effectiveSettings.ListQuotaInfosSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListQuotaInfos);
            Modify_ListQuotaInfosApiCall(ref _callListQuotaInfos);
            _callGetQuotaInfo = clientHelper.BuildApiCall<GetQuotaInfoRequest, QuotaInfo>("GetQuotaInfo", grpcClient.GetQuotaInfoAsync, grpcClient.GetQuotaInfo, effectiveSettings.GetQuotaInfoSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetQuotaInfo);
            Modify_GetQuotaInfoApiCall(ref _callGetQuotaInfo);
            _callListQuotaPreferences = clientHelper.BuildApiCall<ListQuotaPreferencesRequest, ListQuotaPreferencesResponse>("ListQuotaPreferences", grpcClient.ListQuotaPreferencesAsync, grpcClient.ListQuotaPreferences, effectiveSettings.ListQuotaPreferencesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListQuotaPreferences);
            Modify_ListQuotaPreferencesApiCall(ref _callListQuotaPreferences);
            _callGetQuotaPreference = clientHelper.BuildApiCall<GetQuotaPreferenceRequest, QuotaPreference>("GetQuotaPreference", grpcClient.GetQuotaPreferenceAsync, grpcClient.GetQuotaPreference, effectiveSettings.GetQuotaPreferenceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetQuotaPreference);
            Modify_GetQuotaPreferenceApiCall(ref _callGetQuotaPreference);
            _callCreateQuotaPreference = clientHelper.BuildApiCall<CreateQuotaPreferenceRequest, QuotaPreference>("CreateQuotaPreference", grpcClient.CreateQuotaPreferenceAsync, grpcClient.CreateQuotaPreference, effectiveSettings.CreateQuotaPreferenceSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateQuotaPreference);
            Modify_CreateQuotaPreferenceApiCall(ref _callCreateQuotaPreference);
            _callUpdateQuotaPreference = clientHelper.BuildApiCall<UpdateQuotaPreferenceRequest, QuotaPreference>("UpdateQuotaPreference", grpcClient.UpdateQuotaPreferenceAsync, grpcClient.UpdateQuotaPreference, effectiveSettings.UpdateQuotaPreferenceSettings).WithGoogleRequestParam("quota_preference.name", request => request.QuotaPreference?.Name);
            Modify_ApiCall(ref _callUpdateQuotaPreference);
            Modify_UpdateQuotaPreferenceApiCall(ref _callUpdateQuotaPreference);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListQuotaInfosApiCall(ref gaxgrpc::ApiCall<ListQuotaInfosRequest, ListQuotaInfosResponse> call);

        partial void Modify_GetQuotaInfoApiCall(ref gaxgrpc::ApiCall<GetQuotaInfoRequest, QuotaInfo> call);

        partial void Modify_ListQuotaPreferencesApiCall(ref gaxgrpc::ApiCall<ListQuotaPreferencesRequest, ListQuotaPreferencesResponse> call);

        partial void Modify_GetQuotaPreferenceApiCall(ref gaxgrpc::ApiCall<GetQuotaPreferenceRequest, QuotaPreference> call);

        partial void Modify_CreateQuotaPreferenceApiCall(ref gaxgrpc::ApiCall<CreateQuotaPreferenceRequest, QuotaPreference> call);

        partial void Modify_UpdateQuotaPreferenceApiCall(ref gaxgrpc::ApiCall<UpdateQuotaPreferenceRequest, QuotaPreference> call);

        partial void OnConstruction(CloudQuotas.CloudQuotasClient grpcClient, CloudQuotasSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CloudQuotas client</summary>
        public override CloudQuotas.CloudQuotasClient GrpcClient { get; }

        partial void Modify_ListQuotaInfosRequest(ref ListQuotaInfosRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetQuotaInfoRequest(ref GetQuotaInfoRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListQuotaPreferencesRequest(ref ListQuotaPreferencesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetQuotaPreferenceRequest(ref GetQuotaPreferenceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateQuotaPreferenceRequest(ref CreateQuotaPreferenceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateQuotaPreferenceRequest(ref UpdateQuotaPreferenceRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists QuotaInfos of all quotas for a given project, folder or organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="QuotaInfo"/> resources.</returns>
        public override gax::PagedEnumerable<ListQuotaInfosResponse, QuotaInfo> ListQuotaInfos(ListQuotaInfosRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListQuotaInfosRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListQuotaInfosRequest, ListQuotaInfosResponse, QuotaInfo>(_callListQuotaInfos, request, callSettings);
        }

        /// <summary>
        /// Lists QuotaInfos of all quotas for a given project, folder or organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="QuotaInfo"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListQuotaInfosResponse, QuotaInfo> ListQuotaInfosAsync(ListQuotaInfosRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListQuotaInfosRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListQuotaInfosRequest, ListQuotaInfosResponse, QuotaInfo>(_callListQuotaInfos, request, callSettings);
        }

        /// <summary>
        /// Retrieve the QuotaInfo of a quota for a project, folder or organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override QuotaInfo GetQuotaInfo(GetQuotaInfoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetQuotaInfoRequest(ref request, ref callSettings);
            return _callGetQuotaInfo.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieve the QuotaInfo of a quota for a project, folder or organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<QuotaInfo> GetQuotaInfoAsync(GetQuotaInfoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetQuotaInfoRequest(ref request, ref callSettings);
            return _callGetQuotaInfo.Async(request, callSettings);
        }

        /// <summary>
        /// Lists QuotaPreferences in a given project, folder or organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="QuotaPreference"/> resources.</returns>
        public override gax::PagedEnumerable<ListQuotaPreferencesResponse, QuotaPreference> ListQuotaPreferences(ListQuotaPreferencesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListQuotaPreferencesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListQuotaPreferencesRequest, ListQuotaPreferencesResponse, QuotaPreference>(_callListQuotaPreferences, request, callSettings);
        }

        /// <summary>
        /// Lists QuotaPreferences in a given project, folder or organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="QuotaPreference"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListQuotaPreferencesResponse, QuotaPreference> ListQuotaPreferencesAsync(ListQuotaPreferencesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListQuotaPreferencesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListQuotaPreferencesRequest, ListQuotaPreferencesResponse, QuotaPreference>(_callListQuotaPreferences, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single QuotaPreference.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override QuotaPreference GetQuotaPreference(GetQuotaPreferenceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetQuotaPreferenceRequest(ref request, ref callSettings);
            return _callGetQuotaPreference.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single QuotaPreference.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<QuotaPreference> GetQuotaPreferenceAsync(GetQuotaPreferenceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetQuotaPreferenceRequest(ref request, ref callSettings);
            return _callGetQuotaPreference.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new QuotaPreference that declares the desired value for a quota.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override QuotaPreference CreateQuotaPreference(CreateQuotaPreferenceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateQuotaPreferenceRequest(ref request, ref callSettings);
            return _callCreateQuotaPreference.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new QuotaPreference that declares the desired value for a quota.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<QuotaPreference> CreateQuotaPreferenceAsync(CreateQuotaPreferenceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateQuotaPreferenceRequest(ref request, ref callSettings);
            return _callCreateQuotaPreference.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the parameters of a single QuotaPreference. It can updates the
        /// config in any states, not just the ones pending approval.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override QuotaPreference UpdateQuotaPreference(UpdateQuotaPreferenceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateQuotaPreferenceRequest(ref request, ref callSettings);
            return _callUpdateQuotaPreference.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the parameters of a single QuotaPreference. It can updates the
        /// config in any states, not just the ones pending approval.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<QuotaPreference> UpdateQuotaPreferenceAsync(UpdateQuotaPreferenceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateQuotaPreferenceRequest(ref request, ref callSettings);
            return _callUpdateQuotaPreference.Async(request, callSettings);
        }
    }

    public partial class ListQuotaInfosRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListQuotaPreferencesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListQuotaInfosResponse : gaxgrpc::IPageResponse<QuotaInfo>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<QuotaInfo> GetEnumerator() => QuotaInfos.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListQuotaPreferencesResponse : gaxgrpc::IPageResponse<QuotaPreference>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<QuotaPreference> GetEnumerator() => QuotaPreferences.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
