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

namespace Google.Shopping.Merchant.IssueResolution.V1Beta
{
    /// <summary>Settings for <see cref="IssueResolutionServiceClient"/> instances.</summary>
    public sealed partial class IssueResolutionServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="IssueResolutionServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="IssueResolutionServiceSettings"/>.</returns>
        public static IssueResolutionServiceSettings GetDefault() => new IssueResolutionServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="IssueResolutionServiceSettings"/> object with default settings.
        /// </summary>
        public IssueResolutionServiceSettings()
        {
        }

        private IssueResolutionServiceSettings(IssueResolutionServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            RenderAccountIssuesSettings = existing.RenderAccountIssuesSettings;
            RenderProductIssuesSettings = existing.RenderProductIssuesSettings;
            TriggerActionSettings = existing.TriggerActionSettings;
            OnCopy(existing);
        }

        partial void OnCopy(IssueResolutionServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IssueResolutionServiceClient.RenderAccountIssues</c> and
        /// <c>IssueResolutionServiceClient.RenderAccountIssuesAsync</c>.
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
        public gaxgrpc::CallSettings RenderAccountIssuesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IssueResolutionServiceClient.RenderProductIssues</c> and
        /// <c>IssueResolutionServiceClient.RenderProductIssuesAsync</c>.
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
        public gaxgrpc::CallSettings RenderProductIssuesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IssueResolutionServiceClient.TriggerAction</c> and <c>IssueResolutionServiceClient.TriggerActionAsync</c>
        /// .
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
        public gaxgrpc::CallSettings TriggerActionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="IssueResolutionServiceSettings"/> object.</returns>
        public IssueResolutionServiceSettings Clone() => new IssueResolutionServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="IssueResolutionServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class IssueResolutionServiceClientBuilder : gaxgrpc::ClientBuilderBase<IssueResolutionServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public IssueResolutionServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public IssueResolutionServiceClientBuilder() : base(IssueResolutionServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref IssueResolutionServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<IssueResolutionServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override IssueResolutionServiceClient Build()
        {
            IssueResolutionServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<IssueResolutionServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<IssueResolutionServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private IssueResolutionServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return IssueResolutionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<IssueResolutionServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return IssueResolutionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => IssueResolutionServiceClient.ChannelPool;
    }

    /// <summary>IssueResolutionService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to provide an issue resolution content for account issues and product
    /// issues.
    /// </remarks>
    public abstract partial class IssueResolutionServiceClient
    {
        /// <summary>
        /// The default endpoint for the IssueResolutionService service, which is a host of "merchantapi.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default IssueResolutionService scopes.</summary>
        /// <remarks>
        /// The default IssueResolutionService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(IssueResolutionService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="IssueResolutionServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="IssueResolutionServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="IssueResolutionServiceClient"/>.</returns>
        public static stt::Task<IssueResolutionServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new IssueResolutionServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="IssueResolutionServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="IssueResolutionServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="IssueResolutionServiceClient"/>.</returns>
        public static IssueResolutionServiceClient Create() => new IssueResolutionServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="IssueResolutionServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="IssueResolutionServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="IssueResolutionServiceClient"/>.</returns>
        internal static IssueResolutionServiceClient Create(grpccore::CallInvoker callInvoker, IssueResolutionServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            IssueResolutionService.IssueResolutionServiceClient grpcClient = new IssueResolutionService.IssueResolutionServiceClient(callInvoker);
            return new IssueResolutionServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC IssueResolutionService client</summary>
        public virtual IssueResolutionService.IssueResolutionServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Provide a list of business's account issues with an issue resolution
        /// content and available actions. This content and actions are meant to be
        /// rendered and shown in third-party applications.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RenderAccountIssuesResponse RenderAccountIssues(RenderAccountIssuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Provide a list of business's account issues with an issue resolution
        /// content and available actions. This content and actions are meant to be
        /// rendered and shown in third-party applications.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RenderAccountIssuesResponse> RenderAccountIssuesAsync(RenderAccountIssuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Provide a list of business's account issues with an issue resolution
        /// content and available actions. This content and actions are meant to be
        /// rendered and shown in third-party applications.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RenderAccountIssuesResponse> RenderAccountIssuesAsync(RenderAccountIssuesRequest request, st::CancellationToken cancellationToken) =>
            RenderAccountIssuesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Provide a list of business's account issues with an issue resolution
        /// content and available actions. This content and actions are meant to be
        /// rendered and shown in third-party applications.
        /// </summary>
        /// <param name="name">
        /// Required. The account to fetch issues for.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RenderAccountIssuesResponse RenderAccountIssues(string name, gaxgrpc::CallSettings callSettings = null) =>
            RenderAccountIssues(new RenderAccountIssuesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Provide a list of business's account issues with an issue resolution
        /// content and available actions. This content and actions are meant to be
        /// rendered and shown in third-party applications.
        /// </summary>
        /// <param name="name">
        /// Required. The account to fetch issues for.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RenderAccountIssuesResponse> RenderAccountIssuesAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            RenderAccountIssuesAsync(new RenderAccountIssuesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Provide a list of business's account issues with an issue resolution
        /// content and available actions. This content and actions are meant to be
        /// rendered and shown in third-party applications.
        /// </summary>
        /// <param name="name">
        /// Required. The account to fetch issues for.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RenderAccountIssuesResponse> RenderAccountIssuesAsync(string name, st::CancellationToken cancellationToken) =>
            RenderAccountIssuesAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Provide a list of business's account issues with an issue resolution
        /// content and available actions. This content and actions are meant to be
        /// rendered and shown in third-party applications.
        /// </summary>
        /// <param name="name">
        /// Required. The account to fetch issues for.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RenderAccountIssuesResponse RenderAccountIssues(AccountName name, gaxgrpc::CallSettings callSettings = null) =>
            RenderAccountIssues(new RenderAccountIssuesRequest
            {
                AccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Provide a list of business's account issues with an issue resolution
        /// content and available actions. This content and actions are meant to be
        /// rendered and shown in third-party applications.
        /// </summary>
        /// <param name="name">
        /// Required. The account to fetch issues for.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RenderAccountIssuesResponse> RenderAccountIssuesAsync(AccountName name, gaxgrpc::CallSettings callSettings = null) =>
            RenderAccountIssuesAsync(new RenderAccountIssuesRequest
            {
                AccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Provide a list of business's account issues with an issue resolution
        /// content and available actions. This content and actions are meant to be
        /// rendered and shown in third-party applications.
        /// </summary>
        /// <param name="name">
        /// Required. The account to fetch issues for.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RenderAccountIssuesResponse> RenderAccountIssuesAsync(AccountName name, st::CancellationToken cancellationToken) =>
            RenderAccountIssuesAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Provide a list of issues for business's product with an issue resolution
        /// content and available actions. This content and actions are meant to be
        /// rendered and shown in third-party applications.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RenderProductIssuesResponse RenderProductIssues(RenderProductIssuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Provide a list of issues for business's product with an issue resolution
        /// content and available actions. This content and actions are meant to be
        /// rendered and shown in third-party applications.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RenderProductIssuesResponse> RenderProductIssuesAsync(RenderProductIssuesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Provide a list of issues for business's product with an issue resolution
        /// content and available actions. This content and actions are meant to be
        /// rendered and shown in third-party applications.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RenderProductIssuesResponse> RenderProductIssuesAsync(RenderProductIssuesRequest request, st::CancellationToken cancellationToken) =>
            RenderProductIssuesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Provide a list of issues for business's product with an issue resolution
        /// content and available actions. This content and actions are meant to be
        /// rendered and shown in third-party applications.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the product to fetch issues for.
        /// Format: `accounts/{account}/products/{product}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RenderProductIssuesResponse RenderProductIssues(string name, gaxgrpc::CallSettings callSettings = null) =>
            RenderProductIssues(new RenderProductIssuesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Provide a list of issues for business's product with an issue resolution
        /// content and available actions. This content and actions are meant to be
        /// rendered and shown in third-party applications.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the product to fetch issues for.
        /// Format: `accounts/{account}/products/{product}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RenderProductIssuesResponse> RenderProductIssuesAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            RenderProductIssuesAsync(new RenderProductIssuesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Provide a list of issues for business's product with an issue resolution
        /// content and available actions. This content and actions are meant to be
        /// rendered and shown in third-party applications.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the product to fetch issues for.
        /// Format: `accounts/{account}/products/{product}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RenderProductIssuesResponse> RenderProductIssuesAsync(string name, st::CancellationToken cancellationToken) =>
            RenderProductIssuesAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Provide a list of issues for business's product with an issue resolution
        /// content and available actions. This content and actions are meant to be
        /// rendered and shown in third-party applications.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the product to fetch issues for.
        /// Format: `accounts/{account}/products/{product}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RenderProductIssuesResponse RenderProductIssues(ProductName name, gaxgrpc::CallSettings callSettings = null) =>
            RenderProductIssues(new RenderProductIssuesRequest
            {
                ProductName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Provide a list of issues for business's product with an issue resolution
        /// content and available actions. This content and actions are meant to be
        /// rendered and shown in third-party applications.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the product to fetch issues for.
        /// Format: `accounts/{account}/products/{product}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RenderProductIssuesResponse> RenderProductIssuesAsync(ProductName name, gaxgrpc::CallSettings callSettings = null) =>
            RenderProductIssuesAsync(new RenderProductIssuesRequest
            {
                ProductName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Provide a list of issues for business's product with an issue resolution
        /// content and available actions. This content and actions are meant to be
        /// rendered and shown in third-party applications.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the product to fetch issues for.
        /// Format: `accounts/{account}/products/{product}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RenderProductIssuesResponse> RenderProductIssuesAsync(ProductName name, st::CancellationToken cancellationToken) =>
            RenderProductIssuesAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Start an action. The action can be requested by a business in
        /// third-party application. Before the business can request the action, the
        /// third-party application needs to show them action specific content and
        /// display a user input form.
        /// 
        /// The action can be successfully started only once all `required` inputs are
        /// provided. If any `required` input is missing, or invalid value was
        /// provided, the service will return 400 error. Validation errors will contain
        /// [Ids][google.shopping.merchant.issueresolution.v1beta.InputField.id] for
        /// all problematic field together with translated, human readable error
        /// messages that can be shown to the user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TriggerActionResponse TriggerAction(TriggerActionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Start an action. The action can be requested by a business in
        /// third-party application. Before the business can request the action, the
        /// third-party application needs to show them action specific content and
        /// display a user input form.
        /// 
        /// The action can be successfully started only once all `required` inputs are
        /// provided. If any `required` input is missing, or invalid value was
        /// provided, the service will return 400 error. Validation errors will contain
        /// [Ids][google.shopping.merchant.issueresolution.v1beta.InputField.id] for
        /// all problematic field together with translated, human readable error
        /// messages that can be shown to the user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TriggerActionResponse> TriggerActionAsync(TriggerActionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Start an action. The action can be requested by a business in
        /// third-party application. Before the business can request the action, the
        /// third-party application needs to show them action specific content and
        /// display a user input form.
        /// 
        /// The action can be successfully started only once all `required` inputs are
        /// provided. If any `required` input is missing, or invalid value was
        /// provided, the service will return 400 error. Validation errors will contain
        /// [Ids][google.shopping.merchant.issueresolution.v1beta.InputField.id] for
        /// all problematic field together with translated, human readable error
        /// messages that can be shown to the user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TriggerActionResponse> TriggerActionAsync(TriggerActionRequest request, st::CancellationToken cancellationToken) =>
            TriggerActionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Start an action. The action can be requested by a business in
        /// third-party application. Before the business can request the action, the
        /// third-party application needs to show them action specific content and
        /// display a user input form.
        /// 
        /// The action can be successfully started only once all `required` inputs are
        /// provided. If any `required` input is missing, or invalid value was
        /// provided, the service will return 400 error. Validation errors will contain
        /// [Ids][google.shopping.merchant.issueresolution.v1beta.InputField.id] for
        /// all problematic field together with translated, human readable error
        /// messages that can be shown to the user.
        /// </summary>
        /// <param name="name">
        /// Required. The business's account that is triggering the action.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TriggerActionResponse TriggerAction(string name, gaxgrpc::CallSettings callSettings = null) =>
            TriggerAction(new TriggerActionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Start an action. The action can be requested by a business in
        /// third-party application. Before the business can request the action, the
        /// third-party application needs to show them action specific content and
        /// display a user input form.
        /// 
        /// The action can be successfully started only once all `required` inputs are
        /// provided. If any `required` input is missing, or invalid value was
        /// provided, the service will return 400 error. Validation errors will contain
        /// [Ids][google.shopping.merchant.issueresolution.v1beta.InputField.id] for
        /// all problematic field together with translated, human readable error
        /// messages that can be shown to the user.
        /// </summary>
        /// <param name="name">
        /// Required. The business's account that is triggering the action.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TriggerActionResponse> TriggerActionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            TriggerActionAsync(new TriggerActionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Start an action. The action can be requested by a business in
        /// third-party application. Before the business can request the action, the
        /// third-party application needs to show them action specific content and
        /// display a user input form.
        /// 
        /// The action can be successfully started only once all `required` inputs are
        /// provided. If any `required` input is missing, or invalid value was
        /// provided, the service will return 400 error. Validation errors will contain
        /// [Ids][google.shopping.merchant.issueresolution.v1beta.InputField.id] for
        /// all problematic field together with translated, human readable error
        /// messages that can be shown to the user.
        /// </summary>
        /// <param name="name">
        /// Required. The business's account that is triggering the action.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TriggerActionResponse> TriggerActionAsync(string name, st::CancellationToken cancellationToken) =>
            TriggerActionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Start an action. The action can be requested by a business in
        /// third-party application. Before the business can request the action, the
        /// third-party application needs to show them action specific content and
        /// display a user input form.
        /// 
        /// The action can be successfully started only once all `required` inputs are
        /// provided. If any `required` input is missing, or invalid value was
        /// provided, the service will return 400 error. Validation errors will contain
        /// [Ids][google.shopping.merchant.issueresolution.v1beta.InputField.id] for
        /// all problematic field together with translated, human readable error
        /// messages that can be shown to the user.
        /// </summary>
        /// <param name="name">
        /// Required. The business's account that is triggering the action.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TriggerActionResponse TriggerAction(AccountName name, gaxgrpc::CallSettings callSettings = null) =>
            TriggerAction(new TriggerActionRequest
            {
                AccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Start an action. The action can be requested by a business in
        /// third-party application. Before the business can request the action, the
        /// third-party application needs to show them action specific content and
        /// display a user input form.
        /// 
        /// The action can be successfully started only once all `required` inputs are
        /// provided. If any `required` input is missing, or invalid value was
        /// provided, the service will return 400 error. Validation errors will contain
        /// [Ids][google.shopping.merchant.issueresolution.v1beta.InputField.id] for
        /// all problematic field together with translated, human readable error
        /// messages that can be shown to the user.
        /// </summary>
        /// <param name="name">
        /// Required. The business's account that is triggering the action.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TriggerActionResponse> TriggerActionAsync(AccountName name, gaxgrpc::CallSettings callSettings = null) =>
            TriggerActionAsync(new TriggerActionRequest
            {
                AccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Start an action. The action can be requested by a business in
        /// third-party application. Before the business can request the action, the
        /// third-party application needs to show them action specific content and
        /// display a user input form.
        /// 
        /// The action can be successfully started only once all `required` inputs are
        /// provided. If any `required` input is missing, or invalid value was
        /// provided, the service will return 400 error. Validation errors will contain
        /// [Ids][google.shopping.merchant.issueresolution.v1beta.InputField.id] for
        /// all problematic field together with translated, human readable error
        /// messages that can be shown to the user.
        /// </summary>
        /// <param name="name">
        /// Required. The business's account that is triggering the action.
        /// Format: `accounts/{account}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TriggerActionResponse> TriggerActionAsync(AccountName name, st::CancellationToken cancellationToken) =>
            TriggerActionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>IssueResolutionService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to provide an issue resolution content for account issues and product
    /// issues.
    /// </remarks>
    public sealed partial class IssueResolutionServiceClientImpl : IssueResolutionServiceClient
    {
        private readonly gaxgrpc::ApiCall<RenderAccountIssuesRequest, RenderAccountIssuesResponse> _callRenderAccountIssues;

        private readonly gaxgrpc::ApiCall<RenderProductIssuesRequest, RenderProductIssuesResponse> _callRenderProductIssues;

        private readonly gaxgrpc::ApiCall<TriggerActionRequest, TriggerActionResponse> _callTriggerAction;

        /// <summary>
        /// Constructs a client wrapper for the IssueResolutionService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="IssueResolutionServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public IssueResolutionServiceClientImpl(IssueResolutionService.IssueResolutionServiceClient grpcClient, IssueResolutionServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            IssueResolutionServiceSettings effectiveSettings = settings ?? IssueResolutionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callRenderAccountIssues = clientHelper.BuildApiCall<RenderAccountIssuesRequest, RenderAccountIssuesResponse>("RenderAccountIssues", grpcClient.RenderAccountIssuesAsync, grpcClient.RenderAccountIssues, effectiveSettings.RenderAccountIssuesSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRenderAccountIssues);
            Modify_RenderAccountIssuesApiCall(ref _callRenderAccountIssues);
            _callRenderProductIssues = clientHelper.BuildApiCall<RenderProductIssuesRequest, RenderProductIssuesResponse>("RenderProductIssues", grpcClient.RenderProductIssuesAsync, grpcClient.RenderProductIssues, effectiveSettings.RenderProductIssuesSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRenderProductIssues);
            Modify_RenderProductIssuesApiCall(ref _callRenderProductIssues);
            _callTriggerAction = clientHelper.BuildApiCall<TriggerActionRequest, TriggerActionResponse>("TriggerAction", grpcClient.TriggerActionAsync, grpcClient.TriggerAction, effectiveSettings.TriggerActionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callTriggerAction);
            Modify_TriggerActionApiCall(ref _callTriggerAction);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_RenderAccountIssuesApiCall(ref gaxgrpc::ApiCall<RenderAccountIssuesRequest, RenderAccountIssuesResponse> call);

        partial void Modify_RenderProductIssuesApiCall(ref gaxgrpc::ApiCall<RenderProductIssuesRequest, RenderProductIssuesResponse> call);

        partial void Modify_TriggerActionApiCall(ref gaxgrpc::ApiCall<TriggerActionRequest, TriggerActionResponse> call);

        partial void OnConstruction(IssueResolutionService.IssueResolutionServiceClient grpcClient, IssueResolutionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC IssueResolutionService client</summary>
        public override IssueResolutionService.IssueResolutionServiceClient GrpcClient { get; }

        partial void Modify_RenderAccountIssuesRequest(ref RenderAccountIssuesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RenderProductIssuesRequest(ref RenderProductIssuesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TriggerActionRequest(ref TriggerActionRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Provide a list of business's account issues with an issue resolution
        /// content and available actions. This content and actions are meant to be
        /// rendered and shown in third-party applications.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RenderAccountIssuesResponse RenderAccountIssues(RenderAccountIssuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RenderAccountIssuesRequest(ref request, ref callSettings);
            return _callRenderAccountIssues.Sync(request, callSettings);
        }

        /// <summary>
        /// Provide a list of business's account issues with an issue resolution
        /// content and available actions. This content and actions are meant to be
        /// rendered and shown in third-party applications.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RenderAccountIssuesResponse> RenderAccountIssuesAsync(RenderAccountIssuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RenderAccountIssuesRequest(ref request, ref callSettings);
            return _callRenderAccountIssues.Async(request, callSettings);
        }

        /// <summary>
        /// Provide a list of issues for business's product with an issue resolution
        /// content and available actions. This content and actions are meant to be
        /// rendered and shown in third-party applications.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RenderProductIssuesResponse RenderProductIssues(RenderProductIssuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RenderProductIssuesRequest(ref request, ref callSettings);
            return _callRenderProductIssues.Sync(request, callSettings);
        }

        /// <summary>
        /// Provide a list of issues for business's product with an issue resolution
        /// content and available actions. This content and actions are meant to be
        /// rendered and shown in third-party applications.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RenderProductIssuesResponse> RenderProductIssuesAsync(RenderProductIssuesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RenderProductIssuesRequest(ref request, ref callSettings);
            return _callRenderProductIssues.Async(request, callSettings);
        }

        /// <summary>
        /// Start an action. The action can be requested by a business in
        /// third-party application. Before the business can request the action, the
        /// third-party application needs to show them action specific content and
        /// display a user input form.
        /// 
        /// The action can be successfully started only once all `required` inputs are
        /// provided. If any `required` input is missing, or invalid value was
        /// provided, the service will return 400 error. Validation errors will contain
        /// [Ids][google.shopping.merchant.issueresolution.v1beta.InputField.id] for
        /// all problematic field together with translated, human readable error
        /// messages that can be shown to the user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TriggerActionResponse TriggerAction(TriggerActionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TriggerActionRequest(ref request, ref callSettings);
            return _callTriggerAction.Sync(request, callSettings);
        }

        /// <summary>
        /// Start an action. The action can be requested by a business in
        /// third-party application. Before the business can request the action, the
        /// third-party application needs to show them action specific content and
        /// display a user input form.
        /// 
        /// The action can be successfully started only once all `required` inputs are
        /// provided. If any `required` input is missing, or invalid value was
        /// provided, the service will return 400 error. Validation errors will contain
        /// [Ids][google.shopping.merchant.issueresolution.v1beta.InputField.id] for
        /// all problematic field together with translated, human readable error
        /// messages that can be shown to the user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TriggerActionResponse> TriggerActionAsync(TriggerActionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TriggerActionRequest(ref request, ref callSettings);
            return _callTriggerAction.Async(request, callSettings);
        }
    }
}
