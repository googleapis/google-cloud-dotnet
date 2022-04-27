// Copyright 2022 Google LLC
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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gagr = Google.Api.Gax.ResourceNames;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Firestore.Admin.V1
{
    /// <summary>Settings for <see cref="FirestoreAdminClient"/> instances.</summary>
    public sealed partial class FirestoreAdminSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="FirestoreAdminSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="FirestoreAdminSettings"/>.</returns>
        public static FirestoreAdminSettings GetDefault() => new FirestoreAdminSettings();

        /// <summary>Constructs a new <see cref="FirestoreAdminSettings"/> object with default settings.</summary>
        public FirestoreAdminSettings()
        {
        }

        private FirestoreAdminSettings(FirestoreAdminSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateIndexSettings = existing.CreateIndexSettings;
            CreateIndexOperationsSettings = existing.CreateIndexOperationsSettings.Clone();
            ListIndexesSettings = existing.ListIndexesSettings;
            GetIndexSettings = existing.GetIndexSettings;
            DeleteIndexSettings = existing.DeleteIndexSettings;
            GetFieldSettings = existing.GetFieldSettings;
            UpdateFieldSettings = existing.UpdateFieldSettings;
            UpdateFieldOperationsSettings = existing.UpdateFieldOperationsSettings.Clone();
            ListFieldsSettings = existing.ListFieldsSettings;
            ExportDocumentsSettings = existing.ExportDocumentsSettings;
            ExportDocumentsOperationsSettings = existing.ExportDocumentsOperationsSettings.Clone();
            ImportDocumentsSettings = existing.ImportDocumentsSettings;
            ImportDocumentsOperationsSettings = existing.ImportDocumentsOperationsSettings.Clone();
            GetDatabaseSettings = existing.GetDatabaseSettings;
            ListDatabasesSettings = existing.ListDatabasesSettings;
            UpdateDatabaseSettings = existing.UpdateDatabaseSettings;
            UpdateDatabaseOperationsSettings = existing.UpdateDatabaseOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(FirestoreAdminSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreAdminClient.CreateIndex</c> and <c>FirestoreAdminClient.CreateIndexAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateIndexSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>FirestoreAdminClient.CreateIndex</c> and
        /// <c>FirestoreAdminClient.CreateIndexAsync</c>.
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
        /// <c>FirestoreAdminClient.ListIndexes</c> and <c>FirestoreAdminClient.ListIndexesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListIndexesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Internal, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreAdminClient.GetIndex</c> and <c>FirestoreAdminClient.GetIndexAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIndexSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Internal, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreAdminClient.DeleteIndex</c> and <c>FirestoreAdminClient.DeleteIndexAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteIndexSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Internal, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreAdminClient.GetField</c> and <c>FirestoreAdminClient.GetFieldAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetFieldSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Internal, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreAdminClient.UpdateField</c> and <c>FirestoreAdminClient.UpdateFieldAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateFieldSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>FirestoreAdminClient.UpdateField</c> and
        /// <c>FirestoreAdminClient.UpdateFieldAsync</c>.
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
        public lro::OperationsSettings UpdateFieldOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreAdminClient.ListFields</c> and <c>FirestoreAdminClient.ListFieldsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListFieldsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Internal, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreAdminClient.ExportDocuments</c> and <c>FirestoreAdminClient.ExportDocumentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExportDocumentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>FirestoreAdminClient.ExportDocuments</c> and
        /// <c>FirestoreAdminClient.ExportDocumentsAsync</c>.
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
        public lro::OperationsSettings ExportDocumentsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreAdminClient.ImportDocuments</c> and <c>FirestoreAdminClient.ImportDocumentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ImportDocumentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>FirestoreAdminClient.ImportDocuments</c> and
        /// <c>FirestoreAdminClient.ImportDocumentsAsync</c>.
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
        /// <c>FirestoreAdminClient.GetDatabase</c> and <c>FirestoreAdminClient.GetDatabaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDatabaseSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreAdminClient.ListDatabases</c> and <c>FirestoreAdminClient.ListDatabasesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDatabasesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreAdminClient.UpdateDatabase</c> and <c>FirestoreAdminClient.UpdateDatabaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDatabaseSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>FirestoreAdminClient.UpdateDatabase</c> and
        /// <c>FirestoreAdminClient.UpdateDatabaseAsync</c>.
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
        public lro::OperationsSettings UpdateDatabaseOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="FirestoreAdminSettings"/> object.</returns>
        public FirestoreAdminSettings Clone() => new FirestoreAdminSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="FirestoreAdminClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class FirestoreAdminClientBuilder : gaxgrpc::ClientBuilderBase<FirestoreAdminClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public FirestoreAdminSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public FirestoreAdminClientBuilder() : base(FirestoreAdminClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref FirestoreAdminClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<FirestoreAdminClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override FirestoreAdminClient Build()
        {
            FirestoreAdminClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<FirestoreAdminClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<FirestoreAdminClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private FirestoreAdminClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return FirestoreAdminClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<FirestoreAdminClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return FirestoreAdminClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => FirestoreAdminClient.ChannelPool;
    }

    /// <summary>FirestoreAdmin client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The Cloud Firestore Admin API.
    /// 
    /// This API provides several administrative services for Cloud Firestore.
    /// 
    /// Project, Database, Namespace, Collection, Collection Group, and Document are
    /// used as defined in the Google Cloud Firestore API.
    /// 
    /// Operation: An Operation represents work being performed in the background.
    /// 
    /// The index service manages Cloud Firestore indexes.
    /// 
    /// Index creation is performed asynchronously.
    /// An Operation resource is created for each such asynchronous operation.
    /// The state of the operation (including any errors encountered)
    /// may be queried via the Operation resource.
    /// 
    /// The Operations collection provides a record of actions performed for the
    /// specified Project (including any Operations in progress). Operations are not
    /// created directly but through calls on other collections or resources.
    /// 
    /// An Operation that is done may be deleted so that it is no longer listed as
    /// part of the Operation collection. Operations are garbage collected after
    /// 30 days. By default, ListOperations will only return in progress and failed
    /// operations. To list completed operation, issue a ListOperations request with
    /// the filter `done: true`.
    /// 
    /// Operations are created by service `FirestoreAdmin`, but are accessed via
    /// service `google.longrunning.Operations`.
    /// </remarks>
    public abstract partial class FirestoreAdminClient
    {
        /// <summary>
        /// The default endpoint for the FirestoreAdmin service, which is a host of "firestore.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "firestore.googleapis.com:443";

        /// <summary>The default FirestoreAdmin scopes.</summary>
        /// <remarks>
        /// The default FirestoreAdmin scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/datastore</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/datastore",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(FirestoreAdmin.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="FirestoreAdminClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="FirestoreAdminClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="FirestoreAdminClient"/>.</returns>
        public static stt::Task<FirestoreAdminClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new FirestoreAdminClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="FirestoreAdminClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="FirestoreAdminClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="FirestoreAdminClient"/>.</returns>
        public static FirestoreAdminClient Create() => new FirestoreAdminClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="FirestoreAdminClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="FirestoreAdminSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="FirestoreAdminClient"/>.</returns>
        internal static FirestoreAdminClient Create(grpccore::CallInvoker callInvoker, FirestoreAdminSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            FirestoreAdmin.FirestoreAdminClient grpcClient = new FirestoreAdmin.FirestoreAdminClient(callInvoker);
            return new FirestoreAdminClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC FirestoreAdmin client</summary>
        public virtual FirestoreAdmin.FirestoreAdminClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a composite index. This returns a [google.longrunning.Operation][google.longrunning.Operation]
        /// which may be used to track the status of the creation. The metadata for
        /// the operation will be the type [IndexOperationMetadata][google.firestore.admin.v1.IndexOperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Index, IndexOperationMetadata> CreateIndex(CreateIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a composite index. This returns a [google.longrunning.Operation][google.longrunning.Operation]
        /// which may be used to track the status of the creation. The metadata for
        /// the operation will be the type [IndexOperationMetadata][google.firestore.admin.v1.IndexOperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Index, IndexOperationMetadata>> CreateIndexAsync(CreateIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a composite index. This returns a [google.longrunning.Operation][google.longrunning.Operation]
        /// which may be used to track the status of the creation. The metadata for
        /// the operation will be the type [IndexOperationMetadata][google.firestore.admin.v1.IndexOperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Index, IndexOperationMetadata>> CreateIndexAsync(CreateIndexRequest request, st::CancellationToken cancellationToken) =>
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
        public virtual lro::Operation<Index, IndexOperationMetadata> PollOnceCreateIndex(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Index, IndexOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateIndexOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateIndex</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Index, IndexOperationMetadata>> PollOnceCreateIndexAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Index, IndexOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateIndexOperationsClient, callSettings);

        /// <summary>
        /// Creates a composite index. This returns a [google.longrunning.Operation][google.longrunning.Operation]
        /// which may be used to track the status of the creation. The metadata for
        /// the operation will be the type [IndexOperationMetadata][google.firestore.admin.v1.IndexOperationMetadata].
        /// </summary>
        /// <param name="parent">
        /// Required. A parent name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}`
        /// </param>
        /// <param name="index">
        /// Required. The composite index to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Index, IndexOperationMetadata> CreateIndex(string parent, Index index, gaxgrpc::CallSettings callSettings = null) =>
            CreateIndex(new CreateIndexRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Index = gax::GaxPreconditions.CheckNotNull(index, nameof(index)),
            }, callSettings);

        /// <summary>
        /// Creates a composite index. This returns a [google.longrunning.Operation][google.longrunning.Operation]
        /// which may be used to track the status of the creation. The metadata for
        /// the operation will be the type [IndexOperationMetadata][google.firestore.admin.v1.IndexOperationMetadata].
        /// </summary>
        /// <param name="parent">
        /// Required. A parent name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}`
        /// </param>
        /// <param name="index">
        /// Required. The composite index to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Index, IndexOperationMetadata>> CreateIndexAsync(string parent, Index index, gaxgrpc::CallSettings callSettings = null) =>
            CreateIndexAsync(new CreateIndexRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Index = gax::GaxPreconditions.CheckNotNull(index, nameof(index)),
            }, callSettings);

        /// <summary>
        /// Creates a composite index. This returns a [google.longrunning.Operation][google.longrunning.Operation]
        /// which may be used to track the status of the creation. The metadata for
        /// the operation will be the type [IndexOperationMetadata][google.firestore.admin.v1.IndexOperationMetadata].
        /// </summary>
        /// <param name="parent">
        /// Required. A parent name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}`
        /// </param>
        /// <param name="index">
        /// Required. The composite index to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Index, IndexOperationMetadata>> CreateIndexAsync(string parent, Index index, st::CancellationToken cancellationToken) =>
            CreateIndexAsync(parent, index, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a composite index. This returns a [google.longrunning.Operation][google.longrunning.Operation]
        /// which may be used to track the status of the creation. The metadata for
        /// the operation will be the type [IndexOperationMetadata][google.firestore.admin.v1.IndexOperationMetadata].
        /// </summary>
        /// <param name="parent">
        /// Required. A parent name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}`
        /// </param>
        /// <param name="index">
        /// Required. The composite index to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Index, IndexOperationMetadata> CreateIndex(CollectionGroupName parent, Index index, gaxgrpc::CallSettings callSettings = null) =>
            CreateIndex(new CreateIndexRequest
            {
                ParentAsCollectionGroupName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Index = gax::GaxPreconditions.CheckNotNull(index, nameof(index)),
            }, callSettings);

        /// <summary>
        /// Creates a composite index. This returns a [google.longrunning.Operation][google.longrunning.Operation]
        /// which may be used to track the status of the creation. The metadata for
        /// the operation will be the type [IndexOperationMetadata][google.firestore.admin.v1.IndexOperationMetadata].
        /// </summary>
        /// <param name="parent">
        /// Required. A parent name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}`
        /// </param>
        /// <param name="index">
        /// Required. The composite index to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Index, IndexOperationMetadata>> CreateIndexAsync(CollectionGroupName parent, Index index, gaxgrpc::CallSettings callSettings = null) =>
            CreateIndexAsync(new CreateIndexRequest
            {
                ParentAsCollectionGroupName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Index = gax::GaxPreconditions.CheckNotNull(index, nameof(index)),
            }, callSettings);

        /// <summary>
        /// Creates a composite index. This returns a [google.longrunning.Operation][google.longrunning.Operation]
        /// which may be used to track the status of the creation. The metadata for
        /// the operation will be the type [IndexOperationMetadata][google.firestore.admin.v1.IndexOperationMetadata].
        /// </summary>
        /// <param name="parent">
        /// Required. A parent name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}`
        /// </param>
        /// <param name="index">
        /// Required. The composite index to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Index, IndexOperationMetadata>> CreateIndexAsync(CollectionGroupName parent, Index index, st::CancellationToken cancellationToken) =>
            CreateIndexAsync(parent, index, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists composite indexes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Index"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListIndexesResponse, Index> ListIndexes(ListIndexesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists composite indexes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Index"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListIndexesResponse, Index> ListIndexesAsync(ListIndexesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists composite indexes.
        /// </summary>
        /// <param name="parent">
        /// Required. A parent name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}`
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
        public virtual gax::PagedEnumerable<ListIndexesResponse, Index> ListIndexes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListIndexes(new ListIndexesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists composite indexes.
        /// </summary>
        /// <param name="parent">
        /// Required. A parent name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}`
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
        public virtual gax::PagedAsyncEnumerable<ListIndexesResponse, Index> ListIndexesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListIndexesAsync(new ListIndexesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists composite indexes.
        /// </summary>
        /// <param name="parent">
        /// Required. A parent name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}`
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
        public virtual gax::PagedEnumerable<ListIndexesResponse, Index> ListIndexes(CollectionGroupName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListIndexes(new ListIndexesRequest
            {
                ParentAsCollectionGroupName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists composite indexes.
        /// </summary>
        /// <param name="parent">
        /// Required. A parent name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}`
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
        public virtual gax::PagedAsyncEnumerable<ListIndexesResponse, Index> ListIndexesAsync(CollectionGroupName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListIndexesAsync(new ListIndexesRequest
            {
                ParentAsCollectionGroupName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets a composite index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Index GetIndex(GetIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a composite index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Index> GetIndexAsync(GetIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a composite index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Index> GetIndexAsync(GetIndexRequest request, st::CancellationToken cancellationToken) =>
            GetIndexAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a composite index.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/indexes/{index_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Index GetIndex(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetIndex(new GetIndexRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a composite index.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/indexes/{index_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Index> GetIndexAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetIndexAsync(new GetIndexRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a composite index.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/indexes/{index_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Index> GetIndexAsync(string name, st::CancellationToken cancellationToken) =>
            GetIndexAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a composite index.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/indexes/{index_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Index GetIndex(IndexName name, gaxgrpc::CallSettings callSettings = null) =>
            GetIndex(new GetIndexRequest
            {
                IndexName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a composite index.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/indexes/{index_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Index> GetIndexAsync(IndexName name, gaxgrpc::CallSettings callSettings = null) =>
            GetIndexAsync(new GetIndexRequest
            {
                IndexName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a composite index.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/indexes/{index_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Index> GetIndexAsync(IndexName name, st::CancellationToken cancellationToken) =>
            GetIndexAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a composite index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteIndex(DeleteIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a composite index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteIndexAsync(DeleteIndexRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a composite index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteIndexAsync(DeleteIndexRequest request, st::CancellationToken cancellationToken) =>
            DeleteIndexAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a composite index.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/indexes/{index_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteIndex(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIndex(new DeleteIndexRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a composite index.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/indexes/{index_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteIndexAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIndexAsync(new DeleteIndexRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a composite index.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/indexes/{index_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteIndexAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteIndexAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a composite index.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/indexes/{index_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteIndex(IndexName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIndex(new DeleteIndexRequest
            {
                IndexName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a composite index.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/indexes/{index_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteIndexAsync(IndexName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteIndexAsync(new DeleteIndexRequest
            {
                IndexName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a composite index.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/indexes/{index_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteIndexAsync(IndexName name, st::CancellationToken cancellationToken) =>
            DeleteIndexAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the metadata and configuration for a Field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Field GetField(GetFieldRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the metadata and configuration for a Field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Field> GetFieldAsync(GetFieldRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the metadata and configuration for a Field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Field> GetFieldAsync(GetFieldRequest request, st::CancellationToken cancellationToken) =>
            GetFieldAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the metadata and configuration for a Field.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/fields/{field_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Field GetField(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetField(new GetFieldRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the metadata and configuration for a Field.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/fields/{field_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Field> GetFieldAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFieldAsync(new GetFieldRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the metadata and configuration for a Field.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/fields/{field_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Field> GetFieldAsync(string name, st::CancellationToken cancellationToken) =>
            GetFieldAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the metadata and configuration for a Field.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/fields/{field_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Field GetField(FieldName name, gaxgrpc::CallSettings callSettings = null) =>
            GetField(new GetFieldRequest
            {
                FieldName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the metadata and configuration for a Field.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/fields/{field_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Field> GetFieldAsync(FieldName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFieldAsync(new GetFieldRequest
            {
                FieldName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the metadata and configuration for a Field.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/fields/{field_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Field> GetFieldAsync(FieldName name, st::CancellationToken cancellationToken) =>
            GetFieldAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a field configuration. Currently, field updates apply only to
        /// single field index configuration. However, calls to
        /// [FirestoreAdmin.UpdateField][google.firestore.admin.v1.FirestoreAdmin.UpdateField] should provide a field mask to avoid
        /// changing any configuration that the caller isn't aware of. The field mask
        /// should be specified as: `{ paths: "index_config" }`.
        /// 
        /// This call returns a [google.longrunning.Operation][google.longrunning.Operation] which may be used to
        /// track the status of the field update. The metadata for
        /// the operation will be the type [FieldOperationMetadata][google.firestore.admin.v1.FieldOperationMetadata].
        /// 
        /// To configure the default field settings for the database, use
        /// the special `Field` with resource name:
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/__default__/fields/*`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Field, FieldOperationMetadata> UpdateField(UpdateFieldRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a field configuration. Currently, field updates apply only to
        /// single field index configuration. However, calls to
        /// [FirestoreAdmin.UpdateField][google.firestore.admin.v1.FirestoreAdmin.UpdateField] should provide a field mask to avoid
        /// changing any configuration that the caller isn't aware of. The field mask
        /// should be specified as: `{ paths: "index_config" }`.
        /// 
        /// This call returns a [google.longrunning.Operation][google.longrunning.Operation] which may be used to
        /// track the status of the field update. The metadata for
        /// the operation will be the type [FieldOperationMetadata][google.firestore.admin.v1.FieldOperationMetadata].
        /// 
        /// To configure the default field settings for the database, use
        /// the special `Field` with resource name:
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/__default__/fields/*`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Field, FieldOperationMetadata>> UpdateFieldAsync(UpdateFieldRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a field configuration. Currently, field updates apply only to
        /// single field index configuration. However, calls to
        /// [FirestoreAdmin.UpdateField][google.firestore.admin.v1.FirestoreAdmin.UpdateField] should provide a field mask to avoid
        /// changing any configuration that the caller isn't aware of. The field mask
        /// should be specified as: `{ paths: "index_config" }`.
        /// 
        /// This call returns a [google.longrunning.Operation][google.longrunning.Operation] which may be used to
        /// track the status of the field update. The metadata for
        /// the operation will be the type [FieldOperationMetadata][google.firestore.admin.v1.FieldOperationMetadata].
        /// 
        /// To configure the default field settings for the database, use
        /// the special `Field` with resource name:
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/__default__/fields/*`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Field, FieldOperationMetadata>> UpdateFieldAsync(UpdateFieldRequest request, st::CancellationToken cancellationToken) =>
            UpdateFieldAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateField</c>.</summary>
        public virtual lro::OperationsClient UpdateFieldOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateField</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Field, FieldOperationMetadata> PollOnceUpdateField(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Field, FieldOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateFieldOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateField</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Field, FieldOperationMetadata>> PollOnceUpdateFieldAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Field, FieldOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateFieldOperationsClient, callSettings);

        /// <summary>
        /// Updates a field configuration. Currently, field updates apply only to
        /// single field index configuration. However, calls to
        /// [FirestoreAdmin.UpdateField][google.firestore.admin.v1.FirestoreAdmin.UpdateField] should provide a field mask to avoid
        /// changing any configuration that the caller isn't aware of. The field mask
        /// should be specified as: `{ paths: "index_config" }`.
        /// 
        /// This call returns a [google.longrunning.Operation][google.longrunning.Operation] which may be used to
        /// track the status of the field update. The metadata for
        /// the operation will be the type [FieldOperationMetadata][google.firestore.admin.v1.FieldOperationMetadata].
        /// 
        /// To configure the default field settings for the database, use
        /// the special `Field` with resource name:
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/__default__/fields/*`.
        /// </summary>
        /// <param name="field">
        /// Required. The field to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Field, FieldOperationMetadata> UpdateField(Field field, gaxgrpc::CallSettings callSettings = null) =>
            UpdateField(new UpdateFieldRequest
            {
                Field = gax::GaxPreconditions.CheckNotNull(field, nameof(field)),
            }, callSettings);

        /// <summary>
        /// Updates a field configuration. Currently, field updates apply only to
        /// single field index configuration. However, calls to
        /// [FirestoreAdmin.UpdateField][google.firestore.admin.v1.FirestoreAdmin.UpdateField] should provide a field mask to avoid
        /// changing any configuration that the caller isn't aware of. The field mask
        /// should be specified as: `{ paths: "index_config" }`.
        /// 
        /// This call returns a [google.longrunning.Operation][google.longrunning.Operation] which may be used to
        /// track the status of the field update. The metadata for
        /// the operation will be the type [FieldOperationMetadata][google.firestore.admin.v1.FieldOperationMetadata].
        /// 
        /// To configure the default field settings for the database, use
        /// the special `Field` with resource name:
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/__default__/fields/*`.
        /// </summary>
        /// <param name="field">
        /// Required. The field to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Field, FieldOperationMetadata>> UpdateFieldAsync(Field field, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFieldAsync(new UpdateFieldRequest
            {
                Field = gax::GaxPreconditions.CheckNotNull(field, nameof(field)),
            }, callSettings);

        /// <summary>
        /// Updates a field configuration. Currently, field updates apply only to
        /// single field index configuration. However, calls to
        /// [FirestoreAdmin.UpdateField][google.firestore.admin.v1.FirestoreAdmin.UpdateField] should provide a field mask to avoid
        /// changing any configuration that the caller isn't aware of. The field mask
        /// should be specified as: `{ paths: "index_config" }`.
        /// 
        /// This call returns a [google.longrunning.Operation][google.longrunning.Operation] which may be used to
        /// track the status of the field update. The metadata for
        /// the operation will be the type [FieldOperationMetadata][google.firestore.admin.v1.FieldOperationMetadata].
        /// 
        /// To configure the default field settings for the database, use
        /// the special `Field` with resource name:
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/__default__/fields/*`.
        /// </summary>
        /// <param name="field">
        /// Required. The field to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Field, FieldOperationMetadata>> UpdateFieldAsync(Field field, st::CancellationToken cancellationToken) =>
            UpdateFieldAsync(field, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the field configuration and metadata for this database.
        /// 
        /// Currently, [FirestoreAdmin.ListFields][google.firestore.admin.v1.FirestoreAdmin.ListFields] only supports listing fields
        /// that have been explicitly overridden. To issue this query, call
        /// [FirestoreAdmin.ListFields][google.firestore.admin.v1.FirestoreAdmin.ListFields] with the filter set to
        /// `indexConfig.usesAncestorConfig:false` .
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Field"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFieldsResponse, Field> ListFields(ListFieldsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the field configuration and metadata for this database.
        /// 
        /// Currently, [FirestoreAdmin.ListFields][google.firestore.admin.v1.FirestoreAdmin.ListFields] only supports listing fields
        /// that have been explicitly overridden. To issue this query, call
        /// [FirestoreAdmin.ListFields][google.firestore.admin.v1.FirestoreAdmin.ListFields] with the filter set to
        /// `indexConfig.usesAncestorConfig:false` .
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Field"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFieldsResponse, Field> ListFieldsAsync(ListFieldsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the field configuration and metadata for this database.
        /// 
        /// Currently, [FirestoreAdmin.ListFields][google.firestore.admin.v1.FirestoreAdmin.ListFields] only supports listing fields
        /// that have been explicitly overridden. To issue this query, call
        /// [FirestoreAdmin.ListFields][google.firestore.admin.v1.FirestoreAdmin.ListFields] with the filter set to
        /// `indexConfig.usesAncestorConfig:false` .
        /// </summary>
        /// <param name="parent">
        /// Required. A parent name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}`
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
        /// <returns>A pageable sequence of <see cref="Field"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFieldsResponse, Field> ListFields(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListFields(new ListFieldsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists the field configuration and metadata for this database.
        /// 
        /// Currently, [FirestoreAdmin.ListFields][google.firestore.admin.v1.FirestoreAdmin.ListFields] only supports listing fields
        /// that have been explicitly overridden. To issue this query, call
        /// [FirestoreAdmin.ListFields][google.firestore.admin.v1.FirestoreAdmin.ListFields] with the filter set to
        /// `indexConfig.usesAncestorConfig:false` .
        /// </summary>
        /// <param name="parent">
        /// Required. A parent name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Field"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFieldsResponse, Field> ListFieldsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListFieldsAsync(new ListFieldsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists the field configuration and metadata for this database.
        /// 
        /// Currently, [FirestoreAdmin.ListFields][google.firestore.admin.v1.FirestoreAdmin.ListFields] only supports listing fields
        /// that have been explicitly overridden. To issue this query, call
        /// [FirestoreAdmin.ListFields][google.firestore.admin.v1.FirestoreAdmin.ListFields] with the filter set to
        /// `indexConfig.usesAncestorConfig:false` .
        /// </summary>
        /// <param name="parent">
        /// Required. A parent name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}`
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
        /// <returns>A pageable sequence of <see cref="Field"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFieldsResponse, Field> ListFields(CollectionGroupName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListFields(new ListFieldsRequest
            {
                ParentAsCollectionGroupName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists the field configuration and metadata for this database.
        /// 
        /// Currently, [FirestoreAdmin.ListFields][google.firestore.admin.v1.FirestoreAdmin.ListFields] only supports listing fields
        /// that have been explicitly overridden. To issue this query, call
        /// [FirestoreAdmin.ListFields][google.firestore.admin.v1.FirestoreAdmin.ListFields] with the filter set to
        /// `indexConfig.usesAncestorConfig:false` .
        /// </summary>
        /// <param name="parent">
        /// Required. A parent name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Field"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFieldsResponse, Field> ListFieldsAsync(CollectionGroupName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListFieldsAsync(new ListFieldsRequest
            {
                ParentAsCollectionGroupName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Exports a copy of all or a subset of documents from Google Cloud Firestore
        /// to another storage system, such as Google Cloud Storage. Recent updates to
        /// documents may not be reflected in the export. The export occurs in the
        /// background and its progress can be monitored and managed via the
        /// Operation resource that is created. The output of an export may only be
        /// used once the associated operation is done. If an export operation is
        /// cancelled before completion it may leave partial data behind in Google
        /// Cloud Storage.
        /// 
        /// For more details on export behavior and output format, refer to:
        /// https://cloud.google.com/firestore/docs/manage-data/export-import
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportDocumentsResponse, ExportDocumentsMetadata> ExportDocuments(ExportDocumentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports a copy of all or a subset of documents from Google Cloud Firestore
        /// to another storage system, such as Google Cloud Storage. Recent updates to
        /// documents may not be reflected in the export. The export occurs in the
        /// background and its progress can be monitored and managed via the
        /// Operation resource that is created. The output of an export may only be
        /// used once the associated operation is done. If an export operation is
        /// cancelled before completion it may leave partial data behind in Google
        /// Cloud Storage.
        /// 
        /// For more details on export behavior and output format, refer to:
        /// https://cloud.google.com/firestore/docs/manage-data/export-import
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportDocumentsResponse, ExportDocumentsMetadata>> ExportDocumentsAsync(ExportDocumentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports a copy of all or a subset of documents from Google Cloud Firestore
        /// to another storage system, such as Google Cloud Storage. Recent updates to
        /// documents may not be reflected in the export. The export occurs in the
        /// background and its progress can be monitored and managed via the
        /// Operation resource that is created. The output of an export may only be
        /// used once the associated operation is done. If an export operation is
        /// cancelled before completion it may leave partial data behind in Google
        /// Cloud Storage.
        /// 
        /// For more details on export behavior and output format, refer to:
        /// https://cloud.google.com/firestore/docs/manage-data/export-import
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportDocumentsResponse, ExportDocumentsMetadata>> ExportDocumentsAsync(ExportDocumentsRequest request, st::CancellationToken cancellationToken) =>
            ExportDocumentsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExportDocuments</c>.</summary>
        public virtual lro::OperationsClient ExportDocumentsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ExportDocuments</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ExportDocumentsResponse, ExportDocumentsMetadata> PollOnceExportDocuments(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportDocumentsResponse, ExportDocumentsMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportDocumentsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportDocuments</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExportDocumentsResponse, ExportDocumentsMetadata>> PollOnceExportDocumentsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportDocumentsResponse, ExportDocumentsMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportDocumentsOperationsClient, callSettings);

        /// <summary>
        /// Exports a copy of all or a subset of documents from Google Cloud Firestore
        /// to another storage system, such as Google Cloud Storage. Recent updates to
        /// documents may not be reflected in the export. The export occurs in the
        /// background and its progress can be monitored and managed via the
        /// Operation resource that is created. The output of an export may only be
        /// used once the associated operation is done. If an export operation is
        /// cancelled before completion it may leave partial data behind in Google
        /// Cloud Storage.
        /// 
        /// For more details on export behavior and output format, refer to:
        /// https://cloud.google.com/firestore/docs/manage-data/export-import
        /// </summary>
        /// <param name="name">
        /// Required. Database to export. Should be of the form:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportDocumentsResponse, ExportDocumentsMetadata> ExportDocuments(string name, gaxgrpc::CallSettings callSettings = null) =>
            ExportDocuments(new ExportDocumentsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Exports a copy of all or a subset of documents from Google Cloud Firestore
        /// to another storage system, such as Google Cloud Storage. Recent updates to
        /// documents may not be reflected in the export. The export occurs in the
        /// background and its progress can be monitored and managed via the
        /// Operation resource that is created. The output of an export may only be
        /// used once the associated operation is done. If an export operation is
        /// cancelled before completion it may leave partial data behind in Google
        /// Cloud Storage.
        /// 
        /// For more details on export behavior and output format, refer to:
        /// https://cloud.google.com/firestore/docs/manage-data/export-import
        /// </summary>
        /// <param name="name">
        /// Required. Database to export. Should be of the form:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportDocumentsResponse, ExportDocumentsMetadata>> ExportDocumentsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ExportDocumentsAsync(new ExportDocumentsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Exports a copy of all or a subset of documents from Google Cloud Firestore
        /// to another storage system, such as Google Cloud Storage. Recent updates to
        /// documents may not be reflected in the export. The export occurs in the
        /// background and its progress can be monitored and managed via the
        /// Operation resource that is created. The output of an export may only be
        /// used once the associated operation is done. If an export operation is
        /// cancelled before completion it may leave partial data behind in Google
        /// Cloud Storage.
        /// 
        /// For more details on export behavior and output format, refer to:
        /// https://cloud.google.com/firestore/docs/manage-data/export-import
        /// </summary>
        /// <param name="name">
        /// Required. Database to export. Should be of the form:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportDocumentsResponse, ExportDocumentsMetadata>> ExportDocumentsAsync(string name, st::CancellationToken cancellationToken) =>
            ExportDocumentsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports a copy of all or a subset of documents from Google Cloud Firestore
        /// to another storage system, such as Google Cloud Storage. Recent updates to
        /// documents may not be reflected in the export. The export occurs in the
        /// background and its progress can be monitored and managed via the
        /// Operation resource that is created. The output of an export may only be
        /// used once the associated operation is done. If an export operation is
        /// cancelled before completion it may leave partial data behind in Google
        /// Cloud Storage.
        /// 
        /// For more details on export behavior and output format, refer to:
        /// https://cloud.google.com/firestore/docs/manage-data/export-import
        /// </summary>
        /// <param name="name">
        /// Required. Database to export. Should be of the form:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportDocumentsResponse, ExportDocumentsMetadata> ExportDocuments(DatabaseName name, gaxgrpc::CallSettings callSettings = null) =>
            ExportDocuments(new ExportDocumentsRequest
            {
                DatabaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Exports a copy of all or a subset of documents from Google Cloud Firestore
        /// to another storage system, such as Google Cloud Storage. Recent updates to
        /// documents may not be reflected in the export. The export occurs in the
        /// background and its progress can be monitored and managed via the
        /// Operation resource that is created. The output of an export may only be
        /// used once the associated operation is done. If an export operation is
        /// cancelled before completion it may leave partial data behind in Google
        /// Cloud Storage.
        /// 
        /// For more details on export behavior and output format, refer to:
        /// https://cloud.google.com/firestore/docs/manage-data/export-import
        /// </summary>
        /// <param name="name">
        /// Required. Database to export. Should be of the form:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportDocumentsResponse, ExportDocumentsMetadata>> ExportDocumentsAsync(DatabaseName name, gaxgrpc::CallSettings callSettings = null) =>
            ExportDocumentsAsync(new ExportDocumentsRequest
            {
                DatabaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Exports a copy of all or a subset of documents from Google Cloud Firestore
        /// to another storage system, such as Google Cloud Storage. Recent updates to
        /// documents may not be reflected in the export. The export occurs in the
        /// background and its progress can be monitored and managed via the
        /// Operation resource that is created. The output of an export may only be
        /// used once the associated operation is done. If an export operation is
        /// cancelled before completion it may leave partial data behind in Google
        /// Cloud Storage.
        /// 
        /// For more details on export behavior and output format, refer to:
        /// https://cloud.google.com/firestore/docs/manage-data/export-import
        /// </summary>
        /// <param name="name">
        /// Required. Database to export. Should be of the form:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportDocumentsResponse, ExportDocumentsMetadata>> ExportDocumentsAsync(DatabaseName name, st::CancellationToken cancellationToken) =>
            ExportDocumentsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports documents into Google Cloud Firestore. Existing documents with the
        /// same name are overwritten. The import occurs in the background and its
        /// progress can be monitored and managed via the Operation resource that is
        /// created. If an ImportDocuments operation is cancelled, it is possible
        /// that a subset of the data has already been imported to Cloud Firestore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, ImportDocumentsMetadata> ImportDocuments(ImportDocumentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports documents into Google Cloud Firestore. Existing documents with the
        /// same name are overwritten. The import occurs in the background and its
        /// progress can be monitored and managed via the Operation resource that is
        /// created. If an ImportDocuments operation is cancelled, it is possible
        /// that a subset of the data has already been imported to Cloud Firestore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, ImportDocumentsMetadata>> ImportDocumentsAsync(ImportDocumentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports documents into Google Cloud Firestore. Existing documents with the
        /// same name are overwritten. The import occurs in the background and its
        /// progress can be monitored and managed via the Operation resource that is
        /// created. If an ImportDocuments operation is cancelled, it is possible
        /// that a subset of the data has already been imported to Cloud Firestore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, ImportDocumentsMetadata>> ImportDocumentsAsync(ImportDocumentsRequest request, st::CancellationToken cancellationToken) =>
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
        public virtual lro::Operation<wkt::Empty, ImportDocumentsMetadata> PollOnceImportDocuments(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, ImportDocumentsMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportDocumentsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportDocuments</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, ImportDocumentsMetadata>> PollOnceImportDocumentsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, ImportDocumentsMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportDocumentsOperationsClient, callSettings);

        /// <summary>
        /// Imports documents into Google Cloud Firestore. Existing documents with the
        /// same name are overwritten. The import occurs in the background and its
        /// progress can be monitored and managed via the Operation resource that is
        /// created. If an ImportDocuments operation is cancelled, it is possible
        /// that a subset of the data has already been imported to Cloud Firestore.
        /// </summary>
        /// <param name="name">
        /// Required. Database to import into. Should be of the form:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, ImportDocumentsMetadata> ImportDocuments(string name, gaxgrpc::CallSettings callSettings = null) =>
            ImportDocuments(new ImportDocumentsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Imports documents into Google Cloud Firestore. Existing documents with the
        /// same name are overwritten. The import occurs in the background and its
        /// progress can be monitored and managed via the Operation resource that is
        /// created. If an ImportDocuments operation is cancelled, it is possible
        /// that a subset of the data has already been imported to Cloud Firestore.
        /// </summary>
        /// <param name="name">
        /// Required. Database to import into. Should be of the form:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, ImportDocumentsMetadata>> ImportDocumentsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ImportDocumentsAsync(new ImportDocumentsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Imports documents into Google Cloud Firestore. Existing documents with the
        /// same name are overwritten. The import occurs in the background and its
        /// progress can be monitored and managed via the Operation resource that is
        /// created. If an ImportDocuments operation is cancelled, it is possible
        /// that a subset of the data has already been imported to Cloud Firestore.
        /// </summary>
        /// <param name="name">
        /// Required. Database to import into. Should be of the form:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, ImportDocumentsMetadata>> ImportDocumentsAsync(string name, st::CancellationToken cancellationToken) =>
            ImportDocumentsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports documents into Google Cloud Firestore. Existing documents with the
        /// same name are overwritten. The import occurs in the background and its
        /// progress can be monitored and managed via the Operation resource that is
        /// created. If an ImportDocuments operation is cancelled, it is possible
        /// that a subset of the data has already been imported to Cloud Firestore.
        /// </summary>
        /// <param name="name">
        /// Required. Database to import into. Should be of the form:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, ImportDocumentsMetadata> ImportDocuments(DatabaseName name, gaxgrpc::CallSettings callSettings = null) =>
            ImportDocuments(new ImportDocumentsRequest
            {
                DatabaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Imports documents into Google Cloud Firestore. Existing documents with the
        /// same name are overwritten. The import occurs in the background and its
        /// progress can be monitored and managed via the Operation resource that is
        /// created. If an ImportDocuments operation is cancelled, it is possible
        /// that a subset of the data has already been imported to Cloud Firestore.
        /// </summary>
        /// <param name="name">
        /// Required. Database to import into. Should be of the form:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, ImportDocumentsMetadata>> ImportDocumentsAsync(DatabaseName name, gaxgrpc::CallSettings callSettings = null) =>
            ImportDocumentsAsync(new ImportDocumentsRequest
            {
                DatabaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Imports documents into Google Cloud Firestore. Existing documents with the
        /// same name are overwritten. The import occurs in the background and its
        /// progress can be monitored and managed via the Operation resource that is
        /// created. If an ImportDocuments operation is cancelled, it is possible
        /// that a subset of the data has already been imported to Cloud Firestore.
        /// </summary>
        /// <param name="name">
        /// Required. Database to import into. Should be of the form:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, ImportDocumentsMetadata>> ImportDocumentsAsync(DatabaseName name, st::CancellationToken cancellationToken) =>
            ImportDocumentsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Database GetDatabase(GetDatabaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Database> GetDatabaseAsync(GetDatabaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Database> GetDatabaseAsync(GetDatabaseRequest request, st::CancellationToken cancellationToken) =>
            GetDatabaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a database.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Database GetDatabase(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDatabase(new GetDatabaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a database.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Database> GetDatabaseAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDatabaseAsync(new GetDatabaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a database.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Database> GetDatabaseAsync(string name, st::CancellationToken cancellationToken) =>
            GetDatabaseAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a database.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Database GetDatabase(DatabaseName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDatabase(new GetDatabaseRequest
            {
                DatabaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a database.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Database> GetDatabaseAsync(DatabaseName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDatabaseAsync(new GetDatabaseRequest
            {
                DatabaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about a database.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Database> GetDatabaseAsync(DatabaseName name, st::CancellationToken cancellationToken) =>
            GetDatabaseAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List all the databases in the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListDatabasesResponse ListDatabases(ListDatabasesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all the databases in the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListDatabasesResponse> ListDatabasesAsync(ListDatabasesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all the databases in the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListDatabasesResponse> ListDatabasesAsync(ListDatabasesRequest request, st::CancellationToken cancellationToken) =>
            ListDatabasesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List all the databases in the project.
        /// </summary>
        /// <param name="parent">
        /// Required. A parent name of the form
        /// `projects/{project_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListDatabasesResponse ListDatabases(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ListDatabases(new ListDatabasesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// List all the databases in the project.
        /// </summary>
        /// <param name="parent">
        /// Required. A parent name of the form
        /// `projects/{project_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListDatabasesResponse> ListDatabasesAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ListDatabasesAsync(new ListDatabasesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// List all the databases in the project.
        /// </summary>
        /// <param name="parent">
        /// Required. A parent name of the form
        /// `projects/{project_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListDatabasesResponse> ListDatabasesAsync(string parent, st::CancellationToken cancellationToken) =>
            ListDatabasesAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List all the databases in the project.
        /// </summary>
        /// <param name="parent">
        /// Required. A parent name of the form
        /// `projects/{project_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListDatabasesResponse ListDatabases(gagr::ProjectName parent, gaxgrpc::CallSettings callSettings = null) =>
            ListDatabases(new ListDatabasesRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// List all the databases in the project.
        /// </summary>
        /// <param name="parent">
        /// Required. A parent name of the form
        /// `projects/{project_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListDatabasesResponse> ListDatabasesAsync(gagr::ProjectName parent, gaxgrpc::CallSettings callSettings = null) =>
            ListDatabasesAsync(new ListDatabasesRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// List all the databases in the project.
        /// </summary>
        /// <param name="parent">
        /// Required. A parent name of the form
        /// `projects/{project_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListDatabasesResponse> ListDatabasesAsync(gagr::ProjectName parent, st::CancellationToken cancellationToken) =>
            ListDatabasesAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Database, UpdateDatabaseMetadata> UpdateDatabase(UpdateDatabaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Database, UpdateDatabaseMetadata>> UpdateDatabaseAsync(UpdateDatabaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Database, UpdateDatabaseMetadata>> UpdateDatabaseAsync(UpdateDatabaseRequest request, st::CancellationToken cancellationToken) =>
            UpdateDatabaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateDatabase</c>.</summary>
        public virtual lro::OperationsClient UpdateDatabaseOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateDatabase</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Database, UpdateDatabaseMetadata> PollOnceUpdateDatabase(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Database, UpdateDatabaseMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDatabaseOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateDatabase</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Database, UpdateDatabaseMetadata>> PollOnceUpdateDatabaseAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Database, UpdateDatabaseMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDatabaseOperationsClient, callSettings);

        /// <summary>
        /// Updates a database.
        /// </summary>
        /// <param name="database">
        /// Required. The database to update.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Database, UpdateDatabaseMetadata> UpdateDatabase(Database database, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDatabase(new UpdateDatabaseRequest
            {
                Database = gax::GaxPreconditions.CheckNotNull(database, nameof(database)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a database.
        /// </summary>
        /// <param name="database">
        /// Required. The database to update.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Database, UpdateDatabaseMetadata>> UpdateDatabaseAsync(Database database, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDatabaseAsync(new UpdateDatabaseRequest
            {
                Database = gax::GaxPreconditions.CheckNotNull(database, nameof(database)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a database.
        /// </summary>
        /// <param name="database">
        /// Required. The database to update.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Database, UpdateDatabaseMetadata>> UpdateDatabaseAsync(Database database, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDatabaseAsync(database, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>FirestoreAdmin client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The Cloud Firestore Admin API.
    /// 
    /// This API provides several administrative services for Cloud Firestore.
    /// 
    /// Project, Database, Namespace, Collection, Collection Group, and Document are
    /// used as defined in the Google Cloud Firestore API.
    /// 
    /// Operation: An Operation represents work being performed in the background.
    /// 
    /// The index service manages Cloud Firestore indexes.
    /// 
    /// Index creation is performed asynchronously.
    /// An Operation resource is created for each such asynchronous operation.
    /// The state of the operation (including any errors encountered)
    /// may be queried via the Operation resource.
    /// 
    /// The Operations collection provides a record of actions performed for the
    /// specified Project (including any Operations in progress). Operations are not
    /// created directly but through calls on other collections or resources.
    /// 
    /// An Operation that is done may be deleted so that it is no longer listed as
    /// part of the Operation collection. Operations are garbage collected after
    /// 30 days. By default, ListOperations will only return in progress and failed
    /// operations. To list completed operation, issue a ListOperations request with
    /// the filter `done: true`.
    /// 
    /// Operations are created by service `FirestoreAdmin`, but are accessed via
    /// service `google.longrunning.Operations`.
    /// </remarks>
    public sealed partial class FirestoreAdminClientImpl : FirestoreAdminClient
    {
        private readonly gaxgrpc::ApiCall<CreateIndexRequest, lro::Operation> _callCreateIndex;

        private readonly gaxgrpc::ApiCall<ListIndexesRequest, ListIndexesResponse> _callListIndexes;

        private readonly gaxgrpc::ApiCall<GetIndexRequest, Index> _callGetIndex;

        private readonly gaxgrpc::ApiCall<DeleteIndexRequest, wkt::Empty> _callDeleteIndex;

        private readonly gaxgrpc::ApiCall<GetFieldRequest, Field> _callGetField;

        private readonly gaxgrpc::ApiCall<UpdateFieldRequest, lro::Operation> _callUpdateField;

        private readonly gaxgrpc::ApiCall<ListFieldsRequest, ListFieldsResponse> _callListFields;

        private readonly gaxgrpc::ApiCall<ExportDocumentsRequest, lro::Operation> _callExportDocuments;

        private readonly gaxgrpc::ApiCall<ImportDocumentsRequest, lro::Operation> _callImportDocuments;

        private readonly gaxgrpc::ApiCall<GetDatabaseRequest, Database> _callGetDatabase;

        private readonly gaxgrpc::ApiCall<ListDatabasesRequest, ListDatabasesResponse> _callListDatabases;

        private readonly gaxgrpc::ApiCall<UpdateDatabaseRequest, lro::Operation> _callUpdateDatabase;

        /// <summary>
        /// Constructs a client wrapper for the FirestoreAdmin service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="FirestoreAdminSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public FirestoreAdminClientImpl(FirestoreAdmin.FirestoreAdminClient grpcClient, FirestoreAdminSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            FirestoreAdminSettings effectiveSettings = settings ?? FirestoreAdminSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            CreateIndexOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateIndexOperationsSettings, logger);
            UpdateFieldOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateFieldOperationsSettings, logger);
            ExportDocumentsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportDocumentsOperationsSettings, logger);
            ImportDocumentsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ImportDocumentsOperationsSettings, logger);
            UpdateDatabaseOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateDatabaseOperationsSettings, logger);
            _callCreateIndex = clientHelper.BuildApiCall<CreateIndexRequest, lro::Operation>("CreateIndex", grpcClient.CreateIndexAsync, grpcClient.CreateIndex, effectiveSettings.CreateIndexSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateIndex);
            Modify_CreateIndexApiCall(ref _callCreateIndex);
            _callListIndexes = clientHelper.BuildApiCall<ListIndexesRequest, ListIndexesResponse>("ListIndexes", grpcClient.ListIndexesAsync, grpcClient.ListIndexes, effectiveSettings.ListIndexesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListIndexes);
            Modify_ListIndexesApiCall(ref _callListIndexes);
            _callGetIndex = clientHelper.BuildApiCall<GetIndexRequest, Index>("GetIndex", grpcClient.GetIndexAsync, grpcClient.GetIndex, effectiveSettings.GetIndexSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetIndex);
            Modify_GetIndexApiCall(ref _callGetIndex);
            _callDeleteIndex = clientHelper.BuildApiCall<DeleteIndexRequest, wkt::Empty>("DeleteIndex", grpcClient.DeleteIndexAsync, grpcClient.DeleteIndex, effectiveSettings.DeleteIndexSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteIndex);
            Modify_DeleteIndexApiCall(ref _callDeleteIndex);
            _callGetField = clientHelper.BuildApiCall<GetFieldRequest, Field>("GetField", grpcClient.GetFieldAsync, grpcClient.GetField, effectiveSettings.GetFieldSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetField);
            Modify_GetFieldApiCall(ref _callGetField);
            _callUpdateField = clientHelper.BuildApiCall<UpdateFieldRequest, lro::Operation>("UpdateField", grpcClient.UpdateFieldAsync, grpcClient.UpdateField, effectiveSettings.UpdateFieldSettings).WithGoogleRequestParam("field.name", request => request.Field?.Name);
            Modify_ApiCall(ref _callUpdateField);
            Modify_UpdateFieldApiCall(ref _callUpdateField);
            _callListFields = clientHelper.BuildApiCall<ListFieldsRequest, ListFieldsResponse>("ListFields", grpcClient.ListFieldsAsync, grpcClient.ListFields, effectiveSettings.ListFieldsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListFields);
            Modify_ListFieldsApiCall(ref _callListFields);
            _callExportDocuments = clientHelper.BuildApiCall<ExportDocumentsRequest, lro::Operation>("ExportDocuments", grpcClient.ExportDocumentsAsync, grpcClient.ExportDocuments, effectiveSettings.ExportDocumentsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callExportDocuments);
            Modify_ExportDocumentsApiCall(ref _callExportDocuments);
            _callImportDocuments = clientHelper.BuildApiCall<ImportDocumentsRequest, lro::Operation>("ImportDocuments", grpcClient.ImportDocumentsAsync, grpcClient.ImportDocuments, effectiveSettings.ImportDocumentsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callImportDocuments);
            Modify_ImportDocumentsApiCall(ref _callImportDocuments);
            _callGetDatabase = clientHelper.BuildApiCall<GetDatabaseRequest, Database>("GetDatabase", grpcClient.GetDatabaseAsync, grpcClient.GetDatabase, effectiveSettings.GetDatabaseSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDatabase);
            Modify_GetDatabaseApiCall(ref _callGetDatabase);
            _callListDatabases = clientHelper.BuildApiCall<ListDatabasesRequest, ListDatabasesResponse>("ListDatabases", grpcClient.ListDatabasesAsync, grpcClient.ListDatabases, effectiveSettings.ListDatabasesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDatabases);
            Modify_ListDatabasesApiCall(ref _callListDatabases);
            _callUpdateDatabase = clientHelper.BuildApiCall<UpdateDatabaseRequest, lro::Operation>("UpdateDatabase", grpcClient.UpdateDatabaseAsync, grpcClient.UpdateDatabase, effectiveSettings.UpdateDatabaseSettings).WithGoogleRequestParam("database.name", request => request.Database?.Name);
            Modify_ApiCall(ref _callUpdateDatabase);
            Modify_UpdateDatabaseApiCall(ref _callUpdateDatabase);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateIndexApiCall(ref gaxgrpc::ApiCall<CreateIndexRequest, lro::Operation> call);

        partial void Modify_ListIndexesApiCall(ref gaxgrpc::ApiCall<ListIndexesRequest, ListIndexesResponse> call);

        partial void Modify_GetIndexApiCall(ref gaxgrpc::ApiCall<GetIndexRequest, Index> call);

        partial void Modify_DeleteIndexApiCall(ref gaxgrpc::ApiCall<DeleteIndexRequest, wkt::Empty> call);

        partial void Modify_GetFieldApiCall(ref gaxgrpc::ApiCall<GetFieldRequest, Field> call);

        partial void Modify_UpdateFieldApiCall(ref gaxgrpc::ApiCall<UpdateFieldRequest, lro::Operation> call);

        partial void Modify_ListFieldsApiCall(ref gaxgrpc::ApiCall<ListFieldsRequest, ListFieldsResponse> call);

        partial void Modify_ExportDocumentsApiCall(ref gaxgrpc::ApiCall<ExportDocumentsRequest, lro::Operation> call);

        partial void Modify_ImportDocumentsApiCall(ref gaxgrpc::ApiCall<ImportDocumentsRequest, lro::Operation> call);

        partial void Modify_GetDatabaseApiCall(ref gaxgrpc::ApiCall<GetDatabaseRequest, Database> call);

        partial void Modify_ListDatabasesApiCall(ref gaxgrpc::ApiCall<ListDatabasesRequest, ListDatabasesResponse> call);

        partial void Modify_UpdateDatabaseApiCall(ref gaxgrpc::ApiCall<UpdateDatabaseRequest, lro::Operation> call);

        partial void OnConstruction(FirestoreAdmin.FirestoreAdminClient grpcClient, FirestoreAdminSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC FirestoreAdmin client</summary>
        public override FirestoreAdmin.FirestoreAdminClient GrpcClient { get; }

        partial void Modify_CreateIndexRequest(ref CreateIndexRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListIndexesRequest(ref ListIndexesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIndexRequest(ref GetIndexRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteIndexRequest(ref DeleteIndexRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetFieldRequest(ref GetFieldRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateFieldRequest(ref UpdateFieldRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListFieldsRequest(ref ListFieldsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportDocumentsRequest(ref ExportDocumentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportDocumentsRequest(ref ImportDocumentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDatabaseRequest(ref GetDatabaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDatabasesRequest(ref ListDatabasesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDatabaseRequest(ref UpdateDatabaseRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateIndex</c>.</summary>
        public override lro::OperationsClient CreateIndexOperationsClient { get; }

        /// <summary>
        /// Creates a composite index. This returns a [google.longrunning.Operation][google.longrunning.Operation]
        /// which may be used to track the status of the creation. The metadata for
        /// the operation will be the type [IndexOperationMetadata][google.firestore.admin.v1.IndexOperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Index, IndexOperationMetadata> CreateIndex(CreateIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateIndexRequest(ref request, ref callSettings);
            return new lro::Operation<Index, IndexOperationMetadata>(_callCreateIndex.Sync(request, callSettings), CreateIndexOperationsClient);
        }

        /// <summary>
        /// Creates a composite index. This returns a [google.longrunning.Operation][google.longrunning.Operation]
        /// which may be used to track the status of the creation. The metadata for
        /// the operation will be the type [IndexOperationMetadata][google.firestore.admin.v1.IndexOperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Index, IndexOperationMetadata>> CreateIndexAsync(CreateIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateIndexRequest(ref request, ref callSettings);
            return new lro::Operation<Index, IndexOperationMetadata>(await _callCreateIndex.Async(request, callSettings).ConfigureAwait(false), CreateIndexOperationsClient);
        }

        /// <summary>
        /// Lists composite indexes.
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
        /// Lists composite indexes.
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
        /// Gets a composite index.
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
        /// Gets a composite index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Index> GetIndexAsync(GetIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIndexRequest(ref request, ref callSettings);
            return _callGetIndex.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a composite index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteIndex(DeleteIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteIndexRequest(ref request, ref callSettings);
            _callDeleteIndex.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a composite index.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteIndexAsync(DeleteIndexRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteIndexRequest(ref request, ref callSettings);
            return _callDeleteIndex.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the metadata and configuration for a Field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Field GetField(GetFieldRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFieldRequest(ref request, ref callSettings);
            return _callGetField.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the metadata and configuration for a Field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Field> GetFieldAsync(GetFieldRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFieldRequest(ref request, ref callSettings);
            return _callGetField.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateField</c>.</summary>
        public override lro::OperationsClient UpdateFieldOperationsClient { get; }

        /// <summary>
        /// Updates a field configuration. Currently, field updates apply only to
        /// single field index configuration. However, calls to
        /// [FirestoreAdmin.UpdateField][google.firestore.admin.v1.FirestoreAdmin.UpdateField] should provide a field mask to avoid
        /// changing any configuration that the caller isn't aware of. The field mask
        /// should be specified as: `{ paths: "index_config" }`.
        /// 
        /// This call returns a [google.longrunning.Operation][google.longrunning.Operation] which may be used to
        /// track the status of the field update. The metadata for
        /// the operation will be the type [FieldOperationMetadata][google.firestore.admin.v1.FieldOperationMetadata].
        /// 
        /// To configure the default field settings for the database, use
        /// the special `Field` with resource name:
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/__default__/fields/*`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Field, FieldOperationMetadata> UpdateField(UpdateFieldRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFieldRequest(ref request, ref callSettings);
            return new lro::Operation<Field, FieldOperationMetadata>(_callUpdateField.Sync(request, callSettings), UpdateFieldOperationsClient);
        }

        /// <summary>
        /// Updates a field configuration. Currently, field updates apply only to
        /// single field index configuration. However, calls to
        /// [FirestoreAdmin.UpdateField][google.firestore.admin.v1.FirestoreAdmin.UpdateField] should provide a field mask to avoid
        /// changing any configuration that the caller isn't aware of. The field mask
        /// should be specified as: `{ paths: "index_config" }`.
        /// 
        /// This call returns a [google.longrunning.Operation][google.longrunning.Operation] which may be used to
        /// track the status of the field update. The metadata for
        /// the operation will be the type [FieldOperationMetadata][google.firestore.admin.v1.FieldOperationMetadata].
        /// 
        /// To configure the default field settings for the database, use
        /// the special `Field` with resource name:
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/__default__/fields/*`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Field, FieldOperationMetadata>> UpdateFieldAsync(UpdateFieldRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFieldRequest(ref request, ref callSettings);
            return new lro::Operation<Field, FieldOperationMetadata>(await _callUpdateField.Async(request, callSettings).ConfigureAwait(false), UpdateFieldOperationsClient);
        }

        /// <summary>
        /// Lists the field configuration and metadata for this database.
        /// 
        /// Currently, [FirestoreAdmin.ListFields][google.firestore.admin.v1.FirestoreAdmin.ListFields] only supports listing fields
        /// that have been explicitly overridden. To issue this query, call
        /// [FirestoreAdmin.ListFields][google.firestore.admin.v1.FirestoreAdmin.ListFields] with the filter set to
        /// `indexConfig.usesAncestorConfig:false` .
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Field"/> resources.</returns>
        public override gax::PagedEnumerable<ListFieldsResponse, Field> ListFields(ListFieldsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFieldsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListFieldsRequest, ListFieldsResponse, Field>(_callListFields, request, callSettings);
        }

        /// <summary>
        /// Lists the field configuration and metadata for this database.
        /// 
        /// Currently, [FirestoreAdmin.ListFields][google.firestore.admin.v1.FirestoreAdmin.ListFields] only supports listing fields
        /// that have been explicitly overridden. To issue this query, call
        /// [FirestoreAdmin.ListFields][google.firestore.admin.v1.FirestoreAdmin.ListFields] with the filter set to
        /// `indexConfig.usesAncestorConfig:false` .
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Field"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListFieldsResponse, Field> ListFieldsAsync(ListFieldsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFieldsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListFieldsRequest, ListFieldsResponse, Field>(_callListFields, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>ExportDocuments</c>.</summary>
        public override lro::OperationsClient ExportDocumentsOperationsClient { get; }

        /// <summary>
        /// Exports a copy of all or a subset of documents from Google Cloud Firestore
        /// to another storage system, such as Google Cloud Storage. Recent updates to
        /// documents may not be reflected in the export. The export occurs in the
        /// background and its progress can be monitored and managed via the
        /// Operation resource that is created. The output of an export may only be
        /// used once the associated operation is done. If an export operation is
        /// cancelled before completion it may leave partial data behind in Google
        /// Cloud Storage.
        /// 
        /// For more details on export behavior and output format, refer to:
        /// https://cloud.google.com/firestore/docs/manage-data/export-import
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ExportDocumentsResponse, ExportDocumentsMetadata> ExportDocuments(ExportDocumentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportDocumentsRequest(ref request, ref callSettings);
            return new lro::Operation<ExportDocumentsResponse, ExportDocumentsMetadata>(_callExportDocuments.Sync(request, callSettings), ExportDocumentsOperationsClient);
        }

        /// <summary>
        /// Exports a copy of all or a subset of documents from Google Cloud Firestore
        /// to another storage system, such as Google Cloud Storage. Recent updates to
        /// documents may not be reflected in the export. The export occurs in the
        /// background and its progress can be monitored and managed via the
        /// Operation resource that is created. The output of an export may only be
        /// used once the associated operation is done. If an export operation is
        /// cancelled before completion it may leave partial data behind in Google
        /// Cloud Storage.
        /// 
        /// For more details on export behavior and output format, refer to:
        /// https://cloud.google.com/firestore/docs/manage-data/export-import
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExportDocumentsResponse, ExportDocumentsMetadata>> ExportDocumentsAsync(ExportDocumentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportDocumentsRequest(ref request, ref callSettings);
            return new lro::Operation<ExportDocumentsResponse, ExportDocumentsMetadata>(await _callExportDocuments.Async(request, callSettings).ConfigureAwait(false), ExportDocumentsOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ImportDocuments</c>.</summary>
        public override lro::OperationsClient ImportDocumentsOperationsClient { get; }

        /// <summary>
        /// Imports documents into Google Cloud Firestore. Existing documents with the
        /// same name are overwritten. The import occurs in the background and its
        /// progress can be monitored and managed via the Operation resource that is
        /// created. If an ImportDocuments operation is cancelled, it is possible
        /// that a subset of the data has already been imported to Cloud Firestore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, ImportDocumentsMetadata> ImportDocuments(ImportDocumentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportDocumentsRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, ImportDocumentsMetadata>(_callImportDocuments.Sync(request, callSettings), ImportDocumentsOperationsClient);
        }

        /// <summary>
        /// Imports documents into Google Cloud Firestore. Existing documents with the
        /// same name are overwritten. The import occurs in the background and its
        /// progress can be monitored and managed via the Operation resource that is
        /// created. If an ImportDocuments operation is cancelled, it is possible
        /// that a subset of the data has already been imported to Cloud Firestore.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, ImportDocumentsMetadata>> ImportDocumentsAsync(ImportDocumentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportDocumentsRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, ImportDocumentsMetadata>(await _callImportDocuments.Async(request, callSettings).ConfigureAwait(false), ImportDocumentsOperationsClient);
        }

        /// <summary>
        /// Gets information about a database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Database GetDatabase(GetDatabaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDatabaseRequest(ref request, ref callSettings);
            return _callGetDatabase.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets information about a database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Database> GetDatabaseAsync(GetDatabaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDatabaseRequest(ref request, ref callSettings);
            return _callGetDatabase.Async(request, callSettings);
        }

        /// <summary>
        /// List all the databases in the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListDatabasesResponse ListDatabases(ListDatabasesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDatabasesRequest(ref request, ref callSettings);
            return _callListDatabases.Sync(request, callSettings);
        }

        /// <summary>
        /// List all the databases in the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListDatabasesResponse> ListDatabasesAsync(ListDatabasesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDatabasesRequest(ref request, ref callSettings);
            return _callListDatabases.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateDatabase</c>.</summary>
        public override lro::OperationsClient UpdateDatabaseOperationsClient { get; }

        /// <summary>
        /// Updates a database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Database, UpdateDatabaseMetadata> UpdateDatabase(UpdateDatabaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDatabaseRequest(ref request, ref callSettings);
            return new lro::Operation<Database, UpdateDatabaseMetadata>(_callUpdateDatabase.Sync(request, callSettings), UpdateDatabaseOperationsClient);
        }

        /// <summary>
        /// Updates a database.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Database, UpdateDatabaseMetadata>> UpdateDatabaseAsync(UpdateDatabaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDatabaseRequest(ref request, ref callSettings);
            return new lro::Operation<Database, UpdateDatabaseMetadata>(await _callUpdateDatabase.Async(request, callSettings).ConfigureAwait(false), UpdateDatabaseOperationsClient);
        }
    }

    public partial class ListIndexesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListFieldsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListIndexesResponse : gaxgrpc::IPageResponse<Index>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Index> GetEnumerator() => Indexes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListFieldsResponse : gaxgrpc::IPageResponse<Field>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Field> GetEnumerator() => Fields.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class FirestoreAdmin
    {
        public partial class FirestoreAdminClient
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
}
