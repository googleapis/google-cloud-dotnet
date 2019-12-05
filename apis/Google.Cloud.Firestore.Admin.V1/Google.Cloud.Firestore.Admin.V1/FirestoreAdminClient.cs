// Copyright 2019 Google LLC
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
using lro = Google.LongRunning;
using pb = Google.Protobuf;
using pbwkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Firestore.Admin.V1
{
    /// <summary>
    /// Settings for a <see cref="FirestoreAdminClient"/>.
    /// </summary>
    public sealed partial class FirestoreAdminSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="FirestoreAdminSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="FirestoreAdminSettings"/>.
        /// </returns>
        public static FirestoreAdminSettings GetDefault() => new FirestoreAdminSettings();

        /// <summary>
        /// Constructs a new <see cref="FirestoreAdminSettings"/> object with default settings.
        /// </summary>
        public FirestoreAdminSettings() { }

        private FirestoreAdminSettings(FirestoreAdminSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateIndexSettings = existing.CreateIndexSettings;
            ListIndexesSettings = existing.ListIndexesSettings;
            GetIndexSettings = existing.GetIndexSettings;
            DeleteIndexSettings = existing.DeleteIndexSettings;
            ImportDocumentsSettings = existing.ImportDocumentsSettings;
            ExportDocumentsSettings = existing.ExportDocumentsSettings;
            GetFieldSettings = existing.GetFieldSettings;
            ListFieldsSettings = existing.ListFieldsSettings;
            UpdateFieldSettings = existing.UpdateFieldSettings;
            OnCopy(existing);
        }

        partial void OnCopy(FirestoreAdminSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="FirestoreAdminClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Internal"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> IdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="FirestoreAdminClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="FirestoreAdminClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="FirestoreAdminClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="FirestoreAdminClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(100),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="FirestoreAdminClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="FirestoreAdminClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="FirestoreAdminClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 60000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(60000),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreAdminClient.CreateIndex</c> and <c>FirestoreAdminClient.CreateIndexAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FirestoreAdminClient.CreateIndex</c> and
        /// <c>FirestoreAdminClient.CreateIndexAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings CreateIndexSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreAdminClient.ListIndexes</c> and <c>FirestoreAdminClient.ListIndexesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FirestoreAdminClient.ListIndexes</c> and
        /// <c>FirestoreAdminClient.ListIndexesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Internal"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListIndexesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreAdminClient.GetIndex</c> and <c>FirestoreAdminClient.GetIndexAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FirestoreAdminClient.GetIndex</c> and
        /// <c>FirestoreAdminClient.GetIndexAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Internal"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetIndexSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreAdminClient.DeleteIndex</c> and <c>FirestoreAdminClient.DeleteIndexAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FirestoreAdminClient.DeleteIndex</c> and
        /// <c>FirestoreAdminClient.DeleteIndexAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Internal"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings DeleteIndexSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreAdminClient.ImportDocuments</c> and <c>FirestoreAdminClient.ImportDocumentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FirestoreAdminClient.ImportDocuments</c> and
        /// <c>FirestoreAdminClient.ImportDocumentsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ImportDocumentsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreAdminClient.ExportDocuments</c> and <c>FirestoreAdminClient.ExportDocumentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FirestoreAdminClient.ExportDocuments</c> and
        /// <c>FirestoreAdminClient.ExportDocumentsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ExportDocumentsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreAdminClient.GetField</c> and <c>FirestoreAdminClient.GetFieldAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FirestoreAdminClient.GetField</c> and
        /// <c>FirestoreAdminClient.GetFieldAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Internal"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetFieldSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreAdminClient.ListFields</c> and <c>FirestoreAdminClient.ListFieldsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FirestoreAdminClient.ListFields</c> and
        /// <c>FirestoreAdminClient.ListFieldsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Internal"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListFieldsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FirestoreAdminClient.UpdateField</c> and <c>FirestoreAdminClient.UpdateFieldAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FirestoreAdminClient.UpdateField</c> and
        /// <c>FirestoreAdminClient.UpdateFieldAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings UpdateFieldSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="FirestoreAdminSettings"/> object.</returns>
        public FirestoreAdminSettings Clone() => new FirestoreAdminSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="FirestoreAdminClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class FirestoreAdminClientBuilder : gaxgrpc::ClientBuilderBase<FirestoreAdminClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public FirestoreAdminSettings Settings { get; set; }

        /// <inheritdoc/>
        public override FirestoreAdminClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return FirestoreAdminClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<FirestoreAdminClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return FirestoreAdminClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => FirestoreAdminClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => FirestoreAdminClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => FirestoreAdminClient.ChannelPool;
    }

    /// <summary>
    /// FirestoreAdmin client wrapper, for convenient use.
    /// </summary>
    public abstract partial class FirestoreAdminClient
    {
        /// <summary>
        /// The default endpoint for the FirestoreAdmin service, which is a host of "firestore.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("firestore.googleapis.com", 443);

        /// <summary>
        /// The default FirestoreAdmin scopes.
        /// </summary>
        /// <remarks>
        /// The default FirestoreAdmin scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/datastore"</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/datastore",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="FirestoreAdminClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Firestore.Admin.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// FirestoreAdminClient client = await FirestoreAdminClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Firestore.Admin.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     FirestoreAdminClient.DefaultEndpoint.Host, FirestoreAdminClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// FirestoreAdminClient client = FirestoreAdminClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="FirestoreAdminSettings"/>.</param>
        /// <returns>The task representing the created <see cref="FirestoreAdminClient"/>.</returns>
        public static async stt::Task<FirestoreAdminClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, FirestoreAdminSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="FirestoreAdminClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Firestore.Admin.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// FirestoreAdminClient client = FirestoreAdminClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Firestore.Admin.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     FirestoreAdminClient.DefaultEndpoint.Host, FirestoreAdminClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// FirestoreAdminClient client = FirestoreAdminClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="FirestoreAdminSettings"/>.</param>
        /// <returns>The created <see cref="FirestoreAdminClient"/>.</returns>
        public static FirestoreAdminClient Create(gaxgrpc::ServiceEndpoint endpoint = null, FirestoreAdminSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="FirestoreAdminClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="FirestoreAdminSettings"/>.</param>
        /// <returns>The created <see cref="FirestoreAdminClient"/>.</returns>
        public static FirestoreAdminClient Create(grpccore::Channel channel, FirestoreAdminSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="FirestoreAdminClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="FirestoreAdminSettings"/>.</param>
        /// <returns>The created <see cref="FirestoreAdminClient"/>.</returns>
        public static FirestoreAdminClient Create(grpccore::CallInvoker callInvoker, FirestoreAdminSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            FirestoreAdmin.FirestoreAdminClient grpcClient = new FirestoreAdmin.FirestoreAdminClient(callInvoker);
            return new FirestoreAdminClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, FirestoreAdminSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, FirestoreAdminSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, FirestoreAdminSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, FirestoreAdminSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC FirestoreAdmin client.
        /// </summary>
        public virtual FirestoreAdmin.FirestoreAdminClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

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
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation> CreateIndexAsync(
            ParentName parent,
            Index index,
            gaxgrpc::CallSettings callSettings = null) => CreateIndexAsync(
                new CreateIndexRequest
                {
                    ParentAsParentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Index = gax::GaxPreconditions.CheckNotNull(index, nameof(index)),
                },
                callSettings);

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
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation> CreateIndexAsync(
            ParentName parent,
            Index index,
            st::CancellationToken cancellationToken) => CreateIndexAsync(
                parent,
                index,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation CreateIndex(
            ParentName parent,
            Index index,
            gaxgrpc::CallSettings callSettings = null) => CreateIndex(
                new CreateIndexRequest
                {
                    ParentAsParentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Index = gax::GaxPreconditions.CheckNotNull(index, nameof(index)),
                },
                callSettings);

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
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation> CreateIndexAsync(
            string parent,
            Index index,
            gaxgrpc::CallSettings callSettings = null) => CreateIndexAsync(
                new CreateIndexRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Index = gax::GaxPreconditions.CheckNotNull(index, nameof(index)),
                },
                callSettings);

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
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation> CreateIndexAsync(
            string parent,
            Index index,
            st::CancellationToken cancellationToken) => CreateIndexAsync(
                parent,
                index,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation CreateIndex(
            string parent,
            Index index,
            gaxgrpc::CallSettings callSettings = null) => CreateIndex(
                new CreateIndexRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Index = gax::GaxPreconditions.CheckNotNull(index, nameof(index)),
                },
                callSettings);

        /// <summary>
        /// Creates a composite index. This returns a [google.longrunning.Operation][google.longrunning.Operation]
        /// which may be used to track the status of the creation. The metadata for
        /// the operation will be the type [IndexOperationMetadata][google.firestore.admin.v1.IndexOperationMetadata].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation> CreateIndexAsync(
            CreateIndexRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a composite index. This returns a [google.longrunning.Operation][google.longrunning.Operation]
        /// which may be used to track the status of the creation. The metadata for
        /// the operation will be the type [IndexOperationMetadata][google.firestore.admin.v1.IndexOperationMetadata].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation> CreateIndexAsync(
            CreateIndexRequest request,
            st::CancellationToken cancellationToken) => CreateIndexAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a composite index. This returns a [google.longrunning.Operation][google.longrunning.Operation]
        /// which may be used to track the status of the creation. The metadata for
        /// the operation will be the type [IndexOperationMetadata][google.firestore.admin.v1.IndexOperationMetadata].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation CreateIndex(
            CreateIndexRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists composite indexes.
        /// </summary>
        /// <param name="parent">
        /// Required. A parent name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Index"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListIndexesResponse, Index> ListIndexesAsync(
            ParentName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListIndexesAsync(
                new ListIndexesRequest
                {
                    ParentAsParentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists composite indexes.
        /// </summary>
        /// <param name="parent">
        /// Required. A parent name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Index"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListIndexesResponse, Index> ListIndexes(
            ParentName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListIndexes(
                new ListIndexesRequest
                {
                    ParentAsParentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists composite indexes.
        /// </summary>
        /// <param name="parent">
        /// Required. A parent name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Index"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListIndexesResponse, Index> ListIndexesAsync(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListIndexesAsync(
                new ListIndexesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists composite indexes.
        /// </summary>
        /// <param name="parent">
        /// Required. A parent name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Index"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListIndexesResponse, Index> ListIndexes(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListIndexes(
                new ListIndexesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists composite indexes.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Index"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListIndexesResponse, Index> ListIndexesAsync(
            ListIndexesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists composite indexes.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Index"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListIndexesResponse, Index> ListIndexes(
            ListIndexesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets a composite index.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/indexes/{index_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Index> GetIndexAsync(
            IndexName name,
            gaxgrpc::CallSettings callSettings = null) => GetIndexAsync(
                new GetIndexRequest
                {
                    IndexName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a composite index.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/indexes/{index_id}`
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Index> GetIndexAsync(
            IndexName name,
            st::CancellationToken cancellationToken) => GetIndexAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a composite index.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/indexes/{index_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Index GetIndex(
            IndexName name,
            gaxgrpc::CallSettings callSettings = null) => GetIndex(
                new GetIndexRequest
                {
                    IndexName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a composite index.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/indexes/{index_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Index> GetIndexAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetIndexAsync(
                new GetIndexRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a composite index.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/indexes/{index_id}`
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Index> GetIndexAsync(
            string name,
            st::CancellationToken cancellationToken) => GetIndexAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a composite index.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/indexes/{index_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Index GetIndex(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetIndex(
                new GetIndexRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a composite index.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Index> GetIndexAsync(
            GetIndexRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets a composite index.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Index> GetIndexAsync(
            GetIndexRequest request,
            st::CancellationToken cancellationToken) => GetIndexAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a composite index.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Index GetIndex(
            GetIndexRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes a composite index.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/indexes/{index_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteIndexAsync(
            IndexName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteIndexAsync(
                new DeleteIndexRequest
                {
                    IndexName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes a composite index.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/indexes/{index_id}`
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteIndexAsync(
            IndexName name,
            st::CancellationToken cancellationToken) => DeleteIndexAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a composite index.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/indexes/{index_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteIndex(
            IndexName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteIndex(
                new DeleteIndexRequest
                {
                    IndexName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes a composite index.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/indexes/{index_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteIndexAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteIndexAsync(
                new DeleteIndexRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes a composite index.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/indexes/{index_id}`
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteIndexAsync(
            string name,
            st::CancellationToken cancellationToken) => DeleteIndexAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a composite index.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/indexes/{index_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteIndex(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteIndex(
                new DeleteIndexRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes a composite index.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteIndexAsync(
            DeleteIndexRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes a composite index.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteIndexAsync(
            DeleteIndexRequest request,
            st::CancellationToken cancellationToken) => DeleteIndexAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a composite index.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteIndex(
            DeleteIndexRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

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
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation> ImportDocumentsAsync(
            DatabaseName name,
            gaxgrpc::CallSettings callSettings = null) => ImportDocumentsAsync(
                new ImportDocumentsRequest
                {
                    DatabaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

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
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation> ImportDocumentsAsync(
            DatabaseName name,
            st::CancellationToken cancellationToken) => ImportDocumentsAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation ImportDocuments(
            DatabaseName name,
            gaxgrpc::CallSettings callSettings = null) => ImportDocuments(
                new ImportDocumentsRequest
                {
                    DatabaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

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
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation> ImportDocumentsAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => ImportDocumentsAsync(
                new ImportDocumentsRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

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
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation> ImportDocumentsAsync(
            string name,
            st::CancellationToken cancellationToken) => ImportDocumentsAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation ImportDocuments(
            string name,
            gaxgrpc::CallSettings callSettings = null) => ImportDocuments(
                new ImportDocumentsRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Imports documents into Google Cloud Firestore. Existing documents with the
        /// same name are overwritten. The import occurs in the background and its
        /// progress can be monitored and managed via the Operation resource that is
        /// created. If an ImportDocuments operation is cancelled, it is possible
        /// that a subset of the data has already been imported to Cloud Firestore.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation> ImportDocumentsAsync(
            ImportDocumentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Imports documents into Google Cloud Firestore. Existing documents with the
        /// same name are overwritten. The import occurs in the background and its
        /// progress can be monitored and managed via the Operation resource that is
        /// created. If an ImportDocuments operation is cancelled, it is possible
        /// that a subset of the data has already been imported to Cloud Firestore.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation> ImportDocumentsAsync(
            ImportDocumentsRequest request,
            st::CancellationToken cancellationToken) => ImportDocumentsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports documents into Google Cloud Firestore. Existing documents with the
        /// same name are overwritten. The import occurs in the background and its
        /// progress can be monitored and managed via the Operation resource that is
        /// created. If an ImportDocuments operation is cancelled, it is possible
        /// that a subset of the data has already been imported to Cloud Firestore.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation ImportDocuments(
            ImportDocumentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        /// </summary>
        /// <param name="name">
        /// Required. Database to export. Should be of the form:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation> ExportDocumentsAsync(
            DatabaseName name,
            gaxgrpc::CallSettings callSettings = null) => ExportDocumentsAsync(
                new ExportDocumentsRequest
                {
                    DatabaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Exports a copy of all or a subset of documents from Google Cloud Firestore
        /// to another storage system, such as Google Cloud Storage. Recent updates to
        /// documents may not be reflected in the export. The export occurs in the
        /// background and its progress can be monitored and managed via the
        /// Operation resource that is created. The output of an export may only be
        /// used once the associated operation is done. If an export operation is
        /// cancelled before completion it may leave partial data behind in Google
        /// Cloud Storage.
        /// </summary>
        /// <param name="name">
        /// Required. Database to export. Should be of the form:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation> ExportDocumentsAsync(
            DatabaseName name,
            st::CancellationToken cancellationToken) => ExportDocumentsAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports a copy of all or a subset of documents from Google Cloud Firestore
        /// to another storage system, such as Google Cloud Storage. Recent updates to
        /// documents may not be reflected in the export. The export occurs in the
        /// background and its progress can be monitored and managed via the
        /// Operation resource that is created. The output of an export may only be
        /// used once the associated operation is done. If an export operation is
        /// cancelled before completion it may leave partial data behind in Google
        /// Cloud Storage.
        /// </summary>
        /// <param name="name">
        /// Required. Database to export. Should be of the form:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation ExportDocuments(
            DatabaseName name,
            gaxgrpc::CallSettings callSettings = null) => ExportDocuments(
                new ExportDocumentsRequest
                {
                    DatabaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Exports a copy of all or a subset of documents from Google Cloud Firestore
        /// to another storage system, such as Google Cloud Storage. Recent updates to
        /// documents may not be reflected in the export. The export occurs in the
        /// background and its progress can be monitored and managed via the
        /// Operation resource that is created. The output of an export may only be
        /// used once the associated operation is done. If an export operation is
        /// cancelled before completion it may leave partial data behind in Google
        /// Cloud Storage.
        /// </summary>
        /// <param name="name">
        /// Required. Database to export. Should be of the form:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation> ExportDocumentsAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => ExportDocumentsAsync(
                new ExportDocumentsRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Exports a copy of all or a subset of documents from Google Cloud Firestore
        /// to another storage system, such as Google Cloud Storage. Recent updates to
        /// documents may not be reflected in the export. The export occurs in the
        /// background and its progress can be monitored and managed via the
        /// Operation resource that is created. The output of an export may only be
        /// used once the associated operation is done. If an export operation is
        /// cancelled before completion it may leave partial data behind in Google
        /// Cloud Storage.
        /// </summary>
        /// <param name="name">
        /// Required. Database to export. Should be of the form:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation> ExportDocumentsAsync(
            string name,
            st::CancellationToken cancellationToken) => ExportDocumentsAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports a copy of all or a subset of documents from Google Cloud Firestore
        /// to another storage system, such as Google Cloud Storage. Recent updates to
        /// documents may not be reflected in the export. The export occurs in the
        /// background and its progress can be monitored and managed via the
        /// Operation resource that is created. The output of an export may only be
        /// used once the associated operation is done. If an export operation is
        /// cancelled before completion it may leave partial data behind in Google
        /// Cloud Storage.
        /// </summary>
        /// <param name="name">
        /// Required. Database to export. Should be of the form:
        /// `projects/{project_id}/databases/{database_id}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation ExportDocuments(
            string name,
            gaxgrpc::CallSettings callSettings = null) => ExportDocuments(
                new ExportDocumentsRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Exports a copy of all or a subset of documents from Google Cloud Firestore
        /// to another storage system, such as Google Cloud Storage. Recent updates to
        /// documents may not be reflected in the export. The export occurs in the
        /// background and its progress can be monitored and managed via the
        /// Operation resource that is created. The output of an export may only be
        /// used once the associated operation is done. If an export operation is
        /// cancelled before completion it may leave partial data behind in Google
        /// Cloud Storage.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation> ExportDocumentsAsync(
            ExportDocumentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation> ExportDocumentsAsync(
            ExportDocumentsRequest request,
            st::CancellationToken cancellationToken) => ExportDocumentsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports a copy of all or a subset of documents from Google Cloud Firestore
        /// to another storage system, such as Google Cloud Storage. Recent updates to
        /// documents may not be reflected in the export. The export occurs in the
        /// background and its progress can be monitored and managed via the
        /// Operation resource that is created. The output of an export may only be
        /// used once the associated operation is done. If an export operation is
        /// cancelled before completion it may leave partial data behind in Google
        /// Cloud Storage.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation ExportDocuments(
            ExportDocumentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets the metadata and configuration for a Field.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/fields/{field_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Field> GetFieldAsync(
            FieldName name,
            gaxgrpc::CallSettings callSettings = null) => GetFieldAsync(
                new GetFieldRequest
                {
                    FieldName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the metadata and configuration for a Field.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/fields/{field_id}`
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Field> GetFieldAsync(
            FieldName name,
            st::CancellationToken cancellationToken) => GetFieldAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the metadata and configuration for a Field.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/fields/{field_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Field GetField(
            FieldName name,
            gaxgrpc::CallSettings callSettings = null) => GetField(
                new GetFieldRequest
                {
                    FieldName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the metadata and configuration for a Field.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/fields/{field_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Field> GetFieldAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetFieldAsync(
                new GetFieldRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the metadata and configuration for a Field.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/fields/{field_id}`
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Field> GetFieldAsync(
            string name,
            st::CancellationToken cancellationToken) => GetFieldAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the metadata and configuration for a Field.
        /// </summary>
        /// <param name="name">
        /// Required. A name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}/fields/{field_id}`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Field GetField(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetField(
                new GetFieldRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the metadata and configuration for a Field.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Field> GetFieldAsync(
            GetFieldRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets the metadata and configuration for a Field.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Field> GetFieldAsync(
            GetFieldRequest request,
            st::CancellationToken cancellationToken) => GetFieldAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the metadata and configuration for a Field.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Field GetField(
            GetFieldRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists the field configuration and metadata for this database.
        ///
        /// Currently, [FirestoreAdmin.ListFields][google.firestore.admin.v1.FirestoreAdmin.ListFields] only supports listing fields
        /// that have been explicitly overridden. To issue this query, call
        /// [FirestoreAdmin.ListFields][google.firestore.admin.v1.FirestoreAdmin.ListFields] with the filter set to
        /// `indexConfig.usesAncestorConfig:false`.
        /// </summary>
        /// <param name="parent">
        /// Required. A parent name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Field"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListFieldsResponse, Field> ListFieldsAsync(
            ParentName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListFieldsAsync(
                new ListFieldsRequest
                {
                    ParentAsParentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the field configuration and metadata for this database.
        ///
        /// Currently, [FirestoreAdmin.ListFields][google.firestore.admin.v1.FirestoreAdmin.ListFields] only supports listing fields
        /// that have been explicitly overridden. To issue this query, call
        /// [FirestoreAdmin.ListFields][google.firestore.admin.v1.FirestoreAdmin.ListFields] with the filter set to
        /// `indexConfig.usesAncestorConfig:false`.
        /// </summary>
        /// <param name="parent">
        /// Required. A parent name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Field"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListFieldsResponse, Field> ListFields(
            ParentName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListFields(
                new ListFieldsRequest
                {
                    ParentAsParentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the field configuration and metadata for this database.
        ///
        /// Currently, [FirestoreAdmin.ListFields][google.firestore.admin.v1.FirestoreAdmin.ListFields] only supports listing fields
        /// that have been explicitly overridden. To issue this query, call
        /// [FirestoreAdmin.ListFields][google.firestore.admin.v1.FirestoreAdmin.ListFields] with the filter set to
        /// `indexConfig.usesAncestorConfig:false`.
        /// </summary>
        /// <param name="parent">
        /// Required. A parent name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Field"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListFieldsResponse, Field> ListFieldsAsync(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListFieldsAsync(
                new ListFieldsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the field configuration and metadata for this database.
        ///
        /// Currently, [FirestoreAdmin.ListFields][google.firestore.admin.v1.FirestoreAdmin.ListFields] only supports listing fields
        /// that have been explicitly overridden. To issue this query, call
        /// [FirestoreAdmin.ListFields][google.firestore.admin.v1.FirestoreAdmin.ListFields] with the filter set to
        /// `indexConfig.usesAncestorConfig:false`.
        /// </summary>
        /// <param name="parent">
        /// Required. A parent name of the form
        /// `projects/{project_id}/databases/{database_id}/collectionGroups/{collection_id}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Field"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListFieldsResponse, Field> ListFields(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListFields(
                new ListFieldsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the field configuration and metadata for this database.
        ///
        /// Currently, [FirestoreAdmin.ListFields][google.firestore.admin.v1.FirestoreAdmin.ListFields] only supports listing fields
        /// that have been explicitly overridden. To issue this query, call
        /// [FirestoreAdmin.ListFields][google.firestore.admin.v1.FirestoreAdmin.ListFields] with the filter set to
        /// `indexConfig.usesAncestorConfig:false`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Field"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListFieldsResponse, Field> ListFieldsAsync(
            ListFieldsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists the field configuration and metadata for this database.
        ///
        /// Currently, [FirestoreAdmin.ListFields][google.firestore.admin.v1.FirestoreAdmin.ListFields] only supports listing fields
        /// that have been explicitly overridden. To issue this query, call
        /// [FirestoreAdmin.ListFields][google.firestore.admin.v1.FirestoreAdmin.ListFields] with the filter set to
        /// `indexConfig.usesAncestorConfig:false`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Field"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListFieldsResponse, Field> ListFields(
            ListFieldsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        /// <param name="field">
        /// Required. The field to be updated.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation> UpdateFieldAsync(
            Field field,
            gaxgrpc::CallSettings callSettings = null) => UpdateFieldAsync(
                new UpdateFieldRequest
                {
                    Field = gax::GaxPreconditions.CheckNotNull(field, nameof(field)),
                },
                callSettings);

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
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation> UpdateFieldAsync(
            Field field,
            st::CancellationToken cancellationToken) => UpdateFieldAsync(
                field,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation UpdateField(
            Field field,
            gaxgrpc::CallSettings callSettings = null) => UpdateField(
                new UpdateFieldRequest
                {
                    Field = gax::GaxPreconditions.CheckNotNull(field, nameof(field)),
                },
                callSettings);

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
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation> UpdateFieldAsync(
            UpdateFieldRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation> UpdateFieldAsync(
            UpdateFieldRequest request,
            st::CancellationToken cancellationToken) => UpdateFieldAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation UpdateField(
            UpdateFieldRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// FirestoreAdmin client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class FirestoreAdminClientImpl : FirestoreAdminClient
    {
        private readonly gaxgrpc::ApiCall<CreateIndexRequest, lro::Operation> _callCreateIndex;
        private readonly gaxgrpc::ApiCall<ListIndexesRequest, ListIndexesResponse> _callListIndexes;
        private readonly gaxgrpc::ApiCall<GetIndexRequest, Index> _callGetIndex;
        private readonly gaxgrpc::ApiCall<DeleteIndexRequest, pbwkt::Empty> _callDeleteIndex;
        private readonly gaxgrpc::ApiCall<ImportDocumentsRequest, lro::Operation> _callImportDocuments;
        private readonly gaxgrpc::ApiCall<ExportDocumentsRequest, lro::Operation> _callExportDocuments;
        private readonly gaxgrpc::ApiCall<GetFieldRequest, Field> _callGetField;
        private readonly gaxgrpc::ApiCall<ListFieldsRequest, ListFieldsResponse> _callListFields;
        private readonly gaxgrpc::ApiCall<UpdateFieldRequest, lro::Operation> _callUpdateField;

        /// <summary>
        /// Constructs a client wrapper for the FirestoreAdmin service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="FirestoreAdminSettings"/> used within this client </param>
        public FirestoreAdminClientImpl(FirestoreAdmin.FirestoreAdminClient grpcClient, FirestoreAdminSettings settings)
        {
            GrpcClient = grpcClient;
            FirestoreAdminSettings effectiveSettings = settings ?? FirestoreAdminSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callCreateIndex = clientHelper.BuildApiCall<CreateIndexRequest, lro::Operation>(
                GrpcClient.CreateIndexAsync, GrpcClient.CreateIndex, effectiveSettings.CreateIndexSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callListIndexes = clientHelper.BuildApiCall<ListIndexesRequest, ListIndexesResponse>(
                GrpcClient.ListIndexesAsync, GrpcClient.ListIndexes, effectiveSettings.ListIndexesSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callGetIndex = clientHelper.BuildApiCall<GetIndexRequest, Index>(
                GrpcClient.GetIndexAsync, GrpcClient.GetIndex, effectiveSettings.GetIndexSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callDeleteIndex = clientHelper.BuildApiCall<DeleteIndexRequest, pbwkt::Empty>(
                GrpcClient.DeleteIndexAsync, GrpcClient.DeleteIndex, effectiveSettings.DeleteIndexSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callImportDocuments = clientHelper.BuildApiCall<ImportDocumentsRequest, lro::Operation>(
                GrpcClient.ImportDocumentsAsync, GrpcClient.ImportDocuments, effectiveSettings.ImportDocumentsSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callExportDocuments = clientHelper.BuildApiCall<ExportDocumentsRequest, lro::Operation>(
                GrpcClient.ExportDocumentsAsync, GrpcClient.ExportDocuments, effectiveSettings.ExportDocumentsSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callGetField = clientHelper.BuildApiCall<GetFieldRequest, Field>(
                GrpcClient.GetFieldAsync, GrpcClient.GetField, effectiveSettings.GetFieldSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callListFields = clientHelper.BuildApiCall<ListFieldsRequest, ListFieldsResponse>(
                GrpcClient.ListFieldsAsync, GrpcClient.ListFields, effectiveSettings.ListFieldsSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callUpdateField = clientHelper.BuildApiCall<UpdateFieldRequest, lro::Operation>(
                GrpcClient.UpdateFieldAsync, GrpcClient.UpdateField, effectiveSettings.UpdateFieldSettings)
                .WithGoogleRequestParam("field.name", request => request.Field?.Name);
            Modify_ApiCall(ref _callCreateIndex);
            Modify_CreateIndexApiCall(ref _callCreateIndex);
            Modify_ApiCall(ref _callListIndexes);
            Modify_ListIndexesApiCall(ref _callListIndexes);
            Modify_ApiCall(ref _callGetIndex);
            Modify_GetIndexApiCall(ref _callGetIndex);
            Modify_ApiCall(ref _callDeleteIndex);
            Modify_DeleteIndexApiCall(ref _callDeleteIndex);
            Modify_ApiCall(ref _callImportDocuments);
            Modify_ImportDocumentsApiCall(ref _callImportDocuments);
            Modify_ApiCall(ref _callExportDocuments);
            Modify_ExportDocumentsApiCall(ref _callExportDocuments);
            Modify_ApiCall(ref _callGetField);
            Modify_GetFieldApiCall(ref _callGetField);
            Modify_ApiCall(ref _callListFields);
            Modify_ListFieldsApiCall(ref _callListFields);
            Modify_ApiCall(ref _callUpdateField);
            Modify_UpdateFieldApiCall(ref _callUpdateField);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        // Partial methods are named to (mostly) ensure there cannot be conflicts with RPC method names.

        // Partial methods called for every ApiCall on construction.
        // Allows modification of all the underlying ApiCall objects.
        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call)
            where TRequest : class, pb::IMessage<TRequest>
            where TResponse : class, pb::IMessage<TResponse>;

        // Partial methods called for each ApiCall on construction.
        // Allows per-RPC-method modification of the underlying ApiCall object.
        partial void Modify_CreateIndexApiCall(ref gaxgrpc::ApiCall<CreateIndexRequest, lro::Operation> call);
        partial void Modify_ListIndexesApiCall(ref gaxgrpc::ApiCall<ListIndexesRequest, ListIndexesResponse> call);
        partial void Modify_GetIndexApiCall(ref gaxgrpc::ApiCall<GetIndexRequest, Index> call);
        partial void Modify_DeleteIndexApiCall(ref gaxgrpc::ApiCall<DeleteIndexRequest, pbwkt::Empty> call);
        partial void Modify_ImportDocumentsApiCall(ref gaxgrpc::ApiCall<ImportDocumentsRequest, lro::Operation> call);
        partial void Modify_ExportDocumentsApiCall(ref gaxgrpc::ApiCall<ExportDocumentsRequest, lro::Operation> call);
        partial void Modify_GetFieldApiCall(ref gaxgrpc::ApiCall<GetFieldRequest, Field> call);
        partial void Modify_ListFieldsApiCall(ref gaxgrpc::ApiCall<ListFieldsRequest, ListFieldsResponse> call);
        partial void Modify_UpdateFieldApiCall(ref gaxgrpc::ApiCall<UpdateFieldRequest, lro::Operation> call);
        partial void OnConstruction(FirestoreAdmin.FirestoreAdminClient grpcClient, FirestoreAdminSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC FirestoreAdmin client.
        /// </summary>
        public override FirestoreAdmin.FirestoreAdminClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_CreateIndexRequest(ref CreateIndexRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListIndexesRequest(ref ListIndexesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetIndexRequest(ref GetIndexRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteIndexRequest(ref DeleteIndexRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ImportDocumentsRequest(ref ImportDocumentsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ExportDocumentsRequest(ref ExportDocumentsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetFieldRequest(ref GetFieldRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListFieldsRequest(ref ListFieldsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateFieldRequest(ref UpdateFieldRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a composite index. This returns a [google.longrunning.Operation][google.longrunning.Operation]
        /// which may be used to track the status of the creation. The metadata for
        /// the operation will be the type [IndexOperationMetadata][google.firestore.admin.v1.IndexOperationMetadata].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<lro::Operation> CreateIndexAsync(
            CreateIndexRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateIndexRequest(ref request, ref callSettings);
            return _callCreateIndex.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a composite index. This returns a [google.longrunning.Operation][google.longrunning.Operation]
        /// which may be used to track the status of the creation. The metadata for
        /// the operation will be the type [IndexOperationMetadata][google.firestore.admin.v1.IndexOperationMetadata].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override lro::Operation CreateIndex(
            CreateIndexRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateIndexRequest(ref request, ref callSettings);
            return _callCreateIndex.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists composite indexes.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Index"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListIndexesResponse, Index> ListIndexesAsync(
            ListIndexesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListIndexesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListIndexesRequest, ListIndexesResponse, Index>(_callListIndexes, request, callSettings);
        }

        /// <summary>
        /// Lists composite indexes.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Index"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListIndexesResponse, Index> ListIndexes(
            ListIndexesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListIndexesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListIndexesRequest, ListIndexesResponse, Index>(_callListIndexes, request, callSettings);
        }

        /// <summary>
        /// Gets a composite index.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<Index> GetIndexAsync(
            GetIndexRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIndexRequest(ref request, ref callSettings);
            return _callGetIndex.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a composite index.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override Index GetIndex(
            GetIndexRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIndexRequest(ref request, ref callSettings);
            return _callGetIndex.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a composite index.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public override stt::Task DeleteIndexAsync(
            DeleteIndexRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteIndexRequest(ref request, ref callSettings);
            return _callDeleteIndex.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a composite index.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteIndex(
            DeleteIndexRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteIndexRequest(ref request, ref callSettings);
            _callDeleteIndex.Sync(request, callSettings);
        }

        /// <summary>
        /// Imports documents into Google Cloud Firestore. Existing documents with the
        /// same name are overwritten. The import occurs in the background and its
        /// progress can be monitored and managed via the Operation resource that is
        /// created. If an ImportDocuments operation is cancelled, it is possible
        /// that a subset of the data has already been imported to Cloud Firestore.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<lro::Operation> ImportDocumentsAsync(
            ImportDocumentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportDocumentsRequest(ref request, ref callSettings);
            return _callImportDocuments.Async(request, callSettings);
        }

        /// <summary>
        /// Imports documents into Google Cloud Firestore. Existing documents with the
        /// same name are overwritten. The import occurs in the background and its
        /// progress can be monitored and managed via the Operation resource that is
        /// created. If an ImportDocuments operation is cancelled, it is possible
        /// that a subset of the data has already been imported to Cloud Firestore.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override lro::Operation ImportDocuments(
            ImportDocumentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportDocumentsRequest(ref request, ref callSettings);
            return _callImportDocuments.Sync(request, callSettings);
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
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<lro::Operation> ExportDocumentsAsync(
            ExportDocumentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportDocumentsRequest(ref request, ref callSettings);
            return _callExportDocuments.Async(request, callSettings);
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
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override lro::Operation ExportDocuments(
            ExportDocumentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportDocumentsRequest(ref request, ref callSettings);
            return _callExportDocuments.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the metadata and configuration for a Field.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<Field> GetFieldAsync(
            GetFieldRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFieldRequest(ref request, ref callSettings);
            return _callGetField.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the metadata and configuration for a Field.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override Field GetField(
            GetFieldRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFieldRequest(ref request, ref callSettings);
            return _callGetField.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists the field configuration and metadata for this database.
        ///
        /// Currently, [FirestoreAdmin.ListFields][google.firestore.admin.v1.FirestoreAdmin.ListFields] only supports listing fields
        /// that have been explicitly overridden. To issue this query, call
        /// [FirestoreAdmin.ListFields][google.firestore.admin.v1.FirestoreAdmin.ListFields] with the filter set to
        /// `indexConfig.usesAncestorConfig:false`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Field"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListFieldsResponse, Field> ListFieldsAsync(
            ListFieldsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFieldsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListFieldsRequest, ListFieldsResponse, Field>(_callListFields, request, callSettings);
        }

        /// <summary>
        /// Lists the field configuration and metadata for this database.
        ///
        /// Currently, [FirestoreAdmin.ListFields][google.firestore.admin.v1.FirestoreAdmin.ListFields] only supports listing fields
        /// that have been explicitly overridden. To issue this query, call
        /// [FirestoreAdmin.ListFields][google.firestore.admin.v1.FirestoreAdmin.ListFields] with the filter set to
        /// `indexConfig.usesAncestorConfig:false`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Field"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListFieldsResponse, Field> ListFields(
            ListFieldsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFieldsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListFieldsRequest, ListFieldsResponse, Field>(_callListFields, request, callSettings);
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
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<lro::Operation> UpdateFieldAsync(
            UpdateFieldRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFieldRequest(ref request, ref callSettings);
            return _callUpdateField.Async(request, callSettings);
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
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override lro::Operation UpdateField(
            UpdateFieldRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFieldRequest(ref request, ref callSettings);
            return _callUpdateField.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListIndexesRequest : gaxgrpc::IPageRequest { }
    public partial class ListIndexesResponse : gaxgrpc::IPageResponse<Index>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<Index> GetEnumerator() => Indexes.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListFieldsRequest : gaxgrpc::IPageRequest { }
    public partial class ListFieldsResponse : gaxgrpc::IPageResponse<Field>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<Field> GetEnumerator() => Fields.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
