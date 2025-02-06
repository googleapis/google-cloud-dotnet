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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Functions.V1
{
    /// <summary>Settings for <see cref="CloudFunctionsServiceClient"/> instances.</summary>
    public sealed partial class CloudFunctionsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CloudFunctionsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CloudFunctionsServiceSettings"/>.</returns>
        public static CloudFunctionsServiceSettings GetDefault() => new CloudFunctionsServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CloudFunctionsServiceSettings"/> object with default settings.
        /// </summary>
        public CloudFunctionsServiceSettings()
        {
        }

        private CloudFunctionsServiceSettings(CloudFunctionsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListFunctionsSettings = existing.ListFunctionsSettings;
            GetFunctionSettings = existing.GetFunctionSettings;
            CreateFunctionSettings = existing.CreateFunctionSettings;
            CreateFunctionOperationsSettings = existing.CreateFunctionOperationsSettings.Clone();
            UpdateFunctionSettings = existing.UpdateFunctionSettings;
            UpdateFunctionOperationsSettings = existing.UpdateFunctionOperationsSettings.Clone();
            DeleteFunctionSettings = existing.DeleteFunctionSettings;
            DeleteFunctionOperationsSettings = existing.DeleteFunctionOperationsSettings.Clone();
            CallFunctionSettings = existing.CallFunctionSettings;
            GenerateUploadUrlSettings = existing.GenerateUploadUrlSettings;
            GenerateDownloadUrlSettings = existing.GenerateDownloadUrlSettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(CloudFunctionsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudFunctionsServiceClient.ListFunctions</c> and <c>CloudFunctionsServiceClient.ListFunctionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListFunctionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudFunctionsServiceClient.GetFunction</c> and <c>CloudFunctionsServiceClient.GetFunctionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetFunctionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudFunctionsServiceClient.CreateFunction</c> and <c>CloudFunctionsServiceClient.CreateFunctionAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateFunctionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudFunctionsServiceClient.CreateFunction</c> and
        /// <c>CloudFunctionsServiceClient.CreateFunctionAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateFunctionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudFunctionsServiceClient.UpdateFunction</c> and <c>CloudFunctionsServiceClient.UpdateFunctionAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateFunctionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudFunctionsServiceClient.UpdateFunction</c> and
        /// <c>CloudFunctionsServiceClient.UpdateFunctionAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings UpdateFunctionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudFunctionsServiceClient.DeleteFunction</c> and <c>CloudFunctionsServiceClient.DeleteFunctionAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteFunctionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudFunctionsServiceClient.DeleteFunction</c> and
        /// <c>CloudFunctionsServiceClient.DeleteFunctionAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteFunctionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudFunctionsServiceClient.CallFunction</c> and <c>CloudFunctionsServiceClient.CallFunctionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CallFunctionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudFunctionsServiceClient.GenerateUploadUrl</c> and
        /// <c>CloudFunctionsServiceClient.GenerateUploadUrlAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateUploadUrlSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudFunctionsServiceClient.GenerateDownloadUrl</c> and
        /// <c>CloudFunctionsServiceClient.GenerateDownloadUrlAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateDownloadUrlSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudFunctionsServiceClient.SetIamPolicy</c> and <c>CloudFunctionsServiceClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudFunctionsServiceClient.GetIamPolicy</c> and <c>CloudFunctionsServiceClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudFunctionsServiceClient.TestIamPermissions</c> and
        /// <c>CloudFunctionsServiceClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CloudFunctionsServiceSettings"/> object.</returns>
        public CloudFunctionsServiceSettings Clone() => new CloudFunctionsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CloudFunctionsServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class CloudFunctionsServiceClientBuilder : gaxgrpc::ClientBuilderBase<CloudFunctionsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CloudFunctionsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CloudFunctionsServiceClientBuilder() : base(CloudFunctionsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CloudFunctionsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CloudFunctionsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CloudFunctionsServiceClient Build()
        {
            CloudFunctionsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CloudFunctionsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CloudFunctionsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CloudFunctionsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CloudFunctionsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CloudFunctionsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CloudFunctionsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CloudFunctionsServiceClient.ChannelPool;
    }

    /// <summary>CloudFunctionsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service that application uses to manipulate triggers and functions.
    /// </remarks>
    public abstract partial class CloudFunctionsServiceClient
    {
        /// <summary>
        /// The default endpoint for the CloudFunctionsService service, which is a host of
        /// "cloudfunctions.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudfunctions.googleapis.com:443";

        /// <summary>The default CloudFunctionsService scopes.</summary>
        /// <remarks>
        /// The default CloudFunctionsService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CloudFunctionsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CloudFunctionsServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CloudFunctionsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CloudFunctionsServiceClient"/>.</returns>
        public static stt::Task<CloudFunctionsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CloudFunctionsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CloudFunctionsServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CloudFunctionsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CloudFunctionsServiceClient"/>.</returns>
        public static CloudFunctionsServiceClient Create() => new CloudFunctionsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CloudFunctionsServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CloudFunctionsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CloudFunctionsServiceClient"/>.</returns>
        internal static CloudFunctionsServiceClient Create(grpccore::CallInvoker callInvoker, CloudFunctionsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CloudFunctionsService.CloudFunctionsServiceClient grpcClient = new CloudFunctionsService.CloudFunctionsServiceClient(callInvoker);
            return new CloudFunctionsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CloudFunctionsService client</summary>
        public virtual CloudFunctionsService.CloudFunctionsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of functions that belong to the requested project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CloudFunction"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFunctionsResponse, CloudFunction> ListFunctions(ListFunctionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of functions that belong to the requested project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CloudFunction"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFunctionsResponse, CloudFunction> ListFunctionsAsync(ListFunctionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a function with the given name from the requested project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CloudFunction GetFunction(GetFunctionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a function with the given name from the requested project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudFunction> GetFunctionAsync(GetFunctionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a function with the given name from the requested project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudFunction> GetFunctionAsync(GetFunctionRequest request, st::CancellationToken cancellationToken) =>
            GetFunctionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a function with the given name from the requested project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the function which details should be obtained.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CloudFunction GetFunction(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFunction(new GetFunctionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a function with the given name from the requested project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the function which details should be obtained.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudFunction> GetFunctionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFunctionAsync(new GetFunctionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a function with the given name from the requested project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the function which details should be obtained.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudFunction> GetFunctionAsync(string name, st::CancellationToken cancellationToken) =>
            GetFunctionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a function with the given name from the requested project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the function which details should be obtained.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CloudFunction GetFunction(CloudFunctionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFunction(new GetFunctionRequest
            {
                CloudFunctionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a function with the given name from the requested project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the function which details should be obtained.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudFunction> GetFunctionAsync(CloudFunctionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFunctionAsync(new GetFunctionRequest
            {
                CloudFunctionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a function with the given name from the requested project.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the function which details should be obtained.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CloudFunction> GetFunctionAsync(CloudFunctionName name, st::CancellationToken cancellationToken) =>
            GetFunctionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new function. If a function with the given name already exists in
        /// the specified project, the long running operation will return
        /// `ALREADY_EXISTS` error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CloudFunction, OperationMetadataV1> CreateFunction(CreateFunctionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new function. If a function with the given name already exists in
        /// the specified project, the long running operation will return
        /// `ALREADY_EXISTS` error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CloudFunction, OperationMetadataV1>> CreateFunctionAsync(CreateFunctionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new function. If a function with the given name already exists in
        /// the specified project, the long running operation will return
        /// `ALREADY_EXISTS` error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CloudFunction, OperationMetadataV1>> CreateFunctionAsync(CreateFunctionRequest request, st::CancellationToken cancellationToken) =>
            CreateFunctionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateFunction</c>.</summary>
        public virtual lro::OperationsClient CreateFunctionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateFunction</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CloudFunction, OperationMetadataV1> PollOnceCreateFunction(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CloudFunction, OperationMetadataV1>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateFunctionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateFunction</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CloudFunction, OperationMetadataV1>> PollOnceCreateFunctionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CloudFunction, OperationMetadataV1>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateFunctionOperationsClient, callSettings);

        /// <summary>
        /// Creates a new function. If a function with the given name already exists in
        /// the specified project, the long running operation will return
        /// `ALREADY_EXISTS` error.
        /// </summary>
        /// <param name="location">
        /// Required. The project and location in which the function should be created,
        /// specified in the format `projects/*/locations/*`
        /// </param>
        /// <param name="function">
        /// Required. Function to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CloudFunction, OperationMetadataV1> CreateFunction(string location, CloudFunction function, gaxgrpc::CallSettings callSettings = null) =>
            CreateFunction(new CreateFunctionRequest
            {
                Location = gax::GaxPreconditions.CheckNotNullOrEmpty(location, nameof(location)),
                Function = gax::GaxPreconditions.CheckNotNull(function, nameof(function)),
            }, callSettings);

        /// <summary>
        /// Creates a new function. If a function with the given name already exists in
        /// the specified project, the long running operation will return
        /// `ALREADY_EXISTS` error.
        /// </summary>
        /// <param name="location">
        /// Required. The project and location in which the function should be created,
        /// specified in the format `projects/*/locations/*`
        /// </param>
        /// <param name="function">
        /// Required. Function to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CloudFunction, OperationMetadataV1>> CreateFunctionAsync(string location, CloudFunction function, gaxgrpc::CallSettings callSettings = null) =>
            CreateFunctionAsync(new CreateFunctionRequest
            {
                Location = gax::GaxPreconditions.CheckNotNullOrEmpty(location, nameof(location)),
                Function = gax::GaxPreconditions.CheckNotNull(function, nameof(function)),
            }, callSettings);

        /// <summary>
        /// Creates a new function. If a function with the given name already exists in
        /// the specified project, the long running operation will return
        /// `ALREADY_EXISTS` error.
        /// </summary>
        /// <param name="location">
        /// Required. The project and location in which the function should be created,
        /// specified in the format `projects/*/locations/*`
        /// </param>
        /// <param name="function">
        /// Required. Function to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CloudFunction, OperationMetadataV1>> CreateFunctionAsync(string location, CloudFunction function, st::CancellationToken cancellationToken) =>
            CreateFunctionAsync(location, function, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new function. If a function with the given name already exists in
        /// the specified project, the long running operation will return
        /// `ALREADY_EXISTS` error.
        /// </summary>
        /// <param name="location">
        /// Required. The project and location in which the function should be created,
        /// specified in the format `projects/*/locations/*`
        /// </param>
        /// <param name="function">
        /// Required. Function to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CloudFunction, OperationMetadataV1> CreateFunction(gagr::LocationName location, CloudFunction function, gaxgrpc::CallSettings callSettings = null) =>
            CreateFunction(new CreateFunctionRequest
            {
                LocationAsLocationName = gax::GaxPreconditions.CheckNotNull(location, nameof(location)),
                Function = gax::GaxPreconditions.CheckNotNull(function, nameof(function)),
            }, callSettings);

        /// <summary>
        /// Creates a new function. If a function with the given name already exists in
        /// the specified project, the long running operation will return
        /// `ALREADY_EXISTS` error.
        /// </summary>
        /// <param name="location">
        /// Required. The project and location in which the function should be created,
        /// specified in the format `projects/*/locations/*`
        /// </param>
        /// <param name="function">
        /// Required. Function to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CloudFunction, OperationMetadataV1>> CreateFunctionAsync(gagr::LocationName location, CloudFunction function, gaxgrpc::CallSettings callSettings = null) =>
            CreateFunctionAsync(new CreateFunctionRequest
            {
                LocationAsLocationName = gax::GaxPreconditions.CheckNotNull(location, nameof(location)),
                Function = gax::GaxPreconditions.CheckNotNull(function, nameof(function)),
            }, callSettings);

        /// <summary>
        /// Creates a new function. If a function with the given name already exists in
        /// the specified project, the long running operation will return
        /// `ALREADY_EXISTS` error.
        /// </summary>
        /// <param name="location">
        /// Required. The project and location in which the function should be created,
        /// specified in the format `projects/*/locations/*`
        /// </param>
        /// <param name="function">
        /// Required. Function to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CloudFunction, OperationMetadataV1>> CreateFunctionAsync(gagr::LocationName location, CloudFunction function, st::CancellationToken cancellationToken) =>
            CreateFunctionAsync(location, function, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates existing function.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CloudFunction, OperationMetadataV1> UpdateFunction(UpdateFunctionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates existing function.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CloudFunction, OperationMetadataV1>> UpdateFunctionAsync(UpdateFunctionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates existing function.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CloudFunction, OperationMetadataV1>> UpdateFunctionAsync(UpdateFunctionRequest request, st::CancellationToken cancellationToken) =>
            UpdateFunctionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateFunction</c>.</summary>
        public virtual lro::OperationsClient UpdateFunctionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateFunction</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CloudFunction, OperationMetadataV1> PollOnceUpdateFunction(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CloudFunction, OperationMetadataV1>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateFunctionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateFunction</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CloudFunction, OperationMetadataV1>> PollOnceUpdateFunctionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CloudFunction, OperationMetadataV1>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateFunctionOperationsClient, callSettings);

        /// <summary>
        /// Updates existing function.
        /// </summary>
        /// <param name="function">
        /// Required. New version of the function.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CloudFunction, OperationMetadataV1> UpdateFunction(CloudFunction function, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFunction(new UpdateFunctionRequest
            {
                Function = gax::GaxPreconditions.CheckNotNull(function, nameof(function)),
            }, callSettings);

        /// <summary>
        /// Updates existing function.
        /// </summary>
        /// <param name="function">
        /// Required. New version of the function.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CloudFunction, OperationMetadataV1>> UpdateFunctionAsync(CloudFunction function, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFunctionAsync(new UpdateFunctionRequest
            {
                Function = gax::GaxPreconditions.CheckNotNull(function, nameof(function)),
            }, callSettings);

        /// <summary>
        /// Updates existing function.
        /// </summary>
        /// <param name="function">
        /// Required. New version of the function.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CloudFunction, OperationMetadataV1>> UpdateFunctionAsync(CloudFunction function, st::CancellationToken cancellationToken) =>
            UpdateFunctionAsync(function, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a function with the given name from the specified project. If the
        /// given function is used by some trigger, the trigger will be updated to
        /// remove this function.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadataV1> DeleteFunction(DeleteFunctionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a function with the given name from the specified project. If the
        /// given function is used by some trigger, the trigger will be updated to
        /// remove this function.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadataV1>> DeleteFunctionAsync(DeleteFunctionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a function with the given name from the specified project. If the
        /// given function is used by some trigger, the trigger will be updated to
        /// remove this function.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadataV1>> DeleteFunctionAsync(DeleteFunctionRequest request, st::CancellationToken cancellationToken) =>
            DeleteFunctionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteFunction</c>.</summary>
        public virtual lro::OperationsClient DeleteFunctionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteFunction</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadataV1> PollOnceDeleteFunction(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadataV1>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteFunctionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteFunction</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadataV1>> PollOnceDeleteFunctionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadataV1>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteFunctionOperationsClient, callSettings);

        /// <summary>
        /// Deletes a function with the given name from the specified project. If the
        /// given function is used by some trigger, the trigger will be updated to
        /// remove this function.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the function which should be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadataV1> DeleteFunction(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFunction(new DeleteFunctionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a function with the given name from the specified project. If the
        /// given function is used by some trigger, the trigger will be updated to
        /// remove this function.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the function which should be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadataV1>> DeleteFunctionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFunctionAsync(new DeleteFunctionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a function with the given name from the specified project. If the
        /// given function is used by some trigger, the trigger will be updated to
        /// remove this function.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the function which should be deleted.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadataV1>> DeleteFunctionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteFunctionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a function with the given name from the specified project. If the
        /// given function is used by some trigger, the trigger will be updated to
        /// remove this function.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the function which should be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadataV1> DeleteFunction(CloudFunctionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFunction(new DeleteFunctionRequest
            {
                CloudFunctionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a function with the given name from the specified project. If the
        /// given function is used by some trigger, the trigger will be updated to
        /// remove this function.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the function which should be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadataV1>> DeleteFunctionAsync(CloudFunctionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFunctionAsync(new DeleteFunctionRequest
            {
                CloudFunctionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a function with the given name from the specified project. If the
        /// given function is used by some trigger, the trigger will be updated to
        /// remove this function.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the function which should be deleted.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadataV1>> DeleteFunctionAsync(CloudFunctionName name, st::CancellationToken cancellationToken) =>
            DeleteFunctionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Synchronously invokes a deployed Cloud Function. To be used for testing
        /// purposes as very limited traffic is allowed. For more information on
        /// the actual limits, refer to
        /// [Rate Limits](https://cloud.google.com/functions/quotas#rate_limits).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CallFunctionResponse CallFunction(CallFunctionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Synchronously invokes a deployed Cloud Function. To be used for testing
        /// purposes as very limited traffic is allowed. For more information on
        /// the actual limits, refer to
        /// [Rate Limits](https://cloud.google.com/functions/quotas#rate_limits).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CallFunctionResponse> CallFunctionAsync(CallFunctionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Synchronously invokes a deployed Cloud Function. To be used for testing
        /// purposes as very limited traffic is allowed. For more information on
        /// the actual limits, refer to
        /// [Rate Limits](https://cloud.google.com/functions/quotas#rate_limits).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CallFunctionResponse> CallFunctionAsync(CallFunctionRequest request, st::CancellationToken cancellationToken) =>
            CallFunctionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Synchronously invokes a deployed Cloud Function. To be used for testing
        /// purposes as very limited traffic is allowed. For more information on
        /// the actual limits, refer to
        /// [Rate Limits](https://cloud.google.com/functions/quotas#rate_limits).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the function to be called.
        /// </param>
        /// <param name="data">
        /// Required. Input to be passed to the function.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CallFunctionResponse CallFunction(string name, string data, gaxgrpc::CallSettings callSettings = null) =>
            CallFunction(new CallFunctionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Data = gax::GaxPreconditions.CheckNotNullOrEmpty(data, nameof(data)),
            }, callSettings);

        /// <summary>
        /// Synchronously invokes a deployed Cloud Function. To be used for testing
        /// purposes as very limited traffic is allowed. For more information on
        /// the actual limits, refer to
        /// [Rate Limits](https://cloud.google.com/functions/quotas#rate_limits).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the function to be called.
        /// </param>
        /// <param name="data">
        /// Required. Input to be passed to the function.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CallFunctionResponse> CallFunctionAsync(string name, string data, gaxgrpc::CallSettings callSettings = null) =>
            CallFunctionAsync(new CallFunctionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Data = gax::GaxPreconditions.CheckNotNullOrEmpty(data, nameof(data)),
            }, callSettings);

        /// <summary>
        /// Synchronously invokes a deployed Cloud Function. To be used for testing
        /// purposes as very limited traffic is allowed. For more information on
        /// the actual limits, refer to
        /// [Rate Limits](https://cloud.google.com/functions/quotas#rate_limits).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the function to be called.
        /// </param>
        /// <param name="data">
        /// Required. Input to be passed to the function.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CallFunctionResponse> CallFunctionAsync(string name, string data, st::CancellationToken cancellationToken) =>
            CallFunctionAsync(name, data, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Synchronously invokes a deployed Cloud Function. To be used for testing
        /// purposes as very limited traffic is allowed. For more information on
        /// the actual limits, refer to
        /// [Rate Limits](https://cloud.google.com/functions/quotas#rate_limits).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the function to be called.
        /// </param>
        /// <param name="data">
        /// Required. Input to be passed to the function.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CallFunctionResponse CallFunction(CloudFunctionName name, string data, gaxgrpc::CallSettings callSettings = null) =>
            CallFunction(new CallFunctionRequest
            {
                CloudFunctionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Data = gax::GaxPreconditions.CheckNotNullOrEmpty(data, nameof(data)),
            }, callSettings);

        /// <summary>
        /// Synchronously invokes a deployed Cloud Function. To be used for testing
        /// purposes as very limited traffic is allowed. For more information on
        /// the actual limits, refer to
        /// [Rate Limits](https://cloud.google.com/functions/quotas#rate_limits).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the function to be called.
        /// </param>
        /// <param name="data">
        /// Required. Input to be passed to the function.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CallFunctionResponse> CallFunctionAsync(CloudFunctionName name, string data, gaxgrpc::CallSettings callSettings = null) =>
            CallFunctionAsync(new CallFunctionRequest
            {
                CloudFunctionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Data = gax::GaxPreconditions.CheckNotNullOrEmpty(data, nameof(data)),
            }, callSettings);

        /// <summary>
        /// Synchronously invokes a deployed Cloud Function. To be used for testing
        /// purposes as very limited traffic is allowed. For more information on
        /// the actual limits, refer to
        /// [Rate Limits](https://cloud.google.com/functions/quotas#rate_limits).
        /// </summary>
        /// <param name="name">
        /// Required. The name of the function to be called.
        /// </param>
        /// <param name="data">
        /// Required. Input to be passed to the function.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CallFunctionResponse> CallFunctionAsync(CloudFunctionName name, string data, st::CancellationToken cancellationToken) =>
            CallFunctionAsync(name, data, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a signed URL for uploading a function source code.
        /// For more information about the signed URL usage see:
        /// https://cloud.google.com/storage/docs/access-control/signed-urls.
        /// Once the function source code upload is complete, the used signed
        /// URL should be provided in CreateFunction or UpdateFunction request
        /// as a reference to the function source code.
        /// 
        /// When uploading source code to the generated signed URL, please follow
        /// these restrictions:
        /// 
        /// * Source file type should be a zip file.
        /// * Source file size should not exceed 100MB limit.
        /// * No credentials should be attached - the signed URLs provide access to the
        /// target bucket using internal service identity; if credentials were
        /// attached, the identity from the credentials would be used, but that
        /// identity does not have permissions to upload files to the URL.
        /// 
        /// When making a HTTP PUT request, these two headers need to be specified:
        /// 
        /// * `content-type: application/zip`
        /// * `x-goog-content-length-range: 0,104857600`
        /// 
        /// And this header SHOULD NOT be specified:
        /// 
        /// * `Authorization: Bearer YOUR_TOKEN`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateUploadUrlResponse GenerateUploadUrl(GenerateUploadUrlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a signed URL for uploading a function source code.
        /// For more information about the signed URL usage see:
        /// https://cloud.google.com/storage/docs/access-control/signed-urls.
        /// Once the function source code upload is complete, the used signed
        /// URL should be provided in CreateFunction or UpdateFunction request
        /// as a reference to the function source code.
        /// 
        /// When uploading source code to the generated signed URL, please follow
        /// these restrictions:
        /// 
        /// * Source file type should be a zip file.
        /// * Source file size should not exceed 100MB limit.
        /// * No credentials should be attached - the signed URLs provide access to the
        /// target bucket using internal service identity; if credentials were
        /// attached, the identity from the credentials would be used, but that
        /// identity does not have permissions to upload files to the URL.
        /// 
        /// When making a HTTP PUT request, these two headers need to be specified:
        /// 
        /// * `content-type: application/zip`
        /// * `x-goog-content-length-range: 0,104857600`
        /// 
        /// And this header SHOULD NOT be specified:
        /// 
        /// * `Authorization: Bearer YOUR_TOKEN`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateUploadUrlResponse> GenerateUploadUrlAsync(GenerateUploadUrlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a signed URL for uploading a function source code.
        /// For more information about the signed URL usage see:
        /// https://cloud.google.com/storage/docs/access-control/signed-urls.
        /// Once the function source code upload is complete, the used signed
        /// URL should be provided in CreateFunction or UpdateFunction request
        /// as a reference to the function source code.
        /// 
        /// When uploading source code to the generated signed URL, please follow
        /// these restrictions:
        /// 
        /// * Source file type should be a zip file.
        /// * Source file size should not exceed 100MB limit.
        /// * No credentials should be attached - the signed URLs provide access to the
        /// target bucket using internal service identity; if credentials were
        /// attached, the identity from the credentials would be used, but that
        /// identity does not have permissions to upload files to the URL.
        /// 
        /// When making a HTTP PUT request, these two headers need to be specified:
        /// 
        /// * `content-type: application/zip`
        /// * `x-goog-content-length-range: 0,104857600`
        /// 
        /// And this header SHOULD NOT be specified:
        /// 
        /// * `Authorization: Bearer YOUR_TOKEN`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateUploadUrlResponse> GenerateUploadUrlAsync(GenerateUploadUrlRequest request, st::CancellationToken cancellationToken) =>
            GenerateUploadUrlAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a signed URL for downloading deployed function source code.
        /// The URL is only valid for a limited period and should be used within
        /// minutes after generation.
        /// For more information about the signed URL usage see:
        /// https://cloud.google.com/storage/docs/access-control/signed-urls
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateDownloadUrlResponse GenerateDownloadUrl(GenerateDownloadUrlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a signed URL for downloading deployed function source code.
        /// The URL is only valid for a limited period and should be used within
        /// minutes after generation.
        /// For more information about the signed URL usage see:
        /// https://cloud.google.com/storage/docs/access-control/signed-urls
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateDownloadUrlResponse> GenerateDownloadUrlAsync(GenerateDownloadUrlRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a signed URL for downloading deployed function source code.
        /// The URL is only valid for a limited period and should be used within
        /// minutes after generation.
        /// For more information about the signed URL usage see:
        /// https://cloud.google.com/storage/docs/access-control/signed-urls
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateDownloadUrlResponse> GenerateDownloadUrlAsync(GenerateDownloadUrlRequest request, st::CancellationToken cancellationToken) =>
            GenerateDownloadUrlAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the IAM access control policy on the specified function.
        /// Replaces any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the IAM access control policy on the specified function.
        /// Replaces any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the IAM access control policy on the specified function.
        /// Replaces any existing policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the IAM access control policy for a function.
        /// Returns an empty policy if the function exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the IAM access control policy for a function.
        /// Returns an empty policy if the function exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the IAM access control policy for a function.
        /// Returns an empty policy if the function exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Tests the specified permissions against the IAM access control policy
        /// for a function.
        /// If the function does not exist, this will return an empty set of
        /// permissions, not a NOT_FOUND error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Tests the specified permissions against the IAM access control policy
        /// for a function.
        /// If the function does not exist, this will return an empty set of
        /// permissions, not a NOT_FOUND error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Tests the specified permissions against the IAM access control policy
        /// for a function.
        /// If the function does not exist, this will return an empty set of
        /// permissions, not a NOT_FOUND error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CloudFunctionsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service that application uses to manipulate triggers and functions.
    /// </remarks>
    public sealed partial class CloudFunctionsServiceClientImpl : CloudFunctionsServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListFunctionsRequest, ListFunctionsResponse> _callListFunctions;

        private readonly gaxgrpc::ApiCall<GetFunctionRequest, CloudFunction> _callGetFunction;

        private readonly gaxgrpc::ApiCall<CreateFunctionRequest, lro::Operation> _callCreateFunction;

        private readonly gaxgrpc::ApiCall<UpdateFunctionRequest, lro::Operation> _callUpdateFunction;

        private readonly gaxgrpc::ApiCall<DeleteFunctionRequest, lro::Operation> _callDeleteFunction;

        private readonly gaxgrpc::ApiCall<CallFunctionRequest, CallFunctionResponse> _callCallFunction;

        private readonly gaxgrpc::ApiCall<GenerateUploadUrlRequest, GenerateUploadUrlResponse> _callGenerateUploadUrl;

        private readonly gaxgrpc::ApiCall<GenerateDownloadUrlRequest, GenerateDownloadUrlResponse> _callGenerateDownloadUrl;

        private readonly gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> _callSetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> _callGetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> _callTestIamPermissions;

        /// <summary>
        /// Constructs a client wrapper for the CloudFunctionsService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CloudFunctionsServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CloudFunctionsServiceClientImpl(CloudFunctionsService.CloudFunctionsServiceClient grpcClient, CloudFunctionsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CloudFunctionsServiceSettings effectiveSettings = settings ?? CloudFunctionsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateFunctionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateFunctionOperationsSettings, logger);
            UpdateFunctionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateFunctionOperationsSettings, logger);
            DeleteFunctionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteFunctionOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListFunctions = clientHelper.BuildApiCall<ListFunctionsRequest, ListFunctionsResponse>("ListFunctions", grpcClient.ListFunctionsAsync, grpcClient.ListFunctions, effectiveSettings.ListFunctionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListFunctions);
            Modify_ListFunctionsApiCall(ref _callListFunctions);
            _callGetFunction = clientHelper.BuildApiCall<GetFunctionRequest, CloudFunction>("GetFunction", grpcClient.GetFunctionAsync, grpcClient.GetFunction, effectiveSettings.GetFunctionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetFunction);
            Modify_GetFunctionApiCall(ref _callGetFunction);
            _callCreateFunction = clientHelper.BuildApiCall<CreateFunctionRequest, lro::Operation>("CreateFunction", grpcClient.CreateFunctionAsync, grpcClient.CreateFunction, effectiveSettings.CreateFunctionSettings).WithGoogleRequestParam("location", request => request.Location);
            Modify_ApiCall(ref _callCreateFunction);
            Modify_CreateFunctionApiCall(ref _callCreateFunction);
            _callUpdateFunction = clientHelper.BuildApiCall<UpdateFunctionRequest, lro::Operation>("UpdateFunction", grpcClient.UpdateFunctionAsync, grpcClient.UpdateFunction, effectiveSettings.UpdateFunctionSettings).WithGoogleRequestParam("function.name", request => request.Function?.Name);
            Modify_ApiCall(ref _callUpdateFunction);
            Modify_UpdateFunctionApiCall(ref _callUpdateFunction);
            _callDeleteFunction = clientHelper.BuildApiCall<DeleteFunctionRequest, lro::Operation>("DeleteFunction", grpcClient.DeleteFunctionAsync, grpcClient.DeleteFunction, effectiveSettings.DeleteFunctionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteFunction);
            Modify_DeleteFunctionApiCall(ref _callDeleteFunction);
            _callCallFunction = clientHelper.BuildApiCall<CallFunctionRequest, CallFunctionResponse>("CallFunction", grpcClient.CallFunctionAsync, grpcClient.CallFunction, effectiveSettings.CallFunctionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCallFunction);
            Modify_CallFunctionApiCall(ref _callCallFunction);
            _callGenerateUploadUrl = clientHelper.BuildApiCall<GenerateUploadUrlRequest, GenerateUploadUrlResponse>("GenerateUploadUrl", grpcClient.GenerateUploadUrlAsync, grpcClient.GenerateUploadUrl, effectiveSettings.GenerateUploadUrlSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callGenerateUploadUrl);
            Modify_GenerateUploadUrlApiCall(ref _callGenerateUploadUrl);
            _callGenerateDownloadUrl = clientHelper.BuildApiCall<GenerateDownloadUrlRequest, GenerateDownloadUrlResponse>("GenerateDownloadUrl", grpcClient.GenerateDownloadUrlAsync, grpcClient.GenerateDownloadUrl, effectiveSettings.GenerateDownloadUrlSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGenerateDownloadUrl);
            Modify_GenerateDownloadUrlApiCall(ref _callGenerateDownloadUrl);
            _callSetIamPolicy = clientHelper.BuildApiCall<gciv::SetIamPolicyRequest, gciv::Policy>("SetIamPolicy", grpcClient.SetIamPolicyAsync, grpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            _callGetIamPolicy = clientHelper.BuildApiCall<gciv::GetIamPolicyRequest, gciv::Policy>("GetIamPolicy", grpcClient.GetIamPolicyAsync, grpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            _callTestIamPermissions = clientHelper.BuildApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse>("TestIamPermissions", grpcClient.TestIamPermissionsAsync, grpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListFunctionsApiCall(ref gaxgrpc::ApiCall<ListFunctionsRequest, ListFunctionsResponse> call);

        partial void Modify_GetFunctionApiCall(ref gaxgrpc::ApiCall<GetFunctionRequest, CloudFunction> call);

        partial void Modify_CreateFunctionApiCall(ref gaxgrpc::ApiCall<CreateFunctionRequest, lro::Operation> call);

        partial void Modify_UpdateFunctionApiCall(ref gaxgrpc::ApiCall<UpdateFunctionRequest, lro::Operation> call);

        partial void Modify_DeleteFunctionApiCall(ref gaxgrpc::ApiCall<DeleteFunctionRequest, lro::Operation> call);

        partial void Modify_CallFunctionApiCall(ref gaxgrpc::ApiCall<CallFunctionRequest, CallFunctionResponse> call);

        partial void Modify_GenerateUploadUrlApiCall(ref gaxgrpc::ApiCall<GenerateUploadUrlRequest, GenerateUploadUrlResponse> call);

        partial void Modify_GenerateDownloadUrlApiCall(ref gaxgrpc::ApiCall<GenerateDownloadUrlRequest, GenerateDownloadUrlResponse> call);

        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> call);

        partial void OnConstruction(CloudFunctionsService.CloudFunctionsServiceClient grpcClient, CloudFunctionsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CloudFunctionsService client</summary>
        public override CloudFunctionsService.CloudFunctionsServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListFunctionsRequest(ref ListFunctionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetFunctionRequest(ref GetFunctionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateFunctionRequest(ref CreateFunctionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateFunctionRequest(ref UpdateFunctionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteFunctionRequest(ref DeleteFunctionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CallFunctionRequest(ref CallFunctionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateUploadUrlRequest(ref GenerateUploadUrlRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateDownloadUrlRequest(ref GenerateDownloadUrlRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetIamPolicyRequest(ref gciv::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIamPolicyRequest(ref gciv::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsRequest(ref gciv::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns a list of functions that belong to the requested project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CloudFunction"/> resources.</returns>
        public override gax::PagedEnumerable<ListFunctionsResponse, CloudFunction> ListFunctions(ListFunctionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFunctionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListFunctionsRequest, ListFunctionsResponse, CloudFunction>(_callListFunctions, request, callSettings);
        }

        /// <summary>
        /// Returns a list of functions that belong to the requested project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CloudFunction"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListFunctionsResponse, CloudFunction> ListFunctionsAsync(ListFunctionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFunctionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListFunctionsRequest, ListFunctionsResponse, CloudFunction>(_callListFunctions, request, callSettings);
        }

        /// <summary>
        /// Returns a function with the given name from the requested project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CloudFunction GetFunction(GetFunctionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFunctionRequest(ref request, ref callSettings);
            return _callGetFunction.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a function with the given name from the requested project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CloudFunction> GetFunctionAsync(GetFunctionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFunctionRequest(ref request, ref callSettings);
            return _callGetFunction.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateFunction</c>.</summary>
        public override lro::OperationsClient CreateFunctionOperationsClient { get; }

        /// <summary>
        /// Creates a new function. If a function with the given name already exists in
        /// the specified project, the long running operation will return
        /// `ALREADY_EXISTS` error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CloudFunction, OperationMetadataV1> CreateFunction(CreateFunctionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFunctionRequest(ref request, ref callSettings);
            return new lro::Operation<CloudFunction, OperationMetadataV1>(_callCreateFunction.Sync(request, callSettings), CreateFunctionOperationsClient);
        }

        /// <summary>
        /// Creates a new function. If a function with the given name already exists in
        /// the specified project, the long running operation will return
        /// `ALREADY_EXISTS` error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CloudFunction, OperationMetadataV1>> CreateFunctionAsync(CreateFunctionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFunctionRequest(ref request, ref callSettings);
            return new lro::Operation<CloudFunction, OperationMetadataV1>(await _callCreateFunction.Async(request, callSettings).ConfigureAwait(false), CreateFunctionOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateFunction</c>.</summary>
        public override lro::OperationsClient UpdateFunctionOperationsClient { get; }

        /// <summary>
        /// Updates existing function.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CloudFunction, OperationMetadataV1> UpdateFunction(UpdateFunctionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFunctionRequest(ref request, ref callSettings);
            return new lro::Operation<CloudFunction, OperationMetadataV1>(_callUpdateFunction.Sync(request, callSettings), UpdateFunctionOperationsClient);
        }

        /// <summary>
        /// Updates existing function.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CloudFunction, OperationMetadataV1>> UpdateFunctionAsync(UpdateFunctionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFunctionRequest(ref request, ref callSettings);
            return new lro::Operation<CloudFunction, OperationMetadataV1>(await _callUpdateFunction.Async(request, callSettings).ConfigureAwait(false), UpdateFunctionOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteFunction</c>.</summary>
        public override lro::OperationsClient DeleteFunctionOperationsClient { get; }

        /// <summary>
        /// Deletes a function with the given name from the specified project. If the
        /// given function is used by some trigger, the trigger will be updated to
        /// remove this function.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadataV1> DeleteFunction(DeleteFunctionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFunctionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadataV1>(_callDeleteFunction.Sync(request, callSettings), DeleteFunctionOperationsClient);
        }

        /// <summary>
        /// Deletes a function with the given name from the specified project. If the
        /// given function is used by some trigger, the trigger will be updated to
        /// remove this function.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadataV1>> DeleteFunctionAsync(DeleteFunctionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFunctionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadataV1>(await _callDeleteFunction.Async(request, callSettings).ConfigureAwait(false), DeleteFunctionOperationsClient);
        }

        /// <summary>
        /// Synchronously invokes a deployed Cloud Function. To be used for testing
        /// purposes as very limited traffic is allowed. For more information on
        /// the actual limits, refer to
        /// [Rate Limits](https://cloud.google.com/functions/quotas#rate_limits).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CallFunctionResponse CallFunction(CallFunctionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CallFunctionRequest(ref request, ref callSettings);
            return _callCallFunction.Sync(request, callSettings);
        }

        /// <summary>
        /// Synchronously invokes a deployed Cloud Function. To be used for testing
        /// purposes as very limited traffic is allowed. For more information on
        /// the actual limits, refer to
        /// [Rate Limits](https://cloud.google.com/functions/quotas#rate_limits).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CallFunctionResponse> CallFunctionAsync(CallFunctionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CallFunctionRequest(ref request, ref callSettings);
            return _callCallFunction.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a signed URL for uploading a function source code.
        /// For more information about the signed URL usage see:
        /// https://cloud.google.com/storage/docs/access-control/signed-urls.
        /// Once the function source code upload is complete, the used signed
        /// URL should be provided in CreateFunction or UpdateFunction request
        /// as a reference to the function source code.
        /// 
        /// When uploading source code to the generated signed URL, please follow
        /// these restrictions:
        /// 
        /// * Source file type should be a zip file.
        /// * Source file size should not exceed 100MB limit.
        /// * No credentials should be attached - the signed URLs provide access to the
        /// target bucket using internal service identity; if credentials were
        /// attached, the identity from the credentials would be used, but that
        /// identity does not have permissions to upload files to the URL.
        /// 
        /// When making a HTTP PUT request, these two headers need to be specified:
        /// 
        /// * `content-type: application/zip`
        /// * `x-goog-content-length-range: 0,104857600`
        /// 
        /// And this header SHOULD NOT be specified:
        /// 
        /// * `Authorization: Bearer YOUR_TOKEN`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateUploadUrlResponse GenerateUploadUrl(GenerateUploadUrlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateUploadUrlRequest(ref request, ref callSettings);
            return _callGenerateUploadUrl.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a signed URL for uploading a function source code.
        /// For more information about the signed URL usage see:
        /// https://cloud.google.com/storage/docs/access-control/signed-urls.
        /// Once the function source code upload is complete, the used signed
        /// URL should be provided in CreateFunction or UpdateFunction request
        /// as a reference to the function source code.
        /// 
        /// When uploading source code to the generated signed URL, please follow
        /// these restrictions:
        /// 
        /// * Source file type should be a zip file.
        /// * Source file size should not exceed 100MB limit.
        /// * No credentials should be attached - the signed URLs provide access to the
        /// target bucket using internal service identity; if credentials were
        /// attached, the identity from the credentials would be used, but that
        /// identity does not have permissions to upload files to the URL.
        /// 
        /// When making a HTTP PUT request, these two headers need to be specified:
        /// 
        /// * `content-type: application/zip`
        /// * `x-goog-content-length-range: 0,104857600`
        /// 
        /// And this header SHOULD NOT be specified:
        /// 
        /// * `Authorization: Bearer YOUR_TOKEN`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateUploadUrlResponse> GenerateUploadUrlAsync(GenerateUploadUrlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateUploadUrlRequest(ref request, ref callSettings);
            return _callGenerateUploadUrl.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a signed URL for downloading deployed function source code.
        /// The URL is only valid for a limited period and should be used within
        /// minutes after generation.
        /// For more information about the signed URL usage see:
        /// https://cloud.google.com/storage/docs/access-control/signed-urls
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateDownloadUrlResponse GenerateDownloadUrl(GenerateDownloadUrlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateDownloadUrlRequest(ref request, ref callSettings);
            return _callGenerateDownloadUrl.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a signed URL for downloading deployed function source code.
        /// The URL is only valid for a limited period and should be used within
        /// minutes after generation.
        /// For more information about the signed URL usage see:
        /// https://cloud.google.com/storage/docs/access-control/signed-urls
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateDownloadUrlResponse> GenerateDownloadUrlAsync(GenerateDownloadUrlRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateDownloadUrlRequest(ref request, ref callSettings);
            return _callGenerateDownloadUrl.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the IAM access control policy on the specified function.
        /// Replaces any existing policy.
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
        /// Sets the IAM access control policy on the specified function.
        /// Replaces any existing policy.
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
        /// Gets the IAM access control policy for a function.
        /// Returns an empty policy if the function exists and does not have a policy
        /// set.
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
        /// Gets the IAM access control policy for a function.
        /// Returns an empty policy if the function exists and does not have a policy
        /// set.
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
        /// Tests the specified permissions against the IAM access control policy
        /// for a function.
        /// If the function does not exist, this will return an empty set of
        /// permissions, not a NOT_FOUND error.
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
        /// Tests the specified permissions against the IAM access control policy
        /// for a function.
        /// If the function does not exist, this will return an empty set of
        /// permissions, not a NOT_FOUND error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }
    }

    public partial class ListFunctionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListFunctionsResponse : gaxgrpc::IPageResponse<CloudFunction>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CloudFunction> GetEnumerator() => Functions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class CloudFunctionsService
    {
        public partial class CloudFunctionsServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() =>
                new lro::Operations.OperationsClient(CallInvoker);
        }
    }

    public static partial class CloudFunctionsService
    {
        public partial class CloudFunctionsServiceClient
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

            /// <summary>
            /// Creates a new instance of <see cref="gciv::IAMPolicy.IAMPolicyClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gciv::IAMPolicy.IAMPolicyClient"/> for the same target as this client.
            /// </returns>
            public virtual gciv::IAMPolicy.IAMPolicyClient CreateIAMPolicyClient() =>
                new gciv::IAMPolicy.IAMPolicyClient(CallInvoker);
        }
    }
}
