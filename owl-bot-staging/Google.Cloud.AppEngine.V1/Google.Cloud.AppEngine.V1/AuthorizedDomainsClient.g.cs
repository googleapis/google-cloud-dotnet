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

namespace Google.Cloud.AppEngine.V1
{
    /// <summary>Settings for <see cref="AuthorizedDomainsClient"/> instances.</summary>
    public sealed partial class AuthorizedDomainsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AuthorizedDomainsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AuthorizedDomainsSettings"/>.</returns>
        public static AuthorizedDomainsSettings GetDefault() => new AuthorizedDomainsSettings();

        /// <summary>Constructs a new <see cref="AuthorizedDomainsSettings"/> object with default settings.</summary>
        public AuthorizedDomainsSettings()
        {
        }

        private AuthorizedDomainsSettings(AuthorizedDomainsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListAuthorizedDomainsSettings = existing.ListAuthorizedDomainsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AuthorizedDomainsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AuthorizedDomainsClient.ListAuthorizedDomains</c> and
        /// <c>AuthorizedDomainsClient.ListAuthorizedDomainsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAuthorizedDomainsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AuthorizedDomainsSettings"/> object.</returns>
        public AuthorizedDomainsSettings Clone() => new AuthorizedDomainsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AuthorizedDomainsClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class AuthorizedDomainsClientBuilder : gaxgrpc::ClientBuilderBase<AuthorizedDomainsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AuthorizedDomainsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AuthorizedDomainsClientBuilder() : base(AuthorizedDomainsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AuthorizedDomainsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AuthorizedDomainsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AuthorizedDomainsClient Build()
        {
            AuthorizedDomainsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AuthorizedDomainsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AuthorizedDomainsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AuthorizedDomainsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AuthorizedDomainsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AuthorizedDomainsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AuthorizedDomainsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AuthorizedDomainsClient.ChannelPool;
    }

    /// <summary>AuthorizedDomains client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Manages domains a user is authorized to administer. To authorize use of a
    /// domain, verify ownership via
    /// [Webmaster Central](https://www.google.com/webmasters/verification/home).
    /// </remarks>
    public abstract partial class AuthorizedDomainsClient
    {
        /// <summary>
        /// The default endpoint for the AuthorizedDomains service, which is a host of "appengine.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "appengine.googleapis.com:443";

        /// <summary>The default AuthorizedDomains scopes.</summary>
        /// <remarks>
        /// The default AuthorizedDomains scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AuthorizedDomains.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AuthorizedDomainsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AuthorizedDomainsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AuthorizedDomainsClient"/>.</returns>
        public static stt::Task<AuthorizedDomainsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AuthorizedDomainsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AuthorizedDomainsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AuthorizedDomainsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AuthorizedDomainsClient"/>.</returns>
        public static AuthorizedDomainsClient Create() => new AuthorizedDomainsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AuthorizedDomainsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AuthorizedDomainsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AuthorizedDomainsClient"/>.</returns>
        internal static AuthorizedDomainsClient Create(grpccore::CallInvoker callInvoker, AuthorizedDomainsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AuthorizedDomains.AuthorizedDomainsClient grpcClient = new AuthorizedDomains.AuthorizedDomainsClient(callInvoker);
            return new AuthorizedDomainsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AuthorizedDomains client</summary>
        public virtual AuthorizedDomains.AuthorizedDomainsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all domains the user is authorized to administer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AuthorizedDomain"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAuthorizedDomainsResponse, AuthorizedDomain> ListAuthorizedDomains(ListAuthorizedDomainsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all domains the user is authorized to administer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AuthorizedDomain"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAuthorizedDomainsResponse, AuthorizedDomain> ListAuthorizedDomainsAsync(ListAuthorizedDomainsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>AuthorizedDomains client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Manages domains a user is authorized to administer. To authorize use of a
    /// domain, verify ownership via
    /// [Webmaster Central](https://www.google.com/webmasters/verification/home).
    /// </remarks>
    public sealed partial class AuthorizedDomainsClientImpl : AuthorizedDomainsClient
    {
        private readonly gaxgrpc::ApiCall<ListAuthorizedDomainsRequest, ListAuthorizedDomainsResponse> _callListAuthorizedDomains;

        /// <summary>
        /// Constructs a client wrapper for the AuthorizedDomains service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AuthorizedDomainsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AuthorizedDomainsClientImpl(AuthorizedDomains.AuthorizedDomainsClient grpcClient, AuthorizedDomainsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AuthorizedDomainsSettings effectiveSettings = settings ?? AuthorizedDomainsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callListAuthorizedDomains = clientHelper.BuildApiCall<ListAuthorizedDomainsRequest, ListAuthorizedDomainsResponse>("ListAuthorizedDomains", grpcClient.ListAuthorizedDomainsAsync, grpcClient.ListAuthorizedDomains, effectiveSettings.ListAuthorizedDomainsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAuthorizedDomains);
            Modify_ListAuthorizedDomainsApiCall(ref _callListAuthorizedDomains);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListAuthorizedDomainsApiCall(ref gaxgrpc::ApiCall<ListAuthorizedDomainsRequest, ListAuthorizedDomainsResponse> call);

        partial void OnConstruction(AuthorizedDomains.AuthorizedDomainsClient grpcClient, AuthorizedDomainsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AuthorizedDomains client</summary>
        public override AuthorizedDomains.AuthorizedDomainsClient GrpcClient { get; }

        partial void Modify_ListAuthorizedDomainsRequest(ref ListAuthorizedDomainsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists all domains the user is authorized to administer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AuthorizedDomain"/> resources.</returns>
        public override gax::PagedEnumerable<ListAuthorizedDomainsResponse, AuthorizedDomain> ListAuthorizedDomains(ListAuthorizedDomainsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAuthorizedDomainsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAuthorizedDomainsRequest, ListAuthorizedDomainsResponse, AuthorizedDomain>(_callListAuthorizedDomains, request, callSettings);
        }

        /// <summary>
        /// Lists all domains the user is authorized to administer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AuthorizedDomain"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAuthorizedDomainsResponse, AuthorizedDomain> ListAuthorizedDomainsAsync(ListAuthorizedDomainsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAuthorizedDomainsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAuthorizedDomainsRequest, ListAuthorizedDomainsResponse, AuthorizedDomain>(_callListAuthorizedDomains, request, callSettings);
        }
    }

    public partial class ListAuthorizedDomainsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAuthorizedDomainsResponse : gaxgrpc::IPageResponse<AuthorizedDomain>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AuthorizedDomain> GetEnumerator() => Domains.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
