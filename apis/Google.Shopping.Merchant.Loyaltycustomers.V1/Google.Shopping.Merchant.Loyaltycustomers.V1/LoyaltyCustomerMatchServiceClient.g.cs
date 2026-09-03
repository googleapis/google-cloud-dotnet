// Copyright 2026 Google LLC
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

namespace Google.Shopping.Merchant.Loyaltycustomers.V1
{
    /// <summary>Settings for <see cref="LoyaltyCustomerMatchServiceClient"/> instances.</summary>
    public sealed partial class LoyaltyCustomerMatchServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="LoyaltyCustomerMatchServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="LoyaltyCustomerMatchServiceSettings"/>.</returns>
        public static LoyaltyCustomerMatchServiceSettings GetDefault() => new LoyaltyCustomerMatchServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="LoyaltyCustomerMatchServiceSettings"/> object with default settings.
        /// </summary>
        public LoyaltyCustomerMatchServiceSettings()
        {
        }

        private LoyaltyCustomerMatchServiceSettings(LoyaltyCustomerMatchServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ManageLoyaltyCustomerMatchSettings = existing.ManageLoyaltyCustomerMatchSettings;
            OnCopy(existing);
        }

        partial void OnCopy(LoyaltyCustomerMatchServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LoyaltyCustomerMatchServiceClient.ManageLoyaltyCustomerMatch</c> and
        /// <c>LoyaltyCustomerMatchServiceClient.ManageLoyaltyCustomerMatchAsync</c>.
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
        public gaxgrpc::CallSettings ManageLoyaltyCustomerMatchSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="LoyaltyCustomerMatchServiceSettings"/> object.</returns>
        public LoyaltyCustomerMatchServiceSettings Clone() => new LoyaltyCustomerMatchServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="LoyaltyCustomerMatchServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class LoyaltyCustomerMatchServiceClientBuilder : gaxgrpc::ClientBuilderBase<LoyaltyCustomerMatchServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public LoyaltyCustomerMatchServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public LoyaltyCustomerMatchServiceClientBuilder() : base(LoyaltyCustomerMatchServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref LoyaltyCustomerMatchServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<LoyaltyCustomerMatchServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override LoyaltyCustomerMatchServiceClient Build()
        {
            LoyaltyCustomerMatchServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<LoyaltyCustomerMatchServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<LoyaltyCustomerMatchServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private LoyaltyCustomerMatchServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return LoyaltyCustomerMatchServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<LoyaltyCustomerMatchServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return LoyaltyCustomerMatchServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => LoyaltyCustomerMatchServiceClient.ChannelPool;
    }

    /// <summary>LoyaltyCustomerMatchService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Manages customer loyalty program memberships for merchants.
    /// 
    /// This service allows all merchants, including non-advertisers, to share their
    /// first-party customer data of loyalty program members. Google uses this data
    /// to personalize organic free listing shopping experiences, in compliance with
    /// the [Merchant Center Terms of
    /// Service](https://support.google.com/merchants/answer/160173).
    /// 
    /// 
    /// The service follows a non-standard, imperative pattern,
    /// exposing a single `ManageLoyaltyCustomerMatch` method rather than
    /// conventional resource identifiers and CRUD operations. This design protects
    /// user privacy by preventing the discovery of a customer's presence or
    /// membership status through standard GET or LIST methods.
    /// </remarks>
    public abstract partial class LoyaltyCustomerMatchServiceClient
    {
        /// <summary>
        /// The default endpoint for the LoyaltyCustomerMatchService service, which is a host of
        /// "merchantapi.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default LoyaltyCustomerMatchService scopes.</summary>
        /// <remarks>
        /// The default LoyaltyCustomerMatchService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(LoyaltyCustomerMatchService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="LoyaltyCustomerMatchServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="LoyaltyCustomerMatchServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="LoyaltyCustomerMatchServiceClient"/>.</returns>
        public static stt::Task<LoyaltyCustomerMatchServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new LoyaltyCustomerMatchServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="LoyaltyCustomerMatchServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="LoyaltyCustomerMatchServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="LoyaltyCustomerMatchServiceClient"/>.</returns>
        public static LoyaltyCustomerMatchServiceClient Create() => new LoyaltyCustomerMatchServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="LoyaltyCustomerMatchServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="LoyaltyCustomerMatchServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="LoyaltyCustomerMatchServiceClient"/>.</returns>
        internal static LoyaltyCustomerMatchServiceClient Create(grpccore::CallInvoker callInvoker, LoyaltyCustomerMatchServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            LoyaltyCustomerMatchService.LoyaltyCustomerMatchServiceClient grpcClient = new LoyaltyCustomerMatchService.LoyaltyCustomerMatchServiceClient(callInvoker);
            return new LoyaltyCustomerMatchServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC LoyaltyCustomerMatchService client</summary>
        public virtual LoyaltyCustomerMatchService.LoyaltyCustomerMatchServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Manages (inserts, updates, or removes) a customer's loyalty tier
        /// information.
        /// 
        /// This method serves as a single interface for all changes to a customer's
        /// loyalty status. The specific action (insert, update, or remove) is
        /// determined by the current state of the merchant-to-customer association and
        /// the `loyalty_tier` value provided in the request.
        /// 
        /// **Operation Logic:**
        /// 
        /// * **Upsert (Insert/Update):** Providing any valid tier other than
        /// `NON_MEMBER` will associate the customer with that tier. If an association
        /// already exists, it will be updated; otherwise, a new one will be created.
        /// * **Removal:** Setting `loyalty_tier` to `NON_MEMBER` will remove any
        /// existing loyalty association for the customer.
        /// 
        /// **Privacy Note:** To protect user privacy, this method consistently returns
        /// a `200 OK` status with a default `LoyaltyCustomer` response if the
        /// customer's identifier cannot be matched to a Google account or if the user
        /// has not opted into loyalty personalization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ManageLoyaltyCustomerMatchResponse ManageLoyaltyCustomerMatch(ManageLoyaltyCustomerMatchRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Manages (inserts, updates, or removes) a customer's loyalty tier
        /// information.
        /// 
        /// This method serves as a single interface for all changes to a customer's
        /// loyalty status. The specific action (insert, update, or remove) is
        /// determined by the current state of the merchant-to-customer association and
        /// the `loyalty_tier` value provided in the request.
        /// 
        /// **Operation Logic:**
        /// 
        /// * **Upsert (Insert/Update):** Providing any valid tier other than
        /// `NON_MEMBER` will associate the customer with that tier. If an association
        /// already exists, it will be updated; otherwise, a new one will be created.
        /// * **Removal:** Setting `loyalty_tier` to `NON_MEMBER` will remove any
        /// existing loyalty association for the customer.
        /// 
        /// **Privacy Note:** To protect user privacy, this method consistently returns
        /// a `200 OK` status with a default `LoyaltyCustomer` response if the
        /// customer's identifier cannot be matched to a Google account or if the user
        /// has not opted into loyalty personalization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManageLoyaltyCustomerMatchResponse> ManageLoyaltyCustomerMatchAsync(ManageLoyaltyCustomerMatchRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Manages (inserts, updates, or removes) a customer's loyalty tier
        /// information.
        /// 
        /// This method serves as a single interface for all changes to a customer's
        /// loyalty status. The specific action (insert, update, or remove) is
        /// determined by the current state of the merchant-to-customer association and
        /// the `loyalty_tier` value provided in the request.
        /// 
        /// **Operation Logic:**
        /// 
        /// * **Upsert (Insert/Update):** Providing any valid tier other than
        /// `NON_MEMBER` will associate the customer with that tier. If an association
        /// already exists, it will be updated; otherwise, a new one will be created.
        /// * **Removal:** Setting `loyalty_tier` to `NON_MEMBER` will remove any
        /// existing loyalty association for the customer.
        /// 
        /// **Privacy Note:** To protect user privacy, this method consistently returns
        /// a `200 OK` status with a default `LoyaltyCustomer` response if the
        /// customer's identifier cannot be matched to a Google account or if the user
        /// has not opted into loyalty personalization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ManageLoyaltyCustomerMatchResponse> ManageLoyaltyCustomerMatchAsync(ManageLoyaltyCustomerMatchRequest request, st::CancellationToken cancellationToken) =>
            ManageLoyaltyCustomerMatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>LoyaltyCustomerMatchService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Manages customer loyalty program memberships for merchants.
    /// 
    /// This service allows all merchants, including non-advertisers, to share their
    /// first-party customer data of loyalty program members. Google uses this data
    /// to personalize organic free listing shopping experiences, in compliance with
    /// the [Merchant Center Terms of
    /// Service](https://support.google.com/merchants/answer/160173).
    /// 
    /// 
    /// The service follows a non-standard, imperative pattern,
    /// exposing a single `ManageLoyaltyCustomerMatch` method rather than
    /// conventional resource identifiers and CRUD operations. This design protects
    /// user privacy by preventing the discovery of a customer's presence or
    /// membership status through standard GET or LIST methods.
    /// </remarks>
    public sealed partial class LoyaltyCustomerMatchServiceClientImpl : LoyaltyCustomerMatchServiceClient
    {
        private readonly gaxgrpc::ApiCall<ManageLoyaltyCustomerMatchRequest, ManageLoyaltyCustomerMatchResponse> _callManageLoyaltyCustomerMatch;

        /// <summary>
        /// Constructs a client wrapper for the LoyaltyCustomerMatchService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="LoyaltyCustomerMatchServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public LoyaltyCustomerMatchServiceClientImpl(LoyaltyCustomerMatchService.LoyaltyCustomerMatchServiceClient grpcClient, LoyaltyCustomerMatchServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            LoyaltyCustomerMatchServiceSettings effectiveSettings = settings ?? LoyaltyCustomerMatchServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callManageLoyaltyCustomerMatch = clientHelper.BuildApiCall<ManageLoyaltyCustomerMatchRequest, ManageLoyaltyCustomerMatchResponse>("ManageLoyaltyCustomerMatch", grpcClient.ManageLoyaltyCustomerMatchAsync, grpcClient.ManageLoyaltyCustomerMatch, effectiveSettings.ManageLoyaltyCustomerMatchSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callManageLoyaltyCustomerMatch);
            Modify_ManageLoyaltyCustomerMatchApiCall(ref _callManageLoyaltyCustomerMatch);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ManageLoyaltyCustomerMatchApiCall(ref gaxgrpc::ApiCall<ManageLoyaltyCustomerMatchRequest, ManageLoyaltyCustomerMatchResponse> call);

        partial void OnConstruction(LoyaltyCustomerMatchService.LoyaltyCustomerMatchServiceClient grpcClient, LoyaltyCustomerMatchServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC LoyaltyCustomerMatchService client</summary>
        public override LoyaltyCustomerMatchService.LoyaltyCustomerMatchServiceClient GrpcClient { get; }

        partial void Modify_ManageLoyaltyCustomerMatchRequest(ref ManageLoyaltyCustomerMatchRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Manages (inserts, updates, or removes) a customer's loyalty tier
        /// information.
        /// 
        /// This method serves as a single interface for all changes to a customer's
        /// loyalty status. The specific action (insert, update, or remove) is
        /// determined by the current state of the merchant-to-customer association and
        /// the `loyalty_tier` value provided in the request.
        /// 
        /// **Operation Logic:**
        /// 
        /// * **Upsert (Insert/Update):** Providing any valid tier other than
        /// `NON_MEMBER` will associate the customer with that tier. If an association
        /// already exists, it will be updated; otherwise, a new one will be created.
        /// * **Removal:** Setting `loyalty_tier` to `NON_MEMBER` will remove any
        /// existing loyalty association for the customer.
        /// 
        /// **Privacy Note:** To protect user privacy, this method consistently returns
        /// a `200 OK` status with a default `LoyaltyCustomer` response if the
        /// customer's identifier cannot be matched to a Google account or if the user
        /// has not opted into loyalty personalization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ManageLoyaltyCustomerMatchResponse ManageLoyaltyCustomerMatch(ManageLoyaltyCustomerMatchRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ManageLoyaltyCustomerMatchRequest(ref request, ref callSettings);
            return _callManageLoyaltyCustomerMatch.Sync(request, callSettings);
        }

        /// <summary>
        /// Manages (inserts, updates, or removes) a customer's loyalty tier
        /// information.
        /// 
        /// This method serves as a single interface for all changes to a customer's
        /// loyalty status. The specific action (insert, update, or remove) is
        /// determined by the current state of the merchant-to-customer association and
        /// the `loyalty_tier` value provided in the request.
        /// 
        /// **Operation Logic:**
        /// 
        /// * **Upsert (Insert/Update):** Providing any valid tier other than
        /// `NON_MEMBER` will associate the customer with that tier. If an association
        /// already exists, it will be updated; otherwise, a new one will be created.
        /// * **Removal:** Setting `loyalty_tier` to `NON_MEMBER` will remove any
        /// existing loyalty association for the customer.
        /// 
        /// **Privacy Note:** To protect user privacy, this method consistently returns
        /// a `200 OK` status with a default `LoyaltyCustomer` response if the
        /// customer's identifier cannot be matched to a Google account or if the user
        /// has not opted into loyalty personalization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ManageLoyaltyCustomerMatchResponse> ManageLoyaltyCustomerMatchAsync(ManageLoyaltyCustomerMatchRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ManageLoyaltyCustomerMatchRequest(ref request, ref callSettings);
            return _callManageLoyaltyCustomerMatch.Async(request, callSettings);
        }
    }
}
