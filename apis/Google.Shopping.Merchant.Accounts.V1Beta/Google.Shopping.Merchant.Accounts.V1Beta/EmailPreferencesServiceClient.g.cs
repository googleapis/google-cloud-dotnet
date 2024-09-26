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
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Shopping.Merchant.Accounts.V1Beta
{
    /// <summary>Settings for <see cref="EmailPreferencesServiceClient"/> instances.</summary>
    public sealed partial class EmailPreferencesServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="EmailPreferencesServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="EmailPreferencesServiceSettings"/>.</returns>
        public static EmailPreferencesServiceSettings GetDefault() => new EmailPreferencesServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="EmailPreferencesServiceSettings"/> object with default settings.
        /// </summary>
        public EmailPreferencesServiceSettings()
        {
        }

        private EmailPreferencesServiceSettings(EmailPreferencesServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetEmailPreferencesSettings = existing.GetEmailPreferencesSettings;
            UpdateEmailPreferencesSettings = existing.UpdateEmailPreferencesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(EmailPreferencesServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EmailPreferencesServiceClient.GetEmailPreferences</c> and
        /// <c>EmailPreferencesServiceClient.GetEmailPreferencesAsync</c>.
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
        public gaxgrpc::CallSettings GetEmailPreferencesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EmailPreferencesServiceClient.UpdateEmailPreferences</c> and
        /// <c>EmailPreferencesServiceClient.UpdateEmailPreferencesAsync</c>.
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
        public gaxgrpc::CallSettings UpdateEmailPreferencesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="EmailPreferencesServiceSettings"/> object.</returns>
        public EmailPreferencesServiceSettings Clone() => new EmailPreferencesServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="EmailPreferencesServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class EmailPreferencesServiceClientBuilder : gaxgrpc::ClientBuilderBase<EmailPreferencesServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public EmailPreferencesServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public EmailPreferencesServiceClientBuilder() : base(EmailPreferencesServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref EmailPreferencesServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<EmailPreferencesServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override EmailPreferencesServiceClient Build()
        {
            EmailPreferencesServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<EmailPreferencesServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<EmailPreferencesServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private EmailPreferencesServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return EmailPreferencesServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<EmailPreferencesServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return EmailPreferencesServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => EmailPreferencesServiceClient.ChannelPool;
    }

    /// <summary>EmailPreferencesService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to support the `EmailPreferences` API.
    /// 
    /// This service only permits retrieving and updating email preferences for the
    /// authenticated user.
    /// </remarks>
    public abstract partial class EmailPreferencesServiceClient
    {
        /// <summary>
        /// The default endpoint for the EmailPreferencesService service, which is a host of
        /// "merchantapi.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default EmailPreferencesService scopes.</summary>
        /// <remarks>
        /// The default EmailPreferencesService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(EmailPreferencesService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="EmailPreferencesServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="EmailPreferencesServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="EmailPreferencesServiceClient"/>.</returns>
        public static stt::Task<EmailPreferencesServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new EmailPreferencesServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="EmailPreferencesServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="EmailPreferencesServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="EmailPreferencesServiceClient"/>.</returns>
        public static EmailPreferencesServiceClient Create() => new EmailPreferencesServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="EmailPreferencesServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="EmailPreferencesServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="EmailPreferencesServiceClient"/>.</returns>
        internal static EmailPreferencesServiceClient Create(grpccore::CallInvoker callInvoker, EmailPreferencesServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            EmailPreferencesService.EmailPreferencesServiceClient grpcClient = new EmailPreferencesService.EmailPreferencesServiceClient(callInvoker);
            return new EmailPreferencesServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC EmailPreferencesService client</summary>
        public virtual EmailPreferencesService.EmailPreferencesServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the email preferences for a Merchant Center account user.
        /// 
        /// Use the name=accounts/*/users/me/emailPreferences alias to get preferences
        /// for the authenticated user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EmailPreferences GetEmailPreferences(GetEmailPreferencesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the email preferences for a Merchant Center account user.
        /// 
        /// Use the name=accounts/*/users/me/emailPreferences alias to get preferences
        /// for the authenticated user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EmailPreferences> GetEmailPreferencesAsync(GetEmailPreferencesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the email preferences for a Merchant Center account user.
        /// 
        /// Use the name=accounts/*/users/me/emailPreferences alias to get preferences
        /// for the authenticated user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EmailPreferences> GetEmailPreferencesAsync(GetEmailPreferencesRequest request, st::CancellationToken cancellationToken) =>
            GetEmailPreferencesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the email preferences for a Merchant Center account user.
        /// 
        /// Use the name=accounts/*/users/me/emailPreferences alias to get preferences
        /// for the authenticated user.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `EmailPreferences` resource.
        /// Format: `accounts/{account}/users/{email}/emailPreferences`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EmailPreferences GetEmailPreferences(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEmailPreferences(new GetEmailPreferencesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the email preferences for a Merchant Center account user.
        /// 
        /// Use the name=accounts/*/users/me/emailPreferences alias to get preferences
        /// for the authenticated user.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `EmailPreferences` resource.
        /// Format: `accounts/{account}/users/{email}/emailPreferences`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EmailPreferences> GetEmailPreferencesAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEmailPreferencesAsync(new GetEmailPreferencesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the email preferences for a Merchant Center account user.
        /// 
        /// Use the name=accounts/*/users/me/emailPreferences alias to get preferences
        /// for the authenticated user.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `EmailPreferences` resource.
        /// Format: `accounts/{account}/users/{email}/emailPreferences`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EmailPreferences> GetEmailPreferencesAsync(string name, st::CancellationToken cancellationToken) =>
            GetEmailPreferencesAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the email preferences for a Merchant Center account user.
        /// 
        /// Use the name=accounts/*/users/me/emailPreferences alias to get preferences
        /// for the authenticated user.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `EmailPreferences` resource.
        /// Format: `accounts/{account}/users/{email}/emailPreferences`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EmailPreferences GetEmailPreferences(EmailPreferencesName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEmailPreferences(new GetEmailPreferencesRequest
            {
                EmailPreferencesName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the email preferences for a Merchant Center account user.
        /// 
        /// Use the name=accounts/*/users/me/emailPreferences alias to get preferences
        /// for the authenticated user.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `EmailPreferences` resource.
        /// Format: `accounts/{account}/users/{email}/emailPreferences`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EmailPreferences> GetEmailPreferencesAsync(EmailPreferencesName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEmailPreferencesAsync(new GetEmailPreferencesRequest
            {
                EmailPreferencesName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the email preferences for a Merchant Center account user.
        /// 
        /// Use the name=accounts/*/users/me/emailPreferences alias to get preferences
        /// for the authenticated user.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `EmailPreferences` resource.
        /// Format: `accounts/{account}/users/{email}/emailPreferences`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EmailPreferences> GetEmailPreferencesAsync(EmailPreferencesName name, st::CancellationToken cancellationToken) =>
            GetEmailPreferencesAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the email preferences for a Merchant Center account user. MCA users
        /// should specify the MCA account rather than a sub-account of the MCA.
        /// 
        /// Preferences which are not explicitly selected in the update mask will not
        /// be updated.
        /// 
        /// It is invalid for updates to specify an UNCONFIRMED opt-in status value.
        /// 
        /// Use the name=accounts/*/users/me/emailPreferences alias to update
        /// preferences
        /// for the authenticated user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EmailPreferences UpdateEmailPreferences(UpdateEmailPreferencesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the email preferences for a Merchant Center account user. MCA users
        /// should specify the MCA account rather than a sub-account of the MCA.
        /// 
        /// Preferences which are not explicitly selected in the update mask will not
        /// be updated.
        /// 
        /// It is invalid for updates to specify an UNCONFIRMED opt-in status value.
        /// 
        /// Use the name=accounts/*/users/me/emailPreferences alias to update
        /// preferences
        /// for the authenticated user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EmailPreferences> UpdateEmailPreferencesAsync(UpdateEmailPreferencesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the email preferences for a Merchant Center account user. MCA users
        /// should specify the MCA account rather than a sub-account of the MCA.
        /// 
        /// Preferences which are not explicitly selected in the update mask will not
        /// be updated.
        /// 
        /// It is invalid for updates to specify an UNCONFIRMED opt-in status value.
        /// 
        /// Use the name=accounts/*/users/me/emailPreferences alias to update
        /// preferences
        /// for the authenticated user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EmailPreferences> UpdateEmailPreferencesAsync(UpdateEmailPreferencesRequest request, st::CancellationToken cancellationToken) =>
            UpdateEmailPreferencesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the email preferences for a Merchant Center account user. MCA users
        /// should specify the MCA account rather than a sub-account of the MCA.
        /// 
        /// Preferences which are not explicitly selected in the update mask will not
        /// be updated.
        /// 
        /// It is invalid for updates to specify an UNCONFIRMED opt-in status value.
        /// 
        /// Use the name=accounts/*/users/me/emailPreferences alias to update
        /// preferences
        /// for the authenticated user.
        /// </summary>
        /// <param name="emailPreferences">
        /// Required. Email Preferences to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields being updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EmailPreferences UpdateEmailPreferences(EmailPreferences emailPreferences, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEmailPreferences(new UpdateEmailPreferencesRequest
            {
                EmailPreferences = gax::GaxPreconditions.CheckNotNull(emailPreferences, nameof(emailPreferences)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the email preferences for a Merchant Center account user. MCA users
        /// should specify the MCA account rather than a sub-account of the MCA.
        /// 
        /// Preferences which are not explicitly selected in the update mask will not
        /// be updated.
        /// 
        /// It is invalid for updates to specify an UNCONFIRMED opt-in status value.
        /// 
        /// Use the name=accounts/*/users/me/emailPreferences alias to update
        /// preferences
        /// for the authenticated user.
        /// </summary>
        /// <param name="emailPreferences">
        /// Required. Email Preferences to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields being updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EmailPreferences> UpdateEmailPreferencesAsync(EmailPreferences emailPreferences, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEmailPreferencesAsync(new UpdateEmailPreferencesRequest
            {
                EmailPreferences = gax::GaxPreconditions.CheckNotNull(emailPreferences, nameof(emailPreferences)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the email preferences for a Merchant Center account user. MCA users
        /// should specify the MCA account rather than a sub-account of the MCA.
        /// 
        /// Preferences which are not explicitly selected in the update mask will not
        /// be updated.
        /// 
        /// It is invalid for updates to specify an UNCONFIRMED opt-in status value.
        /// 
        /// Use the name=accounts/*/users/me/emailPreferences alias to update
        /// preferences
        /// for the authenticated user.
        /// </summary>
        /// <param name="emailPreferences">
        /// Required. Email Preferences to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields being updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EmailPreferences> UpdateEmailPreferencesAsync(EmailPreferences emailPreferences, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateEmailPreferencesAsync(emailPreferences, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>EmailPreferencesService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to support the `EmailPreferences` API.
    /// 
    /// This service only permits retrieving and updating email preferences for the
    /// authenticated user.
    /// </remarks>
    public sealed partial class EmailPreferencesServiceClientImpl : EmailPreferencesServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetEmailPreferencesRequest, EmailPreferences> _callGetEmailPreferences;

        private readonly gaxgrpc::ApiCall<UpdateEmailPreferencesRequest, EmailPreferences> _callUpdateEmailPreferences;

        /// <summary>
        /// Constructs a client wrapper for the EmailPreferencesService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="EmailPreferencesServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public EmailPreferencesServiceClientImpl(EmailPreferencesService.EmailPreferencesServiceClient grpcClient, EmailPreferencesServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            EmailPreferencesServiceSettings effectiveSettings = settings ?? EmailPreferencesServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetEmailPreferences = clientHelper.BuildApiCall<GetEmailPreferencesRequest, EmailPreferences>("GetEmailPreferences", grpcClient.GetEmailPreferencesAsync, grpcClient.GetEmailPreferences, effectiveSettings.GetEmailPreferencesSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEmailPreferences);
            Modify_GetEmailPreferencesApiCall(ref _callGetEmailPreferences);
            _callUpdateEmailPreferences = clientHelper.BuildApiCall<UpdateEmailPreferencesRequest, EmailPreferences>("UpdateEmailPreferences", grpcClient.UpdateEmailPreferencesAsync, grpcClient.UpdateEmailPreferences, effectiveSettings.UpdateEmailPreferencesSettings).WithGoogleRequestParam("email_preferences.name", request => request.EmailPreferences?.Name);
            Modify_ApiCall(ref _callUpdateEmailPreferences);
            Modify_UpdateEmailPreferencesApiCall(ref _callUpdateEmailPreferences);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetEmailPreferencesApiCall(ref gaxgrpc::ApiCall<GetEmailPreferencesRequest, EmailPreferences> call);

        partial void Modify_UpdateEmailPreferencesApiCall(ref gaxgrpc::ApiCall<UpdateEmailPreferencesRequest, EmailPreferences> call);

        partial void OnConstruction(EmailPreferencesService.EmailPreferencesServiceClient grpcClient, EmailPreferencesServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC EmailPreferencesService client</summary>
        public override EmailPreferencesService.EmailPreferencesServiceClient GrpcClient { get; }

        partial void Modify_GetEmailPreferencesRequest(ref GetEmailPreferencesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateEmailPreferencesRequest(ref UpdateEmailPreferencesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the email preferences for a Merchant Center account user.
        /// 
        /// Use the name=accounts/*/users/me/emailPreferences alias to get preferences
        /// for the authenticated user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EmailPreferences GetEmailPreferences(GetEmailPreferencesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEmailPreferencesRequest(ref request, ref callSettings);
            return _callGetEmailPreferences.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the email preferences for a Merchant Center account user.
        /// 
        /// Use the name=accounts/*/users/me/emailPreferences alias to get preferences
        /// for the authenticated user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EmailPreferences> GetEmailPreferencesAsync(GetEmailPreferencesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEmailPreferencesRequest(ref request, ref callSettings);
            return _callGetEmailPreferences.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the email preferences for a Merchant Center account user. MCA users
        /// should specify the MCA account rather than a sub-account of the MCA.
        /// 
        /// Preferences which are not explicitly selected in the update mask will not
        /// be updated.
        /// 
        /// It is invalid for updates to specify an UNCONFIRMED opt-in status value.
        /// 
        /// Use the name=accounts/*/users/me/emailPreferences alias to update
        /// preferences
        /// for the authenticated user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EmailPreferences UpdateEmailPreferences(UpdateEmailPreferencesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEmailPreferencesRequest(ref request, ref callSettings);
            return _callUpdateEmailPreferences.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the email preferences for a Merchant Center account user. MCA users
        /// should specify the MCA account rather than a sub-account of the MCA.
        /// 
        /// Preferences which are not explicitly selected in the update mask will not
        /// be updated.
        /// 
        /// It is invalid for updates to specify an UNCONFIRMED opt-in status value.
        /// 
        /// Use the name=accounts/*/users/me/emailPreferences alias to update
        /// preferences
        /// for the authenticated user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EmailPreferences> UpdateEmailPreferencesAsync(UpdateEmailPreferencesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEmailPreferencesRequest(ref request, ref callSettings);
            return _callUpdateEmailPreferences.Async(request, callSettings);
        }
    }
}
