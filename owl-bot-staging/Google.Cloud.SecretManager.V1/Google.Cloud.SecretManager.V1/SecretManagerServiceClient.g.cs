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
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.SecretManager.V1
{
    /// <summary>Settings for <see cref="SecretManagerServiceClient"/> instances.</summary>
    public sealed partial class SecretManagerServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SecretManagerServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SecretManagerServiceSettings"/>.</returns>
        public static SecretManagerServiceSettings GetDefault() => new SecretManagerServiceSettings();

        /// <summary>Constructs a new <see cref="SecretManagerServiceSettings"/> object with default settings.</summary>
        public SecretManagerServiceSettings()
        {
        }

        private SecretManagerServiceSettings(SecretManagerServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListSecretsSettings = existing.ListSecretsSettings;
            CreateSecretSettings = existing.CreateSecretSettings;
            AddSecretVersionSettings = existing.AddSecretVersionSettings;
            GetSecretSettings = existing.GetSecretSettings;
            UpdateSecretSettings = existing.UpdateSecretSettings;
            DeleteSecretSettings = existing.DeleteSecretSettings;
            ListSecretVersionsSettings = existing.ListSecretVersionsSettings;
            GetSecretVersionSettings = existing.GetSecretVersionSettings;
            AccessSecretVersionSettings = existing.AccessSecretVersionSettings;
            DisableSecretVersionSettings = existing.DisableSecretVersionSettings;
            EnableSecretVersionSettings = existing.EnableSecretVersionSettings;
            DestroySecretVersionSettings = existing.DestroySecretVersionSettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SecretManagerServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecretManagerServiceClient.ListSecrets</c> and <c>SecretManagerServiceClient.ListSecretsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSecretsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecretManagerServiceClient.CreateSecret</c> and <c>SecretManagerServiceClient.CreateSecretAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSecretSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecretManagerServiceClient.AddSecretVersion</c> and <c>SecretManagerServiceClient.AddSecretVersionAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AddSecretVersionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecretManagerServiceClient.GetSecret</c> and <c>SecretManagerServiceClient.GetSecretAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSecretSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecretManagerServiceClient.UpdateSecret</c> and <c>SecretManagerServiceClient.UpdateSecretAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSecretSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecretManagerServiceClient.DeleteSecret</c> and <c>SecretManagerServiceClient.DeleteSecretAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSecretSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecretManagerServiceClient.ListSecretVersions</c> and
        /// <c>SecretManagerServiceClient.ListSecretVersionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSecretVersionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecretManagerServiceClient.GetSecretVersion</c> and <c>SecretManagerServiceClient.GetSecretVersionAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSecretVersionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecretManagerServiceClient.AccessSecretVersion</c> and
        /// <c>SecretManagerServiceClient.AccessSecretVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 2000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AccessSecretVersionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(2000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecretManagerServiceClient.DisableSecretVersion</c> and
        /// <c>SecretManagerServiceClient.DisableSecretVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DisableSecretVersionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecretManagerServiceClient.EnableSecretVersion</c> and
        /// <c>SecretManagerServiceClient.EnableSecretVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings EnableSecretVersionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecretManagerServiceClient.DestroySecretVersion</c> and
        /// <c>SecretManagerServiceClient.DestroySecretVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DestroySecretVersionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecretManagerServiceClient.SetIamPolicy</c> and <c>SecretManagerServiceClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecretManagerServiceClient.GetIamPolicy</c> and <c>SecretManagerServiceClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecretManagerServiceClient.TestIamPermissions</c> and
        /// <c>SecretManagerServiceClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SecretManagerServiceSettings"/> object.</returns>
        public SecretManagerServiceSettings Clone() => new SecretManagerServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SecretManagerServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class SecretManagerServiceClientBuilder : gaxgrpc::ClientBuilderBase<SecretManagerServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SecretManagerServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SecretManagerServiceClientBuilder() : base(SecretManagerServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SecretManagerServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SecretManagerServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SecretManagerServiceClient Build()
        {
            SecretManagerServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SecretManagerServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SecretManagerServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SecretManagerServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SecretManagerServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SecretManagerServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SecretManagerServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SecretManagerServiceClient.ChannelPool;
    }

    /// <summary>SecretManagerService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Secret Manager Service
    /// 
    /// Manages secrets and operations using those secrets. Implements a REST
    /// model with the following objects:
    /// 
    /// * [Secret][google.cloud.secretmanager.v1.Secret]
    /// * [SecretVersion][google.cloud.secretmanager.v1.SecretVersion]
    /// </remarks>
    public abstract partial class SecretManagerServiceClient
    {
        /// <summary>
        /// The default endpoint for the SecretManagerService service, which is a host of "secretmanager.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "secretmanager.googleapis.com:443";

        /// <summary>The default SecretManagerService scopes.</summary>
        /// <remarks>
        /// The default SecretManagerService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SecretManagerService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SecretManagerServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="SecretManagerServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SecretManagerServiceClient"/>.</returns>
        public static stt::Task<SecretManagerServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SecretManagerServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SecretManagerServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="SecretManagerServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SecretManagerServiceClient"/>.</returns>
        public static SecretManagerServiceClient Create() => new SecretManagerServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SecretManagerServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SecretManagerServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SecretManagerServiceClient"/>.</returns>
        internal static SecretManagerServiceClient Create(grpccore::CallInvoker callInvoker, SecretManagerServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SecretManagerService.SecretManagerServiceClient grpcClient = new SecretManagerService.SecretManagerServiceClient(callInvoker);
            return new SecretManagerServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC SecretManagerService client</summary>
        public virtual SecretManagerService.SecretManagerServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [Secrets][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Secret"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSecretsResponse, Secret> ListSecrets(ListSecretsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [Secrets][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Secret"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSecretsResponse, Secret> ListSecretsAsync(ListSecretsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [Secrets][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project associated with the
        /// [Secrets][google.cloud.secretmanager.v1.Secret], in the format `projects/*`
        /// or `projects/*/locations/*`
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
        /// <returns>A pageable sequence of <see cref="Secret"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSecretsResponse, Secret> ListSecrets(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecretsRequest request = new ListSecretsRequest
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
            return ListSecrets(request, callSettings);
        }

        /// <summary>
        /// Lists [Secrets][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project associated with the
        /// [Secrets][google.cloud.secretmanager.v1.Secret], in the format `projects/*`
        /// or `projects/*/locations/*`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Secret"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSecretsResponse, Secret> ListSecretsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecretsRequest request = new ListSecretsRequest
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
            return ListSecretsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists [Secrets][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project associated with the
        /// [Secrets][google.cloud.secretmanager.v1.Secret], in the format `projects/*`
        /// or `projects/*/locations/*`
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
        /// <returns>A pageable sequence of <see cref="Secret"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSecretsResponse, Secret> ListSecrets(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecretsRequest request = new ListSecretsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSecrets(request, callSettings);
        }

        /// <summary>
        /// Lists [Secrets][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project associated with the
        /// [Secrets][google.cloud.secretmanager.v1.Secret], in the format `projects/*`
        /// or `projects/*/locations/*`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Secret"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSecretsResponse, Secret> ListSecretsAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecretsRequest request = new ListSecretsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSecretsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists [Secrets][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project associated with the
        /// [Secrets][google.cloud.secretmanager.v1.Secret], in the format `projects/*`
        /// or `projects/*/locations/*`
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
        /// <returns>A pageable sequence of <see cref="Secret"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSecretsResponse, Secret> ListSecrets(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecretsRequest request = new ListSecretsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSecrets(request, callSettings);
        }

        /// <summary>
        /// Lists [Secrets][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project associated with the
        /// [Secrets][google.cloud.secretmanager.v1.Secret], in the format `projects/*`
        /// or `projects/*/locations/*`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Secret"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSecretsResponse, Secret> ListSecretsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecretsRequest request = new ListSecretsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSecretsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a new [Secret][google.cloud.secretmanager.v1.Secret] containing no
        /// [SecretVersions][google.cloud.secretmanager.v1.SecretVersion].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Secret CreateSecret(CreateSecretRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new [Secret][google.cloud.secretmanager.v1.Secret] containing no
        /// [SecretVersions][google.cloud.secretmanager.v1.SecretVersion].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Secret> CreateSecretAsync(CreateSecretRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new [Secret][google.cloud.secretmanager.v1.Secret] containing no
        /// [SecretVersions][google.cloud.secretmanager.v1.SecretVersion].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Secret> CreateSecretAsync(CreateSecretRequest request, st::CancellationToken cancellationToken) =>
            CreateSecretAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new [Secret][google.cloud.secretmanager.v1.Secret] containing no
        /// [SecretVersions][google.cloud.secretmanager.v1.SecretVersion].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project to associate with the
        /// [Secret][google.cloud.secretmanager.v1.Secret], in the format `projects/*`
        /// or `projects/*/locations/*`.
        /// </param>
        /// <param name="secretId">
        /// Required. This must be unique within the project.
        /// 
        /// A secret ID is a string with a maximum length of 255 characters and can
        /// contain uppercase and lowercase letters, numerals, and the hyphen (`-`) and
        /// underscore (`_`) characters.
        /// </param>
        /// <param name="secret">
        /// Required. A [Secret][google.cloud.secretmanager.v1.Secret] with initial
        /// field values.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Secret CreateSecret(string parent, string secretId, Secret secret, gaxgrpc::CallSettings callSettings = null) =>
            CreateSecret(new CreateSecretRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SecretId = gax::GaxPreconditions.CheckNotNullOrEmpty(secretId, nameof(secretId)),
                Secret = gax::GaxPreconditions.CheckNotNull(secret, nameof(secret)),
            }, callSettings);

        /// <summary>
        /// Creates a new [Secret][google.cloud.secretmanager.v1.Secret] containing no
        /// [SecretVersions][google.cloud.secretmanager.v1.SecretVersion].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project to associate with the
        /// [Secret][google.cloud.secretmanager.v1.Secret], in the format `projects/*`
        /// or `projects/*/locations/*`.
        /// </param>
        /// <param name="secretId">
        /// Required. This must be unique within the project.
        /// 
        /// A secret ID is a string with a maximum length of 255 characters and can
        /// contain uppercase and lowercase letters, numerals, and the hyphen (`-`) and
        /// underscore (`_`) characters.
        /// </param>
        /// <param name="secret">
        /// Required. A [Secret][google.cloud.secretmanager.v1.Secret] with initial
        /// field values.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Secret> CreateSecretAsync(string parent, string secretId, Secret secret, gaxgrpc::CallSettings callSettings = null) =>
            CreateSecretAsync(new CreateSecretRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SecretId = gax::GaxPreconditions.CheckNotNullOrEmpty(secretId, nameof(secretId)),
                Secret = gax::GaxPreconditions.CheckNotNull(secret, nameof(secret)),
            }, callSettings);

        /// <summary>
        /// Creates a new [Secret][google.cloud.secretmanager.v1.Secret] containing no
        /// [SecretVersions][google.cloud.secretmanager.v1.SecretVersion].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project to associate with the
        /// [Secret][google.cloud.secretmanager.v1.Secret], in the format `projects/*`
        /// or `projects/*/locations/*`.
        /// </param>
        /// <param name="secretId">
        /// Required. This must be unique within the project.
        /// 
        /// A secret ID is a string with a maximum length of 255 characters and can
        /// contain uppercase and lowercase letters, numerals, and the hyphen (`-`) and
        /// underscore (`_`) characters.
        /// </param>
        /// <param name="secret">
        /// Required. A [Secret][google.cloud.secretmanager.v1.Secret] with initial
        /// field values.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Secret> CreateSecretAsync(string parent, string secretId, Secret secret, st::CancellationToken cancellationToken) =>
            CreateSecretAsync(parent, secretId, secret, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new [Secret][google.cloud.secretmanager.v1.Secret] containing no
        /// [SecretVersions][google.cloud.secretmanager.v1.SecretVersion].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project to associate with the
        /// [Secret][google.cloud.secretmanager.v1.Secret], in the format `projects/*`
        /// or `projects/*/locations/*`.
        /// </param>
        /// <param name="secretId">
        /// Required. This must be unique within the project.
        /// 
        /// A secret ID is a string with a maximum length of 255 characters and can
        /// contain uppercase and lowercase letters, numerals, and the hyphen (`-`) and
        /// underscore (`_`) characters.
        /// </param>
        /// <param name="secret">
        /// Required. A [Secret][google.cloud.secretmanager.v1.Secret] with initial
        /// field values.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Secret CreateSecret(gagr::ProjectName parent, string secretId, Secret secret, gaxgrpc::CallSettings callSettings = null) =>
            CreateSecret(new CreateSecretRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SecretId = gax::GaxPreconditions.CheckNotNullOrEmpty(secretId, nameof(secretId)),
                Secret = gax::GaxPreconditions.CheckNotNull(secret, nameof(secret)),
            }, callSettings);

        /// <summary>
        /// Creates a new [Secret][google.cloud.secretmanager.v1.Secret] containing no
        /// [SecretVersions][google.cloud.secretmanager.v1.SecretVersion].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project to associate with the
        /// [Secret][google.cloud.secretmanager.v1.Secret], in the format `projects/*`
        /// or `projects/*/locations/*`.
        /// </param>
        /// <param name="secretId">
        /// Required. This must be unique within the project.
        /// 
        /// A secret ID is a string with a maximum length of 255 characters and can
        /// contain uppercase and lowercase letters, numerals, and the hyphen (`-`) and
        /// underscore (`_`) characters.
        /// </param>
        /// <param name="secret">
        /// Required. A [Secret][google.cloud.secretmanager.v1.Secret] with initial
        /// field values.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Secret> CreateSecretAsync(gagr::ProjectName parent, string secretId, Secret secret, gaxgrpc::CallSettings callSettings = null) =>
            CreateSecretAsync(new CreateSecretRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SecretId = gax::GaxPreconditions.CheckNotNullOrEmpty(secretId, nameof(secretId)),
                Secret = gax::GaxPreconditions.CheckNotNull(secret, nameof(secret)),
            }, callSettings);

        /// <summary>
        /// Creates a new [Secret][google.cloud.secretmanager.v1.Secret] containing no
        /// [SecretVersions][google.cloud.secretmanager.v1.SecretVersion].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project to associate with the
        /// [Secret][google.cloud.secretmanager.v1.Secret], in the format `projects/*`
        /// or `projects/*/locations/*`.
        /// </param>
        /// <param name="secretId">
        /// Required. This must be unique within the project.
        /// 
        /// A secret ID is a string with a maximum length of 255 characters and can
        /// contain uppercase and lowercase letters, numerals, and the hyphen (`-`) and
        /// underscore (`_`) characters.
        /// </param>
        /// <param name="secret">
        /// Required. A [Secret][google.cloud.secretmanager.v1.Secret] with initial
        /// field values.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Secret> CreateSecretAsync(gagr::ProjectName parent, string secretId, Secret secret, st::CancellationToken cancellationToken) =>
            CreateSecretAsync(parent, secretId, secret, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new [Secret][google.cloud.secretmanager.v1.Secret] containing no
        /// [SecretVersions][google.cloud.secretmanager.v1.SecretVersion].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project to associate with the
        /// [Secret][google.cloud.secretmanager.v1.Secret], in the format `projects/*`
        /// or `projects/*/locations/*`.
        /// </param>
        /// <param name="secretId">
        /// Required. This must be unique within the project.
        /// 
        /// A secret ID is a string with a maximum length of 255 characters and can
        /// contain uppercase and lowercase letters, numerals, and the hyphen (`-`) and
        /// underscore (`_`) characters.
        /// </param>
        /// <param name="secret">
        /// Required. A [Secret][google.cloud.secretmanager.v1.Secret] with initial
        /// field values.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Secret CreateSecret(gagr::LocationName parent, string secretId, Secret secret, gaxgrpc::CallSettings callSettings = null) =>
            CreateSecret(new CreateSecretRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SecretId = gax::GaxPreconditions.CheckNotNullOrEmpty(secretId, nameof(secretId)),
                Secret = gax::GaxPreconditions.CheckNotNull(secret, nameof(secret)),
            }, callSettings);

        /// <summary>
        /// Creates a new [Secret][google.cloud.secretmanager.v1.Secret] containing no
        /// [SecretVersions][google.cloud.secretmanager.v1.SecretVersion].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project to associate with the
        /// [Secret][google.cloud.secretmanager.v1.Secret], in the format `projects/*`
        /// or `projects/*/locations/*`.
        /// </param>
        /// <param name="secretId">
        /// Required. This must be unique within the project.
        /// 
        /// A secret ID is a string with a maximum length of 255 characters and can
        /// contain uppercase and lowercase letters, numerals, and the hyphen (`-`) and
        /// underscore (`_`) characters.
        /// </param>
        /// <param name="secret">
        /// Required. A [Secret][google.cloud.secretmanager.v1.Secret] with initial
        /// field values.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Secret> CreateSecretAsync(gagr::LocationName parent, string secretId, Secret secret, gaxgrpc::CallSettings callSettings = null) =>
            CreateSecretAsync(new CreateSecretRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SecretId = gax::GaxPreconditions.CheckNotNullOrEmpty(secretId, nameof(secretId)),
                Secret = gax::GaxPreconditions.CheckNotNull(secret, nameof(secret)),
            }, callSettings);

        /// <summary>
        /// Creates a new [Secret][google.cloud.secretmanager.v1.Secret] containing no
        /// [SecretVersions][google.cloud.secretmanager.v1.SecretVersion].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project to associate with the
        /// [Secret][google.cloud.secretmanager.v1.Secret], in the format `projects/*`
        /// or `projects/*/locations/*`.
        /// </param>
        /// <param name="secretId">
        /// Required. This must be unique within the project.
        /// 
        /// A secret ID is a string with a maximum length of 255 characters and can
        /// contain uppercase and lowercase letters, numerals, and the hyphen (`-`) and
        /// underscore (`_`) characters.
        /// </param>
        /// <param name="secret">
        /// Required. A [Secret][google.cloud.secretmanager.v1.Secret] with initial
        /// field values.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Secret> CreateSecretAsync(gagr::LocationName parent, string secretId, Secret secret, st::CancellationToken cancellationToken) =>
            CreateSecretAsync(parent, secretId, secret, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new [SecretVersion][google.cloud.secretmanager.v1.SecretVersion]
        /// containing secret data and attaches it to an existing
        /// [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecretVersion AddSecretVersion(AddSecretVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new [SecretVersion][google.cloud.secretmanager.v1.SecretVersion]
        /// containing secret data and attaches it to an existing
        /// [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecretVersion> AddSecretVersionAsync(AddSecretVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new [SecretVersion][google.cloud.secretmanager.v1.SecretVersion]
        /// containing secret data and attaches it to an existing
        /// [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecretVersion> AddSecretVersionAsync(AddSecretVersionRequest request, st::CancellationToken cancellationToken) =>
            AddSecretVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new [SecretVersion][google.cloud.secretmanager.v1.SecretVersion]
        /// containing secret data and attaches it to an existing
        /// [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the
        /// [Secret][google.cloud.secretmanager.v1.Secret] to associate with the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] in the format
        /// `projects/*/secrets/*` or `projects/*/locations/*/secrets/*`.
        /// </param>
        /// <param name="payload">
        /// Required. The secret payload of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecretVersion AddSecretVersion(string parent, SecretPayload payload, gaxgrpc::CallSettings callSettings = null) =>
            AddSecretVersion(new AddSecretVersionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Payload = gax::GaxPreconditions.CheckNotNull(payload, nameof(payload)),
            }, callSettings);

        /// <summary>
        /// Creates a new [SecretVersion][google.cloud.secretmanager.v1.SecretVersion]
        /// containing secret data and attaches it to an existing
        /// [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the
        /// [Secret][google.cloud.secretmanager.v1.Secret] to associate with the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] in the format
        /// `projects/*/secrets/*` or `projects/*/locations/*/secrets/*`.
        /// </param>
        /// <param name="payload">
        /// Required. The secret payload of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecretVersion> AddSecretVersionAsync(string parent, SecretPayload payload, gaxgrpc::CallSettings callSettings = null) =>
            AddSecretVersionAsync(new AddSecretVersionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Payload = gax::GaxPreconditions.CheckNotNull(payload, nameof(payload)),
            }, callSettings);

        /// <summary>
        /// Creates a new [SecretVersion][google.cloud.secretmanager.v1.SecretVersion]
        /// containing secret data and attaches it to an existing
        /// [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the
        /// [Secret][google.cloud.secretmanager.v1.Secret] to associate with the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] in the format
        /// `projects/*/secrets/*` or `projects/*/locations/*/secrets/*`.
        /// </param>
        /// <param name="payload">
        /// Required. The secret payload of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecretVersion> AddSecretVersionAsync(string parent, SecretPayload payload, st::CancellationToken cancellationToken) =>
            AddSecretVersionAsync(parent, payload, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new [SecretVersion][google.cloud.secretmanager.v1.SecretVersion]
        /// containing secret data and attaches it to an existing
        /// [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the
        /// [Secret][google.cloud.secretmanager.v1.Secret] to associate with the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] in the format
        /// `projects/*/secrets/*` or `projects/*/locations/*/secrets/*`.
        /// </param>
        /// <param name="payload">
        /// Required. The secret payload of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecretVersion AddSecretVersion(SecretName parent, SecretPayload payload, gaxgrpc::CallSettings callSettings = null) =>
            AddSecretVersion(new AddSecretVersionRequest
            {
                ParentAsSecretName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Payload = gax::GaxPreconditions.CheckNotNull(payload, nameof(payload)),
            }, callSettings);

        /// <summary>
        /// Creates a new [SecretVersion][google.cloud.secretmanager.v1.SecretVersion]
        /// containing secret data and attaches it to an existing
        /// [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the
        /// [Secret][google.cloud.secretmanager.v1.Secret] to associate with the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] in the format
        /// `projects/*/secrets/*` or `projects/*/locations/*/secrets/*`.
        /// </param>
        /// <param name="payload">
        /// Required. The secret payload of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecretVersion> AddSecretVersionAsync(SecretName parent, SecretPayload payload, gaxgrpc::CallSettings callSettings = null) =>
            AddSecretVersionAsync(new AddSecretVersionRequest
            {
                ParentAsSecretName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Payload = gax::GaxPreconditions.CheckNotNull(payload, nameof(payload)),
            }, callSettings);

        /// <summary>
        /// Creates a new [SecretVersion][google.cloud.secretmanager.v1.SecretVersion]
        /// containing secret data and attaches it to an existing
        /// [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the
        /// [Secret][google.cloud.secretmanager.v1.Secret] to associate with the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] in the format
        /// `projects/*/secrets/*` or `projects/*/locations/*/secrets/*`.
        /// </param>
        /// <param name="payload">
        /// Required. The secret payload of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecretVersion> AddSecretVersionAsync(SecretName parent, SecretPayload payload, st::CancellationToken cancellationToken) =>
            AddSecretVersionAsync(parent, payload, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets metadata for a given [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Secret GetSecret(GetSecretRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets metadata for a given [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Secret> GetSecretAsync(GetSecretRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets metadata for a given [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Secret> GetSecretAsync(GetSecretRequest request, st::CancellationToken cancellationToken) =>
            GetSecretAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets metadata for a given [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [Secret][google.cloud.secretmanager.v1.Secret], in the format
        /// `projects/*/secrets/*` or `projects/*/locations/*/secrets/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Secret GetSecret(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSecret(new GetSecretRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets metadata for a given [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [Secret][google.cloud.secretmanager.v1.Secret], in the format
        /// `projects/*/secrets/*` or `projects/*/locations/*/secrets/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Secret> GetSecretAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSecretAsync(new GetSecretRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets metadata for a given [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [Secret][google.cloud.secretmanager.v1.Secret], in the format
        /// `projects/*/secrets/*` or `projects/*/locations/*/secrets/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Secret> GetSecretAsync(string name, st::CancellationToken cancellationToken) =>
            GetSecretAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets metadata for a given [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [Secret][google.cloud.secretmanager.v1.Secret], in the format
        /// `projects/*/secrets/*` or `projects/*/locations/*/secrets/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Secret GetSecret(SecretName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSecret(new GetSecretRequest
            {
                SecretName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets metadata for a given [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [Secret][google.cloud.secretmanager.v1.Secret], in the format
        /// `projects/*/secrets/*` or `projects/*/locations/*/secrets/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Secret> GetSecretAsync(SecretName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSecretAsync(new GetSecretRequest
            {
                SecretName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets metadata for a given [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [Secret][google.cloud.secretmanager.v1.Secret], in the format
        /// `projects/*/secrets/*` or `projects/*/locations/*/secrets/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Secret> GetSecretAsync(SecretName name, st::CancellationToken cancellationToken) =>
            GetSecretAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates metadata of an existing
        /// [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Secret UpdateSecret(UpdateSecretRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates metadata of an existing
        /// [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Secret> UpdateSecretAsync(UpdateSecretRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates metadata of an existing
        /// [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Secret> UpdateSecretAsync(UpdateSecretRequest request, st::CancellationToken cancellationToken) =>
            UpdateSecretAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates metadata of an existing
        /// [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="secret">
        /// Required. [Secret][google.cloud.secretmanager.v1.Secret] with updated field
        /// values.
        /// </param>
        /// <param name="updateMask">
        /// Required. Specifies the fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Secret UpdateSecret(Secret secret, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSecret(new UpdateSecretRequest
            {
                Secret = gax::GaxPreconditions.CheckNotNull(secret, nameof(secret)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates metadata of an existing
        /// [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="secret">
        /// Required. [Secret][google.cloud.secretmanager.v1.Secret] with updated field
        /// values.
        /// </param>
        /// <param name="updateMask">
        /// Required. Specifies the fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Secret> UpdateSecretAsync(Secret secret, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSecretAsync(new UpdateSecretRequest
            {
                Secret = gax::GaxPreconditions.CheckNotNull(secret, nameof(secret)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates metadata of an existing
        /// [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="secret">
        /// Required. [Secret][google.cloud.secretmanager.v1.Secret] with updated field
        /// values.
        /// </param>
        /// <param name="updateMask">
        /// Required. Specifies the fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Secret> UpdateSecretAsync(Secret secret, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSecretAsync(secret, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSecret(DeleteSecretRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSecretAsync(DeleteSecretRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSecretAsync(DeleteSecretRequest request, st::CancellationToken cancellationToken) =>
            DeleteSecretAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [Secret][google.cloud.secretmanager.v1.Secret] to delete in the format
        /// `projects/*/secrets/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSecret(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSecret(new DeleteSecretRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [Secret][google.cloud.secretmanager.v1.Secret] to delete in the format
        /// `projects/*/secrets/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSecretAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSecretAsync(new DeleteSecretRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [Secret][google.cloud.secretmanager.v1.Secret] to delete in the format
        /// `projects/*/secrets/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSecretAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSecretAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [Secret][google.cloud.secretmanager.v1.Secret] to delete in the format
        /// `projects/*/secrets/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSecret(SecretName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSecret(new DeleteSecretRequest
            {
                SecretName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [Secret][google.cloud.secretmanager.v1.Secret] to delete in the format
        /// `projects/*/secrets/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSecretAsync(SecretName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSecretAsync(new DeleteSecretRequest
            {
                SecretName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [Secret][google.cloud.secretmanager.v1.Secret] to delete in the format
        /// `projects/*/secrets/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSecretAsync(SecretName name, st::CancellationToken cancellationToken) =>
            DeleteSecretAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists [SecretVersions][google.cloud.secretmanager.v1.SecretVersion]. This
        /// call does not return secret data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SecretVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSecretVersionsResponse, SecretVersion> ListSecretVersions(ListSecretVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [SecretVersions][google.cloud.secretmanager.v1.SecretVersion]. This
        /// call does not return secret data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SecretVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSecretVersionsResponse, SecretVersion> ListSecretVersionsAsync(ListSecretVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [SecretVersions][google.cloud.secretmanager.v1.SecretVersion]. This
        /// call does not return secret data.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the
        /// [Secret][google.cloud.secretmanager.v1.Secret] associated with the
        /// [SecretVersions][google.cloud.secretmanager.v1.SecretVersion] to list, in
        /// the format `projects/*/secrets/*` or `projects/*/locations/*/secrets/*`.
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
        /// <returns>A pageable sequence of <see cref="SecretVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSecretVersionsResponse, SecretVersion> ListSecretVersions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecretVersionsRequest request = new ListSecretVersionsRequest
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
            return ListSecretVersions(request, callSettings);
        }

        /// <summary>
        /// Lists [SecretVersions][google.cloud.secretmanager.v1.SecretVersion]. This
        /// call does not return secret data.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the
        /// [Secret][google.cloud.secretmanager.v1.Secret] associated with the
        /// [SecretVersions][google.cloud.secretmanager.v1.SecretVersion] to list, in
        /// the format `projects/*/secrets/*` or `projects/*/locations/*/secrets/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SecretVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSecretVersionsResponse, SecretVersion> ListSecretVersionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecretVersionsRequest request = new ListSecretVersionsRequest
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
            return ListSecretVersionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists [SecretVersions][google.cloud.secretmanager.v1.SecretVersion]. This
        /// call does not return secret data.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the
        /// [Secret][google.cloud.secretmanager.v1.Secret] associated with the
        /// [SecretVersions][google.cloud.secretmanager.v1.SecretVersion] to list, in
        /// the format `projects/*/secrets/*` or `projects/*/locations/*/secrets/*`.
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
        /// <returns>A pageable sequence of <see cref="SecretVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSecretVersionsResponse, SecretVersion> ListSecretVersions(SecretName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecretVersionsRequest request = new ListSecretVersionsRequest
            {
                ParentAsSecretName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSecretVersions(request, callSettings);
        }

        /// <summary>
        /// Lists [SecretVersions][google.cloud.secretmanager.v1.SecretVersion]. This
        /// call does not return secret data.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the
        /// [Secret][google.cloud.secretmanager.v1.Secret] associated with the
        /// [SecretVersions][google.cloud.secretmanager.v1.SecretVersion] to list, in
        /// the format `projects/*/secrets/*` or `projects/*/locations/*/secrets/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SecretVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSecretVersionsResponse, SecretVersion> ListSecretVersionsAsync(SecretName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecretVersionsRequest request = new ListSecretVersionsRequest
            {
                ParentAsSecretName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSecretVersionsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets metadata for a
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// `projects/*/secrets/*/versions/latest` is an alias to the most recently
        /// created [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecretVersion GetSecretVersion(GetSecretVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets metadata for a
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// `projects/*/secrets/*/versions/latest` is an alias to the most recently
        /// created [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecretVersion> GetSecretVersionAsync(GetSecretVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets metadata for a
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// `projects/*/secrets/*/versions/latest` is an alias to the most recently
        /// created [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecretVersion> GetSecretVersionAsync(GetSecretVersionRequest request, st::CancellationToken cancellationToken) =>
            GetSecretVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets metadata for a
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// `projects/*/secrets/*/versions/latest` is an alias to the most recently
        /// created [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] in the format
        /// `projects/*/secrets/*/versions/*` or
        /// `projects/*/locations/*/secrets/*/versions/*`.
        /// 
        /// `projects/*/secrets/*/versions/latest` or
        /// `projects/*/locations/*/secrets/*/versions/latest` is an alias to the most
        /// recently created
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecretVersion GetSecretVersion(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSecretVersion(new GetSecretVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets metadata for a
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// `projects/*/secrets/*/versions/latest` is an alias to the most recently
        /// created [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] in the format
        /// `projects/*/secrets/*/versions/*` or
        /// `projects/*/locations/*/secrets/*/versions/*`.
        /// 
        /// `projects/*/secrets/*/versions/latest` or
        /// `projects/*/locations/*/secrets/*/versions/latest` is an alias to the most
        /// recently created
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecretVersion> GetSecretVersionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSecretVersionAsync(new GetSecretVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets metadata for a
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// `projects/*/secrets/*/versions/latest` is an alias to the most recently
        /// created [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] in the format
        /// `projects/*/secrets/*/versions/*` or
        /// `projects/*/locations/*/secrets/*/versions/*`.
        /// 
        /// `projects/*/secrets/*/versions/latest` or
        /// `projects/*/locations/*/secrets/*/versions/latest` is an alias to the most
        /// recently created
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecretVersion> GetSecretVersionAsync(string name, st::CancellationToken cancellationToken) =>
            GetSecretVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets metadata for a
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// `projects/*/secrets/*/versions/latest` is an alias to the most recently
        /// created [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] in the format
        /// `projects/*/secrets/*/versions/*` or
        /// `projects/*/locations/*/secrets/*/versions/*`.
        /// 
        /// `projects/*/secrets/*/versions/latest` or
        /// `projects/*/locations/*/secrets/*/versions/latest` is an alias to the most
        /// recently created
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecretVersion GetSecretVersion(SecretVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSecretVersion(new GetSecretVersionRequest
            {
                SecretVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets metadata for a
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// `projects/*/secrets/*/versions/latest` is an alias to the most recently
        /// created [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] in the format
        /// `projects/*/secrets/*/versions/*` or
        /// `projects/*/locations/*/secrets/*/versions/*`.
        /// 
        /// `projects/*/secrets/*/versions/latest` or
        /// `projects/*/locations/*/secrets/*/versions/latest` is an alias to the most
        /// recently created
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecretVersion> GetSecretVersionAsync(SecretVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSecretVersionAsync(new GetSecretVersionRequest
            {
                SecretVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets metadata for a
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// `projects/*/secrets/*/versions/latest` is an alias to the most recently
        /// created [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] in the format
        /// `projects/*/secrets/*/versions/*` or
        /// `projects/*/locations/*/secrets/*/versions/*`.
        /// 
        /// `projects/*/secrets/*/versions/latest` or
        /// `projects/*/locations/*/secrets/*/versions/latest` is an alias to the most
        /// recently created
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecretVersion> GetSecretVersionAsync(SecretVersionName name, st::CancellationToken cancellationToken) =>
            GetSecretVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Accesses a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// This call returns the secret data.
        /// 
        /// `projects/*/secrets/*/versions/latest` is an alias to the most recently
        /// created [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccessSecretVersionResponse AccessSecretVersion(AccessSecretVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Accesses a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// This call returns the secret data.
        /// 
        /// `projects/*/secrets/*/versions/latest` is an alias to the most recently
        /// created [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccessSecretVersionResponse> AccessSecretVersionAsync(AccessSecretVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Accesses a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// This call returns the secret data.
        /// 
        /// `projects/*/secrets/*/versions/latest` is an alias to the most recently
        /// created [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccessSecretVersionResponse> AccessSecretVersionAsync(AccessSecretVersionRequest request, st::CancellationToken cancellationToken) =>
            AccessSecretVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Accesses a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// This call returns the secret data.
        /// 
        /// `projects/*/secrets/*/versions/latest` is an alias to the most recently
        /// created [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] in the format
        /// `projects/*/secrets/*/versions/*` or
        /// `projects/*/locations/*/secrets/*/versions/*`.
        /// 
        /// `projects/*/secrets/*/versions/latest` or
        /// `projects/*/locations/*/secrets/*/versions/latest` is an alias to the most
        /// recently created
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccessSecretVersionResponse AccessSecretVersion(string name, gaxgrpc::CallSettings callSettings = null) =>
            AccessSecretVersion(new AccessSecretVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Accesses a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// This call returns the secret data.
        /// 
        /// `projects/*/secrets/*/versions/latest` is an alias to the most recently
        /// created [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] in the format
        /// `projects/*/secrets/*/versions/*` or
        /// `projects/*/locations/*/secrets/*/versions/*`.
        /// 
        /// `projects/*/secrets/*/versions/latest` or
        /// `projects/*/locations/*/secrets/*/versions/latest` is an alias to the most
        /// recently created
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccessSecretVersionResponse> AccessSecretVersionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            AccessSecretVersionAsync(new AccessSecretVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Accesses a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// This call returns the secret data.
        /// 
        /// `projects/*/secrets/*/versions/latest` is an alias to the most recently
        /// created [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] in the format
        /// `projects/*/secrets/*/versions/*` or
        /// `projects/*/locations/*/secrets/*/versions/*`.
        /// 
        /// `projects/*/secrets/*/versions/latest` or
        /// `projects/*/locations/*/secrets/*/versions/latest` is an alias to the most
        /// recently created
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccessSecretVersionResponse> AccessSecretVersionAsync(string name, st::CancellationToken cancellationToken) =>
            AccessSecretVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Accesses a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// This call returns the secret data.
        /// 
        /// `projects/*/secrets/*/versions/latest` is an alias to the most recently
        /// created [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] in the format
        /// `projects/*/secrets/*/versions/*` or
        /// `projects/*/locations/*/secrets/*/versions/*`.
        /// 
        /// `projects/*/secrets/*/versions/latest` or
        /// `projects/*/locations/*/secrets/*/versions/latest` is an alias to the most
        /// recently created
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccessSecretVersionResponse AccessSecretVersion(SecretVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            AccessSecretVersion(new AccessSecretVersionRequest
            {
                SecretVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Accesses a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// This call returns the secret data.
        /// 
        /// `projects/*/secrets/*/versions/latest` is an alias to the most recently
        /// created [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] in the format
        /// `projects/*/secrets/*/versions/*` or
        /// `projects/*/locations/*/secrets/*/versions/*`.
        /// 
        /// `projects/*/secrets/*/versions/latest` or
        /// `projects/*/locations/*/secrets/*/versions/latest` is an alias to the most
        /// recently created
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccessSecretVersionResponse> AccessSecretVersionAsync(SecretVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            AccessSecretVersionAsync(new AccessSecretVersionRequest
            {
                SecretVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Accesses a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// This call returns the secret data.
        /// 
        /// `projects/*/secrets/*/versions/latest` is an alias to the most recently
        /// created [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] in the format
        /// `projects/*/secrets/*/versions/*` or
        /// `projects/*/locations/*/secrets/*/versions/*`.
        /// 
        /// `projects/*/secrets/*/versions/latest` or
        /// `projects/*/locations/*/secrets/*/versions/latest` is an alias to the most
        /// recently created
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccessSecretVersionResponse> AccessSecretVersionAsync(SecretVersionName name, st::CancellationToken cancellationToken) =>
            AccessSecretVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Disables a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// Sets the [state][google.cloud.secretmanager.v1.SecretVersion.state] of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to
        /// [DISABLED][google.cloud.secretmanager.v1.SecretVersion.State.DISABLED].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecretVersion DisableSecretVersion(DisableSecretVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disables a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// Sets the [state][google.cloud.secretmanager.v1.SecretVersion.state] of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to
        /// [DISABLED][google.cloud.secretmanager.v1.SecretVersion.State.DISABLED].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecretVersion> DisableSecretVersionAsync(DisableSecretVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disables a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// Sets the [state][google.cloud.secretmanager.v1.SecretVersion.state] of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to
        /// [DISABLED][google.cloud.secretmanager.v1.SecretVersion.State.DISABLED].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecretVersion> DisableSecretVersionAsync(DisableSecretVersionRequest request, st::CancellationToken cancellationToken) =>
            DisableSecretVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Disables a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// Sets the [state][google.cloud.secretmanager.v1.SecretVersion.state] of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to
        /// [DISABLED][google.cloud.secretmanager.v1.SecretVersion.State.DISABLED].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to disable in
        /// the format `projects/*/secrets/*/versions/*` or
        /// `projects/*/locations/*/secrets/*/versions/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecretVersion DisableSecretVersion(string name, gaxgrpc::CallSettings callSettings = null) =>
            DisableSecretVersion(new DisableSecretVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Disables a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// Sets the [state][google.cloud.secretmanager.v1.SecretVersion.state] of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to
        /// [DISABLED][google.cloud.secretmanager.v1.SecretVersion.State.DISABLED].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to disable in
        /// the format `projects/*/secrets/*/versions/*` or
        /// `projects/*/locations/*/secrets/*/versions/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecretVersion> DisableSecretVersionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DisableSecretVersionAsync(new DisableSecretVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Disables a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// Sets the [state][google.cloud.secretmanager.v1.SecretVersion.state] of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to
        /// [DISABLED][google.cloud.secretmanager.v1.SecretVersion.State.DISABLED].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to disable in
        /// the format `projects/*/secrets/*/versions/*` or
        /// `projects/*/locations/*/secrets/*/versions/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecretVersion> DisableSecretVersionAsync(string name, st::CancellationToken cancellationToken) =>
            DisableSecretVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Disables a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// Sets the [state][google.cloud.secretmanager.v1.SecretVersion.state] of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to
        /// [DISABLED][google.cloud.secretmanager.v1.SecretVersion.State.DISABLED].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to disable in
        /// the format `projects/*/secrets/*/versions/*` or
        /// `projects/*/locations/*/secrets/*/versions/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecretVersion DisableSecretVersion(SecretVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            DisableSecretVersion(new DisableSecretVersionRequest
            {
                SecretVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Disables a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// Sets the [state][google.cloud.secretmanager.v1.SecretVersion.state] of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to
        /// [DISABLED][google.cloud.secretmanager.v1.SecretVersion.State.DISABLED].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to disable in
        /// the format `projects/*/secrets/*/versions/*` or
        /// `projects/*/locations/*/secrets/*/versions/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecretVersion> DisableSecretVersionAsync(SecretVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            DisableSecretVersionAsync(new DisableSecretVersionRequest
            {
                SecretVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Disables a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// Sets the [state][google.cloud.secretmanager.v1.SecretVersion.state] of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to
        /// [DISABLED][google.cloud.secretmanager.v1.SecretVersion.State.DISABLED].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to disable in
        /// the format `projects/*/secrets/*/versions/*` or
        /// `projects/*/locations/*/secrets/*/versions/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecretVersion> DisableSecretVersionAsync(SecretVersionName name, st::CancellationToken cancellationToken) =>
            DisableSecretVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enables a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// Sets the [state][google.cloud.secretmanager.v1.SecretVersion.state] of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to
        /// [ENABLED][google.cloud.secretmanager.v1.SecretVersion.State.ENABLED].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecretVersion EnableSecretVersion(EnableSecretVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enables a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// Sets the [state][google.cloud.secretmanager.v1.SecretVersion.state] of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to
        /// [ENABLED][google.cloud.secretmanager.v1.SecretVersion.State.ENABLED].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecretVersion> EnableSecretVersionAsync(EnableSecretVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enables a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// Sets the [state][google.cloud.secretmanager.v1.SecretVersion.state] of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to
        /// [ENABLED][google.cloud.secretmanager.v1.SecretVersion.State.ENABLED].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecretVersion> EnableSecretVersionAsync(EnableSecretVersionRequest request, st::CancellationToken cancellationToken) =>
            EnableSecretVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enables a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// Sets the [state][google.cloud.secretmanager.v1.SecretVersion.state] of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to
        /// [ENABLED][google.cloud.secretmanager.v1.SecretVersion.State.ENABLED].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to enable in
        /// the format `projects/*/secrets/*/versions/*` or
        /// `projects/*/locations/*/secrets/*/versions/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecretVersion EnableSecretVersion(string name, gaxgrpc::CallSettings callSettings = null) =>
            EnableSecretVersion(new EnableSecretVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Enables a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// Sets the [state][google.cloud.secretmanager.v1.SecretVersion.state] of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to
        /// [ENABLED][google.cloud.secretmanager.v1.SecretVersion.State.ENABLED].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to enable in
        /// the format `projects/*/secrets/*/versions/*` or
        /// `projects/*/locations/*/secrets/*/versions/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecretVersion> EnableSecretVersionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            EnableSecretVersionAsync(new EnableSecretVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Enables a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// Sets the [state][google.cloud.secretmanager.v1.SecretVersion.state] of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to
        /// [ENABLED][google.cloud.secretmanager.v1.SecretVersion.State.ENABLED].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to enable in
        /// the format `projects/*/secrets/*/versions/*` or
        /// `projects/*/locations/*/secrets/*/versions/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecretVersion> EnableSecretVersionAsync(string name, st::CancellationToken cancellationToken) =>
            EnableSecretVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enables a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// Sets the [state][google.cloud.secretmanager.v1.SecretVersion.state] of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to
        /// [ENABLED][google.cloud.secretmanager.v1.SecretVersion.State.ENABLED].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to enable in
        /// the format `projects/*/secrets/*/versions/*` or
        /// `projects/*/locations/*/secrets/*/versions/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecretVersion EnableSecretVersion(SecretVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            EnableSecretVersion(new EnableSecretVersionRequest
            {
                SecretVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Enables a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// Sets the [state][google.cloud.secretmanager.v1.SecretVersion.state] of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to
        /// [ENABLED][google.cloud.secretmanager.v1.SecretVersion.State.ENABLED].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to enable in
        /// the format `projects/*/secrets/*/versions/*` or
        /// `projects/*/locations/*/secrets/*/versions/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecretVersion> EnableSecretVersionAsync(SecretVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            EnableSecretVersionAsync(new EnableSecretVersionRequest
            {
                SecretVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Enables a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// Sets the [state][google.cloud.secretmanager.v1.SecretVersion.state] of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to
        /// [ENABLED][google.cloud.secretmanager.v1.SecretVersion.State.ENABLED].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to enable in
        /// the format `projects/*/secrets/*/versions/*` or
        /// `projects/*/locations/*/secrets/*/versions/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecretVersion> EnableSecretVersionAsync(SecretVersionName name, st::CancellationToken cancellationToken) =>
            EnableSecretVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Destroys a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// Sets the [state][google.cloud.secretmanager.v1.SecretVersion.state] of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to
        /// [DESTROYED][google.cloud.secretmanager.v1.SecretVersion.State.DESTROYED]
        /// and irrevocably destroys the secret data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecretVersion DestroySecretVersion(DestroySecretVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Destroys a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// Sets the [state][google.cloud.secretmanager.v1.SecretVersion.state] of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to
        /// [DESTROYED][google.cloud.secretmanager.v1.SecretVersion.State.DESTROYED]
        /// and irrevocably destroys the secret data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecretVersion> DestroySecretVersionAsync(DestroySecretVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Destroys a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// Sets the [state][google.cloud.secretmanager.v1.SecretVersion.state] of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to
        /// [DESTROYED][google.cloud.secretmanager.v1.SecretVersion.State.DESTROYED]
        /// and irrevocably destroys the secret data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecretVersion> DestroySecretVersionAsync(DestroySecretVersionRequest request, st::CancellationToken cancellationToken) =>
            DestroySecretVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Destroys a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// Sets the [state][google.cloud.secretmanager.v1.SecretVersion.state] of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to
        /// [DESTROYED][google.cloud.secretmanager.v1.SecretVersion.State.DESTROYED]
        /// and irrevocably destroys the secret data.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to destroy in
        /// the format `projects/*/secrets/*/versions/*` or
        /// `projects/*/locations/*/secrets/*/versions/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecretVersion DestroySecretVersion(string name, gaxgrpc::CallSettings callSettings = null) =>
            DestroySecretVersion(new DestroySecretVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Destroys a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// Sets the [state][google.cloud.secretmanager.v1.SecretVersion.state] of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to
        /// [DESTROYED][google.cloud.secretmanager.v1.SecretVersion.State.DESTROYED]
        /// and irrevocably destroys the secret data.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to destroy in
        /// the format `projects/*/secrets/*/versions/*` or
        /// `projects/*/locations/*/secrets/*/versions/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecretVersion> DestroySecretVersionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DestroySecretVersionAsync(new DestroySecretVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Destroys a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// Sets the [state][google.cloud.secretmanager.v1.SecretVersion.state] of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to
        /// [DESTROYED][google.cloud.secretmanager.v1.SecretVersion.State.DESTROYED]
        /// and irrevocably destroys the secret data.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to destroy in
        /// the format `projects/*/secrets/*/versions/*` or
        /// `projects/*/locations/*/secrets/*/versions/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecretVersion> DestroySecretVersionAsync(string name, st::CancellationToken cancellationToken) =>
            DestroySecretVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Destroys a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// Sets the [state][google.cloud.secretmanager.v1.SecretVersion.state] of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to
        /// [DESTROYED][google.cloud.secretmanager.v1.SecretVersion.State.DESTROYED]
        /// and irrevocably destroys the secret data.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to destroy in
        /// the format `projects/*/secrets/*/versions/*` or
        /// `projects/*/locations/*/secrets/*/versions/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecretVersion DestroySecretVersion(SecretVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            DestroySecretVersion(new DestroySecretVersionRequest
            {
                SecretVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Destroys a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// Sets the [state][google.cloud.secretmanager.v1.SecretVersion.state] of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to
        /// [DESTROYED][google.cloud.secretmanager.v1.SecretVersion.State.DESTROYED]
        /// and irrevocably destroys the secret data.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to destroy in
        /// the format `projects/*/secrets/*/versions/*` or
        /// `projects/*/locations/*/secrets/*/versions/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecretVersion> DestroySecretVersionAsync(SecretVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            DestroySecretVersionAsync(new DestroySecretVersionRequest
            {
                SecretVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Destroys a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// Sets the [state][google.cloud.secretmanager.v1.SecretVersion.state] of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to
        /// [DESTROYED][google.cloud.secretmanager.v1.SecretVersion.State.DESTROYED]
        /// and irrevocably destroys the secret data.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to destroy in
        /// the format `projects/*/secrets/*/versions/*` or
        /// `projects/*/locations/*/secrets/*/versions/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecretVersion> DestroySecretVersionAsync(SecretVersionName name, st::CancellationToken cancellationToken) =>
            DestroySecretVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on the specified secret. Replaces any
        /// existing policy.
        /// 
        /// Permissions on
        /// [SecretVersions][google.cloud.secretmanager.v1.SecretVersion] are enforced
        /// according to the policy set on the associated
        /// [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on the specified secret. Replaces any
        /// existing policy.
        /// 
        /// Permissions on
        /// [SecretVersions][google.cloud.secretmanager.v1.SecretVersion] are enforced
        /// according to the policy set on the associated
        /// [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on the specified secret. Replaces any
        /// existing policy.
        /// 
        /// Permissions on
        /// [SecretVersions][google.cloud.secretmanager.v1.SecretVersion] are enforced
        /// according to the policy set on the associated
        /// [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a secret.
        /// Returns empty policy if the secret exists and does not have a policy set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for a secret.
        /// Returns empty policy if the secret exists and does not have a policy set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for a secret.
        /// Returns empty policy if the secret exists and does not have a policy set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has for the specified secret.
        /// If the secret does not exist, this call returns an empty set of
        /// permissions, not a NOT_FOUND error.
        /// 
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that a caller has for the specified secret.
        /// If the secret does not exist, this call returns an empty set of
        /// permissions, not a NOT_FOUND error.
        /// 
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that a caller has for the specified secret.
        /// If the secret does not exist, this call returns an empty set of
        /// permissions, not a NOT_FOUND error.
        /// 
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SecretManagerService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Secret Manager Service
    /// 
    /// Manages secrets and operations using those secrets. Implements a REST
    /// model with the following objects:
    /// 
    /// * [Secret][google.cloud.secretmanager.v1.Secret]
    /// * [SecretVersion][google.cloud.secretmanager.v1.SecretVersion]
    /// </remarks>
    public sealed partial class SecretManagerServiceClientImpl : SecretManagerServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListSecretsRequest, ListSecretsResponse> _callListSecrets;

        private readonly gaxgrpc::ApiCall<CreateSecretRequest, Secret> _callCreateSecret;

        private readonly gaxgrpc::ApiCall<AddSecretVersionRequest, SecretVersion> _callAddSecretVersion;

        private readonly gaxgrpc::ApiCall<GetSecretRequest, Secret> _callGetSecret;

        private readonly gaxgrpc::ApiCall<UpdateSecretRequest, Secret> _callUpdateSecret;

        private readonly gaxgrpc::ApiCall<DeleteSecretRequest, wkt::Empty> _callDeleteSecret;

        private readonly gaxgrpc::ApiCall<ListSecretVersionsRequest, ListSecretVersionsResponse> _callListSecretVersions;

        private readonly gaxgrpc::ApiCall<GetSecretVersionRequest, SecretVersion> _callGetSecretVersion;

        private readonly gaxgrpc::ApiCall<AccessSecretVersionRequest, AccessSecretVersionResponse> _callAccessSecretVersion;

        private readonly gaxgrpc::ApiCall<DisableSecretVersionRequest, SecretVersion> _callDisableSecretVersion;

        private readonly gaxgrpc::ApiCall<EnableSecretVersionRequest, SecretVersion> _callEnableSecretVersion;

        private readonly gaxgrpc::ApiCall<DestroySecretVersionRequest, SecretVersion> _callDestroySecretVersion;

        private readonly gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> _callSetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> _callGetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> _callTestIamPermissions;

        /// <summary>
        /// Constructs a client wrapper for the SecretManagerService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SecretManagerServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SecretManagerServiceClientImpl(SecretManagerService.SecretManagerServiceClient grpcClient, SecretManagerServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SecretManagerServiceSettings effectiveSettings = settings ?? SecretManagerServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListSecrets = clientHelper.BuildApiCall<ListSecretsRequest, ListSecretsResponse>("ListSecrets", grpcClient.ListSecretsAsync, grpcClient.ListSecrets, effectiveSettings.ListSecretsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSecrets);
            Modify_ListSecretsApiCall(ref _callListSecrets);
            _callCreateSecret = clientHelper.BuildApiCall<CreateSecretRequest, Secret>("CreateSecret", grpcClient.CreateSecretAsync, grpcClient.CreateSecret, effectiveSettings.CreateSecretSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSecret);
            Modify_CreateSecretApiCall(ref _callCreateSecret);
            _callAddSecretVersion = clientHelper.BuildApiCall<AddSecretVersionRequest, SecretVersion>("AddSecretVersion", grpcClient.AddSecretVersionAsync, grpcClient.AddSecretVersion, effectiveSettings.AddSecretVersionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callAddSecretVersion);
            Modify_AddSecretVersionApiCall(ref _callAddSecretVersion);
            _callGetSecret = clientHelper.BuildApiCall<GetSecretRequest, Secret>("GetSecret", grpcClient.GetSecretAsync, grpcClient.GetSecret, effectiveSettings.GetSecretSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSecret);
            Modify_GetSecretApiCall(ref _callGetSecret);
            _callUpdateSecret = clientHelper.BuildApiCall<UpdateSecretRequest, Secret>("UpdateSecret", grpcClient.UpdateSecretAsync, grpcClient.UpdateSecret, effectiveSettings.UpdateSecretSettings).WithGoogleRequestParam("secret.name", request => request.Secret?.Name);
            Modify_ApiCall(ref _callUpdateSecret);
            Modify_UpdateSecretApiCall(ref _callUpdateSecret);
            _callDeleteSecret = clientHelper.BuildApiCall<DeleteSecretRequest, wkt::Empty>("DeleteSecret", grpcClient.DeleteSecretAsync, grpcClient.DeleteSecret, effectiveSettings.DeleteSecretSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSecret);
            Modify_DeleteSecretApiCall(ref _callDeleteSecret);
            _callListSecretVersions = clientHelper.BuildApiCall<ListSecretVersionsRequest, ListSecretVersionsResponse>("ListSecretVersions", grpcClient.ListSecretVersionsAsync, grpcClient.ListSecretVersions, effectiveSettings.ListSecretVersionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSecretVersions);
            Modify_ListSecretVersionsApiCall(ref _callListSecretVersions);
            _callGetSecretVersion = clientHelper.BuildApiCall<GetSecretVersionRequest, SecretVersion>("GetSecretVersion", grpcClient.GetSecretVersionAsync, grpcClient.GetSecretVersion, effectiveSettings.GetSecretVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSecretVersion);
            Modify_GetSecretVersionApiCall(ref _callGetSecretVersion);
            _callAccessSecretVersion = clientHelper.BuildApiCall<AccessSecretVersionRequest, AccessSecretVersionResponse>("AccessSecretVersion", grpcClient.AccessSecretVersionAsync, grpcClient.AccessSecretVersion, effectiveSettings.AccessSecretVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callAccessSecretVersion);
            Modify_AccessSecretVersionApiCall(ref _callAccessSecretVersion);
            _callDisableSecretVersion = clientHelper.BuildApiCall<DisableSecretVersionRequest, SecretVersion>("DisableSecretVersion", grpcClient.DisableSecretVersionAsync, grpcClient.DisableSecretVersion, effectiveSettings.DisableSecretVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDisableSecretVersion);
            Modify_DisableSecretVersionApiCall(ref _callDisableSecretVersion);
            _callEnableSecretVersion = clientHelper.BuildApiCall<EnableSecretVersionRequest, SecretVersion>("EnableSecretVersion", grpcClient.EnableSecretVersionAsync, grpcClient.EnableSecretVersion, effectiveSettings.EnableSecretVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callEnableSecretVersion);
            Modify_EnableSecretVersionApiCall(ref _callEnableSecretVersion);
            _callDestroySecretVersion = clientHelper.BuildApiCall<DestroySecretVersionRequest, SecretVersion>("DestroySecretVersion", grpcClient.DestroySecretVersionAsync, grpcClient.DestroySecretVersion, effectiveSettings.DestroySecretVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDestroySecretVersion);
            Modify_DestroySecretVersionApiCall(ref _callDestroySecretVersion);
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

        partial void Modify_ListSecretsApiCall(ref gaxgrpc::ApiCall<ListSecretsRequest, ListSecretsResponse> call);

        partial void Modify_CreateSecretApiCall(ref gaxgrpc::ApiCall<CreateSecretRequest, Secret> call);

        partial void Modify_AddSecretVersionApiCall(ref gaxgrpc::ApiCall<AddSecretVersionRequest, SecretVersion> call);

        partial void Modify_GetSecretApiCall(ref gaxgrpc::ApiCall<GetSecretRequest, Secret> call);

        partial void Modify_UpdateSecretApiCall(ref gaxgrpc::ApiCall<UpdateSecretRequest, Secret> call);

        partial void Modify_DeleteSecretApiCall(ref gaxgrpc::ApiCall<DeleteSecretRequest, wkt::Empty> call);

        partial void Modify_ListSecretVersionsApiCall(ref gaxgrpc::ApiCall<ListSecretVersionsRequest, ListSecretVersionsResponse> call);

        partial void Modify_GetSecretVersionApiCall(ref gaxgrpc::ApiCall<GetSecretVersionRequest, SecretVersion> call);

        partial void Modify_AccessSecretVersionApiCall(ref gaxgrpc::ApiCall<AccessSecretVersionRequest, AccessSecretVersionResponse> call);

        partial void Modify_DisableSecretVersionApiCall(ref gaxgrpc::ApiCall<DisableSecretVersionRequest, SecretVersion> call);

        partial void Modify_EnableSecretVersionApiCall(ref gaxgrpc::ApiCall<EnableSecretVersionRequest, SecretVersion> call);

        partial void Modify_DestroySecretVersionApiCall(ref gaxgrpc::ApiCall<DestroySecretVersionRequest, SecretVersion> call);

        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> call);

        partial void OnConstruction(SecretManagerService.SecretManagerServiceClient grpcClient, SecretManagerServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SecretManagerService client</summary>
        public override SecretManagerService.SecretManagerServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListSecretsRequest(ref ListSecretsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSecretRequest(ref CreateSecretRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AddSecretVersionRequest(ref AddSecretVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSecretRequest(ref GetSecretRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSecretRequest(ref UpdateSecretRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSecretRequest(ref DeleteSecretRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSecretVersionsRequest(ref ListSecretVersionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSecretVersionRequest(ref GetSecretVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AccessSecretVersionRequest(ref AccessSecretVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DisableSecretVersionRequest(ref DisableSecretVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_EnableSecretVersionRequest(ref EnableSecretVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DestroySecretVersionRequest(ref DestroySecretVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetIamPolicyRequest(ref gciv::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIamPolicyRequest(ref gciv::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsRequest(ref gciv::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists [Secrets][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Secret"/> resources.</returns>
        public override gax::PagedEnumerable<ListSecretsResponse, Secret> ListSecrets(ListSecretsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSecretsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSecretsRequest, ListSecretsResponse, Secret>(_callListSecrets, request, callSettings);
        }

        /// <summary>
        /// Lists [Secrets][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Secret"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSecretsResponse, Secret> ListSecretsAsync(ListSecretsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSecretsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSecretsRequest, ListSecretsResponse, Secret>(_callListSecrets, request, callSettings);
        }

        /// <summary>
        /// Creates a new [Secret][google.cloud.secretmanager.v1.Secret] containing no
        /// [SecretVersions][google.cloud.secretmanager.v1.SecretVersion].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Secret CreateSecret(CreateSecretRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSecretRequest(ref request, ref callSettings);
            return _callCreateSecret.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new [Secret][google.cloud.secretmanager.v1.Secret] containing no
        /// [SecretVersions][google.cloud.secretmanager.v1.SecretVersion].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Secret> CreateSecretAsync(CreateSecretRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSecretRequest(ref request, ref callSettings);
            return _callCreateSecret.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new [SecretVersion][google.cloud.secretmanager.v1.SecretVersion]
        /// containing secret data and attaches it to an existing
        /// [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SecretVersion AddSecretVersion(AddSecretVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddSecretVersionRequest(ref request, ref callSettings);
            return _callAddSecretVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new [SecretVersion][google.cloud.secretmanager.v1.SecretVersion]
        /// containing secret data and attaches it to an existing
        /// [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SecretVersion> AddSecretVersionAsync(AddSecretVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddSecretVersionRequest(ref request, ref callSettings);
            return _callAddSecretVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Gets metadata for a given [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Secret GetSecret(GetSecretRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSecretRequest(ref request, ref callSettings);
            return _callGetSecret.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets metadata for a given [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Secret> GetSecretAsync(GetSecretRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSecretRequest(ref request, ref callSettings);
            return _callGetSecret.Async(request, callSettings);
        }

        /// <summary>
        /// Updates metadata of an existing
        /// [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Secret UpdateSecret(UpdateSecretRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSecretRequest(ref request, ref callSettings);
            return _callUpdateSecret.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates metadata of an existing
        /// [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Secret> UpdateSecretAsync(UpdateSecretRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSecretRequest(ref request, ref callSettings);
            return _callUpdateSecret.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteSecret(DeleteSecretRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSecretRequest(ref request, ref callSettings);
            _callDeleteSecret.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a [Secret][google.cloud.secretmanager.v1.Secret].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteSecretAsync(DeleteSecretRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSecretRequest(ref request, ref callSettings);
            return _callDeleteSecret.Async(request, callSettings);
        }

        /// <summary>
        /// Lists [SecretVersions][google.cloud.secretmanager.v1.SecretVersion]. This
        /// call does not return secret data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SecretVersion"/> resources.</returns>
        public override gax::PagedEnumerable<ListSecretVersionsResponse, SecretVersion> ListSecretVersions(ListSecretVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSecretVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSecretVersionsRequest, ListSecretVersionsResponse, SecretVersion>(_callListSecretVersions, request, callSettings);
        }

        /// <summary>
        /// Lists [SecretVersions][google.cloud.secretmanager.v1.SecretVersion]. This
        /// call does not return secret data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SecretVersion"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSecretVersionsResponse, SecretVersion> ListSecretVersionsAsync(ListSecretVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSecretVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSecretVersionsRequest, ListSecretVersionsResponse, SecretVersion>(_callListSecretVersions, request, callSettings);
        }

        /// <summary>
        /// Gets metadata for a
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// `projects/*/secrets/*/versions/latest` is an alias to the most recently
        /// created [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SecretVersion GetSecretVersion(GetSecretVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSecretVersionRequest(ref request, ref callSettings);
            return _callGetSecretVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets metadata for a
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// `projects/*/secrets/*/versions/latest` is an alias to the most recently
        /// created [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SecretVersion> GetSecretVersionAsync(GetSecretVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSecretVersionRequest(ref request, ref callSettings);
            return _callGetSecretVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Accesses a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// This call returns the secret data.
        /// 
        /// `projects/*/secrets/*/versions/latest` is an alias to the most recently
        /// created [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AccessSecretVersionResponse AccessSecretVersion(AccessSecretVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AccessSecretVersionRequest(ref request, ref callSettings);
            return _callAccessSecretVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Accesses a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// This call returns the secret data.
        /// 
        /// `projects/*/secrets/*/versions/latest` is an alias to the most recently
        /// created [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AccessSecretVersionResponse> AccessSecretVersionAsync(AccessSecretVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AccessSecretVersionRequest(ref request, ref callSettings);
            return _callAccessSecretVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Disables a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// Sets the [state][google.cloud.secretmanager.v1.SecretVersion.state] of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to
        /// [DISABLED][google.cloud.secretmanager.v1.SecretVersion.State.DISABLED].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SecretVersion DisableSecretVersion(DisableSecretVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DisableSecretVersionRequest(ref request, ref callSettings);
            return _callDisableSecretVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Disables a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// Sets the [state][google.cloud.secretmanager.v1.SecretVersion.state] of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to
        /// [DISABLED][google.cloud.secretmanager.v1.SecretVersion.State.DISABLED].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SecretVersion> DisableSecretVersionAsync(DisableSecretVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DisableSecretVersionRequest(ref request, ref callSettings);
            return _callDisableSecretVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Enables a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// Sets the [state][google.cloud.secretmanager.v1.SecretVersion.state] of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to
        /// [ENABLED][google.cloud.secretmanager.v1.SecretVersion.State.ENABLED].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SecretVersion EnableSecretVersion(EnableSecretVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnableSecretVersionRequest(ref request, ref callSettings);
            return _callEnableSecretVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Enables a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// Sets the [state][google.cloud.secretmanager.v1.SecretVersion.state] of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to
        /// [ENABLED][google.cloud.secretmanager.v1.SecretVersion.State.ENABLED].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SecretVersion> EnableSecretVersionAsync(EnableSecretVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnableSecretVersionRequest(ref request, ref callSettings);
            return _callEnableSecretVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Destroys a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// Sets the [state][google.cloud.secretmanager.v1.SecretVersion.state] of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to
        /// [DESTROYED][google.cloud.secretmanager.v1.SecretVersion.State.DESTROYED]
        /// and irrevocably destroys the secret data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SecretVersion DestroySecretVersion(DestroySecretVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DestroySecretVersionRequest(ref request, ref callSettings);
            return _callDestroySecretVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Destroys a [SecretVersion][google.cloud.secretmanager.v1.SecretVersion].
        /// 
        /// Sets the [state][google.cloud.secretmanager.v1.SecretVersion.state] of the
        /// [SecretVersion][google.cloud.secretmanager.v1.SecretVersion] to
        /// [DESTROYED][google.cloud.secretmanager.v1.SecretVersion.State.DESTROYED]
        /// and irrevocably destroys the secret data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SecretVersion> DestroySecretVersionAsync(DestroySecretVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DestroySecretVersionRequest(ref request, ref callSettings);
            return _callDestroySecretVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy on the specified secret. Replaces any
        /// existing policy.
        /// 
        /// Permissions on
        /// [SecretVersions][google.cloud.secretmanager.v1.SecretVersion] are enforced
        /// according to the policy set on the associated
        /// [Secret][google.cloud.secretmanager.v1.Secret].
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
        /// Sets the access control policy on the specified secret. Replaces any
        /// existing policy.
        /// 
        /// Permissions on
        /// [SecretVersions][google.cloud.secretmanager.v1.SecretVersion] are enforced
        /// according to the policy set on the associated
        /// [Secret][google.cloud.secretmanager.v1.Secret].
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
        /// Gets the access control policy for a secret.
        /// Returns empty policy if the secret exists and does not have a policy set.
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
        /// Gets the access control policy for a secret.
        /// Returns empty policy if the secret exists and does not have a policy set.
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
        /// Returns permissions that a caller has for the specified secret.
        /// If the secret does not exist, this call returns an empty set of
        /// permissions, not a NOT_FOUND error.
        /// 
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
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
        /// Returns permissions that a caller has for the specified secret.
        /// If the secret does not exist, this call returns an empty set of
        /// permissions, not a NOT_FOUND error.
        /// 
        /// Note: This operation is designed to be used for building permission-aware
        /// UIs and command-line tools, not for authorization checking. This operation
        /// may "fail open" without warning.
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

    public partial class ListSecretsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSecretVersionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSecretsResponse : gaxgrpc::IPageResponse<Secret>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Secret> GetEnumerator() => Secrets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSecretVersionsResponse : gaxgrpc::IPageResponse<SecretVersion>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<SecretVersion> GetEnumerator() => Versions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class SecretManagerService
    {
        public partial class SecretManagerServiceClient
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
