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

namespace Google.Cloud.Dialogflow.V2
{
    /// <summary>Settings for <see cref="ConversationProfilesClient"/> instances.</summary>
    public sealed partial class ConversationProfilesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ConversationProfilesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ConversationProfilesSettings"/>.</returns>
        public static ConversationProfilesSettings GetDefault() => new ConversationProfilesSettings();

        /// <summary>Constructs a new <see cref="ConversationProfilesSettings"/> object with default settings.</summary>
        public ConversationProfilesSettings()
        {
        }

        private ConversationProfilesSettings(ConversationProfilesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListConversationProfilesSettings = existing.ListConversationProfilesSettings;
            GetConversationProfileSettings = existing.GetConversationProfileSettings;
            CreateConversationProfileSettings = existing.CreateConversationProfileSettings;
            UpdateConversationProfileSettings = existing.UpdateConversationProfileSettings;
            DeleteConversationProfileSettings = existing.DeleteConversationProfileSettings;
            SetSuggestionFeatureConfigSettings = existing.SetSuggestionFeatureConfigSettings;
            SetSuggestionFeatureConfigOperationsSettings = existing.SetSuggestionFeatureConfigOperationsSettings.Clone();
            ClearSuggestionFeatureConfigSettings = existing.ClearSuggestionFeatureConfigSettings;
            ClearSuggestionFeatureConfigOperationsSettings = existing.ClearSuggestionFeatureConfigOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ConversationProfilesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationProfilesClient.ListConversationProfiles</c> and
        /// <c>ConversationProfilesClient.ListConversationProfilesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListConversationProfilesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationProfilesClient.GetConversationProfile</c> and
        /// <c>ConversationProfilesClient.GetConversationProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetConversationProfileSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationProfilesClient.CreateConversationProfile</c> and
        /// <c>ConversationProfilesClient.CreateConversationProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateConversationProfileSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationProfilesClient.UpdateConversationProfile</c> and
        /// <c>ConversationProfilesClient.UpdateConversationProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateConversationProfileSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationProfilesClient.DeleteConversationProfile</c> and
        /// <c>ConversationProfilesClient.DeleteConversationProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteConversationProfileSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationProfilesClient.SetSuggestionFeatureConfig</c> and
        /// <c>ConversationProfilesClient.SetSuggestionFeatureConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetSuggestionFeatureConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConversationProfilesClient.SetSuggestionFeatureConfig</c>
        /// and <c>ConversationProfilesClient.SetSuggestionFeatureConfigAsync</c>.
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
        public lro::OperationsSettings SetSuggestionFeatureConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationProfilesClient.ClearSuggestionFeatureConfig</c> and
        /// <c>ConversationProfilesClient.ClearSuggestionFeatureConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ClearSuggestionFeatureConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConversationProfilesClient.ClearSuggestionFeatureConfig</c>
        /// and <c>ConversationProfilesClient.ClearSuggestionFeatureConfigAsync</c>.
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
        public lro::OperationsSettings ClearSuggestionFeatureConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ConversationProfilesSettings"/> object.</returns>
        public ConversationProfilesSettings Clone() => new ConversationProfilesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ConversationProfilesClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ConversationProfilesClientBuilder : gaxgrpc::ClientBuilderBase<ConversationProfilesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ConversationProfilesSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ConversationProfilesClientBuilder() : base(ConversationProfilesClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ConversationProfilesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ConversationProfilesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ConversationProfilesClient Build()
        {
            ConversationProfilesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ConversationProfilesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ConversationProfilesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ConversationProfilesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ConversationProfilesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ConversationProfilesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ConversationProfilesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ConversationProfilesClient.ChannelPool;
    }

    /// <summary>ConversationProfiles client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing
    /// [ConversationProfiles][google.cloud.dialogflow.v2.ConversationProfile].
    /// </remarks>
    public abstract partial class ConversationProfilesClient
    {
        /// <summary>
        /// The default endpoint for the ConversationProfiles service, which is a host of "dialogflow.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dialogflow.googleapis.com:443";

        /// <summary>The default ConversationProfiles scopes.</summary>
        /// <remarks>
        /// The default ConversationProfiles scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/dialogflow</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/dialogflow",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ConversationProfiles.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ConversationProfilesClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ConversationProfilesClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ConversationProfilesClient"/>.</returns>
        public static stt::Task<ConversationProfilesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ConversationProfilesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ConversationProfilesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="ConversationProfilesClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ConversationProfilesClient"/>.</returns>
        public static ConversationProfilesClient Create() => new ConversationProfilesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ConversationProfilesClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ConversationProfilesSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ConversationProfilesClient"/>.</returns>
        internal static ConversationProfilesClient Create(grpccore::CallInvoker callInvoker, ConversationProfilesSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ConversationProfiles.ConversationProfilesClient grpcClient = new ConversationProfiles.ConversationProfilesClient(callInvoker);
            return new ConversationProfilesClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ConversationProfiles client</summary>
        public virtual ConversationProfiles.ConversationProfilesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all conversation profiles in the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ConversationProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConversationProfilesResponse, ConversationProfile> ListConversationProfiles(ListConversationProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all conversation profiles in the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ConversationProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConversationProfilesResponse, ConversationProfile> ListConversationProfilesAsync(ListConversationProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all conversation profiles in the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to list all conversation profiles from.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="ConversationProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConversationProfilesResponse, ConversationProfile> ListConversationProfiles(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversationProfilesRequest request = new ListConversationProfilesRequest
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
            return ListConversationProfiles(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all conversation profiles in the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to list all conversation profiles from.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ConversationProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConversationProfilesResponse, ConversationProfile> ListConversationProfilesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversationProfilesRequest request = new ListConversationProfilesRequest
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
            return ListConversationProfilesAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all conversation profiles in the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to list all conversation profiles from.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="ConversationProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConversationProfilesResponse, ConversationProfile> ListConversationProfiles(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversationProfilesRequest request = new ListConversationProfilesRequest
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
            return ListConversationProfiles(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all conversation profiles in the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to list all conversation profiles from.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ConversationProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConversationProfilesResponse, ConversationProfile> ListConversationProfilesAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversationProfilesRequest request = new ListConversationProfilesRequest
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
            return ListConversationProfilesAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all conversation profiles in the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to list all conversation profiles from.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="ConversationProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConversationProfilesResponse, ConversationProfile> ListConversationProfiles(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversationProfilesRequest request = new ListConversationProfilesRequest
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
            return ListConversationProfiles(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all conversation profiles in the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to list all conversation profiles from.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ConversationProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConversationProfilesResponse, ConversationProfile> ListConversationProfilesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversationProfilesRequest request = new ListConversationProfilesRequest
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
            return ListConversationProfilesAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified conversation profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConversationProfile GetConversationProfile(GetConversationProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified conversation profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversationProfile> GetConversationProfileAsync(GetConversationProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified conversation profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversationProfile> GetConversationProfileAsync(GetConversationProfileRequest request, st::CancellationToken cancellationToken) =>
            GetConversationProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified conversation profile.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversation profile.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationProfiles/&lt;Conversation Profile ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConversationProfile GetConversationProfile(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversationProfile(new GetConversationProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified conversation profile.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversation profile.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationProfiles/&lt;Conversation Profile ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversationProfile> GetConversationProfileAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversationProfileAsync(new GetConversationProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified conversation profile.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversation profile.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationProfiles/&lt;Conversation Profile ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversationProfile> GetConversationProfileAsync(string name, st::CancellationToken cancellationToken) =>
            GetConversationProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified conversation profile.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversation profile.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationProfiles/&lt;Conversation Profile ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConversationProfile GetConversationProfile(ConversationProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversationProfile(new GetConversationProfileRequest
            {
                ConversationProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified conversation profile.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversation profile.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationProfiles/&lt;Conversation Profile ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversationProfile> GetConversationProfileAsync(ConversationProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversationProfileAsync(new GetConversationProfileRequest
            {
                ConversationProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified conversation profile.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the conversation profile.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationProfiles/&lt;Conversation Profile ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversationProfile> GetConversationProfileAsync(ConversationProfileName name, st::CancellationToken cancellationToken) =>
            GetConversationProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a conversation profile in the specified project.
        /// 
        /// [ConversationProfile.create_time][google.cloud.dialogflow.v2.ConversationProfile.create_time]
        /// and
        /// [ConversationProfile.update_time][google.cloud.dialogflow.v2.ConversationProfile.update_time]
        /// aren't populated in the response. You can retrieve them via
        /// [GetConversationProfile][google.cloud.dialogflow.v2.ConversationProfiles.GetConversationProfile]
        /// API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConversationProfile CreateConversationProfile(CreateConversationProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a conversation profile in the specified project.
        /// 
        /// [ConversationProfile.create_time][google.cloud.dialogflow.v2.ConversationProfile.create_time]
        /// and
        /// [ConversationProfile.update_time][google.cloud.dialogflow.v2.ConversationProfile.update_time]
        /// aren't populated in the response. You can retrieve them via
        /// [GetConversationProfile][google.cloud.dialogflow.v2.ConversationProfiles.GetConversationProfile]
        /// API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversationProfile> CreateConversationProfileAsync(CreateConversationProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a conversation profile in the specified project.
        /// 
        /// [ConversationProfile.create_time][google.cloud.dialogflow.v2.ConversationProfile.create_time]
        /// and
        /// [ConversationProfile.update_time][google.cloud.dialogflow.v2.ConversationProfile.update_time]
        /// aren't populated in the response. You can retrieve them via
        /// [GetConversationProfile][google.cloud.dialogflow.v2.ConversationProfiles.GetConversationProfile]
        /// API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversationProfile> CreateConversationProfileAsync(CreateConversationProfileRequest request, st::CancellationToken cancellationToken) =>
            CreateConversationProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a conversation profile in the specified project.
        /// 
        /// [ConversationProfile.create_time][google.cloud.dialogflow.v2.ConversationProfile.create_time]
        /// and
        /// [ConversationProfile.update_time][google.cloud.dialogflow.v2.ConversationProfile.update_time]
        /// aren't populated in the response. You can retrieve them via
        /// [GetConversationProfile][google.cloud.dialogflow.v2.ConversationProfiles.GetConversationProfile]
        /// API.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to create a conversation profile for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
        /// </param>
        /// <param name="conversationProfile">
        /// Required. The conversation profile to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConversationProfile CreateConversationProfile(string parent, ConversationProfile conversationProfile, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversationProfile(new CreateConversationProfileRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ConversationProfile = gax::GaxPreconditions.CheckNotNull(conversationProfile, nameof(conversationProfile)),
            }, callSettings);

        /// <summary>
        /// Creates a conversation profile in the specified project.
        /// 
        /// [ConversationProfile.create_time][google.cloud.dialogflow.v2.ConversationProfile.create_time]
        /// and
        /// [ConversationProfile.update_time][google.cloud.dialogflow.v2.ConversationProfile.update_time]
        /// aren't populated in the response. You can retrieve them via
        /// [GetConversationProfile][google.cloud.dialogflow.v2.ConversationProfiles.GetConversationProfile]
        /// API.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to create a conversation profile for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
        /// </param>
        /// <param name="conversationProfile">
        /// Required. The conversation profile to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversationProfile> CreateConversationProfileAsync(string parent, ConversationProfile conversationProfile, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversationProfileAsync(new CreateConversationProfileRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ConversationProfile = gax::GaxPreconditions.CheckNotNull(conversationProfile, nameof(conversationProfile)),
            }, callSettings);

        /// <summary>
        /// Creates a conversation profile in the specified project.
        /// 
        /// [ConversationProfile.create_time][google.cloud.dialogflow.v2.ConversationProfile.create_time]
        /// and
        /// [ConversationProfile.update_time][google.cloud.dialogflow.v2.ConversationProfile.update_time]
        /// aren't populated in the response. You can retrieve them via
        /// [GetConversationProfile][google.cloud.dialogflow.v2.ConversationProfiles.GetConversationProfile]
        /// API.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to create a conversation profile for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
        /// </param>
        /// <param name="conversationProfile">
        /// Required. The conversation profile to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversationProfile> CreateConversationProfileAsync(string parent, ConversationProfile conversationProfile, st::CancellationToken cancellationToken) =>
            CreateConversationProfileAsync(parent, conversationProfile, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a conversation profile in the specified project.
        /// 
        /// [ConversationProfile.create_time][google.cloud.dialogflow.v2.ConversationProfile.create_time]
        /// and
        /// [ConversationProfile.update_time][google.cloud.dialogflow.v2.ConversationProfile.update_time]
        /// aren't populated in the response. You can retrieve them via
        /// [GetConversationProfile][google.cloud.dialogflow.v2.ConversationProfiles.GetConversationProfile]
        /// API.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to create a conversation profile for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
        /// </param>
        /// <param name="conversationProfile">
        /// Required. The conversation profile to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConversationProfile CreateConversationProfile(gagr::ProjectName parent, ConversationProfile conversationProfile, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversationProfile(new CreateConversationProfileRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ConversationProfile = gax::GaxPreconditions.CheckNotNull(conversationProfile, nameof(conversationProfile)),
            }, callSettings);

        /// <summary>
        /// Creates a conversation profile in the specified project.
        /// 
        /// [ConversationProfile.create_time][google.cloud.dialogflow.v2.ConversationProfile.create_time]
        /// and
        /// [ConversationProfile.update_time][google.cloud.dialogflow.v2.ConversationProfile.update_time]
        /// aren't populated in the response. You can retrieve them via
        /// [GetConversationProfile][google.cloud.dialogflow.v2.ConversationProfiles.GetConversationProfile]
        /// API.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to create a conversation profile for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
        /// </param>
        /// <param name="conversationProfile">
        /// Required. The conversation profile to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversationProfile> CreateConversationProfileAsync(gagr::ProjectName parent, ConversationProfile conversationProfile, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversationProfileAsync(new CreateConversationProfileRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ConversationProfile = gax::GaxPreconditions.CheckNotNull(conversationProfile, nameof(conversationProfile)),
            }, callSettings);

        /// <summary>
        /// Creates a conversation profile in the specified project.
        /// 
        /// [ConversationProfile.create_time][google.cloud.dialogflow.v2.ConversationProfile.create_time]
        /// and
        /// [ConversationProfile.update_time][google.cloud.dialogflow.v2.ConversationProfile.update_time]
        /// aren't populated in the response. You can retrieve them via
        /// [GetConversationProfile][google.cloud.dialogflow.v2.ConversationProfiles.GetConversationProfile]
        /// API.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to create a conversation profile for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
        /// </param>
        /// <param name="conversationProfile">
        /// Required. The conversation profile to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversationProfile> CreateConversationProfileAsync(gagr::ProjectName parent, ConversationProfile conversationProfile, st::CancellationToken cancellationToken) =>
            CreateConversationProfileAsync(parent, conversationProfile, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a conversation profile in the specified project.
        /// 
        /// [ConversationProfile.create_time][google.cloud.dialogflow.v2.ConversationProfile.create_time]
        /// and
        /// [ConversationProfile.update_time][google.cloud.dialogflow.v2.ConversationProfile.update_time]
        /// aren't populated in the response. You can retrieve them via
        /// [GetConversationProfile][google.cloud.dialogflow.v2.ConversationProfiles.GetConversationProfile]
        /// API.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to create a conversation profile for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
        /// </param>
        /// <param name="conversationProfile">
        /// Required. The conversation profile to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConversationProfile CreateConversationProfile(gagr::LocationName parent, ConversationProfile conversationProfile, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversationProfile(new CreateConversationProfileRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ConversationProfile = gax::GaxPreconditions.CheckNotNull(conversationProfile, nameof(conversationProfile)),
            }, callSettings);

        /// <summary>
        /// Creates a conversation profile in the specified project.
        /// 
        /// [ConversationProfile.create_time][google.cloud.dialogflow.v2.ConversationProfile.create_time]
        /// and
        /// [ConversationProfile.update_time][google.cloud.dialogflow.v2.ConversationProfile.update_time]
        /// aren't populated in the response. You can retrieve them via
        /// [GetConversationProfile][google.cloud.dialogflow.v2.ConversationProfiles.GetConversationProfile]
        /// API.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to create a conversation profile for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
        /// </param>
        /// <param name="conversationProfile">
        /// Required. The conversation profile to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversationProfile> CreateConversationProfileAsync(gagr::LocationName parent, ConversationProfile conversationProfile, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversationProfileAsync(new CreateConversationProfileRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ConversationProfile = gax::GaxPreconditions.CheckNotNull(conversationProfile, nameof(conversationProfile)),
            }, callSettings);

        /// <summary>
        /// Creates a conversation profile in the specified project.
        /// 
        /// [ConversationProfile.create_time][google.cloud.dialogflow.v2.ConversationProfile.create_time]
        /// and
        /// [ConversationProfile.update_time][google.cloud.dialogflow.v2.ConversationProfile.update_time]
        /// aren't populated in the response. You can retrieve them via
        /// [GetConversationProfile][google.cloud.dialogflow.v2.ConversationProfiles.GetConversationProfile]
        /// API.
        /// </summary>
        /// <param name="parent">
        /// Required. The project to create a conversation profile for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`.
        /// </param>
        /// <param name="conversationProfile">
        /// Required. The conversation profile to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversationProfile> CreateConversationProfileAsync(gagr::LocationName parent, ConversationProfile conversationProfile, st::CancellationToken cancellationToken) =>
            CreateConversationProfileAsync(parent, conversationProfile, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified conversation profile.
        /// 
        /// [ConversationProfile.create_time][google.cloud.dialogflow.v2.ConversationProfile.create_time]
        /// and
        /// [ConversationProfile.update_time][google.cloud.dialogflow.v2.ConversationProfile.update_time]
        /// aren't populated in the response. You can retrieve them via
        /// [GetConversationProfile][google.cloud.dialogflow.v2.ConversationProfiles.GetConversationProfile]
        /// API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConversationProfile UpdateConversationProfile(UpdateConversationProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified conversation profile.
        /// 
        /// [ConversationProfile.create_time][google.cloud.dialogflow.v2.ConversationProfile.create_time]
        /// and
        /// [ConversationProfile.update_time][google.cloud.dialogflow.v2.ConversationProfile.update_time]
        /// aren't populated in the response. You can retrieve them via
        /// [GetConversationProfile][google.cloud.dialogflow.v2.ConversationProfiles.GetConversationProfile]
        /// API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversationProfile> UpdateConversationProfileAsync(UpdateConversationProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified conversation profile.
        /// 
        /// [ConversationProfile.create_time][google.cloud.dialogflow.v2.ConversationProfile.create_time]
        /// and
        /// [ConversationProfile.update_time][google.cloud.dialogflow.v2.ConversationProfile.update_time]
        /// aren't populated in the response. You can retrieve them via
        /// [GetConversationProfile][google.cloud.dialogflow.v2.ConversationProfiles.GetConversationProfile]
        /// API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversationProfile> UpdateConversationProfileAsync(UpdateConversationProfileRequest request, st::CancellationToken cancellationToken) =>
            UpdateConversationProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified conversation profile.
        /// 
        /// [ConversationProfile.create_time][google.cloud.dialogflow.v2.ConversationProfile.create_time]
        /// and
        /// [ConversationProfile.update_time][google.cloud.dialogflow.v2.ConversationProfile.update_time]
        /// aren't populated in the response. You can retrieve them via
        /// [GetConversationProfile][google.cloud.dialogflow.v2.ConversationProfiles.GetConversationProfile]
        /// API.
        /// </summary>
        /// <param name="conversationProfile">
        /// Required. The conversation profile to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The mask to control which fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConversationProfile UpdateConversationProfile(ConversationProfile conversationProfile, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConversationProfile(new UpdateConversationProfileRequest
            {
                ConversationProfile = gax::GaxPreconditions.CheckNotNull(conversationProfile, nameof(conversationProfile)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the specified conversation profile.
        /// 
        /// [ConversationProfile.create_time][google.cloud.dialogflow.v2.ConversationProfile.create_time]
        /// and
        /// [ConversationProfile.update_time][google.cloud.dialogflow.v2.ConversationProfile.update_time]
        /// aren't populated in the response. You can retrieve them via
        /// [GetConversationProfile][google.cloud.dialogflow.v2.ConversationProfiles.GetConversationProfile]
        /// API.
        /// </summary>
        /// <param name="conversationProfile">
        /// Required. The conversation profile to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The mask to control which fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversationProfile> UpdateConversationProfileAsync(ConversationProfile conversationProfile, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConversationProfileAsync(new UpdateConversationProfileRequest
            {
                ConversationProfile = gax::GaxPreconditions.CheckNotNull(conversationProfile, nameof(conversationProfile)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates the specified conversation profile.
        /// 
        /// [ConversationProfile.create_time][google.cloud.dialogflow.v2.ConversationProfile.create_time]
        /// and
        /// [ConversationProfile.update_time][google.cloud.dialogflow.v2.ConversationProfile.update_time]
        /// aren't populated in the response. You can retrieve them via
        /// [GetConversationProfile][google.cloud.dialogflow.v2.ConversationProfiles.GetConversationProfile]
        /// API.
        /// </summary>
        /// <param name="conversationProfile">
        /// Required. The conversation profile to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. The mask to control which fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversationProfile> UpdateConversationProfileAsync(ConversationProfile conversationProfile, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateConversationProfileAsync(conversationProfile, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified conversation profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteConversationProfile(DeleteConversationProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified conversation profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversationProfileAsync(DeleteConversationProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified conversation profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversationProfileAsync(DeleteConversationProfileRequest request, st::CancellationToken cancellationToken) =>
            DeleteConversationProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified conversation profile.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversation profile to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationProfiles/&lt;Conversation Profile ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteConversationProfile(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversationProfile(new DeleteConversationProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified conversation profile.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversation profile to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationProfiles/&lt;Conversation Profile ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversationProfileAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversationProfileAsync(new DeleteConversationProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified conversation profile.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversation profile to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationProfiles/&lt;Conversation Profile ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversationProfileAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteConversationProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified conversation profile.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversation profile to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationProfiles/&lt;Conversation Profile ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteConversationProfile(ConversationProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversationProfile(new DeleteConversationProfileRequest
            {
                ConversationProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified conversation profile.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversation profile to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationProfiles/&lt;Conversation Profile ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversationProfileAsync(ConversationProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversationProfileAsync(new DeleteConversationProfileRequest
            {
                ConversationProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified conversation profile.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the conversation profile to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationProfiles/&lt;Conversation Profile ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConversationProfileAsync(ConversationProfileName name, st::CancellationToken cancellationToken) =>
            DeleteConversationProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds or updates a suggestion feature in a conversation profile.
        /// If the conversation profile contains the type of suggestion feature for
        /// the participant role, it will update it. Otherwise it will insert the
        /// suggestion feature.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [SetSuggestionFeatureConfigOperationMetadata][google.cloud.dialogflow.v2.SetSuggestionFeatureConfigOperationMetadata]
        /// - `response`:
        /// [ConversationProfile][google.cloud.dialogflow.v2.ConversationProfile]
        /// 
        /// If a long running operation to add or update suggestion feature
        /// config for the same conversation profile, participant role and suggestion
        /// feature type exists, please cancel the existing long running operation
        /// before sending such request, otherwise the request will be rejected.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConversationProfile, SetSuggestionFeatureConfigOperationMetadata> SetSuggestionFeatureConfig(SetSuggestionFeatureConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds or updates a suggestion feature in a conversation profile.
        /// If the conversation profile contains the type of suggestion feature for
        /// the participant role, it will update it. Otherwise it will insert the
        /// suggestion feature.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [SetSuggestionFeatureConfigOperationMetadata][google.cloud.dialogflow.v2.SetSuggestionFeatureConfigOperationMetadata]
        /// - `response`:
        /// [ConversationProfile][google.cloud.dialogflow.v2.ConversationProfile]
        /// 
        /// If a long running operation to add or update suggestion feature
        /// config for the same conversation profile, participant role and suggestion
        /// feature type exists, please cancel the existing long running operation
        /// before sending such request, otherwise the request will be rejected.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversationProfile, SetSuggestionFeatureConfigOperationMetadata>> SetSuggestionFeatureConfigAsync(SetSuggestionFeatureConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds or updates a suggestion feature in a conversation profile.
        /// If the conversation profile contains the type of suggestion feature for
        /// the participant role, it will update it. Otherwise it will insert the
        /// suggestion feature.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [SetSuggestionFeatureConfigOperationMetadata][google.cloud.dialogflow.v2.SetSuggestionFeatureConfigOperationMetadata]
        /// - `response`:
        /// [ConversationProfile][google.cloud.dialogflow.v2.ConversationProfile]
        /// 
        /// If a long running operation to add or update suggestion feature
        /// config for the same conversation profile, participant role and suggestion
        /// feature type exists, please cancel the existing long running operation
        /// before sending such request, otherwise the request will be rejected.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversationProfile, SetSuggestionFeatureConfigOperationMetadata>> SetSuggestionFeatureConfigAsync(SetSuggestionFeatureConfigRequest request, st::CancellationToken cancellationToken) =>
            SetSuggestionFeatureConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SetSuggestionFeatureConfig</c>.</summary>
        public virtual lro::OperationsClient SetSuggestionFeatureConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetSuggestionFeatureConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ConversationProfile, SetSuggestionFeatureConfigOperationMetadata> PollOnceSetSuggestionFeatureConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConversationProfile, SetSuggestionFeatureConfigOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetSuggestionFeatureConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetSuggestionFeatureConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ConversationProfile, SetSuggestionFeatureConfigOperationMetadata>> PollOnceSetSuggestionFeatureConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConversationProfile, SetSuggestionFeatureConfigOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetSuggestionFeatureConfigOperationsClient, callSettings);

        /// <summary>
        /// Adds or updates a suggestion feature in a conversation profile.
        /// If the conversation profile contains the type of suggestion feature for
        /// the participant role, it will update it. Otherwise it will insert the
        /// suggestion feature.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [SetSuggestionFeatureConfigOperationMetadata][google.cloud.dialogflow.v2.SetSuggestionFeatureConfigOperationMetadata]
        /// - `response`:
        /// [ConversationProfile][google.cloud.dialogflow.v2.ConversationProfile]
        /// 
        /// If a long running operation to add or update suggestion feature
        /// config for the same conversation profile, participant role and suggestion
        /// feature type exists, please cancel the existing long running operation
        /// before sending such request, otherwise the request will be rejected.
        /// </summary>
        /// <param name="conversationProfile">
        /// Required. The Conversation Profile to add or update the suggestion feature
        /// config. Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationProfiles/&lt;Conversation Profile ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConversationProfile, SetSuggestionFeatureConfigOperationMetadata> SetSuggestionFeatureConfig(string conversationProfile, gaxgrpc::CallSettings callSettings = null) =>
            SetSuggestionFeatureConfig(new SetSuggestionFeatureConfigRequest
            {
                ConversationProfile = gax::GaxPreconditions.CheckNotNullOrEmpty(conversationProfile, nameof(conversationProfile)),
            }, callSettings);

        /// <summary>
        /// Adds or updates a suggestion feature in a conversation profile.
        /// If the conversation profile contains the type of suggestion feature for
        /// the participant role, it will update it. Otherwise it will insert the
        /// suggestion feature.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [SetSuggestionFeatureConfigOperationMetadata][google.cloud.dialogflow.v2.SetSuggestionFeatureConfigOperationMetadata]
        /// - `response`:
        /// [ConversationProfile][google.cloud.dialogflow.v2.ConversationProfile]
        /// 
        /// If a long running operation to add or update suggestion feature
        /// config for the same conversation profile, participant role and suggestion
        /// feature type exists, please cancel the existing long running operation
        /// before sending such request, otherwise the request will be rejected.
        /// </summary>
        /// <param name="conversationProfile">
        /// Required. The Conversation Profile to add or update the suggestion feature
        /// config. Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationProfiles/&lt;Conversation Profile ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversationProfile, SetSuggestionFeatureConfigOperationMetadata>> SetSuggestionFeatureConfigAsync(string conversationProfile, gaxgrpc::CallSettings callSettings = null) =>
            SetSuggestionFeatureConfigAsync(new SetSuggestionFeatureConfigRequest
            {
                ConversationProfile = gax::GaxPreconditions.CheckNotNullOrEmpty(conversationProfile, nameof(conversationProfile)),
            }, callSettings);

        /// <summary>
        /// Adds or updates a suggestion feature in a conversation profile.
        /// If the conversation profile contains the type of suggestion feature for
        /// the participant role, it will update it. Otherwise it will insert the
        /// suggestion feature.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [SetSuggestionFeatureConfigOperationMetadata][google.cloud.dialogflow.v2.SetSuggestionFeatureConfigOperationMetadata]
        /// - `response`:
        /// [ConversationProfile][google.cloud.dialogflow.v2.ConversationProfile]
        /// 
        /// If a long running operation to add or update suggestion feature
        /// config for the same conversation profile, participant role and suggestion
        /// feature type exists, please cancel the existing long running operation
        /// before sending such request, otherwise the request will be rejected.
        /// </summary>
        /// <param name="conversationProfile">
        /// Required. The Conversation Profile to add or update the suggestion feature
        /// config. Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationProfiles/&lt;Conversation Profile ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversationProfile, SetSuggestionFeatureConfigOperationMetadata>> SetSuggestionFeatureConfigAsync(string conversationProfile, st::CancellationToken cancellationToken) =>
            SetSuggestionFeatureConfigAsync(conversationProfile, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds or updates a suggestion feature in a conversation profile.
        /// If the conversation profile contains the type of suggestion feature for
        /// the participant role, it will update it. Otherwise it will insert the
        /// suggestion feature.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [SetSuggestionFeatureConfigOperationMetadata][google.cloud.dialogflow.v2.SetSuggestionFeatureConfigOperationMetadata]
        /// - `response`:
        /// [ConversationProfile][google.cloud.dialogflow.v2.ConversationProfile]
        /// 
        /// If a long running operation to add or update suggestion feature
        /// config for the same conversation profile, participant role and suggestion
        /// feature type exists, please cancel the existing long running operation
        /// before sending such request, otherwise the request will be rejected.
        /// </summary>
        /// <param name="conversationProfile">
        /// Required. The Conversation Profile to add or update the suggestion feature
        /// config. Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationProfiles/&lt;Conversation Profile ID&gt;`.
        /// </param>
        /// <param name="participantRole">
        /// Required. The participant role to add or update the suggestion feature
        /// config. Only HUMAN_AGENT or END_USER can be used.
        /// </param>
        /// <param name="suggestionFeatureConfig">
        /// Required. The suggestion feature config to add or update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConversationProfile, SetSuggestionFeatureConfigOperationMetadata> SetSuggestionFeatureConfig(string conversationProfile, Participant.Types.Role participantRole, HumanAgentAssistantConfig.Types.SuggestionFeatureConfig suggestionFeatureConfig, gaxgrpc::CallSettings callSettings = null) =>
            SetSuggestionFeatureConfig(new SetSuggestionFeatureConfigRequest
            {
                ConversationProfile = gax::GaxPreconditions.CheckNotNullOrEmpty(conversationProfile, nameof(conversationProfile)),
                ParticipantRole = participantRole,
                SuggestionFeatureConfig = gax::GaxPreconditions.CheckNotNull(suggestionFeatureConfig, nameof(suggestionFeatureConfig)),
            }, callSettings);

        /// <summary>
        /// Adds or updates a suggestion feature in a conversation profile.
        /// If the conversation profile contains the type of suggestion feature for
        /// the participant role, it will update it. Otherwise it will insert the
        /// suggestion feature.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [SetSuggestionFeatureConfigOperationMetadata][google.cloud.dialogflow.v2.SetSuggestionFeatureConfigOperationMetadata]
        /// - `response`:
        /// [ConversationProfile][google.cloud.dialogflow.v2.ConversationProfile]
        /// 
        /// If a long running operation to add or update suggestion feature
        /// config for the same conversation profile, participant role and suggestion
        /// feature type exists, please cancel the existing long running operation
        /// before sending such request, otherwise the request will be rejected.
        /// </summary>
        /// <param name="conversationProfile">
        /// Required. The Conversation Profile to add or update the suggestion feature
        /// config. Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationProfiles/&lt;Conversation Profile ID&gt;`.
        /// </param>
        /// <param name="participantRole">
        /// Required. The participant role to add or update the suggestion feature
        /// config. Only HUMAN_AGENT or END_USER can be used.
        /// </param>
        /// <param name="suggestionFeatureConfig">
        /// Required. The suggestion feature config to add or update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversationProfile, SetSuggestionFeatureConfigOperationMetadata>> SetSuggestionFeatureConfigAsync(string conversationProfile, Participant.Types.Role participantRole, HumanAgentAssistantConfig.Types.SuggestionFeatureConfig suggestionFeatureConfig, gaxgrpc::CallSettings callSettings = null) =>
            SetSuggestionFeatureConfigAsync(new SetSuggestionFeatureConfigRequest
            {
                ConversationProfile = gax::GaxPreconditions.CheckNotNullOrEmpty(conversationProfile, nameof(conversationProfile)),
                ParticipantRole = participantRole,
                SuggestionFeatureConfig = gax::GaxPreconditions.CheckNotNull(suggestionFeatureConfig, nameof(suggestionFeatureConfig)),
            }, callSettings);

        /// <summary>
        /// Adds or updates a suggestion feature in a conversation profile.
        /// If the conversation profile contains the type of suggestion feature for
        /// the participant role, it will update it. Otherwise it will insert the
        /// suggestion feature.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [SetSuggestionFeatureConfigOperationMetadata][google.cloud.dialogflow.v2.SetSuggestionFeatureConfigOperationMetadata]
        /// - `response`:
        /// [ConversationProfile][google.cloud.dialogflow.v2.ConversationProfile]
        /// 
        /// If a long running operation to add or update suggestion feature
        /// config for the same conversation profile, participant role and suggestion
        /// feature type exists, please cancel the existing long running operation
        /// before sending such request, otherwise the request will be rejected.
        /// </summary>
        /// <param name="conversationProfile">
        /// Required. The Conversation Profile to add or update the suggestion feature
        /// config. Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationProfiles/&lt;Conversation Profile ID&gt;`.
        /// </param>
        /// <param name="participantRole">
        /// Required. The participant role to add or update the suggestion feature
        /// config. Only HUMAN_AGENT or END_USER can be used.
        /// </param>
        /// <param name="suggestionFeatureConfig">
        /// Required. The suggestion feature config to add or update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversationProfile, SetSuggestionFeatureConfigOperationMetadata>> SetSuggestionFeatureConfigAsync(string conversationProfile, Participant.Types.Role participantRole, HumanAgentAssistantConfig.Types.SuggestionFeatureConfig suggestionFeatureConfig, st::CancellationToken cancellationToken) =>
            SetSuggestionFeatureConfigAsync(conversationProfile, participantRole, suggestionFeatureConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Clears a suggestion feature from a conversation profile for the given
        /// participant role.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [ClearSuggestionFeatureConfigOperationMetadata][google.cloud.dialogflow.v2.ClearSuggestionFeatureConfigOperationMetadata]
        /// - `response`:
        /// [ConversationProfile][google.cloud.dialogflow.v2.ConversationProfile]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConversationProfile, ClearSuggestionFeatureConfigOperationMetadata> ClearSuggestionFeatureConfig(ClearSuggestionFeatureConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Clears a suggestion feature from a conversation profile for the given
        /// participant role.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [ClearSuggestionFeatureConfigOperationMetadata][google.cloud.dialogflow.v2.ClearSuggestionFeatureConfigOperationMetadata]
        /// - `response`:
        /// [ConversationProfile][google.cloud.dialogflow.v2.ConversationProfile]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversationProfile, ClearSuggestionFeatureConfigOperationMetadata>> ClearSuggestionFeatureConfigAsync(ClearSuggestionFeatureConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Clears a suggestion feature from a conversation profile for the given
        /// participant role.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [ClearSuggestionFeatureConfigOperationMetadata][google.cloud.dialogflow.v2.ClearSuggestionFeatureConfigOperationMetadata]
        /// - `response`:
        /// [ConversationProfile][google.cloud.dialogflow.v2.ConversationProfile]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversationProfile, ClearSuggestionFeatureConfigOperationMetadata>> ClearSuggestionFeatureConfigAsync(ClearSuggestionFeatureConfigRequest request, st::CancellationToken cancellationToken) =>
            ClearSuggestionFeatureConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ClearSuggestionFeatureConfig</c>.</summary>
        public virtual lro::OperationsClient ClearSuggestionFeatureConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ClearSuggestionFeatureConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ConversationProfile, ClearSuggestionFeatureConfigOperationMetadata> PollOnceClearSuggestionFeatureConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConversationProfile, ClearSuggestionFeatureConfigOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ClearSuggestionFeatureConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ClearSuggestionFeatureConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ConversationProfile, ClearSuggestionFeatureConfigOperationMetadata>> PollOnceClearSuggestionFeatureConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConversationProfile, ClearSuggestionFeatureConfigOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ClearSuggestionFeatureConfigOperationsClient, callSettings);

        /// <summary>
        /// Clears a suggestion feature from a conversation profile for the given
        /// participant role.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [ClearSuggestionFeatureConfigOperationMetadata][google.cloud.dialogflow.v2.ClearSuggestionFeatureConfigOperationMetadata]
        /// - `response`:
        /// [ConversationProfile][google.cloud.dialogflow.v2.ConversationProfile]
        /// </summary>
        /// <param name="conversationProfile">
        /// Required. The Conversation Profile to add or update the suggestion feature
        /// config. Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationProfiles/&lt;Conversation Profile ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConversationProfile, ClearSuggestionFeatureConfigOperationMetadata> ClearSuggestionFeatureConfig(string conversationProfile, gaxgrpc::CallSettings callSettings = null) =>
            ClearSuggestionFeatureConfig(new ClearSuggestionFeatureConfigRequest
            {
                ConversationProfile = gax::GaxPreconditions.CheckNotNullOrEmpty(conversationProfile, nameof(conversationProfile)),
            }, callSettings);

        /// <summary>
        /// Clears a suggestion feature from a conversation profile for the given
        /// participant role.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [ClearSuggestionFeatureConfigOperationMetadata][google.cloud.dialogflow.v2.ClearSuggestionFeatureConfigOperationMetadata]
        /// - `response`:
        /// [ConversationProfile][google.cloud.dialogflow.v2.ConversationProfile]
        /// </summary>
        /// <param name="conversationProfile">
        /// Required. The Conversation Profile to add or update the suggestion feature
        /// config. Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationProfiles/&lt;Conversation Profile ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversationProfile, ClearSuggestionFeatureConfigOperationMetadata>> ClearSuggestionFeatureConfigAsync(string conversationProfile, gaxgrpc::CallSettings callSettings = null) =>
            ClearSuggestionFeatureConfigAsync(new ClearSuggestionFeatureConfigRequest
            {
                ConversationProfile = gax::GaxPreconditions.CheckNotNullOrEmpty(conversationProfile, nameof(conversationProfile)),
            }, callSettings);

        /// <summary>
        /// Clears a suggestion feature from a conversation profile for the given
        /// participant role.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [ClearSuggestionFeatureConfigOperationMetadata][google.cloud.dialogflow.v2.ClearSuggestionFeatureConfigOperationMetadata]
        /// - `response`:
        /// [ConversationProfile][google.cloud.dialogflow.v2.ConversationProfile]
        /// </summary>
        /// <param name="conversationProfile">
        /// Required. The Conversation Profile to add or update the suggestion feature
        /// config. Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationProfiles/&lt;Conversation Profile ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversationProfile, ClearSuggestionFeatureConfigOperationMetadata>> ClearSuggestionFeatureConfigAsync(string conversationProfile, st::CancellationToken cancellationToken) =>
            ClearSuggestionFeatureConfigAsync(conversationProfile, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Clears a suggestion feature from a conversation profile for the given
        /// participant role.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [ClearSuggestionFeatureConfigOperationMetadata][google.cloud.dialogflow.v2.ClearSuggestionFeatureConfigOperationMetadata]
        /// - `response`:
        /// [ConversationProfile][google.cloud.dialogflow.v2.ConversationProfile]
        /// </summary>
        /// <param name="conversationProfile">
        /// Required. The Conversation Profile to add or update the suggestion feature
        /// config. Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationProfiles/&lt;Conversation Profile ID&gt;`.
        /// </param>
        /// <param name="participantRole">
        /// Required. The participant role to remove the suggestion feature
        /// config. Only HUMAN_AGENT or END_USER can be used.
        /// </param>
        /// <param name="suggestionFeatureType">
        /// Required. The type of the suggestion feature to remove.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConversationProfile, ClearSuggestionFeatureConfigOperationMetadata> ClearSuggestionFeatureConfig(string conversationProfile, Participant.Types.Role participantRole, SuggestionFeature.Types.Type suggestionFeatureType, gaxgrpc::CallSettings callSettings = null) =>
            ClearSuggestionFeatureConfig(new ClearSuggestionFeatureConfigRequest
            {
                ConversationProfile = gax::GaxPreconditions.CheckNotNullOrEmpty(conversationProfile, nameof(conversationProfile)),
                ParticipantRole = participantRole,
                SuggestionFeatureType = suggestionFeatureType,
            }, callSettings);

        /// <summary>
        /// Clears a suggestion feature from a conversation profile for the given
        /// participant role.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [ClearSuggestionFeatureConfigOperationMetadata][google.cloud.dialogflow.v2.ClearSuggestionFeatureConfigOperationMetadata]
        /// - `response`:
        /// [ConversationProfile][google.cloud.dialogflow.v2.ConversationProfile]
        /// </summary>
        /// <param name="conversationProfile">
        /// Required. The Conversation Profile to add or update the suggestion feature
        /// config. Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationProfiles/&lt;Conversation Profile ID&gt;`.
        /// </param>
        /// <param name="participantRole">
        /// Required. The participant role to remove the suggestion feature
        /// config. Only HUMAN_AGENT or END_USER can be used.
        /// </param>
        /// <param name="suggestionFeatureType">
        /// Required. The type of the suggestion feature to remove.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversationProfile, ClearSuggestionFeatureConfigOperationMetadata>> ClearSuggestionFeatureConfigAsync(string conversationProfile, Participant.Types.Role participantRole, SuggestionFeature.Types.Type suggestionFeatureType, gaxgrpc::CallSettings callSettings = null) =>
            ClearSuggestionFeatureConfigAsync(new ClearSuggestionFeatureConfigRequest
            {
                ConversationProfile = gax::GaxPreconditions.CheckNotNullOrEmpty(conversationProfile, nameof(conversationProfile)),
                ParticipantRole = participantRole,
                SuggestionFeatureType = suggestionFeatureType,
            }, callSettings);

        /// <summary>
        /// Clears a suggestion feature from a conversation profile for the given
        /// participant role.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [ClearSuggestionFeatureConfigOperationMetadata][google.cloud.dialogflow.v2.ClearSuggestionFeatureConfigOperationMetadata]
        /// - `response`:
        /// [ConversationProfile][google.cloud.dialogflow.v2.ConversationProfile]
        /// </summary>
        /// <param name="conversationProfile">
        /// Required. The Conversation Profile to add or update the suggestion feature
        /// config. Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationProfiles/&lt;Conversation Profile ID&gt;`.
        /// </param>
        /// <param name="participantRole">
        /// Required. The participant role to remove the suggestion feature
        /// config. Only HUMAN_AGENT or END_USER can be used.
        /// </param>
        /// <param name="suggestionFeatureType">
        /// Required. The type of the suggestion feature to remove.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversationProfile, ClearSuggestionFeatureConfigOperationMetadata>> ClearSuggestionFeatureConfigAsync(string conversationProfile, Participant.Types.Role participantRole, SuggestionFeature.Types.Type suggestionFeatureType, st::CancellationToken cancellationToken) =>
            ClearSuggestionFeatureConfigAsync(conversationProfile, participantRole, suggestionFeatureType, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ConversationProfiles client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing
    /// [ConversationProfiles][google.cloud.dialogflow.v2.ConversationProfile].
    /// </remarks>
    public sealed partial class ConversationProfilesClientImpl : ConversationProfilesClient
    {
        private readonly gaxgrpc::ApiCall<ListConversationProfilesRequest, ListConversationProfilesResponse> _callListConversationProfiles;

        private readonly gaxgrpc::ApiCall<GetConversationProfileRequest, ConversationProfile> _callGetConversationProfile;

        private readonly gaxgrpc::ApiCall<CreateConversationProfileRequest, ConversationProfile> _callCreateConversationProfile;

        private readonly gaxgrpc::ApiCall<UpdateConversationProfileRequest, ConversationProfile> _callUpdateConversationProfile;

        private readonly gaxgrpc::ApiCall<DeleteConversationProfileRequest, wkt::Empty> _callDeleteConversationProfile;

        private readonly gaxgrpc::ApiCall<SetSuggestionFeatureConfigRequest, lro::Operation> _callSetSuggestionFeatureConfig;

        private readonly gaxgrpc::ApiCall<ClearSuggestionFeatureConfigRequest, lro::Operation> _callClearSuggestionFeatureConfig;

        /// <summary>
        /// Constructs a client wrapper for the ConversationProfiles service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ConversationProfilesSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ConversationProfilesClientImpl(ConversationProfiles.ConversationProfilesClient grpcClient, ConversationProfilesSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ConversationProfilesSettings effectiveSettings = settings ?? ConversationProfilesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            SetSuggestionFeatureConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.SetSuggestionFeatureConfigOperationsSettings, logger);
            ClearSuggestionFeatureConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ClearSuggestionFeatureConfigOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListConversationProfiles = clientHelper.BuildApiCall<ListConversationProfilesRequest, ListConversationProfilesResponse>("ListConversationProfiles", grpcClient.ListConversationProfilesAsync, grpcClient.ListConversationProfiles, effectiveSettings.ListConversationProfilesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListConversationProfiles);
            Modify_ListConversationProfilesApiCall(ref _callListConversationProfiles);
            _callGetConversationProfile = clientHelper.BuildApiCall<GetConversationProfileRequest, ConversationProfile>("GetConversationProfile", grpcClient.GetConversationProfileAsync, grpcClient.GetConversationProfile, effectiveSettings.GetConversationProfileSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetConversationProfile);
            Modify_GetConversationProfileApiCall(ref _callGetConversationProfile);
            _callCreateConversationProfile = clientHelper.BuildApiCall<CreateConversationProfileRequest, ConversationProfile>("CreateConversationProfile", grpcClient.CreateConversationProfileAsync, grpcClient.CreateConversationProfile, effectiveSettings.CreateConversationProfileSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateConversationProfile);
            Modify_CreateConversationProfileApiCall(ref _callCreateConversationProfile);
            _callUpdateConversationProfile = clientHelper.BuildApiCall<UpdateConversationProfileRequest, ConversationProfile>("UpdateConversationProfile", grpcClient.UpdateConversationProfileAsync, grpcClient.UpdateConversationProfile, effectiveSettings.UpdateConversationProfileSettings).WithGoogleRequestParam("conversation_profile.name", request => request.ConversationProfile?.Name);
            Modify_ApiCall(ref _callUpdateConversationProfile);
            Modify_UpdateConversationProfileApiCall(ref _callUpdateConversationProfile);
            _callDeleteConversationProfile = clientHelper.BuildApiCall<DeleteConversationProfileRequest, wkt::Empty>("DeleteConversationProfile", grpcClient.DeleteConversationProfileAsync, grpcClient.DeleteConversationProfile, effectiveSettings.DeleteConversationProfileSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteConversationProfile);
            Modify_DeleteConversationProfileApiCall(ref _callDeleteConversationProfile);
            _callSetSuggestionFeatureConfig = clientHelper.BuildApiCall<SetSuggestionFeatureConfigRequest, lro::Operation>("SetSuggestionFeatureConfig", grpcClient.SetSuggestionFeatureConfigAsync, grpcClient.SetSuggestionFeatureConfig, effectiveSettings.SetSuggestionFeatureConfigSettings).WithGoogleRequestParam("conversation_profile", request => request.ConversationProfile);
            Modify_ApiCall(ref _callSetSuggestionFeatureConfig);
            Modify_SetSuggestionFeatureConfigApiCall(ref _callSetSuggestionFeatureConfig);
            _callClearSuggestionFeatureConfig = clientHelper.BuildApiCall<ClearSuggestionFeatureConfigRequest, lro::Operation>("ClearSuggestionFeatureConfig", grpcClient.ClearSuggestionFeatureConfigAsync, grpcClient.ClearSuggestionFeatureConfig, effectiveSettings.ClearSuggestionFeatureConfigSettings).WithGoogleRequestParam("conversation_profile", request => request.ConversationProfile);
            Modify_ApiCall(ref _callClearSuggestionFeatureConfig);
            Modify_ClearSuggestionFeatureConfigApiCall(ref _callClearSuggestionFeatureConfig);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListConversationProfilesApiCall(ref gaxgrpc::ApiCall<ListConversationProfilesRequest, ListConversationProfilesResponse> call);

        partial void Modify_GetConversationProfileApiCall(ref gaxgrpc::ApiCall<GetConversationProfileRequest, ConversationProfile> call);

        partial void Modify_CreateConversationProfileApiCall(ref gaxgrpc::ApiCall<CreateConversationProfileRequest, ConversationProfile> call);

        partial void Modify_UpdateConversationProfileApiCall(ref gaxgrpc::ApiCall<UpdateConversationProfileRequest, ConversationProfile> call);

        partial void Modify_DeleteConversationProfileApiCall(ref gaxgrpc::ApiCall<DeleteConversationProfileRequest, wkt::Empty> call);

        partial void Modify_SetSuggestionFeatureConfigApiCall(ref gaxgrpc::ApiCall<SetSuggestionFeatureConfigRequest, lro::Operation> call);

        partial void Modify_ClearSuggestionFeatureConfigApiCall(ref gaxgrpc::ApiCall<ClearSuggestionFeatureConfigRequest, lro::Operation> call);

        partial void OnConstruction(ConversationProfiles.ConversationProfilesClient grpcClient, ConversationProfilesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ConversationProfiles client</summary>
        public override ConversationProfiles.ConversationProfilesClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListConversationProfilesRequest(ref ListConversationProfilesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetConversationProfileRequest(ref GetConversationProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateConversationProfileRequest(ref CreateConversationProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateConversationProfileRequest(ref UpdateConversationProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteConversationProfileRequest(ref DeleteConversationProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetSuggestionFeatureConfigRequest(ref SetSuggestionFeatureConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ClearSuggestionFeatureConfigRequest(ref ClearSuggestionFeatureConfigRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the list of all conversation profiles in the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ConversationProfile"/> resources.</returns>
        public override gax::PagedEnumerable<ListConversationProfilesResponse, ConversationProfile> ListConversationProfiles(ListConversationProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConversationProfilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListConversationProfilesRequest, ListConversationProfilesResponse, ConversationProfile>(_callListConversationProfiles, request, callSettings);
        }

        /// <summary>
        /// Returns the list of all conversation profiles in the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ConversationProfile"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListConversationProfilesResponse, ConversationProfile> ListConversationProfilesAsync(ListConversationProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConversationProfilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListConversationProfilesRequest, ListConversationProfilesResponse, ConversationProfile>(_callListConversationProfiles, request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified conversation profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ConversationProfile GetConversationProfile(GetConversationProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConversationProfileRequest(ref request, ref callSettings);
            return _callGetConversationProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified conversation profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ConversationProfile> GetConversationProfileAsync(GetConversationProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConversationProfileRequest(ref request, ref callSettings);
            return _callGetConversationProfile.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a conversation profile in the specified project.
        /// 
        /// [ConversationProfile.create_time][google.cloud.dialogflow.v2.ConversationProfile.create_time]
        /// and
        /// [ConversationProfile.update_time][google.cloud.dialogflow.v2.ConversationProfile.update_time]
        /// aren't populated in the response. You can retrieve them via
        /// [GetConversationProfile][google.cloud.dialogflow.v2.ConversationProfiles.GetConversationProfile]
        /// API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ConversationProfile CreateConversationProfile(CreateConversationProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConversationProfileRequest(ref request, ref callSettings);
            return _callCreateConversationProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a conversation profile in the specified project.
        /// 
        /// [ConversationProfile.create_time][google.cloud.dialogflow.v2.ConversationProfile.create_time]
        /// and
        /// [ConversationProfile.update_time][google.cloud.dialogflow.v2.ConversationProfile.update_time]
        /// aren't populated in the response. You can retrieve them via
        /// [GetConversationProfile][google.cloud.dialogflow.v2.ConversationProfiles.GetConversationProfile]
        /// API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ConversationProfile> CreateConversationProfileAsync(CreateConversationProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConversationProfileRequest(ref request, ref callSettings);
            return _callCreateConversationProfile.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified conversation profile.
        /// 
        /// [ConversationProfile.create_time][google.cloud.dialogflow.v2.ConversationProfile.create_time]
        /// and
        /// [ConversationProfile.update_time][google.cloud.dialogflow.v2.ConversationProfile.update_time]
        /// aren't populated in the response. You can retrieve them via
        /// [GetConversationProfile][google.cloud.dialogflow.v2.ConversationProfiles.GetConversationProfile]
        /// API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ConversationProfile UpdateConversationProfile(UpdateConversationProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConversationProfileRequest(ref request, ref callSettings);
            return _callUpdateConversationProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified conversation profile.
        /// 
        /// [ConversationProfile.create_time][google.cloud.dialogflow.v2.ConversationProfile.create_time]
        /// and
        /// [ConversationProfile.update_time][google.cloud.dialogflow.v2.ConversationProfile.update_time]
        /// aren't populated in the response. You can retrieve them via
        /// [GetConversationProfile][google.cloud.dialogflow.v2.ConversationProfiles.GetConversationProfile]
        /// API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ConversationProfile> UpdateConversationProfileAsync(UpdateConversationProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConversationProfileRequest(ref request, ref callSettings);
            return _callUpdateConversationProfile.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified conversation profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteConversationProfile(DeleteConversationProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConversationProfileRequest(ref request, ref callSettings);
            _callDeleteConversationProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified conversation profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteConversationProfileAsync(DeleteConversationProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConversationProfileRequest(ref request, ref callSettings);
            return _callDeleteConversationProfile.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>SetSuggestionFeatureConfig</c>.</summary>
        public override lro::OperationsClient SetSuggestionFeatureConfigOperationsClient { get; }

        /// <summary>
        /// Adds or updates a suggestion feature in a conversation profile.
        /// If the conversation profile contains the type of suggestion feature for
        /// the participant role, it will update it. Otherwise it will insert the
        /// suggestion feature.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [SetSuggestionFeatureConfigOperationMetadata][google.cloud.dialogflow.v2.SetSuggestionFeatureConfigOperationMetadata]
        /// - `response`:
        /// [ConversationProfile][google.cloud.dialogflow.v2.ConversationProfile]
        /// 
        /// If a long running operation to add or update suggestion feature
        /// config for the same conversation profile, participant role and suggestion
        /// feature type exists, please cancel the existing long running operation
        /// before sending such request, otherwise the request will be rejected.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ConversationProfile, SetSuggestionFeatureConfigOperationMetadata> SetSuggestionFeatureConfig(SetSuggestionFeatureConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetSuggestionFeatureConfigRequest(ref request, ref callSettings);
            return new lro::Operation<ConversationProfile, SetSuggestionFeatureConfigOperationMetadata>(_callSetSuggestionFeatureConfig.Sync(request, callSettings), SetSuggestionFeatureConfigOperationsClient);
        }

        /// <summary>
        /// Adds or updates a suggestion feature in a conversation profile.
        /// If the conversation profile contains the type of suggestion feature for
        /// the participant role, it will update it. Otherwise it will insert the
        /// suggestion feature.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [SetSuggestionFeatureConfigOperationMetadata][google.cloud.dialogflow.v2.SetSuggestionFeatureConfigOperationMetadata]
        /// - `response`:
        /// [ConversationProfile][google.cloud.dialogflow.v2.ConversationProfile]
        /// 
        /// If a long running operation to add or update suggestion feature
        /// config for the same conversation profile, participant role and suggestion
        /// feature type exists, please cancel the existing long running operation
        /// before sending such request, otherwise the request will be rejected.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ConversationProfile, SetSuggestionFeatureConfigOperationMetadata>> SetSuggestionFeatureConfigAsync(SetSuggestionFeatureConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetSuggestionFeatureConfigRequest(ref request, ref callSettings);
            return new lro::Operation<ConversationProfile, SetSuggestionFeatureConfigOperationMetadata>(await _callSetSuggestionFeatureConfig.Async(request, callSettings).ConfigureAwait(false), SetSuggestionFeatureConfigOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ClearSuggestionFeatureConfig</c>.</summary>
        public override lro::OperationsClient ClearSuggestionFeatureConfigOperationsClient { get; }

        /// <summary>
        /// Clears a suggestion feature from a conversation profile for the given
        /// participant role.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [ClearSuggestionFeatureConfigOperationMetadata][google.cloud.dialogflow.v2.ClearSuggestionFeatureConfigOperationMetadata]
        /// - `response`:
        /// [ConversationProfile][google.cloud.dialogflow.v2.ConversationProfile]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ConversationProfile, ClearSuggestionFeatureConfigOperationMetadata> ClearSuggestionFeatureConfig(ClearSuggestionFeatureConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ClearSuggestionFeatureConfigRequest(ref request, ref callSettings);
            return new lro::Operation<ConversationProfile, ClearSuggestionFeatureConfigOperationMetadata>(_callClearSuggestionFeatureConfig.Sync(request, callSettings), ClearSuggestionFeatureConfigOperationsClient);
        }

        /// <summary>
        /// Clears a suggestion feature from a conversation profile for the given
        /// participant role.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [ClearSuggestionFeatureConfigOperationMetadata][google.cloud.dialogflow.v2.ClearSuggestionFeatureConfigOperationMetadata]
        /// - `response`:
        /// [ConversationProfile][google.cloud.dialogflow.v2.ConversationProfile]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ConversationProfile, ClearSuggestionFeatureConfigOperationMetadata>> ClearSuggestionFeatureConfigAsync(ClearSuggestionFeatureConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ClearSuggestionFeatureConfigRequest(ref request, ref callSettings);
            return new lro::Operation<ConversationProfile, ClearSuggestionFeatureConfigOperationMetadata>(await _callClearSuggestionFeatureConfig.Async(request, callSettings).ConfigureAwait(false), ClearSuggestionFeatureConfigOperationsClient);
        }
    }

    public partial class ListConversationProfilesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListConversationProfilesResponse : gaxgrpc::IPageResponse<ConversationProfile>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ConversationProfile> GetEnumerator() => ConversationProfiles.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ConversationProfiles
    {
        public partial class ConversationProfilesClient
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

    public static partial class ConversationProfiles
    {
        public partial class ConversationProfilesClient
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
