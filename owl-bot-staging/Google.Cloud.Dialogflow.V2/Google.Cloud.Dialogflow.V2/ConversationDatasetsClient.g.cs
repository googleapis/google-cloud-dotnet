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
    /// <summary>Settings for <see cref="ConversationDatasetsClient"/> instances.</summary>
    public sealed partial class ConversationDatasetsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ConversationDatasetsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ConversationDatasetsSettings"/>.</returns>
        public static ConversationDatasetsSettings GetDefault() => new ConversationDatasetsSettings();

        /// <summary>Constructs a new <see cref="ConversationDatasetsSettings"/> object with default settings.</summary>
        public ConversationDatasetsSettings()
        {
        }

        private ConversationDatasetsSettings(ConversationDatasetsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateConversationDatasetSettings = existing.CreateConversationDatasetSettings;
            CreateConversationDatasetOperationsSettings = existing.CreateConversationDatasetOperationsSettings.Clone();
            GetConversationDatasetSettings = existing.GetConversationDatasetSettings;
            ListConversationDatasetsSettings = existing.ListConversationDatasetsSettings;
            DeleteConversationDatasetSettings = existing.DeleteConversationDatasetSettings;
            DeleteConversationDatasetOperationsSettings = existing.DeleteConversationDatasetOperationsSettings.Clone();
            ImportConversationDataSettings = existing.ImportConversationDataSettings;
            ImportConversationDataOperationsSettings = existing.ImportConversationDataOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ConversationDatasetsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationDatasetsClient.CreateConversationDataset</c> and
        /// <c>ConversationDatasetsClient.CreateConversationDatasetAsync</c>.
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
        public gaxgrpc::CallSettings CreateConversationDatasetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConversationDatasetsClient.CreateConversationDataset</c> and
        /// <c>ConversationDatasetsClient.CreateConversationDatasetAsync</c>.
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
        public lro::OperationsSettings CreateConversationDatasetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationDatasetsClient.GetConversationDataset</c> and
        /// <c>ConversationDatasetsClient.GetConversationDatasetAsync</c>.
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
        public gaxgrpc::CallSettings GetConversationDatasetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationDatasetsClient.ListConversationDatasets</c> and
        /// <c>ConversationDatasetsClient.ListConversationDatasetsAsync</c>.
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
        public gaxgrpc::CallSettings ListConversationDatasetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationDatasetsClient.DeleteConversationDataset</c> and
        /// <c>ConversationDatasetsClient.DeleteConversationDatasetAsync</c>.
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
        public gaxgrpc::CallSettings DeleteConversationDatasetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConversationDatasetsClient.DeleteConversationDataset</c> and
        /// <c>ConversationDatasetsClient.DeleteConversationDatasetAsync</c>.
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
        public lro::OperationsSettings DeleteConversationDatasetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversationDatasetsClient.ImportConversationData</c> and
        /// <c>ConversationDatasetsClient.ImportConversationDataAsync</c>.
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
        public gaxgrpc::CallSettings ImportConversationDataSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConversationDatasetsClient.ImportConversationData</c> and
        /// <c>ConversationDatasetsClient.ImportConversationDataAsync</c>.
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
        public lro::OperationsSettings ImportConversationDataOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ConversationDatasetsSettings"/> object.</returns>
        public ConversationDatasetsSettings Clone() => new ConversationDatasetsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ConversationDatasetsClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ConversationDatasetsClientBuilder : gaxgrpc::ClientBuilderBase<ConversationDatasetsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ConversationDatasetsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ConversationDatasetsClientBuilder() : base(ConversationDatasetsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ConversationDatasetsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ConversationDatasetsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ConversationDatasetsClient Build()
        {
            ConversationDatasetsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ConversationDatasetsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ConversationDatasetsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ConversationDatasetsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ConversationDatasetsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ConversationDatasetsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ConversationDatasetsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ConversationDatasetsClient.ChannelPool;
    }

    /// <summary>ConversationDatasets client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Conversation datasets.
    /// 
    /// Conversation datasets contain raw conversation files and their
    /// customizable metadata that can be used for model training.
    /// </remarks>
    public abstract partial class ConversationDatasetsClient
    {
        /// <summary>
        /// The default endpoint for the ConversationDatasets service, which is a host of "dialogflow.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dialogflow.googleapis.com:443";

        /// <summary>The default ConversationDatasets scopes.</summary>
        /// <remarks>
        /// The default ConversationDatasets scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ConversationDatasets.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ConversationDatasetsClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ConversationDatasetsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ConversationDatasetsClient"/>.</returns>
        public static stt::Task<ConversationDatasetsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ConversationDatasetsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ConversationDatasetsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="ConversationDatasetsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ConversationDatasetsClient"/>.</returns>
        public static ConversationDatasetsClient Create() => new ConversationDatasetsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ConversationDatasetsClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ConversationDatasetsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ConversationDatasetsClient"/>.</returns>
        internal static ConversationDatasetsClient Create(grpccore::CallInvoker callInvoker, ConversationDatasetsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ConversationDatasets.ConversationDatasetsClient grpcClient = new ConversationDatasets.ConversationDatasetsClient(callInvoker);
            return new ConversationDatasetsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ConversationDatasets client</summary>
        public virtual ConversationDatasets.ConversationDatasetsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new conversation dataset.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [CreateConversationDatasetOperationMetadata][google.cloud.dialogflow.v2.CreateConversationDatasetOperationMetadata]
        /// - `response`:
        /// [ConversationDataset][google.cloud.dialogflow.v2.ConversationDataset]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConversationDataset, CreateConversationDatasetOperationMetadata> CreateConversationDataset(CreateConversationDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new conversation dataset.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [CreateConversationDatasetOperationMetadata][google.cloud.dialogflow.v2.CreateConversationDatasetOperationMetadata]
        /// - `response`:
        /// [ConversationDataset][google.cloud.dialogflow.v2.ConversationDataset]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversationDataset, CreateConversationDatasetOperationMetadata>> CreateConversationDatasetAsync(CreateConversationDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new conversation dataset.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [CreateConversationDatasetOperationMetadata][google.cloud.dialogflow.v2.CreateConversationDatasetOperationMetadata]
        /// - `response`:
        /// [ConversationDataset][google.cloud.dialogflow.v2.ConversationDataset]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversationDataset, CreateConversationDatasetOperationMetadata>> CreateConversationDatasetAsync(CreateConversationDatasetRequest request, st::CancellationToken cancellationToken) =>
            CreateConversationDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateConversationDataset</c>.</summary>
        public virtual lro::OperationsClient CreateConversationDatasetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateConversationDataset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ConversationDataset, CreateConversationDatasetOperationMetadata> PollOnceCreateConversationDataset(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConversationDataset, CreateConversationDatasetOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateConversationDatasetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateConversationDataset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ConversationDataset, CreateConversationDatasetOperationMetadata>> PollOnceCreateConversationDatasetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConversationDataset, CreateConversationDatasetOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateConversationDatasetOperationsClient, callSettings);

        /// <summary>
        /// Creates a new conversation dataset.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [CreateConversationDatasetOperationMetadata][google.cloud.dialogflow.v2.CreateConversationDatasetOperationMetadata]
        /// - `response`:
        /// [ConversationDataset][google.cloud.dialogflow.v2.ConversationDataset]
        /// </summary>
        /// <param name="parent">
        /// Required. The project to create conversation dataset for. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`
        /// </param>
        /// <param name="conversationDataset">
        /// Required. The conversation dataset to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConversationDataset, CreateConversationDatasetOperationMetadata> CreateConversationDataset(string parent, ConversationDataset conversationDataset, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversationDataset(new CreateConversationDatasetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ConversationDataset = gax::GaxPreconditions.CheckNotNull(conversationDataset, nameof(conversationDataset)),
            }, callSettings);

        /// <summary>
        /// Creates a new conversation dataset.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [CreateConversationDatasetOperationMetadata][google.cloud.dialogflow.v2.CreateConversationDatasetOperationMetadata]
        /// - `response`:
        /// [ConversationDataset][google.cloud.dialogflow.v2.ConversationDataset]
        /// </summary>
        /// <param name="parent">
        /// Required. The project to create conversation dataset for. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`
        /// </param>
        /// <param name="conversationDataset">
        /// Required. The conversation dataset to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversationDataset, CreateConversationDatasetOperationMetadata>> CreateConversationDatasetAsync(string parent, ConversationDataset conversationDataset, gaxgrpc::CallSettings callSettings = null) =>
            CreateConversationDatasetAsync(new CreateConversationDatasetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ConversationDataset = gax::GaxPreconditions.CheckNotNull(conversationDataset, nameof(conversationDataset)),
            }, callSettings);

        /// <summary>
        /// Creates a new conversation dataset.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [CreateConversationDatasetOperationMetadata][google.cloud.dialogflow.v2.CreateConversationDatasetOperationMetadata]
        /// - `response`:
        /// [ConversationDataset][google.cloud.dialogflow.v2.ConversationDataset]
        /// </summary>
        /// <param name="parent">
        /// Required. The project to create conversation dataset for. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`
        /// </param>
        /// <param name="conversationDataset">
        /// Required. The conversation dataset to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConversationDataset, CreateConversationDatasetOperationMetadata>> CreateConversationDatasetAsync(string parent, ConversationDataset conversationDataset, st::CancellationToken cancellationToken) =>
            CreateConversationDatasetAsync(parent, conversationDataset, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified conversation dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConversationDataset GetConversationDataset(GetConversationDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified conversation dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversationDataset> GetConversationDatasetAsync(GetConversationDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified conversation dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversationDataset> GetConversationDatasetAsync(GetConversationDatasetRequest request, st::CancellationToken cancellationToken) =>
            GetConversationDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified conversation dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The conversation dataset to retrieve. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationDatasets/&lt;Conversation Dataset ID&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConversationDataset GetConversationDataset(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversationDataset(new GetConversationDatasetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified conversation dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The conversation dataset to retrieve. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationDatasets/&lt;Conversation Dataset ID&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversationDataset> GetConversationDatasetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversationDatasetAsync(new GetConversationDatasetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified conversation dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The conversation dataset to retrieve. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationDatasets/&lt;Conversation Dataset ID&gt;`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversationDataset> GetConversationDatasetAsync(string name, st::CancellationToken cancellationToken) =>
            GetConversationDatasetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified conversation dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The conversation dataset to retrieve. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationDatasets/&lt;Conversation Dataset ID&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConversationDataset GetConversationDataset(ConversationDatasetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversationDataset(new GetConversationDatasetRequest
            {
                ConversationDatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified conversation dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The conversation dataset to retrieve. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationDatasets/&lt;Conversation Dataset ID&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversationDataset> GetConversationDatasetAsync(ConversationDatasetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConversationDatasetAsync(new GetConversationDatasetRequest
            {
                ConversationDatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified conversation dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The conversation dataset to retrieve. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationDatasets/&lt;Conversation Dataset ID&gt;`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConversationDataset> GetConversationDatasetAsync(ConversationDatasetName name, st::CancellationToken cancellationToken) =>
            GetConversationDatasetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the list of all conversation datasets in the specified
        /// project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ConversationDataset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConversationDatasetsResponse, ConversationDataset> ListConversationDatasets(ListConversationDatasetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all conversation datasets in the specified
        /// project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ConversationDataset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConversationDatasetsResponse, ConversationDataset> ListConversationDatasetsAsync(ListConversationDatasetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all conversation datasets in the specified
        /// project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location name to list all conversation datasets
        /// for. Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`
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
        /// <returns>A pageable sequence of <see cref="ConversationDataset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConversationDatasetsResponse, ConversationDataset> ListConversationDatasets(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversationDatasetsRequest request = new ListConversationDatasetsRequest
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
            return ListConversationDatasets(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all conversation datasets in the specified
        /// project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location name to list all conversation datasets
        /// for. Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ConversationDataset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConversationDatasetsResponse, ConversationDataset> ListConversationDatasetsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversationDatasetsRequest request = new ListConversationDatasetsRequest
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
            return ListConversationDatasetsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all conversation datasets in the specified
        /// project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location name to list all conversation datasets
        /// for. Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`
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
        /// <returns>A pageable sequence of <see cref="ConversationDataset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConversationDatasetsResponse, ConversationDataset> ListConversationDatasets(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversationDatasetsRequest request = new ListConversationDatasetsRequest
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
            return ListConversationDatasets(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all conversation datasets in the specified
        /// project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location name to list all conversation datasets
        /// for. Format: `projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ConversationDataset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConversationDatasetsResponse, ConversationDataset> ListConversationDatasetsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConversationDatasetsRequest request = new ListConversationDatasetsRequest
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
            return ListConversationDatasetsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified conversation dataset.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [DeleteConversationDatasetOperationMetadata][google.cloud.dialogflow.v2.DeleteConversationDatasetOperationMetadata]
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteConversationDatasetOperationMetadata> DeleteConversationDataset(DeleteConversationDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified conversation dataset.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [DeleteConversationDatasetOperationMetadata][google.cloud.dialogflow.v2.DeleteConversationDatasetOperationMetadata]
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteConversationDatasetOperationMetadata>> DeleteConversationDatasetAsync(DeleteConversationDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified conversation dataset.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [DeleteConversationDatasetOperationMetadata][google.cloud.dialogflow.v2.DeleteConversationDatasetOperationMetadata]
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteConversationDatasetOperationMetadata>> DeleteConversationDatasetAsync(DeleteConversationDatasetRequest request, st::CancellationToken cancellationToken) =>
            DeleteConversationDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteConversationDataset</c>.</summary>
        public virtual lro::OperationsClient DeleteConversationDatasetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteConversationDataset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteConversationDatasetOperationMetadata> PollOnceDeleteConversationDataset(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteConversationDatasetOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteConversationDatasetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteConversationDataset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteConversationDatasetOperationMetadata>> PollOnceDeleteConversationDatasetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteConversationDatasetOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteConversationDatasetOperationsClient, callSettings);

        /// <summary>
        /// Deletes the specified conversation dataset.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [DeleteConversationDatasetOperationMetadata][google.cloud.dialogflow.v2.DeleteConversationDatasetOperationMetadata]
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="name">
        /// Required. The conversation dataset to delete. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationDatasets/&lt;Conversation Dataset ID&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteConversationDatasetOperationMetadata> DeleteConversationDataset(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversationDataset(new DeleteConversationDatasetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified conversation dataset.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [DeleteConversationDatasetOperationMetadata][google.cloud.dialogflow.v2.DeleteConversationDatasetOperationMetadata]
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="name">
        /// Required. The conversation dataset to delete. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationDatasets/&lt;Conversation Dataset ID&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteConversationDatasetOperationMetadata>> DeleteConversationDatasetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversationDatasetAsync(new DeleteConversationDatasetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified conversation dataset.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [DeleteConversationDatasetOperationMetadata][google.cloud.dialogflow.v2.DeleteConversationDatasetOperationMetadata]
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="name">
        /// Required. The conversation dataset to delete. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationDatasets/&lt;Conversation Dataset ID&gt;`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteConversationDatasetOperationMetadata>> DeleteConversationDatasetAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteConversationDatasetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified conversation dataset.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [DeleteConversationDatasetOperationMetadata][google.cloud.dialogflow.v2.DeleteConversationDatasetOperationMetadata]
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="name">
        /// Required. The conversation dataset to delete. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationDatasets/&lt;Conversation Dataset ID&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteConversationDatasetOperationMetadata> DeleteConversationDataset(ConversationDatasetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversationDataset(new DeleteConversationDatasetRequest
            {
                ConversationDatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified conversation dataset.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [DeleteConversationDatasetOperationMetadata][google.cloud.dialogflow.v2.DeleteConversationDatasetOperationMetadata]
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="name">
        /// Required. The conversation dataset to delete. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationDatasets/&lt;Conversation Dataset ID&gt;`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteConversationDatasetOperationMetadata>> DeleteConversationDatasetAsync(ConversationDatasetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConversationDatasetAsync(new DeleteConversationDatasetRequest
            {
                ConversationDatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified conversation dataset.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [DeleteConversationDatasetOperationMetadata][google.cloud.dialogflow.v2.DeleteConversationDatasetOperationMetadata]
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="name">
        /// Required. The conversation dataset to delete. Format:
        /// `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/conversationDatasets/&lt;Conversation Dataset ID&gt;`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteConversationDatasetOperationMetadata>> DeleteConversationDatasetAsync(ConversationDatasetName name, st::CancellationToken cancellationToken) =>
            DeleteConversationDatasetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Import data into the specified conversation dataset. Note that it
        /// is not allowed to import data to a conversation dataset that
        /// already has data in it.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [ImportConversationDataOperationMetadata][google.cloud.dialogflow.v2.ImportConversationDataOperationMetadata]
        /// - `response`:
        /// [ImportConversationDataOperationResponse][google.cloud.dialogflow.v2.ImportConversationDataOperationResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportConversationDataOperationResponse, ImportConversationDataOperationMetadata> ImportConversationData(ImportConversationDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Import data into the specified conversation dataset. Note that it
        /// is not allowed to import data to a conversation dataset that
        /// already has data in it.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [ImportConversationDataOperationMetadata][google.cloud.dialogflow.v2.ImportConversationDataOperationMetadata]
        /// - `response`:
        /// [ImportConversationDataOperationResponse][google.cloud.dialogflow.v2.ImportConversationDataOperationResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportConversationDataOperationResponse, ImportConversationDataOperationMetadata>> ImportConversationDataAsync(ImportConversationDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Import data into the specified conversation dataset. Note that it
        /// is not allowed to import data to a conversation dataset that
        /// already has data in it.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [ImportConversationDataOperationMetadata][google.cloud.dialogflow.v2.ImportConversationDataOperationMetadata]
        /// - `response`:
        /// [ImportConversationDataOperationResponse][google.cloud.dialogflow.v2.ImportConversationDataOperationResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportConversationDataOperationResponse, ImportConversationDataOperationMetadata>> ImportConversationDataAsync(ImportConversationDataRequest request, st::CancellationToken cancellationToken) =>
            ImportConversationDataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ImportConversationData</c>.</summary>
        public virtual lro::OperationsClient ImportConversationDataOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportConversationData</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ImportConversationDataOperationResponse, ImportConversationDataOperationMetadata> PollOnceImportConversationData(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportConversationDataOperationResponse, ImportConversationDataOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportConversationDataOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportConversationData</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ImportConversationDataOperationResponse, ImportConversationDataOperationMetadata>> PollOnceImportConversationDataAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportConversationDataOperationResponse, ImportConversationDataOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportConversationDataOperationsClient, callSettings);
    }

    /// <summary>ConversationDatasets client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Conversation datasets.
    /// 
    /// Conversation datasets contain raw conversation files and their
    /// customizable metadata that can be used for model training.
    /// </remarks>
    public sealed partial class ConversationDatasetsClientImpl : ConversationDatasetsClient
    {
        private readonly gaxgrpc::ApiCall<CreateConversationDatasetRequest, lro::Operation> _callCreateConversationDataset;

        private readonly gaxgrpc::ApiCall<GetConversationDatasetRequest, ConversationDataset> _callGetConversationDataset;

        private readonly gaxgrpc::ApiCall<ListConversationDatasetsRequest, ListConversationDatasetsResponse> _callListConversationDatasets;

        private readonly gaxgrpc::ApiCall<DeleteConversationDatasetRequest, lro::Operation> _callDeleteConversationDataset;

        private readonly gaxgrpc::ApiCall<ImportConversationDataRequest, lro::Operation> _callImportConversationData;

        /// <summary>
        /// Constructs a client wrapper for the ConversationDatasets service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ConversationDatasetsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ConversationDatasetsClientImpl(ConversationDatasets.ConversationDatasetsClient grpcClient, ConversationDatasetsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ConversationDatasetsSettings effectiveSettings = settings ?? ConversationDatasetsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateConversationDatasetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateConversationDatasetOperationsSettings, logger);
            DeleteConversationDatasetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteConversationDatasetOperationsSettings, logger);
            ImportConversationDataOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ImportConversationDataOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreateConversationDataset = clientHelper.BuildApiCall<CreateConversationDatasetRequest, lro::Operation>("CreateConversationDataset", grpcClient.CreateConversationDatasetAsync, grpcClient.CreateConversationDataset, effectiveSettings.CreateConversationDatasetSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateConversationDataset);
            Modify_CreateConversationDatasetApiCall(ref _callCreateConversationDataset);
            _callGetConversationDataset = clientHelper.BuildApiCall<GetConversationDatasetRequest, ConversationDataset>("GetConversationDataset", grpcClient.GetConversationDatasetAsync, grpcClient.GetConversationDataset, effectiveSettings.GetConversationDatasetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetConversationDataset);
            Modify_GetConversationDatasetApiCall(ref _callGetConversationDataset);
            _callListConversationDatasets = clientHelper.BuildApiCall<ListConversationDatasetsRequest, ListConversationDatasetsResponse>("ListConversationDatasets", grpcClient.ListConversationDatasetsAsync, grpcClient.ListConversationDatasets, effectiveSettings.ListConversationDatasetsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListConversationDatasets);
            Modify_ListConversationDatasetsApiCall(ref _callListConversationDatasets);
            _callDeleteConversationDataset = clientHelper.BuildApiCall<DeleteConversationDatasetRequest, lro::Operation>("DeleteConversationDataset", grpcClient.DeleteConversationDatasetAsync, grpcClient.DeleteConversationDataset, effectiveSettings.DeleteConversationDatasetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteConversationDataset);
            Modify_DeleteConversationDatasetApiCall(ref _callDeleteConversationDataset);
            _callImportConversationData = clientHelper.BuildApiCall<ImportConversationDataRequest, lro::Operation>("ImportConversationData", grpcClient.ImportConversationDataAsync, grpcClient.ImportConversationData, effectiveSettings.ImportConversationDataSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callImportConversationData);
            Modify_ImportConversationDataApiCall(ref _callImportConversationData);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateConversationDatasetApiCall(ref gaxgrpc::ApiCall<CreateConversationDatasetRequest, lro::Operation> call);

        partial void Modify_GetConversationDatasetApiCall(ref gaxgrpc::ApiCall<GetConversationDatasetRequest, ConversationDataset> call);

        partial void Modify_ListConversationDatasetsApiCall(ref gaxgrpc::ApiCall<ListConversationDatasetsRequest, ListConversationDatasetsResponse> call);

        partial void Modify_DeleteConversationDatasetApiCall(ref gaxgrpc::ApiCall<DeleteConversationDatasetRequest, lro::Operation> call);

        partial void Modify_ImportConversationDataApiCall(ref gaxgrpc::ApiCall<ImportConversationDataRequest, lro::Operation> call);

        partial void OnConstruction(ConversationDatasets.ConversationDatasetsClient grpcClient, ConversationDatasetsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ConversationDatasets client</summary>
        public override ConversationDatasets.ConversationDatasetsClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreateConversationDatasetRequest(ref CreateConversationDatasetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetConversationDatasetRequest(ref GetConversationDatasetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListConversationDatasetsRequest(ref ListConversationDatasetsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteConversationDatasetRequest(ref DeleteConversationDatasetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportConversationDataRequest(ref ImportConversationDataRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateConversationDataset</c>.</summary>
        public override lro::OperationsClient CreateConversationDatasetOperationsClient { get; }

        /// <summary>
        /// Creates a new conversation dataset.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [CreateConversationDatasetOperationMetadata][google.cloud.dialogflow.v2.CreateConversationDatasetOperationMetadata]
        /// - `response`:
        /// [ConversationDataset][google.cloud.dialogflow.v2.ConversationDataset]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ConversationDataset, CreateConversationDatasetOperationMetadata> CreateConversationDataset(CreateConversationDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConversationDatasetRequest(ref request, ref callSettings);
            return new lro::Operation<ConversationDataset, CreateConversationDatasetOperationMetadata>(_callCreateConversationDataset.Sync(request, callSettings), CreateConversationDatasetOperationsClient);
        }

        /// <summary>
        /// Creates a new conversation dataset.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [CreateConversationDatasetOperationMetadata][google.cloud.dialogflow.v2.CreateConversationDatasetOperationMetadata]
        /// - `response`:
        /// [ConversationDataset][google.cloud.dialogflow.v2.ConversationDataset]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ConversationDataset, CreateConversationDatasetOperationMetadata>> CreateConversationDatasetAsync(CreateConversationDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConversationDatasetRequest(ref request, ref callSettings);
            return new lro::Operation<ConversationDataset, CreateConversationDatasetOperationMetadata>(await _callCreateConversationDataset.Async(request, callSettings).ConfigureAwait(false), CreateConversationDatasetOperationsClient);
        }

        /// <summary>
        /// Retrieves the specified conversation dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ConversationDataset GetConversationDataset(GetConversationDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConversationDatasetRequest(ref request, ref callSettings);
            return _callGetConversationDataset.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified conversation dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ConversationDataset> GetConversationDatasetAsync(GetConversationDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConversationDatasetRequest(ref request, ref callSettings);
            return _callGetConversationDataset.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all conversation datasets in the specified
        /// project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ConversationDataset"/> resources.</returns>
        public override gax::PagedEnumerable<ListConversationDatasetsResponse, ConversationDataset> ListConversationDatasets(ListConversationDatasetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConversationDatasetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListConversationDatasetsRequest, ListConversationDatasetsResponse, ConversationDataset>(_callListConversationDatasets, request, callSettings);
        }

        /// <summary>
        /// Returns the list of all conversation datasets in the specified
        /// project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ConversationDataset"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListConversationDatasetsResponse, ConversationDataset> ListConversationDatasetsAsync(ListConversationDatasetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConversationDatasetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListConversationDatasetsRequest, ListConversationDatasetsResponse, ConversationDataset>(_callListConversationDatasets, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteConversationDataset</c>.</summary>
        public override lro::OperationsClient DeleteConversationDatasetOperationsClient { get; }

        /// <summary>
        /// Deletes the specified conversation dataset.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [DeleteConversationDatasetOperationMetadata][google.cloud.dialogflow.v2.DeleteConversationDatasetOperationMetadata]
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteConversationDatasetOperationMetadata> DeleteConversationDataset(DeleteConversationDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConversationDatasetRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteConversationDatasetOperationMetadata>(_callDeleteConversationDataset.Sync(request, callSettings), DeleteConversationDatasetOperationsClient);
        }

        /// <summary>
        /// Deletes the specified conversation dataset.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [DeleteConversationDatasetOperationMetadata][google.cloud.dialogflow.v2.DeleteConversationDatasetOperationMetadata]
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteConversationDatasetOperationMetadata>> DeleteConversationDatasetAsync(DeleteConversationDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConversationDatasetRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteConversationDatasetOperationMetadata>(await _callDeleteConversationDataset.Async(request, callSettings).ConfigureAwait(false), DeleteConversationDatasetOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ImportConversationData</c>.</summary>
        public override lro::OperationsClient ImportConversationDataOperationsClient { get; }

        /// <summary>
        /// Import data into the specified conversation dataset. Note that it
        /// is not allowed to import data to a conversation dataset that
        /// already has data in it.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [ImportConversationDataOperationMetadata][google.cloud.dialogflow.v2.ImportConversationDataOperationMetadata]
        /// - `response`:
        /// [ImportConversationDataOperationResponse][google.cloud.dialogflow.v2.ImportConversationDataOperationResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ImportConversationDataOperationResponse, ImportConversationDataOperationMetadata> ImportConversationData(ImportConversationDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportConversationDataRequest(ref request, ref callSettings);
            return new lro::Operation<ImportConversationDataOperationResponse, ImportConversationDataOperationMetadata>(_callImportConversationData.Sync(request, callSettings), ImportConversationDataOperationsClient);
        }

        /// <summary>
        /// Import data into the specified conversation dataset. Note that it
        /// is not allowed to import data to a conversation dataset that
        /// already has data in it.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [ImportConversationDataOperationMetadata][google.cloud.dialogflow.v2.ImportConversationDataOperationMetadata]
        /// - `response`:
        /// [ImportConversationDataOperationResponse][google.cloud.dialogflow.v2.ImportConversationDataOperationResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ImportConversationDataOperationResponse, ImportConversationDataOperationMetadata>> ImportConversationDataAsync(ImportConversationDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportConversationDataRequest(ref request, ref callSettings);
            return new lro::Operation<ImportConversationDataOperationResponse, ImportConversationDataOperationMetadata>(await _callImportConversationData.Async(request, callSettings).ConfigureAwait(false), ImportConversationDataOperationsClient);
        }
    }

    public partial class ListConversationDatasetsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListConversationDatasetsResponse : gaxgrpc::IPageResponse<ConversationDataset>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ConversationDataset> GetEnumerator() => ConversationDatasets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ConversationDatasets
    {
        public partial class ConversationDatasetsClient
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

    public static partial class ConversationDatasets
    {
        public partial class ConversationDatasetsClient
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
