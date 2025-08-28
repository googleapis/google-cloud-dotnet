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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.CloudSecurityCompliance.V1
{
    /// <summary>Settings for <see cref="ConfigClient"/> instances.</summary>
    public sealed partial class ConfigSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ConfigSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ConfigSettings"/>.</returns>
        public static ConfigSettings GetDefault() => new ConfigSettings();

        /// <summary>Constructs a new <see cref="ConfigSettings"/> object with default settings.</summary>
        public ConfigSettings()
        {
        }

        private ConfigSettings(ConfigSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListFrameworksSettings = existing.ListFrameworksSettings;
            GetFrameworkSettings = existing.GetFrameworkSettings;
            CreateFrameworkSettings = existing.CreateFrameworkSettings;
            UpdateFrameworkSettings = existing.UpdateFrameworkSettings;
            DeleteFrameworkSettings = existing.DeleteFrameworkSettings;
            ListCloudControlsSettings = existing.ListCloudControlsSettings;
            GetCloudControlSettings = existing.GetCloudControlSettings;
            CreateCloudControlSettings = existing.CreateCloudControlSettings;
            UpdateCloudControlSettings = existing.UpdateCloudControlSettings;
            DeleteCloudControlSettings = existing.DeleteCloudControlSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ConfigSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ConfigClient.ListFrameworks</c>
        ///  and <c>ConfigClient.ListFrameworksAsync</c>.
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
        public gaxgrpc::CallSettings ListFrameworksSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ConfigClient.GetFramework</c>
        ///  and <c>ConfigClient.GetFrameworkAsync</c>.
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
        public gaxgrpc::CallSettings GetFrameworkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigClient.CreateFramework</c> and <c>ConfigClient.CreateFrameworkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateFrameworkSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigClient.UpdateFramework</c> and <c>ConfigClient.UpdateFrameworkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateFrameworkSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigClient.DeleteFramework</c> and <c>ConfigClient.DeleteFrameworkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteFrameworkSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigClient.ListCloudControls</c> and <c>ConfigClient.ListCloudControlsAsync</c>.
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
        public gaxgrpc::CallSettings ListCloudControlsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigClient.GetCloudControl</c> and <c>ConfigClient.GetCloudControlAsync</c>.
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
        public gaxgrpc::CallSettings GetCloudControlSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigClient.CreateCloudControl</c> and <c>ConfigClient.CreateCloudControlAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateCloudControlSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigClient.UpdateCloudControl</c> and <c>ConfigClient.UpdateCloudControlAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateCloudControlSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigClient.DeleteCloudControl</c> and <c>ConfigClient.DeleteCloudControlAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteCloudControlSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ConfigSettings"/> object.</returns>
        public ConfigSettings Clone() => new ConfigSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ConfigClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ConfigClientBuilder : gaxgrpc::ClientBuilderBase<ConfigClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ConfigSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ConfigClientBuilder() : base(ConfigClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ConfigClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ConfigClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ConfigClient Build()
        {
            ConfigClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ConfigClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ConfigClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ConfigClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ConfigClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ConfigClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ConfigClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ConfigClient.ChannelPool;
    }

    /// <summary>Config client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for config resources
    /// </remarks>
    public abstract partial class ConfigClient
    {
        /// <summary>
        /// The default endpoint for the Config service, which is a host of "cloudsecuritycompliance.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudsecuritycompliance.googleapis.com:443";

        /// <summary>The default Config scopes.</summary>
        /// <remarks>
        /// The default Config scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Config.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ConfigClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="ConfigClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ConfigClient"/>.</returns>
        public static stt::Task<ConfigClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ConfigClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ConfigClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="ConfigClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ConfigClient"/>.</returns>
        public static ConfigClient Create() => new ConfigClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ConfigClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ConfigSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ConfigClient"/>.</returns>
        internal static ConfigClient Create(grpccore::CallInvoker callInvoker, ConfigSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Config.ConfigClient grpcClient = new Config.ConfigClient(callInvoker);
            return new ConfigClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Config client</summary>
        public virtual Config.ConfigClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Frameworks in a given organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Framework"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFrameworksResponse, Framework> ListFrameworks(ListFrameworksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Frameworks in a given organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Framework"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFrameworksResponse, Framework> ListFrameworksAsync(ListFrameworksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Frameworks in a given organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, in the format
        /// `organizations/{organization}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="Framework"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFrameworksResponse, Framework> ListFrameworks(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFrameworksRequest request = new ListFrameworksRequest
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
            return ListFrameworks(request, callSettings);
        }

        /// <summary>
        /// Lists Frameworks in a given organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, in the format
        /// `organizations/{organization}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Framework"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFrameworksResponse, Framework> ListFrameworksAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFrameworksRequest request = new ListFrameworksRequest
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
            return ListFrameworksAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Frameworks in a given organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, in the format
        /// `organizations/{organization}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="Framework"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFrameworksResponse, Framework> ListFrameworks(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFrameworksRequest request = new ListFrameworksRequest
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
            return ListFrameworks(request, callSettings);
        }

        /// <summary>
        /// Lists Frameworks in a given organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, in the format
        /// `organizations/{organization}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Framework"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFrameworksResponse, Framework> ListFrameworksAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFrameworksRequest request = new ListFrameworksRequest
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
            return ListFrameworksAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Framework.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Framework GetFramework(GetFrameworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Framework.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Framework> GetFrameworkAsync(GetFrameworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Framework.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Framework> GetFrameworkAsync(GetFrameworkRequest request, st::CancellationToken cancellationToken) =>
            GetFrameworkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Framework.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the framework to retrieve.
        /// Format:
        /// organizations/{organization}/locations/{location}/frameworks/{framework_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Framework GetFramework(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFramework(new GetFrameworkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Framework.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the framework to retrieve.
        /// Format:
        /// organizations/{organization}/locations/{location}/frameworks/{framework_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Framework> GetFrameworkAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFrameworkAsync(new GetFrameworkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Framework.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the framework to retrieve.
        /// Format:
        /// organizations/{organization}/locations/{location}/frameworks/{framework_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Framework> GetFrameworkAsync(string name, st::CancellationToken cancellationToken) =>
            GetFrameworkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Framework.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the framework to retrieve.
        /// Format:
        /// organizations/{organization}/locations/{location}/frameworks/{framework_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Framework GetFramework(FrameworkName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFramework(new GetFrameworkRequest
            {
                FrameworkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Framework.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the framework to retrieve.
        /// Format:
        /// organizations/{organization}/locations/{location}/frameworks/{framework_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Framework> GetFrameworkAsync(FrameworkName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFrameworkAsync(new GetFrameworkRequest
            {
                FrameworkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Framework.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the framework to retrieve.
        /// Format:
        /// organizations/{organization}/locations/{location}/frameworks/{framework_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Framework> GetFrameworkAsync(FrameworkName name, st::CancellationToken cancellationToken) =>
            GetFrameworkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a single framework for a given resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Framework CreateFramework(CreateFrameworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a single framework for a given resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Framework> CreateFrameworkAsync(CreateFrameworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a single framework for a given resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Framework> CreateFrameworkAsync(CreateFrameworkRequest request, st::CancellationToken cancellationToken) =>
            CreateFrameworkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a single framework for a given resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, in the format
        /// `organizations/{organization}/locations/{location}`.
        /// </param>
        /// <param name="framework">
        /// Required. The resource being created
        /// </param>
        /// <param name="frameworkId">
        /// Required. ID of the framework.
        /// This is not the full name of the framework.
        /// This is the last part of the full name of the framework.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Framework CreateFramework(string parent, Framework framework, string frameworkId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFramework(new CreateFrameworkRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                FrameworkId = gax::GaxPreconditions.CheckNotNullOrEmpty(frameworkId, nameof(frameworkId)),
                Framework = gax::GaxPreconditions.CheckNotNull(framework, nameof(framework)),
            }, callSettings);

        /// <summary>
        /// Creates a single framework for a given resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, in the format
        /// `organizations/{organization}/locations/{location}`.
        /// </param>
        /// <param name="framework">
        /// Required. The resource being created
        /// </param>
        /// <param name="frameworkId">
        /// Required. ID of the framework.
        /// This is not the full name of the framework.
        /// This is the last part of the full name of the framework.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Framework> CreateFrameworkAsync(string parent, Framework framework, string frameworkId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFrameworkAsync(new CreateFrameworkRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                FrameworkId = gax::GaxPreconditions.CheckNotNullOrEmpty(frameworkId, nameof(frameworkId)),
                Framework = gax::GaxPreconditions.CheckNotNull(framework, nameof(framework)),
            }, callSettings);

        /// <summary>
        /// Creates a single framework for a given resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, in the format
        /// `organizations/{organization}/locations/{location}`.
        /// </param>
        /// <param name="framework">
        /// Required. The resource being created
        /// </param>
        /// <param name="frameworkId">
        /// Required. ID of the framework.
        /// This is not the full name of the framework.
        /// This is the last part of the full name of the framework.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Framework> CreateFrameworkAsync(string parent, Framework framework, string frameworkId, st::CancellationToken cancellationToken) =>
            CreateFrameworkAsync(parent, framework, frameworkId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a single framework for a given resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, in the format
        /// `organizations/{organization}/locations/{location}`.
        /// </param>
        /// <param name="framework">
        /// Required. The resource being created
        /// </param>
        /// <param name="frameworkId">
        /// Required. ID of the framework.
        /// This is not the full name of the framework.
        /// This is the last part of the full name of the framework.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Framework CreateFramework(OrganizationLocationName parent, Framework framework, string frameworkId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFramework(new CreateFrameworkRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                FrameworkId = gax::GaxPreconditions.CheckNotNullOrEmpty(frameworkId, nameof(frameworkId)),
                Framework = gax::GaxPreconditions.CheckNotNull(framework, nameof(framework)),
            }, callSettings);

        /// <summary>
        /// Creates a single framework for a given resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, in the format
        /// `organizations/{organization}/locations/{location}`.
        /// </param>
        /// <param name="framework">
        /// Required. The resource being created
        /// </param>
        /// <param name="frameworkId">
        /// Required. ID of the framework.
        /// This is not the full name of the framework.
        /// This is the last part of the full name of the framework.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Framework> CreateFrameworkAsync(OrganizationLocationName parent, Framework framework, string frameworkId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFrameworkAsync(new CreateFrameworkRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                FrameworkId = gax::GaxPreconditions.CheckNotNullOrEmpty(frameworkId, nameof(frameworkId)),
                Framework = gax::GaxPreconditions.CheckNotNull(framework, nameof(framework)),
            }, callSettings);

        /// <summary>
        /// Creates a single framework for a given resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, in the format
        /// `organizations/{organization}/locations/{location}`.
        /// </param>
        /// <param name="framework">
        /// Required. The resource being created
        /// </param>
        /// <param name="frameworkId">
        /// Required. ID of the framework.
        /// This is not the full name of the framework.
        /// This is the last part of the full name of the framework.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Framework> CreateFrameworkAsync(OrganizationLocationName parent, Framework framework, string frameworkId, st::CancellationToken cancellationToken) =>
            CreateFrameworkAsync(parent, framework, frameworkId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a single Framework.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Framework UpdateFramework(UpdateFrameworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a single Framework.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Framework> UpdateFrameworkAsync(UpdateFrameworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a single Framework.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Framework> UpdateFrameworkAsync(UpdateFrameworkRequest request, st::CancellationToken cancellationToken) =>
            UpdateFrameworkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a single Framework.
        /// </summary>
        /// <param name="framework">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Framework resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields present in the request will be
        /// overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Framework UpdateFramework(Framework framework, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFramework(new UpdateFrameworkRequest
            {
                UpdateMask = updateMask,
                Framework = gax::GaxPreconditions.CheckNotNull(framework, nameof(framework)),
            }, callSettings);

        /// <summary>
        /// Updates a single Framework.
        /// </summary>
        /// <param name="framework">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Framework resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields present in the request will be
        /// overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Framework> UpdateFrameworkAsync(Framework framework, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFrameworkAsync(new UpdateFrameworkRequest
            {
                UpdateMask = updateMask,
                Framework = gax::GaxPreconditions.CheckNotNull(framework, nameof(framework)),
            }, callSettings);

        /// <summary>
        /// Updates a single Framework.
        /// </summary>
        /// <param name="framework">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Framework resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields present in the request will be
        /// overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Framework> UpdateFrameworkAsync(Framework framework, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateFrameworkAsync(framework, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Framework.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteFramework(DeleteFrameworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Framework.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFrameworkAsync(DeleteFrameworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Framework.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFrameworkAsync(DeleteFrameworkRequest request, st::CancellationToken cancellationToken) =>
            DeleteFrameworkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Framework.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the format
        /// `organizations/{organization}/locations/{location}/frameworks/{framework}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteFramework(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFramework(new DeleteFrameworkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Framework.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the format
        /// `organizations/{organization}/locations/{location}/frameworks/{framework}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFrameworkAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFrameworkAsync(new DeleteFrameworkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Framework.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the format
        /// `organizations/{organization}/locations/{location}/frameworks/{framework}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFrameworkAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteFrameworkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Framework.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the format
        /// `organizations/{organization}/locations/{location}/frameworks/{framework}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteFramework(FrameworkName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFramework(new DeleteFrameworkRequest
            {
                FrameworkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Framework.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the format
        /// `organizations/{organization}/locations/{location}/frameworks/{framework}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFrameworkAsync(FrameworkName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFrameworkAsync(new DeleteFrameworkRequest
            {
                FrameworkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Framework.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the format
        /// `organizations/{organization}/locations/{location}/frameworks/{framework}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFrameworkAsync(FrameworkName name, st::CancellationToken cancellationToken) =>
            DeleteFrameworkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists CloudControls in a given organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CloudControl"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCloudControlsResponse, CloudControl> ListCloudControls(ListCloudControlsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists CloudControls in a given organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CloudControl"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCloudControlsResponse, CloudControl> ListCloudControlsAsync(ListCloudControlsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists CloudControls in a given organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, in the format
        /// `organizations/{organization}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="CloudControl"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCloudControlsResponse, CloudControl> ListCloudControls(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCloudControlsRequest request = new ListCloudControlsRequest
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
            return ListCloudControls(request, callSettings);
        }

        /// <summary>
        /// Lists CloudControls in a given organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, in the format
        /// `organizations/{organization}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CloudControl"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCloudControlsResponse, CloudControl> ListCloudControlsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCloudControlsRequest request = new ListCloudControlsRequest
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
            return ListCloudControlsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists CloudControls in a given organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, in the format
        /// `organizations/{organization}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="CloudControl"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCloudControlsResponse, CloudControl> ListCloudControls(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCloudControlsRequest request = new ListCloudControlsRequest
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
            return ListCloudControls(request, callSettings);
        }

        /// <summary>
        /// Lists CloudControls in a given organization.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, in the format
        /// `organizations/{organization}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CloudControl"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCloudControlsResponse, CloudControl> ListCloudControlsAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCloudControlsRequest request = new ListCloudControlsRequest
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
            return ListCloudControlsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single CloudControl.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CloudControl GetCloudControl(GetCloudControlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single CloudControl.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudControl> GetCloudControlAsync(GetCloudControlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single CloudControl.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudControl> GetCloudControlAsync(GetCloudControlRequest request, st::CancellationToken cancellationToken) =>
            GetCloudControlAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single CloudControl.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the cloudcontrol to retrieve in the format:
        /// organizations/{organization}/locations/{location}/cloudControls/{cloud_control}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CloudControl GetCloudControl(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCloudControl(new GetCloudControlRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single CloudControl.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the cloudcontrol to retrieve in the format:
        /// organizations/{organization}/locations/{location}/cloudControls/{cloud_control}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudControl> GetCloudControlAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCloudControlAsync(new GetCloudControlRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single CloudControl.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the cloudcontrol to retrieve in the format:
        /// organizations/{organization}/locations/{location}/cloudControls/{cloud_control}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudControl> GetCloudControlAsync(string name, st::CancellationToken cancellationToken) =>
            GetCloudControlAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single CloudControl.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the cloudcontrol to retrieve in the format:
        /// organizations/{organization}/locations/{location}/cloudControls/{cloud_control}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CloudControl GetCloudControl(CloudControlName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCloudControl(new GetCloudControlRequest
            {
                CloudControlName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single CloudControl.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the cloudcontrol to retrieve in the format:
        /// organizations/{organization}/locations/{location}/cloudControls/{cloud_control}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudControl> GetCloudControlAsync(CloudControlName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCloudControlAsync(new GetCloudControlRequest
            {
                CloudControlName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single CloudControl.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the cloudcontrol to retrieve in the format:
        /// organizations/{organization}/locations/{location}/cloudControls/{cloud_control}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudControl> GetCloudControlAsync(CloudControlName name, st::CancellationToken cancellationToken) =>
            GetCloudControlAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a single CloudControl for a given resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CloudControl CreateCloudControl(CreateCloudControlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a single CloudControl for a given resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudControl> CreateCloudControlAsync(CreateCloudControlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a single CloudControl for a given resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudControl> CreateCloudControlAsync(CreateCloudControlRequest request, st::CancellationToken cancellationToken) =>
            CreateCloudControlAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a single CloudControl for a given resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, in the format
        /// `organizations/{organization}/locations/{location}`.
        /// </param>
        /// <param name="cloudControl">
        /// Required. The resource being created
        /// </param>
        /// <param name="cloudControlId">
        /// Required. ID of the CloudControl.
        /// This is the last segment of the CloudControl resource name.
        /// Format: `^[a-zA-Z][a-zA-Z0-9-]{0,61}[a-zA-Z0-9]$`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CloudControl CreateCloudControl(string parent, CloudControl cloudControl, string cloudControlId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCloudControl(new CreateCloudControlRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CloudControlId = gax::GaxPreconditions.CheckNotNullOrEmpty(cloudControlId, nameof(cloudControlId)),
                CloudControl = gax::GaxPreconditions.CheckNotNull(cloudControl, nameof(cloudControl)),
            }, callSettings);

        /// <summary>
        /// Creates a single CloudControl for a given resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, in the format
        /// `organizations/{organization}/locations/{location}`.
        /// </param>
        /// <param name="cloudControl">
        /// Required. The resource being created
        /// </param>
        /// <param name="cloudControlId">
        /// Required. ID of the CloudControl.
        /// This is the last segment of the CloudControl resource name.
        /// Format: `^[a-zA-Z][a-zA-Z0-9-]{0,61}[a-zA-Z0-9]$`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudControl> CreateCloudControlAsync(string parent, CloudControl cloudControl, string cloudControlId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCloudControlAsync(new CreateCloudControlRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CloudControlId = gax::GaxPreconditions.CheckNotNullOrEmpty(cloudControlId, nameof(cloudControlId)),
                CloudControl = gax::GaxPreconditions.CheckNotNull(cloudControl, nameof(cloudControl)),
            }, callSettings);

        /// <summary>
        /// Creates a single CloudControl for a given resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, in the format
        /// `organizations/{organization}/locations/{location}`.
        /// </param>
        /// <param name="cloudControl">
        /// Required. The resource being created
        /// </param>
        /// <param name="cloudControlId">
        /// Required. ID of the CloudControl.
        /// This is the last segment of the CloudControl resource name.
        /// Format: `^[a-zA-Z][a-zA-Z0-9-]{0,61}[a-zA-Z0-9]$`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudControl> CreateCloudControlAsync(string parent, CloudControl cloudControl, string cloudControlId, st::CancellationToken cancellationToken) =>
            CreateCloudControlAsync(parent, cloudControl, cloudControlId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a single CloudControl for a given resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, in the format
        /// `organizations/{organization}/locations/{location}`.
        /// </param>
        /// <param name="cloudControl">
        /// Required. The resource being created
        /// </param>
        /// <param name="cloudControlId">
        /// Required. ID of the CloudControl.
        /// This is the last segment of the CloudControl resource name.
        /// Format: `^[a-zA-Z][a-zA-Z0-9-]{0,61}[a-zA-Z0-9]$`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CloudControl CreateCloudControl(OrganizationLocationName parent, CloudControl cloudControl, string cloudControlId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCloudControl(new CreateCloudControlRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CloudControlId = gax::GaxPreconditions.CheckNotNullOrEmpty(cloudControlId, nameof(cloudControlId)),
                CloudControl = gax::GaxPreconditions.CheckNotNull(cloudControl, nameof(cloudControl)),
            }, callSettings);

        /// <summary>
        /// Creates a single CloudControl for a given resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, in the format
        /// `organizations/{organization}/locations/{location}`.
        /// </param>
        /// <param name="cloudControl">
        /// Required. The resource being created
        /// </param>
        /// <param name="cloudControlId">
        /// Required. ID of the CloudControl.
        /// This is the last segment of the CloudControl resource name.
        /// Format: `^[a-zA-Z][a-zA-Z0-9-]{0,61}[a-zA-Z0-9]$`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudControl> CreateCloudControlAsync(OrganizationLocationName parent, CloudControl cloudControl, string cloudControlId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCloudControlAsync(new CreateCloudControlRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CloudControlId = gax::GaxPreconditions.CheckNotNullOrEmpty(cloudControlId, nameof(cloudControlId)),
                CloudControl = gax::GaxPreconditions.CheckNotNull(cloudControl, nameof(cloudControl)),
            }, callSettings);

        /// <summary>
        /// Creates a single CloudControl for a given resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, in the format
        /// `organizations/{organization}/locations/{location}`.
        /// </param>
        /// <param name="cloudControl">
        /// Required. The resource being created
        /// </param>
        /// <param name="cloudControlId">
        /// Required. ID of the CloudControl.
        /// This is the last segment of the CloudControl resource name.
        /// Format: `^[a-zA-Z][a-zA-Z0-9-]{0,61}[a-zA-Z0-9]$`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudControl> CreateCloudControlAsync(OrganizationLocationName parent, CloudControl cloudControl, string cloudControlId, st::CancellationToken cancellationToken) =>
            CreateCloudControlAsync(parent, cloudControl, cloudControlId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a single CloudControl.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CloudControl UpdateCloudControl(UpdateCloudControlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a single CloudControl.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudControl> UpdateCloudControlAsync(UpdateCloudControlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a single CloudControl.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudControl> UpdateCloudControlAsync(UpdateCloudControlRequest request, st::CancellationToken cancellationToken) =>
            UpdateCloudControlAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a single CloudControl.
        /// </summary>
        /// <param name="cloudControl">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// CloudControl resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields present in the request will be
        /// overwritten. The fields that can be updated are:
        /// 1. Display_name
        /// 2. Description
        /// 3. Parameters
        /// 4. Rules
        /// 5. ParameterSpec.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CloudControl UpdateCloudControl(CloudControl cloudControl, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCloudControl(new UpdateCloudControlRequest
            {
                UpdateMask = updateMask,
                CloudControl = gax::GaxPreconditions.CheckNotNull(cloudControl, nameof(cloudControl)),
            }, callSettings);

        /// <summary>
        /// Updates a single CloudControl.
        /// </summary>
        /// <param name="cloudControl">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// CloudControl resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields present in the request will be
        /// overwritten. The fields that can be updated are:
        /// 1. Display_name
        /// 2. Description
        /// 3. Parameters
        /// 4. Rules
        /// 5. ParameterSpec.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudControl> UpdateCloudControlAsync(CloudControl cloudControl, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCloudControlAsync(new UpdateCloudControlRequest
            {
                UpdateMask = updateMask,
                CloudControl = gax::GaxPreconditions.CheckNotNull(cloudControl, nameof(cloudControl)),
            }, callSettings);

        /// <summary>
        /// Updates a single CloudControl.
        /// </summary>
        /// <param name="cloudControl">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// CloudControl resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields present in the request will be
        /// overwritten. The fields that can be updated are:
        /// 1. Display_name
        /// 2. Description
        /// 3. Parameters
        /// 4. Rules
        /// 5. ParameterSpec.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudControl> UpdateCloudControlAsync(CloudControl cloudControl, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCloudControlAsync(cloudControl, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single CloudControl.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCloudControl(DeleteCloudControlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single CloudControl.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCloudControlAsync(DeleteCloudControlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single CloudControl.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCloudControlAsync(DeleteCloudControlRequest request, st::CancellationToken cancellationToken) =>
            DeleteCloudControlAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single CloudControl.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the format
        /// `organizations/{organization}/locations/{location}/CloudControls/{CloudControl}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCloudControl(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCloudControl(new DeleteCloudControlRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single CloudControl.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the format
        /// `organizations/{organization}/locations/{location}/CloudControls/{CloudControl}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCloudControlAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCloudControlAsync(new DeleteCloudControlRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single CloudControl.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the format
        /// `organizations/{organization}/locations/{location}/CloudControls/{CloudControl}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCloudControlAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteCloudControlAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single CloudControl.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the format
        /// `organizations/{organization}/locations/{location}/CloudControls/{CloudControl}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCloudControl(CloudControlName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCloudControl(new DeleteCloudControlRequest
            {
                CloudControlName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single CloudControl.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the format
        /// `organizations/{organization}/locations/{location}/CloudControls/{CloudControl}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCloudControlAsync(CloudControlName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCloudControlAsync(new DeleteCloudControlRequest
            {
                CloudControlName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single CloudControl.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the format
        /// `organizations/{organization}/locations/{location}/CloudControls/{CloudControl}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCloudControlAsync(CloudControlName name, st::CancellationToken cancellationToken) =>
            DeleteCloudControlAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Config client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for config resources
    /// </remarks>
    public sealed partial class ConfigClientImpl : ConfigClient
    {
        private readonly gaxgrpc::ApiCall<ListFrameworksRequest, ListFrameworksResponse> _callListFrameworks;

        private readonly gaxgrpc::ApiCall<GetFrameworkRequest, Framework> _callGetFramework;

        private readonly gaxgrpc::ApiCall<CreateFrameworkRequest, Framework> _callCreateFramework;

        private readonly gaxgrpc::ApiCall<UpdateFrameworkRequest, Framework> _callUpdateFramework;

        private readonly gaxgrpc::ApiCall<DeleteFrameworkRequest, wkt::Empty> _callDeleteFramework;

        private readonly gaxgrpc::ApiCall<ListCloudControlsRequest, ListCloudControlsResponse> _callListCloudControls;

        private readonly gaxgrpc::ApiCall<GetCloudControlRequest, CloudControl> _callGetCloudControl;

        private readonly gaxgrpc::ApiCall<CreateCloudControlRequest, CloudControl> _callCreateCloudControl;

        private readonly gaxgrpc::ApiCall<UpdateCloudControlRequest, CloudControl> _callUpdateCloudControl;

        private readonly gaxgrpc::ApiCall<DeleteCloudControlRequest, wkt::Empty> _callDeleteCloudControl;

        /// <summary>
        /// Constructs a client wrapper for the Config service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ConfigSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ConfigClientImpl(Config.ConfigClient grpcClient, ConfigSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ConfigSettings effectiveSettings = settings ?? ConfigSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListFrameworks = clientHelper.BuildApiCall<ListFrameworksRequest, ListFrameworksResponse>("ListFrameworks", grpcClient.ListFrameworksAsync, grpcClient.ListFrameworks, effectiveSettings.ListFrameworksSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListFrameworks);
            Modify_ListFrameworksApiCall(ref _callListFrameworks);
            _callGetFramework = clientHelper.BuildApiCall<GetFrameworkRequest, Framework>("GetFramework", grpcClient.GetFrameworkAsync, grpcClient.GetFramework, effectiveSettings.GetFrameworkSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetFramework);
            Modify_GetFrameworkApiCall(ref _callGetFramework);
            _callCreateFramework = clientHelper.BuildApiCall<CreateFrameworkRequest, Framework>("CreateFramework", grpcClient.CreateFrameworkAsync, grpcClient.CreateFramework, effectiveSettings.CreateFrameworkSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateFramework);
            Modify_CreateFrameworkApiCall(ref _callCreateFramework);
            _callUpdateFramework = clientHelper.BuildApiCall<UpdateFrameworkRequest, Framework>("UpdateFramework", grpcClient.UpdateFrameworkAsync, grpcClient.UpdateFramework, effectiveSettings.UpdateFrameworkSettings).WithGoogleRequestParam("framework.name", request => request.Framework?.Name);
            Modify_ApiCall(ref _callUpdateFramework);
            Modify_UpdateFrameworkApiCall(ref _callUpdateFramework);
            _callDeleteFramework = clientHelper.BuildApiCall<DeleteFrameworkRequest, wkt::Empty>("DeleteFramework", grpcClient.DeleteFrameworkAsync, grpcClient.DeleteFramework, effectiveSettings.DeleteFrameworkSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteFramework);
            Modify_DeleteFrameworkApiCall(ref _callDeleteFramework);
            _callListCloudControls = clientHelper.BuildApiCall<ListCloudControlsRequest, ListCloudControlsResponse>("ListCloudControls", grpcClient.ListCloudControlsAsync, grpcClient.ListCloudControls, effectiveSettings.ListCloudControlsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCloudControls);
            Modify_ListCloudControlsApiCall(ref _callListCloudControls);
            _callGetCloudControl = clientHelper.BuildApiCall<GetCloudControlRequest, CloudControl>("GetCloudControl", grpcClient.GetCloudControlAsync, grpcClient.GetCloudControl, effectiveSettings.GetCloudControlSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCloudControl);
            Modify_GetCloudControlApiCall(ref _callGetCloudControl);
            _callCreateCloudControl = clientHelper.BuildApiCall<CreateCloudControlRequest, CloudControl>("CreateCloudControl", grpcClient.CreateCloudControlAsync, grpcClient.CreateCloudControl, effectiveSettings.CreateCloudControlSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCloudControl);
            Modify_CreateCloudControlApiCall(ref _callCreateCloudControl);
            _callUpdateCloudControl = clientHelper.BuildApiCall<UpdateCloudControlRequest, CloudControl>("UpdateCloudControl", grpcClient.UpdateCloudControlAsync, grpcClient.UpdateCloudControl, effectiveSettings.UpdateCloudControlSettings).WithGoogleRequestParam("cloud_control.name", request => request.CloudControl?.Name);
            Modify_ApiCall(ref _callUpdateCloudControl);
            Modify_UpdateCloudControlApiCall(ref _callUpdateCloudControl);
            _callDeleteCloudControl = clientHelper.BuildApiCall<DeleteCloudControlRequest, wkt::Empty>("DeleteCloudControl", grpcClient.DeleteCloudControlAsync, grpcClient.DeleteCloudControl, effectiveSettings.DeleteCloudControlSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteCloudControl);
            Modify_DeleteCloudControlApiCall(ref _callDeleteCloudControl);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListFrameworksApiCall(ref gaxgrpc::ApiCall<ListFrameworksRequest, ListFrameworksResponse> call);

        partial void Modify_GetFrameworkApiCall(ref gaxgrpc::ApiCall<GetFrameworkRequest, Framework> call);

        partial void Modify_CreateFrameworkApiCall(ref gaxgrpc::ApiCall<CreateFrameworkRequest, Framework> call);

        partial void Modify_UpdateFrameworkApiCall(ref gaxgrpc::ApiCall<UpdateFrameworkRequest, Framework> call);

        partial void Modify_DeleteFrameworkApiCall(ref gaxgrpc::ApiCall<DeleteFrameworkRequest, wkt::Empty> call);

        partial void Modify_ListCloudControlsApiCall(ref gaxgrpc::ApiCall<ListCloudControlsRequest, ListCloudControlsResponse> call);

        partial void Modify_GetCloudControlApiCall(ref gaxgrpc::ApiCall<GetCloudControlRequest, CloudControl> call);

        partial void Modify_CreateCloudControlApiCall(ref gaxgrpc::ApiCall<CreateCloudControlRequest, CloudControl> call);

        partial void Modify_UpdateCloudControlApiCall(ref gaxgrpc::ApiCall<UpdateCloudControlRequest, CloudControl> call);

        partial void Modify_DeleteCloudControlApiCall(ref gaxgrpc::ApiCall<DeleteCloudControlRequest, wkt::Empty> call);

        partial void OnConstruction(Config.ConfigClient grpcClient, ConfigSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Config client</summary>
        public override Config.ConfigClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListFrameworksRequest(ref ListFrameworksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetFrameworkRequest(ref GetFrameworkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateFrameworkRequest(ref CreateFrameworkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateFrameworkRequest(ref UpdateFrameworkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteFrameworkRequest(ref DeleteFrameworkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCloudControlsRequest(ref ListCloudControlsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCloudControlRequest(ref GetCloudControlRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateCloudControlRequest(ref CreateCloudControlRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCloudControlRequest(ref UpdateCloudControlRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteCloudControlRequest(ref DeleteCloudControlRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists Frameworks in a given organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Framework"/> resources.</returns>
        public override gax::PagedEnumerable<ListFrameworksResponse, Framework> ListFrameworks(ListFrameworksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFrameworksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListFrameworksRequest, ListFrameworksResponse, Framework>(_callListFrameworks, request, callSettings);
        }

        /// <summary>
        /// Lists Frameworks in a given organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Framework"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListFrameworksResponse, Framework> ListFrameworksAsync(ListFrameworksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFrameworksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListFrameworksRequest, ListFrameworksResponse, Framework>(_callListFrameworks, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Framework.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Framework GetFramework(GetFrameworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFrameworkRequest(ref request, ref callSettings);
            return _callGetFramework.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Framework.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Framework> GetFrameworkAsync(GetFrameworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFrameworkRequest(ref request, ref callSettings);
            return _callGetFramework.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a single framework for a given resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Framework CreateFramework(CreateFrameworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFrameworkRequest(ref request, ref callSettings);
            return _callCreateFramework.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a single framework for a given resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Framework> CreateFrameworkAsync(CreateFrameworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFrameworkRequest(ref request, ref callSettings);
            return _callCreateFramework.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a single Framework.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Framework UpdateFramework(UpdateFrameworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFrameworkRequest(ref request, ref callSettings);
            return _callUpdateFramework.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a single Framework.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Framework> UpdateFrameworkAsync(UpdateFrameworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFrameworkRequest(ref request, ref callSettings);
            return _callUpdateFramework.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a single Framework.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteFramework(DeleteFrameworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFrameworkRequest(ref request, ref callSettings);
            _callDeleteFramework.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a single Framework.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteFrameworkAsync(DeleteFrameworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFrameworkRequest(ref request, ref callSettings);
            return _callDeleteFramework.Async(request, callSettings);
        }

        /// <summary>
        /// Lists CloudControls in a given organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CloudControl"/> resources.</returns>
        public override gax::PagedEnumerable<ListCloudControlsResponse, CloudControl> ListCloudControls(ListCloudControlsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCloudControlsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCloudControlsRequest, ListCloudControlsResponse, CloudControl>(_callListCloudControls, request, callSettings);
        }

        /// <summary>
        /// Lists CloudControls in a given organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CloudControl"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCloudControlsResponse, CloudControl> ListCloudControlsAsync(ListCloudControlsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCloudControlsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCloudControlsRequest, ListCloudControlsResponse, CloudControl>(_callListCloudControls, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single CloudControl.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CloudControl GetCloudControl(GetCloudControlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCloudControlRequest(ref request, ref callSettings);
            return _callGetCloudControl.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single CloudControl.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CloudControl> GetCloudControlAsync(GetCloudControlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCloudControlRequest(ref request, ref callSettings);
            return _callGetCloudControl.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a single CloudControl for a given resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CloudControl CreateCloudControl(CreateCloudControlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCloudControlRequest(ref request, ref callSettings);
            return _callCreateCloudControl.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a single CloudControl for a given resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CloudControl> CreateCloudControlAsync(CreateCloudControlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCloudControlRequest(ref request, ref callSettings);
            return _callCreateCloudControl.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a single CloudControl.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CloudControl UpdateCloudControl(UpdateCloudControlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCloudControlRequest(ref request, ref callSettings);
            return _callUpdateCloudControl.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a single CloudControl.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CloudControl> UpdateCloudControlAsync(UpdateCloudControlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCloudControlRequest(ref request, ref callSettings);
            return _callUpdateCloudControl.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a single CloudControl.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteCloudControl(DeleteCloudControlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCloudControlRequest(ref request, ref callSettings);
            _callDeleteCloudControl.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a single CloudControl.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteCloudControlAsync(DeleteCloudControlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCloudControlRequest(ref request, ref callSettings);
            return _callDeleteCloudControl.Async(request, callSettings);
        }
    }

    public partial class ListFrameworksRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCloudControlsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListFrameworksResponse : gaxgrpc::IPageResponse<Framework>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Framework> GetEnumerator() => Frameworks.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListCloudControlsResponse : gaxgrpc::IPageResponse<CloudControl>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CloudControl> GetEnumerator() => CloudControls.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Config
    {
        public partial class ConfigClient
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
