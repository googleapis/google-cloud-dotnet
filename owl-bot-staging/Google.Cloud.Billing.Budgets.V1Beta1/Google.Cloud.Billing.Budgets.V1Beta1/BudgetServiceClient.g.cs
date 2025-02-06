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

namespace Google.Cloud.Billing.Budgets.V1Beta1
{
    /// <summary>Settings for <see cref="BudgetServiceClient"/> instances.</summary>
    public sealed partial class BudgetServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BudgetServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BudgetServiceSettings"/>.</returns>
        public static BudgetServiceSettings GetDefault() => new BudgetServiceSettings();

        /// <summary>Constructs a new <see cref="BudgetServiceSettings"/> object with default settings.</summary>
        public BudgetServiceSettings()
        {
        }

        private BudgetServiceSettings(BudgetServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateBudgetSettings = existing.CreateBudgetSettings;
            UpdateBudgetSettings = existing.UpdateBudgetSettings;
            GetBudgetSettings = existing.GetBudgetSettings;
            ListBudgetsSettings = existing.ListBudgetsSettings;
            DeleteBudgetSettings = existing.DeleteBudgetSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BudgetServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BudgetServiceClient.CreateBudget</c> and <c>BudgetServiceClient.CreateBudgetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateBudgetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BudgetServiceClient.UpdateBudget</c> and <c>BudgetServiceClient.UpdateBudgetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateBudgetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BudgetServiceClient.GetBudget</c> and <c>BudgetServiceClient.GetBudgetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetBudgetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BudgetServiceClient.ListBudgets</c> and <c>BudgetServiceClient.ListBudgetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListBudgetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BudgetServiceClient.DeleteBudget</c> and <c>BudgetServiceClient.DeleteBudgetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteBudgetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BudgetServiceSettings"/> object.</returns>
        public BudgetServiceSettings Clone() => new BudgetServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BudgetServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class BudgetServiceClientBuilder : gaxgrpc::ClientBuilderBase<BudgetServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BudgetServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public BudgetServiceClientBuilder() : base(BudgetServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref BudgetServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<BudgetServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override BudgetServiceClient Build()
        {
            BudgetServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<BudgetServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<BudgetServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private BudgetServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BudgetServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<BudgetServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BudgetServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BudgetServiceClient.ChannelPool;
    }

    /// <summary>BudgetService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// BudgetService stores Cloud Billing budgets, which define a
    /// budget plan and rules to execute as we track spend against that plan.
    /// </remarks>
    public abstract partial class BudgetServiceClient
    {
        /// <summary>
        /// The default endpoint for the BudgetService service, which is a host of "billingbudgets.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "billingbudgets.googleapis.com:443";

        /// <summary>The default BudgetService scopes.</summary>
        /// <remarks>
        /// The default BudgetService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-billing</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-billing",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(BudgetService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="BudgetServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="BudgetServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="BudgetServiceClient"/>.</returns>
        public static stt::Task<BudgetServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new BudgetServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="BudgetServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="BudgetServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="BudgetServiceClient"/>.</returns>
        public static BudgetServiceClient Create() => new BudgetServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="BudgetServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BudgetServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="BudgetServiceClient"/>.</returns>
        internal static BudgetServiceClient Create(grpccore::CallInvoker callInvoker, BudgetServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BudgetService.BudgetServiceClient grpcClient = new BudgetService.BudgetServiceClient(callInvoker);
            return new BudgetServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC BudgetService client</summary>
        public virtual BudgetService.BudgetServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new budget. See
        /// [Quotas and limits](https://cloud.google.com/billing/quotas)
        /// for more information on the limits of the number of budgets you can create.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Budget CreateBudget(CreateBudgetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new budget. See
        /// [Quotas and limits](https://cloud.google.com/billing/quotas)
        /// for more information on the limits of the number of budgets you can create.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Budget> CreateBudgetAsync(CreateBudgetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new budget. See
        /// [Quotas and limits](https://cloud.google.com/billing/quotas)
        /// for more information on the limits of the number of budgets you can create.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Budget> CreateBudgetAsync(CreateBudgetRequest request, st::CancellationToken cancellationToken) =>
            CreateBudgetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a budget and returns the updated budget.
        /// 
        /// WARNING: There are some fields exposed on the Google Cloud Console that
        /// aren't available on this API. Budget fields that are not exposed in
        /// this API will not be changed by this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Budget UpdateBudget(UpdateBudgetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a budget and returns the updated budget.
        /// 
        /// WARNING: There are some fields exposed on the Google Cloud Console that
        /// aren't available on this API. Budget fields that are not exposed in
        /// this API will not be changed by this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Budget> UpdateBudgetAsync(UpdateBudgetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a budget and returns the updated budget.
        /// 
        /// WARNING: There are some fields exposed on the Google Cloud Console that
        /// aren't available on this API. Budget fields that are not exposed in
        /// this API will not be changed by this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Budget> UpdateBudgetAsync(UpdateBudgetRequest request, st::CancellationToken cancellationToken) =>
            UpdateBudgetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a budget.
        /// 
        /// WARNING: There are some fields exposed on the Google Cloud Console that
        /// aren't available on this API. When reading from the API, you will not
        /// see these fields in the return value, though they may have been set
        /// in the Cloud Console.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Budget GetBudget(GetBudgetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a budget.
        /// 
        /// WARNING: There are some fields exposed on the Google Cloud Console that
        /// aren't available on this API. When reading from the API, you will not
        /// see these fields in the return value, though they may have been set
        /// in the Cloud Console.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Budget> GetBudgetAsync(GetBudgetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a budget.
        /// 
        /// WARNING: There are some fields exposed on the Google Cloud Console that
        /// aren't available on this API. When reading from the API, you will not
        /// see these fields in the return value, though they may have been set
        /// in the Cloud Console.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Budget> GetBudgetAsync(GetBudgetRequest request, st::CancellationToken cancellationToken) =>
            GetBudgetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of budgets for a billing account.
        /// 
        /// WARNING: There are some fields exposed on the Google Cloud Console that
        /// aren't available on this API. When reading from the API, you will not
        /// see these fields in the return value, though they may have been set
        /// in the Cloud Console.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Budget"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBudgetsResponse, Budget> ListBudgets(ListBudgetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of budgets for a billing account.
        /// 
        /// WARNING: There are some fields exposed on the Google Cloud Console that
        /// aren't available on this API. When reading from the API, you will not
        /// see these fields in the return value, though they may have been set
        /// in the Cloud Console.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Budget"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBudgetsResponse, Budget> ListBudgetsAsync(ListBudgetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a budget. Returns successfully if already deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteBudget(DeleteBudgetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a budget. Returns successfully if already deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBudgetAsync(DeleteBudgetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a budget. Returns successfully if already deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBudgetAsync(DeleteBudgetRequest request, st::CancellationToken cancellationToken) =>
            DeleteBudgetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>BudgetService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// BudgetService stores Cloud Billing budgets, which define a
    /// budget plan and rules to execute as we track spend against that plan.
    /// </remarks>
    public sealed partial class BudgetServiceClientImpl : BudgetServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateBudgetRequest, Budget> _callCreateBudget;

        private readonly gaxgrpc::ApiCall<UpdateBudgetRequest, Budget> _callUpdateBudget;

        private readonly gaxgrpc::ApiCall<GetBudgetRequest, Budget> _callGetBudget;

        private readonly gaxgrpc::ApiCall<ListBudgetsRequest, ListBudgetsResponse> _callListBudgets;

        private readonly gaxgrpc::ApiCall<DeleteBudgetRequest, wkt::Empty> _callDeleteBudget;

        /// <summary>
        /// Constructs a client wrapper for the BudgetService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="BudgetServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public BudgetServiceClientImpl(BudgetService.BudgetServiceClient grpcClient, BudgetServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            BudgetServiceSettings effectiveSettings = settings ?? BudgetServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCreateBudget = clientHelper.BuildApiCall<CreateBudgetRequest, Budget>("CreateBudget", grpcClient.CreateBudgetAsync, grpcClient.CreateBudget, effectiveSettings.CreateBudgetSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateBudget);
            Modify_CreateBudgetApiCall(ref _callCreateBudget);
            _callUpdateBudget = clientHelper.BuildApiCall<UpdateBudgetRequest, Budget>("UpdateBudget", grpcClient.UpdateBudgetAsync, grpcClient.UpdateBudget, effectiveSettings.UpdateBudgetSettings).WithGoogleRequestParam("budget.name", request => request.Budget?.Name);
            Modify_ApiCall(ref _callUpdateBudget);
            Modify_UpdateBudgetApiCall(ref _callUpdateBudget);
            _callGetBudget = clientHelper.BuildApiCall<GetBudgetRequest, Budget>("GetBudget", grpcClient.GetBudgetAsync, grpcClient.GetBudget, effectiveSettings.GetBudgetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetBudget);
            Modify_GetBudgetApiCall(ref _callGetBudget);
            _callListBudgets = clientHelper.BuildApiCall<ListBudgetsRequest, ListBudgetsResponse>("ListBudgets", grpcClient.ListBudgetsAsync, grpcClient.ListBudgets, effectiveSettings.ListBudgetsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListBudgets);
            Modify_ListBudgetsApiCall(ref _callListBudgets);
            _callDeleteBudget = clientHelper.BuildApiCall<DeleteBudgetRequest, wkt::Empty>("DeleteBudget", grpcClient.DeleteBudgetAsync, grpcClient.DeleteBudget, effectiveSettings.DeleteBudgetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteBudget);
            Modify_DeleteBudgetApiCall(ref _callDeleteBudget);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateBudgetApiCall(ref gaxgrpc::ApiCall<CreateBudgetRequest, Budget> call);

        partial void Modify_UpdateBudgetApiCall(ref gaxgrpc::ApiCall<UpdateBudgetRequest, Budget> call);

        partial void Modify_GetBudgetApiCall(ref gaxgrpc::ApiCall<GetBudgetRequest, Budget> call);

        partial void Modify_ListBudgetsApiCall(ref gaxgrpc::ApiCall<ListBudgetsRequest, ListBudgetsResponse> call);

        partial void Modify_DeleteBudgetApiCall(ref gaxgrpc::ApiCall<DeleteBudgetRequest, wkt::Empty> call);

        partial void OnConstruction(BudgetService.BudgetServiceClient grpcClient, BudgetServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC BudgetService client</summary>
        public override BudgetService.BudgetServiceClient GrpcClient { get; }

        partial void Modify_CreateBudgetRequest(ref CreateBudgetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateBudgetRequest(ref UpdateBudgetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBudgetRequest(ref GetBudgetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBudgetsRequest(ref ListBudgetsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteBudgetRequest(ref DeleteBudgetRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a new budget. See
        /// [Quotas and limits](https://cloud.google.com/billing/quotas)
        /// for more information on the limits of the number of budgets you can create.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Budget CreateBudget(CreateBudgetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBudgetRequest(ref request, ref callSettings);
            return _callCreateBudget.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new budget. See
        /// [Quotas and limits](https://cloud.google.com/billing/quotas)
        /// for more information on the limits of the number of budgets you can create.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Budget> CreateBudgetAsync(CreateBudgetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBudgetRequest(ref request, ref callSettings);
            return _callCreateBudget.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a budget and returns the updated budget.
        /// 
        /// WARNING: There are some fields exposed on the Google Cloud Console that
        /// aren't available on this API. Budget fields that are not exposed in
        /// this API will not be changed by this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Budget UpdateBudget(UpdateBudgetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBudgetRequest(ref request, ref callSettings);
            return _callUpdateBudget.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a budget and returns the updated budget.
        /// 
        /// WARNING: There are some fields exposed on the Google Cloud Console that
        /// aren't available on this API. Budget fields that are not exposed in
        /// this API will not be changed by this method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Budget> UpdateBudgetAsync(UpdateBudgetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBudgetRequest(ref request, ref callSettings);
            return _callUpdateBudget.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a budget.
        /// 
        /// WARNING: There are some fields exposed on the Google Cloud Console that
        /// aren't available on this API. When reading from the API, you will not
        /// see these fields in the return value, though they may have been set
        /// in the Cloud Console.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Budget GetBudget(GetBudgetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBudgetRequest(ref request, ref callSettings);
            return _callGetBudget.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a budget.
        /// 
        /// WARNING: There are some fields exposed on the Google Cloud Console that
        /// aren't available on this API. When reading from the API, you will not
        /// see these fields in the return value, though they may have been set
        /// in the Cloud Console.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Budget> GetBudgetAsync(GetBudgetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBudgetRequest(ref request, ref callSettings);
            return _callGetBudget.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a list of budgets for a billing account.
        /// 
        /// WARNING: There are some fields exposed on the Google Cloud Console that
        /// aren't available on this API. When reading from the API, you will not
        /// see these fields in the return value, though they may have been set
        /// in the Cloud Console.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Budget"/> resources.</returns>
        public override gax::PagedEnumerable<ListBudgetsResponse, Budget> ListBudgets(ListBudgetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBudgetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListBudgetsRequest, ListBudgetsResponse, Budget>(_callListBudgets, request, callSettings);
        }

        /// <summary>
        /// Returns a list of budgets for a billing account.
        /// 
        /// WARNING: There are some fields exposed on the Google Cloud Console that
        /// aren't available on this API. When reading from the API, you will not
        /// see these fields in the return value, though they may have been set
        /// in the Cloud Console.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Budget"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBudgetsResponse, Budget> ListBudgetsAsync(ListBudgetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBudgetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBudgetsRequest, ListBudgetsResponse, Budget>(_callListBudgets, request, callSettings);
        }

        /// <summary>
        /// Deletes a budget. Returns successfully if already deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteBudget(DeleteBudgetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBudgetRequest(ref request, ref callSettings);
            _callDeleteBudget.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a budget. Returns successfully if already deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteBudgetAsync(DeleteBudgetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBudgetRequest(ref request, ref callSettings);
            return _callDeleteBudget.Async(request, callSettings);
        }
    }

    public partial class ListBudgetsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBudgetsResponse : gaxgrpc::IPageResponse<Budget>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Budget> GetEnumerator() => Budgets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
