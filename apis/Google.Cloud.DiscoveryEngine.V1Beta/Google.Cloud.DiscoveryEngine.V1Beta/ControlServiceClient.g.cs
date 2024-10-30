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

namespace Google.Cloud.DiscoveryEngine.V1Beta
{
    /// <summary>Settings for <see cref="ControlServiceClient"/> instances.</summary>
    public sealed partial class ControlServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ControlServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ControlServiceSettings"/>.</returns>
        public static ControlServiceSettings GetDefault() => new ControlServiceSettings();

        /// <summary>Constructs a new <see cref="ControlServiceSettings"/> object with default settings.</summary>
        public ControlServiceSettings()
        {
        }

        private ControlServiceSettings(ControlServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateControlSettings = existing.CreateControlSettings;
            DeleteControlSettings = existing.DeleteControlSettings;
            UpdateControlSettings = existing.UpdateControlSettings;
            GetControlSettings = existing.GetControlSettings;
            ListControlsSettings = existing.ListControlsSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ControlServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ControlServiceClient.CreateControl</c> and <c>ControlServiceClient.CreateControlAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateControlSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ControlServiceClient.DeleteControl</c> and <c>ControlServiceClient.DeleteControlAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteControlSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ControlServiceClient.UpdateControl</c> and <c>ControlServiceClient.UpdateControlAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateControlSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ControlServiceClient.GetControl</c> and <c>ControlServiceClient.GetControlAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetControlSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ControlServiceClient.ListControls</c> and <c>ControlServiceClient.ListControlsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListControlsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ControlServiceSettings"/> object.</returns>
        public ControlServiceSettings Clone() => new ControlServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ControlServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ControlServiceClientBuilder : gaxgrpc::ClientBuilderBase<ControlServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ControlServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ControlServiceClientBuilder() : base(ControlServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ControlServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ControlServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ControlServiceClient Build()
        {
            ControlServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ControlServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ControlServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ControlServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ControlServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ControlServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ControlServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ControlServiceClient.ChannelPool;
    }

    /// <summary>ControlService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for performing CRUD operations on Controls.
    /// Controls allow for custom logic to be implemented in the serving path.
    /// Controls need to be attached to a Serving Config to be considered during a
    /// request.
    /// </remarks>
    public abstract partial class ControlServiceClient
    {
        /// <summary>
        /// The default endpoint for the ControlService service, which is a host of "discoveryengine.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "discoveryengine.googleapis.com:443";

        /// <summary>The default ControlService scopes.</summary>
        /// <remarks>
        /// The default ControlService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ControlService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ControlServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ControlServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ControlServiceClient"/>.</returns>
        public static stt::Task<ControlServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ControlServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ControlServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ControlServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ControlServiceClient"/>.</returns>
        public static ControlServiceClient Create() => new ControlServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ControlServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ControlServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ControlServiceClient"/>.</returns>
        internal static ControlServiceClient Create(grpccore::CallInvoker callInvoker, ControlServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ControlService.ControlServiceClient grpcClient = new ControlService.ControlServiceClient(callInvoker);
            return new ControlServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ControlService client</summary>
        public virtual ControlService.ControlServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Control.
        /// 
        /// By default 1000 controls are allowed for a data store.
        /// A request can be submitted to adjust this limit.
        /// If the [Control][google.cloud.discoveryengine.v1beta.Control] to create
        /// already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Control CreateControl(CreateControlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Control.
        /// 
        /// By default 1000 controls are allowed for a data store.
        /// A request can be submitted to adjust this limit.
        /// If the [Control][google.cloud.discoveryengine.v1beta.Control] to create
        /// already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Control> CreateControlAsync(CreateControlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Control.
        /// 
        /// By default 1000 controls are allowed for a data store.
        /// A request can be submitted to adjust this limit.
        /// If the [Control][google.cloud.discoveryengine.v1beta.Control] to create
        /// already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Control> CreateControlAsync(CreateControlRequest request, st::CancellationToken cancellationToken) =>
            CreateControlAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Control.
        /// 
        /// By default 1000 controls are allowed for a data store.
        /// A request can be submitted to adjust this limit.
        /// If the [Control][google.cloud.discoveryengine.v1beta.Control] to create
        /// already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="parent">
        /// Required. Full resource name of parent data store. Format:
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}`
        /// or
        /// `projects/{project}/locations/{location}/collections/{collection_id}/engines/{engine_id}`.
        /// </param>
        /// <param name="control">
        /// Required. The Control to create.
        /// </param>
        /// <param name="controlId">
        /// Required. The ID to use for the Control, which will become the final
        /// component of the Control's resource name.
        /// 
        /// This value must be within 1-63 characters.
        /// Valid characters are /[a-z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Control CreateControl(string parent, Control control, string controlId, gaxgrpc::CallSettings callSettings = null) =>
            CreateControl(new CreateControlRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Control = gax::GaxPreconditions.CheckNotNull(control, nameof(control)),
                ControlId = gax::GaxPreconditions.CheckNotNullOrEmpty(controlId, nameof(controlId)),
            }, callSettings);

        /// <summary>
        /// Creates a Control.
        /// 
        /// By default 1000 controls are allowed for a data store.
        /// A request can be submitted to adjust this limit.
        /// If the [Control][google.cloud.discoveryengine.v1beta.Control] to create
        /// already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="parent">
        /// Required. Full resource name of parent data store. Format:
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}`
        /// or
        /// `projects/{project}/locations/{location}/collections/{collection_id}/engines/{engine_id}`.
        /// </param>
        /// <param name="control">
        /// Required. The Control to create.
        /// </param>
        /// <param name="controlId">
        /// Required. The ID to use for the Control, which will become the final
        /// component of the Control's resource name.
        /// 
        /// This value must be within 1-63 characters.
        /// Valid characters are /[a-z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Control> CreateControlAsync(string parent, Control control, string controlId, gaxgrpc::CallSettings callSettings = null) =>
            CreateControlAsync(new CreateControlRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Control = gax::GaxPreconditions.CheckNotNull(control, nameof(control)),
                ControlId = gax::GaxPreconditions.CheckNotNullOrEmpty(controlId, nameof(controlId)),
            }, callSettings);

        /// <summary>
        /// Creates a Control.
        /// 
        /// By default 1000 controls are allowed for a data store.
        /// A request can be submitted to adjust this limit.
        /// If the [Control][google.cloud.discoveryengine.v1beta.Control] to create
        /// already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="parent">
        /// Required. Full resource name of parent data store. Format:
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}`
        /// or
        /// `projects/{project}/locations/{location}/collections/{collection_id}/engines/{engine_id}`.
        /// </param>
        /// <param name="control">
        /// Required. The Control to create.
        /// </param>
        /// <param name="controlId">
        /// Required. The ID to use for the Control, which will become the final
        /// component of the Control's resource name.
        /// 
        /// This value must be within 1-63 characters.
        /// Valid characters are /[a-z][0-9]-_/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Control> CreateControlAsync(string parent, Control control, string controlId, st::CancellationToken cancellationToken) =>
            CreateControlAsync(parent, control, controlId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Control.
        /// 
        /// By default 1000 controls are allowed for a data store.
        /// A request can be submitted to adjust this limit.
        /// If the [Control][google.cloud.discoveryengine.v1beta.Control] to create
        /// already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="parent">
        /// Required. Full resource name of parent data store. Format:
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}`
        /// or
        /// `projects/{project}/locations/{location}/collections/{collection_id}/engines/{engine_id}`.
        /// </param>
        /// <param name="control">
        /// Required. The Control to create.
        /// </param>
        /// <param name="controlId">
        /// Required. The ID to use for the Control, which will become the final
        /// component of the Control's resource name.
        /// 
        /// This value must be within 1-63 characters.
        /// Valid characters are /[a-z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Control CreateControl(EngineName parent, Control control, string controlId, gaxgrpc::CallSettings callSettings = null) =>
            CreateControl(new CreateControlRequest
            {
                ParentAsEngineName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Control = gax::GaxPreconditions.CheckNotNull(control, nameof(control)),
                ControlId = gax::GaxPreconditions.CheckNotNullOrEmpty(controlId, nameof(controlId)),
            }, callSettings);

        /// <summary>
        /// Creates a Control.
        /// 
        /// By default 1000 controls are allowed for a data store.
        /// A request can be submitted to adjust this limit.
        /// If the [Control][google.cloud.discoveryengine.v1beta.Control] to create
        /// already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="parent">
        /// Required. Full resource name of parent data store. Format:
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}`
        /// or
        /// `projects/{project}/locations/{location}/collections/{collection_id}/engines/{engine_id}`.
        /// </param>
        /// <param name="control">
        /// Required. The Control to create.
        /// </param>
        /// <param name="controlId">
        /// Required. The ID to use for the Control, which will become the final
        /// component of the Control's resource name.
        /// 
        /// This value must be within 1-63 characters.
        /// Valid characters are /[a-z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Control> CreateControlAsync(EngineName parent, Control control, string controlId, gaxgrpc::CallSettings callSettings = null) =>
            CreateControlAsync(new CreateControlRequest
            {
                ParentAsEngineName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Control = gax::GaxPreconditions.CheckNotNull(control, nameof(control)),
                ControlId = gax::GaxPreconditions.CheckNotNullOrEmpty(controlId, nameof(controlId)),
            }, callSettings);

        /// <summary>
        /// Creates a Control.
        /// 
        /// By default 1000 controls are allowed for a data store.
        /// A request can be submitted to adjust this limit.
        /// If the [Control][google.cloud.discoveryengine.v1beta.Control] to create
        /// already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="parent">
        /// Required. Full resource name of parent data store. Format:
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}`
        /// or
        /// `projects/{project}/locations/{location}/collections/{collection_id}/engines/{engine_id}`.
        /// </param>
        /// <param name="control">
        /// Required. The Control to create.
        /// </param>
        /// <param name="controlId">
        /// Required. The ID to use for the Control, which will become the final
        /// component of the Control's resource name.
        /// 
        /// This value must be within 1-63 characters.
        /// Valid characters are /[a-z][0-9]-_/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Control> CreateControlAsync(EngineName parent, Control control, string controlId, st::CancellationToken cancellationToken) =>
            CreateControlAsync(parent, control, controlId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Control.
        /// 
        /// By default 1000 controls are allowed for a data store.
        /// A request can be submitted to adjust this limit.
        /// If the [Control][google.cloud.discoveryengine.v1beta.Control] to create
        /// already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="parent">
        /// Required. Full resource name of parent data store. Format:
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}`
        /// or
        /// `projects/{project}/locations/{location}/collections/{collection_id}/engines/{engine_id}`.
        /// </param>
        /// <param name="control">
        /// Required. The Control to create.
        /// </param>
        /// <param name="controlId">
        /// Required. The ID to use for the Control, which will become the final
        /// component of the Control's resource name.
        /// 
        /// This value must be within 1-63 characters.
        /// Valid characters are /[a-z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Control CreateControl(DataStoreName parent, Control control, string controlId, gaxgrpc::CallSettings callSettings = null) =>
            CreateControl(new CreateControlRequest
            {
                ParentAsDataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Control = gax::GaxPreconditions.CheckNotNull(control, nameof(control)),
                ControlId = gax::GaxPreconditions.CheckNotNullOrEmpty(controlId, nameof(controlId)),
            }, callSettings);

        /// <summary>
        /// Creates a Control.
        /// 
        /// By default 1000 controls are allowed for a data store.
        /// A request can be submitted to adjust this limit.
        /// If the [Control][google.cloud.discoveryengine.v1beta.Control] to create
        /// already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="parent">
        /// Required. Full resource name of parent data store. Format:
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}`
        /// or
        /// `projects/{project}/locations/{location}/collections/{collection_id}/engines/{engine_id}`.
        /// </param>
        /// <param name="control">
        /// Required. The Control to create.
        /// </param>
        /// <param name="controlId">
        /// Required. The ID to use for the Control, which will become the final
        /// component of the Control's resource name.
        /// 
        /// This value must be within 1-63 characters.
        /// Valid characters are /[a-z][0-9]-_/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Control> CreateControlAsync(DataStoreName parent, Control control, string controlId, gaxgrpc::CallSettings callSettings = null) =>
            CreateControlAsync(new CreateControlRequest
            {
                ParentAsDataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Control = gax::GaxPreconditions.CheckNotNull(control, nameof(control)),
                ControlId = gax::GaxPreconditions.CheckNotNullOrEmpty(controlId, nameof(controlId)),
            }, callSettings);

        /// <summary>
        /// Creates a Control.
        /// 
        /// By default 1000 controls are allowed for a data store.
        /// A request can be submitted to adjust this limit.
        /// If the [Control][google.cloud.discoveryengine.v1beta.Control] to create
        /// already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="parent">
        /// Required. Full resource name of parent data store. Format:
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}`
        /// or
        /// `projects/{project}/locations/{location}/collections/{collection_id}/engines/{engine_id}`.
        /// </param>
        /// <param name="control">
        /// Required. The Control to create.
        /// </param>
        /// <param name="controlId">
        /// Required. The ID to use for the Control, which will become the final
        /// component of the Control's resource name.
        /// 
        /// This value must be within 1-63 characters.
        /// Valid characters are /[a-z][0-9]-_/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Control> CreateControlAsync(DataStoreName parent, Control control, string controlId, st::CancellationToken cancellationToken) =>
            CreateControlAsync(parent, control, controlId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Control.
        /// 
        /// If the [Control][google.cloud.discoveryengine.v1beta.Control] to delete
        /// does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteControl(DeleteControlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Control.
        /// 
        /// If the [Control][google.cloud.discoveryengine.v1beta.Control] to delete
        /// does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteControlAsync(DeleteControlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Control.
        /// 
        /// If the [Control][google.cloud.discoveryengine.v1beta.Control] to delete
        /// does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteControlAsync(DeleteControlRequest request, st::CancellationToken cancellationToken) =>
            DeleteControlAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Control.
        /// 
        /// If the [Control][google.cloud.discoveryengine.v1beta.Control] to delete
        /// does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Control to delete. Format:
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}/controls/{control_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteControl(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteControl(new DeleteControlRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Control.
        /// 
        /// If the [Control][google.cloud.discoveryengine.v1beta.Control] to delete
        /// does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Control to delete. Format:
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}/controls/{control_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteControlAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteControlAsync(new DeleteControlRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Control.
        /// 
        /// If the [Control][google.cloud.discoveryengine.v1beta.Control] to delete
        /// does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Control to delete. Format:
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}/controls/{control_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteControlAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteControlAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Control.
        /// 
        /// If the [Control][google.cloud.discoveryengine.v1beta.Control] to delete
        /// does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Control to delete. Format:
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}/controls/{control_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteControl(ControlName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteControl(new DeleteControlRequest
            {
                ControlName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Control.
        /// 
        /// If the [Control][google.cloud.discoveryengine.v1beta.Control] to delete
        /// does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Control to delete. Format:
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}/controls/{control_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteControlAsync(ControlName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteControlAsync(new DeleteControlRequest
            {
                ControlName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Control.
        /// 
        /// If the [Control][google.cloud.discoveryengine.v1beta.Control] to delete
        /// does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Control to delete. Format:
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}/controls/{control_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteControlAsync(ControlName name, st::CancellationToken cancellationToken) =>
            DeleteControlAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a Control.
        /// 
        /// [Control][google.cloud.discoveryengine.v1beta.Control] action type cannot
        /// be changed. If the [Control][google.cloud.discoveryengine.v1beta.Control]
        /// to update does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Control UpdateControl(UpdateControlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a Control.
        /// 
        /// [Control][google.cloud.discoveryengine.v1beta.Control] action type cannot
        /// be changed. If the [Control][google.cloud.discoveryengine.v1beta.Control]
        /// to update does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Control> UpdateControlAsync(UpdateControlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a Control.
        /// 
        /// [Control][google.cloud.discoveryengine.v1beta.Control] action type cannot
        /// be changed. If the [Control][google.cloud.discoveryengine.v1beta.Control]
        /// to update does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Control> UpdateControlAsync(UpdateControlRequest request, st::CancellationToken cancellationToken) =>
            UpdateControlAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a Control.
        /// 
        /// [Control][google.cloud.discoveryengine.v1beta.Control] action type cannot
        /// be changed. If the [Control][google.cloud.discoveryengine.v1beta.Control]
        /// to update does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="control">
        /// Required. The Control to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Indicates which fields in the provided
        /// [Control][google.cloud.discoveryengine.v1beta.Control] to update. The
        /// following are NOT supported:
        /// 
        /// * [Control.name][google.cloud.discoveryengine.v1beta.Control.name]
        /// * [Control.solution_type][google.cloud.discoveryengine.v1beta.Control.solution_type]
        /// 
        /// If not set or empty, all supported fields are updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Control UpdateControl(Control control, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateControl(new UpdateControlRequest
            {
                Control = gax::GaxPreconditions.CheckNotNull(control, nameof(control)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a Control.
        /// 
        /// [Control][google.cloud.discoveryengine.v1beta.Control] action type cannot
        /// be changed. If the [Control][google.cloud.discoveryengine.v1beta.Control]
        /// to update does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="control">
        /// Required. The Control to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Indicates which fields in the provided
        /// [Control][google.cloud.discoveryengine.v1beta.Control] to update. The
        /// following are NOT supported:
        /// 
        /// * [Control.name][google.cloud.discoveryengine.v1beta.Control.name]
        /// * [Control.solution_type][google.cloud.discoveryengine.v1beta.Control.solution_type]
        /// 
        /// If not set or empty, all supported fields are updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Control> UpdateControlAsync(Control control, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateControlAsync(new UpdateControlRequest
            {
                Control = gax::GaxPreconditions.CheckNotNull(control, nameof(control)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a Control.
        /// 
        /// [Control][google.cloud.discoveryengine.v1beta.Control] action type cannot
        /// be changed. If the [Control][google.cloud.discoveryengine.v1beta.Control]
        /// to update does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="control">
        /// Required. The Control to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Indicates which fields in the provided
        /// [Control][google.cloud.discoveryengine.v1beta.Control] to update. The
        /// following are NOT supported:
        /// 
        /// * [Control.name][google.cloud.discoveryengine.v1beta.Control.name]
        /// * [Control.solution_type][google.cloud.discoveryengine.v1beta.Control.solution_type]
        /// 
        /// If not set or empty, all supported fields are updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Control> UpdateControlAsync(Control control, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateControlAsync(control, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Control.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Control GetControl(GetControlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Control.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Control> GetControlAsync(GetControlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Control.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Control> GetControlAsync(GetControlRequest request, st::CancellationToken cancellationToken) =>
            GetControlAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Control.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Control to get. Format:
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}/controls/{control_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Control GetControl(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetControl(new GetControlRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Control.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Control to get. Format:
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}/controls/{control_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Control> GetControlAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetControlAsync(new GetControlRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Control.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Control to get. Format:
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}/controls/{control_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Control> GetControlAsync(string name, st::CancellationToken cancellationToken) =>
            GetControlAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Control.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Control to get. Format:
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}/controls/{control_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Control GetControl(ControlName name, gaxgrpc::CallSettings callSettings = null) =>
            GetControl(new GetControlRequest
            {
                ControlName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Control.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Control to get. Format:
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}/controls/{control_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Control> GetControlAsync(ControlName name, gaxgrpc::CallSettings callSettings = null) =>
            GetControlAsync(new GetControlRequest
            {
                ControlName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Control.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Control to get. Format:
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}/controls/{control_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Control> GetControlAsync(ControlName name, st::CancellationToken cancellationToken) =>
            GetControlAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all Controls by their parent
        /// [DataStore][google.cloud.discoveryengine.v1beta.DataStore].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Control"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListControlsResponse, Control> ListControls(ListControlsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all Controls by their parent
        /// [DataStore][google.cloud.discoveryengine.v1beta.DataStore].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Control"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListControlsResponse, Control> ListControlsAsync(ListControlsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all Controls by their parent
        /// [DataStore][google.cloud.discoveryengine.v1beta.DataStore].
        /// </summary>
        /// <param name="parent">
        /// Required. The data store resource name. Format:
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}`
        /// or
        /// `projects/{project}/locations/{location}/collections/{collection_id}/engines/{engine_id}`.
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
        /// <returns>A pageable sequence of <see cref="Control"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListControlsResponse, Control> ListControls(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListControlsRequest request = new ListControlsRequest
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
            return ListControls(request, callSettings);
        }

        /// <summary>
        /// Lists all Controls by their parent
        /// [DataStore][google.cloud.discoveryengine.v1beta.DataStore].
        /// </summary>
        /// <param name="parent">
        /// Required. The data store resource name. Format:
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}`
        /// or
        /// `projects/{project}/locations/{location}/collections/{collection_id}/engines/{engine_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Control"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListControlsResponse, Control> ListControlsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListControlsRequest request = new ListControlsRequest
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
            return ListControlsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all Controls by their parent
        /// [DataStore][google.cloud.discoveryengine.v1beta.DataStore].
        /// </summary>
        /// <param name="parent">
        /// Required. The data store resource name. Format:
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}`
        /// or
        /// `projects/{project}/locations/{location}/collections/{collection_id}/engines/{engine_id}`.
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
        /// <returns>A pageable sequence of <see cref="Control"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListControlsResponse, Control> ListControls(EngineName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListControlsRequest request = new ListControlsRequest
            {
                ParentAsEngineName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListControls(request, callSettings);
        }

        /// <summary>
        /// Lists all Controls by their parent
        /// [DataStore][google.cloud.discoveryengine.v1beta.DataStore].
        /// </summary>
        /// <param name="parent">
        /// Required. The data store resource name. Format:
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}`
        /// or
        /// `projects/{project}/locations/{location}/collections/{collection_id}/engines/{engine_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Control"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListControlsResponse, Control> ListControlsAsync(EngineName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListControlsRequest request = new ListControlsRequest
            {
                ParentAsEngineName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListControlsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all Controls by their parent
        /// [DataStore][google.cloud.discoveryengine.v1beta.DataStore].
        /// </summary>
        /// <param name="parent">
        /// Required. The data store resource name. Format:
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}`
        /// or
        /// `projects/{project}/locations/{location}/collections/{collection_id}/engines/{engine_id}`.
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
        /// <returns>A pageable sequence of <see cref="Control"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListControlsResponse, Control> ListControls(DataStoreName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListControlsRequest request = new ListControlsRequest
            {
                ParentAsDataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListControls(request, callSettings);
        }

        /// <summary>
        /// Lists all Controls by their parent
        /// [DataStore][google.cloud.discoveryengine.v1beta.DataStore].
        /// </summary>
        /// <param name="parent">
        /// Required. The data store resource name. Format:
        /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}`
        /// or
        /// `projects/{project}/locations/{location}/collections/{collection_id}/engines/{engine_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Control"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListControlsResponse, Control> ListControlsAsync(DataStoreName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListControlsRequest request = new ListControlsRequest
            {
                ParentAsDataStoreName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListControlsAsync(request, callSettings);
        }
    }

    /// <summary>ControlService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for performing CRUD operations on Controls.
    /// Controls allow for custom logic to be implemented in the serving path.
    /// Controls need to be attached to a Serving Config to be considered during a
    /// request.
    /// </remarks>
    public sealed partial class ControlServiceClientImpl : ControlServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateControlRequest, Control> _callCreateControl;

        private readonly gaxgrpc::ApiCall<DeleteControlRequest, wkt::Empty> _callDeleteControl;

        private readonly gaxgrpc::ApiCall<UpdateControlRequest, Control> _callUpdateControl;

        private readonly gaxgrpc::ApiCall<GetControlRequest, Control> _callGetControl;

        private readonly gaxgrpc::ApiCall<ListControlsRequest, ListControlsResponse> _callListControls;

        /// <summary>
        /// Constructs a client wrapper for the ControlService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ControlServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ControlServiceClientImpl(ControlService.ControlServiceClient grpcClient, ControlServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ControlServiceSettings effectiveSettings = settings ?? ControlServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreateControl = clientHelper.BuildApiCall<CreateControlRequest, Control>("CreateControl", grpcClient.CreateControlAsync, grpcClient.CreateControl, effectiveSettings.CreateControlSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateControl);
            Modify_CreateControlApiCall(ref _callCreateControl);
            _callDeleteControl = clientHelper.BuildApiCall<DeleteControlRequest, wkt::Empty>("DeleteControl", grpcClient.DeleteControlAsync, grpcClient.DeleteControl, effectiveSettings.DeleteControlSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteControl);
            Modify_DeleteControlApiCall(ref _callDeleteControl);
            _callUpdateControl = clientHelper.BuildApiCall<UpdateControlRequest, Control>("UpdateControl", grpcClient.UpdateControlAsync, grpcClient.UpdateControl, effectiveSettings.UpdateControlSettings).WithGoogleRequestParam("control.name", request => request.Control?.Name);
            Modify_ApiCall(ref _callUpdateControl);
            Modify_UpdateControlApiCall(ref _callUpdateControl);
            _callGetControl = clientHelper.BuildApiCall<GetControlRequest, Control>("GetControl", grpcClient.GetControlAsync, grpcClient.GetControl, effectiveSettings.GetControlSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetControl);
            Modify_GetControlApiCall(ref _callGetControl);
            _callListControls = clientHelper.BuildApiCall<ListControlsRequest, ListControlsResponse>("ListControls", grpcClient.ListControlsAsync, grpcClient.ListControls, effectiveSettings.ListControlsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListControls);
            Modify_ListControlsApiCall(ref _callListControls);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateControlApiCall(ref gaxgrpc::ApiCall<CreateControlRequest, Control> call);

        partial void Modify_DeleteControlApiCall(ref gaxgrpc::ApiCall<DeleteControlRequest, wkt::Empty> call);

        partial void Modify_UpdateControlApiCall(ref gaxgrpc::ApiCall<UpdateControlRequest, Control> call);

        partial void Modify_GetControlApiCall(ref gaxgrpc::ApiCall<GetControlRequest, Control> call);

        partial void Modify_ListControlsApiCall(ref gaxgrpc::ApiCall<ListControlsRequest, ListControlsResponse> call);

        partial void OnConstruction(ControlService.ControlServiceClient grpcClient, ControlServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ControlService client</summary>
        public override ControlService.ControlServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreateControlRequest(ref CreateControlRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteControlRequest(ref DeleteControlRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateControlRequest(ref UpdateControlRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetControlRequest(ref GetControlRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListControlsRequest(ref ListControlsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a Control.
        /// 
        /// By default 1000 controls are allowed for a data store.
        /// A request can be submitted to adjust this limit.
        /// If the [Control][google.cloud.discoveryengine.v1beta.Control] to create
        /// already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Control CreateControl(CreateControlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateControlRequest(ref request, ref callSettings);
            return _callCreateControl.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a Control.
        /// 
        /// By default 1000 controls are allowed for a data store.
        /// A request can be submitted to adjust this limit.
        /// If the [Control][google.cloud.discoveryengine.v1beta.Control] to create
        /// already exists, an ALREADY_EXISTS error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Control> CreateControlAsync(CreateControlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateControlRequest(ref request, ref callSettings);
            return _callCreateControl.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a Control.
        /// 
        /// If the [Control][google.cloud.discoveryengine.v1beta.Control] to delete
        /// does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteControl(DeleteControlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteControlRequest(ref request, ref callSettings);
            _callDeleteControl.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a Control.
        /// 
        /// If the [Control][google.cloud.discoveryengine.v1beta.Control] to delete
        /// does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteControlAsync(DeleteControlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteControlRequest(ref request, ref callSettings);
            return _callDeleteControl.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a Control.
        /// 
        /// [Control][google.cloud.discoveryengine.v1beta.Control] action type cannot
        /// be changed. If the [Control][google.cloud.discoveryengine.v1beta.Control]
        /// to update does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Control UpdateControl(UpdateControlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateControlRequest(ref request, ref callSettings);
            return _callUpdateControl.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a Control.
        /// 
        /// [Control][google.cloud.discoveryengine.v1beta.Control] action type cannot
        /// be changed. If the [Control][google.cloud.discoveryengine.v1beta.Control]
        /// to update does not exist, a NOT_FOUND error is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Control> UpdateControlAsync(UpdateControlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateControlRequest(ref request, ref callSettings);
            return _callUpdateControl.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a Control.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Control GetControl(GetControlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetControlRequest(ref request, ref callSettings);
            return _callGetControl.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a Control.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Control> GetControlAsync(GetControlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetControlRequest(ref request, ref callSettings);
            return _callGetControl.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all Controls by their parent
        /// [DataStore][google.cloud.discoveryengine.v1beta.DataStore].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Control"/> resources.</returns>
        public override gax::PagedEnumerable<ListControlsResponse, Control> ListControls(ListControlsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListControlsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListControlsRequest, ListControlsResponse, Control>(_callListControls, request, callSettings);
        }

        /// <summary>
        /// Lists all Controls by their parent
        /// [DataStore][google.cloud.discoveryengine.v1beta.DataStore].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Control"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListControlsResponse, Control> ListControlsAsync(ListControlsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListControlsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListControlsRequest, ListControlsResponse, Control>(_callListControls, request, callSettings);
        }
    }

    public partial class ListControlsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListControlsResponse : gaxgrpc::IPageResponse<Control>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Control> GetEnumerator() => Controls.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ControlService
    {
        public partial class ControlServiceClient
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
