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

namespace Google.Shopping.Css.V1
{
    /// <summary>Settings for <see cref="AccountLabelsServiceClient"/> instances.</summary>
    public sealed partial class AccountLabelsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AccountLabelsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AccountLabelsServiceSettings"/>.</returns>
        public static AccountLabelsServiceSettings GetDefault() => new AccountLabelsServiceSettings();

        /// <summary>Constructs a new <see cref="AccountLabelsServiceSettings"/> object with default settings.</summary>
        public AccountLabelsServiceSettings()
        {
        }

        private AccountLabelsServiceSettings(AccountLabelsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListAccountLabelsSettings = existing.ListAccountLabelsSettings;
            CreateAccountLabelSettings = existing.CreateAccountLabelSettings;
            UpdateAccountLabelSettings = existing.UpdateAccountLabelSettings;
            DeleteAccountLabelSettings = existing.DeleteAccountLabelSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AccountLabelsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccountLabelsServiceClient.ListAccountLabels</c> and <c>AccountLabelsServiceClient.ListAccountLabelsAsync</c>
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
        public gaxgrpc::CallSettings ListAccountLabelsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccountLabelsServiceClient.CreateAccountLabel</c> and
        /// <c>AccountLabelsServiceClient.CreateAccountLabelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAccountLabelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccountLabelsServiceClient.UpdateAccountLabel</c> and
        /// <c>AccountLabelsServiceClient.UpdateAccountLabelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAccountLabelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccountLabelsServiceClient.DeleteAccountLabel</c> and
        /// <c>AccountLabelsServiceClient.DeleteAccountLabelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAccountLabelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AccountLabelsServiceSettings"/> object.</returns>
        public AccountLabelsServiceSettings Clone() => new AccountLabelsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AccountLabelsServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class AccountLabelsServiceClientBuilder : gaxgrpc::ClientBuilderBase<AccountLabelsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AccountLabelsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AccountLabelsServiceClientBuilder() : base(AccountLabelsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AccountLabelsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AccountLabelsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AccountLabelsServiceClient Build()
        {
            AccountLabelsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AccountLabelsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AccountLabelsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AccountLabelsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AccountLabelsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AccountLabelsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AccountLabelsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AccountLabelsServiceClient.ChannelPool;
    }

    /// <summary>AccountLabelsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Manages Merchant Center and CSS accounts labels.
    /// </remarks>
    public abstract partial class AccountLabelsServiceClient
    {
        /// <summary>
        /// The default endpoint for the AccountLabelsService service, which is a host of "css.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "css.googleapis.com:443";

        /// <summary>The default AccountLabelsService scopes.</summary>
        /// <remarks>
        /// The default AccountLabelsService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AccountLabelsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AccountLabelsServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AccountLabelsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AccountLabelsServiceClient"/>.</returns>
        public static stt::Task<AccountLabelsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AccountLabelsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AccountLabelsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="AccountLabelsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AccountLabelsServiceClient"/>.</returns>
        public static AccountLabelsServiceClient Create() => new AccountLabelsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AccountLabelsServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AccountLabelsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AccountLabelsServiceClient"/>.</returns>
        internal static AccountLabelsServiceClient Create(grpccore::CallInvoker callInvoker, AccountLabelsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AccountLabelsService.AccountLabelsServiceClient grpcClient = new AccountLabelsService.AccountLabelsServiceClient(callInvoker);
            return new AccountLabelsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AccountLabelsService client</summary>
        public virtual AccountLabelsService.AccountLabelsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the labels assigned to an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AccountLabel"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAccountLabelsResponse, AccountLabel> ListAccountLabels(ListAccountLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the labels assigned to an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AccountLabel"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAccountLabelsResponse, AccountLabel> ListAccountLabelsAsync(ListAccountLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the labels assigned to an account.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent account.
        /// Format: accounts/{account}
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
        /// <returns>A pageable sequence of <see cref="AccountLabel"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAccountLabelsResponse, AccountLabel> ListAccountLabels(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAccountLabelsRequest request = new ListAccountLabelsRequest
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
            return ListAccountLabels(request, callSettings);
        }

        /// <summary>
        /// Lists the labels assigned to an account.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent account.
        /// Format: accounts/{account}
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
        /// <returns>A pageable asynchronous sequence of <see cref="AccountLabel"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAccountLabelsResponse, AccountLabel> ListAccountLabelsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAccountLabelsRequest request = new ListAccountLabelsRequest
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
            return ListAccountLabelsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the labels assigned to an account.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent account.
        /// Format: accounts/{account}
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
        /// <returns>A pageable sequence of <see cref="AccountLabel"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAccountLabelsResponse, AccountLabel> ListAccountLabels(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAccountLabelsRequest request = new ListAccountLabelsRequest
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
            return ListAccountLabels(request, callSettings);
        }

        /// <summary>
        /// Lists the labels assigned to an account.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent account.
        /// Format: accounts/{account}
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
        /// <returns>A pageable asynchronous sequence of <see cref="AccountLabel"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAccountLabelsResponse, AccountLabel> ListAccountLabelsAsync(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAccountLabelsRequest request = new ListAccountLabelsRequest
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
            return ListAccountLabelsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a new label, not assigned to any account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccountLabel CreateAccountLabel(CreateAccountLabelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new label, not assigned to any account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountLabel> CreateAccountLabelAsync(CreateAccountLabelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new label, not assigned to any account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountLabel> CreateAccountLabelAsync(CreateAccountLabelRequest request, st::CancellationToken cancellationToken) =>
            CreateAccountLabelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new label, not assigned to any account.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent account.
        /// Format: accounts/{account}
        /// </param>
        /// <param name="accountLabel">
        /// Required. The label to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccountLabel CreateAccountLabel(string parent, AccountLabel accountLabel, gaxgrpc::CallSettings callSettings = null) =>
            CreateAccountLabel(new CreateAccountLabelRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AccountLabel = gax::GaxPreconditions.CheckNotNull(accountLabel, nameof(accountLabel)),
            }, callSettings);

        /// <summary>
        /// Creates a new label, not assigned to any account.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent account.
        /// Format: accounts/{account}
        /// </param>
        /// <param name="accountLabel">
        /// Required. The label to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountLabel> CreateAccountLabelAsync(string parent, AccountLabel accountLabel, gaxgrpc::CallSettings callSettings = null) =>
            CreateAccountLabelAsync(new CreateAccountLabelRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AccountLabel = gax::GaxPreconditions.CheckNotNull(accountLabel, nameof(accountLabel)),
            }, callSettings);

        /// <summary>
        /// Creates a new label, not assigned to any account.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent account.
        /// Format: accounts/{account}
        /// </param>
        /// <param name="accountLabel">
        /// Required. The label to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountLabel> CreateAccountLabelAsync(string parent, AccountLabel accountLabel, st::CancellationToken cancellationToken) =>
            CreateAccountLabelAsync(parent, accountLabel, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new label, not assigned to any account.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent account.
        /// Format: accounts/{account}
        /// </param>
        /// <param name="accountLabel">
        /// Required. The label to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccountLabel CreateAccountLabel(AccountName parent, AccountLabel accountLabel, gaxgrpc::CallSettings callSettings = null) =>
            CreateAccountLabel(new CreateAccountLabelRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AccountLabel = gax::GaxPreconditions.CheckNotNull(accountLabel, nameof(accountLabel)),
            }, callSettings);

        /// <summary>
        /// Creates a new label, not assigned to any account.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent account.
        /// Format: accounts/{account}
        /// </param>
        /// <param name="accountLabel">
        /// Required. The label to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountLabel> CreateAccountLabelAsync(AccountName parent, AccountLabel accountLabel, gaxgrpc::CallSettings callSettings = null) =>
            CreateAccountLabelAsync(new CreateAccountLabelRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AccountLabel = gax::GaxPreconditions.CheckNotNull(accountLabel, nameof(accountLabel)),
            }, callSettings);

        /// <summary>
        /// Creates a new label, not assigned to any account.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent account.
        /// Format: accounts/{account}
        /// </param>
        /// <param name="accountLabel">
        /// Required. The label to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountLabel> CreateAccountLabelAsync(AccountName parent, AccountLabel accountLabel, st::CancellationToken cancellationToken) =>
            CreateAccountLabelAsync(parent, accountLabel, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a label.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccountLabel UpdateAccountLabel(UpdateAccountLabelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a label.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountLabel> UpdateAccountLabelAsync(UpdateAccountLabelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a label.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountLabel> UpdateAccountLabelAsync(UpdateAccountLabelRequest request, st::CancellationToken cancellationToken) =>
            UpdateAccountLabelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a label.
        /// </summary>
        /// <param name="accountLabel">
        /// Required. The updated label. All fields must be provided.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AccountLabel UpdateAccountLabel(AccountLabel accountLabel, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAccountLabel(new UpdateAccountLabelRequest
            {
                AccountLabel = gax::GaxPreconditions.CheckNotNull(accountLabel, nameof(accountLabel)),
            }, callSettings);

        /// <summary>
        /// Updates a label.
        /// </summary>
        /// <param name="accountLabel">
        /// Required. The updated label. All fields must be provided.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountLabel> UpdateAccountLabelAsync(AccountLabel accountLabel, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAccountLabelAsync(new UpdateAccountLabelRequest
            {
                AccountLabel = gax::GaxPreconditions.CheckNotNull(accountLabel, nameof(accountLabel)),
            }, callSettings);

        /// <summary>
        /// Updates a label.
        /// </summary>
        /// <param name="accountLabel">
        /// Required. The updated label. All fields must be provided.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AccountLabel> UpdateAccountLabelAsync(AccountLabel accountLabel, st::CancellationToken cancellationToken) =>
            UpdateAccountLabelAsync(accountLabel, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a label and removes it from all accounts to which it was assigned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAccountLabel(DeleteAccountLabelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a label and removes it from all accounts to which it was assigned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAccountLabelAsync(DeleteAccountLabelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a label and removes it from all accounts to which it was assigned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAccountLabelAsync(DeleteAccountLabelRequest request, st::CancellationToken cancellationToken) =>
            DeleteAccountLabelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a label and removes it from all accounts to which it was assigned.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the label to delete.
        /// Format:  accounts/{account}/labels/{label}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAccountLabel(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAccountLabel(new DeleteAccountLabelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a label and removes it from all accounts to which it was assigned.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the label to delete.
        /// Format:  accounts/{account}/labels/{label}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAccountLabelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAccountLabelAsync(new DeleteAccountLabelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a label and removes it from all accounts to which it was assigned.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the label to delete.
        /// Format:  accounts/{account}/labels/{label}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAccountLabelAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAccountLabelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a label and removes it from all accounts to which it was assigned.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the label to delete.
        /// Format:  accounts/{account}/labels/{label}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAccountLabel(AccountLabelName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAccountLabel(new DeleteAccountLabelRequest
            {
                AccountLabelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a label and removes it from all accounts to which it was assigned.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the label to delete.
        /// Format:  accounts/{account}/labels/{label}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAccountLabelAsync(AccountLabelName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAccountLabelAsync(new DeleteAccountLabelRequest
            {
                AccountLabelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a label and removes it from all accounts to which it was assigned.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the label to delete.
        /// Format:  accounts/{account}/labels/{label}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAccountLabelAsync(AccountLabelName name, st::CancellationToken cancellationToken) =>
            DeleteAccountLabelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AccountLabelsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Manages Merchant Center and CSS accounts labels.
    /// </remarks>
    public sealed partial class AccountLabelsServiceClientImpl : AccountLabelsServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListAccountLabelsRequest, ListAccountLabelsResponse> _callListAccountLabels;

        private readonly gaxgrpc::ApiCall<CreateAccountLabelRequest, AccountLabel> _callCreateAccountLabel;

        private readonly gaxgrpc::ApiCall<UpdateAccountLabelRequest, AccountLabel> _callUpdateAccountLabel;

        private readonly gaxgrpc::ApiCall<DeleteAccountLabelRequest, wkt::Empty> _callDeleteAccountLabel;

        /// <summary>
        /// Constructs a client wrapper for the AccountLabelsService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AccountLabelsServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AccountLabelsServiceClientImpl(AccountLabelsService.AccountLabelsServiceClient grpcClient, AccountLabelsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AccountLabelsServiceSettings effectiveSettings = settings ?? AccountLabelsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callListAccountLabels = clientHelper.BuildApiCall<ListAccountLabelsRequest, ListAccountLabelsResponse>("ListAccountLabels", grpcClient.ListAccountLabelsAsync, grpcClient.ListAccountLabels, effectiveSettings.ListAccountLabelsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAccountLabels);
            Modify_ListAccountLabelsApiCall(ref _callListAccountLabels);
            _callCreateAccountLabel = clientHelper.BuildApiCall<CreateAccountLabelRequest, AccountLabel>("CreateAccountLabel", grpcClient.CreateAccountLabelAsync, grpcClient.CreateAccountLabel, effectiveSettings.CreateAccountLabelSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAccountLabel);
            Modify_CreateAccountLabelApiCall(ref _callCreateAccountLabel);
            _callUpdateAccountLabel = clientHelper.BuildApiCall<UpdateAccountLabelRequest, AccountLabel>("UpdateAccountLabel", grpcClient.UpdateAccountLabelAsync, grpcClient.UpdateAccountLabel, effectiveSettings.UpdateAccountLabelSettings).WithGoogleRequestParam("account_label.name", request => request.AccountLabel?.Name);
            Modify_ApiCall(ref _callUpdateAccountLabel);
            Modify_UpdateAccountLabelApiCall(ref _callUpdateAccountLabel);
            _callDeleteAccountLabel = clientHelper.BuildApiCall<DeleteAccountLabelRequest, wkt::Empty>("DeleteAccountLabel", grpcClient.DeleteAccountLabelAsync, grpcClient.DeleteAccountLabel, effectiveSettings.DeleteAccountLabelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAccountLabel);
            Modify_DeleteAccountLabelApiCall(ref _callDeleteAccountLabel);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListAccountLabelsApiCall(ref gaxgrpc::ApiCall<ListAccountLabelsRequest, ListAccountLabelsResponse> call);

        partial void Modify_CreateAccountLabelApiCall(ref gaxgrpc::ApiCall<CreateAccountLabelRequest, AccountLabel> call);

        partial void Modify_UpdateAccountLabelApiCall(ref gaxgrpc::ApiCall<UpdateAccountLabelRequest, AccountLabel> call);

        partial void Modify_DeleteAccountLabelApiCall(ref gaxgrpc::ApiCall<DeleteAccountLabelRequest, wkt::Empty> call);

        partial void OnConstruction(AccountLabelsService.AccountLabelsServiceClient grpcClient, AccountLabelsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AccountLabelsService client</summary>
        public override AccountLabelsService.AccountLabelsServiceClient GrpcClient { get; }

        partial void Modify_ListAccountLabelsRequest(ref ListAccountLabelsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAccountLabelRequest(ref CreateAccountLabelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAccountLabelRequest(ref UpdateAccountLabelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAccountLabelRequest(ref DeleteAccountLabelRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists the labels assigned to an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AccountLabel"/> resources.</returns>
        public override gax::PagedEnumerable<ListAccountLabelsResponse, AccountLabel> ListAccountLabels(ListAccountLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAccountLabelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAccountLabelsRequest, ListAccountLabelsResponse, AccountLabel>(_callListAccountLabels, request, callSettings);
        }

        /// <summary>
        /// Lists the labels assigned to an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AccountLabel"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAccountLabelsResponse, AccountLabel> ListAccountLabelsAsync(ListAccountLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAccountLabelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAccountLabelsRequest, ListAccountLabelsResponse, AccountLabel>(_callListAccountLabels, request, callSettings);
        }

        /// <summary>
        /// Creates a new label, not assigned to any account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AccountLabel CreateAccountLabel(CreateAccountLabelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAccountLabelRequest(ref request, ref callSettings);
            return _callCreateAccountLabel.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new label, not assigned to any account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AccountLabel> CreateAccountLabelAsync(CreateAccountLabelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAccountLabelRequest(ref request, ref callSettings);
            return _callCreateAccountLabel.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a label.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AccountLabel UpdateAccountLabel(UpdateAccountLabelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAccountLabelRequest(ref request, ref callSettings);
            return _callUpdateAccountLabel.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a label.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AccountLabel> UpdateAccountLabelAsync(UpdateAccountLabelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAccountLabelRequest(ref request, ref callSettings);
            return _callUpdateAccountLabel.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a label and removes it from all accounts to which it was assigned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteAccountLabel(DeleteAccountLabelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAccountLabelRequest(ref request, ref callSettings);
            _callDeleteAccountLabel.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a label and removes it from all accounts to which it was assigned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteAccountLabelAsync(DeleteAccountLabelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAccountLabelRequest(ref request, ref callSettings);
            return _callDeleteAccountLabel.Async(request, callSettings);
        }
    }

    public partial class ListAccountLabelsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAccountLabelsResponse : gaxgrpc::IPageResponse<AccountLabel>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AccountLabel> GetEnumerator() => AccountLabels.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
