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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.ModelArmor.V1Beta
{
    /// <summary>Settings for <see cref="ModelArmorClient"/> instances.</summary>
    public sealed partial class ModelArmorSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ModelArmorSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ModelArmorSettings"/>.</returns>
        public static ModelArmorSettings GetDefault() => new ModelArmorSettings();

        /// <summary>Constructs a new <see cref="ModelArmorSettings"/> object with default settings.</summary>
        public ModelArmorSettings()
        {
        }

        private ModelArmorSettings(ModelArmorSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListTemplatesSettings = existing.ListTemplatesSettings;
            GetTemplateSettings = existing.GetTemplateSettings;
            CreateTemplateSettings = existing.CreateTemplateSettings;
            UpdateTemplateSettings = existing.UpdateTemplateSettings;
            DeleteTemplateSettings = existing.DeleteTemplateSettings;
            GetFloorSettingSettings = existing.GetFloorSettingSettings;
            UpdateFloorSettingSettings = existing.UpdateFloorSettingSettings;
            SanitizeUserPromptSettings = existing.SanitizeUserPromptSettings;
            SanitizeModelResponseSettings = existing.SanitizeModelResponseSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ModelArmorSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelArmorClient.ListTemplates</c> and <c>ModelArmorClient.ListTemplatesAsync</c>.
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
        public gaxgrpc::CallSettings ListTemplatesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelArmorClient.GetTemplate</c> and <c>ModelArmorClient.GetTemplateAsync</c>.
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
        public gaxgrpc::CallSettings GetTemplateSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelArmorClient.CreateTemplate</c> and <c>ModelArmorClient.CreateTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelArmorClient.UpdateTemplate</c> and <c>ModelArmorClient.UpdateTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelArmorClient.DeleteTemplate</c> and <c>ModelArmorClient.DeleteTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelArmorClient.GetFloorSetting</c> and <c>ModelArmorClient.GetFloorSettingAsync</c>.
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
        public gaxgrpc::CallSettings GetFloorSettingSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelArmorClient.UpdateFloorSetting</c> and <c>ModelArmorClient.UpdateFloorSettingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateFloorSettingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelArmorClient.SanitizeUserPrompt</c> and <c>ModelArmorClient.SanitizeUserPromptAsync</c>.
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
        public gaxgrpc::CallSettings SanitizeUserPromptSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ModelArmorClient.SanitizeModelResponse</c> and <c>ModelArmorClient.SanitizeModelResponseAsync</c>.
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
        public gaxgrpc::CallSettings SanitizeModelResponseSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ModelArmorSettings"/> object.</returns>
        public ModelArmorSettings Clone() => new ModelArmorSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ModelArmorClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ModelArmorClientBuilder : gaxgrpc::ClientBuilderBase<ModelArmorClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ModelArmorSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ModelArmorClientBuilder() : base(ModelArmorClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ModelArmorClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ModelArmorClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ModelArmorClient Build()
        {
            ModelArmorClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ModelArmorClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ModelArmorClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ModelArmorClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ModelArmorClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ModelArmorClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ModelArmorClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ModelArmorClient.ChannelPool;
    }

    /// <summary>ModelArmor client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public abstract partial class ModelArmorClient
    {
        /// <summary>
        /// The default endpoint for the ModelArmor service, which is a host of "modelarmor.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "modelarmor.googleapis.com:443";

        /// <summary>The default ModelArmor scopes.</summary>
        /// <remarks>
        /// The default ModelArmor scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ModelArmor.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ModelArmorClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ModelArmorClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ModelArmorClient"/>.</returns>
        public static stt::Task<ModelArmorClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ModelArmorClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ModelArmorClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="ModelArmorClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ModelArmorClient"/>.</returns>
        public static ModelArmorClient Create() => new ModelArmorClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ModelArmorClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ModelArmorSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ModelArmorClient"/>.</returns>
        internal static ModelArmorClient Create(grpccore::CallInvoker callInvoker, ModelArmorSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ModelArmor.ModelArmorClient grpcClient = new ModelArmor.ModelArmorClient(callInvoker);
            return new ModelArmorClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ModelArmor client</summary>
        public virtual ModelArmor.ModelArmorClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Templates in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Template"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTemplatesResponse, Template> ListTemplates(ListTemplatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Templates in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Template"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTemplatesResponse, Template> ListTemplatesAsync(ListTemplatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Templates in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListTemplatesRequest
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
        /// <returns>A pageable sequence of <see cref="Template"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTemplatesResponse, Template> ListTemplates(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTemplatesRequest request = new ListTemplatesRequest
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
            return ListTemplates(request, callSettings);
        }

        /// <summary>
        /// Lists Templates in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListTemplatesRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="Template"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTemplatesResponse, Template> ListTemplatesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTemplatesRequest request = new ListTemplatesRequest
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
            return ListTemplatesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Templates in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListTemplatesRequest
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
        /// <returns>A pageable sequence of <see cref="Template"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTemplatesResponse, Template> ListTemplates(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTemplatesRequest request = new ListTemplatesRequest
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
            return ListTemplates(request, callSettings);
        }

        /// <summary>
        /// Lists Templates in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListTemplatesRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="Template"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTemplatesResponse, Template> ListTemplatesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTemplatesRequest request = new ListTemplatesRequest
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
            return ListTemplatesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Template GetTemplate(GetTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Template> GetTemplateAsync(GetTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Template> GetTemplateAsync(GetTemplateRequest request, st::CancellationToken cancellationToken) =>
            GetTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Template.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Template GetTemplate(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTemplate(new GetTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Template.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Template> GetTemplateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTemplateAsync(new GetTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Template.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Template> GetTemplateAsync(string name, st::CancellationToken cancellationToken) =>
            GetTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Template.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Template GetTemplate(TemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTemplate(new GetTemplateRequest
            {
                TemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Template.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Template> GetTemplateAsync(TemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTemplateAsync(new GetTemplateRequest
            {
                TemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Template.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Template> GetTemplateAsync(TemplateName name, st::CancellationToken cancellationToken) =>
            GetTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Template in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Template CreateTemplate(CreateTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Template in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Template> CreateTemplateAsync(CreateTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Template in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Template> CreateTemplateAsync(CreateTemplateRequest request, st::CancellationToken cancellationToken) =>
            CreateTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Template in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="template">
        /// Required. The resource being created
        /// </param>
        /// <param name="templateId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// template_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Template CreateTemplate(string parent, Template template, string templateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTemplate(new CreateTemplateRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TemplateId = gax::GaxPreconditions.CheckNotNullOrEmpty(templateId, nameof(templateId)),
                Template = gax::GaxPreconditions.CheckNotNull(template, nameof(template)),
            }, callSettings);

        /// <summary>
        /// Creates a new Template in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="template">
        /// Required. The resource being created
        /// </param>
        /// <param name="templateId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// template_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Template> CreateTemplateAsync(string parent, Template template, string templateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTemplateAsync(new CreateTemplateRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TemplateId = gax::GaxPreconditions.CheckNotNullOrEmpty(templateId, nameof(templateId)),
                Template = gax::GaxPreconditions.CheckNotNull(template, nameof(template)),
            }, callSettings);

        /// <summary>
        /// Creates a new Template in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="template">
        /// Required. The resource being created
        /// </param>
        /// <param name="templateId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// template_id from the method_signature of Create RPC
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Template> CreateTemplateAsync(string parent, Template template, string templateId, st::CancellationToken cancellationToken) =>
            CreateTemplateAsync(parent, template, templateId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Template in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="template">
        /// Required. The resource being created
        /// </param>
        /// <param name="templateId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// template_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Template CreateTemplate(gagr::LocationName parent, Template template, string templateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTemplate(new CreateTemplateRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TemplateId = gax::GaxPreconditions.CheckNotNullOrEmpty(templateId, nameof(templateId)),
                Template = gax::GaxPreconditions.CheckNotNull(template, nameof(template)),
            }, callSettings);

        /// <summary>
        /// Creates a new Template in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="template">
        /// Required. The resource being created
        /// </param>
        /// <param name="templateId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// template_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Template> CreateTemplateAsync(gagr::LocationName parent, Template template, string templateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTemplateAsync(new CreateTemplateRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TemplateId = gax::GaxPreconditions.CheckNotNullOrEmpty(templateId, nameof(templateId)),
                Template = gax::GaxPreconditions.CheckNotNull(template, nameof(template)),
            }, callSettings);

        /// <summary>
        /// Creates a new Template in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="template">
        /// Required. The resource being created
        /// </param>
        /// <param name="templateId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// template_id from the method_signature of Create RPC
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Template> CreateTemplateAsync(gagr::LocationName parent, Template template, string templateId, st::CancellationToken cancellationToken) =>
            CreateTemplateAsync(parent, template, templateId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Template UpdateTemplate(UpdateTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Template> UpdateTemplateAsync(UpdateTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Template> UpdateTemplateAsync(UpdateTemplateRequest request, st::CancellationToken cancellationToken) =>
            UpdateTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Template.
        /// </summary>
        /// <param name="template">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Template resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Template UpdateTemplate(Template template, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTemplate(new UpdateTemplateRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Template = gax::GaxPreconditions.CheckNotNull(template, nameof(template)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Template.
        /// </summary>
        /// <param name="template">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Template resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Template> UpdateTemplateAsync(Template template, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTemplateAsync(new UpdateTemplateRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Template = gax::GaxPreconditions.CheckNotNull(template, nameof(template)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Template.
        /// </summary>
        /// <param name="template">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Template resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Template> UpdateTemplateAsync(Template template, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateTemplateAsync(template, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTemplate(DeleteTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTemplateAsync(DeleteTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTemplateAsync(DeleteTemplateRequest request, st::CancellationToken cancellationToken) =>
            DeleteTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Template.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTemplate(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTemplate(new DeleteTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Template.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTemplateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTemplateAsync(new DeleteTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Template.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTemplateAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Template.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTemplate(TemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTemplate(new DeleteTemplateRequest
            {
                TemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Template.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTemplateAsync(TemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTemplateAsync(new DeleteTemplateRequest
            {
                TemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Template.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTemplateAsync(TemplateName name, st::CancellationToken cancellationToken) =>
            DeleteTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single floor setting of a project
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FloorSetting GetFloorSetting(GetFloorSettingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single floor setting of a project
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FloorSetting> GetFloorSettingAsync(GetFloorSettingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single floor setting of a project
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FloorSetting> GetFloorSettingAsync(GetFloorSettingRequest request, st::CancellationToken cancellationToken) =>
            GetFloorSettingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single floor setting of a project
        /// </summary>
        /// <param name="name">
        /// Required. The name of the floor setting to get, example
        /// projects/123/floorsetting.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FloorSetting GetFloorSetting(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFloorSetting(new GetFloorSettingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single floor setting of a project
        /// </summary>
        /// <param name="name">
        /// Required. The name of the floor setting to get, example
        /// projects/123/floorsetting.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FloorSetting> GetFloorSettingAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFloorSettingAsync(new GetFloorSettingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single floor setting of a project
        /// </summary>
        /// <param name="name">
        /// Required. The name of the floor setting to get, example
        /// projects/123/floorsetting.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FloorSetting> GetFloorSettingAsync(string name, st::CancellationToken cancellationToken) =>
            GetFloorSettingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single floor setting of a project
        /// </summary>
        /// <param name="name">
        /// Required. The name of the floor setting to get, example
        /// projects/123/floorsetting.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FloorSetting GetFloorSetting(FloorSettingName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFloorSetting(new GetFloorSettingRequest
            {
                FloorSettingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single floor setting of a project
        /// </summary>
        /// <param name="name">
        /// Required. The name of the floor setting to get, example
        /// projects/123/floorsetting.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FloorSetting> GetFloorSettingAsync(FloorSettingName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFloorSettingAsync(new GetFloorSettingRequest
            {
                FloorSettingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single floor setting of a project
        /// </summary>
        /// <param name="name">
        /// Required. The name of the floor setting to get, example
        /// projects/123/floorsetting.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FloorSetting> GetFloorSettingAsync(FloorSettingName name, st::CancellationToken cancellationToken) =>
            GetFloorSettingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single floor setting of a project
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FloorSetting UpdateFloorSetting(UpdateFloorSettingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single floor setting of a project
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FloorSetting> UpdateFloorSettingAsync(UpdateFloorSettingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single floor setting of a project
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FloorSetting> UpdateFloorSettingAsync(UpdateFloorSettingRequest request, st::CancellationToken cancellationToken) =>
            UpdateFloorSettingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single floor setting of a project
        /// </summary>
        /// <param name="floorSetting">
        /// Required. The floor setting being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// FloorSetting resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FloorSetting UpdateFloorSetting(FloorSetting floorSetting, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFloorSetting(new UpdateFloorSettingRequest
            {
                FloorSetting = gax::GaxPreconditions.CheckNotNull(floorSetting, nameof(floorSetting)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single floor setting of a project
        /// </summary>
        /// <param name="floorSetting">
        /// Required. The floor setting being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// FloorSetting resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FloorSetting> UpdateFloorSettingAsync(FloorSetting floorSetting, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFloorSettingAsync(new UpdateFloorSettingRequest
            {
                FloorSetting = gax::GaxPreconditions.CheckNotNull(floorSetting, nameof(floorSetting)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single floor setting of a project
        /// </summary>
        /// <param name="floorSetting">
        /// Required. The floor setting being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// FloorSetting resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FloorSetting> UpdateFloorSettingAsync(FloorSetting floorSetting, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateFloorSettingAsync(floorSetting, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sanitizes User Prompt.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SanitizeUserPromptResponse SanitizeUserPrompt(SanitizeUserPromptRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sanitizes User Prompt.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SanitizeUserPromptResponse> SanitizeUserPromptAsync(SanitizeUserPromptRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sanitizes User Prompt.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SanitizeUserPromptResponse> SanitizeUserPromptAsync(SanitizeUserPromptRequest request, st::CancellationToken cancellationToken) =>
            SanitizeUserPromptAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sanitizes Model Response.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SanitizeModelResponseResponse SanitizeModelResponse(SanitizeModelResponseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sanitizes Model Response.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SanitizeModelResponseResponse> SanitizeModelResponseAsync(SanitizeModelResponseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sanitizes Model Response.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SanitizeModelResponseResponse> SanitizeModelResponseAsync(SanitizeModelResponseRequest request, st::CancellationToken cancellationToken) =>
            SanitizeModelResponseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ModelArmor client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public sealed partial class ModelArmorClientImpl : ModelArmorClient
    {
        private readonly gaxgrpc::ApiCall<ListTemplatesRequest, ListTemplatesResponse> _callListTemplates;

        private readonly gaxgrpc::ApiCall<GetTemplateRequest, Template> _callGetTemplate;

        private readonly gaxgrpc::ApiCall<CreateTemplateRequest, Template> _callCreateTemplate;

        private readonly gaxgrpc::ApiCall<UpdateTemplateRequest, Template> _callUpdateTemplate;

        private readonly gaxgrpc::ApiCall<DeleteTemplateRequest, wkt::Empty> _callDeleteTemplate;

        private readonly gaxgrpc::ApiCall<GetFloorSettingRequest, FloorSetting> _callGetFloorSetting;

        private readonly gaxgrpc::ApiCall<UpdateFloorSettingRequest, FloorSetting> _callUpdateFloorSetting;

        private readonly gaxgrpc::ApiCall<SanitizeUserPromptRequest, SanitizeUserPromptResponse> _callSanitizeUserPrompt;

        private readonly gaxgrpc::ApiCall<SanitizeModelResponseRequest, SanitizeModelResponseResponse> _callSanitizeModelResponse;

        /// <summary>
        /// Constructs a client wrapper for the ModelArmor service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ModelArmorSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ModelArmorClientImpl(ModelArmor.ModelArmorClient grpcClient, ModelArmorSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ModelArmorSettings effectiveSettings = settings ?? ModelArmorSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListTemplates = clientHelper.BuildApiCall<ListTemplatesRequest, ListTemplatesResponse>("ListTemplates", grpcClient.ListTemplatesAsync, grpcClient.ListTemplates, effectiveSettings.ListTemplatesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTemplates);
            Modify_ListTemplatesApiCall(ref _callListTemplates);
            _callGetTemplate = clientHelper.BuildApiCall<GetTemplateRequest, Template>("GetTemplate", grpcClient.GetTemplateAsync, grpcClient.GetTemplate, effectiveSettings.GetTemplateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTemplate);
            Modify_GetTemplateApiCall(ref _callGetTemplate);
            _callCreateTemplate = clientHelper.BuildApiCall<CreateTemplateRequest, Template>("CreateTemplate", grpcClient.CreateTemplateAsync, grpcClient.CreateTemplate, effectiveSettings.CreateTemplateSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTemplate);
            Modify_CreateTemplateApiCall(ref _callCreateTemplate);
            _callUpdateTemplate = clientHelper.BuildApiCall<UpdateTemplateRequest, Template>("UpdateTemplate", grpcClient.UpdateTemplateAsync, grpcClient.UpdateTemplate, effectiveSettings.UpdateTemplateSettings).WithGoogleRequestParam("template.name", request => request.Template?.Name);
            Modify_ApiCall(ref _callUpdateTemplate);
            Modify_UpdateTemplateApiCall(ref _callUpdateTemplate);
            _callDeleteTemplate = clientHelper.BuildApiCall<DeleteTemplateRequest, wkt::Empty>("DeleteTemplate", grpcClient.DeleteTemplateAsync, grpcClient.DeleteTemplate, effectiveSettings.DeleteTemplateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTemplate);
            Modify_DeleteTemplateApiCall(ref _callDeleteTemplate);
            _callGetFloorSetting = clientHelper.BuildApiCall<GetFloorSettingRequest, FloorSetting>("GetFloorSetting", grpcClient.GetFloorSettingAsync, grpcClient.GetFloorSetting, effectiveSettings.GetFloorSettingSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetFloorSetting);
            Modify_GetFloorSettingApiCall(ref _callGetFloorSetting);
            _callUpdateFloorSetting = clientHelper.BuildApiCall<UpdateFloorSettingRequest, FloorSetting>("UpdateFloorSetting", grpcClient.UpdateFloorSettingAsync, grpcClient.UpdateFloorSetting, effectiveSettings.UpdateFloorSettingSettings).WithGoogleRequestParam("floor_setting.name", request => request.FloorSetting?.Name);
            Modify_ApiCall(ref _callUpdateFloorSetting);
            Modify_UpdateFloorSettingApiCall(ref _callUpdateFloorSetting);
            _callSanitizeUserPrompt = clientHelper.BuildApiCall<SanitizeUserPromptRequest, SanitizeUserPromptResponse>("SanitizeUserPrompt", grpcClient.SanitizeUserPromptAsync, grpcClient.SanitizeUserPrompt, effectiveSettings.SanitizeUserPromptSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callSanitizeUserPrompt);
            Modify_SanitizeUserPromptApiCall(ref _callSanitizeUserPrompt);
            _callSanitizeModelResponse = clientHelper.BuildApiCall<SanitizeModelResponseRequest, SanitizeModelResponseResponse>("SanitizeModelResponse", grpcClient.SanitizeModelResponseAsync, grpcClient.SanitizeModelResponse, effectiveSettings.SanitizeModelResponseSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callSanitizeModelResponse);
            Modify_SanitizeModelResponseApiCall(ref _callSanitizeModelResponse);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListTemplatesApiCall(ref gaxgrpc::ApiCall<ListTemplatesRequest, ListTemplatesResponse> call);

        partial void Modify_GetTemplateApiCall(ref gaxgrpc::ApiCall<GetTemplateRequest, Template> call);

        partial void Modify_CreateTemplateApiCall(ref gaxgrpc::ApiCall<CreateTemplateRequest, Template> call);

        partial void Modify_UpdateTemplateApiCall(ref gaxgrpc::ApiCall<UpdateTemplateRequest, Template> call);

        partial void Modify_DeleteTemplateApiCall(ref gaxgrpc::ApiCall<DeleteTemplateRequest, wkt::Empty> call);

        partial void Modify_GetFloorSettingApiCall(ref gaxgrpc::ApiCall<GetFloorSettingRequest, FloorSetting> call);

        partial void Modify_UpdateFloorSettingApiCall(ref gaxgrpc::ApiCall<UpdateFloorSettingRequest, FloorSetting> call);

        partial void Modify_SanitizeUserPromptApiCall(ref gaxgrpc::ApiCall<SanitizeUserPromptRequest, SanitizeUserPromptResponse> call);

        partial void Modify_SanitizeModelResponseApiCall(ref gaxgrpc::ApiCall<SanitizeModelResponseRequest, SanitizeModelResponseResponse> call);

        partial void OnConstruction(ModelArmor.ModelArmorClient grpcClient, ModelArmorSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ModelArmor client</summary>
        public override ModelArmor.ModelArmorClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListTemplatesRequest(ref ListTemplatesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTemplateRequest(ref GetTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTemplateRequest(ref CreateTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTemplateRequest(ref UpdateTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTemplateRequest(ref DeleteTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetFloorSettingRequest(ref GetFloorSettingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateFloorSettingRequest(ref UpdateFloorSettingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SanitizeUserPromptRequest(ref SanitizeUserPromptRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SanitizeModelResponseRequest(ref SanitizeModelResponseRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists Templates in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Template"/> resources.</returns>
        public override gax::PagedEnumerable<ListTemplatesResponse, Template> ListTemplates(ListTemplatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTemplatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTemplatesRequest, ListTemplatesResponse, Template>(_callListTemplates, request, callSettings);
        }

        /// <summary>
        /// Lists Templates in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Template"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTemplatesResponse, Template> ListTemplatesAsync(ListTemplatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTemplatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTemplatesRequest, ListTemplatesResponse, Template>(_callListTemplates, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Template GetTemplate(GetTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTemplateRequest(ref request, ref callSettings);
            return _callGetTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Template> GetTemplateAsync(GetTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTemplateRequest(ref request, ref callSettings);
            return _callGetTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new Template in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Template CreateTemplate(CreateTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTemplateRequest(ref request, ref callSettings);
            return _callCreateTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new Template in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Template> CreateTemplateAsync(CreateTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTemplateRequest(ref request, ref callSettings);
            return _callCreateTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the parameters of a single Template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Template UpdateTemplate(UpdateTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTemplateRequest(ref request, ref callSettings);
            return _callUpdateTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the parameters of a single Template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Template> UpdateTemplateAsync(UpdateTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTemplateRequest(ref request, ref callSettings);
            return _callUpdateTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a single Template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteTemplate(DeleteTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTemplateRequest(ref request, ref callSettings);
            _callDeleteTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a single Template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteTemplateAsync(DeleteTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTemplateRequest(ref request, ref callSettings);
            return _callDeleteTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single floor setting of a project
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FloorSetting GetFloorSetting(GetFloorSettingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFloorSettingRequest(ref request, ref callSettings);
            return _callGetFloorSetting.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single floor setting of a project
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FloorSetting> GetFloorSettingAsync(GetFloorSettingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFloorSettingRequest(ref request, ref callSettings);
            return _callGetFloorSetting.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the parameters of a single floor setting of a project
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FloorSetting UpdateFloorSetting(UpdateFloorSettingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFloorSettingRequest(ref request, ref callSettings);
            return _callUpdateFloorSetting.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the parameters of a single floor setting of a project
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FloorSetting> UpdateFloorSettingAsync(UpdateFloorSettingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFloorSettingRequest(ref request, ref callSettings);
            return _callUpdateFloorSetting.Async(request, callSettings);
        }

        /// <summary>
        /// Sanitizes User Prompt.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SanitizeUserPromptResponse SanitizeUserPrompt(SanitizeUserPromptRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SanitizeUserPromptRequest(ref request, ref callSettings);
            return _callSanitizeUserPrompt.Sync(request, callSettings);
        }

        /// <summary>
        /// Sanitizes User Prompt.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SanitizeUserPromptResponse> SanitizeUserPromptAsync(SanitizeUserPromptRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SanitizeUserPromptRequest(ref request, ref callSettings);
            return _callSanitizeUserPrompt.Async(request, callSettings);
        }

        /// <summary>
        /// Sanitizes Model Response.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SanitizeModelResponseResponse SanitizeModelResponse(SanitizeModelResponseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SanitizeModelResponseRequest(ref request, ref callSettings);
            return _callSanitizeModelResponse.Sync(request, callSettings);
        }

        /// <summary>
        /// Sanitizes Model Response.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SanitizeModelResponseResponse> SanitizeModelResponseAsync(SanitizeModelResponseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SanitizeModelResponseRequest(ref request, ref callSettings);
            return _callSanitizeModelResponse.Async(request, callSettings);
        }
    }

    public partial class ListTemplatesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTemplatesResponse : gaxgrpc::IPageResponse<Template>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Template> GetEnumerator() => Templates.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ModelArmor
    {
        public partial class ModelArmorClient
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
