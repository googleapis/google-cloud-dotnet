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

namespace Google.Shopping.Merchant.Lfp.V1Beta
{
    /// <summary>Settings for <see cref="LfpSaleServiceClient"/> instances.</summary>
    public sealed partial class LfpSaleServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="LfpSaleServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="LfpSaleServiceSettings"/>.</returns>
        public static LfpSaleServiceSettings GetDefault() => new LfpSaleServiceSettings();

        /// <summary>Constructs a new <see cref="LfpSaleServiceSettings"/> object with default settings.</summary>
        public LfpSaleServiceSettings()
        {
        }

        private LfpSaleServiceSettings(LfpSaleServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            InsertLfpSaleSettings = existing.InsertLfpSaleSettings;
            OnCopy(existing);
        }

        partial void OnCopy(LfpSaleServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LfpSaleServiceClient.InsertLfpSale</c> and <c>LfpSaleServiceClient.InsertLfpSaleAsync</c>.
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
        public gaxgrpc::CallSettings InsertLfpSaleSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="LfpSaleServiceSettings"/> object.</returns>
        public LfpSaleServiceSettings Clone() => new LfpSaleServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="LfpSaleServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class LfpSaleServiceClientBuilder : gaxgrpc::ClientBuilderBase<LfpSaleServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public LfpSaleServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public LfpSaleServiceClientBuilder() : base(LfpSaleServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref LfpSaleServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<LfpSaleServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override LfpSaleServiceClient Build()
        {
            LfpSaleServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<LfpSaleServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<LfpSaleServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private LfpSaleServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return LfpSaleServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<LfpSaleServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return LfpSaleServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => LfpSaleServiceClient.ChannelPool;
    }

    /// <summary>LfpSaleService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for a [LFP
    /// partner](https://support.google.com/merchants/answer/7676652) to submit sales
    /// data for a merchant.
    /// </remarks>
    public abstract partial class LfpSaleServiceClient
    {
        /// <summary>
        /// The default endpoint for the LfpSaleService service, which is a host of "merchantapi.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default LfpSaleService scopes.</summary>
        /// <remarks>
        /// The default LfpSaleService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(LfpSaleService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="LfpSaleServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="LfpSaleServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="LfpSaleServiceClient"/>.</returns>
        public static stt::Task<LfpSaleServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new LfpSaleServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="LfpSaleServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="LfpSaleServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="LfpSaleServiceClient"/>.</returns>
        public static LfpSaleServiceClient Create() => new LfpSaleServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="LfpSaleServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="LfpSaleServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="LfpSaleServiceClient"/>.</returns>
        internal static LfpSaleServiceClient Create(grpccore::CallInvoker callInvoker, LfpSaleServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            LfpSaleService.LfpSaleServiceClient grpcClient = new LfpSaleService.LfpSaleServiceClient(callInvoker);
            return new LfpSaleServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC LfpSaleService client</summary>
        public virtual LfpSaleService.LfpSaleServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Inserts a `LfpSale` for the given merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LfpSale InsertLfpSale(InsertLfpSaleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Inserts a `LfpSale` for the given merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LfpSale> InsertLfpSaleAsync(InsertLfpSaleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Inserts a `LfpSale` for the given merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LfpSale> InsertLfpSaleAsync(InsertLfpSaleRequest request, st::CancellationToken cancellationToken) =>
            InsertLfpSaleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>LfpSaleService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for a [LFP
    /// partner](https://support.google.com/merchants/answer/7676652) to submit sales
    /// data for a merchant.
    /// </remarks>
    public sealed partial class LfpSaleServiceClientImpl : LfpSaleServiceClient
    {
        private readonly gaxgrpc::ApiCall<InsertLfpSaleRequest, LfpSale> _callInsertLfpSale;

        /// <summary>
        /// Constructs a client wrapper for the LfpSaleService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="LfpSaleServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public LfpSaleServiceClientImpl(LfpSaleService.LfpSaleServiceClient grpcClient, LfpSaleServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            LfpSaleServiceSettings effectiveSettings = settings ?? LfpSaleServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callInsertLfpSale = clientHelper.BuildApiCall<InsertLfpSaleRequest, LfpSale>("InsertLfpSale", grpcClient.InsertLfpSaleAsync, grpcClient.InsertLfpSale, effectiveSettings.InsertLfpSaleSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callInsertLfpSale);
            Modify_InsertLfpSaleApiCall(ref _callInsertLfpSale);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_InsertLfpSaleApiCall(ref gaxgrpc::ApiCall<InsertLfpSaleRequest, LfpSale> call);

        partial void OnConstruction(LfpSaleService.LfpSaleServiceClient grpcClient, LfpSaleServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC LfpSaleService client</summary>
        public override LfpSaleService.LfpSaleServiceClient GrpcClient { get; }

        partial void Modify_InsertLfpSaleRequest(ref InsertLfpSaleRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Inserts a `LfpSale` for the given merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LfpSale InsertLfpSale(InsertLfpSaleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertLfpSaleRequest(ref request, ref callSettings);
            return _callInsertLfpSale.Sync(request, callSettings);
        }

        /// <summary>
        /// Inserts a `LfpSale` for the given merchant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LfpSale> InsertLfpSaleAsync(InsertLfpSaleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertLfpSaleRequest(ref request, ref callSettings);
            return _callInsertLfpSale.Async(request, callSettings);
        }
    }
}
