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
using gcfv = Google.Cloud.Firestore.V1;
using gcl = Google.Cloud.Location;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using linq = System.Linq;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Firestore.V1
{
    /// <summary>Settings for <see cref="FirestoreClient"/> instances.</summary>
    public sealed partial class FirestoreSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="FirestoreSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="FirestoreSettings"/>.</returns>
        public static FirestoreSettings GetDefault() => new FirestoreSettings();

        /// <summary>Constructs a new <see cref="FirestoreSettings"/> object with default settings.</summary>
        public FirestoreSettings()
        {
        }

        private FirestoreSettings(FirestoreSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetDocumentSettings = existing.GetDocumentSettings;
            ListDocumentsSettings = existing.ListDocumentsSettings;
            UpdateDocumentSettings = existing.UpdateDocumentSettings;
            DeleteDocumentSettings = existing.DeleteDocumentSettings;
            BatchGetDocumentsSettings = existing.BatchGetDocumentsSettings;
            BeginTransactionSettings = existing.BeginTransactionSettings;
            CommitSettings = existing.CommitSettings;
            RollbackSettings = existing.RollbackSettings;
            RunQuerySettings = existing.RunQuerySettings;
            RunAggregationQuerySettings = existing.RunAggregationQuerySettings;
            PartitionQuerySettings = existing.PartitionQuerySettings;
            WriteSettings = existing.WriteSettings;
            WriteStreamingSettings = existing.WriteStreamingSettings;
            ListenSettings = existing.ListenSettings;
            ListenStreamingSettings = existing.ListenStreamingSettings;
            ListCollectionIdsSettings = existing.ListCollectionIdsSettings;
            BatchWriteSettings = existing.BatchWriteSettings;
            CreateDocumentSettings = existing.CreateDocumentSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(FirestoreSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>FirestoreClient.GetDocument</c>
        ///  and <c>FirestoreClient.GetDocumentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.Internal"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDocumentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Internal, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreClient.ListDocuments</c> and <c>FirestoreClient.ListDocumentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.Internal"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDocumentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Internal, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreClient.UpdateDocument</c> and <c>FirestoreClient.UpdateDocumentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDocumentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreClient.DeleteDocument</c> and <c>FirestoreClient.DeleteDocumentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.Internal"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDocumentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Internal, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreClient.BatchGetDocuments</c> and <c>FirestoreClient.BatchGetDocumentsAsync</c>.
        /// </summary>
        /// <remarks>Timeout: 300 seconds.</remarks>
        public gaxgrpc::CallSettings BatchGetDocumentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreClient.BeginTransaction</c> and <c>FirestoreClient.BeginTransactionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.Internal"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BeginTransactionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Internal, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>FirestoreClient.Commit</c>
        /// and <c>FirestoreClient.CommitAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CommitSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>FirestoreClient.Rollback</c>
        ///  and <c>FirestoreClient.RollbackAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.Internal"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RollbackSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Internal, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>FirestoreClient.RunQuery</c>
        ///  and <c>FirestoreClient.RunQueryAsync</c>.
        /// </summary>
        /// <remarks>Timeout: 300 seconds.</remarks>
        public gaxgrpc::CallSettings RunQuerySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreClient.RunAggregationQuery</c> and <c>FirestoreClient.RunAggregationQueryAsync</c>.
        /// </summary>
        /// <remarks>Timeout: 300 seconds.</remarks>
        public gaxgrpc::CallSettings RunAggregationQuerySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreClient.PartitionQuery</c> and <c>FirestoreClient.PartitionQueryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.Internal"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PartitionQuerySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Internal, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>FirestoreClient.Write</c>
        /// and <c>FirestoreClient.WriteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 86400 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings WriteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(86400000)));

        /// <summary>
        /// <see cref="gaxgrpc::BidirectionalStreamingSettings"/> for calls to <c>FirestoreClient.Write</c> and
        /// <c>FirestoreClient.WriteAsync</c>.
        /// </summary>
        /// <remarks>The default local send queue size is 100.</remarks>
        public gaxgrpc::BidirectionalStreamingSettings WriteStreamingSettings { get; set; } = new gaxgrpc::BidirectionalStreamingSettings(100);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>FirestoreClient.Listen</c>
        /// and <c>FirestoreClient.ListenAsync</c>.
        /// </summary>
        /// <remarks>Timeout: 86400 seconds.</remarks>
        public gaxgrpc::CallSettings ListenSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(86400000)));

        /// <summary>
        /// <see cref="gaxgrpc::BidirectionalStreamingSettings"/> for calls to <c>FirestoreClient.Listen</c> and
        /// <c>FirestoreClient.ListenAsync</c>.
        /// </summary>
        /// <remarks>The default local send queue size is 100.</remarks>
        public gaxgrpc::BidirectionalStreamingSettings ListenStreamingSettings { get; set; } = new gaxgrpc::BidirectionalStreamingSettings(100);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreClient.ListCollectionIds</c> and <c>FirestoreClient.ListCollectionIdsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.Internal"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCollectionIdsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Internal, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>FirestoreClient.BatchWrite</c>
        ///  and <c>FirestoreClient.BatchWriteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.Aborted"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchWriteSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Aborted)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreClient.CreateDocument</c> and <c>FirestoreClient.CreateDocumentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.ResourceExhausted"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDocumentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.ResourceExhausted, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="FirestoreSettings"/> object.</returns>
        public FirestoreSettings Clone() => new FirestoreSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="FirestoreClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class FirestoreClientBuilder : gaxgrpc::ClientBuilderBase<FirestoreClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public FirestoreSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public FirestoreClientBuilder() : base(FirestoreClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref FirestoreClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<FirestoreClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override FirestoreClient Build()
        {
            FirestoreClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<FirestoreClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<FirestoreClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private FirestoreClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return FirestoreClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<FirestoreClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return FirestoreClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => FirestoreClient.ChannelPool;
    }

    /// <summary>Firestore client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The Cloud Firestore service.
    /// 
    /// Cloud Firestore is a fast, fully managed, serverless, cloud-native NoSQL
    /// document database that simplifies storing, syncing, and querying data for
    /// your mobile, web, and IoT apps at global scale. Its client libraries provide
    /// live synchronization and offline support, while its security features and
    /// integrations with Firebase and Google Cloud Platform accelerate building
    /// truly serverless apps.
    /// </remarks>
    public abstract partial class FirestoreClient
    {
        /// <summary>
        /// The default endpoint for the Firestore service, which is a host of "firestore.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "firestore.googleapis.com:443";

        /// <summary>The default Firestore scopes.</summary>
        /// <remarks>
        /// The default Firestore scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Firestore.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="FirestoreClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="FirestoreClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="FirestoreClient"/>.</returns>
        public static stt::Task<FirestoreClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new FirestoreClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="FirestoreClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="FirestoreClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="FirestoreClient"/>.</returns>
        public static FirestoreClient Create() => new FirestoreClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="FirestoreClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="FirestoreSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="FirestoreClient"/>.</returns>
        internal static FirestoreClient Create(grpccore::CallInvoker callInvoker, FirestoreSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Firestore.FirestoreClient grpcClient = new Firestore.FirestoreClient(callInvoker);
            return new FirestoreClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Firestore client</summary>
        public virtual Firestore.FirestoreClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a single document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Document GetDocument(GetDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a single document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Document> GetDocumentAsync(GetDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a single document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Document> GetDocumentAsync(GetDocumentRequest request, st::CancellationToken cancellationToken) =>
            GetDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists documents.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Document"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDocumentsResponse, Document> ListDocuments(ListDocumentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists documents.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Document"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDocumentsResponse, Document> ListDocumentsAsync(ListDocumentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates or inserts a document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Document UpdateDocument(UpdateDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates or inserts a document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Document> UpdateDocumentAsync(UpdateDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates or inserts a document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Document> UpdateDocumentAsync(UpdateDocumentRequest request, st::CancellationToken cancellationToken) =>
            UpdateDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates or inserts a document.
        /// </summary>
        /// <param name="document">
        /// Required. The updated document.
        /// Creates the document if it does not already exist.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// None of the field paths in the mask may contain a reserved name.
        /// 
        /// If the document exists on the server and has fields not referenced in the
        /// mask, they are left unchanged.
        /// Fields referenced in the mask, but not present in the input document, are
        /// deleted from the document on the server.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Document UpdateDocument(Document document, DocumentMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDocument(new UpdateDocumentRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates or inserts a document.
        /// </summary>
        /// <param name="document">
        /// Required. The updated document.
        /// Creates the document if it does not already exist.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// None of the field paths in the mask may contain a reserved name.
        /// 
        /// If the document exists on the server and has fields not referenced in the
        /// mask, they are left unchanged.
        /// Fields referenced in the mask, but not present in the input document, are
        /// deleted from the document on the server.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Document> UpdateDocumentAsync(Document document, DocumentMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDocumentAsync(new UpdateDocumentRequest
            {
                Document = gax::GaxPreconditions.CheckNotNull(document, nameof(document)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates or inserts a document.
        /// </summary>
        /// <param name="document">
        /// Required. The updated document.
        /// Creates the document if it does not already exist.
        /// </param>
        /// <param name="updateMask">
        /// The fields to update.
        /// None of the field paths in the mask may contain a reserved name.
        /// 
        /// If the document exists on the server and has fields not referenced in the
        /// mask, they are left unchanged.
        /// Fields referenced in the mask, but not present in the input document, are
        /// deleted from the document on the server.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Document> UpdateDocumentAsync(Document document, DocumentMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDocumentAsync(document, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDocument(DeleteDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDocumentAsync(DeleteDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDocumentAsync(DeleteDocumentRequest request, st::CancellationToken cancellationToken) =>
            DeleteDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a document.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Document to delete. In the format:
        /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDocument(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDocument(new DeleteDocumentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a document.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Document to delete. In the format:
        /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDocumentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDocumentAsync(new DeleteDocumentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a document.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Document to delete. In the format:
        /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDocumentAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDocumentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Server streaming methods for <see cref="BatchGetDocuments(BatchGetDocumentsRequest,gaxgrpc::CallSettings)"/>
        /// .
        /// </summary>
        public abstract partial class BatchGetDocumentsStream : gaxgrpc::ServerStreamingBase<BatchGetDocumentsResponse>
        {
        }

        /// <summary>
        /// Gets multiple documents.
        /// 
        /// Documents returned by this method are not guaranteed to be returned in the
        /// same order that they were requested.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual BatchGetDocumentsStream BatchGetDocuments(BatchGetDocumentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts a new transaction.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BeginTransactionResponse BeginTransaction(BeginTransactionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts a new transaction.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BeginTransactionResponse> BeginTransactionAsync(BeginTransactionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts a new transaction.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BeginTransactionResponse> BeginTransactionAsync(BeginTransactionRequest request, st::CancellationToken cancellationToken) =>
            BeginTransactionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts a new transaction.
        /// </summary>
        /// <param name="database">
        /// Required. The database name. In the format:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BeginTransactionResponse BeginTransaction(string database, gaxgrpc::CallSettings callSettings = null) =>
            BeginTransaction(new BeginTransactionRequest
            {
                Database = gax::GaxPreconditions.CheckNotNullOrEmpty(database, nameof(database)),
            }, callSettings);

        /// <summary>
        /// Starts a new transaction.
        /// </summary>
        /// <param name="database">
        /// Required. The database name. In the format:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BeginTransactionResponse> BeginTransactionAsync(string database, gaxgrpc::CallSettings callSettings = null) =>
            BeginTransactionAsync(new BeginTransactionRequest
            {
                Database = gax::GaxPreconditions.CheckNotNullOrEmpty(database, nameof(database)),
            }, callSettings);

        /// <summary>
        /// Starts a new transaction.
        /// </summary>
        /// <param name="database">
        /// Required. The database name. In the format:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BeginTransactionResponse> BeginTransactionAsync(string database, st::CancellationToken cancellationToken) =>
            BeginTransactionAsync(database, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Commits a transaction, while optionally updating documents.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CommitResponse Commit(CommitRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Commits a transaction, while optionally updating documents.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CommitResponse> CommitAsync(CommitRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Commits a transaction, while optionally updating documents.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CommitResponse> CommitAsync(CommitRequest request, st::CancellationToken cancellationToken) =>
            CommitAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Commits a transaction, while optionally updating documents.
        /// </summary>
        /// <param name="database">
        /// Required. The database name. In the format:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="writes">
        /// The writes to apply.
        /// 
        /// Always executed atomically and in order.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CommitResponse Commit(string database, scg::IEnumerable<gcfv::Write> writes, gaxgrpc::CallSettings callSettings = null) =>
            Commit(new CommitRequest
            {
                Database = gax::GaxPreconditions.CheckNotNullOrEmpty(database, nameof(database)),
                Writes =
                {
                    writes ?? linq::Enumerable.Empty<gcfv::Write>(),
                },
            }, callSettings);

        /// <summary>
        /// Commits a transaction, while optionally updating documents.
        /// </summary>
        /// <param name="database">
        /// Required. The database name. In the format:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="writes">
        /// The writes to apply.
        /// 
        /// Always executed atomically and in order.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CommitResponse> CommitAsync(string database, scg::IEnumerable<gcfv::Write> writes, gaxgrpc::CallSettings callSettings = null) =>
            CommitAsync(new CommitRequest
            {
                Database = gax::GaxPreconditions.CheckNotNullOrEmpty(database, nameof(database)),
                Writes =
                {
                    writes ?? linq::Enumerable.Empty<gcfv::Write>(),
                },
            }, callSettings);

        /// <summary>
        /// Commits a transaction, while optionally updating documents.
        /// </summary>
        /// <param name="database">
        /// Required. The database name. In the format:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="writes">
        /// The writes to apply.
        /// 
        /// Always executed atomically and in order.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CommitResponse> CommitAsync(string database, scg::IEnumerable<gcfv::Write> writes, st::CancellationToken cancellationToken) =>
            CommitAsync(database, writes, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Rolls back a transaction.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void Rollback(RollbackRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Rolls back a transaction.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task RollbackAsync(RollbackRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Rolls back a transaction.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task RollbackAsync(RollbackRequest request, st::CancellationToken cancellationToken) =>
            RollbackAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Rolls back a transaction.
        /// </summary>
        /// <param name="database">
        /// Required. The database name. In the format:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="transaction">
        /// Required. The transaction to roll back.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void Rollback(string database, proto::ByteString transaction, gaxgrpc::CallSettings callSettings = null) =>
            Rollback(new RollbackRequest
            {
                Database = gax::GaxPreconditions.CheckNotNullOrEmpty(database, nameof(database)),
                Transaction = gax::GaxPreconditions.CheckNotNull(transaction, nameof(transaction)),
            }, callSettings);

        /// <summary>
        /// Rolls back a transaction.
        /// </summary>
        /// <param name="database">
        /// Required. The database name. In the format:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="transaction">
        /// Required. The transaction to roll back.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task RollbackAsync(string database, proto::ByteString transaction, gaxgrpc::CallSettings callSettings = null) =>
            RollbackAsync(new RollbackRequest
            {
                Database = gax::GaxPreconditions.CheckNotNullOrEmpty(database, nameof(database)),
                Transaction = gax::GaxPreconditions.CheckNotNull(transaction, nameof(transaction)),
            }, callSettings);

        /// <summary>
        /// Rolls back a transaction.
        /// </summary>
        /// <param name="database">
        /// Required. The database name. In the format:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="transaction">
        /// Required. The transaction to roll back.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task RollbackAsync(string database, proto::ByteString transaction, st::CancellationToken cancellationToken) =>
            RollbackAsync(database, transaction, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Server streaming methods for <see cref="RunQuery(RunQueryRequest,gaxgrpc::CallSettings)"/>.
        /// </summary>
        public abstract partial class RunQueryStream : gaxgrpc::ServerStreamingBase<RunQueryResponse>
        {
        }

        /// <summary>
        /// Runs a query.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual RunQueryStream RunQuery(RunQueryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Server streaming methods for
        /// <see cref="RunAggregationQuery(RunAggregationQueryRequest,gaxgrpc::CallSettings)"/>.
        /// </summary>
        public abstract partial class RunAggregationQueryStream : gaxgrpc::ServerStreamingBase<RunAggregationQueryResponse>
        {
        }

        /// <summary>
        /// Runs an aggregation query.
        /// 
        /// Rather than producing [Document][google.firestore.v1.Document] results like
        /// [Firestore.RunQuery][google.firestore.v1.Firestore.RunQuery], this API
        /// allows running an aggregation to produce a series of
        /// [AggregationResult][google.firestore.v1.AggregationResult] server-side.
        /// 
        /// High-Level Example:
        /// 
        /// ```
        /// -- Return the number of documents in table given a filter.
        /// SELECT COUNT(*) FROM ( SELECT * FROM k where a = true );
        /// ```
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual RunAggregationQueryStream RunAggregationQuery(RunAggregationQueryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Partitions a query by returning partition cursors that can be used to run
        /// the query in parallel. The returned partition cursors are split points that
        /// can be used by RunQuery as starting/end points for the query results.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Cursor"/> resources.</returns>
        public virtual gax::PagedEnumerable<PartitionQueryResponse, Cursor> PartitionQuery(PartitionQueryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Partitions a query by returning partition cursors that can be used to run
        /// the query in parallel. The returned partition cursors are split points that
        /// can be used by RunQuery as starting/end points for the query results.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Cursor"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<PartitionQueryResponse, Cursor> PartitionQueryAsync(PartitionQueryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Bidirectional streaming methods for
        /// <see cref="Write(gaxgrpc::CallSettings,gaxgrpc::BidirectionalStreamingSettings)"/>.
        /// </summary>
        public abstract partial class WriteStream : gaxgrpc::BidirectionalStreamingBase<WriteRequest, WriteResponse>
        {
        }

        /// <summary>
        /// Streams batches of document updates and deletes, in order. This method is
        /// only available via gRPC or WebChannel (not REST).
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public virtual WriteStream Write(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Bidirectional streaming methods for
        /// <see cref="Listen(gaxgrpc::CallSettings,gaxgrpc::BidirectionalStreamingSettings)"/>.
        /// </summary>
        public abstract partial class ListenStream : gaxgrpc::BidirectionalStreamingBase<ListenRequest, ListenResponse>
        {
        }

        /// <summary>
        /// Listens to changes. This method is only available via gRPC or WebChannel
        /// (not REST).
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public virtual ListenStream Listen(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the collection IDs underneath a document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCollectionIdsResponse, string> ListCollectionIds(ListCollectionIdsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the collection IDs underneath a document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCollectionIdsResponse, string> ListCollectionIdsAsync(ListCollectionIdsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the collection IDs underneath a document.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent document. In the format:
        /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`.
        /// For example:
        /// `projects/my-project/databases/my-database/documents/chatrooms/my-chatroom`
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
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCollectionIdsResponse, string> ListCollectionIds(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCollectionIdsRequest request = new ListCollectionIdsRequest
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
            return ListCollectionIds(request, callSettings);
        }

        /// <summary>
        /// Lists all the collection IDs underneath a document.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent document. In the format:
        /// `projects/{project_id}/databases/{database_id}/documents/{document_path}`.
        /// For example:
        /// `projects/my-project/databases/my-database/documents/chatrooms/my-chatroom`
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
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCollectionIdsResponse, string> ListCollectionIdsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCollectionIdsRequest request = new ListCollectionIdsRequest
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
            return ListCollectionIdsAsync(request, callSettings);
        }

        /// <summary>
        /// Applies a batch of write operations.
        /// 
        /// The BatchWrite method does not apply the write operations atomically
        /// and can apply them out of order. Method does not allow more than one write
        /// per document. Each write succeeds or fails independently. See the
        /// [BatchWriteResponse][google.firestore.v1.BatchWriteResponse] for the
        /// success status of each write.
        /// 
        /// If you require an atomically applied set of writes, use
        /// [Commit][google.firestore.v1.Firestore.Commit] instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchWriteResponse BatchWrite(BatchWriteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Applies a batch of write operations.
        /// 
        /// The BatchWrite method does not apply the write operations atomically
        /// and can apply them out of order. Method does not allow more than one write
        /// per document. Each write succeeds or fails independently. See the
        /// [BatchWriteResponse][google.firestore.v1.BatchWriteResponse] for the
        /// success status of each write.
        /// 
        /// If you require an atomically applied set of writes, use
        /// [Commit][google.firestore.v1.Firestore.Commit] instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchWriteResponse> BatchWriteAsync(BatchWriteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Applies a batch of write operations.
        /// 
        /// The BatchWrite method does not apply the write operations atomically
        /// and can apply them out of order. Method does not allow more than one write
        /// per document. Each write succeeds or fails independently. See the
        /// [BatchWriteResponse][google.firestore.v1.BatchWriteResponse] for the
        /// success status of each write.
        /// 
        /// If you require an atomically applied set of writes, use
        /// [Commit][google.firestore.v1.Firestore.Commit] instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchWriteResponse> BatchWriteAsync(BatchWriteRequest request, st::CancellationToken cancellationToken) =>
            BatchWriteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Document CreateDocument(CreateDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Document> CreateDocumentAsync(CreateDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Document> CreateDocumentAsync(CreateDocumentRequest request, st::CancellationToken cancellationToken) =>
            CreateDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Firestore client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The Cloud Firestore service.
    /// 
    /// Cloud Firestore is a fast, fully managed, serverless, cloud-native NoSQL
    /// document database that simplifies storing, syncing, and querying data for
    /// your mobile, web, and IoT apps at global scale. Its client libraries provide
    /// live synchronization and offline support, while its security features and
    /// integrations with Firebase and Google Cloud Platform accelerate building
    /// truly serverless apps.
    /// </remarks>
    public sealed partial class FirestoreClientImpl : FirestoreClient
    {
        private readonly gaxgrpc::ApiCall<GetDocumentRequest, Document> _callGetDocument;

        private readonly gaxgrpc::ApiCall<ListDocumentsRequest, ListDocumentsResponse> _callListDocuments;

        private readonly gaxgrpc::ApiCall<UpdateDocumentRequest, Document> _callUpdateDocument;

        private readonly gaxgrpc::ApiCall<DeleteDocumentRequest, wkt::Empty> _callDeleteDocument;

        private readonly gaxgrpc::ApiServerStreamingCall<BatchGetDocumentsRequest, BatchGetDocumentsResponse> _callBatchGetDocuments;

        private readonly gaxgrpc::ApiCall<BeginTransactionRequest, BeginTransactionResponse> _callBeginTransaction;

        private readonly gaxgrpc::ApiCall<CommitRequest, CommitResponse> _callCommit;

        private readonly gaxgrpc::ApiCall<RollbackRequest, wkt::Empty> _callRollback;

        private readonly gaxgrpc::ApiServerStreamingCall<RunQueryRequest, RunQueryResponse> _callRunQuery;

        private readonly gaxgrpc::ApiServerStreamingCall<RunAggregationQueryRequest, RunAggregationQueryResponse> _callRunAggregationQuery;

        private readonly gaxgrpc::ApiCall<PartitionQueryRequest, PartitionQueryResponse> _callPartitionQuery;

        private readonly gaxgrpc::ApiBidirectionalStreamingCall<WriteRequest, WriteResponse> _callWrite;

        private readonly gaxgrpc::ApiBidirectionalStreamingCall<ListenRequest, ListenResponse> _callListen;

        private readonly gaxgrpc::ApiCall<ListCollectionIdsRequest, ListCollectionIdsResponse> _callListCollectionIds;

        private readonly gaxgrpc::ApiCall<BatchWriteRequest, BatchWriteResponse> _callBatchWrite;

        private readonly gaxgrpc::ApiCall<CreateDocumentRequest, Document> _callCreateDocument;

        /// <summary>
        /// Constructs a client wrapper for the Firestore service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="FirestoreSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public FirestoreClientImpl(Firestore.FirestoreClient grpcClient, FirestoreSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            FirestoreSettings effectiveSettings = settings ?? FirestoreSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callGetDocument = clientHelper.BuildApiCall<GetDocumentRequest, Document>("GetDocument", grpcClient.GetDocumentAsync, grpcClient.GetDocument, effectiveSettings.GetDocumentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDocument);
            Modify_GetDocumentApiCall(ref _callGetDocument);
            _callListDocuments = clientHelper.BuildApiCall<ListDocumentsRequest, ListDocumentsResponse>("ListDocuments", grpcClient.ListDocumentsAsync, grpcClient.ListDocuments, effectiveSettings.ListDocumentsSettings).WithGoogleRequestParam("parent", request => request.Parent).WithGoogleRequestParam("collection_id", request => request.CollectionId);
            Modify_ApiCall(ref _callListDocuments);
            Modify_ListDocumentsApiCall(ref _callListDocuments);
            _callUpdateDocument = clientHelper.BuildApiCall<UpdateDocumentRequest, Document>("UpdateDocument", grpcClient.UpdateDocumentAsync, grpcClient.UpdateDocument, effectiveSettings.UpdateDocumentSettings).WithGoogleRequestParam("document.name", request => request.Document?.Name);
            Modify_ApiCall(ref _callUpdateDocument);
            Modify_UpdateDocumentApiCall(ref _callUpdateDocument);
            _callDeleteDocument = clientHelper.BuildApiCall<DeleteDocumentRequest, wkt::Empty>("DeleteDocument", grpcClient.DeleteDocumentAsync, grpcClient.DeleteDocument, effectiveSettings.DeleteDocumentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDocument);
            Modify_DeleteDocumentApiCall(ref _callDeleteDocument);
            _callBatchGetDocuments = clientHelper.BuildApiCall<BatchGetDocumentsRequest, BatchGetDocumentsResponse>("BatchGetDocuments", grpcClient.BatchGetDocuments, effectiveSettings.BatchGetDocumentsSettings).WithGoogleRequestParam("database", request => request.Database);
            Modify_ApiCall(ref _callBatchGetDocuments);
            Modify_BatchGetDocumentsApiCall(ref _callBatchGetDocuments);
            _callBeginTransaction = clientHelper.BuildApiCall<BeginTransactionRequest, BeginTransactionResponse>("BeginTransaction", grpcClient.BeginTransactionAsync, grpcClient.BeginTransaction, effectiveSettings.BeginTransactionSettings).WithGoogleRequestParam("database", request => request.Database);
            Modify_ApiCall(ref _callBeginTransaction);
            Modify_BeginTransactionApiCall(ref _callBeginTransaction);
            _callCommit = clientHelper.BuildApiCall<CommitRequest, CommitResponse>("Commit", grpcClient.CommitAsync, grpcClient.Commit, effectiveSettings.CommitSettings).WithGoogleRequestParam("database", request => request.Database);
            Modify_ApiCall(ref _callCommit);
            Modify_CommitApiCall(ref _callCommit);
            _callRollback = clientHelper.BuildApiCall<RollbackRequest, wkt::Empty>("Rollback", grpcClient.RollbackAsync, grpcClient.Rollback, effectiveSettings.RollbackSettings).WithGoogleRequestParam("database", request => request.Database);
            Modify_ApiCall(ref _callRollback);
            Modify_RollbackApiCall(ref _callRollback);
            _callRunQuery = clientHelper.BuildApiCall<RunQueryRequest, RunQueryResponse>("RunQuery", grpcClient.RunQuery, effectiveSettings.RunQuerySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callRunQuery);
            Modify_RunQueryApiCall(ref _callRunQuery);
            _callRunAggregationQuery = clientHelper.BuildApiCall<RunAggregationQueryRequest, RunAggregationQueryResponse>("RunAggregationQuery", grpcClient.RunAggregationQuery, effectiveSettings.RunAggregationQuerySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callRunAggregationQuery);
            Modify_RunAggregationQueryApiCall(ref _callRunAggregationQuery);
            _callPartitionQuery = clientHelper.BuildApiCall<PartitionQueryRequest, PartitionQueryResponse>("PartitionQuery", grpcClient.PartitionQueryAsync, grpcClient.PartitionQuery, effectiveSettings.PartitionQuerySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callPartitionQuery);
            Modify_PartitionQueryApiCall(ref _callPartitionQuery);
            _callWrite = clientHelper.BuildApiCall<WriteRequest, WriteResponse>("Write", grpcClient.Write, effectiveSettings.WriteSettings, effectiveSettings.WriteStreamingSettings);
            Modify_ApiCall(ref _callWrite);
            Modify_WriteApiCall(ref _callWrite);
            _callListen = clientHelper.BuildApiCall<ListenRequest, ListenResponse>("Listen", grpcClient.Listen, effectiveSettings.ListenSettings, effectiveSettings.ListenStreamingSettings);
            Modify_ApiCall(ref _callListen);
            Modify_ListenApiCall(ref _callListen);
            _callListCollectionIds = clientHelper.BuildApiCall<ListCollectionIdsRequest, ListCollectionIdsResponse>("ListCollectionIds", grpcClient.ListCollectionIdsAsync, grpcClient.ListCollectionIds, effectiveSettings.ListCollectionIdsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCollectionIds);
            Modify_ListCollectionIdsApiCall(ref _callListCollectionIds);
            _callBatchWrite = clientHelper.BuildApiCall<BatchWriteRequest, BatchWriteResponse>("BatchWrite", grpcClient.BatchWriteAsync, grpcClient.BatchWrite, effectiveSettings.BatchWriteSettings).WithGoogleRequestParam("database", request => request.Database);
            Modify_ApiCall(ref _callBatchWrite);
            Modify_BatchWriteApiCall(ref _callBatchWrite);
            _callCreateDocument = clientHelper.BuildApiCall<CreateDocumentRequest, Document>("CreateDocument", grpcClient.CreateDocumentAsync, grpcClient.CreateDocument, effectiveSettings.CreateDocumentSettings).WithGoogleRequestParam("parent", request => request.Parent).WithGoogleRequestParam("collection_id", request => request.CollectionId);
            Modify_ApiCall(ref _callCreateDocument);
            Modify_CreateDocumentApiCall(ref _callCreateDocument);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiBidirectionalStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiServerStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetDocumentApiCall(ref gaxgrpc::ApiCall<GetDocumentRequest, Document> call);

        partial void Modify_ListDocumentsApiCall(ref gaxgrpc::ApiCall<ListDocumentsRequest, ListDocumentsResponse> call);

        partial void Modify_UpdateDocumentApiCall(ref gaxgrpc::ApiCall<UpdateDocumentRequest, Document> call);

        partial void Modify_DeleteDocumentApiCall(ref gaxgrpc::ApiCall<DeleteDocumentRequest, wkt::Empty> call);

        partial void Modify_BatchGetDocumentsApiCall(ref gaxgrpc::ApiServerStreamingCall<BatchGetDocumentsRequest, BatchGetDocumentsResponse> call);

        partial void Modify_BeginTransactionApiCall(ref gaxgrpc::ApiCall<BeginTransactionRequest, BeginTransactionResponse> call);

        partial void Modify_CommitApiCall(ref gaxgrpc::ApiCall<CommitRequest, CommitResponse> call);

        partial void Modify_RollbackApiCall(ref gaxgrpc::ApiCall<RollbackRequest, wkt::Empty> call);

        partial void Modify_RunQueryApiCall(ref gaxgrpc::ApiServerStreamingCall<RunQueryRequest, RunQueryResponse> call);

        partial void Modify_RunAggregationQueryApiCall(ref gaxgrpc::ApiServerStreamingCall<RunAggregationQueryRequest, RunAggregationQueryResponse> call);

        partial void Modify_PartitionQueryApiCall(ref gaxgrpc::ApiCall<PartitionQueryRequest, PartitionQueryResponse> call);

        partial void Modify_WriteApiCall(ref gaxgrpc::ApiBidirectionalStreamingCall<WriteRequest, WriteResponse> call);

        partial void Modify_ListenApiCall(ref gaxgrpc::ApiBidirectionalStreamingCall<ListenRequest, ListenResponse> call);

        partial void Modify_ListCollectionIdsApiCall(ref gaxgrpc::ApiCall<ListCollectionIdsRequest, ListCollectionIdsResponse> call);

        partial void Modify_BatchWriteApiCall(ref gaxgrpc::ApiCall<BatchWriteRequest, BatchWriteResponse> call);

        partial void Modify_CreateDocumentApiCall(ref gaxgrpc::ApiCall<CreateDocumentRequest, Document> call);

        partial void OnConstruction(Firestore.FirestoreClient grpcClient, FirestoreSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Firestore client</summary>
        public override Firestore.FirestoreClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_GetDocumentRequest(ref GetDocumentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDocumentsRequest(ref ListDocumentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDocumentRequest(ref UpdateDocumentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDocumentRequest(ref DeleteDocumentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchGetDocumentsRequest(ref BatchGetDocumentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BeginTransactionRequest(ref BeginTransactionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CommitRequest(ref CommitRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RollbackRequest(ref RollbackRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RunQueryRequest(ref RunQueryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RunAggregationQueryRequest(ref RunAggregationQueryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PartitionQueryRequest(ref PartitionQueryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_WriteRequestCallSettings(ref gaxgrpc::CallSettings settings);

        partial void Modify_WriteRequestRequest(ref WriteRequest request);

        partial void Modify_ListenRequestCallSettings(ref gaxgrpc::CallSettings settings);

        partial void Modify_ListenRequestRequest(ref ListenRequest request);

        partial void Modify_ListCollectionIdsRequest(ref ListCollectionIdsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchWriteRequest(ref BatchWriteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateDocumentRequest(ref CreateDocumentRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets a single document.
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
        /// Gets a single document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Document> GetDocumentAsync(GetDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDocumentRequest(ref request, ref callSettings);
            return _callGetDocument.Async(request, callSettings);
        }

        /// <summary>
        /// Lists documents.
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
        /// Lists documents.
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
        /// Updates or inserts a document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Document UpdateDocument(UpdateDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDocumentRequest(ref request, ref callSettings);
            return _callUpdateDocument.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates or inserts a document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Document> UpdateDocumentAsync(UpdateDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDocumentRequest(ref request, ref callSettings);
            return _callUpdateDocument.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteDocument(DeleteDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDocumentRequest(ref request, ref callSettings);
            _callDeleteDocument.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteDocumentAsync(DeleteDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDocumentRequest(ref request, ref callSettings);
            return _callDeleteDocument.Async(request, callSettings);
        }

        internal sealed partial class BatchGetDocumentsStreamImpl : BatchGetDocumentsStream
        {
            /// <summary>Construct the server streaming method for <c>BatchGetDocuments</c>.</summary>
            /// <param name="call">The underlying gRPC server streaming call.</param>
            public BatchGetDocumentsStreamImpl(grpccore::AsyncServerStreamingCall<BatchGetDocumentsResponse> call) => GrpcCall = call;

            public override grpccore::AsyncServerStreamingCall<BatchGetDocumentsResponse> GrpcCall { get; }
        }

        /// <summary>
        /// Gets multiple documents.
        /// 
        /// Documents returned by this method are not guaranteed to be returned in the
        /// same order that they were requested.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public override FirestoreClient.BatchGetDocumentsStream BatchGetDocuments(BatchGetDocumentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchGetDocumentsRequest(ref request, ref callSettings);
            return new BatchGetDocumentsStreamImpl(_callBatchGetDocuments.Call(request, callSettings));
        }

        /// <summary>
        /// Starts a new transaction.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BeginTransactionResponse BeginTransaction(BeginTransactionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BeginTransactionRequest(ref request, ref callSettings);
            return _callBeginTransaction.Sync(request, callSettings);
        }

        /// <summary>
        /// Starts a new transaction.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BeginTransactionResponse> BeginTransactionAsync(BeginTransactionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BeginTransactionRequest(ref request, ref callSettings);
            return _callBeginTransaction.Async(request, callSettings);
        }

        /// <summary>
        /// Commits a transaction, while optionally updating documents.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CommitResponse Commit(CommitRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CommitRequest(ref request, ref callSettings);
            return _callCommit.Sync(request, callSettings);
        }

        /// <summary>
        /// Commits a transaction, while optionally updating documents.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CommitResponse> CommitAsync(CommitRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CommitRequest(ref request, ref callSettings);
            return _callCommit.Async(request, callSettings);
        }

        /// <summary>
        /// Rolls back a transaction.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void Rollback(RollbackRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RollbackRequest(ref request, ref callSettings);
            _callRollback.Sync(request, callSettings);
        }

        /// <summary>
        /// Rolls back a transaction.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task RollbackAsync(RollbackRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RollbackRequest(ref request, ref callSettings);
            return _callRollback.Async(request, callSettings);
        }

        internal sealed partial class RunQueryStreamImpl : RunQueryStream
        {
            /// <summary>Construct the server streaming method for <c>RunQuery</c>.</summary>
            /// <param name="call">The underlying gRPC server streaming call.</param>
            public RunQueryStreamImpl(grpccore::AsyncServerStreamingCall<RunQueryResponse> call) => GrpcCall = call;

            public override grpccore::AsyncServerStreamingCall<RunQueryResponse> GrpcCall { get; }
        }

        /// <summary>
        /// Runs a query.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public override FirestoreClient.RunQueryStream RunQuery(RunQueryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunQueryRequest(ref request, ref callSettings);
            return new RunQueryStreamImpl(_callRunQuery.Call(request, callSettings));
        }

        internal sealed partial class RunAggregationQueryStreamImpl : RunAggregationQueryStream
        {
            /// <summary>Construct the server streaming method for <c>RunAggregationQuery</c>.</summary>
            /// <param name="call">The underlying gRPC server streaming call.</param>
            public RunAggregationQueryStreamImpl(grpccore::AsyncServerStreamingCall<RunAggregationQueryResponse> call) => GrpcCall = call;

            public override grpccore::AsyncServerStreamingCall<RunAggregationQueryResponse> GrpcCall { get; }
        }

        /// <summary>
        /// Runs an aggregation query.
        /// 
        /// Rather than producing [Document][google.firestore.v1.Document] results like
        /// [Firestore.RunQuery][google.firestore.v1.Firestore.RunQuery], this API
        /// allows running an aggregation to produce a series of
        /// [AggregationResult][google.firestore.v1.AggregationResult] server-side.
        /// 
        /// High-Level Example:
        /// 
        /// ```
        /// -- Return the number of documents in table given a filter.
        /// SELECT COUNT(*) FROM ( SELECT * FROM k where a = true );
        /// ```
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public override FirestoreClient.RunAggregationQueryStream RunAggregationQuery(RunAggregationQueryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunAggregationQueryRequest(ref request, ref callSettings);
            return new RunAggregationQueryStreamImpl(_callRunAggregationQuery.Call(request, callSettings));
        }

        /// <summary>
        /// Partitions a query by returning partition cursors that can be used to run
        /// the query in parallel. The returned partition cursors are split points that
        /// can be used by RunQuery as starting/end points for the query results.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Cursor"/> resources.</returns>
        public override gax::PagedEnumerable<PartitionQueryResponse, Cursor> PartitionQuery(PartitionQueryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PartitionQueryRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<PartitionQueryRequest, PartitionQueryResponse, Cursor>(_callPartitionQuery, request, callSettings);
        }

        /// <summary>
        /// Partitions a query by returning partition cursors that can be used to run
        /// the query in parallel. The returned partition cursors are split points that
        /// can be used by RunQuery as starting/end points for the query results.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Cursor"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<PartitionQueryResponse, Cursor> PartitionQueryAsync(PartitionQueryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PartitionQueryRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<PartitionQueryRequest, PartitionQueryResponse, Cursor>(_callPartitionQuery, request, callSettings);
        }

        internal sealed partial class WriteStreamImpl : WriteStream
        {
            /// <summary>Construct the bidirectional streaming method for <c>Write</c>.</summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">
            /// The <see cref="gaxgrpc::BufferedClientStreamWriter{WriteRequest}"/> instance associated with this
            /// streaming call.
            /// </param>
            public WriteStreamImpl(FirestoreClientImpl service, grpccore::AsyncDuplexStreamingCall<WriteRequest, WriteResponse> call, gaxgrpc::BufferedClientStreamWriter<WriteRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private FirestoreClientImpl _service;

            private gaxgrpc::BufferedClientStreamWriter<WriteRequest> _writeBuffer;

            public override grpccore::AsyncDuplexStreamingCall<WriteRequest, WriteResponse> GrpcCall { get; }

            private WriteRequest ModifyRequest(WriteRequest request)
            {
                _service.Modify_WriteRequestRequest(ref request);
                return request;
            }

            public override stt::Task TryWriteAsync(WriteRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            public override stt::Task WriteAsync(WriteRequest message) => _writeBuffer.WriteAsync(ModifyRequest(message));

            public override stt::Task TryWriteAsync(WriteRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            public override stt::Task WriteAsync(WriteRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            public override stt::Task TryWriteCompleteAsync() => _writeBuffer.TryWriteCompleteAsync();

            public override stt::Task WriteCompleteAsync() => _writeBuffer.WriteCompleteAsync();
        }

        /// <summary>
        /// Streams batches of document updates and deletes, in order. This method is
        /// only available via gRPC or WebChannel (not REST).
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public override FirestoreClient.WriteStream Write(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_WriteRequestCallSettings(ref callSettings);
            gaxgrpc::BidirectionalStreamingSettings effectiveStreamingSettings = streamingSettings ?? _callWrite.StreamingSettings;
            grpccore::AsyncDuplexStreamingCall<WriteRequest, WriteResponse> call = _callWrite.Call(callSettings);
            gaxgrpc::BufferedClientStreamWriter<WriteRequest> writeBuffer = new gaxgrpc::BufferedClientStreamWriter<WriteRequest>(call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new WriteStreamImpl(this, call, writeBuffer);
        }

        internal sealed partial class ListenStreamImpl : ListenStream
        {
            /// <summary>Construct the bidirectional streaming method for <c>Listen</c>.</summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">
            /// The <see cref="gaxgrpc::BufferedClientStreamWriter{ListenRequest}"/> instance associated with this
            /// streaming call.
            /// </param>
            public ListenStreamImpl(FirestoreClientImpl service, grpccore::AsyncDuplexStreamingCall<ListenRequest, ListenResponse> call, gaxgrpc::BufferedClientStreamWriter<ListenRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private FirestoreClientImpl _service;

            private gaxgrpc::BufferedClientStreamWriter<ListenRequest> _writeBuffer;

            public override grpccore::AsyncDuplexStreamingCall<ListenRequest, ListenResponse> GrpcCall { get; }

            private ListenRequest ModifyRequest(ListenRequest request)
            {
                _service.Modify_ListenRequestRequest(ref request);
                return request;
            }

            public override stt::Task TryWriteAsync(ListenRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            public override stt::Task WriteAsync(ListenRequest message) => _writeBuffer.WriteAsync(ModifyRequest(message));

            public override stt::Task TryWriteAsync(ListenRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            public override stt::Task WriteAsync(ListenRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            public override stt::Task TryWriteCompleteAsync() => _writeBuffer.TryWriteCompleteAsync();

            public override stt::Task WriteCompleteAsync() => _writeBuffer.WriteCompleteAsync();
        }

        /// <summary>
        /// Listens to changes. This method is only available via gRPC or WebChannel
        /// (not REST).
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public override FirestoreClient.ListenStream Listen(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_ListenRequestCallSettings(ref callSettings);
            gaxgrpc::BidirectionalStreamingSettings effectiveStreamingSettings = streamingSettings ?? _callListen.StreamingSettings;
            grpccore::AsyncDuplexStreamingCall<ListenRequest, ListenResponse> call = _callListen.Call(callSettings);
            gaxgrpc::BufferedClientStreamWriter<ListenRequest> writeBuffer = new gaxgrpc::BufferedClientStreamWriter<ListenRequest>(call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new ListenStreamImpl(this, call, writeBuffer);
        }

        /// <summary>
        /// Lists all the collection IDs underneath a document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public override gax::PagedEnumerable<ListCollectionIdsResponse, string> ListCollectionIds(ListCollectionIdsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCollectionIdsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCollectionIdsRequest, ListCollectionIdsResponse, string>(_callListCollectionIds, request, callSettings);
        }

        /// <summary>
        /// Lists all the collection IDs underneath a document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCollectionIdsResponse, string> ListCollectionIdsAsync(ListCollectionIdsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCollectionIdsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCollectionIdsRequest, ListCollectionIdsResponse, string>(_callListCollectionIds, request, callSettings);
        }

        /// <summary>
        /// Applies a batch of write operations.
        /// 
        /// The BatchWrite method does not apply the write operations atomically
        /// and can apply them out of order. Method does not allow more than one write
        /// per document. Each write succeeds or fails independently. See the
        /// [BatchWriteResponse][google.firestore.v1.BatchWriteResponse] for the
        /// success status of each write.
        /// 
        /// If you require an atomically applied set of writes, use
        /// [Commit][google.firestore.v1.Firestore.Commit] instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchWriteResponse BatchWrite(BatchWriteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchWriteRequest(ref request, ref callSettings);
            return _callBatchWrite.Sync(request, callSettings);
        }

        /// <summary>
        /// Applies a batch of write operations.
        /// 
        /// The BatchWrite method does not apply the write operations atomically
        /// and can apply them out of order. Method does not allow more than one write
        /// per document. Each write succeeds or fails independently. See the
        /// [BatchWriteResponse][google.firestore.v1.BatchWriteResponse] for the
        /// success status of each write.
        /// 
        /// If you require an atomically applied set of writes, use
        /// [Commit][google.firestore.v1.Firestore.Commit] instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchWriteResponse> BatchWriteAsync(BatchWriteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchWriteRequest(ref request, ref callSettings);
            return _callBatchWrite.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Document CreateDocument(CreateDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDocumentRequest(ref request, ref callSettings);
            return _callCreateDocument.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Document> CreateDocumentAsync(CreateDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDocumentRequest(ref request, ref callSettings);
            return _callCreateDocument.Async(request, callSettings);
        }
    }

    public partial class ListDocumentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class PartitionQueryRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCollectionIdsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDocumentsResponse : gaxgrpc::IPageResponse<Document>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Document> GetEnumerator() => Documents.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class PartitionQueryResponse : gaxgrpc::IPageResponse<Cursor>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Cursor> GetEnumerator() => Partitions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListCollectionIdsResponse : gaxgrpc::IPageResponse<string>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<string> GetEnumerator() => CollectionIds.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Firestore
    {
        public partial class FirestoreClient
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
