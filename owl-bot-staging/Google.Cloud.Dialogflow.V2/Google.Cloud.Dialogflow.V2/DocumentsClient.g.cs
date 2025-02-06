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
    /// <summary>Settings for <see cref="DocumentsClient"/> instances.</summary>
    public sealed partial class DocumentsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DocumentsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DocumentsSettings"/>.</returns>
        public static DocumentsSettings GetDefault() => new DocumentsSettings();

        /// <summary>Constructs a new <see cref="DocumentsSettings"/> object with default settings.</summary>
        public DocumentsSettings()
        {
        }

        private DocumentsSettings(DocumentsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListDocumentsSettings = existing.ListDocumentsSettings;
            GetDocumentSettings = existing.GetDocumentSettings;
            CreateDocumentSettings = existing.CreateDocumentSettings;
            CreateDocumentOperationsSettings = existing.CreateDocumentOperationsSettings.Clone();
            ImportDocumentsSettings = existing.ImportDocumentsSettings;
            ImportDocumentsOperationsSettings = existing.ImportDocumentsOperationsSettings.Clone();
            DeleteDocumentSettings = existing.DeleteDocumentSettings;
            DeleteDocumentOperationsSettings = existing.DeleteDocumentOperationsSettings.Clone();
            UpdateDocumentSettings = existing.UpdateDocumentSettings;
            UpdateDocumentOperationsSettings = existing.UpdateDocumentOperationsSettings.Clone();
            ReloadDocumentSettings = existing.ReloadDocumentSettings;
            ReloadDocumentOperationsSettings = existing.ReloadDocumentOperationsSettings.Clone();
            ExportDocumentSettings = existing.ExportDocumentSettings;
            ExportDocumentOperationsSettings = existing.ExportDocumentOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DocumentsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentsClient.ListDocuments</c> and <c>DocumentsClient.ListDocumentsAsync</c>.
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
        public gaxgrpc::CallSettings ListDocumentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DocumentsClient.GetDocument</c>
        ///  and <c>DocumentsClient.GetDocumentAsync</c>.
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
        public gaxgrpc::CallSettings GetDocumentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentsClient.CreateDocument</c> and <c>DocumentsClient.CreateDocumentAsync</c>.
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
        public gaxgrpc::CallSettings CreateDocumentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DocumentsClient.CreateDocument</c> and
        /// <c>DocumentsClient.CreateDocumentAsync</c>.
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
        public lro::OperationsSettings CreateDocumentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentsClient.ImportDocuments</c> and <c>DocumentsClient.ImportDocumentsAsync</c>.
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
        public gaxgrpc::CallSettings ImportDocumentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DocumentsClient.ImportDocuments</c> and
        /// <c>DocumentsClient.ImportDocumentsAsync</c>.
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
        public lro::OperationsSettings ImportDocumentsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentsClient.DeleteDocument</c> and <c>DocumentsClient.DeleteDocumentAsync</c>.
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
        public gaxgrpc::CallSettings DeleteDocumentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DocumentsClient.DeleteDocument</c> and
        /// <c>DocumentsClient.DeleteDocumentAsync</c>.
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
        public lro::OperationsSettings DeleteDocumentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentsClient.UpdateDocument</c> and <c>DocumentsClient.UpdateDocumentAsync</c>.
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
        public gaxgrpc::CallSettings UpdateDocumentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DocumentsClient.UpdateDocument</c> and
        /// <c>DocumentsClient.UpdateDocumentAsync</c>.
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
        public lro::OperationsSettings UpdateDocumentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentsClient.ReloadDocument</c> and <c>DocumentsClient.ReloadDocumentAsync</c>.
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
        public gaxgrpc::CallSettings ReloadDocumentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DocumentsClient.ReloadDocument</c> and
        /// <c>DocumentsClient.ReloadDocumentAsync</c>.
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
        public lro::OperationsSettings ReloadDocumentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentsClient.ExportDocument</c> and <c>DocumentsClient.ExportDocumentAsync</c>.
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
        public gaxgrpc::CallSettings ExportDocumentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DocumentsClient.ExportDocument</c> and
        /// <c>DocumentsClient.ExportDocumentAsync</c>.
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
        public lro::OperationsSettings ExportDocumentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DocumentsSettings"/> object.</returns>
        public DocumentsSettings Clone() => new DocumentsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DocumentsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class DocumentsClientBuilder : gaxgrpc::ClientBuilderBase<DocumentsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DocumentsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DocumentsClientBuilder() : base(DocumentsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DocumentsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DocumentsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DocumentsClient Build()
        {
            DocumentsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DocumentsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DocumentsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DocumentsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DocumentsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DocumentsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DocumentsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DocumentsClient.ChannelPool;
    }

    /// <summary>Documents client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing knowledge
    /// [Documents][google.cloud.dialogflow.v2.Document].
    /// </remarks>
    public abstract partial class DocumentsClient
    {
        /// <summary>
        /// The default endpoint for the Documents service, which is a host of "dialogflow.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dialogflow.googleapis.com:443";

        /// <summary>The default Documents scopes.</summary>
        /// <remarks>
        /// The default Documents scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Documents.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DocumentsClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="DocumentsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DocumentsClient"/>.</returns>
        public static stt::Task<DocumentsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DocumentsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DocumentsClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="DocumentsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DocumentsClient"/>.</returns>
        public static DocumentsClient Create() => new DocumentsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DocumentsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DocumentsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DocumentsClient"/>.</returns>
        internal static DocumentsClient Create(grpccore::CallInvoker callInvoker, DocumentsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Documents.DocumentsClient grpcClient = new Documents.DocumentsClient(callInvoker);
            return new DocumentsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Documents client</summary>
        public virtual Documents.DocumentsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all documents of the knowledge base.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Document"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDocumentsResponse, Document> ListDocuments(ListDocumentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all documents of the knowledge base.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Document"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDocumentsResponse, Document> ListDocumentsAsync(ListDocumentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all documents of the knowledge base.
        /// </summary>
        /// <param name="parent">
        /// Required. The knowledge base to list all documents for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/knowledgeBases/&lt;Knowledge Base ID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="Document"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDocumentsResponse, Document> ListDocuments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDocumentsRequest request = new ListDocumentsRequest
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
            return ListDocuments(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all documents of the knowledge base.
        /// </summary>
        /// <param name="parent">
        /// Required. The knowledge base to list all documents for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/knowledgeBases/&lt;Knowledge Base ID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Document"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDocumentsResponse, Document> ListDocumentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDocumentsRequest request = new ListDocumentsRequest
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
            return ListDocumentsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all documents of the knowledge base.
        /// </summary>
        /// <param name="parent">
        /// Required. The knowledge base to list all documents for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/knowledgeBases/&lt;Knowledge Base ID&gt;`.
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
        /// <returns>A pageable sequence of <see cref="Document"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDocumentsResponse, Document> ListDocuments(KnowledgeBaseName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDocumentsRequest request = new ListDocumentsRequest
            {
                ParentAsKnowledgeBaseName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDocuments(request, callSettings);
        }

        /// <summary>
        /// Returns the list of all documents of the knowledge base.
        /// </summary>
        /// <param name="parent">
        /// Required. The knowledge base to list all documents for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/knowledgeBases/&lt;Knowledge Base ID&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Document"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDocumentsResponse, Document> ListDocumentsAsync(KnowledgeBaseName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDocumentsRequest request = new ListDocumentsRequest
            {
                ParentAsKnowledgeBaseName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDocumentsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Document GetDocument(GetDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Document> GetDocumentAsync(GetDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Document> GetDocumentAsync(GetDocumentRequest request, st::CancellationToken cancellationToken) =>
            GetDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified document.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the document to retrieve.
        /// Format `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/knowledgeBases/&lt;Knowledge Base ID&gt;/documents/&lt;Document ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Document GetDocument(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDocument(new GetDocumentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified document.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the document to retrieve.
        /// Format `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/knowledgeBases/&lt;Knowledge Base ID&gt;/documents/&lt;Document ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Document> GetDocumentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDocumentAsync(new GetDocumentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified document.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the document to retrieve.
        /// Format `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/knowledgeBases/&lt;Knowledge Base ID&gt;/documents/&lt;Document ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Document> GetDocumentAsync(string name, st::CancellationToken cancellationToken) =>
            GetDocumentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified document.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the document to retrieve.
        /// Format `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/knowledgeBases/&lt;Knowledge Base ID&gt;/documents/&lt;Document ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Document GetDocument(DocumentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDocument(new GetDocumentRequest
            {
                DocumentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified document.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the document to retrieve.
        /// Format `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/knowledgeBases/&lt;Knowledge Base ID&gt;/documents/&lt;Document ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Document> GetDocumentAsync(DocumentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDocumentAsync(new GetDocumentRequest
            {
                DocumentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified document.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the document to retrieve.
        /// Format `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/knowledgeBases/&lt;Knowledge Base ID&gt;/documents/&lt;Document ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Document> GetDocumentAsync(DocumentName name, st::CancellationToken cancellationToken) =>
            GetDocumentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new document.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: [Document][google.cloud.dialogflow.v2.Document]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Document, KnowledgeOperationMetadata> CreateDocument(CreateDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new document.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: [Document][google.cloud.dialogflow.v2.Document]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Document, KnowledgeOperationMetadata>> CreateDocumentAsync(CreateDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new document.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: [Document][google.cloud.dialogflow.v2.Document]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Document, KnowledgeOperationMetadata>> CreateDocumentAsync(CreateDocumentRequest request, st::CancellationToken cancellationToken) =>
            CreateDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateDocument</c>.</summary>
        public virtual lro::OperationsClient CreateDocumentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateDocument</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Document, KnowledgeOperationMetadata> PollOnceCreateDocument(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Document, KnowledgeOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDocumentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateDocument</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Document, KnowledgeOperationMetadata>> PollOnceCreateDocumentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Document, KnowledgeOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDocumentOperationsClient, callSettings);

        /// <summary>
        /// Creates a new document.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: [Document][google.cloud.dialogflow.v2.Document]
        /// </summary>
        /// <param name="parent">
        /// Required. The knowledge base to create a document for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/knowledgeBases/&lt;Knowledge Base ID&gt;`.
        /// </param>
        /// <param name="document">
        /// Required. The document to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Document, KnowledgeOperationMetadata> CreateDocument(string parent, Document document, gaxgrpc::CallSettings callSettings = null) =>
            CreateDocument(new CreateDocumentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
            }, callSettings);

        /// <summary>
        /// Creates a new document.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: [Document][google.cloud.dialogflow.v2.Document]
        /// </summary>
        /// <param name="parent">
        /// Required. The knowledge base to create a document for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/knowledgeBases/&lt;Knowledge Base ID&gt;`.
        /// </param>
        /// <param name="document">
        /// Required. The document to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Document, KnowledgeOperationMetadata>> CreateDocumentAsync(string parent, Document document, gaxgrpc::CallSettings callSettings = null) =>
            CreateDocumentAsync(new CreateDocumentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
            }, callSettings);

        /// <summary>
        /// Creates a new document.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: [Document][google.cloud.dialogflow.v2.Document]
        /// </summary>
        /// <param name="parent">
        /// Required. The knowledge base to create a document for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/knowledgeBases/&lt;Knowledge Base ID&gt;`.
        /// </param>
        /// <param name="document">
        /// Required. The document to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Document, KnowledgeOperationMetadata>> CreateDocumentAsync(string parent, Document document, st::CancellationToken cancellationToken) =>
            CreateDocumentAsync(parent, document, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new document.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: [Document][google.cloud.dialogflow.v2.Document]
        /// </summary>
        /// <param name="parent">
        /// Required. The knowledge base to create a document for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/knowledgeBases/&lt;Knowledge Base ID&gt;`.
        /// </param>
        /// <param name="document">
        /// Required. The document to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Document, KnowledgeOperationMetadata> CreateDocument(KnowledgeBaseName parent, Document document, gaxgrpc::CallSettings callSettings = null) =>
            CreateDocument(new CreateDocumentRequest
            {
                ParentAsKnowledgeBaseName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
            }, callSettings);

        /// <summary>
        /// Creates a new document.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: [Document][google.cloud.dialogflow.v2.Document]
        /// </summary>
        /// <param name="parent">
        /// Required. The knowledge base to create a document for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/knowledgeBases/&lt;Knowledge Base ID&gt;`.
        /// </param>
        /// <param name="document">
        /// Required. The document to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Document, KnowledgeOperationMetadata>> CreateDocumentAsync(KnowledgeBaseName parent, Document document, gaxgrpc::CallSettings callSettings = null) =>
            CreateDocumentAsync(new CreateDocumentRequest
            {
                ParentAsKnowledgeBaseName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
            }, callSettings);

        /// <summary>
        /// Creates a new document.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: [Document][google.cloud.dialogflow.v2.Document]
        /// </summary>
        /// <param name="parent">
        /// Required. The knowledge base to create a document for.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/knowledgeBases/&lt;Knowledge Base ID&gt;`.
        /// </param>
        /// <param name="document">
        /// Required. The document to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Document, KnowledgeOperationMetadata>> CreateDocumentAsync(KnowledgeBaseName parent, Document document, st::CancellationToken cancellationToken) =>
            CreateDocumentAsync(parent, document, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates documents by importing data from external sources.
        /// Dialogflow supports up to 350 documents in each request. If you try to
        /// import more, Dialogflow will return an error.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`:
        /// [ImportDocumentsResponse][google.cloud.dialogflow.v2.ImportDocumentsResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportDocumentsResponse, KnowledgeOperationMetadata> ImportDocuments(ImportDocumentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates documents by importing data from external sources.
        /// Dialogflow supports up to 350 documents in each request. If you try to
        /// import more, Dialogflow will return an error.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`:
        /// [ImportDocumentsResponse][google.cloud.dialogflow.v2.ImportDocumentsResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportDocumentsResponse, KnowledgeOperationMetadata>> ImportDocumentsAsync(ImportDocumentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates documents by importing data from external sources.
        /// Dialogflow supports up to 350 documents in each request. If you try to
        /// import more, Dialogflow will return an error.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`:
        /// [ImportDocumentsResponse][google.cloud.dialogflow.v2.ImportDocumentsResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportDocumentsResponse, KnowledgeOperationMetadata>> ImportDocumentsAsync(ImportDocumentsRequest request, st::CancellationToken cancellationToken) =>
            ImportDocumentsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ImportDocuments</c>.</summary>
        public virtual lro::OperationsClient ImportDocumentsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ImportDocuments</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ImportDocumentsResponse, KnowledgeOperationMetadata> PollOnceImportDocuments(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportDocumentsResponse, KnowledgeOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportDocumentsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportDocuments</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ImportDocumentsResponse, KnowledgeOperationMetadata>> PollOnceImportDocumentsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportDocumentsResponse, KnowledgeOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportDocumentsOperationsClient, callSettings);

        /// <summary>
        /// Deletes the specified document.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, KnowledgeOperationMetadata> DeleteDocument(DeleteDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified document.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, KnowledgeOperationMetadata>> DeleteDocumentAsync(DeleteDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified document.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, KnowledgeOperationMetadata>> DeleteDocumentAsync(DeleteDocumentRequest request, st::CancellationToken cancellationToken) =>
            DeleteDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteDocument</c>.</summary>
        public virtual lro::OperationsClient DeleteDocumentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteDocument</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, KnowledgeOperationMetadata> PollOnceDeleteDocument(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, KnowledgeOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDocumentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteDocument</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, KnowledgeOperationMetadata>> PollOnceDeleteDocumentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, KnowledgeOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDocumentOperationsClient, callSettings);

        /// <summary>
        /// Deletes the specified document.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="name">
        /// Required. The name of the document to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/knowledgeBases/&lt;Knowledge Base ID&gt;/documents/&lt;Document ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, KnowledgeOperationMetadata> DeleteDocument(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDocument(new DeleteDocumentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified document.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="name">
        /// Required. The name of the document to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/knowledgeBases/&lt;Knowledge Base ID&gt;/documents/&lt;Document ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, KnowledgeOperationMetadata>> DeleteDocumentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDocumentAsync(new DeleteDocumentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified document.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="name">
        /// Required. The name of the document to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/knowledgeBases/&lt;Knowledge Base ID&gt;/documents/&lt;Document ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, KnowledgeOperationMetadata>> DeleteDocumentAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDocumentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified document.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="name">
        /// Required. The name of the document to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/knowledgeBases/&lt;Knowledge Base ID&gt;/documents/&lt;Document ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, KnowledgeOperationMetadata> DeleteDocument(DocumentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDocument(new DeleteDocumentRequest
            {
                DocumentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified document.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="name">
        /// Required. The name of the document to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/knowledgeBases/&lt;Knowledge Base ID&gt;/documents/&lt;Document ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, KnowledgeOperationMetadata>> DeleteDocumentAsync(DocumentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDocumentAsync(new DeleteDocumentRequest
            {
                DocumentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified document.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="name">
        /// Required. The name of the document to delete.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/knowledgeBases/&lt;Knowledge Base ID&gt;/documents/&lt;Document ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, KnowledgeOperationMetadata>> DeleteDocumentAsync(DocumentName name, st::CancellationToken cancellationToken) =>
            DeleteDocumentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified document.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: [Document][google.cloud.dialogflow.v2.Document]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Document, KnowledgeOperationMetadata> UpdateDocument(UpdateDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified document.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: [Document][google.cloud.dialogflow.v2.Document]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Document, KnowledgeOperationMetadata>> UpdateDocumentAsync(UpdateDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified document.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: [Document][google.cloud.dialogflow.v2.Document]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Document, KnowledgeOperationMetadata>> UpdateDocumentAsync(UpdateDocumentRequest request, st::CancellationToken cancellationToken) =>
            UpdateDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateDocument</c>.</summary>
        public virtual lro::OperationsClient UpdateDocumentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateDocument</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Document, KnowledgeOperationMetadata> PollOnceUpdateDocument(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Document, KnowledgeOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDocumentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateDocument</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Document, KnowledgeOperationMetadata>> PollOnceUpdateDocumentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Document, KnowledgeOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDocumentOperationsClient, callSettings);

        /// <summary>
        /// Updates the specified document.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: [Document][google.cloud.dialogflow.v2.Document]
        /// </summary>
        /// <param name="document">
        /// Required. The document to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Not specified means `update all`.
        /// Currently, only `display_name` can be updated, an InvalidArgument will be
        /// returned for attempting to update other fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Document, KnowledgeOperationMetadata> UpdateDocument(Document document, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDocument(new UpdateDocumentRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified document.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: [Document][google.cloud.dialogflow.v2.Document]
        /// </summary>
        /// <param name="document">
        /// Required. The document to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Not specified means `update all`.
        /// Currently, only `display_name` can be updated, an InvalidArgument will be
        /// returned for attempting to update other fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Document, KnowledgeOperationMetadata>> UpdateDocumentAsync(Document document, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDocumentAsync(new UpdateDocumentRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified document.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: [Document][google.cloud.dialogflow.v2.Document]
        /// </summary>
        /// <param name="document">
        /// Required. The document to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Not specified means `update all`.
        /// Currently, only `display_name` can be updated, an InvalidArgument will be
        /// returned for attempting to update other fields.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Document, KnowledgeOperationMetadata>> UpdateDocumentAsync(Document document, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDocumentAsync(document, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reloads the specified document from its specified source, content_uri or
        /// content. The previously loaded content of the document will be deleted.
        /// Note: Even when the content of the document has not changed, there still
        /// may be side effects because of internal implementation changes.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: [Document][google.cloud.dialogflow.v2.Document]
        /// 
        /// Note: The `projects.agent.knowledgeBases.documents` resource is deprecated;
        /// only use `projects.knowledgeBases.documents`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Document, KnowledgeOperationMetadata> ReloadDocument(ReloadDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reloads the specified document from its specified source, content_uri or
        /// content. The previously loaded content of the document will be deleted.
        /// Note: Even when the content of the document has not changed, there still
        /// may be side effects because of internal implementation changes.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: [Document][google.cloud.dialogflow.v2.Document]
        /// 
        /// Note: The `projects.agent.knowledgeBases.documents` resource is deprecated;
        /// only use `projects.knowledgeBases.documents`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Document, KnowledgeOperationMetadata>> ReloadDocumentAsync(ReloadDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reloads the specified document from its specified source, content_uri or
        /// content. The previously loaded content of the document will be deleted.
        /// Note: Even when the content of the document has not changed, there still
        /// may be side effects because of internal implementation changes.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: [Document][google.cloud.dialogflow.v2.Document]
        /// 
        /// Note: The `projects.agent.knowledgeBases.documents` resource is deprecated;
        /// only use `projects.knowledgeBases.documents`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Document, KnowledgeOperationMetadata>> ReloadDocumentAsync(ReloadDocumentRequest request, st::CancellationToken cancellationToken) =>
            ReloadDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ReloadDocument</c>.</summary>
        public virtual lro::OperationsClient ReloadDocumentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ReloadDocument</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Document, KnowledgeOperationMetadata> PollOnceReloadDocument(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Document, KnowledgeOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ReloadDocumentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ReloadDocument</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Document, KnowledgeOperationMetadata>> PollOnceReloadDocumentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Document, KnowledgeOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ReloadDocumentOperationsClient, callSettings);

        /// <summary>
        /// Reloads the specified document from its specified source, content_uri or
        /// content. The previously loaded content of the document will be deleted.
        /// Note: Even when the content of the document has not changed, there still
        /// may be side effects because of internal implementation changes.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: [Document][google.cloud.dialogflow.v2.Document]
        /// 
        /// Note: The `projects.agent.knowledgeBases.documents` resource is deprecated;
        /// only use `projects.knowledgeBases.documents`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the document to reload.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/knowledgeBases/&lt;Knowledge Base ID&gt;/documents/&lt;Document ID&gt;`
        /// </param>
        /// <param name="contentUri">
        /// Optional. The path of gcs source file for reloading document content. For
        /// now, only gcs uri is supported.
        /// 
        /// For documents stored in Google Cloud Storage, these URIs must have
        /// the form `gs://&lt;bucket-name&gt;/&lt;object-name&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Document, KnowledgeOperationMetadata> ReloadDocument(string name, string contentUri, gaxgrpc::CallSettings callSettings = null) =>
            ReloadDocument(new ReloadDocumentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                ContentUri = contentUri ?? "",
            }, callSettings);

        /// <summary>
        /// Reloads the specified document from its specified source, content_uri or
        /// content. The previously loaded content of the document will be deleted.
        /// Note: Even when the content of the document has not changed, there still
        /// may be side effects because of internal implementation changes.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: [Document][google.cloud.dialogflow.v2.Document]
        /// 
        /// Note: The `projects.agent.knowledgeBases.documents` resource is deprecated;
        /// only use `projects.knowledgeBases.documents`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the document to reload.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/knowledgeBases/&lt;Knowledge Base ID&gt;/documents/&lt;Document ID&gt;`
        /// </param>
        /// <param name="contentUri">
        /// Optional. The path of gcs source file for reloading document content. For
        /// now, only gcs uri is supported.
        /// 
        /// For documents stored in Google Cloud Storage, these URIs must have
        /// the form `gs://&lt;bucket-name&gt;/&lt;object-name&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Document, KnowledgeOperationMetadata>> ReloadDocumentAsync(string name, string contentUri, gaxgrpc::CallSettings callSettings = null) =>
            ReloadDocumentAsync(new ReloadDocumentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                ContentUri = contentUri ?? "",
            }, callSettings);

        /// <summary>
        /// Reloads the specified document from its specified source, content_uri or
        /// content. The previously loaded content of the document will be deleted.
        /// Note: Even when the content of the document has not changed, there still
        /// may be side effects because of internal implementation changes.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: [Document][google.cloud.dialogflow.v2.Document]
        /// 
        /// Note: The `projects.agent.knowledgeBases.documents` resource is deprecated;
        /// only use `projects.knowledgeBases.documents`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the document to reload.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/knowledgeBases/&lt;Knowledge Base ID&gt;/documents/&lt;Document ID&gt;`
        /// </param>
        /// <param name="contentUri">
        /// Optional. The path of gcs source file for reloading document content. For
        /// now, only gcs uri is supported.
        /// 
        /// For documents stored in Google Cloud Storage, these URIs must have
        /// the form `gs://&lt;bucket-name&gt;/&lt;object-name&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Document, KnowledgeOperationMetadata>> ReloadDocumentAsync(string name, string contentUri, st::CancellationToken cancellationToken) =>
            ReloadDocumentAsync(name, contentUri, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reloads the specified document from its specified source, content_uri or
        /// content. The previously loaded content of the document will be deleted.
        /// Note: Even when the content of the document has not changed, there still
        /// may be side effects because of internal implementation changes.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: [Document][google.cloud.dialogflow.v2.Document]
        /// 
        /// Note: The `projects.agent.knowledgeBases.documents` resource is deprecated;
        /// only use `projects.knowledgeBases.documents`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the document to reload.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/knowledgeBases/&lt;Knowledge Base ID&gt;/documents/&lt;Document ID&gt;`
        /// </param>
        /// <param name="contentUri">
        /// Optional. The path of gcs source file for reloading document content. For
        /// now, only gcs uri is supported.
        /// 
        /// For documents stored in Google Cloud Storage, these URIs must have
        /// the form `gs://&lt;bucket-name&gt;/&lt;object-name&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Document, KnowledgeOperationMetadata> ReloadDocument(DocumentName name, string contentUri, gaxgrpc::CallSettings callSettings = null) =>
            ReloadDocument(new ReloadDocumentRequest
            {
                DocumentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                ContentUri = contentUri ?? "",
            }, callSettings);

        /// <summary>
        /// Reloads the specified document from its specified source, content_uri or
        /// content. The previously loaded content of the document will be deleted.
        /// Note: Even when the content of the document has not changed, there still
        /// may be side effects because of internal implementation changes.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: [Document][google.cloud.dialogflow.v2.Document]
        /// 
        /// Note: The `projects.agent.knowledgeBases.documents` resource is deprecated;
        /// only use `projects.knowledgeBases.documents`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the document to reload.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/knowledgeBases/&lt;Knowledge Base ID&gt;/documents/&lt;Document ID&gt;`
        /// </param>
        /// <param name="contentUri">
        /// Optional. The path of gcs source file for reloading document content. For
        /// now, only gcs uri is supported.
        /// 
        /// For documents stored in Google Cloud Storage, these URIs must have
        /// the form `gs://&lt;bucket-name&gt;/&lt;object-name&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Document, KnowledgeOperationMetadata>> ReloadDocumentAsync(DocumentName name, string contentUri, gaxgrpc::CallSettings callSettings = null) =>
            ReloadDocumentAsync(new ReloadDocumentRequest
            {
                DocumentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                ContentUri = contentUri ?? "",
            }, callSettings);

        /// <summary>
        /// Reloads the specified document from its specified source, content_uri or
        /// content. The previously loaded content of the document will be deleted.
        /// Note: Even when the content of the document has not changed, there still
        /// may be side effects because of internal implementation changes.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: [Document][google.cloud.dialogflow.v2.Document]
        /// 
        /// Note: The `projects.agent.knowledgeBases.documents` resource is deprecated;
        /// only use `projects.knowledgeBases.documents`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the document to reload.
        /// Format: `projects/&lt;Project ID&gt;/locations/&lt;Location
        /// ID&gt;/knowledgeBases/&lt;Knowledge Base ID&gt;/documents/&lt;Document ID&gt;`
        /// </param>
        /// <param name="contentUri">
        /// Optional. The path of gcs source file for reloading document content. For
        /// now, only gcs uri is supported.
        /// 
        /// For documents stored in Google Cloud Storage, these URIs must have
        /// the form `gs://&lt;bucket-name&gt;/&lt;object-name&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Document, KnowledgeOperationMetadata>> ReloadDocumentAsync(DocumentName name, string contentUri, st::CancellationToken cancellationToken) =>
            ReloadDocumentAsync(name, contentUri, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports a smart messaging candidate document into the specified
        /// destination.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: [Document][google.cloud.dialogflow.v2.Document]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Document, KnowledgeOperationMetadata> ExportDocument(ExportDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports a smart messaging candidate document into the specified
        /// destination.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: [Document][google.cloud.dialogflow.v2.Document]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Document, KnowledgeOperationMetadata>> ExportDocumentAsync(ExportDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports a smart messaging candidate document into the specified
        /// destination.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: [Document][google.cloud.dialogflow.v2.Document]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Document, KnowledgeOperationMetadata>> ExportDocumentAsync(ExportDocumentRequest request, st::CancellationToken cancellationToken) =>
            ExportDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExportDocument</c>.</summary>
        public virtual lro::OperationsClient ExportDocumentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ExportDocument</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Document, KnowledgeOperationMetadata> PollOnceExportDocument(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Document, KnowledgeOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportDocumentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportDocument</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Document, KnowledgeOperationMetadata>> PollOnceExportDocumentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Document, KnowledgeOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportDocumentOperationsClient, callSettings);
    }

    /// <summary>Documents client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing knowledge
    /// [Documents][google.cloud.dialogflow.v2.Document].
    /// </remarks>
    public sealed partial class DocumentsClientImpl : DocumentsClient
    {
        private readonly gaxgrpc::ApiCall<ListDocumentsRequest, ListDocumentsResponse> _callListDocuments;

        private readonly gaxgrpc::ApiCall<GetDocumentRequest, Document> _callGetDocument;

        private readonly gaxgrpc::ApiCall<CreateDocumentRequest, lro::Operation> _callCreateDocument;

        private readonly gaxgrpc::ApiCall<ImportDocumentsRequest, lro::Operation> _callImportDocuments;

        private readonly gaxgrpc::ApiCall<DeleteDocumentRequest, lro::Operation> _callDeleteDocument;

        private readonly gaxgrpc::ApiCall<UpdateDocumentRequest, lro::Operation> _callUpdateDocument;

        private readonly gaxgrpc::ApiCall<ReloadDocumentRequest, lro::Operation> _callReloadDocument;

        private readonly gaxgrpc::ApiCall<ExportDocumentRequest, lro::Operation> _callExportDocument;

        /// <summary>
        /// Constructs a client wrapper for the Documents service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DocumentsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DocumentsClientImpl(Documents.DocumentsClient grpcClient, DocumentsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DocumentsSettings effectiveSettings = settings ?? DocumentsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateDocumentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateDocumentOperationsSettings, logger);
            ImportDocumentsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ImportDocumentsOperationsSettings, logger);
            DeleteDocumentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteDocumentOperationsSettings, logger);
            UpdateDocumentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateDocumentOperationsSettings, logger);
            ReloadDocumentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ReloadDocumentOperationsSettings, logger);
            ExportDocumentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportDocumentOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListDocuments = clientHelper.BuildApiCall<ListDocumentsRequest, ListDocumentsResponse>("ListDocuments", grpcClient.ListDocumentsAsync, grpcClient.ListDocuments, effectiveSettings.ListDocumentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDocuments);
            Modify_ListDocumentsApiCall(ref _callListDocuments);
            _callGetDocument = clientHelper.BuildApiCall<GetDocumentRequest, Document>("GetDocument", grpcClient.GetDocumentAsync, grpcClient.GetDocument, effectiveSettings.GetDocumentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDocument);
            Modify_GetDocumentApiCall(ref _callGetDocument);
            _callCreateDocument = clientHelper.BuildApiCall<CreateDocumentRequest, lro::Operation>("CreateDocument", grpcClient.CreateDocumentAsync, grpcClient.CreateDocument, effectiveSettings.CreateDocumentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDocument);
            Modify_CreateDocumentApiCall(ref _callCreateDocument);
            _callImportDocuments = clientHelper.BuildApiCall<ImportDocumentsRequest, lro::Operation>("ImportDocuments", grpcClient.ImportDocumentsAsync, grpcClient.ImportDocuments, effectiveSettings.ImportDocumentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callImportDocuments);
            Modify_ImportDocumentsApiCall(ref _callImportDocuments);
            _callDeleteDocument = clientHelper.BuildApiCall<DeleteDocumentRequest, lro::Operation>("DeleteDocument", grpcClient.DeleteDocumentAsync, grpcClient.DeleteDocument, effectiveSettings.DeleteDocumentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDocument);
            Modify_DeleteDocumentApiCall(ref _callDeleteDocument);
            _callUpdateDocument = clientHelper.BuildApiCall<UpdateDocumentRequest, lro::Operation>("UpdateDocument", grpcClient.UpdateDocumentAsync, grpcClient.UpdateDocument, effectiveSettings.UpdateDocumentSettings).WithGoogleRequestParam("document.name", request => request.Document?.Name);
            Modify_ApiCall(ref _callUpdateDocument);
            Modify_UpdateDocumentApiCall(ref _callUpdateDocument);
            _callReloadDocument = clientHelper.BuildApiCall<ReloadDocumentRequest, lro::Operation>("ReloadDocument", grpcClient.ReloadDocumentAsync, grpcClient.ReloadDocument, effectiveSettings.ReloadDocumentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callReloadDocument);
            Modify_ReloadDocumentApiCall(ref _callReloadDocument);
            _callExportDocument = clientHelper.BuildApiCall<ExportDocumentRequest, lro::Operation>("ExportDocument", grpcClient.ExportDocumentAsync, grpcClient.ExportDocument, effectiveSettings.ExportDocumentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callExportDocument);
            Modify_ExportDocumentApiCall(ref _callExportDocument);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListDocumentsApiCall(ref gaxgrpc::ApiCall<ListDocumentsRequest, ListDocumentsResponse> call);

        partial void Modify_GetDocumentApiCall(ref gaxgrpc::ApiCall<GetDocumentRequest, Document> call);

        partial void Modify_CreateDocumentApiCall(ref gaxgrpc::ApiCall<CreateDocumentRequest, lro::Operation> call);

        partial void Modify_ImportDocumentsApiCall(ref gaxgrpc::ApiCall<ImportDocumentsRequest, lro::Operation> call);

        partial void Modify_DeleteDocumentApiCall(ref gaxgrpc::ApiCall<DeleteDocumentRequest, lro::Operation> call);

        partial void Modify_UpdateDocumentApiCall(ref gaxgrpc::ApiCall<UpdateDocumentRequest, lro::Operation> call);

        partial void Modify_ReloadDocumentApiCall(ref gaxgrpc::ApiCall<ReloadDocumentRequest, lro::Operation> call);

        partial void Modify_ExportDocumentApiCall(ref gaxgrpc::ApiCall<ExportDocumentRequest, lro::Operation> call);

        partial void OnConstruction(Documents.DocumentsClient grpcClient, DocumentsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Documents client</summary>
        public override Documents.DocumentsClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListDocumentsRequest(ref ListDocumentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDocumentRequest(ref GetDocumentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateDocumentRequest(ref CreateDocumentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportDocumentsRequest(ref ImportDocumentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDocumentRequest(ref DeleteDocumentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDocumentRequest(ref UpdateDocumentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReloadDocumentRequest(ref ReloadDocumentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportDocumentRequest(ref ExportDocumentRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the list of all documents of the knowledge base.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Document"/> resources.</returns>
        public override gax::PagedEnumerable<ListDocumentsResponse, Document> ListDocuments(ListDocumentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDocumentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDocumentsRequest, ListDocumentsResponse, Document>(_callListDocuments, request, callSettings);
        }

        /// <summary>
        /// Returns the list of all documents of the knowledge base.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Document"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDocumentsResponse, Document> ListDocumentsAsync(ListDocumentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDocumentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDocumentsRequest, ListDocumentsResponse, Document>(_callListDocuments, request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Document GetDocument(GetDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDocumentRequest(ref request, ref callSettings);
            return _callGetDocument.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Document> GetDocumentAsync(GetDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDocumentRequest(ref request, ref callSettings);
            return _callGetDocument.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateDocument</c>.</summary>
        public override lro::OperationsClient CreateDocumentOperationsClient { get; }

        /// <summary>
        /// Creates a new document.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: [Document][google.cloud.dialogflow.v2.Document]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Document, KnowledgeOperationMetadata> CreateDocument(CreateDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDocumentRequest(ref request, ref callSettings);
            return new lro::Operation<Document, KnowledgeOperationMetadata>(_callCreateDocument.Sync(request, callSettings), CreateDocumentOperationsClient);
        }

        /// <summary>
        /// Creates a new document.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: [Document][google.cloud.dialogflow.v2.Document]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Document, KnowledgeOperationMetadata>> CreateDocumentAsync(CreateDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDocumentRequest(ref request, ref callSettings);
            return new lro::Operation<Document, KnowledgeOperationMetadata>(await _callCreateDocument.Async(request, callSettings).ConfigureAwait(false), CreateDocumentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ImportDocuments</c>.</summary>
        public override lro::OperationsClient ImportDocumentsOperationsClient { get; }

        /// <summary>
        /// Creates documents by importing data from external sources.
        /// Dialogflow supports up to 350 documents in each request. If you try to
        /// import more, Dialogflow will return an error.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`:
        /// [ImportDocumentsResponse][google.cloud.dialogflow.v2.ImportDocumentsResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ImportDocumentsResponse, KnowledgeOperationMetadata> ImportDocuments(ImportDocumentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportDocumentsRequest(ref request, ref callSettings);
            return new lro::Operation<ImportDocumentsResponse, KnowledgeOperationMetadata>(_callImportDocuments.Sync(request, callSettings), ImportDocumentsOperationsClient);
        }

        /// <summary>
        /// Creates documents by importing data from external sources.
        /// Dialogflow supports up to 350 documents in each request. If you try to
        /// import more, Dialogflow will return an error.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`:
        /// [ImportDocumentsResponse][google.cloud.dialogflow.v2.ImportDocumentsResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ImportDocumentsResponse, KnowledgeOperationMetadata>> ImportDocumentsAsync(ImportDocumentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportDocumentsRequest(ref request, ref callSettings);
            return new lro::Operation<ImportDocumentsResponse, KnowledgeOperationMetadata>(await _callImportDocuments.Async(request, callSettings).ConfigureAwait(false), ImportDocumentsOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteDocument</c>.</summary>
        public override lro::OperationsClient DeleteDocumentOperationsClient { get; }

        /// <summary>
        /// Deletes the specified document.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, KnowledgeOperationMetadata> DeleteDocument(DeleteDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDocumentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, KnowledgeOperationMetadata>(_callDeleteDocument.Sync(request, callSettings), DeleteDocumentOperationsClient);
        }

        /// <summary>
        /// Deletes the specified document.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, KnowledgeOperationMetadata>> DeleteDocumentAsync(DeleteDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDocumentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, KnowledgeOperationMetadata>(await _callDeleteDocument.Async(request, callSettings).ConfigureAwait(false), DeleteDocumentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateDocument</c>.</summary>
        public override lro::OperationsClient UpdateDocumentOperationsClient { get; }

        /// <summary>
        /// Updates the specified document.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: [Document][google.cloud.dialogflow.v2.Document]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Document, KnowledgeOperationMetadata> UpdateDocument(UpdateDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDocumentRequest(ref request, ref callSettings);
            return new lro::Operation<Document, KnowledgeOperationMetadata>(_callUpdateDocument.Sync(request, callSettings), UpdateDocumentOperationsClient);
        }

        /// <summary>
        /// Updates the specified document.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: [Document][google.cloud.dialogflow.v2.Document]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Document, KnowledgeOperationMetadata>> UpdateDocumentAsync(UpdateDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDocumentRequest(ref request, ref callSettings);
            return new lro::Operation<Document, KnowledgeOperationMetadata>(await _callUpdateDocument.Async(request, callSettings).ConfigureAwait(false), UpdateDocumentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ReloadDocument</c>.</summary>
        public override lro::OperationsClient ReloadDocumentOperationsClient { get; }

        /// <summary>
        /// Reloads the specified document from its specified source, content_uri or
        /// content. The previously loaded content of the document will be deleted.
        /// Note: Even when the content of the document has not changed, there still
        /// may be side effects because of internal implementation changes.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: [Document][google.cloud.dialogflow.v2.Document]
        /// 
        /// Note: The `projects.agent.knowledgeBases.documents` resource is deprecated;
        /// only use `projects.knowledgeBases.documents`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Document, KnowledgeOperationMetadata> ReloadDocument(ReloadDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReloadDocumentRequest(ref request, ref callSettings);
            return new lro::Operation<Document, KnowledgeOperationMetadata>(_callReloadDocument.Sync(request, callSettings), ReloadDocumentOperationsClient);
        }

        /// <summary>
        /// Reloads the specified document from its specified source, content_uri or
        /// content. The previously loaded content of the document will be deleted.
        /// Note: Even when the content of the document has not changed, there still
        /// may be side effects because of internal implementation changes.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: [Document][google.cloud.dialogflow.v2.Document]
        /// 
        /// Note: The `projects.agent.knowledgeBases.documents` resource is deprecated;
        /// only use `projects.knowledgeBases.documents`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Document, KnowledgeOperationMetadata>> ReloadDocumentAsync(ReloadDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReloadDocumentRequest(ref request, ref callSettings);
            return new lro::Operation<Document, KnowledgeOperationMetadata>(await _callReloadDocument.Async(request, callSettings).ConfigureAwait(false), ReloadDocumentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ExportDocument</c>.</summary>
        public override lro::OperationsClient ExportDocumentOperationsClient { get; }

        /// <summary>
        /// Exports a smart messaging candidate document into the specified
        /// destination.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: [Document][google.cloud.dialogflow.v2.Document]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Document, KnowledgeOperationMetadata> ExportDocument(ExportDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportDocumentRequest(ref request, ref callSettings);
            return new lro::Operation<Document, KnowledgeOperationMetadata>(_callExportDocument.Sync(request, callSettings), ExportDocumentOperationsClient);
        }

        /// <summary>
        /// Exports a smart messaging candidate document into the specified
        /// destination.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`:
        /// [KnowledgeOperationMetadata][google.cloud.dialogflow.v2.KnowledgeOperationMetadata]
        /// - `response`: [Document][google.cloud.dialogflow.v2.Document]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Document, KnowledgeOperationMetadata>> ExportDocumentAsync(ExportDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportDocumentRequest(ref request, ref callSettings);
            return new lro::Operation<Document, KnowledgeOperationMetadata>(await _callExportDocument.Async(request, callSettings).ConfigureAwait(false), ExportDocumentOperationsClient);
        }
    }

    public partial class ListDocumentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDocumentsResponse : gaxgrpc::IPageResponse<Document>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Document> GetEnumerator() => Documents.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Documents
    {
        public partial class DocumentsClient
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

    public static partial class Documents
    {
        public partial class DocumentsClient
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
