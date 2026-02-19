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

namespace Google.Cloud.VectorSearch.V1
{
    /// <summary>Settings for <see cref="VectorSearchServiceClient"/> instances.</summary>
    public sealed partial class VectorSearchServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="VectorSearchServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="VectorSearchServiceSettings"/>.</returns>
        public static VectorSearchServiceSettings GetDefault() => new VectorSearchServiceSettings();

        /// <summary>Constructs a new <see cref="VectorSearchServiceSettings"/> object with default settings.</summary>
        public VectorSearchServiceSettings()
        {
        }

        private VectorSearchServiceSettings(VectorSearchServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListCollectionsSettings = existing.ListCollectionsSettings;
            GetCollectionSettings = existing.GetCollectionSettings;
            CreateCollectionSettings = existing.CreateCollectionSettings;
            CreateCollectionOperationsSettings = existing.CreateCollectionOperationsSettings.Clone();
            UpdateCollectionSettings = existing.UpdateCollectionSettings;
            UpdateCollectionOperationsSettings = existing.UpdateCollectionOperationsSettings.Clone();
            DeleteCollectionSettings = existing.DeleteCollectionSettings;
            DeleteCollectionOperationsSettings = existing.DeleteCollectionOperationsSettings.Clone();
            ListIndexesSettings = existing.ListIndexesSettings;
            GetIndexSettings = existing.GetIndexSettings;
            CreateIndexSettings = existing.CreateIndexSettings;
            CreateIndexOperationsSettings = existing.CreateIndexOperationsSettings.Clone();
            DeleteIndexSettings = existing.DeleteIndexSettings;
            DeleteIndexOperationsSettings = existing.DeleteIndexOperationsSettings.Clone();
            ImportDataObjectsSettings = existing.ImportDataObjectsSettings;
            ImportDataObjectsOperationsSettings = existing.ImportDataObjectsOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(VectorSearchServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VectorSearchServiceClient.ListCollections</c> and <c>VectorSearchServiceClient.ListCollectionsAsync</c>.
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
        public gaxgrpc::CallSettings ListCollectionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VectorSearchServiceClient.GetCollection</c> and <c>VectorSearchServiceClient.GetCollectionAsync</c>.
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
        public gaxgrpc::CallSettings GetCollectionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VectorSearchServiceClient.CreateCollection</c> and <c>VectorSearchServiceClient.CreateCollectionAsync</c>
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
        public gaxgrpc::CallSettings CreateCollectionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VectorSearchServiceClient.CreateCollection</c> and
        /// <c>VectorSearchServiceClient.CreateCollectionAsync</c>.
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
        public lro::OperationsSettings CreateCollectionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VectorSearchServiceClient.UpdateCollection</c> and <c>VectorSearchServiceClient.UpdateCollectionAsync</c>
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
        public gaxgrpc::CallSettings UpdateCollectionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VectorSearchServiceClient.UpdateCollection</c> and
        /// <c>VectorSearchServiceClient.UpdateCollectionAsync</c>.
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
        public lro::OperationsSettings UpdateCollectionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VectorSearchServiceClient.DeleteCollection</c> and <c>VectorSearchServiceClient.DeleteCollectionAsync</c>
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
        public gaxgrpc::CallSettings DeleteCollectionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VectorSearchServiceClient.DeleteCollection</c> and
        /// <c>VectorSearchServiceClient.DeleteCollectionAsync</c>.
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
        public lro::OperationsSettings DeleteCollectionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VectorSearchServiceClient.ListIndexes</c> and <c>VectorSearchServiceClient.ListIndexesAsync</c>.
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
        public gaxgrpc::CallSettings ListIndexesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VectorSearchServiceClient.GetIndex</c> and <c>VectorSearchServiceClient.GetIndexAsync</c>.
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
        public gaxgrpc::CallSettings GetIndexSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VectorSearchServiceClient.CreateIndex</c> and <c>VectorSearchServiceClient.CreateIndexAsync</c>.
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
        public gaxgrpc::CallSettings CreateIndexSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VectorSearchServiceClient.CreateIndex</c> and
        /// <c>VectorSearchServiceClient.CreateIndexAsync</c>.
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
        public lro::OperationsSettings CreateIndexOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VectorSearchServiceClient.DeleteIndex</c> and <c>VectorSearchServiceClient.DeleteIndexAsync</c>.
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
        public gaxgrpc::CallSettings DeleteIndexSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VectorSearchServiceClient.DeleteIndex</c> and
        /// <c>VectorSearchServiceClient.DeleteIndexAsync</c>.
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
        public lro::OperationsSettings DeleteIndexOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VectorSearchServiceClient.ImportDataObjects</c> and <c>VectorSearchServiceClient.ImportDataObjectsAsync</c>
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
        public gaxgrpc::CallSettings ImportDataObjectsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VectorSearchServiceClient.ImportDataObjects</c> and
        /// <c>VectorSearchServiceClient.ImportDataObjectsAsync</c>.
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
        public lro::OperationsSettings ImportDataObjectsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="VectorSearchServiceSettings"/> object.</returns>
        public VectorSearchServiceSettings Clone() => new VectorSearchServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="VectorSearchServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class VectorSearchServiceClientBuilder : gaxgrpc::ClientBuilderBase<VectorSearchServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public VectorSearchServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public VectorSearchServiceClientBuilder() : base(VectorSearchServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref VectorSearchServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<VectorSearchServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override VectorSearchServiceClient Build()
        {
            VectorSearchServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<VectorSearchServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<VectorSearchServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private VectorSearchServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return VectorSearchServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<VectorSearchServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return VectorSearchServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => VectorSearchServiceClient.ChannelPool;
    }

    /// <summary>VectorSearchService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// VectorSearchService provides methods for managing Collection resources, and
    /// Collection Index resources. The primary resources offered by this service are
    /// Collections which are a container for a set of related JSON data objects, and
    /// Collection Indexes which enable efficient ANN search across data objects
    /// within a Collection.
    /// </remarks>
    public abstract partial class VectorSearchServiceClient
    {
        /// <summary>
        /// The default endpoint for the VectorSearchService service, which is a host of "vectorsearch.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "vectorsearch.googleapis.com:443";

        /// <summary>The default VectorSearchService scopes.</summary>
        /// <remarks>
        /// The default VectorSearchService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(VectorSearchService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="VectorSearchServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="VectorSearchServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="VectorSearchServiceClient"/>.</returns>
        public static stt::Task<VectorSearchServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new VectorSearchServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="VectorSearchServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="VectorSearchServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="VectorSearchServiceClient"/>.</returns>
        public static VectorSearchServiceClient Create() => new VectorSearchServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="VectorSearchServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="VectorSearchServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="VectorSearchServiceClient"/>.</returns>
        internal static VectorSearchServiceClient Create(grpccore::CallInvoker callInvoker, VectorSearchServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            VectorSearchService.VectorSearchServiceClient grpcClient = new VectorSearchService.VectorSearchServiceClient(callInvoker);
            return new VectorSearchServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC VectorSearchService client</summary>
        public virtual VectorSearchService.VectorSearchServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Collections in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Collection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCollectionsResponse, Collection> ListCollections(ListCollectionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Collections in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Collection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCollectionsResponse, Collection> ListCollectionsAsync(ListCollectionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Collections in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListCollectionsRequest
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
        /// <returns>A pageable sequence of <see cref="Collection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCollectionsResponse, Collection> ListCollections(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCollectionsRequest request = new ListCollectionsRequest
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
            return ListCollections(request, callSettings);
        }

        /// <summary>
        /// Lists Collections in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListCollectionsRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="Collection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCollectionsResponse, Collection> ListCollectionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCollectionsRequest request = new ListCollectionsRequest
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
            return ListCollectionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Collections in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListCollectionsRequest
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
        /// <returns>A pageable sequence of <see cref="Collection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCollectionsResponse, Collection> ListCollections(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCollectionsRequest request = new ListCollectionsRequest
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
            return ListCollections(request, callSettings);
        }

        /// <summary>
        /// Lists Collections in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListCollectionsRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="Collection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCollectionsResponse, Collection> ListCollectionsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCollectionsRequest request = new ListCollectionsRequest
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
            return ListCollectionsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Collection GetCollection(GetCollectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Collection> GetCollectionAsync(GetCollectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Collection> GetCollectionAsync(GetCollectionRequest request, st::CancellationToken cancellationToken) =>
            GetCollectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Collection.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Collection GetCollection(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCollection(new GetCollectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Collection.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Collection> GetCollectionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCollectionAsync(new GetCollectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Collection.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Collection> GetCollectionAsync(string name, st::CancellationToken cancellationToken) =>
            GetCollectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Collection.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Collection GetCollection(CollectionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCollection(new GetCollectionRequest
            {
                CollectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Collection.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Collection> GetCollectionAsync(CollectionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCollectionAsync(new GetCollectionRequest
            {
                CollectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Collection.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Collection> GetCollectionAsync(CollectionName name, st::CancellationToken cancellationToken) =>
            GetCollectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Collection in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Collection, OperationMetadata> CreateCollection(CreateCollectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Collection in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collection, OperationMetadata>> CreateCollectionAsync(CreateCollectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Collection in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collection, OperationMetadata>> CreateCollectionAsync(CreateCollectionRequest request, st::CancellationToken cancellationToken) =>
            CreateCollectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateCollection</c>.</summary>
        public virtual lro::OperationsClient CreateCollectionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateCollection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Collection, OperationMetadata> PollOnceCreateCollection(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Collection, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateCollectionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateCollection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Collection, OperationMetadata>> PollOnceCreateCollectionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Collection, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateCollectionOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Collection in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="collection">
        /// Required. The resource being created
        /// </param>
        /// <param name="collectionId">
        /// Required. ID of the Collection to create.
        /// The id must be 1-63 characters long, and comply with
        /// [RFC1035](https://www.ietf.org/rfc/rfc1035.txt).
        /// Specifically, it must be 1-63 characters long and match the regular
        /// expression `[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Collection, OperationMetadata> CreateCollection(string parent, Collection collection, string collectionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCollection(new CreateCollectionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CollectionId = gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)),
                Collection = gax::GaxPreconditions.CheckNotNull(collection, nameof(collection)),
            }, callSettings);

        /// <summary>
        /// Creates a new Collection in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="collection">
        /// Required. The resource being created
        /// </param>
        /// <param name="collectionId">
        /// Required. ID of the Collection to create.
        /// The id must be 1-63 characters long, and comply with
        /// [RFC1035](https://www.ietf.org/rfc/rfc1035.txt).
        /// Specifically, it must be 1-63 characters long and match the regular
        /// expression `[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collection, OperationMetadata>> CreateCollectionAsync(string parent, Collection collection, string collectionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCollectionAsync(new CreateCollectionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CollectionId = gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)),
                Collection = gax::GaxPreconditions.CheckNotNull(collection, nameof(collection)),
            }, callSettings);

        /// <summary>
        /// Creates a new Collection in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="collection">
        /// Required. The resource being created
        /// </param>
        /// <param name="collectionId">
        /// Required. ID of the Collection to create.
        /// The id must be 1-63 characters long, and comply with
        /// [RFC1035](https://www.ietf.org/rfc/rfc1035.txt).
        /// Specifically, it must be 1-63 characters long and match the regular
        /// expression `[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collection, OperationMetadata>> CreateCollectionAsync(string parent, Collection collection, string collectionId, st::CancellationToken cancellationToken) =>
            CreateCollectionAsync(parent, collection, collectionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Collection in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="collection">
        /// Required. The resource being created
        /// </param>
        /// <param name="collectionId">
        /// Required. ID of the Collection to create.
        /// The id must be 1-63 characters long, and comply with
        /// [RFC1035](https://www.ietf.org/rfc/rfc1035.txt).
        /// Specifically, it must be 1-63 characters long and match the regular
        /// expression `[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Collection, OperationMetadata> CreateCollection(gagr::LocationName parent, Collection collection, string collectionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCollection(new CreateCollectionRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CollectionId = gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)),
                Collection = gax::GaxPreconditions.CheckNotNull(collection, nameof(collection)),
            }, callSettings);

        /// <summary>
        /// Creates a new Collection in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="collection">
        /// Required. The resource being created
        /// </param>
        /// <param name="collectionId">
        /// Required. ID of the Collection to create.
        /// The id must be 1-63 characters long, and comply with
        /// [RFC1035](https://www.ietf.org/rfc/rfc1035.txt).
        /// Specifically, it must be 1-63 characters long and match the regular
        /// expression `[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collection, OperationMetadata>> CreateCollectionAsync(gagr::LocationName parent, Collection collection, string collectionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCollectionAsync(new CreateCollectionRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CollectionId = gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)),
                Collection = gax::GaxPreconditions.CheckNotNull(collection, nameof(collection)),
            }, callSettings);

        /// <summary>
        /// Creates a new Collection in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="collection">
        /// Required. The resource being created
        /// </param>
        /// <param name="collectionId">
        /// Required. ID of the Collection to create.
        /// The id must be 1-63 characters long, and comply with
        /// [RFC1035](https://www.ietf.org/rfc/rfc1035.txt).
        /// Specifically, it must be 1-63 characters long and match the regular
        /// expression `[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collection, OperationMetadata>> CreateCollectionAsync(gagr::LocationName parent, Collection collection, string collectionId, st::CancellationToken cancellationToken) =>
            CreateCollectionAsync(parent, collection, collectionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Collection, OperationMetadata> UpdateCollection(UpdateCollectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collection, OperationMetadata>> UpdateCollectionAsync(UpdateCollectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collection, OperationMetadata>> UpdateCollectionAsync(UpdateCollectionRequest request, st::CancellationToken cancellationToken) =>
            UpdateCollectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateCollection</c>.</summary>
        public virtual lro::OperationsClient UpdateCollectionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateCollection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Collection, OperationMetadata> PollOnceUpdateCollection(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Collection, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateCollectionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateCollection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Collection, OperationMetadata>> PollOnceUpdateCollectionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Collection, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateCollectionOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Collection.
        /// </summary>
        /// <param name="collection">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Collection resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields present in the request will be
        /// overwritten.
        /// 
        /// The following fields support update: `display_name`, `description`,
        /// `labels`, `data_schema`, `vector_schema`.
        /// For `data_schema` and `vector_schema`, fields can only be added, not
        /// deleted, but `vertex_embedding_config` in `vector_schema` can be added or
        /// removed.
        /// Partial updates for `data_schema` and `vector_schema` are also supported
        /// by using sub-field paths in `update_mask`, e.g.
        /// `data_schema.properties.foo` or `vector_schema.my_vector_field`.
        /// 
        /// If `*` is provided in the update_mask, full replacement will be performed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Collection, OperationMetadata> UpdateCollection(Collection collection, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCollection(new UpdateCollectionRequest
            {
                UpdateMask = updateMask,
                Collection = gax::GaxPreconditions.CheckNotNull(collection, nameof(collection)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Collection.
        /// </summary>
        /// <param name="collection">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Collection resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields present in the request will be
        /// overwritten.
        /// 
        /// The following fields support update: `display_name`, `description`,
        /// `labels`, `data_schema`, `vector_schema`.
        /// For `data_schema` and `vector_schema`, fields can only be added, not
        /// deleted, but `vertex_embedding_config` in `vector_schema` can be added or
        /// removed.
        /// Partial updates for `data_schema` and `vector_schema` are also supported
        /// by using sub-field paths in `update_mask`, e.g.
        /// `data_schema.properties.foo` or `vector_schema.my_vector_field`.
        /// 
        /// If `*` is provided in the update_mask, full replacement will be performed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collection, OperationMetadata>> UpdateCollectionAsync(Collection collection, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCollectionAsync(new UpdateCollectionRequest
            {
                UpdateMask = updateMask,
                Collection = gax::GaxPreconditions.CheckNotNull(collection, nameof(collection)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Collection.
        /// </summary>
        /// <param name="collection">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Collection resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields present in the request will be
        /// overwritten.
        /// 
        /// The following fields support update: `display_name`, `description`,
        /// `labels`, `data_schema`, `vector_schema`.
        /// For `data_schema` and `vector_schema`, fields can only be added, not
        /// deleted, but `vertex_embedding_config` in `vector_schema` can be added or
        /// removed.
        /// Partial updates for `data_schema` and `vector_schema` are also supported
        /// by using sub-field paths in `update_mask`, e.g.
        /// `data_schema.properties.foo` or `vector_schema.my_vector_field`.
        /// 
        /// If `*` is provided in the update_mask, full replacement will be performed.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Collection, OperationMetadata>> UpdateCollectionAsync(Collection collection, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCollectionAsync(collection, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCollection(DeleteCollectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCollectionAsync(DeleteCollectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCollectionAsync(DeleteCollectionRequest request, st::CancellationToken cancellationToken) =>
            DeleteCollectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteCollection</c>.</summary>
        public virtual lro::OperationsClient DeleteCollectionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteCollection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteCollection(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteCollectionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteCollection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteCollectionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteCollectionOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Collection.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCollection(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCollection(new DeleteCollectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Collection.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCollectionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCollectionAsync(new DeleteCollectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Collection.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCollectionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteCollectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Collection.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCollection(CollectionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCollection(new DeleteCollectionRequest
            {
                CollectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Collection.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCollectionAsync(CollectionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCollectionAsync(new DeleteCollectionRequest
            {
                CollectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Collection.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCollectionAsync(CollectionName name, st::CancellationToken cancellationToken) =>
            DeleteCollectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Indexes in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Index"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListIndexesResponse, Index> ListIndexes(ListIndexesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Indexes in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Index"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListIndexesResponse, Index> ListIndexesAsync(ListIndexesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Indexes in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListIndexesRequest
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
        /// <returns>A pageable sequence of <see cref="Index"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListIndexesResponse, Index> ListIndexes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListIndexesRequest request = new ListIndexesRequest
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
            return ListIndexes(request, callSettings);
        }

        /// <summary>
        /// Lists Indexes in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListIndexesRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="Index"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListIndexesResponse, Index> ListIndexesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListIndexesRequest request = new ListIndexesRequest
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
            return ListIndexesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Indexes in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListIndexesRequest
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
        /// <returns>A pageable sequence of <see cref="Index"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListIndexesResponse, Index> ListIndexes(CollectionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListIndexesRequest request = new ListIndexesRequest
            {
                ParentAsCollectionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListIndexes(request, callSettings);
        }

        /// <summary>
        /// Lists Indexes in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListIndexesRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="Index"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListIndexesResponse, Index> ListIndexesAsync(CollectionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListIndexesRequest request = new ListIndexesRequest
            {
                ParentAsCollectionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListIndexesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Index GetIndex(GetIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Index> GetIndexAsync(GetIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Index> GetIndexAsync(GetIndexRequest request, st::CancellationToken cancellationToken) =>
            GetIndexAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Index.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Index GetIndex(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetIndex(new GetIndexRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Index.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Index> GetIndexAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetIndexAsync(new GetIndexRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Index.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Index> GetIndexAsync(string name, st::CancellationToken cancellationToken) =>
            GetIndexAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Index.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Index GetIndex(IndexName name, gaxgrpc::CallSettings callSettings = null) =>
            GetIndex(new GetIndexRequest
            {
                IndexName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Index.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Index> GetIndexAsync(IndexName name, gaxgrpc::CallSettings callSettings = null) =>
            GetIndexAsync(new GetIndexRequest
            {
                IndexName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Index.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Index> GetIndexAsync(IndexName name, st::CancellationToken cancellationToken) =>
            GetIndexAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Index in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Index, OperationMetadata> CreateIndex(CreateIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Index in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Index, OperationMetadata>> CreateIndexAsync(CreateIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Index in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Index, OperationMetadata>> CreateIndexAsync(CreateIndexRequest request, st::CancellationToken cancellationToken) =>
            CreateIndexAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateIndex</c>.</summary>
        public virtual lro::OperationsClient CreateIndexOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateIndex</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Index, OperationMetadata> PollOnceCreateIndex(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Index, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateIndexOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateIndex</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Index, OperationMetadata>> PollOnceCreateIndexAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Index, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateIndexOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Index in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Collection for which to create the
        /// Index. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}`
        /// </param>
        /// <param name="index">
        /// Required. The resource being created
        /// </param>
        /// <param name="indexId">
        /// Required. ID of the Index to create.
        /// The id must be 1-63 characters long, and comply with
        /// [RFC1035](https://www.ietf.org/rfc/rfc1035.txt).
        /// Specifically, it must be 1-63 characters long and match the regular
        /// expression `[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Index, OperationMetadata> CreateIndex(string parent, Index index, string indexId, gaxgrpc::CallSettings callSettings = null) =>
            CreateIndex(new CreateIndexRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                IndexId = gax::GaxPreconditions.CheckNotNullOrEmpty(indexId, nameof(indexId)),
                Index = gax::GaxPreconditions.CheckNotNull(index, nameof(index)),
            }, callSettings);

        /// <summary>
        /// Creates a new Index in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Collection for which to create the
        /// Index. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}`
        /// </param>
        /// <param name="index">
        /// Required. The resource being created
        /// </param>
        /// <param name="indexId">
        /// Required. ID of the Index to create.
        /// The id must be 1-63 characters long, and comply with
        /// [RFC1035](https://www.ietf.org/rfc/rfc1035.txt).
        /// Specifically, it must be 1-63 characters long and match the regular
        /// expression `[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Index, OperationMetadata>> CreateIndexAsync(string parent, Index index, string indexId, gaxgrpc::CallSettings callSettings = null) =>
            CreateIndexAsync(new CreateIndexRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                IndexId = gax::GaxPreconditions.CheckNotNullOrEmpty(indexId, nameof(indexId)),
                Index = gax::GaxPreconditions.CheckNotNull(index, nameof(index)),
            }, callSettings);

        /// <summary>
        /// Creates a new Index in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Collection for which to create the
        /// Index. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}`
        /// </param>
        /// <param name="index">
        /// Required. The resource being created
        /// </param>
        /// <param name="indexId">
        /// Required. ID of the Index to create.
        /// The id must be 1-63 characters long, and comply with
        /// [RFC1035](https://www.ietf.org/rfc/rfc1035.txt).
        /// Specifically, it must be 1-63 characters long and match the regular
        /// expression `[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Index, OperationMetadata>> CreateIndexAsync(string parent, Index index, string indexId, st::CancellationToken cancellationToken) =>
            CreateIndexAsync(parent, index, indexId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Index in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Collection for which to create the
        /// Index. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}`
        /// </param>
        /// <param name="index">
        /// Required. The resource being created
        /// </param>
        /// <param name="indexId">
        /// Required. ID of the Index to create.
        /// The id must be 1-63 characters long, and comply with
        /// [RFC1035](https://www.ietf.org/rfc/rfc1035.txt).
        /// Specifically, it must be 1-63 characters long and match the regular
        /// expression `[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Index, OperationMetadata> CreateIndex(CollectionName parent, Index index, string indexId, gaxgrpc::CallSettings callSettings = null) =>
            CreateIndex(new CreateIndexRequest
            {
                ParentAsCollectionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                IndexId = gax::GaxPreconditions.CheckNotNullOrEmpty(indexId, nameof(indexId)),
                Index = gax::GaxPreconditions.CheckNotNull(index, nameof(index)),
            }, callSettings);

        /// <summary>
        /// Creates a new Index in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Collection for which to create the
        /// Index. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}`
        /// </param>
        /// <param name="index">
        /// Required. The resource being created
        /// </param>
        /// <param name="indexId">
        /// Required. ID of the Index to create.
        /// The id must be 1-63 characters long, and comply with
        /// [RFC1035](https://www.ietf.org/rfc/rfc1035.txt).
        /// Specifically, it must be 1-63 characters long and match the regular
        /// expression `[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Index, OperationMetadata>> CreateIndexAsync(CollectionName parent, Index index, string indexId, gaxgrpc::CallSettings callSettings = null) =>
            CreateIndexAsync(new CreateIndexRequest
            {
                ParentAsCollectionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                IndexId = gax::GaxPreconditions.CheckNotNullOrEmpty(indexId, nameof(indexId)),
                Index = gax::GaxPreconditions.CheckNotNull(index, nameof(index)),
            }, callSettings);

        /// <summary>
        /// Creates a new Index in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Collection for which to create the
        /// Index. Format:
        /// `projects/{project}/locations/{location}/collections/{collection}`
        /// </param>
        /// <param name="index">
        /// Required. The resource being created
        /// </param>
        /// <param name="indexId">
        /// Required. ID of the Index to create.
        /// The id must be 1-63 characters long, and comply with
        /// [RFC1035](https://www.ietf.org/rfc/rfc1035.txt).
        /// Specifically, it must be 1-63 characters long and match the regular
        /// expression `[a-z](?:[-a-z0-9]{0,61}[a-z0-9])?`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Index, OperationMetadata>> CreateIndexAsync(CollectionName parent, Index index, string indexId, st::CancellationToken cancellationToken) =>
            CreateIndexAsync(parent, index, indexId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteIndex(DeleteIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteIndexAsync(DeleteIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteIndexAsync(DeleteIndexRequest request, st::CancellationToken cancellationToken) =>
            DeleteIndexAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteIndex</c>.</summary>
        public virtual lro::OperationsClient DeleteIndexOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteIndex</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteIndex(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteIndexOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteIndex</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteIndexAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteIndexOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Index.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Index to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/indexes/{index}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteIndex(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIndex(new DeleteIndexRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Index.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Index to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/indexes/{index}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteIndexAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIndexAsync(new DeleteIndexRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Index.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Index to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/indexes/{index}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteIndexAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteIndexAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Index.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Index to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/indexes/{index}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteIndex(IndexName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIndex(new DeleteIndexRequest
            {
                IndexName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Index.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Index to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/indexes/{index}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteIndexAsync(IndexName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIndexAsync(new DeleteIndexRequest
            {
                IndexName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Index.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Index to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/collections/{collection}/indexes/{index}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteIndexAsync(IndexName name, st::CancellationToken cancellationToken) =>
            DeleteIndexAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Initiates a Long-Running Operation to import DataObjects into a Collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportDataObjectsResponse, ImportDataObjectsMetadata> ImportDataObjects(ImportDataObjectsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Initiates a Long-Running Operation to import DataObjects into a Collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportDataObjectsResponse, ImportDataObjectsMetadata>> ImportDataObjectsAsync(ImportDataObjectsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Initiates a Long-Running Operation to import DataObjects into a Collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportDataObjectsResponse, ImportDataObjectsMetadata>> ImportDataObjectsAsync(ImportDataObjectsRequest request, st::CancellationToken cancellationToken) =>
            ImportDataObjectsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ImportDataObjects</c>.</summary>
        public virtual lro::OperationsClient ImportDataObjectsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ImportDataObjects</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ImportDataObjectsResponse, ImportDataObjectsMetadata> PollOnceImportDataObjects(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportDataObjectsResponse, ImportDataObjectsMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportDataObjectsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportDataObjects</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ImportDataObjectsResponse, ImportDataObjectsMetadata>> PollOnceImportDataObjectsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportDataObjectsResponse, ImportDataObjectsMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportDataObjectsOperationsClient, callSettings);
    }

    /// <summary>VectorSearchService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// VectorSearchService provides methods for managing Collection resources, and
    /// Collection Index resources. The primary resources offered by this service are
    /// Collections which are a container for a set of related JSON data objects, and
    /// Collection Indexes which enable efficient ANN search across data objects
    /// within a Collection.
    /// </remarks>
    public sealed partial class VectorSearchServiceClientImpl : VectorSearchServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListCollectionsRequest, ListCollectionsResponse> _callListCollections;

        private readonly gaxgrpc::ApiCall<GetCollectionRequest, Collection> _callGetCollection;

        private readonly gaxgrpc::ApiCall<CreateCollectionRequest, lro::Operation> _callCreateCollection;

        private readonly gaxgrpc::ApiCall<UpdateCollectionRequest, lro::Operation> _callUpdateCollection;

        private readonly gaxgrpc::ApiCall<DeleteCollectionRequest, lro::Operation> _callDeleteCollection;

        private readonly gaxgrpc::ApiCall<ListIndexesRequest, ListIndexesResponse> _callListIndexes;

        private readonly gaxgrpc::ApiCall<GetIndexRequest, Index> _callGetIndex;

        private readonly gaxgrpc::ApiCall<CreateIndexRequest, lro::Operation> _callCreateIndex;

        private readonly gaxgrpc::ApiCall<DeleteIndexRequest, lro::Operation> _callDeleteIndex;

        private readonly gaxgrpc::ApiCall<ImportDataObjectsRequest, lro::Operation> _callImportDataObjects;

        /// <summary>
        /// Constructs a client wrapper for the VectorSearchService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="VectorSearchServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public VectorSearchServiceClientImpl(VectorSearchService.VectorSearchServiceClient grpcClient, VectorSearchServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            VectorSearchServiceSettings effectiveSettings = settings ?? VectorSearchServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateCollectionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateCollectionOperationsSettings, logger);
            UpdateCollectionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateCollectionOperationsSettings, logger);
            DeleteCollectionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteCollectionOperationsSettings, logger);
            CreateIndexOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateIndexOperationsSettings, logger);
            DeleteIndexOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteIndexOperationsSettings, logger);
            ImportDataObjectsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ImportDataObjectsOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListCollections = clientHelper.BuildApiCall<ListCollectionsRequest, ListCollectionsResponse>("ListCollections", grpcClient.ListCollectionsAsync, grpcClient.ListCollections, effectiveSettings.ListCollectionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCollections);
            Modify_ListCollectionsApiCall(ref _callListCollections);
            _callGetCollection = clientHelper.BuildApiCall<GetCollectionRequest, Collection>("GetCollection", grpcClient.GetCollectionAsync, grpcClient.GetCollection, effectiveSettings.GetCollectionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCollection);
            Modify_GetCollectionApiCall(ref _callGetCollection);
            _callCreateCollection = clientHelper.BuildApiCall<CreateCollectionRequest, lro::Operation>("CreateCollection", grpcClient.CreateCollectionAsync, grpcClient.CreateCollection, effectiveSettings.CreateCollectionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCollection);
            Modify_CreateCollectionApiCall(ref _callCreateCollection);
            _callUpdateCollection = clientHelper.BuildApiCall<UpdateCollectionRequest, lro::Operation>("UpdateCollection", grpcClient.UpdateCollectionAsync, grpcClient.UpdateCollection, effectiveSettings.UpdateCollectionSettings).WithGoogleRequestParam("collection.name", request => request.Collection?.Name);
            Modify_ApiCall(ref _callUpdateCollection);
            Modify_UpdateCollectionApiCall(ref _callUpdateCollection);
            _callDeleteCollection = clientHelper.BuildApiCall<DeleteCollectionRequest, lro::Operation>("DeleteCollection", grpcClient.DeleteCollectionAsync, grpcClient.DeleteCollection, effectiveSettings.DeleteCollectionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteCollection);
            Modify_DeleteCollectionApiCall(ref _callDeleteCollection);
            _callListIndexes = clientHelper.BuildApiCall<ListIndexesRequest, ListIndexesResponse>("ListIndexes", grpcClient.ListIndexesAsync, grpcClient.ListIndexes, effectiveSettings.ListIndexesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListIndexes);
            Modify_ListIndexesApiCall(ref _callListIndexes);
            _callGetIndex = clientHelper.BuildApiCall<GetIndexRequest, Index>("GetIndex", grpcClient.GetIndexAsync, grpcClient.GetIndex, effectiveSettings.GetIndexSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetIndex);
            Modify_GetIndexApiCall(ref _callGetIndex);
            _callCreateIndex = clientHelper.BuildApiCall<CreateIndexRequest, lro::Operation>("CreateIndex", grpcClient.CreateIndexAsync, grpcClient.CreateIndex, effectiveSettings.CreateIndexSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateIndex);
            Modify_CreateIndexApiCall(ref _callCreateIndex);
            _callDeleteIndex = clientHelper.BuildApiCall<DeleteIndexRequest, lro::Operation>("DeleteIndex", grpcClient.DeleteIndexAsync, grpcClient.DeleteIndex, effectiveSettings.DeleteIndexSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteIndex);
            Modify_DeleteIndexApiCall(ref _callDeleteIndex);
            _callImportDataObjects = clientHelper.BuildApiCall<ImportDataObjectsRequest, lro::Operation>("ImportDataObjects", grpcClient.ImportDataObjectsAsync, grpcClient.ImportDataObjects, effectiveSettings.ImportDataObjectsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callImportDataObjects);
            Modify_ImportDataObjectsApiCall(ref _callImportDataObjects);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListCollectionsApiCall(ref gaxgrpc::ApiCall<ListCollectionsRequest, ListCollectionsResponse> call);

        partial void Modify_GetCollectionApiCall(ref gaxgrpc::ApiCall<GetCollectionRequest, Collection> call);

        partial void Modify_CreateCollectionApiCall(ref gaxgrpc::ApiCall<CreateCollectionRequest, lro::Operation> call);

        partial void Modify_UpdateCollectionApiCall(ref gaxgrpc::ApiCall<UpdateCollectionRequest, lro::Operation> call);

        partial void Modify_DeleteCollectionApiCall(ref gaxgrpc::ApiCall<DeleteCollectionRequest, lro::Operation> call);

        partial void Modify_ListIndexesApiCall(ref gaxgrpc::ApiCall<ListIndexesRequest, ListIndexesResponse> call);

        partial void Modify_GetIndexApiCall(ref gaxgrpc::ApiCall<GetIndexRequest, Index> call);

        partial void Modify_CreateIndexApiCall(ref gaxgrpc::ApiCall<CreateIndexRequest, lro::Operation> call);

        partial void Modify_DeleteIndexApiCall(ref gaxgrpc::ApiCall<DeleteIndexRequest, lro::Operation> call);

        partial void Modify_ImportDataObjectsApiCall(ref gaxgrpc::ApiCall<ImportDataObjectsRequest, lro::Operation> call);

        partial void OnConstruction(VectorSearchService.VectorSearchServiceClient grpcClient, VectorSearchServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC VectorSearchService client</summary>
        public override VectorSearchService.VectorSearchServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListCollectionsRequest(ref ListCollectionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCollectionRequest(ref GetCollectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateCollectionRequest(ref CreateCollectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCollectionRequest(ref UpdateCollectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteCollectionRequest(ref DeleteCollectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListIndexesRequest(ref ListIndexesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIndexRequest(ref GetIndexRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateIndexRequest(ref CreateIndexRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteIndexRequest(ref DeleteIndexRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportDataObjectsRequest(ref ImportDataObjectsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists Collections in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Collection"/> resources.</returns>
        public override gax::PagedEnumerable<ListCollectionsResponse, Collection> ListCollections(ListCollectionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCollectionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCollectionsRequest, ListCollectionsResponse, Collection>(_callListCollections, request, callSettings);
        }

        /// <summary>
        /// Lists Collections in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Collection"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCollectionsResponse, Collection> ListCollectionsAsync(ListCollectionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCollectionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCollectionsRequest, ListCollectionsResponse, Collection>(_callListCollections, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Collection GetCollection(GetCollectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCollectionRequest(ref request, ref callSettings);
            return _callGetCollection.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Collection> GetCollectionAsync(GetCollectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCollectionRequest(ref request, ref callSettings);
            return _callGetCollection.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateCollection</c>.</summary>
        public override lro::OperationsClient CreateCollectionOperationsClient { get; }

        /// <summary>
        /// Creates a new Collection in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Collection, OperationMetadata> CreateCollection(CreateCollectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCollectionRequest(ref request, ref callSettings);
            return new lro::Operation<Collection, OperationMetadata>(_callCreateCollection.Sync(request, callSettings), CreateCollectionOperationsClient);
        }

        /// <summary>
        /// Creates a new Collection in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Collection, OperationMetadata>> CreateCollectionAsync(CreateCollectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCollectionRequest(ref request, ref callSettings);
            return new lro::Operation<Collection, OperationMetadata>(await _callCreateCollection.Async(request, callSettings).ConfigureAwait(false), CreateCollectionOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateCollection</c>.</summary>
        public override lro::OperationsClient UpdateCollectionOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single Collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Collection, OperationMetadata> UpdateCollection(UpdateCollectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCollectionRequest(ref request, ref callSettings);
            return new lro::Operation<Collection, OperationMetadata>(_callUpdateCollection.Sync(request, callSettings), UpdateCollectionOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single Collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Collection, OperationMetadata>> UpdateCollectionAsync(UpdateCollectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCollectionRequest(ref request, ref callSettings);
            return new lro::Operation<Collection, OperationMetadata>(await _callUpdateCollection.Async(request, callSettings).ConfigureAwait(false), UpdateCollectionOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteCollection</c>.</summary>
        public override lro::OperationsClient DeleteCollectionOperationsClient { get; }

        /// <summary>
        /// Deletes a single Collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteCollection(DeleteCollectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCollectionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteCollection.Sync(request, callSettings), DeleteCollectionOperationsClient);
        }

        /// <summary>
        /// Deletes a single Collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCollectionAsync(DeleteCollectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCollectionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteCollection.Async(request, callSettings).ConfigureAwait(false), DeleteCollectionOperationsClient);
        }

        /// <summary>
        /// Lists Indexes in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Index"/> resources.</returns>
        public override gax::PagedEnumerable<ListIndexesResponse, Index> ListIndexes(ListIndexesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListIndexesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListIndexesRequest, ListIndexesResponse, Index>(_callListIndexes, request, callSettings);
        }

        /// <summary>
        /// Lists Indexes in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Index"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListIndexesResponse, Index> ListIndexesAsync(ListIndexesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListIndexesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListIndexesRequest, ListIndexesResponse, Index>(_callListIndexes, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Index GetIndex(GetIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIndexRequest(ref request, ref callSettings);
            return _callGetIndex.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Index> GetIndexAsync(GetIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIndexRequest(ref request, ref callSettings);
            return _callGetIndex.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateIndex</c>.</summary>
        public override lro::OperationsClient CreateIndexOperationsClient { get; }

        /// <summary>
        /// Creates a new Index in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Index, OperationMetadata> CreateIndex(CreateIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateIndexRequest(ref request, ref callSettings);
            return new lro::Operation<Index, OperationMetadata>(_callCreateIndex.Sync(request, callSettings), CreateIndexOperationsClient);
        }

        /// <summary>
        /// Creates a new Index in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Index, OperationMetadata>> CreateIndexAsync(CreateIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateIndexRequest(ref request, ref callSettings);
            return new lro::Operation<Index, OperationMetadata>(await _callCreateIndex.Async(request, callSettings).ConfigureAwait(false), CreateIndexOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteIndex</c>.</summary>
        public override lro::OperationsClient DeleteIndexOperationsClient { get; }

        /// <summary>
        /// Deletes a single Index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteIndex(DeleteIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteIndexRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteIndex.Sync(request, callSettings), DeleteIndexOperationsClient);
        }

        /// <summary>
        /// Deletes a single Index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteIndexAsync(DeleteIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteIndexRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteIndex.Async(request, callSettings).ConfigureAwait(false), DeleteIndexOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ImportDataObjects</c>.</summary>
        public override lro::OperationsClient ImportDataObjectsOperationsClient { get; }

        /// <summary>
        /// Initiates a Long-Running Operation to import DataObjects into a Collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ImportDataObjectsResponse, ImportDataObjectsMetadata> ImportDataObjects(ImportDataObjectsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportDataObjectsRequest(ref request, ref callSettings);
            return new lro::Operation<ImportDataObjectsResponse, ImportDataObjectsMetadata>(_callImportDataObjects.Sync(request, callSettings), ImportDataObjectsOperationsClient);
        }

        /// <summary>
        /// Initiates a Long-Running Operation to import DataObjects into a Collection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ImportDataObjectsResponse, ImportDataObjectsMetadata>> ImportDataObjectsAsync(ImportDataObjectsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportDataObjectsRequest(ref request, ref callSettings);
            return new lro::Operation<ImportDataObjectsResponse, ImportDataObjectsMetadata>(await _callImportDataObjects.Async(request, callSettings).ConfigureAwait(false), ImportDataObjectsOperationsClient);
        }
    }

    public partial class ListCollectionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListIndexesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCollectionsResponse : gaxgrpc::IPageResponse<Collection>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Collection> GetEnumerator() => Collections.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListIndexesResponse : gaxgrpc::IPageResponse<Index>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Index> GetEnumerator() => Indexes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class VectorSearchService
    {
        public partial class VectorSearchServiceClient
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

    public static partial class VectorSearchService
    {
        public partial class VectorSearchServiceClient
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
