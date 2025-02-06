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
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Shopping.Merchant.Accounts.V1Beta
{
    /// <summary>Settings for <see cref="BusinessIdentityServiceClient"/> instances.</summary>
    public sealed partial class BusinessIdentityServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BusinessIdentityServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BusinessIdentityServiceSettings"/>.</returns>
        public static BusinessIdentityServiceSettings GetDefault() => new BusinessIdentityServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="BusinessIdentityServiceSettings"/> object with default settings.
        /// </summary>
        public BusinessIdentityServiceSettings()
        {
        }

        private BusinessIdentityServiceSettings(BusinessIdentityServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetBusinessIdentitySettings = existing.GetBusinessIdentitySettings;
            UpdateBusinessIdentitySettings = existing.UpdateBusinessIdentitySettings;
            OnCopy(existing);
        }

        partial void OnCopy(BusinessIdentityServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BusinessIdentityServiceClient.GetBusinessIdentity</c> and
        /// <c>BusinessIdentityServiceClient.GetBusinessIdentityAsync</c>.
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
        public gaxgrpc::CallSettings GetBusinessIdentitySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BusinessIdentityServiceClient.UpdateBusinessIdentity</c> and
        /// <c>BusinessIdentityServiceClient.UpdateBusinessIdentityAsync</c>.
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
        public gaxgrpc::CallSettings UpdateBusinessIdentitySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BusinessIdentityServiceSettings"/> object.</returns>
        public BusinessIdentityServiceSettings Clone() => new BusinessIdentityServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BusinessIdentityServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class BusinessIdentityServiceClientBuilder : gaxgrpc::ClientBuilderBase<BusinessIdentityServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BusinessIdentityServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public BusinessIdentityServiceClientBuilder() : base(BusinessIdentityServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref BusinessIdentityServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<BusinessIdentityServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override BusinessIdentityServiceClient Build()
        {
            BusinessIdentityServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<BusinessIdentityServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<BusinessIdentityServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private BusinessIdentityServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BusinessIdentityServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<BusinessIdentityServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BusinessIdentityServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BusinessIdentityServiceClient.ChannelPool;
    }

    /// <summary>BusinessIdentityService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to support [business
    /// identity](https://support.google.com/merchants/answer/12564247) API.
    /// </remarks>
    public abstract partial class BusinessIdentityServiceClient
    {
        /// <summary>
        /// The default endpoint for the BusinessIdentityService service, which is a host of
        /// "merchantapi.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default BusinessIdentityService scopes.</summary>
        /// <remarks>
        /// The default BusinessIdentityService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(BusinessIdentityService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="BusinessIdentityServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="BusinessIdentityServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="BusinessIdentityServiceClient"/>.</returns>
        public static stt::Task<BusinessIdentityServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new BusinessIdentityServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="BusinessIdentityServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="BusinessIdentityServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="BusinessIdentityServiceClient"/>.</returns>
        public static BusinessIdentityServiceClient Create() => new BusinessIdentityServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="BusinessIdentityServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BusinessIdentityServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="BusinessIdentityServiceClient"/>.</returns>
        internal static BusinessIdentityServiceClient Create(grpccore::CallInvoker callInvoker, BusinessIdentityServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BusinessIdentityService.BusinessIdentityServiceClient grpcClient = new BusinessIdentityService.BusinessIdentityServiceClient(callInvoker);
            return new BusinessIdentityServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC BusinessIdentityService client</summary>
        public virtual BusinessIdentityService.BusinessIdentityServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the business identity of an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BusinessIdentity GetBusinessIdentity(GetBusinessIdentityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the business identity of an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BusinessIdentity> GetBusinessIdentityAsync(GetBusinessIdentityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the business identity of an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BusinessIdentity> GetBusinessIdentityAsync(GetBusinessIdentityRequest request, st::CancellationToken cancellationToken) =>
            GetBusinessIdentityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the business identity of an account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the business identity.
        /// Format: `accounts/{account}/businessIdentity`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BusinessIdentity GetBusinessIdentity(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBusinessIdentity(new GetBusinessIdentityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the business identity of an account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the business identity.
        /// Format: `accounts/{account}/businessIdentity`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BusinessIdentity> GetBusinessIdentityAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBusinessIdentityAsync(new GetBusinessIdentityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the business identity of an account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the business identity.
        /// Format: `accounts/{account}/businessIdentity`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BusinessIdentity> GetBusinessIdentityAsync(string name, st::CancellationToken cancellationToken) =>
            GetBusinessIdentityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the business identity of an account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the business identity.
        /// Format: `accounts/{account}/businessIdentity`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BusinessIdentity GetBusinessIdentity(BusinessIdentityName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBusinessIdentity(new GetBusinessIdentityRequest
            {
                BusinessIdentityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the business identity of an account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the business identity.
        /// Format: `accounts/{account}/businessIdentity`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BusinessIdentity> GetBusinessIdentityAsync(BusinessIdentityName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBusinessIdentityAsync(new GetBusinessIdentityRequest
            {
                BusinessIdentityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the business identity of an account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the business identity.
        /// Format: `accounts/{account}/businessIdentity`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BusinessIdentity> GetBusinessIdentityAsync(BusinessIdentityName name, st::CancellationToken cancellationToken) =>
            GetBusinessIdentityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the business identity of an account. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BusinessIdentity UpdateBusinessIdentity(UpdateBusinessIdentityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the business identity of an account. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BusinessIdentity> UpdateBusinessIdentityAsync(UpdateBusinessIdentityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the business identity of an account. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BusinessIdentity> UpdateBusinessIdentityAsync(UpdateBusinessIdentityRequest request, st::CancellationToken cancellationToken) =>
            UpdateBusinessIdentityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the business identity of an account. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="businessIdentity">
        /// Required. The new version of the business identity.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields being updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BusinessIdentity UpdateBusinessIdentity(BusinessIdentity businessIdentity, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBusinessIdentity(new UpdateBusinessIdentityRequest
            {
                BusinessIdentity = gax::GaxPreconditions.CheckNotNull(businessIdentity, nameof(businessIdentity)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the business identity of an account. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="businessIdentity">
        /// Required. The new version of the business identity.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields being updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BusinessIdentity> UpdateBusinessIdentityAsync(BusinessIdentity businessIdentity, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBusinessIdentityAsync(new UpdateBusinessIdentityRequest
            {
                BusinessIdentity = gax::GaxPreconditions.CheckNotNull(businessIdentity, nameof(businessIdentity)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the business identity of an account. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="businessIdentity">
        /// Required. The new version of the business identity.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields being updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BusinessIdentity> UpdateBusinessIdentityAsync(BusinessIdentity businessIdentity, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateBusinessIdentityAsync(businessIdentity, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>BusinessIdentityService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to support [business
    /// identity](https://support.google.com/merchants/answer/12564247) API.
    /// </remarks>
    public sealed partial class BusinessIdentityServiceClientImpl : BusinessIdentityServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetBusinessIdentityRequest, BusinessIdentity> _callGetBusinessIdentity;

        private readonly gaxgrpc::ApiCall<UpdateBusinessIdentityRequest, BusinessIdentity> _callUpdateBusinessIdentity;

        /// <summary>
        /// Constructs a client wrapper for the BusinessIdentityService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="BusinessIdentityServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public BusinessIdentityServiceClientImpl(BusinessIdentityService.BusinessIdentityServiceClient grpcClient, BusinessIdentityServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            BusinessIdentityServiceSettings effectiveSettings = settings ?? BusinessIdentityServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetBusinessIdentity = clientHelper.BuildApiCall<GetBusinessIdentityRequest, BusinessIdentity>("GetBusinessIdentity", grpcClient.GetBusinessIdentityAsync, grpcClient.GetBusinessIdentity, effectiveSettings.GetBusinessIdentitySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetBusinessIdentity);
            Modify_GetBusinessIdentityApiCall(ref _callGetBusinessIdentity);
            _callUpdateBusinessIdentity = clientHelper.BuildApiCall<UpdateBusinessIdentityRequest, BusinessIdentity>("UpdateBusinessIdentity", grpcClient.UpdateBusinessIdentityAsync, grpcClient.UpdateBusinessIdentity, effectiveSettings.UpdateBusinessIdentitySettings).WithGoogleRequestParam("business_identity.name", request => request.BusinessIdentity?.Name);
            Modify_ApiCall(ref _callUpdateBusinessIdentity);
            Modify_UpdateBusinessIdentityApiCall(ref _callUpdateBusinessIdentity);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetBusinessIdentityApiCall(ref gaxgrpc::ApiCall<GetBusinessIdentityRequest, BusinessIdentity> call);

        partial void Modify_UpdateBusinessIdentityApiCall(ref gaxgrpc::ApiCall<UpdateBusinessIdentityRequest, BusinessIdentity> call);

        partial void OnConstruction(BusinessIdentityService.BusinessIdentityServiceClient grpcClient, BusinessIdentityServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC BusinessIdentityService client</summary>
        public override BusinessIdentityService.BusinessIdentityServiceClient GrpcClient { get; }

        partial void Modify_GetBusinessIdentityRequest(ref GetBusinessIdentityRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateBusinessIdentityRequest(ref UpdateBusinessIdentityRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves the business identity of an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BusinessIdentity GetBusinessIdentity(GetBusinessIdentityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBusinessIdentityRequest(ref request, ref callSettings);
            return _callGetBusinessIdentity.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the business identity of an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BusinessIdentity> GetBusinessIdentityAsync(GetBusinessIdentityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBusinessIdentityRequest(ref request, ref callSettings);
            return _callGetBusinessIdentity.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the business identity of an account. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BusinessIdentity UpdateBusinessIdentity(UpdateBusinessIdentityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBusinessIdentityRequest(ref request, ref callSettings);
            return _callUpdateBusinessIdentity.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the business identity of an account. Executing this method requires
        /// admin access.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BusinessIdentity> UpdateBusinessIdentityAsync(UpdateBusinessIdentityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBusinessIdentityRequest(ref request, ref callSettings);
            return _callUpdateBusinessIdentity.Async(request, callSettings);
        }
    }
}
