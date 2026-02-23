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

namespace Google.Ads.DataManager.V1
{
    /// <summary>Settings for <see cref="PartnerLinkServiceClient"/> instances.</summary>
    public sealed partial class PartnerLinkServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PartnerLinkServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PartnerLinkServiceSettings"/>.</returns>
        public static PartnerLinkServiceSettings GetDefault() => new PartnerLinkServiceSettings();

        /// <summary>Constructs a new <see cref="PartnerLinkServiceSettings"/> object with default settings.</summary>
        public PartnerLinkServiceSettings()
        {
        }

        private PartnerLinkServiceSettings(PartnerLinkServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreatePartnerLinkSettings = existing.CreatePartnerLinkSettings;
            DeletePartnerLinkSettings = existing.DeletePartnerLinkSettings;
            SearchPartnerLinksSettings = existing.SearchPartnerLinksSettings;
            OnCopy(existing);
        }

        partial void OnCopy(PartnerLinkServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PartnerLinkServiceClient.CreatePartnerLink</c> and <c>PartnerLinkServiceClient.CreatePartnerLinkAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreatePartnerLinkSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PartnerLinkServiceClient.DeletePartnerLink</c> and <c>PartnerLinkServiceClient.DeletePartnerLinkAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeletePartnerLinkSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PartnerLinkServiceClient.SearchPartnerLinks</c> and <c>PartnerLinkServiceClient.SearchPartnerLinksAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchPartnerLinksSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PartnerLinkServiceSettings"/> object.</returns>
        public PartnerLinkServiceSettings Clone() => new PartnerLinkServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PartnerLinkServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class PartnerLinkServiceClientBuilder : gaxgrpc::ClientBuilderBase<PartnerLinkServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PartnerLinkServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public PartnerLinkServiceClientBuilder() : base(PartnerLinkServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref PartnerLinkServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PartnerLinkServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PartnerLinkServiceClient Build()
        {
            PartnerLinkServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PartnerLinkServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PartnerLinkServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PartnerLinkServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PartnerLinkServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<PartnerLinkServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PartnerLinkServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PartnerLinkServiceClient.ChannelPool;
    }

    /// <summary>PartnerLinkService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing partner links.
    /// </remarks>
    public abstract partial class PartnerLinkServiceClient
    {
        /// <summary>
        /// The default endpoint for the PartnerLinkService service, which is a host of "datamanager.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "datamanager.googleapis.com:443";

        /// <summary>The default PartnerLinkService scopes.</summary>
        /// <remarks>
        /// The default PartnerLinkService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/datamanager</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/datamanager",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(PartnerLinkService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="PartnerLinkServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="PartnerLinkServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PartnerLinkServiceClient"/>.</returns>
        public static stt::Task<PartnerLinkServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PartnerLinkServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PartnerLinkServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="PartnerLinkServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="PartnerLinkServiceClient"/>.</returns>
        public static PartnerLinkServiceClient Create() => new PartnerLinkServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PartnerLinkServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PartnerLinkServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="PartnerLinkServiceClient"/>.</returns>
        internal static PartnerLinkServiceClient Create(grpccore::CallInvoker callInvoker, PartnerLinkServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            PartnerLinkService.PartnerLinkServiceClient grpcClient = new PartnerLinkService.PartnerLinkServiceClient(callInvoker);
            return new PartnerLinkServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC PartnerLinkService client</summary>
        public virtual PartnerLinkService.PartnerLinkServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a partner link for the given account.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PartnerLink CreatePartnerLink(CreatePartnerLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a partner link for the given account.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PartnerLink> CreatePartnerLinkAsync(CreatePartnerLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a partner link for the given account.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PartnerLink> CreatePartnerLinkAsync(CreatePartnerLinkRequest request, st::CancellationToken cancellationToken) =>
            CreatePartnerLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a partner link for the given account.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of partner links.
        /// Format: accountTypes/{account_type}/accounts/{account}
        /// </param>
        /// <param name="partnerLink">
        /// Required. The partner link to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PartnerLink CreatePartnerLink(string parent, PartnerLink partnerLink, gaxgrpc::CallSettings callSettings = null) =>
            CreatePartnerLink(new CreatePartnerLinkRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PartnerLink = gax::GaxPreconditions.CheckNotNull(partnerLink, nameof(partnerLink)),
            }, callSettings);

        /// <summary>
        /// Creates a partner link for the given account.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of partner links.
        /// Format: accountTypes/{account_type}/accounts/{account}
        /// </param>
        /// <param name="partnerLink">
        /// Required. The partner link to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PartnerLink> CreatePartnerLinkAsync(string parent, PartnerLink partnerLink, gaxgrpc::CallSettings callSettings = null) =>
            CreatePartnerLinkAsync(new CreatePartnerLinkRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PartnerLink = gax::GaxPreconditions.CheckNotNull(partnerLink, nameof(partnerLink)),
            }, callSettings);

        /// <summary>
        /// Creates a partner link for the given account.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of partner links.
        /// Format: accountTypes/{account_type}/accounts/{account}
        /// </param>
        /// <param name="partnerLink">
        /// Required. The partner link to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PartnerLink> CreatePartnerLinkAsync(string parent, PartnerLink partnerLink, st::CancellationToken cancellationToken) =>
            CreatePartnerLinkAsync(parent, partnerLink, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a partner link for the given account.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of partner links.
        /// Format: accountTypes/{account_type}/accounts/{account}
        /// </param>
        /// <param name="partnerLink">
        /// Required. The partner link to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PartnerLink CreatePartnerLink(AccountName parent, PartnerLink partnerLink, gaxgrpc::CallSettings callSettings = null) =>
            CreatePartnerLink(new CreatePartnerLinkRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PartnerLink = gax::GaxPreconditions.CheckNotNull(partnerLink, nameof(partnerLink)),
            }, callSettings);

        /// <summary>
        /// Creates a partner link for the given account.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of partner links.
        /// Format: accountTypes/{account_type}/accounts/{account}
        /// </param>
        /// <param name="partnerLink">
        /// Required. The partner link to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PartnerLink> CreatePartnerLinkAsync(AccountName parent, PartnerLink partnerLink, gaxgrpc::CallSettings callSettings = null) =>
            CreatePartnerLinkAsync(new CreatePartnerLinkRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PartnerLink = gax::GaxPreconditions.CheckNotNull(partnerLink, nameof(partnerLink)),
            }, callSettings);

        /// <summary>
        /// Creates a partner link for the given account.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of partner links.
        /// Format: accountTypes/{account_type}/accounts/{account}
        /// </param>
        /// <param name="partnerLink">
        /// Required. The partner link to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PartnerLink> CreatePartnerLinkAsync(AccountName parent, PartnerLink partnerLink, st::CancellationToken cancellationToken) =>
            CreatePartnerLinkAsync(parent, partnerLink, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a partner link for the given account.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePartnerLink(DeletePartnerLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a partner link for the given account.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePartnerLinkAsync(DeletePartnerLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a partner link for the given account.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePartnerLinkAsync(DeletePartnerLinkRequest request, st::CancellationToken cancellationToken) =>
            DeletePartnerLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a partner link for the given account.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the partner link to delete.
        /// Format:
        /// accountTypes/{account_type}/accounts/{account}/partnerLinks/{partner_link}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePartnerLink(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePartnerLink(new DeletePartnerLinkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a partner link for the given account.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the partner link to delete.
        /// Format:
        /// accountTypes/{account_type}/accounts/{account}/partnerLinks/{partner_link}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePartnerLinkAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePartnerLinkAsync(new DeletePartnerLinkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a partner link for the given account.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the partner link to delete.
        /// Format:
        /// accountTypes/{account_type}/accounts/{account}/partnerLinks/{partner_link}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePartnerLinkAsync(string name, st::CancellationToken cancellationToken) =>
            DeletePartnerLinkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a partner link for the given account.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the partner link to delete.
        /// Format:
        /// accountTypes/{account_type}/accounts/{account}/partnerLinks/{partner_link}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePartnerLink(PartnerLinkName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePartnerLink(new DeletePartnerLinkRequest
            {
                PartnerLinkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a partner link for the given account.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the partner link to delete.
        /// Format:
        /// accountTypes/{account_type}/accounts/{account}/partnerLinks/{partner_link}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePartnerLinkAsync(PartnerLinkName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePartnerLinkAsync(new DeletePartnerLinkRequest
            {
                PartnerLinkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a partner link for the given account.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the partner link to delete.
        /// Format:
        /// accountTypes/{account_type}/accounts/{account}/partnerLinks/{partner_link}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePartnerLinkAsync(PartnerLinkName name, st::CancellationToken cancellationToken) =>
            DeletePartnerLinkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Searches for all partner links to and from a given account.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PartnerLink"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchPartnerLinksResponse, PartnerLink> SearchPartnerLinks(SearchPartnerLinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches for all partner links to and from a given account.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PartnerLink"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchPartnerLinksResponse, PartnerLink> SearchPartnerLinksAsync(SearchPartnerLinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches for all partner links to and from a given account.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="parent">
        /// Required. Account to search for partner links. If no `filter` is specified,
        /// all partner links where this account is either the `owning_account` or
        /// `partner_account` are returned.
        /// 
        /// Format: `accountTypes/{account_type}/accounts/{account}`
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
        /// <returns>A pageable sequence of <see cref="PartnerLink"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchPartnerLinksResponse, PartnerLink> SearchPartnerLinks(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchPartnerLinksRequest request = new SearchPartnerLinksRequest
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
            return SearchPartnerLinks(request, callSettings);
        }

        /// <summary>
        /// Searches for all partner links to and from a given account.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="parent">
        /// Required. Account to search for partner links. If no `filter` is specified,
        /// all partner links where this account is either the `owning_account` or
        /// `partner_account` are returned.
        /// 
        /// Format: `accountTypes/{account_type}/accounts/{account}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="PartnerLink"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchPartnerLinksResponse, PartnerLink> SearchPartnerLinksAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchPartnerLinksRequest request = new SearchPartnerLinksRequest
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
            return SearchPartnerLinksAsync(request, callSettings);
        }

        /// <summary>
        /// Searches for all partner links to and from a given account.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="parent">
        /// Required. Account to search for partner links. If no `filter` is specified,
        /// all partner links where this account is either the `owning_account` or
        /// `partner_account` are returned.
        /// 
        /// Format: `accountTypes/{account_type}/accounts/{account}`
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
        /// <returns>A pageable sequence of <see cref="PartnerLink"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchPartnerLinksResponse, PartnerLink> SearchPartnerLinks(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchPartnerLinksRequest request = new SearchPartnerLinksRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchPartnerLinks(request, callSettings);
        }

        /// <summary>
        /// Searches for all partner links to and from a given account.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="parent">
        /// Required. Account to search for partner links. If no `filter` is specified,
        /// all partner links where this account is either the `owning_account` or
        /// `partner_account` are returned.
        /// 
        /// Format: `accountTypes/{account_type}/accounts/{account}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="PartnerLink"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchPartnerLinksResponse, PartnerLink> SearchPartnerLinksAsync(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchPartnerLinksRequest request = new SearchPartnerLinksRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchPartnerLinksAsync(request, callSettings);
        }
    }

    /// <summary>PartnerLinkService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing partner links.
    /// </remarks>
    public sealed partial class PartnerLinkServiceClientImpl : PartnerLinkServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreatePartnerLinkRequest, PartnerLink> _callCreatePartnerLink;

        private readonly gaxgrpc::ApiCall<DeletePartnerLinkRequest, wkt::Empty> _callDeletePartnerLink;

        private readonly gaxgrpc::ApiCall<SearchPartnerLinksRequest, SearchPartnerLinksResponse> _callSearchPartnerLinks;

        /// <summary>
        /// Constructs a client wrapper for the PartnerLinkService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="PartnerLinkServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public PartnerLinkServiceClientImpl(PartnerLinkService.PartnerLinkServiceClient grpcClient, PartnerLinkServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            PartnerLinkServiceSettings effectiveSettings = settings ?? PartnerLinkServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCreatePartnerLink = clientHelper.BuildApiCall<CreatePartnerLinkRequest, PartnerLink>("CreatePartnerLink", grpcClient.CreatePartnerLinkAsync, grpcClient.CreatePartnerLink, effectiveSettings.CreatePartnerLinkSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreatePartnerLink);
            Modify_CreatePartnerLinkApiCall(ref _callCreatePartnerLink);
            _callDeletePartnerLink = clientHelper.BuildApiCall<DeletePartnerLinkRequest, wkt::Empty>("DeletePartnerLink", grpcClient.DeletePartnerLinkAsync, grpcClient.DeletePartnerLink, effectiveSettings.DeletePartnerLinkSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeletePartnerLink);
            Modify_DeletePartnerLinkApiCall(ref _callDeletePartnerLink);
            _callSearchPartnerLinks = clientHelper.BuildApiCall<SearchPartnerLinksRequest, SearchPartnerLinksResponse>("SearchPartnerLinks", grpcClient.SearchPartnerLinksAsync, grpcClient.SearchPartnerLinks, effectiveSettings.SearchPartnerLinksSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSearchPartnerLinks);
            Modify_SearchPartnerLinksApiCall(ref _callSearchPartnerLinks);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreatePartnerLinkApiCall(ref gaxgrpc::ApiCall<CreatePartnerLinkRequest, PartnerLink> call);

        partial void Modify_DeletePartnerLinkApiCall(ref gaxgrpc::ApiCall<DeletePartnerLinkRequest, wkt::Empty> call);

        partial void Modify_SearchPartnerLinksApiCall(ref gaxgrpc::ApiCall<SearchPartnerLinksRequest, SearchPartnerLinksResponse> call);

        partial void OnConstruction(PartnerLinkService.PartnerLinkServiceClient grpcClient, PartnerLinkServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC PartnerLinkService client</summary>
        public override PartnerLinkService.PartnerLinkServiceClient GrpcClient { get; }

        partial void Modify_CreatePartnerLinkRequest(ref CreatePartnerLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePartnerLinkRequest(ref DeletePartnerLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchPartnerLinksRequest(ref SearchPartnerLinksRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a partner link for the given account.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PartnerLink CreatePartnerLink(CreatePartnerLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePartnerLinkRequest(ref request, ref callSettings);
            return _callCreatePartnerLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a partner link for the given account.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PartnerLink> CreatePartnerLinkAsync(CreatePartnerLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePartnerLinkRequest(ref request, ref callSettings);
            return _callCreatePartnerLink.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a partner link for the given account.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeletePartnerLink(DeletePartnerLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePartnerLinkRequest(ref request, ref callSettings);
            _callDeletePartnerLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a partner link for the given account.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeletePartnerLinkAsync(DeletePartnerLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePartnerLinkRequest(ref request, ref callSettings);
            return _callDeletePartnerLink.Async(request, callSettings);
        }

        /// <summary>
        /// Searches for all partner links to and from a given account.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PartnerLink"/> resources.</returns>
        public override gax::PagedEnumerable<SearchPartnerLinksResponse, PartnerLink> SearchPartnerLinks(SearchPartnerLinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchPartnerLinksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchPartnerLinksRequest, SearchPartnerLinksResponse, PartnerLink>(_callSearchPartnerLinks, request, callSettings);
        }

        /// <summary>
        /// Searches for all partner links to and from a given account.
        /// 
        /// Authorization Headers:
        /// 
        /// This method supports the following optional headers to define how the API
        /// authorizes access for the request:
        /// 
        /// * `login-account`: (Optional) The resource name of the account where the
        /// Google Account of the credentials is a user. If not set, defaults to the
        /// account of the request. Format:
        /// `accountTypes/{loginAccountType}/accounts/{loginAccountId}`
        /// * `linked-account`: (Optional) The resource name of the account with an
        /// established product link to the `login-account`. Format:
        /// `accountTypes/{linkedAccountType}/accounts/{linkedAccountId}`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PartnerLink"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchPartnerLinksResponse, PartnerLink> SearchPartnerLinksAsync(SearchPartnerLinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchPartnerLinksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchPartnerLinksRequest, SearchPartnerLinksResponse, PartnerLink>(_callSearchPartnerLinks, request, callSettings);
        }
    }

    public partial class SearchPartnerLinksRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchPartnerLinksResponse : gaxgrpc::IPageResponse<PartnerLink>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PartnerLink> GetEnumerator() => PartnerLinks.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
