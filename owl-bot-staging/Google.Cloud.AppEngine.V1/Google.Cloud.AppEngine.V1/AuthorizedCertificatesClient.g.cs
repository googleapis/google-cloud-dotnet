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

namespace Google.Cloud.AppEngine.V1
{
    /// <summary>Settings for <see cref="AuthorizedCertificatesClient"/> instances.</summary>
    public sealed partial class AuthorizedCertificatesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AuthorizedCertificatesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AuthorizedCertificatesSettings"/>.</returns>
        public static AuthorizedCertificatesSettings GetDefault() => new AuthorizedCertificatesSettings();

        /// <summary>
        /// Constructs a new <see cref="AuthorizedCertificatesSettings"/> object with default settings.
        /// </summary>
        public AuthorizedCertificatesSettings()
        {
        }

        private AuthorizedCertificatesSettings(AuthorizedCertificatesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListAuthorizedCertificatesSettings = existing.ListAuthorizedCertificatesSettings;
            GetAuthorizedCertificateSettings = existing.GetAuthorizedCertificateSettings;
            CreateAuthorizedCertificateSettings = existing.CreateAuthorizedCertificateSettings;
            UpdateAuthorizedCertificateSettings = existing.UpdateAuthorizedCertificateSettings;
            DeleteAuthorizedCertificateSettings = existing.DeleteAuthorizedCertificateSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AuthorizedCertificatesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AuthorizedCertificatesClient.ListAuthorizedCertificates</c> and
        /// <c>AuthorizedCertificatesClient.ListAuthorizedCertificatesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAuthorizedCertificatesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AuthorizedCertificatesClient.GetAuthorizedCertificate</c> and
        /// <c>AuthorizedCertificatesClient.GetAuthorizedCertificateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAuthorizedCertificateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AuthorizedCertificatesClient.CreateAuthorizedCertificate</c> and
        /// <c>AuthorizedCertificatesClient.CreateAuthorizedCertificateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAuthorizedCertificateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AuthorizedCertificatesClient.UpdateAuthorizedCertificate</c> and
        /// <c>AuthorizedCertificatesClient.UpdateAuthorizedCertificateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAuthorizedCertificateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AuthorizedCertificatesClient.DeleteAuthorizedCertificate</c> and
        /// <c>AuthorizedCertificatesClient.DeleteAuthorizedCertificateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAuthorizedCertificateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AuthorizedCertificatesSettings"/> object.</returns>
        public AuthorizedCertificatesSettings Clone() => new AuthorizedCertificatesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AuthorizedCertificatesClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class AuthorizedCertificatesClientBuilder : gaxgrpc::ClientBuilderBase<AuthorizedCertificatesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AuthorizedCertificatesSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AuthorizedCertificatesClientBuilder() : base(AuthorizedCertificatesClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AuthorizedCertificatesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AuthorizedCertificatesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AuthorizedCertificatesClient Build()
        {
            AuthorizedCertificatesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AuthorizedCertificatesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AuthorizedCertificatesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AuthorizedCertificatesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AuthorizedCertificatesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AuthorizedCertificatesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AuthorizedCertificatesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AuthorizedCertificatesClient.ChannelPool;
    }

    /// <summary>AuthorizedCertificates client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Manages SSL certificates a user is authorized to administer. A user can
    /// administer any SSL certificates applicable to their authorized domains.
    /// </remarks>
    public abstract partial class AuthorizedCertificatesClient
    {
        /// <summary>
        /// The default endpoint for the AuthorizedCertificates service, which is a host of "appengine.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "appengine.googleapis.com:443";

        /// <summary>The default AuthorizedCertificates scopes.</summary>
        /// <remarks>
        /// The default AuthorizedCertificates scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/appengine.admin</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform.read-only</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/appengine.admin",
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AuthorizedCertificates.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AuthorizedCertificatesClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AuthorizedCertificatesClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AuthorizedCertificatesClient"/>.</returns>
        public static stt::Task<AuthorizedCertificatesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AuthorizedCertificatesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AuthorizedCertificatesClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AuthorizedCertificatesClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AuthorizedCertificatesClient"/>.</returns>
        public static AuthorizedCertificatesClient Create() => new AuthorizedCertificatesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AuthorizedCertificatesClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AuthorizedCertificatesSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AuthorizedCertificatesClient"/>.</returns>
        internal static AuthorizedCertificatesClient Create(grpccore::CallInvoker callInvoker, AuthorizedCertificatesSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AuthorizedCertificates.AuthorizedCertificatesClient grpcClient = new AuthorizedCertificates.AuthorizedCertificatesClient(callInvoker);
            return new AuthorizedCertificatesClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AuthorizedCertificates client</summary>
        public virtual AuthorizedCertificates.AuthorizedCertificatesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all SSL certificates the user is authorized to administer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AuthorizedCertificate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAuthorizedCertificatesResponse, AuthorizedCertificate> ListAuthorizedCertificates(ListAuthorizedCertificatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all SSL certificates the user is authorized to administer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AuthorizedCertificate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAuthorizedCertificatesResponse, AuthorizedCertificate> ListAuthorizedCertificatesAsync(ListAuthorizedCertificatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the specified SSL certificate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AuthorizedCertificate GetAuthorizedCertificate(GetAuthorizedCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the specified SSL certificate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuthorizedCertificate> GetAuthorizedCertificateAsync(GetAuthorizedCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the specified SSL certificate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuthorizedCertificate> GetAuthorizedCertificateAsync(GetAuthorizedCertificateRequest request, st::CancellationToken cancellationToken) =>
            GetAuthorizedCertificateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Uploads the specified SSL certificate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AuthorizedCertificate CreateAuthorizedCertificate(CreateAuthorizedCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Uploads the specified SSL certificate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuthorizedCertificate> CreateAuthorizedCertificateAsync(CreateAuthorizedCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Uploads the specified SSL certificate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuthorizedCertificate> CreateAuthorizedCertificateAsync(CreateAuthorizedCertificateRequest request, st::CancellationToken cancellationToken) =>
            CreateAuthorizedCertificateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified SSL certificate. To renew a certificate and maintain
        /// its existing domain mappings, update `certificate_data` with a new
        /// certificate. The new certificate must be applicable to the same domains as
        /// the original certificate. The certificate `display_name` may also be
        /// updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AuthorizedCertificate UpdateAuthorizedCertificate(UpdateAuthorizedCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified SSL certificate. To renew a certificate and maintain
        /// its existing domain mappings, update `certificate_data` with a new
        /// certificate. The new certificate must be applicable to the same domains as
        /// the original certificate. The certificate `display_name` may also be
        /// updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuthorizedCertificate> UpdateAuthorizedCertificateAsync(UpdateAuthorizedCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified SSL certificate. To renew a certificate and maintain
        /// its existing domain mappings, update `certificate_data` with a new
        /// certificate. The new certificate must be applicable to the same domains as
        /// the original certificate. The certificate `display_name` may also be
        /// updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AuthorizedCertificate> UpdateAuthorizedCertificateAsync(UpdateAuthorizedCertificateRequest request, st::CancellationToken cancellationToken) =>
            UpdateAuthorizedCertificateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified SSL certificate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAuthorizedCertificate(DeleteAuthorizedCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified SSL certificate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAuthorizedCertificateAsync(DeleteAuthorizedCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified SSL certificate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAuthorizedCertificateAsync(DeleteAuthorizedCertificateRequest request, st::CancellationToken cancellationToken) =>
            DeleteAuthorizedCertificateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AuthorizedCertificates client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Manages SSL certificates a user is authorized to administer. A user can
    /// administer any SSL certificates applicable to their authorized domains.
    /// </remarks>
    public sealed partial class AuthorizedCertificatesClientImpl : AuthorizedCertificatesClient
    {
        private readonly gaxgrpc::ApiCall<ListAuthorizedCertificatesRequest, ListAuthorizedCertificatesResponse> _callListAuthorizedCertificates;

        private readonly gaxgrpc::ApiCall<GetAuthorizedCertificateRequest, AuthorizedCertificate> _callGetAuthorizedCertificate;

        private readonly gaxgrpc::ApiCall<CreateAuthorizedCertificateRequest, AuthorizedCertificate> _callCreateAuthorizedCertificate;

        private readonly gaxgrpc::ApiCall<UpdateAuthorizedCertificateRequest, AuthorizedCertificate> _callUpdateAuthorizedCertificate;

        private readonly gaxgrpc::ApiCall<DeleteAuthorizedCertificateRequest, wkt::Empty> _callDeleteAuthorizedCertificate;

        /// <summary>
        /// Constructs a client wrapper for the AuthorizedCertificates service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="AuthorizedCertificatesSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AuthorizedCertificatesClientImpl(AuthorizedCertificates.AuthorizedCertificatesClient grpcClient, AuthorizedCertificatesSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AuthorizedCertificatesSettings effectiveSettings = settings ?? AuthorizedCertificatesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callListAuthorizedCertificates = clientHelper.BuildApiCall<ListAuthorizedCertificatesRequest, ListAuthorizedCertificatesResponse>("ListAuthorizedCertificates", grpcClient.ListAuthorizedCertificatesAsync, grpcClient.ListAuthorizedCertificates, effectiveSettings.ListAuthorizedCertificatesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAuthorizedCertificates);
            Modify_ListAuthorizedCertificatesApiCall(ref _callListAuthorizedCertificates);
            _callGetAuthorizedCertificate = clientHelper.BuildApiCall<GetAuthorizedCertificateRequest, AuthorizedCertificate>("GetAuthorizedCertificate", grpcClient.GetAuthorizedCertificateAsync, grpcClient.GetAuthorizedCertificate, effectiveSettings.GetAuthorizedCertificateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAuthorizedCertificate);
            Modify_GetAuthorizedCertificateApiCall(ref _callGetAuthorizedCertificate);
            _callCreateAuthorizedCertificate = clientHelper.BuildApiCall<CreateAuthorizedCertificateRequest, AuthorizedCertificate>("CreateAuthorizedCertificate", grpcClient.CreateAuthorizedCertificateAsync, grpcClient.CreateAuthorizedCertificate, effectiveSettings.CreateAuthorizedCertificateSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAuthorizedCertificate);
            Modify_CreateAuthorizedCertificateApiCall(ref _callCreateAuthorizedCertificate);
            _callUpdateAuthorizedCertificate = clientHelper.BuildApiCall<UpdateAuthorizedCertificateRequest, AuthorizedCertificate>("UpdateAuthorizedCertificate", grpcClient.UpdateAuthorizedCertificateAsync, grpcClient.UpdateAuthorizedCertificate, effectiveSettings.UpdateAuthorizedCertificateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateAuthorizedCertificate);
            Modify_UpdateAuthorizedCertificateApiCall(ref _callUpdateAuthorizedCertificate);
            _callDeleteAuthorizedCertificate = clientHelper.BuildApiCall<DeleteAuthorizedCertificateRequest, wkt::Empty>("DeleteAuthorizedCertificate", grpcClient.DeleteAuthorizedCertificateAsync, grpcClient.DeleteAuthorizedCertificate, effectiveSettings.DeleteAuthorizedCertificateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAuthorizedCertificate);
            Modify_DeleteAuthorizedCertificateApiCall(ref _callDeleteAuthorizedCertificate);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListAuthorizedCertificatesApiCall(ref gaxgrpc::ApiCall<ListAuthorizedCertificatesRequest, ListAuthorizedCertificatesResponse> call);

        partial void Modify_GetAuthorizedCertificateApiCall(ref gaxgrpc::ApiCall<GetAuthorizedCertificateRequest, AuthorizedCertificate> call);

        partial void Modify_CreateAuthorizedCertificateApiCall(ref gaxgrpc::ApiCall<CreateAuthorizedCertificateRequest, AuthorizedCertificate> call);

        partial void Modify_UpdateAuthorizedCertificateApiCall(ref gaxgrpc::ApiCall<UpdateAuthorizedCertificateRequest, AuthorizedCertificate> call);

        partial void Modify_DeleteAuthorizedCertificateApiCall(ref gaxgrpc::ApiCall<DeleteAuthorizedCertificateRequest, wkt::Empty> call);

        partial void OnConstruction(AuthorizedCertificates.AuthorizedCertificatesClient grpcClient, AuthorizedCertificatesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AuthorizedCertificates client</summary>
        public override AuthorizedCertificates.AuthorizedCertificatesClient GrpcClient { get; }

        partial void Modify_ListAuthorizedCertificatesRequest(ref ListAuthorizedCertificatesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAuthorizedCertificateRequest(ref GetAuthorizedCertificateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAuthorizedCertificateRequest(ref CreateAuthorizedCertificateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAuthorizedCertificateRequest(ref UpdateAuthorizedCertificateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAuthorizedCertificateRequest(ref DeleteAuthorizedCertificateRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists all SSL certificates the user is authorized to administer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AuthorizedCertificate"/> resources.</returns>
        public override gax::PagedEnumerable<ListAuthorizedCertificatesResponse, AuthorizedCertificate> ListAuthorizedCertificates(ListAuthorizedCertificatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAuthorizedCertificatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAuthorizedCertificatesRequest, ListAuthorizedCertificatesResponse, AuthorizedCertificate>(_callListAuthorizedCertificates, request, callSettings);
        }

        /// <summary>
        /// Lists all SSL certificates the user is authorized to administer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AuthorizedCertificate"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAuthorizedCertificatesResponse, AuthorizedCertificate> ListAuthorizedCertificatesAsync(ListAuthorizedCertificatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAuthorizedCertificatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAuthorizedCertificatesRequest, ListAuthorizedCertificatesResponse, AuthorizedCertificate>(_callListAuthorizedCertificates, request, callSettings);
        }

        /// <summary>
        /// Gets the specified SSL certificate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AuthorizedCertificate GetAuthorizedCertificate(GetAuthorizedCertificateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAuthorizedCertificateRequest(ref request, ref callSettings);
            return _callGetAuthorizedCertificate.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the specified SSL certificate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AuthorizedCertificate> GetAuthorizedCertificateAsync(GetAuthorizedCertificateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAuthorizedCertificateRequest(ref request, ref callSettings);
            return _callGetAuthorizedCertificate.Async(request, callSettings);
        }

        /// <summary>
        /// Uploads the specified SSL certificate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AuthorizedCertificate CreateAuthorizedCertificate(CreateAuthorizedCertificateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAuthorizedCertificateRequest(ref request, ref callSettings);
            return _callCreateAuthorizedCertificate.Sync(request, callSettings);
        }

        /// <summary>
        /// Uploads the specified SSL certificate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AuthorizedCertificate> CreateAuthorizedCertificateAsync(CreateAuthorizedCertificateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAuthorizedCertificateRequest(ref request, ref callSettings);
            return _callCreateAuthorizedCertificate.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified SSL certificate. To renew a certificate and maintain
        /// its existing domain mappings, update `certificate_data` with a new
        /// certificate. The new certificate must be applicable to the same domains as
        /// the original certificate. The certificate `display_name` may also be
        /// updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AuthorizedCertificate UpdateAuthorizedCertificate(UpdateAuthorizedCertificateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAuthorizedCertificateRequest(ref request, ref callSettings);
            return _callUpdateAuthorizedCertificate.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified SSL certificate. To renew a certificate and maintain
        /// its existing domain mappings, update `certificate_data` with a new
        /// certificate. The new certificate must be applicable to the same domains as
        /// the original certificate. The certificate `display_name` may also be
        /// updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AuthorizedCertificate> UpdateAuthorizedCertificateAsync(UpdateAuthorizedCertificateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAuthorizedCertificateRequest(ref request, ref callSettings);
            return _callUpdateAuthorizedCertificate.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified SSL certificate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteAuthorizedCertificate(DeleteAuthorizedCertificateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAuthorizedCertificateRequest(ref request, ref callSettings);
            _callDeleteAuthorizedCertificate.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified SSL certificate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteAuthorizedCertificateAsync(DeleteAuthorizedCertificateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAuthorizedCertificateRequest(ref request, ref callSettings);
            return _callDeleteAuthorizedCertificate.Async(request, callSettings);
        }
    }

    public partial class ListAuthorizedCertificatesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAuthorizedCertificatesResponse : gaxgrpc::IPageResponse<AuthorizedCertificate>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AuthorizedCertificate> GetEnumerator() => Certificates.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
