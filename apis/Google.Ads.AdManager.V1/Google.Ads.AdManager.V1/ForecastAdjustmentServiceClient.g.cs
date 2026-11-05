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
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Ads.AdManager.V1
{
    /// <summary>Settings for <see cref="ForecastAdjustmentServiceClient"/> instances.</summary>
    public sealed partial class ForecastAdjustmentServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ForecastAdjustmentServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ForecastAdjustmentServiceSettings"/>.</returns>
        public static ForecastAdjustmentServiceSettings GetDefault() => new ForecastAdjustmentServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ForecastAdjustmentServiceSettings"/> object with default settings.
        /// </summary>
        public ForecastAdjustmentServiceSettings()
        {
        }

        private ForecastAdjustmentServiceSettings(ForecastAdjustmentServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetForecastAdjustmentSettings = existing.GetForecastAdjustmentSettings;
            ListForecastAdjustmentsSettings = existing.ListForecastAdjustmentsSettings;
            CreateForecastAdjustmentSettings = existing.CreateForecastAdjustmentSettings;
            BatchCreateForecastAdjustmentsSettings = existing.BatchCreateForecastAdjustmentsSettings;
            BatchActivateForecastAdjustmentsSettings = existing.BatchActivateForecastAdjustmentsSettings;
            BatchDeactivateForecastAdjustmentsSettings = existing.BatchDeactivateForecastAdjustmentsSettings;
            UpdateForecastAdjustmentSettings = existing.UpdateForecastAdjustmentSettings;
            BatchUpdateForecastAdjustmentsSettings = existing.BatchUpdateForecastAdjustmentsSettings;
            CalculateDailyAdOpportunityCountsSettings = existing.CalculateDailyAdOpportunityCountsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ForecastAdjustmentServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ForecastAdjustmentServiceClient.GetForecastAdjustment</c> and
        /// <c>ForecastAdjustmentServiceClient.GetForecastAdjustmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetForecastAdjustmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ForecastAdjustmentServiceClient.ListForecastAdjustments</c> and
        /// <c>ForecastAdjustmentServiceClient.ListForecastAdjustmentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListForecastAdjustmentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ForecastAdjustmentServiceClient.CreateForecastAdjustment</c> and
        /// <c>ForecastAdjustmentServiceClient.CreateForecastAdjustmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateForecastAdjustmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ForecastAdjustmentServiceClient.BatchCreateForecastAdjustments</c> and
        /// <c>ForecastAdjustmentServiceClient.BatchCreateForecastAdjustmentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateForecastAdjustmentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ForecastAdjustmentServiceClient.BatchActivateForecastAdjustments</c> and
        /// <c>ForecastAdjustmentServiceClient.BatchActivateForecastAdjustmentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchActivateForecastAdjustmentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ForecastAdjustmentServiceClient.BatchDeactivateForecastAdjustments</c> and
        /// <c>ForecastAdjustmentServiceClient.BatchDeactivateForecastAdjustmentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchDeactivateForecastAdjustmentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ForecastAdjustmentServiceClient.UpdateForecastAdjustment</c> and
        /// <c>ForecastAdjustmentServiceClient.UpdateForecastAdjustmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateForecastAdjustmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ForecastAdjustmentServiceClient.BatchUpdateForecastAdjustments</c> and
        /// <c>ForecastAdjustmentServiceClient.BatchUpdateForecastAdjustmentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchUpdateForecastAdjustmentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ForecastAdjustmentServiceClient.CalculateDailyAdOpportunityCounts</c> and
        /// <c>ForecastAdjustmentServiceClient.CalculateDailyAdOpportunityCountsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CalculateDailyAdOpportunityCountsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ForecastAdjustmentServiceSettings"/> object.</returns>
        public ForecastAdjustmentServiceSettings Clone() => new ForecastAdjustmentServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ForecastAdjustmentServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ForecastAdjustmentServiceClientBuilder : gaxgrpc::ClientBuilderBase<ForecastAdjustmentServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ForecastAdjustmentServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ForecastAdjustmentServiceClientBuilder() : base(ForecastAdjustmentServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ForecastAdjustmentServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ForecastAdjustmentServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ForecastAdjustmentServiceClient Build()
        {
            ForecastAdjustmentServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ForecastAdjustmentServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ForecastAdjustmentServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ForecastAdjustmentServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ForecastAdjustmentServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ForecastAdjustmentServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ForecastAdjustmentServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ForecastAdjustmentServiceClient.ChannelPool;
    }

    /// <summary>ForecastAdjustmentService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `ForecastAdjustment` objects.
    /// </remarks>
    public abstract partial class ForecastAdjustmentServiceClient
    {
        /// <summary>
        /// The default endpoint for the ForecastAdjustmentService service, which is a host of
        /// "admanager.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default ForecastAdjustmentService scopes.</summary>
        /// <remarks>
        /// The default ForecastAdjustmentService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// <item><description>https://www.googleapis.com/auth/admanager.readonly</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
            "https://www.googleapis.com/auth/admanager.readonly",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ForecastAdjustmentService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ForecastAdjustmentServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ForecastAdjustmentServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ForecastAdjustmentServiceClient"/>.</returns>
        public static stt::Task<ForecastAdjustmentServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ForecastAdjustmentServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ForecastAdjustmentServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ForecastAdjustmentServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ForecastAdjustmentServiceClient"/>.</returns>
        public static ForecastAdjustmentServiceClient Create() => new ForecastAdjustmentServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ForecastAdjustmentServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ForecastAdjustmentServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ForecastAdjustmentServiceClient"/>.</returns>
        internal static ForecastAdjustmentServiceClient Create(grpccore::CallInvoker callInvoker, ForecastAdjustmentServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ForecastAdjustmentService.ForecastAdjustmentServiceClient grpcClient = new ForecastAdjustmentService.ForecastAdjustmentServiceClient(callInvoker);
            return new ForecastAdjustmentServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ForecastAdjustmentService client</summary>
        public virtual ForecastAdjustmentService.ForecastAdjustmentServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `ForecastAdjustment` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ForecastAdjustment GetForecastAdjustment(GetForecastAdjustmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `ForecastAdjustment` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ForecastAdjustment> GetForecastAdjustmentAsync(GetForecastAdjustmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `ForecastAdjustment` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ForecastAdjustment> GetForecastAdjustmentAsync(GetForecastAdjustmentRequest request, st::CancellationToken cancellationToken) =>
            GetForecastAdjustmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `ForecastAdjustment` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ForecastAdjustment.
        /// Format:
        /// `networks/{network_code}/forecastAdjustments/{forecastAdjustmentId}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ForecastAdjustment GetForecastAdjustment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetForecastAdjustment(new GetForecastAdjustmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `ForecastAdjustment` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ForecastAdjustment.
        /// Format:
        /// `networks/{network_code}/forecastAdjustments/{forecastAdjustmentId}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ForecastAdjustment> GetForecastAdjustmentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetForecastAdjustmentAsync(new GetForecastAdjustmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `ForecastAdjustment` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ForecastAdjustment.
        /// Format:
        /// `networks/{network_code}/forecastAdjustments/{forecastAdjustmentId}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ForecastAdjustment> GetForecastAdjustmentAsync(string name, st::CancellationToken cancellationToken) =>
            GetForecastAdjustmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `ForecastAdjustment` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ForecastAdjustment.
        /// Format:
        /// `networks/{network_code}/forecastAdjustments/{forecastAdjustmentId}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ForecastAdjustment GetForecastAdjustment(ForecastAdjustmentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetForecastAdjustment(new GetForecastAdjustmentRequest
            {
                ForecastAdjustmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `ForecastAdjustment` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ForecastAdjustment.
        /// Format:
        /// `networks/{network_code}/forecastAdjustments/{forecastAdjustmentId}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ForecastAdjustment> GetForecastAdjustmentAsync(ForecastAdjustmentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetForecastAdjustmentAsync(new GetForecastAdjustmentRequest
            {
                ForecastAdjustmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `ForecastAdjustment` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ForecastAdjustment.
        /// Format:
        /// `networks/{network_code}/forecastAdjustments/{forecastAdjustmentId}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ForecastAdjustment> GetForecastAdjustmentAsync(ForecastAdjustmentName name, st::CancellationToken cancellationToken) =>
            GetForecastAdjustmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ForecastAdjustment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListForecastAdjustmentsResponse, ForecastAdjustment> ListForecastAdjustments(ListForecastAdjustmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ForecastAdjustment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListForecastAdjustmentsResponse, ForecastAdjustment> ListForecastAdjustmentsAsync(ListForecastAdjustmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of ForecastAdjustments.
        /// Format: `networks/{network_code}`
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
        /// <returns>A pageable sequence of <see cref="ForecastAdjustment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListForecastAdjustmentsResponse, ForecastAdjustment> ListForecastAdjustments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListForecastAdjustmentsRequest request = new ListForecastAdjustmentsRequest
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
            return ListForecastAdjustments(request, callSettings);
        }

        /// <summary>
        /// Lists `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of ForecastAdjustments.
        /// Format: `networks/{network_code}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ForecastAdjustment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListForecastAdjustmentsResponse, ForecastAdjustment> ListForecastAdjustmentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListForecastAdjustmentsRequest request = new ListForecastAdjustmentsRequest
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
            return ListForecastAdjustmentsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of ForecastAdjustments.
        /// Format: `networks/{network_code}`
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
        /// <returns>A pageable sequence of <see cref="ForecastAdjustment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListForecastAdjustmentsResponse, ForecastAdjustment> ListForecastAdjustments(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListForecastAdjustmentsRequest request = new ListForecastAdjustmentsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListForecastAdjustments(request, callSettings);
        }

        /// <summary>
        /// Lists `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of ForecastAdjustments.
        /// Format: `networks/{network_code}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ForecastAdjustment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListForecastAdjustmentsResponse, ForecastAdjustment> ListForecastAdjustmentsAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListForecastAdjustmentsRequest request = new ListForecastAdjustmentsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListForecastAdjustmentsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a `ForecastAdjustment` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ForecastAdjustment CreateForecastAdjustment(CreateForecastAdjustmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `ForecastAdjustment` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ForecastAdjustment> CreateForecastAdjustmentAsync(CreateForecastAdjustmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `ForecastAdjustment` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ForecastAdjustment> CreateForecastAdjustmentAsync(CreateForecastAdjustmentRequest request, st::CancellationToken cancellationToken) =>
            CreateForecastAdjustmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `ForecastAdjustment` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `ForecastAdjustment` will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="forecastAdjustment">
        /// Required. The `ForecastAdjustment` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ForecastAdjustment CreateForecastAdjustment(string parent, ForecastAdjustment forecastAdjustment, gaxgrpc::CallSettings callSettings = null) =>
            CreateForecastAdjustment(new CreateForecastAdjustmentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ForecastAdjustment = gax::GaxPreconditions.CheckNotNull(forecastAdjustment, nameof(forecastAdjustment)),
            }, callSettings);

        /// <summary>
        /// Creates a `ForecastAdjustment` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `ForecastAdjustment` will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="forecastAdjustment">
        /// Required. The `ForecastAdjustment` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ForecastAdjustment> CreateForecastAdjustmentAsync(string parent, ForecastAdjustment forecastAdjustment, gaxgrpc::CallSettings callSettings = null) =>
            CreateForecastAdjustmentAsync(new CreateForecastAdjustmentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ForecastAdjustment = gax::GaxPreconditions.CheckNotNull(forecastAdjustment, nameof(forecastAdjustment)),
            }, callSettings);

        /// <summary>
        /// Creates a `ForecastAdjustment` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `ForecastAdjustment` will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="forecastAdjustment">
        /// Required. The `ForecastAdjustment` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ForecastAdjustment> CreateForecastAdjustmentAsync(string parent, ForecastAdjustment forecastAdjustment, st::CancellationToken cancellationToken) =>
            CreateForecastAdjustmentAsync(parent, forecastAdjustment, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `ForecastAdjustment` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `ForecastAdjustment` will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="forecastAdjustment">
        /// Required. The `ForecastAdjustment` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ForecastAdjustment CreateForecastAdjustment(NetworkName parent, ForecastAdjustment forecastAdjustment, gaxgrpc::CallSettings callSettings = null) =>
            CreateForecastAdjustment(new CreateForecastAdjustmentRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ForecastAdjustment = gax::GaxPreconditions.CheckNotNull(forecastAdjustment, nameof(forecastAdjustment)),
            }, callSettings);

        /// <summary>
        /// Creates a `ForecastAdjustment` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `ForecastAdjustment` will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="forecastAdjustment">
        /// Required. The `ForecastAdjustment` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ForecastAdjustment> CreateForecastAdjustmentAsync(NetworkName parent, ForecastAdjustment forecastAdjustment, gaxgrpc::CallSettings callSettings = null) =>
            CreateForecastAdjustmentAsync(new CreateForecastAdjustmentRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ForecastAdjustment = gax::GaxPreconditions.CheckNotNull(forecastAdjustment, nameof(forecastAdjustment)),
            }, callSettings);

        /// <summary>
        /// Creates a `ForecastAdjustment` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `ForecastAdjustment` will be
        /// created. Format: `networks/{network_code}`
        /// </param>
        /// <param name="forecastAdjustment">
        /// Required. The `ForecastAdjustment` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ForecastAdjustment> CreateForecastAdjustmentAsync(NetworkName parent, ForecastAdjustment forecastAdjustment, st::CancellationToken cancellationToken) =>
            CreateForecastAdjustmentAsync(parent, forecastAdjustment, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateForecastAdjustmentsResponse BatchCreateForecastAdjustments(BatchCreateForecastAdjustmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateForecastAdjustmentsResponse> BatchCreateForecastAdjustmentsAsync(BatchCreateForecastAdjustmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateForecastAdjustmentsResponse> BatchCreateForecastAdjustmentsAsync(BatchCreateForecastAdjustmentsRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateForecastAdjustmentsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `ForecastAdjustments` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateForecastAdjustmentRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `ForecastAdjustment` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateForecastAdjustmentsResponse BatchCreateForecastAdjustments(string parent, scg::IEnumerable<CreateForecastAdjustmentRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateForecastAdjustments(new BatchCreateForecastAdjustmentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `ForecastAdjustments` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateForecastAdjustmentRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `ForecastAdjustment` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateForecastAdjustmentsResponse> BatchCreateForecastAdjustmentsAsync(string parent, scg::IEnumerable<CreateForecastAdjustmentRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateForecastAdjustmentsAsync(new BatchCreateForecastAdjustmentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `ForecastAdjustments` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateForecastAdjustmentRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `ForecastAdjustment` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateForecastAdjustmentsResponse> BatchCreateForecastAdjustmentsAsync(string parent, scg::IEnumerable<CreateForecastAdjustmentRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateForecastAdjustmentsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `ForecastAdjustments` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateForecastAdjustmentRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `ForecastAdjustment` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateForecastAdjustmentsResponse BatchCreateForecastAdjustments(NetworkName parent, scg::IEnumerable<CreateForecastAdjustmentRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateForecastAdjustments(new BatchCreateForecastAdjustmentsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `ForecastAdjustments` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateForecastAdjustmentRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `ForecastAdjustment` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateForecastAdjustmentsResponse> BatchCreateForecastAdjustmentsAsync(NetworkName parent, scg::IEnumerable<CreateForecastAdjustmentRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateForecastAdjustmentsAsync(new BatchCreateForecastAdjustmentsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `ForecastAdjustments` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the CreateForecastAdjustmentRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `ForecastAdjustment` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateForecastAdjustmentsResponse> BatchCreateForecastAdjustmentsAsync(NetworkName parent, scg::IEnumerable<CreateForecastAdjustmentRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateForecastAdjustmentsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Activates a list of `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateForecastAdjustmentsResponse BatchActivateForecastAdjustments(BatchActivateForecastAdjustmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Activates a list of `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateForecastAdjustmentsResponse> BatchActivateForecastAdjustmentsAsync(BatchActivateForecastAdjustmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Activates a list of `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateForecastAdjustmentsResponse> BatchActivateForecastAdjustmentsAsync(BatchActivateForecastAdjustmentsRequest request, st::CancellationToken cancellationToken) =>
            BatchActivateForecastAdjustmentsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Activates a list of `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `ForecastAdjustment` objects to
        /// activate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateForecastAdjustmentsResponse BatchActivateForecastAdjustments(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateForecastAdjustments(new BatchActivateForecastAdjustmentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Activates a list of `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `ForecastAdjustment` objects to
        /// activate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateForecastAdjustmentsResponse> BatchActivateForecastAdjustmentsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateForecastAdjustmentsAsync(new BatchActivateForecastAdjustmentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Activates a list of `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `ForecastAdjustment` objects to
        /// activate.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateForecastAdjustmentsResponse> BatchActivateForecastAdjustmentsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchActivateForecastAdjustmentsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Activates a list of `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `ForecastAdjustment` objects to
        /// activate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateForecastAdjustmentsResponse BatchActivateForecastAdjustments(NetworkName parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateForecastAdjustments(new BatchActivateForecastAdjustmentsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Activates a list of `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `ForecastAdjustment` objects to
        /// activate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateForecastAdjustmentsResponse> BatchActivateForecastAdjustmentsAsync(NetworkName parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateForecastAdjustmentsAsync(new BatchActivateForecastAdjustmentsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Activates a list of `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `ForecastAdjustment` objects to
        /// activate.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateForecastAdjustmentsResponse> BatchActivateForecastAdjustmentsAsync(NetworkName parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchActivateForecastAdjustmentsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deactivates a list of `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateForecastAdjustmentsResponse BatchDeactivateForecastAdjustments(BatchDeactivateForecastAdjustmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deactivates a list of `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateForecastAdjustmentsResponse> BatchDeactivateForecastAdjustmentsAsync(BatchDeactivateForecastAdjustmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deactivates a list of `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateForecastAdjustmentsResponse> BatchDeactivateForecastAdjustmentsAsync(BatchDeactivateForecastAdjustmentsRequest request, st::CancellationToken cancellationToken) =>
            BatchDeactivateForecastAdjustmentsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deactivates a list of `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `ForecastAdjustment` objects to
        /// deactivate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateForecastAdjustmentsResponse BatchDeactivateForecastAdjustments(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateForecastAdjustments(new BatchDeactivateForecastAdjustmentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `ForecastAdjustment` objects to
        /// deactivate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateForecastAdjustmentsResponse> BatchDeactivateForecastAdjustmentsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateForecastAdjustmentsAsync(new BatchDeactivateForecastAdjustmentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `ForecastAdjustment` objects to
        /// deactivate.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateForecastAdjustmentsResponse> BatchDeactivateForecastAdjustmentsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchDeactivateForecastAdjustmentsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deactivates a list of `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `ForecastAdjustment` objects to
        /// deactivate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateForecastAdjustmentsResponse BatchDeactivateForecastAdjustments(NetworkName parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateForecastAdjustments(new BatchDeactivateForecastAdjustmentsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `ForecastAdjustment` objects to
        /// deactivate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateForecastAdjustmentsResponse> BatchDeactivateForecastAdjustmentsAsync(NetworkName parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateForecastAdjustmentsAsync(new BatchDeactivateForecastAdjustmentsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `ForecastAdjustment` objects to
        /// deactivate.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateForecastAdjustmentsResponse> BatchDeactivateForecastAdjustmentsAsync(NetworkName parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchDeactivateForecastAdjustmentsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `ForecastAdjustment` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ForecastAdjustment UpdateForecastAdjustment(UpdateForecastAdjustmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `ForecastAdjustment` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ForecastAdjustment> UpdateForecastAdjustmentAsync(UpdateForecastAdjustmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `ForecastAdjustment` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ForecastAdjustment> UpdateForecastAdjustmentAsync(UpdateForecastAdjustmentRequest request, st::CancellationToken cancellationToken) =>
            UpdateForecastAdjustmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `ForecastAdjustment` object.
        /// </summary>
        /// <param name="forecastAdjustment">
        /// Required. The `ForecastAdjustment` to update.
        /// 
        /// The `ForecastAdjustment`'s `name` is used to identify the
        /// `ForecastAdjustment` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ForecastAdjustment UpdateForecastAdjustment(ForecastAdjustment forecastAdjustment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateForecastAdjustment(new UpdateForecastAdjustmentRequest
            {
                ForecastAdjustment = gax::GaxPreconditions.CheckNotNull(forecastAdjustment, nameof(forecastAdjustment)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a `ForecastAdjustment` object.
        /// </summary>
        /// <param name="forecastAdjustment">
        /// Required. The `ForecastAdjustment` to update.
        /// 
        /// The `ForecastAdjustment`'s `name` is used to identify the
        /// `ForecastAdjustment` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ForecastAdjustment> UpdateForecastAdjustmentAsync(ForecastAdjustment forecastAdjustment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateForecastAdjustmentAsync(new UpdateForecastAdjustmentRequest
            {
                ForecastAdjustment = gax::GaxPreconditions.CheckNotNull(forecastAdjustment, nameof(forecastAdjustment)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a `ForecastAdjustment` object.
        /// </summary>
        /// <param name="forecastAdjustment">
        /// Required. The `ForecastAdjustment` to update.
        /// 
        /// The `ForecastAdjustment`'s `name` is used to identify the
        /// `ForecastAdjustment` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ForecastAdjustment> UpdateForecastAdjustmentAsync(ForecastAdjustment forecastAdjustment, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateForecastAdjustmentAsync(forecastAdjustment, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateForecastAdjustmentsResponse BatchUpdateForecastAdjustments(BatchUpdateForecastAdjustmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateForecastAdjustmentsResponse> BatchUpdateForecastAdjustmentsAsync(BatchUpdateForecastAdjustmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateForecastAdjustmentsResponse> BatchUpdateForecastAdjustmentsAsync(BatchUpdateForecastAdjustmentsRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdateForecastAdjustmentsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `ForecastAdjustments` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateForecastAdjustmentRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `ForecastAdjustment` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateForecastAdjustmentsResponse BatchUpdateForecastAdjustments(string parent, scg::IEnumerable<UpdateForecastAdjustmentRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateForecastAdjustments(new BatchUpdateForecastAdjustmentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `ForecastAdjustments` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateForecastAdjustmentRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `ForecastAdjustment` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateForecastAdjustmentsResponse> BatchUpdateForecastAdjustmentsAsync(string parent, scg::IEnumerable<UpdateForecastAdjustmentRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateForecastAdjustmentsAsync(new BatchUpdateForecastAdjustmentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `ForecastAdjustments` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateForecastAdjustmentRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `ForecastAdjustment` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateForecastAdjustmentsResponse> BatchUpdateForecastAdjustmentsAsync(string parent, scg::IEnumerable<UpdateForecastAdjustmentRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateForecastAdjustmentsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `ForecastAdjustments` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateForecastAdjustmentRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `ForecastAdjustment` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateForecastAdjustmentsResponse BatchUpdateForecastAdjustments(NetworkName parent, scg::IEnumerable<UpdateForecastAdjustmentRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateForecastAdjustments(new BatchUpdateForecastAdjustmentsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `ForecastAdjustments` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateForecastAdjustmentRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `ForecastAdjustment` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateForecastAdjustmentsResponse> BatchUpdateForecastAdjustmentsAsync(NetworkName parent, scg::IEnumerable<UpdateForecastAdjustmentRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateForecastAdjustmentsAsync(new BatchUpdateForecastAdjustmentsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `ForecastAdjustments` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the UpdateForecastAdjustmentRequest must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `ForecastAdjustment` objects to update.
        /// A maximum of 100 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateForecastAdjustmentsResponse> BatchUpdateForecastAdjustmentsAsync(NetworkName parent, scg::IEnumerable<UpdateForecastAdjustmentRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateForecastAdjustmentsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Calculates daily ad opportunity counts for a prospective
        /// `ForecastAdjustment` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CalculateDailyAdOpportunityCountsResponse CalculateDailyAdOpportunityCounts(CalculateDailyAdOpportunityCountsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Calculates daily ad opportunity counts for a prospective
        /// `ForecastAdjustment` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalculateDailyAdOpportunityCountsResponse> CalculateDailyAdOpportunityCountsAsync(CalculateDailyAdOpportunityCountsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Calculates daily ad opportunity counts for a prospective
        /// `ForecastAdjustment` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalculateDailyAdOpportunityCountsResponse> CalculateDailyAdOpportunityCountsAsync(CalculateDailyAdOpportunityCountsRequest request, st::CancellationToken cancellationToken) =>
            CalculateDailyAdOpportunityCountsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Calculates daily ad opportunity counts for a prospective
        /// `ForecastAdjustment` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `ForecastAdjustment` will be
        /// calculated. Format: `networks/{network_code}`
        /// </param>
        /// <param name="forecastAdjustment">
        /// Required. The prospective `ForecastAdjustment` to calculate daily ad
        /// opportunity counts for.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CalculateDailyAdOpportunityCountsResponse CalculateDailyAdOpportunityCounts(string parent, ForecastAdjustment forecastAdjustment, gaxgrpc::CallSettings callSettings = null) =>
            CalculateDailyAdOpportunityCounts(new CalculateDailyAdOpportunityCountsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ForecastAdjustment = gax::GaxPreconditions.CheckNotNull(forecastAdjustment, nameof(forecastAdjustment)),
            }, callSettings);

        /// <summary>
        /// Calculates daily ad opportunity counts for a prospective
        /// `ForecastAdjustment` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `ForecastAdjustment` will be
        /// calculated. Format: `networks/{network_code}`
        /// </param>
        /// <param name="forecastAdjustment">
        /// Required. The prospective `ForecastAdjustment` to calculate daily ad
        /// opportunity counts for.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalculateDailyAdOpportunityCountsResponse> CalculateDailyAdOpportunityCountsAsync(string parent, ForecastAdjustment forecastAdjustment, gaxgrpc::CallSettings callSettings = null) =>
            CalculateDailyAdOpportunityCountsAsync(new CalculateDailyAdOpportunityCountsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ForecastAdjustment = gax::GaxPreconditions.CheckNotNull(forecastAdjustment, nameof(forecastAdjustment)),
            }, callSettings);

        /// <summary>
        /// Calculates daily ad opportunity counts for a prospective
        /// `ForecastAdjustment` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `ForecastAdjustment` will be
        /// calculated. Format: `networks/{network_code}`
        /// </param>
        /// <param name="forecastAdjustment">
        /// Required. The prospective `ForecastAdjustment` to calculate daily ad
        /// opportunity counts for.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalculateDailyAdOpportunityCountsResponse> CalculateDailyAdOpportunityCountsAsync(string parent, ForecastAdjustment forecastAdjustment, st::CancellationToken cancellationToken) =>
            CalculateDailyAdOpportunityCountsAsync(parent, forecastAdjustment, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Calculates daily ad opportunity counts for a prospective
        /// `ForecastAdjustment` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `ForecastAdjustment` will be
        /// calculated. Format: `networks/{network_code}`
        /// </param>
        /// <param name="forecastAdjustment">
        /// Required. The prospective `ForecastAdjustment` to calculate daily ad
        /// opportunity counts for.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CalculateDailyAdOpportunityCountsResponse CalculateDailyAdOpportunityCounts(NetworkName parent, ForecastAdjustment forecastAdjustment, gaxgrpc::CallSettings callSettings = null) =>
            CalculateDailyAdOpportunityCounts(new CalculateDailyAdOpportunityCountsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ForecastAdjustment = gax::GaxPreconditions.CheckNotNull(forecastAdjustment, nameof(forecastAdjustment)),
            }, callSettings);

        /// <summary>
        /// Calculates daily ad opportunity counts for a prospective
        /// `ForecastAdjustment` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `ForecastAdjustment` will be
        /// calculated. Format: `networks/{network_code}`
        /// </param>
        /// <param name="forecastAdjustment">
        /// Required. The prospective `ForecastAdjustment` to calculate daily ad
        /// opportunity counts for.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalculateDailyAdOpportunityCountsResponse> CalculateDailyAdOpportunityCountsAsync(NetworkName parent, ForecastAdjustment forecastAdjustment, gaxgrpc::CallSettings callSettings = null) =>
            CalculateDailyAdOpportunityCountsAsync(new CalculateDailyAdOpportunityCountsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ForecastAdjustment = gax::GaxPreconditions.CheckNotNull(forecastAdjustment, nameof(forecastAdjustment)),
            }, callSettings);

        /// <summary>
        /// Calculates daily ad opportunity counts for a prospective
        /// `ForecastAdjustment` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `ForecastAdjustment` will be
        /// calculated. Format: `networks/{network_code}`
        /// </param>
        /// <param name="forecastAdjustment">
        /// Required. The prospective `ForecastAdjustment` to calculate daily ad
        /// opportunity counts for.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CalculateDailyAdOpportunityCountsResponse> CalculateDailyAdOpportunityCountsAsync(NetworkName parent, ForecastAdjustment forecastAdjustment, st::CancellationToken cancellationToken) =>
            CalculateDailyAdOpportunityCountsAsync(parent, forecastAdjustment, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ForecastAdjustmentService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `ForecastAdjustment` objects.
    /// </remarks>
    public sealed partial class ForecastAdjustmentServiceClientImpl : ForecastAdjustmentServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetForecastAdjustmentRequest, ForecastAdjustment> _callGetForecastAdjustment;

        private readonly gaxgrpc::ApiCall<ListForecastAdjustmentsRequest, ListForecastAdjustmentsResponse> _callListForecastAdjustments;

        private readonly gaxgrpc::ApiCall<CreateForecastAdjustmentRequest, ForecastAdjustment> _callCreateForecastAdjustment;

        private readonly gaxgrpc::ApiCall<BatchCreateForecastAdjustmentsRequest, BatchCreateForecastAdjustmentsResponse> _callBatchCreateForecastAdjustments;

        private readonly gaxgrpc::ApiCall<BatchActivateForecastAdjustmentsRequest, BatchActivateForecastAdjustmentsResponse> _callBatchActivateForecastAdjustments;

        private readonly gaxgrpc::ApiCall<BatchDeactivateForecastAdjustmentsRequest, BatchDeactivateForecastAdjustmentsResponse> _callBatchDeactivateForecastAdjustments;

        private readonly gaxgrpc::ApiCall<UpdateForecastAdjustmentRequest, ForecastAdjustment> _callUpdateForecastAdjustment;

        private readonly gaxgrpc::ApiCall<BatchUpdateForecastAdjustmentsRequest, BatchUpdateForecastAdjustmentsResponse> _callBatchUpdateForecastAdjustments;

        private readonly gaxgrpc::ApiCall<CalculateDailyAdOpportunityCountsRequest, CalculateDailyAdOpportunityCountsResponse> _callCalculateDailyAdOpportunityCounts;

        /// <summary>
        /// Constructs a client wrapper for the ForecastAdjustmentService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="ForecastAdjustmentServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ForecastAdjustmentServiceClientImpl(ForecastAdjustmentService.ForecastAdjustmentServiceClient grpcClient, ForecastAdjustmentServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ForecastAdjustmentServiceSettings effectiveSettings = settings ?? ForecastAdjustmentServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetForecastAdjustment = clientHelper.BuildApiCall<GetForecastAdjustmentRequest, ForecastAdjustment>("GetForecastAdjustment", grpcClient.GetForecastAdjustmentAsync, grpcClient.GetForecastAdjustment, effectiveSettings.GetForecastAdjustmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetForecastAdjustment);
            Modify_GetForecastAdjustmentApiCall(ref _callGetForecastAdjustment);
            _callListForecastAdjustments = clientHelper.BuildApiCall<ListForecastAdjustmentsRequest, ListForecastAdjustmentsResponse>("ListForecastAdjustments", grpcClient.ListForecastAdjustmentsAsync, grpcClient.ListForecastAdjustments, effectiveSettings.ListForecastAdjustmentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListForecastAdjustments);
            Modify_ListForecastAdjustmentsApiCall(ref _callListForecastAdjustments);
            _callCreateForecastAdjustment = clientHelper.BuildApiCall<CreateForecastAdjustmentRequest, ForecastAdjustment>("CreateForecastAdjustment", grpcClient.CreateForecastAdjustmentAsync, grpcClient.CreateForecastAdjustment, effectiveSettings.CreateForecastAdjustmentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateForecastAdjustment);
            Modify_CreateForecastAdjustmentApiCall(ref _callCreateForecastAdjustment);
            _callBatchCreateForecastAdjustments = clientHelper.BuildApiCall<BatchCreateForecastAdjustmentsRequest, BatchCreateForecastAdjustmentsResponse>("BatchCreateForecastAdjustments", grpcClient.BatchCreateForecastAdjustmentsAsync, grpcClient.BatchCreateForecastAdjustments, effectiveSettings.BatchCreateForecastAdjustmentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateForecastAdjustments);
            Modify_BatchCreateForecastAdjustmentsApiCall(ref _callBatchCreateForecastAdjustments);
            _callBatchActivateForecastAdjustments = clientHelper.BuildApiCall<BatchActivateForecastAdjustmentsRequest, BatchActivateForecastAdjustmentsResponse>("BatchActivateForecastAdjustments", grpcClient.BatchActivateForecastAdjustmentsAsync, grpcClient.BatchActivateForecastAdjustments, effectiveSettings.BatchActivateForecastAdjustmentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchActivateForecastAdjustments);
            Modify_BatchActivateForecastAdjustmentsApiCall(ref _callBatchActivateForecastAdjustments);
            _callBatchDeactivateForecastAdjustments = clientHelper.BuildApiCall<BatchDeactivateForecastAdjustmentsRequest, BatchDeactivateForecastAdjustmentsResponse>("BatchDeactivateForecastAdjustments", grpcClient.BatchDeactivateForecastAdjustmentsAsync, grpcClient.BatchDeactivateForecastAdjustments, effectiveSettings.BatchDeactivateForecastAdjustmentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchDeactivateForecastAdjustments);
            Modify_BatchDeactivateForecastAdjustmentsApiCall(ref _callBatchDeactivateForecastAdjustments);
            _callUpdateForecastAdjustment = clientHelper.BuildApiCall<UpdateForecastAdjustmentRequest, ForecastAdjustment>("UpdateForecastAdjustment", grpcClient.UpdateForecastAdjustmentAsync, grpcClient.UpdateForecastAdjustment, effectiveSettings.UpdateForecastAdjustmentSettings).WithGoogleRequestParam("forecast_adjustment.name", request => request.ForecastAdjustment?.Name);
            Modify_ApiCall(ref _callUpdateForecastAdjustment);
            Modify_UpdateForecastAdjustmentApiCall(ref _callUpdateForecastAdjustment);
            _callBatchUpdateForecastAdjustments = clientHelper.BuildApiCall<BatchUpdateForecastAdjustmentsRequest, BatchUpdateForecastAdjustmentsResponse>("BatchUpdateForecastAdjustments", grpcClient.BatchUpdateForecastAdjustmentsAsync, grpcClient.BatchUpdateForecastAdjustments, effectiveSettings.BatchUpdateForecastAdjustmentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUpdateForecastAdjustments);
            Modify_BatchUpdateForecastAdjustmentsApiCall(ref _callBatchUpdateForecastAdjustments);
            _callCalculateDailyAdOpportunityCounts = clientHelper.BuildApiCall<CalculateDailyAdOpportunityCountsRequest, CalculateDailyAdOpportunityCountsResponse>("CalculateDailyAdOpportunityCounts", grpcClient.CalculateDailyAdOpportunityCountsAsync, grpcClient.CalculateDailyAdOpportunityCounts, effectiveSettings.CalculateDailyAdOpportunityCountsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCalculateDailyAdOpportunityCounts);
            Modify_CalculateDailyAdOpportunityCountsApiCall(ref _callCalculateDailyAdOpportunityCounts);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetForecastAdjustmentApiCall(ref gaxgrpc::ApiCall<GetForecastAdjustmentRequest, ForecastAdjustment> call);

        partial void Modify_ListForecastAdjustmentsApiCall(ref gaxgrpc::ApiCall<ListForecastAdjustmentsRequest, ListForecastAdjustmentsResponse> call);

        partial void Modify_CreateForecastAdjustmentApiCall(ref gaxgrpc::ApiCall<CreateForecastAdjustmentRequest, ForecastAdjustment> call);

        partial void Modify_BatchCreateForecastAdjustmentsApiCall(ref gaxgrpc::ApiCall<BatchCreateForecastAdjustmentsRequest, BatchCreateForecastAdjustmentsResponse> call);

        partial void Modify_BatchActivateForecastAdjustmentsApiCall(ref gaxgrpc::ApiCall<BatchActivateForecastAdjustmentsRequest, BatchActivateForecastAdjustmentsResponse> call);

        partial void Modify_BatchDeactivateForecastAdjustmentsApiCall(ref gaxgrpc::ApiCall<BatchDeactivateForecastAdjustmentsRequest, BatchDeactivateForecastAdjustmentsResponse> call);

        partial void Modify_UpdateForecastAdjustmentApiCall(ref gaxgrpc::ApiCall<UpdateForecastAdjustmentRequest, ForecastAdjustment> call);

        partial void Modify_BatchUpdateForecastAdjustmentsApiCall(ref gaxgrpc::ApiCall<BatchUpdateForecastAdjustmentsRequest, BatchUpdateForecastAdjustmentsResponse> call);

        partial void Modify_CalculateDailyAdOpportunityCountsApiCall(ref gaxgrpc::ApiCall<CalculateDailyAdOpportunityCountsRequest, CalculateDailyAdOpportunityCountsResponse> call);

        partial void OnConstruction(ForecastAdjustmentService.ForecastAdjustmentServiceClient grpcClient, ForecastAdjustmentServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ForecastAdjustmentService client</summary>
        public override ForecastAdjustmentService.ForecastAdjustmentServiceClient GrpcClient { get; }

        partial void Modify_GetForecastAdjustmentRequest(ref GetForecastAdjustmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListForecastAdjustmentsRequest(ref ListForecastAdjustmentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateForecastAdjustmentRequest(ref CreateForecastAdjustmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateForecastAdjustmentsRequest(ref BatchCreateForecastAdjustmentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchActivateForecastAdjustmentsRequest(ref BatchActivateForecastAdjustmentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchDeactivateForecastAdjustmentsRequest(ref BatchDeactivateForecastAdjustmentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateForecastAdjustmentRequest(ref UpdateForecastAdjustmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdateForecastAdjustmentsRequest(ref BatchUpdateForecastAdjustmentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CalculateDailyAdOpportunityCountsRequest(ref CalculateDailyAdOpportunityCountsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves a `ForecastAdjustment` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ForecastAdjustment GetForecastAdjustment(GetForecastAdjustmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetForecastAdjustmentRequest(ref request, ref callSettings);
            return _callGetForecastAdjustment.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a `ForecastAdjustment` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ForecastAdjustment> GetForecastAdjustmentAsync(GetForecastAdjustmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetForecastAdjustmentRequest(ref request, ref callSettings);
            return _callGetForecastAdjustment.Async(request, callSettings);
        }

        /// <summary>
        /// Lists `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ForecastAdjustment"/> resources.</returns>
        public override gax::PagedEnumerable<ListForecastAdjustmentsResponse, ForecastAdjustment> ListForecastAdjustments(ListForecastAdjustmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListForecastAdjustmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListForecastAdjustmentsRequest, ListForecastAdjustmentsResponse, ForecastAdjustment>(_callListForecastAdjustments, request, callSettings);
        }

        /// <summary>
        /// Lists `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ForecastAdjustment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListForecastAdjustmentsResponse, ForecastAdjustment> ListForecastAdjustmentsAsync(ListForecastAdjustmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListForecastAdjustmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListForecastAdjustmentsRequest, ListForecastAdjustmentsResponse, ForecastAdjustment>(_callListForecastAdjustments, request, callSettings);
        }

        /// <summary>
        /// Creates a `ForecastAdjustment` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ForecastAdjustment CreateForecastAdjustment(CreateForecastAdjustmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateForecastAdjustmentRequest(ref request, ref callSettings);
            return _callCreateForecastAdjustment.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a `ForecastAdjustment` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ForecastAdjustment> CreateForecastAdjustmentAsync(CreateForecastAdjustmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateForecastAdjustmentRequest(ref request, ref callSettings);
            return _callCreateForecastAdjustment.Async(request, callSettings);
        }

        /// <summary>
        /// Creates `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCreateForecastAdjustmentsResponse BatchCreateForecastAdjustments(BatchCreateForecastAdjustmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateForecastAdjustmentsRequest(ref request, ref callSettings);
            return _callBatchCreateForecastAdjustments.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCreateForecastAdjustmentsResponse> BatchCreateForecastAdjustmentsAsync(BatchCreateForecastAdjustmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateForecastAdjustmentsRequest(ref request, ref callSettings);
            return _callBatchCreateForecastAdjustments.Async(request, callSettings);
        }

        /// <summary>
        /// Activates a list of `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchActivateForecastAdjustmentsResponse BatchActivateForecastAdjustments(BatchActivateForecastAdjustmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchActivateForecastAdjustmentsRequest(ref request, ref callSettings);
            return _callBatchActivateForecastAdjustments.Sync(request, callSettings);
        }

        /// <summary>
        /// Activates a list of `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchActivateForecastAdjustmentsResponse> BatchActivateForecastAdjustmentsAsync(BatchActivateForecastAdjustmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchActivateForecastAdjustmentsRequest(ref request, ref callSettings);
            return _callBatchActivateForecastAdjustments.Async(request, callSettings);
        }

        /// <summary>
        /// Deactivates a list of `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchDeactivateForecastAdjustmentsResponse BatchDeactivateForecastAdjustments(BatchDeactivateForecastAdjustmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeactivateForecastAdjustmentsRequest(ref request, ref callSettings);
            return _callBatchDeactivateForecastAdjustments.Sync(request, callSettings);
        }

        /// <summary>
        /// Deactivates a list of `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchDeactivateForecastAdjustmentsResponse> BatchDeactivateForecastAdjustmentsAsync(BatchDeactivateForecastAdjustmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeactivateForecastAdjustmentsRequest(ref request, ref callSettings);
            return _callBatchDeactivateForecastAdjustments.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a `ForecastAdjustment` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ForecastAdjustment UpdateForecastAdjustment(UpdateForecastAdjustmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateForecastAdjustmentRequest(ref request, ref callSettings);
            return _callUpdateForecastAdjustment.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a `ForecastAdjustment` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ForecastAdjustment> UpdateForecastAdjustmentAsync(UpdateForecastAdjustmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateForecastAdjustmentRequest(ref request, ref callSettings);
            return _callUpdateForecastAdjustment.Async(request, callSettings);
        }

        /// <summary>
        /// Batch updates `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchUpdateForecastAdjustmentsResponse BatchUpdateForecastAdjustments(BatchUpdateForecastAdjustmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateForecastAdjustmentsRequest(ref request, ref callSettings);
            return _callBatchUpdateForecastAdjustments.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch updates `ForecastAdjustment` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchUpdateForecastAdjustmentsResponse> BatchUpdateForecastAdjustmentsAsync(BatchUpdateForecastAdjustmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateForecastAdjustmentsRequest(ref request, ref callSettings);
            return _callBatchUpdateForecastAdjustments.Async(request, callSettings);
        }

        /// <summary>
        /// Calculates daily ad opportunity counts for a prospective
        /// `ForecastAdjustment` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CalculateDailyAdOpportunityCountsResponse CalculateDailyAdOpportunityCounts(CalculateDailyAdOpportunityCountsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CalculateDailyAdOpportunityCountsRequest(ref request, ref callSettings);
            return _callCalculateDailyAdOpportunityCounts.Sync(request, callSettings);
        }

        /// <summary>
        /// Calculates daily ad opportunity counts for a prospective
        /// `ForecastAdjustment` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CalculateDailyAdOpportunityCountsResponse> CalculateDailyAdOpportunityCountsAsync(CalculateDailyAdOpportunityCountsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CalculateDailyAdOpportunityCountsRequest(ref request, ref callSettings);
            return _callCalculateDailyAdOpportunityCounts.Async(request, callSettings);
        }
    }

    public partial class ListForecastAdjustmentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListForecastAdjustmentsResponse : gaxgrpc::IPageResponse<ForecastAdjustment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ForecastAdjustment> GetEnumerator() => ForecastAdjustments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
