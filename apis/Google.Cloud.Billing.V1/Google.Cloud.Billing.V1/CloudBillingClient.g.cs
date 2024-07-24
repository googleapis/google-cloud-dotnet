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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gciv = Google.Cloud.Iam.V1;
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

namespace Google.Cloud.Billing.V1
{
    /// <summary>Settings for <see cref="CloudBillingClient"/> instances.</summary>
    public sealed partial class CloudBillingSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CloudBillingSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CloudBillingSettings"/>.</returns>
        public static CloudBillingSettings GetDefault() => new CloudBillingSettings();

        /// <summary>Constructs a new <see cref="CloudBillingSettings"/> object with default settings.</summary>
        public CloudBillingSettings()
        {
        }

        private CloudBillingSettings(CloudBillingSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetBillingAccountSettings = existing.GetBillingAccountSettings;
            ListBillingAccountsSettings = existing.ListBillingAccountsSettings;
            UpdateBillingAccountSettings = existing.UpdateBillingAccountSettings;
            CreateBillingAccountSettings = existing.CreateBillingAccountSettings;
            ListProjectBillingInfoSettings = existing.ListProjectBillingInfoSettings;
            GetProjectBillingInfoSettings = existing.GetProjectBillingInfoSettings;
            UpdateProjectBillingInfoSettings = existing.UpdateProjectBillingInfoSettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            MoveBillingAccountSettings = existing.MoveBillingAccountSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CloudBillingSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudBillingClient.GetBillingAccount</c> and <c>CloudBillingClient.GetBillingAccountAsync</c>.
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
        public gaxgrpc::CallSettings GetBillingAccountSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudBillingClient.ListBillingAccounts</c> and <c>CloudBillingClient.ListBillingAccountsAsync</c>.
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
        public gaxgrpc::CallSettings ListBillingAccountsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudBillingClient.UpdateBillingAccount</c> and <c>CloudBillingClient.UpdateBillingAccountAsync</c>.
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
        public gaxgrpc::CallSettings UpdateBillingAccountSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudBillingClient.CreateBillingAccount</c> and <c>CloudBillingClient.CreateBillingAccountAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateBillingAccountSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudBillingClient.ListProjectBillingInfo</c> and <c>CloudBillingClient.ListProjectBillingInfoAsync</c>.
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
        public gaxgrpc::CallSettings ListProjectBillingInfoSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudBillingClient.GetProjectBillingInfo</c> and <c>CloudBillingClient.GetProjectBillingInfoAsync</c>.
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
        public gaxgrpc::CallSettings GetProjectBillingInfoSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudBillingClient.UpdateProjectBillingInfo</c> and <c>CloudBillingClient.UpdateProjectBillingInfoAsync</c>
        /// .
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
        public gaxgrpc::CallSettings UpdateProjectBillingInfoSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudBillingClient.GetIamPolicy</c> and <c>CloudBillingClient.GetIamPolicyAsync</c>.
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
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudBillingClient.SetIamPolicy</c> and <c>CloudBillingClient.SetIamPolicyAsync</c>.
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
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudBillingClient.TestIamPermissions</c> and <c>CloudBillingClient.TestIamPermissionsAsync</c>.
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
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudBillingClient.MoveBillingAccount</c> and <c>CloudBillingClient.MoveBillingAccountAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MoveBillingAccountSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CloudBillingSettings"/> object.</returns>
        public CloudBillingSettings Clone() => new CloudBillingSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CloudBillingClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class CloudBillingClientBuilder : gaxgrpc::ClientBuilderBase<CloudBillingClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CloudBillingSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CloudBillingClientBuilder() : base(CloudBillingClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CloudBillingClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CloudBillingClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CloudBillingClient Build()
        {
            CloudBillingClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CloudBillingClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CloudBillingClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CloudBillingClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CloudBillingClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CloudBillingClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CloudBillingClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CloudBillingClient.ChannelPool;
    }

    /// <summary>CloudBilling client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Retrieves the Google Cloud Console billing accounts and associates them with
    /// projects.
    /// </remarks>
    public abstract partial class CloudBillingClient
    {
        /// <summary>
        /// The default endpoint for the CloudBilling service, which is a host of "cloudbilling.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudbilling.googleapis.com:443";

        /// <summary>The default CloudBilling scopes.</summary>
        /// <remarks>
        /// The default CloudBilling scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-billing</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-billing.readonly</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-billing",
            "https://www.googleapis.com/auth/cloud-billing.readonly",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CloudBilling.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CloudBillingClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CloudBillingClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CloudBillingClient"/>.</returns>
        public static stt::Task<CloudBillingClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CloudBillingClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CloudBillingClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CloudBillingClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CloudBillingClient"/>.</returns>
        public static CloudBillingClient Create() => new CloudBillingClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CloudBillingClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CloudBillingSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CloudBillingClient"/>.</returns>
        internal static CloudBillingClient Create(grpccore::CallInvoker callInvoker, CloudBillingSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CloudBilling.CloudBillingClient grpcClient = new CloudBilling.CloudBillingClient(callInvoker);
            return new CloudBillingClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CloudBilling client</summary>
        public virtual CloudBilling.CloudBillingClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a billing account. The current authenticated user
        /// must be a [viewer of the billing
        /// account](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BillingAccount GetBillingAccount(GetBillingAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a billing account. The current authenticated user
        /// must be a [viewer of the billing
        /// account](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BillingAccount> GetBillingAccountAsync(GetBillingAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a billing account. The current authenticated user
        /// must be a [viewer of the billing
        /// account](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BillingAccount> GetBillingAccountAsync(GetBillingAccountRequest request, st::CancellationToken cancellationToken) =>
            GetBillingAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a billing account. The current authenticated user
        /// must be a [viewer of the billing
        /// account](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the billing account to retrieve. For
        /// example, `billingAccounts/012345-567890-ABCDEF`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BillingAccount GetBillingAccount(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBillingAccount(new GetBillingAccountRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a billing account. The current authenticated user
        /// must be a [viewer of the billing
        /// account](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the billing account to retrieve. For
        /// example, `billingAccounts/012345-567890-ABCDEF`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BillingAccount> GetBillingAccountAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBillingAccountAsync(new GetBillingAccountRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a billing account. The current authenticated user
        /// must be a [viewer of the billing
        /// account](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the billing account to retrieve. For
        /// example, `billingAccounts/012345-567890-ABCDEF`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BillingAccount> GetBillingAccountAsync(string name, st::CancellationToken cancellationToken) =>
            GetBillingAccountAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a billing account. The current authenticated user
        /// must be a [viewer of the billing
        /// account](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the billing account to retrieve. For
        /// example, `billingAccounts/012345-567890-ABCDEF`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BillingAccount GetBillingAccount(gagr::BillingAccountName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBillingAccount(new GetBillingAccountRequest
            {
                BillingAccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a billing account. The current authenticated user
        /// must be a [viewer of the billing
        /// account](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the billing account to retrieve. For
        /// example, `billingAccounts/012345-567890-ABCDEF`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BillingAccount> GetBillingAccountAsync(gagr::BillingAccountName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBillingAccountAsync(new GetBillingAccountRequest
            {
                BillingAccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a billing account. The current authenticated user
        /// must be a [viewer of the billing
        /// account](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the billing account to retrieve. For
        /// example, `billingAccounts/012345-567890-ABCDEF`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BillingAccount> GetBillingAccountAsync(gagr::BillingAccountName name, st::CancellationToken cancellationToken) =>
            GetBillingAccountAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the billing accounts that the current authenticated user has
        /// permission to
        /// [view](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BillingAccount"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBillingAccountsResponse, BillingAccount> ListBillingAccounts(ListBillingAccountsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the billing accounts that the current authenticated user has
        /// permission to
        /// [view](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BillingAccount"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBillingAccountsResponse, BillingAccount> ListBillingAccountsAsync(ListBillingAccountsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the billing accounts that the current authenticated user has
        /// permission to
        /// [view](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BillingAccount"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBillingAccountsResponse, BillingAccount> ListBillingAccounts(string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBillingAccountsRequest request = new ListBillingAccountsRequest { };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListBillingAccounts(request, callSettings);
        }

        /// <summary>
        /// Lists the billing accounts that the current authenticated user has
        /// permission to
        /// [view](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BillingAccount"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBillingAccountsResponse, BillingAccount> ListBillingAccountsAsync(string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBillingAccountsRequest request = new ListBillingAccountsRequest { };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListBillingAccountsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the billing accounts that the current authenticated user has
        /// permission to
        /// [view](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="parent">
        /// Optional. The parent resource to list billing accounts from.
        /// Format:
        /// - `organizations/{organization_id}`, for example,
        /// `organizations/12345678`
        /// - `billingAccounts/{billing_account_id}`, for example,
        /// `billingAccounts/012345-567890-ABCDEF`
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
        /// <returns>A pageable sequence of <see cref="BillingAccount"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBillingAccountsResponse, BillingAccount> ListBillingAccounts(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBillingAccountsRequest request = new ListBillingAccountsRequest { Parent = parent ?? "", };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListBillingAccounts(request, callSettings);
        }

        /// <summary>
        /// Lists the billing accounts that the current authenticated user has
        /// permission to
        /// [view](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="parent">
        /// Optional. The parent resource to list billing accounts from.
        /// Format:
        /// - `organizations/{organization_id}`, for example,
        /// `organizations/12345678`
        /// - `billingAccounts/{billing_account_id}`, for example,
        /// `billingAccounts/012345-567890-ABCDEF`
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
        /// <returns>A pageable asynchronous sequence of <see cref="BillingAccount"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBillingAccountsResponse, BillingAccount> ListBillingAccountsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBillingAccountsRequest request = new ListBillingAccountsRequest { Parent = parent ?? "", };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListBillingAccountsAsync(request, callSettings);
        }

        /// <summary>
        /// Updates a billing account's fields.
        /// Currently the only field that can be edited is `display_name`.
        /// The current authenticated user must have the `billing.accounts.update`
        /// IAM permission, which is typically given to the
        /// [administrator](https://cloud.google.com/billing/docs/how-to/billing-access)
        /// of the billing account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BillingAccount UpdateBillingAccount(UpdateBillingAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a billing account's fields.
        /// Currently the only field that can be edited is `display_name`.
        /// The current authenticated user must have the `billing.accounts.update`
        /// IAM permission, which is typically given to the
        /// [administrator](https://cloud.google.com/billing/docs/how-to/billing-access)
        /// of the billing account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BillingAccount> UpdateBillingAccountAsync(UpdateBillingAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a billing account's fields.
        /// Currently the only field that can be edited is `display_name`.
        /// The current authenticated user must have the `billing.accounts.update`
        /// IAM permission, which is typically given to the
        /// [administrator](https://cloud.google.com/billing/docs/how-to/billing-access)
        /// of the billing account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BillingAccount> UpdateBillingAccountAsync(UpdateBillingAccountRequest request, st::CancellationToken cancellationToken) =>
            UpdateBillingAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a billing account's fields.
        /// Currently the only field that can be edited is `display_name`.
        /// The current authenticated user must have the `billing.accounts.update`
        /// IAM permission, which is typically given to the
        /// [administrator](https://cloud.google.com/billing/docs/how-to/billing-access)
        /// of the billing account.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the billing account resource to be updated.
        /// </param>
        /// <param name="account">
        /// Required. The billing account resource to replace the resource on the
        /// server.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BillingAccount UpdateBillingAccount(string name, BillingAccount account, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBillingAccount(new UpdateBillingAccountRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Account = gax::GaxPreconditions.CheckNotNull(account, nameof(account)),
            }, callSettings);

        /// <summary>
        /// Updates a billing account's fields.
        /// Currently the only field that can be edited is `display_name`.
        /// The current authenticated user must have the `billing.accounts.update`
        /// IAM permission, which is typically given to the
        /// [administrator](https://cloud.google.com/billing/docs/how-to/billing-access)
        /// of the billing account.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the billing account resource to be updated.
        /// </param>
        /// <param name="account">
        /// Required. The billing account resource to replace the resource on the
        /// server.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BillingAccount> UpdateBillingAccountAsync(string name, BillingAccount account, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBillingAccountAsync(new UpdateBillingAccountRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Account = gax::GaxPreconditions.CheckNotNull(account, nameof(account)),
            }, callSettings);

        /// <summary>
        /// Updates a billing account's fields.
        /// Currently the only field that can be edited is `display_name`.
        /// The current authenticated user must have the `billing.accounts.update`
        /// IAM permission, which is typically given to the
        /// [administrator](https://cloud.google.com/billing/docs/how-to/billing-access)
        /// of the billing account.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the billing account resource to be updated.
        /// </param>
        /// <param name="account">
        /// Required. The billing account resource to replace the resource on the
        /// server.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BillingAccount> UpdateBillingAccountAsync(string name, BillingAccount account, st::CancellationToken cancellationToken) =>
            UpdateBillingAccountAsync(name, account, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a billing account's fields.
        /// Currently the only field that can be edited is `display_name`.
        /// The current authenticated user must have the `billing.accounts.update`
        /// IAM permission, which is typically given to the
        /// [administrator](https://cloud.google.com/billing/docs/how-to/billing-access)
        /// of the billing account.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the billing account resource to be updated.
        /// </param>
        /// <param name="account">
        /// Required. The billing account resource to replace the resource on the
        /// server.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BillingAccount UpdateBillingAccount(gagr::BillingAccountName name, BillingAccount account, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBillingAccount(new UpdateBillingAccountRequest
            {
                BillingAccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Account = gax::GaxPreconditions.CheckNotNull(account, nameof(account)),
            }, callSettings);

        /// <summary>
        /// Updates a billing account's fields.
        /// Currently the only field that can be edited is `display_name`.
        /// The current authenticated user must have the `billing.accounts.update`
        /// IAM permission, which is typically given to the
        /// [administrator](https://cloud.google.com/billing/docs/how-to/billing-access)
        /// of the billing account.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the billing account resource to be updated.
        /// </param>
        /// <param name="account">
        /// Required. The billing account resource to replace the resource on the
        /// server.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BillingAccount> UpdateBillingAccountAsync(gagr::BillingAccountName name, BillingAccount account, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBillingAccountAsync(new UpdateBillingAccountRequest
            {
                BillingAccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Account = gax::GaxPreconditions.CheckNotNull(account, nameof(account)),
            }, callSettings);

        /// <summary>
        /// Updates a billing account's fields.
        /// Currently the only field that can be edited is `display_name`.
        /// The current authenticated user must have the `billing.accounts.update`
        /// IAM permission, which is typically given to the
        /// [administrator](https://cloud.google.com/billing/docs/how-to/billing-access)
        /// of the billing account.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the billing account resource to be updated.
        /// </param>
        /// <param name="account">
        /// Required. The billing account resource to replace the resource on the
        /// server.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BillingAccount> UpdateBillingAccountAsync(gagr::BillingAccountName name, BillingAccount account, st::CancellationToken cancellationToken) =>
            UpdateBillingAccountAsync(name, account, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// This method creates [billing
        /// subaccounts](https://cloud.google.com/billing/docs/concepts#subaccounts).
        /// 
        /// Google Cloud resellers should use the
        /// Channel Services APIs,
        /// [accounts.customers.create](https://cloud.google.com/channel/docs/reference/rest/v1/accounts.customers/create)
        /// and
        /// [accounts.customers.entitlements.create](https://cloud.google.com/channel/docs/reference/rest/v1/accounts.customers.entitlements/create).
        /// 
        /// When creating a subaccount, the current authenticated user must have the
        /// `billing.accounts.update` IAM permission on the parent account, which is
        /// typically given to billing account
        /// [administrators](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// This method will return an error if the parent account has not been
        /// provisioned for subaccounts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BillingAccount CreateBillingAccount(CreateBillingAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// This method creates [billing
        /// subaccounts](https://cloud.google.com/billing/docs/concepts#subaccounts).
        /// 
        /// Google Cloud resellers should use the
        /// Channel Services APIs,
        /// [accounts.customers.create](https://cloud.google.com/channel/docs/reference/rest/v1/accounts.customers/create)
        /// and
        /// [accounts.customers.entitlements.create](https://cloud.google.com/channel/docs/reference/rest/v1/accounts.customers.entitlements/create).
        /// 
        /// When creating a subaccount, the current authenticated user must have the
        /// `billing.accounts.update` IAM permission on the parent account, which is
        /// typically given to billing account
        /// [administrators](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// This method will return an error if the parent account has not been
        /// provisioned for subaccounts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BillingAccount> CreateBillingAccountAsync(CreateBillingAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// This method creates [billing
        /// subaccounts](https://cloud.google.com/billing/docs/concepts#subaccounts).
        /// 
        /// Google Cloud resellers should use the
        /// Channel Services APIs,
        /// [accounts.customers.create](https://cloud.google.com/channel/docs/reference/rest/v1/accounts.customers/create)
        /// and
        /// [accounts.customers.entitlements.create](https://cloud.google.com/channel/docs/reference/rest/v1/accounts.customers.entitlements/create).
        /// 
        /// When creating a subaccount, the current authenticated user must have the
        /// `billing.accounts.update` IAM permission on the parent account, which is
        /// typically given to billing account
        /// [administrators](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// This method will return an error if the parent account has not been
        /// provisioned for subaccounts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BillingAccount> CreateBillingAccountAsync(CreateBillingAccountRequest request, st::CancellationToken cancellationToken) =>
            CreateBillingAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// This method creates [billing
        /// subaccounts](https://cloud.google.com/billing/docs/concepts#subaccounts).
        /// 
        /// Google Cloud resellers should use the
        /// Channel Services APIs,
        /// [accounts.customers.create](https://cloud.google.com/channel/docs/reference/rest/v1/accounts.customers/create)
        /// and
        /// [accounts.customers.entitlements.create](https://cloud.google.com/channel/docs/reference/rest/v1/accounts.customers.entitlements/create).
        /// 
        /// When creating a subaccount, the current authenticated user must have the
        /// `billing.accounts.update` IAM permission on the parent account, which is
        /// typically given to billing account
        /// [administrators](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// This method will return an error if the parent account has not been
        /// provisioned for subaccounts.
        /// </summary>
        /// <param name="billingAccount">
        /// Required. The billing account resource to create.
        /// Currently CreateBillingAccount only supports subaccount creation, so
        /// any created billing accounts must be under a provided parent billing
        /// account.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BillingAccount CreateBillingAccount(BillingAccount billingAccount, gaxgrpc::CallSettings callSettings = null) =>
            CreateBillingAccount(new CreateBillingAccountRequest
            {
                BillingAccount = gax::GaxPreconditions.CheckNotNull(billingAccount, nameof(billingAccount)),
            }, callSettings);

        /// <summary>
        /// This method creates [billing
        /// subaccounts](https://cloud.google.com/billing/docs/concepts#subaccounts).
        /// 
        /// Google Cloud resellers should use the
        /// Channel Services APIs,
        /// [accounts.customers.create](https://cloud.google.com/channel/docs/reference/rest/v1/accounts.customers/create)
        /// and
        /// [accounts.customers.entitlements.create](https://cloud.google.com/channel/docs/reference/rest/v1/accounts.customers.entitlements/create).
        /// 
        /// When creating a subaccount, the current authenticated user must have the
        /// `billing.accounts.update` IAM permission on the parent account, which is
        /// typically given to billing account
        /// [administrators](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// This method will return an error if the parent account has not been
        /// provisioned for subaccounts.
        /// </summary>
        /// <param name="billingAccount">
        /// Required. The billing account resource to create.
        /// Currently CreateBillingAccount only supports subaccount creation, so
        /// any created billing accounts must be under a provided parent billing
        /// account.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BillingAccount> CreateBillingAccountAsync(BillingAccount billingAccount, gaxgrpc::CallSettings callSettings = null) =>
            CreateBillingAccountAsync(new CreateBillingAccountRequest
            {
                BillingAccount = gax::GaxPreconditions.CheckNotNull(billingAccount, nameof(billingAccount)),
            }, callSettings);

        /// <summary>
        /// This method creates [billing
        /// subaccounts](https://cloud.google.com/billing/docs/concepts#subaccounts).
        /// 
        /// Google Cloud resellers should use the
        /// Channel Services APIs,
        /// [accounts.customers.create](https://cloud.google.com/channel/docs/reference/rest/v1/accounts.customers/create)
        /// and
        /// [accounts.customers.entitlements.create](https://cloud.google.com/channel/docs/reference/rest/v1/accounts.customers.entitlements/create).
        /// 
        /// When creating a subaccount, the current authenticated user must have the
        /// `billing.accounts.update` IAM permission on the parent account, which is
        /// typically given to billing account
        /// [administrators](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// This method will return an error if the parent account has not been
        /// provisioned for subaccounts.
        /// </summary>
        /// <param name="billingAccount">
        /// Required. The billing account resource to create.
        /// Currently CreateBillingAccount only supports subaccount creation, so
        /// any created billing accounts must be under a provided parent billing
        /// account.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BillingAccount> CreateBillingAccountAsync(BillingAccount billingAccount, st::CancellationToken cancellationToken) =>
            CreateBillingAccountAsync(billingAccount, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// This method creates [billing
        /// subaccounts](https://cloud.google.com/billing/docs/concepts#subaccounts).
        /// 
        /// Google Cloud resellers should use the
        /// Channel Services APIs,
        /// [accounts.customers.create](https://cloud.google.com/channel/docs/reference/rest/v1/accounts.customers/create)
        /// and
        /// [accounts.customers.entitlements.create](https://cloud.google.com/channel/docs/reference/rest/v1/accounts.customers.entitlements/create).
        /// 
        /// When creating a subaccount, the current authenticated user must have the
        /// `billing.accounts.update` IAM permission on the parent account, which is
        /// typically given to billing account
        /// [administrators](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// This method will return an error if the parent account has not been
        /// provisioned for subaccounts.
        /// </summary>
        /// <param name="billingAccount">
        /// Required. The billing account resource to create.
        /// Currently CreateBillingAccount only supports subaccount creation, so
        /// any created billing accounts must be under a provided parent billing
        /// account.
        /// </param>
        /// <param name="parent">
        /// Optional. The parent to create a billing account from.
        /// Format:
        /// - `billingAccounts/{billing_account_id}`, for example,
        /// `billingAccounts/012345-567890-ABCDEF`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BillingAccount CreateBillingAccount(BillingAccount billingAccount, string parent, gaxgrpc::CallSettings callSettings = null) =>
            CreateBillingAccount(new CreateBillingAccountRequest
            {
                BillingAccount = gax::GaxPreconditions.CheckNotNull(billingAccount, nameof(billingAccount)),
                Parent = parent ?? "",
            }, callSettings);

        /// <summary>
        /// This method creates [billing
        /// subaccounts](https://cloud.google.com/billing/docs/concepts#subaccounts).
        /// 
        /// Google Cloud resellers should use the
        /// Channel Services APIs,
        /// [accounts.customers.create](https://cloud.google.com/channel/docs/reference/rest/v1/accounts.customers/create)
        /// and
        /// [accounts.customers.entitlements.create](https://cloud.google.com/channel/docs/reference/rest/v1/accounts.customers.entitlements/create).
        /// 
        /// When creating a subaccount, the current authenticated user must have the
        /// `billing.accounts.update` IAM permission on the parent account, which is
        /// typically given to billing account
        /// [administrators](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// This method will return an error if the parent account has not been
        /// provisioned for subaccounts.
        /// </summary>
        /// <param name="billingAccount">
        /// Required. The billing account resource to create.
        /// Currently CreateBillingAccount only supports subaccount creation, so
        /// any created billing accounts must be under a provided parent billing
        /// account.
        /// </param>
        /// <param name="parent">
        /// Optional. The parent to create a billing account from.
        /// Format:
        /// - `billingAccounts/{billing_account_id}`, for example,
        /// `billingAccounts/012345-567890-ABCDEF`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BillingAccount> CreateBillingAccountAsync(BillingAccount billingAccount, string parent, gaxgrpc::CallSettings callSettings = null) =>
            CreateBillingAccountAsync(new CreateBillingAccountRequest
            {
                BillingAccount = gax::GaxPreconditions.CheckNotNull(billingAccount, nameof(billingAccount)),
                Parent = parent ?? "",
            }, callSettings);

        /// <summary>
        /// This method creates [billing
        /// subaccounts](https://cloud.google.com/billing/docs/concepts#subaccounts).
        /// 
        /// Google Cloud resellers should use the
        /// Channel Services APIs,
        /// [accounts.customers.create](https://cloud.google.com/channel/docs/reference/rest/v1/accounts.customers/create)
        /// and
        /// [accounts.customers.entitlements.create](https://cloud.google.com/channel/docs/reference/rest/v1/accounts.customers.entitlements/create).
        /// 
        /// When creating a subaccount, the current authenticated user must have the
        /// `billing.accounts.update` IAM permission on the parent account, which is
        /// typically given to billing account
        /// [administrators](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// This method will return an error if the parent account has not been
        /// provisioned for subaccounts.
        /// </summary>
        /// <param name="billingAccount">
        /// Required. The billing account resource to create.
        /// Currently CreateBillingAccount only supports subaccount creation, so
        /// any created billing accounts must be under a provided parent billing
        /// account.
        /// </param>
        /// <param name="parent">
        /// Optional. The parent to create a billing account from.
        /// Format:
        /// - `billingAccounts/{billing_account_id}`, for example,
        /// `billingAccounts/012345-567890-ABCDEF`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BillingAccount> CreateBillingAccountAsync(BillingAccount billingAccount, string parent, st::CancellationToken cancellationToken) =>
            CreateBillingAccountAsync(billingAccount, parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the projects associated with a billing account. The current
        /// authenticated user must have the `billing.resourceAssociations.list` IAM
        /// permission, which is often given to billing account
        /// [viewers](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ProjectBillingInfo"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProjectBillingInfoResponse, ProjectBillingInfo> ListProjectBillingInfo(ListProjectBillingInfoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the projects associated with a billing account. The current
        /// authenticated user must have the `billing.resourceAssociations.list` IAM
        /// permission, which is often given to billing account
        /// [viewers](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ProjectBillingInfo"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProjectBillingInfoResponse, ProjectBillingInfo> ListProjectBillingInfoAsync(ListProjectBillingInfoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the projects associated with a billing account. The current
        /// authenticated user must have the `billing.resourceAssociations.list` IAM
        /// permission, which is often given to billing account
        /// [viewers](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the billing account associated with the
        /// projects that you want to list. For example,
        /// `billingAccounts/012345-567890-ABCDEF`.
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
        /// <returns>A pageable sequence of <see cref="ProjectBillingInfo"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProjectBillingInfoResponse, ProjectBillingInfo> ListProjectBillingInfo(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProjectBillingInfoRequest request = new ListProjectBillingInfoRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListProjectBillingInfo(request, callSettings);
        }

        /// <summary>
        /// Lists the projects associated with a billing account. The current
        /// authenticated user must have the `billing.resourceAssociations.list` IAM
        /// permission, which is often given to billing account
        /// [viewers](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the billing account associated with the
        /// projects that you want to list. For example,
        /// `billingAccounts/012345-567890-ABCDEF`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ProjectBillingInfo"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProjectBillingInfoResponse, ProjectBillingInfo> ListProjectBillingInfoAsync(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProjectBillingInfoRequest request = new ListProjectBillingInfoRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListProjectBillingInfoAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the projects associated with a billing account. The current
        /// authenticated user must have the `billing.resourceAssociations.list` IAM
        /// permission, which is often given to billing account
        /// [viewers](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the billing account associated with the
        /// projects that you want to list. For example,
        /// `billingAccounts/012345-567890-ABCDEF`.
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
        /// <returns>A pageable sequence of <see cref="ProjectBillingInfo"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProjectBillingInfoResponse, ProjectBillingInfo> ListProjectBillingInfo(gagr::BillingAccountName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProjectBillingInfoRequest request = new ListProjectBillingInfoRequest
            {
                BillingAccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListProjectBillingInfo(request, callSettings);
        }

        /// <summary>
        /// Lists the projects associated with a billing account. The current
        /// authenticated user must have the `billing.resourceAssociations.list` IAM
        /// permission, which is often given to billing account
        /// [viewers](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the billing account associated with the
        /// projects that you want to list. For example,
        /// `billingAccounts/012345-567890-ABCDEF`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ProjectBillingInfo"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProjectBillingInfoResponse, ProjectBillingInfo> ListProjectBillingInfoAsync(gagr::BillingAccountName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProjectBillingInfoRequest request = new ListProjectBillingInfoRequest
            {
                BillingAccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListProjectBillingInfoAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the billing information for a project. The current authenticated user
        /// must have the `resourcemanager.projects.get` permission for the project,
        /// which can be granted by assigning the [Project
        /// Viewer](https://cloud.google.com/iam/docs/understanding-roles#predefined_roles)
        /// role.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProjectBillingInfo GetProjectBillingInfo(GetProjectBillingInfoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the billing information for a project. The current authenticated user
        /// must have the `resourcemanager.projects.get` permission for the project,
        /// which can be granted by assigning the [Project
        /// Viewer](https://cloud.google.com/iam/docs/understanding-roles#predefined_roles)
        /// role.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProjectBillingInfo> GetProjectBillingInfoAsync(GetProjectBillingInfoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the billing information for a project. The current authenticated user
        /// must have the `resourcemanager.projects.get` permission for the project,
        /// which can be granted by assigning the [Project
        /// Viewer](https://cloud.google.com/iam/docs/understanding-roles#predefined_roles)
        /// role.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProjectBillingInfo> GetProjectBillingInfoAsync(GetProjectBillingInfoRequest request, st::CancellationToken cancellationToken) =>
            GetProjectBillingInfoAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the billing information for a project. The current authenticated user
        /// must have the `resourcemanager.projects.get` permission for the project,
        /// which can be granted by assigning the [Project
        /// Viewer](https://cloud.google.com/iam/docs/understanding-roles#predefined_roles)
        /// role.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the project for which billing information is
        /// retrieved. For example, `projects/tokyo-rain-123`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProjectBillingInfo GetProjectBillingInfo(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProjectBillingInfo(new GetProjectBillingInfoRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the billing information for a project. The current authenticated user
        /// must have the `resourcemanager.projects.get` permission for the project,
        /// which can be granted by assigning the [Project
        /// Viewer](https://cloud.google.com/iam/docs/understanding-roles#predefined_roles)
        /// role.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the project for which billing information is
        /// retrieved. For example, `projects/tokyo-rain-123`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProjectBillingInfo> GetProjectBillingInfoAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProjectBillingInfoAsync(new GetProjectBillingInfoRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the billing information for a project. The current authenticated user
        /// must have the `resourcemanager.projects.get` permission for the project,
        /// which can be granted by assigning the [Project
        /// Viewer](https://cloud.google.com/iam/docs/understanding-roles#predefined_roles)
        /// role.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the project for which billing information is
        /// retrieved. For example, `projects/tokyo-rain-123`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProjectBillingInfo> GetProjectBillingInfoAsync(string name, st::CancellationToken cancellationToken) =>
            GetProjectBillingInfoAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the billing information for a project. The current authenticated user
        /// must have the `resourcemanager.projects.get` permission for the project,
        /// which can be granted by assigning the [Project
        /// Viewer](https://cloud.google.com/iam/docs/understanding-roles#predefined_roles)
        /// role.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the project for which billing information is
        /// retrieved. For example, `projects/tokyo-rain-123`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProjectBillingInfo GetProjectBillingInfo(gagr::ProjectName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProjectBillingInfo(new GetProjectBillingInfoRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the billing information for a project. The current authenticated user
        /// must have the `resourcemanager.projects.get` permission for the project,
        /// which can be granted by assigning the [Project
        /// Viewer](https://cloud.google.com/iam/docs/understanding-roles#predefined_roles)
        /// role.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the project for which billing information is
        /// retrieved. For example, `projects/tokyo-rain-123`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProjectBillingInfo> GetProjectBillingInfoAsync(gagr::ProjectName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProjectBillingInfoAsync(new GetProjectBillingInfoRequest
            {
                ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the billing information for a project. The current authenticated user
        /// must have the `resourcemanager.projects.get` permission for the project,
        /// which can be granted by assigning the [Project
        /// Viewer](https://cloud.google.com/iam/docs/understanding-roles#predefined_roles)
        /// role.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the project for which billing information is
        /// retrieved. For example, `projects/tokyo-rain-123`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProjectBillingInfo> GetProjectBillingInfoAsync(gagr::ProjectName name, st::CancellationToken cancellationToken) =>
            GetProjectBillingInfoAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets or updates the billing account associated with a project. You specify
        /// the new billing account by setting the `billing_account_name` in the
        /// `ProjectBillingInfo` resource to the resource name of a billing account.
        /// Associating a project with an open billing account enables billing on the
        /// project and allows charges for resource usage. If the project already had a
        /// billing account, this method changes the billing account used for resource
        /// usage charges.
        /// 
        /// *Note:* Incurred charges that have not yet been reported in the transaction
        /// history of the Google Cloud Console might be billed to the new billing
        /// account, even if the charge occurred before the new billing account was
        /// assigned to the project.
        /// 
        /// The current authenticated user must have ownership privileges for both
        /// the
        /// [project](https://cloud.google.com/docs/permissions-overview#h.bgs0oxofvnoo
        /// ) and the [billing
        /// account](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// 
        /// You can disable billing on the project by setting the
        /// `billing_account_name` field to empty. This action disassociates the
        /// current billing account from the project. Any billable activity of your
        /// in-use services will stop, and your application could stop functioning as
        /// expected. Any unbilled charges to date will be billed to the previously
        /// associated account. The current authenticated user must be either an owner
        /// of the project or an owner of the billing account for the project.
        /// 
        /// Note that associating a project with a *closed* billing account will have
        /// much the same effect as disabling billing on the project: any paid
        /// resources used by the project will be shut down. Thus, unless you wish to
        /// disable billing, you should always call this method with the name of an
        /// *open* billing account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProjectBillingInfo UpdateProjectBillingInfo(UpdateProjectBillingInfoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets or updates the billing account associated with a project. You specify
        /// the new billing account by setting the `billing_account_name` in the
        /// `ProjectBillingInfo` resource to the resource name of a billing account.
        /// Associating a project with an open billing account enables billing on the
        /// project and allows charges for resource usage. If the project already had a
        /// billing account, this method changes the billing account used for resource
        /// usage charges.
        /// 
        /// *Note:* Incurred charges that have not yet been reported in the transaction
        /// history of the Google Cloud Console might be billed to the new billing
        /// account, even if the charge occurred before the new billing account was
        /// assigned to the project.
        /// 
        /// The current authenticated user must have ownership privileges for both
        /// the
        /// [project](https://cloud.google.com/docs/permissions-overview#h.bgs0oxofvnoo
        /// ) and the [billing
        /// account](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// 
        /// You can disable billing on the project by setting the
        /// `billing_account_name` field to empty. This action disassociates the
        /// current billing account from the project. Any billable activity of your
        /// in-use services will stop, and your application could stop functioning as
        /// expected. Any unbilled charges to date will be billed to the previously
        /// associated account. The current authenticated user must be either an owner
        /// of the project or an owner of the billing account for the project.
        /// 
        /// Note that associating a project with a *closed* billing account will have
        /// much the same effect as disabling billing on the project: any paid
        /// resources used by the project will be shut down. Thus, unless you wish to
        /// disable billing, you should always call this method with the name of an
        /// *open* billing account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProjectBillingInfo> UpdateProjectBillingInfoAsync(UpdateProjectBillingInfoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets or updates the billing account associated with a project. You specify
        /// the new billing account by setting the `billing_account_name` in the
        /// `ProjectBillingInfo` resource to the resource name of a billing account.
        /// Associating a project with an open billing account enables billing on the
        /// project and allows charges for resource usage. If the project already had a
        /// billing account, this method changes the billing account used for resource
        /// usage charges.
        /// 
        /// *Note:* Incurred charges that have not yet been reported in the transaction
        /// history of the Google Cloud Console might be billed to the new billing
        /// account, even if the charge occurred before the new billing account was
        /// assigned to the project.
        /// 
        /// The current authenticated user must have ownership privileges for both
        /// the
        /// [project](https://cloud.google.com/docs/permissions-overview#h.bgs0oxofvnoo
        /// ) and the [billing
        /// account](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// 
        /// You can disable billing on the project by setting the
        /// `billing_account_name` field to empty. This action disassociates the
        /// current billing account from the project. Any billable activity of your
        /// in-use services will stop, and your application could stop functioning as
        /// expected. Any unbilled charges to date will be billed to the previously
        /// associated account. The current authenticated user must be either an owner
        /// of the project or an owner of the billing account for the project.
        /// 
        /// Note that associating a project with a *closed* billing account will have
        /// much the same effect as disabling billing on the project: any paid
        /// resources used by the project will be shut down. Thus, unless you wish to
        /// disable billing, you should always call this method with the name of an
        /// *open* billing account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProjectBillingInfo> UpdateProjectBillingInfoAsync(UpdateProjectBillingInfoRequest request, st::CancellationToken cancellationToken) =>
            UpdateProjectBillingInfoAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets or updates the billing account associated with a project. You specify
        /// the new billing account by setting the `billing_account_name` in the
        /// `ProjectBillingInfo` resource to the resource name of a billing account.
        /// Associating a project with an open billing account enables billing on the
        /// project and allows charges for resource usage. If the project already had a
        /// billing account, this method changes the billing account used for resource
        /// usage charges.
        /// 
        /// *Note:* Incurred charges that have not yet been reported in the transaction
        /// history of the Google Cloud Console might be billed to the new billing
        /// account, even if the charge occurred before the new billing account was
        /// assigned to the project.
        /// 
        /// The current authenticated user must have ownership privileges for both
        /// the
        /// [project](https://cloud.google.com/docs/permissions-overview#h.bgs0oxofvnoo
        /// ) and the [billing
        /// account](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// 
        /// You can disable billing on the project by setting the
        /// `billing_account_name` field to empty. This action disassociates the
        /// current billing account from the project. Any billable activity of your
        /// in-use services will stop, and your application could stop functioning as
        /// expected. Any unbilled charges to date will be billed to the previously
        /// associated account. The current authenticated user must be either an owner
        /// of the project or an owner of the billing account for the project.
        /// 
        /// Note that associating a project with a *closed* billing account will have
        /// much the same effect as disabling billing on the project: any paid
        /// resources used by the project will be shut down. Thus, unless you wish to
        /// disable billing, you should always call this method with the name of an
        /// *open* billing account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the project associated with the billing
        /// information that you want to update. For example,
        /// `projects/tokyo-rain-123`.
        /// </param>
        /// <param name="projectBillingInfo">
        /// The new billing information for the project. Output-only fields are
        /// ignored; thus, you can leave empty all fields except
        /// `billing_account_name`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProjectBillingInfo UpdateProjectBillingInfo(string name, ProjectBillingInfo projectBillingInfo, gaxgrpc::CallSettings callSettings = null) =>
            UpdateProjectBillingInfo(new UpdateProjectBillingInfoRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                ProjectBillingInfo = projectBillingInfo,
            }, callSettings);

        /// <summary>
        /// Sets or updates the billing account associated with a project. You specify
        /// the new billing account by setting the `billing_account_name` in the
        /// `ProjectBillingInfo` resource to the resource name of a billing account.
        /// Associating a project with an open billing account enables billing on the
        /// project and allows charges for resource usage. If the project already had a
        /// billing account, this method changes the billing account used for resource
        /// usage charges.
        /// 
        /// *Note:* Incurred charges that have not yet been reported in the transaction
        /// history of the Google Cloud Console might be billed to the new billing
        /// account, even if the charge occurred before the new billing account was
        /// assigned to the project.
        /// 
        /// The current authenticated user must have ownership privileges for both
        /// the
        /// [project](https://cloud.google.com/docs/permissions-overview#h.bgs0oxofvnoo
        /// ) and the [billing
        /// account](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// 
        /// You can disable billing on the project by setting the
        /// `billing_account_name` field to empty. This action disassociates the
        /// current billing account from the project. Any billable activity of your
        /// in-use services will stop, and your application could stop functioning as
        /// expected. Any unbilled charges to date will be billed to the previously
        /// associated account. The current authenticated user must be either an owner
        /// of the project or an owner of the billing account for the project.
        /// 
        /// Note that associating a project with a *closed* billing account will have
        /// much the same effect as disabling billing on the project: any paid
        /// resources used by the project will be shut down. Thus, unless you wish to
        /// disable billing, you should always call this method with the name of an
        /// *open* billing account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the project associated with the billing
        /// information that you want to update. For example,
        /// `projects/tokyo-rain-123`.
        /// </param>
        /// <param name="projectBillingInfo">
        /// The new billing information for the project. Output-only fields are
        /// ignored; thus, you can leave empty all fields except
        /// `billing_account_name`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProjectBillingInfo> UpdateProjectBillingInfoAsync(string name, ProjectBillingInfo projectBillingInfo, gaxgrpc::CallSettings callSettings = null) =>
            UpdateProjectBillingInfoAsync(new UpdateProjectBillingInfoRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                ProjectBillingInfo = projectBillingInfo,
            }, callSettings);

        /// <summary>
        /// Sets or updates the billing account associated with a project. You specify
        /// the new billing account by setting the `billing_account_name` in the
        /// `ProjectBillingInfo` resource to the resource name of a billing account.
        /// Associating a project with an open billing account enables billing on the
        /// project and allows charges for resource usage. If the project already had a
        /// billing account, this method changes the billing account used for resource
        /// usage charges.
        /// 
        /// *Note:* Incurred charges that have not yet been reported in the transaction
        /// history of the Google Cloud Console might be billed to the new billing
        /// account, even if the charge occurred before the new billing account was
        /// assigned to the project.
        /// 
        /// The current authenticated user must have ownership privileges for both
        /// the
        /// [project](https://cloud.google.com/docs/permissions-overview#h.bgs0oxofvnoo
        /// ) and the [billing
        /// account](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// 
        /// You can disable billing on the project by setting the
        /// `billing_account_name` field to empty. This action disassociates the
        /// current billing account from the project. Any billable activity of your
        /// in-use services will stop, and your application could stop functioning as
        /// expected. Any unbilled charges to date will be billed to the previously
        /// associated account. The current authenticated user must be either an owner
        /// of the project or an owner of the billing account for the project.
        /// 
        /// Note that associating a project with a *closed* billing account will have
        /// much the same effect as disabling billing on the project: any paid
        /// resources used by the project will be shut down. Thus, unless you wish to
        /// disable billing, you should always call this method with the name of an
        /// *open* billing account.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the project associated with the billing
        /// information that you want to update. For example,
        /// `projects/tokyo-rain-123`.
        /// </param>
        /// <param name="projectBillingInfo">
        /// The new billing information for the project. Output-only fields are
        /// ignored; thus, you can leave empty all fields except
        /// `billing_account_name`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProjectBillingInfo> UpdateProjectBillingInfoAsync(string name, ProjectBillingInfo projectBillingInfo, st::CancellationToken cancellationToken) =>
            UpdateProjectBillingInfoAsync(name, projectBillingInfo, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a billing account.
        /// The caller must have the `billing.accounts.getIamPolicy` permission on the
        /// account, which is often given to billing account
        /// [viewers](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for a billing account.
        /// The caller must have the `billing.accounts.getIamPolicy` permission on the
        /// account, which is often given to billing account
        /// [viewers](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for a billing account.
        /// The caller must have the `billing.accounts.getIamPolicy` permission on the
        /// account, which is often given to billing account
        /// [viewers](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a billing account.
        /// The caller must have the `billing.accounts.getIamPolicy` permission on the
        /// account, which is often given to billing account
        /// [viewers](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new gciv::GetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a billing account.
        /// The caller must have the `billing.accounts.getIamPolicy` permission on the
        /// account, which is often given to billing account
        /// [viewers](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new gciv::GetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a billing account.
        /// The caller must have the `billing.accounts.getIamPolicy` permission on the
        /// account, which is often given to billing account
        /// [viewers](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(string resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a billing account.
        /// The caller must have the `billing.accounts.getIamPolicy` permission on the
        /// account, which is often given to billing account
        /// [viewers](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a billing account.
        /// The caller must have the `billing.accounts.getIamPolicy` permission on the
        /// account, which is often given to billing account
        /// [viewers](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy for a billing account.
        /// The caller must have the `billing.accounts.getIamPolicy` permission on the
        /// account, which is often given to billing account
        /// [viewers](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gax::IResourceName resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy for a billing account. Replaces any existing
        /// policy.
        /// The caller must have the `billing.accounts.setIamPolicy` permission on the
        /// account, which is often given to billing account
        /// [administrators](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy for a billing account. Replaces any existing
        /// policy.
        /// The caller must have the `billing.accounts.setIamPolicy` permission on the
        /// account, which is often given to billing account
        /// [administrators](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy for a billing account. Replaces any existing
        /// policy.
        /// The caller must have the `billing.accounts.setIamPolicy` permission on the
        /// account, which is often given to billing account
        /// [administrators](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy for a billing account. Replaces any existing
        /// policy.
        /// The caller must have the `billing.accounts.setIamPolicy` permission on the
        /// account, which is often given to billing account
        /// [administrators](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(string resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicy(new gciv::SetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy for a billing account. Replaces any existing
        /// policy.
        /// The caller must have the `billing.accounts.setIamPolicy` permission on the
        /// account, which is often given to billing account
        /// [administrators](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(string resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyAsync(new gciv::SetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy for a billing account. Replaces any existing
        /// policy.
        /// The caller must have the `billing.accounts.setIamPolicy` permission on the
        /// account, which is often given to billing account
        /// [administrators](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(string resource, gciv::Policy policy, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(resource, policy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy for a billing account. Replaces any existing
        /// policy.
        /// The caller must have the `billing.accounts.setIamPolicy` permission on the
        /// account, which is often given to billing account
        /// [administrators](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gax::IResourceName resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicy(new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy for a billing account. Replaces any existing
        /// policy.
        /// The caller must have the `billing.accounts.setIamPolicy` permission on the
        /// account, which is often given to billing account
        /// [administrators](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gax::IResourceName resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyAsync(new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy for a billing account. Replaces any existing
        /// policy.
        /// The caller must have the `billing.accounts.setIamPolicy` permission on the
        /// account, which is often given to billing account
        /// [administrators](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gax::IResourceName resource, gciv::Policy policy, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(resource, policy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Tests the access control policy for a billing account. This method takes
        /// the resource and a set of permissions as input and returns the subset of
        /// the input permissions that the caller is allowed for that resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Tests the access control policy for a billing account. This method takes
        /// the resource and a set of permissions as input and returns the subset of
        /// the input permissions that the caller is allowed for that resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Tests the access control policy for a billing account. This method takes
        /// the resource and a set of permissions as input and returns the subset of
        /// the input permissions that the caller is allowed for that resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Tests the access control policy for a billing account. This method takes
        /// the resource and a set of permissions as input and returns the subset of
        /// the input permissions that the caller is allowed for that resource.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(string resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissions(new gciv::TestIamPermissionsRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Tests the access control policy for a billing account. This method takes
        /// the resource and a set of permissions as input and returns the subset of
        /// the input permissions that the caller is allowed for that resource.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(string resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissionsAsync(new gciv::TestIamPermissionsRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Tests the access control policy for a billing account. This method takes
        /// the resource and a set of permissions as input and returns the subset of
        /// the input permissions that the caller is allowed for that resource.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(string resource, scg::IEnumerable<string> permissions, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(resource, permissions, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Tests the access control policy for a billing account. This method takes
        /// the resource and a set of permissions as input and returns the subset of
        /// the input permissions that the caller is allowed for that resource.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gax::IResourceName resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissions(new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Tests the access control policy for a billing account. This method takes
        /// the resource and a set of permissions as input and returns the subset of
        /// the input permissions that the caller is allowed for that resource.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gax::IResourceName resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissionsAsync(new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Tests the access control policy for a billing account. This method takes
        /// the resource and a set of permissions as input and returns the subset of
        /// the input permissions that the caller is allowed for that resource.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gax::IResourceName resource, scg::IEnumerable<string> permissions, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(resource, permissions, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Changes which parent organization a billing account belongs to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BillingAccount MoveBillingAccount(MoveBillingAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes which parent organization a billing account belongs to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BillingAccount> MoveBillingAccountAsync(MoveBillingAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes which parent organization a billing account belongs to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BillingAccount> MoveBillingAccountAsync(MoveBillingAccountRequest request, st::CancellationToken cancellationToken) =>
            MoveBillingAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CloudBilling client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Retrieves the Google Cloud Console billing accounts and associates them with
    /// projects.
    /// </remarks>
    public sealed partial class CloudBillingClientImpl : CloudBillingClient
    {
        private readonly gaxgrpc::ApiCall<GetBillingAccountRequest, BillingAccount> _callGetBillingAccount;

        private readonly gaxgrpc::ApiCall<ListBillingAccountsRequest, ListBillingAccountsResponse> _callListBillingAccounts;

        private readonly gaxgrpc::ApiCall<UpdateBillingAccountRequest, BillingAccount> _callUpdateBillingAccount;

        private readonly gaxgrpc::ApiCall<CreateBillingAccountRequest, BillingAccount> _callCreateBillingAccount;

        private readonly gaxgrpc::ApiCall<ListProjectBillingInfoRequest, ListProjectBillingInfoResponse> _callListProjectBillingInfo;

        private readonly gaxgrpc::ApiCall<GetProjectBillingInfoRequest, ProjectBillingInfo> _callGetProjectBillingInfo;

        private readonly gaxgrpc::ApiCall<UpdateProjectBillingInfoRequest, ProjectBillingInfo> _callUpdateProjectBillingInfo;

        private readonly gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> _callGetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> _callSetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> _callTestIamPermissions;

        private readonly gaxgrpc::ApiCall<MoveBillingAccountRequest, BillingAccount> _callMoveBillingAccount;

        /// <summary>
        /// Constructs a client wrapper for the CloudBilling service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CloudBillingSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CloudBillingClientImpl(CloudBilling.CloudBillingClient grpcClient, CloudBillingSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CloudBillingSettings effectiveSettings = settings ?? CloudBillingSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetBillingAccount = clientHelper.BuildApiCall<GetBillingAccountRequest, BillingAccount>("GetBillingAccount", grpcClient.GetBillingAccountAsync, grpcClient.GetBillingAccount, effectiveSettings.GetBillingAccountSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetBillingAccount);
            Modify_GetBillingAccountApiCall(ref _callGetBillingAccount);
            _callListBillingAccounts = clientHelper.BuildApiCall<ListBillingAccountsRequest, ListBillingAccountsResponse>("ListBillingAccounts", grpcClient.ListBillingAccountsAsync, grpcClient.ListBillingAccounts, effectiveSettings.ListBillingAccountsSettings);
            Modify_ApiCall(ref _callListBillingAccounts);
            Modify_ListBillingAccountsApiCall(ref _callListBillingAccounts);
            _callUpdateBillingAccount = clientHelper.BuildApiCall<UpdateBillingAccountRequest, BillingAccount>("UpdateBillingAccount", grpcClient.UpdateBillingAccountAsync, grpcClient.UpdateBillingAccount, effectiveSettings.UpdateBillingAccountSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateBillingAccount);
            Modify_UpdateBillingAccountApiCall(ref _callUpdateBillingAccount);
            _callCreateBillingAccount = clientHelper.BuildApiCall<CreateBillingAccountRequest, BillingAccount>("CreateBillingAccount", grpcClient.CreateBillingAccountAsync, grpcClient.CreateBillingAccount, effectiveSettings.CreateBillingAccountSettings);
            Modify_ApiCall(ref _callCreateBillingAccount);
            Modify_CreateBillingAccountApiCall(ref _callCreateBillingAccount);
            _callListProjectBillingInfo = clientHelper.BuildApiCall<ListProjectBillingInfoRequest, ListProjectBillingInfoResponse>("ListProjectBillingInfo", grpcClient.ListProjectBillingInfoAsync, grpcClient.ListProjectBillingInfo, effectiveSettings.ListProjectBillingInfoSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callListProjectBillingInfo);
            Modify_ListProjectBillingInfoApiCall(ref _callListProjectBillingInfo);
            _callGetProjectBillingInfo = clientHelper.BuildApiCall<GetProjectBillingInfoRequest, ProjectBillingInfo>("GetProjectBillingInfo", grpcClient.GetProjectBillingInfoAsync, grpcClient.GetProjectBillingInfo, effectiveSettings.GetProjectBillingInfoSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetProjectBillingInfo);
            Modify_GetProjectBillingInfoApiCall(ref _callGetProjectBillingInfo);
            _callUpdateProjectBillingInfo = clientHelper.BuildApiCall<UpdateProjectBillingInfoRequest, ProjectBillingInfo>("UpdateProjectBillingInfo", grpcClient.UpdateProjectBillingInfoAsync, grpcClient.UpdateProjectBillingInfo, effectiveSettings.UpdateProjectBillingInfoSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateProjectBillingInfo);
            Modify_UpdateProjectBillingInfoApiCall(ref _callUpdateProjectBillingInfo);
            _callGetIamPolicy = clientHelper.BuildApiCall<gciv::GetIamPolicyRequest, gciv::Policy>("GetIamPolicy", grpcClient.GetIamPolicyAsync, grpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            _callSetIamPolicy = clientHelper.BuildApiCall<gciv::SetIamPolicyRequest, gciv::Policy>("SetIamPolicy", grpcClient.SetIamPolicyAsync, grpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            _callTestIamPermissions = clientHelper.BuildApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse>("TestIamPermissions", grpcClient.TestIamPermissionsAsync, grpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            _callMoveBillingAccount = clientHelper.BuildApiCall<MoveBillingAccountRequest, BillingAccount>("MoveBillingAccount", grpcClient.MoveBillingAccountAsync, grpcClient.MoveBillingAccount, effectiveSettings.MoveBillingAccountSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callMoveBillingAccount);
            Modify_MoveBillingAccountApiCall(ref _callMoveBillingAccount);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetBillingAccountApiCall(ref gaxgrpc::ApiCall<GetBillingAccountRequest, BillingAccount> call);

        partial void Modify_ListBillingAccountsApiCall(ref gaxgrpc::ApiCall<ListBillingAccountsRequest, ListBillingAccountsResponse> call);

        partial void Modify_UpdateBillingAccountApiCall(ref gaxgrpc::ApiCall<UpdateBillingAccountRequest, BillingAccount> call);

        partial void Modify_CreateBillingAccountApiCall(ref gaxgrpc::ApiCall<CreateBillingAccountRequest, BillingAccount> call);

        partial void Modify_ListProjectBillingInfoApiCall(ref gaxgrpc::ApiCall<ListProjectBillingInfoRequest, ListProjectBillingInfoResponse> call);

        partial void Modify_GetProjectBillingInfoApiCall(ref gaxgrpc::ApiCall<GetProjectBillingInfoRequest, ProjectBillingInfo> call);

        partial void Modify_UpdateProjectBillingInfoApiCall(ref gaxgrpc::ApiCall<UpdateProjectBillingInfoRequest, ProjectBillingInfo> call);

        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> call);

        partial void Modify_MoveBillingAccountApiCall(ref gaxgrpc::ApiCall<MoveBillingAccountRequest, BillingAccount> call);

        partial void OnConstruction(CloudBilling.CloudBillingClient grpcClient, CloudBillingSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CloudBilling client</summary>
        public override CloudBilling.CloudBillingClient GrpcClient { get; }

        partial void Modify_GetBillingAccountRequest(ref GetBillingAccountRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBillingAccountsRequest(ref ListBillingAccountsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateBillingAccountRequest(ref UpdateBillingAccountRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateBillingAccountRequest(ref CreateBillingAccountRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListProjectBillingInfoRequest(ref ListProjectBillingInfoRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetProjectBillingInfoRequest(ref GetProjectBillingInfoRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateProjectBillingInfoRequest(ref UpdateProjectBillingInfoRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIamPolicyRequest(ref gciv::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetIamPolicyRequest(ref gciv::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsRequest(ref gciv::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MoveBillingAccountRequest(ref MoveBillingAccountRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets information about a billing account. The current authenticated user
        /// must be a [viewer of the billing
        /// account](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BillingAccount GetBillingAccount(GetBillingAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBillingAccountRequest(ref request, ref callSettings);
            return _callGetBillingAccount.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets information about a billing account. The current authenticated user
        /// must be a [viewer of the billing
        /// account](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BillingAccount> GetBillingAccountAsync(GetBillingAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBillingAccountRequest(ref request, ref callSettings);
            return _callGetBillingAccount.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the billing accounts that the current authenticated user has
        /// permission to
        /// [view](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BillingAccount"/> resources.</returns>
        public override gax::PagedEnumerable<ListBillingAccountsResponse, BillingAccount> ListBillingAccounts(ListBillingAccountsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBillingAccountsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListBillingAccountsRequest, ListBillingAccountsResponse, BillingAccount>(_callListBillingAccounts, request, callSettings);
        }

        /// <summary>
        /// Lists the billing accounts that the current authenticated user has
        /// permission to
        /// [view](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BillingAccount"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBillingAccountsResponse, BillingAccount> ListBillingAccountsAsync(ListBillingAccountsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBillingAccountsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBillingAccountsRequest, ListBillingAccountsResponse, BillingAccount>(_callListBillingAccounts, request, callSettings);
        }

        /// <summary>
        /// Updates a billing account's fields.
        /// Currently the only field that can be edited is `display_name`.
        /// The current authenticated user must have the `billing.accounts.update`
        /// IAM permission, which is typically given to the
        /// [administrator](https://cloud.google.com/billing/docs/how-to/billing-access)
        /// of the billing account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BillingAccount UpdateBillingAccount(UpdateBillingAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBillingAccountRequest(ref request, ref callSettings);
            return _callUpdateBillingAccount.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a billing account's fields.
        /// Currently the only field that can be edited is `display_name`.
        /// The current authenticated user must have the `billing.accounts.update`
        /// IAM permission, which is typically given to the
        /// [administrator](https://cloud.google.com/billing/docs/how-to/billing-access)
        /// of the billing account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BillingAccount> UpdateBillingAccountAsync(UpdateBillingAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBillingAccountRequest(ref request, ref callSettings);
            return _callUpdateBillingAccount.Async(request, callSettings);
        }

        /// <summary>
        /// This method creates [billing
        /// subaccounts](https://cloud.google.com/billing/docs/concepts#subaccounts).
        /// 
        /// Google Cloud resellers should use the
        /// Channel Services APIs,
        /// [accounts.customers.create](https://cloud.google.com/channel/docs/reference/rest/v1/accounts.customers/create)
        /// and
        /// [accounts.customers.entitlements.create](https://cloud.google.com/channel/docs/reference/rest/v1/accounts.customers.entitlements/create).
        /// 
        /// When creating a subaccount, the current authenticated user must have the
        /// `billing.accounts.update` IAM permission on the parent account, which is
        /// typically given to billing account
        /// [administrators](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// This method will return an error if the parent account has not been
        /// provisioned for subaccounts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BillingAccount CreateBillingAccount(CreateBillingAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBillingAccountRequest(ref request, ref callSettings);
            return _callCreateBillingAccount.Sync(request, callSettings);
        }

        /// <summary>
        /// This method creates [billing
        /// subaccounts](https://cloud.google.com/billing/docs/concepts#subaccounts).
        /// 
        /// Google Cloud resellers should use the
        /// Channel Services APIs,
        /// [accounts.customers.create](https://cloud.google.com/channel/docs/reference/rest/v1/accounts.customers/create)
        /// and
        /// [accounts.customers.entitlements.create](https://cloud.google.com/channel/docs/reference/rest/v1/accounts.customers.entitlements/create).
        /// 
        /// When creating a subaccount, the current authenticated user must have the
        /// `billing.accounts.update` IAM permission on the parent account, which is
        /// typically given to billing account
        /// [administrators](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// This method will return an error if the parent account has not been
        /// provisioned for subaccounts.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BillingAccount> CreateBillingAccountAsync(CreateBillingAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBillingAccountRequest(ref request, ref callSettings);
            return _callCreateBillingAccount.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the projects associated with a billing account. The current
        /// authenticated user must have the `billing.resourceAssociations.list` IAM
        /// permission, which is often given to billing account
        /// [viewers](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ProjectBillingInfo"/> resources.</returns>
        public override gax::PagedEnumerable<ListProjectBillingInfoResponse, ProjectBillingInfo> ListProjectBillingInfo(ListProjectBillingInfoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProjectBillingInfoRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListProjectBillingInfoRequest, ListProjectBillingInfoResponse, ProjectBillingInfo>(_callListProjectBillingInfo, request, callSettings);
        }

        /// <summary>
        /// Lists the projects associated with a billing account. The current
        /// authenticated user must have the `billing.resourceAssociations.list` IAM
        /// permission, which is often given to billing account
        /// [viewers](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ProjectBillingInfo"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListProjectBillingInfoResponse, ProjectBillingInfo> ListProjectBillingInfoAsync(ListProjectBillingInfoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProjectBillingInfoRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListProjectBillingInfoRequest, ListProjectBillingInfoResponse, ProjectBillingInfo>(_callListProjectBillingInfo, request, callSettings);
        }

        /// <summary>
        /// Gets the billing information for a project. The current authenticated user
        /// must have the `resourcemanager.projects.get` permission for the project,
        /// which can be granted by assigning the [Project
        /// Viewer](https://cloud.google.com/iam/docs/understanding-roles#predefined_roles)
        /// role.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ProjectBillingInfo GetProjectBillingInfo(GetProjectBillingInfoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProjectBillingInfoRequest(ref request, ref callSettings);
            return _callGetProjectBillingInfo.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the billing information for a project. The current authenticated user
        /// must have the `resourcemanager.projects.get` permission for the project,
        /// which can be granted by assigning the [Project
        /// Viewer](https://cloud.google.com/iam/docs/understanding-roles#predefined_roles)
        /// role.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ProjectBillingInfo> GetProjectBillingInfoAsync(GetProjectBillingInfoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProjectBillingInfoRequest(ref request, ref callSettings);
            return _callGetProjectBillingInfo.Async(request, callSettings);
        }

        /// <summary>
        /// Sets or updates the billing account associated with a project. You specify
        /// the new billing account by setting the `billing_account_name` in the
        /// `ProjectBillingInfo` resource to the resource name of a billing account.
        /// Associating a project with an open billing account enables billing on the
        /// project and allows charges for resource usage. If the project already had a
        /// billing account, this method changes the billing account used for resource
        /// usage charges.
        /// 
        /// *Note:* Incurred charges that have not yet been reported in the transaction
        /// history of the Google Cloud Console might be billed to the new billing
        /// account, even if the charge occurred before the new billing account was
        /// assigned to the project.
        /// 
        /// The current authenticated user must have ownership privileges for both
        /// the
        /// [project](https://cloud.google.com/docs/permissions-overview#h.bgs0oxofvnoo
        /// ) and the [billing
        /// account](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// 
        /// You can disable billing on the project by setting the
        /// `billing_account_name` field to empty. This action disassociates the
        /// current billing account from the project. Any billable activity of your
        /// in-use services will stop, and your application could stop functioning as
        /// expected. Any unbilled charges to date will be billed to the previously
        /// associated account. The current authenticated user must be either an owner
        /// of the project or an owner of the billing account for the project.
        /// 
        /// Note that associating a project with a *closed* billing account will have
        /// much the same effect as disabling billing on the project: any paid
        /// resources used by the project will be shut down. Thus, unless you wish to
        /// disable billing, you should always call this method with the name of an
        /// *open* billing account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ProjectBillingInfo UpdateProjectBillingInfo(UpdateProjectBillingInfoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateProjectBillingInfoRequest(ref request, ref callSettings);
            return _callUpdateProjectBillingInfo.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets or updates the billing account associated with a project. You specify
        /// the new billing account by setting the `billing_account_name` in the
        /// `ProjectBillingInfo` resource to the resource name of a billing account.
        /// Associating a project with an open billing account enables billing on the
        /// project and allows charges for resource usage. If the project already had a
        /// billing account, this method changes the billing account used for resource
        /// usage charges.
        /// 
        /// *Note:* Incurred charges that have not yet been reported in the transaction
        /// history of the Google Cloud Console might be billed to the new billing
        /// account, even if the charge occurred before the new billing account was
        /// assigned to the project.
        /// 
        /// The current authenticated user must have ownership privileges for both
        /// the
        /// [project](https://cloud.google.com/docs/permissions-overview#h.bgs0oxofvnoo
        /// ) and the [billing
        /// account](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// 
        /// You can disable billing on the project by setting the
        /// `billing_account_name` field to empty. This action disassociates the
        /// current billing account from the project. Any billable activity of your
        /// in-use services will stop, and your application could stop functioning as
        /// expected. Any unbilled charges to date will be billed to the previously
        /// associated account. The current authenticated user must be either an owner
        /// of the project or an owner of the billing account for the project.
        /// 
        /// Note that associating a project with a *closed* billing account will have
        /// much the same effect as disabling billing on the project: any paid
        /// resources used by the project will be shut down. Thus, unless you wish to
        /// disable billing, you should always call this method with the name of an
        /// *open* billing account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ProjectBillingInfo> UpdateProjectBillingInfoAsync(UpdateProjectBillingInfoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateProjectBillingInfoRequest(ref request, ref callSettings);
            return _callUpdateProjectBillingInfo.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for a billing account.
        /// The caller must have the `billing.accounts.getIamPolicy` permission on the
        /// account, which is often given to billing account
        /// [viewers](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for a billing account.
        /// The caller must have the `billing.accounts.getIamPolicy` permission on the
        /// account, which is often given to billing account
        /// [viewers](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy for a billing account. Replaces any existing
        /// policy.
        /// The caller must have the `billing.accounts.setIamPolicy` permission on the
        /// account, which is often given to billing account
        /// [administrators](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy for a billing account. Replaces any existing
        /// policy.
        /// The caller must have the `billing.accounts.setIamPolicy` permission on the
        /// account, which is often given to billing account
        /// [administrators](https://cloud.google.com/billing/docs/how-to/billing-access).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Tests the access control policy for a billing account. This method takes
        /// the resource and a set of permissions as input and returns the subset of
        /// the input permissions that the caller is allowed for that resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Sync(request, callSettings);
        }

        /// <summary>
        /// Tests the access control policy for a billing account. This method takes
        /// the resource and a set of permissions as input and returns the subset of
        /// the input permissions that the caller is allowed for that resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }

        /// <summary>
        /// Changes which parent organization a billing account belongs to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BillingAccount MoveBillingAccount(MoveBillingAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MoveBillingAccountRequest(ref request, ref callSettings);
            return _callMoveBillingAccount.Sync(request, callSettings);
        }

        /// <summary>
        /// Changes which parent organization a billing account belongs to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BillingAccount> MoveBillingAccountAsync(MoveBillingAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MoveBillingAccountRequest(ref request, ref callSettings);
            return _callMoveBillingAccount.Async(request, callSettings);
        }
    }

    public partial class ListBillingAccountsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListProjectBillingInfoRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBillingAccountsResponse : gaxgrpc::IPageResponse<BillingAccount>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<BillingAccount> GetEnumerator() => BillingAccounts.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListProjectBillingInfoResponse : gaxgrpc::IPageResponse<ProjectBillingInfo>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ProjectBillingInfo> GetEnumerator() => ProjectBillingInfo.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
