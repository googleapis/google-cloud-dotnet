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

namespace Google.Shopping.Merchant.Accounts.V1Beta
{
    /// <summary>Settings for <see cref="BusinessInfoServiceClient"/> instances.</summary>
    public sealed partial class BusinessInfoServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BusinessInfoServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BusinessInfoServiceSettings"/>.</returns>
        public static BusinessInfoServiceSettings GetDefault() => new BusinessInfoServiceSettings();

        /// <summary>Constructs a new <see cref="BusinessInfoServiceSettings"/> object with default settings.</summary>
        public BusinessInfoServiceSettings()
        {
        }

        private BusinessInfoServiceSettings(BusinessInfoServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetBusinessInfoSettings = existing.GetBusinessInfoSettings;
            UpdateBusinessInfoSettings = existing.UpdateBusinessInfoSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BusinessInfoServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BusinessInfoServiceClient.GetBusinessInfo</c> and <c>BusinessInfoServiceClient.GetBusinessInfoAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetBusinessInfoSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BusinessInfoServiceClient.UpdateBusinessInfo</c> and <c>BusinessInfoServiceClient.UpdateBusinessInfoAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateBusinessInfoSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BusinessInfoServiceSettings"/> object.</returns>
        public BusinessInfoServiceSettings Clone() => new BusinessInfoServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BusinessInfoServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class BusinessInfoServiceClientBuilder : gaxgrpc::ClientBuilderBase<BusinessInfoServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BusinessInfoServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public BusinessInfoServiceClientBuilder() : base(BusinessInfoServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref BusinessInfoServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<BusinessInfoServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override BusinessInfoServiceClient Build()
        {
            BusinessInfoServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<BusinessInfoServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<BusinessInfoServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private BusinessInfoServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BusinessInfoServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<BusinessInfoServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BusinessInfoServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BusinessInfoServiceClient.ChannelPool;
    }

    /// <summary>BusinessInfoService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to support business info API.
    /// </remarks>
    public abstract partial class BusinessInfoServiceClient
    {
        /// <summary>
        /// The default endpoint for the BusinessInfoService service, which is a host of "merchantapi.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default BusinessInfoService scopes.</summary>
        /// <remarks>
        /// The default BusinessInfoService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(BusinessInfoService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="BusinessInfoServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="BusinessInfoServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="BusinessInfoServiceClient"/>.</returns>
        public static stt::Task<BusinessInfoServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new BusinessInfoServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="BusinessInfoServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="BusinessInfoServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="BusinessInfoServiceClient"/>.</returns>
        public static BusinessInfoServiceClient Create() => new BusinessInfoServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="BusinessInfoServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BusinessInfoServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="BusinessInfoServiceClient"/>.</returns>
        internal static BusinessInfoServiceClient Create(grpccore::CallInvoker callInvoker, BusinessInfoServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BusinessInfoService.BusinessInfoServiceClient grpcClient = new BusinessInfoService.BusinessInfoServiceClient(callInvoker);
            return new BusinessInfoServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC BusinessInfoService client</summary>
        public virtual BusinessInfoService.BusinessInfoServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the business info of an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BusinessInfo GetBusinessInfo(GetBusinessInfoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the business info of an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BusinessInfo> GetBusinessInfoAsync(GetBusinessInfoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the business info of an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BusinessInfo> GetBusinessInfoAsync(GetBusinessInfoRequest request, st::CancellationToken cancellationToken) =>
            GetBusinessInfoAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the business info of an account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the business info.
        /// Format: `accounts/{account}/businessInfo`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BusinessInfo GetBusinessInfo(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBusinessInfo(new GetBusinessInfoRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the business info of an account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the business info.
        /// Format: `accounts/{account}/businessInfo`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BusinessInfo> GetBusinessInfoAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBusinessInfoAsync(new GetBusinessInfoRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the business info of an account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the business info.
        /// Format: `accounts/{account}/businessInfo`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BusinessInfo> GetBusinessInfoAsync(string name, st::CancellationToken cancellationToken) =>
            GetBusinessInfoAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the business info of an account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the business info.
        /// Format: `accounts/{account}/businessInfo`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BusinessInfo GetBusinessInfo(BusinessInfoName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBusinessInfo(new GetBusinessInfoRequest
            {
                BusinessInfoName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the business info of an account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the business info.
        /// Format: `accounts/{account}/businessInfo`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BusinessInfo> GetBusinessInfoAsync(BusinessInfoName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBusinessInfoAsync(new GetBusinessInfoRequest
            {
                BusinessInfoName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the business info of an account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the business info.
        /// Format: `accounts/{account}/businessInfo`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BusinessInfo> GetBusinessInfoAsync(BusinessInfoName name, st::CancellationToken cancellationToken) =>
            GetBusinessInfoAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the business info of an account. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BusinessInfo UpdateBusinessInfo(UpdateBusinessInfoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the business info of an account. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BusinessInfo> UpdateBusinessInfoAsync(UpdateBusinessInfoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the business info of an account. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BusinessInfo> UpdateBusinessInfoAsync(UpdateBusinessInfoRequest request, st::CancellationToken cancellationToken) =>
            UpdateBusinessInfoAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the business info of an account. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="businessInfo">
        /// Required. The new version of the business info.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields being updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BusinessInfo UpdateBusinessInfo(BusinessInfo businessInfo, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBusinessInfo(new UpdateBusinessInfoRequest
            {
                BusinessInfo = gax::GaxPreconditions.CheckNotNull(businessInfo, nameof(businessInfo)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the business info of an account. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="businessInfo">
        /// Required. The new version of the business info.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields being updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BusinessInfo> UpdateBusinessInfoAsync(BusinessInfo businessInfo, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBusinessInfoAsync(new UpdateBusinessInfoRequest
            {
                BusinessInfo = gax::GaxPreconditions.CheckNotNull(businessInfo, nameof(businessInfo)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the business info of an account. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="businessInfo">
        /// Required. The new version of the business info.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields being updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BusinessInfo> UpdateBusinessInfoAsync(BusinessInfo businessInfo, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateBusinessInfoAsync(businessInfo, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>BusinessInfoService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to support business info API.
    /// </remarks>
    public sealed partial class BusinessInfoServiceClientImpl : BusinessInfoServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetBusinessInfoRequest, BusinessInfo> _callGetBusinessInfo;

        private readonly gaxgrpc::ApiCall<UpdateBusinessInfoRequest, BusinessInfo> _callUpdateBusinessInfo;

        /// <summary>
        /// Constructs a client wrapper for the BusinessInfoService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="BusinessInfoServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public BusinessInfoServiceClientImpl(BusinessInfoService.BusinessInfoServiceClient grpcClient, BusinessInfoServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            BusinessInfoServiceSettings effectiveSettings = settings ?? BusinessInfoServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetBusinessInfo = clientHelper.BuildApiCall<GetBusinessInfoRequest, BusinessInfo>("GetBusinessInfo", grpcClient.GetBusinessInfoAsync, grpcClient.GetBusinessInfo, effectiveSettings.GetBusinessInfoSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetBusinessInfo);
            Modify_GetBusinessInfoApiCall(ref _callGetBusinessInfo);
            _callUpdateBusinessInfo = clientHelper.BuildApiCall<UpdateBusinessInfoRequest, BusinessInfo>("UpdateBusinessInfo", grpcClient.UpdateBusinessInfoAsync, grpcClient.UpdateBusinessInfo, effectiveSettings.UpdateBusinessInfoSettings).WithGoogleRequestParam("business_info.name", request => request.BusinessInfo?.Name);
            Modify_ApiCall(ref _callUpdateBusinessInfo);
            Modify_UpdateBusinessInfoApiCall(ref _callUpdateBusinessInfo);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetBusinessInfoApiCall(ref gaxgrpc::ApiCall<GetBusinessInfoRequest, BusinessInfo> call);

        partial void Modify_UpdateBusinessInfoApiCall(ref gaxgrpc::ApiCall<UpdateBusinessInfoRequest, BusinessInfo> call);

        partial void OnConstruction(BusinessInfoService.BusinessInfoServiceClient grpcClient, BusinessInfoServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC BusinessInfoService client</summary>
        public override BusinessInfoService.BusinessInfoServiceClient GrpcClient { get; }

        partial void Modify_GetBusinessInfoRequest(ref GetBusinessInfoRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateBusinessInfoRequest(ref UpdateBusinessInfoRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves the business info of an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BusinessInfo GetBusinessInfo(GetBusinessInfoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBusinessInfoRequest(ref request, ref callSettings);
            return _callGetBusinessInfo.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the business info of an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BusinessInfo> GetBusinessInfoAsync(GetBusinessInfoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBusinessInfoRequest(ref request, ref callSettings);
            return _callGetBusinessInfo.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the business info of an account. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BusinessInfo UpdateBusinessInfo(UpdateBusinessInfoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBusinessInfoRequest(ref request, ref callSettings);
            return _callUpdateBusinessInfo.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the business info of an account. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BusinessInfo> UpdateBusinessInfoAsync(UpdateBusinessInfoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBusinessInfoRequest(ref request, ref callSettings);
            return _callUpdateBusinessInfo.Async(request, callSettings);
        }
    }
}
