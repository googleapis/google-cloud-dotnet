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

namespace Google.Shopping.Merchant.Conversions.V1Beta
{
    /// <summary>Settings for <see cref="ConversionSourcesServiceClient"/> instances.</summary>
    public sealed partial class ConversionSourcesServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ConversionSourcesServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ConversionSourcesServiceSettings"/>.</returns>
        public static ConversionSourcesServiceSettings GetDefault() => new ConversionSourcesServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ConversionSourcesServiceSettings"/> object with default settings.
        /// </summary>
        public ConversionSourcesServiceSettings()
        {
        }

        private ConversionSourcesServiceSettings(ConversionSourcesServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateConversionSourceSettings = existing.CreateConversionSourceSettings;
            UpdateConversionSourceSettings = existing.UpdateConversionSourceSettings;
            DeleteConversionSourceSettings = existing.DeleteConversionSourceSettings;
            UndeleteConversionSourceSettings = existing.UndeleteConversionSourceSettings;
            GetConversionSourceSettings = existing.GetConversionSourceSettings;
            ListConversionSourcesSettings = existing.ListConversionSourcesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ConversionSourcesServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversionSourcesServiceClient.CreateConversionSource</c> and
        /// <c>ConversionSourcesServiceClient.CreateConversionSourceAsync</c>.
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
        public gaxgrpc::CallSettings CreateConversionSourceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversionSourcesServiceClient.UpdateConversionSource</c> and
        /// <c>ConversionSourcesServiceClient.UpdateConversionSourceAsync</c>.
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
        public gaxgrpc::CallSettings UpdateConversionSourceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversionSourcesServiceClient.DeleteConversionSource</c> and
        /// <c>ConversionSourcesServiceClient.DeleteConversionSourceAsync</c>.
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
        public gaxgrpc::CallSettings DeleteConversionSourceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversionSourcesServiceClient.UndeleteConversionSource</c> and
        /// <c>ConversionSourcesServiceClient.UndeleteConversionSourceAsync</c>.
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
        public gaxgrpc::CallSettings UndeleteConversionSourceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversionSourcesServiceClient.GetConversionSource</c> and
        /// <c>ConversionSourcesServiceClient.GetConversionSourceAsync</c>.
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
        public gaxgrpc::CallSettings GetConversionSourceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversionSourcesServiceClient.ListConversionSources</c> and
        /// <c>ConversionSourcesServiceClient.ListConversionSourcesAsync</c>.
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
        public gaxgrpc::CallSettings ListConversionSourcesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ConversionSourcesServiceSettings"/> object.</returns>
        public ConversionSourcesServiceSettings Clone() => new ConversionSourcesServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ConversionSourcesServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ConversionSourcesServiceClientBuilder : gaxgrpc::ClientBuilderBase<ConversionSourcesServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ConversionSourcesServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ConversionSourcesServiceClientBuilder() : base(ConversionSourcesServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ConversionSourcesServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ConversionSourcesServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ConversionSourcesServiceClient Build()
        {
            ConversionSourcesServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ConversionSourcesServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ConversionSourcesServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ConversionSourcesServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ConversionSourcesServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ConversionSourcesServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ConversionSourcesServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ConversionSourcesServiceClient.ChannelPool;
    }

    /// <summary>ConversionSourcesService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing conversion sources for a merchant account.
    /// </remarks>
    public abstract partial class ConversionSourcesServiceClient
    {
        /// <summary>
        /// The default endpoint for the ConversionSourcesService service, which is a host of
        /// "merchantapi.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default ConversionSourcesService scopes.</summary>
        /// <remarks>
        /// The default ConversionSourcesService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ConversionSourcesService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ConversionSourcesServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ConversionSourcesServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ConversionSourcesServiceClient"/>.</returns>
        public static stt::Task<ConversionSourcesServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ConversionSourcesServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ConversionSourcesServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ConversionSourcesServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ConversionSourcesServiceClient"/>.</returns>
        public static ConversionSourcesServiceClient Create() => new ConversionSourcesServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ConversionSourcesServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ConversionSourcesServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ConversionSourcesServiceClient"/>.</returns>
        internal static ConversionSourcesServiceClient Create(grpccore::CallInvoker callInvoker, ConversionSourcesServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ConversionSourcesService.ConversionSourcesServiceClient grpcClient = new ConversionSourcesService.ConversionSourcesServiceClient(callInvoker);
            return new ConversionSourcesServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ConversionSourcesService client</summary>
        public virtual ConversionSourcesService.ConversionSourcesServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new conversion source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConversionSource CreateConversionSource(CreateConversionSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new conversion source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversionSource> CreateConversionSourceAsync(CreateConversionSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new conversion source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversionSource> CreateConversionSourceAsync(CreateConversionSourceRequest request, st::CancellationToken cancellationToken) =>
            CreateConversionSourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new conversion source.
        /// </summary>
        /// <param name="parent">
        /// Required. The merchant account that will own the new conversion source.
        /// Format: accounts/{account}
        /// </param>
        /// <param name="conversionSource">
        /// Required. The conversion source description. A new ID will be automatically
        /// assigned to it upon creation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConversionSource CreateConversionSource(string parent, ConversionSource conversionSource, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversionSource(new CreateConversionSourceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ConversionSource = gax::GaxPreconditions.CheckNotNull(conversionSource, nameof(conversionSource)),
            }, callSettings);

        /// <summary>
        /// Creates a new conversion source.
        /// </summary>
        /// <param name="parent">
        /// Required. The merchant account that will own the new conversion source.
        /// Format: accounts/{account}
        /// </param>
        /// <param name="conversionSource">
        /// Required. The conversion source description. A new ID will be automatically
        /// assigned to it upon creation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversionSource> CreateConversionSourceAsync(string parent, ConversionSource conversionSource, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversionSourceAsync(new CreateConversionSourceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ConversionSource = gax::GaxPreconditions.CheckNotNull(conversionSource, nameof(conversionSource)),
            }, callSettings);

        /// <summary>
        /// Creates a new conversion source.
        /// </summary>
        /// <param name="parent">
        /// Required. The merchant account that will own the new conversion source.
        /// Format: accounts/{account}
        /// </param>
        /// <param name="conversionSource">
        /// Required. The conversion source description. A new ID will be automatically
        /// assigned to it upon creation.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversionSource> CreateConversionSourceAsync(string parent, ConversionSource conversionSource, st::CancellationToken cancellationToken) =>
            CreateConversionSourceAsync(parent, conversionSource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new conversion source.
        /// </summary>
        /// <param name="parent">
        /// Required. The merchant account that will own the new conversion source.
        /// Format: accounts/{account}
        /// </param>
        /// <param name="conversionSource">
        /// Required. The conversion source description. A new ID will be automatically
        /// assigned to it upon creation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConversionSource CreateConversionSource(AccountName parent, ConversionSource conversionSource, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversionSource(new CreateConversionSourceRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ConversionSource = gax::GaxPreconditions.CheckNotNull(conversionSource, nameof(conversionSource)),
            }, callSettings);

        /// <summary>
        /// Creates a new conversion source.
        /// </summary>
        /// <param name="parent">
        /// Required. The merchant account that will own the new conversion source.
        /// Format: accounts/{account}
        /// </param>
        /// <param name="conversionSource">
        /// Required. The conversion source description. A new ID will be automatically
        /// assigned to it upon creation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversionSource> CreateConversionSourceAsync(AccountName parent, ConversionSource conversionSource, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversionSourceAsync(new CreateConversionSourceRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ConversionSource = gax::GaxPreconditions.CheckNotNull(conversionSource, nameof(conversionSource)),
            }, callSettings);

        /// <summary>
        /// Creates a new conversion source.
        /// </summary>
        /// <param name="parent">
        /// Required. The merchant account that will own the new conversion source.
        /// Format: accounts/{account}
        /// </param>
        /// <param name="conversionSource">
        /// Required. The conversion source description. A new ID will be automatically
        /// assigned to it upon creation.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversionSource> CreateConversionSourceAsync(AccountName parent, ConversionSource conversionSource, st::CancellationToken cancellationToken) =>
            CreateConversionSourceAsync(parent, conversionSource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates information of an existing conversion source. Available only for
        /// Merchant Center Destination conversion sources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConversionSource UpdateConversionSource(UpdateConversionSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates information of an existing conversion source. Available only for
        /// Merchant Center Destination conversion sources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversionSource> UpdateConversionSourceAsync(UpdateConversionSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates information of an existing conversion source. Available only for
        /// Merchant Center Destination conversion sources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversionSource> UpdateConversionSourceAsync(UpdateConversionSourceRequest request, st::CancellationToken cancellationToken) =>
            UpdateConversionSourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates information of an existing conversion source. Available only for
        /// Merchant Center Destination conversion sources.
        /// </summary>
        /// <param name="conversionSource">
        /// Required. The new version of the conversion source data.
        /// Format: accounts/{account}/conversionSources/{conversion_source}
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields being updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConversionSource UpdateConversionSource(ConversionSource conversionSource, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConversionSource(new UpdateConversionSourceRequest
            {
                ConversionSource = gax::GaxPreconditions.CheckNotNull(conversionSource, nameof(conversionSource)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates information of an existing conversion source. Available only for
        /// Merchant Center Destination conversion sources.
        /// </summary>
        /// <param name="conversionSource">
        /// Required. The new version of the conversion source data.
        /// Format: accounts/{account}/conversionSources/{conversion_source}
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields being updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversionSource> UpdateConversionSourceAsync(ConversionSource conversionSource, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConversionSourceAsync(new UpdateConversionSourceRequest
            {
                ConversionSource = gax::GaxPreconditions.CheckNotNull(conversionSource, nameof(conversionSource)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates information of an existing conversion source. Available only for
        /// Merchant Center Destination conversion sources.
        /// </summary>
        /// <param name="conversionSource">
        /// Required. The new version of the conversion source data.
        /// Format: accounts/{account}/conversionSources/{conversion_source}
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields being updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversionSource> UpdateConversionSourceAsync(ConversionSource conversionSource, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateConversionSourceAsync(conversionSource, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Archives an existing conversion source. If the conversion source is a
        /// Merchant Center Destination, it will be recoverable for 30 days. If the
        /// conversion source is a Google Analytics Link, it will be deleted
        /// immediately and can be restored by creating a new one.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteConversionSource(DeleteConversionSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Archives an existing conversion source. If the conversion source is a
        /// Merchant Center Destination, it will be recoverable for 30 days. If the
        /// conversion source is a Google Analytics Link, it will be deleted
        /// immediately and can be restored by creating a new one.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversionSourceAsync(DeleteConversionSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Archives an existing conversion source. If the conversion source is a
        /// Merchant Center Destination, it will be recoverable for 30 days. If the
        /// conversion source is a Google Analytics Link, it will be deleted
        /// immediately and can be restored by creating a new one.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversionSourceAsync(DeleteConversionSourceRequest request, st::CancellationToken cancellationToken) =>
            DeleteConversionSourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Archives an existing conversion source. If the conversion source is a
        /// Merchant Center Destination, it will be recoverable for 30 days. If the
        /// conversion source is a Google Analytics Link, it will be deleted
        /// immediately and can be restored by creating a new one.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversion source to be deleted.
        /// Format: accounts/{account}/conversionSources/{conversion_source}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteConversionSource(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversionSource(new DeleteConversionSourceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Archives an existing conversion source. If the conversion source is a
        /// Merchant Center Destination, it will be recoverable for 30 days. If the
        /// conversion source is a Google Analytics Link, it will be deleted
        /// immediately and can be restored by creating a new one.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversion source to be deleted.
        /// Format: accounts/{account}/conversionSources/{conversion_source}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversionSourceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversionSourceAsync(new DeleteConversionSourceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Archives an existing conversion source. If the conversion source is a
        /// Merchant Center Destination, it will be recoverable for 30 days. If the
        /// conversion source is a Google Analytics Link, it will be deleted
        /// immediately and can be restored by creating a new one.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversion source to be deleted.
        /// Format: accounts/{account}/conversionSources/{conversion_source}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversionSourceAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteConversionSourceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Archives an existing conversion source. If the conversion source is a
        /// Merchant Center Destination, it will be recoverable for 30 days. If the
        /// conversion source is a Google Analytics Link, it will be deleted
        /// immediately and can be restored by creating a new one.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversion source to be deleted.
        /// Format: accounts/{account}/conversionSources/{conversion_source}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteConversionSource(ConversionSourceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversionSource(new DeleteConversionSourceRequest
            {
                ConversionSourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Archives an existing conversion source. If the conversion source is a
        /// Merchant Center Destination, it will be recoverable for 30 days. If the
        /// conversion source is a Google Analytics Link, it will be deleted
        /// immediately and can be restored by creating a new one.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversion source to be deleted.
        /// Format: accounts/{account}/conversionSources/{conversion_source}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversionSourceAsync(ConversionSourceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversionSourceAsync(new DeleteConversionSourceRequest
            {
                ConversionSourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Archives an existing conversion source. If the conversion source is a
        /// Merchant Center Destination, it will be recoverable for 30 days. If the
        /// conversion source is a Google Analytics Link, it will be deleted
        /// immediately and can be restored by creating a new one.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversion source to be deleted.
        /// Format: accounts/{account}/conversionSources/{conversion_source}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversionSourceAsync(ConversionSourceName name, st::CancellationToken cancellationToken) =>
            DeleteConversionSourceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Re-enables an archived conversion source. Only Available for Merchant
        /// Center Destination conversion sources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConversionSource UndeleteConversionSource(UndeleteConversionSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Re-enables an archived conversion source. Only Available for Merchant
        /// Center Destination conversion sources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversionSource> UndeleteConversionSourceAsync(UndeleteConversionSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Re-enables an archived conversion source. Only Available for Merchant
        /// Center Destination conversion sources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversionSource> UndeleteConversionSourceAsync(UndeleteConversionSourceRequest request, st::CancellationToken cancellationToken) =>
            UndeleteConversionSourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches a conversion source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConversionSource GetConversionSource(GetConversionSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches a conversion source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversionSource> GetConversionSourceAsync(GetConversionSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches a conversion source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversionSource> GetConversionSourceAsync(GetConversionSourceRequest request, st::CancellationToken cancellationToken) =>
            GetConversionSourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches a conversion source.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversion source to be fetched.
        /// Format: accounts/{account}/conversionsources/{conversion_source}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConversionSource GetConversionSource(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversionSource(new GetConversionSourceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches a conversion source.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversion source to be fetched.
        /// Format: accounts/{account}/conversionsources/{conversion_source}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversionSource> GetConversionSourceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversionSourceAsync(new GetConversionSourceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches a conversion source.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversion source to be fetched.
        /// Format: accounts/{account}/conversionsources/{conversion_source}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversionSource> GetConversionSourceAsync(string name, st::CancellationToken cancellationToken) =>
            GetConversionSourceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches a conversion source.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversion source to be fetched.
        /// Format: accounts/{account}/conversionsources/{conversion_source}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConversionSource GetConversionSource(ConversionSourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversionSource(new GetConversionSourceRequest
            {
                ConversionSourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches a conversion source.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversion source to be fetched.
        /// Format: accounts/{account}/conversionsources/{conversion_source}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversionSource> GetConversionSourceAsync(ConversionSourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversionSourceAsync(new GetConversionSourceRequest
            {
                ConversionSourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches a conversion source.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversion source to be fetched.
        /// Format: accounts/{account}/conversionsources/{conversion_source}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversionSource> GetConversionSourceAsync(ConversionSourceName name, st::CancellationToken cancellationToken) =>
            GetConversionSourceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the list of conversion sources the caller has access to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ConversionSource"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConversionSourcesResponse, ConversionSource> ListConversionSources(ListConversionSourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of conversion sources the caller has access to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ConversionSource"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConversionSourcesResponse, ConversionSource> ListConversionSourcesAsync(ListConversionSourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of conversion sources the caller has access to.
        /// </summary>
        /// <param name="parent">
        /// Required. The merchant account who owns the collection of conversion
        /// sources. Format: accounts/{account}
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
        /// <returns>A pageable sequence of <see cref="ConversionSource"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConversionSourcesResponse, ConversionSource> ListConversionSources(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversionSourcesRequest request = new ListConversionSourcesRequest
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
            return ListConversionSources(request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of conversion sources the caller has access to.
        /// </summary>
        /// <param name="parent">
        /// Required. The merchant account who owns the collection of conversion
        /// sources. Format: accounts/{account}
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
        /// <returns>A pageable asynchronous sequence of <see cref="ConversionSource"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConversionSourcesResponse, ConversionSource> ListConversionSourcesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversionSourcesRequest request = new ListConversionSourcesRequest
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
            return ListConversionSourcesAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of conversion sources the caller has access to.
        /// </summary>
        /// <param name="parent">
        /// Required. The merchant account who owns the collection of conversion
        /// sources. Format: accounts/{account}
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
        /// <returns>A pageable sequence of <see cref="ConversionSource"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConversionSourcesResponse, ConversionSource> ListConversionSources(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversionSourcesRequest request = new ListConversionSourcesRequest
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
            return ListConversionSources(request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of conversion sources the caller has access to.
        /// </summary>
        /// <param name="parent">
        /// Required. The merchant account who owns the collection of conversion
        /// sources. Format: accounts/{account}
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
        /// <returns>A pageable asynchronous sequence of <see cref="ConversionSource"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConversionSourcesResponse, ConversionSource> ListConversionSourcesAsync(AccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversionSourcesRequest request = new ListConversionSourcesRequest
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
            return ListConversionSourcesAsync(request, callSettings);
        }
    }

    /// <summary>ConversionSourcesService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing conversion sources for a merchant account.
    /// </remarks>
    public sealed partial class ConversionSourcesServiceClientImpl : ConversionSourcesServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateConversionSourceRequest, ConversionSource> _callCreateConversionSource;

        private readonly gaxgrpc::ApiCall<UpdateConversionSourceRequest, ConversionSource> _callUpdateConversionSource;

        private readonly gaxgrpc::ApiCall<DeleteConversionSourceRequest, wkt::Empty> _callDeleteConversionSource;

        private readonly gaxgrpc::ApiCall<UndeleteConversionSourceRequest, ConversionSource> _callUndeleteConversionSource;

        private readonly gaxgrpc::ApiCall<GetConversionSourceRequest, ConversionSource> _callGetConversionSource;

        private readonly gaxgrpc::ApiCall<ListConversionSourcesRequest, ListConversionSourcesResponse> _callListConversionSources;

        /// <summary>
        /// Constructs a client wrapper for the ConversionSourcesService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="ConversionSourcesServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ConversionSourcesServiceClientImpl(ConversionSourcesService.ConversionSourcesServiceClient grpcClient, ConversionSourcesServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ConversionSourcesServiceSettings effectiveSettings = settings ?? ConversionSourcesServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCreateConversionSource = clientHelper.BuildApiCall<CreateConversionSourceRequest, ConversionSource>("CreateConversionSource", grpcClient.CreateConversionSourceAsync, grpcClient.CreateConversionSource, effectiveSettings.CreateConversionSourceSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateConversionSource);
            Modify_CreateConversionSourceApiCall(ref _callCreateConversionSource);
            _callUpdateConversionSource = clientHelper.BuildApiCall<UpdateConversionSourceRequest, ConversionSource>("UpdateConversionSource", grpcClient.UpdateConversionSourceAsync, grpcClient.UpdateConversionSource, effectiveSettings.UpdateConversionSourceSettings).WithGoogleRequestParam("conversion_source.name", request => request.ConversionSource?.Name);
            Modify_ApiCall(ref _callUpdateConversionSource);
            Modify_UpdateConversionSourceApiCall(ref _callUpdateConversionSource);
            _callDeleteConversionSource = clientHelper.BuildApiCall<DeleteConversionSourceRequest, wkt::Empty>("DeleteConversionSource", grpcClient.DeleteConversionSourceAsync, grpcClient.DeleteConversionSource, effectiveSettings.DeleteConversionSourceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteConversionSource);
            Modify_DeleteConversionSourceApiCall(ref _callDeleteConversionSource);
            _callUndeleteConversionSource = clientHelper.BuildApiCall<UndeleteConversionSourceRequest, ConversionSource>("UndeleteConversionSource", grpcClient.UndeleteConversionSourceAsync, grpcClient.UndeleteConversionSource, effectiveSettings.UndeleteConversionSourceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUndeleteConversionSource);
            Modify_UndeleteConversionSourceApiCall(ref _callUndeleteConversionSource);
            _callGetConversionSource = clientHelper.BuildApiCall<GetConversionSourceRequest, ConversionSource>("GetConversionSource", grpcClient.GetConversionSourceAsync, grpcClient.GetConversionSource, effectiveSettings.GetConversionSourceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetConversionSource);
            Modify_GetConversionSourceApiCall(ref _callGetConversionSource);
            _callListConversionSources = clientHelper.BuildApiCall<ListConversionSourcesRequest, ListConversionSourcesResponse>("ListConversionSources", grpcClient.ListConversionSourcesAsync, grpcClient.ListConversionSources, effectiveSettings.ListConversionSourcesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListConversionSources);
            Modify_ListConversionSourcesApiCall(ref _callListConversionSources);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateConversionSourceApiCall(ref gaxgrpc::ApiCall<CreateConversionSourceRequest, ConversionSource> call);

        partial void Modify_UpdateConversionSourceApiCall(ref gaxgrpc::ApiCall<UpdateConversionSourceRequest, ConversionSource> call);

        partial void Modify_DeleteConversionSourceApiCall(ref gaxgrpc::ApiCall<DeleteConversionSourceRequest, wkt::Empty> call);

        partial void Modify_UndeleteConversionSourceApiCall(ref gaxgrpc::ApiCall<UndeleteConversionSourceRequest, ConversionSource> call);

        partial void Modify_GetConversionSourceApiCall(ref gaxgrpc::ApiCall<GetConversionSourceRequest, ConversionSource> call);

        partial void Modify_ListConversionSourcesApiCall(ref gaxgrpc::ApiCall<ListConversionSourcesRequest, ListConversionSourcesResponse> call);

        partial void OnConstruction(ConversionSourcesService.ConversionSourcesServiceClient grpcClient, ConversionSourcesServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ConversionSourcesService client</summary>
        public override ConversionSourcesService.ConversionSourcesServiceClient GrpcClient { get; }

        partial void Modify_CreateConversionSourceRequest(ref CreateConversionSourceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateConversionSourceRequest(ref UpdateConversionSourceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteConversionSourceRequest(ref DeleteConversionSourceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UndeleteConversionSourceRequest(ref UndeleteConversionSourceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetConversionSourceRequest(ref GetConversionSourceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListConversionSourcesRequest(ref ListConversionSourcesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a new conversion source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ConversionSource CreateConversionSource(CreateConversionSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConversionSourceRequest(ref request, ref callSettings);
            return _callCreateConversionSource.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new conversion source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ConversionSource> CreateConversionSourceAsync(CreateConversionSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConversionSourceRequest(ref request, ref callSettings);
            return _callCreateConversionSource.Async(request, callSettings);
        }

        /// <summary>
        /// Updates information of an existing conversion source. Available only for
        /// Merchant Center Destination conversion sources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ConversionSource UpdateConversionSource(UpdateConversionSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConversionSourceRequest(ref request, ref callSettings);
            return _callUpdateConversionSource.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates information of an existing conversion source. Available only for
        /// Merchant Center Destination conversion sources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ConversionSource> UpdateConversionSourceAsync(UpdateConversionSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConversionSourceRequest(ref request, ref callSettings);
            return _callUpdateConversionSource.Async(request, callSettings);
        }

        /// <summary>
        /// Archives an existing conversion source. If the conversion source is a
        /// Merchant Center Destination, it will be recoverable for 30 days. If the
        /// conversion source is a Google Analytics Link, it will be deleted
        /// immediately and can be restored by creating a new one.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteConversionSource(DeleteConversionSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConversionSourceRequest(ref request, ref callSettings);
            _callDeleteConversionSource.Sync(request, callSettings);
        }

        /// <summary>
        /// Archives an existing conversion source. If the conversion source is a
        /// Merchant Center Destination, it will be recoverable for 30 days. If the
        /// conversion source is a Google Analytics Link, it will be deleted
        /// immediately and can be restored by creating a new one.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteConversionSourceAsync(DeleteConversionSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConversionSourceRequest(ref request, ref callSettings);
            return _callDeleteConversionSource.Async(request, callSettings);
        }

        /// <summary>
        /// Re-enables an archived conversion source. Only Available for Merchant
        /// Center Destination conversion sources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ConversionSource UndeleteConversionSource(UndeleteConversionSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeleteConversionSourceRequest(ref request, ref callSettings);
            return _callUndeleteConversionSource.Sync(request, callSettings);
        }

        /// <summary>
        /// Re-enables an archived conversion source. Only Available for Merchant
        /// Center Destination conversion sources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ConversionSource> UndeleteConversionSourceAsync(UndeleteConversionSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeleteConversionSourceRequest(ref request, ref callSettings);
            return _callUndeleteConversionSource.Async(request, callSettings);
        }

        /// <summary>
        /// Fetches a conversion source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ConversionSource GetConversionSource(GetConversionSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConversionSourceRequest(ref request, ref callSettings);
            return _callGetConversionSource.Sync(request, callSettings);
        }

        /// <summary>
        /// Fetches a conversion source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ConversionSource> GetConversionSourceAsync(GetConversionSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConversionSourceRequest(ref request, ref callSettings);
            return _callGetConversionSource.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of conversion sources the caller has access to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ConversionSource"/> resources.</returns>
        public override gax::PagedEnumerable<ListConversionSourcesResponse, ConversionSource> ListConversionSources(ListConversionSourcesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConversionSourcesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListConversionSourcesRequest, ListConversionSourcesResponse, ConversionSource>(_callListConversionSources, request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of conversion sources the caller has access to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ConversionSource"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListConversionSourcesResponse, ConversionSource> ListConversionSourcesAsync(ListConversionSourcesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConversionSourcesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListConversionSourcesRequest, ListConversionSourcesResponse, ConversionSource>(_callListConversionSources, request, callSettings);
        }
    }

    public partial class ListConversionSourcesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListConversionSourcesResponse : gaxgrpc::IPageResponse<ConversionSource>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ConversionSource> GetEnumerator() => ConversionSources.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
