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
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Dialogflow.V2
{
    /// <summary>Settings for <see cref="FulfillmentsClient"/> instances.</summary>
    public sealed partial class FulfillmentsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="FulfillmentsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="FulfillmentsSettings"/>.</returns>
        public static FulfillmentsSettings GetDefault() => new FulfillmentsSettings();

        /// <summary>Constructs a new <see cref="FulfillmentsSettings"/> object with default settings.</summary>
        public FulfillmentsSettings()
        {
        }

        private FulfillmentsSettings(FulfillmentsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetFulfillmentSettings = existing.GetFulfillmentSettings;
            UpdateFulfillmentSettings = existing.UpdateFulfillmentSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(FulfillmentsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FulfillmentsClient.GetFulfillment</c> and <c>FulfillmentsClient.GetFulfillmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetFulfillmentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FulfillmentsClient.UpdateFulfillment</c> and <c>FulfillmentsClient.UpdateFulfillmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateFulfillmentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="FulfillmentsSettings"/> object.</returns>
        public FulfillmentsSettings Clone() => new FulfillmentsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="FulfillmentsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class FulfillmentsClientBuilder : gaxgrpc::ClientBuilderBase<FulfillmentsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public FulfillmentsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public FulfillmentsClientBuilder() : base(FulfillmentsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref FulfillmentsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<FulfillmentsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override FulfillmentsClient Build()
        {
            FulfillmentsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<FulfillmentsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<FulfillmentsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private FulfillmentsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return FulfillmentsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<FulfillmentsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return FulfillmentsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => FulfillmentsClient.ChannelPool;
    }

    /// <summary>Fulfillments client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Fulfillments][google.cloud.dialogflow.v2.Fulfillment].
    /// </remarks>
    public abstract partial class FulfillmentsClient
    {
        /// <summary>
        /// The default endpoint for the Fulfillments service, which is a host of "dialogflow.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dialogflow.googleapis.com:443";

        /// <summary>The default Fulfillments scopes.</summary>
        /// <remarks>
        /// The default Fulfillments scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/dialogflow</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/dialogflow",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Fulfillments.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="FulfillmentsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="FulfillmentsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="FulfillmentsClient"/>.</returns>
        public static stt::Task<FulfillmentsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new FulfillmentsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="FulfillmentsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="FulfillmentsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="FulfillmentsClient"/>.</returns>
        public static FulfillmentsClient Create() => new FulfillmentsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="FulfillmentsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="FulfillmentsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="FulfillmentsClient"/>.</returns>
        internal static FulfillmentsClient Create(grpccore::CallInvoker callInvoker, FulfillmentsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Fulfillments.FulfillmentsClient grpcClient = new Fulfillments.FulfillmentsClient(callInvoker);
            return new FulfillmentsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Fulfillments client</summary>
        public virtual Fulfillments.FulfillmentsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the fulfillment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Fulfillment GetFulfillment(GetFulfillmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the fulfillment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Fulfillment> GetFulfillmentAsync(GetFulfillmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the fulfillment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Fulfillment> GetFulfillmentAsync(GetFulfillmentRequest request, st::CancellationToken cancellationToken) =>
            GetFulfillmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the fulfillment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the fulfillment.
        /// Format: `projects/&lt;Project ID&gt;/agent/fulfillment`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Fulfillment GetFulfillment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFulfillment(new GetFulfillmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the fulfillment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the fulfillment.
        /// Format: `projects/&lt;Project ID&gt;/agent/fulfillment`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Fulfillment> GetFulfillmentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFulfillmentAsync(new GetFulfillmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the fulfillment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the fulfillment.
        /// Format: `projects/&lt;Project ID&gt;/agent/fulfillment`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Fulfillment> GetFulfillmentAsync(string name, st::CancellationToken cancellationToken) =>
            GetFulfillmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the fulfillment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the fulfillment.
        /// Format: `projects/&lt;Project ID&gt;/agent/fulfillment`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Fulfillment GetFulfillment(FulfillmentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFulfillment(new GetFulfillmentRequest
            {
                FulfillmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the fulfillment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the fulfillment.
        /// Format: `projects/&lt;Project ID&gt;/agent/fulfillment`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Fulfillment> GetFulfillmentAsync(FulfillmentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFulfillmentAsync(new GetFulfillmentRequest
            {
                FulfillmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the fulfillment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the fulfillment.
        /// Format: `projects/&lt;Project ID&gt;/agent/fulfillment`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Fulfillment> GetFulfillmentAsync(FulfillmentName name, st::CancellationToken cancellationToken) =>
            GetFulfillmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the fulfillment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Fulfillment UpdateFulfillment(UpdateFulfillmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the fulfillment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Fulfillment> UpdateFulfillmentAsync(UpdateFulfillmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the fulfillment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Fulfillment> UpdateFulfillmentAsync(UpdateFulfillmentRequest request, st::CancellationToken cancellationToken) =>
            UpdateFulfillmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the fulfillment.
        /// </summary>
        /// <param name="fulfillment">
        /// Required. The fulfillment to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The mask to control which fields get updated. If the mask is not
        /// present, all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Fulfillment UpdateFulfillment(Fulfillment fulfillment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFulfillment(new UpdateFulfillmentRequest
            {
                Fulfillment = gax::GaxPreconditions.CheckNotNull(fulfillment, nameof(fulfillment)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the fulfillment.
        /// </summary>
        /// <param name="fulfillment">
        /// Required. The fulfillment to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The mask to control which fields get updated. If the mask is not
        /// present, all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Fulfillment> UpdateFulfillmentAsync(Fulfillment fulfillment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFulfillmentAsync(new UpdateFulfillmentRequest
            {
                Fulfillment = gax::GaxPreconditions.CheckNotNull(fulfillment, nameof(fulfillment)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the fulfillment.
        /// </summary>
        /// <param name="fulfillment">
        /// Required. The fulfillment to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The mask to control which fields get updated. If the mask is not
        /// present, all fields will be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Fulfillment> UpdateFulfillmentAsync(Fulfillment fulfillment, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateFulfillmentAsync(fulfillment, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Fulfillments client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Fulfillments][google.cloud.dialogflow.v2.Fulfillment].
    /// </remarks>
    public sealed partial class FulfillmentsClientImpl : FulfillmentsClient
    {
        private readonly gaxgrpc::ApiCall<GetFulfillmentRequest, Fulfillment> _callGetFulfillment;

        private readonly gaxgrpc::ApiCall<UpdateFulfillmentRequest, Fulfillment> _callUpdateFulfillment;

        /// <summary>
        /// Constructs a client wrapper for the Fulfillments service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="FulfillmentsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public FulfillmentsClientImpl(Fulfillments.FulfillmentsClient grpcClient, FulfillmentsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            FulfillmentsSettings effectiveSettings = settings ?? FulfillmentsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callGetFulfillment = clientHelper.BuildApiCall<GetFulfillmentRequest, Fulfillment>("GetFulfillment", grpcClient.GetFulfillmentAsync, grpcClient.GetFulfillment, effectiveSettings.GetFulfillmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetFulfillment);
            Modify_GetFulfillmentApiCall(ref _callGetFulfillment);
            _callUpdateFulfillment = clientHelper.BuildApiCall<UpdateFulfillmentRequest, Fulfillment>("UpdateFulfillment", grpcClient.UpdateFulfillmentAsync, grpcClient.UpdateFulfillment, effectiveSettings.UpdateFulfillmentSettings).WithGoogleRequestParam("fulfillment.name", request => request.Fulfillment?.Name);
            Modify_ApiCall(ref _callUpdateFulfillment);
            Modify_UpdateFulfillmentApiCall(ref _callUpdateFulfillment);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetFulfillmentApiCall(ref gaxgrpc::ApiCall<GetFulfillmentRequest, Fulfillment> call);

        partial void Modify_UpdateFulfillmentApiCall(ref gaxgrpc::ApiCall<UpdateFulfillmentRequest, Fulfillment> call);

        partial void OnConstruction(Fulfillments.FulfillmentsClient grpcClient, FulfillmentsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Fulfillments client</summary>
        public override Fulfillments.FulfillmentsClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_GetFulfillmentRequest(ref GetFulfillmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateFulfillmentRequest(ref UpdateFulfillmentRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves the fulfillment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Fulfillment GetFulfillment(GetFulfillmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFulfillmentRequest(ref request, ref callSettings);
            return _callGetFulfillment.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the fulfillment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Fulfillment> GetFulfillmentAsync(GetFulfillmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFulfillmentRequest(ref request, ref callSettings);
            return _callGetFulfillment.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the fulfillment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Fulfillment UpdateFulfillment(UpdateFulfillmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFulfillmentRequest(ref request, ref callSettings);
            return _callUpdateFulfillment.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the fulfillment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Fulfillment> UpdateFulfillmentAsync(UpdateFulfillmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFulfillmentRequest(ref request, ref callSettings);
            return _callUpdateFulfillment.Async(request, callSettings);
        }
    }

    public static partial class Fulfillments
    {
        public partial class FulfillmentsClient
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
